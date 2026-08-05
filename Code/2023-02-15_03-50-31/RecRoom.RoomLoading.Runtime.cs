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
using Mono.Math;
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
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3A810A0", Offset = "0x3A804A0", VA = "0x183A810A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72ABD0", Offset = "0x729FD0", VA = "0x18072ABD0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xC60960", Offset = "0xC5FD60", VA = "0x180C60960")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PIDEOELMNID : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3A89200", Offset = "0x3A88600", VA = "0x183A89200")]
	public PIDEOELMNID(string DENPJAMCNLD, Exception LOPPGFLFDNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class DCPPKBFLPII : NEBEEBGPMHJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct EDAOLFIEEKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<DMKADNPMMCB>> <>t__builder;

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
		private TaskAwaiter<global::KOCPOIDKMLD<DMKADNPMMCB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3A72B30", Offset = "0x3A71F30", VA = "0x183A72B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3A72D10", Offset = "0x3A72110", VA = "0x183A72D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct IBPMLENKCED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<MLDKMPGPNNH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<MLDKMPGPNNH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3A774B0", Offset = "0x3A768B0", VA = "0x183A774B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3A77670", Offset = "0x3A76A70", VA = "0x183A77670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	[UnityEngine.Scripting.Preserve]
	public DCPPKBFLPII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x311D090", Offset = "0x311C490", VA = "0x18311D090", Slot = "4")]
	[AsyncStateMachine(typeof(EDAOLFIEEKL))]
	public Task<IReadOnlyList<DMKADNPMMCB>> GMLALHPJMGA(long LLDIIOOAFHI, long ADPAGPHKENF, [Optional] CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x311D1E0", Offset = "0x311C5E0", VA = "0x18311D1E0", Slot = "5")]
	[AsyncStateMachine(typeof(IBPMLENKCED))]
	public Task<IReadOnlyList<MLDKMPGPNNH>> LEONNOBNPDJ(IReadOnlyList<int> GBFLFKNPLJM, [Optional] CancellationToken OLHHOODBFDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PNLOHIHDNOE : IEquatable<PNLOHIHDNOE>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int NPOHJEKKGOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	MLDKMPGPNNH DGCEHGGDCGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime CNLNPMMMPAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	DEJBOJOPLBD? MAACBINLJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IEMFJMNBNCH? MGICLEFCHJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	KGHGPIODGPF HACCKALIFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<BCGEGHGDJPI> ONNPFNLEIKN();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum KGHGPIODGPF
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NEBEEBGPMHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<DMKADNPMMCB>> GMLALHPJMGA(long LLDIIOOAFHI, long ADPAGPHKENF, [Optional] CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<MLDKMPGPNNH>> LEONNOBNPDJ(IReadOnlyList<int> GBFLFKNPLJM, [Optional] CancellationToken OLHHOODBFDC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class OIDLNIKKEPP
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class HJLIANLKFJL : PNLOHIHDNOE, IEquatable<PNLOHIHDNOE>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct PNLGCBOKPLO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<BCGEGHGDJPI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public HJLIANLKFJL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private LLIEKCMACKC <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<NJHHCJFILAP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<BCGEGHGDJPI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x45D9A10", Offset = "0x45D8E10", VA = "0x1845D9A10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x45D9EA0", Offset = "0x45D92A0", VA = "0x1845D9EA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly DMKADNPMMCB LFJCKAMKCMO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int NPOHJEKKGOA
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x703080", Offset = "0x702480", VA = "0x180703080", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MLDKMPGPNNH DGCEHGGDCGC
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime IFJGEHILPJC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x1C54F10", Offset = "0x1C54310", VA = "0x181C54F10", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public DEJBOJOPLBD? MAACBINLJLL
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xDCB760", Offset = "0xDCAB60", VA = "0x180DCB760", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IEMFJMNBNCH? MGICLEFCHJO
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xDCB720", Offset = "0xDCAB20", VA = "0x180DCB720", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KGHGPIODGPF HACCKALIFGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7DF3D0", Offset = "0x7DE7D0", VA = "0x1807DF3D0", Slot = "10")]
			get
			{
				return default(KGHGPIODGPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x45D3BE0", Offset = "0x45D2FE0", VA = "0x1845D3BE0", Slot = "9")]
		[AsyncStateMachine(typeof(PNLGCBOKPLO))]
		public Task<BCGEGHGDJPI> ONNPFNLEIKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x45D3D10", Offset = "0x45D3110", VA = "0x1845D3D10")]
		public HJLIANLKFJL(int GAPFICIADNP, MLDKMPGPNNH MIKPECMELBJ, DMKADNPMMCB LFJCKAMKCMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x45D39E0", Offset = "0x45D2DE0", VA = "0x1845D39E0", Slot = "11")]
		public bool Equals(PNLOHIHDNOE IHIJPIJNLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x45D3A70", Offset = "0x45D2E70", VA = "0x1845D3A70", Slot = "0")]
		public override bool Equals(object ADHHHFDPAPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x45D3BA0", Offset = "0x45D2FA0", VA = "0x1845D3BA0")]
		private bool OAINLFHJGDK(HJLIANLKFJL IHIJPIJNLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x45D3B10", Offset = "0x45D2F10", VA = "0x1845D3B10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class MEHIIMDECDI : PNLOHIHDNOE, IEquatable<PNLOHIHDNOE>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct NNGHCJEPACN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<BCGEGHGDJPI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public MEHIIMDECDI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<BCGEGHGDJPI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x45D6790", Offset = "0x45D5B90", VA = "0x1845D6790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x45D6970", Offset = "0x45D5D70", VA = "0x1845D6970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly HJHFIAECAFN ANFEBHNJAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly DEJBOJOPLBD BEOAOJDCEAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly IEMFJMNBNCH GPDFKFNKAOK;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int NPOHJEKKGOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x45D5BE0", Offset = "0x45D4FE0", VA = "0x1845D5BE0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MLDKMPGPNNH DGCEHGGDCGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x45D5EB0", Offset = "0x45D52B0", VA = "0x1845D5EB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime IFJGEHILPJC
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x45D5E60", Offset = "0x45D5260", VA = "0x1845D5E60", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DEJBOJOPLBD? MAACBINLJLL
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x45D5D80", Offset = "0x45D5180", VA = "0x1845D5D80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IEMFJMNBNCH? MGICLEFCHJO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x45D5B90", Offset = "0x45D4F90", VA = "0x1845D5B90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public KGHGPIODGPF HACCKALIFGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D30A0", VA = "0x1807D3CA0", Slot = "10")]
			get
			{
				return default(KGHGPIODGPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA42EA0", Offset = "0xA422A0", VA = "0x180A42EA0")]
		public MEHIIMDECDI(HJHFIAECAFN GNJIELOFDMK, DEJBOJOPLBD FHJAGFCOPIP, IEMFJMNBNCH MHNKLLFJNLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x45D5FB0", Offset = "0x45D53B0", VA = "0x1845D5FB0", Slot = "9")]
		[AsyncStateMachine(typeof(NNGHCJEPACN))]
		public Task<BCGEGHGDJPI> ONNPFNLEIKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x45D5C30", Offset = "0x45D5030", VA = "0x1845D5C30", Slot = "11")]
		public bool Equals(PNLOHIHDNOE IHIJPIJNLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x45D5CD0", Offset = "0x45D50D0", VA = "0x1845D5CD0", Slot = "0")]
		public override bool Equals(object ADHHHFDPAPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x45D5F50", Offset = "0x45D5350", VA = "0x1845D5F50")]
		private bool OAINLFHJGDK(MEHIIMDECDI IHIJPIJNLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x45D5DD0", Offset = "0x45D51D0", VA = "0x1845D5DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class JNNCODECHCP : PNLOHIHDNOE, IEquatable<PNLOHIHDNOE>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct GCKLEMHGFPN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<BCGEGHGDJPI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<BCGEGHGDJPI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x45D2080", Offset = "0x45D1480", VA = "0x1845D2080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x45D2260", Offset = "0x45D1660", VA = "0x1845D2260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly MLDKMPGPNNH ANEKPEEGIOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly DEJBOJOPLBD BEOAOJDCEAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly IEMFJMNBNCH GPDFKFNKAOK;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int NPOHJEKKGOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x45D52D0", Offset = "0x45D46D0", VA = "0x1845D52D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public MLDKMPGPNNH DGCEHGGDCGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime IFJGEHILPJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F8CD0", VA = "0x1806F98D0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public DEJBOJOPLBD? MAACBINLJLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x45D55E0", Offset = "0x45D49E0", VA = "0x1845D55E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IEMFJMNBNCH? MGICLEFCHJO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x45D5280", Offset = "0x45D4680", VA = "0x1845D5280", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public KGHGPIODGPF HACCKALIFGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F8CD0", VA = "0x1806F98D0", Slot = "10")]
			get
			{
				return default(KGHGPIODGPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA42EA0", Offset = "0xA422A0", VA = "0x180A42EA0")]
		public JNNCODECHCP(MLDKMPGPNNH MIKPECMELBJ, DEJBOJOPLBD FHJAGFCOPIP, IEMFJMNBNCH MHNKLLFJNLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x45D57E0", Offset = "0x45D4BE0", VA = "0x1845D57E0", Slot = "9")]
		[AsyncStateMachine(typeof(GCKLEMHGFPN))]
		public Task<BCGEGHGDJPI> ONNPFNLEIKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x45D5350", Offset = "0x45D4750", VA = "0x1845D5350", Slot = "11")]
		public bool Equals(PNLOHIHDNOE IHIJPIJNLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x45D5490", Offset = "0x45D4890", VA = "0x1845D5490", Slot = "0")]
		public override bool Equals(object ADHHHFDPAPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x45D5630", Offset = "0x45D4A30", VA = "0x1845D5630", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x45D56E0", Offset = "0x45D4AE0", VA = "0x1845D56E0")]
		private bool OAINLFHJGDK(JNNCODECHCP IHIJPIJNLJM)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct HANPDJAEODN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<PNLOHIHDNOE>> <>t__builder;

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
		public OIDLNIKKEPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<DMKADNPMMCB> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<DMKADNPMMCB>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, MLDKMPGPNNH account, DMKADNPMMCB roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x45D2A90", Offset = "0x45D1E90", VA = "0x1845D2A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x45D3520", Offset = "0x45D2920", VA = "0x1845D3520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct FLENALBOPNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, MLDKMPGPNNH account, DMKADNPMMCB roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<DMKADNPMMCB> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public OIDLNIKKEPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<MLDKMPGPNNH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x45D1130", Offset = "0x45D0530", VA = "0x1845D1130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x45D1AB0", Offset = "0x45D0EB0", VA = "0x1845D1AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KIHFBDODNJO LEEAHAIOPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly NEBEEBGPMHJ NEBFMOGCAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly JMGMCBCMGOO OIOHLEHKDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly global::IJOEEHHBALN<(long, long), IReadOnlyList<DMKADNPMMCB>> FJIEDDEPOLO;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A82110", Offset = "0x3A81510", VA = "0x183A82110")]
	[UnityEngine.Scripting.Preserve]
	public OIDLNIKKEPP([CNHALHMHHIC(null)] NEBEEBGPMHJ EOPDPJDCMAC, [CNHALHMHHIC(null)] JMGMCBCMGOO CKEPHGJFMOM, [CNHALHMHHIC(null)] KIHFBDODNJO LEJBAGCEPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A81FC0", Offset = "0x3A813C0", VA = "0x183A81FC0")]
	[AsyncStateMachine(typeof(HANPDJAEODN))]
	public Task<IList<PNLOHIHDNOE>> PMMLMKEFPFG(long LLDIIOOAFHI, long KFGNOJDEOOA, bool GJODAEEGGML = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3A81E10", Offset = "0x3A81210", VA = "0x183A81E10")]
	private bool MOJPOLKHKGF(DateTime? HNBCCIIMILF, long LLDIIOOAFHI, long KFGNOJDEOOA, out HJHFIAECAFN EKDFAKLJBGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3A81CD0", Offset = "0x3A810D0", VA = "0x183A81CD0")]
	[AsyncStateMachine(typeof(FLENALBOPNP))]
	private Task<IReadOnlyList<(int, MLDKMPGPNNH, DMKADNPMMCB)>> AFFEEONLGCE(IReadOnlyList<DMKADNPMMCB> HIOJLLPHGDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JMGMCBCMGOO
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<HJHFIAECAFN> ECMAEACLGHL;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DKPCFFKNCOM(long LLDIIOOAFHI, long KFGNOJDEOOA, PNGJOFGNDJG LLGBGHFCOLE, ALDHOJLECOH KJHAOKNAKMN);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ALBHPMCNOOH(long LLDIIOOAFHI, long KFGNOJDEOOA, out HJHFIAECAFN EKDFAKLJBGF);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IJBDFMJGIJC(long LLDIIOOAFHI, long KFGNOJDEOOA, ALDHOJLECOH KJHAOKNAKMN, out HJHFIAECAFN EKDFAKLJBGF);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JPCJDMCCHPO(long LLDIIOOAFHI, long KFGNOJDEOOA);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface HOKGHPAIJPE : PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BNBMIMCILDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task PBFEMOHINML
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ELKFLPDMFCE(Task DLDNMMGIFIK, string JLDFDOILLBB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface ECICOCBCFBI : PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BCGEGHGDJPI> NBHKKLIIEHJ(HJHFIAECAFN EKDFAKLJBGF);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ALFDOPDICJO(CancellationToken OLHHOODBFDC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface LMBFFAEKNKL : PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	EMJFBIFAMEN BENGGBGOJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFNGPHCLMNH();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ABEMGBENLOF();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface PCBEFAPPLHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNACPANAOEJ(JMNCFHIJLAL IMJGFHGLEPI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface FMBGGBENKME
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan PGPENOKLNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan IJNMMMMEPAM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan GIIBLCEIOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan BGCDLKHGAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool APIGLJCNKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool JDAFDDDJMBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool PLIICIAGNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum IMCDPDNDLMM
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum FDJMDHAGLAP
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
public struct NBNKBIKAIGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long CDDPJFBHIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long ADPAGPHKENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly IMCDPDNDLMM DDJDPMGLPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception BGKIICPPPFK;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3A7F580", Offset = "0x3A7E980", VA = "0x183A7F580")]
	public NBNKBIKAIGB(long CDDPJFBHIMC, long ADPAGPHKENF, IMCDPDNDLMM DDJDPMGLPAE, [CanBeNull] Exception BGKIICPPPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3A7F530", Offset = "0x3A7E930", VA = "0x183A7F530")]
	public static NBNKBIKAIGB FFPKNNKHNKN(IDJHFGEEFAO ADBPFEHIBFM, IMCDPDNDLMM DDJDPMGLPAE, [Optional] Exception BGKIICPPPFK)
	{
		return default(NBNKBIKAIGB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate void MMGGIDKNBHL(NBNKBIKAIGB MLBPLLDNPGN);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface BOHCGLIDEGH : PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action IHOPJKJHOFL;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event MMGGIDKNBHL NFLKMPMKOFB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MMGGIDKNBHL JEOKJPHGMKE;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event MMGGIDKNBHL HJDGBEEMKIL;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<FDJMDHAGLAP, bool> BNNCAJJKHBA;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NKDELDGHDOH();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FBDNENELBEC(NBNKBIKAIGB MLBPLLDNPGN);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FFICBGDLDFF(NBNKBIKAIGB MLBPLLDNPGN);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DAKJNJIGGOI(NBNKBIKAIGB MLBPLLDNPGN);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DAINKJMBOKO(FDJMDHAGLAP HGNGEDBMHCK, bool PKOGEGLMCLO);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface MJBGHMCABDH : PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PANECCPLNBC();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BLEIJLMEPOC();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OBGDMCGDCAI();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate Task ECKFDOGEEPA(HBMEPODFBHF GDKBHGNBDKI, CancellationToken AJDBKDIMOHA);
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface IOHIBNHMCEK : PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool IIGPGGNOILH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NKGFEGECMBF(ECKFDOGEEPA GGJAGGNMEDH);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface IOCLFLHAOLK : PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TaskStatus NGNILFAPKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GALAIALKFKC(IDJHFGEEFAO NPLPKFFKPLE, AMEFKLDHCDD KCIIEMDKNMC, CancellationToken FFBLKMEPPBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class DLIBCBGGBBM
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x311EA70", Offset = "0x311DE70", VA = "0x18311EA70")]
	public static bool PIGEBDPAMHB(this IOCLFLHAOLK PLPEFHCJLFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface JMNCFHIJLAL : LLIEKCMACKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CancellationToken ICAJPMKNFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	LECENBDGBAK LJOKEFMODBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	OCLKGMDKHAF NJAPPDMCIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	LKHDDEOALEA JHBOJKNLAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	HKLHFCGBNEN DDGABFFCPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	OGJIKCIMBEL BLHNIKJGMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	CCCHDJOODDG OLEOBAHGMIK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	HKINNJHLDGA BDLBLIMICNB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	AMMHDIJOABG EEEHELBBFPC
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HOKGHPAIJPE GDHCLABABDO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	ECICOCBCFBI PNKKAMKJODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	BOHCGLIDEGH HGPBPBGNLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	MJBGHMCABDH EIEIPCABIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	IOCLFLHAOLK GPBHDDKAIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	IOHIBNHMCEK PNDLFMJDAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	COONKIKCBOP BJMKGOPGEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	JELOMCLHFJH BEDLAMJIICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	JHOIAGANLCL IEPPHPGONOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	MCMKCPIGMEJ ELAFJPDEEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	IPFNOIGAFBL MCEJKCJPBIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	EBAJLFIGJKG NCIFGKBNEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ELCJHBCIGIA AFGAGPIADCH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	DNDCBPDDGOE PFOOHONEEEP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	PPJPEAOCAOG HAMLGOALDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	MCKGJFCMHHK BHCBAJHMFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	AEBHPDBGDEM INBBJJGOFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	LMBFFAEKNKL BAOMMLCKKED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	FMBGGBENKME AOELLJOFDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	MPIOEIHCLEA IIHIBMKPMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	JMGMCBCMGOO CBJBECMKHML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void HOFHHBHIEJB(AMEFKLDHCDD OMFBMPBGLLB);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface COONKIKCBOP : PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HJHOLDMOADO AOHLLDNPMGN(Guid OMEAOMOIGDD);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BCBAFCFKBLF(Guid OMEAOMOIGDD);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GCFIJOMHNGB(Guid OMEAOMOIGDD, Task IHCDPPNLEGI);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HIPPOGMIDML(Guid OMEAOMOIGDD, BCGEGHGDJPI OCICNIKOLOP);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OBGDMCGDCAI(Guid OMEAOMOIGDD);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(BCGEGHGDJPI, Task)> AEIJLFCLAAN(Guid OMEAOMOIGDD);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface JELOMCLHFJH : PCBEFAPPLHA, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface JHOIAGANLCL : PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JBEGGIBCIAC(PLBGOAPJHAI DENPJAMCNLD);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JELPJMMFNKD(PLBGOAPJHAI DENPJAMCNLD);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<LBJBELAPCEL> MMDKHNOFIFL(CancellationToken POBPHDLEHCN);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public delegate BCGEGHGDJPI FCDNLKBCPPO(KPNOOPGJEKD FCAPIJNHCMP, LBJBELAPCEL ENHFFKPEKCH);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface MCMKCPIGMEJ : PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HJHOLDMOADO LLEEFHEMKHG(PLBGOAPJHAI KHECEKIAEMI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DIDNPJJGAHC(Guid OMEAOMOIGDD, Task IHCDPPNLEGI);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface IPFNOIGAFBL : PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BCGEGHGDJPI> MCEJKCJPBIP(PLBGOAPJHAI MOKAOCBBHED);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface EBAJLFIGJKG : PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GKIAAKPIFKA> EPGHFDIAJGD(IBIDBCAPHMG KIBJDNPFMAF, IDJHFGEEFAO NPLPKFFKPLE, CancellationToken OLHHOODBFDC);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface DNDCBPDDGOE : PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BCGEGHGDJPI KLEEOIGKBMJ(KPNOOPGJEKD FCAPIJNHCMP);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MIHFEJNMPGD(string BENGLHDIHMD);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface ELCJHBCIGIA : PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PLBGOAPJHAI> GDKKCLBPMDG(PLBGOAPJHAI EFADACBHMKC, FHFCMNCJGAI BMPAMAENPDM, CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<PLBGOAPJHAI> EDPHKIIMHFC(CancellationToken OLHHOODBFDC, FHFCMNCJGAI BMPAMAENPDM);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MFMLJGKBCFN KOIAOINOLKF(NJHNOKIINKM MHMFKNEPJPG, IBIDBCAPHMG KIBJDNPFMAF);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MFMLJGKBCFN PIPEJONHFGC(NJHNOKIINKM MHMFKNEPJPG, IBIDBCAPHMG KIBJDNPFMAF);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface PPJPEAOCAOG : PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BCGEGHGDJPI KKOCHPDKDIO(KPNOOPGJEKD FCAPIJNHCMP, LBJBELAPCEL ENHFFKPEKCH);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BCGEGHGDJPI KKMFOJFMEJI(KPNOOPGJEKD NBOLIIBAEOO);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BCGEGHGDJPI GPKOFLMIBDL(KPNOOPGJEKD NBOLIIBAEOO);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface MCKGJFCMHHK
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FICALAAPNNG(JIFPIMFGIMH IKNLKCICDJN);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKDLJOKLNNE(JIFPIMFGIMH IKNLKCICDJN);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OIPNHHDMABO(JIFPIMFGIMH IKNLKCICDJN);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EOINMBNADLC(JIFPIMFGIMH IKNLKCICDJN);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class JIFPIMFGIMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly IDJHFGEEFAO KIECEPKGDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> PBHAPGPDOCG;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public global::NEKDBCPDAGF<string> OBPHKIACCEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7062B0", Offset = "0x7056B0", VA = "0x1807062B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7803F0", Offset = "0x77F7F0", VA = "0x1807803F0")]
	public JIFPIMFGIMH(IDJHFGEEFAO GBJGFACLOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x312C980", Offset = "0x312BD80", VA = "0x18312C980")]
	public JIFPIMFGIMH NHEFFAODJPE(string EBOEHIFNNLM, string JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x312CA50", Offset = "0x312BE50", VA = "0x18312CA50")]
	public bool PPCFKFDDBJA(out IEnumerable<KeyValuePair<string, string>> LBBDMAMLFNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0xC522D0", Offset = "0xC516D0", VA = "0x180C522D0")]
	public JIFPIMFGIMH LPGDGCAAOCM(global::NEKDBCPDAGF<string> HHEDADBLDNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MPIOEIHCLEA
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool MIIOGCKCOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string KKMKOIAMDOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PENLPKEPBAC();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GCLGHOFJCBB EHOGIFLFHLO(long CFDJBIILEAP);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::BHGMNFKGCMD<AKFPGEDHNIP, LNAKJJBHDNH> LHNOJIGINKE(long CFDJBIILEAP);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::BHGMNFKGCMD<AKFPGEDHNIP, ALJFOENJMIN> ILALPNHNAKL(long CFDJBIILEAP);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::BHGMNFKGCMD<long, LALKLMFOCHP> JIBBCHBCBII();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> DIDAHENJJLF(byte[] NMJILFMGNAI, byte[] LAODEMMELPI, CancellationToken OLHHOODBFDC);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface LLIEKCMACKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool PIGEBDPAMHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HIKDAGNHGPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	Task PGCINANFFIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	AMEFKLDHCDD KOEEBOCPDDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action IHOPJKJHOFL;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event MMGGIDKNBHL NFLKMPMKOFB;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event MMGGIDKNBHL JEOKJPHGMKE;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MMGGIDKNBHL HJDGBEEMKIL;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<FDJMDHAGLAP, bool> BNNCAJJKHBA;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BLEIJLMEPOC();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	LOJLPLPIAGN FCLMGICNADM();

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ALBEPCFBDLD JCPPDMJADGC();

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<BCGEGHGDJPI> NBHKKLIIEHJ(HJHFIAECAFN GNJIELOFDMK);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task ALFDOPDICJO(CancellationToken OLHHOODBFDC);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface OGJIKCIMBEL
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool KFIEKGFFHDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string KIPOBGBEJEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMIKLLJDGAH(Scene GPMLNFDMBJA);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HKLAKPPCIHN(AOKGGOOOAAG EJELBGLGCHL, CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task ELOHOPLPFFN();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface HKLHFCGBNEN
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	IDGMGLIGADE KHOLDMMJLMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int CNGEIFCHLAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool KAFFLJLCIAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool DMGIPOFJAFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool CGAGHIHFIAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool IEKPJFPCOAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool NAIAPBGEDCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	KPNOOPGJEKD JIHMNJJIKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool FLGJDOIIBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LECENBDGBAK BCBDIBCOKBJ(LECENBDGBAK EEMEKCBAKEI);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BBCJBDHFLMB(LECENBDGBAK LNELKNMCOEH);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task MLOGPCFKLJK(IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task ICIAPAJNAPK(CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task JPCJBDPLHHF(OJGFDBKPPLK EBBINHBEDJD, [Optional] CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NFIBNBOHAMG(float CJKLDKLIPFL);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OIJOLJBNKGM(string LJFJPGNDKGJ);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<BOEEIMMOILK> OOFOECKGBEH();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDisposable EHCLCMNNHHM(object MAFDHEKFLMG, BOEEIMMOILK IHDBFFAAICJ);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LNAKJJBHDNH FPKOABKBMLN();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LCOKIPDKNLD(int DHPNPBCHFNK);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task JAHMFBIMLKG();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FAAMJPHAOBB();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool MPMLCNIFDNO();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task DOKMCAJFDCJ(CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task JNAHBLKBLHD(CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<FMBDPDBMBFM> LBAFCHOMFIM(DateTime DHGMLEPOCIB, CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> HIPGBNFODHI(CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NIEPENIDLHF();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "25")]
	MIFBNDKINNO HJDOFONNFDG(CALEGKJDHNB FLJHFLFCMAB, ALJFOENJMIN ALCHMIAHOOM, IEnumerable<PersistenceView> FKHOPLFFPFG, ref OFOCKNJFHCC OMNCAEMBDJJ);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MFDJLLOAIBI(ALJFOENJMIN ALCHMIAHOOM);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DKEJLPDGEDE(POHCLHIPEBO JNGKMBCEAGB, in MIFBNDKINNO MNKFJJIHAAE);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task CGLNKENJJAE(ALJFOENJMIN CIHGBDJBHIA, bool DNOHJCNENEN, CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task JHPLNBMNDPH(CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void LDDJGOCDPPF(long LLDIIOOAFHI, long ADPAGPHKENF, NJHHCJFILAP KBKLNNOLLHH, PNGJOFGNDJG LLGBGHFCOLE);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void OKHGNMAADBB(long LLDIIOOAFHI, long ADPAGPHKENF);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void APPFHKDCNKD(PersistenceView FNBGOKIDJFJ);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool JHKPKIDJKMA(PersistenceView CHOBEAJIPKF);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool GFACAGHPJNG(POHCLHIPEBO JNGKMBCEAGB, CJHBLOEDPCM BNAKNHIHHFP, out LMHNNMECCEL MIDIKAFJEMI);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void KNDIIMFGIPJ();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void NLFNEHOLNHF();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable KAKBHPECKGP();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void MNJEPBGGMLA(ALJFOENJMIN CIHGBDJBHIA, CJHBLOEDPCM BNAKNHIHHFP);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> IBNFLPMJDLD(OCLKGMDKHAF LHLIGPNBLOF, CancellationToken OLHHOODBFDC, IBIDBCAPHMG KIBJDNPFMAF);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void JEDGNJANBBF(CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<OCDLNECLLKD> FCNCPAEHDLA(OPNKDAPNCBG EFADACBHMKC);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<AOJPNBHMMII> JGEKAICGCPF(string MILFEKOPFBC, long LLDIIOOAFHI, long ADPAGPHKENF, string IDBLHDFAAFE, ENBONPHDNAF.KEKNDACMKEB GDKBHGNBDKI, ENBONPHDNAF.KEKNDACMKEB LAODEMMELPI, int DJCINABOACI);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<NJHHCJFILAP> NIIBLDDFMCF(long LLDIIOOAFHI, bool ILFFIHOOFPB, CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool AHEFFFMKLMN();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool MGKANMEKLMN();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool PKGNLNNHFBN(IEnumerable<LMHNNMECCEL> NLIMAGOHPEC);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void CHEBJCEEMGA(List<GameObject> LMHHBCBDNLB);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "50")]
	float HHNJJGNMLHP();

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool BLGKCJFPDOA(string NOGFKIMFHJP, out Scene BGCBBDJLHHN);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "52")]
	Task<Scene> CPODMHBNPCN(string NOGFKIMFHJP, LoadSceneMode NNBEHPIBIJP, bool OPLGAMIEKAA, IBIDBCAPHMG HHEDADBLDNA);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void LAOLFMKMPLP();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "54")]
	bool MOAKHOIEALA(ByteString EJAHCFFDNJB);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void DANCLEJHAGI(IDJHFGEEFAO AKLGGPCNKNN);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task OKNJBGDNDPH(IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "58")]
	Task MJDGBGPPDHC(IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void CMAIKKEIAAM();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "60")]
	IDisposable GGOCKFHIFPD();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "61")]
	FCIKFFNPKLM IIKAEPOHKOG();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface FCIKFFNPKLM
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AJCCBIBEMNC(CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PHNBNBNDIGC(CancellationToken OLHHOODBFDC);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct MIFBNDKINNO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> FLDDHFBMEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IDisposable PMJDGDJGBCH;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3133870", Offset = "0x3132C70", VA = "0x183133870", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum FMBDPDBMBFM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface IDGMGLIGADE
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	IDJHFGEEFAO ELFNMKOIMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	NJHHCJFILAP LLMOOHLDJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	COOBAAMIODE CNHDNIAJHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool GNJAICOCDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool NDIKIMEAAOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	int CNGEIFCHLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action LDCDDIKNALD;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<int> BFPGJKOJKHA;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MAJNNDHEOAF();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.NKGDLLLCEFI> IADBHFHGHNF();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task LMBBGDMCDBJ();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "13")]
	(IDJHFGEEFAO, AMEFKLDHCDD) GIOAAFDMHCM();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GNFMLPKABNA ODPCFONPBHJ();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CPEMPLCBELP(long CFDJBIILEAP);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface AEBHPDBGDEM
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GIOCCNIPCMD(out IEnumerable<int> JDBFCCDMGKD);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKMKANIKAJE(GLKHMHJFJLG AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCJDBDOMJIK(GLKHMHJFJLG AJDBKDIMOHA);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface CEDIKIHLIDK
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KGCEHFFBNAN(BCGEGHGDJPI GLKJMCNNMBI);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface OKNOKGNGLLP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGKKBABDGII(PGKHMIDIOIF.NANNHKNAHHB LEKIHHOGFEJ);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JMIMGECCIPP(PGKHMIDIOIF.NANNHKNAHHB LEKIHHOGFEJ);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface CCCHDJOODDG : OKNOKGNGLLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BCGEGHGDJPI AEGJFHAEKNK(KPNOOPGJEKD NBOLIIBAEOO);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface HKINNJHLDGA : OKNOKGNGLLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BCGEGHGDJPI KLEEOIGKBMJ(KPNOOPGJEKD OCNINCAELAD);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface GCLGHOFJCBB
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::OHFECDBHLHC<AOKGGOOOAAG, IOILPEPIEGB>> HKAAJJEOLFG(string IDBLHDFAAFE, long CFDJBIILEAP, MCKNPKJAOMF.GLBPDGMBKIC DLMGJJEDGFE, CancellationToken OLHHOODBFDC);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface BHGMNFKGCMD<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::OHFECDBHLHC<byte[], IOILPEPIEGB>> EAOILJPGFPN(TGetDataArg CDKILDODEEL, CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::OHFECDBHLHC<global::KKPNMOBPAON<TData>, IOILPEPIEGB> IFHIOLBDHOF(byte[] ONIBEFDCPGD);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class HABFBODLIAB : JMNCFHIJLAL, LLIEKCMACKC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct GHBFBBKLIBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<BCGEGHGDJPI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public HABFBODLIAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public HJHFIAECAFN autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<BCGEGHGDJPI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x40227A0", Offset = "0x4021BA0", VA = "0x1840227A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4022A40", Offset = "0x4021E40", VA = "0x184022A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct PHOJMLCOELD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public HABFBODLIAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x402C8D0", Offset = "0x402BCD0", VA = "0x18402C8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class CBBFKFGPMKD : IEnumerable<PCBEFAPPLHA>, IEnumerable, IEnumerator<PCBEFAPPLHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private PCBEFAPPLHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public HABFBODLIAB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private PCBEFAPPLHA System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x75EDA0", Offset = "0x75E1A0", VA = "0x18075EDA0")]
		[DebuggerHidden]
		public CBBFKFGPMKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x401B940", Offset = "0x401AD40", VA = "0x18401B940", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x401BD80", Offset = "0x401B180", VA = "0x18401BD80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x401BCE0", Offset = "0x401B0E0", VA = "0x18401BCE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PCBEFAPPLHA> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x401BCE0", Offset = "0x401B0E0", VA = "0x18401BCE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource ECKJKPFKLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly LECENBDGBAK LNELKNMCOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private CPCILOGODIA DHICJCLHPCI;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public OCLKGMDKHAF NJAPPDMCIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6E79C0", Offset = "0x6E6DC0", VA = "0x1806E79C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6E8F10", Offset = "0x6E8310", VA = "0x1806E8F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public LKHDDEOALEA JHBOJKNLAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB40", Offset = "0x7CAF40", VA = "0x1807CBB40", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8A7C70", Offset = "0x8A7070", VA = "0x1808A7C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public HKLHFCGBNEN DDGABFFCPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x77F5A0", Offset = "0x77E9A0", VA = "0x18077F5A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x83DD10", Offset = "0x83D110", VA = "0x18083DD10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public OGJIKCIMBEL BLHNIKJGMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x77D5F0", Offset = "0x77C9F0", VA = "0x18077D5F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x706290", Offset = "0x705690", VA = "0x180706290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public CCCHDJOODDG OLEOBAHGMIK
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x77D600", Offset = "0x77CA00", VA = "0x18077D600", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x83DD00", Offset = "0x83D100", VA = "0x18083DD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public HKINNJHLDGA BDLBLIMICNB
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6F0B50", Offset = "0x6EFF50", VA = "0x1806F0B50", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7E1190", Offset = "0x7E0590", VA = "0x1807E1190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public AMMHDIJOABG EEEHELBBFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x725C80", Offset = "0x725080", VA = "0x180725C80", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7F06E0", Offset = "0x7EFAE0", VA = "0x1807F06E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public HOKGHPAIJPE GDHCLABABDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7A4AB0", Offset = "0x7A3EB0", VA = "0x1807A4AB0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7F06C0", Offset = "0x7EFAC0", VA = "0x1807F06C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public ECICOCBCFBI PNKKAMKJODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x757C60", Offset = "0x757060", VA = "0x180757C60", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x807460", Offset = "0x806860", VA = "0x180807460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public BOHCGLIDEGH HGPBPBGNLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x786230", Offset = "0x785630", VA = "0x180786230", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x80E3F0", Offset = "0x80D7F0", VA = "0x18080E3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public MJBGHMCABDH EIEIPCABIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6F71B0", Offset = "0x6F65B0", VA = "0x1806F71B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7270", Offset = "0x6F6670", VA = "0x1806F7270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public IOCLFLHAOLK GPBHDDKAIGK
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x77D610", Offset = "0x77CA10", VA = "0x18077D610", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7F06D0", Offset = "0x7EFAD0", VA = "0x1807F06D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public IOHIBNHMCEK PNDLFMJDAGE
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6EC370", Offset = "0x6EB770", VA = "0x1806EC370", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5D0", Offset = "0x6EB9D0", VA = "0x1806EC5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public COONKIKCBOP BJMKGOPGEFI
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6EC430", Offset = "0x6EB830", VA = "0x1806EC430", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5E0", Offset = "0x6EB9E0", VA = "0x1806EC5E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public JELOMCLHFJH BEDLAMJIICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6EC2F0", Offset = "0x6EB6F0", VA = "0x1806EC2F0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5C0", Offset = "0x6EB9C0", VA = "0x1806EC5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public JHOIAGANLCL IEPPHPGONOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x702380", Offset = "0x701780", VA = "0x180702380", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7023D0", Offset = "0x7017D0", VA = "0x1807023D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public MCMKCPIGMEJ ELAFJPDEEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8E1270", Offset = "0x8E0670", VA = "0x1808E1270", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E00", Offset = "0x8E1200", VA = "0x1808E1E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public IPFNOIGAFBL MCEJKCJPBIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7044D0", Offset = "0x7038D0", VA = "0x1807044D0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7049A0", Offset = "0x703DA0", VA = "0x1807049A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public EBAJLFIGJKG NCIFGKBNEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x704720", Offset = "0x703B20", VA = "0x180704720", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x704B00", Offset = "0x703F00", VA = "0x180704B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public ELCJHBCIGIA AFGAGPIADCH
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x724000", Offset = "0x723400", VA = "0x180724000", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7259B0", Offset = "0x724DB0", VA = "0x1807259B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public DNDCBPDDGOE PFOOHONEEEP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7037E0", Offset = "0x702BE0", VA = "0x1807037E0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF580", Offset = "0x9DE980", VA = "0x1809DF580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public PPJPEAOCAOG HAMLGOALDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7044B0", Offset = "0x7038B0", VA = "0x1807044B0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7274F0", Offset = "0x7268F0", VA = "0x1807274F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public MCKGJFCMHHK BHCBAJHMFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7044C0", Offset = "0x7038C0", VA = "0x1807044C0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x704990", Offset = "0x703D90", VA = "0x180704990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public AEBHPDBGDEM INBBJJGOFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7274E0", Offset = "0x7268E0", VA = "0x1807274E0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x727500", Offset = "0x726900", VA = "0x180727500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public LMBFFAEKNKL BAOMMLCKKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x723610", Offset = "0x722A10", VA = "0x180723610", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x704AE0", Offset = "0x703EE0", VA = "0x180704AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public FMBGGBENKME AOELLJOFDFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x72B1D0", Offset = "0x72A5D0", VA = "0x18072B1D0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x72B1F0", Offset = "0x72A5F0", VA = "0x18072B1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public MPIOEIHCLEA IIHIBMKPMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x72B1E0", Offset = "0x72A5E0", VA = "0x18072B1E0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x72B200", Offset = "0x72A600", VA = "0x18072B200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public JMGMCBCMGOO CBJBECMKHML
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7300C0", Offset = "0x72F4C0", VA = "0x1807300C0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public AMEFKLDHCDD KOEEBOCPDDF
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9D4C60", Offset = "0x9D4060", VA = "0x1809D4C60", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF560", Offset = "0x9DE960", VA = "0x1809DF560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private bool HEBFMNAHMHH
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3126A20", Offset = "0x3125E20", VA = "0x183126A20", Slot = "45")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private bool JLPHCCHMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3127040", Offset = "0x3126440", VA = "0x183127040", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private Task CPFNLCHDCOL
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x31263D0", Offset = "0x31257D0", VA = "0x1831263D0", Slot = "47")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private CancellationToken AMPMDHKALNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3126B50", Offset = "0x3125F50", VA = "0x183126B50", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private LECENBDGBAK PDPHCEANENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event Action NMPNIHNEANC
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3126700", Offset = "0x3125B00", VA = "0x183126700", Slot = "35")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3126E30", Offset = "0x3126230", VA = "0x183126E30", Slot = "36")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event MMGGIDKNBHL DAPBICABLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3126FE0", Offset = "0x31263E0", VA = "0x183126FE0", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3126370", Offset = "0x3125770", VA = "0x183126370", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event MMGGIDKNBHL HIAMCHIIGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3127120", Offset = "0x3126520", VA = "0x183127120", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3126B70", Offset = "0x3125F70", VA = "0x183126B70", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event MMGGIDKNBHL JECGHBBLBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3126D80", Offset = "0x3126180", VA = "0x183126D80", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3126510", Offset = "0x3125910", VA = "0x183126510", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event Action<FDJMDHAGLAP, bool> NBGPNEFDEIN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x31270C0", Offset = "0x31264C0", VA = "0x1831270C0", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3126A80", Offset = "0x3125E80", VA = "0x183126A80", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x9DF560", Offset = "0x9DE960", VA = "0x1809DF560", Slot = "34")]
	public void HOFHHBHIEJB(AMEFKLDHCDD OMFBMPBGLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3127180", Offset = "0x3126580", VA = "0x183127180")]
	[UnityEngine.Scripting.Preserve]
	internal HABFBODLIAB([CNHALHMHHIC(null)] LECENBDGBAK LNELKNMCOEH, [CNHALHMHHIC(null)] OCLKGMDKHAF LHLIGPNBLOF, [CNHALHMHHIC(null)] LKHDDEOALEA PPABLONDLJA, [CNHALHMHHIC(null)] HKLHFCGBNEN FGFPMOHFMOM, [CNHALHMHHIC(null)] OGJIKCIMBEL IPPJCODHKLM, [CNHALHMHHIC(null)] CCCHDJOODDG CKLMGHGJPKO, [CNHALHMHHIC(null)] HKINNJHLDGA DIMCABPKIIN, [CNHALHMHHIC(null)] AMMHDIJOABG NDMFPGJENNL, [CNHALHMHHIC(null)] HOKGHPAIJPE DKMAEGIFCMM, [CNHALHMHHIC(null)] ECICOCBCFBI GHAFMCFJGNK, [CNHALHMHHIC(null)] BOHCGLIDEGH IPILJEFIHFH, [CNHALHMHHIC(null)] MJBGHMCABDH FIHFCIIOOBP, [CNHALHMHHIC(null)] IOCLFLHAOLK PLPEFHCJLFL, [CNHALHMHHIC(null)] IOHIBNHMCEK MDOMDJJMJCD, [CNHALHMHHIC(null)] COONKIKCBOP HGCLFAABBMF, [CNHALHMHHIC(null)] JELOMCLHFJH MBGOHFKLLNJ, [CNHALHMHHIC(null)] JHOIAGANLCL BHHILJFEOPK, [CNHALHMHHIC(null)] MCMKCPIGMEJ HOCJOFLIKOJ, [CNHALHMHHIC(null)] IPFNOIGAFBL HAMMKHLMDKF, [CNHALHMHHIC(null)] EBAJLFIGJKG KMECCPGKJOB, [CNHALHMHHIC(null)] DNDCBPDDGOE NBFPPKPCELD, [CNHALHMHHIC(null)] ELCJHBCIGIA KNBFKCAAJGP, [CNHALHMHHIC(null)] PPJPEAOCAOG EJKCHKLJKIP, [CNHALHMHHIC(null)] MCKGJFCMHHK PBLCKEGEMIE, [CNHALHMHHIC(null)] AEBHPDBGDEM EHNJKIFHOKM, [CNHALHMHHIC(null)] FMBGGBENKME HPHLIJIBJEH, [CNHALHMHHIC(null)] MPIOEIHCLEA ACMEJBCAAFM, [CNHALHMHHIC(null)] JMGMCBCMGOO FEKAPDONIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3126420", Offset = "0x3125820", VA = "0x183126420")]
	private void BNACPANAOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3126570", Offset = "0x3125970", VA = "0x183126570", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3126DE0", Offset = "0x31261E0", VA = "0x183126DE0", Slot = "48")]
	private void NEFDKHBPDFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3126E90", Offset = "0x3126290", VA = "0x183126E90", Slot = "49")]
	private LOJLPLPIAGN OHBNJLHGGAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3126BD0", Offset = "0x3125FD0", VA = "0x183126BD0", Slot = "50")]
	private ALBEPCFBDLD MPDGAPPFIGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3126760", Offset = "0x3125B60", VA = "0x183126760", Slot = "51")]
	[AsyncStateMachine(typeof(GHBFBBKLIBB))]
	private Task<BCGEGHGDJPI> FHEIEJGMPIB(HJHFIAECAFN EKDFAKLJBGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x31268A0", Offset = "0x3125CA0", VA = "0x1831268A0", Slot = "52")]
	[AsyncStateMachine(typeof(PHOJMLCOELD))]
	private Task GIDCDIFKOHM(CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3126AE0", Offset = "0x3125EE0", VA = "0x183126AE0")]
	[IteratorStateMachine(typeof(CBBFKFGPMKD))]
	private IEnumerable<PCBEFAPPLHA> KNHGMECNHIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x31269C0", Offset = "0x3125DC0", VA = "0x1831269C0")]
	[CompilerGenerated]
	private void HCADNOCGILA(PCBEFAPPLHA BGHFDNDJKMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal class PEDMPOOBCNI : FMPFBNPFBBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct CLLNAHLPCNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public PEDMPOOBCNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x45CEA10", Offset = "0x45CDE10", VA = "0x1845CEA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x45CEDA0", Offset = "0x45CE1A0", VA = "0x1845CEDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly JMNCFHIJLAL IMJGFHGLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly HKLHFCGBNEN FGFPMOHFMOM;

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x77FBB0", Offset = "0x77EFB0", VA = "0x18077FBB0")]
	public PEDMPOOBCNI(JMNCFHIJLAL IMJGFHGLEPI, HKLHFCGBNEN FGFPMOHFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3A86FC0", Offset = "0x3A863C0", VA = "0x183A86FC0", Slot = "4")]
	[AsyncStateMachine(typeof(CLLNAHLPCNF))]
	public Task<bool> IEJLPOMLNHI(CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3A870E0", Offset = "0x3A864E0", VA = "0x183A870E0")]
	[CompilerGenerated]
	private object NGJMFKBMHGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class KOFBKPMDMMN : FMPFBNPFBBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct KNCGIDEBDPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public KOFBKPMDMMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4027F00", Offset = "0x4027300", VA = "0x184027F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4028550", Offset = "0x4027950", VA = "0x184028550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const float FIIPPEHIKNK = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly JMNCFHIJLAL IMJGFHGLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly HKLHFCGBNEN FGFPMOHFMOM;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private IDGMGLIGADE KHOLDMMJLMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x312F240", Offset = "0x312E640", VA = "0x18312F240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x77FBB0", Offset = "0x77EFB0", VA = "0x18077FBB0")]
	public KOFBKPMDMMN(JMNCFHIJLAL IMJGFHGLEPI, HKLHFCGBNEN FGFPMOHFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x312F100", Offset = "0x312E500", VA = "0x18312F100", Slot = "4")]
	[AsyncStateMachine(typeof(KNCGIDEBDPA))]
	public Task<bool> IEJLPOMLNHI(CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x312F290", Offset = "0x312E690", VA = "0x18312F290")]
	[CompilerGenerated]
	private object PBGKJHGMPAC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class MEHGBOFFCOJ : FMPFBNPFBBI
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class DKPMLJJNHFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public MEHGBOFFCOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Matchmaking.NKGDLLLCEFI result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public IDJHFGEEFAO newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public DKPMLJJNHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x401DDA0", Offset = "0x401D1A0", VA = "0x18401DDA0")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x401DEF0", Offset = "0x401D2F0", VA = "0x18401DEF0")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x401DF60", Offset = "0x401D360", VA = "0x18401DF60")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct BEFDCHJPBFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public MEHGBOFFCOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private DKPMLJJNHFL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<Matchmaking.NKGDLLLCEFI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x40194E0", Offset = "0x40188E0", VA = "0x1840194E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4019DD0", Offset = "0x40191D0", VA = "0x184019DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private const float FIIPPEHIKNK = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly JMNCFHIJLAL IMJGFHGLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly HKLHFCGBNEN FGFPMOHFMOM;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private IDGMGLIGADE KHOLDMMJLMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3131E10", Offset = "0x3131210", VA = "0x183131E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x77FBB0", Offset = "0x77EFB0", VA = "0x18077FBB0")]
	public MEHGBOFFCOJ(JMNCFHIJLAL IMJGFHGLEPI, HKLHFCGBNEN FGFPMOHFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x3131CD0", Offset = "0x31310D0", VA = "0x183131CD0", Slot = "4")]
	[AsyncStateMachine(typeof(BEFDCHJPBFM))]
	public Task<bool> IEJLPOMLNHI(CancellationToken OLHHOODBFDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal interface FMPFBNPFBBI
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> IEJLPOMLNHI(CancellationToken OLHHOODBFDC);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal struct PDBAGOONIAE
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class DMACALGIIOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public JMNCFHIJLAL manager;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public DMACALGIIOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x45CF1B0", Offset = "0x45CE5B0", VA = "0x1845CF1B0")]
		internal Task <CreateTask>b__0(HBMEPODFBHF data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct PKHGNFGCOEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public PDBAGOONIAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private HJHFIAECAFN <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<FMBDPDBMBFM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<BCGEGHGDJPI> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x45D7F60", Offset = "0x45D7360", VA = "0x1845D7F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x45D8470", Offset = "0x45D7870", VA = "0x1845D8470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct GOJIMMFEAOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public PDBAGOONIAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x45D2860", Offset = "0x45D1C60", VA = "0x1845D2860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CancellationToken OLHHOODBFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly JMNCFHIJLAL OBOKKBNADPB;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private OCLKGMDKHAF NJAPPDMCIGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A869D0", Offset = "0x3A85DD0", VA = "0x183A869D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private HKLHFCGBNEN DDGABFFCPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3A86980", Offset = "0x3A85D80", VA = "0x183A86980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private IDGMGLIGADE KHOLDMMJLMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3A86D60", Offset = "0x3A86160", VA = "0x183A86D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private ECICOCBCFBI PNKKAMKJODB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3A86D10", Offset = "0x3A86110", VA = "0x183A86D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3A86F80", Offset = "0x3A86380", VA = "0x183A86F80")]
	public PDBAGOONIAE(CancellationToken OLHHOODBFDC, JMNCFHIJLAL OBOKKBNADPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3A86B20", Offset = "0x3A85F20", VA = "0x183A86B20")]
	public static ECKFDOGEEPA HOJKAPIAMNB(JMNCFHIJLAL OBOKKBNADPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3A86850", Offset = "0x3A85C50", VA = "0x183A86850")]
	[AsyncStateMachine(typeof(PKHGNFGCOEL))]
	public Task<bool> BMPOKKCKKNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3A86DE0", Offset = "0x3A861E0", VA = "0x183A86DE0")]
	private bool PDHLMPEKDNL(out HJHFIAECAFN EKDFAKLJBGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3A86A20", Offset = "0x3A85E20", VA = "0x183A86A20")]
	[AsyncStateMachine(typeof(GOJIMMFEAOH))]
	private Task HNCHFOJPNIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3A86BD0", Offset = "0x3A85FD0", VA = "0x183A86BD0")]
	private Task<FMBDPDBMBFM> LBBCNNCJPAD(HJHFIAECAFN HFLFGBGANBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal struct HJHOLDMOADO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly COONKIKCBOP HGCLFAABBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid OMEAOMOIGDD;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private Task<(BCGEGHGDJPI, Task)> COAMFKHHHKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3127DD0", Offset = "0x31271D0", VA = "0x183127DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0xCB2520", Offset = "0xCB1920", VA = "0x180CB2520")]
	public HJHOLDMOADO(COONKIKCBOP HGCLFAABBMF, Guid OMEAOMOIGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3127D80", Offset = "0x3127180", VA = "0x183127D80")]
	public TaskAwaiter<(BCGEGHGDJPI, Task)> FGPGNCBIIPK()
	{
		return default(TaskAwaiter<(BCGEGHGDJPI, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3127CB0", Offset = "0x31270B0", VA = "0x183127CB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal struct FHOIEFINKGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly TaskCompletionSource<(BCGEGHGDJPI, Task)> BPKAACJCJCD;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Task<(BCGEGHGDJPI, Task)> COAMFKHHHKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x31222A0", Offset = "0x31216A0", VA = "0x1831222A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x3122330", Offset = "0x3121730", VA = "0x183122330")]
	public FHOIEFINKGL(TimeSpan JLCJBKDPAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3122130", Offset = "0x3121530", VA = "0x183122130")]
	public void HIMEKPFHIEL(Task IHCDPPNLEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x3122210", Offset = "0x3121610", VA = "0x183122210")]
	public void JIMBEJMINBB(BCGEGHGDJPI GLKJMCNNMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x31222E0", Offset = "0x31216E0", VA = "0x1831222E0")]
	public void OPPKKPLCANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x31220A0", Offset = "0x31214A0", VA = "0x1831220A0")]
	internal void AIFJCFNBGEK(string DENPJAMCNLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class MPMBJGBMNCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class KCNCPKEJCEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public long subRoomId;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public KCNCPKEJCEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x18895B0", Offset = "0x18889B0", VA = "0x1818895B0")]
		internal bool <Create>b__0(COOBAAMIODE subRoom)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D6A0", Offset = "0x3A7CAA0", VA = "0x183A7D6A0")]
	public static GKIAAKPIFKA BFPHDDBHNEE(long CDDPJFBHIMC, long ADPAGPHKENF, AKFPGEDHNIP NMJILFMGNAI, string IDBLHDFAAFE, AKFPGEDHNIP LAODEMMELPI, string MILFEKOPFBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D310", Offset = "0x3A7C710", VA = "0x183A7D310")]
	public static GKIAAKPIFKA BFPHDDBHNEE(NJHHCJFILAP JBGBDEJMHBA, DMKADNPMMCB KFEEGEEOKGL, [Optional] string MILFEKOPFBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D480", Offset = "0x3A7C880", VA = "0x183A7D480")]
	public static GKIAAKPIFKA BFPHDDBHNEE(NJHHCJFILAP JBGBDEJMHBA, long ADPAGPHKENF, [Optional] string MILFEKOPFBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D9A0", Offset = "0x3A7CDA0", VA = "0x183A7D9A0")]
	public static GKIAAKPIFKA JHABAINNCAN(this GKIAAKPIFKA KBGLHNCEHFF, NJHHCJFILAP BMCMMEMFJOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D8C0", Offset = "0x3A7CCC0", VA = "0x183A7D8C0")]
	public static GKIAAKPIFKA BOMCEOGINNK(this GKIAAKPIFKA KBGLHNCEHFF, DMKADNPMMCB MHOONPPAHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D7E0", Offset = "0x3A7CBE0", VA = "0x183A7D7E0")]
	public static GKIAAKPIFKA BOMCEOGINNK(this GKIAAKPIFKA KBGLHNCEHFF, COOBAAMIODE KJHIAIHHEEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[UnityEngine.Scripting.Preserve]
internal class HFFNFMGJIOE : HOKGHPAIJPE, PCBEFAPPLHA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct EPKOONIDJHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public HFFNFMGJIOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x401FD70", Offset = "0x401F170", VA = "0x18401FD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly GLKHMHJFJLG DBFEJDFMMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private string BLJBMGIFGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Task NMJAAEKDIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private JMNCFHIJLAL IMJGFHGLEPI;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool BNBMIMCILDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3127840", Offset = "0x3126C40", VA = "0x183127840", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Task PBFEMOHINML
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3127870", Offset = "0x3126C70", VA = "0x183127870", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7B2940", Offset = "0x7B1D40", VA = "0x1807B2940", Slot = "7")]
	public void BNACPANAOEJ(JMNCFHIJLAL IMJGFHGLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x31276C0", Offset = "0x3126AC0", VA = "0x1831276C0", Slot = "6")]
	public void ELKFLPDMFCE(Task DLDNMMGIFIK, string JLDFDOILLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x31278D0", Offset = "0x3126CD0", VA = "0x1831278D0")]
	[AsyncStateMachine(typeof(EPKOONIDJHM))]
	private Task JGLJDAPPMFB(Task DHAOJIJAMHP, string JLDFDOILLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3127A00", Offset = "0x3126E00", VA = "0x183127A00")]
	public HFFNFMGJIOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class NAJJCNFDHID : LMBFFAEKNKL, PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool MJMPHGBAKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private EMJFBIFAMEN GAMLAEFKOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private OCLKGMDKHAF LHLIGPNBLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private FMBGGBENKME HPHLIJIBJEH;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public EMJFBIFAMEN BENGGBGOJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3A7F260", Offset = "0x3A7E660", VA = "0x183A7F260", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3A7F0E0", Offset = "0x3A7E4E0", VA = "0x183A7F0E0", Slot = "7")]
	public void BNACPANAOEJ(JMNCFHIJLAL IMJGFHGLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A7EF20", Offset = "0x3A7E320", VA = "0x183A7EF20", Slot = "5")]
	public void AFNGPHCLMNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x3A7EEE0", Offset = "0x3A7E2E0", VA = "0x183A7EEE0", Slot = "6")]
	public void ABEMGBENLOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3A7F2D0", Offset = "0x3A7E6D0", VA = "0x183A7F2D0")]
	private Task OHKILJOKCAE(MIFJLBDDLNO IGJFJCHKKMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x3A7EEE0", Offset = "0x3A7E2E0", VA = "0x183A7EEE0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public NAJJCNFDHID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class GMDIMOICAKF : FMBGGBENKME
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private class JEDNPNBGKGJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly PEDGOFLLMDJ CANJKFBLJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string EBOEHIFNNLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly T EOBGHKICABG;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public T ALAOEPGGPNI
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x75DD10", Offset = "0x75D110", VA = "0x18075DD10")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x75DD30", Offset = "0x75D130", VA = "0x18075DD30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD5B0", Offset = "0x3AAC9B0", VA = "0x183AAD5B0")]
		public JEDNPNBGKGJ(PEDGOFLLMDJ CANJKFBLJKC, string EBOEHIFNNLM, T EOBGHKICABG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD240", Offset = "0x3AAC640", VA = "0x183AAD240")]
		private void ICKNCGKCGIH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly JEDNPNBGKGJ<TimeSpan> FBMJOFOHHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly JEDNPNBGKGJ<TimeSpan> LIMNHAPHHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly JEDNPNBGKGJ<TimeSpan> JOOGHFGDMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly JEDNPNBGKGJ<TimeSpan> ANGOLBCHFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly JEDNPNBGKGJ<bool> GCEBHGOEPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly JEDNPNBGKGJ<bool> HIKOHCACMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly JEDNPNBGKGJ<bool> AOFDKDNGADJ;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public TimeSpan PGPENOKLNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3125190", Offset = "0x3124590", VA = "0x183125190", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public TimeSpan IJNMMMMEPAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3125150", Offset = "0x3124550", VA = "0x183125150", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public TimeSpan GIIBLCEIOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3125110", Offset = "0x3124510", VA = "0x183125110", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan BGCDLKHGAIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x31251D0", Offset = "0x31245D0", VA = "0x1831251D0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool APIGLJCNKJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3125090", Offset = "0x3124490", VA = "0x183125090", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool JDAFDDDJMBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x31250D0", Offset = "0x31244D0", VA = "0x1831250D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool PLIICIAGNOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3125210", Offset = "0x3124610", VA = "0x183125210", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x3125250", Offset = "0x3124650", VA = "0x183125250")]
	[UnityEngine.Scripting.Preserve]
	public GMDIMOICAKF([CNHALHMHHIC(null)] PEDGOFLLMDJ CANJKFBLJKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[UnityEngine.Scripting.Preserve]
internal class MDJHCNHOIKE : BOHCGLIDEGH, PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class JAEGJKIHLJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public NBNKBIKAIGB roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public JAEGJKIHLJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x4024470", Offset = "0x4023870", VA = "0x184024470")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action IHOPJKJHOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x312FF90", Offset = "0x312F390", VA = "0x18312FF90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x31304D0", Offset = "0x312F8D0", VA = "0x1831304D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event MMGGIDKNBHL NFLKMPMKOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3130930", Offset = "0x312FD30", VA = "0x183130930", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x31301D0", Offset = "0x312F5D0", VA = "0x1831301D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event MMGGIDKNBHL JEOKJPHGMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3130890", Offset = "0x312FC90", VA = "0x183130890", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x312FE10", Offset = "0x312F210", VA = "0x18312FE10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event MMGGIDKNBHL HJDGBEEMKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x31309D0", Offset = "0x312FDD0", VA = "0x1831309D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3130030", Offset = "0x312F430", VA = "0x183130030", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<FDJMDHAGLAP, bool> BNNCAJJKHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3130130", Offset = "0x312F530", VA = "0x183130130", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x31307F0", Offset = "0x312FBF0", VA = "0x1831307F0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "19")]
	public void BNACPANAOEJ(JMNCFHIJLAL IMJGFHGLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x3130570", Offset = "0x312F970", VA = "0x183130570", Slot = "14")]
	public void NKDELDGHDOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x31300D0", Offset = "0x312F4D0", VA = "0x1831300D0", Slot = "15")]
	public void FBDNENELBEC(NBNKBIKAIGB MLBPLLDNPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x3130100", Offset = "0x312F500", VA = "0x183130100", Slot = "16")]
	public void FFICBGDLDFF(NBNKBIKAIGB MLBPLLDNPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x312FF60", Offset = "0x312F360", VA = "0x18312FF60", Slot = "17")]
	public void DAKJNJIGGOI(NBNKBIKAIGB MLBPLLDNPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x312FEB0", Offset = "0x312F2B0", VA = "0x18312FEB0", Slot = "18")]
	public void DAINKJMBOKO(FDJMDHAGLAP HGNGEDBMHCK, bool PKOGEGLMCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3130270", Offset = "0x312F670", VA = "0x183130270")]
	private void KICKDGJKECN(MMGGIDKNBHL IHDBFFAAICJ, NBNKBIKAIGB MLBPLLDNPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public MDJHCNHOIKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[UnityEngine.Scripting.Preserve]
internal class ONPAOBEDKDG : MJBGHMCABDH, PCBEFAPPLHA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct HGOBMLFAOGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ONPAOBEDKDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x45D35D0", Offset = "0x45D29D0", VA = "0x1845D35D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct CMBHJOIAOPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public ONPAOBEDKDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x45CEDF0", Offset = "0x45CE1F0", VA = "0x1845CEDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class PDENLCBNMEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PDENLCBNMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x45D7DE0", Offset = "0x45D71E0", VA = "0x1845D7DE0")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct DMMPONHNFLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public ONPAOBEDKDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private PDENLCBNMEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x45CF1F0", Offset = "0x45CE5F0", VA = "0x1845CF1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x45CF780", Offset = "0x45CEB80", VA = "0x1845CF780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class AKOLKDFCIBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public AKOLKDFCIBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x45CD010", Offset = "0x45CC410", VA = "0x1845CD010")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private JMNCFHIJLAL IMJGFHGLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private HKLHFCGBNEN FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private FMPFBNPFBBI[] OLHEDFDOIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private CancellationTokenSource BMLBNCLOPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private int MHCOIGHGMIN;

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x3A85790", Offset = "0x3A84B90", VA = "0x183A85790", Slot = "7")]
	public void BNACPANAOEJ(JMNCFHIJLAL IMJGFHGLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x3A85C90", Offset = "0x3A85090", VA = "0x183A85C90", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x3A86220", Offset = "0x3A85620", VA = "0x183A86220", Slot = "6")]
	public void OBGDMCGDCAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x3A85630", Offset = "0x3A84A30", VA = "0x183A85630", Slot = "5")]
	public void BLEIJLMEPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x3A863A0", Offset = "0x3A857A0", VA = "0x183A863A0", Slot = "4")]
	[AsyncStateMachine(typeof(HGOBMLFAOGP))]
	public Task PANECCPLNBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x3A85810", Offset = "0x3A84C10", VA = "0x183A85810")]
	private void CMGHHGCEPKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x3A85B60", Offset = "0x3A84F60", VA = "0x183A85B60")]
	[AsyncStateMachine(typeof(CMBHJOIAOPO))]
	private Task DHGEOBNEMMO(CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x3A864B0", Offset = "0x3A858B0", VA = "0x183A864B0")]
	[AsyncStateMachine(typeof(DMMPONHNFLG))]
	private Task<bool> PONEILNIFDC(int BELCAJFDAHD, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x3A85F00", Offset = "0x3A85300", VA = "0x183A85F00")]
	private void IMGGFDKOHBG(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x3A85CA0", Offset = "0x3A850A0", VA = "0x183A85CA0")]
	private void FLFGIBIFDJP(int BELCAJFDAHD, bool PKOGEGLMCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x3A86060", Offset = "0x3A85460", VA = "0x183A86060")]
	private void MAOBGKAGECK(int BELCAJFDAHD, Exception AKCADADCFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x3A85DF0", Offset = "0x3A851F0", VA = "0x183A85DF0")]
	private void HDIPPBCFDJO(CancellationToken OLHHOODBFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public ONPAOBEDKDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[UnityEngine.Scripting.Preserve]
internal class NAJEPJJAPOK : IOHIBNHMCEK, PCBEFAPPLHA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct PCDPOKFDJEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public NAJEPJJAPOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public HBMEPODFBHF roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x45D7990", Offset = "0x45D6D90", VA = "0x1845D7990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class HKPDKKHCNPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public NAJEPJJAPOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public HBMEPODFBHF roomData;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public HKPDKKHCNPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x45D3D70", Offset = "0x45D3170", VA = "0x1845D3D70")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct BJHNCKLIOAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public ECKFDOGEEPA taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x45CD6D0", Offset = "0x45CCAD0", VA = "0x1845CD6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct FNMJAOIMJPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public NAJEPJJAPOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x45D1E20", Offset = "0x45D1220", VA = "0x1845D1E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly HashSet<ECKFDOGEEPA> JMIJDGINKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private LKHDDEOALEA PPABLONDLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private JMNCFHIJLAL IMJGFHGLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private BOEEIMMOILK CEGKPDMMAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private OLILHDPEHAK FDDBMNENEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private IDisposable JPKGBDHKLJF;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool IIGPGGNOILH
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3A7EE30", Offset = "0x3A7E230", VA = "0x183A7EE30", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	internal Task COAMFKHHHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3A7EE20", Offset = "0x3A7E220", VA = "0x183A7EE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3A7DAA0", Offset = "0x3A7CEA0", VA = "0x183A7DAA0", Slot = "6")]
	public void BNACPANAOEJ(JMNCFHIJLAL IMJGFHGLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3A7DDA0", Offset = "0x3A7D1A0", VA = "0x183A7DDA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3A7EB70", Offset = "0x3A7DF70", VA = "0x183A7EB70", Slot = "5")]
	public bool NKGFEGECMBF(ECKFDOGEEPA GGJAGGNMEDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3A7E540", Offset = "0x3A7D940", VA = "0x183A7E540")]
	private void KDOBBBHAIJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3A7E7A0", Offset = "0x3A7DBA0", VA = "0x183A7E7A0")]
	private void MBECNCPGBLK(HBMEPODFBHF GDKBHGNBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3A7ED00", Offset = "0x3A7E100", VA = "0x183A7ED00")]
	[AsyncStateMachine(typeof(PCDPOKFDJEA))]
	private Task OHFFOBNCAGF(HBMEPODFBHF GDKBHGNBDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3A7DF20", Offset = "0x3A7D320", VA = "0x183A7DF20")]
	private Func<CancellationToken, List<Task>> GMOMPKAIFON(HBMEPODFBHF GDKBHGNBDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3A7E000", Offset = "0x3A7D400", VA = "0x183A7E000")]
	private List<Task> IKJHKBGNAAO(HBMEPODFBHF GDKBHGNBDKI, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3A7EA40", Offset = "0x3A7DE40", VA = "0x183A7EA40")]
	[AsyncStateMachine(typeof(BJHNCKLIOAL))]
	private Task MPOGGOGJCIE(ECKFDOGEEPA BDJCJJEPECL, HBMEPODFBHF ONIBEFDCPGD, CancellationToken AJDBKDIMOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x3A7DE20", Offset = "0x3A7D220", VA = "0x183A7DE20")]
	[AsyncStateMachine(typeof(FNMJAOIMJPK))]
	private Task EBIKNHOPBCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x3A7EBD0", Offset = "0x3A7DFD0", VA = "0x183A7EBD0")]
	private void OBGDMCGDCAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x3A7EE60", Offset = "0x3A7E260", VA = "0x183A7EE60")]
	public NAJEPJJAPOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[RecRoom.NoEngine.Common.Preserve]
internal class HKDDGCNLHOK : IOCLFLHAOLK, PCBEFAPPLHA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct NAIIMPMNKDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public IDJHFGEEFAO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public HKDDGCNLHOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public AMEFKLDHCDD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x4029800", Offset = "0x4028C00", VA = "0x184029800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct CHOMHHPFAME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public HKDDGCNLHOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public IDJHFGEEFAO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AMEFKLDHCDD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private global::NEKDBCPDAGF<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private FHFCMNCJGAI <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private JIFPIMFGIMH <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x401C670", Offset = "0x401BA70", VA = "0x18401C670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class AGLKLKICAFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public Task<GKIAAKPIFKA> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public AGLKLKICAFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
		internal Task<GKIAAKPIFKA> <ConnectToRoomAndRunLoadLogic>b__0(IBIDBCAPHMG _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct KLMDCPGBHGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public HKDDGCNLHOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public IDJHFGEEFAO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public IBIDBCAPHMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public AMEFKLDHCDD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public FHFCMNCJGAI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private AGLKLKICAFB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private BNJMAHNLHOH <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private IBIDBCAPHMG <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private CINGNOEIMGI <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private CancellationTokenSource <photonJoinedTokenSource>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private CancellationToken <photonJoinedToken>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private Task <roomLoadTask>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter<GKIAAKPIFKA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x4026700", Offset = "0x4025B00", VA = "0x184026700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct BDCKFJANFMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public HKDDGCNLHOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public IBIDBCAPHMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private IBIDBCAPHMG <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private IBIDBCAPHMG <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x4018BF0", Offset = "0x4017FF0", VA = "0x184018BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct PLGLKJALNPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public HKDDGCNLHOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private LECENBDGBAK <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x402CAA0", Offset = "0x402BEA0", VA = "0x18402CAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct JOMNFGMACLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public IBIDBCAPHMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public IDJHFGEEFAO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public HKDDGCNLHOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public FHFCMNCJGAI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private IBIDBCAPHMG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter<LHJNPODOKGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x40245D0", Offset = "0x40239D0", VA = "0x1840245D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class GGPIIJGEJCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public IDJHFGEEFAO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public GGPIIJGEJCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x4021F50", Offset = "0x4021350", VA = "0x184021F50")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x4021E50", Offset = "0x4021250", VA = "0x184021E50")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct NEADKGGLOHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public IDJHFGEEFAO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public HKDDGCNLHOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private GGPIIJGEJCB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x4029D60", Offset = "0x4029160", VA = "0x184029D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct DKAMOFHMHNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public IBIDBCAPHMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public HKDDGCNLHOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public FHFCMNCJGAI joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public GKIAAKPIFKA initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public IDJHFGEEFAO targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public BNJMAHNLHOH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private IBIDBCAPHMG <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x401D7C0", Offset = "0x401CBC0", VA = "0x18401D7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct DEBOHPPPKBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public IBIDBCAPHMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public HKDDGCNLHOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private IBIDBCAPHMG <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x401D240", Offset = "0x401C640", VA = "0x18401D240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct DONFKFHAAAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public HKDDGCNLHOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public IBIDBCAPHMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x401E000", Offset = "0x401D400", VA = "0x18401E000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct BMCMDCDJHIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public IBIDBCAPHMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public HKDDGCNLHOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private IBIDBCAPHMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x401B160", Offset = "0x401A560", VA = "0x18401B160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct DPKIOIIDKOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public HKDDGCNLHOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<BCGEGHGDJPI> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x401E6A0", Offset = "0x401DAA0", VA = "0x18401E6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct PHJBAPAGKAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public HKDDGCNLHOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private IBIDBCAPHMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x402C5E0", Offset = "0x402B9E0", VA = "0x18402C5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class GIGPHLJOFEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public IDJHFGEEFAO targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public GIGPHLJOFEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x4022FE0", Offset = "0x40223E0", VA = "0x184022FE0")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class ACGFHAHJANL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ACGFHAHJANL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x40182D0", Offset = "0x40176D0", VA = "0x1840182D0")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class IIIIPOGNKHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public IDJHFGEEFAO targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public IIIIPOGNKHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x4024160", Offset = "0x4023560", VA = "0x184024160")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class CDMANELFDFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public IDJHFGEEFAO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public CDMANELFDFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x401C510", Offset = "0x401B910", VA = "0x18401C510")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly string MGCGCDEMOCJ;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly string MCEHMGDCIOF;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly string OAGPDDHKNOK;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly Guid HOLNKHKCCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private AMMHDIJOABG NDMFPGJENNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private LKHDDEOALEA PPABLONDLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private OCLKGMDKHAF LHLIGPNBLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private JMNCFHIJLAL IMJGFHGLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private HKLHFCGBNEN FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private MJBGHMCABDH FIHFCIIOOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private HOKGHPAIJPE DKMAEGIFCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private BOHCGLIDEGH IPILJEFIHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private FMBGGBENKME HPHLIJIBJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private IDisposable JPKGBDHKLJF;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public TaskStatus NGNILFAPKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA37490", Offset = "0xA36890", VA = "0x180A37490", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1127C60", Offset = "0x1127060", VA = "0x181127C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private IDGMGLIGADE KHOLDMMJLMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x312B710", Offset = "0x312AB10", VA = "0x18312B710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x3129130", Offset = "0x3128530", VA = "0x183129130", Slot = "6")]
	public void BNACPANAOEJ(JMNCFHIJLAL IMJGFHGLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x3129770", Offset = "0x3128B70", VA = "0x183129770", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3129F80", Offset = "0x3129380", VA = "0x183129F80", Slot = "5")]
	[AsyncStateMachine(typeof(NAIIMPMNKDG))]
	public Task GALAIALKFKC(IDJHFGEEFAO NPLPKFFKPLE, AMEFKLDHCDD KCIIEMDKNMC, CancellationToken FFBLKMEPPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3129610", Offset = "0x3128A10", VA = "0x183129610")]
	[AsyncStateMachine(typeof(CHOMHHPFAME))]
	private Task DMNHGMPEOCJ(IDJHFGEEFAO NPLPKFFKPLE, AMEFKLDHCDD KCIIEMDKNMC, CancellationToken FFBLKMEPPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3129A70", Offset = "0x3128E70", VA = "0x183129A70")]
	private static void EMIPGFMMMIM(IDJHFGEEFAO NPLPKFFKPLE, Exception AKCADADCFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x312AA30", Offset = "0x3129E30", VA = "0x18312AA30")]
	private static void JAFGLLFBMFG(JIFPIMFGIMH JANDIEDHMGD, Exception AKCADADCFJN, [Optional] List<int> OBLMBGGIALD, int MHCOIGHGMIN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x312A8B0", Offset = "0x3129CB0", VA = "0x18312A8B0")]
	[AsyncStateMachine(typeof(KLMDCPGBHGL))]
	private Task IMKHOFDKJCN(IBIDBCAPHMG HHEDADBLDNA, IDJHFGEEFAO NPLPKFFKPLE, AMEFKLDHCDD KCIIEMDKNMC, FHFCMNCJGAI HBFINIJBIAP, CancellationToken FFBLKMEPPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3128830", Offset = "0x3127C30", VA = "0x183128830")]
	private void AFIHHDNFAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x31294D0", Offset = "0x31288D0", VA = "0x1831294D0")]
	[AsyncStateMachine(typeof(BDCKFJANFMO))]
	private Task CAKOIPJBDEJ(IBIDBCAPHMG HHEDADBLDNA, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x312A3D0", Offset = "0x31297D0", VA = "0x18312A3D0")]
	private void ICPPJHBPDJI(IDJHFGEEFAO NPLPKFFKPLE, CancellationToken FFBLKMEPPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x3129C30", Offset = "0x3129030", VA = "0x183129C30")]
	private void FEALFPCDAGE(IDJHFGEEFAO NPLPKFFKPLE, FHFCMNCJGAI HBFINIJBIAP, OperationCanceledException OIPAGBJFLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x3128980", Offset = "0x3127D80", VA = "0x183128980")]
	private void ANEFFJJIKBA(IDJHFGEEFAO NPLPKFFKPLE, FHFCMNCJGAI HBFINIJBIAP, Exception AKCADADCFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3128590", Offset = "0x3127990", VA = "0x183128590")]
	private void AFCLJDALNGH(IDJHFGEEFAO NPLPKFFKPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x312BC40", Offset = "0x312B040", VA = "0x18312BC40")]
	private static NBNKBIKAIGB PFOHOLFJDOC(IDJHFGEEFAO NPLPKFFKPLE)
	{
		return default(NBNKBIKAIGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x312B760", Offset = "0x312AB60", VA = "0x18312B760")]
	[AsyncStateMachine(typeof(PLGLKJALNPF))]
	private Task MMICJGHNIJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x312B440", Offset = "0x312A840", VA = "0x18312B440")]
	private static LHJNPODOKGA KEBFAHEGKNK(IDJHFGEEFAO NPLPKFFKPLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x3129900", Offset = "0x3128D00", VA = "0x183129900")]
	[AsyncStateMachine(typeof(JOMNFGMACLL))]
	private Task EHHPKOONIMA(IDJHFGEEFAO NPLPKFFKPLE, FHFCMNCJGAI HBFINIJBIAP, IBIDBCAPHMG HHEDADBLDNA, CancellationToken IPIGPAAHFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x312BAE0", Offset = "0x312AEE0", VA = "0x18312BAE0")]
	[AsyncStateMachine(typeof(NEADKGGLOHI))]
	private Task ODKAMPDDEFO(IDJHFGEEFAO NPLPKFFKPLE, CancellationTokenSource BAIOINENBJA, Task NJGCJFLLHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x3129340", Offset = "0x3128740", VA = "0x183129340")]
	[AsyncStateMachine(typeof(DKAMOFHMHNP))]
	private Task CAEKOAPOAKN(GKIAAKPIFKA JCCBLHPABCB, BNJMAHNLHOH EIAPDOMBHAD, IDJHFGEEFAO NECAKFLPNCG, FHFCMNCJGAI PIHFFLBPGBM, IBIDBCAPHMG HHEDADBLDNA, CancellationToken PEMFLHNKENE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3128340", Offset = "0x3127740", VA = "0x183128340")]
	private FHFCMNCJGAI ADPJFFHKILK(FHFCMNCJGAI PIHFFLBPGBM, ref CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x31297C0", Offset = "0x3128BC0", VA = "0x1831297C0")]
	[AsyncStateMachine(typeof(DEBOHPPPKBB))]
	private Task EGLIIGHBDPA(IBIDBCAPHMG HHEDADBLDNA, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x312A0D0", Offset = "0x31294D0", VA = "0x18312A0D0")]
	[AsyncStateMachine(typeof(DONFKFHAAAO))]
	private Task GHBMNFLDLGP(IBIDBCAPHMG HHEDADBLDNA, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x312A200", Offset = "0x3129600", VA = "0x18312A200")]
	[AsyncStateMachine(typeof(BMCMDCDJHIG))]
	private Task HJEFNDOJJLE(IBIDBCAPHMG HHEDADBLDNA, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x3128DB0", Offset = "0x31281B0", VA = "0x183128DB0")]
	[AsyncStateMachine(typeof(DPKIOIIDKOM))]
	private Task BKINIBCBDLO(HBMEPODFBHF ONIBEFDCPGD, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x312B300", Offset = "0x312A700", VA = "0x18312B300")]
	[AsyncStateMachine(typeof(PHJBAPAGKAH))]
	private Task JPCJBDPLHHF(IBIDBCAPHMG KIBJDNPFMAF, CancellationToken IPIGPAAHFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x3128C40", Offset = "0x3128040", VA = "0x183128C40")]
	private static void AOIJHDDHLLK(IDJHFGEEFAO NPLPKFFKPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x312B4F0", Offset = "0x312A8F0", VA = "0x18312B4F0")]
	private void MCBLIFLGFJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x312A340", Offset = "0x3129740", VA = "0x18312A340")]
	private void HLJPAGLIJDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x3129EF0", Offset = "0x31292F0", VA = "0x183129EF0")]
	private void FMIPIJIHOJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x312B270", Offset = "0x312A670", VA = "0x18312B270")]
	private void JHGKMKFCIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x312A730", Offset = "0x3129B30", VA = "0x18312A730")]
	private static void ILKGBJJACAC(IDJHFGEEFAO NPLPKFFKPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x312BC80", Offset = "0x312B080", VA = "0x18312BC80")]
	private static void PMHEDKAMGDE(IDJHFGEEFAO NPLPKFFKPLE, CancellationToken IPIGPAAHFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x312B860", Offset = "0x312AC60", VA = "0x18312B860")]
	private static void NDKOBHBPGPF(IDJHFGEEFAO NPLPKFFKPLE, Exception AKCADADCFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x3128EF0", Offset = "0x31282F0", VA = "0x183128EF0")]
	private void BMEMPHHLLJL(IDJHFGEEFAO NPLPKFFKPLE, Task NJGCJFLLHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x312B9F0", Offset = "0x312ADF0", VA = "0x18312B9F0")]
	private static void NDPGLCAACEE(Func<string> HKGFIHMBIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x312BE30", Offset = "0x312B230", VA = "0x18312BE30")]
	public HKDDGCNLHOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[UnityEngine.Scripting.Preserve]
internal sealed class FLGONBGCOMA : COONKIKCBOP, PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class JNHJCAGFKKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public JNHJCAGFKKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x4024570", Offset = "0x4023970", VA = "0x184024570")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class FFAHPMFHJFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public FFAHPMFHJFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x4020BB0", Offset = "0x401FFB0", VA = "0x184020BB0")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class FHLFKLJKIEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public FHLFKLJKIEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x4020C10", Offset = "0x4020010", VA = "0x184020C10")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class CCGFEBKLDBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public CCGFEBKLDBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x401C4B0", Offset = "0x401B8B0", VA = "0x18401C4B0")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class CFNJHAOBCNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public CFNJHAOBCNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x401C610", Offset = "0x401BA10", VA = "0x18401C610")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private readonly Dictionary<Guid, FHOIEFINKGL> HGCLFAABBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private readonly TimeSpan KNHJDMMGNCL;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "10")]
	public void BNACPANAOEJ(JMNCFHIJLAL IMJGFHGLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x31233A0", Offset = "0x31227A0", VA = "0x1831233A0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x3122E50", Offset = "0x3122250", VA = "0x183122E50", Slot = "4")]
	public HJHOLDMOADO AOHLLDNPMGN(Guid OMEAOMOIGDD)
	{
		return default(HJHOLDMOADO);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x31230E0", Offset = "0x31224E0", VA = "0x1831230E0", Slot = "5")]
	public bool BCBAFCFKBLF(Guid OMEAOMOIGDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x3123D10", Offset = "0x3123110", VA = "0x183123D10", Slot = "8")]
	public bool OBGDMCGDCAI(Guid OMEAOMOIGDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x31233B0", Offset = "0x31227B0", VA = "0x1831233B0", Slot = "6")]
	public bool GCFIJOMHNGB(Guid OMEAOMOIGDD, Task IHCDPPNLEGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x3123A40", Offset = "0x3122E40", VA = "0x183123A40", Slot = "7")]
	public bool HIPPOGMIDML(Guid OMEAOMOIGDD, BCGEGHGDJPI GLKJMCNNMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x3122DC0", Offset = "0x31221C0", VA = "0x183122DC0", Slot = "9")]
	public Task<(BCGEGHGDJPI, Task)> AEIJLFCLAAN(Guid OMEAOMOIGDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x3123780", Offset = "0x3122B80", VA = "0x183123780")]
	private void GOAKHIJGIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x3123F90", Offset = "0x3123390", VA = "0x183123F90")]
	public FLGONBGCOMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[UnityEngine.Scripting.Preserve]
internal class BEHAKBHHLDE : JELOMCLHFJH, PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private class HODJBAJIHJL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private readonly IDJHFGEEFAO AKLGGPCNKNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private readonly CancellationTokenSource BMLBNCLOPOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public readonly CancellationToken BOFNFMALJFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private bool AECGNKKKMIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private bool NPIEAKJHFPJ;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x3A77390", Offset = "0x3A76790", VA = "0x183A77390")]
		public HODJBAJIHJL(IDJHFGEEFAO AKLGGPCNKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3A77240", Offset = "0x3A76640", VA = "0x183A77240")]
		public void OBGDMCGDCAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x3A77210", Offset = "0x3A76610", VA = "0x183A77210", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class ENILLFPMPHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public MIFJLBDDLNO disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ENILLFPMPHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x3A72DC0", Offset = "0x3A721C0", VA = "0x183A72DC0")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct JDNGPMOLHLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public MIFJLBDDLNO disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public BEHAKBHHLDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x3A78850", Offset = "0x3A77C50", VA = "0x183A78850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class DKCKJLOJMIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public DKCKJLOJMIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x3A72A00", Offset = "0x3A71E00", VA = "0x183A72A00")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct LFENKBIHPJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public BEHAKBHHLDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x3A7A020", Offset = "0x3A79420", VA = "0x183A7A020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x788E90", Offset = "0x788290", VA = "0x180788E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class NHLAPDBPGKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public IDJHFGEEFAO newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public NHLAPDBPGKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x3A7FC70", Offset = "0x3A7F070", VA = "0x183A7FC70")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x3A7FD10", Offset = "0x3A7F110", VA = "0x183A7FD10")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x3A7FD50", Offset = "0x3A7F150", VA = "0x183A7FD50")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class FDAHOBIMGJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public FDAHOBIMGJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x3A73860", Offset = "0x3A72C60", VA = "0x183A73860")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct MLBCJDGGOEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public IDJHFGEEFAO newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public BEHAKBHHLDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public AMEFKLDHCDD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private NHLAPDBPGKL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x3A7B980", Offset = "0x3A7AD80", VA = "0x183A7B980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private LKHDDEOALEA PPABLONDLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private JMNCFHIJLAL IMJGFHGLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private MJBGHMCABDH FIHFCIIOOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private HKLHFCGBNEN FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private FMBGGBENKME HPHLIJIBJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private IOCLFLHAOLK PLPEFHCJLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private long GKICBCFKKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private HODJBAJIHJL BJBLDDKFFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private bool BKOHNKAPGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private Task KEKFHBPNOMN;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private IDGMGLIGADE KHOLDMMJLMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x311A570", Offset = "0x3119970", VA = "0x18311A570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool LKGHHHIHNKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7BE830", Offset = "0x7BDC30", VA = "0x1807BE830")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x31196B0", Offset = "0x3118AB0", VA = "0x1831196B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x31196C0", Offset = "0x3118AC0", VA = "0x1831196C0", Slot = "4")]
	public void BNACPANAOEJ(JMNCFHIJLAL IMJGFHGLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x3119BD0", Offset = "0x3118FD0", VA = "0x183119BD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x3119970", Offset = "0x3118D70", VA = "0x183119970")]
	[AsyncStateMachine(typeof(JDNGPMOLHLK))]
	private Task CBHMPHFLOJF(MIFJLBDDLNO HAPIAPNFHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x311A180", Offset = "0x3119580", VA = "0x18311A180")]
	private void LDCDDIKNALD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3119F60", Offset = "0x3119360", VA = "0x183119F60")]
	private void ILPCMENOJLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x3119D50", Offset = "0x3119150", VA = "0x183119D50")]
	private void FKDCDGEDNML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x3119540", Offset = "0x3118940", VA = "0x183119540")]
	private bool ACIIKMFANDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x31195C0", Offset = "0x31189C0", VA = "0x1831195C0")]
	[AsyncStateMachine(typeof(LFENKBIHPJD))]
	private void BFPGJKOJKHA(int PMIGFHIBOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x311A5C0", Offset = "0x31199C0", VA = "0x18311A5C0")]
	private void MNDPOEHKEAM(out IDisposable DAOHFIKEKPA, out IDisposable MBBNHJPHBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x311A3A0", Offset = "0x31197A0", VA = "0x18311A3A0")]
	private bool LFBBCLAALCP(IDJHFGEEFAO AKLGGPCNKNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x311A530", Offset = "0x3119930", VA = "0x18311A530")]
	private void MHCEGDOLLGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3119A90", Offset = "0x3118E90", VA = "0x183119A90")]
	[AsyncStateMachine(typeof(MLBCJDGGOEO))]
	private Task DMNHGMPEOCJ(IDJHFGEEFAO AKLGGPCNKNN, AMEFKLDHCDD KCIIEMDKNMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x311A980", Offset = "0x3119D80", VA = "0x18311A980")]
	public BEHAKBHHLDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[UnityEngine.Scripting.Preserve]
internal sealed class PFKKAOHJEIA : JHOIAGANLCL, PCBEFAPPLHA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct ADDOBHKFAKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public AsyncTaskMethodBuilder<LBJBELAPCEL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public PFKKAOHJEIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private TaskAwaiter<LBJBELAPCEL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x45CCD70", Offset = "0x45CC170", VA = "0x1845CCD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x45CCFC0", Offset = "0x45CC3C0", VA = "0x1845CCFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class IHEILHNNMMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public PLBGOAPJHAI message;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public IHEILHNNMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x45D4250", Offset = "0x45D3650", VA = "0x1845D4250")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class PPGKEDFMEOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public PLBGOAPJHAI messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PPGKEDFMEOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x45D9EF0", Offset = "0x45D92F0", VA = "0x1845D9EF0")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class GDFDJNGILJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public PLBGOAPJHAI request;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public GDFDJNGILJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x45D22B0", Offset = "0x45D16B0", VA = "0x1845D22B0")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct ODCPNMPFFDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public PLBGOAPJHAI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public PFKKAOHJEIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private TaskAwaiter<NJHNOKIINKM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x45D7310", Offset = "0x45D6710", VA = "0x1845D7310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class LNKMGPKFOOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public PLBGOAPJHAI operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public LNKMGPKFOOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x45D5940", Offset = "0x45D4D40", VA = "0x1845D5940")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct JKJJMEGDJAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public PLBGOAPJHAI operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public PFKKAOHJEIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private FHFCMNCJGAI <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter<PLBGOAPJHAI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x45D4960", Offset = "0x45D3D60", VA = "0x1845D4960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct FEOAODGPIFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public AsyncTaskMethodBuilder<NJHNOKIINKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public PFKKAOHJEIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public PLBGOAPJHAI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private FHFCMNCJGAI <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter<PLBGOAPJHAI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x45CFE60", Offset = "0x45CF260", VA = "0x1845CFE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x45D02B0", Offset = "0x45CF6B0", VA = "0x1845D02B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class PGAGLPKPCEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public NJHNOKIINKM operation;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PGAGLPKPCEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x45D7E50", Offset = "0x45D7250", VA = "0x1845D7E50")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct GGBJGBGBNKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public NJHNOKIINKM operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public PFKKAOHJEIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private global::NEKDBCPDAGF<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x45D2310", Offset = "0x45D1710", VA = "0x1845D2310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class HGMACMPLCOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public PLBGOAPJHAI request;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public HGMACMPLCOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x45D3570", Offset = "0x45D2970", VA = "0x1845D3570")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class EONCOGGCANJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public PLBGOAPJHAI request;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public EONCOGGCANJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x45CFD50", Offset = "0x45CF150", VA = "0x1845CFD50")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private JMNCFHIJLAL IMJGFHGLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private HOKGHPAIJPE DKMAEGIFCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private MCMKCPIGMEJ HOCJOFLIKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private ELCJHBCIGIA KNBFKCAAJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private OCLKGMDKHAF LHLIGPNBLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private TaskCompletionSource<LBJBELAPCEL> AKPHJOPLGDO;

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x3A87900", Offset = "0x3A86D00", VA = "0x183A87900", Slot = "7")]
	public void BNACPANAOEJ(JMNCFHIJLAL IMJGFHGLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x3A88C90", Offset = "0x3A88090", VA = "0x183A88C90", Slot = "6")]
	[AsyncStateMachine(typeof(ADDOBHKFAKB))]
	public Task<LBJBELAPCEL> MMDKHNOFIFL(CancellationToken POBPHDLEHCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x3A88070", Offset = "0x3A87470", VA = "0x183A88070", Slot = "4")]
	public void JBEGGIBCIAC(PLBGOAPJHAI DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x3A884B0", Offset = "0x3A878B0", VA = "0x183A884B0", Slot = "5")]
	public void JELPJMMFNKD(PLBGOAPJHAI NKIBAIBHINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x3A877D0", Offset = "0x3A86BD0", VA = "0x183A877D0")]
	[AsyncStateMachine(typeof(ODCPNMPFFDN))]
	private Task AKLMOAPAOKO(PLBGOAPJHAI EFADACBHMKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x3A87E10", Offset = "0x3A87210", VA = "0x183A87E10")]
	[AsyncStateMachine(typeof(JKJJMEGDJAO))]
	private Task ICPGFFNGNHO(PLBGOAPJHAI PDCKPMCGFPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x3A88B40", Offset = "0x3A87F40", VA = "0x183A88B40")]
	[AsyncStateMachine(typeof(FEOAODGPIFL))]
	private Task<NJHNOKIINKM> MIGJGAMGFGK(PLBGOAPJHAI EFADACBHMKC, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x3A88DD0", Offset = "0x3A881D0", VA = "0x183A88DD0")]
	private FHFCMNCJGAI POBHKIEDOBJ(PLBGOAPJHAI MOKAOCBBHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x3A87F40", Offset = "0x3A87340", VA = "0x183A87F40")]
	[AsyncStateMachine(typeof(GGBJGBGBNKL))]
	private Task IMBOPNDPIAI(NJHNOKIINKM GMFDMCMDPFN, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x3A888C0", Offset = "0x3A87CC0", VA = "0x183A888C0")]
	private NJHNOKIINKM LNFLOHIBDCO(PLBGOAPJHAI EFADACBHMKC, FHFCMNCJGAI BMPAMAENPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x327FBC0", Offset = "0x327EFC0", VA = "0x18327FBC0")]
	private T CDFLEBLMJPJ<T>(T JFBPNBNBHOE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x3A879E0", Offset = "0x3A86DE0", VA = "0x183A879E0")]
	private NJHNOKIINKM CCKAAOCGMPD(PLBGOAPJHAI EFADACBHMKC, FHFCMNCJGAI BMPAMAENPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public PFKKAOHJEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x3A87DC0", Offset = "0x3A871C0", VA = "0x183A87DC0")]
	[CompilerGenerated]
	private void EFCPKDODIED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[UnityEngine.Scripting.Preserve]
internal sealed class OKCNNNELMKI : MCMKCPIGMEJ, PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class LPMKGDAMCHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public LPMKGDAMCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x45D5B20", Offset = "0x45D4F20", VA = "0x1845D5B20")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class KNCKLOFFNCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public KNCKLOFFNCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x45D58D0", Offset = "0x45D4CD0", VA = "0x1845D58D0")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private OCLKGMDKHAF LHLIGPNBLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private PPJPEAOCAOG EJKCHKLJKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private JHOIAGANLCL BHHILJFEOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private COONKIKCBOP HGCLFAABBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private AEBHPDBGDEM EHNJKIFHOKM;

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x3A82DE0", Offset = "0x3A821E0", VA = "0x183A82DE0", Slot = "6")]
	public void BNACPANAOEJ(JMNCFHIJLAL IMJGFHGLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x3A837A0", Offset = "0x3A82BA0", VA = "0x183A837A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x3A842A0", Offset = "0x3A836A0", VA = "0x183A842A0", Slot = "4")]
	public HJHOLDMOADO LLEEFHEMKHG(PLBGOAPJHAI KHECEKIAEMI)
	{
		return default(HJHOLDMOADO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x3A83210", Offset = "0x3A82610", VA = "0x183A83210", Slot = "5")]
	public void DIDNPJJGAHC(Guid OMEAOMOIGDD, Task IHCDPPNLEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x3A841D0", Offset = "0x3A835D0", VA = "0x183A841D0")]
	private void HPLJLNICKKC(byte BCKOGAKEPFK, int LMFAFKHHIIJ, object PPHKELLPHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x3A83840", Offset = "0x3A82C40", VA = "0x183A83840")]
	private void EJBGOODCMIG(KLJENAINLCK FFEKEOCBAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A84AB0", Offset = "0x3A83EB0", VA = "0x183A84AB0")]
	private void PPOELEJJLBD(KLJENAINLCK FFEKEOCBAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x3A82F50", Offset = "0x3A82350", VA = "0x183A82F50")]
	private void DHNBKKFIIMP(KLJENAINLCK FFEKEOCBAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x3A847A0", Offset = "0x3A83BA0", VA = "0x183A847A0")]
	private BCGEGHGDJPI OOKFIDAPNII(PLBGOAPJHAI MOKAOCBBHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x3A828E0", Offset = "0x3A81CE0", VA = "0x183A828E0")]
	private void BCIMMIMFKKC(PLBGOAPJHAI PDCKPMCGFPJ, BCGEGHGDJPI GLKJMCNNMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x3A83F80", Offset = "0x3A83380", VA = "0x183A83F80")]
	private bool FFJAMDAJEFK(PLBGOAPJHAI PDCKPMCGFPJ, BCGEGHGDJPI GLKJMCNNMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x3A82B40", Offset = "0x3A81F40", VA = "0x183A82B40")]
	private bool BKIKDIHJMIO(PLBGOAPJHAI NONNDFDNKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x3A83490", Offset = "0x3A82890", VA = "0x183A83490")]
	private bool DPINFCCCCJN(byte BCKOGAKEPFK, ExitGames.Client.Photon.Hashtable FFEKEOCBAFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public OKCNNNELMKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[UnityEngine.Scripting.Preserve]
internal sealed class DBPGPEGJHLF : IPFNOIGAFBL, PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class AKDKJJMEIGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public LBJBELAPCEL operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public DBPGPEGJHLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public PLBGOAPJHAI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public AKDKJJMEIGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x3A70C80", Offset = "0x3A70080", VA = "0x183A70C80")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x3A70CF0", Offset = "0x3A700F0", VA = "0x183A70CF0")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct EOLCABGIFPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public AsyncTaskMethodBuilder<BCGEGHGDJPI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public DBPGPEGJHLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public PLBGOAPJHAI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private TaskAwaiter<BCGEGHGDJPI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x3A72E70", Offset = "0x3A72270", VA = "0x183A72E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x3A73400", Offset = "0x3A72800", VA = "0x183A73400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class ADFFCBADKGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public LBJBELAPCEL operationType;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ADFFCBADKGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x3A70710", Offset = "0x3A6FB10", VA = "0x183A70710")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class NIDJEAHHBJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public PLBGOAPJHAI request;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public NIDJEAHHBJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x3A7FD90", Offset = "0x3A7F190", VA = "0x183A7FD90")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x3A7FE00", Offset = "0x3A7F200", VA = "0x183A7FE00")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x3A7FE70", Offset = "0x3A7F270", VA = "0x183A7FE70")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct JEFGGLGEPCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public AsyncTaskMethodBuilder<BCGEGHGDJPI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public PLBGOAPJHAI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public DBPGPEGJHLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private NIDJEAHHBJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private HJHOLDMOADO <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private BCGEGHGDJPI <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private TaskAwaiter<(BCGEGHGDJPI validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x3A78BF0", Offset = "0x3A77FF0", VA = "0x183A78BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x3A792F0", Offset = "0x3A786F0", VA = "0x183A792F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private OCLKGMDKHAF LHLIGPNBLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private PPJPEAOCAOG EJKCHKLJKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private MCMKCPIGMEJ HOCJOFLIKOJ;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x311CA50", Offset = "0x311BE50", VA = "0x18311CA50", Slot = "5")]
	public void BNACPANAOEJ(JMNCFHIJLAL IMJGFHGLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x311CD80", Offset = "0x311C180", VA = "0x18311CD80", Slot = "4")]
	[AsyncStateMachine(typeof(EOLCABGIFPC))]
	private Task<BCGEGHGDJPI> FFHIBFBMPBH(PLBGOAPJHAI MOKAOCBBHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x311CB00", Offset = "0x311BF00", VA = "0x18311CB00")]
	private bool DMEPILOLPDC(LBJBELAPCEL HGNGEDBMHCK, out BCGEGHGDJPI APCBFLNDMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x311CEC0", Offset = "0x311C2C0", VA = "0x18311CEC0")]
	[AsyncStateMachine(typeof(JEFGGLGEPCN))]
	private Task<BCGEGHGDJPI> KNANFBPNGBM(PLBGOAPJHAI EFADACBHMKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public DBPGPEGJHLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class JPHAKMNJLEE : EBAJLFIGJKG, PCBEFAPPLHA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct DANFEODKBBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<GKIAAKPIFKA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public IDJHFGEEFAO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public JPHAKMNJLEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private TaskAwaiter<NJHHCJFILAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x401D010", Offset = "0x401C410", VA = "0x18401D010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x401D1F0", Offset = "0x401C5F0", VA = "0x18401D1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class PGMFFIBHHMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PGMFFIBHHMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x402C530", Offset = "0x402B930", VA = "0x18402C530")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct NFFHJKPGNPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<NJHHCJFILAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public JPHAKMNJLEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public IDJHFGEEFAO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private PGMFFIBHHMA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter<CDAODPLIHFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x402ABB0", Offset = "0x4029FB0", VA = "0x18402ABB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x402B000", Offset = "0x402A400", VA = "0x18402B000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class ILNMBCOILAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ILNMBCOILAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x18895B0", Offset = "0x18889B0", VA = "0x1818895B0")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(COOBAAMIODE sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private HKLHFCGBNEN FGFPMOHFMOM;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly (AKFPGEDHNIP superRoomData, string unityAssetId, AKFPGEDHNIP subRoomData) FHAOGFLCHCG;

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x312D3F0", Offset = "0x312C7F0", VA = "0x18312D3F0", Slot = "5")]
	public void BNACPANAOEJ(JMNCFHIJLAL IMJGFHGLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x312D9A0", Offset = "0x312CDA0", VA = "0x18312D9A0", Slot = "4")]
	[AsyncStateMachine(typeof(DANFEODKBBA))]
	public Task<GKIAAKPIFKA> EPGHFDIAJGD(IBIDBCAPHMG KIBJDNPFMAF, IDJHFGEEFAO NPLPKFFKPLE, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x312DB20", Offset = "0x312CF20", VA = "0x18312DB20")]
	[AsyncStateMachine(typeof(NFFHJKPGNPA))]
	private Task<NJHHCJFILAP> HPBDCCJNNHP(IDJHFGEEFAO NPLPKFFKPLE, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x312D460", Offset = "0x312C860", VA = "0x18312D460")]
	private GKIAAKPIFKA DDKONFIMBOD(IDJHFGEEFAO NPLPKFFKPLE, NJHHCJFILAP DCEDBHGIJKC, long KFGNOJDEOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x312D5F0", Offset = "0x312C9F0", VA = "0x18312D5F0")]
	private (AKFPGEDHNIP, string, AKFPGEDHNIP) EIEJDAICHEA(IDJHFGEEFAO NPLPKFFKPLE, NJHHCJFILAP DCEDBHGIJKC, long KFGNOJDEOOA)
	{
		return default((AKFPGEDHNIP, string, AKFPGEDHNIP));
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public JPHAKMNJLEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[UnityEngine.Scripting.Preserve]
internal sealed class EBEFEIGNMBL : ELCJHBCIGIA, PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class JEPDDLIJAFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public PLBGOAPJHAI request;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public JEPDDLIJAFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x3A79340", Offset = "0x3A78740", VA = "0x183A79340")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct ACIEFAJEJIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<PLBGOAPJHAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public PLBGOAPJHAI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public EBEFEIGNMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public FHFCMNCJGAI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private TaskAwaiter<PLBGOAPJHAI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x3A70240", Offset = "0x3A6F640", VA = "0x183A70240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x3A706C0", Offset = "0x3A6FAC0", VA = "0x183A706C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct GMPKPNMNJMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public AsyncTaskMethodBuilder<PLBGOAPJHAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public EBEFEIGNMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public FHFCMNCJGAI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<JJGGGKNMKHE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x3A74E10", Offset = "0x3A74210", VA = "0x183A74E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x3A753F0", Offset = "0x3A747F0", VA = "0x183A753F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class HLEAPKMMKBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public PLBGOAPJHAI request;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public HLEAPKMMKBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x3A76250", Offset = "0x3A75650", VA = "0x183A76250")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct HLJHHCIFFJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public AsyncTaskMethodBuilder<PLBGOAPJHAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public PLBGOAPJHAI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public EBEFEIGNMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public FHFCMNCJGAI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private IFKMEDBFPKJ <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private FAIMJAOBDNC <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<JJGGGKNMKHE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x3A762B0", Offset = "0x3A756B0", VA = "0x183A762B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x3A76D40", Offset = "0x3A76140", VA = "0x183A76D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private OCLKGMDKHAF LHLIGPNBLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private LMBFFAEKNKL CIKAGCFBOHB;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private EMJFBIFAMEN BENGGBGOJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x311F180", Offset = "0x311E580", VA = "0x18311F180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x311ECA0", Offset = "0x311E0A0", VA = "0x18311ECA0", Slot = "8")]
	public void BNACPANAOEJ(JMNCFHIJLAL IMJGFHGLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x311EE90", Offset = "0x311E290", VA = "0x18311EE90", Slot = "4")]
	[AsyncStateMachine(typeof(ACIEFAJEJIG))]
	public Task<PLBGOAPJHAI> GDKKCLBPMDG(PLBGOAPJHAI EFADACBHMKC, FHFCMNCJGAI BMPAMAENPDM, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x311ED30", Offset = "0x311E130", VA = "0x18311ED30", Slot = "5")]
	[AsyncStateMachine(typeof(GMPKPNMNJMK))]
	public Task<PLBGOAPJHAI> EDPHKIIMHFC(CancellationToken OLHHOODBFDC, FHFCMNCJGAI BMPAMAENPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x311F230", Offset = "0x311E630", VA = "0x18311F230", Slot = "6")]
	public MFMLJGKBCFN KOIAOINOLKF(NJHNOKIINKM MHMFKNEPJPG, IBIDBCAPHMG KIBJDNPFMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x311F4D0", Offset = "0x311E8D0", VA = "0x18311F4D0", Slot = "7")]
	public MFMLJGKBCFN PIPEJONHFGC(NJHNOKIINKM MHMFKNEPJPG, IBIDBCAPHMG KIBJDNPFMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x311F000", Offset = "0x311E400", VA = "0x18311F000")]
	[AsyncStateMachine(typeof(HLJHHCIFFJB))]
	private Task<PLBGOAPJHAI> INPMOPOJCCA(PLBGOAPJHAI EFADACBHMKC, FHFCMNCJGAI BMPAMAENPDM, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x311F4C0", Offset = "0x311E8C0", VA = "0x18311F4C0")]
	private static byte[] MGCMPHDBLDI(PLBGOAPJHAI DENPJAMCNLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x311EAC0", Offset = "0x311DEC0", VA = "0x18311EAC0")]
	private static string BLFEHJANJKM(byte[] CDKILDODEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EBEFEIGNMBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[UnityEngine.Scripting.Preserve]
internal sealed class ACKEHPICIAC : PPJPEAOCAOG, PCBEFAPPLHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private CCCHDJOODDG CKLMGHGJPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private OCLKGMDKHAF LHLIGPNBLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private HOKGHPAIJPE DKMAEGIFCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private DNDCBPDDGOE NBFPPKPCELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private HKLHFCGBNEN FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private IOCLFLHAOLK PLPEFHCJLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private IOHIBNHMCEK MDOMDJJMJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private FMBGGBENKME HPHLIJIBJEH;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private IDGMGLIGADE KHOLDMMJLMF
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x3115E00", Offset = "0x3115200", VA = "0x183115E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private static BCGEGHGDJPI HMJAIKDHEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x3115DA0", Offset = "0x31151A0", VA = "0x183115DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x3115500", Offset = "0x3114900", VA = "0x183115500", Slot = "7")]
	public void BNACPANAOEJ(JMNCFHIJLAL IMJGFHGLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x3115C10", Offset = "0x3115010", VA = "0x183115C10", Slot = "4")]
	public BCGEGHGDJPI KKOCHPDKDIO(KPNOOPGJEKD FCAPIJNHCMP, LBJBELAPCEL ENHFFKPEKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x3115930", Offset = "0x3114D30", VA = "0x183115930", Slot = "5")]
	public BCGEGHGDJPI KKMFOJFMEJI(KPNOOPGJEKD NBOLIIBAEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x31156C0", Offset = "0x3114AC0", VA = "0x1831156C0", Slot = "6")]
	public BCGEGHGDJPI GPKOFLMIBDL(KPNOOPGJEKD NBOLIIBAEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x3115660", Offset = "0x3114A60", VA = "0x183115660")]
	private static BCGEGHGDJPI CEGLKFMHDKO(KGOBOGAGHPL EBBINHBEDJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public ACKEHPICIAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class NFPKDMICGLF : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x3A7F5A0", Offset = "0x3A7E9A0", VA = "0x183A7F5A0")]
	public NFPKDMICGLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x14D9040", Offset = "0x14D8440", VA = "0x1814D9040")]
	public NFPKDMICGLF(string DENPJAMCNLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class AGKBKHJNEBD : ECICOCBCFBI, PCBEFAPPLHA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct CHPDMGBNBBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public AsyncTaskMethodBuilder<BCGEGHGDJPI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public AGKBKHJNEBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public HJHFIAECAFN autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private global::NEKDBCPDAGF<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private IBIDBCAPHMG <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private ADHEFAOCNHL <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private IBIDBCAPHMG <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<BCGEGHGDJPI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x3A717D0", Offset = "0x3A70BD0", VA = "0x183A717D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x3A71F30", Offset = "0x3A71330", VA = "0x183A71F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct NFPMLBNKNHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public AGKBKHJNEBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x3A7F5E0", Offset = "0x3A7E9E0", VA = "0x183A7F5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct OLKFJCMFLAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public AGKBKHJNEBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x3A850E0", Offset = "0x3A844E0", VA = "0x183A850E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct HHCLGIENHMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public AGKBKHJNEBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x3A75B80", Offset = "0x3A74F80", VA = "0x183A75B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct IIHGFLCHKOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AGKBKHJNEBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x3A776C0", Offset = "0x3A76AC0", VA = "0x183A776C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct JIABCGBGDNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public AGKBKHJNEBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public ALDHOJLECOH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private global::NEKDBCPDAGF<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x3A793A0", Offset = "0x3A787A0", VA = "0x183A793A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private static readonly TimeSpan LIEGPHNJEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private OCLKGMDKHAF LHLIGPNBLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private JMNCFHIJLAL IMJGFHGLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private HKLHFCGBNEN FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private ELCJHBCIGIA KNBFKCAAJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private HOKGHPAIJPE DKMAEGIFCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private IOHIBNHMCEK MDOMDJJMJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private CancellationTokenSource MFBDJICNADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private Task PMKANKLLDPA;

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3116EB0", Offset = "0x31162B0", VA = "0x183116EB0", Slot = "6")]
	public void BNACPANAOEJ(JMNCFHIJLAL IMJGFHGLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x1B31730", Offset = "0x1B30B30", VA = "0x181B31730", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3117690", Offset = "0x3116A90", VA = "0x183117690", Slot = "4")]
	[AsyncStateMachine(typeof(CHPDMGBNBBC))]
	public Task<BCGEGHGDJPI> NBHKKLIIEHJ(HJHFIAECAFN EKDFAKLJBGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x3116D90", Offset = "0x3116190", VA = "0x183116D90", Slot = "5")]
	[AsyncStateMachine(typeof(NFPMLBNKNHO))]
	public Task ALFDOPDICJO([Optional] CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x1B31730", Offset = "0x1B30B30", VA = "0x181B31730")]
	public void NGDCMFGIFJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3117070", Offset = "0x3116470", VA = "0x183117070")]
	private ADHEFAOCNHL CMHNNIGOJLM(HJHFIAECAFN EKDFAKLJBGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x3117900", Offset = "0x3116D00", VA = "0x183117900")]
	[AsyncStateMachine(typeof(OLKFJCMFLAM))]
	private Task PNGFNLFIKFB(HBMEPODFBHF IGJFJCHKKMF, CancellationToken FFBLKMEPPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x3117460", Offset = "0x3116860", VA = "0x183117460")]
	[AsyncStateMachine(typeof(HHCLGIENHMO))]
	private Task HOLPOBPFPFN([Optional] CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x31177D0", Offset = "0x3116BD0", VA = "0x1831177D0")]
	[AsyncStateMachine(typeof(IIHGFLCHKOG))]
	private Task NIHDKGFCIJD(TimeSpan KPGIHDAHHDK, CancellationToken FFBLKMEPPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x3117A30", Offset = "0x3116E30", VA = "0x183117A30")]
	private Task PPGHFCPOCHM(ALDHOJLECOH KJHAOKNAKMN, CancellationToken FFBLKMEPPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3117330", Offset = "0x3116730", VA = "0x183117330")]
	[AsyncStateMachine(typeof(JIABCGBGDNL))]
	private Task HCCNGBENGON(ALDHOJLECOH KJHAOKNAKMN, CancellationToken FFBLKMEPPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x3117580", Offset = "0x3116980", VA = "0x183117580")]
	private bool KLEEOIGKBMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public AGKBKHJNEBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[UnityEngine.Scripting.Preserve]
internal class OHCBMHKBNDF : DNDCBPDDGOE, PCBEFAPPLHA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct NEFFNJIKBDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public OHCBMHKBNDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private global::NEKDBCPDAGF<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x45D6460", Offset = "0x45D5860", VA = "0x1845D6460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private HKINNJHLDGA DIMCABPKIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private JMNCFHIJLAL IMJGFHGLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private PPJPEAOCAOG EJKCHKLJKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private ELCJHBCIGIA KNBFKCAAJGP;

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x3A81730", Offset = "0x3A80B30", VA = "0x183A81730", Slot = "6")]
	public void BNACPANAOEJ(JMNCFHIJLAL IMJGFHGLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x3A81950", Offset = "0x3A80D50", VA = "0x183A81950", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x3A81BB0", Offset = "0x3A80FB0", VA = "0x183A81BB0", Slot = "5")]
	[AsyncStateMachine(typeof(NEFFNJIKBDH))]
	public Task MIHFEJNMPGD(string BENGLHDIHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x3A819A0", Offset = "0x3A80DA0", VA = "0x183A819A0", Slot = "4")]
	public BCGEGHGDJPI KLEEOIGKBMJ(KPNOOPGJEKD FCAPIJNHCMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x3A81A60", Offset = "0x3A80E60", VA = "0x183A81A60")]
	private NBCHNOCJHBB LPPICPJEGCM(string BENGLHDIHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public OHCBMHKBNDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class KGLLJPDKLCH
{
	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x312E3A0", Offset = "0x312D7A0", VA = "0x18312E3A0")]
	public static void PDDIKDGMEFB(LECENBDGBAK LNELKNMCOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x312E2C0", Offset = "0x312D6C0", VA = "0x18312E2C0")]
	internal static void NOGBOKDNONK(LECENBDGBAK LNELKNMCOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x312DD90", Offset = "0x312D190", VA = "0x18312DD90")]
	internal static void EFDGGAACMEJ(LECENBDGBAK LNELKNMCOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x312DE70", Offset = "0x312D270", VA = "0x18312DE70")]
	internal static void JFNPCNHAGFO(LECENBDGBAK LNELKNMCOEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal class FEFGKDCFEPF : global::OKMGAMPPJLB<PLBGOAPJHAI>
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class OMJJLDMANBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public PLBGOAPJHAI message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public OMJJLDMANBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x402C180", Offset = "0x402B580", VA = "0x18402C180")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly FEFGKDCFEPF HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private const string KDPCIFPHNKN = "pl";

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x3121550", Offset = "0x3120950", VA = "0x183121550")]
	public ExitGames.Client.Photon.Hashtable LMGAKHPBOLH(PLBGOAPJHAI DENPJAMCNLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x3121410", Offset = "0x3120810", VA = "0x183121410", Slot = "5")]
	protected override void DEMBBMDADIN(PLBGOAPJHAI DENPJAMCNLD, IDictionary<object, object> ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x31215D0", Offset = "0x31209D0", VA = "0x1831215D0", Slot = "6")]
	public override PLBGOAPJHAI LPJEJNEGJFP(IDictionary<object, object> ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x31217D0", Offset = "0x3120BD0", VA = "0x1831217D0")]
	private static void NDPGLCAACEE(string AHPJJBDHKJG, PLBGOAPJHAI DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x31219E0", Offset = "0x3120DE0", VA = "0x1831219E0")]
	public FEFGKDCFEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x31210C0", Offset = "0x31204C0", VA = "0x1831210C0")]
	[CompilerGenerated]
	internal static string ADANMEDJCFI(GKIAAKPIFKA KBGLHNCEHFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class HJIGHIEKNOB
{
	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public static BCGEGHGDJPI HMJAIKDHEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x3115DA0", Offset = "0x31151A0", VA = "0x183115DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x31280A0", Offset = "0x31274A0", VA = "0x1831280A0")]
	public static bool FMELAJLBHND(this BCGEGHGDJPI GLKJMCNNMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3115660", Offset = "0x3114A60", VA = "0x183115660")]
	public static BCGEGHGDJPI CEGLKFMHDKO(KGOBOGAGHPL FDKDECGDDJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x31280C0", Offset = "0x31274C0", VA = "0x1831280C0")]
	public static BCGEGHGDJPI MGHOCLDLIBK(params BCGEGHGDJPI[] LNKHLPFFPEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3127EA0", Offset = "0x31272A0", VA = "0x183127EA0")]
	public static BCGEGHGDJPI FJBJEEKJPAM(IEnumerable<BCGEGHGDJPI> LNKHLPFFPEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x31280D0", Offset = "0x31274D0", VA = "0x1831280D0")]
	public static string OPLCCCKKAPF(this BCGEGHGDJPI APCBFLNDMMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public abstract class PGKHMIDIOIF : OKNOKGNGLLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public delegate BCGEGHGDJPI NANNHKNAHHB([NotNull] KPNOOPGJEKD JGGGPAKOBFF);

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class BPMKOEJJDDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public KPNOOPGJEKD photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public BPMKOEJJDDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x45CDB80", Offset = "0x45CCF80", VA = "0x1845CDB80")]
		internal BCGEGHGDJPI <Validate>b__0(NANNHKNAHHB v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	protected readonly HashSet<NANNHKNAHHB> GCLDLONNEAJ;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x3A88EA0", Offset = "0x3A882A0", VA = "0x183A88EA0", Slot = "4")]
	public void GGKKBABDGII(NANNHKNAHHB LEKIHHOGFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x3A89120", Offset = "0x3A88520", VA = "0x183A89120", Slot = "5")]
	public void JMIMGECCIPP(NANNHKNAHHB LEKIHHOGFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3A88E50", Offset = "0x3A88250", VA = "0x183A88E50", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3A88F00", Offset = "0x3A88300", VA = "0x183A88F00")]
	protected BCGEGHGDJPI JEEJLMBNCEM(KPNOOPGJEKD NBOLIIBAEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3A89180", Offset = "0x3A88580", VA = "0x183A89180")]
	protected PGKHMIDIOIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public class AJMDFEANFEM : PGKHMIDIOIF, CCCHDJOODDG, OKNOKGNGLLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class EIGNPDLKMLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public BCGEGHGDJPI result;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public EIGNPDLKMLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x3A72D60", Offset = "0x3A72160", VA = "0x183A72D60")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x31184A0", Offset = "0x31178A0", VA = "0x1831184A0")]
	[UnityEngine.Scripting.Preserve]
	public AJMDFEANFEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3118310", Offset = "0x3117710", VA = "0x183118310", Slot = "8")]
	public BCGEGHGDJPI AEGJFHAEKNK(KPNOOPGJEKD NBOLIIBAEOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class IPMICMEPKBJ : PGKHMIDIOIF, HKINNJHLDGA, OKNOKGNGLLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class EJDELCJGCBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public BCGEGHGDJPI result;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public EJDELCJGCBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x401F220", Offset = "0x401E620", VA = "0x18401F220")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x31184A0", Offset = "0x31178A0", VA = "0x1831184A0")]
	[UnityEngine.Scripting.Preserve]
	public IPMICMEPKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x312C7F0", Offset = "0x312BBF0", VA = "0x18312C7F0", Slot = "8")]
	public BCGEGHGDJPI KLEEOIGKBMJ(KPNOOPGJEKD OCNINCAELAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public enum OJGFDBKPPLK
{
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class DIOGALGGCHD
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class OCHAKMDJNGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public global::NEKDBCPDAGF<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public OCHAKMDJNGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x3A81130", Offset = "0x3A80530", VA = "0x183A81130")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public const string BAODLKIPCJI = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public const string DBKLNKMFGBH = "END: ";

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x311DC00", Offset = "0x311D000", VA = "0x18311DC00")]
	public static global::NEKDBCPDAGF<string> LNBBEKCDOJG([Optional] string HHHMCDPDAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x311DCD0", Offset = "0x311D0D0", VA = "0x18311DCD0")]
	private static void NHHJCCAJAOL(string EBOEHIFNNLM, FJAAKIDABOG HHEDADBLDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x311DA40", Offset = "0x311CE40", VA = "0x18311DA40")]
	private static void DDBDKAFCFLM(string EBOEHIFNNLM, FJAAKIDABOG HHEDADBLDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x311DDD0", Offset = "0x311D1D0", VA = "0x18311DDD0")]
	public static void OMMPBCMIEMK(global::NEKDBCPDAGF<string> HHEDADBLDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x311DB40", Offset = "0x311CF40", VA = "0x18311DB40")]
	public static string KJBEECCFIDO(PLBGOAPJHAI MOKAOCBBHED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class DEGAOOONNJH
{
	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x311D440", Offset = "0x311C840", VA = "0x18311D440")]
	public static void OJNFGIFLALO(this OCLKGMDKHAF LHLIGPNBLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x311D320", Offset = "0x311C720", VA = "0x18311D320")]
	public static void IBEBFIFFLBN(this OCLKGMDKHAF LHLIGPNBLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x311D330", Offset = "0x311C730", VA = "0x18311D330")]
	private static void LELPKCIPIPN(this OCLKGMDKHAF LHLIGPNBLOF, bool IOEFALMGHEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class BLHPMOMGCMJ : OEOOGEIKAHO, NNFPOGJEMPN, KNGFJJIGIJH, CIJLMIAADOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private readonly NNFPOGJEMPN LAJNLKPPCND;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public KPNOOPGJEKD JIHMNJJIKIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x311ADF0", Offset = "0x311A1F0", VA = "0x18311ADF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public int PKPHPAPICDK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x311B250", Offset = "0x311A650", VA = "0x18311B250", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int NGBBEIBDAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x311AEE0", Offset = "0x311A2E0", VA = "0x18311AEE0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool GLOGKDDOBJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F9850", Offset = "0x6F8C50", VA = "0x1806F9850", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public int KHLBOPKPEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7DF3D0", Offset = "0x7DE7D0", VA = "0x1807DF3D0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event HGHANPGHOBI.PEHNHLFMNEA COJHOHHPGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event GIEHLCAMNMC CNCABBKINCM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x311AF30", Offset = "0x311A330", VA = "0x18311AF30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x311B030", Offset = "0x311A430", VA = "0x18311B030", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event Action<bool> ABBEAEGFJCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<KPNOOPGJEKD> JKALGAFEDGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action LNHPNMEJANJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x311AE40", Offset = "0x311A240", VA = "0x18311AE40", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x311B0D0", Offset = "0x311A4D0", VA = "0x18311B0D0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7BB810", Offset = "0x7BAC10", VA = "0x1807BB810")]
	public BLHPMOMGCMJ(NNFPOGJEMPN LAJNLKPPCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x311B2A0", Offset = "0x311A6A0", VA = "0x18311B2A0", Slot = "8")]
	public bool OIAFPGOOBOC(byte BCKOGAKEPFK, ExitGames.Client.Photon.Hashtable IOMLMBOBGBC, MMJHLIMEJFI JEOEGAMMAKB, SendOptions BLMEKIABMDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x311B350", Offset = "0x311A750", VA = "0x18311B350", Slot = "29")]
	public KPNOOPGJEKD OKDAAGNDILB(int HEJJIPBKGFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x311B170", Offset = "0x311A570", VA = "0x18311B170", Slot = "16")]
	public KPNOOPGJEKD NHOMJGCLLDA(int ELEHPEANOJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "19")]
	public void CLMBDPGJDED(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "20")]
	public void APNEHJPINPL(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "21")]
	public void NNCCJIPNKOP(object AJDBKDIMOHA, bool KHOBADBEHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x311AFD0", Offset = "0x311A3D0", VA = "0x18311AFD0", Slot = "22")]
	public IDisposable KIGGCKDPADB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "23")]
	private bool KJJKKKPHPPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "24")]
	public void BIOPNNPAKHN(StringBuilder HFPDOHGJOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x311ADD0", Offset = "0x311A1D0", VA = "0x18311ADD0", Slot = "25")]
	public bool ALIHNKHGDCI(bool BHEMHCJMMCP, out string GNLLAOFLEDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	public void GLPILELFOOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x1C9D7C0", Offset = "0x1C9CBC0", VA = "0x181C9D7C0", Slot = "28")]
	public void OCLBAFBMNPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal struct KLJENAINLCK
{
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public const string ANBNEBCOLAL = "v_result";

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public const string FDPMNPOIKEO = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private readonly IDictionary<object, object> FFEKEOCBAFH;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool HGGGGBFNODB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x9C88D0", Offset = "0x9C7CD0", VA = "0x1809C88D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F00", Offset = "0x6E1300", VA = "0x1806E1F00")]
	public KLJENAINLCK(IDictionary<object, object> FFEKEOCBAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x312E780", Offset = "0x312DB80", VA = "0x18312E780")]
	public bool CEMNEHPLGJP(out PLBGOAPJHAI DENPJAMCNLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x312E9A0", Offset = "0x312DDA0", VA = "0x18312E9A0")]
	public Guid NBINJIKHDIC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x312E840", Offset = "0x312DC40", VA = "0x18312E840")]
	public BCGEGHGDJPI IFGDHDIDBDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x312E690", Offset = "0x312DA90", VA = "0x18312E690")]
	public static ExitGames.Client.Photon.Hashtable BFPHDDBHNEE(PLBGOAPJHAI DENPJAMCNLD, BCGEGHGDJPI GLKJMCNNMBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal static class LPHGJFJKEHJ
{
	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x312FB40", Offset = "0x312EF40", VA = "0x18312FB40")]
	public static string ACPDHMIMCJC(this IDJHFGEEFAO GBJGFACLOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x312FD90", Offset = "0x312F190", VA = "0x18312FD90")]
	public static bool AFMMPPKINKC(this IDJHFGEEFAO GBJGFACLOGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal struct OLILHDPEHAK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct EBJLKHLMKLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public OLILHDPEHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x45CFBB0", Offset = "0x45CEFB0", VA = "0x1845CFBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private readonly CancellationTokenSource BMLBNCLOPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private Task DLDNMMGIFIK;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool HGGGGBFNODB
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x3A84F10", Offset = "0x3A84310", VA = "0x183A84F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	internal Task COAMFKHHHKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x3A84F40", Offset = "0x3A84340", VA = "0x183A84F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x3A84FC0", Offset = "0x3A843C0", VA = "0x183A84FC0")]
	public OLILHDPEHAK(CancellationToken OLHHOODBFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x3A84DE0", Offset = "0x3A841E0", VA = "0x183A84DE0")]
	[AsyncStateMachine(typeof(EBJLKHLMKLD))]
	public Task IAOIFAKGFNF(Func<CancellationToken, List<Task>> DGOOKCLCHOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x3A84D90", Offset = "0x3A84190", VA = "0x183A84D90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public readonly struct MGNMJIIHJCM<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct CIIMFEIDDII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public AsyncTaskMethodBuilder<global::OHFECDBHLHC<global::KKPNMOBPAON<TData>, IOILPEPIEGB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public IBIDBCAPHMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public global::MGNMJIIHJCM<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private IBIDBCAPHMG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private TaskAwaiter<global::OHFECDBHLHC<byte[], IOILPEPIEGB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x337B250", Offset = "0x337A650", VA = "0x18337B250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x2E7A3F0", Offset = "0x2E797F0", VA = "0x182E7A3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private readonly global::BHGMNFKGCMD<TGetDataArg, TData> FHGAMNFIHGP;

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F00", Offset = "0x6E1300", VA = "0x1806E1F00")]
	internal MGNMJIIHJCM(global::BHGMNFKGCMD<TGetDataArg, TData> IAPGLFJKDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x3A96810", Offset = "0x3A95C10", VA = "0x183A96810")]
	[AsyncStateMachine(typeof(global::MGNMJIIHJCM<, >.CIIMFEIDDII))]
	public Task<global::OHFECDBHLHC<global::KKPNMOBPAON<TData>, IOILPEPIEGB>> OKBCJGEHGGO(TGetDataArg CDKILDODEEL, string MNDCFCCDBCF, IBIDBCAPHMG HHEDADBLDNA, CancellationToken OLHHOODBFDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public static class FACIFOFLDIA
{
	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2717A80", Offset = "0x2716E80", VA = "0x182717A80")]
	public static global::MGNMJIIHJCM<TGetDataArg, TData> GDHAFJANMPF<TGetDataArg, TData>(global::BHGMNFKGCMD<TGetDataArg, TData> IAPGLFJKDEF)
	{
		return default(global::MGNMJIIHJCM<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public class AMMHDIJOABG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private readonly MKBBBKJBKGN KBJLIJJCOII;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private const string HJGOKGKDCGN = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private const string HIIPLIOKILK = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private const string KBEPLEKGOHC = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private const string EKIEIKNKKNN = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private const string NCAOMHNLEIK = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private string EFCPGAABINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private long? BJBNDONLGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private long? LDODAHJDMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private ADBPAACHPEK KEEJHCEOPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private long? DFLAEIHPCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private bool NJHEHLDCELC;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public string BCPHKBDCEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public long MAOFPDOGKMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x3118EB0", Offset = "0x31182B0", VA = "0x183118EB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public long DIJMDECIGNA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x31194A0", Offset = "0x31188A0", VA = "0x1831194A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public ADBPAACHPEK NENJHIDANEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x6D8750", Offset = "0x6D7B50", VA = "0x1806D8750")]
		get
		{
			return default(ADBPAACHPEK);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x3118F10", Offset = "0x3118310", VA = "0x183118F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public long DIAPLOGGIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x3118D60", Offset = "0x3118160", VA = "0x183118D60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x3119500", Offset = "0x3118900", VA = "0x183119500")]
	[UnityEngine.Scripting.Preserve]
	public AMMHDIJOABG([CNHALHMHHIC(null)] MKBBBKJBKGN KBJLIJJCOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x3119000", Offset = "0x3118400", VA = "0x183119000")]
	private void JIPHPJDEFCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x31189B0", Offset = "0x3117DB0", VA = "0x1831189B0")]
	public void AKMJFOPHIFP(long LLDIIOOAFHI, long KFGNOJDEOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x3118DC0", Offset = "0x31181C0", VA = "0x183118DC0")]
	public void FIKLEDIJNBH(string KELAPCIADKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x31191B0", Offset = "0x31185B0", VA = "0x1831191B0")]
	public void OIMMEMIKIBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal class MFMLJGKBCFN : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct KFCOKCFDFPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public AsyncTaskMethodBuilder<PLBGOAPJHAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public PLBGOAPJHAI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public MFMLJGKBCFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private IBIDBCAPHMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private TaskAwaiter<GPABNAHEFBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x4025F20", Offset = "0x4025320", VA = "0x184025F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x4026230", Offset = "0x4025630", VA = "0x184026230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct IDEPOAJBNAA<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private sealed class GHAKLJJCCAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public PLBGOAPJHAI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public GHAKLJJCCAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x4022690", Offset = "0x4021A90", VA = "0x184022690")]
		internal PLBGOAPJHAI <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct GNALDOMHFPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public AsyncTaskMethodBuilder<GPABNAHEFBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public PLBGOAPJHAI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public MFMLJGKBCFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private IFKMEDBFPKJ <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private TaskAwaiter<GPABNAHEFBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x40234D0", Offset = "0x40228D0", VA = "0x1840234D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x4023CB0", Offset = "0x40230B0", VA = "0x184023CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct MIGNBEABDOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public MFMLJGKBCFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x40296A0", Offset = "0x4028AA0", VA = "0x1840296A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class EHPNCJHCAGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public EHPNCJHCAGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x401F0B0", Offset = "0x401E4B0", VA = "0x18401F0B0")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private sealed class GJDIABMGDFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public GJDIABMGDFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x4023470", Offset = "0x4022870", VA = "0x184023470")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private sealed class ECDDBLPOEDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ECDDBLPOEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x401EDC0", Offset = "0x401E1C0", VA = "0x18401EDC0")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class GNNLEANEHPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public GNNLEANEHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x4023D00", Offset = "0x4023100", VA = "0x184023D00")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class EFDEMBKJCLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public MFMLJGKBCFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public EFDEMBKJCLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x401EE30", Offset = "0x401E230", VA = "0x18401EE30")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class KEJCPKLFGJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public MFMLJGKBCFN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public KEJCPKLFGJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x4025C80", Offset = "0x4025080", VA = "0x184025C80")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private static readonly Guid BEJGPBDGGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public readonly NJHNOKIINKM KGKHEDLKDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private readonly EMJFBIFAMEN BHFOPADPDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly KNGFJJIGIJH LHLIGPNBLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private readonly CIJLMIAADOM MKNOHGKAKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private bool MEMDMMNBCHC;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x3133650", Offset = "0x3132A50", VA = "0x183133650")]
	public MFMLJGKBCFN(NJHNOKIINKM GMFDMCMDPFN, EMJFBIFAMEN BHFOPADPDLB, KNGFJJIGIJH LHLIGPNBLOF, CIJLMIAADOM MKNOHGKAKBL, IBIDBCAPHMG KIBJDNPFMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x3131E60", Offset = "0x3131260", VA = "0x183131E60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x3131E60", Offset = "0x3131260", VA = "0x183131E60")]
	public void AKKOFCNPIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x31325B0", Offset = "0x31319B0", VA = "0x1831325B0")]
	public void HACCNNDEKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x3132170", Offset = "0x3131570", VA = "0x183132170")]
	public void EIDPEMEHANH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x3132700", Offset = "0x3131B00", VA = "0x183132700")]
	[AsyncStateMachine(typeof(KFCOKCFDFPH))]
	internal Task<PLBGOAPJHAI> JDDPCMBBNHA(IBIDBCAPHMG KIBJDNPFMAF, PLBGOAPJHAI MOKAOCBBHED, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x311F4C0", Offset = "0x311E8C0", VA = "0x18311F4C0")]
	private static byte[] OLKOMOBGCIA<T>(T DENPJAMCNLD) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x33BB280", Offset = "0x33BA680", VA = "0x1833BB280")]
	private static T JGBHFIPHIPM<T>(MessageParser<T> BMLCLLMCNJF, byte[] DENPJAMCNLD, T FLGDGHMLIAI) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x3132010", Offset = "0x3131410", VA = "0x183132010")]
	[AsyncStateMachine(typeof(GNALDOMHFPC))]
	private Task<GPABNAHEFBE> EIBKKPAICJC(PLBGOAPJHAI MOKAOCBBHED, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x33BAFA0", Offset = "0x33BA3A0", VA = "0x1833BAFA0")]
	[AsyncStateMachine(typeof(MOEEOJNCGCN))]
	internal Task<T> GKLIJNOFPBF<T>(CancellationToken FFBLKMEPPBJ, Func<CancellationToken, Task<T>> GFLFDNPPFDD, int LDDGBPCDNLG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x3132460", Offset = "0x3131860", VA = "0x183132460")]
	[AsyncStateMachine(typeof(MIGNBEABDOP))]
	internal Task GKLIJNOFPBF(CancellationToken FFBLKMEPPBJ, Func<CancellationToken, Task> GFLFDNPPFDD, int LDDGBPCDNLG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x3132CC0", Offset = "0x31320C0", VA = "0x183132CC0")]
	public PLBGOAPJHAI LLLMINGNFPH(IFKMEDBFPKJ DCPEMCDAFLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x3132880", Offset = "0x3131C80", VA = "0x183132880")]
	public MJGKPFMGAPI JONDNKFPMNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x3132D50", Offset = "0x3132150", VA = "0x183132D50")]
	public MJBKFIFINGO MLHJHFLJDFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x3133110", Offset = "0x3132510", VA = "0x183133110")]
	public MECBAEJOJKA OADHBPDOPIM([Optional] MCIFGLAOFBP? PBFKDCHNBGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x31330E0", Offset = "0x31324E0", VA = "0x1831330E0")]
	public void NHKJBMALMMA(Func<Guid, bool> OCOPNGDLHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x3132AE0", Offset = "0x3131EE0", VA = "0x183132AE0")]
	public void LLFGPKNPCED(Func<Guid, bool> ELPKBLJIDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x3133230", Offset = "0x3132630", VA = "0x183133230")]
	public void OCAPCNFMKAA(Func<Guid, bool> OCOPNGDLHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x31333D0", Offset = "0x31327D0", VA = "0x1831333D0")]
	public Guid OFGAGFJGBFE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x3132950", Offset = "0x3131D50", VA = "0x183132950")]
	public void KPLHFMLPANF(Guid DGKELKDLHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x3132310", Offset = "0x3131710", VA = "0x183132310")]
	public void FOLOEIAMEJG(PLBGOAPJHAI IHJLKABLLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x3132F50", Offset = "0x3132350", VA = "0x183132F50")]
	public void NDPGLCAACEE(string HGKAIBNMMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x3132DC0", Offset = "0x31321C0", VA = "0x183132DC0")]
	public void NDPGLCAACEE(Func<string> JPFLHEEKFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x33BABB0", Offset = "0x33B9FB0", VA = "0x1833BABB0")]
	private T CDFLEBLMJPJ<T>(T JFBPNBNBHOE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x31322C0", Offset = "0x31316C0", VA = "0x1831322C0")]
	public void ENGEBFMHLJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x33BAC90", Offset = "0x33BA090", VA = "0x1833BAC90")]
	[CompilerGenerated]
	internal static string DIAJFFFDCIC<T>(byte[] NPNCGJAPKIL, int FCPLMOKHPHM, ref IDEPOAJBNAA<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal sealed class PFFGOPOGGMK : NJHNOKIINKM
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class INAMHAJGEMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public INAMHAJGEMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x45D4660", Offset = "0x45D3A60", VA = "0x1845D4660")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct ODAKOCIBJJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public PFFGOPOGGMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public MFMLJGKBCFN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private MJBKFIFINGO <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x45D6EC0", Offset = "0x45D62C0", VA = "0x1845D6EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class BOFPKKCPGGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public GNFMLPKABNA presence;

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public BOFPKKCPGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x45CDA40", Offset = "0x45CCE40", VA = "0x1845CDA40")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private readonly GKIAAKPIFKA JCCBLHPABCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private readonly IDJHFGEEFAO MBOKGPBFEKI;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private const bool GKMFOELHGJG = false;

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x3A875C0", Offset = "0x3A869C0", VA = "0x183A875C0")]
	public PFFGOPOGGMK(GKIAAKPIFKA JCCBLHPABCB, IDJHFGEEFAO MBOKGPBFEKI, Guid OMEAOMOIGDD, JMNCFHIJLAL IMJGFHGLEPI, FHFCMNCJGAI IAKEAAFMAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x3A87470", Offset = "0x3A86870", VA = "0x183A87470", Slot = "8")]
	[AsyncStateMachine(typeof(ODAKOCIBJJG))]
	protected override Task OEMHFFDLDAN(MFMLJGKBCFN EFLDCPJPINN, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x3A87220", Offset = "0x3A86620", VA = "0x183A87220")]
	private GNFMLPKABNA ODPCFONPBHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal class ADHEFAOCNHL : NJHNOKIINKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct LLMCBEGCADE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public ADHEFAOCNHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public MFMLJGKBCFN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private IBIDBCAPHMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private TaskAwaiter<OCDLNECLLKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x3A7ABA0", Offset = "0x3A79FA0", VA = "0x183A7ABA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private readonly int FADNHLCFMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private readonly HJHFIAECAFN GNJIELOFDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public readonly long NAMBHCIKONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public readonly long MFJPNOLJPLO;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public OCDLNECLLKD IICKKDJJKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x757C60", Offset = "0x757060", VA = "0x180757C60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x807460", Offset = "0x806860", VA = "0x180807460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x3115F90", Offset = "0x3115390", VA = "0x183115F90")]
	public ADHEFAOCNHL(Guid OMEAOMOIGDD, JMNCFHIJLAL IMJGFHGLEPI, FHFCMNCJGAI IAKEAAFMAMC, int FADNHLCFMCD, HJHFIAECAFN GNJIELOFDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x3115E50", Offset = "0x3115250", VA = "0x183115E50", Slot = "8")]
	[AsyncStateMachine(typeof(LLMCBEGCADE))]
	protected override Task OEMHFFDLDAN(MFMLJGKBCFN EFLDCPJPINN, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal abstract class CCDEPNBHIKA : NJHNOKIINKM
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class EAFEOIKNDBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public CCDEPNBHIKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public FCIKFFNPKLM playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public EAFEOIKNDBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x3A72A70", Offset = "0x3A71E70", VA = "0x183A72A70")]
		internal Task <RunAsync>b__0(IBIDBCAPHMG postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x3A72AB0", Offset = "0x3A71EB0", VA = "0x183A72AB0")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct GPOCACDBNCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public CCDEPNBHIKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public MFMLJGKBCFN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private EAFEOIKNDBB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x3A75440", Offset = "0x3A74840", VA = "0x183A75440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct CNGHBBEBDDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public IBIDBCAPHMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public FCIKFFNPKLM playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public CCDEPNBHIKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private IBIDBCAPHMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x3A71F80", Offset = "0x3A71380", VA = "0x183A71F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x311B8A0", Offset = "0x311ACA0", VA = "0x18311B8A0")]
	public CCDEPNBHIKA(Guid OMEAOMOIGDD, JMNCFHIJLAL IMJGFHGLEPI, FHFCMNCJGAI IAKEAAFMAMC, string FMAAEKBDOAG, FDJMDHAGLAP HGNGEDBMHCK, bool KHHEOKCMKGM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x311B750", Offset = "0x311AB50", VA = "0x18311B750", Slot = "8")]
	[AsyncStateMachine(typeof(GPOCACDBNCA))]
	protected override Task OEMHFFDLDAN(MFMLJGKBCFN EFLDCPJPINN, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task JMJIGLLGAFK(MFMLJGKBCFN EFLDCPJPINN, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x311B5F0", Offset = "0x311A9F0", VA = "0x18311B5F0")]
	[AsyncStateMachine(typeof(CNGHBBEBDDB))]
	private Task DEOJBOCMMIC(IDisposable OKPINGBDIJF, FCIKFFNPKLM FBHFPFPCJBM, IBIDBCAPHMG HHEDADBLDNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal class GCDNAJBGELK : NJHNOKIINKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct FKPEMJDOHCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public GCDNAJBGELK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public MFMLJGKBCFN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private TaskAwaiter<PNGJOFGNDJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x40210F0", Offset = "0x40204F0", VA = "0x1840210F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private readonly ALDHOJLECOH KJHAOKNAKMN;

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x3124270", Offset = "0x3123670", VA = "0x183124270")]
	public GCDNAJBGELK(Guid OMEAOMOIGDD, JMNCFHIJLAL IMJGFHGLEPI, FHFCMNCJGAI IAKEAAFMAMC, ALDHOJLECOH KJHAOKNAKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x3124050", Offset = "0x3123450", VA = "0x183124050", Slot = "7")]
	protected override string JLFBJNMHAOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x3124130", Offset = "0x3123530", VA = "0x183124130", Slot = "8")]
	[AsyncStateMachine(typeof(FKPEMJDOHCB))]
	protected override Task OEMHFFDLDAN(MFMLJGKBCFN EFLDCPJPINN, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal abstract class NJHNOKIINKM : MOKBCDABHAA
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public delegate Task IEGCKLADDLI(IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class PAKLDFNCKBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public IBIDBCAPHMG operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public NJHNOKIINKM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PAKLDFNCKBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x45D7960", Offset = "0x45D6D60", VA = "0x1845D7960")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class LODFDECOAGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public PAKLDFNCKBA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public LODFDECOAGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x45D59A0", Offset = "0x45D4DA0", VA = "0x1845D59A0")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x45D5A60", Offset = "0x45D4E60", VA = "0x1845D5A60")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private struct FKONOJEMGAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public NJHNOKIINKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public Func<NJHNOKIINKM, IBIDBCAPHMG, MFMLJGKBCFN> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private PAKLDFNCKBA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private MFMLJGKBCFN <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private TaskAwaiter<PLBGOAPJHAI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x45D0300", Offset = "0x45CF700", VA = "0x1845D0300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private struct JIBPINHFJDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public NJHNOKIINKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x45D46D0", Offset = "0x45D3AD0", VA = "0x1845D46D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public readonly Guid CEFEFFDEHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public readonly ByteString AINGGNMKCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public readonly FHFCMNCJGAI CDPLFELBEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	protected readonly string OAPEAFCGBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private readonly JMNCFHIJLAL IMJGFHGLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private readonly bool KHHEOKCMKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private readonly Queue<IEGCKLADDLI> AJAEIHGEDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private readonly CINGNOEIMGI AGHEOELJNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private readonly FDJMDHAGLAP HGNGEDBMHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private bool PNPKDKEMBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public ADBPAACHPEK OJNABDFCOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public ADBPAACHPEK FNHNFDIMNEG;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public JMNCFHIJLAL MDHFAHDNFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public HKLHFCGBNEN DDGABFFCPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x3A80170", Offset = "0x3A7F570", VA = "0x183A80170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public OGJIKCIMBEL BLHNIKJGMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x3A80550", Offset = "0x3A7F950", VA = "0x183A80550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public IDGMGLIGADE KHOLDMMJLMF
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x3A80430", Offset = "0x3A7F830", VA = "0x183A80430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public float ENIDNKJMEME
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x3A804D0", Offset = "0x3A7F8D0", VA = "0x183A804D0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event CODHJHFLGDA NGDDPGHLDGB
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x3A804B0", Offset = "0x3A7F8B0", VA = "0x183A804B0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x3A80790", Offset = "0x3A7FB90", VA = "0x183A80790", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x3A807B0", Offset = "0x3A7FBB0", VA = "0x183A807B0")]
	protected NJHNOKIINKM(Guid OMEAOMOIGDD, JMNCFHIJLAL IMJGFHGLEPI, FHFCMNCJGAI IAKEAAFMAMC, string FMAAEKBDOAG, FDJMDHAGLAP HGNGEDBMHCK, bool KHHEOKCMKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x3A80370", Offset = "0x3A7F770", VA = "0x183A80370", Slot = "7")]
	protected virtual string JLFBJNMHAOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x3A804F0", Offset = "0x3A7F8F0", VA = "0x183A804F0")]
	public void NFJCKPIPPCK(IEGCKLADDLI BDJCJJEPECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x3A80350", Offset = "0x3A7F750", VA = "0x183A80350")]
	protected void JBNKGHBMCED(float KHNOBAAPEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x3A80020", Offset = "0x3A7F420", VA = "0x183A80020")]
	[AsyncStateMachine(typeof(FKONOJEMGAE))]
	public Task BMPOKKCKKNK(CancellationToken OLHHOODBFDC, IBIDBCAPHMG KIBJDNPFMAF, [Optional] Func<NJHNOKIINKM, IBIDBCAPHMG, MFMLJGKBCFN> CHJCBNKADNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x3A801C0", Offset = "0x3A7F5C0", VA = "0x183A801C0")]
	private void EPOOHEHOGKO(bool PKOGEGLMCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x3A80680", Offset = "0x3A7FA80", VA = "0x183A80680")]
	private void OEOIBACEKOL(MFMLJGKBCFN EFLDCPJPINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task OEMHFFDLDAN(MFMLJGKBCFN EFLDCPJPINN, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x3A7FEE0", Offset = "0x3A7F2E0", VA = "0x183A7FEE0")]
	[AsyncStateMachine(typeof(JIBPINHFJDG))]
	private Task BEENAGGNPNB(IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x3A803B0", Offset = "0x3A7F7B0", VA = "0x183A803B0")]
	public PLBGOAPJHAI LLLMINGNFPH(IFKMEDBFPKJ DCPEMCDAFLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x3A805A0", Offset = "0x3A7F9A0", VA = "0x183A805A0")]
	[CompilerGenerated]
	private Task OCEJGANCGDF(CancellationToken EHIBGNPGILO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
internal sealed class BPOIFNHHLBA : CCDEPNBHIKA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct FKEGLKIPEIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public BPOIFNHHLBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public MFMLJGKBCFN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private NBNKBIKAIGB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private MJBKFIFINGO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x3A73900", Offset = "0x3A72D00", VA = "0x183A73900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private readonly GKIAAKPIFKA IENMJHNNIMB;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x311B540", Offset = "0x311A940", VA = "0x18311B540")]
	public BPOIFNHHLBA(Guid OMEAOMOIGDD, JMNCFHIJLAL IMJGFHGLEPI, GKIAAKPIFKA IENMJHNNIMB, FHFCMNCJGAI IAKEAAFMAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x311B3F0", Offset = "0x311A7F0", VA = "0x18311B3F0", Slot = "9")]
	[AsyncStateMachine(typeof(FKEGLKIPEIP))]
	protected override Task JMJIGLLGAFK(MFMLJGKBCFN EFLDCPJPINN, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
internal class NBCHNOCJHBB : NJHNOKIINKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct FNGBOPLGNAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public NBCHNOCJHBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public MFMLJGKBCFN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private TaskAwaiter<PNGJOFGNDJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x45D1B00", Offset = "0x45D0F00", VA = "0x1845D1B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private readonly string ONIMEKFKAGH;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x3A7F480", Offset = "0x3A7E880", VA = "0x183A7F480")]
	public NBCHNOCJHBB(Guid OMEAOMOIGDD, JMNCFHIJLAL IMJGFHGLEPI, FHFCMNCJGAI IAKEAAFMAMC, string ONIMEKFKAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x3A7F350", Offset = "0x3A7E750", VA = "0x183A7F350", Slot = "8")]
	[AsyncStateMachine(typeof(FNGBOPLGNAM))]
	protected override Task OEMHFFDLDAN(MFMLJGKBCFN EFLDCPJPINN, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class ENBMCMKHHFO : CCDEPNBHIKA
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class PPPBMGCPJNK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public AsyncTaskMethodBuilder<PLBGOAPJHAI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public PPPBMGCPJNK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			private TaskAwaiter<PNGJOFGNDJG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			private TaskAwaiter<PLBGOAPJHAI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x45DC800", Offset = "0x45DBC00", VA = "0x1845DC800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x45DCB50", Offset = "0x45DBF50", VA = "0x1845DCB50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public ENBMCMKHHFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public MECBAEJOJKA serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public MJGKPFMGAPI uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PPPBMGCPJNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x402CEC0", Offset = "0x402C2C0", VA = "0x18402CEC0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<PLBGOAPJHAI> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct GIGPJIIGFBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public ENBMCMKHHFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public MFMLJGKBCFN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private PPPBMGCPJNK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private NBNKBIKAIGB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private MJBKFIFINGO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TaskAwaiter<PLBGOAPJHAI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x3A73EE0", Offset = "0x3A732E0", VA = "0x183A73EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	private readonly int DJCINABOACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	[CanBeNull]
	private readonly MNCEMDCIACF NEGDKGFCMAH;

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x3120B40", Offset = "0x311FF40", VA = "0x183120B40")]
	public ENBMCMKHHFO(Guid OMEAOMOIGDD, JMNCFHIJLAL IMJGFHGLEPI, int DJCINABOACI, MNCEMDCIACF NEGDKGFCMAH, FHFCMNCJGAI IAKEAAFMAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x3120840", Offset = "0x311FC40", VA = "0x183120840", Slot = "9")]
	[AsyncStateMachine(typeof(GIGPJIIGFBG))]
	protected override Task JMJIGLLGAFK(MFMLJGKBCFN EFLDCPJPINN, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x3120720", Offset = "0x311FB20", VA = "0x183120720")]
	private void AOAJDJAEKEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x31209A0", Offset = "0x311FDA0", VA = "0x1831209A0")]
	private void PIBFHPEBNHP(IBIDBCAPHMG KIBJDNPFMAF, NBNKBIKAIGB MLBPLLDNPGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal abstract class OFDEKMCOBBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public readonly NJHNOKIINKM KGKHEDLKDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public readonly MFMLJGKBCFN MJPEIEAFBHC;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public HKLHFCGBNEN DDGABFFCPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x3A811B0", Offset = "0x3A805B0", VA = "0x183A811B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public IDGMGLIGADE KHOLDMMJLMF
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x3A81200", Offset = "0x3A80600", VA = "0x183A81200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x3A812D0", Offset = "0x3A806D0", VA = "0x183A812D0")]
	protected OFDEKMCOBBC(MFMLJGKBCFN EFLDCPJPINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x3A812B0", Offset = "0x3A806B0", VA = "0x183A812B0")]
	protected void NDPGLCAACEE(string HGKAIBNMMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x3A81290", Offset = "0x3A80690", VA = "0x183A81290")]
	public void NDPGLCAACEE(Func<string> JPFLHEEKFPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal struct DIBJCPPCAMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public Dictionary<Guid, List<FIDOEHJLJBB>> HPILNMHNGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public Dictionary<Guid, List<FIDOEHJLJBB>> IMKOKPNMMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public Dictionary<Guid, List<FIDOEHJLJBB>> NIDAEEJAFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public List<Guid> IEEODLJPEFN;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x311D450", Offset = "0x311C850", VA = "0x18311D450")]
	public static DIBJCPPCAMC JLPNHBINJFC(HKLHFCGBNEN FGFPMOHFMOM, ADBPAACHPEK BJKECJALDIC, HBMEPODFBHF PJKBLPIBHBJ)
	{
		return default(DIBJCPPCAMC);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal struct LHLIJEBKIFK
{
	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0")]
	public static LHLIJEBKIFK BFPHDDBHNEE()
	{
		return default(LHLIJEBKIFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void FPFHFGDOEPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void CGCHGLFCGJH(HBMEPODFBHF ONIBEFDCPGD, object JNGKMBCEAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void JFGPICPECMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal struct CDAODPLIHFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public readonly NJHHCJFILAP KBKLNNOLLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public readonly COOBAAMIODE CBIJCMKPEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public readonly GPBJNGHMIFG HCEAGEMIOND;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x311B8F0", Offset = "0x311ACF0", VA = "0x18311B8F0")]
	public CDAODPLIHFK(NJHHCJFILAP KBKLNNOLLHH, COOBAAMIODE CBIJCMKPEJE, GPBJNGHMIFG HCEAGEMIOND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal struct OGKGOFLGOEA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	private readonly MFMLJGKBCFN EFLDCPJPINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	private readonly Guid DGKELKDLHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private bool PKOGEGLMCLO;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x3A81440", Offset = "0x3A80840", VA = "0x183A81440")]
	public static OGKGOFLGOEA OFGAGFJGBFE(MFMLJGKBCFN EFLDCPJPINN)
	{
		return default(OGKGOFLGOEA);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x1F882D0", Offset = "0x1F876D0", VA = "0x181F882D0")]
	public void KPFBNOOHIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x3A81330", Offset = "0x3A80730", VA = "0x183A81330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x3A814A0", Offset = "0x3A808A0", VA = "0x183A814A0")]
	private OGKGOFLGOEA(MFMLJGKBCFN EFLDCPJPINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x3A81330", Offset = "0x3A80730", VA = "0x183A81330")]
	private void KPLHFMLPANF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x3A81390", Offset = "0x3A80790", VA = "0x183A81390")]
	private Func<Guid, bool> JGBBAKKINHH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
internal class MJBKFIFINGO : OFDEKMCOBBC, MOKBCDABHAA
{
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public delegate Task<ADBPAACHPEK> BJHJIKLOIKD(HBMEPODFBHF ONIBEFDCPGD, EPCGCCMKFOK KNMGHCGDCMP, CINGNOEIMGI EIAPDOMBHAD, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct PLNLOJNLMEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public MJBKFIFINGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public GKIAAKPIFKA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private OGKGOFLGOEA <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private TaskAwaiter<PLBGOAPJHAI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x45D8A70", Offset = "0x45D7E70", VA = "0x1845D8A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct NFENLCCONFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public AsyncTaskMethodBuilder<PLBGOAPJHAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public MJBKFIFINGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public GKIAAKPIFKA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private IBIDBCAPHMG <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private TaskAwaiter<PLBGOAPJHAI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x402A840", Offset = "0x4029C40", VA = "0x18402A840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x402AB60", Offset = "0x4029F60", VA = "0x18402AB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct ACJEGAFBDKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public MJBKFIFINGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public GKIAAKPIFKA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private IBIDBCAPHMG <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x4018370", Offset = "0x4017770", VA = "0x184018370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class ICIBBOOJJJJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010E")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public AsyncTaskMethodBuilder<CDAODPLIHFK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public ICIBBOOJJJJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private CDAODPLIHFK <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			private TaskAwaiter<ADBPAACHPEK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			private TaskAwaiter<CDAODPLIHFK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x45DB540", Offset = "0x45DA940", VA = "0x1845DB540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x45DBB50", Offset = "0x45DAF50", VA = "0x1845DBB50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public AsyncTaskMethodBuilder<HBMEPODFBHF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public ICIBBOOJJJJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			private HBMEPODFBHF <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			private TaskAwaiter<ADBPAACHPEK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			private TaskAwaiter<HBMEPODFBHF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x45DBBA0", Offset = "0x45DAFA0", VA = "0x1845DBBA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x45DC0D0", Offset = "0x45DB4D0", VA = "0x1845DC0D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000110")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			public ICIBBOOJJJJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			private bool <reloadSceneForObjectModel>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			private TaskAwaiter<ADBPAACHPEK> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			private EPCGCCMKFOK <timedYielder>5__3;

			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0x45DA1D0", Offset = "0x45D95D0", VA = "0x1845DA1D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public MJBKFIFINGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public GKIAAKPIFKA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public CINGNOEIMGI preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public CINGNOEIMGI downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public CDAODPLIHFK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public CINGNOEIMGI postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public HBMEPODFBHF phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public MCKNPKJAOMF.GLBPDGMBKIC <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ICIBBOOJJJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x4023EA0", Offset = "0x40232A0", VA = "0x184023EA0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<CDAODPLIHFK> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x4023FE0", Offset = "0x40233E0", VA = "0x184023FE0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<HBMEPODFBHF> <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x4024120", Offset = "0x4023520", VA = "0x184024120")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x4023D70", Offset = "0x4023170", VA = "0x184023D70")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct PMPOIFDKPGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public MJBKFIFINGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public GKIAAKPIFKA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public bool isInitialLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private ICIBBOOJJJJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private TaskAwaiter<CDAODPLIHFK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private TaskAwaiter<HBMEPODFBHF> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x45D8E00", Offset = "0x45D8200", VA = "0x1845D8E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct BMJMDJNMOCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public MJBKFIFINGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public IBIDBCAPHMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x401B420", Offset = "0x401A820", VA = "0x18401B420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct PLHEMKILMLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public MJBKFIFINGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public CINGNOEIMGI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private IBIDBCAPHMG <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private TaskAwaiter<ADBPAACHPEK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x45D84C0", Offset = "0x45D78C0", VA = "0x1845D84C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct EPDILBHHGGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public AsyncTaskMethodBuilder<ADBPAACHPEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public MJBKFIFINGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public CINGNOEIMGI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private IBIDBCAPHMG <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<ADBPAACHPEK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x401F280", Offset = "0x401E680", VA = "0x18401F280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x401FD20", Offset = "0x401F120", VA = "0x18401FD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct JPFLMOGHFEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public AsyncTaskMethodBuilder<ADBPAACHPEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public MJBKFIFINGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public CINGNOEIMGI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public EPCGCCMKFOK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private IBIDBCAPHMG <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private TaskAwaiter<ADBPAACHPEK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x4024C30", Offset = "0x4024030", VA = "0x184024C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x40257E0", Offset = "0x4024BE0", VA = "0x1840257E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct GGDAEBBLKBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public AsyncTaskMethodBuilder<ADBPAACHPEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public MJBKFIFINGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public ADBPAACHPEK operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public CINGNOEIMGI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public HBMEPODFBHF deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private TaskAwaiter<ADBPAACHPEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x4021C00", Offset = "0x4021000", VA = "0x184021C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x4021E00", Offset = "0x4021200", VA = "0x184021E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class PPIHHFJCBBH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000119")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public AsyncTaskMethodBuilder<ADBPAACHPEK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public PPIHHFJCBBH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			private TaskAwaiter<ADBPAACHPEK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0x45DC120", Offset = "0x45DB520", VA = "0x1845DC120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0x45DC670", Offset = "0x45DBA70", VA = "0x1845DC670", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public MJBKFIFINGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public CINGNOEIMGI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public BJHJIKLOIKD masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public EPCGCCMKFOK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public ADBPAACHPEK originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PPIHHFJCBBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x45D9F50", Offset = "0x45D9350", VA = "0x1845D9F50")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<ADBPAACHPEK> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct OAPFKIKBJIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public AsyncTaskMethodBuilder<ADBPAACHPEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public MJBKFIFINGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public CINGNOEIMGI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public BJHJIKLOIKD masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public EPCGCCMKFOK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private TaskAwaiter<ADBPAACHPEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x45D69C0", Offset = "0x45D5DC0", VA = "0x1845D69C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x45D6E70", Offset = "0x45D6270", VA = "0x1845D6E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct NMBEOCJKBKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public MJBKFIFINGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public CINGNOEIMGI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private ADBPAACHPEK <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private IEnumerator<ADBPAACHPEK> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private TaskAwaiter<ADBPAACHPEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x402B850", Offset = "0x402AC50", VA = "0x18402B850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct KGMJAAHDPJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public MJBKFIFINGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x4026280", Offset = "0x4025680", VA = "0x184026280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct DGEDDPPALKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public JMNCFHIJLAL roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x401D630", Offset = "0x401CA30", VA = "0x18401D630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct AINMAPDBJAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public MJBKFIFINGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x40185D0", Offset = "0x40179D0", VA = "0x1840185D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class IOPIBADOMOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public NJHHCJFILAP roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public IOPIBADOMOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x40241E0", Offset = "0x40235E0", VA = "0x1840241E0")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private readonly GLKHMHJFJLG PBKDLICAKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly GLKHMHJFJLG HJBGGJMCMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly AMMHDIJOABG NDMFPGJENNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly CKBFJBANFAL AJJFADDHGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	private readonly FIIEPBBDBAE JIKPEHDKMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	private readonly BNJMAHNLHOH PBLGIJJOHDB;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float ENIDNKJMEME
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x3135720", Offset = "0x3134B20", VA = "0x183135720", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private JMNCFHIJLAL MDHFAHDNFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x3134020", Offset = "0x3133420", VA = "0x183134020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event CODHJHFLGDA NGDDPGHLDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x31355E0", Offset = "0x31349E0", VA = "0x1831355E0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x3135B20", Offset = "0x3134F20", VA = "0x183135B20", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x3135D40", Offset = "0x3135140", VA = "0x183135D40")]
	public MJBKFIFINGO(MFMLJGKBCFN EFLDCPJPINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x3134EF0", Offset = "0x31342F0", VA = "0x183134EF0")]
	[AsyncStateMachine(typeof(PLNLOJNLMEN))]
	public Task HPEOECKACBL(GKIAAKPIFKA EFADACBHMKC, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC, bool DCAJCBHAJKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x3133D20", Offset = "0x3133120", VA = "0x183133D20")]
	[AsyncStateMachine(typeof(NFENLCCONFO))]
	private Task<PLBGOAPJHAI> AEJCBCDBLDN(GKIAAKPIFKA EFADACBHMKC, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x3135200", Offset = "0x3134600", VA = "0x183135200")]
	[AsyncStateMachine(typeof(ACJEGAFBDKH))]
	private Task KFLBEELBNFE(GKIAAKPIFKA EFADACBHMKC, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC, bool DCAJCBHAJKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x3135050", Offset = "0x3134450", VA = "0x183135050")]
	[AsyncStateMachine(typeof(PMPOIFDKPGA))]
	private Task IMNIDBJOFNG(GKIAAKPIFKA EFADACBHMKC, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken GEBPFPDDLHH, bool DCAJCBHAJKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x31359F0", Offset = "0x3134DF0", VA = "0x1831359F0")]
	[AsyncStateMachine(typeof(BMJMDJNMOCF))]
	private Task OKNJBGDNDPH(IBIDBCAPHMG HHEDADBLDNA, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x31348F0", Offset = "0x3133CF0", VA = "0x1831348F0")]
	[AsyncStateMachine(typeof(PLHEMKILMLE))]
	private Task FDAOFFJLHIP(HBMEPODFBHF ONIBEFDCPGD, CINGNOEIMGI EIAPDOMBHAD, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x3134770", Offset = "0x3133B70", VA = "0x183134770")]
	[AsyncStateMachine(typeof(EPDILBHHGGC))]
	private Task<ADBPAACHPEK> ENIIJNBPFIH(HBMEPODFBHF ONIBEFDCPGD, EPCGCCMKFOK MNNPJOPIJHH, CINGNOEIMGI EIAPDOMBHAD, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x3134A50", Offset = "0x3133E50", VA = "0x183134A50")]
	[AsyncStateMachine(typeof(JPFLMOGHFEN))]
	private Task<ADBPAACHPEK> FMEHCMDEHOB(HBMEPODFBHF ONIBEFDCPGD, EPCGCCMKFOK MNNPJOPIJHH, CINGNOEIMGI EIAPDOMBHAD, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x3134310", Offset = "0x3133710", VA = "0x183134310")]
	[AsyncStateMachine(typeof(GGDAEBBLKBK))]
	private Task<ADBPAACHPEK> CLIDFNMKALG(ADBPAACHPEK BJKECJALDIC, HBMEPODFBHF PJKBLPIBHBJ, CINGNOEIMGI EIAPDOMBHAD, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC, bool HGMPHEDOLGA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x31354F0", Offset = "0x31348F0", VA = "0x1831354F0")]
	private bool MIDAIELNHNG(HBMEPODFBHF OBAAJHMIJJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x3135B90", Offset = "0x3134F90", VA = "0x183135B90")]
	[AsyncStateMachine(typeof(OAPFKIKBJIG))]
	protected Task<ADBPAACHPEK> POKPJBCLBFI(HBMEPODFBHF ONIBEFDCPGD, EPCGCCMKFOK MNNPJOPIJHH, CINGNOEIMGI EIAPDOMBHAD, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC, BJHJIKLOIKD LAFGJNNJJFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x31341B0", Offset = "0x31335B0", VA = "0x1831341B0")]
	[AsyncStateMachine(typeof(NMBEOCJKBKJ))]
	private Task CHIBLPKGJMC(HBMEPODFBHF ONIBEFDCPGD, CINGNOEIMGI EIAPDOMBHAD, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x31351B0", Offset = "0x31345B0", VA = "0x1831351B0")]
	private void JDEOBJKFNCE(ADBPAACHPEK LGEIJNPFKKO, CINGNOEIMGI EIAPDOMBHAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x3134D60", Offset = "0x3134160", VA = "0x183134D60")]
	private void GNMAAPCBOIA(ADBPAACHPEK GLCNPHEBMMP, out ADBPAACHPEK BJJCIBCKEMM, out ADBPAACHPEK NGNKHNFAHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x31354B0", Offset = "0x31348B0", VA = "0x1831354B0")]
	private Task<CDAODPLIHFK> LGADLFMEMBA(GKIAAKPIFKA EFADACBHMKC, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x3135B40", Offset = "0x3134F40", VA = "0x183135B40")]
	private Task<HBMEPODFBHF> PIHEGMADHOI(GKIAAKPIFKA EFADACBHMKC, CDAODPLIHFK ONIBEFDCPGD, MCKNPKJAOMF.GLBPDGMBKIC DLMGJJEDGFE, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x3133ED0", Offset = "0x31332D0", VA = "0x183133ED0")]
	[AsyncStateMachine(typeof(KGMJAAHDPJN))]
	private Task AOMMEGBGBLA(HBMEPODFBHF ONIBEFDCPGD, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x3134DA0", Offset = "0x31341A0", VA = "0x183134DA0")]
	[AsyncStateMachine(typeof(DGEDDPPALKB))]
	private Task HDJNBMBHGCB(HBMEPODFBHF ONIBEFDCPGD, JMNCFHIJLAL IMJGFHGLEPI, IBIDBCAPHMG KIBJDNPFMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x3135600", Offset = "0x3134A00", VA = "0x183135600")]
	[AsyncStateMachine(typeof(AINMAPDBJAD))]
	private Task MNNFDGAKBOC(HBMEPODFBHF ONIBEFDCPGD, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x31344A0", Offset = "0x31338A0", VA = "0x1831344A0")]
	private Task DFHIOGGIPDL(HBMEPODFBHF ONIBEFDCPGD, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x3134050", Offset = "0x3133450", VA = "0x183134050")]
	private Task BKFPKKJIPNE(HBMEPODFBHF ONIBEFDCPGD, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x3135360", Offset = "0x3134760", VA = "0x183135360")]
	private Task LEJFMNDJPEH(HBMEPODFBHF ONIBEFDCPGD, EPCGCCMKFOK MNNPJOPIJHH, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x3134600", Offset = "0x3133A00", VA = "0x183134600")]
	private Task EJCPFMPHOKO(HBMEPODFBHF ONIBEFDCPGD, EPCGCCMKFOK MNNPJOPIJHH, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x312F810", Offset = "0x312EC10", VA = "0x18312F810")]
	private static Task MCHBBBKGOHF(CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x3135740", Offset = "0x3134B40", VA = "0x183135740")]
	private Task OHFNHNOGDJC(HBMEPODFBHF ONIBEFDCPGD, EPCGCCMKFOK MNNPJOPIJHH, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x31358A0", Offset = "0x3134CA0", VA = "0x1831358A0")]
	private Task OIBKMNDGHGO(HBMEPODFBHF ONIBEFDCPGD, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x3133EA0", Offset = "0x31332A0", VA = "0x183133EA0")]
	private void ANBBOBNIBEP(GKIAAKPIFKA EFADACBHMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x3134BF0", Offset = "0x3133FF0", VA = "0x183134BF0")]
	private static void GHAEENPLNJP(NJHHCJFILAP KBKLNNOLLHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct AHDKIPABALL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private JMNCFHIJLAL IMJGFHGLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private HBMEPODFBHF ONIBEFDCPGD;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private HKLHFCGBNEN DDGABFFCPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x3118010", Offset = "0x3117410", VA = "0x183118010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x3117D10", Offset = "0x3117110", VA = "0x183117D10")]
	public static Task BMPOKKCKKNK(JMNCFHIJLAL IMJGFHGLEPI, HBMEPODFBHF ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x3117DB0", Offset = "0x31171B0", VA = "0x183117DB0")]
	private void BMPOKKCKKNK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal struct LOIFNAPIKCK
{
	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x312F810", Offset = "0x312EC10", VA = "0x18312F810")]
	public static Task BMPOKKCKKNK(CancellationToken OLHHOODBFDC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000122")]
internal struct GICDGOFILOF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct FHOPJBMAAGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public MFMLJGKBCFN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private IBIDBCAPHMG <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x4020C70", Offset = "0x4020070", VA = "0x184020C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x3124DF0", Offset = "0x31241F0", VA = "0x183124DF0")]
	[AsyncStateMachine(typeof(FHOPJBMAAGE))]
	public static Task BMPOKKCKKNK(MFMLJGKBCFN EFLDCPJPINN, HBMEPODFBHF ONIBEFDCPGD, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal struct FIOHOBOLOGF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct NJICGKNJAFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public MFMLJGKBCFN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public EPCGCCMKFOK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private ADBPAACHPEK <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private JMNCFHIJLAL <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private HKLHFCGBNEN <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private List<(PersistenceView, POHCLHIPEBO)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private POHCLHIPEBO <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x402B050", Offset = "0x402A450", VA = "0x18402B050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x31229E0", Offset = "0x3121DE0", VA = "0x1831229E0")]
	[AsyncStateMachine(typeof(NJICGKNJAFL))]
	public static Task BMPOKKCKKNK(MFMLJGKBCFN EFLDCPJPINN, HBMEPODFBHF ONIBEFDCPGD, EPCGCCMKFOK MNNPJOPIJHH, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x3122B50", Offset = "0x3121F50", VA = "0x183122B50")]
	private static void GNBKOGBLNBG(PersistenceView CHOBEAJIPKF, POHCLHIPEBO JNGKMBCEAGB, HBMEPODFBHF ONIBEFDCPGD, ADBPAACHPEK BJKECJALDIC, bool DNOHJCNENEN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal struct KKPBAFCJLHG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct KBCIICAEPCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public JMNCFHIJLAL roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x4025830", Offset = "0x4024C30", VA = "0x184025830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x312E560", Offset = "0x312D960", VA = "0x18312E560")]
	[AsyncStateMachine(typeof(KBCIICAEPCJ))]
	public static Task BMPOKKCKKNK(JMNCFHIJLAL IMJGFHGLEPI, HBMEPODFBHF ONIBEFDCPGD, CancellationToken OLHHOODBFDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal struct GGANBCLOJHM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct AAIBAIFCLPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public JMNCFHIJLAL roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public MFMLJGKBCFN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x4018160", Offset = "0x4017560", VA = "0x184018160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct BHPCEOEADKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public GGANBCLOJHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private TaskAwaiter<PLBGOAPJHAI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x4019E20", Offset = "0x4019220", VA = "0x184019E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class FEPACGHDBPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public CJHBLOEDPCM version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public FEPACGHDBPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x4020A20", Offset = "0x401FE20", VA = "0x184020A20")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x4020B00", Offset = "0x401FF00", VA = "0x184020B00")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private JMNCFHIJLAL IMJGFHGLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private HBMEPODFBHF ONIBEFDCPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private MFMLJGKBCFN EFLDCPJPINN;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	private static readonly ByteString IPBGECGGMDB;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private HKLHFCGBNEN DDGABFFCPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x31245C0", Offset = "0x31239C0", VA = "0x1831245C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private IDGMGLIGADE KHOLDMMJLMF
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x3124CC0", Offset = "0x31240C0", VA = "0x183124CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x3124450", Offset = "0x3123850", VA = "0x183124450")]
	[AsyncStateMachine(typeof(AAIBAIFCLPE))]
	public static Task BMPOKKCKKNK(JMNCFHIJLAL IMJGFHGLEPI, HBMEPODFBHF ONIBEFDCPGD, MFMLJGKBCFN EFLDCPJPINN, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x3124310", Offset = "0x3123710", VA = "0x183124310")]
	[AsyncStateMachine(typeof(BHPCEOEADKO))]
	private Task BMPOKKCKKNK(IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x3124610", Offset = "0x3123A10", VA = "0x183124610")]
	private void HOBNJECMDFB([NotNull] ALJFOENJMIN CIHGBDJBHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x3124D40", Offset = "0x3124140", VA = "0x183124D40")]
	private bool NCCIDGOOIEO(CJHBLOEDPCM FLPPPNDNNNB, ALJFOENJMIN CIHGBDJBHIA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal struct KMLDEOHAMLL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct MENCICAIFMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public AsyncTaskMethodBuilder<HBMEPODFBHF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public KMLDEOHAMLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public MCKNPKJAOMF.GLBPDGMBKIC downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private IBIDBCAPHMG <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private TaskAwaiter<(global::OHFECDBHLHC<AOKGGOOOAAG, IOILPEPIEGB>, global::OHFECDBHLHC<global::KKPNMOBPAON<ALJFOENJMIN>, IOILPEPIEGB>, global::OHFECDBHLHC<global::KKPNMOBPAON<LNAKJJBHDNH>, IOILPEPIEGB>, global::OHFECDBHLHC<global::KKPNMOBPAON<LALKLMFOCHP>, IOILPEPIEGB>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x4028B50", Offset = "0x4027F50", VA = "0x184028B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x4029410", Offset = "0x4028810", VA = "0x184029410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct GIEOLBCENKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public AsyncTaskMethodBuilder<global::OHFECDBHLHC<AOKGGOOOAAG, IOILPEPIEGB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public IBIDBCAPHMG downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public KMLDEOHAMLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public MCKNPKJAOMF.GLBPDGMBKIC downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private IBIDBCAPHMG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private TaskAwaiter<global::OHFECDBHLHC<AOKGGOOOAAG, IOILPEPIEGB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x4022A90", Offset = "0x4021E90", VA = "0x184022A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x4022F90", Offset = "0x4022390", VA = "0x184022F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private global::MGNMJIIHJCM<AKFPGEDHNIP, LNAKJJBHDNH> JBGBDEJMHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private global::MGNMJIIHJCM<AKFPGEDHNIP, ALJFOENJMIN> CBIJCMKPEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private global::MGNMJIIHJCM<long, LALKLMFOCHP> JDOHHDIMIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private GCLGHOFJCBB DBGINKMHKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	private GKIAAKPIFKA EFADACBHMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	private NJHHCJFILAP KBKLNNOLLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private COOBAAMIODE OACDKCLGHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private long CFDJBIILEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private IBIDBCAPHMG HHEDADBLDNA;

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x312EDE0", Offset = "0x312E1E0", VA = "0x18312EDE0")]
	public static Task<HBMEPODFBHF> LPJBODCEBFK(JMNCFHIJLAL IMJGFHGLEPI, GKIAAKPIFKA EFADACBHMKC, in CDAODPLIHFK ONIBEFDCPGD, MCKNPKJAOMF.GLBPDGMBKIC DLMGJJEDGFE, IBIDBCAPHMG HHEDADBLDNA, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x312EC30", Offset = "0x312E030", VA = "0x18312EC30")]
	[AsyncStateMachine(typeof(MENCICAIFMH))]
	private Task<HBMEPODFBHF> BMPOKKCKKNK(MCKNPKJAOMF.GLBPDGMBKIC DLMGJJEDGFE, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x312EDA0", Offset = "0x312E1A0", VA = "0x18312EDA0")]
	private AKFPGEDHNIP FFPKNNKHNKN(NCNOCDPKPJA LFJPDDCPGGF)
	{
		return default(AKFPGEDHNIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x312EA80", Offset = "0x312DE80", VA = "0x18312EA80")]
	[AsyncStateMachine(typeof(GIEOLBCENKN))]
	private Task<global::OHFECDBHLHC<AOKGGOOOAAG, IOILPEPIEGB>> AJNHPBDKDPP(string IDBLHDFAAFE, long CFDJBIILEAP, MCKNPKJAOMF.GLBPDGMBKIC DLMGJJEDGFE, IBIDBCAPHMG FNEHFCCMLCN, CancellationToken OLHHOODBFDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal struct DKMLIILLEDH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct GKPIENKODDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public AsyncTaskMethodBuilder<CDAODPLIHFK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public DKMLIILLEDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private IBIDBCAPHMG <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private TaskAwaiter<CDAODPLIHFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x3A74910", Offset = "0x3A73D10", VA = "0x183A74910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x3A74DC0", Offset = "0x3A741C0", VA = "0x183A74DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private struct OGPJKJGFNPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public AsyncTaskMethodBuilder<CDAODPLIHFK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public DKMLIILLEDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private TaskAwaiter<CDAODPLIHFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x3A814F0", Offset = "0x3A808F0", VA = "0x183A814F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x3A816E0", Offset = "0x3A80AE0", VA = "0x183A816E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private sealed class FBJDDAODIEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public FBJDDAODIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x18895B0", Offset = "0x18889B0", VA = "0x1818895B0")]
		internal bool <FetchRoomDetails>b__0(COOBAAMIODE sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct BHPEMNGLAKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public AsyncTaskMethodBuilder<CDAODPLIHFK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public HKLHFCGBNEN callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private FBJDDAODIEF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private IBIDBCAPHMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private TaskAwaiter<NJHHCJFILAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x3A71240", Offset = "0x3A70640", VA = "0x183A71240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x3A71780", Offset = "0x3A70B80", VA = "0x183A71780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private HKLHFCGBNEN FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private AMMHDIJOABG NDMFPGJENNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private IBIDBCAPHMG HHEDADBLDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private long LLDIIOOAFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	private long KFGNOJDEOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	private string IKMOEBBPIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	private AKFPGEDHNIP BMNBJDJOJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	private AKFPGEDHNIP OGINOHNCNFK;

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x311E7E0", Offset = "0x311DBE0", VA = "0x18311E7E0")]
	public static Task<CDAODPLIHFK> LPJBODCEBFK(JMNCFHIJLAL IMJGFHGLEPI, GKIAAKPIFKA EFADACBHMKC, IBIDBCAPHMG HHEDADBLDNA, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x311DF40", Offset = "0x311D340", VA = "0x18311DF40")]
	[AsyncStateMachine(typeof(GKPIENKODDD))]
	private Task<CDAODPLIHFK> BMPOKKCKKNK(CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x311E650", Offset = "0x311DA50", VA = "0x18311E650")]
	[AsyncStateMachine(typeof(OGPJKJGFNPH))]
	private Task<CDAODPLIHFK> LGADLFMEMBA(long LLDIIOOAFHI, long KFGNOJDEOOA, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC, bool JPCEFACCCGL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x311E4D0", Offset = "0x311D8D0", VA = "0x18311E4D0")]
	[AsyncStateMachine(typeof(BHPEMNGLAKC))]
	public static Task<CDAODPLIHFK> LGADLFMEMBA(HKLHFCGBNEN FGFPMOHFMOM, long LLDIIOOAFHI, long KFGNOJDEOOA, CancellationToken OLHHOODBFDC, IBIDBCAPHMG KIBJDNPFMAF, bool JPCEFACCCGL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x311E3C0", Offset = "0x311D7C0", VA = "0x18311E3C0")]
	private void KGLGINFGBCA(NJHHCJFILAP KBKLNNOLLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x311E250", Offset = "0x311D650", VA = "0x18311E250")]
	private bool IINMINCIPOF(CDAODPLIHFK ONIBEFDCPGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x311E0A0", Offset = "0x311D4A0", VA = "0x18311E0A0")]
	private void GJAIHJDDHMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct NKCMDPFCBEE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct IIKFNAJPKMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public NKCMDPFCBEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private IBIDBCAPHMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x45D42B0", Offset = "0x45D36B0", VA = "0x1845D42B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private const int CCGHCFPLJFM = 20;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private const float CFMMAFDEFPM = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private HKLHFCGBNEN FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private HBMEPODFBHF ONIBEFDCPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private IBIDBCAPHMG HHEDADBLDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private float DACDAHJELAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private float HBIANKMPBEE;

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x3A80CE0", Offset = "0x3A800E0", VA = "0x183A80CE0")]
	public static Task HCLFEGLJCNF(JMNCFHIJLAL IMJGFHGLEPI, HBMEPODFBHF ONIBEFDCPGD, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x3A808F0", Offset = "0x3A7FCF0", VA = "0x183A808F0")]
	[AsyncStateMachine(typeof(IIKFNAJPKMD))]
	public Task BMPOKKCKKNK(CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x3A80E80", Offset = "0x3A80280", VA = "0x183A80E80")]
	private static void IECEOICEHKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x3A80B00", Offset = "0x3A7FF00", VA = "0x183A80B00")]
	private void CLPLHKGCHHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x3A80A40", Offset = "0x3A7FE40", VA = "0x183A80A40")]
	private static float CAHCFGGKNBA(HKLHFCGBNEN FGFPMOHFMOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x3A80A20", Offset = "0x3A7FE20", VA = "0x183A80A20")]
	private static float CABKLOBDMLG()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct BGJAKBEMLMI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct MNHKLIIOKOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public MFMLJGKBCFN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private NJHNOKIINKM <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private JMNCFHIJLAL <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private AGCPNHIOPIL.HCJANKNEKJL <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private TaskAwaiter<PLBGOAPJHAI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x3A7CB00", Offset = "0x3A7BF00", VA = "0x183A7CB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct PLOPKLKNOIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private HAGOEFHIFEI.BLNBDKDGDOD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x3A89F00", Offset = "0x3A89300", VA = "0x183A89F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x311AA00", Offset = "0x3119E00", VA = "0x18311AA00")]
	[AsyncStateMachine(typeof(MNHKLIIOKOJ))]
	public static Task BMPOKKCKKNK(MFMLJGKBCFN EFLDCPJPINN, HBMEPODFBHF ONIBEFDCPGD, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x311AB60", Offset = "0x3119F60", VA = "0x18311AB60")]
	private static Task<PLBGOAPJHAI> KGFIFJFOJPF(MFMLJGKBCFN EFLDCPJPINN, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x311AD00", Offset = "0x311A100", VA = "0x18311AD00")]
	[AsyncStateMachine(typeof(PLOPKLKNOIC))]
	private static Task PEBEKKFONEC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct AIBKPAKFJJF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct AHAKBDGDBKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public AIBKPAKFJJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private IBIDBCAPHMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x3A70780", Offset = "0x3A6FB80", VA = "0x183A70780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class LJLOEDGFCDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public LJLOEDGFCDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x3A7AB20", Offset = "0x3A79F20", VA = "0x183A7AB20")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct JNCEOPHDBMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public AIBKPAKFJJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private EGLLLPPLLKF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x3A79AB0", Offset = "0x3A78EB0", VA = "0x183A79AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	private bool ONKLPNBDMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private IBIDBCAPHMG HHEDADBLDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private JMNCFHIJLAL IMJGFHGLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private CancellationToken OLHHOODBFDC;

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x31182A0", Offset = "0x31176A0", VA = "0x1831182A0")]
	public static Task KOKILLNBBID(JMNCFHIJLAL IMJGFHGLEPI, bool ONKLPNBDMIO, IBIDBCAPHMG HHEDADBLDNA, CancellationToken IPIGPAAHFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x3118060", Offset = "0x3117460", VA = "0x183118060")]
	[AsyncStateMachine(typeof(AHAKBDGDBKA))]
	private Task BMPOKKCKKNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x3118170", Offset = "0x3117570", VA = "0x183118170")]
	[AsyncStateMachine(typeof(JNCEOPHDBMN))]
	private Task EBHEJPIOENM(bool OPLGAMIEKAA, string NOGFKIMFHJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0")]
	private bool HONLLEFCPDA(bool ONKLPNBDMIO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct MIGHIKALPHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct OHCINHFPBNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public MIGHIKALPHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private IBIDBCAPHMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x402BC90", Offset = "0x402B090", VA = "0x18402BC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x402C0E0", Offset = "0x402B4E0", VA = "0x18402C0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class OLMDHIKJIJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public OLMDHIKJIJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x402C130", Offset = "0x402B530", VA = "0x18402C130")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct LJOIPFCFDKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public MIGHIKALPHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private EGLLLPPLLKF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x40285A0", Offset = "0x40279A0", VA = "0x1840285A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x4028B00", Offset = "0x4027F00", VA = "0x184028B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private GPBJNGHMIFG CDJAJKIALLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private IBIDBCAPHMG HHEDADBLDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private JMNCFHIJLAL IMJGFHGLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private bool DLLFCODIDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private HBMEPODFBHF ONIBEFDCPGD;

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x3133CA0", Offset = "0x31330A0", VA = "0x183133CA0")]
	public static Task<Scene> PHHJMNJDLKP(JMNCFHIJLAL IMJGFHGLEPI, GPBJNGHMIFG DPGMIPMKOAD, IBIDBCAPHMG HHEDADBLDNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x31338C0", Offset = "0x3132CC0", VA = "0x1831338C0")]
	public static Task<Scene> AOCEBOPECGB(JMNCFHIJLAL IMJGFHGLEPI, HBMEPODFBHF ONIBEFDCPGD, IBIDBCAPHMG HHEDADBLDNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x3133960", Offset = "0x3132D60", VA = "0x183133960")]
	[AsyncStateMachine(typeof(OHCINHFPBNM))]
	private Task<Scene> BMPOKKCKKNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x3133BF0", Offset = "0x3132FF0", VA = "0x183133BF0")]
	private bool IIAEGNLPEIO(HBMEPODFBHF ONIBEFDCPGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x3133C30", Offset = "0x3133030", VA = "0x183133C30")]
	private void LAOLFMKMPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x3133A90", Offset = "0x3132E90", VA = "0x183133A90")]
	[AsyncStateMachine(typeof(LJOIPFCFDKD))]
	private Task<Scene> EBHEJPIOENM(string NOGFKIMFHJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal struct FIIEPBBDBAE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct GGPKMDNDHFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public AsyncTaskMethodBuilder<ADBPAACHPEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public FIIEPBBDBAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public ADBPAACHPEK nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public HBMEPODFBHF deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private IBIDBCAPHMG <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private TaskAwaiter<ADBPAACHPEK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x4022050", Offset = "0x4021450", VA = "0x184022050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x4022640", Offset = "0x4021A40", VA = "0x184022640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct KHBCCFICIEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public AsyncTaskMethodBuilder<ADBPAACHPEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public FIIEPBBDBAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public ADBPAACHPEK state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private TaskAwaiter<PLBGOAPJHAI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x4026430", Offset = "0x4025830", VA = "0x184026430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x40266B0", Offset = "0x4025AB0", VA = "0x1840266B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly MFMLJGKBCFN EFLDCPJPINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private readonly AMMHDIJOABG NDMFPGJENNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private readonly CKBFJBANFAL AJJFADDHGHA;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private NJHNOKIINKM KGKHEDLKDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0xA98480", Offset = "0xA97880", VA = "0x180A98480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x3122980", Offset = "0x3121D80", VA = "0x183122980")]
	public FIIEPBBDBAE(MFMLJGKBCFN EFLDCPJPINN, AMMHDIJOABG NDMFPGJENNL, CKBFJBANFAL AJJFADDHGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x31224D0", Offset = "0x31218D0", VA = "0x1831224D0")]
	[AsyncStateMachine(typeof(GGPKMDNDHFG))]
	public Task<ADBPAACHPEK> FINBOOPNJKP(ADBPAACHPEK EIJLNBCGPKK, HBMEPODFBHF PJKBLPIBHBJ, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC, bool HGMPHEDOLGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x3122670", Offset = "0x3121A70", VA = "0x183122670")]
	[AsyncStateMachine(typeof(KHBCCFICIEP))]
	private Task<ADBPAACHPEK> LGIFCNLHPLO(IBIDBCAPHMG KIBJDNPFMAF, ADBPAACHPEK BGHMFEPCABE, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x31224A0", Offset = "0x31218A0", VA = "0x1831224A0")]
	private bool AJAGAAGPEEN(ADBPAACHPEK ECNEHEIGGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x31227E0", Offset = "0x3121BE0", VA = "0x1831227E0")]
	private void NDPGLCAACEE(string HKGFIHMBIEF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal struct HDEHMINAIPE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct FPPHIPIBCHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public NJHNOKIINKM operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public EPCGCCMKFOK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private List<(PersistenceView, POHCLHIPEBO)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private (PersistenceView, POHCLHIPEBO) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x40216A0", Offset = "0x4020AA0", VA = "0x1840216A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x3127560", Offset = "0x3126960", VA = "0x183127560")]
	[AsyncStateMachine(typeof(FPPHIPIBCHK))]
	public static Task BMPOKKCKKNK(NJHNOKIINKM GMFDMCMDPFN, HBMEPODFBHF ONIBEFDCPGD, EPCGCCMKFOK MNNPJOPIJHH, CancellationToken OLHHOODBFDC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal struct GLCJEOGBIHK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct CBKNGFHHDEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public NJHNOKIINKM operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public EPCGCCMKFOK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private CJHBLOEDPCM <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private List<(PersistenceView, POHCLHIPEBO)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private POHCLHIPEBO <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x401BDC0", Offset = "0x401B1C0", VA = "0x18401BDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x3124F40", Offset = "0x3124340", VA = "0x183124F40")]
	[AsyncStateMachine(typeof(CBKNGFHHDEN))]
	public static Task BMPOKKCKKNK(NJHNOKIINKM GMFDMCMDPFN, HBMEPODFBHF ONIBEFDCPGD, EPCGCCMKFOK MNNPJOPIJHH, CancellationToken OLHHOODBFDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct AGCPNHIOPIL
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public struct HCJANKNEKJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public List<LMHNNMECCEL> GANAAJHDBDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public List<POHCLHIPEBO> JJDHFJCEBJH;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x9B6E00", Offset = "0x9B6200", VA = "0x1809B6E00")]
		public HCJANKNEKJL(List<LMHNNMECCEL> GANAAJHDBDJ, List<POHCLHIPEBO> JJDHFJCEBJH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class EPFMCJFEHME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public IEnumerable<LMHNNMECCEL> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public EPFMCJFEHME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x3A73450", Offset = "0x3A72850", VA = "0x183A73450")]
		internal object <TryBulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private JMNCFHIJLAL IMJGFHGLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private HBMEPODFBHF ONIBEFDCPGD;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private HKLHFCGBNEN DDGABFFCPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x31165A0", Offset = "0x31159A0", VA = "0x1831165A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x3116540", Offset = "0x3115940", VA = "0x183116540")]
	public static HCJANKNEKJL BMPOKKCKKNK(JMNCFHIJLAL IMJGFHGLEPI, HBMEPODFBHF ONIBEFDCPGD)
	{
		return default(HCJANKNEKJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x3116220", Offset = "0x3115620", VA = "0x183116220")]
	private HCJANKNEKJL BMPOKKCKKNK()
	{
		return default(HCJANKNEKJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x31165F0", Offset = "0x31159F0", VA = "0x1831165F0")]
	private HCJANKNEKJL FBOLKALOENA(ALJFOENJMIN CIHGBDJBHIA, CJHBLOEDPCM BNAKNHIHHFP)
	{
		return default(HCJANKNEKJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x3116B40", Offset = "0x3115F40", VA = "0x183116B40")]
	private bool MOBLBDDLMMJ(IEnumerable<LMHNNMECCEL> GANAAJHDBDJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct OJEIPMNOHPE
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class EPNGCDNFADK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public AGCPNHIOPIL.HCJANKNEKJL instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public EPNGCDNFADK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x45CFDB0", Offset = "0x45CF1B0", VA = "0x1845CFDB0")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class PHNKAMCMAHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PHNKAMCMAHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x45D7ED0", Offset = "0x45D72D0", VA = "0x1845D7ED0")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x3A82230", Offset = "0x3A81630", VA = "0x183A82230")]
	public static void BMPOKKCKKNK(NJHNOKIINKM GMFDMCMDPFN, HBMEPODFBHF ONIBEFDCPGD, AGCPNHIOPIL.HCJANKNEKJL EGMMONICDGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal class CKBFJBANFAL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct FAEJLPBEECE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public CKBFJBANFAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public ADBPAACHPEK operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public HBMEPODFBHF deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public IBIDBCAPHMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x3A734D0", Offset = "0x3A728D0", VA = "0x183A734D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class MOIMHFIJACP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			public MOIMHFIJACP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0x45DC6C0", Offset = "0x45DBAC0", VA = "0x1845DC6C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public CKBFJBANFAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public IBIDBCAPHMG handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public MOIMHFIJACP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x3A7D1F0", Offset = "0x3A7C5F0", VA = "0x183A7D1F0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct BHGAMOGIJAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public CKBFJBANFAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public IBIDBCAPHMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private MOIMHFIJACP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x3A70E20", Offset = "0x3A70220", VA = "0x183A70E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct HNBNLKKJBGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public CKBFJBANFAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public IBIDBCAPHMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private IBIDBCAPHMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private Dictionary<Guid, List<FIDOEHJLJBB>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x3A76D90", Offset = "0x3A76190", VA = "0x183A76D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct CNLBPDKFPDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public CKBFJBANFAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public IBIDBCAPHMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private IBIDBCAPHMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private Dictionary<Guid, List<FIDOEHJLJBB>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x3A72440", Offset = "0x3A71840", VA = "0x183A72440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class MCFLJJIDKNN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000159")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005A6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005A7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public FIDOEHJLJBB handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			public MCFLJJIDKNN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0x45DA090", Offset = "0x45D9490", VA = "0x1845DA090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public DGPNIDHPEME runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public List<FIDOEHJLJBB> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public MCFLJJIDKNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x3A7B400", Offset = "0x3A7A800", VA = "0x183A7B400")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x3A7B5E0", Offset = "0x3A7A9E0", VA = "0x183A7B5E0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(FIDOEHJLJBB handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x3A7B4F0", Offset = "0x3A7A8F0", VA = "0x183A7B4F0")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct HHHHIOPONLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public DGPNIDHPEME runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public List<FIDOEHJLJBB> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private MCFLJJIDKNN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x3A75CC0", Offset = "0x3A750C0", VA = "0x183A75CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct MJIPLOADELH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public CKBFJBANFAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public IBIDBCAPHMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x3A7B700", Offset = "0x3A7AB00", VA = "0x183A7B700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class IOIGPKBKNHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public IOIGPKBKNHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x3A78380", Offset = "0x3A77780", VA = "0x183A78380")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct JBIMEAEMDCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public CKBFJBANFAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public HBMEPODFBHF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x3A783F0", Offset = "0x3A777F0", VA = "0x183A783F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class HPLIBHJAPPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public HPLIBHJAPPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x3A77440", Offset = "0x3A76840", VA = "0x183A77440")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct IKBHEEEDJGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public CKBFJBANFAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private TaskAwaiter<PLBGOAPJHAI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x3A77E10", Offset = "0x3A77210", VA = "0x183A77E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class NPGKOFMDLLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public NPGKOFMDLLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x3A81030", Offset = "0x3A80430", VA = "0x183A81030")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private readonly MFMLJGKBCFN EFLDCPJPINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private DIBJCPPCAMC AJJFADDHGHA;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private NJHNOKIINKM KGKHEDLKDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x7BBDE0", Offset = "0x7BB1E0", VA = "0x1807BBDE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x7803F0", Offset = "0x77F7F0", VA = "0x1807803F0")]
	public CKBFJBANFAL(MFMLJGKBCFN EFLDCPJPINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x311BBE0", Offset = "0x311AFE0", VA = "0x18311BBE0")]
	[AsyncStateMachine(typeof(FAEJLPBEECE))]
	public Task BMPOKKCKKNK(ADBPAACHPEK BJKECJALDIC, HBMEPODFBHF PJKBLPIBHBJ, IBIDBCAPHMG HHEDADBLDNA, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x311C7B0", Offset = "0x311BBB0", VA = "0x18311C7B0")]
	[AsyncStateMachine(typeof(BHGAMOGIJAB))]
	private Task NCCBKJODNGG(HBMEPODFBHF ONIBEFDCPGD, IBIDBCAPHMG HHEDADBLDNA, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x311C650", Offset = "0x311BA50", VA = "0x18311C650")]
	[AsyncStateMachine(typeof(HNBNLKKJBGA))]
	private Task MNCJDIJMCLC(HBMEPODFBHF ONIBEFDCPGD, IBIDBCAPHMG HHEDADBLDNA, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x311B940", Offset = "0x311AD40", VA = "0x18311B940")]
	[AsyncStateMachine(typeof(CNLBPDKFPDP))]
	private Task ACDGJAGMDLO(HBMEPODFBHF ONIBEFDCPGD, IBIDBCAPHMG HHEDADBLDNA, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x311BAA0", Offset = "0x311AEA0", VA = "0x18311BAA0")]
	[AsyncStateMachine(typeof(HHHHIOPONLO))]
	private Task AEHBADCIIIF(Guid OJJCPPOPDKA, List<FIDOEHJLJBB> AMONLPNCMKM, DGPNIDHPEME MELEJKEOLGM, HBMEPODFBHF ONIBEFDCPGD, CancellationToken AJDBKDIMOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x311C500", Offset = "0x311B900", VA = "0x18311C500")]
	[AsyncStateMachine(typeof(MJIPLOADELH))]
	private Task MFMNLODEJII(HBMEPODFBHF ONIBEFDCPGD, IBIDBCAPHMG HHEDADBLDNA, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x311C910", Offset = "0x311BD10", VA = "0x18311C910")]
	[AsyncStateMachine(typeof(JBIMEAEMDCE))]
	private Task ODGHMNAHDCJ(Guid NLHCGEAIIPI, HBMEPODFBHF ONIBEFDCPGD, IBIDBCAPHMG HHEDADBLDNA, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x311BF10", Offset = "0x311B310", VA = "0x18311BF10")]
	[AsyncStateMachine(typeof(IKBHEEEDJGB))]
	private Task CAJLOBJAGEC(Guid NLHCGEAIIPI, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x311C190", Offset = "0x311B590", VA = "0x18311C190")]
	private void HMLFGGPMEBE(Guid NLHCGEAIIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x311C060", Offset = "0x311B460", VA = "0x18311C060")]
	private void EFDMMELAGFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x311C330", Offset = "0x311B730", VA = "0x18311C330")]
	public Guid LDANOBNCKBD(ADBPAACHPEK LGEIJNPFKKO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x311BD40", Offset = "0x311B140", VA = "0x18311BD40")]
	[CompilerGenerated]
	private object BNLNMKNFGBO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
public readonly struct PNGJOFGNDJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	[CanBeNull]
	public readonly ALJFOENJMIN DCACFIFNINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	[NotNull]
	public readonly HJMENAOAHNM BPMJNAAIDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	[CanBeNull]
	public readonly string BEGKPCNPKGK;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public IReadOnlyCollection<string> IKNKGAJONFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x3A8A4D0", Offset = "0x3A898D0", VA = "0x183A8A4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public IReadOnlyDictionary<long, int> KJIEKMOGDBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x3A8A4B0", Offset = "0x3A898B0", VA = "0x183A8A4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A4F0", Offset = "0x3A898F0", VA = "0x183A8A4F0")]
	public PNGJOFGNDJG([CanBeNull] ALJFOENJMIN GDKBHGNBDKI, [NotNull] HJMENAOAHNM KLFEHFPCPLE, [CanBeNull] string IDBLHDFAAFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal class MECBAEJOJKA : OFDEKMCOBBC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct ALNMGNFDJNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public AsyncTaskMethodBuilder<PNGJOFGNDJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public MECBAEJOJKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public CALEGKJDHNB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x4018700", Offset = "0x4017B00", VA = "0x184018700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x4018BA0", Offset = "0x4017FA0", VA = "0x184018BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private sealed class MFFFAHOKMJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public CALEGKJDHNB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public MFFFAHOKMJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x4029460", Offset = "0x4028860", VA = "0x184029460")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class KMBOHNMIPOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public MFFFAHOKMJC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public KMBOHNMIPOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x4027E90", Offset = "0x4027290", VA = "0x184027E90")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class DHMMBAEAOHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public MFFFAHOKMJC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public DHMMBAEAOHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x401D780", Offset = "0x401CB80", VA = "0x18401D780")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct FBEILHCFMPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public CALEGKJDHNB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public MECBAEJOJKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private KMBOHNMIPOM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private HAGOEFHIFEI.MICLJBEPDMF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x4020420", Offset = "0x401F820", VA = "0x184020420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	private readonly MCIFGLAOFBP PBFKDCHNBGG;

	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	private static readonly TimeSpan DJDPBBJDJBL;

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x3131BF0", Offset = "0x3130FF0", VA = "0x183131BF0")]
	public MECBAEJOJKA(MFMLJGKBCFN EFLDCPJPINN, [Optional] MCIFGLAOFBP? PBFKDCHNBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x3130C90", Offset = "0x3130090", VA = "0x183130C90")]
	[AsyncStateMachine(typeof(ALNMGNFDJNH))]
	public Task<PNGJOFGNDJG> LMGAKHPBOLH(long KFGNOJDEOOA, string IDBLHDFAAFE, CALEGKJDHNB FLJHFLFCMAB, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x3131A20", Offset = "0x3130E20", VA = "0x183131A20")]
	[AsyncStateMachine(typeof(FBEILHCFMPK))]
	private Task OKDDABFJJKH(CALEGKJDHNB FLJHFLFCMAB, IEnumerable<PersistenceView> FKHOPLFFPFG, StringBuilder CAKBPBJGHOG, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x3131330", Offset = "0x3130730", VA = "0x183131330")]
	private PNGJOFGNDJG MDHNKHNJMJI(long KFGNOJDEOOA, string IDBLHDFAAFE, CALEGKJDHNB FLJHFLFCMAB, IEnumerable<PersistenceView> FKHOPLFFPFG, StringBuilder CAKBPBJGHOG)
	{
		return default(PNGJOFGNDJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x31318B0", Offset = "0x3130CB0", VA = "0x1831318B0")]
	private ALJFOENJMIN NJKHONNPNJN(long KFGNOJDEOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x3130A70", Offset = "0x312FE70", VA = "0x183130A70")]
	private void HKLEHNJJELE(ALJFOENJMIN ALCHMIAHOOM, StringBuilder CAKBPBJGHOG, IEnumerable<PersistenceView> FKHOPLFFPFG, in MIFBNDKINNO MNKFJJIHAAE, ref OFOCKNJFHCC OMNCAEMBDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x3130E10", Offset = "0x3130210", VA = "0x183130E10")]
	private void LPJEMJPGEIH(ALJFOENJMIN ALCHMIAHOOM, StringBuilder CAKBPBJGHOG, PersistenceView CHOBEAJIPKF, ref OFOCKNJFHCC OMNCAEMBDJJ, in MIFBNDKINNO MNKFJJIHAAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal class MJGKPFMGAPI : OFDEKMCOBBC
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class MHCIMBPLBFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public ENBONPHDNAF.KEKNDACMKEB roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public ENBONPHDNAF.KEKNDACMKEB subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public MHCIMBPLBFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x45D60D0", Offset = "0x45D54D0", VA = "0x1845D60D0")]
		internal object <UploadRoomDataToStorage>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x45D6160", Offset = "0x45D5560", VA = "0x1845D6160")]
		internal object <UploadRoomDataToStorage>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x45D61B0", Offset = "0x45D55B0", VA = "0x1845D61B0")]
		internal object <UploadRoomDataToStorage>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x45D6220", Offset = "0x45D5620", VA = "0x1845D6220")]
		internal object <UploadRoomDataToStorage>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct CBHIJABCDAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public AsyncTaskMethodBuilder<(ENBONPHDNAF.KEKNDACMKEB roomDataUpload, ENBONPHDNAF.KEKNDACMKEB subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public PNGJOFGNDJG roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public MJGKPFMGAPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private MHCIMBPLBFM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private TaskAwaiter<ENBONPHDNAF.KEKNDACMKEB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x45CDBB0", Offset = "0x45CCFB0", VA = "0x1845CDBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x45CE650", Offset = "0x45CDA50", VA = "0x1845CE650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct ANBILDCKPIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public AsyncTaskMethodBuilder<OCDLNECLLKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public MJGKPFMGAPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public PNGJOFGNDJG roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public MNCEMDCIACF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter<(ENBONPHDNAF.KEKNDACMKEB roomDataUpload, ENBONPHDNAF.KEKNDACMKEB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private TaskAwaiter<OCDLNECLLKD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x45CD1C0", Offset = "0x45CC5C0", VA = "0x1845CD1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x45CD680", Offset = "0x45CCA80", VA = "0x1845CD680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct DOHFJKJIFJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public AsyncTaskMethodBuilder<AOJPNBHMMII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public MJGKPFMGAPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public PNGJOFGNDJG roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private TaskAwaiter<(ENBONPHDNAF.KEKNDACMKEB roomDataUpload, ENBONPHDNAF.KEKNDACMKEB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private TaskAwaiter<AOJPNBHMMII> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x45CF7D0", Offset = "0x45CEBD0", VA = "0x1845CF7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x45CFB60", Offset = "0x45CEF60", VA = "0x1845CFB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class ALIOBALNJCD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000623")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000624")]
			public AsyncTaskMethodBuilder<PLBGOAPJHAI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000625")]
			public ALIOBALNJCD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000626")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000627")]
			private PLBGOAPJHAI <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000628")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000629")]
			private TaskAwaiter<AOJPNBHMMII> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400062A")]
			private TaskAwaiter<OCDLNECLLKD> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400062B")]
			private TaskAwaiter<PLBGOAPJHAI> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x45DCBA0", Offset = "0x45DBFA0", VA = "0x1845DCBA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x45DD6C0", Offset = "0x45DCAC0", VA = "0x1845DD6C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public MJGKPFMGAPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public PNGJOFGNDJG roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public MNCEMDCIACF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ALIOBALNJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x45CD080", Offset = "0x45CC480", VA = "0x1845CD080")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<PLBGOAPJHAI> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct CDEGDGIKGJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public AsyncTaskMethodBuilder<PLBGOAPJHAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public MJGKPFMGAPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public PNGJOFGNDJG roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public MNCEMDCIACF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private TaskAwaiter<PLBGOAPJHAI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x45CE6A0", Offset = "0x45CDAA0", VA = "0x1845CE6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x45CE950", Offset = "0x45CDD50", VA = "0x1845CE950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private const float EHKCPLKMNIB = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private readonly EBAJLFIGJKG KMECCPGKJOB;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private JMNCFHIJLAL MDHFAHDNFLN
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x3134020", Offset = "0x3133420", VA = "0x183134020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x31365A0", Offset = "0x31359A0", VA = "0x1831365A0")]
	public MJGKPFMGAPI(MFMLJGKBCFN EFLDCPJPINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x3136430", Offset = "0x3135830", VA = "0x183136430")]
	[AsyncStateMachine(typeof(CBHIJABCDAH))]
	private Task<(ENBONPHDNAF.KEKNDACMKEB, ENBONPHDNAF.KEKNDACMKEB)> FFCEHNNPLND(PNGJOFGNDJG LLGBGHFCOLE, long LLDIIOOAFHI, long ADPAGPHKENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x31362A0", Offset = "0x31356A0", VA = "0x1831362A0")]
	[AsyncStateMachine(typeof(ANBILDCKPIB))]
	public Task<OCDLNECLLKD> BPLKDIEMEGC(int DJCINABOACI, [CanBeNull] MNCEMDCIACF NEGDKGFCMAH, PNGJOFGNDJG LLGBGHFCOLE, long LLDIIOOAFHI, long ADPAGPHKENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x3135F60", Offset = "0x3135360", VA = "0x183135F60")]
	[AsyncStateMachine(typeof(DOHFJKJIFJF))]
	private Task<AOJPNBHMMII> BJBAKIFGOPJ(string MILFEKOPFBC, int DJCINABOACI, PNGJOFGNDJG LLGBGHFCOLE, long LLDIIOOAFHI, long ADPAGPHKENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x31360F0", Offset = "0x31354F0", VA = "0x1831360F0")]
	[AsyncStateMachine(typeof(CDEGDGIKGJA))]
	public Task<PLBGOAPJHAI> BOMNDGKIAHF(int DJCINABOACI, [CanBeNull] MNCEMDCIACF NEGDKGFCMAH, PNGJOFGNDJG LLGBGHFCOLE, long LLDIIOOAFHI, long ADPAGPHKENF, IBIDBCAPHMG KIBJDNPFMAF, CancellationToken OLHHOODBFDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
public abstract class JIPIKLAMCDA<T> where T : global::JIPIKLAMCDA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000637")]
	internal readonly JMNCFHIJLAL BNDHAGFCPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000638")]
	private int? BKAPPMOFLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000639")]
	protected readonly Guid CEFEFFDEHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400063A")]
	protected readonly LBJBELAPCEL MBAHBFCHMHD;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	protected T KAPGMJAKHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x3EA0F90", Offset = "0x3EA0390", VA = "0x183EA0F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x3EA10F0", Offset = "0x3EA04F0", VA = "0x183EA10F0")]
	internal JIPIKLAMCDA(JMNCFHIJLAL CGKAJGLCPCB, LBJBELAPCEL ENHFFKPEKCH, [Optional] Guid? OMEAOMOIGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0EB0", Offset = "0x3EA02B0", VA = "0x183EA0EB0")]
	private PLBGOAPJHAI GDIEAJDLEDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "4")]
	protected virtual void CFOECDBECIF(PLBGOAPJHAI DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0DA0", Offset = "0x3EA01A0", VA = "0x183EA0DA0")]
	public T BFHANPECPAI(KPNOOPGJEKD OCNINCAELAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0E30", Offset = "0x3EA0230", VA = "0x183EA0E30")]
	public T FBDNGKLCHDP(int OOOMBAPEHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0FF0", Offset = "0x3EA03F0", VA = "0x183EA0FF0", Slot = "5")]
	public virtual Task<BCGEGHGDJPI> PLMINPIEJCD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
public class LOJLPLPIAGN : global::JIPIKLAMCDA<LOJLPLPIAGN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	private GKIAAKPIFKA KBGLHNCEHFF;

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x312FA10", Offset = "0x312EE10", VA = "0x18312FA10")]
	internal LOJLPLPIAGN(JMNCFHIJLAL CGKAJGLCPCB, LBJBELAPCEL ENHFFKPEKCH, [Optional] Guid? OMEAOMOIGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x312F9F0", Offset = "0x312EDF0", VA = "0x18312F9F0")]
	public LOJLPLPIAGN NNBLBNPMIDI(GKIAAKPIFKA KBGLHNCEHFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x312F930", Offset = "0x312ED30", VA = "0x18312F930", Slot = "4")]
	protected override void CFOECDBECIF(PLBGOAPJHAI DENPJAMCNLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public class ALBEPCFBDLD : global::JIPIKLAMCDA<ALBEPCFBDLD>
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	internal enum PKOAGJBEEAN
	{
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct JMCGGIMHFON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public AsyncTaskMethodBuilder<BCGEGHGDJPI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public ALBEPCFBDLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private TaskAwaiter<BCGEGHGDJPI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x3A79760", Offset = "0x3A78B60", VA = "0x183A79760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x3A79A60", Offset = "0x3A78E60", VA = "0x183A79A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400063C")]
	private PKOAGJBEEAN DJIKDBJMPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400063D")]
	private string MCPJPPEPKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400063E")]
	private MNCEMDCIACF KBGLHNCEHFF;

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x3118830", Offset = "0x3117C30", VA = "0x183118830")]
	internal ALBEPCFBDLD(JMNCFHIJLAL CGKAJGLCPCB, LBJBELAPCEL ENHFFKPEKCH, [Optional] Guid? OMEAOMOIGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x3118680", Offset = "0x3117A80", VA = "0x183118680")]
	public ALBEPCFBDLD HMKBNNECEHM(string HDOFKOFNOIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x31186F0", Offset = "0x3117AF0", VA = "0x1831186F0")]
	public ALBEPCFBDLD MFGCPHJFNOE(bool JBGBLDHMDNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x3118650", Offset = "0x3117A50", VA = "0x183118650")]
	public ALBEPCFBDLD GJKIMKGIKGA(string BENGLHDIHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x3118620", Offset = "0x3117A20", VA = "0x183118620")]
	public ALBEPCFBDLD DJEFBCFEHHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x31184B0", Offset = "0x31178B0", VA = "0x1831184B0", Slot = "4")]
	protected override void CFOECDBECIF(PLBGOAPJHAI DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x3118710", Offset = "0x3117B10", VA = "0x183118710", Slot = "5")]
	[AsyncStateMachine(typeof(JMCGGIMHFON))]
	public override Task<BCGEGHGDJPI> PLMINPIEJCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x31186B0", Offset = "0x3117AB0", VA = "0x1831186B0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<BCGEGHGDJPI> IKEKHDCLENA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal static class HFPLDKCBODJ
{
	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x3127B60", Offset = "0x3126F60", VA = "0x183127B60")]
	public static void GIIDEFJNFOL(this GNFMLPKABNA OAPDCHADOAF, IDJHFGEEFAO MBOKGPBFEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x3127A80", Offset = "0x3126E80", VA = "0x183127A80")]
	public static void AOIJHDDHLLK(this IDJHFGEEFAO GBJGFACLOGD, [Optional] string DENPJAMCNLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public static class AGACMMKENJM
{
	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x31160C0", Offset = "0x31154C0", VA = "0x1831160C0")]
	public static AKFPGEDHNIP DBLCNFPDEFN(this NCNOCDPKPJA LFJPDDCPGGF)
	{
		return default(AKFPGEDHNIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x3116160", Offset = "0x3115560", VA = "0x183116160")]
	public static NCNOCDPKPJA HJDKOGMFBHA(this AKFPGEDHNIP KGCGKHACAAH)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CreateAssetMenu]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200017A")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400064B")]
			public KGOBOGAGHPL ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400064C")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400064D")]
			public KGOBOGAGHPL HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400064E")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400064F")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000650")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private static KGOBOGAGHPL[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private Dictionary<KGOBOGAGHPL, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x3A8A8D0", Offset = "0x3A89CD0", VA = "0x183A8A8D0")]
		public bool BODCPLNPJMF(KGOBOGAGHPL FDKDECGDDJM, out ResultConfig HPHLIJIBJEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x3A8A940", Offset = "0x3A89D40", VA = "0x183A8A940")]
		public ResultConfig OBDHLKLPDKP(KGOBOGAGHPL EBBINHBEDJD, [Optional] HashSet<KGOBOGAGHPL> ABENBCKDHLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x3A8AFE0", Offset = "0x3A8A3E0", VA = "0x183A8AFE0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x3A8AA60", Offset = "0x3A89E60", VA = "0x183A8AA60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x7681E0", Offset = "0x7675E0", VA = "0x1807681E0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
public static class KPEFKGPGGJD
{
	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x312F370", Offset = "0x312E770", VA = "0x18312F370")]
	[ELNMOMKNGKB(LBAHANGFDMJ.GameOnly)]
	private static void DPKBCOEJEKN(LECENBDGBAK FHGLCNOGDKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
public interface HJHFIAECAFN : IEquatable<HJHFIAECAFN>
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	PHNADBBFEOJ PBHEJDFBJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	DateTime KEHCAOKJDFA
	{
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GOFMAIADJEA();

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GIEGHPHLHHO(long LLDIIOOAFHI, long KFGNOJDEOOA, out PNGJOFGNDJG LLGBGHFCOLE);
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class PJFGAMPKNBB : JMGMCBCMGOO
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class CJHAJBKFJDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public ALDHOJLECOH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public CJHAJBKFJDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x45CE9A0", Offset = "0x45CDDA0", VA = "0x1845CE9A0")]
		internal object <TrySaveAutosaveData>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private readonly BLDLAAPONMP MIIIEAPECPI;

	[Cpp2IlInjected.Token(Token = "0x4000657")]
	private const int DJPKEJPCHHL = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event Action<HJHFIAECAFN> ECMAEACLGHL
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x3A89760", Offset = "0x3A88B60", VA = "0x183A89760", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x3A89A70", Offset = "0x3A88E70", VA = "0x183A89A70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x7803F0", Offset = "0x77F7F0", VA = "0x1807803F0")]
	[UnityEngine.Scripting.Preserve]
	public PJFGAMPKNBB([CNHALHMHHIC(null)] BLDLAAPONMP MIIIEAPECPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x3A89400", Offset = "0x3A88800", VA = "0x183A89400", Slot = "6")]
	public bool DKPCFFKNCOM(long LLDIIOOAFHI, long KFGNOJDEOOA, PNGJOFGNDJG LLGBGHFCOLE, ALDHOJLECOH KJHAOKNAKMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x3A899D0", Offset = "0x3A88DD0", VA = "0x183A899D0")]
	private void KPHGFDAOKGN(HJHFIAECAFN GNJIELOFDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x3A89280", Offset = "0x3A88680", VA = "0x183A89280", Slot = "7")]
	public bool ALBHPMCNOOH(long LLDIIOOAFHI, long KFGNOJDEOOA, out HJHFIAECAFN EKDFAKLJBGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x3A89800", Offset = "0x3A88C00", VA = "0x183A89800", Slot = "8")]
	public bool IJBDFMJGIJC(long LLDIIOOAFHI, long KFGNOJDEOOA, ALDHOJLECOH KJHAOKNAKMN, out HJHFIAECAFN EKDFAKLJBGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x3A89B10", Offset = "0x3A88F10", VA = "0x183A89B10")]
	private void OPDHNGBEJLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x3A898B0", Offset = "0x3A88CB0", VA = "0x183A898B0", Slot = "9")]
	public void JPCJDMCCHPO(long LLDIIOOAFHI, long KFGNOJDEOOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal abstract class EKBAPFHBFBJ : BLDLAAPONMP
{
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	protected enum BFGNOKIKGEH : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class PBFAKJACDKM : IEnumerable<HJHFIAECAFN>, IEnumerable, IEnumerator<HJHFIAECAFN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private HJHFIAECAFN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public EKBAPFHBFBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private ALDHOJLECOH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public ALDHOJLECOH <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		private HJHFIAECAFN System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x75EDA0", Offset = "0x75E1A0", VA = "0x18075EDA0")]
		[DebuggerHidden]
		public PBFAKJACDKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x3A86600", Offset = "0x3A85A00", VA = "0x183A86600", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x3A86810", Offset = "0x3A85C10", VA = "0x183A86810", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x3A86760", Offset = "0x3A85B60", VA = "0x183A86760", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HJHFIAECAFN> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x3A86760", Offset = "0x3A85B60", VA = "0x183A86760", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class DACOHGNEEBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public ALDHOJLECOH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public DACOHGNEEBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x3A72940", Offset = "0x3A71D40", VA = "0x183A72940")]
		internal object <SaveAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private sealed class DEDJKLHGKBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public EKBAPFHBFBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public DEDJKLHGKBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x3A729D0", Offset = "0x3A71DD0", VA = "0x183A729D0")]
		internal void <TryReadAutosaveFile>b__0(KPNBNOAAALL.ILCAIPCPCBJ ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400065D")]
	protected readonly string JEKKBHLEMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400065E")]
	private readonly object MPJNININJCC;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract PHNADBBFEOJ PBHEJDFBJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x3120690", Offset = "0x311FA90", VA = "0x183120690")]
	protected EKBAPFHBFBJ([CanBeNull] string DHENHGGPKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x311FDC0", Offset = "0x311F1C0", VA = "0x18311FDC0", Slot = "5")]
	public bool AGIBKHGFDAP(long LLDIIOOAFHI, long KFGNOJDEOOA, ALDHOJLECOH KJHAOKNAKMN, out HJHFIAECAFN GNJIELOFDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x311FFA0", Offset = "0x311F3A0", VA = "0x18311FFA0", Slot = "6")]
	[IteratorStateMachine(typeof(PBFAKJACDKM))]
	public IEnumerable<HJHFIAECAFN> FHLDHKACBDP(ALDHOJLECOH KJHAOKNAKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void OBNFJCOPHGE(Stream LEAJGHOFECD, long LLDIIOOAFHI, long KFGNOJDEOOA, PNGJOFGNDJG LLGBGHFCOLE);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool OFDJIDLPLLN(Stream MKLJLDBHLPJ, long LLDIIOOAFHI, long KFGNOJDEOOA, DCEFICIPGGF BLDELCGAFPP, out PNGJOFGNDJG LLGBGHFCOLE);

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x3120090", Offset = "0x311F490", VA = "0x183120090", Slot = "7")]
	public HJHFIAECAFN IFMAFJNAEFI(long LLDIIOOAFHI, long KFGNOJDEOOA, PNGJOFGNDJG LLGBGHFCOLE, ALDHOJLECOH KJHAOKNAKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo DMCENIJIJBP(long LLDIIOOAFHI, long KFGNOJDEOOA, ALDHOJLECOH KJHAOKNAKMN, BFGNOKIKGEH PNDOHGJABDO);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo PKOMIBCOBAH(ALDHOJLECOH KJHAOKNAKMN, BFGNOKIKGEH PNDOHGJABDO);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x3120020", Offset = "0x311F420", VA = "0x183120020")]
	protected void GGLJAMHOFNE(KPNBNOAAALL.ILCAIPCPCBJ BPGOMEHPKHH, string HKGFIHMBIEF, FileInfo EPMHFOMBHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x31203E0", Offset = "0x311F7E0", VA = "0x1831203E0")]
	internal bool NJGLGACJGPO(FileInfo JHKPOCOBPEI, long LLDIIOOAFHI, long KFGNOJDEOOA, out PNGJOFGNDJG LLGBGHFCOLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	private void FKJKJCKFFHP(Exception KODHGAIEAOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal class INKLODHOOCD : EKBAPFHBFBJ
{
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private const string EFCKFJOOLIK = "V2";

	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private const string CKKENKPBBJH = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x4000670")]
	private const string BPFAJKGEEMK = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public override PHNADBBFEOJ PBHEJDFBJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x1C6D3C0", Offset = "0x1C6C7C0", VA = "0x181C6D3C0", Slot = "8")]
		get
		{
			return default(PHNADBBFEOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x312C740", Offset = "0x312BB40", VA = "0x18312C740")]
	public INKLODHOOCD([Optional] string DHENHGGPKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x312BF30", Offset = "0x312B330", VA = "0x18312BF30")]
	private void NIMFDLLEAPP(ALDHOJLECOH KJHAOKNAKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x312BFB0", Offset = "0x312B3B0", VA = "0x18312BFB0", Slot = "9")]
	internal override void OBNFJCOPHGE(Stream LEAJGHOFECD, long LLDIIOOAFHI, long KFGNOJDEOOA, PNGJOFGNDJG LLGBGHFCOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x312C1C0", Offset = "0x312B5C0", VA = "0x18312C1C0", Slot = "10")]
	internal override bool OFDJIDLPLLN(Stream MKLJLDBHLPJ, long LLDIIOOAFHI, long KFGNOJDEOOA, DCEFICIPGGF BLDELCGAFPP, out PNGJOFGNDJG LLGBGHFCOLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x312BE40", Offset = "0x312B240", VA = "0x18312BE40", Slot = "11")]
	protected override FileInfo DMCENIJIJBP(long LLDIIOOAFHI, long KFGNOJDEOOA, ALDHOJLECOH KJHAOKNAKMN, BFGNOKIKGEH PNDOHGJABDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x312C630", Offset = "0x312BA30", VA = "0x18312C630", Slot = "12")]
	protected override DirectoryInfo PKOMIBCOBAH(ALDHOJLECOH KJHAOKNAKMN, BFGNOKIKGEH PNDOHGJABDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal sealed class GPMPACIOIDO : EKBAPFHBFBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private static readonly byte[] EBOEHIFNNLM;

	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private const string CKKENKPBBJH = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private const string BPFAJKGEEMK = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private const string NKDHHJLNPCM = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	private readonly byte[] IGKOFELOOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	private readonly byte[] FIGDAAGLFCL;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public override PHNADBBFEOJ PBHEJDFBJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0xA56830", Offset = "0xA55C30", VA = "0x180A56830", Slot = "8")]
		get
		{
			return default(PHNADBBFEOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x3126220", Offset = "0x3125620", VA = "0x183126220")]
	public GPMPACIOIDO([Optional] string DHENHGGPKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x3125790", Offset = "0x3124B90", VA = "0x183125790", Slot = "9")]
	internal override void OBNFJCOPHGE(Stream LEAJGHOFECD, long LLDIIOOAFHI, long KFGNOJDEOOA, PNGJOFGNDJG LLGBGHFCOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x31259F0", Offset = "0x3124DF0", VA = "0x1831259F0", Slot = "10")]
	internal override bool OFDJIDLPLLN(Stream MKLJLDBHLPJ, long LLDIIOOAFHI, long KFGNOJDEOOA, DCEFICIPGGF BLDELCGAFPP, out PNGJOFGNDJG LLGBGHFCOLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x3125680", Offset = "0x3124A80", VA = "0x183125680")]
	private void IACDOGOMLCM(byte[] NPNCGJAPKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x3125550", Offset = "0x3124950", VA = "0x183125550", Slot = "11")]
	protected override FileInfo DMCENIJIJBP(long LLDIIOOAFHI, long KFGNOJDEOOA, ALDHOJLECOH KJHAOKNAKMN, BFGNOKIKGEH PNDOHGJABDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x3126080", Offset = "0x3125480", VA = "0x183126080", Slot = "12")]
	protected override DirectoryInfo PKOMIBCOBAH(ALDHOJLECOH KJHAOKNAKMN, BFGNOKIKGEH PNDOHGJABDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
public enum PHNADBBFEOJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000679")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal class JOLHGNDAMON : BLDLAAPONMP
{
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class BICEFJFMMAP : IEnumerable<HJHFIAECAFN>, IEnumerable, IEnumerator<HJHFIAECAFN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private HJHFIAECAFN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public JOLHGNDAMON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private ALDHOJLECOH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public ALDHOJLECOH <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private PHNADBBFEOJ[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private IEnumerator<HJHFIAECAFN> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		private HJHFIAECAFN System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x75EDA0", Offset = "0x75E1A0", VA = "0x18075EDA0")]
		[DebuggerHidden]
		public BICEFJFMMAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x401AAB0", Offset = "0x4019EB0", VA = "0x18401AAB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x401A6E0", Offset = "0x4019AE0", VA = "0x18401A6E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x401AB40", Offset = "0x4019F40", VA = "0x18401AB40")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x401AA70", Offset = "0x4019E70", VA = "0x18401AA70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x401A9C0", Offset = "0x4019DC0", VA = "0x18401A9C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HJHFIAECAFN> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x401A9C0", Offset = "0x4019DC0", VA = "0x18401A9C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400067B")]
	private readonly PHNADBBFEOJ[] BKPKECBKEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400067C")]
	private readonly Dictionary<PHNADBBFEOJ, BLDLAAPONMP> JPIHJDPCLGD;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public PHNADBBFEOJ PBHEJDFBJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x312D040", Offset = "0x312C440", VA = "0x18312D040", Slot = "4")]
		get
		{
			return default(PHNADBBFEOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x312D080", Offset = "0x312C480", VA = "0x18312D080")]
	[UnityEngine.Scripting.Preserve]
	public JOLHGNDAMON(params BLDLAAPONMP[] FOLMGGFLJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x312CAD0", Offset = "0x312BED0", VA = "0x18312CAD0", Slot = "5")]
	public bool AGIBKHGFDAP(long LLDIIOOAFHI, long KFGNOJDEOOA, ALDHOJLECOH KJHAOKNAKMN, out HJHFIAECAFN GNJIELOFDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x312CC30", Offset = "0x312C030", VA = "0x18312CC30")]
	private void EKCOOPANLBJ(int OFILLJFJAFA, long LLDIIOOAFHI, long KFGNOJDEOOA, ALDHOJLECOH KJHAOKNAKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x312CE60", Offset = "0x312C260", VA = "0x18312CE60", Slot = "6")]
	[IteratorStateMachine(typeof(BICEFJFMMAP))]
	public IEnumerable<HJHFIAECAFN> FHLDHKACBDP(ALDHOJLECOH KJHAOKNAKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x312CEE0", Offset = "0x312C2E0", VA = "0x18312CEE0", Slot = "7")]
	public HJHFIAECAFN IFMAFJNAEFI(long LLDIIOOAFHI, long KFGNOJDEOOA, PNGJOFGNDJG LLGBGHFCOLE, ALDHOJLECOH KJHAOKNAKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
internal static class PMPPGBAJLFF
{
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	internal const int NAGDGIJPEEP = 32;

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A410", Offset = "0x3A89810", VA = "0x183A8A410")]
	internal static byte[] PGADAOEHNBD(byte[] NPNCGJAPKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A390", Offset = "0x3A89790", VA = "0x183A8A390")]
	public static void HBKHBOLCJDC(Stream DMEDBCCHBBH, byte[] INCJAMHFFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A1B0", Offset = "0x3A895B0", VA = "0x183A8A1B0")]
	public static bool FGEGEAKOEFG(Stream DMEDBCCHBBH, long AGKAODCKODO, DCEFICIPGGF HJKADNJGGCK, out byte[] JONAECIFELP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
internal sealed class FEGGKOEAMKE : HJHFIAECAFN, IEquatable<HJHFIAECAFN>, IEquatable<FEGGKOEAMKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	private readonly EKBAPFHBFBJ ODAOECILILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	public readonly FileInfo IOANLILEJEM;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public PHNADBBFEOJ PBHEJDFBJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x1031CF0", Offset = "0x10310F0", VA = "0x181031CF0", Slot = "4")]
		get
		{
			return default(PHNADBBFEOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public DateTime KEHCAOKJDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x3121A20", Offset = "0x3120E20", VA = "0x183121A20", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x3121FA0", Offset = "0x31213A0", VA = "0x183121FA0")]
	public FEGGKOEAMKE(EKBAPFHBFBJ LOHPIMNIJBM, FileInfo JHKPOCOBPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x3121EF0", Offset = "0x31212F0", VA = "0x183121EF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x3121D90", Offset = "0x3121190", VA = "0x183121D90", Slot = "6")]
	public void GOFMAIADJEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x3121D50", Offset = "0x3121150", VA = "0x183121D50", Slot = "7")]
	public bool GIEGHPHLHHO(long LLDIIOOAFHI, long KFGNOJDEOOA, out PNGJOFGNDJG LLGBGHFCOLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x3121C70", Offset = "0x3121070", VA = "0x183121C70", Slot = "8")]
	public bool Equals(HJHFIAECAFN IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x3121BC0", Offset = "0x3120FC0", VA = "0x183121BC0", Slot = "9")]
	public bool Equals(FEGGKOEAMKE IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x3121AC0", Offset = "0x3120EC0", VA = "0x183121AC0", Slot = "0")]
	public override bool Equals(object ADHHHFDPAPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x3121E50", Offset = "0x3121250", VA = "0x183121E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x261FB40", Offset = "0x261EF40", VA = "0x18261FB40")]
	public static bool GJOJIEKGOHO(FEGGKOEAMKE KOBPJIJCFOM, FEGGKOEAMKE PLEGOCBOLDH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x261F7B0", Offset = "0x261EBB0", VA = "0x18261F7B0")]
	public static bool ALCENKEOHOJ(FEGGKOEAMKE KOBPJIJCFOM, FEGGKOEAMKE PLEGOCBOLDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public delegate void DCEFICIPGGF(KPNBNOAAALL.ILCAIPCPCBJ AKIBCJPKHBN, string DENPJAMCNLD);
[Cpp2IlInjected.Token(Token = "0x200018F")]
internal interface BLDLAAPONMP
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	PHNADBBFEOJ PBHEJDFBJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AGIBKHGFDAP(long LLDIIOOAFHI, long KFGNOJDEOOA, ALDHOJLECOH KJHAOKNAKMN, out HJHFIAECAFN GNJIELOFDMK);

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<HJHFIAECAFN> FHLDHKACBDP(ALDHOJLECOH KJHAOKNAKMN);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HJHFIAECAFN IFMAFJNAEFI(long LLDIIOOAFHI, long KFGNOJDEOOA, PNGJOFGNDJG LLGBGHFCOLE, ALDHOJLECOH KJHAOKNAKMN);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000192")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x400068E")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x400068F")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x4000690")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x4000691")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x311F790", Offset = "0x311EB90", VA = "0x18311F790")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x311F8A0", Offset = "0x311ECA0", VA = "0x18311F8A0")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000194")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000692")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
	}
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
