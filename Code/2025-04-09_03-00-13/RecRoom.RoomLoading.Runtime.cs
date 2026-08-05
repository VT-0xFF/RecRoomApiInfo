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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x808B360", Offset = "0x808A760", VA = "0x18808B360")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
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
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8086BC0", Offset = "0x8085FC0", VA = "0x188086BC0", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x808E560", Offset = "0x808D960", VA = "0x18808E560", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2553680", Offset = "0x2552A80", VA = "0x182553680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ELPHMIPMMBG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x80784E0", Offset = "0x80778E0", VA = "0x1880784E0")]
	public ELPHMIPMMBG(string DAMFJFKKFBI, Exception HIFFMIIALED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class CLIKLOFCPNB : ECFFCCGLHEI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct JKOLKMGLEBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<DOIHDMEMACP>> <>t__builder;

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
		private TaskAwaiter<KAGJDIGADOF<GKGFGBABKAH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x807E8B0", Offset = "0x807DCB0", VA = "0x18807E8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x807EAF0", Offset = "0x807DEF0", VA = "0x18807EAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct MBAKHHEKCNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<AJJLICNNELL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<AJJLICNNELL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8086EF0", Offset = "0x80862F0", VA = "0x188086EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8087100", Offset = "0x8086500", VA = "0x188087100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	[UnityEngine.Scripting.Preserve]
	public CLIKLOFCPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8075030", Offset = "0x8074430", VA = "0x188075030", Slot = "4")]
	[AsyncStateMachine(typeof(JKOLKMGLEBL))]
	public Task<IReadOnlyList<DOIHDMEMACP>> ILGKCPDGOMI(long MIFADOBCMAC, long OFAOCKBMEGP, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8074F20", Offset = "0x8074320", VA = "0x188074F20", Slot = "5")]
	[AsyncStateMachine(typeof(MBAKHHEKCNI))]
	public Task<IReadOnlyList<AJJLICNNELL>> EPMDDLAGKPK(IReadOnlyList<int> DICFOOJFCLC, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DAJAGKGMOOD : IEquatable<DAJAGKGMOOD>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int LEKLJPAJDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	AJJLICNNELL BDMAPALGGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime JCJPNALPAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	OOJNNNOJHED? OOCJICNBMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BIHJBMEMEFM? PFJPBHMPNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	ICKIEKLPHFL NCKFBDDEPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<OGJPCDKPGHL> LLEMIBHBCFA();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum ICKIEKLPHFL
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ECFFCCGLHEI
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<DOIHDMEMACP>> ILGKCPDGOMI(long MIFADOBCMAC, long OFAOCKBMEGP, [Optional] CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<AJJLICNNELL>> EPMDDLAGKPK(IReadOnlyList<int> DICFOOJFCLC, [Optional] CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EHOOGGNDLCC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class DIILAMFBMEO : DAJAGKGMOOD, IEquatable<DAJAGKGMOOD>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct JCGFDGLDJKO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<OGJPCDKPGHL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public DIILAMFBMEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private LGIJHFEOCEK <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<IBBAMKLHGAN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<OGJPCDKPGHL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x807E2C0", Offset = "0x807D6C0", VA = "0x18807E2C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x807E840", Offset = "0x807DC40", VA = "0x18807E840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly DOIHDMEMACP IFHCDCGLJIA;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int LEKLJPAJDCD
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9AE430", Offset = "0x9AD830", VA = "0x1809AE430", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AJJLICNNELL BDMAPALGGCL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime DCJBDBIDEIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8075CE0", Offset = "0x80750E0", VA = "0x188075CE0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OOJNNNOJHED? OOCJICNBMGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x69950B0", Offset = "0x69944B0", VA = "0x1869950B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public BIHJBMEMEFM? PFJPBHMPNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2895730", Offset = "0x2894B30", VA = "0x182895730", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ICKIEKLPHFL NCKFBDDEPAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB232D0", Offset = "0xB226D0", VA = "0x180B232D0", Slot = "10")]
			get
			{
				return default(ICKIEKLPHFL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8075D80", Offset = "0x8075180", VA = "0x188075D80", Slot = "9")]
		[AsyncStateMachine(typeof(JCGFDGLDJKO))]
		public Task<OGJPCDKPGHL> LLEMIBHBCFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8075EC0", Offset = "0x80752C0", VA = "0x188075EC0")]
		public DIILAMFBMEO(int PNMMEHCMDHJ, AJJLICNNELL GBNJOAGINEI, DOIHDMEMACP IFHCDCGLJIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8075C50", Offset = "0x8075050", VA = "0x188075C50", Slot = "11")]
		public bool Equals(DAJAGKGMOOD KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8075BB0", Offset = "0x8074FB0", VA = "0x188075BB0", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8075E80", Offset = "0x8075280", VA = "0x188075E80")]
		private bool MAEADOOLHFI(DIILAMFBMEO KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8075D00", Offset = "0x8075100", VA = "0x188075D00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class NPFPHLIDBEA : DAJAGKGMOOD, IEquatable<DAJAGKGMOOD>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct MKLGFOKPMIK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<OGJPCDKPGHL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public NPFPHLIDBEA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<OGJPCDKPGHL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x80881F0", Offset = "0x80875F0", VA = "0x1880881F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8088440", Offset = "0x8087840", VA = "0x188088440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly CKKDNBIBBCP OKMPJPFAFPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly OOJNNNOJHED OCBJHPFFCIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly BIHJBMEMEFM AELLOMENOBD;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int LEKLJPAJDCD
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x808B320", Offset = "0x808A720", VA = "0x18808B320", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AJJLICNNELL BDMAPALGGCL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x808B240", Offset = "0x808A640", VA = "0x18808B240", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime DCJBDBIDEIB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x808B020", Offset = "0x808A420", VA = "0x18808B020", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public OOJNNNOJHED? OOCJICNBMGM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x808B2D0", Offset = "0x808A6D0", VA = "0x18808B2D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public BIHJBMEMEFM? PFJPBHMPNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x808AFD0", Offset = "0x808A3D0", VA = "0x18808AFD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ICKIEKLPHFL NCKFBDDEPAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xB222B0", Offset = "0xB216B0", VA = "0x180B222B0", Slot = "10")]
			get
			{
				return default(ICKIEKLPHFL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1D46F50", Offset = "0x1D46350", VA = "0x181D46F50")]
		public NPFPHLIDBEA(CKKDNBIBBCP CEDHNEPJPLG, OOJNNNOJHED MJHGFJCMHBP, BIHJBMEMEFM ECBJHACCLFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x808B0F0", Offset = "0x808A4F0", VA = "0x18808B0F0", Slot = "9")]
		[AsyncStateMachine(typeof(MKLGFOKPMIK))]
		public Task<OGJPCDKPGHL> LLEMIBHBCFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x808AF30", Offset = "0x808A330", VA = "0x18808AF30", Slot = "11")]
		public bool Equals(DAJAGKGMOOD KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x808AE80", Offset = "0x808A280", VA = "0x18808AE80", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x808B1E0", Offset = "0x808A5E0", VA = "0x18808B1E0")]
		private bool MAEADOOLHFI(NPFPHLIDBEA KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x808B070", Offset = "0x808A470", VA = "0x18808B070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class MGEDBHJDBLL : DAJAGKGMOOD, IEquatable<DAJAGKGMOOD>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct NEGHJNIGMDA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<OGJPCDKPGHL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<OGJPCDKPGHL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x808A840", Offset = "0x8089C40", VA = "0x18808A840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x808AAA0", Offset = "0x8089EA0", VA = "0x18808AAA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly AJJLICNNELL NDCCKEMCBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly OOJNNNOJHED OCBJHPFFCIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly BIHJBMEMEFM AELLOMENOBD;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int LEKLJPAJDCD
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x80881D0", Offset = "0x80875D0", VA = "0x1880881D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public AJJLICNNELL BDMAPALGGCL
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime DCJBDBIDEIB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public OOJNNNOJHED? OOCJICNBMGM
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8088180", Offset = "0x8087580", VA = "0x188088180", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public BIHJBMEMEFM? PFJPBHMPNNA
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8087EF0", Offset = "0x80872F0", VA = "0x188087EF0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ICKIEKLPHFL NCKFBDDEPAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "10")]
			get
			{
				return default(ICKIEKLPHFL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1D46F50", Offset = "0x1D46350", VA = "0x181D46F50")]
		public MGEDBHJDBLL(AJJLICNNELL GBNJOAGINEI, OOJNNNOJHED MJHGFJCMHBP, BIHJBMEMEFM ECBJHACCLFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8087FD0", Offset = "0x80873D0", VA = "0x188087FD0", Slot = "9")]
		[AsyncStateMachine(typeof(NEGHJNIGMDA))]
		public Task<OGJPCDKPGHL> LLEMIBHBCFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8087E80", Offset = "0x8087280", VA = "0x188087E80", Slot = "11")]
		public bool Equals(DAJAGKGMOOD KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8087E00", Offset = "0x8087200", VA = "0x188087E00", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8087F40", Offset = "0x8087340", VA = "0x188087F40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x80880A0", Offset = "0x80874A0", VA = "0x1880880A0")]
		private bool MAEADOOLHFI(MGEDBHJDBLL KNCKFHOKGJM)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct OALHDKLBKGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<DAJAGKGMOOD>> <>t__builder;

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
		public EHOOGGNDLCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<DOIHDMEMACP> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<DOIHDMEMACP>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, AJJLICNNELL account, DOIHDMEMACP roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x808B650", Offset = "0x808AA50", VA = "0x18808B650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x808C480", Offset = "0x808B880", VA = "0x18808C480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct AKFFLPIHAGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, AJJLICNNELL account, DOIHDMEMACP roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<DOIHDMEMACP> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public EHOOGGNDLCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<AJJLICNNELL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x806F230", Offset = "0x806E630", VA = "0x18806F230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x806FC00", Offset = "0x806F000", VA = "0x18806FC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly AJBBEIPPJKL NFJHMGNEMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly ECFFCCGLHEI MIGEFPFNANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly JJEFOPFFIIN EBAHFOHOGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly GDHFCHKNKML<(long, long), IReadOnlyList<DOIHDMEMACP>> FKILLEKLCEB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x80779F0", Offset = "0x8076DF0", VA = "0x1880779F0")]
	[UnityEngine.Scripting.Preserve]
	public EHOOGGNDLCC([CMKKAFOAFJE(null)] ECFFCCGLHEI DHPIAKHBJNG, [CMKKAFOAFJE(null)] JJEFOPFFIIN HAFGNNKMAEH, [CMKKAFOAFJE(null)] AJBBEIPPJKL JOHEHDNDKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x80778A0", Offset = "0x8076CA0", VA = "0x1880778A0")]
	[AsyncStateMachine(typeof(OALHDKLBKGP))]
	public Task<IList<DAJAGKGMOOD>> PPJOGMEDBFN(long MIFADOBCMAC, long JCNNPHFBOMP, bool EEFLOEGEJLK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x80775F0", Offset = "0x80769F0", VA = "0x1880775F0")]
	private bool DAKEIPICAIA(DateTime? HGHOFAFIMHO, long MIFADOBCMAC, long JCNNPHFBOMP, [Out] CKKDNBIBBCP HGHJCHINOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8077790", Offset = "0x8076B90", VA = "0x188077790")]
	[AsyncStateMachine(typeof(AKFFLPIHAGN))]
	private Task<IReadOnlyList<(int, AJJLICNNELL, DOIHDMEMACP)>> GABPJMNKHGM(IReadOnlyList<DOIHDMEMACP> GOKCFHJGOBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JJEFOPFFIIN
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<CKKDNBIBBCP> JNBEEIPBIFD;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IIHLEFJGIEA(long MIFADOBCMAC, long JCNNPHFBOMP, PLFCMNGIAGA ECMHMDMOHLI, JFCACKFPDGD GIHOEMBHLDB);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NINICLEKIBN(long MIFADOBCMAC, long JCNNPHFBOMP, [Out] CKKDNBIBBCP HGHJCHINOFK);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NBHNIPPBFAL(long MIFADOBCMAC, long JCNNPHFBOMP, JFCACKFPDGD GIHOEMBHLDB, [Out] CKKDNBIBBCP HGHJCHINOFK);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KNDJCHHOBKJ(long MIFADOBCMAC, long JCNNPHFBOMP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface PMMACJEODNL : KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool IHDIPNEPJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task ILPGACJPDCO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FINHILCMPMJ(Task NHNFPALEEPM, string BFJGAFPKFPF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface FFFKBLCKPNE : KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OGJPCDKPGHL> FHOJJMNBMGO(CKKDNBIBBCP HGHJCHINOFK);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KOLLENMFCCL(CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface GBFKOIDPNBM : KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	FONJBPLEFOC JHEBAKLCCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FMKNEEMGNIF();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MLLIDFOPGBF();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface KBHPKIEBIBJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface NFOKCOMKNBM
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan EMIBBBNHBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan AMAABLFEJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan PKIEGBDPHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan AAKKAOOGLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool FOEECLGDAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool IBAOGCKFLML
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool HPFDDJIIDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int KHJLJCPCOCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool KAHEBEJFJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool HNHNBAFPKLA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool PHBCHLNMPPK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum MIMKIGDBBLO
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum PPKFOIPGIIE
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
public struct BMAMFBAMLOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long LNPKBFNBKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long OFAOCKBMEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly MIMKIGDBBLO HAFNBBNOLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception KOOEEMDHOPA;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8073CB0", Offset = "0x80730B0", VA = "0x188073CB0")]
	public BMAMFBAMLOB(long LNPKBFNBKIA, long OFAOCKBMEGP, MIMKIGDBBLO HAFNBBNOLPO, [CanBeNull] Exception KOOEEMDHOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8073C60", Offset = "0x8073060", VA = "0x188073C60")]
	public static BMAMFBAMLOB NFJOOPGCIPO(ELMNGLJGGCK DAEIDOOBJBH, MIMKIGDBBLO HAFNBBNOLPO, [Optional] Exception KOOEEMDHOPA)
	{
		return default(BMAMFBAMLOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void GCAPAODEIHF(BMAMFBAMLOB GKBKHGJHGGN);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface HNHLGDCHOMD : KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action GBHCFOKKOBG;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GCAPAODEIHF MJOEKHHMKOK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event GCAPAODEIHF LADLHDPNCBA;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event GCAPAODEIHF DHEFDFMPOFP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<PPKFOIPGIIE, bool> JLBIEPCIMGB;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ABHHMHNIBEA();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KHHHBFHKFDD(BMAMFBAMLOB GKBKHGJHGGN);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OEBADAAGJNM(BMAMFBAMLOB GKBKHGJHGGN);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PCFAPJEIKIP(BMAMFBAMLOB GKBKHGJHGGN);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JNMCIAICKAN(PPKFOIPGIIE CMJLDNADNMP, bool JKLFEMENKBM);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface JKCJLPBKNAB : KBHPKIEBIBJ, IDisposable
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
	bool CHDMODABKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LINBILDFDDA(Reason JKODLOFLBMK = Reason.Unknown);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OMKNLFKJMEJ();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface LBDHEDHCFOP : KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus BNLIINMELIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PPPOMNFHKIF(ELMNGLJGGCK DKEKMBLAHBL, ALODEKIMLIG KFJFIDCNJLA, CancellationToken BOHHBCNKHLK);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class CGOLCKDLNIE
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8074200", Offset = "0x8073600", VA = "0x188074200")]
	public static bool MHBBBBMGKBK(this LBDHEDHCFOP OOLOGEGALNI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task OAKJPOKLEGC(CancellationToken HHGPJKKLNIG, int BNOGLLLKJPP, NCKNCPPCAHN MNHJBCEPCPN);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface BFEJMCCPNJJ : KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPANAFEAEEP(OAKJPOKLEGC GKMLILDEFIG);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface HENFMPPFGFG : LGIJHFEOCEK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken DEIKLKLGMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	DHLGDCALOEP BPBHJEDHMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	FMKBFEIFICC BBEHMGBBFKO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	AKDJHEMIBMN JICIDMLEIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	BEHHGOBGNKL LDPIMCPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	BGLHDLEKEGE MDDCDEOBBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	OECLOADLJFM HAJCCCEFJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	FKLBCLNGIJH PFPEHNKBNGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	EGBBHHGAGKN BGHMOPGNAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	PMMACJEODNL LHOLJMJIMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	FFFKBLCKPNE BMFDHBGAKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HNHLGDCHOMD HJJMFCOGKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	JKCJLPBKNAB OJNDIODJGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	LBDHEDHCFOP ICLJJCKICLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	BFEJMCCPNJJ CPJCCOMCLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	IBOGFHOCCBO CMLAOJFPAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	PCJFOBAJPBG DDABFMPOHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GMNBOJDPOMF DDMIKJLMHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	ODLGNDIIDEN EBKLABGDMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	DKOGEAIEABM OPOEIFBFABJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	AKAGACKDLFM KKCINCDFALD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	BHDEHADDLMD DIKEMKPABJI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	AEFNHDNPDGB ANLENMMAPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	PIDPHNCIMCF ABNMKADPLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	NGHCPIHNGGJ AIFBNBOPKHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	GBFKOIDPNBM PCCOKLHDKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	NFOKCOMKNBM EGIALEKFNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	HMNAEIFDIFE GHAFIMOHIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	JJEFOPFFIIN OMBFAJMENKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	OOEHFEBFNNO BIENELCBMJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	GLNEFDGIGPM NNJEFJGEKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	CADBKKNPFMF NAHDHIDMNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	FAOIIFKBBED MDEOPANMCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool EAFLLELKCLG
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
	void EALODHOCNNN(ALODEKIMLIG FGMLHIFKOHE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface IBOGFHOCCBO : KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FGFMLOMLHHI JJBKLNLGAIJ(Guid FDFDCKJIMBB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JEBJOEBLLEI(Guid FDFDCKJIMBB);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IDKHLOEDIPG(Guid FDFDCKJIMBB, Task JBIOGHPPPMJ);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PPNGDMAJHKO(Guid FDFDCKJIMBB, OGJPCDKPGHL EPBKEBGNKME);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(OGJPCDKPGHL, Task)> APPGNFKIDIP(Guid FDFDCKJIMBB);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface MAIPAJJCPPG : KBHPKIEBIBJ, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface PCJFOBAJPBG : KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEIBDBGMJEP(EPOGGLOBAKG DAMFJFKKFBI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FMMMOAFEHEN(EPOGGLOBAKG DAMFJFKKFBI);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<OGNLJOEPPKN> NGJKIOJDLDP(CancellationToken GHDNKDIFAGE);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface GMNBOJDPOMF : KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FGFMLOMLHHI CMHKALEDHAA(EPOGGLOBAKG KEGFOJLGFBH);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FINDJJAMDBO(Guid FDFDCKJIMBB, Task JBIOGHPPPMJ);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface ODLGNDIIDEN : KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OGJPCDKPGHL> EBKLABGDMAM(EPOGGLOBAKG KBECLOEPHKF);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface DKOGEAIEABM : KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NAMDFBDBPAO> JHOKNIONKNO(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, ELMNGLJGGCK DKEKMBLAHBL, CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface BHDEHADDLMD : KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OGJPCDKPGHL GCKNKCJNMCE(DNIGIBHMBIB DBPOAMOJLGH);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MKJAEAFJGLM(string IOOOOBAIEAN);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface AKAGACKDLFM : KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EPOGGLOBAKG> CHOFHHBDGBK(EPOGGLOBAKG ANMDEHLLLBJ, IGPBPPCMANO MMOEGADJJKD, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<EPOGGLOBAKG> OKJPGBOGCBO(CancellationToken LMNHDKIFBOH, IGPBPPCMANO MMOEGADJJKD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KKJJOKHIFIF ADKGCHFEPJO(EBHOBHMGDHC PIDDBFCEPEF, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KKJJOKHIFIF JGCOABDPKAO(EBHOBHMGDHC PIDDBFCEPEF, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface AEFNHDNPDGB : KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OGJPCDKPGHL CPCJPACPPID(DNIGIBHMBIB DBPOAMOJLGH, OGNLJOEPPKN FHHMBNMHEHD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OGJPCDKPGHL IBIJOKDLMGH(DNIGIBHMBIB ODJOKMHBJDP);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface GMCCGHJBJAL
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	const int HFJELHAACIO = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, PFJMGMIJPHK> ECDAMHAKBBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action FNFODGAIKMH
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
	IReadOnlyList<Guid> HJMBKPMHGKF();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task GJBPGDMDBNM([Optional] CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PMGGNKEKLJI([Optional] CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface PIDPHNCIMCF
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECIHFGNBPHM(PIOLBCBDLJN CFBOLJNCAFA);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHNCHKBCIID(PIOLBCBDLJN CFBOLJNCAFA);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GIFLPACFPBL(PIOLBCBDLJN CFBOLJNCAFA);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DPCJLANBIMN(PIOLBCBDLJN CFBOLJNCAFA);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class PIOLBCBDLJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly ELMNGLJGGCK BBLLHMMLBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Dictionary<string, string> LDGNLBGEHIL;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public APGKENHKANG<string> GEIBEFEOHFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9A9260", Offset = "0x9A8660", VA = "0x1809A9260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	public PIOLBCBDLJN(ELMNGLJGGCK HHOKLMFBNEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x808D250", Offset = "0x808C650", VA = "0x18808D250")]
	public PIOLBCBDLJN IMHCCOLCOBM(string DJBLFBEBKGO, string FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x808D1C0", Offset = "0x808C5C0", VA = "0x18808D1C0")]
	public bool DGBKCBDCJBM([Out] IEnumerable<KeyValuePair<string, string>> BAIFMFOEFGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA840", Offset = "0x6FB9C40", VA = "0x186FBA840")]
	public PIOLBCBDLJN FLILPABANNI(APGKENHKANG<string> KINEPAABOFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface HMNAEIFDIFE
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool GPDOPACEFIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string NPIOCJEGKPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool AOEIEJIOLDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GPJMAHMOCFP();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KFJDGJEGIOM EAKGPBDKAEN(long OLGEMOMILNI);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JCFIGNPNPNK<KKCEGILFGJB, NFAAFKCENHI> HEJFGKGPONF(long OLGEMOMILNI);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JCFIGNPNPNK<KKCEGILFGJB, AOIFKBLFGKD> FGEFFGEEHNF(long OLGEMOMILNI);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JCFIGNPNPNK<long, OADNLLEBHMI> DIOPKJHPGJB();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<INFPHCDJCLC>> LCFLEMCPDEI(long OLGEMOMILNI, IReadOnlyCollection<INFPHCDJCLC> DHHPIEFNLAO, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HGFPLEMJJKE(long OLGEMOMILNI, [Out] bool DIFHHDMHBNA);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> OGJNADHGLPG(byte[] JKIDAGFNHLP, byte[] LLICHJIMFEF, IReadOnlyCollection<Guid> EKCJACKLPAH, CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface GHPEFBEBANI
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NAMDFBDBPAO GNHEPACBJCH(long LNPKBFNBKIA, long OFAOCKBMEGP, string EFBGJFMCDKM);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NAMDFBDBPAO GNHEPACBJCH(long LNPKBFNBKIA, long OFAOCKBMEGP, KKCEGILFGJB JKIDAGFNHLP, Guid? BEKMDJCAAJN, long KFJJHJMHDOB, bool DMENPOMFOFE);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NAMDFBDBPAO GNHEPACBJCH(DHJBDKCLFJF FBIEBFPFNON);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NAMDFBDBPAO GNHEPACBJCH(IBBAMKLHGAN BAINIHJKIDE, DOIHDMEMACP OMJINBCKBKD);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface LGIJHFEOCEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool MHBBBBMGKBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool MLAILONFHII
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool EAFLLELKCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	GHPEFBEBANI FEHJFLINGCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	ALODEKIMLIG IKEHJOOPJKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action GBHCFOKKOBG;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event GCAPAODEIHF MJOEKHHMKOK;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event GCAPAODEIHF LADLHDPNCBA;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event GCAPAODEIHF DHEFDFMPOFP;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<PPKFOIPGIIE, bool> JLBIEPCIMGB;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OMKNLFKJMEJ();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NILLKCEJPKG MIEEGKGJEDI();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IJCJEHDBGCB LLGCKAGOHJA();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task IAJAHPGDGHJ(int ALJILABKHFO, IJHECIBDPGO FBOPDOAKGNF, Func<PLFCMNGIAGA, PLFCMNGIAGA> EGAFBDKFNFO);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<OGJPCDKPGHL> FHOJJMNBMGO(CKKDNBIBBCP CEDHNEPJPLG);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task KOLLENMFCCL(CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface BGLHDLEKEGE
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool EFDABPLKJIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool FPEGHNACIHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? CONJOIPECAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBDEAGBOFNO(Scene JLGOKPMFFMM);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task JHPGEHAOMJK(DBFCLNDHECL BFENKINPEII, IReadOnlyList<DBFCLNDHECL> BACGAFFDDMM, IReadOnlyList<DBFCLNDHECL> DHDBEGHMMIC, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IHIDNJHGBMD(OOCHLHODMFP CEPFKLCFKKP);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task NPHMKFONODB(IReadOnlyList<Guid> AKAOLPDBNMD, CancellationToken LEJKBOKAFJL);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HLKKJKFMIAO HNGGFJJMIJF();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task IFBDEKNAFGN();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task ODFMPAILAFG();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface BEHHGOBGNKL
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	CDCAHPMDKLI JLEJGCAJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool FPENJEOOBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool JMMHHBBOFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool PPMGMJPKPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool AFOPFHHEAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int JBOOFHAKCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool ANOCMPDNLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool FKMDHLOMHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int NFONBFADHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int DDGEIDPOMNM
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool BMFCEOEHNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool ECCGCICPANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool KMLDCMOKPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float JAMDJKFJHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> LHGOOONHPGI;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DHLGDCALOEP AKILLCKHBLD(DHLGDCALOEP GFGIBNLEFOJ);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDAEFGCLDHF(DHLGDCALOEP NKMJDOBLHGP);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IKAOAFOEGDF();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task CNGEHJNBIEA(APGKENHKANG<string>.EEEKGBDKLHP MMECDJALEPJ, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ILEJNDHMCLI(float BBLAIIAJPLM);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MOILFBCOPDD(string BBLPHGNPPDD);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<HHAPIHFLFHJ> OHIGKKDGPFE();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable PCDKICIMIIK(object PCJJKLDOJMD, HHAPIHFLFHJ ENGJIBHFOBO);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<HIAAHBCANNL> FGOJGFNMGAP();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NFAAFKCENHI ABNAKLKIOJP(IEnumerable<AJANKEAEBKF> PPELGBEJKKO);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MAHLJECEOBB(int BMBMKKHEAHH);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task PEDCNJOCKPI();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GBMNAHNPJCP();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool LNINEPCGNIH();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task PLDGAPMCPLE(CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task DGFEAAMMEJB(CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<JNLKHFADKEJ> CALKBLMHBHP(DateTime CLPBGDCGKNF, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> LOKDBOJHMAH(CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NBCFCFAJFHG(string DAMFJFKKFBI = "", float HLOBKBPABIA = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "25")]
	EJPLPBCADEO DCFDFHFEMHB(HJGDKKKNFOO ONHCODKGHOO, HKFCLLCDEKJ BONNIONLFGJ, AOIFKBLFGKD ONBMANKKKHN, IEnumerable<PersistenceView> HOLHGEDPHEF, AOBGJNEOAEI IGKLENELELN);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HMBBHKGHHDJ(AOIFKBLFGKD ONBMANKKKHN);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void FKMEELDKEJA(AJANKEAEBKF LLCPKAOMDKB, [In] EJPLPBCADEO PAKDJMBDPBI);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task LHBPCMIMEJO(AOIFKBLFGKD KLBPAEOBMAP, bool PKDAIMKHECK, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task HDMENBLFAFC(CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MNACMMDGLPN(long MIFADOBCMAC, long OFAOCKBMEGP, IBBAMKLHGAN BCEDDHNENJL, DOIHDMEMACP ODLHDECGOKP, PLFCMNGIAGA ECMHMDMOHLI, IJHECIBDPGO? FBOPDOAKGNF, DCMMCMGKNNK? PHPGFAPLADG);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void OJFOANLBOMA(long MIFADOBCMAC, long OFAOCKBMEGP, DCMMCMGKNNK? PHPGFAPLADG);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void KJDGKFGDOGL(PersistenceView PFNEEFHBDIG);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void LHMIHKOKFGL(string COACEDHDIAD, ELMNGLJGGCK HHOKLMFBNEK, HGLMOIEJBBA HNJAPPGCPFF, [Optional] string? LEKDMOBALLD, [Optional] string? JHHLFEOLKGC, [Optional] string? HEMALCCNKHE);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool HNNOJAKEKBI(PersistenceView EKLEPCBGCMK);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool MILNDEGHCBG(AJANKEAEBKF LLCPKAOMDKB, CECIAOOGNBJ JBMJKJMIILJ, [Out] PBLDHPJABID COCICLHFDJD);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task JMADNGPGNPL(CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void OINIMIGBOFA();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable DNFJKDKIOPM();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void NINHPHEHBBA(AOIFKBLFGKD KLBPAEOBMAP, CECIAOOGNBJ JBMJKJMIILJ);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> LBFCJJIKOHO(FMKBFEIFICC BOGAODIGBEK, CancellationToken LMNHDKIFBOH, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void ICALOEFFOKK(CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<DHJBDKCLFJF> BDLCMBMJJDB(NPHDCBHFEFO ANMDEHLLLBJ);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<IBBAMKLHGAN> BOPCLAFNAAD(long MIFADOBCMAC, bool EBCGPBFLFJM, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<GKGFGBABKAH> KANIHIJCKGL(long MIFADOBCMAC, long OFAOCKBMEGP, long KFJJHJMHDOB, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<GKGFGBABKAH> ANAJFPOLEKL(long MIFADOBCMAC, long OFAOCKBMEGP, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<APIECIFOHEN> OLBBJAOBPFI(long MIFADOBCMAC, Guid CNMEKDJHEOL, long? JCNNPHFBOMP, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "47")]
	JCFIGNPNPNK<APIECIFOHEN, IEnumerable<LLDEBPMCGFM>> BCPBCBELMFA();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<MJFIDHLLGBC> MKPNMLBLLLH(string EFBGJFMCDKM, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<MJFIDHLLGBC> MFFBBEFFGON(string EFBGJFMCDKM, long MIFADOBCMAC, long OFAOCKBMEGP, Guid? JGICNMOHCMI, LBNOIGENJNJ.HCGGFPCHEGC LLMAFCHBBPF, LBNOIGENJNJ.HCGGFPCHEGC LLICHJIMFEF, int ALJILABKHFO);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool EMECIDJBCAL();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool BIPHDNBJIAP();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool CIDCKAAONPO(IEnumerable<PBLDHPJABID> DCBNLJMGAAD);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void BJIHKHINMFC(List<GameObject> BJFMLGEHGNK);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float AGPPABGFIKB();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> KHMOLOLPIHG(CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> NJHDCKIDFAO(string DFCMKAEHLAO, LoadSceneMode KJPMGMOOKEA, bool FCCJDBBOCBI, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void ADLGAEFDFOG();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void KNILGLGOFCL(bool CGAPLHFOGJF);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void DHPNGCADHNA();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void BDHGGCLGCEN();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void BEOCBAPJNKP(bool FOEDEELHLLA);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task<LBNOIGENJNJ.HCGGFPCHEGC> OPJALBJOGME(byte[] HPMNBNLACCC, LBNOIGENJNJ.GELEKMBFCLO MMFFJLPGPAM, LEIAKFIKBHE GGGKKONOOPF, [Optional] IReadOnlyCollection<string>? CBLOAFIJHFK, [Optional] string? CPIGPKDEJOA);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void LKPADEFAKLB(ELMNGLJGGCK LAEOEHEDICK);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task MBEBDBCGGFK(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task EIGJIFBPIOE(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task MOFDMFPLNAG(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "77")]
	Task AFCGPIBLKMD(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "78")]
	IDisposable ELBKFMALFCD();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "79")]
	KBPMFLBCKDN ALGDCBOHMCJ();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "80")]
	Task KDEIDPJPMPA(CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface KBPMFLBCKDN
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GFNKBGPKKOG(CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IGAJKAIJBAF(CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct EJPLPBCADEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public HashSet<int> HGAHOONJANK;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum JNLKHFADKEJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct HJGDKKKNFOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Guid? NBIGHKECMND;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface CDCAHPMDKLI
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	ELMNGLJGGCK DIJMKHAIBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	IBBAMKLHGAN OPNILIPBKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	GMHIEIPOGED IHDCDGEGIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool AAGBICIGING
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool NPDKPAKLHIN
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int OCONLBBPOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action IGPHPKOBPFL;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> LBMIJMNFCGC;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BGBHCNJNMKO();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.FIHFEJPLBAH> CJIIMDJAJFD(long OLGEMOMILNI, [Optional] CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<MJEIBBNCLFO> KMIPGKEPJKP(ELMNGLJGGCK HHOKLMFBNEK, [Optional] ALODEKIMLIG KFJFIDCNJLA);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<MJEIBBNCLFO> PFJJBIPCFAG();

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task CJMLFGDCKAL();

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(ELMNGLJGGCK, ALODEKIMLIG) OIGAMAEKCBJ();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "16")]
	OLGIGMIMIFN JAAEMFGPEGO();

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KPGJAALBCEM(long OLGEMOMILNI);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KNOANOGKNBP(ELMNGLJGGCK HHOKLMFBNEK, Matchmaking.NBPOMBJHFGA HBALBIOOGIJ, (int Major, int? Minor)? HLLDLKNABPD);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface NGHCPIHNGGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GHNCPKEBEHK([Out] IEnumerable<int> PCGFFIMNONJ);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMNAIHENMNF(CEGHMOMNMEC HHGPJKKLNIG);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJHAHCKMFPK(CEGHMOMNMEC HHGPJKKLNIG);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface OEGLEMCCNAH
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PHCEMMLENFO(OGJPCDKPGHL HNFLDGONBPM);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface ECCBHLJGFKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLLGJABLFDJ(CJAFONOBJEN.GAMLEOPPJOC FNPMDNALIPI);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JAFNFDCHGIK(CJAFONOBJEN.GAMLEOPPJOC FNPMDNALIPI);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface OECLOADLJFM : ECCBHLJGFKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OGJPCDKPGHL ODBEPKLEGAF(DNIGIBHMBIB ODJOKMHBJDP);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface FKLBCLNGIJH : ECCBHLJGFKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OGJPCDKPGHL GCKNKCJNMCE(DNIGIBHMBIB GGMAHLNBIDK);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface KFJDGJEGIOM
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KGPHFOFOMPJ<MJBEDDENEDM, ADGPAJEIFGP>> KCLLMOCLLED(Guid? JGICNMOHCMI, IReadOnlyCollection<INFPHCDJCLC> BKGEJEKCCOC, IReadOnlyCollection<INFPHCDJCLC> NGEAFLLBCHM, FPBGJGMBMBK FHJAGNEGENL, long? MIFADOBCMAC, long? OFAOCKBMEGP, PKEEJPANGHO.BNNACOHHJOL ELOKFHOLKDI, CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class MJBEDDENEDM
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public DBFCLNDHECL BKMHFMPFODH
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<DBFCLNDHECL> DPMHAPOBPKA
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<DBFCLNDHECL> JHGPGLNFKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xBA82B0", Offset = "0xBA76B0", VA = "0x180BA82B0")]
	public MJBEDDENEDM(DBFCLNDHECL IKFDCKFFMBA, IReadOnlyList<DBFCLNDHECL> NEINIFKBABK, IReadOnlyList<DBFCLNDHECL> POAIPJJEFHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface JCFIGNPNPNK<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KGPHFOFOMPJ<PPEBEAEDJID<TData>, ADGPAJEIFGP>> KJCLDGJHFKE(TGetDataArg HBNMBAEKPFF, CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class INHFFLDACLK : HENFMPPFGFG, LGIJHFEOCEK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct CEJNGLHGCNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<OGJPCDKPGHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public INHFFLDACLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public CKKDNBIBBCP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<OGJPCDKPGHL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8073D50", Offset = "0x8073150", VA = "0x188073D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8073FD0", Offset = "0x80733D0", VA = "0x188073FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct FNAJEFFAJFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public INHFFLDACLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8078740", Offset = "0x8077B40", VA = "0x188078740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8078970", Offset = "0x8077D70", VA = "0x188078970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class IIONPKNMJHP : IEnumerable<KBHPKIEBIBJ>, IEnumerable, IEnumerator<KBHPKIEBIBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private KBHPKIEBIBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public INHFFLDACLK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private KBHPKIEBIBJ System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xDEB050", Offset = "0xDEA450", VA = "0x180DEB050")]
		[DebuggerHidden]
		public IIONPKNMJHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x807B620", Offset = "0x807AA20", VA = "0x18807B620", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x807BA80", Offset = "0x807AE80", VA = "0x18807BA80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x807B9D0", Offset = "0x807ADD0", VA = "0x18807B9D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KBHPKIEBIBJ> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x807B9D0", Offset = "0x807ADD0", VA = "0x18807B9D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CancellationTokenSource LIDAPPOBDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly DHLGDCALOEP NKMJDOBLHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool EKDCONIHOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private IAHANCCNKIK NAOGNLFLLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool KGJBEGEMDJD;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public FMKBFEIFICC BBEHMGBBFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A60", Offset = "0x9A8E60", VA = "0x1809A9A60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AC0", Offset = "0x9A8EC0", VA = "0x1809A9AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public AKDJHEMIBMN JICIDMLEIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A70", Offset = "0x9A8E70", VA = "0x1809A9A70", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A80", Offset = "0x9A8E80", VA = "0x1809A9A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public BEHHGOBGNKL LDPIMCPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A40", Offset = "0x9A8E40", VA = "0x1809A9A40", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A90", Offset = "0x9A8E90", VA = "0x1809A9A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public BGLHDLEKEGE MDDCDEOBBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AA0", Offset = "0x9A8EA0", VA = "0x1809A9AA0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A50", Offset = "0x9A8E50", VA = "0x1809A9A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public OECLOADLJFM HAJCCCEFJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A30", Offset = "0x9A8E30", VA = "0x1809A9A30", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AB0", Offset = "0x9A8EB0", VA = "0x1809A9AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public FKLBCLNGIJH PFPEHNKBNGF
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE420", Offset = "0x9AD820", VA = "0x1809AE420", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4E0", Offset = "0x9AD8E0", VA = "0x1809AE4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public GHPEFBEBANI FEHJFLINGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4D0", Offset = "0x9AD8D0", VA = "0x1809AE4D0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4F0", Offset = "0x9AD8F0", VA = "0x1809AE4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public EGBBHHGAGKN BGHMOPGNAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5B0", Offset = "0x9AD9B0", VA = "0x1809AE5B0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9AE550", Offset = "0x9AD950", VA = "0x1809AE550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public PMMACJEODNL LHOLJMJIMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xB232B0", Offset = "0xB226B0", VA = "0x180B232B0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x11F1080", Offset = "0x11F0480", VA = "0x1811F1080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public FFFKBLCKPNE BMFDHBGAKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9AE450", Offset = "0x9AD850", VA = "0x1809AE450", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9AE520", Offset = "0x9AD920", VA = "0x1809AE520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public HNHLGDCHOMD HJJMFCOGKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xC35E10", Offset = "0xC35210", VA = "0x180C35E10", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xDAB2F0", Offset = "0xDAA6F0", VA = "0x180DAB2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public JKCJLPBKNAB OJNDIODJGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9B2A70", Offset = "0x9B1E70", VA = "0x1809B2A70", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9B2AD0", Offset = "0x9B1ED0", VA = "0x1809B2AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public LBDHEDHCFOP ICLJJCKICLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xB6DE10", Offset = "0xB6D210", VA = "0x180B6DE10", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xDB0000", Offset = "0xDAF400", VA = "0x180DB0000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public BFEJMCCPNJJ CPJCCOMCLCC
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xC8CA80", Offset = "0xC8BE80", VA = "0x180C8CA80", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xC8CA90", Offset = "0xC8BE90", VA = "0x180C8CA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IBOGFHOCCBO CMLAOJFPAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xC35C40", Offset = "0xC35040", VA = "0x180C35C40", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x10791D0", Offset = "0x10785D0", VA = "0x1810791D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public MAIPAJJCPPG EOJNFMAFNNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xC20DF0", Offset = "0xC201F0", VA = "0x180C20DF0", Slot = "62")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xCBC450", Offset = "0xCBB850", VA = "0x180CBC450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public PCJFOBAJPBG DDABFMPOHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xAF1570", Offset = "0xAF0970", VA = "0x180AF1570", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xAF1080", Offset = "0xAF0480", VA = "0x180AF1080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public GMNBOJDPOMF DDMIKJLMHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9B2AC0", Offset = "0x9B1EC0", VA = "0x1809B2AC0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9B2AF0", Offset = "0x9B1EF0", VA = "0x1809B2AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public ODLGNDIIDEN EBKLABGDMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xB01990", Offset = "0xB00D90", VA = "0x180B01990", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xB013C0", Offset = "0xB007C0", VA = "0x180B013C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public DKOGEAIEABM OPOEIFBFABJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xB0F480", Offset = "0xB0E880", VA = "0x180B0F480", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xB0D9D0", Offset = "0xB0CDD0", VA = "0x180B0D9D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public AKAGACKDLFM KKCINCDFALD
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA19A20", Offset = "0xA18E20", VA = "0x180A19A20", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA33D30", Offset = "0xA33130", VA = "0x180A33D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public BHDEHADDLMD DIKEMKPABJI
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA30580", Offset = "0xA2F980", VA = "0x180A30580", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA387F0", Offset = "0xA37BF0", VA = "0x180A387F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public AEFNHDNPDGB ANLENMMAPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAEF7A0", Offset = "0xAEEBA0", VA = "0x180AEF7A0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xAEBFF0", Offset = "0xAEB3F0", VA = "0x180AEBFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public PIDPHNCIMCF ABNMKADPLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA54080", Offset = "0xA53480", VA = "0x180A54080", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA37C60", Offset = "0xA37060", VA = "0x180A37C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public NGHCPIHNGGJ AIFBNBOPKHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xAE1E50", Offset = "0xAE1250", VA = "0x180AE1E50", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA30610", Offset = "0xA2FA10", VA = "0x180A30610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public GBFKOIDPNBM PCCOKLHDKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA52B10", VA = "0x180A53710", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA3A790", Offset = "0xA39B90", VA = "0x180A3A790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public NFOKCOMKNBM EGIALEKFNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA2F790", Offset = "0xA2EB90", VA = "0x180A2F790", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA38C90", Offset = "0xA38090", VA = "0x180A38C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public HMNAEIFDIFE GHAFIMOHIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA25EA0", Offset = "0xA252A0", VA = "0x180A25EA0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA1D8E0", Offset = "0xA1CCE0", VA = "0x180A1D8E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public JJEFOPFFIIN OMBFAJMENKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA397B0", Offset = "0xA38BB0", VA = "0x180A397B0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public OOEHFEBFNNO BIENELCBMJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA25600", Offset = "0xA24A00", VA = "0x180A25600", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public GLNEFDGIGPM NNJEFJGEKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA1DC30", Offset = "0xA1D030", VA = "0x180A1DC30", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public CADBKKNPFMF NAHDHIDMNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA14E90", Offset = "0xA14290", VA = "0x180A14E90", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public FAOIIFKBBED MDEOPANMCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA1D520", Offset = "0xA1C920", VA = "0x180A1D520", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public ALODEKIMLIG IKEHJOOPJKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA25E80", Offset = "0xA25280", VA = "0x180A25E80", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xEA2250", Offset = "0xEA1650", VA = "0x180EA2250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool OAOEMMEAHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x807DAE0", Offset = "0x807CEE0", VA = "0x18807DAE0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool GAMGOEKOLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x807DB40", Offset = "0x807CF40", VA = "0x18807DB40", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool FCMILKBEPNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1AF08A0", Offset = "0x1AEFCA0", VA = "0x181AF08A0", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken PENGGCNAILL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x807CE10", Offset = "0x807C210", VA = "0x18807CE10", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private DHLGDCALOEP CCICKHFHADB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool EFJFANABNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1AF08A0", Offset = "0x1AEFCA0", VA = "0x181AF08A0", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1AEAD60", Offset = "0x1AEA160", VA = "0x181AEAD60", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action GOKFPIBJIOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x807D910", Offset = "0x807CD10", VA = "0x18807D910", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x807D3A0", Offset = "0x807C7A0", VA = "0x18807D3A0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event GCAPAODEIHF LBJOJGHOJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x807CE30", Offset = "0x807C230", VA = "0x18807CE30", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x807D540", Offset = "0x807C940", VA = "0x18807D540", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event GCAPAODEIHF NPCENFAFPPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x807D340", Offset = "0x807C740", VA = "0x18807D340", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x807CFE0", Offset = "0x807C3E0", VA = "0x18807CFE0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event GCAPAODEIHF JOGPLMLKGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x807D8B0", Offset = "0x807CCB0", VA = "0x18807D8B0", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x807DC90", Offset = "0x807D090", VA = "0x18807DC90", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<PPKFOIPGIIE, bool> IDBNIMDKPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x807D040", Offset = "0x807C440", VA = "0x18807D040", Slot = "48")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x807CE90", Offset = "0x807C290", VA = "0x18807CE90", Slot = "49")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0xEA2250", Offset = "0xEA1650", VA = "0x180EA2250", Slot = "39")]
	public void EALODHOCNNN(ALODEKIMLIG FGMLHIFKOHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x807DCF0", Offset = "0x807D0F0", VA = "0x18807DCF0")]
	[UnityEngine.Scripting.Preserve]
	internal INHFFLDACLK([CMKKAFOAFJE(null)] DHLGDCALOEP NKMJDOBLHGP, [CMKKAFOAFJE(null)] FMKBFEIFICC BOGAODIGBEK, [CMKKAFOAFJE(null)] AKDJHEMIBMN MIPJJEBLOIG, [CMKKAFOAFJE(null)] BEHHGOBGNKL IAPHFNOPBJO, [CMKKAFOAFJE(null)] BGLHDLEKEGE BHOKHBGHNNC, [CMKKAFOAFJE(null)] OECLOADLJFM KCMEOJGNOCC, [CMKKAFOAFJE(null)] FKLBCLNGIJH JGGPEAFECGJ, [CMKKAFOAFJE(null)] EGBBHHGAGKN BDFIBCDOEKG, [CMKKAFOAFJE(null)] PMMACJEODNL AEDDIMEJOEC, [CMKKAFOAFJE(null)] FFFKBLCKPNE LHOCJJFNGFM, [CMKKAFOAFJE(null)] HNHLGDCHOMD JIHGMCPNOEK, [CMKKAFOAFJE(null)] JKCJLPBKNAB MGBCFAFLPMJ, [CMKKAFOAFJE(null)] LBDHEDHCFOP OOLOGEGALNI, [CMKKAFOAFJE(null)] BFEJMCCPNJJ EOGCPILNJHO, [CMKKAFOAFJE(null)] IBOGFHOCCBO NDOOJONJDNA, [CMKKAFOAFJE(null)] MAIPAJJCPPG PEAPKOHNAEO, [CMKKAFOAFJE(null)] PCJFOBAJPBG NIDMAHCNFMM, [CMKKAFOAFJE(null)] GMNBOJDPOMF AIBKIAEAGPH, [CMKKAFOAFJE(null)] ODLGNDIIDEN EGEHFHFCJJL, [CMKKAFOAFJE(null)] DKOGEAIEABM OLIGAJLLAND, [CMKKAFOAFJE(null)] BHDEHADDLMD EGCLPDLBPFJ, [CMKKAFOAFJE(null)] AKAGACKDLFM CDODBONFBPP, [CMKKAFOAFJE(null)] AEFNHDNPDGB EJIFMKNBKDJ, [CMKKAFOAFJE(null)] PIDPHNCIMCF LFDAPAFGGGA, [CMKKAFOAFJE(null)] NGHCPIHNGGJ GGBHNFALOBC, [CMKKAFOAFJE(null)] NFOKCOMKNBM HNFCGGMPMHM, [CMKKAFOAFJE(null)] HMNAEIFDIFE FPEOBPEELJF, [CMKKAFOAFJE(null)] JJEFOPFFIIN APDIEPHHGLF, [CMKKAFOAFJE(null)] OOEHFEBFNNO LBNHFJAFLON, [CMKKAFOAFJE(null)] GLNEFDGIGPM GNLBINGGPAL, [CMKKAFOAFJE(null)] CADBKKNPFMF AHAJFADKBKH, [CMKKAFOAFJE(null)] FAOIIFKBBED HKHKDBPNEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x807D490", Offset = "0x807C890", VA = "0x18807D490")]
	private void GDCNGOALEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x807D0A0", Offset = "0x807C4A0", VA = "0x18807D0A0", Slot = "61")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x807DBC0", Offset = "0x807CFC0", VA = "0x18807DBC0", Slot = "53")]
	private void NACMLHNCJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x807D400", Offset = "0x807C800", VA = "0x18807D400", Slot = "54")]
	private NILLKCEJPKG FOMPEMLOONN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x807CD80", Offset = "0x807C180", VA = "0x18807CD80", Slot = "55")]
	private IJCJEHDBGCB AAJHBFKGJFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x807D5A0", Offset = "0x807C9A0", VA = "0x18807D5A0", Slot = "57")]
	public Task IAJAHPGDGHJ(int ALJILABKHFO, IJHECIBDPGO FBOPDOAKGNF, Func<PLFCMNGIAGA, PLFCMNGIAGA> EGAFBDKFNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x807D230", Offset = "0x807C630", VA = "0x18807D230")]
	private OGPCJMPMLOG EIEPHPIMAEK(int ALJILABKHFO, IJHECIBDPGO FBOPDOAKGNF, Func<PLFCMNGIAGA, PLFCMNGIAGA> EGAFBDKFNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x807D970", Offset = "0x807CD70", VA = "0x18807D970", Slot = "58")]
	[AsyncStateMachine(typeof(CEJNGLHGCNJ))]
	private Task<OGJPCDKPGHL> ILHJKMALLIO(CKKDNBIBBCP HGHJCHINOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x807CEF0", Offset = "0x807C2F0", VA = "0x18807CEF0", Slot = "59")]
	[AsyncStateMachine(typeof(FNAJEFFAJFH))]
	private Task CAEONCPIHDA(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x807DC10", Offset = "0x807D010", VA = "0x18807DC10")]
	[IteratorStateMachine(typeof(IIONPKNMJHP))]
	private IEnumerable<KBHPKIEBIBJ> NBLBJKMHCKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x807DA80", Offset = "0x807CE80", VA = "0x18807DA80")]
	[CompilerGenerated]
	private void JFCEKJEGMKD(KBHPKIEBIBJ DMJKAPFLGHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class PKMLOKKNCAP : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x16A45B0", Offset = "0x16A39B0", VA = "0x1816A45B0")]
	public PKMLOKKNCAP(string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class CFILEMNOOBB : LDINNJCHBAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct NFHDHDIMNDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<LDINNJCHBAF.EGBDLOOLBIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public HashSet<JKCJLPBKNAB.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public CFILEMNOOBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x808AB10", Offset = "0x8089F10", VA = "0x18808AB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x808AE10", Offset = "0x808A210", VA = "0x18808AE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly BEHHGOBGNKL IAPHFNOPBJO;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string BPCKIDPEGEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8074040", Offset = "0x8073440", VA = "0x188074040", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x9B9340", Offset = "0x9B8740", VA = "0x1809B9340")]
	public CFILEMNOOBB(HENFMPPFGFG LMJMNPPPAHL, BEHHGOBGNKL IAPHFNOPBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x8074070", Offset = "0x8073470", VA = "0x188074070", Slot = "5")]
	[AsyncStateMachine(typeof(NFHDHDIMNDO))]
	public Task<LDINNJCHBAF.EGBDLOOLBIJ> NBAMFGNPAAN(HashSet<JKCJLPBKNAB.Reason> BFDKCOPLGCA, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class KPMNAIDNJAG : OAJNKOJFIJA, LDINNJCHBAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct LELCPLHBGGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<LDINNJCHBAF.EGBDLOOLBIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public KPMNAIDNJAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public HashSet<JKCJLPBKNAB.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private ELMNGLJGGCK <localRoomInstance>5__2;

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
		private TaskAwaiter<LDINNJCHBAF.EGBDLOOLBIJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8084BB0", Offset = "0x8083FB0", VA = "0x188084BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8085510", Offset = "0x8084910", VA = "0x188085510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string BPCKIDPEGEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x80849B0", Offset = "0x8083DB0", VA = "0x1880849B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x9B9340", Offset = "0x9B8740", VA = "0x1809B9340")]
	public KPMNAIDNJAG(HENFMPPFGFG LMJMNPPPAHL, BEHHGOBGNKL IAPHFNOPBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x80849E0", Offset = "0x8083DE0", VA = "0x1880849E0", Slot = "5")]
	[AsyncStateMachine(typeof(LELCPLHBGGM))]
	public Task<LDINNJCHBAF.EGBDLOOLBIJ> NBAMFGNPAAN(HashSet<JKCJLPBKNAB.Reason> BFDKCOPLGCA, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class LOCFPLGMLOJ : OAJNKOJFIJA, LDINNJCHBAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct CPCEKLGMPPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public AsyncTaskMethodBuilder<LDINNJCHBAF.EGBDLOOLBIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public LOCFPLGMLOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public HashSet<JKCJLPBKNAB.Reason> fallbackTriggersToIgnore;

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
		private TaskAwaiter<MJEIBBNCLFO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter<LDINNJCHBAF.EGBDLOOLBIJ> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8075150", Offset = "0x8074550", VA = "0x188075150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8075B40", Offset = "0x8074F40", VA = "0x188075B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string BPCKIDPEGEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x80869C0", Offset = "0x8085DC0", VA = "0x1880869C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x9B9340", Offset = "0x9B8740", VA = "0x1809B9340")]
	public LOCFPLGMLOJ(HENFMPPFGFG LMJMNPPPAHL, BEHHGOBGNKL IAPHFNOPBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x80869F0", Offset = "0x8085DF0", VA = "0x1880869F0", Slot = "5")]
	[AsyncStateMachine(typeof(CPCEKLGMPPD))]
	public Task<LDINNJCHBAF.EGBDLOOLBIJ> NBAMFGNPAAN(HashSet<JKCJLPBKNAB.Reason> BFDKCOPLGCA, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class IFCLBDAKMEN : OAJNKOJFIJA, LDINNJCHBAF
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class OLFOKBNOHHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public MJEIBBNCLFO matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public ELMNGLJGGCK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public OLFOKBNOHHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x808D030", Offset = "0x808C430", VA = "0x18808D030")]
		internal object MIAMCBBLEJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x808CF70", Offset = "0x808C370", VA = "0x18808CF70")]
		internal object CLMHBPMGGBD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct MEENEKFABEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public AsyncTaskMethodBuilder<LDINNJCHBAF.EGBDLOOLBIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public IFCLBDAKMEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public HashSet<JKCJLPBKNAB.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private OLFOKBNOHHA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<MJEIBBNCLFO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter<LDINNJCHBAF.EGBDLOOLBIJ> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8087170", Offset = "0x8086570", VA = "0x188087170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8087D90", Offset = "0x8087190", VA = "0x188087D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string BPCKIDPEGEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x807AF80", Offset = "0x807A380", VA = "0x18807AF80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x9B9340", Offset = "0x9B8740", VA = "0x1809B9340")]
	public IFCLBDAKMEN(HENFMPPFGFG LMJMNPPPAHL, BEHHGOBGNKL IAPHFNOPBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x807AFB0", Offset = "0x807A3B0", VA = "0x18807AFB0", Slot = "5")]
	[AsyncStateMachine(typeof(MEENEKFABEG))]
	public Task<LDINNJCHBAF.EGBDLOOLBIJ> NBAMFGNPAAN(HashSet<JKCJLPBKNAB.Reason> BFDKCOPLGCA, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class OAJNKOJFIJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct ACFHBFBIDAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public GBHBOJAPDOA log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public HashSet<JKCJLPBKNAB.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public OAJNKOJFIJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<JKCJLPBKNAB.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x806DF10", Offset = "0x806D310", VA = "0x18806DF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x806E430", Offset = "0x806D830", VA = "0x18806E430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	protected readonly HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	protected readonly BEHHGOBGNKL IAPHFNOPBJO;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected CDCAHPMDKLI JLEJGCAJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x808B510", Offset = "0x808A910", VA = "0x18808B510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x9B9340", Offset = "0x9B8740", VA = "0x1809B9340")]
	public OAJNKOJFIJA(HENFMPPFGFG LMJMNPPPAHL, BEHHGOBGNKL IAPHFNOPBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x808B3E0", Offset = "0x808A7E0", VA = "0x18808B3E0")]
	[AsyncStateMachine(typeof(ACFHBFBIDAF))]
	protected Task GHMMEKPMDLL(GBHBOJAPDOA DPDKJPMBJOA, HashSet<JKCJLPBKNAB.Reason> BFDKCOPLGCA, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class LJPPEFIIKCA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct GONHNMBCOIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder<LDINNJCHBAF.EGBDLOOLBIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public BEHHGOBGNKL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8079CA0", Offset = "0x80790A0", VA = "0x188079CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x807A020", Offset = "0x8079420", VA = "0x18807A020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class IPHKDKECGNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public HENFMPPFGFG roomManager;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public IPHKDKECGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x807E1C0", Offset = "0x807D5C0", VA = "0x18807E1C0")]
		internal object EGGNKGEDHCJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly float NKKNGFDIGLJ;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	internal static readonly HashSet<JKCJLPBKNAB.Reason> LDJBOGOAPLK;

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x80861C0", Offset = "0x80855C0", VA = "0x1880861C0")]
	[AsyncStateMachine(typeof(GONHNMBCOIN))]
	internal static Task<LDINNJCHBAF.EGBDLOOLBIJ> PIFIODOEOFP(BEHHGOBGNKL IAPHFNOPBJO, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8086040", Offset = "0x8085440", VA = "0x188086040")]
	internal static void KHLBMOLDOKG(HENFMPPFGFG LMJMNPPPAHL, GBHBOJAPDOA DPDKJPMBJOA, string COACEDHDIAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface LDINNJCHBAF
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct EGBDLOOLBIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public bool JKLFEMENKBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public JKCJLPBKNAB.Reason JKODLOFLBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Enum? HEMALCCNKHE;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x80775B0", Offset = "0x80769B0", VA = "0x1880775B0")]
		public static EGBDLOOLBIJ ABONCMIDHHC()
		{
			return default(EGBDLOOLBIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x80775C0", Offset = "0x80769C0", VA = "0x1880775C0")]
		public static EGBDLOOLBIJ CNMDBLOHBFB(JKCJLPBKNAB.Reason JKODLOFLBMK, [Optional] Enum? HEMALCCNKHE)
		{
			return default(EGBDLOOLBIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string BDMAJDEPNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<EGBDLOOLBIJ> NBAMFGNPAAN(HashSet<JKCJLPBKNAB.Reason> BFDKCOPLGCA, CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct DJOLONAHFCN
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class GCCIAMCNCKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public HENFMPPFGFG manager;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public GCCIAMCNCKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x80789D0", Offset = "0x8077DD0", VA = "0x1880789D0")]
		internal Task NONKGBBDIEE(CancellationToken cancellationToken, int roomTotalVersion, NCKNCPPCAHN localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct OHDPJNKFJPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public DJOLONAHFCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private CKKDNBIBBCP <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter<JNLKHFADKEJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter<OGJPCDKPGHL> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x808C820", Offset = "0x808BC20", VA = "0x18808C820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x808CDB0", Offset = "0x808C1B0", VA = "0x18808CDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct HCKKLPCCOHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public DJOLONAHFCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x807AC00", Offset = "0x807A000", VA = "0x18807AC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x807AF20", Offset = "0x807A320", VA = "0x18807AF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly CancellationToken LMNHDKIFBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly HENFMPPFGFG HEKFIEJNOCO;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private FMKBFEIFICC BBEHMGBBFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x80770E0", Offset = "0x80764E0", VA = "0x1880770E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private BEHHGOBGNKL LDPIMCPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x80774B0", Offset = "0x80768B0", VA = "0x1880774B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private CDCAHPMDKLI JLEJGCAJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8077330", Offset = "0x8076730", VA = "0x188077330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private FFFKBLCKPNE BMFDHBGAKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x80773B0", Offset = "0x80767B0", VA = "0x1880773B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x26899E0", Offset = "0x2688DE0", VA = "0x1826899E0")]
	public DJOLONAHFCN(CancellationToken LMNHDKIFBOH, HENFMPPFGFG HEKFIEJNOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8077400", Offset = "0x8076800", VA = "0x188077400")]
	public static OAKJPOKLEGC NNDMFMIMKMF(HENFMPPFGFG HEKFIEJNOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8076DC0", Offset = "0x80761C0", VA = "0x188076DC0")]
	[AsyncStateMachine(typeof(OHDPJNKFJPP))]
	public Task<bool> AMNMBKBGPIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x8076ED0", Offset = "0x80762D0", VA = "0x188076ED0")]
	private bool CEICAMGDFOH([Out] CKKDNBIBBCP HGHJCHINOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x8077130", Offset = "0x8076530", VA = "0x188077130")]
	[AsyncStateMachine(typeof(HCKKLPCCOHA))]
	private Task GPHPMADLKFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x8077200", Offset = "0x8076600", VA = "0x188077200")]
	private Task<JNLKHFADKEJ> IIOGCGDOENH(CKKDNBIBBCP HCKHEJPLOJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct FGFMLOMLHHI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly IBOGFHOCCBO NDOOJONJDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Guid FDFDCKJIMBB;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(OGJPCDKPGHL, Task)> NEKJJBNJIAF
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8078670", Offset = "0x8077A70", VA = "0x188078670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4E33940", Offset = "0x4E32D40", VA = "0x184E33940")]
	public FGFMLOMLHHI(IBOGFHOCCBO NDOOJONJDNA, Guid FDFDCKJIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8078620", Offset = "0x8077A20", VA = "0x188078620")]
	public TaskAwaiter<(OGJPCDKPGHL, Task)> LKDLBOJCELA()
	{
		return default(TaskAwaiter<(OGJPCDKPGHL, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x8078550", Offset = "0x8077950", VA = "0x188078550", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct KJMEKGCBFNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly TaskCompletionSource<(OGJPCDKPGHL, Task)> MDMDCIOCDHB;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(OGJPCDKPGHL, Task)> NEKJJBNJIAF
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8084760", Offset = "0x8083B60", VA = "0x188084760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8084830", Offset = "0x8083C30", VA = "0x188084830")]
	public KJMEKGCBFNO(TimeSpan ADEFLDLMJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8084630", Offset = "0x8083A30", VA = "0x188084630")]
	public void FNMAHMIDKJO(Task JBIOGHPPPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x80847A0", Offset = "0x8083BA0", VA = "0x1880847A0")]
	public void MJDLMLOEHPH(OGJPCDKPGHL HNFLDGONBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x80845E0", Offset = "0x80839E0", VA = "0x1880845E0")]
	public void AOODJABAHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x80846D0", Offset = "0x8083AD0", VA = "0x1880846D0")]
	internal void GIEABCJGJIL(string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class OCNMKPGGBNG
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x808C680", Offset = "0x808BA80", VA = "0x18808C680")]
	public static NAMDFBDBPAO JCNCFJFOLEL(this NAMDFBDBPAO DMDJHNIAOJN, IBBAMKLHGAN NHDNMOCKOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x808C4F0", Offset = "0x808B8F0", VA = "0x18808C4F0")]
	public static NAMDFBDBPAO JBEODMKCFLO(this NAMDFBDBPAO DMDJHNIAOJN, DOIHDMEMACP BIMMDMENOHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class MNOPFNBFCGI : GHPEFBEBANI
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class ONCKFBHGHJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public DOIHDMEMACP subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public ONCKFBHGHJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x808D0B0", Offset = "0x808C4B0", VA = "0x18808D0B0")]
		internal bool GNKNEADBGJO(GMHIEIPOGED s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly NFOKCOMKNBM NAHLKHJHOFH;

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	public MNOPFNBFCGI(NFOKCOMKNBM HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x8088610", Offset = "0x8087A10", VA = "0x188088610", Slot = "4")]
	public NAMDFBDBPAO GNHEPACBJCH(long LNPKBFNBKIA, long OFAOCKBMEGP, string EFBGJFMCDKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x80884B0", Offset = "0x80878B0", VA = "0x1880884B0", Slot = "5")]
	public NAMDFBDBPAO GNHEPACBJCH(long LNPKBFNBKIA, long OFAOCKBMEGP, KKCEGILFGJB JKIDAGFNHLP, Guid? BEKMDJCAAJN, long KFJJHJMHDOB, bool DMENPOMFOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x8088980", Offset = "0x8087D80", VA = "0x188088980", Slot = "6")]
	public NAMDFBDBPAO GNHEPACBJCH(DHJBDKCLFJF FBIEBFPFNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x80886A0", Offset = "0x8087AA0", VA = "0x1880886A0", Slot = "7")]
	public NAMDFBDBPAO GNHEPACBJCH(IBBAMKLHGAN BAINIHJKIDE, DOIHDMEMACP OMJINBCKBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8088B80", Offset = "0x8087F80", VA = "0x188088B80")]
	private Guid? NEMFGDKGMNN(IBBAMKLHGAN NHGHBHBKNPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class HBCPGMJJBPP : PMMACJEODNL, KBHPKIEBIBJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct ANBMJGHMKPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public HBCPGMJJBPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x806FC70", Offset = "0x806F070", VA = "0x18806FC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8070300", Offset = "0x806F700", VA = "0x188070300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly CEGHMOMNMEC DHJMDJJLMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private string LLGDDHLPCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Task FDLFPEKMCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool IHDIPNEPJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x807A280", Offset = "0x8079680", VA = "0x18807A280", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task ILPGACJPDCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x807A1F0", Offset = "0x80795F0", VA = "0x18807A1F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x9B01E0", Offset = "0x9AF5E0", VA = "0x1809B01E0", Slot = "7")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x807A090", Offset = "0x8079490", VA = "0x18807A090", Slot = "6")]
	public void FINHILCMPMJ(Task NHNFPALEEPM, string BFJGAFPKFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x807A2B0", Offset = "0x80796B0", VA = "0x18807A2B0")]
	[AsyncStateMachine(typeof(ANBMJGHMKPP))]
	private Task PEFAPPMJFLJ(Task JLGCIHFLEAI, string BFJGAFPKFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x807A3D0", Offset = "0x80797D0", VA = "0x18807A3D0")]
	public HBCPGMJJBPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class IHKADMFJMPB : GBFKOIDPNBM, KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private bool KFMCGHGGEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private FONJBPLEFOC IKJIGBMHCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private FMKBFEIFICC BOGAODIGBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NFOKCOMKNBM HNFCGGMPMHM;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public FONJBPLEFOC JHEBAKLCCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x807B180", Offset = "0x807A580", VA = "0x18807B180", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x807B3E0", Offset = "0x807A7E0", VA = "0x18807B3E0", Slot = "7")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x807B230", Offset = "0x807A630", VA = "0x18807B230", Slot = "5")]
	public void FMKNEEMGNIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x807B1F0", Offset = "0x807A5F0", VA = "0x18807B1F0", Slot = "6")]
	public void MLLIDFOPGBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x807B560", Offset = "0x807A960", VA = "0x18807B560")]
	private Task IANHLJFGELH(OFLJMGOKAPC FKPHPPGPLLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x807B1F0", Offset = "0x807A5F0", VA = "0x18807B1F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public IHKADMFJMPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class HCDAJCMLMFC : NFOKCOMKNBM
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class FMNIMFKOMLN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly NNOOHIAHMIG ENFLKMBLIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly string DJBLFBEBKGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly T PFCPDJEHNAP;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T HDKOPKMNJCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0xBEA690", Offset = "0xBE9A90", VA = "0x180BEA690")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xBEA330", Offset = "0xBE9730", VA = "0x180BEA330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x47808F0", Offset = "0x477FCF0", VA = "0x1847808F0")]
		public FMNIMFKOMLN(NNOOHIAHMIG ENFLKMBLIJN, string DJBLFBEBKGO, T PFCPDJEHNAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x477FF70", Offset = "0x477F370", VA = "0x18477FF70")]
		private void HBJJBPAPEBB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly NNOOHIAHMIG ENFLKMBLIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly FMNIMFKOMLN<TimeSpan> PDNILMBILJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly FMNIMFKOMLN<TimeSpan> HEEIAIFNKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly FMNIMFKOMLN<TimeSpan> JEDIBLBHEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly FMNIMFKOMLN<TimeSpan> NDCCFNBOJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly FMNIMFKOMLN<bool> HHBJPJKPHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly FMNIMFKOMLN<bool> JODGIJGHOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly FMNIMFKOMLN<bool> EGIACJFBEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly FMNIMFKOMLN<int> OFHAIOLBOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly FMNIMFKOMLN<bool> FEFDIDLHJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly FMNIMFKOMLN<bool> KAKJGPPBEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly FMNIMFKOMLN<JLFFPKKOLLM> BNPNLENDPKC;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan EMIBBBNHBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x807A670", Offset = "0x8079A70", VA = "0x18807A670", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan AMAABLFEJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x807A630", Offset = "0x8079A30", VA = "0x18807A630", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan PKIEGBDPHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x807A460", Offset = "0x8079860", VA = "0x18807A460", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan AAKKAOOGLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x807A4E0", Offset = "0x80798E0", VA = "0x18807A4E0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool FOEECLGDAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x807A6F0", Offset = "0x8079AF0", VA = "0x18807A6F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool IBAOGCKFLML
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x807A5F0", Offset = "0x80799F0", VA = "0x18807A5F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool HPFDDJIIDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x807A5B0", Offset = "0x80799B0", VA = "0x18807A5B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int KHJLJCPCOCI
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x807A4A0", Offset = "0x80798A0", VA = "0x18807A4A0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool KAHEBEJFJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x807A6B0", Offset = "0x8079AB0", VA = "0x18807A6B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool HNHNBAFPKLA
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x807A520", Offset = "0x8079920", VA = "0x18807A520", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool PHBCHLNMPPK
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x807A560", Offset = "0x8079960", VA = "0x18807A560", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x807A730", Offset = "0x8079B30", VA = "0x18807A730")]
	[UnityEngine.Scripting.Preserve]
	public HCDAJCMLMFC([CMKKAFOAFJE(null)] NNOOHIAHMIG ENFLKMBLIJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class GJDGNNNKEAP : HNHLGDCHOMD, KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class ONDHPEBAAHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public BMAMFBAMLOB roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public ONDHPEBAAHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x808D0E0", Offset = "0x808C4E0", VA = "0x18808D0E0")]
		internal object EEJBFKCGCHK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action GBHCFOKKOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8078CB0", Offset = "0x80780B0", VA = "0x188078CB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8079370", Offset = "0x8078770", VA = "0x188079370", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event GCAPAODEIHF MJOEKHHMKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8078F10", Offset = "0x8078310", VA = "0x188078F10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8078C10", Offset = "0x8078010", VA = "0x188078C10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event GCAPAODEIHF LADLHDPNCBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8079410", Offset = "0x8078810", VA = "0x188079410", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8079220", Offset = "0x8078620", VA = "0x188079220", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event GCAPAODEIHF DHEFDFMPOFP
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8079060", Offset = "0x8078460", VA = "0x188079060", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8079180", Offset = "0x8078580", VA = "0x188079180", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<PPKFOIPGIIE, bool> JLBIEPCIMGB
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8078FB0", Offset = "0x80783B0", VA = "0x188078FB0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x80792C0", Offset = "0x80786C0", VA = "0x1880792C0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "19")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8078A20", Offset = "0x8077E20", VA = "0x188078A20", Slot = "14")]
	public void ABHHMHNIBEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8079150", Offset = "0x8078550", VA = "0x188079150", Slot = "15")]
	public void KHHHBFHKFDD(BMAMFBAMLOB GKBKHGJHGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x80794B0", Offset = "0x80788B0", VA = "0x1880794B0", Slot = "16")]
	public void OEBADAAGJNM(BMAMFBAMLOB GKBKHGJHGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x80794E0", Offset = "0x80788E0", VA = "0x1880794E0", Slot = "17")]
	public void PCFAPJEIKIP(BMAMFBAMLOB GKBKHGJHGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8079100", Offset = "0x8078500", VA = "0x188079100", Slot = "18")]
	public void JNMCIAICKAN(PPKFOIPGIIE CMJLDNADNMP, bool JKLFEMENKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x8078D50", Offset = "0x8078150", VA = "0x188078D50")]
	private void HKANHPMMIAO(GCAPAODEIHF ENGJIBHFOBO, BMAMFBAMLOB GKBKHGJHGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public GJDGNNNKEAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[UnityEngine.Scripting.Preserve]
internal class DJIFBPIFJEH : JKCJLPBKNAB, KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class MPFDAIAFENH : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct GMODJBPHFJM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public MPFDAIAFENH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public JKCJLPBKNAB.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private IFKKDICMKCC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private LDINNJCHBAF[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private TaskAwaiter<LDINNJCHBAF.EGBDLOOLBIJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x8079510", Offset = "0x8078910", VA = "0x188079510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x8079C40", Offset = "0x8079040", VA = "0x188079C40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private struct ILAHHDLCEBN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public AsyncTaskMethodBuilder<LDINNJCHBAF.EGBDLOOLBIJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public LDINNJCHBAF fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public MPFDAIAFENH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public JKCJLPBKNAB.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private IFKKDICMKCC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private IIPFHLEMLIB <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private TaskAwaiter<LDINNJCHBAF.EGBDLOOLBIJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x807C080", Offset = "0x807B480", VA = "0x18807C080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x807CD10", Offset = "0x807C110", VA = "0x18807CD10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class CACMJHFFIFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public LDINNJCHBAF fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public CACMJHFFIFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x8073CD0", Offset = "0x80730D0", VA = "0x188073CD0")]
			internal object AMOPHHKPMNO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Task NHNFPALEEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationTokenSource NKPAICCCLOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public IIPFHLEMLIB APMLGCPJHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public BEHHGOBGNKL IAPHFNOPBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public HGLMOIEJBBA HNJAPPGCPFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public ELMNGLJGGCK HHOKLMFBNEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public LDINNJCHBAF[] FKGLCEAOOOB;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool IAEHNHFNHAH
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x807BC70", Offset = "0x807B070", VA = "0x18807BC70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool DHMAOLDECCE
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x807BAD0", Offset = "0x807AED0", VA = "0x18807BAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x808A720", Offset = "0x8089B20", VA = "0x18808A720")]
		public MPFDAIAFENH(BEHHGOBGNKL IAPHFNOPBJO, HGLMOIEJBBA HNJAPPGCPFF, ELMNGLJGGCK HHOKLMFBNEK, LDINNJCHBAF[] FKGLCEAOOOB, CancellationToken LMNHDKIFBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8089430", Offset = "0x8088830", VA = "0x188089430", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x80897E0", Offset = "0x8088BE0", VA = "0x1880897E0")]
		public void FGOHIBDFIND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x808A110", Offset = "0x8089510", VA = "0x18808A110")]
		public void NFKAGBILBAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8088C30", Offset = "0x8088030", VA = "0x188088C30")]
		public void APANDHLIDIF(JKCJLPBKNAB.Reason IAMAGDICGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x80896E0", Offset = "0x8088AE0", VA = "0x1880896E0")]
		[AsyncStateMachine(typeof(GMODJBPHFJM))]
		public Task FFFNGMNJBBP(JKCJLPBKNAB.Reason JKODLOFLBMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x808A270", Offset = "0x8089670", VA = "0x18808A270")]
		[AsyncStateMachine(typeof(ILAHHDLCEBN))]
		private Task<LDINNJCHBAF.EGBDLOOLBIJ> PGAFCHFOODF(JKCJLPBKNAB.Reason JKODLOFLBMK, LDINNJCHBAF FFGBAAEHMCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x80895C0", Offset = "0x80889C0", VA = "0x1880895C0")]
		private void FFDMHCDHPFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8089DB0", Offset = "0x80891B0", VA = "0x188089DB0")]
		public bool KMNLIMJIKOE(JKCJLPBKNAB.Reason GMHJKFAIEGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8089E60", Offset = "0x8089260", VA = "0x188089E60")]
		private void MPLCOKOEFLA(IIPFHLEMLIB DHJOIBPBMPI, JKCJLPBKNAB.Reason JKODLOFLBMK = JKCJLPBKNAB.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8089040", Offset = "0x8088440", VA = "0x188089040")]
		private void CFINCOMEDOM(IIPFHLEMLIB DHJOIBPBMPI, LDINNJCHBAF.EGBDLOOLBIJ HBALBIOOGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8089C10", Offset = "0x8089010", VA = "0x188089C10")]
		private void IHEKIKPMAAO(IIPFHLEMLIB DHJOIBPBMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8089850", Offset = "0x8088C50", VA = "0x188089850")]
		private void FLKGJLPJKOF(IIPFHLEMLIB DHJOIBPBMPI, LDINNJCHBAF.EGBDLOOLBIJ HBALBIOOGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8088EE0", Offset = "0x80882E0", VA = "0x188088EE0")]
		private void APKODIIIAEE(IIPFHLEMLIB DHJOIBPBMPI, Exception BLCFGIAFKHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8089320", Offset = "0x8088720", VA = "0x188089320")]
		private void DPHJNLHJAIL(LDINNJCHBAF FFGBAAEHMCF, JKCJLPBKNAB.Reason JKODLOFLBMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8089210", Offset = "0x8088610", VA = "0x188089210")]
		private void DGCNDFCDMIN(LDINNJCHBAF FFGBAAEHMCF, JKCJLPBKNAB.Reason JKODLOFLBMK, string HEMALCCNKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x808A3B0", Offset = "0x80897B0", VA = "0x18808A3B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class IIPFHLEMLIB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Task<LDINNJCHBAF.EGBDLOOLBIJ> NHNFPALEEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public CancellationTokenSource NKPAICCCLOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public LDINNJCHBAF FFGBAAEHMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public JKCJLPBKNAB.Reason IAMAGDICGLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public HashSet<JKCJLPBKNAB.Reason> BFDKCOPLGCA;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool IAEHNHFNHAH
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x807BC70", Offset = "0x807B070", VA = "0x18807BC70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool DHMAOLDECCE
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x807BAD0", Offset = "0x807AED0", VA = "0x18807BAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x807BB10", Offset = "0x807AF10", VA = "0x18807BB10")]
		public void OAALHNMPGBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x807BAF0", Offset = "0x807AEF0", VA = "0x18807BAF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x807BC90", Offset = "0x807B090", VA = "0x18807BC90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x807BFF0", Offset = "0x807B3F0", VA = "0x18807BFF0")]
		public IIPFHLEMLIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class OHJMDOIHCKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public JKCJLPBKNAB.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public OHJMDOIHCKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x808CF00", Offset = "0x808C300", VA = "0x18808CF00")]
		internal object OJHCFMNNBLB(IIPFHLEMLIB x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x808CE20", Offset = "0x808C220", VA = "0x18808CE20")]
		internal object AINOLGOIPJF(MPFDAIAFENH x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x808CE90", Offset = "0x808C290", VA = "0x18808CE90")]
		internal object NILEDJOAJKI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct LJENHBJFAIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public JKCJLPBKNAB.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public DJIFBPIFJEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private OHJMDOIHCKL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8085580", Offset = "0x8084980", VA = "0x188085580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8085FE0", Offset = "0x80853E0", VA = "0x188085FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct CIJNAMHKHIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public DJIFBPIFJEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public JKCJLPBKNAB.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private MPFDAIAFENH <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8074250", Offset = "0x8073650", VA = "0x188074250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8074EC0", Offset = "0x80742C0", VA = "0x188074EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct LMCPCFOPHKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public DJIFBPIFJEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x80863F0", Offset = "0x80857F0", VA = "0x1880863F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8086960", Offset = "0x8085D60", VA = "0x188086960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	internal static readonly GBHBOJAPDOA LDIAFBDGCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private BEHHGOBGNKL IAPHFNOPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private MPFDAIAFENH BGKJBFHENNC;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private CDCAHPMDKLI JLEJGCAJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8076600", Offset = "0x8075A00", VA = "0x188076600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool CHDMODABKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x223F6F0", Offset = "0x223EAF0", VA = "0x18223F6F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool MJCABOOJDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8076650", Offset = "0x8075A50", VA = "0x188076650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x8076580", Offset = "0x8075980", VA = "0x188076580", Slot = "7")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x80764A0", Offset = "0x80758A0", VA = "0x1880764A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x80766C0", Offset = "0x8075AC0", VA = "0x1880766C0", Slot = "9")]
	public void OAALHNMPGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8076B10", Offset = "0x8075F10", VA = "0x188076B10")]
	private bool PHAPEABJODD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x8075F20", Offset = "0x8075320", VA = "0x188075F20", Slot = "6")]
	private void BCDHNIBLOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x8075FF0", Offset = "0x80753F0", VA = "0x188075FF0", Slot = "5")]
	[AsyncStateMachine(typeof(LJENHBJFAIB))]
	private Task DDAIJHLCLOM(JKCJLPBKNAB.Reason JKODLOFLBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x8076840", Offset = "0x8075C40", VA = "0x188076840")]
	private bool PFAGCNNJELG(JKCJLPBKNAB.Reason JKODLOFLBMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x80760E0", Offset = "0x80754E0", VA = "0x1880760E0")]
	private LDINNJCHBAF[] DILNILCLOCD(ELMNGLJGGCK JNCILALKDNL, HGLMOIEJBBA GFEIMBGNADK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x8076BF0", Offset = "0x8075FF0", VA = "0x188076BF0")]
	[AsyncStateMachine(typeof(CIJNAMHKHIN))]
	private Task PHBLCGMKOIN(JKCJLPBKNAB.Reason JKODLOFLBMK, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x80764B0", Offset = "0x80758B0", VA = "0x1880764B0")]
	[AsyncStateMachine(typeof(LMCPCFOPHKM))]
	private Task EPAHABENECF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public DJIFBPIFJEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class BBMJPJNDFEI : LBDHEDHCFOP, KBHPKIEBIBJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct EIFCLDBBMAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public ELMNGLJGGCK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public BBMJPJNDFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public ALODEKIMLIG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8077B20", Offset = "0x8076F20", VA = "0x188077B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8078480", Offset = "0x8077880", VA = "0x188078480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct ADGNEKJPLCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public BBMJPJNDFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public ELMNGLJGGCK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public ALODEKIMLIG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private APGKENHKANG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private IFKKDICMKCC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private IGPBPPCMANO <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private PIOLBCBDLJN <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x806E490", Offset = "0x806D890", VA = "0x18806E490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x806F1D0", Offset = "0x806E5D0", VA = "0x18806F1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class DLEJEFAJEKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public Matchmaking.NBPOMBJHFGA result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public FPPEPKADMMN errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public DLEJEFAJEKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8077500", Offset = "0x8076900", VA = "0x188077500")]
		internal object BMPIAIKIGBJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class PDBMHFNMMJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Task<NAMDFBDBPAO> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public PDBMHFNMMJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		internal Task<NAMDFBDBPAO> PJBMPNGMCEN(APGKENHKANG<string>.EEEKGBDKLHP _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct KIGINKMJBFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public BBMJPJNDFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public ELMNGLJGGCK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public ALODEKIMLIG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public IGPBPPCMANO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private PDBMHFNMMJM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private LIJGGIIFNIO <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private IFKKDICMKCC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private APGKENHKANG<string>.EEEKGBDKLHP <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private FAHCCCHCJAA <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private Task<Matchmaking.FIHFEJPLBAH> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private PBHBHLLFPAM <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.FIHFEJPLBAH> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter<NAMDFBDBPAO> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x807EB60", Offset = "0x807DF60", VA = "0x18807EB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8084580", Offset = "0x8083980", VA = "0x188084580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct HBIEIPGCPNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public BBMJPJNDFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private APGKENHKANG<string>.EEEKGBDKLHP <disconnectTimerScope>5__3;

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
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x809A900", Offset = "0x8099D00", VA = "0x18809A900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x809B360", Offset = "0x809A760", VA = "0x18809B360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct CMJBEAAHINB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public BBMJPJNDFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private DHLGDCALOEP <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8095030", Offset = "0x8094430", VA = "0x188095030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x80954C0", Offset = "0x80948C0", VA = "0x1880954C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct CLFCHKEHDCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public AsyncTaskMethodBuilder<Matchmaking.FIHFEJPLBAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public ELMNGLJGGCK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public BBMJPJNDFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TaskAwaiter<Matchmaking.FIHFEJPLBAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8094AE0", Offset = "0x8093EE0", VA = "0x188094AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8094FC0", Offset = "0x80943C0", VA = "0x188094FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct IKJLKILLMOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public Matchmaking.FIHFEJPLBAH serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public BBMJPJNDFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public IGPBPPCMANO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private TaskAwaiter<ODLMCKNIIID> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x809EC10", Offset = "0x809E010", VA = "0x18809EC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x809F250", Offset = "0x809E650", VA = "0x18809F250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class LIJFPDMDPAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public ELMNGLJGGCK targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public LIJFPDMDPAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x80A6210", Offset = "0x80A5610", VA = "0x1880A6210")]
		internal object FEPFDLFCKCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x80A6110", Offset = "0x80A5510", VA = "0x1880A6110")]
		internal string DFHOMJKAHNI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct OLCNINLEKLE : IAsyncStateMachine
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
		public ELMNGLJGGCK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public BBMJPJNDFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private LIJFPDMDPAL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private IFKKDICMKCC <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x80AA3E0", Offset = "0x80A97E0", VA = "0x1880AA3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x80AAF70", Offset = "0x80AA370", VA = "0x1880AAF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct MBLMHNIDJMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public BBMJPJNDFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public IGPBPPCMANO joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public NAMDFBDBPAO initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public ELMNGLJGGCK targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public LIJGGIIFNIO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private APGKENHKANG<string>.EEEKGBDKLHP <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x80A6310", Offset = "0x80A5710", VA = "0x1880A6310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x80A6B00", Offset = "0x80A5F00", VA = "0x1880A6B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct CILHPCKCCLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public BBMJPJNDFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private APGKENHKANG<string>.EEEKGBDKLHP <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private IFKKDICMKCC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap3;

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
		private IFKKDICMKCC <>7__wrap5;

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
		[Cpp2IlInjected.Address(RVA = "0x80931E0", Offset = "0x80925E0", VA = "0x1880931E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x80949C0", Offset = "0x8093DC0", VA = "0x1880949C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct EHMJHMLIHPI : IAsyncStateMachine
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
		public NCKNCPPCAHN localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public BBMJPJNDFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<OGJPCDKPGHL> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8097370", Offset = "0x8096770", VA = "0x188097370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8097B70", Offset = "0x8096F70", VA = "0x188097B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class HLFMJHFGFDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public ELMNGLJGGCK targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public HLFMJHFGFDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x809C820", Offset = "0x809BC20", VA = "0x18809C820")]
		internal object AAOIMBLFKFL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class EGHLIAEEGAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public EGHLIAEEGAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x80971D0", Offset = "0x80965D0", VA = "0x1880971D0")]
		internal void KNBNFONDKMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class CMPKOCHPMKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public ELMNGLJGGCK targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public CMPKOCHPMKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8095520", Offset = "0x8094920", VA = "0x188095520")]
		internal object KDBKBHIONFC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class EHFDBNFGGBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public ELMNGLJGGCK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public EHFDBNFGGBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8097270", Offset = "0x8096670", VA = "0x188097270")]
		internal string CEBDIHBBIOO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly GBHBOJAPDOA GIBCMDFGDCJ;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly GBHBOJAPDOA MEFLDIIHLNI;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly GBHBOJAPDOA JHBFPDNHGJL;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly string EIPMIDHAGLB;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static readonly string GHDMIPHAGBN;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static readonly string EICMGIFGKLF;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public static readonly Guid JHDIHOMMOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private EGBBHHGAGKN BDFIBCDOEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private AKDJHEMIBMN MIPJJEBLOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private FMKBFEIFICC BOGAODIGBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private BEHHGOBGNKL IAPHFNOPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private JKCJLPBKNAB MGBCFAFLPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private PMMACJEODNL AEDDIMEJOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private HNHLGDCHOMD JIHGMCPNOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private GLNEFDGIGPM GNLBINGGPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private OOEHFEBFNNO LBNHFJAFLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private IDisposable BGIHGEOFKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private FAOIIFKBBED HKHKDBPNEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly CEGHMOMNMEC KBKOFDBMDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private PBHBHLLFPAM KINGAKNDOMF;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus BNLIINMELIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9D1DA0", Offset = "0x9D11A0", VA = "0x1809D1DA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x11E84D0", Offset = "0x11E78D0", VA = "0x1811E84D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CDCAHPMDKLI JLEJGCAJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8072320", Offset = "0x8071720", VA = "0x188072320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8071BC0", Offset = "0x8070FC0", VA = "0x188071BC0", Slot = "6")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x80709F0", Offset = "0x806FDF0", VA = "0x1880709F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8073890", Offset = "0x8072C90", VA = "0x188073890", Slot = "5")]
	[AsyncStateMachine(typeof(EIFCLDBBMAF))]
	public Task PPPOMNFHKIF(ELMNGLJGGCK DKEKMBLAHBL, ALODEKIMLIG KFJFIDCNJLA, CancellationToken BOHHBCNKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8072A50", Offset = "0x8071E50", VA = "0x188072A50")]
	[AsyncStateMachine(typeof(ADGNEKJPLCH))]
	private Task MKACOFIGHAN(ELMNGLJGGCK DKEKMBLAHBL, ALODEKIMLIG KFJFIDCNJLA, CancellationToken BOHHBCNKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8071760", Offset = "0x8070B60", VA = "0x188071760")]
	private void FNPNNGAIDDH(GLNEFDGIGPM GNLBINGGPAL, ELMNGLJGGCK DKEKMBLAHBL, Exception BLCFGIAFKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8070CF0", Offset = "0x80700F0", VA = "0x188070CF0")]
	private static void FIBBGIIFDEI(PIOLBCBDLJN ILHJJILDJLG, Exception BLCFGIAFKHH, [Optional] List<int> LLNOOACPEAB, int OGMFGMCEAIC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8071FA0", Offset = "0x80713A0", VA = "0x188071FA0")]
	[AsyncStateMachine(typeof(KIGINKMJBFB))]
	private Task HHDIJOAHFFO(APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, ELMNGLJGGCK DKEKMBLAHBL, ALODEKIMLIG KFJFIDCNJLA, IGPBPPCMANO KCMOKJFLMKN, CancellationToken BOHHBCNKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x8070360", Offset = "0x806F760", VA = "0x188070360")]
	private void CBJLDFLHDNB([CallerMemberName] string CNBBADPEGOF = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x80721F0", Offset = "0x80715F0", VA = "0x1880721F0")]
	[AsyncStateMachine(typeof(HBIEIPGCPNO))]
	private Task JDPFJCBBPEE(APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x80732B0", Offset = "0x80726B0", VA = "0x1880732B0")]
	private void OHPMCAHGDOI(ELMNGLJGGCK DKEKMBLAHBL, CancellationToken BOHHBCNKHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8072F20", Offset = "0x8072320", VA = "0x188072F20")]
	private void OAHHIPNAGCC(ELMNGLJGGCK DKEKMBLAHBL, TaskStatus AIEJMDNEBEJ, string DAMFJFKKFBI, IGPBPPCMANO KCMOKJFLMKN, Exception OBHLNPEHLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8072400", Offset = "0x8071800", VA = "0x188072400")]
	private void KKKPNOLBHFP(ELMNGLJGGCK DKEKMBLAHBL, IGPBPPCMANO KCMOKJFLMKN, OperationCanceledException LOGCOHCKONG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8070640", Offset = "0x806FA40", VA = "0x188070640")]
	private void CMLFHBILFPM(ELMNGLJGGCK DKEKMBLAHBL, IGPBPPCMANO KCMOKJFLMKN, Exception BLCFGIAFKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8072C00", Offset = "0x8072000", VA = "0x188072C00")]
	private void NGNMHEHPDAB(ELMNGLJGGCK DKEKMBLAHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8071EE0", Offset = "0x80712E0", VA = "0x188071EE0")]
	private static BMAMFBAMLOB GDKHDPPECMA(ELMNGLJGGCK DKEKMBLAHBL)
	{
		return default(BMAMFBAMLOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8073730", Offset = "0x8072B30", VA = "0x188073730")]
	[AsyncStateMachine(typeof(CMJBEAAHINB))]
	private Task PNGLMIHIAEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x80704E0", Offset = "0x806F8E0", VA = "0x1880704E0")]
	[AsyncStateMachine(typeof(CLFCHKEHDCF))]
	private Task<Matchmaking.FIHFEJPLBAH> CJIIMDJAJFD(ELMNGLJGGCK DKEKMBLAHBL, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8072E10", Offset = "0x8072210", VA = "0x188072E10")]
	private static ODLMCKNIIID NNLGBGDEHGN(Matchmaking.FIHFEJPLBAH ONBLFPEPINM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x80735E0", Offset = "0x80729E0", VA = "0x1880735E0")]
	[AsyncStateMachine(typeof(IKJLKILLMOE))]
	private Task PFGNJAGKCNC(Matchmaking.FIHFEJPLBAH ONBLFPEPINM, IGPBPPCMANO KCMOKJFLMKN, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken ACCKNLEMPFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x8072680", Offset = "0x8071A80", VA = "0x188072680")]
	[AsyncStateMachine(typeof(OLCNINLEKLE))]
	private Task LAJMFNDEIOM(ELMNGLJGGCK DKEKMBLAHBL, CancellationTokenSource NKNPKGFGJPB, Task IMAIBDLBBDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x8072510", Offset = "0x8071910", VA = "0x188072510")]
	[AsyncStateMachine(typeof(MBLMHNIDJMM))]
	private Task KPFHKHADLBE(NAMDFBDBPAO GNMBKDKPGHM, LIJGGIIFNIO ICHECBEBLLL, ELMNGLJGGCK CEPLFOPGMML, IGPBPPCMANO CEKFIJNJKCK, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken BIPEFMIMBHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x8070800", Offset = "0x806FC00", VA = "0x188070800")]
	private IGPBPPCMANO DLBEAEPKHLG(IGPBPPCMANO CEKFIJNJKCK, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x80706C0", Offset = "0x806FAC0", VA = "0x1880706C0")]
	[AsyncStateMachine(typeof(CILHPCKCCLG))]
	private Task DHNFANGIKGB(APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8073180", Offset = "0x8072580", VA = "0x188073180")]
	[AsyncStateMachine(typeof(EHMJHMLIHPI))]
	private Task OCDAEKLBIEJ(CancellationToken LMNHDKIFBOH, int BNOGLLLKJPP, NCKNCPPCAHN MNHJBCEPCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x80728D0", Offset = "0x8071CD0", VA = "0x1880728D0")]
	private static void MAAMEOOGHIP(ELMNGLJGGCK DKEKMBLAHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8071530", Offset = "0x8070930", VA = "0x188071530")]
	private void FKGODGMECJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8072480", Offset = "0x8071880", VA = "0x188072480")]
	private void KMNAJFPLKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8072370", Offset = "0x8071770", VA = "0x188072370")]
	private void KCGEBLDDCAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x8073800", Offset = "0x8072C00", VA = "0x188073800")]
	private void POMCGJAGDME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x8072100", Offset = "0x8071500", VA = "0x188072100")]
	private static void IMFJGGCAMPG(ELMNGLJGGCK DKEKMBLAHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x80727C0", Offset = "0x8071BC0", VA = "0x1880727C0")]
	private static CancellationTokenRegistration LPCAMNFJFMG(ELMNGLJGGCK DKEKMBLAHBL, CancellationToken ACCKNLEMPFA)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x8070A40", Offset = "0x806FE40", VA = "0x188070A40")]
	private static void EDJCKDGBBAO(ELMNGLJGGCK DKEKMBLAHBL, Exception BLCFGIAFKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x8070B40", Offset = "0x806FF40", VA = "0x188070B40")]
	private void EHDGAJIDPNO(ELMNGLJGGCK DKEKMBLAHBL, Task IMAIBDLBBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x8071F40", Offset = "0x8071340", VA = "0x188071F40")]
	private static void GFDFDHMHGGA(Func<string> GJKLHCCFCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8073BD0", Offset = "0x8072FD0", VA = "0x188073BD0")]
	public BBMJPJNDFEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x8072BA0", Offset = "0x8071FA0", VA = "0x188072BA0")]
	[CompilerGenerated]
	internal static (int, int?) MKEILMPCKBH(FPPEPKADMMN HLLDLKNABPD)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[RecRoom.NoEngine.Common.Preserve]
internal class LFGEKCFKGKA : BFEJMCCPNJJ, KBHPKIEBIBJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct NJPLOEJDFHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public LFGEKCFKGKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public NCKNCPPCAHN localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x80A7000", Offset = "0x80A6400", VA = "0x1880A7000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x80A74E0", Offset = "0x80A68E0", VA = "0x1880A74E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class GGEAMOPNLMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public LFGEKCFKGKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public NCKNCPPCAHN localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public GGEAMOPNLMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x809A150", Offset = "0x8099550", VA = "0x18809A150")]
		internal List<Task> KDDHDABOKFK(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct HCBMLOFHMHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public OAKJPOKLEGC taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public NCKNCPPCAHN localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x809B3C0", Offset = "0x809A7C0", VA = "0x18809B3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x809B760", Offset = "0x809AB60", VA = "0x18809B760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct DLJOPGHEPGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public LFGEKCFKGKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8095A70", Offset = "0x8094E70", VA = "0x188095A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8095D50", Offset = "0x8095150", VA = "0x188095D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly HashSet<OAKJPOKLEGC> MFANICKDCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private AKDJHEMIBMN MIPJJEBLOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private HHAPIHFLFHJ DKCPKDDFFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private OLJOBLKCAHJ DDAJDGHABBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private IDisposable BGIHGEOFKBF;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x80A51D0", Offset = "0x80A45D0", VA = "0x1880A51D0", Slot = "5")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x80A5170", Offset = "0x80A4570", VA = "0x1880A5170", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x80A5DB0", Offset = "0x80A51B0", VA = "0x1880A5DB0", Slot = "4")]
	public bool OPANAFEAEEP(OAKJPOKLEGC GKMLILDEFIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x80A5CE0", Offset = "0x80A50E0", VA = "0x1880A5CE0")]
	private void OMNOGAGKPNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x80A4E80", Offset = "0x80A4280", VA = "0x1880A4E80")]
	private void AONEGKGJOBB(FEJGNMMNDHD LLMAFCHBBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x80A54B0", Offset = "0x80A48B0", VA = "0x1880A54B0")]
	[AsyncStateMachine(typeof(NJPLOEJDFHM))]
	private Task KEDHMFIGGGO(int BNOGLLLKJPP, NCKNCPPCAHN MNHJBCEPCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x80A50A0", Offset = "0x80A44A0", VA = "0x1880A50A0")]
	private Func<CancellationToken, List<Task>> APJIPNJFDOJ(int BNOGLLLKJPP, NCKNCPPCAHN MNHJBCEPCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x80A5670", Offset = "0x80A4A70", VA = "0x1880A5670")]
	private List<Task> NPALFNDHBAF(int BNOGLLLKJPP, NCKNCPPCAHN MNHJBCEPCPN, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x80A5BC0", Offset = "0x80A4FC0", VA = "0x1880A5BC0")]
	[AsyncStateMachine(typeof(HCBMLOFHMHF))]
	private Task OAMCFHGJDBB(OAKJPOKLEGC IJBCOFDMABE, CancellationToken HHGPJKKLNIG, int BNOGLLLKJPP, NCKNCPPCAHN MNHJBCEPCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x80A55A0", Offset = "0x80A49A0", VA = "0x1880A55A0")]
	[AsyncStateMachine(typeof(DLJOPGHEPGE))]
	private Task LJHMJLADKMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x80A5B40", Offset = "0x80A4F40", VA = "0x1880A5B40")]
	private void OAALHNMPGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x80A5E10", Offset = "0x80A5210", VA = "0x1880A5E10")]
	public LFGEKCFKGKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[UnityEngine.Scripting.Preserve]
internal sealed class DMEABMCOKHB : IBOGFHOCCBO, KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class LBNCAHIOKBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public LBNCAHIOKBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x80A2FB0", Offset = "0x80A23B0", VA = "0x1880A2FB0")]
		internal object KDPHEDNFOIK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class AENEHADDPAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public AENEHADDPAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x808F680", Offset = "0x808EA80", VA = "0x18808F680")]
		internal object AFNGAGMICKL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class OHOFCNPNEME
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public OHOFCNPNEME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class JIJLNFBEHEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public JIJLNFBEHEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x80A0790", Offset = "0x809FB90", VA = "0x1880A0790")]
		internal object JCCFHANCJGD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class ACKHADGBDHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public ACKHADGBDHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x808F620", Offset = "0x808EA20", VA = "0x18808F620")]
		internal object BBJALLFHIIH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private readonly Dictionary<Guid, KJMEKGCBFNO> NDOOJONJDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private readonly TimeSpan MINJAACFLPN;

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "9")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x8095E20", Offset = "0x8095220", VA = "0x188095E20", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x8096370", Offset = "0x8095770", VA = "0x188096370", Slot = "4")]
	public FGFMLOMLHHI JJBKLNLGAIJ(Guid FDFDCKJIMBB)
	{
		return default(FGFMLOMLHHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x8096160", Offset = "0x8095560", VA = "0x188096160", Slot = "5")]
	public bool JEBJOEBLLEI(Guid FDFDCKJIMBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x8095E30", Offset = "0x8095230", VA = "0x188095E30", Slot = "6")]
	public bool IDKHLOEDIPG(Guid FDFDCKJIMBB, Task JBIOGHPPPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x80967C0", Offset = "0x8095BC0", VA = "0x1880967C0", Slot = "7")]
	public bool PPNGDMAJHKO(Guid FDFDCKJIMBB, OGJPCDKPGHL HNFLDGONBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8095DB0", Offset = "0x80951B0", VA = "0x188095DB0", Slot = "8")]
	public Task<(OGJPCDKPGHL, Task)> APPGNFKIDIP(Guid FDFDCKJIMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x8096590", Offset = "0x8095990", VA = "0x188096590")]
	private void OIOAELOHIEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x80969A0", Offset = "0x8095DA0", VA = "0x1880969A0")]
	public DMEABMCOKHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[RecRoom.NoEngine.Common.Preserve]
internal class OJOHBGMMIEP : MAIPAJJCPPG, KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private class JIBPAJGMCIA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private readonly ELMNGLJGGCK LAEOEHEDICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private readonly CancellationTokenSource MCOIFPENEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public readonly CancellationToken IFEMJINDLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private bool GIDIFBHLKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private bool ACJJLPFCEAB;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x80A06E0", Offset = "0x809FAE0", VA = "0x1880A06E0")]
		public JIBPAJGMCIA(ELMNGLJGGCK LAEOEHEDICK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x80A0590", Offset = "0x809F990", VA = "0x1880A0590")]
		public void OAALHNMPGBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x80A0560", Offset = "0x809F960", VA = "0x1880A0560", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class MOMLKPPECGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public OFLJMGOKAPC disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MOMLKPPECGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x80A6BC0", Offset = "0x80A5FC0", VA = "0x1880A6BC0")]
		internal object PBAKKAKPOCI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct GCJODFKCODG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public OFLJMGOKAPC disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public OJOHBGMMIEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8099C30", Offset = "0x8099030", VA = "0x188099C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x809A080", Offset = "0x8099480", VA = "0x18809A080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class FHLMNPGEEFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public OJOHBGMMIEP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public FHLMNPGEEFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x80995E0", Offset = "0x80989E0", VA = "0x1880995E0")]
		internal object JBGKGBNMFMC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class CJIJGFACFKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public ELMNGLJGGCK newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public FHLMNPGEEFC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public CJIJGFACFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x8094A20", Offset = "0x8093E20", VA = "0x188094A20")]
		internal object HCDFOEGIEGE((ELMNGLJGGCK lastLocalPlayerRoomInstance, ELMNGLJGGCK newRoomInstance, JKCJLPBKNAB fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct BNGGLBFLOJC : IAsyncStateMachine
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
		public OJOHBGMMIEP <>4__this;

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
		private IFKKDICMKCC <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x8091370", Offset = "0x8090770", VA = "0x188091370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class INKEBKHEOCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public ELMNGLJGGCK newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public INKEBKHEOCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x809F370", Offset = "0x809E770", VA = "0x18809F370")]
		internal object LHFHPBAENJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x809F2B0", Offset = "0x809E6B0", VA = "0x18809F2B0")]
		internal void GAFOINDHDCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x809F410", Offset = "0x809E810", VA = "0x18809F410")]
		internal object OFEFJLDNFCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x809F330", Offset = "0x809E730", VA = "0x18809F330")]
		internal object HDKCDOHIGCH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct KJIIKLPKCHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public ELMNGLJGGCK newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public OJOHBGMMIEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public ALODEKIMLIG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private INKEBKHEOCF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private IFKKDICMKCC <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x80A1800", Offset = "0x80A0C00", VA = "0x1880A1800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x80A27B0", Offset = "0x80A1BB0", VA = "0x1880A27B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly OIHBGKAGLJI.EMFDHBNFGAL ECOGEJFAIGK;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly AEHPAJILBPF MLBADPCMBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private AKDJHEMIBMN MIPJJEBLOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private JKCJLPBKNAB MGBCFAFLPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private BEHHGOBGNKL IAPHFNOPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private NFOKCOMKNBM HNFCGGMPMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private LBDHEDHCFOP OOLOGEGALNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private ELMNGLJGGCK HMGHDGMACJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private JIBPAJGMCIA IJEDFIFNDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private bool OOLNGPIEFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private Task BPPFDFDGAFK;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private CDCAHPMDKLI JLEJGCAJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x80A9980", Offset = "0x80A8D80", VA = "0x1880A9980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool FPMNBCOMPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xBC38E0", Offset = "0xBC2CE0", VA = "0x180BC38E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x80A8F90", Offset = "0x80A8390", VA = "0x1880A8F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x80A9500", Offset = "0x80A8900", VA = "0x1880A9500", Slot = "4")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x80A9390", Offset = "0x80A8790", VA = "0x1880A9390", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x80A90A0", Offset = "0x80A84A0", VA = "0x1880A90A0")]
	[AsyncStateMachine(typeof(GCJODFKCODG))]
	private Task BHOJDJGPEPG(OFLJMGOKAPC JHHDCJJPOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x80A97F0", Offset = "0x80A8BF0", VA = "0x1880A97F0")]
	private void IGPHPKOBPFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x80A9190", Offset = "0x80A8590", VA = "0x1880A9190")]
	private void BNFDNFKONOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x80A99D0", Offset = "0x80A8DD0", VA = "0x1880A99D0")]
	private void LBCPAGPKKEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x80A9320", Offset = "0x80A8720", VA = "0x1880A9320")]
	private bool BOMPFAEFHMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x80A9B50", Offset = "0x80A8F50", VA = "0x1880A9B50")]
	[AsyncStateMachine(typeof(BNGGLBFLOJC))]
	private void LBMIJMNFCGC(int LGLPENFMNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x80A9D50", Offset = "0x80A9150", VA = "0x1880A9D50")]
	private void NOKCLHJMFNF([Out] IDisposable BPIBJCJFFCI, [Out] IDisposable HHOFNEPKNCM, [Out] IDisposable LDKCBBIHOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x80A8FA0", Offset = "0x80A83A0", VA = "0x1880A8FA0")]
	private bool BDEBONMAIJH(ELMNGLJGGCK LAEOEHEDICK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x80A97A0", Offset = "0x80A8BA0", VA = "0x1880A97A0")]
	private void IBOHAAJDIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x80A9C20", Offset = "0x80A9020", VA = "0x1880A9C20")]
	[AsyncStateMachine(typeof(KJIIKLPKCHE))]
	private Task MKACOFIGHAN(ELMNGLJGGCK LAEOEHEDICK, ALODEKIMLIG KFJFIDCNJLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x80AA370", Offset = "0x80A9770", VA = "0x1880AA370")]
	public OJOHBGMMIEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[UnityEngine.Scripting.Preserve]
internal sealed class APCPCBFOAFB : PCJFOBAJPBG, KBHPKIEBIBJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct NJKLDIJMDEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<OGNLJOEPPKN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public APCPCBFOAFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<OGNLJOEPPKN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x80A6D00", Offset = "0x80A6100", VA = "0x1880A6D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x80A6F90", Offset = "0x80A6390", VA = "0x1880A6F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class LICNKPHEOJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public EPOGGLOBAKG message;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public LICNKPHEOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x80A60B0", Offset = "0x80A54B0", VA = "0x1880A60B0")]
		internal object MMCNKCLOHIG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class GNBLDFLCHMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public EPOGGLOBAKG messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public GNBLDFLCHMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x809A7F0", Offset = "0x8099BF0", VA = "0x18809A7F0")]
		internal object FLPLLNJDODG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class BGJNCILOMML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public EPOGGLOBAKG request;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public BGJNCILOMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8091310", Offset = "0x8090710", VA = "0x188091310")]
		internal object PHFPECDNHNB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct AAGBNKOJOLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public EPOGGLOBAKG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public APCPCBFOAFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<EBHOBHMGDHC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x808ECF0", Offset = "0x808E0F0", VA = "0x18808ECF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x808F5C0", Offset = "0x808E9C0", VA = "0x18808F5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class HFDHIJMILCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public EPOGGLOBAKG operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public HFDHIJMILCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x809C7C0", Offset = "0x809BBC0", VA = "0x18809C7C0")]
		internal object PHFIOAFPAGG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct PDGAOKOLFBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public EPOGGLOBAKG operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public APCPCBFOAFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private IGPBPPCMANO <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x80AB720", Offset = "0x80AAB20", VA = "0x1880AB720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x80AC290", Offset = "0x80AB690", VA = "0x1880AC290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct HMLCNDFLAMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public AsyncTaskMethodBuilder<EBHOBHMGDHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public APCPCBFOAFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public EPOGGLOBAKG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private MFLHJEJLHNB.KHENFLBPIDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private IGPBPPCMANO <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x809C9F0", Offset = "0x809BDF0", VA = "0x18809C9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x809CF20", Offset = "0x809C320", VA = "0x18809CF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class PCKNHLHNJEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public EBHOBHMGDHC operation;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public PCKNHLHNJEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x80AB6A0", Offset = "0x80AAAA0", VA = "0x1880AB6A0")]
		internal object KDHIFHADJFE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct JEFEGHAGIFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public EBHOBHMGDHC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public APCPCBFOAFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private APGKENHKANG<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x809F9C0", Offset = "0x809EDC0", VA = "0x18809F9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x80A0000", Offset = "0x809F400", VA = "0x1880A0000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class EFPGJKIIBEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public EPOGGLOBAKG request;

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public EFPGJKIIBEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8097170", Offset = "0x8096570", VA = "0x188097170")]
		internal object NJHODNDIAAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class IHGOLHOMPBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public EPOGGLOBAKG request;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public IHGOLHOMPBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x809E390", Offset = "0x809D790", VA = "0x18809E390")]
		internal object LOLKJBHFHFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private PMMACJEODNL AEDDIMEJOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private GMNBOJDPOMF AIBKIAEAGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private AKAGACKDLFM CDODBONFBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private FMKBFEIFICC BOGAODIGBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private TaskCompletionSource<OGNLJOEPPKN> DMGGEIOPJIH;

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x8090A90", Offset = "0x808FE90", VA = "0x188090A90", Slot = "7")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x80910B0", Offset = "0x80904B0", VA = "0x1880910B0", Slot = "6")]
	[AsyncStateMachine(typeof(NJKLDIJMDEP))]
	public Task<OGNLJOEPPKN> NGJKIOJDLDP(CancellationToken GHDNKDIFAGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8090C10", Offset = "0x8090010", VA = "0x188090C10", Slot = "4")]
	public void IEIBDBGMJEP(EPOGGLOBAKG DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x8090730", Offset = "0x808FB30", VA = "0x188090730", Slot = "5")]
	public void FMMMOAFEHEN(EPOGGLOBAKG HBNLBJJDBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x808FF60", Offset = "0x808F360", VA = "0x18808FF60")]
	[AsyncStateMachine(typeof(AAGBNKOJOLC))]
	private Task CFLMDPFEKLF(EPOGGLOBAKG ANMDEHLLLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x8090FA0", Offset = "0x80903A0", VA = "0x188090FA0")]
	[AsyncStateMachine(typeof(PDGAOKOLFBE))]
	private Task KHIKHGHCEAE(EPOGGLOBAKG DFHHMKOIGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x808FE10", Offset = "0x808F210", VA = "0x18808FE10")]
	[AsyncStateMachine(typeof(HMLCNDFLAMC))]
	private Task<EBHOBHMGDHC> BJEIAEMILIF(EPOGGLOBAKG ANMDEHLLLBJ, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x8090B80", Offset = "0x808FF80", VA = "0x188090B80")]
	private IGPBPPCMANO HOEBOMHOGLB(EPOGGLOBAKG KBECLOEPHKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x8090610", Offset = "0x808FA10", VA = "0x188090610")]
	[AsyncStateMachine(typeof(JEFEGHAGIFG))]
	private Task FDBMJLKOHLA(EBHOBHMGDHC EKJBIEIFIHC, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x8090400", Offset = "0x808F800", VA = "0x188090400")]
	private EBHOBHMGDHC DMMLNDENKLN(EPOGGLOBAKG ANMDEHLLLBJ, IGPBPPCMANO MMOEGADJJKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x3D90020", Offset = "0x3D8F420", VA = "0x183D90020")]
	private T EIPAMIOLDNO<T>(T FFOEEMKIKJO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x8090070", Offset = "0x808F470", VA = "0x188090070")]
	private EBHOBHMGDHC CKEKLLHKMPN(EPOGGLOBAKG ANMDEHLLLBJ, IGPBPPCMANO MMOEGADJJKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public APCPCBFOAFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class LEPJNHNJODF : GMNBOJDPOMF, KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class KDPDPBHGKBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public KDPDPBHGKBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x80A1790", Offset = "0x80A0B90", VA = "0x1880A1790")]
		internal object GPFECMHHKMN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class HAJIMHNNLML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public HAJIMHNNLML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x809A890", Offset = "0x8099C90", VA = "0x18809A890")]
		internal object BODLBOPAOOD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private FMKBFEIFICC BOGAODIGBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private AEFNHDNPDGB EJIFMKNBKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private PCJFOBAJPBG NIDMAHCNFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private IBOGFHOCCBO NDOOJONJDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private NGHCPIHNGGJ GGBHNFALOBC;

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x80A4610", Offset = "0x80A3A10", VA = "0x1880A4610", Slot = "6")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x80A4140", Offset = "0x80A3540", VA = "0x1880A4140", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x80A3B40", Offset = "0x80A2F40", VA = "0x1880A3B40", Slot = "4")]
	public FGFMLOMLHHI CMHKALEDHAA(EPOGGLOBAKG KEGFOJLGFBH)
	{
		return default(FGFMLOMLHHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x80A4400", Offset = "0x80A3800", VA = "0x1880A4400", Slot = "5")]
	public void FINDJJAMDBO(Guid FDFDCKJIMBB, Task JBIOGHPPPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x80A37D0", Offset = "0x80A2BD0", VA = "0x1880A37D0")]
	private void BMLCGOBJODA(byte MIDDANGFEAA, int PBDEPMNBOEB, object KDFIAKDDPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x80A3250", Offset = "0x80A2650", VA = "0x1880A3250")]
	private void BMGDGIHBPLO(HGEDMLNCGKA JOKKIDPHPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x80A4780", Offset = "0x80A3B80", VA = "0x1880A4780")]
	private void MGJOAOGHEEM(HGEDMLNCGKA JOKKIDPHPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x80A3010", Offset = "0x80A2410", VA = "0x1880A3010")]
	private void BEFAFHBHMJG(HGEDMLNCGKA JOKKIDPHPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x80A38A0", Offset = "0x80A2CA0", VA = "0x1880A38A0")]
	private OGJPCDKPGHL CKMEDBCMEHK(EPOGGLOBAKG KBECLOEPHKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x80A4A00", Offset = "0x80A3E00", VA = "0x1880A4A00")]
	private void MHEHAFHKFKE(EPOGGLOBAKG DFHHMKOIGME, OGJPCDKPGHL HNFLDGONBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x80A3F60", Offset = "0x80A3360", VA = "0x1880A3F60")]
	private bool DAIABHODGPG(EPOGGLOBAKG DFHHMKOIGME, OGJPCDKPGHL HNFLDGONBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x80A41F0", Offset = "0x80A35F0", VA = "0x1880A41F0")]
	private bool EGLGEHKFCHB(EPOGGLOBAKG LHPEOJEJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x80A4C00", Offset = "0x80A4000", VA = "0x1880A4C00")]
	private bool OKPOBPMMOMN(byte MIDDANGFEAA, ExitGames.Client.Photon.Hashtable JOKKIDPHPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public LEPJNHNJODF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[UnityEngine.Scripting.Preserve]
internal sealed class JHAMJKOPACI : ODLGNDIIDEN, KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class LHJLNACAPNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public OGNLJOEPPKN operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public JHAMJKOPACI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public EPOGGLOBAKG roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public LHJLNACAPNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x80A6040", Offset = "0x80A5440", VA = "0x1880A6040")]
		internal object HJMONLHNIDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x80A5EA0", Offset = "0x80A52A0", VA = "0x1880A5EA0")]
		internal object GMJGADGNGEP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct EAOFDJEMFME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public AsyncTaskMethodBuilder<OGJPCDKPGHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public JHAMJKOPACI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public EPOGGLOBAKG roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter<OGJPCDKPGHL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8096A60", Offset = "0x8095E60", VA = "0x188096A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8097100", Offset = "0x8096500", VA = "0x188097100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class GEDIJBMFFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public OGNLJOEPPKN operationType;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public GEDIJBMFFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x809A0E0", Offset = "0x80994E0", VA = "0x18809A0E0")]
		internal object PIFMGGNPPGM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class BADFKEKMPOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public EPOGGLOBAKG request;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public BADFKEKMPOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8091230", Offset = "0x8090630", VA = "0x188091230")]
		internal object MJGMDGJDCJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x80912A0", Offset = "0x80906A0", VA = "0x1880912A0")]
		internal object NHHBEMBCKCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x80911C0", Offset = "0x80905C0", VA = "0x1880911C0")]
		internal object LNFBHFIFACL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct JKDGCCPOFCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public AsyncTaskMethodBuilder<OGJPCDKPGHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public EPOGGLOBAKG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public JHAMJKOPACI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private BADFKEKMPOF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private FGFMLOMLHHI <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private OGJPCDKPGHL <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<(OGJPCDKPGHL validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x80A07F0", Offset = "0x809FBF0", VA = "0x1880A07F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x80A10C0", Offset = "0x80A04C0", VA = "0x1880A10C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private FMKBFEIFICC BOGAODIGBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private AEFNHDNPDGB EJIFMKNBKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private GMNBOJDPOMF AIBKIAEAGPH;

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x80A02C0", Offset = "0x809F6C0", VA = "0x1880A02C0", Slot = "5")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x80A0060", Offset = "0x809F460", VA = "0x1880A0060", Slot = "4")]
	[AsyncStateMachine(typeof(EAOFDJEMFME))]
	private Task<OGJPCDKPGHL> CECJOFJONKA(EPOGGLOBAKG KBECLOEPHKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x80A0370", Offset = "0x809F770", VA = "0x1880A0370")]
	private bool KCHALEHEGDE(OGNLJOEPPKN CMJLDNADNMP, [Out] OGJPCDKPGHL HBALBIOOGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x80A0180", Offset = "0x809F580", VA = "0x1880A0180")]
	[AsyncStateMachine(typeof(JKDGCCPOFCE))]
	private Task<OGJPCDKPGHL> CFLHNLMOLPH(EPOGGLOBAKG ANMDEHLLLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public JHAMJKOPACI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class FHCNGIFDNJK : DKOGEAIEABM, KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private struct KKECMPPAFHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public KKCEGILFGJB ODDGKOCCHKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public long BPDPABABPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public Guid? BEIAHCLMLED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public bool MGIOLMNEHAF;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct IJKAJHPDKEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public AsyncTaskMethodBuilder<NAMDFBDBPAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public ELMNGLJGGCK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public FHCNGIFDNJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter<IBBAMKLHGAN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<NAMDFBDBPAO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x809E5D0", Offset = "0x809D9D0", VA = "0x18809E5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x809EBA0", Offset = "0x809DFA0", VA = "0x18809EBA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class NLHNMBPNIFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public NLHNMBPNIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x80A7540", Offset = "0x80A6940", VA = "0x1880A7540")]
		internal object BJDMEEHJPMD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct JMDPMOLGFEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<IBBAMKLHGAN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public FHCNGIFDNJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public ELMNGLJGGCK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private NLHNMBPNIFG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter<IBBAMKLHGAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x80A1130", Offset = "0x80A0530", VA = "0x1880A1130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x80A1720", Offset = "0x80A0B20", VA = "0x1880A1720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct GCDPOLDCMMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder<NAMDFBDBPAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public FHCNGIFDNJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public ELMNGLJGGCK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public IBBAMKLHGAN roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<KKECMPPAFHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x8099650", Offset = "0x8098A50", VA = "0x188099650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8099BC0", Offset = "0x8098FC0", VA = "0x188099BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class IJFPIKLLDJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public IBBAMKLHGAN roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public IJFPIKLLDJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xDB4D10", Offset = "0xDB4110", VA = "0x180DB4D10")]
		internal bool GEOPPKGAPPD(GMHIEIPOGED sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x809E510", Offset = "0x809D910", VA = "0x18809E510")]
		internal object OJGFGOOHLJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x809E480", Offset = "0x809D880", VA = "0x18809E480")]
		internal object JOLDBBAMDID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x809E3F0", Offset = "0x809D7F0", VA = "0x18809E3F0")]
		internal object JFLKIIICIKO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class OMGMEAAFNKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public IJFPIKLLDJH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public OMGMEAAFNKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x80AAFD0", Offset = "0x80AA3D0", VA = "0x1880AAFD0")]
		internal object HEDKABKIKFF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct HDLJCLEFDJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder<KKECMPPAFHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public IBBAMKLHGAN roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public FHCNGIFDNJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public ELMNGLJGGCK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private OMGMEAAFNKC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private TaskAwaiter<KKECMPPAFHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private TaskAwaiter<APIECIFOHEN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x809B7C0", Offset = "0x809ABC0", VA = "0x18809B7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x809C750", Offset = "0x809BB50", VA = "0x18809C750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class MPGIIBKAAPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MPGIIBKAAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x80A6C50", Offset = "0x80A6050", VA = "0x1880A6C50")]
		internal object CDIAFPCEPJE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct AJIDACGBBFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AsyncTaskMethodBuilder<KKECMPPAFHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public GMHIEIPOGED subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public FHCNGIFDNJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public ELMNGLJGGCK dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private MPGIIBKAAPB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private TaskAwaiter<GKGFGBABKAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x808F6E0", Offset = "0x808EAE0", VA = "0x18808F6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x808FDA0", Offset = "0x808F1A0", VA = "0x18808FDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private BEHHGOBGNKL IAPHFNOPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private NFOKCOMKNBM HNFCGGMPMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private CADBKKNPFMF AHAJFADKBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private GHPEFBEBANI MDOBPJGPEIF;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x80990C0", Offset = "0x80984C0", VA = "0x1880990C0", Slot = "5")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x80991B0", Offset = "0x80985B0", VA = "0x1880991B0", Slot = "4")]
	[AsyncStateMachine(typeof(IJKAJHPDKEH))]
	public Task<NAMDFBDBPAO> JHOKNIONKNO(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, ELMNGLJGGCK DKEKMBLAHBL, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x8099310", Offset = "0x8098710", VA = "0x188099310")]
	[AsyncStateMachine(typeof(JMDPMOLGFEB))]
	private Task<IBBAMKLHGAN> KFJCAOIJLKH(ELMNGLJGGCK DKEKMBLAHBL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x8098DE0", Offset = "0x80981E0", VA = "0x188098DE0")]
	[AsyncStateMachine(typeof(GCDPOLDCMMO))]
	private Task<NAMDFBDBPAO> AGFPFNMFDPO(ELMNGLJGGCK DKEKMBLAHBL, IBBAMKLHGAN ADBOOCEJEGJ, long JCNNPHFBOMP, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x8098F50", Offset = "0x8098350", VA = "0x188098F50")]
	[AsyncStateMachine(typeof(HDLJCLEFDJC))]
	private Task<KKECMPPAFHI> EKHIGHENODM(ELMNGLJGGCK DKEKMBLAHBL, IBBAMKLHGAN ADBOOCEJEGJ, long JCNNPHFBOMP, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x8099470", Offset = "0x8098870", VA = "0x188099470")]
	[AsyncStateMachine(typeof(AJIDACGBBFM))]
	private Task<KKECMPPAFHI> MGOJBENCPJN(ELMNGLJGGCK AOIOEMLIMME, GMHIEIPOGED FNFEBBMJIJM, long JCNNPHFBOMP, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public FHCNGIFDNJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[UnityEngine.Scripting.Preserve]
internal sealed class CDNBJLKCCLK : AKAGACKDLFM, KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class MIPOFGMEGPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public EPOGGLOBAKG request;

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MIPOFGMEGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x80A6B60", Offset = "0x80A5F60", VA = "0x1880A6B60")]
		internal object CHIAJPFNAKF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private struct NOAHCIAJEJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public AsyncTaskMethodBuilder<EPOGGLOBAKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public EPOGGLOBAKG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public CDNBJLKCCLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public IGPBPPCMANO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x80A81A0", Offset = "0x80A75A0", VA = "0x1880A81A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x80A87B0", Offset = "0x80A7BB0", VA = "0x1880A87B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct GLGHFGEOGKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public AsyncTaskMethodBuilder<EPOGGLOBAKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public CDNBJLKCCLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public IGPBPPCMANO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TaskAwaiter<NFBGMLKNLKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x809A190", Offset = "0x8099590", VA = "0x18809A190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x809A780", Offset = "0x8099B80", VA = "0x18809A780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class PJCMDDDFOJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public EPOGGLOBAKG request;

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public PJCMDDDFOJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x80AC2F0", Offset = "0x80AB6F0", VA = "0x1880AC2F0")]
		internal object MGAFDEGAHPN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct IGPFFJHPPGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder<EPOGGLOBAKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public EPOGGLOBAKG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public CDNBJLKCCLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public IGPBPPCMANO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private EALLHFNFBPD <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private MKCJCAGALGL <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private TaskAwaiter<NFBGMLKNLKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x809D730", Offset = "0x809CB30", VA = "0x18809D730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x809E320", Offset = "0x809D720", VA = "0x18809E320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private FMKBFEIFICC BOGAODIGBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private GBFKOIDPNBM FDHCAMMBDNN;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private FONJBPLEFOC JHEBAKLCCDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8092CB0", Offset = "0x80920B0", VA = "0x188092CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x8092ED0", Offset = "0x80922D0", VA = "0x188092ED0", Slot = "8")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x8092B50", Offset = "0x8091F50", VA = "0x188092B50", Slot = "4")]
	[AsyncStateMachine(typeof(NOAHCIAJEJE))]
	public Task<EPOGGLOBAKG> CHOFHHBDGBK(EPOGGLOBAKG ANMDEHLLLBJ, IGPBPPCMANO MMOEGADJJKD, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x8093090", Offset = "0x8092490", VA = "0x188093090", Slot = "5")]
	[AsyncStateMachine(typeof(GLGHFGEOGKA))]
	public Task<EPOGGLOBAKG> OKJPGBOGCBO(CancellationToken LMNHDKIFBOH, IGPBPPCMANO MMOEGADJJKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x8092AA0", Offset = "0x8091EA0", VA = "0x188092AA0", Slot = "6")]
	public KKJJOKHIFIF ADKGCHFEPJO(EBHOBHMGDHC PIDDBFCEPEF, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x8092F60", Offset = "0x8092360", VA = "0x188092F60", Slot = "7")]
	public KKJJOKHIFIF JGCOABDPKAO(EBHOBHMGDHC PIDDBFCEPEF, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x8092D70", Offset = "0x8092170", VA = "0x188092D70")]
	[AsyncStateMachine(typeof(IGPFFJHPPGK))]
	private Task<EPOGGLOBAKG> DCLNBLAMAEA(EPOGGLOBAKG ANMDEHLLLBJ, IGPBPPCMANO MMOEGADJJKD, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x36DE0F0", Offset = "0x36DD4F0", VA = "0x1836DE0F0")]
	private static byte[] HAEOGOCLDPL(EPOGGLOBAKG DAMFJFKKFBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public CDNBJLKCCLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[UnityEngine.Scripting.Preserve]
internal sealed class OPECPFCMJMP : AEFNHDNPDGB, KBHPKIEBIBJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private OECLOADLJFM KCMEOJGNOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private FMKBFEIFICC BOGAODIGBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private PMMACJEODNL AEDDIMEJOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private BHDEHADDLMD EGCLPDLBPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private BEHHGOBGNKL IAPHFNOPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private LBDHEDHCFOP OOLOGEGALNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private BFEJMCCPNJJ EOGCPILNJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private NFOKCOMKNBM HNFCGGMPMHM;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private CDCAHPMDKLI JLEJGCAJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x80AB640", Offset = "0x80AAA40", VA = "0x1880AB640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static OGJPCDKPGHL ABONCMIDHHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x80AB690", Offset = "0x80AAA90", VA = "0x1880AB690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x80AB240", Offset = "0x80AA640", VA = "0x1880AB240", Slot = "6")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x80AB0D0", Offset = "0x80AA4D0", VA = "0x1880AB0D0", Slot = "4")]
	public OGJPCDKPGHL CPCJPACPPID(DNIGIBHMBIB DBPOAMOJLGH, OGNLJOEPPKN FHHMBNMHEHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x80AB3C0", Offset = "0x80AA7C0", VA = "0x1880AB3C0", Slot = "5")]
	public OGJPCDKPGHL IBIJOKDLMGH(DNIGIBHMBIB ODJOKMHBJDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x80AB3B0", Offset = "0x80AA7B0", VA = "0x1880AB3B0")]
	private static OGJPCDKPGHL HJCBGAHJHIA(JNDBDBIFPHO JKODLOFLBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public OPECPFCMJMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class GOCHIKEMDEC : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x809A850", Offset = "0x8099C50", VA = "0x18809A850")]
	public GOCHIKEMDEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7326260", Offset = "0x7325660", VA = "0x187326260")]
	public GOCHIKEMDEC(string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[UnityEngine.Scripting.Preserve]
internal sealed class FEGGAGKLBGD : FFFKBLCKPNE, KBHPKIEBIBJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct NLIAEEPGIFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public AsyncTaskMethodBuilder<OGJPCDKPGHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public FEGGAGKLBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public CKKDNBIBBCP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private APGKENHKANG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private APGKENHKANG<string>.EEEKGBDKLHP <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private DPKNKAFHJIP <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private TaskAwaiter<OGJPCDKPGHL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x80A75F0", Offset = "0x80A69F0", VA = "0x1880A75F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x80A8130", Offset = "0x80A7530", VA = "0x1880A8130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct HOOGIEKEJOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public FEGGAGKLBGD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x809CF90", Offset = "0x809C390", VA = "0x18809CF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x809D6D0", Offset = "0x809CAD0", VA = "0x18809D6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct JBHMDPGAFHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public FEGGAGKLBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x809F450", Offset = "0x809E850", VA = "0x18809F450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x809F960", Offset = "0x809ED60", VA = "0x18809F960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct KKKKDNCGGLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public FEGGAGKLBGD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x80A2810", Offset = "0x80A1C10", VA = "0x1880A2810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x80A2F50", Offset = "0x80A2350", VA = "0x1880A2F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct EODAHIGCAOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public FEGGAGKLBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x8097BD0", Offset = "0x8096FD0", VA = "0x188097BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x8097D70", Offset = "0x8097170", VA = "0x188097D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct OCIPJDEEDKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public FEGGAGKLBGD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x80A8820", Offset = "0x80A7C20", VA = "0x1880A8820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x80A8F30", Offset = "0x80A8330", VA = "0x1880A8F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct DDMHNCFJNDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public FEGGAGKLBGD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x80955A0", Offset = "0x80949A0", VA = "0x1880955A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x8095A10", Offset = "0x8094E10", VA = "0x188095A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct GOFBJKEPADI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public FEGGAGKLBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public JFCACKFPDGD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private APGKENHKANG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x80B8E50", Offset = "0x80B8250", VA = "0x1880B8E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x80B93F0", Offset = "0x80B87F0", VA = "0x1880B93F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private FMKBFEIFICC BOGAODIGBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private BEHHGOBGNKL IAPHFNOPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private AKAGACKDLFM CDODBONFBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private PMMACJEODNL AEDDIMEJOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private BFEJMCCPNJJ EOGCPILNJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private CancellationTokenSource EEFGEJACMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private Task HLABOFAHMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private TaskCompletionSource<int> EFNNDEBICAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private int JPHMGHLMPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private int HHMAAFJBBEN;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x8098280", Offset = "0x8097680", VA = "0x188098280", Slot = "6")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x11AE360", Offset = "0x11AD760", VA = "0x1811AE360", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x8098A80", Offset = "0x8097E80", VA = "0x188098A80")]
	private void MJPNLPEHBLL(float IBODAGBPMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x8097ED0", Offset = "0x80972D0", VA = "0x188097ED0", Slot = "4")]
	[AsyncStateMachine(typeof(NLIAEEPGIFN))]
	public Task<OGJPCDKPGHL> FHOJJMNBMGO(CKKDNBIBBCP HGHJCHINOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x8098820", Offset = "0x8097C20", VA = "0x188098820", Slot = "5")]
	[AsyncStateMachine(typeof(HOOGIEKEJOG))]
	public Task KOLLENMFCCL([Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x11AE360", Offset = "0x11AD760", VA = "0x1811AE360")]
	public void AOOACJPLHML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x8098910", Offset = "0x8097D10", VA = "0x188098910")]
	private DPKNKAFHJIP LNLDACJCCIH(CKKDNBIBBCP HGHJCHINOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x8098540", Offset = "0x8097940", VA = "0x188098540")]
	[AsyncStateMachine(typeof(JBHMDPGAFHJ))]
	private Task IDCCDAIAHHL(CancellationToken BOHHBCNKHLK, int BNOGLLLKJPP, NCKNCPPCAHN MNHJBCEPCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x8098630", Offset = "0x8097A30", VA = "0x188098630")]
	[AsyncStateMachine(typeof(KKKKDNCGGLM))]
	private Task IOMGODKELLL(CancellationToken BOHHBCNKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x8098CF0", Offset = "0x80980F0", VA = "0x188098CF0")]
	[AsyncStateMachine(typeof(EODAHIGCAOG))]
	private Task OJGHKMBJFLJ([Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x8098730", Offset = "0x8097B30", VA = "0x188098730")]
	[AsyncStateMachine(typeof(OCIPJDEEDKN))]
	private Task JHPCEKPFEJG(CancellationToken BOHHBCNKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x8097DD0", Offset = "0x80971D0", VA = "0x188097DD0")]
	[AsyncStateMachine(typeof(DDMHNCFJNDO))]
	private Task CAOFHNPGCHF(CancellationToken OBLLCMCDHMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x8098B60", Offset = "0x8097F60", VA = "0x188098B60")]
	private Task NNHBFGDBPMH(JFCACKFPDGD GIHOEMBHLDB, CancellationToken BOHHBCNKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x8098430", Offset = "0x8097830", VA = "0x188098430")]
	[AsyncStateMachine(typeof(GOFBJKEPADI))]
	private Task HOMHMOLGJCI(JFCACKFPDGD GIHOEMBHLDB, CancellationToken BOHHBCNKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x8098000", Offset = "0x8097400", VA = "0x188098000")]
	private bool GCKNKCJNMCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public FEGGAGKLBGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[UnityEngine.Scripting.Preserve]
internal class ODDGEJLGIDD : BHDEHADDLMD, KBHPKIEBIBJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct CLKIJENJBLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public ODDGEJLGIDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private APGKENHKANG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x80AFBC0", Offset = "0x80AEFC0", VA = "0x1880AFBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x80B0180", Offset = "0x80AF580", VA = "0x1880B0180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private FKLBCLNGIJH JGGPEAFECGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private AEFNHDNPDGB EJIFMKNBKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private AKAGACKDLFM CDODBONFBPP;

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x80C51D0", Offset = "0x80C45D0", VA = "0x1880C51D0", Slot = "6")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x80C50D0", Offset = "0x80C44D0", VA = "0x1880C50D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x80C54B0", Offset = "0x80C48B0", VA = "0x1880C54B0", Slot = "5")]
	[AsyncStateMachine(typeof(CLKIJENJBLE))]
	public Task MKJAEAFJGLM(string IOOOOBAIEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x80C5120", Offset = "0x80C4520", VA = "0x1880C5120", Slot = "4")]
	public OGJPCDKPGHL GCKNKCJNMCE(DNIGIBHMBIB DBPOAMOJLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x80C4F90", Offset = "0x80C4390", VA = "0x1880C4F90")]
	private GGFPIDNIPGL BDPNNGFAKDM(string IOOOOBAIEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public ODDGEJLGIDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class GDIHCNHBLAF
{
	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x80B7B10", Offset = "0x80B6F10", VA = "0x1880B7B10")]
	public static void FKEKKJIMDFB(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x80B7D50", Offset = "0x80B7150", VA = "0x1880B7D50")]
	internal static void GLAEEOPMAKI(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x80B7EB0", Offset = "0x80B72B0", VA = "0x1880B7EB0")]
	internal static void ILGOELGAPLI(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x80B7F90", Offset = "0x80B7390", VA = "0x1880B7F90")]
	internal static void PEKHMIGJJDD(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x35F5200", Offset = "0x35F4600", VA = "0x1835F5200")]
	private static void CCFMJCGMLMG<Interface, Impl, Interface>(DHLGDCALOEP NKMJDOBLHGP) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class JAODKAKCOOB : FIMKPIKONFK<EPOGGLOBAKG>
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class BOPBHLNEPBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public EPOGGLOBAKG message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public BOPBHLNEPBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x80ADEF0", Offset = "0x80AD2F0", VA = "0x1880ADEF0")]
		internal object LBJDMCEGBCM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly JAODKAKCOOB DNEPPKLGBFA;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x80BCDD0", Offset = "0x80BC1D0", VA = "0x1880BCDD0")]
	public ExitGames.Client.Photon.Hashtable PELCBGJOJPC(EPOGGLOBAKG DAMFJFKKFBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x80BC6C0", Offset = "0x80BBAC0", VA = "0x1880BC6C0", Slot = "5")]
	protected override void EAJHGDDEIPA(EPOGGLOBAKG DAMFJFKKFBI, IDictionary<object, object> HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x80BC900", Offset = "0x80BBD00", VA = "0x1880BC900", Slot = "6")]
	public override EPOGGLOBAKG HFAEDKNMEEN(IDictionary<object, object> HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x80BC7F0", Offset = "0x80BBBF0", VA = "0x1880BC7F0")]
	private static void GFDFDHMHGGA(string DKFMMLIFNLP, EPOGGLOBAKG DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x80BCEF0", Offset = "0x80BC2F0", VA = "0x1880BCEF0")]
	public JAODKAKCOOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x80BCB30", Offset = "0x80BBF30", VA = "0x1880BCB30")]
	[CompilerGenerated]
	internal static string MPJNPIIDCDL(NAMDFBDBPAO DMDJHNIAOJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class PAECBLAJFOL
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static OGJPCDKPGHL ABONCMIDHHC
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x80C7910", Offset = "0x80C6D10", VA = "0x1880C7910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x80C7640", Offset = "0x80C6A40", VA = "0x1880C7640")]
	public static bool BFPLJFLOJFJ(this OGJPCDKPGHL HNFLDGONBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x80C78B0", Offset = "0x80C6CB0", VA = "0x1880C78B0")]
	public static OGJPCDKPGHL HJCBGAHJHIA(JNDBDBIFPHO GCFDJFLLMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x80C7970", Offset = "0x80C6D70", VA = "0x1880C7970")]
	public static OGJPCDKPGHL MOIELNJENNK(IEnumerable<OGJPCDKPGHL> ADJJDJNNFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x80C7660", Offset = "0x80C6A60", VA = "0x1880C7660")]
	public static string DFPPCCJLPBJ(this OGJPCDKPGHL HBALBIOOGIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public abstract class CJAFONOBJEN : ECCBHLJGFKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public delegate OGJPCDKPGHL GAMLEOPPJOC([NotNull] DNIGIBHMBIB BPMEJAFJIGN);

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class CCLIJGCFMGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public DNIGIBHMBIB photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public CCLIJGCFMGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x1466A20", Offset = "0x1465E20", VA = "0x181466A20")]
		internal OGJPCDKPGHL AKKMJEFOAMI(GAMLEOPPJOC v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	private bool EKDCONIHOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038E")]
	protected readonly HashSet<GAMLEOPPJOC> FICECIKAKMM;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x80AF7E0", Offset = "0x80AEBE0", VA = "0x1880AF7E0", Slot = "4")]
	public void HLLGJABLFDJ(GAMLEOPPJOC FNPMDNALIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x80AF840", Offset = "0x80AEC40", VA = "0x1880AF840", Slot = "5")]
	public void JAFNFDCHGIK(GAMLEOPPJOC FNPMDNALIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x80AF790", Offset = "0x80AEB90", VA = "0x1880AF790", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x80AF8A0", Offset = "0x80AECA0", VA = "0x1880AF8A0")]
	protected OGJPCDKPGHL NLFBCECALFC(DNIGIBHMBIB ODJOKMHBJDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x80AFB30", Offset = "0x80AEF30", VA = "0x1880AFB30")]
	protected CJAFONOBJEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public class MOAPLBKOBIL : CJAFONOBJEN, OECLOADLJFM, ECCBHLJGFKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class LKCGMALBINI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public OGJPCDKPGHL result;

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public LKCGMALBINI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x80C2990", Offset = "0x80C1D90", VA = "0x1880C2990")]
		internal object ABBPNAGMPJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x80C4110", Offset = "0x80C3510", VA = "0x1880C4110")]
	[UnityEngine.Scripting.Preserve]
	public MOAPLBKOBIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x80C4000", Offset = "0x80C3400", VA = "0x1880C4000", Slot = "8")]
	public OGJPCDKPGHL ODBEPKLEGAF(DNIGIBHMBIB ODJOKMHBJDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class PDMIBCLLFIK : CJAFONOBJEN, FKLBCLNGIJH, ECCBHLJGFKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class MBIIDMBEJCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public OGJPCDKPGHL result;

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MBIIDMBEJCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x80C3F30", Offset = "0x80C3330", VA = "0x1880C3F30")]
		internal object KOGPOOLPJAI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x80C4110", Offset = "0x80C3510", VA = "0x1880C4110")]
	[UnityEngine.Scripting.Preserve]
	public PDMIBCLLFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x80C7B60", Offset = "0x80C6F60", VA = "0x1880C7B60", Slot = "8")]
	public OGJPCDKPGHL GCKNKCJNMCE(DNIGIBHMBIB GGMAHLNBIDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal static class OHFFLGGMFML
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class AHGBOOACFEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public APGKENHKANG<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public AHGBOOACFEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x80ACD00", Offset = "0x80AC100", VA = "0x1880ACD00")]
		internal object IFCOJCNBMLK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x80C5870", Offset = "0x80C4C70", VA = "0x1880C5870")]
	public static APGKENHKANG<string> CLIEJFAHFIP(GBHBOJAPDOA DPDKJPMBJOA, [Optional] string COMBJFMBCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x80C57B0", Offset = "0x80C4BB0", VA = "0x1880C57B0")]
	public static void CGNFFNJPPFF(APGKENHKANG<string> KINEPAABOFB, GBHBOJAPDOA DPDKJPMBJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x80C5950", Offset = "0x80C4D50", VA = "0x1880C5950")]
	public static string MOIMBCJIKLB(EPOGGLOBAKG KBECLOEPHKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal static class ECGPPINEELO
{
	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x80B2410", Offset = "0x80B1810", VA = "0x1880B2410")]
	public static void OHBFAKEBAMO(this FMKBFEIFICC BOGAODIGBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x80B22E0", Offset = "0x80B16E0", VA = "0x1880B22E0")]
	public static void BOIBPGEJHBA(this FMKBFEIFICC BOGAODIGBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x80B22F0", Offset = "0x80B16F0", VA = "0x1880B22F0")]
	private static void JJAHLBOBKAL(this FMKBFEIFICC BOGAODIGBEK, bool BFMKMMLPDPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class IJGJNNNIEBD : AOODGACCJNE, DEDAEOHHDGL, EHHBJPGDAKJ, AEOJMJJOHFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	private readonly DEDAEOHHDGL AANEOJPDLDP;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public DNIGIBHMBIB GLIPCCAMJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x80BBEE0", Offset = "0x80BB2E0", VA = "0x1880BBEE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int ADKAHCGPLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x80BC1B0", Offset = "0x80BB5B0", VA = "0x1880BC1B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int BNBFPFJIGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x80BC160", Offset = "0x80BB560", VA = "0x1880BC160", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool LADPAGIBFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int MPHNNCPMNKB
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xB232D0", Offset = "0xB226D0", VA = "0x180B232D0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event MGBPOGEONJM.JKFCPKLPGCH CDALAPBDHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event MPNDCDPCBLI MIJJAFGANPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x80BBFD0", Offset = "0x80BB3D0", VA = "0x1880BBFD0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x80BC070", Offset = "0x80BB470", VA = "0x1880BC070", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> GFELLJOGAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<DNIGIBHMBIB> DIJINAIGFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action GDKOHBMJJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x80BC2E0", Offset = "0x80BB6E0", VA = "0x1880BC2E0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x80BBF30", Offset = "0x80BB330", VA = "0x1880BBF30", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0xC686E0", Offset = "0xC67AE0", VA = "0x180C686E0")]
	public IJGJNNNIEBD(DEDAEOHHDGL AANEOJPDLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x80BBE30", Offset = "0x80BB230", VA = "0x1880BBE30", Slot = "8")]
	public bool ADCBEOHLBMG(byte MIDDANGFEAA, object PMHIICLKBJN, DHGFKKBCAMK HNIADHOEMAB, SendOptions ACCOEAAOMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x80BC200", Offset = "0x80BB600", VA = "0x1880BC200", Slot = "16")]
	public DNIGIBHMBIB OGCGKCCKLEP(int CBHDFIGALJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "19")]
	public void PNJBKLODMKM(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "20")]
	public void OOEBPBPKHGC(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "21")]
	public void LIIAMCCAEJN(object HHGPJKKLNIG, bool MOJLEMKJLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x80BC110", Offset = "0x80BB510", VA = "0x1880BC110", Slot = "22")]
	public IDisposable IHNHMFBCFOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "23")]
	private bool LIFJLIGALCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "24")]
	public void LBEGNPIBGGG(StringBuilder ECDIJKLJMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xE97BD0", Offset = "0xE96FD0", VA = "0x180E97BD0", Slot = "25")]
	public bool EADHGHPOGHI(bool LCGINDJNOFG, [Out] string AFHGIBDEPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0xE30570", Offset = "0xE2F970", VA = "0x180E30570", Slot = "28")]
	public void EEEPFHCBJKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal struct HGEDMLNCGKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	private readonly IDictionary<object, object> JOKKIDPHPDA;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0xC747D0", Offset = "0xC73BD0", VA = "0x180C747D0")]
	public HGEDMLNCGKA(IDictionary<object, object> JOKKIDPHPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x80BA200", Offset = "0x80B9600", VA = "0x1880BA200")]
	public bool BGCAHEPFDLK([Out] EPOGGLOBAKG DAMFJFKKFBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x80BA2B0", Offset = "0x80B96B0", VA = "0x1880BA2B0")]
	public Guid CBHJMMDDNFJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x80BA360", Offset = "0x80B9760", VA = "0x1880BA360")]
	public OGJPCDKPGHL CEBCEBHDGHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x80BA490", Offset = "0x80B9890", VA = "0x1880BA490")]
	public static ExitGames.Client.Photon.Hashtable GNHEPACBJCH(EPOGGLOBAKG DAMFJFKKFBI, OGJPCDKPGHL HNFLDGONBPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal static class FFCEHFICGGJ
{
	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x80B6930", Offset = "0x80B5D30", VA = "0x1880B6930")]
	public static bool GGABLEEDJCL(this ELMNGLJGGCK HHOKLMFBNEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct OLJOBLKCAHJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct EBIOFCCGOGI : IAsyncStateMachine
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
		public OLJOBLKCAHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x80B20A0", Offset = "0x80B14A0", VA = "0x1880B20A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x80B2280", Offset = "0x80B1680", VA = "0x1880B2280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	private readonly CancellationTokenSource MCOIFPENEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	private bool EKDCONIHOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	private Task NHNFPALEEPM;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool PNPLPCMDCBA
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x80C69C0", Offset = "0x80C5DC0", VA = "0x1880C69C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x80C6B00", Offset = "0x80C5F00", VA = "0x1880C6B00")]
	public OLJOBLKCAHJ(CancellationToken LMNHDKIFBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x80C69F0", Offset = "0x80C5DF0", VA = "0x1880C69F0")]
	[AsyncStateMachine(typeof(EBIOFCCGOGI))]
	public Task PFDECELLGBL(Func<CancellationToken, List<Task>> AFDLLEKBIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x80C6970", Offset = "0x80C5D70", VA = "0x1880C6970", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public readonly struct GLNNEJMAOCG<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct PELOFAJFGME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<PPEBEAEDJID<TData>, ADGPAJEIFGP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public GLNNEJMAOCG<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private TaskAwaiter<KGPHFOFOMPJ<PPEBEAEDJID<TData>, ADGPAJEIFGP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x530B910", Offset = "0x530AD10", VA = "0x18530B910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x48FB5F0", Offset = "0x48FA9F0", VA = "0x1848FB5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	private readonly JCFIGNPNPNK<TGetDataArg, TData> AMCNMNPOCHO;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xC747D0", Offset = "0xC73BD0", VA = "0x180C747D0")]
	internal GLNNEJMAOCG(JCFIGNPNPNK<TGetDataArg, TData> OHJFEHDLOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x486A330", Offset = "0x4869730", VA = "0x18486A330")]
	[AsyncStateMachine(typeof(GLNNEJMAOCG<, >.PELOFAJFGME))]
	public Task<KGPHFOFOMPJ<PPEBEAEDJID<TData>, ADGPAJEIFGP>> HEPBKLFGCOI(TGetDataArg HBNMBAEKPFF, string IBIBKMNOBIP, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public static class KBGMFCKMHHB
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x33FE020", Offset = "0x33FD420", VA = "0x1833FE020")]
	public static GLNNEJMAOCG<TGetDataArg, TData> HBLBJMFGHFK<TGetDataArg, TData>(JCFIGNPNPNK<TGetDataArg, TData> OHJFEHDLOHB)
	{
		return default(GLNNEJMAOCG<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public struct FPPEPKADMMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public readonly int NKFHHLEFGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public readonly int? JCKCNOIIHBI;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x4E33ED0", Offset = "0x4E332D0", VA = "0x184E33ED0")]
	public FPPEPKADMMN(int BMBMKKHEAHH, [Optional] int? IBHBHJJKGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x80B7080", Offset = "0x80B6480", VA = "0x1880B7080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface IHKBPIJEHEI<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJJFIGAKANF();

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IHKBPIJEHEI<T> ODJKHDILCFH(string EGKFIDEDPCL);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IHKBPIJEHEI<T> PAKIDIGNLHE(GJECBAHOJPF<T> EOFOIPHIFNO);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IHKBPIJEHEI<T> PCGFLDMCNGM(int HLLDLKNABPD);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IHKBPIJEHEI<T> JLOMJIAAHBN(int HLLDLKNABPD, ILBMFPGFIFH<T> JEKAANJMFLF);
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface GLNEFDGIGPM
{
	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IHKBPIJEHEI<T> IICKMIBBHOF<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ELENBEIFKNO LHGEJMPMBCI(Exception BLCFGIAFKHH);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FPPEPKADMMN JPCJBHFAMFB(Exception BLCFGIAFKHH);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public delegate string GJECBAHOJPF<in T>(T BLCFGIAFKHH) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public delegate int ILBMFPGFIFH<in T>(T BLCFGIAFKHH) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class HPLIMJAOKJJ : GLNEFDGIGPM
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private delegate string JNCDLGOCLBB(Exception BLCFGIAFKHH);

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private delegate int MEFCCHIAHFH(Exception BLCFGIAFKHH);

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class EAJEMJDHIGD<T> : IHKBPIJEHEI<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		[CompilerGenerated]
		private sealed class DFCJKOFKFMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public DFCJKOFKFMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
			internal string IMNDDNMMOOK(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000100")]
		[CompilerGenerated]
		private sealed class BHBIFCNMFDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public GJECBAHOJPF<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public BHBIFCNMFDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x5103D60", Offset = "0x5103160", VA = "0x185103D60")]
			internal string DEPEGECOLCF(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class NMBLMEDEOAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public ILBMFPGFIFH<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public NMBLMEDEOAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x5103D60", Offset = "0x5103160", VA = "0x185103D60")]
			internal int CGFGKEEDGCG(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private readonly HPLIMJAOKJJ GNLBINGGPAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private readonly Type CLMJFONOOFK;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x428A900", Offset = "0x4289D00", VA = "0x18428A900")]
		internal EAJEMJDHIGD(HPLIMJAOKJJ GNLBINGGPAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x428A520", Offset = "0x4289920", VA = "0x18428A520", Slot = "4")]
		public void EJJFIGAKANF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x428A680", Offset = "0x4289A80", VA = "0x18428A680", Slot = "5")]
		public IHKBPIJEHEI<T> ODJKHDILCFH(string EGKFIDEDPCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x428A7A0", Offset = "0x4289BA0", VA = "0x18428A7A0", Slot = "6")]
		public IHKBPIJEHEI<T> PAKIDIGNLHE(GJECBAHOJPF<T> EOFOIPHIFNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x428A8C0", Offset = "0x4289CC0", VA = "0x18428A8C0", Slot = "7")]
		public IHKBPIJEHEI<T> PCGFLDMCNGM(int HLLDLKNABPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x428A550", Offset = "0x4289950", VA = "0x18428A550", Slot = "8")]
		public IHKBPIJEHEI<T> JLOMJIAAHBN(int HLLDLKNABPD, ILBMFPGFIFH<T> JEKAANJMFLF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class LMADDAPLLMD<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private bool HMGELOIOKIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly List<Type> OPMMPAKPMCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly Dictionary<Type, TVal> KHMDEBPOBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly Dictionary<Type, int> NGMLMMBGLFB;

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public IReadOnlyList<Type> PAOANPENHIB
		{
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x4E70A50", Offset = "0x4E6FE50", VA = "0x184E70A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x4E70BB0", Offset = "0x4E6FFB0", VA = "0x184E70BB0")]
		public LMADDAPLLMD(Dictionary<Type, int> NGMLMMBGLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x4E708A0", Offset = "0x4E6FCA0", VA = "0x184E708A0")]
		public void JJBKLNLGAIJ(Type DJBLFBEBKGO, TVal PCJCDFNKKKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x4E70850", Offset = "0x4E6FC50", VA = "0x184E70850")]
		public bool JHOPICCACKP(Type CLMJFONOOFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x4E70A00", Offset = "0x4E6FE00", VA = "0x184E70A00")]
		public bool KADJIPIGNIG(TVal FFOEEMKIKJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x4E70800", Offset = "0x4E6FC00", VA = "0x184E70800")]
		public TVal IOLMGDEDCOJ(Type HAFNBBNOLPO)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x4E706C0", Offset = "0x4E6FAC0", VA = "0x184E706C0")]
		[CompilerGenerated]
		private int GJGNIHMALNA(Type JHHNJGBGOOD, Type LFMNBHEDPLL)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class CFDLMKHMHCA : IEnumerable<FPPEPKADMMN>, IEnumerable, IEnumerator<FPPEPKADMMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private FPPEPKADMMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public HPLIMJAOKJJ <>4__this;

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
		private IEnumerator<FPPEPKADMMN> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		private FPPEPKADMMN System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x43673C0", Offset = "0x43667C0", VA = "0x1843673C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(FPPEPKADMMN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x80AF5F0", Offset = "0x80AE9F0", VA = "0x1880AF5F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xDEB050", Offset = "0xDEA450", VA = "0x180DEB050")]
		[DebuggerHidden]
		public CFDLMKHMHCA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x80AF640", Offset = "0x80AEA40", VA = "0x1880AF640", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x80AEF90", Offset = "0x80AE390", VA = "0x1880AEF90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x80AF490", Offset = "0x80AE890", VA = "0x1880AF490")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x80AF440", Offset = "0x80AE840", VA = "0x1880AF440")]
		private void NIIFAIKAHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x80AF5A0", Offset = "0x80AE9A0", VA = "0x1880AF5A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x80AF4E0", Offset = "0x80AE8E0", VA = "0x1880AF4E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FPPEPKADMMN> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x80AF4E0", Offset = "0x80AE8E0", VA = "0x1880AF4E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private static readonly FPPEPKADMMN EOAOLADCBOC;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private static readonly Dictionary<Type, int> OMLFBOGEOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly HashSet<Type> DDCFMCCOOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private readonly LMADDAPLLMD<int> CIFCKAMLLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private readonly LMADDAPLLMD<MEFCCHIAHFH> FPIIAEFANGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly LMADDAPLLMD<JNCDLGOCLBB> CIGOJEDCKHF;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x80BAEA0", Offset = "0x80BA2A0", VA = "0x1880BAEA0")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	internal static void FJKHLPMEJLC(DHLGDCALOEP EOJAEMANAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x80BBA90", Offset = "0x80BAE90", VA = "0x1880BBA90")]
	[RecRoom.NoEngine.Common.Preserve]
	public HPLIMJAOKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x3393FF0", Offset = "0x33933F0", VA = "0x183393FF0", Slot = "4")]
	public IHKBPIJEHEI<T> IICKMIBBHOF<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x80BB4C0", Offset = "0x80BA8C0", VA = "0x1880BB4C0", Slot = "5")]
	public ELENBEIFKNO LHGEJMPMBCI(Exception BLCFGIAFKHH)
	{
		return default(ELENBEIFKNO);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x80BB1E0", Offset = "0x80BA5E0", VA = "0x1880BB1E0", Slot = "6")]
	public FPPEPKADMMN JPCJBHFAMFB(Exception? BLCFGIAFKHH)
	{
		return default(FPPEPKADMMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x80BABB0", Offset = "0x80B9FB0", VA = "0x1880BABB0", Slot = "7")]
	[IteratorStateMachine(typeof(CFDLMKHMHCA))]
	public IEnumerable<FPPEPKADMMN> BFGMBLGFIPD(Exception BLCFGIAFKHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x80BAA60", Offset = "0x80B9E60", VA = "0x1880BAA60", Slot = "8")]
	public string AMMJHOIGDNB(Exception? BLCFGIAFKHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x80BB550", Offset = "0x80BA950", VA = "0x1880BB550")]
	private string OHODOBPOEOJ(AggregateException LNHMAKGBDME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x80BA6B0", Offset = "0x80B9AB0", VA = "0x1880BA6B0")]
	private void AAGCIICDPPB(Type CLMJFONOOFK, int HLLDLKNABPD, MEFCCHIAHFH? LHELAIDKAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x80BAC50", Offset = "0x80BA050", VA = "0x1880BAC50")]
	private void DKDAEPIJOOD(Type CLMJFONOOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x80BAF10", Offset = "0x80BA310", VA = "0x1880BAF10")]
	private void INENBIMABMK(Type CLMJFONOOFK, JNCDLGOCLBB NNHGLJADHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x80BB850", Offset = "0x80BAC50", VA = "0x1880BB850")]
	private static int PDLHBDMKDAM(Type CLMJFONOOFK, Dictionary<Type, int> NGMLMMBGLFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x36499C0", Offset = "0x3648DC0", VA = "0x1836499C0")]
	private static bool DNNBJHAMNLB<TVal>(LMADDAPLLMD<TVal> JGMAGBDHLIF, Type CLMJFONOOFK, [Out] TVal FFOEEMKIKJO) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x80BB3E0", Offset = "0x80BA7E0", VA = "0x1880BB3E0")]
	[CompilerGenerated]
	internal static int LEOPIODECHL(Type ANKILLPBLGC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public struct ELENBEIFKNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public readonly FPPEPKADMMN FLMJECNBAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public readonly string OCDDHEMNBPA;

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x80B39A0", Offset = "0x80B2DA0", VA = "0x1880B39A0")]
	public ELENBEIFKNO(string AFEHBECBJJL, FPPEPKADMMN HLLDLKNABPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x80B3900", Offset = "0x80B2D00", VA = "0x1880B3900")]
	public string GCHGHBDFDJL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class EGBBHHGAGKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	private readonly IFCCBFAGEOA AINAIEBPKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	private string ICNKDFBGGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	private long? IDPIBEEFBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	private long? GNJLCAFPBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	private long? BOECMFKFLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private string DLOHMHKFDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	private CPPDEEJEANJ LGMACHAGLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private long? KLPOMKEOAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private bool BBGEKHDKIGN;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public string GFMGEAKNGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public long GMLDEMLBBLI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x80B2F30", Offset = "0x80B2330", VA = "0x1880B2F30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public long KMKIGPCHBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x80B3360", Offset = "0x80B2760", VA = "0x1880B3360")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public long EHLFKLOAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x80B3300", Offset = "0x80B2700", VA = "0x1880B3300")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public string MMLDKKPJJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x80B33C0", Offset = "0x80B27C0", VA = "0x1880B33C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public CPPDEEJEANJ MJFAPDECCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xCC4190", Offset = "0xCC3590", VA = "0x180CC4190")]
		get
		{
			return default(CPPDEEJEANJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x80B3400", Offset = "0x80B2800", VA = "0x1880B3400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public long BFFLIOCILPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x80B3860", Offset = "0x80B2C60", VA = "0x1880B3860")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x80B38C0", Offset = "0x80B2CC0", VA = "0x1880B38C0")]
	[UnityEngine.Scripting.Preserve]
	public EGBBHHGAGKN([CMKKAFOAFJE(null)] IFCCBFAGEOA AINAIEBPKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x80B3610", Offset = "0x80B2A10", VA = "0x1880B3610")]
	private void MFNDJLKMLGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x80B2AA0", Offset = "0x80B1EA0", VA = "0x1880B2AA0")]
	public void BKEFDKJBHGC(long MIFADOBCMAC, long JCNNPHFBOMP, [Optional] long? OLGEMOMILNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x80B34F0", Offset = "0x80B28F0", VA = "0x1880B34F0")]
	public void ICCEJDDDGNI(long OLGEMOMILNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x80B3590", Offset = "0x80B2990", VA = "0x1880B3590")]
	public void JJHNHHAPCBA(string JGBBMDGLIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x80B2F90", Offset = "0x80B2390", VA = "0x1880B2F90")]
	public void EGKEHIEPBKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal class KKJJOKHIFIF : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct KMABANLFDPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public AsyncTaskMethodBuilder<EPOGGLOBAKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public EPOGGLOBAKG roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public KKJJOKHIFIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private TaskAwaiter<FONJBPLEFOC.ADOMEOOKKOA<EPOGGLOBAKG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x80C1B70", Offset = "0x80C0F70", VA = "0x1880C1B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x80C20B0", Offset = "0x80C14B0", VA = "0x1880C20B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct EAOAKPBOJIO<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private sealed class CEOBAGCFNCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public EPOGGLOBAKG roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public CEOBAGCFNCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x80AE6E0", Offset = "0x80ADAE0", VA = "0x1880AE6E0")]
		internal EPOGGLOBAKG HOLBCBHNDHH(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct EEKAIGBBGDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public AsyncTaskMethodBuilder<FONJBPLEFOC.ADOMEOOKKOA<EPOGGLOBAKG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public EPOGGLOBAKG roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public KKJJOKHIFIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private EALLHFNFBPD <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private TaskAwaiter<FONJBPLEFOC.ADOMEOOKKOA<EPOGGLOBAKG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x80B2420", Offset = "0x80B1820", VA = "0x1880B2420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x80B2A30", Offset = "0x80B1E30", VA = "0x1880B2A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct HCNHAJJJGMF<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public KKJJOKHIFIF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x48FAB10", Offset = "0x48F9F10", VA = "0x1848FAB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x48FB5F0", Offset = "0x48FA9F0", VA = "0x1848FB5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct INKLDECPPHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public KKJJOKHIFIF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x80BC380", Offset = "0x80BB780", VA = "0x1880BC380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x80BC660", Offset = "0x80BBA60", VA = "0x1880BC660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private sealed class DPHIONIBMHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public DPHIONIBMHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x80B1010", Offset = "0x80B0410", VA = "0x1880B1010")]
		internal object OLGALKDLALD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x80B0F50", Offset = "0x80B0350", VA = "0x1880B0F50")]
		internal bool GHAPPJHMJFG(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class DFHNOPLEDNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public DFHNOPLEDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x80B0980", Offset = "0x80AFD80", VA = "0x1880B0980")]
		internal object PCFAAMAHIGE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class OJIMABEEALN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public OJIMABEEALN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x80C67E0", Offset = "0x80C5BE0", VA = "0x1880C67E0")]
		internal object MKEHLALMMDH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class ACLHLJPCHKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public ACLHLJPCHKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x80ACC90", Offset = "0x80AC090", VA = "0x1880ACC90")]
		internal object HLBGNOIPBAD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class KHCMNOIEDKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public KKJJOKHIFIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public KHCMNOIEDKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x80C03D0", Offset = "0x80BF7D0", VA = "0x1880C03D0")]
		internal object LBJDMCEGBCM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private static readonly Guid LDIHPIANANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public readonly EBHOBHMGDHC GOAKAGEIOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly FONJBPLEFOC OENCKNAJGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly EHHBJPGDAKJ BOGAODIGBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private readonly AEOJMJJOHFJ PEBAAHMMMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private bool FOHLHGKIKNJ;

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x80C1940", Offset = "0x80C0D40", VA = "0x1880C1940")]
	public KKJJOKHIFIF(EBHOBHMGDHC EKJBIEIFIHC, FONJBPLEFOC OENCKNAJGKK, EHHBJPGDAKJ BOGAODIGBEK, AEOJMJJOHFJ PEBAAHMMMNA, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x80C0960", Offset = "0x80BFD60", VA = "0x1880C0960", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x80C1450", Offset = "0x80C0850", VA = "0x1880C1450")]
	public void KPJKEFFCLHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x80C0970", Offset = "0x80BFD70", VA = "0x1880C0970")]
	public void EAPAKLPPOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x80C16F0", Offset = "0x80C0AF0", VA = "0x1880C16F0")]
	public void PALPLMMKHCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x80C1000", Offset = "0x80C0400", VA = "0x1880C1000")]
	[AsyncStateMachine(typeof(KMABANLFDPM))]
	internal Task<EPOGGLOBAKG> HFNMHJIDAMJ(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, EPOGGLOBAKG KBECLOEPHKF, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x36DE0F0", Offset = "0x36DD4F0", VA = "0x1836DE0F0")]
	private static byte[] PMHBLCFEAKG<T>(T DAMFJFKKFBI) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x36DDFA0", Offset = "0x36DD3A0", VA = "0x1836DDFA0")]
	private static T GHBOPAPMBGE<T>(MessageParser<T> BPKFDKFLGKL, byte[] DAMFJFKKFBI, T ILHNGOAPCGM) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x80C0CA0", Offset = "0x80C00A0", VA = "0x1880C0CA0")]
	[AsyncStateMachine(typeof(EEKAIGBBGDL))]
	private Task<FONJBPLEFOC.ADOMEOOKKOA<EPOGGLOBAKG>> ELHLIKDFGGG(EPOGGLOBAKG KBECLOEPHKF, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x36DE100", Offset = "0x36DD500", VA = "0x1836DE100")]
	[AsyncStateMachine(typeof(HCNHAJJJGMF<>))]
	internal Task<T> POKJMAOPDIH<T>(CancellationToken BOHHBCNKHLK, Func<CancellationToken, Task<T>> JGICNIKOAID, int NHGDOMMIKNI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x80C17B0", Offset = "0x80C0BB0", VA = "0x1880C17B0")]
	[AsyncStateMachine(typeof(INKLDECPPHN))]
	internal Task POKJMAOPDIH(CancellationToken BOHHBCNKHLK, Func<CancellationToken, Task> JGICNIKOAID, int NHGDOMMIKNI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x80C08E0", Offset = "0x80BFCE0", VA = "0x1880C08E0")]
	public HOBKOKHAHLA DIMNJIILPGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x80C12C0", Offset = "0x80C06C0", VA = "0x1880C12C0")]
	public KBCLJOLIADF IHHAJFGBGJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x80C0A30", Offset = "0x80BFE30", VA = "0x1880C0A30")]
	public HHEPFLADLLI ELCJBPPMNID([Optional] GBHBOJAPDOA? DPDKJPMBJOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x80C1160", Offset = "0x80C0560", VA = "0x1880C1160")]
	public void HLMELPDNCBH(Func<Guid, bool> NNBAEDGBKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x80C1340", Offset = "0x80C0740", VA = "0x1880C1340")]
	public void JKFJHAKAPGD(Func<Guid, bool> GDGOIBPMMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x80C1570", Offset = "0x80C0970", VA = "0x1880C1570")]
	public Guid LCICLGADGAP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x80C0DE0", Offset = "0x80C01E0", VA = "0x1880C0DE0")]
	public void GENIAJMPFDF(Guid LGMEGFGHALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x80C07B0", Offset = "0x80BFBB0", VA = "0x1880C07B0")]
	public void DHGJHFBIPEG(EPOGGLOBAKG BEFMIFGMDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x80C0EF0", Offset = "0x80C02F0", VA = "0x1880C0EF0")]
	public void GFDFDHMHGGA(string MMBPFNIMCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x36DDEC0", Offset = "0x36DD2C0", VA = "0x1836DDEC0")]
	private T EIPAMIOLDNO<T>(T FFOEEMKIKJO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x80C0760", Offset = "0x80BFB60", VA = "0x1880C0760")]
	public void CFNEENJJHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x36DDC20", Offset = "0x36DD020", VA = "0x1836DDC20")]
	[CompilerGenerated]
	internal static string AJIOIOHFPCK<T>(byte[] DHHEGLJJIIE, int NKOOKMNGKGJ, EAOAKPBOJIO<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal sealed class FDJFIOEGONE : EBHOBHMGDHC
{
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class MICPADCFGHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MICPADCFGHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x80C3F90", Offset = "0x80C3390", VA = "0x1880C3F90")]
		internal object NEKAPODGPIO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct GCDIKCFGGDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public FDJFIOEGONE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private OLGIGMIMIFN <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private KBCLJOLIADF <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x80B7160", Offset = "0x80B6560", VA = "0x1880B7160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x80B7AB0", Offset = "0x80B6EB0", VA = "0x1880B7AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct COLIAPEMDMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public FDJFIOEGONE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private TaskAwaiter<IBBAMKLHGAN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x80B01E0", Offset = "0x80AF5E0", VA = "0x1880B01E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x80B0920", Offset = "0x80AFD20", VA = "0x1880B0920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct LCHCIDBJKKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public FDJFIOEGONE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter<GKGFGBABKAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x80C2610", Offset = "0x80C1A10", VA = "0x1880C2610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x80C2920", Offset = "0x80C1D20", VA = "0x1880C2920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private sealed class EAKEMFEJIFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public OLGIGMIMIFN presence;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public EAKEMFEJIFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x80B12C0", Offset = "0x80B06C0", VA = "0x1880B12C0")]
		internal object DKNNNBALKFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private static readonly GBHBOJAPDOA MLIAFKELENI;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private static readonly GBHBOJAPDOA KMECBCCNCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private readonly NAMDFBDBPAO GNMBKDKPGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	private readonly ELMNGLJGGCK PJHPPMJLCEE;

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x80B67A0", Offset = "0x80B5BA0", VA = "0x1880B67A0")]
	public FDJFIOEGONE(NAMDFBDBPAO GNMBKDKPGHM, ELMNGLJGGCK PJHPPMJLCEE, Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, IGPBPPCMANO GHLBPFNFNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x80B61B0", Offset = "0x80B55B0", VA = "0x1880B61B0", Slot = "7")]
	[AsyncStateMachine(typeof(GCDIKCFGGDA))]
	protected override Task FGKIGELDKPJ(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x80B65D0", Offset = "0x80B59D0", VA = "0x1880B65D0")]
	[AsyncStateMachine(typeof(COLIAPEMDMC))]
	private Task KNILGLGOFCL(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x80B62F0", Offset = "0x80B56F0", VA = "0x1880B62F0")]
	[AsyncStateMachine(typeof(LCHCIDBJKKG))]
	private Task<int> IIFFFBLMCCM(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x80B6400", Offset = "0x80B5800", VA = "0x1880B6400")]
	private OLGIGMIMIFN JAAEMFGPEGO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class DPKNKAFHJIP : EBHOBHMGDHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct ONJNKFMNAFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public DPKNKAFHJIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private TaskAwaiter<DHJBDKCLFJF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x80C6C30", Offset = "0x80C6030", VA = "0x1880C6C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x80C75E0", Offset = "0x80C69E0", VA = "0x1880C75E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private readonly int OBCGCNPOFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private readonly CKKDNBIBBCP CEDHNEPJPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public readonly long GGHGNFHHKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public readonly long LAKPJKFHFDN;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public DHJBDKCLFJF KOCLMOEIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5B0", Offset = "0x9AD9B0", VA = "0x1809AE5B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x9AE550", Offset = "0x9AD950", VA = "0x1809AE550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x80B1190", Offset = "0x80B0590", VA = "0x1880B1190")]
	public DPKNKAFHJIP(Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, IGPBPPCMANO GHLBPFNFNJA, int OBCGCNPOFOC, CKKDNBIBBCP CEDHNEPJPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x80B1070", Offset = "0x80B0470", VA = "0x1880B1070", Slot = "7")]
	[AsyncStateMachine(typeof(ONJNKFMNAFF))]
	protected override Task FGKIGELDKPJ(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal abstract class GGHIOHHDEEH : EBHOBHMGDHC
{
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class NLKFKKEKCMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public GGHIOHHDEEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public KBPMFLBCKDN playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public NLKFKKEKCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x80C4120", Offset = "0x80C3520", VA = "0x1880C4120")]
		internal Task BEAHNHJKHLB(APGKENHKANG<string>.EEEKGBDKLHP postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x80C4160", Offset = "0x80C3560", VA = "0x1880C4160")]
		internal object MMKOAHILAHI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct NNNMEKPKFCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public GGHIOHHDEEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private NLKFKKEKCMK <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x80C41F0", Offset = "0x80C35F0", VA = "0x1880C41F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x80C49C0", Offset = "0x80C3DC0", VA = "0x1880C49C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private struct FHFBNGNBPFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public KBPMFLBCKDN playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public GGHIOHHDEEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x80B69B0", Offset = "0x80B5DB0", VA = "0x1880B69B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x80B6F60", Offset = "0x80B6360", VA = "0x1880B6F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x80B8E00", Offset = "0x80B8200", VA = "0x1880B8E00")]
	public GGHIOHHDEEH(Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, IGPBPPCMANO GHLBPFNFNJA, string KGOFODEJJEL, PPKFOIPGIIE CMJLDNADNMP, bool OPKMAOKOPPN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x80B8B80", Offset = "0x80B7F80", VA = "0x1880B8B80", Slot = "7")]
	[AsyncStateMachine(typeof(NNNMEKPKFCN))]
	protected override Task FGKIGELDKPJ(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task PGMNAIFDGJK(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x80B8CC0", Offset = "0x80B80C0", VA = "0x1880B8CC0")]
	[AsyncStateMachine(typeof(FHFBNGNBPFO))]
	private Task NKFCLHPLOMM(IDisposable IMEJOJAEBIK, KBPMFLBCKDN FCOFLPFNFCO, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
internal class PMAPKCJFKPO : EBHOBHMGDHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct KBGCJBJNBCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public PMAPKCJFKPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public KKJJOKHIFIF operationContext;

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
		private TaskAwaiter<PLFCMNGIAGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x80BFC80", Offset = "0x80BF080", VA = "0x1880BFC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x80C0270", Offset = "0x80BF670", VA = "0x1880C0270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private readonly JFCACKFPDGD GIHOEMBHLDB;

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x80C7E70", Offset = "0x80C7270", VA = "0x1880C7E70")]
	public PMAPKCJFKPO(Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, IGPBPPCMANO GHLBPFNFNJA, JFCACKFPDGD GIHOEMBHLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x80C7D90", Offset = "0x80C7190", VA = "0x1880C7D90", Slot = "6")]
	protected override string HBICNKDHNPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x80C7C70", Offset = "0x80C7070", VA = "0x1880C7C70", Slot = "7")]
	[AsyncStateMachine(typeof(KBGCJBJNBCA))]
	protected override Task FGKIGELDKPJ(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal abstract class EBHOBHMGDHC : EEKKCJKNBCB
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	public delegate Task KJIBKPEMFLN(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class HJFNKDJILPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public APGKENHKANG<string>.EEEKGBDKLHP operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public EBHOBHMGDHC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public HJFNKDJILPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x80BA580", Offset = "0x80B9980", VA = "0x1880BA580")]
		internal Task MFBLKHJDHJI(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private sealed class FPLIAEFAKIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public HJFNKDJILPP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public FPLIAEFAKIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x80B6FC0", Offset = "0x80B63C0", VA = "0x1880B6FC0")]
		internal object LMIDEPIDMLC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct LNNIBKIFJPM : IAsyncStateMachine
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
		public EBHOBHMGDHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public Func<EBHOBHMGDHC, APGKENHKANG<string>.EEEKGBDKLHP, KKJJOKHIFIF> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private HJFNKDJILPP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private KKJJOKHIFIF <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x80C2B30", Offset = "0x80C1F30", VA = "0x1880C2B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x80C3C80", Offset = "0x80C3080", VA = "0x1880C3C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct JKAPPBOHHEB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80BD2F0", Offset = "0x80BC6F0", VA = "0x1880BD2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x80BDD90", Offset = "0x80BD190", VA = "0x1880BDD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct JEPODJMBDPH : IAsyncStateMachine
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
		public EBHOBHMGDHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x80BCF30", Offset = "0x80BC330", VA = "0x1880BCF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x80BD290", Offset = "0x80BC690", VA = "0x1880BD290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public readonly Guid FDCJMIFHPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public readonly ByteString CGMMDBBNEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public readonly IGPBPPCMANO MNAIDKMHBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	protected readonly string GDEKKBDFCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private readonly HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	private readonly bool OPKMAOKOPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private readonly Queue<KJIBKPEMFLN> BBGODPFOCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private readonly FAHCCCHCJAA GONCJJIELEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private readonly PPKFOIPGIIE CMJLDNADNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private bool MHIDKAHJIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public CPPDEEJEANJ DOMLENPLJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public CPPDEEJEANJ PGHOEKCJDND;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public HENFMPPFGFG KBLPAMDIOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public BEHHGOBGNKL LDPIMCPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x80B1E70", Offset = "0x80B1270", VA = "0x1880B1E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public BGLHDLEKEGE MDDCDEOBBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x80B1A50", Offset = "0x80B0E50", VA = "0x1880B1A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public CDCAHPMDKLI JLEJGCAJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x80B1AE0", Offset = "0x80B0EE0", VA = "0x1880B1AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event ABEIMCMKCDE AMAEMNCEHKG
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x80B1AC0", Offset = "0x80B0EC0", VA = "0x1880B1AC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x80B1550", Offset = "0x80B0950", VA = "0x1880B1550", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x80B1F40", Offset = "0x80B1340", VA = "0x1880B1F40")]
	protected EBHOBHMGDHC(Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, IGPBPPCMANO GHLBPFNFNJA, string KGOFODEJJEL, PPKFOIPGIIE CMJLDNADNMP, bool OPKMAOKOPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x80B17F0", Offset = "0x80B0BF0", VA = "0x1880B17F0", Slot = "6")]
	protected virtual string HBICNKDHNPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x80B1570", Offset = "0x80B0970", VA = "0x1880B1570")]
	public void CODPPKCEDFG(KJIBKPEMFLN IJBCOFDMABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x80B1AA0", Offset = "0x80B0EA0", VA = "0x1880B1AA0")]
	protected void JKBIDDHPGHN(float ICNDIBLBLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x80B1400", Offset = "0x80B0800", VA = "0x1880B1400")]
	[AsyncStateMachine(typeof(LNNIBKIFJPM))]
	public Task AMNMBKBGPIL(CancellationToken LMNHDKIFBOH, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, [Optional] Func<EBHOBHMGDHC, APGKENHKANG<string>.EEEKGBDKLHP, KKJJOKHIFIF> FONIOECLIFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x80B15D0", Offset = "0x80B09D0", VA = "0x1880B15D0")]
	[AsyncStateMachine(typeof(JKAPPBOHHEB))]
	private static Task GCDENDIMLBP(Func<CancellationToken, Task> IKLEOOFHJNL, Func<CancellationToken, Task> LKIKIAIODNC, CancellationToken BOHHBCNKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x80B1BE0", Offset = "0x80B0FE0", VA = "0x1880B1BE0")]
	private void MMPMEELBBMO(bool JKLFEMENKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x80B1830", Offset = "0x80B0C30", VA = "0x1880B1830")]
	private void HBPNJEPPPMJ(KKJJOKHIFIF NHOEKMCOCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task FGKIGELDKPJ(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x80B1D50", Offset = "0x80B1150", VA = "0x1880B1D50")]
	[AsyncStateMachine(typeof(JEPODJMBDPH))]
	private Task NFGPEBKEPFI(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x80B1EC0", Offset = "0x80B12C0", VA = "0x1880B1EC0")]
	public EPOGGLOBAKG PIDBMFDFONG(EALLHFNFBPD MDODFHEHHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x80B1700", Offset = "0x80B0B00", VA = "0x1880B1700")]
	[CompilerGenerated]
	private Task GHOICFBMOJL(CancellationToken OOLNPDLPIEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x80B1B60", Offset = "0x80B0F60", VA = "0x1880B1B60")]
	[CompilerGenerated]
	private object KGKFDKJKOCL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
internal sealed class PPJIEAJMMNK : GGHIOHHDEEH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct CEPLHNANLBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public PPJIEAJMMNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private BMAMFBAMLOB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private KBCLJOLIADF <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x80AE7C0", Offset = "0x80ADBC0", VA = "0x1880AE7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x80AEF30", Offset = "0x80AE330", VA = "0x1880AEF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private readonly NAMDFBDBPAO IGFBKPMIPEE;

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x80C8060", Offset = "0x80C7460", VA = "0x1880C8060")]
	public PPJIEAJMMNK(Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, NAMDFBDBPAO IGFBKPMIPEE, IGPBPPCMANO GHLBPFNFNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x80C7F10", Offset = "0x80C7310", VA = "0x1880C7F10", Slot = "8")]
	[AsyncStateMachine(typeof(CEPLHNANLBC))]
	protected override Task PGMNAIFDGJK(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal class GGFPIDNIPGL : EBHOBHMGDHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct KNEOGGMMLCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public GGFPIDNIPGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private TaskAwaiter<PLFCMNGIAGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x80C2120", Offset = "0x80C1520", VA = "0x1880C2120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x80C25B0", Offset = "0x80C19B0", VA = "0x1880C25B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private readonly string HNFLEJGACGP;

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x80B8AD0", Offset = "0x80B7ED0", VA = "0x1880B8AD0")]
	public GGFPIDNIPGL(Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, IGPBPPCMANO GHLBPFNFNJA, string HNFLEJGACGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x80B89C0", Offset = "0x80B7DC0", VA = "0x1880B89C0", Slot = "7")]
	[AsyncStateMachine(typeof(KNEOGGMMLCG))]
	protected override Task FGKIGELDKPJ(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal class OCOHBNHLHNM : GGHIOHHDEEH
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class OKCINAGFNGM
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
			public AsyncTaskMethodBuilder<EPOGGLOBAKG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public OKCINAGFNGM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			private TaskAwaiter<PLFCMNGIAGA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			private TaskAwaiter<EPOGGLOBAKG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x80C9060", Offset = "0x80C8460", VA = "0x1880C9060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0x80C9550", Offset = "0x80C8950", VA = "0x1880C9550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public OCOHBNHLHNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public HHEPFLADLLI serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public HJGDKKKNFOO roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public HOBKOKHAHLA uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public DCMMCMGKNNK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public OKCINAGFNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x80C6850", Offset = "0x80C5C50", VA = "0x1880C6850")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<EPOGGLOBAKG> PLNPPENAGIG(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private struct EPGMHNBDJHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public OCOHBNHLHNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private OKCINAGFNGM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private BMAMFBAMLOB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private KBCLJOLIADF <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private EPOGGLOBAKG <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x80B4B60", Offset = "0x80B3F60", VA = "0x1880B4B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x80B5AB0", Offset = "0x80B4EB0", VA = "0x1880B5AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private static readonly GBHBOJAPDOA MLIAFKELENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private readonly int ALJILABKHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	[CanBeNull]
	private readonly IJHECIBDPGO FBOPDOAKGNF;

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x80C4EE0", Offset = "0x80C42E0", VA = "0x1880C4EE0")]
	public OCOHBNHLHNM(Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, int ALJILABKHFO, IJHECIBDPGO FBOPDOAKGNF, IGPBPPCMANO GHLBPFNFNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x80C4CF0", Offset = "0x80C40F0", VA = "0x1880C4CF0", Slot = "8")]
	[AsyncStateMachine(typeof(EPGMHNBDJHF))]
	protected override Task PGMNAIFDGJK(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x80C4BF0", Offset = "0x80C3FF0", VA = "0x1880C4BF0")]
	private void BFDKIADCOFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x80C4A20", Offset = "0x80C3E20", VA = "0x1880C4A20")]
	private void BBNOMHPPKIM(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, BMAMFBAMLOB GKBKHGJHGGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal class OGPCJMPMLOG : EBHOBHMGDHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct EOHOHGLENBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public OGPCJMPMLOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private BMAMFBAMLOB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private HLFDOLJKNKL<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private TaskAwaiter<DHJBDKCLFJF> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x80B39C0", Offset = "0x80B2DC0", VA = "0x1880B39C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x80B4B00", Offset = "0x80B3F00", VA = "0x1880B4B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private readonly int ALJILABKHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private readonly IJHECIBDPGO FBOPDOAKGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private Func<PLFCMNGIAGA, PLFCMNGIAGA> EGAFBDKFNFO;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x80C56F0", Offset = "0x80C4AF0", VA = "0x1880C56F0")]
	public OGPCJMPMLOG(Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, int ALJILABKHFO, IJHECIBDPGO FBOPDOAKGNF, Func<PLFCMNGIAGA, PLFCMNGIAGA> EGAFBDKFNFO, IGPBPPCMANO GHLBPFNFNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x80C55B0", Offset = "0x80C49B0", VA = "0x1880C55B0", Slot = "7")]
	[AsyncStateMachine(typeof(EOHOHGLENBF))]
	protected override Task FGKIGELDKPJ(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal abstract class LOMGCHGEPFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public readonly EBHOBHMGDHC GOAKAGEIOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public readonly KKJJOKHIFIF BKLNCKFKCDN;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public BEHHGOBGNKL LDPIMCPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x80C3E80", Offset = "0x80C3280", VA = "0x1880C3E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public CDCAHPMDKLI JLEJGCAJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x80C3DF0", Offset = "0x80C31F0", VA = "0x1880C3DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x80C3ED0", Offset = "0x80C32D0", VA = "0x1880C3ED0")]
	protected LOMGCHGEPFF(KKJJOKHIFIF NHOEKMCOCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x80C3CE0", Offset = "0x80C30E0", VA = "0x1880C3CE0")]
	protected void GFDFDHMHGGA(string MMBPFNIMCOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct GFIJHOCNJMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public Dictionary<Guid, List<PHPLHHACNNI>> CLMNFFOPHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public Dictionary<Guid, List<PHPLHHACNNI>> DDOAGPBHENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public Dictionary<Guid, List<PHPLHHACNNI>> LACMFMCIPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public List<Guid> OBGKNNODJAJ;

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x80B83C0", Offset = "0x80B77C0", VA = "0x1880B83C0")]
	public static GFIJHOCNJMG IOLMGDEDCOJ(BEHHGOBGNKL IAPHFNOPBJO, CPPDEEJEANJ OIHFCHECHPE, FEJGNMMNDHD PNEKEJIIDPC)
	{
		return default(GFIJHOCNJMG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct GHCMEEJDHHM
{
	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930")]
	public static GHCMEEJDHHM GNHEPACBJCH()
	{
		return default(GHCMEEJDHHM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct LLFJICEIFIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public readonly IBBAMKLHGAN BCEDDHNENJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public readonly GMHIEIPOGED DNJKJFGBJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public readonly Guid? JGICNMOHCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public readonly IReadOnlyCollection<INFPHCDJCLC> BKGEJEKCCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public readonly IReadOnlyCollection<INFPHCDJCLC> NGEAFLLBCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public readonly KKCEGILFGJB JKIDAGFNHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public readonly KKCEGILFGJB LLICHJIMFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public readonly APIECIFOHEN OOCJDIEIEAK;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool NGFPILOHFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x80C29F0", Offset = "0x80C1DF0", VA = "0x1880C29F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x80C2A80", Offset = "0x80C1E80", VA = "0x1880C2A80")]
	public LLFJICEIFIE(IBBAMKLHGAN BCEDDHNENJL, GMHIEIPOGED DNJKJFGBJDN, Guid? JGICNMOHCMI, IReadOnlyList<INFPHCDJCLC> BKGEJEKCCOC, IReadOnlyCollection<INFPHCDJCLC> NGEAFLLBCHM, KKCEGILFGJB JKIDAGFNHLP, KKCEGILFGJB LLICHJIMFEF, APIECIFOHEN OOCJDIEIEAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct OJAFMNCCPPC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private readonly KKJJOKHIFIF NHOEKMCOCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private readonly Guid LGMEGFGHALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private bool JKLFEMENKBM;

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x80C6620", Offset = "0x80C5A20", VA = "0x1880C6620")]
	public static OJAFMNCCPPC LCICLGADGAP(KKJJOKHIFIF NHOEKMCOCFJ)
	{
		return default(OJAFMNCCPPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x10B5900", Offset = "0x10B4D00", VA = "0x1810B5900")]
	public void HAGDIDHLJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x80C63E0", Offset = "0x80C57E0", VA = "0x1880C63E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x80C6650", Offset = "0x80C5A50", VA = "0x1880C6650")]
	private OJAFMNCCPPC(KKJJOKHIFIF NHOEKMCOCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x80C63F0", Offset = "0x80C57F0", VA = "0x1880C63F0")]
	private void GENIAJMPFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x80C6340", Offset = "0x80C5740", VA = "0x1880C6340")]
	private Func<Guid, bool> BCELLALGBDD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal class KBCLJOLIADF : LOMGCHGEPFF, EEKKCJKNBCB
{
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	public delegate Task<CPPDEEJEANJ> KGCCGODJLBG(FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN EDBFLAPPGIG, FAHCCCHCJAA ICHECBEBLLL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct OHOJFDKNBNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public NAMDFBDBPAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private OJAFMNCCPPC <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x80C5A10", Offset = "0x80C4E10", VA = "0x1880C5A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x80C62E0", Offset = "0x80C56E0", VA = "0x1880C62E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct CBEBGECOGGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public AsyncTaskMethodBuilder<EPOGGLOBAKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public NAMDFBDBPAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private APGKENHKANG<string>.EEEKGBDKLHP <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x80AE240", Offset = "0x80AD640", VA = "0x1880AE240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x80AE670", Offset = "0x80ADA70", VA = "0x1880AE670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct FAGNANOLENP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public NAMDFBDBPAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private APGKENHKANG<string>.EEEKGBDKLHP <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x80B5B10", Offset = "0x80B4F10", VA = "0x1880B5B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x80B6150", Offset = "0x80B5550", VA = "0x1880B6150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class DGFDMDPHFPJ
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
			public AsyncTaskMethodBuilder<LLFJICEIFIE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			public DGFDMDPHFPJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			private LLFJICEIFIE <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			private TaskAwaiter<CPPDEEJEANJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			private TaskAwaiter<LLFJICEIFIE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0x80C8110", Offset = "0x80C7510", VA = "0x1880C8110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x80C8900", Offset = "0x80C7D00", VA = "0x1880C8900", Slot = "5")]
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
			public AsyncTaskMethodBuilder<FEJGNMMNDHD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			public DGFDMDPHFPJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004FF")]
			private FEJGNMMNDHD <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			private TaskAwaiter<CPPDEEJEANJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			private TaskAwaiter<FEJGNMMNDHD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x80C8970", Offset = "0x80C7D70", VA = "0x1880C8970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x80C8FF0", Offset = "0x80C83F0", VA = "0x1880C8FF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public NAMDFBDBPAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public FAHCCCHCJAA preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public FAHCCCHCJAA downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public LLFJICEIFIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public FAHCCCHCJAA postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public FEJGNMMNDHD phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public PKEEJPANGHO.BNNACOHHJOL <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public DGFDMDPHFPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x80B0CA0", Offset = "0x80B00A0", VA = "0x1880B0CA0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<LLFJICEIFIE> NMNDFBEOJME(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x80B0E30", Offset = "0x80B0230", VA = "0x1880B0E30")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<FEJGNMMNDHD> PLIMJNGALLB(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x80B0DF0", Offset = "0x80B01F0", VA = "0x1880B0DF0")]
		internal void PKLBHGFBDND(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x80B0B40", Offset = "0x80AFF40", VA = "0x1880B0B40")]
		internal Task ELNBLOMABLO(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x80B09E0", Offset = "0x80AFDE0", VA = "0x1880B09E0")]
		internal Task DFINEDLMAJJ(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct HFCDHJBEBNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public NAMDFBDBPAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private DGFDMDPHFPJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private TaskAwaiter<LLFJICEIFIE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private TaskAwaiter<FEJGNMMNDHD> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x80B9450", Offset = "0x80B8850", VA = "0x1880B9450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x80BA1A0", Offset = "0x80B95A0", VA = "0x1880BA1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct BMDMLFAJJHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public FEJGNMMNDHD phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public FAHCCCHCJAA postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private PLDBJHIGINN <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x80ACD80", Offset = "0x80AC180", VA = "0x1880ACD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x80ADE90", Offset = "0x80AD290", VA = "0x1880ADE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct ACMNIAEPCJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x80CA230", Offset = "0x80C9630", VA = "0x1880CA230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x80CAA10", Offset = "0x80C9E10", VA = "0x1880CAA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct EGEJKKELHCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public FAHCCCHCJAA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private APGKENHKANG<string>.EEEKGBDKLHP <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x80D0560", Offset = "0x80CF960", VA = "0x1880D0560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x80D0DA0", Offset = "0x80D01A0", VA = "0x1880D0DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct MBNAIOLMKOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public FAHCCCHCJAA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private APGKENHKANG<string>.EEEKGBDKLHP <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x80D9890", Offset = "0x80D8C90", VA = "0x1880D9890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x80DA850", Offset = "0x80D9C50", VA = "0x1880DA850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct LGLNHLLEAMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public FAHCCCHCJAA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public PLDBJHIGINN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private APGKENHKANG<string>.EEEKGBDKLHP <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x80D8420", Offset = "0x80D7820", VA = "0x1880D8420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x80D9530", Offset = "0x80D8930", VA = "0x1880D9530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct CNNLAHBJDCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public CPPDEEJEANJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public FAHCCCHCJAA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public FEJGNMMNDHD deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x80CE8F0", Offset = "0x80CDCF0", VA = "0x1880CE8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x80CEB40", Offset = "0x80CDF40", VA = "0x1880CEB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class KPJMGNONFGI
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
			public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public KPJMGNONFGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			private IFKKDICMKCC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			private TaskAwaiter<CPPDEEJEANJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x80E1870", Offset = "0x80E0C70", VA = "0x1880E1870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x80E1E90", Offset = "0x80E1290", VA = "0x1880E1E90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public FAHCCCHCJAA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public KGCCGODJLBG masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public PLDBJHIGINN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public CPPDEEJEANJ originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public KPJMGNONFGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x80D7240", Offset = "0x80D6640", VA = "0x1880D7240")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<CPPDEEJEANJ> BHFCNKFCKGH(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct AKEDMKJFPMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public FAHCCCHCJAA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public KGCCGODJLBG masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public PLDBJHIGINN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x80CC870", Offset = "0x80CBC70", VA = "0x1880CC870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x80CCD90", Offset = "0x80CC190", VA = "0x1880CCD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct HPFDHHPCCHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public FAHCCCHCJAA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private CPPDEEJEANJ <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private IEnumerator<CPPDEEJEANJ> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x80D40E0", Offset = "0x80D34E0", VA = "0x1880D40E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x80D4640", Offset = "0x80D3A40", VA = "0x1880D4640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct JMGJJJFNEHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x80D6530", Offset = "0x80D5930", VA = "0x1880D6530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x80D6820", Offset = "0x80D5C20", VA = "0x1880D6820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct PMBMOGHHOIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x80E0AA0", Offset = "0x80DFEA0", VA = "0x1880E0AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x80E0CC0", Offset = "0x80E00C0", VA = "0x1880E0CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class ODOJMBAOGCA
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
			public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			public ODOJMBAOGCA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public FEJGNMMNDHD data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public FAHCCCHCJAA progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			private TaskAwaiter<CPPDEEJEANJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			private TaskAwaiter<FCNPEFLMCKN> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x80E1F00", Offset = "0x80E1300", VA = "0x1880E1F00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x80E29D0", Offset = "0x80E1DD0", VA = "0x1880E29D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public JIGBJIEJJOJ mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public ODOJMBAOGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x80DFB20", Offset = "0x80DEF20", VA = "0x1880DFB20")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<CPPDEEJEANJ> EHNGHGEJLCE(FEJGNMMNDHD data, PLDBJHIGINN _, FAHCCCHCJAA progressTracker, APGKENHKANG<string>.EEEKGBDKLHP stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct MINADENBPKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public FEJGNMMNDHD phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public FAHCCCHCJAA postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private ODOJMBAOGCA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private PLDBJHIGINN <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x80DAE50", Offset = "0x80DA250", VA = "0x1880DAE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x80DBD10", Offset = "0x80DB110", VA = "0x1880DBD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct GDMFONEDMFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x80D1D70", Offset = "0x80D1170", VA = "0x1880D1D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x80D2170", Offset = "0x80D1570", VA = "0x1880D2170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct JHLEDGBJHNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public FAHCCCHCJAA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private APGKENHKANG<string>.EEEKGBDKLHP <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x80D59C0", Offset = "0x80D4DC0", VA = "0x1880D59C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x80D5FE0", Offset = "0x80D53E0", VA = "0x1880D5FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private readonly CEGHMOMNMEC MDCHKHELICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private readonly CEGHMOMNMEC APGOJHCGIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private readonly EGBBHHGAGKN BDFIBCDOEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private readonly AJIIKDKENGF LAOGAOKCDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private readonly KMGIEHGOPOH HBACHNLEBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private ProfilerCounterValue<int> APOCJDEKCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private readonly LIJGGIIFNIO LFALINOEJDL;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private HENFMPPFGFG KBLPAMDIOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x80BE130", Offset = "0x80BD530", VA = "0x1880BE130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event ABEIMCMKCDE AMAEMNCEHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x80BED40", Offset = "0x80BE140", VA = "0x1880BED40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x80BDF50", Offset = "0x80BD350", VA = "0x1880BDF50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x80BF9B0", Offset = "0x80BEDB0", VA = "0x1880BF9B0")]
	public KBCLJOLIADF(KKJJOKHIFIF NHOEKMCOCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x80BE5E0", Offset = "0x80BD9E0", VA = "0x1880BE5E0")]
	[AsyncStateMachine(typeof(OHOJFDKNBNK))]
	public Task HFOGDPNAGCE(NAMDFBDBPAO ANMDEHLLLBJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x80BEB00", Offset = "0x80BDF00", VA = "0x1880BEB00")]
	[AsyncStateMachine(typeof(CBEBGECOGGG))]
	private Task<EPOGGLOBAKG> ILGGABHFOMD(NAMDFBDBPAO ANMDEHLLLBJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x80BF1A0", Offset = "0x80BE5A0", VA = "0x1880BF1A0")]
	[AsyncStateMachine(typeof(FAGNANOLENP))]
	private Task MFJHMACMAJB(NAMDFBDBPAO ANMDEHLLLBJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x80BE870", Offset = "0x80BDC70", VA = "0x1880BE870")]
	[AsyncStateMachine(typeof(HFCDHJBEBNL))]
	private Task ICIIMFPCGCI(NAMDFBDBPAO ANMDEHLLLBJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken EKEDFDDDCCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x80BF2E0", Offset = "0x80BE6E0", VA = "0x1880BF2E0")]
	[AsyncStateMachine(typeof(BMDMLFAJJHO))]
	private Task NCICFOGOAFC(FEJGNMMNDHD EEGEGAOKGGE, FAHCCCHCJAA CAGOMMOJGKI, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken CJFLDHPBPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x80BF090", Offset = "0x80BE490", VA = "0x1880BF090")]
	[AsyncStateMachine(typeof(ACMNIAEPCJH))]
	private Task MBEBDBCGGFK(APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x80BEDA0", Offset = "0x80BE1A0", VA = "0x1880BEDA0")]
	[AsyncStateMachine(typeof(EGEJKKELHCO))]
	private Task KKKKIFBNHAA(FEJGNMMNDHD HPMNBNLACCC, FAHCCCHCJAA ICHECBEBLLL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x80BEEF0", Offset = "0x80BE2F0", VA = "0x1880BEEF0")]
	[AsyncStateMachine(typeof(MBNAIOLMKOM))]
	private Task<CPPDEEJEANJ> LDFONFHCDNC(FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, FAHCCCHCJAA ICHECBEBLLL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x80BF5E0", Offset = "0x80BE9E0", VA = "0x1880BF5E0")]
	[AsyncStateMachine(typeof(LGLNHLLEAMH))]
	private Task<CPPDEEJEANJ> NJAOFHIFLBE(FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, FAHCCCHCJAA ICHECBEBLLL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x80BDFB0", Offset = "0x80BD3B0", VA = "0x1880BDFB0")]
	[AsyncStateMachine(typeof(CNNLAHBJDCF))]
	private Task<CPPDEEJEANJ> EBONNFEBGLB(CPPDEEJEANJ OIHFCHECHPE, FEJGNMMNDHD PNEKEJIIDPC, FAHCCCHCJAA ICHECBEBLLL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH, bool JAPCKMIOHHD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x80BF8C0", Offset = "0x80BECC0", VA = "0x1880BF8C0")]
	private bool PKJCHBGDPEM(FEJGNMMNDHD EEGEGAOKGGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x80BE440", Offset = "0x80BD840", VA = "0x1880BE440")]
	[AsyncStateMachine(typeof(AKEDMKJFPMP))]
	protected Task<CPPDEEJEANJ> GGFCDMKIDIN(FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, FAHCCCHCJAA ICHECBEBLLL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH, KGCCGODJLBG CHHCCBOMPAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x80BE9B0", Offset = "0x80BDDB0", VA = "0x1880BE9B0")]
	[AsyncStateMachine(typeof(HPFDHHPCCHI))]
	private Task IHAMMCJOPLO(FEJGNMMNDHD HPMNBNLACCC, FAHCCCHCJAA ICHECBEBLLL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x80BE820", Offset = "0x80BDC20", VA = "0x1880BE820")]
	private void HPNGMDGLJBM(CPPDEEJEANJ EBDPJJJPIOL, FAHCCCHCJAA ICHECBEBLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x80BE2B0", Offset = "0x80BD6B0", VA = "0x1880BE2B0")]
	private void GANOBHCKGKM(CPPDEEJEANJ NBOOECJLKFL, [Out] CPPDEEJEANJ IAKMBNBLJPH, [Out] CPPDEEJEANJ LIPAJOPLKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x80BDF70", Offset = "0x80BD370", VA = "0x1880BDF70")]
	private Task<LLFJICEIFIE> CBBODNHLDHH(NAMDFBDBPAO ANMDEHLLLBJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x80BED60", Offset = "0x80BE160", VA = "0x1880BED60")]
	private Task<FEJGNMMNDHD> JNEDEGLLDMJ(LLFJICEIFIE HPMNBNLACCC, PKEEJPANGHO.BNNACOHHJOL ELOKFHOLKDI, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x80BE2F0", Offset = "0x80BD6F0", VA = "0x1880BE2F0")]
	[AsyncStateMachine(typeof(JMGJJJFNEHM))]
	private Task GAPINMNLIAF(FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH, bool LIJMPIPGMKC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x80BE730", Offset = "0x80BDB30", VA = "0x1880BE730")]
	[AsyncStateMachine(typeof(PMBMOGHHOIO))]
	private Task HMAMNFDLHCH(FEJGNMMNDHD HPMNBNLACCC, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x80BED10", Offset = "0x80BE110", VA = "0x1880BED10")]
	private Task JDNDPPLOKNH(FEJGNMMNDHD HPMNBNLACCC, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x80BF050", Offset = "0x80BE450", VA = "0x1880BF050")]
	private Task LMDAPONBKMC(FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x80BDF30", Offset = "0x80BD330", VA = "0x1880BDF30")]
	private Task BEFLGKKDGHC(FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x80BF070", Offset = "0x80BE470", VA = "0x1880BF070")]
	private Task MAOLJHKFAMP(FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x80BE5D0", Offset = "0x80BD9D0", VA = "0x1880BE5D0")]
	private static Task GMPHIAENNMM(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x80BDDF0", Offset = "0x80BD1F0", VA = "0x1880BDDF0")]
	private Task AEKHDCNCMNC(FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x80BF760", Offset = "0x80BEB60", VA = "0x1880BF760")]
	private Task NOBACCFKLIF(FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x80BF590", Offset = "0x80BE990", VA = "0x1880BF590")]
	private void NGEHEJECIDB(NAMDFBDBPAO ANMDEHLLLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x80BEC60", Offset = "0x80BE060", VA = "0x1880BEC60")]
	public void IPLNDKEPOAC(long OLGEMOMILNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	private static void NIICOCEJFGF(IBBAMKLHGAN BCEDDHNENJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x80BE160", Offset = "0x80BD560", VA = "0x1880BE160")]
	[AsyncStateMachine(typeof(MINADENBPKL))]
	private Task FLPOJHIJJGO(FEJGNMMNDHD EEGEGAOKGGE, FAHCCCHCJAA CAGOMMOJGKI, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken CJFLDHPBPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x80BF780", Offset = "0x80BEB80", VA = "0x1880BF780")]
	[AsyncStateMachine(typeof(GDMFONEDMFA))]
	private Task OFLCAHFBICA(FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x80BDE10", Offset = "0x80BD210", VA = "0x1880BDE10")]
	private static AHNPMJGNJNJ AGBIABABLPH(FEJGNMMNDHD PNEKEJIIDPC)
	{
		return default(AHNPMJGNJNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x80BF430", Offset = "0x80BE830", VA = "0x1880BF430")]
	[AsyncStateMachine(typeof(JHLEDGBJHNG))]
	private Task<CPPDEEJEANJ> NDMODBJLFAB(FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, FAHCCCHCJAA ICHECBEBLLL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	private void IPGKCCEKEJG(CPPDEEJEANJ OJFCACKMOFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct PDHALOGKABI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	private FEJGNMMNDHD HPMNBNLACCC;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private BEHHGOBGNKL LDPIMCPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x80DFF70", Offset = "0x80DF370", VA = "0x1880DFF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x80DFC80", Offset = "0x80DF080", VA = "0x1880DFC80")]
	public static Task AMNMBKBGPIL(HENFMPPFGFG LMJMNPPPAHL, FEJGNMMNDHD HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x80DFD60", Offset = "0x80DF160", VA = "0x1880DFD60")]
	private void AMNMBKBGPIL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct EKGCPPJHFLO
{
	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x80D0E00", Offset = "0x80D0200", VA = "0x1880D0E00")]
	public static Task AMNMBKBGPIL(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct POBJNOKPJGO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct MHOONIPEGOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private APGKENHKANG<string>.EEEKGBDKLHP <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x80DA8C0", Offset = "0x80D9CC0", VA = "0x1880DA8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x80DADF0", Offset = "0x80DA1F0", VA = "0x1880DADF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x80E0D20", Offset = "0x80E0120", VA = "0x1880E0D20")]
	[AsyncStateMachine(typeof(MHOONIPEGOM))]
	public static Task AMNMBKBGPIL(KKJJOKHIFIF NHOEKMCOCFJ, FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct GEDMJOHOMED
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct NBHAKOEJGMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public PLDBJHIGINN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private HENFMPPFGFG <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private BEHHGOBGNKL <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private CPPDEEJEANJ <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private IFKKDICMKCC <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private List<(PersistenceView, AJANKEAEBKF)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private AJANKEAEBKF <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x80DC480", Offset = "0x80DB880", VA = "0x1880DC480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x80DD150", Offset = "0x80DC550", VA = "0x1880DD150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x80D21D0", Offset = "0x80D15D0", VA = "0x1880D21D0")]
	[AsyncStateMachine(typeof(NBHAKOEJGMK))]
	public static Task AMNMBKBGPIL(KKJJOKHIFIF NHOEKMCOCFJ, FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x80D2320", Offset = "0x80D1720", VA = "0x1880D2320")]
	private static void OIJCFOGEAJK(PersistenceView EKLEPCBGCMK, AJANKEAEBKF LLCPKAOMDKB, FEJGNMMNDHD HPMNBNLACCC, CPPDEEJEANJ OIHFCHECHPE, bool PKDAIMKHECK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct BMDNKCDBAPG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct AKMDJMPECKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public HENFMPPFGFG roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private IFKKDICMKCC <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x80CCE00", Offset = "0x80CC200", VA = "0x1880CCE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x80CD420", Offset = "0x80CC820", VA = "0x1880CD420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x80CD9D0", Offset = "0x80CCDD0", VA = "0x1880CD9D0")]
	[AsyncStateMachine(typeof(AKMDJMPECKE))]
	public static Task AMNMBKBGPIL(HENFMPPFGFG LMJMNPPPAHL, FEJGNMMNDHD HPMNBNLACCC, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal struct HGDOANGMHBG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct LDPDNBPMKKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public HENFMPPFGFG roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x80D81B0", Offset = "0x80D75B0", VA = "0x1880D81B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x80D83C0", Offset = "0x80D77C0", VA = "0x1880D83C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class GEMKBMFJJJB
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
			public APGKENHKANG<string>.EEEKGBDKLHP timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			public GEMKBMFJJJB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x80E2D60", Offset = "0x80E2160", VA = "0x1880E2D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x80E30F0", Offset = "0x80E24F0", VA = "0x1880E30F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public GEMKBMFJJJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x80D2510", Offset = "0x80D1910", VA = "0x1880D2510")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task NOHIFMNCGAO(APGKENHKANG<string>.EEEKGBDKLHP timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct AIJFBBOPIKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public HGDOANGMHBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private IFKKDICMKCC <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x80CAD00", Offset = "0x80CA100", VA = "0x1880CAD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x80CB900", Offset = "0x80CAD00", VA = "0x1880CB900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class EOKCKGBMKPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public CECIAOOGNBJ version;

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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public EOKCKGBMKPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x80D0F90", Offset = "0x80D0390", VA = "0x1880D0F90")]
		internal object LHDFAGFCDMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x80D0EE0", Offset = "0x80D02E0", VA = "0x1880D0EE0")]
		internal object GPOJFHMIGPA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private FEJGNMMNDHD HPMNBNLACCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private KKJJOKHIFIF NHOEKMCOCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private bool LIJMPIPGMKC;

	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private static readonly ByteString BAFEBLDBIPA;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private BEHHGOBGNKL LDPIMCPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x80D4000", Offset = "0x80D3400", VA = "0x1880D4000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private CDCAHPMDKLI JLEJGCAJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x80D3F60", Offset = "0x80D3360", VA = "0x1880D3F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x80D3600", Offset = "0x80D2A00", VA = "0x1880D3600")]
	[AsyncStateMachine(typeof(LDPDNBPMKKL))]
	public static Task AMNMBKBGPIL(HENFMPPFGFG LMJMNPPPAHL, FEJGNMMNDHD HPMNBNLACCC, KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH, bool LIJMPIPGMKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x80D34D0", Offset = "0x80D28D0", VA = "0x1880D34D0")]
	[AsyncStateMachine(typeof(AIJFBBOPIKP))]
	private Task AMNMBKBGPIL(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x80D3750", Offset = "0x80D2B50", VA = "0x1880D3750")]
	private void BFKEHEIPFBG([NotNull] AOIFKBLFGKD KLBPAEOBMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x80D3F20", Offset = "0x80D3320", VA = "0x1880D3F20")]
	private bool COCAPJOKCHF(CECIAOOGNBJ IOFNCNFBMGK, AOIFKBLFGKD KLBPAEOBMAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct CGLKDPOJEME
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct LAAJLPFHAFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public AsyncTaskMethodBuilder<FEJGNMMNDHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public CGLKDPOJEME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public PKEEJPANGHO.BNNACOHHJOL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private APGKENHKANG<string>.EEEKGBDKLHP <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private TaskAwaiter<IReadOnlyCollection<INFPHCDJCLC>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private TaskAwaiter<(KGPHFOFOMPJ<MJBEDDENEDM, ADGPAJEIFGP>, KGPHFOFOMPJ<PPEBEAEDJID<AOIFKBLFGKD>, ADGPAJEIFGP>, KGPHFOFOMPJ<PPEBEAEDJID<NFAAFKCENHI>, ADGPAJEIFGP>, KGPHFOFOMPJ<PPEBEAEDJID<IEnumerable<LLDEBPMCGFM>>, ADGPAJEIFGP>, KGPHFOFOMPJ<PPEBEAEDJID<OADNLLEBHMI>, ADGPAJEIFGP>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x80D7360", Offset = "0x80D6760", VA = "0x1880D7360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x80D8140", Offset = "0x80D7540", VA = "0x1880D8140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct HAJOLELEFEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<MJBEDDENEDM, ADGPAJEIFGP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public APGKENHKANG<string>.EEEKGBDKLHP downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public CGLKDPOJEME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public IReadOnlyCollection<INFPHCDJCLC> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public IReadOnlyCollection<INFPHCDJCLC> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public PKEEJPANGHO.BNNACOHHJOL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter<KGPHFOFOMPJ<MJBEDDENEDM, ADGPAJEIFGP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x80D2E00", Offset = "0x80D2200", VA = "0x1880D2E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x80D3460", Offset = "0x80D2860", VA = "0x1880D3460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	private GLNNEJMAOCG<KKCEGILFGJB, NFAAFKCENHI> NMJLEPIBEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	private GLNNEJMAOCG<KKCEGILFGJB, AOIFKBLFGKD> NBFDPHANPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	private GLNNEJMAOCG<APIECIFOHEN, IEnumerable<LLDEBPMCGFM>> IAFCAIPLCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	private GLNNEJMAOCG<long, OADNLLEBHMI> AEDPGNCCDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private KFJDGJEGIOM KNENEEOMHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private IBBAMKLHGAN BCEDDHNENJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private GMHIEIPOGED DNJKJFGBJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	private Guid? JGICNMOHCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	private IReadOnlyCollection<INFPHCDJCLC> BKGEJEKCCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private Task<IReadOnlyCollection<INFPHCDJCLC>> NJHDMFNCGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	private KKCEGILFGJB JKIDAGFNHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private KKCEGILFGJB LLICHJIMFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private KKCEGILFGJB? IANBAGIGNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private APIECIFOHEN OOCJDIEIEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB;

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x80CE2B0", Offset = "0x80CD6B0", VA = "0x1880CE2B0")]
	public static Task<FEJGNMMNDHD> MDOFEFHDGHD(HENFMPPFGFG LMJMNPPPAHL, [In] LLFJICEIFIE HPMNBNLACCC, PKEEJPANGHO.BNNACOHHJOL ELOKFHOLKDI, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x80CDED0", Offset = "0x80CD2D0", VA = "0x1880CDED0")]
	[AsyncStateMachine(typeof(LAAJLPFHAFG))]
	private Task<FEJGNMMNDHD> AMNMBKBGPIL(PKEEJPANGHO.BNNACOHHJOL ELOKFHOLKDI, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x80CE080", Offset = "0x80CD480", VA = "0x1880CE080")]
	[AsyncStateMachine(typeof(HAJOLELEFEC))]
	private Task<KGPHFOFOMPJ<MJBEDDENEDM, ADGPAJEIFGP>> BDELOHHCEOG(Guid? JGICNMOHCMI, IReadOnlyCollection<INFPHCDJCLC> BKGEJEKCCOC, IReadOnlyCollection<INFPHCDJCLC> NGEAFLLBCHM, long? MIFADOBCMAC, long? OFAOCKBMEGP, PKEEJPANGHO.BNNACOHHJOL ELOKFHOLKDI, APGKENHKANG<string>.EEEKGBDKLHP DBPNBHHJBHL, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct MIPGGNGAMPA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct DJHBKLBNGCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public AsyncTaskMethodBuilder<LLFJICEIFIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public MIPGGNGAMPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private APGKENHKANG<string>.EEEKGBDKLHP <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private TaskAwaiter<LLFJICEIFIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x80CFAC0", Offset = "0x80CEEC0", VA = "0x1880CFAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x80CFF10", Offset = "0x80CF310", VA = "0x1880CFF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct PJBCMJBALNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public AsyncTaskMethodBuilder<LLFJICEIFIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public MIPGGNGAMPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private TaskAwaiter<LLFJICEIFIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x80E05B0", Offset = "0x80DF9B0", VA = "0x1880E05B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x80E0A30", Offset = "0x80DFE30", VA = "0x1880E0A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class BLBMEDMJHGJ
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
			public BLBMEDMJHGJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			private TaskAwaiter<MJFIDHLLGBC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			private TaskAwaiter<GKGFGBABKAH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x80E0E60", Offset = "0x80E0260", VA = "0x1880E0E60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x80E1810", Offset = "0x80E0C10", VA = "0x1880E1810", Slot = "5")]
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
		public HMNAEIFDIFE roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public BEHHGOBGNKL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public KKCEGILFGJB superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public KKCEGILFGJB subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public IReadOnlyList<INFPHCDJCLC> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public IReadOnlyList<INFPHCDJCLC> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public IBBAMKLHGAN roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public BLBMEDMJHGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xDB4D10", Offset = "0xDB4110", VA = "0x180DB4D10")]
		internal bool CEHOOAKAKBE(GMHIEIPOGED sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x80CD900", Offset = "0x80CCD00", VA = "0x1880CD900")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task PIKIONADBML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x80CD700", Offset = "0x80CCB00", VA = "0x1880CD700")]
		internal Task<APIECIFOHEN> FDINHINCFDG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct NJFPBLLLEMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public AsyncTaskMethodBuilder<LLFJICEIFIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public HMNAEIFDIFE roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public BEHHGOBGNKL callbacks;

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
		public KKCEGILFGJB superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private BLBMEDMJHGJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private GMHIEIPOGED <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private Task<APIECIFOHEN> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private TaskAwaiter<IBBAMKLHGAN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private TaskAwaiter<APIECIFOHEN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x80DE1C0", Offset = "0x80DD5C0", VA = "0x1880DE1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x80DF170", Offset = "0x80DE570", VA = "0x1880DF170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	private BEHHGOBGNKL IAPHFNOPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private EGBBHHGAGKN BDFIBCDOEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	private HMNAEIFDIFE FPEOBPEELJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	private APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private long MIFADOBCMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private long JCNNPHFBOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private long KFJJHJMHDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	private string EFBGJFMCDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	private KKCEGILFGJB BFMEHFLBKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private Guid MKCDIKOMEAO;

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x80DC230", Offset = "0x80DB630", VA = "0x1880DC230")]
	public static Task<LLFJICEIFIE> MDOFEFHDGHD(HENFMPPFGFG LMJMNPPPAHL, NAMDFBDBPAO ANMDEHLLLBJ, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x80DBD70", Offset = "0x80DB170", VA = "0x1880DBD70")]
	[AsyncStateMachine(typeof(DJHBKLBNGCF))]
	private Task<LLFJICEIFIE> AMNMBKBGPIL(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x80DBEC0", Offset = "0x80DB2C0", VA = "0x1880DBEC0")]
	[AsyncStateMachine(typeof(PJBCMJBALNK))]
	private Task<LLFJICEIFIE> CBBODNHLDHH(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x80DC030", Offset = "0x80DB430", VA = "0x1880DC030")]
	[AsyncStateMachine(typeof(NJFPBLLLEMG))]
	private static Task<LLFJICEIFIE> CBBODNHLDHH(BEHHGOBGNKL IAPHFNOPBJO, HMNAEIFDIFE FPEOBPEELJF, long MIFADOBCMAC, long JCNNPHFBOMP, long KFJJHJMHDOB, string EFBGJFMCDKM, KKCEGILFGJB BFMEHFLBKKN, Guid MKCDIKOMEAO, CancellationToken LMNHDKIFBOH, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x80DC200", Offset = "0x80DB600", VA = "0x1880DC200")]
	private void LJAIHCPKFMN(IBBAMKLHGAN BCEDDHNENJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
internal struct KHOOBDAKPAO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct PILJOLPOOME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public KHOOBDAKPAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x80DFFC0", Offset = "0x80DF3C0", VA = "0x1880DFFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x80E0550", Offset = "0x80DF950", VA = "0x1880E0550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private BEHHGOBGNKL IAPHFNOPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private FEJGNMMNDHD HPMNBNLACCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	private APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	private float NECLKMCCDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private float DHDMPBNLPAG;

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x80D6AD0", Offset = "0x80D5ED0", VA = "0x1880D6AD0")]
	public static Task CHFKHDLNPND(HENFMPPFGFG LMJMNPPPAHL, FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x80D6880", Offset = "0x80D5C80", VA = "0x1880D6880")]
	[AsyncStateMachine(typeof(PILJOLPOOME))]
	public Task AMNMBKBGPIL(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x80D69A0", Offset = "0x80D5DA0", VA = "0x1880D69A0")]
	private static void BGGNIDBDMPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x80D6C70", Offset = "0x80D6070", VA = "0x1880D6C70")]
	private void JEJHEAHHMAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x80D6DF0", Offset = "0x80D61F0", VA = "0x1880D6DF0")]
	private static float PLCAELMDBCK(BEHHGOBGNKL IAPHFNOPBJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x80D6DD0", Offset = "0x80D61D0", VA = "0x1880D6DD0")]
	private static float MFCPJOMBOEJ()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000171")]
internal struct MBJPOMJEPGB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct IKDDEFNIEGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private EBHOBHMGDHC <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private HENFMPPFGFG <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private NEKEBJFHDJO.GLLCLBOHLDM <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x80D46A0", Offset = "0x80D3AA0", VA = "0x1880D46A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x80D4EC0", Offset = "0x80D42C0", VA = "0x1880D4EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private struct CEHPLELBBFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x80CDAF0", Offset = "0x80CCEF0", VA = "0x1880CDAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x80CDE20", Offset = "0x80CD220", VA = "0x1880CDE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x80D9620", Offset = "0x80D8A20", VA = "0x1880D9620")]
	[AsyncStateMachine(typeof(IKDDEFNIEGO))]
	public static Task AMNMBKBGPIL(KKJJOKHIFIF NHOEKMCOCFJ, FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x80D9820", Offset = "0x80D8C20", VA = "0x1880D9820")]
	private static Task<EPOGGLOBAKG> CPBEDOIBKNP(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x80D9760", Offset = "0x80D8B60", VA = "0x1880D9760")]
	[AsyncStateMachine(typeof(CEHPLELBBFL))]
	private static Task BDHKNJBDGNL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct AIEAPCNIPJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct JGFNECAPHPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public AIEAPCNIPJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x80D52B0", Offset = "0x80D46B0", VA = "0x1880D52B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x80D5960", Offset = "0x80D4D60", VA = "0x1880D5960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class DIJFPHLAAPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public DIJFPHLAAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x80CFA40", Offset = "0x80CEE40", VA = "0x1880CFA40")]
		internal object ONHCMHEPCNJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct JHPEADIODNF : IAsyncStateMachine
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
		public AIEAPCNIPJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x80D6050", Offset = "0x80D5450", VA = "0x1880D6050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x80D64D0", Offset = "0x80D58D0", VA = "0x1880D64D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private bool IDMFCMLEMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private CancellationToken LMNHDKIFBOH;

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x80CAB60", Offset = "0x80C9F60", VA = "0x1880CAB60")]
	public static Task GGENPDJMBBE(HENFMPPFGFG LMJMNPPPAHL, bool IDMFCMLEMKF, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken ACCKNLEMPFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x80CAA70", Offset = "0x80C9E70", VA = "0x1880CAA70")]
	[AsyncStateMachine(typeof(JGFNECAPHPN))]
	private Task AMNMBKBGPIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x80CABD0", Offset = "0x80C9FD0", VA = "0x1880CABD0")]
	[AsyncStateMachine(typeof(JHPEADIODNF))]
	private Task NGCKJANIEHD(bool FCCJDBBOCBI, string DFCMKAEHLAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930")]
	private bool IKHAKCDAABE(bool IDMFCMLEMKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
internal struct JABCCLAIPFH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct EBDACLAJKPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public JABCCLAIPFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x80CFF80", Offset = "0x80CF380", VA = "0x1880CFF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x80D04F0", Offset = "0x80CF8F0", VA = "0x1880D04F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class CFNEJDFFHMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public CFNEJDFFHMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x80CDE80", Offset = "0x80CD280", VA = "0x1880CDE80")]
		internal object ONHCMHEPCNJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private struct FHCHKFGLFGH : IAsyncStateMachine
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
		public JABCCLAIPFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x80D1790", Offset = "0x80D0B90", VA = "0x1880D1790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x80D1C10", Offset = "0x80D1010", VA = "0x1880D1C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private JAEMPKFBFLE HLOOKLFAJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private bool KLLCNDEIEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private FEJGNMMNDHD HPMNBNLACCC;

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x80D50B0", Offset = "0x80D44B0", VA = "0x1880D50B0")]
	public static Task<Scene> BGMGGAGKKOL(HENFMPPFGFG LMJMNPPPAHL, JAEMPKFBFLE NGFOGEBLNMM, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x80D4F90", Offset = "0x80D4390", VA = "0x1880D4F90")]
	[AsyncStateMachine(typeof(EBDACLAJKPJ))]
	private Task<Scene> AMNMBKBGPIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x80D5130", Offset = "0x80D4530", VA = "0x1880D5130")]
	private bool MOJAMDEECPC(FEJGNMMNDHD HPMNBNLACCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x80D4F20", Offset = "0x80D4320", VA = "0x1880D4F20")]
	private void ADLGAEFDFOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x80D5160", Offset = "0x80D4560", VA = "0x1880D5160")]
	[AsyncStateMachine(typeof(FHCHKFGLFGH))]
	private Task<Scene> NGCKJANIEHD(string DFCMKAEHLAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal struct KMGIEHGOPOH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct CPHEOOLMLOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public KMGIEHGOPOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public CPPDEEJEANJ nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public FEJGNMMNDHD deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private APGKENHKANG<string>.EEEKGBDKLHP <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x80CEF00", Offset = "0x80CE300", VA = "0x1880CEF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x80CF9D0", Offset = "0x80CEDD0", VA = "0x1880CF9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct CONLCCGKFON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public KMGIEHGOPOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public CPPDEEJEANJ state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x80CEBB0", Offset = "0x80CDFB0", VA = "0x1880CEBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x80CEE90", Offset = "0x80CE290", VA = "0x1880CEE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	private readonly KKJJOKHIFIF NHOEKMCOCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private readonly EGBBHHGAGKN BDFIBCDOEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private readonly AJIIKDKENGF LAOGAOKCDDK;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private EBHOBHMGDHC GOAKAGEIOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x65DDE10", Offset = "0x65DD210", VA = "0x1865DDE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x80D71E0", Offset = "0x80D65E0", VA = "0x1880D71E0")]
	public KMGIEHGOPOH(KKJJOKHIFIF NHOEKMCOCFJ, EGBBHHGAGKN BDFIBCDOEKG, AJIIKDKENGF LAOGAOKCDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x80D7060", Offset = "0x80D6460", VA = "0x1880D7060")]
	[AsyncStateMachine(typeof(CPHEOOLMLOM))]
	public Task<CPPDEEJEANJ> PFJGMBDMACP(CPPDEEJEANJ OKCFFPINPMN, FEJGNMMNDHD PNEKEJIIDPC, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH, bool JAPCKMIOHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x80D6EB0", Offset = "0x80D62B0", VA = "0x1880D6EB0")]
	[AsyncStateMachine(typeof(CONLCCGKFON))]
	private Task<CPPDEEJEANJ> DOMAGLIGIDO(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CPPDEEJEANJ DHJOIBPBMPI, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x80D7030", Offset = "0x80D6430", VA = "0x1880D7030")]
	private bool KIIMBFKDJJI(CPPDEEJEANJ LCPALEACDKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x80D7010", Offset = "0x80D6410", VA = "0x1880D7010")]
	private void GFDFDHMHGGA(string GJKLHCCFCHI)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal struct BHBKMDIDFMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct FCNNLGOHHIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public EBHOBHMGDHC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public PLDBJHIGINN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private IFKKDICMKCC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private List<(PersistenceView, AJANKEAEBKF)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private (PersistenceView, AJANKEAEBKF) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x80D1070", Offset = "0x80D0470", VA = "0x1880D1070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x80D1730", Offset = "0x80D0B30", VA = "0x1880D1730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x80CD5C0", Offset = "0x80CC9C0", VA = "0x1880CD5C0")]
	[AsyncStateMachine(typeof(FCNNLGOHHIO))]
	public static Task AMNMBKBGPIL(EBHOBHMGDHC EKJBIEIFIHC, FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal struct CLMNPEIAENC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct NKJMELEIPNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public EBHOBHMGDHC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public PLDBJHIGINN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private CECIAOOGNBJ <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private IFKKDICMKCC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private List<(PersistenceView, AJANKEAEBKF)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private AJANKEAEBKF <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x80DF1E0", Offset = "0x80DE5E0", VA = "0x1880DF1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x80DFAC0", Offset = "0x80DEEC0", VA = "0x1880DFAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x80CE7B0", Offset = "0x80CDBB0", VA = "0x1880CE7B0")]
	[AsyncStateMachine(typeof(NKJMELEIPNO))]
	public static Task AMNMBKBGPIL(EBHOBHMGDHC EKJBIEIFIHC, FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal struct NEKEBJFHDJO
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	public struct GLLCLBOHLDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public List<PBLDHPJABID> CBPLGBMDHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public List<AJANKEAEBKF> IABBBFPOLCB;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2B0", Offset = "0xA3C6B0", VA = "0x180A3D2B0")]
		public GLLCLBOHLDM(List<PBLDHPJABID> CBPLGBMDHAG, List<AJANKEAEBKF> IABBBFPOLCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private sealed class LMONBMICLNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public IEnumerable<PBLDHPJABID> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public LMONBMICLNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x80D95A0", Offset = "0x80D89A0", VA = "0x1880D95A0")]
		internal object EILLAILGMPF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private FEJGNMMNDHD HPMNBNLACCC;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private BEHHGOBGNKL LDPIMCPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x80DDBE0", Offset = "0x80DCFE0", VA = "0x1880DDBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x80DD400", Offset = "0x80DC800", VA = "0x1880DD400")]
	public static GLLCLBOHLDM AMNMBKBGPIL(HENFMPPFGFG LMJMNPPPAHL, FEJGNMMNDHD HPMNBNLACCC)
	{
		return default(GLLCLBOHLDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x80DD1B0", Offset = "0x80DC5B0", VA = "0x1880DD1B0")]
	private GLLCLBOHLDM AMNMBKBGPIL()
	{
		return default(GLLCLBOHLDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x80DD460", Offset = "0x80DC860", VA = "0x1880DD460")]
	private GLLCLBOHLDM CJMLOMBJCJE(AOIFKBLFGKD KLBPAEOBMAP, CECIAOOGNBJ JBMJKJMIILJ)
	{
		return default(GLLCLBOHLDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x80DDA10", Offset = "0x80DCE10", VA = "0x1880DDA10")]
	private bool DBKGNKJLFNB(IEnumerable<PBLDHPJABID> CBPLGBMDHAG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal struct ACKIMHGLCDB
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class BABOBBFDNMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public NEKEBJFHDJO.GLLCLBOHLDM instantiations;

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public BABOBBFDNMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x80CD480", Offset = "0x80CC880", VA = "0x1880CD480")]
		internal object NOHIFMNCGAO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class BFMOGLDGGCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public BFMOGLDGGCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x80CD530", Offset = "0x80CC930", VA = "0x1880CD530")]
		internal object MFBLKHJDHJI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x80C9C80", Offset = "0x80C9080", VA = "0x1880C9C80")]
	public static void AMNMBKBGPIL(EBHOBHMGDHC EKJBIEIFIHC, FEJGNMMNDHD HPMNBNLACCC, NEKEBJFHDJO.GLLCLBOHLDM OOGDBEOLEGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal class AJIIKDKENGF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct GKLOOPPDIIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public AJIIKDKENGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public CPPDEEJEANJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public FEJGNMMNDHD deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x80D2630", Offset = "0x80D1A30", VA = "0x1880D2630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x80D2DA0", Offset = "0x80D21A0", VA = "0x1880D2DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class FJJHPOCKOHP
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
			public FJJHPOCKOHP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006DA")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000664")]
			[Cpp2IlInjected.Address(RVA = "0x80E2A40", Offset = "0x80E1E40", VA = "0x1880E2A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x80E2D00", Offset = "0x80E2100", VA = "0x1880E2D00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public AJIIKDKENGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public APGKENHKANG<string>.EEEKGBDKLHP handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public FJJHPOCKOHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x80D1C80", Offset = "0x80D1080", VA = "0x1880D1C80")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task LOELDOBFGJF(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private struct NHLAIFOJHNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public AJIIKDKENGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		private FJJHPOCKOHP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x80DDC30", Offset = "0x80DD030", VA = "0x1880DDC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x80DE160", Offset = "0x80DD560", VA = "0x1880DE160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct CGHNABAIHNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public AJIIKDKENGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private Dictionary<Guid, List<PHPLHHACNNI>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x80E5950", Offset = "0x80E4D50", VA = "0x1880E5950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x80E5F60", Offset = "0x80E5360", VA = "0x1880E5F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private struct MHDKNLKIHPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public AJIIKDKENGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private Dictionary<Guid, List<PHPLHHACNNI>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x80F0070", Offset = "0x80EF470", VA = "0x1880F0070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x80F0700", Offset = "0x80EFB00", VA = "0x1880F0700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class FHFLIPAJCHM
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
			public PHPLHHACNNI handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006FE")]
			public FHFLIPAJCHM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006FF")]
			private IFKKDICMKCC <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000700")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x80F1EB0", Offset = "0x80F12B0", VA = "0x1880F1EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x80F2310", Offset = "0x80F1710", VA = "0x1880F2310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public AGFEBOGLHIP runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public List<PHPLHHACNNI> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public FHFLIPAJCHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x80E7E60", Offset = "0x80E7260", VA = "0x1880E7E60")]
		internal object NGGFEKJILEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x80E7D60", Offset = "0x80E7160", VA = "0x1880E7D60")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task EDNOBBOKBKE(PHPLHHACNNI handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x80E7F50", Offset = "0x80E7350", VA = "0x1880E7F50")]
		internal object NNBKCJKMLFN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct EKJJPNJDCDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public AGFEBOGLHIP runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public List<PHPLHHACNNI> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		private FHFLIPAJCHM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x80E7830", Offset = "0x80E6C30", VA = "0x1880E7830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x80E7D00", Offset = "0x80E7100", VA = "0x1880E7D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private struct KLMHHOOGGBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public AJIIKDKENGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

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
		[Cpp2IlInjected.Address(RVA = "0x80EF4B0", Offset = "0x80EE8B0", VA = "0x1880EF4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x80EF7A0", Offset = "0x80EEBA0", VA = "0x1880EF7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class PMPFNEMHKBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public PMPFNEMHKBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x80F1E40", Offset = "0x80F1240", VA = "0x1880F1E40")]
		internal object GDDKBEIHCHH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private struct DFMNFGOBKGO : IAsyncStateMachine
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
		public AJIIKDKENGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x80E6190", Offset = "0x80E5590", VA = "0x1880E6190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x80E6640", Offset = "0x80E5A40", VA = "0x1880E6640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class OAACFJAODMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public OAACFJAODMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x80F0980", Offset = "0x80EFD80", VA = "0x1880F0980")]
		internal object HPDNPFNPPMN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private struct BFDNMGGEGJF : IAsyncStateMachine
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
		public AJIIKDKENGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x80E3800", Offset = "0x80E2C00", VA = "0x1880E3800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x80E3E30", Offset = "0x80E3230", VA = "0x1880E3E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class BJNNDEFPAMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public BJNNDEFPAMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x80E3E90", Offset = "0x80E3290", VA = "0x1880E3E90")]
		internal object GCMELIHGDHG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private readonly KKJJOKHIFIF NHOEKMCOCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private GFIJHOCNJMG LAOGAOKCDDK;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private EBHOBHMGDHC GOAKAGEIOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x1039E90", Offset = "0x1039290", VA = "0x181039E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	public AJIIKDKENGF(KKJJOKHIFIF NHOEKMCOCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x80CBAA0", Offset = "0x80CAEA0", VA = "0x1880CBAA0")]
	[AsyncStateMachine(typeof(GKLOOPPDIIK))]
	public Task AMNMBKBGPIL(CPPDEEJEANJ OIHFCHECHPE, FEJGNMMNDHD PNEKEJIIDPC, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x80CC180", Offset = "0x80CB580", VA = "0x1880CC180")]
	[AsyncStateMachine(typeof(NHLAIFOJHNI))]
	private Task JCKBKECGNIE(FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x80CBF00", Offset = "0x80CB300", VA = "0x1880CBF00")]
	[AsyncStateMachine(typeof(CGHNABAIHNN))]
	private Task FIFJHCHNHOC(FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x80CC730", Offset = "0x80CBB30", VA = "0x1880CC730")]
	[AsyncStateMachine(typeof(MHDKNLKIHPE))]
	private Task PPHLAAFCKIL(FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x80CC480", Offset = "0x80CB880", VA = "0x1880CC480")]
	[AsyncStateMachine(typeof(EKJJPNJDCDH))]
	private Task OPJCJNMKFKC(Guid EBKKNHAJLEM, List<PHPLHHACNNI> PHGHBAOFPNF, AGFEBOGLHIP AMPLHFDHCMG, FEJGNMMNDHD HPMNBNLACCC, CancellationToken HHGPJKKLNIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x80CC040", Offset = "0x80CB440", VA = "0x1880CC040")]
	[AsyncStateMachine(typeof(KLMHHOOGGBI))]
	private Task FPFOIKJPJHG(FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x80CB960", Offset = "0x80CAD60", VA = "0x1880CB960")]
	[AsyncStateMachine(typeof(DFMNFGOBKGO))]
	private Task ALHIHAHLADF(Guid MPNKLMEHFIA, FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x80CBDC0", Offset = "0x80CB1C0", VA = "0x1880CBDC0")]
	[AsyncStateMachine(typeof(BFDNMGGEGJF))]
	private Task EBMKDHCDHPE(Guid MPNKLMEHFIA, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x80CC370", Offset = "0x80CB770", VA = "0x1880CC370")]
	private void KKMNLEHLGGD(Guid MPNKLMEHFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x80CC2C0", Offset = "0x80CB6C0", VA = "0x1880CC2C0")]
	private void KKAABHJGHAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x80CC5D0", Offset = "0x80CB9D0", VA = "0x1880CC5D0")]
	public Guid PACHFDDJNIA(CPPDEEJEANJ EBDPJJJPIOL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x80CBBF0", Offset = "0x80CAFF0", VA = "0x1880CBBF0")]
	[CompilerGenerated]
	private object DNHMKMJBIKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal struct JAKNLIMDIHM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct JGMHFBPAAFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public JAKNLIMDIHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		private IEnumerator<HIAAHBCANNL> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x80ED870", Offset = "0x80ECC70", VA = "0x1880ED870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x80EDF00", Offset = "0x80ED300", VA = "0x1880EDF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000729")]
	private BEHHGOBGNKL IAPHFNOPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400072A")]
	private APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072B")]
	private CancellationToken LMNHDKIFBOH;

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x80ED450", Offset = "0x80EC850", VA = "0x1880ED450")]
	public static Task PFDECELLGBL(BEHHGOBGNKL IAPHFNOPBJO, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken ACCKNLEMPFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x80ED360", Offset = "0x80EC760", VA = "0x1880ED360")]
	[AsyncStateMachine(typeof(JGMHFBPAAFL))]
	private Task AMNMBKBGPIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public readonly struct DCMMCMGKNNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000732")]
	public readonly bool JBFHOMJDIAE;

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x28634A0", Offset = "0x28628A0", VA = "0x1828634A0")]
	public DCMMCMGKNNK(bool KNOHFHHIJHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public readonly struct PLFCMNGIAGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000733")]
	public readonly AOIFKBLFGKD? FDLLHFJHPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000734")]
	public readonly LMBINBOIHNM ADFGKBCLDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000735")]
	public readonly Guid? NBIGHKECMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000736")]
	public readonly IReadOnlyList<Guid> ECDAMHAKBBI;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public IReadOnlyCollection<string> GGOIBNGNOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x80F1D20", Offset = "0x80F1120", VA = "0x1880F1D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public IReadOnlyDictionary<long, int> NLDNGDGJCEC
	{
		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x80F1D00", Offset = "0x80F1100", VA = "0x1880F1D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x80F1D40", Offset = "0x80F1140", VA = "0x1880F1D40")]
	public PLFCMNGIAGA(AOIFKBLFGKD? LLMAFCHBBPF, LMBINBOIHNM IJPFNDPHDOM, Guid? JGICNMOHCMI, [Optional] IReadOnlyList<Guid>? HHCLEOOMIME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
internal class HHEPFLADLLI : LOMGCHGEPFF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private struct IBMDBBGMGGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public AsyncTaskMethodBuilder<PLFCMNGIAGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public HHEPFLADLLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		public HKFCLLCDEKJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public HJGDKKKNFOO roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		private IFKKDICMKCC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x80EC310", Offset = "0x80EB710", VA = "0x1880EC310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x80EC9B0", Offset = "0x80EBDB0", VA = "0x1880EC9B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private sealed class HHLNFCACDJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public HHLNFCACDJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x80EB6B0", Offset = "0x80EAAB0", VA = "0x1880EB6B0")]
		internal object BCBOBPECJLJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private struct CCEKMHFGDAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public HHEPFLADLLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		public HKFCLLCDEKJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private HHLNFCACDJG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private IFKKDICMKCC <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private LEHDJFKJBJH<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x80E4E30", Offset = "0x80E4230", VA = "0x1880E4E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x80E58F0", Offset = "0x80E4CF0", VA = "0x1880E58F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000737")]
	private readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x4000738")]
	private static readonly TimeSpan KLNMLCEHBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000739")]
	private readonly ICJNLBAHBIB AGIMLMJEEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400073A")]
	private readonly KFMCEPHLDFP OIIAIOBOJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400073B")]
	private readonly GMCCGHJBJAL CFKGPJIDBKL;

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x80EB640", Offset = "0x80EAA40", VA = "0x1880EB640")]
	public HHEPFLADLLI(KKJJOKHIFIF NHOEKMCOCFJ, ICJNLBAHBIB AGIMLMJEEAK, KFMCEPHLDFP IELMBIOABLF, GMCCGHJBJAL CFKGPJIDBKL, GBHBOJAPDOA DPDKJPMBJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x80EB480", Offset = "0x80EA880", VA = "0x1880EB480")]
	[AsyncStateMachine(typeof(IBMDBBGMGGA))]
	public Task<PLFCMNGIAGA> PELCBGJOJPC(long JCNNPHFBOMP, HJGDKKKNFOO ONHCODKGHOO, HKFCLLCDEKJ BONNIONLFGJ, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x80EB340", Offset = "0x80EA740", VA = "0x1880EB340")]
	[AsyncStateMachine(typeof(CCEKMHFGDAI))]
	private Task MGGPPECPLCA(HKFCLLCDEKJ BONNIONLFGJ, PersistenceView[] HOLHGEDPHEF, StringBuilder LNPIOIEKNKK, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x80EAAE0", Offset = "0x80E9EE0", VA = "0x1880EAAE0")]
	private PLFCMNGIAGA IJFCCFNGONE(long JCNNPHFBOMP, HJGDKKKNFOO ONHCODKGHOO, HKFCLLCDEKJ BONNIONLFGJ, IEnumerable<PersistenceView> HOLHGEDPHEF, StringBuilder LNPIOIEKNKK)
	{
		return default(PLFCMNGIAGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x80EA490", Offset = "0x80E9890", VA = "0x1880EA490")]
	private AOIFKBLFGKD CJDCDGODCMM(long JCNNPHFBOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x80EB0F0", Offset = "0x80EA4F0", VA = "0x1880EB0F0")]
	private void LFFPAMIKHNA(AOIFKBLFGKD ONBMANKKKHN, StringBuilder LNPIOIEKNKK, IEnumerable<PersistenceView> HOLHGEDPHEF, [In] EJPLPBCADEO PAKDJMBDPBI, AOBGJNEOAEI IGKLENELELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x80EA650", Offset = "0x80E9A50", VA = "0x1880EA650")]
	private void FHBIJFICLBH(AOIFKBLFGKD ONBMANKKKHN, StringBuilder LNPIOIEKNKK, PersistenceView EKLEPCBGCMK, AOBGJNEOAEI IGKLENELELN, [In] EJPLPBCADEO PAKDJMBDPBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal class HOBKOKHAHLA : LOMGCHGEPFF
{
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private sealed class IOEPMDGPIFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public LBNOIGENJNJ.HCGGFPCHEGC roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public IOEPMDGPIFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x80ED310", Offset = "0x80EC710", VA = "0x1880ED310")]
		internal object LDDDCLJDLCB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private struct OOLIABOCJPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public AsyncTaskMethodBuilder<(LBNOIGENJNJ.HCGGFPCHEGC roomDataUpload, LBNOIGENJNJ.HCGGFPCHEGC subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public PLFCMNGIAGA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public BEHHGOBGNKL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		private IOEPMDGPIFI <>8__1;

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
		private TaskAwaiter<LBNOIGENJNJ.HCGGFPCHEGC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x80F09F0", Offset = "0x80EFDF0", VA = "0x1880F09F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x80F1270", Offset = "0x80F0670", VA = "0x1880F1270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private struct JEIDJDKJFAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public AsyncTaskMethodBuilder<DHJBDKCLFJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public HOBKOKHAHLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public IJHECIBDPGO roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public PLFCMNGIAGA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		private TaskAwaiter<DHJBDKCLFJF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x80ED4C0", Offset = "0x80EC8C0", VA = "0x1880ED4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x80ED760", Offset = "0x80ECB60", VA = "0x1880ED760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private struct EJMBLCIHKBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public AsyncTaskMethodBuilder<DHJBDKCLFJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public BEHHGOBGNKL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public PLFCMNGIAGA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public NFIJHFLFIBC ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public IJHECIBDPGO roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		private TaskAwaiter<(LBNOIGENJNJ.HCGGFPCHEGC roomDataUpload, LBNOIGENJNJ.HCGGFPCHEGC subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		private TaskAwaiter<DHJBDKCLFJF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x80E7160", Offset = "0x80E6560", VA = "0x1880E7160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x80E77C0", Offset = "0x80E6BC0", VA = "0x1880E77C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private struct MBDHMKBAKDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		public AsyncTaskMethodBuilder<MJFIDHLLGBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		public HOBKOKHAHLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		public PLFCMNGIAGA roomSerializedData;

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
		private TaskAwaiter<(LBNOIGENJNJ.HCGGFPCHEGC roomDataUpload, LBNOIGENJNJ.HCGGFPCHEGC subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		private TaskAwaiter<MJFIDHLLGBC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x80EFB40", Offset = "0x80EEF40", VA = "0x1880EFB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x80F0000", Offset = "0x80EF400", VA = "0x1880F0000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private sealed class KDNHJAKHPNO
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
			public AsyncTaskMethodBuilder<EPOGGLOBAKG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400078A")]
			public KDNHJAKHPNO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400078B")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400078C")]
			private EPOGGLOBAKG <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400078D")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400078E")]
			private TaskAwaiter<MJFIDHLLGBC> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400078F")]
			private TaskAwaiter<DHJBDKCLFJF> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000790")]
			private TaskAwaiter<EPOGGLOBAKG> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006B2")]
			[Cpp2IlInjected.Address(RVA = "0x80F2370", Offset = "0x80F1770", VA = "0x1880F2370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0x80F3580", Offset = "0x80F2980", VA = "0x1880F3580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public HOBKOKHAHLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public PLFCMNGIAGA roomSerializedData;

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
		public IJHECIBDPGO roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public DCMMCMGKNNK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public KDNHJAKHPNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x80EF380", Offset = "0x80EE780", VA = "0x1880EF380")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<EPOGGLOBAKG> HCHDELPDNNI(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private struct BLODLCGLJEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public AsyncTaskMethodBuilder<EPOGGLOBAKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public HOBKOKHAHLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public PLFCMNGIAGA roomSerializedData;

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
		public IJHECIBDPGO roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public DCMMCMGKNNK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x80E3F00", Offset = "0x80E3300", VA = "0x1880E3F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x80E4230", Offset = "0x80E3630", VA = "0x1880E4230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000755")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x4000756")]
	private static readonly GBHBOJAPDOA MLIAFKELENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000757")]
	private readonly DKOGEAIEABM OLIGAJLLAND;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private HENFMPPFGFG KBLPAMDIOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x80BE130", Offset = "0x80BD530", VA = "0x1880BE130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x80EC280", Offset = "0x80EB680", VA = "0x1880EC280")]
	public HOBKOKHAHLA(KKJJOKHIFIF NHOEKMCOCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x80EBD70", Offset = "0x80EB170", VA = "0x1880EBD70")]
	[AsyncStateMachine(typeof(OOLIABOCJPP))]
	private static Task<(LBNOIGENJNJ.HCGGFPCHEGC, LBNOIGENJNJ.HCGGFPCHEGC)> GOGNIGAJIBM(BEHHGOBGNKL IAPHFNOPBJO, PLFCMNGIAGA ECMHMDMOHLI, long MIFADOBCMAC, long OFAOCKBMEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x80EB8B0", Offset = "0x80EACB0", VA = "0x1880EB8B0")]
	[AsyncStateMachine(typeof(JEIDJDKJFAI))]
	public Task<DHJBDKCLFJF> BJPJHGFPCMH(int ALJILABKHFO, [CanBeNull] IJHECIBDPGO FBOPDOAKGNF, PLFCMNGIAGA ECMHMDMOHLI, long MIFADOBCMAC, long OFAOCKBMEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x80EBA20", Offset = "0x80EAE20", VA = "0x1880EBA20")]
	public static Task<DHJBDKCLFJF> BJPJHGFPCMH(BEHHGOBGNKL IAPHFNOPBJO, int ALJILABKHFO, [CanBeNull] IJHECIBDPGO FBOPDOAKGNF, PLFCMNGIAGA ECMHMDMOHLI, long MIFADOBCMAC, long OFAOCKBMEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x80EB720", Offset = "0x80EAB20", VA = "0x1880EB720")]
	[AsyncStateMachine(typeof(EJMBLCIHKBN))]
	public static Task<DHJBDKCLFJF> BJPJHGFPCMH(BEHHGOBGNKL IAPHFNOPBJO, int ALJILABKHFO, [CanBeNull] IJHECIBDPGO FBOPDOAKGNF, PLFCMNGIAGA ECMHMDMOHLI, long MIFADOBCMAC, long OFAOCKBMEGP, NFIJHFLFIBC FAAABALDJOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x80EBEC0", Offset = "0x80EB2C0", VA = "0x1880EBEC0")]
	[AsyncStateMachine(typeof(MBDHMKBAKDC))]
	private Task<MJFIDHLLGBC> IALMHFPKNGA(string EFBGJFMCDKM, int ALJILABKHFO, PLFCMNGIAGA ECMHMDMOHLI, long MIFADOBCMAC, long OFAOCKBMEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x80EC040", Offset = "0x80EB440", VA = "0x1880EC040")]
	[AsyncStateMachine(typeof(BLODLCGLJEA))]
	public Task<EPOGGLOBAKG> INLCLMJPADM(int ALJILABKHFO, IJHECIBDPGO? FBOPDOAKGNF, PLFCMNGIAGA ECMHMDMOHLI, long MIFADOBCMAC, long OFAOCKBMEGP, DCMMCMGKNNK PHPGFAPLADG, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public abstract class CJPEGCLNHBM<T> where T : CJPEGCLNHBM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079D")]
	internal readonly HENFMPPFGFG HANEBLJAFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079E")]
	private int? LOLGHOBDHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079F")]
	protected readonly Guid FDCJMIFHPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007A0")]
	protected readonly OGNLJOEPPKN BONBPEOCPCL;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected T GMCDKEOPHIL
	{
		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x63F8210", Offset = "0x63F7610", VA = "0x1863F8210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x63F8270", Offset = "0x63F7670", VA = "0x1863F8270")]
	internal CJPEGCLNHBM(HENFMPPFGFG OCPJDDFOEKE, OGNLJOEPPKN FHHMBNMHEHD, [Optional] Guid? FDFDCKJIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x63F7EC0", Offset = "0x63F72C0", VA = "0x1863F7EC0")]
	private EPOGGLOBAKG ELBCNGCIOMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "4")]
	protected virtual void PKHIHBGNKDK(EPOGGLOBAKG DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x63F8170", Offset = "0x63F7570", VA = "0x1863F8170")]
	public T IPICJBGHNPE(DNIGIBHMBIB GGMAHLNBIDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x63F7FA0", Offset = "0x63F73A0", VA = "0x1863F7FA0")]
	public T EPHPJJCIMJJ(int OKGNFGGIHLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x63F8040", Offset = "0x63F7440", VA = "0x1863F8040", Slot = "5")]
	public virtual Task<OGJPCDKPGHL> IGGEPNIJKHC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public class NILLKCEJPKG : CJPEGCLNHBM<NILLKCEJPKG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007A1")]
	private NAMDFBDBPAO DMDJHNIAOJN;

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x80F08B0", Offset = "0x80EFCB0", VA = "0x1880F08B0")]
	internal NILLKCEJPKG(HENFMPPFGFG OCPJDDFOEKE, OGNLJOEPPKN FHHMBNMHEHD, [Optional] Guid? FDFDCKJIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x73DE930", Offset = "0x73DDD30", VA = "0x1873DE930")]
	public NILLKCEJPKG LHGENFAMPIP(NAMDFBDBPAO DMDJHNIAOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x80F07E0", Offset = "0x80EFBE0", VA = "0x1880F07E0", Slot = "4")]
	protected override void PKHIHBGNKDK(EPOGGLOBAKG DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
public class IJCJEHDBGCB : CJPEGCLNHBM<IJCJEHDBGCB>
{
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	internal enum HKPKMIDKNEB
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
	private struct PDIBKBEJPAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public AsyncTaskMethodBuilder<OGJPCDKPGHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public IJCJEHDBGCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		private TaskAwaiter<OGJPCDKPGHL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x80F12E0", Offset = "0x80F06E0", VA = "0x1880F12E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x80F1690", Offset = "0x80F0A90", VA = "0x1880F1690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007A2")]
	private HKPKMIDKNEB BFEGOLPGOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007A3")]
	private string KFMJCPIFOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007A4")]
	private IJHECIBDPGO DMDJHNIAOJN;

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x80ECD60", Offset = "0x80EC160", VA = "0x1880ECD60")]
	internal IJCJEHDBGCB(HENFMPPFGFG OCPJDDFOEKE, OGNLJOEPPKN FHHMBNMHEHD, [Optional] Guid? FDFDCKJIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x80ECA20", Offset = "0x80EBE20", VA = "0x1880ECA20")]
	public IJCJEHDBGCB CMCBPGJKPNC(string ONJHPHOODPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x80ECBD0", Offset = "0x80EBFD0", VA = "0x1880ECBD0")]
	public IJCJEHDBGCB OAEECGLPLKL(bool AJAHJLHNKJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x80ECBB0", Offset = "0x80EBFB0", VA = "0x1880ECBB0")]
	public IJCJEHDBGCB JJGFGJMDAHL(bool PCKJNEHNNLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x80ECA90", Offset = "0x80EBE90", VA = "0x1880ECA90")]
	public IJCJEHDBGCB GCGNJLJJICF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x80ECBF0", Offset = "0x80EBFF0", VA = "0x1880ECBF0", Slot = "4")]
	protected override void PKHIHBGNKDK(EPOGGLOBAKG DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x80ECAC0", Offset = "0x80EBEC0", VA = "0x1880ECAC0", Slot = "5")]
	[AsyncStateMachine(typeof(PDIBKBEJPAC))]
	public override Task<OGJPCDKPGHL> IGGEPNIJKHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x80ECA50", Offset = "0x80EBE50", VA = "0x1880ECA50")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<OGJPCDKPGHL> FMKFANKEEPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal static class COCCCGMHJAK
{
	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x80E5FC0", Offset = "0x80E53C0", VA = "0x1880E5FC0")]
	public static void GBCKNBAHNKN(this OLGIGMIMIFN OKDJBKODHNO, ELMNGLJGGCK PJHPPMJLCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x80E6110", Offset = "0x80E5510", VA = "0x1880E6110")]
	public static void MAAMEOOGHIP(this ELMNGLJGGCK HHOKLMFBNEK, [Optional] string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public static class IKPPOFIHFCD
{
	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x80ED1C0", Offset = "0x80EC5C0", VA = "0x1880ED1C0")]
	public static KKCEGILFGJB HGKDLNNDPCF(this NIEMIMHBOGJ PALJLCLNIHE)
	{
		return default(KKCEGILFGJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x80ED260", Offset = "0x80EC660", VA = "0x1880ED260")]
	public static NIEMIMHBOGJ PMKAIBADFBK(this KKCEGILFGJB IFIFEABECPD)
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
			public JNDBDBIFPHO ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			public JNDBDBIFPHO HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		private static JNDBDBIFPHO[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007B0")]
		private Dictionary<JNDBDBIFPHO, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x80F3C80", Offset = "0x80F3080", VA = "0x1880F3C80")]
		public bool NKBMCGJPMLE(JNDBDBIFPHO GCFDJFLLMIH, [Out] ResultConfig HNFCGGMPMHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x80F3B40", Offset = "0x80F2F40", VA = "0x1880F3B40")]
		public ResultConfig GNFPFEMAKPF(JNDBDBIFPHO JKODLOFLBMK, [Optional] HashSet<JNDBDBIFPHO> IANHIMJDGBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x80F42A0", Offset = "0x80F36A0", VA = "0x1880F42A0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x80F3CF0", Offset = "0x80F30F0", VA = "0x1880F3CF0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xB034E0", Offset = "0xB028E0", VA = "0x180B034E0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
public class LKCGMKJMEPF : FAOIIFKBBED
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[CompilerGenerated]
	private struct IJELGPFPNJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		public LKCGMKJMEPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public APGKENHKANG<string>.EEEKGBDKLHP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x80ECED0", Offset = "0x80EC2D0", VA = "0x1880ECED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x80ED160", Offset = "0x80EC560", VA = "0x1880ED160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[CompilerGenerated]
	private struct FIHCAGLKJJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		public APGKENHKANG<string>.EEEKGBDKLHP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		public FAOIIFKBBED preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		private APGKENHKANG<string>.EEEKGBDKLHP <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x80E8040", Offset = "0x80E7440", VA = "0x1880E8040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x80E84E0", Offset = "0x80E78E0", VA = "0x1880E84E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007BC")]
	private readonly PCGFALIICAO DEJGPOAAAGI;

	[Cpp2IlInjected.Token(Token = "0x40007BD")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public string AEMAACCBEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x80EF800", Offset = "0x80EEC00", VA = "0x1880EF800", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x80EFA60", Offset = "0x80EEE60", VA = "0x1880EFA60")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	internal static void OPNOJEPKKPP(DHLGDCALOEP EOJAEMANAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	[RecRoom.NoEngine.Common.Preserve]
	public LKCGMKJMEPF([CMKKAFOAFJE(null)] PCGFALIICAO DEJGPOAAAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x80EF830", Offset = "0x80EEC30", VA = "0x1880EF830", Slot = "5")]
	[AsyncStateMachine(typeof(IJELGPFPNJA))]
	public Task AMNMBKBGPIL(APGKENHKANG<string>.EEEKGBDKLHP GHLKOGBLJCP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x80EF940", Offset = "0x80EED40", VA = "0x1880EF940")]
	[AsyncStateMachine(typeof(FIHCAGLKJJB))]
	private Task HNEJBHNPFEF(FAOIIFKBBED HKHKDBPNEED, APGKENHKANG<string>.EEEKGBDKLHP GHLKOGBLJCP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
public interface PCGFALIICAO : FAOIIFKBBED
{
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
public interface FAOIIFKBBED
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	string AEMAACCBEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AMNMBKBGPIL(APGKENHKANG<string>.EEEKGBDKLHP GHLKOGBLJCP, CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
public static class AINGOBDEJJH
{
	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x80E33F0", Offset = "0x80E27F0", VA = "0x1880E33F0")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	internal static void BBLAOBGDHMG(DHLGDCALOEP EOJAEMANAOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
public interface CKKDNBIBBCP : IEquatable<CKKDNBIBBCP>
{
	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	DateTime BJLNCFEJNHA
	{
		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPLHDDCDICF();

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GEGGBOPFAEM(long MIFADOBCMAC, long JCNNPHFBOMP, [Out] PLFCMNGIAGA ECMHMDMOHLI);
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
internal class JIMCGDCBCOD : JJEFOPFFIIN
{
	[Cpp2IlInjected.Token(Token = "0x20001BE")]
	[CompilerGenerated]
	private sealed class JOKMPDFGEBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		public JFCACKFPDGD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public JOKMPDFGEBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x80EF310", Offset = "0x80EE710", VA = "0x1880EF310")]
		internal object KAIJFHHNHNH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007CB")]
	private readonly GBMHKFGAAKM EGGLDPGDCFD;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<CKKDNBIBBCP> JNBEEIPBIFD
	{
		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x80EE390", Offset = "0x80ED790", VA = "0x1880EE390", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x80EE740", Offset = "0x80EDB40", VA = "0x1880EE740", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	[UnityEngine.Scripting.Preserve]
	public JIMCGDCBCOD([CMKKAFOAFJE(null)] GBMHKFGAAKM EGGLDPGDCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x80EE440", Offset = "0x80ED840", VA = "0x1880EE440", Slot = "6")]
	public bool IIHLEFJGIEA(long MIFADOBCMAC, long JCNNPHFBOMP, PLFCMNGIAGA ECMHMDMOHLI, JFCACKFPDGD GIHOEMBHLDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0xD12E30", Offset = "0xD12230", VA = "0x180D12E30")]
	private void FDPPHHPHCED(CKKDNBIBBCP CEDHNEPJPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x80EE9C0", Offset = "0x80EDDC0", VA = "0x1880EE9C0", Slot = "7")]
	public bool NINICLEKIBN(long MIFADOBCMAC, long JCNNPHFBOMP, [Out] CKKDNBIBBCP HGHJCHINOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x80EE910", Offset = "0x80EDD10", VA = "0x1880EE910", Slot = "8")]
	public bool NBHNIPPBFAL(long MIFADOBCMAC, long JCNNPHFBOMP, JFCACKFPDGD GIHOEMBHLDB, [Out] CKKDNBIBBCP HGHJCHINOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x80EDF60", Offset = "0x80ED360", VA = "0x1880EDF60")]
	private void BHEBMOODBDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x80EE7F0", Offset = "0x80EDBF0", VA = "0x1880EE7F0", Slot = "9")]
	public void KNDJCHHOBKJ(long MIFADOBCMAC, long JCNNPHFBOMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
internal abstract class DHNGKNLLHCN : GBMHKFGAAKM
{
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	protected enum MCMOEPGLMEN : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[CompilerGenerated]
	private sealed class CBDHBCGOMDD : IEnumerable<CKKDNBIBBCP>, IEnumerable, IEnumerator<CKKDNBIBBCP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private CKKDNBIBBCP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		public DHNGKNLLHCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		private JFCACKFPDGD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		public JFCACKFPDGD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		private CKKDNBIBBCP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xDEB050", Offset = "0xDEA450", VA = "0x180DEB050")]
		[DebuggerHidden]
		public CBDHBCGOMDD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x80E4B00", Offset = "0x80E3F00", VA = "0x1880E4B00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x80E4DE0", Offset = "0x80E41E0", VA = "0x1880E4DE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x80E4D30", Offset = "0x80E4130", VA = "0x1880E4D30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CKKDNBIBBCP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x80E4D30", Offset = "0x80E4130", VA = "0x1880E4D30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[CompilerGenerated]
	private sealed class JFAODIFAPDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		public JFCACKFPDGD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DE")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public JFAODIFAPDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x80ED7D0", Offset = "0x80ECBD0", VA = "0x1880ED7D0")]
		internal object FFPKHNILFPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C4")]
	[CompilerGenerated]
	private sealed class NBJKEBNOBHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DF")]
		public DHNGKNLLHCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E0")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public NBJKEBNOBHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x80F0760", Offset = "0x80EFB60", VA = "0x1880F0760")]
		internal void NKIMDDLIINL(NOGKHBFIKBD.GGJNLOGIEPC ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007D1")]
	private readonly object CJNELGHOAMP;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	protected string DIIEIDHPMOK
	{
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x80E6A90", Offset = "0x80E5E90", VA = "0x1880E6A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public abstract JHEPPKFKLJA JBACIEDJFCN
	{
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x80E70E0", Offset = "0x80E64E0", VA = "0x1880E70E0")]
	protected DHNGKNLLHCN([CanBeNull] string HPFDDMPIFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x80E6E60", Offset = "0x80E6260", VA = "0x1880E6E60", Slot = "5")]
	public bool JHHKOFPBOED(long MIFADOBCMAC, long JCNNPHFBOMP, JFCACKFPDGD GIHOEMBHLDB, [Out] CKKDNBIBBCP CEDHNEPJPLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x80E7050", Offset = "0x80E6450", VA = "0x1880E7050", Slot = "6")]
	[IteratorStateMachine(typeof(CBDHBCGOMDD))]
	public IEnumerable<CKKDNBIBBCP> MIPDJJJKIJE(JFCACKFPDGD GIHOEMBHLDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void NIJAKLMIGCP(Stream OCNLBBDBIHI, long MIFADOBCMAC, long JCNNPHFBOMP, PLFCMNGIAGA ECMHMDMOHLI);

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool AJCGEBOBFPA(Stream NHHOHACOPOO, long MIFADOBCMAC, long JCNNPHFBOMP, CCPPLFONDLN CAIINJFADJO, [Out] PLFCMNGIAGA ECMHMDMOHLI);

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x80E6710", Offset = "0x80E5B10", VA = "0x1880E6710", Slot = "7")]
	public CKKDNBIBBCP FLAAOIDEDHM(long MIFADOBCMAC, long JCNNPHFBOMP, PLFCMNGIAGA ECMHMDMOHLI, JFCACKFPDGD GIHOEMBHLDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo EOOPOFGFDJB(long MIFADOBCMAC, long JCNNPHFBOMP, JFCACKFPDGD GIHOEMBHLDB, MCMOEPGLMEN AGBOFEFHDBD);

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo ECMEPHNGFPK(JFCACKFPDGD GIHOEMBHLDB, MCMOEPGLMEN AGBOFEFHDBD);

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x80E66A0", Offset = "0x80E5AA0", VA = "0x1880E66A0")]
	protected void AJPCNODBNMF(NOGKHBFIKBD.GGJNLOGIEPC NJCPOEBCCFB, string GJKLHCCFCHI, FileInfo OMBFEJGGAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x80E6AA0", Offset = "0x80E5EA0", VA = "0x1880E6AA0")]
	internal bool HOCEEMMCNDC(FileInfo AKLEFFEABNP, long MIFADOBCMAC, long JCNNPHFBOMP, [Out] PLFCMNGIAGA ECMHMDMOHLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	private void MFPEPEPJABF(Exception OBHLNPEHLEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
internal class GCLNHIHFMEF : DHNGKNLLHCN
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public override JHEPPKFKLJA JBACIEDJFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x1C9C260", Offset = "0x1C9B660", VA = "0x181C9C260", Slot = "8")]
		get
		{
			return default(JHEPPKFKLJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x80E9150", Offset = "0x80E8550", VA = "0x1880E9150")]
	public GCLNHIHFMEF([Optional] string HPFDDMPIFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x80E8E20", Offset = "0x80E8220", VA = "0x1880E8E20")]
	private void KFBKCLFFBJF(JFCACKFPDGD GIHOEMBHLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x80E8EA0", Offset = "0x80E82A0", VA = "0x1880E8EA0", Slot = "9")]
	internal override void NIJAKLMIGCP(Stream OCNLBBDBIHI, long MIFADOBCMAC, long JCNNPHFBOMP, PLFCMNGIAGA ECMHMDMOHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x80E8540", Offset = "0x80E7940", VA = "0x1880E8540", Slot = "10")]
	internal override bool AJCGEBOBFPA(Stream NHHOHACOPOO, long MIFADOBCMAC, long JCNNPHFBOMP, CCPPLFONDLN CAIINJFADJO, [Out] PLFCMNGIAGA ECMHMDMOHLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x80E8D30", Offset = "0x80E8130", VA = "0x1880E8D30", Slot = "11")]
	protected override FileInfo EOOPOFGFDJB(long MIFADOBCMAC, long JCNNPHFBOMP, JFCACKFPDGD GIHOEMBHLDB, MCMOEPGLMEN AGBOFEFHDBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x80E8C30", Offset = "0x80E8030", VA = "0x1880E8C30", Slot = "12")]
	protected override DirectoryInfo ECMEPHNGFPK(JFCACKFPDGD GIHOEMBHLDB, MCMOEPGLMEN AGBOFEFHDBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
internal sealed class GIILEBAMJJA : DHNGKNLLHCN
{
	[Cpp2IlInjected.Token(Token = "0x40007E1")]
	private static readonly byte[] DJBLFBEBKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007E2")]
	private readonly byte[] CBBOOBPJNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007E3")]
	private readonly byte[] JEOMEMKIDID;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public override JHEPPKFKLJA JBACIEDJFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x6C12140", Offset = "0x6C11540", VA = "0x186C12140", Slot = "8")]
		get
		{
			return default(JHEPPKFKLJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x80EA3A0", Offset = "0x80E97A0", VA = "0x1880EA3A0")]
	public GIILEBAMJJA([Optional] string HPFDDMPIFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x80E9F00", Offset = "0x80E9300", VA = "0x1880E9F00", Slot = "9")]
	internal override void NIJAKLMIGCP(Stream OCNLBBDBIHI, long MIFADOBCMAC, long JCNNPHFBOMP, PLFCMNGIAGA ECMHMDMOHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x80E9190", Offset = "0x80E8590", VA = "0x1880E9190", Slot = "10")]
	internal override bool AJCGEBOBFPA(Stream NHHOHACOPOO, long MIFADOBCMAC, long JCNNPHFBOMP, CCPPLFONDLN CAIINJFADJO, [Out] PLFCMNGIAGA ECMHMDMOHLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x80E9E40", Offset = "0x80E9240", VA = "0x1880E9E40")]
	private void FGJGHIGHKBH(byte[] DHHEGLJJIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x80E9D10", Offset = "0x80E9110", VA = "0x1880E9D10", Slot = "11")]
	protected override FileInfo EOOPOFGFDJB(long MIFADOBCMAC, long JCNNPHFBOMP, JFCACKFPDGD GIHOEMBHLDB, MCMOEPGLMEN AGBOFEFHDBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x80E9C00", Offset = "0x80E9000", VA = "0x1880E9C00", Slot = "12")]
	protected override DirectoryInfo ECMEPHNGFPK(JFCACKFPDGD GIHOEMBHLDB, MCMOEPGLMEN AGBOFEFHDBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
public enum JHEPPKFKLJA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40007E7")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40007E8")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40007E9")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
internal class BOOPABDMMJD : GBMHKFGAAKM
{
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	[CompilerGenerated]
	private sealed class JJOPBHHPDKP : IEnumerable<CKKDNBIBBCP>, IEnumerable, IEnumerator<CKKDNBIBBCP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private CKKDNBIBBCP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		public BOOPABDMMJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		private JFCACKFPDGD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		public JFCACKFPDGD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		private JHEPPKFKLJA[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		private IEnumerator<CKKDNBIBBCP> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		private CKKDNBIBBCP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xDEB050", Offset = "0xDEA450", VA = "0x180DEB050")]
		[DebuggerHidden]
		public JJOPBHHPDKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x80EEF60", Offset = "0x80EE360", VA = "0x1880EEF60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x80EEB30", Offset = "0x80EDF30", VA = "0x1880EEB30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x80EEE10", Offset = "0x80EE210", VA = "0x1880EEE10")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x80EEF10", Offset = "0x80EE310", VA = "0x1880EEF10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x80EEE60", Offset = "0x80EE260", VA = "0x1880EEE60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CKKDNBIBBCP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x80EEE60", Offset = "0x80EE260", VA = "0x1880EEE60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007EA")]
	private readonly JHEPPKFKLJA[] CLBJGGFGIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007EB")]
	private readonly Dictionary<JHEPPKFKLJA, GBMHKFGAAKM> DEIFFNCEEHI;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public JHEPPKFKLJA JBACIEDJFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x80E4710", Offset = "0x80E3B10", VA = "0x1880E4710", Slot = "4")]
		get
		{
			return default(JHEPPKFKLJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x80E47D0", Offset = "0x80E3BD0", VA = "0x1880E47D0")]
	[UnityEngine.Scripting.Preserve]
	public BOOPABDMMJD(params GBMHKFGAAKM[] NBHMBPHMBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x80E45C0", Offset = "0x80E39C0", VA = "0x1880E45C0", Slot = "5")]
	public bool JHHKOFPBOED(long MIFADOBCMAC, long JCNNPHFBOMP, JFCACKFPDGD GIHOEMBHLDB, [Out] CKKDNBIBBCP CEDHNEPJPLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x80E42A0", Offset = "0x80E36A0", VA = "0x1880E42A0")]
	private void AFELGFJEBCC(int HAKFCPHADCF, long MIFADOBCMAC, long JCNNPHFBOMP, JFCACKFPDGD GIHOEMBHLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x80E4740", Offset = "0x80E3B40", VA = "0x1880E4740", Slot = "6")]
	[IteratorStateMachine(typeof(JJOPBHHPDKP))]
	public IEnumerable<CKKDNBIBBCP> MIPDJJJKIJE(JFCACKFPDGD GIHOEMBHLDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x80E44D0", Offset = "0x80E38D0", VA = "0x1880E44D0", Slot = "7")]
	public CKKDNBIBBCP FLAAOIDEDHM(long MIFADOBCMAC, long JCNNPHFBOMP, PLFCMNGIAGA ECMHMDMOHLI, JFCACKFPDGD GIHOEMBHLDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
internal static class JNCMPLKIDDD
{
	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x80EEFF0", Offset = "0x80EE3F0", VA = "0x1880EEFF0")]
	internal static byte[] BILNGEOLLLO(byte[] DHHEGLJJIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x80EF0B0", Offset = "0x80EE4B0", VA = "0x1880EF0B0")]
	public static void GENNJMMDKBC(Stream DHNIJNCIKDC, byte[] PFPGIOEIJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x80EF130", Offset = "0x80EE530", VA = "0x1880EF130")]
	public static bool JNELINDMJBG(Stream DHNIJNCIKDC, long DJIOEHNGCPA, CCPPLFONDLN GBIKANHNGLB, [Out] byte[] JBLJGMBBIIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
internal sealed class PLAMICGLKAL : CKKDNBIBBCP, IEquatable<CKKDNBIBBCP>, IEquatable<PLAMICGLKAL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F9")]
	private readonly DHNGKNLLHCN BKOIFKEAJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007FA")]
	public readonly FileInfo MHEHEPMGBLG;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public JHEPPKFKLJA JBACIEDJFCN
	{
		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x79DD6E0", Offset = "0x79DCAE0", VA = "0x1879DD6E0", Slot = "9")]
		get
		{
			return default(JHEPPKFKLJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public DateTime BJLNCFEJNHA
	{
		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x80F1700", Offset = "0x80F0B00", VA = "0x1880F1700", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x80F1BF0", Offset = "0x80F0FF0", VA = "0x1880F1BF0")]
	public PLAMICGLKAL(DHNGKNLLHCN LCKIEHPLCKO, FileInfo AKLEFFEABNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x80F1B40", Offset = "0x80F0F40", VA = "0x1880F1B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x80F1A80", Offset = "0x80F0E80", VA = "0x1880F1A80", Slot = "5")]
	public void LPLHDDCDICF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x80F19B0", Offset = "0x80F0DB0", VA = "0x1880F19B0", Slot = "6")]
	public bool GEGGBOPFAEM(long MIFADOBCMAC, long JCNNPHFBOMP, [Out] PLFCMNGIAGA ECMHMDMOHLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x80F1940", Offset = "0x80F0D40", VA = "0x1880F1940", Slot = "7")]
	public bool Equals(CKKDNBIBBCP KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x80F1790", Offset = "0x80F0B90", VA = "0x1880F1790", Slot = "8")]
	public bool Equals(PLAMICGLKAL KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x80F1850", Offset = "0x80F0C50", VA = "0x1880F1850", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x80F19F0", Offset = "0x80F0DF0", VA = "0x1880F19F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
public delegate void CCPPLFONDLN(NOGKHBFIKBD.GGJNLOGIEPC FCJAMLOPNNN, string DAMFJFKKFBI);
[Cpp2IlInjected.Token(Token = "0x20001CF")]
internal interface GBMHKFGAAKM
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	JHEPPKFKLJA JBACIEDJFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JHHKOFPBOED(long MIFADOBCMAC, long JCNNPHFBOMP, JFCACKFPDGD GIHOEMBHLDB, [Out] CKKDNBIBBCP CEDHNEPJPLG);

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<CKKDNBIBBCP> MIPDJJJKIJE(JFCACKFPDGD GIHOEMBHLDB);

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CKKDNBIBBCP FLAAOIDEDHM(long MIFADOBCMAC, long JCNNPHFBOMP, PLFCMNGIAGA ECMHMDMOHLI, JFCACKFPDGD GIHOEMBHLDB);
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
