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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7023190", Offset = "0x7022190", VA = "0x187023190")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87C700", Offset = "0x87B700", VA = "0x18087C700")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x87C740", Offset = "0x87B740", VA = "0x18087C740")]
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
	public class LogRegistrationIndex : AGBKNAFJGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x701F190", Offset = "0x701E190", VA = "0x18701F190", Slot = "4")]
		public override void GGLLICMBJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NPFFJJKBOID : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7023120", Offset = "0x7022120", VA = "0x187023120")]
	public NPFFJJKBOID(string KKHEHGHPOAA, Exception NFGOFCBGHNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class LDEDGDJNBHP : IIPAKEPCIDF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct NBBGFBNDILN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<LHGODKBPKKI>> <>t__builder;

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
		private TaskAwaiter<CJFKONEAHCB<LHGODKBPKKI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x70209B0", Offset = "0x701F9B0", VA = "0x1870209B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7020BF0", Offset = "0x701FBF0", VA = "0x187020BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct DGDGJBFCMPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<NNOEHACINLC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<NNOEHACINLC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7014F50", Offset = "0x7013F50", VA = "0x187014F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7015160", Offset = "0x7014160", VA = "0x187015160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	[UnityEngine.Scripting.Preserve]
	public LDEDGDJNBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x701E5B0", Offset = "0x701D5B0", VA = "0x18701E5B0", Slot = "4")]
	[AsyncStateMachine(typeof(NBBGFBNDILN))]
	public Task<IReadOnlyList<LHGODKBPKKI>> LCLFCNBLHOJ(long MFLLPFDNGGL, long KNEHMNKKPOH, [Optional] CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x701E4A0", Offset = "0x701D4A0", VA = "0x18701E4A0", Slot = "5")]
	[AsyncStateMachine(typeof(DGDGJBFCMPE))]
	public Task<IReadOnlyList<NNOEHACINLC>> BHOEFHBJAIF(IReadOnlyList<int> CPCEFNKGCIO, [Optional] CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ENBEDLMGNIM : IEquatable<ENBEDLMGNIM>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int PNBCJNLLIDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	NNOEHACINLC JOFKMNHFDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime MGBPMOENELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	MJPNHEHGJPK? MEDAIENJHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BGFAJJFAJBC? PPAKNCNEKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	ALJEKICLDJA FAGPLLHEOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<CDPIDOPDCID> CEIPAEGAGIB();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum ALJEKICLDJA
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IIPAKEPCIDF
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<LHGODKBPKKI>> LCLFCNBLHOJ(long MFLLPFDNGGL, long KNEHMNKKPOH, [Optional] CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<NNOEHACINLC>> BHOEFHBJAIF(IReadOnlyList<int> CPCEFNKGCIO, [Optional] CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DLALDBKFCOO
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class HJEDPHPPLGA : ENBEDLMGNIM, IEquatable<ENBEDLMGNIM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct LAKDCEAMMBE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<CDPIDOPDCID> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public HJEDPHPPLGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private PIOJFEIEMOG <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<AFJNCMKOAEB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<CDPIDOPDCID> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x701DF90", Offset = "0x701CF90", VA = "0x18701DF90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x701E430", Offset = "0x701D430", VA = "0x18701E430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly LHGODKBPKKI ADINHJOABJM;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int PNBCJNLLIDE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x85BDB0", Offset = "0x85ADB0", VA = "0x18085BDB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public NNOEHACINLC JOFKMNHFDAB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime ADPPIMJHCCN
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5B9E330", Offset = "0x5B9D330", VA = "0x185B9E330", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MJPNHEHGJPK? MEDAIENJHFB
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1D1DEA0", Offset = "0x1D1CEA0", VA = "0x181D1DEA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public BGFAJJFAJBC? PPAKNCNEKJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5B9E410", Offset = "0x5B9D410", VA = "0x185B9E410", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ALJEKICLDJA FAGPLLHEOHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9AF2F0", Offset = "0x9AE2F0", VA = "0x1809AF2F0", Slot = "10")]
			get
			{
				return default(ALJEKICLDJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7019D30", Offset = "0x7018D30", VA = "0x187019D30", Slot = "9")]
		[AsyncStateMachine(typeof(LAKDCEAMMBE))]
		public Task<CDPIDOPDCID> CEIPAEGAGIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x701A020", Offset = "0x7019020", VA = "0x18701A020")]
		public HJEDPHPPLGA(int LHIBNOBDCJA, NNOEHACINLC MPJLKBAACJC, LHGODKBPKKI ADINHJOABJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7019ED0", Offset = "0x7018ED0", VA = "0x187019ED0", Slot = "11")]
		public bool Equals(ENBEDLMGNIM ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7019E30", Offset = "0x7018E30", VA = "0x187019E30", Slot = "0")]
		public override bool Equals(object NOPFNIKINJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7019FE0", Offset = "0x7018FE0", VA = "0x187019FE0")]
		private bool OJACDMHNDLI(HJEDPHPPLGA ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7019F60", Offset = "0x7018F60", VA = "0x187019F60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class FAFCDNGKKMA : ENBEDLMGNIM, IEquatable<ENBEDLMGNIM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct DEKBDKNODJL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<CDPIDOPDCID> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public FAFCDNGKKMA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<CDPIDOPDCID> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7014CB0", Offset = "0x7013CB0", VA = "0x187014CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7014EE0", Offset = "0x7013EE0", VA = "0x187014EE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly JEIKNEHGIKE EOPFLPNADOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly MJPNHEHGJPK GFPJPKCIDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly BGFAJJFAJBC JCIBCMFHEPL;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int PNBCJNLLIDE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7016A60", Offset = "0x7015A60", VA = "0x187016A60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NNOEHACINLC JOFKMNHFDAB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7016610", Offset = "0x7015610", VA = "0x187016610", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime ADPPIMJHCCN
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7016960", Offset = "0x7015960", VA = "0x187016960", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public MJPNHEHGJPK? MEDAIENJHFB
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x70169B0", Offset = "0x70159B0", VA = "0x1870169B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public BGFAJJFAJBC? PPAKNCNEKJK
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x70165C0", Offset = "0x70155C0", VA = "0x1870165C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ALJEKICLDJA FAGPLLHEOHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9A6590", Offset = "0x9A5590", VA = "0x1809A6590", Slot = "10")]
			get
			{
				return default(ALJEKICLDJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x129C1A0", Offset = "0x129B1A0", VA = "0x18129C1A0")]
		public FAFCDNGKKMA(JEIKNEHGIKE IFMNCMCIJMB, MJPNHEHGJPK ANBKGOEOGFN, BGFAJJFAJBC NDAJKHLFPKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x70166A0", Offset = "0x70156A0", VA = "0x1870166A0", Slot = "9")]
		[AsyncStateMachine(typeof(DEKBDKNODJL))]
		public Task<CDPIDOPDCID> CEIPAEGAGIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7016790", Offset = "0x7015790", VA = "0x187016790", Slot = "11")]
		public bool Equals(ENBEDLMGNIM ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7016830", Offset = "0x7015830", VA = "0x187016830", Slot = "0")]
		public override bool Equals(object NOPFNIKINJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7016A00", Offset = "0x7015A00", VA = "0x187016A00")]
		private bool OJACDMHNDLI(FAFCDNGKKMA ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x70168E0", Offset = "0x70158E0", VA = "0x1870168E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class CEPPLEEEMEB : ENBEDLMGNIM, IEquatable<ENBEDLMGNIM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct CMFCABGHFIF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<CDPIDOPDCID> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<CDPIDOPDCID> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7014720", Offset = "0x7013720", VA = "0x187014720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7014960", Offset = "0x7013960", VA = "0x187014960", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly NNOEHACINLC JNLDDGOMICD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly MJPNHEHGJPK GFPJPKCIDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly BGFAJJFAJBC JCIBCMFHEPL;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int PNBCJNLLIDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7014700", Offset = "0x7013700", VA = "0x187014700", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public NNOEHACINLC JOFKMNHFDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime ADPPIMJHCCN
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public MJPNHEHGJPK? MEDAIENJHFB
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x70145D0", Offset = "0x70135D0", VA = "0x1870145D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public BGFAJJFAJBC? PPAKNCNEKJK
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x70141F0", Offset = "0x70131F0", VA = "0x1870141F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ALJEKICLDJA FAGPLLHEOHE
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "10")]
			get
			{
				return default(ALJEKICLDJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x129C1A0", Offset = "0x129B1A0", VA = "0x18129C1A0")]
		public CEPPLEEEMEB(NNOEHACINLC MPJLKBAACJC, MJPNHEHGJPK ANBKGOEOGFN, BGFAJJFAJBC NDAJKHLFPKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7014240", Offset = "0x7013240", VA = "0x187014240", Slot = "9")]
		[AsyncStateMachine(typeof(CMFCABGHFIF))]
		public Task<CDPIDOPDCID> CEIPAEGAGIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7014430", Offset = "0x7013430", VA = "0x187014430", Slot = "11")]
		public bool Equals(ENBEDLMGNIM ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7014310", Offset = "0x7013310", VA = "0x187014310", Slot = "0")]
		public override bool Equals(object NOPFNIKINJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7014540", Offset = "0x7013540", VA = "0x187014540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7014620", Offset = "0x7013620", VA = "0x187014620")]
		private bool OJACDMHNDLI(CEPPLEEEMEB ACBLPNJDJBF)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct OLDEPFJPGDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<ENBEDLMGNIM>> <>t__builder;

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
		public DLALDBKFCOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<LHGODKBPKKI> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<LHGODKBPKKI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, NNOEHACINLC account, LHGODKBPKKI roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7023470", Offset = "0x7022470", VA = "0x187023470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x70242B0", Offset = "0x70232B0", VA = "0x1870242B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct MOOBEDEEKKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, NNOEHACINLC account, LHGODKBPKKI roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<LHGODKBPKKI> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public DLALDBKFCOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<NNOEHACINLC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x701FF60", Offset = "0x701EF60", VA = "0x18701FF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7020940", Offset = "0x701F940", VA = "0x187020940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly AKBJNPIDJPD NFBDHIBMNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly IIPAKEPCIDF BGCNNMALBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly PJDGBOIGELF LJELEOGHMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly KIDOIMPBPFI<(long, long), IReadOnlyList<LHGODKBPKKI>> PKHNKAIOFKO;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7015DD0", Offset = "0x7014DD0", VA = "0x187015DD0")]
	[UnityEngine.Scripting.Preserve]
	public DLALDBKFCOO([JONIFKKOOAA(null)] IIPAKEPCIDF DCKFNJFBNDK, [JONIFKKOOAA(null)] PJDGBOIGELF FLEFIHLBBPH, [JONIFKKOOAA(null)] AKBJNPIDJPD HIMDFMCLJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7015B70", Offset = "0x7014B70", VA = "0x187015B70")]
	[AsyncStateMachine(typeof(OLDEPFJPGDA))]
	public Task<IList<ENBEDLMGNIM>> DNMIAPHPODE(long MFLLPFDNGGL, long EHHCEAFAAIL, bool ABDOLEHKKHE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x70159D0", Offset = "0x70149D0", VA = "0x1870159D0")]
	private bool AJJMLDFPALC(DateTime? BDNNJPHAOOK, long MFLLPFDNGGL, long EHHCEAFAAIL, [Out] JEIKNEHGIKE NMDGMOPBHKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7015CC0", Offset = "0x7014CC0", VA = "0x187015CC0")]
	[AsyncStateMachine(typeof(MOOBEDEEKKJ))]
	private Task<IReadOnlyList<(int, NNOEHACINLC, LHGODKBPKKI)>> EDJHAENIJMA(IReadOnlyList<LHGODKBPKKI> DJNLEEBHIMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PJDGBOIGELF
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<JEIKNEHGIKE> FDIADEBPAND;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BBLADOEBDGA(long MFLLPFDNGGL, long EHHCEAFAAIL, EGHPBEBBELB AHNMDIOCJEH, EJEHHNILJEA KAACMIHMDEC);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JMHNNGLOFJK(long MFLLPFDNGGL, long EHHCEAFAAIL, [Out] JEIKNEHGIKE NMDGMOPBHKN);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LAOKHLOEDLB(long MFLLPFDNGGL, long EHHCEAFAAIL, EJEHHNILJEA KAACMIHMDEC, [Out] JEIKNEHGIKE NMDGMOPBHKN);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OGGEJFAHLHG(long MFLLPFDNGGL, long EHHCEAFAAIL);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface FMILMIMGGOO : KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool EMGJIFBNLDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task FABPMDNPIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HIOIIMFOBLH(Task FGPHJGHMKNM, string MANNLACDIJM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface HMOIFGBPDCI : KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CDPIDOPDCID> EONNNGGCHDA(JEIKNEHGIKE NMDGMOPBHKN);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NOCEIHEBDDM(CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface BCEHKEGFECJ : KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	NBGCBMENGBP KPKCHDNJNPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJPEMHHFMOO();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MAMDJAKFMMK();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface KABDBBKMGKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFNNOPDGNGK(FPLMJHIKMFP ICDIIGEJPGM);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface BHNDCJDEGBI
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan NEBLFEOMONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan AKBENIHFIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan KDAFCCGLJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan BBNHHHCOGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool EADBGGFCOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool FKJKAHOMBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool MCGKBBPHLCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int FFLMLMIAIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool DNJJEDAIHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool MPJMNKGKMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum EDDLOEIIPFG
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum FAICFABDAGI
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
public struct HHPMLGFPHIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long MKMCNPGABHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long KNEHMNKKPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly EDDLOEIIPFG HNGLFCFOHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception KGNDIJCNDCO;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7019D10", Offset = "0x7018D10", VA = "0x187019D10")]
	public HHPMLGFPHIL(long MKMCNPGABHO, long KNEHMNKKPOH, EDDLOEIIPFG HNGLFCFOHLI, [CanBeNull] Exception KGNDIJCNDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7019CC0", Offset = "0x7018CC0", VA = "0x187019CC0")]
	public static HHPMLGFPHIL CJEJKMLBKEL(PJAFGDKDHNF HBBHFHNJBFH, EDDLOEIIPFG HNGLFCFOHLI, [Optional] Exception KGNDIJCNDCO)
	{
		return default(HHPMLGFPHIL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate void DMPJHAHAFDA(HHPMLGFPHIL EEMEFKGLBBA);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface FFANMCAACBH : KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action BCEOOODPNNF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event DMPJHAHAFDA KDDOOKFMOGI;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event DMPJHAHAFDA CJMBAOGBJMI;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event DMPJHAHAFDA DIBCCGKLIEA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<FAICFABDAGI, bool> ADLFJCKGPDP;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OLANCFICNDM();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FMJPNGBLPHN(HHPMLGFPHIL EEMEFKGLBBA);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HGCHLDDKLIG(HHPMLGFPHIL EEMEFKGLBBA);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OGIMGPIBOAC(HHPMLGFPHIL EEMEFKGLBBA);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PHLPNPAOIKJ(FAICFABDAGI HJBPLFIGHKM, bool ADMMLGCNPFE);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface PDMELBICMOC : KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EIMAOALOEDB();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NAOLMLAPOLI();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface HNNBOBPPOPF : KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus CIBPOOFAAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OFJNJJEGOFN(PJAFGDKDHNF MLOEGMNAALP, EPELMGABJHE GIFNLGAIOPP, CancellationToken CKFCHGJKDBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class FDOFIDPBNDD
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7016AA0", Offset = "0x7015AA0", VA = "0x187016AA0")]
	public static bool FNJIEMAHOML(this HNNBOBPPOPF JGFEBJKHLHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate Task HENJJIMFCAP(CancellationToken DJIBMMAIGPE, int FLDOALLBIIP, MJKPLCNHABA NIPKIEGBLMM);
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface IJCGBJPCBMP : KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FFGFPHFEIPI(HENJJIMFCAP JJFJLFJKLOM);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface FPLMJHIKMFP : PIOJFEIEMOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken CLPPAKNFOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	NDJGECDCBMH BFNOBIIBIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	EIHCBOIGFHH AIANBJBNKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	AAMEEHEGCAA LAFHBHIMOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ICFBHJEIGMP POFCPOIIAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	MJLNBIEJOCH GKPJHEDALLP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	DAGLENMEAMP KKOAEGFFILI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	FKFCOBBBJFG KJJIHKJHOEL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	IOEEDLJNEAH PNOKKMCGANN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	FMILMIMGGOO ELPBBOMHMFL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	HMOIFGBPDCI OFEABHFIMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	FFANMCAACBH KKLBDJKBMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	PDMELBICMOC BGKHNJNKEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HNNBOBPPOPF HEJMHMJNLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IJCGBJPCBMP HFDMEPGOLPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	BHKONILDDPB OLCLFDJEJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	NGGKNMPNMDK BEILJEBOLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	DBGBHMBICHB IJCFNJNAIBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	MCGLIMLPBAH EOEEOBLONGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DJCOHDGDBBC LNJHCEPIAKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	POGOLOONGNH HGILBMPJEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	HAMLHDFIHKI IHDBJEPNCOO
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	LMFMHBLPPGJ AIFOPBMCCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	PEPOGGKKJLP DGBADPLLLDD
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	KALIOJPEJGN NFIKHLCKNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	BCEHKEGFECJ POGBHOBMAOL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	BHNDCJDEGBI GEBPIDKMHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	HNEMDIOKFMA OIHBNPDIICC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	PJDGBOIGELF OCJFOHFDPPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	OBJJHCDEKJJ LEBFBIHILGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	EJFHNNKMENL DNLEEGIBPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	CJINGDNGAEK BKMCIDDKEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	OBLJMEGKEJC HKAHFBLOIHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void EONBDJGEGAJ(EPELMGABJHE JKIHNHIEFMG);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface BHKONILDDPB : KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BJEFPMHLDDL GKAGDNHKNII(Guid PHAMLENOBDP);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FFDBNDOHLIO(Guid PHAMLENOBDP);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MMBJCCJOEFF(Guid PHAMLENOBDP, Task IGHFBOKMDMP);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PACGLAJGIFE(Guid PHAMLENOBDP, CDPIDOPDCID KBFMJFGAHKI);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(CDPIDOPDCID, Task)> MCBMMGNPFNN(Guid PHAMLENOBDP);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface ILNMIHADCPN : KABDBBKMGKL, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface NGGKNMPNMDK : KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNINGLOAPOK(DKMNKHDNIBD KKHEHGHPOAA);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DPEKEDKJDOO(DKMNKHDNIBD KKHEHGHPOAA);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<LDJAJOAAKGC> PCCPIBPMHKM(CancellationToken NKDFNGHFKJC);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface DBGBHMBICHB : KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BJEFPMHLDDL CGJOBBFCMCD(DKMNKHDNIBD EAAEOGDKMGK);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GOCHBDHGPKB(Guid PHAMLENOBDP, Task IGHFBOKMDMP);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface MCGLIMLPBAH : KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CDPIDOPDCID> EOEEOBLONGI(DKMNKHDNIBD MBBLEEHOBKL);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface DJCOHDGDBBC : KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BJEHJDLGDFO> ADICFGGHCPP(KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, PJAFGDKDHNF MLOEGMNAALP, CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface HAMLHDFIHKI : KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CDPIDOPDCID FCHHGLGOCAA(EEPDJJKFILM NOMIEKKDAGG);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NDLEMFNFAIO(string PLCNFEGEAJG);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface POGOLOONGNH : KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DKMNKHDNIBD> KHMILKPOOOC(DKMNKHDNIBD HHNBCLDGHCL, MFFPJJNLNNN NGFBHJIHHDN, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<DKMNKHDNIBD> PNEOGMNHILP(CancellationToken LABHBAHABKB, MFFPJJNLNNN NGFBHJIHHDN);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CHMMBEKDPCD GBMBMDHMGGE(DPOAJAMLBLE PJDDKLGEKCN, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CHMMBEKDPCD DHGDLPEMEKD(DPOAJAMLBLE PJDDKLGEKCN, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface LMFMHBLPPGJ : KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CDPIDOPDCID HEKMBNHAJMK(EEPDJJKFILM NOMIEKKDAGG, LDJAJOAAKGC DOIIBAIKNLJ);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CDPIDOPDCID BCIKJJMIAIO(EEPDJJKFILM IPLCJMBGNDN);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface PEPOGGKKJLP
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOFNBANEIAP(JIKOCFMECDG INDEJNJCMKF);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJEILDICOMI(JIKOCFMECDG INDEJNJCMKF);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DBJBACBOEPJ(JIKOCFMECDG INDEJNJCMKF);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PGGCCAOCAGC(JIKOCFMECDG INDEJNJCMKF);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class JIKOCFMECDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly PJAFGDKDHNF PGIMBKHMAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> AINJFMFBMCA;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public KLCBNGOGDPF<string> GBNBGEKEMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x854650", Offset = "0x853650", VA = "0x180854650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	public JIKOCFMECDG(PJAFGDKDHNF AIPGHLJGNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x701CEF0", Offset = "0x701BEF0", VA = "0x18701CEF0")]
	public JIKOCFMECDG JJMDHLCJKLL(string GMFCIHEFPPO, string JJCEIJMGOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x701CE60", Offset = "0x701BE60", VA = "0x18701CE60")]
	public bool HBHHIMNINFO([Out] IEnumerable<KeyValuePair<string, string>> EECFNBMOJHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6276F60", Offset = "0x6275F60", VA = "0x186276F60")]
	public JIKOCFMECDG HBCEIEAJLDB(KLCBNGOGDPF<string> COCKABGNCJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface HNEMDIOKFMA
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool OKODPGOFHCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string OIABPCFNCKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool PFFDNDONDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KMPBPGLPKHE();

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JDADNFIBCCJ COKCAEEPCBL(long ONBLDGLEBND);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	INLFDNJMICH<KIDKIHLFPDC, OPGPLFDAFEE> IFLDOLJPHGB(long ONBLDGLEBND);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	INLFDNJMICH<KIDKIHLFPDC, KECMDPPEFHG> GHDHGKKKMOE(long ONBLDGLEBND);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	INLFDNJMICH<long, DJMMCDEOJKM> ABNLDDGDBEF();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FMMOCDFKOMG(long ONBLDGLEBND, [Out] bool LNALANCFNJK);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> MJABMEBICCD(byte[] LDGJIBHMHDH, byte[] BIDAIDJLFGN, CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface PIOJFEIEMOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool FNJIEMAHOML
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool AIIFFCJJBLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	EPELMGABJHE FAPCLMKBEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action BCEOOODPNNF;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event DMPJHAHAFDA KDDOOKFMOGI;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event DMPJHAHAFDA CJMBAOGBJMI;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event DMPJHAHAFDA DIBCCGKLIEA;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<FAICFABDAGI, bool> ADLFJCKGPDP;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NAOLMLAPOLI();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NKLCFNADKBK ELLBCCGKELC();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ENMKHCFJBGI KEJBHHLPMKI();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<CDPIDOPDCID> EONNNGGCHDA(JEIKNEHGIKE IFMNCMCIJMB);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task NOCEIHEBDDM(CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface MJLNBIEJOCH
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool AFDOBKFHNII
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	string ECBFAFPJGND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACEJKGNDIFK(Scene AOJOFNNAHEJ);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PMDMEMBBGNO(EHINFMJDBCM OLMEIPNILDD, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task BNIIBDENNBC();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task KJIPGIFGBNM();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface ICFBHJEIGMP
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	IIBKIJCPLOJ AGEBIJJODLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool ADPPIPJKDOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool EFCHJHHEIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool NBAOFPAMGKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool CMKKHJBACJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int PHNHIDGPEOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool PFMCJFNGOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool CAPMFENOBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	byte KNHDCKNKDPD
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	byte LNBGKFKBMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool NHMKMKCLJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool IIJNICPFJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool PGCCBIEDFAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	float OKNBCMBIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> DDEMIMCCLNN;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NDJGECDCBMH NFBEIJNLDOO(NDJGECDCBMH IMNFKMKKLKD);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLDGLFGLAND(NDJGECDCBMH MMBLPJPOBHB);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LCBGCFKDBID();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task KJPOMPJIDAN(KLCBNGOGDPF<string>.BPJNBAPCFPO AHBJJDODIDP, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HDPPCLAIGIM(float FPGNFNMDNAF);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GMFOPDNFLOP(string FAFNIBDAFEG);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<ACLAJEAKFDA> GDMBDPKFFED();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable KBGMOLPAKFO(object PDLLDMABKGP, ACLAJEAKFDA ANPILJCEKDH);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<OMBDFJMOFCJ> OMCAEFCCKOA();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	OPGPLFDAFEE IAPDMNIKLJK(IEnumerable<ENFIPLJHHAN> NIMIEHKGAPI);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GJMBCKNJMCA(int KLHABFFOPGM);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task GIOOJPCGKKJ();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HMHCOAKPNCM();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool GINKPJMOAOG();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task GFFNGDDBOOM(CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task IIAPNEBANKM(CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<EGMDONPFLGH> HNDMKDOBDFP(DateTime HIDFDFPPEII, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> IMMPNAPDCLD(CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LAGEMMFIAPA(string KKHEHGHPOAA = "", float OCJBGOIAOCN = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "25")]
	BLDLANPDJEK LGBMNDIDKMH(HAGLFGFJMBC GCKKMHMOMMM, JEBPGEFJPEO GJCAFENEDIP, KECMDPPEFHG NKCIFMIJNOK, IEnumerable<PersistenceView> KCJODJEGCGJ, NLAJGCBNEID MDLMCGPDINM);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GDPOLGMLDFG(KECMDPPEFHG NKCIFMIJNOK);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JONMFGALMNO(ENFIPLJHHAN HNOBJNPONNI, [In] BLDLANPDJEK GEDBNCKLEDD);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task EOIMECKNENA(KECMDPPEFHG EMKHAEJLEFJ, bool CDGBDCOGIEM, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task OOLADAODPKJ(CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void ODNFEPCJPAM(long MFLLPFDNGGL, long KNEHMNKKPOH, AFJNCMKOAEB DGCGCONGDDJ, LHGODKBPKKI HCCHGABJPLE, EGHPBEBBELB AHNMDIOCJEH, CIIAAADNGNH? PFJJPJNHLEK, PEDLLJADMJP? OFKKHDCPFPM);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void FPBMDEEAEBE(long MFLLPFDNGGL, long KNEHMNKKPOH, PEDLLJADMJP? OFKKHDCPFPM);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void CHPAHNIKPPM(PersistenceView DAKGCIADFDO);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool ILAHKNLKFCM(PersistenceView KHKFEBPAGAG);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool OMCFBAPMHLH(ENFIPLJHHAN HNOBJNPONNI, EBLAFNHPHNO PIBHEOOEKKE, [Out] BDEMGCIABCE AJCIAFNKGGI);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task MGCGGKLNGHM(CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void INPCJGJGCML();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable HFFDPAPOKCO();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void CCGOHFAPCDF(KECMDPPEFHG EMKHAEJLEFJ, EBLAFNHPHNO PIBHEOOEKKE);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> BKOCCIKEPIB(EIHCBOIGFHH PIKFDLICNNE, CancellationToken LABHBAHABKB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void IHNIFDGPFCL(CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<ODCIKMCBEPK> DEHLADMKJKL(JIBAEFGHKLH HHNBCLDGHCL);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<AFJNCMKOAEB> ONIAGNOLICH(long MFLLPFDNGGL, bool HPIPAOCOFDE, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<LHGODKBPKKI> FBAGLEPKPGC(long MFLLPFDNGGL, long KNEHMNKKPOH, long FCIOGEHFGHC, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<LHGODKBPKKI> DOFKOCJEHFG(long MFLLPFDNGGL, long KNEHMNKKPOH, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<BDAHONEPHPJ> LBJGBLBAFIK(string GJLGNAADPEF, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<BDAHONEPHPJ> DAMBAGJFMFH(string GJLGNAADPEF, long MFLLPFDNGGL, long KNEHMNKKPOH, string HIFKBGMPOPE, MHLILHNPMJB.DMENNCJDPGH KBAPBJOHBKA, MHLILHNPMJB.DMENNCJDPGH BIDAIDJLFGN, int BENCOAFHAIE);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool IDKDGKMLFFO();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool GMAKGHOEMEA();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool NGIHLKKAJOB(IEnumerable<BDEMGCIABCE> KJNGDLMHCPN);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void CPLLHMBGFHG(List<GameObject> NMMNPLMIAAE);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "52")]
	float DLJMAHHHCPM();

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task<Scene> GKOKEHJKDGL(string FEBNLODCIFJ, LoadSceneMode GNHNDAPFAIO, bool FMIADNGFDCN, KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void JJCBMAANJBB();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void LPFHPMPPIHO(bool HFODIMENHKG);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void MKBNIAPHGOF();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void PBHFPADLKLH();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void EHEAIHGALHB(PJAFGDKDHNF OKDGJEEFKMM);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task PNLICJKICOP(KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task BDPNPFIAPID(KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "70")]
	Task OPJALCHGLFP(KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task OPKLJNLKHEJ(KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "72")]
	IDisposable KPAMCLNJMGL();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "73")]
	DEIMABLGJBJ BDOPLKJFBOK();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task HFJDDBEJCFL(CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface DEIMABLGJBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CGIPLNPOBDK(CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BGGFDHOPNCB(CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct BLDLANPDJEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> ACNNOGINFBK;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum EGMDONPFLGH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct HAGLFGFJMBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string MALHCOEHMEF;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface IIBKIJCPLOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	PJAFGDKDHNF FALODGJMLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	AFJNCMKOAEB DEDLAMEPEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	NGELDFKPLFG KGJELHNNCNH
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool BJKHHJDOLEB
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool EFLIHMOMIJN
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int ECGDKGDLEBB
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action OAGHLHLDNGN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> ABJBFOPLFIB;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LHLHMJMOPBI();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.FEMMGOOLEIE> BIBNJHLFOEO(long ONBLDGLEBND, [Optional] CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<GLOFNOBLFIF> BPIHHNOAFJN();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task CHMHBHJFKAB();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(PJAFGDKDHNF, EPELMGABJHE) KNCIHHCCJPB();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CDHPIBIKHJE JKHKDBHOEBI();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PFOOLJHLDJJ(long ONBLDGLEBND);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EEIGIACOACE(PJAFGDKDHNF AIPGHLJGNDC, Matchmaking.PDCLGBLFFHK KNFGDDANCCK, (int Major, int? Minor)? CMBMLLGKBPM);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface KALIOJPEJGN
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DONMKCJGJLC([Out] IEnumerable<int> FDJGNMGEIJL);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void COMKFEPPOEI(AIBHHEDLNAL DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EANGAJBPCPM(AIBHHEDLNAL DJIBMMAIGPE);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface FGCMMLCDKHK
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GPMKOBJEOCO(CDPIDOPDCID DIGFOPCJPDL);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface EPMDPLCBGFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKFKEGKCFDO(NJFJGLKIAHN.GJMNCNLJDAN MOMKKIFHNBB);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFIBPAPKGNF(NJFJGLKIAHN.GJMNCNLJDAN MOMKKIFHNBB);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface DAGLENMEAMP : EPMDPLCBGFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CDPIDOPDCID ONJBIHFAGHL(EEPDJJKFILM IPLCJMBGNDN);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface FKFCOBBBJFG : EPMDPLCBGFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CDPIDOPDCID FCHHGLGOCAA(EEPDJJKFILM ABGNPDBOJGC);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface JDADNFIBCCJ
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DFAHBLOKBPH<EHINFMJDBCM, DNBIAPHIKOM>> OIGMALIEAHC(string HIFKBGMPOPE, long ONBLDGLEBND, long? MFLLPFDNGGL, long? KNEHMNKKPOH, HBJBOCABMJK.JBEGGCMHJHB KDGKOEFHGEK, CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface INLFDNJMICH<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DFAHBLOKBPH<LMMNLPJCOOL<TData>, DNBIAPHIKOM>> FNBELHHIEGG(TGetDataArg OEMEKBFANIG, CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class JEHCNKNNLFD : FPLMJHIKMFP, PIOJFEIEMOG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct JMOEMHLCADO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<CDPIDOPDCID> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public JEHCNKNNLFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public JEIKNEHGIKE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<CDPIDOPDCID> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x701CFC0", Offset = "0x701BFC0", VA = "0x18701CFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x701D240", Offset = "0x701C240", VA = "0x18701D240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct PCIHPNDPODF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public JEHCNKNNLFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7025A60", Offset = "0x7024A60", VA = "0x187025A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7025C90", Offset = "0x7024C90", VA = "0x187025C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class FNLABPPJOOM : IEnumerable<KABDBBKMGKL>, IEnumerable, IEnumerator<KABDBBKMGKL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private KABDBBKMGKL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public JEHCNKNNLFD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		private KABDBBKMGKL System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8A4A30", Offset = "0x8A3A30", VA = "0x1808A4A30")]
		[DebuggerHidden]
		public FNLABPPJOOM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7017B20", Offset = "0x7016B20", VA = "0x187017B20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7017F80", Offset = "0x7016F80", VA = "0x187017F80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7017ED0", Offset = "0x7016ED0", VA = "0x187017ED0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KABDBBKMGKL> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7017ED0", Offset = "0x7016ED0", VA = "0x187017ED0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource JONIAPLPAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly NDJGECDCBMH MMBLPJPOBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool OJOGLGJEHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NGPCLKEAKPM MPBHFNMLHBI;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public EIHCBOIGFHH AIANBJBNKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x8507F0", VA = "0x1808517F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x851820", Offset = "0x850820", VA = "0x180851820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public AAMEEHEGCAA LAFHBHIMOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8515F0", Offset = "0x8505F0", VA = "0x1808515F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8518B0", Offset = "0x8508B0", VA = "0x1808518B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public ICFBHJEIGMP POFCPOIIAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8516F0", Offset = "0x8506F0", VA = "0x1808516F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8518A0", Offset = "0x8508A0", VA = "0x1808518A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public MJLNBIEJOCH GKPJHEDALLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x85B5E0", Offset = "0x85A5E0", VA = "0x18085B5E0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x85B5F0", Offset = "0x85A5F0", VA = "0x18085B5F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public DAGLENMEAMP KKOAEGFFILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8516D0", Offset = "0x8506D0", VA = "0x1808516D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8518D0", Offset = "0x8508D0", VA = "0x1808518D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public FKFCOBBBJFG KJJIHKJHOEL
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x8507D0", VA = "0x1808517D0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8516E0", Offset = "0x8506E0", VA = "0x1808516E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public IOEEDLJNEAH PNOKKMCGANN
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x85FB20", Offset = "0x85EB20", VA = "0x18085FB20", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x85FB30", Offset = "0x85EB30", VA = "0x18085FB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public FMILMIMGGOO ELPBBOMHMFL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x85FC60", Offset = "0x85EC60", VA = "0x18085FC60", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x85FC80", Offset = "0x85EC80", VA = "0x18085FC80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public HMOIFGBPDCI OFEABHFIMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x85FBB0", Offset = "0x85EBB0", VA = "0x18085FBB0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x85FB60", Offset = "0x85EB60", VA = "0x18085FB60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public FFANMCAACBH KKLBDJKBMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6B50", VA = "0x180AB7B50", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xBD14E0", Offset = "0xBD04E0", VA = "0x180BD14E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public PDMELBICMOC BGKHNJNKEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x85FBD0", Offset = "0x85EBD0", VA = "0x18085FBD0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x85FBE0", Offset = "0x85EBE0", VA = "0x18085FBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public HNNBOBPPOPF HEJMHMJNLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xB266F0", Offset = "0xB256F0", VA = "0x180B266F0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xABCA80", Offset = "0xABBA80", VA = "0x180ABCA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public IJCGBJPCBMP HFDMEPGOLPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x85D2D0", Offset = "0x85C2D0", VA = "0x18085D2D0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x85D330", Offset = "0x85C330", VA = "0x18085D330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public BHKONILDDPB OLCLFDJEJFN
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x981B50", Offset = "0x980B50", VA = "0x180981B50", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xC75870", Offset = "0xC74870", VA = "0x180C75870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public ILNMIHADCPN KACNPJIBAPC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xBADF40", Offset = "0xBACF40", VA = "0x180BADF40", Slot = "57")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xBADF50", Offset = "0xBACF50", VA = "0x180BADF50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public NGGKNMPNMDK BEILJEBOLLC
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7A0", Offset = "0xA1E7A0", VA = "0x180A1F7A0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA19A00", Offset = "0xA18A00", VA = "0x180A19A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public DBGBHMBICHB IJCFNJNAIBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x998240", Offset = "0x997240", VA = "0x180998240", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA204F0", Offset = "0xA1F4F0", VA = "0x180A204F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public MCGLIMLPBAH EOEEOBLONGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x98F4A0", Offset = "0x98E4A0", VA = "0x18098F4A0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA75350", Offset = "0xA74350", VA = "0x180A75350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public DJCOHDGDBBC LNJHCEPIAKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x85D2E0", Offset = "0x85C2E0", VA = "0x18085D2E0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x85D310", Offset = "0x85C310", VA = "0x18085D310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public POGOLOONGNH HGILBMPJEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9955A0", Offset = "0x9945A0", VA = "0x1809955A0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA6B230", Offset = "0xA6A230", VA = "0x180A6B230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public HAMLHDFIHKI IHDBJEPNCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x95CA90", Offset = "0x95BA90", VA = "0x18095CA90", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xC758B0", Offset = "0xC748B0", VA = "0x180C758B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public LMFMHBLPPGJ AIFOPBMCCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x99B680", Offset = "0x99A680", VA = "0x18099B680", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xC75890", Offset = "0xC74890", VA = "0x180C75890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public PEPOGGKKJLP DGBADPLLLDD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x99B690", Offset = "0x99A690", VA = "0x18099B690", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xABA730", Offset = "0xAB9730", VA = "0x180ABA730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public KALIOJPEJGN NFIKHLCKNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x99B5F0", Offset = "0x99A5F0", VA = "0x18099B5F0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xC75850", Offset = "0xC74850", VA = "0x180C75850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public BCEHKEGFECJ POGBHOBMAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x99B600", Offset = "0x99A600", VA = "0x18099B600", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xC75A70", Offset = "0xC74A70", VA = "0x180C75A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public BHNDCJDEGBI GEBPIDKMHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x99B4E0", Offset = "0x99A4E0", VA = "0x18099B4E0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xC75A50", Offset = "0xC74A50", VA = "0x180C75A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public HNEMDIOKFMA OIHBNPDIICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x99B4B0", Offset = "0x99A4B0", VA = "0x18099B4B0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xC75990", Offset = "0xC74990", VA = "0x180C75990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public PJDGBOIGELF OCJFOHFDPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x99B410", Offset = "0x99A410", VA = "0x18099B410", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public OBJJHCDEKJJ LEBFBIHILGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xB3B4B0", Offset = "0xB3A4B0", VA = "0x180B3B4B0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public EJFHNNKMENL DNLEEGIBPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x99B670", Offset = "0x99A670", VA = "0x18099B670", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public CJINGDNGAEK BKMCIDDKEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xBF8430", Offset = "0xBF7430", VA = "0x180BF8430", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public OBLJMEGKEJC HKAHFBLOIHD
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xBF8260", Offset = "0xBF7260", VA = "0x180BF8260", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public EPELMGABJHE FAPCLMKBEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xBF6640", Offset = "0xBF5640", VA = "0x180BF6640", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xC758D0", Offset = "0xC748D0", VA = "0x180C758D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private bool MGLBKPLGPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x701BF70", Offset = "0x701AF70", VA = "0x18701BF70", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private bool EOJIBBKNJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x701C480", Offset = "0x701B480", VA = "0x18701C480", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private CancellationToken CPGPBEDHJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x701BF50", Offset = "0x701AF50", VA = "0x18701BF50", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private NDJGECDCBMH ACAIHOMFDFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action EJMDPIIOHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x701C5C0", Offset = "0x701B5C0", VA = "0x18701C5C0", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x701C500", Offset = "0x701B500", VA = "0x18701C500", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event DMPJHAHAFDA DLHOPECGCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x701BEF0", Offset = "0x701AEF0", VA = "0x18701BEF0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x701BE90", Offset = "0x701AE90", VA = "0x18701BE90", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event DMPJHAHAFDA GJHIOEBFNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x701C560", Offset = "0x701B560", VA = "0x18701C560", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x701C990", Offset = "0x701B990", VA = "0x18701C990", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event DMPJHAHAFDA DFCAMGAKCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x701C050", Offset = "0x701B050", VA = "0x18701C050", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x701C730", Offset = "0x701B730", VA = "0x18701C730", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<FAICFABDAGI, bool> NPCGIOHMBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x701C420", Offset = "0x701B420", VA = "0x18701C420", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x701C930", Offset = "0x701B930", VA = "0x18701C930", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0xC758D0", Offset = "0xC748D0", VA = "0x180C758D0", Slot = "37")]
	public void EONBDJGEGAJ(EPELMGABJHE JKIHNHIEFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x701C9F0", Offset = "0x701B9F0", VA = "0x18701C9F0")]
	[UnityEngine.Scripting.Preserve]
	internal JEHCNKNNLFD([JONIFKKOOAA(null)] NDJGECDCBMH MMBLPJPOBHB, [JONIFKKOOAA(null)] EIHCBOIGFHH PIKFDLICNNE, [JONIFKKOOAA(null)] AAMEEHEGCAA PENPFHPHPNG, [JONIFKKOOAA(null)] ICFBHJEIGMP LCGMLIBOFMO, [JONIFKKOOAA(null)] MJLNBIEJOCH ENJCLJIOONP, [JONIFKKOOAA(null)] DAGLENMEAMP KMICNDCFOFO, [JONIFKKOOAA(null)] FKFCOBBBJFG LFOBCPBCLPP, [JONIFKKOOAA(null)] IOEEDLJNEAH CNHDNJOLLOA, [JONIFKKOOAA(null)] FMILMIMGGOO MEEDMOGLOPC, [JONIFKKOOAA(null)] HMOIFGBPDCI CGKBNJBIHHE, [JONIFKKOOAA(null)] FFANMCAACBH PHHCGKEOFMA, [JONIFKKOOAA(null)] PDMELBICMOC DOCFNIMHOCE, [JONIFKKOOAA(null)] HNNBOBPPOPF JGFEBJKHLHG, [JONIFKKOOAA(null)] IJCGBJPCBMP PIHAHCJAHJA, [JONIFKKOOAA(null)] BHKONILDDPB IEJFDDMEIPF, [JONIFKKOOAA(null)] ILNMIHADCPN GBPPCLICAHB, [JONIFKKOOAA(null)] NGGKNMPNMDK EACKIFHAKIG, [JONIFKKOOAA(null)] DBGBHMBICHB FCCKEPMGBBB, [JONIFKKOOAA(null)] MCGLIMLPBAH FKKEIFPHMEG, [JONIFKKOOAA(null)] DJCOHDGDBBC EIHELPAEMNH, [JONIFKKOOAA(null)] HAMLHDFIHKI INBAKNBBLCA, [JONIFKKOOAA(null)] POGOLOONGNH BNMKCOAPNDL, [JONIFKKOOAA(null)] LMFMHBLPPGJ FMBGCKHFMEM, [JONIFKKOOAA(null)] PEPOGGKKJLP DMAKODMDHED, [JONIFKKOOAA(null)] KALIOJPEJGN AIAIGNBMDCD, [JONIFKKOOAA(null)] BHNDCJDEGBI IOPKIGDDBDF, [JONIFKKOOAA(null)] HNEMDIOKFMA HBJOHCJFHNC, [JONIFKKOOAA(null)] PJDGBOIGELF FDBBAGONCHL, [JONIFKKOOAA(null)] OBJJHCDEKJJ JEHMBKNGONC, [JONIFKKOOAA(null)] EJFHNNKMENL INFKAKPFJBL, [JONIFKKOOAA(null)] CJINGDNGAEK CCCNFPGKIHG, [JONIFKKOOAA(null)] OBLJMEGKEJC CIEJPPJPNND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x701C680", Offset = "0x701B680", VA = "0x18701C680")]
	private void LFNNOPDGNGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x701C140", Offset = "0x701B140", VA = "0x18701C140", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x701C2E0", Offset = "0x701B2E0", VA = "0x18701C2E0", Slot = "50")]
	private void EOAAEHEKKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x701C0B0", Offset = "0x701B0B0", VA = "0x18701C0B0", Slot = "51")]
	private NKLCFNADKBK DOMMNGEEDEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x701C790", Offset = "0x701B790", VA = "0x18701C790", Slot = "52")]
	private ENMKHCFJBGI NAPFFAAHFGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x701C820", Offset = "0x701B820", VA = "0x18701C820", Slot = "53")]
	[AsyncStateMachine(typeof(JMOEMHLCADO))]
	private Task<CDPIDOPDCID> NEHIKCOINOC(JEIKNEHGIKE NMDGMOPBHKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x701C330", Offset = "0x701B330", VA = "0x18701C330", Slot = "54")]
	[AsyncStateMachine(typeof(PCIHPNDPODF))]
	private Task FEGADPBJJIF(CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x701BFD0", Offset = "0x701AFD0", VA = "0x18701BFD0")]
	[IteratorStateMachine(typeof(FNLABPPJOOM))]
	private IEnumerable<KABDBBKMGKL> DHCBGOJDPKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x701C620", Offset = "0x701B620", VA = "0x18701C620")]
	[CompilerGenerated]
	private void KAIEAOILJAH(KABDBBKMGKL EMPBMFAFICE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class LHKIONOCJMO : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x10082C0", Offset = "0x10072C0", VA = "0x1810082C0")]
	public LHKIONOCJMO(string KKHEHGHPOAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class KJGCCDMGFJJ : NPIEJOEOFDN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct JNGEENIJLDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public KJGCCDMGFJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x701D2B0", Offset = "0x701C2B0", VA = "0x18701D2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x701D5F0", Offset = "0x701C5F0", VA = "0x18701D5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly FPLMJHIKMFP ICDIIGEJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly ICFBHJEIGMP LCGMLIBOFMO;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x857060", Offset = "0x856060", VA = "0x180857060")]
	public KJGCCDMGFJJ(FPLMJHIKMFP ICDIIGEJPGM, ICFBHJEIGMP LCGMLIBOFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x701DEA0", Offset = "0x701CEA0", VA = "0x18701DEA0", Slot = "4")]
	[AsyncStateMachine(typeof(JNGEENIJLDN))]
	public Task<bool> KKMNBIMODAK(CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x701DDC0", Offset = "0x701CDC0", VA = "0x18701DDC0")]
	[CompilerGenerated]
	private object DJCNKENPEJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class OKCMGPHNGKI : NPIEJOEOFDN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct FEENBFGCGKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public OKCMGPHNGKI <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7016AF0", Offset = "0x7015AF0", VA = "0x187016AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7017200", Offset = "0x7016200", VA = "0x187017200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly FPLMJHIKMFP ICDIIGEJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly ICFBHJEIGMP LCGMLIBOFMO;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private IIBKIJCPLOJ AGEBIJJODLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7023210", Offset = "0x7022210", VA = "0x187023210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x857060", Offset = "0x856060", VA = "0x180857060")]
	public OKCMGPHNGKI(FPLMJHIKMFP ICDIIGEJPGM, ICFBHJEIGMP LCGMLIBOFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x7023340", Offset = "0x7022340", VA = "0x187023340", Slot = "4")]
	[AsyncStateMachine(typeof(FEENBFGCGKA))]
	public Task<bool> KKMNBIMODAK(CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7023260", Offset = "0x7022260", VA = "0x187023260")]
	[CompilerGenerated]
	private object IEMNKDACLAN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class MLNEEBOGNGK : NPIEJOEOFDN
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class DBLBDPOOBAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public MLNEEBOGNGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public GLOFNOBLFIF result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public PJAFGDKDHNF newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public DBLBDPOOBAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7014A40", Offset = "0x7013A40", VA = "0x187014A40")]
		internal object KAJNGBPKEIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x70149D0", Offset = "0x70139D0", VA = "0x1870149D0")]
		internal object IFALBIEGELG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7014B30", Offset = "0x7013B30", VA = "0x187014B30")]
		internal object NFKDNNOABBG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct AGGMDBGHGBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public MLNEEBOGNGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private DBLBDPOOBAL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<GLOFNOBLFIF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x700D700", Offset = "0x700C700", VA = "0x18700D700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x700E030", Offset = "0x700D030", VA = "0x18700E030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly FPLMJHIKMFP ICDIIGEJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ICFBHJEIGMP LCGMLIBOFMO;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private IIBKIJCPLOJ AGEBIJJODLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x701FD70", Offset = "0x701ED70", VA = "0x18701FD70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x857060", Offset = "0x856060", VA = "0x180857060")]
	public MLNEEBOGNGK(FPLMJHIKMFP ICDIIGEJPGM, ICFBHJEIGMP LCGMLIBOFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x701FDC0", Offset = "0x701EDC0", VA = "0x18701FDC0", Slot = "4")]
	[AsyncStateMachine(typeof(AGGMDBGHGBL))]
	public Task<bool> KKMNBIMODAK(CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface NPIEJOEOFDN
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> KKMNBIMODAK(CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct NJEHHENCCDH
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class LKMILKOOCNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public FPLMJHIKMFP manager;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public LKMILKOOCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x701EDC0", Offset = "0x701DDC0", VA = "0x18701EDC0")]
		internal Task PBBLGBOIIFM(CancellationToken cancellationToken, int roomTotalVersion, MJKPLCNHABA localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct PEBPEEAPKJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public NJEHHENCCDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private JEIKNEHGIKE <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<EGMDONPFLGH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<CDPIDOPDCID> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7029760", Offset = "0x7028760", VA = "0x187029760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7029CF0", Offset = "0x7028CF0", VA = "0x187029CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct LPFEBKBLCKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public NJEHHENCCDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x701EE10", Offset = "0x701DE10", VA = "0x18701EE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x701F130", Offset = "0x701E130", VA = "0x18701F130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly CancellationToken LABHBAHABKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly FPLMJHIKMFP HADKCEDAMNP;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private EIHCBOIGFHH AIANBJBNKOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7022170", Offset = "0x7021170", VA = "0x187022170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private ICFBHJEIGMP POFCPOIIAOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7022120", Offset = "0x7021120", VA = "0x187022120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private IIBKIJCPLOJ AGEBIJJODLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7021FA0", Offset = "0x7020FA0", VA = "0x187021FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private HMOIFGBPDCI OFEABHFIMIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x70220D0", Offset = "0x70210D0", VA = "0x1870220D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2009770", Offset = "0x2008770", VA = "0x182009770")]
	public NJEHHENCCDH(CancellationToken LABHBAHABKB, FPLMJHIKMFP HADKCEDAMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7022020", Offset = "0x7021020", VA = "0x187022020")]
	public static HENJJIMFCAP BCLNBDDMLEK(FPLMJHIKMFP HADKCEDAMNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7022500", Offset = "0x7021500", VA = "0x187022500")]
	[AsyncStateMachine(typeof(PEBPEEAPKJD))]
	public Task<bool> PCBFBKDIPKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x70221C0", Offset = "0x70211C0", VA = "0x1870221C0")]
	private bool JFLLILJEEML([Out] JEIKNEHGIKE NMDGMOPBHKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7021ED0", Offset = "0x7020ED0", VA = "0x187021ED0")]
	[AsyncStateMachine(typeof(LPFEBKBLCKH))]
	private Task AIMLFIOAMGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x70223D0", Offset = "0x70213D0", VA = "0x1870223D0")]
	private Task<EGMDONPFLGH> LDBIMNGNCAJ(JEIKNEHGIKE IHFMADDOAGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct BJEFPMHLDDL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly BHKONILDDPB IEJFDDMEIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Guid PHAMLENOBDP;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Task<(CDPIDOPDCID, Task)> GBALFINANAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x700E1C0", Offset = "0x700D1C0", VA = "0x18700E1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x42CFE70", Offset = "0x42CEE70", VA = "0x1842CFE70")]
	public BJEFPMHLDDL(BHKONILDDPB IEJFDDMEIPF, Guid PHAMLENOBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x700E170", Offset = "0x700D170", VA = "0x18700E170")]
	public TaskAwaiter<(CDPIDOPDCID, Task)> KJJJNEGPHHP()
	{
		return default(TaskAwaiter<(CDPIDOPDCID, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x700E0A0", Offset = "0x700D0A0", VA = "0x18700E0A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct GHCLCFIJGKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly TaskCompletionSource<(CDPIDOPDCID, Task)> IMLMDFOGNFF;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Task<(CDPIDOPDCID, Task)> GBALFINANAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x70197A0", Offset = "0x70187A0", VA = "0x1870197A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7019870", Offset = "0x7018870", VA = "0x187019870")]
	public GHCLCFIJGKE(TimeSpan AOBFBAOECKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7019700", Offset = "0x7018700", VA = "0x187019700")]
	public void HMKDBFOCIFH(Task IGHFBOKMDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x70197E0", Offset = "0x70187E0", VA = "0x1870197E0")]
	public void OKINJMMHOGD(CDPIDOPDCID DIGFOPCJPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x70196B0", Offset = "0x70186B0", VA = "0x1870196B0")]
	public void GKGBFACFAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7019620", Offset = "0x7018620", VA = "0x187019620")]
	internal void DJIMLHBINCK(string KKHEHGHPOAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class FFFOEAOFNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class DLAILOKOPKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public LHGODKBPKKI subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public DLAILOKOPKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x70159A0", Offset = "0x70149A0", VA = "0x1870159A0")]
		internal bool PCGDAHNHGDH(NGELDFKPLFG s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7017630", Offset = "0x7016630", VA = "0x187017630")]
	public static BJEHJDLGDFO EAPGIKBOING(long MKMCNPGABHO, long KNEHMNKKPOH, string GJLGNAADPEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x70176C0", Offset = "0x70166C0", VA = "0x1870176C0")]
	public static BJEHJDLGDFO EAPGIKBOING(long MKMCNPGABHO, long KNEHMNKKPOH, KIDKIHLFPDC LDGJIBHMHDH, long FCIOGEHFGHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7017270", Offset = "0x7016270", VA = "0x187017270")]
	public static BJEHJDLGDFO EAPGIKBOING(ODCIKMCBEPK EEIFLMBEEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7017400", Offset = "0x7016400", VA = "0x187017400")]
	public static BJEHJDLGDFO EAPGIKBOING(AFJNCMKOAEB LLMNCOFHIKO, LHGODKBPKKI BBOEGEFGLHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7017910", Offset = "0x7016910", VA = "0x187017910")]
	public static BJEHJDLGDFO FKCMOBIHDDC(this BJEHJDLGDFO KLINFCCHIED, AFJNCMKOAEB NCFLMKLKCIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7017780", Offset = "0x7016780", VA = "0x187017780")]
	public static BJEHJDLGDFO EMMKICIEBCC(this BJEHJDLGDFO KLINFCCHIED, LHGODKBPKKI IJNBBEAEMFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.NoEngine.Common.Preserve]
internal class IKICGMAFEJA : FMILMIMGGOO, KABDBBKMGKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct LDNDEIJDKIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public IKICGMAFEJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x701E6D0", Offset = "0x701D6D0", VA = "0x18701E6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x701ED60", Offset = "0x701DD60", VA = "0x18701ED60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly AIBHHEDLNAL DCPNLHLCFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private string AJCEFNMDGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Task KCHIIJIMAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private FPLMJHIKMFP ICDIIGEJPGM;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool EMGJIFBNLDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x701AE90", Offset = "0x7019E90", VA = "0x18701AE90", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Task FABPMDNPIKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x701AEC0", Offset = "0x7019EC0", VA = "0x18701AEC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x855820", Offset = "0x854820", VA = "0x180855820", Slot = "7")]
	public void LFNNOPDGNGK(FPLMJHIKMFP ICDIIGEJPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x701AF50", Offset = "0x7019F50", VA = "0x18701AF50", Slot = "6")]
	public void HIOIIMFOBLH(Task FGPHJGHMKNM, string MANNLACDIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x701B0B0", Offset = "0x701A0B0", VA = "0x18701B0B0")]
	[AsyncStateMachine(typeof(LDNDEIJDKIK))]
	private Task KAAGOPNPAHL(Task GGMBCHLBGNH, string MANNLACDIJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x701B1D0", Offset = "0x701A1D0", VA = "0x18701B1D0")]
	public IKICGMAFEJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class IINNIECNOOB : BCEHKEGFECJ, KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool LAFJKHKPJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private NBGCBMENGBP FEEMJCIIMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private EIHCBOIGFHH PIKFDLICNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private BHNDCJDEGBI IOPKIGDDBDF;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public NBGCBMENGBP KPKCHDNJNPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x701ACA0", Offset = "0x7019CA0", VA = "0x18701ACA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x701AD10", Offset = "0x7019D10", VA = "0x18701AD10", Slot = "7")]
	public void LFNNOPDGNGK(FPLMJHIKMFP ICDIIGEJPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x701AAF0", Offset = "0x7019AF0", VA = "0x18701AAF0", Slot = "5")]
	public void IJPEMHHFMOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x701A9F0", Offset = "0x70199F0", VA = "0x18701A9F0", Slot = "6")]
	public void MAMDJAKFMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x701AA30", Offset = "0x7019A30", VA = "0x18701AA30")]
	private Task GGLPDKNKJBL(JFLCNCOMOGB PGMBMLICCAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x701A9F0", Offset = "0x70199F0", VA = "0x18701A9F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public IINNIECNOOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class KAIGPNCDELO : BHNDCJDEGBI
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class IDBNBBDFNEI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly GFDNMDGANLI NDHCAOHMMME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly string GMFCIHEFPPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly T KCDEJIJHLPJ;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public T JMEAFIDIDGF
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x8A3710", Offset = "0x8A2710", VA = "0x1808A3710")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3EB92D0", Offset = "0x3EB82D0", VA = "0x183EB92D0")]
		public IDBNBBDFNEI(GFDNMDGANLI NDHCAOHMMME, string GMFCIHEFPPO, T KCDEJIJHLPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8E10", Offset = "0x3EB7E10", VA = "0x183EB8E10")]
		private void JOLGOJKNGKI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly GFDNMDGANLI NDHCAOHMMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly IDBNBBDFNEI<TimeSpan> KLFIHAHJHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly IDBNBBDFNEI<TimeSpan> JJGMNMMIMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly IDBNBBDFNEI<TimeSpan> HPBGFCIIDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly IDBNBBDFNEI<TimeSpan> MKALEGAFAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly IDBNBBDFNEI<bool> HLEIGBIHGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly IDBNBBDFNEI<bool> OMNMONMDFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly IDBNBBDFNEI<bool> CKAGCBAIEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly IDBNBBDFNEI<int> FHEGIDCEBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly IDBNBBDFNEI<bool> KDFHBIMGIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly IDBNBBDFNEI<bool> PKKFGELMGNK;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public TimeSpan NEBLFEOMONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x701D7D0", Offset = "0x701C7D0", VA = "0x18701D7D0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public TimeSpan AKBENIHFIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x701D850", Offset = "0x701C850", VA = "0x18701D850", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public TimeSpan KDAFCCGLJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x701D810", Offset = "0x701C810", VA = "0x18701D810", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public TimeSpan BBNHHHCOGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x701D790", Offset = "0x701C790", VA = "0x18701D790", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool EADBGGFCOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x701D890", Offset = "0x701C890", VA = "0x18701D890", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool FKJKAHOMBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x701D910", Offset = "0x701C910", VA = "0x18701D910", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool MCGKBBPHLCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x701D6D0", Offset = "0x701C6D0", VA = "0x18701D6D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int FFLMLMIAIBC
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x701D750", Offset = "0x701C750", VA = "0x18701D750", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool DNJJEDAIHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x701D8D0", Offset = "0x701C8D0", VA = "0x18701D8D0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool MPJMNKGKMAD
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x701D710", Offset = "0x701C710", VA = "0x18701D710", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x701D950", Offset = "0x701C950", VA = "0x18701D950")]
	[UnityEngine.Scripting.Preserve]
	public KAIGPNCDELO([JONIFKKOOAA(null)] GFDNMDGANLI NDHCAOHMMME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal class NNBNLLDDDMP : FFANMCAACBH, KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class DEEFCIEOPOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public HHPMLGFPHIL roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public DEEFCIEOPOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7014BD0", Offset = "0x7013BD0", VA = "0x187014BD0")]
		internal object ACLMLHCCJBP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action BCEOOODPNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7022D60", Offset = "0x7021D60", VA = "0x187022D60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x70226B0", Offset = "0x70216B0", VA = "0x1870226B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event DMPJHAHAFDA KDDOOKFMOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7022750", Offset = "0x7021750", VA = "0x187022750", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7023080", Offset = "0x7022080", VA = "0x187023080", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event DMPJHAHAFDA CJMBAOGBJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x70228C0", Offset = "0x70218C0", VA = "0x1870228C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7022610", Offset = "0x7021610", VA = "0x187022610", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event DMPJHAHAFDA DIBCCGKLIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7022CC0", Offset = "0x7021CC0", VA = "0x187022CC0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x70227F0", Offset = "0x70217F0", VA = "0x1870227F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<FAICFABDAGI, bool> ADLFJCKGPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7022C10", Offset = "0x7021C10", VA = "0x187022C10", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7022B60", Offset = "0x7021B60", VA = "0x187022B60", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "19")]
	public void LFNNOPDGNGK(FPLMJHIKMFP ICDIIGEJPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7022E30", Offset = "0x7021E30", VA = "0x187022E30", Slot = "14")]
	public void OLANCFICNDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7022890", Offset = "0x7021890", VA = "0x187022890", Slot = "15")]
	public void FMJPNGBLPHN(HHPMLGFPHIL EEMEFKGLBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7022B30", Offset = "0x7021B30", VA = "0x187022B30", Slot = "16")]
	public void HGCHLDDKLIG(HHPMLGFPHIL EEMEFKGLBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7022E00", Offset = "0x7021E00", VA = "0x187022E00", Slot = "17")]
	public void OGIMGPIBOAC(HHPMLGFPHIL EEMEFKGLBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7023030", Offset = "0x7022030", VA = "0x187023030", Slot = "18")]
	public void PHLPNPAOIKJ(FAICFABDAGI HJBPLFIGHKM, bool ADMMLGCNPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7022960", Offset = "0x7021960", VA = "0x187022960")]
	private void GHKHNOGELCE(DMPJHAHAFDA ANPILJCEKDH, HHPMLGFPHIL EEMEFKGLBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public NNBNLLDDDMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[UnityEngine.Scripting.Preserve]
internal class ACIGDDCMKCL : PDMELBICMOC, KABDBBKMGKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct CBGMKJELHFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public ACIGDDCMKCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7013CB0", Offset = "0x7012CB0", VA = "0x187013CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7014190", Offset = "0x7013190", VA = "0x187014190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct EBDOFJBAAEE : IAsyncStateMachine
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
		public ACIGDDCMKCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7015F00", Offset = "0x7014F00", VA = "0x187015F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7016560", Offset = "0x7015560", VA = "0x187016560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class JPPKOBGBOMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public JPPKOBGBOMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x701D660", Offset = "0x701C660", VA = "0x18701D660")]
		internal object BEFMLKHOONM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct NDJDADIMCDC : IAsyncStateMachine
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
		public ACIGDDCMKCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private JPPKOBGBOMF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7020C60", Offset = "0x701FC60", VA = "0x187020C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x70213B0", Offset = "0x70203B0", VA = "0x1870213B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class FFGMCCDIJFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public FFGMCCDIJFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7017A00", Offset = "0x7016A00", VA = "0x187017A00")]
		internal object DEOMLCJLDED()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private FPLMJHIKMFP ICDIIGEJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private ICFBHJEIGMP LCGMLIBOFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private NPIEJOEOFDN[] JGHPDINFGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private CancellationTokenSource DJMJNBDHLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private int HMHGKNCDDDJ;

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x700CF20", Offset = "0x700BF20", VA = "0x18700CF20", Slot = "6")]
	public void LFNNOPDGNGK(FPLMJHIKMFP ICDIIGEJPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x700C860", Offset = "0x700B860", VA = "0x18700C860", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x700C630", Offset = "0x700B630", VA = "0x18700C630", Slot = "8")]
	public void BCGNNIMMKEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x700CFA0", Offset = "0x700BFA0", VA = "0x18700CFA0", Slot = "5")]
	public void NAOLMLAPOLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x700C870", Offset = "0x700B870", VA = "0x18700C870", Slot = "4")]
	[AsyncStateMachine(typeof(CBGMKJELHFP))]
	public Task EIMAOALOEDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x700CB20", Offset = "0x700BB20", VA = "0x18700CB20")]
	private void JJHCCKPGKNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x700CA20", Offset = "0x700BA20", VA = "0x18700CA20")]
	[AsyncStateMachine(typeof(EBDOFJBAAEE))]
	private Task JDNCOHECMKN(CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x700C4F0", Offset = "0x700B4F0", VA = "0x18700C4F0")]
	[AsyncStateMachine(typeof(NDJDADIMCDC))]
	private Task<bool> AHMLPBINOMI(int HCALFJOJKJO, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x700CE40", Offset = "0x700BE40", VA = "0x18700CE40")]
	private void KLGNJBNLEAI(int HCALFJOJKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x700C940", Offset = "0x700B940", VA = "0x18700C940")]
	private void GBHMHKLJILM(int HCALFJOJKJO, bool ADMMLGCNPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x700C730", Offset = "0x700B730", VA = "0x18700C730")]
	private void DDENJEJBJIE(int HCALFJOJKJO, Exception APIEMOLNMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x700D070", Offset = "0x700C070", VA = "0x18700D070")]
	private void OPDIMGOOBFG(CancellationToken LABHBAHABKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public ACIGDDCMKCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.NoEngine.Common.Preserve]
internal class PDOEKDCHAMK : HNNBOBPPOPF, KABDBBKMGKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct MEENOOFECAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public PJAFGDKDHNF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public PDOEKDCHAMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public EPELMGABJHE customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x701F3B0", Offset = "0x701E3B0", VA = "0x18701F3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x701FD10", Offset = "0x701ED10", VA = "0x18701FD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct GDBPOCOMGDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public PDOEKDCHAMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public PJAFGDKDHNF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public EPELMGABJHE customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private KLCBNGOGDPF<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private KNFEKPELEMG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private MFFPJJNLNNN <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private JIKOCFMECDG <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7017FD0", Offset = "0x7016FD0", VA = "0x187017FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7018C60", Offset = "0x7017C60", VA = "0x187018C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class FHMHHMCABEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Matchmaking.PDCLGBLFFHK result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public PLDMJLNJFKP errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public FHMHHMCABEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7017A70", Offset = "0x7016A70", VA = "0x187017A70")]
		internal object BILPILLONPP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class JECKEEJFGKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public Task<BJEHJDLGDFO> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public JECKEEJFGKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		internal Task<BJEHJDLGDFO> LLMELEBOLHM(KLCBNGOGDPF<string>.BPJNBAPCFPO _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct BKACDPCMIMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public PDOEKDCHAMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public PJAFGDKDHNF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public EPELMGABJHE customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public MFFPJJNLNNN joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private JECKEEJFGKJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private APGNEMKOEFL <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private KNFEKPELEMG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private FBMPPIILJHC <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private Task<Matchmaking.FEMMGOOLEIE> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private BOEALMGEOOL <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.FEMMGOOLEIE> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter<BJEHJDLGDFO> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x700E290", Offset = "0x700D290", VA = "0x18700E290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7013C50", Offset = "0x7012C50", VA = "0x187013C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct NDONIHCOKLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public PDOEKDCHAMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <disconnectTimerScope>5__3;

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
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7021420", Offset = "0x7020420", VA = "0x187021420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7021E70", Offset = "0x7020E70", VA = "0x187021E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct AGBLPJBFHCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public PDOEKDCHAMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private NDJGECDCBMH <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x700D230", Offset = "0x700C230", VA = "0x18700D230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x700D6A0", Offset = "0x700C6A0", VA = "0x18700D6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct PHNNAENOHOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder<Matchmaking.FEMMGOOLEIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public PJAFGDKDHNF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public PDOEKDCHAMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter<Matchmaking.FEMMGOOLEIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7029D60", Offset = "0x7028D60", VA = "0x187029D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x702A260", Offset = "0x7029260", VA = "0x18702A260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct GENKKMCNEHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Matchmaking.FEMMGOOLEIE serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public PDOEKDCHAMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public MFFPJJNLNNN joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter<DCBJOBNAKBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7018CC0", Offset = "0x7017CC0", VA = "0x187018CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x70193C0", Offset = "0x70183C0", VA = "0x1870193C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class GGJDGHODMPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public PJAFGDKDHNF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public GGJDGHODMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7019420", Offset = "0x7018420", VA = "0x187019420")]
		internal object DCDHHLFMLFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7019520", Offset = "0x7018520", VA = "0x187019520")]
		internal string GDDLNDOCICA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct IPGPAFMPKHB : IAsyncStateMachine
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
		public PJAFGDKDHNF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public PDOEKDCHAMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private GGJDGHODMPN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private KNFEKPELEMG <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x701B260", Offset = "0x701A260", VA = "0x18701B260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x701BE30", Offset = "0x701AE30", VA = "0x18701BE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct IBFDKLCMKEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public PDOEKDCHAMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public MFFPJJNLNNN joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public BJEHJDLGDFO initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public PJAFGDKDHNF targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public APGNEMKOEFL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x701A080", Offset = "0x7019080", VA = "0x18701A080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x701A990", Offset = "0x7019990", VA = "0x18701A990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct PBIMDBMBPLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public PDOEKDCHAMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private KNFEKPELEMG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap3;

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

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x70243C0", Offset = "0x70233C0", VA = "0x1870243C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7025A00", Offset = "0x7024A00", VA = "0x187025A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct DIGDJEFCGON : IAsyncStateMachine
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
		public MJKPLCNHABA localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public PDOEKDCHAMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter<CDPIDOPDCID> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x70151D0", Offset = "0x70141D0", VA = "0x1870151D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7015940", Offset = "0x7014940", VA = "0x187015940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class HEBGGKHKKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public PJAFGDKDHNF targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public HEBGGKHKKPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7019A00", Offset = "0x7018A00", VA = "0x187019A00")]
		internal object PNEFIFNAOJL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class PAHNJMPKGGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public PAHNJMPKGGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7024320", Offset = "0x7023320", VA = "0x187024320")]
		internal void OINOOOLLCIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class MMCEGOFJENA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public PJAFGDKDHNF targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public MMCEGOFJENA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x701FEE0", Offset = "0x701EEE0", VA = "0x18701FEE0")]
		internal object GKEOGEJFHLB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class IKBIAGMPIFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public PJAFGDKDHNF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public IKBIAGMPIFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x703A0C0", Offset = "0x70390C0", VA = "0x18703A0C0")]
		internal string LHPGHMPBDJN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly PHLKHBEJKKB MFNNKEFDCNH;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly PHLKHBEJKKB ANNAFDLJGMA;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly PHLKHBEJKKB IDGFLCEAGPL;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string EBMKCJHCMPI;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string FFJDGKPEJJF;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly string JOKJAAGLOGM;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly Guid PBGEHGPGMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private IOEEDLJNEAH CNHDNJOLLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private AAMEEHEGCAA PENPFHPHPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private EIHCBOIGFHH PIKFDLICNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private FPLMJHIKMFP ICDIIGEJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private ICFBHJEIGMP LCGMLIBOFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private PDMELBICMOC DOCFNIMHOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private FMILMIMGGOO MEEDMOGLOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private FFANMCAACBH PHHCGKEOFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private EJFHNNKMENL INFKAKPFJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private OBJJHCDEKJJ JEHMBKNGONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private IDisposable OFLMAOPNKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private OBLJMEGKEJC CIEJPPJPNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly AIBHHEDLNAL NFALBAPEPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private BOEALMGEOOL LJOOKNLFBBI;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public TaskStatus CIBPOOFAAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x879460", Offset = "0x878460", VA = "0x180879460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xBA4E70", Offset = "0xBA3E70", VA = "0x180BA4E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private IIBKIJCPLOJ AGEBIJJODLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7025ED0", Offset = "0x7024ED0", VA = "0x187025ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7028080", Offset = "0x7027080", VA = "0x187028080", Slot = "6")]
	public void LFNNOPDGNGK(FPLMJHIKMFP ICDIIGEJPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x70268F0", Offset = "0x70258F0", VA = "0x1870268F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7029130", Offset = "0x7028130", VA = "0x187029130", Slot = "5")]
	[AsyncStateMachine(typeof(MEENOOFECAF))]
	public Task OFJNJJEGOFN(PJAFGDKDHNF MLOEGMNAALP, EPELMGABJHE GIFNLGAIOPP, CancellationToken CKFCHGJKDBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x70267A0", Offset = "0x70257A0", VA = "0x1870267A0")]
	[AsyncStateMachine(typeof(GDBPOCOMGDN))]
	private Task DOHOBGBJFBJ(PJAFGDKDHNF MLOEGMNAALP, EPELMGABJHE GIFNLGAIOPP, CancellationToken CKFCHGJKDBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7026940", Offset = "0x7025940", VA = "0x187026940")]
	private void EIOMDKJLAHA(EJFHNNKMENL INFKAKPFJBL, PJAFGDKDHNF MLOEGMNAALP, Exception APIEMOLNMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x70283B0", Offset = "0x70273B0", VA = "0x1870283B0")]
	private static void LKHLGKIMAJM(JIKOCFMECDG GNBDMBJFDHH, Exception APIEMOLNMPG, [Optional] List<int> KPIBKHDKOMH, int HMHGKNCDDDJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7027AB0", Offset = "0x7026AB0", VA = "0x187027AB0")]
	[AsyncStateMachine(typeof(BKACDPCMIMJ))]
	private Task JNECDALPBHE(KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, PJAFGDKDHNF MLOEGMNAALP, EPELMGABJHE GIFNLGAIOPP, MFFPJJNLNNN ENOODDOBHDF, CancellationToken CKFCHGJKDBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7025CF0", Offset = "0x7024CF0", VA = "0x187025CF0")]
	private void AHKCEAOOBGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x70261C0", Offset = "0x70251C0", VA = "0x1870261C0")]
	[AsyncStateMachine(typeof(NDONIHCOKLA))]
	private Task CKPPBKJPEHE(KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7026470", Offset = "0x7025470", VA = "0x187026470")]
	private void DJLEFGIDCCK(PJAFGDKDHNF MLOEGMNAALP, CancellationToken CKFCHGJKDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7027880", Offset = "0x7026880", VA = "0x187027880")]
	private void JMLJJKBMPGI(PJAFGDKDHNF MLOEGMNAALP, MFFPJJNLNNN ENOODDOBHDF, OperationCanceledException EDJNNCPGGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7028D70", Offset = "0x7027D70", VA = "0x187028D70")]
	private void MLINAGJMOAH(PJAFGDKDHNF MLOEGMNAALP, MFFPJJNLNNN ENOODDOBHDF, Exception APIEMOLNMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7026E00", Offset = "0x7025E00", VA = "0x187026E00")]
	private void EMOPLJLLFFP(PJAFGDKDHNF MLOEGMNAALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7028FA0", Offset = "0x7027FA0", VA = "0x187028FA0")]
	private static HHPMLGFPHIL MLKFGBLONGG(PJAFGDKDHNF MLOEGMNAALP)
	{
		return default(HHPMLGFPHIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7029060", Offset = "0x7028060", VA = "0x187029060")]
	[AsyncStateMachine(typeof(AGBLPJBFHCC))]
	private Task NOBAFCCCPEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7026060", Offset = "0x7025060", VA = "0x187026060")]
	[AsyncStateMachine(typeof(PHNNAENOHOA))]
	private Task<Matchmaking.FEMMGOOLEIE> BIBNJHLFOEO(PJAFGDKDHNF MLOEGMNAALP, KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7028C60", Offset = "0x7027C60", VA = "0x187028C60")]
	private static DCBJOBNAKBI MHMJLBHAPFO(Matchmaking.FEMMGOOLEIE KDDPEAKEACH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7027010", Offset = "0x7026010", VA = "0x187027010")]
	[AsyncStateMachine(typeof(GENKKMCNEHJ))]
	private Task FADOMCALNCD(Matchmaking.FEMMGOOLEIE KDDPEAKEACH, MFFPJJNLNNN ENOODDOBHDF, KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, CancellationToken DIAJBCBNAGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7025F20", Offset = "0x7024F20", VA = "0x187025F20")]
	[AsyncStateMachine(typeof(IPGPAFMPKHB))]
	private Task BEBMAJKLMBA(PJAFGDKDHNF MLOEGMNAALP, CancellationTokenSource HNBPHMEFCMM, Task CPDFOHCFFIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x7027250", Offset = "0x7026250", VA = "0x187027250")]
	[AsyncStateMachine(typeof(IBFDKLCMKEA))]
	private Task GNAOFFBGMLA(BJEHJDLGDFO OMAGDACDENP, APGNEMKOEFL IAIDAFICOOB, PJAFGDKDHNF CKKPPAPCDDH, MFFPJJNLNNN KOOLIJEGMGP, KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, CancellationToken CEJPNGKCBGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x70273C0", Offset = "0x70263C0", VA = "0x1870273C0")]
	private MFFPJJNLNNN GOHIEOMCFGG(MFFPJJNLNNN KOOLIJEGMGP, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7027750", Offset = "0x7026750", VA = "0x187027750")]
	[AsyncStateMachine(typeof(PBIMDBMBPLK))]
	private Task JIJBOPGBPHJ(KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7027F50", Offset = "0x7026F50", VA = "0x187027F50")]
	[AsyncStateMachine(typeof(DIGDJEFCGON))]
	private Task LAJIMJFKNLK(CancellationToken LABHBAHABKB, int FLDOALLBIIP, MJKPLCNHABA NIPKIEGBLMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x70262F0", Offset = "0x70252F0", VA = "0x1870262F0")]
	private static void DIGGBPAECJB(PJAFGDKDHNF MLOEGMNAALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7029270", Offset = "0x7028270", VA = "0x187029270")]
	private void PHACFOHLCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7025E40", Offset = "0x7024E40", VA = "0x187025E40")]
	private void ALBOAKKAOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7027C10", Offset = "0x7026C10", VA = "0x187027C10")]
	private void KDIGHNMICFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x70276C0", Offset = "0x70266C0", VA = "0x1870276C0")]
	private void JBMMFLOAAEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7027160", Offset = "0x7026160", VA = "0x187027160")]
	private static void GIPIKICIKFH(PJAFGDKDHNF MLOEGMNAALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x70275B0", Offset = "0x70265B0", VA = "0x1870275B0")]
	private static CancellationTokenRegistration HEAHIDCGPED(PJAFGDKDHNF MLOEGMNAALP, CancellationToken DIAJBCBNAGO)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7027CA0", Offset = "0x7026CA0", VA = "0x187027CA0")]
	private static void KKDEDJKEOBA(PJAFGDKDHNF MLOEGMNAALP, Exception APIEMOLNMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7027DA0", Offset = "0x7026DA0", VA = "0x187027DA0")]
	private void KNFAFEADPFK(PJAFGDKDHNF MLOEGMNAALP, Task CPDFOHCFFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7026DA0", Offset = "0x7025DA0", VA = "0x187026DA0")]
	private static void ELCBEGJPMKG(Func<string> HHIJHJEKJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x70296D0", Offset = "0x70286D0", VA = "0x1870296D0")]
	public PDOEKDCHAMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x7029000", Offset = "0x7028000", VA = "0x187029000")]
	[CompilerGenerated]
	internal static (int, int?) MPCGNMDMDBG(PLDMJLNJFKP CMBMLLGKBPM)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class HIMPPGJGFIJ : IJCGBJPCBMP, KABDBBKMGKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct MIBAIGIDBLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public HIMPPGJGFIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public MJKPLCNHABA localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7044C70", Offset = "0x7043C70", VA = "0x187044C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x70450E0", Offset = "0x70440E0", VA = "0x1870450E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class GNBMMNKLAKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public HIMPPGJGFIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public MJKPLCNHABA localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public GNBMMNKLAKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x70363D0", Offset = "0x70353D0", VA = "0x1870363D0")]
		internal List<Task> ECMFEMMMOGN(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct PIILNFIDGME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public HENJJIMFCAP taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public MJKPLCNHABA localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x704A2F0", Offset = "0x70492F0", VA = "0x18704A2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x704A680", Offset = "0x7049680", VA = "0x18704A680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct FJKALKHJHKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public HIMPPGJGFIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x70314F0", Offset = "0x70304F0", VA = "0x1870314F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x70317B0", Offset = "0x70307B0", VA = "0x1870317B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly HashSet<HENJJIMFCAP> JMEKMKNHNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private AAMEEHEGCAA PENPFHPHPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private FPLMJHIKMFP ICDIIGEJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private ACLAJEAKFDA LFNAJKNODBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private ECAKNBCPLHD IDNGKPKDEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private IDisposable OFLMAOPNKOB;

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7038870", Offset = "0x7037870", VA = "0x187038870", Slot = "5")]
	public void LFNNOPDGNGK(FPLMJHIKMFP ICDIIGEJPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7037FF0", Offset = "0x7036FF0", VA = "0x187037FF0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7038070", Offset = "0x7037070", VA = "0x187038070", Slot = "4")]
	public bool FFGFPHFEIPI(HENJJIMFCAP JJFJLFJKLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7038B70", Offset = "0x7037B70", VA = "0x187038B70")]
	private void PBKJPLBALIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7037DD0", Offset = "0x7036DD0", VA = "0x187037DD0")]
	private void DDKBKICPNLE(PEJDOCBEAIB KBAPBJOHBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7037C30", Offset = "0x7036C30", VA = "0x187037C30")]
	[AsyncStateMachine(typeof(MIBAIGIDBLK))]
	private Task AHCNJFHIABI(int FLDOALLBIIP, MJKPLCNHABA NIPKIEGBLMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x70380D0", Offset = "0x70370D0", VA = "0x1870380D0")]
	private Func<CancellationToken, List<Task>> HPNFJAKEIHL(int FLDOALLBIIP, MJKPLCNHABA NIPKIEGBLMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7038390", Offset = "0x7037390", VA = "0x187038390")]
	private List<Task> KMOKGJLCMAM(int FLDOALLBIIP, MJKPLCNHABA NIPKIEGBLMM, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x70381A0", Offset = "0x70371A0", VA = "0x1870381A0")]
	[AsyncStateMachine(typeof(PIILNFIDGME))]
	private Task IGAEGCOMDGK(HENJJIMFCAP LNCBFFLCGKM, CancellationToken DJIBMMAIGPE, int FLDOALLBIIP, MJKPLCNHABA NIPKIEGBLMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x70382C0", Offset = "0x70372C0", VA = "0x1870382C0")]
	[AsyncStateMachine(typeof(FJKALKHJHKA))]
	private Task JLOLHAHFDNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7037D20", Offset = "0x7036D20", VA = "0x187037D20")]
	private void BCGNNIMMKEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x7038C40", Offset = "0x7037C40", VA = "0x187038C40")]
	public HIMPPGJGFIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[UnityEngine.Scripting.Preserve]
internal sealed class CKAOAGMJLLN : BHKONILDDPB, KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class NHBOEALGLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public NHBOEALGLPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7046D30", Offset = "0x7045D30", VA = "0x187046D30")]
		internal object EKJIBHGKCIH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class DJOIPNNMKJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public DJOIPNNMKJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x702F540", Offset = "0x702E540", VA = "0x18702F540")]
		internal object BCEGGKNLONM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class OPOFCOPEAEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public OPOFCOPEAEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class CHIFGDDIHCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public CHIFGDDIHCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x702C7E0", Offset = "0x702B7E0", VA = "0x18702C7E0")]
		internal object HDLEOHBCJJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class EAMLOANIACM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public EAMLOANIACM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x702F720", Offset = "0x702E720", VA = "0x18702F720")]
		internal object OBKBDCAPFJP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly Dictionary<Guid, GHCLCFIJGKE> IEJFDDMEIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly TimeSpan ANOONDANJAM;

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "9")]
	public void LFNNOPDGNGK(FPLMJHIKMFP ICDIIGEJPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x702DB40", Offset = "0x702CB40", VA = "0x18702DB40", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x702DD60", Offset = "0x702CD60", VA = "0x18702DD60", Slot = "4")]
	public BJEFPMHLDDL GKAGDNHKNII(Guid PHAMLENOBDP)
	{
		return default(BJEFPMHLDDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x702DB50", Offset = "0x702CB50", VA = "0x18702DB50", Slot = "5")]
	public bool FFDBNDOHLIO(Guid PHAMLENOBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x702E220", Offset = "0x702D220", VA = "0x18702E220", Slot = "6")]
	public bool MMBJCCJOEFF(Guid PHAMLENOBDP, Task IGHFBOKMDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x702E550", Offset = "0x702D550", VA = "0x18702E550", Slot = "7")]
	public bool PACGLAJGIFE(Guid PHAMLENOBDP, CDPIDOPDCID DIGFOPCJPDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x702E1B0", Offset = "0x702D1B0", VA = "0x18702E1B0", Slot = "8")]
	public Task<(CDPIDOPDCID, Task)> MCBMMGNPFNN(Guid PHAMLENOBDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x702DF80", Offset = "0x702CF80", VA = "0x18702DF80")]
	private void HDOIBHNPIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x702E730", Offset = "0x702D730", VA = "0x18702E730")]
	public CKAOAGMJLLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.NoEngine.Common.Preserve]
internal class FPBCMHPLIOJ : ILNMIHADCPN, KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private class DDPIBMCCHDL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private readonly PJAFGDKDHNF OKDGJEEFKMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private readonly CancellationTokenSource DJMJNBDHLHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public readonly CancellationToken JHMMBMAJEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private bool PLMNOHJHGDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private bool IHDIIKNEDCC;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x702E970", Offset = "0x702D970", VA = "0x18702E970")]
		public DDPIBMCCHDL(PJAFGDKDHNF OKDGJEEFKMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x702E7F0", Offset = "0x702D7F0", VA = "0x18702E7F0")]
		public void BCGNNIMMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x702E940", Offset = "0x702D940", VA = "0x18702E940", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class AKKOANFLAGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public JFLCNCOMOGB disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public AKKOANFLAGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x702B7E0", Offset = "0x702A7E0", VA = "0x18702B7E0")]
		internal object GJMCEIIBFKA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct KIDMCNHGDBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public JFLCNCOMOGB disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public FPBCMHPLIOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x703ED50", Offset = "0x703DD50", VA = "0x18703ED50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x703F100", Offset = "0x703E100", VA = "0x18703F100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class FHBNODMCMHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public FHBNODMCMHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7031480", Offset = "0x7030480", VA = "0x187031480")]
		internal object BNFJDHFADHM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct JINLNKEDCJL : IAsyncStateMachine
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
		public FPBCMHPLIOJ <>4__this;

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
		private KNFEKPELEMG <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x703C1B0", Offset = "0x703B1B0", VA = "0x18703C1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class MHNHMACLFGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public PJAFGDKDHNF newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public MHNHMACLFGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7044BD0", Offset = "0x7043BD0", VA = "0x187044BD0")]
		internal object POFGEDGMKAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7044B50", Offset = "0x7043B50", VA = "0x187044B50")]
		internal object FLECALNGLHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7044B90", Offset = "0x7043B90", VA = "0x187044B90")]
		internal object PNGPCLADOJB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class GBILGJDPKGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public GBILGJDPKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7032CD0", Offset = "0x7031CD0", VA = "0x187032CD0")]
		internal void EKPBIAAHFAH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct EIICLHINCKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public PJAFGDKDHNF newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public FPBCMHPLIOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public EPELMGABJHE customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private MHNHMACLFGN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private KNFEKPELEMG <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x702FA40", Offset = "0x702EA40", VA = "0x18702FA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x70309C0", Offset = "0x702F9C0", VA = "0x1870309C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly PMJGCDHIKCF.ODPAHMCMJPD JLEDKDMLIIE;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly IAPDJFOCNPM JBDPHEAJJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private AAMEEHEGCAA PENPFHPHPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private FPLMJHIKMFP ICDIIGEJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private PDMELBICMOC DOCFNIMHOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private ICFBHJEIGMP LCGMLIBOFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private BHNDCJDEGBI IOPKIGDDBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private HNNBOBPPOPF JGFEBJKHLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private PJAFGDKDHNF HMBPFGHNGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private DDPIBMCCHDL DIOEKBJMMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private bool AMNEKEOCLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private Task BLOIGBFGFEJ;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private IIBKIJCPLOJ AGEBIJJODLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x70318E0", Offset = "0x70308E0", VA = "0x1870318E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool JADKMBFDHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9F1E90", Offset = "0x9F0E90", VA = "0x1809F1E90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x70321C0", Offset = "0x70311C0", VA = "0x1870321C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x70323E0", Offset = "0x70313E0", VA = "0x1870323E0", Slot = "4")]
	public void LFNNOPDGNGK(FPLMJHIKMFP ICDIIGEJPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7031D40", Offset = "0x7030D40", VA = "0x187031D40", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x70321D0", Offset = "0x70311D0", VA = "0x1870321D0")]
	[AsyncStateMachine(typeof(KIDMCNHGDBM))]
	private Task JCKMMLADGFG(JFLCNCOMOGB PAKCIFACNHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7032700", Offset = "0x7031700", VA = "0x187032700")]
	private void OAGHLHLDNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7031EB0", Offset = "0x7030EB0", VA = "0x187031EB0")]
	private void EKOCADGNMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7032040", Offset = "0x7031040", VA = "0x187032040")]
	private void FNDAPMNFPLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7032680", Offset = "0x7031680", VA = "0x187032680")]
	private bool MIMJNEFFOHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7031810", Offset = "0x7030810", VA = "0x187031810")]
	[AsyncStateMachine(typeof(JINLNKEDCJL))]
	private void ABJBFOPLFIB(int NAOBJALFMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7031930", Offset = "0x7030930", VA = "0x187031930")]
	private void CKOBCNOCICM([Out] IDisposable JEEFMLKGMPB, [Out] IDisposable FNIGPKIGAKK, [Out] IDisposable BIKHNBIBHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x70322C0", Offset = "0x70312C0", VA = "0x1870322C0")]
	private bool LBJIFALHAPN(PJAFGDKDHNF OKDGJEEFKMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7031BC0", Offset = "0x7030BC0", VA = "0x187031BC0")]
	private void DGOPCLDKHEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7031C10", Offset = "0x7030C10", VA = "0x187031C10")]
	[AsyncStateMachine(typeof(EIICLHINCKF))]
	private Task DOHOBGBJFBJ(PJAFGDKDHNF OKDGJEEFKMM, EPELMGABJHE GIFNLGAIOPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7032C60", Offset = "0x7031C60", VA = "0x187032C60")]
	public FPBCMHPLIOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[UnityEngine.Scripting.Preserve]
internal sealed class NGCNJHEEIBP : NGGKNMPNMDK, KABDBBKMGKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct LPMKDNFHFIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public AsyncTaskMethodBuilder<LDJAJOAAKGC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public NGCNJHEEIBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter<LDJAJOAAKGC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7044060", Offset = "0x7043060", VA = "0x187044060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x70442F0", Offset = "0x70432F0", VA = "0x1870442F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class INBOAMIPHMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public DKMNKHDNIBD message;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public INBOAMIPHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x703A220", Offset = "0x7039220", VA = "0x18703A220")]
		internal object ELAOIGLGFDI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class CCHDBLBGBLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public DKMNKHDNIBD messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public CCHDBLBGBLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x702C520", Offset = "0x702B520", VA = "0x18702C520")]
		internal object AOOGJBHDCLI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class NKIBJODBKFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public DKMNKHDNIBD request;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public NKIBJODBKFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x70471D0", Offset = "0x70461D0", VA = "0x1870471D0")]
		internal object IKMJNBNHIOM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct ICNGPCAKGEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public DKMNKHDNIBD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public NGCNJHEEIBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter<DPOAJAMLBLE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7038CD0", Offset = "0x7037CD0", VA = "0x187038CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7039590", Offset = "0x7038590", VA = "0x187039590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class CDICMKOJPPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public DKMNKHDNIBD operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public CDICMKOJPPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x702C780", Offset = "0x702B780", VA = "0x18702C780")]
		internal object MNFLHCNAINJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct GLKOPFLCCLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public DKMNKHDNIBD operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public NGCNJHEEIBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private MFFPJJNLNNN <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<DKMNKHDNIBD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7035790", Offset = "0x7034790", VA = "0x187035790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7036300", Offset = "0x7035300", VA = "0x187036300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct IDKHLOFJOCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<DPOAJAMLBLE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public NGCNJHEEIBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public DKMNKHDNIBD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private ILMNFDDPJKF.NDICFGEKOHF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private MFFPJJNLNNN <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<DKMNKHDNIBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x70395F0", Offset = "0x70385F0", VA = "0x1870395F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7039B10", Offset = "0x7038B10", VA = "0x187039B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class BBNNJLJLNBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public DPOAJAMLBLE operation;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public BBNNJLJLNBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x702BD70", Offset = "0x702AD70", VA = "0x18702BD70")]
		internal object AJHDAPAOKDL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct ELIDIOJHKPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public DPOAJAMLBLE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public NGCNJHEEIBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private KLCBNGOGDPF<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7030A20", Offset = "0x702FA20", VA = "0x187030A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x7031050", Offset = "0x7030050", VA = "0x187031050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class MNPADKNEJFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public DKMNKHDNIBD request;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public MNPADKNEJFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x70451A0", Offset = "0x70441A0", VA = "0x1870451A0")]
		internal object ONOOCHGGPKG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class MJLDIJFPDBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public DKMNKHDNIBD request;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public MJLDIJFPDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7045140", Offset = "0x7044140", VA = "0x187045140")]
		internal object NFBFAKKGBJA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private FPLMJHIKMFP ICDIIGEJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private FMILMIMGGOO MEEDMOGLOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private DBGBHMBICHB FCCKEPMGBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private POGOLOONGNH BNMKCOAPNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private EIHCBOIGFHH PIKFDLICNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private TaskCompletionSource<LDJAJOAAKGC> NHIDEPJAMEG;

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7046990", Offset = "0x7045990", VA = "0x187046990", Slot = "7")]
	public void LFNNOPDGNGK(FPLMJHIKMFP ICDIIGEJPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7046B90", Offset = "0x7045B90", VA = "0x187046B90", Slot = "6")]
	[AsyncStateMachine(typeof(LPMKDNFHFIP))]
	public Task<LDJAJOAAKGC> PCCPIBPMHKM(CancellationToken NKDFNGHFKJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7046600", Offset = "0x7045600", VA = "0x187046600", Slot = "4")]
	public void JNINGLOAPOK(DKMNKHDNIBD KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7046030", Offset = "0x7045030", VA = "0x187046030", Slot = "5")]
	public void DPEKEDKJDOO(DKMNKHDNIBD LMKKACIOAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7046A80", Offset = "0x7045A80", VA = "0x187046A80")]
	[AsyncStateMachine(typeof(ICNGPCAKGEO))]
	private Task OHCPMJFBJHI(DKMNKHDNIBD HHNBCLDGHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7045980", Offset = "0x7044980", VA = "0x187045980")]
	[AsyncStateMachine(typeof(GLKOPFLCCLG))]
	private Task AABAKEJHHON(DKMNKHDNIBD JLBJNBGNNDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7046390", Offset = "0x7045390", VA = "0x187046390")]
	[AsyncStateMachine(typeof(IDKHLOFJOCO))]
	private Task<DPOAJAMLBLE> FDIPCIHPNFJ(DKMNKHDNIBD HHNBCLDGHCL, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7046CA0", Offset = "0x7045CA0", VA = "0x187046CA0")]
	private MFFPJJNLNNN POADEKBEBLA(DKMNKHDNIBD MBBLEEHOBKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x70464E0", Offset = "0x70454E0", VA = "0x1870464E0")]
	[AsyncStateMachine(typeof(ELIDIOJHKPB))]
	private Task HAIELECIDNA(DPOAJAMLBLE IEHHLNFCIFN, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7045A90", Offset = "0x7044A90", VA = "0x187045A90")]
	private DPOAJAMLBLE CJKAAODEGGE(DKMNKHDNIBD HHNBCLDGHCL, MFFPJJNLNNN NGFBHJIHHDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2D09DA0", Offset = "0x2D08DA0", VA = "0x182D09DA0")]
	private T DEIMIGNJMEI<T>(T JJCEIJMGOAB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7045CA0", Offset = "0x7044CA0", VA = "0x187045CA0")]
	private DPOAJAMLBLE DAMBDGDEHHE(DKMNKHDNIBD HHNBCLDGHCL, MFFPJJNLNNN NGFBHJIHHDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public NGCNJHEEIBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class LCJPLMEEBJM : DBGBHMBICHB, KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class EAAMHFADDIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public EAAMHFADDIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x702F6B0", Offset = "0x702E6B0", VA = "0x18702F6B0")]
		internal object HEMJKGMGDGG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class GLMADNEODOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public GLMADNEODOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7036360", Offset = "0x7035360", VA = "0x187036360")]
		internal object GHMPIEACILL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private EIHCBOIGFHH PIKFDLICNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private LMFMHBLPPGJ FMBGCKHFMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private NGGKNMPNMDK EACKIFHAKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private BHKONILDDPB IEJFDDMEIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private KALIOJPEJGN AIAIGNBMDCD;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7042360", Offset = "0x7041360", VA = "0x187042360", Slot = "6")]
	public void LFNNOPDGNGK(FPLMJHIKMFP ICDIIGEJPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7041880", Offset = "0x7040880", VA = "0x187041880", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7041450", Offset = "0x7040450", VA = "0x187041450", Slot = "4")]
	public BJEFPMHLDDL CGJOBBFCMCD(DKMNKHDNIBD EAAEOGDKMGK)
	{
		return default(BJEFPMHLDDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7041DF0", Offset = "0x7040DF0", VA = "0x187041DF0", Slot = "5")]
	public void GOCHBDHGPKB(Guid PHAMLENOBDP, Task IGHFBOKMDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7042290", Offset = "0x7041290", VA = "0x187042290")]
	private void JGMOHPCINKC(byte KNDLICIEHED, int OIGBOPKMBBG, object PJIPNPOKKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x70424D0", Offset = "0x70414D0", VA = "0x1870424D0")]
	private void LPEBGHOFCJI(DJKPEIKGKFN AOIHJKDLECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7042A60", Offset = "0x7041A60", VA = "0x187042A60")]
	private void MHJPGNIJEDP(DJKPEIKGKFN AOIHJKDLECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7041210", Offset = "0x7040210", VA = "0x187041210")]
	private void BOHDAKLLMNB(DJKPEIKGKFN AOIHJKDLECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7041BB0", Offset = "0x7040BB0", VA = "0x187041BB0")]
	private CDPIDOPDCID FHBPIEMCKFB(DKMNKHDNIBD MBBLEEHOBKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7042D60", Offset = "0x7041D60", VA = "0x187042D60")]
	private void NGHMFCFHMNO(DKMNKHDNIBD JLBJNBGNNDL, CDPIDOPDCID DIGFOPCJPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7042F70", Offset = "0x7041F70", VA = "0x187042F70")]
	private bool PELJMNOPMMB(DKMNKHDNIBD JLBJNBGNNDL, CDPIDOPDCID DIGFOPCJPDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7041930", Offset = "0x7040930", VA = "0x187041930")]
	private bool EDMNJIDMMHB(DKMNKHDNIBD BBJCEMIFKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7042000", Offset = "0x7041000", VA = "0x187042000")]
	private bool ILLDCKNGDGM(byte KNDLICIEHED, ExitGames.Client.Photon.Hashtable AOIHJKDLECK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public LCJPLMEEBJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[UnityEngine.Scripting.Preserve]
internal sealed class OLICDFLMNKM : MCGLIMLPBAH, KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class AONJEMBGEDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public LDJAJOAAKGC operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public OLICDFLMNKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public DKMNKHDNIBD roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public AONJEMBGEDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x702B9A0", Offset = "0x702A9A0", VA = "0x18702B9A0")]
		internal object LLGCBGKLGLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x702B870", Offset = "0x702A870", VA = "0x18702B870")]
		internal object JJMIGJOPHOP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct OOKOEIIGBNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public AsyncTaskMethodBuilder<CDPIDOPDCID> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public OLICDFLMNKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public DKMNKHDNIBD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private TaskAwaiter<CDPIDOPDCID> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x7049680", Offset = "0x7048680", VA = "0x187049680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x7049D10", Offset = "0x7048D10", VA = "0x187049D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class JPNCKKNFGMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public LDJAJOAAKGC operationType;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public JPNCKKNFGMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x703DD30", Offset = "0x703CD30", VA = "0x18703DD30")]
		internal object BHNFAGGGKJM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class GEJOKOFOPCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public DKMNKHDNIBD request;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public GEJOKOFOPCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x7032E50", Offset = "0x7031E50", VA = "0x187032E50")]
		internal object POEDDGCHJFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x7032D70", Offset = "0x7031D70", VA = "0x187032D70")]
		internal object LJEILEAHGDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x7032DE0", Offset = "0x7031DE0", VA = "0x187032DE0")]
		internal object NJMEJOGPHFG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct JMELJDLCDEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<CDPIDOPDCID> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public DKMNKHDNIBD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public OLICDFLMNKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private GEJOKOFOPCJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private BJEFPMHLDDL <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private CDPIDOPDCID <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter<(CDPIDOPDCID validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x703D390", Offset = "0x703C390", VA = "0x18703D390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x703DC40", Offset = "0x703CC40", VA = "0x18703DC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private EIHCBOIGFHH PIKFDLICNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private LMFMHBLPPGJ FMBGCKHFMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private DBGBHMBICHB FCCKEPMGBBB;

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x70489E0", Offset = "0x70479E0", VA = "0x1870489E0", Slot = "5")]
	public void LFNNOPDGNGK(FPLMJHIKMFP ICDIIGEJPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x70486D0", Offset = "0x70476D0", VA = "0x1870486D0", Slot = "4")]
	[AsyncStateMachine(typeof(OOKOEIIGBNC))]
	private Task<CDPIDOPDCID> GFPNNMEKINN(DKMNKHDNIBD MBBLEEHOBKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x70487F0", Offset = "0x70477F0", VA = "0x1870487F0")]
	private bool HOKFBNDGGDM(LDJAJOAAKGC HJBPLFIGHKM, [Out] CDPIDOPDCID KNFGDDANCCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7048590", Offset = "0x7047590", VA = "0x187048590")]
	[AsyncStateMachine(typeof(JMELJDLCDEF))]
	private Task<CDPIDOPDCID> AAMJIMAONOJ(DKMNKHDNIBD HHNBCLDGHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public OLICDFLMNKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class JFJLOMLKIAE : DJCOHDGDBBC, KABDBBKMGKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct BLPONGEKDOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public AsyncTaskMethodBuilder<BJEHJDLGDFO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public PJAFGDKDHNF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public JFJLOMLKIAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter<AFJNCMKOAEB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<BJEHJDLGDFO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x702BE30", Offset = "0x702AE30", VA = "0x18702BE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x702C400", Offset = "0x702B400", VA = "0x18702C400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class DMDKDKCEHIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public DMDKDKCEHIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x702F600", Offset = "0x702E600", VA = "0x18702F600")]
		internal object NJDPFOOIIJK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct HHJHLGKEAKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public AsyncTaskMethodBuilder<AFJNCMKOAEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public JFJLOMLKIAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public PJAFGDKDHNF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private DMDKDKCEHIB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter<AFJNCMKOAEB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x70375D0", Offset = "0x70365D0", VA = "0x1870375D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x7037BC0", Offset = "0x7036BC0", VA = "0x187037BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct GILLBIEINLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<BJEHJDLGDFO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public JFJLOMLKIAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public PJAFGDKDHNF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public AFJNCMKOAEB roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<(KIDKIHLFPDC superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x7034600", Offset = "0x7033600", VA = "0x187034600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x7034A60", Offset = "0x7033A60", VA = "0x187034A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class IADIPEAFOBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public IADIPEAFOBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA05D40", Offset = "0xA04D40", VA = "0x180A05D40")]
		internal bool CCOGCICFBHB(NGELDFKPLFG sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct JCKKILLNEKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AsyncTaskMethodBuilder<(KIDKIHLFPDC superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AFJNCMKOAEB roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public JFJLOMLKIAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public PJAFGDKDHNF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private TaskAwaiter<(KIDKIHLFPDC superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x703B0F0", Offset = "0x703A0F0", VA = "0x18703B0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x703B790", Offset = "0x703A790", VA = "0x18703B790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class CADJHGDJNOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public CADJHGDJNOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x702C470", Offset = "0x702B470", VA = "0x18702C470")]
		internal object BJONIIEDONI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct KHIEJFHANDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<(KIDKIHLFPDC superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public NGELDFKPLFG subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public JFJLOMLKIAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public PJAFGDKDHNF dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private CADJHGDJNOI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<LHGODKBPKKI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x703E5B0", Offset = "0x703D5B0", VA = "0x18703E5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x703ECE0", Offset = "0x703DCE0", VA = "0x18703ECE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly (KIDKIHLFPDC superRoomData, long subRoomDataSaveId) KFCKHPKHBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private ICFBHJEIGMP LCGMLIBOFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private CJINGDNGAEK CCCNFPGKIHG;

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x703BEE0", Offset = "0x703AEE0", VA = "0x18703BEE0", Slot = "5")]
	public void LFNNOPDGNGK(FPLMJHIKMFP ICDIIGEJPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x703B940", Offset = "0x703A940", VA = "0x18703B940", Slot = "4")]
	[AsyncStateMachine(typeof(BLPONGEKDOJ))]
	public Task<BJEHJDLGDFO> ADICFGGHCPP(KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, PJAFGDKDHNF MLOEGMNAALP, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x703BC10", Offset = "0x703AC10", VA = "0x18703BC10")]
	[AsyncStateMachine(typeof(HHJHLGKEAKF))]
	private Task<AFJNCMKOAEB> FJBMCCEEJDF(PJAFGDKDHNF MLOEGMNAALP, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x703BAA0", Offset = "0x703AAA0", VA = "0x18703BAA0")]
	[AsyncStateMachine(typeof(GILLBIEINLH))]
	private Task<BJEHJDLGDFO> CGDBNAEDEAC(PJAFGDKDHNF MLOEGMNAALP, AFJNCMKOAEB HAGNJOLKBDF, long EHHCEAFAAIL, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x703BD70", Offset = "0x703AD70", VA = "0x18703BD70")]
	[AsyncStateMachine(typeof(JCKKILLNEKI))]
	private Task<(KIDKIHLFPDC, long)> GBGDFGEHJCH(PJAFGDKDHNF MLOEGMNAALP, AFJNCMKOAEB HAGNJOLKBDF, long EHHCEAFAAIL, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x703BF70", Offset = "0x703AF70", VA = "0x18703BF70")]
	[AsyncStateMachine(typeof(KHIEJFHANDH))]
	private Task<(KIDKIHLFPDC, long)> PEGELHCDDPB(PJAFGDKDHNF PELEOHLMGHK, NGELDFKPLFG DCEHFEHPKFP, long EHHCEAFAAIL, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public JFJLOMLKIAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[UnityEngine.Scripting.Preserve]
internal sealed class AGGIGHJFLEM : POGOLOONGNH, KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class KDJBDKFHNCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public DKMNKHDNIBD request;

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public KDJBDKFHNCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x703E550", Offset = "0x703D550", VA = "0x18703E550")]
		internal object CDMEIGBDAKC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct GPJECIMDCBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public AsyncTaskMethodBuilder<DKMNKHDNIBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public DKMNKHDNIBD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public AGGIGHJFLEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public MFFPJJNLNNN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<DKMNKHDNIBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x70369D0", Offset = "0x70359D0", VA = "0x1870369D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x7036FE0", Offset = "0x7035FE0", VA = "0x187036FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct DJOBAINNEOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public AsyncTaskMethodBuilder<DKMNKHDNIBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public AGGIGHJFLEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public MFFPJJNLNNN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter<PDCKGLPFHAJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x702EED0", Offset = "0x702DED0", VA = "0x18702EED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x702F4D0", Offset = "0x702E4D0", VA = "0x18702F4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class GLBJBGMJKLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public DKMNKHDNIBD request;

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public GLBJBGMJKLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x7035730", Offset = "0x7034730", VA = "0x187035730")]
		internal object BHBMBMKOJEF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct GJHCHNBHNNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<DKMNKHDNIBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public DKMNKHDNIBD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AGGIGHJFLEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public MFFPJJNLNNN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private ANJDLGFKNMD <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private ODIJKJJBAKO <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter<PDCKGLPFHAJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x7034AD0", Offset = "0x7033AD0", VA = "0x187034AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x70356C0", Offset = "0x70346C0", VA = "0x1870356C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private EIHCBOIGFHH PIKFDLICNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private BCEHKEGFECJ BFCNDPMJAPN;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private NBGCBMENGBP KPKCHDNJNPA
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x702B3E0", Offset = "0x702A3E0", VA = "0x18702B3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x702B4A0", Offset = "0x702A4A0", VA = "0x18702B4A0", Slot = "8")]
	public void LFNNOPDGNGK(FPLMJHIKMFP ICDIIGEJPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x702B280", Offset = "0x702A280", VA = "0x18702B280", Slot = "4")]
	[AsyncStateMachine(typeof(GPJECIMDCBO))]
	public Task<DKMNKHDNIBD> KHMILKPOOOC(DKMNKHDNIBD HHNBCLDGHCL, MFFPJJNLNNN NGFBHJIHHDN, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x702B690", Offset = "0x702A690", VA = "0x18702B690", Slot = "5")]
	[AsyncStateMachine(typeof(DJOBAINNEOM))]
	public Task<DKMNKHDNIBD> PNEOGMNHILP(CancellationToken LABHBAHABKB, MFFPJJNLNNN NGFBHJIHHDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x702B070", Offset = "0x702A070", VA = "0x18702B070", Slot = "6")]
	public CHMMBEKDPCD GBMBMDHMGGE(DPOAJAMLBLE PJDDKLGEKCN, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x702AE40", Offset = "0x7029E40", VA = "0x18702AE40", Slot = "7")]
	public CHMMBEKDPCD DHGDLPEMEKD(DPOAJAMLBLE PJDDKLGEKCN, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x702B530", Offset = "0x702A530", VA = "0x18702B530")]
	[AsyncStateMachine(typeof(GJHCHNBHNNH))]
	private Task<DKMNKHDNIBD> LLDPKFKDOCO(DKMNKHDNIBD HHNBCLDGHCL, MFFPJJNLNNN NGFBHJIHHDN, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x299A5A0", Offset = "0x29995A0", VA = "0x18299A5A0")]
	private static byte[] PEJKKNEEDCA(DKMNKHDNIBD KKHEHGHPOAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public AGGIGHJFLEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[UnityEngine.Scripting.Preserve]
internal sealed class OODLNFFGAPH : LMFMHBLPPGJ, KABDBBKMGKL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private DAGLENMEAMP KMICNDCFOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private EIHCBOIGFHH PIKFDLICNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private FMILMIMGGOO MEEDMOGLOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private HAMLHDFIHKI INBAKNBBLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private ICFBHJEIGMP LCGMLIBOFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private HNNBOBPPOPF JGFEBJKHLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private IJCGBJPCBMP PIHAHCJAHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private BHNDCJDEGBI IOPKIGDDBDF;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private IIBKIJCPLOJ AGEBIJJODLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x7049050", Offset = "0x7048050", VA = "0x187049050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private static CDPIDOPDCID PJAEPDNOMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x703A060", Offset = "0x7039060", VA = "0x18703A060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7049510", Offset = "0x7048510", VA = "0x187049510", Slot = "6")]
	public void LFNNOPDGNGK(FPLMJHIKMFP ICDIIGEJPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x70493A0", Offset = "0x70483A0", VA = "0x1870493A0", Slot = "4")]
	public CDPIDOPDCID HEKMBNHAJMK(EEPDJJKFILM NOMIEKKDAGG, LDJAJOAAKGC DOIIBAIKNLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x70490A0", Offset = "0x70480A0", VA = "0x1870490A0", Slot = "5")]
	public CDPIDOPDCID BCIKJJMIAIO(EEPDJJKFILM IPLCJMBGNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x703A000", Offset = "0x7039000", VA = "0x18703A000")]
	private static CDPIDOPDCID HGDAOFOHGOD(AAILHDBANJG JMFILHLKOGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public OODLNFFGAPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class BKHKEACLNEI : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x702BDF0", Offset = "0x702ADF0", VA = "0x18702BDF0")]
	public BKHKEACLNEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x64C0020", Offset = "0x64BF020", VA = "0x1864C0020")]
	public BKHKEACLNEI(string KKHEHGHPOAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[UnityEngine.Scripting.Preserve]
internal sealed class LCAKHMGNLMF : HMOIFGBPDCI, KABDBBKMGKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct KLCFFLOINIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder<CDPIDOPDCID> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public LCAKHMGNLMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public JEIKNEHGIKE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private KLCBNGOGDPF<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private FKCPEKHDAAC <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<CDPIDOPDCID> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x703F160", Offset = "0x703E160", VA = "0x18703F160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x703FCE0", Offset = "0x703ECE0", VA = "0x18703FCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct KDBGIDKFAFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public LCAKHMGNLMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x703DDA0", Offset = "0x703CDA0", VA = "0x18703DDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x703E4F0", Offset = "0x703D4F0", VA = "0x18703E4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct OPLABHHHJNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public LCAKHMGNLMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7049D80", Offset = "0x7048D80", VA = "0x187049D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x704A290", Offset = "0x7049290", VA = "0x18704A290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct OENIENHKHIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public LCAKHMGNLMF <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7047550", Offset = "0x7046550", VA = "0x187047550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7047CA0", Offset = "0x7046CA0", VA = "0x187047CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct CCKEOLMLENJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public LCAKHMGNLMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x702C580", Offset = "0x702B580", VA = "0x18702C580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x702C720", Offset = "0x702B720", VA = "0x18702C720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct NCBALDLENCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public LCAKHMGNLMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7045200", Offset = "0x7044200", VA = "0x187045200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7045920", Offset = "0x7044920", VA = "0x187045920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct KNDKINIGMGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public LCAKHMGNLMF <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x703FD50", Offset = "0x703ED50", VA = "0x18703FD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x70401C0", Offset = "0x703F1C0", VA = "0x1870401C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct GNCGMOICBAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public LCAKHMGNLMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public EJEHHNILJEA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private KLCBNGOGDPF<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7036410", Offset = "0x7035410", VA = "0x187036410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7036970", Offset = "0x7035970", VA = "0x187036970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private EIHCBOIGFHH PIKFDLICNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private FPLMJHIKMFP ICDIIGEJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private ICFBHJEIGMP LCGMLIBOFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private POGOLOONGNH BNMKCOAPNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private FMILMIMGGOO MEEDMOGLOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private IJCGBJPCBMP PIHAHCJAHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private CancellationTokenSource OHNCONKICOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private Task CGHJJDKAFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private TaskCompletionSource<int> PNNMJDDNALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private int FNPHFKFMIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private int FEONKDNIACK;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7040DE0", Offset = "0x703FDE0", VA = "0x187040DE0", Slot = "6")]
	public void LFNNOPDGNGK(FPLMJHIKMFP ICDIIGEJPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0xB5BE20", Offset = "0xB5AE20", VA = "0x180B5BE20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7040510", Offset = "0x703F510", VA = "0x187040510")]
	private void EMHCJFJNBCM(float ODCKEFAJKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x70405F0", Offset = "0x703F5F0", VA = "0x1870405F0", Slot = "4")]
	[AsyncStateMachine(typeof(KLCFFLOINIG))]
	public Task<CDPIDOPDCID> EONNNGGCHDA(JEIKNEHGIKE NMDGMOPBHKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7040F90", Offset = "0x703FF90", VA = "0x187040F90", Slot = "5")]
	[AsyncStateMachine(typeof(KDBGIDKFAFA))]
	public Task NOCEIHEBDDM([Optional] CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0xB5BE20", Offset = "0xB5AE20", VA = "0x180B5BE20")]
	public void FLKLKLMEOKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7040A80", Offset = "0x703FA80", VA = "0x187040A80")]
	private FKCPEKHDAAC JAGEFJCMIPK(JEIKNEHGIKE NMDGMOPBHKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7040CF0", Offset = "0x703FCF0", VA = "0x187040CF0")]
	[AsyncStateMachine(typeof(OPLABHHHJNC))]
	private Task JOCBBOIHKME(CancellationToken CKFCHGJKDBJ, int FLDOALLBIIP, MJKPLCNHABA NIPKIEGBLMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7040BF0", Offset = "0x703FBF0", VA = "0x187040BF0")]
	[AsyncStateMachine(typeof(OENIENHKHIL))]
	private Task JKJIDFCOPND(CancellationToken CKFCHGJKDBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7040330", Offset = "0x703F330", VA = "0x187040330")]
	[AsyncStateMachine(typeof(CCKEOLMLENJ))]
	private Task CJOABJEEMKK([Optional] CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7040420", Offset = "0x703F420", VA = "0x187040420")]
	[AsyncStateMachine(typeof(NCBALDLENCL))]
	private Task DPPABCFDBPC(CancellationToken CKFCHGJKDBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7040980", Offset = "0x703F980", VA = "0x187040980")]
	[AsyncStateMachine(typeof(KNDKINIGMGB))]
	private Task HNDNGPOMBPP(CancellationToken DIILKACGMBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7041080", Offset = "0x7040080", VA = "0x187041080")]
	private Task OECJNAOGFEB(EJEHHNILJEA KAACMIHMDEC, CancellationToken CKFCHGJKDBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7040220", Offset = "0x703F220", VA = "0x187040220")]
	[AsyncStateMachine(typeof(GNCGMOICBAE))]
	private Task CBKBEEJGCOC(EJEHHNILJEA KAACMIHMDEC, CancellationToken CKFCHGJKDBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7040720", Offset = "0x703F720", VA = "0x187040720")]
	private bool FCHHGLGOCAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public LCAKHMGNLMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[UnityEngine.Scripting.Preserve]
internal class HENIPKMMBHD : HAMLHDFIHKI, KABDBBKMGKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct OMMBLKHODGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public HENIPKMMBHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private KLCBNGOGDPF<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7048A90", Offset = "0x7047A90", VA = "0x187048A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7048FF0", Offset = "0x7047FF0", VA = "0x187048FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private FKFCOBBBJFG LFOBCPBCLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private FPLMJHIKMFP ICDIIGEJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private LMFMHBLPPGJ FMBGCKHFMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private POGOLOONGNH BNMKCOAPNDL;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x7037100", Offset = "0x7036100", VA = "0x187037100", Slot = "6")]
	public void LFNNOPDGNGK(FPLMJHIKMFP ICDIIGEJPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x7037050", Offset = "0x7036050", VA = "0x187037050", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x70373E0", Offset = "0x70363E0", VA = "0x1870373E0", Slot = "5")]
	[AsyncStateMachine(typeof(OMMBLKHODGI))]
	public Task NDLEMFNFAIO(string PLCNFEGEAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x70370A0", Offset = "0x70360A0", VA = "0x1870370A0", Slot = "4")]
	public CDPIDOPDCID FCHHGLGOCAA(EEPDJJKFILM NOMIEKKDAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x70374E0", Offset = "0x70364E0", VA = "0x1870374E0")]
	private FIGMNNFAJJB PBEPIHAJLDB(string PLCNFEGEAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public HENIPKMMBHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class LHOFMIMGEPA
{
	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x7043CC0", Offset = "0x7042CC0", VA = "0x187043CC0")]
	public static void OEONPDMJHKO(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x7043F00", Offset = "0x7042F00", VA = "0x187043F00")]
	internal static void PCCCCNGGDOG(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x7043790", Offset = "0x7042790", VA = "0x187043790")]
	internal static void CGOLCOIHFKM(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x7043870", Offset = "0x7042870", VA = "0x187043870")]
	internal static void FCAOHPNOFOF(NDJGECDCBMH MMBLPJPOBHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal class OJCGIAPGKPO : LFLNFHCBNDK<DKMNKHDNIBD>
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class APAPIAHOLKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public DKMNKHDNIBD message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public APAPIAHOLKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x702BA10", Offset = "0x702AA10", VA = "0x18702BA10")]
		internal object DMGKIKALBAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly OJCGIAPGKPO PNNELGGLBHA;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x7047F40", Offset = "0x7046F40", VA = "0x187047F40")]
	public ExitGames.Client.Photon.Hashtable JMNIMAIKKED(DKMNKHDNIBD KKHEHGHPOAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x7047D00", Offset = "0x7046D00", VA = "0x187047D00", Slot = "5")]
	protected override void DMHBJGCKDFK(DKMNKHDNIBD KKHEHGHPOAA, IDictionary<object, object> AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x7048280", Offset = "0x7047280", VA = "0x187048280", Slot = "6")]
	public override DKMNKHDNIBD PPFECFLIGJE(IDictionary<object, object> AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x7047E30", Offset = "0x7046E30", VA = "0x187047E30")]
	private static void ELCBEGJPMKG(string ELECLKGFGKN, DKMNKHDNIBD KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x7048550", Offset = "0x7047550", VA = "0x187048550")]
	public OJCGIAPGKPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x7047FD0", Offset = "0x7046FD0", VA = "0x187047FD0")]
	[CompilerGenerated]
	internal static string PGNFJHNCHEC(BJEHJDLGDFO KLINFCCHIED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class IJEOFINIKCE
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public static CDPIDOPDCID PJAEPDNOMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x703A060", Offset = "0x7039060", VA = "0x18703A060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x7039FE0", Offset = "0x7038FE0", VA = "0x187039FE0")]
	public static bool BJMDJDGNPAB(this CDPIDOPDCID DIGFOPCJPDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x703A000", Offset = "0x7039000", VA = "0x18703A000")]
	public static CDPIDOPDCID HGDAOFOHGOD(AAILHDBANJG NHNKOHGANKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x7039B80", Offset = "0x7038B80", VA = "0x187039B80")]
	public static CDPIDOPDCID AGDMCAIEPMC(IEnumerable<CDPIDOPDCID> PCAJJFBANGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7039D80", Offset = "0x7038D80", VA = "0x187039D80")]
	public static string BCAEIPLNICB(this CDPIDOPDCID KNFGDDANCCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public abstract class NJFJGLKIAHN : EPMDPLCBGFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public delegate CDPIDOPDCID GJMNCNLJDAN([NotNull] EEPDJJKFILM PGOBMOHLAJP);

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class NDKLNLFPEHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public EEPDJJKFILM photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public NDKLNLFPEHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x66CEAF0", Offset = "0x66CDAF0", VA = "0x1866CEAF0")]
		internal CDPIDOPDCID AMMONGMHCFG(GJMNCNLJDAN v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private bool OJOGLGJEHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	protected readonly HashSet<GJMNCNLJDAN> ECPGJPODIEF;

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x7047080", Offset = "0x7046080", VA = "0x187047080", Slot = "4")]
	public void GKFKEGKCFDO(GJMNCNLJDAN MOMKKIFHNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x70470E0", Offset = "0x70460E0", VA = "0x1870470E0", Slot = "5")]
	public void KFIBPAPKGNF(GJMNCNLJDAN MOMKKIFHNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7046D90", Offset = "0x7045D90", VA = "0x187046D90", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x7046DE0", Offset = "0x7045DE0", VA = "0x187046DE0")]
	protected CDPIDOPDCID FCPNLBNNBDO(EEPDJJKFILM IPLCJMBGNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x7047140", Offset = "0x7046140", VA = "0x187047140")]
	protected NJFJGLKIAHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class EMJFJECFLAF : NJFJGLKIAHN, DAGLENMEAMP, EPMDPLCBGFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class IMDNPJIJMKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public CDPIDOPDCID result;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public IMDNPJIJMKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x703A1C0", Offset = "0x70391C0", VA = "0x18703A1C0")]
		internal object KKNENGIFNLJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x702EB30", Offset = "0x702DB30", VA = "0x18702EB30")]
	[UnityEngine.Scripting.Preserve]
	public EMJFJECFLAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x70310B0", Offset = "0x70300B0", VA = "0x1870310B0", Slot = "8")]
	public CDPIDOPDCID ONJBIHFAGHL(EEPDJJKFILM IPLCJMBGNDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class DHDDBPHEIJB : NJFJGLKIAHN, FKFCOBBBJFG, EPMDPLCBGFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private sealed class DJOPGCGBKKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public CDPIDOPDCID result;

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public DJOPGCGBKKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x702F5A0", Offset = "0x702E5A0", VA = "0x18702F5A0")]
		internal object PLDPOILJAEL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x702EB30", Offset = "0x702DB30", VA = "0x18702EB30")]
	[UnityEngine.Scripting.Preserve]
	public DHDDBPHEIJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x702EA20", Offset = "0x702DA20", VA = "0x18702EA20", Slot = "8")]
	public CDPIDOPDCID FCHHGLGOCAA(EEPDJJKFILM ABGNPDBOJGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal static class ODIKEODPCAG
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private sealed class JMKAIAGLHDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public KLCBNGOGDPF<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public JMKAIAGLHDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x703DCB0", Offset = "0x703CCB0", VA = "0x18703DCB0")]
		internal object EPCPAOIKPNP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x7047470", Offset = "0x7046470", VA = "0x187047470")]
	public static KLCBNGOGDPF<string> MNFEDNCENAO(PHLKHBEJKKB IGEICKLFDBC, [Optional] string OELLILECDPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x70473B0", Offset = "0x70463B0", VA = "0x1870473B0")]
	public static void KLIEGOIJKOP(KLCBNGOGDPF<string> COCKABGNCJJ, PHLKHBEJKKB IGEICKLFDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x70472F0", Offset = "0x70462F0", VA = "0x1870472F0")]
	public static string JGDLHHEHHFP(DKMNKHDNIBD MBBLEEHOBKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal static class JEENELLKFLG
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x703B930", Offset = "0x703A930", VA = "0x18703B930")]
	public static void KNIKDENCEHO(this EIHCBOIGFHH PIKFDLICNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x703B920", Offset = "0x703A920", VA = "0x18703B920")]
	public static void IJPMFHAMAED(this EIHCBOIGFHH PIKFDLICNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x703B800", Offset = "0x703A800", VA = "0x18703B800")]
	private static void FACNFLJBBMK(this EIHCBOIGFHH PIKFDLICNNE, bool KLMNOKCAALG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class LHICBDDEAPL : HHGPOLHNGOK, GCGMGNAOHCB, LMBHPFDPKGJ, FDIGNGAOFAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private readonly GCGMGNAOHCB PEKLLPDANJJ;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public EEPDJJKFILM MCDLKPFDKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7043630", Offset = "0x7042630", VA = "0x187043630", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int GPMEKKPHCEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7043350", Offset = "0x7042350", VA = "0x187043350", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public int HNKCAGAPKEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7043740", Offset = "0x7042740", VA = "0x187043740", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DAEPGHIJCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int OCFMNEJIOKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2F0", Offset = "0x9AE2F0", VA = "0x1809AF2F0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event BCLFFFPJFPJ.FONDPIANDIE PJPAGDNPOEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event ADEMFPPICOH PJMFNLOEHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7043590", Offset = "0x7042590", VA = "0x187043590", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x70433A0", Offset = "0x70423A0", VA = "0x1870433A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> EDLAJABALMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<EEPDJJKFILM> GHFLOCOECKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action MKAOLAPPFOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7043680", Offset = "0x7042680", VA = "0x187043680", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7043440", Offset = "0x7042440", VA = "0x187043440", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0xB2DE40", Offset = "0xB2CE40", VA = "0x180B2DE40")]
	public LHICBDDEAPL(GCGMGNAOHCB PEKLLPDANJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x70434E0", Offset = "0x70424E0", VA = "0x1870434E0", Slot = "8")]
	public bool JBEFCMDOBLA(byte KNDLICIEHED, ExitGames.Client.Photon.Hashtable DPOMCMMELEP, KDBJHGPGGMN HDCDPDDPEHF, SendOptions EENGILGBAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x7043270", Offset = "0x7042270", VA = "0x187043270", Slot = "16")]
	public EEPDJJKFILM FAHPJBKEMIM(int KFDCPIPJNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "19")]
	public void APJEHBBLCLG(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "20")]
	public void PHDMDPDFHDH(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "21")]
	public void NILJDNGIGCP(object DJIBMMAIGPE, bool CLACCHGMAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7043220", Offset = "0x7042220", VA = "0x187043220", Slot = "22")]
	public IDisposable AMCBHBOEGEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "23")]
	private bool BPKKPPBFMAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "24")]
	public void ILMKKOCDBDN(StringBuilder GLMEBNDONIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x7043720", Offset = "0x7042720", VA = "0x187043720", Slot = "25")]
	public bool MHLGKCOFBIP(bool BLCFBAEGPCO, [Out] string EHELKEOJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0xA51BE0", Offset = "0xA50BE0", VA = "0x180A51BE0", Slot = "28")]
	public void CJBAANLGMPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct DJKPEIKGKFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private readonly IDictionary<object, object> AOIHJKDLECK;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0xA111F0", Offset = "0xA101F0", VA = "0x180A111F0")]
	public DJKPEIKGKFN(IDictionary<object, object> AOIHJKDLECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x702ED70", Offset = "0x702DD70", VA = "0x18702ED70")]
	public bool EGNJOLPDMEB([Out] DKMNKHDNIBD KKHEHGHPOAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x702EE20", Offset = "0x702DE20", VA = "0x18702EE20")]
	public Guid EOJEHPNONPK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x702EC30", Offset = "0x702DC30", VA = "0x18702EC30")]
	public CDPIDOPDCID EEEIGIMJHGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x702EB40", Offset = "0x702DB40", VA = "0x18702EB40")]
	public static ExitGames.Client.Photon.Hashtable EAPGIKBOING(DKMNKHDNIBD KKHEHGHPOAA, CDPIDOPDCID DIGFOPCJPDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal static class FAFKPNEJKAI
{
	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x7031400", Offset = "0x7030400", VA = "0x187031400")]
	public static bool PONMHNAILNN(this PJAFGDKDHNF AIPGHLJGNDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct ECAKNBCPLHD : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct ENDMEEILGHB : IAsyncStateMachine
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
		public ECAKNBCPLHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x70311C0", Offset = "0x70301C0", VA = "0x1870311C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x70313A0", Offset = "0x70303A0", VA = "0x1870313A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private readonly CancellationTokenSource DJMJNBDHLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private bool OJOGLGJEHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private Task FGPHJGHMKNM;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool KJINILEJGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x702F8E0", Offset = "0x702E8E0", VA = "0x18702F8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x702F910", Offset = "0x702E910", VA = "0x18702F910")]
	public ECAKNBCPLHD(CancellationToken LABHBAHABKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x702F7D0", Offset = "0x702E7D0", VA = "0x18702F7D0")]
	[AsyncStateMachine(typeof(ENDMEEILGHB))]
	public Task GBFCHCNEIDA(Func<CancellationToken, List<Task>> DBKOAPDHJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x702F780", Offset = "0x702E780", VA = "0x18702F780", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly struct PFOAELAJAGO<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct LKLHGOJEPGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<LMMNLPJCOOL<TData>, DNBIAPHIKOM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public PFOAELAJAGO<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private TaskAwaiter<DFAHBLOKBPH<LMMNLPJCOOL<TData>, DNBIAPHIKOM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x42FE0C0", Offset = "0x42FD0C0", VA = "0x1842FE0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x3898510", Offset = "0x3897510", VA = "0x183898510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private readonly INLFDNJMICH<TGetDataArg, TData> OMOPLBNHPIH;

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0xA111F0", Offset = "0xA101F0", VA = "0x180A111F0")]
	internal PFOAELAJAGO(INLFDNJMICH<TGetDataArg, TData> HPGJLJLFPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x47A30C0", Offset = "0x47A20C0", VA = "0x1847A30C0")]
	[AsyncStateMachine(typeof(PFOAELAJAGO<, >.LKLHGOJEPGF))]
	public Task<DFAHBLOKBPH<LMMNLPJCOOL<TData>, DNBIAPHIKOM>> DMADIHLBACC(TGetDataArg OEMEKBFANIG, string BCNDHABHHBI, KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class EJMEBBAJPNM
{
	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2992900", Offset = "0x2991900", VA = "0x182992900")]
	public static PFOAELAJAGO<TGetDataArg, TData> GAKCNKPJGEK<TGetDataArg, TData>(INLFDNJMICH<TGetDataArg, TData> HPGJLJLFPIH)
	{
		return default(PFOAELAJAGO<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct PLDMJLNJFKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public readonly int KAKDFNCFBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public readonly int? COMJLOOLKJE;

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x42B19D0", Offset = "0x42B09D0", VA = "0x1842B19D0")]
	public PLDMJLNJFKP(int KLHABFFOPGM, [Optional] int? DFGJHBMOBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x704A6E0", Offset = "0x70496E0", VA = "0x18704A6E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public interface JDNEPPILDJI<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGDGOBDGAMK();

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JDNEPPILDJI<T> BOANCHKCLHK(string OGMBGKKMGPO);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JDNEPPILDJI<T> JDJANGHCAAM(GDJMHGKGJMP<T> OHAGLCJJAAD);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JDNEPPILDJI<T> LNKAKEANLKK(int CMBMLLGKBPM);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JDNEPPILDJI<T> LOFOBFDMPPK(int CMBMLLGKBPM, CDJJMKLEPIC<T> HJJICGLOHLN);
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface EJFHNNKMENL
{
	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JDNEPPILDJI<T> LLEAOHHFNIH<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OCEPHCAANJL AJFAIGNKIDE(Exception APIEMOLNMPG);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PLDMJLNJFKP COMPKJMLNAH(Exception APIEMOLNMPG);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public delegate string GDJMHGKGJMP<in T>(T APIEMOLNMPG) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public delegate int CDJJMKLEPIC<in T>(T APIEMOLNMPG) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal class GGBPKOOEHIA : EJFHNNKMENL
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	private delegate string GCEEHNDFDJK(Exception APIEMOLNMPG);

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private delegate int MILBCBKDJEJ(Exception APIEMOLNMPG);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class LCOAMDJIGPA<T> : JDNEPPILDJI<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[CompilerGenerated]
		private sealed class FKDPMPHILBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public FKDPMPHILBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
			internal string JJBIKACKBJC(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class AECLMHBEKFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public GDJMHGKGJMP<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public AECLMHBEKFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x3D02760", Offset = "0x3D01760", VA = "0x183D02760")]
			internal string LHNPKIBDKNK(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class DGHFFDFPNCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public CDJJMKLEPIC<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public DGHFFDFPNCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x3D02760", Offset = "0x3D01760", VA = "0x183D02760")]
			internal int IDAJEJIPGGI(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private readonly GGBPKOOEHIA INFKAKPFJBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private readonly Type PHJHDFCOBDP;

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x42D9C80", Offset = "0x42D8C80", VA = "0x1842D9C80")]
		internal LCOAMDJIGPA(GGBPKOOEHIA INFKAKPFJBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x42D99C0", Offset = "0x42D89C0", VA = "0x1842D99C0", Slot = "4")]
		public void HGDGOBDGAMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x42D98A0", Offset = "0x42D88A0", VA = "0x1842D98A0", Slot = "5")]
		public JDNEPPILDJI<T> BOANCHKCLHK(string OGMBGKKMGPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x42D99F0", Offset = "0x42D89F0", VA = "0x1842D99F0", Slot = "6")]
		public JDNEPPILDJI<T> JDJANGHCAAM(GDJMHGKGJMP<T> OHAGLCJJAAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x42D9B10", Offset = "0x42D8B10", VA = "0x1842D9B10", Slot = "7")]
		public JDNEPPILDJI<T> LNKAKEANLKK(int CMBMLLGKBPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x42D9B50", Offset = "0x42D8B50", VA = "0x1842D9B50", Slot = "8")]
		public JDNEPPILDJI<T> LOFOBFDMPPK(int CMBMLLGKBPM, CDJJMKLEPIC<T> HJJICGLOHLN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private class EKOBLNNFABB<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private bool BDIMFOOBIPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private readonly List<Type> CEGCLEGGIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private readonly Dictionary<Type, TVal> KMCODFKCCMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly Dictionary<Type, int> FIIIDGOJOMF;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public IReadOnlyList<Type> FCDHADEPFJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x38A7B90", Offset = "0x38A6B90", VA = "0x1838A7B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x38A7D40", Offset = "0x38A6D40", VA = "0x1838A7D40")]
		public EKOBLNNFABB(Dictionary<Type, int> FIIIDGOJOMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x38A79E0", Offset = "0x38A69E0", VA = "0x1838A79E0")]
		public void GKAGDNHKNII(Type GMFCIHEFPPO, TVal AAINAOCHJJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x38A7CF0", Offset = "0x38A6CF0", VA = "0x1838A7CF0")]
		public bool PJEMCDNFPJB(Type PHJHDFCOBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x38A7990", Offset = "0x38A6990", VA = "0x1838A7990")]
		public bool FKCOFDIIDDJ(TVal JJCEIJMGOAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x38A7B40", Offset = "0x38A6B40", VA = "0x1838A7B40")]
		public TVal MKHPGHPCCLG(Type HNGLFCFOHLI)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x38A78F0", Offset = "0x38A68F0", VA = "0x1838A78F0")]
		[CompilerGenerated]
		private int EHAIAAPHFAP(Type PLHPCOMKLFM, Type JLPOKBKFEEC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class MDFMHGPCCEP : IEnumerable<PLDMJLNJFKP>, IEnumerable, IEnumerator<PLDMJLNJFKP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private PLDMJLNJFKP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public GGBPKOOEHIA <>4__this;

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
		private IEnumerator<PLDMJLNJFKP> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		private PLDMJLNJFKP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x38AB510", Offset = "0x38AA510", VA = "0x1838AB510", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PLDMJLNJFKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x70449B0", Offset = "0x70439B0", VA = "0x1870449B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x8A4A30", Offset = "0x8A3A30", VA = "0x1808A4A30")]
		[DebuggerHidden]
		public MDFMHGPCCEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x7044A00", Offset = "0x7043A00", VA = "0x187044A00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x70443B0", Offset = "0x70433B0", VA = "0x1870443B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x7044360", Offset = "0x7043360", VA = "0x187044360")]
		private void IKLMFKCBKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x7044850", Offset = "0x7043850", VA = "0x187044850")]
		private void POOBBHLNDCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x7044960", Offset = "0x7043960", VA = "0x187044960", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x70448A0", Offset = "0x70438A0", VA = "0x1870448A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PLDMJLNJFKP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x70448A0", Offset = "0x70438A0", VA = "0x1870448A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private static readonly PLDMJLNJFKP IJFBLHMJKDD;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private static readonly Dictionary<Type, int> LDGNMHFFEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly HashSet<Type> IDNILKMAMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly EKOBLNNFABB<int> HEOKBGIFIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly EKOBLNNFABB<MILBCBKDJEJ> ABGHIIDENBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly EKOBLNNFABB<GCEEHNDFDJK> NPDCONBEHJP;

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7033260", Offset = "0x7032260", VA = "0x187033260")]
	[ONAOIKEPAJE(IKAJKCKEGIH.GameOnly)]
	private static void BJONJIDIGGM(NDJGECDCBMH GJMGLGAJGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x70342C0", Offset = "0x70332C0", VA = "0x1870342C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GGBPKOOEHIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x2BB96B0", Offset = "0x2BB86B0", VA = "0x182BB96B0", Slot = "4")]
	public JDNEPPILDJI<T> LLEAOHHFNIH<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x7032EC0", Offset = "0x7031EC0", VA = "0x187032EC0", Slot = "5")]
	public OCEPHCAANJL AJFAIGNKIDE(Exception APIEMOLNMPG)
	{
		return default(OCEPHCAANJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x70332D0", Offset = "0x70322D0", VA = "0x1870332D0", Slot = "6")]
	public PLDMJLNJFKP COMPKJMLNAH(Exception? APIEMOLNMPG)
	{
		return default(PLDMJLNJFKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x70339F0", Offset = "0x70329F0", VA = "0x1870339F0", Slot = "7")]
	[IteratorStateMachine(typeof(MDFMHGPCCEP))]
	public IEnumerable<PLDMJLNJFKP> HLGMMLFMNGG(Exception APIEMOLNMPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7033F20", Offset = "0x7032F20", VA = "0x187033F20", Slot = "8")]
	public string MIHLNCJMBGF(Exception? APIEMOLNMPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x7032F50", Offset = "0x7031F50", VA = "0x187032F50")]
	private string BIDHMCANKOP(AggregateException FAINNGKJCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x7033A90", Offset = "0x7032A90", VA = "0x187033A90")]
	private void JJJECBEHGBH(Type PHJHDFCOBDP, int CMBMLLGKBPM, MILBCBKDJEJ? CIHCCGEBMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x70337A0", Offset = "0x70327A0", VA = "0x1870337A0")]
	private void GPDBJLDNBNA(Type PHJHDFCOBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x70334D0", Offset = "0x70324D0", VA = "0x1870334D0")]
	private void DDELDGFPMOL(Type PHJHDFCOBDP, GCEEHNDFDJK FDLJDKLBFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x7034070", Offset = "0x7033070", VA = "0x187034070")]
	private static int PGHFDIBKEOJ(Type PHJHDFCOBDP, Dictionary<Type, int> FIIIDGOJOMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9730", Offset = "0x2BB8730", VA = "0x182BB9730")]
	private static bool OJAKAOFHPNL<TVal>(EKOBLNNFABB<TVal> ADLAOOMHAPB, Type PHJHDFCOBDP, [Out] TVal JJCEIJMGOAB) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x7033E40", Offset = "0x7032E40", VA = "0x187033E40")]
	[CompilerGenerated]
	internal static int LNPCEELHBIJ(Type PDFJIFBIGFJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public struct OCEPHCAANJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public readonly PLDMJLNJFKP KBDGPDOLENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public readonly string KGDMOPMOOIE;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x70472D0", Offset = "0x70462D0", VA = "0x1870472D0")]
	public OCEPHCAANJL(string DGPFBPINPEO, PLDMJLNJFKP CMBMLLGKBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7047230", Offset = "0x7046230", VA = "0x187047230")]
	public string MECHIGGDLLB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class IOEEDLJNEAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private readonly LFDOIPPMKHF GJOJOAMKBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private string JIAHCPPIEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private long? MFGKGMHCDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private long? MNDDGHHPENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private long? MIIHEEJFLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private string HMHDHAFAINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private DFIBCMGCDHD ABLJKCOJIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private long? JLEGGOGPJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private bool OLBHHMAIAFO;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public string AIGBGPCMKOM
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public long JCGGOKMNGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x703AFF0", Offset = "0x7039FF0", VA = "0x18703AFF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public long NFCCJCONNIC
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x703B050", Offset = "0x703A050", VA = "0x18703B050")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public long DNFCOOOLHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x703AA60", Offset = "0x7039A60", VA = "0x18703AA60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string PBKBOFFDFID
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x703AB20", Offset = "0x7039B20", VA = "0x18703AB20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public DFIBCMGCDHD MNEEICFECBO
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xB3DDE0", Offset = "0xB3CDE0", VA = "0x180B3DDE0")]
		get
		{
			return default(DFIBCMGCDHD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x703A570", Offset = "0x7039570", VA = "0x18703A570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long IDDPNCNEKLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x703AAC0", Offset = "0x7039AC0", VA = "0x18703AAC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x703B0B0", Offset = "0x703A0B0", VA = "0x18703B0B0")]
	[UnityEngine.Scripting.Preserve]
	public IOEEDLJNEAH([JONIFKKOOAA(null)] LFDOIPPMKHF GJOJOAMKBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x703A280", Offset = "0x7039280", VA = "0x18703A280")]
	private void ALPOACPIKGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x703AB60", Offset = "0x7039B60", VA = "0x18703AB60")]
	public void HKEIHNBEPJO(long MFLLPFDNGGL, long EHHCEAFAAIL, [Optional] long? ONBLDGLEBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x703A4D0", Offset = "0x70394D0", VA = "0x18703A4D0")]
	public void CCGADKDMPCB(long ONBLDGLEBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x703A9E0", Offset = "0x70399E0", VA = "0x18703A9E0")]
	public void FCFBNEDOKNJ(string EHMAHHPLCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x703A660", Offset = "0x7039660", VA = "0x18703A660")]
	public void DGMIANHHPFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal class CHMMBEKDPCD : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct ALPGOOIMOKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public AsyncTaskMethodBuilder<DKMNKHDNIBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public DKMNKHDNIBD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public CHMMBEKDPCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private TaskAwaiter<NBGCBMENGBP.KMCMCKPAAIG<DKMNKHDNIBD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x704B170", Offset = "0x704A170", VA = "0x18704B170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x704B570", Offset = "0x704A570", VA = "0x18704B570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct DPFJHANCABK<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class DBBJOIJAPCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public DKMNKHDNIBD roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public DBBJOIJAPCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x704E6E0", Offset = "0x704D6E0", VA = "0x18704E6E0")]
		internal DKMNKHDNIBD BBHBKHGPBHP(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct DGCJNJKHKOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public AsyncTaskMethodBuilder<NBGCBMENGBP.KMCMCKPAAIG<DKMNKHDNIBD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public DKMNKHDNIBD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public CHMMBEKDPCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private ANJDLGFKNMD <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter<NBGCBMENGBP.KMCMCKPAAIG<DKMNKHDNIBD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x704E970", Offset = "0x704D970", VA = "0x18704E970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x704EF80", Offset = "0x704DF80", VA = "0x18704EF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct ABHOFDBHDGM<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public CHMMBEKDPCD <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x3CEAE50", Offset = "0x3CE9E50", VA = "0x183CEAE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x35D0370", Offset = "0x35CF370", VA = "0x1835D0370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct GPCEOBEEJHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public CHMMBEKDPCD <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x7053CF0", Offset = "0x7052CF0", VA = "0x187053CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x7053EB0", Offset = "0x7052EB0", VA = "0x187053EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class DGIICBPCCOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public DGIICBPCCOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x704F0B0", Offset = "0x704E0B0", VA = "0x18704F0B0")]
		internal object OAAOOODNHEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x704EFF0", Offset = "0x704DFF0", VA = "0x18704EFF0")]
		internal bool BOMFNPCBHEB(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class NEAMBOIHDEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public NEAMBOIHDEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x705EEF0", Offset = "0x705DEF0", VA = "0x18705EEF0")]
		internal object OAOKPIMFAJH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class LINIGONHCNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public LINIGONHCNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x705BD30", Offset = "0x705AD30", VA = "0x18705BD30")]
		internal object EAPNBECJOKJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class GENHIBPPIOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public GENHIBPPIOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x70539B0", Offset = "0x70529B0", VA = "0x1870539B0")]
		internal object DHDFNBANBJK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class GOGLBECBNEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public CHMMBEKDPCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public GOGLBECBNEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x7053AA0", Offset = "0x7052AA0", VA = "0x187053AA0")]
		internal object DMGKIKALBAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private static readonly Guid OCDFIJAODOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly DPOAJAMLBLE HLLOKKDEOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly NBGCBMENGBP HCCNHDHFPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly LMBHPFDPKGJ PIKFDLICNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly FDIGNGAOFAD DBEJFOEFLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private bool IEDAHMPEDDN;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x702D910", Offset = "0x702C910", VA = "0x18702D910")]
	public CHMMBEKDPCD(DPOAJAMLBLE IEHHLNFCIFN, NBGCBMENGBP HCCNHDHFPBH, LMBHPFDPKGJ PIKFDLICNNE, FDIGNGAOFAD DBEJFOEFLEA, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x702C9E0", Offset = "0x702B9E0", VA = "0x18702C9E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x702C9E0", Offset = "0x702B9E0", VA = "0x18702C9E0")]
	public void GIPNPBLMKAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x702D340", Offset = "0x702C340", VA = "0x18702D340")]
	public void LBPFMBBBBCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x702D680", Offset = "0x702C680", VA = "0x18702D680")]
	public void OBIJGOOOOKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x702CDC0", Offset = "0x702BDC0", VA = "0x18702CDC0")]
	[AsyncStateMachine(typeof(ALPGOOIMOKF))]
	internal Task<DKMNKHDNIBD> FGOGIGDKMKL(KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, DKMNKHDNIBD MBBLEEHOBKL, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x299A5A0", Offset = "0x29995A0", VA = "0x18299A5A0")]
	private static byte[] AJFKDJJPBMM<T>(T KKHEHGHPOAA) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x299A940", Offset = "0x2999940", VA = "0x18299A940")]
	private static T NPBHBGALNMA<T>(MessageParser<T> ONJKGJJDEDI, byte[] KKHEHGHPOAA, T OEAJJMJNJLF) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x702D400", Offset = "0x702C400", VA = "0x18702D400")]
	[AsyncStateMachine(typeof(DGCJNJKHKOM))]
	private Task<NBGCBMENGBP.KMCMCKPAAIG<DKMNKHDNIBD>> LIEEBHOPDKP(DKMNKHDNIBD MBBLEEHOBKL, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x299A6A0", Offset = "0x29996A0", VA = "0x18299A6A0")]
	[AsyncStateMachine(typeof(ABHOFDBHDGM<>))]
	internal Task<T> EOGLFGNMDKE<T>(CancellationToken CKFCHGJKDBJ, Func<CancellationToken, Task<T>> GJEJKCJONJH, int FABCKMIFAEB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x702CC10", Offset = "0x702BC10", VA = "0x18702CC10")]
	[AsyncStateMachine(typeof(GPCEOBEEJHL))]
	internal Task EOGLFGNMDKE(CancellationToken CKFCHGJKDBJ, Func<CancellationToken, Task> GJEJKCJONJH, int FABCKMIFAEB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x702CD40", Offset = "0x702BD40", VA = "0x18702CD40")]
	public CEAAOANADDL FGGFPCJGODH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x702D140", Offset = "0x702C140", VA = "0x18702D140")]
	public CIMHBHAEHBN IHMEBPAKHII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x702C890", Offset = "0x702B890", VA = "0x18702C890")]
	public OJAJEOGNIKA DMOIDLIFDKL([Optional] PHLKHBEJKKB? IGEICKLFDBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x702D740", Offset = "0x702C740", VA = "0x18702D740")]
	public void OFPJKAFJGEG(Func<Guid, bool> DOFCLDNCPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x702CF20", Offset = "0x702BF20", VA = "0x18702CF20")]
	public void FMJBBLAJHAP(Func<Guid, bool> HNDHIDBAEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x702D1C0", Offset = "0x702C1C0", VA = "0x18702D1C0")]
	public Guid KJENIHKOKOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x702D030", Offset = "0x702C030", VA = "0x18702D030")]
	public void GCAPJOBNHLI(Guid LCGFKFACFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x702D540", Offset = "0x702C540", VA = "0x18702D540")]
	public void NGOOEMAOBBO(DKMNKHDNIBD HKFACMALAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x702CB00", Offset = "0x702BB00", VA = "0x18702CB00")]
	public void ELCBEGJPMKG(string LGEBEMPLMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x299A5B0", Offset = "0x29995B0", VA = "0x18299A5B0")]
	private T DEIMIGNJMEI<T>(T JJCEIJMGOAB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x702C840", Offset = "0x702B840", VA = "0x18702C840")]
	public void AILAMPNEFAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x299AA90", Offset = "0x2999A90", VA = "0x18299AA90")]
	[CompilerGenerated]
	internal static string OEIDEEEFOKM<T>(byte[] KABOAHAAMFF, int BEFMODGHLMP, DPFJHANCABK<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal sealed class BPNGIDOMIDF : DPOAJAMLBLE
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class BBMDACGGEMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public BBMDACGGEMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x704B5E0", Offset = "0x704A5E0", VA = "0x18704B5E0")]
		internal object LGBLPIGLEEK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct FFHKLOEEMAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public BPNGIDOMIDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public CHMMBEKDPCD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private CDHPIBIKHJE <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private CIMHBHAEHBN <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x7051A10", Offset = "0x7050A10", VA = "0x187051A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x70522E0", Offset = "0x70512E0", VA = "0x1870522E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct KNDEKIFCOHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public BPNGIDOMIDF <>4__this;

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
		private TaskAwaiter<AFJNCMKOAEB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x705A3C0", Offset = "0x70593C0", VA = "0x18705A3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x705AB70", Offset = "0x7059B70", VA = "0x18705AB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct NPIDNFNMMOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public BPNGIDOMIDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TaskAwaiter<LHGODKBPKKI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x705F480", Offset = "0x705E480", VA = "0x18705F480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x705F790", Offset = "0x705E790", VA = "0x18705F790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class JNENLJMHLCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public CDHPIBIKHJE presence;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public JNENLJMHLCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x7059D40", Offset = "0x7058D40", VA = "0x187059D40")]
		internal object DDIIDBLKLDK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private static readonly PHLKHBEJKKB COAFAKPLIEO;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private static readonly PHLKHBEJKKB COPEDDECKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private readonly BJEHJDLGDFO OMAGDACDENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private readonly PJAFGDKDHNF JPEEABGAEEM;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x704C430", Offset = "0x704B430", VA = "0x18704C430")]
	public BPNGIDOMIDF(BJEHJDLGDFO OMAGDACDENP, PJAFGDKDHNF JPEEABGAEEM, Guid PHAMLENOBDP, FPLMJHIKMFP ICDIIGEJPGM, MFFPJJNLNNN PPBGNLNGGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x704BE20", Offset = "0x704AE20", VA = "0x18704BE20", Slot = "7")]
	[AsyncStateMachine(typeof(FFHKLOEEMAL))]
	protected override Task BCNNPHGGFAE(CHMMBEKDPCD DIKAKALEHHB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x704C250", Offset = "0x704B250", VA = "0x18704C250")]
	[AsyncStateMachine(typeof(KNDEKIFCOHB))]
	private Task LPFHPMPPIHO(CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x704BF60", Offset = "0x704AF60", VA = "0x18704BF60")]
	[AsyncStateMachine(typeof(NPIDNFNMMOO))]
	private Task<byte> HKANNIDDANB(CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x704C070", Offset = "0x704B070", VA = "0x18704C070")]
	private CDHPIBIKHJE JKHKDBHOEBI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal class FKCPEKHDAAC : DPOAJAMLBLE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct HECNBNGBGAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public FKCPEKHDAAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public CHMMBEKDPCD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private TaskAwaiter<ODCIKMCBEPK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x7054820", Offset = "0x7053820", VA = "0x187054820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x70551A0", Offset = "0x70541A0", VA = "0x1870551A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	private readonly int HKJLDLCKBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	private readonly JEIKNEHGIKE IFMNCMCIJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public readonly long NCHINCKKPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public readonly long GBIALJHJKGH;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public ODCIKMCBEPK HGKHEAIKPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x85FBB0", Offset = "0x85EBB0", VA = "0x18085FBB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x85FB60", Offset = "0x85EB60", VA = "0x18085FB60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x7052B80", Offset = "0x7051B80", VA = "0x187052B80")]
	public FKCPEKHDAAC(Guid PHAMLENOBDP, FPLMJHIKMFP ICDIIGEJPGM, MFFPJJNLNNN PPBGNLNGGGB, int HKJLDLCKBKP, JEIKNEHGIKE IFMNCMCIJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x7052A60", Offset = "0x7051A60", VA = "0x187052A60", Slot = "7")]
	[AsyncStateMachine(typeof(HECNBNGBGAF))]
	protected override Task BCNNPHGGFAE(CHMMBEKDPCD DIKAKALEHHB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal abstract class JCAJCMGAHME : DPOAJAMLBLE
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class KFFNPEOECND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public JCAJCMGAHME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public DEIMABLGJBJ playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public KFFNPEOECND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x7059F10", Offset = "0x7058F10", VA = "0x187059F10")]
		internal Task MDHIPLPDPPA(KLCBNGOGDPF<string>.BPJNBAPCFPO postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x7059E80", Offset = "0x7058E80", VA = "0x187059E80")]
		internal object BOGGCMPHJNI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct MPILHLMLICK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public JCAJCMGAHME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public CHMMBEKDPCD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private KFFNPEOECND <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x705E0C0", Offset = "0x705D0C0", VA = "0x18705E0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x705E880", Offset = "0x705D880", VA = "0x18705E880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct MHFGAHKGABM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public DEIMABLGJBJ playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public JCAJCMGAHME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x705CA90", Offset = "0x705BA90", VA = "0x18705CA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x705D020", Offset = "0x705C020", VA = "0x18705D020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x70583C0", Offset = "0x70573C0", VA = "0x1870583C0")]
	public JCAJCMGAHME(Guid PHAMLENOBDP, FPLMJHIKMFP ICDIIGEJPGM, MFFPJJNLNNN PPBGNLNGGGB, string MAEKNLIEJOJ, FAICFABDAGI HJBPLFIGHKM, bool IJKNKJIHJME = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x7058140", Offset = "0x7057140", VA = "0x187058140", Slot = "7")]
	[AsyncStateMachine(typeof(MPILHLMLICK))]
	protected override Task BCNNPHGGFAE(CHMMBEKDPCD DIKAKALEHHB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task JCBOEOEDADD(CHMMBEKDPCD DIKAKALEHHB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x7058280", Offset = "0x7057280", VA = "0x187058280")]
	[AsyncStateMachine(typeof(MHFGAHKGABM))]
	private Task IEKEILMPEKL(IDisposable FGDMIAIFPHE, DEIMABLGJBJ LOJJNGICKOE, KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal class FKDDIBIKBOH : DPOAJAMLBLE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct BIAMOPCCOME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public FKDDIBIKBOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public CHMMBEKDPCD operationContext;

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
		private TaskAwaiter<EGHPBEBBELB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x704B650", Offset = "0x704A650", VA = "0x18704B650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x704BBC0", Offset = "0x704ABC0", VA = "0x18704BBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly EJEHHNILJEA KAACMIHMDEC;

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x7052EB0", Offset = "0x7051EB0", VA = "0x187052EB0")]
	public FKDDIBIKBOH(Guid PHAMLENOBDP, FPLMJHIKMFP ICDIIGEJPGM, MFFPJJNLNNN PPBGNLNGGGB, EJEHHNILJEA KAACMIHMDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x7052DD0", Offset = "0x7051DD0", VA = "0x187052DD0", Slot = "6")]
	protected override string NEOMCNAGMBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x7052CB0", Offset = "0x7051CB0", VA = "0x187052CB0", Slot = "7")]
	[AsyncStateMachine(typeof(BIAMOPCCOME))]
	protected override Task BCNNPHGGFAE(CHMMBEKDPCD DIKAKALEHHB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal abstract class DPOAJAMLBLE : OLPDJCMCKLE
{
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public delegate Task KHFCEHKCPFN(KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class INJLHDLAPFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public DPOAJAMLBLE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public INJLHDLAPFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x7057F10", Offset = "0x7056F10", VA = "0x187057F10")]
		internal Task HGANEPJBJBP(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class OJELNJJPFEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public INJLHDLAPFC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public OJELNJJPFEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x705FBC0", Offset = "0x705EBC0", VA = "0x18705FBC0")]
		internal object KEEHOLFNPHA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct LDJKFECFONG : IAsyncStateMachine
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
		public DPOAJAMLBLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public Func<DPOAJAMLBLE, KLCBNGOGDPF<string>.BPJNBAPCFPO, CHMMBEKDPCD> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private INJLHDLAPFC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private CHMMBEKDPCD <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private TaskAwaiter<DKMNKHDNIBD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x705ABD0", Offset = "0x7059BD0", VA = "0x18705ABD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x705BCD0", Offset = "0x705ACD0", VA = "0x18705BCD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct HHPIADFFGFM : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x70564A0", Offset = "0x70554A0", VA = "0x1870564A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x7056F30", Offset = "0x7055F30", VA = "0x187056F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct OANPANADNMN : IAsyncStateMachine
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
		public DPOAJAMLBLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x705F800", Offset = "0x705E800", VA = "0x18705F800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x705FB60", Offset = "0x705EB60", VA = "0x18705FB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public readonly Guid NOFPFFHHHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public readonly ByteString OMLDJBAEGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public readonly MFFPJJNLNNN KMIHJPCHPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	protected readonly string CHFLDHEIHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private readonly FPLMJHIKMFP ICDIIGEJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private readonly bool IJKNKJIHJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly Queue<KHFCEHKCPFN> CLKNCIBFLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly FBMPPIILJHC NFKDCNOMGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly FAICFABDAGI HJBPLFIGHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private bool GKCBLBMGJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public DFIBCMGCDHD HDNHGMBLANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public DFIBCMGCDHD BHCMBGPPIGJ;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public FPLMJHIKMFP BJDOHINMMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850840", VA = "0x180851840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public ICFBHJEIGMP POFCPOIIAOI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x704F280", Offset = "0x704E280", VA = "0x18704F280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public MJLNBIEJOCH GKPJHEDALLP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x704F190", Offset = "0x704E190", VA = "0x18704F190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public IIBKIJCPLOJ AGEBIJJODLL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x704F110", Offset = "0x704E110", VA = "0x18704F110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event DFELLKFGNIL AOGBJAPDPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x704F1E0", Offset = "0x704E1E0", VA = "0x18704F1E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x704F200", Offset = "0x704E200", VA = "0x18704F200", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x704FB40", Offset = "0x704EB40", VA = "0x18704FB40")]
	protected DPOAJAMLBLE(Guid PHAMLENOBDP, FPLMJHIKMFP ICDIIGEJPGM, MFFPJJNLNNN PPBGNLNGGGB, string MAEKNLIEJOJ, FAICFABDAGI HJBPLFIGHKM, bool IJKNKJIHJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x704F8A0", Offset = "0x704E8A0", VA = "0x18704F8A0", Slot = "6")]
	protected virtual string NEOMCNAGMBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x704F220", Offset = "0x704E220", VA = "0x18704F220")]
	public void EICHKLFBGKG(KHFCEHKCPFN LNCBFFLCGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x704F6E0", Offset = "0x704E6E0", VA = "0x18704F6E0")]
	protected void MFACPPFIMIM(float GEMGCEDHMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x704F8E0", Offset = "0x704E8E0", VA = "0x18704F8E0")]
	[AsyncStateMachine(typeof(LDJKFECFONG))]
	public Task PCBFBKDIPKL(CancellationToken LABHBAHABKB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, [Optional] Func<DPOAJAMLBLE, KLCBNGOGDPF<string>.BPJNBAPCFPO, CHMMBEKDPCD> DBNFKINDPDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x704F5B0", Offset = "0x704E5B0", VA = "0x18704F5B0")]
	[AsyncStateMachine(typeof(HHPIADFFGFM))]
	private static Task KFBMGEBDADJ(Func<CancellationToken, Task> MHLCNKPDFMM, Func<CancellationToken, Task> EGDBDIFACOK, CancellationToken CKFCHGJKDBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x704F440", Offset = "0x704E440", VA = "0x18704F440")]
	private void IGNMOFOGIKB(bool ADMMLGCNPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x704FA30", Offset = "0x704EA30", VA = "0x18704FA30")]
	private void PGOCPKGKLFJ(CHMMBEKDPCD DIKAKALEHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task BCNNPHGGFAE(CHMMBEKDPCD DIKAKALEHHB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x704F700", Offset = "0x704E700", VA = "0x18704F700")]
	[AsyncStateMachine(typeof(OANPANADNMN))]
	private Task MKEKBBIOCCC(KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x704F820", Offset = "0x704E820", VA = "0x18704F820")]
	public DKMNKHDNIBD MKFDNCJHDEE(ANJDLGFKNMD BLCBEKOFNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x704F350", Offset = "0x704E350", VA = "0x18704F350")]
	[CompilerGenerated]
	private Task FHFBLPCAPKB(CancellationToken IGKMAMABJBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x704F2D0", Offset = "0x704E2D0", VA = "0x18704F2D0")]
	[CompilerGenerated]
	private object FBIOEFEJPHG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal sealed class BKLODGPKLHA : JCAJCMGAHME
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct JFOCOHGGEGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public BKLODGPKLHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public CHMMBEKDPCD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private HHPMLGFPHIL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private CIMHBHAEHBN <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x7058410", Offset = "0x7057410", VA = "0x187058410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x7058B80", Offset = "0x7057B80", VA = "0x187058B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	private readonly BJEHJDLGDFO EKCOBHILKMC;

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x704BD70", Offset = "0x704AD70", VA = "0x18704BD70")]
	public BKLODGPKLHA(Guid PHAMLENOBDP, FPLMJHIKMFP ICDIIGEJPGM, BJEHJDLGDFO EKCOBHILKMC, MFFPJJNLNNN PPBGNLNGGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x704BC20", Offset = "0x704AC20", VA = "0x18704BC20", Slot = "8")]
	[AsyncStateMachine(typeof(JFOCOHGGEGJ))]
	protected override Task JCBOEOEDADD(CHMMBEKDPCD DIKAKALEHHB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal class FIGMNNFAJJB : DPOAJAMLBLE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct NOPNJEAKGBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public FIGMNNFAJJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public CHMMBEKDPCD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private TaskAwaiter<EGHPBEBBELB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x705F070", Offset = "0x705E070", VA = "0x18705F070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x705F420", Offset = "0x705E420", VA = "0x18705F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private readonly string LHEGNOINOAB;

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x70529B0", Offset = "0x70519B0", VA = "0x1870529B0")]
	public FIGMNNFAJJB(Guid PHAMLENOBDP, FPLMJHIKMFP ICDIIGEJPGM, MFFPJJNLNNN PPBGNLNGGGB, string LHEGNOINOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x70528A0", Offset = "0x70518A0", VA = "0x1870528A0", Slot = "7")]
	[AsyncStateMachine(typeof(NOPNJEAKGBE))]
	protected override Task BCNNPHGGFAE(CHMMBEKDPCD DIKAKALEHHB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal class OLMALHOAKIC : JCAJCMGAHME
{
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class KLHFNBJDIJF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000118")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public AsyncTaskMethodBuilder<DKMNKHDNIBD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public KLHFNBJDIJF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<EGHPBEBBELB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			private TaskAwaiter<DKMNKHDNIBD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x7062FF0", Offset = "0x7061FF0", VA = "0x187062FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x70634B0", Offset = "0x70624B0", VA = "0x1870634B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public OLMALHOAKIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public OJAJEOGNIKA serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public HAGLFGFJMBC roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public CEAAOANADDL uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public PEDLLJADMJP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public KLHFNBJDIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x705A2A0", Offset = "0x70592A0", VA = "0x18705A2A0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<DKMNKHDNIBD> LBLGPPPGLFJ(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct FBNJOHLKLDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public OLMALHOAKIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public CHMMBEKDPCD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private KLHFNBJDIJF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private HHPMLGFPHIL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private CIMHBHAEHBN <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private DKMNKHDNIBD <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private TaskAwaiter<DKMNKHDNIBD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x7050A50", Offset = "0x704FA50", VA = "0x187050A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x70519B0", Offset = "0x70509B0", VA = "0x1870519B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private static readonly PHLKHBEJKKB COAFAKPLIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly int BENCOAFHAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	[CanBeNull]
	private readonly CIIAAADNGNH PFJJPJNHLEK;

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x7060140", Offset = "0x705F140", VA = "0x187060140")]
	public OLMALHOAKIC(Guid PHAMLENOBDP, FPLMJHIKMFP ICDIIGEJPGM, int BENCOAFHAIE, CIIAAADNGNH PFJJPJNHLEK, MFFPJJNLNNN PPBGNLNGGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x705FF50", Offset = "0x705EF50", VA = "0x18705FF50", Slot = "8")]
	[AsyncStateMachine(typeof(FBNJOHLKLDG))]
	protected override Task JCBOEOEDADD(CHMMBEKDPCD DIKAKALEHHB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x705FE50", Offset = "0x705EE50", VA = "0x18705FE50")]
	private void DNHJHFCJPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x705FC80", Offset = "0x705EC80", VA = "0x18705FC80")]
	private void CNJLCLMLOCD(KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, HHPMLGFPHIL EEMEFKGLBBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal abstract class OOFNBODDNMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public readonly DPOAJAMLBLE HLLOKKDEOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public readonly CHMMBEKDPCD KAFKNMHNCMH;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public ICFBHJEIGMP POFCPOIIAOI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x70602A0", Offset = "0x705F2A0", VA = "0x1870602A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public IIBKIJCPLOJ AGEBIJJODLL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x70601F0", Offset = "0x705F1F0", VA = "0x1870601F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x70602F0", Offset = "0x705F2F0", VA = "0x1870602F0")]
	protected OOFNBODDNMA(CHMMBEKDPCD DIKAKALEHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x7060280", Offset = "0x705F280", VA = "0x187060280")]
	protected void ELCBEGJPMKG(string LGEBEMPLMEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct MPPNEAHKNLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public Dictionary<Guid, List<BDMLKBHGMHN>> AMPJDGIGJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public Dictionary<Guid, List<BDMLKBHGMHN>> BGJGJMHKPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public Dictionary<Guid, List<BDMLKBHGMHN>> HDEJOHKHNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public List<Guid> DDOFIKBCCOD;

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x705E8E0", Offset = "0x705D8E0", VA = "0x18705E8E0")]
	public static MPPNEAHKNLC MKHPGHPCCLG(ICFBHJEIGMP LCGMLIBOFMO, DFIBCMGCDHD DABMNPGCDJD, PEJDOCBEAIB HIEPBFNGDPK)
	{
		return default(MPPNEAHKNLC);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal struct CJHGKMEIBKI
{
	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950")]
	public static CJHGKMEIBKI EAPGIKBOING()
	{
		return default(CJHGKMEIBKI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct GFPOIMFJFNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public readonly AFJNCMKOAEB DGCGCONGDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public readonly NGELDFKPLFG OKJLNEFMDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public readonly string HIFKBGMPOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public readonly KIDKIHLFPDC LDGJIBHMHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public readonly KIDKIHLFPDC BIDAIDJLFGN;

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x7053A20", Offset = "0x7052A20", VA = "0x187053A20")]
	public GFPOIMFJFNK(AFJNCMKOAEB DGCGCONGDDJ, NGELDFKPLFG OKJLNEFMDKL, string HIFKBGMPOPE, KIDKIHLFPDC LDGJIBHMHDH, KIDKIHLFPDC BIDAIDJLFGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct DEPODBDMDFL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private readonly CHMMBEKDPCD DIKAKALEHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private readonly Guid LCGFKFACFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private bool ADMMLGCNPFE;

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x704E820", Offset = "0x704D820", VA = "0x18704E820")]
	public static DEPODBDMDFL KJENIHKOKOC(CHMMBEKDPCD DIKAKALEHHB)
	{
		return default(DEPODBDMDFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0xA81B00", Offset = "0xA80B00", VA = "0x180A81B00")]
	public void LDGPDMNENCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x704E7C0", Offset = "0x704D7C0", VA = "0x18704E7C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x704E920", Offset = "0x704D920", VA = "0x18704E920")]
	private DEPODBDMDFL(CHMMBEKDPCD DIKAKALEHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x704E7C0", Offset = "0x704D7C0", VA = "0x18704E7C0")]
	private void GCAPJOBNHLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x704E880", Offset = "0x704D880", VA = "0x18704E880")]
	private Func<Guid, bool> PEIJFHOKLJB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal class CIMHBHAEHBN : OOFNBODDNMA, OLPDJCMCKLE
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public delegate Task<DFIBCMGCDHD> IPPHJLHJFAM(PEJDOCBEAIB AHGAPHMJDIB, OEADBKPHHAK MMGBHLNAJKI, FBMPPIILJHC IAIDAFICOOB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct PKFCBFIMFMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public BJEHJDLGDFO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private DEPODBDMDFL <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private TaskAwaiter<DKMNKHDNIBD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x70612D0", Offset = "0x70602D0", VA = "0x1870612D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x7061A40", Offset = "0x7060A40", VA = "0x187061A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct HFBDABNKLGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public AsyncTaskMethodBuilder<DKMNKHDNIBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public BJEHJDLGDFO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private TaskAwaiter<DKMNKHDNIBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x7055480", Offset = "0x7054480", VA = "0x187055480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x7055890", Offset = "0x7054890", VA = "0x187055890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct GEMLDHMBEMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public BJEHJDLGDFO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x70534C0", Offset = "0x70524C0", VA = "0x1870534C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x7053950", Offset = "0x7052950", VA = "0x187053950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class FICKOGDNDCB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public AsyncTaskMethodBuilder<GFPOIMFJFNK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public FICKOGDNDCB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private GFPOIMFJFNK <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			private TaskAwaiter<DFIBCMGCDHD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private TaskAwaiter<GFPOIMFJFNK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x7061AA0", Offset = "0x7060AA0", VA = "0x187061AA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x7062230", Offset = "0x7061230", VA = "0x187062230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public AsyncTaskMethodBuilder<PEJDOCBEAIB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public FICKOGDNDCB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			private PEJDOCBEAIB <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			private TaskAwaiter<DFIBCMGCDHD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private TaskAwaiter<PEJDOCBEAIB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x70622A0", Offset = "0x70612A0", VA = "0x1870622A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x70628F0", Offset = "0x70618F0", VA = "0x1870628F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public BJEHJDLGDFO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public FBMPPIILJHC preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public FBMPPIILJHC downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public GFPOIMFJFNK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public FBMPPIILJHC postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public PEJDOCBEAIB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public HBJBOCABMJK.JBEGGCMHJHB <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public FICKOGDNDCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x7052760", Offset = "0x7051760", VA = "0x187052760")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<GFPOIMFJFNK> OPIIBFJHIHF(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x7052600", Offset = "0x7051600", VA = "0x187052600")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<PEJDOCBEAIB> LLKHAHMFLDM(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7052720", Offset = "0x7051720", VA = "0x187052720")]
		internal void OHIHMCBFAOB(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x70524A0", Offset = "0x70514A0", VA = "0x1870524A0")]
		internal Task EGHJEANCPDB(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x7052340", Offset = "0x7051340", VA = "0x187052340")]
		internal Task ABDNAGHJEON(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct EKNADGLPOEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public BJEHJDLGDFO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private FICKOGDNDCB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private TaskAwaiter<GFPOIMFJFNK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter<PEJDOCBEAIB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x704FCA0", Offset = "0x704ECA0", VA = "0x18704FCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x70509F0", Offset = "0x704F9F0", VA = "0x1870509F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct PIDKFFNGLAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public PEJDOCBEAIB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public FBMPPIILJHC postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private TaskAwaiter<DFIBCMGCDHD> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private OEADBKPHHAK <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x7060350", Offset = "0x705F350", VA = "0x187060350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x7061270", Offset = "0x7060270", VA = "0x187061270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct HCLIFNCNEAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x7053F10", Offset = "0x7052F10", VA = "0x187053F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x70547C0", Offset = "0x70537C0", VA = "0x1870547C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct MAAINPDPMAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public FBMPPIILJHC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private TaskAwaiter<DFIBCMGCDHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x705BDA0", Offset = "0x705ADA0", VA = "0x18705BDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x705C720", Offset = "0x705B720", VA = "0x18705C720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct MMOMJOLLMEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AsyncTaskMethodBuilder<DFIBCMGCDHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public FBMPPIILJHC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private TaskAwaiter<DFIBCMGCDHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x705D080", Offset = "0x705C080", VA = "0x18705D080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x705E050", Offset = "0x705D050", VA = "0x18705E050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct JHGOAPGDHAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public AsyncTaskMethodBuilder<DFIBCMGCDHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public FBMPPIILJHC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public OEADBKPHHAK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter<DFIBCMGCDHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x7058BE0", Offset = "0x7057BE0", VA = "0x187058BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x7059CD0", Offset = "0x7058CD0", VA = "0x187059CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct MDECCCBFCDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public AsyncTaskMethodBuilder<DFIBCMGCDHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public DFIBCMGCDHD operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public FBMPPIILJHC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public PEJDOCBEAIB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private TaskAwaiter<DFIBCMGCDHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x705C780", Offset = "0x705B780", VA = "0x18705C780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x705CA20", Offset = "0x705BA20", VA = "0x18705CA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class NGBPEKLIEPF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000131")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			public AsyncTaskMethodBuilder<DFIBCMGCDHD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			public NGBPEKLIEPF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			private KNFEKPELEMG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private TaskAwaiter<DFIBCMGCDHD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x7062960", Offset = "0x7061960", VA = "0x187062960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000530")]
			[Cpp2IlInjected.Address(RVA = "0x7062F80", Offset = "0x7061F80", VA = "0x187062F80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public FBMPPIILJHC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public IPPHJLHJFAM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public OEADBKPHHAK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public DFIBCMGCDHD originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public NGBPEKLIEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x705EF50", Offset = "0x705DF50", VA = "0x18705EF50")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<DFIBCMGCDHD> IFDDAIKPHID(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private struct FMLMDIPJFLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public AsyncTaskMethodBuilder<DFIBCMGCDHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public FBMPPIILJHC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public IPPHJLHJFAM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public OEADBKPHHAK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter<DFIBCMGCDHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x7052F50", Offset = "0x7051F50", VA = "0x187052F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x7053450", Offset = "0x7052450", VA = "0x187053450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct CAMLEEKPBOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public FBMPPIILJHC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private DFIBCMGCDHD <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private IEnumerator<DFIBCMGCDHD> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private TaskAwaiter<DFIBCMGCDHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x704C5C0", Offset = "0x704B5C0", VA = "0x18704C5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x704CAF0", Offset = "0x704BAF0", VA = "0x18704CAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct HFAPAOAJEKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x7055200", Offset = "0x7054200", VA = "0x187055200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x7055420", Offset = "0x7054420", VA = "0x187055420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct KILPOMEAGMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x705A0A0", Offset = "0x70590A0", VA = "0x18705A0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x705A240", Offset = "0x7059240", VA = "0x18705A240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct IDBEABEIONJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public PEJDOCBEAIB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public FBMPPIILJHC postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private TaskAwaiter<DFIBCMGCDHD> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private OEADBKPHHAK <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x7056F90", Offset = "0x7055F90", VA = "0x187056F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x7057EB0", Offset = "0x7056EB0", VA = "0x187057EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct HHJBFGDJAAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public AsyncTaskMethodBuilder<DFIBCMGCDHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public CIMHBHAEHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public FBMPPIILJHC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private TaskAwaiter<DFIBCMGCDHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x7055900", Offset = "0x7054900", VA = "0x187055900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x7056430", Offset = "0x7055430", VA = "0x187056430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly AIBHHEDLNAL CBOLEIBNEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly AIBHHEDLNAL DAPFHIILJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly IOEEDLJNEAH CNHDNJOLLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly ANLKNCKJJKC KJGMDNHKDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private readonly ILEDMAAEHFG PONGNPHONCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private ProfilerCounterValue<int> EBJCIAECGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly APGNEMKOEFL HBCKFHMPDNA;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private FPLMJHIKMFP BJDOHINMMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x704CB90", Offset = "0x704BB90", VA = "0x18704CB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event DFELLKFGNIL AOGBJAPDPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x704D150", Offset = "0x704C150", VA = "0x18704D150", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x704D5F0", Offset = "0x704C5F0", VA = "0x18704D5F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x704E420", Offset = "0x704D420", VA = "0x18704E420")]
	public CIMHBHAEHBN(CHMMBEKDPCD DIKAKALEHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x704E1C0", Offset = "0x704D1C0", VA = "0x18704E1C0")]
	[AsyncStateMachine(typeof(PKFCBFIMFMI))]
	public Task PDCFCFIKGPO(BJEHJDLGDFO HHNBCLDGHCL, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x704DC60", Offset = "0x704CC60", VA = "0x18704DC60")]
	[AsyncStateMachine(typeof(HFBDABNKLGB))]
	private Task<DKMNKHDNIBD> LFFGNDPMGPI(BJEHJDLGDFO HHNBCLDGHCL, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x704CEB0", Offset = "0x704BEB0", VA = "0x18704CEB0")]
	[AsyncStateMachine(typeof(GEMLDHMBEMI))]
	private Task CHGHDPCAMLF(BJEHJDLGDFO HHNBCLDGHCL, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x704D170", Offset = "0x704C170", VA = "0x18704D170")]
	[AsyncStateMachine(typeof(EKNADGLPOEO))]
	private Task DAHFLBDLPEA(BJEHJDLGDFO HHNBCLDGHCL, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken CGLPGIDKHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x704DE30", Offset = "0x704CE30", VA = "0x18704DE30")]
	[AsyncStateMachine(typeof(PIDKFFNGLAA))]
	private Task MNEPMKPIKHD(PEJDOCBEAIB KLDAEFEPLOB, FBMPPIILJHC AOHLPBMHBEN, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken MEDFKMALJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x704E310", Offset = "0x704D310", VA = "0x18704E310")]
	[AsyncStateMachine(typeof(HCLIFNCNEAI))]
	private Task PNLICJKICOP(KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x704CD10", Offset = "0x704BD10", VA = "0x18704CD10")]
	[AsyncStateMachine(typeof(MAAINPDPMAH))]
	private Task ANOJKBPDOIF(PEJDOCBEAIB AHGAPHMJDIB, FBMPPIILJHC IAIDAFICOOB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x704D490", Offset = "0x704C490", VA = "0x18704D490")]
	[AsyncStateMachine(typeof(MMOMJOLLMEM))]
	private Task<DFIBCMGCDHD> EBIJGGKBHDM(PEJDOCBEAIB AHGAPHMJDIB, OEADBKPHHAK LOPOCHJNEPN, FBMPPIILJHC IAIDAFICOOB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x704D8A0", Offset = "0x704C8A0", VA = "0x18704D8A0")]
	[AsyncStateMachine(typeof(JHGOAPGDHAE))]
	private Task<DFIBCMGCDHD> JMBFGHGFPAL(PEJDOCBEAIB AHGAPHMJDIB, OEADBKPHHAK LOPOCHJNEPN, FBMPPIILJHC IAIDAFICOOB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x704D2B0", Offset = "0x704C2B0", VA = "0x18704D2B0")]
	[AsyncStateMachine(typeof(MDECCCBFCDK))]
	private Task<DFIBCMGCDHD> DBEIHPOPKIF(DFIBCMGCDHD DABMNPGCDJD, PEJDOCBEAIB HIEPBFNGDPK, FBMPPIILJHC IAIDAFICOOB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB, bool HKMLNAACEBH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x704D610", Offset = "0x704C610", VA = "0x18704D610")]
	private bool FBCNFNCEOFF(PEJDOCBEAIB KLDAEFEPLOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x704DF80", Offset = "0x704CF80", VA = "0x18704DF80")]
	[AsyncStateMachine(typeof(FMLMDIPJFLJ))]
	protected Task<DFIBCMGCDHD> NAENCNHNAMA(PEJDOCBEAIB AHGAPHMJDIB, OEADBKPHHAK LOPOCHJNEPN, FBMPPIILJHC IAIDAFICOOB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB, IPPHJLHJFAM ODBKGKMGEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x704D730", Offset = "0x704C730", VA = "0x18704D730")]
	[AsyncStateMachine(typeof(CAMLEEKPBOM))]
	private Task IOIOIPFCGNC(PEJDOCBEAIB AHGAPHMJDIB, FBMPPIILJHC IAIDAFICOOB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x704E110", Offset = "0x704D110", VA = "0x18704E110")]
	private void NDOGMCIFKDE(DFIBCMGCDHD DCNHNFDAJKN, FBMPPIILJHC IAIDAFICOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x704E160", Offset = "0x704D160", VA = "0x18704E160")]
	private void NLFHBMLHFPE(DFIBCMGCDHD KKJADBGDBBH, [Out] DFIBCMGCDHD NJNABPDPEBH, [Out] DFIBCMGCDHD HMKCEEHAKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x704CB50", Offset = "0x704BB50", VA = "0x18704CB50")]
	private Task<GFPOIMFJFNK> ADAECPLGGFH(BJEHJDLGDFO HHNBCLDGHCL, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x704D450", Offset = "0x704C450", VA = "0x18704D450")]
	private Task<PEJDOCBEAIB> DNLCBJIDDDA(GFPOIMFJFNK AHGAPHMJDIB, HBJBOCABMJK.JBEGGCMHJHB KDGKOEFHGEK, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x704CBC0", Offset = "0x704BBC0", VA = "0x18704CBC0")]
	[AsyncStateMachine(typeof(HFAPAOAJEKA))]
	private Task AMLNEIOFEHI(PEJDOCBEAIB AHGAPHMJDIB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB, bool IIDODNJPOHL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x704DB70", Offset = "0x704CB70", VA = "0x18704DB70")]
	[AsyncStateMachine(typeof(KILPOMEAGMJ))]
	private Task KMDAHJGAPLP(PEJDOCBEAIB AHGAPHMJDIB, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x704DDE0", Offset = "0x704CDE0", VA = "0x18704DDE0")]
	private Task MLMDJECENJL(PEJDOCBEAIB AHGAPHMJDIB, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x704D880", Offset = "0x704C880", VA = "0x18704D880")]
	private Task JEJKBIKEIAA(PEJDOCBEAIB AHGAPHMJDIB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x704D710", Offset = "0x704C710", VA = "0x18704D710")]
	private Task IEILEKNELFM(PEJDOCBEAIB AHGAPHMJDIB, OEADBKPHHAK LOPOCHJNEPN, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x704DDC0", Offset = "0x704CDC0", VA = "0x18704DDC0")]
	private Task LGFAPJFOIHE(PEJDOCBEAIB AHGAPHMJDIB, OEADBKPHHAK LOPOCHJNEPN, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x704D700", Offset = "0x704C700", VA = "0x18704D700")]
	private static Task FOJHOEIPNGH(CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x704DE10", Offset = "0x704CE10", VA = "0x18704DE10")]
	private Task MNEHLFGCAGE(PEJDOCBEAIB AHGAPHMJDIB, OEADBKPHHAK LOPOCHJNEPN, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x704E1A0", Offset = "0x704D1A0", VA = "0x18704E1A0")]
	private Task OHKAKCGHBLO(PEJDOCBEAIB AHGAPHMJDIB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x704CE60", Offset = "0x704BE60", VA = "0x18704CE60")]
	private void BDGDDELLHED(BJEHJDLGDFO HHNBCLDGHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x704D430", Offset = "0x704C430", VA = "0x18704D430")]
	public void DKDBDDNNJEM(long ONBLDGLEBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	private static void IHKKIOHBLBO(AFJNCMKOAEB DGCGCONGDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x704DA20", Offset = "0x704CA20", VA = "0x18704DA20")]
	[AsyncStateMachine(typeof(IDBEABEIONJ))]
	private Task KCDHIGGKEAC(PEJDOCBEAIB KLDAEFEPLOB, FBMPPIILJHC AOHLPBMHBEN, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken MEDFKMALJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x704CFF0", Offset = "0x704BFF0", VA = "0x18704CFF0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(HHJBFGDJAAL))]
	private Task<DFIBCMGCDHD> CIKJGMBGMJN(PEJDOCBEAIB AHGAPHMJDIB, OEADBKPHHAK LOPOCHJNEPN, FBMPPIILJHC IAIDAFICOOB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct FNKDIHAOGOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private FPLMJHIKMFP ICDIIGEJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private PEJDOCBEAIB AHGAPHMJDIB;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private ICFBHJEIGMP POFCPOIIAOI
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x706D700", Offset = "0x706C700", VA = "0x18706D700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x706D970", Offset = "0x706C970", VA = "0x18706D970")]
	public static Task PCBFBKDIPKL(FPLMJHIKMFP ICDIIGEJPGM, PEJDOCBEAIB AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x706D750", Offset = "0x706C750", VA = "0x18706D750")]
	private void PCBFBKDIPKL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct IGPNEFJKENG
{
	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x70703E0", Offset = "0x706F3E0", VA = "0x1870703E0")]
	public static Task PCBFBKDIPKL(CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct BBAHCLFCMAK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct EKGAGMKJLAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public CHMMBEKDPCD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x706B4A0", Offset = "0x706A4A0", VA = "0x18706B4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x706B9C0", Offset = "0x706A9C0", VA = "0x18706B9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x70667F0", Offset = "0x70657F0", VA = "0x1870667F0")]
	[AsyncStateMachine(typeof(EKGAGMKJLAH))]
	public static Task PCBFBKDIPKL(CHMMBEKDPCD DIKAKALEHHB, PEJDOCBEAIB AHGAPHMJDIB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct MHKBCILCEIL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct BFLCDMIJONG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public CHMMBEKDPCD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public OEADBKPHHAK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private DFIBCMGCDHD <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private FPLMJHIKMFP <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private ICFBHJEIGMP <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private KNFEKPELEMG <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private List<(PersistenceView, ENFIPLJHHAN)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private ENFIPLJHHAN <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x7066930", Offset = "0x7065930", VA = "0x187066930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x70675B0", Offset = "0x70665B0", VA = "0x1870675B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x70761E0", Offset = "0x70751E0", VA = "0x1870761E0")]
	[AsyncStateMachine(typeof(BFLCDMIJONG))]
	public static Task PCBFBKDIPKL(CHMMBEKDPCD DIKAKALEHHB, PEJDOCBEAIB AHGAPHMJDIB, OEADBKPHHAK LOPOCHJNEPN, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x7075FE0", Offset = "0x7074FE0", VA = "0x187075FE0")]
	private static void BBGMPIAKKOE(PersistenceView KHKFEBPAGAG, ENFIPLJHHAN HNOBJNPONNI, PEJDOCBEAIB AHGAPHMJDIB, DFIBCMGCDHD DABMNPGCDJD, bool CDGBDCOGIEM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct IFLMPBKKLPJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct OPCNNNKOCGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public FPLMJHIKMFP roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x7079A70", Offset = "0x7078A70", VA = "0x187079A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x7079EB0", Offset = "0x7078EB0", VA = "0x187079EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x70702D0", Offset = "0x706F2D0", VA = "0x1870702D0")]
	[AsyncStateMachine(typeof(OPCNNNKOCGM))]
	public static Task PCBFBKDIPKL(FPLMJHIKMFP ICDIIGEJPGM, PEJDOCBEAIB AHGAPHMJDIB, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct PABGNCALCDG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct FPBGBLBLEPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public FPLMJHIKMFP roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public CHMMBEKDPCD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x706DB90", Offset = "0x706CB90", VA = "0x18706DB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x706DDA0", Offset = "0x706CDA0", VA = "0x18706DDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class NNIPBNGHEAE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000144")]
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
			public KLCBNGOGDPF<string>.BPJNBAPCFPO timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			public NNIPBNGHEAE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0x707C670", Offset = "0x707B670", VA = "0x18707C670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x707CA00", Offset = "0x707BA00", VA = "0x18707CA00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public NNIPBNGHEAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x7077B60", Offset = "0x7076B60", VA = "0x187077B60")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task EKLLFNHIHHJ(KLCBNGOGDPF<string>.BPJNBAPCFPO timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct JHGDBHCFMGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public PABGNCALCDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter<DKMNKHDNIBD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x7072740", Offset = "0x7071740", VA = "0x187072740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x7073100", Offset = "0x7072100", VA = "0x187073100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class MAIHAEDKGFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public EBLAFNHPHNO version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public MAIHAEDKGFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x7075470", Offset = "0x7074470", VA = "0x187075470")]
		internal object GJJADFDHCIG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x70753C0", Offset = "0x70743C0", VA = "0x1870753C0")]
		internal object CNPLFHOJCPM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private FPLMJHIKMFP ICDIIGEJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private PEJDOCBEAIB AHGAPHMJDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private CHMMBEKDPCD DIKAKALEHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private bool IIDODNJPOHL;

	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private static readonly ByteString IFAIHFNKLDM;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private ICFBHJEIGMP POFCPOIIAOI
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x707A690", Offset = "0x7079690", VA = "0x18707A690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private IIBKIJCPLOJ AGEBIJJODLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x7079F50", Offset = "0x7078F50", VA = "0x187079F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x707A820", Offset = "0x7079820", VA = "0x18707A820")]
	[AsyncStateMachine(typeof(FPBGBLBLEPC))]
	public static Task PCBFBKDIPKL(FPLMJHIKMFP ICDIIGEJPGM, PEJDOCBEAIB AHGAPHMJDIB, CHMMBEKDPCD DIKAKALEHHB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB, bool IIDODNJPOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x707A6E0", Offset = "0x70796E0", VA = "0x18707A6E0")]
	[AsyncStateMachine(typeof(JHGDBHCFMGD))]
	private Task PCBFBKDIPKL(KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x7079FF0", Offset = "0x7078FF0", VA = "0x187079FF0")]
	private void AMFENEBCMGD([NotNull] KECMDPPEFHG EMKHAEJLEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x7079F10", Offset = "0x7078F10", VA = "0x187079F10")]
	private bool ABAKAPCEFBI(EBLAFNHPHNO FFOAGBHJNBO, KECMDPPEFHG EMKHAEJLEFJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal struct CAEEOILMKPN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct JGNNHIGGNPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public AsyncTaskMethodBuilder<PEJDOCBEAIB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public CAEEOILMKPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public HBJBOCABMJK.JBEGGCMHJHB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private TaskAwaiter<(DFAHBLOKBPH<EHINFMJDBCM, DNBIAPHIKOM>, DFAHBLOKBPH<LMMNLPJCOOL<KECMDPPEFHG>, DNBIAPHIKOM>, DFAHBLOKBPH<LMMNLPJCOOL<OPGPLFDAFEE>, DNBIAPHIKOM>, DFAHBLOKBPH<LMMNLPJCOOL<DJMMCDEOJKM>, DNBIAPHIKOM>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x7071C20", Offset = "0x7070C20", VA = "0x187071C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x70726D0", Offset = "0x70716D0", VA = "0x1870726D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct LHNCNAFPHFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<EHINFMJDBCM, DNBIAPHIKOM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public CAEEOILMKPN <>4__this;

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
		public HBJBOCABMJK.JBEGGCMHJHB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private TaskAwaiter<DFAHBLOKBPH<EHINFMJDBCM, DNBIAPHIKOM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x7074880", Offset = "0x7073880", VA = "0x187074880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x7074E90", Offset = "0x7073E90", VA = "0x187074E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	private PFOAELAJAGO<KIDKIHLFPDC, OPGPLFDAFEE> NOPBALHLBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private PFOAELAJAGO<KIDKIHLFPDC, KECMDPPEFHG> DFFJFEHHHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private PFOAELAJAGO<long, DJMMCDEOJKM> EFHKBDDAPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private JDADNFIBCCJ FBHBHBMKLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private AFJNCMKOAEB DGCGCONGDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private NGELDFKPLFG OKJLNEFMDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private string HIFKBGMPOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private KIDKIHLFPDC LDGJIBHMHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private KIDKIHLFPDC BIDAIDJLFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private long ONBLDGLEBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ;

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x7068530", Offset = "0x7067530", VA = "0x187068530")]
	public static Task<PEJDOCBEAIB> HKKEBMAHFIA(FPLMJHIKMFP ICDIIGEJPGM, [In] GFPOIMFJFNK AHGAPHMJDIB, HBJBOCABMJK.JBEGGCMHJHB KDGKOEFHGEK, KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x70688A0", Offset = "0x70678A0", VA = "0x1870688A0")]
	[AsyncStateMachine(typeof(JGNNHIGGNPK))]
	private Task<PEJDOCBEAIB> PCBFBKDIPKL(HBJBOCABMJK.JBEGGCMHJHB KDGKOEFHGEK, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x7068370", Offset = "0x7067370", VA = "0x187068370")]
	[AsyncStateMachine(typeof(LHNCNAFPHFP))]
	private Task<DFAHBLOKBPH<EHINFMJDBCM, DNBIAPHIKOM>> BPCIKCMMINL(string HIFKBGMPOPE, long ONBLDGLEBND, long? MFLLPFDNGGL, long? KNEHMNKKPOH, HBJBOCABMJK.JBEGGCMHJHB KDGKOEFHGEK, KLCBNGOGDPF<string>.BPJNBAPCFPO GJIGMCDFOJJ, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal struct EFAKPDLMMFJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct BAFJJOFIBNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public AsyncTaskMethodBuilder<GFPOIMFJFNK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public EFAKPDLMMFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private TaskAwaiter<GFPOIMFJFNK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x7066380", Offset = "0x7065380", VA = "0x187066380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x7066780", Offset = "0x7065780", VA = "0x187066780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct OOCKBDPHBLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public AsyncTaskMethodBuilder<GFPOIMFJFNK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public EFAKPDLMMFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter<GFPOIMFJFNK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x70795D0", Offset = "0x70785D0", VA = "0x1870795D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x7079A00", Offset = "0x7078A00", VA = "0x187079A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class ILAJBNBCGPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public ILAJBNBCGPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xA05D40", Offset = "0xA04D40", VA = "0x180A05D40")]
		internal bool AGBDNALJHOI(NGELDFKPLFG sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct PMKKPFACMAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public AsyncTaskMethodBuilder<GFPOIMFJFNK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public KIDKIHLFPDC superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public ICFBHJEIGMP callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private ILAJBNBCGPH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public HNEMDIOKFMA roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private AFJNCMKOAEB <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private NGELDFKPLFG <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private KIDKIHLFPDC <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private KIDKIHLFPDC <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private TaskAwaiter<AFJNCMKOAEB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private TaskAwaiter<BDAHONEPHPJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private TaskAwaiter<LHGODKBPKKI> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x707AFB0", Offset = "0x7079FB0", VA = "0x18707AFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x707C0E0", Offset = "0x707B0E0", VA = "0x18707C0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	private ICFBHJEIGMP LCGMLIBOFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	private IOEEDLJNEAH CNHDNJOLLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	private HNEMDIOKFMA HBJOHCJFHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	private KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private long MFLLPFDNGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private long EHHCEAFAAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private long FCIOGEHFGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private string GJLGNAADPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private KIDKIHLFPDC HIBPGPGIODB;

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x706A930", Offset = "0x7069930", VA = "0x18706A930")]
	public static Task<GFPOIMFJFNK> HKKEBMAHFIA(FPLMJHIKMFP ICDIIGEJPGM, BJEHJDLGDFO HHNBCLDGHCL, KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x706ABB0", Offset = "0x7069BB0", VA = "0x18706ABB0")]
	[AsyncStateMachine(typeof(BAFJJOFIBNN))]
	private Task<GFPOIMFJFNK> PCBFBKDIPKL(CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x706A600", Offset = "0x7069600", VA = "0x18706A600")]
	[AsyncStateMachine(typeof(OOCKBDPHBLH))]
	private Task<GFPOIMFJFNK> ADAECPLGGFH(KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x706A760", Offset = "0x7069760", VA = "0x18706A760")]
	[AsyncStateMachine(typeof(PMKKPFACMAG))]
	private static Task<GFPOIMFJFNK> ADAECPLGGFH(ICFBHJEIGMP LCGMLIBOFMO, HNEMDIOKFMA HBJOHCJFHNC, long MFLLPFDNGGL, long EHHCEAFAAIL, long FCIOGEHFGHC, string GJLGNAADPEF, KIDKIHLFPDC HIBPGPGIODB, CancellationToken LABHBAHABKB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x706A900", Offset = "0x7069900", VA = "0x18706A900")]
	private void FAIOGHEKMNM(AFJNCMKOAEB DGCGCONGDDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct AECKBKHKDHL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct ACMIFBBBFCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public AECKBKHKDHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x7063890", Offset = "0x7062890", VA = "0x187063890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x7063E20", Offset = "0x7062E20", VA = "0x187063E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	private ICFBHJEIGMP LCGMLIBOFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	private PEJDOCBEAIB AHGAPHMJDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private float AGPKJEFNEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private float BDLEIKDKNDN;

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x7064070", Offset = "0x7063070", VA = "0x187064070")]
	public static Task NAPFIIDFBBO(FPLMJHIKMFP ICDIIGEJPGM, PEJDOCBEAIB AHGAPHMJDIB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x7064410", Offset = "0x7063410", VA = "0x187064410")]
	[AsyncStateMachine(typeof(ACMIFBBBFCO))]
	public Task PCBFBKDIPKL(CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x7064210", Offset = "0x7063210", VA = "0x187064210")]
	private static void NHBJBJBKANI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x7063F10", Offset = "0x7062F10", VA = "0x187063F10")]
	private void IEFOLMHOHLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x7064350", Offset = "0x7063350", VA = "0x187064350")]
	private static float NLDLEAPNOLK(ICFBHJEIGMP LCGMLIBOFMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x7063EF0", Offset = "0x7062EF0", VA = "0x187063EF0")]
	private static float AJJCKHMNNLM()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal struct ENJFILOMMPL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct BOAEOEEMGFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public CHMMBEKDPCD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private DPOAJAMLBLE <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private FPLMJHIKMFP <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private MHCIFAMFBDK.NOHFGOLNPOP <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private TaskAwaiter<DKMNKHDNIBD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x7067AF0", Offset = "0x7066AF0", VA = "0x187067AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x7068310", Offset = "0x7067310", VA = "0x187068310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct AHENHHGJGOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x7064530", Offset = "0x7063530", VA = "0x187064530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x7064820", Offset = "0x7063820", VA = "0x187064820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x706BB50", Offset = "0x706AB50", VA = "0x18706BB50")]
	[AsyncStateMachine(typeof(BOAEOEEMGFA))]
	public static Task PCBFBKDIPKL(CHMMBEKDPCD DIKAKALEHHB, PEJDOCBEAIB AHGAPHMJDIB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x706BAE0", Offset = "0x706AAE0", VA = "0x18706BAE0")]
	private static Task<DKMNKHDNIBD> LCLNPHPIFHG(CHMMBEKDPCD DIKAKALEHHB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x706BA20", Offset = "0x706AA20", VA = "0x18706BA20")]
	[AsyncStateMachine(typeof(AHENHHGJGOB))]
	private static Task JKPILKKLKOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct KNMCCCCNOMG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct OBDKBJBDNFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public KNMCCCCNOMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x7077C80", Offset = "0x7076C80", VA = "0x187077C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x7078330", Offset = "0x7077330", VA = "0x187078330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class KOMOAIOPJAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public KOMOAIOPJAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x7074070", Offset = "0x7073070", VA = "0x187074070")]
		internal object BEBDDNPLEIF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct LIMMEIHCDKI : IAsyncStateMachine
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
		public KNMCCCCNOMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x7074F00", Offset = "0x7073F00", VA = "0x187074F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x7075360", Offset = "0x7074360", VA = "0x187075360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AC")]
	private bool GGFKEENDHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private FPLMJHIKMFP ICDIIGEJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AF")]
	private CancellationToken LABHBAHABKB;

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x7073F10", Offset = "0x7072F10", VA = "0x187073F10")]
	public static Task PABACFGIBJI(FPLMJHIKMFP ICDIIGEJPGM, bool GGFKEENDHMC, KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, CancellationToken DIAJBCBNAGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x7073F80", Offset = "0x7072F80", VA = "0x187073F80")]
	[AsyncStateMachine(typeof(OBDKBJBDNFC))]
	private Task PCBFBKDIPKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x7073DE0", Offset = "0x7072DE0", VA = "0x187073DE0")]
	[AsyncStateMachine(typeof(LIMMEIHCDKI))]
	private Task FLOOPDKNJGP(bool FMIADNGFDCN, string FEBNLODCIFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950")]
	private bool BNFGLMNILIA(bool GGFKEENDHMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct BMPHFGAEKKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct CCLEPCGIFNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public BMPHFGAEKKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x7068A30", Offset = "0x7067A30", VA = "0x187068A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x7068FA0", Offset = "0x7067FA0", VA = "0x187068FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private sealed class JEBCAPEBJII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public JEBCAPEBJII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x70719F0", Offset = "0x70709F0", VA = "0x1870719F0")]
		internal object BEBDDNPLEIF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct CNJAKHCHCDM : IAsyncStateMachine
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
		public BMPHFGAEKKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x7069E00", Offset = "0x7068E00", VA = "0x187069E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x706A290", Offset = "0x7069290", VA = "0x18706A290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private EONIMKIFDHN HOFNNINNPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private FPLMJHIKMFP ICDIIGEJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private bool HMBFCKCBMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private PEJDOCBEAIB AHGAPHMJDIB;

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x7067950", Offset = "0x7066950", VA = "0x187067950")]
	public static Task<Scene> LKPOOFALIBL(FPLMJHIKMFP ICDIIGEJPGM, EONIMKIFDHN MEDELCCMMIP, KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x70679D0", Offset = "0x70669D0", VA = "0x1870679D0")]
	[AsyncStateMachine(typeof(CCLEPCGIFNM))]
	private Task<Scene> PCBFBKDIPKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x7067760", Offset = "0x7066760", VA = "0x187067760")]
	private bool ACPNLENFGMD(PEJDOCBEAIB AHGAPHMJDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x70678E0", Offset = "0x70668E0", VA = "0x1870678E0")]
	private void JJCBMAANJBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x7067790", Offset = "0x7066790", VA = "0x187067790")]
	[AsyncStateMachine(typeof(CNJAKHCHCDM))]
	private Task<Scene> FLOOPDKNJGP(string FEBNLODCIFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct ILEDMAAEHFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct MIAEEOKFMOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public AsyncTaskMethodBuilder<DFIBCMGCDHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public ILEDMAAEHFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public DFIBCMGCDHD nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public PEJDOCBEAIB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private TaskAwaiter<DFIBCMGCDHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x7076330", Offset = "0x7075330", VA = "0x187076330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x7076E10", Offset = "0x7075E10", VA = "0x187076E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct AJJMHPHEKHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public AsyncTaskMethodBuilder<DFIBCMGCDHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public ILEDMAAEHFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public DFIBCMGCDHD state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private TaskAwaiter<DKMNKHDNIBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x7064B40", Offset = "0x7063B40", VA = "0x187064B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x7064E20", Offset = "0x7063E20", VA = "0x187064E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private readonly CHMMBEKDPCD DIKAKALEHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private readonly IOEEDLJNEAH CNHDNJOLLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private readonly ANLKNCKJJKC KJGMDNHKDOE;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private DPOAJAMLBLE HLLOKKDEOMM
	{
		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x579A9A0", Offset = "0x57999A0", VA = "0x18579A9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x7071290", Offset = "0x7070290", VA = "0x187071290")]
	public ILEDMAAEHFG(CHMMBEKDPCD DIKAKALEHHB, IOEEDLJNEAH CNHDNJOLLOA, ANLKNCKJJKC KJGMDNHKDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x7070F60", Offset = "0x706FF60", VA = "0x187070F60")]
	[AsyncStateMachine(typeof(MIAEEOKFMOH))]
	public Task<DFIBCMGCDHD> AMNDFIOMKCE(DFIBCMGCDHD KCLPBNJGOEM, PEJDOCBEAIB HIEPBFNGDPK, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB, bool HKMLNAACEBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x7071130", Offset = "0x7070130", VA = "0x187071130")]
	[AsyncStateMachine(typeof(AJJMHPHEKHB))]
	private Task<DFIBCMGCDHD> HEEOBJCJEOK(KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, DFIBCMGCDHD JKKAFCBPEPF, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x70710E0", Offset = "0x70700E0", VA = "0x1870710E0")]
	private bool ECLGGGMHAFA(DFIBCMGCDHD OEPOHOMIGOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x7071110", Offset = "0x7070110", VA = "0x187071110")]
	private void ELCBEGJPMKG(string HHIJHJEKJHK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct FOGNAIKPFFH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct JBODMJPCLEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public DPOAJAMLBLE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public OEADBKPHHAK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private KNFEKPELEMG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private List<(PersistenceView, ENFIPLJHHAN)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private (PersistenceView, ENFIPLJHHAN) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x70712F0", Offset = "0x70702F0", VA = "0x1870712F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x7071900", Offset = "0x7070900", VA = "0x187071900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x706DA50", Offset = "0x706CA50", VA = "0x18706DA50")]
	[AsyncStateMachine(typeof(JBODMJPCLEO))]
	public static Task PCBFBKDIPKL(DPOAJAMLBLE IEHHLNFCIFN, PEJDOCBEAIB AHGAPHMJDIB, OEADBKPHHAK LOPOCHJNEPN, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal struct FKCLAJPELKD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct KELBNFLFNHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public DPOAJAMLBLE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public OEADBKPHHAK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private EBLAFNHPHNO <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private KNFEKPELEMG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private List<(PersistenceView, ENFIPLJHHAN)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private ENFIPLJHHAN <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7073530", Offset = "0x7072530", VA = "0x187073530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x7073D80", Offset = "0x7072D80", VA = "0x187073D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x706D090", Offset = "0x706C090", VA = "0x18706D090")]
	[AsyncStateMachine(typeof(KELBNFLFNHN))]
	public static Task PCBFBKDIPKL(DPOAJAMLBLE IEHHLNFCIFN, PEJDOCBEAIB AHGAPHMJDIB, OEADBKPHHAK LOPOCHJNEPN, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal struct MHCIFAMFBDK
{
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	public struct NOHFGOLNPOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public List<BDEMGCIABCE> LOBBHNAAHNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public List<ENFIPLJHHAN> JOIHPDMGEJD;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xB852B0", Offset = "0xB842B0", VA = "0x180B852B0")]
		public NOHFGOLNPOP(List<BDEMGCIABCE> LOBBHNAAHNK, List<ENFIPLJHHAN> JOIHPDMGEJD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class JECOJDKJGPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public IEnumerable<BDEMGCIABCE> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public JECOJDKJGPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x7071A40", Offset = "0x7070A40", VA = "0x187071A40")]
		internal object ADADAJGHMFB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005FF")]
	private FPLMJHIKMFP ICDIIGEJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000600")]
	private PEJDOCBEAIB AHGAPHMJDIB;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private ICFBHJEIGMP POFCPOIIAOI
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7075550", Offset = "0x7074550", VA = "0x187075550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x7075B50", Offset = "0x7074B50", VA = "0x187075B50")]
	public static NOHFGOLNPOP PCBFBKDIPKL(FPLMJHIKMFP ICDIIGEJPGM, PEJDOCBEAIB AHGAPHMJDIB)
	{
		return default(NOHFGOLNPOP);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x7075BB0", Offset = "0x7074BB0", VA = "0x187075BB0")]
	private NOHFGOLNPOP PCBFBKDIPKL()
	{
		return default(NOHFGOLNPOP);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x70755A0", Offset = "0x70745A0", VA = "0x1870755A0")]
	private NOHFGOLNPOP HCHLIOLNMBG(KECMDPPEFHG EMKHAEJLEFJ, EBLAFNHPHNO PIBHEOOEKKE)
	{
		return default(NOHFGOLNPOP);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x7075E10", Offset = "0x7074E10", VA = "0x187075E10")]
	private bool PDFNEGNONCM(IEnumerable<BDEMGCIABCE> LOBBHNAAHNK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct PANNOEMJLEO
{
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private sealed class LHBCMPBIMCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public MHCIFAMFBDK.NOHFGOLNPOP instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public LHBCMPBIMCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x70747D0", Offset = "0x70737D0", VA = "0x1870747D0")]
		internal object EKLLFNHIHHJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class JCJICBKNFDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public JCJICBKNFDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x7071960", Offset = "0x7070960", VA = "0x187071960")]
		internal object HGANEPJBJBP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x707AA00", Offset = "0x7079A00", VA = "0x18707AA00")]
	public static void PCBFBKDIPKL(DPOAJAMLBLE IEHHLNFCIFN, PEJDOCBEAIB AHGAPHMJDIB, MHCIFAMFBDK.NOHFGOLNPOP NADDJOJHJNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal class ANLKNCKJJKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct IKIODFDNDBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public ANLKNCKJJKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public DFIBCMGCDHD operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public PEJDOCBEAIB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x70704C0", Offset = "0x706F4C0", VA = "0x1870704C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x7070C30", Offset = "0x706FC30", VA = "0x187070C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class AHPNFLDJLMK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016D")]
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
			public AHPNFLDJLMK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x707C350", Offset = "0x707B350", VA = "0x18707C350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x707C610", Offset = "0x707B610", VA = "0x18707C610", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public ANLKNCKJJKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public AHPNFLDJLMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x7064A50", Offset = "0x7063A50", VA = "0x187064A50")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task LOILKBHKMBJ(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct AOPPMFAKCKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public ANLKNCKJJKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private AHPNFLDJLMK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x7065DF0", Offset = "0x7064DF0", VA = "0x187065DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x7066320", Offset = "0x7065320", VA = "0x187066320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct EGAADPHJACK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public ANLKNCKJJKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private Dictionary<Guid, List<BDMLKBHGMHN>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x706AD50", Offset = "0x7069D50", VA = "0x18706AD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x706B300", Offset = "0x706A300", VA = "0x18706B300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct LAIICLEMKOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public ANLKNCKJJKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private Dictionary<Guid, List<BDMLKBHGMHN>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x70740F0", Offset = "0x70730F0", VA = "0x1870740F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x7074770", Offset = "0x7073770", VA = "0x187074770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class ILBCMEBAGJL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000172")]
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
			public BDMLKBHGMHN handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			public ILBCMEBAGJL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x707C150", Offset = "0x707B150", VA = "0x18707C150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0x707C2F0", Offset = "0x707B2F0", VA = "0x18707C2F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public FONENGJIKDJ runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public List<BDMLKBHGMHN> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public ILBCMEBAGJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x7070D80", Offset = "0x706FD80", VA = "0x187070D80")]
		internal object NBAJJKPNOMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x7070C90", Offset = "0x706FC90", VA = "0x187070C90")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task CHDANFNEIJG(BDMLKBHGMHN handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x7070E70", Offset = "0x706FE70", VA = "0x187070E70")]
		internal object PEGIBDCIACL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private struct FKKLIKONHPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public FONENGJIKDJ runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public List<BDMLKBHGMHN> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private ILBCMEBAGJL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x706D1D0", Offset = "0x706C1D0", VA = "0x18706D1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x706D6A0", Offset = "0x706C6A0", VA = "0x18706D6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct NIJIKDDMHBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public ANLKNCKJJKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x70773A0", Offset = "0x70763A0", VA = "0x1870773A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x7077960", Offset = "0x7076960", VA = "0x187077960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class AEBEAMDBMAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public AEBEAMDBMAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x7063E80", Offset = "0x7062E80", VA = "0x187063E80")]
		internal object KJMFILDAKHH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct IDGODAGHOHH : IAsyncStateMachine
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
		public ANLKNCKJJKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public PEJDOCBEAIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x706FDB0", Offset = "0x706EDB0", VA = "0x18706FDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x7070270", Offset = "0x706F270", VA = "0x187070270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class OIIGDKPHGKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public OIIGDKPHGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x7078390", Offset = "0x7077390", VA = "0x187078390")]
		internal object EONGOHFIMHI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct EPGCPLMAEJA : IAsyncStateMachine
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
		public ANLKNCKJJKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private TaskAwaiter<DKMNKHDNIBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x706C120", Offset = "0x706B120", VA = "0x18706C120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x706C760", Offset = "0x706B760", VA = "0x18706C760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class ONPNNKHOAHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public ONPNNKHOAHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x7079560", Offset = "0x7078560", VA = "0x187079560")]
		internal object FIBJBEBOFEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private readonly CHMMBEKDPCD DIKAKALEHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private MPPNEAHKNLC KJGMDNHKDOE;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private DPOAJAMLBLE HLLOKKDEOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x9A01E0", Offset = "0x99F1E0", VA = "0x1809A01E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	public ANLKNCKJJKC(CHMMBEKDPCD DIKAKALEHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x7065B50", Offset = "0x7064B50", VA = "0x187065B50")]
	[AsyncStateMachine(typeof(IKIODFDNDBA))]
	public Task PCBFBKDIPKL(DFIBCMGCDHD DABMNPGCDJD, PEJDOCBEAIB HIEPBFNGDPK, KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x7065A10", Offset = "0x7064A10", VA = "0x187065A10")]
	[AsyncStateMachine(typeof(AOPPMFAKCKJ))]
	private Task MMHHKCNCCLH(PEJDOCBEAIB AHGAPHMJDIB, KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x70658D0", Offset = "0x70648D0", VA = "0x1870658D0")]
	[AsyncStateMachine(typeof(EGAADPHJACK))]
	private Task HKEJDMOKKGC(PEJDOCBEAIB AHGAPHMJDIB, KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x7065790", Offset = "0x7064790", VA = "0x187065790")]
	[AsyncStateMachine(typeof(LAIICLEMKOC))]
	private Task FNDPAHPKHAI(PEJDOCBEAIB AHGAPHMJDIB, KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x7065CA0", Offset = "0x7064CA0", VA = "0x187065CA0")]
	[AsyncStateMachine(typeof(FKKLIKONHPH))]
	private Task PDNCKOIKOHK(Guid CCCKALJCMEJ, List<BDMLKBHGMHN> CDLPHJELOHB, FONENGJIKDJ KPKGBPJFEFG, PEJDOCBEAIB AHGAPHMJDIB, CancellationToken DJIBMMAIGPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x70652D0", Offset = "0x70642D0", VA = "0x1870652D0")]
	[AsyncStateMachine(typeof(NIJIKDDMHBD))]
	private Task DHMAJDNMJOD(PEJDOCBEAIB AHGAPHMJDIB, KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x7065650", Offset = "0x7064650", VA = "0x187065650")]
	[AsyncStateMachine(typeof(IDGODAGHOHH))]
	private Task EGPLPJMFCKH(Guid PNPGEOHAPFB, PEJDOCBEAIB AHGAPHMJDIB, KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x7064FB0", Offset = "0x7063FB0", VA = "0x187064FB0")]
	[AsyncStateMachine(typeof(EPGCPLMAEJA))]
	private Task AIBBFAHKCOM(Guid PNPGEOHAPFB, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x7064E90", Offset = "0x7063E90", VA = "0x187064E90")]
	private void ADFDMOKDMDJ(Guid PNPGEOHAPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x70655A0", Offset = "0x70645A0", VA = "0x1870655A0")]
	private void DOBNCONLGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x7065410", Offset = "0x7064410", VA = "0x187065410")]
	public Guid DLBLGKEBHKK(DFIBCMGCDHD DCNHNFDAJKN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x70650F0", Offset = "0x70640F0", VA = "0x1870650F0")]
	[CompilerGenerated]
	private object AIGPDEOPPIO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal struct JGEBILGKBNG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct GHMDKKCMHFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public JGEBILGKBNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private IEnumerator<OMBDFJMOFCJ> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x706E960", Offset = "0x706D960", VA = "0x18706E960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x706F040", Offset = "0x706E040", VA = "0x18706F040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private ICFBHJEIGMP LCGMLIBOFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private CancellationToken LABHBAHABKB;

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x7071AC0", Offset = "0x7070AC0", VA = "0x187071AC0")]
	public static Task GBFCHCNEIDA(ICFBHJEIGMP LCGMLIBOFMO, KLCBNGOGDPF<string>.BPJNBAPCFPO COCKABGNCJJ, CancellationToken DIAJBCBNAGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x7071B30", Offset = "0x7070B30", VA = "0x187071B30")]
	[AsyncStateMachine(typeof(GHMDKKCMHFC))]
	private Task PCBFBKDIPKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
public readonly struct PEDLLJADMJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	public readonly bool JNFJEGIENEB;

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x21BB7E0", Offset = "0x21BA7E0", VA = "0x1821BB7E0")]
	public PEDLLJADMJP(bool IDKOAGHICDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public readonly struct EGHPBEBBELB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	public readonly KECMDPPEFHG? NJCOMKGHFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	public readonly ODEJHGLDADF NGGNENEDOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	public readonly string? MALHCOEHMEF;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public IReadOnlyCollection<string> GMKDJINHJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x706B360", Offset = "0x706A360", VA = "0x18706B360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public IReadOnlyDictionary<long, int> MEACIEACGIF
	{
		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x706B380", Offset = "0x706A380", VA = "0x18706B380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x706B3A0", Offset = "0x706A3A0", VA = "0x18706B3A0")]
	public EGHPBEBBELB(KECMDPPEFHG? KBAPBJOHBKA, ODEJHGLDADF IHFJMFJBKHJ, string? HIFKBGMPOPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal class OJAJEOGNIKA : OOFNBODDNMA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct GDFCODNACGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public AsyncTaskMethodBuilder<EGHPBEBBELB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public OJAJEOGNIKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public JEBPGEFJPEO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public HAGLFGFJMBC roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private KNFEKPELEMG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x706E280", Offset = "0x706D280", VA = "0x18706E280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x706E8F0", Offset = "0x706D8F0", VA = "0x18706E8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class DALLFDCLHCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public JEBPGEFJPEO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public OJAJEOGNIKA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public DALLFDCLHCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x706A300", Offset = "0x7069300", VA = "0x18706A300")]
		internal Task GJMOFDHMDGD(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x706A520", Offset = "0x7069520", VA = "0x18706A520")]
		internal Task JEHKEHOHEHG(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class MJJDMHJIMKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public DALLFDCLHCN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public MJJDMHJIMKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x7076E80", Offset = "0x7075E80", VA = "0x187076E80")]
		internal object COKCEAOLCBP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class HPEEFGIPINK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public DALLFDCLHCN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public HPEEFGIPINK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x706FD70", Offset = "0x706ED70", VA = "0x18706FD70")]
		internal Task NIMBEPDHDOD(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct FAIMIDKFMDH : IAsyncStateMachine
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
		public JEBPGEFJPEO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public OJAJEOGNIKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private MJJDMHJIMKL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private KNFEKPELEMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x706C7C0", Offset = "0x706B7C0", VA = "0x18706C7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x706D030", Offset = "0x706C030", VA = "0x18706D030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private static readonly TimeSpan ECNICNNKDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private readonly HEJLDJLPDCJ GFHFOJLJPOO;

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x7079510", Offset = "0x7078510", VA = "0x187079510")]
	public OJAJEOGNIKA(CHMMBEKDPCD DIKAKALEHHB, HEJLDJLPDCJ GFHFOJLJPOO, PHLKHBEJKKB IGEICKLFDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x7079200", Offset = "0x7078200", VA = "0x187079200")]
	[AsyncStateMachine(typeof(GDFCODNACGM))]
	public Task<EGHPBEBBELB> JMNIMAIKKED(long EHHCEAFAAIL, HAGLFGFJMBC GCKKMHMOMMM, JEBPGEFJPEO GJCAFENEDIP, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x7079360", Offset = "0x7078360", VA = "0x187079360")]
	[AsyncStateMachine(typeof(FAIMIDKFMDH))]
	private Task PNNJJIENKFD(JEBPGEFJPEO GJCAFENEDIP, IEnumerable<PersistenceView> KCJODJEGCGJ, StringBuilder NMKFFAFDCHI, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x7078AF0", Offset = "0x7077AF0", VA = "0x187078AF0")]
	private EGHPBEBBELB DEOHOLJGKPF(long EHHCEAFAAIL, HAGLFGFJMBC GCKKMHMOMMM, JEBPGEFJPEO GJCAFENEDIP, IEnumerable<PersistenceView> KCJODJEGCGJ, StringBuilder NMKFFAFDCHI)
	{
		return default(EGHPBEBBELB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x70790A0", Offset = "0x70780A0", VA = "0x1870790A0")]
	private KECMDPPEFHG IOOLLOPOJAB(long EHHCEAFAAIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x70788A0", Offset = "0x70778A0", VA = "0x1870788A0")]
	private void CMLGBNKOJDD(KECMDPPEFHG NKCIFMIJNOK, StringBuilder NMKFFAFDCHI, IEnumerable<PersistenceView> KCJODJEGCGJ, [In] BLDLANPDJEK GEDBNCKLEDD, NLAJGCBNEID MDLMCGPDINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x7078400", Offset = "0x7077400", VA = "0x187078400")]
	private void AAKNNHJBNDA(KECMDPPEFHG NKCIFMIJNOK, StringBuilder NMKFFAFDCHI, PersistenceView KHKFEBPAGAG, NLAJGCBNEID MDLMCGPDINM, [In] BLDLANPDJEK GEDBNCKLEDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal class CEAAOANADDL : OOFNBODDNMA
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class EFJNDGJBICO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public MHLILHNPMJB.DMENNCJDPGH roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public EFJNDGJBICO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x706AD00", Offset = "0x7069D00", VA = "0x18706AD00")]
		internal object CGBBIEOALOO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private struct GKDEOHADJDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public AsyncTaskMethodBuilder<(MHLILHNPMJB.DMENNCJDPGH roomDataUpload, MHLILHNPMJB.DMENNCJDPGH subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public EGHPBEBBELB roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public CEAAOANADDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private EFJNDGJBICO <>8__1;

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
		private TaskAwaiter<MHLILHNPMJB.DMENNCJDPGH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x706F0A0", Offset = "0x706E0A0", VA = "0x18706F0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x706F8F0", Offset = "0x706E8F0", VA = "0x18706F8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct CIFAMKIALEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public AsyncTaskMethodBuilder<ODCIKMCBEPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public CEAAOANADDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public EGHPBEBBELB roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public CIIAAADNGNH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private TaskAwaiter<(MHLILHNPMJB.DMENNCJDPGH roomDataUpload, MHLILHNPMJB.DMENNCJDPGH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private TaskAwaiter<ODCIKMCBEPK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x7069700", Offset = "0x7068700", VA = "0x187069700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x7069D90", Offset = "0x7068D90", VA = "0x187069D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct GBMAJLBDIBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public AsyncTaskMethodBuilder<BDAHONEPHPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public CEAAOANADDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public EGHPBEBBELB roomSerializedData;

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
		private TaskAwaiter<(MHLILHNPMJB.DMENNCJDPGH roomDataUpload, MHLILHNPMJB.DMENNCJDPGH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private TaskAwaiter<BDAHONEPHPJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x706DE00", Offset = "0x706CE00", VA = "0x18706DE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x706E210", Offset = "0x706D210", VA = "0x18706E210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class NBJIKHJDLAM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C1")]
			public AsyncTaskMethodBuilder<DKMNKHDNIBD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C2")]
			public NBJIKHJDLAM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C3")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C4")]
			private DKMNKHDNIBD <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			private TaskAwaiter<BDAHONEPHPJ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			private TaskAwaiter<ODCIKMCBEPK> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			private TaskAwaiter<DKMNKHDNIBD> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x707CA60", Offset = "0x707BA60", VA = "0x18707CA60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x707D9E0", Offset = "0x707C9E0", VA = "0x18707D9E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public CEAAOANADDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public EGHPBEBBELB roomSerializedData;

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
		public CIIAAADNGNH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public PEDLLJADMJP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public NBJIKHJDLAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x7077270", Offset = "0x7076270", VA = "0x187077270")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<DKMNKHDNIBD> GMINLNGPGNN(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private struct MLPKFLAHDPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public AsyncTaskMethodBuilder<DKMNKHDNIBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public CEAAOANADDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public EGHPBEBBELB roomSerializedData;

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
		public CIIAAADNGNH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public PEDLLJADMJP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private TaskAwaiter<DKMNKHDNIBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x7076EF0", Offset = "0x7075EF0", VA = "0x187076EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x7077200", Offset = "0x7076200", VA = "0x187077200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private static readonly PHLKHBEJKKB COAFAKPLIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private readonly DJCOHDGDBBC EIHELPAEMNH;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private FPLMJHIKMFP BJDOHINMMLF
	{
		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x704CB90", Offset = "0x704BB90", VA = "0x18704CB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x7069670", Offset = "0x7068670", VA = "0x187069670")]
	public CEAAOANADDL(CHMMBEKDPCD DIKAKALEHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x7069490", Offset = "0x7068490", VA = "0x187069490")]
	[AsyncStateMachine(typeof(GKDEOHADJDC))]
	private Task<(MHLILHNPMJB.DMENNCJDPGH, MHLILHNPMJB.DMENNCJDPGH)> KELMIILMFPC(EGHPBEBBELB AHNMDIOCJEH, long MFLLPFDNGGL, long KNEHMNKKPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x7069320", Offset = "0x7068320", VA = "0x187069320")]
	[AsyncStateMachine(typeof(CIFAMKIALEO))]
	public Task<ODCIKMCBEPK> IONIFHFKAEC(int BENCOAFHAIE, [CanBeNull] CIIAAADNGNH PFJJPJNHLEK, EGHPBEBBELB AHNMDIOCJEH, long MFLLPFDNGGL, long KNEHMNKKPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x7069010", Offset = "0x7068010", VA = "0x187069010")]
	[AsyncStateMachine(typeof(GBMAJLBDIBG))]
	private Task<BDAHONEPHPJ> FPGALLEMCLP(string GJLGNAADPEF, int BENCOAFHAIE, EGHPBEBBELB AHNMDIOCJEH, long MFLLPFDNGGL, long KNEHMNKKPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x7069180", Offset = "0x7068180", VA = "0x187069180")]
	[AsyncStateMachine(typeof(MLPKFLAHDPH))]
	public Task<DKMNKHDNIBD> GNHGJAOINCA(int BENCOAFHAIE, CIIAAADNGNH? PFJJPJNHLEK, EGHPBEBBELB AHNMDIOCJEH, long MFLLPFDNGGL, long KNEHMNKKPOH, PEDLLJADMJP OFKKHDCPFPM, KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public abstract class AIJLCGBAKJH<T> where T : AIJLCGBAKJH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	internal readonly FPLMJHIKMFP GNEJFMALKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private int? MIMMEPLPBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	protected readonly Guid NOFPFFHHHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	protected readonly LDJAJOAAKGC ICDNIJHFLEA;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	protected T DOHBPDEJJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D320", Offset = "0x3D1C320", VA = "0x183D1D320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x3D1D6C0", Offset = "0x3D1C6C0", VA = "0x183D1D6C0")]
	internal AIJLCGBAKJH(FPLMJHIKMFP IMEEAPCMILI, LDJAJOAAKGC DOIIBAIKNLJ, [Optional] Guid? PHAMLENOBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x3D1D4B0", Offset = "0x3D1C4B0", VA = "0x183D1D4B0")]
	private DKMNKHDNIBD NKPLHKMJKNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "4")]
	protected virtual void FPLAIFPNJEL(DKMNKHDNIBD KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x3D1D420", Offset = "0x3D1C420", VA = "0x183D1D420")]
	public T NGJJGAGHBMD(EEPDJJKFILM ABGNPDBOJGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x3D1D380", Offset = "0x3D1C380", VA = "0x183D1D380")]
	public T LDMDAKIDGBB(int AHAKPDNLKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x3D1D590", Offset = "0x3D1C590", VA = "0x183D1D590", Slot = "5")]
	public virtual Task<CDPIDOPDCID> OLBJAJLMBNG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public class NKLCFNADKBK : AIJLCGBAKJH<NKLCFNADKBK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private BJEHJDLGDFO KLINFCCHIED;

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x7077A90", Offset = "0x7076A90", VA = "0x187077A90")]
	internal NKLCFNADKBK(FPLMJHIKMFP IMEEAPCMILI, LDJAJOAAKGC DOIIBAIKNLJ, [Optional] Guid? PHAMLENOBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x6594B70", Offset = "0x6593B70", VA = "0x186594B70")]
	public NKLCFNADKBK EGGLIJHHGHH(BJEHJDLGDFO KLINFCCHIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x70779C0", Offset = "0x70769C0", VA = "0x1870779C0", Slot = "4")]
	protected override void FPLAIFPNJEL(DKMNKHDNIBD KKHEHGHPOAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class ENMKHCFJBGI : AIJLCGBAKJH<ENMKHCFJBGI>
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	internal enum OICFCEFGEKD
	{
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct HBHGNIJIPIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public AsyncTaskMethodBuilder<CDPIDOPDCID> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public ENMKHCFJBGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private TaskAwaiter<CDPIDOPDCID> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x706F960", Offset = "0x706E960", VA = "0x18706F960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x706FD00", Offset = "0x706ED00", VA = "0x18706FD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private OICFCEFGEKD MDEAJMGCAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private string GKBFDPMKFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private CIIAAADNGNH KLINFCCHIED;

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x706BFB0", Offset = "0x706AFB0", VA = "0x18706BFB0")]
	internal ENMKHCFJBGI(FPLMJHIKMFP IMEEAPCMILI, LDJAJOAAKGC DOIIBAIKNLJ, [Optional] Guid? PHAMLENOBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x706BC90", Offset = "0x706AC90", VA = "0x18706BC90")]
	public ENMKHCFJBGI ANNNBIKKGEM(string EHMGHMNDKCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x706BE70", Offset = "0x706AE70", VA = "0x18706BE70")]
	public ENMKHCFJBGI KCJMGNNBHOJ(bool DCBJBNFNNGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x706BE90", Offset = "0x706AE90", VA = "0x18706BE90")]
	public ENMKHCFJBGI OJMKCKBCDIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x706BD00", Offset = "0x706AD00", VA = "0x18706BD00", Slot = "4")]
	protected override void FPLAIFPNJEL(DKMNKHDNIBD KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x706BEC0", Offset = "0x706AEC0", VA = "0x18706BEC0", Slot = "5")]
	[AsyncStateMachine(typeof(HBHGNIJIPIB))]
	public override Task<CDPIDOPDCID> OLBJAJLMBNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x706BCC0", Offset = "0x706ACC0", VA = "0x18706BCC0")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<CDPIDOPDCID> CICAIPLALHH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
internal static class AHFJDGFIIHF
{
	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x7064900", Offset = "0x7063900", VA = "0x187064900")]
	public static void GGJILLKPPPF(this CDHPIBIKHJE MHHHLJPCOBM, PJAFGDKDHNF JPEEABGAEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x7064880", Offset = "0x7063880", VA = "0x187064880")]
	public static void DIGGBPAECJB(this PJAFGDKDHNF AIPGHLJGNDC, [Optional] string KKHEHGHPOAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public static class BHECFOIAHDH
{
	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x7067610", Offset = "0x7066610", VA = "0x187067610")]
	public static KIDKIHLFPDC FIEMPKEGNEA(this NCOGEPGILOA CHDBKKIKAHJ)
	{
		return default(KIDKIHLFPDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x70676B0", Offset = "0x70666B0", VA = "0x1870676B0")]
	public static NCOGEPGILOA IGHKAAFNEPK(this KIDKIHLFPDC OGGPICACIOD)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000196")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006E9")]
			public AAILHDBANJG ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006EA")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006EB")]
			public AAILHDBANJG HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private static AAILHDBANJG[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private Dictionary<AAILHDBANJG, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x707E0C0", Offset = "0x707D0C0", VA = "0x18707E0C0")]
		public bool OMIBOIFDMFC(AAILHDBANJG NHNKOHGANKF, [Out] ResultConfig IOPKIGDDBDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x707DF80", Offset = "0x707CF80", VA = "0x18707DF80")]
		public ResultConfig BJHBPINAMIP(AAILHDBANJG JMFILHLKOGK, [Optional] HashSet<AAILHDBANJG> NLPCJMJNIKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x707E690", Offset = "0x707D690", VA = "0x18707E690", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x707E130", Offset = "0x707D130", VA = "0x18707E130", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x939730", Offset = "0x938730", VA = "0x180939730")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
public class JOMHENKGODO : OBLJMEGKEJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private struct KDGJNIJIHGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public JOMHENKGODO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x7080E20", Offset = "0x707FE20", VA = "0x187080E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x7080FB0", Offset = "0x707FFB0", VA = "0x187080FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct BBPNGAOMMCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public OBLJMEGKEJC preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x707ED60", Offset = "0x707DD60", VA = "0x18707ED60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x707F270", Offset = "0x707E270", VA = "0x18707F270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private readonly GMJFCCKMPIC KICNNGIKOHJ;

	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public string ECCLCFAPJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x7073160", Offset = "0x7072160", VA = "0x187073160", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x70732B0", Offset = "0x70722B0", VA = "0x1870732B0")]
	[ONAOIKEPAJE(NOFONODCPKJ.Root, IKAJKCKEGIH.GameOnly)]
	private static void IIPNNHOGOLM(NDJGECDCBMH GJMGLGAJGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	[RecRoom.NoEngine.Common.Preserve]
	public JOMHENKGODO([JONIFKKOOAA(null)] GMJFCCKMPIC KICNNGIKOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x70733B0", Offset = "0x70723B0", VA = "0x1870733B0", Slot = "5")]
	[AsyncStateMachine(typeof(KDGJNIJIHGP))]
	public Task PCBFBKDIPKL(KLCBNGOGDPF<string>.BPJNBAPCFPO DOLKNGHMGCO, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x7073190", Offset = "0x7072190", VA = "0x187073190")]
	[AsyncStateMachine(typeof(BBPNGAOMMCK))]
	private Task GJIPJEKNDEA(OBLJMEGKEJC CIEJPPJPNND, KLCBNGOGDPF<string>.BPJNBAPCFPO DOLKNGHMGCO, CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public interface GMJFCCKMPIC : OBLJMEGKEJC
{
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public interface OBLJMEGKEJC
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string ECCLCFAPJLB
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PCBFBKDIPKL(KLCBNGOGDPF<string>.BPJNBAPCFPO DOLKNGHMGCO, CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public static class CLODDCHHEIE
{
	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x707F3C0", Offset = "0x707E3C0", VA = "0x18707F3C0")]
	[ONAOIKEPAJE(IKAJKCKEGIH.GameOnly)]
	private static void ACLEMPFHCOI(NDJGECDCBMH GJMGLGAJGKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public interface JEIKNEHGIKE : IEquatable<JEIKNEHGIKE>
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	DateTime MCFELABNJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKLHKLNNHHJ();

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GKAIKKHEIJA(long MFLLPFDNGGL, long EHHCEAFAAIL, [Out] EGHPBEBBELB AHNMDIOCJEH);
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal class PLNMEIOBCBG : PJDGBOIGELF
{
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private sealed class CGEMAFCNEDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public EJEHHNILJEA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public CGEMAFCNEDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x707F350", Offset = "0x707E350", VA = "0x18707F350")]
		internal object BHENJFPAEGK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000703")]
	private readonly CDEKICLHOIM FPLJKEOLPCF;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<JEIKNEHGIKE> FDIADEBPAND
	{
		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x7083920", Offset = "0x7082920", VA = "0x187083920", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x7083BF0", Offset = "0x7082BF0", VA = "0x187083BF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	[UnityEngine.Scripting.Preserve]
	public PLNMEIOBCBG([JONIFKKOOAA(null)] CDEKICLHOIM FPLJKEOLPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x7083640", Offset = "0x7082640", VA = "0x187083640", Slot = "6")]
	public bool BBLADOEBDGA(long MFLLPFDNGGL, long EHHCEAFAAIL, EGHPBEBBELB AHNMDIOCJEH, EJEHHNILJEA KAACMIHMDEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x1D3EBB0", Offset = "0x1D3DBB0", VA = "0x181D3EBB0")]
	private void FPMPGABCMOI(JEIKNEHGIKE IFMNCMCIJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x70839D0", Offset = "0x70829D0", VA = "0x1870839D0", Slot = "7")]
	public bool JMHNNGLOFJK(long MFLLPFDNGGL, long EHHCEAFAAIL, [Out] JEIKNEHGIKE NMDGMOPBHKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x7083B40", Offset = "0x7082B40", VA = "0x187083B40", Slot = "8")]
	public bool LAOKHLOEDLB(long MFLLPFDNGGL, long EHHCEAFAAIL, EJEHHNILJEA KAACMIHMDEC, [Out] JEIKNEHGIKE NMDGMOPBHKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x7083DC0", Offset = "0x7082DC0", VA = "0x187083DC0")]
	private void PNHOHLCBNHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x7083CA0", Offset = "0x7082CA0", VA = "0x187083CA0", Slot = "9")]
	public void OGGEJFAHLHG(long MFLLPFDNGGL, long EHHCEAFAAIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal abstract class HENPLAMAOLJ : CDEKICLHOIM
{
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	protected enum POPNKLOMMCH : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private sealed class ABEGGACNGFD : IEnumerable<JEIKNEHGIKE>, IEnumerable, IEnumerator<JEIKNEHGIKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private JEIKNEHGIKE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public HENPLAMAOLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private EJEHHNILJEA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public EJEHHNILJEA <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		private JEIKNEHGIKE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x8A4A30", Offset = "0x8A3A30", VA = "0x1808A4A30")]
		[DebuggerHidden]
		public ABEGGACNGFD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x707EA30", Offset = "0x707DA30", VA = "0x18707EA30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x707ED10", Offset = "0x707DD10", VA = "0x18707ED10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x707EC60", Offset = "0x707DC60", VA = "0x18707EC60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JEIKNEHGIKE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x707EC60", Offset = "0x707DC60", VA = "0x18707EC60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class HEJKJEEFHOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public EJEHHNILJEA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public HEJKJEEFHOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x70802F0", Offset = "0x707F2F0", VA = "0x1870802F0")]
		internal object JPJMJKDNDGN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private sealed class BMHHELNFLFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public HENPLAMAOLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public BMHHELNFLFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x707F2D0", Offset = "0x707E2D0", VA = "0x18707F2D0")]
		internal void JEOAFHLDGLG(OMDNPJKGGMJ.LIGIEIEKJNK ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private readonly object FEPAAMHLPKC;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	protected string JMEFJFFPDBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x70809A0", Offset = "0x707F9A0", VA = "0x1870809A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public abstract JPGAEKEGOLI CGHPJKJHLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x7080DA0", Offset = "0x707FDA0", VA = "0x187080DA0")]
	protected HENPLAMAOLJ([CanBeNull] string FDALLOANLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x70807B0", Offset = "0x707F7B0", VA = "0x1870807B0", Slot = "5")]
	public bool EPFHMLCHMOI(long MFLLPFDNGGL, long EHHCEAFAAIL, EJEHHNILJEA KAACMIHMDEC, [Out] JEIKNEHGIKE IFMNCMCIJMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x7080390", Offset = "0x707F390", VA = "0x187080390", Slot = "6")]
	[IteratorStateMachine(typeof(ABEGGACNGFD))]
	public IEnumerable<JEIKNEHGIKE> BNFHFKNGADK(EJEHHNILJEA KAACMIHMDEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void EKFOAKKIIIB(Stream NAMKLFNCENB, long MFLLPFDNGGL, long EHHCEAFAAIL, EGHPBEBBELB AHNMDIOCJEH);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool BFGICCOOINI(Stream LAOALOPCNGO, long MFLLPFDNGGL, long EHHCEAFAAIL, DAJIOGMCCCK CGAPGEABPDC, [Out] EGHPBEBBELB AHNMDIOCJEH);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x7080A20", Offset = "0x707FA20", VA = "0x187080A20", Slot = "7")]
	public JEIKNEHGIKE JNNHABKGKGO(long MFLLPFDNGGL, long EHHCEAFAAIL, EGHPBEBBELB AHNMDIOCJEH, EJEHHNILJEA KAACMIHMDEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo BCPKKMPPLEN(long MFLLPFDNGGL, long EHHCEAFAAIL, EJEHHNILJEA KAACMIHMDEC, POPNKLOMMCH CIEMDMEDHME);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo IMACOPJBPCN(EJEHHNILJEA KAACMIHMDEC, POPNKLOMMCH CIEMDMEDHME);

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x70809B0", Offset = "0x707F9B0", VA = "0x1870809B0")]
	protected void IEOCNCOJLMC(OMDNPJKGGMJ.LIGIEIEKJNK HLGHPLIIOKM, string HHIJHJEKJHK, FileInfo JDCPEIIKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x7080420", Offset = "0x707F420", VA = "0x187080420")]
	internal bool CABBOOKKOBA(FileInfo IOIAJIBHODF, long MFLLPFDNGGL, long EHHCEAFAAIL, [Out] EGHPBEBBELB AHNMDIOCJEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	private void ACBHLFNLCCA(Exception KOABFHNGJCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
internal class EBONGLMMIGL : HENPLAMAOLJ
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public override JPGAEKEGOLI CGHPJKJHLNO
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xD1ABC0", Offset = "0xD19BC0", VA = "0x180D1ABC0", Slot = "8")]
		get
		{
			return default(JPGAEKEGOLI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x70802B0", Offset = "0x707F2B0", VA = "0x1870802B0")]
	public EBONGLMMIGL([Optional] string FDALLOANLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x7080230", Offset = "0x707F230", VA = "0x187080230")]
	private void NKPEAILAHBM(EJEHHNILJEA KAACMIHMDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x707FEA0", Offset = "0x707EEA0", VA = "0x18707FEA0", Slot = "9")]
	internal override void EKFOAKKIIIB(Stream NAMKLFNCENB, long MFLLPFDNGGL, long EHHCEAFAAIL, EGHPBEBBELB AHNMDIOCJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x707F8C0", Offset = "0x707E8C0", VA = "0x18707F8C0", Slot = "10")]
	internal override bool BFGICCOOINI(Stream LAOALOPCNGO, long MFLLPFDNGGL, long EHHCEAFAAIL, DAJIOGMCCCK CGAPGEABPDC, [Out] EGHPBEBBELB AHNMDIOCJEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x707F7D0", Offset = "0x707E7D0", VA = "0x18707F7D0", Slot = "11")]
	protected override FileInfo BCPKKMPPLEN(long MFLLPFDNGGL, long EHHCEAFAAIL, EJEHHNILJEA KAACMIHMDEC, POPNKLOMMCH CIEMDMEDHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x7080130", Offset = "0x707F130", VA = "0x187080130", Slot = "12")]
	protected override DirectoryInfo IMACOPJBPCN(EJEHHNILJEA KAACMIHMDEC, POPNKLOMMCH CIEMDMEDHME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal sealed class OLHEBMJJABE : HENPLAMAOLJ
{
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private static readonly byte[] GMFCIHEFPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private readonly byte[] GHCFCIDNKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400071B")]
	private readonly byte[] ALCHMBEJDFI;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public override JPGAEKEGOLI CGHPJKJHLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C350", Offset = "0x5E1B350", VA = "0x185E1C350", Slot = "8")]
		get
		{
			return default(JPGAEKEGOLI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x7082EE0", Offset = "0x7081EE0", VA = "0x187082EE0")]
	public OLHEBMJJABE([Optional] string FDALLOANLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x7082A80", Offset = "0x7081A80", VA = "0x187082A80", Slot = "9")]
	internal override void EKFOAKKIIIB(Stream NAMKLFNCENB, long MFLLPFDNGGL, long EHHCEAFAAIL, EGHPBEBBELB AHNMDIOCJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x70821F0", Offset = "0x70811F0", VA = "0x1870821F0", Slot = "10")]
	internal override bool BFGICCOOINI(Stream LAOALOPCNGO, long MFLLPFDNGGL, long EHHCEAFAAIL, DAJIOGMCCCK CGAPGEABPDC, [Out] EGHPBEBBELB AHNMDIOCJEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x70829C0", Offset = "0x70819C0", VA = "0x1870829C0")]
	private void EDIDMDJHIOF(byte[] KABOAHAAMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x70820C0", Offset = "0x70810C0", VA = "0x1870820C0", Slot = "11")]
	protected override FileInfo BCPKKMPPLEN(long MFLLPFDNGGL, long EHHCEAFAAIL, EJEHHNILJEA KAACMIHMDEC, POPNKLOMMCH CIEMDMEDHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x7082D40", Offset = "0x7081D40", VA = "0x187082D40", Slot = "12")]
	protected override DirectoryInfo IMACOPJBPCN(EJEHHNILJEA KAACMIHMDEC, POPNKLOMMCH CIEMDMEDHME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
public enum JPGAEKEGOLI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400071D")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
internal class MEEKFOMJFBG : CDEKICLHOIM
{
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private sealed class LFMFGNMOKHP : IEnumerable<JEIKNEHGIKE>, IEnumerable, IEnumerator<JEIKNEHGIKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		private JEIKNEHGIKE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public MEEKFOMJFBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		private EJEHHNILJEA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public EJEHHNILJEA <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private JPGAEKEGOLI[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private IEnumerator<JEIKNEHGIKE> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private JEIKNEHGIKE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x8A4A30", Offset = "0x8A3A30", VA = "0x1808A4A30")]
		[DebuggerHidden]
		public LFMFGNMOKHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x7081760", Offset = "0x7080760", VA = "0x187081760", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x7081380", Offset = "0x7080380", VA = "0x187081380", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x7081330", Offset = "0x7080330", VA = "0x187081330")]
		private void IKLMFKCBKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x7081710", Offset = "0x7080710", VA = "0x187081710", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x7081660", Offset = "0x7080660", VA = "0x187081660", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JEIKNEHGIKE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x7081660", Offset = "0x7080660", VA = "0x187081660", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private readonly JPGAEKEGOLI[] MPGKOHOKICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000721")]
	private readonly Dictionary<JPGAEKEGOLI, CDEKICLHOIM> BPOOEMIKKEF;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public JPGAEKEGOLI CGHPJKJHLNO
	{
		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x7081880", Offset = "0x7080880", VA = "0x187081880", Slot = "4")]
		get
		{
			return default(JPGAEKEGOLI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x7081D70", Offset = "0x7080D70", VA = "0x187081D70")]
	[UnityEngine.Scripting.Preserve]
	public MEEKFOMJFBG(params CDEKICLHOIM[] FMFIFLBICON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x70818B0", Offset = "0x70808B0", VA = "0x1870818B0", Slot = "5")]
	public bool EPFHMLCHMOI(long MFLLPFDNGGL, long EHHCEAFAAIL, EJEHHNILJEA KAACMIHMDEC, [Out] JEIKNEHGIKE IFMNCMCIJMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x7081B50", Offset = "0x7080B50", VA = "0x187081B50")]
	private void OAPKEBHONKG(int PMMAMLGJCML, long MFLLPFDNGGL, long EHHCEAFAAIL, EJEHHNILJEA KAACMIHMDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x70817F0", Offset = "0x70807F0", VA = "0x1870817F0", Slot = "6")]
	[IteratorStateMachine(typeof(LFMFGNMOKHP))]
	public IEnumerable<JEIKNEHGIKE> BNFHFKNGADK(EJEHHNILJEA KAACMIHMDEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x7081A00", Offset = "0x7080A00", VA = "0x187081A00", Slot = "7")]
	public JEIKNEHGIKE JNNHABKGKGO(long MFLLPFDNGGL, long EHHCEAFAAIL, EGHPBEBBELB AHNMDIOCJEH, EJEHHNILJEA KAACMIHMDEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
internal static class LEGODBHNLAF
{
	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x7081270", Offset = "0x7080270", VA = "0x187081270")]
	internal static byte[] POPEBEOBIGP(byte[] KABOAHAAMFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x70811F0", Offset = "0x70801F0", VA = "0x1870811F0")]
	public static void DKLINFKOFIO(Stream BDHIFNLNDAC, byte[] KHJBKCNBFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x7081010", Offset = "0x7080010", VA = "0x187081010")]
	public static bool DJPPNKJPGEC(Stream BDHIFNLNDAC, long CGGIJFBFAFD, DAJIOGMCCCK KHCNBEIEONO, [Out] byte[] PNBPJHLPGDE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal sealed class PAFGADHAGEM : JEIKNEHGIKE, IEquatable<JEIKNEHGIKE>, IEquatable<PAFGADHAGEM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	private readonly HENPLAMAOLJ KIHJDEDCLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	public readonly FileInfo OGLMDKANMED;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public JPGAEKEGOLI CGHPJKJHLNO
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A470", Offset = "0x6A39470", VA = "0x186A3A470", Slot = "9")]
		get
		{
			return default(JPGAEKEGOLI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DateTime MCFELABNJGF
	{
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x7083330", Offset = "0x7082330", VA = "0x187083330", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x7083530", Offset = "0x7082530", VA = "0x187083530")]
	public PAFGADHAGEM(HENPLAMAOLJ BJHMHMJNFOG, FileInfo IOIAJIBHODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x7083480", Offset = "0x7082480", VA = "0x187083480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x70833C0", Offset = "0x70823C0", VA = "0x1870833C0", Slot = "5")]
	public void PKLHKLNNHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x7083260", Offset = "0x7082260", VA = "0x187083260", Slot = "6")]
	public bool GKAIKKHEIJA(long MFLLPFDNGGL, long EHHCEAFAAIL, [Out] EGHPBEBBELB AHNMDIOCJEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x7082FD0", Offset = "0x7081FD0", VA = "0x187082FD0", Slot = "7")]
	public bool Equals(JEIKNEHGIKE ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x70830B0", Offset = "0x70820B0", VA = "0x1870830B0", Slot = "8")]
	public bool Equals(PAFGADHAGEM ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x7083170", Offset = "0x7082170", VA = "0x187083170", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x70832A0", Offset = "0x70822A0", VA = "0x1870832A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
public delegate void DAJIOGMCCCK(OMDNPJKGGMJ.LIGIEIEKJNK APACDGOJGLN, string KKHEHGHPOAA);
[Cpp2IlInjected.Token(Token = "0x20001B0")]
internal interface CDEKICLHOIM
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	JPGAEKEGOLI CGHPJKJHLNO
	{
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EPFHMLCHMOI(long MFLLPFDNGGL, long EHHCEAFAAIL, EJEHHNILJEA KAACMIHMDEC, [Out] JEIKNEHGIKE IFMNCMCIJMB);

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<JEIKNEHGIKE> BNFHFKNGADK(EJEHHNILJEA KAACMIHMDEC);

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JEIKNEHGIKE JNNHABKGKGO(long MFLLPFDNGGL, long EHHCEAFAAIL, EGHPBEBBELB AHNMDIOCJEH, EJEHHNILJEA KAACMIHMDEC);
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
