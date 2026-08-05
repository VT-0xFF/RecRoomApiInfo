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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82F2E10", Offset = "0x82F1610", VA = "0x1882F2E10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
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
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82F1020", Offset = "0x82EF820", VA = "0x1882F1020", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82F6870", Offset = "0x82F5070", VA = "0x1882F6870", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2612DF0", Offset = "0x26115F0", VA = "0x182612DF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FICMIHOELOB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x82DCE30", Offset = "0x82DB630", VA = "0x1882DCE30")]
	public FICMIHOELOB(string NJAAPDELBNN, Exception CLGGKPBHAHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class ICPDMLDLLMN : LNPKHOLALEI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct PNGBMAGLODO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<BMPGFEIBEIF>> <>t__builder;

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
		private TaskAwaiter<ANJHPPEHIAC<OMKFKAIDNEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82F5380", Offset = "0x82F3B80", VA = "0x1882F5380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82F55C0", Offset = "0x82F3DC0", VA = "0x1882F55C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OPBPNHNOBFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<MHDMOHJIDLA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<MHDMOHJIDLA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82F2FC0", Offset = "0x82F17C0", VA = "0x1882F2FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82F31D0", Offset = "0x82F19D0", VA = "0x1882F31D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	[UnityEngine.Scripting.Preserve]
	public ICPDMLDLLMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82E0DA0", Offset = "0x82DF5A0", VA = "0x1882E0DA0", Slot = "4")]
	[AsyncStateMachine(typeof(PNGBMAGLODO))]
	public Task<IReadOnlyList<BMPGFEIBEIF>> JEJDALMHDJJ(long MDLDCACFGIB, long DBEJCKJKFPB, [Optional] CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x82E0C90", Offset = "0x82DF490", VA = "0x1882E0C90", Slot = "5")]
	[AsyncStateMachine(typeof(OPBPNHNOBFJ))]
	public Task<IReadOnlyList<MHDMOHJIDLA>> CPLBBJJEOAA(IReadOnlyList<int> PHOFJMNHHBH, [Optional] CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GMOIMCBJOEI : IEquatable<GMOIMCBJOEI>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int IJKOEAFCLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	MHDMOHJIDLA MFLLLDKDMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime CGCJELJFIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IAHCCPKAHLI? BDNGKFKCPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GCEOHBAELHJ? EGFODGFJMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	CGDJFLAMOMA ECNHDKNFKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<MJOPCCNIMCA> PJMOGIGIAPN();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum CGDJFLAMOMA
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LNPKHOLALEI
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<BMPGFEIBEIF>> JEJDALMHDJJ(long MDLDCACFGIB, long DBEJCKJKFPB, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<MHDMOHJIDLA>> CPLBBJJEOAA(IReadOnlyList<int> PHOFJMNHHBH, [Optional] CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class COOBOHAELDF
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class KNHECOPDFLI : GMOIMCBJOEI, IEquatable<GMOIMCBJOEI>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct KJNJOFFIBHI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<MJOPCCNIMCA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public KNHECOPDFLI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private BGPDBLKFCBP <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<HCHPFAEFOMI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<MJOPCCNIMCA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x82EC1E0", Offset = "0x82EA9E0", VA = "0x1882EC1E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x82EC770", Offset = "0x82EAF70", VA = "0x1882EC770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly BMPGFEIBEIF CCOLMDHOFJP;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int IJKOEAFCLJA
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MHDMOHJIDLA MFLLLDKDMHP
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime AEALOLCCNPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x82ECF40", Offset = "0x82EB740", VA = "0x1882ECF40", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IAHCCPKAHLI? BDNGKFKCPEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6BB07A0", Offset = "0x6BAEFA0", VA = "0x186BB07A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public GCEOHBAELHJ? EGFODGFJMCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x297C150", Offset = "0x297A950", VA = "0x18297C150", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CGDJFLAMOMA ECNHDKNFKEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xBCB360", Offset = "0xBC9B60", VA = "0x180BCB360", Slot = "10")]
			get
			{
				return default(CGDJFLAMOMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x82ECF60", Offset = "0x82EB760", VA = "0x1882ECF60", Slot = "9")]
		[AsyncStateMachine(typeof(KJNJOFFIBHI))]
		public Task<MJOPCCNIMCA> PJMOGIGIAPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x82ED060", Offset = "0x82EB860", VA = "0x1882ED060")]
		public KNHECOPDFLI(int OEPIIGKEJNH, MHDMOHJIDLA KFAFCGFMFIJ, BMPGFEIBEIF CCOLMDHOFJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x82ECE30", Offset = "0x82EB630", VA = "0x1882ECE30", Slot = "11")]
		public bool Equals(GMOIMCBJOEI PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x82ECD90", Offset = "0x82EB590", VA = "0x1882ECD90", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x82ECD50", Offset = "0x82EB550", VA = "0x1882ECD50")]
		private bool DBHJAHHABJP(KNHECOPDFLI PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x82ECEC0", Offset = "0x82EB6C0", VA = "0x1882ECEC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class APNJFLIDDFA : GMOIMCBJOEI, IEquatable<GMOIMCBJOEI>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct JBJPMJPNGHM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<MJOPCCNIMCA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public APNJFLIDDFA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<MJOPCCNIMCA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x82E45F0", Offset = "0x82E2DF0", VA = "0x1882E45F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x82E4840", Offset = "0x82E3040", VA = "0x1882E4840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly GANHOFFPCAM MBFHHPHLJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly IAHCCPKAHLI EDBEKMADIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly GCEOHBAELHJ JFHPEACAFCA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int IJKOEAFCLJA
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x82D8C40", Offset = "0x82D7440", VA = "0x1882D8C40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MHDMOHJIDLA MFLLLDKDMHP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x82D8EF0", Offset = "0x82D76F0", VA = "0x1882D8EF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime AEALOLCCNPD
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x82D8EA0", Offset = "0x82D76A0", VA = "0x1882D8EA0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IAHCCPKAHLI? BDNGKFKCPEE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x82D8E50", Offset = "0x82D7650", VA = "0x1882D8E50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public GCEOHBAELHJ? EGFODGFJMCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x82D8F80", Offset = "0x82D7780", VA = "0x1882D8F80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public CGDJFLAMOMA ECNHDKNFKEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xBB4EE0", Offset = "0xBB36E0", VA = "0x180BB4EE0", Slot = "10")]
			get
			{
				return default(CGDJFLAMOMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1E216F0", Offset = "0x1E1FEF0", VA = "0x181E216F0")]
		public APNJFLIDDFA(GANHOFFPCAM NPNJHLNLNMP, IAHCCPKAHLI IEDBPDLCDHK, GCEOHBAELHJ AHLMOBKAJMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x82D8FD0", Offset = "0x82D77D0", VA = "0x1882D8FD0", Slot = "9")]
		[AsyncStateMachine(typeof(JBJPMJPNGHM))]
		public Task<MJOPCCNIMCA> PJMOGIGIAPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x82D8C80", Offset = "0x82D7480", VA = "0x1882D8C80", Slot = "11")]
		public bool Equals(GMOIMCBJOEI PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82D8D20", Offset = "0x82D7520", VA = "0x1882D8D20", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x82D8BE0", Offset = "0x82D73E0", VA = "0x1882D8BE0")]
		private bool DBHJAHHABJP(APNJFLIDDFA PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82D8DD0", Offset = "0x82D75D0", VA = "0x1882D8DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class HDBNPNOONDP : GMOIMCBJOEI, IEquatable<GMOIMCBJOEI>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct CBJNDGPDMBO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<MJOPCCNIMCA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<MJOPCCNIMCA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x82D9380", Offset = "0x82D7B80", VA = "0x1882D9380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x82D95E0", Offset = "0x82D7DE0", VA = "0x1882D95E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly MHDMOHJIDLA EJFJPLMICGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly IAHCCPKAHLI EDBEKMADIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly GCEOHBAELHJ JFHPEACAFCA;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int IJKOEAFCLJA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x82DEA90", Offset = "0x82DD290", VA = "0x1882DEA90", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public MHDMOHJIDLA MFLLLDKDMHP
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime AEALOLCCNPD
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IAHCCPKAHLI? BDNGKFKCPEE
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x82DEC30", Offset = "0x82DD430", VA = "0x1882DEC30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public GCEOHBAELHJ? EGFODGFJMCP
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x82DEC80", Offset = "0x82DD480", VA = "0x1882DEC80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public CGDJFLAMOMA ECNHDKNFKEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "10")]
			get
			{
				return default(CGDJFLAMOMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1E216F0", Offset = "0x1E1FEF0", VA = "0x181E216F0")]
		public HDBNPNOONDP(MHDMOHJIDLA KFAFCGFMFIJ, IAHCCPKAHLI IEDBPDLCDHK, GCEOHBAELHJ AHLMOBKAJMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82DECD0", Offset = "0x82DD4D0", VA = "0x1882DECD0", Slot = "9")]
		[AsyncStateMachine(typeof(CBJNDGPDMBO))]
		public Task<MJOPCCNIMCA> PJMOGIGIAPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x82DEB30", Offset = "0x82DD330", VA = "0x1882DEB30", Slot = "11")]
		public bool Equals(GMOIMCBJOEI PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x82DEAB0", Offset = "0x82DD2B0", VA = "0x1882DEAB0", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82DEBA0", Offset = "0x82DD3A0", VA = "0x1882DEBA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x82DE9B0", Offset = "0x82DD1B0", VA = "0x1882DE9B0")]
		private bool DBHJAHHABJP(HDBNPNOONDP PGPJMFPAKOO)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct PJJDEGOIGOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<GMOIMCBJOEI>> <>t__builder;

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
		public COOBOHAELDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<BMPGFEIBEIF> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<BMPGFEIBEIF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, MHDMOHJIDLA account, BMPGFEIBEIF roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x82F44D0", Offset = "0x82F2CD0", VA = "0x1882F44D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x82F5310", Offset = "0x82F3B10", VA = "0x1882F5310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct MFLIEPEEMNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, MHDMOHJIDLA account, BMPGFEIBEIF roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<BMPGFEIBEIF> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public COOBOHAELDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<MHDMOHJIDLA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x82F13A0", Offset = "0x82EFBA0", VA = "0x1882F13A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x82F1D70", Offset = "0x82F0570", VA = "0x1882F1D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FLFFJCDCPLP IPKHIIMGMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly LNPKHOLALEI FHFOLNGAPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly CLIJODHNBOD CDOEHECELPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly KIIGOKDGLEA<(long, long), IReadOnlyList<BMPGFEIBEIF>> NLHEECMJPDE;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x82DA270", Offset = "0x82D8A70", VA = "0x1882DA270")]
	[UnityEngine.Scripting.Preserve]
	public COOBOHAELDF([LDAFGEHKDJK(null)] LNPKHOLALEI FDFMNDAGMBO, [LDAFGEHKDJK(null)] CLIJODHNBOD ADDHPLJHCMA, [LDAFGEHKDJK(null)] FLFFJCDCPLP KKMAMIPLKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x82D9E70", Offset = "0x82D8670", VA = "0x1882D9E70")]
	[AsyncStateMachine(typeof(PJJDEGOIGOM))]
	public Task<IList<GMOIMCBJOEI>> HPEDFAMHNKK(long MDLDCACFGIB, long ODGNDMLNOIH, bool AJAFGADKIFL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x82D9FC0", Offset = "0x82D87C0", VA = "0x1882D9FC0")]
	private bool MNCKGOJNNEL(DateTime? BPBLNADHNLE, long MDLDCACFGIB, long ODGNDMLNOIH, [Out] GANHOFFPCAM EFAOGHPAKDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82DA160", Offset = "0x82D8960", VA = "0x1882DA160")]
	[AsyncStateMachine(typeof(MFLIEPEEMNI))]
	private Task<IReadOnlyList<(int, MHDMOHJIDLA, BMPGFEIBEIF)>> PNDHBDIFDJN(IReadOnlyList<BMPGFEIBEIF> CMNBOCEJGOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CLIJODHNBOD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GANHOFFPCAM> MINBHPPHPHB;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JLPAGNNLABJ(long MDLDCACFGIB, long ODGNDMLNOIH, MKHFNGCIHMI EAIJCJBEHLN, OCGCHDNKCFE FGGEEODNNKF);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PHJDGEKKIIO(long MDLDCACFGIB, long ODGNDMLNOIH, [Out] GANHOFFPCAM EFAOGHPAKDG);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MOLDMIABLLA(long MDLDCACFGIB, long ODGNDMLNOIH, OCGCHDNKCFE FGGEEODNNKF, [Out] GANHOFFPCAM EFAOGHPAKDG);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MFOOCKFFCAC(long MDLDCACFGIB, long ODGNDMLNOIH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface BGNAANIBOJP : OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DDDABECNMFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task AENIANANJKN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FOGBDKOCDHI(Task BFOIMBMKJIA, string GBMKDNJEGLB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface CEGLHANHICO : OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MJOPCCNIMCA> GDLFNIDJDBA(GANHOFFPCAM EFAOGHPAKDG);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BCBOFHFGMPJ(CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface CJPJONPIBFJ : OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	HBIANJDPELM ADABGMEEMNG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHBIJIEOFMG();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NOFGADBABPF();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface OACHLMNKJAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPIOKLMMDIH(IBNHMOEDCKG CDLOFOIHHCC);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface BOHPHODOLDK
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan AJDGANOGBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan DKNDLNBMPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan LGHMBPCHFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan NFECCNAHFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool FANNOIFGLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool CNCKHKBCLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool HGNAPADGLBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int NLBEGEOCOAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool FFIMFHCNAEO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool AFFBECKCICD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool MMOOICCICFE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum JOGKJLAEJOO
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum BIAEOMGDAEE
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
public struct DEALDLCNIEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long CNECHKELGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long DBEJCKJKFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly JOGKJLAEJOO PIJHKCJDAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception NDJACLAJANO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x82DAAE0", Offset = "0x82D92E0", VA = "0x1882DAAE0")]
	public DEALDLCNIEC(long CNECHKELGPE, long DBEJCKJKFPB, JOGKJLAEJOO PIJHKCJDAHO, [CanBeNull] Exception NDJACLAJANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x82DAA90", Offset = "0x82D9290", VA = "0x1882DAA90")]
	public static DEALDLCNIEC FJFLDAKDOLM(ADDOLAOCDBG NDMNFOPCPLE, JOGKJLAEJOO PIJHKCJDAHO, [Optional] Exception NDJACLAJANO)
	{
		return default(DEALDLCNIEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void JKPHLHNDBHC(DEALDLCNIEC PDKLKKAPOEG);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface KOLJJJIKCKA : OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action JDKDJMGELEC;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event JKPHLHNDBHC HCBBKOMDAFN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JKPHLHNDBHC FCMGHBLDAFB;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event JKPHLHNDBHC OJPBAADMLKK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<BIAEOMGDAEE, bool> ALGAABMIGKK;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PNGFNJIGIFN();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ALFKPBPLALC(DEALDLCNIEC PDKLKKAPOEG);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JBLFBLGPAHJ(DEALDLCNIEC PDKLKKAPOEG);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MLGAOFOHFFB(DEALDLCNIEC PDKLKKAPOEG);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FEGPJFKGKHD(BIAEOMGDAEE LBCFNOHNLPL, bool EJCCGIABFNE);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface CIAEDAHKOKG : OACHLMNKJAD, IDisposable
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
	bool KKCHAJMNDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JDPBAFLJDFC(Reason NLGEMFKLFCF = Reason.Unknown);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IDGIMBAHGKM();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface IIBBCEMMFDM : OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus OAAOOKAPDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JDCJNIJLFNC(ADDOLAOCDBG NDOAKLELACH, DPNGIIIGHEF CPFLDOKAPNJ, CancellationToken HPBFCDCKFAO);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class ALADDPPDMKP
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x82D7FC0", Offset = "0x82D67C0", VA = "0x1882D7FC0")]
	public static bool FEBPAOKIKII(this IIBBCEMMFDM FNDMBKNLKKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task HCLIEADMJEL(CancellationToken JILOCOLKOMJ, int ECEJAIGHIDI, COICKFBCMHF LFBAMJJFDKL);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface PKGLAMNHGHN : OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NMGIPDOKCJM(HCLIEADMJEL LCEGJIKNJEL);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface IBNHMOEDCKG : BGPDBLKFCBP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken DAKDKHPKJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	HHDGAAFLDEF LGKEMEBACIO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	FOAMNLJKJEK CCPKGAGGNLL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	GOGPOCOGOBL HLPHAHDIGII
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	DHHGNBFICMC PILJEFNINPM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	ICFBADGDCHF JGBKILABOBL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	BPHMPAJBIBK FLLJNCGCAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	IKDBLDBFNFM AHOONCJDJNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	ECOIGKPCBDF FPIKEDAGDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	BGNAANIBOJP MILOOHLDNIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	CEGLHANHICO NEGHFJGHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	KOLJJJIKCKA CKBFNFODMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	CIAEDAHKOKG KMAHNCGFNNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	IIBBCEMMFDM CBLCGPINHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	PKGLAMNHGHN LCELOIDGBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	AKBEMKDEJEH MGJPCLFNLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	LIBAMEGNOIL KKHIDLLCJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	NJHHJFPHOAK CFEGHBJOHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	LDMDOMDMHPI KHKPOPFDGHH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	OODEDDNEKOO MPIBCLEGFPO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ADNGNJCDMJO HBLNIEJOOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	HOKEHILMPLD DPKOJIMDGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	KGFCPCHMJMI DOKCHALLLDN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	LPGCMMDJHFF KGDICPEMCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	KBEBBAGNJGJ FHAMLFKOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	CJPJONPIBFJ BFNLJDJGPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	BOHPHODOLDK MFJHBAICAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	GJLIIHMFEJN COEKPBMKLJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	CLIJODHNBOD CFLOLJFONFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	IOECHHPJIMN NGINGJCEIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	OFLKHHIPKIE GKEPPNGNEJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	PDHBLMAPBNH HGCJBLIBOME
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	PPIGJJKFIEK MIHBPEJPMMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool PNMHOFOLMAH
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
	void KEMIEPMCLCN(DPNGIIIGHEF ALHDPOKAEEC);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface AKBEMKDEJEH : OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EAJOEMNKDCL OIHLAKEIFNH(Guid KJHDGFKNPKN);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AHELLINFOCL(Guid KJHDGFKNPKN);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MFIBGEFACIJ(Guid KJHDGFKNPKN, Task KJGICOEAHJI);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JKEIOABIKAI(Guid KJHDGFKNPKN, MJOPCCNIMCA KHFCOAIANDB);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(MJOPCCNIMCA, Task)> KDKBDHLMKOM(Guid KJHDGFKNPKN);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface JCODMPBACKM : OACHLMNKJAD, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface LIBAMEGNOIL : OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LENHNEOICHO(NBCEMMDCCGB NJAAPDELBNN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGAOPFGHMPC(NBCEMMDCCGB NJAAPDELBNN);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<HLOJBJMGFLA> HIEINKOCEDG(CancellationToken GPIMMPEOKPL);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface NJHHJFPHOAK : OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EAJOEMNKDCL CMAEIEKPKAM(NBCEMMDCCGB OJOJFGLINHG);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOMADIIOHAE(Guid KJHDGFKNPKN, Task KJGICOEAHJI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface LDMDOMDMHPI : OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MJOPCCNIMCA> KHKPOPFDGHH(NBCEMMDCCGB ACANOPILGDO);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface OODEDDNEKOO : OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HHEFLMKOLLI> FMMDJHKKPLA(BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, ADDOLAOCDBG NDOAKLELACH, CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface HOKEHILMPLD : OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MJOPCCNIMCA LOFLJLLBAOF(GFEBJDBBDID NEFBNPHEJEC);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BOIAKFMJFOJ(string CGOKOPBMMLE);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface ADNGNJCDMJO : OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NBCEMMDCCGB> IDOMMNGOOPL(NBCEMMDCCGB JHLBOHEIAIJ, ABNJELCGKNH BEHMGGPGCPF, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<NBCEMMDCCGB> KDAOCFMMJNC(CancellationToken DNHBNMHIDAC, ABNJELCGKNH BEHMGGPGCPF);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JIJPPLMKGGB OFCCPCHBNEL(LMDCPPPCHDP BHGMCKEPELK, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JIJPPLMKGGB ALBICNEOHBJ(LMDCPPPCHDP BHGMCKEPELK, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface KGFCPCHMJMI : OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MJOPCCNIMCA NHKHIFHDCHF(GFEBJDBBDID NEFBNPHEJEC, HLOJBJMGFLA JAFKFKLBIBG);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MJOPCCNIMCA LOPLNEBPAKB(GFEBJDBBDID JJLLGPNLOHI);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface NLDGDOGNBHB
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	const int EADLCPFFAHO = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, MLAMBOHBOIB> DHPDLINGOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action KAHDIOADKHM
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
	IReadOnlyList<Guid> HKGGEBNBCCJ();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task HBHKHOPKIAA([Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task GEIEMOMFEKM([Optional] CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface LPGCMMDJHFF
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAMFBLOBACH(GJDGFHACGHA HHIEDCKCAGN);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CHIDOOBDPFO(GJDGFHACGHA HHIEDCKCAGN);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPMCECNNEOP(GJDGFHACGHA HHIEDCKCAGN);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ICFMBLEMCFK(GJDGFHACGHA HHIEDCKCAGN);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class GJDGFHACGHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly ADDOLAOCDBG ONGFDGHMEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Dictionary<string, string> HDNLMFOACIP;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public BGHFCMFIENI<string> PLFAMBGJAMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public GJDGFHACGHA(ADDOLAOCDBG CDFKPNNAMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x82DDA90", Offset = "0x82DC290", VA = "0x1882DDA90")]
	public GJDGFHACGHA LEFMOPGHBEB(string BELIEAFHDAH, string OPMIAMEJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x82DDB60", Offset = "0x82DC360", VA = "0x1882DDB60")]
	public bool OMPLPLBACNF([Out] IEnumerable<KeyValuePair<string, string>> LPBOJHGMEDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x71D6740", Offset = "0x71D4F40", VA = "0x1871D6740")]
	public GJDGFHACGHA IKJHAAKIFHO(BGHFCMFIENI<string> NIBJMJJGOBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface GJLIIHMFEJN
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool ENEHOCCBMEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string JFACFNIBKPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool ALAPLCDLBBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LEMFLOCFBFL();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MKMFJMPKGKL JPAIILIMGOL(long PAHLPEDOKGC);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DBGMCEFPAHH<COMDBKPAHPB, NLICKNHNJCI> HIOJLPIFEAL(long PAHLPEDOKGC);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DBGMCEFPAHH<COMDBKPAHPB, IOKANKGCBIH> EJAKGBBPAHG(long PAHLPEDOKGC);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DBGMCEFPAHH<long, OKGNGFGOKMI> LKOKKHGNJAN();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<CABHDLHGNPC>> DGNMAELKOOI(long PAHLPEDOKGC, IReadOnlyCollection<CABHDLHGNPC> CNMOJJGILEF, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool AHEGGGKNDDC(long PAHLPEDOKGC, [Out] bool AKDCFELFGHE);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> KDOKOCJPMKA(byte[] GDDBLNGCPFI, byte[] DIJEEBBCAAD, IReadOnlyCollection<Guid> HILPBLCHKPB, CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface JIDDILENHDB
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HHEFLMKOLLI NKIHIDGHACP(long CNECHKELGPE, long DBEJCKJKFPB, string KJCMLLPPGED);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HHEFLMKOLLI NKIHIDGHACP(long CNECHKELGPE, long DBEJCKJKFPB, COMDBKPAHPB GDDBLNGCPFI, Guid? HCHIFCCLLCA, long AEGGFNGPLLP, bool DIMNOKFJGPP);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HHEFLMKOLLI NKIHIDGHACP(EEIBBLLOKKE BFBCBOCDJKN);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HHEFLMKOLLI NKIHIDGHACP(HCHPFAEFOMI POGHHKALCGK, BMPGFEIBEIF CNNDIOOCMEL);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface BGPDBLKFCBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool FEBPAOKIKII
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool CDPNKNFIJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool PNMHOFOLMAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	JIDDILENHDB DCGHBKOKAEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	DPNGIIIGHEF CMOLFOCKLPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action JDKDJMGELEC;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event JKPHLHNDBHC HCBBKOMDAFN;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event JKPHLHNDBHC FCMGHBLDAFB;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event JKPHLHNDBHC OJPBAADMLKK;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<BIAEOMGDAEE, bool> ALGAABMIGKK;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IDGIMBAHGKM();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	LGNELIMGMHE PEJAFHEIAKD();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BLAEKIAIDMC JELGEHKBOLI();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task JECPHBIEKII(int IIKNDOCDPLN, OGEHCBNGKDA HBFLJINIIGI, Func<MKHFNGCIHMI, MKHFNGCIHMI> HKGKICPAHGI);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<MJOPCCNIMCA> GDLFNIDJDBA(GANHOFFPCAM NPNJHLNLNMP);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task BCBOFHFGMPJ(CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface ICFBADGDCHF
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool GLDIFOEPHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool KJCEGIGGGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? PBNMFEOOFJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECKLFLNFGOE(Scene KMBJEEMDDOE);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task EJOHBOPCGMJ(MNKJPCENEBF GAONADKEBHI, IReadOnlyList<MNKJPCENEBF> BHLCEFJPAKM, IReadOnlyList<MNKJPCENEBF> EJHIKPHIMHA, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GBODLFFIBED(DJONKJPBLCE EPONNBFFLDB);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task HGKMPMFCCDF(IReadOnlyList<Guid> FHDJKDGDMID, CancellationToken HINEMKGLDEJ);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AHDMIGLMAJL KFOBOJCEJAA();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task HCJOPLIPHPO();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OONKNFBFKLI(GameObject LCCMOEPNGNG);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task NOGJEJEDJMP();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface DHHGNBFICMC
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	CAAJIOJLKCC DNEAEPDOCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool GDILAGDGAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool LHDNGPKFNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool OOPDLNFDJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool LCLFEHPCJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int CCOABBFDOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool FJEEEBCNAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool JCBGPJGJJNM
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int OOHIJPJCNDP
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int OMDDJENPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool NHMPONKHLCB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool OCMNKNFBIAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool CLBBBMFIOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float LFNIAHPEHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> JAMDOOCKMLL;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HHDGAAFLDEF OPGOEJGKEKH(HHDGAAFLDEF BDBANPDIJIA);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGNPEIEDCLE(HHDGAAFLDEF PMKEELMHMLA);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MIONGFAKKDJ();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task ANFFPIHFPHH(BGHFCMFIENI<string>.KHCJHMNAJKC PAPIJGKAELA, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GNEMKLOBPNO(float JFFBLIAEJEK);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BKDMIGEIMBD(string JNGEILKPDIM);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<KOLLEJKBENP> MFNKJJOLHEF();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable LEPBBFEFBMF(object KLNHOILIBHH, KOLLEJKBENP HNDJPBGDNGH);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<LLNJLFIDPAD> EIMHDLMANMC();

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NLICKNHNJCI MAEGFHPGPPM(IEnumerable<PEBBACKHDPF> GDOKGOIHILP);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FGAMFDAECEH(int HLGPGMAFMLJ);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task CJKOPGPCAOF();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IBCKNEEJGOL();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool OBGLEHIOIAL();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task KHIDHBLPNGH(CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task OOECGDNOIMJ(CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<CKACNKNMDFO> CLLEFMNDMBP(DateTime BLLJCLBADOA, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> JABBDKMKAGF(CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LKEKLEFGACL(string NJAAPDELBNN = "", float DJFBMECKBEL = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "25")]
	HCIMABFACGN MCCKKBNNLHM(AJCFEJBAGHB ANLCGKGKMEK, HEDEPEBBEPH DGMIBEGFLND, IOKANKGCBIH IFHGONGGBMP, IEnumerable<PersistenceView> KEBBLNGBLMJ, BIOKGIBHGBO FCGFJNKMNLM);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JPONFIPBHAO(IOKANKGCBIH IFHGONGGBMP);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EFOFLGKABPE(PEBBACKHDPF GIKOLFBJMJH, [In] HCIMABFACGN LBNIKJEOOKI);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task CMNCMJLHDHB(IOKANKGCBIH HAEGAMBDMNL, bool BIOKHOJMLPA, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task MFDEPDIHPAI(CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GEFPLBPNODN(long MDLDCACFGIB, long DBEJCKJKFPB, HCHPFAEFOMI DHIDHGNHAGI, BMPGFEIBEIF COKMBJKAKON, MKHFNGCIHMI EAIJCJBEHLN, OGEHCBNGKDA? HBFLJINIIGI, KFPKEIFCKFO? ANHMJOMJPDK);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void LIBBJOCPFGL(long MDLDCACFGIB, long DBEJCKJKFPB, KFPKEIFCKFO? ANHMJOMJPDK);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void DOJBNGCNCAB(PersistenceView MFMPDOOIABP);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void HPOKENOLJNA(string CHDIDGHENDF, ADDOLAOCDBG CDFKPNNAMDG, CENHDONEPEA KNICMBDNGMP, [Optional] string? FIKPGOJOEHB, [Optional] string? ECMODAJHKED, [Optional] string? LJDGHNENHGP);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool FBCNOGLPCCK(PersistenceView JNLFCOMKBMA);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool ELFBDJICKBM(PEBBACKHDPF GIKOLFBJMJH, FHIIJIJJHKM KOBJEGAJAKI, [Out] OLPKOLEDJIC JHICOALIPJH);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task FJNBAHLJHIG(CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void PFLOHEIGKFF();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable DPMKJHDLGJJ();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void OBGDDPOONPB(IOKANKGCBIH HAEGAMBDMNL, FHIIJIJJHKM KOBJEGAJAKI);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> NJNFGGGFBKB(FOAMNLJKJEK HIEPPCLFHOF, CancellationToken DNHBNMHIDAC, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void AOMKKNEDMMI(CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<EEIBBLLOKKE> PJBBKAMPCCJ(LFJKKMFLGLD JHLBOHEIAIJ);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<HCHPFAEFOMI> NFGFMBGNENN(long MDLDCACFGIB, bool KEDACMDOEBJ, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<OMKFKAIDNEH> JGDMOMGKNBG(long MDLDCACFGIB, long DBEJCKJKFPB, long AEGGFNGPLLP, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<OMKFKAIDNEH> MBEMNDHEGJE(long MDLDCACFGIB, long DBEJCKJKFPB, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<BAFFAAEPLJL> NMFIDNNKEKN(long MDLDCACFGIB, Guid JKBHFMCMDDP, long? ODGNDMLNOIH, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "47")]
	DBGMCEFPAHH<BAFFAAEPLJL, IEnumerable<FNPLOHJEMAN>> EFHCPMEKOEP();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<OLKDICNFHHB> IPGBLNHHDCB(string KJCMLLPPGED, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<OLKDICNFHHB> AEHDGPDBEJK(string KJCMLLPPGED, long MDLDCACFGIB, long DBEJCKJKFPB, Guid? KHGICEEABBP, NHIBJNFDGFI.IIEBADJIKNF PDNEBCPKAAP, NHIBJNFDGFI.IIEBADJIKNF DIJEEBBCAAD, int IIKNDOCDPLN);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool FKMNFBPGDAB();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool LCMFLHHGANG();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool NGEIKINOKNP(IEnumerable<OLPKOLEDJIC> KBNBIFNGGHB);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void HMADFFIIPHH(List<GameObject> IAGDBFCNLEK);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float PGCFFJLHPBL();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> CDMBOAGOCDC(CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> MGJFIIKAIBL(string HOAJLCLGOHE, LoadSceneMode BOONMGANKEI, bool DHAFJMEDOCD, BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void JAJHLBACIKJ();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void CKBOBCGDLCM(bool BCOFJMBGKOE);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void NMMFDHBHHAC();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void HBLNFMCOMGB();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void HJOLMBAEFHH(bool BBDFMFKFLFD);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task<NHIBJNFDGFI.IIEBADJIKNF> PIJPHOEMJJK(byte[] NFNBKNAJBPN, NHIBJNFDGFI.MDEBNPPEIBP FHOFAEDEEIN, JFDMNGPDAAE FLKKCDEIJLL, [Optional] IReadOnlyCollection<string>? OELGIPOIKJK, [Optional] string? MOFMHLNCOMN);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void PJFHBMOJDLK(ADDOLAOCDBG NCCFEACBIPP);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task KBELCFJGAHA(BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task JCICIHEHKCE(BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task AHFKBHOPDKK(BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "77")]
	Task ADEANKALDOI(BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "78")]
	IDisposable GDCEBHOHHFC();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "79")]
	LBOIKKJIIFC GOBGEIMDPNK();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "80")]
	Task NIAIGEKINEG(CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface LBOIKKJIIFC
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ODNJEBPKBFL(CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CIEAHADHCOB(CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct HCIMABFACGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public HashSet<int> CIPDBJIPAJP;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum CKACNKNMDFO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct AJCFEJBAGHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Guid? CPEKFMPNMOI;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface CAAJIOJLKCC
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	ADDOLAOCDBG KEIDDJKOCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	HCHPFAEFOMI EGFOEMKEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	EFHDFBNHLAI JBJAHFHOOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool FBHPGHPNAHO
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool GNLKPDOOHDD
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int HFECNLHAEGF
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action MACFCDJBHBD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> GFEIHOMLNOH;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LNGPDMOPNDH();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.MEGLOJEAPIG> DFNDMKDJKPF(long PAHLPEDOKGC, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<NCKLJFDMIJK> KNMNIGIFGAN(ADDOLAOCDBG CDFKPNNAMDG, [Optional] DPNGIIIGHEF CPFLDOKAPNJ);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<NCKLJFDMIJK> BFOPDLOFELF();

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task DCJNNGIFJKO();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(ADDOLAOCDBG, DPNGIIIGHEF) DEMNKLBOFKP();

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IJNMEJLNFNJ BAAFEKCGGKB();

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HIDPHBFDHKN(long PAHLPEDOKGC);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void ICGKMJOFOJG(ADDOLAOCDBG CDFKPNNAMDG, Matchmaking.ODEODNLADOA HLPIAOANGMD, (int Major, int? Minor)? JBAPMMNBLOM);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface KBEBBAGNJGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CENHFCODBNK([Out] IEnumerable<int> ADCANBBMOBO);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHOPHLHGJCD(GKLIALCKGHC JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MDIJOEPHGEF(GKLIALCKGHC JILOCOLKOMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface FEOICHNBNDF
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CEDDGODGFNL(MJOPCCNIMCA NLLLFHIJCAE);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface CDHHAFMGPDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHIFLNAKOGN(IPBBLCLBHEE.MOLBHGAAFIK JPBLPENMDNH);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDLLDPMGPNL(IPBBLCLBHEE.MOLBHGAAFIK JPBLPENMDNH);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface BPHMPAJBIBK : CDHHAFMGPDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MJOPCCNIMCA MHIJCDAPEAC(GFEBJDBBDID JJLLGPNLOHI);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface IKDBLDBFNFM : CDHHAFMGPDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MJOPCCNIMCA LOFLJLLBAOF(GFEBJDBBDID JFDOFPAEGJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface MKMFJMPKGKL
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HCGBMJDNFKJ<IMJGIKLDEEF, PLLAIPNOLPG>> HHGICMPLFPD(Guid? KHGICEEABBP, IReadOnlyCollection<CABHDLHGNPC> HAAEAKDAFDC, IReadOnlyCollection<CABHDLHGNPC> MCENODOAHLL, LFPHHGOEBDM MIGICMHBMEE, long? MDLDCACFGIB, long? DBEJCKJKFPB, PIMHGEACHCB.BCKCHKHFKGB LAODBPDHCNE, CancellationToken DNHBNMHIDAC, bool EKIOKNKGCCB = false);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class IMJGIKLDEEF
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public MNKJPCENEBF OOGLBBACBLP
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<MNKJPCENEBF> OFLPCLPJOCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<MNKJPCENEBF> AHFFEOJAJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xC2FD30", Offset = "0xC2E530", VA = "0x180C2FD30")]
	public IMJGIKLDEEF(MNKJPCENEBF FBIICMJLNHD, IReadOnlyList<MNKJPCENEBF> MJALOCIIGEF, IReadOnlyList<MNKJPCENEBF> GOLKFHPFLMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface DBGMCEFPAHH<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HCGBMJDNFKJ<CCNPADACDGN<TData>, PLLAIPNOLPG>> NPNEGHMDPPL(TGetDataArg MJAILKMLAHP, CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class JCNLFHHJJOL : IBNHMOEDCKG, BGPDBLKFCBP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct KENPAIKEHLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<MJOPCCNIMCA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public JCNLFHHJJOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GANHOFFPCAM autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<MJOPCCNIMCA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x82EBBC0", Offset = "0x82EA3C0", VA = "0x1882EBBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x82EBE40", Offset = "0x82EA640", VA = "0x1882EBE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct BODPDPEEEMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public JCNLFHHJJOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x82D90F0", Offset = "0x82D78F0", VA = "0x1882D90F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x82D9320", Offset = "0x82D7B20", VA = "0x1882D9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class GIGAMGOEKGD : IEnumerable<OACHLMNKJAD>, IEnumerable, IEnumerator<OACHLMNKJAD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private OACHLMNKJAD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public JCNLFHHJJOL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private OACHLMNKJAD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xE73320", Offset = "0xE71B20", VA = "0x180E73320")]
		[DebuggerHidden]
		public GIGAMGOEKGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x82DD5E0", Offset = "0x82DBDE0", VA = "0x1882DD5E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x82DDA40", Offset = "0x82DC240", VA = "0x1882DDA40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x82DD990", Offset = "0x82DC190", VA = "0x1882DD990", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OACHLMNKJAD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x82DD990", Offset = "0x82DC190", VA = "0x1882DD990", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CancellationTokenSource MHIPNPJMFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly HHDGAAFLDEF PMKEELMHMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool IHDAJILAEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private AJBLPKENEKD DCGLPBIMKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool CNIBALGAHHM;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public FOAMNLJKJEK CCPKGAGGNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9DD240", Offset = "0x9DBA40", VA = "0x1809DD240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public GOGPOCOGOBL HLPHAHDIGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9DD230", Offset = "0x9DBA30", VA = "0x1809DD230", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1D0", Offset = "0x9DB9D0", VA = "0x1809DD1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public DHHGNBFICMC PILJEFNINPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9DD210", Offset = "0x9DBA10", VA = "0x1809DD210", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9DD220", Offset = "0x9DBA20", VA = "0x1809DD220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public ICFBADGDCHF JGBKILABOBL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1C0", Offset = "0x9DB9C0", VA = "0x1809DD1C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1B0", Offset = "0x9DB9B0", VA = "0x1809DD1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public BPHMPAJBIBK FLLJNCGCAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1F0", Offset = "0x9DB9F0", VA = "0x1809DD1F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1E0", Offset = "0x9DB9E0", VA = "0x1809DD1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public IKDBLDBFNFM AHOONCJDJNN
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9E93E0", Offset = "0x9E7BE0", VA = "0x1809E93E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9E9480", Offset = "0x9E7C80", VA = "0x1809E9480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public JIDDILENHDB DCGHBKOKAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9E9310", Offset = "0x9E7B10", VA = "0x1809E9310", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9E9320", Offset = "0x9E7B20", VA = "0x1809E9320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public ECOIGKPCBDF FPIKEDAGDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9E9400", Offset = "0x9E7C00", VA = "0x1809E9400", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9E92D0", Offset = "0x9E7AD0", VA = "0x1809E92D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public BGNAANIBOJP MILOOHLDNIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xBCAEE0", Offset = "0xBC96E0", VA = "0x180BCAEE0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x12B1DD0", Offset = "0x12B05D0", VA = "0x1812B1DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public CEGLHANHICO NEGHFJGHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9E9390", Offset = "0x9E7B90", VA = "0x1809E9390", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9E9340", Offset = "0x9E7B40", VA = "0x1809E9340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public KOLJJJIKCKA CKBFNFODMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xCAB0D0", Offset = "0xCA98D0", VA = "0x180CAB0D0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xE18B30", Offset = "0xE17330", VA = "0x180E18B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public CIAEDAHKOKG KMAHNCGFNNM
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9E71A0", Offset = "0x9E59A0", VA = "0x1809E71A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9E7180", Offset = "0x9E5980", VA = "0x1809E7180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public IIBBCEMMFDM CBLCGPINHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xBF9060", Offset = "0xBF7860", VA = "0x180BF9060", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xE28C10", Offset = "0xE27410", VA = "0x180E28C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public PKGLAMNHGHN LCELOIDGBPF
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xD206F0", Offset = "0xD1EEF0", VA = "0x180D206F0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xD20700", Offset = "0xD1EF00", VA = "0x180D20700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public AKBEMKDEJEH MGJPCLFNLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xCAAF00", Offset = "0xCA9700", VA = "0x180CAAF00", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x112F9C0", Offset = "0x112E1C0", VA = "0x18112F9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public JCODMPBACKM NBDGJECPLJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xC95FB0", Offset = "0xC947B0", VA = "0x180C95FB0", Slot = "62")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xD50380", Offset = "0xD4EB80", VA = "0x180D50380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public LIBAMEGNOIL KKHIDLLCJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA74590", Offset = "0xA72D90", VA = "0x180A74590", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA76EB0", Offset = "0xA756B0", VA = "0x180A76EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public NJHHJFPHOAK CFEGHBJOHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9E71B0", Offset = "0x9E59B0", VA = "0x1809E71B0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x9E71C0", Offset = "0x9E59C0", VA = "0x1809E71C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public LDMDOMDMHPI KHKPOPFDGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA9E6B0", Offset = "0xA9CEB0", VA = "0x180A9E6B0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xB62080", Offset = "0xB60880", VA = "0x180B62080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public OODEDDNEKOO MPIBCLEGFPO
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA7B0F0", Offset = "0xA798F0", VA = "0x180A7B0F0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA7A190", Offset = "0xA78990", VA = "0x180A7A190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public ADNGNJCDMJO HBLNIEJOOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA74730", Offset = "0xA72F30", VA = "0x180A74730", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA7E500", Offset = "0xA7CD00", VA = "0x180A7E500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public HOKEHILMPLD DPKOJIMDGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA74760", Offset = "0xA72F60", VA = "0x180A74760", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA73940", Offset = "0xA72140", VA = "0x180A73940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public KGFCPCHMJMI DOKCHALLLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA9F080", Offset = "0xA9D880", VA = "0x180A9F080", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xB6BB30", Offset = "0xB6A330", VA = "0x180B6BB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public LPGCMMDJHFF KGDICPEMCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA9F040", Offset = "0xA9D840", VA = "0x180A9F040", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA92DB0", Offset = "0xA915B0", VA = "0x180A92DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public KBEBBAGNJGJ FHAMLFKOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA9F060", Offset = "0xA9D860", VA = "0x180A9F060", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA88640", Offset = "0xA86E40", VA = "0x180A88640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public CJPJONPIBFJ BFNLJDJGPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA9F050", Offset = "0xA9D850", VA = "0x180A9F050", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA8BE40", Offset = "0xA8A640", VA = "0x180A8BE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public BOHPHODOLDK MFJHBAICAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA94DA0", Offset = "0xA935A0", VA = "0x180A94DA0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA8A7A0", Offset = "0xA88FA0", VA = "0x180A8A7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public GJLIIHMFEJN COEKPBMKLJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA9DF60", Offset = "0xA9C760", VA = "0x180A9DF60", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xAB7A10", Offset = "0xAB6210", VA = "0x180AB7A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public CLIJODHNBOD CFLOLJFONFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA97120", Offset = "0xA95920", VA = "0x180A97120", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public IOECHHPJIMN NGINGJCEIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA8C000", Offset = "0xA8A800", VA = "0x180A8C000", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public OFLKHHIPKIE GKEPPNGNEJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA88030", Offset = "0xA86830", VA = "0x180A88030", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public PDHBLMAPBNH HGCJBLIBOME
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA898F0", Offset = "0xA880F0", VA = "0x180A898F0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public PPIGJJKFIEK MIHBPEJPMMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA9DCD0", Offset = "0xA9C4D0", VA = "0x180A9DCD0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public DPNGIIIGHEF CMOLFOCKLPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA97130", Offset = "0xA95930", VA = "0x180A97130", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xF53220", Offset = "0xF51A20", VA = "0x180F53220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool ALCJPDOANJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x82E4990", Offset = "0x82E3190", VA = "0x1882E4990", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool PIEDGPKLMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x82E54F0", Offset = "0x82E3CF0", VA = "0x1882E54F0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool OBMPKBFLHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1BCAF50", Offset = "0x1BC9750", VA = "0x181BCAF50", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken AMLLNIMAEOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x82E5570", Offset = "0x82E3D70", VA = "0x1882E5570", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private HHDGAAFLDEF FEJMGOLLGHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool FMMKOGCOOCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1BCAF50", Offset = "0x1BC9750", VA = "0x181BCAF50", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1BC5390", Offset = "0x1BC3B90", VA = "0x181BC5390", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action OBPDLHNGONN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x82E49F0", Offset = "0x82E31F0", VA = "0x1882E49F0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x82E56A0", Offset = "0x82E3EA0", VA = "0x1882E56A0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event JKPHLHNDBHC JNFCAHOMHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x82E4930", Offset = "0x82E3130", VA = "0x1882E4930", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x82E5490", Offset = "0x82E3C90", VA = "0x1882E5490", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event JKPHLHNDBHC OGDNBFDBDCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x82E4C90", Offset = "0x82E3490", VA = "0x1882E4C90", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x82E4C30", Offset = "0x82E3430", VA = "0x1882E4C30", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event JKPHLHNDBHC FDAGGCIDEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x82E4F20", Offset = "0x82E3720", VA = "0x1882E4F20", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x82E4E60", Offset = "0x82E3660", VA = "0x1882E4E60", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<BIAEOMGDAEE, bool> FHODIAOHFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x82E5640", Offset = "0x82E3E40", VA = "0x1882E5640", Slot = "48")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x82E4EC0", Offset = "0x82E36C0", VA = "0x1882E4EC0", Slot = "49")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0xF53220", Offset = "0xF51A20", VA = "0x180F53220", Slot = "39")]
	public void KEMIEPMCLCN(DPNGIIIGHEF ALHDPOKAEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x82E5810", Offset = "0x82E4010", VA = "0x1882E5810")]
	[UnityEngine.Scripting.Preserve]
	internal JCNLFHHJJOL([LDAFGEHKDJK(null)] HHDGAAFLDEF PMKEELMHMLA, [LDAFGEHKDJK(null)] FOAMNLJKJEK HIEPPCLFHOF, [LDAFGEHKDJK(null)] GOGPOCOGOBL PMPBIKPEKLO, [LDAFGEHKDJK(null)] DHHGNBFICMC LMJFACKNPAI, [LDAFGEHKDJK(null)] ICFBADGDCHF KILPILABIOG, [LDAFGEHKDJK(null)] BPHMPAJBIBK GLMIFODABPM, [LDAFGEHKDJK(null)] IKDBLDBFNFM PGELCPLMIHC, [LDAFGEHKDJK(null)] ECOIGKPCBDF IGBOEAEPDEM, [LDAFGEHKDJK(null)] BGNAANIBOJP KBGGGNHPGNJ, [LDAFGEHKDJK(null)] CEGLHANHICO MDOFKMAEFJF, [LDAFGEHKDJK(null)] KOLJJJIKCKA NAEDIAJJFEH, [LDAFGEHKDJK(null)] CIAEDAHKOKG BGKBJHFEPEM, [LDAFGEHKDJK(null)] IIBBCEMMFDM FNDMBKNLKKG, [LDAFGEHKDJK(null)] PKGLAMNHGHN HEECGAJJLBB, [LDAFGEHKDJK(null)] AKBEMKDEJEH EFHGDJDKGME, [LDAFGEHKDJK(null)] JCODMPBACKM FDCHCAGHEBJ, [LDAFGEHKDJK(null)] LIBAMEGNOIL OILDOBGBPEM, [LDAFGEHKDJK(null)] NJHHJFPHOAK LLMFLKIIFNG, [LDAFGEHKDJK(null)] LDMDOMDMHPI MMJNLACMBKI, [LDAFGEHKDJK(null)] OODEDDNEKOO IJNPLBEHPOH, [LDAFGEHKDJK(null)] HOKEHILMPLD FNODADMJNJH, [LDAFGEHKDJK(null)] ADNGNJCDMJO JHMFEOBFGHK, [LDAFGEHKDJK(null)] KGFCPCHMJMI KHOLCDGBMBM, [LDAFGEHKDJK(null)] LPGCMMDJHFF HAJACPMKDKK, [LDAFGEHKDJK(null)] KBEBBAGNJGJ IGCCOBBOJON, [LDAFGEHKDJK(null)] BOHPHODOLDK PKENAIPAKDA, [LDAFGEHKDJK(null)] GJLIIHMFEJN DNDIHNEMGPA, [LDAFGEHKDJK(null)] CLIJODHNBOD FPIEEKFCEPH, [LDAFGEHKDJK(null)] IOECHHPJIMN GDLDGKPJNHF, [LDAFGEHKDJK(null)] OFLKHHIPKIE ALMPDKMNLAC, [LDAFGEHKDJK(null)] PDHBLMAPBNH NPHKFKOBBGG, [LDAFGEHKDJK(null)] PPIGJJKFIEK LCKPIDMFOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x82E5590", Offset = "0x82E3D90", VA = "0x1882E5590")]
	private void NPIOKLMMDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x82E4AA0", Offset = "0x82E32A0", VA = "0x1882E4AA0", Slot = "61")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x82E4A50", Offset = "0x82E3250", VA = "0x1882E4A50", Slot = "53")]
	private void DIOFOOHMCIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x82E5310", Offset = "0x82E3B10", VA = "0x1882E5310", Slot = "54")]
	private LGNELIMGMHE JIMFKMOHDHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x82E4F80", Offset = "0x82E3780", VA = "0x1882E4F80", Slot = "55")]
	private BLAEKIAIDMC JACJIKBKLKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x82E5010", Offset = "0x82E3810", VA = "0x1882E5010", Slot = "57")]
	public Task JECPHBIEKII(int IIKNDOCDPLN, OGEHCBNGKDA HBFLJINIIGI, Func<MKHFNGCIHMI, MKHFNGCIHMI> HKGKICPAHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x82E4CF0", Offset = "0x82E34F0", VA = "0x1882E4CF0")]
	private LJBHFJCJNEG EMMJFMJFEKP(int IIKNDOCDPLN, OGEHCBNGKDA HBFLJINIIGI, Func<MKHFNGCIHMI, MKHFNGCIHMI> HKGKICPAHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x82E5700", Offset = "0x82E3F00", VA = "0x1882E5700", Slot = "58")]
	[AsyncStateMachine(typeof(KENPAIKEHLC))]
	private Task<MJOPCCNIMCA> PNDIKBAGLON(GANHOFFPCAM EFAOGHPAKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x82E53A0", Offset = "0x82E3BA0", VA = "0x1882E53A0", Slot = "59")]
	[AsyncStateMachine(typeof(BODPDPEEEMO))]
	private Task LBOKJPACODH(CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x82E48B0", Offset = "0x82E30B0", VA = "0x1882E48B0")]
	[IteratorStateMachine(typeof(GIGAMGOEKGD))]
	private IEnumerable<OACHLMNKJAD> ABHDAECJBDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x82E4E00", Offset = "0x82E3600", VA = "0x1882E4E00")]
	[CompilerGenerated]
	private void FDFCCKKEIKF(OACHLMNKJAD IKKBFHNKIMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class KMDCLAEBGJD : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1792BA0", Offset = "0x17913A0", VA = "0x181792BA0")]
	public KMDCLAEBGJD(string NJAAPDELBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class HHHBIPPMFEK : CPAPAKNBFAL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct KEIOIJJJGLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<CPAPAKNBFAL.LLPJINIKDPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public HashSet<CIAEDAHKOKG.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public HHHBIPPMFEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x82EB850", Offset = "0x82EA050", VA = "0x1882EB850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x82EBB50", Offset = "0x82EA350", VA = "0x1882EBB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly IBNHMOEDCKG CDLOFOIHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly DHHGNBFICMC LMJFACKNPAI;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string DFKOJKJJKFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x82DEEB0", Offset = "0x82DD6B0", VA = "0x1882DEEB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x9E57C0", Offset = "0x9E3FC0", VA = "0x1809E57C0")]
	public HHHBIPPMFEK(IBNHMOEDCKG CDLOFOIHHCC, DHHGNBFICMC LMJFACKNPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x82DEDA0", Offset = "0x82DD5A0", VA = "0x1882DEDA0", Slot = "5")]
	[AsyncStateMachine(typeof(KEIOIJJJGLB))]
	public Task<CPAPAKNBFAL.LLPJINIKDPG> LLLGKPFOBAE(HashSet<CIAEDAHKOKG.Reason> HGICHEDMJKK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class AHFNOAHMBPF : IFFCAPDOJDK, CPAPAKNBFAL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct APFBCCHCGEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<CPAPAKNBFAL.LLPJINIKDPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public AHFNOAHMBPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public HashSet<CIAEDAHKOKG.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private ADDOLAOCDBG <localRoomInstance>5__2;

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
		private TaskAwaiter<CPAPAKNBFAL.LLPJINIKDPG> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x82D8010", Offset = "0x82D6810", VA = "0x1882D8010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x82D8970", Offset = "0x82D7170", VA = "0x1882D8970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string DFKOJKJJKFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x82D7F10", Offset = "0x82D6710", VA = "0x1882D7F10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x9E57C0", Offset = "0x9E3FC0", VA = "0x1809E57C0")]
	public AHFNOAHMBPF(IBNHMOEDCKG CDLOFOIHHCC, DHHGNBFICMC LMJFACKNPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x82D7DC0", Offset = "0x82D65C0", VA = "0x1882D7DC0", Slot = "5")]
	[AsyncStateMachine(typeof(APFBCCHCGEM))]
	public Task<CPAPAKNBFAL.LLPJINIKDPG> LLLGKPFOBAE(HashSet<CIAEDAHKOKG.Reason> HGICHEDMJKK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class APLNPIKFNKP : IFFCAPDOJDK, CPAPAKNBFAL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct NHJNJKOJPBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public AsyncTaskMethodBuilder<CPAPAKNBFAL.LLPJINIKDPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public APLNPIKFNKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public HashSet<CIAEDAHKOKG.Reason> fallbackTriggersToIgnore;

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
		private TaskAwaiter<NCKLJFDMIJK> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter<CPAPAKNBFAL.LLPJINIKDPG> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x82F23B0", Offset = "0x82F0BB0", VA = "0x1882F23B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x82F2DA0", Offset = "0x82F15A0", VA = "0x1882F2DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string DFKOJKJJKFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x82D8B30", Offset = "0x82D7330", VA = "0x1882D8B30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x9E57C0", Offset = "0x9E3FC0", VA = "0x1809E57C0")]
	public APLNPIKFNKP(IBNHMOEDCKG CDLOFOIHHCC, DHHGNBFICMC LMJFACKNPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x82D89E0", Offset = "0x82D71E0", VA = "0x1882D89E0", Slot = "5")]
	[AsyncStateMachine(typeof(NHJNJKOJPBC))]
	public Task<CPAPAKNBFAL.LLPJINIKDPG> LLLGKPFOBAE(HashSet<CIAEDAHKOKG.Reason> HGICHEDMJKK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class LKKFFCHABOK : IFFCAPDOJDK, CPAPAKNBFAL
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class PHICPLOMHCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public NCKLJFDMIJK matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public ADDOLAOCDBG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public PHICPLOMHCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x82F3900", Offset = "0x82F2100", VA = "0x1882F3900")]
		internal object IHKNEANGEHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x82F3840", Offset = "0x82F2040", VA = "0x1882F3840")]
		internal object AIDDCMFBBHM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct EOPEOALCOHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public AsyncTaskMethodBuilder<CPAPAKNBFAL.LLPJINIKDPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public LKKFFCHABOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public HashSet<CIAEDAHKOKG.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private PHICPLOMHCM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<NCKLJFDMIJK> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter<CPAPAKNBFAL.LLPJINIKDPG> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x82DB850", Offset = "0x82DA050", VA = "0x1882DB850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x82DC470", Offset = "0x82DAC70", VA = "0x1882DC470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string DFKOJKJJKFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x82F0F30", Offset = "0x82EF730", VA = "0x1882F0F30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x9E57C0", Offset = "0x9E3FC0", VA = "0x1809E57C0")]
	public LKKFFCHABOK(IBNHMOEDCKG CDLOFOIHHCC, DHHGNBFICMC LMJFACKNPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x82F0DE0", Offset = "0x82EF5E0", VA = "0x1882F0DE0", Slot = "5")]
	[AsyncStateMachine(typeof(EOPEOALCOHG))]
	public Task<CPAPAKNBFAL.LLPJINIKDPG> LLLGKPFOBAE(HashSet<CIAEDAHKOKG.Reason> HGICHEDMJKK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class IFFCAPDOJDK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct EPBOIEGALKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public LLPKKNNAIAE log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public HashSet<CIAEDAHKOKG.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public IFFCAPDOJDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<CIAEDAHKOKG.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x82DC4E0", Offset = "0x82DACE0", VA = "0x1882DC4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x82DCA00", Offset = "0x82DB200", VA = "0x1882DCA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	protected readonly IBNHMOEDCKG CDLOFOIHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	protected readonly DHHGNBFICMC LMJFACKNPAI;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected CAAJIOJLKCC DNEAEPDOCGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x82E0EC0", Offset = "0x82DF6C0", VA = "0x1882E0EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x9E57C0", Offset = "0x9E3FC0", VA = "0x1809E57C0")]
	public IFFCAPDOJDK(IBNHMOEDCKG CDLOFOIHHCC, DHHGNBFICMC LMJFACKNPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x82E0F10", Offset = "0x82DF710", VA = "0x1882E0F10")]
	[AsyncStateMachine(typeof(EPBOIEGALKI))]
	protected Task NDKGBCCOPAH(LLPKKNNAIAE NOMHFHBJHNN, HashSet<CIAEDAHKOKG.Reason> HGICHEDMJKK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class AABIGJDMGHN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct LFKCEHOLINP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder<CPAPAKNBFAL.LLPJINIKDPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public DHHGNBFICMC callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x82F09F0", Offset = "0x82EF1F0", VA = "0x1882F09F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x82F0D70", Offset = "0x82EF570", VA = "0x1882F0D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class IACNBNDBAAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public IBNHMOEDCKG roomManager;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public IACNBNDBAAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x82DFE90", Offset = "0x82DE690", VA = "0x1882DFE90")]
		internal object NAHBPBONKKI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly float MIAIABCMMCL;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	internal static readonly HashSet<CIAEDAHKOKG.Reason> GAMLAEFMLPN;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x82D6170", Offset = "0x82D4970", VA = "0x1882D6170")]
	[AsyncStateMachine(typeof(LFKCEHOLINP))]
	internal static Task<CPAPAKNBFAL.LLPJINIKDPG> FLPOEBDNNEP(DHHGNBFICMC LMJFACKNPAI, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x82D6280", Offset = "0x82D4A80", VA = "0x1882D6280")]
	internal static void OIOODJAGMIN(IBNHMOEDCKG CDLOFOIHHCC, LLPKKNNAIAE NOMHFHBJHNN, string CHDIDGHENDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface CPAPAKNBFAL
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct LLPJINIKDPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public bool EJCCGIABFNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public CIAEDAHKOKG.Reason NLGEMFKLFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Enum? LJDGHNENHGP;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x82F0FE0", Offset = "0x82EF7E0", VA = "0x1882F0FE0")]
		public static LLPJINIKDPG BEPNLJCJPFD()
		{
			return default(LLPJINIKDPG);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x82F0FF0", Offset = "0x82EF7F0", VA = "0x1882F0FF0")]
		public static LLPJINIKDPG FKBEJNLHJII(CIAEDAHKOKG.Reason NLGEMFKLFCF, [Optional] Enum? LJDGHNENHGP)
		{
			return default(LLPJINIKDPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string IJKIPMIGMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<LLPJINIKDPG> LLLGKPFOBAE(HashSet<CIAEDAHKOKG.Reason> HGICHEDMJKK, CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct FODPBCIOMJM
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class DODMEIAMHIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public IBNHMOEDCKG manager;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public DODMEIAMHIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x82DAB00", Offset = "0x82D9300", VA = "0x1882DAB00")]
		internal Task IEKNJGHKKFH(CancellationToken cancellationToken, int roomTotalVersion, COICKFBCMHF localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct PAIHNMHPEBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public FODPBCIOMJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private GANHOFFPCAM <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter<CKACNKNMDFO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter<MJOPCCNIMCA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x82F3240", Offset = "0x82F1A40", VA = "0x1882F3240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x82F37D0", Offset = "0x82F1FD0", VA = "0x1882F37D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct CNJDOLHKJBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public FODPBCIOMJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x82D9AF0", Offset = "0x82D82F0", VA = "0x1882D9AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x82D9E10", Offset = "0x82D8610", VA = "0x1882D9E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly CancellationToken DNHBNMHIDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly IBNHMOEDCKG IPKPNIAEJDE;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private FOAMNLJKJEK CCPKGAGGNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x82DD2B0", Offset = "0x82DBAB0", VA = "0x1882DD2B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private DHHGNBFICMC PILJEFNINPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x82DCEA0", Offset = "0x82DB6A0", VA = "0x1882DCEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private CAAJIOJLKCC DNEAEPDOCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x82DD230", Offset = "0x82DBA30", VA = "0x1882DD230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private CEGLHANHICO NEGHFJGHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x82DD3B0", Offset = "0x82DBBB0", VA = "0x1882DD3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x27682C0", Offset = "0x2766AC0", VA = "0x1827682C0")]
	public FODPBCIOMJM(CancellationToken DNHBNMHIDAC, IBNHMOEDCKG IPKPNIAEJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x82DD300", Offset = "0x82DBB00", VA = "0x1882DD300")]
	public static HCLIEADMJEL LDIMFBGLJPP(IBNHMOEDCKG IPKPNIAEJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x82DD4D0", Offset = "0x82DBCD0", VA = "0x1882DD4D0")]
	[AsyncStateMachine(typeof(PAIHNMHPEBC))]
	public Task<bool> OEANMMBFPHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x82DD020", Offset = "0x82DB820", VA = "0x1882DD020")]
	private bool IEEGLHPFFOM([Out] GANHOFFPCAM EFAOGHPAKDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x82DD400", Offset = "0x82DBC00", VA = "0x1882DD400")]
	[AsyncStateMachine(typeof(CNJDOLHKJBH))]
	private Task ODBACONDHMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x82DCEF0", Offset = "0x82DB6F0", VA = "0x1882DCEF0")]
	private Task<CKACNKNMDFO> HILCAOECJEN(GANHOFFPCAM MHABNEJMLKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct EAJOEMNKDCL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly AKBEMKDEJEH EFHGDJDKGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Guid KJHDGFKNPKN;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(MJOPCCNIMCA, Task)> NDHEOOKGDNK
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x82DAB50", Offset = "0x82D9350", VA = "0x1882DAB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x4FBD6B0", Offset = "0x4FBBEB0", VA = "0x184FBD6B0")]
	public EAJOEMNKDCL(AKBEMKDEJEH EFHGDJDKGME, Guid KJHDGFKNPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x82DACF0", Offset = "0x82D94F0", VA = "0x1882DACF0")]
	public TaskAwaiter<(MJOPCCNIMCA, Task)> HJMFLLMLOGL()
	{
		return default(TaskAwaiter<(MJOPCCNIMCA, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x82DAC20", Offset = "0x82D9420", VA = "0x1882DAC20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct FAGDBKELBAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly TaskCompletionSource<(MJOPCCNIMCA, Task)> BLNDIHHOEIH;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(MJOPCCNIMCA, Task)> NDHEOOKGDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x82DCA60", Offset = "0x82DB260", VA = "0x1882DCA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x82DCCB0", Offset = "0x82DB4B0", VA = "0x1882DCCB0")]
	public FAGDBKELBAE(TimeSpan GCGADGABLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x82DCC10", Offset = "0x82DB410", VA = "0x1882DCC10")]
	public void OIDNNLAENNE(Task KJGICOEAHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x82DCAA0", Offset = "0x82DB2A0", VA = "0x1882DCAA0")]
	public void DPBHBMOFIDP(MJOPCCNIMCA NLLLFHIJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x82DCBC0", Offset = "0x82DB3C0", VA = "0x1882DCBC0")]
	public void NPNKEDIKBKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x82DCB30", Offset = "0x82DB330", VA = "0x1882DCB30")]
	internal void GKICFIOANLE(string NJAAPDELBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class KJLALNPOOIB
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x82EC040", Offset = "0x82EA840", VA = "0x1882EC040")]
	public static HHEFLMKOLLI NBGAOEHGGFG(this HHEFLMKOLLI JDGDKOENECG, HCHPFAEFOMI PMKHFCAOIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x82EBEB0", Offset = "0x82EA6B0", VA = "0x1882EBEB0")]
	public static HHEFLMKOLLI KGFMCNGOOEF(this HHEFLMKOLLI JDGDKOENECG, BMPGFEIBEIF BGMLNLIHPPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class PJIHIIFLICB : JIDDILENHDB
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class BIAIJMHMFBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public BMPGFEIBEIF subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public BIAIJMHMFBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x82D90C0", Offset = "0x82D78C0", VA = "0x1882D90C0")]
		internal bool OLFHDDICENE(EFHDFBNHLAI s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly BOHPHODOLDK FHINLCHLMOO;

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public PJIHIIFLICB(BOHPHODOLDK PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x82F4230", Offset = "0x82F2A30", VA = "0x1882F4230", Slot = "4")]
	public HHEFLMKOLLI NKIHIDGHACP(long CNECHKELGPE, long DBEJCKJKFPB, string KJCMLLPPGED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x82F42C0", Offset = "0x82F2AC0", VA = "0x1882F42C0", Slot = "5")]
	public HHEFLMKOLLI NKIHIDGHACP(long CNECHKELGPE, long DBEJCKJKFPB, COMDBKPAHPB GDDBLNGCPFI, Guid? HCHIFCCLLCA, long AEGGFNGPLLP, bool DIMNOKFJGPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x82F4030", Offset = "0x82F2830", VA = "0x1882F4030", Slot = "6")]
	public HHEFLMKOLLI NKIHIDGHACP(EEIBBLLOKKE BFBCBOCDJKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x82F3D50", Offset = "0x82F2550", VA = "0x1882F3D50", Slot = "7")]
	public HHEFLMKOLLI NKIHIDGHACP(HCHPFAEFOMI POGHHKALCGK, BMPGFEIBEIF CNNDIOOCMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x82F4420", Offset = "0x82F2C20", VA = "0x1882F4420")]
	private Guid? PIMKNDPLAGK(HCHPFAEFOMI IFLLKEIGEON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class PJENCDPCHMO : BGNAANIBOJP, OACHLMNKJAD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct DBKPMMKFBLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public PJENCDPCHMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x82DA3A0", Offset = "0x82D8BA0", VA = "0x1882DA3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x82DAA30", Offset = "0x82D9230", VA = "0x1882DAA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly GKLIALCKGHC FKLNBEKJNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private string BHGIBECJLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Task BHOLMGHHBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private IBNHMOEDCKG CDLOFOIHHCC;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool DDDABECNMFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x82F3B70", Offset = "0x82F2370", VA = "0x1882F3B70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task AENIANANJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x82F3980", Offset = "0x82F2180", VA = "0x1882F3980", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780", Slot = "7")]
	public void NPIOKLMMDIH(IBNHMOEDCKG CDLOFOIHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x82F3A10", Offset = "0x82F2210", VA = "0x1882F3A10", Slot = "6")]
	public void FOGBDKOCDHI(Task BFOIMBMKJIA, string GBMKDNJEGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x82F3BA0", Offset = "0x82F23A0", VA = "0x1882F3BA0")]
	[AsyncStateMachine(typeof(DBKPMMKFBLF))]
	private Task IIPMJLDDGCJ(Task LLHLKAAFIAF, string GBMKDNJEGLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x82F3CC0", Offset = "0x82F24C0", VA = "0x1882F3CC0")]
	public PJENCDPCHMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class CCFJKKJKJIH : CJPJONPIBFJ, OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private bool NADEHKGPMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private HBIANJDPELM FONLCHLCNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private FOAMNLJKJEK HIEPPCLFHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private BOHPHODOLDK PKENAIPAKDA;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public HBIANJDPELM ADABGMEEMNG
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x82D9650", Offset = "0x82D7E50", VA = "0x1882D9650", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x82D9970", Offset = "0x82D8170", VA = "0x1882D9970", Slot = "7")]
	public void NPIOKLMMDIH(IBNHMOEDCKG CDLOFOIHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x82D9700", Offset = "0x82D7F00", VA = "0x1882D9700", Slot = "5")]
	public void FHBIJIEOFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x82D96C0", Offset = "0x82D7EC0", VA = "0x1882D96C0", Slot = "6")]
	public void NOFGADBABPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x82D98B0", Offset = "0x82D80B0", VA = "0x1882D98B0")]
	private Task JPGIMMMKJDG(KBMOFBNCMMD LDIOMGMJIGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x82D96C0", Offset = "0x82D7EC0", VA = "0x1882D96C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public CCFJKKJKJIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class HMPLEIJOKMI : BOHPHODOLDK
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class FKLFKLOEJKN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly AGPOKEKNOGC HFMDFHLKMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly string BELIEAFHDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly T LHCNPHOLELG;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T GDCDOMLHCOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xC47930", Offset = "0xC46130", VA = "0x180C47930")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0xC466E0", Offset = "0xC44EE0", VA = "0x180C466E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x48D2290", Offset = "0x48D0A90", VA = "0x1848D2290")]
		public FKLFKLOEJKN(AGPOKEKNOGC HFMDFHLKMEB, string BELIEAFHDAH, T LHCNPHOLELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x48D1E30", Offset = "0x48D0630", VA = "0x1848D1E30")]
		private void AIBFCBAGPII()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly AGPOKEKNOGC HFMDFHLKMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly FKLFKLOEJKN<TimeSpan> LCDILCNABBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly FKLFKLOEJKN<TimeSpan> BGMMNBHICGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly FKLFKLOEJKN<TimeSpan> CDCIOBALJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly FKLFKLOEJKN<TimeSpan> IEPGDDMIINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly FKLFKLOEJKN<bool> LMHMBDABMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly FKLFKLOEJKN<bool> HAGJEBLHCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly FKLFKLOEJKN<bool> CPBCCGPJODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly FKLFKLOEJKN<int> OIHFCEOEPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly FKLFKLOEJKN<bool> MELGGMGPHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly FKLFKLOEJKN<bool> PEKBJBENLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly FKLFKLOEJKN<OEKNDJBDCIH> BHONMIOFILK;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan AJDGANOGBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x82DEFE0", Offset = "0x82DD7E0", VA = "0x1882DEFE0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan DKNDLNBMPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x82DF1B0", Offset = "0x82DD9B0", VA = "0x1882DF1B0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan LGHMBPCHFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x82DF130", Offset = "0x82DD930", VA = "0x1882DF130", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan NFECCNAHFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x82DF0B0", Offset = "0x82DD8B0", VA = "0x1882DF0B0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool FANNOIFGLFE
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x82DEF60", Offset = "0x82DD760", VA = "0x1882DEF60", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool CNCKHKBCLOE
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x82DEFA0", Offset = "0x82DD7A0", VA = "0x1882DEFA0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool HGNAPADGLBN
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x82DF1F0", Offset = "0x82DD9F0", VA = "0x1882DF1F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int NLBEGEOCOAL
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x82DF020", Offset = "0x82DD820", VA = "0x1882DF020", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool FFIMFHCNAEO
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x82DF170", Offset = "0x82DD970", VA = "0x1882DF170", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool AFFBECKCICD
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x82DF0F0", Offset = "0x82DD8F0", VA = "0x1882DF0F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool MMOOICCICFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x82DF060", Offset = "0x82DD860", VA = "0x1882DF060", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x82DF230", Offset = "0x82DDA30", VA = "0x1882DF230")]
	[UnityEngine.Scripting.Preserve]
	public HMPLEIJOKMI([LDAFGEHKDJK(null)] AGPOKEKNOGC HFMDFHLKMEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class AECFCHIEMIE : KOLJJJIKCKA, OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class KDGNBPIBGBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public DEALDLCNIEC roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public KDGNBPIBGBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x82EB770", Offset = "0x82E9F70", VA = "0x1882EB770")]
		internal object FOPJBEMGLNO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action JDKDJMGELEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x82D6550", Offset = "0x82D4D50", VA = "0x1882D6550", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x82D6AD0", Offset = "0x82D52D0", VA = "0x1882D6AD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event JKPHLHNDBHC HCBBKOMDAFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x82D6CB0", Offset = "0x82D54B0", VA = "0x1882D6CB0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x82D6690", Offset = "0x82D4E90", VA = "0x1882D6690", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event JKPHLHNDBHC FCMGHBLDAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x82D65F0", Offset = "0x82D4DF0", VA = "0x1882D65F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x82D6C10", Offset = "0x82D5410", VA = "0x1882D6C10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event JKPHLHNDBHC OJPBAADMLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x82D6D80", Offset = "0x82D5580", VA = "0x1882D6D80", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x82D6B70", Offset = "0x82D5370", VA = "0x1882D6B70", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<BIAEOMGDAEE, bool> ALGAABMIGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x82D6780", Offset = "0x82D4F80", VA = "0x1882D6780", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x82D69F0", Offset = "0x82D51F0", VA = "0x1882D69F0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "19")]
	public void NPIOKLMMDIH(IBNHMOEDCKG CDLOFOIHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x82D6E20", Offset = "0x82D5620", VA = "0x1882D6E20", Slot = "14")]
	public void PNGFNJIGIFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x82D6520", Offset = "0x82D4D20", VA = "0x1882D6520", Slot = "15")]
	public void ALFKPBPLALC(DEALDLCNIEC PDKLKKAPOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x82D6AA0", Offset = "0x82D52A0", VA = "0x1882D6AA0", Slot = "16")]
	public void JBLFBLGPAHJ(DEALDLCNIEC PDKLKKAPOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x82D6D50", Offset = "0x82D5550", VA = "0x1882D6D50", Slot = "17")]
	public void MLGAOFOHFFB(DEALDLCNIEC PDKLKKAPOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x82D6730", Offset = "0x82D4F30", VA = "0x1882D6730", Slot = "18")]
	public void FEGPJFKGKHD(BIAEOMGDAEE LBCFNOHNLPL, bool EJCCGIABFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x82D6830", Offset = "0x82D5030", VA = "0x1882D6830")]
	private void GINPGABDCGP(JKPHLHNDBHC HNDJPBGDNGH, DEALDLCNIEC PDKLKKAPOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AECFCHIEMIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[UnityEngine.Scripting.Preserve]
internal class IPHCOOPPCJI : CIAEDAHKOKG, OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class IFGGPOGICNC : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct HOJGJAFGAFD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public IFGGPOGICNC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public CIAEDAHKOKG.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private LGBPIAHJJBO <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private CPAPAKNBFAL[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private TaskAwaiter<CPAPAKNBFAL.LLPJINIKDPG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x82DF700", Offset = "0x82DDF00", VA = "0x1882DF700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x82DFE30", Offset = "0x82DE630", VA = "0x1882DFE30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private struct IBPGLAOECCB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public AsyncTaskMethodBuilder<CPAPAKNBFAL.LLPJINIKDPG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public CPAPAKNBFAL fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public IFGGPOGICNC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public CIAEDAHKOKG.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private LGBPIAHJJBO <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private KKKPLGMOBNE <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private TaskAwaiter<CPAPAKNBFAL.LLPJINIKDPG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x82DFF90", Offset = "0x82DE790", VA = "0x1882DFF90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x82E0C20", Offset = "0x82DF420", VA = "0x1882E0C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class OMFJLGHGLEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public CPAPAKNBFAL fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public OMFJLGHGLEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x82F2F40", Offset = "0x82F1740", VA = "0x1882F2F40")]
			internal object BKOMNMNCLAB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Task BFOIMBMKJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationTokenSource CCLIKBGHLPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public KKKPLGMOBNE OLGBIHAHIAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public DHHGNBFICMC LMJFACKNPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public CENHDONEPEA KNICMBDNGMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public ADDOLAOCDBG CDFKPNNAMDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public CPAPAKNBFAL[] DDJEKLADEKF;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool PKJNPIMLPAB
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x82E12C0", Offset = "0x82DFAC0", VA = "0x1882E12C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool AKKIMNLPLAC
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x82E2160", Offset = "0x82E0960", VA = "0x1882E2160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x82E2B70", Offset = "0x82E1370", VA = "0x1882E2B70")]
		public IFGGPOGICNC(DHHGNBFICMC LMJFACKNPAI, CENHDONEPEA KNICMBDNGMP, ADDOLAOCDBG CDFKPNNAMDG, CPAPAKNBFAL[] DDJEKLADEKF, CancellationToken DNHBNMHIDAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x82E12E0", Offset = "0x82DFAE0", VA = "0x1882E12E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x82E1610", Offset = "0x82DFE10", VA = "0x1882E1610")]
		public void FPIKDMGCHPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x82E26A0", Offset = "0x82E0EA0", VA = "0x1882E26A0")]
		public void PMOHFMEODIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x82E1B70", Offset = "0x82E0370", VA = "0x1882E1B70")]
		public void JGHNLOHDBCL(CIAEDAHKOKG.Reason LLGJHLMJGFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x82E1680", Offset = "0x82DFE80", VA = "0x1882E1680")]
		[AsyncStateMachine(typeof(HOJGJAFGAFD))]
		public Task IMCPGLKGHHD(CIAEDAHKOKG.Reason NLGEMFKLFCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x82E1780", Offset = "0x82DFF80", VA = "0x1882E1780")]
		[AsyncStateMachine(typeof(IBPGLAOECCB))]
		private Task<CPAPAKNBFAL.LLPJINIKDPG> IOALLPPKJEL(CIAEDAHKOKG.Reason NLGEMFKLFCF, CPAPAKNBFAL BMACLLDENKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x82E1F30", Offset = "0x82E0730", VA = "0x1882E1F30")]
		private void MHFKAIOAGPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x82E1210", Offset = "0x82DFA10", VA = "0x1882E1210")]
		public bool BFLJOICDFNP(CIAEDAHKOKG.Reason OBHAFMCDCPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x82E18C0", Offset = "0x82E00C0", VA = "0x1882E18C0")]
		private void IPAANOLAINH(KKKPLGMOBNE LLNIPANPIOA, CIAEDAHKOKG.Reason NLGEMFKLFCF = CIAEDAHKOKG.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x82E1040", Offset = "0x82DF840", VA = "0x1882E1040")]
		private void ALCAOCCECOI(KKKPLGMOBNE LLNIPANPIOA, CPAPAKNBFAL.LLPJINIKDPG HLPIAOANGMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x82E1470", Offset = "0x82DFC70", VA = "0x1882E1470")]
		private void FANGAJNJOFO(KKKPLGMOBNE LLNIPANPIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x82E22E0", Offset = "0x82E0AE0", VA = "0x1882E22E0")]
		private void PMCCABGFBNH(KKKPLGMOBNE LLNIPANPIOA, CPAPAKNBFAL.LLPJINIKDPG HLPIAOANGMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x82E2180", Offset = "0x82E0980", VA = "0x1882E2180")]
		private void PCFDNDFKMKP(KKKPLGMOBNE LLNIPANPIOA, Exception IIIACJLJMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x82E2050", Offset = "0x82E0850", VA = "0x1882E2050")]
		private void NMFCBCFOEME(CPAPAKNBFAL BMACLLDENKN, CIAEDAHKOKG.Reason NLGEMFKLFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x82E1E20", Offset = "0x82E0620", VA = "0x1882E1E20")]
		private void KFMCDKCLDPP(CPAPAKNBFAL BMACLLDENKN, CIAEDAHKOKG.Reason NLGEMFKLFCF, string LJDGHNENHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x82E2800", Offset = "0x82E1000", VA = "0x1882E2800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class KKKPLGMOBNE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Task<CPAPAKNBFAL.LLPJINIKDPG> BFOIMBMKJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public CancellationTokenSource CCLIKBGHLPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public CPAPAKNBFAL BMACLLDENKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public CIAEDAHKOKG.Reason LLGJHLMJGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public HashSet<CIAEDAHKOKG.Reason> HGICHEDMJKK;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool PKJNPIMLPAB
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x82E12C0", Offset = "0x82DFAC0", VA = "0x1882E12C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool AKKIMNLPLAC
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x82E2160", Offset = "0x82E0960", VA = "0x1882E2160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x82EC800", Offset = "0x82EB000", VA = "0x1882EC800")]
		public void MMGGKEIOFEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x82EC7E0", Offset = "0x82EAFE0", VA = "0x1882EC7E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x82EC960", Offset = "0x82EB160", VA = "0x1882EC960", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x82ECCC0", Offset = "0x82EB4C0", VA = "0x1882ECCC0")]
		public KKKPLGMOBNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class EBFOIACOIIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public CIAEDAHKOKG.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public EBFOIACOIIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x82DAE20", Offset = "0x82D9620", VA = "0x1882DAE20")]
		internal object PHFFIJGIFAC(KKKPLGMOBNE x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x82DAD40", Offset = "0x82D9540", VA = "0x1882DAD40")]
		internal object NJGBNCOKICH(IFGGPOGICNC x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x82DADB0", Offset = "0x82D95B0", VA = "0x1882DADB0")]
		internal object PEMFFDAPHFB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct IPIMCEICDGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public CIAEDAHKOKG.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public IPHCOOPPCJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private EBFOIACOIIA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x82E3B30", Offset = "0x82E2330", VA = "0x1882E3B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x82E4590", Offset = "0x82E2D90", VA = "0x1882E4590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct GPLLEOAKEDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public IPHCOOPPCJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public CIAEDAHKOKG.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private IFGGPOGICNC <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x82DDBF0", Offset = "0x82DC3F0", VA = "0x1882DDBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x82DE860", Offset = "0x82DD060", VA = "0x1882DE860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct NGIAOBFNGIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public IPHCOOPPCJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x82F1DE0", Offset = "0x82F05E0", VA = "0x1882F1DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x82F2350", Offset = "0x82F0B50", VA = "0x1882F2350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	internal static readonly LLPKKNNAIAE GFDGKLOEGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private IBNHMOEDCKG CDLOFOIHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private DHHGNBFICMC LMJFACKNPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private IFGGPOGICNC LOIOHKJHHLI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private CAAJIOJLKCC DNEAEPDOCGL
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x82E30A0", Offset = "0x82E18A0", VA = "0x1882E30A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool KKCHAJMNDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2330E20", Offset = "0x232F620", VA = "0x182330E20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool FFOMNFEDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x82E2C90", Offset = "0x82E1490", VA = "0x1882E2C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x82E3630", Offset = "0x82E1E30", VA = "0x1882E3630", Slot = "7")]
	public void NPIOKLMMDIH(IBNHMOEDCKG CDLOFOIHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x82E2E10", Offset = "0x82E1610", VA = "0x1882E2E10", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x82E34B0", Offset = "0x82E1CB0", VA = "0x1882E34B0", Slot = "9")]
	public void MMGGKEIOFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x82E2E20", Offset = "0x82E1620", VA = "0x1882E2E20")]
	private bool EKPGLHODIIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x82E2F00", Offset = "0x82E1700", VA = "0x1882E2F00", Slot = "6")]
	private void GAKFPIKHIAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x82E3980", Offset = "0x82E2180", VA = "0x1882E3980", Slot = "5")]
	[AsyncStateMachine(typeof(IPIMCEICDGL))]
	private Task PELNNJADCDB(CIAEDAHKOKG.Reason NLGEMFKLFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x82E36B0", Offset = "0x82E1EB0", VA = "0x1882E36B0")]
	private bool OHMCMEGGAPF(CIAEDAHKOKG.Reason NLGEMFKLFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x82E30F0", Offset = "0x82E18F0", VA = "0x1882E30F0")]
	private CPAPAKNBFAL[] LINKHNKLFFO(ADDOLAOCDBG CHIEPJFBIMN, CENHDONEPEA PNPCLEOGIGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x82E2D00", Offset = "0x82E1500", VA = "0x1882E2D00")]
	[AsyncStateMachine(typeof(GPLLEOAKEDJ))]
	private Task CJCBCOEOCGH(CIAEDAHKOKG.Reason NLGEMFKLFCF, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x82E2FD0", Offset = "0x82E17D0", VA = "0x1882E2FD0")]
	[AsyncStateMachine(typeof(NGIAOBFNGIF))]
	private Task HLKMDMJLLHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public IPHCOOPPCJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class KOPMIOCLDII : IIBBCEMMFDM, OACHLMNKJAD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct EEMEHIDBGKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public ADDOLAOCDBG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public KOPMIOCLDII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public DPNGIIIGHEF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x82DAE90", Offset = "0x82D9690", VA = "0x1882DAE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x82DB7F0", Offset = "0x82D9FF0", VA = "0x1882DB7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct AFPCABJMGEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public KOPMIOCLDII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public ADDOLAOCDBG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public DPNGIIIGHEF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private BGHFCMFIENI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private LGBPIAHJJBO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private ABNJELCGKNH <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private GJDGFHACGHA <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x82D7010", Offset = "0x82D5810", VA = "0x1882D7010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x82D7D60", Offset = "0x82D6560", VA = "0x1882D7D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class OIOPHCHEJJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public Matchmaking.ODEODNLADOA result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public LHJIGLOHNHI errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public OIOPHCHEJJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x82F2E90", Offset = "0x82F1690", VA = "0x1882F2E90")]
		internal object AIIJNHMDFEE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class HOCIMNBMMND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Task<HHEFLMKOLLI> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HOCIMNBMMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		internal Task<HHEFLMKOLLI> BMFELJOEEAF(BGHFCMFIENI<string>.KHCJHMNAJKC _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct JHLJAGHBAKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public KOPMIOCLDII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public ADDOLAOCDBG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public DPNGIIIGHEF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public ABNJELCGKNH joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private HOCIMNBMMND <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private ANMPLDNLLMO <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private LGBPIAHJJBO <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private CMMOHKIHFLN <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private Task<Matchmaking.MEGLOJEAPIG> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private BIBALFLOEHL <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.MEGLOJEAPIG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter<HHEFLMKOLLI> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x82E5CE0", Offset = "0x82E44E0", VA = "0x1882E5CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x82EB710", Offset = "0x82E9F10", VA = "0x1882EB710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct IGICBKOMOJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public KOPMIOCLDII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <disconnectTimerScope>5__3;

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
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8306F00", Offset = "0x8305700", VA = "0x188306F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8307960", Offset = "0x8306160", VA = "0x188307960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct HPFGFNOABNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public KOPMIOCLDII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private HHDGAAFLDEF <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x83056C0", Offset = "0x8303EC0", VA = "0x1883056C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8305B40", Offset = "0x8304340", VA = "0x188305B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct PDPLOOAFPBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public AsyncTaskMethodBuilder<Matchmaking.MEGLOJEAPIG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public ADDOLAOCDBG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public KOPMIOCLDII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TaskAwaiter<Matchmaking.MEGLOJEAPIG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x830FD00", Offset = "0x830E500", VA = "0x18830FD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x83101D0", Offset = "0x830E9D0", VA = "0x1883101D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct HECECGJNGEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public Matchmaking.MEGLOJEAPIG serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public KOPMIOCLDII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public ABNJELCGKNH joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private TaskAwaiter<LHPCAELPBGB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8304620", Offset = "0x8302E20", VA = "0x188304620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8304C60", Offset = "0x8303460", VA = "0x188304C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class HIOMMNKOCAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public ADDOLAOCDBG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HIOMMNKOCAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8304DC0", Offset = "0x83035C0", VA = "0x188304DC0")]
		internal object PIOJBJPKBLL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8304CC0", Offset = "0x83034C0", VA = "0x188304CC0")]
		internal string NEINLBIPOBJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct IFIKAIGBFCN : IAsyncStateMachine
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
		public ADDOLAOCDBG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public KOPMIOCLDII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private HIOMMNKOCAB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private LGBPIAHJJBO <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8306310", Offset = "0x8304B10", VA = "0x188306310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8306EA0", Offset = "0x83056A0", VA = "0x188306EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct GDCLCFPOOHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public KOPMIOCLDII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public ABNJELCGKNH joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public HHEFLMKOLLI initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public ADDOLAOCDBG targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public ANMPLDNLLMO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x8300AB0", Offset = "0x82FF2B0", VA = "0x188300AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x83012A0", Offset = "0x82FFAA0", VA = "0x1883012A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct BFPIJIKGNOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public KOPMIOCLDII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private LGBPIAHJJBO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap3;

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
		private LGBPIAHJJBO <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x82F79E0", Offset = "0x82F61E0", VA = "0x1882F79E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x82F91C0", Offset = "0x82F79C0", VA = "0x1882F91C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct FLPOJLMHMIN : IAsyncStateMachine
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
		public COICKFBCMHF localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public KOPMIOCLDII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<MJOPCCNIMCA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8300260", Offset = "0x82FEA60", VA = "0x188300260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8300A50", Offset = "0x82FF250", VA = "0x188300A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class LMEJENPIPJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public ADDOLAOCDBG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public LMEJENPIPJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x830A6F0", Offset = "0x8308EF0", VA = "0x18830A6F0")]
		internal object HFECJGCDAPG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class JLFEEHGIMDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public JLFEEHGIMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8308250", Offset = "0x8306A50", VA = "0x188308250")]
		internal void BINCFBDOLHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class NGGFFJOJNDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public ADDOLAOCDBG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public NGGFFJOJNDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x830CD00", Offset = "0x830B500", VA = "0x18830CD00")]
		internal object EOCAKKMOIFH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class PNHIPKPNNJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public ADDOLAOCDBG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public PNHIPKPNNJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x8313F20", Offset = "0x8312720", VA = "0x188313F20")]
		internal string ICMOPMAJCAM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly LLPKKNNAIAE FPHIGCCFAGB;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly LLPKKNNAIAE KJDBBMHKGMP;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly LLPKKNNAIAE JBOOENBPDEH;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly string HPNFFFGFLMJ;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static readonly string LOAEPNNHODM;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static readonly string KMJCHJJKOOG;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public static readonly Guid KJJKKCCCCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private ECOIGKPCBDF IGBOEAEPDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private GOGPOCOGOBL PMPBIKPEKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private FOAMNLJKJEK HIEPPCLFHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private IBNHMOEDCKG CDLOFOIHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private DHHGNBFICMC LMJFACKNPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private CIAEDAHKOKG BGKBJHFEPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private BGNAANIBOJP KBGGGNHPGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private KOLJJJIKCKA NAEDIAJJFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private OFLKHHIPKIE ALMPDKMNLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private IOECHHPJIMN GDLDGKPJNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private IDisposable HGJNLOOJGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private PPIGJJKFIEK LCKPIDMFOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly GKLIALCKGHC AFJNMFIOEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private BIBALFLOEHL ECINKMBKJIC;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus OAAOOKAPDKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA06680", Offset = "0xA04E80", VA = "0x180A06680", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x12C7F40", Offset = "0x12C6740", VA = "0x1812C7F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CAAJIOJLKCC DNEAEPDOCGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x82EF300", Offset = "0x82EDB00", VA = "0x1882EF300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x82EFBC0", Offset = "0x82EE3C0", VA = "0x1882EFBC0", Slot = "6")]
	public void NPIOKLMMDIH(IBNHMOEDCKG CDLOFOIHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x82EDF10", Offset = "0x82EC710", VA = "0x1882EDF10", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x82EF350", Offset = "0x82EDB50", VA = "0x1882EF350", Slot = "5")]
	[AsyncStateMachine(typeof(EEMEHIDBGKO))]
	public Task JDCJNIJLFNC(ADDOLAOCDBG NDOAKLELACH, DPNGIIIGHEF CPFLDOKAPNJ, CancellationToken HPBFCDCKFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x82EEE50", Offset = "0x82ED650", VA = "0x1882EEE50")]
	[AsyncStateMachine(typeof(AFPCABJMGEI))]
	private Task HOADIMHMNDG(ADDOLAOCDBG NDOAKLELACH, DPNGIIIGHEF CPFLDOKAPNJ, CancellationToken HPBFCDCKFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x82ED4B0", Offset = "0x82EBCB0", VA = "0x1882ED4B0")]
	private void CMKBOFCPNOC(OFLKHHIPKIE ALMPDKMNLAC, ADDOLAOCDBG NDOAKLELACH, Exception IIIACJLJMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x82EE250", Offset = "0x82ECA50", VA = "0x1882EE250")]
	private static void GBHFBBANCLB(GJDGFHACGHA JAHPNIOFIOM, Exception IIIACJLJMAE, [Optional] List<int> DAAMFPDOIGM, int PIKPNHELGDB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x82F0090", Offset = "0x82EE890", VA = "0x1882F0090")]
	[AsyncStateMachine(typeof(JHLJAGHBAKP))]
	private Task ONPNGCFLHAO(BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, ADDOLAOCDBG NDOAKLELACH, DPNGIIIGHEF CPFLDOKAPNJ, ABNJELCGKNH KMAMHDGKNIG, CancellationToken HPBFCDCKFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x82EEB20", Offset = "0x82ED320", VA = "0x1882EEB20")]
	private void GKJDOHFNGAH([CallerMemberName] string LKLMNEHMCBO = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x82EFA00", Offset = "0x82EE200", VA = "0x1882EFA00")]
	[AsyncStateMachine(typeof(IGICBKOMOJK))]
	private Task MOJCMAJBEOL(BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x82ED180", Offset = "0x82EB980", VA = "0x1882ED180")]
	private void BJBNFKDFEBG(ADDOLAOCDBG NDOAKLELACH, CancellationToken HPBFCDCKFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x82EDF60", Offset = "0x82EC760", VA = "0x1882EDF60")]
	private void EEMBLKOMAEH(ADDOLAOCDBG NDOAKLELACH, TaskStatus LMFHHGHJKAN, string NJAAPDELBNN, ABNJELCGKNH KMAMHDGKNIG, Exception GEIIPKBBOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x82F06E0", Offset = "0x82EEEE0", VA = "0x1882F06E0")]
	private void POIIMEOACGE(ADDOLAOCDBG NDOAKLELACH, ABNJELCGKNH KMAMHDGKNIG, OperationCanceledException HHPGDOKCJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x82EDA70", Offset = "0x82EC270", VA = "0x1882EDA70")]
	private void DHBBEJFOILM(ADDOLAOCDBG NDOAKLELACH, ABNJELCGKNH KMAMHDGKNIG, Exception IIIACJLJMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x82EDBC0", Offset = "0x82EC3C0", VA = "0x1882EDBC0")]
	private void DKAJHJJJCOP(ADDOLAOCDBG NDOAKLELACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x82ED120", Offset = "0x82EB920", VA = "0x1882ED120")]
	private static DEALDLCNIEC BHLJGBDDAJI(ADDOLAOCDBG NDOAKLELACH)
	{
		return default(DEALDLCNIEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x82EDAF0", Offset = "0x82EC2F0", VA = "0x1882EDAF0")]
	[AsyncStateMachine(typeof(HPFGFNOABNM))]
	private Task DJDICBINHOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x82ED910", Offset = "0x82EC110", VA = "0x1882ED910")]
	[AsyncStateMachine(typeof(PDPLOOAFPBO))]
	private Task<Matchmaking.MEGLOJEAPIG> DFNDMKDJKPF(ADDOLAOCDBG NDOAKLELACH, BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x82F01F0", Offset = "0x82EE9F0", VA = "0x1882F01F0")]
	private static LHPCAELPBGB OOGGOHKMJLP(Matchmaking.MEGLOJEAPIG GGJGDDBLIKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x82F0300", Offset = "0x82EEB00", VA = "0x1882F0300")]
	[AsyncStateMachine(typeof(HECECGJNGEL))]
	private Task PBPLEJCILHO(Matchmaking.MEGLOJEAPIG GGJGDDBLIKK, ABNJELCGKNH KMAMHDGKNIG, BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, CancellationToken EIOFNAEPDMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x82EFEF0", Offset = "0x82EE6F0", VA = "0x1882EFEF0")]
	[AsyncStateMachine(typeof(IFIKAIGBFCN))]
	private Task OAPAGLDDGEB(ADDOLAOCDBG NDOAKLELACH, CancellationTokenSource APFDHMEODMK, Task PDIKCFLPEHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x82EF0A0", Offset = "0x82ED8A0", VA = "0x1882EF0A0")]
	[AsyncStateMachine(typeof(GDCLCFPOOHA))]
	private Task IHJCCLODNKC(HHEFLMKOLLI OICCDEJOFAJ, ANMPLDNLLMO AGHAGDNHBHF, ADDOLAOCDBG CCJLADFMLKF, ABNJELCGKNH GLHBJDHPPAK, BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, CancellationToken KOJCMHOCLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x82EF5C0", Offset = "0x82EDDC0", VA = "0x1882EF5C0")]
	private ABNJELCGKNH LCHEPCACDMF(ABNJELCGKNH GLHBJDHPPAK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x82EDDD0", Offset = "0x82EC5D0", VA = "0x1882EDDD0")]
	[AsyncStateMachine(typeof(BFPIJIKGNOM))]
	private Task DOIHEOJOPFK(BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x82EF490", Offset = "0x82EDC90", VA = "0x1882EF490")]
	[AsyncStateMachine(typeof(FLPOJLMHMIN))]
	private Task JFHAIMJMLDF(CancellationToken DNHBNMHIDAC, int ECEJAIGHIDI, COICKFBCMHF LFBAMJJFDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x82F0450", Offset = "0x82EEC50", VA = "0x1882F0450")]
	private static void PHLLPIDLFGA(ADDOLAOCDBG NDOAKLELACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x82EF7B0", Offset = "0x82EDFB0", VA = "0x1882EF7B0")]
	private void LMGMCOIDBGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x82EE1C0", Offset = "0x82EC9C0", VA = "0x1882EE1C0")]
	private void FCNOKALNAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x82EEA90", Offset = "0x82ED290", VA = "0x1882EEA90")]
	private void GENHGEOMHBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x82EFB30", Offset = "0x82EE330", VA = "0x1882EFB30")]
	private void NIKAMJLLHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x82EF210", Offset = "0x82EDA10", VA = "0x1882EF210")]
	private static void IJEBMEPHEEF(ADDOLAOCDBG NDOAKLELACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x82F05D0", Offset = "0x82EEDD0", VA = "0x1882F05D0")]
	private static CancellationTokenRegistration PLOMGNAPDKK(ADDOLAOCDBG NDOAKLELACH, CancellationToken EIOFNAEPDMA)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x82EEFA0", Offset = "0x82ED7A0", VA = "0x1882EEFA0")]
	private static void IGHGOAEGGGC(ADDOLAOCDBG NDOAKLELACH, Exception IIIACJLJMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x82EECA0", Offset = "0x82ED4A0", VA = "0x1882EECA0")]
	private void HNJKHFHBJDI(ADDOLAOCDBG NDOAKLELACH, Task PDIKCFLPEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x82ED0C0", Offset = "0x82EB8C0", VA = "0x1882ED0C0")]
	private static void BAOGIJBMDME(Func<string> FJKOAJJOLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x82F0960", Offset = "0x82EF160", VA = "0x1882F0960")]
	public KOPMIOCLDII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x82F0030", Offset = "0x82EE830", VA = "0x1882F0030")]
	[CompilerGenerated]
	internal static (int, int?) OLDAGDKEMLB(LHJIGLOHNHI JBAPMMNBLOM)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[RecRoom.NoEngine.Common.Preserve]
internal class GKPBMOLJOLB : PKGLAMNHGHN, OACHLMNKJAD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct MIKLAFPBBAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public GKPBMOLJOLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public COICKFBCMHF localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x830A930", Offset = "0x8309130", VA = "0x18830A930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x830AE10", Offset = "0x8309610", VA = "0x18830AE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class DDKICGIFAPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public GKPBMOLJOLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public COICKFBCMHF localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public DDKICGIFAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x82FC710", Offset = "0x82FAF10", VA = "0x1882FC710")]
		internal List<Task> OFACPJNPFNM(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct NDMPIJLGLAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public HCLIEADMJEL taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public COICKFBCMHF localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x830C400", Offset = "0x830AC00", VA = "0x18830C400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x830C7A0", Offset = "0x830AFA0", VA = "0x18830C7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct MLEMJLOBHMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public GKPBMOLJOLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x830AE70", Offset = "0x8309670", VA = "0x18830AE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x830B150", Offset = "0x8309950", VA = "0x18830B150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly HashSet<HCLIEADMJEL> NKEFHJBEGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private GOGPOCOGOBL PMPBIKPEKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private IBNHMOEDCKG CDLOFOIHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private KOLLEJKBENP HNGEDDJBKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private IFPFHIBMHCM KNBHMJJNBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private IDisposable HGJNLOOJGEL;

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x83021E0", Offset = "0x83009E0", VA = "0x1883021E0", Slot = "5")]
	public void NPIOKLMMDIH(IBNHMOEDCKG CDLOFOIHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x83016D0", Offset = "0x82FFED0", VA = "0x1883016D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8302180", Offset = "0x8300980", VA = "0x188302180", Slot = "4")]
	public bool NMGIPDOKCJM(HCLIEADMJEL LCEGJIKNJEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8301E10", Offset = "0x8300610", VA = "0x188301E10")]
	private void MBOOMDHKGBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8301F60", Offset = "0x8300760", VA = "0x188301F60")]
	private void MPMCONLCJMC(CCOEKIMEHPP PDNEBCPKAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x8301C00", Offset = "0x8300400", VA = "0x188301C00")]
	[AsyncStateMachine(typeof(MIKLAFPBBAD))]
	private Task FAGJLKDICAE(int ECEJAIGHIDI, COICKFBCMHF LFBAMJJFDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8301600", Offset = "0x82FFE00", VA = "0x188301600")]
	private Func<CancellationToken, List<Task>> ANADLKPJEEB(int ECEJAIGHIDI, COICKFBCMHF LFBAMJJFDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8301730", Offset = "0x82FFF30", VA = "0x188301730")]
	private List<Task> EECBNEPKODJ(int ECEJAIGHIDI, COICKFBCMHF LFBAMJJFDKL, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x8301CF0", Offset = "0x83004F0", VA = "0x188301CF0")]
	[AsyncStateMachine(typeof(NDMPIJLGLAF))]
	private Task KELKIFBMAMB(HCLIEADMJEL FMJKHBAJLOP, CancellationToken JILOCOLKOMJ, int ECEJAIGHIDI, COICKFBCMHF LFBAMJJFDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x83024C0", Offset = "0x8300CC0", VA = "0x1883024C0")]
	[AsyncStateMachine(typeof(MLEMJLOBHMO))]
	private Task PHPFKMFNGHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x8301EE0", Offset = "0x83006E0", VA = "0x188301EE0")]
	private void MMGGKEIOFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x8302590", Offset = "0x8300D90", VA = "0x188302590")]
	public GKPBMOLJOLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[UnityEngine.Scripting.Preserve]
internal sealed class NCMLLBKFGCF : AKBEMKDEJEH, OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class AGHMDGAFBGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public AGHMDGAFBGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x82F7980", Offset = "0x82F6180", VA = "0x1882F7980")]
		internal object JPELIJLKNNA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class EIIJGKPJKBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public EIIJGKPJKBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x82FEAE0", Offset = "0x82FD2E0", VA = "0x1882FEAE0")]
		internal object PCNDJKFIKKG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class JAPONHDECPA
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public JAPONHDECPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class OHJILAJMENM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public OHJILAJMENM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x830F4F0", Offset = "0x830DCF0", VA = "0x18830F4F0")]
		internal object MAGKCLFBKEK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class FHFLPOOOCHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public FHFLPOOOCHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x82FFC30", Offset = "0x82FE430", VA = "0x1882FFC30")]
		internal object LHKNBJJBODJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private readonly Dictionary<Guid, FAGDBKELBAE> EFHGDJDKGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private readonly TimeSpan IBHHHOMCLAF;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "9")]
	public void NPIOKLMMDIH(IBNHMOEDCKG CDLOFOIHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x830B960", Offset = "0x830A160", VA = "0x18830B960", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x830C120", Offset = "0x830A920", VA = "0x18830C120", Slot = "4")]
	public EAJOEMNKDCL OIHLAKEIFNH(Guid KJHDGFKNPKN)
	{
		return default(EAJOEMNKDCL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x830B750", Offset = "0x8309F50", VA = "0x18830B750", Slot = "5")]
	public bool AHELLINFOCL(Guid KJHDGFKNPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x830BDF0", Offset = "0x830A5F0", VA = "0x18830BDF0", Slot = "6")]
	public bool MFIBGEFACIJ(Guid KJHDGFKNPKN, Task KJGICOEAHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x830BBA0", Offset = "0x830A3A0", VA = "0x18830BBA0", Slot = "7")]
	public bool JKEIOABIKAI(Guid KJHDGFKNPKN, MJOPCCNIMCA NLLLFHIJCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x830BD80", Offset = "0x830A580", VA = "0x18830BD80", Slot = "8")]
	public Task<(MJOPCCNIMCA, Task)> KDKBDHLMKOM(Guid KJHDGFKNPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x830B970", Offset = "0x830A170", VA = "0x18830B970")]
	private void HMDDBBPNLEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x830C340", Offset = "0x830AB40", VA = "0x18830C340")]
	public NCMLLBKFGCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[RecRoom.NoEngine.Common.Preserve]
internal class PJMNOJFLHOM : JCODMPBACKM, OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private class FGPOHHAAOOB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private readonly ADDOLAOCDBG NCCFEACBIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private readonly CancellationTokenSource GCOFADJEBOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public readonly CancellationToken AKDFEJKGFPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private bool DJCIJBJCHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private bool HGKGNONOPPK;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x82FFB80", Offset = "0x82FE380", VA = "0x1882FFB80")]
		public FGPOHHAAOOB(ADDOLAOCDBG NCCFEACBIPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x82FFA30", Offset = "0x82FE230", VA = "0x1882FFA30")]
		public void MMGGKEIOFEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x82FFA00", Offset = "0x82FE200", VA = "0x1882FFA00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class KMPEFLJCMBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public KBMOFBNCMMD disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public KMPEFLJCMBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x830A320", Offset = "0x8308B20", VA = "0x18830A320")]
		internal object NBPOCMJLBDJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct DLOJLBGHLFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public KBMOFBNCMMD disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public PJMNOJFLHOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x82FC7D0", Offset = "0x82FAFD0", VA = "0x1882FC7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x82FCC20", Offset = "0x82FB420", VA = "0x1882FCC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class FDKCHNGGFEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public PJMNOJFLHOM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public FDKCHNGGFEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x82FF990", Offset = "0x82FE190", VA = "0x1882FF990")]
		internal object PGCGJMINMEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class NOIPCFHJKGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public ADDOLAOCDBG newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public FDKCHNGGFEL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public NOIPCFHJKGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x830E130", Offset = "0x830C930", VA = "0x18830E130")]
		internal object HCGBHDNDKGB((ADDOLAOCDBG lastLocalPlayerRoomInstance, ADDOLAOCDBG newRoomInstance, CIAEDAHKOKG fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct DODECIJBCNM : IAsyncStateMachine
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
		public PJMNOJFLHOM <>4__this;

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
		private LGBPIAHJJBO <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x82FCC80", Offset = "0x82FB480", VA = "0x1882FCC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class IHFBNMOKBDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public ADDOLAOCDBG newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public IHFBNMOKBDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8307A00", Offset = "0x8306200", VA = "0x188307A00")]
		internal object IAHOKOIOHCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8307AE0", Offset = "0x83062E0", VA = "0x188307AE0")]
		internal void PCAABAGIIOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x8307AA0", Offset = "0x83062A0", VA = "0x188307AA0")]
		internal object ODEKMNNPPIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x83079C0", Offset = "0x83061C0", VA = "0x1883079C0")]
		internal object FBKKOIPDFCH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct PGCMMJPFNJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public ADDOLAOCDBG newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public PJMNOJFLHOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public DPNGIIIGHEF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private IHFBNMOKBDL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private LGBPIAHJJBO <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8310240", Offset = "0x830EA40", VA = "0x188310240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x8311200", Offset = "0x830FA00", VA = "0x188311200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly JKJAMGFDOAE.IEIKOLPMNOH ACAJPDHIHEK;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly BLAPDLNLEPM DFHJJEIDDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private GOGPOCOGOBL PMPBIKPEKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private IBNHMOEDCKG CDLOFOIHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private CIAEDAHKOKG BGKBJHFEPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private DHHGNBFICMC LMJFACKNPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private BOHPHODOLDK PKENAIPAKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private IIBBCEMMFDM FNDMBKNLKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private ADDOLAOCDBG IBDIFFKMKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private FGPOHHAAOOB FMPDGNOJAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private bool HDKHAEEJIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private Task KNILACBFEDK;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private CAAJIOJLKCC DNEAEPDOCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8312EA0", Offset = "0x83116A0", VA = "0x188312EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool AFCMMNDPLDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xC52870", Offset = "0xC51070", VA = "0x180C52870")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8312C40", Offset = "0x8311440", VA = "0x188312C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x8313880", Offset = "0x8312080", VA = "0x188313880", Slot = "4")]
	public void NPIOKLMMDIH(IBNHMOEDCKG CDLOFOIHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8312AD0", Offset = "0x83112D0", VA = "0x188312AD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8313500", Offset = "0x8311D00", VA = "0x188313500")]
	[AsyncStateMachine(typeof(DLOJLBGHLFK))]
	private Task MLKBDGAKCIJ(KBMOFBNCMMD EBFBJEHLGOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x8313170", Offset = "0x8311970", VA = "0x188313170")]
	private void MACFCDJBHBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x8313300", Offset = "0x8311B00", VA = "0x188313300")]
	private void MAFFOACHAMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8312EF0", Offset = "0x83116F0", VA = "0x188312EF0")]
	private void KMKDCGLMBNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8313490", Offset = "0x8311C90", VA = "0x188313490")]
	private bool MAHJBIKANON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x8312CA0", Offset = "0x83114A0", VA = "0x188312CA0")]
	[AsyncStateMachine(typeof(DODECIJBCNM))]
	private void GFEIHOMLNOH(int OJPIEODNKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x83135F0", Offset = "0x8311DF0", VA = "0x1883135F0")]
	private void NNCDAMFKAHL([Out] IDisposable NPOCBPGJIPJ, [Out] IDisposable LAJCGHNINPL, [Out] IDisposable HNNOFAPAPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8313070", Offset = "0x8311870", VA = "0x188313070")]
	private bool LFCDEFMJAEG(ADDOLAOCDBG NCCFEACBIPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8312C50", Offset = "0x8311450", VA = "0x188312C50")]
	private void FOEKMCPMJDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8312D70", Offset = "0x8311570", VA = "0x188312D70")]
	[AsyncStateMachine(typeof(PGCMMJPFNJN))]
	private Task HOADIMHMNDG(ADDOLAOCDBG NCCFEACBIPP, DPNGIIIGHEF CPFLDOKAPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8313EB0", Offset = "0x83126B0", VA = "0x188313EB0")]
	public PJMNOJFLHOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[UnityEngine.Scripting.Preserve]
internal sealed class NNKFEKCGGMB : LIBAMEGNOIL, OACHLMNKJAD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct GEGMMIKNLJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<HLOJBJMGFLA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public NNKFEKCGGMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<HLOJBJMGFLA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x8301300", Offset = "0x82FFB00", VA = "0x188301300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x8301590", Offset = "0x82FFD90", VA = "0x188301590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class PPNHCHAAFLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public NBCEMMDCCGB message;

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public PPNHCHAAFLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x8314600", Offset = "0x8312E00", VA = "0x188314600")]
		internal object CFMLMJLHPLN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class HLONCEHBDCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public NBCEMMDCCGB messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HLONCEHBDCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8305660", Offset = "0x8303E60", VA = "0x188305660")]
		internal object CAFKFCHIIMP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class EHOKMPFCEIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public NBCEMMDCCGB request;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public EHOKMPFCEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x82FEA80", Offset = "0x82FD280", VA = "0x1882FEA80")]
		internal object DFJGCDFCGCI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct AAANEAGNIDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public NBCEMMDCCGB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public NNKFEKCGGMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<LMDCPPPCHDP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x82F6FF0", Offset = "0x82F57F0", VA = "0x1882F6FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x82F78C0", Offset = "0x82F60C0", VA = "0x1882F78C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class OJNJJHCNPJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public NBCEMMDCCGB operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public OJNJJHCNPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x830F550", Offset = "0x830DD50", VA = "0x18830F550")]
		internal object PBHKOJEGPPH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct ENFHELPDODC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public NBCEMMDCCGB operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public NNKFEKCGGMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private ABNJELCGKNH <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<NBCEMMDCCGB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x82FEBA0", Offset = "0x82FD3A0", VA = "0x1882FEBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x82FF710", Offset = "0x82FDF10", VA = "0x1882FF710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct NAIFGHOOGDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public AsyncTaskMethodBuilder<LMDCPPPCHDP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public NNKFEKCGGMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public NBCEMMDCCGB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private NHDAHPGHDDA.NNAFOHHCNDB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private ABNJELCGKNH <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter<NBCEMMDCCGB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x830B1B0", Offset = "0x83099B0", VA = "0x18830B1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x830B6E0", Offset = "0x8309EE0", VA = "0x18830B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class DHAPGFNEMBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public LMDCPPPCHDP operation;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public DHAPGFNEMBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x82FC750", Offset = "0x82FAF50", VA = "0x1882FC750")]
		internal object FFKILLGDPAK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct JJKDHEFPGOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public LMDCPPPCHDP operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public NNKFEKCGGMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private BGHFCMFIENI<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x8307BC0", Offset = "0x83063C0", VA = "0x188307BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x83081F0", Offset = "0x83069F0", VA = "0x1883081F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class ACFJGDHCEJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public NBCEMMDCCGB request;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public ACFJGDHCEJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x82F7920", Offset = "0x82F6120", VA = "0x1882F7920")]
		internal object IKOMEEJOJDA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class IMFBLBLCHLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public NBCEMMDCCGB request;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public IMFBLBLCHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8307B60", Offset = "0x8306360", VA = "0x188307B60")]
		internal object ECKHIJCLHDL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private IBNHMOEDCKG CDLOFOIHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private BGNAANIBOJP KBGGGNHPGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private NJHHJFPHOAK LLMFLKIIFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private ADNGNJCDMJO JHMFEOBFGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private FOAMNLJKJEK HIEPPCLFHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private TaskCompletionSource<HLOJBJMGFLA> OBBFEALEKGE;

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x830E040", Offset = "0x830C840", VA = "0x18830E040", Slot = "7")]
	public void NPIOKLMMDIH(IBNHMOEDCKG CDLOFOIHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x830D700", Offset = "0x830BF00", VA = "0x18830D700", Slot = "6")]
	[AsyncStateMachine(typeof(GEGMMIKNLJH))]
	public Task<HLOJBJMGFLA> HIEINKOCEDG(CancellationToken GPIMMPEOKPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x830DBA0", Offset = "0x830C3A0", VA = "0x18830DBA0", Slot = "4")]
	public void LENHNEOICHO(NBCEMMDCCGB NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x830CFE0", Offset = "0x830B7E0", VA = "0x18830CFE0", Slot = "5")]
	public void CGAOPFGHMPC(NBCEMMDCCGB OCMNPKPKBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x830DF30", Offset = "0x830C730", VA = "0x18830DF30")]
	[AsyncStateMachine(typeof(AAANEAGNIDH))]
	private Task MMHNDMPHFFH(NBCEMMDCCGB JHLBOHEIAIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x830CED0", Offset = "0x830B6D0", VA = "0x18830CED0")]
	[AsyncStateMachine(typeof(ENFHELPDODC))]
	private Task BLNDJOALMBE(NBCEMMDCCGB FKHLGOGNENL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x830CD80", Offset = "0x830B580", VA = "0x18830CD80")]
	[AsyncStateMachine(typeof(NAIFGHOOGDI))]
	private Task<LMDCPPPCHDP> BAAHBNKJIHO(NBCEMMDCCGB JHLBOHEIAIJ, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x830D550", Offset = "0x830BD50", VA = "0x18830D550")]
	private ABNJELCGKNH EMMLNAFJBPP(NBCEMMDCCGB ACANOPILGDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x830D5E0", Offset = "0x830BDE0", VA = "0x18830D5E0")]
	[AsyncStateMachine(typeof(JJKDHEFPGOC))]
	private Task HFHKEBGEPKP(LMDCPPPCHDP EIJBIEHCPFH, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x830D340", Offset = "0x830BB40", VA = "0x18830D340")]
	private LMDCPPPCHDP DNHEBPHKHJL(NBCEMMDCCGB JHLBOHEIAIJ, ABNJELCGKNH BEHMGGPGCPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3933EE0", Offset = "0x39326E0", VA = "0x183933EE0")]
	private T EKBOIMNEIAL<T>(T OPMIAMEJKDH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x830D810", Offset = "0x830C010", VA = "0x18830D810")]
	private LMDCPPPCHDP KHNKEDLNJGN(NBCEMMDCCGB JHLBOHEIAIJ, ABNJELCGKNH BEHMGGPGCPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public NNKFEKCGGMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class CIOBANBCGBE : NJHHJFPHOAK, OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class MGCHNNLHNEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public MGCHNNLHNEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x830A8C0", Offset = "0x83090C0", VA = "0x18830A8C0")]
		internal object DFGBHLLCFBK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class BNIKJOLKGEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public BNIKJOLKGEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x82F9930", Offset = "0x82F8130", VA = "0x1882F9930")]
		internal object CCCBKGIHKMD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private FOAMNLJKJEK HIEPPCLFHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private KGFCPCHMJMI KHOLCDGBMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private LIBAMEGNOIL OILDOBGBPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private AKBEMKDEJEH EFHGDJDKGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private KBEBBAGNJGJ IGCCOBBOJON;

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x82FC5A0", Offset = "0x82FADA0", VA = "0x1882FC5A0", Slot = "6")]
	public void NPIOKLMMDIH(IBNHMOEDCKG CDLOFOIHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x82FB450", Offset = "0x82F9C50", VA = "0x1882FB450", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x82FAB90", Offset = "0x82F9390", VA = "0x1882FAB90", Slot = "4")]
	public EAJOEMNKDCL CMAEIEKPKAM(NBCEMMDCCGB OJOJFGLINHG)
	{
		return default(EAJOEMNKDCL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x82FA980", Offset = "0x82F9180", VA = "0x1882FA980", Slot = "5")]
	public void BOMADIIOHAE(Guid KJHDGFKNPKN, Task KJGICOEAHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x82FA8B0", Offset = "0x82F90B0", VA = "0x1882FA8B0")]
	private void AEEBHPCMAJD(byte JPNHFMOKNOK, int EEPMLGNKEHB, object FGPFFCBJFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x82FB500", Offset = "0x82F9D00", VA = "0x1882FB500")]
	private void FAOPDGLEKLC(MHMBBIOKCKM BKLKAFKNCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x82FBA80", Offset = "0x82FA280", VA = "0x1882FBA80")]
	private void KDALFBIFKCM(MHMBBIOKCKM BKLKAFKNCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x82FC360", Offset = "0x82FAB60", VA = "0x1882FC360")]
	private void MAIIPIHBCDG(MHMBBIOKCKM BKLKAFKNCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x82FAFB0", Offset = "0x82F97B0", VA = "0x1882FAFB0")]
	private MJOPCCNIMCA DIGEDMDMPAJ(NBCEMMDCCGB ACANOPILGDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x82FB250", Offset = "0x82F9A50", VA = "0x1882FB250")]
	private void DILFJFPDFEF(NBCEMMDCCGB FKHLGOGNENL, MJOPCCNIMCA NLLLFHIJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x82FBCF0", Offset = "0x82FA4F0", VA = "0x1882FBCF0")]
	private bool KJAILKONHHA(NBCEMMDCCGB FKHLGOGNENL, MJOPCCNIMCA NLLLFHIJCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x82FC150", Offset = "0x82FA950", VA = "0x1882FC150")]
	private bool MABIIKDBCFP(NBCEMMDCCGB HNGAOIJDAIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x82FBED0", Offset = "0x82FA6D0", VA = "0x1882FBED0")]
	private bool LDGOCFBOCJH(byte JPNHFMOKNOK, ExitGames.Client.Photon.Hashtable BKLKAFKNCOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public CIOBANBCGBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[UnityEngine.Scripting.Preserve]
internal sealed class NGGBEJJAGHH : LDMDOMDMHPI, OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class EOLFMGGIMEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public HLOJBJMGFLA operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public NGGBEJJAGHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public NBCEMMDCCGB roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public EOLFMGGIMEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x82FF920", Offset = "0x82FE120", VA = "0x1882FF920")]
		internal object CPIJIILJIJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x82FF770", Offset = "0x82FDF70", VA = "0x1882FF770")]
		internal object AEDLAEDFPPA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct CCDAFHOLHOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public AsyncTaskMethodBuilder<MJOPCCNIMCA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public NGGBEJJAGHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public NBCEMMDCCGB roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter<MJOPCCNIMCA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x82F99A0", Offset = "0x82F81A0", VA = "0x1882F99A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x82FA040", Offset = "0x82F8840", VA = "0x1882FA040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class GOMLHDJBBDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public HLOJBJMGFLA operationType;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public GOMLHDJBBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x83045B0", Offset = "0x8302DB0", VA = "0x1883045B0")]
		internal object NAMCHHOGLCF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class LLPFJOOMKEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public NBCEMMDCCGB request;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public LLPFJOOMKEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x830A610", Offset = "0x8308E10", VA = "0x18830A610")]
		internal object KMKNBFOGPMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x830A5A0", Offset = "0x8308DA0", VA = "0x18830A5A0")]
		internal object HLLBINIGNNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x830A680", Offset = "0x8308E80", VA = "0x18830A680")]
		internal object MOIJLBKNLCE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct GLMMNOFDEIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public AsyncTaskMethodBuilder<MJOPCCNIMCA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public NBCEMMDCCGB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public NGGBEJJAGHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private LLPFJOOMKEN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private EAJOEMNKDCL <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private MJOPCCNIMCA <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<(MJOPCCNIMCA validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x8302620", Offset = "0x8300E20", VA = "0x188302620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x8302EF0", Offset = "0x83016F0", VA = "0x188302EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private FOAMNLJKJEK HIEPPCLFHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private KGFCPCHMJMI KHOLCDGBMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private NJHHJFPHOAK LLMFLKIIFNG;

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x830CC50", Offset = "0x830B450", VA = "0x18830CC50", Slot = "5")]
	public void NPIOKLMMDIH(IBNHMOEDCKG CDLOFOIHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x830CB30", Offset = "0x830B330", VA = "0x18830CB30", Slot = "4")]
	[AsyncStateMachine(typeof(CCDAFHOLHOM))]
	private Task<MJOPCCNIMCA> KOKDOEMFCPC(NBCEMMDCCGB ACANOPILGDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x830C940", Offset = "0x830B140", VA = "0x18830C940")]
	private bool IEDGAFIBNII(HLOJBJMGFLA LBCFNOHNLPL, [Out] MJOPCCNIMCA HLPIAOANGMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x830C800", Offset = "0x830B000", VA = "0x18830C800")]
	[AsyncStateMachine(typeof(GLMMNOFDEIC))]
	private Task<MJOPCCNIMCA> GFCCOIKMFIK(NBCEMMDCCGB JHLBOHEIAIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public NGGBEJJAGHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class CFPPANOLOEN : OODEDDNEKOO, OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private struct OBFOLAOOPCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public COMDBKPAHPB PNDBAFBFNNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public long OKIJAKPGEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public Guid? OLFCGNLPGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public bool NCBOGPAOELP;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct GNBFLBEPMFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public AsyncTaskMethodBuilder<HHEFLMKOLLI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public ADDOLAOCDBG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public CFPPANOLOEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter<HCHPFAEFOMI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<HHEFLMKOLLI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x8302F60", Offset = "0x8301760", VA = "0x188302F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x8303530", Offset = "0x8301D30", VA = "0x188303530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class KNDEDALJIEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public KNDEDALJIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x830A3F0", Offset = "0x8308BF0", VA = "0x18830A3F0")]
		internal object IBGLKEEOIBO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct BNGLJJMCBNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<HCHPFAEFOMI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public CFPPANOLOEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public ADDOLAOCDBG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private KNDEDALJIEF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter<HCHPFAEFOMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x82F92D0", Offset = "0x82F7AD0", VA = "0x1882F92D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x82F98C0", Offset = "0x82F80C0", VA = "0x1882F98C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct PPJMPBDHALP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder<HHEFLMKOLLI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public CFPPANOLOEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public ADDOLAOCDBG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public HCHPFAEFOMI roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<OBFOLAOOPCK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8314020", Offset = "0x8312820", VA = "0x188314020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8314590", Offset = "0x8312D90", VA = "0x188314590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class OOBAHANCPGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public HCHPFAEFOMI roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public OOBAHANCPGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xE2AA10", Offset = "0xE29210", VA = "0x180E2AA10")]
		internal bool GEFNKOOEALI(EFHDFBNHLAI sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x830FC40", Offset = "0x830E440", VA = "0x18830FC40")]
		internal object GAGELLJONFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x830FBB0", Offset = "0x830E3B0", VA = "0x18830FBB0")]
		internal object EHJCMOJHOOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x830FB20", Offset = "0x830E320", VA = "0x18830FB20")]
		internal object DKONHIJJEOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class LKHDNCEMGAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public OOBAHANCPGI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public LKHDNCEMGAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x830A4A0", Offset = "0x8308CA0", VA = "0x18830A4A0")]
		internal object KBGCAFHBIDF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct GNHKEMGIMCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder<OBFOLAOOPCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public HCHPFAEFOMI roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public CFPPANOLOEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public ADDOLAOCDBG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private LKHDNCEMGAA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private TaskAwaiter<OBFOLAOOPCK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private TaskAwaiter<BAFFAAEPLJL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x83035A0", Offset = "0x8301DA0", VA = "0x1883035A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8304540", Offset = "0x8302D40", VA = "0x188304540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class BIBPAKCILBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public BIBPAKCILBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x82F9220", Offset = "0x82F7A20", VA = "0x1882F9220")]
		internal object KDPNAPAICJF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct PJHNEKHBONM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AsyncTaskMethodBuilder<OBFOLAOOPCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public EFHDFBNHLAI subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public CFPPANOLOEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public ADDOLAOCDBG dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private BIBPAKCILBN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private TaskAwaiter<OMKFKAIDNEH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8312390", Offset = "0x8310B90", VA = "0x188312390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8312A60", Offset = "0x8311260", VA = "0x188312A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private DHHGNBFICMC LMJFACKNPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private BOHPHODOLDK PKENAIPAKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private PDHBLMAPBNH NPHKFKOBBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private JIDDILENHDB IJLPEKHOLHA;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x82FA7C0", Offset = "0x82F8FC0", VA = "0x1882FA7C0", Slot = "5")]
	public void NPIOKLMMDIH(IBNHMOEDCKG CDLOFOIHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x82FA500", Offset = "0x82F8D00", VA = "0x1882FA500", Slot = "4")]
	[AsyncStateMachine(typeof(GNBFLBEPMFH))]
	public Task<HHEFLMKOLLI> FMMDJHKKPLA(BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, ADDOLAOCDBG NDOAKLELACH, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x82FA660", Offset = "0x82F8E60", VA = "0x1882FA660")]
	[AsyncStateMachine(typeof(BNGLJJMCBNC))]
	private Task<HCHPFAEFOMI> FOKBCKJJNCG(ADDOLAOCDBG NDOAKLELACH, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x82FA0B0", Offset = "0x82F88B0", VA = "0x1882FA0B0")]
	[AsyncStateMachine(typeof(PPJMPBDHALP))]
	private Task<HHEFLMKOLLI> DEFIANDFNIH(ADDOLAOCDBG NDOAKLELACH, HCHPFAEFOMI DDNKGBJDCEA, long ODGNDMLNOIH, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x82FA220", Offset = "0x82F8A20", VA = "0x1882FA220")]
	[AsyncStateMachine(typeof(GNHKEMGIMCK))]
	private Task<OBFOLAOOPCK> DMAMNAEEPLN(ADDOLAOCDBG NDOAKLELACH, HCHPFAEFOMI DDNKGBJDCEA, long ODGNDMLNOIH, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x82FA390", Offset = "0x82F8B90", VA = "0x1882FA390")]
	[AsyncStateMachine(typeof(PJHNEKHBONM))]
	private Task<OBFOLAOOPCK> FIPOAJOLPKM(ADDOLAOCDBG MNAKGPLIAMB, EFHDFBNHLAI POBLICOPOML, long ODGNDMLNOIH, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public CFPPANOLOEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[UnityEngine.Scripting.Preserve]
internal sealed class OGEHNOKODLF : ADNGNJCDMJO, OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class EBDCNLKMDIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public NBCEMMDCCGB request;

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public EBDCNLKMDIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x82FE3C0", Offset = "0x82FCBC0", VA = "0x1882FE3C0")]
		internal object LKIBAMCPDDH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private struct JMKBANKEBIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public AsyncTaskMethodBuilder<NBCEMMDCCGB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public NBCEMMDCCGB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public OGEHNOKODLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public ABNJELCGKNH pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private TaskAwaiter<NBCEMMDCCGB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x83082F0", Offset = "0x8306AF0", VA = "0x1883082F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8308900", Offset = "0x8307100", VA = "0x188308900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct EEOKEMBOKBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public AsyncTaskMethodBuilder<NBCEMMDCCGB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public OGEHNOKODLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public ABNJELCGKNH pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TaskAwaiter<EMECJJLINOC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x82FE420", Offset = "0x82FCC20", VA = "0x1882FE420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x82FEA10", Offset = "0x82FD210", VA = "0x1882FEA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class EJHEDOOOHDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public NBCEMMDCCGB request;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public EJHEDOOOHDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x82FEB40", Offset = "0x82FD340", VA = "0x1882FEB40")]
		internal object PPFAFHPJGOP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct PHNEOACBNAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder<NBCEMMDCCGB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public NBCEMMDCCGB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public OGEHNOKODLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public ABNJELCGKNH pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private LOJIFDBAMIB <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private HLBOPOEPMCC <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private TaskAwaiter<EMECJJLINOC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x8311730", Offset = "0x830FF30", VA = "0x188311730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x8312320", Offset = "0x8310B20", VA = "0x188312320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private FOAMNLJKJEK HIEPPCLFHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private CJPJONPIBFJ GPEBIFDONGP;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private HBIANJDPELM ADABGMEEMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x830EEE0", Offset = "0x830D6E0", VA = "0x18830EEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x830F3B0", Offset = "0x830DBB0", VA = "0x18830F3B0", Slot = "8")]
	public void NPIOKLMMDIH(IBNHMOEDCKG CDLOFOIHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x830EFA0", Offset = "0x830D7A0", VA = "0x18830EFA0", Slot = "4")]
	[AsyncStateMachine(typeof(JMKBANKEBIE))]
	public Task<NBCEMMDCCGB> IDOMMNGOOPL(NBCEMMDCCGB JHLBOHEIAIJ, ABNJELCGKNH BEHMGGPGCPF, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x830F260", Offset = "0x830DA60", VA = "0x18830F260", Slot = "5")]
	[AsyncStateMachine(typeof(EEOKEMBOKBH))]
	public Task<NBCEMMDCCGB> KDAOCFMMJNC(CancellationToken DNHBNMHIDAC, ABNJELCGKNH BEHMGGPGCPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x830F440", Offset = "0x830DC40", VA = "0x18830F440", Slot = "6")]
	public JIJPPLMKGGB OFCCPCHBNEL(LMDCPPPCHDP BHGMCKEPELK, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x830EDB0", Offset = "0x830D5B0", VA = "0x18830EDB0", Slot = "7")]
	public JIJPPLMKGGB ALBICNEOHBJ(LMDCPPPCHDP BHGMCKEPELK, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x830F100", Offset = "0x830D900", VA = "0x18830F100")]
	[AsyncStateMachine(typeof(PHNEOACBNAA))]
	private Task<NBCEMMDCCGB> KANPAODCJDN(NBCEMMDCCGB JHLBOHEIAIJ, ABNJELCGKNH BEHMGGPGCPF, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x38080E0", Offset = "0x38068E0", VA = "0x1838080E0")]
	private static byte[] LKGFOGCAJMO(NBCEMMDCCGB NJAAPDELBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public OGEHNOKODLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[UnityEngine.Scripting.Preserve]
internal sealed class FIPFBMJGIDG : KGFCPCHMJMI, OACHLMNKJAD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private BPHMPAJBIBK GLMIFODABPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private FOAMNLJKJEK HIEPPCLFHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private BGNAANIBOJP KBGGGNHPGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private HOKEHILMPLD FNODADMJNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private DHHGNBFICMC LMJFACKNPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private IIBBCEMMFDM FNDMBKNLKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private PKGLAMNHGHN HEECGAJJLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private BOHPHODOLDK PKENAIPAKDA;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private CAAJIOJLKCC DNEAEPDOCGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x82FFCA0", Offset = "0x82FE4A0", VA = "0x1882FFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static MJOPCCNIMCA BEPNLJCJPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x8300250", Offset = "0x82FEA50", VA = "0x188300250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x83000E0", Offset = "0x82FE8E0", VA = "0x1883000E0", Slot = "6")]
	public void NPIOKLMMDIH(IBNHMOEDCKG CDLOFOIHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x82FFF70", Offset = "0x82FE770", VA = "0x1882FFF70", Slot = "4")]
	public MJOPCCNIMCA NHKHIFHDCHF(GFEBJDBBDID NEFBNPHEJEC, HLOJBJMGFLA JAFKFKLBIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x82FFCF0", Offset = "0x82FE4F0", VA = "0x1882FFCF0", Slot = "5")]
	public MJOPCCNIMCA LOPLNEBPAKB(GFEBJDBBDID JJLLGPNLOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x82FFC90", Offset = "0x82FE490", VA = "0x1882FFC90")]
	private static MJOPCCNIMCA IFEOEHDDOJE(DMMLJMIMHAI NLGEMFKLFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FIPFBMJGIDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class KNAGEFOOCEA : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x830A3B0", Offset = "0x8308BB0", VA = "0x18830A3B0")]
	public KNAGEFOOCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x75497C0", Offset = "0x7547FC0", VA = "0x1875497C0")]
	public KNAGEFOOCEA(string NJAAPDELBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[UnityEngine.Scripting.Preserve]
internal sealed class KHBCPDPBFML : CEGLHANHICO, OACHLMNKJAD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct OFDHNAIGIMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public AsyncTaskMethodBuilder<MJOPCCNIMCA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public KHBCPDPBFML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public GANHOFFPCAM autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private BGHFCMFIENI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private EOCNKNEHJEA <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private TaskAwaiter<MJOPCCNIMCA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x830E1F0", Offset = "0x830C9F0", VA = "0x18830E1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x830ED40", Offset = "0x830D540", VA = "0x18830ED40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct HJPAOCCKPHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public KHBCPDPBFML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x8304EC0", Offset = "0x83036C0", VA = "0x188304EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x8305600", Offset = "0x8303E00", VA = "0x188305600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct OKPOELGFLIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public KHBCPDPBFML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x830F5B0", Offset = "0x830DDB0", VA = "0x18830F5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x830FAC0", Offset = "0x830E2C0", VA = "0x18830FAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct JPAEFCAAMCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public KHBCPDPBFML <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x8308970", Offset = "0x8307170", VA = "0x188308970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x83090B0", Offset = "0x83078B0", VA = "0x1883090B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct KIKAOGLKKJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public KHBCPDPBFML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x830A120", Offset = "0x8308920", VA = "0x18830A120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x830A2C0", Offset = "0x8308AC0", VA = "0x18830A2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct IENJGCDJCMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public KHBCPDPBFML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x8305BA0", Offset = "0x83043A0", VA = "0x188305BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x83062B0", Offset = "0x8304AB0", VA = "0x1883062B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct PGHMKEJOCOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public KHBCPDPBFML <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x8311260", Offset = "0x830FA60", VA = "0x188311260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x83116D0", Offset = "0x830FED0", VA = "0x1883116D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct OPJAMHILGKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public KHBCPDPBFML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public OCGCHDNKCFE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private BGHFCMFIENI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x832D870", Offset = "0x832C070", VA = "0x18832D870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x832DE10", Offset = "0x832C610", VA = "0x18832DE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private FOAMNLJKJEK HIEPPCLFHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private IBNHMOEDCKG CDLOFOIHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private DHHGNBFICMC LMJFACKNPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private ADNGNJCDMJO JHMFEOBFGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private BGNAANIBOJP KBGGGNHPGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private PKGLAMNHGHN HEECGAJJLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private CancellationTokenSource GLINEKJDJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private Task GOIENIFLGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private TaskCompletionSource<int> PMDHADEGNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private int GDFIINCONEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private int GDJKEKLNNDK;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x8309F70", Offset = "0x8308770", VA = "0x188309F70", Slot = "6")]
	public void NPIOKLMMDIH(IBNHMOEDCKG CDLOFOIHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1273860", Offset = "0x1272060", VA = "0x181273860", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x8309200", Offset = "0x8307A00", VA = "0x188309200")]
	private void BNEHIADANAN(float FIPAPPPKKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x83092E0", Offset = "0x8307AE0", VA = "0x1883092E0", Slot = "4")]
	[AsyncStateMachine(typeof(OFDHNAIGIMK))]
	public Task<MJOPCCNIMCA> GDLFNIDJDBA(GANHOFFPCAM EFAOGHPAKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x8309110", Offset = "0x8307910", VA = "0x188309110", Slot = "5")]
	[AsyncStateMachine(typeof(HJPAOCCKPHG))]
	public Task BCBOFHFGMPJ([Optional] CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x1273860", Offset = "0x1272060", VA = "0x181273860")]
	public void HFFHKFCHOFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x8309520", Offset = "0x8307D20", VA = "0x188309520")]
	private EOCNKNEHJEA HLNNGCFBBNO(GANHOFFPCAM EFAOGHPAKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x8309780", Offset = "0x8307F80", VA = "0x188309780")]
	[AsyncStateMachine(typeof(OKPOELGFLIM))]
	private Task JHFAANKBIDO(CancellationToken HPBFCDCKFAO, int ECEJAIGHIDI, COICKFBCMHF LFBAMJJFDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x8309D70", Offset = "0x8308570", VA = "0x188309D70")]
	[AsyncStateMachine(typeof(JPAEFCAAMCP))]
	private Task MHPOCKMMHBN(CancellationToken HPBFCDCKFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x8309690", Offset = "0x8307E90", VA = "0x188309690")]
	[AsyncStateMachine(typeof(KIKAOGLKKJO))]
	private Task JBMCFFNFKGH([Optional] CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x8309A00", Offset = "0x8308200", VA = "0x188309A00")]
	[AsyncStateMachine(typeof(IENJGCDJCMB))]
	private Task LNEDLJCLHMO(CancellationToken HPBFCDCKFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x8309E70", Offset = "0x8308670", VA = "0x188309E70")]
	[AsyncStateMachine(typeof(PGHMKEJOCOB))]
	private Task NKDJBOAEMDM(CancellationToken BAAKFBINONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x8309870", Offset = "0x8308070", VA = "0x188309870")]
	private Task KDAPJDFAIJB(OCGCHDNKCFE FGGEEODNNKF, CancellationToken HPBFCDCKFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x8309410", Offset = "0x8307C10", VA = "0x188309410")]
	[AsyncStateMachine(typeof(OPJAMHILGKJ))]
	private Task HEGAMCFIPEM(OCGCHDNKCFE FGGEEODNNKF, CancellationToken HPBFCDCKFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x8309AF0", Offset = "0x83082F0", VA = "0x188309AF0")]
	private bool LOFLJLLBAOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public KHBCPDPBFML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[UnityEngine.Scripting.Preserve]
internal class ADMEIAEDIBN : HOKEHILMPLD, OACHLMNKJAD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct PKGCIJPDPNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public ADMEIAEDIBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private BGHFCMFIENI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x832E3A0", Offset = "0x832CBA0", VA = "0x18832E3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x832E950", Offset = "0x832D150", VA = "0x18832E950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private IKDBLDBFNFM PGELCPLMIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private IBNHMOEDCKG CDLOFOIHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private KGFCPCHMJMI KHOLCDGBMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private ADNGNJCDMJO JHMFEOBFGHK;

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x83152F0", Offset = "0x8313AF0", VA = "0x1883152F0", Slot = "6")]
	public void NPIOKLMMDIH(IBNHMOEDCKG CDLOFOIHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x83150A0", Offset = "0x83138A0", VA = "0x1883150A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x8314FA0", Offset = "0x83137A0", VA = "0x188314FA0", Slot = "5")]
	[AsyncStateMachine(typeof(PKGCIJPDPNF))]
	public Task BOIAKFMJFOJ(string CGOKOPBMMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x8315230", Offset = "0x8313A30", VA = "0x188315230", Slot = "4")]
	public MJOPCCNIMCA LOFLJLLBAOF(GFEBJDBBDID NEFBNPHEJEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x83150F0", Offset = "0x83138F0", VA = "0x1883150F0")]
	private DKLFMBKNIBG JPHIJGPIBJC(string CGOKOPBMMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public ADMEIAEDIBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class KAFHICCJEOO
{
	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x8322AD0", Offset = "0x83212D0", VA = "0x188322AD0")]
	public static void FJPGCFLOGIN(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x8322970", Offset = "0x8321170", VA = "0x188322970")]
	internal static void DEELCNFAMAH(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x8322D10", Offset = "0x8321510", VA = "0x188322D10")]
	internal static void MJFCNALEGJE(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x8322DF0", Offset = "0x83215F0", VA = "0x188322DF0")]
	internal static void OCIFEINIHFL(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x3830810", Offset = "0x382F010", VA = "0x183830810")]
	private static void HDPHFNGKBBF<Interface, Impl, Interface>(HHDGAAFLDEF PMKEELMHMLA) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class GOFOKMPOKBO : EBAAJOPFNMH<NBCEMMDCCGB>
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class COBMMBEJOMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public NBCEMMDCCGB message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public COBMMBEJOMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x83182A0", Offset = "0x8316AA0", VA = "0x1883182A0")]
		internal object FKBPCAPNJHP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly GOFOKMPOKBO DJLOIKDDKCN;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x831D510", Offset = "0x831BD10", VA = "0x18831D510")]
	public ExitGames.Client.Photon.Hashtable LIJGMGKAKKG(NBCEMMDCCGB NJAAPDELBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x831D140", Offset = "0x831B940", VA = "0x18831D140", Slot = "5")]
	protected override void EELHLADNKKN(NBCEMMDCCGB NJAAPDELBNN, IDictionary<object, object> NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x831D5A0", Offset = "0x831BDA0", VA = "0x18831D5A0", Slot = "6")]
	public override NBCEMMDCCGB MPBEICGIKAG(IDictionary<object, object> NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x831D030", Offset = "0x831B830", VA = "0x18831D030")]
	private static void BAOGIJBMDME(string CJHIOALEEJB, NBCEMMDCCGB NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x831D860", Offset = "0x831C060", VA = "0x18831D860")]
	public GOFOKMPOKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x831D270", Offset = "0x831BA70", VA = "0x18831D270")]
	[CompilerGenerated]
	internal static string HLBLMGHNKKA(HHEFLMKOLLI JDGDKOENECG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class GJJECALIGBJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static MJOPCCNIMCA BEPNLJCJPFD
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x831CD10", Offset = "0x831B510", VA = "0x18831CD10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x831CD70", Offset = "0x831B570", VA = "0x18831CD70")]
	public static bool PKGAGENMEGF(this MJOPCCNIMCA NLLLFHIJCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x831CAC0", Offset = "0x831B2C0", VA = "0x18831CAC0")]
	public static MJOPCCNIMCA IFEOEHDDOJE(DMMLJMIMHAI OJFJOGGNGGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x831CB20", Offset = "0x831B320", VA = "0x18831CB20")]
	public static MJOPCCNIMCA JNBDEOAGGKP(IEnumerable<MJOPCCNIMCA> KOMBMNJBDGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x831C870", Offset = "0x831B070", VA = "0x18831C870")]
	public static string FMNOHHMBLNN(this MJOPCCNIMCA HLPIAOANGMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public abstract class IPBBLCLBHEE : CDHHAFMGPDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public delegate MJOPCCNIMCA MOLBHGAAFIK([NotNull] GFEBJDBBDID KLBOJNFLPCJ);

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class NPHCLPJBDBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public GFEBJDBBDID photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public NPHCLPJBDBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x152BBB0", Offset = "0x152A3B0", VA = "0x18152BBB0")]
		internal MJOPCCNIMCA HCCDHHKMDGD(MOLBHGAAFIK v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	private bool IHDAJILAEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038E")]
	protected readonly HashSet<MOLBHGAAFIK> DLPBFAFGOGK;

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x8320BA0", Offset = "0x831F3A0", VA = "0x188320BA0", Slot = "4")]
	public void FHIFLNAKOGN(MOLBHGAAFIK JPBLPENMDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x8320AF0", Offset = "0x831F2F0", VA = "0x188320AF0", Slot = "5")]
	public void CDLLDPMGPNL(MOLBHGAAFIK JPBLPENMDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x8320B50", Offset = "0x831F350", VA = "0x188320B50", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x8320C00", Offset = "0x831F400", VA = "0x188320C00")]
	protected MJOPCCNIMCA MMHMJFIDDCH(GFEBJDBBDID JJLLGPNLOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x8320E90", Offset = "0x831F690", VA = "0x188320E90")]
	protected IPBBLCLBHEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public class DFODBGAMNAE : IPBBLCLBHEE, BPHMPAJBIBK, CDHHAFMGPDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class IHGJEAKDGKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public MJOPCCNIMCA result;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public IHGJEAKDGKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8320A90", Offset = "0x831F290", VA = "0x188320A90")]
		internal object BFCKPNLDMPN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x8319790", Offset = "0x8317F90", VA = "0x188319790")]
	[UnityEngine.Scripting.Preserve]
	public DFODBGAMNAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x8319680", Offset = "0x8317E80", VA = "0x188319680", Slot = "8")]
	public MJOPCCNIMCA MHIJCDAPEAC(GFEBJDBBDID JJLLGPNLOHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class ICFKONLECMC : IPBBLCLBHEE, IKDBLDBFNFM, CDHHAFMGPDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class KJPDIIBKGIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public MJOPCCNIMCA result;

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public KJPDIIBKGIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x8323A50", Offset = "0x8322250", VA = "0x188323A50")]
		internal object DJCLAEELGEG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x8319790", Offset = "0x8317F90", VA = "0x188319790")]
	[UnityEngine.Scripting.Preserve]
	public ICFKONLECMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x8320040", Offset = "0x831E840", VA = "0x188320040", Slot = "8")]
	public MJOPCCNIMCA LOFLJLLBAOF(GFEBJDBBDID JFDOFPAEGJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal static class PCKMCPNBLPL
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class MPPMLPPOJBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public BGHFCMFIENI<string> timer;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public MPPMLPPOJBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x832A660", Offset = "0x8328E60", VA = "0x18832A660")]
		internal object HMKIKNJNFOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x832E2C0", Offset = "0x832CAC0", VA = "0x18832E2C0")]
	public static BGHFCMFIENI<string> PBCBDFMIBMO(LLPKKNNAIAE NOMHFHBJHNN, [Optional] string JFIIMGPBPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x832E140", Offset = "0x832C940", VA = "0x18832E140")]
	public static void CEANAFIBHDP(BGHFCMFIENI<string> NIBJMJJGOBF, LLPKKNNAIAE NOMHFHBJHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x832E200", Offset = "0x832CA00", VA = "0x18832E200")]
	public static string GNDJIFFGBNE(NBCEMMDCCGB ACANOPILGDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal static class BOLOIHMEFAP
{
	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x8317580", Offset = "0x8315D80", VA = "0x188317580")]
	public static void EENIKJENDFO(this FOAMNLJKJEK HIEPPCLFHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x8317590", Offset = "0x8315D90", VA = "0x188317590")]
	public static void KBFKFLEBCJE(this FOAMNLJKJEK HIEPPCLFHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x83175A0", Offset = "0x8315DA0", VA = "0x1883175A0")]
	private static void NHMADGCPLEE(this FOAMNLJKJEK HIEPPCLFHOF, bool JIJPLJJFIMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class LNBNFGMJKNF : KFHAELEHMGM, CHAFJNOMFLF, KMOHBMIJHLP, LICGECJPOEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	private readonly CHAFJNOMFLF IOBCPCHPFDC;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public GFEBJDBBDID MIFHJIFKLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x8326690", Offset = "0x8324E90", VA = "0x188326690", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int PPMDNNIJEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x83269B0", Offset = "0x83251B0", VA = "0x1883269B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int CNKHHFMFJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x8326790", Offset = "0x8324F90", VA = "0x188326790", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool ADAEIDAFINM
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int OPHONDFMJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xBCB360", Offset = "0xBC9B60", VA = "0x180BCB360", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event OODAEKHKKNF.FIGPOPJHGGF IJKMEICIABJ
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event FAJLDFMGMGK JCNLOMNMNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x83268C0", Offset = "0x83250C0", VA = "0x1883268C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x83265F0", Offset = "0x8324DF0", VA = "0x1883265F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> PDCLLDKOGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<GFEBJDBBDID> CHBCPHDBKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action PKCDLDELFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x83264B0", Offset = "0x8324CB0", VA = "0x1883264B0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x8326550", Offset = "0x8324D50", VA = "0x188326550", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0xCCF9C0", Offset = "0xCCE1C0", VA = "0x180CCF9C0")]
	public LNBNFGMJKNF(CHAFJNOMFLF IOBCPCHPFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x83266E0", Offset = "0x8324EE0", VA = "0x1883266E0", Slot = "8")]
	public bool HDNGAMFOHND(byte JPNHFMOKNOK, object PJHLMONHMFJ, MEBJAELMEMP GONNDGNNCBE, SendOptions ALFGGMACGOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x83267E0", Offset = "0x8324FE0", VA = "0x1883267E0", Slot = "16")]
	public GFEBJDBBDID KFCAMPLBAKJ(int DCILOEIKONN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "19")]
	public void BDDPEGBPHFP(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "20")]
	public void IDONALOINPI(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "21")]
	public void IEPNGDGMDGF(object JILOCOLKOMJ, bool PACEJFCJBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x8326960", Offset = "0x8325160", VA = "0x188326960", Slot = "22")]
	public IDisposable KODAEFCMOLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "23")]
	private bool LBCOFANPCKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "24")]
	public void EDGMLPNFIEG(StringBuilder ONNNBFKHFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0xF643B0", Offset = "0xF62BB0", VA = "0x180F643B0", Slot = "25")]
	public bool MMFIDCFBKIA(bool MLDIOLLNCGP, [Out] string LKNKJJBHDKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0xEEFA50", Offset = "0xEEE250", VA = "0x180EEFA50", Slot = "28")]
	public void EIHKCEFGPFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal struct MHMBBIOKCKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	private readonly IDictionary<object, object> BKLKAFKNCOH;

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0xCEDE50", Offset = "0xCEC650", VA = "0x180CEDE50")]
	public MHMBBIOKCKM(IDictionary<object, object> BKLKAFKNCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x8329610", Offset = "0x8327E10", VA = "0x188329610")]
	public bool DAEPJHPJBGA([Out] NBCEMMDCCGB NJAAPDELBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x83296C0", Offset = "0x8327EC0", VA = "0x1883296C0")]
	public Guid GIFFDNLJFFF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x83294E0", Offset = "0x8327CE0", VA = "0x1883294E0")]
	public MJOPCCNIMCA AGCIAPOFGEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x8329770", Offset = "0x8327F70", VA = "0x188329770")]
	public static ExitGames.Client.Photon.Hashtable NKIHIDGHACP(NBCEMMDCCGB NJAAPDELBNN, MJOPCCNIMCA NLLLFHIJCAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal static class DHBIKBBGLNK
{
	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x83197A0", Offset = "0x8317FA0", VA = "0x1883197A0")]
	public static bool GAIOMCDPEFC(this ADDOLAOCDBG CDFKPNNAMDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct IFPFHIBMHCM : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct LKCMIPNHKFN : IAsyncStateMachine
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
		public IFPFHIBMHCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x83255C0", Offset = "0x8323DC0", VA = "0x1883255C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x83257A0", Offset = "0x8323FA0", VA = "0x1883257A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	private readonly CancellationTokenSource GCOFADJEBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	private bool IHDAJILAEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	private Task BFOIMBMKJIA;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool FFFKLPKJBMG
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x83202B0", Offset = "0x831EAB0", VA = "0x1883202B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x83202E0", Offset = "0x831EAE0", VA = "0x1883202E0")]
	public IFPFHIBMHCM(CancellationToken DNHBNMHIDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x8320150", Offset = "0x831E950", VA = "0x188320150")]
	[AsyncStateMachine(typeof(LKCMIPNHKFN))]
	public Task CGCNLGKKAMJ(Func<CancellationToken, List<Task>> BPBMHGHEFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x8320260", Offset = "0x831EA60", VA = "0x188320260", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public readonly struct CBEIFODGGIG<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct EHEJDJCAEEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<CCNPADACDGN<TData>, PLLAIPNOLPG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public CBEIFODGGIG<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private TaskAwaiter<HCGBMJDNFKJ<CCNPADACDGN<TData>, PLLAIPNOLPG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x43F9F00", Offset = "0x43F8700", VA = "0x1843F9F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x43FB080", Offset = "0x43F9880", VA = "0x1843FB080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	private readonly DBGMCEFPAHH<TGetDataArg, TData> DDCMACNPPHA;

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0xCEDE50", Offset = "0xCEC650", VA = "0x180CEDE50")]
	internal CBEIFODGGIG(DBGMCEFPAHH<TGetDataArg, TData> ILEBEOADOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6307250", Offset = "0x6305A50", VA = "0x186307250")]
	[AsyncStateMachine(typeof(CBEIFODGGIG<, >.EHEJDJCAEEG))]
	public Task<HCGBMJDNFKJ<CCNPADACDGN<TData>, PLLAIPNOLPG>> BEEPOCDHMCP(TGetDataArg MJAILKMLAHP, string GNBEKBOKOKH, BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public static class BIGGLKEMNLI
{
	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x352A9A0", Offset = "0x35291A0", VA = "0x18352A9A0")]
	public static CBEIFODGGIG<TGetDataArg, TData> CJOJELENPLJ<TGetDataArg, TData>(DBGMCEFPAHH<TGetDataArg, TData> ILEBEOADOPL)
	{
		return default(CBEIFODGGIG<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public struct LHJIGLOHNHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public readonly int GBDGOENPFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public readonly int? OCAGKGIAILL;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x4FB7450", Offset = "0x4FB5C50", VA = "0x184FB7450")]
	public LHJIGLOHNHI(int HLGPGMAFMLJ, [Optional] int? MLFGJKOBCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x83252E0", Offset = "0x8323AE0", VA = "0x1883252E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface FHEHNMANKEG<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPHPBFOFJMN();

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FHEHNMANKEG<T> PAPIEPGJLPB(string EEELONGPGHO);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FHEHNMANKEG<T> BFCINCLFMKL(OAFEDIEEIKO<T> IEDDLCDKEDH);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FHEHNMANKEG<T> FEPCOLCIDFM(int JBAPMMNBLOM);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FHEHNMANKEG<T> IBGIKIEJIPH(int JBAPMMNBLOM, FFEFPADGJGO<T> JPGFLJLLEEF);
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface OFLKHHIPKIE
{
	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FHEHNMANKEG<T> PMNNEECOLHL<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JCLBGHPPIHM JHFMAKKGPNB(Exception IIIACJLJMAE);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LHJIGLOHNHI PANCEIHPBHI(Exception IIIACJLJMAE);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public delegate string OAFEDIEEIKO<in T>(T IIIACJLJMAE) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public delegate int FFEFPADGJGO<in T>(T IIIACJLJMAE) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class MBHECGFGCML : OFLKHHIPKIE
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private delegate string IDFEIAACAGF(Exception IIIACJLJMAE);

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private delegate int MNAJKJBGPPC(Exception IIIACJLJMAE);

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class HPMCLOMEFAL<T> : FHEHNMANKEG<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		[CompilerGenerated]
		private sealed class MGCIJMLKJHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public MGCIJMLKJHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			internal string CDPOGBCPAHB(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000100")]
		[CompilerGenerated]
		private sealed class JMFKKBJLDBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public OAFEDIEEIKO<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public JMFKKBJLDBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x48E1DB0", Offset = "0x48E05B0", VA = "0x1848E1DB0")]
			internal string AIKJCPCCCKH(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class FMGMPPDABCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public FFEFPADGJGO<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public FMGMPPDABCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x48E1DB0", Offset = "0x48E05B0", VA = "0x1848E1DB0")]
			internal int CDAEFHPDBPE(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private readonly MBHECGFGCML ALMPDKMNLAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private readonly Type JJEEOPDCKAO;

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x4A9FD30", Offset = "0x4A9E530", VA = "0x184A9FD30")]
		internal HPMCLOMEFAL(MBHECGFGCML ALMPDKMNLAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x4A9FA70", Offset = "0x4A9E270", VA = "0x184A9FA70", Slot = "4")]
		public void DPHPBFOFJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x4A9FC10", Offset = "0x4A9E410", VA = "0x184A9FC10", Slot = "5")]
		public FHEHNMANKEG<T> PAPIEPGJLPB(string EEELONGPGHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x4A9F950", Offset = "0x4A9E150", VA = "0x184A9F950", Slot = "6")]
		public FHEHNMANKEG<T> BFCINCLFMKL(OAFEDIEEIKO<T> IEDDLCDKEDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x4A9FAA0", Offset = "0x4A9E2A0", VA = "0x184A9FAA0", Slot = "7")]
		public FHEHNMANKEG<T> FEPCOLCIDFM(int JBAPMMNBLOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x4A9FAE0", Offset = "0x4A9E2E0", VA = "0x184A9FAE0", Slot = "8")]
		public FHEHNMANKEG<T> IBGIKIEJIPH(int JBAPMMNBLOM, FFEFPADGJGO<T> JPGFLJLLEEF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class FHGJMJALEAP<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private bool KJMIEAIAONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly List<Type> DBCFADHGDHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly Dictionary<Type, TVal> BDNHAKIBKMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly Dictionary<Type, int> IDGEJIGJNNN;

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public IReadOnlyList<Type> MMCDECHJOKC
		{
			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x48C6830", Offset = "0x48C5030", VA = "0x1848C6830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x48C6A00", Offset = "0x48C5200", VA = "0x1848C6A00")]
		public FHGJMJALEAP(Dictionary<Type, int> IDGEJIGJNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x48C6620", Offset = "0x48C4E20", VA = "0x1848C6620")]
		public void OIHLAKEIFNH(Type BELIEAFHDAH, TVal DDLBJHGGANE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x48C6490", Offset = "0x48C4C90", VA = "0x1848C6490")]
		public bool MJLPJLFNNBA(Type JJEEOPDCKAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x48C6440", Offset = "0x48C4C40", VA = "0x1848C6440")]
		public bool LMPMKEBMPHA(TVal OPMIAMEJKDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x48C63F0", Offset = "0x48C4BF0", VA = "0x1848C63F0")]
		public TVal EFPADONOPCC(Type PIJHKCJDAHO)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x48C6580", Offset = "0x48C4D80", VA = "0x1848C6580")]
		[CompilerGenerated]
		private int NMNECLKPGJH(Type GDFPINKAFAJ, Type OMFCKAKBOJH)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class HHNNKGIPIGC : IEnumerable<LHJIGLOHNHI>, IEnumerable, IEnumerator<LHJIGLOHNHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private LHJIGLOHNHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public MBHECGFGCML <>4__this;

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
		private IEnumerator<LHJIGLOHNHI> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		private LHJIGLOHNHI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x44A1C80", Offset = "0x44A0480", VA = "0x1844A1C80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(LHJIGLOHNHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x831DF00", Offset = "0x831C700", VA = "0x18831DF00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xE73320", Offset = "0xE71B20", VA = "0x180E73320")]
		[DebuggerHidden]
		public HHNNKGIPIGC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x831DF50", Offset = "0x831C750", VA = "0x18831DF50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x831D940", Offset = "0x831C140", VA = "0x18831D940", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x831D8A0", Offset = "0x831C0A0", VA = "0x18831D8A0")]
		private void JCGGFCDKBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x831D8F0", Offset = "0x831C0F0", VA = "0x18831D8F0")]
		private void LGFFOGMDBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x831DEB0", Offset = "0x831C6B0", VA = "0x18831DEB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x831DDF0", Offset = "0x831C5F0", VA = "0x18831DDF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LHJIGLOHNHI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x831DDF0", Offset = "0x831C5F0", VA = "0x18831DDF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private static readonly LHJIGLOHNHI DCBBJIOFEPL;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private static readonly Dictionary<Type, int> LOMFAIIGFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly HashSet<Type> HGEKGBMDOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private readonly FHGJMJALEAP<int> MKJNMODEIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private readonly FHGJMJALEAP<MNAJKJBGPPC> IFCOLPBCEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly FHGJMJALEAP<IDFEIAACAGF> HHGEAEPLCJB;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x83276F0", Offset = "0x8325EF0", VA = "0x1883276F0")]
	[PJMOOJOMMCC.OJAOBFKEEAO.IHGAJDILMAJ]
	internal static void FGFPGKKONLH(HHDGAAFLDEF LFLOONKADLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x8327DE0", Offset = "0x83265E0", VA = "0x188327DE0")]
	[RecRoom.NoEngine.Common.Preserve]
	public MBHECGFGCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x358FF90", Offset = "0x358E790", VA = "0x18358FF90", Slot = "4")]
	public FHEHNMANKEG<T> PMNNEECOLHL<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x8327A90", Offset = "0x8326290", VA = "0x188327A90", Slot = "5")]
	public JCLBGHPPIHM JHFMAKKGPNB(Exception IIIACJLJMAE)
	{
		return default(JCLBGHPPIHM);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x8327B20", Offset = "0x8326320", VA = "0x188327B20", Slot = "6")]
	public LHJIGLOHNHI PANCEIHPBHI(Exception? IIIACJLJMAE)
	{
		return default(LHJIGLOHNHI);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x8326B50", Offset = "0x8325350", VA = "0x188326B50", Slot = "7")]
	[IteratorStateMachine(typeof(HHNNKGIPIGC))]
	public IEnumerable<LHJIGLOHNHI> BNGNMFGCMJO(Exception IIIACJLJMAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x8326A00", Offset = "0x8325200", VA = "0x188326A00", Slot = "8")]
	public string AGNFLHFEKBK(Exception? IIIACJLJMAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x8326BF0", Offset = "0x83253F0", VA = "0x188326BF0")]
	private string DGNMOOBGFBF(AggregateException HEDEGCPEPGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x8327340", Offset = "0x8325B40", VA = "0x188327340")]
	private void ENLBJFBPGMH(Type JJEEOPDCKAO, int JBAPMMNBLOM, MNAJKJBGPPC? OBKHAKCNONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x8327840", Offset = "0x8326040", VA = "0x188327840")]
	private void IEIJJGEIIJN(Type JJEEOPDCKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x8326EF0", Offset = "0x83256F0", VA = "0x188326EF0")]
	private void DPPDPPOCANK(Type JJEEOPDCKAO, IDFEIAACAGF IMEFCDFAHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x83271C0", Offset = "0x83259C0", VA = "0x1883271C0")]
	private static int EEKFFECBBFC(Type JJEEOPDCKAO, Dictionary<Type, int> IDGEJIGJNNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x38A5CA0", Offset = "0x38A44A0", VA = "0x1838A5CA0")]
	private static bool JIAFDHKLIJO<TVal>(FHGJMJALEAP<TVal> MGEDIIGJIGC, Type JJEEOPDCKAO, [Out] TVal OPMIAMEJKDH) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x8327760", Offset = "0x8325F60", VA = "0x188327760")]
	[CompilerGenerated]
	internal static int FJJNANHILML(Type CCCLMGEJPLL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public struct JCLBGHPPIHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public readonly LHJIGLOHNHI LJCCNHFIBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public readonly string GCJLFENBFJD;

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x8321460", Offset = "0x831FC60", VA = "0x188321460")]
	public JCLBGHPPIHM(string GMBOJJPFJDH, LHJIGLOHNHI JBAPMMNBLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x83213C0", Offset = "0x831FBC0", VA = "0x1883213C0")]
	public string FCDLCDCOABM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class ECOIGKPCBDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	private readonly EOEGNJFKOMG GEHEEEKICHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	private string PLLEAHDKKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	private long? FMIFIMPHECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	private long? EDENAFGFPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	private long? CNBNILICCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private string IJDPJELDFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	private DJJCHOMGFCK DHHEFNAHEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private long? AEFJLELODGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private bool CDGKDAGJMEG;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public string CEJBDDOIJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public long MILNPMJJLAH
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x831A480", Offset = "0x8318C80", VA = "0x18831A480")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public long DIBIJKBMMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x831A0A0", Offset = "0x83188A0", VA = "0x18831A0A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public long ALCNAGDLIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x831AE30", Offset = "0x8319630", VA = "0x18831AE30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public string BMKFNADEHFB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x831AE90", Offset = "0x8319690", VA = "0x18831AE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public DJJCHOMGFCK EKMMAFJFFML
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xD43E80", Offset = "0xD42680", VA = "0x180D43E80")]
		get
		{
			return default(DJJCHOMGFCK);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x831AD40", Offset = "0x8319540", VA = "0x18831AD40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public long FPGJBPBNGEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x831A4E0", Offset = "0x8318CE0", VA = "0x18831A4E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x831AED0", Offset = "0x83196D0", VA = "0x18831AED0")]
	[UnityEngine.Scripting.Preserve]
	public ECOIGKPCBDF([LDAFGEHKDJK(null)] EOEGNJFKOMG GEHEEEKICHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x831AA50", Offset = "0x8319250", VA = "0x18831AA50")]
	private void IDIKOMBLIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x831A540", Offset = "0x8318D40", VA = "0x18831A540")]
	public void GPMAFMJECKF(long MDLDCACFGIB, long ODGNDMLNOIH, [Optional] long? PAHLPEDOKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x831ACA0", Offset = "0x83194A0", VA = "0x18831ACA0")]
	public void INCJIMKMLDM(long PAHLPEDOKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x831A9D0", Offset = "0x83191D0", VA = "0x18831A9D0")]
	public void IBNDBDFCMDJ(string IKMNCDLIGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x831A100", Offset = "0x8318900", VA = "0x18831A100")]
	public void CODFKMCGIEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal class JIJPPLMKGGB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct MBLFHCADFHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public AsyncTaskMethodBuilder<NBCEMMDCCGB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public NBCEMMDCCGB roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public JIJPPLMKGGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private TaskAwaiter<HBIANJDPELM.IHNHFPHBEEA<NBCEMMDCCGB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x8328180", Offset = "0x8326980", VA = "0x188328180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x83286C0", Offset = "0x8326EC0", VA = "0x1883286C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct NGHCDLDBPMO<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private sealed class JPPNKCGDBBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public NBCEMMDCCGB roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public JPPNKCGDBBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x8322890", Offset = "0x8321090", VA = "0x188322890")]
		internal NBCEMMDCCGB NFANHFNAGJM(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct IHGEJGPBKAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public AsyncTaskMethodBuilder<HBIANJDPELM.IHNHFPHBEEA<NBCEMMDCCGB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public NBCEMMDCCGB roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public JIJPPLMKGGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private LOJIFDBAMIB <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private TaskAwaiter<HBIANJDPELM.IHNHFPHBEEA<NBCEMMDCCGB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x8320410", Offset = "0x831EC10", VA = "0x188320410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x8320A20", Offset = "0x831F220", VA = "0x188320A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct OPPNBIACNKP<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public JIJPPLMKGGB <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x5490550", Offset = "0x548ED50", VA = "0x185490550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x43FB080", Offset = "0x43F9880", VA = "0x1843FB080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct BAAFMKOFBLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public JIJPPLMKGGB <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x83155D0", Offset = "0x8313DD0", VA = "0x1883155D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x83158B0", Offset = "0x83140B0", VA = "0x1883158B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private sealed class CFJIFFHEBCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public CFJIFFHEBCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x8318180", Offset = "0x8316980", VA = "0x188318180")]
		internal object DNCGJHEGOEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x83181E0", Offset = "0x83169E0", VA = "0x1883181E0")]
		internal bool IHLICFINNHD(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class BPJDHLHLBKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public BPJDHLHLBKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x83176C0", Offset = "0x8315EC0", VA = "0x1883176C0")]
		internal object KCCMEPPDDFH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class EFKJCHOBJLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public EFKJCHOBJLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x831AF10", Offset = "0x8319710", VA = "0x18831AF10")]
		internal object MAGEOPHBBOD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class MJPJJDDLCMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public MJPJJDDLCMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x8329BE0", Offset = "0x83283E0", VA = "0x188329BE0")]
		internal object GKIJKLHCEGB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class OJCLNJEDIIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public JIJPPLMKGGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public OJCLNJEDIIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x832BB10", Offset = "0x832A310", VA = "0x18832BB10")]
		internal object FKBPCAPNJHP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private static readonly Guid DPJAHKFBMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public readonly LMDCPPPCHDP CDKKILOLLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly HBIANJDPELM NGHHKFGLDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly KMOHBMIJHLP HIEPPCLFHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private readonly LICGECJPOEG IHALABDEOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private bool HDEKHJIHPKL;

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x8322660", Offset = "0x8320E60", VA = "0x188322660")]
	public JIJPPLMKGGB(LMDCPPPCHDP EIJBIEHCPFH, HBIANJDPELM NGHHKFGLDAF, KMOHBMIJHLP HIEPPCLFHOF, LICGECJPOEG IHALABDEOJN, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x8321B50", Offset = "0x8320350", VA = "0x188321B50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x8321BE0", Offset = "0x83203E0", VA = "0x188321BE0")]
	public void EIJDECBKKAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x8322230", Offset = "0x8320A30", VA = "0x188322230")]
	public void HFBJCEKKKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x8321480", Offset = "0x831FC80", VA = "0x188321480")]
	public void AOGKDHGKKCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x8321D00", Offset = "0x8320500", VA = "0x188321D00")]
	[AsyncStateMachine(typeof(MBLFHCADFHO))]
	internal Task<NBCEMMDCCGB> FABCAPLEHGI(BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, NBCEMMDCCGB ACANOPILGDO, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x38080E0", Offset = "0x38068E0", VA = "0x1838080E0")]
	private static byte[] BJNOEECMDJK<T>(T NJAAPDELBNN) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x38080F0", Offset = "0x38068F0", VA = "0x1838080F0")]
	private static T EFFAGLDCMGI<T>(MessageParser<T> KOPHBEHDCPP, byte[] NJAAPDELBNN, T DLFHPGCLELE) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x8321E60", Offset = "0x8320660", VA = "0x188321E60")]
	[AsyncStateMachine(typeof(IHGEJGPBKAH))]
	private Task<HBIANJDPELM.IHNHFPHBEEA<NBCEMMDCCGB>> FBCBCCPKKOD(NBCEMMDCCGB ACANOPILGDO, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x3808330", Offset = "0x3806B30", VA = "0x183808330")]
	[AsyncStateMachine(typeof(OPPNBIACNKP<>))]
	internal Task<T> LIANAMLPCKA<T>(CancellationToken HPBFCDCKFAO, Func<CancellationToken, Task<T>> LDPEMDHLBFB, int KLEOLCPIFEN = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x8322370", Offset = "0x8320B70", VA = "0x188322370")]
	[AsyncStateMachine(typeof(BAAFMKOFBLJ))]
	internal Task LIANAMLPCKA(CancellationToken HPBFCDCKFAO, Func<CancellationToken, Task> LDPEMDHLBFB, int KLEOLCPIFEN = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x8321B60", Offset = "0x8320360", VA = "0x188321B60")]
	public ELIPGBBJBEL EIGHAMMMFBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x83222F0", Offset = "0x8320AF0", VA = "0x1883222F0")]
	public HJINLEHMEJL KANMMMLDHNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x83218E0", Offset = "0x83200E0", VA = "0x1883218E0")]
	public JFJJBIEFCOE DNAAIFLALGL([Optional] LLPKKNNAIAE? NOMHFHBJHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x8321FA0", Offset = "0x83207A0", VA = "0x188321FA0")]
	public void FFEOLEAKANG(Func<Guid, bool> KGPKPCGGMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x83224A0", Offset = "0x8320CA0", VA = "0x1883224A0")]
	public void MHJMPPPMMNM(Func<Guid, bool> IJIMEMLJMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x8321650", Offset = "0x831FE50", VA = "0x188321650")]
	public Guid CIPLINGPNAO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x83217D0", Offset = "0x831FFD0", VA = "0x1883217D0")]
	public void CLBPIADGFLB(Guid DPEKEOGLAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x8322100", Offset = "0x8320900", VA = "0x188322100")]
	public void GJECAKOICEA(NBCEMMDCCGB GBIDGHDEGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x8321540", Offset = "0x831FD40", VA = "0x188321540")]
	public void BAOGIJBMDME(string JPMBPDALJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x3808240", Offset = "0x3806A40", VA = "0x183808240")]
	private T EKBOIMNEIAL<T>(T OPMIAMEJKDH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x83225B0", Offset = "0x8320DB0", VA = "0x1883225B0")]
	public void MLFIEJPEAHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x3807E40", Offset = "0x3806640", VA = "0x183807E40")]
	[CompilerGenerated]
	internal static string BCKDCMGHNKJ<T>(byte[] FLMLKMBDILC, int CFPHIOFNMLM, NGHCDLDBPMO<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal sealed class PMMHOOOOPIO : LMDCPPPCHDP
{
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class KCFKNKGJNAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public KCFKNKGJNAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x8323220", Offset = "0x8321A20", VA = "0x188323220")]
		internal object GJLCNIACNFJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct OMFBFILFOLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public PMMHOOOOPIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public JIJPPLMKGGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private IJNMEJLNFNJ <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private HJINLEHMEJL <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x832BD50", Offset = "0x832A550", VA = "0x18832BD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x832C6A0", Offset = "0x832AEA0", VA = "0x18832C6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct OABOCKFCKJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public PMMHOOOOPIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private TaskAwaiter<HCHPFAEFOMI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x832ACE0", Offset = "0x83294E0", VA = "0x18832ACE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x832B410", Offset = "0x8329C10", VA = "0x18832B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct MIJPOOKHBCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public PMMHOOOOPIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter<OMKFKAIDNEH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x8329860", Offset = "0x8328060", VA = "0x188329860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x8329B70", Offset = "0x8328370", VA = "0x188329B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private sealed class GDFHCCOJANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public IJNMEJLNFNJ presence;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public GDFHCCOJANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x831BC30", Offset = "0x831A430", VA = "0x18831BC30")]
		internal object LJIDNAJIOEL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private static readonly LLPKKNNAIAE ADMHDNBLAHC;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private static readonly LLPKKNNAIAE HGAHDBLOJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private readonly HHEFLMKOLLI OICCDEJOFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	private readonly ADDOLAOCDBG MLJBGHHJPBI;

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x8330030", Offset = "0x832E830", VA = "0x188330030")]
	public PMMHOOOOPIO(HHEFLMKOLLI OICCDEJOFAJ, ADDOLAOCDBG MLJBGHHJPBI, Guid KJHDGFKNPKN, IBNHMOEDCKG CDLOFOIHHCC, ABNJELCGKNH DOHMIAFKBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x832FA40", Offset = "0x832E240", VA = "0x18832FA40", Slot = "7")]
	[AsyncStateMachine(typeof(OMFBFILFOLF))]
	protected override Task APPJNBHOPFJ(JIJPPLMKGGB JLIEPGCFHDK, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x832FD50", Offset = "0x832E550", VA = "0x18832FD50")]
	[AsyncStateMachine(typeof(OABOCKFCKJP))]
	private Task CKBOBCGDLCM(CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x832FE50", Offset = "0x832E650", VA = "0x18832FE50")]
	[AsyncStateMachine(typeof(MIJPOOKHBCN))]
	private Task<int> HHNHJJIFHKG(CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x832FB80", Offset = "0x832E380", VA = "0x18832FB80")]
	private IJNMEJLNFNJ BAAFEKCGGKB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class EOCNKNEHJEA : LMDCPPPCHDP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct MPDALBFGLOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public EOCNKNEHJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public JIJPPLMKGGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private TaskAwaiter<EEIBBLLOKKE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x8329C50", Offset = "0x8328450", VA = "0x188329C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x832A600", Offset = "0x8328E00", VA = "0x18832A600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private readonly int OGJCODOBMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private readonly GANHOFFPCAM NPNJHLNLNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public readonly long MPBMECOMGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public readonly long OPBPKLLBAFH;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public EEIBBLLOKKE MOBHMEEOHHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x9E9400", Offset = "0x9E7C00", VA = "0x1809E9400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x9E92D0", Offset = "0x9E7AD0", VA = "0x1809E92D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x831B0A0", Offset = "0x83198A0", VA = "0x18831B0A0")]
	public EOCNKNEHJEA(Guid KJHDGFKNPKN, IBNHMOEDCKG CDLOFOIHHCC, ABNJELCGKNH DOHMIAFKBPP, int OGJCODOBMCM, GANHOFFPCAM NPNJHLNLNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x831AF80", Offset = "0x8319780", VA = "0x18831AF80", Slot = "7")]
	[AsyncStateMachine(typeof(MPDALBFGLOH))]
	protected override Task APPJNBHOPFJ(JIJPPLMKGGB JLIEPGCFHDK, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal abstract class PAIIPCKEHNA : LMDCPPPCHDP
{
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class DHHHMOKFIPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public PAIIPCKEHNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public LBOIKKJIIFC playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public DHHHMOKFIPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x8319820", Offset = "0x8318020", VA = "0x188319820")]
		internal Task DGPGAMGJBAN(BGHFCMFIENI<string>.KHCJHMNAJKC postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x8319860", Offset = "0x8318060", VA = "0x188319860")]
		internal object JICPMNEMPHE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct DFEGGHIJGPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public PAIIPCKEHNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public JIJPPLMKGGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private DHHHMOKFIPP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x8318E50", Offset = "0x8317650", VA = "0x188318E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x8319620", Offset = "0x8317E20", VA = "0x188319620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private struct LCPPGHNLLHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public LBOIKKJIIFC playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public PAIIPCKEHNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x8323AB0", Offset = "0x83222B0", VA = "0x188323AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x8324060", Offset = "0x8322860", VA = "0x188324060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x832E0F0", Offset = "0x832C8F0", VA = "0x18832E0F0")]
	public PAIIPCKEHNA(Guid KJHDGFKNPKN, IBNHMOEDCKG CDLOFOIHHCC, ABNJELCGKNH DOHMIAFKBPP, string ABJGLEGLAFD, BIAEOMGDAEE LBCFNOHNLPL, bool FOLPDCJBFBM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x832DE70", Offset = "0x832C670", VA = "0x18832DE70", Slot = "7")]
	[AsyncStateMachine(typeof(DFEGGHIJGPI))]
	protected override Task APPJNBHOPFJ(JIJPPLMKGGB JLIEPGCFHDK, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task FGGFEMMINEK(JIJPPLMKGGB JLIEPGCFHDK, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x832DFB0", Offset = "0x832C7B0", VA = "0x18832DFB0")]
	[AsyncStateMachine(typeof(LCPPGHNLLHE))]
	private Task FPKHOMILDBI(IDisposable KPIHLBKHPOG, LBOIKKJIIFC ECIBEFIBEAN, BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
internal class GNOIPLBAAGG : LMDCPPPCHDP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct DNAABACCONG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public GNOIPLBAAGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public JIJPPLMKGGB operationContext;

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
		private TaskAwaiter<MKHFNGCIHMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x8319AB0", Offset = "0x83182B0", VA = "0x188319AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x831A040", Offset = "0x8318840", VA = "0x18831A040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private readonly OCGCHDNKCFE FGGEEODNNKF;

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x831CF90", Offset = "0x831B790", VA = "0x18831CF90")]
	public GNOIPLBAAGG(Guid KJHDGFKNPKN, IBNHMOEDCKG CDLOFOIHHCC, ABNJELCGKNH DOHMIAFKBPP, OCGCHDNKCFE FGGEEODNNKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x831CEB0", Offset = "0x831B6B0", VA = "0x18831CEB0", Slot = "6")]
	protected override string KPBCAJHAPGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x831CD90", Offset = "0x831B590", VA = "0x18831CD90", Slot = "7")]
	[AsyncStateMachine(typeof(DNAABACCONG))]
	protected override Task APPJNBHOPFJ(JIJPPLMKGGB JLIEPGCFHDK, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal abstract class LMDCPPPCHDP : HPIIBGBFMNF
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	public delegate Task PLFIGCPNMDN(BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class CELCHPFJBLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public LMDCPPPCHDP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public CELCHPFJBLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x8318050", Offset = "0x8316850", VA = "0x188318050")]
		internal Task LECOAECKPPP(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private sealed class FCBIJKOONFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public CELCHPFJBLA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public FCBIJKOONFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x831B1D0", Offset = "0x83199D0", VA = "0x18831B1D0")]
		internal object MBODOKNOMJE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct LEHFHDNIMPM : IAsyncStateMachine
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
		public LMDCPPPCHDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public Func<LMDCPPPCHDP, BGHFCMFIENI<string>.KHCJHMNAJKC, JIJPPLMKGGB> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private CELCHPFJBLA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private JIJPPLMKGGB <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private TaskAwaiter<NBCEMMDCCGB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x83240C0", Offset = "0x83228C0", VA = "0x1883240C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x8325280", Offset = "0x8323A80", VA = "0x188325280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct GGILHJHLAEI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x831BD70", Offset = "0x831A570", VA = "0x18831BD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x831C810", Offset = "0x831B010", VA = "0x18831C810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct FJLKBJDDFEM : IAsyncStateMachine
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
		public LMDCPPPCHDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x831B290", Offset = "0x8319A90", VA = "0x18831B290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x831B5F0", Offset = "0x8319DF0", VA = "0x18831B5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public readonly Guid MADKPKKPOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public readonly ByteString HGGPGBPBEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public readonly ABNJELCGKNH DOEJEOGMAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	protected readonly string BDEHFANGJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private readonly IBNHMOEDCKG CDLOFOIHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	private readonly bool FOLPDCJBFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private readonly Queue<PLFIGCPNMDN> KEPILLGHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private readonly CMMOHKIHFLN FOCCGMALHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private readonly BIAEOMGDAEE LBCFNOHNLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private bool PGOOCPHCHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public DJJCHOMGFCK CJOHHGFAAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public DJJCHOMGFCK HEAMIEMEODB;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public IBNHMOEDCKG MOHKHIHLFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public DHHGNBFICMC PILJEFNINPM
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x83259A0", Offset = "0x83241A0", VA = "0x1883259A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public ICFBADGDCHF JGBKILABOBL
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x8325A70", Offset = "0x8324270", VA = "0x188325A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public CAAJIOJLKCC DNEAEPDOCGL
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x8325BA0", Offset = "0x83243A0", VA = "0x188325BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event OLNBDDIDIEL EHINKHJMACF
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x8325F90", Offset = "0x8324790", VA = "0x188325F90", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x8325C20", Offset = "0x8324420", VA = "0x188325C20", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x8326350", Offset = "0x8324B50", VA = "0x188326350")]
	protected LMDCPPPCHDP(Guid KJHDGFKNPKN, IBNHMOEDCKG CDLOFOIHHCC, ABNJELCGKNH DOHMIAFKBPP, string ABJGLEGLAFD, BIAEOMGDAEE LBCFNOHNLPL, bool FOLPDCJBFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x8325C40", Offset = "0x8324440", VA = "0x188325C40", Slot = "6")]
	protected virtual string KPBCAJHAPGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x8325B40", Offset = "0x8324340", VA = "0x188325B40")]
	public void IIBOENPHMFC(PLFIGCPNMDN FMJKHBAJLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x8325980", Offset = "0x8324180", VA = "0x188325980")]
	protected void DALPBNIILHP(float GOHMPMCJCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x83260E0", Offset = "0x83248E0", VA = "0x1883260E0")]
	[AsyncStateMachine(typeof(LEHFHDNIMPM))]
	public Task OEANMMBFPHG(CancellationToken DNHBNMHIDAC, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, [Optional] Func<LMDCPPPCHDP, BGHFCMFIENI<string>.KHCJHMNAJKC, JIJPPLMKGGB> PNNMEFCMIBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x8325FB0", Offset = "0x83247B0", VA = "0x188325FB0")]
	[AsyncStateMachine(typeof(GGILHJHLAEI))]
	private static Task NAPIELPMHEK(Func<CancellationToken, Task> LGCMGNMJANK, Func<CancellationToken, Task> KLFOFBGDCLJ, CancellationToken HPBFCDCKFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x8325800", Offset = "0x8324000", VA = "0x188325800")]
	private void BPDCBLBHHEC(bool EJCCGIABFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x8325C80", Offset = "0x8324480", VA = "0x188325C80")]
	private void LOCBAOEAHLK(JIJPPLMKGGB JLIEPGCFHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task APPJNBHOPFJ(JIJPPLMKGGB JLIEPGCFHDK, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x8326230", Offset = "0x8324A30", VA = "0x188326230")]
	[AsyncStateMachine(typeof(FJLKBJDDFEM))]
	private Task OLKIBGMAECF(BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x8325AC0", Offset = "0x83242C0", VA = "0x188325AC0")]
	public NBCEMMDCCGB GMOCALDIOCF(LOJIFDBAMIB HAEGJPIOKLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x8325EA0", Offset = "0x83246A0", VA = "0x188325EA0")]
	[CompilerGenerated]
	private Task MFJJFKLMFLI(CancellationToken NACLDKPPPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x83259F0", Offset = "0x83241F0", VA = "0x1883259F0")]
	[CompilerGenerated]
	private object FFHBIHHIMIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
internal sealed class DEKELLKJLCD : PAIIPCKEHNA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct KDGHNNCAEBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public DEKELLKJLCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public JIJPPLMKGGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private DEALDLCNIEC <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private HJINLEHMEJL <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x8323290", Offset = "0x8321A90", VA = "0x188323290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x83239F0", Offset = "0x83221F0", VA = "0x1883239F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private readonly HHEFLMKOLLI AKOPMFNOJCF;

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x8318DA0", Offset = "0x83175A0", VA = "0x188318DA0")]
	public DEKELLKJLCD(Guid KJHDGFKNPKN, IBNHMOEDCKG CDLOFOIHHCC, HHEFLMKOLLI AKOPMFNOJCF, ABNJELCGKNH DOHMIAFKBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x8318C50", Offset = "0x8317450", VA = "0x188318C50", Slot = "8")]
	[AsyncStateMachine(typeof(KDGHNNCAEBM))]
	protected override Task FGGFEMMINEK(JIJPPLMKGGB JLIEPGCFHDK, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal class DKLFMBKNIBG : LMDCPPPCHDP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct DBCPGJPKIFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public DKLFMBKNIBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public JIJPPLMKGGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private TaskAwaiter<MKHFNGCIHMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x83185F0", Offset = "0x8316DF0", VA = "0x1883185F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x83189A0", Offset = "0x83171A0", VA = "0x1883189A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private readonly string IOMCHGGDFAG;

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x8319A00", Offset = "0x8318200", VA = "0x188319A00")]
	public DKLFMBKNIBG(Guid KJHDGFKNPKN, IBNHMOEDCKG CDLOFOIHHCC, ABNJELCGKNH DOHMIAFKBPP, string IOMCHGGDFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x83198F0", Offset = "0x83180F0", VA = "0x1883198F0", Slot = "7")]
	[AsyncStateMachine(typeof(DBCPGJPKIFO))]
	protected override Task APPJNBHOPFJ(JIJPPLMKGGB JLIEPGCFHDK, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal class BOFIHPBMGBN : PAIIPCKEHNA
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class HLOAHINOKKG
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
			public AsyncTaskMethodBuilder<NBCEMMDCCGB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public HLOAHINOKKG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			private TaskAwaiter<MKHFNGCIHMI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			private TaskAwaiter<NBCEMMDCCGB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0x8331110", Offset = "0x832F910", VA = "0x188331110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0x8331600", Offset = "0x832FE00", VA = "0x188331600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public BOFIHPBMGBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public JFJJBIEFCOE serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public AJCFEJBAGHB roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public ELIPGBBJBEL uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public KFPKEIFCKFO roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HLOAHINOKKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x831FF20", Offset = "0x831E720", VA = "0x18831FF20")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<NBCEMMDCCGB> CCPECJCHPHE(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private struct PMLEPFFPDGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public BOFIHPBMGBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public JIJPPLMKGGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private HLOAHINOKKG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private DEALDLCNIEC <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private HJINLEHMEJL <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private NBCEMMDCCGB <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private TaskAwaiter<NBCEMMDCCGB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x832EB00", Offset = "0x832D300", VA = "0x18832EB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x832F9E0", Offset = "0x832E1E0", VA = "0x18832F9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private static readonly LLPKKNNAIAE ADMHDNBLAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private readonly int IIKNDOCDPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	[CanBeNull]
	private readonly OGEHCBNGKDA HBFLJINIIGI;

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x83174D0", Offset = "0x8315CD0", VA = "0x1883174D0")]
	public BOFIHPBMGBN(Guid KJHDGFKNPKN, IBNHMOEDCKG CDLOFOIHHCC, int IIKNDOCDPLN, OGEHCBNGKDA HBFLJINIIGI, ABNJELCGKNH DOHMIAFKBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x83172E0", Offset = "0x8315AE0", VA = "0x1883172E0", Slot = "8")]
	[AsyncStateMachine(typeof(PMLEPFFPDGJ))]
	protected override Task FGGFEMMINEK(JIJPPLMKGGB JLIEPGCFHDK, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x83171E0", Offset = "0x83159E0", VA = "0x1883171E0")]
	private void FAAJCKFCIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x8317010", Offset = "0x8315810", VA = "0x188317010")]
	private void CANDEMDBELI(BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, DEALDLCNIEC PDKLKKAPOEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal class LJBHFJCJNEG : LMDCPPPCHDP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct BNHPIJODJCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public LJBHFJCJNEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private DEALDLCNIEC <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private GOANNPAHNKI<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private TaskAwaiter<EEIBBLLOKKE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x8315E80", Offset = "0x8314680", VA = "0x188315E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x8316FB0", Offset = "0x83157B0", VA = "0x188316FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private readonly int IIKNDOCDPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private readonly OGEHCBNGKDA HBFLJINIIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private Func<MKHFNGCIHMI, MKHFNGCIHMI> HKGKICPAHGI;

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x8325500", Offset = "0x8323D00", VA = "0x188325500")]
	public LJBHFJCJNEG(Guid KJHDGFKNPKN, IBNHMOEDCKG CDLOFOIHHCC, int IIKNDOCDPLN, OGEHCBNGKDA HBFLJINIIGI, Func<MKHFNGCIHMI, MKHFNGCIHMI> HKGKICPAHGI, ABNJELCGKNH DOHMIAFKBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x83253C0", Offset = "0x8323BC0", VA = "0x1883253C0", Slot = "7")]
	[AsyncStateMachine(typeof(BNHPIJODJCJ))]
	protected override Task APPJNBHOPFJ(JIJPPLMKGGB JLIEPGCFHDK, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal abstract class DCBOMABPBFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public readonly LMDCPPPCHDP CDKKILOLLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public readonly JIJPPLMKGGB GOCMEDPPBCG;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DHHGNBFICMC PILJEFNINPM
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x8318B10", Offset = "0x8317310", VA = "0x188318B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public CAAJIOJLKCC DNEAEPDOCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x8318B60", Offset = "0x8317360", VA = "0x188318B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x8318BF0", Offset = "0x83173F0", VA = "0x188318BF0")]
	protected DCBOMABPBFJ(JIJPPLMKGGB JLIEPGCFHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x8318A00", Offset = "0x8317200", VA = "0x188318A00")]
	protected void BAOGIJBMDME(string JPMBPDALJEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct NBJGBNFKILK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public Dictionary<Guid, List<CIPAFGDGOOC>> FNMFOMOPGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public Dictionary<Guid, List<CIPAFGDGOOC>> DJHJHGCNOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public Dictionary<Guid, List<CIPAFGDGOOC>> NJJAEFIFBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public List<Guid> JCJFLNFBCDK;

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x832A6E0", Offset = "0x8328EE0", VA = "0x18832A6E0")]
	public static NBJGBNFKILK EFPADONOPCC(DHHGNBFICMC LMJFACKNPAI, DJJCHOMGFCK NMBDJBIBPNO, CCOEKIMEHPP LNLLHMLOLHD)
	{
		return default(NBJGBNFKILK);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct GAEFODIOFMH
{
	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40")]
	public static GAEFODIOFMH NKIHIDGHACP()
	{
		return default(GAEFODIOFMH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct GCLHKHMIKGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public readonly HCHPFAEFOMI DHIDHGNHAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public readonly EFHDFBNHLAI NOIGHDFNADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public readonly Guid? KHGICEEABBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public readonly IReadOnlyCollection<CABHDLHGNPC> HAAEAKDAFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public readonly IReadOnlyCollection<CABHDLHGNPC> MCENODOAHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public readonly COMDBKPAHPB GDDBLNGCPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public readonly COMDBKPAHPB DIJEEBBCAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public readonly BAFFAAEPLJL CBGHANGHJHI;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool CIPIPLAAAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x831BAF0", Offset = "0x831A2F0", VA = "0x18831BAF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x831BB80", Offset = "0x831A380", VA = "0x18831BB80")]
	public GCLHKHMIKGG(HCHPFAEFOMI DHIDHGNHAGI, EFHDFBNHLAI NOIGHDFNADI, Guid? KHGICEEABBP, IReadOnlyList<CABHDLHGNPC> HAAEAKDAFDC, IReadOnlyCollection<CABHDLHGNPC> MCENODOAHLL, COMDBKPAHPB GDDBLNGCPFI, COMDBKPAHPB DIJEEBBCAAD, BAFFAAEPLJL CBGHANGHJHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct GBOAMNCMIIB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private readonly JIJPPLMKGGB JLIEPGCFHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private readonly Guid DPEKEOGLAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private bool EJCCGIABFNE;

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x831B650", Offset = "0x8319E50", VA = "0x18831B650")]
	public static GBOAMNCMIIB CIPLINGPNAO(JIJPPLMKGGB JLIEPGCFHDK)
	{
		return default(GBOAMNCMIIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x117AD70", Offset = "0x1179570", VA = "0x18117AD70")]
	public void ALHCMFALOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x831B8B0", Offset = "0x831A0B0", VA = "0x18831B8B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x831B960", Offset = "0x831A160", VA = "0x18831B960")]
	private GBOAMNCMIIB(JIJPPLMKGGB JLIEPGCFHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x831B680", Offset = "0x8319E80", VA = "0x18831B680")]
	private void CLBPIADGFLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x831B8C0", Offset = "0x831A0C0", VA = "0x18831B8C0")]
	private Func<Guid, bool> HJBGGLIPJGN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal class HJINLEHMEJL : DCBOMABPBFJ, HPIIBGBFMNF
{
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	public delegate Task<DJJCHOMGFCK> JIFPPOFBIOJ(CCOEKIMEHPP NFNBKNAJBPN, PNICJDGICNA PLAGKJFCFKN, CMMOHKIHFLN AGHAGDNHBHF, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct CCMGHGNNOHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public HHEFLMKOLLI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private GBOAMNCMIIB <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private TaskAwaiter<NBCEMMDCCGB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x8317720", Offset = "0x8315F20", VA = "0x188317720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x8317FF0", Offset = "0x83167F0", VA = "0x188317FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct JBMMLDGJMHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public AsyncTaskMethodBuilder<NBCEMMDCCGB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public HHEFLMKOLLI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private TaskAwaiter<NBCEMMDCCGB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x8320F20", Offset = "0x831F720", VA = "0x188320F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x8321350", Offset = "0x831FB50", VA = "0x188321350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct OIKODOGACPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public HHEFLMKOLLI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x832B470", Offset = "0x8329C70", VA = "0x18832B470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x832BAB0", Offset = "0x832A2B0", VA = "0x18832BAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class BGCODPNFHGK
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
			public AsyncTaskMethodBuilder<GCLHKHMIKGG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			public BGCODPNFHGK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			private GCLHKHMIKGG <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			private TaskAwaiter<DJJCHOMGFCK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			private TaskAwaiter<GCLHKHMIKGG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x83301C0", Offset = "0x832E9C0", VA = "0x1883301C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x83309B0", Offset = "0x832F1B0", VA = "0x1883309B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<CCOEKIMEHPP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			public BGCODPNFHGK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004FF")]
			private CCOEKIMEHPP <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			private TaskAwaiter<DJJCHOMGFCK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			private TaskAwaiter<CCOEKIMEHPP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x8330A20", Offset = "0x832F220", VA = "0x188330A20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x83310A0", Offset = "0x832F8A0", VA = "0x1883310A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public HHEFLMKOLLI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public CMMOHKIHFLN preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public CMMOHKIHFLN downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public GCLHKHMIKGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public CMMOHKIHFLN postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public CCOEKIMEHPP phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public PIMHGEACHCB.BCKCHKHFKGB <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public BGCODPNFHGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x8315910", Offset = "0x8314110", VA = "0x188315910")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<GCLHKHMIKGG> CJHDGLJBDFD(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x8315A60", Offset = "0x8314260", VA = "0x188315A60")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<CCOEKIMEHPP> FMGAMOMECDH(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x8315CE0", Offset = "0x83144E0", VA = "0x188315CE0")]
		internal void HLOCCLCOGOD(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x8315D20", Offset = "0x8314520", VA = "0x188315D20")]
		internal Task PDIBNOCMBHL(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x8315B80", Offset = "0x8314380", VA = "0x188315B80")]
		internal Task GNEGDBBDJBA(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct MHACNKPMAJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public HHEFLMKOLLI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private BGCODPNFHGK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private TaskAwaiter<GCLHKHMIKGG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private TaskAwaiter<CCOEKIMEHPP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x8328730", Offset = "0x8326F30", VA = "0x188328730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x8329480", Offset = "0x8327C80", VA = "0x188329480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct OPIEGENOKMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public CCOEKIMEHPP phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public CMMOHKIHFLN postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private TaskAwaiter<DJJCHOMGFCK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private PNICJDGICNA <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x832C700", Offset = "0x832AF00", VA = "0x18832C700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x832D810", Offset = "0x832C010", VA = "0x18832D810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct DNJICFGNFPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x8337410", Offset = "0x8335C10", VA = "0x188337410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x8337BF0", Offset = "0x83363F0", VA = "0x188337BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct MJFHACHGMJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public CMMOHKIHFLN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private TaskAwaiter<DJJCHOMGFCK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x8344B80", Offset = "0x8343380", VA = "0x188344B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x83453C0", Offset = "0x8343BC0", VA = "0x1883453C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct KACIJADJHMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public AsyncTaskMethodBuilder<DJJCHOMGFCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public CMMOHKIHFLN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private TaskAwaiter<DJJCHOMGFCK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8341390", Offset = "0x833FB90", VA = "0x188341390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x8342350", Offset = "0x8340B50", VA = "0x188342350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct HNPOMOFCGHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public AsyncTaskMethodBuilder<DJJCHOMGFCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public CMMOHKIHFLN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public PNICJDGICNA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private TaskAwaiter<DJJCHOMGFCK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x833C4E0", Offset = "0x833ACE0", VA = "0x18833C4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x833D5F0", Offset = "0x833BDF0", VA = "0x18833D5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct MBKLEFFNMDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public AsyncTaskMethodBuilder<DJJCHOMGFCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public DJJCHOMGFCK operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public CMMOHKIHFLN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public CCOEKIMEHPP deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private TaskAwaiter<DJJCHOMGFCK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x8344530", Offset = "0x8342D30", VA = "0x188344530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x8344780", Offset = "0x8342F80", VA = "0x188344780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class OMHJJPDBHFO
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
			public AsyncTaskMethodBuilder<DJJCHOMGFCK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public OMHJJPDBHFO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			private LGBPIAHJJBO <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			private TaskAwaiter<DJJCHOMGFCK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x8349C70", Offset = "0x8348470", VA = "0x188349C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x834A290", Offset = "0x8348A90", VA = "0x18834A290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public CMMOHKIHFLN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public JIFPPOFBIOJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public PNICJDGICNA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public DJJCHOMGFCK originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public OMHJJPDBHFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x8348230", Offset = "0x8346A30", VA = "0x188348230")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<DJJCHOMGFCK> IMGIFHFIBJK(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct AANMKLFDBMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder<DJJCHOMGFCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public CMMOHKIHFLN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public JIFPPOFBIOJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public PNICJDGICNA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private TaskAwaiter<DJJCHOMGFCK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x8331CE0", Offset = "0x83304E0", VA = "0x188331CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x8332200", Offset = "0x8330A00", VA = "0x188332200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct HAKMHGIKHBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public CMMOHKIHFLN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private DJJCHOMGFCK <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private IEnumerator<DJJCHOMGFCK> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private TaskAwaiter<DJJCHOMGFCK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x833AE10", Offset = "0x8339610", VA = "0x18833AE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x833B360", Offset = "0x8339B60", VA = "0x18833B360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct ECIJBNMJCFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x8337C50", Offset = "0x8336450", VA = "0x188337C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x8337F40", Offset = "0x8336740", VA = "0x188337F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct ALBHBHGKAGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x83325F0", Offset = "0x8330DF0", VA = "0x1883325F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x8332810", Offset = "0x8331010", VA = "0x188332810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class KDONNCAILJM
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
			public AsyncTaskMethodBuilder<DJJCHOMGFCK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			public KDONNCAILJM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public CCOEKIMEHPP data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public CMMOHKIHFLN progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			private TaskAwaiter<DJJCHOMGFCK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			private TaskAwaiter<JPPDCKCEBKK> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x834A300", Offset = "0x8348B00", VA = "0x18834A300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x834ADC0", Offset = "0x83495C0", VA = "0x18834ADC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public HIEHDDMHKLI mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public KDONNCAILJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x8343430", Offset = "0x8341C30", VA = "0x188343430")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<DJJCHOMGFCK> KFDJMAPIAKB(CCOEKIMEHPP data, PNICJDGICNA _, CMMOHKIHFLN progressTracker, BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct KCKLADBGLHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public CCOEKIMEHPP phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public CMMOHKIHFLN postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private KDONNCAILJM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private PNICJDGICNA <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter<DJJCHOMGFCK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x8342500", Offset = "0x8340D00", VA = "0x188342500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x83433D0", Offset = "0x8341BD0", VA = "0x1883433D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct GIOMAOIJBMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x833A4D0", Offset = "0x8338CD0", VA = "0x18833A4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x833A8D0", Offset = "0x83390D0", VA = "0x18833A8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct NFELHPDLEGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public AsyncTaskMethodBuilder<DJJCHOMGFCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public HJINLEHMEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public CMMOHKIHFLN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private TaskAwaiter<DJJCHOMGFCK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x83461A0", Offset = "0x83449A0", VA = "0x1883461A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x83467C0", Offset = "0x8344FC0", VA = "0x1883467C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private readonly GKLIALCKGHC FFNGJIAIDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private readonly GKLIALCKGHC JGLFCLOMJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private readonly ECOIGKPCBDF IGBOEAEPDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private readonly PNOJEPKMLEK FPKEDPKOBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private readonly MHKGOJKIDIL CKONAPOPNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private ProfilerCounterValue<int> AMCCNOLICLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private readonly ANMPLDNLLMO CNBOFIDHNKD;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private IBNHMOEDCKG MOHKHIHLFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x831F3C0", Offset = "0x831DBC0", VA = "0x18831F3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event OLNBDDIDIEL EHINKHJMACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x831FA70", Offset = "0x831E270", VA = "0x18831FA70", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x831F610", Offset = "0x831DE10", VA = "0x18831F610", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x831FC60", Offset = "0x831E460", VA = "0x18831FC60")]
	public HJINLEHMEJL(JIJPPLMKGGB JLIEPGCFHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x831E500", Offset = "0x831CD00", VA = "0x18831E500")]
	[AsyncStateMachine(typeof(CCMGHGNNOHJ))]
	public Task BLBKEHKCHIK(HHEFLMKOLLI JHLBOHEIAIJ, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x831F400", Offset = "0x831DC00", VA = "0x18831F400")]
	[AsyncStateMachine(typeof(JBMMLDGJMHF))]
	private Task<NBCEMMDCCGB> HLABCDGMGBN(HHEFLMKOLLI JHLBOHEIAIJ, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x831E8B0", Offset = "0x831D0B0", VA = "0x18831E8B0")]
	[AsyncStateMachine(typeof(OIKODOGACPC))]
	private Task CNDMJCOGKAN(HHEFLMKOLLI JHLBOHEIAIJ, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x831EA30", Offset = "0x831D230", VA = "0x18831EA30")]
	[AsyncStateMachine(typeof(MHACNKPMAJB))]
	private Task DHNMJKAHIFC(HHEFLMKOLLI JHLBOHEIAIJ, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken FFHCIBPIOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x831F270", Offset = "0x831DA70", VA = "0x18831F270")]
	[AsyncStateMachine(typeof(OPIEGENOKMI))]
	private Task GMOLLPPBHIM(CCOEKIMEHPP HDPNDAKKFDM, CMMOHKIHFLN OGMJHBFOINC, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken MHPDGMBJIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x831F790", Offset = "0x831DF90", VA = "0x18831F790")]
	[AsyncStateMachine(typeof(DNJICFGNFPE))]
	private Task KBELCFJGAHA(BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x831E3B0", Offset = "0x831CBB0", VA = "0x18831E3B0")]
	[AsyncStateMachine(typeof(MJFHACHGMJL))]
	private Task BHKEHAMOEHK(CCOEKIMEHPP NFNBKNAJBPN, CMMOHKIHFLN AGHAGDNHBHF, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x831F630", Offset = "0x831DE30", VA = "0x18831F630")]
	[AsyncStateMachine(typeof(KACIJADJHMC))]
	private Task<DJJCHOMGFCK> KAFCDAOJKKF(CCOEKIMEHPP NFNBKNAJBPN, PNICJDGICNA LCFFPACFBID, CMMOHKIHFLN AGHAGDNHBHF, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x831EE30", Offset = "0x831D630", VA = "0x18831EE30")]
	[AsyncStateMachine(typeof(HNPOMOFCGHC))]
	private Task<DJJCHOMGFCK> FFOILLPACPE(CCOEKIMEHPP NFNBKNAJBPN, PNICJDGICNA LCFFPACFBID, CMMOHKIHFLN AGHAGDNHBHF, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x831EB70", Offset = "0x831D370", VA = "0x18831EB70")]
	[AsyncStateMachine(typeof(MBKLEFFNMDM))]
	private Task<DJJCHOMGFCK> EBHMEHNMEJF(DJJCHOMGFCK NMBDJBIBPNO, CCOEKIMEHPP LNLLHMLOLHD, CMMOHKIHFLN AGHAGDNHBHF, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC, bool EFDEOMBCCHC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x831F960", Offset = "0x831E160", VA = "0x18831F960")]
	private bool LMIBKBOKAMP(CCOEKIMEHPP HDPNDAKKFDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x831FAD0", Offset = "0x831E2D0", VA = "0x18831FAD0")]
	[AsyncStateMachine(typeof(AANMKLFDBMP))]
	protected Task<DJJCHOMGFCK> PKEMOABBNHA(CCOEKIMEHPP NFNBKNAJBPN, PNICJDGICNA LCFFPACFBID, CMMOHKIHFLN AGHAGDNHBHF, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC, JIFPPOFBIOJ LFHFBHMEKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x831EFD0", Offset = "0x831D7D0", VA = "0x18831EFD0")]
	[AsyncStateMachine(typeof(HAKMHGIKHBJ))]
	private Task GEDGJJHPKHE(CCOEKIMEHPP NFNBKNAJBPN, CMMOHKIHFLN AGHAGDNHBHF, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x831F910", Offset = "0x831E110", VA = "0x18831F910")]
	private void LCKGBNJNMEE(DJJCHOMGFCK NOHOBNAMPCA, CMMOHKIHFLN AGHAGDNHBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x831E0A0", Offset = "0x831C8A0", VA = "0x18831E0A0")]
	private void ADPGNKEFDDH(DJJCHOMGFCK ENEAOOGGICL, [Out] DJJCHOMGFCK MPLCPAANLPP, [Out] DJJCHOMGFCK KLBJFEHNFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x831FA90", Offset = "0x831E290", VA = "0x18831FA90")]
	private Task<GCLHKHMIKGG> NKFKNJBNFCK(HHEFLMKOLLI JHLBOHEIAIJ, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x831F8D0", Offset = "0x831E0D0", VA = "0x18831F8D0")]
	private Task<CCOEKIMEHPP> KPOPAILHGAF(GCLHKHMIKGG NFNBKNAJBPN, PIMHGEACHCB.BCKCHKHFKGB LAODBPDHCNE, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x831F120", Offset = "0x831D920", VA = "0x18831F120")]
	[AsyncStateMachine(typeof(ECIJBNMJCFD))]
	private Task GGNGKGEIOEE(CCOEKIMEHPP NFNBKNAJBPN, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC, bool FHJEHBPIKDA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x831E650", Offset = "0x831CE50", VA = "0x18831E650")]
	[AsyncStateMachine(typeof(ALBHBHGKAGI))]
	private Task BNJKFLIFIFE(CCOEKIMEHPP NFNBKNAJBPN, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x831F8A0", Offset = "0x831E0A0", VA = "0x18831F8A0")]
	private Task KLKHNOPEGPO(CCOEKIMEHPP NFNBKNAJBPN, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x831E740", Offset = "0x831CF40", VA = "0x18831E740")]
	private Task BPJGBIDFCJH(CCOEKIMEHPP NFNBKNAJBPN, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x831EFB0", Offset = "0x831D7B0", VA = "0x18831EFB0")]
	private Task FNOBHIBAGHM(CCOEKIMEHPP NFNBKNAJBPN, PNICJDGICNA LCFFPACFBID, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x831FA50", Offset = "0x831E250", VA = "0x18831FA50")]
	private Task MFCIGBFADFE(CCOEKIMEHPP NFNBKNAJBPN, PNICJDGICNA LCFFPACFBID, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x831F3F0", Offset = "0x831DBF0", VA = "0x18831F3F0")]
	private static Task HJKALJBCAEI(CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x831EA10", Offset = "0x831D210", VA = "0x18831EA10")]
	private Task DEMAMMHKFCJ(CCOEKIMEHPP NFNBKNAJBPN, PNICJDGICNA LCFFPACFBID, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x831E9F0", Offset = "0x831D1F0", VA = "0x18831E9F0")]
	private Task DDAEFMJHMBL(CCOEKIMEHPP NFNBKNAJBPN, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x831E0E0", Offset = "0x831C8E0", VA = "0x18831E0E0")]
	private void AFEBIGDPCJI(HHEFLMKOLLI JHLBOHEIAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x831F560", Offset = "0x831DD60", VA = "0x18831F560")]
	public void JEMNEKBEENA(long PAHLPEDOKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	private static void LILDHADPOHD(HCHPFAEFOMI DHIDHGNHAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x831E760", Offset = "0x831CF60", VA = "0x18831E760")]
	[AsyncStateMachine(typeof(KCKLADBGLHG))]
	private Task CEGDNEPDECJ(CCOEKIMEHPP HDPNDAKKFDM, CMMOHKIHFLN OGMJHBFOINC, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken MHPDGMBJIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x831ECF0", Offset = "0x831D4F0", VA = "0x18831ECF0")]
	[AsyncStateMachine(typeof(GIOMAOIJBMK))]
	private Task ENKPLJAIHGH(CCOEKIMEHPP NFNBKNAJBPN, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x831E130", Offset = "0x831C930", VA = "0x18831E130")]
	private static DKLAEGBPMFH ALAIPLDNIML(CCOEKIMEHPP LNLLHMLOLHD)
	{
		return default(DKLAEGBPMFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x831E250", Offset = "0x831CA50", VA = "0x18831E250")]
	[AsyncStateMachine(typeof(NFELHPDLEGN))]
	private Task<DJJCHOMGFCK> BFNKFLEAJLB(CCOEKIMEHPP NFNBKNAJBPN, PNICJDGICNA LCFFPACFBID, CMMOHKIHFLN AGHAGDNHBHF, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	private void NBJIFMDIIKF(DJJCHOMGFCK MHGLNJBFNMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct BONCLGMJLLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	private IBNHMOEDCKG CDLOFOIHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	private CCOEKIMEHPP NFNBKNAJBPN;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private DHHGNBFICMC PILJEFNINPM
	{
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x83351D0", Offset = "0x83339D0", VA = "0x1883351D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x8335430", Offset = "0x8333C30", VA = "0x188335430")]
	public static Task OEANMMBFPHG(IBNHMOEDCKG CDLOFOIHHCC, CCOEKIMEHPP NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x8335220", Offset = "0x8333A20", VA = "0x188335220")]
	private void OEANMMBFPHG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct MAKACMNBKJJ
{
	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x8344450", Offset = "0x8342C50", VA = "0x188344450")]
	public static Task OEANMMBFPHG(CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct KAFNJLBHCMK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct DFNNJPJKNON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public JIJPPLMKGGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x8336E80", Offset = "0x8335680", VA = "0x188336E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x83373B0", Offset = "0x8335BB0", VA = "0x1883373B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x83423C0", Offset = "0x8340BC0", VA = "0x1883423C0")]
	[AsyncStateMachine(typeof(DFNNJPJKNON))]
	public static Task OEANMMBFPHG(JIJPPLMKGGB JLIEPGCFHDK, CCOEKIMEHPP NFNBKNAJBPN, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct EPCBEEPCIHI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct HOELNINPNDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public JIJPPLMKGGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public PNICJDGICNA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private IBNHMOEDCKG <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private DHHGNBFICMC <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private DJJCHOMGFCK <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private LGBPIAHJJBO <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private List<(PersistenceView, PEBBACKHDPF)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private PEBBACKHDPF <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x833D660", Offset = "0x833BE60", VA = "0x18833D660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x833E330", Offset = "0x833CB30", VA = "0x18833E330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x83381E0", Offset = "0x83369E0", VA = "0x1883381E0")]
	[AsyncStateMachine(typeof(HOELNINPNDI))]
	public static Task OEANMMBFPHG(JIJPPLMKGGB JLIEPGCFHDK, CCOEKIMEHPP NFNBKNAJBPN, PNICJDGICNA LCFFPACFBID, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x8337FF0", Offset = "0x83367F0", VA = "0x188337FF0")]
	private static void LFPIGPAMKIE(PersistenceView JNLFCOMKBMA, PEBBACKHDPF GIKOLFBJMJH, CCOEKIMEHPP NFNBKNAJBPN, DJJCHOMGFCK NMBDJBIBPNO, bool BIOKHOJMLPA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct NEHJPKHHBGB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct IOPBADNFMLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public IBNHMOEDCKG roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private LGBPIAHJJBO <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x833FDA0", Offset = "0x833E5A0", VA = "0x18833FDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x83403C0", Offset = "0x833EBC0", VA = "0x1883403C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x8346080", Offset = "0x8344880", VA = "0x188346080")]
	[AsyncStateMachine(typeof(IOPBADNFMLI))]
	public static Task OEANMMBFPHG(IBNHMOEDCKG CDLOFOIHHCC, CCOEKIMEHPP NFNBKNAJBPN, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal struct OLDIMFMAFCE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct AEFAIIJFPLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public IBNHMOEDCKG roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public JIJPPLMKGGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x83322F0", Offset = "0x8330AF0", VA = "0x1883322F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x8332500", Offset = "0x8330D00", VA = "0x188332500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class HELBGMCHCBP
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
			public BGHFCMFIENI<string>.KHCJHMNAJKC timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			public HELBGMCHCBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x834AE30", Offset = "0x8349630", VA = "0x18834AE30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x834B1C0", Offset = "0x83499C0", VA = "0x18834B1C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HELBGMCHCBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x833BAD0", Offset = "0x833A2D0", VA = "0x18833BAD0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task AJBHMPLJONI(BGHFCMFIENI<string>.KHCJHMNAJKC timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct MJNEIOMLAGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public OLDIMFMAFCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private LGBPIAHJJBO <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private TaskAwaiter<NBCEMMDCCGB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x8345420", Offset = "0x8343C20", VA = "0x188345420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x8346020", Offset = "0x8344820", VA = "0x188346020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class HJFEKGAINKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public FHIIJIJJHKM version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HJFEKGAINKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x833C350", Offset = "0x833AB50", VA = "0x18833C350")]
		internal object BFEPPAMOANB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x833C430", Offset = "0x833AC30", VA = "0x18833C430")]
		internal object FNEENMCGAGO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private IBNHMOEDCKG CDLOFOIHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private CCOEKIMEHPP NFNBKNAJBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private JIJPPLMKGGB JLIEPGCFHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private bool FHJEHBPIKDA;

	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private static readonly ByteString MJKAHNHIGIE;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private DHHGNBFICMC PILJEFNINPM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x8347620", Offset = "0x8345E20", VA = "0x188347620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private CAAJIOJLKCC DNEAEPDOCGL
	{
		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x8347670", Offset = "0x8345E70", VA = "0x188347670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x8348050", Offset = "0x8346850", VA = "0x188348050")]
	[AsyncStateMachine(typeof(AEFAIIJFPLL))]
	public static Task OEANMMBFPHG(IBNHMOEDCKG CDLOFOIHHCC, CCOEKIMEHPP NFNBKNAJBPN, JIJPPLMKGGB JLIEPGCFHDK, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC, bool FHJEHBPIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x8347F20", Offset = "0x8346720", VA = "0x188347F20")]
	[AsyncStateMachine(typeof(MJNEIOMLAGE))]
	private Task OEANMMBFPHG(BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x8347750", Offset = "0x8345F50", VA = "0x188347750")]
	private void MEHKCFFMAKE([NotNull] IOKANKGCBIH HAEGAMBDMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x8347710", Offset = "0x8345F10", VA = "0x188347710")]
	private bool JHJAMHMABCH(FHIIJIJJHKM JLNEBEJFOHB, IOKANKGCBIH HAEGAMBDMNL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct LJMHOPBPMDO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct CNLLJICBGHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public AsyncTaskMethodBuilder<CCOEKIMEHPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public LJMHOPBPMDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public PIMHGEACHCB.BCKCHKHFKGB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private TaskAwaiter<IReadOnlyCollection<CABHDLHGNPC>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private TaskAwaiter<(HCGBMJDNFKJ<IMJGIKLDEEF, PLLAIPNOLPG>, HCGBMJDNFKJ<CCNPADACDGN<IOKANKGCBIH>, PLLAIPNOLPG>, HCGBMJDNFKJ<CCNPADACDGN<NLICKNHNJCI>, PLLAIPNOLPG>, HCGBMJDNFKJ<CCNPADACDGN<IEnumerable<FNPLOHJEMAN>>, PLLAIPNOLPG>, HCGBMJDNFKJ<CCNPADACDGN<OKGNGFGOKMI>, PLLAIPNOLPG>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x8335590", Offset = "0x8333D90", VA = "0x188335590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x8336370", Offset = "0x8334B70", VA = "0x188336370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct BCDHHKIMONL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<IMJGIKLDEEF, PLLAIPNOLPG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public LJMHOPBPMDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public IReadOnlyCollection<CABHDLHGNPC> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public IReadOnlyCollection<CABHDLHGNPC> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public PIMHGEACHCB.BCKCHKHFKGB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter<HCGBMJDNFKJ<IMJGIKLDEEF, PLLAIPNOLPG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x8332F60", Offset = "0x8331760", VA = "0x188332F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x83335C0", Offset = "0x8331DC0", VA = "0x1883335C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	private CBEIFODGGIG<COMDBKPAHPB, NLICKNHNJCI> KIJEICKNENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	private CBEIFODGGIG<COMDBKPAHPB, IOKANKGCBIH> BLCGFGDIAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	private CBEIFODGGIG<BAFFAAEPLJL, IEnumerable<FNPLOHJEMAN>> IFKLEONMHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	private CBEIFODGGIG<long, OKGNGFGOKMI> CKEJJBGLKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private MKMFJMPKGKL MEBBPAEBJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private HCHPFAEFOMI DHIDHGNHAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private EFHDFBNHLAI NOIGHDFNADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	private Guid? KHGICEEABBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	private IReadOnlyCollection<CABHDLHGNPC> HAAEAKDAFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private Task<IReadOnlyCollection<CABHDLHGNPC>> DONDNDFENDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	private COMDBKPAHPB GDDBLNGCPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private COMDBKPAHPB DIJEEBBCAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private COMDBKPAHPB? MPCKMOJDIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private BAFFAAEPLJL CBGHANGHJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF;

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x8343590", Offset = "0x8341D90", VA = "0x188343590")]
	public static Task<CCOEKIMEHPP> EGACOFDOINE(IBNHMOEDCKG CDLOFOIHHCC, [In] GCLHKHMIKGG NFNBKNAJBPN, PIMHGEACHCB.BCKCHKHFKGB LAODBPDHCNE, BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x8343CC0", Offset = "0x83424C0", VA = "0x188343CC0")]
	[AsyncStateMachine(typeof(CNLLJICBGHI))]
	private Task<CCOEKIMEHPP> OEANMMBFPHG(PIMHGEACHCB.BCKCHKHFKGB LAODBPDHCNE, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x8343A90", Offset = "0x8342290", VA = "0x188343A90")]
	[AsyncStateMachine(typeof(BCDHHKIMONL))]
	private Task<HCGBMJDNFKJ<IMJGIKLDEEF, PLLAIPNOLPG>> LKNIBCFGAOC(Guid? KHGICEEABBP, IReadOnlyCollection<CABHDLHGNPC> HAAEAKDAFDC, IReadOnlyCollection<CABHDLHGNPC> MCENODOAHLL, long? MDLDCACFGIB, long? DBEJCKJKFPB, PIMHGEACHCB.BCKCHKHFKGB LAODBPDHCNE, BGHFCMFIENI<string>.KHCJHMNAJKC IMBDKKAOMGO, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct IFCHMEKEJEK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct JGMOIKJJMKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public AsyncTaskMethodBuilder<GCLHKHMIKGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public IFCHMEKEJEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private TaskAwaiter<GCLHKHMIKGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x8340420", Offset = "0x833EC20", VA = "0x188340420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x8340870", Offset = "0x833F070", VA = "0x188340870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct HFLOEKKEKAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public AsyncTaskMethodBuilder<GCLHKHMIKGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public IFCHMEKEJEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private TaskAwaiter<GCLHKHMIKGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x833BE60", Offset = "0x833A660", VA = "0x18833BE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x833C2E0", Offset = "0x833AAE0", VA = "0x18833C2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class OFNLNBODEDP
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
			public OFNLNBODEDP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			private TaskAwaiter<OLKDICNFHHB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			private TaskAwaiter<OMKFKAIDNEH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x8349260", Offset = "0x8347A60", VA = "0x188349260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x8349C10", Offset = "0x8348410", VA = "0x188349C10", Slot = "5")]
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
		public GJLIIHMFEJN roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public DHHGNBFICMC callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public COMDBKPAHPB superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public COMDBKPAHPB subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public IReadOnlyList<CABHDLHGNPC> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public IReadOnlyList<CABHDLHGNPC> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public HCHPFAEFOMI roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public OFNLNBODEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xE2AA10", Offset = "0xE29210", VA = "0x180E2AA10")]
		internal bool PBNHIAELBOD(EFHDFBNHLAI sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x8347550", Offset = "0x8345D50", VA = "0x188347550")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task OGGKBAIIIDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x8347350", Offset = "0x8345B50", VA = "0x188347350")]
		internal Task<BAFFAAEPLJL> BCNJMLNCAND()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct GCNEDCNKKJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public AsyncTaskMethodBuilder<GCLHKHMIKGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public GJLIIHMFEJN roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public DHHGNBFICMC callbacks;

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
		public COMDBKPAHPB superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private OFNLNBODEDP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private EFHDFBNHLAI <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private Task<BAFFAAEPLJL> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private TaskAwaiter<HCHPFAEFOMI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private TaskAwaiter<BAFFAAEPLJL> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x83394B0", Offset = "0x8337CB0", VA = "0x1883394B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x833A460", Offset = "0x8338C60", VA = "0x18833A460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	private DHHGNBFICMC LMJFACKNPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private ECOIGKPCBDF IGBOEAEPDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	private GJLIIHMFEJN DNDIHNEMGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	private BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private long MDLDCACFGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private long ODGNDMLNOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private long AEGGFNGPLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	private string KJCMLLPPGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	private COMDBKPAHPB DCDOFGOEPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private Guid JNEIGEKLLFO;

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x833E4D0", Offset = "0x833CCD0", VA = "0x18833E4D0")]
	public static Task<GCLHKHMIKGG> EGACOFDOINE(IBNHMOEDCKG CDLOFOIHHCC, HHEFLMKOLLI JHLBOHEIAIJ, BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x833EA90", Offset = "0x833D290", VA = "0x18833EA90")]
	[AsyncStateMachine(typeof(JGMOIKJJMKF))]
	private Task<GCLHKHMIKGG> OEANMMBFPHG(CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x833E920", Offset = "0x833D120", VA = "0x18833E920")]
	[AsyncStateMachine(typeof(HFLOEKKEKAJ))]
	private Task<GCLHKHMIKGG> NKFKNJBNFCK(BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x833E750", Offset = "0x833CF50", VA = "0x18833E750")]
	[AsyncStateMachine(typeof(GCNEDCNKKJP))]
	private static Task<GCLHKHMIKGG> NKFKNJBNFCK(DHHGNBFICMC LMJFACKNPAI, GJLIIHMFEJN DNDIHNEMGPA, long MDLDCACFGIB, long ODGNDMLNOIH, long AEGGFNGPLLP, string KJCMLLPPGED, COMDBKPAHPB DCDOFGOEPAF, Guid JNEIGEKLLFO, CancellationToken DNHBNMHIDAC, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x833E720", Offset = "0x833CF20", VA = "0x18833E720")]
	private void GLGMCHAPBDB(HCHPFAEFOMI DHIDHGNHAGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
internal struct FFKBIJFANCF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct BCJKDGLACCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public FFKBIJFANCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x8333630", Offset = "0x8331E30", VA = "0x188333630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x8333BC0", Offset = "0x83323C0", VA = "0x188333BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private DHHGNBFICMC LMJFACKNPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private CCOEKIMEHPP NFNBKNAJBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	private BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	private float ENOJMCJADIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private float PADMEMKPFMP;

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x8338A10", Offset = "0x8337210", VA = "0x188338A10")]
	public static Task NMHNCJGDKMH(IBNHMOEDCKG CDLOFOIHHCC, CCOEKIMEHPP NFNBKNAJBPN, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x8338BB0", Offset = "0x83373B0", VA = "0x188338BB0")]
	[AsyncStateMachine(typeof(BCJKDGLACCP))]
	public Task OEANMMBFPHG(CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x83386C0", Offset = "0x8336EC0", VA = "0x1883386C0")]
	private static void BNFGDAGIKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x83388B0", Offset = "0x83370B0", VA = "0x1883388B0")]
	private void GNIJGKMAMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x83387F0", Offset = "0x8336FF0", VA = "0x1883387F0")]
	private static float FPICLNAAOPF(DHHGNBFICMC LMJFACKNPAI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x8338CD0", Offset = "0x83374D0", VA = "0x188338CD0")]
	private static float POOIIJHCBBP()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000171")]
internal struct HFJCAPPEAOL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct IHIMGMPPBOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public JIJPPLMKGGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private LMDCPPPCHDP <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private IBNHMOEDCKG <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private BKNFMOMHKNA.DFBLJHEEFLL <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private TaskAwaiter<NBCEMMDCCGB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x833EBE0", Offset = "0x833D3E0", VA = "0x18833EBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x833F400", Offset = "0x833DC00", VA = "0x18833F400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private struct JOGLNKFMGLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x8341000", Offset = "0x833F800", VA = "0x188341000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x8341330", Offset = "0x833FB30", VA = "0x188341330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x833BC60", Offset = "0x833A460", VA = "0x18833BC60")]
	[AsyncStateMachine(typeof(IHIMGMPPBOM))]
	public static Task OEANMMBFPHG(JIJPPLMKGGB JLIEPGCFHDK, CCOEKIMEHPP NFNBKNAJBPN, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x833BBF0", Offset = "0x833A3F0", VA = "0x18833BBF0")]
	private static Task<NBCEMMDCCGB> KKJHOMBFMBJ(JIJPPLMKGGB JLIEPGCFHDK, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x833BDA0", Offset = "0x833A5A0", VA = "0x18833BDA0")]
	[AsyncStateMachine(typeof(JOGLNKFMGLL))]
	private static Task PJNLAALJIJD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct FKIDNMDELAL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct HEGAMCBGPFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public FKIDNMDELAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x833B3C0", Offset = "0x8339BC0", VA = "0x18833B3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x833BA70", Offset = "0x833A270", VA = "0x18833BA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class AAOCHFJBBEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public AAOCHFJBBEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x8332270", Offset = "0x8330A70", VA = "0x188332270")]
		internal object LCNAIKIEBHE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct GKOCPHHNCED : IAsyncStateMachine
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
		public FKIDNMDELAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x833A930", Offset = "0x8339130", VA = "0x18833A930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x833ADB0", Offset = "0x83395B0", VA = "0x18833ADB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private bool COEJNFGCAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	private IBNHMOEDCKG CDLOFOIHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private CancellationToken DNHBNMHIDAC;

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x83390E0", Offset = "0x83378E0", VA = "0x1883390E0")]
	public static Task IGDABFGEGPB(IBNHMOEDCKG CDLOFOIHHCC, bool COEJNFGCAHO, BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, CancellationToken EIOFNAEPDMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x8339150", Offset = "0x8337950", VA = "0x188339150")]
	[AsyncStateMachine(typeof(HEGAMCBGPFG))]
	private Task OEANMMBFPHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x8339240", Offset = "0x8337A40", VA = "0x188339240")]
	[AsyncStateMachine(typeof(GKOCPHHNCED))]
	private Task OICMCEFAMKD(bool DHAFJMEDOCD, string HOAJLCLGOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40")]
	private bool DILENJBDPFK(bool COEJNFGCAHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
internal struct FBEEFHOPCJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct LPIGEGGLEGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public FBEEFHOPCJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x8343E70", Offset = "0x8342670", VA = "0x188343E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x83443E0", Offset = "0x8342BE0", VA = "0x1883443E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class EEKKOHFGGHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public EEKKOHFGGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x8337FA0", Offset = "0x83367A0", VA = "0x188337FA0")]
		internal object LCNAIKIEBHE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private struct DDIJGPPPJDA : IAsyncStateMachine
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
		public FBEEFHOPCJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x8336990", Offset = "0x8335190", VA = "0x188336990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x8336E10", Offset = "0x8335610", VA = "0x188336E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private AIOOMGADOIK FJPAJANIICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private IBNHMOEDCKG CDLOFOIHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private bool NFKPJPIPFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private CCOEKIMEHPP NFNBKNAJBPN;

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x83383D0", Offset = "0x8336BD0", VA = "0x1883383D0")]
	public static Task<Scene> LEIEBKPEDFG(IBNHMOEDCKG CDLOFOIHHCC, AIOOMGADOIK GBAKHJEAHOD, BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x8338450", Offset = "0x8336C50", VA = "0x188338450")]
	[AsyncStateMachine(typeof(LPIGEGGLEGC))]
	private Task<Scene> OEANMMBFPHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x8338330", Offset = "0x8336B30", VA = "0x188338330")]
	private bool EMOMCLKEDCL(CCOEKIMEHPP NFNBKNAJBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x8338360", Offset = "0x8336B60", VA = "0x188338360")]
	private void JAJHLBACIKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x8338570", Offset = "0x8336D70", VA = "0x188338570")]
	[AsyncStateMachine(typeof(DDIJGPPPJDA))]
	private Task<Scene> OICMCEFAMKD(string HOAJLCLGOHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal struct MHKGOJKIDIL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct BMHEMPBEMIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public AsyncTaskMethodBuilder<DJJCHOMGFCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public MHKGOJKIDIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public DJJCHOMGFCK nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public CCOEKIMEHPP deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private TaskAwaiter<DJJCHOMGFCK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x8334690", Offset = "0x8332E90", VA = "0x188334690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x8335160", Offset = "0x8333960", VA = "0x188335160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct NOGLGBDOEOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public AsyncTaskMethodBuilder<DJJCHOMGFCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public MHKGOJKIDIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public DJJCHOMGFCK state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private TaskAwaiter<NBCEMMDCCGB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x8347000", Offset = "0x8345800", VA = "0x188347000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x83472E0", Offset = "0x8345AE0", VA = "0x1883472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	private readonly JIJPPLMKGGB JLIEPGCFHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private readonly ECOIGKPCBDF IGBOEAEPDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private readonly PNOJEPKMLEK FPKEDPKOBFF;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private LMDCPPPCHDP CDKKILOLLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x6841CB0", Offset = "0x68404B0", VA = "0x186841CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x8344B20", Offset = "0x8343320", VA = "0x188344B20")]
	public MHKGOJKIDIL(JIJPPLMKGGB JLIEPGCFHDK, ECOIGKPCBDF IGBOEAEPDEM, PNOJEPKMLEK FPKEDPKOBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x83449A0", Offset = "0x83431A0", VA = "0x1883449A0")]
	[AsyncStateMachine(typeof(BMHEMPBEMIE))]
	public Task<DJJCHOMGFCK> IFKEMPDPDPL(DJJCHOMGFCK DIDBKJBGFIB, CCOEKIMEHPP LNLLHMLOLHD, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC, bool EFDEOMBCCHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x8344840", Offset = "0x8343040", VA = "0x188344840")]
	[AsyncStateMachine(typeof(NOGLGBDOEOC))]
	private Task<DJJCHOMGFCK> GGCLCPMOLEC(BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, DJJCHOMGFCK LLNIPANPIOA, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x8344810", Offset = "0x8343010", VA = "0x188344810")]
	private bool BFBCDFDFHNP(DJJCHOMGFCK ADIHKBDPPAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x83447F0", Offset = "0x8342FF0", VA = "0x1883447F0")]
	private void BAOGIJBMDME(string FJKOAJJOLCG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal struct FLNNFBCFCKN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct JHIDCDDNJKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public LMDCPPPCHDP operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public PNICJDGICNA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private LGBPIAHJJBO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private List<(PersistenceView, PEBBACKHDPF)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private (PersistenceView, PEBBACKHDPF) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x83408E0", Offset = "0x833F0E0", VA = "0x1883408E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x8340FA0", Offset = "0x833F7A0", VA = "0x188340FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x8339370", Offset = "0x8337B70", VA = "0x188339370")]
	[AsyncStateMachine(typeof(JHIDCDDNJKE))]
	public static Task OEANMMBFPHG(LMDCPPPCHDP EIJBIEHCPFH, CCOEKIMEHPP NFNBKNAJBPN, PNICJDGICNA LCFFPACFBID, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal struct ICHIFKLLLOP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct IOGBMOMIKJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public LMDCPPPCHDP operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public PNICJDGICNA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private FHIIJIJJHKM <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private LGBPIAHJJBO <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private List<(PersistenceView, PEBBACKHDPF)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private PEBBACKHDPF <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x833F460", Offset = "0x833DC60", VA = "0x18833F460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x833FD40", Offset = "0x833E540", VA = "0x18833FD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x833E390", Offset = "0x833CB90", VA = "0x18833E390")]
	[AsyncStateMachine(typeof(IOGBMOMIKJL))]
	public static Task OEANMMBFPHG(LMDCPPPCHDP EIJBIEHCPFH, CCOEKIMEHPP NFNBKNAJBPN, PNICJDGICNA LCFFPACFBID, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
public struct FIAECNINLBK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private struct BBCBAFIBPKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<IMJGIKLDEEF, PLLAIPNOLPG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public FIAECNINLBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public PIMHGEACHCB.BCKCHKHFKGB preloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		private TaskAwaiter<HCGBMJDNFKJ<IMJGIKLDEEF, PLLAIPNOLPG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x8332870", Offset = "0x8331070", VA = "0x188332870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x8332EF0", Offset = "0x83316F0", VA = "0x188332EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private long KELONIBMFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private long HJJKJCMGEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private Guid? HBEHHPFPLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	private IReadOnlyCollection<CABHDLHGNPC> EGIMEHMILOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private IReadOnlyCollection<CABHDLHGNPC> BOKOPCMHPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private MKMFJMPKGKL LFEPBJDMILF;

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x8338DA0", Offset = "0x83375A0", VA = "0x188338DA0")]
	public static Task<HCGBMJDNFKJ<IMJGIKLDEEF, PLLAIPNOLPG>> EGACOFDOINE(long MDLDCACFGIB, long ODGNDMLNOIH, OMKFKAIDNEH NDLKAGJANKG, PIMHGEACHCB.BCKCHKHFKGB PPMCBLICMLL, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x8338F00", Offset = "0x8337700", VA = "0x188338F00")]
	[AsyncStateMachine(typeof(BBCBAFIBPKI))]
	private Task<HCGBMJDNFKJ<IMJGIKLDEEF, PLLAIPNOLPG>> OEANMMBFPHG(PIMHGEACHCB.BCKCHKHFKGB PPMCBLICMLL, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
internal struct BKNFMOMHKNA
{
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	public struct DFBLJHEEFLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public List<OLPKOLEDJIC> KNHFGMHFLAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public List<PEBBACKHDPF> NBFIBMEDGCJ;

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xA81780", Offset = "0xA7FF80", VA = "0x180A81780")]
		public DFBLJHEEFLL(List<OLPKOLEDJIC> KNHFGMHFLAL, List<PEBBACKHDPF> NBFIBMEDGCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class CCLHKODGKLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public IEnumerable<OLPKOLEDJIC> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public CCLHKODGKLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x8335510", Offset = "0x8333D10", VA = "0x188335510")]
		internal object GECFHKNGMCK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	private IBNHMOEDCKG CDLOFOIHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	private CCOEKIMEHPP NFNBKNAJBPN;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private DHHGNBFICMC PILJEFNINPM
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x8333C20", Offset = "0x8332420", VA = "0x188333C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x8334630", Offset = "0x8332E30", VA = "0x188334630")]
	public static DFBLJHEEFLL OEANMMBFPHG(IBNHMOEDCKG CDLOFOIHHCC, CCOEKIMEHPP NFNBKNAJBPN)
	{
		return default(DFBLJHEEFLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x83343E0", Offset = "0x8332BE0", VA = "0x1883343E0")]
	private DFBLJHEEFLL OEANMMBFPHG()
	{
		return default(DFBLJHEEFLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x8333E40", Offset = "0x8332640", VA = "0x188333E40")]
	private DFBLJHEEFLL NHAADCNKNFL(IOKANKGCBIH HAEGAMBDMNL, FHIIJIJJHKM KOBJEGAJAKI)
	{
		return default(DFBLJHEEFLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x8333C70", Offset = "0x8332470", VA = "0x188333C70")]
	private bool KOOGKAMBCJM(IEnumerable<OLPKOLEDJIC> KNHFGMHFLAL)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal struct CPKLADFMJJN
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class FGAIONKKDKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public BKNFMOMHKNA.DFBLJHEEFLL instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public FGAIONKKDKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x8338CF0", Offset = "0x83374F0", VA = "0x188338CF0")]
		internal object AJBHMPLJONI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class AINPOPNFEGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public AINPOPNFEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x8332560", Offset = "0x8330D60", VA = "0x188332560")]
		internal object LECOAECKPPP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x83363E0", Offset = "0x8334BE0", VA = "0x1883363E0")]
	public static void OEANMMBFPHG(LMDCPPPCHDP EIJBIEHCPFH, CCOEKIMEHPP NFNBKNAJBPN, BKNFMOMHKNA.DFBLJHEEFLL GKJPMOHEAEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal class PNOJEPKMLEK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private struct NLJBCLFKFLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public PNOJEPKMLEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public DJJCHOMGFCK operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public CCOEKIMEHPP deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x8346830", Offset = "0x8345030", VA = "0x188346830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x8346FA0", Offset = "0x83457A0", VA = "0x188346FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class LHPEPJFDGDA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018E")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006E5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006E6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006E7")]
			public LHPEPJFDGDA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006E8")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006E9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x835AB80", Offset = "0x8359380", VA = "0x18835AB80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x835AD20", Offset = "0x8359520", VA = "0x18835AD20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public PNOJEPKMLEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public LHPEPJFDGDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x8358530", Offset = "0x8356D30", VA = "0x188358530")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task IIJLAOBMPEP(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private struct FMHCHKNLPCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public PNOJEPKMLEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		private LHPEPJFDGDA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x8350CD0", Offset = "0x834F4D0", VA = "0x188350CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x8351200", Offset = "0x834FA00", VA = "0x188351200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private struct GNCKDGPIAIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public PNOJEPKMLEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		private Dictionary<Guid, List<CIPAFGDGOOC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x83512E0", Offset = "0x834FAE0", VA = "0x1883512E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x83518F0", Offset = "0x83500F0", VA = "0x1883518F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private struct HECONGDCECJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public PNOJEPKMLEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private Dictionary<Guid, List<CIPAFGDGOOC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x8351950", Offset = "0x8350150", VA = "0x188351950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x8351FE0", Offset = "0x83507E0", VA = "0x188351FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private sealed class BKIOBLLELBK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000193")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000709")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400070A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400070B")]
			public CIPAFGDGOOC handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400070C")]
			public BKIOBLLELBK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400070D")]
			private LGBPIAHJJBO <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400070E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0x835A6C0", Offset = "0x8358EC0", VA = "0x18835A6C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(RVA = "0x835AB20", Offset = "0x8359320", VA = "0x18835AB20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public ILMBABOFIDE runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public List<CIPAFGDGOOC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public BKIOBLLELBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x834BF40", Offset = "0x834A740", VA = "0x18834BF40")]
		internal object DOBKJNGOMMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x834C120", Offset = "0x834A920", VA = "0x18834C120")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task OLCNBFAPHFP(CIPAFGDGOOC handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x834C030", Offset = "0x834A830", VA = "0x18834C030")]
		internal object JEMOMJCILEK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private struct COFOMPABJFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public ILMBABOFIDE runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public List<CIPAFGDGOOC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private BKIOBLLELBK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x834EC60", Offset = "0x834D460", VA = "0x18834EC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x834F130", Offset = "0x834D930", VA = "0x18834F130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private struct BFMGHJEKJPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public PNOJEPKMLEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x834BB80", Offset = "0x834A380", VA = "0x18834BB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x834BE70", Offset = "0x834A670", VA = "0x18834BE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class BGHNGJBLIKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public BGHNGJBLIKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x834BED0", Offset = "0x834A6D0", VA = "0x18834BED0")]
		internal object DNMCNBIGGIB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private struct CIGMNLJLMKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public PNOJEPKMLEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public CCOEKIMEHPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x834E750", Offset = "0x834CF50", VA = "0x18834E750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x834EC00", Offset = "0x834D400", VA = "0x18834EC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class IDNLPLGFAGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public IDNLPLGFAGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x8352920", Offset = "0x8351120", VA = "0x188352920")]
		internal object CPKFKGBAMBI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct KIFDFOGAFMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public PNOJEPKMLEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private LGBPIAHJJBO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		private TaskAwaiter<NBCEMMDCCGB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x8357600", Offset = "0x8355E00", VA = "0x188357600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x8357C30", Offset = "0x8356430", VA = "0x188357C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class IJAANLJHBAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public IJAANLJHBAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x8352990", Offset = "0x8351190", VA = "0x188352990")]
		internal object JPGAPDFLOFK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private readonly JIJPPLMKGGB JLIEPGCFHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private NBJGBNFKILK FPKEDPKOBFF;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private LMDCPPPCHDP CDKKILOLLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x10BC830", Offset = "0x10BB030", VA = "0x1810BC830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public PNOJEPKMLEK(JIJPPLMKGGB JLIEPGCFHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x8348E70", Offset = "0x8347670", VA = "0x188348E70")]
	[AsyncStateMachine(typeof(NLJBCLFKFLK))]
	public Task OEANMMBFPHG(DJJCHOMGFCK NMBDJBIBPNO, CCOEKIMEHPP LNLLHMLOLHD, BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x8348B60", Offset = "0x8347360", VA = "0x188348B60")]
	[AsyncStateMachine(typeof(FMHCHKNLPCB))]
	private Task LINEJONMFIA(CCOEKIMEHPP NFNBKNAJBPN, BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x8348A20", Offset = "0x8347220", VA = "0x188348A20")]
	[AsyncStateMachine(typeof(GNCKDGPIAIB))]
	private Task LGAJCLEANCI(CCOEKIMEHPP NFNBKNAJBPN, BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x83485A0", Offset = "0x8346DA0", VA = "0x1883485A0")]
	[AsyncStateMachine(typeof(HECONGDCECJ))]
	private Task EKFHBLKDEPH(CCOEKIMEHPP NFNBKNAJBPN, BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x8348820", Offset = "0x8347020", VA = "0x188348820")]
	[AsyncStateMachine(typeof(COFOMPABJFA))]
	private Task HBKKJJGBDPB(Guid EMJJBPBFNEJ, List<CIPAFGDGOOC> KKMOELDCMMA, ILMBABOFIDE BHACHGGEDKL, CCOEKIMEHPP NFNBKNAJBPN, CancellationToken JILOCOLKOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x8348350", Offset = "0x8346B50", VA = "0x188348350")]
	[AsyncStateMachine(typeof(BFMGHJEKJPL))]
	private Task EEIFEMEHGNG(CCOEKIMEHPP NFNBKNAJBPN, BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x8348FC0", Offset = "0x83477C0", VA = "0x188348FC0")]
	[AsyncStateMachine(typeof(CIGMNLJLMKK))]
	private Task PFPAJMNFNKL(Guid GGBBCCJPADB, CCOEKIMEHPP NFNBKNAJBPN, BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x83486E0", Offset = "0x8346EE0", VA = "0x1883486E0")]
	[AsyncStateMachine(typeof(KIFDFOGAFMN))]
	private Task FBMNGPNLAKF(Guid GGBBCCJPADB, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x8348490", Offset = "0x8346C90", VA = "0x188348490")]
	private void EFIEOGEJIFK(Guid GGBBCCJPADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x8348970", Offset = "0x8347170", VA = "0x188348970")]
	private void IAIBBLJHCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x8349100", Offset = "0x8347900", VA = "0x188349100")]
	public Guid PJMKAFPPIIM(DJJCHOMGFCK NOHOBNAMPCA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x8348CA0", Offset = "0x83474A0", VA = "0x188348CA0")]
	[CompilerGenerated]
	private object LNPMAHLAGPM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
internal struct JOCCLCAIJHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private struct KLLHODPHNMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public JOCCLCAIJHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		private IEnumerator<LLNJLFIDPAD> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x8357C90", Offset = "0x8356490", VA = "0x188357C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x8358330", Offset = "0x8356B30", VA = "0x188358330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000737")]
	private DHHGNBFICMC LMJFACKNPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000738")]
	private BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000739")]
	private CancellationToken DNHBNMHIDAC;

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x8357140", Offset = "0x8355940", VA = "0x188357140")]
	public static Task CGCNLGKKAMJ(DHHGNBFICMC LMJFACKNPAI, BGHFCMFIENI<string>.KHCJHMNAJKC NIBJMJJGOBF, CancellationToken EIOFNAEPDMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x83571B0", Offset = "0x83559B0", VA = "0x1883571B0")]
	[AsyncStateMachine(typeof(KLLHODPHNMP))]
	private Task OEANMMBFPHG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public readonly struct KFPKEIFCKFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000740")]
	public readonly bool BFFNGHOJHFA;

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x2976410", Offset = "0x2974C10", VA = "0x182976410")]
	public KFPKEIFCKFO(bool OHHDCBEDJKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public readonly struct MKHFNGCIHMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000741")]
	public readonly IOKANKGCBIH? DHINALDFLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000742")]
	public readonly EEHGIOKIEIO BFAIEKHDOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000743")]
	public readonly Guid? CPEKFMPNMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000744")]
	public readonly IReadOnlyList<Guid> DHPDLINGOFO;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public IReadOnlyCollection<string> BDIBDMCIAGG
	{
		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x8358790", Offset = "0x8356F90", VA = "0x188358790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public IReadOnlyDictionary<long, int> MAACJEEIEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x8358770", Offset = "0x8356F70", VA = "0x188358770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x83587B0", Offset = "0x8356FB0", VA = "0x1883587B0")]
	public MKHFNGCIHMI(IOKANKGCBIH? PDNEBCPKAAP, EEHGIOKIEIO GDCMIODMEKH, Guid? KHGICEEABBP, [Optional] IReadOnlyList<Guid>? KDPKDIOJJII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal class JFJJBIEFCOE : DCBOMABPBFJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private struct JIEJNHJMONF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public AsyncTaskMethodBuilder<MKHFNGCIHMI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public JFJJBIEFCOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public HEDEPEBBEPH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public AJCFEJBAGHB roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		private LGBPIAHJJBO <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x8356050", Offset = "0x8354850", VA = "0x188356050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x83566F0", Offset = "0x8354EF0", VA = "0x1883566F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[CompilerGenerated]
	private sealed class JPFNPNCPOAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public JPFNPNCPOAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x83572A0", Offset = "0x8355AA0", VA = "0x1883572A0")]
		internal object MNILENHPMHP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[CompilerGenerated]
	private struct PEFBPJIIMFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public JFJJBIEFCOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public HEDEPEBBEPH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		private JPFNPNCPOAN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		private LGBPIAHJJBO <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		private JNOBHPMEBLN<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x8359BA0", Offset = "0x83583A0", VA = "0x188359BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x835A660", Offset = "0x8358E60", VA = "0x18835A660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000745")]
	private readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x4000746")]
	private static readonly TimeSpan KBPIHHBHGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000747")]
	private readonly KFHNDJGGMDC KAOBGODAKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000748")]
	private readonly KKAJMOJBBFD DMACGHOMFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000749")]
	private readonly NLDGDOGNBHB NLNIFADPOGJ;

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x8355FE0", Offset = "0x83547E0", VA = "0x188355FE0")]
	public JFJJBIEFCOE(JIJPPLMKGGB JLIEPGCFHDK, KFHNDJGGMDC KAOBGODAKKI, KKAJMOJBBFD LGJKONHHLND, NLDGDOGNBHB NLNIFADPOGJ, LLPKKNNAIAE NOMHFHBJHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x8355BD0", Offset = "0x83543D0", VA = "0x188355BD0")]
	[AsyncStateMachine(typeof(JIEJNHJMONF))]
	public Task<MKHFNGCIHMI> LIJGMGKAKKG(long ODGNDMLNOIH, AJCFEJBAGHB ANLCGKGKMEK, HEDEPEBBEPH DGMIBEGFLND, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x8354E30", Offset = "0x8353630", VA = "0x188354E30")]
	[AsyncStateMachine(typeof(PEFBPJIIMFH))]
	private Task BFFCDIFNCIO(HEDEPEBBEPH DGMIBEGFLND, PersistenceView[] KEBBLNGBLMJ, StringBuilder GCOLEPMCEBC, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x8354F70", Offset = "0x8353770", VA = "0x188354F70")]
	private MKHFNGCIHMI GCKLAOCOBPB(long ODGNDMLNOIH, AJCFEJBAGHB ANLCGKGKMEK, HEDEPEBBEPH DGMIBEGFLND, IEnumerable<PersistenceView> KEBBLNGBLMJ, StringBuilder GCOLEPMCEBC)
	{
		return default(MKHFNGCIHMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x8355A10", Offset = "0x8354210", VA = "0x188355A10")]
	private IOKANKGCBIH IGOPLCGCDDO(long ODGNDMLNOIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x8355D20", Offset = "0x8354520", VA = "0x188355D20")]
	private void MKOBEPMLGNE(IOKANKGCBIH IFHGONGGBMP, StringBuilder GCOLEPMCEBC, IEnumerable<PersistenceView> KEBBLNGBLMJ, [In] HCIMABFACGN LBNIKJEOOKI, BIOKGIBHGBO FCGFJNKMNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x8355580", Offset = "0x8353D80", VA = "0x188355580")]
	private void GCPGBIPJAAP(IOKANKGCBIH IFHGONGGBMP, StringBuilder GCOLEPMCEBC, PersistenceView JNLFCOMKBMA, BIOKGIBHGBO FCGFJNKMNLM, [In] HCIMABFACGN LBNIKJEOOKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
internal class ELIPGBBJBEL : DCBOMABPBFJ
{
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private sealed class FCDGGHNNMMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public NHIBJNFDGFI.IIEBADJIKNF roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public FCDGGHNNMMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x8350870", Offset = "0x834F070", VA = "0x188350870")]
		internal object ABEMKFGKDJB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private struct JCGEOJGBOMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public AsyncTaskMethodBuilder<(NHIBJNFDGFI.IIEBADJIKNF roomDataUpload, NHIBJNFDGFI.IIEBADJIKNF subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public MKHFNGCIHMI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public DHHGNBFICMC callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		private FCDGGHNNMMN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		private TaskAwaiter<NHIBJNFDGFI.IIEBADJIKNF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x8354030", Offset = "0x8352830", VA = "0x188354030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x83548B0", Offset = "0x83530B0", VA = "0x1883548B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private struct DALBHHDODLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public AsyncTaskMethodBuilder<EEIBBLLOKKE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public ELIPGBBJBEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public OGEHCBNGKDA roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public MKHFNGCIHMI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private TaskAwaiter<EEIBBLLOKKE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x834F190", Offset = "0x834D990", VA = "0x18834F190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x834F430", Offset = "0x834DC30", VA = "0x18834F430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private struct IMBDEBPJDLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		public AsyncTaskMethodBuilder<EEIBBLLOKKE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		public DHHGNBFICMC callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		public MKHFNGCIHMI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		public AJECEHEMBLO ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public OGEHCBNGKDA roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		private TaskAwaiter<(NHIBJNFDGFI.IIEBADJIKNF roomDataUpload, NHIBJNFDGFI.IIEBADJIKNF subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		private TaskAwaiter<EEIBBLLOKKE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x83535C0", Offset = "0x8351DC0", VA = "0x1883535C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x8353C20", Offset = "0x8352420", VA = "0x188353C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct JMEMHMNEMGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public AsyncTaskMethodBuilder<OLKDICNFHHB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public ELIPGBBJBEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public MKHFNGCIHMI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		private TaskAwaiter<(NHIBJNFDGFI.IIEBADJIKNF roomDataUpload, NHIBJNFDGFI.IIEBADJIKNF subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		private TaskAwaiter<OLKDICNFHHB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x8356760", Offset = "0x8354F60", VA = "0x188356760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x8356C10", Offset = "0x8355410", VA = "0x188356C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private sealed class CCBCNKJMDFL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AC")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000796")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000797")]
			public AsyncTaskMethodBuilder<NBCEMMDCCGB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000798")]
			public CCBCNKJMDFL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000799")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400079A")]
			private NBCEMMDCCGB <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400079B")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400079C")]
			private TaskAwaiter<OLKDICNFHHB> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400079D")]
			private TaskAwaiter<EEIBBLLOKKE> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400079E")]
			private TaskAwaiter<NBCEMMDCCGB> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006B8")]
			[Cpp2IlInjected.Address(RVA = "0x835AD80", Offset = "0x8359580", VA = "0x18835AD80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B9")]
			[Cpp2IlInjected.Address(RVA = "0x835BF80", Offset = "0x835A780", VA = "0x18835BF80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public ELIPGBBJBEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public MKHFNGCIHMI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public OGEHCBNGKDA roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public KFPKEIFCKFO roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public CCBCNKJMDFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x834E620", Offset = "0x834CE20", VA = "0x18834E620")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<NBCEMMDCCGB> LMIJBAOJJJC(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private struct JBCBBEHKBCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		public AsyncTaskMethodBuilder<NBCEMMDCCGB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		public ELIPGBBJBEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		public MKHFNGCIHMI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		public OGEHCBNGKDA roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		public KFPKEIFCKFO roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		private TaskAwaiter<NBCEMMDCCGB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x8353C90", Offset = "0x8352490", VA = "0x188353C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x8353FC0", Offset = "0x83527C0", VA = "0x188353FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000763")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x4000764")]
	private static readonly LLPKKNNAIAE ADMHDNBLAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000765")]
	private readonly OODEDDNEKOO IJNPLBEHPOH;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private IBNHMOEDCKG MOHKHIHLFND
	{
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x831F3C0", Offset = "0x831DBC0", VA = "0x18831F3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x83507E0", Offset = "0x834EFE0", VA = "0x1883507E0")]
	public ELIPGBBJBEL(JIJPPLMKGGB JLIEPGCFHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x834FE30", Offset = "0x834E630", VA = "0x18834FE30")]
	[AsyncStateMachine(typeof(JCGEOJGBOMG))]
	private static Task<(NHIBJNFDGFI.IIEBADJIKNF, NHIBJNFDGFI.IIEBADJIKNF)> DMJOIHNNNBN(DHHGNBFICMC LMJFACKNPAI, MKHFNGCIHMI EAIJCJBEHLN, long MDLDCACFGIB, long DBEJCKJKFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x83502D0", Offset = "0x834EAD0", VA = "0x1883502D0")]
	[AsyncStateMachine(typeof(DALBHHDODLO))]
	public Task<EEIBBLLOKKE> EGFGGKFMJFF(int IIKNDOCDPLN, [CanBeNull] OGEHCBNGKDA HBFLJINIIGI, MKHFNGCIHMI EAIJCJBEHLN, long MDLDCACFGIB, long DBEJCKJKFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x834FF80", Offset = "0x834E780", VA = "0x18834FF80")]
	public static Task<EEIBBLLOKKE> EGFGGKFMJFF(DHHGNBFICMC LMJFACKNPAI, int IIKNDOCDPLN, [CanBeNull] OGEHCBNGKDA HBFLJINIIGI, MKHFNGCIHMI EAIJCJBEHLN, long MDLDCACFGIB, long DBEJCKJKFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x8350440", Offset = "0x834EC40", VA = "0x188350440")]
	[AsyncStateMachine(typeof(IMBDEBPJDLA))]
	public static Task<EEIBBLLOKKE> EGFGGKFMJFF(DHHGNBFICMC LMJFACKNPAI, int IIKNDOCDPLN, [CanBeNull] OGEHCBNGKDA HBFLJINIIGI, MKHFNGCIHMI EAIJCJBEHLN, long MDLDCACFGIB, long DBEJCKJKFPB, AJECEHEMBLO CHGHBGNIKJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x83505D0", Offset = "0x834EDD0", VA = "0x1883505D0")]
	[AsyncStateMachine(typeof(JMEMHMNEMGM))]
	private Task<OLKDICNFHHB> MIBMDEKEODL(string KJCMLLPPGED, int IIKNDOCDPLN, MKHFNGCIHMI EAIJCJBEHLN, long MDLDCACFGIB, long DBEJCKJKFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x834FC80", Offset = "0x834E480", VA = "0x18834FC80")]
	[AsyncStateMachine(typeof(JBCBBEHKBCJ))]
	public Task<NBCEMMDCCGB> AKDPJJNGFHG(int IIKNDOCDPLN, OGEHCBNGKDA? HBFLJINIIGI, MKHFNGCIHMI EAIJCJBEHLN, long MDLDCACFGIB, long DBEJCKJKFPB, KFPKEIFCKFO ANHMJOMJPDK, BGHFCMFIENI<string>.KHCJHMNAJKC OOHELHJHBGK, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
public abstract class DGEPIMADCLN<T> where T : DGEPIMADCLN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007AB")]
	internal readonly IBNHMOEDCKG DLPCGMFABBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007AC")]
	private int? EHMGMONECGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007AD")]
	protected readonly Guid MADKPKKPOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007AE")]
	protected readonly HLOJBJMGFLA MNOEJCNFAFF;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected T MOGNFJEIOBO
	{
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x68D0580", Offset = "0x68CED80", VA = "0x1868D0580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x68D0930", Offset = "0x68CF130", VA = "0x1868D0930")]
	internal DGEPIMADCLN(IBNHMOEDCKG DEFDBHCGBHN, HLOJBJMGFLA JAFKFKLBIBG, [Optional] Guid? KJHDGFKNPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x68D0680", Offset = "0x68CEE80", VA = "0x1868D0680")]
	private NBCEMMDCCGB MLJDFEHBPDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	protected virtual void LJCPJLAMEJA(NBCEMMDCCGB NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x68D0760", Offset = "0x68CEF60", VA = "0x1868D0760")]
	public T NFOOPLIHHPE(GFEBJDBBDID JFDOFPAEGJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x68D05E0", Offset = "0x68CEDE0", VA = "0x1868D05E0")]
	public T KONEPBCFIMA(int IEMDIBBBFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x68D0800", Offset = "0x68CF000", VA = "0x1868D0800", Slot = "5")]
	public virtual Task<MJOPCCNIMCA> PGPMBLABIOL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
public class LGNELIMGMHE : DGEPIMADCLN<LGNELIMGMHE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007AF")]
	private HHEFLMKOLLI JDGDKOENECG;

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x8358460", Offset = "0x8356C60", VA = "0x188358460")]
	internal LGNELIMGMHE(IBNHMOEDCKG DEFDBHCGBHN, HLOJBJMGFLA JAFKFKLBIBG, [Optional] Guid? KJHDGFKNPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x76029B0", Offset = "0x76011B0", VA = "0x1876029B0")]
	public LGNELIMGMHE OAMEPDFBHPH(HHEFLMKOLLI JDGDKOENECG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x8358390", Offset = "0x8356B90", VA = "0x188358390", Slot = "4")]
	protected override void LJCPJLAMEJA(NBCEMMDCCGB NJAAPDELBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public class BLAEKIAIDMC : DGEPIMADCLN<BLAEKIAIDMC>
{
	[Cpp2IlInjected.Token(Token = "0x20001B1")]
	internal enum CEBBHCFGPHG
	{
		[Cpp2IlInjected.Token(Token = "0x40007B4")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007B5")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40007B6")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	[CompilerGenerated]
	private struct FDGJNEKMFJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007B8")]
		public AsyncTaskMethodBuilder<MJOPCCNIMCA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public BLAEKIAIDMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		private TaskAwaiter<MJOPCCNIMCA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x83508C0", Offset = "0x834F0C0", VA = "0x1883508C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x8350C60", Offset = "0x834F460", VA = "0x188350C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007B0")]
	private CEBBHCFGPHG PEPIDKGKFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007B1")]
	private string LEFOIKHEOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007B2")]
	private OGEHCBNGKDA JDGDKOENECG;

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x834C560", Offset = "0x834AD60", VA = "0x18834C560")]
	internal BLAEKIAIDMC(IBNHMOEDCKG DEFDBHCGBHN, HLOJBJMGFLA JAFKFKLBIBG, [Optional] Guid? KJHDGFKNPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x834C440", Offset = "0x834AC40", VA = "0x18834C440")]
	public BLAEKIAIDMC NLDBEKBIIKE(string NIAMDMBDIJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x834C260", Offset = "0x834AA60", VA = "0x18834C260")]
	public BLAEKIAIDMC EOEFPKOLKDM(bool PIEALINLHLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x834C280", Offset = "0x834AA80", VA = "0x18834C280")]
	public BLAEKIAIDMC HMPKIONAOFA(bool BDKHAAFFCNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x834C410", Offset = "0x834AC10", VA = "0x18834C410")]
	public BLAEKIAIDMC LJOCJFJOPFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x834C2A0", Offset = "0x834AAA0", VA = "0x18834C2A0", Slot = "4")]
	protected override void LJCPJLAMEJA(NBCEMMDCCGB NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x834C470", Offset = "0x834AC70", VA = "0x18834C470", Slot = "5")]
	[AsyncStateMachine(typeof(FDGJNEKMFJF))]
	public override Task<MJOPCCNIMCA> PGPMBLABIOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x834C220", Offset = "0x834AA20", VA = "0x18834C220")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<MJOPCCNIMCA> BIONDBLCJNO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
internal static class NHFOMENEFAK
{
	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x8358BD0", Offset = "0x83573D0", VA = "0x188358BD0")]
	public static void IHHIHJPGCKG(this IJNMEJLNFNJ AELOIOPPFMH, ADDOLAOCDBG MLJBGHHJPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x8358D20", Offset = "0x8357520", VA = "0x188358D20")]
	public static void PHLLPIDLFGA(this ADDOLAOCDBG CDFKPNNAMDG, [Optional] string NJAAPDELBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
public static class MAKFOCEPJIO
{
	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x8358620", Offset = "0x8356E20", VA = "0x188358620")]
	public static COMDBKPAHPB KKMAHIJFFJO(this KHDBOEKAKMH GKMGIBMAGHB)
	{
		return default(COMDBKPAHPB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x83586C0", Offset = "0x8356EC0", VA = "0x1883586C0")]
	public static KHDBOEKAKMH NLEAFCFOBPF(this COMDBKPAHPB PNLFCNFNBCP)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001B5")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001B6")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007BF")]
			public DMMLJMIMHAI ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007C0")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007C1")]
			public DMMLJMIMHAI HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007C2")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007C3")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007C4")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006DA")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		private static DMMLJMIMHAI[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		private Dictionary<DMMLJMIMHAI, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x835C680", Offset = "0x835AE80", VA = "0x18835C680")]
		public bool OAPJAOHOGCK(DMMLJMIMHAI OJFJOGGNGGD, [Out] ResultConfig PKENAIPAKDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x835C540", Offset = "0x835AD40", VA = "0x18835C540")]
		public ResultConfig IJNPKADHGMO(DMMLJMIMHAI NLGEMFKLFCF, [Optional] HashSet<DMMLJMIMHAI> LOJOFDEFPGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x835CCA0", Offset = "0x835B4A0", VA = "0x18835CCA0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x835C6F0", Offset = "0x835AEF0", VA = "0x18835C6F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xB90A50", Offset = "0xB8F250", VA = "0x180B90A50")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B8")]
public class OBEAIDOCMNO : PPIGJJKFIEK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[CompilerGenerated]
	private struct KHFJONAAEKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		public OBEAIDOCMNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x8357310", Offset = "0x8355B10", VA = "0x188357310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x83575A0", Offset = "0x8355DA0", VA = "0x1883575A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[CompilerGenerated]
	private struct JEHAGCBCHMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		public BGHFCMFIENI<string>.KHCJHMNAJKC timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		public PPIGJJKFIEK preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		private BGHFCMFIENI<string>.KHCJHMNAJKC <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x8354920", Offset = "0x8353120", VA = "0x188354920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x8354DD0", Offset = "0x83535D0", VA = "0x188354DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007CA")]
	private readonly BBCGEBCLLEC CBKNHBLHJMG;

	[Cpp2IlInjected.Token(Token = "0x40007CB")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public string KGJEEKNFPPG
	{
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x8358EC0", Offset = "0x83576C0", VA = "0x188358EC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x8359000", Offset = "0x8357800", VA = "0x188359000")]
	[PJMOOJOMMCC.OJAOBFKEEAO.IHGAJDILMAJ]
	internal static void OHIEJCAALDD(HHDGAAFLDEF LFLOONKADLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	[RecRoom.NoEngine.Common.Preserve]
	public OBEAIDOCMNO([LDAFGEHKDJK(null)] BBCGEBCLLEC CBKNHBLHJMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x8358EF0", Offset = "0x83576F0", VA = "0x188358EF0", Slot = "5")]
	[AsyncStateMachine(typeof(KHFJONAAEKM))]
	public Task OEANMMBFPHG(BGHFCMFIENI<string>.KHCJHMNAJKC PFDDAGHNIBE, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x8358DA0", Offset = "0x83575A0", VA = "0x188358DA0")]
	[AsyncStateMachine(typeof(JEHAGCBCHMK))]
	private Task EPLJFCHBFBD(PPIGJJKFIEK LCKPIDMFOHK, BGHFCMFIENI<string>.KHCJHMNAJKC PFDDAGHNIBE, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
public interface BBCGEBCLLEC : PPIGJJKFIEK
{
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
public interface PPIGJJKFIEK
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	string KGJEEKNFPPG
	{
		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OEANMMBFPHG(BGHFCMFIENI<string>.KHCJHMNAJKC PFDDAGHNIBE, CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
public static class DKENKNHFEMP
{
	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x834F4A0", Offset = "0x834DCA0", VA = "0x18834F4A0")]
	[PJMOOJOMMCC.OJAOBFKEEAO.IHGAJDILMAJ]
	internal static void JMICLABLGOM(HHDGAAFLDEF LFLOONKADLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public interface GANHOFFPCAM : IEquatable<GANHOFFPCAM>
{
	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	DateTime FHPAMAHHDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKJILBFBEIH();

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NLCCKOEPODO(long MDLDCACFGIB, long ODGNDMLNOIH, [Out] MKHFNGCIHMI EAIJCJBEHLN);
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
internal class ILEPJHJDIPE : CLIJODHNBOD
{
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	[CompilerGenerated]
	private sealed class AMFENCFPJCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		public OCGCHDNKCFE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public AMFENCFPJCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x834BB10", Offset = "0x834A310", VA = "0x18834BB10")]
		internal object CNICHGFEMOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007D9")]
	private readonly NOCOEGOIBBK PIFGMGJKFKI;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<GANHOFFPCAM> MINBHPPHPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x8352A00", Offset = "0x8351200", VA = "0x188352A00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x83531D0", Offset = "0x83519D0", VA = "0x1883531D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	[UnityEngine.Scripting.Preserve]
	public ILEPJHJDIPE([LDAFGEHKDJK(null)] NOCOEGOIBBK PIFGMGJKFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x8352AB0", Offset = "0x83512B0", VA = "0x188352AB0", Slot = "6")]
	public bool JLPAGNNLABJ(long MDLDCACFGIB, long ODGNDMLNOIH, MKHFNGCIHMI EAIJCJBEHLN, OCGCHDNKCFE FGGEEODNNKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0xD953A0", Offset = "0xD93BA0", VA = "0x180D953A0")]
	private void BAEDPIPPOCH(GANHOFFPCAM NPNJHLNLNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x8353450", Offset = "0x8351C50", VA = "0x188353450", Slot = "7")]
	public bool PHJDGEKKIIO(long MDLDCACFGIB, long ODGNDMLNOIH, [Out] GANHOFFPCAM EFAOGHPAKDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x83533A0", Offset = "0x8351BA0", VA = "0x1883533A0", Slot = "8")]
	public bool MOLDMIABLLA(long MDLDCACFGIB, long ODGNDMLNOIH, OCGCHDNKCFE FGGEEODNNKF, [Out] GANHOFFPCAM EFAOGHPAKDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x8352DB0", Offset = "0x83515B0", VA = "0x188352DB0")]
	private void LKHMMKNCPJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x8353280", Offset = "0x8351A80", VA = "0x188353280", Slot = "9")]
	public void MFOOCKFFCAC(long MDLDCACFGIB, long ODGNDMLNOIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
internal abstract class PBLOBJBMFIH : NOCOEGOIBBK
{
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	protected enum OBFGPIKBECH : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007E1")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007E2")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C4")]
	[CompilerGenerated]
	private sealed class EAMPGKBGKGE : IEnumerable<GANHOFFPCAM>, IEnumerable, IEnumerator<GANHOFFPCAM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		private GANHOFFPCAM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public PBLOBJBMFIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		private OCGCHDNKCFE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		public OCGCHDNKCFE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		private GANHOFFPCAM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xE73320", Offset = "0xE71B20", VA = "0x180E73320")]
		[DebuggerHidden]
		public EAMPGKBGKGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x834F8B0", Offset = "0x834E0B0", VA = "0x18834F8B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x834FB90", Offset = "0x834E390", VA = "0x18834FB90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x834FAE0", Offset = "0x834E2E0", VA = "0x18834FAE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GANHOFFPCAM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x834FAE0", Offset = "0x834E2E0", VA = "0x18834FAE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[CompilerGenerated]
	private sealed class EHCOGJGBIKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		public OCGCHDNKCFE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public EHCOGJGBIKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x834FBE0", Offset = "0x834E3E0", VA = "0x18834FBE0")]
		internal object HNPHBOONLBO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[CompilerGenerated]
	private sealed class GABEGIFMHCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		public PBLOBJBMFIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public GABEGIFMHCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x8351260", Offset = "0x834FA60", VA = "0x188351260")]
		internal void NKBOCBIGADC(BLLOLGEPOJA.BFEJCGDEKOO ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007DF")]
	private readonly object FBHBMFMNIEM;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	protected string DHHFJHPHCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x83590E0", Offset = "0x83578E0", VA = "0x1883590E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public abstract CPDPEFDDKLC NHOEFDDAAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x8359B20", Offset = "0x8358320", VA = "0x188359B20")]
	protected PBLOBJBMFIH([CanBeNull] string AMNODOIMNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x8359830", Offset = "0x8358030", VA = "0x188359830", Slot = "5")]
	public bool JJEIJHDNKLC(long MDLDCACFGIB, long ODGNDMLNOIH, OCGCHDNKCFE FGGEEODNNKF, [Out] GANHOFFPCAM NPNJHLNLNMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x8359A90", Offset = "0x8358290", VA = "0x188359A90", Slot = "6")]
	[IteratorStateMachine(typeof(EAMPGKBGKGE))]
	public IEnumerable<GANHOFFPCAM> LJDLINPPOPI(OCGCHDNKCFE FGGEEODNNKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void HIODBFNBMEB(Stream BBDMMNBMNGO, long MDLDCACFGIB, long ODGNDMLNOIH, MKHFNGCIHMI EAIJCJBEHLN);

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool LKFMCBLFJIO(Stream GFEEMJMJJJF, long MDLDCACFGIB, long ODGNDMLNOIH, KFFEHEOGAFL NJMNNMKPECE, [Out] MKHFNGCIHMI EAIJCJBEHLN);

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x83590F0", Offset = "0x83578F0", VA = "0x1883590F0", Slot = "7")]
	public GANHOFFPCAM HAGKPIELFKJ(long MDLDCACFGIB, long ODGNDMLNOIH, MKHFNGCIHMI EAIJCJBEHLN, OCGCHDNKCFE FGGEEODNNKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo GKMDNGAFJOB(long MDLDCACFGIB, long ODGNDMLNOIH, OCGCHDNKCFE FGGEEODNNKF, OBFGPIKBECH LHFCJFNBAPI);

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo LADPGADGCOI(OCGCHDNKCFE FGGEEODNNKF, OBFGPIKBECH LHFCJFNBAPI);

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x8359A20", Offset = "0x8358220", VA = "0x188359A20")]
	protected void JLIILIHNGOD(BLLOLGEPOJA.BFEJCGDEKOO HHOOHABHPEO, string FJKOAJJOLCG, FileInfo EPNFPGFJOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x8359470", Offset = "0x8357C70", VA = "0x188359470")]
	internal bool HNKNPPMGENH(FileInfo JOBEJPMDODP, long MDLDCACFGIB, long ODGNDMLNOIH, [Out] MKHFNGCIHMI EAIJCJBEHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	private void GOEOMPEDIHM(Exception GEIIPKBBOEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
internal class BMFBAKJPHAB : PBLOBJBMFIH
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public override CPDPEFDDKLC NHOEFDDAAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x1D7A660", Offset = "0x1D78E60", VA = "0x181D7A660", Slot = "8")]
		get
		{
			return default(CPDPEFDDKLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x834E5E0", Offset = "0x834CDE0", VA = "0x18834E5E0")]
	public BMFBAKJPHAB([Optional] string AMNODOIMNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x834E560", Offset = "0x834CD60", VA = "0x18834E560")]
	private void PDDPGHKFEOM(OCGCHDNKCFE FGGEEODNNKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x834DAC0", Offset = "0x834C2C0", VA = "0x18834DAC0", Slot = "9")]
	internal override void HIODBFNBMEB(Stream BBDMMNBMNGO, long MDLDCACFGIB, long ODGNDMLNOIH, MKHFNGCIHMI EAIJCJBEHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x834DE70", Offset = "0x834C670", VA = "0x18834DE70", Slot = "10")]
	internal override bool LKFMCBLFJIO(Stream GFEEMJMJJJF, long MDLDCACFGIB, long ODGNDMLNOIH, KFFEHEOGAFL NJMNNMKPECE, [Out] MKHFNGCIHMI EAIJCJBEHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x834D9D0", Offset = "0x834C1D0", VA = "0x18834D9D0", Slot = "11")]
	protected override FileInfo GKMDNGAFJOB(long MDLDCACFGIB, long ODGNDMLNOIH, OCGCHDNKCFE FGGEEODNNKF, OBFGPIKBECH LHFCJFNBAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x834DD70", Offset = "0x834C570", VA = "0x18834DD70", Slot = "12")]
	protected override DirectoryInfo LADPGADGCOI(OCGCHDNKCFE FGGEEODNNKF, OBFGPIKBECH LHFCJFNBAPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
internal sealed class BMCGMJLPNGB : PBLOBJBMFIH
{
	[Cpp2IlInjected.Token(Token = "0x40007EF")]
	private static readonly byte[] BELIEAFHDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007F0")]
	private readonly byte[] MKLJKDDENIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007F1")]
	private readonly byte[] DPDDEDMDFCI;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public override CPDPEFDDKLC NHOEFDDAAPD
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x6E2E7D0", Offset = "0x6E2CFD0", VA = "0x186E2E7D0", Slot = "8")]
		get
		{
			return default(CPDPEFDDKLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x834D8E0", Offset = "0x834C0E0", VA = "0x18834D8E0")]
	public BMCGMJLPNGB([Optional] string AMNODOIMNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x834C8C0", Offset = "0x834B0C0", VA = "0x18834C8C0", Slot = "9")]
	internal override void HIODBFNBMEB(Stream BBDMMNBMNGO, long MDLDCACFGIB, long ODGNDMLNOIH, MKHFNGCIHMI EAIJCJBEHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x834CDE0", Offset = "0x834B5E0", VA = "0x18834CDE0", Slot = "10")]
	internal override bool LKFMCBLFJIO(Stream GFEEMJMJJJF, long MDLDCACFGIB, long ODGNDMLNOIH, KFFEHEOGAFL NJMNNMKPECE, [Out] MKHFNGCIHMI EAIJCJBEHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x834C6D0", Offset = "0x834AED0", VA = "0x18834C6D0")]
	private void FAJKOBLAPOE(byte[] FLMLKMBDILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x834C790", Offset = "0x834AF90", VA = "0x18834C790", Slot = "11")]
	protected override FileInfo GKMDNGAFJOB(long MDLDCACFGIB, long ODGNDMLNOIH, OCGCHDNKCFE FGGEEODNNKF, OBFGPIKBECH LHFCJFNBAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x834CCD0", Offset = "0x834B4D0", VA = "0x18834CCD0", Slot = "12")]
	protected override DirectoryInfo LADPGADGCOI(OCGCHDNKCFE FGGEEODNNKF, OBFGPIKBECH LHFCJFNBAPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
public enum CPDPEFDDKLC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40007F5")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40007F6")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40007F7")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
internal class HELBKCJGGFI : NOCOEGOIBBK
{
	[Cpp2IlInjected.Token(Token = "0x20001CD")]
	[CompilerGenerated]
	private sealed class JMGHGDPJADK : IEnumerable<GANHOFFPCAM>, IEnumerable, IEnumerator<GANHOFFPCAM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		private GANHOFFPCAM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		public HELBKCJGGFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		private OCGCHDNKCFE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000803")]
		public OCGCHDNKCFE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		private CPDPEFDDKLC[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		private IEnumerator<GANHOFFPCAM> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		private GANHOFFPCAM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0xE73320", Offset = "0xE71B20", VA = "0x180E73320")]
		[DebuggerHidden]
		public JMGHGDPJADK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x83570B0", Offset = "0x83558B0", VA = "0x1883570B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x8356CD0", Offset = "0x83554D0", VA = "0x188356CD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x8356C80", Offset = "0x8355480", VA = "0x188356C80")]
		private void JCGGFCDKBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x8357060", Offset = "0x8355860", VA = "0x188357060", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x8356FB0", Offset = "0x83557B0", VA = "0x188356FB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GANHOFFPCAM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x8356FB0", Offset = "0x83557B0", VA = "0x188356FB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F8")]
	private readonly CPDPEFDDKLC[] DPNDFNMJIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007F9")]
	private readonly Dictionary<CPDPEFDDKLC, NOCOEGOIBBK> KPKEIKFGHDA;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public CPDPEFDDKLC NHOEFDDAAPD
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x8352040", Offset = "0x8350840", VA = "0x188352040", Slot = "4")]
		get
		{
			return default(CPDPEFDDKLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x83525F0", Offset = "0x8350DF0", VA = "0x1883525F0")]
	[UnityEngine.Scripting.Preserve]
	public HELBKCJGGFI(params NOCOEGOIBBK[] MMMFJFPMKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x83521D0", Offset = "0x83509D0", VA = "0x1883521D0", Slot = "5")]
	public bool JJEIJHDNKLC(long MDLDCACFGIB, long ODGNDMLNOIH, OCGCHDNKCFE FGGEEODNNKF, [Out] GANHOFFPCAM NPNJHLNLNMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x8352320", Offset = "0x8350B20", VA = "0x188352320")]
	private void KCIGMDGMICL(int IGNAFHMEMDI, long MDLDCACFGIB, long ODGNDMLNOIH, OCGCHDNKCFE FGGEEODNNKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x8352560", Offset = "0x8350D60", VA = "0x188352560", Slot = "6")]
	[IteratorStateMachine(typeof(JMGHGDPJADK))]
	public IEnumerable<GANHOFFPCAM> LJDLINPPOPI(OCGCHDNKCFE FGGEEODNNKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x8352070", Offset = "0x8350870", VA = "0x188352070", Slot = "7")]
	public GANHOFFPCAM HAGKPIELFKJ(long MDLDCACFGIB, long ODGNDMLNOIH, MKHFNGCIHMI EAIJCJBEHLN, OCGCHDNKCFE FGGEEODNNKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
internal static class NDJNPEMNKEC
{
	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x8358B10", Offset = "0x8357310", VA = "0x188358B10")]
	internal static byte[] LKDJBGHPPDL(byte[] FLMLKMBDILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x83588B0", Offset = "0x83570B0", VA = "0x1883588B0")]
	public static void AIPLHCNHOPP(Stream PIAGKKGLFMH, byte[] BDDICIPJPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x8358930", Offset = "0x8357130", VA = "0x188358930")]
	public static bool KDDGNCIIOON(Stream PIAGKKGLFMH, long IHPPAOEOOJB, KFFEHEOGAFL DKJDGCJJGBO, [Out] byte[] ILFHPMKOFPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
internal sealed class ACJGKIKCHCI : GANHOFFPCAM, IEquatable<GANHOFFPCAM>, IEquatable<ACJGKIKCHCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000807")]
	private readonly PBLOBJBMFIH NEICINCKNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000808")]
	public readonly FileInfo DLCFGPFLHOA;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public CPDPEFDDKLC NHOEFDDAAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A010", Offset = "0x7C38810", VA = "0x187C3A010", Slot = "9")]
		get
		{
			return default(CPDPEFDDKLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public DateTime FHPAMAHHDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x834B5D0", Offset = "0x8349DD0", VA = "0x18834B5D0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x834BA00", Offset = "0x834A200", VA = "0x18834BA00")]
	public ACJGKIKCHCI(PBLOBJBMFIH CHBCCNAADGN, FileInfo JOBEJPMDODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x834B950", Offset = "0x834A150", VA = "0x18834B950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x834B510", Offset = "0x8349D10", VA = "0x18834B510", Slot = "5")]
	public void AKJILBFBEIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x834B910", Offset = "0x834A110", VA = "0x18834B910", Slot = "6")]
	public bool NLCCKOEPODO(long MDLDCACFGIB, long ODGNDMLNOIH, [Out] MKHFNGCIHMI EAIJCJBEHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x834B660", Offset = "0x8349E60", VA = "0x18834B660", Slot = "7")]
	public bool Equals(GANHOFFPCAM PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x834B6D0", Offset = "0x8349ED0", VA = "0x18834B6D0", Slot = "8")]
	public bool Equals(ACJGKIKCHCI PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x834B790", Offset = "0x8349F90", VA = "0x18834B790", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x834B880", Offset = "0x834A080", VA = "0x18834B880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
public delegate void KFFEHEOGAFL(BLLOLGEPOJA.BFEJCGDEKOO OOLBHBGHCME, string NJAAPDELBNN);
[Cpp2IlInjected.Token(Token = "0x20001D1")]
internal interface NOCOEGOIBBK
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	CPDPEFDDKLC NHOEFDDAAPD
	{
		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JJEIJHDNKLC(long MDLDCACFGIB, long ODGNDMLNOIH, OCGCHDNKCFE FGGEEODNNKF, [Out] GANHOFFPCAM NPNJHLNLNMP);

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<GANHOFFPCAM> LJDLINPPOPI(OCGCHDNKCFE FGGEEODNNKF);

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GANHOFFPCAM HAGKPIELFKJ(long MDLDCACFGIB, long ODGNDMLNOIH, MKHFNGCIHMI EAIJCJBEHLN, OCGCHDNKCFE FGGEEODNNKF);
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
