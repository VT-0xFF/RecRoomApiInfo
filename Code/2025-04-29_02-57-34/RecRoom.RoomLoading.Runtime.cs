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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x82CDA30", Offset = "0x82CCE30", VA = "0x1882CDA30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
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
	public class LogRegistrationIndex : EEFEEDICGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82C9B10", Offset = "0x82C8F10", VA = "0x1882C9B10", Slot = "4")]
		public override void KECNLMAOALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82D4D80", Offset = "0x82D4180", VA = "0x1882D4D80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x25D0340", Offset = "0x25CF740", VA = "0x1825D0340")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JMGMBEKCENO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x82C66B0", Offset = "0x82C5AB0", VA = "0x1882C66B0")]
	public JMGMBEKCENO(string FGEBHLNNMNH, Exception BNECGNPLEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class ILMBIMKHPGG : BPMOOPKAJBC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct JPLCBECEOKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<IFADHLGHNJJ>> <>t__builder;

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
		private TaskAwaiter<IDDECIIKCLK<MJKAJBCBAGM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82C7FC0", Offset = "0x82C73C0", VA = "0x1882C7FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82C8200", Offset = "0x82C7600", VA = "0x1882C8200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct IPMGEEGMJCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<PDBLABCCIPH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<PDBLABCCIPH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82C37B0", Offset = "0x82C2BB0", VA = "0x1882C37B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82C39C0", Offset = "0x82C2DC0", VA = "0x1882C39C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	[UnityEngine.Scripting.Preserve]
	public ILMBIMKHPGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82C26E0", Offset = "0x82C1AE0", VA = "0x1882C26E0", Slot = "4")]
	[AsyncStateMachine(typeof(JPLCBECEOKM))]
	public Task<IReadOnlyList<IFADHLGHNJJ>> LFEMLCGHGFK(long NFMLPECGLEO, long PIEICLNIOGJ, [Optional] CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x82C2800", Offset = "0x82C1C00", VA = "0x1882C2800", Slot = "5")]
	[AsyncStateMachine(typeof(IPMGEEGMJCO))]
	public Task<IReadOnlyList<PDBLABCCIPH>> PLKJBJOAIOD(IReadOnlyList<int> LHJMNBACKEH, [Optional] CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CMGPFHMBEEF : IEquatable<CMGPFHMBEEF>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int EDCLPPNJMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	PDBLABCCIPH HJGDCPLEBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime OKPLEINNCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	OIGNCMMGMJK? MNBMLDMELID
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HNAPNCECNKA? ANLEMCBODOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	FKEBBNGNCDO OIIFFOHGFNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<AEALKLKILHL> JJMGLCBECEJ();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum FKEBBNGNCDO
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BPMOOPKAJBC
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<IFADHLGHNJJ>> LFEMLCGHGFK(long NFMLPECGLEO, long PIEICLNIOGJ, [Optional] CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<PDBLABCCIPH>> PLKJBJOAIOD(IReadOnlyList<int> LHJMNBACKEH, [Optional] CancellationToken JDDHIJBJNHP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class APDJOAGDGFF
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class CNJFAMKNBPC : CMGPFHMBEEF, IEquatable<CMGPFHMBEEF>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct EBIJFJJEBHO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<AEALKLKILHL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public CNJFAMKNBPC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private FMJFPDLMNBB <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<HNAJHGJKLNP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<AEALKLKILHL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x82B67C0", Offset = "0x82B5BC0", VA = "0x1882B67C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x82B6D50", Offset = "0x82B6150", VA = "0x1882B6D50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly IFADHLGHNJJ GJIKAOOHNCI;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int EDCLPPNJMAA
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9D5BF0", Offset = "0x9D4FF0", VA = "0x1809D5BF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PDBLABCCIPH HJGDCPLEBOI
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime DAKIDIJJKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x82B56F0", Offset = "0x82B4AF0", VA = "0x1882B56F0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OIGNCMMGMJK? MNBMLDMELID
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B510", Offset = "0x6B7A910", VA = "0x186B7B510", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public HNAPNCECNKA? ANLEMCBODOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x292A7E0", Offset = "0x2929BE0", VA = "0x18292A7E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public FKEBBNGNCDO OIIFFOHGFNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xBB21D0", Offset = "0xBB15D0", VA = "0x180BB21D0", Slot = "10")]
			get
			{
				return default(FKEBBNGNCDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x82B55F0", Offset = "0x82B49F0", VA = "0x1882B55F0", Slot = "9")]
		[AsyncStateMachine(typeof(EBIJFJJEBHO))]
		public Task<AEALKLKILHL> JJMGLCBECEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x82B5750", Offset = "0x82B4B50", VA = "0x1882B5750")]
		public CNJFAMKNBPC(int MMJEMHLCMDC, PDBLABCCIPH IGHCHPGJHDD, IFADHLGHNJJ GJIKAOOHNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x82B54E0", Offset = "0x82B48E0", VA = "0x1882B54E0", Slot = "11")]
		public bool Equals(CMGPFHMBEEF DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x82B5440", Offset = "0x82B4840", VA = "0x1882B5440", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x82B5710", Offset = "0x82B4B10", VA = "0x1882B5710")]
		private bool PADODGOICLA(CNJFAMKNBPC DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x82B5570", Offset = "0x82B4970", VA = "0x1882B5570", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class NFHBHMPAEPN : CMGPFHMBEEF, IEquatable<CMGPFHMBEEF>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct NAFKBPPIGIH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<AEALKLKILHL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public NFHBHMPAEPN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<AEALKLKILHL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x82CC070", Offset = "0x82CB470", VA = "0x1882CC070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x82CC2C0", Offset = "0x82CB6C0", VA = "0x1882CC2C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly OKAHFFFFHHK EAPMIKOCHBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly OIGNCMMGMJK HBFDDIDJKEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly HNAPNCECNKA HIJEILELMIC;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int EDCLPPNJMAA
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x82CC860", Offset = "0x82CBC60", VA = "0x1882CC860", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public PDBLABCCIPH HJGDCPLEBOI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x82CC5F0", Offset = "0x82CB9F0", VA = "0x1882CC5F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime DAKIDIJJKGN
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x82CC770", Offset = "0x82CBB70", VA = "0x1882CC770", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public OIGNCMMGMJK? MNBMLDMELID
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x82CC7C0", Offset = "0x82CBBC0", VA = "0x1882CC7C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public HNAPNCECNKA? ANLEMCBODOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x82CC810", Offset = "0x82CBC10", VA = "0x1882CC810", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public FKEBBNGNCDO OIIFFOHGFNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xBA6200", Offset = "0xBA5600", VA = "0x180BA6200", Slot = "10")]
			get
			{
				return default(FKEBBNGNCDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1DDB180", Offset = "0x1DDA580", VA = "0x181DDB180")]
		public NFHBHMPAEPN(OKAHFFFFHHK BPEIEPPOFBB, OIGNCMMGMJK DAPEHFHJGPE, HNAPNCECNKA GGGBFNNAFND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x82CC680", Offset = "0x82CBA80", VA = "0x1882CC680", Slot = "9")]
		[AsyncStateMachine(typeof(NAFKBPPIGIH))]
		public Task<AEALKLKILHL> JJMGLCBECEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x82CC4D0", Offset = "0x82CB8D0", VA = "0x1882CC4D0", Slot = "11")]
		public bool Equals(CMGPFHMBEEF DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82CC420", Offset = "0x82CB820", VA = "0x1882CC420", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x82CC8A0", Offset = "0x82CBCA0", VA = "0x1882CC8A0")]
		private bool PADODGOICLA(NFHBHMPAEPN DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82CC570", Offset = "0x82CB970", VA = "0x1882CC570", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class GHOBMIKCJDC : CMGPFHMBEEF, IEquatable<CMGPFHMBEEF>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct ALMNNFFNALM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<AEALKLKILHL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<AEALKLKILHL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x82B4360", Offset = "0x82B3760", VA = "0x1882B4360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x82B45C0", Offset = "0x82B39C0", VA = "0x1882B45C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly PDBLABCCIPH OCEGLEELGAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly OIGNCMMGMJK HBFDDIDJKEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly HNAPNCECNKA HIJEILELMIC;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int EDCLPPNJMAA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x82BA000", Offset = "0x82B9400", VA = "0x1882BA000", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public PDBLABCCIPH HJGDCPLEBOI
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime DAKIDIJJKGN
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public OIGNCMMGMJK? MNBMLDMELID
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x82B9F60", Offset = "0x82B9360", VA = "0x1882B9F60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HNAPNCECNKA? ANLEMCBODOC
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x82B9FB0", Offset = "0x82B93B0", VA = "0x1882B9FB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public FKEBBNGNCDO OIIFFOHGFNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "10")]
			get
			{
				return default(FKEBBNGNCDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1DDB180", Offset = "0x1DDA580", VA = "0x181DDB180")]
		public GHOBMIKCJDC(PDBLABCCIPH IGHCHPGJHDD, OIGNCMMGMJK DAPEHFHJGPE, HNAPNCECNKA GGGBFNNAFND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82B9E90", Offset = "0x82B9290", VA = "0x1882B9E90", Slot = "9")]
		[AsyncStateMachine(typeof(ALMNNFFNALM))]
		public Task<AEALKLKILHL> JJMGLCBECEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x82B9D90", Offset = "0x82B9190", VA = "0x1882B9D90", Slot = "11")]
		public bool Equals(CMGPFHMBEEF DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x82B9D10", Offset = "0x82B9110", VA = "0x1882B9D10", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82B9E00", Offset = "0x82B9200", VA = "0x1882B9E00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x82BA020", Offset = "0x82B9420", VA = "0x1882BA020")]
		private bool PADODGOICLA(GHOBMIKCJDC DMMBOHMLHLF)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct JNAKANHLPAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<CMGPFHMBEEF>> <>t__builder;

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
		public APDJOAGDGFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<IFADHLGHNJJ> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<IFADHLGHNJJ>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, PDBLABCCIPH account, IFADHLGHNJJ roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x82C70F0", Offset = "0x82C64F0", VA = "0x1882C70F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x82C7F50", Offset = "0x82C7350", VA = "0x1882C7F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct POPAEGNLNAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, PDBLABCCIPH account, IFADHLGHNJJ roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<IFADHLGHNJJ> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public APDJOAGDGFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<PDBLABCCIPH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x82D2FF0", Offset = "0x82D23F0", VA = "0x1882D2FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x82D3A00", Offset = "0x82D2E00", VA = "0x1882D3A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly AAAHBLPOIEC BDBNDNPKEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly BPMOOPKAJBC BLPLLECMIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly AGCKBMHAENJ BNINHFLCCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly DBCKBHEENGK<(long, long), IReadOnlyList<IFADHLGHNJJ>> FMOIGDELAMI;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x82B4A30", Offset = "0x82B3E30", VA = "0x1882B4A30")]
	[UnityEngine.Scripting.Preserve]
	public APDJOAGDGFF([MGCCDFKFGBG(null)] BPMOOPKAJBC CIDAMCAMMJO, [MGCCDFKFGBG(null)] AGCKBMHAENJ NACBOPJLNPA, [MGCCDFKFGBG(null)] AAAHBLPOIEC LCOOHFJHNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x82B4630", Offset = "0x82B3A30", VA = "0x1882B4630")]
	[AsyncStateMachine(typeof(JNAKANHLPAE))]
	public Task<IList<CMGPFHMBEEF>> EIMFIPJIAPC(long NFMLPECGLEO, long AKJILJJKOFL, bool DKKHFDFDCEO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x82B4780", Offset = "0x82B3B80", VA = "0x1882B4780")]
	private bool JJDIDDLNKNM(DateTime? ECCJEFJDEHM, long NFMLPECGLEO, long AKJILJJKOFL, [Out] OKAHFFFFHHK OLLDGDPALBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82B4920", Offset = "0x82B3D20", VA = "0x1882B4920")]
	[AsyncStateMachine(typeof(POPAEGNLNAG))]
	private Task<IReadOnlyList<(int, PDBLABCCIPH, IFADHLGHNJJ)>> KIHINHGCPDI(IReadOnlyList<IFADHLGHNJJ> MNGBPFHLNLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface AGCKBMHAENJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<OKAHFFFFHHK> PBCILEOGODB;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AMIKABIIOLG(long NFMLPECGLEO, long AKJILJJKOFL, BNHNOHNOJEM HOEAFNFMMDO, FOBHJDGLMCB CJFNFMAHILH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DPNCCPJCDIC(long NFMLPECGLEO, long AKJILJJKOFL, [Out] OKAHFFFFHHK OLLDGDPALBP);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BPFCPKCLOKB(long NFMLPECGLEO, long AKJILJJKOFL, FOBHJDGLMCB CJFNFMAHILH, [Out] OKAHFFFFHHK OLLDGDPALBP);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OCNBBAFFJON(long NFMLPECGLEO, long AKJILJJKOFL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface IIEIJMHMIDP : GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool GLMEEDOPBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task JFNCJNMHMBI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGFPFJBJIKM(Task OOCBIOLELBN, string CMKCIMANDJC);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface DNIHMPAIOAJ : GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AEALKLKILHL> LELHEAIKDPF(OKAHFFFFHHK OLLDGDPALBP);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FAHDBKJLFDG(CancellationToken JDDHIJBJNHP);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface NGJOOKOOPFO : GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	AMEIOOCAHKO HBFAKPBIGNB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAAGCFKNBKI();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PIIKKOKPHEK();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface GIBBKBNAGGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ENMMELFAOHH(LHLFHJJLIPN CNCGLFBHFNK);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface AILCPENEKDG
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan EFKFEJEBDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan BJDDOJMEDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan GGGONIJMOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan OAIGMCNHHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool GBMEJBCAIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool BBDNHMPPCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool LDKEAIIDOLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int LCDHNIKDCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool MOJIFCKKFHG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool JLJEOHONAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool GBLIIBFAJAD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum MFFBAMMDBEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum BJGBMLOIFEK
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
public struct AFEHEDCGLIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long HIGHEGOCLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long PIEICLNIOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly MFFBAMMDBEJ KHNCICOHHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception BNIALJJFHMI;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x82B4340", Offset = "0x82B3740", VA = "0x1882B4340")]
	public AFEHEDCGLIC(long HIGHEGOCLFP, long PIEICLNIOGJ, MFFBAMMDBEJ KHNCICOHHHJ, [CanBeNull] Exception BNIALJJFHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x82B42F0", Offset = "0x82B36F0", VA = "0x1882B42F0")]
	public static AFEHEDCGLIC AIJMHMNEAAE(ECGOJJLBFIL CAKIDGFMJNN, MFFBAMMDBEJ KHNCICOHHHJ, [Optional] Exception BNIALJJFHMI)
	{
		return default(AFEHEDCGLIC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void FMIINANPHEH(AFEHEDCGLIC NOKOGAFLODM);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface JDFLHGHEICC : GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HPILDCGMEKP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event FMIINANPHEH AFDMLPANCFF;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event FMIINANPHEH IEEENNDGGFP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event FMIINANPHEH OMNFOOFJJGD;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<BJGBMLOIFEK, bool> IGAJHHMLJJA;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FJDLNAJAFNA();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EIGLHJKBHKN(AFEHEDCGLIC NOKOGAFLODM);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GGDDCPBAPFG(AFEHEDCGLIC NOKOGAFLODM);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HPFMMMPHFLD(AFEHEDCGLIC NOKOGAFLODM);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IKLNFOGEFKJ(BJGBMLOIFEK LODIOJIJDAO, bool LCNFJJJGFFM);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface DPHHHFAFOFC : GIBBKBNAGGA, IDisposable
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

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool LGGFFEKEKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PPMJOCEOLBK(Reason HJCCPGPOLBJ = Reason.Unknown);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NLENLDEEDJF();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface OJOCFDFOCPF : GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus IADCJDCOMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IEAOMFPLDPL(ECGOJJLBFIL EEAMAAFGDPN, PJKLHEMEKPG GJICGBGEIJI, CancellationToken EKBICDMGFBA);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class DFMENGAOLKD
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x82B6460", Offset = "0x82B5860", VA = "0x1882B6460")]
	public static bool IMBBGJDGGEG(this OJOCFDFOCPF EAPLEJDFFDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task NEBPKINFJKK(CancellationToken PAHPIGHLKFG, int MNNHJBJAAJF, JMJBOEJBCPI CLOPLKJEDAD);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface JJDMBPKALHJ : GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMGNOEGFENF(NEBPKINFJKK NGNCMLKIIIK);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface LHLFHJJLIPN : FMJFPDLMNBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken PPMCHGHEHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	NPCGGDCACLM PGDHIHIMLOF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	LPHAKFKHFIH KGPHOKLMHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	LNAEMNOKNDE NJCNJIFIECM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	LLKLGIOAOCK GHCAPJHEIJG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HKEHHDOFEDF PJOAPNBILMO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	KABGKKMFHEJ PIDBLCEOAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	BEPNFOFFIEI FODLCAMGADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	EALPINOJEEF DCKOIDIFNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	IIEIJMHMIDP PLHPEIJFFPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	DNIHMPAIOAJ AFBEOGPMOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	JDFLHGHEICC FEMFIFKECIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	DPHHHFAFOFC KAFGBKKFJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	OJOCFDFOCPF DBKBHPOPOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	JJDMBPKALHJ EDEMBEAAKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KOAMAHKJIOG LFEAAMDAILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	JLCPDDFBFLB KGBCJPIKPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GBECEDNOEAP NONPJPNOEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	ECFEJGBAEFH HEMDILNOCOB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	DCHGLMHEJOH HJFDKAEKEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	KDADCPFMPNP IDLKHKCCLCO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	BMLOHPGFPPG IBPEFGMNBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	GJCFGAAANPB HOBFHBOBIKM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	MKNLELNHKFD MFHGPEDCKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	DDPNMHJOMBG LFOGGNDDDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	NGJOOKOOPFO JDGIPLNAFML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AILCPENEKDG FGJADDOICBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	KFEOAJAPKPO GAKLLMFJHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AGCKBMHAENJ EHJCNNPJFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	JCELCBHKANI DLCGPLAEELE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	JCINOMLBHPJ FBEGABAMIBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	JOLGBJEMEGL OFPBDDJKJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	MGPCNPKFNKG ANOIHAKOJCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool NDPJJOJHHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void EPMDBJLMJEB(PJKLHEMEKPG LEPIIJFLLND);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface KOAMAHKJIOG : GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JMDIMJDCLIF FGAAHPGCDNG(Guid IAFOFMFFKIO);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NMPKBAOEGPN(Guid IAFOFMFFKIO);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FEACEIJBACD(Guid IAFOFMFFKIO, Task DMAKFDFMNKC);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AONCHGBEKOO(Guid IAFOFMFFKIO, AEALKLKILHL CCGCGHIBJGG);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(AEALKLKILHL, Task)> BPHFAGJAJJB(Guid IAFOFMFFKIO);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface AOLJKEMGNBI : GIBBKBNAGGA, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface JLCPDDFBFLB : GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFMMHIPOGCO(HOGPILOHPJM FGEBHLNNMNH);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMJKGNDIDEL(HOGPILOHPJM FGEBHLNNMNH);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<MCCMJJHBLDP> FNPJNIJFBLM(CancellationToken LGNBGINOHHF);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface GBECEDNOEAP : GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JMDIMJDCLIF KFDEOANBEGO(HOGPILOHPJM EPBKIEHJJCK);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFABBCFMNIC(Guid IAFOFMFFKIO, Task DMAKFDFMNKC);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface ECFEJGBAEFH : GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AEALKLKILHL> HEMDILNOCOB(HOGPILOHPJM MFKNAHPEKFH);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface DCHGLMHEJOH : GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JKNOMNBJNEB> FBCGNGLLIJP(BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, ECGOJJLBFIL EEAMAAFGDPN, CancellationToken JDDHIJBJNHP);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface BMLOHPGFPPG : GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AEALKLKILHL NOHLBKPOEKA(EKIKILMCLIO IKIPBIHEFBA);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JBNBKIHFLLD(string BHKOPEBBFJK);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface KDADCPFMPNP : GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HOGPILOHPJM> NBEOBCBCNBF(HOGPILOHPJM LFFAIMMKIAM, LJOHHGILGBC OFCENAICMPD, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<HOGPILOHPJM> ADALFFIIPGD(CancellationToken JDDHIJBJNHP, LJOHHGILGBC OFCENAICMPD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EKCMCCJKLGK ODJANFIKEMA(PJCDBCNMOMI EJDEDAIJHNC, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EKCMCCJKLGK JNKOOGMMODG(PJCDBCNMOMI EJDEDAIJHNC, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface GJCFGAAANPB : GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AEALKLKILHL LBILBHJLBLE(EKIKILMCLIO IKIPBIHEFBA, MCCMJJHBLDP FILHOBMLBKK);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AEALKLKILHL EBAOEAELIDG(EKIKILMCLIO JODMALNMLGA);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface NCIFNOGPKJP
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	const int KMMIPCPFDHL = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, LMLJCJPPDDD> LLKJOKMNJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action AFEDEMCNJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<Guid> OMMCJOBCINH();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task GKJFBOHOMME([Optional] CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ENNFCKJNOAB([Optional] CancellationToken JDDHIJBJNHP);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface MKNLELNHKFD
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHIGEJOHNKI(BGHJMLKLCPN HIPHPEMEAGM);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEHBHMKOMHA(BGHJMLKLCPN HIPHPEMEAGM);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOMIDJBIHEE(BGHJMLKLCPN HIPHPEMEAGM);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LKBMONLLLDB(BGHJMLKLCPN HIPHPEMEAGM);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class BGHJMLKLCPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly ECGOJJLBFIL JMOMOCLPNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Dictionary<string, string> MOOKIPENKLO;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public BNJJFADPKOK<string> KOGMPLEGCMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9CCC50", Offset = "0x9CC050", VA = "0x1809CCC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	public BGHJMLKLCPN(ECGOJJLBFIL OINOCKJMHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x82B5230", Offset = "0x82B4630", VA = "0x1882B5230")]
	public BGHJMLKLCPN NLGDLJBECHK(string IICGAABOENK, string OOEMJLHLIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x82B51A0", Offset = "0x82B45A0", VA = "0x1882B51A0")]
	public bool DEGHINKEJFD([Out] IEnumerable<KeyValuePair<string, string>> JEHKFJFGPOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x71A4270", Offset = "0x71A3670", VA = "0x1871A4270")]
	public BGHJMLKLCPN CICGEEHGIME(BNJJFADPKOK<string> IHAAMEONBJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface KFEOAJAPKPO
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool LDGMEKGAEEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string BMMAGBCJLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool NIBGKHGIFDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EDIMNPLIDMO();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DLOKMMGDHPN HNJKCGJNJJK(long DHKHJPCIEKA);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HPAENFOLHFM<GPEOIJBIPCA, KPMJDHJBPEL> BCNFAGDIFKM(long DHKHJPCIEKA);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HPAENFOLHFM<GPEOIJBIPCA, MMIOGOBDHFC> LLEIEEHKPPF(long DHKHJPCIEKA);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HPAENFOLHFM<long, CLFCELJMAMP> LNBHPCNNIKF();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<FKNKAHPIOKE>> FLCAHCFGNDA(long DHKHJPCIEKA, IReadOnlyCollection<FKNKAHPIOKE> GBPDKGNONEO, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IGMKJBNILBL(long DHKHJPCIEKA, [Out] bool DDLNOBPOOEN);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> KEOPKGMEGCO(byte[] PBNEIBAJIIG, byte[] JJMNDMDKNDJ, IReadOnlyCollection<Guid> HIJDDAFCGBD, CancellationToken JDDHIJBJNHP);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface PJDACJNGEOD
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JKNOMNBJNEB BPKMLDCMEGB(long HIGHEGOCLFP, long PIEICLNIOGJ, string LOLPCFDIILM);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JKNOMNBJNEB BPKMLDCMEGB(long HIGHEGOCLFP, long PIEICLNIOGJ, GPEOIJBIPCA PBNEIBAJIIG, Guid? OGDLKIJEAFA, long KDAFCLHLBDB, bool NGJGPIHJCIN);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JKNOMNBJNEB BPKMLDCMEGB(EAOAOGAEAGM IBFJPIPBFOF);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JKNOMNBJNEB BPKMLDCMEGB(HNAJHGJKLNP CNMCCLMMOAL, IFADHLGHNJJ DJHDCDENBCA);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface FMJFPDLMNBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool IMBBGJDGGEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool FOGEECCPIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool NDPJJOJHHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	PJDACJNGEOD BDFEDEJNAKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	PJKLHEMEKPG CAOCHKFBFHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action HPILDCGMEKP;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FMIINANPHEH AFDMLPANCFF;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event FMIINANPHEH IEEENNDGGFP;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event FMIINANPHEH OMNFOOFJJGD;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<BJGBMLOIFEK, bool> IGAJHHMLJJA;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NLENLDEEDJF();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HABAAAJBIHC NCMNIEJELFA();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DFMADOPCDNL LIOIEBDPFOC();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task AEAICJAEBEM(int MBANJJBOKOG, OOGIILPNHKC AFEEILJEPLN, Func<BNHNOHNOJEM, BNHNOHNOJEM> HOPMAEGNHBN);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<AEALKLKILHL> LELHEAIKDPF(OKAHFFFFHHK BPEIEPPOFBB);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task FAHDBKJLFDG(CancellationToken JDDHIJBJNHP);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface HKEHHDOFEDF
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool GMMBLFIAPAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool JIJLMMJKBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? LIIEPEHCEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDJCPHAEAFO(Scene DMCBHKAGONH);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task KHPPDMMIFOP(KDFBLPMDGJH CPGKAKPIBFI, IReadOnlyList<KDFBLPMDGJH> CCDOBLGEHKO, IReadOnlyList<KDFBLPMDGJH> CAAIBJCDFEH, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ILCCJLMHKGH(BJEBFEBDAOA KLAOLAACHFK);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task JCHEOLKKGMO(IReadOnlyList<Guid> JODFPEAPDGK, CancellationToken KJGCCFDCINO);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IOPIMMFHANC EADLEEEBJHL();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task DLHBGLGPGCD();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task DCJLDBNDHBH();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface LLKLGIOAOCK
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	EOFPDHAABFM OHFFLHAGGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool MLPEHNOCJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool CMEAJENJECO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool AMGKLBJBOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool NJDFDNIGKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int PFCJHJFKEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool EPNGNNPCHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool KHFJGCKCPHC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int OMDNMNLLDFN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int EOOENDIEFBN
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool IAFLFDNDJCH
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool MCPCPAGMOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool MHFNPCLBOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float DLNEBNHNMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> JGFCMDLHFMA;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NPCGGDCACLM KIGIICKMNFI(NPCGGDCACLM GBALDODBKFK);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFAILNJNMJG(NPCGGDCACLM INELJPKBMLP);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AJMECGNKHCJ();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task PGLAGEELLGP(BNJJFADPKOK<string>.EFJIBBJEOLP KMPANFNMAGG, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AFGDKKDOEJP(float DPADJBEFPIN);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OMEDMCMODFA(string LPHIFBBKFHF);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<OOEHAOJOEMN> GCFDDMNCOCJ();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable OGOHKNJGGBA(object FAJBNOJIOHK, OOEHAOJOEMN CBFIOILKHPI);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<BPEMJMDHKBJ> MKIHMLBECDI();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KPMJDHJBPEL JBGMJBACCLI(IEnumerable<IBDHKNDIHNK> LDAIHJLBDPI);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JKOMHNDMOBO(int PEHFPIIENIB);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task GBICMEDDOHH();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GOKNBAPCJAI();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool HENCGAIAADI();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task NGBDJIJFFKP(CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task ADAALDNPMDB(CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<AHKNMGFDAAG> KPHEMOIPIPD(DateTime CNLLCFENHMC, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> DEGECFDIAKH(CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PPDICMLIDHP(string FGEBHLNNMNH = "", float JGFPKIBNFLI = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "25")]
	GGHCNLJOJLN JCLOOCCGBGP(PMJGODHIFMK DDMFAOHNAGN, OGDDCPBMNHF OBICHNFPNBD, MMIOGOBDHFC IAAOGIMLPPP, IEnumerable<PersistenceView> FHCGJOMGIEP, MLEJOHEHBLD DFMGFJGFHAC);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void AOIMGMAGHKM(MMIOGOBDHFC IAAOGIMLPPP);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void PMEMOILGEGI(IBDHKNDIHNK GEBIOONDCDF, [In] GGHCNLJOJLN IHEHFNAIPPM);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task GFGIABPIGKG(MMIOGOBDHFC HEDMDBBDAPE, bool EEOIMMODCNC, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task AFGGNEONHGF(CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void BOKMGHLGLGK(long NFMLPECGLEO, long PIEICLNIOGJ, HNAJHGJKLNP LBIMIKPLDOP, IFADHLGHNJJ ACCFHJLGBCI, BNHNOHNOJEM HOEAFNFMMDO, OOGIILPNHKC? AFEEILJEPLN, NBFKFCCDAMP? ECBCIOLFNJL);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void NFCEJJOOIJG(long NFMLPECGLEO, long PIEICLNIOGJ, NBFKFCCDAMP? ECBCIOLFNJL);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void KCMNAPBCEJC(PersistenceView FKEOMLCOOEP);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void NHEJDIIGOAE(string OGLLNGIKJKE, ECGOJJLBFIL OINOCKJMHLO, CNCGCLBFAKP AOLFIBBKOEG, [Optional] string? FAPCOIIDPGJ, [Optional] string? NMDJHILGNNN, [Optional] string? BIGDFONAIBK);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool INEJOHGOFPP(PersistenceView KNHIPANAKJG);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool FBAMGDLDKKG(IBDHKNDIHNK GEBIOONDCDF, KFOIBDNOLMJ LBKIKJEFAFK, [Out] KKBBLNDJLCH OBNFOGKGCJL);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task MDKFCOAAHIO(CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void PFPONBBLBPP();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable CNBBLIOLCIF();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void OJHJKCPLNOI(MMIOGOBDHFC HEDMDBBDAPE, KFOIBDNOLMJ LBKIKJEFAFK);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> LAHAKHMBNJI(LPHAKFKHFIH MFHPJCBDCMN, CancellationToken JDDHIJBJNHP, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void HBJDPABFMJH(CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<EAOAOGAEAGM> KFMOMDHJFJP(MPJDGNCKIFC LFFAIMMKIAM);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<HNAJHGJKLNP> OPGDEHOPBJO(long NFMLPECGLEO, bool GJPBIDKPIAB, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<MJKAJBCBAGM> EICIKMKHANE(long NFMLPECGLEO, long PIEICLNIOGJ, long KDAFCLHLBDB, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<MJKAJBCBAGM> BKOAOECDIMD(long NFMLPECGLEO, long PIEICLNIOGJ, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<JDNBODNOFNG> ODAJDIMNFMD(long NFMLPECGLEO, Guid FNGOGIEIAAI, long? AKJILJJKOFL, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "47")]
	HPAENFOLHFM<JDNBODNOFNG, IEnumerable<APCBODKDHBC>> NFMLKKNJFNO();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<GKCPDEPPDCM> EJFGKIDEOBL(string LOLPCFDIILM, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<GKCPDEPPDCM> OBABLOFNEDP(string LOLPCFDIILM, long NFMLPECGLEO, long PIEICLNIOGJ, Guid? CFEIEOEJEOL, NOEKHCGOBMH.OEKGMIBHJGE NILNGFKCINL, NOEKHCGOBMH.OEKGMIBHJGE JJMNDMDKNDJ, int MBANJJBOKOG);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool KNOPHLKAMJF();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool CPIIBHOJKGD();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool NPCDIIHGFMH(IEnumerable<KKBBLNDJLCH> JCMBMIIBIHA);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void OILIBHLMLNK(List<GameObject> JLPNENAODDD);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float IFKKLJBNMLM();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> FOOHCIFGPDM(CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> GHDFIHHDIDL(string OGBJCLBNMBK, LoadSceneMode JMOGLIIJCHM, bool MAONBEFDDAD, BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void CJKFPMGBGLL();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void OAOHDCDGMJE(bool PBPBGDAIGID);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void AMBMCFDHIGG();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void OMHECPPHAEF();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void GAHIFEDHIAD(bool AOCGMMLFJAN);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task<NOEKHCGOBMH.OEKGMIBHJGE> HNONHLGCCKD(byte[] AOFGGGKINCN, NOEKHCGOBMH.GLCMOBMPHCI HCICKEEKIKL, MHLPLEKFJHG IDOFJPKIEEI, [Optional] IReadOnlyCollection<string>? JHLJEDELNJL, [Optional] string? BFALMAMHKBO);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void AIDNHOJGPOB(ECGOJJLBFIL HJBOHCENIMO);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task HIHONBHFKIP(BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task CDHJCGJIJNJ(BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task HPGINOHEGFL(BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "77")]
	Task APMPJFHOPJI(BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "78")]
	IDisposable IPKKMMBLHFO();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "79")]
	BACFOGGJNFO OEEJKPDDEAD();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "80")]
	Task IGBPCCFEIID(CancellationToken JDDHIJBJNHP);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface BACFOGGJNFO
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HJDEOIDOFAP(CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LIJPGPPPOFI(CancellationToken JDDHIJBJNHP);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct GGHCNLJOJLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public HashSet<int> PPFDCJKMLAO;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum AHKNMGFDAAG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct PMJGODHIFMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Guid? GNADLEHNJHJ;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface EOFPDHAABFM
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	ECGOJJLBFIL DIEKANAMOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	HNAJHGJKLNP NCJAHPOHGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	HABMELLNJLH NDKAFLDGDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool MKHENCCPICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool BAAHFDHBIBM
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int BLIAJHICDIE
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action HHFCDLHBJKJ;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> HJEJFNAHKEA;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EGBMCBDKEBE();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.ACOMAKFMCHD> EBJAIBILEEO(long DHKHJPCIEKA, [Optional] CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<CPPOLMCEHHG> HIJINOJNGIC(ECGOJJLBFIL OINOCKJMHLO, [Optional] PJKLHEMEKPG GJICGBGEIJI);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<CPPOLMCEHHG> NDPKELAIMHB();

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task LJNJJJGNHDJ();

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(ECGOJJLBFIL, PJKLHEMEKPG) DHKAGKNAOLD();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "16")]
	HCOCEGBHFMI LMAKIFIBMAP();

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ELFJGEPAFOP(long DHKHJPCIEKA);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DMAJMFGFGBF(ECGOJJLBFIL OINOCKJMHLO, Matchmaking.NMCIDFEHOOJ APLCGCDLEGH, (int Major, int? Minor)? HJPLLMGICPE);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface DDPNMHJOMBG
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JAODBLJKFKI([Out] IEnumerable<int> JDJENJJICKN);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALKJIMINLPP(LIHEKALDDOB PAHPIGHLKFG);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DPPPAJKAGGH(LIHEKALDDOB PAHPIGHLKFG);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface CKNEFOLCLME
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OKJBNGODFHG(AEALKLKILHL KJGABACDPEM);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface HAJBBLGBNDD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AACCOKEIGFG(IOBFOHBHMME.IHEAJAEEAJO JBMAGACOOOO);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPPJECCICMA(IOBFOHBHMME.IHEAJAEEAJO JBMAGACOOOO);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface KABGKKMFHEJ : HAJBBLGBNDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AEALKLKILHL ONJANLKLBLM(EKIKILMCLIO JODMALNMLGA);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface BEPNFOFFIEI : HAJBBLGBNDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AEALKLKILHL NOHLBKPOEKA(EKIKILMCLIO HANDOEBGAFL);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface DLOKMMGDHPN
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BECHBBIPIFM<NAANJOANDLO, IDMJKCLDJLO>> HGLFENBAJBD(Guid? CFEIEOEJEOL, IReadOnlyCollection<FKNKAHPIOKE> GLGLOHHDCFP, IReadOnlyCollection<FKNKAHPIOKE> KHGANELLIAN, FLKCCIGLICB HICCNEPAKHG, long? NFMLPECGLEO, long? PIEICLNIOGJ, HCDGKADAPOC.CKFPKAEIJLL OPHFIDCCGMO, CancellationToken JDDHIJBJNHP);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class NAANJOANDLO
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public KDFBLPMDGJH PMDKMHGAABG
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<KDFBLPMDGJH> JKIOIIIBJGK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<KDFBLPMDGJH> MGNKGDOBEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xC237D0", Offset = "0xC22BD0", VA = "0x180C237D0")]
	public NAANJOANDLO(KDFBLPMDGJH MDMCDFPPJPD, IReadOnlyList<KDFBLPMDGJH> IAOMAFPLMOG, IReadOnlyList<KDFBLPMDGJH> ODLGAENFJCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface HPAENFOLHFM<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BECHBBIPIFM<JHFICJGOLCJ<TData>, IDMJKCLDJLO>> CMONDNKCJGH(TGetDataArg LICDMCPJILC, CancellationToken JDDHIJBJNHP);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class JLGEAHMPPFM : LHLFHJJLIPN, FMJFPDLMNBB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct JIFKFIJJLJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<AEALKLKILHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public JLGEAHMPPFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public OKAHFFFFHHK autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<AEALKLKILHL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x82C4060", Offset = "0x82C3460", VA = "0x1882C4060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x82C42E0", Offset = "0x82C36E0", VA = "0x1882C42E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct FLPCOCJEFAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public JLGEAHMPPFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x82B8630", Offset = "0x82B7A30", VA = "0x1882B8630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x82B8860", Offset = "0x82B7C60", VA = "0x1882B8860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class BDCEJACFPON : IEnumerable<GIBBKBNAGGA>, IEnumerable, IEnumerator<GIBBKBNAGGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private GIBBKBNAGGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public JLGEAHMPPFM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private GIBBKBNAGGA System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xE69660", Offset = "0xE68A60", VA = "0x180E69660")]
		[DebuggerHidden]
		public BDCEJACFPON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x82B4BA0", Offset = "0x82B3FA0", VA = "0x1882B4BA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x82B5000", Offset = "0x82B4400", VA = "0x1882B5000", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x82B4F50", Offset = "0x82B4350", VA = "0x1882B4F50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GIBBKBNAGGA> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x82B4F50", Offset = "0x82B4350", VA = "0x1882B4F50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CancellationTokenSource CANNMMPOOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly NPCGGDCACLM INELJPKBMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool LLMGCACGBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private IANMDOGKHEN CIGODLAJGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool ICELNLABCPC;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public LPHAKFKHFIH KGPHOKLMHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9CD800", Offset = "0x9CCC00", VA = "0x1809CD800", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9CD7E0", Offset = "0x9CCBE0", VA = "0x1809CD7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public LNAEMNOKNDE NJCNJIFIECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9CD810", Offset = "0x9CCC10", VA = "0x1809CD810", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9CD7F0", Offset = "0x9CCBF0", VA = "0x1809CD7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public LLKLGIOAOCK GHCAPJHEIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9CD860", Offset = "0x9CCC60", VA = "0x1809CD860", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9CD820", Offset = "0x9CCC20", VA = "0x1809CD820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public HKEHHDOFEDF PJOAPNBILMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9CD7D0", Offset = "0x9CCBD0", VA = "0x1809CD7D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9CD850", Offset = "0x9CCC50", VA = "0x1809CD850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public KABGKKMFHEJ PIDBLCEOAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9CD840", Offset = "0x9CCC40", VA = "0x1809CD840", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9CD830", Offset = "0x9CCC30", VA = "0x1809CD830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public BEPNFOFFIEI FODLCAMGADP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9D5B60", Offset = "0x9D4F60", VA = "0x1809D5B60", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9D5C00", Offset = "0x9D5000", VA = "0x1809D5C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public PJDACJNGEOD BDFEDEJNAKG
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9D5AB0", Offset = "0x9D4EB0", VA = "0x1809D5AB0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9D5AC0", Offset = "0x9D4EC0", VA = "0x1809D5AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public EALPINOJEEF DCKOIDIFNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9D5C70", Offset = "0x9D5070", VA = "0x1809D5C70", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9D5C20", Offset = "0x9D5020", VA = "0x1809D5C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public IIEIJMHMIDP PLHPEIJFFPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xBB23C0", Offset = "0xBB17C0", VA = "0x180BB23C0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x12684B0", Offset = "0x12678B0", VA = "0x1812684B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public DNIHMPAIOAJ AFBEOGPMOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9D5C80", Offset = "0x9D5080", VA = "0x1809D5C80", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9D5B70", Offset = "0x9D4F70", VA = "0x1809D5B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public JDFLHGHEICC FEMFIFKECIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xC9B070", Offset = "0xC9A470", VA = "0x180C9B070", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xE0CC00", Offset = "0xE0C000", VA = "0x180E0CC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public DPHHHFAFOFC KAFGBKKFJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E60", Offset = "0x9D3260", VA = "0x1809D3E60", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3EC0", Offset = "0x9D32C0", VA = "0x1809D3EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public OJOCFDFOCPF DBKBHPOPOOE
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xBE6830", Offset = "0xBE5C30", VA = "0x180BE6830", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xE18B10", Offset = "0xE17F10", VA = "0x180E18B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public JJDMBPKALHJ EDEMBEAAKIA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xD116C0", Offset = "0xD10AC0", VA = "0x180D116C0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xD116D0", Offset = "0xD10AD0", VA = "0x180D116D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public KOAMAHKJIOG LFEAAMDAILM
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xC9AEA0", Offset = "0xC9A2A0", VA = "0x180C9AEA0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x10E8A70", Offset = "0x10E7E70", VA = "0x1810E8A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public AOLJKEMGNBI OKJJLGMICMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xC85E40", Offset = "0xC85240", VA = "0x180C85E40", Slot = "62")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xD41390", Offset = "0xD40790", VA = "0x180D41390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public JLCPDDFBFLB KGBCJPIKPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA5F080", Offset = "0xA5E480", VA = "0x180A5F080", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA633D0", Offset = "0xA627D0", VA = "0x180A633D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public GBECEDNOEAP NONPJPNOEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9D3EB0", Offset = "0x9D32B0", VA = "0x1809D3EB0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9D3F00", Offset = "0x9D3300", VA = "0x1809D3F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public ECFEJGBAEFH HEMDILNOCOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA8ABA0", Offset = "0xA89FA0", VA = "0x180A8ABA0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xB4EC60", Offset = "0xB4E060", VA = "0x180B4EC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public DCHGLMHEJOH HJFDKAEKEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA67400", Offset = "0xA66800", VA = "0x180A67400", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA65F70", Offset = "0xA65370", VA = "0x180A65F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public KDADCPFMPNP IDLKHKCCLCO
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F230", Offset = "0xA5E630", VA = "0x180A5F230", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA6A9B0", Offset = "0xA69DB0", VA = "0x180A6A9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public BMLOHPGFPPG IBPEFGMNBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F260", Offset = "0xA5E660", VA = "0x180A5F260", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA5E740", Offset = "0xA5DB40", VA = "0x180A5E740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public GJCFGAAANPB HOBFHBOBIKM
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA8B570", Offset = "0xA8A970", VA = "0x180A8B570", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xB58970", Offset = "0xB57D70", VA = "0x180B58970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public MKNLELNHKFD MFHGPEDCKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA8B530", Offset = "0xA8A930", VA = "0x180A8B530", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA72080", Offset = "0xA71480", VA = "0x180A72080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public DDPNMHJOMBG LFOGGNDDDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA8B550", Offset = "0xA8A950", VA = "0x180A8B550", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9A0", Offset = "0xA7BDA0", VA = "0x180A7C9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public NGJOOKOOPFO JDGIPLNAFML
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA8B540", Offset = "0xA8A940", VA = "0x180A8B540", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA6EAD0", Offset = "0xA6DED0", VA = "0x180A6EAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public AILCPENEKDG FGJADDOICBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE50", Offset = "0xA6D250", VA = "0x180A6DE50", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA77CF0", Offset = "0xA770F0", VA = "0x180A77CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public KFEOAJAPKPO GAKLLMFJHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA8A450", Offset = "0xA89850", VA = "0x180A8A450", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xAA1C00", Offset = "0xAA1000", VA = "0x180AA1C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public AGCKBMHAENJ EHJCNNPJFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA74670", Offset = "0xA73A70", VA = "0x180A74670", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public JCELCBHKANI DLCGPLAEELE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA73B20", Offset = "0xA72F20", VA = "0x180A73B20", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public JCINOMLBHPJ FBEGABAMIBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA6F130", Offset = "0xA6E530", VA = "0x180A6F130", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public JOLGBJEMEGL OFPBDDJKJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA790E0", Offset = "0xA784E0", VA = "0x180A790E0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public MGPCNPKFNKG ANOIHAKOJCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA8A1C0", Offset = "0xA895C0", VA = "0x180A8A1C0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public PJKLHEMEKPG CAOCHKFBFHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA7D600", Offset = "0xA7CA00", VA = "0x180A7D600", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xF146D0", Offset = "0xF13AD0", VA = "0x180F146D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool DEPDNHPLLII
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x82C5630", Offset = "0x82C4A30", VA = "0x1882C5630", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool KEJGPJFMFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x82C5E00", Offset = "0x82C5200", VA = "0x1882C5E00", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool BCPJCGLJEDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1B81B70", Offset = "0x1B80F70", VA = "0x181B81B70", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken JIAKOOCGINL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x82C58F0", Offset = "0x82C4CF0", VA = "0x1882C58F0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private NPCGGDCACLM JIEKILBJFKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool FOGJONIGCIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1B81B70", Offset = "0x1B80F70", VA = "0x181B81B70", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1B7D460", Offset = "0x1B7C860", VA = "0x181B7D460", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action ENDKCKGMFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x82C5A50", Offset = "0x82C4E50", VA = "0x1882C5A50", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x82C5B10", Offset = "0x82C4F10", VA = "0x1882C5B10", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event FMIINANPHEH IJCNGNEOPDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x82C5970", Offset = "0x82C4D70", VA = "0x1882C5970", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x82C5690", Offset = "0x82C4A90", VA = "0x1882C5690", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event FMIINANPHEH CFLEFLGIINP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x82C5AB0", Offset = "0x82C4EB0", VA = "0x1882C5AB0", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x82C5430", Offset = "0x82C4830", VA = "0x1882C5430", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event FMIINANPHEH LBOKBPLPOJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x82C5910", Offset = "0x82C4D10", VA = "0x1882C5910", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x82C5890", Offset = "0x82C4C90", VA = "0x1882C5890", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<BJGBMLOIFEK, bool> ABHNOIOIMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x82C5E80", Offset = "0x82C5280", VA = "0x1882C5E80", Slot = "48")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x82C5830", Offset = "0x82C4C30", VA = "0x1882C5830", Slot = "49")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0xF146D0", Offset = "0xF13AD0", VA = "0x180F146D0", Slot = "39")]
	public void EPMDBJLMJEB(PJKLHEMEKPG LEPIIJFLLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x82C5FF0", Offset = "0x82C53F0", VA = "0x1882C5FF0")]
	[UnityEngine.Scripting.Preserve]
	internal JLGEAHMPPFM([MGCCDFKFGBG(null)] NPCGGDCACLM INELJPKBMLP, [MGCCDFKFGBG(null)] LPHAKFKHFIH MFHPJCBDCMN, [MGCCDFKFGBG(null)] LNAEMNOKNDE NPNCKHICDNP, [MGCCDFKFGBG(null)] LLKLGIOAOCK HLIKBEKBJPB, [MGCCDFKFGBG(null)] HKEHHDOFEDF CBMOIFCKAPP, [MGCCDFKFGBG(null)] KABGKKMFHEJ GDPCCIJMGOE, [MGCCDFKFGBG(null)] BEPNFOFFIEI DGOKMHMFACC, [MGCCDFKFGBG(null)] EALPINOJEEF IGNJCMAMHAP, [MGCCDFKFGBG(null)] IIEIJMHMIDP MNDMKGFPPMK, [MGCCDFKFGBG(null)] DNIHMPAIOAJ KJBLEMMFBFB, [MGCCDFKFGBG(null)] JDFLHGHEICC MGHLKNNNHOI, [MGCCDFKFGBG(null)] DPHHHFAFOFC IKACDKLNPPC, [MGCCDFKFGBG(null)] OJOCFDFOCPF EAPLEJDFFDI, [MGCCDFKFGBG(null)] JJDMBPKALHJ HIELIKJIKKP, [MGCCDFKFGBG(null)] KOAMAHKJIOG CAMCBGNDNHF, [MGCCDFKFGBG(null)] AOLJKEMGNBI JNOLJFPLNDJ, [MGCCDFKFGBG(null)] JLCPDDFBFLB PNPLGPGBLMB, [MGCCDFKFGBG(null)] GBECEDNOEAP MOBKOGOJAMJ, [MGCCDFKFGBG(null)] ECFEJGBAEFH JNOIMNFNGKM, [MGCCDFKFGBG(null)] DCHGLMHEJOH OPAKBIOPIAJ, [MGCCDFKFGBG(null)] BMLOHPGFPPG MHNMKEODBJA, [MGCCDFKFGBG(null)] KDADCPFMPNP EENGEPLMGHE, [MGCCDFKFGBG(null)] GJCFGAAANPB AJBDFGPLKBB, [MGCCDFKFGBG(null)] MKNLELNHKFD LABLCKKOCJK, [MGCCDFKFGBG(null)] DDPNMHJOMBG DKFEPDFCMDK, [MGCCDFKFGBG(null)] AILCPENEKDG ICLMPPLIKCJ, [MGCCDFKFGBG(null)] KFEOAJAPKPO IHPFPMMMOOH, [MGCCDFKFGBG(null)] AGCKBMHAENJ HJABEJBGFCM, [MGCCDFKFGBG(null)] JCELCBHKANI BOMFFALMBCE, [MGCCDFKFGBG(null)] JCINOMLBHPJ JGBKDONAMOO, [MGCCDFKFGBG(null)] JOLGBJEMEGL GEDDNLIABGA, [MGCCDFKFGBG(null)] MGPCNPKFNKG AMALOEIAOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x82C56F0", Offset = "0x82C4AF0", VA = "0x1882C56F0")]
	private void ENMMELFAOHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x82C5490", Offset = "0x82C4890", VA = "0x1882C5490", Slot = "61")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x82C5380", Offset = "0x82C4780", VA = "0x1882C5380", Slot = "53")]
	private void BANPOKFEFOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x82C5D70", Offset = "0x82C5170", VA = "0x1882C5D70", Slot = "54")]
	private HABAAAJBIHC NMFMLGOPNNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x82C57A0", Offset = "0x82C4BA0", VA = "0x1882C57A0", Slot = "55")]
	private DFMADOPCDNL FMFMLNICEAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x82C5070", Offset = "0x82C4470", VA = "0x1882C5070", Slot = "57")]
	public Task AEAICJAEBEM(int MBANJJBOKOG, OOGIILPNHKC AFEEILJEPLN, Func<BNHNOHNOJEM, BNHNOHNOJEM> HOPMAEGNHBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x82C5EE0", Offset = "0x82C52E0", VA = "0x1882C5EE0")]
	private CECMIPKLDKM PHOKHBOGJMG(int MBANJJBOKOG, OOGIILPNHKC AFEEILJEPLN, Func<BNHNOHNOJEM, BNHNOHNOJEM> HOPMAEGNHBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x82C5B70", Offset = "0x82C4F70", VA = "0x1882C5B70", Slot = "58")]
	[AsyncStateMachine(typeof(JIFKFIJJLJH))]
	private Task<AEALKLKILHL> MGLJLLHHEOA(OKAHFFFFHHK OLLDGDPALBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x82C5C80", Offset = "0x82C5080", VA = "0x1882C5C80", Slot = "59")]
	[AsyncStateMachine(typeof(FLPCOCJEFAD))]
	private Task NDLCKBCNGBP(CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x82C59D0", Offset = "0x82C4DD0", VA = "0x1882C59D0")]
	[IteratorStateMachine(typeof(BDCEJACFPON))]
	private IEnumerable<GIBBKBNAGGA> JJHEDDPPJNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x82C53D0", Offset = "0x82C47D0", VA = "0x1882C53D0")]
	[CompilerGenerated]
	private void DMFBOBBPEKI(GIBBKBNAGGA FBIFMODNLFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class BDIDCAIJIAJ : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x174AF50", Offset = "0x174A350", VA = "0x18174AF50")]
	public BDIDCAIJIAJ(string FGEBHLNNMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class DPDHDFDMJHE : BDNEJDNNBKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct HLDBBBAAIAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<BDNEJDNNBKC.BBBIEKEBHME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public HashSet<DPHHHFAFOFC.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public DPDHDFDMJHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x82BB650", Offset = "0x82BAA50", VA = "0x1882BB650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x82BB960", Offset = "0x82BAD60", VA = "0x1882BB960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly LHLFHJJLIPN CNCGLFBHFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly LLKLGIOAOCK HLIKBEKBJPB;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string DPAPPBHANIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x82B6710", Offset = "0x82B5B10", VA = "0x1882B6710", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x9CD730", Offset = "0x9CCB30", VA = "0x1809CD730")]
	public DPDHDFDMJHE(LHLFHJJLIPN CNCGLFBHFNK, LLKLGIOAOCK HLIKBEKBJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x82B6600", Offset = "0x82B5A00", VA = "0x1882B6600", Slot = "5")]
	[AsyncStateMachine(typeof(HLDBBBAAIAE))]
	public Task<BDNEJDNNBKC.BBBIEKEBHME> AOFMOKGODHB(HashSet<DPHHHFAFOFC.Reason> KGICNGCIHMB, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class GGLFDONPKII : PCPDAGOPDNE, BDNEJDNNBKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct JMNFILEKOGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<BDNEJDNNBKC.BBBIEKEBHME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public GGLFDONPKII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public HashSet<DPHHHFAFOFC.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private ECGOJJLBFIL <localRoomInstance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private long <preFallbackInstance>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private bool <currentIsOffline>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter<BDNEJDNNBKC.BBBIEKEBHME> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x82C6720", Offset = "0x82C5B20", VA = "0x1882C6720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x82C7080", Offset = "0x82C6480", VA = "0x1882C7080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string DPAPPBHANIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x82B9C60", Offset = "0x82B9060", VA = "0x1882B9C60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x9CD730", Offset = "0x9CCB30", VA = "0x1809CD730")]
	public GGLFDONPKII(LHLFHJJLIPN CNCGLFBHFNK, LLKLGIOAOCK HLIKBEKBJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x82B9B10", Offset = "0x82B8F10", VA = "0x1882B9B10", Slot = "5")]
	[AsyncStateMachine(typeof(JMNFILEKOGB))]
	public Task<BDNEJDNNBKC.BBBIEKEBHME> AOFMOKGODHB(HashSet<DPHHHFAFOFC.Reason> KGICNGCIHMB, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class EOPHAJJGPFL : PCPDAGOPDNE, BDNEJDNNBKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct KCBNDIOMNKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public AsyncTaskMethodBuilder<BDNEJDNNBKC.BBBIEKEBHME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public EOPHAJJGPFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public HashSet<DPHHHFAFOFC.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter<CPPOLMCEHHG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter<BDNEJDNNBKC.BBBIEKEBHME> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x82C85A0", Offset = "0x82C79A0", VA = "0x1882C85A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x82C8F90", Offset = "0x82C8390", VA = "0x1882C8F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string DPAPPBHANIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x82B8580", Offset = "0x82B7980", VA = "0x1882B8580", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x9CD730", Offset = "0x9CCB30", VA = "0x1809CD730")]
	public EOPHAJJGPFL(LHLFHJJLIPN CNCGLFBHFNK, LLKLGIOAOCK HLIKBEKBJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x82B8430", Offset = "0x82B7830", VA = "0x1882B8430", Slot = "5")]
	[AsyncStateMachine(typeof(KCBNDIOMNKP))]
	public Task<BDNEJDNNBKC.BBBIEKEBHME> AOFMOKGODHB(HashSet<DPHHHFAFOFC.Reason> KGICNGCIHMB, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class PNKFADMPKDP : PCPDAGOPDNE, BDNEJDNNBKC
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class CFDKOOFIMFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CPPOLMCEHHG matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public ECGOJJLBFIL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public CFDKOOFIMFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x82B5300", Offset = "0x82B4700", VA = "0x1882B5300")]
		internal object IDLLNAFFLDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x82B5380", Offset = "0x82B4780", VA = "0x1882B5380")]
		internal object MNHGKMPPMPC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct DECKLBNMBHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public AsyncTaskMethodBuilder<BDNEJDNNBKC.BBBIEKEBHME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public PNKFADMPKDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public HashSet<DPHHHFAFOFC.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private CFDKOOFIMFL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<CPPOLMCEHHG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter<BDNEJDNNBKC.BBBIEKEBHME> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x82B57B0", Offset = "0x82B4BB0", VA = "0x1882B57B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x82B63F0", Offset = "0x82B57F0", VA = "0x1882B63F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string DPAPPBHANIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x82D2F40", Offset = "0x82D2340", VA = "0x1882D2F40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x9CD730", Offset = "0x9CCB30", VA = "0x1809CD730")]
	public PNKFADMPKDP(LHLFHJJLIPN CNCGLFBHFNK, LLKLGIOAOCK HLIKBEKBJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x82D2DF0", Offset = "0x82D21F0", VA = "0x1882D2DF0", Slot = "5")]
	[AsyncStateMachine(typeof(DECKLBNMBHP))]
	public Task<BDNEJDNNBKC.BBBIEKEBHME> AOFMOKGODHB(HashSet<DPHHHFAFOFC.Reason> KGICNGCIHMB, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class PCPDAGOPDNE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct MFGAMGLFHOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public LMKAPNBAFDO log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public HashSet<DPHHHFAFOFC.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public PCPDAGOPDNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<DPHHHFAFOFC.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x82CBAF0", Offset = "0x82CAEF0", VA = "0x1882CBAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x82CC010", Offset = "0x82CB410", VA = "0x1882CC010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	protected readonly LHLFHJJLIPN CNCGLFBHFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	protected readonly LLKLGIOAOCK HLIKBEKBJPB;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected EOFPDHAABFM OHFFLHAGGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x82D2620", Offset = "0x82D1A20", VA = "0x1882D2620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x9CD730", Offset = "0x9CCB30", VA = "0x1809CD730")]
	public PCPDAGOPDNE(LHLFHJJLIPN CNCGLFBHFNK, LLKLGIOAOCK HLIKBEKBJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x82D24F0", Offset = "0x82D18F0", VA = "0x1882D24F0")]
	[AsyncStateMachine(typeof(MFGAMGLFHOI))]
	protected Task ELCGEAHOEDH(LMKAPNBAFDO KIBGFJNEFGA, HashSet<DPHHHFAFOFC.Reason> KGICNGCIHMB, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class KMDNJHBMJCK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct EFJBMEHOIKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder<BDNEJDNNBKC.BBBIEKEBHME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public LLKLGIOAOCK callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x82B7560", Offset = "0x82B6960", VA = "0x1882B7560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x82B78E0", Offset = "0x82B6CE0", VA = "0x1882B78E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class BDPDECCMFBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public LHLFHJJLIPN roomManager;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BDPDECCMFBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x82B5050", Offset = "0x82B4450", VA = "0x1882B5050")]
		internal object BBLGKOFMCIP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly float BICECNMBCDL;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	internal static readonly HashSet<DPHHHFAFOFC.Reason> EBMABBIEEGM;

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x82C9780", Offset = "0x82C8B80", VA = "0x1882C9780")]
	[AsyncStateMachine(typeof(EFJBMEHOIKA))]
	internal static Task<BDNEJDNNBKC.BBBIEKEBHME> PEAMCMLHALP(LLKLGIOAOCK HLIKBEKBJPB, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x82C9600", Offset = "0x82C8A00", VA = "0x1882C9600")]
	internal static void MIPAKJCKFNC(LHLFHJJLIPN CNCGLFBHFNK, LMKAPNBAFDO KIBGFJNEFGA, string OGLLNGIKJKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface BDNEJDNNBKC
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct BBBIEKEBHME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public bool LCNFJJJGFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public DPHHHFAFOFC.Reason HJCCPGPOLBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Enum? BIGDFONAIBK;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x82B4B90", Offset = "0x82B3F90", VA = "0x1882B4B90")]
		public static BBBIEKEBHME OACLJGMAPCF()
		{
			return default(BBBIEKEBHME);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x82B4B60", Offset = "0x82B3F60", VA = "0x1882B4B60")]
		public static BBBIEKEBHME DDJMFPPAFOP(DPHHHFAFOFC.Reason HJCCPGPOLBJ, [Optional] Enum? BIGDFONAIBK)
		{
			return default(BBBIEKEBHME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string LJCJHIGEHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<BBBIEKEBHME> AOFMOKGODHB(HashSet<DPHHHFAFOFC.Reason> KGICNGCIHMB, CancellationToken JDDHIJBJNHP);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct GGIGHNKGCOJ
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class BFALAFCFGPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public LHLFHJJLIPN manager;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BFALAFCFGPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x82B5150", Offset = "0x82B4550", VA = "0x1882B5150")]
		internal Task EMANKDENMJJ(CancellationToken cancellationToken, int roomTotalVersion, JMJBOEJBCPI localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct JCNMFBCJDIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public GGIGHNKGCOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private OKAHFFFFHHK <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter<AHKNMGFDAAG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter<AEALKLKILHL> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x82C3A30", Offset = "0x82C2E30", VA = "0x1882C3A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x82C3FC0", Offset = "0x82C33C0", VA = "0x1882C3FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct NGPMAPJOKFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public GGIGHNKGCOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x82CC900", Offset = "0x82CBD00", VA = "0x1882CC900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x82CCC20", Offset = "0x82CC020", VA = "0x1882CCC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly CancellationToken JDDHIJBJNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly LHLFHJJLIPN BIGODBDFGBM;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private LPHAKFKHFIH KGPHOKLMHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x82B93D0", Offset = "0x82B87D0", VA = "0x1882B93D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private LLKLGIOAOCK GHCAPJHEIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x82B9540", Offset = "0x82B8940", VA = "0x1882B9540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private EOFPDHAABFM OHFFLHAGGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x82B96A0", Offset = "0x82B8AA0", VA = "0x1882B96A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private DNIHMPAIOAJ AFBEOGPMOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x82B9420", Offset = "0x82B8820", VA = "0x1882B9420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x27015E0", Offset = "0x27009E0", VA = "0x1827015E0")]
	public GGIGHNKGCOJ(CancellationToken JDDHIJBJNHP, LHLFHJJLIPN BIGODBDFGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x82B9A60", Offset = "0x82B8E60", VA = "0x1882B9A60")]
	public static NEBPKINFJKK MDIELKAOLHD(LHLFHJJLIPN BIGODBDFGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x82B9590", Offset = "0x82B8990", VA = "0x1882B9590")]
	[AsyncStateMachine(typeof(JCNMFBCJDIK))]
	public Task<bool> ILOIMMFJAMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x82B9850", Offset = "0x82B8C50", VA = "0x1882B9850")]
	private bool JIEIHMHIKFH([Out] OKAHFFFFHHK OLLDGDPALBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x82B9470", Offset = "0x82B8870", VA = "0x1882B9470")]
	[AsyncStateMachine(typeof(NGPMAPJOKFC))]
	private Task EPBMKAIPKIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x82B9720", Offset = "0x82B8B20", VA = "0x1882B9720")]
	private Task<AHKNMGFDAAG> JECNCFHGFOC(OKAHFFFFHHK LNIJAEIMPKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct JMDIMJDCLIF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly KOAMAHKJIOG CAMCBGNDNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Guid IAFOFMFFKIO;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(AEALKLKILHL, Task)> BCDCDCPAHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x82C6590", Offset = "0x82C5990", VA = "0x1882C6590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4E850C0", Offset = "0x4E844C0", VA = "0x184E850C0")]
	public JMDIMJDCLIF(KOAMAHKJIOG CAMCBGNDNHF, Guid IAFOFMFFKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x82C6660", Offset = "0x82C5A60", VA = "0x1882C6660")]
	public TaskAwaiter<(AEALKLKILHL, Task)> OIMEOLNNAHI()
	{
		return default(TaskAwaiter<(AEALKLKILHL, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x82C64C0", Offset = "0x82C58C0", VA = "0x1882C64C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct IGKMMOJCCOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly TaskCompletionSource<(AEALKLKILHL, Task)> AONHJDKFGOP;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(AEALKLKILHL, Task)> BCDCDCPAHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x82C2510", Offset = "0x82C1910", VA = "0x1882C2510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x82C2550", Offset = "0x82C1950", VA = "0x1882C2550")]
	public IGKMMOJCCOM(TimeSpan MDBJPKFAGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x82C2470", Offset = "0x82C1870", VA = "0x1882C2470")]
	public void NGMOFJKKMFM(Task DMAKFDFMNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x82C23E0", Offset = "0x82C17E0", VA = "0x1882C23E0")]
	public void IANOJKLDIBO(AEALKLKILHL KJGABACDPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x82C2390", Offset = "0x82C1790", VA = "0x1882C2390")]
	public void HOBHBKFMJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x82C2300", Offset = "0x82C1700", VA = "0x1882C2300")]
	internal void EAJPMLMOLHG(string FGEBHLNNMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class KCBBDFDKKBM
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x82C8270", Offset = "0x82C7670", VA = "0x1882C8270")]
	public static JKNOMNBJNEB KEGLDBBMFDB(this JKNOMNBJNEB CFFKMBGFAOG, HNAJHGJKLNP PGIIADIIDPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x82C8410", Offset = "0x82C7810", VA = "0x1882C8410")]
	public static JKNOMNBJNEB NFBLHLMNBDL(this JKNOMNBJNEB CFFKMBGFAOG, IFADHLGHNJJ OBAHINDMMMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class PKPFMAHJFGD : PJDACJNGEOD
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class JHBAJCBDMPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public IFADHLGHNJJ subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public JHBAJCBDMPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x82C4030", Offset = "0x82C3430", VA = "0x1882C4030")]
		internal bool IMKJOEHGOGC(HABMELLNJLH s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly AILCPENEKDG MMLGAJNCLBF;

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	public PKPFMAHJFGD(AILCPENEKDG ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x82D27D0", Offset = "0x82D1BD0", VA = "0x1882D27D0", Slot = "4")]
	public JKNOMNBJNEB BPKMLDCMEGB(long HIGHEGOCLFP, long PIEICLNIOGJ, string LOLPCFDIILM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x82D2670", Offset = "0x82D1A70", VA = "0x1882D2670", Slot = "5")]
	public JKNOMNBJNEB BPKMLDCMEGB(long HIGHEGOCLFP, long PIEICLNIOGJ, GPEOIJBIPCA PBNEIBAJIIG, Guid? OGDLKIJEAFA, long KDAFCLHLBDB, bool NGJGPIHJCIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x82D2B40", Offset = "0x82D1F40", VA = "0x1882D2B40", Slot = "6")]
	public JKNOMNBJNEB BPKMLDCMEGB(EAOAOGAEAGM IBFJPIPBFOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x82D2860", Offset = "0x82D1C60", VA = "0x1882D2860", Slot = "7")]
	public JKNOMNBJNEB BPKMLDCMEGB(HNAJHGJKLNP CNMCCLMMOAL, IFADHLGHNJJ DJHDCDENBCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x82D2D40", Offset = "0x82D2140", VA = "0x1882D2D40")]
	private Guid? OOLPLDNADIL(HNAJHGJKLNP OCFPPFFMCMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class OBGINKBDIGI : IIEIJMHMIDP, GIBBKBNAGGA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct IOPMGOMMACO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public OBGINKBDIGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x82C2910", Offset = "0x82C1D10", VA = "0x1882C2910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x82C2FB0", Offset = "0x82C23B0", VA = "0x1882C2FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly LIHEKALDDOB LMGDGADCMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private string JNJHLMOALMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Task IAMCPDFJHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private LHLFHJJLIPN CNCGLFBHFNK;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool GLMEEDOPBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x82CDB40", Offset = "0x82CCF40", VA = "0x1882CDB40", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task JFNCJNMHMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x82CDAB0", Offset = "0x82CCEB0", VA = "0x1882CDAB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x9D24A0", Offset = "0x9D18A0", VA = "0x1809D24A0", Slot = "7")]
	public void ENMMELFAOHH(LHLFHJJLIPN CNCGLFBHFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x82CDB70", Offset = "0x82CCF70", VA = "0x1882CDB70", Slot = "6")]
	public void MGFPFJBJIKM(Task OOCBIOLELBN, string CMKCIMANDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x82CDCD0", Offset = "0x82CD0D0", VA = "0x1882CDCD0")]
	[AsyncStateMachine(typeof(IOPMGOMMACO))]
	private Task OJJKIIHBAJH(Task JELKEOBCBOD, string CMKCIMANDJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x82CDDF0", Offset = "0x82CD1F0", VA = "0x1882CDDF0")]
	public OBGINKBDIGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class HOOHFFDPGPK : NGJOOKOOPFO, GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private bool FKGNAOEHNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private AMEIOOCAHKO IAINMFDPLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private LPHAKFKHFIH MFHPJCBDCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private AILCPENEKDG ICLMPPLIKCJ;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public AMEIOOCAHKO HBFAKPBIGNB
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x82BB9D0", Offset = "0x82BADD0", VA = "0x1882BB9D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x82BBB40", Offset = "0x82BAF40", VA = "0x1882BBB40", Slot = "7")]
	public void ENMMELFAOHH(LHLFHJJLIPN CNCGLFBHFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x82BBCC0", Offset = "0x82BB0C0", VA = "0x1882BBCC0", Slot = "5")]
	public void GAAGCFKNBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x82BBB00", Offset = "0x82BAF00", VA = "0x1882BBB00", Slot = "6")]
	public void PIIKKOKPHEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x82BBA40", Offset = "0x82BAE40", VA = "0x1882BBA40")]
	private Task DJBMEFLOPAE(BGKOCAICLAE PLCJAHDMBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x82BBB00", Offset = "0x82BAF00", VA = "0x1882BBB00", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public HOOHFFDPGPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class EFGJGAMLJLB : AILCPENEKDG
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class KHDKHGENIJE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly PCFGMNCOCPN MIBMBMCHHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly string IICGAABOENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly T JMBBJHIBCGJ;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T APFNDOMNAPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0xC461D0", Offset = "0xC455D0", VA = "0x180C461D0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xC461E0", Offset = "0xC455E0", VA = "0x180C461E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x4DF3B20", Offset = "0x4DF2F20", VA = "0x184DF3B20")]
		public KHDKHGENIJE(PCFGMNCOCPN MIBMBMCHHLM, string IICGAABOENK, T JMBBJHIBCGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x4DF35E0", Offset = "0x4DF29E0", VA = "0x184DF35E0")]
		private void BBJMEKAACOK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly PCFGMNCOCPN MIBMBMCHHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly KHDKHGENIJE<TimeSpan> ADFKKOAKJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly KHDKHGENIJE<TimeSpan> AHBEAFOAECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly KHDKHGENIJE<TimeSpan> IDOPHMFKGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly KHDKHGENIJE<TimeSpan> EELPHJNJOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly KHDKHGENIJE<bool> ICDLEBICHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly KHDKHGENIJE<bool> EEDBKCGGMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly KHDKHGENIJE<bool> EAKNOPDJPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly KHDKHGENIJE<int> FOKHNDBPEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly KHDKHGENIJE<bool> OIMAFFPFBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly KHDKHGENIJE<bool> MMDKLCGFBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly KHDKHGENIJE<NHEHHACAMCL> DBFIHCAMEEJ;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan EFKFEJEBDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x82B6F90", Offset = "0x82B6390", VA = "0x1882B6F90", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan BJDDOJMEDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x82B6E50", Offset = "0x82B6250", VA = "0x1882B6E50", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan GGGONIJMOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x82B6F10", Offset = "0x82B6310", VA = "0x1882B6F10", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan OAIGMCNHHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x82B6FD0", Offset = "0x82B63D0", VA = "0x1882B6FD0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool GBMEJBCAIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x82B6E90", Offset = "0x82B6290", VA = "0x1882B6E90", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool BBDNHMPPCKI
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x82B6F50", Offset = "0x82B6350", VA = "0x1882B6F50", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool LDKEAIIDOLO
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x82B6ED0", Offset = "0x82B62D0", VA = "0x1882B6ED0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int LCDHNIKDCNG
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x82B7050", Offset = "0x82B6450", VA = "0x1882B7050", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool MOJIFCKKFHG
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x82B6DC0", Offset = "0x82B61C0", VA = "0x1882B6DC0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool JLJEOHONAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x82B7010", Offset = "0x82B6410", VA = "0x1882B7010", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool GBLIIBFAJAD
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x82B6E00", Offset = "0x82B6200", VA = "0x1882B6E00", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x82B7090", Offset = "0x82B6490", VA = "0x1882B7090")]
	[UnityEngine.Scripting.Preserve]
	public EFGJGAMLJLB([MGCCDFKFGBG(null)] PCFGMNCOCPN MIBMBMCHHLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class GDOJFLMHAMG : JDFLHGHEICC, GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class LLLLPANLPBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public AFEHEDCGLIC roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public LLLLPANLPBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x82C9A30", Offset = "0x82C8E30", VA = "0x1882C9A30")]
		internal object JNMKBHLLLCG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action HPILDCGMEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x82B8960", Offset = "0x82B7D60", VA = "0x1882B8960", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x82B88C0", Offset = "0x82B7CC0", VA = "0x1882B88C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event FMIINANPHEH AFDMLPANCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x82B90F0", Offset = "0x82B84F0", VA = "0x1882B90F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x82B8A00", Offset = "0x82B7E00", VA = "0x1882B8A00", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event FMIINANPHEH IEEENNDGGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x82B8AD0", Offset = "0x82B7ED0", VA = "0x1882B8AD0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x82B9290", Offset = "0x82B8690", VA = "0x1882B9290", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event FMIINANPHEH OMNFOOFJJGD
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x82B8DA0", Offset = "0x82B81A0", VA = "0x1882B8DA0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x82B9330", Offset = "0x82B8730", VA = "0x1882B9330", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<BJGBMLOIFEK, bool> IGAJHHMLJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x82B9010", Offset = "0x82B8410", VA = "0x1882B9010", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x82B91E0", Offset = "0x82B85E0", VA = "0x1882B91E0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "19")]
	public void ENMMELFAOHH(LHLFHJJLIPN CNCGLFBHFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x82B8B70", Offset = "0x82B7F70", VA = "0x1882B8B70", Slot = "14")]
	public void FJDLNAJAFNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x82B8AA0", Offset = "0x82B7EA0", VA = "0x1882B8AA0", Slot = "15")]
	public void EIGLHJKBHKN(AFEHEDCGLIC NOKOGAFLODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x82B8D70", Offset = "0x82B8170", VA = "0x1882B8D70", Slot = "16")]
	public void GGDDCPBAPFG(AFEHEDCGLIC NOKOGAFLODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x82B90C0", Offset = "0x82B84C0", VA = "0x1882B90C0", Slot = "17")]
	public void HPFMMMPHFLD(AFEHEDCGLIC NOKOGAFLODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x82B9190", Offset = "0x82B8590", VA = "0x1882B9190", Slot = "18")]
	public void IKLNFOGEFKJ(BJGBMLOIFEK LODIOJIJDAO, bool LCNFJJJGFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x82B8E40", Offset = "0x82B8240", VA = "0x1882B8E40")]
	private void HFGDGIKOIHK(FMIINANPHEH CBFIOILKHPI, AFEHEDCGLIC NOKOGAFLODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public GDOJFLMHAMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[UnityEngine.Scripting.Preserve]
internal class GNOOBEPCFLK : DPHHHFAFOFC, GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class MBOLMMMKBEG : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct IPLMIFMLKGM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public MBOLMMMKBEG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public DPHHHFAFOFC.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private FNIAOHCFFHK <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private BDNEJDNNBKC[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private TaskAwaiter<BDNEJDNNBKC.BBBIEKEBHME> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x82C3010", Offset = "0x82C2410", VA = "0x1882C3010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x82C3750", Offset = "0x82C2B50", VA = "0x1882C3750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private struct JJODPGNDNOK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public AsyncTaskMethodBuilder<BDNEJDNNBKC.BBBIEKEBHME> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public BDNEJDNNBKC fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public MBOLMMMKBEG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public DPHHHFAFOFC.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private FNIAOHCFFHK <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private HHFOKOAJHLL <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private TaskAwaiter<BDNEJDNNBKC.BBBIEKEBHME> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x82C4350", Offset = "0x82C3750", VA = "0x1882C4350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x82C5000", Offset = "0x82C4400", VA = "0x1882C5000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class LDFGAMLMGDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public BDNEJDNNBKC fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public LDFGAMLMGDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x82C99B0", Offset = "0x82C8DB0", VA = "0x1882C99B0")]
			internal object ABMDHKMFEDL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Task OOCBIOLELBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationTokenSource FGGJCHOJHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public HHFOKOAJHLL EEJLKBIMGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public LLKLGIOAOCK HLIKBEKBJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public CNCGCLBFAKP AOLFIBBKOEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public ECGOJJLBFIL OINOCKJMHLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public BDNEJDNNBKC[] LFBCPEDKMOA;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool LMGILDLJIEG
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x82BB230", Offset = "0x82BA630", VA = "0x1882BB230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool ONKDJKIELGD
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x82BB080", Offset = "0x82BA480", VA = "0x1882BB080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x82CB9D0", Offset = "0x82CADD0", VA = "0x1882CB9D0")]
		public MBOLMMMKBEG(LLKLGIOAOCK HLIKBEKBJPB, CNCGCLBFAKP AOLFIBBKOEG, ECGOJJLBFIL OINOCKJMHLO, BDNEJDNNBKC[] LFBCPEDKMOA, CancellationToken JDDHIJBJNHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x82CA560", Offset = "0x82C9960", VA = "0x1882CA560", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x82CB5D0", Offset = "0x82CA9D0", VA = "0x1882CB5D0")]
		public void PPPDFJGCNOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x82CA700", Offset = "0x82C9B00", VA = "0x1882CA700")]
		public void GBIMFKKNPIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x82CAB30", Offset = "0x82C9F30", VA = "0x1882CAB30")]
		public void HLDFDDCKMAO(DPHHHFAFOFC.Reason CGHAONGLKPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x82CB100", Offset = "0x82CA500", VA = "0x1882CB100")]
		[AsyncStateMachine(typeof(IPLMIFMLKGM))]
		public Task OMKKHFDNFLH(DPHHHFAFOFC.Reason HJCCPGPOLBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x82CAFC0", Offset = "0x82CA3C0", VA = "0x1882CAFC0")]
		[AsyncStateMachine(typeof(JJODPGNDNOK))]
		private Task<BDNEJDNNBKC.BBBIEKEBHME> OFNJCEHMJCD(DPHHHFAFOFC.Reason HJCCPGPOLBJ, BDNEJDNNBKC FIPJAIFOCOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x82C9E40", Offset = "0x82C9240", VA = "0x1882C9E40")]
		private void BCPNILGHJIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x82CAE00", Offset = "0x82CA200", VA = "0x1882CAE00")]
		public bool NMGGEFBKLEM(DPHHHFAFOFC.Reason BBCHKHICKLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x82CA0D0", Offset = "0x82C94D0", VA = "0x1882CA0D0")]
		private void CMEIONMNBEO(HHFOKOAJHLL FGCBFMGNEPC, DPHHHFAFOFC.Reason HJCCPGPOLBJ = DPHHHFAFOFC.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x82CA390", Offset = "0x82C9790", VA = "0x1882CA390")]
		private void DLAFCKGOGCM(HHFOKOAJHLL FGCBFMGNEPC, BDNEJDNNBKC.BBBIEKEBHME APLCGCDLEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x82CA870", Offset = "0x82C9C70", VA = "0x1882CA870")]
		private void HALPEKBHOCP(HHFOKOAJHLL FGCBFMGNEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x82CB200", Offset = "0x82CA600", VA = "0x1882CB200")]
		private void PNNBEOKPDKL(HHFOKOAJHLL FGCBFMGNEPC, BDNEJDNNBKC.BBBIEKEBHME APLCGCDLEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x82C9F60", Offset = "0x82C9360", VA = "0x1882C9F60")]
		private void CAAGACAJPAB(HHFOKOAJHLL FGCBFMGNEPC, Exception CCEMNOMFFKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x82CAEB0", Offset = "0x82CA2B0", VA = "0x1882CAEB0")]
		private void NMMFAKHCEAL(BDNEJDNNBKC FIPJAIFOCOM, DPHHHFAFOFC.Reason HJCCPGPOLBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x82CAA20", Offset = "0x82C9E20", VA = "0x1882CAA20")]
		private void HJJCLLHFLEP(BDNEJDNNBKC FIPJAIFOCOM, DPHHHFAFOFC.Reason HJCCPGPOLBJ, string BIGDFONAIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x82CB640", Offset = "0x82CAA40", VA = "0x1882CB640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class HHFOKOAJHLL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Task<BDNEJDNNBKC.BBBIEKEBHME> OOCBIOLELBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public CancellationTokenSource FGGJCHOJHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public BDNEJDNNBKC FIPJAIFOCOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public DPHHHFAFOFC.Reason CGHAONGLKPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public HashSet<DPHHHFAFOFC.Reason> KGICNGCIHMB;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool LMGILDLJIEG
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x82BB230", Offset = "0x82BA630", VA = "0x1882BB230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool ONKDJKIELGD
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x82BB080", Offset = "0x82BA480", VA = "0x1882BB080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x82BB0C0", Offset = "0x82BA4C0", VA = "0x1882BB0C0")]
		public void KOCPBONGJHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x82BB0A0", Offset = "0x82BA4A0", VA = "0x1882BB0A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x82BB250", Offset = "0x82BA650", VA = "0x1882BB250", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x82BB5C0", Offset = "0x82BA9C0", VA = "0x1882BB5C0")]
		public HHFOKOAJHLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class DLAMBEHGOPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public DPHHHFAFOFC.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public DLAMBEHGOPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x82B6590", Offset = "0x82B5990", VA = "0x1882B6590")]
		internal object PINHPLAMAOL(HHFOKOAJHLL x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x82B64B0", Offset = "0x82B58B0", VA = "0x1882B64B0")]
		internal object AHGCEHDANCP(MBOLMMMKBEG x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x82B6520", Offset = "0x82B5920", VA = "0x1882B6520")]
		internal object NDDIKEDEDDH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct EIBPMHMKFKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public DPHHHFAFOFC.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public GNOOBEPCFLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private DLAMBEHGOPH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x82B7950", Offset = "0x82B6D50", VA = "0x1882B7950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x82B83D0", Offset = "0x82B77D0", VA = "0x1882B83D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct OFNOCCMEDDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public GNOOBEPCFLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public DPHHHFAFOFC.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private MBOLMMMKBEG <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x82CDE80", Offset = "0x82CD280", VA = "0x1882CDE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x82CEB10", Offset = "0x82CDF10", VA = "0x1882CEB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct KFHPAOPDNGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public GNOOBEPCFLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x82C9000", Offset = "0x82C8400", VA = "0x1882C9000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x82C95A0", Offset = "0x82C89A0", VA = "0x1882C95A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	internal static readonly LMKAPNBAFDO DOOGPLHFHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private LHLFHJJLIPN CNCGLFBHFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private LLKLGIOAOCK HLIKBEKBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private MBOLMMMKBEG MJHGJPGBJGB;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private EOFPDHAABFM OHFFLHAGGEM
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x82BA820", Offset = "0x82B9C20", VA = "0x1882BA820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool LGGFFEKEKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x22DD620", Offset = "0x22DCA20", VA = "0x1822DD620", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool GEOEMCAHOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x82BA7B0", Offset = "0x82B9BB0", VA = "0x1882BA7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x82BA730", Offset = "0x82B9B30", VA = "0x1882BA730", Slot = "7")]
	public void ENMMELFAOHH(LHLFHJJLIPN CNCGLFBHFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x82BA720", Offset = "0x82B9B20", VA = "0x1882BA720", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x82BA960", Offset = "0x82B9D60", VA = "0x1882BA960", Slot = "9")]
	public void KOCPBONGJHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x82BAC00", Offset = "0x82BA000", VA = "0x1882BAC00")]
	private bool OPELAINAPBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x82BA280", Offset = "0x82B9680", VA = "0x1882BA280", Slot = "6")]
	private void CPNHGEDGLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x82BA870", Offset = "0x82B9C70", VA = "0x1882BA870", Slot = "5")]
	[AsyncStateMachine(typeof(EIBPMHMKFKI))]
	private Task JFFEODHGBNA(DPHHHFAFOFC.Reason HJCCPGPOLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x82BACE0", Offset = "0x82BA0E0", VA = "0x1882BACE0")]
	private bool PCEHIINKNKO(DPHHHFAFOFC.Reason HJCCPGPOLBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x82BA350", Offset = "0x82B9750", VA = "0x1882BA350")]
	private BDNEJDNNBKC[] DLEOIKKEHPO(ECGOJJLBFIL BIHFFDOJECG, CNCGCLBFAKP JGMCEPAAGMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x82BAAF0", Offset = "0x82B9EF0", VA = "0x1882BAAF0")]
	[AsyncStateMachine(typeof(OFNOCCMEDDC))]
	private Task LJAPHHECCFA(DPHHHFAFOFC.Reason HJCCPGPOLBJ, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x82BA1B0", Offset = "0x82B95B0", VA = "0x1882BA1B0")]
	[AsyncStateMachine(typeof(KFHPAOPDNGJ))]
	private Task BMAMCMBKJLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public GNOOBEPCFLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class OMIIGMEJIMD : OJOCFDFOCPF, GIBBKBNAGGA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct IDCEOKDBCHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public ECGOJJLBFIL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public OMIIGMEJIMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public PJKLHEMEKPG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x82BBE70", Offset = "0x82BB270", VA = "0x1882BBE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x82BC7E0", Offset = "0x82BBBE0", VA = "0x1882BC7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct NLENNMMMAFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public OMIIGMEJIMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public ECGOJJLBFIL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public PJKLHEMEKPG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private BNJJFADPKOK<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private FNIAOHCFFHK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private LJOHHGILGBC <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private BGHJMLKLCPN <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x82CCC80", Offset = "0x82CC080", VA = "0x1882CCC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x82CD9D0", Offset = "0x82CCDD0", VA = "0x1882CD9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class GMACNDBEFCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public Matchmaking.NMCIDFEHOOJ result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public MODLJLMFBEE errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public GMACNDBEFCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x82BA100", Offset = "0x82B9500", VA = "0x1882BA100")]
		internal object KKGOIPFIIHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class NOIDJAEHCEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Task<JKNOMNBJNEB> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public NOIDJAEHCEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		internal Task<JKNOMNBJNEB> JFBLHGINMLM(BNJJFADPKOK<string>.EFJIBBJEOLP _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct IECGNMKEOHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public OMIIGMEJIMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public ECGOJJLBFIL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public PJKLHEMEKPG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public LJOHHGILGBC joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private NOIDJAEHCEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private DMFFGJNNEKN <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private FNIAOHCFFHK <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private DHAJBAACLNK <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private Task<Matchmaking.ACOMAKFMCHD> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private JJCKMGAKPIK <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private TaskAwaiter<Matchmaking.ACOMAKFMCHD> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter<JKNOMNBJNEB> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x82BC840", Offset = "0x82BBC40", VA = "0x1882BC840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x82C22A0", Offset = "0x82C16A0", VA = "0x1882C22A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct MBIGPKNJAPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public OMIIGMEJIMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x82ED220", Offset = "0x82EC620", VA = "0x1882ED220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x82EDC90", Offset = "0x82ED090", VA = "0x1882EDC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct HPJILIABAFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public OMIIGMEJIMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private NPCGGDCACLM <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x82E6930", Offset = "0x82E5D30", VA = "0x1882E6930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x82E6DC0", Offset = "0x82E61C0", VA = "0x1882E6DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct MHGDBHPDPCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public AsyncTaskMethodBuilder<Matchmaking.ACOMAKFMCHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public ECGOJJLBFIL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public OMIIGMEJIMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TaskAwaiter<Matchmaking.ACOMAKFMCHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x82EDCF0", Offset = "0x82ED0F0", VA = "0x1882EDCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x82EE1D0", Offset = "0x82ED5D0", VA = "0x1882EE1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct ADBDLEPDIMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public Matchmaking.ACOMAKFMCHD serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public OMIIGMEJIMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public LJOHHGILGBC joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private TaskAwaiter<CDLFCEEGFMO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x82D58C0", Offset = "0x82D4CC0", VA = "0x1882D58C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x82D5F10", Offset = "0x82D5310", VA = "0x1882D5F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class KDMJGCOLFEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public ECGOJJLBFIL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public KDMJGCOLFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x82EB6E0", Offset = "0x82EAAE0", VA = "0x1882EB6E0")]
		internal object KOKDFMGBDFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x82EB5E0", Offset = "0x82EA9E0", VA = "0x1882EB5E0")]
		internal string GENHOCLAPJH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct GCOPNGBDINK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public ECGOJJLBFIL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public OMIIGMEJIMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private KDMJGCOLFEC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x82E1AA0", Offset = "0x82E0EA0", VA = "0x1882E1AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x82E2640", Offset = "0x82E1A40", VA = "0x1882E2640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct BKEBMGPFPLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public OMIIGMEJIMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public LJOHHGILGBC joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public JKNOMNBJNEB initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public ECGOJJLBFIL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public DMFFGJNNEKN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x82D7C20", Offset = "0x82D7020", VA = "0x1882D7C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x82D8410", Offset = "0x82D7810", VA = "0x1882D8410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct EGCLLOJJKMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public OMIIGMEJIMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private FNIAOHCFFHK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private FNIAOHCFFHK <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x82DE830", Offset = "0x82DDC30", VA = "0x1882DE830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x82E0030", Offset = "0x82DF430", VA = "0x1882E0030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct BBGKHFFOPGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public JMJBOEJBCPI localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public OMIIGMEJIMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<AEALKLKILHL> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x82D67E0", Offset = "0x82D5BE0", VA = "0x1882D67E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x82D6FE0", Offset = "0x82D63E0", VA = "0x1882D6FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class ICMKEJMNGLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public ECGOJJLBFIL targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public ICMKEJMNGLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x82E6E20", Offset = "0x82E6220", VA = "0x1882E6E20")]
		internal object IHMAJHIAJNI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class APPLIMCBABM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public APPLIMCBABM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x82D66E0", Offset = "0x82D5AE0", VA = "0x1882D66E0")]
		internal void PPKPNLIFBNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class DALJDIDNJBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public ECGOJJLBFIL targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public DALJDIDNJBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x82DC880", Offset = "0x82DBC80", VA = "0x1882DC880")]
		internal object JFCAGODJCLI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class JNBCLJNPPJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public ECGOJJLBFIL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public JNBCLJNPPJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x82E9760", Offset = "0x82E8B60", VA = "0x1882E9760")]
		internal string FCEGILKFDOO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly LMKAPNBAFDO CBMNGBCNBAH;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly LMKAPNBAFDO KKHIHKBBJGO;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly LMKAPNBAFDO HJCKGEJLMNO;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly string ONHCMBLONME;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static readonly string IJLBBNPFNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static readonly string KIDEGPDEACP;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public static readonly Guid JEPBBOOCIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private EALPINOJEEF IGNJCMAMHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private LNAEMNOKNDE NPNCKHICDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private LPHAKFKHFIH MFHPJCBDCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private LHLFHJJLIPN CNCGLFBHFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private LLKLGIOAOCK HLIKBEKBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private DPHHHFAFOFC IKACDKLNPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private IIEIJMHMIDP MNDMKGFPPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private JDFLHGHEICC MGHLKNNNHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private JCINOMLBHPJ JGBKDONAMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private JCELCBHKANI BOMFFALMBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private IDisposable FIOMAPEOAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private MGPCNPKFNKG AMALOEIAOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly LIHEKALDDOB IKPHBAICIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private JJCKMGAKPIK HLLKCMFHJNK;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus IADCJDCOMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9F1B90", Offset = "0x9F0F90", VA = "0x1809F1B90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x1260700", Offset = "0x125FB00", VA = "0x181260700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private EOFPDHAABFM OHFFLHAGGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x82D0F40", Offset = "0x82D0340", VA = "0x1882D0F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x82CF2F0", Offset = "0x82CE6F0", VA = "0x1882CF2F0", Slot = "6")]
	public void ENMMELFAOHH(LHLFHJJLIPN CNCGLFBHFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x82CEFD0", Offset = "0x82CE3D0", VA = "0x1882CEFD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x82D0A10", Offset = "0x82CFE10", VA = "0x1882D0A10", Slot = "5")]
	[AsyncStateMachine(typeof(IDCEOKDBCHJ))]
	public Task IEAOMFPLDPL(ECGOJJLBFIL EEAMAAFGDPN, PJKLHEMEKPG GJICGBGEIJI, CancellationToken EKBICDMGFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x82D0450", Offset = "0x82CF850", VA = "0x1882D0450")]
	[AsyncStateMachine(typeof(NLENNMMMAFB))]
	private Task HFCBNDCJOMO(ECGOJJLBFIL EEAMAAFGDPN, PJKLHEMEKPG GJICGBGEIJI, CancellationToken EKBICDMGFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x82D05A0", Offset = "0x82CF9A0", VA = "0x1882D05A0")]
	private void HPDLOPBHLJD(JCINOMLBHPJ JGBKDONAMOO, ECGOJJLBFIL EEAMAAFGDPN, Exception CCEMNOMFFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x82CF780", Offset = "0x82CEB80", VA = "0x1882CF780")]
	private static void GCCKLPAKNOO(BGHJMLKLCPN ENFJOAKHFPA, Exception CCEMNOMFFKG, [Optional] List<int> NMEDGILFFDI, int OCDCMELLDGM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x82CF620", Offset = "0x82CEA20", VA = "0x1882CF620")]
	[AsyncStateMachine(typeof(IECGNMKEOHB))]
	private Task FHPLKKNLAOP(BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, ECGOJJLBFIL EEAMAAFGDPN, PJKLHEMEKPG GJICGBGEIJI, LJOHHGILGBC ADDJAPACBOL, CancellationToken EKBICDMGFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x82D0DC0", Offset = "0x82D01C0", VA = "0x1882D0DC0")]
	private void INJNMCCAMMF([CallerMemberName] string LLLLBFFGALH = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x82D0C90", Offset = "0x82D0090", VA = "0x1882D0C90")]
	[AsyncStateMachine(typeof(MBIGPKNJAPK))]
	private Task IKCIAIMDIDL(BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x82D0120", Offset = "0x82CF520", VA = "0x1882D0120")]
	private void HEOCDIPMHKC(ECGOJJLBFIL EEAMAAFGDPN, CancellationToken EKBICDMGFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x82CEB70", Offset = "0x82CDF70", VA = "0x1882CEB70")]
	private void AIPLLFFCMCO(ECGOJJLBFIL EEAMAAFGDPN, TaskStatus AIJFIKCPODO, string FGEBHLNNMNH, LJOHHGILGBC ADDJAPACBOL, Exception COANEMFJDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x82D0F90", Offset = "0x82D0390", VA = "0x1882D0F90")]
	private void JDHDCONFMBI(ECGOJJLBFIL EEAMAAFGDPN, LJOHHGILGBC ADDJAPACBOL, OperationCanceledException KNENCCOEONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x82CEDE0", Offset = "0x82CE1E0", VA = "0x1882CEDE0")]
	private void BDBFANDPNCC(ECGOJJLBFIL EEAMAAFGDPN, LJOHHGILGBC ADDJAPACBOL, Exception CCEMNOMFFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x82D1720", Offset = "0x82D0B20", VA = "0x1882D1720")]
	private void MFKNEOKADDL(ECGOJJLBFIL EEAMAAFGDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x82D2150", Offset = "0x82D1550", VA = "0x1882D2150")]
	private static AFEHEDCGLIC PIDOOBKJNBC(ECGOJJLBFIL EEAMAAFGDPN)
	{
		return default(AFEHEDCGLIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x82D1930", Offset = "0x82D0D30", VA = "0x1882D1930")]
	[AsyncStateMachine(typeof(HPJILIABAFH))]
	private Task MIHLEIFFCOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x82CF020", Offset = "0x82CE420", VA = "0x1882CF020")]
	[AsyncStateMachine(typeof(MHGDBHPDPCD))]
	private Task<Matchmaking.ACOMAKFMCHD> EBJAIBILEEO(ECGOJJLBFIL EEAMAAFGDPN, BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x82CF180", Offset = "0x82CE580", VA = "0x1882CF180")]
	private static CDLFCEEGFMO EFNOGLMKJEI(Matchmaking.ACOMAKFMCHD CIEIMAHOFAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x82D1260", Offset = "0x82D0660", VA = "0x1882D1260")]
	[AsyncStateMachine(typeof(ADBDLEPDIMA))]
	private Task KMIBMHDFJKO(Matchmaking.ACOMAKFMCHD CIEIMAHOFAB, LJOHHGILGBC ADDJAPACBOL, BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, CancellationToken CPENNOHENKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x82CFFE0", Offset = "0x82CF3E0", VA = "0x1882CFFE0")]
	[AsyncStateMachine(typeof(GCOPNGBDINK))]
	private Task HBCMAFDHPMN(ECGOJJLBFIL EEAMAAFGDPN, CancellationTokenSource NHFAIIPDGND, Task NKKJMNPOFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x82D1FE0", Offset = "0x82D13E0", VA = "0x1882D1FE0")]
	[AsyncStateMachine(typeof(BKEBMGPFPLN))]
	private Task PGIJDBOGGIE(JKNOMNBJNEB BMNMEDOPAEL, DMFFGJNNEKN FCENDNCDCMD, ECGOJJLBFIL BGKGBKGKOKL, LJOHHGILGBC HEPPHAFEAFD, BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, CancellationToken JLDEKAAPHLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x82D13B0", Offset = "0x82D07B0", VA = "0x1882D13B0")]
	private LJOHHGILGBC LDMINIPNGCB(LJOHHGILGBC HEPPHAFEAFD, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x82D0B50", Offset = "0x82CFF50", VA = "0x1882D0B50")]
	[AsyncStateMachine(typeof(EGCLLOJJKMM))]
	private Task IIMBCAACLOA(BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x82D1130", Offset = "0x82D0530", VA = "0x1882D1130")]
	[AsyncStateMachine(typeof(BBGKHFFOPGP))]
	private Task KJAPEAKJDKK(CancellationToken JDDHIJBJNHP, int MNNHJBJAAJF, JMJBOEJBCPI CLOPLKJEDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x82D15A0", Offset = "0x82D09A0", VA = "0x1882D15A0")]
	private static void LEDLNCPNOFH(ECGOJJLBFIL EEAMAAFGDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x82D1CB0", Offset = "0x82D10B0", VA = "0x1882D1CB0")]
	private void NOMNKPEHIDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x82D21B0", Offset = "0x82D15B0", VA = "0x1882D21B0")]
	private void PNDGHNNCJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x82D1010", Offset = "0x82D0410", VA = "0x1882D1010")]
	private void KGDFEHBLEDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x82D10A0", Offset = "0x82D04A0", VA = "0x1882D10A0")]
	private void KHDNFBFPBII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x82D1EF0", Offset = "0x82D12F0", VA = "0x1882D1EF0")]
	private static void OBIELPKNGOB(ECGOJJLBFIL EEAMAAFGDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x82CEEC0", Offset = "0x82CE2C0", VA = "0x1882CEEC0")]
	private static CancellationTokenRegistration DJBOMPALLLE(ECGOJJLBFIL EEAMAAFGDPN, CancellationToken CPENNOHENKG)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x82D1A00", Offset = "0x82D0E00", VA = "0x1882D1A00")]
	private static void NEPFEAGFCLI(ECGOJJLBFIL EEAMAAFGDPN, Exception CCEMNOMFFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x82D1B00", Offset = "0x82D0F00", VA = "0x1882D1B00")]
	private void NEPGHKHMLNA(ECGOJJLBFIL EEAMAAFGDPN, Task NKKJMNPOFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x82CEE60", Offset = "0x82CE260", VA = "0x1882CEE60")]
	private static void BKFDGJHNENK(Func<string> BNFNFAFOAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x82D2460", Offset = "0x82D1860", VA = "0x1882D2460")]
	public OMIIGMEJIMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x82CF290", Offset = "0x82CE690", VA = "0x1882CF290")]
	[CompilerGenerated]
	internal static (int, int?) EHICJJCFICE(MODLJLMFBEE HJPLLMGICPE)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[RecRoom.NoEngine.Common.Preserve]
internal class JPDAGDICDAP : JJDMBPKALHJ, GIBBKBNAGGA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct FOGMJPOBEMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public JPDAGDICDAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public JMJBOEJBCPI localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x82E1410", Offset = "0x82E0810", VA = "0x1882E1410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x82E18F0", Offset = "0x82E0CF0", VA = "0x1882E18F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class KKGJHICLBAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public JPDAGDICDAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public JMJBOEJBCPI localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public KKGJHICLBAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x82ED1E0", Offset = "0x82EC5E0", VA = "0x1882ED1E0")]
		internal List<Task> EPFNKBAIGMP(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct KAMEBGCJCPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public NEBPKINFJKK taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public JMJBOEJBCPI localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x82EB1E0", Offset = "0x82EA5E0", VA = "0x1882EB1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x82EB580", Offset = "0x82EA980", VA = "0x1882EB580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct ACILCKACPJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public JPDAGDICDAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x82D5580", Offset = "0x82D4980", VA = "0x1882D5580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x82D5860", Offset = "0x82D4C60", VA = "0x1882D5860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly HashSet<NEBPKINFJKK> NNPBGNFFLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private LNAEMNOKNDE NPNCKHICDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private LHLFHJJLIPN CNCGLFBHFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private OOEHAOJOEMN NMKADLHJDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private FKNPMFLBNCF CAJHNPOIIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private IDisposable FIOMAPEOAFP;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x82EA1D0", Offset = "0x82E95D0", VA = "0x1882EA1D0", Slot = "5")]
	public void ENMMELFAOHH(LHLFHJJLIPN CNCGLFBHFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x82EA170", Offset = "0x82E9570", VA = "0x1882EA170", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x82EA720", Offset = "0x82E9B20", VA = "0x1882EA720", Slot = "4")]
	public bool KMGNOEGFENF(NEBPKINFJKK NGNCMLKIIIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x82EA580", Offset = "0x82E9980", VA = "0x1882EA580")]
	private void JKMICGABDNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x82E9A70", Offset = "0x82E8E70", VA = "0x1882E9A70")]
	private void CHPKOMGMMLL(PMABFBOEKAG NILNGFKCINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x82EA920", Offset = "0x82E9D20", VA = "0x1882EA920")]
	[AsyncStateMachine(typeof(FOGMJPOBEMG))]
	private Task NHFELIIIKMD(int MNNHJBJAAJF, JMJBOEJBCPI CLOPLKJEDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x82EA4B0", Offset = "0x82E98B0", VA = "0x1882EA4B0")]
	private Func<CancellationToken, List<Task>> EPDLFBKOOLC(int MNNHJBJAAJF, JMJBOEJBCPI CLOPLKJEDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x82E9C90", Offset = "0x82E9090", VA = "0x1882E9C90")]
	private List<Task> DOGDODGCKPD(int MNNHJBJAAJF, JMJBOEJBCPI CLOPLKJEDAD, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x82EA800", Offset = "0x82E9C00", VA = "0x1882EA800")]
	[AsyncStateMachine(typeof(KAMEBGCJCPC))]
	private Task LINGOFEAJJI(NEBPKINFJKK GDILCIHIHJE, CancellationToken PAHPIGHLKFG, int MNNHJBJAAJF, JMJBOEJBCPI CLOPLKJEDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x82EA650", Offset = "0x82E9A50", VA = "0x1882EA650")]
	[AsyncStateMachine(typeof(ACILCKACPJB))]
	private Task JNGICNKJCJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x82EA780", Offset = "0x82E9B80", VA = "0x1882EA780")]
	private void KOCPBONGJHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x82EAA10", Offset = "0x82E9E10", VA = "0x1882EAA10")]
	public JPDAGDICDAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[UnityEngine.Scripting.Preserve]
internal sealed class CNFNKIECCKE : KOAMAHKJIOG, GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class AAPLDDIOLPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AAPLDDIOLPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x82D5520", Offset = "0x82D4920", VA = "0x1882D5520")]
		internal object ABGLLHMONKO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class OOHIDKIHNIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public OOHIDKIHNIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x82F2010", Offset = "0x82F1410", VA = "0x1882F2010")]
		internal object LDFAKAGPPOL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class FGMJEGFOGBC
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public FGMJEGFOGBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class ILHJLCHEMBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public ILHJLCHEMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x82E75D0", Offset = "0x82E69D0", VA = "0x1882E75D0")]
		internal object GLBMPNOJEAG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class BBCFOBAADHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BBCFOBAADHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x82D6780", Offset = "0x82D5B80", VA = "0x1882D6780")]
		internal object LLKIICLFIAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private readonly Dictionary<Guid, IGKMMOJCCOM> CAMCBGNDNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private readonly TimeSpan BHPOKIOEKGE;

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "9")]
	public void ENMMELFAOHH(LHLFHJJLIPN CNCGLFBHFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x82DBE20", Offset = "0x82DB220", VA = "0x1882DBE20", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x82DC160", Offset = "0x82DB560", VA = "0x1882DC160", Slot = "4")]
	public JMDIMJDCLIF FGAAHPGCDNG(Guid IAFOFMFFKIO)
	{
		return default(JMDIMJDCLIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x82DC380", Offset = "0x82DB780", VA = "0x1882DC380", Slot = "5")]
	public bool NMPKBAOEGPN(Guid IAFOFMFFKIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x82DBE30", Offset = "0x82DB230", VA = "0x1882DBE30", Slot = "6")]
	public bool FEACEIJBACD(Guid IAFOFMFFKIO, Task DMAKFDFMNKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x82DBBD0", Offset = "0x82DAFD0", VA = "0x1882DBBD0", Slot = "7")]
	public bool AONCHGBEKOO(Guid IAFOFMFFKIO, AEALKLKILHL KJGABACDPEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x82DBDB0", Offset = "0x82DB1B0", VA = "0x1882DBDB0", Slot = "8")]
	public Task<(AEALKLKILHL, Task)> BPHFAGJAJJB(Guid IAFOFMFFKIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x82DC590", Offset = "0x82DB990", VA = "0x1882DC590")]
	private void PMIJMLGDKCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x82DC7C0", Offset = "0x82DBBC0", VA = "0x1882DC7C0")]
	public CNFNKIECCKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[RecRoom.NoEngine.Common.Preserve]
internal class GMHNCHFLCIH : AOLJKEMGNBI, GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private class EHALPGPKJCF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private readonly ECGOJJLBFIL HJBOHCENIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private readonly CancellationTokenSource LOIPKDKGEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public readonly CancellationToken BJEHHDHHFKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private bool GKGBONCIMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private bool FJEDLGBMFFE;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x82E0210", Offset = "0x82DF610", VA = "0x1882E0210")]
		public EHALPGPKJCF(ECGOJJLBFIL HJBOHCENIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x82E00C0", Offset = "0x82DF4C0", VA = "0x1882E00C0")]
		public void KOCPBONGJHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x82E0090", Offset = "0x82DF490", VA = "0x1882E0090", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class FDDCFBNECNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public BGKOCAICLAE disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public FDDCFBNECNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x82E1340", Offset = "0x82E0740", VA = "0x1882E1340")]
		internal object HMMEJDBFGJD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct OBMEAPKJIHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public BGKOCAICLAE disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public GMHNCHFLCIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x82EFAC0", Offset = "0x82EEEC0", VA = "0x1882EFAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x82EFF10", Offset = "0x82EF310", VA = "0x1882EFF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class MIOCLNNHEEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public GMHNCHFLCIH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public MIOCLNNHEEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x82EE240", Offset = "0x82ED640", VA = "0x1882EE240")]
		internal object KMDHHDGKPDE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class NJALGINJCAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public ECGOJJLBFIL newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public MIOCLNNHEEP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public NJALGINJCAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x82EF3A0", Offset = "0x82EE7A0", VA = "0x1882EF3A0")]
		internal object EMPPIBFENIE((ECGOJJLBFIL lastLocalPlayerRoomInstance, ECGOJJLBFIL newRoomInstance, DPHHHFAFOFC fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct DIFPMFAMFIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public GMHNCHFLCIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private FNIAOHCFFHK <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x82DC900", Offset = "0x82DBD00", VA = "0x1882DC900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class JOHAACJJAKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public ECGOJJLBFIL newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public JOHAACJJAKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x82E98A0", Offset = "0x82E8CA0", VA = "0x1882E98A0")]
		internal object CPMPKLAPEFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x82E9980", Offset = "0x82E8D80", VA = "0x1882E9980")]
		internal void OLAMJJDHELD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x82E9940", Offset = "0x82E8D40", VA = "0x1882E9940")]
		internal object GEKEOHBMLGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x82E9860", Offset = "0x82E8C60", VA = "0x1882E9860")]
		internal object ANKMGMIEKJA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct OEAGCJFNJKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public ECGOJJLBFIL newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public GMHNCHFLCIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public PJKLHEMEKPG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private JOHAACJJAKD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x82EFF70", Offset = "0x82EF370", VA = "0x1882EFF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x82F0F30", Offset = "0x82F0330", VA = "0x1882F0F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly CGFKKMHBEKL.EAJAHAPCOPP BOAHGGCJPIL;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly GDFDMFMFFAD IDFOLEAEIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private LNAEMNOKNDE NPNCKHICDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private LHLFHJJLIPN CNCGLFBHFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private DPHHHFAFOFC IKACDKLNPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private LLKLGIOAOCK HLIKBEKBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private AILCPENEKDG ICLMPPLIKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private OJOCFDFOCPF EAPLEJDFFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private ECGOJJLBFIL FDMPKFHJLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private EHALPGPKJCF OFFGFDFKDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private bool CMJPILBLOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private Task HEPPMGPDCHB;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private EOFPDHAABFM OHFFLHAGGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x82E31C0", Offset = "0x82E25C0", VA = "0x1882E31C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool BBDJCLEECMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xC3A520", Offset = "0xC39920", VA = "0x180C3A520")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x82E2800", Offset = "0x82E1C00", VA = "0x1882E2800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x82E2B90", Offset = "0x82E1F90", VA = "0x1882E2B90", Slot = "4")]
	public void ENMMELFAOHH(LHLFHJJLIPN CNCGLFBHFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x82E29A0", Offset = "0x82E1DA0", VA = "0x1882E29A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x82E3500", Offset = "0x82E2900", VA = "0x1882E3500")]
	[AsyncStateMachine(typeof(OBMEAPKJIHD))]
	private Task OPOJKPOLLBN(BGKOCAICLAE DFGGMIJGADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x82E2F60", Offset = "0x82E2360", VA = "0x1882E2F60")]
	private void HHFCDLHBJKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x82E2810", Offset = "0x82E1C10", VA = "0x1882E2810")]
	private void DNLPCBLIGLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x82E35F0", Offset = "0x82E29F0", VA = "0x1882E35F0")]
	private void PIPFJNKPPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x82E2B10", Offset = "0x82E1F10", VA = "0x1882E2B10")]
	private bool EEKIJILINIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x82E30F0", Offset = "0x82E24F0", VA = "0x1882E30F0")]
	[AsyncStateMachine(typeof(DIFPMFAMFIK))]
	private void HJEJFNAHKEA(int JAOBHFJGJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x82E3260", Offset = "0x82E2660", VA = "0x1882E3260")]
	private void OBPBAPLGGFP([Out] IDisposable OCIGAEPPJOF, [Out] IDisposable BHBDMPMGEFA, [Out] IDisposable DHNEGALAIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x82E2700", Offset = "0x82E1B00", VA = "0x1882E2700")]
	private bool APCFFGFODHH(ECGOJJLBFIL HJBOHCENIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x82E3210", Offset = "0x82E2610", VA = "0x1882E3210")]
	private void JBNLOEAOCAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x82E2E30", Offset = "0x82E2230", VA = "0x1882E2E30")]
	[AsyncStateMachine(typeof(OEAGCJFNJKG))]
	private Task HFCBNDCJOMO(ECGOJJLBFIL HJBOHCENIMO, PJKLHEMEKPG GJICGBGEIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x82E3B30", Offset = "0x82E2F30", VA = "0x1882E3B30")]
	public GMHNCHFLCIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[UnityEngine.Scripting.Preserve]
internal sealed class IPJEKKHONCA : JLCPDDFBFLB, GIBBKBNAGGA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct CBKLHJMOCCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<MCCMJJHBLDP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public IPJEKKHONCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<MCCMJJHBLDP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x82D9180", Offset = "0x82D8580", VA = "0x1882D9180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x82D9410", Offset = "0x82D8810", VA = "0x1882D9410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class NLOCBPFICPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public HOGPILOHPJM message;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public NLOCBPFICPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x82EF460", Offset = "0x82EE860", VA = "0x1882EF460")]
		internal object BHCINIBMJDE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class ILPCAMNDNON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public HOGPILOHPJM messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public ILPCAMNDNON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x82E7630", Offset = "0x82E6A30", VA = "0x1882E7630")]
		internal object OCHOIEFKEBP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class GIONDOJADAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public HOGPILOHPJM request;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public GIONDOJADAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x82E26A0", Offset = "0x82E1AA0", VA = "0x1882E26A0")]
		internal object MPBNDHFLEBJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct MNBOLGHDOAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public HOGPILOHPJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public IPJEKKHONCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<PJCDBCNMOMI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x82EE530", Offset = "0x82ED930", VA = "0x1882EE530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x82EEE00", Offset = "0x82EE200", VA = "0x1882EEE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class MLFACABDAMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public HOGPILOHPJM operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public MLFACABDAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x82EE4D0", Offset = "0x82ED8D0", VA = "0x1882EE4D0")]
		internal object OFJKMFDIBDE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct BCBKIPAIFMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public HOGPILOHPJM operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public IPJEKKHONCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private LJOHHGILGBC <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<HOGPILOHPJM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x82D7040", Offset = "0x82D6440", VA = "0x1882D7040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x82D7BC0", Offset = "0x82D6FC0", VA = "0x1882D7BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct NPBBFEHOCMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public AsyncTaskMethodBuilder<PJCDBCNMOMI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public IPJEKKHONCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public HOGPILOHPJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private FFHMNGMBNJI.HKKPDFOOKIK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private LJOHHGILGBC <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter<HOGPILOHPJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x82EF4C0", Offset = "0x82EE8C0", VA = "0x1882EF4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x82EF9F0", Offset = "0x82EEDF0", VA = "0x1882EF9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class CJLGBFFPHGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public PJCDBCNMOMI operation;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public CJLGBFFPHGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x82DB390", Offset = "0x82DA790", VA = "0x1882DB390")]
		internal object EICLOMKOIBP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct JLOJKENJAAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public PJCDBCNMOMI operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public IPJEKKHONCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private BNJJFADPKOK<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x82E90C0", Offset = "0x82E84C0", VA = "0x1882E90C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x82E9700", Offset = "0x82E8B00", VA = "0x1882E9700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class PDFGEMJHOON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public HOGPILOHPJM request;

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public PDFGEMJHOON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x82F2250", Offset = "0x82F1650", VA = "0x1882F2250")]
		internal object OOBHMHGILIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class OBIFHFMKEMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public HOGPILOHPJM request;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public OBIFHFMKEMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x82EFA60", Offset = "0x82EEE60", VA = "0x1882EFA60")]
		internal object NENJJMOJELG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private LHLFHJJLIPN CNCGLFBHFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private IIEIJMHMIDP MNDMKGFPPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private GBECEDNOEAP MOBKOGOJAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private KDADCPFMPNP EENGEPLMGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private LPHAKFKHFIH MFHPJCBDCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private TaskCompletionSource<MCCMJJHBLDP> MEAEDONLFLK;

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x82E7ED0", Offset = "0x82E72D0", VA = "0x1882E7ED0", Slot = "7")]
	public void ENMMELFAOHH(LHLFHJJLIPN CNCGLFBHFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x82E7FC0", Offset = "0x82E73C0", VA = "0x1882E7FC0", Slot = "6")]
	[AsyncStateMachine(typeof(CBKLHJMOCCJ))]
	public Task<MCCMJJHBLDP> FNPJNIJFBLM(CancellationToken LGNBGINOHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x82E7690", Offset = "0x82E6A90", VA = "0x1882E7690", Slot = "4")]
	public void AFMMHIPOGCO(HOGPILOHPJM FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x82E86E0", Offset = "0x82E7AE0", VA = "0x1882E86E0", Slot = "5")]
	public void OMJKGNDIDEL(HOGPILOHPJM GHNFFCENNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x82E8270", Offset = "0x82E7670", VA = "0x1882E8270")]
	[AsyncStateMachine(typeof(MNBOLGHDOAE))]
	private Task LDDOIKKMOPJ(HOGPILOHPJM LFFAIMMKIAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x82E80D0", Offset = "0x82E74D0", VA = "0x1882E80D0")]
	[AsyncStateMachine(typeof(BCBKIPAIFMB))]
	private Task KFOFNCIPJJA(HOGPILOHPJM IEPDGAKMFIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x82E8590", Offset = "0x82E7990", VA = "0x1882E8590")]
	[AsyncStateMachine(typeof(NPBBFEHOCMH))]
	private Task<PJCDBCNMOMI> NGGOMPGNBPC(HOGPILOHPJM LFFAIMMKIAM, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x82E81E0", Offset = "0x82E75E0", VA = "0x1882E81E0")]
	private LJOHHGILGBC KLCAIBBDFOO(HOGPILOHPJM MFKNAHPEKFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x82E7DB0", Offset = "0x82E71B0", VA = "0x1882E7DB0")]
	[AsyncStateMachine(typeof(JLOJKENJAAE))]
	private Task BJFPPGINCJM(PJCDBCNMOMI LLGAMDBNNCE, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x82E8380", Offset = "0x82E7780", VA = "0x1882E8380")]
	private PJCDBCNMOMI MPKBKAGOBCB(HOGPILOHPJM LFFAIMMKIAM, LJOHHGILGBC OFCENAICMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x3739CF0", Offset = "0x37390F0", VA = "0x183739CF0")]
	private T FHJJIEFAMEJ<T>(T OOEMJLHLIHJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x82E7A20", Offset = "0x82E6E20", VA = "0x1882E7A20")]
	private PJCDBCNMOMI BBGKFFDIDNG(HOGPILOHPJM LFFAIMMKIAM, LJOHHGILGBC OFCENAICMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public IPJEKKHONCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class CJJJMNEDNLD : GBECEDNOEAP, GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class KKCIIPJGONM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public KKCIIPJGONM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x82ECB00", Offset = "0x82EBF00", VA = "0x1882ECB00")]
		internal object DJKNKOEBGBB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class NCMNFGMHODN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public NCMNFGMHODN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x82EEE60", Offset = "0x82EE260", VA = "0x1882EEE60")]
		internal object HNAEBADHBPC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private LPHAKFKHFIH MFHPJCBDCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private GJCFGAAANPB AJBDFGPLKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private JLCPDDFBFLB PNPLGPGBLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private KOAMAHKJIOG CAMCBGNDNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private DDPNMHJOMBG DKFEPDFCMDK;

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x82D9A50", Offset = "0x82D8E50", VA = "0x1882D9A50", Slot = "6")]
	public void ENMMELFAOHH(LHLFHJJLIPN CNCGLFBHFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x82D9710", Offset = "0x82D8B10", VA = "0x1882D9710", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x82DA1D0", Offset = "0x82D95D0", VA = "0x1882DA1D0", Slot = "4")]
	public JMDIMJDCLIF KFDEOANBEGO(HOGPILOHPJM EPBKIEHJJCK)
	{
		return default(JMDIMJDCLIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x82D9BC0", Offset = "0x82D8FC0", VA = "0x1882D9BC0", Slot = "5")]
	public void FFABBCFMNIC(Guid IAFOFMFFKIO, Task DMAKFDFMNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x82DAD20", Offset = "0x82DA120", VA = "0x1882DAD20")]
	private void OHPMFJBOKCC(byte NDDBDBLEGEI, int CGMMAEHGDNB, object JPAHOGJAGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x82DADF0", Offset = "0x82DA1F0", VA = "0x1882DADF0")]
	private void OMCEELCFKIF(OPLHCIAJPIG NIIPCCMNFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x82D97C0", Offset = "0x82D8BC0", VA = "0x1882D97C0")]
	private void EMNNHIKICHJ(OPLHCIAJPIG NIIPCCMNFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x82DAAE0", Offset = "0x82D9EE0", VA = "0x1882DAAE0")]
	private void NFBFAJMKNAA(OPLHCIAJPIG NIIPCCMNFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x82DA610", Offset = "0x82D9A10", VA = "0x1882DA610")]
	private AEALKLKILHL MLKNBNNCPMK(HOGPILOHPJM MFKNAHPEKFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x82D9DD0", Offset = "0x82D91D0", VA = "0x1882D9DD0")]
	private void GFNFPOIGBOJ(HOGPILOHPJM IEPDGAKMFIA, AEALKLKILHL KJGABACDPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x82D9FE0", Offset = "0x82D93E0", VA = "0x1882D9FE0")]
	private bool IJLOIKLFIGF(HOGPILOHPJM IEPDGAKMFIA, AEALKLKILHL KJGABACDPEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x82DA8C0", Offset = "0x82D9CC0", VA = "0x1882DA8C0")]
	private bool NBKOBIAPADK(HOGPILOHPJM PNFFPOBOHCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x82D9480", Offset = "0x82D8880", VA = "0x1882D9480")]
	private bool DLKABPPBAMP(byte NDDBDBLEGEI, ExitGames.Client.Photon.Hashtable NIIPCCMNFHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public CJJJMNEDNLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[UnityEngine.Scripting.Preserve]
internal sealed class HKLFAPKBKLP : ECFEJGBAEFH, GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class MJEIABMDFDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public MCCMJJHBLDP operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public HKLFAPKBKLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public HOGPILOHPJM roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public MJEIABMDFDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x82EE460", Offset = "0x82ED860", VA = "0x1882EE460")]
		internal object PMMNDOOBELC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x82EE2B0", Offset = "0x82ED6B0", VA = "0x1882EE2B0")]
		internal object CIBBKIBCJIF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct AEFCPDPLDKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public AsyncTaskMethodBuilder<AEALKLKILHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public HKLFAPKBKLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public HOGPILOHPJM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter<AEALKLKILHL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x82D5F70", Offset = "0x82D5370", VA = "0x1882D5F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x82D6610", Offset = "0x82D5A10", VA = "0x1882D6610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class JOPLAHMDKLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public MCCMJJHBLDP operationType;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public JOPLAHMDKLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x82E9A00", Offset = "0x82E8E00", VA = "0x1882E9A00")]
		internal object GHODFOFBODB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class GAMLIHEEHDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public HOGPILOHPJM request;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public GAMLIHEEHDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x82E1A30", Offset = "0x82E0E30", VA = "0x1882E1A30")]
		internal object PIEJLJDFIBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x82E1950", Offset = "0x82E0D50", VA = "0x1882E1950")]
		internal object DNDKHPLIFGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x82E19C0", Offset = "0x82E0DC0", VA = "0x1882E19C0")]
		internal object JMGNDCKOCLG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct GMPEFLMHIDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public AsyncTaskMethodBuilder<AEALKLKILHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public HOGPILOHPJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public HKLFAPKBKLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private GAMLIHEEHDB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private JMDIMJDCLIF <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private AEALKLKILHL <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<(AEALKLKILHL validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x82E3BA0", Offset = "0x82E2FA0", VA = "0x1882E3BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x82E4470", Offset = "0x82E3870", VA = "0x1882E4470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private LPHAKFKHFIH MFHPJCBDCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private GJCFGAAANPB AJBDFGPLKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private GBECEDNOEAP MOBKOGOJAMJ;

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x82E6620", Offset = "0x82E5A20", VA = "0x1882E6620", Slot = "5")]
	public void ENMMELFAOHH(LHLFHJJLIPN CNCGLFBHFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x82E66D0", Offset = "0x82E5AD0", VA = "0x1882E66D0", Slot = "4")]
	[AsyncStateMachine(typeof(AEFCPDPLDKM))]
	private Task<AEALKLKILHL> GDIMCLLEDFE(HOGPILOHPJM MFKNAHPEKFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x82E6430", Offset = "0x82E5830", VA = "0x1882E6430")]
	private bool BGHNNLDDCDD(MCCMJJHBLDP LODIOJIJDAO, [Out] AEALKLKILHL APLCGCDLEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x82E67F0", Offset = "0x82E5BF0", VA = "0x1882E67F0")]
	[AsyncStateMachine(typeof(GMPEFLMHIDO))]
	private Task<AEALKLKILHL> OLHFAONKMIF(HOGPILOHPJM LFFAIMMKIAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public HKLFAPKBKLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class HBDJJEPJLHO : DCHGLMHEJOH, GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private struct OFIGLCOBGJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public GPEOIJBIPCA JIAOIEHKLFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public long LBHKAHBKJPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public Guid? CBBGAPABCCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public bool LECDBBGFKCF;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct FBEAJBOFDCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public AsyncTaskMethodBuilder<JKNOMNBJNEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public ECGOJJLBFIL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public HBDJJEPJLHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter<HNAJHGJKLNP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<JKNOMNBJNEB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x82E0B00", Offset = "0x82DFF00", VA = "0x1882E0B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x82E10D0", Offset = "0x82E04D0", VA = "0x1882E10D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class EJAPAKOFLBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public EJAPAKOFLBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x82E02C0", Offset = "0x82DF6C0", VA = "0x1882E02C0")]
		internal object LJANDOFKGPB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct KINFMAALJLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<HNAJHGJKLNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public HBDJJEPJLHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public ECGOJJLBFIL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private EJAPAKOFLBE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter<HNAJHGJKLNP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x82EC3A0", Offset = "0x82EB7A0", VA = "0x1882EC3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x82EC990", Offset = "0x82EBD90", VA = "0x1882EC990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct IIANFLGBBPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder<JKNOMNBJNEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public HBDJJEPJLHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public ECGOJJLBFIL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public HNAJHGJKLNP roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<OFIGLCOBGJO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x82E6FF0", Offset = "0x82E63F0", VA = "0x1882E6FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x82E7560", Offset = "0x82E6960", VA = "0x1882E7560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class PBJOCNEBJDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public HNAJHGJKLNP roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public PBJOCNEBJDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xE19250", Offset = "0xE18650", VA = "0x180E19250")]
		internal bool LJOBDJPELGH(HABMELLNJLH sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x82F2070", Offset = "0x82F1470", VA = "0x1882F2070")]
		internal object FNPNLDONMKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x82F2130", Offset = "0x82F1530", VA = "0x1882F2130")]
		internal object GBPGOJCNLFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x82F21C0", Offset = "0x82F15C0", VA = "0x1882F21C0")]
		internal object GOLOIELGFLI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class KIOCADIKPCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public PBJOCNEBJDJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public KIOCADIKPCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x82ECA00", Offset = "0x82EBE00", VA = "0x1882ECA00")]
		internal object KOPAFMMFDNA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct OHEEBIELDNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder<OFIGLCOBGJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public HNAJHGJKLNP roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public HBDJJEPJLHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public ECGOJJLBFIL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private KIOCADIKPCK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private TaskAwaiter<OFIGLCOBGJO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private TaskAwaiter<JDNBODNOFNG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x82F0F90", Offset = "0x82F0390", VA = "0x1882F0F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x82F1F40", Offset = "0x82F1340", VA = "0x1882F1F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class BKHMDOCFKPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BKHMDOCFKPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x82D8470", Offset = "0x82D7870", VA = "0x1882D8470")]
		internal object AFCHDNPFMED()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct JPKDHDPGLFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AsyncTaskMethodBuilder<OFIGLCOBGJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public HABMELLNJLH subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public HBDJJEPJLHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public ECGOJJLBFIL dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private BKHMDOCFKPM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private TaskAwaiter<MJKAJBCBAGM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x82EAAA0", Offset = "0x82E9EA0", VA = "0x1882EAAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x82EB170", Offset = "0x82EA570", VA = "0x1882EB170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private LLKLGIOAOCK HLIKBEKBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private AILCPENEKDG ICLMPPLIKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private JOLGBJEMEGL GEDDNLIABGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private PJDACJNGEOD OCMIIHJLBBF;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x82E57D0", Offset = "0x82E4BD0", VA = "0x1882E57D0", Slot = "5")]
	public void ENMMELFAOHH(LHLFHJJLIPN CNCGLFBHFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x82E58C0", Offset = "0x82E4CC0", VA = "0x1882E58C0", Slot = "4")]
	[AsyncStateMachine(typeof(FBEAJBOFDCE))]
	public Task<JKNOMNBJNEB> FBCGNGLLIJP(BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, ECGOJJLBFIL EEAMAAFGDPN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x82E5B90", Offset = "0x82E4F90", VA = "0x1882E5B90")]
	[AsyncStateMachine(typeof(KINFMAALJLB))]
	private Task<HNAJHGJKLNP> MCACHFILGCG(ECGOJJLBFIL EEAMAAFGDPN, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x82E5660", Offset = "0x82E4A60", VA = "0x1882E5660")]
	[AsyncStateMachine(typeof(IIANFLGBBPO))]
	private Task<JKNOMNBJNEB> EHGGBMGGKAK(ECGOJJLBFIL EEAMAAFGDPN, HNAJHGJKLNP LCBJKEIGKLM, long AKJILJJKOFL, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x82E5A20", Offset = "0x82E4E20", VA = "0x1882E5A20")]
	[AsyncStateMachine(typeof(OHEEBIELDNE))]
	private Task<OFIGLCOBGJO> FEHAECIGEBL(ECGOJJLBFIL EEAMAAFGDPN, HNAJHGJKLNP LCBJKEIGKLM, long AKJILJJKOFL, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x82E54F0", Offset = "0x82E48F0", VA = "0x1882E54F0")]
	[AsyncStateMachine(typeof(JPKDHDPGLFP))]
	private Task<OFIGLCOBGJO> CFBGNKFFFNA(ECGOJJLBFIL JEJJGFNDPNN, HABMELLNJLH LCHNEIADLCB, long AKJILJJKOFL, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public HBDJJEPJLHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[UnityEngine.Scripting.Preserve]
internal sealed class HCHOPPMNAAL : KDADCPFMPNP, GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class OKKMNLAEBJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public HOGPILOHPJM request;

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public OKKMNLAEBJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x82F1FB0", Offset = "0x82F13B0", VA = "0x1882F1FB0")]
		internal object DPMDBLIMMAC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private struct JFCKFGACJGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public AsyncTaskMethodBuilder<HOGPILOHPJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public HOGPILOHPJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public HCHOPPMNAAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public LJOHHGILGBC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private TaskAwaiter<HOGPILOHPJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x82E8A40", Offset = "0x82E7E40", VA = "0x1882E8A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x82E9050", Offset = "0x82E8450", VA = "0x1882E9050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct KKEOPOFKPFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public AsyncTaskMethodBuilder<HOGPILOHPJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public HCHOPPMNAAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public LJOHHGILGBC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TaskAwaiter<JJHGLACJPOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x82ECB70", Offset = "0x82EBF70", VA = "0x1882ECB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x82ED170", Offset = "0x82EC570", VA = "0x1882ED170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class AIGCJLOOLGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public HOGPILOHPJM request;

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AIGCJLOOLGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x82D6680", Offset = "0x82D5A80", VA = "0x1882D6680")]
		internal object NALBEAAELPP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct BPMKCACEPNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder<HOGPILOHPJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public HOGPILOHPJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public HCHOPPMNAAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public LJOHHGILGBC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private ECFIOHOLLBH <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private JIHLNLGMMDC <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private TaskAwaiter<JJHGLACJPOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x82D8520", Offset = "0x82D7920", VA = "0x1882D8520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x82D9110", Offset = "0x82D8510", VA = "0x1882D9110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private LPHAKFKHFIH MFHPJCBDCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private NGJOOKOOPFO MLMDPNFMONL;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private AMEIOOCAHKO HBFAKPBIGNB
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x82E5E40", Offset = "0x82E5240", VA = "0x1882E5E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x82E6060", Offset = "0x82E5460", VA = "0x1882E6060", Slot = "8")]
	public void ENMMELFAOHH(LHLFHJJLIPN CNCGLFBHFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x82E6220", Offset = "0x82E5620", VA = "0x1882E6220", Slot = "4")]
	[AsyncStateMachine(typeof(JFCKFGACJGN))]
	public Task<HOGPILOHPJM> NBEOBCBCNBF(HOGPILOHPJM LFFAIMMKIAM, LJOHHGILGBC OFCENAICMPD, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x82E5CF0", Offset = "0x82E50F0", VA = "0x1882E5CF0", Slot = "5")]
	[AsyncStateMachine(typeof(KKEOPOFKPFM))]
	public Task<HOGPILOHPJM> ADALFFIIPGD(CancellationToken JDDHIJBJNHP, LJOHHGILGBC OFCENAICMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x82E6380", Offset = "0x82E5780", VA = "0x1882E6380", Slot = "6")]
	public EKCMCCJKLGK ODJANFIKEMA(PJCDBCNMOMI EJDEDAIJHNC, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x82E60F0", Offset = "0x82E54F0", VA = "0x1882E60F0", Slot = "7")]
	public EKCMCCJKLGK JNKOOGMMODG(PJCDBCNMOMI EJDEDAIJHNC, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x82E5F00", Offset = "0x82E5300", VA = "0x1882E5F00")]
	[AsyncStateMachine(typeof(BPMKCACEPNC))]
	private Task<HOGPILOHPJM> EKJJGNJCDEC(HOGPILOHPJM LFFAIMMKIAM, LJOHHGILGBC OFCENAICMPD, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x353C5C0", Offset = "0x353B9C0", VA = "0x18353C5C0")]
	private static byte[] ODHGNNGNCNJ(HOGPILOHPJM FGEBHLNNMNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public HCHOPPMNAAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[UnityEngine.Scripting.Preserve]
internal sealed class PFIGGCAFLJL : GJCFGAAANPB, GIBBKBNAGGA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private KABGKKMFHEJ GDPCCIJMGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private LPHAKFKHFIH MFHPJCBDCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private IIEIJMHMIDP MNDMKGFPPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private BMLOHPGFPPG MHNMKEODBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private LLKLGIOAOCK HLIKBEKBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private OJOCFDFOCPF EAPLEJDFFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private JJDMBPKALHJ HIELIKJIKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private AILCPENEKDG ICLMPPLIKCJ;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private EOFPDHAABFM OHFFLHAGGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x82F26B0", Offset = "0x82F1AB0", VA = "0x1882F26B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static AEALKLKILHL OACLJGMAPCF
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x82F2700", Offset = "0x82F1B00", VA = "0x1882F2700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x82F2530", Offset = "0x82F1930", VA = "0x1882F2530", Slot = "6")]
	public void ENMMELFAOHH(LHLFHJJLIPN CNCGLFBHFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x82F2710", Offset = "0x82F1B10", VA = "0x1882F2710", Slot = "4")]
	public AEALKLKILHL LBILBHJLBLE(EKIKILMCLIO IKIPBIHEFBA, MCCMJJHBLDP FILHOBMLBKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x82F22B0", Offset = "0x82F16B0", VA = "0x1882F22B0", Slot = "5")]
	public AEALKLKILHL EBAOEAELIDG(EKIKILMCLIO JODMALNMLGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x82F26A0", Offset = "0x82F1AA0", VA = "0x1882F26A0")]
	private static AEALKLKILHL IEKCFLMLICG(MCEMLLJABCE HJCCPGPOLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public PFIGGCAFLJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class FOFDHJKKEBH : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x82E13D0", Offset = "0x82E07D0", VA = "0x1882E13D0")]
	public FOFDHJKKEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7523BB0", Offset = "0x7522FB0", VA = "0x187523BB0")]
	public FOFDHJKKEBH(string FGEBHLNNMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[UnityEngine.Scripting.Preserve]
internal sealed class GPKNDELKBFK : DNIHMPAIOAJ, GIBBKBNAGGA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct KGDIEKGICEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public AsyncTaskMethodBuilder<AEALKLKILHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public GPKNDELKBFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public OKAHFFFFHHK autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private BNJJFADPKOK<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private DLLPDBGKFBJ <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private TaskAwaiter<AEALKLKILHL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x82EB7E0", Offset = "0x82EABE0", VA = "0x1882EB7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x82EC330", Offset = "0x82EB730", VA = "0x1882EC330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct CMDPGHAEEII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public GPKNDELKBFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x82DB410", Offset = "0x82DA810", VA = "0x1882DB410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x82DBB70", Offset = "0x82DAF70", VA = "0x1882DBB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct PGCJNKLFGPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public GPKNDELKBFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x82F2880", Offset = "0x82F1C80", VA = "0x1882F2880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x82F2D90", Offset = "0x82F2190", VA = "0x1882F2D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct DIPLBDLFBGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public GPKNDELKBFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x82DE080", Offset = "0x82DD480", VA = "0x1882DE080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x82DE7D0", Offset = "0x82DDBD0", VA = "0x1882DE7D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct FBPFBOMNEOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public GPKNDELKBFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x82E1140", Offset = "0x82E0540", VA = "0x1882E1140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x82E12E0", Offset = "0x82E06E0", VA = "0x1882E12E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct EMMEFJAMOAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public GPKNDELKBFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x82E0370", Offset = "0x82DF770", VA = "0x1882E0370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x82E0AA0", Offset = "0x82DFEA0", VA = "0x1882E0AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct NGJMANMPLHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public GPKNDELKBFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x82EEED0", Offset = "0x82EE2D0", VA = "0x1882EEED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x82EF340", Offset = "0x82EE740", VA = "0x1882EF340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct KFDGDFPGGEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public GPKNDELKBFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public FOBHJDGLMCB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private BNJJFADPKOK<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x8306580", Offset = "0x8305980", VA = "0x188306580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x8306B20", Offset = "0x8305F20", VA = "0x188306B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private LPHAKFKHFIH MFHPJCBDCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private LHLFHJJLIPN CNCGLFBHFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private LLKLGIOAOCK HLIKBEKBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private KDADCPFMPNP EENGEPLMGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private IIEIJMHMIDP MNDMKGFPPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private JJDMBPKALHJ HIELIKJIKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private CancellationTokenSource CJJCFJADPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private Task CPLKIGNHDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private TaskCompletionSource<int> LAIPEOIKLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private int EKJPEMCLPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private int EOPFIAKDNDB;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x82E4940", Offset = "0x82E3D40", VA = "0x1882E4940", Slot = "6")]
	public void ENMMELFAOHH(LHLFHJJLIPN CNCGLFBHFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x122C340", Offset = "0x122B740", VA = "0x18122C340", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x82E4670", Offset = "0x82E3A70", VA = "0x1882E4670")]
	private void BIPGHNALHPM(float FNLGHOOFPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x82E4E40", Offset = "0x82E4240", VA = "0x1882E4E40", Slot = "4")]
	[AsyncStateMachine(typeof(KGDIEKGICEH))]
	public Task<AEALKLKILHL> LELHEAIKDPF(OKAHFFFFHHK OLLDGDPALBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x82E4AF0", Offset = "0x82E3EF0", VA = "0x1882E4AF0", Slot = "5")]
	[AsyncStateMachine(typeof(CMDPGHAEEII))]
	public Task FAHDBKJLFDG([Optional] CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x122C340", Offset = "0x122B740", VA = "0x18122C340")]
	public void FLIBMFELLPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x82E4BE0", Offset = "0x82E3FE0", VA = "0x1882E4BE0")]
	private DLLPDBGKFBJ HDMIHJKGBKN(OKAHFFFFHHK OLLDGDPALBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x82E4750", Offset = "0x82E3B50", VA = "0x1882E4750")]
	[AsyncStateMachine(typeof(PGCJNKLFGPB))]
	private Task CGKPAONGGFG(CancellationToken EKBICDMGFBA, int MNNHJBJAAJF, JMJBOEJBCPI CLOPLKJEDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x82E4840", Offset = "0x82E3C40", VA = "0x1882E4840")]
	[AsyncStateMachine(typeof(DIPLBDLFBGD))]
	private Task DBJLEAFPFIK(CancellationToken EKBICDMGFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x82E4F70", Offset = "0x82E4370", VA = "0x1882E4F70")]
	[AsyncStateMachine(typeof(FBPFBOMNEOK))]
	private Task LJPCBCEENHL([Optional] CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x82E4D50", Offset = "0x82E4150", VA = "0x1882E4D50")]
	[AsyncStateMachine(typeof(EMMEFJAMOAC))]
	private Task KHMEPMMDCHL(CancellationToken EKBICDMGFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x82E53F0", Offset = "0x82E47F0", VA = "0x1882E53F0")]
	[AsyncStateMachine(typeof(NGJMANMPLHJ))]
	private Task POGDGEHOBFI(CancellationToken FLCPFFKBEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x82E44E0", Offset = "0x82E38E0", VA = "0x1882E44E0")]
	private Task AHBEDIIDMJF(FOBHJDGLMCB CJFNFMAHILH, CancellationToken EKBICDMGFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x82E5060", Offset = "0x82E4460", VA = "0x1882E5060")]
	[AsyncStateMachine(typeof(KFDGDFPGGEL))]
	private Task LOIECNJAKPD(FOBHJDGLMCB CJFNFMAHILH, CancellationToken EKBICDMGFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x82E5170", Offset = "0x82E4570", VA = "0x1882E5170")]
	private bool NOHLBKPOEKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public GPKNDELKBFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[UnityEngine.Scripting.Preserve]
internal class ELJEPELBEHP : BMLOHPGFPPG, GIBBKBNAGGA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct ABAMBHIHKIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public ELJEPELBEHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private BNJJFADPKOK<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x82F3770", Offset = "0x82F2B70", VA = "0x1882F3770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x82F3D30", Offset = "0x82F3130", VA = "0x1882F3D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private BEPNFOFFIEI DGOKMHMFACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private LHLFHJJLIPN CNCGLFBHFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private GJCFGAAANPB AJBDFGPLKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private KDADCPFMPNP EENGEPLMGHE;

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x82FDBB0", Offset = "0x82FCFB0", VA = "0x1882FDBB0", Slot = "6")]
	public void ENMMELFAOHH(LHLFHJJLIPN CNCGLFBHFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x82FDB60", Offset = "0x82FCF60", VA = "0x1882FDB60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x82FDE90", Offset = "0x82FD290", VA = "0x1882FDE90", Slot = "5")]
	[AsyncStateMachine(typeof(ABAMBHIHKIA))]
	public Task JBNBKIHFLLD(string BHKOPEBBFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x82FE0D0", Offset = "0x82FD4D0", VA = "0x1882FE0D0", Slot = "4")]
	public AEALKLKILHL NOHLBKPOEKA(EKIKILMCLIO IKIPBIHEFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x82FDF90", Offset = "0x82FD390", VA = "0x1882FDF90")]
	private GCMDHIPDMBL MNDMMBLHKDO(string BHKOPEBBFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public ELJEPELBEHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class DOFFOBFMNEJ
{
	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x82F96D0", Offset = "0x82F8AD0", VA = "0x1882F96D0")]
	public static void PBDKJDFCIFK(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x82F9060", Offset = "0x82F8460", VA = "0x1882F9060")]
	internal static void GKFENHKHDHK(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x82F95F0", Offset = "0x82F89F0", VA = "0x1882F95F0")]
	internal static void OBLNPBAKPJN(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x82F91C0", Offset = "0x82F85C0", VA = "0x1882F91C0")]
	internal static void JAGBNDNAPLP(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x350BD10", Offset = "0x350B110", VA = "0x18350BD10")]
	private static void OCCBMAHBNCG<Interface, Impl, Interface>(NPCGGDCACLM INELJPKBMLP) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class IOLAJIFBPBF : BJENCJHGNPA<HOGPILOHPJM>
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class GIHLNNOKGMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public HOGPILOHPJM message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public GIHLNNOKGMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x83002E0", Offset = "0x82FF6E0", VA = "0x1883002E0")]
		internal object KKKOLAIEHPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly IOLAJIFBPBF IADGMEFIGGI;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x83042D0", Offset = "0x83036D0", VA = "0x1883042D0")]
	public ExitGames.Client.Photon.Hashtable PEGKBLBFNLH(HOGPILOHPJM FGEBHLNNMNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x8303CC0", Offset = "0x83030C0", VA = "0x188303CC0", Slot = "5")]
	protected override void GOPLFMJHAIO(HOGPILOHPJM FGEBHLNNMNH, IDictionary<object, object> AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x83040A0", Offset = "0x83034A0", VA = "0x1883040A0", Slot = "6")]
	public override HOGPILOHPJM ILOIKAMJPOD(IDictionary<object, object> AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x8303BB0", Offset = "0x8302FB0", VA = "0x188303BB0")]
	private static void BKFDGJHNENK(string CLHNFCENHCL, HOGPILOHPJM FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x8304400", Offset = "0x8303800", VA = "0x188304400")]
	public IOLAJIFBPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x8303DF0", Offset = "0x83031F0", VA = "0x188303DF0")]
	[CompilerGenerated]
	internal static string GPAMNKFAIIH(JKNOMNBJNEB CFFKMBGFAOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class HIHALKDGEOJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static AEALKLKILHL OACLJGMAPCF
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x8301BB0", Offset = "0x8300FB0", VA = "0x188301BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x8301C10", Offset = "0x8301010", VA = "0x188301C10")]
	public static bool LHIPDLMGBBP(this AEALKLKILHL KJGABACDPEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x8301B50", Offset = "0x8300F50", VA = "0x188301B50")]
	public static AEALKLKILHL IEKCFLMLICG(MCEMLLJABCE NCPNLAHMLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x83016F0", Offset = "0x8300AF0", VA = "0x1883016F0")]
	public static AEALKLKILHL CHDNBIPOPHK(IEnumerable<AEALKLKILHL> AAPLBFHHHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x83018F0", Offset = "0x8300CF0", VA = "0x1883018F0")]
	public static string HHDPFHPCJNJ(this AEALKLKILHL APLCGCDLEGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public abstract class IOBFOHBHMME : HAJBBLGBNDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public delegate AEALKLKILHL IHEAJAEEAJO([NotNull] EKIKILMCLIO HNEECOLCJBB);

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class MANHLCELPEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public EKIKILMCLIO photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public MANHLCELPEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x14E0680", Offset = "0x14DFA80", VA = "0x1814E0680")]
		internal AEALKLKILHL NHJFONECPKP(IHEAJAEEAJO v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	private bool LLMGCACGBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038E")]
	protected readonly HashSet<IHEAJAEEAJO> GOPNFLFKAFO;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x8303770", Offset = "0x8302B70", VA = "0x188303770", Slot = "4")]
	public void AACCOKEIGFG(IHEAJAEEAJO JBMAGACOOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x8303AC0", Offset = "0x8302EC0", VA = "0x188303AC0", Slot = "5")]
	public void KPPJECCICMA(IHEAJAEEAJO JBMAGACOOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x83037D0", Offset = "0x8302BD0", VA = "0x1883037D0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x8303820", Offset = "0x8302C20", VA = "0x188303820")]
	protected AEALKLKILHL ICBLABFHIFI(EKIKILMCLIO JODMALNMLGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x8303B20", Offset = "0x8302F20", VA = "0x188303B20")]
	protected IOBFOHBHMME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public class NFCJIEBKIFO : IOBFOHBHMME, KABGKKMFHEJ, HAJBBLGBNDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class HJIILHFHMFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public AEALKLKILHL result;

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public HJIILHFHMFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x8301C30", Offset = "0x8301030", VA = "0x188301C30")]
		internal object HLPFNNJMKFK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x82FC720", Offset = "0x82FBB20", VA = "0x1882FC720")]
	[UnityEngine.Scripting.Preserve]
	public NFCJIEBKIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x8309C50", Offset = "0x8309050", VA = "0x188309C50", Slot = "8")]
	public AEALKLKILHL ONJANLKLBLM(EKIKILMCLIO JODMALNMLGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class EKBLEEKBPOG : IOBFOHBHMME, BEPNFOFFIEI, HAJBBLGBNDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class DLAFGALCGLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public AEALKLKILHL result;

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public DLAFGALCGLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x82F8CF0", Offset = "0x82F80F0", VA = "0x1882F8CF0")]
		internal object GNBIMBAPINB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x82FC720", Offset = "0x82FBB20", VA = "0x1882FC720")]
	[UnityEngine.Scripting.Preserve]
	public EKBLEEKBPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x82FC610", Offset = "0x82FBA10", VA = "0x1882FC610", Slot = "8")]
	public AEALKLKILHL NOHLBKPOEKA(EKIKILMCLIO HANDOEBGAFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal static class COEOPONEGMA
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class BEOLFMFGJKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public BNJJFADPKOK<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BEOLFMFGJKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x82F68A0", Offset = "0x82F5CA0", VA = "0x1882F68A0")]
		internal object LMBJNAPNMKO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x82F8320", Offset = "0x82F7720", VA = "0x1882F8320")]
	public static BNJJFADPKOK<string> FPFLDAAEICN(LMKAPNBAFDO KIBGFJNEFGA, [Optional] string PALHOHABGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x82F8260", Offset = "0x82F7660", VA = "0x1882F8260")]
	public static void FDOBCDNFMAN(BNJJFADPKOK<string> IHAAMEONBJO, LMKAPNBAFDO KIBGFJNEFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x82F81A0", Offset = "0x82F75A0", VA = "0x1882F81A0")]
	public static string BHNPLEOOLFN(HOGPILOHPJM MFKNAHPEKFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal static class GBJKMEMBEBA
{
	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x82FFEB0", Offset = "0x82FF2B0", VA = "0x1882FFEB0")]
	public static void FIMFBMFPIHE(this LPHAKFKHFIH MFHPJCBDCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x82FFEA0", Offset = "0x82FF2A0", VA = "0x1882FFEA0")]
	public static void BHMAOEHEFLE(this LPHAKFKHFIH MFHPJCBDCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x82FFEC0", Offset = "0x82FF2C0", VA = "0x1882FFEC0")]
	private static void LFMLDLKDEEB(this LPHAKFKHFIH MFHPJCBDCMN, bool IBIFONGDBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class KCKKHBEKGMF : LNLEABIMEEE, MHHLGCJEGKC, EKHANEOMCNI, OHBLDCHHCFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	private readonly MHHLGCJEGKC OODIFKFCABF;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public EKIKILMCLIO EPJKFIDHMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x83052C0", Offset = "0x83046C0", VA = "0x1883052C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int FHLBFNPLELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x8304DC0", Offset = "0x83041C0", VA = "0x188304DC0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int NIPOOAFLEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x8305270", Offset = "0x8304670", VA = "0x188305270", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool CCKFFFNOJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int OJFCOJDOLJB
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xBB21D0", Offset = "0xBB15D0", VA = "0x180BB21D0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event MKOBGCKLGBC.FABKLKJBMGH ACIHNKPPBDK
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event CJMJLBKCBFP GDJELABBNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x8304E10", Offset = "0x8304210", VA = "0x188304E10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x8304F00", Offset = "0x8304300", VA = "0x188304F00", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> AKKDJJHGBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<EKIKILMCLIO> APEEJEADEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action NHMMEMEMMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x83051D0", Offset = "0x83045D0", VA = "0x1883051D0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x8305130", Offset = "0x8304530", VA = "0x188305130", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0xCCE090", Offset = "0xCCD490", VA = "0x180CCE090")]
	public KCKKHBEKGMF(MHHLGCJEGKC OODIFKFCABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x8304FA0", Offset = "0x83043A0", VA = "0x188304FA0", Slot = "8")]
	public bool MCFCJCDLGNA(byte NDDBDBLEGEI, object HIGADOGNONE, BIJHJPADKKG NGPACOBKLJA, SendOptions LELBGLABKEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x8305050", Offset = "0x8304450", VA = "0x188305050", Slot = "16")]
	public EKIKILMCLIO MMMHDDGIEOD(int KGKDIIKHGOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "19")]
	public void JNPHFHKBLPH(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "20")]
	public void OAALMGEDGPO(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "21")]
	public void NNCGOACENHH(object PAHPIGHLKFG, bool BJODENMJKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x8304EB0", Offset = "0x83042B0", VA = "0x188304EB0", Slot = "22")]
	public IDisposable HPOHPEKGBEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "23")]
	private bool CNAPDDOPEIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "24")]
	public void ODFBABJPKIM(StringBuilder NBMFACDLLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xEF2DF0", Offset = "0xEF21F0", VA = "0x180EF2DF0", Slot = "25")]
	public bool IJHJAEDLINB(bool AHPGKKBJPMG, [Out] string MHFONFLBJOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0xEA1B40", Offset = "0xEA0F40", VA = "0x180EA1B40", Slot = "28")]
	public void LAPFJFJELMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal struct OPLHCIAJPIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	private readonly IDictionary<object, object> NIIPCCMNFHI;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0xCE6E00", Offset = "0xCE6200", VA = "0x180CE6E00")]
	public OPLHCIAJPIG(IDictionary<object, object> NIIPCCMNFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x830C820", Offset = "0x830BC20", VA = "0x18830C820")]
	public bool OBJBMGJDJPB([Out] HOGPILOHPJM FGEBHLNNMNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x830C8D0", Offset = "0x830BCD0", VA = "0x18830C8D0")]
	public Guid OGJFLIPHECC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x830C6E0", Offset = "0x830BAE0", VA = "0x18830C6E0")]
	public AEALKLKILHL JOEHHNIAGFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x830C5F0", Offset = "0x830B9F0", VA = "0x18830C5F0")]
	public static ExitGames.Client.Photon.Hashtable BPKMLDCMEGB(HOGPILOHPJM FGEBHLNNMNH, AEALKLKILHL KJGABACDPEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal static class PDDPEDKIPKK
{
	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x830CE20", Offset = "0x830C220", VA = "0x18830CE20")]
	public static bool MHFMLNPKLIB(this ECGOJJLBFIL OINOCKJMHLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct FKNPMFLBNCF : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct EPHKHMPGDHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public FKNPMFLBNCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x82FE4D0", Offset = "0x82FD8D0", VA = "0x1882FE4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x82FE6B0", Offset = "0x82FDAB0", VA = "0x1882FE6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	private readonly CancellationTokenSource LOIPKDKGEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	private bool LLMGCACGBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	private Task OOCBIOLELBN;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool CMMDKLGDPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x82FF980", Offset = "0x82FED80", VA = "0x1882FF980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x82FF9B0", Offset = "0x82FEDB0", VA = "0x1882FF9B0")]
	public FKNPMFLBNCF(CancellationToken JDDHIJBJNHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x82FF870", Offset = "0x82FEC70", VA = "0x1882FF870")]
	[AsyncStateMachine(typeof(EPHKHMPGDHL))]
	public Task JHEJIOONLAK(Func<CancellationToken, List<Task>> PLGCEKMMKAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x82FF820", Offset = "0x82FEC20", VA = "0x1882FF820", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public readonly struct IOBMDNONMHF<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct MEPKKNEJPMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<JHFICJGOLCJ<TData>, IDMJKCLDJLO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public IOBMDNONMHF<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private TaskAwaiter<BECHBBIPIFM<JHFICJGOLCJ<TData>, IDMJKCLDJLO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x50B41C0", Offset = "0x50B35C0", VA = "0x1850B41C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x48D6B10", Offset = "0x48D5F10", VA = "0x1848D6B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	private readonly HPAENFOLHFM<TGetDataArg, TData> DGDPNOACCCN;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xCE6E00", Offset = "0xCE6200", VA = "0x180CE6E00")]
	internal IOBMDNONMHF(HPAENFOLHFM<TGetDataArg, TData> BGLHIFBEGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x4A77FB0", Offset = "0x4A773B0", VA = "0x184A77FB0")]
	[AsyncStateMachine(typeof(IOBMDNONMHF<, >.MEPKKNEJPMC))]
	public Task<BECHBBIPIFM<JHFICJGOLCJ<TData>, IDMJKCLDJLO>> KPOLDOJIDEG(TGetDataArg LICDMCPJILC, string CHNFKMBELFA, BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public static class DPDOFIOOAMC
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x34FC380", Offset = "0x34FB780", VA = "0x1834FC380")]
	public static IOBMDNONMHF<TGetDataArg, TData> FABCCGGAHMJ<TGetDataArg, TData>(HPAENFOLHFM<TGetDataArg, TData> BGLHIFBEGOD)
	{
		return default(IOBMDNONMHF<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public struct MODLJLMFBEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public readonly int HCLBKIGIGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public readonly int? NLAEALKMAGH;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x4E81040", Offset = "0x4E80440", VA = "0x184E81040")]
	public MODLJLMFBEE(int PEHFPIIENIB, [Optional] int? OHLFAELCCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x8309B70", Offset = "0x8308F70", VA = "0x188309B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface CKMKBOANCFH<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDGIEJGBHPJ();

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CKMKBOANCFH<T> KDJGEDEPFJF(string GDODLHCOCDP);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CKMKBOANCFH<T> IKONJAGIHGP(NKINOGEIIGG<T> FCIGMLECIDO);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CKMKBOANCFH<T> BCDINOBCBED(int HJPLLMGICPE);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CKMKBOANCFH<T> IIKPPECCCAC(int HJPLLMGICPE, PGPFPGCJEOD<T> GDKGABCGCHH);
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface JCINOMLBHPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CKMKBOANCFH<T> KDMJMGBEIAP<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DNIDKHCFNBG EGNMDOOAHLN(Exception CCEMNOMFFKG);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MODLJLMFBEE KJIBLFHFDIG(Exception CCEMNOMFFKG);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public delegate string NKINOGEIIGG<in T>(T CCEMNOMFFKG) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public delegate int PGPFPGCJEOD<in T>(T CCEMNOMFFKG) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class KGEDHNBOGKF : JCINOMLBHPJ
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private delegate string OEBDMFJBECL(Exception CCEMNOMFFKG);

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private delegate int HFIGGEMBLFL(Exception CCEMNOMFFKG);

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class BDGOPDGCMOL<T> : CKMKBOANCFH<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		[CompilerGenerated]
		private sealed class LKGEGCCBEKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public LKGEGCCBEKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
			internal string FGIOJGLKLFO(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000100")]
		[CompilerGenerated]
		private sealed class OHGFOMGHIOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public NKINOGEIIGG<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public OHGFOMGHIOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x43AB140", Offset = "0x43AA540", VA = "0x1843AB140")]
			internal string GKKFBBJBDCA(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class EJGBJKLOELL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public PGPFPGCJEOD<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public EJGBJKLOELL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x43AB140", Offset = "0x43AA540", VA = "0x1843AB140")]
			internal int IMGOKEOEBLG(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private readonly KGEDHNBOGKF JGBKDONAMOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private readonly Type POGNFAGOOEG;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D060", Offset = "0x5E9C460", VA = "0x185E9D060")]
		internal BDGOPDGCMOL(KGEDHNBOGKF JGBKDONAMOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CCB0", Offset = "0x5E9C0B0", VA = "0x185E9CCB0", Slot = "4")]
		public void EDGIEJGBHPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CF40", Offset = "0x5E9C340", VA = "0x185E9CF40", Slot = "5")]
		public CKMKBOANCFH<T> KDJGEDEPFJF(string GDODLHCOCDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CE20", Offset = "0x5E9C220", VA = "0x185E9CE20", Slot = "6")]
		public CKMKBOANCFH<T> IKONJAGIHGP(NKINOGEIIGG<T> FCIGMLECIDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CC70", Offset = "0x5E9C070", VA = "0x185E9CC70", Slot = "7")]
		public CKMKBOANCFH<T> BCDINOBCBED(int HJPLLMGICPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CCE0", Offset = "0x5E9C0E0", VA = "0x185E9CCE0", Slot = "8")]
		public CKMKBOANCFH<T> IIKPPECCCAC(int HJPLLMGICPE, PGPFPGCJEOD<T> GDKGABCGCHH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class FBGMBKNPHMD<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private bool KPLODJKCBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly List<Type> GLECAFLONHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly Dictionary<Type, TVal> JAAPAEIJGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly Dictionary<Type, int> KHPOCGHAPFP;

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public IReadOnlyList<Type> OAGHJGPAAFK
		{
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x47C8830", Offset = "0x47C7C30", VA = "0x1847C8830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x47C89B0", Offset = "0x47C7DB0", VA = "0x1847C89B0")]
		public FBGMBKNPHMD(Dictionary<Type, int> KHPOCGHAPFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x47C85D0", Offset = "0x47C79D0", VA = "0x1847C85D0")]
		public void FGAAHPGCDNG(Type IICGAABOENK, TVal DBALGCNBEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x47C8450", Offset = "0x47C7850", VA = "0x1847C8450")]
		public bool AIOLGCKLHOM(Type POGNFAGOOEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x47C87D0", Offset = "0x47C7BD0", VA = "0x1847C87D0")]
		public bool GCHCFBPMOIA(TVal OOEMJLHLIHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x47C84B0", Offset = "0x47C78B0", VA = "0x1847C84B0")]
		public TVal DANLDNLMJMK(Type KHNCICOHHHJ)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x47C8690", Offset = "0x47C7A90", VA = "0x1847C8690")]
		[CompilerGenerated]
		private int FIOFENONCBB(Type OGCDLKLBILC, Type JKJEAOPAFGL)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class NPEIMIGIIJJ : IEnumerable<MODLJLMFBEE>, IEnumerable, IEnumerator<MODLJLMFBEE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private MODLJLMFBEE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public KGEDHNBOGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private IEnumerator<MODLJLMFBEE> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		private MODLJLMFBEE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x441D840", Offset = "0x441CC40", VA = "0x18441D840", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MODLJLMFBEE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x830B530", Offset = "0x830A930", VA = "0x18830B530", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xE69660", Offset = "0xE68A60", VA = "0x180E69660")]
		[DebuggerHidden]
		public NPEIMIGIIJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x830B580", Offset = "0x830A980", VA = "0x18830B580", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x830AF70", Offset = "0x830A370", VA = "0x18830AF70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x830AED0", Offset = "0x830A2D0", VA = "0x18830AED0")]
		private void BIIMICBPMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x830AF20", Offset = "0x830A320", VA = "0x18830AF20")]
		private void LNCBGHLOKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x830B4E0", Offset = "0x830A8E0", VA = "0x18830B4E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x830B420", Offset = "0x830A820", VA = "0x18830B420", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MODLJLMFBEE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x830B420", Offset = "0x830A820", VA = "0x18830B420", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private static readonly MODLJLMFBEE HPFCEAOCGBC;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private static readonly Dictionary<Type, int> DEPJNAAOGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly HashSet<Type> PBJOBJMCMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private readonly FBGMBKNPHMD<int> OHEGKDFMMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private readonly FBGMBKNPHMD<HFIGGEMBLFL> BIEPFEHAHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly FBGMBKNPHMD<OEBDMFJBECL> PPFJJADGKNE;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x8306B80", Offset = "0x8305F80", VA = "0x188306B80")]
	[ACPGCKDGGJH.EHOIKNIBKMA.DOIDFDFNIIB]
	internal static void BIBAMGIFFDO(NPCGGDCACLM MIOIJELPIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x8307F80", Offset = "0x8307380", VA = "0x188307F80")]
	[RecRoom.NoEngine.Common.Preserve]
	public KGEDHNBOGKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x353FEB0", Offset = "0x353F2B0", VA = "0x18353FEB0", Slot = "4")]
	public CKMKBOANCFH<T> KDMJMGBEIAP<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x8306CD0", Offset = "0x83060D0", VA = "0x188306CD0", Slot = "5")]
	public DNIDKHCFNBG EGNMDOOAHLN(Exception CCEMNOMFFKG)
	{
		return default(DNIDKHCFNBG);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x83071D0", Offset = "0x83065D0", VA = "0x1883071D0", Slot = "6")]
	public MODLJLMFBEE KJIBLFHFDIG(Exception? CCEMNOMFFKG)
	{
		return default(MODLJLMFBEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x8306EE0", Offset = "0x83062E0", VA = "0x188306EE0", Slot = "7")]
	[IteratorStateMachine(typeof(NPEIMIGIIJJ))]
	public IEnumerable<MODLJLMFBEE> IGFJKABNALJ(Exception CCEMNOMFFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x8307A90", Offset = "0x8306E90", VA = "0x188307A90", Slot = "8")]
	public string OACBCPLHBEF(Exception? CCEMNOMFFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x8307780", Offset = "0x8306B80", VA = "0x188307780")]
	private string NNOCCOFLGDL(AggregateException OKKHOECLAND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x83073D0", Offset = "0x83067D0", VA = "0x1883073D0")]
	private void MBDCDIIOCLN(Type POGNFAGOOEG, int HJPLLMGICPE, HFIGGEMBLFL? KHAHDACNPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x8306F80", Offset = "0x8306380", VA = "0x188306F80")]
	private void KCKJAIGIEPF(Type POGNFAGOOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x8307BE0", Offset = "0x8306FE0", VA = "0x188307BE0")]
	private void PELEIENJKKA(Type POGNFAGOOEG, OEBDMFJBECL LINIKHDCDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x8306D60", Offset = "0x8306160", VA = "0x188306D60")]
	private static int FDCMDHHNLGL(Type POGNFAGOOEG, Dictionary<Type, int> KHPOCGHAPFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x3785C00", Offset = "0x3785000", VA = "0x183785C00")]
	private static bool AIPJPDGBFGI<TVal>(FBGMBKNPHMD<TVal> LMNAOMMMDJP, Type POGNFAGOOEG, [Out] TVal OOEMJLHLIHJ) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x8306BF0", Offset = "0x8305FF0", VA = "0x188306BF0")]
	[CompilerGenerated]
	internal static int DBEJGIHFKPN(Type MJDIAGNBGIO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public struct DNIDKHCFNBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public readonly MODLJLMFBEE FOLHDFACNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public readonly string KBMPPDAAIEM;

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x82F9040", Offset = "0x82F8440", VA = "0x1882F9040")]
	public DNIDKHCFNBG(string HJMIMNONOEA, MODLJLMFBEE HJPLLMGICPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x82F8FA0", Offset = "0x82F83A0", VA = "0x1882F8FA0")]
	public string KJEMDBNOOIM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class EALPINOJEEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	private readonly LNDDKGGFANB GLGCGHGKHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	private string AEPNBGKANGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	private long? CAMGLIBGEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	private long? IFKIBBOBLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	private long? CMMCADOFMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private string PEJDMPJIPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	private ACEACLGOILG KLCHIELCHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private long? CDMKFKJHMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private bool PODPJCNALID;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public string DHLADGJOHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public long LMCPLFGPFCA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x82F9A10", Offset = "0x82F8E10", VA = "0x1882F9A10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public long DFKOLJJMJFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x82FA040", Offset = "0x82F9440", VA = "0x1882FA040")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public long NDMCLNNBHIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x82FA1D0", Offset = "0x82F95D0", VA = "0x1882FA1D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public string OEDLOOABCIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x82FA0A0", Offset = "0x82F94A0", VA = "0x1882FA0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public ACEACLGOILG ELNLLGONPJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xD37CA0", Offset = "0xD370A0", VA = "0x180D37CA0")]
		get
		{
			return default(ACEACLGOILG);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x82FA0E0", Offset = "0x82F94E0", VA = "0x1882FA0E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public long JFHFAOIJLNE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x82F9910", Offset = "0x82F8D10", VA = "0x1882F9910")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x82FA740", Offset = "0x82F9B40", VA = "0x1882FA740")]
	[UnityEngine.Scripting.Preserve]
	public EALPINOJEEF([MGCCDFKFGBG(null)] LNDDKGGFANB GLGCGHGKHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x82F9A70", Offset = "0x82F8E70", VA = "0x1882F9A70")]
	private void HAHNAFHFEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x82FA230", Offset = "0x82F9630", VA = "0x1882FA230")]
	public void MADCOKNAKCC(long NFMLPECGLEO, long AKJILJJKOFL, [Optional] long? DHKHJPCIEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x82F9970", Offset = "0x82F8D70", VA = "0x1882F9970")]
	public void ENKGBGNPALO(long DHKHJPCIEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x82FA6C0", Offset = "0x82F9AC0", VA = "0x1882FA6C0")]
	public void NMHAELMALAB(string PPLGMFFJCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x82F9CC0", Offset = "0x82F90C0", VA = "0x1882F9CC0")]
	public void ILMCCFIOKKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal class EKCMCCJKLGK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct JMFMDKGLAIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public AsyncTaskMethodBuilder<HOGPILOHPJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public HOGPILOHPJM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public EKCMCCJKLGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private TaskAwaiter<AMEIOOCAHKO.ICLEBOPJFPO<HOGPILOHPJM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x8304810", Offset = "0x8303C10", VA = "0x188304810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x8304D50", Offset = "0x8304150", VA = "0x188304D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct KOGBHABKJKH<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private sealed class HJPEKIBEBNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public HOGPILOHPJM roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public HJPEKIBEBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x8301C90", Offset = "0x8301090", VA = "0x188301C90")]
		internal HOGPILOHPJM HONNGDNGFBE(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct GJJPBFFNOAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public AsyncTaskMethodBuilder<AMEIOOCAHKO.ICLEBOPJFPO<HOGPILOHPJM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public HOGPILOHPJM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public EKCMCCJKLGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private ECFIOHOLLBH <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private TaskAwaiter<AMEIOOCAHKO.ICLEBOPJFPO<HOGPILOHPJM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x8300640", Offset = "0x82FFA40", VA = "0x188300640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x8300C50", Offset = "0x8300050", VA = "0x188300C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct PBOFNLBLCPE<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public EKCMCCJKLGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x54773D0", Offset = "0x54767D0", VA = "0x1854773D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x48D6B10", Offset = "0x48D5F10", VA = "0x1848D6B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct EMMDJHDFGFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public EKCMCCJKLGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x82FE190", Offset = "0x82FD590", VA = "0x1882FE190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x82FE470", Offset = "0x82FD870", VA = "0x1882FE470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private sealed class HPPIMPAMOKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public HPPIMPAMOKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x8301E30", Offset = "0x8301230", VA = "0x188301E30")]
		internal object JACHMKHDFIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x8301D70", Offset = "0x8301170", VA = "0x188301D70")]
		internal bool GEJJJBCKANK(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class KNPPCMBAMPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public KNPPCMBAMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x8308C10", Offset = "0x8308010", VA = "0x188308C10")]
		internal object IPEKEKDFAMM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class BLKLPPGAKLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BLKLPPGAKLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x82F6990", Offset = "0x82F5D90", VA = "0x1882F6990")]
		internal object POAPNPGDBIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class PJJHBMLAKPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public PJJHBMLAKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x830E570", Offset = "0x830D970", VA = "0x18830E570")]
		internal object GKBEIADNBPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class COHNKIMNGAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public EKCMCCJKLGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public COHNKIMNGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x82F8400", Offset = "0x82F7800", VA = "0x1882F8400")]
		internal object KKKOLAIEHPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private static readonly Guid BJKDOJKHAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public readonly PJCDBCNMOMI DKDCOFMBBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly AMEIOOCAHKO FKCLIOCJDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly EKHANEOMCNI MFHPJCBDCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private readonly OHBLDCHHCFA IFJCJNKKBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private bool FCLGNOIALPN;

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x82FD930", Offset = "0x82FCD30", VA = "0x1882FD930")]
	public EKCMCCJKLGK(PJCDBCNMOMI LLGAMDBNNCE, AMEIOOCAHKO FKCLIOCJDDI, EKHANEOMCNI MFHPJCBDCMN, OHBLDCHHCFA IFJCJNKKBEB, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x82FC960", Offset = "0x82FBD60", VA = "0x1882FC960", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x82FC840", Offset = "0x82FBC40", VA = "0x1882FC840")]
	public void DNAEBFPOHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x82FCF10", Offset = "0x82FC310", VA = "0x1882FCF10")]
	public void IIEPNLNHIMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x82FCBE0", Offset = "0x82FBFE0", VA = "0x1882FCBE0")]
	public void IBLEFJJAICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x82FD5E0", Offset = "0x82FC9E0", VA = "0x1882FD5E0")]
	[AsyncStateMachine(typeof(JMFMDKGLAIP))]
	internal Task<HOGPILOHPJM> PLDMGPJCOIM(BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, HOGPILOHPJM MFKNAHPEKFH, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x353C5C0", Offset = "0x353B9C0", VA = "0x18353C5C0")]
	private static byte[] GAHAOOOLIJO<T>(T FGEBHLNNMNH) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x353C5D0", Offset = "0x353B9D0", VA = "0x18353C5D0")]
	private static T ILHOPDFJABB<T>(MessageParser<T> HFHNCHPMOKI, byte[] FGEBHLNNMNH, T FLPHAKFDHID) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x82FD050", Offset = "0x82FC450", VA = "0x1882FD050")]
	[AsyncStateMachine(typeof(GJJPBFFNOAD))]
	private Task<AMEIOOCAHKO.ICLEBOPJFPO<HOGPILOHPJM>> KFLMFMOPBEC(HOGPILOHPJM MFKNAHPEKFH, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x353C9D0", Offset = "0x353BDD0", VA = "0x18353C9D0")]
	[AsyncStateMachine(typeof(PBOFNLBLCPE<>))]
	internal Task<T> LGKKBEJMDBL<T>(CancellationToken EKBICDMGFBA, Func<CancellationToken, Task<T>> IINBPOCOKMM, int AAMNMFGGGJG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x82FD430", Offset = "0x82FC830", VA = "0x1882FD430")]
	[AsyncStateMachine(typeof(EMMDJHDFGFC))]
	internal Task LGKKBEJMDBL(CancellationToken EKBICDMGFBA, Func<CancellationToken, Task> IINBPOCOKMM, int AAMNMFGGGJG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x82FD560", Offset = "0x82FC960", VA = "0x1882FD560")]
	public GPDPAGDFEGM NNEHPBPDIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x82FCFD0", Offset = "0x82FC3D0", VA = "0x1882FCFD0")]
	public EHJGAICEDAO IKAAFLJKKGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x82FCCA0", Offset = "0x82FC0A0", VA = "0x1882FCCA0")]
	public DDELOLOMNAN IENFGMIMCHO([Optional] LMKAPNBAFDO? KIBGFJNEFGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x82FD190", Offset = "0x82FC590", VA = "0x1882FD190")]
	public void KGCOPBAEONC(Func<Guid, bool> MBNHHMGCBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x82FCAD0", Offset = "0x82FBED0", VA = "0x1882FCAD0")]
	public void HDELBBJIPNP(Func<Guid, bool> DEENNNHIHBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x82FD740", Offset = "0x82FCB40", VA = "0x1882FD740")]
	public Guid PPAODIIJFKP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x82FC9C0", Offset = "0x82FBDC0", VA = "0x1882FC9C0")]
	public void GJPGKJGAKII(Guid JLONKJFLENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x82FD2F0", Offset = "0x82FC6F0", VA = "0x1882FD2F0")]
	public void LCECOBIFLLJ(HOGPILOHPJM FAKILBFNFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x82FC730", Offset = "0x82FBB30", VA = "0x1882FC730")]
	public void BKFDGJHNENK(string OCPMBLEKPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x353C4D0", Offset = "0x353B8D0", VA = "0x18353C4D0")]
	private T FHJJIEFAMEJ<T>(T OOEMJLHLIHJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x82FC970", Offset = "0x82FBD70", VA = "0x1882FC970")]
	public void FOIIMAMBDFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x353C720", Offset = "0x353BB20", VA = "0x18353C720")]
	[CompilerGenerated]
	internal static string JJPIBJJPGBP<T>(byte[] FLIFCMNPFIN, int CMOFODPGFML, KOGBHABKJKH<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal sealed class KMMHDDKGKNC : PJCDBCNMOMI
{
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class BLCKDMFCDBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BLCKDMFCDBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x82F6920", Offset = "0x82F5D20", VA = "0x1882F6920")]
		internal object DHCBMCCGFFN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct OJCNAMPLJFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public KMMHDDKGKNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public EKCMCCJKLGK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private HCOCEGBHFMI <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private EHJGAICEDAO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x830BC40", Offset = "0x830B040", VA = "0x18830BC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x830C590", Offset = "0x830B990", VA = "0x18830C590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct INNOOPNCAMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public KMMHDDKGKNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private TaskAwaiter<HNAJHGJKLNP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x8302FD0", Offset = "0x83023D0", VA = "0x188302FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x8303710", Offset = "0x8302B10", VA = "0x188303710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct ADAGMIALOKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public KMMHDDKGKNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter<MJKAJBCBAGM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x82F3D90", Offset = "0x82F3190", VA = "0x1882F3D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x82F40A0", Offset = "0x82F34A0", VA = "0x1882F40A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private sealed class GCFGAMBBNHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public HCOCEGBHFMI presence;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public GCFGAMBBNHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x82FFFE0", Offset = "0x82FF3E0", VA = "0x1882FFFE0")]
		internal object HMGMNJFKBHH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private static readonly LMKAPNBAFDO PLBIGHLHFHJ;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private static readonly LMKAPNBAFDO EOBGHGLJOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private readonly JKNOMNBJNEB BMNMEDOPAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	private readonly ECGOJJLBFIL GMJPKCAACCM;

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x8308A80", Offset = "0x8307E80", VA = "0x188308A80")]
	public KMMHDDKGKNC(JKNOMNBJNEB BMNMEDOPAEL, ECGOJJLBFIL GMJPKCAACCM, Guid IAFOFMFFKIO, LHLFHJJLIPN CNCGLFBHFNK, LJOHHGILGBC GAJCAOPJOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x8308860", Offset = "0x8307C60", VA = "0x188308860", Slot = "7")]
	[AsyncStateMachine(typeof(OJCNAMPLJFA))]
	protected override Task PEIOCAIOOCL(EKCMCCJKLGK MIFPAPEJAIK, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x8308650", Offset = "0x8307A50", VA = "0x188308650")]
	[AsyncStateMachine(typeof(INNOOPNCAMI))]
	private Task OAOHDCDGMJE(CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x8308750", Offset = "0x8307B50", VA = "0x188308750")]
	[AsyncStateMachine(typeof(ADAGMIALOKP))]
	private Task<int> OCBMMLCCJIK(CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x8308470", Offset = "0x8307870", VA = "0x188308470")]
	private HCOCEGBHFMI LMAKIFIBMAP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class DLLPDBGKFBJ : PJCDBCNMOMI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct PEAEAGEKCDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public DLLPDBGKFBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public EKCMCCJKLGK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private TaskAwaiter<EAOAOGAEAGM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x830CEA0", Offset = "0x830C2A0", VA = "0x18830CEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x830D850", Offset = "0x830CC50", VA = "0x18830D850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private readonly int AKFFEBFOLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private readonly OKAHFFFFHHK BPEIEPPOFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public readonly long OOPNDDKBIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public readonly long DPDBHLGBPGP;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public EAOAOGAEAGM HFKDDBCBHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x9D5C70", Offset = "0x9D5070", VA = "0x1809D5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x9D5C20", Offset = "0x9D5020", VA = "0x1809D5C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x82F8E70", Offset = "0x82F8270", VA = "0x1882F8E70")]
	public DLLPDBGKFBJ(Guid IAFOFMFFKIO, LHLFHJJLIPN CNCGLFBHFNK, LJOHHGILGBC GAJCAOPJOLM, int AKFFEBFOLFP, OKAHFFFFHHK BPEIEPPOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x82F8D50", Offset = "0x82F8150", VA = "0x1882F8D50", Slot = "7")]
	[AsyncStateMachine(typeof(PEAEAGEKCDH))]
	protected override Task PEIOCAIOOCL(EKCMCCJKLGK MIFPAPEJAIK, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal abstract class JKKGFICGKGD : PJCDBCNMOMI
{
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class KFBDLAMDKOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public JKKGFICGKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public BACFOGGJNFO playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public KFBDLAMDKOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x8306540", Offset = "0x8305940", VA = "0x188306540")]
		internal Task LCCAJDKLIOH(BNJJFADPKOK<string>.EFJIBBJEOLP postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x83064B0", Offset = "0x83058B0", VA = "0x1883064B0")]
		internal object KCHNPNOPDGL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct MLBNPAOPDDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public JKKGFICGKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public EKCMCCJKLGK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private KFBDLAMDKOP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x83091F0", Offset = "0x83085F0", VA = "0x1883091F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x83099C0", Offset = "0x8308DC0", VA = "0x1883099C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private struct FKJLMOEAECB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public BACFOGGJNFO playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public JKKGFICGKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x82FF210", Offset = "0x82FE610", VA = "0x1882FF210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x82FF7C0", Offset = "0x82FEBC0", VA = "0x1882FF7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x83047C0", Offset = "0x8303BC0", VA = "0x1883047C0")]
	public JKKGFICGKGD(Guid IAFOFMFFKIO, LHLFHJJLIPN CNCGLFBHFNK, LJOHHGILGBC GAJCAOPJOLM, string LJHHAGONAHN, BJGBMLOIFEK LODIOJIJDAO, bool EIBMPGHOEHO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x8304680", Offset = "0x8303A80", VA = "0x188304680", Slot = "7")]
	[AsyncStateMachine(typeof(MLBNPAOPDDO))]
	protected override Task PEIOCAIOOCL(EKCMCCJKLGK MIFPAPEJAIK, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task KGLCCAPOACH(EKCMCCJKLGK MIFPAPEJAIK, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x8304540", Offset = "0x8303940", VA = "0x188304540")]
	[AsyncStateMachine(typeof(FKJLMOEAECB))]
	private Task GPDOPCPLIIJ(IDisposable LPCFHPOGEDE, BACFOGGJNFO GAJEPPCEDDI, BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
internal class BOENCLEFNGA : PJCDBCNMOMI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct PNHHPNKHLMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public BOENCLEFNGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public EKCMCCJKLGK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private TaskAwaiter<BNHNOHNOJEM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x830E5E0", Offset = "0x830D9E0", VA = "0x18830E5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x830EB70", Offset = "0x830DF70", VA = "0x18830EB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private readonly FOBHJDGLMCB CJFNFMAHILH;

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x82F6C00", Offset = "0x82F6000", VA = "0x1882F6C00")]
	public BOENCLEFNGA(Guid IAFOFMFFKIO, LHLFHJJLIPN CNCGLFBHFNK, LJOHHGILGBC GAJCAOPJOLM, FOBHJDGLMCB CJFNFMAHILH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x82F6A00", Offset = "0x82F5E00", VA = "0x1882F6A00", Slot = "6")]
	protected override string BEECCHCNLED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x82F6AE0", Offset = "0x82F5EE0", VA = "0x1882F6AE0", Slot = "7")]
	[AsyncStateMachine(typeof(PNHHPNKHLMK))]
	protected override Task PEIOCAIOOCL(EKCMCCJKLGK MIFPAPEJAIK, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal abstract class PJCDBCNMOMI : JOOCMKBCAMM
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	public delegate Task MLMIOHBADOP(BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class BDDDEOOODGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public PJCDBCNMOMI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BDDDEOOODGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x82F6770", Offset = "0x82F5B70", VA = "0x1882F6770")]
		internal Task OBCPHPCPBOE(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private sealed class KOPKGODEHDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public BDDDEOOODGK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public KOPKGODEHDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x8308C70", Offset = "0x8308070", VA = "0x188308C70")]
		internal object LNOIGLPDBGG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct ANGAOJBDPGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public PJCDBCNMOMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public Func<PJCDBCNMOMI, BNJJFADPKOK<string>.EFJIBBJEOLP, EKCMCCJKLGK> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private BDDDEOOODGK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private EKCMCCJKLGK <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private TaskAwaiter<HOGPILOHPJM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x82F4A40", Offset = "0x82F3E40", VA = "0x1882F4A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x82F5B90", Offset = "0x82F4F90", VA = "0x1882F5B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct FDPFHAODELB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x82FE710", Offset = "0x82FDB10", VA = "0x1882FE710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x82FF1B0", Offset = "0x82FE5B0", VA = "0x1882FF1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct FLPNIEMNOEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public PJCDBCNMOMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x82FFAE0", Offset = "0x82FEEE0", VA = "0x1882FFAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x82FFE40", Offset = "0x82FF240", VA = "0x1882FFE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public readonly Guid NBHBLNGHIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public readonly ByteString GLGAHJKEIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public readonly LJOHHGILGBC OBDEADNHFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	protected readonly string BIGCNBFIBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private readonly LHLFHJJLIPN CNCGLFBHFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	private readonly bool EIBMPGHOEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private readonly Queue<MLMIOHBADOP> BKOKMKDLIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private readonly DHAJBAACLNK IDIJJCBAHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private readonly BJGBMLOIFEK LODIOJIJDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private bool CBKJLLIHJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public ACEACLGOILG HCAGJINDMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public ACEACLGOILG CMBDPPLMJGF;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public LHLFHJJLIPN KFFMLJHDNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public LLKLGIOAOCK GHCAPJHEIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x830DC30", Offset = "0x830D030", VA = "0x18830DC30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public HKEHHDOFEDF PJOAPNBILMO
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x830E0D0", Offset = "0x830D4D0", VA = "0x18830E0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public EOFPDHAABFM OHFFLHAGGEM
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x830E050", Offset = "0x830D450", VA = "0x18830E050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event IIACEPHHMFF KJHJGNDJICK
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x830DC10", Offset = "0x830D010", VA = "0x18830DC10", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x830E2C0", Offset = "0x830D6C0", VA = "0x18830E2C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x830E410", Offset = "0x830D810", VA = "0x18830E410")]
	protected PJCDBCNMOMI(Guid IAFOFMFFKIO, LHLFHJJLIPN CNCGLFBHFNK, LJOHHGILGBC GAJCAOPJOLM, string LJHHAGONAHN, BJGBMLOIFEK LODIOJIJDAO, bool EIBMPGHOEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x830D9A0", Offset = "0x830CDA0", VA = "0x18830D9A0", Slot = "6")]
	protected virtual string BEECCHCNLED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x830DD20", Offset = "0x830D120", VA = "0x18830DD20")]
	public void HPMPFKDLKMB(MLMIOHBADOP GDILCIHIHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x830DC80", Offset = "0x830D080", VA = "0x18830DC80")]
	protected void FIFAHPCEOIG(float OHELNHAJILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x830DF00", Offset = "0x830D300", VA = "0x18830DF00")]
	[AsyncStateMachine(typeof(ANGAOJBDPGP))]
	public Task ILOIMMFJAMD(CancellationToken JDDHIJBJNHP, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, [Optional] Func<PJCDBCNMOMI, BNJJFADPKOK<string>.EFJIBBJEOLP, EKCMCCJKLGK> GJIJFCGJKHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x830E2E0", Offset = "0x830D6E0", VA = "0x18830E2E0")]
	[AsyncStateMachine(typeof(FDPFHAODELB))]
	private static Task OACNNCPGHHD(Func<CancellationToken, Task> MEIDNOIKONL, Func<CancellationToken, Task> GFLFFGKNGAH, CancellationToken EKBICDMGFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x830DD80", Offset = "0x830D180", VA = "0x18830DD80")]
	private void ILCAOFCBFEI(bool LCNFJJJGFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x830D9E0", Offset = "0x830CDE0", VA = "0x18830D9E0")]
	private void CDIIPOIENDP(EKCMCCJKLGK MIFPAPEJAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task PEIOCAIOOCL(EKCMCCJKLGK MIFPAPEJAIK, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x830E120", Offset = "0x830D520", VA = "0x18830E120")]
	[AsyncStateMachine(typeof(FLPNIEMNOEN))]
	private Task JLLDELIDFHB(BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x830DCA0", Offset = "0x830D0A0", VA = "0x18830DCA0")]
	public HOGPILOHPJM HGOKAFGHKJD(ECFIOHOLLBH NNAANLOGANA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x830D8B0", Offset = "0x830CCB0", VA = "0x18830D8B0")]
	[CompilerGenerated]
	private Task AKLAJLPMJBN(CancellationToken DEEHPBDAIHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x830E240", Offset = "0x830D640", VA = "0x18830E240")]
	[CompilerGenerated]
	private object MJPAECCIJHF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
internal sealed class IJIJFKFDBOO : JKKGFICGKGD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct GOMCHIGHPHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public IJIJFKFDBOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public EKCMCCJKLGK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private AFEHEDCGLIC <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private EHJGAICEDAO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x8300CC0", Offset = "0x83000C0", VA = "0x188300CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x8301430", Offset = "0x8300830", VA = "0x188301430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private readonly JKNOMNBJNEB IGFGIJADFKJ;

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x8302F20", Offset = "0x8302320", VA = "0x188302F20")]
	public IJIJFKFDBOO(Guid IAFOFMFFKIO, LHLFHJJLIPN CNCGLFBHFNK, JKNOMNBJNEB IGFGIJADFKJ, LJOHHGILGBC GAJCAOPJOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x8302DD0", Offset = "0x83021D0", VA = "0x188302DD0", Slot = "8")]
	[AsyncStateMachine(typeof(GOMCHIGHPHD))]
	protected override Task KGLCCAPOACH(EKCMCCJKLGK MIFPAPEJAIK, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal class GCMDHIPDMBL : PJCDBCNMOMI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct CGOFJFAOMGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public GCMDHIPDMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public EKCMCCJKLGK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private TaskAwaiter<BNHNOHNOJEM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x82F6EA0", Offset = "0x82F62A0", VA = "0x1882F6EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x82F7250", Offset = "0x82F6650", VA = "0x1882F7250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private readonly string DFOMMGLHOBN;

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x8300230", Offset = "0x82FF630", VA = "0x188300230")]
	public GCMDHIPDMBL(Guid IAFOFMFFKIO, LHLFHJJLIPN CNCGLFBHFNK, LJOHHGILGBC GAJCAOPJOLM, string DFOMMGLHOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x8300120", Offset = "0x82FF520", VA = "0x188300120", Slot = "7")]
	[AsyncStateMachine(typeof(CGOFJFAOMGM))]
	protected override Task PEIOCAIOOCL(EKCMCCJKLGK MIFPAPEJAIK, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal class ANLCLJJFEOD : JKKGFICGKGD
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class CLGENCFPEBH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000131")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public AsyncTaskMethodBuilder<HOGPILOHPJM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public CLGENCFPEBH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			private TaskAwaiter<BNHNOHNOJEM> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			private TaskAwaiter<HOGPILOHPJM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x830FB20", Offset = "0x830EF20", VA = "0x18830FB20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0x8310010", Offset = "0x830F410", VA = "0x188310010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public ANLCLJJFEOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public DDELOLOMNAN serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public PMJGODHIFMK roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public GPDPAGDFEGM uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public NBFKFCCDAMP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public CLGENCFPEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x82F72B0", Offset = "0x82F66B0", VA = "0x1882F72B0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<HOGPILOHPJM> GJBHCMDEIPA(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private struct IHFDNIJNCGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public ANLCLJJFEOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public EKCMCCJKLGK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private CLGENCFPEBH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private AFEHEDCGLIC <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private EHJGAICEDAO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private HOGPILOHPJM <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private TaskAwaiter<HOGPILOHPJM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x8301E90", Offset = "0x8301290", VA = "0x188301E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x8302D70", Offset = "0x8302170", VA = "0x188302D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private static readonly LMKAPNBAFDO PLBIGHLHFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private readonly int MBANJJBOKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	[CanBeNull]
	private readonly OOGIILPNHKC AFEEILJEPLN;

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x82F60B0", Offset = "0x82F54B0", VA = "0x1882F60B0")]
	public ANLCLJJFEOD(Guid IAFOFMFFKIO, LHLFHJJLIPN CNCGLFBHFNK, int MBANJJBOKOG, OOGIILPNHKC AFEEILJEPLN, LJOHHGILGBC GAJCAOPJOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x82F5DC0", Offset = "0x82F51C0", VA = "0x1882F5DC0", Slot = "8")]
	[AsyncStateMachine(typeof(IHFDNIJNCGD))]
	protected override Task KGLCCAPOACH(EKCMCCJKLGK MIFPAPEJAIK, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x82F5F00", Offset = "0x82F5300", VA = "0x1882F5F00")]
	private void PAKHDPIIBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x82F5BF0", Offset = "0x82F4FF0", VA = "0x1882F5BF0")]
	private void DIOMKGNHJAH(BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, AFEHEDCGLIC NOKOGAFLODM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal class CECMIPKLDKM : PJCDBCNMOMI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct KEACMMKBOND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public CECMIPKLDKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private AFEHEDCGLIC <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private PKCCCOBBKFK<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private TaskAwaiter<EAOAOGAEAGM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x8305310", Offset = "0x8304710", VA = "0x188305310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x8306450", Offset = "0x8305850", VA = "0x188306450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private readonly int MBANJJBOKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private readonly OOGIILPNHKC AFEEILJEPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private Func<BNHNOHNOJEM, BNHNOHNOJEM> HOPMAEGNHBN;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x82F6DE0", Offset = "0x82F61E0", VA = "0x1882F6DE0")]
	public CECMIPKLDKM(Guid IAFOFMFFKIO, LHLFHJJLIPN CNCGLFBHFNK, int MBANJJBOKOG, OOGIILPNHKC AFEEILJEPLN, Func<BNHNOHNOJEM, BNHNOHNOJEM> HOPMAEGNHBN, LJOHHGILGBC GAJCAOPJOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x82F6CA0", Offset = "0x82F60A0", VA = "0x1882F6CA0", Slot = "7")]
	[AsyncStateMachine(typeof(KEACMMKBOND))]
	protected override Task PEIOCAIOOCL(EKCMCCJKLGK MIFPAPEJAIK, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal abstract class HDCEMHIJFIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public readonly PJCDBCNMOMI DKDCOFMBBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public readonly EKCMCCJKLGK PDCKOENLBOI;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public LLKLGIOAOCK GHCAPJHEIJG
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x83015B0", Offset = "0x83009B0", VA = "0x1883015B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public EOFPDHAABFM OHFFLHAGGEM
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x8301600", Offset = "0x8300A00", VA = "0x188301600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x8301690", Offset = "0x8300A90", VA = "0x188301690")]
	protected HDCEMHIJFIC(EKCMCCJKLGK MIFPAPEJAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x8301490", Offset = "0x8300890", VA = "0x188301490")]
	protected void BKFDGJHNENK(string OCPMBLEKPIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct ANPJMKBHNCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public Dictionary<Guid, List<LMELJOKCJFH>> FMKNCFLJNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public Dictionary<Guid, List<LMELJOKCJFH>> LMNLGBEDKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public Dictionary<Guid, List<LMELJOKCJFH>> ENAIEJEGNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public List<Guid> OOOJCCHGMEK;

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x82F6160", Offset = "0x82F5560", VA = "0x1882F6160")]
	public static ANPJMKBHNCP DANLDNLMJMK(LLKLGIOAOCK HLIKBEKBJPB, ACEACLGOILG HDOIAGEHIGK, PMABFBOEKAG NCKEPNBEOKJ)
	{
		return default(ANPJMKBHNCP);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct NKLPADLMGFI
{
	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0")]
	public static NKLPADLMGFI BPKMLDCMEGB()
	{
		return default(NKLPADLMGFI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct KJLEKPJABLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public readonly HNAJHGJKLNP LBIMIKPLDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public readonly HABMELLNJLH AMHCBGDKHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public readonly Guid? CFEIEOEJEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public readonly IReadOnlyCollection<FKNKAHPIOKE> GLGLOHHDCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public readonly IReadOnlyCollection<FKNKAHPIOKE> KHGANELLIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public readonly GPEOIJBIPCA PBNEIBAJIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public readonly GPEOIJBIPCA JJMNDMDKNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public readonly JDNBODNOFNG KFOMBPOJBIE;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool FHGHBHOMODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x8308330", Offset = "0x8307730", VA = "0x188308330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x83083C0", Offset = "0x83077C0", VA = "0x1883083C0")]
	public KJLEKPJABLG(HNAJHGJKLNP LBIMIKPLDOP, HABMELLNJLH AMHCBGDKHJL, Guid? CFEIEOEJEOL, IReadOnlyList<FKNKAHPIOKE> GLGLOHHDCFP, IReadOnlyCollection<FKNKAHPIOKE> KHGANELLIAN, GPEOIJBIPCA PBNEIBAJIIG, GPEOIJBIPCA JJMNDMDKNDJ, JDNBODNOFNG KFOMBPOJBIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct MCBMMALNMAJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private readonly EKCMCCJKLGK MIFPAPEJAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private readonly Guid JLONKJFLENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private bool LCNFJJJGFFM;

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x8309020", Offset = "0x8308420", VA = "0x188309020")]
	public static MCBMMALNMAJ PPAODIIJFKP(EKCMCCJKLGK MIFPAPEJAIK)
	{
		return default(MCBMMALNMAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x111CD20", Offset = "0x111C120", VA = "0x18111CD20")]
	public void BBHCKKJKONH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x8308DD0", Offset = "0x83081D0", VA = "0x188308DD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x8309050", Offset = "0x8308450", VA = "0x188309050")]
	private MCBMMALNMAJ(EKCMCCJKLGK MIFPAPEJAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x8308DE0", Offset = "0x83081E0", VA = "0x188308DE0")]
	private void GJPGKJGAKII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x8308D30", Offset = "0x8308130", VA = "0x188308D30")]
	private Func<Guid, bool> CGKJDHLDBEM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal class EHJGAICEDAO : HDCEMHIJFIC, JOOCMKBCAMM
{
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	public delegate Task<ACEACLGOILG> JCIINNBIPMO(PMABFBOEKAG AOFGGGKINCN, CGIJHFBFBKP ANECABJGACC, DHAJBAACLNK FCENDNCDCMD, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct AIFJFLGHNNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public JKNOMNBJNEB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private MCBMMALNMAJ <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private TaskAwaiter<HOGPILOHPJM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x82F4110", Offset = "0x82F3510", VA = "0x1882F4110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x82F49E0", Offset = "0x82F3DE0", VA = "0x1882F49E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct PAAMLJCOPBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public AsyncTaskMethodBuilder<HOGPILOHPJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public JKNOMNBJNEB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private TaskAwaiter<HOGPILOHPJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x830C980", Offset = "0x830BD80", VA = "0x18830C980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x830CDB0", Offset = "0x830C1B0", VA = "0x18830CDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct DJIEGJNPPNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public JKNOMNBJNEB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x82F8650", Offset = "0x82F7A50", VA = "0x1882F8650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x82F8C90", Offset = "0x82F8090", VA = "0x1882F8C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class OGBEMINIHJF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000141")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public AsyncTaskMethodBuilder<KJLEKPJABLG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			public OGBEMINIHJF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			private KJLEKPJABLG <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			private TaskAwaiter<ACEACLGOILG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			private TaskAwaiter<KJLEKPJABLG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0x830EBD0", Offset = "0x830DFD0", VA = "0x18830EBD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x830F3C0", Offset = "0x830E7C0", VA = "0x18830F3C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000142")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004FC")]
			public AsyncTaskMethodBuilder<PMABFBOEKAG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			public OGBEMINIHJF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004FF")]
			private PMABFBOEKAG <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			private TaskAwaiter<ACEACLGOILG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			private TaskAwaiter<PMABFBOEKAG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x830F430", Offset = "0x830E830", VA = "0x18830F430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x830FAB0", Offset = "0x830EEB0", VA = "0x18830FAB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public JKNOMNBJNEB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public DHAJBAACLNK preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public DHAJBAACLNK downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public KJLEKPJABLG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public DHAJBAACLNK postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public PMABFBOEKAG phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public HCDGKADAPOC.CKFPKAEIJLL <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public OGBEMINIHJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x830B990", Offset = "0x830AD90", VA = "0x18830B990")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<KJLEKPJABLG> JNAJKMCNLFD(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x830B870", Offset = "0x830AC70", VA = "0x18830B870")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<PMABFBOEKAG> IFLLJFFCPGE(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x830B830", Offset = "0x830AC30", VA = "0x18830B830")]
		internal void EDJGAANEDCF(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x830B6D0", Offset = "0x830AAD0", VA = "0x18830B6D0")]
		internal Task CIPGBGBHGFF(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x830BAE0", Offset = "0x830AEE0", VA = "0x18830BAE0")]
		internal Task OCBBHPEEPBK(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct COCDKGNEAPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public JKNOMNBJNEB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private OGBEMINIHJF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private TaskAwaiter<KJLEKPJABLG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private TaskAwaiter<PMABFBOEKAG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x82F73D0", Offset = "0x82F67D0", VA = "0x1882F73D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x82F8140", Offset = "0x82F7540", VA = "0x1882F8140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct NGPFGGHICLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public PMABFBOEKAG phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public DHAJBAACLNK postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private TaskAwaiter<ACEACLGOILG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private CGIJHFBFBKP <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x8309D60", Offset = "0x8309160", VA = "0x188309D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x830AE70", Offset = "0x830A270", VA = "0x18830AE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct GDMABHOJEJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x83194A0", Offset = "0x83188A0", VA = "0x1883194A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x8319C80", Offset = "0x8319080", VA = "0x188319C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct AFCDNHAKPOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public DHAJBAACLNK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private TaskAwaiter<ACEACLGOILG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x8311F60", Offset = "0x8311360", VA = "0x188311F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x83127A0", Offset = "0x8311BA0", VA = "0x1883127A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct COGGHOKMMKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public AsyncTaskMethodBuilder<ACEACLGOILG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public DHAJBAACLNK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private TaskAwaiter<ACEACLGOILG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x8315C80", Offset = "0x8315080", VA = "0x188315C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8316C40", Offset = "0x8316040", VA = "0x188316C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct ABHDFGMDFHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public AsyncTaskMethodBuilder<ACEACLGOILG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public DHAJBAACLNK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public CGIJHFBFBKP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private TaskAwaiter<ACEACLGOILG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x8310DE0", Offset = "0x83101E0", VA = "0x188310DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x8311EF0", Offset = "0x83112F0", VA = "0x188311EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct HCLPFOALKOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public AsyncTaskMethodBuilder<ACEACLGOILG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public ACEACLGOILG operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public DHAJBAACLNK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public PMABFBOEKAG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private TaskAwaiter<ACEACLGOILG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x831C820", Offset = "0x831BC20", VA = "0x18831C820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x831CA70", Offset = "0x831BE70", VA = "0x18831CA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class IPAJAGALGHC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014C")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			public AsyncTaskMethodBuilder<ACEACLGOILG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public IPAJAGALGHC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			private FNIAOHCFFHK <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			private TaskAwaiter<ACEACLGOILG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x8328480", Offset = "0x8327880", VA = "0x188328480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x8328AB0", Offset = "0x8327EB0", VA = "0x188328AB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public DHAJBAACLNK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public JCIINNBIPMO masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public CGIJHFBFBKP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public ACEACLGOILG originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public IPAJAGALGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x831F840", Offset = "0x831EC40", VA = "0x18831F840")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<ACEACLGOILG> AKECNBKOIEH(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct CGOMBJMAECB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder<ACEACLGOILG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public DHAJBAACLNK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public JCIINNBIPMO masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public CGIJHFBFBKP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private TaskAwaiter<ACEACLGOILG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x83156F0", Offset = "0x8314AF0", VA = "0x1883156F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x8315C10", Offset = "0x8315010", VA = "0x188315C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct PPBHCCPGJOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public DHAJBAACLNK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private ACEACLGOILG <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private IEnumerator<ACEACLGOILG> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private TaskAwaiter<ACEACLGOILG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x8327380", Offset = "0x8326780", VA = "0x188327380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x83278E0", Offset = "0x8326CE0", VA = "0x1883278E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct DPOOGMOIBON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x8318920", Offset = "0x8317D20", VA = "0x188318920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x8318C10", Offset = "0x8318010", VA = "0x188318C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct MCBBHOBFFAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x8324230", Offset = "0x8323630", VA = "0x188324230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x8324460", Offset = "0x8323860", VA = "0x188324460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class FLAENOJJAAG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000152")]
		private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			public AsyncTaskMethodBuilder<ACEACLGOILG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			public FLAENOJJAAG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public PMABFBOEKAG data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public DHAJBAACLNK progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			private TaskAwaiter<ACEACLGOILG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			private TaskAwaiter<GKICOJJKFKN> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x8328B20", Offset = "0x8327F20", VA = "0x188328B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x83295F0", Offset = "0x83289F0", VA = "0x1883295F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public AJMGOIMEPGE mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public FLAENOJJAAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x8319200", Offset = "0x8318600", VA = "0x188319200")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<ACEACLGOILG> ALDENJHBFAI(PMABFBOEKAG data, CGIJHFBFBKP _, DHAJBAACLNK progressTracker, BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct GFBAJCMBKPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public PMABFBOEKAG phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public DHAJBAACLNK postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private FLAENOJJAAG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private CGIJHFBFBKP <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter<ACEACLGOILG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x831A900", Offset = "0x8319D00", VA = "0x18831A900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x831B7D0", Offset = "0x831ABD0", VA = "0x18831B7D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct CGCHIMHBFFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x8315290", Offset = "0x8314690", VA = "0x188315290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x8315690", Offset = "0x8314A90", VA = "0x188315690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct NEBJPDJJNJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public AsyncTaskMethodBuilder<ACEACLGOILG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public EHJGAICEDAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public DHAJBAACLNK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private TaskAwaiter<ACEACLGOILG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x8324590", Offset = "0x8323990", VA = "0x188324590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x8324BB0", Offset = "0x8323FB0", VA = "0x188324BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private readonly LIHEKALDDOB BKNEGJAHNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private readonly LIHEKALDDOB CGMBGAMEFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private readonly EALPINOJEEF IGNJCMAMHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private readonly KANFGHIBODB AJKGFOKCFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private readonly PKIEMPCKCJG NCNIOODOCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private ProfilerCounterValue<int> MBHDKBEHDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private readonly DMFFGJNNEKN CBKOOGFOIJF;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private LHLFHJJLIPN KFFMLJHDNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x82FC020", Offset = "0x82FB420", VA = "0x1882FC020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event IIACEPHHMFF KJHJGNDJICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x82FAD60", Offset = "0x82FA160", VA = "0x1882FAD60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x82FBAD0", Offset = "0x82FAED0", VA = "0x1882FBAD0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x82FC340", Offset = "0x82FB740", VA = "0x1882FC340")]
	public EHJGAICEDAO(EKCMCCJKLGK MIFPAPEJAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x82FA8D0", Offset = "0x82F9CD0", VA = "0x1882FA8D0")]
	[AsyncStateMachine(typeof(AIFJFLGHNNO))]
	public Task BIFFNBAFBDG(JKNOMNBJNEB LFFAIMMKIAM, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x82FB420", Offset = "0x82FA820", VA = "0x1882FB420")]
	[AsyncStateMachine(typeof(PAAMLJCOPBJ))]
	private Task<HOGPILOHPJM> JGKAIEBIALG(JKNOMNBJNEB LFFAIMMKIAM, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x82FB080", Offset = "0x82FA480", VA = "0x1882FB080")]
	[AsyncStateMachine(typeof(DJIEGJNPPNO))]
	private Task GMFLEADPMNK(JKNOMNBJNEB LFFAIMMKIAM, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x82FB5D0", Offset = "0x82FA9D0", VA = "0x1882FB5D0")]
	[AsyncStateMachine(typeof(COCDKGNEAPI))]
	private Task KOEHKIJBMLL(JKNOMNBJNEB LFFAIMMKIAM, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken BPIAKNAFGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x82FB710", Offset = "0x82FAB10", VA = "0x1882FB710")]
	[AsyncStateMachine(typeof(NGPFGGHICLA))]
	private Task LGGMAHHPJPO(PMABFBOEKAG EDAEICHHMGI, DHAJBAACLNK DNDJGNFHDIG, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken OAPPOOKANNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x82FB1E0", Offset = "0x82FA5E0", VA = "0x1882FB1E0")]
	[AsyncStateMachine(typeof(GDMABHOJEJA))]
	private Task HIHONBHFKIP(BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x82FBB40", Offset = "0x82FAF40", VA = "0x1882FBB40")]
	[AsyncStateMachine(typeof(AFCDNHAKPOC))]
	private Task NMPBDEBJPEH(PMABFBOEKAG AOFGGGKINCN, DHAJBAACLNK FCENDNCDCMD, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x82FBEC0", Offset = "0x82FB2C0", VA = "0x1882FBEC0")]
	[AsyncStateMachine(typeof(COGGHOKMMKB))]
	private Task<ACEACLGOILG> OGMCLFDIGLN(PMABFBOEKAG AOFGGGKINCN, CGIJHFBFBKP IJGDBGGPKBI, DHAJBAACLNK FCENDNCDCMD, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x82FC050", Offset = "0x82FB450", VA = "0x1882FC050")]
	[AsyncStateMachine(typeof(ABHDFGMDFHD))]
	private Task<ACEACLGOILG> PAFNINODJCC(PMABFBOEKAG AOFGGGKINCN, CGIJHFBFBKP IJGDBGGPKBI, DHAJBAACLNK FCENDNCDCMD, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x82FABE0", Offset = "0x82F9FE0", VA = "0x1882FABE0")]
	[AsyncStateMachine(typeof(HCLPFOALKOO))]
	private Task<ACEACLGOILG> DPIKANJKHIB(ACEACLGOILG HDOIAGEHIGK, PMABFBOEKAG NCKEPNBEOKJ, DHAJBAACLNK FCENDNCDCMD, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP, bool MMEHKBEDNOH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x82FBC90", Offset = "0x82FB090", VA = "0x1882FBC90")]
	private bool OBGMDDDEGNI(PMABFBOEKAG EDAEICHHMGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x82FAD80", Offset = "0x82FA180", VA = "0x1882FAD80")]
	[AsyncStateMachine(typeof(CGOMBJMAECB))]
	protected Task<ACEACLGOILG> FBPADMKNDEE(PMABFBOEKAG AOFGGGKINCN, CGIJHFBFBKP IJGDBGGPKBI, DHAJBAACLNK FCENDNCDCMD, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP, JCIINNBIPMO LALBPICJOAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x82FC1F0", Offset = "0x82FB5F0", VA = "0x1882FC1F0")]
	[AsyncStateMachine(typeof(PPBHCCPGJOD))]
	private Task PIGLLDFONFO(PMABFBOEKAG AOFGGGKINCN, DHAJBAACLNK FCENDNCDCMD, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x82FBA80", Offset = "0x82FAE80", VA = "0x1882FBA80")]
	private void MOMMKPEMDLK(ACEACLGOILG NIFEKMCNBIL, DHAJBAACLNK FCENDNCDCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x82FABA0", Offset = "0x82F9FA0", VA = "0x1882FABA0")]
	private void CJHPMDFNLAE(ACEACLGOILG OGAAHEPCMNF, [Out] ACEACLGOILG OOAIBONAECH, [Out] ACEACLGOILG JDJCACLAGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x82FAF50", Offset = "0x82FA350", VA = "0x1882FAF50")]
	private Task<KJLEKPJABLG> FNDIEOOEBMH(JKNOMNBJNEB LFFAIMMKIAM, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x82FAF10", Offset = "0x82FA310", VA = "0x1882FAF10")]
	private Task<PMABFBOEKAG> FJEBCGJMAAH(KJLEKPJABLG AOFGGGKINCN, HCDGKADAPOC.CKFPKAEIJLL OPHFIDCCGMO, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x82FA780", Offset = "0x82F9B80", VA = "0x1882FA780")]
	[AsyncStateMachine(typeof(DPOOGMOIBON))]
	private Task AFDMAPKIGCD(PMABFBOEKAG AOFGGGKINCN, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP, bool IGDMACDKKDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x82FAF90", Offset = "0x82FA390", VA = "0x1882FAF90")]
	[AsyncStateMachine(typeof(MCBBHOBFFAF))]
	private Task GEKLMAKAPDG(PMABFBOEKAG AOFGGGKINCN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x82FB5A0", Offset = "0x82FA9A0", VA = "0x1882FB5A0")]
	private Task KMBCFLECNDM(PMABFBOEKAG AOFGGGKINCN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x82FC1D0", Offset = "0x82FB5D0", VA = "0x1882FC1D0")]
	private Task PIDPGNMGCGN(PMABFBOEKAG AOFGGGKINCN, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x82FB1C0", Offset = "0x82FA5C0", VA = "0x1882FB1C0")]
	private Task GNEHNOPAIMI(PMABFBOEKAG AOFGGGKINCN, CGIJHFBFBKP IJGDBGGPKBI, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x82FB9B0", Offset = "0x82FADB0", VA = "0x1882FB9B0")]
	private Task MJCFJAHCKCP(PMABFBOEKAG AOFGGGKINCN, CGIJHFBFBKP IJGDBGGPKBI, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x82FB2F0", Offset = "0x82FA6F0", VA = "0x1882FB2F0")]
	private static Task HMFICDLMOFN(CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x82FB580", Offset = "0x82FA980", VA = "0x1882FB580")]
	private Task JMHOJGJBPNE(PMABFBOEKAG AOFGGGKINCN, CGIJHFBFBKP IJGDBGGPKBI, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x82FAA20", Offset = "0x82F9E20", VA = "0x1882FAA20")]
	private Task CDCMOLJOPHB(PMABFBOEKAG AOFGGGKINCN, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x82FBAF0", Offset = "0x82FAEF0", VA = "0x1882FBAF0")]
	private void NGFOFIJCKJK(JKNOMNBJNEB LFFAIMMKIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x82FB9D0", Offset = "0x82FADD0", VA = "0x1882FB9D0")]
	public void MOKAHEBKJGD(long DHKHJPCIEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	private static void HDCHEEPJCFH(HNAJHGJKLNP LBIMIKPLDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x82FB860", Offset = "0x82FAC60", VA = "0x1882FB860")]
	[AsyncStateMachine(typeof(GFBAJCMBKPL))]
	private Task LGNGPGHCLFK(PMABFBOEKAG EDAEICHHMGI, DHAJBAACLNK DNDJGNFHDIG, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken OAPPOOKANNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x82FBD80", Offset = "0x82FB180", VA = "0x1882FBD80")]
	[AsyncStateMachine(typeof(CGCHIMHBFFK))]
	private Task OCAHPILAPKO(PMABFBOEKAG AOFGGGKINCN, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x82FB300", Offset = "0x82FA700", VA = "0x1882FB300")]
	private static DLLNGCAHPJF IKFNDELMHIN(PMABFBOEKAG NCKEPNBEOKJ)
	{
		return default(DLLNGCAHPJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x82FAA40", Offset = "0x82F9E40", VA = "0x1882FAA40")]
	[AsyncStateMachine(typeof(NEBJPDJJNJI))]
	private Task<ACEACLGOILG> CIFGJPIIBDM(PMABFBOEKAG AOFGGGKINCN, CGIJHFBFBKP IJGDBGGPKBI, DHAJBAACLNK FCENDNCDCMD, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	private void FAJLIEKBHJB(ACEACLGOILG GEJDKNIGANE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct GPGJJCBJFAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	private LHLFHJJLIPN CNCGLFBHFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	private PMABFBOEKAG AOFGGGKINCN;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private LLKLGIOAOCK GHCAPJHEIJG
	{
		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x831BFF0", Offset = "0x831B3F0", VA = "0x18831BFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x831C040", Offset = "0x831B440", VA = "0x18831C040")]
	public static Task ILOIMMFJAMD(LHLFHJJLIPN CNCGLFBHFNK, PMABFBOEKAG AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x831C120", Offset = "0x831B520", VA = "0x18831C120")]
	private void ILOIMMFJAMD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct BIGKMDJMJKO
{
	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x8313610", Offset = "0x8312A10", VA = "0x188313610")]
	public static Task ILOIMMFJAMD(CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct FPMHHEBJKOJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct EEELKMJAMPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public EKCMCCJKLGK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x8318C70", Offset = "0x8318070", VA = "0x188318C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x83191A0", Offset = "0x83185A0", VA = "0x1883191A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x8319360", Offset = "0x8318760", VA = "0x188319360")]
	[AsyncStateMachine(typeof(EEELKMJAMPC))]
	public static Task ILOIMMFJAMD(EKCMCCJKLGK MIFPAPEJAIK, PMABFBOEKAG AOFGGGKINCN, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct LACEBMKJCDE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct BJDGECKACOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public EKCMCCJKLGK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public CGIJHFBFBKP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private LHLFHJJLIPN <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private LLKLGIOAOCK <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private ACEACLGOILG <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private FNIAOHCFFHK <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private List<(PersistenceView, IBDHKNDIHNK)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private IBDHKNDIHNK <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x83136F0", Offset = "0x8312AF0", VA = "0x1883136F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x83143D0", Offset = "0x83137D0", VA = "0x1883143D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x8322A50", Offset = "0x8321E50", VA = "0x188322A50")]
	[AsyncStateMachine(typeof(BJDGECKACOP))]
	public static Task ILOIMMFJAMD(EKCMCCJKLGK MIFPAPEJAIK, PMABFBOEKAG AOFGGGKINCN, CGIJHFBFBKP IJGDBGGPKBI, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x8322BA0", Offset = "0x8321FA0", VA = "0x188322BA0")]
	private static void KKABKKCJCEM(PersistenceView KNHIPANAKJG, IBDHKNDIHNK GEBIOONDCDF, PMABFBOEKAG AOFGGGKINCN, ACEACLGOILG HDOIAGEHIGK, bool EEOIMMODCNC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct OHHFGCBCKIK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct JFDGHHPDEBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public LHLFHJJLIPN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private FNIAOHCFFHK <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x8320890", Offset = "0x831FC90", VA = "0x188320890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x8320EB0", Offset = "0x83202B0", VA = "0x188320EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x8325BB0", Offset = "0x8324FB0", VA = "0x188325BB0")]
	[AsyncStateMachine(typeof(JFDGHHPDEBA))]
	public static Task ILOIMMFJAMD(LHLFHJJLIPN CNCGLFBHFNK, PMABFBOEKAG AOFGGGKINCN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal struct GELEEMMPMBK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct KPBENGBMLPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public LHLFHJJLIPN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public EKCMCCJKLGK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x83227E0", Offset = "0x8321BE0", VA = "0x1883227E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x83229F0", Offset = "0x8321DF0", VA = "0x1883229F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class PPIOMEOHEOE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000162")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005D6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			public BNJJFADPKOK<string>.EFJIBBJEOLP timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			public PPIOMEOHEOE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x8329980", Offset = "0x8328D80", VA = "0x188329980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x8329D10", Offset = "0x8329110", VA = "0x188329D10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public PPIOMEOHEOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x8327940", Offset = "0x8326D40", VA = "0x188327940")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task LHLAPJDCBBK(BNJJFADPKOK<string>.EFJIBBJEOLP timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct LBIPLGJJEMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public GELEEMMPMBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private FNIAOHCFFHK <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private TaskAwaiter<HOGPILOHPJM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x8322E90", Offset = "0x8322290", VA = "0x188322E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x8323AA0", Offset = "0x8322EA0", VA = "0x188323AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class AILKGPECCGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public KFOIBDNOLMJ version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AILKGPECCGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x8312800", Offset = "0x8311C00", VA = "0x188312800")]
		internal object MNMOOICCDBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x83128E0", Offset = "0x8311CE0", VA = "0x1883128E0")]
		internal object PHBABFJKIPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private LHLFHJJLIPN CNCGLFBHFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private PMABFBOEKAG AOFGGGKINCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private EKCMCCJKLGK MIFPAPEJAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private bool IGDMACDKKDO;

	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private static readonly ByteString PPBDBGEHADC;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private LLKLGIOAOCK GHCAPJHEIJG
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x8319CE0", Offset = "0x83190E0", VA = "0x188319CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private EOFPDHAABFM OHFFLHAGGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x831A790", Offset = "0x8319B90", VA = "0x18831A790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x831A510", Offset = "0x8319910", VA = "0x18831A510")]
	[AsyncStateMachine(typeof(KPBENGBMLPH))]
	public static Task ILOIMMFJAMD(LHLFHJJLIPN CNCGLFBHFNK, PMABFBOEKAG AOFGGGKINCN, EKCMCCJKLGK MIFPAPEJAIK, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP, bool IGDMACDKKDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x831A660", Offset = "0x8319A60", VA = "0x18831A660")]
	[AsyncStateMachine(typeof(LBIPLGJJEMI))]
	private Task ILOIMMFJAMD(BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x8319D30", Offset = "0x8319130", VA = "0x188319D30")]
	private void GNOENGHLPEO([NotNull] MMIOGOBDHFC HEDMDBBDAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x831A830", Offset = "0x8319C30", VA = "0x18831A830")]
	private bool MLADDGIPJEJ(KFOIBDNOLMJ IPCFHGIMHJJ, MMIOGOBDHFC HEDMDBBDAPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct KFNIEGNKNFA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct PLCKENBKHAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public AsyncTaskMethodBuilder<PMABFBOEKAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public KFNIEGNKNFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public HCDGKADAPOC.CKFPKAEIJLL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private TaskAwaiter<IReadOnlyCollection<FKNKAHPIOKE>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private TaskAwaiter<(BECHBBIPIFM<NAANJOANDLO, IDMJKCLDJLO>, BECHBBIPIFM<JHFICJGOLCJ<MMIOGOBDHFC>, IDMJKCLDJLO>, BECHBBIPIFM<JHFICJGOLCJ<KPMJDHJBPEL>, IDMJKCLDJLO>, BECHBBIPIFM<JHFICJGOLCJ<IEnumerable<APCBODKDHBC>>, IDMJKCLDJLO>, BECHBBIPIFM<JHFICJGOLCJ<CLFCELJMAMP>, IDMJKCLDJLO>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x8326530", Offset = "0x8325930", VA = "0x188326530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x8327310", Offset = "0x8326710", VA = "0x188327310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct JDGHOFAPDEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<NAANJOANDLO, IDMJKCLDJLO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public KFNIEGNKNFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public IReadOnlyCollection<FKNKAHPIOKE> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public IReadOnlyCollection<FKNKAHPIOKE> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public HCDGKADAPOC.CKFPKAEIJLL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter<BECHBBIPIFM<NAANJOANDLO, IDMJKCLDJLO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x83201C0", Offset = "0x831F5C0", VA = "0x1883201C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x8320820", Offset = "0x831FC20", VA = "0x188320820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	private IOBMDNONMHF<GPEOIJBIPCA, KPMJDHJBPEL> CCPCEPCLIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	private IOBMDNONMHF<GPEOIJBIPCA, MMIOGOBDHFC> BGCFKIKOLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	private IOBMDNONMHF<JDNBODNOFNG, IEnumerable<APCBODKDHBC>> EHBIPOADABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	private IOBMDNONMHF<long, CLFCELJMAMP> KEPFDIJNIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private DLOKMMGDHPN CILLKBDJDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private HNAJHGJKLNP LBIMIKPLDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private HABMELLNJLH AMHCBGDKHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	private Guid? CFEIEOEJEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	private IReadOnlyCollection<FKNKAHPIOKE> GLGLOHHDCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private Task<IReadOnlyCollection<FKNKAHPIOKE>> GLELEKAJFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	private GPEOIJBIPCA PBNEIBAJIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private GPEOIJBIPCA JJMNDMDKNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private GPEOIJBIPCA? NLGLIDCMIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private JDNBODNOFNG KFOMBPOJBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO;

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x8321F00", Offset = "0x8321300", VA = "0x188321F00")]
	public static Task<PMABFBOEKAG> AFGOPPEBDCB(LHLFHJJLIPN CNCGLFBHFNK, [In] KJLEKPJABLG AOFGGGKINCN, HCDGKADAPOC.CKFPKAEIJLL OPHFIDCCGMO, BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x8322400", Offset = "0x8321800", VA = "0x188322400")]
	[AsyncStateMachine(typeof(PLCKENBKHAD))]
	private Task<PMABFBOEKAG> ILOIMMFJAMD(HCDGKADAPOC.CKFPKAEIJLL OPHFIDCCGMO, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x83225B0", Offset = "0x83219B0", VA = "0x1883225B0")]
	[AsyncStateMachine(typeof(JDGHOFAPDEP))]
	private Task<BECHBBIPIFM<NAANJOANDLO, IDMJKCLDJLO>> KFGJCLDJPGN(Guid? CFEIEOEJEOL, IReadOnlyCollection<FKNKAHPIOKE> GLGLOHHDCFP, IReadOnlyCollection<FKNKAHPIOKE> KHGANELLIAN, long? NFMLPECGLEO, long? PIEICLNIOGJ, HCDGKADAPOC.CKFPKAEIJLL OPHFIDCCGMO, BNJJFADPKOK<string>.EFJIBBJEOLP EIOMBBBDHGK, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct BMHHBKLEOAL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct CCJEGDFKBAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public AsyncTaskMethodBuilder<KJLEKPJABLG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public BMHHBKLEOAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private TaskAwaiter<KJLEKPJABLG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x8314DD0", Offset = "0x83141D0", VA = "0x188314DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x8315220", Offset = "0x8314620", VA = "0x188315220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct GGMGMDFOIMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public AsyncTaskMethodBuilder<KJLEKPJABLG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public BMHHBKLEOAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private TaskAwaiter<KJLEKPJABLG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x831B830", Offset = "0x831AC30", VA = "0x18831B830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x831BCB0", Offset = "0x831B0B0", VA = "0x18831BCB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class GPAPLDIIDOH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016C")]
		private struct <<FetchRoomLoadDetails>g__getRoomSaveData|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000636")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000637")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000638")]
			public GPAPLDIIDOH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			private TaskAwaiter<GKCPDEPPDCM> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			private TaskAwaiter<MJKAJBCBAGM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x8327A60", Offset = "0x8326E60", VA = "0x188327A60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x8328420", Offset = "0x8327820", VA = "0x188328420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public KFEOAJAPKPO roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public LLKLGIOAOCK callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public GPEOIJBIPCA superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public GPEOIJBIPCA subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public IReadOnlyList<FKNKAHPIOKE> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public IReadOnlyList<FKNKAHPIOKE> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public HNAJHGJKLNP roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public GPAPLDIIDOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xE19250", Offset = "0xE18650", VA = "0x180E19250")]
		internal bool NGPBHPHGOMD(HABMELLNJLH sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x831BD20", Offset = "0x831B120", VA = "0x18831BD20")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task MHAOKAAMBJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x831BDF0", Offset = "0x831B1F0", VA = "0x18831BDF0")]
		internal Task<JDNBODNOFNG> NAHBGECBHDG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct DBKJKDFGCPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public AsyncTaskMethodBuilder<KJLEKPJABLG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public KFEOAJAPKPO roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public LLKLGIOAOCK callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public GPEOIJBIPCA superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private GPAPLDIIDOH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private HABMELLNJLH <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private Task<JDNBODNOFNG> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private TaskAwaiter<HNAJHGJKLNP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private TaskAwaiter<JDNBODNOFNG> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x8317530", Offset = "0x8316930", VA = "0x188317530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x83184E0", Offset = "0x83178E0", VA = "0x1883184E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	private LLKLGIOAOCK HLIKBEKBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private EALPINOJEEF IGNJCMAMHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	private KFEOAJAPKPO IHPFPMMMOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	private BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private long NFMLPECGLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private long AKJILJJKOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private long KDAFCLHLBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	private string LOLPCFDIILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	private GPEOIJBIPCA MKKOFHDCGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private Guid LIKFNGBHOCH;

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x8314430", Offset = "0x8313830", VA = "0x188314430")]
	public static Task<KJLEKPJABLG> AFGOPPEBDCB(LHLFHJJLIPN CNCGLFBHFNK, JKNOMNBJNEB LFFAIMMKIAM, BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x83149F0", Offset = "0x8313DF0", VA = "0x1883149F0")]
	[AsyncStateMachine(typeof(CCJEGDFKBAC))]
	private Task<KJLEKPJABLG> ILOIMMFJAMD(CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x8314880", Offset = "0x8313C80", VA = "0x188314880")]
	[AsyncStateMachine(typeof(GGMGMDFOIMD))]
	private Task<KJLEKPJABLG> FNDIEOOEBMH(BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x83146B0", Offset = "0x8313AB0", VA = "0x1883146B0")]
	[AsyncStateMachine(typeof(DBKJKDFGCPD))]
	private static Task<KJLEKPJABLG> FNDIEOOEBMH(LLKLGIOAOCK HLIKBEKBJPB, KFEOAJAPKPO IHPFPMMMOOH, long NFMLPECGLEO, long AKJILJJKOFL, long KDAFCLHLBDB, string LOLPCFDIILM, GPEOIJBIPCA MKKOFHDCGDJ, Guid LIKFNGBHOCH, CancellationToken JDDHIJBJNHP, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x8314680", Offset = "0x8313A80", VA = "0x188314680")]
	private void DCJBFMCKPAE(HNAJHGJKLNP LBIMIKPLDOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
internal struct AABDFGBGJEM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct JBDPNELLLFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public AABDFGBGJEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x831F960", Offset = "0x831ED60", VA = "0x18831F960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x831FEF0", Offset = "0x831F2F0", VA = "0x18831FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private LLKLGIOAOCK HLIKBEKBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private PMABFBOEKAG AOFGGGKINCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	private BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	private float NICHELFECCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private float BJJMHAHKKJO;

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x83107A0", Offset = "0x830FBA0", VA = "0x1883107A0")]
	public static Task CLFNLJKDHJA(LHLFHJJLIPN CNCGLFBHFNK, PMABFBOEKAG AOFGGGKINCN, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x8310A00", Offset = "0x830FE00", VA = "0x188310A00")]
	[AsyncStateMachine(typeof(JBDPNELLLFJ))]
	public Task ILOIMMFJAMD(CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x8310B20", Offset = "0x830FF20", VA = "0x188310B20")]
	private static void KNNJNCEBLCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x8310C60", Offset = "0x8310060", VA = "0x188310C60")]
	private void MJEDBFAPILC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x8310940", Offset = "0x830FD40", VA = "0x188310940")]
	private static float HADNOGFGDJL(LLKLGIOAOCK HLIKBEKBJPB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x8310DC0", Offset = "0x83101C0", VA = "0x188310DC0")]
	private static float NLLPOMBHFCK()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000171")]
internal struct JBOGLBGKPDC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct COKCBFOKMOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public EKCMCCJKLGK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private PJCDBCNMOMI <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private LHLFHJJLIPN <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private NGIJFPIFBPB.HGOKLINHOJL <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private TaskAwaiter<HOGPILOHPJM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x8316CB0", Offset = "0x83160B0", VA = "0x188316CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x83174D0", Offset = "0x83168D0", VA = "0x1883174D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private struct PJNEPIIHFHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x8325E10", Offset = "0x8325210", VA = "0x188325E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x8326140", Offset = "0x8325540", VA = "0x188326140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x831FF50", Offset = "0x831F350", VA = "0x18831FF50")]
	[AsyncStateMachine(typeof(COKCBFOKMOI))]
	public static Task ILOIMMFJAMD(EKCMCCJKLGK MIFPAPEJAIK, PMABFBOEKAG AOFGGGKINCN, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x8320090", Offset = "0x831F490", VA = "0x188320090")]
	private static Task<HOGPILOHPJM> MNOLOBCHKAD(EKCMCCJKLGK MIFPAPEJAIK, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x8320100", Offset = "0x831F500", VA = "0x188320100")]
	[AsyncStateMachine(typeof(PJNEPIIHFHC))]
	private static Task NDGHDLALFKF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct CCGJHHADBGL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct HIFOMLKLJLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public CCGJHHADBGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x831D8F0", Offset = "0x831CCF0", VA = "0x18831D8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x831DFA0", Offset = "0x831D3A0", VA = "0x18831DFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class MFEOJIECFJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public MFEOJIECFJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x83244C0", Offset = "0x83238C0", VA = "0x1883244C0")]
		internal object MKODFEBMIHI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct HBGNEKPHNDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public CCGJHHADBGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x831C340", Offset = "0x831B740", VA = "0x18831C340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x831C7C0", Offset = "0x831BBC0", VA = "0x18831C7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private bool IMJNODNKIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	private LHLFHJJLIPN CNCGLFBHFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private CancellationToken JDDHIJBJNHP;

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x8314B40", Offset = "0x8313F40", VA = "0x188314B40")]
	public static Task CIMNIOCCCBL(LHLFHJJLIPN CNCGLFBHFNK, bool IMJNODNKIOL, BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, CancellationToken CPENNOHENKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x8314CE0", Offset = "0x83140E0", VA = "0x188314CE0")]
	[AsyncStateMachine(typeof(HIFOMLKLJLI))]
	private Task ILOIMMFJAMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x8314BB0", Offset = "0x8313FB0", VA = "0x188314BB0")]
	[AsyncStateMachine(typeof(HBGNEKPHNDA))]
	private Task EJNNEHLKLLD(bool MAONBEFDDAD, string OGBJCLBNMBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0")]
	private bool JLOECNMPLGF(bool IMJNODNKIOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
internal struct IDOCNNGBCBC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct HJMHMGDFFCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public IDOCNNGBCBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x831E000", Offset = "0x831D400", VA = "0x18831E000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x831E570", Offset = "0x831D970", VA = "0x18831E570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class MGBFIBHAMED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public MGBFIBHAMED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x8324540", Offset = "0x8323940", VA = "0x188324540")]
		internal object MKODFEBMIHI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private struct OBMMKBNPEAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public IDOCNNGBCBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x83256B0", Offset = "0x8324AB0", VA = "0x1883256B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x8325B40", Offset = "0x8324F40", VA = "0x188325B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private FFAAEPGJLMN KMAEMLKOKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private LHLFHJJLIPN CNCGLFBHFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private bool PFLOGLLKKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private PMABFBOEKAG AOFGGGKINCN;

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x831F520", Offset = "0x831E920", VA = "0x18831F520")]
	public static Task<Scene> CNEFBKDIEGF(LHLFHJJLIPN CNCGLFBHFNK, FFAAEPGJLMN IDPKEAOPMID, BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x831F6F0", Offset = "0x831EAF0", VA = "0x18831F6F0")]
	[AsyncStateMachine(typeof(HJMHMGDFFCP))]
	private Task<Scene> ILOIMMFJAMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x831F810", Offset = "0x831EC10", VA = "0x18831F810")]
	private bool POHMEEAHJIP(PMABFBOEKAG AOFGGGKINCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x831F4B0", Offset = "0x831E8B0", VA = "0x18831F4B0")]
	private void CJKFPMGBGLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x831F5A0", Offset = "0x831E9A0", VA = "0x18831F5A0")]
	[AsyncStateMachine(typeof(OBMMKBNPEAF))]
	private Task<Scene> EJNNEHLKLLD(string OGBJCLBNMBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal struct PKIEMPCKCJG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct BBGBDEHKBMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public AsyncTaskMethodBuilder<ACEACLGOILG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public PKIEMPCKCJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public ACEACLGOILG nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public PMABFBOEKAG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private TaskAwaiter<ACEACLGOILG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x8312990", Offset = "0x8311D90", VA = "0x188312990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x8313460", Offset = "0x8312860", VA = "0x188313460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct DHABICMFMHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public AsyncTaskMethodBuilder<ACEACLGOILG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public PKIEMPCKCJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public ACEACLGOILG state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private TaskAwaiter<HOGPILOHPJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x83185D0", Offset = "0x83179D0", VA = "0x1883185D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x83188B0", Offset = "0x8317CB0", VA = "0x1883188B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	private readonly EKCMCCJKLGK MIFPAPEJAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private readonly EALPINOJEEF IGNJCMAMHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private readonly KANFGHIBODB AJKGFOKCFAA;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private PJCDBCNMOMI DKDCOFMBBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x679CB30", Offset = "0x679BF30", VA = "0x18679CB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x83264D0", Offset = "0x83258D0", VA = "0x1883264D0")]
	public PKIEMPCKCJG(EKCMCCJKLGK MIFPAPEJAIK, EALPINOJEEF IGNJCMAMHAP, KANFGHIBODB AJKGFOKCFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x83261C0", Offset = "0x83255C0", VA = "0x1883261C0")]
	[AsyncStateMachine(typeof(BBGBDEHKBMK))]
	public Task<ACEACLGOILG> DFOPIDDOAEJ(ACEACLGOILG LDGLEOKDHLJ, PMABFBOEKAG NCKEPNBEOKJ, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP, bool MMEHKBEDNOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x8326340", Offset = "0x8325740", VA = "0x188326340")]
	[AsyncStateMachine(typeof(DHABICMFMHN))]
	private Task<ACEACLGOILG> GIMIMHEGBIN(BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, ACEACLGOILG FGCBFMGNEPC, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x83264A0", Offset = "0x83258A0", VA = "0x1883264A0")]
	private bool LCINBFDMCDB(ACEACLGOILG DHHHELGJJKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x83261A0", Offset = "0x83255A0", VA = "0x1883261A0")]
	private void BKFDGJHNENK(string BNFNFAFOAGE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal struct PJAOCIFIKEH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct LJADCPKPBPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public PJCDBCNMOMI operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public CGIJHFBFBKP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private FNIAOHCFFHK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private List<(PersistenceView, IBDHKNDIHNK)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private (PersistenceView, IBDHKNDIHNK) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x8323B00", Offset = "0x8322F00", VA = "0x188323B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x83241D0", Offset = "0x83235D0", VA = "0x1883241D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x8325CD0", Offset = "0x83250D0", VA = "0x188325CD0")]
	[AsyncStateMachine(typeof(LJADCPKPBPB))]
	public static Task ILOIMMFJAMD(PJCDBCNMOMI LLGAMDBNNCE, PMABFBOEKAG AOFGGGKINCN, CGIJHFBFBKP IJGDBGGPKBI, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal struct BGKPBGNFBAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct IDGLPPFDBGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public PJCDBCNMOMI operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public CGIJHFBFBKP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private KFOIBDNOLMJ <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private FNIAOHCFFHK <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private List<(PersistenceView, IBDHKNDIHNK)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private IBDHKNDIHNK <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x831EB70", Offset = "0x831DF70", VA = "0x18831EB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x831F450", Offset = "0x831E850", VA = "0x18831F450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x83134D0", Offset = "0x83128D0", VA = "0x1883134D0")]
	[AsyncStateMachine(typeof(IDGLPPFDBGE))]
	public static Task ILOIMMFJAMD(PJCDBCNMOMI LLGAMDBNNCE, PMABFBOEKAG AOFGGGKINCN, CGIJHFBFBKP IJGDBGGPKBI, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal struct NGIJFPIFBPB
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	public struct HGOKLINHOJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public List<KKBBLNDJLCH> KMCAMAKGJCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public List<IBDHKNDIHNK> KEADEPJEJKI;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xA813A0", Offset = "0xA807A0", VA = "0x180A813A0")]
		public HGOKLINHOJL(List<KKBBLNDJLCH> KMCAMAKGJCD, List<IBDHKNDIHNK> KEADEPJEJKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private sealed class DGEIFNJGHNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public IEnumerable<KKBBLNDJLCH> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public DGEIFNJGHNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x8318550", Offset = "0x8317950", VA = "0x188318550")]
		internal object IENDNFKHMAI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	private LHLFHJJLIPN CNCGLFBHFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private PMABFBOEKAG AOFGGGKINCN;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private LLKLGIOAOCK GHCAPJHEIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x8324DF0", Offset = "0x83241F0", VA = "0x188324DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x8324E40", Offset = "0x8324240", VA = "0x188324E40")]
	public static HGOKLINHOJL ILOIMMFJAMD(LHLFHJJLIPN CNCGLFBHFNK, PMABFBOEKAG AOFGGGKINCN)
	{
		return default(HGOKLINHOJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x8324EA0", Offset = "0x83242A0", VA = "0x188324EA0")]
	private HGOKLINHOJL ILOIMMFJAMD()
	{
		return default(HGOKLINHOJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x8325100", Offset = "0x8324500", VA = "0x188325100")]
	private HGOKLINHOJL NDODDLCODPE(MMIOGOBDHFC HEDMDBBDAPE, KFOIBDNOLMJ LBKIKJEFAFK)
	{
		return default(HGOKLINHOJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x8324C20", Offset = "0x8324020", VA = "0x188324C20")]
	private bool BLCHLBBHFGA(IEnumerable<KKBBLNDJLCH> KMCAMAKGJCD)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal struct HIFKPDGNEJC
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class JLLCFPNHCAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public NGIJFPIFBPB.HGOKLINHOJL instantiations;

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public JLLCFPNHCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x8320F10", Offset = "0x8320310", VA = "0x188320F10")]
		internal object LHLAPJDCBBK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class HHPEPPMFEOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public HHPEPPMFEOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x831D2B0", Offset = "0x831C6B0", VA = "0x18831D2B0")]
		internal object OBCPHPCPBOE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x831D340", Offset = "0x831C740", VA = "0x18831D340")]
	public static void ILOIMMFJAMD(PJCDBCNMOMI LLGAMDBNNCE, PMABFBOEKAG AOFGGGKINCN, NGIJFPIFBPB.HGOKLINHOJL KIEADECAGBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal class KANFGHIBODB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct HGAKNIEJCPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public KANFGHIBODB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public ACEACLGOILG operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public PMABFBOEKAG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x831CAE0", Offset = "0x831BEE0", VA = "0x18831CAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x831D250", Offset = "0x831C650", VA = "0x18831D250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class LACKLMPBDIK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006D8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006D9")]
			public LACKLMPBDIK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006DA")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000664")]
			[Cpp2IlInjected.Address(RVA = "0x8329660", Offset = "0x8328A60", VA = "0x188329660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x8329920", Offset = "0x8328D20", VA = "0x188329920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public KANFGHIBODB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public LACKLMPBDIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x8322DA0", Offset = "0x83221A0", VA = "0x188322DA0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task GPFABACKNMO(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private struct IBOBLAHGPLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public KANFGHIBODB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		private LACKLMPBDIK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x831E5E0", Offset = "0x831D9E0", VA = "0x18831E5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x831EB10", Offset = "0x831DF10", VA = "0x18831EB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct HPFPHEAOHIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public KANFGHIBODB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private Dictionary<Guid, List<LMELJOKCJFH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x8333C70", Offset = "0x8333070", VA = "0x188333C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x8334280", Offset = "0x8333680", VA = "0x188334280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private struct FLIOMIPBLCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public KANFGHIBODB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private Dictionary<Guid, List<LMELJOKCJFH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x832F5D0", Offset = "0x832E9D0", VA = "0x18832F5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x832FC60", Offset = "0x832F060", VA = "0x18832FC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class BOCPILNNLHD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000191")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006FB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006FC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006FD")]
			public LMELJOKCJFH handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006FE")]
			public BOCPILNNLHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006FF")]
			private FNIAOHCFFHK <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000700")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x8338BB0", Offset = "0x8337FB0", VA = "0x188338BB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x8339020", Offset = "0x8338420", VA = "0x188339020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public KFIALIOGHEG runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public List<LMELJOKCJFH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BOCPILNNLHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x832A820", Offset = "0x8329C20", VA = "0x18832A820")]
		internal object MLAEIIFILHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x832A720", Offset = "0x8329B20", VA = "0x18832A720")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task LJCOMDMMKDI(LMELJOKCJFH handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x832A910", Offset = "0x8329D10", VA = "0x18832A910")]
		internal object NFMKCINIAJG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct GNLBKHGADAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public KFIALIOGHEG runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public List<LMELJOKCJFH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		private BOCPILNNLHD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x8330B00", Offset = "0x832FF00", VA = "0x188330B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x8330FD0", Offset = "0x83303D0", VA = "0x188330FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private struct JPAJPMDBHAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public KANFGHIBODB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x8335010", Offset = "0x8334410", VA = "0x188335010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x8335300", Offset = "0x8334700", VA = "0x188335300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class NNCIBMDMOKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public NNCIBMDMOKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x8338A80", Offset = "0x8337E80", VA = "0x188338A80")]
		internal object AFFOPFBJCEO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private struct FHHFCJMHNNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public KANFGHIBODB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public PMABFBOEKAG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x832F050", Offset = "0x832E450", VA = "0x18832F050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x832F500", Offset = "0x832E900", VA = "0x18832F500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class OBIBKGLFBJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public OBIBKGLFBJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x8338AF0", Offset = "0x8337EF0", VA = "0x188338AF0")]
		internal object HPMLNHGFENA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private struct FOEOEBEOOII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public KANFGHIBODB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		private FNIAOHCFFHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		private TaskAwaiter<HOGPILOHPJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x832FCC0", Offset = "0x832F0C0", VA = "0x18832FCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x83302F0", Offset = "0x832F6F0", VA = "0x1883302F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class DFJILAANDCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public DFJILAANDCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x832D6C0", Offset = "0x832CAC0", VA = "0x18832D6C0")]
		internal object ENNPDOFEPEA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private readonly EKCMCCJKLGK MIFPAPEJAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private ANPJMKBHNCP AJKGFOKCFAA;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private PJCDBCNMOMI DKDCOFMBBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x10A6CF0", Offset = "0x10A60F0", VA = "0x1810A6CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	public KANFGHIBODB(EKCMCCJKLGK MIFPAPEJAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x8321500", Offset = "0x8320900", VA = "0x188321500")]
	[AsyncStateMachine(typeof(HGAKNIEJCPC))]
	public Task ILOIMMFJAMD(ACEACLGOILG HDOIAGEHIGK, PMABFBOEKAG NCKEPNBEOKJ, BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x83213C0", Offset = "0x83207C0", VA = "0x1883213C0")]
	[AsyncStateMachine(typeof(IBOBLAHGPLL))]
	private Task IADNMHCKEPI(PMABFBOEKAG AOFGGGKINCN, BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x8321650", Offset = "0x8320A50", VA = "0x188321650")]
	[AsyncStateMachine(typeof(HPFPHEAOHIB))]
	private Task INJEJNKJAHA(PMABFBOEKAG AOFGGGKINCN, BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x8321840", Offset = "0x8320C40", VA = "0x188321840")]
	[AsyncStateMachine(typeof(FLIOMIPBLCL))]
	private Task KECIEBKEKIE(PMABFBOEKAG AOFGGGKINCN, BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x8321270", Offset = "0x8320670", VA = "0x188321270")]
	[AsyncStateMachine(typeof(GNLBKHGADAH))]
	private Task EPEAEAMMLAL(Guid FODGMGKEIMA, List<LMELJOKCJFH> AFCKHDGLOOK, KFIALIOGHEG CCLCPBPKBKJ, PMABFBOEKAG AOFGGGKINCN, CancellationToken PAHPIGHLKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x8321DC0", Offset = "0x83211C0", VA = "0x188321DC0")]
	[AsyncStateMachine(typeof(JPAJPMDBHAK))]
	private Task PCDPHGALNEF(PMABFBOEKAG AOFGGGKINCN, BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x8321C80", Offset = "0x8321080", VA = "0x188321C80")]
	[AsyncStateMachine(typeof(FHHFCJMHNNH))]
	private Task MNPEHLOPFEB(Guid JBJBCNGDFNF, PMABFBOEKAG AOFGGGKINCN, BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x8320FC0", Offset = "0x83203C0", VA = "0x188320FC0")]
	[AsyncStateMachine(typeof(FOEOEBEOOII))]
	private Task CMEHICKNAIA(Guid JBJBCNGDFNF, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x8321B60", Offset = "0x8320F60", VA = "0x188321B60")]
	private void LENJNGNEDGF(Guid JBJBCNGDFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x8321790", Offset = "0x8320B90", VA = "0x188321790")]
	private void JNODPJODIOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x8321100", Offset = "0x8320500", VA = "0x188321100")]
	public Guid DBONDEFJKMP(ACEACLGOILG NIFEKMCNBIL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x8321980", Offset = "0x8320D80", VA = "0x188321980")]
	[CompilerGenerated]
	private object KEMGIIOCPDK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal struct MDLBDJJKMFH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct JPGFKMOJCGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public MDLBDJJKMFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		private IEnumerator<BPEMJMDHKBJ> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x8335360", Offset = "0x8334760", VA = "0x188335360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x8335A00", Offset = "0x8334E00", VA = "0x188335A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000729")]
	private LLKLGIOAOCK HLIKBEKBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400072A")]
	private BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072B")]
	private CancellationToken JDDHIJBJNHP;

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x8338160", Offset = "0x8337560", VA = "0x188338160")]
	public static Task JHEJIOONLAK(LLKLGIOAOCK HLIKBEKBJPB, BNJJFADPKOK<string>.EFJIBBJEOLP IHAAMEONBJO, CancellationToken CPENNOHENKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x8338070", Offset = "0x8337470", VA = "0x188338070")]
	[AsyncStateMachine(typeof(JPGFKMOJCGO))]
	private Task ILOIMMFJAMD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public readonly struct NBFKFCCDAMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000732")]
	public readonly bool FEDPNOOLHPG;

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x28EC7F0", Offset = "0x28EBBF0", VA = "0x1828EC7F0")]
	public NBFKFCCDAMP(bool KBPAKKGAPOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public readonly struct BNHNOHNOJEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000733")]
	public readonly MMIOGOBDHFC? OMKHGEBPNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000734")]
	public readonly HHOCCKCNFKN JFNPHHNOPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000735")]
	public readonly Guid? GNADLEHNJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000736")]
	public readonly IReadOnlyList<Guid> LLKJOKMNJAI;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public IReadOnlyCollection<string> JKFINMECPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x832A600", Offset = "0x8329A00", VA = "0x18832A600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public IReadOnlyDictionary<long, int> GDAFPMGIEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x832A5E0", Offset = "0x83299E0", VA = "0x18832A5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x832A620", Offset = "0x8329A20", VA = "0x18832A620")]
	public BNHNOHNOJEM(MMIOGOBDHFC? NILNGFKCINL, HHOCCKCNFKN KLPBPNOJLKE, Guid? CFEIEOEJEOL, [Optional] IReadOnlyList<Guid>? KHNDEHMMGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
internal class DDELOLOMNAN : HDCEMHIJFIC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private struct HDABGFEAMDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public AsyncTaskMethodBuilder<BNHNOHNOJEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public DDELOLOMNAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		public OGDDCPBMNHF serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public PMJGODHIFMK roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		private FNIAOHCFFHK <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x8331DD0", Offset = "0x83311D0", VA = "0x188331DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x8332470", Offset = "0x8331870", VA = "0x188332470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private sealed class EHNPBCPEICM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public EHNPBCPEICM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x832E050", Offset = "0x832D450", VA = "0x18832E050")]
		internal object PIDGJBNNMEA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private struct MCLEFBLHOJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public DDELOLOMNAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		public OGDDCPBMNHF serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private EHNPBCPEICM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private FNIAOHCFFHK <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private OAGGALGHDAH<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x8337540", Offset = "0x8336940", VA = "0x188337540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x8338010", Offset = "0x8337410", VA = "0x188338010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000737")]
	private readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x4000738")]
	private static readonly TimeSpan JEDCFCCEKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000739")]
	private readonly DJFDDPIGILM ONCNIJBGPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400073A")]
	private readonly CCCOHJFPHJC AMKHGIFFPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400073B")]
	private readonly NCIFNOGPKJP MMAPMELEKBN;

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x832D650", Offset = "0x832CA50", VA = "0x18832D650")]
	public DDELOLOMNAN(EKCMCCJKLGK MIFPAPEJAIK, DJFDDPIGILM ONCNIJBGPLP, CCCOHJFPHJC PFFNFPAFFEL, NCIFNOGPKJP MMAPMELEKBN, LMKAPNBAFDO KIBGFJNEFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x832D490", Offset = "0x832C890", VA = "0x18832D490")]
	[AsyncStateMachine(typeof(HDABGFEAMDK))]
	public Task<BNHNOHNOJEM> PEGKBLBFNLH(long AKJILJJKOFL, PMJGODHIFMK DDMFAOHNAGN, OGDDCPBMNHF OBICHNFPNBD, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x832CEA0", Offset = "0x832C2A0", VA = "0x18832CEA0")]
	[AsyncStateMachine(typeof(MCLEFBLHOJL))]
	private Task ILFOPBAIPIH(OGDDCPBMNHF OBICHNFPNBD, PersistenceView[] FHCGJOMGIEP, StringBuilder PALINDAFGOL, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x832C890", Offset = "0x832BC90", VA = "0x18832C890")]
	private BNHNOHNOJEM FOPLJNLDMOA(long AKJILJJKOFL, PMJGODHIFMK DDMFAOHNAGN, OGDDCPBMNHF OBICHNFPNBD, IEnumerable<PersistenceView> FHCGJOMGIEP, StringBuilder PALINDAFGOL)
	{
		return default(BNHNOHNOJEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x832C6D0", Offset = "0x832BAD0", VA = "0x18832C6D0")]
	private MMIOGOBDHFC EKJECGFECCB(long AKJILJJKOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x832C480", Offset = "0x832B880", VA = "0x18832C480")]
	private void DIDJMPGILOE(MMIOGOBDHFC IAAOGIMLPPP, StringBuilder PALINDAFGOL, IEnumerable<PersistenceView> FHCGJOMGIEP, [In] GGHCNLJOJLN IHEHFNAIPPM, MLEJOHEHBLD DFMGFJGFHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x832CFE0", Offset = "0x832C3E0", VA = "0x18832CFE0")]
	private void MODHANEPPMJ(MMIOGOBDHFC IAAOGIMLPPP, StringBuilder PALINDAFGOL, PersistenceView KNHIPANAKJG, MLEJOHEHBLD DFMGFJGFHAC, [In] GGHCNLJOJLN IHEHFNAIPPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal class GPDPAGDFEGM : HDCEMHIJFIC
{
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private sealed class OENAMCLIIBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public NOEKHCGOBMH.OEKGMIBHJGE roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public OENAMCLIIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x8338B60", Offset = "0x8337F60", VA = "0x188338B60")]
		internal object GDOEKGAOMDG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private struct CHHOHNNHPBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public AsyncTaskMethodBuilder<(NOEKHCGOBMH.OEKGMIBHJGE roomDataUpload, NOEKHCGOBMH.OEKGMIBHJGE subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public BNHNOHNOJEM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public LLKLGIOAOCK callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		private OENAMCLIIBD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private TaskAwaiter<NOEKHCGOBMH.OEKGMIBHJGE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x832B4C0", Offset = "0x832A8C0", VA = "0x18832B4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x832BD40", Offset = "0x832B140", VA = "0x18832BD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private struct IEIHKDCDNNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public AsyncTaskMethodBuilder<EAOAOGAEAGM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public GPDPAGDFEGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public OOGIILPNHKC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public BNHNOHNOJEM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		private TaskAwaiter<EAOAOGAEAGM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x8334790", Offset = "0x8333B90", VA = "0x188334790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x8334A30", Offset = "0x8333E30", VA = "0x188334A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private struct CMIJPENGJCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public AsyncTaskMethodBuilder<EAOAOGAEAGM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public LLKLGIOAOCK callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public BNHNOHNOJEM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public AHJLBEHCIFO ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public OOGIILPNHKC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		private TaskAwaiter<(NOEKHCGOBMH.OEKGMIBHJGE roomDataUpload, NOEKHCGOBMH.OEKGMIBHJGE subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		private TaskAwaiter<EAOAOGAEAGM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x832BDB0", Offset = "0x832B1B0", VA = "0x18832BDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x832C410", Offset = "0x832B810", VA = "0x18832C410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private struct BHIJDKMMBAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		public AsyncTaskMethodBuilder<GKCPDEPPDCM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		public GPDPAGDFEGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		public BNHNOHNOJEM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		private TaskAwaiter<(NOEKHCGOBMH.OEKGMIBHJGE roomDataUpload, NOEKHCGOBMH.OEKGMIBHJGE subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		private TaskAwaiter<GKCPDEPPDCM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x832A0B0", Offset = "0x83294B0", VA = "0x18832A0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x832A570", Offset = "0x8329970", VA = "0x18832A570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private sealed class EGLININJJKB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AA")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000788")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000789")]
			public AsyncTaskMethodBuilder<HOGPILOHPJM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400078A")]
			public EGLININJJKB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400078B")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400078C")]
			private HOGPILOHPJM <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400078D")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400078E")]
			private TaskAwaiter<GKCPDEPPDCM> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400078F")]
			private TaskAwaiter<EAOAOGAEAGM> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000790")]
			private TaskAwaiter<HOGPILOHPJM> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006B2")]
			[Cpp2IlInjected.Address(RVA = "0x8339080", Offset = "0x8338480", VA = "0x188339080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0x833A290", Offset = "0x8339690", VA = "0x18833A290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public GPDPAGDFEGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public BNHNOHNOJEM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public OOGIILPNHKC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public NBFKFCCDAMP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public EGLININJJKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x832DF20", Offset = "0x832D320", VA = "0x18832DF20")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<HOGPILOHPJM> MPPELKDHBLB(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private struct MNGLGIJOIEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public AsyncTaskMethodBuilder<HOGPILOHPJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public GPDPAGDFEGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public BNHNOHNOJEM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public OOGIILPNHKC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public NBFKFCCDAMP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		private TaskAwaiter<HOGPILOHPJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x83386E0", Offset = "0x8337AE0", VA = "0x1883386E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x8338A10", Offset = "0x8337E10", VA = "0x188338A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000755")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x4000756")]
	private static readonly LMKAPNBAFDO PLBIGHLHFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000757")]
	private readonly DCHGLMHEJOH OPAKBIOPIAJ;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private LHLFHJJLIPN KFFMLJHDNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x82FC020", Offset = "0x82FB420", VA = "0x1882FC020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x8331BA0", Offset = "0x8330FA0", VA = "0x188331BA0")]
	public GPDPAGDFEGM(EKCMCCJKLGK MIFPAPEJAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x8331030", Offset = "0x8330430", VA = "0x188331030")]
	[AsyncStateMachine(typeof(CHHOHNNHPBL))]
	private static Task<(NOEKHCGOBMH.OEKGMIBHJGE, NOEKHCGOBMH.OEKGMIBHJGE)> BCPDHABBEFM(LLKLGIOAOCK HLIKBEKBJPB, BNHNOHNOJEM HOEAFNFMMDO, long NFMLPECGLEO, long PIEICLNIOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x83314B0", Offset = "0x83308B0", VA = "0x1883314B0")]
	[AsyncStateMachine(typeof(IEIHKDCDNNA))]
	public Task<EAOAOGAEAGM> GOGACPDALIP(int MBANJJBOKOG, [CanBeNull] OOGIILPNHKC AFEEILJEPLN, BNHNOHNOJEM HOEAFNFMMDO, long NFMLPECGLEO, long PIEICLNIOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x8331620", Offset = "0x8330A20", VA = "0x188331620")]
	public static Task<EAOAOGAEAGM> GOGACPDALIP(LLKLGIOAOCK HLIKBEKBJPB, int MBANJJBOKOG, [CanBeNull] OOGIILPNHKC AFEEILJEPLN, BNHNOHNOJEM HOEAFNFMMDO, long NFMLPECGLEO, long PIEICLNIOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x8331970", Offset = "0x8330D70", VA = "0x188331970")]
	[AsyncStateMachine(typeof(CMIJPENGJCN))]
	public static Task<EAOAOGAEAGM> GOGACPDALIP(LLKLGIOAOCK HLIKBEKBJPB, int MBANJJBOKOG, [CanBeNull] OOGIILPNHKC AFEEILJEPLN, BNHNOHNOJEM HOEAFNFMMDO, long NFMLPECGLEO, long PIEICLNIOGJ, AHJLBEHCIFO ENNCENPJFLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x8331180", Offset = "0x8330580", VA = "0x188331180")]
	[AsyncStateMachine(typeof(BHIJDKMMBAB))]
	private Task<GKCPDEPPDCM> DLJFAAECMEG(string LOLPCFDIILM, int MBANJJBOKOG, BNHNOHNOJEM HOEAFNFMMDO, long NFMLPECGLEO, long PIEICLNIOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x8331300", Offset = "0x8330700", VA = "0x188331300")]
	[AsyncStateMachine(typeof(MNGLGIJOIEI))]
	public Task<HOGPILOHPJM> FCAALLLJAJM(int MBANJJBOKOG, OOGIILPNHKC? AFEEILJEPLN, BNHNOHNOJEM HOEAFNFMMDO, long NFMLPECGLEO, long PIEICLNIOGJ, NBFKFCCDAMP ECBCIOLFNJL, BNJJFADPKOK<string>.EFJIBBJEOLP BJIEABKMLAN, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public abstract class KDPDOEEOJPM<T> where T : KDPDOEEOJPM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079D")]
	internal readonly LHLFHJJLIPN LEENFIIPLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079E")]
	private int? KCJOPNEBFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079F")]
	protected readonly Guid NBHBLNGHIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007A0")]
	protected readonly MCCMJJHBLDP AHAKLPMDHGD;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected T EJJKOHBCLPM
	{
		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x4D76B90", Offset = "0x4D75F90", VA = "0x184D76B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x4D76DF0", Offset = "0x4D761F0", VA = "0x184D76DF0")]
	internal KDPDOEEOJPM(LHLFHJJLIPN NANDOCCBKGN, MCCMJJHBLDP FILHOBMLBKK, [Optional] Guid? IAFOFMFFKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x4D76BF0", Offset = "0x4D75FF0", VA = "0x184D76BF0")]
	private HOGPILOHPJM KJNPLFNHEJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "4")]
	protected virtual void DNPKDMMKGIC(HOGPILOHPJM FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x4D76CD0", Offset = "0x4D760D0", VA = "0x184D76CD0")]
	public T LFONLJNOFOD(EKIKILMCLIO HANDOEBGAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x4D76AE0", Offset = "0x4D75EE0", VA = "0x184D76AE0")]
	public T DGGHFEPJLAG(int EEDJAPGMLAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x4D769B0", Offset = "0x4D75DB0", VA = "0x184D769B0", Slot = "5")]
	public virtual Task<AEALKLKILHL> CDBGBNAONCI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public class HABAAAJBIHC : KDPDOEEOJPM<HABAAAJBIHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007A1")]
	private JKNOMNBJNEB CFFKMBGFAOG;

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x8331D00", Offset = "0x8331100", VA = "0x188331D00")]
	internal HABAAAJBIHC(LHLFHJJLIPN NANDOCCBKGN, MCCMJJHBLDP FILHOBMLBKK, [Optional] Guid? IAFOFMFFKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x75DF340", Offset = "0x75DE740", VA = "0x1875DF340")]
	public HABAAAJBIHC NLAOIIKPIGD(JKNOMNBJNEB CFFKMBGFAOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x8331C30", Offset = "0x8331030", VA = "0x188331C30", Slot = "4")]
	protected override void DNPKDMMKGIC(HOGPILOHPJM FGEBHLNNMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
public class DFMADOPCDNL : KDPDOEEOJPM<DFMADOPCDNL>
{
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	internal enum EJPFANHMKKO
	{
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[CompilerGenerated]
	private struct JDBJBLOEPHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public AsyncTaskMethodBuilder<AEALKLKILHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public DFMADOPCDNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		private TaskAwaiter<AEALKLKILHL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x8334AA0", Offset = "0x8333EA0", VA = "0x188334AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x8334E50", Offset = "0x8334250", VA = "0x188334E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007A2")]
	private EJPFANHMKKO EFNHBFPGGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007A3")]
	private string JAGIGPNMAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007A4")]
	private OOGIILPNHKC CFFKMBGFAOG;

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x832DA70", Offset = "0x832CE70", VA = "0x18832DA70")]
	internal DFMADOPCDNL(LHLFHJJLIPN NANDOCCBKGN, MCCMJJHBLDP FILHOBMLBKK, [Optional] Guid? IAFOFMFFKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x832DA20", Offset = "0x832CE20", VA = "0x18832DA20")]
	public DFMADOPCDNL NKKBDAICHLF(string IKFIIFEGFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x832DA50", Offset = "0x832CE50", VA = "0x18832DA50")]
	public DFMADOPCDNL NLCELDAEACK(bool DDAJDDIOJBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x832D820", Offset = "0x832CC20", VA = "0x18832D820")]
	public DFMADOPCDNL DDJKAGGNEBJ(bool JHACCFELPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x832D9B0", Offset = "0x832CDB0", VA = "0x18832D9B0")]
	public DFMADOPCDNL GJOKBGEJNKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x832D840", Offset = "0x832CC40", VA = "0x18832D840", Slot = "4")]
	protected override void DNPKDMMKGIC(HOGPILOHPJM FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x832D730", Offset = "0x832CB30", VA = "0x18832D730", Slot = "5")]
	[AsyncStateMachine(typeof(JDBJBLOEPHG))]
	public override Task<AEALKLKILHL> CDBGBNAONCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x832D9E0", Offset = "0x832CDE0", VA = "0x18832D9E0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<AEALKLKILHL> IEPMOKFEDHI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal static class LAKHMPEINBH
{
	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x83373F0", Offset = "0x83367F0", VA = "0x1883373F0")]
	public static void MNDNPHOOIND(this HCOCEGBHFMI CLKBKGKPHNL, ECGOJJLBFIL GMJPKCAACCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x8337370", Offset = "0x8336770", VA = "0x188337370")]
	public static void LEDLNCPNOFH(this ECGOJJLBFIL OINOCKJMHLO, [Optional] string FGEBHLNNMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public static class JFJIFKELNKC
{
	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x8334EC0", Offset = "0x83342C0", VA = "0x188334EC0")]
	public static GPEOIJBIPCA FNKCFFDOHPG(this MGDEPODGFPA GJBJAJEDGJF)
	{
		return default(GPEOIJBIPCA);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x8334F60", Offset = "0x8334360", VA = "0x188334F60")]
	public static MGDEPODGFPA GNICJAKKODM(this GPEOIJBIPCA FFLMJDLNLPF)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001B4")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			public MCEMLLJABCE ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			public MCEMLLJABCE HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		private static MCEMLLJABCE[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007B0")]
		private Dictionary<MCEMLLJABCE, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x833A8B0", Offset = "0x8339CB0", VA = "0x18833A8B0")]
		public bool FKJINHHBCIF(MCEMLLJABCE NCPNLAHMLIF, [Out] ResultConfig ICLMPPLIKCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x833A920", Offset = "0x8339D20", VA = "0x18833A920")]
		public ResultConfig LGIPPHOOEHP(MCEMLLJABCE HJCCPGPOLBJ, [Optional] HashSet<MCEMLLJABCE> ALIGBLHMBLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x833B030", Offset = "0x833A430", VA = "0x18833B030", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x833AA60", Offset = "0x8339E60", VA = "0x18833AA60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xB7EE00", Offset = "0xB7E200", VA = "0x180B7EE00")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
public class DMLNNHHNFAL : MGPCNPKFNKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[CompilerGenerated]
	private struct GLKABAMLHOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		public DMLNNHHNFAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x8330810", Offset = "0x832FC10", VA = "0x188330810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x8330AA0", Offset = "0x832FEA0", VA = "0x188330AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[CompilerGenerated]
	private struct MLAFBPIMIHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		public BNJJFADPKOK<string>.EFJIBBJEOLP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		public MGPCNPKFNKG preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		private BNJJFADPKOK<string>.EFJIBBJEOLP <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x83381D0", Offset = "0x83375D0", VA = "0x1883381D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x8338680", Offset = "0x8337A80", VA = "0x188338680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007BC")]
	private readonly PCHAPGOEFDK AEKLOJLBHLL;

	[Cpp2IlInjected.Token(Token = "0x40007BD")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public string BGGAPBFNMEL
	{
		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x832DD00", Offset = "0x832D100", VA = "0x18832DD00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x832DE40", Offset = "0x832D240", VA = "0x18832DE40")]
	[ACPGCKDGGJH.EHOIKNIBKMA.DOIDFDFNIIB]
	internal static void JFPDPLCMAPE(NPCGGDCACLM MIOIJELPIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	[RecRoom.NoEngine.Common.Preserve]
	public DMLNNHHNFAL([MGCCDFKFGBG(null)] PCHAPGOEFDK AEKLOJLBHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x832DD30", Offset = "0x832D130", VA = "0x18832DD30", Slot = "5")]
	[AsyncStateMachine(typeof(GLKABAMLHOG))]
	public Task ILOIMMFJAMD(BNJJFADPKOK<string>.EFJIBBJEOLP MOHPBCGNFBE, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x832DBE0", Offset = "0x832CFE0", VA = "0x18832DBE0")]
	[AsyncStateMachine(typeof(MLAFBPIMIHG))]
	private Task FEMGJNFHDLK(MGPCNPKFNKG AMALOEIAOPB, BNJJFADPKOK<string>.EFJIBBJEOLP MOHPBCGNFBE, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
public interface PCHAPGOEFDK : MGPCNPKFNKG
{
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
public interface MGPCNPKFNKG
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	string BGGAPBFNMEL
	{
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ILOIMMFJAMD(BNJJFADPKOK<string>.EFJIBBJEOLP MOHPBCGNFBE, CancellationToken JDDHIJBJNHP);
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
public static class IDACMNIHELH
{
	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x83342E0", Offset = "0x83336E0", VA = "0x1883342E0")]
	[ACPGCKDGGJH.EHOIKNIBKMA.DOIDFDFNIIB]
	internal static void OFPJHOBLCJH(NPCGGDCACLM MIOIJELPIBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
public interface OKAHFFFFHHK : IEquatable<OKAHFFFFHHK>
{
	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	DateTime AACGCACJMJK
	{
		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LCAJALKAIEL();

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NACECCMOIHB(long NFMLPECGLEO, long AKJILJJKOFL, [Out] BNHNOHNOJEM HOEAFNFMMDO);
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
internal class HDPNAPFHOKF : AGCKBMHAENJ
{
	[Cpp2IlInjected.Token(Token = "0x20001BE")]
	[CompilerGenerated]
	private sealed class FIPNIDOMMMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		public FOBHJDGLMCB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public FIPNIDOMMMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x832F560", Offset = "0x832E960", VA = "0x18832F560")]
		internal object DNLGDEFEFNL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007CB")]
	private readonly MCECFGCGNKA NOCMLBNMJPA;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<OKAHFFFFHHK> PBCILEOGODB
	{
		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x83327E0", Offset = "0x8331BE0", VA = "0x1883327E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x8333010", Offset = "0x8332410", VA = "0x188333010", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	[UnityEngine.Scripting.Preserve]
	public HDPNAPFHOKF([MGCCDFKFGBG(null)] MCECFGCGNKA NOCMLBNMJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x83324E0", Offset = "0x83318E0", VA = "0x1883324E0", Slot = "6")]
	public bool AMIKABIIOLG(long NFMLPECGLEO, long AKJILJJKOFL, BNHNOHNOJEM HOEAFNFMMDO, FOBHJDGLMCB CJFNFMAHILH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0xD85160", Offset = "0xD84560", VA = "0x180D85160")]
	private void LMKPLDEMLNN(OKAHFFFFHHK BPEIEPPOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x8332940", Offset = "0x8331D40", VA = "0x188332940", Slot = "7")]
	public bool DPNCCPJCDIC(long NFMLPECGLEO, long AKJILJJKOFL, [Out] OKAHFFFFHHK OLLDGDPALBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x8332890", Offset = "0x8331C90", VA = "0x188332890", Slot = "8")]
	public bool BPFCPKCLOKB(long NFMLPECGLEO, long AKJILJJKOFL, FOBHJDGLMCB CJFNFMAHILH, [Out] OKAHFFFFHHK OLLDGDPALBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x8332AB0", Offset = "0x8331EB0", VA = "0x188332AB0")]
	private void IIEECJFCDPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x8332EE0", Offset = "0x83322E0", VA = "0x188332EE0", Slot = "9")]
	public void OCNBBAFFJON(long NFMLPECGLEO, long AKJILJJKOFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
internal abstract class CAKDAAKMGCN : MCECFGCGNKA
{
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	protected enum LMGEJGNJHNA : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[CompilerGenerated]
	private sealed class FGBOCDOPIHP : IEnumerable<OKAHFFFFHHK>, IEnumerable, IEnumerator<OKAHFFFFHHK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private OKAHFFFFHHK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		public CAKDAAKMGCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		private FOBHJDGLMCB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		public FOBHJDGLMCB <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		private OKAHFFFFHHK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xE69660", Offset = "0xE68A60", VA = "0x180E69660")]
		[DebuggerHidden]
		public FGBOCDOPIHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x832ED20", Offset = "0x832E120", VA = "0x18832ED20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x832F000", Offset = "0x832E400", VA = "0x18832F000", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x832EF50", Offset = "0x832E350", VA = "0x18832EF50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OKAHFFFFHHK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x832EF50", Offset = "0x832E350", VA = "0x18832EF50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[CompilerGenerated]
	private sealed class IDHDOEDBPNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		public FOBHJDGLMCB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DE")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public IDHDOEDBPNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x83346F0", Offset = "0x8333AF0", VA = "0x1883346F0")]
		internal object KBLJEKGMCCC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C4")]
	[CompilerGenerated]
	private sealed class AOHLHFGCLDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DF")]
		public CAKDAAKMGCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E0")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AOHLHFGCLDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x832A030", Offset = "0x8329430", VA = "0x18832A030")]
		internal void LOIJKDCBPOP(OIGNJGNCDAK.GDMJABNKMGN ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007D1")]
	private readonly object EMGLFDBBBGP;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	protected string LGOJFNJINAO
	{
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x832B430", Offset = "0x832A830", VA = "0x18832B430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public abstract FKMELKFKKAA EMLMKAEMLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x832B440", Offset = "0x832A840", VA = "0x18832B440")]
	protected CAKDAAKMGCN([CanBeNull] string MFNCLPAFMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x832ADF0", Offset = "0x832A1F0", VA = "0x18832ADF0", Slot = "5")]
	public bool FKEABMNPMIA(long NFMLPECGLEO, long AKJILJJKOFL, FOBHJDGLMCB CJFNFMAHILH, [Out] OKAHFFFFHHK BPEIEPPOFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x832AFE0", Offset = "0x832A3E0", VA = "0x18832AFE0", Slot = "6")]
	[IteratorStateMachine(typeof(FGBOCDOPIHP))]
	public IEnumerable<OKAHFFFFHHK> HGPDAACFOCJ(FOBHJDGLMCB CJFNFMAHILH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void MAMKFGAMANP(Stream GJGPEBKGFCA, long NFMLPECGLEO, long AKJILJJKOFL, BNHNOHNOJEM HOEAFNFMMDO);

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool NHJIGGMCPEG(Stream FNPHGGBNGHN, long NFMLPECGLEO, long AKJILJJKOFL, BOCNODFKAEI GAFDMDOICGL, [Out] BNHNOHNOJEM HOEAFNFMMDO);

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x832AA00", Offset = "0x8329E00", VA = "0x18832AA00", Slot = "7")]
	public OKAHFFFFHHK EADFICBHPOJ(long NFMLPECGLEO, long AKJILJJKOFL, BNHNOHNOJEM HOEAFNFMMDO, FOBHJDGLMCB CJFNFMAHILH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo LEJNPIIKIAP(long NFMLPECGLEO, long AKJILJJKOFL, FOBHJDGLMCB CJFNFMAHILH, LMGEJGNJHNA PPHEHFJBMBF);

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo EPDKAEPNOEP(FOBHJDGLMCB CJFNFMAHILH, LMGEJGNJHNA PPHEHFJBMBF);

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x832AD80", Offset = "0x832A180", VA = "0x18832AD80")]
	protected void EBEHIGJKDID(OIGNJGNCDAK.GDMJABNKMGN GGPNCFGCIKC, string BNFNFAFOAGE, FileInfo COOPBNBODFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x832B070", Offset = "0x832A470", VA = "0x18832B070")]
	internal bool IGBACODOLLP(FileInfo MAAEFAMDLPE, long NFMLPECGLEO, long AKJILJJKOFL, [Out] BNHNOHNOJEM HOEAFNFMMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	private void JINJDLHIAPE(Exception COANEMFJDAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
internal class FAHDALCEMPB : CAKDAAKMGCN
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public override FKMELKFKKAA EMLMKAEMLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x1D30C30", Offset = "0x1D30030", VA = "0x181D30C30", Slot = "8")]
		get
		{
			return default(FKMELKFKKAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x832ECE0", Offset = "0x832E0E0", VA = "0x18832ECE0")]
	public FAHDALCEMPB([Optional] string MFNCLPAFMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x832EC60", Offset = "0x832E060", VA = "0x18832EC60")]
	private void OALLLNGDGEC(FOBHJDGLMCB CJFNFMAHILH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x832E2B0", Offset = "0x832D6B0", VA = "0x18832E2B0", Slot = "9")]
	internal override void MAMKFGAMANP(Stream GJGPEBKGFCA, long NFMLPECGLEO, long AKJILJJKOFL, BNHNOHNOJEM HOEAFNFMMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x832E560", Offset = "0x832D960", VA = "0x18832E560", Slot = "10")]
	internal override bool NHJIGGMCPEG(Stream FNPHGGBNGHN, long NFMLPECGLEO, long AKJILJJKOFL, BOCNODFKAEI GAFDMDOICGL, [Out] BNHNOHNOJEM HOEAFNFMMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x832E1C0", Offset = "0x832D5C0", VA = "0x18832E1C0", Slot = "11")]
	protected override FileInfo LEJNPIIKIAP(long NFMLPECGLEO, long AKJILJJKOFL, FOBHJDGLMCB CJFNFMAHILH, LMGEJGNJHNA PPHEHFJBMBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x832E0C0", Offset = "0x832D4C0", VA = "0x18832E0C0", Slot = "12")]
	protected override DirectoryInfo EPDKAEPNOEP(FOBHJDGLMCB CJFNFMAHILH, LMGEJGNJHNA PPHEHFJBMBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
internal sealed class KNJMOJLJPFH : CAKDAAKMGCN
{
	[Cpp2IlInjected.Token(Token = "0x40007E1")]
	private static readonly byte[] IICGAABOENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007E2")]
	private readonly byte[] CJEPLOICDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007E3")]
	private readonly byte[] LIOPNBOGAHB;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public override FKMELKFKKAA EMLMKAEMLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x6DFC920", Offset = "0x6DFBD20", VA = "0x186DFC920", Slot = "8")]
		get
		{
			return default(FKMELKFKKAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x8336C80", Offset = "0x8336080", VA = "0x188336C80")]
	public KNJMOJLJPFH([Optional] string MFNCLPAFMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x8335D60", Offset = "0x8335160", VA = "0x188335D60", Slot = "9")]
	internal override void MAMKFGAMANP(Stream GJGPEBKGFCA, long NFMLPECGLEO, long AKJILJJKOFL, BNHNOHNOJEM HOEAFNFMMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x8336180", Offset = "0x8335580", VA = "0x188336180", Slot = "10")]
	internal override bool NHJIGGMCPEG(Stream FNPHGGBNGHN, long NFMLPECGLEO, long AKJILJJKOFL, BOCNODFKAEI GAFDMDOICGL, [Out] BNHNOHNOJEM HOEAFNFMMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x8335A60", Offset = "0x8334E60", VA = "0x188335A60")]
	private void AAGJCICNKEN(byte[] FLIFCMNPFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x8335C30", Offset = "0x8335030", VA = "0x188335C30", Slot = "11")]
	protected override FileInfo LEJNPIIKIAP(long NFMLPECGLEO, long AKJILJJKOFL, FOBHJDGLMCB CJFNFMAHILH, LMGEJGNJHNA PPHEHFJBMBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x8335B20", Offset = "0x8334F20", VA = "0x188335B20", Slot = "12")]
	protected override DirectoryInfo EPDKAEPNOEP(FOBHJDGLMCB CJFNFMAHILH, LMGEJGNJHNA PPHEHFJBMBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
public enum FKMELKFKKAA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40007E7")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40007E8")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40007E9")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
internal class HJCJNAKNFKE : MCECFGCGNKA
{
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	[CompilerGenerated]
	private sealed class GKFDHBHOMJB : IEnumerable<OKAHFFFFHHK>, IEnumerable, IEnumerator<OKAHFFFFHHK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private OKAHFFFFHHK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		public HJCJNAKNFKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		private FOBHJDGLMCB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		public FOBHJDGLMCB <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		private FKMELKFKKAA[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		private IEnumerator<OKAHFFFFHHK> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		private OKAHFFFFHHK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xE69660", Offset = "0xE68A60", VA = "0x180E69660")]
		[DebuggerHidden]
		public GKFDHBHOMJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x8330780", Offset = "0x832FB80", VA = "0x188330780", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x83303A0", Offset = "0x832F7A0", VA = "0x1883303A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x8330350", Offset = "0x832F750", VA = "0x188330350")]
		private void BIIMICBPMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x8330730", Offset = "0x832FB30", VA = "0x188330730", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x8330680", Offset = "0x832FA80", VA = "0x188330680", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OKAHFFFFHHK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x8330680", Offset = "0x832FA80", VA = "0x188330680", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007EA")]
	private readonly FKMELKFKKAA[] GKHFJKCNCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007EB")]
	private readonly Dictionary<FKMELKFKKAA, MCECFGCGNKA> MOMIIAKLAGK;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public FKMELKFKKAA EMLMKAEMLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x83338F0", Offset = "0x8332CF0", VA = "0x1883338F0", Slot = "4")]
		get
		{
			return default(FKMELKFKKAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x8333920", Offset = "0x8332D20", VA = "0x188333920")]
	[UnityEngine.Scripting.Preserve]
	public HJCJNAKNFKE(params MCECFGCGNKA[] FHFHJHJEGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x83334D0", Offset = "0x83328D0", VA = "0x1883334D0", Slot = "5")]
	public bool FKEABMNPMIA(long NFMLPECGLEO, long AKJILJJKOFL, FOBHJDGLMCB CJFNFMAHILH, [Out] OKAHFFFFHHK BPEIEPPOFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x8333620", Offset = "0x8332A20", VA = "0x188333620")]
	private void FPGDOHABCGG(int CJAKBNAPBOM, long NFMLPECGLEO, long AKJILJJKOFL, FOBHJDGLMCB CJFNFMAHILH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x8333860", Offset = "0x8332C60", VA = "0x188333860", Slot = "6")]
	[IteratorStateMachine(typeof(GKFDHBHOMJB))]
	public IEnumerable<OKAHFFFFHHK> HGPDAACFOCJ(FOBHJDGLMCB CJFNFMAHILH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x83333E0", Offset = "0x83327E0", VA = "0x1883333E0", Slot = "7")]
	public OKAHFFFFHHK EADFICBHPOJ(long NFMLPECGLEO, long AKJILJJKOFL, BNHNOHNOJEM HOEAFNFMMDO, FOBHJDGLMCB CJFNFMAHILH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
internal static class HEGMHDHJJAL
{
	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x8333320", Offset = "0x8332720", VA = "0x188333320")]
	internal static byte[] GNGFGDFMJPO(byte[] FLIFCMNPFIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x83332A0", Offset = "0x83326A0", VA = "0x1883332A0")]
	public static void EHIEKMEJBCP(Stream AJOPCIKNIMD, byte[] LLODIBAACNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x83330C0", Offset = "0x83324C0", VA = "0x1883330C0")]
	public static bool DEIMGODBBAF(Stream AJOPCIKNIMD, long INIFFGAGCAL, BOCNODFKAEI NFDGACFBAIK, [Out] byte[] PNNHFFOPKGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
internal sealed class KONKGPLIMOO : OKAHFFFFHHK, IEquatable<OKAHFFFFHHK>, IEquatable<KONKGPLIMOO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F9")]
	private readonly CAKDAAKMGCN CJFBHGFFCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007FA")]
	public readonly FileInfo BKLJEFFIIEO;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public FKMELKFKKAA EMLMKAEMLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E400", Offset = "0x7C0D800", VA = "0x187C0E400", Slot = "9")]
		get
		{
			return default(FKMELKFKKAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public DateTime AACGCACJMJK
	{
		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x83370E0", Offset = "0x83364E0", VA = "0x1883370E0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x8337260", Offset = "0x8336660", VA = "0x188337260")]
	public KONKGPLIMOO(CAKDAAKMGCN NJPGPBOPMPM, FileInfo MAAEFAMDLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x83371B0", Offset = "0x83365B0", VA = "0x1883371B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x8337020", Offset = "0x8336420", VA = "0x188337020", Slot = "5")]
	public void LCAJALKAIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x8337170", Offset = "0x8336570", VA = "0x188337170", Slot = "6")]
	public bool NACECCMOIHB(long NFMLPECGLEO, long AKJILJJKOFL, [Out] BNHNOHNOJEM HOEAFNFMMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x8336D70", Offset = "0x8336170", VA = "0x188336D70", Slot = "7")]
	public bool Equals(OKAHFFFFHHK DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x8336DE0", Offset = "0x83361E0", VA = "0x188336DE0", Slot = "8")]
	public bool Equals(KONKGPLIMOO DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x8336EA0", Offset = "0x83362A0", VA = "0x188336EA0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x8336F90", Offset = "0x8336390", VA = "0x188336F90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
public delegate void BOCNODFKAEI(OIGNJGNCDAK.GDMJABNKMGN EIHHNGOHNFK, string FGEBHLNNMNH);
[Cpp2IlInjected.Token(Token = "0x20001CF")]
internal interface MCECFGCGNKA
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	FKMELKFKKAA EMLMKAEMLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FKEABMNPMIA(long NFMLPECGLEO, long AKJILJJKOFL, FOBHJDGLMCB CJFNFMAHILH, [Out] OKAHFFFFHHK BPEIEPPOFBB);

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<OKAHFFFFHHK> HGPDAACFOCJ(FOBHJDGLMCB CJFNFMAHILH);

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OKAHFFFFHHK EADFICBHPOJ(long NFMLPECGLEO, long AKJILJJKOFL, BNHNOHNOJEM HOEAFNFMMDO, FOBHJDGLMCB CJFNFMAHILH);
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
