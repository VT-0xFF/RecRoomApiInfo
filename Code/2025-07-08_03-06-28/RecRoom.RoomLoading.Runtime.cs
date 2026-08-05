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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x892DF90", Offset = "0x892CD90", VA = "0x18892DF90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class ELFNFNHPMNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal Task<KFCNEKKBOAD> OEPAEMLBECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal Task LKNPIGMBAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal OLHIPLPGMDP NMMCPPAFCDK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public ELFNFNHPMNK()
	{
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8928B30", Offset = "0x8927930", VA = "0x188928B30", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x892FE00", Offset = "0x892EC00", VA = "0x18892FE00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GGNJKNIAJNP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x891D900", Offset = "0x891C700", VA = "0x18891D900")]
	public GGNJKNIAJNP(string IIHOFBLPONF, Exception CEFEOBEJCIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal class KDKJAJEMBMK : JAMPHEHOAJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PCBHOHMCCBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<IReadOnlyList<GOCLDJNMENA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private TaskAwaiter<NPKEOIJLPHH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x892EB30", Offset = "0x892D930", VA = "0x18892EB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x892ED70", Offset = "0x892DB70", VA = "0x18892ED70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct GKMHPCDJNGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<AAGOGOPCHGE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<List<AAGOGOPCHGE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x891E4F0", Offset = "0x891D2F0", VA = "0x18891E4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x891E700", Offset = "0x891D500", VA = "0x18891E700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	[UnityEngine.Scripting.Preserve]
	public KDKJAJEMBMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8926080", Offset = "0x8924E80", VA = "0x188926080", Slot = "4")]
	[AsyncStateMachine(typeof(PCBHOHMCCBK))]
	public Task<IReadOnlyList<GOCLDJNMENA>> FMGJPOKLMOI(long NCGHDDJNJOM, long HEPLHKILNBD, [Optional] CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x89261A0", Offset = "0x8924FA0", VA = "0x1889261A0", Slot = "5")]
	[AsyncStateMachine(typeof(GKMHPCDJNGE))]
	public Task<IReadOnlyList<AAGOGOPCHGE>> NKKDHNFBFFM(IReadOnlyList<int> OKLDCIBGGFD, [Optional] CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NIKGDGLIDHP : IEquatable<NIKGDGLIDHP>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int IIKDLGBOIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	AAGOGOPCHGE CCFNBMAEGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime NGAPNABJAAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	FHEHDDAJNCC? LDFCMIDBOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GKBAMBIBDEK? FJPGEEDBLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	FIBIPKAHBAA ALDNMHCMDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<PPJMMNMCCIA> JGCEGILIDLO();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum FIBIPKAHBAA
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JAMPHEHOAJH
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<GOCLDJNMENA>> FMGJPOKLMOI(long NCGHDDJNJOM, long HEPLHKILNBD, [Optional] CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<AAGOGOPCHGE>> NKKDHNFBFFM(IReadOnlyList<int> OKLDCIBGGFD, [Optional] CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LOIAKANFKGI
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class CLNLCFGJHNI : NIKGDGLIDHP, IEquatable<NIKGDGLIDHP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct BMFFMKLPJIL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncTaskMethodBuilder<PPJMMNMCCIA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public CLNLCFGJHNI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private IGPMCFDPCFE <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private TaskAwaiter<AACPGJNOFJH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private TaskAwaiter<PPJMMNMCCIA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8910E60", Offset = "0x890FC60", VA = "0x188910E60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x89113E0", Offset = "0x89101E0", VA = "0x1889113E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly GOCLDJNMENA MJDJIMJBOBN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int IIKDLGBOIEC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA5E620", Offset = "0xA5D420", VA = "0x180A5E620", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AAGOGOPCHGE CCFNBMAEGLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime AAGBGHFPMOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x89137A0", Offset = "0x89125A0", VA = "0x1889137A0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FHEHDDAJNCC? LDFCMIDBOHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2C58070", Offset = "0x2C56E70", VA = "0x182C58070", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public GKBAMBIBDEK? FJPGEEDBLPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8913700", Offset = "0x8912500", VA = "0x188913700", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public FIBIPKAHBAA ALDNMHCMDCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAB4B10", Offset = "0xAB3910", VA = "0x180AB4B10", Slot = "10")]
			get
			{
				return default(FIBIPKAHBAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x89137C0", Offset = "0x89125C0", VA = "0x1889137C0", Slot = "9")]
		[AsyncStateMachine(typeof(BMFFMKLPJIL))]
		public Task<PPJMMNMCCIA> JGCEGILIDLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8913900", Offset = "0x8912700", VA = "0x188913900")]
		public CLNLCFGJHNI(int DDMBBPDCACC, AAGOGOPCHGE CEBCOHDLCBO, GOCLDJNMENA MJDJIMJBOBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x89135D0", Offset = "0x89123D0", VA = "0x1889135D0", Slot = "11")]
		public bool Equals(NIKGDGLIDHP LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8913660", Offset = "0x8912460", VA = "0x188913660", Slot = "0")]
		public override bool Equals(object MKPNGAKJFMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x89138C0", Offset = "0x89126C0", VA = "0x1889138C0")]
		private bool LMAFFPNFCJE(CLNLCFGJHNI LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8913720", Offset = "0x8912520", VA = "0x188913720", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class BGHPICLPNFN : NIKGDGLIDHP, IEquatable<NIKGDGLIDHP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct BMAEFJNJLEA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public AsyncTaskMethodBuilder<PPJMMNMCCIA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public BGHPICLPNFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<PPJMMNMCCIA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8910BA0", Offset = "0x890F9A0", VA = "0x188910BA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8910DF0", Offset = "0x890FBF0", VA = "0x188910DF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly EKDPPHJHEGI EMLLEENGPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly FHEHDDAJNCC CAFHPAPDDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly GKBAMBIBDEK MONIALAGJJE;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int IIKDLGBOIEC
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x890FF80", Offset = "0x890ED80", VA = "0x18890FF80", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AAGOGOPCHGE CCFNBMAEGLL
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x890FCD0", Offset = "0x890EAD0", VA = "0x18890FCD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime AAGBGHFPMOL
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x890FFC0", Offset = "0x890EDC0", VA = "0x18890FFC0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public FHEHDDAJNCC? LDFCMIDBOHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8910160", Offset = "0x890EF60", VA = "0x188910160", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public GKBAMBIBDEK? FJPGEEDBLPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x890FEB0", Offset = "0x890ECB0", VA = "0x18890FEB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public FIBIPKAHBAA ALDNMHCMDCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCDFFB0", Offset = "0xCDEDB0", VA = "0x180CDFFB0", Slot = "10")]
			get
			{
				return default(FIBIPKAHBAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2099960", Offset = "0x2098760", VA = "0x182099960")]
		public BGHPICLPNFN(EKDPPHJHEGI LICJOHINBNE, FHEHDDAJNCC MOLNBPIJNNC, GKBAMBIBDEK IEICKFFCDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8910010", Offset = "0x890EE10", VA = "0x188910010", Slot = "9")]
		[AsyncStateMachine(typeof(BMAEFJNJLEA))]
		public Task<PPJMMNMCCIA> JGCEGILIDLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x890FE10", Offset = "0x890EC10", VA = "0x18890FE10", Slot = "11")]
		public bool Equals(NIKGDGLIDHP LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x890FD60", Offset = "0x890EB60", VA = "0x18890FD60", Slot = "0")]
		public override bool Equals(object MKPNGAKJFMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8910100", Offset = "0x890EF00", VA = "0x188910100")]
		private bool LMAFFPNFCJE(BGHPICLPNFN LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x890FF00", Offset = "0x890ED00", VA = "0x18890FF00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private sealed class DGACLDGFBHA : NIKGDGLIDHP, IEquatable<NIKGDGLIDHP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct AHEMKKHINCP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder<PPJMMNMCCIA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<PPJMMNMCCIA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x890EF00", Offset = "0x890DD00", VA = "0x18890EF00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x890F160", Offset = "0x890DF60", VA = "0x18890F160", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly AAGOGOPCHGE KEADCFODLLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly FHEHDDAJNCC CAFHPAPDDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly GKBAMBIBDEK MONIALAGJJE;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int IIKDLGBOIEC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x89153B0", Offset = "0x89141B0", VA = "0x1889153B0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public AAGOGOPCHGE CCFNBMAEGLL
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime AAGBGHFPMOL
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public FHEHDDAJNCC? LDFCMIDBOHL
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8915580", Offset = "0x8914380", VA = "0x188915580", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public GKBAMBIBDEK? FJPGEEDBLPK
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x89152D0", Offset = "0x89140D0", VA = "0x1889152D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public FIBIPKAHBAA ALDNMHCMDCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "10")]
			get
			{
				return default(FIBIPKAHBAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2099960", Offset = "0x2098760", VA = "0x182099960")]
		public DGACLDGFBHA(AAGOGOPCHGE CEBCOHDLCBO, FHEHDDAJNCC MOLNBPIJNNC, GKBAMBIBDEK IEICKFFCDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x89153D0", Offset = "0x89141D0", VA = "0x1889153D0", Slot = "9")]
		[AsyncStateMachine(typeof(AHEMKKHINCP))]
		public Task<PPJMMNMCCIA> JGCEGILIDLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8915260", Offset = "0x8914060", VA = "0x188915260", Slot = "11")]
		public bool Equals(NIKGDGLIDHP LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x89151E0", Offset = "0x8913FE0", VA = "0x1889151E0", Slot = "0")]
		public override bool Equals(object MKPNGAKJFMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8915320", Offset = "0x8914120", VA = "0x188915320", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x89154A0", Offset = "0x89142A0", VA = "0x1889154A0")]
		private bool LMAFFPNFCJE(DGACLDGFBHA LOKLFHKEJPC)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct IFIMEJNPPNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<IList<NIKGDGLIDHP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public LOIAKANFKGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IReadOnlyList<GOCLDJNMENA> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<IReadOnlyList<GOCLDJNMENA>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<(int accountId, AAGOGOPCHGE account, GOCLDJNMENA roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x89201F0", Offset = "0x891EFF0", VA = "0x1889201F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8921030", Offset = "0x891FE30", VA = "0x188921030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct NKOMOBHEEEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, AAGOGOPCHGE account, GOCLDJNMENA roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IReadOnlyList<GOCLDJNMENA> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public LOIAKANFKGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<IReadOnlyList<AAGOGOPCHGE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x892CD30", Offset = "0x892BB30", VA = "0x18892CD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x892D740", Offset = "0x892C540", VA = "0x18892D740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly GCMENIIILFB ODHKOJHHOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly JAMPHEHOAJH HPMAPLHDMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly AMDLPNAJCME INFNPKMDPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly DAOBLECFCHP<(long, long), IReadOnlyList<GOCLDJNMENA>> GPAPMEMLKAG;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8928A00", Offset = "0x8927800", VA = "0x188928A00")]
	[UnityEngine.Scripting.Preserve]
	public LOIAKANFKGI([OLOAAHJODHH(null)] JAMPHEHOAJH DJNNCBPICMB, [OLOAAHJODHH(null)] AMDLPNAJCME FPNCLJJEEPP, [OLOAAHJODHH(null)] GCMENIIILFB HIMNCMNNJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8928710", Offset = "0x8927510", VA = "0x188928710")]
	[AsyncStateMachine(typeof(IFIMEJNPPNF))]
	public Task<IList<NIKGDGLIDHP>> IMIOJDLOICL(long NCGHDDJNJOM, long KAAGEAEADCM, bool ILAKLMOLNLF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8928860", Offset = "0x8927660", VA = "0x188928860")]
	private bool JPJMGAPENJO(DateTime? BOKLFMGDFIB, long NCGHDDJNJOM, long KAAGEAEADCM, [Out] EKDPPHJHEGI KMKBPCBONMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8928600", Offset = "0x8927400", VA = "0x188928600")]
	[AsyncStateMachine(typeof(NKOMOBHEEEF))]
	private Task<IReadOnlyList<(int, AAGOGOPCHGE, GOCLDJNMENA)>> DOHKGMDNLLE(IReadOnlyList<GOCLDJNMENA> PKJDBALEOPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface AMDLPNAJCME
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<EKDPPHJHEGI> KAFGNKCFDAA;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KALFGHLLOIN(long NCGHDDJNJOM, long KAAGEAEADCM, FMBJDHFAPIA DFLHHMJDJCP, AJHDCFJNACE IJMPHHBDLBM);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MHOHMEADDLP(long NCGHDDJNJOM, long KAAGEAEADCM, [Out] EKDPPHJHEGI KMKBPCBONMH);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GNGIKGNNCHJ(long NCGHDDJNJOM, long KAAGEAEADCM, AJHDCFJNACE IJMPHHBDLBM, [Out] EKDPPHJHEGI KMKBPCBONMH);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GHEEKNACJEO(long NCGHDDJNJOM, long KAAGEAEADCM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface GCJLOJAJIIE : LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KHODBFAHJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task HHPODOEKDHA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KEOMAFHPJAI(Task JNOGJECEFDN, string OIPOAFMACCD);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface JBEKKAIEGIO : LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PPJMMNMCCIA> LANHHBIGBLF(EKDPPHJHEGI KMKBPCBONMH);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NPDIDDIBMBN(CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface AJFLOEABEBJ : LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	DBHNIBMELEK PEFNMIMJMIK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLNDJHPFCFO();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KPCJPPIIDAF();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface LFDFDKOBAHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGPDNICIDDD(IAMHPLKENKJ BFNHJCAHHAN);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal interface EGACAKPHMKL
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan DNGPNJGPOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan LKGPBLLOOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan KJLDPGHEGEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan MPOCPNLBIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool IBJHDCLIPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool AAHCIPBLEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OKKBLNGPBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int ILBNEAJAFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool CLMJPJAPBLM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool AIOEHOFCAKP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool MCAEFAEOEAO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum INFGEFHOJEO
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum HOIOGHENLBA
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct GOPOOGGIALC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly long HKCIJOEDKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly long HEPLHKILNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly INFGEFHOJEO DGPNPBEKOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[CanBeNull]
	public readonly Exception JLLKKKKGLOJ;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x891E7C0", Offset = "0x891D5C0", VA = "0x18891E7C0")]
	public GOPOOGGIALC(long HKCIJOEDKPP, long HEPLHKILNBD, INFGEFHOJEO DGPNPBEKOOD, [CanBeNull] Exception JLLKKKKGLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x891E770", Offset = "0x891D570", VA = "0x18891E770")]
	public static GOPOOGGIALC LJODEGLIPMG(PLJJBKEIPKH COFOIELIMID, INFGEFHOJEO DGPNPBEKOOD, [Optional] Exception JLLKKKKGLOJ)
	{
		return default(GOPOOGGIALC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void ALBAPOCHKGH(GOPOOGGIALC PIEALDOIJLL);
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface OJALOMIDNOE : LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event ALBAPOCHKGH MLGAFFNEKEH;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event ALBAPOCHKGH EHDKHOLEALH;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event ALBAPOCHKGH ELHECCHFCOD;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<HOIOGHENLBA, bool> JCCOMKLJLBH;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GBOLPPJLBAN(GOPOOGGIALC PIEALDOIJLL);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MPLNDNCIMJD(GOPOOGGIALC PIEALDOIJLL);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JCLCIAOBPKF(GOPOOGGIALC PIEALDOIJLL);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OEJGKBBLOPE(HOIOGHENLBA FPKOCILEBIL, bool BIFFJAIGCIP);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface FCLCFKPAGOL : LFDFDKOBAHG, IDisposable, HNAAGPPFDEA
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool ONFGOMOPJON
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPLIKPMOFKO();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface IMBMOMBAKHG : LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus BLIGHNGOINM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BJDFJHFOODK(PLJJBKEIPKH ICBDNDPBBBE, JPJHIFKDPIB GOOANGGIPNB, CancellationToken FOJIDEIIGFD);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class ILHLDKBOOOO
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8921B50", Offset = "0x8920950", VA = "0x188921B50")]
	public static bool CKNNKKICLIG(this IMBMOMBAKHG GMFEHAACDLA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task FKAPHGDHFGG(CancellationToken OCGDLEBGIMO, int CEEFGLDKHNK, KIBEKEOAJNC GNLPCANCLKL);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface EGGAILHONLB : LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOOECEAPGJM(FKAPHGDHFGG JCLBPCJGNNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface IAMHPLKENKJ : IGPMCFDPCFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken ILFCDLOICDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	LOAHJOOKLEP KHJENMFPGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	GLOINHDCCCK NMCBGJPOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	FKAEINJLMOK KCPIDHOOGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	LGPCFOHIOOE HLIHHKGELEG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	JPEKCHMJINJ HIKCMFOFKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	JCAELKFFBCM JEBDEAGIBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	CGDGOCJDGEK OMOAAHDHEKI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	PPEDIAHNHEB AGIDODKGDKF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	GCJLOJAJIIE ENDMFDKHHNE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	JBEKKAIEGIO BFAOKFHAOGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	OJALOMIDNOE LCJNHJJBAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	FCLCFKPAGOL APNLMMGGKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	IMBMOMBAKHG MENJHCMDOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	EGGAILHONLB GEGGNEFCMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	DGJPJGNBJOF GHOODOLJPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	AOPFJIOOICJ KJMANDGCHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GNKBHGLOHGH JBNNOCIHFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	GMGJGIMGKMD NHMBKLFELHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	DCFAMFOCBOI MNHDLMPABGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	FAJNPDJCFLB OEDPABBKBMB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	PIBMLGIDOAO IKPPEKBFHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	NOLLCEDHKEP ADIDOCIBFCN
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	KIHDNBBJLFN PBNCDKONKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	LAGJNAHAJLN OEKIEJGIGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	AJFLOEABEBJ PLMGDBPFIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	EGACAKPHMKL ADDIDOJALPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	MOHNFINFDFF DMHMDGACPKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AMDLPNAJCME HNIPLAMJGLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	KGBPGLLJLNA NGIJINOPKDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EJGFFGADOMD CNOLHPCOIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	BEMANHJPLDJ GKPLBPKLDFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	OOINCOPNPCH JKPIADPCMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool MLOEHGGAHKM
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
	void JDLBKDDDLKL(JPJHIFKDPIB LBLBCNHFEAD);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface DGJPJGNBJOF : LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LBEPELJJLIC OLHPIGGMIDE(Guid ALEMANCBDEO);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EBNLHEFHMEO(Guid ALEMANCBDEO);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PKNMEAHOGBO(Guid ALEMANCBDEO, Task MICEHCPDAIA);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EHBNLEMMIFL(Guid ALEMANCBDEO, PPJMMNMCCIA BGPOOIFCMDM);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(PPJMMNMCCIA, Task)> DFMILGNFCNB(Guid ALEMANCBDEO);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface LIENCJLLPEG : LFDFDKOBAHG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface AOPFJIOOICJ : LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPMCBNFPEGN(FGGKMIFBJPI IIHOFBLPONF);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CFNPKLBFILB(FGGKMIFBJPI IIHOFBLPONF);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<CHJGFILBKKF> FAONBGEGMKA(CancellationToken LMMGIHPFHOK);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface GNKBHGLOHGH : LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LBEPELJJLIC BDIFFOEICMJ(FGGKMIFBJPI HKONIAJLDMB);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NIIGLCJDFFL(Guid ALEMANCBDEO, Task MICEHCPDAIA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface GMGJGIMGKMD : LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PPJMMNMCCIA> NHMBKLFELHD(FGGKMIFBJPI GHELEALCFHI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface DCFAMFOCBOI : LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NLIPGAAAAGA> IHEBNJDEEDE(EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, PLJJBKEIPKH ICBDNDPBBBE, CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface PIBMLGIDOAO : LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PPJMMNMCCIA HCKHHPGLNKA(CDKFIILELLC FDPINKEEHCL);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ANPJMJIHEAL(string PFPNMKAMPMH);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface FAJNPDJCFLB : LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FGGKMIFBJPI> HJECGCIODNF(FGGKMIFBJPI OHNONCFAIKH, JHDPICMPNBI BIILOFMIEIC, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<FGGKMIFBJPI> BOGJHBJFJPL(CancellationToken HIMDFBHMPLL, JHDPICMPNBI BIILOFMIEIC);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NPKOEGNGKDP CGLMGHMJKAI(NJDDNJPCANH IGIEOCFKIHG, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NPKOEGNGKDP LOEHKGFNKCD(NJDDNJPCANH IGIEOCFKIHG, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface NOLLCEDHKEP : LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PPJMMNMCCIA JHOAJBCFPHD(CDKFIILELLC FDPINKEEHCL, CHJGFILBKKF NNEHFLALFCH);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PPJMMNMCCIA GDEBGHKJKGJ(CDKFIILELLC DLMFOKOOJGG);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface PAHJHCJMCKK
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	const int DIMBBDJDDBD = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, MAAJAIKPGDF> FFFIGPILMFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action LFOABHFOBBP
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
	IReadOnlyList<Guid> CDDHMABEGEC();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task ALEDBLNMHMA([Optional] CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task OELPDMGAHML([Optional] CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface KIHDNBBJLFN
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGPBDNIPMBE(CALGOMMCKGL HFPIMAOBLOC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGCNBOHFOPJ(CALGOMMCKGL HFPIMAOBLOC);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ENNACDJGBNC(CALGOMMCKGL HFPIMAOBLOC);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NFPHIMMLOEN(CALGOMMCKGL HFPIMAOBLOC);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class CALGOMMCKGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly PLJJBKEIPKH FINFGDIEKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Dictionary<string, string> JFCFOOFDADB;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public EHDFINDMEJI<string> KANBANFMPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA595B0", Offset = "0xA583B0", VA = "0x180A595B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
	public CALGOMMCKGL(PLJJBKEIPKH HOAMOKDGHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8911450", Offset = "0x8910250", VA = "0x188911450")]
	public CALGOMMCKGL DBDEDEDCJGF(string MAHBBBBCDEL, string BNECONOIKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8911520", Offset = "0x8910320", VA = "0x188911520")]
	public bool IJHKAKDEELM([Out] IEnumerable<KeyValuePair<string, string>> JAOKKOHHGDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x770BF30", Offset = "0x770AD30", VA = "0x18770BF30")]
	public CALGOMMCKGL FODAAJJJGPO(EHDFINDMEJI<string> INANPMNJHBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface MOHNFINFDFF
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool DIKDKKBEFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string OLFFLLPNNBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool OILEDBIGDFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FCDPBLMLBCF();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OJJNCLDHGBH BADHJAGJLHO(long CHOOOGFBFJJ);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IIJBCDKGIOM<MFCKDCKCJFL, CPDFLLLEANH> PHMLMJNBFBA(long CHOOOGFBFJJ);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IIJBCDKGIOM<MFCKDCKCJFL, IMABAOJCLFC> MBLLPANENNB(long CHOOOGFBFJJ);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IIJBCDKGIOM<long, HDFBKAHFHIL> GEOMDHIIIMG();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<AJBFPABIEDC>> KILOLALCPLI(long CHOOOGFBFJJ, IReadOnlyCollection<AJBFPABIEDC> OIGIHNBCKAP, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IMOAGEFFDOH(long CHOOOGFBFJJ, [Out] bool JHGEKFIBLPL);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> DMGCJFJEDIF(byte[] NOAJNBLGDKM, byte[] MGNGLPCCMFF, IReadOnlyCollection<Guid> HMLJEHBINGD, CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface NMBECPFKCLD
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NLIPGAAAAGA LDFHHMLGJNG(long HKCIJOEDKPP, long HEPLHKILNBD, string JFBBAOMPOPG);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NLIPGAAAAGA LDFHHMLGJNG(long HKCIJOEDKPP, long HEPLHKILNBD, MFCKDCKCJFL NOAJNBLGDKM, Guid? IJDGJLDLEAH, long HFGFHGICNFF, bool MCCIIGAJBFC);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NLIPGAAAAGA LDFHHMLGJNG(AEFELCHEGKN CFDCDCIGKII);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NLIPGAAAAGA LDFHHMLGJNG(AACPGJNOFJH KFOMNGFGCEM, GOCLDJNMENA ABPMJOCMDAE);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface IGPMCFDPCFE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool CKNNKKICLIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool EENPHBNAECE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool MLOEHGGAHKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	NMBECPFKCLD NDDJBDBLMMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	JPJHIFKDPIB KPKKDCOKINK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event ALBAPOCHKGH MLGAFFNEKEH;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event ALBAPOCHKGH EHDKHOLEALH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event ALBAPOCHKGH ELHECCHFCOD;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<HOIOGHENLBA, bool> JCCOMKLJLBH;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KPLIKPMOFKO();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GIAFIGCKAON KABJILIJPCN();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EDCNEBDIPFE MBBFBGAGLCL();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task ECNDFGCJPAF(int EJENBHALFPN, GAJAJCGPIFH LGBFOCAKECN, Func<FMBJDHFAPIA, FMBJDHFAPIA> HOKJJGOAHHD);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<PPJMMNMCCIA> LANHHBIGBLF(EKDPPHJHEGI LICJOHINBNE);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task NPDIDDIBMBN(CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface JPEKCHMJINJ
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool OAKELNDHEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool GHAENDDHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? NMKCLJPJFOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDJMNLNFENB(Scene BEKJEDDIMKB);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task AHBHCDCGDIP(ENBAOPBPJOK HJJEEOIEJHF, IReadOnlyList<ENBAOPBPJOK> PFPEMCCFGLB, IReadOnlyList<ENBAOPBPJOK> AOPPMLKGLGJ, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CNEFADLHLFI(Guid COBCHIDBIBM, IReadOnlyList<Guid> HMLJEHBINGD, PMCCBKDDIGM NAFMPEIKPOH, [Optional] object FEAHEFFKIPG);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task IPFOMECFHGA(IReadOnlyList<Guid> FFDKEMCNKJM, CancellationToken PBIMLDFENAO);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AIFEGLPMADP LKLDHAMJEBF();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task LLHFJLNDCBC();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GJEPGBLADOO(GameObject EJNHDGCJKPM);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task KADICFKICFE();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface LGPCFOHIOOE
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	KGJIHOMIGPB MFMKIIGCFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool LGEHBEHDLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool IGDCLHMFGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool CAGHPOHCJHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool JNJJPPIDOAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int KJNJGINCKNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool JGMPFJHBDML
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool NFCGILGEONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int GAHFIENIFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int JKFBPHEAMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool DPOPBNPEJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool LIDPOKPFDEN
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool DLJEABBKLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float BENFJHEGAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<float> IJAEGDCDGDK;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LOAHJOOKLEP NPGGLKIKPHC(LOAHJOOKLEP MIBEBGFMJBL);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGKDPLKBHJH(LOAHJOOKLEP CHDHLAGMCKI);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOAEJBGADFF();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task HHMMFPCHIPN(EHDFINDMEJI<string>.NGEIFBMECIG HCJDBBMEHLK, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JBBMFOBEICD(float CHNKJNHIHIH);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NDGKFLGEKBH(string DLNGPIGGLBL);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<JKDIEKHIAPL> JNFHHBGDPHI();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable KJPKFLLMAND(object IEOOLFDDEEF, JKDIEKHIAPL IOACPCLMBLG);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<LAKKBDHPEHD> CFABMEAGICJ();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CPDFLLLEANH MDDEJBPAHOP(IEnumerable<CDOFHMONKPD> LPAHBDJPCDG);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DHJFOOINEJG(int PBBMMPMCJKL);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task NJFAPIIHPIK();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PFCNHOHOJCH();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool MDJJPHJAMJM();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task KFHJENGOLGK(CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task MBFAIFKBPJF(CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<NJJCDLJJKIK> ABKHHPDJKLI(DateTime DMEELMAGLHI, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> DKCNIGKHBNA(CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OHIHDJHMJPC(string IIHOFBLPONF = "", float CFEOPLEMNPG = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "25")]
	GKILACMFGFC PBKMPCPAGJH(AKGLAIKGPKN OMJLEHMHBNK, FAGPKDIFNIN PCHBJGHMGLM, IMABAOJCLFC BADEBMBOFEI, IEnumerable<PersistenceView> HGIGECBAHNK, BCHJBLIFBEP IOMPNBMHBBN);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void POEECJABJKA(IMABAOJCLFC BADEBMBOFEI);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DBBNGHBJBHO(CDOFHMONKPD FKPLGDJFALO, [In] GKILACMFGFC KGGPHMGMLDK);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task CDPJLFLHJLJ(IMABAOJCLFC AACKIOLKKKG, bool MKHNHOGOHMC, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task OIJALBLANPG(CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void AFHNKJNDAPO(long NCGHDDJNJOM, long HEPLHKILNBD, AACPGJNOFJH OKIMGMJFNAN, GOCLDJNMENA BMGEAFGAKNK, FMBJDHFAPIA DFLHHMJDJCP, GAJAJCGPIFH? LGBFOCAKECN, HANPKCOEGMA? PANHNBEMPMM);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void CFONAHFBOAK(long NCGHDDJNJOM, long HEPLHKILNBD, HANPKCOEGMA? PANHNBEMPMM);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void KEEPBGCNEKB(PersistenceView BDGKJCLBGDD);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void AEGBJHKMJCE(string EAPPMENGJFI, PLJJBKEIPKH HOAMOKDGHIC, AOJDMMEOILE KHPEJJKCMGG, [Optional] string? CIGHNPIJEGG, [Optional] string? IICFPBFPGHG, [Optional] string? HOABJJDFHAC);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool NEOBOLAALKE(PersistenceView LNFFCKNEJCB);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool EJFECKFDBIN(CDOFHMONKPD FKPLGDJFALO, NPIADBPPJMB ICMMHNPEOPO, [Out] PDDMBACFDOH DGONEPIBNBP);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task KOMNDACHEFF(CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void FCNOBOCEBIM();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable KFKHCLAJJNB();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void PNDIJNIOMMG(IMABAOJCLFC AACKIOLKKKG, NPIADBPPJMB ICMMHNPEOPO);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> DHJGMADPLJH(GLOINHDCCCK LEFGLILMCMC, CancellationToken HIMDFBHMPLL, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void KADFNKNBKPH(CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<AEFELCHEGKN> IAMMCCCDNOA(AKMJAGKEJMP OHNONCFAIKH);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<AACPGJNOFJH> CBDONCLOMPL(long NCGHDDJNJOM, bool EHOAIBHFOJD, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<FPNKDIBEOOD> POAAHJPPLPD(long NCGHDDJNJOM, long HEPLHKILNBD, long HFGFHGICNFF, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<GOCLDJNMENA> OAPEDPNKLBE(long NCGHDDJNJOM, long HEPLHKILNBD, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<OGKANJAJEAE> NGEEBMADMAI(long NCGHDDJNJOM, Guid HAFDMNGFFCP, long? KAAGEAEADCM, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "47")]
	IIJBCDKGIOM<OGKANJAJEAE, IEnumerable<NMGBCEEGCOL>> HMBKAFJOAOG();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<BHOCDPCCCDL> KBNBAJFAGKD(string JFBBAOMPOPG, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<BHOCDPCCCDL> LJKIEFIGDJP(string JFBBAOMPOPG, long NCGHDDJNJOM, long HEPLHKILNBD, Guid? COBCHIDBIBM, FIPAFGIJBOP.CGNHFPAKDNP JBNEABKLADH, FIPAFGIJBOP.CGNHFPAKDNP MGNGLPCCMFF, int EJENBHALFPN);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool OIFEDKKEPKA();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool DHADEMOHAEG();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool JAGFIJIBKBF(IEnumerable<PDDMBACFDOH> AFLPOKCJFHH);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void HHPHNPAHLOE(List<GameObject> KBPJPPLFCII);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float NMJJNGGIJOH();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> OMGAAIGHKHG(CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> LIBPAGGNKFM(string NOBPIEKKHNK, LoadSceneMode KIANKJDHDBM, bool LPLCLLOHEOO, EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void GOJHOGPMOAH(bool IDKBJKINDBO);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void FMFKICBAJFO();

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void ENIDJEMFLNM();

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void DKJPEAOFCBI(bool GIHECMJKKFB);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task<FIPAFGIJBOP.CGNHFPAKDNP> CIAFFNCPDOD(byte[] BOIPFNOKGBJ, FIPAFGIJBOP.OLINBFOLOLP DJENKIKPJFK, GHCGODNMJLD LOFMPHHFPDG, [Optional] IReadOnlyCollection<string>? BOOLOKDINIP, [Optional] string? OFPIAOFINOO);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void KAAKCJPEODI(PLJJBKEIPKH OKIBNOEBHMI);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task MEGPFADMFLE(EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task KCDDFKPNLFO(EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task FKIPPJCDAAA(EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task JMACBJJBBNP(EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "77")]
	IDisposable BHLLMLDKLCL();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "78")]
	NFIHJEAHFPH GEBIEIGMICJ();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "79")]
	Task ACAMMPHMPHB(CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface NFIHJEAHFPH
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NKMCCGICPEC(CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NAGICONDAEG(CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct GKILACMFGFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public HashSet<int> AFMMACADHDH;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum NJJCDLJJKIK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct AKGLAIKGPKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Guid? IPLEJNECALM;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface KGJIHOMIGPB
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	PLJJBKEIPKH FBKEHCPFNMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	AACPGJNOFJH OFAHOLAEKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	EJHPEGDEELG LJGCNIGDKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool POOENBLLKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool AAMOFOLFMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int JAMCIBLCDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action EDLPAIACNDC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<int> IPHPDCMAGLB;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CCHLIJMJBAH();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.NMGGLFNPNKG> NPMDPKAGDIA(long CHOOOGFBFJJ, [Optional] CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<NGNNKBKHJLN> AEDDMEMODHH(PLJJBKEIPKH HOAMOKDGHIC, [Optional] JPJHIFKDPIB GOOANGGIPNB);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<NGNNKBKHJLN> DEGKIOOPGPN();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task FAGHCDJECGN();

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(PLJJBKEIPKH, JPJHIFKDPIB) NKLJAJGHLKA();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	DAIJPMNLLOK NNEFKGJKFDM();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EBNMFJEJJLE(long CHOOOGFBFJJ);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MDCAGBEIBHF(PLJJBKEIPKH HOAMOKDGHIC, Matchmaking.FOBJNAIFBPM OHLBIIOAJDL, (int Major, int? Minor)? PKDKDIFALGO);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface LAGJNAHAJLN
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FABPNMLKANJ([Out] IEnumerable<int> EIFCDGNHNDA);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDLJCCEIPKM(NLHHJHMMPAF OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MKEHNPJLACC(NLHHJHMMPAF OCGDLEBGIMO);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface ECFEPBNFIHL
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NKOLEELHLNM(PPJMMNMCCIA NLJIGEDEIGC);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface EJHFJJKEGIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGELDNNCDGD(ICGGKFMAOPJ.BHLIKILHFKC CBADCDGNEMB);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHHCMEAGKCJ(ICGGKFMAOPJ.BHLIKILHFKC CBADCDGNEMB);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface JCAELKFFBCM : EJHFJJKEGIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PPJMMNMCCIA NGAGMBABJLF(CDKFIILELLC DLMFOKOOJGG);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface CGDGOCJDGEK : EJHFJJKEGIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PPJMMNMCCIA HCKHHPGLNKA(CDKFIILELLC BFIOOMKAEHA);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface OJJNCLDHGBH
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CKPFCFEHEPP<NGMGMFNJOFA, BHGDKCCPEDL>> MLAFGDOOAJF(Guid? COBCHIDBIBM, IReadOnlyCollection<AJBFPABIEDC> LCBBEPHPGBM, IReadOnlyCollection<AJBFPABIEDC> JKEINEDOMEM, IOILJJGBHOC FIEBBBMGKJB, long? NCGHDDJNJOM, long? HEPLHKILNBD, CPNKCMLPCHO.BCNKMIJPOCG HOBJJPMKMPE, CancellationToken HIMDFBHMPLL, bool BBHMBPGFGNL = false);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class NGMGMFNJOFA
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public ENBAOPBPJOK FNFGKGFNOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<ENBAOPBPJOK> DEBEJMIHLLE
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<ENBAOPBPJOK> NEACJLINFNF
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xD42A30", Offset = "0xD41830", VA = "0x180D42A30")]
	public NGMGMFNJOFA(ENBAOPBPJOK JPOMHKNOMGF, IReadOnlyList<ENBAOPBPJOK> COLFLBDAAEM, IReadOnlyList<ENBAOPBPJOK> GKPGNNIPJDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface IIJBCDKGIOM<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CKPFCFEHEPP<DFNOANMHPNJ<TData>, BHGDKCCPEDL>> LCLMFAHGKCG(TGetDataArg AGJNJFMNGDN, CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class DHALFGHFEOA : IAMHPLKENKJ, IGPMCFDPCFE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct JCGBJHDBKCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<PPJMMNMCCIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public DHALFGHFEOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public EKDPPHJHEGI autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<PPJMMNMCCIA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8925630", Offset = "0x8924430", VA = "0x188925630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x89258B0", Offset = "0x89246B0", VA = "0x1889258B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct KKIAFGPBDKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public DHALFGHFEOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x89269F0", Offset = "0x89257F0", VA = "0x1889269F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8926C20", Offset = "0x8925A20", VA = "0x188926C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class IHNGPMOBNNF : IEnumerable<LFDFDKOBAHG>, IEnumerable, IEnumerator<LFDFDKOBAHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private LFDFDKOBAHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public DHALFGHFEOA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private LFDFDKOBAHG System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xF9A0D0", Offset = "0xF98ED0", VA = "0x180F9A0D0")]
		[DebuggerHidden]
		public IHNGPMOBNNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x89210A0", Offset = "0x891FEA0", VA = "0x1889210A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8921500", Offset = "0x8920300", VA = "0x188921500", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8921450", Offset = "0x8920250", VA = "0x188921450", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LFDFDKOBAHG> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8921450", Offset = "0x8920250", VA = "0x188921450", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly CancellationTokenSource GBINBLMHHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly LOAHJOOKLEP CHDHLAGMCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool HDGGIMAAJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private FINDDLJDFHM BIKFIIPDEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private bool PLPBLPBPPNB;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public GLOINHDCCCK NMCBGJPOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA5F360", Offset = "0xA5E160", VA = "0x180A5F360", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3A0", Offset = "0xA5E1A0", VA = "0x180A5F3A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public FKAEINJLMOK KCPIDHOOGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA5F330", Offset = "0xA5E130", VA = "0x180A5F330", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA5F370", Offset = "0xA5E170", VA = "0x180A5F370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public LGPCFOHIOOE HLIHHKGELEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA5F380", Offset = "0xA5E180", VA = "0x180A5F380", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA5F350", Offset = "0xA5E150", VA = "0x180A5F350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public JPEKCHMJINJ HIKCMFOFKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA5F320", Offset = "0xA5E120", VA = "0x180A5F320", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA5F340", Offset = "0xA5E140", VA = "0x180A5F340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public JCAELKFFBCM JEBDEAGIBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E190", VA = "0x180A5F390", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3B0", Offset = "0xA5E1B0", VA = "0x180A5F3B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public CGDGOCJDGEK OMOAAHDHEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA667D0", Offset = "0xA655D0", VA = "0x180A667D0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA66740", Offset = "0xA65540", VA = "0x180A66740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public NMBECPFKCLD NDDJBDBLMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA66720", Offset = "0xA65520", VA = "0x180A66720", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA66710", Offset = "0xA65510", VA = "0x180A66710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public PPEDIAHNHEB AGIDODKGDKF
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA66730", Offset = "0xA65530", VA = "0x180A66730", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA66690", Offset = "0xA65490", VA = "0x180A66690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public GCJLOJAJIIE ENDMFDKHHNE
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xABBEB0", Offset = "0xABACB0", VA = "0x180ABBEB0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xAB9B50", Offset = "0xAB8950", VA = "0x180AB9B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public JBEKKAIEGIO BFAOKFHAOGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA66680", Offset = "0xA65480", VA = "0x180A66680", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA667E0", Offset = "0xA655E0", VA = "0x180A667E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public OJALOMIDNOE LCJNHJJBAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xABC2D0", Offset = "0xABB0D0", VA = "0x180ABC2D0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xB0E290", Offset = "0xB0D090", VA = "0x180B0E290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public FCLCFKPAGOL APNLMMGGKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA65C30", Offset = "0xA64A30", VA = "0x180A65C30", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA65C10", Offset = "0xA64A10", VA = "0x180A65C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public IMBMOMBAKHG MENJHCMDOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xB0E4E0", Offset = "0xB0D2E0", VA = "0x180B0E4E0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xB0E440", Offset = "0xB0D240", VA = "0x180B0E440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public EGGAILHONLB GEGGNEFCMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xB28240", Offset = "0xB27040", VA = "0x180B28240", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xB28250", Offset = "0xB27050", VA = "0x180B28250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public DGJPJGNBJOF GHOODOLJPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xB0E4A0", Offset = "0xB0D2A0", VA = "0x180B0E4A0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xB28220", Offset = "0xB27020", VA = "0x180B28220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public LIENCJLLPEG AFPBDHBFBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xB0E460", Offset = "0xB0D260", VA = "0x180B0E460", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xB0E500", Offset = "0xB0D300", VA = "0x180B0E500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public AOPFJIOOICJ KJMANDGCHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xAD0BB0", Offset = "0xACF9B0", VA = "0x180AD0BB0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xAD4210", Offset = "0xAD3010", VA = "0x180AD4210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public GNKBHGLOHGH JBNNOCIHFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA65C40", Offset = "0xA64A40", VA = "0x180A65C40", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA65BF0", Offset = "0xA649F0", VA = "0x180A65BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public GMGJGIMGKMD NHMBKLFELHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xAD4880", Offset = "0xAD3680", VA = "0x180AD4880", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xAD41E0", Offset = "0xAD2FE0", VA = "0x180AD41E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public DCFAMFOCBOI MNHDLMPABGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xAD4870", Offset = "0xAD3670", VA = "0x180AD4870", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xAD3E60", Offset = "0xAD2C60", VA = "0x180AD3E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public FAJNPDJCFLB OEDPABBKBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xACF330", Offset = "0xACE130", VA = "0x180ACF330", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xACF1A0", Offset = "0xACDFA0", VA = "0x180ACF1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public PIBMLGIDOAO IKPPEKBFHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xADC5C0", Offset = "0xADB3C0", VA = "0x180ADC5C0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xAD7E10", Offset = "0xAD6C10", VA = "0x180AD7E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public NOLLCEDHKEP ADIDOCIBFCN
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAD0AA0", Offset = "0xACF8A0", VA = "0x180AD0AA0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xAD7D00", Offset = "0xAD6B00", VA = "0x180AD7D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public KIHDNBBJLFN PBNCDKONKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xAD27E0", Offset = "0xAD15E0", VA = "0x180AD27E0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xAD1030", Offset = "0xACFE30", VA = "0x180AD1030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public LAGJNAHAJLN OEKIEJGIGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xAD2690", Offset = "0xAD1490", VA = "0x180AD2690", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAD1550", Offset = "0xAD0350", VA = "0x180AD1550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public AJFLOEABEBJ PLMGDBPFIPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xAC0A30", Offset = "0xABF830", VA = "0x180AC0A30", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xAD2AF0", Offset = "0xAD18F0", VA = "0x180AD2AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public EGACAKPHMKL ADDIDOJALPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xBB4D80", Offset = "0xBB3B80", VA = "0x180BB4D80", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xBB8CC0", Offset = "0xBB7AC0", VA = "0x180BB8CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public MOHNFINFDFF DMHMDGACPKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xB21400", Offset = "0xB20200", VA = "0x180B21400", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xB1D8B0", Offset = "0xB1C6B0", VA = "0x180B1D8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public AMDLPNAJCME HNIPLAMJGLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xB210B0", Offset = "0xB1FEB0", VA = "0x180B210B0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public KGBPGLLJLNA NGIJINOPKDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xBAD880", Offset = "0xBAC680", VA = "0x180BAD880", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public EJGFFGADOMD CNOLHPCOIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xBB6A10", Offset = "0xBB5810", VA = "0x180BB6A10", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public BEMANHJPLDJ GKPLBPKLDFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xBAAC50", Offset = "0xBA9A50", VA = "0x180BAAC50", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public OOINCOPNPCH JKPIADPCMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xBC4B60", Offset = "0xBC3960", VA = "0x180BC4B60", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public JPJHIFKDPIB KPKKDCOKINK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xBB4C30", Offset = "0xBB3A30", VA = "0x180BB4C30", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xD32EA0", Offset = "0xD31CA0", VA = "0x180D32EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool JCFLENNINKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x89163D0", Offset = "0x89151D0", VA = "0x1889163D0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool NLJCPPCADOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8915630", Offset = "0x8914430", VA = "0x188915630", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool AHAHECOEMEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1E4DAC0", Offset = "0x1E4C8C0", VA = "0x181E4DAC0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken MNMHCNHHGGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8915740", Offset = "0x8914540", VA = "0x188915740", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private LOAHJOOKLEP DIGOKBPABDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool NBKFJMDDBPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1E4DAC0", Offset = "0x1E4C8C0", VA = "0x181E4DAC0", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1E494D0", Offset = "0x1E482D0", VA = "0x181E494D0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event ALBAPOCHKGH POLLCDJBBOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x89157C0", Offset = "0x89145C0", VA = "0x1889157C0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8915F20", Offset = "0x8914D20", VA = "0x188915F20", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event ALBAPOCHKGH MKKKKJKAHGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x89155D0", Offset = "0x89143D0", VA = "0x1889155D0", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8916430", Offset = "0x8915230", VA = "0x188916430", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event ALBAPOCHKGH OICKGGBDCCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8915760", Offset = "0x8914560", VA = "0x188915760", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8915F80", Offset = "0x8914D80", VA = "0x188915F80", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event Action<HOIOGHENLBA, bool> EKMMFIIDOEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8916370", Offset = "0x8915170", VA = "0x188916370", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8915960", Offset = "0x8914760", VA = "0x188915960", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xD32EA0", Offset = "0xD31CA0", VA = "0x180D32EA0", Slot = "39")]
	public void JDLBKDDDLKL(JPJHIFKDPIB LBLBCNHFEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8916490", Offset = "0x8915290", VA = "0x188916490")]
	[UnityEngine.Scripting.Preserve]
	internal DHALFGHFEOA([OLOAAHJODHH(null)] LOAHJOOKLEP CHDHLAGMCKI, [OLOAAHJODHH(null)] GLOINHDCCCK LEFGLILMCMC, [OLOAAHJODHH(null)] FKAEINJLMOK CMABOKIFKGB, [OLOAAHJODHH(null)] LGPCFOHIOOE JBNGHMBPLHF, [OLOAAHJODHH(null)] JPEKCHMJINJ NIEGOIHMACF, [OLOAAHJODHH(null)] JCAELKFFBCM OKHODMHHMGH, [OLOAAHJODHH(null)] CGDGOCJDGEK KPOCDPAKIDF, [OLOAAHJODHH(null)] PPEDIAHNHEB MCJJCFBAPMA, [OLOAAHJODHH(null)] GCJLOJAJIIE IMIPADJGEKM, [OLOAAHJODHH(null)] JBEKKAIEGIO JPCCAFMBOOD, [OLOAAHJODHH(null)] OJALOMIDNOE HIEOEHIBOHN, [OLOAAHJODHH(null)] FCLCFKPAGOL CGJHAKOJMPL, [OLOAAHJODHH(null)] IMBMOMBAKHG GMFEHAACDLA, [OLOAAHJODHH(null)] EGGAILHONLB EOGBKDHEEKF, [OLOAAHJODHH(null)] DGJPJGNBJOF MAIKMKJCLPB, [OLOAAHJODHH(null)] LIENCJLLPEG NDBEIDIMMAP, [OLOAAHJODHH(null)] AOPFJIOOICJ IBAAGPGMDOL, [OLOAAHJODHH(null)] GNKBHGLOHGH APHCKCMMBIL, [OLOAAHJODHH(null)] GMGJGIMGKMD PBAHGMJLGNG, [OLOAAHJODHH(null)] DCFAMFOCBOI NPLHAHEJEBO, [OLOAAHJODHH(null)] PIBMLGIDOAO HCDFMKKOFMJ, [OLOAAHJODHH(null)] FAJNPDJCFLB CEHHIHAKLOM, [OLOAAHJODHH(null)] NOLLCEDHKEP GLKHKGCNMAP, [OLOAAHJODHH(null)] KIHDNBBJLFN DADOFPDEGJB, [OLOAAHJODHH(null)] LAGJNAHAJLN JLHBJLOGOJD, [OLOAAHJODHH(null)] EGACAKPHMKL FNFCFIGCMHH, [OLOAAHJODHH(null)] MOHNFINFDFF FOAIFJJMCLD, [OLOAAHJODHH(null)] AMDLPNAJCME OANJMJACLBN, [OLOAAHJODHH(null)] KGBPGLLJLNA LEADOGOPBPO, [OLOAAHJODHH(null)] EJGFFGADOMD ACCELNCAJNL, [OLOAAHJODHH(null)] BEMANHJPLDJ NDJEEGCEAMD, [OLOAAHJODHH(null)] OOINCOPNPCH PNLFBNPOBPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x89159C0", Offset = "0x89147C0", VA = "0x1889159C0")]
	private void DGPDNICIDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x8915A70", Offset = "0x8914870", VA = "0x188915A70", Slot = "59")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x8915910", Offset = "0x8914710", VA = "0x188915910", Slot = "51")]
	private void DEBHOMBPCPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8916170", Offset = "0x8914F70", VA = "0x188916170", Slot = "52")]
	private GIAFIGCKAON KMCAAIEKJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x89156B0", Offset = "0x89144B0", VA = "0x1889156B0", Slot = "53")]
	private EDCNEBDIPFE BEKAOFCAOGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x8915C10", Offset = "0x8914A10", VA = "0x188915C10", Slot = "55")]
	public Task ECNDFGCJPAF(int EJENBHALFPN, GAJAJCGPIFH LGBFOCAKECN, Func<FMBJDHFAPIA, FMBJDHFAPIA> HOKJJGOAHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x8915FE0", Offset = "0x8914DE0", VA = "0x188915FE0")]
	private BCPDGLIGHPJ GGEANBBFMGL(int EJENBHALFPN, GAJAJCGPIFH LGBFOCAKECN, Func<FMBJDHFAPIA, FMBJDHFAPIA> HOKJJGOAHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8916200", Offset = "0x8915000", VA = "0x188916200", Slot = "56")]
	[AsyncStateMachine(typeof(JCGBJHDBKCG))]
	private Task<PPJMMNMCCIA> LFLAFOMKMIG(EKDPPHJHEGI KMKBPCBONMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8915820", Offset = "0x8914620", VA = "0x188915820", Slot = "57")]
	[AsyncStateMachine(typeof(KKIAFGPBDKP))]
	private Task DAJBNJAIDKE(CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x89160F0", Offset = "0x8914EF0", VA = "0x1889160F0")]
	[IteratorStateMachine(typeof(IHNGPMOBNNF))]
	private IEnumerable<LFDFDKOBAHG> HIHGBPCNIND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8916310", Offset = "0x8915110", VA = "0x188916310")]
	[CompilerGenerated]
	private void MEHBCPIGECN(LFDFDKOBAHG LPAADBJGJNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class LGAFKNHLBIM : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x19F6B30", Offset = "0x19F5930", VA = "0x1819F6B30")]
	public LGAFKNHLBIM(string IIHOFBLPONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class FGIKCMDANEO : OBMECOIMEFL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct BJLOBGKIHAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder<OBMECOIMEFL.ICEBLFILIGL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public HashSet<HNAAGPPFDEA.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public FGIKCMDANEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8910820", Offset = "0x890F620", VA = "0x188910820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8910B30", Offset = "0x890F930", VA = "0x188910B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly IAMHPLKENKJ BFNHJCAHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly LGPCFOHIOOE JBNGHMBPLHF;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string IGLCNABAKFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x891C6D0", Offset = "0x891B4D0", VA = "0x18891C6D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0xA639A0", Offset = "0xA627A0", VA = "0x180A639A0")]
	public FGIKCMDANEO(IAMHPLKENKJ BFNHJCAHHAN, LGPCFOHIOOE JBNGHMBPLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x891C700", Offset = "0x891B500", VA = "0x18891C700", Slot = "5")]
	[AsyncStateMachine(typeof(BJLOBGKIHAL))]
	public Task<OBMECOIMEFL.ICEBLFILIGL> MDNDICMMFJF(HashSet<HNAAGPPFDEA.Reason> LINHJBCCENH, CancellationToken HIMDFBHMPLL, HNAAGPPFDEA.Reason EGLDLGDMAJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class CGNANBAEJLJ : JEDGLAHHBLA, OBMECOIMEFL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct GIKILIDLKBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<OBMECOIMEFL.ICEBLFILIGL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CGNANBAEJLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public HashSet<HNAAGPPFDEA.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public HNAAGPPFDEA.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private PLJJBKEIPKH <localRoomInstance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private long <preFallbackInstance>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private bool <currentIsOffline>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<OBMECOIMEFL.ICEBLFILIGL> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x891DAB0", Offset = "0x891C8B0", VA = "0x18891DAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x891E480", Offset = "0x891D280", VA = "0x18891E480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly CALDANMDCAE PGLPLMOMPKJ;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string IGLCNABAKFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8911A50", Offset = "0x8910850", VA = "0x188911A50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8911C50", Offset = "0x8910A50", VA = "0x188911C50")]
	public CGNANBAEJLJ([OLOAAHJODHH(null)] IAMHPLKENKJ BFNHJCAHHAN, [OLOAAHJODHH(null)] LGPCFOHIOOE JBNGHMBPLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8911A80", Offset = "0x8910880", VA = "0x188911A80", Slot = "5")]
	[AsyncStateMachine(typeof(GIKILIDLKBB))]
	public Task<OBMECOIMEFL.ICEBLFILIGL> MDNDICMMFJF(HashSet<HNAAGPPFDEA.Reason> LINHJBCCENH, CancellationToken HIMDFBHMPLL, HNAAGPPFDEA.Reason EGLDLGDMAJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class KCDOBEEEENH : JEDGLAHHBLA, OBMECOIMEFL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct KMIAJLNCOHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<OBMECOIMEFL.ICEBLFILIGL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public KCDOBEEEENH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public HashSet<HNAAGPPFDEA.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<NGNNKBKHJLN> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<OBMECOIMEFL.ICEBLFILIGL> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8926C80", Offset = "0x8925A80", VA = "0x188926C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8927670", Offset = "0x8926470", VA = "0x188927670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string IGLCNABAKFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8925E80", Offset = "0x8924C80", VA = "0x188925E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0xA639A0", Offset = "0xA627A0", VA = "0x180A639A0")]
	public KCDOBEEEENH(IAMHPLKENKJ BFNHJCAHHAN, LGPCFOHIOOE JBNGHMBPLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8925EB0", Offset = "0x8924CB0", VA = "0x188925EB0", Slot = "5")]
	[AsyncStateMachine(typeof(KMIAJLNCOHC))]
	public Task<OBMECOIMEFL.ICEBLFILIGL> MDNDICMMFJF(HashSet<HNAAGPPFDEA.Reason> LINHJBCCENH, CancellationToken HIMDFBHMPLL, HNAAGPPFDEA.Reason EGLDLGDMAJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class MONPPIJODCL : JEDGLAHHBLA, OBMECOIMEFL
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class GIBCEHNODMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public NGNNKBKHJLN matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public PLJJBKEIPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public GIBCEHNODMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x891D970", Offset = "0x891C770", VA = "0x18891D970")]
		internal object EMHAFLLDGFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x891D9F0", Offset = "0x891C7F0", VA = "0x18891D9F0")]
		internal object FBKNKPKAGLO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct HIKFEJAHCGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<OBMECOIMEFL.ICEBLFILIGL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public MONPPIJODCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public HashSet<HNAAGPPFDEA.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private GIBCEHNODMM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public HNAAGPPFDEA.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter<NGNNKBKHJLN> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter<OBMECOIMEFL.ICEBLFILIGL> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x891F350", Offset = "0x891E150", VA = "0x18891F350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x891FFF0", Offset = "0x891EDF0", VA = "0x18891FFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly CALDANMDCAE PGLPLMOMPKJ;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string IGLCNABAKFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x892CA60", Offset = "0x892B860", VA = "0x18892CA60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x892CC60", Offset = "0x892BA60", VA = "0x18892CC60")]
	public MONPPIJODCL([OLOAAHJODHH(null)] IAMHPLKENKJ BFNHJCAHHAN, [OLOAAHJODHH(null)] LGPCFOHIOOE JBNGHMBPLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x892CA90", Offset = "0x892B890", VA = "0x18892CA90", Slot = "5")]
	[AsyncStateMachine(typeof(HIKFEJAHCGM))]
	public Task<OBMECOIMEFL.ICEBLFILIGL> MDNDICMMFJF(HashSet<HNAAGPPFDEA.Reason> LINHJBCCENH, CancellationToken HIMDFBHMPLL, HNAAGPPFDEA.Reason EGLDLGDMAJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class JEDGLAHHBLA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct MMOGFBFBPHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public PHLHEDGDBJO log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public HashSet<HNAAGPPFDEA.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public JEDGLAHHBLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private List<HNAAGPPFDEA.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x892B7C0", Offset = "0x892A5C0", VA = "0x18892B7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x892BCE0", Offset = "0x892AAE0", VA = "0x18892BCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	protected readonly IAMHPLKENKJ BFNHJCAHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	protected readonly LGPCFOHIOOE JBNGHMBPLHF;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected KGJIHOMIGPB MFMKIIGCFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8925920", Offset = "0x8924720", VA = "0x188925920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0xA639A0", Offset = "0xA627A0", VA = "0x180A639A0")]
	public JEDGLAHHBLA(IAMHPLKENKJ BFNHJCAHHAN, LGPCFOHIOOE JBNGHMBPLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8925970", Offset = "0x8924770", VA = "0x188925970")]
	[AsyncStateMachine(typeof(MMOGFBFBPHE))]
	protected Task LKFDGPGLGNO(PHLHEDGDBJO CFEMPAINFAM, HashSet<HNAAGPPFDEA.Reason> LINHJBCCENH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class GEMMPNPPEHP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct BIONALHNGKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder<OBMECOIMEFL.ICEBLFILIGL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public LGPCFOHIOOE callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8910430", Offset = "0x890F230", VA = "0x188910430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x89107B0", Offset = "0x890F5B0", VA = "0x1889107B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class HLFPPFLKDIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public IAMHPLKENKJ roomManager;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public HLFPPFLKDIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8920060", Offset = "0x891EE60", VA = "0x188920060")]
		internal object ALPJDDNFBIA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static readonly float BFLNEDCOFNG;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	internal static readonly HashSet<HNAAGPPFDEA.Reason> CJIADLKCAIJ;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x891D550", Offset = "0x891C350", VA = "0x18891D550")]
	[AsyncStateMachine(typeof(BIONALHNGKI))]
	internal static Task<OBMECOIMEFL.ICEBLFILIGL> BNANBGBJLHE(LGPCFOHIOOE JBNGHMBPLHF, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x891D660", Offset = "0x891C460", VA = "0x18891D660")]
	internal static void EJPMNFJLLMC(IAMHPLKENKJ BFNHJCAHHAN, PHLHEDGDBJO CFEMPAINFAM, string EAPPMENGJFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface OBMECOIMEFL
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct ICEBLFILIGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool BIFFJAIGCIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public HNAAGPPFDEA.Reason EGLDLGDMAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Enum? HOABJJDFHAC;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8920160", Offset = "0x891EF60", VA = "0x188920160")]
		public static ICEBLFILIGL IFJDHFKELAG()
		{
			return default(ICEBLFILIGL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8920170", Offset = "0x891EF70", VA = "0x188920170")]
		public static ICEBLFILIGL MDEBBNDOHDH(HNAAGPPFDEA.Reason EGLDLGDMAJN, [Optional] Enum? HOABJJDFHAC)
		{
			return default(ICEBLFILIGL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string ECNMBNLMJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ICEBLFILIGL> MDNDICMMFJF(HashSet<HNAAGPPFDEA.Reason> LINHJBCCENH, CancellationToken HIMDFBHMPLL, HNAAGPPFDEA.Reason EGLDLGDMAJN);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct KFAODDGHNGO
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class IEGICLFBBMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public IAMHPLKENKJ manager;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public IEGICLFBBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x89201A0", Offset = "0x891EFA0", VA = "0x1889201A0")]
		internal Task NLCOLIPDLCM(CancellationToken cancellationToken, int roomTotalVersion, KIBEKEOAJNC localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct IJIJJGFCOFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public KFAODDGHNGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private EKDPPHJHEGI <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter<NJJCDLJJKIK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private TaskAwaiter<PPJMMNMCCIA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8921550", Offset = "0x8920350", VA = "0x188921550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8921AE0", Offset = "0x89208E0", VA = "0x188921AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct AKFIEIHAGDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public KFAODDGHNGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x890F950", Offset = "0x890E750", VA = "0x18890F950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x890FC70", Offset = "0x890EA70", VA = "0x18890FC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly CancellationToken HIMDFBHMPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly IAMHPLKENKJ HEJIJKOGOJP;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private GLOINHDCCCK NMCBGJPOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x89262B0", Offset = "0x89250B0", VA = "0x1889262B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private LGPCFOHIOOE HLIHHKGELEG
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x89266C0", Offset = "0x89254C0", VA = "0x1889266C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private KGJIHOMIGPB MFMKIIGCFHG
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8926300", Offset = "0x8925100", VA = "0x188926300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private JBEKKAIEGIO BFAOKFHAOGG
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8926540", Offset = "0x8925340", VA = "0x188926540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x29D0CE0", Offset = "0x29CFAE0", VA = "0x1829D0CE0")]
	public KFAODDGHNGO(CancellationToken HIMDFBHMPLL, IAMHPLKENKJ HEJIJKOGOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8926380", Offset = "0x8925180", VA = "0x188926380")]
	public static FKAPHGDHFGG DCJCDOKAOAM(IAMHPLKENKJ HEJIJKOGOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8926430", Offset = "0x8925230", VA = "0x188926430")]
	[AsyncStateMachine(typeof(IJIJJGFCOFI))]
	public Task<bool> DIEFFEOBOIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8926710", Offset = "0x8925510", VA = "0x188926710")]
	private bool LECPFPLGEHP([Out] EKDPPHJHEGI KMKBPCBONMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8926920", Offset = "0x8925720", VA = "0x188926920")]
	[AsyncStateMachine(typeof(AKFIEIHAGDF))]
	private Task NKBHFEGECCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8926590", Offset = "0x8925390", VA = "0x188926590")]
	private Task<NJJCDLJJKIK> GADNIBEJFDA(EKDPPHJHEGI APNIFELMKLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct LBEPELJJLIC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly DGJPJGNBJOF MAIKMKJCLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Guid ALEMANCBDEO;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(PPJMMNMCCIA, Task)> PELEODOOCPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x89277B0", Offset = "0x89265B0", VA = "0x1889277B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x53D9BE0", Offset = "0x53D89E0", VA = "0x1853D9BE0")]
	public LBEPELJJLIC(DGJPJGNBJOF MAIKMKJCLPB, Guid ALEMANCBDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x8927880", Offset = "0x8926680", VA = "0x188927880")]
	public TaskAwaiter<(PPJMMNMCCIA, Task)> PPFCCOKCHJK()
	{
		return default(TaskAwaiter<(PPJMMNMCCIA, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x89276E0", Offset = "0x89264E0", VA = "0x1889276E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct JIKMAKKMEFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly TaskCompletionSource<(PPJMMNMCCIA, Task)> JHBHCDOAGEM;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(PPJMMNMCCIA, Task)> PELEODOOCPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8925CB0", Offset = "0x8924AB0", VA = "0x188925CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x8925CF0", Offset = "0x8924AF0", VA = "0x188925CF0")]
	public JIKMAKKMEFO(TimeSpan DKEAKDFFACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8925B80", Offset = "0x8924980", VA = "0x188925B80")]
	public void GBLPBIKHJDJ(Task MICEHCPDAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8925C20", Offset = "0x8924A20", VA = "0x188925C20")]
	public void KKFLCCFGKLF(PPJMMNMCCIA NLJIGEDEIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8925B30", Offset = "0x8924930", VA = "0x188925B30")]
	public void DAGOBKMFPGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x8925AA0", Offset = "0x89248A0", VA = "0x188925AA0")]
	internal void BKMMHNAJECE(string IIHOFBLPONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class EIDOFLCDAAL
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x891C320", Offset = "0x891B120", VA = "0x18891C320")]
	public static NLIPGAAAAGA BLGOBPECFFB(this NLIPGAAAAGA OFCPJKNFOPJ, AACPGJNOFJH BBJBEDCNANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x891C4C0", Offset = "0x891B2C0", VA = "0x18891C4C0")]
	public static NLIPGAAAAGA ELGMIFIDCJA(this NLIPGAAAAGA OFCPJKNFOPJ, GOCLDJNMENA MKFJEDLGJOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class AHHIIKIFPMB : NMBECPFKCLD
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class PPHFEBOHNAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public GOCLDJNMENA subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public PPHFEBOHNAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x892EDE0", Offset = "0x892DBE0", VA = "0x18892EDE0")]
		internal bool DCGDNMAPJEP(EJHPEGDEELG s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly EGACAKPHMKL LOLCCHCNOBA;

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
	public AHHIIKIFPMB(EGACAKPHMKL FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x890F1D0", Offset = "0x890DFD0", VA = "0x18890F1D0", Slot = "4")]
	public NLIPGAAAAGA LDFHHMLGJNG(long HKCIJOEDKPP, long HEPLHKILNBD, string JFBBAOMPOPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x890F260", Offset = "0x890E060", VA = "0x18890F260", Slot = "5")]
	public NLIPGAAAAGA LDFHHMLGJNG(long HKCIJOEDKPP, long HEPLHKILNBD, MFCKDCKCJFL NOAJNBLGDKM, Guid? IJDGJLDLEAH, long HFGFHGICNFF, bool MCCIIGAJBFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x890F6A0", Offset = "0x890E4A0", VA = "0x18890F6A0", Slot = "6")]
	public NLIPGAAAAGA LDFHHMLGJNG(AEFELCHEGKN CFDCDCIGKII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x890F3C0", Offset = "0x890E1C0", VA = "0x18890F3C0", Slot = "7")]
	public NLIPGAAAAGA LDFHHMLGJNG(AACPGJNOFJH KFOMNGFGCEM, GOCLDJNMENA ABPMJOCMDAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x890F8A0", Offset = "0x890E6A0", VA = "0x18890F8A0")]
	private Guid? LHODMJPEEEL(AACPGJNOFJH MPEIFBKCFBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class HDEJALPJIJC : GCJLOJAJIIE, LFDFDKOBAHG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct CJFHBOKGMFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public HDEJALPJIJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8911D20", Offset = "0x8910B20", VA = "0x188911D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x89123C0", Offset = "0x89111C0", VA = "0x1889123C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly NLHHJHMMPAF AJOLCMHOJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private string OMMAKIAKELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Task GPLFOBDDMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private IAMHPLKENKJ BFNHJCAHHAN;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool KHODBFAHJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x891F290", Offset = "0x891E090", VA = "0x18891F290", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task HHPODOEKDHA
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x891F0A0", Offset = "0x891DEA0", VA = "0x18891F0A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0xA59830", Offset = "0xA58630", VA = "0x180A59830", Slot = "7")]
	public void DGPDNICIDDD(IAMHPLKENKJ BFNHJCAHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x891F130", Offset = "0x891DF30", VA = "0x18891F130", Slot = "6")]
	public void KEOMAFHPJAI(Task JNOGJECEFDN, string OIPOAFMACCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x891EF80", Offset = "0x891DD80", VA = "0x18891EF80")]
	[AsyncStateMachine(typeof(CJFHBOKGMFC))]
	private Task BHLIEHOFAMO(Task AJBOIAFJGMF, string OIPOAFMACCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x891F2C0", Offset = "0x891E0C0", VA = "0x18891F2C0")]
	public HDEJALPJIJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class CCIHELAPACL : AJFLOEABEBJ, LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private bool PCADIIGPFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private DBHNIBMELEK GHFGIKNNIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private GLOINHDCCCK LEFGLILMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private EGACAKPHMKL FNFCFIGCMHH;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public DBHNIBMELEK PEFNMIMJMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8911830", Offset = "0x8910630", VA = "0x188911830", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8911670", Offset = "0x8910470", VA = "0x188911670", Slot = "7")]
	public void DGPDNICIDDD(IAMHPLKENKJ BFNHJCAHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x89118A0", Offset = "0x89106A0", VA = "0x1889118A0", Slot = "5")]
	public void NLNDJHPFCFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x89117F0", Offset = "0x89105F0", VA = "0x1889117F0", Slot = "6")]
	public void KPCJPPIIDAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x89115B0", Offset = "0x89103B0", VA = "0x1889115B0")]
	private Task AJJNJFNDJIN(CMNFMNABDHH FCNMCCJKGMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x89117F0", Offset = "0x89105F0", VA = "0x1889117F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public CCIHELAPACL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class HCHLGKOFIBN : EGACAKPHMKL
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class MOOCIGFCCFK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly EILEDNOBBBM BMDDNKKDAIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly string MAHBBBBCDEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly T JILABBLHNAO;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T HBDLGDLEPJD
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xB2CDD0", Offset = "0xB2BBD0", VA = "0x180B2CDD0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xB2CE40", Offset = "0xB2BC40", VA = "0x180B2CE40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x568ABE0", Offset = "0x56899E0", VA = "0x18568ABE0")]
		public MOOCIGFCCFK(EILEDNOBBBM BMDDNKKDAIM, string MAHBBBBCDEL, T JILABBLHNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x568A6B0", Offset = "0x56894B0", VA = "0x18568A6B0")]
		private void PHEAJCANOLL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly EILEDNOBBBM BMDDNKKDAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly MOOCIGFCCFK<TimeSpan> DOLDKAGCHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly MOOCIGFCCFK<TimeSpan> OFPKAGOHJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly MOOCIGFCCFK<TimeSpan> GJNCOBLFECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly MOOCIGFCCFK<TimeSpan> HNCBJDJOCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly MOOCIGFCCFK<bool> KIACLGEBCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly MOOCIGFCCFK<bool> NIPEAGMENHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly MOOCIGFCCFK<bool> JNLAAGBNDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly MOOCIGFCCFK<int> BGJINNOEMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly MOOCIGFCCFK<bool> FBJCLCOFCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly MOOCIGFCCFK<bool> NODNOCILNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly MOOCIGFCCFK<LPFMLMENMHJ> MJPJAPBBKKD;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan DNGPNJGPOEP
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x891EA70", Offset = "0x891D870", VA = "0x18891EA70", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan LKGPBLLOOJK
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x891E7E0", Offset = "0x891D5E0", VA = "0x18891E7E0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan KJLDPGHEGEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x891EA30", Offset = "0x891D830", VA = "0x18891EA30", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan MPOCPNLBIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x891E9F0", Offset = "0x891D7F0", VA = "0x18891E9F0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool IBJHDCLIPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x891E8F0", Offset = "0x891D6F0", VA = "0x18891E8F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool AAHCIPBLEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x891E870", Offset = "0x891D670", VA = "0x18891E870", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool OKKBLNGPBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x891E8B0", Offset = "0x891D6B0", VA = "0x18891E8B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int ILBNEAJAFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x891E9B0", Offset = "0x891D7B0", VA = "0x18891E9B0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool CLMJPJAPBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x891E930", Offset = "0x891D730", VA = "0x18891E930", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool AIOEHOFCAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x891E970", Offset = "0x891D770", VA = "0x18891E970", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool MCAEFAEOEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x891E820", Offset = "0x891D620", VA = "0x18891E820", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x891EAB0", Offset = "0x891D8B0", VA = "0x18891EAB0")]
	[UnityEngine.Scripting.Preserve]
	public HCHLGKOFIBN([OLOAAHJODHH(null)] EILEDNOBBBM BMDDNKKDAIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class COKKBKPJKCP : OJALOMIDNOE, LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class MCBFHMIGMDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public GOPOOGGIALC roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public MCBFHMIGMDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8928EF0", Offset = "0x8927CF0", VA = "0x188928EF0")]
		internal object LJAMDAJPPFL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event ALBAPOCHKGH MLGAFFNEKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8914B30", Offset = "0x8913930", VA = "0x188914B30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8914BD0", Offset = "0x89139D0", VA = "0x188914BD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event ALBAPOCHKGH EHDKHOLEALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8914FF0", Offset = "0x8913DF0", VA = "0x188914FF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8914ED0", Offset = "0x8913CD0", VA = "0x188914ED0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event ALBAPOCHKGH ELHECCHFCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8915090", Offset = "0x8913E90", VA = "0x188915090", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8914E00", Offset = "0x8913C00", VA = "0x188914E00", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<HOIOGHENLBA, bool> JCCOMKLJLBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8914D20", Offset = "0x8913B20", VA = "0x188914D20", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8914C70", Offset = "0x8913A70", VA = "0x188914C70", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "16")]
	public void DGPDNICIDDD(IAMHPLKENKJ BFNHJCAHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8914DD0", Offset = "0x8913BD0", VA = "0x188914DD0", Slot = "12")]
	public void GBOLPPJLBAN(GOPOOGGIALC PIEALDOIJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8914F70", Offset = "0x8913D70", VA = "0x188914F70", Slot = "13")]
	public void MPLNDNCIMJD(GOPOOGGIALC PIEALDOIJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8914EA0", Offset = "0x8913CA0", VA = "0x188914EA0", Slot = "14")]
	public void JCLCIAOBPKF(GOPOOGGIALC PIEALDOIJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8914FA0", Offset = "0x8913DA0", VA = "0x188914FA0", Slot = "15")]
	public void OEJGKBBLOPE(HOIOGHENLBA FPKOCILEBIL, bool BIFFJAIGCIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8914960", Offset = "0x8913760", VA = "0x188914960")]
	private void BOBFGEKALDJ(ALBAPOCHKGH IOACPCLMBLG, GOPOOGGIALC PIEALDOIJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public COKKBKPJKCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[UnityEngine.Scripting.Preserve]
internal class COHBEHLPPLB : FCLCFKPAGOL, LFDFDKOBAHG, IDisposable, HNAAGPPFDEA
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private class MIEEHFDDDGD : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct NOCACBAKBMP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public MIEEHFDDDGD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public HNAAGPPFDEA.ENHGMKIIJDN reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			private HICKLFFFPPA <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private OBMECOIMEFL[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			private TaskAwaiter<OBMECOIMEFL.ICEBLFILIGL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x892D7B0", Offset = "0x892C5B0", VA = "0x18892D7B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x892DF30", Offset = "0x892CD30", VA = "0x18892DF30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct LELCKLGPDEA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public AsyncTaskMethodBuilder<OBMECOIMEFL.ICEBLFILIGL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public OBMECOIMEFL fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public MIEEHFDDDGD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public HNAAGPPFDEA.ENHGMKIIJDN reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private HICKLFFFPPA <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			private FLJJFALOMJJ <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private TaskAwaiter<OBMECOIMEFL.ICEBLFILIGL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x89278D0", Offset = "0x89266D0", VA = "0x1889278D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x8928590", Offset = "0x8927390", VA = "0x188928590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class BIHDPBGAACE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public HNAAGPPFDEA.ENHGMKIIJDN reason;

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public BIHDPBGAACE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x89101B0", Offset = "0x890EFB0", VA = "0x1889101B0")]
			internal object IKAPNMEMCJG((HNAAGPPFDEA.Reason fallbackReason, AOJDMMEOILE roomDto, FLJJFALOMJJ state, string subReason) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class EKNADFFPHCK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public OBMECOIMEFL fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public EKNADFFPHCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x891C650", Offset = "0x891B450", VA = "0x18891C650")]
			internal object FPMFMABEGDL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Task JNOGJECEFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CancellationTokenSource EFFDKFEIDNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public FLJJFALOMJJ JGFMELOKCPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public LGPCFOHIOOE JBNGHMBPLHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AOJDMMEOILE KHPEJJKCMGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public PLJJBKEIPKH HOAMOKDGHIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public OBMECOIMEFL[] OLAMPKCDKPN;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool ABLLAPEADEI
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x891C9C0", Offset = "0x891B7C0", VA = "0x18891C9C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool ABPKMLCJMKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x891C9A0", Offset = "0x891B7A0", VA = "0x18891C9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x892B6A0", Offset = "0x892A4A0", VA = "0x18892B6A0")]
		public MIEEHFDDDGD(LGPCFOHIOOE JBNGHMBPLHF, AOJDMMEOILE KHPEJJKCMGG, PLJJBKEIPKH HOAMOKDGHIC, OBMECOIMEFL[] OLAMPKCDKPN, CancellationToken HIMDFBHMPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8929DE0", Offset = "0x8928BE0", VA = "0x188929DE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x892AAF0", Offset = "0x89298F0", VA = "0x18892AAF0")]
		public void KPNPOKLKDII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x892A030", Offset = "0x8928E30", VA = "0x18892A030")]
		public void GDMAMIJCBBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8929B10", Offset = "0x8928910", VA = "0x188929B10")]
		public void CLAKODPMOFI(HNAAGPPFDEA.Reason FMDFIDPIMDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x892AB60", Offset = "0x8929960", VA = "0x18892AB60")]
		[AsyncStateMachine(typeof(NOCACBAKBMP))]
		public Task LLIGJMIOLBA(HNAAGPPFDEA.ENHGMKIIJDN EGLDLGDMAJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x892A570", Offset = "0x8929370", VA = "0x18892A570")]
		[AsyncStateMachine(typeof(LELCKLGPDEA))]
		private Task<OBMECOIMEFL.ICEBLFILIGL> HNMNLIBHCDC(HNAAGPPFDEA.ENHGMKIIJDN EGLDLGDMAJN, OBMECOIMEFL HNBENLNKIOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x892AE40", Offset = "0x8929C40", VA = "0x18892AE40")]
		private void OFDCHJPIKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8929F80", Offset = "0x8928D80", VA = "0x188929F80")]
		public bool EJLLIDAGMNC(HNAAGPPFDEA.Reason NLDIKNGJIIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x892B070", Offset = "0x8929E70", VA = "0x18892B070")]
		private void PNOLHFPNMAG(FLJJFALOMJJ EOMNODKHFBK, HNAAGPPFDEA.ENHGMKIIJDN EGLDLGDMAJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x892AC70", Offset = "0x8929A70", VA = "0x18892AC70")]
		private void NCIJLJBGKCA(FLJJFALOMJJ EOMNODKHFBK, OBMECOIMEFL.ICEBLFILIGL OHLBIIOAJDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x892A830", Offset = "0x8929630", VA = "0x18892A830")]
		private void IOLNBMADJOD(FLJJFALOMJJ EOMNODKHFBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x892A1A0", Offset = "0x8928FA0", VA = "0x18892A1A0")]
		private void HCGLMELPBGP(FLJJFALOMJJ EOMNODKHFBK, OBMECOIMEFL.ICEBLFILIGL OHLBIIOAJDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x892A6C0", Offset = "0x89294C0", VA = "0x18892A6C0")]
		private void HPOEMCEFHPF(FLJJFALOMJJ EOMNODKHFBK, Exception KHPHCONHPBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x892AF60", Offset = "0x8929D60", VA = "0x18892AF60")]
		private void OGMCICACMIL(OBMECOIMEFL HNBENLNKIOG, HNAAGPPFDEA.ENHGMKIIJDN EGLDLGDMAJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x892A9E0", Offset = "0x89297E0", VA = "0x18892A9E0")]
		private void JCOPLHFJAID(OBMECOIMEFL HNBENLNKIOG, HNAAGPPFDEA.Reason EGLDLGDMAJN, string HOABJJDFHAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x892B310", Offset = "0x892A110", VA = "0x18892B310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class FLJJFALOMJJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public Task<OBMECOIMEFL.ICEBLFILIGL> JNOGJECEFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public CancellationTokenSource EFFDKFEIDNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public OBMECOIMEFL HNBENLNKIOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public HNAAGPPFDEA.Reason FMDFIDPIMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public HashSet<HNAAGPPFDEA.Reason> LINHJBCCENH;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool ABLLAPEADEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x891C9C0", Offset = "0x891B7C0", VA = "0x18891C9C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool ABPKMLCJMKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x891C9A0", Offset = "0x891B7A0", VA = "0x18891C9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x891C9E0", Offset = "0x891B7E0", VA = "0x18891C9E0")]
		public void PAEHAFKCBBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x891C980", Offset = "0x891B780", VA = "0x18891C980", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x891CB50", Offset = "0x891B950", VA = "0x18891CB50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x891CEC0", Offset = "0x891BCC0", VA = "0x18891CEC0")]
		public FLJJFALOMJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class OBHFCEPPGON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public HNAAGPPFDEA.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public OBHFCEPPGON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x892E080", Offset = "0x892CE80", VA = "0x18892E080")]
		internal object FNGPIPNOMFK(FLJJFALOMJJ x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x892E0F0", Offset = "0x892CEF0", VA = "0x18892E0F0")]
		internal object MAHNHEJMDFJ(MIEEHFDDDGD x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x892E010", Offset = "0x892CE10", VA = "0x18892E010")]
		internal object BLPOHFDPDCC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct MCKLBOIJHPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public HNAAGPPFDEA.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public COHBEHLPPLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private OBHFCEPPGON <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public Exception exception;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8928FD0", Offset = "0x8927DD0", VA = "0x188928FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8929AB0", Offset = "0x89288B0", VA = "0x188929AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct MNFDCIICIFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public COHBEHLPPLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public HNAAGPPFDEA.ENHGMKIIJDN reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private MIEEHFDDDGD <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x892BD40", Offset = "0x892AB40", VA = "0x18892BD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x892CA00", Offset = "0x892B800", VA = "0x18892CA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct GEDPIJBJPIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public COHBEHLPPLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x891CF50", Offset = "0x891BD50", VA = "0x18891CF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x891D4F0", Offset = "0x891C2F0", VA = "0x18891D4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	internal static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	internal static readonly PHLHEDGDBJO FMMNCLJIIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IAMHPLKENKJ BFNHJCAHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private LGPCFOHIOOE JBNGHMBPLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private MIEEHFDDDGD BMBILNFEDFJ;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private KGJIHOMIGPB MFMKIIGCFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8913960", Offset = "0x8912760", VA = "0x188913960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool ONFGOMOPJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x262CF00", Offset = "0x262BD00", VA = "0x18262CF00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool IKMDHMNHOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x89143E0", Offset = "0x89131E0", VA = "0x1889143E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x89139B0", Offset = "0x89127B0", VA = "0x1889139B0", Slot = "6")]
	public void DGPDNICIDDD(IAMHPLKENKJ BFNHJCAHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8913A30", Offset = "0x8912830", VA = "0x188913A30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8914710", Offset = "0x8913510", VA = "0x188914710", Slot = "9")]
	public void PAEHAFKCBBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8913D40", Offset = "0x8912B40", VA = "0x188913D40")]
	private bool FNCNCOCGBHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8914450", Offset = "0x8913250", VA = "0x188914450", Slot = "5")]
	private void JFDFKHDLINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x89145F0", Offset = "0x89133F0", VA = "0x1889145F0", Slot = "8")]
	[AsyncStateMachine(typeof(MCKLBOIJHPB))]
	public Task OIKHOMMMNEK(HNAAGPPFDEA.Reason EGLDLGDMAJN, [Optional] Exception HIKJGCCPIBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x8913A40", Offset = "0x8912840", VA = "0x188913A40")]
	private bool EHEOEJDLHOP(HNAAGPPFDEA.ENHGMKIIJDN EGLDLGDMAJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8913E20", Offset = "0x8912C20", VA = "0x188913E20")]
	private OBMECOIMEFL[] GJNLNOHLIPE(PLJJBKEIPKH IKKDCPJFEKI, AOJDMMEOILE MGOEHNKIHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x89142C0", Offset = "0x89130C0", VA = "0x1889142C0")]
	[AsyncStateMachine(typeof(MNFDCIICIFI))]
	private Task HJBNBJDBEFI(HNAAGPPFDEA.ENHGMKIIJDN EGLDLGDMAJN, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8914520", Offset = "0x8913320", VA = "0x188914520")]
	[AsyncStateMachine(typeof(GEDPIJBJPIJ))]
	private Task LNHKLCGGACK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public COHBEHLPPLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class IOPEFDKJACL : IMBMOMBAKHG, LFDFDKOBAHG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct OKJFAKHIBDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public PLJJBKEIPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public IOPEFDKJACL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public JPJHIFKDPIB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x892E160", Offset = "0x892CF60", VA = "0x18892E160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x892EAD0", Offset = "0x892D8D0", VA = "0x18892EAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct CKKJLPHNLLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public IOPEFDKJACL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public PLJJBKEIPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public JPJHIFKDPIB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private EHDFINDMEJI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private HICKLFFFPPA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private JHDPICMPNBI <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private CALGOMMCKGL <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8912420", Offset = "0x8911220", VA = "0x188912420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8913570", Offset = "0x8912370", VA = "0x188913570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class DDLKPAAKKOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Matchmaking.FOBJNAIFBPM result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public NIPINPIGFJL errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public DDLKPAAKKOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8915130", Offset = "0x8913F30", VA = "0x188915130")]
		internal object PFMIGABLANF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class JCJLNEINAHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public Task<NLIPGAAAAGA> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public JCJLNEINAHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		internal Task<NLIPGAAAAGA> ICJKCKCDLAN(EHDFINDMEJI<string>.NGEIFBMECIG _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct DKBJPCCDEAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public IOPEFDKJACL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public PLJJBKEIPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public EHDFINDMEJI<string>.NGEIFBMECIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public JPJHIFKDPIB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public JHDPICMPNBI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private JCJLNEINAHB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private AOCMPNLIOFK <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private HICKLFFFPPA <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private HBGMKMHNODB <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private Task<Matchmaking.NMGGLFNPNKG> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private GJGPNMLGMLG <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter<Matchmaking.NMGGLFNPNKG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private TaskAwaiter<NLIPGAAAAGA> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8916960", Offset = "0x8915760", VA = "0x188916960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x891C2C0", Offset = "0x891B0C0", VA = "0x18891C2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class JBFGEMBIDFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Task<NLIPGAAAAGA> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public JBFGEMBIDFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		internal Task<NLIPGAAAAGA> EFFBCMMPJBG(EHDFINDMEJI<string>.NGEIFBMECIG _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct ILKLCKELGCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public IOPEFDKJACL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public PLJJBKEIPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public EHDFINDMEJI<string>.NGEIFBMECIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public JPJHIFKDPIB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public JHDPICMPNBI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private AOCMPNLIOFK <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private HICKLFFFPPA <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private HBGMKMHNODB <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private Task<Matchmaking.NMGGLFNPNKG> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private NLIPGAAAAGA <initialRoomLoadPayload>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private ELFNFNHPMNK <preloadContext>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter<NLIPGAAAAGA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private GJGPNMLGMLG <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private Task <loadEmptySceneTask>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private CFEFPICLLAN <sceneManagementService>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private OLHIPLPGMDP <scenePreloadRequest>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private CancellationTokenSource <cameraFadeCts>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private TaskAwaiter<KFCNEKKBOAD> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private int <i>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private YieldAwaitable.YieldAwaiter <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter<Matchmaking.NMGGLFNPNKG> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private CancellationToken <photonJoinedToken>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x893CE10", Offset = "0x893BC10", VA = "0x18893CE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8942490", Offset = "0x8941290", VA = "0x188942490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct NJALOECFJHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public IOPEFDKJACL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public EHDFINDMEJI<string>.NGEIFBMECIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x894AAB0", Offset = "0x89498B0", VA = "0x18894AAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x894B520", Offset = "0x894A320", VA = "0x18894B520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct IOKPOOFOJOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public IOPEFDKJACL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private LOAHJOOKLEP <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8942B90", Offset = "0x8941990", VA = "0x188942B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x8943020", Offset = "0x8941E20", VA = "0x188943020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct JNHHLOGABFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public AsyncTaskMethodBuilder<Matchmaking.NMGGLFNPNKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public PLJJBKEIPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public EHDFINDMEJI<string>.NGEIFBMECIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public IOPEFDKJACL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter<Matchmaking.NMGGLFNPNKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8944BA0", Offset = "0x89439A0", VA = "0x188944BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8945080", Offset = "0x8943E80", VA = "0x188945080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct IOGCHOMFAMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public EHDFINDMEJI<string>.NGEIFBMECIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public Matchmaking.NMGGLFNPNKG serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public IOPEFDKJACL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public JHDPICMPNBI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private TaskAwaiter<NDHHCEKFPGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x89424F0", Offset = "0x89412F0", VA = "0x1889424F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8942B30", Offset = "0x8941930", VA = "0x188942B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class GIOBFKBHDFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public PLJJBKEIPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public GIOBFKBHDFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x893AB60", Offset = "0x8939960", VA = "0x18893AB60")]
		internal object NJGJCAPIMPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x893AA60", Offset = "0x8939860", VA = "0x18893AA60")]
		internal string AGGOCNOBOBF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct DIHCMNACPAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public PLJJBKEIPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public IOPEFDKJACL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private GIOBFKBHDFB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8937BC0", Offset = "0x89369C0", VA = "0x188937BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8938760", Offset = "0x8937560", VA = "0x188938760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct CJHCNNGKBBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public EHDFINDMEJI<string>.NGEIFBMECIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public IOPEFDKJACL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public JHDPICMPNBI joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public NLIPGAAAAGA initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public PLJJBKEIPKH targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public ELFNFNHPMNK preloadContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public AOCMPNLIOFK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8934EB0", Offset = "0x8933CB0", VA = "0x188934EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x89356A0", Offset = "0x89344A0", VA = "0x1889356A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct BFFCKNEAGOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public EHDFINDMEJI<string>.NGEIFBMECIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public IOPEFDKJACL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private HICKLFFFPPA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private HICKLFFFPPA <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8931750", Offset = "0x8930550", VA = "0x188931750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8932F30", Offset = "0x8931D30", VA = "0x188932F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct PKLNKJOMIGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public KIBEKEOAJNC localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public IOPEFDKJACL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private TaskAwaiter<PPJMMNMCCIA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x894E2B0", Offset = "0x894D0B0", VA = "0x18894E2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x894EAB0", Offset = "0x894D8B0", VA = "0x18894EAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class LCLIFEMMBDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public PLJJBKEIPKH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public LCLIFEMMBDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8945900", Offset = "0x8944700", VA = "0x188945900")]
		internal object JFKEOHONBGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class BJHOIDLJKLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public BJHOIDLJKLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8934610", Offset = "0x8933410", VA = "0x188934610")]
		internal void EDDPGAOBIJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class DBBDPJCMINP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public PLJJBKEIPKH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public DBBDPJCMINP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8936AB0", Offset = "0x89358B0", VA = "0x188936AB0")]
		internal object AHLAOHDFBDP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class LLKNGNBLPNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public PLJJBKEIPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public LLKNGNBLPNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8948430", Offset = "0x8947230", VA = "0x188948430")]
		internal string MGPDNIOEFCA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly PHLHEDGDBJO GJPCNGGCBBO;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly PHLHEDGDBJO PANIAKMELLN;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly PHLHEDGDBJO ADINIBPBKNI;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static readonly string ABPHFGHAAPP;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private static readonly string ENEAJPINDDI;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private static readonly string NGCFBGNMKOK;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly Guid GLKFFNCHKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private PPEDIAHNHEB MCJJCFBAPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private FKAEINJLMOK CMABOKIFKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private GLOINHDCCCK LEFGLILMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private IAMHPLKENKJ BFNHJCAHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private LGPCFOHIOOE JBNGHMBPLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private FCLCFKPAGOL CGJHAKOJMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private GCJLOJAJIIE IMIPADJGEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private OJALOMIDNOE HIEOEHIBOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private EJGFFGADOMD ACCELNCAJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private KGBPGLLJLNA LEADOGOPBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private IDisposable HNPLBLKPINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private OOINCOPNPCH PNLFBNPOBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly NLHHJHMMPAF IKACLHGGAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private GJGPNMLGMLG HEEGOCELPCC;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus BLIGHNGOINM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xA7FE00", Offset = "0xA7EC00", VA = "0x180A7FE00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x150D960", Offset = "0x150C760", VA = "0x18150D960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private KGJIHOMIGPB MFMKIIGCFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x89222A0", Offset = "0x89210A0", VA = "0x1889222A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x89224E0", Offset = "0x89212E0", VA = "0x1889224E0", Slot = "6")]
	public void DGPDNICIDDD(IAMHPLKENKJ BFNHJCAHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8922800", Offset = "0x8921600", VA = "0x188922800", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8921F50", Offset = "0x8920D50", VA = "0x188921F50", Slot = "5")]
	[AsyncStateMachine(typeof(OKJFAKHIBDA))]
	public Task BJDFJHFOODK(PLJJBKEIPKH ICBDNDPBBBE, JPJHIFKDPIB GOOANGGIPNB, CancellationToken FOJIDEIIGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8922EF0", Offset = "0x8921CF0", VA = "0x188922EF0")]
	[AsyncStateMachine(typeof(CKKJLPHNLLJ))]
	private Task HIGOOCIKGFO(PLJJBKEIPKH ICBDNDPBBBE, JPJHIFKDPIB GOOANGGIPNB, CancellationToken FOJIDEIIGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8923E00", Offset = "0x8922C00", VA = "0x188923E00")]
	private void KMGCLOGHFLK(EJGFFGADOMD ACCELNCAJNL, PLJJBKEIPKH ICBDNDPBBBE, Exception KHPHCONHPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x89231A0", Offset = "0x8921FA0", VA = "0x1889231A0")]
	private static void JCEJAFFJACF(CALGOMMCKGL LEPBHOFGBNK, Exception KHPHCONHPBN, [Optional] List<int> OGNIPOMNEFF, int JAPPLAIIFBN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8923040", Offset = "0x8921E40", VA = "0x188923040")]
	[AsyncStateMachine(typeof(DKBJPCCDEAH))]
	private Task JBLCAPBCCHG(EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, PLJJBKEIPKH ICBDNDPBBBE, JPJHIFKDPIB GOOANGGIPNB, JHDPICMPNBI LMHAGOFAEJN, CancellationToken FOJIDEIIGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8921DF0", Offset = "0x8920BF0", VA = "0x188921DF0")]
	[AsyncStateMachine(typeof(ILKLCKELGCA))]
	private Task BCLIPNIAMBD(EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, PLJJBKEIPKH ICBDNDPBBBE, JPJHIFKDPIB GOOANGGIPNB, JHDPICMPNBI LMHAGOFAEJN, CancellationToken FOJIDEIIGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x8923AC0", Offset = "0x89228C0", VA = "0x188923AC0")]
	private void KECBCBPIFPE([CallerMemberName] string DHAGGMOAHBK = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8925000", Offset = "0x8923E00", VA = "0x188925000")]
	[AsyncStateMachine(typeof(NJALOECFJHP))]
	private Task OBNBDHELEMA(EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8924960", Offset = "0x8923760", VA = "0x188924960")]
	private void MDIIICLMHEO(PLJJBKEIPKH ICBDNDPBBBE, CancellationToken FOJIDEIIGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8922C90", Offset = "0x8921A90", VA = "0x188922C90")]
	private void GOJAJBFHFHG(PLJJBKEIPKH ICBDNDPBBBE, TaskStatus OLJEMIPCECB, string IIHOFBLPONF, JHDPICMPNBI LMHAGOFAEJN, Exception HIKJGCCPIBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8922B80", Offset = "0x8921980", VA = "0x188922B80")]
	private void FJDEADDNPPL(PLJJBKEIPKH ICBDNDPBBBE, JHDPICMPNBI LMHAGOFAEJN, OperationCanceledException MHALHJCNOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8922400", Offset = "0x8921200", VA = "0x188922400")]
	private void CLJLGHIHDPD(PLJJBKEIPKH ICBDNDPBBBE, JHDPICMPNBI LMHAGOFAEJN, Exception KHPHCONHPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8924C90", Offset = "0x8923A90", VA = "0x188924C90")]
	private void MDNKJKJGHCD(PLJJBKEIPKH ICBDNDPBBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x89229D0", Offset = "0x89217D0", VA = "0x1889229D0")]
	private static GOPOOGGIALC EIPIDHCKBJB(PLJJBKEIPKH ICBDNDPBBBE)
	{
		return default(GOPOOGGIALC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8922090", Offset = "0x8920E90", VA = "0x188922090")]
	[AsyncStateMachine(typeof(IOKPOOFOJOM))]
	private Task CEMFBGKPGIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8924EA0", Offset = "0x8923CA0", VA = "0x188924EA0")]
	[AsyncStateMachine(typeof(JNHHLOGABFJ))]
	private Task<Matchmaking.NMGGLFNPNKG> NPMDPKAGDIA(PLJJBKEIPKH ICBDNDPBBBE, EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x89222F0", Offset = "0x89210F0", VA = "0x1889222F0")]
	private static NDHHCEKFPGA CGNNOCLIDCC(Matchmaking.NMGGLFNPNKG FMMOODEGBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x8922A30", Offset = "0x8921830", VA = "0x188922A30")]
	[AsyncStateMachine(typeof(IOGCHOMFAMO))]
	private Task EOPEMGNLHDM(Matchmaking.NMGGLFNPNKG FMMOODEGBLD, JHDPICMPNBI LMHAGOFAEJN, EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, CancellationToken MBEDCBFGOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x8921BA0", Offset = "0x89209A0", VA = "0x188921BA0")]
	[AsyncStateMachine(typeof(DIHCMNACPAG))]
	private Task ADGOKHFLCIF(PLJJBKEIPKH ICBDNDPBBBE, CancellationTokenSource IDEIADFAFEL, Task CEODABPIKMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8922850", Offset = "0x8921650", VA = "0x188922850")]
	[AsyncStateMachine(typeof(CJHCNNGKBBA))]
	private Task EDINHHDENMM(NLIPGAAAAGA LIDKENLOPCE, AOCMPNLIOFK KMFPAFFBLBH, PLJJBKEIPKH HJFCGLHAHPH, JHDPICMPNBI OIEHOHJIKAP, EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, CancellationToken LJCFODMFEGG, [Optional] ELFNFNHPMNK DIKKAKOJDJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8925190", Offset = "0x8923F90", VA = "0x188925190")]
	private JHDPICMPNBI OLBMGIMFGHF(JHDPICMPNBI OIEHOHJIKAP, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8922160", Offset = "0x8920F60", VA = "0x188922160")]
	[AsyncStateMachine(typeof(BFFCKNEAGOL))]
	private Task CFEGPPJLNJB(EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8923CD0", Offset = "0x8922AD0", VA = "0x188923CD0")]
	[AsyncStateMachine(typeof(PKLNKJOMIGA))]
	private Task KMENDHDMFHC(CancellationToken HIMDFBHMPLL, int CEEFGLDKHNK, KIBEKEOAJNC GNLPCANCLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x89247E0", Offset = "0x89235E0", VA = "0x1889247E0")]
	private static void MAPPEILABOK(PLJJBKEIPKH ICBDNDPBBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x89245B0", Offset = "0x89233B0", VA = "0x1889245B0")]
	private void LDKLEIDBOLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8923C40", Offset = "0x8922A40", VA = "0x188923C40")]
	private void KEGDDBENFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8922C00", Offset = "0x8921A00", VA = "0x188922C00")]
	private void FJJFJDNMLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8924520", Offset = "0x8923320", VA = "0x188924520")]
	private void KOKHBJKMFMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x89239D0", Offset = "0x89227D0", VA = "0x1889239D0")]
	private static void JCLOANCHHMI(PLJJBKEIPKH ICBDNDPBBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x8921CE0", Offset = "0x8920AE0", VA = "0x188921CE0")]
	private static CancellationTokenRegistration BBFHOKEECHN(PLJJBKEIPKH ICBDNDPBBBE, CancellationToken MBEDCBFGOJP)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x8924420", Offset = "0x8923220", VA = "0x188924420")]
	private static void KOIELPMENDK(PLJJBKEIPKH ICBDNDPBBBE, Exception KHPHCONHPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x8924270", Offset = "0x8923070", VA = "0x188924270")]
	private void KNGAINNMINP(PLJJBKEIPKH ICBDNDPBBBE, Task CEODABPIKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8925130", Offset = "0x8923F30", VA = "0x188925130")]
	private static void OJKKHHLLEBA(Func<string> ADKIEKNHCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x89255A0", Offset = "0x89243A0", VA = "0x1889255A0")]
	public IOPEFDKJACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8922480", Offset = "0x8921280", VA = "0x188922480")]
	[CompilerGenerated]
	internal static (int, int?) CNEJOGCEBCM(NIPINPIGFJL PKDKDIFALGO)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[RecRoom.NoEngine.Common.Preserve]
internal class NABIEFBEHEC : EGGAILHONLB, LFDFDKOBAHG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct JGEGIOGGIHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public NABIEFBEHEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public KIBEKEOAJNC localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x89445B0", Offset = "0x89433B0", VA = "0x1889445B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x8944A90", Offset = "0x8943890", VA = "0x188944A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class KIAMPHCCKBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public NABIEFBEHEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public KIBEKEOAJNC localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KIAMPHCCKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8945760", Offset = "0x8944560", VA = "0x188945760")]
		internal List<Task> OMHOMLMJGDO(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct IEGIAIFICPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public FKAPHGDHFGG taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public KIBEKEOAJNC localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x893BDF0", Offset = "0x893ABF0", VA = "0x18893BDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x893C190", Offset = "0x893AF90", VA = "0x18893C190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct PNJMGGKOBNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public NABIEFBEHEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x894EC10", Offset = "0x894DA10", VA = "0x18894EC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x894EEF0", Offset = "0x894DCF0", VA = "0x18894EEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private readonly HashSet<FKAPHGDHFGG> BGHAGOIODFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private FKAEINJLMOK CMABOKIFKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private IAMHPLKENKJ BFNHJCAHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private JKDIEKHIAPL PEMOKCECBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private CENECABELJM BKBBBJGJJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private IDisposable HNPLBLKPINK;

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8949890", Offset = "0x8948690", VA = "0x188949890", Slot = "5")]
	public void DGPDNICIDDD(IAMHPLKENKJ BFNHJCAHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8949B70", Offset = "0x8948970", VA = "0x188949B70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x894A4D0", Offset = "0x89492D0", VA = "0x18894A4D0", Slot = "4")]
	public bool KOOECEAPGJM(FKAPHGDHFGG JCLBPCJGNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x894A600", Offset = "0x8949400", VA = "0x18894A600")]
	private void NEPLMDPGLHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8949CF0", Offset = "0x8948AF0", VA = "0x188949CF0")]
	private void ELEDNJCGCBB(EIPHABKKBFG JBNEABKLADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x8949F10", Offset = "0x8948D10", VA = "0x188949F10")]
	[AsyncStateMachine(typeof(JGEGIOGGIHD))]
	private Task HNAGNLFLKJI(int CEEFGLDKHNK, KIBEKEOAJNC GNLPCANCLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x894A530", Offset = "0x8949330", VA = "0x18894A530")]
	private Func<CancellationToken, List<Task>> KPJKOAGMPMD(int CEEFGLDKHNK, KIBEKEOAJNC GNLPCANCLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x894A000", Offset = "0x8948E00", VA = "0x18894A000")]
	private List<Task> JLHALDKLLDF(int CEEFGLDKHNK, KIBEKEOAJNC GNLPCANCLKL, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x8949BD0", Offset = "0x89489D0", VA = "0x188949BD0")]
	[AsyncStateMachine(typeof(IEGIAIFICPI))]
	private Task EEFEIGMIEFC(FKAPHGDHFGG MHGAFFIJAJC, CancellationToken OCGDLEBGIMO, int CEEFGLDKHNK, KIBEKEOAJNC GNLPCANCLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x894A6D0", Offset = "0x89494D0", VA = "0x18894A6D0")]
	[AsyncStateMachine(typeof(PNJMGGKOBNP))]
	private Task NMGBEPELMHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x894A7A0", Offset = "0x89495A0", VA = "0x18894A7A0")]
	private void PAEHAFKCBBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x894A820", Offset = "0x8949620", VA = "0x18894A820")]
	public NABIEFBEHEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[UnityEngine.Scripting.Preserve]
internal sealed class IONPEONLNPL : DGJPJGNBJOF, LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class GDBMNAJDCLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public GDBMNAJDCLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x893A9A0", Offset = "0x89397A0", VA = "0x18893A9A0")]
		internal object OKCLEGLDHPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class LDOAJFFNLIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public LDOAJFFNLIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8945DD0", Offset = "0x8944BD0", VA = "0x188945DD0")]
		internal object JJIDLFCKGDN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class MJBFIGMMHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public MJBFIGMMHMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class GGGPCFLDPJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public GGGPCFLDPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x893AA00", Offset = "0x8939800", VA = "0x18893AA00")]
		internal object GGAJFKBFNHC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class DCCDFCDHECL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public DCCDFCDHECL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8936B30", Offset = "0x8935930", VA = "0x188936B30")]
		internal object AEKBCNJCGMI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private readonly Dictionary<Guid, JIKMAKKMEFO> MAIKMKJCLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private readonly TimeSpan HINKHIJMGBL;

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "9")]
	public void DGPDNICIDDD(IAMHPLKENKJ BFNHJCAHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x89430F0", Offset = "0x8941EF0", VA = "0x1889430F0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x8943720", Offset = "0x8942520", VA = "0x188943720", Slot = "4")]
	public LBEPELJJLIC OLHPIGGMIDE(Guid ALEMANCBDEO)
	{
		return default(LBEPELJJLIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x8943100", Offset = "0x8941F00", VA = "0x188943100", Slot = "5")]
	public bool EBNLHEFHMEO(Guid ALEMANCBDEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x8943940", Offset = "0x8942740", VA = "0x188943940", Slot = "6")]
	public bool PKNMEAHOGBO(Guid ALEMANCBDEO, Task MICEHCPDAIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x8943310", Offset = "0x8942110", VA = "0x188943310", Slot = "7")]
	public bool EHBNLEMMIFL(Guid ALEMANCBDEO, PPJMMNMCCIA NLJIGEDEIGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x8943080", Offset = "0x8941E80", VA = "0x188943080", Slot = "8")]
	public Task<(PPJMMNMCCIA, Task)> DFMILGNFCNB(Guid ALEMANCBDEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x89434F0", Offset = "0x89422F0", VA = "0x1889434F0")]
	private void GBMGOFAEJPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x8943C70", Offset = "0x8942A70", VA = "0x188943C70")]
	public IONPEONLNPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[RecRoom.NoEngine.Common.Preserve]
internal class PHHEOKLJNNO : LIENCJLLPEG, LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class LLCFLONFEDK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private readonly PLJJBKEIPKH OKIBNOEBHMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private readonly CancellationTokenSource JJKKCMEFGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public readonly CancellationToken CJNIBOMEOPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private bool CIOPHNGBNMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private bool FOABPIBDEDN;

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8948380", Offset = "0x8947180", VA = "0x188948380")]
		public LLCFLONFEDK(PLJJBKEIPKH OKIBNOEBHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8948230", Offset = "0x8947030", VA = "0x188948230")]
		public void PAEHAFKCBBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8948200", Offset = "0x8947000", VA = "0x188948200", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class POCNLLJNDJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public CMNFMNABDHH disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public POCNLLJNDJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x894EF50", Offset = "0x894DD50", VA = "0x18894EF50")]
		internal object FJPKHFJNFGK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private struct LEMFMOLAMAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CMNFMNABDHH disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public PHHEOKLJNNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8945E30", Offset = "0x8944C30", VA = "0x188945E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8946290", Offset = "0x8945090", VA = "0x188946290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class OEPDLPILFMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public PHHEOKLJNNO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public OEPDLPILFMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x894B580", Offset = "0x894A380", VA = "0x18894B580")]
		internal object ECLCEIDDNHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class ENNADOKJABK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public PLJJBKEIPKH newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public OEPDLPILFMA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public ENNADOKJABK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8939C20", Offset = "0x8938A20", VA = "0x188939C20")]
		internal object GJFILLLBPCA((PLJJBKEIPKH lastLocalPlayerRoomInstance, PLJJBKEIPKH newRoomInstance, FCLCFKPAGOL fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct PJDLIGKMAME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public PHHEOKLJNNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private HICKLFFFPPA <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x894CAF0", Offset = "0x894B8F0", VA = "0x18894CAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xAAD270", Offset = "0xAAC070", VA = "0x180AAD270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class NCNCOJOMDBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public PLJJBKEIPKH newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public NCNCOJOMDBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x894A970", Offset = "0x8949770", VA = "0x18894A970")]
		internal object GNPLFIEMNGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x894A8F0", Offset = "0x89496F0", VA = "0x18894A8F0")]
		internal void EOPDJAFEENA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x894A8B0", Offset = "0x89496B0", VA = "0x18894A8B0")]
		internal object APLKEEAECEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x894AA10", Offset = "0x8949810", VA = "0x18894AA10")]
		internal object JBAPELLMFGF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct DCDFPKHIJNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public PLJJBKEIPKH newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public PHHEOKLJNNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public JPJHIFKDPIB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private NCNCOJOMDBM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x8936B90", Offset = "0x8935990", VA = "0x188936B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x8937B60", Offset = "0x8936960", VA = "0x188937B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static readonly EGGDKDNDJFK.LGCGMGIEMDK EADPDCEOLHC;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static readonly LJBOOAFCILM DNDMODNACIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private FKAEINJLMOK CMABOKIFKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private IAMHPLKENKJ BFNHJCAHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private FCLCFKPAGOL CGJHAKOJMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private LGPCFOHIOOE JBNGHMBPLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private EGACAKPHMKL FNFCFIGCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private IMBMOMBAKHG GMFEHAACDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private PLJJBKEIPKH EINJJAAIIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private LLCFLONFEDK EABONJDNFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool KLNFMGEOFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private Task LILAIIGLFIO;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private KGJIHOMIGPB MFMKIIGCFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x894B7D0", Offset = "0x894A5D0", VA = "0x18894B7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool IIACJKICDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xACBBC0", Offset = "0xACA9C0", VA = "0x180ACBBC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x894BFA0", Offset = "0x894ADA0", VA = "0x18894BFA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x894B9B0", Offset = "0x894A7B0", VA = "0x18894B9B0", Slot = "4")]
	public void DGPDNICIDDD(IAMHPLKENKJ BFNHJCAHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x894BC50", Offset = "0x894AA50", VA = "0x18894BC50", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x894C0E0", Offset = "0x894AEE0", VA = "0x18894C0E0")]
	[AsyncStateMachine(typeof(LEMFMOLAMAL))]
	private Task IMGOAHMLKLE(CMNFMNABDHH GDEDOAKBAOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x894BE10", Offset = "0x894AC10", VA = "0x18894BE10")]
	private void EDLPAIACNDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x894B820", Offset = "0x894A620", VA = "0x18894B820")]
	private void CPPNJJICCPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x894B650", Offset = "0x894A450", VA = "0x18894B650")]
	private void ABFDPGCBEJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x894C3A0", Offset = "0x894B1A0", VA = "0x18894C3A0")]
	private bool PEMIBEHGHEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x894C1D0", Offset = "0x894AFD0", VA = "0x18894C1D0")]
	[AsyncStateMachine(typeof(PJDLIGKMAME))]
	private void IPHPDCMAGLB(int DGOGGKOBPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x894C420", Offset = "0x894B220", VA = "0x18894C420")]
	private void PNFHHEGNDMN([Out] IDisposable DPPFAOGMGBN, [Out] IDisposable NDPOHCPIMJG, [Out] IDisposable FNBCGHGMBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x894C2A0", Offset = "0x894B0A0", VA = "0x18894C2A0")]
	private bool KBMPNIMPKKJ(PLJJBKEIPKH OKIBNOEBHMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x894BDC0", Offset = "0x894ABC0", VA = "0x18894BDC0")]
	private void ECDPNOCDIED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x894BFB0", Offset = "0x894ADB0", VA = "0x18894BFB0")]
	[AsyncStateMachine(typeof(DCDFPKHIJNC))]
	private Task HIGOOCIKGFO(PLJJBKEIPKH OKIBNOEBHMI, JPJHIFKDPIB GOOANGGIPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x894CA80", Offset = "0x894B880", VA = "0x18894CA80")]
	public PHHEOKLJNNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[UnityEngine.Scripting.Preserve]
internal sealed class COBMFPHLLLF : AOPFJIOOICJ, LFDFDKOBAHG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct LDGFOMFDBEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public AsyncTaskMethodBuilder<CHJGFILBKKF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public COBMFPHLLLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private TaskAwaiter<CHJGFILBKKF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x8945AD0", Offset = "0x89448D0", VA = "0x188945AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x8945D60", Offset = "0x8944B60", VA = "0x188945D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class DKAHNKPACLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public FGGKMIFBJPI message;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public DKAHNKPACLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x89387C0", Offset = "0x89375C0", VA = "0x1889387C0")]
		internal object POGIICOBOOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class BBGKINJHBFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public FGGKMIFBJPI messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public BBGKINJHBFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x89316F0", Offset = "0x89304F0", VA = "0x1889316F0")]
		internal object EEJDOBOKNKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class HFOEDHHCMOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public FGGKMIFBJPI request;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public HFOEDHHCMOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x893B160", Offset = "0x8939F60", VA = "0x18893B160")]
		internal object KLMKJJDGHOD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct LNBDJJPOLNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public FGGKMIFBJPI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public COBMFPHLLLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private TaskAwaiter<NJDDNJPCANH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x8948530", Offset = "0x8947330", VA = "0x188948530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x8948E00", Offset = "0x8947C00", VA = "0x188948E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class NEADAOOPDFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public FGGKMIFBJPI operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public NEADAOOPDFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x894AA50", Offset = "0x8949850", VA = "0x18894AA50")]
		internal object PDLDIFJMMIB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct HPIKHHICOOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public FGGKMIFBJPI operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public COBMFPHLLLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private JHDPICMPNBI <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter<FGGKMIFBJPI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x893B1C0", Offset = "0x8939FC0", VA = "0x18893B1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x893BD30", Offset = "0x893AB30", VA = "0x18893BD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct ILCPOBONNPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<NJDDNJPCANH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public COBMFPHLLLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public FGGKMIFBJPI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private GLPNBFHMGDH.JLCFCKEKDHF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private JHDPICMPNBI <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private TaskAwaiter<FGGKMIFBJPI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x893C870", Offset = "0x893B670", VA = "0x18893C870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x893CDA0", Offset = "0x893BBA0", VA = "0x18893CDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class KJPEPHPLHEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public NJDDNJPCANH operation;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KJPEPHPLHEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x89457A0", Offset = "0x89445A0", VA = "0x1889457A0")]
		internal object OHGNHBBFAPH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct FJOHGBJFBLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public NJDDNJPCANH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public COBMFPHLLLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private EHDFINDMEJI<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8939D20", Offset = "0x8938B20", VA = "0x188939D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x893A360", Offset = "0x8939160", VA = "0x18893A360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class DLGNHANIGNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public FGGKMIFBJPI request;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public DLGNHANIGNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8938820", Offset = "0x8937620", VA = "0x188938820")]
		internal object PENCABECHLI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class ICFJANKJPKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public FGGKMIFBJPI request;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public ICFJANKJPKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x893BD90", Offset = "0x893AB90", VA = "0x18893BD90")]
		internal object OPCDMAAGBOG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private IAMHPLKENKJ BFNHJCAHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private GCJLOJAJIIE IMIPADJGEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private GNKBHGLOHGH APHCKCMMBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private FAJNPDJCFLB CEHHIHAKLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private GLOINHDCCCK LEFGLILMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private TaskCompletionSource<CHJGFILBKKF> GEFHHNLDCKC;

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x8935DF0", Offset = "0x8934BF0", VA = "0x188935DF0", Slot = "7")]
	public void DGPDNICIDDD(IAMHPLKENKJ BFNHJCAHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x89360F0", Offset = "0x8934EF0", VA = "0x1889360F0", Slot = "6")]
	[AsyncStateMachine(typeof(LDGFOMFDBEH))]
	public Task<CHJGFILBKKF> FAONBGEGMKA(CancellationToken LMMGIHPFHOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x8936320", Offset = "0x8935120", VA = "0x188936320", Slot = "4")]
	public void GPMCBNFPEGN(FGGKMIFBJPI IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x8935700", Offset = "0x8934500", VA = "0x188935700", Slot = "5")]
	public void CFNPKLBFILB(FGGKMIFBJPI HLBBHOHGDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x89367C0", Offset = "0x89355C0", VA = "0x1889367C0")]
	[AsyncStateMachine(typeof(LNBDJJPOLNI))]
	private Task KNCBKACGKBF(FGGKMIFBJPI OHNONCFAIKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x89366B0", Offset = "0x89354B0", VA = "0x1889366B0")]
	[AsyncStateMachine(typeof(HPIKHHICOOF))]
	private Task IHODIJAONIP(FGGKMIFBJPI GJKIIJPADEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x89368D0", Offset = "0x89356D0", VA = "0x1889368D0")]
	[AsyncStateMachine(typeof(ILCPOBONNPP))]
	private Task<NJDDNJPCANH> MIPNALIPMDH(FGGKMIFBJPI OHNONCFAIKH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x8936A20", Offset = "0x8935820", VA = "0x188936A20")]
	private JHDPICMPNBI OJFIEGNPKEE(FGGKMIFBJPI GHELEALCFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x8936200", Offset = "0x8935000", VA = "0x188936200")]
	[AsyncStateMachine(typeof(FJOHGBJFBLH))]
	private Task FFCGKFFIEOM(NJDDNJPCANH POKDMNFNEPP, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8935EE0", Offset = "0x8934CE0", VA = "0x188935EE0")]
	private NJDDNJPCANH EPKAMNGJOFM(FGGKMIFBJPI OHNONCFAIKH, JHDPICMPNBI BIILOFMIEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x39A2630", Offset = "0x39A1430", VA = "0x1839A2630")]
	private T BPPDEOPCMCL<T>(T BNECONOIKOE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x8935A60", Offset = "0x8934860", VA = "0x188935A60")]
	private NJDDNJPCANH DBNKECDMPCC(FGGKMIFBJPI OHNONCFAIKH, JHDPICMPNBI BIILOFMIEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public COBMFPHLLLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class LIJJLBMAIBK : GNKBHGLOHGH, LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class KNDDBDKNPJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KNDDBDKNPJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x8945820", Offset = "0x8944620", VA = "0x188945820")]
		internal object LDBDGMIBPPB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class NABGCIFJEPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public NABGCIFJEPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8949820", Offset = "0x8948620", VA = "0x188949820")]
		internal object ALBECFKGFHO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private GLOINHDCCCK LEFGLILMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private NOLLCEDHKEP GLKHKGCNMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private AOPFJIOOICJ IBAAGPGMDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private DGJPJGNBJOF MAIKMKJCLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private LAGJNAHAJLN JLHBJLOGOJD;

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x8947100", Offset = "0x8945F00", VA = "0x188947100", Slot = "6")]
	public void DGPDNICIDDD(IAMHPLKENKJ BFNHJCAHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x8947270", Offset = "0x8946070", VA = "0x188947270", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x8946510", Offset = "0x8945310", VA = "0x188946510", Slot = "4")]
	public LBEPELJJLIC BDIFFOEICMJ(FGGKMIFBJPI HKONIAJLDMB)
	{
		return default(LBEPELJJLIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x8947D40", Offset = "0x8946B40", VA = "0x188947D40", Slot = "5")]
	public void NIIGLCJDFFL(Guid ALEMANCBDEO, Task MICEHCPDAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x8947320", Offset = "0x8946120", VA = "0x188947320")]
	private void FHHIPIOOAJJ(BNHAMMLICHE BKMCGGEFFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x8946B60", Offset = "0x8945960", VA = "0x188946B60")]
	private void DAAKADCHAPP(EMOJBEBODMP IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x8947680", Offset = "0x8946480", VA = "0x188947680")]
	private void LIKDFBFHLFM(EMOJBEBODMP IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x8947B00", Offset = "0x8946900", VA = "0x188947B00")]
	private void MNDIFLLPDJN(EMOJBEBODMP IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x8947F50", Offset = "0x8946D50", VA = "0x188947F50")]
	private PPJMMNMCCIA OILKALFNHCH(FGGKMIFBJPI GHELEALCFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x8946950", Offset = "0x8945750", VA = "0x188946950")]
	private void BEMKBANCHEO(FGGKMIFBJPI GJKIIJPADEJ, PPJMMNMCCIA NLJIGEDEIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x8947910", Offset = "0x8946710", VA = "0x188947910")]
	private bool MCMNLAFGKML(FGGKMIFBJPI GJKIIJPADEJ, PPJMMNMCCIA NLJIGEDEIGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x89462F0", Offset = "0x89450F0", VA = "0x1889462F0")]
	private bool BBGIFBOHBMN(FGGKMIFBJPI EBBLNDCMPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x8947430", Offset = "0x8946230", VA = "0x188947430")]
	private bool JPNKBEGPPAL(byte PDHHKJCHAJA, ExitGames.Client.Photon.Hashtable IHKPBFJODHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public LIJJLBMAIBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[UnityEngine.Scripting.Preserve]
internal sealed class GKDFCOEAICP : GMGJGIMGKMD, LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class MAGGDKKDBHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public CHJGFILBKKF operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public GKDFCOEAICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public FGGKMIFBJPI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public MAGGDKKDBHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x8948FF0", Offset = "0x8947DF0", VA = "0x188948FF0")]
		internal object NFNJBEPKHIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8948EC0", Offset = "0x8947CC0", VA = "0x188948EC0")]
		internal object EPKPDIBMKBP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct MIBIIBBKPON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder<PPJMMNMCCIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public GKDFCOEAICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public FGGKMIFBJPI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter<PPJMMNMCCIA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8949110", Offset = "0x8947F10", VA = "0x188949110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x89497B0", Offset = "0x89485B0", VA = "0x1889497B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class KNMDDBJLGKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public CHJGFILBKKF operationType;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KNMDDBJLGKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x8945890", Offset = "0x8944690", VA = "0x188945890")]
		internal object NMAKNHMHDBB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class JFDEFBFGLHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public FGGKMIFBJPI request;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public JFDEFBFGLHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x89444D0", Offset = "0x89432D0", VA = "0x1889444D0")]
		internal object KOLJOIIOFAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x8944460", Offset = "0x8943260", VA = "0x188944460")]
		internal object FBOGGDKFIBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8944540", Offset = "0x8943340", VA = "0x188944540")]
		internal object NKOIEPOIEND()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct AJNJAKGBCOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder<PPJMMNMCCIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public FGGKMIFBJPI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public GKDFCOEAICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private JFDEFBFGLHA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private LBEPELJJLIC <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private PPJMMNMCCIA <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter<(PPJMMNMCCIA validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8930770", Offset = "0x892F570", VA = "0x188930770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x8931040", Offset = "0x892FE40", VA = "0x188931040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private GLOINHDCCCK LEFGLILMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private NOLLCEDHKEP GLKHKGCNMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private GNKBHGLOHGH APHCKCMMBIL;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x893AF90", Offset = "0x8939D90", VA = "0x18893AF90", Slot = "5")]
	public void DGPDNICIDDD(IAMHPLKENKJ BFNHJCAHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x893B040", Offset = "0x8939E40", VA = "0x18893B040", Slot = "4")]
	[AsyncStateMachine(typeof(MIBIIBBKPON))]
	private Task<PPJMMNMCCIA> JEGJHBBIFEI(FGGKMIFBJPI GHELEALCFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x893AC60", Offset = "0x8939A60", VA = "0x18893AC60")]
	private bool BIHABECJFED(CHJGFILBKKF FPKOCILEBIL, [Out] PPJMMNMCCIA OHLBIIOAJDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x893AE50", Offset = "0x8939C50", VA = "0x18893AE50")]
	[AsyncStateMachine(typeof(AJNJAKGBCOO))]
	private Task<PPJMMNMCCIA> BIJDIJBFLND(FGGKMIFBJPI OHNONCFAIKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public GKDFCOEAICP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class BPALJLAOMKG : DCFAMFOCBOI, LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private struct CIOOINAKGFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public MFCKDCKCJFL LNCNAPOKDLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public long JIMIBMCEMAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public Guid? IIAEIJHFPJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public bool PPHIBLEKMGB;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct ANKAFDBNPLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder<NLIPGAAAAGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public PLJJBKEIPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public BPALJLAOMKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private TaskAwaiter<AACPGJNOFJH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<NLIPGAAAAGA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x89310B0", Offset = "0x892FEB0", VA = "0x1889310B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x8931680", Offset = "0x8930480", VA = "0x188931680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class JJLAOMCPFLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public JJLAOMCPFLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x8944AF0", Offset = "0x89438F0", VA = "0x188944AF0")]
		internal object GHAIMFINGIH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct BGOLPLGNBEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public AsyncTaskMethodBuilder<AACPGJNOFJH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public BPALJLAOMKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public PLJJBKEIPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private JJLAOMCPFLM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private TaskAwaiter<AACPGJNOFJH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8932F90", Offset = "0x8931D90", VA = "0x188932F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8933580", Offset = "0x8932380", VA = "0x188933580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct FNJIMBHCBGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AsyncTaskMethodBuilder<NLIPGAAAAGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public BPALJLAOMKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public PLJJBKEIPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AACPGJNOFJH roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter<CIOOINAKGFB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x893A3C0", Offset = "0x89391C0", VA = "0x18893A3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x893A930", Offset = "0x8939730", VA = "0x18893A930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class AEGCCPOKNJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public AACPGJNOFJH roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public AEGCCPOKNJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xFAB770", Offset = "0xFAA570", VA = "0x180FAB770")]
		internal bool ADHLFGJDFFN(EJHPEGDEELG sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x8930590", Offset = "0x892F390", VA = "0x188930590")]
		internal object MJCONMEOJBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x89306E0", Offset = "0x892F4E0", VA = "0x1889306E0")]
		internal object NNCLBGFOPID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x8930650", Offset = "0x892F450", VA = "0x188930650")]
		internal object NFLDKEGCECL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class PNEEICKLHJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public AEGCCPOKNJD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public PNEEICKLHJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x894EB10", Offset = "0x894D910", VA = "0x18894EB10")]
		internal object GGIMJEGLCJP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct BHGKCIOCMAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public AsyncTaskMethodBuilder<CIOOINAKGFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public AACPGJNOFJH roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public BPALJLAOMKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public PLJJBKEIPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private PNEEICKLHJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private TaskAwaiter<CIOOINAKGFB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private TaskAwaiter<OGKANJAJEAE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x89335F0", Offset = "0x89323F0", VA = "0x1889335F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x89345A0", Offset = "0x89333A0", VA = "0x1889345A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class MGGMCLEMBFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public MGGMCLEMBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x8949060", Offset = "0x8947E60", VA = "0x188949060")]
		internal object FLIODFGOEJA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private struct JCGEPKNLCFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public AsyncTaskMethodBuilder<CIOOINAKGFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public EJHPEGDEELG subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public BPALJLAOMKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public PLJJBKEIPKH dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private MGGMCLEMBFI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private TaskAwaiter<GOCLDJNMENA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8943D30", Offset = "0x8942B30", VA = "0x188943D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x89443F0", Offset = "0x89431F0", VA = "0x1889443F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private LGPCFOHIOOE JBNGHMBPLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private EGACAKPHMKL FNFCFIGCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private BEMANHJPLDJ NDJEEGCEAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private NMBECPFKCLD HONBLKDJKCG;

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x89346B0", Offset = "0x89334B0", VA = "0x1889346B0", Slot = "5")]
	public void DGPDNICIDDD(IAMHPLKENKJ BFNHJCAHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x8934910", Offset = "0x8933710", VA = "0x188934910", Slot = "4")]
	[AsyncStateMachine(typeof(ANKAFDBNPLP))]
	public Task<NLIPGAAAAGA> IHEBNJDEEDE(EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, PLJJBKEIPKH ICBDNDPBBBE, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x8934BE0", Offset = "0x89339E0", VA = "0x188934BE0")]
	[AsyncStateMachine(typeof(BGOLPLGNBEG))]
	private Task<AACPGJNOFJH> LJIGBGMAANP(PLJJBKEIPKH ICBDNDPBBBE, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x8934D40", Offset = "0x8933B40", VA = "0x188934D40")]
	[AsyncStateMachine(typeof(FNJIMBHCBGP))]
	private Task<NLIPGAAAAGA> LLBPHJKCCPM(PLJJBKEIPKH ICBDNDPBBBE, AACPGJNOFJH HDJLJGEPGEG, long KAAGEAEADCM, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x8934A70", Offset = "0x8933870", VA = "0x188934A70")]
	[AsyncStateMachine(typeof(BHGKCIOCMAI))]
	private Task<CIOOINAKGFB> LBBPONBHADI(PLJJBKEIPKH ICBDNDPBBBE, AACPGJNOFJH HDJLJGEPGEG, long KAAGEAEADCM, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x89347A0", Offset = "0x89335A0", VA = "0x1889347A0")]
	[AsyncStateMachine(typeof(JCGEPKNLCFD))]
	private Task<CIOOINAKGFB> EBOHNALOJLA(PLJJBKEIPKH NOIJDBAMBBE, EJHPEGDEELG LGGFANHFKBF, long KAAGEAEADCM, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public BPALJLAOMKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[UnityEngine.Scripting.Preserve]
internal sealed class EHIOOCNHGKJ : FAJNPDJCFLB, LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class PHFFGHKLOCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public FGGKMIFBJPI request;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public PHFFGHKLOCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x894B5F0", Offset = "0x894A3F0", VA = "0x18894B5F0")]
		internal object NCJBLNMPAGI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct IJNHHJAJGJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public AsyncTaskMethodBuilder<FGGKMIFBJPI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public FGGKMIFBJPI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public EHIOOCNHGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public JHDPICMPNBI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private TaskAwaiter<FGGKMIFBJPI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x893C1F0", Offset = "0x893AFF0", VA = "0x18893C1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x893C800", Offset = "0x893B600", VA = "0x18893C800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct JOFEPDOHHCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public AsyncTaskMethodBuilder<FGGKMIFBJPI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public EHIOOCNHGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public JHDPICMPNBI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private TaskAwaiter<JFLMJDPGAPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x89450F0", Offset = "0x8943EF0", VA = "0x1889450F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x89456F0", Offset = "0x89444F0", VA = "0x1889456F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class LODLMGIDKGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public FGGKMIFBJPI request;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public LODLMGIDKGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8948E60", Offset = "0x8947C60", VA = "0x188948E60")]
		internal object JBLDAKOPICI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct EHEMKBDMCBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public AsyncTaskMethodBuilder<FGGKMIFBJPI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public FGGKMIFBJPI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public EHIOOCNHGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public JHDPICMPNBI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private ADMEBNGDCKJ <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private LFMFBOGIEKH <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private TaskAwaiter<JFLMJDPGAPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8938880", Offset = "0x8937680", VA = "0x188938880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x8939470", Offset = "0x8938270", VA = "0x188939470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private GLOINHDCCCK LEFGLILMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private AJFLOEABEBJ DFDCIIPEPPC;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private DBHNIBMELEK PEFNMIMJMIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x8939B60", Offset = "0x8938960", VA = "0x188939B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x89396E0", Offset = "0x89384E0", VA = "0x1889396E0", Slot = "8")]
	public void DGPDNICIDDD(IAMHPLKENKJ BFNHJCAHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x8939770", Offset = "0x8938570", VA = "0x188939770", Slot = "4")]
	[AsyncStateMachine(typeof(IJNHHJAJGJO))]
	public Task<FGGKMIFBJPI> HJECGCIODNF(FGGKMIFBJPI OHNONCFAIKH, JHDPICMPNBI BIILOFMIEIC, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x89394E0", Offset = "0x89382E0", VA = "0x1889394E0", Slot = "5")]
	[AsyncStateMachine(typeof(JOFEPDOHHCE))]
	public Task<FGGKMIFBJPI> BOGJHBJFJPL(CancellationToken HIMDFBHMPLL, JHDPICMPNBI BIILOFMIEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x8939630", Offset = "0x8938430", VA = "0x188939630", Slot = "6")]
	public NPKOEGNGKDP CGLMGHMJKAI(NJDDNJPCANH IGIEOCFKIHG, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x8939A30", Offset = "0x8938830", VA = "0x188939A30", Slot = "7")]
	public NPKOEGNGKDP LOEHKGFNKCD(NJDDNJPCANH IGIEOCFKIHG, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x89398D0", Offset = "0x89386D0", VA = "0x1889398D0")]
	[AsyncStateMachine(typeof(EHEMKBDMCBC))]
	private Task<FGGKMIFBJPI> JMGCNDKHDAH(FGGKMIFBJPI OHNONCFAIKH, JHDPICMPNBI BIILOFMIEIC, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x3D12260", Offset = "0x3D11060", VA = "0x183D12260")]
	private static byte[] ADGGBDMMCLF(FGGKMIFBJPI IIHOFBLPONF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public EHIOOCNHGKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[UnityEngine.Scripting.Preserve]
internal sealed class PONHLODGAKB : NOLLCEDHKEP, LFDFDKOBAHG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private JCAELKFFBCM OKHODMHHMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private GLOINHDCCCK LEFGLILMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private GCJLOJAJIIE IMIPADJGEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private PIBMLGIDOAO HCDFMKKOFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private LGPCFOHIOOE JBNGHMBPLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private IMBMOMBAKHG GMFEHAACDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private EGGAILHONLB EOGBKDHEEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private EGACAKPHMKL FNFCFIGCMHH;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private KGJIHOMIGPB MFMKIIGCFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x894EFE0", Offset = "0x894DDE0", VA = "0x18894EFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static PPJMMNMCCIA IFJDHFKELAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x894F1A0", Offset = "0x894DFA0", VA = "0x18894F1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x894F030", Offset = "0x894DE30", VA = "0x18894F030", Slot = "6")]
	public void DGPDNICIDDD(IAMHPLKENKJ BFNHJCAHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x894F430", Offset = "0x894E230", VA = "0x18894F430", Slot = "4")]
	public PPJMMNMCCIA JHOAJBCFPHD(CDKFIILELLC FDPINKEEHCL, CHJGFILBKKF NNEHFLALFCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x894F1B0", Offset = "0x894DFB0", VA = "0x18894F1B0", Slot = "5")]
	public PPJMMNMCCIA GDEBGHKJKGJ(CDKFIILELLC DLMFOKOOJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x894F5A0", Offset = "0x894E3A0", VA = "0x18894F5A0")]
	private static PPJMMNMCCIA JJKAJLCKJLO(MFCHBPKIIHA EGLDLGDMAJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public PONHLODGAKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public class FBEIHMGMEEC : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x8939CE0", Offset = "0x8938AE0", VA = "0x188939CE0")]
	public FBEIHMGMEEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7A94E90", Offset = "0x7A93C90", VA = "0x187A94E90")]
	public FBEIHMGMEEC(string IIHOFBLPONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[UnityEngine.Scripting.Preserve]
internal sealed class FFBMAIGFPKG : JBEKKAIEGIO, LFDFDKOBAHG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct LCKHPAFACPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public AsyncTaskMethodBuilder<PPJMMNMCCIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public FFBMAIGFPKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public EKDPPHJHEGI autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private EHDFINDMEJI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private FGECGAJEOOJ <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private TaskAwaiter<PPJMMNMCCIA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x8961DD0", Offset = "0x8960BD0", VA = "0x188961DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x89627A0", Offset = "0x89615A0", VA = "0x1889627A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct MHOLLLKOFMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public FFBMAIGFPKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x8965E80", Offset = "0x8964C80", VA = "0x188965E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x89665E0", Offset = "0x89653E0", VA = "0x1889665E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct ENFFPFGOCMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public FFBMAIGFPKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x8955A80", Offset = "0x8954880", VA = "0x188955A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x8955F90", Offset = "0x8954D90", VA = "0x188955F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct MPBFHFFABIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public FFBMAIGFPKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x8966E30", Offset = "0x8965C30", VA = "0x188966E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x89675F0", Offset = "0x89663F0", VA = "0x1889675F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct EOOBCMHOHHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public FFBMAIGFPKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x89568A0", Offset = "0x89556A0", VA = "0x1889568A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x8956A40", Offset = "0x8955840", VA = "0x188956A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct DGHCFEFHLGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public FFBMAIGFPKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x8953390", Offset = "0x8952190", VA = "0x188953390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x8953AC0", Offset = "0x89528C0", VA = "0x188953AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct GMFPIIJFILH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public FFBMAIGFPKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x89593A0", Offset = "0x89581A0", VA = "0x1889593A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x8959810", Offset = "0x8958610", VA = "0x188959810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct JCEHHJEDGED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public FFBMAIGFPKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public AJHDCFJNACE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private EHDFINDMEJI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x895E0B0", Offset = "0x895CEB0", VA = "0x18895E0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x895E650", Offset = "0x895D450", VA = "0x18895E650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private GLOINHDCCCK LEFGLILMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private IAMHPLKENKJ BFNHJCAHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private LGPCFOHIOOE JBNGHMBPLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private FAJNPDJCFLB CEHHIHAKLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private GCJLOJAJIIE IMIPADJGEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private EGGAILHONLB EOGBKDHEEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private CancellationTokenSource MGCLNLMOIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private Task JAMDABPHPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private TaskCompletionSource<int> HDBMCHOELKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private int AAPNPOLECLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private int GEEJHNCGJKO;

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x8957910", Offset = "0x8956710", VA = "0x188957910", Slot = "6")]
	public void DGPDNICIDDD(IAMHPLKENKJ BFNHJCAHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x14A0B20", Offset = "0x149F920", VA = "0x1814A0B20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x8957AC0", Offset = "0x89568C0", VA = "0x188957AC0")]
	private void DMENLAJPGMG(float FFLNPKMOICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x8958350", Offset = "0x8957150", VA = "0x188958350", Slot = "4")]
	[AsyncStateMachine(typeof(LCKHPAFACPL))]
	public Task<PPJMMNMCCIA> LANHHBIGBLF(EKDPPHJHEGI KMKBPCBONMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x8958570", Offset = "0x8957370", VA = "0x188958570", Slot = "5")]
	[AsyncStateMachine(typeof(MHOLLLKOFMB))]
	public Task NPDIDDIBMBN([Optional] CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x14A0B20", Offset = "0x149F920", VA = "0x1814A0B20")]
	public void BNGKEEBAEEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x8957BA0", Offset = "0x89569A0", VA = "0x188957BA0")]
	private FGECGAJEOOJ DPFCFPPIKHB(EKDPPHJHEGI KMKBPCBONMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x8958480", Offset = "0x8957280", VA = "0x188958480")]
	[AsyncStateMachine(typeof(ENFFPFGOCMD))]
	private Task NMIFPBNIHLO(CancellationToken FOJIDEIIGFD, int CEEFGLDKHNK, KIBEKEOAJNC GNLPCANCLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x8958660", Offset = "0x8957460", VA = "0x188958660")]
	[AsyncStateMachine(typeof(MPBFHFFABIK))]
	private Task OGFEILKOCKL(CancellationToken FOJIDEIIGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x8957DD0", Offset = "0x8956BD0", VA = "0x188957DD0")]
	[AsyncStateMachine(typeof(EOOBCMHOHHG))]
	private Task GAACCGKLPPN([Optional] CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x8957690", Offset = "0x8956490", VA = "0x188957690")]
	[AsyncStateMachine(typeof(DGHCFEFHLGO))]
	private Task AGIIMKOKJGE(CancellationToken FOJIDEIIGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x8958140", Offset = "0x8956F40", VA = "0x188958140")]
	[AsyncStateMachine(typeof(GMFPIIJFILH))]
	private Task HHGKEKMAHKF(CancellationToken HPKDELAPBEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x8957780", Offset = "0x8956580", VA = "0x188957780")]
	private Task CGPCJBFFOHJ(AJHDCFJNACE IJMPHHBDLBM, CancellationToken FOJIDEIIGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x8958240", Offset = "0x8957040", VA = "0x188958240")]
	[AsyncStateMachine(typeof(JCEHHJEDGED))]
	private Task JFNEEKBHNFD(AJHDCFJNACE IJMPHHBDLBM, CancellationToken FOJIDEIIGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x8957EC0", Offset = "0x8956CC0", VA = "0x188957EC0")]
	private bool HCKHHPGLNKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public FFBMAIGFPKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[UnityEngine.Scripting.Preserve]
internal class EPHNKNCBKJJ : PIBMLGIDOAO, LFDFDKOBAHG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct KOBFFAEKEOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public EPHNKNCBKJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private EHDFINDMEJI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x89617B0", Offset = "0x89605B0", VA = "0x1889617B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x8961D70", Offset = "0x8960B70", VA = "0x188961D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private CGDGOCJDGEK KPOCDPAKIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000391")]
	private IAMHPLKENKJ BFNHJCAHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private NOLLCEDHKEP GLKHKGCNMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private FAJNPDJCFLB CEHHIHAKLOM;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x8956BA0", Offset = "0x89559A0", VA = "0x188956BA0", Slot = "6")]
	public void DGPDNICIDDD(IAMHPLKENKJ BFNHJCAHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x8956E80", Offset = "0x8955C80", VA = "0x188956E80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x8956AA0", Offset = "0x89558A0", VA = "0x188956AA0", Slot = "5")]
	[AsyncStateMachine(typeof(KOBFFAEKEOB))]
	public Task ANPJMJIHEAL(string PFPNMKAMPMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x8956ED0", Offset = "0x8955CD0", VA = "0x188956ED0", Slot = "4")]
	public PPJMMNMCCIA HCKHHPGLNKA(CDKFIILELLC FDPINKEEHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x8956F30", Offset = "0x8955D30", VA = "0x188956F30")]
	private OLBLFPJBCML PJLBDBHOOFF(string PFPNMKAMPMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public EPHNKNCBKJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public static class EODDIDLKAEE
{
	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x8956660", Offset = "0x8955460", VA = "0x188956660")]
	public static void OCMJJOPMPGO(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x8956500", Offset = "0x8955300", VA = "0x188956500")]
	internal static void NBMPPPEDIJD(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x8956420", Offset = "0x8955220", VA = "0x188956420")]
	internal static void JILNBAAKGBI(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x8955FF0", Offset = "0x8954DF0", VA = "0x188955FF0")]
	internal static void AOEMOHIGJJJ(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x3A1DEF0", Offset = "0x3A1CCF0", VA = "0x183A1DEF0")]
	private static void MBEJJHCGIEL<Interface, Impl, Interface>(LOAHJOOKLEP CHDHLAGMCKI) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal class LGNHCOAIDEP : FJDANLJBJPP<FGGKMIFBJPI>
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private sealed class FHINFIGAKNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public FGGKMIFBJPI message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FHINFIGAKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x89589B0", Offset = "0x89577B0", VA = "0x1889589B0")]
		internal object LEEEIJAIIFG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly LGNHCOAIDEP ODAOEPEFKDK;

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x8963070", Offset = "0x8961E70", VA = "0x188963070")]
	public ExitGames.Client.Photon.Hashtable NEJFHFKCOKJ(FGGKMIFBJPI IIHOFBLPONF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x8962F40", Offset = "0x8961D40", VA = "0x188962F40", Slot = "5")]
	protected override void MBCFOJJGNND(FGGKMIFBJPI IIHOFBLPONF, IDictionary<object, object> BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x8962D10", Offset = "0x8961B10", VA = "0x188962D10", Slot = "6")]
	public override FGGKMIFBJPI KIDJPDKJMHF(IDictionary<object, object> BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x8963100", Offset = "0x8961F00", VA = "0x188963100")]
	private static void OJKKHHLLEBA(string NNAICENCINP, FGGKMIFBJPI IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x89632B0", Offset = "0x89620B0", VA = "0x1889632B0")]
	public LGNHCOAIDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x8962A60", Offset = "0x8961860", VA = "0x188962A60")]
	[CompilerGenerated]
	internal static string ICJPLJMLKMJ(NLIPGAAAAGA OFCPJKNFOPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public static class FNIDMNFPLDF
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static PPJMMNMCCIA IFJDHFKELAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x8958D80", Offset = "0x8957B80", VA = "0x188958D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x89590A0", Offset = "0x8957EA0", VA = "0x1889590A0")]
	public static bool KIFDCDDJHLF(this PPJMMNMCCIA NLJIGEDEIGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x8959040", Offset = "0x8957E40", VA = "0x188959040")]
	public static PPJMMNMCCIA JJKAJLCKJLO(MFCHBPKIIHA LOGIKODIGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x89590C0", Offset = "0x8957EC0", VA = "0x1889590C0")]
	public static PPJMMNMCCIA PEOIEGJBLEI(IEnumerable<PPJMMNMCCIA> HBAHAALHELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x8958DE0", Offset = "0x8957BE0", VA = "0x188958DE0")]
	public static string IBJHIEEFPMI(this PPJMMNMCCIA OHLBIIOAJDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public abstract class ICGGKFMAOPJ : EJHFJJKEGIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public delegate PPJMMNMCCIA BHLIKILHFKC([NotNull] CDKFIILELLC FMBEIGMGJCL);

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class HHJNPNCEJFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public CDKFIILELLC photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public HHJNPNCEJFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x17650F0", Offset = "0x1763EF0", VA = "0x1817650F0")]
		internal PPJMMNMCCIA EKAIADJMMHG(BHLIKILHFKC v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	private bool HDGGIMAAJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	protected readonly HashSet<BHLIKILHFKC> AINAHEKLLOC;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x895BB90", Offset = "0x895A990", VA = "0x18895BB90", Slot = "4")]
	public void MGELDNNCDGD(BHLIKILHFKC CBADCDGNEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x895BBF0", Offset = "0x895A9F0", VA = "0x18895BBF0", Slot = "5")]
	public void MHHCMEAGKCJ(BHLIKILHFKC CBADCDGNEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x895BB40", Offset = "0x895A940", VA = "0x18895BB40", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x895B8A0", Offset = "0x895A6A0", VA = "0x18895B8A0")]
	protected PPJMMNMCCIA BDMOBADBABB(CDKFIILELLC DLMFOKOOJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x895BC50", Offset = "0x895AA50", VA = "0x18895BC50")]
	protected ICGGKFMAOPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class JCLPAKLBNGA : ICGGKFMAOPJ, JCAELKFFBCM, EJHFJJKEGIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class FPHKOAMCBFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public PPJMMNMCCIA result;

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FPHKOAMCBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x89592C0", Offset = "0x89580C0", VA = "0x1889592C0")]
		internal object IKDKDEGDEEJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x895E7C0", Offset = "0x895D5C0", VA = "0x18895E7C0")]
	[UnityEngine.Scripting.Preserve]
	public JCLPAKLBNGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x895E6B0", Offset = "0x895D4B0", VA = "0x18895E6B0", Slot = "8")]
	public PPJMMNMCCIA NGAGMBABJLF(CDKFIILELLC DLMFOKOOJGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class MJFEOFBBPFH : ICGGKFMAOPJ, CGDGOCJDGEK, EJHFJJKEGIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class MDNALPKDFJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public PPJMMNMCCIA result;

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public MDNALPKDFJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x8965E20", Offset = "0x8964C20", VA = "0x188965E20")]
		internal object LPEJENMIEDK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x895E7C0", Offset = "0x895D5C0", VA = "0x18895E7C0")]
	[UnityEngine.Scripting.Preserve]
	public MJFEOFBBPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x8966640", Offset = "0x8965440", VA = "0x188966640", Slot = "8")]
	public PPJMMNMCCIA HCKHHPGLNKA(CDKFIILELLC BFIOOMKAEHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal static class DIEMIHFEKFH
{
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private sealed class GAJDAEHDNEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public EHDFINDMEJI<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public GAJDAEHDNEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x8959320", Offset = "0x8958120", VA = "0x188959320")]
		internal object LHDCCGMJHNH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x8953BE0", Offset = "0x89529E0", VA = "0x188953BE0")]
	public static EHDFINDMEJI<string> EGCFJNEDDLK(PHLHEDGDBJO CFEMPAINFAM, [Optional] string CKAENABAGHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x8953CC0", Offset = "0x8952AC0", VA = "0x188953CC0")]
	public static void FKMBHKCLONI(EHDFINDMEJI<string> INANPMNJHBH, PHLHEDGDBJO CFEMPAINFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x8953B20", Offset = "0x8952920", VA = "0x188953B20")]
	public static string BIKMNPLPANI(FGGKMIFBJPI GHELEALCFHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal static class MMCFHPNKDFP
{
	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x8966750", Offset = "0x8965550", VA = "0x188966750")]
	public static void CJLFKJLJBIP(this GLOINHDCCCK LEFGLILMCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x8966880", Offset = "0x8965680", VA = "0x188966880")]
	public static void MELBILHHILI(this GLOINHDCCCK LEFGLILMCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x8966760", Offset = "0x8965560", VA = "0x188966760")]
	private static void DGHELGAIMPE(this GLOINHDCCCK LEFGLILMCMC, bool JFOLDLMPFGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class IBMDIAFBCCO : LDHNAFBKDEA, JMFPGPLHDPA, EOJHGHGPFPI, ADIAHLJLKIO
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[DefaultMember("Item")]
	private class KBLNMDBFDHF : BNHAMMLICHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly byte PBBMMPMCJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly int DFODLDMBKGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly object GMEFFDPOCHO;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public byte DAKKGIPNOCC
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xB2CDD0", Offset = "0xB2BBD0", VA = "0x180B2CDD0", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public int IHPIJHOJMFD
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA750", Offset = "0xAA9550", VA = "0x180AAA750", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public object JGAMFNLHNIE
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public object CBMLGEIEAGG
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x89614A0", Offset = "0x89602A0", VA = "0x1889614A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x7A9C4D0", Offset = "0x7A9B2D0", VA = "0x187A9C4D0")]
		public KBLNMDBFDHF(byte PBBMMPMCJKL, int DFODLDMBKGD, object GMEFFDPOCHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x8961450", Offset = "0x8960250", VA = "0x188961450", Slot = "8")]
		public bool BNILIKGEJAF(byte MAHBBBBCDEL, [Out] object BNECONOIKOE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private readonly JMFPGPLHDPA EEGKCFKOLIN;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public CDKFIILELLC MJGODKHPGED
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x895B6F0", Offset = "0x895A4F0", VA = "0x18895B6F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int FAPMOAFEKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x895B360", Offset = "0x895A160", VA = "0x18895B360", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int AFKDEMJKGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x895B160", Offset = "0x8959F60", VA = "0x18895B160", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public CDKFIILELLC KHOJCOJCEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x895B310", Offset = "0x895A110", VA = "0x18895B310", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool FIGMIMCIHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public int JEONCIPDDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xAB4B10", Offset = "0xAB3910", VA = "0x180AB4B10", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public string DLLNHBGOKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x895B250", Offset = "0x895A050", VA = "0x18895B250", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Func<string, string> HHBCCJPDNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x895AFC0", Offset = "0x8959DC0", VA = "0x18895AFC0", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<string, long> IADDKLIFMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<BNHAMMLICHE> IPHPMBONNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x895B7F0", Offset = "0x895A5F0", VA = "0x18895B7F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x895B740", Offset = "0x895A540", VA = "0x18895B740", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<bool> JGEPJGNPIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "26")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "27")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<CDKFIILELLC> CGBHEFOCDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action GFHEEAKKOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x895B080", Offset = "0x8959E80", VA = "0x18895B080", Slot = "35")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x895B1B0", Offset = "0x8959FB0", VA = "0x18895B1B0", Slot = "36")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x895B2B0", Offset = "0x895A0B0", VA = "0x18895B2B0", Slot = "19")]
	public void FJEKKPEHOEO(string GGDFKFACHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0xE2A710", Offset = "0xE29510", VA = "0x180E2A710")]
	public IBMDIAFBCCO(JMFPGPLHDPA EEGKCFKOLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x895AE60", Offset = "0x8959C60", VA = "0x18895AE60", Slot = "8")]
	public bool ABAIPAFDLHL(byte PDHHKJCHAJA, object DJDGPPAEEBM, EIIAJLFMPKP AHDDAHBPIGH, CEHPMOIPPMO JOBCJCEJNOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x895B570", Offset = "0x895A370", VA = "0x18895B570", Slot = "20")]
	public CDKFIILELLC JADMFPFBEGO(int KBOFJIFLEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x895B490", Offset = "0x895A290", VA = "0x18895B490", Slot = "21")]
	public CDKFIILELLC IOLEOBNOIFI(int ADHDKEKHIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x895B3B0", Offset = "0x895A1B0", VA = "0x18895B3B0", Slot = "22")]
	public CDKFIILELLC HDOFDBCLPAD(int KBOFJIFLEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x895B610", Offset = "0x895A410", VA = "0x18895B610", Slot = "23")]
	public IReadOnlyList<CDKFIILELLC> JPIEBONGCDC(bool CNEBLAHDCNB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x895B120", Offset = "0x8959F20", VA = "0x18895B120", Slot = "24")]
	public IReadOnlyList<CDKFIILELLC> BHMCFIBJKMP(bool CNEBLAHDCNB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "25")]
	public bool GIBCAOLOBGD(CDKFIILELLC OEKEOJLNJFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "28")]
	public void DFMMIIOHJJM(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "29")]
	public void GLKKEOFCCJK(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "30")]
	public void HIPJHKDIONB(object OCGDLEBGIMO, bool EKEBHDLGILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x895AF70", Offset = "0x8959D70", VA = "0x18895AF70", Slot = "31")]
	public IDisposable ABKGMIJKJKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "32")]
	private bool EMOEAFLGOCN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "33")]
	public void DJOJDICKJCJ(StringBuilder DEPPELPLLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x1087810", Offset = "0x1086610", VA = "0x181087810", Slot = "34")]
	public bool MEPEMDMOGLG(bool AECBMPJFLNM, [Out] string BKBLOMKNEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0xFF4A10", Offset = "0xFF3810", VA = "0x180FF4A10", Slot = "37")]
	public void EBBEHLFKPPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal struct EMOJBEBODMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly IDictionary<object, object> IHKPBFJODHM;

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0xE3B7E0", Offset = "0xE3A5E0", VA = "0x180E3B7E0")]
	public EMOJBEBODMP(IDictionary<object, object> IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x89559D0", Offset = "0x89547D0", VA = "0x1889559D0")]
	public bool NDLOLHALIIH([Out] FGGKMIFBJPI IIHOFBLPONF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x89556F0", Offset = "0x89544F0", VA = "0x1889556F0")]
	public Guid CPCDLCJIOPF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x89557A0", Offset = "0x89545A0", VA = "0x1889557A0")]
	public PPJMMNMCCIA FBJKGILKHKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x89558E0", Offset = "0x89546E0", VA = "0x1889558E0")]
	public static ExitGames.Client.Photon.Hashtable LDFHHMLGJNG(FGGKMIFBJPI IIHOFBLPONF, PPJMMNMCCIA NLJIGEDEIGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal static class CHEHHMMEBCD
{
	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x89526C0", Offset = "0x89514C0", VA = "0x1889526C0")]
	public static bool MEKPMHCCPBB(this PLJJBKEIPKH HOAMOKDGHIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal struct CENECABELJM : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct CHIFDAFEMAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public CENECABELJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8952740", Offset = "0x8951540", VA = "0x188952740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8952920", Offset = "0x8951720", VA = "0x188952920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly CancellationTokenSource JJKKCMEFGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private bool HDGGIMAAJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private Task JNOGJECEFDN;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool IHBLCGMONJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x8952560", Offset = "0x8951360", VA = "0x188952560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x8952590", Offset = "0x8951390", VA = "0x188952590")]
	public CENECABELJM(CancellationToken HIMDFBHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8952400", Offset = "0x8951200", VA = "0x188952400")]
	[AsyncStateMachine(typeof(CHIFDAFEMAI))]
	public Task BMJLIKDBCPO(Func<CancellationToken, List<Task>> AAFCGMDBCKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x8952510", Offset = "0x8951310", VA = "0x188952510", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public readonly struct CODFOIDDMOC<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct DKNEKPGMEAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public AsyncTaskMethodBuilder<CKPFCFEHEPP<DFNOANMHPNJ<TData>, BHGDKCCPEDL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public EHDFINDMEJI<string>.NGEIFBMECIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public CODFOIDDMOC<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<CKPFCFEHEPP<DFNOANMHPNJ<TData>, BHGDKCCPEDL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x6E08040", Offset = "0x6E06E40", VA = "0x186E08040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x4C94C20", Offset = "0x4C93A20", VA = "0x184C94C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	private readonly IIJBCDKGIOM<TGetDataArg, TData> IHILFMGFJPA;

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0xE3B7E0", Offset = "0xE3A5E0", VA = "0x180E3B7E0")]
	internal CODFOIDDMOC(IIJBCDKGIOM<TGetDataArg, TData> FEBHHEFFJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x68DF990", Offset = "0x68DE790", VA = "0x1868DF990")]
	[AsyncStateMachine(typeof(CODFOIDDMOC<, >.DKNEKPGMEAO))]
	public Task<CKPFCFEHEPP<DFNOANMHPNJ<TData>, BHGDKCCPEDL>> CCILGCMCMIF(TGetDataArg AGJNJFMNGDN, string JFMAJBDHHJG, EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public static class GJFOINMPLFO
{
	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x39F27A0", Offset = "0x39F15A0", VA = "0x1839F27A0")]
	public static CODFOIDDMOC<TGetDataArg, TData> OGAKBGHEIKK<TGetDataArg, TData>(IIJBCDKGIOM<TGetDataArg, TData> FEBHHEFFJMB)
	{
		return default(CODFOIDDMOC<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public struct NIPINPIGFJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public readonly int DAKKGIPNOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public readonly int? IJIKKDOEFLB;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x53D5A80", Offset = "0x53D4880", VA = "0x1853D5A80")]
	public NIPINPIGFJL(int PBBMMPMCJKL, [Optional] int? GPBPMBIPJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x8967A90", Offset = "0x8966890", VA = "0x188967A90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface KEJEGNCCPHP<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCFFGDCGEPA();

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KEJEGNCCPHP<T> LLNOGLOFKFK(string DBLHLEOMFHK);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KEJEGNCCPHP<T> PMKIKNJODEC(FDNBKNMLGEO<T> CONBOGLKKCK);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KEJEGNCCPHP<T> ADGHLKFBLBL(int PKDKDIFALGO);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KEJEGNCCPHP<T> JNLEBAGPAAP(int PKDKDIFALGO, KGKLKINDALB<T> DEIOHFDAGGD);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface EJGFFGADOMD
{
	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KEJEGNCCPHP<T> BADAHBGCAHL<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BGDJBIFFCPN EELHNJOPMJK(Exception KHPHCONHPBN);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NIPINPIGFJL DCMADJFIMGA(Exception KHPHCONHPBN);
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public delegate string FDNBKNMLGEO<in T>(T KHPHCONHPBN) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public delegate int KGKLKINDALB<in T>(T KHPHCONHPBN) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class KBFMHBLGDBL : EJGFFGADOMD
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private delegate string GONJIKPONOP(Exception KHPHCONHPBN);

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private delegate int GGCEFLPBJIH(Exception KHPHCONHPBN);

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	private class FMBHGOAOFND<T> : KEJEGNCCPHP<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class HOOKGOEJEKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public HOOKGOEJEKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
			internal string CKILGAGHMPK(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		[CompilerGenerated]
		private sealed class JIGMEODJMIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public FDNBKNMLGEO<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public JIGMEODJMIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x51B26D0", Offset = "0x51B14D0", VA = "0x1851B26D0")]
			internal string MMMJDPDOFNG(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000104")]
		[CompilerGenerated]
		private sealed class BPBOMOFDIAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public KGKLKINDALB<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public BPBOMOFDIAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x51B26D0", Offset = "0x51B14D0", VA = "0x1851B26D0")]
			internal int PBAEMCNFPCB(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private readonly KBFMHBLGDBL ACCELNCAJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private readonly Type JJBIJEINLHN;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x4CCCEB0", Offset = "0x4CCBCB0", VA = "0x184CCCEB0")]
		internal FMBHGOAOFND(KBFMHBLGDBL ACCELNCAJNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x4CCCB40", Offset = "0x4CCB940", VA = "0x184CCCB40", Slot = "4")]
		public void BCFFGDCGEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x4CCCC90", Offset = "0x4CCBA90", VA = "0x184CCCC90", Slot = "5")]
		public KEJEGNCCPHP<T> LLNOGLOFKFK(string DBLHLEOMFHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x4CCCDA0", Offset = "0x4CCBBA0", VA = "0x184CCCDA0", Slot = "6")]
		public KEJEGNCCPHP<T> PMKIKNJODEC(FDNBKNMLGEO<T> CONBOGLKKCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x4CCCB00", Offset = "0x4CCB900", VA = "0x184CCCB00", Slot = "7")]
		public KEJEGNCCPHP<T> ADGHLKFBLBL(int PKDKDIFALGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x4CCCB70", Offset = "0x4CCB970", VA = "0x184CCCB70", Slot = "8")]
		public KEJEGNCCPHP<T> JNLEBAGPAAP(int PKDKDIFALGO, KGKLKINDALB<T> DEIOHFDAGGD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class CFFIJBJBHEE<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private bool HNBBEBNPKCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private readonly List<Type> JHGPJCMHAAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private readonly Dictionary<Type, TVal> IAHPMCOOLLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private readonly Dictionary<Type, int> GKIPHDFMNMK;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public IReadOnlyList<Type> FBAGMBIACMG
		{
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x670CA40", Offset = "0x670B840", VA = "0x18670CA40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x670CD90", Offset = "0x670BB90", VA = "0x18670CD90")]
		public CFFIJBJBHEE(Dictionary<Type, int> GKIPHDFMNMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x670CBE0", Offset = "0x670B9E0", VA = "0x18670CBE0")]
		public void OLHPIGGMIDE(Type MAHBBBBCDEL, TVal HBLCHHJHKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x670C900", Offset = "0x670B700", VA = "0x18670C900")]
		public bool FOFGMCIDMBG(Type JJBIJEINLHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x670C940", Offset = "0x670B740", VA = "0x18670C940")]
		public bool HDGPHFFFDLN(TVal BNECONOIKOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x670CB00", Offset = "0x670B900", VA = "0x18670CB00")]
		public TVal LHCLHJGACJJ(Type DGPNPBEKOOD)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x670C7C0", Offset = "0x670B5C0", VA = "0x18670C7C0")]
		[CompilerGenerated]
		private int EKDDNCLICCP(Type KEHKHCGPHIC, Type GONNHCPAJCA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class HIKJDILGBHJ : IEnumerable<NIPINPIGFJL>, IEnumerable, IEnumerator<NIPINPIGFJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private NIPINPIGFJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public KBFMHBLGDBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private IEnumerator<NIPINPIGFJL> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private NIPINPIGFJL System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x48A60A0", Offset = "0x48A4EA0", VA = "0x1848A60A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(NIPINPIGFJL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x895A000", Offset = "0x8958E00", VA = "0x18895A000", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xF9A0D0", Offset = "0xF98ED0", VA = "0x180F9A0D0")]
		[DebuggerHidden]
		public HIKJDILGBHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x895A050", Offset = "0x8958E50", VA = "0x18895A050", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x8959A40", Offset = "0x8958840", VA = "0x188959A40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x89599F0", Offset = "0x89587F0", VA = "0x1889599F0")]
		private void KHMMOEFKMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x89599A0", Offset = "0x89587A0", VA = "0x1889599A0")]
		private void ICJNGMGPPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x8959FB0", Offset = "0x8958DB0", VA = "0x188959FB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x8959EF0", Offset = "0x8958CF0", VA = "0x188959EF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NIPINPIGFJL> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8959EF0", Offset = "0x8958CF0", VA = "0x188959EF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private static readonly NIPINPIGFJL AKNNCGKDCIA;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private static readonly Dictionary<Type, int> DIEPIHIMDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly HashSet<Type> COANCILFEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	private readonly CFFIJBJBHEE<int> ICAPHMDGEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	private readonly CFFIJBJBHEE<GGCEFLPBJIH> EJAGLFICBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	private readonly CFFIJBJBHEE<GONJIKPONOP> BMBBFFADJDF;

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x8960E20", Offset = "0x895FC20", VA = "0x188960E20")]
	[ONLJNMLDJBD.KDDDMPKOLFO.GACHHHHOLBP]
	internal static void NPDNKFNEHEP(LOAHJOOKLEP MHIANKFNOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x89610B0", Offset = "0x895FEB0", VA = "0x1889610B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KBFMHBLGDBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x3122F60", Offset = "0x3121D60", VA = "0x183122F60", Slot = "4")]
	public KEJEGNCCPHP<T> BADAHBGCAHL<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x8960300", Offset = "0x895F100", VA = "0x188960300", Slot = "5")]
	public BGDJBIFFCPN EELHNJOPMJK(Exception KHPHCONHPBN)
	{
		return default(BGDJBIFFCPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x895FD50", Offset = "0x895EB50", VA = "0x18895FD50", Slot = "6")]
	public NIPINPIGFJL DCMADJFIMGA(Exception? KHPHCONHPBN)
	{
		return default(NIPINPIGFJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x895FCB0", Offset = "0x895EAB0", VA = "0x18895FCB0", Slot = "7")]
	[IteratorStateMachine(typeof(HIKJDILGBHJ))]
	public IEnumerable<NIPINPIGFJL> CGLPADGOHBA(Exception KHPHCONHPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x8960E90", Offset = "0x895FC90", VA = "0x188960E90", Slot = "8")]
	public string POKCPDGLGCN(Exception? KHPHCONHPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x8960740", Offset = "0x895F540", VA = "0x188960740")]
	private string LNHFIBBGPPF(AggregateException OMBHHBFBCKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x8960390", Offset = "0x895F190", VA = "0x188960390")]
	private void HGMNJGNKEHO(Type JJBIJEINLHN, int PKDKDIFALGO, GGCEFLPBJIH? DFPLEBNKNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x8960BD0", Offset = "0x895F9D0", VA = "0x188960BD0")]
	private void NJMAIBNFBID(Type JJBIJEINLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x895FF50", Offset = "0x895ED50", VA = "0x18895FF50")]
	private void DGOFAKMGBCD(Type JJBIJEINLHN, GONJIKPONOP BHEPLCDJIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x8960A50", Offset = "0x895F850", VA = "0x188960A50")]
	private static int NFBGJKDMEBE(Type JJBIJEINLHN, Dictionary<Type, int> GKIPHDFMNMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x3C3ACA0", Offset = "0x3C39AA0", VA = "0x183C3ACA0")]
	private static bool FNPAJPELICH<TVal>(CFFIJBJBHEE<TVal> FEBLBJIINOM, Type JJBIJEINLHN, [Out] TVal BNECONOIKOE) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8960220", Offset = "0x895F020", VA = "0x188960220")]
	[CompilerGenerated]
	internal static int DPIFIEFCPII(Type NKCHCGFMMNJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public struct BGDJBIFFCPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public readonly NIPINPIGFJL NCMGDHLDJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public readonly string IHMAJJNGLJI;

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x89510E0", Offset = "0x894FEE0", VA = "0x1889510E0")]
	public BGDJBIFFCPN(string LEPKJMHAOLF, NIPINPIGFJL PKDKDIFALGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x8951040", Offset = "0x894FE40", VA = "0x188951040")]
	public string EIADKLINHBB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class PPEDIAHNHEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private readonly BKIICIJGLFD EIHAEDIBKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private string ODJLECBFENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private long? LICKJKIOBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private long? CNECOLMDLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private long? INAMGOHNLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private string GHHEOGAJPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private GFFKHEAOFOJ HKPALEOHLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private long? BMDALIIJACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private bool FIFHLOKIAHG;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public string ODBIFEBIBKH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public long PFFBGAMIIJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x896C260", Offset = "0x896B060", VA = "0x18896C260")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public long LDCGLFMFIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x896BD10", Offset = "0x896AB10", VA = "0x18896BD10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public long ENGGNHMGBMD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x896BD70", Offset = "0x896AB70", VA = "0x18896BD70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string LILNIDKPAEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x896CA00", Offset = "0x896B800", VA = "0x18896CA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public GFFKHEAOFOJ FAAAEDKKBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xAB5350", Offset = "0xAB4150", VA = "0x180AB5350")]
		get
		{
			return default(GFFKHEAOFOJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x896BC20", Offset = "0x896AA20", VA = "0x18896BC20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public long KGOCJNOMPEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x896C9A0", Offset = "0x896B7A0", VA = "0x18896C9A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x896CA40", Offset = "0x896B840", VA = "0x18896CA40")]
	[UnityEngine.Scripting.Preserve]
	public PPEDIAHNHEB([OLOAAHJODHH(null)] BKIICIJGLFD EIHAEDIBKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x896C360", Offset = "0x896B160", VA = "0x18896C360")]
	private void HEPDFHECBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x896BDD0", Offset = "0x896ABD0", VA = "0x18896BDD0")]
	public void FDBMINALACN(long NCGHDDJNJOM, long KAAGEAEADCM, [Optional] long? CHOOOGFBFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x896C2C0", Offset = "0x896B0C0", VA = "0x18896C2C0")]
	public void HDEAEEKFBNP(long CHOOOGFBFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x896C920", Offset = "0x896B720", VA = "0x18896C920")]
	public void INLIEDMLHOB(string PEIBEBOEDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x896C5B0", Offset = "0x896B3B0", VA = "0x18896C5B0")]
	public void HFKBCOMJAHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class NPKOEGNGKDP : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct OLHKGDAHHOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public AsyncTaskMethodBuilder<FGGKMIFBJPI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public FGGKMIFBJPI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public NPKOEGNGKDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private TaskAwaiter<DBHNIBMELEK.LKAOMGMKNOJ<FGGKMIFBJPI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x896B600", Offset = "0x896A400", VA = "0x18896B600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x896BB40", Offset = "0x896A940", VA = "0x18896BB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct EIFJLHMHFPC<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class HNLLNCNOEDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public FGGKMIFBJPI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public HNLLNCNOEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x895A3C0", Offset = "0x89591C0", VA = "0x18895A3C0")]
		internal FGGKMIFBJPI HANKKILCHDO(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct OALCGPFAIGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public AsyncTaskMethodBuilder<DBHNIBMELEK.LKAOMGMKNOJ<FGGKMIFBJPI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public FGGKMIFBJPI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public NPKOEGNGKDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private ADMEBNGDCKJ <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private TaskAwaiter<DBHNIBMELEK.LKAOMGMKNOJ<FGGKMIFBJPI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x8969C60", Offset = "0x8968A60", VA = "0x188969C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x896A270", Offset = "0x8969070", VA = "0x18896A270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct JBPLOLNHKNE<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public NPKOEGNGKDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x51862D0", Offset = "0x51850D0", VA = "0x1851862D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x4C94C20", Offset = "0x4C93A20", VA = "0x184C94C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct MOHEBAEMLFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public NPKOEGNGKDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x8966AF0", Offset = "0x89658F0", VA = "0x188966AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x8966DD0", Offset = "0x8965BD0", VA = "0x188966DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class LKOBLCMOPOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public LKOBLCMOPOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x8964860", Offset = "0x8963660", VA = "0x188964860")]
		internal object GGNDOKAEAGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x89648C0", Offset = "0x89636C0", VA = "0x1889648C0")]
		internal bool KAKIJCJFNLC(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class KNFMPONHLOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KNFMPONHLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x8961750", Offset = "0x8960550", VA = "0x188961750")]
		internal object NNFFPAHKHEB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class PFIHIEKMJBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public PFIHIEKMJBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x896BBB0", Offset = "0x896A9B0", VA = "0x18896BBB0")]
		internal object CPHAICDDGKM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class FMOAGMNBGCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FMOAGMNBGCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x8958D10", Offset = "0x8957B10", VA = "0x188958D10")]
		internal object DNJHFNEDFHA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class LDCPKAJKNNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public NPKOEGNGKDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public LDCPKAJKNNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x8962810", Offset = "0x8961610", VA = "0x188962810")]
		internal object LEEEIJAIIFG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private static readonly Guid IFMCDCGNJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public readonly NJDDNJPCANH DAHCGELOPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	private readonly DBHNIBMELEK NLKGAJKEDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	private readonly EOJHGHGPFPI LEFGLILMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	private readonly ADIAHLJLKIO KKANALCHGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	private bool HJGJEOGOFPL;

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x8969A30", Offset = "0x8968830", VA = "0x188969A30")]
	public NPKOEGNGKDP(NJDDNJPCANH POKDMNFNEPP, DBHNIBMELEK NLKGAJKEDDD, EOJHGHGPFPI LEFGLILMCMC, ADIAHLJLKIO KKANALCHGND, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x8968D10", Offset = "0x8967B10", VA = "0x188968D10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x8968D20", Offset = "0x8967B20", VA = "0x188968D20")]
	public void ENHBEGNKPDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x8968C50", Offset = "0x8967A50", VA = "0x188968C50")]
	public void DKLBHOACFHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x89697A0", Offset = "0x89685A0", VA = "0x1889697A0")]
	public void OCBPHLCNCDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x89693D0", Offset = "0x89681D0", VA = "0x1889693D0")]
	[AsyncStateMachine(typeof(OLHKGDAHHOI))]
	internal Task<FGGKMIFBJPI> LCEAKAINOAB(EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, FGGKMIFBJPI GHELEALCFHI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x3D12260", Offset = "0x3D11060", VA = "0x183D12260")]
	private static byte[] CIGCOMIHPII<T>(T IIHOFBLPONF) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x3D12270", Offset = "0x3D11070", VA = "0x183D12270")]
	private static T GAPOFIBDNPO<T>(MessageParser<T> LHBIPOJIBEL, byte[] IIHOFBLPONF, T NKLFIDDLENK) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x8969020", Offset = "0x8967E20", VA = "0x188969020")]
	[AsyncStateMachine(typeof(OALCGPFAIGO))]
	private Task<DBHNIBMELEK.LKAOMGMKNOJ<FGGKMIFBJPI>> GOAEJACJCPG(FGGKMIFBJPI GHELEALCFHI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x3D12670", Offset = "0x3D11470", VA = "0x183D12670")]
	[AsyncStateMachine(typeof(JBPLOLNHKNE<>))]
	internal Task<T> IPKOECFJFDP<T>(CancellationToken FOJIDEIIGFD, Func<CancellationToken, Task<T>> ACFKBFJDMNP, int PAPBCAKEKLI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x8969160", Offset = "0x8967F60", VA = "0x188969160")]
	[AsyncStateMachine(typeof(MOHEBAEMLFI))]
	internal Task IPKOECFJFDP(CancellationToken FOJIDEIIGFD, Func<CancellationToken, Task> ACFKBFJDMNP, int PAPBCAKEKLI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x8968FA0", Offset = "0x8967DA0", VA = "0x188968FA0")]
	public ENGKMPOGMEN FGHNGEJBGHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x8968A40", Offset = "0x8967840", VA = "0x188968A40")]
	public IOHNKCADMCC DFLLIAKBLEH([Optional] ELFNFNHPMNK DIKKAKOJDJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x8969530", Offset = "0x8968330", VA = "0x188969530")]
	public NKINAFBDBPC NFJNIMNOJNL([Optional] PHLHEDGDBJO? CFEMPAINFAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x8968E40", Offset = "0x8967C40", VA = "0x188968E40")]
	public void FAFNAHMCKNC(Func<Guid, bool> JGFEDFHOGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x8968820", Offset = "0x8967620", VA = "0x188968820")]
	public void AAIGFHJEFLM(Func<Guid, bool> ILEOOGLPAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x8968AD0", Offset = "0x89678D0", VA = "0x188968AD0")]
	public Guid DJDHPHGMGOB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x8968930", Offset = "0x8967730", VA = "0x188968930")]
	public void BADBHGJCCNA(Guid ALPNJHDBADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x8969290", Offset = "0x8968090", VA = "0x188969290")]
	public void KBMCKIIBONP(FGGKMIFBJPI NJLJHICGILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x8969860", Offset = "0x8968660", VA = "0x188969860")]
	public void OJKKHHLLEBA(string DOHAAKJINBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x3D12180", Offset = "0x3D10F80", VA = "0x183D12180")]
	private T BPPDEOPCMCL<T>(T BNECONOIKOE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x8969970", Offset = "0x8968770", VA = "0x188969970")]
	public void OOPOJLECLGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x3D123C0", Offset = "0x3D111C0", VA = "0x183D123C0")]
	[CompilerGenerated]
	internal static string IJIMNIGDLOB<T>(byte[] JMAPKDPGDHP, int CGLFLAMIPMP, EIFJLHMHFPC<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal sealed class JHEEMIGINKN : NJDDNJPCANH
{
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class IJOGLPBKCEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public IJOGLPBKCEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x895BCE0", Offset = "0x895AAE0", VA = "0x18895BCE0")]
		internal object CABKDCOCKPB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct EBINPKHHOKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public JHEEMIGINKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public NPKOEGNGKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private DAIJPMNLLOK <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private IOHNKCADMCC <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private TaskAwaiter<LLIFOPCOJJN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x8953EC0", Offset = "0x8952CC0", VA = "0x188953EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x8954DC0", Offset = "0x8953BC0", VA = "0x188954DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct EHHOBCABHEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public JHEEMIGINKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private TaskAwaiter<AACPGJNOFJH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x8954E20", Offset = "0x8953C20", VA = "0x188954E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x89555C0", Offset = "0x89543C0", VA = "0x1889555C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct NBOFOEHPDPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public JHEEMIGINKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private TaskAwaiter<FPNKDIBEOOD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x8967650", Offset = "0x8966450", VA = "0x188967650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x8967960", Offset = "0x8966760", VA = "0x188967960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class DLJFADMOEGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public DAIJPMNLLOK presence;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public DLJFADMOEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x8953D80", Offset = "0x8952B80", VA = "0x188953D80")]
		internal object MGLJCINBDLA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private static readonly PHLHEDGDBJO FBBIFJHMNMH;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private static readonly PHLHEDGDBJO MCFLJHOOAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private readonly NLIPGAAAAGA LIDKENLOPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly PLJJBKEIPKH KCFNOHKIAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly ELFNFNHPMNK DIKKAKOJDJG;

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x895F570", Offset = "0x895E370", VA = "0x18895F570")]
	public JHEEMIGINKN(NLIPGAAAAGA LIDKENLOPCE, PLJJBKEIPKH KCFNOHKIAJD, Guid ALEMANCBDEO, IAMHPLKENKJ BFNHJCAHHAN, JHDPICMPNBI EEPMCAKKJEF, ELFNFNHPMNK DIKKAKOJDJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x895F070", Offset = "0x895DE70", VA = "0x18895F070", Slot = "7")]
	[AsyncStateMachine(typeof(EBINPKHHOKH))]
	protected override Task GGLIEJBDGBK(NPKOEGNGKDP CKGHDNAPCNB, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x895F1C0", Offset = "0x895DFC0", VA = "0x18895F1C0")]
	[AsyncStateMachine(typeof(EHHOBCABHEE))]
	private Task GOJHOGPMOAH(CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x895EF60", Offset = "0x895DD60", VA = "0x18895EF60")]
	[AsyncStateMachine(typeof(NBOFOEHPDPI))]
	private Task<int> BMHDJEJOEBH(CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x895F2C0", Offset = "0x895E0C0", VA = "0x18895F2C0")]
	private DAIJPMNLLOK NNEFKGJKFDM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal class FGECGAJEOOJ : NJDDNJPCANH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct CMGNGJGIGIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public FGECGAJEOOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public NPKOEGNGKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private TaskAwaiter<AEFELCHEGKN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x8952980", Offset = "0x8951780", VA = "0x188952980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x8953330", Offset = "0x8952130", VA = "0x188953330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly int DMCALPDPBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly EKDPPHJHEGI LICJOHINBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public readonly long NBAAIIHONBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public readonly long GMNPNPCNDPB;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public AEFELCHEGKN ALMBGOBDJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xA66730", Offset = "0xA65530", VA = "0x180A66730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xA66690", Offset = "0xA65490", VA = "0x180A66690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x8958880", Offset = "0x8957680", VA = "0x188958880")]
	public FGECGAJEOOJ(Guid ALEMANCBDEO, IAMHPLKENKJ BFNHJCAHHAN, JHDPICMPNBI EEPMCAKKJEF, int DMCALPDPBPN, EKDPPHJHEGI LICJOHINBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x8958760", Offset = "0x8957560", VA = "0x188958760", Slot = "7")]
	[AsyncStateMachine(typeof(CMGNGJGIGIM))]
	protected override Task GGLIEJBDGBK(NPKOEGNGKDP CKGHDNAPCNB, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal abstract class OHHCPKKDMKF : NJDDNJPCANH
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class EMLFEAGECGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public OHHCPKKDMKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public NFIHJEAHFPH playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public EMLFEAGECGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x8955620", Offset = "0x8954420", VA = "0x188955620")]
		internal Task BKNELCJIJOI(EHDFINDMEJI<string>.NGEIFBMECIG postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x8955660", Offset = "0x8954460", VA = "0x188955660")]
		internal object FMFKOGAIJCJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct IAKNDDMNDJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public OHHCPKKDMKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public NPKOEGNGKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private EMLFEAGECGO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x895A4A0", Offset = "0x89592A0", VA = "0x18895A4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x895AE00", Offset = "0x8959C00", VA = "0x18895AE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct LIODBGOAFFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public EHDFINDMEJI<string>.NGEIFBMECIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public NFIHJEAHFPH playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public OHHCPKKDMKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x8964240", Offset = "0x8963040", VA = "0x188964240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x8964800", Offset = "0x8963600", VA = "0x188964800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x896AC20", Offset = "0x8969A20", VA = "0x18896AC20")]
	public OHHCPKKDMKF(Guid ALEMANCBDEO, IAMHPLKENKJ BFNHJCAHHAN, JHDPICMPNBI EEPMCAKKJEF, string NDFIAGIGCFJ, HOIOGHENLBA FPKOCILEBIL, bool HLIKCFEJIKD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x896A930", Offset = "0x8969730", VA = "0x18896A930", Slot = "7")]
	[AsyncStateMachine(typeof(IAKNDDMNDJB))]
	protected override Task GGLIEJBDGBK(NPKOEGNGKDP CKGHDNAPCNB, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task LEIFKBMEDLE(NPKOEGNGKDP CKGHDNAPCNB, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x896AA70", Offset = "0x8969870", VA = "0x18896AA70")]
	[AsyncStateMachine(typeof(LIODBGOAFFO))]
	private Task PIFEGAPEKFF(IDisposable KMBKCIKLBGF, NFIHJEAHFPH ONPGKDAGDFF, EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal class JGMDJNLFLAL : NJDDNJPCANH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct OFLLDIIGDKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public JGMDJNLFLAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public NPKOEGNGKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private TaskAwaiter<FMBJDHFAPIA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x896A2E0", Offset = "0x89690E0", VA = "0x18896A2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x896A8D0", Offset = "0x89696D0", VA = "0x18896A8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	private readonly AJHDCFJNACE IJMPHHBDLBM;

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x895EEC0", Offset = "0x895DCC0", VA = "0x18895EEC0")]
	public JGMDJNLFLAL(Guid ALEMANCBDEO, IAMHPLKENKJ BFNHJCAHHAN, JHDPICMPNBI EEPMCAKKJEF, AJHDCFJNACE IJMPHHBDLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x895ECC0", Offset = "0x895DAC0", VA = "0x18895ECC0", Slot = "6")]
	protected override string DJPCKICCONA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x895EDA0", Offset = "0x895DBA0", VA = "0x18895EDA0", Slot = "7")]
	[AsyncStateMachine(typeof(OFLLDIIGDKE))]
	protected override Task GGLIEJBDGBK(NPKOEGNGKDP CKGHDNAPCNB, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal abstract class NJDDNJPCANH : NHCDFALIEAO
{
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	public delegate Task AFEHIJMHJIB(EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class GNLJLGMHDBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public EHDFINDMEJI<string>.NGEIFBMECIG operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public NJDDNJPCANH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public GNLJLGMHDBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x8959870", Offset = "0x8958670", VA = "0x188959870")]
		internal Task LHIMEDJNOAC(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class NFJMANHHDDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public GNLJLGMHDBJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public NFJMANHHDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x89679D0", Offset = "0x89667D0", VA = "0x1889679D0")]
		internal object DLEPLAICDBA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct CDANBLLIMBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public NJDDNJPCANH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public Func<NJDDNJPCANH, EHDFINDMEJI<string>.NGEIFBMECIG, NPKOEGNGKDP> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private GNLJLGMHDBJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private NPKOEGNGKDP <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private TaskAwaiter<FGGKMIFBJPI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x8951100", Offset = "0x894FF00", VA = "0x188951100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x89523A0", Offset = "0x89511A0", VA = "0x1889523A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct BFIKMEOJCBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x8950540", Offset = "0x894F340", VA = "0x188950540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x8950FE0", Offset = "0x894FDE0", VA = "0x188950FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct ABDLPNEKKOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public NJDDNJPCANH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x894FE40", Offset = "0x894EC40", VA = "0x18894FE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x89501A0", Offset = "0x894EFA0", VA = "0x1889501A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public readonly Guid GGHLJDMBIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public readonly ByteString OMDPJGFBALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public readonly JHDPICMPNBI IICACKMHIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	protected readonly string DDKBNJEMKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private readonly IAMHPLKENKJ BFNHJCAHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private readonly bool HLIKCFEJIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private readonly Queue<AFEHIJMHJIB> HIOCJGGGCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private readonly HBGMKMHNODB ANEHMIEHPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private readonly HOIOGHENLBA FPKOCILEBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private bool ODBLDIFKHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public GFFKHEAOFOJ ONGGOIKJBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public GFFKHEAOFOJ NMMMDECLKCI;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public IAMHPLKENKJ HCBEGBGLEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public LGPCFOHIOOE HLIHHKGELEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x89684E0", Offset = "0x89672E0", VA = "0x1889684E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public JPEKCHMJINJ HIKCMFOFKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x8967D70", Offset = "0x8966B70", VA = "0x188967D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public KGJIHOMIGPB MFMKIIGCFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x8967DC0", Offset = "0x8966BC0", VA = "0x188967DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event NPDDMGKAAIH DPDGIENCCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x8967E40", Offset = "0x8966C40", VA = "0x188967E40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x8968620", Offset = "0x8967420", VA = "0x188968620", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x89686C0", Offset = "0x89674C0", VA = "0x1889686C0")]
	protected NJDDNJPCANH(Guid ALEMANCBDEO, IAMHPLKENKJ BFNHJCAHHAN, JHDPICMPNBI EEPMCAKKJEF, string NDFIAGIGCFJ, HOIOGHENLBA FPKOCILEBIL, bool HLIKCFEJIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x89680E0", Offset = "0x8966EE0", VA = "0x1889680E0", Slot = "6")]
	protected virtual string DJPCKICCONA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x8967B70", Offset = "0x8966970", VA = "0x188967B70")]
	public void AGOBLJNHFLK(AFEHIJMHJIB MHGAFFIJAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x89684C0", Offset = "0x89672C0", VA = "0x1889684C0")]
	protected void ICEJGLJKHKN(float JEDAAEHCPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x8967F90", Offset = "0x8966D90", VA = "0x188967F90")]
	[AsyncStateMachine(typeof(CDANBLLIMBC))]
	public Task DIEFFEOBOIO(CancellationToken HIMDFBHMPLL, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, [Optional] Func<NJDDNJPCANH, EHDFINDMEJI<string>.NGEIFBMECIG, NPKOEGNGKDP> PGKDPIKOACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x8967E60", Offset = "0x8966C60", VA = "0x188967E60")]
	[AsyncStateMachine(typeof(BFIKMEOJCBF))]
	private static Task CKAAIMPJIMN(Func<CancellationToken, Task> NKEODGLIGIJ, Func<CancellationToken, Task> ICDONGCDFJI, CancellationToken FOJIDEIIGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x8968350", Offset = "0x8967150", VA = "0x188968350")]
	private void GCPCJHKPILC(bool BIFFJAIGCIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x8968120", Offset = "0x8966F20", VA = "0x188968120")]
	private void EJHNFKGAALN(NPKOEGNGKDP CKGHDNAPCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task GGLIEJBDGBK(NPKOEGNGKDP CKGHDNAPCNB, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x8967C50", Offset = "0x8966A50", VA = "0x188967C50")]
	[AsyncStateMachine(typeof(ABDLPNEKKOH))]
	private Task AMPFBOFNDMB(EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x8968640", Offset = "0x8967440", VA = "0x188968640")]
	public FGGKMIFBJPI PAAMABDNLJF(ADMEBNGDCKJ OKJPEBAJBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x8968530", Offset = "0x8967330", VA = "0x188968530")]
	[CompilerGenerated]
	private Task JFBPDAPONGL(CancellationToken ODOKMLFIJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x8967BD0", Offset = "0x89669D0", VA = "0x188967BD0")]
	[CompilerGenerated]
	private object AHLMPHPDFFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal sealed class HKAJCPOFHPK : OHHCPKKDMKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct OJKIELFDMBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public HKAJCPOFHPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public NPKOEGNGKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private GOPOOGGIALC <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private IOHNKCADMCC <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x896AC70", Offset = "0x8969A70", VA = "0x18896AC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x896B3E0", Offset = "0x896A1E0", VA = "0x18896B3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private readonly NLIPGAAAAGA HMHPKOCJIDO;

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x895A2F0", Offset = "0x89590F0", VA = "0x18895A2F0")]
	public HKAJCPOFHPK(Guid ALEMANCBDEO, IAMHPLKENKJ BFNHJCAHHAN, NLIPGAAAAGA HMHPKOCJIDO, JHDPICMPNBI EEPMCAKKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x895A1A0", Offset = "0x8958FA0", VA = "0x18895A1A0", Slot = "8")]
	[AsyncStateMachine(typeof(OJKIELFDMBH))]
	protected override Task LEIFKBMEDLE(NPKOEGNGKDP CKGHDNAPCNB, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal class OLBLFPJBCML : NJDDNJPCANH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct JGCGIMFCIHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public OLBLFPJBCML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public NPKOEGNGKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private TaskAwaiter<FMBJDHFAPIA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x895E7D0", Offset = "0x895D5D0", VA = "0x18895E7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x895EC60", Offset = "0x895DA60", VA = "0x18895EC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private readonly string EGAIJLDAGHB;

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x896B550", Offset = "0x896A350", VA = "0x18896B550")]
	public OLBLFPJBCML(Guid ALEMANCBDEO, IAMHPLKENKJ BFNHJCAHHAN, JHDPICMPNBI EEPMCAKKJEF, string EGAIJLDAGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x896B440", Offset = "0x896A240", VA = "0x18896B440", Slot = "7")]
	[AsyncStateMachine(typeof(JGCGIMFCIHH))]
	protected override Task GGLIEJBDGBK(NPKOEGNGKDP CKGHDNAPCNB, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal class JHLPLKIOLIN : OHHCPKKDMKF
{
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private sealed class KDNKJKJJLND
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000134")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004B0")]
			public AsyncTaskMethodBuilder<FGGKMIFBJPI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			public KDNKJKJJLND <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			private TaskAwaiter<FMBJDHFAPIA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			private TaskAwaiter<FGGKMIFBJPI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0x896CA80", Offset = "0x896B880", VA = "0x18896CA80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0x896CF70", Offset = "0x896BD70", VA = "0x18896CF70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public JHLPLKIOLIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public NKINAFBDBPC serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public AKGLAIKGPKN roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public ENGKMPOGMEN uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public HANPKCOEGMA roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KDNKJKJJLND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x89614F0", Offset = "0x89602F0", VA = "0x1889614F0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<FGGKMIFBJPI> JGADIEGAOPA(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct LHMGOAOCLKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public JHLPLKIOLIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public NPKOEGNGKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private KDNKJKJJLND <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private GOPOOGGIALC <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private IOHNKCADMCC <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private FGGKMIFBJPI <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private TaskAwaiter<FGGKMIFBJPI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x89632F0", Offset = "0x89620F0", VA = "0x1889632F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x89641E0", Offset = "0x8962FE0", VA = "0x1889641E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	private static readonly PHLHEDGDBJO FBBIFJHMNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private readonly int EJENBHALFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	[CanBeNull]
	private readonly GAJAJCGPIFH LGBFOCAKECN;

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x895FBE0", Offset = "0x895E9E0", VA = "0x18895FBE0")]
	public JHLPLKIOLIN(Guid ALEMANCBDEO, IAMHPLKENKJ BFNHJCAHHAN, int EJENBHALFPN, GAJAJCGPIFH LGBFOCAKECN, JHDPICMPNBI EEPMCAKKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x895F9F0", Offset = "0x895E7F0", VA = "0x18895F9F0", Slot = "8")]
	[AsyncStateMachine(typeof(LHMGOAOCLKC))]
	protected override Task LEIFKBMEDLE(NPKOEGNGKDP CKGHDNAPCNB, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x895F8F0", Offset = "0x895E6F0", VA = "0x18895F8F0")]
	private void HJENKLPMCKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x895F720", Offset = "0x895E520", VA = "0x18895F720")]
	private void FJCPNCELOFF(EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, GOPOOGGIALC PIEALDOIJLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal class BCPDGLIGHPJ : NJDDNJPCANH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct MBILNDMJNNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public BCPDGLIGHPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private GOPOOGGIALC <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private FPNKDIBEOOD <currentRoomSave>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private NONKHMPPJIB<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private TaskAwaiter<FPNKDIBEOOD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private TaskAwaiter<AEFELCHEGKN> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private TaskAwaiter <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x8964980", Offset = "0x8963780", VA = "0x188964980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x8965DC0", Offset = "0x8964BC0", VA = "0x188965DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	private readonly int EJENBHALFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	private readonly GAJAJCGPIFH LGBFOCAKECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	private Func<FMBJDHFAPIA, FMBJDHFAPIA> HOKJJGOAHHD;

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x8950480", Offset = "0x894F280", VA = "0x188950480")]
	public BCPDGLIGHPJ(Guid ALEMANCBDEO, IAMHPLKENKJ BFNHJCAHHAN, int EJENBHALFPN, GAJAJCGPIFH LGBFOCAKECN, Func<FMBJDHFAPIA, FMBJDHFAPIA> HOKJJGOAHHD, JHDPICMPNBI EEPMCAKKJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x8950350", Offset = "0x894F150", VA = "0x188950350", Slot = "7")]
	[AsyncStateMachine(typeof(MBILNDMJNNA))]
	protected override Task GGLIEJBDGBK(NPKOEGNGKDP CKGHDNAPCNB, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal abstract class MNFNGMFCFBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public readonly NJDDNJPCANH DAHCGELOPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public readonly NPKOEGNGKDP GOGBFFHIPGE;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public LGPCFOHIOOE HLIHHKGELEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x8966920", Offset = "0x8965720", VA = "0x188966920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public KGJIHOMIGPB MFMKIIGCFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x8966890", Offset = "0x8965690", VA = "0x188966890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x8966A90", Offset = "0x8965890", VA = "0x188966A90")]
	protected MNFNGMFCFBJ(NPKOEGNGKDP CKGHDNAPCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x8966970", Offset = "0x8965770", VA = "0x188966970")]
	protected void OJKKHHLLEBA(string DOHAAKJINBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct FBEMFHJJCBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public Dictionary<Guid, List<LABOCDCFPDG>> KGDMOPKMHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public Dictionary<Guid, List<LABOCDCFPDG>> KFFAPJLOCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public Dictionary<Guid, List<LABOCDCFPDG>> BOPJDJFIOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public List<Guid> CELJAGFLLOE;

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x8957070", Offset = "0x8955E70", VA = "0x188957070")]
	public static FBEMFHJJCBL LHCLHJGACJJ(LGPCFOHIOOE JBNGHMBPLHF, GFFKHEAOFOJ MAPHKMILNHA, EIPHABKKBFG OCKOIJNHFNG)
	{
		return default(FBEMFHJJCBL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct EHLMOOOEFKE
{
	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480")]
	public static EHLMOOOEFKE LDFHHMLGJNG()
	{
		return default(EHLMOOOEFKE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct KFCNEKKBOAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public readonly AACPGJNOFJH OKIMGMJFNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public readonly EJHPEGDEELG AFHBEOHEFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public readonly Guid? COBCHIDBIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public readonly IReadOnlyCollection<AJBFPABIEDC> LCBBEPHPGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public readonly IReadOnlyCollection<AJBFPABIEDC> JKEINEDOMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public readonly MFCKDCKCJFL NOAJNBLGDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public readonly MFCKDCKCJFL MGNGLPCCMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public readonly OGKANJAJEAE CAPDJOOOCLC;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool CFOKPMCDJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x8961610", Offset = "0x8960410", VA = "0x188961610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x89616A0", Offset = "0x89604A0", VA = "0x1889616A0")]
	public KFCNEKKBOAD(AACPGJNOFJH OKIMGMJFNAN, EJHPEGDEELG AFHBEOHEFPP, Guid? COBCHIDBIBM, IReadOnlyList<AJBFPABIEDC> LCBBEPHPGBM, IReadOnlyCollection<AJBFPABIEDC> JKEINEDOMEM, MFCKDCKCJFL NOAJNBLGDKM, MFCKDCKCJFL MGNGLPCCMFF, OGKANJAJEAE CAPDJOOOCLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct IKOMNOJMJCJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private readonly NPKOEGNGKDP CKGHDNAPCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private readonly Guid ALPNJHDBADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private bool BIFFJAIGCIP;

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x895BF90", Offset = "0x895AD90", VA = "0x18895BF90")]
	public static IKOMNOJMJCJ DJDHPHGMGOB(NPKOEGNGKDP CKGHDNAPCNB)
	{
		return default(IKOMNOJMJCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x13033A0", Offset = "0x13021A0", VA = "0x1813033A0")]
	public void BNBHECCOKHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x895BFC0", Offset = "0x895ADC0", VA = "0x18895BFC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x895C070", Offset = "0x895AE70", VA = "0x18895C070")]
	private IKOMNOJMJCJ(NPKOEGNGKDP CKGHDNAPCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x895BD50", Offset = "0x895AB50", VA = "0x18895BD50")]
	private void BADBHGJCCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x895BFD0", Offset = "0x895ADD0", VA = "0x18895BFD0")]
	private Func<Guid, bool> EDIJJCOOKOG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
internal class IOHNKCADMCC : MNFNGMFCFBJ, NHCDFALIEAO
{
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	public delegate Task<GFFKHEAOFOJ> EHFHECJIGLI(EIPHABKKBFG BOIPFNOKGBJ, KBIBHABDIIC FCACNOPIDLG, HBGMKMHNODB KMFPAFFBLBH, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct PKJIGNJMOFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public NLIPGAAAAGA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private IKOMNOJMJCJ <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private TaskAwaiter<FGGKMIFBJPI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x897FD30", Offset = "0x897EB30", VA = "0x18897FD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x8980470", Offset = "0x897F270", VA = "0x188980470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct LFDOJOCECLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public AsyncTaskMethodBuilder<FGGKMIFBJPI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public NLIPGAAAAGA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private TaskAwaiter<FGGKMIFBJPI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x897A5F0", Offset = "0x89793F0", VA = "0x18897A5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x897AA20", Offset = "0x8979820", VA = "0x18897AA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct AJGPPODGIML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public NLIPGAAAAGA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x896E2D0", Offset = "0x896D0D0", VA = "0x18896E2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x896E790", Offset = "0x896D590", VA = "0x18896E790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class ENLFOGHFGCE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000144")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public AsyncTaskMethodBuilder<KFCNEKKBOAD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			public ENLFOGHFGCE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			private KFCNEKKBOAD <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			private TaskAwaiter<GFFKHEAOFOJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000516")]
			private TaskAwaiter<KFCNEKKBOAD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x8982D70", Offset = "0x8981B70", VA = "0x188982D70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x8983630", Offset = "0x8982430", VA = "0x188983630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000145")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000517")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000518")]
			public AsyncTaskMethodBuilder<EIPHABKKBFG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000519")]
			public ENLFOGHFGCE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400051A")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400051B")]
			private EIPHABKKBFG <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			private TaskAwaiter<GFFKHEAOFOJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			private TaskAwaiter<EIPHABKKBFG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x89836A0", Offset = "0x89824A0", VA = "0x1889836A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x8983CF0", Offset = "0x8982AF0", VA = "0x188983CF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public NLIPGAAAAGA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public HBGMKMHNODB preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public HBGMKMHNODB downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public KFCNEKKBOAD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public HBGMKMHNODB postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public EIPHABKKBFG phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public CPNKCMLPCHO.BCNKMIJPOCG <>9__5;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public ENLFOGHFGCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x8971890", Offset = "0x8970690", VA = "0x188971890")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<KFCNEKKBOAD> ICHOOAAOBBI(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x89716F0", Offset = "0x89704F0", VA = "0x1889716F0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<EIPHABKKBFG> DLDANDDDIIA(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x8971850", Offset = "0x8970650", VA = "0x188971850")]
		internal void FEOGFCKLOJD(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x8971810", Offset = "0x8970610", VA = "0x188971810")]
		internal Task ELCLBDMCING(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x89719E0", Offset = "0x89707E0", VA = "0x1889719E0")]
		internal Task IFHEICNPHFD(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct PEPJAACOBBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public NLIPGAAAAGA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private ENLFOGHFGCE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter<KFCNEKKBOAD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private TaskAwaiter<EIPHABKKBFG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x897EEA0", Offset = "0x897DCA0", VA = "0x18897EEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x897FB70", Offset = "0x897E970", VA = "0x18897FB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct FCCIFOOCEBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public EIPHABKKBFG phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public HBGMKMHNODB postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private TaskAwaiter<GFFKHEAOFOJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private KBIBHABDIIC <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x8971A20", Offset = "0x8970820", VA = "0x188971A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x8972880", Offset = "0x8971680", VA = "0x188972880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct GOBCIHDMBOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public EHDFINDMEJI<string>.NGEIFBMECIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x8974CB0", Offset = "0x8973AB0", VA = "0x188974CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x8975490", Offset = "0x8974290", VA = "0x188975490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct GHNPGMMDBCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public HBGMKMHNODB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private TaskAwaiter<GFFKHEAOFOJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x8973940", Offset = "0x8972740", VA = "0x188973940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x8974180", Offset = "0x8972F80", VA = "0x188974180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct PLNHAALDING : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public AsyncTaskMethodBuilder<GFFKHEAOFOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public HBGMKMHNODB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private TaskAwaiter<GFFKHEAOFOJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x8981210", Offset = "0x8980010", VA = "0x188981210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x89821D0", Offset = "0x8980FD0", VA = "0x1889821D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct NKNIMMIJCNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public AsyncTaskMethodBuilder<GFFKHEAOFOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public HBGMKMHNODB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public KBIBHABDIIC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private TaskAwaiter<GFFKHEAOFOJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x897C910", Offset = "0x897B710", VA = "0x18897C910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x897DA20", Offset = "0x897C820", VA = "0x18897DA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct HACJIGKPIPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public AsyncTaskMethodBuilder<GFFKHEAOFOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public GFFKHEAOFOJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public HBGMKMHNODB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public EIPHABKKBFG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter<GFFKHEAOFOJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x89754F0", Offset = "0x89742F0", VA = "0x1889754F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x8975750", Offset = "0x8974550", VA = "0x188975750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class KKNJDKLGDCJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014F")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			public AsyncTaskMethodBuilder<GFFKHEAOFOJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			public KKNJDKLGDCJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			private HICKLFFFPPA <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			private TaskAwaiter<GFFKHEAOFOJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x8983D60", Offset = "0x8982B60", VA = "0x188983D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x8984390", Offset = "0x8983190", VA = "0x188984390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public HBGMKMHNODB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public EHFHECJIGLI masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public KBIBHABDIIC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public GFFKHEAOFOJ originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KKNJDKLGDCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x897A240", Offset = "0x8979040", VA = "0x18897A240")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<GFFKHEAOFOJ> GFIKBOBHOJC(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct EBKMJDFDJNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public AsyncTaskMethodBuilder<GFFKHEAOFOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public HBGMKMHNODB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public EHFHECJIGLI masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public KBIBHABDIIC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private TaskAwaiter<GFFKHEAOFOJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x8970E10", Offset = "0x896FC10", VA = "0x188970E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x8971330", Offset = "0x8970130", VA = "0x188971330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct CGOCBDMGJJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public HBGMKMHNODB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private GFFKHEAOFOJ <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private IEnumerator<GFFKHEAOFOJ> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private TaskAwaiter<GFFKHEAOFOJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x8970140", Offset = "0x896EF40", VA = "0x188970140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x89706A0", Offset = "0x896F4A0", VA = "0x1889706A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct JHGCFIALCJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x8978ED0", Offset = "0x8977CD0", VA = "0x188978ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x89791C0", Offset = "0x8977FC0", VA = "0x1889791C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct LCPADIEDJAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x897A360", Offset = "0x8979160", VA = "0x18897A360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x897A590", Offset = "0x8979390", VA = "0x18897A590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class PKHHOFKHDNM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000155")]
		private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			public AsyncTaskMethodBuilder<GFFKHEAOFOJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			public PKHHOFKHDNM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			public EIPHABKKBFG data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400059B")]
			public HBGMKMHNODB progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400059C")]
			public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400059D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			private TaskAwaiter<GFFKHEAOFOJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			private TaskAwaiter<FFKAMMEFNKE> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x8984400", Offset = "0x8983200", VA = "0x188984400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x8984ED0", Offset = "0x8983CD0", VA = "0x188984ED0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public KNCFPDKBHDF mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public PKHHOFKHDNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x897FBD0", Offset = "0x897E9D0", VA = "0x18897FBD0")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<GFFKHEAOFOJ> JPKMIKIPNHG(EIPHABKKBFG data, KBIBHABDIIC _, HBGMKMHNODB progressTracker, EHDFINDMEJI<string>.NGEIFBMECIG stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct HOKDABAEGJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public EIPHABKKBFG phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public HBGMKMHNODB postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private PKHHOFKHDNM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private KBIBHABDIIC <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter<GFFKHEAOFOJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x89770F0", Offset = "0x8975EF0", VA = "0x1889770F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x8977F40", Offset = "0x8976D40", VA = "0x188977F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct FJKMEOOAMGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x8972FF0", Offset = "0x8971DF0", VA = "0x188972FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x89733F0", Offset = "0x89721F0", VA = "0x1889733F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct CNFMBLJEEMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public AsyncTaskMethodBuilder<GFFKHEAOFOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public IOHNKCADMCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public HBGMKMHNODB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private TaskAwaiter<GFFKHEAOFOJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x8970700", Offset = "0x896F500", VA = "0x188970700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x8970D20", Offset = "0x896FB20", VA = "0x188970D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private readonly NLHHJHMMPAF LAGPLOPKOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private readonly NLHHJHMMPAF PHCODILJLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private readonly PPEDIAHNHEB MCJJCFBAPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private readonly BNNIMHFJNDJ ACOIBLJPMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private readonly GBGIALEOKMB EFHDHEFJGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private ProfilerCounterValue<int> FEGHICPJEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private readonly AOCMPNLIOFK LEFEHDCFIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private readonly ELFNFNHPMNK DIKKAKOJDJG;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private IAMHPLKENKJ HCBEGBGLEGG
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x895DA00", Offset = "0x895C800", VA = "0x18895DA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event NPDDMGKAAIH DPDGIENCCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x895C6C0", Offset = "0x895B4C0", VA = "0x18895C6C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x895D750", Offset = "0x895C550", VA = "0x18895D750", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x895DDD0", Offset = "0x895CBD0", VA = "0x18895DDD0")]
	public IOHNKCADMCC(NPKOEGNGKDP CKGHDNAPCNB, ELFNFNHPMNK DIKKAKOJDJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x895D250", Offset = "0x895C050", VA = "0x18895D250")]
	[AsyncStateMachine(typeof(PKJIGNJMOFK))]
	public Task KNGDPGBHFLC(NLIPGAAAAGA OHNONCFAIKH, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x895D770", Offset = "0x895C570", VA = "0x18895D770")]
	[AsyncStateMachine(typeof(LFDOJOCECLJ))]
	private Task<FGGKMIFBJPI> NCNODKGOLIH(NLIPGAAAAGA OHNONCFAIKH, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x895C770", Offset = "0x895B570", VA = "0x18895C770")]
	[AsyncStateMachine(typeof(AJGPPODGIML))]
	private Task ENLMLOLMGGL(NLIPGAAAAGA OHNONCFAIKH, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x895D4B0", Offset = "0x895C2B0", VA = "0x18895D4B0")]
	[AsyncStateMachine(typeof(PEPJAACOBBE))]
	private Task MAONCJKGPED(NLIPGAAAAGA OHNONCFAIKH, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken BLBBEBFDGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x895DB90", Offset = "0x895C990", VA = "0x18895DB90")]
	[AsyncStateMachine(typeof(FCCIFOOCEBL))]
	private Task OFIIHEBICNO(EIPHABKKBFG BADFBKHEOPI, HBGMKMHNODB LAALLGMMCAM, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken LBIOMPGIELB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x895D640", Offset = "0x895C440", VA = "0x18895D640")]
	[AsyncStateMachine(typeof(GOBCIHDMBOK))]
	private Task MEGPFADMFLE(EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x895C530", Offset = "0x895B330", VA = "0x18895C530")]
	[AsyncStateMachine(typeof(GHNPGMMDBCL))]
	private Task CBHOCEINNFM(EIPHABKKBFG BOIPFNOKGBJ, HBGMKMHNODB KMFPAFFBLBH, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x895DA30", Offset = "0x895C830", VA = "0x18895DA30")]
	[AsyncStateMachine(typeof(PLNHAALDING))]
	private Task<GFFKHEAOFOJ> NPOAGFMBFPN(EIPHABKKBFG BOIPFNOKGBJ, KBIBHABDIIC AMFPCODGPAL, HBGMKMHNODB KMFPAFFBLBH, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x895C8B0", Offset = "0x895B6B0", VA = "0x18895C8B0")]
	[AsyncStateMachine(typeof(NKNIMMIJCNG))]
	private Task<GFFKHEAOFOJ> FHJMLIJMIHF(EIPHABKKBFG BOIPFNOKGBJ, KBIBHABDIIC AMFPCODGPAL, HBGMKMHNODB KMFPAFFBLBH, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x895D0B0", Offset = "0x895BEB0", VA = "0x18895D0B0")]
	[AsyncStateMachine(typeof(HACJIGKPIPH))]
	private Task<GFFKHEAOFOJ> KBCJLHJMDON(GFFKHEAOFOJ MAPHKMILNHA, EIPHABKKBFG OCKOIJNHFNG, HBGMKMHNODB KMFPAFFBLBH, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL, bool LONCPHFEFMG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x895DCE0", Offset = "0x895CAE0", VA = "0x18895DCE0")]
	private bool PGPOOFMCCCP(EIPHABKKBFG BADFBKHEOPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x895CA30", Offset = "0x895B830", VA = "0x18895CA30")]
	[AsyncStateMachine(typeof(EBKMJDFDJNF))]
	protected Task<GFFKHEAOFOJ> HCNGNGBLAKH(EIPHABKKBFG BOIPFNOKGBJ, KBIBHABDIIC AMFPCODGPAL, HBGMKMHNODB KMFPAFFBLBH, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL, EHFHECJIGLI CLJGFDGMCMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x895CBC0", Offset = "0x895B9C0", VA = "0x18895CBC0")]
	[AsyncStateMachine(typeof(CGOCBDMGJJH))]
	private Task HCNPDEIEOHI(EIPHABKKBFG BOIPFNOKGBJ, HBGMKMHNODB KMFPAFFBLBH, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x895C6E0", Offset = "0x895B4E0", VA = "0x18895C6E0")]
	private void DHDNOMAPGGL(GFFKHEAOFOJ CHNOBNEEJEK, HBGMKMHNODB KMFPAFFBLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x895C730", Offset = "0x895B530", VA = "0x18895C730")]
	private void DONEEENNPEG(GFFKHEAOFOJ LINOOMKPGDK, [Out] GFFKHEAOFOJ AKMNCLOOKJI, [Out] GFFKHEAOFOJ LCPCHEEOKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x895C4F0", Offset = "0x895B2F0", VA = "0x18895C4F0")]
	private Task<KFCNEKKBOAD> CBBOLGIEOPP(NLIPGAAAAGA OHNONCFAIKH, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x895C680", Offset = "0x895B480", VA = "0x18895C680")]
	private Task<EIPHABKKBFG> CCLNKBIDGNK(KFCNEKKBOAD BOIPFNOKGBJ, CPNKCMLPCHO.BCNKMIJPOCG HOBJJPMKMPE, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x895C3A0", Offset = "0x895B1A0", VA = "0x18895C3A0")]
	[AsyncStateMachine(typeof(JHGCFIALCJN))]
	private Task BDPHLIFGJOE(EIPHABKKBFG BOIPFNOKGBJ, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL, bool KOHOOLHJGFL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x895D3A0", Offset = "0x895C1A0", VA = "0x18895D3A0")]
	[AsyncStateMachine(typeof(LCPADIEDJAO))]
	private Task LDLPCNBFADI(EIPHABKKBFG BOIPFNOKGBJ, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x895CD30", Offset = "0x895BB30", VA = "0x18895CD30")]
	private Task HEMCCGHLFLI(EIPHABKKBFG BOIPFNOKGBJ, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x895D230", Offset = "0x895C030", VA = "0x18895D230")]
	private Task KBOFAPEOGMJ(EIPHABKKBFG BOIPFNOKGBJ, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x895CD10", Offset = "0x895BB10", VA = "0x18895CD10")]
	private Task HDBCIEFJLEA(EIPHABKKBFG BOIPFNOKGBJ, KBIBHABDIIC AMFPCODGPAL, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x895D490", Offset = "0x895C290", VA = "0x18895D490")]
	private Task LGHJHJEEMHB(EIPHABKKBFG BOIPFNOKGBJ, KBIBHABDIIC AMFPCODGPAL, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x895D8D0", Offset = "0x895C6D0", VA = "0x18895D8D0")]
	private static Task NHEMPHLCNGL(CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x895C210", Offset = "0x895B010", VA = "0x18895C210")]
	private Task AABJELJNMMF(EIPHABKKBFG BOIPFNOKGBJ, KBIBHABDIIC AMFPCODGPAL, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x895C380", Offset = "0x895B180", VA = "0x18895C380")]
	private Task ALOMBOBENMK(EIPHABKKBFG BOIPFNOKGBJ, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x895D5F0", Offset = "0x895C3F0", VA = "0x18895D5F0")]
	private void MEEPCBHILEC(NLIPGAAAAGA OHNONCFAIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x895CEA0", Offset = "0x895BCA0", VA = "0x18895CEA0")]
	public void JGAFKJAJJDB(long CHOOOGFBFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	private static void JPABCDFBGFI(AACPGJNOFJH OKIMGMJFNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x895C230", Offset = "0x895B030", VA = "0x18895C230")]
	[AsyncStateMachine(typeof(HOKDABAEGJG))]
	private Task AGAJLBIHIMJ(EIPHABKKBFG BADFBKHEOPI, HBGMKMHNODB LAALLGMMCAM, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken LBIOMPGIELB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x895CD60", Offset = "0x895BB60", VA = "0x18895CD60")]
	[AsyncStateMachine(typeof(FJKMEOOAMGO))]
	private Task HMEDDKEIOFL(EIPHABKKBFG BOIPFNOKGBJ, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x895D8E0", Offset = "0x895C6E0", VA = "0x18895D8E0")]
	private static NPBBPECINAL NIBMEANLKMB(EIPHABKKBFG OCKOIJNHFNG)
	{
		return default(NPBBPECINAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x895CF50", Offset = "0x895BD50", VA = "0x18895CF50")]
	[AsyncStateMachine(typeof(CNFMBLJEEMB))]
	private Task<GFFKHEAOFOJ> JIPGGJGOFEK(EIPHABKKBFG BOIPFNOKGBJ, KBIBHABDIIC AMFPCODGPAL, HBGMKMHNODB KMFPAFFBLBH, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	private void AAIGABPEHAF(GFFKHEAOFOJ FCGBCIFDNGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct EEPLMLJNHAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	private IAMHPLKENKJ BFNHJCAHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	private EIPHABKKBFG BOIPFNOKGBJ;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private LGPCFOHIOOE HLIHHKGELEG
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x89716A0", Offset = "0x89704A0", VA = "0x1889716A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x89713A0", Offset = "0x89701A0", VA = "0x1889713A0")]
	public static Task DIEFFEOBOIO(IAMHPLKENKJ BFNHJCAHHAN, EIPHABKKBFG BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x8971480", Offset = "0x8970280", VA = "0x188971480")]
	private void DIEFFEOBOIO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct NNOPIMHJNHA
{
	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x897E8E0", Offset = "0x897D6E0", VA = "0x18897E8E0")]
	public static Task DIEFFEOBOIO(CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal struct BKOJNDEJLDI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct GMGNEPNEEFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public NPKOEGNGKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x8974720", Offset = "0x8973520", VA = "0x188974720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x8974C50", Offset = "0x8973A50", VA = "0x188974C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x896EAC0", Offset = "0x896D8C0", VA = "0x18896EAC0")]
	[AsyncStateMachine(typeof(GMGNEPNEEFI))]
	public static Task DIEFFEOBOIO(NPKOEGNGKDP CKGHDNAPCNB, EIPHABKKBFG BOIPFNOKGBJ, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct MGJAMOJBNCN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct PKJLBDEFLNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public NPKOEGNGKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public KBIBHABDIIC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private IAMHPLKENKJ <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private LGPCFOHIOOE <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private GFFKHEAOFOJ <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private HICKLFFFPPA <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private List<(PersistenceView, CDOFHMONKPD)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private CDOFHMONKPD <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x89804D0", Offset = "0x897F2D0", VA = "0x1889804D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x89811B0", Offset = "0x897FFB0", VA = "0x1889811B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x897AF90", Offset = "0x8979D90", VA = "0x18897AF90")]
	[AsyncStateMachine(typeof(PKJLBDEFLNJ))]
	public static Task DIEFFEOBOIO(NPKOEGNGKDP CKGHDNAPCNB, EIPHABKKBFG BOIPFNOKGBJ, KBIBHABDIIC AMFPCODGPAL, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x897B0E0", Offset = "0x8979EE0", VA = "0x18897B0E0")]
	private static void DOHFDJMNCPO(PersistenceView LNFFCKNEJCB, CDOFHMONKPD FKPLGDJFALO, EIPHABKKBFG BOIPFNOKGBJ, GFFKHEAOFOJ MAPHKMILNHA, bool MKHNHOGOHMC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct PNMNOKMOHPB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct AHMMNKJOBNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public IAMHPLKENKJ roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private HICKLFFFPPA <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x896DC50", Offset = "0x896CA50", VA = "0x18896DC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x896E270", Offset = "0x896D070", VA = "0x18896E270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x8982240", Offset = "0x8981040", VA = "0x188982240")]
	[AsyncStateMachine(typeof(AHMMNKJOBNB))]
	public static Task DIEFFEOBOIO(IAMHPLKENKJ BFNHJCAHHAN, EIPHABKKBFG BOIPFNOKGBJ, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal struct HLBAPJPFFEA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct JBBGNJENMCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public IAMHPLKENKJ roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public NPKOEGNGKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x8977FF0", Offset = "0x8976DF0", VA = "0x188977FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x8978200", Offset = "0x8977000", VA = "0x188978200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class MPAKDOCHMGP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000165")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005F1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005F2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F3")]
			public EHDFINDMEJI<string>.NGEIFBMECIG timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005F4")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			public MPAKDOCHMGP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005F7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x8984F40", Offset = "0x8983D40", VA = "0x188984F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x89852D0", Offset = "0x89840D0", VA = "0x1889852D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public MPAKDOCHMGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x897B2E0", Offset = "0x897A0E0", VA = "0x18897B2E0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task BAAFBPDGDAI(EHDFINDMEJI<string>.NGEIFBMECIG timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct JBKBCCLOHFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public HLBAPJPFFEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private HICKLFFFPPA <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private TaskAwaiter<FGGKMIFBJPI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x8978260", Offset = "0x8977060", VA = "0x188978260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x8978E70", Offset = "0x8977C70", VA = "0x188978E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class BMDAPBGCGKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public NPIADBPPJMB version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public BMDAPBGCGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x896EF90", Offset = "0x896DD90", VA = "0x18896EF90")]
		internal object FANPANNCPNL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x896F070", Offset = "0x896DE70", VA = "0x18896F070")]
		internal object JBBBJOIGKIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private IAMHPLKENKJ BFNHJCAHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private EIPHABKKBFG BOIPFNOKGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private NPKOEGNGKDP CKGHDNAPCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private bool KOHOOLHJGFL;

	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private static readonly ByteString BMILJDKBLEE;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private LGPCFOHIOOE HLIHHKGELEG
	{
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x8976990", Offset = "0x8975790", VA = "0x188976990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private KGJIHOMIGPB MFMKIIGCFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x8976670", Offset = "0x8975470", VA = "0x188976670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x8976710", Offset = "0x8975510", VA = "0x188976710")]
	[AsyncStateMachine(typeof(JBBGNJENMCM))]
	public static Task DIEFFEOBOIO(IAMHPLKENKJ BFNHJCAHHAN, EIPHABKKBFG BOIPFNOKGBJ, NPKOEGNGKDP CKGHDNAPCNB, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL, bool KOHOOLHJGFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x8976860", Offset = "0x8975660", VA = "0x188976860")]
	[AsyncStateMachine(typeof(JBKBCCLOHFB))]
	private Task DIEFFEOBOIO(EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x8975E90", Offset = "0x8974C90", VA = "0x188975E90")]
	private void CFODPPNNKLH([NotNull] IMABAOJCLFC AACKIOLKKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x89769E0", Offset = "0x89757E0", VA = "0x1889769E0")]
	private bool MKIIJHBEMIO(NPIADBPPJMB DMIBKIHBLCP, IMABAOJCLFC AACKIOLKKKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct BMJDCOAHDPA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct NMHJPKPEMHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public AsyncTaskMethodBuilder<EIPHABKKBFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public BMJDCOAHDPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public CPNKCMLPCHO.BCNKMIJPOCG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private TaskAwaiter<IReadOnlyCollection<AJBFPABIEDC>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private TaskAwaiter<(CKPFCFEHEPP<NGMGMFNJOFA, BHGDKCCPEDL>, CKPFCFEHEPP<DFNOANMHPNJ<IMABAOJCLFC>, BHGDKCCPEDL>, CKPFCFEHEPP<DFNOANMHPNJ<CPDFLLLEANH>, BHGDKCCPEDL>, CKPFCFEHEPP<DFNOANMHPNJ<IEnumerable<NMGBCEEGCOL>>, BHGDKCCPEDL>, CKPFCFEHEPP<DFNOANMHPNJ<HDFBKAHFHIL>, BHGDKCCPEDL>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x897DA90", Offset = "0x897C890", VA = "0x18897DA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x897E870", Offset = "0x897D670", VA = "0x18897E870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct HJMCJGOPBNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public AsyncTaskMethodBuilder<CKPFCFEHEPP<NGMGMFNJOFA, BHGDKCCPEDL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public EHDFINDMEJI<string>.NGEIFBMECIG downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public BMJDCOAHDPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public IReadOnlyCollection<AJBFPABIEDC> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public IReadOnlyCollection<AJBFPABIEDC> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public CPNKCMLPCHO.BCNKMIJPOCG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private TaskAwaiter<CKPFCFEHEPP<NGMGMFNJOFA, BHGDKCCPEDL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x89757C0", Offset = "0x89745C0", VA = "0x1889757C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x8975E20", Offset = "0x8974C20", VA = "0x188975E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private CODFOIDDMOC<MFCKDCKCJFL, CPDFLLLEANH> FBABHGFBICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private CODFOIDDMOC<MFCKDCKCJFL, IMABAOJCLFC> ENIFHGBDBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	private CODFOIDDMOC<OGKANJAJEAE, IEnumerable<NMGBCEEGCOL>> MDIOJMODFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private CODFOIDDMOC<long, HDFBKAHFHIL> HFDBALNLBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private OJJNCLDHGBH BPNAPKDHMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private AACPGJNOFJH OKIMGMJFNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private EJHPEGDEELG AFHBEOHEFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private Guid? COBCHIDBIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	private IReadOnlyCollection<AJBFPABIEDC> LCBBEPHPGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000610")]
	private Task<IReadOnlyCollection<AJBFPABIEDC>> BJJBMDBBGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	private MFCKDCKCJFL NOAJNBLGDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private MFCKDCKCJFL MGNGLPCCMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	private MFCKDCKCJFL? KEDPAJJLCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	private OGKANJAJEAE CAPDJOOOCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x896F120", Offset = "0x896DF20", VA = "0x18896F120")]
	public static Task<EIPHABKKBFG> ANFJADIADBG(IAMHPLKENKJ BFNHJCAHHAN, [In] KFCNEKKBOAD BOIPFNOKGBJ, CPNKCMLPCHO.BCNKMIJPOCG HOBJJPMKMPE, EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x896F5C0", Offset = "0x896E3C0", VA = "0x18896F5C0")]
	[AsyncStateMachine(typeof(NMHJPKPEMHE))]
	private Task<EIPHABKKBFG> DIEFFEOBOIO(CPNKCMLPCHO.BCNKMIJPOCG HOBJJPMKMPE, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x896F770", Offset = "0x896E570", VA = "0x18896F770")]
	[AsyncStateMachine(typeof(HJMCJGOPBNP))]
	private Task<CKPFCFEHEPP<NGMGMFNJOFA, BHGDKCCPEDL>> NAIKFPKOBBF(Guid? COBCHIDBIBM, IReadOnlyCollection<AJBFPABIEDC> LCBBEPHPGBM, IReadOnlyCollection<AJBFPABIEDC> JKEINEDOMEM, long? NCGHDDJNJOM, long? HEPLHKILNBD, CPNKCMLPCHO.BCNKMIJPOCG HOBJJPMKMPE, EHDFINDMEJI<string>.NGEIFBMECIG BPJFPPPIABE, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal struct FFGGMLCNBML
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct NGKIBKKCONL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public AsyncTaskMethodBuilder<KFCNEKKBOAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public FFGGMLCNBML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private TaskAwaiter<KFCNEKKBOAD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x897BC60", Offset = "0x897AA60", VA = "0x18897BC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x897C0B0", Offset = "0x897AEB0", VA = "0x18897C0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct FOMICCDKKLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public AsyncTaskMethodBuilder<KFCNEKKBOAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public FFGGMLCNBML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		private TaskAwaiter<KFCNEKKBOAD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x8973450", Offset = "0x8972250", VA = "0x188973450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x89738D0", Offset = "0x89726D0", VA = "0x1889738D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class AJJMOMDHHJC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016F")]
		private struct <<FetchRoomLoadDetails>g__getRoomSaveData|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000652")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000653")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000654")]
			public AJJMOMDHHJC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000656")]
			private TaskAwaiter<BHOCDPCCCDL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000657")]
			private TaskAwaiter<FPNKDIBEOOD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x8982360", Offset = "0x8981160", VA = "0x188982360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x8982D10", Offset = "0x8981B10", VA = "0x188982D10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public MOHNFINFDFF roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public LGPCFOHIOOE callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public MFCKDCKCJFL superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public MFCKDCKCJFL subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public IReadOnlyList<AJBFPABIEDC> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public IReadOnlyList<AJBFPABIEDC> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public AACPGJNOFJH roomDetails;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public AJJMOMDHHJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xFAB770", Offset = "0xFAA570", VA = "0x180FAB770")]
		internal bool KHEELBPPNDD(EJHPEGDEELG sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x896E9F0", Offset = "0x896D7F0", VA = "0x18896E9F0")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task ILKMIJKAIGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x896E7F0", Offset = "0x896D5F0", VA = "0x18896E7F0")]
		internal Task<OGKANJAJEAE> EJGCGBJPAMM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct JMJJAMHAOKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public AsyncTaskMethodBuilder<KFCNEKKBOAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public MOHNFINFDFF roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public LGPCFOHIOOE callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public MFCKDCKCJFL superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private AJJMOMDHHJC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private EJHPEGDEELG <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private Task<OGKANJAJEAE> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private TaskAwaiter<AACPGJNOFJH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private TaskAwaiter<OGKANJAJEAE> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x8979220", Offset = "0x8978020", VA = "0x188979220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x897A1D0", Offset = "0x8978FD0", VA = "0x18897A1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	private LGPCFOHIOOE JBNGHMBPLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	private PPEDIAHNHEB MCJJCFBAPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	private MOHNFINFDFF FOAIFJJMCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private long NCGHDDJNJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private long KAAGEAEADCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	private long HFGFHGICNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	private string JFBBAOMPOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private MFCKDCKCJFL DMHJLNAAGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private Guid FBDPLFFNIML;

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x89728E0", Offset = "0x89716E0", VA = "0x1889728E0")]
	public static Task<KFCNEKKBOAD> ANFJADIADBG(IAMHPLKENKJ BFNHJCAHHAN, NLIPGAAAAGA OHNONCFAIKH, EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x8972E70", Offset = "0x8971C70", VA = "0x188972E70")]
	[AsyncStateMachine(typeof(NGKIBKKCONL))]
	private Task<KFCNEKKBOAD> DIEFFEOBOIO(CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x8972D00", Offset = "0x8971B00", VA = "0x188972D00")]
	[AsyncStateMachine(typeof(FOMICCDKKLO))]
	private Task<KFCNEKKBOAD> CBBOLGIEOPP(EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x8972B30", Offset = "0x8971930", VA = "0x188972B30")]
	[AsyncStateMachine(typeof(JMJJAMHAOKK))]
	private static Task<KFCNEKKBOAD> CBBOLGIEOPP(LGPCFOHIOOE JBNGHMBPLHF, MOHNFINFDFF FOAIFJJMCLD, long NCGHDDJNJOM, long KAAGEAEADCM, long HFGFHGICNFF, string JFBBAOMPOPG, MFCKDCKCJFL DMHJLNAAGKE, Guid FBDPLFFNIML, CancellationToken HIMDFBHMPLL, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x8972FC0", Offset = "0x8971DC0", VA = "0x188972FC0")]
	private void KJMEGNEDMBK(AACPGJNOFJH OKIMGMJFNAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
internal struct HNAIJKNPDFF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct AABPNDCMFFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public HNAIJKNPDFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x896D660", Offset = "0x896C460", VA = "0x18896D660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x896DBF0", Offset = "0x896C9F0", VA = "0x18896DBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private LGPCFOHIOOE JBNGHMBPLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private EIPHABKKBFG BOIPFNOKGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private float GMDBKGMMEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private float FFPFHMLKFJL;

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x8976BD0", Offset = "0x89759D0", VA = "0x188976BD0")]
	public static Task DOHIJNJKEGK(IAMHPLKENKJ BFNHJCAHHAN, EIPHABKKBFG BOIPFNOKGBJ, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x8976AB0", Offset = "0x89758B0", VA = "0x188976AB0")]
	[AsyncStateMachine(typeof(AABPNDCMFFM))]
	public Task DIEFFEOBOIO(CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x8976D70", Offset = "0x8975B70", VA = "0x188976D70")]
	private static void FEJLCNDEHEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x8976F90", Offset = "0x8975D90", VA = "0x188976F90")]
	private void NDOJIFMJGFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x8976EB0", Offset = "0x8975CB0", VA = "0x188976EB0")]
	private static float HHNDJPKFIGA(LGPCFOHIOOE JBNGHMBPLHF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x8976F70", Offset = "0x8975D70", VA = "0x188976F70")]
	private static float JOLHFOCOJGD()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct LHHFJDFMODL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct NAANEEOCDHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public NPKOEGNGKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private NJDDNJPCANH <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private IAMHPLKENKJ <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private PGDEJCAKCNB.GIPAGKKCJDE <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private TaskAwaiter<FGGKMIFBJPI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x897B400", Offset = "0x897A200", VA = "0x18897B400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x897BC00", Offset = "0x897AA00", VA = "0x18897BC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct BLLABMDJLNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x896EC00", Offset = "0x896DA00", VA = "0x18896EC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x896EF30", Offset = "0x896DD30", VA = "0x18896EF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x897AB50", Offset = "0x8979950", VA = "0x18897AB50")]
	[AsyncStateMachine(typeof(NAANEEOCDHH))]
	public static Task DIEFFEOBOIO(NPKOEGNGKDP CKGHDNAPCNB, EIPHABKKBFG BOIPFNOKGBJ, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x897AC90", Offset = "0x8979A90", VA = "0x18897AC90")]
	private static Task<FGGKMIFBJPI> KPJIELNMJPJ(NPKOEGNGKDP CKGHDNAPCNB, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x897AA90", Offset = "0x8979890", VA = "0x18897AA90")]
	[AsyncStateMachine(typeof(BLLABMDJLNB))]
	private static Task CFMPBIDNHHB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal struct LOAAAONODNP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct NJCLBPHAHPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public LOAAAONODNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x897C120", Offset = "0x897AF20", VA = "0x18897C120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x897C8B0", Offset = "0x897B6B0", VA = "0x18897C8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class DFGFJEHOOED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public DFGFJEHOOED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x8970D90", Offset = "0x896FB90", VA = "0x188970D90")]
		internal object EJIIACPMHPI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct OJMOJMCFOHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public LOAAAONODNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x897E9C0", Offset = "0x897D7C0", VA = "0x18897E9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x897EE40", Offset = "0x897DC40", VA = "0x18897EE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private bool FOEEEMPIBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	private EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	private IAMHPLKENKJ BFNHJCAHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	private CancellationToken HIMDFBHMPLL;

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x897AD00", Offset = "0x8979B00", VA = "0x18897AD00")]
	public static Task AAEPGLHLBJF(IAMHPLKENKJ BFNHJCAHHAN, bool FOEEEMPIBFG, EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, CancellationToken MBEDCBFGOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x897AD70", Offset = "0x8979B70", VA = "0x18897AD70")]
	[AsyncStateMachine(typeof(NJCLBPHAHPP))]
	private Task DIEFFEOBOIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x897AE60", Offset = "0x8979C60", VA = "0x18897AE60")]
	[AsyncStateMachine(typeof(OJMOJMCFOHC))]
	private Task JJPBMHPPAOD(bool LPLCLLOHEOO, string NOBPIEKKHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480")]
	private bool PDCDPPPKIFL(bool FOEEEMPIBFG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal struct CCNHAFIOFJB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct GKPACPMJAEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public CCNHAFIOFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x89741E0", Offset = "0x8972FE0", VA = "0x1889741E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x89746B0", Offset = "0x89734B0", VA = "0x1889746B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private sealed class IGNDCLCPABM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public IGNDCLCPABM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x8977FA0", Offset = "0x8976DA0", VA = "0x188977FA0")]
		internal object EJIIACPMHPI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct CGMOEEECDLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public CCNHAFIOFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x896FC40", Offset = "0x896EA40", VA = "0x18896FC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x89700D0", Offset = "0x896EED0", VA = "0x1889700D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private PPHBGHAHNBC KPDDOMLPPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private IAMHPLKENKJ BFNHJCAHHAN;

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x896FBF0", Offset = "0x896E9F0", VA = "0x18896FBF0")]
	public static Task<Scene> LCBDDIGHLPP(IAMHPLKENKJ BFNHJCAHHAN, PPHBGHAHNBC PCHJNGJNCCN, EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x896F9A0", Offset = "0x896E7A0", VA = "0x18896F9A0")]
	[AsyncStateMachine(typeof(GKPACPMJAEO))]
	private Task<Scene> DIEFFEOBOIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x896FAB0", Offset = "0x896E8B0", VA = "0x18896FAB0")]
	[AsyncStateMachine(typeof(CGMOEEECDLI))]
	private Task<Scene> JJPBMHPPAOD(string NOBPIEKKHNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal struct GBGIALEOKMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct LBEOJNAGIFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public AsyncTaskMethodBuilder<GFFKHEAOFOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public GBGIALEOKMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public GFFKHEAOFOJ nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public EIPHABKKBFG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private TaskAwaiter<GFFKHEAOFOJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x89923C0", Offset = "0x89911C0", VA = "0x1889923C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x8992E90", Offset = "0x8991C90", VA = "0x188992E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct NJMJGPPKHNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public AsyncTaskMethodBuilder<GFFKHEAOFOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public GBGIALEOKMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public GFFKHEAOFOJ state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private TaskAwaiter<FGGKMIFBJPI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x8995900", Offset = "0x8994700", VA = "0x188995900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x8995BE0", Offset = "0x89949E0", VA = "0x188995BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	private readonly NPKOEGNGKDP CKGHDNAPCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006AD")]
	private readonly PPEDIAHNHEB MCJJCFBAPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AE")]
	private readonly BNNIMHFJNDJ ACOIBLJPMGB;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private NJDDNJPCANH DAHCGELOPEO
	{
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x6D374C0", Offset = "0x6D362C0", VA = "0x186D374C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x898C800", Offset = "0x898B600", VA = "0x18898C800")]
	public GBGIALEOKMB(NPKOEGNGKDP CKGHDNAPCNB, PPEDIAHNHEB MCJJCFBAPMA, BNNIMHFJNDJ ACOIBLJPMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x898C500", Offset = "0x898B300", VA = "0x18898C500")]
	[AsyncStateMachine(typeof(LBEOJNAGIFC))]
	public Task<GFFKHEAOFOJ> FKHJMANFGAF(GFFKHEAOFOJ HPHPLHLFNBF, EIPHABKKBFG OCKOIJNHFNG, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL, bool LONCPHFEFMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x898C680", Offset = "0x898B480", VA = "0x18898C680")]
	[AsyncStateMachine(typeof(NJMJGPPKHNM))]
	private Task<GFFKHEAOFOJ> GKDEMFMMOLB(EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, GFFKHEAOFOJ EOMNODKHFBK, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x898C4D0", Offset = "0x898B2D0", VA = "0x18898C4D0")]
	private bool EMGCBEJIFCJ(GFFKHEAOFOJ FGNKNALFMDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x898C7E0", Offset = "0x898B5E0", VA = "0x18898C7E0")]
	private void OJKKHHLLEBA(string ADKIEKNHCGN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal struct AIKBAKFBKEK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private struct GOGIOMEHKID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public NJDDNJPCANH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public KBIBHABDIIC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private HICKLFFFPPA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private List<(PersistenceView, CDOFHMONKPD)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		private (PersistenceView, CDOFHMONKPD) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x898CD50", Offset = "0x898BB50", VA = "0x18898CD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x898D420", Offset = "0x898C220", VA = "0x18898D420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x8985810", Offset = "0x8984610", VA = "0x188985810")]
	[AsyncStateMachine(typeof(GOGIOMEHKID))]
	public static Task DIEFFEOBOIO(NJDDNJPCANH POKDMNFNEPP, EIPHABKKBFG BOIPFNOKGBJ, KBIBHABDIIC AMFPCODGPAL, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal struct JCFOJCIEAHA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct DFGIAPIIOAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public NJDDNJPCANH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public KBIBHABDIIC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private NPIADBPPJMB <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private HICKLFFFPPA <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private List<(PersistenceView, CDOFHMONKPD)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private CDOFHMONKPD <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x8988D60", Offset = "0x8987B60", VA = "0x188988D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x8989640", Offset = "0x8988440", VA = "0x188989640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x8990880", Offset = "0x898F680", VA = "0x188990880")]
	[AsyncStateMachine(typeof(DFGIAPIIOAI))]
	public static Task DIEFFEOBOIO(NJDDNJPCANH POKDMNFNEPP, EIPHABKKBFG BOIPFNOKGBJ, KBIBHABDIIC AMFPCODGPAL, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public struct GGOIJMLFECH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private struct DNOLHLJGFGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public AsyncTaskMethodBuilder<CKPFCFEHEPP<NGMGMFNJOFA, BHGDKCCPEDL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public GGOIJMLFECH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public CPNKCMLPCHO.BCNKMIJPOCG preloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private TaskAwaiter<CKPFCFEHEPP<NGMGMFNJOFA, BHGDKCCPEDL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x8989710", Offset = "0x8988510", VA = "0x188989710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x8989D90", Offset = "0x8988B90", VA = "0x188989D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private long PNKNDHONGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private long BAEDKFFMJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private Guid? PBJMEAENLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private IReadOnlyCollection<AJBFPABIEDC> NMMMAALGPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private IReadOnlyCollection<AJBFPABIEDC> KOOFAEKHLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private OJJNCLDHGBH EIOHFAMKHDD;

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x898C860", Offset = "0x898B660", VA = "0x18898C860")]
	public static Task<CKPFCFEHEPP<NGMGMFNJOFA, BHGDKCCPEDL>> ANFJADIADBG(long NCGHDDJNJOM, long KAAGEAEADCM, FPNKDIBEOOD CKGDOJJMHED, CPNKCMLPCHO.BCNKMIJPOCG OFKIFLJBBCG, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x898C9C0", Offset = "0x898B7C0", VA = "0x18898C9C0")]
	[AsyncStateMachine(typeof(DNOLHLJGFGO))]
	private Task<CKPFCFEHEPP<NGMGMFNJOFA, BHGDKCCPEDL>> DIEFFEOBOIO(CPNKCMLPCHO.BCNKMIJPOCG OFKIFLJBBCG, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal struct PGDEJCAKCNB
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	public struct GIPAGKKCJDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public List<PDDMBACFDOH> NEGOGKLOHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public List<CDOFHMONKPD> JJEOLHOIEEA;

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xBC8270", Offset = "0xBC7070", VA = "0x180BC8270")]
		public GIPAGKKCJDE(List<PDDMBACFDOH> NEGOGKLOHLK, List<CDOFHMONKPD> JJEOLHOIEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class LABLCBHHKBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public IEnumerable<PDDMBACFDOH> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public LABLCBHHKBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x8992340", Offset = "0x8991140", VA = "0x188992340")]
		internal object NLEHAJIPJOM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006E9")]
	private IAMHPLKENKJ BFNHJCAHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006EA")]
	private EIPHABKKBFG BOIPFNOKGBJ;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private LGPCFOHIOOE HLIHHKGELEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x8999730", Offset = "0x8998530", VA = "0x188999730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x89996D0", Offset = "0x89984D0", VA = "0x1889996D0")]
	public static GIPAGKKCJDE DIEFFEOBOIO(IAMHPLKENKJ BFNHJCAHHAN, EIPHABKKBFG BOIPFNOKGBJ)
	{
		return default(GIPAGKKCJDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x8999470", Offset = "0x8998270", VA = "0x188999470")]
	private GIPAGKKCJDE DIEFFEOBOIO()
	{
		return default(GIPAGKKCJDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x8998CF0", Offset = "0x8997AF0", VA = "0x188998CF0")]
	private GIPAGKKCJDE ADAKBHILKNA(IMABAOJCLFC AACKIOLKKKG, NPIADBPPJMB ICMMHNPEOPO)
	{
		return default(GIPAGKKCJDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x89992A0", Offset = "0x89980A0", VA = "0x1889992A0")]
	private bool AOHPNEEHJLE(IEnumerable<PDDMBACFDOH> NEGOGKLOHLK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal struct CGFBCICHDJH
{
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class OLBIKPDHHCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public PGDEJCAKCNB.GIPAGKKCJDE instantiations;

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public OLBIKPDHHCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x8998910", Offset = "0x8997710", VA = "0x188998910")]
		internal object BAAFBPDGDAI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class EOIDDJKBCNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public EOIDDJKBCNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x898B1E0", Offset = "0x8989FE0", VA = "0x18898B1E0")]
		internal object LHIMEDJNOAC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x8988360", Offset = "0x8987160", VA = "0x188988360")]
	public static void DIEFFEOBOIO(NJDDNJPCANH POKDMNFNEPP, EIPHABKKBFG BOIPFNOKGBJ, PGDEJCAKCNB.GIPAGKKCJDE DGKOCAOHING)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
internal class BNNIMHFJNDJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private struct MIGEKGNKKCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public BNNIMHFJNDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public GFFKHEAOFOJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public EIPHABKKBFG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public EHDFINDMEJI<string>.NGEIFBMECIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x8995130", Offset = "0x8993F30", VA = "0x188995130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x89958A0", Offset = "0x89946A0", VA = "0x1889958A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class EAFIEMKENPF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000191")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000700")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000701")]
			public EAFIEMKENPF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000702")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000703")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x899ABD0", Offset = "0x89999D0", VA = "0x18899ABD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x899AE90", Offset = "0x8999C90", VA = "0x18899AE90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public BNNIMHFJNDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public EHDFINDMEJI<string>.NGEIFBMECIG handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public EAFIEMKENPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x8989E00", Offset = "0x8988C00", VA = "0x188989E00")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task PENBLPDNMIC(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct HGLMLIIPLDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public BNNIMHFJNDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public EHDFINDMEJI<string>.NGEIFBMECIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		private EAFIEMKENPF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x898D8A0", Offset = "0x898C6A0", VA = "0x18898D8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x898DDD0", Offset = "0x898CBD0", VA = "0x18898DDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct FIEACANNKJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public BNNIMHFJNDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public EHDFINDMEJI<string>.NGEIFBMECIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private Dictionary<Guid, List<LABOCDCFPDG>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x898B7A0", Offset = "0x898A5A0", VA = "0x18898B7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x898BDB0", Offset = "0x898ABB0", VA = "0x18898BDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private struct NMOBFDAMEKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public BNNIMHFJNDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public EHDFINDMEJI<string>.NGEIFBMECIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private Dictionary<Guid, List<LABOCDCFPDG>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x8996F70", Offset = "0x8995D70", VA = "0x188996F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x8997610", Offset = "0x8996410", VA = "0x188997610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class LJDCOINAKOO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000196")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000723")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000724")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000725")]
			public LABOCDCFPDG handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000726")]
			public LJDCOINAKOO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000727")]
			private HICKLFFFPPA <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000728")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x899A700", Offset = "0x8999500", VA = "0x18899A700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x899AB70", Offset = "0x8999970", VA = "0x18899AB70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public BBADNCMFFIL runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public List<LABOCDCFPDG> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public LJDCOINAKOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x8993000", Offset = "0x8991E00", VA = "0x188993000")]
		internal object LCIJMGPHPMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x8992F00", Offset = "0x8991D00", VA = "0x188992F00")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task CPIHHEHHKCF(LABOCDCFPDG handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x89930F0", Offset = "0x8991EF0", VA = "0x1889930F0")]
		internal object MOENFINONKD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private struct PMHACGCMEJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public BBADNCMFFIL runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public List<LABOCDCFPDG> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private LJDCOINAKOO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x899A1D0", Offset = "0x8998FD0", VA = "0x18899A1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x899A6A0", Offset = "0x89994A0", VA = "0x18899A6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private struct BFMNFMHNGNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public BNNIMHFJNDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public EHDFINDMEJI<string>.NGEIFBMECIG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x89869F0", Offset = "0x89857F0", VA = "0x1889869F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x8986FB0", Offset = "0x8985DB0", VA = "0x188986FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class JLKILIPLMHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public JLKILIPLMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x8990A30", Offset = "0x898F830", VA = "0x188990A30")]
		internal object NMLKGKKLBFN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct PIMBHHJPJDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public BNNIMHFJNDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public EIPHABKKBFG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x8999CB0", Offset = "0x8998AB0", VA = "0x188999CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x899A170", Offset = "0x8998F70", VA = "0x18899A170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private sealed class DGBMKPKDEMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public DGBMKPKDEMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x89896A0", Offset = "0x89884A0", VA = "0x1889896A0")]
		internal object NBKGKECHKDO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private struct HNMMFGBBLCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public BNNIMHFJNDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private HICKLFFFPPA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private TaskAwaiter<FGGKMIFBJPI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x898F140", Offset = "0x898DF40", VA = "0x18898F140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x898F780", Offset = "0x898E580", VA = "0x18898F780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private sealed class FGCFJHHAPCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FGCFJHHAPCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x898B730", Offset = "0x898A530", VA = "0x18898B730")]
		internal object KDDOOGCCPKO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F1")]
	private readonly NPKOEGNGKDP CKGHDNAPCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	private FBEMFHJJCBL ACOIBLJPMGB;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private NJDDNJPCANH DAHCGELOPEO
	{
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x1276650", Offset = "0x1275450", VA = "0x181276650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
	public BNNIMHFJNDJ(NPKOEGNGKDP CKGHDNAPCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x89876D0", Offset = "0x89864D0", VA = "0x1889876D0")]
	[AsyncStateMachine(typeof(MIGEKGNKKCJ))]
	public Task DIEFFEOBOIO(GFFKHEAOFOJ MAPHKMILNHA, EIPHABKKBFG OCKOIJNHFNG, EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x8987420", Offset = "0x8986220", VA = "0x188987420")]
	[AsyncStateMachine(typeof(HGLMLIIPLDE))]
	private Task AJIDKKKFHED(EIPHABKKBFG BOIPFNOKGBJ, EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x8987DD0", Offset = "0x8986BD0", VA = "0x188987DD0")]
	[AsyncStateMachine(typeof(FIEACANNKJH))]
	private Task IDLOPDPHLLI(EIPHABKKBFG BOIPFNOKGBJ, EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x8988220", Offset = "0x8987020", VA = "0x188988220")]
	[AsyncStateMachine(typeof(NMOBFDAMEKE))]
	private Task OPMKNPPHKLB(EIPHABKKBFG BOIPFNOKGBJ, EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x8987C80", Offset = "0x8986A80", VA = "0x188987C80")]
	[AsyncStateMachine(typeof(PMHACGCMEJJ))]
	private Task GMLHJIFPDEB(Guid LKHJFPGFAFO, List<LABOCDCFPDG> IAJINKDGBDH, BBADNCMFFIL FPDDLMMOPOG, EIPHABKKBFG BOIPFNOKGBJ, CancellationToken OCGDLEBGIMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x8987FC0", Offset = "0x8986DC0", VA = "0x188987FC0")]
	[AsyncStateMachine(typeof(BFMNFMHNGNM))]
	private Task OBDEBDNGBDB(EIPHABKKBFG BOIPFNOKGBJ, EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x8987820", Offset = "0x8986620", VA = "0x188987820")]
	[AsyncStateMachine(typeof(PIMBHHJPJDO))]
	private Task EAEPPHLMBLO(Guid CMNLGEGIEGE, EIPHABKKBFG BOIPFNOKGBJ, EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x8987B40", Offset = "0x8986940", VA = "0x188987B40")]
	[AsyncStateMachine(typeof(HNMMFGBBLCN))]
	private Task EPGIGOAGHNE(Guid CMNLGEGIEGE, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x8988100", Offset = "0x8986F00", VA = "0x188988100")]
	private void OMNBLJJDHGF(Guid CMNLGEGIEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x8987F10", Offset = "0x8986D10", VA = "0x188987F10")]
	private void KGGCFDPNBPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x8987560", Offset = "0x8986360", VA = "0x188987560")]
	public Guid BLLPDHBDAJF(GFFKHEAOFOJ CHNOBNEEJEK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x8987960", Offset = "0x8986760", VA = "0x188987960")]
	[CompilerGenerated]
	private object EMOMODJGKKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal struct CILHPOJAELA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private struct IFOPOCKLINO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public CILHPOJAELA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		private IEnumerator<LAKKBDHPEHD> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x898F7E0", Offset = "0x898E5E0", VA = "0x18898F7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x898FE70", Offset = "0x898EC70", VA = "0x18898FE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000751")]
	private LGPCFOHIOOE JBNGHMBPLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000752")]
	private EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000753")]
	private CancellationToken HIMDFBHMPLL;

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x8988C00", Offset = "0x8987A00", VA = "0x188988C00")]
	public static Task BMJLIKDBCPO(LGPCFOHIOOE JBNGHMBPLHF, EHDFINDMEJI<string>.NGEIFBMECIG INANPMNJHBH, CancellationToken MBEDCBFGOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x8988C70", Offset = "0x8987A70", VA = "0x188988C70")]
	[AsyncStateMachine(typeof(IFOPOCKLINO))]
	private Task DIEFFEOBOIO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
public readonly struct HANPKCOEGMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075A")]
	public readonly bool KCDHIOCOOKB;

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x2C0E250", Offset = "0x2C0D050", VA = "0x182C0E250")]
	public HANPKCOEGMA(bool JABJKKBEGNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public readonly struct FMBJDHFAPIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075B")]
	public readonly IMABAOJCLFC? PCPALICPDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400075C")]
	public readonly AJEJNDJABAI MCOFIKCIKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400075D")]
	public readonly Guid? IPLEJNECALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400075E")]
	public readonly IReadOnlyList<Guid> FFFIGPILMFG;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public IReadOnlyCollection<string> PCMOADGLCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x898BEB0", Offset = "0x898ACB0", VA = "0x18898BEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public IReadOnlyDictionary<long, int> BHENDOKNLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x898BE90", Offset = "0x898AC90", VA = "0x18898BE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x898BED0", Offset = "0x898ACD0", VA = "0x18898BED0")]
	public FMBJDHFAPIA(IMABAOJCLFC? JBNEABKLADH, AJEJNDJABAI KGGOBNBKCNO, Guid? COBCHIDBIBM, [Optional] IReadOnlyList<Guid>? HOHDKHLICBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal class NKINAFBDBPC : MNFNGMFCFBJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private struct LOIIMFAGPHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public AsyncTaskMethodBuilder<FMBJDHFAPIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public NKINAFBDBPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public FAGPKDIFNIN serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public AKGLAIKGPKN roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		private HICKLFFFPPA <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x8993930", Offset = "0x8992730", VA = "0x188993930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x8993FD0", Offset = "0x8992DD0", VA = "0x188993FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class EBDEHFGGGDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public EBDEHFGGGDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x8989EF0", Offset = "0x8988CF0", VA = "0x188989EF0")]
		internal object MMFLLJIPECN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private struct KMAMFKPPPNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public NKINAFBDBPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public FAGPKDIFNIN serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		private EBDEHFGGGDH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		private HICKLFFFPPA <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		private GDLAFIILODC<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x8990E30", Offset = "0x898FC30", VA = "0x188990E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x89919F0", Offset = "0x89907F0", VA = "0x1889919F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400075F")]
	private readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x4000760")]
	private static readonly TimeSpan AGHMINNAJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000761")]
	private readonly MHMOHCEGHPB JDCBHCOHDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000762")]
	private readonly GGPPBGKNJJG JDPMJNJBHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000763")]
	private readonly PAHJHCJMCKK INHIALAGDBL;

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x8996F00", Offset = "0x8995D00", VA = "0x188996F00")]
	public NKINAFBDBPC(NPKOEGNGKDP CKGHDNAPCNB, MHMOHCEGHPB JDCBHCOHDKE, GGPPBGKNJJG MDHGLALFHAP, PAHJHCJMCKK INHIALAGDBL, PHLHEDGDBJO CFEMPAINFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x8996930", Offset = "0x8995730", VA = "0x188996930")]
	[AsyncStateMachine(typeof(LOIIMFAGPHL))]
	public Task<FMBJDHFAPIA> NEJFHFKCOKJ(long KAAGEAEADCM, AKGLAIKGPKN OMJLEHMHBNK, FAGPKDIFNIN PCHBJGHMGLM, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x8995D90", Offset = "0x8994B90", VA = "0x188995D90")]
	private static bool FKGPJIPOKEE(PersistenceView LNFFCKNEJCB, [Out] AAKBPENLLKA AAPNENIKNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x8995C50", Offset = "0x8994A50", VA = "0x188995C50")]
	[AsyncStateMachine(typeof(KMAMFKPPPNA))]
	private Task ELOFGAOEDMH(FAGPKDIFNIN PCHBJGHMGLM, PersistenceView[] HGIGECBAHNK, StringBuilder AAPEJDGCCGG, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x8995E80", Offset = "0x8994C80", VA = "0x188995E80")]
	private FMBJDHFAPIA IMEMFABKBCC(long KAAGEAEADCM, AKGLAIKGPKN OMJLEHMHBNK, FAGPKDIFNIN PCHBJGHMGLM, IEnumerable<PersistenceView> HGIGECBAHNK, StringBuilder AAPEJDGCCGG)
	{
		return default(FMBJDHFAPIA);
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x8996A80", Offset = "0x8995880", VA = "0x188996A80")]
	private IMABAOJCLFC OFANAIBFONG(long KAAGEAEADCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x8996C40", Offset = "0x8995A40", VA = "0x188996C40")]
	private void PPGMNKGNJEO(IMABAOJCLFC BADEBMBOFEI, StringBuilder AAPEJDGCCGG, IEnumerable<PersistenceView> HGIGECBAHNK, [In] GKILACMFGFC KGGPHMGMLDK, BCHJBLIFBEP IOMPNBMHBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x8996490", Offset = "0x8995290", VA = "0x188996490")]
	private void JJDLLBDIABF(IMABAOJCLFC BADEBMBOFEI, StringBuilder AAPEJDGCCGG, PersistenceView LNFFCKNEJCB, BCHJBLIFBEP IOMPNBMHBBN, [In] GKILACMFGFC KGGPHMGMLDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal class ENGKMPOGMEN : MNFNGMFCFBJ
{
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private sealed class KHEHPLHDKGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public FIPAFGIJBOP.CGNHFPAKDNP roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KHEHPLHDKGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x8990DE0", Offset = "0x898FBE0", VA = "0x188990DE0")]
		internal object IGAHCJLJDDD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct KPKJPAALBGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public AsyncTaskMethodBuilder<(FIPAFGIJBOP.CGNHFPAKDNP roomDataUpload, FIPAFGIJBOP.CGNHFPAKDNP subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public FMBJDHFAPIA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public LGPCFOHIOOE callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		private KHEHPLHDKGP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		private TaskAwaiter<FIPAFGIJBOP.CGNHFPAKDNP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x8991A50", Offset = "0x8990850", VA = "0x188991A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x89922D0", Offset = "0x89910D0", VA = "0x1889922D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private struct MHBDGAOCLOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public AsyncTaskMethodBuilder<AEFELCHEGKN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public ENGKMPOGMEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public GAJAJCGPIFH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public FMBJDHFAPIA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		private TaskAwaiter<AEFELCHEGKN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x8994E20", Offset = "0x8993C20", VA = "0x188994E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x89950C0", Offset = "0x8993EC0", VA = "0x1889950C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private struct ODDPLJEBFFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public AsyncTaskMethodBuilder<AEFELCHEGKN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public LGPCFOHIOOE callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public FMBJDHFAPIA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public HHJONIOGFJH ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public GAJAJCGPIFH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		private TaskAwaiter<(FIPAFGIJBOP.CGNHFPAKDNP roomDataUpload, FIPAFGIJBOP.CGNHFPAKDNP subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		private TaskAwaiter<AEFELCHEGKN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x8997670", Offset = "0x8996470", VA = "0x188997670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x8997CD0", Offset = "0x8996AD0", VA = "0x188997CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private struct PHOLNIIOEPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		public AsyncTaskMethodBuilder<BHOCDPCCCDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		public ENGKMPOGMEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		public FMBJDHFAPIA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		private TaskAwaiter<(FIPAFGIJBOP.CGNHFPAKDNP roomDataUpload, FIPAFGIJBOP.CGNHFPAKDNP subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		private TaskAwaiter<BHOCDPCCCDL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x8999780", Offset = "0x8998580", VA = "0x188999780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x8999C40", Offset = "0x8998A40", VA = "0x188999C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[CompilerGenerated]
	private sealed class JAENKIBODNM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			public AsyncTaskMethodBuilder<FGGKMIFBJPI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			public JAENKIBODNM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			private FGGKMIFBJPI <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			private TaskAwaiter<BHOCDPCCCDL> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007B7")]
			private TaskAwaiter<AEFELCHEGKN> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007B8")]
			private TaskAwaiter<FGGKMIFBJPI> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0x899AEF0", Offset = "0x8999CF0", VA = "0x18899AEF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0x899C100", Offset = "0x899AF00", VA = "0x18899C100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public ENGKMPOGMEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public FMBJDHFAPIA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		public GAJAJCGPIFH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		public HANPKCOEGMA roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public JAENKIBODNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x8990750", Offset = "0x898F550", VA = "0x188990750")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<FGGKMIFBJPI> KKPKOCOJDFE(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[CompilerGenerated]
	private struct AJHDNPIBFAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		public AsyncTaskMethodBuilder<FGGKMIFBJPI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public ENGKMPOGMEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public FMBJDHFAPIA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		public GAJAJCGPIFH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public HANPKCOEGMA roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		private TaskAwaiter<FGGKMIFBJPI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x8985950", Offset = "0x8984750", VA = "0x188985950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x8985C80", Offset = "0x8984A80", VA = "0x188985C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400077D")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x400077E")]
	private static readonly PHLHEDGDBJO FBBIFJHMNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400077F")]
	private readonly DCFAMFOCBOI NPLHAHEJEBO;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private IAMHPLKENKJ HCBEGBGLEGG
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x895DA00", Offset = "0x895C800", VA = "0x18895DA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x898B150", Offset = "0x8989F50", VA = "0x18898B150")]
	public ENGKMPOGMEN(NPKOEGNGKDP CKGHDNAPCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x898A760", Offset = "0x8989560", VA = "0x18898A760")]
	[AsyncStateMachine(typeof(KPKJPAALBGF))]
	private static Task<(FIPAFGIJBOP.CGNHFPAKDNP, FIPAFGIJBOP.CGNHFPAKDNP)> GHGDDFLFKJI(LGPCFOHIOOE JBNGHMBPLHF, FMBJDHFAPIA DFLHHMJDJCP, long NCGHDDJNJOM, long HEPLHKILNBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x898ABF0", Offset = "0x89899F0", VA = "0x18898ABF0")]
	[AsyncStateMachine(typeof(MHBDGAOCLOL))]
	public Task<AEFELCHEGKN> NGLMKCMFPLA(int EJENBHALFPN, [CanBeNull] GAJAJCGPIFH LGBFOCAKECN, FMBJDHFAPIA DFLHHMJDJCP, long NCGHDDJNJOM, long HEPLHKILNBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x898AD60", Offset = "0x8989B60", VA = "0x18898AD60")]
	public static Task<AEFELCHEGKN> NGLMKCMFPLA(LGPCFOHIOOE JBNGHMBPLHF, int EJENBHALFPN, [CanBeNull] GAJAJCGPIFH LGBFOCAKECN, FMBJDHFAPIA DFLHHMJDJCP, long NCGHDDJNJOM, long HEPLHKILNBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x898AA60", Offset = "0x8989860", VA = "0x18898AA60")]
	[AsyncStateMachine(typeof(ODDPLJEBFFH))]
	public static Task<AEFELCHEGKN> NGLMKCMFPLA(LGPCFOHIOOE JBNGHMBPLHF, int EJENBHALFPN, [CanBeNull] GAJAJCGPIFH LGBFOCAKECN, FMBJDHFAPIA DFLHHMJDJCP, long NCGHDDJNJOM, long HEPLHKILNBD, HHJONIOGFJH EDLDAAAMFBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x898A5E0", Offset = "0x89893E0", VA = "0x18898A5E0")]
	[AsyncStateMachine(typeof(PHOLNIIOEPJ))]
	private Task<BHOCDPCCCDL> APOLHLHLPJC(string JFBBAOMPOPG, int EJENBHALFPN, FMBJDHFAPIA DFLHHMJDJCP, long NCGHDDJNJOM, long HEPLHKILNBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x898A8B0", Offset = "0x89896B0", VA = "0x18898A8B0")]
	[AsyncStateMachine(typeof(AJHDNPIBFAA))]
	public Task<FGGKMIFBJPI> MOAPBPACIPA(int EJENBHALFPN, GAJAJCGPIFH? LGBFOCAKECN, FMBJDHFAPIA DFLHHMJDJCP, long NCGHDDJNJOM, long HEPLHKILNBD, HANPKCOEGMA PANHNBEMPMM, EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public abstract class IDAPEAGBGOM<T> where T : IDAPEAGBGOM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C5")]
	internal readonly IAMHPLKENKJ FMMPFIOOPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C6")]
	private int? NKJBGOHOCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C7")]
	protected readonly Guid GGHLJDMBIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C8")]
	protected readonly CHJGFILBKKF EAGAMLGLPNG;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	protected T AJEBEMOGDFE
	{
		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x4F13450", Offset = "0x4F12250", VA = "0x184F13450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x4F137D0", Offset = "0x4F125D0", VA = "0x184F137D0")]
	internal IDAPEAGBGOM(IAMHPLKENKJ HJIOGAHAHEK, CHJGFILBKKF NNEHFLALFCH, [Optional] Guid? ALEMANCBDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x4F134B0", Offset = "0x4F122B0", VA = "0x184F134B0")]
	private FGGKMIFBJPI APIIBLKCHKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
	protected virtual void OGJFLKOHENF(FGGKMIFBJPI IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x4F136B0", Offset = "0x4F124B0", VA = "0x184F136B0")]
	public T GPDHHMBOMMP(CDKFIILELLC BFIOOMKAEHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x4F13740", Offset = "0x4F12540", VA = "0x184F13740")]
	public T PICEEGHBIDL(int HFPDAMGHAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x4F13590", Offset = "0x4F12390", VA = "0x184F13590", Slot = "5")]
	public virtual Task<PPJMMNMCCIA> GKOHGECDFOJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public class GIAFIGCKAON : IDAPEAGBGOM<GIAFIGCKAON>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007C9")]
	private NLIPGAAAAGA OFCPJKNFOPJ;

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x898CC80", Offset = "0x898BA80", VA = "0x18898CC80")]
	internal GIAFIGCKAON(IAMHPLKENKJ HJIOGAHAHEK, CHJGFILBKKF NNEHFLALFCH, [Optional] Guid? ALEMANCBDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x7B50F90", Offset = "0x7B4FD90", VA = "0x187B50F90")]
	public GIAFIGCKAON DMGCEHGEOBH(NLIPGAAAAGA OFCPJKNFOPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x898CBB0", Offset = "0x898B9B0", VA = "0x18898CBB0", Slot = "4")]
	protected override void OGJFLKOHENF(FGGKMIFBJPI IIHOFBLPONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public class EDCNEBDIPFE : IDAPEAGBGOM<EDCNEBDIPFE>
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	internal enum LJGIGNGIJHC
	{
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B5")]
	[CompilerGenerated]
	private struct HDEKIFDNIHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		public AsyncTaskMethodBuilder<PPJMMNMCCIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		public EDCNEBDIPFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		private TaskAwaiter<PPJMMNMCCIA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x898D480", Offset = "0x898C280", VA = "0x18898D480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x898D830", Offset = "0x898C630", VA = "0x18898D830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007CA")]
	private LJGIGNGIJHC CPGACNGHDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007CB")]
	private string OFKIENLDNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007CC")]
	private GAJAJCGPIFH OFCPJKNFOPJ;

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x898A470", Offset = "0x8989270", VA = "0x18898A470")]
	internal EDCNEBDIPFE(IAMHPLKENKJ HJIOGAHAHEK, CHJGFILBKKF NNEHFLALFCH, [Optional] Guid? ALEMANCBDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x898A290", Offset = "0x8989090", VA = "0x18898A290")]
	public EDCNEBDIPFE MAIGOELCNFO(string BKPMFKNMLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x898A270", Offset = "0x8989070", VA = "0x18898A270")]
	public EDCNEBDIPFE JBCNFNMIFFN(bool HEHNCMIBHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x898A130", Offset = "0x8988F30", VA = "0x18898A130")]
	public EDCNEBDIPFE AGCHGFPCILG(bool LKMOBBMBJLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x898A150", Offset = "0x8988F50", VA = "0x18898A150")]
	public EDCNEBDIPFE CKPOEEOPNGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x898A300", Offset = "0x8989100", VA = "0x18898A300", Slot = "4")]
	protected override void OGJFLKOHENF(FGGKMIFBJPI IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x898A180", Offset = "0x8988F80", VA = "0x18898A180", Slot = "5")]
	[AsyncStateMachine(typeof(HDEKIFDNIHD))]
	public override Task<PPJMMNMCCIA> GKOHGECDFOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x898A2C0", Offset = "0x89890C0", VA = "0x18898A2C0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<PPJMMNMCCIA> MMCCAIAPNAK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
internal static class EBPGOGDBIML
{
	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x8989FE0", Offset = "0x8988DE0", VA = "0x188989FE0")]
	public static void OMODJGPMLFK(this DAIJPMNLLOK GFDNFLIOFAH, PLJJBKEIPKH KCFNOHKIAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x8989F60", Offset = "0x8988D60", VA = "0x188989F60")]
	public static void MAPPEILABOK(this PLJJBKEIPKH HOAMOKDGHIC, [Optional] string IIHOFBLPONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B7")]
public static class LKLCIOAKEHO
{
	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x8993290", Offset = "0x8992090", VA = "0x188993290")]
	public static MFCKDCKCJFL ONEANAMDDLJ(this DJPALDEBLEK NJNIKEGMEJE)
	{
		return default(MFCKDCKCJFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x89931E0", Offset = "0x8991FE0", VA = "0x1889931E0")]
	public static DJPALDEBLEK ANKCLGAOOHI(this MFCKDCKCJFL PKOKIAPEGGN)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001B9")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007D9")]
			public MFCHBPKIIHA ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			public MFCHBPKIIHA HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007DD")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007DE")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006E1")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private static MFCHBPKIIHA[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		private Dictionary<MFCHBPKIIHA, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x899C720", Offset = "0x899B520", VA = "0x18899C720")]
		public bool FPLDCIKFODB(MFCHBPKIIHA LOGIKODIGAD, [Out] ResultConfig FNFCFIGCMHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x899C790", Offset = "0x899B590", VA = "0x18899C790")]
		public ResultConfig IAGLCCCIFNP(MFCHBPKIIHA EGLDLGDMAJN, [Optional] HashSet<MFCHBPKIIHA> ENIKKFHOLPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x899CE30", Offset = "0x899BC30", VA = "0x18899CE30", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x899C8D0", Offset = "0x899B6D0", VA = "0x18899C8D0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xCC5E40", Offset = "0xCC4C40", VA = "0x180CC5E40")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
public class KCEDLDFEOGP : OOINCOPNPCH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[CompilerGenerated]
	private struct CGGDOCODKLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		public KCEDLDFEOGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		public EHDFINDMEJI<string>.NGEIFBMECIG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x8988910", Offset = "0x8987710", VA = "0x188988910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x8988BA0", Offset = "0x89879A0", VA = "0x188988BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BD")]
	[CompilerGenerated]
	private struct FPGLKDACIMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		public EHDFINDMEJI<string>.NGEIFBMECIG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		public OOINCOPNPCH preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x898BFD0", Offset = "0x898ADD0", VA = "0x18898BFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x898C470", Offset = "0x898B270", VA = "0x18898C470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007E4")]
	private readonly HIBGNDCMOJM MOBDHFLGIOM;

	[Cpp2IlInjected.Token(Token = "0x40007E5")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string NPMPDGPPLHM
	{
		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x8990AA0", Offset = "0x898F8A0", VA = "0x188990AA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x8990D00", Offset = "0x898FB00", VA = "0x188990D00")]
	[ONLJNMLDJBD.KDDDMPKOLFO.GACHHHHOLBP]
	internal static void JFAOHENDPOF(LOAHJOOKLEP MHIANKFNOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KCEDLDFEOGP([OLOAAHJODHH(null)] HIBGNDCMOJM MOBDHFLGIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x8990AD0", Offset = "0x898F8D0", VA = "0x188990AD0", Slot = "5")]
	[AsyncStateMachine(typeof(CGGDOCODKLK))]
	public Task DIEFFEOBOIO(EHDFINDMEJI<string>.NGEIFBMECIG KOFEPIFFNLL, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x8990BE0", Offset = "0x898F9E0", VA = "0x188990BE0")]
	[AsyncStateMachine(typeof(FPGLKDACIMA))]
	private Task GFPMAALGKCF(OOINCOPNPCH PNLFBNPOBPL, EHDFINDMEJI<string>.NGEIFBMECIG KOFEPIFFNLL, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public interface HIBGNDCMOJM : OOINCOPNPCH
{
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public interface OOINCOPNPCH
{
	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	string NPMPDGPPLHM
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DIEFFEOBOIO(EHDFINDMEJI<string>.NGEIFBMECIG KOFEPIFFNLL, CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public static class BMDKGPEICOG
{
	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x8987010", Offset = "0x8985E10", VA = "0x188987010")]
	[ONLJNMLDJBD.KDDDMPKOLFO.GACHHHHOLBP]
	internal static void KEKMDAEKNFP(LOAHJOOKLEP MHIANKFNOAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
public interface EKDPPHJHEGI : IEquatable<EKDPPHJHEGI>
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	DateTime OCDCBHPKDAN
	{
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFMIGJKFHNO();

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CDCLNLCMCOD(long NCGHDDJNJOM, long KAAGEAEADCM, [Out] FMBJDHFAPIA DFLHHMJDJCP);
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
internal class OHKNPLPDHFK : AMDLPNAJCME
{
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[CompilerGenerated]
	private sealed class JCHINDPHHLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		public AJHDCFJNACE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public JCHINDPHHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x89909C0", Offset = "0x898F7C0", VA = "0x1889909C0")]
		internal object DECKDFDOEHF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F3")]
	private readonly FCMLHHLLHMO OGCGMCFOLHM;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<EKDPPHJHEGI> KAFGNKCFDAA
	{
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x8998860", Offset = "0x8997660", VA = "0x188998860", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x89987B0", Offset = "0x89975B0", VA = "0x1889987B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
	[UnityEngine.Scripting.Preserve]
	public OHKNPLPDHFK([OLOAAHJODHH(null)] FCMLHHLLHMO OGCGMCFOLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x8998340", Offset = "0x8997140", VA = "0x188998340", Slot = "6")]
	public bool KALFGHLLOIN(long NCGHDDJNJOM, long KAAGEAEADCM, FMBJDHFAPIA DFLHHMJDJCP, AJHDCFJNACE IJMPHHBDLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0xEC7730", Offset = "0xEC6530", VA = "0x180EC7730")]
	private void IINIDODNJIE(EKDPPHJHEGI LICJOHINBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x8998640", Offset = "0x8997440", VA = "0x188998640", Slot = "7")]
	public bool MHOHMEADDLP(long NCGHDDJNJOM, long KAAGEAEADCM, [Out] EKDPPHJHEGI KMKBPCBONMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x8998290", Offset = "0x8997090", VA = "0x188998290", Slot = "8")]
	public bool GNGIKGNNCHJ(long NCGHDDJNJOM, long KAAGEAEADCM, AJHDCFJNACE IJMPHHBDLBM, [Out] EKDPPHJHEGI KMKBPCBONMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x8997D40", Offset = "0x8996B40", VA = "0x188997D40")]
	private void EIPIBDLPDEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x8998170", Offset = "0x8996F70", VA = "0x188998170", Slot = "9")]
	public void GHEEKNACJEO(long NCGHDDJNJOM, long KAAGEAEADCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
internal abstract class MAPNBPIIGEK : FCMLHHLLHMO
{
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	protected enum FJHGGCMMFBG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[CompilerGenerated]
	private sealed class PCPJHGDDKGD : IEnumerable<EKDPPHJHEGI>, IEnumerable, IEnumerator<EKDPPHJHEGI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		private EKDPPHJHEGI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		public MAPNBPIIGEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		private AJHDCFJNACE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		public AJHDCFJNACE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000803")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private EKDPPHJHEGI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xF9A0D0", Offset = "0xF98ED0", VA = "0x180F9A0D0")]
		[DebuggerHidden]
		public PCPJHGDDKGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x89989C0", Offset = "0x89977C0", VA = "0x1889989C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x8998CA0", Offset = "0x8997AA0", VA = "0x188998CA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x8998BF0", Offset = "0x89979F0", VA = "0x188998BF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EKDPPHJHEGI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x8998BF0", Offset = "0x89979F0", VA = "0x188998BF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[CompilerGenerated]
	private sealed class BDOOBPHICPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		public AJHDCFJNACE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public BDOOBPHICPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x8985CF0", Offset = "0x8984AF0", VA = "0x188985CF0")]
		internal object GNHAIKFJIBB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[CompilerGenerated]
	private sealed class FJBNMCNHENC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000807")]
		public MAPNBPIIGEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000808")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FJBNMCNHENC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x898BE10", Offset = "0x898AC10", VA = "0x18898BE10")]
		internal void HMGBAGAIEAN(FCIKBGAKGPJ.FIMFMEDFMFD ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F9")]
	private readonly object EKGBJDENOGC;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	protected string ICDGBNBGDBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x8994040", Offset = "0x8992E40", VA = "0x188994040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public abstract IOJOJEPJCBE MOHBAOOHPPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x8994A80", Offset = "0x8993880", VA = "0x188994A80")]
	protected MAPNBPIIGEK([CanBeNull] string MMOKGNDCAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x8994440", Offset = "0x8993240", VA = "0x188994440", Slot = "5")]
	public bool NEKGNNOJHIJ(long NCGHDDJNJOM, long KAAGEAEADCM, AJHDCFJNACE IJMPHHBDLBM, [Out] EKDPPHJHEGI LICJOHINBNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x8994630", Offset = "0x8993430", VA = "0x188994630", Slot = "6")]
	[IteratorStateMachine(typeof(PCPJHGDDKGD))]
	public IEnumerable<EKDPPHJHEGI> OJHJEELJOIN(AJHDCFJNACE IJMPHHBDLBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void JFBBMNPDMME(Stream KBDOCMAAFDJ, long NCGHDDJNJOM, long KAAGEAEADCM, FMBJDHFAPIA DFLHHMJDJCP);

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool AHHADFPJFBK(Stream CNDFLBKAIFM, long NCGHDDJNJOM, long KAAGEAEADCM, EBJOMGOFPGJ OHPNCNPJGFH, [Out] FMBJDHFAPIA DFLHHMJDJCP);

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x89940C0", Offset = "0x8992EC0", VA = "0x1889940C0", Slot = "7")]
	public EKDPPHJHEGI HGOIOPFMNAJ(long NCGHDDJNJOM, long KAAGEAEADCM, FMBJDHFAPIA DFLHHMJDJCP, AJHDCFJNACE IJMPHHBDLBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo LPDPDFOMAOD(long NCGHDDJNJOM, long KAAGEAEADCM, AJHDCFJNACE IJMPHHBDLBM, FJHGGCMMFBG AALKEMKKFAE);

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo AANHKODPOCD(AJHDCFJNACE IJMPHHBDLBM, FJHGGCMMFBG AALKEMKKFAE);

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x8994050", Offset = "0x8992E50", VA = "0x188994050")]
	protected void FGGLAEFHKIC(FCIKBGAKGPJ.FIMFMEDFMFD DPFGMLDJGFM, string ADKIEKNHCGN, FileInfo AIHMDMAMACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x89946C0", Offset = "0x89934C0", VA = "0x1889946C0")]
	internal bool PHPOCLFMBBP(FileInfo OLHFKEJKLNG, long NCGHDDJNJOM, long KAAGEAEADCM, [Out] FMBJDHFAPIA DFLHHMJDJCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	private void PLCJAKFJODB(Exception HIKJGCCPIBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
internal class BEKMJKIOHOE : MAPNBPIIGEK
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public override IOJOJEPJCBE MOHBAOOHPPL
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x1429A30", Offset = "0x1428830", VA = "0x181429A30", Slot = "8")]
		get
		{
			return default(IOJOJEPJCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x89869B0", Offset = "0x89857B0", VA = "0x1889869B0")]
	public BEKMJKIOHOE([Optional] string MMOKGNDCAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x8985E90", Offset = "0x8984C90", VA = "0x188985E90")]
	private void AHDEIHMIILO(AJHDCFJNACE IJMPHHBDLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x8986610", Offset = "0x8985410", VA = "0x188986610", Slot = "9")]
	internal override void JFBBMNPDMME(Stream KBDOCMAAFDJ, long NCGHDDJNJOM, long KAAGEAEADCM, FMBJDHFAPIA DFLHHMJDJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x8985F10", Offset = "0x8984D10", VA = "0x188985F10", Slot = "10")]
	internal override bool AHHADFPJFBK(Stream CNDFLBKAIFM, long NCGHDDJNJOM, long KAAGEAEADCM, EBJOMGOFPGJ OHPNCNPJGFH, [Out] FMBJDHFAPIA DFLHHMJDJCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x89868C0", Offset = "0x89856C0", VA = "0x1889868C0", Slot = "11")]
	protected override FileInfo LPDPDFOMAOD(long NCGHDDJNJOM, long KAAGEAEADCM, AJHDCFJNACE IJMPHHBDLBM, FJHGGCMMFBG AALKEMKKFAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x8985D90", Offset = "0x8984B90", VA = "0x188985D90", Slot = "12")]
	protected override DirectoryInfo AANHKODPOCD(AJHDCFJNACE IJMPHHBDLBM, FJHGGCMMFBG AALKEMKKFAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
internal sealed class HIPPANHFNPG : MAPNBPIIGEK
{
	[Cpp2IlInjected.Token(Token = "0x4000809")]
	private static readonly byte[] MAHBBBBCDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400080A")]
	private readonly byte[] IHOFPFNIJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400080B")]
	private readonly byte[] LONODNDOHLN;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public override IOJOJEPJCBE MOHBAOOHPPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x19D42B0", Offset = "0x19D30B0", VA = "0x1819D42B0", Slot = "8")]
		get
		{
			return default(IOJOJEPJCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x898F050", Offset = "0x898DE50", VA = "0x18898F050")]
	public HIPPANHFNPG([Optional] string MMOKGNDCAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x898E9B0", Offset = "0x898D7B0", VA = "0x18898E9B0", Slot = "9")]
	internal override void JFBBMNPDMME(Stream KBDOCMAAFDJ, long NCGHDDJNJOM, long KAAGEAEADCM, FMBJDHFAPIA DFLHHMJDJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x898DF40", Offset = "0x898CD40", VA = "0x18898DF40", Slot = "10")]
	internal override bool AHHADFPJFBK(Stream CNDFLBKAIFM, long NCGHDDJNJOM, long KAAGEAEADCM, EBJOMGOFPGJ OHPNCNPJGFH, [Out] FMBJDHFAPIA DFLHHMJDJCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x898EDD0", Offset = "0x898DBD0", VA = "0x18898EDD0")]
	private void KBCOFCLKJDA(byte[] JMAPKDPGDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x898EE90", Offset = "0x898DC90", VA = "0x18898EE90", Slot = "11")]
	protected override FileInfo LPDPDFOMAOD(long NCGHDDJNJOM, long KAAGEAEADCM, AJHDCFJNACE IJMPHHBDLBM, FJHGGCMMFBG AALKEMKKFAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x898DE30", Offset = "0x898CC30", VA = "0x18898DE30", Slot = "12")]
	protected override DirectoryInfo AANHKODPOCD(AJHDCFJNACE IJMPHHBDLBM, FJHGGCMMFBG AALKEMKKFAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
public enum IOJOJEPJCBE : byte
{
	[Cpp2IlInjected.Token(Token = "0x400080F")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000810")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000811")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
internal class IJFCHFJMMMC : FCMLHHLLHMO
{
	[Cpp2IlInjected.Token(Token = "0x20001D0")]
	[CompilerGenerated]
	private sealed class EPHEJOCLONL : IEnumerable<EKDPPHJHEGI>, IEnumerable, IEnumerator<EKDPPHJHEGI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		private EKDPPHJHEGI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		public IJFCHFJMMMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		private AJHDCFJNACE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		public AJHDCFJNACE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		private IOJOJEPJCBE[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		private IEnumerator<EKDPPHJHEGI> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		private EKDPPHJHEGI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0xF9A0D0", Offset = "0xF98ED0", VA = "0x180F9A0D0")]
		[DebuggerHidden]
		public EPHEJOCLONL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x898B6A0", Offset = "0x898A4A0", VA = "0x18898B6A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x898B2C0", Offset = "0x898A0C0", VA = "0x18898B2C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x898B270", Offset = "0x898A070", VA = "0x18898B270")]
		private void KHMMOEFKMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x898B650", Offset = "0x898A450", VA = "0x18898B650", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x898B5A0", Offset = "0x898A3A0", VA = "0x18898B5A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EKDPPHJHEGI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x898B5A0", Offset = "0x898A3A0", VA = "0x18898B5A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000812")]
	private readonly IOJOJEPJCBE[] DFKMGHGOCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000813")]
	private readonly Dictionary<IOJOJEPJCBE, FCMLHHLLHMO> PFAANBNAEBM;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public IOJOJEPJCBE MOHBAOOHPPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x8990100", Offset = "0x898EF00", VA = "0x188990100", Slot = "4")]
		get
		{
			return default(IOJOJEPJCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x8990400", Offset = "0x898F200", VA = "0x188990400")]
	[UnityEngine.Scripting.Preserve]
	public IJFCHFJMMMC(params FCMLHHLLHMO[] FDGNIKAFMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x8990220", Offset = "0x898F020", VA = "0x188990220", Slot = "5")]
	public bool NEKGNNOJHIJ(long NCGHDDJNJOM, long KAAGEAEADCM, AJHDCFJNACE IJMPHHBDLBM, [Out] EKDPPHJHEGI LICJOHINBNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x898FED0", Offset = "0x898ECD0", VA = "0x18898FED0")]
	private void ABHAPOIIJHM(int KAKDEBIOBII, long NCGHDDJNJOM, long KAAGEAEADCM, AJHDCFJNACE IJMPHHBDLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x8990370", Offset = "0x898F170", VA = "0x188990370", Slot = "6")]
	[IteratorStateMachine(typeof(EPHEJOCLONL))]
	public IEnumerable<EKDPPHJHEGI> OJHJEELJOIN(AJHDCFJNACE IJMPHHBDLBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x8990130", Offset = "0x898EF30", VA = "0x188990130", Slot = "7")]
	public EKDPPHJHEGI HGOIOPFMNAJ(long NCGHDDJNJOM, long KAAGEAEADCM, FMBJDHFAPIA DFLHHMJDJCP, AJHDCFJNACE IJMPHHBDLBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
internal static class MGAEIFDFCGD
{
	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x8994D60", Offset = "0x8993B60", VA = "0x188994D60")]
	internal static byte[] JAFFELDOKAE(byte[] JMAPKDPGDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x8994B00", Offset = "0x8993900", VA = "0x188994B00")]
	public static void AHBMJDJAGFN(Stream DJJDFCKFJJM, byte[] EKAILIIMPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x8994B80", Offset = "0x8993980", VA = "0x188994B80")]
	public static bool FKHPBAJEDJA(Stream DJJDFCKFJJM, long JDNANMCLBIN, EBJOMGOFPGJ BNPKFONADEF, [Out] byte[] JGPHIBOPCIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
internal sealed class LMALABKNEKA : EKDPPHJHEGI, IEquatable<EKDPPHJHEGI>, IEquatable<LMALABKNEKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000821")]
	private readonly MAPNBPIIGEK HKABBFFAOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000822")]
	public readonly FileInfo CFFOBGOMIIP;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public IOJOJEPJCBE MOHBAOOHPPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x8212DD0", Offset = "0x8211BD0", VA = "0x188212DD0", Slot = "9")]
		get
		{
			return default(IOJOJEPJCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public DateTime OCDCBHPKDAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x89936E0", Offset = "0x89924E0", VA = "0x1889936E0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x8993820", Offset = "0x8992620", VA = "0x188993820")]
	public LMALABKNEKA(MAPNBPIIGEK MJLDNPIJIAA, FileInfo OLHFKEJKLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x8993770", Offset = "0x8992570", VA = "0x188993770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x8993620", Offset = "0x8992420", VA = "0x188993620", Slot = "5")]
	public void NFMIGJKFHNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x8993330", Offset = "0x8992130", VA = "0x188993330", Slot = "6")]
	public bool CDCLNLCMCOD(long NCGHDDJNJOM, long KAAGEAEADCM, [Out] FMBJDHFAPIA DFLHHMJDJCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x8993370", Offset = "0x8992170", VA = "0x188993370", Slot = "7")]
	public bool Equals(EKDPPHJHEGI LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x89934D0", Offset = "0x89922D0", VA = "0x1889934D0", Slot = "8")]
	public bool Equals(LMALABKNEKA LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x89933E0", Offset = "0x89921E0", VA = "0x1889933E0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x8993590", Offset = "0x8992390", VA = "0x188993590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
public delegate void EBJOMGOFPGJ(FCIKBGAKGPJ.FIMFMEDFMFD PNGPALFFEGN, string IIHOFBLPONF);
[Cpp2IlInjected.Token(Token = "0x20001D4")]
internal interface FCMLHHLLHMO
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	IOJOJEPJCBE MOHBAOOHPPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NEKGNNOJHIJ(long NCGHDDJNJOM, long KAAGEAEADCM, AJHDCFJNACE IJMPHHBDLBM, [Out] EKDPPHJHEGI LICJOHINBNE);

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<EKDPPHJHEGI> OJHJEELJOIN(AJHDCFJNACE IJMPHHBDLBM);

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EKDPPHJHEGI HGOIOPFMNAJ(long NCGHDDJNJOM, long KAAGEAEADCM, FMBJDHFAPIA DFLHHMJDJCP, AJHDCFJNACE IJMPHHBDLBM);
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
