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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B8E460", Offset = "0x8B8CE60", VA = "0x188B8E460")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class AAHPIJDFAJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal Task<NGBABHAHMPG> BBMDGOECBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal Task AIJHOKMNBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal BJKINLKLGHG DLPEIKJCABC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public AAHPIJDFAJG()
	{
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B8CAF0", Offset = "0x8B8B4F0", VA = "0x188B8CAF0", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B93450", Offset = "0x8B91E50", VA = "0x188B93450", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DPFLBNKBOGF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8B78EE0", Offset = "0x8B778E0", VA = "0x188B78EE0")]
	public DPFLBNKBOGF(string ONGDPODJNBL, Exception GNHHAMPPHJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal class KGEIAHEJIDF : IEMOCGCCCIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct ONPOKEOIFGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<IReadOnlyList<APAPHONKBGM>> <>t__builder;

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
		private TaskAwaiter<LLDGKPCMPJL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8B90940", Offset = "0x8B8F340", VA = "0x188B90940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8B90B80", Offset = "0x8B8F580", VA = "0x188B90B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct OOHKONKJGLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<FPNJKEDCGAO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<List<FPNJKEDCGAO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8B90BF0", Offset = "0x8B8F5F0", VA = "0x188B90BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8B90E00", Offset = "0x8B8F800", VA = "0x188B90E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	[UnityEngine.Scripting.Preserve]
	public KGEIAHEJIDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8B8B8C0", Offset = "0x8B8A2C0", VA = "0x188B8B8C0", Slot = "4")]
	[AsyncStateMachine(typeof(ONPOKEOIFGG))]
	public Task<IReadOnlyList<APAPHONKBGM>> NPEDGPCBJCN(long DKMPIOFKFMN, long JCFCCOKDCNL, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8B8B7B0", Offset = "0x8B8A1B0", VA = "0x188B8B7B0", Slot = "5")]
	[AsyncStateMachine(typeof(OOHKONKJGLK))]
	public Task<IReadOnlyList<FPNJKEDCGAO>> GEIJDPFLAPF(IReadOnlyList<int> BNGCOGOKHNL, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LGEIALNOOPP : IEquatable<LGEIALNOOPP>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int BMCCGMDFKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	FPNJKEDCGAO ANBANCFHPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime HPLPABIGOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NPJJEBGBNDK? EHEHIOIPJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OLNPCLKFKJH? ADKNJJGDNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	MHGNGPGIAJE GKPEABIDKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<FNEGFJHAODE> DEJOLFKEKMF();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum MHGNGPGIAJE
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IEMOCGCCCIA
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<APAPHONKBGM>> NPEDGPCBJCN(long DKMPIOFKFMN, long JCFCCOKDCNL, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<FPNJKEDCGAO>> GEIJDPFLAPF(IReadOnlyList<int> BNGCOGOKHNL, [Optional] CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MOFJKMDCKLO
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class BGDOGGGMKLN : LGEIALNOOPP, IEquatable<LGEIALNOOPP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct PENEALFHEGK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncTaskMethodBuilder<FNEGFJHAODE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public BGDOGGGMKLN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private PGOMLIKIJEK <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private TaskAwaiter<DJEKJMDOAHO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private TaskAwaiter<FNEGFJHAODE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8B91E80", Offset = "0x8B90880", VA = "0x188B91E80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8B92410", Offset = "0x8B90E10", VA = "0x188B92410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly APAPHONKBGM ICBJIECKAKL;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int BMCCGMDFKJH
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FPNJKEDCGAO ANBANCFHPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime FLFCHJCNEFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8B75440", Offset = "0x8B73E40", VA = "0x188B75440", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NPJJEBGBNDK? EHEHIOIPJMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2D04D30", Offset = "0x2D03730", VA = "0x182D04D30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public OLNPCLKFKJH? ADKNJJGDNLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8B75460", Offset = "0x8B73E60", VA = "0x188B75460", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MHGNGPGIAJE GKPEABIDKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xC325B0", Offset = "0xC30FB0", VA = "0x180C325B0", Slot = "10")]
			get
			{
				return default(MHGNGPGIAJE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8B75150", Offset = "0x8B73B50", VA = "0x188B75150", Slot = "9")]
		[AsyncStateMachine(typeof(PENEALFHEGK))]
		public Task<FNEGFJHAODE> DEJOLFKEKMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8B75480", Offset = "0x8B73E80", VA = "0x188B75480")]
		public BGDOGGGMKLN(int OPIJJHGPJPL, FPNJKEDCGAO GCPLOGIILGI, APAPHONKBGM ICBJIECKAKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B75250", Offset = "0x8B73C50", VA = "0x188B75250", Slot = "11")]
		public bool Equals(LGEIALNOOPP EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8B752E0", Offset = "0x8B73CE0", VA = "0x188B752E0", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8B75380", Offset = "0x8B73D80", VA = "0x188B75380")]
		private bool FPGCGMKMKFA(BGDOGGGMKLN EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8B753C0", Offset = "0x8B73DC0", VA = "0x188B753C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class FDFCKCALHDI : LGEIALNOOPP, IEquatable<LGEIALNOOPP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct NOHJLPACCCM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public AsyncTaskMethodBuilder<FNEGFJHAODE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public FDFCKCALHDI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<FNEGFJHAODE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8B8E1A0", Offset = "0x8B8CBA0", VA = "0x188B8E1A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8B8E3F0", Offset = "0x8B8CDF0", VA = "0x188B8E3F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly JBJNNHCHIGL EAFCPNGGBLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NPJJEBGBNDK NGHHELCILLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly OLNPCLKFKJH CEEDDOJOBLF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int BMCCGMDFKJH
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8B7E930", Offset = "0x8B7D330", VA = "0x188B7E930", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FPNJKEDCGAO ANBANCFHPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8B7E620", Offset = "0x8B7D020", VA = "0x188B7E620", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime FLFCHJCNEFF
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8B7E970", Offset = "0x8B7D370", VA = "0x188B7E970", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NPJJEBGBNDK? EHEHIOIPJMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8B7E860", Offset = "0x8B7D260", VA = "0x188B7E860", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public OLNPCLKFKJH? ADKNJJGDNLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8B7E9C0", Offset = "0x8B7D3C0", VA = "0x188B7E9C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public MHGNGPGIAJE GKPEABIDKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xD0FF90", Offset = "0xD0E990", VA = "0x180D0FF90", Slot = "10")]
			get
			{
				return default(MHGNGPGIAJE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x21205B0", Offset = "0x211EFB0", VA = "0x1821205B0")]
		public FDFCKCALHDI(JBJNNHCHIGL CMMNIMNPMPI, NPJJEBGBNDK BJFIKOPEODN, OLNPCLKFKJH IOOJNINKLCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E530", Offset = "0x8B7CF30", VA = "0x188B7E530", Slot = "9")]
		[AsyncStateMachine(typeof(NOHJLPACCCM))]
		public Task<FNEGFJHAODE> DEJOLFKEKMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E760", Offset = "0x8B7D160", VA = "0x188B7E760", Slot = "11")]
		public bool Equals(LGEIALNOOPP EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E6B0", Offset = "0x8B7D0B0", VA = "0x188B7E6B0", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E800", Offset = "0x8B7D200", VA = "0x188B7E800")]
		private bool FPGCGMKMKFA(FDFCKCALHDI EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E8B0", Offset = "0x8B7D2B0", VA = "0x188B7E8B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private sealed class CICNIMPMADH : LGEIALNOOPP, IEquatable<LGEIALNOOPP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct NOGCDJNEMLB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder<FNEGFJHAODE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<FNEGFJHAODE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8B8DED0", Offset = "0x8B8C8D0", VA = "0x188B8DED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8B8E130", Offset = "0x8B8CB30", VA = "0x188B8E130", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly FPNJKEDCGAO HOFFCLEJKBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly NPJJEBGBNDK NGHHELCILLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly OLNPCLKFKJH CEEDDOJOBLF;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int BMCCGMDFKJH
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8B77890", Offset = "0x8B76290", VA = "0x188B77890", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public FPNJKEDCGAO ANBANCFHPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime FLFCHJCNEFF
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public NPJJEBGBNDK? EHEHIOIPJMO
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8B777B0", Offset = "0x8B761B0", VA = "0x188B777B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public OLNPCLKFKJH? ADKNJJGDNLB
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8B778B0", Offset = "0x8B762B0", VA = "0x188B778B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public MHGNGPGIAJE GKPEABIDKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "10")]
			get
			{
				return default(MHGNGPGIAJE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x21205B0", Offset = "0x211EFB0", VA = "0x1821205B0")]
		public CICNIMPMADH(FPNJKEDCGAO GCPLOGIILGI, NPJJEBGBNDK BJFIKOPEODN, OLNPCLKFKJH IOOJNINKLCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8B77510", Offset = "0x8B75F10", VA = "0x188B77510", Slot = "9")]
		[AsyncStateMachine(typeof(NOGCDJNEMLB))]
		public Task<FNEGFJHAODE> DEJOLFKEKMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8B77660", Offset = "0x8B76060", VA = "0x188B77660", Slot = "11")]
		public bool Equals(LGEIALNOOPP EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8B775E0", Offset = "0x8B75FE0", VA = "0x188B775E0", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B77800", Offset = "0x8B76200", VA = "0x188B77800", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8B776D0", Offset = "0x8B760D0", VA = "0x188B776D0")]
		private bool FPGCGMKMKFA(CICNIMPMADH EFNHKCDKOGH)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct JBLLHJOHBKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<IList<LGEIALNOOPP>> <>t__builder;

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
		public MOFJKMDCKLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IReadOnlyList<APAPHONKBGM> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<IReadOnlyList<APAPHONKBGM>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<(int accountId, FPNJKEDCGAO account, APAPHONKBGM roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8B89430", Offset = "0x8B87E30", VA = "0x188B89430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8B8A270", Offset = "0x8B88C70", VA = "0x188B8A270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct NKLIGDMCLDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, FPNJKEDCGAO account, APAPHONKBGM roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IReadOnlyList<APAPHONKBGM> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public MOFJKMDCKLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<IReadOnlyList<FPNJKEDCGAO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8B8D460", Offset = "0x8B8BE60", VA = "0x188B8D460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8B8DE60", Offset = "0x8B8C860", VA = "0x188B8DE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CIJOJACAEON INDBFADNKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly IEMOCGCCCIA PHPKBILKHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HKBKALLJCLJ CANBGCNFAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly JNGKBOCCLBG<(long, long), IReadOnlyList<APAPHONKBGM>> ONDMGMMBLGB;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8B8D330", Offset = "0x8B8BD30", VA = "0x188B8D330")]
	[UnityEngine.Scripting.Preserve]
	public MOFJKMDCKLO([LNLOHEINMEO(null)] IEMOCGCCCIA GJDKLNDALFE, [LNLOHEINMEO(null)] HKBKALLJCLJ OGELKGCGKOB, [LNLOHEINMEO(null)] CIJOJACAEON HPPAJIEKLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8B8D1E0", Offset = "0x8B8BBE0", VA = "0x188B8D1E0")]
	[AsyncStateMachine(typeof(JBLLHJOHBKB))]
	public Task<IList<LGEIALNOOPP>> PGIKAEPEEKB(long DKMPIOFKFMN, long JOIKPPGBGCF, bool CNCFCCDFOEL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8B8CF30", Offset = "0x8B8B930", VA = "0x188B8CF30")]
	private bool BBPLEGBAIPG(DateTime? HLFKAGPFBII, long DKMPIOFKFMN, long JOIKPPGBGCF, [Out] JBJNNHCHIGL CBJDOBLNCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8B8D0D0", Offset = "0x8B8BAD0", VA = "0x188B8D0D0")]
	[AsyncStateMachine(typeof(NKLIGDMCLDP))]
	private Task<IReadOnlyList<(int, FPNJKEDCGAO, APAPHONKBGM)>> MELIHEIIJBI(IReadOnlyList<APAPHONKBGM> OOEHNBKMDFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HKBKALLJCLJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<JBJNNHCHIGL> JPEGNMHGHGK;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FPMCBJJLCFJ(long DKMPIOFKFMN, long JOIKPPGBGCF, HNFMIDJGFGN CDKAFKOFPNO, AHLLAMLIAPD MJAEFDLBIKK);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PNGNABEIPOP(long DKMPIOFKFMN, long JOIKPPGBGCF, [Out] JBJNNHCHIGL CBJDOBLNCEK);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KPLGPHPCMPE(long DKMPIOFKFMN, long JOIKPPGBGCF, AHLLAMLIAPD MJAEFDLBIKK, [Out] JBJNNHCHIGL CBJDOBLNCEK);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ABHMBIIFOEE(long DKMPIOFKFMN, long JOIKPPGBGCF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface ANENIIJDGIC : BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MGIAPHIFBNA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task DJBJKMODFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCILIMAAFLA(Task AIPCFMDLKCK, string CLCNDDBDJHI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface HKIBLJFJOCJ : BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FNEGFJHAODE> LEADEDGDNFA(JBJNNHCHIGL CBJDOBLNCEK);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GMEIJJDNCDC(CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface OMFLAHJDHFM : BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	MMKEEKNGMFG JGFKHHPBOGM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNDMEJFNMGN();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NODOENJKLOG();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface BKKMCONGPMO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICNIAFDKEKI(PKEIPCLCGCJ MBIPODKGFBO);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal interface KFCIEIAMDDJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan MMDMBNHBBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan EOFOBAEELIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan LJGOALPFHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan NFJPMDOPGGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool JHFGIPLNEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool PGLMBPNFNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool JOJGHLPLGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int BIIKDLFBKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool GADDBHMMMNG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool KAKFBEHKBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool FLAFGGNLNME
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum DJJGPDHMHPL
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum DJILFCNIHBH
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
public struct CBIENAKDHBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly long OHGFCKGKFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly long JCFCCOKDCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly DJJGPDHMHPL AEOGKDPPBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[CanBeNull]
	public readonly Exception HMHLMDGFGGO;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8B76A30", Offset = "0x8B75430", VA = "0x188B76A30")]
	public CBIENAKDHBL(long OHGFCKGKFMF, long JCFCCOKDCNL, DJJGPDHMHPL AEOGKDPPBBE, [CanBeNull] Exception HMHLMDGFGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8B769E0", Offset = "0x8B753E0", VA = "0x188B769E0")]
	public static CBIENAKDHBL DIKKIOCKMLC(FIICLMFOJBM DEDDOFHDJHH, DJJGPDHMHPL AEOGKDPPBBE, [Optional] Exception HMHLMDGFGGO)
	{
		return default(CBIENAKDHBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void ACMJJALOMHI(CBIENAKDHBL JCKBCDHGAGN);
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface INIGPMILEMO : BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event ACMJJALOMHI OFOGMCPBDAP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event ACMJJALOMHI MFFLDIHGJLG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event ACMJJALOMHI NJLANFBBDHG;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<DJILFCNIHBH, bool> OBJDEPMMCFJ;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CHFALGOJNKN(CBIENAKDHBL JCKBCDHGAGN);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PIJPKIKLKKN(CBIENAKDHBL JCKBCDHGAGN);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LLNIJALEFDP(CBIENAKDHBL JCKBCDHGAGN);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ANMKJIANFLN(DJILFCNIHBH NLGPIOCMJCE, bool CEHCEBOGFEO);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface KDKLGIKJMEP : BKKMCONGPMO, IDisposable, IOOJPFDBJMM
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool GLFCBMGCLCM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BLIIBPIOLKP();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface MMANGHPIIGN : BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus KFJEHFLOIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OPPKANKLKAE(FIICLMFOJBM CEAKNHDJEBC, DNBIMKJJAHK IGNOKKAHPGK, CancellationToken BOJKDJLCGKE);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class HPPHGICIJAP
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8B86780", Offset = "0x8B85180", VA = "0x188B86780")]
	public static bool AGIHGKINFNL(this MMANGHPIIGN NDNAMJBDEFM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task EECLCBBHACO(CancellationToken DHNMCOFINFM, int AOOBCKPMEFJ, HDAMBOGOJKO LEAPPPBNNDJ);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface EAAHCCJEPDK : BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HKHEJMNGCLI(EECLCBBHACO FMFINDAMJGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface PKEIPCLCGCJ : PGOMLIKIJEK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken EGOJGLLJBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	CFAMNNNCHJA EEJNMHAHMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	JEJOFHIOJBA ODCAIOEMKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	APKPGOLLIMG LBNOGEHEDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	KGCDOOPNJBJ NJNPDNFAPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	LLCOCPCCELB BJOKDEICJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	APNHHKNLLEN MKOPENIAPLA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NEAJMIIPJPB BNKLGAAFAIN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	CBEFKDIMHCC OKKPCGADLFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	ANENIIJDGIC MALOBBDPGPF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	HKIBLJFJOCJ BDKGAHJGBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	INIGPMILEMO LIFOGMBKHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	KDKLGIKJMEP CHFENINNHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	MMANGHPIIGN EAIAGFLAEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	EAAHCCJEPDK LFLHJAEJEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	MAKAPNCIGKM CONPFAPCLPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	MKCIIMLKNMM LEKHFOPEPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ANCFFIABIGG PFMBFLLFPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	GJGLFGOIALL NBEBIENMOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	EHCGFOOAAPC LJOAPCBJBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	JPHLDOGIHOB MJNEDPDFJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	KBNDONDPNJA JFDGFKKFPMF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	LFABHNPPLMB GPDIHKEJBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	EHFLLDDKOID PBBBJMCDOAN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	MAHBABFIPHH HOJDJAJMLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	OMFLAHJDHFM DOLJMJIOICH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	KFCIEIAMDDJ MHEGDPPAPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	FIADEAFPLEB FLECOPBKPIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	HKBKALLJCLJ EEOBKFDDMPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	BKJBKHJKMHD GDHABHLENCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	CGNFEIFNNMC JPLKMBCDGOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	IALEJHMEBGG EDABFNFJOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	AOHKHOJNHBD OEJPBJMKEFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool KBIBIKCNDDM
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
	void BFDMJJPGEFD(DNBIMKJJAHK IFNBGFINEGG);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface MAKAPNCIGKM : BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CMGEJIHEHPB MJGPLOFFIKO(Guid BJGNCPGGOCA);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BBOPECIHIDA(Guid BJGNCPGGOCA);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PMNNHINGIAB(Guid BJGNCPGGOCA, Task KACLMHEHNDA);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CMKAIGHNBLH(Guid BJGNCPGGOCA, FNEGFJHAODE OCFJPMHLGMH);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(FNEGFJHAODE, Task)> JPDMCFGGECP(Guid BJGNCPGGOCA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface GDKAMGGNKMO : BKKMCONGPMO, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface MKCIIMLKNMM : BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNHOECDIBDP(FPMLGPKCMLB ONGDPODJNBL);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDCGNDIICKI(FPMLGPKCMLB ONGDPODJNBL);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<FPJCCCPHHPB> MAIKOEGPLPK(CancellationToken HFHCCJBEPKM);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface ANCFFIABIGG : BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CMGEJIHEHPB JPCNMHMGLNI(FPMLGPKCMLB GGCLMLLGCNJ);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDBDIHDCDNO(Guid BJGNCPGGOCA, Task KACLMHEHNDA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface GJGLFGOIALL : BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FNEGFJHAODE> NBEBIENMOHE(FPMLGPKCMLB LOLEDACMADE);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface EHCGFOOAAPC : BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MLFBJBKAEMO> GFKBHICOJOG(OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, FIICLMFOJBM CEAKNHDJEBC, CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface KBNDONDPNJA : BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FNEGFJHAODE NHBIDKDBOEL(POIAKMBAMML HBBJNPLOCFM);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IOAMMHBFDFO(string HODLOHIDPMG);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface JPHLDOGIHOB : BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FPMLGPKCMLB> EAIJFAFNLNB(FPMLGPKCMLB NIBLEOGJBJF, CDEDAAICECI AHLBPAOAMLM, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<FPMLGPKCMLB> AGNBGDEEDKL(CancellationToken OMJKEHOJJFF, CDEDAAICECI AHLBPAOAMLM);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OHBMAKCLEEN EIEENNHBKOB(MFDOGKHNMAA LOMLEJHBJDE, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OHBMAKCLEEN JECEFAKCGBI(MFDOGKHNMAA LOMLEJHBJDE, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface LFABHNPPLMB : BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FNEGFJHAODE BILBNDBAGMH(POIAKMBAMML HBBJNPLOCFM, FPJCCCPHHPB KGCMMEAFMPJ);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FNEGFJHAODE KFCLJEJDPEP(POIAKMBAMML PFEPHHMCGMM);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface OGJABJCHHGF
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	const int MLNEENGCAGH = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, MDJMAOPEMDH> AMMBPCELEKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action LKGANMDGIHM
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
	IReadOnlyList<Guid> NAEJMIEDHJE();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task CGPCGHFLDGG([Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task GPIBDPCLJEA([Optional] CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface EHFLLDDKOID
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLEEBHEIKMB(DBELILBDMNM BFKEGOHFOPL);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPIDPBFBAAH(DBELILBDMNM BFKEGOHFOPL);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOKJFOPHPKB(DBELILBDMNM BFKEGOHFOPL);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BNMOAGMPAFB(DBELILBDMNM BFKEGOHFOPL);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class DBELILBDMNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly FIICLMFOJBM FHFCENLHAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Dictionary<string, string> PEEJGIIDCCO;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public OGMJCPNEHOO<string> JGNCKMFAFJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public DBELILBDMNM(FIICLMFOJBM KEOPPNFKOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8B78E10", Offset = "0x8B77810", VA = "0x188B78E10")]
	public DBELILBDMNM HIJGKNLOPMI(string LNBCHJPEENA, string PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8B78D80", Offset = "0x8B77780", VA = "0x188B78D80")]
	public bool DLHPAMMEBPM([Out] IEnumerable<KeyValuePair<string, string>> JMNNHAJOCKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7A82010", Offset = "0x7A80A10", VA = "0x187A82010")]
	public DBELILBDMNM ACOIJLDNPCK(OGMJCPNEHOO<string> HIBNALIEBDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface FIADEAFPLEB
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool MOIODIPCOBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string KBAFFEFJPIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool FNLPKOKJOLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void COAALHNFDCK();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LGPDKDODGPL GONPOEKBHHC(long MNAMJIAHNIM);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KLFADJGMDLG<HCMJMHBJMFG, HEEMABDELIE> HOBALANMIJG(long MNAMJIAHNIM);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KLFADJGMDLG<HCMJMHBJMFG, AJDHPEOBCFP> NENBKMAHHCA(long MNAMJIAHNIM);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KLFADJGMDLG<long, OBGLFNADNNH> MICLIHIECCK();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<MMFCCBABPAO>> CHCEDGCGAIE(long MNAMJIAHNIM, IReadOnlyCollection<MMFCCBABPAO> FMKMDBHPEBN, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool APNFJFDJMAL(long MNAMJIAHNIM, [Out] bool GIJHINJCDAL);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> LHJJAGFOCPK(byte[] MFNLMEFHDNI, byte[] IDBNBOBAMJH, IReadOnlyCollection<Guid> DEOJLMJCNPF, CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface HGAFBENODKE
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLFBJBKAEMO OIDBKGGJJLH(long OHGFCKGKFMF, long JCFCCOKDCNL, string MIMKOOGLIBI);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MLFBJBKAEMO OIDBKGGJJLH(long OHGFCKGKFMF, long JCFCCOKDCNL, HCMJMHBJMFG MFNLMEFHDNI, Guid? CPCGBGNMNMH, long CIJFOCDDGDK, bool IEBAGPEOJFF);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MLFBJBKAEMO OIDBKGGJJLH(JCHGMBODNBK FIGADLNOJGA);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MLFBJBKAEMO OIDBKGGJJLH(DJEKJMDOAHO BLHLPKKGNMH, APAPHONKBGM EJHGOFLGBLP);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface PGOMLIKIJEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool AGIHGKINFNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool LDNLJCBOPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool KBIBIKCNDDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	HGAFBENODKE LJIKIIACEPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	DNBIMKJJAHK MIHBPPMEDCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event ACMJJALOMHI OFOGMCPBDAP;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event ACMJJALOMHI MFFLDIHGJLG;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event ACMJJALOMHI NJLANFBBDHG;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<DJILFCNIHBH, bool> OBJDEPMMCFJ;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BLIIBPIOLKP();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CIBFDAJCAMN CCCCGAPEGCD();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CFNOBLNFNJK FPLOEACLKOH();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task PBJEJANMLME(int BIJMEFDNJBK, BBLKGPIDOCC FEBMKDPBPHE, Func<HNFMIDJGFGN, HNFMIDJGFGN> HEDBLNILIGI);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<FNEGFJHAODE> LEADEDGDNFA(JBJNNHCHIGL CMMNIMNPMPI);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task GMEIJJDNCDC(CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface LLCOCPCCELB
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool CEKMAFLPEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool NGBDCBNNGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? CMJHFMKFLCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPNFOGEOABO(Scene CFHMLNIGEEA);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task DHEIPHMBOPP(HKHBKGNJPNE CFMNKBEEPBC, IReadOnlyList<HKHBKGNJPNE> JFGKIIDFIHK, IReadOnlyList<HKHBKGNJPNE> OKDPJPHAIJJ, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CJILAPKBNOH(Guid IDCJGBECDDM, IReadOnlyList<Guid> DEOJLMJCNPF, LDHMONEBJMO CJMCLMIBDII, [Optional] object FDBEECFBEEC);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task MIHIOODCJAN(IReadOnlyList<Guid> PNEOAHIPEAL, CancellationToken PHEBLCCOJED);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CALKCIIEGGI MPFMJAOMEEI();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task DIPCLDNNOBF();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PAFCHODEFHG(GameObject EJLPJBJLNAK);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task EAPBBICMNGG();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface KGCDOOPNJBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	NIIBNLNBABL HLKOBEKBMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool PHBCBLECPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool MLICINANJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool KGEBMBMMPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool MFEJKABHNLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int MDMBEKNKOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool NFKMLGNELAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool CBKIMDIGMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int FOELHGDMABH
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int MAHPFDEGECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool BJILAHOAHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool EGBHMKAKFNC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool PHPJDJMMDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float IAMAEFEPFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<float> PNCLFEHGOCO;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CFAMNNNCHJA ONFPOHNAJEM(CFAMNNNCHJA PEBKMCJKHME);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POHJDAFNBMP(CFAMNNNCHJA JBOIKIICKBA);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LDKCHOFBGDB();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task NLMLLPKGLHL(OGMJCPNEHOO<string>.LOEEEDILNMC HKHMJNNOANC, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ODOJFJGJJIH(float LEHODIGOOEA);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JLACGOENGBO(string HJIKHCCLFIK);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<NNCIEOBEJLN> NMACNPAKFLA();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable CFDCCDKHPOH(object HCLPHJDKMCA, NNCIEOBEJLN LCJFNEJNIDM);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<AFKECIDEIKC> BGBBGDPINPG();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HEEMABDELIE BKOECHJCAID(IEnumerable<BHOPKDGDEFN> OEKCFEHGHBB);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GCIKGCCHCCM(int LKMAOFPCIGJ);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task FJLDCFPKCEB();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BELIIMMFIIE();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool ODGPDONBHMF();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task JJMFLKIMLNI(CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task KKFBPLPLMKI(CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<PLMMKCFKCLM> NGKMMINOLMA(DateTime KOCOGIPPEDJ, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> MNELKPNBIAE(CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PIKBCKKANOD(string ONGDPODJNBL = "", float KHJNAGFHPGB = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "25")]
	DHJPAILKIOA OPANPDPJPKC(OCOGPPDAFJO KECGDFMGAMO, MIOKGJCEPIK PMPJINGFHBP, AJDHPEOBCFP LAJDMLONDKB, IEnumerable<PersistenceView> PGFPOHCBFOP, GALGMADDFIP ABBMHACAOIN);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CDJONLDEOPH(AJDHPEOBCFP LAJDMLONDKB);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LEMBACLALFE(BHOPKDGDEFN HGCHPOBFDBI, [In] DHJPAILKIOA HLJPNDHEBEG);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task LIKDIJKFBLA(AJDHPEOBCFP DNANDPJDLAG, bool HCGHAFBGIOJ, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task DHONNLCNHPG(CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IICONOMOGEC(long DKMPIOFKFMN, long JCFCCOKDCNL, DJEKJMDOAHO GADEDFJOCGJ, APAPHONKBGM BJFMIPMDECF, HNFMIDJGFGN CDKAFKOFPNO, BBLKGPIDOCC? FEBMKDPBPHE, GFFHLOLHICK? CKGAAIFJFHK);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void IDOOBHMMLNC(long DKMPIOFKFMN, long JCFCCOKDCNL, GFFHLOLHICK? CKGAAIFJFHK);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void BKMMFIPOELA(PersistenceView PPNOFKBPBEL);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void NMKJLHINEPM(string GKDGCMBKDJA, FIICLMFOJBM KEOPPNFKOEL, OIBIBNOAMEK OCLNGGKLFPE, [Optional] string? LCAGMCOFDEC, [Optional] string? MMNJFDOCKBF, [Optional] string? NFFKEGLOKCH);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool OHBAPODKIGH(PersistenceView EGPPKOBFLID);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool BCLJIJFIFBP(BHOPKDGDEFN HGCHPOBFDBI, BKLAHIHKKHK PGGHHODBCLO, [Out] BPEHFCJOHOP DADIMCHFKBB);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task AMLCEIEGOGJ(CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void IOMPCPJIJMB();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable KNKOKAGNMNN();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void MEIOODKBBLJ(AJDHPEOBCFP DNANDPJDLAG, BKLAHIHKKHK PGGHHODBCLO);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> OGIGCOKCANB(JEJOFHIOJBA HFINBJNJOEI, CancellationToken OMJKEHOJJFF, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void LMIEOJGPLKP(CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<JCHGMBODNBK> NFOCMHHHGME(NAGLFBHPGKM NIBLEOGJBJF);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<DJEKJMDOAHO> LMALAPFLJCD(long DKMPIOFKFMN, bool GMGOFGCONBE, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<BBOGCAENLMO> DPCLNLMKLLJ(long DKMPIOFKFMN, long JCFCCOKDCNL, long CIJFOCDDGDK, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<APAPHONKBGM> BHKHPMCGHJN(long DKMPIOFKFMN, long JCFCCOKDCNL, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<MGLMPLLOJJF> OHHNNLHNHLB(long DKMPIOFKFMN, Guid HINODLHOFHH, long? JOIKPPGBGCF, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "47")]
	KLFADJGMDLG<MGLMPLLOJJF, IEnumerable<JANJDGIBAEN>> PHJPOKJHPMH();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<DLAPJAGBOIF> DHHFJHFEAMA(string MIMKOOGLIBI, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<DLAPJAGBOIF> EPKNMFOHPEO(string MIMKOOGLIBI, long DKMPIOFKFMN, long JCFCCOKDCNL, Guid? IDCJGBECDDM, AMIAOJBFLFI.LBKJHLAMGGL OBPEHAFILEK, AMIAOJBFLFI.LBKJHLAMGGL IDBNBOBAMJH, int BIJMEFDNJBK);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool OMOBNNIPDKN();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool GELCEIAHHKC();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool NPCCNNNEIMP(IEnumerable<BPEHFCJOHOP> MJPJCDDCBCJ);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void CEDELNPEEBM(List<GameObject> CJGJNLNEMHI);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float OBHOBDKBMBB();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> KCPADOPNJLK(CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> DHKNGMBBCFH(string MPIBHFEHILP, LoadSceneMode AGHLHNDENPM, bool NAFEFMDLLJM, OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void ODDEIDFPBAL(bool DKBBOMHPGKC);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void INOHOPOPAAJ();

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void HHLENIPDDAI();

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void PEDPHKJPPIC(bool BGFBHMLPHGP);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task<AMIAOJBFLFI.LBKJHLAMGGL> ILCLBHNOBKE(byte[] GPCDCFCPGFK, AMIAOJBFLFI.DMFBMKGGBOE KOJOHEMFFLA, FBPNHGHBDHC EKLKIKNENMK, [Optional] IReadOnlyCollection<string>? AJEBGDGLMHD, [Optional] string? ENAPMKMDGBG);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void HDLAGNFFDGM(FIICLMFOJBM BHNMENBIBOK);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task PHANGJJMFDO(OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task EFOHAOJEMJM(OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task MBKICOFFNNL(OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task KFCNKBDBGBI(OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "77")]
	IDisposable KGPJIPNKFPD();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "78")]
	MOGNBOBBCBH FLDDENFIEFE();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "79")]
	Task BENOOIGGKOJ(CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface MOGNBOBBCBH
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DAABONJIGOJ(CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CHIBBKFMAGA(CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct DHJPAILKIOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public HashSet<int> BFPFEEHNJAO;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum PLMMKCFKCLM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct OCOGPPDAFJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Guid? IAGHKHMHFCC;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface NIIBNLNBABL
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	FIICLMFOJBM LFCCMFGBFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	DJEKJMDOAHO FIANMCBEBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	DBNKIMCJKJK ADOBAPJEABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool MAJFMLEMMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool JMLLJJPADMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int JIPCHKJONGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action HMCDIPPNOHI;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<int> LPCHOENMAIP;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BFEPOPAANKL();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.CGGLCKAFDCM> BFBLEABHNDC(long MNAMJIAHNIM, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<GHAPMHDAMDF> BAECIKHBIFJ(FIICLMFOJBM KEOPPNFKOEL, [Optional] DNBIMKJJAHK IGNOKKAHPGK);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<GHAPMHDAMDF> MLNGPGILLJE();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task KEHPBHPHABI();

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(FIICLMFOJBM, DNBIMKJJAHK) GLMMFANGNKB();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	DKMBMPCHLAM NPGPKFAGHCP();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LMIANHHIKLD(long MNAMJIAHNIM);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NGDJFNDKEBA(FIICLMFOJBM KEOPPNFKOEL, Matchmaking.DNODANILOPE AEAMJGPOBKI, (int Major, int? Minor)? EKKNDADGPGC);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface MAHBABFIPHH
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LCCJOEBJACD([Out] IEnumerable<int> PNECEDJMHLG);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBODDLDDKAJ(NJLNMLEFFEL DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MDOEGMHPMBL(NJLNMLEFFEL DHNMCOFINFM);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface PLAADJPJJJB
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KELFOPANBDJ(FNEGFJHAODE EDLDCHCPHPF);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface HEEEMJHMOLP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JALPOKCBCOG(DLOCIFOCMNN.NIEGFFOGPJA MBCJDMNELNK);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DPGCJIFJBFH(DLOCIFOCMNN.NIEGFFOGPJA MBCJDMNELNK);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface APNHHKNLLEN : HEEEMJHMOLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FNEGFJHAODE DNLAPNEGABM(POIAKMBAMML PFEPHHMCGMM);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface NEAJMIIPJPB : HEEEMJHMOLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FNEGFJHAODE NHBIDKDBOEL(POIAKMBAMML PIAAPOBLMOF);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface LGPDKDODGPL
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DOHEMIFBILP<NIFOPHOIBJN, OGOHDADDIPM>> KBKBFMCDOHB(Guid? IDCJGBECDDM, IReadOnlyCollection<MMFCCBABPAO> PIMOKNPHILO, IReadOnlyCollection<MMFCCBABPAO> KFJJDJLBCCL, PCPIEKJCMFL AHABFDNECCL, long? DKMPIOFKFMN, long? JCFCCOKDCNL, NPHFKKEFGIB.LLDFOILIDAI AJIKBCEGIDO, CancellationToken OMJKEHOJJFF, bool ILNEFANPNNN = false);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class NIFOPHOIBJN
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public HKHBKGNJPNE GKCMMNMMPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<HKHBKGNJPNE> ANNOCHOFNCO
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<HKHBKGNJPNE> HOGAINONBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xDB36D0", Offset = "0xDB20D0", VA = "0x180DB36D0")]
	public NIFOPHOIBJN(HKHBKGNJPNE CLDHKFLPEKE, IReadOnlyList<HKHBKGNJPNE> EAIHHBFKCJK, IReadOnlyList<HKHBKGNJPNE> LOJGJNMCNGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface KLFADJGMDLG<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DOHEMIFBILP<CDDDFCHIGNI<TData>, OGOHDADDIPM>> EAFPFAIOOLI(TGetDataArg GOMJJOOOEFM, CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class AHOONEOPCIM : PKEIPCLCGCJ, PGOMLIKIJEK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct PCOIJGPNANH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<FNEGFJHAODE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AHOONEOPCIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public JBJNNHCHIGL autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<FNEGFJHAODE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8B91B90", Offset = "0x8B90590", VA = "0x188B91B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B91E10", Offset = "0x8B90810", VA = "0x188B91E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct KHMIJBEKPFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AHOONEOPCIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B8B9E0", Offset = "0x8B8A3E0", VA = "0x188B8B9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B8BC10", Offset = "0x8B8A610", VA = "0x188B8BC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class IKPDFKBPFLM : IEnumerable<BKKMCONGPMO>, IEnumerable, IEnumerator<BKKMCONGPMO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private BKKMCONGPMO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AHOONEOPCIM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private BKKMCONGPMO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
		[DebuggerHidden]
		public IKPDFKBPFLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B87970", Offset = "0x8B86370", VA = "0x188B87970", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B87DD0", Offset = "0x8B867D0", VA = "0x188B87DD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B87D20", Offset = "0x8B86720", VA = "0x188B87D20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BKKMCONGPMO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B87D20", Offset = "0x8B86720", VA = "0x188B87D20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly CancellationTokenSource BLADCDBCAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly CFAMNNNCHJA JBOIKIICKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool JAFNIEKLOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private LEAHPBPJDPO LPPPAHJAOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private bool MMLKHHPKACM;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public JEJOFHIOJBA ODCAIOEMKBN
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA84220", Offset = "0xA82C20", VA = "0x180A84220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public APKPGOLLIMG LBNOGEHEDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA84200", Offset = "0xA82C00", VA = "0x180A84200", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA84190", Offset = "0xA82B90", VA = "0x180A84190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public KGCDOOPNJBJ NJNPDNFAPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA841E0", Offset = "0xA82BE0", VA = "0x180A841E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA841C0", Offset = "0xA82BC0", VA = "0x180A841C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public LLCOCPCCELB BJOKDEICJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA841B0", Offset = "0xA82BB0", VA = "0x180A841B0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA841A0", Offset = "0xA82BA0", VA = "0x180A841A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public APNHHKNLLEN MKOPENIAPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA841F0", Offset = "0xA82BF0", VA = "0x180A841F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA841D0", Offset = "0xA82BD0", VA = "0x180A841D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public NEAJMIIPJPB BNKLGAAFAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA90910", Offset = "0xA8F310", VA = "0x180A90910", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA909B0", Offset = "0xA8F3B0", VA = "0x180A909B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public HGAFBENODKE LJIKIIACEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA909E0", Offset = "0xA8F3E0", VA = "0x180A909E0", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA909C0", Offset = "0xA8F3C0", VA = "0x180A909C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public CBEFKDIMHCC OKKPCGADLFF
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA909D0", Offset = "0xA8F3D0", VA = "0x180A909D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA90970", Offset = "0xA8F370", VA = "0x180A90970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public ANENIIJDGIC MALOBBDPGPF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xAEDCD0", Offset = "0xAEC6D0", VA = "0x180AEDCD0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xAEB9B0", Offset = "0xAEA3B0", VA = "0x180AEB9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public HKIBLJFJOCJ BDKGAHJGBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA90900", Offset = "0xA8F300", VA = "0x180A90900", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA90890", Offset = "0xA8F290", VA = "0x180A90890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public INIGPMILEMO LIFOGMBKHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xAEE0F0", Offset = "0xAECAF0", VA = "0x180AEE0F0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xB40620", Offset = "0xB3F020", VA = "0x180B40620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public KDKLGIKJMEP CHFENINNHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA89DE0", Offset = "0xA887E0", VA = "0x180A89DE0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA89E50", Offset = "0xA88850", VA = "0x180A89E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public MMANGHPIIGN EAIAGFLAEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xB406B0", Offset = "0xB3F0B0", VA = "0x180B406B0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xB405B0", Offset = "0xB3EFB0", VA = "0x180B405B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public EAAHCCJEPDK LFLHJAEJEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xE93590", Offset = "0xE91F90", VA = "0x180E93590", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xE935A0", Offset = "0xE91FA0", VA = "0x180E935A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public MAKAPNCIGKM CONPFAPCLPF
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xB40610", Offset = "0xB3F010", VA = "0x180B40610", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xB68BC0", Offset = "0xB675C0", VA = "0x180B68BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public GDKAMGGNKMO CNIODLIFBGB
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xB40660", Offset = "0xB3F060", VA = "0x180B40660", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xB405D0", Offset = "0xB3EFD0", VA = "0x180B405D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public MKCIIMLKNMM LEKHFOPEPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xAFE330", Offset = "0xAFCD30", VA = "0x180AFE330", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xB013C0", Offset = "0xAFFDC0", VA = "0x180B013C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public ANCFFIABIGG PFMBFLLFPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA89E90", Offset = "0xA88890", VA = "0x180A89E90", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA89E10", Offset = "0xA88810", VA = "0x180A89E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public GJGLFGOIALL NBEBIENMOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xB02020", Offset = "0xB00A20", VA = "0x180B02020", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xB01370", Offset = "0xAFFD70", VA = "0x180B01370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public EHCGFOOAAPC LJOAPCBJBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xB02010", Offset = "0xB00A10", VA = "0x180B02010", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xB01630", Offset = "0xB00030", VA = "0x180B01630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public JPHLDOGIHOB MJNEDPDFJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xAFCCC0", Offset = "0xAFB6C0", VA = "0x180AFCCC0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xAFC800", Offset = "0xAFB200", VA = "0x180AFC800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public KBNDONDPNJA JFDGFKKFPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xB0A4B0", Offset = "0xB08EB0", VA = "0x180B0A4B0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xB06350", Offset = "0xB04D50", VA = "0x180B06350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public LFABHNPPLMB GPDIHKEJBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAFE220", Offset = "0xAFCC20", VA = "0x180AFE220", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xB03C10", Offset = "0xB02610", VA = "0x180B03C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public EHFLLDDKOID PBBBJMCDOAN
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xAFFF70", Offset = "0xAFE970", VA = "0x180AFFF70", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xAFEF90", Offset = "0xAFD990", VA = "0x180AFEF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public MAHBABFIPHH HOJDJAJMLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xAFFE20", Offset = "0xAFE820", VA = "0x180AFFE20", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAFEF70", Offset = "0xAFD970", VA = "0x180AFEF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public OMFLAHJDHFM DOLJMJIOICH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xAEF5D0", Offset = "0xAEDFD0", VA = "0x180AEF5D0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xB00280", Offset = "0xAFEC80", VA = "0x180B00280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public KFCIEIAMDDJ MHEGDPPAPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xBE9730", Offset = "0xBE8130", VA = "0x180BE9730", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xBEB2F0", Offset = "0xBE9CF0", VA = "0x180BEB2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public FIADEAFPLEB FLECOPBKPIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xB654E0", Offset = "0xB63EE0", VA = "0x180B654E0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xB60050", Offset = "0xB5EA50", VA = "0x180B60050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public HKBKALLJCLJ EEOBKFDDMPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xB65190", Offset = "0xB63B90", VA = "0x180B65190", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public BKJBKHJKMHD GDHABHLENCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xBEA150", Offset = "0xBE8B50", VA = "0x180BEA150", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CGNFEIFNNMC JPLKMBCDGOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xBE9A80", Offset = "0xBE8480", VA = "0x180BE9A80", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public IALEJHMEBGG EDABFNFJOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xBDB970", Offset = "0xBDA370", VA = "0x180BDB970", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public AOHKHOJNHBD OEJPBJMKEFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xBF8800", Offset = "0xBF7200", VA = "0x180BF8800", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public DNBIMKJJAHK MIHBPPMEDCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xBE24F0", Offset = "0xBE0EF0", VA = "0x180BE24F0", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xD6A1C0", Offset = "0xD68BC0", VA = "0x180D6A1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool LLCEPANHNEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B73EF0", Offset = "0x8B728F0", VA = "0x188B73EF0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool HFPIIIHNDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B73090", Offset = "0x8B71A90", VA = "0x188B73090", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool CKONJLPLJJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1EEB890", Offset = "0x1EEA290", VA = "0x181EEB890", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken NNBEAMGHBOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B731D0", Offset = "0x8B71BD0", VA = "0x188B731D0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private CFAMNNNCHJA MMACKLAJKBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool IMDNANCHMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1EEB890", Offset = "0x1EEA290", VA = "0x181EEB890", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1EE6350", Offset = "0x1EE4D50", VA = "0x181EE6350", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event ACMJJALOMHI FEADLMGNFBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B73420", Offset = "0x8B71E20", VA = "0x188B73420", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8B73AF0", Offset = "0x8B724F0", VA = "0x188B73AF0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event ACMJJALOMHI IKNLOGMCOAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B734E0", Offset = "0x8B71EE0", VA = "0x188B734E0", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8B738F0", Offset = "0x8B722F0", VA = "0x188B738F0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event ACMJJALOMHI IDAEACHFEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8B73170", Offset = "0x8B71B70", VA = "0x188B73170", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B73110", Offset = "0x8B71B10", VA = "0x188B73110", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event Action<DJILFCNIHBH, bool> HHHMPNBDJFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B73480", Offset = "0x8B71E80", VA = "0x188B73480", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B73A40", Offset = "0x8B72440", VA = "0x188B73A40", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xD6A1C0", Offset = "0xD68BC0", VA = "0x180D6A1C0", Slot = "39")]
	public void BFDMJJPGEFD(DNBIMKJJAHK IFNBGFINEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8B73F50", Offset = "0x8B72950", VA = "0x188B73F50")]
	[UnityEngine.Scripting.Preserve]
	internal AHOONEOPCIM([LNLOHEINMEO(null)] CFAMNNNCHJA JBOIKIICKBA, [LNLOHEINMEO(null)] JEJOFHIOJBA HFINBJNJOEI, [LNLOHEINMEO(null)] APKPGOLLIMG BOOHMEPFPPP, [LNLOHEINMEO(null)] KGCDOOPNJBJ JDNAAPNIDID, [LNLOHEINMEO(null)] LLCOCPCCELB EFCABBMPFNA, [LNLOHEINMEO(null)] APNHHKNLLEN HNBJIPBOPKE, [LNLOHEINMEO(null)] NEAJMIIPJPB PGGKFPINHMM, [LNLOHEINMEO(null)] CBEFKDIMHCC FAOBOCHEEEI, [LNLOHEINMEO(null)] ANENIIJDGIC IDHPJGGMFIE, [LNLOHEINMEO(null)] HKIBLJFJOCJ OECOKIPGIHF, [LNLOHEINMEO(null)] INIGPMILEMO LLMHINCMLEH, [LNLOHEINMEO(null)] KDKLGIKJMEP GCDCHLLKANA, [LNLOHEINMEO(null)] MMANGHPIIGN NDNAMJBDEFM, [LNLOHEINMEO(null)] EAAHCCJEPDK NNPOGHNBNKC, [LNLOHEINMEO(null)] MAKAPNCIGKM AFKGJPMAAOP, [LNLOHEINMEO(null)] GDKAMGGNKMO BGOPCGCOOBH, [LNLOHEINMEO(null)] MKCIIMLKNMM FGNDGEGEAAF, [LNLOHEINMEO(null)] ANCFFIABIGG KEALAHPIHLB, [LNLOHEINMEO(null)] GJGLFGOIALL AMCCBEHCIEN, [LNLOHEINMEO(null)] EHCGFOOAAPC LEFBGFJGOPL, [LNLOHEINMEO(null)] KBNDONDPNJA MCEEDLKGAEK, [LNLOHEINMEO(null)] JPHLDOGIHOB LHCFNNAECKA, [LNLOHEINMEO(null)] LFABHNPPLMB LECAEFAHFJC, [LNLOHEINMEO(null)] EHFLLDDKOID GLJFHAHCIGK, [LNLOHEINMEO(null)] MAHBABFIPHH KAPIBHBCKAO, [LNLOHEINMEO(null)] KFCIEIAMDDJ CJFJFBGGCAJ, [LNLOHEINMEO(null)] FIADEAFPLEB LGBLEBKONBO, [LNLOHEINMEO(null)] HKBKALLJCLJ DJIMFHDLLAK, [LNLOHEINMEO(null)] BKJBKHJKMHD AMDDLFCGEBB, [LNLOHEINMEO(null)] CGNFEIFNNMC CKDMDKIMHAN, [LNLOHEINMEO(null)] IALEJHMEBGG JGNJOAAKFKE, [LNLOHEINMEO(null)] AOHKHOJNHBD DIHOHCENNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x8B735C0", Offset = "0x8B71FC0", VA = "0x188B735C0")]
	private void ICNIAFDKEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x8B731F0", Offset = "0x8B71BF0", VA = "0x188B731F0", Slot = "59")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x8B73AA0", Offset = "0x8B724A0", VA = "0x188B73AA0", Slot = "51")]
	private void NLMGILHCMBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8B73B50", Offset = "0x8B72550", VA = "0x188B73B50", Slot = "52")]
	private CIBFDAJCAMN OJCDLEIFBPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8B73390", Offset = "0x8B71D90", VA = "0x188B73390", Slot = "53")]
	private CFNOBLNFNJK EGGPLBDEOPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x8B73BE0", Offset = "0x8B725E0", VA = "0x188B73BE0", Slot = "55")]
	public Task PBJEJANMLME(int BIJMEFDNJBK, BBLKGPIDOCC FEBMKDPBPHE, Func<HNFMIDJGFGN, HNFMIDJGFGN> HEDBLNILIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x8B73670", Offset = "0x8B72070", VA = "0x188B73670")]
	private LPPDAOOBPLN JBCMBPBBBJL(int BIJMEFDNJBK, BBLKGPIDOCC FEBMKDPBPHE, Func<HNFMIDJGFGN, HNFMIDJGFGN> HEDBLNILIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8B737E0", Offset = "0x8B721E0", VA = "0x188B737E0", Slot = "56")]
	[AsyncStateMachine(typeof(PCOIJGPNANH))]
	private Task<FNEGFJHAODE> JMFABJAEDGM(JBJNNHCHIGL CBJDOBLNCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8B73950", Offset = "0x8B72350", VA = "0x188B73950", Slot = "57")]
	[AsyncStateMachine(typeof(KHMIJBEKPFK))]
	private Task NCJIEHGDFBK(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8B73540", Offset = "0x8B71F40", VA = "0x188B73540")]
	[IteratorStateMachine(typeof(IKPDFKBPFLM))]
	private IEnumerable<BKKMCONGPMO> HOBMLGGOPKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8B73780", Offset = "0x8B72180", VA = "0x188B73780")]
	[CompilerGenerated]
	private void JEGJEJGOLBJ(BKKMCONGPMO BIMLKJFNDFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class HBMKNJEMJDM : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x1A7C120", Offset = "0x1A7AB20", VA = "0x181A7C120")]
	public HBMKNJEMJDM(string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class CALKOKDLJOJ : KHJHJNMCOKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct BBABDBEOKHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder<KHJHJNMCOKF.IMJNDFKJACN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public HashSet<IOOJPFDBJMM.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CALKOKDLJOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8B74600", Offset = "0x8B73000", VA = "0x188B74600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8B74910", Offset = "0x8B73310", VA = "0x188B74910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly PKEIPCLCGCJ MBIPODKGFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly KGCDOOPNJBJ JDNAAPNIDID;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string NFGBMOJACNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B76930", Offset = "0x8B75330", VA = "0x188B76930", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0xA93780", Offset = "0xA92180", VA = "0x180A93780")]
	public CALKOKDLJOJ(PKEIPCLCGCJ MBIPODKGFBO, KGCDOOPNJBJ JDNAAPNIDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x8B76820", Offset = "0x8B75220", VA = "0x188B76820", Slot = "5")]
	[AsyncStateMachine(typeof(BBABDBEOKHG))]
	public Task<KHJHJNMCOKF.IMJNDFKJACN> FAOFMEEAMBL(HashSet<IOOJPFDBJMM.Reason> LPDDNDAPHPB, CancellationToken OMJKEHOJJFF, IOOJPFDBJMM.Reason HDDLNGLMMKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class LIMLDBIPLEH : IAGNOMHFPAC, KHJHJNMCOKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct HIJPBHFINCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<KHJHJNMCOKF.IMJNDFKJACN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public LIMLDBIPLEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public HashSet<IOOJPFDBJMM.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public IOOJPFDBJMM.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private FIICLMFOJBM <localRoomInstance>5__2;

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
		private TaskAwaiter<KHJHJNMCOKF.IMJNDFKJACN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8B85950", Offset = "0x8B84350", VA = "0x188B85950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8B86320", Offset = "0x8B84D20", VA = "0x188B86320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly GMOIKPPICLH GLGCLFNNBOE;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string NFGBMOJACNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8B8C190", Offset = "0x8B8AB90", VA = "0x188B8C190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8B8C240", Offset = "0x8B8AC40", VA = "0x188B8C240")]
	public LIMLDBIPLEH([LNLOHEINMEO(null)] PKEIPCLCGCJ MBIPODKGFBO, [LNLOHEINMEO(null)] KGCDOOPNJBJ JDNAAPNIDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8B8C040", Offset = "0x8B8AA40", VA = "0x188B8C040", Slot = "5")]
	[AsyncStateMachine(typeof(HIJPBHFINCP))]
	public Task<KHJHJNMCOKF.IMJNDFKJACN> FAOFMEEAMBL(HashSet<IOOJPFDBJMM.Reason> LPDDNDAPHPB, CancellationToken OMJKEHOJJFF, IOOJPFDBJMM.Reason HDDLNGLMMKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class LJHNKMIAMGG : IAGNOMHFPAC, KHJHJNMCOKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct IAJNJDJJCGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<KHJHJNMCOKF.IMJNDFKJACN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public LJHNKMIAMGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public HashSet<IOOJPFDBJMM.Reason> fallbackTriggersToIgnore;

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
		private TaskAwaiter<GHAPMHDAMDF> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<KHJHJNMCOKF.IMJNDFKJACN> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B86F10", Offset = "0x8B85910", VA = "0x188B86F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8B87900", Offset = "0x8B86300", VA = "0x188B87900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string NFGBMOJACNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8B8C460", Offset = "0x8B8AE60", VA = "0x188B8C460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0xA93780", Offset = "0xA92180", VA = "0x180A93780")]
	public LJHNKMIAMGG(PKEIPCLCGCJ MBIPODKGFBO, KGCDOOPNJBJ JDNAAPNIDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8B8C310", Offset = "0x8B8AD10", VA = "0x188B8C310", Slot = "5")]
	[AsyncStateMachine(typeof(IAJNJDJJCGM))]
	public Task<KHJHJNMCOKF.IMJNDFKJACN> FAOFMEEAMBL(HashSet<IOOJPFDBJMM.Reason> LPDDNDAPHPB, CancellationToken OMJKEHOJJFF, IOOJPFDBJMM.Reason HDDLNGLMMKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class ILCDKLIKJAG : IAGNOMHFPAC, KHJHJNMCOKF
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class LLAPLNMPDIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public GHAPMHDAMDF matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public FIICLMFOJBM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LLAPLNMPDIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B8C5D0", Offset = "0x8B8AFD0", VA = "0x188B8C5D0")]
		internal object OEMCCAEDHPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B8C510", Offset = "0x8B8AF10", VA = "0x188B8C510")]
		internal object EDLCDCEOIPG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct JOFNDLEPNNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<KHJHJNMCOKF.IMJNDFKJACN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public ILCDKLIKJAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public HashSet<IOOJPFDBJMM.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private LLAPLNMPDIP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public IOOJPFDBJMM.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter<GHAPMHDAMDF> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter<KHJHJNMCOKF.IMJNDFKJACN> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B8A770", Offset = "0x8B89170", VA = "0x188B8A770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8B8B410", Offset = "0x8B89E10", VA = "0x188B8B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly GMOIKPPICLH GLGCLFNNBOE;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string NFGBMOJACNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8B87F70", Offset = "0x8B86970", VA = "0x188B87F70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8B88020", Offset = "0x8B86A20", VA = "0x188B88020")]
	public ILCDKLIKJAG([LNLOHEINMEO(null)] PKEIPCLCGCJ MBIPODKGFBO, [LNLOHEINMEO(null)] KGCDOOPNJBJ JDNAAPNIDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x8B87E20", Offset = "0x8B86820", VA = "0x188B87E20", Slot = "5")]
	[AsyncStateMachine(typeof(JOFNDLEPNNM))]
	public Task<KHJHJNMCOKF.IMJNDFKJACN> FAOFMEEAMBL(HashSet<IOOJPFDBJMM.Reason> LPDDNDAPHPB, CancellationToken OMJKEHOJJFF, IOOJPFDBJMM.Reason HDDLNGLMMKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class IAGNOMHFPAC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct GGIMEHOADFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public MEBJEIOEDLD log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public HashSet<IOOJPFDBJMM.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public IAGNOMHFPAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private List<IOOJPFDBJMM.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8B7F190", Offset = "0x8B7DB90", VA = "0x188B7F190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8B7F6B0", Offset = "0x8B7E0B0", VA = "0x188B7F6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	protected readonly PKEIPCLCGCJ MBIPODKGFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	protected readonly KGCDOOPNJBJ JDNAAPNIDID;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected NIIBNLNBABL HLKOBEKBMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8B86EC0", Offset = "0x8B858C0", VA = "0x188B86EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0xA93780", Offset = "0xA92180", VA = "0x180A93780")]
	public IAGNOMHFPAC(PKEIPCLCGCJ MBIPODKGFBO, KGCDOOPNJBJ JDNAAPNIDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8B86D90", Offset = "0x8B85790", VA = "0x188B86D90")]
	[AsyncStateMachine(typeof(GGIMEHOADFA))]
	protected Task FEECECEKCIB(MEBJEIOEDLD HJHMNJLNNBM, HashSet<IOOJPFDBJMM.Reason> LPDDNDAPHPB, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class CJHKHDGPKID
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct HKBNJKCMKOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder<KHJHJNMCOKF.IMJNDFKJACN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public KGCDOOPNJBJ callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B86390", Offset = "0x8B84D90", VA = "0x188B86390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8B86710", Offset = "0x8B85110", VA = "0x188B86710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class ANJBMGOFDNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public PKEIPCLCGCJ roomManager;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ANJBMGOFDNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8B74420", Offset = "0x8B72E20", VA = "0x188B74420")]
		internal object GAHBFJMFFHG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static readonly float BBOEGNLAHAJ;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	internal static readonly HashSet<IOOJPFDBJMM.Reason> NDLPIIJKBAA;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8B780E0", Offset = "0x8B76AE0", VA = "0x188B780E0")]
	[AsyncStateMachine(typeof(HKBNJKCMKOH))]
	internal static Task<KHJHJNMCOKF.IMJNDFKJACN> LKFJNBHEIOE(KGCDOOPNJBJ JDNAAPNIDID, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8B781F0", Offset = "0x8B76BF0", VA = "0x188B781F0")]
	internal static void NPAHJCICFIK(PKEIPCLCGCJ MBIPODKGFBO, MEBJEIOEDLD HJHMNJLNNBM, string GKDGCMBKDJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface KHJHJNMCOKF
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct IMJNDFKJACN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool CEHCEBOGFEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public IOOJPFDBJMM.Reason HDDLNGLMMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Enum? NFFKEGLOKCH;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8B892D0", Offset = "0x8B87CD0", VA = "0x188B892D0")]
		public static IMJNDFKJACN INJIMBANEAK()
		{
			return default(IMJNDFKJACN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8B892A0", Offset = "0x8B87CA0", VA = "0x188B892A0")]
		public static IMJNDFKJACN ILCLLHHJIIC(IOOJPFDBJMM.Reason HDDLNGLMMKN, [Optional] Enum? NFFKEGLOKCH)
		{
			return default(IMJNDFKJACN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string GCOAMAOOGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IMJNDFKJACN> FAOFMEEAMBL(HashSet<IOOJPFDBJMM.Reason> LPDDNDAPHPB, CancellationToken OMJKEHOJJFF, IOOJPFDBJMM.Reason HDDLNGLMMKN);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct CHMMMMDIIFD
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class EAOMNEKHCNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public PKEIPCLCGCJ manager;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public EAOMNEKHCNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8B78F50", Offset = "0x8B77950", VA = "0x188B78F50")]
		internal Task MKDAOOIDCOO(CancellationToken cancellationToken, int roomTotalVersion, HDAMBOGOJKO localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct BMGAMAIEPOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CHMMMMDIIFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private JBJNNHCHIGL <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter<PLMMKCFKCLM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private TaskAwaiter<FNEGFJHAODE> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8B754E0", Offset = "0x8B73EE0", VA = "0x188B754E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8B75A70", Offset = "0x8B74470", VA = "0x188B75A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct CDDHLAODPKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public CHMMMMDIIFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8B76A50", Offset = "0x8B75450", VA = "0x188B76A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8B76D70", Offset = "0x8B75770", VA = "0x188B76D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly CancellationToken OMJKEHOJJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly PKEIPCLCGCJ NKHELPOPPEM;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private JEJOFHIOJBA ODCAIOEMKBN
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8B774C0", Offset = "0x8B75EC0", VA = "0x188B774C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private KGCDOOPNJBJ NJNPDNFAPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8B770D0", Offset = "0x8B75AD0", VA = "0x188B770D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private NIIBNLNBABL HLKOBEKBMCP
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8B77440", Offset = "0x8B75E40", VA = "0x188B77440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private HKIBLJFJOCJ BDKGAHJGBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8B76EA0", Offset = "0x8B758A0", VA = "0x188B76EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2A69780", Offset = "0x2A68180", VA = "0x182A69780")]
	public CHMMMMDIIFD(CancellationToken OMJKEHOJJFF, PKEIPCLCGCJ NKHELPOPPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8B76EF0", Offset = "0x8B758F0", VA = "0x188B76EF0")]
	public static EECLCBBHACO GOHGPKJPLEL(PKEIPCLCGCJ NKHELPOPPEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8B77120", Offset = "0x8B75B20", VA = "0x188B77120")]
	[AsyncStateMachine(typeof(BMGAMAIEPOO))]
	public Task<bool> JCNNIFHFEKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8B77230", Offset = "0x8B75C30", VA = "0x188B77230")]
	private bool OOKKMIOPKFM([Out] JBJNNHCHIGL CBJDOBLNCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8B76DD0", Offset = "0x8B757D0", VA = "0x188B76DD0")]
	[AsyncStateMachine(typeof(CDDHLAODPKN))]
	private Task BPCMOMDDMDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8B76FA0", Offset = "0x8B759A0", VA = "0x188B76FA0")]
	private Task<PLMMKCFKCLM> HCIDGBPOGAI(JBJNNHCHIGL HEEGDDBKFOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct CMGEJIHEHPB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly MAKAPNCIGKM AFKGJPMAAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Guid BJGNCPGGOCA;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(FNEGFJHAODE, Task)> ILGOPMIBIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8B78560", Offset = "0x8B76F60", VA = "0x188B78560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x557A5B0", Offset = "0x5578FB0", VA = "0x18557A5B0")]
	public CMGEJIHEHPB(MAKAPNCIGKM AFKGJPMAAOP, Guid BJGNCPGGOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x8B78630", Offset = "0x8B77030", VA = "0x188B78630")]
	public TaskAwaiter<(FNEGFJHAODE, Task)> LBAHCCCMDNN()
	{
		return default(TaskAwaiter<(FNEGFJHAODE, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x8B78490", Offset = "0x8B76E90", VA = "0x188B78490", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct JEOOBPCFKOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly TaskCompletionSource<(FNEGFJHAODE, Task)> HKECECLCJPM;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(FNEGFJHAODE, Task)> ILGOPMIBIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8B8A4F0", Offset = "0x8B88EF0", VA = "0x188B8A4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x8B8A530", Offset = "0x8B88F30", VA = "0x188B8A530")]
	public JEOOBPCFKOC(TimeSpan LCCCJECCOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8B8A3C0", Offset = "0x8B88DC0", VA = "0x188B8A3C0")]
	public void GKFNMIPFFME(Task KACLMHEHNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8B8A460", Offset = "0x8B88E60", VA = "0x188B8A460")]
	public void HPNMLMGJLIG(FNEGFJHAODE EDLDCHCPHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8B8A2E0", Offset = "0x8B88CE0", VA = "0x188B8A2E0")]
	public void EENPNJCMNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x8B8A330", Offset = "0x8B88D30", VA = "0x188B8A330")]
	internal void GIBHECNFMGD(string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class KBPCCDMHKHG
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8B8B610", Offset = "0x8B8A010", VA = "0x188B8B610")]
	public static MLFBJBKAEMO IAABCDCICPI(this MLFBJBKAEMO EEMEEFCIEHD, DJEKJMDOAHO DPCLILECBIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8B8B480", Offset = "0x8B89E80", VA = "0x188B8B480")]
	public static MLFBJBKAEMO GEKOHCEBKOA(this MLFBJBKAEMO EEMEEFCIEHD, APAPHONKBGM ICJGJGCLEBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class FPJINFAIGOL : HGAFBENODKE
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class BEDPPANGHPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public APAPHONKBGM subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BEDPPANGHPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8B75120", Offset = "0x8B73B20", VA = "0x188B75120")]
		internal bool FOGBNIJEOGG(DBNKIMCJKJK s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly KFCIEIAMDDJ HKDHOCODDIE;

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public FPJINFAIGOL(KFCIEIAMDDJ CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8B7EFA0", Offset = "0x8B7D9A0", VA = "0x188B7EFA0", Slot = "4")]
	public MLFBJBKAEMO OIDBKGGJJLH(long OHGFCKGKFMF, long JCFCCOKDCNL, string MIMKOOGLIBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8B7F030", Offset = "0x8B7DA30", VA = "0x188B7F030", Slot = "5")]
	public MLFBJBKAEMO OIDBKGGJJLH(long OHGFCKGKFMF, long JCFCCOKDCNL, HCMJMHBJMFG MFNLMEFHDNI, Guid? CPCGBGNMNMH, long CIJFOCDDGDK, bool IEBAGPEOJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8B7EDA0", Offset = "0x8B7D7A0", VA = "0x188B7EDA0", Slot = "6")]
	public MLFBJBKAEMO OIDBKGGJJLH(JCHGMBODNBK FIGADLNOJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8B7EAC0", Offset = "0x8B7D4C0", VA = "0x188B7EAC0", Slot = "7")]
	public MLFBJBKAEMO OIDBKGGJJLH(DJEKJMDOAHO BLHLPKKGNMH, APAPHONKBGM EJHGOFLGBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8B7EA10", Offset = "0x8B7D410", VA = "0x188B7EA10")]
	private Guid? LGFBBBKGEBL(DJEKJMDOAHO OEEHCDLAICB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class LHCOJDHNPDK : ANENIIJDGIC, BKKMCONGPMO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct DAANMGDMAKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public LHCOJDHNPDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8B78680", Offset = "0x8B77080", VA = "0x188B78680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8B78D20", Offset = "0x8B77720", VA = "0x188B78D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly NJLNMLEFFEL JJAMHANIEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private string BHBAKCMJJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Task NKEMAJKMPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private PKEIPCLCGCJ MBIPODKGFBO;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool MGIAPHIFBNA
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8BC70", Offset = "0x8B8A670", VA = "0x188B8BC70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task DJBJKMODFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8B8BCA0", Offset = "0x8B8A6A0", VA = "0x188B8BCA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0", Slot = "7")]
	public void ICNIAFDKEKI(PKEIPCLCGCJ MBIPODKGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8B8BE50", Offset = "0x8B8A850", VA = "0x188B8BE50", Slot = "6")]
	public void JCILIMAAFLA(Task AIPCFMDLKCK, string CLCNDDBDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8B8BD30", Offset = "0x8B8A730", VA = "0x188B8BD30")]
	[AsyncStateMachine(typeof(DAANMGDMAKD))]
	private Task HKKFFJPANNK(Task NGMMBLPMFAL, string CLCNDDBDJHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8B8BFB0", Offset = "0x8B8A9B0", VA = "0x188B8BFB0")]
	public LHCOJDHNPDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class LLNAOPBDGDB : OMFLAHJDHFM, BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private bool BMBPFMNMCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private MMKEEKNGMFG FJLBHJMMBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private JEJOFHIOJBA HFINBJNJOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private KFCIEIAMDDJ CJFJFBGGCAJ;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public MMKEEKNGMFG JGFKHHPBOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8B8C900", Offset = "0x8B8B300", VA = "0x188B8C900", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8B8C970", Offset = "0x8B8B370", VA = "0x188B8C970", Slot = "7")]
	public void ICNIAFDKEKI(PKEIPCLCGCJ MBIPODKGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x8B8C650", Offset = "0x8B8B050", VA = "0x188B8C650", Slot = "5")]
	public void BNDMEJFNMGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x8B8C8C0", Offset = "0x8B8B2C0", VA = "0x188B8C8C0", Slot = "6")]
	public void NODOENJKLOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x8B8C800", Offset = "0x8B8B200", VA = "0x188B8C800")]
	private Task CKCDAMDLAHH(ODAHNAOHLPJ GIGDEGEMDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x8B8C8C0", Offset = "0x8B8B2C0", VA = "0x188B8C8C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public LLNAOPBDGDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class BBDFOGPHILD : KFCIEIAMDDJ
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class MFKOOEJFEMN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly DBKGBEHKCFL HENOFOKJKEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly string LNBCHJPEENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly T KKCMINIPIBD;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T BHKLFFIKDPE
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xB50B70", Offset = "0xB4F570", VA = "0x180B50B70")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xB50B50", Offset = "0xB4F550", VA = "0x180B50B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x581B8D0", Offset = "0x581A2D0", VA = "0x18581B8D0")]
		public MFKOOEJFEMN(DBKGBEHKCFL HENOFOKJKEM, string LNBCHJPEENA, T KKCMINIPIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x581B660", Offset = "0x581A060", VA = "0x18581B660")]
		private void DFDDGMLFAFM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly DBKGBEHKCFL HENOFOKJKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly MFKOOEJFEMN<TimeSpan> FOFAFDOCEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly MFKOOEJFEMN<TimeSpan> KMAMJDHPGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly MFKOOEJFEMN<TimeSpan> LBJFJPADGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly MFKOOEJFEMN<TimeSpan> HIOJFPPPHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly MFKOOEJFEMN<bool> APBJLCNGPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly MFKOOEJFEMN<bool> KNGINJHDACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly MFKOOEJFEMN<bool> PGMOOKKLCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly MFKOOEJFEMN<int> HJCHKMGNHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly MFKOOEJFEMN<bool> AJMHPEANCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly MFKOOEJFEMN<bool> KDNONENMCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly MFKOOEJFEMN<KNEJLBPHMMH> KBEIPJHDLNJ;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan MMDMBNHBBLG
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8B74A50", Offset = "0x8B73450", VA = "0x188B74A50", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan EOFOBAEELIN
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8B74B90", Offset = "0x8B73590", VA = "0x188B74B90", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan LJGOALPFHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8B74B50", Offset = "0x8B73550", VA = "0x188B74B50", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan NFJPMDOPGGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8B74C10", Offset = "0x8B73610", VA = "0x188B74C10", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool JHFGIPLNEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8B74AD0", Offset = "0x8B734D0", VA = "0x188B74AD0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool PGLMBPNFNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8B74A10", Offset = "0x8B73410", VA = "0x188B74A10", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool JOJGHLPLGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8B74BD0", Offset = "0x8B735D0", VA = "0x188B74BD0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int BIIKDLFBKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8B749D0", Offset = "0x8B733D0", VA = "0x188B749D0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool GADDBHMMMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8B74B10", Offset = "0x8B73510", VA = "0x188B74B10", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool KAKFBEHKBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8B74A90", Offset = "0x8B73490", VA = "0x188B74A90", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool FLAFGGNLNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8B74980", Offset = "0x8B73380", VA = "0x188B74980", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x8B74C50", Offset = "0x8B73650", VA = "0x188B74C50")]
	[UnityEngine.Scripting.Preserve]
	public BBDFOGPHILD([LNLOHEINMEO(null)] DBKGBEHKCFL HENOFOKJKEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class OGMNMKACIHN : INIGPMILEMO, BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class BADBPPHBBDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public CBIENAKDHBL roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BADBPPHBBDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8B74520", Offset = "0x8B72F20", VA = "0x188B74520")]
		internal object MGIBNJHCHCK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event ACMJJALOMHI OFOGMCPBDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8B8E9C0", Offset = "0x8B8D3C0", VA = "0x188B8E9C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8B8EA90", Offset = "0x8B8D490", VA = "0x188B8EA90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event ACMJJALOMHI MFFLDIHGJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8B8E580", Offset = "0x8B8CF80", VA = "0x188B8E580", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8B8E750", Offset = "0x8B8D150", VA = "0x188B8E750", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event ACMJJALOMHI NJLANFBBDHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8B8E4E0", Offset = "0x8B8CEE0", VA = "0x188B8E4E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8B8EBE0", Offset = "0x8B8D5E0", VA = "0x188B8EBE0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<DJILFCNIHBH, bool> OBJDEPMMCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8B8EB30", Offset = "0x8B8D530", VA = "0x188B8EB30", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8B8E6A0", Offset = "0x8B8D0A0", VA = "0x188B8E6A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "16")]
	public void ICNIAFDKEKI(PKEIPCLCGCJ MBIPODKGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8B8E670", Offset = "0x8B8D070", VA = "0x188B8E670", Slot = "12")]
	public void CHFALGOJNKN(CBIENAKDHBL JCKBCDHGAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8B8EC80", Offset = "0x8B8D680", VA = "0x188B8EC80", Slot = "13")]
	public void PIJPKIKLKKN(CBIENAKDHBL JCKBCDHGAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8B8EA60", Offset = "0x8B8D460", VA = "0x188B8EA60", Slot = "14")]
	public void LLNIJALEFDP(CBIENAKDHBL JCKBCDHGAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8B8E620", Offset = "0x8B8D020", VA = "0x188B8E620", Slot = "15")]
	public void ANMKJIANFLN(DJILFCNIHBH NLGPIOCMJCE, bool CEHCEBOGFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8B8E7F0", Offset = "0x8B8D1F0", VA = "0x188B8E7F0")]
	private void ELEPNCJAFML(ACMJJALOMHI LCJFNEJNIDM, CBIENAKDHBL JCKBCDHGAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public OGMNMKACIHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[UnityEngine.Scripting.Preserve]
internal class EHNJDAIKBFE : KDKLGIKJMEP, BKKMCONGPMO, IDisposable, IOOJPFDBJMM
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private class OJFCHPGAMHD : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct CIOPIKOIMPJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public OJFCHPGAMHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public IOOJPFDBJMM.BOFNKEABMNO reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			private OJMINOEPFCH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private KHJHJNMCOKF[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			private TaskAwaiter<KHJHJNMCOKF.IMJNDFKJACN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x8B77900", Offset = "0x8B76300", VA = "0x188B77900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x8B78080", Offset = "0x8B76A80", VA = "0x188B78080", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct BPIGMAJIADJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public AsyncTaskMethodBuilder<KHJHJNMCOKF.IMJNDFKJACN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public KHJHJNMCOKF fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public OJFCHPGAMHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public IOOJPFDBJMM.BOFNKEABMNO reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private OJMINOEPFCH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			private IAGEABFJNAP <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private TaskAwaiter<KHJHJNMCOKF.IMJNDFKJACN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x8B75AE0", Offset = "0x8B744E0", VA = "0x188B75AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x8B767B0", Offset = "0x8B751B0", VA = "0x188B767B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class HHMFMMJLHHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public IOOJPFDBJMM.BOFNKEABMNO reason;

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public HHMFMMJLHHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x8B856E0", Offset = "0x8B840E0", VA = "0x188B856E0")]
			internal object BHAOHFAEGMP((IOOJPFDBJMM.Reason fallbackReason, OIBIBNOAMEK roomDto, IAGEABFJNAP state, string subReason) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class MFKOLADEGAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public KHJHJNMCOKF fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public MFKOLADEGAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x8B8CEB0", Offset = "0x8B8B8B0", VA = "0x188B8CEB0")]
			internal object KOLBHGOIBHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Task AIPCFMDLKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CancellationTokenSource HMOHFAGJPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public IAGEABFJNAP PMDDHBMBOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public KGCDOOPNJBJ JDNAAPNIDID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public OIBIBNOAMEK OCLNGGKLFPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public FIICLMFOJBM KEOPPNFKOEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public KHJHJNMCOKF[] AIIIGDBJBKN;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool CCPIHKOJBEH
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x8B86960", Offset = "0x8B85360", VA = "0x188B86960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool EICILBIJFIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8B86980", Offset = "0x8B85380", VA = "0x188B86980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8B90820", Offset = "0x8B8F220", VA = "0x188B90820")]
		public OJFCHPGAMHD(KGCDOOPNJBJ JDNAAPNIDID, OIBIBNOAMEK OCLNGGKLFPE, FIICLMFOJBM KEOPPNFKOEL, KHJHJNMCOKF[] AIIIGDBJBKN, CancellationToken OMJKEHOJJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8B8F240", Offset = "0x8B8DC40", VA = "0x188B8F240", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8B8FD40", Offset = "0x8B8E740", VA = "0x188B8FD40")]
		public void JFCLEMMHKEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8B90190", Offset = "0x8B8EB90", VA = "0x188B90190")]
		public void NAFDJNFNPEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8B8F680", Offset = "0x8B8E080", VA = "0x188B8F680")]
		public void FACIFNDLNAO(IOOJPFDBJMM.Reason IAOPBKBLKHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8B8FA60", Offset = "0x8B8E460", VA = "0x188B8FA60")]
		[AsyncStateMachine(typeof(CIOPIKOIMPJ))]
		public Task GLJJOOJDPHN(IOOJPFDBJMM.BOFNKEABMNO HDDLNGLMMKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8B8FDB0", Offset = "0x8B8E7B0", VA = "0x188B8FDB0")]
		[AsyncStateMachine(typeof(BPIGMAJIADJ))]
		private Task<KHJHJNMCOKF.IMJNDFKJACN> JPJOCLHNGMA(IOOJPFDBJMM.BOFNKEABMNO HDDLNGLMMKN, KHJHJNMCOKF FNPOGCAPAED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8B90070", Offset = "0x8B8EA70", VA = "0x188B90070")]
		private void MONDPLKMOAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8B8ECB0", Offset = "0x8B8D6B0", VA = "0x188B8ECB0")]
		public bool BICJACKHCBN(IOOJPFDBJMM.Reason FAINEOJFEFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8B8F3E0", Offset = "0x8B8DDE0", VA = "0x188B8F3E0")]
		private void EIDGPJNBBLF(IAGEABFJNAP BLKFHFCBEDC, IOOJPFDBJMM.BOFNKEABMNO HDDLNGLMMKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8FB70", Offset = "0x8B8E570", VA = "0x188B8FB70")]
		private void IKOLAGJLJAB(IAGEABFJNAP BLKFHFCBEDC, KHJHJNMCOKF.IMJNDFKJACN AEAMJGPOBKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8B90300", Offset = "0x8B8ED00", VA = "0x188B90300")]
		private void OIHBOLENPHG(IAGEABFJNAP BLKFHFCBEDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8ED60", Offset = "0x8B8D760", VA = "0x188B8ED60")]
		private void DCEAMABHENC(IAGEABFJNAP BLKFHFCBEDC, KHJHJNMCOKF.IMJNDFKJACN AEAMJGPOBKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8B8FF00", Offset = "0x8B8E900", VA = "0x188B8FF00")]
		private void MNJFOEEDNMM(IAGEABFJNAP BLKFHFCBEDC, Exception HPIGFEEDBKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8B8F130", Offset = "0x8B8DB30", VA = "0x188B8F130")]
		private void DOBDEMFLHOH(KHJHJNMCOKF FNPOGCAPAED, IOOJPFDBJMM.BOFNKEABMNO HDDLNGLMMKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8B8F950", Offset = "0x8B8E350", VA = "0x188B8F950")]
		private void FKFGEADKIKA(KHJHJNMCOKF FNPOGCAPAED, IOOJPFDBJMM.Reason HDDLNGLMMKN, string NFFKEGLOKCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8B904B0", Offset = "0x8B8EEB0", VA = "0x188B904B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class IAGEABFJNAP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public Task<KHJHJNMCOKF.IMJNDFKJACN> AIPCFMDLKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public CancellationTokenSource HMOHFAGJPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public KHJHJNMCOKF FNPOGCAPAED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public IOOJPFDBJMM.Reason IAOPBKBLKHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public HashSet<IOOJPFDBJMM.Reason> LPDDNDAPHPB;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool CCPIHKOJBEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x8B86960", Offset = "0x8B85360", VA = "0x188B86960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool EICILBIJFIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x8B86980", Offset = "0x8B85380", VA = "0x188B86980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8B867F0", Offset = "0x8B851F0", VA = "0x188B867F0")]
		public void EHCJELPFFAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8B867D0", Offset = "0x8B851D0", VA = "0x188B867D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8B869A0", Offset = "0x8B853A0", VA = "0x188B869A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8B86D00", Offset = "0x8B85700", VA = "0x188B86D00")]
		public IAGEABFJNAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class INGLOEBKOIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public IOOJPFDBJMM.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public INGLOEBKOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8B892E0", Offset = "0x8B87CE0", VA = "0x188B892E0")]
		internal object DGKLBBGBFPL(IAGEABFJNAP x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8B893C0", Offset = "0x8B87DC0", VA = "0x188B893C0")]
		internal object PEHLBHFGJFI(OJFCHPGAMHD x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x8B89350", Offset = "0x8B87D50", VA = "0x188B89350")]
		internal object OPBCJGNJLCK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct ACLHADFPJOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public IOOJPFDBJMM.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public EHNJDAIKBFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private INGLOEBKOIE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public Exception exception;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B72400", Offset = "0x8B70E00", VA = "0x188B72400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8B73030", Offset = "0x8B71A30", VA = "0x188B73030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct OOPAENJOMNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public EHNJDAIKBFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public IOOJPFDBJMM.BOFNKEABMNO reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private OJFCHPGAMHD <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B90E70", Offset = "0x8B8F870", VA = "0x188B90E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8B91B30", Offset = "0x8B90530", VA = "0x188B91B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct GIIKDPACAEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public EHNJDAIKBFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B7F710", Offset = "0x8B7E110", VA = "0x188B7F710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B7FCB0", Offset = "0x8B7E6B0", VA = "0x188B7FCB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	internal static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	internal static readonly MEBJEIOEDLD FGLAMOEDBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private PKEIPCLCGCJ MBIPODKGFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private KGCDOOPNJBJ JDNAAPNIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private OJFCHPGAMHD IFLEJIHEEND;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private NIIBNLNBABL HLKOBEKBMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E420", Offset = "0x8B7CE20", VA = "0x188B7E420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool GLFCBMGCLCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x26ADD20", Offset = "0x26AC720", VA = "0x1826ADD20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool FNPHHKPHHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E3B0", Offset = "0x8B7CDB0", VA = "0x188B7E3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8B7DB00", Offset = "0x8B7C500", VA = "0x188B7DB00", Slot = "6")]
	public void ICNIAFDKEKI(PKEIPCLCGCJ MBIPODKGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D840", Offset = "0x8B7C240", VA = "0x188B7D840", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D850", Offset = "0x8B7C250", VA = "0x188B7D850", Slot = "9")]
	public void EHCJELPFFAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8B7DC50", Offset = "0x8B7C650", VA = "0x188B7DC50")]
	private bool JEKHLBNAAOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8B7DE50", Offset = "0x8B7C850", VA = "0x188B7DE50", Slot = "5")]
	private void NAAOGDDHFML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x8B7DD30", Offset = "0x8B7C730", VA = "0x188B7DD30", Slot = "8")]
	[AsyncStateMachine(typeof(ACLHADFPJOA))]
	public Task MHJGMPDIAGE(IOOJPFDBJMM.Reason HDDLNGLMMKN, [Optional] Exception CMHNFFEOOMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D540", Offset = "0x8B7BF40", VA = "0x188B7D540")]
	private bool DAMHJFFDNBM(IOOJPFDBJMM.BOFNKEABMNO HDDLNGLMMKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8B7DF20", Offset = "0x8B7C920", VA = "0x188B7DF20")]
	private KHJHJNMCOKF[] NBMHBOGONHB(FIICLMFOJBM NEPLEJNELJM, OIBIBNOAMEK AFLIJMLFMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D9E0", Offset = "0x8B7C3E0", VA = "0x188B7D9E0")]
	[AsyncStateMachine(typeof(OOPAENJOMNE))]
	private Task GBBAGAELFMB(IOOJPFDBJMM.BOFNKEABMNO HDDLNGLMMKN, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8B7DB80", Offset = "0x8B7C580", VA = "0x188B7DB80")]
	[AsyncStateMachine(typeof(GIIKDPACAEN))]
	private Task IMANPDKDOEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public EHNJDAIKBFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class EDCKIDKDBBD : MMANGHPIIGN, BKKMCONGPMO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct EFPFOMEPOAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public FIICLMFOJBM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public EDCKIDKDBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public DNBIMKJJAHK customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CB70", Offset = "0x8B7B570", VA = "0x188B7CB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B7D4E0", Offset = "0x8B7BEE0", VA = "0x188B7D4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct IMFEFLKFFEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public EDCKIDKDBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public FIICLMFOJBM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public DNBIMKJJAHK customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private OGMJCPNEHOO<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private OJMINOEPFCH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private CDEDAAICECI <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private DBELILBDMNM <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B880F0", Offset = "0x8B86AF0", VA = "0x188B880F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B89240", Offset = "0x8B87C40", VA = "0x188B89240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class JFHJOEHKEFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Matchmaking.DNODANILOPE result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public NIGMLAABFAO errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public JFHJOEHKEFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B8A6C0", Offset = "0x8B890C0", VA = "0x188B8A6C0")]
		internal object OINCEDHCJJA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class KFIKNIJDJCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public Task<MLFBJBKAEMO> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KFIKNIJDJCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		internal Task<MLFBJBKAEMO> PIIILLAKDGP(OGMJCPNEHOO<string>.LOEEEDILNMC _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct GKOACDHFNOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public EDCKIDKDBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public FIICLMFOJBM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public DNBIMKJJAHK customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public CDEDAAICECI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private KFIKNIJDJCO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private IOBDEMMLBCL <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private OJMINOEPFCH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private EHPANNKFGMM <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private Task<Matchmaking.CGGLCKAFDCM> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private NLNOGLBEGFJ <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.CGGLCKAFDCM> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private TaskAwaiter<MLFBJBKAEMO> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B7FD10", Offset = "0x8B7E710", VA = "0x188B7FD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8B85680", Offset = "0x8B84080", VA = "0x188B85680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class BDFGEJEEEIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Task<MLFBJBKAEMO> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BDFGEJEEEIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		internal Task<MLFBJBKAEMO> LOCGFIGDGNA(OGMJCPNEHOO<string>.LOEEEDILNMC _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct GJJPNIFKMKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public EDCKIDKDBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public FIICLMFOJBM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public DNBIMKJJAHK customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public CDEDAAICECI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private IOBDEMMLBCL <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private OJMINOEPFCH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private EHPANNKFGMM <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private Task<Matchmaking.CGGLCKAFDCM> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private MLFBJBKAEMO <initialRoomLoadPayload>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private AAHPIJDFAJG <preloadContext>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter<MLFBJBKAEMO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private NLNOGLBEGFJ <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private Task <loadEmptySceneTask>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private DLPPJIOGBLH <sceneManagementService>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private BJKINLKLGHG <scenePreloadRequest>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private CancellationTokenSource <cameraFadeCts>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private TaskAwaiter<NGBABHAHMPG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private int <i>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private YieldAwaitable.YieldAwaiter <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter<Matchmaking.CGGLCKAFDCM> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private CancellationToken <photonJoinedToken>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA0190", Offset = "0x8B9EB90", VA = "0x188BA0190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA5810", Offset = "0x8BA4210", VA = "0x188BA5810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct JLHMCDFHOKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public EDCKIDKDBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <disconnectTimerScope>5__3;

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
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7FD0", Offset = "0x8BA69D0", VA = "0x188BA7FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8A40", Offset = "0x8BA7440", VA = "0x188BA8A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct BHFNDNEIEEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public EDCKIDKDBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private CFAMNNNCHJA <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8B98520", Offset = "0x8B96F20", VA = "0x188B98520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x8B989A0", Offset = "0x8B973A0", VA = "0x188B989A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct OMJDEBBGPEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public AsyncTaskMethodBuilder<Matchmaking.CGGLCKAFDCM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public FIICLMFOJBM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public EDCKIDKDBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter<Matchmaking.CGGLCKAFDCM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1620", Offset = "0x8BB0020", VA = "0x188BB1620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1AF0", Offset = "0x8BB04F0", VA = "0x188BB1AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct EFFBOECKMHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public Matchmaking.CGGLCKAFDCM serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public EDCKIDKDBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public CDEDAAICECI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private TaskAwaiter<NOJPLHNOJFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8B9AF00", Offset = "0x8B99900", VA = "0x188B9AF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8B9B550", Offset = "0x8B99F50", VA = "0x188B9B550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class GDMEKIDIGKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public FIICLMFOJBM targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GDMEKIDIGKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B9DF70", Offset = "0x8B9C970", VA = "0x188B9DF70")]
		internal object FIBOMKPJIOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E070", Offset = "0x8B9CA70", VA = "0x188B9E070")]
		internal string OOPMAFLGPJA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct DLPMCNFLNFF : IAsyncStateMachine
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
		public FIICLMFOJBM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public EDCKIDKDBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private GDMEKIDIGKA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private OJMINOEPFCH <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x8B99C50", Offset = "0x8B98650", VA = "0x188B99C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8B9A7E0", Offset = "0x8B991E0", VA = "0x188B9A7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct MCJAEOODFNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public EDCKIDKDBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CDEDAAICECI joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public MLFBJBKAEMO initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public FIICLMFOJBM targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public AAHPIJDFAJG preloadContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public IOBDEMMLBCL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC820", Offset = "0x8BAB220", VA = "0x188BAC820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD010", Offset = "0x8BABA10", VA = "0x188BAD010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct BFHKEPLLIGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public EDCKIDKDBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private OJMINOEPFCH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap3;

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
		private OJMINOEPFCH <>7__wrap5;

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
		[Cpp2IlInjected.Address(RVA = "0x8B96CD0", Offset = "0x8B956D0", VA = "0x188B96CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8B984C0", Offset = "0x8B96EC0", VA = "0x188B984C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct KEOHJJBGMKB : IAsyncStateMachine
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
		public HDAMBOGOJKO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public EDCKIDKDBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private TaskAwaiter<FNEGFJHAODE> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9930", Offset = "0x8BA8330", VA = "0x188BA9930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA120", Offset = "0x8BA8B20", VA = "0x188BAA120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class OHEFPFBHDOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public FIICLMFOJBM targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public OHEFPFBHDOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF050", Offset = "0x8BADA50", VA = "0x188BAF050")]
		internal object PPKEOKHHKOE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class CAAKNIKDMPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public CAAKNIKDMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8B98AF0", Offset = "0x8B974F0", VA = "0x188B98AF0")]
		internal void JKGNONELJNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class EBKLNHECBDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public FIICLMFOJBM targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public EBKLNHECBDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8B9AE80", Offset = "0x8B99880", VA = "0x188B9AE80")]
		internal object KOGHFEOGCJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class GCIMGOBMHFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public FIICLMFOJBM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GCIMGOBMHFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8B9DE70", Offset = "0x8B9C870", VA = "0x188B9DE70")]
		internal string EGOBBPOBCFG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly MEBJEIOEDLD ADGEMPDGFIC;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly MEBJEIOEDLD GAPJMEGBHCD;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly MEBJEIOEDLD DLGHDOOOGMO;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static readonly string PFKEAOAKOCM;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private static readonly string FKFNIPIGKGC;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private static readonly string OMKIEOMPDNP;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly Guid LABAJCAHHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private CBEFKDIMHCC FAOBOCHEEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private APKPGOLLIMG BOOHMEPFPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private JEJOFHIOJBA HFINBJNJOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private PKEIPCLCGCJ MBIPODKGFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private KGCDOOPNJBJ JDNAAPNIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private KDKLGIKJMEP GCDCHLLKANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private ANENIIJDGIC IDHPJGGMFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private INIGPMILEMO LLMHINCMLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private CGNFEIFNNMC CKDMDKIMHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private BKJBKHJKMHD AMDDLFCGEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private IDisposable KHKBDLEGOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private AOHKHOJNHBD DIHOHCENNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly NJLNMLEFFEL MBMNCCJHCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private NLNOGLBEGFJ HKICEOOECAF;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus KFJEHFLOIKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xAAD1D0", Offset = "0xAABBD0", VA = "0x180AAD1D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1577D80", Offset = "0x1576780", VA = "0x181577D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private NIIBNLNBABL HLKOBEKBMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C6F0", Offset = "0x8B7B0F0", VA = "0x188B7C6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x8B7AF40", Offset = "0x8B79940", VA = "0x188B7AF40", Slot = "6")]
	public void ICNIAFDKEKI(PKEIPCLCGCJ MBIPODKGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8B7A040", Offset = "0x8B78A40", VA = "0x188B7A040", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8B7C5B0", Offset = "0x8B7AFB0", VA = "0x188B7C5B0", Slot = "5")]
	[AsyncStateMachine(typeof(EFPFOMEPOAL))]
	public Task OPPKANKLKAE(FIICLMFOJBM CEAKNHDJEBC, DNBIMKJJAHK IGNOKKAHPGK, CancellationToken BOJKDJLCGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8B7BE80", Offset = "0x8B7A880", VA = "0x188B7BE80")]
	[AsyncStateMachine(typeof(IMFEFLKFFEI))]
	private Task MNHGNIKJBLD(FIICLMFOJBM CEAKNHDJEBC, DNBIMKJJAHK IGNOKKAHPGK, CancellationToken BOJKDJLCGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8B7B910", Offset = "0x8B7A310", VA = "0x188B7B910")]
	private void MCMHHGICLND(CGNFEIFNNMC CKDMDKIMHAN, FIICLMFOJBM CEAKNHDJEBC, Exception HPIGFEEDBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8B790D0", Offset = "0x8B77AD0", VA = "0x188B790D0")]
	private static void ANPOCKLPBEN(DBELILBDMNM EFDNFENBMKI, Exception HPIGFEEDBKD, [Optional] List<int> DPMLGKJADBM, int NCDDAHDMLMB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8B7A350", Offset = "0x8B78D50", VA = "0x188B7A350")]
	[AsyncStateMachine(typeof(GKOACDHFNOL))]
	private Task FFAPMDAHGOH(OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, FIICLMFOJBM CEAKNHDJEBC, DNBIMKJJAHK IGNOKKAHPGK, CDEDAAICECI JJNFCNEJCJI, CancellationToken BOJKDJLCGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8B7A4B0", Offset = "0x8B78EB0", VA = "0x188B7A4B0")]
	[AsyncStateMachine(typeof(GJJPNIFKMKL))]
	private Task FFJJDODJMBB(OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, FIICLMFOJBM CEAKNHDJEBC, DNBIMKJJAHK IGNOKKAHPGK, CDEDAAICECI JJNFCNEJCJI, CancellationToken BOJKDJLCGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x8B79AD0", Offset = "0x8B784D0", VA = "0x188B79AD0")]
	private void BNMLJJJFLNM([CallerMemberName] string GBBOLJACGCA = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8B7A8F0", Offset = "0x8B792F0", VA = "0x188B7A8F0")]
	[AsyncStateMachine(typeof(JLHMCDFHOKE))]
	private Task FNDBMFMFFND(OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8B7B4D0", Offset = "0x8B79ED0", VA = "0x188B7B4D0")]
	private void JFKIFEDLKDI(FIICLMFOJBM CEAKNHDJEBC, CancellationToken BOJKDJLCGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8B7ABC0", Offset = "0x8B795C0", VA = "0x188B7ABC0")]
	private void GOJKHLOMKKJ(FIICLMFOJBM CEAKNHDJEBC, TaskStatus PIABFOHDCDB, string ONGDPODJNBL, CDEDAAICECI JJNFCNEJCJI, Exception CMHNFFEOOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8B7B270", Offset = "0x8B79C70", VA = "0x188B7B270")]
	private void IEAJAJHODMA(FIICLMFOJBM CEAKNHDJEBC, CDEDAAICECI JJNFCNEJCJI, OperationCanceledException OMIGJGFBBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8B79DD0", Offset = "0x8B787D0", VA = "0x188B79DD0")]
	private void CHLAOPLOJIO(FIICLMFOJBM CEAKNHDJEBC, CDEDAAICECI JJNFCNEJCJI, Exception HPIGFEEDBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8B7C250", Offset = "0x8B7AC50", VA = "0x188B7C250")]
	private void NOIIKBMIJCA(FIICLMFOJBM CEAKNHDJEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8B7C550", Offset = "0x8B7AF50", VA = "0x188B7C550")]
	private static CBIENAKDHBL OOFIDGJOCMH(FIICLMFOJBM CEAKNHDJEBC)
	{
		return default(CBIENAKDHBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8B7C180", Offset = "0x8B7AB80", VA = "0x188B7C180")]
	[AsyncStateMachine(typeof(BHFNDNEIEEB))]
	private Task NLELJCGDADM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8B79970", Offset = "0x8B78370", VA = "0x188B79970")]
	[AsyncStateMachine(typeof(OMJDEBBGPEH))]
	private Task<Matchmaking.CGGLCKAFDCM> BFBLEABHNDC(FIICLMFOJBM CEAKNHDJEBC, OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8B7AE30", Offset = "0x8B79830", VA = "0x188B7AE30")]
	private static NOJPLHNOJFK HDBFDOGFPBJ(Matchmaking.CGGLCKAFDCM HPHCALGGDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x8B7B380", Offset = "0x8B79D80", VA = "0x188B7B380")]
	[AsyncStateMachine(typeof(EFFBOECKMHA))]
	private Task JFIDDGGOADL(Matchmaking.CGGLCKAFDCM HPHCALGGDOA, CDEDAAICECI JJNFCNEJCJI, OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, CancellationToken FACNKJHPOCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x8B7AA80", Offset = "0x8B79480", VA = "0x188B7AA80")]
	[AsyncStateMachine(typeof(DLPMCNFLNFF))]
	private Task GLIKCKNOHPA(FIICLMFOJBM CEAKNHDJEBC, CancellationTokenSource KGIILAIMIJB, Task FHCONHOMCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8B7A1D0", Offset = "0x8B78BD0", VA = "0x188B7A1D0")]
	[AsyncStateMachine(typeof(MCJAEOODFNH))]
	private Task EKHMFCABFBC(MLFBJBKAEMO CHONICAIHNE, IOBDEMMLBCL GBHDJAGLPBM, FIICLMFOJBM DEGDBDLIAHB, CDEDAAICECI HPAKHPHFJEG, OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, CancellationToken BPJFJKBGCKK, [Optional] AAHPIJDFAJG BGBIDLFABMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8B79E50", Offset = "0x8B78850", VA = "0x188B79E50")]
	private CDEDAAICECI DMFCLNPKCPF(CDEDAAICECI HPAKHPHFJEG, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8B7A090", Offset = "0x8B78A90", VA = "0x188B7A090")]
	[AsyncStateMachine(typeof(BFHKEPLLIGB))]
	private Task EIBFAAJHGFN(OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8B78FA0", Offset = "0x8B779A0", VA = "0x188B78FA0")]
	[AsyncStateMachine(typeof(KEOHJJBGMKB))]
	private Task ABLCBNNIMLF(CancellationToken OMJKEHOJJFF, int AOOBCKPMEFJ, HDAMBOGOJKO LEAPPPBNNDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8B79C50", Offset = "0x8B78650", VA = "0x188B79C50")]
	private static void CCCKAHBDCDI(FIICLMFOJBM CEAKNHDJEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8B7A6A0", Offset = "0x8B790A0", VA = "0x188B7A6A0")]
	private void FLEIOHAPIHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8B7A610", Offset = "0x8B79010", VA = "0x188B7A610")]
	private void FHNLMMEAFBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8B7C740", Offset = "0x8B7B140", VA = "0x188B7C740")]
	private void PMIJJLBHJLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8B7B2F0", Offset = "0x8B79CF0", VA = "0x188B7B2F0")]
	private void JFCBDPJIJLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8B7C460", Offset = "0x8B7AE60", VA = "0x188B7C460")]
	private static void OHJLMKIFIPM(FIICLMFOJBM CEAKNHDJEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x8B7B800", Offset = "0x8B7A200", VA = "0x188B7B800")]
	private static CancellationTokenRegistration LLJJHNEHJHD(FIICLMFOJBM CEAKNHDJEBC, CancellationToken FACNKJHPOCH)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x8B7BD80", Offset = "0x8B7A780", VA = "0x188B7BD80")]
	private static void MEOCBODLBFB(FIICLMFOJBM CEAKNHDJEBC, Exception HPIGFEEDBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x8B7BFD0", Offset = "0x8B7A9D0", VA = "0x188B7BFD0")]
	private void NIFBFFALNGC(FIICLMFOJBM CEAKNHDJEBC, Task FHCONHOMCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8B7AA20", Offset = "0x8B79420", VA = "0x188B7AA20")]
	private static void GCLDEHJKFHJ(Func<string> LJCGGLBEFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8B7C9F0", Offset = "0x8B7B3F0", VA = "0x188B7C9F0")]
	public EDCKIDKDBBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8B79910", Offset = "0x8B78310", VA = "0x188B79910")]
	[CompilerGenerated]
	internal static (int, int?) AOGBELAFIOO(NIGMLAABFAO EKKNDADGPGC)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[RecRoom.NoEngine.Common.Preserve]
internal class AEKNKPOPGAM : EAAHCCJEPDK, BKKMCONGPMO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct AGMENIDEHCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public AEKNKPOPGAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public HDAMBOGOJKO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8B94F20", Offset = "0x8B93920", VA = "0x188B94F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x8B95400", Offset = "0x8B93E00", VA = "0x188B95400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class JNELKHHDMCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AEKNKPOPGAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public HDAMBOGOJKO localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public JNELKHHDMCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8BA98F0", Offset = "0x8BA82F0", VA = "0x188BA98F0")]
		internal List<Task> ECCANPNHNPJ(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct HMGIBMPNMCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public EECLCBBHACO taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public HDAMBOGOJKO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6A00", Offset = "0x8BA5400", VA = "0x188BA6A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6DA0", Offset = "0x8BA57A0", VA = "0x188BA6DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct ABIIHMPOMNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public AEKNKPOPGAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8B93BC0", Offset = "0x8B925C0", VA = "0x188B93BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x8B93EA0", Offset = "0x8B928A0", VA = "0x188B93EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private readonly HashSet<EECLCBBHACO> LLFJFKABJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private APKPGOLLIMG BOOHMEPFPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private PKEIPCLCGCJ MBIPODKGFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private NNCIEOBEJLN HFCNPGCCDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private PFNOENBKANA BGBHHNAKOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private IDisposable KHKBDLEGOGE;

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8B94250", Offset = "0x8B92C50", VA = "0x188B94250", Slot = "5")]
	public void ICNIAFDKEKI(PKEIPCLCGCJ MBIPODKGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8B93FF0", Offset = "0x8B929F0", VA = "0x188B93FF0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8B941F0", Offset = "0x8B92BF0", VA = "0x188B941F0", Slot = "4")]
	public bool HKHEJMNGCLI(EECLCBBHACO FMFINDAMJGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8B94CF0", Offset = "0x8B936F0", VA = "0x188B94CF0")]
	private void MNNKMAAFAKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8B94A00", Offset = "0x8B93400", VA = "0x188B94A00")]
	private void JHPILHBBLAD(ALPHANGLKLD OBPEHAFILEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x8B93F00", Offset = "0x8B92900", VA = "0x188B93F00")]
	[AsyncStateMachine(typeof(AGMENIDEHCP))]
	private Task DPCMIEEKABI(int AOOBCKPMEFJ, HDAMBOGOJKO LEAPPPBNNDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x8B94DC0", Offset = "0x8B937C0", VA = "0x188B94DC0")]
	private Func<CancellationToken, List<Task>> PNPBNHPJOJK(int AOOBCKPMEFJ, HDAMBOGOJKO LEAPPPBNNDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x8B94530", Offset = "0x8B92F30", VA = "0x188B94530")]
	private List<Task> IKPBACIHDKD(int AOOBCKPMEFJ, HDAMBOGOJKO LEAPPPBNNDJ, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x8B940D0", Offset = "0x8B92AD0", VA = "0x188B940D0")]
	[AsyncStateMachine(typeof(HMGIBMPNMCN))]
	private Task FCCFIGNIEBL(EECLCBBHACO JIDFLIOODEF, CancellationToken DHNMCOFINFM, int AOOBCKPMEFJ, HDAMBOGOJKO LEAPPPBNNDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8B94C20", Offset = "0x8B93620", VA = "0x188B94C20")]
	[AsyncStateMachine(typeof(ABIIHMPOMNI))]
	private Task KIHGBBGNHJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8B94050", Offset = "0x8B92A50", VA = "0x188B94050")]
	private void EHCJELPFFAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8B94E90", Offset = "0x8B93890", VA = "0x188B94E90")]
	public AEKNKPOPGAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[UnityEngine.Scripting.Preserve]
internal sealed class OABJCHOABPI : MAKAPNCIGKM, BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class CKIMMJMNNLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public CKIMMJMNNLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8B98C90", Offset = "0x8B97690", VA = "0x188B98C90")]
		internal object MADHNHMFCGP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class IIMDOIKKDHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public IIMDOIKKDHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6E60", Offset = "0x8BA5860", VA = "0x188BA6E60")]
		internal object HELDJGKOGBA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class AGLMOBONEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public AGLMOBONEDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class HMNPACBEEFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public HMNPACBEEFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6E00", Offset = "0x8BA5800", VA = "0x188BA6E00")]
		internal object FDNIJPKBKNN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class FMFLFINAMCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public FMFLFINAMCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8B9D950", Offset = "0x8B9C350", VA = "0x188B9D950")]
		internal object BGLIFIFFDOF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private readonly Dictionary<Guid, JEOOBPCFKOC> AFKGJPMAAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private readonly TimeSpan NEMPLKHKFLL;

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "9")]
	public void ICNIAFDKEKI(PKEIPCLCGCJ MBIPODKGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE960", Offset = "0x8BAD360", VA = "0x188BAE960", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE9E0", Offset = "0x8BAD3E0", VA = "0x188BAE9E0", Slot = "4")]
	public CMGEJIHEHPB MJGPLOFFIKO(Guid BJGNCPGGOCA)
	{
		return default(CMGEJIHEHPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE340", Offset = "0x8BACD40", VA = "0x188BAE340", Slot = "5")]
	public bool BBOPECIHIDA(Guid BJGNCPGGOCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x8BAEC00", Offset = "0x8BAD600", VA = "0x188BAEC00", Slot = "6")]
	public bool PMNNHINGIAB(Guid BJGNCPGGOCA, Task KACLMHEHNDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE780", Offset = "0x8BAD180", VA = "0x188BAE780", Slot = "7")]
	public bool CMKAIGHNBLH(Guid BJGNCPGGOCA, FNEGFJHAODE EDLDCHCPHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE970", Offset = "0x8BAD370", VA = "0x188BAE970", Slot = "8")]
	public Task<(FNEGFJHAODE, Task)> JPDMCFGGECP(Guid BJGNCPGGOCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE550", Offset = "0x8BACF50", VA = "0x188BAE550")]
	private void CLDFHFOOFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x8BAEF30", Offset = "0x8BAD930", VA = "0x188BAEF30")]
	public OABJCHOABPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[RecRoom.NoEngine.Common.Preserve]
internal class KJNAFKCGIJM : GDKAMGGNKMO, BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class LHGMMBOEHEG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private readonly FIICLMFOJBM BHNMENBIBOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private readonly CancellationTokenSource LNGJLPHIAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public readonly CancellationToken FIOAMKACPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private bool OMICDPGKKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private bool JNAAJFKIBLB;

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB870", Offset = "0x8BAA270", VA = "0x188BAB870")]
		public LHGMMBOEHEG(FIICLMFOJBM BHNMENBIBOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB720", Offset = "0x8BAA120", VA = "0x188BAB720")]
		public void EHCJELPFFAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB6F0", Offset = "0x8BAA0F0", VA = "0x188BAB6F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class CPJMICIAHPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public ODAHNAOHLPJ disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public CPJMICIAHPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8B98DB0", Offset = "0x8B977B0", VA = "0x188B98DB0")]
		internal object MFILHOACDDE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private struct FNNNOJMFOFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public ODAHNAOHLPJ disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public KJNAFKCGIJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8B9D9B0", Offset = "0x8B9C3B0", VA = "0x188B9D9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8B9DE10", Offset = "0x8B9C810", VA = "0x188B9DE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class BKJNKFGIDPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public KJNAFKCGIJM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BKJNKFGIDPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8B98A00", Offset = "0x8B97400", VA = "0x188B98A00")]
		internal object PAHIJFPDMHN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class NHENLACAEIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public FIICLMFOJBM newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public BKJNKFGIDPI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public NHENLACAEIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE210", Offset = "0x8BACC10", VA = "0x188BAE210")]
		internal object BDHDBMLMMLE((FIICLMFOJBM lastLocalPlayerRoomInstance, FIICLMFOJBM newRoomInstance, KDKLGIKJMEP fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct AOAMPAANBJM : IAsyncStateMachine
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
		public KJNAFKCGIJM <>4__this;

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
		private OJMINOEPFCH <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8B95510", Offset = "0x8B93F10", VA = "0x188B95510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xAE21E0", Offset = "0xAE0BE0", VA = "0x180AE21E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class DFMIOBANDPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public FIICLMFOJBM newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public DFMIOBANDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8B99AF0", Offset = "0x8B984F0", VA = "0x188B99AF0")]
		internal object FMHEEEFBGIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8B99BD0", Offset = "0x8B985D0", VA = "0x188B99BD0")]
		internal void MNLBDJFJBLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8B99AB0", Offset = "0x8B984B0", VA = "0x188B99AB0")]
		internal object ACMGAHEAFIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8B99B90", Offset = "0x8B98590", VA = "0x188B99B90")]
		internal object IKDGGHFDONB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct OHLGDHNBNDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public FIICLMFOJBM newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public KJNAFKCGIJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public DNBIMKJJAHK customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private DFMIOBANDPP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private OJMINOEPFCH <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x8BAF220", Offset = "0x8BADC20", VA = "0x188BAF220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x8BB01F0", Offset = "0x8BAEBF0", VA = "0x188BB01F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static readonly FCKFKGJMBGD.MBLBPCPAECE MOBAMHOLFGA;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static readonly AMEBIDIOCLJ EGFIHPEKMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private APKPGOLLIMG BOOHMEPFPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private PKEIPCLCGCJ MBIPODKGFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private KDKLGIKJMEP GCDCHLLKANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private KGCDOOPNJBJ JDNAAPNIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private KFCIEIAMDDJ CJFJFBGGCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private MMANGHPIIGN NDNAMJBDEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private FIICLMFOJBM FCDBBCHAAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private LHGMMBOEHEG MLBHKPCJCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool LDMJNCIAMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private Task JPLHGIHDHJP;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private NIIBNLNBABL HLKOBEKBMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB080", Offset = "0x8BA9A80", VA = "0x188BAB080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool ECEDPMMIIPL
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xAF4200", Offset = "0xAF2C00", VA = "0x180AF4200")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAACA0", Offset = "0x8BA96A0", VA = "0x188BAACA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8BAA660", Offset = "0x8BA9060", VA = "0x188BAA660", Slot = "4")]
	public void ICNIAFDKEKI(PKEIPCLCGCJ MBIPODKGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8BAA270", Offset = "0x8BA8C70", VA = "0x188BAA270", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8BAA3E0", Offset = "0x8BA8DE0", VA = "0x188BAA3E0")]
	[AsyncStateMachine(typeof(FNNNOJMFOFJ))]
	private Task ENAHCNMLLBA(ODAHNAOHLPJ AINOMCJGGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8BAA4D0", Offset = "0x8BA8ED0", VA = "0x188BAA4D0")]
	private void HMCDIPPNOHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB0D0", Offset = "0x8BA9AD0", VA = "0x188BAB0D0")]
	private void PKPGNEMPMKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x8BAACB0", Offset = "0x8BA96B0", VA = "0x188BAACB0")]
	private void KOALNNMMKLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8BAA1F0", Offset = "0x8BA8BF0", VA = "0x188BAA1F0")]
	private bool BMPKAELCEGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8BAAE30", Offset = "0x8BA9830", VA = "0x188BAAE30")]
	[AsyncStateMachine(typeof(AOAMPAANBJM))]
	private void LPCHOENMAIP(int PCJBPIKLFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x8BAAA00", Offset = "0x8BA9400", VA = "0x188BAAA00")]
	private void JDMMEDDMLHK([Out] IDisposable MGHBBENJEEN, [Out] IDisposable HBKCKDNBGKB, [Out] IDisposable AFCHLOJOEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8BAA900", Offset = "0x8BA9300", VA = "0x188BAA900")]
	private bool ILIEMADEMPK(FIICLMFOJBM BHNMENBIBOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB030", Offset = "0x8BA9A30", VA = "0x188BAB030")]
	private void MOHFHLFEPLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x8BAAF00", Offset = "0x8BA9900", VA = "0x188BAAF00")]
	[AsyncStateMachine(typeof(OHLGDHNBNDK))]
	private Task MNHGNIKJBLD(FIICLMFOJBM BHNMENBIBOK, DNBIMKJJAHK IGNOKKAHPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB620", Offset = "0x8BAA020", VA = "0x188BAB620")]
	public KJNAFKCGIJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[UnityEngine.Scripting.Preserve]
internal sealed class OJJLEKMJGJJ : MKCIIMLKNMM, BKKMCONGPMO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct NBLLAKFEAKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public AsyncTaskMethodBuilder<FPJCCCPHHPB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public OJJLEKMJGJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private TaskAwaiter<FPJCCCPHHPB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD8E0", Offset = "0x8BAC2E0", VA = "0x188BAD8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x8BADB70", Offset = "0x8BAC570", VA = "0x188BADB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class CKPOMMKCCFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public FPMLGPKCMLB message;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public CKPOMMKCCFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x8B98CF0", Offset = "0x8B976F0", VA = "0x188B98CF0")]
		internal object FHLIDOFKEHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class PCJENLDDAKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public FPMLGPKCMLB messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PCJENLDDAKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1B60", Offset = "0x8BB0560", VA = "0x188BB1B60")]
		internal object KFIBBLOKILA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class IJNLPDDHFFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public FPMLGPKCMLB request;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public IJNLPDDHFFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6EC0", Offset = "0x8BA58C0", VA = "0x188BA6EC0")]
		internal object BENFHECAJGE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct JADBBLLCGLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public FPMLGPKCMLB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public OJJLEKMJGJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private TaskAwaiter<MFDOGKHNMAA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7100", Offset = "0x8BA5B00", VA = "0x188BA7100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA79D0", Offset = "0x8BA63D0", VA = "0x188BA79D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class OMFMIDANBPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public FPMLGPKCMLB operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public OMFMIDANBPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB15C0", Offset = "0x8BAFFC0", VA = "0x188BB15C0")]
		internal object LCCEKPLIINB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct HLCDANLGCIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public FPMLGPKCMLB operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public OJJLEKMJGJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private CDEDAAICECI <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter<FPMLGPKCMLB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA5E20", Offset = "0x8BA4820", VA = "0x188BA5E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA69A0", Offset = "0x8BA53A0", VA = "0x188BA69A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct JCHMPNOPCJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<MFDOGKHNMAA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public OJJLEKMJGJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public FPMLGPKCMLB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private ONONFBIEDEL.GDDPIFNFJHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private CDEDAAICECI <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private TaskAwaiter<FPMLGPKCMLB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7A30", Offset = "0x8BA6430", VA = "0x188BA7A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7F60", Offset = "0x8BA6960", VA = "0x188BA7F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class BOJPALAIGKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public MFDOGKHNMAA operation;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BOJPALAIGKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x8B98A70", Offset = "0x8B97470", VA = "0x188B98A70")]
		internal object GBFFAPCGBBL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct DDPHNEIPILO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public MFDOGKHNMAA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public OJJLEKMJGJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private OGMJCPNEHOO<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8B99420", Offset = "0x8B97E20", VA = "0x188B99420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x8B99A50", Offset = "0x8B98450", VA = "0x188B99A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class NDCMBFNDJKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public FPMLGPKCMLB request;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public NDCMBFNDJKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE1B0", Offset = "0x8BACBB0", VA = "0x188BAE1B0")]
		internal object NJLBIJJCNBO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class OEEPIKADOME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public FPMLGPKCMLB request;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public OEEPIKADOME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEFF0", Offset = "0x8BAD9F0", VA = "0x188BAEFF0")]
		internal object BEACHPODOLP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private PKEIPCLCGCJ MBIPODKGFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private ANENIIJDGIC IDHPJGGMFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private ANCFFIABIGG KEALAHPIHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private JPHLDOGIHOB LHCFNNAECKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private JEJOFHIOJBA HFINBJNJOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private TaskCompletionSource<FPJCCCPHHPB> DKNJAFMBIML;

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0E20", Offset = "0x8BAF820", VA = "0x188BB0E20", Slot = "7")]
	public void ICNIAFDKEKI(PKEIPCLCGCJ MBIPODKGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x8BB1020", Offset = "0x8BAFA20", VA = "0x188BB1020", Slot = "6")]
	[AsyncStateMachine(typeof(NBLLAKFEAKA))]
	public Task<FPJCCCPHHPB> MAIKOEGPLPK(CancellationToken HFHCCJBEPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0900", Offset = "0x8BAF300", VA = "0x188BB0900", Slot = "4")]
	public void DNHOECDIBDP(FPMLGPKCMLB ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x8BB1280", Offset = "0x8BAFC80", VA = "0x188BB1280", Slot = "5")]
	public void PDCGNDIICKI(FPMLGPKCMLB IEEAOPPBPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0F10", Offset = "0x8BAF910", VA = "0x188BB0F10")]
	[AsyncStateMachine(typeof(JADBBLLCGLM))]
	private Task KMEJGLCAKJC(FPMLGPKCMLB NIBLEOGJBJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0250", Offset = "0x8BAEC50", VA = "0x188BB0250")]
	[AsyncStateMachine(typeof(HLCDANLGCIC))]
	private Task CFJPADABPOE(FPMLGPKCMLB JDGGLMBEDLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x8BB1130", Offset = "0x8BAFB30", VA = "0x188BB1130")]
	[AsyncStateMachine(typeof(JCHMPNOPCJD))]
	private Task<MFDOGKHNMAA> NFDAOKNLIDF(FPMLGPKCMLB NIBLEOGJBJF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0D90", Offset = "0x8BAF790", VA = "0x188BB0D90")]
	private CDEDAAICECI HJFAMJLBDIN(FPMLGPKCMLB LOLEDACMADE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0C70", Offset = "0x8BAF670", VA = "0x188BB0C70")]
	[AsyncStateMachine(typeof(DDPHNEIPILO))]
	private Task EPBKPHLPBLK(MFDOGKHNMAA EANMJMPIOGJ, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0360", Offset = "0x8BAED60", VA = "0x188BB0360")]
	private MFDOGKHNMAA DBNIJNFJAHC(FPMLGPKCMLB NIBLEOGJBJF, CDEDAAICECI AHLBPAOAMLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x3E4AFC0", Offset = "0x3E499C0", VA = "0x183E4AFC0")]
	private T DEMOHJJMKHH<T>(T PDKJBMPOMNC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0570", Offset = "0x8BAEF70", VA = "0x188BB0570")]
	private MFDOGKHNMAA DNCGNBJNJDK(FPMLGPKCMLB NIBLEOGJBJF, CDEDAAICECI AHLBPAOAMLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public OJJLEKMJGJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class GHAODLCFOGH : ANCFFIABIGG, BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class NPMPCBKCIHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public NPMPCBKCIHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE2D0", Offset = "0x8BACCD0", VA = "0x188BAE2D0")]
		internal object GOLJCOLLLCF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class KHEOJAOAFNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KHEOJAOAFNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA180", Offset = "0x8BA8B80", VA = "0x188BAA180")]
		internal object GKEFCKHNHGL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private JEJOFHIOJBA HFINBJNJOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private LFABHNPPLMB LECAEFAHFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private MKCIIMLKNMM FGNDGEGEAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private MAKAPNCIGKM AFKGJPMAAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private MAHBABFIPHH KAPIBHBCKAO;

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x8B9F3A0", Offset = "0x8B9DDA0", VA = "0x188B9F3A0", Slot = "6")]
	public void ICNIAFDKEKI(PKEIPCLCGCJ MBIPODKGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x8B9E7E0", Offset = "0x8B9D1E0", VA = "0x188B9E7E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x8B9F720", Offset = "0x8B9E120", VA = "0x188B9F720", Slot = "4")]
	public CMGEJIHEHPB JPCNMHMGLNI(FPMLGPKCMLB GGCLMLLGCNJ)
	{
		return default(CMGEJIHEHPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x8B9F510", Offset = "0x8B9DF10", VA = "0x188B9F510", Slot = "5")]
	public void JDBDIHDCDNO(Guid BJGNCPGGOCA, Task KACLMHEHNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x8B9F070", Offset = "0x8B9DA70", VA = "0x188B9F070")]
	private void EKKJBKHOJCP(NDGFICGAFID GFNNIJMCMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x8B9EAD0", Offset = "0x8B9D4D0", VA = "0x188B9EAD0")]
	private void EJAHEFCFOPN(NLJKJGELBAN EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x8B9E560", Offset = "0x8B9CF60", VA = "0x188B9E560")]
	private void CNJMBILCJBP(NLJKJGELBAN EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x8B9E890", Offset = "0x8B9D290", VA = "0x188B9E890")]
	private void EEHGHALANGH(NLJKJGELBAN EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x8B9FB50", Offset = "0x8B9E550", VA = "0x188B9FB50")]
	private FNEGFJHAODE LLMPLLMMOMI(FPMLGPKCMLB LOLEDACMADE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x8B9FD90", Offset = "0x8B9E790", VA = "0x188B9FD90")]
	private void MKNELBGACAP(FPMLGPKCMLB JDGGLMBEDLP, FNEGFJHAODE EDLDCHCPHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x8B9FFA0", Offset = "0x8B9E9A0", VA = "0x188B9FFA0")]
	private bool NKBFJCODGGF(FPMLGPKCMLB JDGGLMBEDLP, FNEGFJHAODE EDLDCHCPHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x8B9F180", Offset = "0x8B9DB80", VA = "0x188B9F180")]
	private bool GJAPNKFGHDD(FPMLGPKCMLB OFKDIEFOION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x8B9E310", Offset = "0x8B9CD10", VA = "0x188B9E310")]
	private bool AAPFAMEAAGP(byte JBJEMPGNJPD, ExitGames.Client.Photon.Hashtable EOOLELFGEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public GHAODLCFOGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[UnityEngine.Scripting.Preserve]
internal sealed class GOIDBFPLBGI : GJGLFGOIALL, BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class GGMDCLKEOMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public FPJCCCPHHPB operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public GOIDBFPLBGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public FPMLGPKCMLB roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GGMDCLKEOMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E2A0", Offset = "0x8B9CCA0", VA = "0x188B9E2A0")]
		internal object MJAGCNEADAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E170", Offset = "0x8B9CB70", VA = "0x188B9E170")]
		internal object ECNJNJJBOBG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct JNADLHHFMAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder<FNEGFJHAODE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public GOIDBFPLBGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public FPMLGPKCMLB roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter<FNEGFJHAODE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8BA91E0", Offset = "0x8BA7BE0", VA = "0x188BA91E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9880", Offset = "0x8BA8280", VA = "0x188BA9880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class MGAFPCJIPDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public FPJCCCPHHPB operationType;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public MGAFPCJIPDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD070", Offset = "0x8BABA70", VA = "0x188BAD070")]
		internal object JFMHLIPHIDK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class LNIFFAHOEKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public FPMLGPKCMLB request;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LNIFFAHOEKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB920", Offset = "0x8BAA320", VA = "0x188BAB920")]
		internal object DCICGDPODGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB990", Offset = "0x8BAA390", VA = "0x188BAB990")]
		internal object HFGJFOGCHFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8BABA00", Offset = "0x8BAA400", VA = "0x188BABA00")]
		internal object MPBFFLGLEAE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct FBBPCOLAKMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder<FNEGFJHAODE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public FPMLGPKCMLB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public GOIDBFPLBGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private LNIFFAHOEKG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private CMGEJIHEHPB <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private FNEGFJHAODE <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter<(FNEGFJHAODE validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC10", Offset = "0x8B9A610", VA = "0x188B9BC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C600", Offset = "0x8B9B000", VA = "0x188B9C600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private JEJOFHIOJBA HFINBJNJOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private LFABHNPPLMB LECAEFAHFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private ANCFFIABIGG KEALAHPIHLB;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5C30", Offset = "0x8BA4630", VA = "0x188BA5C30", Slot = "5")]
	public void ICNIAFDKEKI(PKEIPCLCGCJ MBIPODKGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5B10", Offset = "0x8BA4510", VA = "0x188BA5B10", Slot = "4")]
	[AsyncStateMachine(typeof(JNADLHHFMAH))]
	private Task<FNEGFJHAODE> EMMFOEDBJEL(FPMLGPKCMLB LOLEDACMADE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5920", Offset = "0x8BA4320", VA = "0x188BA5920")]
	private bool AGGDBJMLHOH(FPJCCCPHHPB NLGPIOCMJCE, [Out] FNEGFJHAODE AEAMJGPOBKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5CE0", Offset = "0x8BA46E0", VA = "0x188BA5CE0")]
	[AsyncStateMachine(typeof(FBBPCOLAKMD))]
	private Task<FNEGFJHAODE> PAGEIJGJBOE(FPMLGPKCMLB NIBLEOGJBJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public GOIDBFPLBGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class MKLDDDBKGKJ : EHCGFOOAAPC, BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private struct JJDIGLFJLFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public HCMJMHBJMFG BIFMMINGOGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public long EONIHMMGJOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public Guid? CHPPGNIDLJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public bool NCNDOIJLKNA;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct DOMMKOOCOMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder<MLFBJBKAEMO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public FIICLMFOJBM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public MKLDDDBKGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private TaskAwaiter<DJEKJMDOAHO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<MLFBJBKAEMO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x8B9A840", Offset = "0x8B99240", VA = "0x188B9A840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B9AE10", Offset = "0x8B99810", VA = "0x188B9AE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class GOEDCFHHPMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GOEDCFHHPMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x8BA5870", Offset = "0x8BA4270", VA = "0x188BA5870")]
		internal object JGGKFGPCION()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct ENFBKLMBDCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public AsyncTaskMethodBuilder<DJEKJMDOAHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public MKLDDDBKGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public FIICLMFOJBM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private GOEDCFHHPMH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private TaskAwaiter<DJEKJMDOAHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B9B5B0", Offset = "0x8B99FB0", VA = "0x188B9B5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BBA0", Offset = "0x8B9A5A0", VA = "0x188B9BBA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct DBGFAACAACO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AsyncTaskMethodBuilder<MLFBJBKAEMO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public MKLDDDBKGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public FIICLMFOJBM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public DJEKJMDOAHO roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter<JJDIGLFJLFF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B98E40", Offset = "0x8B97840", VA = "0x188B98E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B993B0", Offset = "0x8B97DB0", VA = "0x188B993B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class JABMDGMEIBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public DJEKJMDOAHO roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public JABMDGMEIBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xFD7070", Offset = "0xFD5A70", VA = "0x180FD7070")]
		internal bool DPNDGFEDBDI(DBNKIMCJKJK sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7040", Offset = "0x8BA5A40", VA = "0x188BA7040")]
		internal object LBOELPNBFEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6FB0", Offset = "0x8BA59B0", VA = "0x188BA6FB0")]
		internal object KKNHPCHBLJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6F20", Offset = "0x8BA5920", VA = "0x188BA6F20")]
		internal object IDCODBKHHNP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class CHLNGKCHGLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public JABMDGMEIBE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public CHLNGKCHGLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B98B90", Offset = "0x8B97590", VA = "0x188B98B90")]
		internal object EILIBGBFLJG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct PMIDOLJCNBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public AsyncTaskMethodBuilder<JJDIGLFJLFF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public DJEKJMDOAHO roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public MKLDDDBKGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public FIICLMFOJBM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private CHLNGKCHGLJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private TaskAwaiter<JJDIGLFJLFF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private TaskAwaiter<MGLMPLLOJJF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1BC0", Offset = "0x8BB05C0", VA = "0x188BB1BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2B70", Offset = "0x8BB1570", VA = "0x188BB2B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class AHEPHAADBOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public AHEPHAADBOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x8B95460", Offset = "0x8B93E60", VA = "0x188B95460")]
		internal object HAMAPPABMDM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private struct JLNAADFGFLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public AsyncTaskMethodBuilder<JJDIGLFJLFF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public DBNKIMCJKJK subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public MKLDDDBKGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public FIICLMFOJBM dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private AHEPHAADBOP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private TaskAwaiter<APAPHONKBGM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8AA0", Offset = "0x8BA74A0", VA = "0x188BA8AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9170", Offset = "0x8BA7B70", VA = "0x188BA9170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private KGCDOOPNJBJ JDNAAPNIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private KFCIEIAMDDJ CJFJFBGGCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private IALEJHMEBGG JGNJOAAKFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private HGAFBENODKE AMAMIBPECML;

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD3B0", Offset = "0x8BABDB0", VA = "0x188BAD3B0", Slot = "5")]
	public void ICNIAFDKEKI(PKEIPCLCGCJ MBIPODKGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD0E0", Offset = "0x8BABAE0", VA = "0x188BAD0E0", Slot = "4")]
	[AsyncStateMachine(typeof(DOMMKOOCOMI))]
	public Task<MLFBJBKAEMO> GFKBHICOJOG(OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, FIICLMFOJBM CEAKNHDJEBC, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD610", Offset = "0x8BAC010", VA = "0x188BAD610")]
	[AsyncStateMachine(typeof(ENFBKLMBDCO))]
	private Task<DJEKJMDOAHO> JBELEAMJIHK(FIICLMFOJBM CEAKNHDJEBC, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD770", Offset = "0x8BAC170", VA = "0x188BAD770")]
	[AsyncStateMachine(typeof(DBGFAACAACO))]
	private Task<MLFBJBKAEMO> OEBNLGMPOHM(FIICLMFOJBM CEAKNHDJEBC, DJEKJMDOAHO EKGOPNCKLNO, long JOIKPPGBGCF, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD4A0", Offset = "0x8BABEA0", VA = "0x188BAD4A0")]
	[AsyncStateMachine(typeof(PMIDOLJCNBA))]
	private Task<JJDIGLFJLFF> IKFBJJACPJJ(FIICLMFOJBM CEAKNHDJEBC, DJEKJMDOAHO EKGOPNCKLNO, long JOIKPPGBGCF, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD240", Offset = "0x8BABC40", VA = "0x188BAD240")]
	[AsyncStateMachine(typeof(JLNAADFGFLI))]
	private Task<JJDIGLFJLFF> GGNECALMPNM(FIICLMFOJBM ICAKIKJKFPH, DBNKIMCJKJK GOLLOAJNBEK, long JOIKPPGBGCF, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public MKLDDDBKGKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[UnityEngine.Scripting.Preserve]
internal sealed class LPIMPLJKCDN : JPHLDOGIHOB, BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class LFEAHKHJHDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public FPMLGPKCMLB request;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LFEAHKHJHDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB690", Offset = "0x8BAA090", VA = "0x188BAB690")]
		internal object FNPMCAHOGBO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct FLDCPBDKJAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public AsyncTaskMethodBuilder<FPMLGPKCMLB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public FPMLGPKCMLB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public LPIMPLJKCDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public CDEDAAICECI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private TaskAwaiter<FPMLGPKCMLB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8B9D2D0", Offset = "0x8B9BCD0", VA = "0x188B9D2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B9D8E0", Offset = "0x8B9C2E0", VA = "0x188B9D8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct LOIBLKDCNAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public AsyncTaskMethodBuilder<FPMLGPKCMLB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public LPIMPLJKCDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public CDEDAAICECI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private TaskAwaiter<BHBOHPALJMA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8BABA70", Offset = "0x8BAA470", VA = "0x188BABA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC070", Offset = "0x8BAAA70", VA = "0x188BAC070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class COEJMDBNEBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public FPMLGPKCMLB request;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public COEJMDBNEBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B98D50", Offset = "0x8B97750", VA = "0x188B98D50")]
		internal object BLACNAMOLNN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct FEKJHPHJBLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public AsyncTaskMethodBuilder<FPMLGPKCMLB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public FPMLGPKCMLB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public LPIMPLJKCDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public CDEDAAICECI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private KKPCJHOPEAB <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private MKOBLGHBCDF <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private TaskAwaiter<BHBOHPALJMA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C670", Offset = "0x8B9B070", VA = "0x188B9C670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x8B9D260", Offset = "0x8B9BC60", VA = "0x188B9D260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private JEJOFHIOJBA HFINBJNJOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private OMFLAHJDHFM ADNJGIKFHLH;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private MMKEEKNGMFG JGFKHHPBOGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC440", Offset = "0x8BAAE40", VA = "0x188BAC440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC660", Offset = "0x8BAB060", VA = "0x188BAC660", Slot = "8")]
	public void ICNIAFDKEKI(PKEIPCLCGCJ MBIPODKGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC230", Offset = "0x8BAAC30", VA = "0x188BAC230", Slot = "4")]
	[AsyncStateMachine(typeof(FLDCPBDKJAG))]
	public Task<FPMLGPKCMLB> EAIJFAFNLNB(FPMLGPKCMLB NIBLEOGJBJF, CDEDAAICECI AHLBPAOAMLM, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC0E0", Offset = "0x8BAAAE0", VA = "0x188BAC0E0", Slot = "5")]
	[AsyncStateMachine(typeof(LOIBLKDCNAF))]
	public Task<FPMLGPKCMLB> AGNBGDEEDKL(CancellationToken OMJKEHOJJFF, CDEDAAICECI AHLBPAOAMLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC390", Offset = "0x8BAAD90", VA = "0x188BAC390", Slot = "6")]
	public OHBMAKCLEEN EIEENNHBKOB(MFDOGKHNMAA LOMLEJHBJDE, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC6F0", Offset = "0x8BAB0F0", VA = "0x188BAC6F0", Slot = "7")]
	public OHBMAKCLEEN JECEFAKCGBI(MFDOGKHNMAA LOMLEJHBJDE, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC500", Offset = "0x8BAAF00", VA = "0x188BAC500")]
	[AsyncStateMachine(typeof(FEKJHPHJBLN))]
	private Task<FPMLGPKCMLB> FPMNFDMMNAH(FPMLGPKCMLB NIBLEOGJBJF, CDEDAAICECI AHLBPAOAMLM, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x3E498C0", Offset = "0x3E482C0", VA = "0x183E498C0")]
	private static byte[] JFMDJGHPCAK(FPMLGPKCMLB ONGDPODJNBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public LPIMPLJKCDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[UnityEngine.Scripting.Preserve]
internal sealed class NCEDLEFENHH : LFABHNPPLMB, BKKMCONGPMO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private APNHHKNLLEN HNBJIPBOPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private JEJOFHIOJBA HFINBJNJOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private ANENIIJDGIC IDHPJGGMFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private KBNDONDPNJA MCEEDLKGAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private KGCDOOPNJBJ JDNAAPNIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private MMANGHPIIGN NDNAMJBDEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private EAAHCCJEPDK NNPOGHNBNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private KFCIEIAMDDJ CJFJFBGGCAJ;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private NIIBNLNBABL HLKOBEKBMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE160", Offset = "0x8BACB60", VA = "0x188BAE160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static FNEGFJHAODE INJIMBANEAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x8BADD50", Offset = "0x8BAC750", VA = "0x188BADD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x8BADD60", Offset = "0x8BAC760", VA = "0x188BADD60", Slot = "6")]
	public void ICNIAFDKEKI(PKEIPCLCGCJ MBIPODKGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x8BADBE0", Offset = "0x8BAC5E0", VA = "0x188BADBE0", Slot = "4")]
	public FNEGFJHAODE BILBNDBAGMH(POIAKMBAMML HBBJNPLOCFM, FPJCCCPHHPB KGCMMEAFMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x8BADED0", Offset = "0x8BAC8D0", VA = "0x188BADED0", Slot = "5")]
	public FNEGFJHAODE KFCLJEJDPEP(POIAKMBAMML PFEPHHMCGMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE150", Offset = "0x8BACB50", VA = "0x188BAE150")]
	private static FNEGFJHAODE OIEEJMLBHKG(OGAHAPMAOOE HDDLNGLMMKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public NCEDLEFENHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public class BPBBMKMMEBO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x8BB4CC0", Offset = "0x8BB36C0", VA = "0x188BB4CC0")]
	public BPBBMKMMEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA340", Offset = "0x7CB8D40", VA = "0x187CBA340")]
	public BPBBMKMMEBO(string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[UnityEngine.Scripting.Preserve]
internal sealed class KDKHDKBIHLH : HKIBLJFJOCJ, BKKMCONGPMO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct DMGOBHLIHPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public AsyncTaskMethodBuilder<FNEGFJHAODE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public KDKHDKBIHLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public JBJNNHCHIGL autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private OGMJCPNEHOO<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private MEKPJBCGGCO <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private TaskAwaiter<FNEGFJHAODE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9DF0", Offset = "0x8BB87F0", VA = "0x188BB9DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA7D0", Offset = "0x8BB91D0", VA = "0x188BBA7D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct KIJMPIMLLGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public KDKHDKBIHLH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8BC2130", Offset = "0x8BC0B30", VA = "0x188BC2130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2890", Offset = "0x8BC1290", VA = "0x188BC2890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct JIMDNJDGAPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public KDKHDKBIHLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0270", Offset = "0x8BBEC70", VA = "0x188BC0270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0780", Offset = "0x8BBF180", VA = "0x188BC0780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct EBIFJFIFOMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public KDKHDKBIHLH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8BBAFD0", Offset = "0x8BB99D0", VA = "0x188BBAFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB790", Offset = "0x8BBA190", VA = "0x188BBB790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct NNOPOIGBAPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public KDKHDKBIHLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x8BC88B0", Offset = "0x8BC72B0", VA = "0x188BC88B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x8BC8A50", Offset = "0x8BC7450", VA = "0x188BC8A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct EBFMFHNPJPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public KDKHDKBIHLH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8BBA840", Offset = "0x8BB9240", VA = "0x188BBA840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x8BBAF70", Offset = "0x8BB9970", VA = "0x188BBAF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct AHMLAEKLKOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public KDKHDKBIHLH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8BB3470", Offset = "0x8BB1E70", VA = "0x188BB3470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x8BB38E0", Offset = "0x8BB22E0", VA = "0x188BB38E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct BGCNEIJFGCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public KDKHDKBIHLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public AHLLAMLIAPD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private OGMJCPNEHOO<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB46C0", Offset = "0x8BB30C0", VA = "0x188BB46C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4C60", Offset = "0x8BB3660", VA = "0x188BB4C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private JEJOFHIOJBA HFINBJNJOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private PKEIPCLCGCJ MBIPODKGFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private KGCDOOPNJBJ JDNAAPNIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private JPHLDOGIHOB LHCFNNAECKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private ANENIIJDGIC IDHPJGGMFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private EAAHCCJEPDK NNPOGHNBNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private CancellationTokenSource IEFBJPJFNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private Task GOEINCCJEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private TaskCompletionSource<int> EHAMEONPPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private int LNHFBKNAOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private int EKHEDCGDEEO;

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1760", Offset = "0x8BC0160", VA = "0x188BC1760", Slot = "6")]
	public void ICNIAFDKEKI(PKEIPCLCGCJ MBIPODKGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x1526A50", Offset = "0x1525450", VA = "0x181526A50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1C40", Offset = "0x8BC0640", VA = "0x188BC1C40")]
	private void MOCCOIJKFLG(float DHGNDFONGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1B10", Offset = "0x8BC0510", VA = "0x188BC1B10", Slot = "4")]
	[AsyncStateMachine(typeof(DMGOBHLIHPH))]
	public Task<FNEGFJHAODE> LEADEDGDNFA(JBJNNHCHIGL CBJDOBLNCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1570", Offset = "0x8BBFF70", VA = "0x188BC1570", Slot = "5")]
	[AsyncStateMachine(typeof(KIJMPIMLLGJ))]
	public Task GMEIJJDNCDC([Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x1526A50", Offset = "0x1525450", VA = "0x181526A50")]
	public void CAIFIHKOPJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1150", Offset = "0x8BBFB50", VA = "0x188BC1150")]
	private MEKPJBCGGCO CNJMFJJECHP(JBJNNHCHIGL CBJDOBLNCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1380", Offset = "0x8BBFD80", VA = "0x188BC1380")]
	[AsyncStateMachine(typeof(JIMDNJDGAPD))]
	private Task DMGNAADKBGL(CancellationToken BOJKDJLCGKE, int AOOBCKPMEFJ, HDAMBOGOJKO LEAPPPBNNDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1660", Offset = "0x8BC0060", VA = "0x188BC1660")]
	[AsyncStateMachine(typeof(EBIFJFIFOMN))]
	private Task HOGHIPHOKOB(CancellationToken BOJKDJLCGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1A20", Offset = "0x8BC0420", VA = "0x188BC1A20")]
	[AsyncStateMachine(typeof(NNOPOIGBAPE))]
	private Task KFGFEODJHDI([Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1060", Offset = "0x8BBFA60", VA = "0x188BC1060")]
	[AsyncStateMachine(typeof(EBFMFHNPJPP))]
	private Task CKDCHDKLMAK(CancellationToken BOJKDJLCGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1470", Offset = "0x8BBFE70", VA = "0x188BC1470")]
	[AsyncStateMachine(typeof(AHMLAEKLKOB))]
	private Task EAEHJKKHDAI(CancellationToken JFHNDJPINKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1D20", Offset = "0x8BC0720", VA = "0x188BC1D20")]
	private Task MOGILAIPNJF(AHLLAMLIAPD MJAEFDLBIKK, CancellationToken BOJKDJLCGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1910", Offset = "0x8BC0310", VA = "0x188BC1910")]
	[AsyncStateMachine(typeof(BGCNEIJFGCB))]
	private Task JJECHDDKAHM(AHLLAMLIAPD MJAEFDLBIKK, CancellationToken BOJKDJLCGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1EB0", Offset = "0x8BC08B0", VA = "0x188BC1EB0")]
	private bool NHBIDKDBOEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public KDKHDKBIHLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[UnityEngine.Scripting.Preserve]
internal class KIKMCDKHBOI : KBNDONDPNJA, BKKMCONGPMO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct PNKMKNANLDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public KIKMCDKHBOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private OGMJCPNEHOO<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x8BCF990", Offset = "0x8BCE390", VA = "0x188BCF990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x8BCFF40", Offset = "0x8BCE940", VA = "0x188BCFF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private NEAJMIIPJPB PGGKFPINHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000391")]
	private PKEIPCLCGCJ MBIPODKGFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private LFABHNPPLMB LECAEFAHFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private JPHLDOGIHOB LHCFNNAECKA;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC2940", Offset = "0x8BC1340", VA = "0x188BC2940", Slot = "6")]
	public void ICNIAFDKEKI(PKEIPCLCGCJ MBIPODKGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x8BC28F0", Offset = "0x8BC12F0", VA = "0x188BC28F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x8BC2C20", Offset = "0x8BC1620", VA = "0x188BC2C20", Slot = "5")]
	[AsyncStateMachine(typeof(PNKMKNANLDC))]
	public Task IOAMMHBFDFO(string HODLOHIDPMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x8BC2E60", Offset = "0x8BC1860", VA = "0x188BC2E60", Slot = "4")]
	public FNEGFJHAODE NHBIDKDBOEL(POIAKMBAMML HBBJNPLOCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x8BC2D20", Offset = "0x8BC1720", VA = "0x188BC2D20")]
	private ELPBHFPCJFN KKGBOJOBOEP(string HODLOHIDPMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public KIKMCDKHBOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public static class NOAAHCFBIHH
{
	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8FC0", Offset = "0x8BC79C0", VA = "0x188BC8FC0")]
	public static void GOBLJGOFEJA(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9200", Offset = "0x8BC7C00", VA = "0x188BC9200")]
	internal static void NCHHBDONLKG(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8EE0", Offset = "0x8BC78E0", VA = "0x188BC8EE0")]
	internal static void FOIGEFIFKMI(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8AB0", Offset = "0x8BC74B0", VA = "0x188BC8AB0")]
	internal static void DBIFBHNHBNP(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x3E19210", Offset = "0x3E17C10", VA = "0x183E19210")]
	private static void ANHIFHAOCKG<Interface, Impl, Interface>(CFAMNNNCHJA JBOIKIICKBA) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal class CAADGJDDFNO : HGJPNAPPIBG<FPMLGPKCMLB>
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private sealed class GACMKEMNPGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public FPMLGPKCMLB message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GACMKEMNPGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD180", Offset = "0x8BBBB80", VA = "0x188BBD180")]
		internal object MLDOMOIGEBM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly CAADGJDDFNO NDAIDGNOFDA;

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x8BB5710", Offset = "0x8BB4110", VA = "0x188BB5710")]
	public ExitGames.Client.Photon.Hashtable AGNKEKDJGCC(FPMLGPKCMLB ONGDPODJNBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x8BB57A0", Offset = "0x8BB41A0", VA = "0x188BB57A0", Slot = "5")]
	protected override void FKCJJGAJKCF(FPMLGPKCMLB ONGDPODJNBL, IDictionary<object, object> GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x8BB59E0", Offset = "0x8BB43E0", VA = "0x188BB59E0", Slot = "6")]
	public override FPMLGPKCMLB JBBKNKCPLNK(IDictionary<object, object> GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x8BB58D0", Offset = "0x8BB42D0", VA = "0x188BB58D0")]
	private static void GCLDEHJKFHJ(string FEPLAELCNLG, FPMLGPKCMLB ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x8BB5F50", Offset = "0x8BB4950", VA = "0x188BB5F50")]
	public CAADGJDDFNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x8BB5C10", Offset = "0x8BB4610", VA = "0x188BB5C10")]
	[CompilerGenerated]
	internal static string PPKFAJNHBLC(MLFBJBKAEMO EEMEEFCIEHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public static class KBMFJEIMKEF
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static FNEGFJHAODE INJIMBANEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0DA0", Offset = "0x8BBF7A0", VA = "0x188BC0DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x8BC0B20", Offset = "0x8BBF520", VA = "0x188BC0B20")]
	public static bool BILPLLNDJGC(this FNEGFJHAODE EDLDCHCPHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x8BC0E00", Offset = "0x8BBF800", VA = "0x188BC0E00")]
	public static FNEGFJHAODE OIEEJMLBHKG(OGAHAPMAOOE GEHFNMHGHJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x8BC0E60", Offset = "0x8BBF860", VA = "0x188BC0E60")]
	public static FNEGFJHAODE PIIIKKBGGMJ(IEnumerable<FNEGFJHAODE> AFMPHLDOMCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x8BC0B40", Offset = "0x8BBF540", VA = "0x188BC0B40")]
	public static string FDOOOKJBADM(this FNEGFJHAODE AEAMJGPOBKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public abstract class DLOCIFOCMNN : HEEEMJHMOLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public delegate FNEGFJHAODE NIEGFFOGPJA([NotNull] POIAKMBAMML PKHAABOHMDK);

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class ENBBCGLHCLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public POIAKMBAMML photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ENBBCGLHCLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x17E9120", Offset = "0x17E7B20", VA = "0x1817E9120")]
		internal FNEGFJHAODE KCFFIBKGJEO(NIEGFFOGPJA v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	private bool JAFNIEKLOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	protected readonly HashSet<NIEGFFOGPJA> PEDFHLPLKLD;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9D00", Offset = "0x8BB8700", VA = "0x188BB9D00", Slot = "4")]
	public void JALPOKCBCOG(NIEGFFOGPJA MBCJDMNELNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9C50", Offset = "0x8BB8650", VA = "0x188BB9C50", Slot = "5")]
	public void DPGCJIFJBFH(NIEGFFOGPJA MBCJDMNELNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9CB0", Offset = "0x8BB86B0", VA = "0x188BB9CB0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x8BB99B0", Offset = "0x8BB83B0", VA = "0x188BB99B0")]
	protected FNEGFJHAODE ADJBDCJJJPK(POIAKMBAMML PFEPHHMCGMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9D60", Offset = "0x8BB8760", VA = "0x188BB9D60")]
	protected DLOCIFOCMNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class ONDOKGFAGJL : DLOCIFOCMNN, APNHHKNLLEN, HEEEMJHMOLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class ENJPABIPGMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public FNEGFJHAODE result;

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ENJPABIPGMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBF60", Offset = "0x8BBA960", VA = "0x188BBBF60")]
		internal object KPCPNGNOAMI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x8BC0260", Offset = "0x8BBEC60", VA = "0x188BC0260")]
	[UnityEngine.Scripting.Preserve]
	public ONDOKGFAGJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x8BCB7B0", Offset = "0x8BCA1B0", VA = "0x188BCB7B0", Slot = "8")]
	public FNEGFJHAODE DNLAPNEGABM(POIAKMBAMML PFEPHHMCGMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class JGAANPJJKBL : DLOCIFOCMNN, NEAJMIIPJPB, HEEEMJHMOLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class PCGCLIMDEGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public FNEGFJHAODE result;

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PCGCLIMDEGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x8BCD770", Offset = "0x8BCC170", VA = "0x188BCD770")]
		internal object GNCEDMLNMMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x8BC0260", Offset = "0x8BBEC60", VA = "0x188BC0260")]
	[UnityEngine.Scripting.Preserve]
	public JGAANPJJKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC0150", Offset = "0x8BBEB50", VA = "0x188BC0150", Slot = "8")]
	public FNEGFJHAODE NHBIDKDBOEL(POIAKMBAMML PIAAPOBLMOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal static class HKINLBGFDBC
{
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private sealed class MECECLCDFLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public OGMJCPNEHOO<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public MECECLCDFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5680", Offset = "0x8BC4080", VA = "0x188BC5680")]
		internal object FADGHCNMCGH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF6A0", Offset = "0x8BBE0A0", VA = "0x188BBF6A0")]
	public static OGMJCPNEHOO<string> KGKIBAEENIK(MEBJEIOEDLD HJHMNJLNNBM, [Optional] string IPCDEBGMMKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF520", Offset = "0x8BBDF20", VA = "0x188BBF520")]
	public static void EDOADBMHPNE(OGMJCPNEHOO<string> HIBNALIEBDI, MEBJEIOEDLD HJHMNJLNNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF5E0", Offset = "0x8BBDFE0", VA = "0x188BBF5E0")]
	public static string JFKKEFIDCGL(FPMLGPKCMLB LOLEDACMADE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal static class JANCJCDJGPO
{
	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x8BBFFB0", Offset = "0x8BBE9B0", VA = "0x188BBFFB0")]
	public static void BJHJPJALOOJ(this JEJOFHIOJBA HFINBJNJOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x8BBFFC0", Offset = "0x8BBE9C0", VA = "0x188BBFFC0")]
	public static void GPCIOGNKLAJ(this JEJOFHIOJBA HFINBJNJOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x8BBFFD0", Offset = "0x8BBE9D0", VA = "0x188BBFFD0")]
	private static void IOHLJLIHGAM(this JEJOFHIOJBA HFINBJNJOEI, bool BIGPLAPONED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class ALOJLBAOPPC : HEJKJBPJGII, PCHEMBGLEFG, MBGCJNMBOPE, NFEEIPGCNPI
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[DefaultMember("Item")]
	private class IGFLACAIJOO : NDGFICGAFID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly byte LKMAOFPCIGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly int AANOAFILNFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly object FMOGNHDGDLE;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public byte ECFFFCOHNGB
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xB50B70", Offset = "0xB4F570", VA = "0x180B50B70", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public int GHKKOHGBCJH
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xAD35E0", Offset = "0xAD1FE0", VA = "0x180AD35E0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public object LKCAPNFOLKE
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public object EFLOLIACEGI
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x8BBF780", Offset = "0x8BBE180", VA = "0x188BBF780", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1A70", Offset = "0x7CC0470", VA = "0x187CC1A70")]
		public IGFLACAIJOO(byte LKMAOFPCIGJ, int AANOAFILNFN, object FMOGNHDGDLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF7D0", Offset = "0x8BBE1D0", VA = "0x188BBF7D0", Slot = "8")]
		public bool PKNEHCKDABA(byte LNBCHJPEENA, [Out] object PDKJBMPOMNC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private readonly PCHEMBGLEFG FMAHALOCFMJ;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public POIAKMBAMML PFBPJPFKPFK
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3F40", Offset = "0x8BB2940", VA = "0x188BB3F40", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int KOPKFBLHDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4230", Offset = "0x8BB2C30", VA = "0x188BB4230", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int KLGGNHHHJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x8BB40D0", Offset = "0x8BB2AD0", VA = "0x188BB40D0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public POIAKMBAMML DCPOHCODDJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3D60", Offset = "0x8BB2760", VA = "0x188BB3D60", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool APCPMJALFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public int EHNJNKCPIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xC325B0", Offset = "0xC30FB0", VA = "0x180C325B0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public string JCCCODLMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3A20", Offset = "0x8BB2420", VA = "0x188BB3A20", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Func<string, string> GNNMFBDCHFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x8BB42C0", Offset = "0x8BB2CC0", VA = "0x188BB42C0", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<string, long> GKOPPPDNOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<NDGFICGAFID> DGLLFHDDKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3DB0", Offset = "0x8BB27B0", VA = "0x188BB3DB0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3B70", Offset = "0x8BB2570", VA = "0x188BB3B70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<bool> AEFGMGLDAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "26")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "27")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<POIAKMBAMML> PLJMNGGJIOE
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action DPIDLNPJMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3A80", Offset = "0x8BB2480", VA = "0x188BB3A80", Slot = "35")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3CC0", Offset = "0x8BB26C0", VA = "0x188BB3CC0", Slot = "36")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x8BB4070", Offset = "0x8BB2A70", VA = "0x188BB4070", Slot = "19")]
	public void KEGLJMKAJJM(string FLBFBHGDBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0xE62940", Offset = "0xE61340", VA = "0x180E62940")]
	public ALOJLBAOPPC(PCHEMBGLEFG FMAHALOCFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x8BB4120", Offset = "0x8BB2B20", VA = "0x188BB4120", Slot = "8")]
	public bool NFDKLIAMEJI(byte JBJEMPGNJPD, object DBCENLDHIPJ, LFCPHBACBIP KAFJCIDDMMN, DLFBKNHNOAP JHLCIINJOPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x8BB3C20", Offset = "0x8BB2620", VA = "0x188BB3C20", Slot = "20")]
	public POIAKMBAMML EHOJGGNNPOI(int OGACJNJBOMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x8BB3940", Offset = "0x8BB2340", VA = "0x188BB3940", Slot = "21")]
	public POIAKMBAMML AHONALBBPDC(int LHPHKGMDHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x8BB3E60", Offset = "0x8BB2860", VA = "0x188BB3E60", Slot = "22")]
	public POIAKMBAMML FNOFDDLJCKF(int OGACJNJBOMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x8BB3F90", Offset = "0x8BB2990", VA = "0x188BB3F90", Slot = "23")]
	public IReadOnlyList<POIAKMBAMML> JBKMDMCDAIH(bool HCHBGGHKOHP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x8BB4280", Offset = "0x8BB2C80", VA = "0x188BB4280", Slot = "24")]
	public IReadOnlyList<POIAKMBAMML> ODIHBBCFFJA(bool HCHBGGHKOHP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "25")]
	public bool FKCGABJOAIE(POIAKMBAMML JJGEFLDDLHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "28")]
	public void IAMANOOODOB(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "29")]
	public void KCPGNCEPFDH(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "30")]
	public void KKEFIJOFOOH(object DHNMCOFINFM, bool BNIIJGIOPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x8BB3B20", Offset = "0x8BB2520", VA = "0x188BB3B20", Slot = "31")]
	public IDisposable DMNKKMMJKHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "32")]
	private bool OFIIDGPBMGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "33")]
	public void FLDIFAOJJHE(StringBuilder IPBAIMPPDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x10D5BC0", Offset = "0x10D45C0", VA = "0x1810D5BC0", Slot = "34")]
	public bool NAAIBACONMJ(bool CHFGFGIAFFI, [Out] string GFHOJCCMEDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x105E040", Offset = "0x105CA40", VA = "0x18105E040", Slot = "37")]
	public void MOJOABEDNIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal struct NLJKJGELBAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly IDictionary<object, object> EOOLELFGEAP;

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0xE76700", Offset = "0xE75100", VA = "0x180E76700")]
	public NLJKJGELBAN(IDictionary<object, object> EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8660", Offset = "0x8BC7060", VA = "0x188BC8660")]
	public bool DOGOFCGCACH([Out] FPMLGPKCMLB ONGDPODJNBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8710", Offset = "0x8BC7110", VA = "0x188BC8710")]
	public Guid ELGKNLIKMJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8520", Offset = "0x8BC6F20", VA = "0x188BC8520")]
	public FNEGFJHAODE CBKGLKIKGGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x8BC87C0", Offset = "0x8BC71C0", VA = "0x188BC87C0")]
	public static ExitGames.Client.Photon.Hashtable OIDBKGGJJLH(FPMLGPKCMLB ONGDPODJNBL, FNEGFJHAODE EDLDCHCPHPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal static class PLHGELFGALP
{
	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x8BCE5A0", Offset = "0x8BCCFA0", VA = "0x188BCE5A0")]
	public static bool OOGNDNFNAAK(this FIICLMFOJBM KEOPPNFKOEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal struct PFNOENBKANA : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct MAINEEJDFGN : IAsyncStateMachine
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
		public PFNOENBKANA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5440", Offset = "0x8BC3E40", VA = "0x188BC5440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5620", Offset = "0x8BC4020", VA = "0x188BC5620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly CancellationTokenSource LNGJLPHIAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private bool JAFNIEKLOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private Task AIPCFMDLKCK;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool DKCDJFPCHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x8BCD7D0", Offset = "0x8BCC1D0", VA = "0x188BCD7D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x8BCD960", Offset = "0x8BCC360", VA = "0x188BCD960")]
	public PFNOENBKANA(CancellationToken OMJKEHOJJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8BCD800", Offset = "0x8BCC200", VA = "0x188BCD800")]
	[AsyncStateMachine(typeof(MAINEEJDFGN))]
	public Task DABGNJEFBCP(Func<CancellationToken, List<Task>> LHGHGNEJKKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x8BCD910", Offset = "0x8BCC310", VA = "0x188BCD910", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public readonly struct GLILHEAMKDI<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct FGLMCNHJKIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public AsyncTaskMethodBuilder<DOHEMIFBILP<CDDDFCHIGNI<TData>, OGOHDADDIPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public GLILHEAMKDI<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<DOHEMIFBILP<CDDDFCHIGNI<TData>, OGOHDADDIPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x4E052A0", Offset = "0x4E03CA0", VA = "0x184E052A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x4947CC0", Offset = "0x49466C0", VA = "0x184947CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	private readonly KLFADJGMDLG<TGetDataArg, TData> CHPBOPOCLBJ;

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0xE76700", Offset = "0xE75100", VA = "0x180E76700")]
	internal GLILHEAMKDI(KLFADJGMDLG<TGetDataArg, TData> MADJNKEDNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x4FB18F0", Offset = "0x4FB02F0", VA = "0x184FB18F0")]
	[AsyncStateMachine(typeof(GLILHEAMKDI<, >.FGLMCNHJKIK))]
	public Task<DOHEMIFBILP<CDDDFCHIGNI<TData>, OGOHDADDIPM>> HCJHKFBKBJP(TGetDataArg GOMJJOOOEFM, string JIEJDKEHFKE, OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public static class NGELGEDLABN
{
	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x3A01790", Offset = "0x3A00190", VA = "0x183A01790")]
	public static GLILHEAMKDI<TGetDataArg, TData> MDDJOGPLAFO<TGetDataArg, TData>(KLFADJGMDLG<TGetDataArg, TData> MADJNKEDNDC)
	{
		return default(GLILHEAMKDI<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public struct NIGMLAABFAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public readonly int ECFFFCOHNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public readonly int? OOHGBPOIBJN;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5576270", Offset = "0x5574C70", VA = "0x185576270")]
	public NIGMLAABFAO(int LKMAOFPCIGJ, [Optional] int? LKCFJPILIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8440", Offset = "0x8BC6E40", VA = "0x188BC8440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface ACLFDGAMIOP<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PCNMIFODBNN();

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ACLFDGAMIOP<T> IENBKPIPFAD(string PKEPBFNDJEA);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ACLFDGAMIOP<T> DDGLJHAKGFE(OGNBKBOKAKH<T> EAJDNIDNKMI);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ACLFDGAMIOP<T> BEPBLFOOAKA(int EKKNDADGPGC);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ACLFDGAMIOP<T> BAHJDPAHNFI(int EKKNDADGPGC, EGACMJOFLBO<T> CFEPJMHBCBA);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface CGNFEIFNNMC
{
	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ACLFDGAMIOP<T> NJCCMOKDBLO<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DEJNPCOHMHD JJOLMEEFLKP(Exception HPIGFEEDBKD);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NIGMLAABFAO MOPBNAINPIN(Exception HPIGFEEDBKD);
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public delegate string OGNBKBOKAKH<in T>(T HPIGFEEDBKD) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public delegate int EGACMJOFLBO<in T>(T HPIGFEEDBKD) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class LLANLIAPHIO : CGNFEIFNNMC
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private delegate string DEKJMIEOLAL(Exception HPIGFEEDBKD);

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private delegate int GDOCEFMALCF(Exception HPIGFEEDBKD);

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	private class EBEJGPGENIP<T> : ACLFDGAMIOP<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class CANMOAIPDLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public CANMOAIPDLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			internal string MFFOFHGEFOC(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		[CompilerGenerated]
		private sealed class LOPEDGMGMPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public OGNBKBOKAKH<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public LOPEDGMGMPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x5625020", Offset = "0x5623A20", VA = "0x185625020")]
			internal string CONJJNNGDPK(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000104")]
		[CompilerGenerated]
		private sealed class OJIBPJOCELP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public EGACMJOFLBO<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public OJIBPJOCELP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x5625020", Offset = "0x5623A20", VA = "0x185625020")]
			internal int FJFMMLMKMFB(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private readonly LLANLIAPHIO CKDMDKIMHAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private readonly Type HDMDLOPLAMI;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x4916580", Offset = "0x4914F80", VA = "0x184916580")]
		internal EBEJGPGENIP(LLANLIAPHIO CKDMDKIMHAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x4916550", Offset = "0x4914F50", VA = "0x184916550", Slot = "4")]
		public void PCNMIFODBNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x4916440", Offset = "0x4914E40", VA = "0x184916440", Slot = "5")]
		public ACLFDGAMIOP<T> IENBKPIPFAD(string PKEPBFNDJEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x4916330", Offset = "0x4914D30", VA = "0x184916330", Slot = "6")]
		public ACLFDGAMIOP<T> DDGLJHAKGFE(OGNBKBOKAKH<T> EAJDNIDNKMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x49162F0", Offset = "0x4914CF0", VA = "0x1849162F0", Slot = "7")]
		public ACLFDGAMIOP<T> BEPBLFOOAKA(int EKKNDADGPGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x49161D0", Offset = "0x4914BD0", VA = "0x1849161D0", Slot = "8")]
		public ACLFDGAMIOP<T> BAHJDPAHNFI(int EKKNDADGPGC, EGACMJOFLBO<T> CFEPJMHBCBA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class GADICPECNAL<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private bool PNDNNCEJNNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private readonly List<Type> MOHGLNLJKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private readonly Dictionary<Type, TVal> IOPIPHHCNGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private readonly Dictionary<Type, int> LILBACFPPDJ;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public IReadOnlyList<Type> OIINBCKKPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x4ED05C0", Offset = "0x4ECEFC0", VA = "0x184ED05C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x4ED0740", Offset = "0x4ECF140", VA = "0x184ED0740")]
		public GADICPECNAL(Dictionary<Type, int> LILBACFPPDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x4ED0340", Offset = "0x4ECED40", VA = "0x184ED0340")]
		public void MJGPLOFFIKO(Type LNBCHJPEENA, TVal BEAEDIJJJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x4ED02C0", Offset = "0x4ECECC0", VA = "0x184ED02C0")]
		public bool DEHMLPFAGKO(Type HDMDLOPLAMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x4ED0300", Offset = "0x4ECED00", VA = "0x184ED0300")]
		public bool KGHAKBLMNFC(TVal PDKJBMPOMNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x44A3EC0", Offset = "0x44A28C0", VA = "0x1844A3EC0")]
		public TVal DHBICMHDGKM(Type AEOGKDPPBBE)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x4ED0520", Offset = "0x4ECEF20", VA = "0x184ED0520")]
		[CompilerGenerated]
		private int OAHOPGIJHOP(Type BBKHIAHGMGP, Type LIHKHNBAHLE)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class NFIBOEFFBAF : IEnumerable<NIGMLAABFAO>, IEnumerable, IEnumerator<NIGMLAABFAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private NIGMLAABFAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public LLANLIAPHIO <>4__this;

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
		private IEnumerator<NIGMLAABFAO> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private NIGMLAABFAO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x49499E0", Offset = "0x49483E0", VA = "0x1849499E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(NIGMLAABFAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x8BC77A0", Offset = "0x8BC61A0", VA = "0x188BC77A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
		[DebuggerHidden]
		public NFIBOEFFBAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x8BC77F0", Offset = "0x8BC61F0", VA = "0x188BC77F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7190", Offset = "0x8BC5B90", VA = "0x188BC7190", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7140", Offset = "0x8BC5B40", VA = "0x188BC7140")]
		private void ALLLMJKJJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7640", Offset = "0x8BC6040", VA = "0x188BC7640")]
		private void NADPDCNBFDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7750", Offset = "0x8BC6150", VA = "0x188BC7750", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7690", Offset = "0x8BC6090", VA = "0x188BC7690", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NIGMLAABFAO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7690", Offset = "0x8BC6090", VA = "0x188BC7690", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private static readonly NIGMLAABFAO KJDEHOPAJML;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private static readonly Dictionary<Type, int> KEONGFKLDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly HashSet<Type> LECLNHPKPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	private readonly GADICPECNAL<int> FAHNFMGFBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	private readonly GADICPECNAL<GDOCEFMALCF> MKBDOBBNDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	private readonly GADICPECNAL<DEKJMIEOLAL> DEGAEBDHBFN;

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3F30", Offset = "0x8BC2930", VA = "0x188BC3F30")]
	[PPMDKOHJEBA.KMGFFEOOKKA.HAOMKJDLLID]
	internal static void CPNCCEEHJEL(CFAMNNNCHJA GEPFIGLFPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x8BC4E30", Offset = "0x8BC3830", VA = "0x188BC4E30")]
	[RecRoom.NoEngine.Common.Preserve]
	public LLANLIAPHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x3C75FA0", Offset = "0x3C749A0", VA = "0x183C75FA0", Slot = "4")]
	public ACLFDGAMIOP<T> NJCCMOKDBLO<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x8BC42B0", Offset = "0x8BC2CB0", VA = "0x188BC42B0", Slot = "5")]
	public DEJNPCOHMHD JJOLMEEFLKP(Exception HPIGFEEDBKD)
	{
		return default(DEJNPCOHMHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x8BC4710", Offset = "0x8BC3110", VA = "0x188BC4710", Slot = "6")]
	public NIGMLAABFAO MOPBNAINPIN(Exception? HPIGFEEDBKD)
	{
		return default(NIGMLAABFAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x8BC4910", Offset = "0x8BC3310", VA = "0x188BC4910", Slot = "7")]
	[IteratorStateMachine(typeof(NFIBOEFFBAF))]
	public IEnumerable<NIGMLAABFAO> OEDMABLPFDD(Exception HPIGFEEDBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3A30", Offset = "0x8BC2430", VA = "0x188BC3A30", Slot = "8")]
	public string AOFGCEEHPDB(Exception? HPIGFEEDBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3FA0", Offset = "0x8BC29A0", VA = "0x188BC3FA0")]
	private string DPEBAOFGGJH(AggregateException AHBOOKEKDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3B80", Offset = "0x8BC2580", VA = "0x188BC3B80")]
	private void BIMOANBECNB(Type HDMDLOPLAMI, int EKKNDADGPGC, GDOCEFMALCF? DHEJLCLGOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x8BC44C0", Offset = "0x8BC2EC0", VA = "0x188BC44C0")]
	private void MKCHPMOLALM(Type HDMDLOPLAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x8BC4A90", Offset = "0x8BC3490", VA = "0x188BC4A90")]
	private void PDDINLDOHDB(Type HDMDLOPLAMI, DEKJMIEOLAL GCFAPNKHGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x8BC4340", Offset = "0x8BC2D40", VA = "0x188BC4340")]
	private static int KEBICNAGLDO(Type HDMDLOPLAMI, Dictionary<Type, int> LILBACFPPDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x3D497D0", Offset = "0x3D481D0", VA = "0x183D497D0")]
	private static bool DKCFKCAGPGD<TVal>(GADICPECNAL<TVal> EJKNLPOFFNN, Type HDMDLOPLAMI, [Out] TVal PDKJBMPOMNC) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8BC49B0", Offset = "0x8BC33B0", VA = "0x188BC49B0")]
	[CompilerGenerated]
	internal static int OGOONKGGABG(Type CFDIMNGKPFK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public struct DEJNPCOHMHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public readonly NIGMLAABFAO BNCAPCFBCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public readonly string NOBDHDGOJKP;

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x8BB83B0", Offset = "0x8BB6DB0", VA = "0x188BB83B0")]
	public DEJNPCOHMHD(string KDMACEDOPGP, NIGMLAABFAO EKKNDADGPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x8BB8310", Offset = "0x8BB6D10", VA = "0x188BB8310")]
	public string ANHKCPCBLKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class CBEFKDIMHCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private readonly OEDJIHBFGCK FLOAIEFIAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private string OLGICJIHHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private long? BLEANGHAOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private long? KMPEPJALNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private long? AAJBGLHEKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private string NPFIAIIFHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private KNOBEKJADBE KKNHLFLLPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private long? MKOEGIABDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private bool PIGDGNIOIBK;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public string MGHHEGADPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public long DDPJIEBCMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6320", Offset = "0x8BB4D20", VA = "0x188BB6320")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public long LLJHHDHPDFF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6890", Offset = "0x8BB5290", VA = "0x188BB6890")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public long NLAOMOLIIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6070", Offset = "0x8BB4A70", VA = "0x188BB6070")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string NHCAKMOJCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6D80", Offset = "0x8BB5780", VA = "0x188BB6D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public KNOBEKJADBE MKGAPANFPMC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xAE78E0", Offset = "0xAE62E0", VA = "0x180AE78E0")]
		get
		{
			return default(KNOBEKJADBE);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6700", Offset = "0x8BB5100", VA = "0x188BB6700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public long NHNLCFCHCDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6010", Offset = "0x8BB4A10", VA = "0x188BB6010")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x8BB6DC0", Offset = "0x8BB57C0", VA = "0x188BB6DC0")]
	[UnityEngine.Scripting.Preserve]
	public CBEFKDIMHCC([LNLOHEINMEO(null)] OEDJIHBFGCK FLOAIEFIAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x8BB60D0", Offset = "0x8BB4AD0", VA = "0x188BB60D0")]
	private void IEOCNMJINNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x8BB68F0", Offset = "0x8BB52F0", VA = "0x188BB68F0")]
	public void OODLFOJBDEH(long DKMPIOFKFMN, long JOIKPPGBGCF, [Optional] long? MNAMJIAHNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x8BB67F0", Offset = "0x8BB51F0", VA = "0x188BB67F0")]
	public void KBJCOGCGINN(long MNAMJIAHNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x8BB5F90", Offset = "0x8BB4990", VA = "0x188BB5F90")]
	public void AECAIBOJHLJ(string JEICIMIGOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x8BB6380", Offset = "0x8BB4D80", VA = "0x188BB6380")]
	public void IPEGHPPCGFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class OHBMAKCLEEN : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct EICKGEEFHEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public AsyncTaskMethodBuilder<FPMLGPKCMLB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public FPMLGPKCMLB roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public OHBMAKCLEEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private TaskAwaiter<MMKEEKNGMFG.BOIILJMBJMC<FPMLGPKCMLB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB7F0", Offset = "0x8BBA1F0", VA = "0x188BBB7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBD30", Offset = "0x8BBA730", VA = "0x188BBBD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct BOCFGHGLBBF<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class HHKJEIFGPJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public FPMLGPKCMLB roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public HHKJEIFGPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF440", Offset = "0x8BBDE40", VA = "0x188BBF440")]
		internal FPMLGPKCMLB JFMJHKEIOKG(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct PGKAHOJFKIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public AsyncTaskMethodBuilder<MMKEEKNGMFG.BOIILJMBJMC<FPMLGPKCMLB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public FPMLGPKCMLB roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public OHBMAKCLEEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private KKPCJHOPEAB <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private TaskAwaiter<MMKEEKNGMFG.BOIILJMBJMC<FPMLGPKCMLB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x8BCDA90", Offset = "0x8BCC490", VA = "0x188BCDA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE0A0", Offset = "0x8BCCAA0", VA = "0x188BCE0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct NAHHCGPLBBO<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public OHBMAKCLEEN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x589BA20", Offset = "0x589A420", VA = "0x18589BA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x4947CC0", Offset = "0x49466C0", VA = "0x184947CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct AMMLNPODBBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public OHBMAKCLEEN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8BB4380", Offset = "0x8BB2D80", VA = "0x188BB4380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4660", Offset = "0x8BB3060", VA = "0x188BB4660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class HALFACIHMOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public HALFACIHMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x8BBED00", Offset = "0x8BBD700", VA = "0x188BBED00")]
		internal object BKINCCKKKKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x8BBED60", Offset = "0x8BBD760", VA = "0x188BBED60")]
		internal bool KCBNOLOFHHA(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class JCBFEDGMHDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public JCBFEDGMHDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x8BC00F0", Offset = "0x8BBEAF0", VA = "0x188BC00F0")]
		internal object LHFDGFDIOMK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class LKBGFBCCPHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LKBGFBCCPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x8BC39C0", Offset = "0x8BC23C0", VA = "0x188BC39C0")]
		internal object KKLKAHNDFNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class GMAJMOBEAIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GMAJMOBEAIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x8BBEA70", Offset = "0x8BBD470", VA = "0x188BBEA70")]
		internal object OOLHPBCNEKL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class GJBEOFBAOIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public OHBMAKCLEEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GJBEOFBAOIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE070", Offset = "0x8BBCA70", VA = "0x188BBE070")]
		internal object MLDOMOIGEBM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private static readonly Guid BFOMFNBCBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public readonly MFDOGKHNMAA JKEEOHKCKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	private readonly MMKEEKNGMFG LDNGPGNBIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	private readonly MBGCJNMBOPE HFINBJNJOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	private readonly NFEEIPGCNPI OKALIMNNJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	private bool IGKNGGIGAAE;

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x8BCB580", Offset = "0x8BC9F80", VA = "0x188BCB580")]
	public OHBMAKCLEEN(MFDOGKHNMAA EANMJMPIOGJ, MMKEEKNGMFG LDNGPGNBIBM, MBGCJNMBOPE HFINBJNJOEI, NFEEIPGCNPI OKALIMNNJLO, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x8BCAAF0", Offset = "0x8BC94F0", VA = "0x188BCAAF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x8BCAC80", Offset = "0x8BC9680", VA = "0x188BCAC80")]
	public void EJJLKDKNDLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x8BCB080", Offset = "0x8BC9A80", VA = "0x188BCB080")]
	public void MFKKAHKKFGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x8BCAFC0", Offset = "0x8BC99C0", VA = "0x188BCAFC0")]
	public void KFAEPGCAOFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x8BCB3B0", Offset = "0x8BC9DB0", VA = "0x188BCB3B0")]
	[AsyncStateMachine(typeof(EICKGEEFHEN))]
	internal Task<FPMLGPKCMLB> PIDLNGPOJKL(OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, FPMLGPKCMLB LOLEDACMADE, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x3E498C0", Offset = "0x3E482C0", VA = "0x183E498C0")]
	private static byte[] AHKJNEGIJID<T>(T ONGDPODJNBL) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x3E49E80", Offset = "0x3E48880", VA = "0x183E49E80")]
	private static T FCGMIJAKIPC<T>(MessageParser<T> NNAHCIHBEEM, byte[] ONGDPODJNBL, T PJNPFAHFNHF) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA370", Offset = "0x8BC8D70", VA = "0x188BCA370")]
	[AsyncStateMachine(typeof(PGKAHOJFKIP))]
	private Task<MMKEEKNGMFG.BOIILJMBJMC<FPMLGPKCMLB>> AFGDLCIIEHK(FPMLGPKCMLB LOLEDACMADE, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x3E498D0", Offset = "0x3E482D0", VA = "0x183E498D0")]
	[AsyncStateMachine(typeof(NAHHCGPLBBO<>))]
	internal Task<T> DBCNMGDAODG<T>(CancellationToken BOJKDJLCGKE, Func<CancellationToken, Task<T>> CJPGBIPFOJN, int NGAAAMCJNHE = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA750", Offset = "0x8BC9150", VA = "0x188BCA750")]
	[AsyncStateMachine(typeof(AMMLNPODBBF))]
	internal Task DBCNMGDAODG(CancellationToken BOJKDJLCGKE, Func<CancellationToken, Task> CJPGBIPFOJN, int NGAAAMCJNHE = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x8BCAEB0", Offset = "0x8BC98B0", VA = "0x188BCAEB0")]
	public ENFPHAGBADI HCILLGPBION()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x8BCAF30", Offset = "0x8BC9930", VA = "0x188BCAF30")]
	public OPJFDBCJMPI KCLHAHAFPGO([Optional] AAHPIJDFAJG BGBIDLFABMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA880", Offset = "0x8BC9280", VA = "0x188BCA880")]
	public BDPABHELFBH DJNJEKBFBGB([Optional] MEBJEIOEDLD? HJHMNJLNNBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x8BCB140", Offset = "0x8BC9B40", VA = "0x188BCB140")]
	public void NGKAFLMLBHD(Func<Guid, bool> HNMAJCLPKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA500", Offset = "0x8BC8F00", VA = "0x188BCA500")]
	public void CHJIFJCMCJG(Func<Guid, bool> OOIAPCLCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x8BCAB00", Offset = "0x8BC9500", VA = "0x188BCAB00")]
	public Guid EFICBJGBNAO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x8BCB2A0", Offset = "0x8BC9CA0", VA = "0x188BCB2A0")]
	public void OIMLLMLLIMP(Guid EPMENFOHPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA610", Offset = "0x8BC9010", VA = "0x188BCA610")]
	public void CKBHPFHNIGK(FPMLGPKCMLB FIPOKBINNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x8BCADA0", Offset = "0x8BC97A0", VA = "0x188BCADA0")]
	public void GCLDEHJKFHJ(string DAKOMDCOLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x3E49B50", Offset = "0x3E48550", VA = "0x183E49B50")]
	private T DEMOHJJMKHH<T>(T PDKJBMPOMNC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA4B0", Offset = "0x8BC8EB0", VA = "0x188BCA4B0")]
	public void BCKAENHBHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x3E49BD0", Offset = "0x3E485D0", VA = "0x183E49BD0")]
	[CompilerGenerated]
	internal static string EKOPEKOLFAL<T>(byte[] LHALFHPGBPD, int OFPHGCJEELB, BOCFGHGLBBF<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal sealed class MHHNEOGOJBK : MFDOGKHNMAA
{
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class LPECALAEGOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LPECALAEGOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x8BC51E0", Offset = "0x8BC3BE0", VA = "0x188BC51E0")]
		internal object OKDDNCMJJLP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct FLEDJNOIKJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public MHHNEOGOJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public OHBMAKCLEEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private DKMBMPCHLAM <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private OPJFDBCJMPI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private TaskAwaiter<MGHKBAFLJKK> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC220", Offset = "0x8BBAC20", VA = "0x188BBC220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD120", Offset = "0x8BBBB20", VA = "0x188BBD120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct DBCLGAJGCJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public MHHNEOGOJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private TaskAwaiter<DJEKJMDOAHO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7B10", Offset = "0x8BB6510", VA = "0x188BB7B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x8BB82B0", Offset = "0x8BB6CB0", VA = "0x188BB82B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct IGJLFEADMEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public MHHNEOGOJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private TaskAwaiter<BBOGCAENLMO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF820", Offset = "0x8BBE220", VA = "0x188BBF820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x8BBFB30", Offset = "0x8BBE530", VA = "0x188BBFB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class CHJPIEFKMAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public DKMBMPCHLAM presence;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public CHJPIEFKMAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6E00", Offset = "0x8BB5800", VA = "0x188BB6E00")]
		internal object FBPINOHGJAJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private static readonly MEBJEIOEDLD HPABEMJCJLD;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private static readonly MEBJEIOEDLD ANDJKBDAGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private readonly MLFBJBKAEMO CHONICAIHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly FIICLMFOJBM DGNADGIHMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly AAHPIJDFAJG BGBIDLFABMF;

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x8BC6ED0", Offset = "0x8BC58D0", VA = "0x188BC6ED0")]
	public MHHNEOGOJBK(MLFBJBKAEMO CHONICAIHNE, FIICLMFOJBM DGNADGIHMEI, Guid BJGNCPGGOCA, PKEIPCLCGCJ MBIPODKGFBO, CDEDAAICECI CEBGJIPJABJ, AAHPIJDFAJG BGBIDLFABMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x8BC68B0", Offset = "0x8BC52B0", VA = "0x188BC68B0", Slot = "7")]
	[AsyncStateMachine(typeof(FLEDJNOIKJC))]
	protected override Task EMFKCELOICB(OHBMAKCLEEN KGCEDLPDMEO, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC6CF0", Offset = "0x8BC56F0", VA = "0x188BC6CF0")]
	[AsyncStateMachine(typeof(DBCLGAJGCJO))]
	private Task ODDEIDFPBAL(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x8BC6A00", Offset = "0x8BC5400", VA = "0x188BC6A00")]
	[AsyncStateMachine(typeof(IGJLFEADMEN))]
	private Task<int> GBEIGKEOABL(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x8BC6B10", Offset = "0x8BC5510", VA = "0x188BC6B10")]
	private DKMBMPCHLAM NPGPKFAGHCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal class MEKPJBCGGCO : MFDOGKHNMAA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct BPGHKFHCMEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public MEKPJBCGGCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public OHBMAKCLEEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private TaskAwaiter<JCHGMBODNBK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4D00", Offset = "0x8BB3700", VA = "0x188BB4D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB56B0", Offset = "0x8BB40B0", VA = "0x188BB56B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly int EGKCCCDBIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly JBJNNHCHIGL CMMNIMNPMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public readonly long EDCJBBOOIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public readonly long AEGMDMADPMJ;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public JCHGMBODNBK NJPMKDEJKBA
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xA909D0", Offset = "0xA8F3D0", VA = "0x180A909D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xA90970", Offset = "0xA8F370", VA = "0x180A90970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC5820", Offset = "0x8BC4220", VA = "0x188BC5820")]
	public MEKPJBCGGCO(Guid BJGNCPGGOCA, PKEIPCLCGCJ MBIPODKGFBO, CDEDAAICECI CEBGJIPJABJ, int EGKCCCDBIIJ, JBJNNHCHIGL CMMNIMNPMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x8BC5700", Offset = "0x8BC4100", VA = "0x188BC5700", Slot = "7")]
	[AsyncStateMachine(typeof(BPGHKFHCMEF))]
	protected override Task EMFKCELOICB(OHBMAKCLEEN KGCEDLPDMEO, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal abstract class JLIPDABHKCF : MFDOGKHNMAA
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class PJINCBHBAKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public JLIPDABHKCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public MOGNBOBBCBH playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PJINCBHBAKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE560", Offset = "0x8BCCF60", VA = "0x188BCE560")]
		internal Task IHEPKKGBJNK(OGMJCPNEHOO<string>.LOEEEDILNMC postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE4D0", Offset = "0x8BCCED0", VA = "0x188BCE4D0")]
		internal object DFMADNABPOO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct NHJCIOEHNNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public JLIPDABHKCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public OHBMAKCLEEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private PJINCBHBAKJ <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x8BC7A80", Offset = "0x8BC6480", VA = "0x188BC7A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x8BC83E0", Offset = "0x8BC6DE0", VA = "0x188BC83E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct HEKGPFOHAOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public MOGNBOBBCBH playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public JLIPDABHKCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBEE20", Offset = "0x8BBD820", VA = "0x188BBEE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF3E0", Offset = "0x8BBDDE0", VA = "0x188BBF3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x8BC0AD0", Offset = "0x8BBF4D0", VA = "0x188BC0AD0")]
	public JLIPDABHKCF(Guid BJGNCPGGOCA, PKEIPCLCGCJ MBIPODKGFBO, CDEDAAICECI CEBGJIPJABJ, string MDFCKJGHEDG, DJILFCNIHBH NLGPIOCMJCE, bool CMMFGMGHMNO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x8BC0920", Offset = "0x8BBF320", VA = "0x188BC0920", Slot = "7")]
	[AsyncStateMachine(typeof(NHJCIOEHNNN))]
	protected override Task EMFKCELOICB(OHBMAKCLEEN KGCEDLPDMEO, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task JGMFHCFDGOH(OHBMAKCLEEN KGCEDLPDMEO, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x8BC07E0", Offset = "0x8BBF1E0", VA = "0x188BC07E0")]
	[AsyncStateMachine(typeof(HEKGPFOHAOH))]
	private Task CIJFAHMJHCG(IDisposable NFMHNBEJECK, MOGNBOBBCBH MMMJNOHBMLA, OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal class MGBAGIFKFEG : MFDOGKHNMAA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct DAHHFCHHHOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public MGBAGIFKFEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public OHBMAKCLEEN operationContext;

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
		private TaskAwaiter<HNFMIDJGFGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7520", Offset = "0x8BB5F20", VA = "0x188BB7520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7AB0", Offset = "0x8BB64B0", VA = "0x188BB7AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	private readonly AHLLAMLIAPD MJAEFDLBIKK;

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC6810", Offset = "0x8BC5210", VA = "0x188BC6810")]
	public MGBAGIFKFEG(Guid BJGNCPGGOCA, PKEIPCLCGCJ MBIPODKGFBO, CDEDAAICECI CEBGJIPJABJ, AHLLAMLIAPD MJAEFDLBIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x8BC6730", Offset = "0x8BC5130", VA = "0x188BC6730", Slot = "6")]
	protected override string NFLODOPMHDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x8BC6610", Offset = "0x8BC5010", VA = "0x188BC6610", Slot = "7")]
	[AsyncStateMachine(typeof(DAHHFCHHHOG))]
	protected override Task EMFKCELOICB(OHBMAKCLEEN KGCEDLPDMEO, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal abstract class MFDOGKHNMAA : BPLKMOAGFGN
{
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	public delegate Task DFGCHCLKLCO(OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class OBDJNPCLKHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public MFDOGKHNMAA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public OBDJNPCLKHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x8BC9360", Offset = "0x8BC7D60", VA = "0x188BC9360")]
		internal Task AMMDGKEAFDC(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class NDJMBNJLNDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public OBDJNPCLKHL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public NDJMBNJLNDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7080", Offset = "0x8BC5A80", VA = "0x188BC7080")]
		internal object IBMBGJCIJKH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct PMLCBOJBPMC : IAsyncStateMachine
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
		public MFDOGKHNMAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public Func<MFDOGKHNMAA, OGMJCPNEHOO<string>.LOEEEDILNMC, OHBMAKCLEEN> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private OBDJNPCLKHL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private OHBMAKCLEEN <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private TaskAwaiter<FPMLGPKCMLB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE620", Offset = "0x8BCD020", VA = "0x188BCE620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x8BCF930", Offset = "0x8BCE330", VA = "0x188BCF930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct KJLJHLJPJEA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8BC2EC0", Offset = "0x8BC18C0", VA = "0x188BC2EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3960", Offset = "0x8BC2360", VA = "0x188BC3960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct PHJPBJBOBNA : IAsyncStateMachine
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
		public MFDOGKHNMAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE110", Offset = "0x8BCCB10", VA = "0x188BCE110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE470", Offset = "0x8BCCE70", VA = "0x188BCE470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public readonly Guid MOHCIPMJKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public readonly ByteString LICKJEIMAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public readonly CDEDAAICECI FFAELJCECNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	protected readonly string JHDDKHODNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private readonly PKEIPCLCGCJ MBIPODKGFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private readonly bool CMMFGMGHMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private readonly Queue<DFGCHCLKLCO> EILEJLKJCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private readonly EHPANNKFGMM DPBEOGOPKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private readonly DJILFCNIHBH NLGPIOCMJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private bool JDDDBDDNFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public KNOBEKJADBE GILGFCGBBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public KNOBEKJADBE CJOCNNLPDPD;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public PKEIPCLCGCJ CACGEGMOACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public KGCDOOPNJBJ NJNPDNFAPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x8BC60E0", Offset = "0x8BC4AE0", VA = "0x188BC60E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public LLCOCPCCELB BJOKDEICJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6460", Offset = "0x8BC4E60", VA = "0x188BC6460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public NIIBNLNBABL HLKOBEKBMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x8BC63E0", Offset = "0x8BC4DE0", VA = "0x188BC63E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event KOCNCIFIKJM EFCJNAENKFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6280", Offset = "0x8BC4C80", VA = "0x188BC6280", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5950", Offset = "0x8BC4350", VA = "0x188BC5950", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x8BC64B0", Offset = "0x8BC4EB0", VA = "0x188BC64B0")]
	protected MFDOGKHNMAA(Guid BJGNCPGGOCA, PKEIPCLCGCJ MBIPODKGFBO, CDEDAAICECI CEBGJIPJABJ, string MDFCKJGHEDG, DJILFCNIHBH NLGPIOCMJCE, bool CMMFGMGHMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x8BC62A0", Offset = "0x8BC4CA0", VA = "0x188BC62A0", Slot = "6")]
	protected virtual string NFLODOPMHDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x8BC5E30", Offset = "0x8BC4830", VA = "0x188BC5E30")]
	public void FAJDAIOOOKG(DFGCHCLKLCO JIDFLIOODEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x8BC5E90", Offset = "0x8BC4890", VA = "0x188BC5E90")]
	protected void GDKEPHCAGJB(float DJKLMOIIBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x8BC6130", Offset = "0x8BC4B30", VA = "0x188BC6130")]
	[AsyncStateMachine(typeof(PMLCBOJBPMC))]
	public Task JCNNIFHFEKH(CancellationToken OMJKEHOJJFF, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, [Optional] Func<MFDOGKHNMAA, OGMJCPNEHOO<string>.LOEEEDILNMC, OHBMAKCLEEN> KNCDKBFOBOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC5A90", Offset = "0x8BC4490", VA = "0x188BC5A90")]
	[AsyncStateMachine(typeof(KJLJHLJPJEA))]
	private static Task ANPNKLDMMPD(Func<CancellationToken, Task> LDDNAHPBAHI, Func<CancellationToken, Task> NMGPLECMAFC, CancellationToken BOJKDJLCGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x8BC5BC0", Offset = "0x8BC45C0", VA = "0x188BC5BC0")]
	private void BFACKKACOFI(bool CEHCEBOGFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x8BC5EB0", Offset = "0x8BC48B0", VA = "0x188BC5EB0")]
	private void GIBMMOEMHAP(OHBMAKCLEEN KGCEDLPDMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task EMFKCELOICB(OHBMAKCLEEN KGCEDLPDMEO, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x8BC5970", Offset = "0x8BC4370", VA = "0x188BC5970")]
	[AsyncStateMachine(typeof(PHJPBJBOBNA))]
	private Task AKNAOBKLADP(OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x8BC62E0", Offset = "0x8BC4CE0", VA = "0x188BC62E0")]
	public FPMLGPKCMLB PFOENEAEDDO(KKPCJHOPEAB BGNENLDKPEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x8BC5D40", Offset = "0x8BC4740", VA = "0x188BC5D40")]
	[CompilerGenerated]
	private Task CADAKKBNBCM(CancellationToken JCAFCJGCHAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x8BC6360", Offset = "0x8BC4D60", VA = "0x188BC6360")]
	[CompilerGenerated]
	private object PGIIJOMJEKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal sealed class GPFKOJANBPC : JLIPDABHKCF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct GKIAJOGFIGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public GPFKOJANBPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public OHBMAKCLEEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private CBIENAKDHBL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private OPJFDBCJMPI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE2B0", Offset = "0x8BBCCB0", VA = "0x188BBE2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x8BBEA10", Offset = "0x8BBD410", VA = "0x188BBEA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private readonly MLFBJBKAEMO LOEDCEJLCIE;

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x8BBEC30", Offset = "0x8BBD630", VA = "0x188BBEC30")]
	public GPFKOJANBPC(Guid BJGNCPGGOCA, PKEIPCLCGCJ MBIPODKGFBO, MLFBJBKAEMO LOEDCEJLCIE, CDEDAAICECI CEBGJIPJABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x8BBEAE0", Offset = "0x8BBD4E0", VA = "0x188BBEAE0", Slot = "8")]
	[AsyncStateMachine(typeof(GKIAJOGFIGF))]
	protected override Task JGMFHCFDGOH(OHBMAKCLEEN KGCEDLPDMEO, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal class ELPBHFPCJFN : MFDOGKHNMAA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct INKKMPIDODF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public ELPBHFPCJFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public OHBMAKCLEEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private TaskAwaiter<HNFMIDJGFGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x8BBFBA0", Offset = "0x8BBE5A0", VA = "0x188BBFBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x8BBFF50", Offset = "0x8BBE950", VA = "0x188BBFF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private readonly string EHLDAOMNLDA;

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x8BBBEB0", Offset = "0x8BBA8B0", VA = "0x188BBBEB0")]
	public ELPBHFPCJFN(Guid BJGNCPGGOCA, PKEIPCLCGCJ MBIPODKGFBO, CDEDAAICECI CEBGJIPJABJ, string EHLDAOMNLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x8BBBDA0", Offset = "0x8BBA7A0", VA = "0x188BBBDA0", Slot = "7")]
	[AsyncStateMachine(typeof(INKKMPIDODF))]
	protected override Task EMFKCELOICB(OHBMAKCLEEN KGCEDLPDMEO, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal class GIKELBGGJOA : JLIPDABHKCF
{
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private sealed class CKLIGACPGAK
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
			public AsyncTaskMethodBuilder<FPMLGPKCMLB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			public CKLIGACPGAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			private TaskAwaiter<HNFMIDJGFGN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			private TaskAwaiter<FPMLGPKCMLB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0x8BCFFA0", Offset = "0x8BCE9A0", VA = "0x188BCFFA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0x8BD0490", Offset = "0x8BCEE90", VA = "0x188BD0490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public GIKELBGGJOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public BDPABHELFBH serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public OCOGPPDAFJO roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public ENFPHAGBADI uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public GFFHLOLHICK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public CKLIGACPGAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7400", Offset = "0x8BB5E00", VA = "0x188BB7400")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<FPMLGPKCMLB> GGKMMFOIFHJ(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct OEEBIJLIGCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public GIKELBGGJOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public OHBMAKCLEEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private CKLIGACPGAK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private CBIENAKDHBL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private OPJFDBCJMPI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private FPMLGPKCMLB <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private TaskAwaiter<FPMLGPKCMLB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x8BC9490", Offset = "0x8BC7E90", VA = "0x188BC9490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA310", Offset = "0x8BC8D10", VA = "0x188BCA310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	private static readonly MEBJEIOEDLD HPABEMJCJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private readonly int BIJMEFDNJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	[CanBeNull]
	private readonly BBLKGPIDOCC FEBMKDPBPHE;

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x8BBD990", Offset = "0x8BBC390", VA = "0x188BBD990")]
	public GIKELBGGJOA(Guid BJGNCPGGOCA, PKEIPCLCGCJ MBIPODKGFBO, int BIJMEFDNJBK, BBLKGPIDOCC FEBMKDPBPHE, CDEDAAICECI CEBGJIPJABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x8BBD6A0", Offset = "0x8BBC0A0", VA = "0x188BBD6A0", Slot = "8")]
	[AsyncStateMachine(typeof(OEEBIJLIGCC))]
	protected override Task JGMFHCFDGOH(OHBMAKCLEEN KGCEDLPDMEO, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x8BBD7E0", Offset = "0x8BBC1E0", VA = "0x188BBD7E0")]
	private void KCOGBILEIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x8BBD4D0", Offset = "0x8BBBED0", VA = "0x188BBD4D0")]
	private void AHPEELKFDNG(OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CBIENAKDHBL JCKBCDHGAGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal class LPPDAOOBPLN : MFDOGKHNMAA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct DHIONEHGNOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public LPPDAOOBPLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private CBIENAKDHBL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private BBOGCAENLMO <currentRoomSave>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private FDLGIOOGFEJ<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private TaskAwaiter<BBOGCAENLMO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private TaskAwaiter<JCHGMBODNBK> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private TaskAwaiter <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8520", Offset = "0x8BB6F20", VA = "0x188BB8520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9950", Offset = "0x8BB8350", VA = "0x188BB9950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	private readonly int BIJMEFDNJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	private readonly BBLKGPIDOCC FEBMKDPBPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	private Func<HNFMIDJGFGN, HNFMIDJGFGN> HEDBLNILIGI;

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x8BC5380", Offset = "0x8BC3D80", VA = "0x188BC5380")]
	public LPPDAOOBPLN(Guid BJGNCPGGOCA, PKEIPCLCGCJ MBIPODKGFBO, int BIJMEFDNJBK, BBLKGPIDOCC FEBMKDPBPHE, Func<HNFMIDJGFGN, HNFMIDJGFGN> HEDBLNILIGI, CDEDAAICECI CEBGJIPJABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x8BC5250", Offset = "0x8BC3C50", VA = "0x188BC5250", Slot = "7")]
	[AsyncStateMachine(typeof(DHIONEHGNOM))]
	protected override Task EMFKCELOICB(OHBMAKCLEEN KGCEDLPDMEO, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal abstract class ENMMKPENCJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public readonly MFDOGKHNMAA JKEEOHKCKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public readonly OHBMAKCLEEN EFKDHNJDPBG;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public KGCDOOPNJBJ NJNPDNFAPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC0E0", Offset = "0x8BBAAE0", VA = "0x188BBC0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public NIIBNLNBABL HLKOBEKBMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC130", Offset = "0x8BBAB30", VA = "0x188BBC130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x8BBC1C0", Offset = "0x8BBABC0", VA = "0x188BBC1C0")]
	protected ENMMKPENCJF(OHBMAKCLEEN KGCEDLPDMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x8BBBFC0", Offset = "0x8BBA9C0", VA = "0x188BBBFC0")]
	protected void GCLDEHJKFHJ(string DAKOMDCOLPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct GIKEOCBMNEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public Dictionary<Guid, List<KLGCNLILPBP>> ENEPPDEJPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public Dictionary<Guid, List<KLGCNLILPBP>> ILNDEOFIGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public Dictionary<Guid, List<KLGCNLILPBP>> DMJBKNFAOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public List<Guid> HFOHGIJDFJN;

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x8BBDA60", Offset = "0x8BBC460", VA = "0x188BBDA60")]
	public static GIKEOCBMNEF DHBICMHDGKM(KGCDOOPNJBJ JDNAAPNIDID, KNOBEKJADBE EBODKBGKJOH, ALPHANGLKLD COOMMKFGFGC)
	{
		return default(GIKEOCBMNEF);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct EMLEDBMPBGN
{
	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480")]
	public static EMLEDBMPBGN OIDBKGGJJLH()
	{
		return default(EMLEDBMPBGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct NGBABHAHMPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public readonly DJEKJMDOAHO GADEDFJOCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public readonly DBNKIMCJKJK ECKHOBBHDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public readonly Guid? IDCJGBECDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public readonly IReadOnlyCollection<MMFCCBABPAO> PIMOKNPHILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public readonly IReadOnlyCollection<MMFCCBABPAO> KFJJDJLBCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public readonly HCMJMHBJMFG MFNLMEFHDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public readonly HCMJMHBJMFG IDBNBOBAMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public readonly MGLMPLLOJJF BFFIDPCBGEB;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool CDHGEAECKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7940", Offset = "0x8BC6340", VA = "0x188BC7940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x8BC79D0", Offset = "0x8BC63D0", VA = "0x188BC79D0")]
	public NGBABHAHMPG(DJEKJMDOAHO GADEDFJOCGJ, DBNKIMCJKJK ECKHOBBHDON, Guid? IDCJGBECDDM, IReadOnlyList<MMFCCBABPAO> PIMOKNPHILO, IReadOnlyCollection<MMFCCBABPAO> KFJJDJLBCCL, HCMJMHBJMFG MFNLMEFHDNI, HCMJMHBJMFG IDBNBOBAMJH, MGLMPLLOJJF BFFIDPCBGEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct CIECOMEEAML : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private readonly OHBMAKCLEEN KGCEDLPDMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private readonly Guid EPMENFOHPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private bool CEHCEBOGFEO;

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x8BB6FF0", Offset = "0x8BB59F0", VA = "0x188BB6FF0")]
	public static CIECOMEEAML EFICBJGBNAO(OHBMAKCLEEN KGCEDLPDMEO)
	{
		return default(CIECOMEEAML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x136D4A0", Offset = "0x136BEA0", VA = "0x18136D4A0")]
	public void LFJPMAPNGML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x8BB6FE0", Offset = "0x8BB59E0", VA = "0x188BB6FE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x8BB7260", Offset = "0x8BB5C60", VA = "0x188BB7260")]
	private CIECOMEEAML(OHBMAKCLEEN KGCEDLPDMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x8BB7020", Offset = "0x8BB5A20", VA = "0x188BB7020")]
	private void OIMLLMLLIMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x8BB6F40", Offset = "0x8BB5940", VA = "0x188BB6F40")]
	private Func<Guid, bool> BCEGMPIEENJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
internal class OPJFDBCJMPI : ENMMKPENCJF, BPLKMOAGFGN
{
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	public delegate Task<KNOBEKJADBE> FPJBOCJPIBC(ALPHANGLKLD GPCDCFCPGFK, HEJNJNBOEGM OMGGNFMAEIC, EHPANNKFGMM GBHDJAGLPBM, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct DLOCKFAFAIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public MLFBJBKAEMO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private CIECOMEEAML <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private TaskAwaiter<FPMLGPKCMLB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BD7310", Offset = "0x8BD5D10", VA = "0x188BD7310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x8BD7A60", Offset = "0x8BD6460", VA = "0x188BD7A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct NADINGDEDPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public AsyncTaskMethodBuilder<FPMLGPKCMLB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public MLFBJBKAEMO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private TaskAwaiter<FPMLGPKCMLB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x8BE1D30", Offset = "0x8BE0730", VA = "0x188BE1D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2160", Offset = "0x8BE0B60", VA = "0x188BE2160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct JJEEIHIMHBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public MLFBJBKAEMO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x8BDEEC0", Offset = "0x8BDD8C0", VA = "0x188BDEEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x8BDF380", Offset = "0x8BDDD80", VA = "0x188BDF380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class FNIDLMCDBDH
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
			public AsyncTaskMethodBuilder<NGBABHAHMPG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			public FNIDLMCDBDH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			private NGBABHAHMPG <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			private TaskAwaiter<KNOBEKJADBE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000516")]
			private TaskAwaiter<NGBABHAHMPG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x8BE6290", Offset = "0x8BE4C90", VA = "0x188BE6290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x8BE6B50", Offset = "0x8BE5550", VA = "0x188BE6B50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<ALPHANGLKLD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000519")]
			public FNIDLMCDBDH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400051A")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400051B")]
			private ALPHANGLKLD <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			private TaskAwaiter<KNOBEKJADBE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			private TaskAwaiter<ALPHANGLKLD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x8BE6BC0", Offset = "0x8BE55C0", VA = "0x188BE6BC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x8BE7210", Offset = "0x8BE5C10", VA = "0x188BE7210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public MLFBJBKAEMO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public EHPANNKFGMM preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public EHPANNKFGMM downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public NGBABHAHMPG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public EHPANNKFGMM postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public ALPHANGLKLD phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public NPHFKKEFGIB.LLDFOILIDAI <>9__5;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public FNIDLMCDBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9CD0", Offset = "0x8BD86D0", VA = "0x188BD9CD0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<NGBABHAHMPG> MNGMIOCNFEP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9BB0", Offset = "0x8BD85B0", VA = "0x188BD9BB0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<ALPHANGLKLD> GMFHDLMKOBI(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9B70", Offset = "0x8BD8570", VA = "0x188BD9B70")]
		internal void GKECDBJJCMK(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9AF0", Offset = "0x8BD84F0", VA = "0x188BD9AF0")]
		internal Task EBMEEBDPFOD(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9B30", Offset = "0x8BD8530", VA = "0x188BD9B30")]
		internal Task FBMJGJNJDCC(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct MBLACMBABAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public MLFBJBKAEMO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private FNIDLMCDBDH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter<NGBABHAHMPG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private TaskAwaiter<ALPHANGLKLD> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8BE0470", Offset = "0x8BDEE70", VA = "0x188BE0470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x8BE1140", Offset = "0x8BDFB40", VA = "0x188BE1140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct HBPBALHPIDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public ALPHANGLKLD phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public EHPANNKFGMM postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private TaskAwaiter<KNOBEKJADBE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private HEJNJNBOEGM <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x8BDB220", Offset = "0x8BD9C20", VA = "0x188BDB220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x8BDC080", Offset = "0x8BDAA80", VA = "0x188BDC080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct CFIIOLBPNBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x8BD5760", Offset = "0x8BD4160", VA = "0x188BD5760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x8BD5F40", Offset = "0x8BD4940", VA = "0x188BD5F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct DKBIBFKKECI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public EHPANNKFGMM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private TaskAwaiter<KNOBEKJADBE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x8BD6A70", Offset = "0x8BD5470", VA = "0x188BD6A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x8BD72B0", Offset = "0x8BD5CB0", VA = "0x188BD72B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct CBLDDDAADGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public AsyncTaskMethodBuilder<KNOBEKJADBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public EHPANNKFGMM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private TaskAwaiter<KNOBEKJADBE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3F30", Offset = "0x8BD2930", VA = "0x188BD3F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x8BD4EF0", Offset = "0x8BD38F0", VA = "0x188BD4EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct NEMKNAEHKMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public AsyncTaskMethodBuilder<KNOBEKJADBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public EHPANNKFGMM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public HEJNJNBOEGM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private TaskAwaiter<KNOBEKJADBE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x8BE21D0", Offset = "0x8BE0BD0", VA = "0x188BE21D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x8BE32E0", Offset = "0x8BE1CE0", VA = "0x188BE32E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct FOHEOMFGEFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public AsyncTaskMethodBuilder<KNOBEKJADBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public KNOBEKJADBE operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public EHPANNKFGMM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public ALPHANGLKLD deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter<KNOBEKJADBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9E20", Offset = "0x8BD8820", VA = "0x188BD9E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA080", Offset = "0x8BD8A80", VA = "0x188BDA080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class FDCLBHBMNNK
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
			public AsyncTaskMethodBuilder<KNOBEKJADBE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			public FDCLBHBMNNK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			private OJMINOEPFCH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			private TaskAwaiter<KNOBEKJADBE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x8BE7280", Offset = "0x8BE5C80", VA = "0x188BE7280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x8BE78B0", Offset = "0x8BE62B0", VA = "0x188BE78B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public EHPANNKFGMM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public FPJBOCJPIBC masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public HEJNJNBOEGM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public KNOBEKJADBE originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public FDCLBHBMNNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9890", Offset = "0x8BD8290", VA = "0x188BD9890")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<KNOBEKJADBE> HKOILOEMFCA(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct CFAPBJCLLFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public AsyncTaskMethodBuilder<KNOBEKJADBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public EHPANNKFGMM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public FPJBOCJPIBC masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public HEJNJNBOEGM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private TaskAwaiter<KNOBEKJADBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x8BD51D0", Offset = "0x8BD3BD0", VA = "0x188BD51D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x8BD56F0", Offset = "0x8BD40F0", VA = "0x188BD56F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct MCCCDNIHFHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public EHPANNKFGMM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private KNOBEKJADBE <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private IEnumerator<KNOBEKJADBE> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private TaskAwaiter<KNOBEKJADBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x8BE11A0", Offset = "0x8BDFBA0", VA = "0x188BE11A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x8BE16F0", Offset = "0x8BE00F0", VA = "0x188BE16F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct BOBHDKKLFJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x8BD3BE0", Offset = "0x8BD25E0", VA = "0x188BD3BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3ED0", Offset = "0x8BD28D0", VA = "0x188BD3ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct LOPBDNJMJIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x8BE01E0", Offset = "0x8BDEBE0", VA = "0x188BE01E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x8BE0410", Offset = "0x8BDEE10", VA = "0x188BE0410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class AHOKOCBEFOG
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
			public AsyncTaskMethodBuilder<KNOBEKJADBE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			public AHOKOCBEFOG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			public ALPHANGLKLD data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400059B")]
			public EHPANNKFGMM progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400059C")]
			public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400059D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			private TaskAwaiter<KNOBEKJADBE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			private TaskAwaiter<OMMEAGIPDJH> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x8BE7920", Offset = "0x8BE6320", VA = "0x188BE7920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x8BE83E0", Offset = "0x8BE6DE0", VA = "0x188BE83E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public LPAMPPONENL mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public AHOKOCBEFOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0B80", Offset = "0x8BCF580", VA = "0x188BD0B80")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<KNOBEKJADBE> HGOMBJMMCHE(ALPHANGLKLD data, HEJNJNBOEGM _, EHPANNKFGMM progressTracker, OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct HFBIDFKMCPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public ALPHANGLKLD phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public EHPANNKFGMM postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private AHOKOCBEFOG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private HEJNJNBOEGM <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter<KNOBEKJADBE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x8BDC0E0", Offset = "0x8BDAAE0", VA = "0x188BDC0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x8BDCF30", Offset = "0x8BDB930", VA = "0x188BDCF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct HNGCJDIFNFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x8BDCF90", Offset = "0x8BDB990", VA = "0x188BDCF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x8BDD390", Offset = "0x8BDBD90", VA = "0x188BDD390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct NNJKIMGBODD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public AsyncTaskMethodBuilder<KNOBEKJADBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public OPJFDBCJMPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public EHPANNKFGMM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private TaskAwaiter<KNOBEKJADBE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3350", Offset = "0x8BE1D50", VA = "0x188BE3350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x8BE3970", Offset = "0x8BE2370", VA = "0x188BE3970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private readonly NJLNMLEFFEL PPHAMPNILND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private readonly NJLNMLEFFEL IGLDHIAAKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private readonly CBEFKDIMHCC FAOBOCHEEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private readonly KBJPDNDKAJC PEJLPMNJAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private readonly BDJKPDPMFDM OBGPMCEELPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private ProfilerCounterValue<int> LOLELBPAJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private readonly IOBDEMMLBCL ONBGEMOCFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private readonly AAHPIJDFAJG BGBIDLFABMF;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private PKEIPCLCGCJ CACGEGMOACI
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC970", Offset = "0x8BCB370", VA = "0x188BCC970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event KOCNCIFIKJM EFCJNAENKFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x8BCCCE0", Offset = "0x8BCB6E0", VA = "0x188BCCCE0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB8C0", Offset = "0x8BCA2C0", VA = "0x188BCB8C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x8BCD480", Offset = "0x8BCBE80", VA = "0x188BCD480")]
	public OPJFDBCJMPI(OHBMAKCLEEN KGCEDLPDMEO, AAHPIJDFAJG BGBIDLFABMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x8BCB8E0", Offset = "0x8BCA2E0", VA = "0x188BCB8E0")]
	[AsyncStateMachine(typeof(DLOCKFAFAIP))]
	public Task AFPBLEKNBKJ(MLFBJBKAEMO NIBLEOGJBJF, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x8BCC120", Offset = "0x8BCAB20", VA = "0x188BCC120")]
	[AsyncStateMachine(typeof(NADINGDEDPG))]
	private Task<FPMLGPKCMLB> DJPDNJGJMPE(MLFBJBKAEMO NIBLEOGJBJF, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x8BCBC90", Offset = "0x8BCA690", VA = "0x188BCBC90")]
	[AsyncStateMachine(typeof(JJEEIHIMHBH))]
	private Task BMLFJFKFLCI(MLFBJBKAEMO NIBLEOGJBJF, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x8BCCE90", Offset = "0x8BCB890", VA = "0x188BCCE90")]
	[AsyncStateMachine(typeof(MBLACMBABAA))]
	private Task LKIEHDLDJFN(MLFBJBKAEMO NIBLEOGJBJF, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken NHHBDHNOMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x8BCC330", Offset = "0x8BCAD30", VA = "0x188BCC330")]
	[AsyncStateMachine(typeof(HBPBALHPIDF))]
	private Task EGNKEHKNBIP(ALPHANGLKLD CIKOBCBBLHA, EHPANNKFGMM OFJEFNDBFFN, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken EPDLNLAJCHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x8BCD370", Offset = "0x8BCBD70", VA = "0x188BCD370")]
	[AsyncStateMachine(typeof(CFIIOLBPNBC))]
	private Task PHANGJJMFDO(OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x8BCCD40", Offset = "0x8BCB740", VA = "0x188BCCD40")]
	[AsyncStateMachine(typeof(DKBIBFKKECI))]
	private Task KDNLOHGDKDD(ALPHANGLKLD GPCDCFCPGFK, EHPANNKFGMM GBHDJAGLPBM, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x8BCD050", Offset = "0x8BCBA50", VA = "0x188BCD050")]
	[AsyncStateMachine(typeof(CBLDDDAADGE))]
	private Task<KNOBEKJADBE> NHAJEBNFMCO(ALPHANGLKLD GPCDCFCPGFK, HEJNJNBOEGM CGHEHPNFOLC, EHPANNKFGMM GBHDJAGLPBM, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x8BCBE10", Offset = "0x8BCA810", VA = "0x188BCBE10")]
	[AsyncStateMachine(typeof(NEMKNAEHKMI))]
	private Task<KNOBEKJADBE> DCJGABDDCFF(ALPHANGLKLD GPCDCFCPGFK, HEJNJNBOEGM CGHEHPNFOLC, EHPANNKFGMM GBHDJAGLPBM, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x8BCC9C0", Offset = "0x8BCB3C0", VA = "0x188BCC9C0")]
	[AsyncStateMachine(typeof(FOHEOMFGEFG))]
	private Task<KNOBEKJADBE> INEILKAEMGC(KNOBEKJADBE EBODKBGKJOH, ALPHANGLKLD COOMMKFGFGC, EHPANNKFGMM GBHDJAGLPBM, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF, bool AABEDPLGKFH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x8BCBB50", Offset = "0x8BCA550", VA = "0x188BCBB50")]
	private bool AJLDEGIKNCN(ALPHANGLKLD CIKOBCBBLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x8BCBF90", Offset = "0x8BCA990", VA = "0x188BCBF90")]
	[AsyncStateMachine(typeof(CFAPBJCLLFA))]
	protected Task<KNOBEKJADBE> DJANNCCEKEN(ALPHANGLKLD GPCDCFCPGFK, HEJNJNBOEGM CGHEHPNFOLC, EHPANNKFGMM GBHDJAGLPBM, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF, FPJBOCJPIBC OPCLHFMGGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x8BCC590", Offset = "0x8BCAF90", VA = "0x188BCC590")]
	[AsyncStateMachine(typeof(MCCCDNIHFHC))]
	private Task HKEBMDNLJPC(ALPHANGLKLD GPCDCFCPGFK, EHPANNKFGMM GBHDJAGLPBM, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x8BCBC40", Offset = "0x8BCA640", VA = "0x188BCBC40")]
	private void AONLFOODLPL(KNOBEKJADBE AMGDJDJGOLC, EHPANNKFGMM GBHDJAGLPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x8BCCD00", Offset = "0x8BCB700", VA = "0x188BCCD00")]
	private void JPBGMBJDJGI(KNOBEKJADBE ODJPCCPKJFF, [Out] KNOBEKJADBE NBLCCIMHEFG, [Out] KNOBEKJADBE GCFHHMMKNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x8BCD010", Offset = "0x8BCBA10", VA = "0x188BCD010")]
	private Task<NGBABHAHMPG> NDMCGBLBBLN(MLFBJBKAEMO NIBLEOGJBJF, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x8BCCFD0", Offset = "0x8BCB9D0", VA = "0x188BCCFD0")]
	private Task<ALPHANGLKLD> NCFIMFILLIB(NGBABHAHMPG GPCDCFCPGFK, NPHFKKEFGIB.LLDFOILIDAI AJIKBCEGIDO, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x8BCC820", Offset = "0x8BCB220", VA = "0x188BCC820")]
	[AsyncStateMachine(typeof(BOBHDKKLFJH))]
	private Task HLLHCPGJMJM(ALPHANGLKLD GPCDCFCPGFK, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF, bool KOGNJGIKKJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x8BCC480", Offset = "0x8BCAE80", VA = "0x188BCC480")]
	[AsyncStateMachine(typeof(LOPBDNJMJIL))]
	private Task EOBKGGLABKN(ALPHANGLKLD GPCDCFCPGFK, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x8BCD1E0", Offset = "0x8BCBBE0", VA = "0x188BCD1E0")]
	private Task OKBABBJHODH(ALPHANGLKLD GPCDCFCPGFK, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x8BCBDD0", Offset = "0x8BCA7D0", VA = "0x188BCBDD0")]
	private Task CICEEPDKOCB(ALPHANGLKLD GPCDCFCPGFK, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x8BCC9A0", Offset = "0x8BCB3A0", VA = "0x188BCC9A0")]
	private Task IEFELKALAGE(ALPHANGLKLD GPCDCFCPGFK, HEJNJNBOEGM CGHEHPNFOLC, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x8BCBDF0", Offset = "0x8BCA7F0", VA = "0x188BCBDF0")]
	private Task CLCNJJBBKAH(ALPHANGLKLD GPCDCFCPGFK, HEJNJNBOEGM CGHEHPNFOLC, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x8BCD1D0", Offset = "0x8BCBBD0", VA = "0x188BCD1D0")]
	private static Task OCHPHOKKJEI(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x8BCD1B0", Offset = "0x8BCBBB0", VA = "0x188BCD1B0")]
	private Task OBBGJLIHDGO(ALPHANGLKLD GPCDCFCPGFK, HEJNJNBOEGM CGHEHPNFOLC, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x8BCC570", Offset = "0x8BCAF70", VA = "0x188BCC570")]
	private Task FMCCBDCOFJN(ALPHANGLKLD GPCDCFCPGFK, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x8BCCC90", Offset = "0x8BCB690", VA = "0x188BCCC90")]
	private void JHKAHDEIJFN(MLFBJBKAEMO NIBLEOGJBJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x8BCC280", Offset = "0x8BCAC80", VA = "0x188BCC280")]
	public void DOBCDCGDBGC(long MNAMJIAHNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	private static void ICDPBJOKIMM(DJEKJMDOAHO GADEDFJOCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x8BCCB40", Offset = "0x8BCB540", VA = "0x188BCCB40")]
	[AsyncStateMachine(typeof(HFBIDFKMCPB))]
	private Task JEGHALMPIEM(ALPHANGLKLD CIKOBCBBLHA, EHPANNKFGMM OFJEFNDBFFN, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken EPDLNLAJCHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x8BCC6E0", Offset = "0x8BCB0E0", VA = "0x188BCC6E0")]
	[AsyncStateMachine(typeof(HNGCJDIFNFD))]
	private Task HLJEJNPPMOG(ALPHANGLKLD GPCDCFCPGFK, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x8BCBA30", Offset = "0x8BCA430", VA = "0x188BCBA30")]
	private static GJADLJGDNNF AIALOBFAKIP(ALPHANGLKLD COOMMKFGFGC)
	{
		return default(GJADLJGDNNF);
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x8BCD210", Offset = "0x8BCBC10", VA = "0x188BCD210")]
	[AsyncStateMachine(typeof(NNJKIMGBODD))]
	private Task<KNOBEKJADBE> OLEEANECDDD(ALPHANGLKLD GPCDCFCPGFK, HEJNJNBOEGM CGHEHPNFOLC, EHPANNKFGMM GBHDJAGLPBM, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	private void KFMIJCNBDIE(KNOBEKJADBE AEIOCGNIIDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct OBMJAHPJFGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	private PKEIPCLCGCJ MBIPODKGFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	private ALPHANGLKLD GPCDCFCPGFK;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private KGCDOOPNJBJ NJNPDNFAPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x8BE4260", Offset = "0x8BE2C60", VA = "0x188BE4260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x8BE44D0", Offset = "0x8BE2ED0", VA = "0x188BE44D0")]
	public static Task JCNNIFHFEKH(PKEIPCLCGCJ MBIPODKGFBO, ALPHANGLKLD GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x8BE42B0", Offset = "0x8BE2CB0", VA = "0x188BE42B0")]
	private void JCNNIFHFEKH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct BEFLCHIFGLF
{
	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x8BD3050", Offset = "0x8BD1A50", VA = "0x188BD3050")]
	public static Task JCNNIFHFEKH(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal struct FMCGNGAEMMC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct BMIKDGHIPCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public OHBMAKCLEEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3650", Offset = "0x8BD2050", VA = "0x188BD3650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3B80", Offset = "0x8BD2580", VA = "0x188BD3B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x8BD99B0", Offset = "0x8BD83B0", VA = "0x188BD99B0")]
	[AsyncStateMachine(typeof(BMIKDGHIPCA))]
	public static Task JCNNIFHFEKH(OHBMAKCLEEN KGCEDLPDMEO, ALPHANGLKLD GPCDCFCPGFK, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct JJHHDCBFKIG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct IJGGPIFNGGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public OHBMAKCLEEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public HEJNJNBOEGM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private PKEIPCLCGCJ <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private KGCDOOPNJBJ <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private KNOBEKJADBE <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private OJMINOEPFCH <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private List<(PersistenceView, BHOPKDGDEFN)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private BHOPKDGDEFN <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x8BDDA70", Offset = "0x8BDC470", VA = "0x188BDDA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BDE750", Offset = "0x8BDD150", VA = "0x188BDE750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x8BDF3E0", Offset = "0x8BDDDE0", VA = "0x188BDF3E0")]
	[AsyncStateMachine(typeof(IJGGPIFNGGG))]
	public static Task JCNNIFHFEKH(OHBMAKCLEEN KGCEDLPDMEO, ALPHANGLKLD GPCDCFCPGFK, HEJNJNBOEGM CGHEHPNFOLC, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x8BDF530", Offset = "0x8BDDF30", VA = "0x188BDF530")]
	private static void KFDBAKPHBAN(PersistenceView EGPPKOBFLID, BHOPKDGDEFN HGCHPOBFDBI, ALPHANGLKLD GPCDCFCPGFK, KNOBEKJADBE EBODKBGKJOH, bool HCGHAFBGIOJ)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct OIDIPPDPMAP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct IHBIFKMDAAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public PKEIPCLCGCJ roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private OJMINOEPFCH <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x8BDD3F0", Offset = "0x8BDBDF0", VA = "0x188BDD3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x8BDDA10", Offset = "0x8BDC410", VA = "0x188BDDA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x8BE45B0", Offset = "0x8BE2FB0", VA = "0x188BE45B0")]
	[AsyncStateMachine(typeof(IHBIFKMDAAN))]
	public static Task JCNNIFHFEKH(PKEIPCLCGCJ MBIPODKGFBO, ALPHANGLKLD GPCDCFCPGFK, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal struct ELJCALPDFPC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct GCDKIKEIHJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public PKEIPCLCGCJ roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public OHBMAKCLEEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x8BDAFB0", Offset = "0x8BD99B0", VA = "0x188BDAFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x8BDB1C0", Offset = "0x8BD9BC0", VA = "0x188BDB1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class MIDKECAGDMM
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
			public OGMJCPNEHOO<string>.LOEEEDILNMC timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005F4")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			public MIDKECAGDMM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005F7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x8BE8450", Offset = "0x8BE6E50", VA = "0x188BE8450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x8BE87E0", Offset = "0x8BE71E0", VA = "0x188BE87E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public MIDKECAGDMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x8BE1750", Offset = "0x8BE0150", VA = "0x188BE1750")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task OPGPNJCKIBD(OGMJCPNEHOO<string>.LOEEEDILNMC timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct DNCMJGPHKPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public ELJCALPDFPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private OJMINOEPFCH <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private TaskAwaiter<FPMLGPKCMLB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x8BD7AC0", Offset = "0x8BD64C0", VA = "0x188BD7AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x8BD86D0", Offset = "0x8BD70D0", VA = "0x188BD86D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class BJPPKFNODKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public BKLAHIHKKHK version;

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
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BJPPKFNODKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3570", Offset = "0x8BD1F70", VA = "0x188BD3570")]
		internal object JMBPFJOPHPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BD34C0", Offset = "0x8BD1EC0", VA = "0x188BD34C0")]
		internal object HNLJBEECONE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private PKEIPCLCGCJ MBIPODKGFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private ALPHANGLKLD GPCDCFCPGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private OHBMAKCLEEN KGCEDLPDMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private bool KOGNJGIKKJO;

	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private static readonly ByteString PACEEIOHBPB;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private KGCDOOPNJBJ NJNPDNFAPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x8BD8CB0", Offset = "0x8BD76B0", VA = "0x188BD8CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private NIIBNLNBABL HLKOBEKBMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9760", Offset = "0x8BD8160", VA = "0x188BD9760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x8BD94E0", Offset = "0x8BD7EE0", VA = "0x188BD94E0")]
	[AsyncStateMachine(typeof(GCDKIKEIHJD))]
	public static Task JCNNIFHFEKH(PKEIPCLCGCJ MBIPODKGFBO, ALPHANGLKLD GPCDCFCPGFK, OHBMAKCLEEN KGCEDLPDMEO, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF, bool KOGNJGIKKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x8BD9630", Offset = "0x8BD8030", VA = "0x188BD9630")]
	[AsyncStateMachine(typeof(DNCMJGPHKPE))]
	private Task JCNNIFHFEKH(OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x8BD8D00", Offset = "0x8BD7700", VA = "0x188BD8D00")]
	private void ICPAPCNIIPL([NotNull] AJDHPEOBCFP DNANDPJDLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x8BD8C70", Offset = "0x8BD7670", VA = "0x188BD8C70")]
	private bool DKIAOBDFIED(BKLAHIHKKHK OHBCMIBMOPM, AJDHPEOBCFP DNANDPJDLAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct OACAHANAHNF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct AKOFBKDMPAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public AsyncTaskMethodBuilder<ALPHANGLKLD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public OACAHANAHNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public NPHFKKEFGIB.LLDFOILIDAI downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private TaskAwaiter<IReadOnlyCollection<MMFCCBABPAO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private TaskAwaiter<(DOHEMIFBILP<NIFOPHOIBJN, OGOHDADDIPM>, DOHEMIFBILP<CDDDFCHIGNI<AJDHPEOBCFP>, OGOHDADDIPM>, DOHEMIFBILP<CDDDFCHIGNI<HEEMABDELIE>, OGOHDADDIPM>, DOHEMIFBILP<CDDDFCHIGNI<IEnumerable<JANJDGIBAEN>>, OGOHDADDIPM>, DOHEMIFBILP<CDDDFCHIGNI<OBGLFNADNNH>, OGOHDADDIPM>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x8BD11E0", Offset = "0x8BCFBE0", VA = "0x188BD11E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1FC0", Offset = "0x8BD09C0", VA = "0x188BD1FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct GBEIENEEDOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public AsyncTaskMethodBuilder<DOHEMIFBILP<NIFOPHOIBJN, OGOHDADDIPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public OACAHANAHNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public IReadOnlyCollection<MMFCCBABPAO> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public IReadOnlyCollection<MMFCCBABPAO> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public NPHFKKEFGIB.LLDFOILIDAI downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private TaskAwaiter<DOHEMIFBILP<NIFOPHOIBJN, OGOHDADDIPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA8E0", Offset = "0x8BD92E0", VA = "0x188BDA8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x8BDAF40", Offset = "0x8BD9940", VA = "0x188BDAF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private GLILHEAMKDI<HCMJMHBJMFG, HEEMABDELIE> PPFDDNOPPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private GLILHEAMKDI<HCMJMHBJMFG, AJDHPEOBCFP> FFNOHBADFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	private GLILHEAMKDI<MGLMPLLOJJF, IEnumerable<JANJDGIBAEN>> FPNBILOFHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private GLILHEAMKDI<long, OBGLFNADNNH> FEGIIKMDOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private LGPDKDODGPL GLMCIAGAMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private DJEKJMDOAHO GADEDFJOCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private DBNKIMCJKJK ECKHOBBHDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private Guid? IDCJGBECDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	private IReadOnlyCollection<MMFCCBABPAO> PIMOKNPHILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000610")]
	private Task<IReadOnlyCollection<MMFCCBABPAO>> MGENECMCALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	private HCMJMHBJMFG MFNLMEFHDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private HCMJMHBJMFG IDBNBOBAMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	private HCMJMHBJMFG? KEFFOIDAKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	private MGLMPLLOJJF BFFIDPCBGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x8BE39E0", Offset = "0x8BE23E0", VA = "0x188BE39E0")]
	public static Task<ALPHANGLKLD> JCDLJPOPOOM(PKEIPCLCGCJ MBIPODKGFBO, [In] NGBABHAHMPG GPCDCFCPGFK, NPHFKKEFGIB.LLDFOILIDAI AJIKBCEGIDO, OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x8BE3E80", Offset = "0x8BE2880", VA = "0x188BE3E80")]
	[AsyncStateMachine(typeof(AKOFBKDMPAN))]
	private Task<ALPHANGLKLD> JCNNIFHFEKH(NPHFKKEFGIB.LLDFOILIDAI AJIKBCEGIDO, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4030", Offset = "0x8BE2A30", VA = "0x188BE4030")]
	[AsyncStateMachine(typeof(GBEIENEEDOI))]
	private Task<DOHEMIFBILP<NIFOPHOIBJN, OGOHDADDIPM>> PKGHFPKPFEF(Guid? IDCJGBECDDM, IReadOnlyCollection<MMFCCBABPAO> PIMOKNPHILO, IReadOnlyCollection<MMFCCBABPAO> KFJJDJLBCCL, long? DKMPIOFKFMN, long? JCFCCOKDCNL, NPHFKKEFGIB.LLDFOILIDAI AJIKBCEGIDO, OGMJCPNEHOO<string>.LOEEEDILNMC FGCEFIOBHCP, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal struct JAMOJLLCFKK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct MNFOJIAPKCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public AsyncTaskMethodBuilder<NGBABHAHMPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public JAMOJLLCFKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private TaskAwaiter<NGBABHAHMPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x8BE1870", Offset = "0x8BE0270", VA = "0x188BE1870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x8BE1CC0", Offset = "0x8BE06C0", VA = "0x188BE1CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct KNEAJFIPMHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public AsyncTaskMethodBuilder<NGBABHAHMPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public JAMOJLLCFKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		private TaskAwaiter<NGBABHAHMPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x8BDF780", Offset = "0x8BDE180", VA = "0x188BDF780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x8BDFC00", Offset = "0x8BDE600", VA = "0x188BDFC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class LGKIEAFBODG
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
			public LGKIEAFBODG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000656")]
			private TaskAwaiter<DLAPJAGBOIF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000657")]
			private TaskAwaiter<BBOGCAENLMO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x8BE5880", Offset = "0x8BE4280", VA = "0x188BE5880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x8BE6230", Offset = "0x8BE4C30", VA = "0x188BE6230", Slot = "5")]
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
		public FIADEAFPLEB roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public KGCDOOPNJBJ callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public HCMJMHBJMFG superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public HCMJMHBJMFG subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public IReadOnlyList<MMFCCBABPAO> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public IReadOnlyList<MMFCCBABPAO> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public DJEKJMDOAHO roomDetails;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LGKIEAFBODG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xFD7070", Offset = "0xFD5A70", VA = "0x180FD7070")]
		internal bool JGDHONNMFFO(DBNKIMCJKJK sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x8BE0110", Offset = "0x8BDEB10", VA = "0x188BE0110")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task NALIOAGKMOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x8BDFF10", Offset = "0x8BDE910", VA = "0x188BDFF10")]
		internal Task<MGLMPLLOJJF> IIIIADAADOI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct BBOJHOBGACJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public AsyncTaskMethodBuilder<NGBABHAHMPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public FIADEAFPLEB roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public KGCDOOPNJBJ callbacks;

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
		public HCMJMHBJMFG superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private LGKIEAFBODG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private DBNKIMCJKJK <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private Task<MGLMPLLOJJF> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private TaskAwaiter<DJEKJMDOAHO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private TaskAwaiter<MGLMPLLOJJF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x8BD2030", Offset = "0x8BD0A30", VA = "0x188BD2030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x8BD2FE0", Offset = "0x8BD19E0", VA = "0x188BD2FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	private KGCDOOPNJBJ JDNAAPNIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	private CBEFKDIMHCC FAOBOCHEEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	private FIADEAFPLEB LGBLEBKONBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private long DKMPIOFKFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private long JOIKPPGBGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	private long CIJFOCDDGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	private string MIMKOOGLIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private HCMJMHBJMFG HPDGNNPAJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private Guid BIGFHODCBHO;

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x8BDE7B0", Offset = "0x8BDD1B0", VA = "0x188BDE7B0")]
	public static Task<NGBABHAHMPG> JCDLJPOPOOM(PKEIPCLCGCJ MBIPODKGFBO, MLFBJBKAEMO NIBLEOGJBJF, OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x8BDEA00", Offset = "0x8BDD400", VA = "0x188BDEA00")]
	[AsyncStateMachine(typeof(MNFOJIAPKCD))]
	private Task<NGBABHAHMPG> JCNNIFHFEKH(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x8BDEB80", Offset = "0x8BDD580", VA = "0x188BDEB80")]
	[AsyncStateMachine(typeof(KNEAJFIPMHI))]
	private Task<NGBABHAHMPG> NDMCGBLBBLN(OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x8BDECF0", Offset = "0x8BDD6F0", VA = "0x188BDECF0")]
	[AsyncStateMachine(typeof(BBOJHOBGACJ))]
	private static Task<NGBABHAHMPG> NDMCGBLBBLN(KGCDOOPNJBJ JDNAAPNIDID, FIADEAFPLEB LGBLEBKONBO, long DKMPIOFKFMN, long JOIKPPGBGCF, long CIJFOCDDGDK, string MIMKOOGLIBI, HCMJMHBJMFG HPDGNNPAJPO, Guid BIGFHODCBHO, CancellationToken OMJKEHOJJFF, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x8BDEB50", Offset = "0x8BDD550", VA = "0x188BDEB50")]
	private void LJEJACGHNLH(DJEKJMDOAHO GADEDFJOCGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
internal struct OPMPCELEFCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct DFEFNLJLCEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public OPMPCELEFCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x8BD5FA0", Offset = "0x8BD49A0", VA = "0x188BD5FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x8BD6530", Offset = "0x8BD4F30", VA = "0x188BD6530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private KGCDOOPNJBJ JDNAAPNIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private ALPHANGLKLD GPCDCFCPGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private float JNGFGHFEHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private float POLBFNLDODH;

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4D40", Offset = "0x8BE3740", VA = "0x188BE4D40")]
	public static Task OFIFLADBEBP(PKEIPCLCGCJ MBIPODKGFBO, ALPHANGLKLD GPCDCFCPGFK, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4AC0", Offset = "0x8BE34C0", VA = "0x188BE4AC0")]
	[AsyncStateMachine(typeof(DFEFNLJLCEO))]
	public Task JCNNIFHFEKH(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4960", Offset = "0x8BE3360", VA = "0x188BE4960")]
	private static void DLILGHDPPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4BE0", Offset = "0x8BE35E0", VA = "0x188BE4BE0")]
	private void MPHCNHFHKFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4EE0", Offset = "0x8BE38E0", VA = "0x188BE4EE0")]
	private static float POHIDOFPDBA(KGCDOOPNJBJ JDNAAPNIDID)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4AA0", Offset = "0x8BE34A0", VA = "0x188BE4AA0")]
	private static float FEJGBLAGKMK()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct CCFKFAEHDCB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct POPNGKEAJMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public OHBMAKCLEEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private MFDOGKHNMAA <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private PKEIPCLCGCJ <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private GODFDKINIPK.JLFEHMDACFF <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private TaskAwaiter<FPMLGPKCMLB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5020", Offset = "0x8BE3A20", VA = "0x188BE5020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5820", Offset = "0x8BE4220", VA = "0x188BE5820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct BHOKJCLNACC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3130", Offset = "0x8BD1B30", VA = "0x188BD3130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3460", Offset = "0x8BD1E60", VA = "0x188BD3460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x8BD5020", Offset = "0x8BD3A20", VA = "0x188BD5020")]
	[AsyncStateMachine(typeof(POPNGKEAJMA))]
	public static Task JCNNIFHFEKH(OHBMAKCLEEN KGCEDLPDMEO, ALPHANGLKLD GPCDCFCPGFK, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x8BD5160", Offset = "0x8BD3B60", VA = "0x188BD5160")]
	private static Task<FPMLGPKCMLB> KBBGFLEEMBK(OHBMAKCLEEN KGCEDLPDMEO, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x8BD4F60", Offset = "0x8BD3960", VA = "0x188BD4F60")]
	[AsyncStateMachine(typeof(BHOKJCLNACC))]
	private static Task CFJCHEBDMJD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal struct OPGHFJOECGD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct GBEBDAFJAFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public OPGHFJOECGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA0F0", Offset = "0x8BD8AF0", VA = "0x188BDA0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA880", Offset = "0x8BD9280", VA = "0x188BDA880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class PGHANEOHECM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PGHANEOHECM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x8BE4FA0", Offset = "0x8BE39A0", VA = "0x188BE4FA0")]
		internal object JIOPPJHKNCI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct DGNODDCMHJK : IAsyncStateMachine
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
		public OPGHFJOECGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x8BD6590", Offset = "0x8BD4F90", VA = "0x188BD6590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x8BD6A10", Offset = "0x8BD5410", VA = "0x188BD6A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private bool LDCMPFLJJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	private OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	private PKEIPCLCGCJ MBIPODKGFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	private CancellationToken OMJKEHOJJFF;

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x8BE47C0", Offset = "0x8BE31C0", VA = "0x188BE47C0")]
	public static Task LFEAEPBHGNP(PKEIPCLCGCJ MBIPODKGFBO, bool LDCMPFLJJON, OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, CancellationToken FACNKJHPOCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x8BE46D0", Offset = "0x8BE30D0", VA = "0x188BE46D0")]
	[AsyncStateMachine(typeof(GBEBDAFJAFK))]
	private Task JCNNIFHFEKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4830", Offset = "0x8BE3230", VA = "0x188BE4830")]
	[AsyncStateMachine(typeof(DGNODDCMHJK))]
	private Task MILDDNJNPHA(bool NAFEFMDLLJM, string MPIBHFEHILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480")]
	private bool ABEMGMJOGGI(bool LDCMPFLJJON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal struct LBAOLLMACPH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct EFIGHFOHGGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public LBAOLLMACPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x8BD8730", Offset = "0x8BD7130", VA = "0x188BD8730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x8BD8C00", Offset = "0x8BD7600", VA = "0x188BD8C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private sealed class JKNCAIHIIPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public JKNCAIHIIPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x8BDF730", Offset = "0x8BDE130", VA = "0x188BDF730")]
		internal object JIOPPJHKNCI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct AJAGDNJJOEC : IAsyncStateMachine
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
		public LBAOLLMACPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0CE0", Offset = "0x8BCF6E0", VA = "0x188BD0CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1170", Offset = "0x8BCFB70", VA = "0x188BD1170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private MPFMDMNCNFI AFGDECNDFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private PKEIPCLCGCJ MBIPODKGFBO;

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x8BDFC70", Offset = "0x8BDE670", VA = "0x188BDFC70")]
	public static Task<Scene> BLGNNBHLOKI(PKEIPCLCGCJ MBIPODKGFBO, MPFMDMNCNFI EEIHKMGBACG, OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x8BDFCC0", Offset = "0x8BDE6C0", VA = "0x188BDFCC0")]
	[AsyncStateMachine(typeof(EFIGHFOHGGO))]
	private Task<Scene> JCNNIFHFEKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x8BDFDD0", Offset = "0x8BDE7D0", VA = "0x188BDFDD0")]
	[AsyncStateMachine(typeof(AJAGDNJJOEC))]
	private Task<Scene> MILDDNJNPHA(string MPIBHFEHILP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal struct BDJKPDPMFDM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct DHIGHNFCABN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public AsyncTaskMethodBuilder<KNOBEKJADBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public BDJKPDPMFDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public KNOBEKJADBE nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public ALPHANGLKLD deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private TaskAwaiter<KNOBEKJADBE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x8BEE1D0", Offset = "0x8BECBD0", VA = "0x188BEE1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x8BEECA0", Offset = "0x8BED6A0", VA = "0x188BEECA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct IODLBMFLFFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public AsyncTaskMethodBuilder<KNOBEKJADBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public BDJKPDPMFDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public KNOBEKJADBE state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private TaskAwaiter<FPMLGPKCMLB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x8BF40A0", Offset = "0x8BF2AA0", VA = "0x188BF40A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4380", Offset = "0x8BF2D80", VA = "0x188BF4380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	private readonly OHBMAKCLEEN KGCEDLPDMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006AD")]
	private readonly CBEFKDIMHCC FAOBOCHEEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AE")]
	private readonly KBJPDNDKAJC PEJLPMNJAON;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private MFDOGKHNMAA JKEEOHKCKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x6F816A0", Offset = "0x6F800A0", VA = "0x186F816A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x8BE9510", Offset = "0x8BE7F10", VA = "0x188BE9510")]
	public BDJKPDPMFDM(OHBMAKCLEEN KGCEDLPDMEO, CBEFKDIMHCC FAOBOCHEEEI, KBJPDNDKAJC PEJLPMNJAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x8BE91E0", Offset = "0x8BE7BE0", VA = "0x188BE91E0")]
	[AsyncStateMachine(typeof(DHIGHNFCABN))]
	public Task<KNOBEKJADBE> EKOMELEILOE(KNOBEKJADBE EPGAGFIBLOF, ALPHANGLKLD COOMMKFGFGC, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF, bool AABEDPLGKFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x8BE93B0", Offset = "0x8BE7DB0", VA = "0x188BE93B0")]
	[AsyncStateMachine(typeof(IODLBMFLFFM))]
	private Task<KNOBEKJADBE> PDFLDOIFFCL(OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, KNOBEKJADBE BLKFHFCBEDC, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x8BE9380", Offset = "0x8BE7D80", VA = "0x188BE9380")]
	private bool GPABHCILAOA(KNOBEKJADBE NDHOMMGLPKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x8BE9360", Offset = "0x8BE7D60", VA = "0x188BE9360")]
	private void GCLDEHJKFHJ(string LJCGGLBEFFM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal struct GPHAHHAGDNI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private struct FGDFHGNNHEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public MFDOGKHNMAA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public HEJNJNBOEGM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private OJMINOEPFCH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private List<(PersistenceView, BHOPKDGDEFN)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		private (PersistenceView, BHOPKDGDEFN) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0700", Offset = "0x8BEF100", VA = "0x188BF0700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0DD0", Offset = "0x8BEF7D0", VA = "0x188BF0DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x8BF3840", Offset = "0x8BF2240", VA = "0x188BF3840")]
	[AsyncStateMachine(typeof(FGDFHGNNHEB))]
	public static Task JCNNIFHFEKH(MFDOGKHNMAA EANMJMPIOGJ, ALPHANGLKLD GPCDCFCPGFK, HEJNJNBOEGM CGHEHPNFOLC, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal struct GNCCLOKBOAP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct MDGLPINJDLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public MFDOGKHNMAA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public HEJNJNBOEGM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private BKLAHIHKKHK <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private OJMINOEPFCH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private List<(PersistenceView, BHOPKDGDEFN)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private BHOPKDGDEFN <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7D20", Offset = "0x8BF6720", VA = "0x188BF7D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8600", Offset = "0x8BF7000", VA = "0x188BF8600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x8BF2300", Offset = "0x8BF0D00", VA = "0x188BF2300")]
	[AsyncStateMachine(typeof(MDGLPINJDLO))]
	public static Task JCNNIFHFEKH(MFDOGKHNMAA EANMJMPIOGJ, ALPHANGLKLD GPCDCFCPGFK, HEJNJNBOEGM CGHEHPNFOLC, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public struct LIOOOAKBJJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private struct DCJBAFCEKOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public AsyncTaskMethodBuilder<DOHEMIFBILP<NIFOPHOIBJN, OGOHDADDIPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public LIOOOAKBJJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public NPHFKKEFGIB.LLDFOILIDAI preloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private TaskAwaiter<DOHEMIFBILP<NIFOPHOIBJN, OGOHDADDIPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x8BEDAE0", Offset = "0x8BEC4E0", VA = "0x188BEDAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x8BEE160", Offset = "0x8BECB60", VA = "0x188BEE160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private long LIAONHOEBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private long IJNKKJOJKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private Guid? PEJEJFDOKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private IReadOnlyCollection<MMFCCBABPAO> OGJCOCEKNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private IReadOnlyCollection<MMFCCBABPAO> BHLOEINHHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private LGPDKDODGPL JDDFLGPJPHO;

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x8BF79D0", Offset = "0x8BF63D0", VA = "0x188BF79D0")]
	public static Task<DOHEMIFBILP<NIFOPHOIBJN, OGOHDADDIPM>> JCDLJPOPOOM(long DKMPIOFKFMN, long JOIKPPGBGCF, BBOGCAENLMO PCGJNKNOIOG, NPHFKKEFGIB.LLDFOILIDAI LNMJECDOEFG, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x8BF7B30", Offset = "0x8BF6530", VA = "0x188BF7B30")]
	[AsyncStateMachine(typeof(DCJBAFCEKOL))]
	private Task<DOHEMIFBILP<NIFOPHOIBJN, OGOHDADDIPM>> JCNNIFHFEKH(NPHFKKEFGIB.LLDFOILIDAI LNMJECDOEFG, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal struct GODFDKINIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	public struct JLFEHMDACFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public List<BPEHFCJOHOP> GBFCHCCGDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public List<BHOPKDGDEFN> AGCHKLDBCNK;

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xC12020", Offset = "0xC10A20", VA = "0x180C12020")]
		public JLFEHMDACFF(List<BPEHFCJOHOP> GBFCHCCGDAG, List<BHOPKDGDEFN> AGCHKLDBCNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class KHFBBLJNIMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public IEnumerable<BPEHFCJOHOP> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KHFBBLJNIMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x8BF65D0", Offset = "0x8BF4FD0", VA = "0x188BF65D0")]
		internal object MBFBMLJMONL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006E9")]
	private PKEIPCLCGCJ MBIPODKGFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006EA")]
	private ALPHANGLKLD GPCDCFCPGFK;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private KGCDOOPNJBJ NJNPDNFAPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x8BF3530", Offset = "0x8BF1F30", VA = "0x188BF3530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x8BF3580", Offset = "0x8BF1F80", VA = "0x188BF3580")]
	public static JLFEHMDACFF JCNNIFHFEKH(PKEIPCLCGCJ MBIPODKGFBO, ALPHANGLKLD GPCDCFCPGFK)
	{
		return default(JLFEHMDACFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x8BF35E0", Offset = "0x8BF1FE0", VA = "0x188BF35E0")]
	private JLFEHMDACFF JCNNIFHFEKH()
	{
		return default(JLFEHMDACFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x8BF2F90", Offset = "0x8BF1990", VA = "0x188BF2F90")]
	private JLFEHMDACFF GOCBJMMOMLB(AJDHPEOBCFP DNANDPJDLAG, BKLAHIHKKHK PGGHHODBCLO)
	{
		return default(JLFEHMDACFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x8BF2DC0", Offset = "0x8BF17C0", VA = "0x188BF2DC0")]
	private bool BJLHOILJBFL(IEnumerable<BPEHFCJOHOP> GBFCHCCGDAG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal struct BECEJGDEJCL
{
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class OEODBDCLGON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public GODFDKINIPK.JLFEHMDACFF instantiations;

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public OEODBDCLGON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x8BFAFE0", Offset = "0x8BF99E0", VA = "0x188BFAFE0")]
		internal object OPGPNJCKIBD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class ANNDELLGMMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ANNDELLGMMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x8BE9150", Offset = "0x8BE7B50", VA = "0x188BE9150")]
		internal object AMMDGKEAFDC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x8BEA890", Offset = "0x8BE9290", VA = "0x188BEA890")]
	public static void JCNNIFHFEKH(MFDOGKHNMAA EANMJMPIOGJ, ALPHANGLKLD GPCDCFCPGFK, GODFDKINIPK.JLFEHMDACFF LJCHIKBFBBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
internal class KBJPDNDKAJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private struct CMFCEIDMJNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public KBJPDNDKAJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public KNOBEKJADBE operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public ALPHANGLKLD deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x8BED140", Offset = "0x8BEBB40", VA = "0x188BED140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x8BED8B0", Offset = "0x8BEC2B0", VA = "0x188BED8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class AKCJJJMOOJJ
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
			public AKCJJJMOOJJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000702")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000703")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE130", Offset = "0x8BFCB30", VA = "0x188BFE130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE3F0", Offset = "0x8BFCDF0", VA = "0x188BFE3F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public KBJPDNDKAJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public AKCJJJMOOJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE8D70", Offset = "0x8BE7770", VA = "0x188BE8D70")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task PFLBFDMMFLB(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct JOCLHAFCLCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public KBJPDNDKAJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		private AKCJJJMOOJJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4460", Offset = "0x8BF2E60", VA = "0x188BF4460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4990", Offset = "0x8BF3390", VA = "0x188BF4990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct OBPNFPGJABB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public KBJPDNDKAJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private Dictionary<Guid, List<KLGCNLILPBP>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA970", Offset = "0x8BF9370", VA = "0x188BFA970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x8BFAF80", Offset = "0x8BF9980", VA = "0x188BFAF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private struct FIMNHIDGJKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public KBJPDNDKAJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private Dictionary<Guid, List<KLGCNLILPBP>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0E30", Offset = "0x8BEF830", VA = "0x188BF0E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x8BF14D0", Offset = "0x8BEFED0", VA = "0x188BF14D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class GNEJJCBKIKC
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
			public KLGCNLILPBP handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000726")]
			public GNEJJCBKIKC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000727")]
			private OJMINOEPFCH <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000728")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x8BFDC60", Offset = "0x8BFC660", VA = "0x188BFDC60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE0D0", Offset = "0x8BFCAD0", VA = "0x188BFE0D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public FALDLNAGKBL runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public List<KLGCNLILPBP> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GNEJJCBKIKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x8BF2530", Offset = "0x8BF0F30", VA = "0x188BF2530")]
		internal object KCLFNOFEJBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF2620", Offset = "0x8BF1020", VA = "0x188BF2620")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task LBBPDDMGICP(KLGCNLILPBP handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF2440", Offset = "0x8BF0E40", VA = "0x188BF2440")]
		internal object AOCBJFOADIH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private struct BMJKOCHFGCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public FALDLNAGKBL runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public List<KLGCNLILPBP> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private GNEJJCBKIKC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x8BEB160", Offset = "0x8BE9B60", VA = "0x188BEB160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x8BEB630", Offset = "0x8BEA030", VA = "0x188BEB630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private struct OJIONICHKCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public KBJPDNDKAJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC timer;

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
		[Cpp2IlInjected.Address(RVA = "0x8BFBE40", Offset = "0x8BFA840", VA = "0x188BFBE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC400", Offset = "0x8BFAE00", VA = "0x188BFC400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class GMKHHFDNFCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GMKHHFDNFCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1D70", Offset = "0x8BF0770", VA = "0x188BF1D70")]
		internal object HFALLCDLJJM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct GMOONAHNAIB : IAsyncStateMachine
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
		public KBJPDNDKAJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public ALPHANGLKLD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1DE0", Offset = "0x8BF07E0", VA = "0x188BF1DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x8BF22A0", Offset = "0x8BF0CA0", VA = "0x188BF22A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private sealed class JJKMPJKOMDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public JJKMPJKOMDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF43F0", Offset = "0x8BF2DF0", VA = "0x188BF43F0")]
		internal object MMLJFALDFPG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private struct GOAJLNHAPHI : IAsyncStateMachine
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
		public KBJPDNDKAJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private OJMINOEPFCH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private TaskAwaiter<FPMLGPKCMLB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF2720", Offset = "0x8BF1120", VA = "0x188BF2720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF2D60", Offset = "0x8BF1760", VA = "0x188BF2D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private sealed class KMKECOBELAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KMKECOBELAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7260", Offset = "0x8BF5C60", VA = "0x188BF7260")]
		internal object FJGDACCEJHA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F1")]
	private readonly OHBMAKCLEEN KGCEDLPDMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	private GIKEOCBMNEF PEJLPMNJAON;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private MFDOGKHNMAA JKEEOHKCKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x128DFA0", Offset = "0x128C9A0", VA = "0x18128DFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public KBJPDNDKAJC(OHBMAKCLEEN KGCEDLPDMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x8BF5C70", Offset = "0x8BF4670", VA = "0x188BF5C70")]
	[AsyncStateMachine(typeof(CMFCEIDMJNC))]
	public Task JCNNIFHFEKH(KNOBEKJADBE EBODKBGKJOH, ALPHANGLKLD COOMMKFGFGC, OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x8BF5F10", Offset = "0x8BF4910", VA = "0x188BF5F10")]
	[AsyncStateMachine(typeof(JOCLHAFCLCJ))]
	private Task OMHBJEDLMME(ALPHANGLKLD GPCDCFCPGFK, OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x8BF6410", Offset = "0x8BF4E10", VA = "0x188BF6410")]
	[AsyncStateMachine(typeof(OBPNFPGJABB))]
	private Task PPEDHILACDM(ALPHANGLKLD GPCDCFCPGFK, OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x8BF62D0", Offset = "0x8BF4CD0", VA = "0x188BF62D0")]
	[AsyncStateMachine(typeof(FIMNHIDGJKN))]
	private Task PHKFICLMIDE(ALPHANGLKLD GPCDCFCPGFK, OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x8BF5DC0", Offset = "0x8BF47C0", VA = "0x188BF5DC0")]
	[AsyncStateMachine(typeof(BMJKOCHFGCK))]
	private Task JFOBMFHKEDO(Guid BHIFHOKAMHG, List<KLGCNLILPBP> PBAOFIOBLMN, FALDLNAGKBL ADIGPNCHDJO, ALPHANGLKLD GPCDCFCPGFK, CancellationToken DHNMCOFINFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x8BF5950", Offset = "0x8BF4350", VA = "0x188BF5950")]
	[AsyncStateMachine(typeof(OJIONICHKCA))]
	private Task HDAIMJDMHFB(ALPHANGLKLD GPCDCFCPGFK, OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x8BF6050", Offset = "0x8BF4A50", VA = "0x188BF6050")]
	[AsyncStateMachine(typeof(GMOONAHNAIB))]
	private Task ONCJGEDLDAN(Guid BOHGKJKAGKI, ALPHANGLKLD GPCDCFCPGFK, OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x8BF6190", Offset = "0x8BF4B90", VA = "0x188BF6190")]
	[AsyncStateMachine(typeof(GOAJLNHAPHI))]
	private Task PFKDLFDHNMJ(Guid BOHGKJKAGKI, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x8BF56C0", Offset = "0x8BF40C0", VA = "0x188BF56C0")]
	private void GDAAFEJIGNA(Guid BOHGKJKAGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x8BF5610", Offset = "0x8BF4010", VA = "0x188BF5610")]
	private void EGMAAPHAHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x8BF57E0", Offset = "0x8BF41E0", VA = "0x188BF57E0")]
	public Guid GDCCEJJPJDG(KNOBEKJADBE AMGDJDJGOLC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x8BF5A90", Offset = "0x8BF4490", VA = "0x188BF5A90")]
	[CompilerGenerated]
	private object HNFDBFGFJFM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal struct HEFNJCCOEBO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private struct LDKDDHIAJLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public HEFNJCCOEBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		private IEnumerator<AFKECIDEIKC> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x8BF72D0", Offset = "0x8BF5CD0", VA = "0x188BF72D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7970", Offset = "0x8BF6370", VA = "0x188BF7970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000751")]
	private KGCDOOPNJBJ JDNAAPNIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000752")]
	private OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000753")]
	private CancellationToken OMJKEHOJJFF;

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x8BF3980", Offset = "0x8BF2380", VA = "0x188BF3980")]
	public static Task DABGNJEFBCP(KGCDOOPNJBJ JDNAAPNIDID, OGMJCPNEHOO<string>.LOEEEDILNMC HIBNALIEBDI, CancellationToken FACNKJHPOCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x8BF39F0", Offset = "0x8BF23F0", VA = "0x188BF39F0")]
	[AsyncStateMachine(typeof(LDKDDHIAJLE))]
	private Task JCNNIFHFEKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
public readonly struct GFFHLOLHICK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075A")]
	public readonly bool NDBMGLAPGPN;

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8EC0", Offset = "0x2CC78C0", VA = "0x182CC8EC0")]
	public GFFHLOLHICK(bool HKIOHIIGOME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public readonly struct HNFMIDJGFGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075B")]
	public readonly AJDHPEOBCFP? LEOFIKIGHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400075C")]
	public readonly GFIFJMJJLFA KEMMJOANJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400075D")]
	public readonly Guid? IAGHKHMHFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400075E")]
	public readonly IReadOnlyList<Guid> AMMBPCELEKD;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public IReadOnlyCollection<string> OLFAHAFLAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x8BF3F10", Offset = "0x8BF2910", VA = "0x188BF3F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public IReadOnlyDictionary<long, int> GGJHDIAMCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x8BF3EF0", Offset = "0x8BF28F0", VA = "0x188BF3EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x8BF3F30", Offset = "0x8BF2930", VA = "0x188BF3F30")]
	public HNFMIDJGFGN(AJDHPEOBCFP? OBPEHAFILEK, GFIFJMJJLFA DIMBMLIGFOB, Guid? IDCJGBECDDM, [Optional] IReadOnlyList<Guid>? MOKDNCNENNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal class BDPABHELFBH : ENMMKPENCJF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private struct GALIBMMMMMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public AsyncTaskMethodBuilder<HNFMIDJGFGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public BDPABHELFBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public MIOKGJCEPIK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public OCOGPPDAFJO roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		private OJMINOEPFCH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1530", Offset = "0x8BEFF30", VA = "0x188BF1530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1BD0", Offset = "0x8BF05D0", VA = "0x188BF1BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class MEEIDNHOKOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public MEEIDNHOKOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8660", Offset = "0x8BF7060", VA = "0x188BF8660")]
		internal object ACAOIAOEKHK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private struct KJGEOGOFINH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public BDPABHELFBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public MIOKGJCEPIK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		private MEEIDNHOKOK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		private OJMINOEPFCH <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		private MFJNMJILDKH<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6650", Offset = "0x8BF5050", VA = "0x188BF6650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7200", Offset = "0x8BF5C00", VA = "0x188BF7200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400075F")]
	private readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x4000760")]
	private static readonly TimeSpan LGEJHBMPDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000761")]
	private readonly ELOJBDFDFFM HLHOMLLEAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000762")]
	private readonly KHCLOMHNKNA BCKGJNPOBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000763")]
	private readonly OGJABJCHHGF FJONHDJLPAI;

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x8BEA820", Offset = "0x8BE9220", VA = "0x188BEA820")]
	public BDPABHELFBH(OHBMAKCLEEN KGCEDLPDMEO, ELOJBDFDFFM HLHOMLLEAGA, KHCLOMHNKNA AJMBNONDLBF, OGJABJCHHGF FJONHDJLPAI, MEBJEIOEDLD HJHMNJLNNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x8BE9570", Offset = "0x8BE7F70", VA = "0x188BE9570")]
	[AsyncStateMachine(typeof(GALIBMMMMMI))]
	public Task<HNFMIDJGFGN> AGNKEKDJGCC(long JOIKPPGBGCF, OCOGPPDAFJO KECGDFMGAMO, MIOKGJCEPIK PMPJINGFHBP, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x8BEA6C0", Offset = "0x8BE90C0", VA = "0x188BEA6C0")]
	private static bool NNCGBHCGLFF(PersistenceView EGPPKOBFLID, [Out] KIFAOOMDKML CKBKFDACKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x8BEA580", Offset = "0x8BE8F80", VA = "0x188BEA580")]
	[AsyncStateMachine(typeof(KJGEOGOFINH))]
	private Task JNFKCAMDOKI(MIOKGJCEPIK PMPJINGFHBP, PersistenceView[] PGFPOHCBFOP, StringBuilder BGFFOKGAFDN, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x8BE9910", Offset = "0x8BE8310", VA = "0x188BE9910")]
	private HNFMIDJGFGN FGMEGECOBDF(long JOIKPPGBGCF, OCOGPPDAFJO KECGDFMGAMO, MIOKGJCEPIK PMPJINGFHBP, IEnumerable<PersistenceView> PGFPOHCBFOP, StringBuilder BGFFOKGAFDN)
	{
		return default(HNFMIDJGFGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x8BEA3C0", Offset = "0x8BE8DC0", VA = "0x188BEA3C0")]
	private AJDHPEOBCFP JEHMHBPPEOC(long JOIKPPGBGCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x8BE96C0", Offset = "0x8BE80C0", VA = "0x188BE96C0")]
	private void AIJJBGKODEM(AJDHPEOBCFP LAJDMLONDKB, StringBuilder BGFFOKGAFDN, IEnumerable<PersistenceView> PGFPOHCBFOP, [In] DHJPAILKIOA HLJPNDHEBEG, GALGMADDFIP ABBMHACAOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x8BE9F20", Offset = "0x8BE8920", VA = "0x188BE9F20")]
	private void JCEHJHNFEIE(AJDHPEOBCFP LAJDMLONDKB, StringBuilder BGFFOKGAFDN, PersistenceView EGPPKOBFLID, GALGMADDFIP ABBMHACAOIN, [In] DHJPAILKIOA HLJPNDHEBEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal class ENFPHAGBADI : ENMMKPENCJF
{
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private sealed class AIIODBAILAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public AMIAOJBFLFI.LBKJHLAMGGL roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public AIIODBAILAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x8BE8D20", Offset = "0x8BE7720", VA = "0x188BE8D20")]
		internal object GEAFCLMKGKI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct JOLALEEGPMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public AsyncTaskMethodBuilder<(AMIAOJBFLFI.LBKJHLAMGGL roomDataUpload, AMIAOJBFLFI.LBKJHLAMGGL subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public HNFMIDJGFGN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public KGCDOOPNJBJ callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		private AIIODBAILAJ <>8__1;

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
		private TaskAwaiter<AMIAOJBFLFI.LBKJHLAMGGL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x8BF49F0", Offset = "0x8BF33F0", VA = "0x188BF49F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5270", Offset = "0x8BF3C70", VA = "0x188BF5270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private struct OAKHNKKKFHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public AsyncTaskMethodBuilder<JCHGMBODNBK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public ENFPHAGBADI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public BBLKGPIDOCC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public HNFMIDJGFGN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		private TaskAwaiter<JCHGMBODNBK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA660", Offset = "0x8BF9060", VA = "0x188BFA660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA900", Offset = "0x8BF9300", VA = "0x188BFA900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private struct NEOIFPHGFGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public AsyncTaskMethodBuilder<JCHGMBODNBK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public KGCDOOPNJBJ callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public HNFMIDJGFGN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public MEHJAKMDOOK ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public BBLKGPIDOCC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		private TaskAwaiter<(AMIAOJBFLFI.LBKJHLAMGGL roomDataUpload, AMIAOJBFLFI.LBKJHLAMGGL subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		private TaskAwaiter<JCHGMBODNBK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9F90", Offset = "0x8BF8990", VA = "0x188BF9F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA5F0", Offset = "0x8BF8FF0", VA = "0x188BFA5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private struct DILHCOMFPDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		public AsyncTaskMethodBuilder<DLAPJAGBOIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		public ENFPHAGBADI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		public HNFMIDJGFGN roomSerializedData;

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
		private TaskAwaiter<(AMIAOJBFLFI.LBKJHLAMGGL roomDataUpload, AMIAOJBFLFI.LBKJHLAMGGL subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		private TaskAwaiter<DLAPJAGBOIF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x8BEED10", Offset = "0x8BED710", VA = "0x188BEED10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF1C0", Offset = "0x8BEDBC0", VA = "0x188BEF1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[CompilerGenerated]
	private sealed class GDMJFBEEGCK
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
			public AsyncTaskMethodBuilder<FPMLGPKCMLB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			public GDMJFBEEGCK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			private FPMLGPKCMLB <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			private TaskAwaiter<DLAPJAGBOIF> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007B7")]
			private TaskAwaiter<JCHGMBODNBK> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007B8")]
			private TaskAwaiter<FPMLGPKCMLB> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE450", Offset = "0x8BFCE50", VA = "0x188BFE450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0x8BFF650", Offset = "0x8BFE050", VA = "0x188BFF650", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public ENFPHAGBADI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public HNFMIDJGFGN roomSerializedData;

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
		public BBLKGPIDOCC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		public GFFHLOLHICK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GDMJFBEEGCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1C40", Offset = "0x8BF0640", VA = "0x188BF1C40")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<FPMLGPKCMLB> BMBGEKDPIOK(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[CompilerGenerated]
	private struct CILJDIPFEEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		public AsyncTaskMethodBuilder<FPMLGPKCMLB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public ENFPHAGBADI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public HNFMIDJGFGN roomSerializedData;

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
		public BBLKGPIDOCC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public GFFHLOLHICK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		private TaskAwaiter<FPMLGPKCMLB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x8BEBCE0", Offset = "0x8BEA6E0", VA = "0x188BEBCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x8BEC010", Offset = "0x8BEAA10", VA = "0x188BEC010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400077D")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x400077E")]
	private static readonly MEBJEIOEDLD HPABEMJCJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400077F")]
	private readonly EHCGFOOAAPC LEFBGFJGOPL;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private PKEIPCLCGCJ CACGEGMOACI
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC970", Offset = "0x8BCB370", VA = "0x188BCC970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x8BF0670", Offset = "0x8BEF070", VA = "0x188BF0670")]
	public ENFPHAGBADI(OHBMAKCLEEN KGCEDLPDMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x8BF0480", Offset = "0x8BEEE80", VA = "0x188BF0480")]
	[AsyncStateMachine(typeof(JOLALEEGPMD))]
	private static Task<(AMIAOJBFLFI.LBKJHLAMGGL, AMIAOJBFLFI.LBKJHLAMGGL)> LKNPHOEGGNI(KGCDOOPNJBJ JDNAAPNIDID, HNFMIDJGFGN CDKAFKOFPNO, long DKMPIOFKFMN, long JCFCCOKDCNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x8BEFE30", Offset = "0x8BEE830", VA = "0x188BEFE30")]
	[AsyncStateMachine(typeof(OAKHNKKKFHJ))]
	public Task<JCHGMBODNBK> HNBENLPMBOF(int BIJMEFDNJBK, [CanBeNull] BBLKGPIDOCC FEBMKDPBPHE, HNFMIDJGFGN CDKAFKOFPNO, long DKMPIOFKFMN, long JCFCCOKDCNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x8BEFFA0", Offset = "0x8BEE9A0", VA = "0x188BEFFA0")]
	public static Task<JCHGMBODNBK> HNBENLPMBOF(KGCDOOPNJBJ JDNAAPNIDID, int BIJMEFDNJBK, [CanBeNull] BBLKGPIDOCC FEBMKDPBPHE, HNFMIDJGFGN CDKAFKOFPNO, long DKMPIOFKFMN, long JCFCCOKDCNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x8BF02F0", Offset = "0x8BEECF0", VA = "0x188BF02F0")]
	[AsyncStateMachine(typeof(NEOIFPHGFGP))]
	public static Task<JCHGMBODNBK> HNBENLPMBOF(KGCDOOPNJBJ JDNAAPNIDID, int BIJMEFDNJBK, [CanBeNull] BBLKGPIDOCC FEBMKDPBPHE, HNFMIDJGFGN CDKAFKOFPNO, long DKMPIOFKFMN, long JCFCCOKDCNL, MEHJAKMDOOK OLGINPALGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x8BEFB00", Offset = "0x8BEE500", VA = "0x188BEFB00")]
	[AsyncStateMachine(typeof(DILHCOMFPDJ))]
	private Task<DLAPJAGBOIF> BNFJMFKMCKG(string MIMKOOGLIBI, int BIJMEFDNJBK, HNFMIDJGFGN CDKAFKOFPNO, long DKMPIOFKFMN, long JCFCCOKDCNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x8BEFC80", Offset = "0x8BEE680", VA = "0x188BEFC80")]
	[AsyncStateMachine(typeof(CILJDIPFEEH))]
	public Task<FPMLGPKCMLB> DDBMEDPBPAJ(int BIJMEFDNJBK, BBLKGPIDOCC? FEBMKDPBPHE, HNFMIDJGFGN CDKAFKOFPNO, long DKMPIOFKFMN, long JCFCCOKDCNL, GFFHLOLHICK CKGAAIFJFHK, OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public abstract class BDILAMEOPOH<T> where T : BDILAMEOPOH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C5")]
	internal readonly PKEIPCLCGCJ GGDEKCOBPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C6")]
	private int? MCKDMADFBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C7")]
	protected readonly Guid MOHCIPMJKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C8")]
	protected readonly FPJCCCPHHPB LJJAPPIDIMG;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	protected T LJDFEGLEIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x64B5550", Offset = "0x64B3F50", VA = "0x1864B5550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x64B5640", Offset = "0x64B4040", VA = "0x1864B5640")]
	internal BDILAMEOPOH(PKEIPCLCGCJ DACDLNJAONN, FPJCCCPHHPB KGCMMEAFMPJ, [Optional] Guid? BJGNCPGGOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x64B52D0", Offset = "0x64B3CD0", VA = "0x1864B52D0")]
	private FPMLGPKCMLB DFIIIOJNMPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	protected virtual void LBAHDCCJNBJ(FPMLGPKCMLB ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x64B53B0", Offset = "0x64B3DB0", VA = "0x1864B53B0")]
	public T DPMOKEDJOJF(POIAKMBAMML PIAAPOBLMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x64B55B0", Offset = "0x64B3FB0", VA = "0x1864B55B0")]
	public T OPAGADNJCHK(int LJJOHIJDHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x64B5440", Offset = "0x64B3E40", VA = "0x1864B5440", Slot = "5")]
	public virtual Task<FNEGFJHAODE> MKKMCPOLFGK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public class CIBFDAJCAMN : BDILAMEOPOH<CIBFDAJCAMN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007C9")]
	private MLFBJBKAEMO EEMEEFCIEHD;

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x8BEBC10", Offset = "0x8BEA610", VA = "0x188BEBC10")]
	internal CIBFDAJCAMN(PKEIPCLCGCJ DACDLNJAONN, FPJCCCPHHPB KGCMMEAFMPJ, [Optional] Guid? BJGNCPGGOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D76FE0", Offset = "0x7D759E0", VA = "0x187D76FE0")]
	public CIBFDAJCAMN GBIEHCIOAKH(MLFBJBKAEMO EEMEEFCIEHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x8BEBB40", Offset = "0x8BEA540", VA = "0x188BEBB40", Slot = "4")]
	protected override void LBAHDCCJNBJ(FPMLGPKCMLB ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public class CFNOBLNFNJK : BDILAMEOPOH<CFNOBLNFNJK>
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	internal enum FNBAAKEMCLE
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
	private struct EHPECNACEED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		public AsyncTaskMethodBuilder<FNEGFJHAODE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		public CFNOBLNFNJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		private TaskAwaiter<FNEGFJHAODE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF6F0", Offset = "0x8BEE0F0", VA = "0x188BEF6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFA90", Offset = "0x8BEE490", VA = "0x188BEFA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007CA")]
	private FNBAAKEMCLE EINDKEDJLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007CB")]
	private string KEPOHJFEAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007CC")]
	private BBLKGPIDOCC EEMEEFCIEHD;

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x8BEB9D0", Offset = "0x8BEA3D0", VA = "0x188BEB9D0")]
	internal CFNOBLNFNJK(PKEIPCLCGCJ DACDLNJAONN, FPJCCCPHHPB KGCMMEAFMPJ, [Optional] Guid? BJGNCPGGOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x8BEB9A0", Offset = "0x8BEA3A0", VA = "0x188BEB9A0")]
	public CFNOBLNFNJK OCFOOMDJJAH(string IGEOMPONAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x8BEB690", Offset = "0x8BEA090", VA = "0x188BEB690")]
	public CFNOBLNFNJK JMCNKLBCFKM(bool OAGEJPDFAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x8BEB6B0", Offset = "0x8BEA0B0", VA = "0x188BEB6B0")]
	public CFNOBLNFNJK KEMCKLOCMBE(bool NKCACKBLAJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x8BEB710", Offset = "0x8BEA110", VA = "0x188BEB710")]
	public CFNOBLNFNJK KNJKFIKIOHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x8BEB740", Offset = "0x8BEA140", VA = "0x188BEB740", Slot = "4")]
	protected override void LBAHDCCJNBJ(FPMLGPKCMLB ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x8BEB8B0", Offset = "0x8BEA2B0", VA = "0x188BEB8B0", Slot = "5")]
	[AsyncStateMachine(typeof(EHPECNACEED))]
	public override Task<FNEGFJHAODE> MKKMCPOLFGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x8BEB6D0", Offset = "0x8BEA0D0", VA = "0x188BEB6D0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<FNEGFJHAODE> KIDHCDLMDJJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
internal static class CPPHAIBAAEB
{
	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x8BED990", Offset = "0x8BEC390", VA = "0x188BED990")]
	public static void PIEIDKCLMPH(this DKMBMPCHLAM BKBBDIPJDPA, FIICLMFOJBM DGNADGIHMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x8BED910", Offset = "0x8BEC310", VA = "0x188BED910")]
	public static void CCCKAHBDCDI(this FIICLMFOJBM KEOPPNFKOEL, [Optional] string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B7")]
public static class OHPPABBAAKJ
{
	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x8BFB090", Offset = "0x8BF9A90", VA = "0x188BFB090")]
	public static HCMJMHBJMFG HAPBEBOKLDE(this FOBFJOFLHLD AIGPNBPHAOM)
	{
		return default(HCMJMHBJMFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x8BFB130", Offset = "0x8BF9B30", VA = "0x188BFB130")]
	public static FOBFJOFLHLD HHNFIDOABBF(this HCMJMHBJMFG AAFCLMJCKNG)
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
			public OGAHAPMAOOE ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			public OGAHAPMAOOE HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private static OGAHAPMAOOE[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		private Dictionary<OGAHAPMAOOE, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x8BFFDB0", Offset = "0x8BFE7B0", VA = "0x188BFFDB0")]
		public bool LOHGMPKKBBM(OGAHAPMAOOE GEHFNMHGHJN, [Out] ResultConfig CJFJFBGGCAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x8BFFC70", Offset = "0x8BFE670", VA = "0x188BFFC70")]
		public ResultConfig AAPDADIDKNK(OGAHAPMAOOE HDDLNGLMMKN, [Optional] HashSet<OGAHAPMAOOE> KAHDDBPNLLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x8C00380", Offset = "0x8BFED80", VA = "0x188C00380", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x8BFFE20", Offset = "0x8BFE820", VA = "0x188BFFE20", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xD12090", Offset = "0xD10A90", VA = "0x180D12090")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
public class PALDKAEEBJO : AOHKHOJNHBD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[CompilerGenerated]
	private struct AMLHNPCPCJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		public PALDKAEEBJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x8BE8E60", Offset = "0x8BE7860", VA = "0x188BE8E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x8BE90F0", Offset = "0x8BE7AF0", VA = "0x188BE90F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BD")]
	[CompilerGenerated]
	private struct MNHNOCBDHKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		public AOHKHOJNHBD preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x8BF86D0", Offset = "0x8BF70D0", VA = "0x188BF86D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8B80", Offset = "0x8BF7580", VA = "0x188BF8B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007E4")]
	private readonly MGHICKJEDBJ DBIPNAHBKLL;

	[Cpp2IlInjected.Token(Token = "0x40007E5")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string FEDDKDKLMEF
	{
		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BFCE80", Offset = "0x8BFB880", VA = "0x188BFCE80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x8BFCFC0", Offset = "0x8BFB9C0", VA = "0x188BFCFC0")]
	[PPMDKOHJEBA.KMGFFEOOKKA.HAOMKJDLLID]
	internal static void JDFNEBKBOEL(CFAMNNNCHJA GEPFIGLFPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	[RecRoom.NoEngine.Common.Preserve]
	public PALDKAEEBJO([LNLOHEINMEO(null)] MGHICKJEDBJ DBIPNAHBKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x8BFCEB0", Offset = "0x8BFB8B0", VA = "0x188BFCEB0", Slot = "5")]
	[AsyncStateMachine(typeof(AMLHNPCPCJG))]
	public Task JCNNIFHFEKH(OGMJCPNEHOO<string>.LOEEEDILNMC KEEEDCAGGGG, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x8BFCD60", Offset = "0x8BFB760", VA = "0x188BFCD60")]
	[AsyncStateMachine(typeof(MNHNOCBDHKG))]
	private Task AMABAKFIGFI(AOHKHOJNHBD DIHOHCENNMA, OGMJCPNEHOO<string>.LOEEEDILNMC KEEEDCAGGGG, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public interface MGHICKJEDBJ : AOHKHOJNHBD
{
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public interface AOHKHOJNHBD
{
	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	string FEDDKDKLMEF
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JCNNIFHFEKH(OGMJCPNEHOO<string>.LOEEEDILNMC KEEEDCAGGGG, CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public static class HKLCOBJDBMO
{
	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x8BF3AE0", Offset = "0x8BF24E0", VA = "0x188BF3AE0")]
	[PPMDKOHJEBA.KMGFFEOOKKA.HAOMKJDLLID]
	internal static void EIKIOMKMPDG(CFAMNNNCHJA GEPFIGLFPCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
public interface JBJNNHCHIGL : IEquatable<JBJNNHCHIGL>
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	DateTime DDGCBOKKGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKELAMNNKNM();

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MOIKEFFGADM(long DKMPIOFKFMN, long JOIKPPGBGCF, [Out] HNFMIDJGFGN CDKAFKOFPNO);
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
internal class PKDGMIPPCOO : HKBKALLJCLJ
{
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[CompilerGenerated]
	private sealed class INOPCFOGIKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		public AHLLAMLIAPD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public INOPCFOGIKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4030", Offset = "0x8BF2A30", VA = "0x188BF4030")]
		internal object AEIOKPFKKJP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F3")]
	private readonly MNJDMOKLHFI FPKLMOMPHEF;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<JBJNNHCHIGL> JPEGNMHGHGK
	{
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD1C0", Offset = "0x8BFBBC0", VA = "0x188BFD1C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD570", Offset = "0x8BFBF70", VA = "0x188BFD570", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	[UnityEngine.Scripting.Preserve]
	public PKDGMIPPCOO([LNLOHEINMEO(null)] MNJDMOKLHFI FPKLMOMPHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x8BFD270", Offset = "0x8BFBC70", VA = "0x188BFD270", Slot = "6")]
	public bool FPMCBJJLCFJ(long DKMPIOFKFMN, long JOIKPPGBGCF, HNFMIDJGFGN CDKAFKOFPNO, AHLLAMLIAPD MJAEFDLBIKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0xF285C0", Offset = "0xF26FC0", VA = "0x180F285C0")]
	private void MICIMKPEPAD(JBJNNHCHIGL CMMNIMNPMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x8BFDAF0", Offset = "0x8BFC4F0", VA = "0x188BFDAF0", Slot = "7")]
	public bool PNGNABEIPOP(long DKMPIOFKFMN, long JOIKPPGBGCF, [Out] JBJNNHCHIGL CBJDOBLNCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x8BFDA40", Offset = "0x8BFC440", VA = "0x188BFDA40", Slot = "8")]
	public bool KPLGPHPCMPE(long DKMPIOFKFMN, long JOIKPPGBGCF, AHLLAMLIAPD MJAEFDLBIKK, [Out] JBJNNHCHIGL CBJDOBLNCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x8BFD620", Offset = "0x8BFC020", VA = "0x188BFD620")]
	private void KPCCBEEKODN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x8BFD0A0", Offset = "0x8BFBAA0", VA = "0x188BFD0A0", Slot = "9")]
	public void ABHMBIIFOEE(long DKMPIOFKFMN, long JOIKPPGBGCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
internal abstract class CJFDBJNKPDA : MNJDMOKLHFI
{
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	protected enum JDLNBDFCIPL : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[CompilerGenerated]
	private sealed class KBJOIKNOKMD : IEnumerable<JBJNNHCHIGL>, IEnumerable, IEnumerator<JBJNNHCHIGL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		private JBJNNHCHIGL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		public CJFDBJNKPDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		private AHLLAMLIAPD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		public AHLLAMLIAPD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000803")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private JBJNNHCHIGL System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
		[DebuggerHidden]
		public KBJOIKNOKMD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x8BF52E0", Offset = "0x8BF3CE0", VA = "0x188BF52E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x8BF55C0", Offset = "0x8BF3FC0", VA = "0x188BF55C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5510", Offset = "0x8BF3F10", VA = "0x188BF5510", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JBJNNHCHIGL> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5510", Offset = "0x8BF3F10", VA = "0x188BF5510", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[CompilerGenerated]
	private sealed class MPAODFEOPEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		public AHLLAMLIAPD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public MPAODFEOPEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9EF0", Offset = "0x8BF88F0", VA = "0x188BF9EF0")]
		internal object AAKAFGDFLFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[CompilerGenerated]
	private sealed class KCBPMJGGOAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000807")]
		public CJFDBJNKPDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000808")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KCBPMJGGOAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6550", Offset = "0x8BF4F50", VA = "0x188BF6550")]
		internal void KIPKIDCKJEL(INENGAMLDBB.OAIOGADIKOP ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F9")]
	private readonly object BEINCCKHCDA;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	protected string GLEIBDAMHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x8BEC400", Offset = "0x8BEAE00", VA = "0x188BEC400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public abstract AODLEIDFJEK KMOKJKIFHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x8BECAC0", Offset = "0x8BEB4C0", VA = "0x188BECAC0")]
	protected CJFDBJNKPDA([CanBeNull] string AMMCFBLMIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x8BEC860", Offset = "0x8BEB260", VA = "0x188BEC860", Slot = "5")]
	public bool MCCOIGAMHBG(long DKMPIOFKFMN, long JOIKPPGBGCF, AHLLAMLIAPD MJAEFDLBIKK, [Out] JBJNNHCHIGL CMMNIMNPMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x8BEC410", Offset = "0x8BEAE10", VA = "0x188BEC410", Slot = "6")]
	[IteratorStateMachine(typeof(KBJOIKNOKMD))]
	public IEnumerable<JBJNNHCHIGL> HHNMDGGLDNH(AHLLAMLIAPD MJAEFDLBIKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void JLKBEFIPPMH(Stream KBHJNHLILNO, long DKMPIOFKFMN, long JOIKPPGBGCF, HNFMIDJGFGN CDKAFKOFPNO);

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool JAEOKEDPOAK(Stream CEPADNFEMIP, long DKMPIOFKFMN, long JOIKPPGBGCF, FBLKCELCLGF KOMDBFGMKEH, [Out] HNFMIDJGFGN CDKAFKOFPNO);

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x8BEC080", Offset = "0x8BEAA80", VA = "0x188BEC080", Slot = "7")]
	public JBJNNHCHIGL BMOCPOIFIHL(long DKMPIOFKFMN, long JOIKPPGBGCF, HNFMIDJGFGN CDKAFKOFPNO, AHLLAMLIAPD MJAEFDLBIKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo BLLNOAIACIP(long DKMPIOFKFMN, long JOIKPPGBGCF, AHLLAMLIAPD MJAEFDLBIKK, JDLNBDFCIPL PMFIOGLIPDJ);

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo PJDPLGBMEPC(AHLLAMLIAPD MJAEFDLBIKK, JDLNBDFCIPL PMFIOGLIPDJ);

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x8BECA50", Offset = "0x8BEB450", VA = "0x188BECA50")]
	protected void NACMNKCKBJC(INENGAMLDBB.OAIOGADIKOP JLPKOFPIOMC, string LJCGGLBEFFM, FileInfo BBJJIPJJFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x8BEC4A0", Offset = "0x8BEAEA0", VA = "0x188BEC4A0")]
	internal bool KLDMPPBKDHJ(FileInfo MBPLCKMKEDK, long DKMPIOFKFMN, long JOIKPPGBGCF, [Out] HNFMIDJGFGN CDKAFKOFPNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	private void GNGKAHCLDEA(Exception CMHNFFEOOMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
internal class OIBGGKABBKO : CJFDBJNKPDA
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public override AODLEIDFJEK KMOKJKIFHGC
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x1491EE0", Offset = "0x14908E0", VA = "0x181491EE0", Slot = "8")]
		get
		{
			return default(AODLEIDFJEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x8BFBE00", Offset = "0x8BFA800", VA = "0x188BFBE00")]
	public OIBGGKABBKO([Optional] string AMMCFBLMIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x8BFBC80", Offset = "0x8BFA680", VA = "0x188BFBC80")]
	private void PBDOCHOPMEA(AHLLAMLIAPD MJAEFDLBIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x8BFB9D0", Offset = "0x8BFA3D0", VA = "0x188BFB9D0", Slot = "9")]
	internal override void JLKBEFIPPMH(Stream KBHJNHLILNO, long DKMPIOFKFMN, long JOIKPPGBGCF, HNFMIDJGFGN CDKAFKOFPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x8BFB2D0", Offset = "0x8BF9CD0", VA = "0x188BFB2D0", Slot = "10")]
	internal override bool JAEOKEDPOAK(Stream CEPADNFEMIP, long DKMPIOFKFMN, long JOIKPPGBGCF, FBLKCELCLGF KOMDBFGMKEH, [Out] HNFMIDJGFGN CDKAFKOFPNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x8BFB1E0", Offset = "0x8BF9BE0", VA = "0x188BFB1E0", Slot = "11")]
	protected override FileInfo BLLNOAIACIP(long DKMPIOFKFMN, long JOIKPPGBGCF, AHLLAMLIAPD MJAEFDLBIKK, JDLNBDFCIPL PMFIOGLIPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x8BFBD00", Offset = "0x8BFA700", VA = "0x188BFBD00", Slot = "12")]
	protected override DirectoryInfo PJDPLGBMEPC(AHLLAMLIAPD MJAEFDLBIKK, JDLNBDFCIPL PMFIOGLIPDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
internal sealed class MOGJMJJCFGB : CJFDBJNKPDA
{
	[Cpp2IlInjected.Token(Token = "0x4000809")]
	private static readonly byte[] LNBCHJPEENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400080A")]
	private readonly byte[] BKLMMLLMECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400080B")]
	private readonly byte[] FLJHHPJPBCJ;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public override AODLEIDFJEK KMOKJKIFHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x1A60A40", Offset = "0x1A5F440", VA = "0x181A60A40", Slot = "8")]
		get
		{
			return default(AODLEIDFJEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x8BF9E00", Offset = "0x8BF8800", VA = "0x188BF9E00")]
	public MOGJMJJCFGB([Optional] string AMMCFBLMIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x8BF9840", Offset = "0x8BF8240", VA = "0x188BF9840", Slot = "9")]
	internal override void JLKBEFIPPMH(Stream KBHJNHLILNO, long DKMPIOFKFMN, long JOIKPPGBGCF, HNFMIDJGFGN CDKAFKOFPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x8BF8DD0", Offset = "0x8BF77D0", VA = "0x188BF8DD0", Slot = "10")]
	internal override bool JAEOKEDPOAK(Stream CEPADNFEMIP, long DKMPIOFKFMN, long JOIKPPGBGCF, FBLKCELCLGF KOMDBFGMKEH, [Out] HNFMIDJGFGN CDKAFKOFPNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x8BF8D10", Offset = "0x8BF7710", VA = "0x188BF8D10")]
	private void FPOGAIDBOME(byte[] LHALFHPGBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x8BF8BE0", Offset = "0x8BF75E0", VA = "0x188BF8BE0", Slot = "11")]
	protected override FileInfo BLLNOAIACIP(long DKMPIOFKFMN, long JOIKPPGBGCF, AHLLAMLIAPD MJAEFDLBIKK, JDLNBDFCIPL PMFIOGLIPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x8BF9C60", Offset = "0x8BF8660", VA = "0x188BF9C60", Slot = "12")]
	protected override DirectoryInfo PJDPLGBMEPC(AHLLAMLIAPD MJAEFDLBIKK, JDLNBDFCIPL PMFIOGLIPDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
public enum AODLEIDFJEK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400080F")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000810")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000811")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
internal class OOABKGPCNLG : MNJDMOKLHFI
{
	[Cpp2IlInjected.Token(Token = "0x20001D0")]
	[CompilerGenerated]
	private sealed class EAFJPEKEEEP : IEnumerable<JBJNNHCHIGL>, IEnumerable, IEnumerator<JBJNNHCHIGL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		private JBJNNHCHIGL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		public OOABKGPCNLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		private AHLLAMLIAPD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		public AHLLAMLIAPD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		private AODLEIDFJEK[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		private IEnumerator<JBJNNHCHIGL> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		private JBJNNHCHIGL System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
		[DebuggerHidden]
		public EAFJPEKEEEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF660", Offset = "0x8BEE060", VA = "0x188BEF660", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF280", Offset = "0x8BEDC80", VA = "0x188BEF280", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF230", Offset = "0x8BEDC30", VA = "0x188BEF230")]
		private void ALLLMJKJJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF610", Offset = "0x8BEE010", VA = "0x188BEF610", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF560", Offset = "0x8BEDF60", VA = "0x188BEF560", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JBJNNHCHIGL> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF560", Offset = "0x8BEDF60", VA = "0x188BEF560", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000812")]
	private readonly AODLEIDFJEK[] GFMLBOMJHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000813")]
	private readonly Dictionary<AODLEIDFJEK, MNJDMOKLHFI> AJDOPKOBJLA;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public AODLEIDFJEK KMOKJKIFHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC9E0", Offset = "0x8BFB3E0", VA = "0x188BFC9E0", Slot = "4")]
		get
		{
			return default(AODLEIDFJEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x8BFCA10", Offset = "0x8BFB410", VA = "0x188BFCA10")]
	[UnityEngine.Scripting.Preserve]
	public OOABKGPCNLG(params MNJDMOKLHFI[] NGMONPGHMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x8BFC890", Offset = "0x8BFB290", VA = "0x188BFC890", Slot = "5")]
	public bool MCCOIGAMHBG(long DKMPIOFKFMN, long JOIKPPGBGCF, AHLLAMLIAPD MJAEFDLBIKK, [Out] JBJNNHCHIGL CMMNIMNPMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x8BFC650", Offset = "0x8BFB050", VA = "0x188BFC650")]
	private void JKBNMMEELCD(int KODNKAKHLJG, long DKMPIOFKFMN, long JOIKPPGBGCF, AHLLAMLIAPD MJAEFDLBIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x8BFC5C0", Offset = "0x8BFAFC0", VA = "0x188BFC5C0", Slot = "6")]
	[IteratorStateMachine(typeof(EAFJPEKEEEP))]
	public IEnumerable<JBJNNHCHIGL> HHNMDGGLDNH(AHLLAMLIAPD MJAEFDLBIKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x8BFC460", Offset = "0x8BFAE60", VA = "0x188BFC460", Slot = "7")]
	public JBJNNHCHIGL BMOCPOIFIHL(long DKMPIOFKFMN, long JOIKPPGBGCF, HNFMIDJGFGN CDKAFKOFPNO, AHLLAMLIAPD MJAEFDLBIKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
internal static class BGFLAKLGGLN
{
	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x8BEAEC0", Offset = "0x8BE98C0", VA = "0x188BEAEC0")]
	internal static byte[] MOEPJFINAHM(byte[] LHALFHPGBPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x8BEAE40", Offset = "0x8BE9840", VA = "0x188BEAE40")]
	public static void JICHKHIICJN(Stream AKDFBDNJGIO, byte[] ANODLDIABGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x8BEAF80", Offset = "0x8BE9980", VA = "0x188BEAF80")]
	public static bool OPIJFIMGDDP(Stream AKDFBDNJGIO, long MHKOAIJDMEP, FBLKCELCLGF CBMMGMIMHGK, [Out] byte[] NNKBFDKHGHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
internal sealed class CJPKMGAOLOE : JBJNNHCHIGL, IEquatable<JBJNNHCHIGL>, IEquatable<CJPKMGAOLOE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000821")]
	private readonly CJFDBJNKPDA OIJJCFKPCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000822")]
	public readonly FileInfo OMHHDGJHMNP;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public AODLEIDFJEK KMOKJKIFHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x845EEF0", Offset = "0x845D8F0", VA = "0x18845EEF0", Slot = "9")]
		get
		{
			return default(AODLEIDFJEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public DateTime DDGCBOKKGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x8BECE20", Offset = "0x8BEB820", VA = "0x188BECE20", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x8BED030", Offset = "0x8BEBA30", VA = "0x188BED030")]
	public CJPKMGAOLOE(CJFDBJNKPDA LFEELNPEGHE, FileInfo MBPLCKMKEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x8BECF80", Offset = "0x8BEB980", VA = "0x188BECF80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x8BECB40", Offset = "0x8BEB540", VA = "0x188BECB40", Slot = "5")]
	public void AKELAMNNKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x8BECF40", Offset = "0x8BEB940", VA = "0x188BECF40", Slot = "6")]
	public bool MOIKEFFGADM(long DKMPIOFKFMN, long JOIKPPGBGCF, [Out] HNFMIDJGFGN CDKAFKOFPNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x8BECC00", Offset = "0x8BEB600", VA = "0x188BECC00", Slot = "7")]
	public bool Equals(JBJNNHCHIGL EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x8BECC70", Offset = "0x8BEB670", VA = "0x188BECC70", Slot = "8")]
	public bool Equals(CJPKMGAOLOE EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x8BECD30", Offset = "0x8BEB730", VA = "0x188BECD30", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x8BECEB0", Offset = "0x8BEB8B0", VA = "0x188BECEB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
public delegate void FBLKCELCLGF(INENGAMLDBB.OAIOGADIKOP HHBOGECBAHM, string ONGDPODJNBL);
[Cpp2IlInjected.Token(Token = "0x20001D4")]
internal interface MNJDMOKLHFI
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	AODLEIDFJEK KMOKJKIFHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MCCOIGAMHBG(long DKMPIOFKFMN, long JOIKPPGBGCF, AHLLAMLIAPD MJAEFDLBIKK, [Out] JBJNNHCHIGL CMMNIMNPMPI);

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<JBJNNHCHIGL> HHNMDGGLDNH(AHLLAMLIAPD MJAEFDLBIKK);

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JBJNNHCHIGL BMOCPOIFIHL(long DKMPIOFKFMN, long JOIKPPGBGCF, HNFMIDJGFGN CDKAFKOFPNO, AHLLAMLIAPD MJAEFDLBIKK);
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
