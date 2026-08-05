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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x803F800", Offset = "0x803EC00", VA = "0x18803F800")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x803AFB0", Offset = "0x803A3B0", VA = "0x18803AFB0", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x8042AC0", Offset = "0x8041EC0", VA = "0x188042AC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x254E750", Offset = "0x254DB50", VA = "0x18254E750")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ELPHMIPMMBG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x802C7C0", Offset = "0x802BBC0", VA = "0x18802C7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8032C10", Offset = "0x8032010", VA = "0x188032C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8032E50", Offset = "0x8032250", VA = "0x188032E50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x803B2E0", Offset = "0x803A6E0", VA = "0x18803B2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x803B4F0", Offset = "0x803A8F0", VA = "0x18803B4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	[UnityEngine.Scripting.Preserve]
	public CLIKLOFCPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x80292E0", Offset = "0x80286E0", VA = "0x1880292E0", Slot = "4")]
	[AsyncStateMachine(typeof(JKOLKMGLEBL))]
	public Task<IReadOnlyList<DOIHDMEMACP>> ILGKCPDGOMI(long MIFADOBCMAC, long OFAOCKBMEGP, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x80291D0", Offset = "0x80285D0", VA = "0x1880291D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8032610", Offset = "0x8031A10", VA = "0x188032610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8032BA0", Offset = "0x8031FA0", VA = "0x188032BA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9984C0", Offset = "0x9978C0", VA = "0x1809984C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8029F90", Offset = "0x8029390", VA = "0x188029F90", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OOJNNNOJHED? OOCJICNBMGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6938870", Offset = "0x6937C70", VA = "0x186938870", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public BIHJBMEMEFM? PFJPBHMPNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2894790", Offset = "0x2893B90", VA = "0x182894790", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ICKIEKLPHFL NCKFBDDEPAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB1B310", Offset = "0xB1A710", VA = "0x180B1B310", Slot = "10")]
			get
			{
				return default(ICKIEKLPHFL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x802A030", Offset = "0x8029430", VA = "0x18802A030", Slot = "9")]
		[AsyncStateMachine(typeof(JCGFDGLDJKO))]
		public Task<OGJPCDKPGHL> LLEMIBHBCFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x802A170", Offset = "0x8029570", VA = "0x18802A170")]
		public DIILAMFBMEO(int PNMMEHCMDHJ, AJJLICNNELL GBNJOAGINEI, DOIHDMEMACP IFHCDCGLJIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8029F00", Offset = "0x8029300", VA = "0x188029F00", Slot = "11")]
		public bool Equals(DAJAGKGMOOD KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8029E60", Offset = "0x8029260", VA = "0x188029E60", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x802A130", Offset = "0x8029530", VA = "0x18802A130")]
		private bool MAEADOOLHFI(DIILAMFBMEO KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8029FB0", Offset = "0x80293B0", VA = "0x188029FB0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x803C600", Offset = "0x803BA00", VA = "0x18803C600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x803C850", Offset = "0x803BC50", VA = "0x18803C850", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x803F7C0", Offset = "0x803EBC0", VA = "0x18803F7C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AJJLICNNELL BDMAPALGGCL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x803F6E0", Offset = "0x803EAE0", VA = "0x18803F6E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime DCJBDBIDEIB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x803F4C0", Offset = "0x803E8C0", VA = "0x18803F4C0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public OOJNNNOJHED? OOCJICNBMGM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x803F770", Offset = "0x803EB70", VA = "0x18803F770", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public BIHJBMEMEFM? PFJPBHMPNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x803F470", Offset = "0x803E870", VA = "0x18803F470", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ICKIEKLPHFL NCKFBDDEPAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xB1A370", Offset = "0xB19770", VA = "0x180B1A370", Slot = "10")]
			get
			{
				return default(ICKIEKLPHFL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1D35CA0", Offset = "0x1D350A0", VA = "0x181D35CA0")]
		public NPFPHLIDBEA(CKKDNBIBBCP CEDHNEPJPLG, OOJNNNOJHED MJHGFJCMHBP, BIHJBMEMEFM ECBJHACCLFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x803F590", Offset = "0x803E990", VA = "0x18803F590", Slot = "9")]
		[AsyncStateMachine(typeof(MKLGFOKPMIK))]
		public Task<OGJPCDKPGHL> LLEMIBHBCFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x803F3D0", Offset = "0x803E7D0", VA = "0x18803F3D0", Slot = "11")]
		public bool Equals(DAJAGKGMOOD KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x803F320", Offset = "0x803E720", VA = "0x18803F320", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x803F680", Offset = "0x803EA80", VA = "0x18803F680")]
		private bool MAEADOOLHFI(NPFPHLIDBEA KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x803F510", Offset = "0x803E910", VA = "0x18803F510", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x803ECD0", Offset = "0x803E0D0", VA = "0x18803ECD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x803EF30", Offset = "0x803E330", VA = "0x18803EF30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x803C5E0", Offset = "0x803B9E0", VA = "0x18803C5E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime DCJBDBIDEIB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public OOJNNNOJHED? OOCJICNBMGM
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x803C590", Offset = "0x803B990", VA = "0x18803C590", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public BIHJBMEMEFM? PFJPBHMPNNA
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x803C300", Offset = "0x803B700", VA = "0x18803C300", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ICKIEKLPHFL NCKFBDDEPAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "10")]
			get
			{
				return default(ICKIEKLPHFL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1D35CA0", Offset = "0x1D350A0", VA = "0x181D35CA0")]
		public MGEDBHJDBLL(AJJLICNNELL GBNJOAGINEI, OOJNNNOJHED MJHGFJCMHBP, BIHJBMEMEFM ECBJHACCLFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x803C3E0", Offset = "0x803B7E0", VA = "0x18803C3E0", Slot = "9")]
		[AsyncStateMachine(typeof(NEGHJNIGMDA))]
		public Task<OGJPCDKPGHL> LLEMIBHBCFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x803C290", Offset = "0x803B690", VA = "0x18803C290", Slot = "11")]
		public bool Equals(DAJAGKGMOOD KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x803C210", Offset = "0x803B610", VA = "0x18803C210", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x803C350", Offset = "0x803B750", VA = "0x18803C350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x803C4B0", Offset = "0x803B8B0", VA = "0x18803C4B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x803FAF0", Offset = "0x803EEF0", VA = "0x18803FAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8040950", Offset = "0x803FD50", VA = "0x188040950", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x80233E0", Offset = "0x80227E0", VA = "0x1880233E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8023DF0", Offset = "0x80231F0", VA = "0x188023DF0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x802BCC0", Offset = "0x802B0C0", VA = "0x18802BCC0")]
	[UnityEngine.Scripting.Preserve]
	public EHOOGGNDLCC([CMKKAFOAFJE(null)] ECFFCCGLHEI DHPIAKHBJNG, [CMKKAFOAFJE(null)] JJEFOPFFIIN HAFGNNKMAEH, [CMKKAFOAFJE(null)] AJBBEIPPJKL JOHEHDNDKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x802BB70", Offset = "0x802AF70", VA = "0x18802BB70")]
	[AsyncStateMachine(typeof(OALHDKLBKGP))]
	public Task<IList<DAJAGKGMOOD>> PPJOGMEDBFN(long MIFADOBCMAC, long JCNNPHFBOMP, bool EEFLOEGEJLK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x802B8C0", Offset = "0x802ACC0", VA = "0x18802B8C0")]
	private bool DAKEIPICAIA(DateTime? HGHOFAFIMHO, long MIFADOBCMAC, long JCNNPHFBOMP, [Out] CKKDNBIBBCP HGHJCHINOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x802BA60", Offset = "0x802AE60", VA = "0x18802BA60")]
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
	[Cpp2IlInjected.Address(RVA = "0x8027F40", Offset = "0x8027340", VA = "0x188027F40")]
	public BMAMFBAMLOB(long LNPKBFNBKIA, long OFAOCKBMEGP, MIMKIGDBBLO HAFNBBNOLPO, [CanBeNull] Exception KOOEEMDHOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8027EF0", Offset = "0x80272F0", VA = "0x188027EF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8028490", Offset = "0x8027890", VA = "0x188028490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
	public PIOLBCBDLJN(ELMNGLJGGCK HHOKLMFBNEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8041720", Offset = "0x8040B20", VA = "0x188041720")]
	public PIOLBCBDLJN IMHCCOLCOBM(string DJBLFBEBKGO, string FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8041690", Offset = "0x8040A90", VA = "0x188041690")]
	public bool DGBKCBDCJBM([Out] IEnumerable<KeyValuePair<string, string>> BAIFMFOEFGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F63B50", Offset = "0x6F62F50", VA = "0x186F63B50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xBA0FD0", Offset = "0xBA03D0", VA = "0x180BA0FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8027FE0", Offset = "0x80273E0", VA = "0x188027FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8028260", Offset = "0x8027660", VA = "0x188028260", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x802CA20", Offset = "0x802BE20", VA = "0x18802CA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x802CC50", Offset = "0x802C050", VA = "0x18802CC50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xDE6750", Offset = "0xDE5B50", VA = "0x180DE6750")]
		[DebuggerHidden]
		public IIONPKNMJHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x802F930", Offset = "0x802ED30", VA = "0x18802F930", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x802FD90", Offset = "0x802F190", VA = "0x18802FD90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x802FCE0", Offset = "0x802F0E0", VA = "0x18802FCE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KBHPKIEBIBJ> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x802FCE0", Offset = "0x802F0E0", VA = "0x18802FCE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x993A70", Offset = "0x992E70", VA = "0x180993A70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x993AD0", Offset = "0x992ED0", VA = "0x180993AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public AKDJHEMIBMN JICIDMLEIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x993A80", Offset = "0x992E80", VA = "0x180993A80", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x993A90", Offset = "0x992E90", VA = "0x180993A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public BEHHGOBGNKL LDPIMCPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x993A50", Offset = "0x992E50", VA = "0x180993A50", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x993AA0", Offset = "0x992EA0", VA = "0x180993AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public BGLHDLEKEGE MDDCDEOBBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x993AB0", Offset = "0x992EB0", VA = "0x180993AB0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x993A60", Offset = "0x992E60", VA = "0x180993A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public OECLOADLJFM HAJCCCEFJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x993A40", Offset = "0x992E40", VA = "0x180993A40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x993AC0", Offset = "0x992EC0", VA = "0x180993AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public FKLBCLNGIJH PFPEHNKBNGF
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9984B0", Offset = "0x9978B0", VA = "0x1809984B0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x998570", Offset = "0x997970", VA = "0x180998570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public GHPEFBEBANI FEHJFLINGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x998560", Offset = "0x997960", VA = "0x180998560", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x998580", Offset = "0x997980", VA = "0x180998580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public EGBBHHGAGKN BGHMOPGNAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x998640", Offset = "0x997A40", VA = "0x180998640", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9985E0", Offset = "0x9979E0", VA = "0x1809985E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public PMMACJEODNL LHOLJMJIMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xB1B2F0", Offset = "0xB1A6F0", VA = "0x180B1B2F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x11EBD10", Offset = "0x11EB110", VA = "0x1811EBD10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public FFFKBLCKPNE BMFDHBGAKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9984E0", Offset = "0x9978E0", VA = "0x1809984E0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9985B0", Offset = "0x9979B0", VA = "0x1809985B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public HNHLGDCHOMD HJJMFCOGKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xC2F980", Offset = "0xC2ED80", VA = "0x180C2F980", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xDA69D0", Offset = "0xDA5DD0", VA = "0x180DA69D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public JKCJLPBKNAB OJNDIODJGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x99CBA0", Offset = "0x99BFA0", VA = "0x18099CBA0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x99CC00", Offset = "0x99C000", VA = "0x18099CC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public LBDHEDHCFOP ICLJJCKICLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xB7E120", Offset = "0xB7D520", VA = "0x180B7E120", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xDAB6E0", Offset = "0xDAAAE0", VA = "0x180DAB6E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public BFEJMCCPNJJ CPJCCOMCLCC
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xC86D50", Offset = "0xC86150", VA = "0x180C86D50", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xC86D60", Offset = "0xC86160", VA = "0x180C86D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IBOGFHOCCBO CMLAOJFPAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xC2F7B0", Offset = "0xC2EBB0", VA = "0x180C2F7B0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1070EC0", Offset = "0x10702C0", VA = "0x181070EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public MAIPAJJCPPG EOJNFMAFNNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xC1A800", Offset = "0xC19C00", VA = "0x180C1A800", Slot = "62")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xCD2600", Offset = "0xCD1A00", VA = "0x180CD2600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public PCJFOBAJPBG DDABFMPOHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA13CE0", Offset = "0xA130E0", VA = "0x180A13CE0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA172F0", Offset = "0xA166F0", VA = "0x180A172F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public GMNBOJDPOMF DDMIKJLMHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x99CBF0", Offset = "0x99BFF0", VA = "0x18099CBF0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x99CC20", Offset = "0x99C020", VA = "0x18099CC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public ODLGNDIIDEN EBKLABGDMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA1AEF0", Offset = "0xA1A2F0", VA = "0x180A1AEF0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAF9370", Offset = "0xAF8770", VA = "0x180AF9370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public DKOGEAIEABM OPOEIFBFABJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA1AA80", Offset = "0xA19E80", VA = "0x180A1AA80", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xB05A00", Offset = "0xB04E00", VA = "0x180B05A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public AKAGACKDLFM KKCINCDFALD
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA13E80", Offset = "0xA13280", VA = "0x180A13E80", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA09CA0", Offset = "0xA090A0", VA = "0x180A09CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public BHDEHADDLMD DIKEMKPABJI
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA05CE0", Offset = "0xA050E0", VA = "0x180A05CE0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA0E8D0", Offset = "0xA0DCD0", VA = "0x180A0E8D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public AEFNHDNPDGB ANLENMMAPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA1B8C0", Offset = "0xA1ACC0", VA = "0x180A1B8C0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xAE3D70", Offset = "0xAE3170", VA = "0x180AE3D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public PIDPHNCIMCF ABNMKADPLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA1B880", Offset = "0xA1AC80", VA = "0x180A1B880", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA0DB30", Offset = "0xA0CF30", VA = "0x180A0DB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public NGHCPIHNGGJ AIFBNBOPKHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA1B8A0", Offset = "0xA1ACA0", VA = "0x180A1B8A0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA05D70", Offset = "0xA05170", VA = "0x180A05D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public GBFKOIDPNBM PCCOKLHDKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA1B890", Offset = "0xA1AC90", VA = "0x180A1B890", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA10C00", Offset = "0xA10000", VA = "0x180A10C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public NFOKCOMKNBM EGIALEKFNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA04D30", Offset = "0xA04130", VA = "0x180A04D30", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA0EEF0", Offset = "0xA0E2F0", VA = "0x180A0EEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public HMNAEIFDIFE GHAFIMOHIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA1A790", Offset = "0xA19B90", VA = "0x180A1A790", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA29010", Offset = "0xA28410", VA = "0x180A29010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public JJEFOPFFIIN OMBFAJMENKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA0FB00", Offset = "0xA0EF00", VA = "0x180A0FB00", Slot = "32")]
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
		[Cpp2IlInjected.Address(RVA = "0xA08DA0", Offset = "0xA081A0", VA = "0x180A08DA0", Slot = "33")]
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
		[Cpp2IlInjected.Address(RVA = "0xA0C680", Offset = "0xA0BA80", VA = "0x180A0C680", Slot = "34")]
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
		[Cpp2IlInjected.Address(RVA = "0xA04FC0", Offset = "0xA043C0", VA = "0x180A04FC0", Slot = "35")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A500", Offset = "0xA19900", VA = "0x180A1A500", Slot = "36")]
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
		[Cpp2IlInjected.Address(RVA = "0xA099A0", Offset = "0xA08DA0", VA = "0x180A099A0", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xE8C1F0", Offset = "0xE8B5F0", VA = "0x180E8C1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool OAOEMMEAHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8031E30", Offset = "0x8031230", VA = "0x188031E30", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool GAMGOEKOLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8031E90", Offset = "0x8031290", VA = "0x188031E90", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool FCMILKBEPNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1ADDD40", Offset = "0x1ADD140", VA = "0x181ADDD40", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken PENGGCNAILL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8031150", Offset = "0x8030550", VA = "0x188031150", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private DHLGDCALOEP CCICKHFHADB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool EFJFANABNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1ADDD40", Offset = "0x1ADD140", VA = "0x181ADDD40", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1AD7FD0", Offset = "0x1AD73D0", VA = "0x181AD7FD0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action GOKFPIBJIOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8031C60", Offset = "0x8031060", VA = "0x188031C60", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x80316F0", Offset = "0x8030AF0", VA = "0x1880316F0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event GCAPAODEIHF LBJOJGHOJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8031170", Offset = "0x8030570", VA = "0x188031170", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8031890", Offset = "0x8030C90", VA = "0x188031890", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event GCAPAODEIHF NPCENFAFPPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8031690", Offset = "0x8030A90", VA = "0x188031690", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8031320", Offset = "0x8030720", VA = "0x188031320", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event GCAPAODEIHF JOGPLMLKGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8031C00", Offset = "0x8031000", VA = "0x188031C00", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8031FE0", Offset = "0x80313E0", VA = "0x188031FE0", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<PPKFOIPGIIE, bool> IDBNIMDKPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8031380", Offset = "0x8030780", VA = "0x188031380", Slot = "48")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x80311D0", Offset = "0x80305D0", VA = "0x1880311D0", Slot = "49")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0xE8C1F0", Offset = "0xE8B5F0", VA = "0x180E8C1F0", Slot = "39")]
	public void EALODHOCNNN(ALODEKIMLIG FGMLHIFKOHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x8032040", Offset = "0x8031440", VA = "0x188032040")]
	[UnityEngine.Scripting.Preserve]
	internal INHFFLDACLK([CMKKAFOAFJE(null)] DHLGDCALOEP NKMJDOBLHGP, [CMKKAFOAFJE(null)] FMKBFEIFICC BOGAODIGBEK, [CMKKAFOAFJE(null)] AKDJHEMIBMN MIPJJEBLOIG, [CMKKAFOAFJE(null)] BEHHGOBGNKL IAPHFNOPBJO, [CMKKAFOAFJE(null)] BGLHDLEKEGE BHOKHBGHNNC, [CMKKAFOAFJE(null)] OECLOADLJFM KCMEOJGNOCC, [CMKKAFOAFJE(null)] FKLBCLNGIJH JGGPEAFECGJ, [CMKKAFOAFJE(null)] EGBBHHGAGKN BDFIBCDOEKG, [CMKKAFOAFJE(null)] PMMACJEODNL AEDDIMEJOEC, [CMKKAFOAFJE(null)] FFFKBLCKPNE LHOCJJFNGFM, [CMKKAFOAFJE(null)] HNHLGDCHOMD JIHGMCPNOEK, [CMKKAFOAFJE(null)] JKCJLPBKNAB MGBCFAFLPMJ, [CMKKAFOAFJE(null)] LBDHEDHCFOP OOLOGEGALNI, [CMKKAFOAFJE(null)] BFEJMCCPNJJ EOGCPILNJHO, [CMKKAFOAFJE(null)] IBOGFHOCCBO NDOOJONJDNA, [CMKKAFOAFJE(null)] MAIPAJJCPPG PEAPKOHNAEO, [CMKKAFOAFJE(null)] PCJFOBAJPBG NIDMAHCNFMM, [CMKKAFOAFJE(null)] GMNBOJDPOMF AIBKIAEAGPH, [CMKKAFOAFJE(null)] ODLGNDIIDEN EGEHFHFCJJL, [CMKKAFOAFJE(null)] DKOGEAIEABM OLIGAJLLAND, [CMKKAFOAFJE(null)] BHDEHADDLMD EGCLPDLBPFJ, [CMKKAFOAFJE(null)] AKAGACKDLFM CDODBONFBPP, [CMKKAFOAFJE(null)] AEFNHDNPDGB EJIFMKNBKDJ, [CMKKAFOAFJE(null)] PIDPHNCIMCF LFDAPAFGGGA, [CMKKAFOAFJE(null)] NGHCPIHNGGJ GGBHNFALOBC, [CMKKAFOAFJE(null)] NFOKCOMKNBM HNFCGGMPMHM, [CMKKAFOAFJE(null)] HMNAEIFDIFE FPEOBPEELJF, [CMKKAFOAFJE(null)] JJEFOPFFIIN APDIEPHHGLF, [CMKKAFOAFJE(null)] OOEHFEBFNNO LBNHFJAFLON, [CMKKAFOAFJE(null)] GLNEFDGIGPM GNLBINGGPAL, [CMKKAFOAFJE(null)] CADBKKNPFMF AHAJFADKBKH, [CMKKAFOAFJE(null)] FAOIIFKBBED HKHKDBPNEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x80317E0", Offset = "0x8030BE0", VA = "0x1880317E0")]
	private void GDCNGOALEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x80313E0", Offset = "0x80307E0", VA = "0x1880313E0", Slot = "61")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8031F10", Offset = "0x8031310", VA = "0x188031F10", Slot = "53")]
	private void NACMLHNCJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x8031750", Offset = "0x8030B50", VA = "0x188031750", Slot = "54")]
	private NILLKCEJPKG FOMPEMLOONN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x80310C0", Offset = "0x80304C0", VA = "0x1880310C0", Slot = "55")]
	private IJCJEHDBGCB AAJHBFKGJFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x80318F0", Offset = "0x8030CF0", VA = "0x1880318F0", Slot = "57")]
	public Task IAJAHPGDGHJ(int ALJILABKHFO, IJHECIBDPGO FBOPDOAKGNF, Func<PLFCMNGIAGA, PLFCMNGIAGA> EGAFBDKFNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8031580", Offset = "0x8030980", VA = "0x188031580")]
	private OGPCJMPMLOG EIEPHPIMAEK(int ALJILABKHFO, IJHECIBDPGO FBOPDOAKGNF, Func<PLFCMNGIAGA, PLFCMNGIAGA> EGAFBDKFNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8031CC0", Offset = "0x80310C0", VA = "0x188031CC0", Slot = "58")]
	[AsyncStateMachine(typeof(CEJNGLHGCNJ))]
	private Task<OGJPCDKPGHL> ILHJKMALLIO(CKKDNBIBBCP HGHJCHINOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x8031230", Offset = "0x8030630", VA = "0x188031230", Slot = "59")]
	[AsyncStateMachine(typeof(FNAJEFFAJFH))]
	private Task CAEONCPIHDA(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x8031F60", Offset = "0x8031360", VA = "0x188031F60")]
	[IteratorStateMachine(typeof(IIONPKNMJHP))]
	private IEnumerable<KBHPKIEBIBJ> NBLBJKMHCKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x8031DD0", Offset = "0x80311D0", VA = "0x188031DD0")]
	[CompilerGenerated]
	private void JFCEKJEGMKD(KBHPKIEBIBJ DMJKAPFLGHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class PKMLOKKNCAP : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x168E7A0", Offset = "0x168DBA0", VA = "0x18168E7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x803EFA0", Offset = "0x803E3A0", VA = "0x18803EFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x803F2B0", Offset = "0x803E6B0", VA = "0x18803F2B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x80282D0", Offset = "0x80276D0", VA = "0x1880282D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x9A3500", Offset = "0x9A2900", VA = "0x1809A3500")]
	public CFILEMNOOBB(HENFMPPFGFG LMJMNPPPAHL, BEHHGOBGNKL IAPHFNOPBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x8028300", Offset = "0x8027700", VA = "0x188028300", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8038F50", Offset = "0x8038350", VA = "0x188038F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x80398B0", Offset = "0x8038CB0", VA = "0x1880398B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8038D50", Offset = "0x8038150", VA = "0x188038D50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x9A3500", Offset = "0x9A2900", VA = "0x1809A3500")]
	public KPMNAIDNJAG(HENFMPPFGFG LMJMNPPPAHL, BEHHGOBGNKL IAPHFNOPBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8038D80", Offset = "0x8038180", VA = "0x188038D80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8029400", Offset = "0x8028800", VA = "0x188029400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8029DF0", Offset = "0x80291F0", VA = "0x188029DF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x803ADB0", Offset = "0x803A1B0", VA = "0x18803ADB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x9A3500", Offset = "0x9A2900", VA = "0x1809A3500")]
	public LOCFPLGMLOJ(HENFMPPFGFG LMJMNPPPAHL, BEHHGOBGNKL IAPHFNOPBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x803ADE0", Offset = "0x803A1E0", VA = "0x18803ADE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public OLFOKBNOHHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8041500", Offset = "0x8040900", VA = "0x188041500")]
		internal object MIAMCBBLEJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8041440", Offset = "0x8040840", VA = "0x188041440")]
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
		[Cpp2IlInjected.Address(RVA = "0x803B560", Offset = "0x803A960", VA = "0x18803B560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x803C1A0", Offset = "0x803B5A0", VA = "0x18803C1A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x802F290", Offset = "0x802E690", VA = "0x18802F290", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x9A3500", Offset = "0x9A2900", VA = "0x1809A3500")]
	public IFCLBDAKMEN(HENFMPPFGFG LMJMNPPPAHL, BEHHGOBGNKL IAPHFNOPBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x802F2C0", Offset = "0x802E6C0", VA = "0x18802F2C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x80220B0", Offset = "0x80214B0", VA = "0x1880220B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x80225D0", Offset = "0x80219D0", VA = "0x1880225D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x803F9B0", Offset = "0x803EDB0", VA = "0x18803F9B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x9A3500", Offset = "0x9A2900", VA = "0x1809A3500")]
	public OAJNKOJFIJA(HENFMPPFGFG LMJMNPPPAHL, BEHHGOBGNKL IAPHFNOPBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x803F880", Offset = "0x803EC80", VA = "0x18803F880")]
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
		[Cpp2IlInjected.Address(RVA = "0x802DFB0", Offset = "0x802D3B0", VA = "0x18802DFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x802E330", Offset = "0x802D730", VA = "0x18802E330", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public IPHKDKECGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8032510", Offset = "0x8031910", VA = "0x188032510")]
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
	[Cpp2IlInjected.Address(RVA = "0x803A580", Offset = "0x8039980", VA = "0x18803A580")]
	[AsyncStateMachine(typeof(GONHNMBCOIN))]
	internal static Task<LDINNJCHBAF.EGBDLOOLBIJ> PIFIODOEOFP(BEHHGOBGNKL IAPHFNOPBJO, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x803A400", Offset = "0x8039800", VA = "0x18803A400")]
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
		[Cpp2IlInjected.Address(RVA = "0x802B880", Offset = "0x802AC80", VA = "0x18802B880")]
		public static EGBDLOOLBIJ ABONCMIDHHC()
		{
			return default(EGBDLOOLBIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x802B890", Offset = "0x802AC90", VA = "0x18802B890")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public GCCIAMCNCKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x802CCB0", Offset = "0x802C0B0", VA = "0x18802CCB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8040CF0", Offset = "0x80400F0", VA = "0x188040CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8041280", Offset = "0x8040680", VA = "0x188041280", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x802EF10", Offset = "0x802E310", VA = "0x18802EF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x802F230", Offset = "0x802E630", VA = "0x18802F230", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x802B3B0", Offset = "0x802A7B0", VA = "0x18802B3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private BEHHGOBGNKL LDPIMCPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x802B780", Offset = "0x802AB80", VA = "0x18802B780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private CDCAHPMDKLI JLEJGCAJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x802B600", Offset = "0x802AA00", VA = "0x18802B600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private FFFKBLCKPNE BMFDHBGAKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x802B680", Offset = "0x802AA80", VA = "0x18802B680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x26861F0", Offset = "0x26855F0", VA = "0x1826861F0")]
	public DJOLONAHFCN(CancellationToken LMNHDKIFBOH, HENFMPPFGFG HEKFIEJNOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x802B6D0", Offset = "0x802AAD0", VA = "0x18802B6D0")]
	public static OAKJPOKLEGC NNDMFMIMKMF(HENFMPPFGFG HEKFIEJNOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x802B090", Offset = "0x802A490", VA = "0x18802B090")]
	[AsyncStateMachine(typeof(OHDPJNKFJPP))]
	public Task<bool> AMNMBKBGPIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x802B1A0", Offset = "0x802A5A0", VA = "0x18802B1A0")]
	private bool CEICAMGDFOH([Out] CKKDNBIBBCP HGHJCHINOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x802B400", Offset = "0x802A800", VA = "0x18802B400")]
	[AsyncStateMachine(typeof(HCKKLPCCOHA))]
	private Task GPHPMADLKFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x802B4D0", Offset = "0x802A8D0", VA = "0x18802B4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x802C950", Offset = "0x802BD50", VA = "0x18802C950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4E0FE70", Offset = "0x4E0F270", VA = "0x184E0FE70")]
	public FGFMLOMLHHI(IBOGFHOCCBO NDOOJONJDNA, Guid FDFDCKJIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x802C900", Offset = "0x802BD00", VA = "0x18802C900")]
	public TaskAwaiter<(OGJPCDKPGHL, Task)> LKDLBOJCELA()
	{
		return default(TaskAwaiter<(OGJPCDKPGHL, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x802C830", Offset = "0x802BC30", VA = "0x18802C830", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8038AF0", Offset = "0x8037EF0", VA = "0x188038AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8038BC0", Offset = "0x8037FC0", VA = "0x188038BC0")]
	public KJMEKGCBFNO(TimeSpan ADEFLDLMJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x80389C0", Offset = "0x8037DC0", VA = "0x1880389C0")]
	public void FNMAHMIDKJO(Task JBIOGHPPPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8038B30", Offset = "0x8037F30", VA = "0x188038B30")]
	public void MJDLMLOEHPH(OGJPCDKPGHL HNFLDGONBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8038970", Offset = "0x8037D70", VA = "0x188038970")]
	public void AOODJABAHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8038A60", Offset = "0x8037E60", VA = "0x188038A60")]
	internal void GIEABCJGJIL(string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class OCNMKPGGBNG
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8040B50", Offset = "0x803FF50", VA = "0x188040B50")]
	public static NAMDFBDBPAO JCNCFJFOLEL(this NAMDFBDBPAO DMDJHNIAOJN, IBBAMKLHGAN NHDNMOCKOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x80409C0", Offset = "0x803FDC0", VA = "0x1880409C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public ONCKFBHGHJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8041580", Offset = "0x8040980", VA = "0x188041580")]
		internal bool GNKNEADBGJO(GMHIEIPOGED s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly NFOKCOMKNBM NAHLKHJHOFH;

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
	public MNOPFNBFCGI(NFOKCOMKNBM HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x803CA20", Offset = "0x803BE20", VA = "0x18803CA20", Slot = "4")]
	public NAMDFBDBPAO GNHEPACBJCH(long LNPKBFNBKIA, long OFAOCKBMEGP, string EFBGJFMCDKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x803C8C0", Offset = "0x803BCC0", VA = "0x18803C8C0", Slot = "5")]
	public NAMDFBDBPAO GNHEPACBJCH(long LNPKBFNBKIA, long OFAOCKBMEGP, KKCEGILFGJB JKIDAGFNHLP, Guid? BEKMDJCAAJN, long KFJJHJMHDOB, bool DMENPOMFOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x803CD90", Offset = "0x803C190", VA = "0x18803CD90", Slot = "6")]
	public NAMDFBDBPAO GNHEPACBJCH(DHJBDKCLFJF FBIEBFPFNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x803CAB0", Offset = "0x803BEB0", VA = "0x18803CAB0", Slot = "7")]
	public NAMDFBDBPAO GNHEPACBJCH(IBBAMKLHGAN BAINIHJKIDE, DOIHDMEMACP OMJINBCKBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x803CF90", Offset = "0x803C390", VA = "0x18803CF90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8023E60", Offset = "0x8023260", VA = "0x188023E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8024500", Offset = "0x8023900", VA = "0x188024500", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x802E590", Offset = "0x802D990", VA = "0x18802E590", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task ILPGACJPDCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x802E500", Offset = "0x802D900", VA = "0x18802E500", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x99A2A0", Offset = "0x9996A0", VA = "0x18099A2A0", Slot = "7")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x802E3A0", Offset = "0x802D7A0", VA = "0x18802E3A0", Slot = "6")]
	public void FINHILCMPMJ(Task NHNFPALEEPM, string BFJGAFPKFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x802E5C0", Offset = "0x802D9C0", VA = "0x18802E5C0")]
	[AsyncStateMachine(typeof(ANBMJGHMKPP))]
	private Task PEFAPPMJFLJ(Task JLGCIHFLEAI, string BFJGAFPKFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x802E6E0", Offset = "0x802DAE0", VA = "0x18802E6E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x802F490", Offset = "0x802E890", VA = "0x18802F490", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x802F6F0", Offset = "0x802EAF0", VA = "0x18802F6F0", Slot = "7")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x802F540", Offset = "0x802E940", VA = "0x18802F540", Slot = "5")]
	public void FMKNEEMGNIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x802F500", Offset = "0x802E900", VA = "0x18802F500", Slot = "6")]
	public void MLLIDFOPGBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x802F870", Offset = "0x802EC70", VA = "0x18802F870")]
	private Task IANHLJFGELH(OFLJMGOKAPC FKPHPPGPLLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x802F500", Offset = "0x802E900", VA = "0x18802F500", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
			[Cpp2IlInjected.Address(RVA = "0xBE3960", Offset = "0xBE2D60", VA = "0x180BE3960")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xBE35F0", Offset = "0xBE29F0", VA = "0x180BE35F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x4754140", Offset = "0x4753540", VA = "0x184754140")]
		public FMNIMFKOMLN(NNOOHIAHMIG ENFLKMBLIJN, string DJBLFBEBKGO, T PFCPDJEHNAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x47537C0", Offset = "0x4752BC0", VA = "0x1847537C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x802E980", Offset = "0x802DD80", VA = "0x18802E980", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan AMAABLFEJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x802E940", Offset = "0x802DD40", VA = "0x18802E940", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan PKIEGBDPHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x802E770", Offset = "0x802DB70", VA = "0x18802E770", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan AAKKAOOGLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x802E7F0", Offset = "0x802DBF0", VA = "0x18802E7F0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool FOEECLGDAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x802EA00", Offset = "0x802DE00", VA = "0x18802EA00", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool IBAOGCKFLML
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x802E900", Offset = "0x802DD00", VA = "0x18802E900", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool HPFDDJIIDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x802E8C0", Offset = "0x802DCC0", VA = "0x18802E8C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int KHJLJCPCOCI
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x802E7B0", Offset = "0x802DBB0", VA = "0x18802E7B0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool KAHEBEJFJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x802E9C0", Offset = "0x802DDC0", VA = "0x18802E9C0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool HNHNBAFPKLA
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x802E830", Offset = "0x802DC30", VA = "0x18802E830", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool PHBCHLNMPPK
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x802E870", Offset = "0x802DC70", VA = "0x18802E870", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x802EA40", Offset = "0x802DE40", VA = "0x18802EA40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public ONDHPEBAAHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x80415B0", Offset = "0x80409B0", VA = "0x1880415B0")]
		internal object EEJBFKCGCHK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action GBHCFOKKOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x802CFA0", Offset = "0x802C3A0", VA = "0x18802CFA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x802D670", Offset = "0x802CA70", VA = "0x18802D670", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event GCAPAODEIHF MJOEKHHMKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x802D210", Offset = "0x802C610", VA = "0x18802D210", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x802CF00", Offset = "0x802C300", VA = "0x18802CF00", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event GCAPAODEIHF LADLHDPNCBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x802D710", Offset = "0x802CB10", VA = "0x18802D710", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x802D520", Offset = "0x802C920", VA = "0x18802D520", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event GCAPAODEIHF DHEFDFMPOFP
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x802D360", Offset = "0x802C760", VA = "0x18802D360", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x802D480", Offset = "0x802C880", VA = "0x18802D480", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<PPKFOIPGIIE, bool> JLBIEPCIMGB
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x802D2B0", Offset = "0x802C6B0", VA = "0x18802D2B0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x802D5C0", Offset = "0x802C9C0", VA = "0x18802D5C0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "19")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x802CD00", Offset = "0x802C100", VA = "0x18802CD00", Slot = "14")]
	public void ABHHMHNIBEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x802D450", Offset = "0x802C850", VA = "0x18802D450", Slot = "15")]
	public void KHHHBFHKFDD(BMAMFBAMLOB GKBKHGJHGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x802D7B0", Offset = "0x802CBB0", VA = "0x18802D7B0", Slot = "16")]
	public void OEBADAAGJNM(BMAMFBAMLOB GKBKHGJHGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x802D7E0", Offset = "0x802CBE0", VA = "0x18802D7E0", Slot = "17")]
	public void PCFAPJEIKIP(BMAMFBAMLOB GKBKHGJHGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x802D400", Offset = "0x802C800", VA = "0x18802D400", Slot = "18")]
	public void JNMCIAICKAN(PPKFOIPGIIE CMJLDNADNMP, bool JKLFEMENKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x802D040", Offset = "0x802C440", VA = "0x18802D040")]
	private void HKANHPMMIAO(GCAPAODEIHF ENGJIBHFOBO, BMAMFBAMLOB GKBKHGJHGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
			[Cpp2IlInjected.Address(RVA = "0x802D810", Offset = "0x802CC10", VA = "0x18802D810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x802DF50", Offset = "0x802D350", VA = "0x18802DF50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x80303A0", Offset = "0x802F7A0", VA = "0x1880303A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x8031050", Offset = "0x8030450", VA = "0x188031050", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public CACMJHFFIFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x8027F60", Offset = "0x8027360", VA = "0x188027F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x802FF90", Offset = "0x802F390", VA = "0x18802FF90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool DHMAOLDECCE
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x802FDE0", Offset = "0x802F1E0", VA = "0x18802FDE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x803EBB0", Offset = "0x803DFB0", VA = "0x18803EBB0")]
		public MPFDAIAFENH(BEHHGOBGNKL IAPHFNOPBJO, HGLMOIEJBBA HNJAPPGCPFF, ELMNGLJGGCK HHOKLMFBNEK, LDINNJCHBAF[] FKGLCEAOOOB, CancellationToken LMNHDKIFBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x803D870", Offset = "0x803CC70", VA = "0x18803D870", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x803DC30", Offset = "0x803D030", VA = "0x18803DC30")]
		public void FGOHIBDFIND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x803E590", Offset = "0x803D990", VA = "0x18803E590")]
		public void NFKAGBILBAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x803D040", Offset = "0x803C440", VA = "0x18803D040")]
		public void APANDHLIDIF(JKCJLPBKNAB.Reason IAMAGDICGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x803DB30", Offset = "0x803CF30", VA = "0x18803DB30")]
		[AsyncStateMachine(typeof(GMODJBPHFJM))]
		public Task FFFNGMNJBBP(JKCJLPBKNAB.Reason JKODLOFLBMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x803E700", Offset = "0x803DB00", VA = "0x18803E700")]
		[AsyncStateMachine(typeof(ILAHHDLCEBN))]
		private Task<LDINNJCHBAF.EGBDLOOLBIJ> PGAFCHFOODF(JKCJLPBKNAB.Reason JKODLOFLBMK, LDINNJCHBAF FFGBAAEHMCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x803DA10", Offset = "0x803CE10", VA = "0x18803DA10")]
		private void FFDMHCDHPFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x803E220", Offset = "0x803D620", VA = "0x18803E220")]
		public bool KMNLIMJIKOE(JKCJLPBKNAB.Reason GMHJKFAIEGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x803E2D0", Offset = "0x803D6D0", VA = "0x18803E2D0")]
		private void MPLCOKOEFLA(IIPFHLEMLIB DHJOIBPBMPI, JKCJLPBKNAB.Reason JKODLOFLBMK = JKCJLPBKNAB.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x803D480", Offset = "0x803C880", VA = "0x18803D480")]
		private void CFINCOMEDOM(IIPFHLEMLIB DHJOIBPBMPI, LDINNJCHBAF.EGBDLOOLBIJ HBALBIOOGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x803E070", Offset = "0x803D470", VA = "0x18803E070")]
		private void IHEKIKPMAAO(IIPFHLEMLIB DHJOIBPBMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x803DCA0", Offset = "0x803D0A0", VA = "0x18803DCA0")]
		private void FLKGJLPJKOF(IIPFHLEMLIB DHJOIBPBMPI, LDINNJCHBAF.EGBDLOOLBIJ HBALBIOOGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x803D310", Offset = "0x803C710", VA = "0x18803D310")]
		private void APKODIIIAEE(IIPFHLEMLIB DHJOIBPBMPI, Exception BLCFGIAFKHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x803D760", Offset = "0x803CB60", VA = "0x18803D760")]
		private void DPHJNLHJAIL(LDINNJCHBAF FFGBAAEHMCF, JKCJLPBKNAB.Reason JKODLOFLBMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x803D650", Offset = "0x803CA50", VA = "0x18803D650")]
		private void DGCNDFCDMIN(LDINNJCHBAF FFGBAAEHMCF, JKCJLPBKNAB.Reason JKODLOFLBMK, string HEMALCCNKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x803E840", Offset = "0x803DC40", VA = "0x18803E840", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x802FF90", Offset = "0x802F390", VA = "0x18802FF90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool DHMAOLDECCE
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x802FDE0", Offset = "0x802F1E0", VA = "0x18802FDE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x802FE20", Offset = "0x802F220", VA = "0x18802FE20")]
		public void OAALHNMPGBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x802FE00", Offset = "0x802F200", VA = "0x18802FE00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x802FFB0", Offset = "0x802F3B0", VA = "0x18802FFB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x8030310", Offset = "0x802F710", VA = "0x188030310")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public OHJMDOIHCKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x80413D0", Offset = "0x80407D0", VA = "0x1880413D0")]
		internal object OJHCFMNNBLB(IIPFHLEMLIB x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x80412F0", Offset = "0x80406F0", VA = "0x1880412F0")]
		internal object AINOLGOIPJF(MPFDAIAFENH x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8041360", Offset = "0x8040760", VA = "0x188041360")]
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
		[Cpp2IlInjected.Address(RVA = "0x8039920", Offset = "0x8038D20", VA = "0x188039920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x803A3A0", Offset = "0x80397A0", VA = "0x18803A3A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x80284E0", Offset = "0x80278E0", VA = "0x1880284E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8029170", Offset = "0x8028570", VA = "0x188029170", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x803A7B0", Offset = "0x8039BB0", VA = "0x18803A7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x803AD50", Offset = "0x803A150", VA = "0x18803AD50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x802A8B0", Offset = "0x8029CB0", VA = "0x18802A8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool CHDMODABKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x22344E0", Offset = "0x22338E0", VA = "0x1822344E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool MJCABOOJDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x802A900", Offset = "0x8029D00", VA = "0x18802A900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x802A830", Offset = "0x8029C30", VA = "0x18802A830", Slot = "7")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x802A750", Offset = "0x8029B50", VA = "0x18802A750", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x802A970", Offset = "0x8029D70", VA = "0x18802A970", Slot = "9")]
	public void OAALHNMPGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x802ADE0", Offset = "0x802A1E0", VA = "0x18802ADE0")]
	private bool PHAPEABJODD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x802A1D0", Offset = "0x80295D0", VA = "0x18802A1D0", Slot = "6")]
	private void BCDHNIBLOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x802A2A0", Offset = "0x80296A0", VA = "0x18802A2A0", Slot = "5")]
	[AsyncStateMachine(typeof(LJENHBJFAIB))]
	private Task DDAIJHLCLOM(JKCJLPBKNAB.Reason JKODLOFLBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x802AB00", Offset = "0x8029F00", VA = "0x18802AB00")]
	private bool PFAGCNNJELG(JKCJLPBKNAB.Reason JKODLOFLBMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x802A390", Offset = "0x8029790", VA = "0x18802A390")]
	private LDINNJCHBAF[] DILNILCLOCD(ELMNGLJGGCK JNCILALKDNL, HGLMOIEJBBA GFEIMBGNADK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x802AEC0", Offset = "0x802A2C0", VA = "0x18802AEC0")]
	[AsyncStateMachine(typeof(CIJNAMHKHIN))]
	private Task PHBLCGMKOIN(JKCJLPBKNAB.Reason JKODLOFLBMK, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x802A760", Offset = "0x8029B60", VA = "0x18802A760")]
	[AsyncStateMachine(typeof(LMCPCFOPHKM))]
	private Task EPAHABENECF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x802BDF0", Offset = "0x802B1F0", VA = "0x18802BDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x802C760", Offset = "0x802BB60", VA = "0x18802C760", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8022630", Offset = "0x8021A30", VA = "0x188022630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8023380", Offset = "0x8022780", VA = "0x188023380", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public DLEJEFAJEKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x802B7D0", Offset = "0x802ABD0", VA = "0x18802B7D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public PDBMHFNMMJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8032EC0", Offset = "0x80322C0", VA = "0x188032EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8038910", Offset = "0x8037D10", VA = "0x188038910", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x804EEF0", Offset = "0x804E2F0", VA = "0x18804EEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x804F960", Offset = "0x804ED60", VA = "0x18804F960", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8049610", Offset = "0x8048A10", VA = "0x188049610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8049AA0", Offset = "0x8048EA0", VA = "0x188049AA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x80490C0", Offset = "0x80484C0", VA = "0x1880490C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x80495A0", Offset = "0x80489A0", VA = "0x1880495A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8053250", Offset = "0x8052650", VA = "0x188053250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x80538A0", Offset = "0x8052CA0", VA = "0x1880538A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public LIJFPDMDPAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x805A940", Offset = "0x8059D40", VA = "0x18805A940")]
		internal object FEPFDLFCKCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x805A840", Offset = "0x8059C40", VA = "0x18805A840")]
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
		[Cpp2IlInjected.Address(RVA = "0x805EB90", Offset = "0x805DF90", VA = "0x18805EB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x805F720", Offset = "0x805EB20", VA = "0x18805F720", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x805AA40", Offset = "0x8059E40", VA = "0x18805AA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x805B230", Offset = "0x805A630", VA = "0x18805B230", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x80477A0", Offset = "0x8046BA0", VA = "0x1880477A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8048FA0", Offset = "0x80483A0", VA = "0x188048FA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x804B950", Offset = "0x804AD50", VA = "0x18804B950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x804C150", Offset = "0x804B550", VA = "0x18804C150", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public HLFMJHFGFDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8050E40", Offset = "0x8050240", VA = "0x188050E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public EGHLIAEEGAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x804B7B0", Offset = "0x804ABB0", VA = "0x18804B7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public CMPKOCHPMKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8049B00", Offset = "0x8048F00", VA = "0x188049B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public EHFDBNFGGBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x804B850", Offset = "0x804AC50", VA = "0x18804B850")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BBDB0", Offset = "0x9BB1B0", VA = "0x1809BBDB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x11E30F0", Offset = "0x11E24F0", VA = "0x1811E30F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CDCAHPMDKLI JLEJGCAJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8026580", Offset = "0x8025980", VA = "0x188026580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8025E10", Offset = "0x8025210", VA = "0x188025E10", Slot = "6")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8024BF0", Offset = "0x8023FF0", VA = "0x188024BF0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8027B00", Offset = "0x8026F00", VA = "0x188027B00", Slot = "5")]
	[AsyncStateMachine(typeof(EIFCLDBBMAF))]
	public Task PPPOMNFHKIF(ELMNGLJGGCK DKEKMBLAHBL, ALODEKIMLIG KFJFIDCNJLA, CancellationToken BOHHBCNKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8026CB0", Offset = "0x80260B0", VA = "0x188026CB0")]
	[AsyncStateMachine(typeof(ADGNEKJPLCH))]
	private Task MKACOFIGHAN(ELMNGLJGGCK DKEKMBLAHBL, ALODEKIMLIG KFJFIDCNJLA, CancellationToken BOHHBCNKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8025990", Offset = "0x8024D90", VA = "0x188025990")]
	private void FNPNNGAIDDH(GLNEFDGIGPM GNLBINGGPAL, ELMNGLJGGCK DKEKMBLAHBL, Exception BLCFGIAFKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8024EF0", Offset = "0x80242F0", VA = "0x188024EF0")]
	private static void FIBBGIIFDEI(PIOLBCBDLJN ILHJJILDJLG, Exception BLCFGIAFKHH, [Optional] List<int> LLNOOACPEAB, int OGMFGMCEAIC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8026200", Offset = "0x8025600", VA = "0x188026200")]
	[AsyncStateMachine(typeof(KIGINKMJBFB))]
	private Task HHDIJOAHFFO(APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, ELMNGLJGGCK DKEKMBLAHBL, ALODEKIMLIG KFJFIDCNJLA, IGPBPPCMANO KCMOKJFLMKN, CancellationToken BOHHBCNKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x8024560", Offset = "0x8023960", VA = "0x188024560")]
	private void CBJLDFLHDNB([CallerMemberName] string CNBBADPEGOF = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x8026450", Offset = "0x8025850", VA = "0x188026450")]
	[AsyncStateMachine(typeof(HBIEIPGCPNO))]
	private Task JDPFJCBBPEE(APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8027520", Offset = "0x8026920", VA = "0x188027520")]
	private void OHPMCAHGDOI(ELMNGLJGGCK DKEKMBLAHBL, CancellationToken BOHHBCNKHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8027180", Offset = "0x8026580", VA = "0x188027180")]
	private void OAHHIPNAGCC(ELMNGLJGGCK DKEKMBLAHBL, TaskStatus AIEJMDNEBEJ, string DAMFJFKKFBI, IGPBPPCMANO KCMOKJFLMKN, Exception OBHLNPEHLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8026660", Offset = "0x8025A60", VA = "0x188026660")]
	private void KKKPNOLBHFP(ELMNGLJGGCK DKEKMBLAHBL, IGPBPPCMANO KCMOKJFLMKN, OperationCanceledException LOGCOHCKONG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8024840", Offset = "0x8023C40", VA = "0x188024840")]
	private void CMLFHBILFPM(ELMNGLJGGCK DKEKMBLAHBL, IGPBPPCMANO KCMOKJFLMKN, Exception BLCFGIAFKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8026E60", Offset = "0x8026260", VA = "0x188026E60")]
	private void NGNMHEHPDAB(ELMNGLJGGCK DKEKMBLAHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8026140", Offset = "0x8025540", VA = "0x188026140")]
	private static BMAMFBAMLOB GDKHDPPECMA(ELMNGLJGGCK DKEKMBLAHBL)
	{
		return default(BMAMFBAMLOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x80279A0", Offset = "0x8026DA0", VA = "0x1880279A0")]
	[AsyncStateMachine(typeof(CMJBEAAHINB))]
	private Task PNGLMIHIAEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x80246E0", Offset = "0x8023AE0", VA = "0x1880246E0")]
	[AsyncStateMachine(typeof(CLFCHKEHDCF))]
	private Task<Matchmaking.FIHFEJPLBAH> CJIIMDJAJFD(ELMNGLJGGCK DKEKMBLAHBL, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8027070", Offset = "0x8026470", VA = "0x188027070")]
	private static ODLMCKNIIID NNLGBGDEHGN(Matchmaking.FIHFEJPLBAH ONBLFPEPINM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8027850", Offset = "0x8026C50", VA = "0x188027850")]
	[AsyncStateMachine(typeof(IKJLKILLMOE))]
	private Task PFGNJAGKCNC(Matchmaking.FIHFEJPLBAH ONBLFPEPINM, IGPBPPCMANO KCMOKJFLMKN, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken ACCKNLEMPFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x80268E0", Offset = "0x8025CE0", VA = "0x1880268E0")]
	[AsyncStateMachine(typeof(OLCNINLEKLE))]
	private Task LAJMFNDEIOM(ELMNGLJGGCK DKEKMBLAHBL, CancellationTokenSource NKNPKGFGJPB, Task IMAIBDLBBDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x8026770", Offset = "0x8025B70", VA = "0x188026770")]
	[AsyncStateMachine(typeof(MBLMHNIDJMM))]
	private Task KPFHKHADLBE(NAMDFBDBPAO GNMBKDKPGHM, LIJGGIIFNIO ICHECBEBLLL, ELMNGLJGGCK CEPLFOPGMML, IGPBPPCMANO CEKFIJNJKCK, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken BIPEFMIMBHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x8024A00", Offset = "0x8023E00", VA = "0x188024A00")]
	private IGPBPPCMANO DLBEAEPKHLG(IGPBPPCMANO CEKFIJNJKCK, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x80248C0", Offset = "0x8023CC0", VA = "0x1880248C0")]
	[AsyncStateMachine(typeof(CILHPCKCCLG))]
	private Task DHNFANGIKGB(APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x80273F0", Offset = "0x80267F0", VA = "0x1880273F0")]
	[AsyncStateMachine(typeof(EHMJHMLIHPI))]
	private Task OCDAEKLBIEJ(CancellationToken LMNHDKIFBOH, int BNOGLLLKJPP, NCKNCPPCAHN MNHJBCEPCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x8026B30", Offset = "0x8025F30", VA = "0x188026B30")]
	private static void MAAMEOOGHIP(ELMNGLJGGCK DKEKMBLAHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8025750", Offset = "0x8024B50", VA = "0x188025750")]
	private void FKGODGMECJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x80266E0", Offset = "0x8025AE0", VA = "0x1880266E0")]
	private void KMNAJFPLKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x80265D0", Offset = "0x80259D0", VA = "0x1880265D0")]
	private void KCGEBLDDCAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x8027A70", Offset = "0x8026E70", VA = "0x188027A70")]
	private void POMCGJAGDME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x8026360", Offset = "0x8025760", VA = "0x188026360")]
	private static void IMFJGGCAMPG(ELMNGLJGGCK DKEKMBLAHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x8026A20", Offset = "0x8025E20", VA = "0x188026A20")]
	private static CancellationTokenRegistration LPCAMNFJFMG(ELMNGLJGGCK DKEKMBLAHBL, CancellationToken ACCKNLEMPFA)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x8024C40", Offset = "0x8024040", VA = "0x188024C40")]
	private static void EDJCKDGBBAO(ELMNGLJGGCK DKEKMBLAHBL, Exception BLCFGIAFKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x8024D40", Offset = "0x8024140", VA = "0x188024D40")]
	private void EHDGAJIDPNO(ELMNGLJGGCK DKEKMBLAHBL, Task IMAIBDLBBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x80261A0", Offset = "0x80255A0", VA = "0x1880261A0")]
	private static void GFDFDHMHGGA(Func<string> GJKLHCCFCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8027E60", Offset = "0x8027260", VA = "0x188027E60")]
	public BBMJPJNDFEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x8026E00", Offset = "0x8026200", VA = "0x188026E00")]
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
		[Cpp2IlInjected.Address(RVA = "0x805B730", Offset = "0x805AB30", VA = "0x18805B730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x805BC10", Offset = "0x805B010", VA = "0x18805BC10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public GGEAMOPNLMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x804E730", Offset = "0x804DB30", VA = "0x18804E730")]
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
		[Cpp2IlInjected.Address(RVA = "0x804F9C0", Offset = "0x804EDC0", VA = "0x18804F9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x804FD60", Offset = "0x804F160", VA = "0x18804FD60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x804A050", Offset = "0x8049450", VA = "0x18804A050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x804A330", Offset = "0x8049730", VA = "0x18804A330", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x80598F0", Offset = "0x8058CF0", VA = "0x1880598F0", Slot = "5")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x8059890", Offset = "0x8058C90", VA = "0x188059890", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x805A4D0", Offset = "0x80598D0", VA = "0x18805A4D0", Slot = "4")]
	public bool OPANAFEAEEP(OAKJPOKLEGC GKMLILDEFIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x805A400", Offset = "0x8059800", VA = "0x18805A400")]
	private void OMNOGAGKPNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x80595A0", Offset = "0x80589A0", VA = "0x1880595A0")]
	private void AONEGKGJOBB(FEJGNMMNDHD LLMAFCHBBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8059BD0", Offset = "0x8058FD0", VA = "0x188059BD0")]
	[AsyncStateMachine(typeof(NJPLOEJDFHM))]
	private Task KEDHMFIGGGO(int BNOGLLLKJPP, NCKNCPPCAHN MNHJBCEPCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x80597C0", Offset = "0x8058BC0", VA = "0x1880597C0")]
	private Func<CancellationToken, List<Task>> APJIPNJFDOJ(int BNOGLLLKJPP, NCKNCPPCAHN MNHJBCEPCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8059D90", Offset = "0x8059190", VA = "0x188059D90")]
	private List<Task> NPALFNDHBAF(int BNOGLLLKJPP, NCKNCPPCAHN MNHJBCEPCPN, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x805A2E0", Offset = "0x80596E0", VA = "0x18805A2E0")]
	[AsyncStateMachine(typeof(HCBMLOFHMHF))]
	private Task OAMCFHGJDBB(OAKJPOKLEGC IJBCOFDMABE, CancellationToken HHGPJKKLNIG, int BNOGLLLKJPP, NCKNCPPCAHN MNHJBCEPCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x8059CC0", Offset = "0x80590C0", VA = "0x188059CC0")]
	[AsyncStateMachine(typeof(DLJOPGHEPGE))]
	private Task LJHMJLADKMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x805A260", Offset = "0x8059660", VA = "0x18805A260")]
	private void OAALHNMPGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x805A530", Offset = "0x8059930", VA = "0x18805A530")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public LBNCAHIOKBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8057630", Offset = "0x8056A30", VA = "0x188057630")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public AENEHADDPAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8043BE0", Offset = "0x8042FE0", VA = "0x188043BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public JIJLNFBEHEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8054DE0", Offset = "0x80541E0", VA = "0x188054DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public ACKHADGBDHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8043B80", Offset = "0x8042F80", VA = "0x188043B80")]
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
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "9")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x804A400", Offset = "0x8049800", VA = "0x18804A400", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x804A950", Offset = "0x8049D50", VA = "0x18804A950", Slot = "4")]
	public FGFMLOMLHHI JJBKLNLGAIJ(Guid FDFDCKJIMBB)
	{
		return default(FGFMLOMLHHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x804A740", Offset = "0x8049B40", VA = "0x18804A740", Slot = "5")]
	public bool JEBJOEBLLEI(Guid FDFDCKJIMBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x804A410", Offset = "0x8049810", VA = "0x18804A410", Slot = "6")]
	public bool IDKHLOEDIPG(Guid FDFDCKJIMBB, Task JBIOGHPPPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x804ADA0", Offset = "0x804A1A0", VA = "0x18804ADA0", Slot = "7")]
	public bool PPNGDMAJHKO(Guid FDFDCKJIMBB, OGJPCDKPGHL HNFLDGONBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x804A390", Offset = "0x8049790", VA = "0x18804A390", Slot = "8")]
	public Task<(OGJPCDKPGHL, Task)> APPGNFKIDIP(Guid FDFDCKJIMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x804AB70", Offset = "0x8049F70", VA = "0x18804AB70")]
	private void OIOAELOHIEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x804AF80", Offset = "0x804A380", VA = "0x18804AF80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8054D30", Offset = "0x8054130", VA = "0x188054D30")]
		public JIBPAJGMCIA(ELMNGLJGGCK LAEOEHEDICK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8054BE0", Offset = "0x8053FE0", VA = "0x188054BE0")]
		public void OAALHNMPGBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x8054BB0", Offset = "0x8053FB0", VA = "0x188054BB0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public MOMLKPPECGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x805B2F0", Offset = "0x805A6F0", VA = "0x18805B2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x804E210", Offset = "0x804D610", VA = "0x18804E210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x804E660", Offset = "0x804DA60", VA = "0x18804E660", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public FHLMNPGEEFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x804DBC0", Offset = "0x804CFC0", VA = "0x18804DBC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public CJIJGFACFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x8049000", Offset = "0x8048400", VA = "0x188049000")]
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
		[Cpp2IlInjected.Address(RVA = "0x80458E0", Offset = "0x8044CE0", VA = "0x1880458E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x9F4FB0", Offset = "0x9F43B0", VA = "0x1809F4FB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public INKEBKHEOCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x80539C0", Offset = "0x8052DC0", VA = "0x1880539C0")]
		internal object LHFHPBAENJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8053900", Offset = "0x8052D00", VA = "0x188053900")]
		internal void GAFOINDHDCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8053A60", Offset = "0x8052E60", VA = "0x188053A60")]
		internal object OFEFJLDNFCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x8053980", Offset = "0x8052D80", VA = "0x188053980")]
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
		[Cpp2IlInjected.Address(RVA = "0x8055E50", Offset = "0x8055250", VA = "0x188055E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8056E20", Offset = "0x8056220", VA = "0x188056E20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x805E0F0", Offset = "0x805D4F0", VA = "0x18805E0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool FPMNBCOMPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xBBC590", Offset = "0xBBB990", VA = "0x180BBC590")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x805D6F0", Offset = "0x805CAF0", VA = "0x18805D6F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x805DC70", Offset = "0x805D070", VA = "0x18805DC70", Slot = "4")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x805DB00", Offset = "0x805CF00", VA = "0x18805DB00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x805D800", Offset = "0x805CC00", VA = "0x18805D800")]
	[AsyncStateMachine(typeof(GCJODFKCODG))]
	private Task BHOJDJGPEPG(OFLJMGOKAPC JHHDCJJPOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x805DF60", Offset = "0x805D360", VA = "0x18805DF60")]
	private void IGPHPKOBPFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x805D8F0", Offset = "0x805CCF0", VA = "0x18805D8F0")]
	private void BNFDNFKONOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x805E140", Offset = "0x805D540", VA = "0x18805E140")]
	private void LBCPAGPKKEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x805DA80", Offset = "0x805CE80", VA = "0x18805DA80")]
	private bool BOMPFAEFHMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x805E2C0", Offset = "0x805D6C0", VA = "0x18805E2C0")]
	[AsyncStateMachine(typeof(BNGGLBFLOJC))]
	private void LBMIJMNFCGC(int LGLPENFMNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x805E4C0", Offset = "0x805D8C0", VA = "0x18805E4C0")]
	private void NOKCLHJMFNF([Out] IDisposable BPIBJCJFFCI, [Out] IDisposable HHOFNEPKNCM, [Out] IDisposable LDKCBBIHOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x805D700", Offset = "0x805CB00", VA = "0x18805D700")]
	private bool BDEBONMAIJH(ELMNGLJGGCK LAEOEHEDICK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x805DF10", Offset = "0x805D310", VA = "0x18805DF10")]
	private void IBOHAAJDIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x805E390", Offset = "0x805D790", VA = "0x18805E390")]
	[AsyncStateMachine(typeof(KJIIKLPKCHE))]
	private Task MKACOFIGHAN(ELMNGLJGGCK LAEOEHEDICK, ALODEKIMLIG KFJFIDCNJLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x805EB20", Offset = "0x805DF20", VA = "0x18805EB20")]
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
		[Cpp2IlInjected.Address(RVA = "0x805B430", Offset = "0x805A830", VA = "0x18805B430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x805B6C0", Offset = "0x805AAC0", VA = "0x18805B6C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public LICNKPHEOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x805A7E0", Offset = "0x8059BE0", VA = "0x18805A7E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public GNBLDFLCHMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x804EDE0", Offset = "0x804E1E0", VA = "0x18804EDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public BGJNCILOMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8045880", Offset = "0x8044C80", VA = "0x188045880")]
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
		[Cpp2IlInjected.Address(RVA = "0x8043250", Offset = "0x8042650", VA = "0x188043250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x8043B20", Offset = "0x8042F20", VA = "0x188043B20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public HFDHIJMILCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8050DE0", Offset = "0x80501E0", VA = "0x188050DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x805FED0", Offset = "0x805F2D0", VA = "0x18805FED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x8060A50", Offset = "0x805FE50", VA = "0x188060A50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8051010", Offset = "0x8050410", VA = "0x188051010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x8051540", Offset = "0x8050940", VA = "0x188051540", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public PCKNHLHNJEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x805FE50", Offset = "0x805F250", VA = "0x18805FE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8054010", Offset = "0x8053410", VA = "0x188054010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x8054650", Offset = "0x8053A50", VA = "0x188054650", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public EFPGJKIIBEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x804B750", Offset = "0x804AB50", VA = "0x18804B750")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public IHGOLHOMPBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x80529D0", Offset = "0x8051DD0", VA = "0x1880529D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8045000", Offset = "0x8044400", VA = "0x188045000", Slot = "7")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x8045620", Offset = "0x8044A20", VA = "0x188045620", Slot = "6")]
	[AsyncStateMachine(typeof(NJKLDIJMDEP))]
	public Task<OGNLJOEPPKN> NGJKIOJDLDP(CancellationToken GHDNKDIFAGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8045180", Offset = "0x8044580", VA = "0x188045180", Slot = "4")]
	public void IEIBDBGMJEP(EPOGGLOBAKG DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x8044CA0", Offset = "0x80440A0", VA = "0x188044CA0", Slot = "5")]
	public void FMMMOAFEHEN(EPOGGLOBAKG HBNLBJJDBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x80444D0", Offset = "0x80438D0", VA = "0x1880444D0")]
	[AsyncStateMachine(typeof(AAGBNKOJOLC))]
	private Task CFLMDPFEKLF(EPOGGLOBAKG ANMDEHLLLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x8045510", Offset = "0x8044910", VA = "0x188045510")]
	[AsyncStateMachine(typeof(PDGAOKOLFBE))]
	private Task KHIKHGHCEAE(EPOGGLOBAKG DFHHMKOIGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x8044380", Offset = "0x8043780", VA = "0x188044380")]
	[AsyncStateMachine(typeof(HMLCNDFLAMC))]
	private Task<EBHOBHMGDHC> BJEIAEMILIF(EPOGGLOBAKG ANMDEHLLLBJ, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x80450F0", Offset = "0x80444F0", VA = "0x1880450F0")]
	private IGPBPPCMANO HOEBOMHOGLB(EPOGGLOBAKG KBECLOEPHKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x8044B80", Offset = "0x8043F80", VA = "0x188044B80")]
	[AsyncStateMachine(typeof(JEFEGHAGIFG))]
	private Task FDBMJLKOHLA(EBHOBHMGDHC EKJBIEIFIHC, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x8044970", Offset = "0x8043D70", VA = "0x188044970")]
	private EBHOBHMGDHC DMMLNDENKLN(EPOGGLOBAKG ANMDEHLLLBJ, IGPBPPCMANO MMOEGADJJKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x3D75330", Offset = "0x3D74730", VA = "0x183D75330")]
	private T EIPAMIOLDNO<T>(T FFOEEMKIKJO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x80445E0", Offset = "0x80439E0", VA = "0x1880445E0")]
	private EBHOBHMGDHC CKEKLLHKMPN(EPOGGLOBAKG ANMDEHLLLBJ, IGPBPPCMANO MMOEGADJJKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public KDPDPBHGKBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8055DE0", Offset = "0x80551E0", VA = "0x188055DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public HAJIMHNNLML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x804EE80", Offset = "0x804E280", VA = "0x18804EE80")]
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
	[Cpp2IlInjected.Address(RVA = "0x8058D00", Offset = "0x8058100", VA = "0x188058D00", Slot = "6")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x8058820", Offset = "0x8057C20", VA = "0x188058820", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x80581F0", Offset = "0x80575F0", VA = "0x1880581F0", Slot = "4")]
	public FGFMLOMLHHI CMHKALEDHAA(EPOGGLOBAKG KEGFOJLGFBH)
	{
		return default(FGFMLOMLHHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x8058AF0", Offset = "0x8057EF0", VA = "0x188058AF0", Slot = "5")]
	public void FINDJJAMDBO(Guid FDFDCKJIMBB, Task JBIOGHPPPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x8057E70", Offset = "0x8057270", VA = "0x188057E70")]
	private void BMLCGOBJODA(byte MIDDANGFEAA, int PBDEPMNBOEB, object KDFIAKDDPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x80578D0", Offset = "0x8056CD0", VA = "0x1880578D0")]
	private void BMGDGIHBPLO(HGEDMLNCGKA JOKKIDPHPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x8058E70", Offset = "0x8058270", VA = "0x188058E70")]
	private void MGJOAOGHEEM(HGEDMLNCGKA JOKKIDPHPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x8057690", Offset = "0x8056A90", VA = "0x188057690")]
	private void BEFAFHBHMJG(HGEDMLNCGKA JOKKIDPHPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x8057F40", Offset = "0x8057340", VA = "0x188057F40")]
	private OGJPCDKPGHL CKMEDBCMEHK(EPOGGLOBAKG KBECLOEPHKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x8059100", Offset = "0x8058500", VA = "0x188059100")]
	private void MHEHAFHKFKE(EPOGGLOBAKG DFHHMKOIGME, OGJPCDKPGHL HNFLDGONBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x8058630", Offset = "0x8057A30", VA = "0x188058630")]
	private bool DAIABHODGPG(EPOGGLOBAKG DFHHMKOIGME, OGJPCDKPGHL HNFLDGONBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x80588D0", Offset = "0x8057CD0", VA = "0x1880588D0")]
	private bool EGLGEHKFCHB(EPOGGLOBAKG LHPEOJEJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x8059310", Offset = "0x8058710", VA = "0x188059310")]
	private bool OKPOBPMMOMN(byte MIDDANGFEAA, ExitGames.Client.Photon.Hashtable JOKKIDPHPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public LHJLNACAPNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x805A770", Offset = "0x8059B70", VA = "0x18805A770")]
		internal object HJMONLHNIDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x805A5C0", Offset = "0x80599C0", VA = "0x18805A5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x804B040", Offset = "0x804A440", VA = "0x18804B040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x804B6E0", Offset = "0x804AAE0", VA = "0x18804B6E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public GEDIJBMFFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x804E6C0", Offset = "0x804DAC0", VA = "0x18804E6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public BADFKEKMPOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x80457A0", Offset = "0x8044BA0", VA = "0x1880457A0")]
		internal object MJGMDGJDCJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x8045810", Offset = "0x8044C10", VA = "0x188045810")]
		internal object NHHBEMBCKCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x8045730", Offset = "0x8044B30", VA = "0x188045730")]
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
		[Cpp2IlInjected.Address(RVA = "0x8054E40", Offset = "0x8054240", VA = "0x188054E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x8055710", Offset = "0x8054B10", VA = "0x188055710", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x8054910", Offset = "0x8053D10", VA = "0x188054910", Slot = "5")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x80546B0", Offset = "0x8053AB0", VA = "0x1880546B0", Slot = "4")]
	[AsyncStateMachine(typeof(EAOFDJEMFME))]
	private Task<OGJPCDKPGHL> CECJOFJONKA(EPOGGLOBAKG KBECLOEPHKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x80549C0", Offset = "0x8053DC0", VA = "0x1880549C0")]
	private bool KCHALEHEGDE(OGNLJOEPPKN CMJLDNADNMP, [Out] OGJPCDKPGHL HBALBIOOGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x80547D0", Offset = "0x8053BD0", VA = "0x1880547D0")]
	[AsyncStateMachine(typeof(JKDGCCPOFCE))]
	private Task<OGJPCDKPGHL> CFLHNLMOLPH(EPOGGLOBAKG ANMDEHLLLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x8052C10", Offset = "0x8052010", VA = "0x188052C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x80531E0", Offset = "0x80525E0", VA = "0x1880531E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public NLHNMBPNIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x805BC70", Offset = "0x805B070", VA = "0x18805BC70")]
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
		[Cpp2IlInjected.Address(RVA = "0x8055780", Offset = "0x8054B80", VA = "0x188055780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x8055D70", Offset = "0x8055170", VA = "0x188055D70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x804DC30", Offset = "0x804D030", VA = "0x18804DC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x804E1A0", Offset = "0x804D5A0", VA = "0x18804E1A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public IJFPIKLLDJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xDB0490", Offset = "0xDAF890", VA = "0x180DB0490")]
		internal bool GEOPPKGAPPD(GMHIEIPOGED sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x8052B50", Offset = "0x8051F50", VA = "0x188052B50")]
		internal object OJGFGOOHLJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x8052AC0", Offset = "0x8051EC0", VA = "0x188052AC0")]
		internal object JOLDBBAMDID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8052A30", Offset = "0x8051E30", VA = "0x188052A30")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public OMGMEAAFNKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x805F780", Offset = "0x805EB80", VA = "0x18805F780")]
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
		[Cpp2IlInjected.Address(RVA = "0x804FDC0", Offset = "0x804F1C0", VA = "0x18804FDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8050D70", Offset = "0x8050170", VA = "0x188050D70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public MPGIIBKAAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x805B380", Offset = "0x805A780", VA = "0x18805B380")]
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
		[Cpp2IlInjected.Address(RVA = "0x8043C40", Offset = "0x8043040", VA = "0x188043C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8044310", Offset = "0x8043710", VA = "0x188044310", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x804D6A0", Offset = "0x804CAA0", VA = "0x18804D6A0", Slot = "5")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x804D790", Offset = "0x804CB90", VA = "0x18804D790", Slot = "4")]
	[AsyncStateMachine(typeof(IJKAJHPDKEH))]
	public Task<NAMDFBDBPAO> JHOKNIONKNO(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, ELMNGLJGGCK DKEKMBLAHBL, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x804D8F0", Offset = "0x804CCF0", VA = "0x18804D8F0")]
	[AsyncStateMachine(typeof(JMDPMOLGFEB))]
	private Task<IBBAMKLHGAN> KFJCAOIJLKH(ELMNGLJGGCK DKEKMBLAHBL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x804D3C0", Offset = "0x804C7C0", VA = "0x18804D3C0")]
	[AsyncStateMachine(typeof(GCDPOLDCMMO))]
	private Task<NAMDFBDBPAO> AGFPFNMFDPO(ELMNGLJGGCK DKEKMBLAHBL, IBBAMKLHGAN ADBOOCEJEGJ, long JCNNPHFBOMP, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x804D530", Offset = "0x804C930", VA = "0x18804D530")]
	[AsyncStateMachine(typeof(HDLJCLEFDJC))]
	private Task<KKECMPPAFHI> EKHIGHENODM(ELMNGLJGGCK DKEKMBLAHBL, IBBAMKLHGAN ADBOOCEJEGJ, long JCNNPHFBOMP, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x804DA50", Offset = "0x804CE50", VA = "0x18804DA50")]
	[AsyncStateMachine(typeof(AJIDACGBBFM))]
	private Task<KKECMPPAFHI> MGOJBENCPJN(ELMNGLJGGCK AOIOEMLIMME, GMHIEIPOGED FNFEBBMJIJM, long JCNNPHFBOMP, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public MIPOFGMEGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x805B290", Offset = "0x805A690", VA = "0x18805B290")]
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
		[Cpp2IlInjected.Address(RVA = "0x805C8E0", Offset = "0x805BCE0", VA = "0x18805C8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x805CEF0", Offset = "0x805C2F0", VA = "0x18805CEF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x804E770", Offset = "0x804DB70", VA = "0x18804E770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x804ED70", Offset = "0x804E170", VA = "0x18804ED70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public PJCMDDDFOJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x8060AB0", Offset = "0x805FEB0", VA = "0x188060AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8051D70", Offset = "0x8051170", VA = "0x188051D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x8052960", Offset = "0x8051D60", VA = "0x188052960", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8047270", Offset = "0x8046670", VA = "0x188047270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x8047490", Offset = "0x8046890", VA = "0x188047490", Slot = "8")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x8047110", Offset = "0x8046510", VA = "0x188047110", Slot = "4")]
	[AsyncStateMachine(typeof(NOAHCIAJEJE))]
	public Task<EPOGGLOBAKG> CHOFHHBDGBK(EPOGGLOBAKG ANMDEHLLLBJ, IGPBPPCMANO MMOEGADJJKD, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x8047650", Offset = "0x8046A50", VA = "0x188047650", Slot = "5")]
	[AsyncStateMachine(typeof(GLGHFGEOGKA))]
	public Task<EPOGGLOBAKG> OKJPGBOGCBO(CancellationToken LMNHDKIFBOH, IGPBPPCMANO MMOEGADJJKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x8047060", Offset = "0x8046460", VA = "0x188047060", Slot = "6")]
	public KKJJOKHIFIF ADKGCHFEPJO(EBHOBHMGDHC PIDDBFCEPEF, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x8047520", Offset = "0x8046920", VA = "0x188047520", Slot = "7")]
	public KKJJOKHIFIF JGCOABDPKAO(EBHOBHMGDHC PIDDBFCEPEF, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x8047330", Offset = "0x8046730", VA = "0x188047330")]
	[AsyncStateMachine(typeof(IGPFFJHPPGK))]
	private Task<EPOGGLOBAKG> DCLNBLAMAEA(EPOGGLOBAKG ANMDEHLLLBJ, IGPBPPCMANO MMOEGADJJKD, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x36CAF90", Offset = "0x36CA390", VA = "0x1836CAF90")]
	private static byte[] HAEOGOCLDPL(EPOGGLOBAKG DAMFJFKKFBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x805FDF0", Offset = "0x805F1F0", VA = "0x18805FDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static OGJPCDKPGHL ABONCMIDHHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x805FE40", Offset = "0x805F240", VA = "0x18805FE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x805F9F0", Offset = "0x805EDF0", VA = "0x18805F9F0", Slot = "6")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x805F880", Offset = "0x805EC80", VA = "0x18805F880", Slot = "4")]
	public OGJPCDKPGHL CPCJPACPPID(DNIGIBHMBIB DBPOAMOJLGH, OGNLJOEPPKN FHHMBNMHEHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x805FB70", Offset = "0x805EF70", VA = "0x18805FB70", Slot = "5")]
	public OGJPCDKPGHL IBIJOKDLMGH(DNIGIBHMBIB ODJOKMHBJDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x805FB60", Offset = "0x805EF60", VA = "0x18805FB60")]
	private static OGJPCDKPGHL HJCBGAHJHIA(JNDBDBIFPHO JKODLOFLBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public OPECPFCMJMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class GOCHIKEMDEC : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x804EE40", Offset = "0x804E240", VA = "0x18804EE40")]
	public GOCHIKEMDEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x72D6790", Offset = "0x72D5B90", VA = "0x1872D6790")]
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
		[Cpp2IlInjected.Address(RVA = "0x805BD20", Offset = "0x805B120", VA = "0x18805BD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x805C870", Offset = "0x805BC70", VA = "0x18805C870", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x80515B0", Offset = "0x80509B0", VA = "0x1880515B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x8051D10", Offset = "0x8051110", VA = "0x188051D10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8053AA0", Offset = "0x8052EA0", VA = "0x188053AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x8053FB0", Offset = "0x80533B0", VA = "0x188053FB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8056E80", Offset = "0x8056280", VA = "0x188056E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x80575D0", Offset = "0x80569D0", VA = "0x1880575D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x804C1B0", Offset = "0x804B5B0", VA = "0x18804C1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x804C350", Offset = "0x804B750", VA = "0x18804C350", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x805CF60", Offset = "0x805C360", VA = "0x18805CF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x805D690", Offset = "0x805CA90", VA = "0x18805D690", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8049B80", Offset = "0x8048F80", VA = "0x188049B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x8049FF0", Offset = "0x80493F0", VA = "0x188049FF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x806D650", Offset = "0x806CA50", VA = "0x18806D650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x806DBF0", Offset = "0x806CFF0", VA = "0x18806DBF0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x804C860", Offset = "0x804BC60", VA = "0x18804C860", Slot = "6")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x11A8A90", Offset = "0x11A7E90", VA = "0x1811A8A90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x804D060", Offset = "0x804C460", VA = "0x18804D060")]
	private void MJPNLPEHBLL(float IBODAGBPMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x804C4B0", Offset = "0x804B8B0", VA = "0x18804C4B0", Slot = "4")]
	[AsyncStateMachine(typeof(NLIAEEPGIFN))]
	public Task<OGJPCDKPGHL> FHOJJMNBMGO(CKKDNBIBBCP HGHJCHINOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x804CE00", Offset = "0x804C200", VA = "0x18804CE00", Slot = "5")]
	[AsyncStateMachine(typeof(HOOGIEKEJOG))]
	public Task KOLLENMFCCL([Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x11A8A90", Offset = "0x11A7E90", VA = "0x1811A8A90")]
	public void AOOACJPLHML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x804CEF0", Offset = "0x804C2F0", VA = "0x18804CEF0")]
	private DPKNKAFHJIP LNLDACJCCIH(CKKDNBIBBCP HGHJCHINOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x804CB20", Offset = "0x804BF20", VA = "0x18804CB20")]
	[AsyncStateMachine(typeof(JBHMDPGAFHJ))]
	private Task IDCCDAIAHHL(CancellationToken BOHHBCNKHLK, int BNOGLLLKJPP, NCKNCPPCAHN MNHJBCEPCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x804CC10", Offset = "0x804C010", VA = "0x18804CC10")]
	[AsyncStateMachine(typeof(KKKKDNCGGLM))]
	private Task IOMGODKELLL(CancellationToken BOHHBCNKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x804D2D0", Offset = "0x804C6D0", VA = "0x18804D2D0")]
	[AsyncStateMachine(typeof(EODAHIGCAOG))]
	private Task OJGHKMBJFLJ([Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x804CD10", Offset = "0x804C110", VA = "0x18804CD10")]
	[AsyncStateMachine(typeof(OCIPJDEEDKN))]
	private Task JHPCEKPFEJG(CancellationToken BOHHBCNKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x804C3B0", Offset = "0x804B7B0", VA = "0x18804C3B0")]
	[AsyncStateMachine(typeof(DDMHNCFJNDO))]
	private Task CAOFHNPGCHF(CancellationToken OBLLCMCDHMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x804D140", Offset = "0x804C540", VA = "0x18804D140")]
	private Task NNHBFGDBPMH(JFCACKFPDGD GIHOEMBHLDB, CancellationToken BOHHBCNKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x804CA10", Offset = "0x804BE10", VA = "0x18804CA10")]
	[AsyncStateMachine(typeof(GOFBJKEPADI))]
	private Task HOMHMOLGJCI(JFCACKFPDGD GIHOEMBHLDB, CancellationToken BOHHBCNKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x804C5E0", Offset = "0x804B9E0", VA = "0x18804C5E0")]
	private bool GCKNKCJNMCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x80643D0", Offset = "0x80637D0", VA = "0x1880643D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8064990", Offset = "0x8063D90", VA = "0x188064990", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x8079820", Offset = "0x8078C20", VA = "0x188079820", Slot = "6")]
	public void GDCNGOALEGL(HENFMPPFGFG LMJMNPPPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x8079710", Offset = "0x8078B10", VA = "0x188079710", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x8079B00", Offset = "0x8078F00", VA = "0x188079B00", Slot = "5")]
	[AsyncStateMachine(typeof(CLKIJENJBLE))]
	public Task MKJAEAFJGLM(string IOOOOBAIEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x8079760", Offset = "0x8078B60", VA = "0x188079760", Slot = "4")]
	public OGJPCDKPGHL GCKNKCJNMCE(DNIGIBHMBIB DBPOAMOJLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x80795D0", Offset = "0x80789D0", VA = "0x1880795D0")]
	private GGFPIDNIPGL BDPNNGFAKDM(string IOOOOBAIEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public ODDGEJLGIDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class GDIHCNHBLAF
{
	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x806C300", Offset = "0x806B700", VA = "0x18806C300")]
	public static void FKEKKJIMDFB(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x806C540", Offset = "0x806B940", VA = "0x18806C540")]
	internal static void GLAEEOPMAKI(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x806C6A0", Offset = "0x806BAA0", VA = "0x18806C6A0")]
	internal static void ILGOELGAPLI(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x806C780", Offset = "0x806BB80", VA = "0x18806C780")]
	internal static void PEKHMIGJJDD(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x35DEFF0", Offset = "0x35DE3F0", VA = "0x1835DEFF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public BOPBHLNEPBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x80626F0", Offset = "0x8061AF0", VA = "0x1880626F0")]
		internal object LBJDMCEGBCM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly JAODKAKCOOB DNEPPKLGBFA;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x8071510", Offset = "0x8070910", VA = "0x188071510")]
	public ExitGames.Client.Photon.Hashtable PELCBGJOJPC(EPOGGLOBAKG DAMFJFKKFBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x8070E00", Offset = "0x8070200", VA = "0x188070E00", Slot = "5")]
	protected override void EAJHGDDEIPA(EPOGGLOBAKG DAMFJFKKFBI, IDictionary<object, object> HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x8071040", Offset = "0x8070440", VA = "0x188071040", Slot = "6")]
	public override EPOGGLOBAKG HFAEDKNMEEN(IDictionary<object, object> HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x8070F30", Offset = "0x8070330", VA = "0x188070F30")]
	private static void GFDFDHMHGGA(string DKFMMLIFNLP, EPOGGLOBAKG DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x8071640", Offset = "0x8070A40", VA = "0x188071640")]
	public JAODKAKCOOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x8071270", Offset = "0x8070670", VA = "0x188071270")]
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
		[Cpp2IlInjected.Address(RVA = "0x807BF90", Offset = "0x807B390", VA = "0x18807BF90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x807BCB0", Offset = "0x807B0B0", VA = "0x18807BCB0")]
	public static bool BFPLJFLOJFJ(this OGJPCDKPGHL HNFLDGONBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x807BF30", Offset = "0x807B330", VA = "0x18807BF30")]
	public static OGJPCDKPGHL HJCBGAHJHIA(JNDBDBIFPHO GCFDJFLLMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x807BFF0", Offset = "0x807B3F0", VA = "0x18807BFF0")]
	public static OGJPCDKPGHL MOIELNJENNK(IEnumerable<OGJPCDKPGHL> ADJJDJNNFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x807BCD0", Offset = "0x807B0D0", VA = "0x18807BCD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public CCLIJGCFMGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x146C6A0", Offset = "0x146BAA0", VA = "0x18146C6A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8063FE0", Offset = "0x80633E0", VA = "0x188063FE0", Slot = "4")]
	public void HLLGJABLFDJ(GAMLEOPPJOC FNPMDNALIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x8064040", Offset = "0x8063440", VA = "0x188064040", Slot = "5")]
	public void JAFNFDCHGIK(GAMLEOPPJOC FNPMDNALIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x8063F90", Offset = "0x8063390", VA = "0x188063F90", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x80640A0", Offset = "0x80634A0", VA = "0x1880640A0")]
	protected OGJPCDKPGHL NLFBCECALFC(DNIGIBHMBIB ODJOKMHBJDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x8064340", Offset = "0x8063740", VA = "0x188064340")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public LKCGMALBINI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x8076FC0", Offset = "0x80763C0", VA = "0x188076FC0")]
		internal object ABBPNAGMPJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x8078750", Offset = "0x8077B50", VA = "0x188078750")]
	[UnityEngine.Scripting.Preserve]
	public MOAPLBKOBIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x8078640", Offset = "0x8077A40", VA = "0x188078640", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public MBIIDMBEJCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x8078570", Offset = "0x8077970", VA = "0x188078570")]
		internal object KOGPOOLPJAI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x8078750", Offset = "0x8077B50", VA = "0x188078750")]
	[UnityEngine.Scripting.Preserve]
	public PDMIBCLLFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x807C1F0", Offset = "0x807B5F0", VA = "0x18807C1F0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public AHGBOOACFEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x8061500", Offset = "0x8060900", VA = "0x188061500")]
		internal object IFCOJCNBMLK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x8079EC0", Offset = "0x80792C0", VA = "0x188079EC0")]
	public static APGKENHKANG<string> CLIEJFAHFIP(GBHBOJAPDOA DPDKJPMBJOA, [Optional] string COMBJFMBCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x8079E00", Offset = "0x8079200", VA = "0x188079E00")]
	public static void CGNFFNJPPFF(APGKENHKANG<string> KINEPAABOFB, GBHBOJAPDOA DPDKJPMBJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x8079FA0", Offset = "0x80793A0", VA = "0x188079FA0")]
	public static string MOIMBCJIKLB(EPOGGLOBAKG KBECLOEPHKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal static class ECGPPINEELO
{
	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x8066C40", Offset = "0x8066040", VA = "0x188066C40")]
	public static void OHBFAKEBAMO(this FMKBFEIFICC BOGAODIGBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x8066B10", Offset = "0x8065F10", VA = "0x188066B10")]
	public static void BOIBPGEJHBA(this FMKBFEIFICC BOGAODIGBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x8066B20", Offset = "0x8065F20", VA = "0x188066B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x8070740", Offset = "0x806FB40", VA = "0x188070740", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int ADKAHCGPLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x8070A10", Offset = "0x806FE10", VA = "0x188070A10", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int BNBFPFJIGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x80709C0", Offset = "0x806FDC0", VA = "0x1880709C0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool LADPAGIBFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int MPHNNCPMNKB
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xB1B310", Offset = "0xB1A710", VA = "0x180B1B310", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event MGBPOGEONJM.JKFCPKLPGCH CDALAPBDHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event MPNDCDPCBLI MIJJAFGANPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x8070830", Offset = "0x806FC30", VA = "0x188070830", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x80708D0", Offset = "0x806FCD0", VA = "0x1880708D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> GFELLJOGAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<DNIGIBHMBIB> DIJINAIGFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action GDKOHBMJJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x8070B40", Offset = "0x806FF40", VA = "0x188070B40", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x8070790", Offset = "0x806FB90", VA = "0x188070790", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0xC62450", Offset = "0xC61850", VA = "0x180C62450")]
	public IJGJNNNIEBD(DEDAEOHHDGL AANEOJPDLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x8070690", Offset = "0x806FA90", VA = "0x188070690", Slot = "8")]
	public bool ADCBEOHLBMG(byte MIDDANGFEAA, object PMHIICLKBJN, DHGFKKBCAMK HNIADHOEMAB, SendOptions ACCOEAAOMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x8070A60", Offset = "0x806FE60", VA = "0x188070A60", Slot = "16")]
	public DNIGIBHMBIB OGCGKCCKLEP(int CBHDFIGALJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "19")]
	public void PNJBKLODMKM(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "20")]
	public void OOEBPBPKHGC(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "21")]
	public void LIIAMCCAEJN(object HHGPJKKLNIG, bool MOJLEMKJLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x8070970", Offset = "0x806FD70", VA = "0x188070970", Slot = "22")]
	public IDisposable IHNHMFBCFOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "23")]
	private bool LIFJLIGALCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "24")]
	public void LBEGNPIBGGG(StringBuilder ECDIJKLJMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xEA8880", Offset = "0xEA7C80", VA = "0x180EA8880", Slot = "25")]
	public bool EADHGHPOGHI(bool LCGINDJNOFG, [Out] string AFHGIBDEPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0xE2BD60", Offset = "0xE2B160", VA = "0x180E2BD60", Slot = "28")]
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
	[Cpp2IlInjected.Address(RVA = "0xC6E720", Offset = "0xC6DB20", VA = "0x180C6E720")]
	public HGEDMLNCGKA(IDictionary<object, object> JOKKIDPHPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x806EA20", Offset = "0x806DE20", VA = "0x18806EA20")]
	public bool BGCAHEPFDLK([Out] EPOGGLOBAKG DAMFJFKKFBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x806EAD0", Offset = "0x806DED0", VA = "0x18806EAD0")]
	public Guid CBHJMMDDNFJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x806EB80", Offset = "0x806DF80", VA = "0x18806EB80")]
	public OGJPCDKPGHL CEBCEBHDGHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x806ECC0", Offset = "0x806E0C0", VA = "0x18806ECC0")]
	public static ExitGames.Client.Photon.Hashtable GNHEPACBJCH(EPOGGLOBAKG DAMFJFKKFBI, OGJPCDKPGHL HNFLDGONBPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal static class FFCEHFICGGJ
{
	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x806B120", Offset = "0x806A520", VA = "0x18806B120")]
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
		[Cpp2IlInjected.Address(RVA = "0x80668D0", Offset = "0x8065CD0", VA = "0x1880668D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x8066AB0", Offset = "0x8065EB0", VA = "0x188066AB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x807B030", Offset = "0x807A430", VA = "0x18807B030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x807B170", Offset = "0x807A570", VA = "0x18807B170")]
	public OLJOBLKCAHJ(CancellationToken LMNHDKIFBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x807B060", Offset = "0x807A460", VA = "0x18807B060")]
	[AsyncStateMachine(typeof(EBIOFCCGOGI))]
	public Task PFDECELLGBL(Func<CancellationToken, List<Task>> AFDLLEKBIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x807AFE0", Offset = "0x807A3E0", VA = "0x18807AFE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x52D7F90", Offset = "0x52D7390", VA = "0x1852D7F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x4902E00", Offset = "0x4902200", VA = "0x184902E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	private readonly JCFIGNPNPNK<TGetDataArg, TData> AMCNMNPOCHO;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xC6E720", Offset = "0xC6DB20", VA = "0x180C6E720")]
	internal GLNNEJMAOCG(JCFIGNPNPNK<TGetDataArg, TData> OHJFEHDLOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x4851F00", Offset = "0x4851300", VA = "0x184851F00")]
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
	[Cpp2IlInjected.Address(RVA = "0x33E9D10", Offset = "0x33E9110", VA = "0x1833E9D10")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E104D0", Offset = "0x4E0F8D0", VA = "0x184E104D0")]
	public FPPEPKADMMN(int BMBMKKHEAHH, [Optional] int? IBHBHJJKGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x806B870", Offset = "0x806AC70", VA = "0x18806B870", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public DFCJKOFKFMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public BHBIFCNMFDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x50E2D30", Offset = "0x50E2130", VA = "0x1850E2D30")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public NMBLMEDEOAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x50E2D30", Offset = "0x50E2130", VA = "0x1850E2D30")]
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
		[Cpp2IlInjected.Address(RVA = "0x426BD20", Offset = "0x426B120", VA = "0x18426BD20")]
		internal EAJEMJDHIGD(HPLIMJAOKJJ GNLBINGGPAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x426B940", Offset = "0x426AD40", VA = "0x18426B940", Slot = "4")]
		public void EJJFIGAKANF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x426BAA0", Offset = "0x426AEA0", VA = "0x18426BAA0", Slot = "5")]
		public IHKBPIJEHEI<T> ODJKHDILCFH(string EGKFIDEDPCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x426BBC0", Offset = "0x426AFC0", VA = "0x18426BBC0", Slot = "6")]
		public IHKBPIJEHEI<T> PAKIDIGNLHE(GJECBAHOJPF<T> EOFOIPHIFNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x426BCE0", Offset = "0x426B0E0", VA = "0x18426BCE0", Slot = "7")]
		public IHKBPIJEHEI<T> PCGFLDMCNGM(int HLLDLKNABPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x426B970", Offset = "0x426AD70", VA = "0x18426B970", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E49BF0", Offset = "0x4E48FF0", VA = "0x184E49BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x4E49D50", Offset = "0x4E49150", VA = "0x184E49D50")]
		public LMADDAPLLMD(Dictionary<Type, int> NGMLMMBGLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x4E49A40", Offset = "0x4E48E40", VA = "0x184E49A40")]
		public void JJBKLNLGAIJ(Type DJBLFBEBKGO, TVal PCJCDFNKKKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x4E499F0", Offset = "0x4E48DF0", VA = "0x184E499F0")]
		public bool JHOPICCACKP(Type CLMJFONOOFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x4E49BA0", Offset = "0x4E48FA0", VA = "0x184E49BA0")]
		public bool KADJIPIGNIG(TVal FFOEEMKIKJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x4E499A0", Offset = "0x4E48DA0", VA = "0x184E499A0")]
		public TVal IOLMGDEDCOJ(Type HAFNBBNOLPO)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x4E49860", Offset = "0x4E48C60", VA = "0x184E49860")]
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
			[Cpp2IlInjected.Address(RVA = "0x4348A60", Offset = "0x4347E60", VA = "0x184348A60", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8063DF0", Offset = "0x80631F0", VA = "0x188063DF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xDE6750", Offset = "0xDE5B50", VA = "0x180DE6750")]
		[DebuggerHidden]
		public CFDLMKHMHCA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x8063E40", Offset = "0x8063240", VA = "0x188063E40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x8063790", Offset = "0x8062B90", VA = "0x188063790", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x8063C90", Offset = "0x8063090", VA = "0x188063C90")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x8063C40", Offset = "0x8063040", VA = "0x188063C40")]
		private void NIIFAIKAHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x8063DA0", Offset = "0x80631A0", VA = "0x188063DA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x8063CE0", Offset = "0x80630E0", VA = "0x188063CE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FPPEPKADMMN> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x8063CE0", Offset = "0x80630E0", VA = "0x188063CE0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x806F6D0", Offset = "0x806EAD0", VA = "0x18806F6D0")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	internal static void FJKHLPMEJLC(DHLGDCALOEP EOJAEMANAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x80702E0", Offset = "0x806F6E0", VA = "0x1880702E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HPLIMJAOKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x337DEA0", Offset = "0x337D2A0", VA = "0x18337DEA0", Slot = "4")]
	public IHKBPIJEHEI<T> IICKMIBBHOF<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x806FCF0", Offset = "0x806F0F0", VA = "0x18806FCF0", Slot = "5")]
	public ELENBEIFKNO LHGEJMPMBCI(Exception BLCFGIAFKHH)
	{
		return default(ELENBEIFKNO);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x806FA10", Offset = "0x806EE10", VA = "0x18806FA10", Slot = "6")]
	public FPPEPKADMMN JPCJBHFAMFB(Exception? BLCFGIAFKHH)
	{
		return default(FPPEPKADMMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x806F3E0", Offset = "0x806E7E0", VA = "0x18806F3E0", Slot = "7")]
	[IteratorStateMachine(typeof(CFDLMKHMHCA))]
	public IEnumerable<FPPEPKADMMN> BFGMBLGFIPD(Exception BLCFGIAFKHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x806F290", Offset = "0x806E690", VA = "0x18806F290", Slot = "8")]
	public string AMMJHOIGDNB(Exception? BLCFGIAFKHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x806FD80", Offset = "0x806F180", VA = "0x18806FD80")]
	private string OHODOBPOEOJ(AggregateException LNHMAKGBDME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x806EEE0", Offset = "0x806E2E0", VA = "0x18806EEE0")]
	private void AAGCIICDPPB(Type CLMJFONOOFK, int HLLDLKNABPD, MEFCCHIAHFH? LHELAIDKAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x806F480", Offset = "0x806E880", VA = "0x18806F480")]
	private void DKDAEPIJOOD(Type CLMJFONOOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x806F740", Offset = "0x806EB40", VA = "0x18806F740")]
	private void INENBIMABMK(Type CLMJFONOOFK, JNCDLGOCLBB NNHGLJADHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x8070090", Offset = "0x806F490", VA = "0x188070090")]
	private static int PDLHBDMKDAM(Type CLMJFONOOFK, Dictionary<Type, int> NGMLMMBGLFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x35FCD60", Offset = "0x35FC160", VA = "0x1835FCD60")]
	private static bool DNNBJHAMNLB<TVal>(LMADDAPLLMD<TVal> JGMAGBDHLIF, Type CLMJFONOOFK, [Out] TVal FFOEEMKIKJO) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x806FC10", Offset = "0x806F010", VA = "0x18806FC10")]
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
	[Cpp2IlInjected.Address(RVA = "0x80681E0", Offset = "0x80675E0", VA = "0x1880681E0")]
	public ELENBEIFKNO(string AFEHBECBJJL, FPPEPKADMMN HLLDLKNABPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x8068140", Offset = "0x8067540", VA = "0x188068140")]
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
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public long GMLDEMLBBLI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8067760", Offset = "0x8066B60", VA = "0x188067760")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public long KMKIGPCHBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x8067BA0", Offset = "0x8066FA0", VA = "0x188067BA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public long EHLFKLOAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x8067B40", Offset = "0x8066F40", VA = "0x188067B40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public string MMLDKKPJJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x8067C00", Offset = "0x8067000", VA = "0x188067C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public CPPDEEJEANJ MJFAPDECCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xCDA490", Offset = "0xCD9890", VA = "0x180CDA490")]
		get
		{
			return default(CPPDEEJEANJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x8067C40", Offset = "0x8067040", VA = "0x188067C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public long BFFLIOCILPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x80680A0", Offset = "0x80674A0", VA = "0x1880680A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x8068100", Offset = "0x8067500", VA = "0x188068100")]
	[UnityEngine.Scripting.Preserve]
	public EGBBHHGAGKN([CMKKAFOAFJE(null)] IFCCBFAGEOA AINAIEBPKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x8067E50", Offset = "0x8067250", VA = "0x188067E50")]
	private void MFNDJLKMLGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x80672D0", Offset = "0x80666D0", VA = "0x1880672D0")]
	public void BKEFDKJBHGC(long MIFADOBCMAC, long JCNNPHFBOMP, [Optional] long? OLGEMOMILNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x8067D30", Offset = "0x8067130", VA = "0x188067D30")]
	public void ICCEJDDDGNI(long OLGEMOMILNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x8067DD0", Offset = "0x80671D0", VA = "0x188067DD0")]
	public void JJHNHHAPCBA(string JGBBMDGLIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x80677C0", Offset = "0x8066BC0", VA = "0x1880677C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8076280", Offset = "0x8075680", VA = "0x188076280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x80767C0", Offset = "0x8075BC0", VA = "0x1880767C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public CEOBAGCFNCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x8062EE0", Offset = "0x80622E0", VA = "0x188062EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8066C50", Offset = "0x8066050", VA = "0x188066C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x8067260", Offset = "0x8066660", VA = "0x188067260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct HCNHAJJJGMF<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public KKJJOKHIFIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x48C9D80", Offset = "0x48C9180", VA = "0x1848C9D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x3E854B0", Offset = "0x3E848B0", VA = "0x183E854B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct INKLDECPPHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public KKJJOKHIFIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x8070BE0", Offset = "0x806FFE0", VA = "0x188070BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x8070DA0", Offset = "0x80701A0", VA = "0x188070DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class DPHIONIBMHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public DPHIONIBMHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x8065820", Offset = "0x8064C20", VA = "0x188065820")]
		internal object OLGALKDLALD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x8065760", Offset = "0x8064B60", VA = "0x188065760")]
		internal bool GHAPPJHMJFG(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class DFHNOPLEDNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public DFHNOPLEDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x8065190", Offset = "0x8064590", VA = "0x188065190")]
		internal object PCFAAMAHIGE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private sealed class OJIMABEEALN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public OJIMABEEALN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x807AE50", Offset = "0x807A250", VA = "0x18807AE50")]
		internal object MKEHLALMMDH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class ACLHLJPCHKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public ACLHLJPCHKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x8061490", Offset = "0x8060890", VA = "0x188061490")]
		internal object HLBGNOIPBAD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class KHCMNOIEDKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public KKJJOKHIFIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public KHCMNOIEDKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x8074AC0", Offset = "0x8073EC0", VA = "0x188074AC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8076050", Offset = "0x8075450", VA = "0x188076050")]
	public KKJJOKHIFIF(EBHOBHMGDHC EKJBIEIFIHC, FONJBPLEFOC OENCKNAJGKK, EHHBJPGDAKJ BOGAODIGBEK, AEOJMJJOHFJ PEBAAHMMMNA, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x8075060", Offset = "0x8074460", VA = "0x188075060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x8075B50", Offset = "0x8074F50", VA = "0x188075B50")]
	public void KPJKEFFCLHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x8075070", Offset = "0x8074470", VA = "0x188075070")]
	public void EAPAKLPPOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x8075DF0", Offset = "0x80751F0", VA = "0x188075DF0")]
	public void PALPLMMKHCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x8075700", Offset = "0x8074B00", VA = "0x188075700")]
	[AsyncStateMachine(typeof(KMABANLFDPM))]
	internal Task<EPOGGLOBAKG> HFNMHJIDAMJ(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, EPOGGLOBAKG KBECLOEPHKF, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x36CAF90", Offset = "0x36CA390", VA = "0x1836CAF90")]
	private static byte[] PMHBLCFEAKG<T>(T DAMFJFKKFBI) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x36CAE40", Offset = "0x36CA240", VA = "0x1836CAE40")]
	private static T GHBOPAPMBGE<T>(MessageParser<T> BPKFDKFLGKL, byte[] DAMFJFKKFBI, T ILHNGOAPCGM) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x80753A0", Offset = "0x80747A0", VA = "0x1880753A0")]
	[AsyncStateMachine(typeof(EEKAIGBBGDL))]
	private Task<FONJBPLEFOC.ADOMEOOKKOA<EPOGGLOBAKG>> ELHLIKDFGGG(EPOGGLOBAKG KBECLOEPHKF, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x36CAFA0", Offset = "0x36CA3A0", VA = "0x1836CAFA0")]
	[AsyncStateMachine(typeof(HCNHAJJJGMF<>))]
	internal Task<T> POKJMAOPDIH<T>(CancellationToken BOHHBCNKHLK, Func<CancellationToken, Task<T>> JGICNIKOAID, int NHGDOMMIKNI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x8075EB0", Offset = "0x80752B0", VA = "0x188075EB0")]
	[AsyncStateMachine(typeof(INKLDECPPHN))]
	internal Task POKJMAOPDIH(CancellationToken BOHHBCNKHLK, Func<CancellationToken, Task> JGICNIKOAID, int NHGDOMMIKNI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x8074FE0", Offset = "0x80743E0", VA = "0x188074FE0")]
	public HOBKOKHAHLA DIMNJIILPGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x80759C0", Offset = "0x8074DC0", VA = "0x1880759C0")]
	public KBCLJOLIADF IHHAJFGBGJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x8075130", Offset = "0x8074530", VA = "0x188075130")]
	public HHEPFLADLLI ELCJBPPMNID([Optional] GBHBOJAPDOA? DPDKJPMBJOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x8075860", Offset = "0x8074C60", VA = "0x188075860")]
	public void HLMELPDNCBH(Func<Guid, bool> NNBAEDGBKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x8075A40", Offset = "0x8074E40", VA = "0x188075A40")]
	public void JKFJHAKAPGD(Func<Guid, bool> GDGOIBPMMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x8075C70", Offset = "0x8075070", VA = "0x188075C70")]
	public Guid LCICLGADGAP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x80754E0", Offset = "0x80748E0", VA = "0x1880754E0")]
	public void GENIAJMPFDF(Guid LGMEGFGHALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x8074EA0", Offset = "0x80742A0", VA = "0x188074EA0")]
	public void DHGJHFBIPEG(EPOGGLOBAKG BEFMIFGMDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x80755F0", Offset = "0x80749F0", VA = "0x1880755F0")]
	public void GFDFDHMHGGA(string MMBPFNIMCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x36CAD50", Offset = "0x36CA150", VA = "0x1836CAD50")]
	private T EIPAMIOLDNO<T>(T FFOEEMKIKJO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x8074E50", Offset = "0x8074250", VA = "0x188074E50")]
	public void CFNEENJJHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x36CAAA0", Offset = "0x36C9EA0", VA = "0x1836CAAA0")]
	[CompilerGenerated]
	internal static string AJIOIOHFPCK<T>(byte[] DHHEGLJJIIE, int NKOOKMNGKGJ, EAOAKPBOJIO<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal sealed class FDJFIOEGONE : EBHOBHMGDHC
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class MICPADCFGHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public MICPADCFGHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x80785D0", Offset = "0x80779D0", VA = "0x1880785D0")]
		internal object NEKAPODGPIO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct GCDIKCFGGDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public FDJFIOEGONE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private OLGIGMIMIFN <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private KBCLJOLIADF <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x806B950", Offset = "0x806AD50", VA = "0x18806B950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x806C2A0", Offset = "0x806B6A0", VA = "0x18806C2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct COLIAPEMDMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public FDJFIOEGONE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private TaskAwaiter<IBBAMKLHGAN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x80649F0", Offset = "0x8063DF0", VA = "0x1880649F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x8065130", Offset = "0x8064530", VA = "0x188065130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct LCHCIDBJKKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public FDJFIOEGONE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private TaskAwaiter<GKGFGBABKAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x8076C40", Offset = "0x8076040", VA = "0x188076C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x8076F50", Offset = "0x8076350", VA = "0x188076F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class EAKEMFEJIFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public OLGIGMIMIFN presence;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public EAKEMFEJIFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x8065AD0", Offset = "0x8064ED0", VA = "0x188065AD0")]
		internal object DKNNNBALKFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private static readonly GBHBOJAPDOA MLIAFKELENI;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private static readonly GBHBOJAPDOA KMECBCCNCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly NAMDFBDBPAO GNMBKDKPGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private readonly ELMNGLJGGCK PJHPPMJLCEE;

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x806AF90", Offset = "0x806A390", VA = "0x18806AF90")]
	public FDJFIOEGONE(NAMDFBDBPAO GNMBKDKPGHM, ELMNGLJGGCK PJHPPMJLCEE, Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, IGPBPPCMANO GHLBPFNFNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x806A980", Offset = "0x8069D80", VA = "0x18806A980", Slot = "7")]
	[AsyncStateMachine(typeof(GCDIKCFGGDA))]
	protected override Task FGKIGELDKPJ(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x806ADB0", Offset = "0x806A1B0", VA = "0x18806ADB0")]
	[AsyncStateMachine(typeof(COLIAPEMDMC))]
	private Task KNILGLGOFCL(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x806AAC0", Offset = "0x8069EC0", VA = "0x18806AAC0")]
	[AsyncStateMachine(typeof(LCHCIDBJKKG))]
	private Task<int> IIFFFBLMCCM(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x806ABD0", Offset = "0x8069FD0", VA = "0x18806ABD0")]
	private OLGIGMIMIFN JAAEMFGPEGO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal class DPKNKAFHJIP : EBHOBHMGDHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct ONJNKFMNAFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public DPKNKAFHJIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter<DHJBDKCLFJF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x807B2A0", Offset = "0x807A6A0", VA = "0x18807B2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x807BC50", Offset = "0x807B050", VA = "0x18807BC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly int OBCGCNPOFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly CKKDNBIBBCP CEDHNEPJPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public readonly long GGHGNFHHKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public readonly long LAKPJKFHFDN;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public DHJBDKCLFJF KOCLMOEIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x998640", Offset = "0x997A40", VA = "0x180998640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x9985E0", Offset = "0x9979E0", VA = "0x1809985E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x80659A0", Offset = "0x8064DA0", VA = "0x1880659A0")]
	public DPKNKAFHJIP(Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, IGPBPPCMANO GHLBPFNFNJA, int OBCGCNPOFOC, CKKDNBIBBCP CEDHNEPJPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x8065880", Offset = "0x8064C80", VA = "0x188065880", Slot = "7")]
	[AsyncStateMachine(typeof(ONJNKFMNAFF))]
	protected override Task FGKIGELDKPJ(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal abstract class GGHIOHHDEEH : EBHOBHMGDHC
{
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class NLKFKKEKCMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public GGHIOHHDEEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public KBPMFLBCKDN playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public NLKFKKEKCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x8078760", Offset = "0x8077B60", VA = "0x188078760")]
		internal Task BEAHNHJKHLB(APGKENHKANG<string>.EEEKGBDKLHP postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x80787A0", Offset = "0x8077BA0", VA = "0x1880787A0")]
		internal object MMKOAHILAHI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct NNNMEKPKFCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public GGHIOHHDEEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private NLKFKKEKCMK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x8078830", Offset = "0x8077C30", VA = "0x188078830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x8079000", Offset = "0x8078400", VA = "0x188079000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct FHFBNGNBPFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public KBPMFLBCKDN playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public GGHIOHHDEEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x806B1A0", Offset = "0x806A5A0", VA = "0x18806B1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x806B750", Offset = "0x806AB50", VA = "0x18806B750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x806D600", Offset = "0x806CA00", VA = "0x18806D600")]
	public GGHIOHHDEEH(Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, IGPBPPCMANO GHLBPFNFNJA, string KGOFODEJJEL, PPKFOIPGIIE CMJLDNADNMP, bool OPKMAOKOPPN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x806D380", Offset = "0x806C780", VA = "0x18806D380", Slot = "7")]
	[AsyncStateMachine(typeof(NNNMEKPKFCN))]
	protected override Task FGKIGELDKPJ(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task PGMNAIFDGJK(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x806D4C0", Offset = "0x806C8C0", VA = "0x18806D4C0")]
	[AsyncStateMachine(typeof(FHFBNGNBPFO))]
	private Task NKFCLHPLOMM(IDisposable IMEJOJAEBIK, KBPMFLBCKDN FCOFLPFNFCO, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal class PMAPKCJFKPO : EBHOBHMGDHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct KBGCJBJNBCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public PMAPKCJFKPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private TaskAwaiter<PLFCMNGIAGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x80743D0", Offset = "0x80737D0", VA = "0x1880743D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x8074960", Offset = "0x8073D60", VA = "0x188074960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private readonly JFCACKFPDGD GIHOEMBHLDB;

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x807C500", Offset = "0x807B900", VA = "0x18807C500")]
	public PMAPKCJFKPO(Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, IGPBPPCMANO GHLBPFNFNJA, JFCACKFPDGD GIHOEMBHLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x807C420", Offset = "0x807B820", VA = "0x18807C420", Slot = "6")]
	protected override string HBICNKDHNPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x807C300", Offset = "0x807B700", VA = "0x18807C300", Slot = "7")]
	[AsyncStateMachine(typeof(KBGCJBJNBCA))]
	protected override Task FGKIGELDKPJ(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal abstract class EBHOBHMGDHC : EEKKCJKNBCB
{
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	public delegate Task KJIBKPEMFLN(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class HJFNKDJILPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public APGKENHKANG<string>.EEEKGBDKLHP operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public EBHOBHMGDHC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public HJFNKDJILPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x806EDB0", Offset = "0x806E1B0", VA = "0x18806EDB0")]
		internal Task MFBLKHJDHJI(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class FPLIAEFAKIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public HJFNKDJILPP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public FPLIAEFAKIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x806B7B0", Offset = "0x806ABB0", VA = "0x18806B7B0")]
		internal object LMIDEPIDMLC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct LNNIBKIFJPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public EBHOBHMGDHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public Func<EBHOBHMGDHC, APGKENHKANG<string>.EEEKGBDKLHP, KKJJOKHIFIF> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private HJFNKDJILPP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private KKJJOKHIFIF <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x8077160", Offset = "0x8076560", VA = "0x188077160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x80782B0", Offset = "0x80776B0", VA = "0x1880782B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct JKAPPBOHHEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x8071A40", Offset = "0x8070E40", VA = "0x188071A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x80724E0", Offset = "0x80718E0", VA = "0x1880724E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct JEPODJMBDPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public EBHOBHMGDHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x8071680", Offset = "0x8070A80", VA = "0x188071680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x80719E0", Offset = "0x8070DE0", VA = "0x1880719E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public readonly Guid FDCJMIFHPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public readonly ByteString CGMMDBBNEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public readonly IGPBPPCMANO MNAIDKMHBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	protected readonly string GDEKKBDFCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	private readonly HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	private readonly bool OPKMAOKOPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	private readonly Queue<KJIBKPEMFLN> BBGODPFOCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private readonly FAHCCCHCJAA GONCJJIELEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	private readonly PPKFOIPGIIE CMJLDNADNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private bool MHIDKAHJIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public CPPDEEJEANJ DOMLENPLJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public CPPDEEJEANJ PGHOEKCJDND;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public HENFMPPFGFG KBLPAMDIOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x9943F0", Offset = "0x9937F0", VA = "0x1809943F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public BEHHGOBGNKL LDPIMCPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x80666A0", Offset = "0x8065AA0", VA = "0x1880666A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public BGLHDLEKEGE MDDCDEOBBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x8066270", Offset = "0x8065670", VA = "0x188066270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public CDCAHPMDKLI JLEJGCAJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x8066300", Offset = "0x8065700", VA = "0x188066300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event ABEIMCMKCDE AMAEMNCEHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x80662E0", Offset = "0x80656E0", VA = "0x1880662E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x8065D60", Offset = "0x8065160", VA = "0x188065D60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x8066770", Offset = "0x8065B70", VA = "0x188066770")]
	protected EBHOBHMGDHC(Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, IGPBPPCMANO GHLBPFNFNJA, string KGOFODEJJEL, PPKFOIPGIIE CMJLDNADNMP, bool OPKMAOKOPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x8066000", Offset = "0x8065400", VA = "0x188066000", Slot = "6")]
	protected virtual string HBICNKDHNPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x8065D80", Offset = "0x8065180", VA = "0x188065D80")]
	public void CODPPKCEDFG(KJIBKPEMFLN IJBCOFDMABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x80662C0", Offset = "0x80656C0", VA = "0x1880662C0")]
	protected void JKBIDDHPGHN(float ICNDIBLBLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x8065C10", Offset = "0x8065010", VA = "0x188065C10")]
	[AsyncStateMachine(typeof(LNNIBKIFJPM))]
	public Task AMNMBKBGPIL(CancellationToken LMNHDKIFBOH, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, [Optional] Func<EBHOBHMGDHC, APGKENHKANG<string>.EEEKGBDKLHP, KKJJOKHIFIF> FONIOECLIFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x8065DE0", Offset = "0x80651E0", VA = "0x188065DE0")]
	[AsyncStateMachine(typeof(JKAPPBOHHEB))]
	private static Task GCDENDIMLBP(Func<CancellationToken, Task> IKLEOOFHJNL, Func<CancellationToken, Task> LKIKIAIODNC, CancellationToken BOHHBCNKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x8066400", Offset = "0x8065800", VA = "0x188066400")]
	private void MMPMEELBBMO(bool JKLFEMENKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x8066040", Offset = "0x8065440", VA = "0x188066040")]
	private void HBPNJEPPPMJ(KKJJOKHIFIF NHOEKMCOCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task FGKIGELDKPJ(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x8066580", Offset = "0x8065980", VA = "0x188066580")]
	[AsyncStateMachine(typeof(JEPODJMBDPH))]
	private Task NFGPEBKEPFI(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x80666F0", Offset = "0x8065AF0", VA = "0x1880666F0")]
	public EPOGGLOBAKG PIDBMFDFONG(EALLHFNFBPD MDODFHEHHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x8065F10", Offset = "0x8065310", VA = "0x188065F10")]
	[CompilerGenerated]
	private Task GHOICFBMOJL(CancellationToken OOLNPDLPIEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x8066380", Offset = "0x8065780", VA = "0x188066380")]
	[CompilerGenerated]
	private object KGKFDKJKOCL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
internal sealed class PPJIEAJMMNK : GGHIOHHDEEH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct CEPLHNANLBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public PPJIEAJMMNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private BMAMFBAMLOB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private KBCLJOLIADF <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x8062FC0", Offset = "0x80623C0", VA = "0x188062FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x8063730", Offset = "0x8062B30", VA = "0x188063730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private readonly NAMDFBDBPAO IGFBKPMIPEE;

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x807C6F0", Offset = "0x807BAF0", VA = "0x18807C6F0")]
	public PPJIEAJMMNK(Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, NAMDFBDBPAO IGFBKPMIPEE, IGPBPPCMANO GHLBPFNFNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x807C5A0", Offset = "0x807B9A0", VA = "0x18807C5A0", Slot = "8")]
	[AsyncStateMachine(typeof(CEPLHNANLBC))]
	protected override Task PGMNAIFDGJK(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
internal class GGFPIDNIPGL : EBHOBHMGDHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct KNEOGGMMLCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public GGFPIDNIPGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private TaskAwaiter<PLFCMNGIAGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x8076830", Offset = "0x8075C30", VA = "0x188076830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x8076BE0", Offset = "0x8075FE0", VA = "0x188076BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private readonly string HNFLEJGACGP;

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x806D2D0", Offset = "0x806C6D0", VA = "0x18806D2D0")]
	public GGFPIDNIPGL(Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, IGPBPPCMANO GHLBPFNFNJA, string HNFLEJGACGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x806D1C0", Offset = "0x806C5C0", VA = "0x18806D1C0", Slot = "7")]
	[AsyncStateMachine(typeof(KNEOGGMMLCG))]
	protected override Task FGKIGELDKPJ(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal class OCOHBNHLHNM : GGHIOHHDEEH
{
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private sealed class OKCINAGFNGM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000130")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			public AsyncTaskMethodBuilder<EPOGGLOBAKG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public OKCINAGFNGM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			private TaskAwaiter<PLFCMNGIAGA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			private TaskAwaiter<EPOGGLOBAKG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x807D6F0", Offset = "0x807CAF0", VA = "0x18807D6F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x807DBE0", Offset = "0x807CFE0", VA = "0x18807DBE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public OCOHBNHLHNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public HHEPFLADLLI serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public HJGDKKKNFOO roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public HOBKOKHAHLA uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public DCMMCMGKNNK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public OKCINAGFNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x807AEC0", Offset = "0x807A2C0", VA = "0x18807AEC0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<EPOGGLOBAKG> PLNPPENAGIG(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct EPGMHNBDJHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public OCOHBNHLHNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private OKCINAGFNGM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private BMAMFBAMLOB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private KBCLJOLIADF <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private EPOGGLOBAKG <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x80693A0", Offset = "0x80687A0", VA = "0x1880693A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x806A280", Offset = "0x8069680", VA = "0x18806A280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private static readonly GBHBOJAPDOA MLIAFKELENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	private readonly int ALJILABKHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	[CanBeNull]
	private readonly IJHECIBDPGO FBOPDOAKGNF;

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x8079520", Offset = "0x8078920", VA = "0x188079520")]
	public OCOHBNHLHNM(Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, int ALJILABKHFO, IJHECIBDPGO FBOPDOAKGNF, IGPBPPCMANO GHLBPFNFNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x8079330", Offset = "0x8078730", VA = "0x188079330", Slot = "8")]
	[AsyncStateMachine(typeof(EPGMHNBDJHF))]
	protected override Task PGMNAIFDGJK(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x8079230", Offset = "0x8078630", VA = "0x188079230")]
	private void BFDKIADCOFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x8079060", Offset = "0x8078460", VA = "0x188079060")]
	private void BBNOMHPPKIM(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, BMAMFBAMLOB GKBKHGJHGGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal class OGPCJMPMLOG : EBHOBHMGDHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct EOHOHGLENBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public OGPCJMPMLOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private BMAMFBAMLOB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private HLFDOLJKNKL<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private TaskAwaiter<DHJBDKCLFJF> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x8068200", Offset = "0x8067600", VA = "0x188068200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x8069340", Offset = "0x8068740", VA = "0x188069340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private readonly int ALJILABKHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private readonly IJHECIBDPGO FBOPDOAKGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	private Func<PLFCMNGIAGA, PLFCMNGIAGA> EGAFBDKFNFO;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x8079D40", Offset = "0x8079140", VA = "0x188079D40")]
	public OGPCJMPMLOG(Guid FDFDCKJIMBB, HENFMPPFGFG LMJMNPPPAHL, int ALJILABKHFO, IJHECIBDPGO FBOPDOAKGNF, Func<PLFCMNGIAGA, PLFCMNGIAGA> EGAFBDKFNFO, IGPBPPCMANO GHLBPFNFNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x8079C00", Offset = "0x8079000", VA = "0x188079C00", Slot = "7")]
	[AsyncStateMachine(typeof(EOHOHGLENBF))]
	protected override Task FGKIGELDKPJ(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal abstract class LOMGCHGEPFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public readonly EBHOBHMGDHC GOAKAGEIOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public readonly KKJJOKHIFIF BKLNCKFKCDN;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public BEHHGOBGNKL LDPIMCPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x80784C0", Offset = "0x80778C0", VA = "0x1880784C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public CDCAHPMDKLI JLEJGCAJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x8078430", Offset = "0x8077830", VA = "0x188078430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x8078510", Offset = "0x8077910", VA = "0x188078510")]
	protected LOMGCHGEPFF(KKJJOKHIFIF NHOEKMCOCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x8078310", Offset = "0x8077710", VA = "0x188078310")]
	protected void GFDFDHMHGGA(string MMBPFNIMCOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct GFIJHOCNJMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public Dictionary<Guid, List<PHPLHHACNNI>> CLMNFFOPHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public Dictionary<Guid, List<PHPLHHACNNI>> DDOAGPBHENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public Dictionary<Guid, List<PHPLHHACNNI>> LACMFMCIPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public List<Guid> OBGKNNODJAJ;

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x806CBB0", Offset = "0x806BFB0", VA = "0x18806CBB0")]
	public static GFIJHOCNJMG IOLMGDEDCOJ(BEHHGOBGNKL IAPHFNOPBJO, CPPDEEJEANJ OIHFCHECHPE, FEJGNMMNDHD PNEKEJIIDPC)
	{
		return default(GFIJHOCNJMG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal struct GHCMEEJDHHM
{
	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710")]
	public static GHCMEEJDHHM GNHEPACBJCH()
	{
		return default(GHCMEEJDHHM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct LLFJICEIFIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public readonly IBBAMKLHGAN BCEDDHNENJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public readonly GMHIEIPOGED DNJKJFGBJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public readonly Guid? JGICNMOHCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public readonly IReadOnlyCollection<INFPHCDJCLC> BKGEJEKCCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public readonly IReadOnlyCollection<INFPHCDJCLC> NGEAFLLBCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public readonly KKCEGILFGJB JKIDAGFNHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public readonly KKCEGILFGJB LLICHJIMFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public readonly APIECIFOHEN OOCJDIEIEAK;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool NGFPILOHFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x8077020", Offset = "0x8076420", VA = "0x188077020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x80770B0", Offset = "0x80764B0", VA = "0x1880770B0")]
	public LLFJICEIFIE(IBBAMKLHGAN BCEDDHNENJL, GMHIEIPOGED DNJKJFGBJDN, Guid? JGICNMOHCMI, IReadOnlyList<INFPHCDJCLC> BKGEJEKCCOC, IReadOnlyCollection<INFPHCDJCLC> NGEAFLLBCHM, KKCEGILFGJB JKIDAGFNHLP, KKCEGILFGJB LLICHJIMFEF, APIECIFOHEN OOCJDIEIEAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct OJAFMNCCPPC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	private readonly KKJJOKHIFIF NHOEKMCOCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	private readonly Guid LGMEGFGHALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	private bool JKLFEMENKBM;

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x807AC80", Offset = "0x807A080", VA = "0x18807AC80")]
	public static OJAFMNCCPPC LCICLGADGAP(KKJJOKHIFIF NHOEKMCOCFJ)
	{
		return default(OJAFMNCCPPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x10BCF50", Offset = "0x10BC350", VA = "0x1810BCF50")]
	public void HAGDIDHLJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x807AA30", Offset = "0x8079E30", VA = "0x18807AA30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x807ACB0", Offset = "0x807A0B0", VA = "0x18807ACB0")]
	private OJAFMNCCPPC(KKJJOKHIFIF NHOEKMCOCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x807AA40", Offset = "0x8079E40", VA = "0x18807AA40")]
	private void GENIAJMPFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x807A990", Offset = "0x8079D90", VA = "0x18807A990")]
	private Func<Guid, bool> BCELLALGBDD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal class KBCLJOLIADF : LOMGCHGEPFF, EEKKCJKNBCB
{
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	public delegate Task<CPPDEEJEANJ> KGCCGODJLBG(FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN EDBFLAPPGIG, FAHCCCHCJAA ICHECBEBLLL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct OHOJFDKNBNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public NAMDFBDBPAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private OJAFMNCCPPC <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x807A060", Offset = "0x8079460", VA = "0x18807A060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x807A930", Offset = "0x8079D30", VA = "0x18807A930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct CBEBGECOGGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public AsyncTaskMethodBuilder<EPOGGLOBAKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public NAMDFBDBPAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private APGKENHKANG<string>.EEEKGBDKLHP <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x8062A40", Offset = "0x8061E40", VA = "0x188062A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x8062E70", Offset = "0x8062270", VA = "0x188062E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct FAGNANOLENP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public NAMDFBDBPAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private APGKENHKANG<string>.EEEKGBDKLHP <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x806A2E0", Offset = "0x80696E0", VA = "0x18806A2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x806A920", Offset = "0x8069D20", VA = "0x18806A920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class DGFDMDPHFPJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000140")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			public AsyncTaskMethodBuilder<LLFJICEIFIE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public DGFDMDPHFPJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			private LLFJICEIFIE <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			private TaskAwaiter<CPPDEEJEANJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			private TaskAwaiter<LLFJICEIFIE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x807C7A0", Offset = "0x807BBA0", VA = "0x18807C7A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x807CF90", Offset = "0x807C390", VA = "0x18807CF90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000141")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			public AsyncTaskMethodBuilder<FEJGNMMNDHD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			public DGFDMDPHFPJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004FC")]
			private FEJGNMMNDHD <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			private TaskAwaiter<CPPDEEJEANJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			private TaskAwaiter<FEJGNMMNDHD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x807D000", Offset = "0x807C400", VA = "0x18807D000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0x807D680", Offset = "0x807CA80", VA = "0x18807D680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public NAMDFBDBPAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public FAHCCCHCJAA preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public FAHCCCHCJAA downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public LLFJICEIFIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public FAHCCCHCJAA postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public FEJGNMMNDHD phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public PKEEJPANGHO.BNNACOHHJOL <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public DGFDMDPHFPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x80654B0", Offset = "0x80648B0", VA = "0x1880654B0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<LLFJICEIFIE> NMNDFBEOJME(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x8065640", Offset = "0x8064A40", VA = "0x188065640")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<FEJGNMMNDHD> PLIMJNGALLB(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x8065600", Offset = "0x8064A00", VA = "0x188065600")]
		internal void PKLBHGFBDND(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x8065350", Offset = "0x8064750", VA = "0x188065350")]
		internal Task ELNBLOMABLO(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x80651F0", Offset = "0x80645F0", VA = "0x1880651F0")]
		internal Task DFINEDLMAJJ(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct HFCDHJBEBNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public NAMDFBDBPAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private DGFDMDPHFPJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private TaskAwaiter<LLFJICEIFIE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private TaskAwaiter<FEJGNMMNDHD> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x806DC50", Offset = "0x806D050", VA = "0x18806DC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x806E9C0", Offset = "0x806DDC0", VA = "0x18806E9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct BMDMLFAJJHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public FEJGNMMNDHD phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public FAHCCCHCJAA postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private PLDBJHIGINN <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x8061580", Offset = "0x8060980", VA = "0x188061580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x8062690", Offset = "0x8061A90", VA = "0x188062690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct ACMNIAEPCJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x807E7F0", Offset = "0x807DBF0", VA = "0x18807E7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x807EFD0", Offset = "0x807E3D0", VA = "0x18807EFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct EGEJKKELHCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public FAHCCCHCJAA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private APGKENHKANG<string>.EEEKGBDKLHP <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x8084B60", Offset = "0x8083F60", VA = "0x188084B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x80853A0", Offset = "0x80847A0", VA = "0x1880853A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct MBNAIOLMKOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public FAHCCCHCJAA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private APGKENHKANG<string>.EEEKGBDKLHP <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x808DEE0", Offset = "0x808D2E0", VA = "0x18808DEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x808EEA0", Offset = "0x808E2A0", VA = "0x18808EEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct LGLNHLLEAMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public FAHCCCHCJAA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public PLDBJHIGINN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private APGKENHKANG<string>.EEEKGBDKLHP <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x808CA70", Offset = "0x808BE70", VA = "0x18808CA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x808DB80", Offset = "0x808CF80", VA = "0x18808DB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct CNNLAHBJDCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public CPPDEEJEANJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public FAHCCCHCJAA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public FEJGNMMNDHD deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x8082EF0", Offset = "0x80822F0", VA = "0x188082EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8083140", Offset = "0x8082540", VA = "0x188083140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class KPJMGNONFGI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014B")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			public KPJMGNONFGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private IFKKDICMKCC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			private TaskAwaiter<CPPDEEJEANJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x8095F20", Offset = "0x8095320", VA = "0x188095F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x8096550", Offset = "0x8095950", VA = "0x188096550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public FAHCCCHCJAA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public KGCCGODJLBG masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public PLDBJHIGINN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public CPPDEEJEANJ originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public KPJMGNONFGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x808B890", Offset = "0x808AC90", VA = "0x18808B890")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<CPPDEEJEANJ> BHFCNKFCKGH(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct AKEDMKJFPMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public FAHCCCHCJAA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public KGCCGODJLBG masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public PLDBJHIGINN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x8080E70", Offset = "0x8080270", VA = "0x188080E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x8081390", Offset = "0x8080790", VA = "0x188081390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct HPFDHHPCCHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public FAHCCCHCJAA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private CPPDEEJEANJ <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private IEnumerator<CPPDEEJEANJ> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x8088720", Offset = "0x8087B20", VA = "0x188088720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x8088C80", Offset = "0x8088080", VA = "0x188088C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct JMGJJJFNEHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x808AB70", Offset = "0x8089F70", VA = "0x18808AB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x808AE60", Offset = "0x808A260", VA = "0x18808AE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct PMBMOGHHOIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x8095130", Offset = "0x8094530", VA = "0x188095130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x8095360", Offset = "0x8094760", VA = "0x188095360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class ODOJMBAOGCA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000151")]
		private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000578")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000579")]
			public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400057A")]
			public ODOJMBAOGCA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			public FEJGNMMNDHD data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			public FAHCCCHCJAA progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			private TaskAwaiter<CPPDEEJEANJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			private TaskAwaiter<FCNPEFLMCKN> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x80965C0", Offset = "0x80959C0", VA = "0x1880965C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x8097090", Offset = "0x8096490", VA = "0x188097090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public JIGBJIEJJOJ mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public ODOJMBAOGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x80941A0", Offset = "0x80935A0", VA = "0x1880941A0")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<CPPDEEJEANJ> EHNGHGEJLCE(FEJGNMMNDHD data, PLDBJHIGINN _, FAHCCCHCJAA progressTracker, APGKENHKANG<string>.EEEKGBDKLHP stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct MINADENBPKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public FEJGNMMNDHD phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public FAHCCCHCJAA postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private ODOJMBAOGCA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private PLDBJHIGINN <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x808F4A0", Offset = "0x808E8A0", VA = "0x18808F4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x8090370", Offset = "0x808F770", VA = "0x188090370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct GDMFONEDMFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x8086390", Offset = "0x8085790", VA = "0x188086390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x8086790", Offset = "0x8085B90", VA = "0x188086790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct JHLEDGBJHNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public KBCLJOLIADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public FAHCCCHCJAA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private APGKENHKANG<string>.EEEKGBDKLHP <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x808A000", Offset = "0x8089400", VA = "0x18808A000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x808A620", Offset = "0x8089A20", VA = "0x18808A620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private readonly CEGHMOMNMEC MDCHKHELICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private readonly CEGHMOMNMEC APGOJHCGIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private readonly EGBBHHGAGKN BDFIBCDOEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private readonly AJIIKDKENGF LAOGAOKCDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private readonly KMGIEHGOPOH HBACHNLEBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private ProfilerCounterValue<int> APOCJDEKCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private readonly LIJGGIIFNIO LFALINOEJDL;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private HENFMPPFGFG KBLPAMDIOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x8072880", Offset = "0x8071C80", VA = "0x188072880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event ABEIMCMKCDE AMAEMNCEHKG
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x8073490", Offset = "0x8072890", VA = "0x188073490", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x80726A0", Offset = "0x8071AA0", VA = "0x1880726A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x8074100", Offset = "0x8073500", VA = "0x188074100")]
	public KBCLJOLIADF(KKJJOKHIFIF NHOEKMCOCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x8072D30", Offset = "0x8072130", VA = "0x188072D30")]
	[AsyncStateMachine(typeof(OHOJFDKNBNK))]
	public Task HFOGDPNAGCE(NAMDFBDBPAO ANMDEHLLLBJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x8073250", Offset = "0x8072650", VA = "0x188073250")]
	[AsyncStateMachine(typeof(CBEBGECOGGG))]
	private Task<EPOGGLOBAKG> ILGGABHFOMD(NAMDFBDBPAO ANMDEHLLLBJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x80738F0", Offset = "0x8072CF0", VA = "0x1880738F0")]
	[AsyncStateMachine(typeof(FAGNANOLENP))]
	private Task MFJHMACMAJB(NAMDFBDBPAO ANMDEHLLLBJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x8072FC0", Offset = "0x80723C0", VA = "0x188072FC0")]
	[AsyncStateMachine(typeof(HFCDHJBEBNL))]
	private Task ICIIMFPCGCI(NAMDFBDBPAO ANMDEHLLLBJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken EKEDFDDDCCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x8073A30", Offset = "0x8072E30", VA = "0x188073A30")]
	[AsyncStateMachine(typeof(BMDMLFAJJHO))]
	private Task NCICFOGOAFC(FEJGNMMNDHD EEGEGAOKGGE, FAHCCCHCJAA CAGOMMOJGKI, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken CJFLDHPBPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x80737E0", Offset = "0x8072BE0", VA = "0x1880737E0")]
	[AsyncStateMachine(typeof(ACMNIAEPCJH))]
	private Task MBEBDBCGGFK(APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x80734F0", Offset = "0x80728F0", VA = "0x1880734F0")]
	[AsyncStateMachine(typeof(EGEJKKELHCO))]
	private Task KKKKIFBNHAA(FEJGNMMNDHD HPMNBNLACCC, FAHCCCHCJAA ICHECBEBLLL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x8073640", Offset = "0x8072A40", VA = "0x188073640")]
	[AsyncStateMachine(typeof(MBNAIOLMKOM))]
	private Task<CPPDEEJEANJ> LDFONFHCDNC(FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, FAHCCCHCJAA ICHECBEBLLL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x8073D30", Offset = "0x8073130", VA = "0x188073D30")]
	[AsyncStateMachine(typeof(LGLNHLLEAMH))]
	private Task<CPPDEEJEANJ> NJAOFHIFLBE(FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, FAHCCCHCJAA ICHECBEBLLL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x8072700", Offset = "0x8071B00", VA = "0x188072700")]
	[AsyncStateMachine(typeof(CNNLAHBJDCF))]
	private Task<CPPDEEJEANJ> EBONNFEBGLB(CPPDEEJEANJ OIHFCHECHPE, FEJGNMMNDHD PNEKEJIIDPC, FAHCCCHCJAA ICHECBEBLLL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH, bool JAPCKMIOHHD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x8074010", Offset = "0x8073410", VA = "0x188074010")]
	private bool PKJCHBGDPEM(FEJGNMMNDHD EEGEGAOKGGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x8072B90", Offset = "0x8071F90", VA = "0x188072B90")]
	[AsyncStateMachine(typeof(AKEDMKJFPMP))]
	protected Task<CPPDEEJEANJ> GGFCDMKIDIN(FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, FAHCCCHCJAA ICHECBEBLLL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH, KGCCGODJLBG CHHCCBOMPAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x8073100", Offset = "0x8072500", VA = "0x188073100")]
	[AsyncStateMachine(typeof(HPFDHHPCCHI))]
	private Task IHAMMCJOPLO(FEJGNMMNDHD HPMNBNLACCC, FAHCCCHCJAA ICHECBEBLLL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x8072F70", Offset = "0x8072370", VA = "0x188072F70")]
	private void HPNGMDGLJBM(CPPDEEJEANJ EBDPJJJPIOL, FAHCCCHCJAA ICHECBEBLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x8072A00", Offset = "0x8071E00", VA = "0x188072A00")]
	private void GANOBHCKGKM(CPPDEEJEANJ NBOOECJLKFL, [Out] CPPDEEJEANJ IAKMBNBLJPH, [Out] CPPDEEJEANJ LIPAJOPLKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x80726C0", Offset = "0x8071AC0", VA = "0x1880726C0")]
	private Task<LLFJICEIFIE> CBBODNHLDHH(NAMDFBDBPAO ANMDEHLLLBJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x80734B0", Offset = "0x80728B0", VA = "0x1880734B0")]
	private Task<FEJGNMMNDHD> JNEDEGLLDMJ(LLFJICEIFIE HPMNBNLACCC, PKEEJPANGHO.BNNACOHHJOL ELOKFHOLKDI, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x8072A40", Offset = "0x8071E40", VA = "0x188072A40")]
	[AsyncStateMachine(typeof(JMGJJJFNEHM))]
	private Task GAPINMNLIAF(FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH, bool LIJMPIPGMKC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x8072E80", Offset = "0x8072280", VA = "0x188072E80")]
	[AsyncStateMachine(typeof(PMBMOGHHOIO))]
	private Task HMAMNFDLHCH(FEJGNMMNDHD HPMNBNLACCC, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x8073460", Offset = "0x8072860", VA = "0x188073460")]
	private Task JDNDPPLOKNH(FEJGNMMNDHD HPMNBNLACCC, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x80737A0", Offset = "0x8072BA0", VA = "0x1880737A0")]
	private Task LMDAPONBKMC(FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x8072680", Offset = "0x8071A80", VA = "0x188072680")]
	private Task BEFLGKKDGHC(FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x80737C0", Offset = "0x8072BC0", VA = "0x1880737C0")]
	private Task MAOLJHKFAMP(FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x8072D20", Offset = "0x8072120", VA = "0x188072D20")]
	private static Task GMPHIAENNMM(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x8072540", Offset = "0x8071940", VA = "0x188072540")]
	private Task AEKHDCNCMNC(FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x8073EB0", Offset = "0x80732B0", VA = "0x188073EB0")]
	private Task NOBACCFKLIF(FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x8073CE0", Offset = "0x80730E0", VA = "0x188073CE0")]
	private void NGEHEJECIDB(NAMDFBDBPAO ANMDEHLLLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x80733B0", Offset = "0x80727B0", VA = "0x1880733B0")]
	public void IPLNDKEPOAC(long OLGEMOMILNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
	private static void NIICOCEJFGF(IBBAMKLHGAN BCEDDHNENJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x80728B0", Offset = "0x8071CB0", VA = "0x1880728B0")]
	[AsyncStateMachine(typeof(MINADENBPKL))]
	private Task FLPOJHIJJGO(FEJGNMMNDHD EEGEGAOKGGE, FAHCCCHCJAA CAGOMMOJGKI, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken CJFLDHPBPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x8073ED0", Offset = "0x80732D0", VA = "0x188073ED0")]
	[AsyncStateMachine(typeof(GDMFONEDMFA))]
	private Task OFLCAHFBICA(FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x8072560", Offset = "0x8071960", VA = "0x188072560")]
	private static AHNPMJGNJNJ AGBIABABLPH(FEJGNMMNDHD PNEKEJIIDPC)
	{
		return default(AHNPMJGNJNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x8073B80", Offset = "0x8072F80", VA = "0x188073B80")]
	[AsyncStateMachine(typeof(JHLEDGBJHNG))]
	private Task<CPPDEEJEANJ> NDMODBJLFAB(FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, FAHCCCHCJAA ICHECBEBLLL, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
	private void IPGKCCEKEJG(CPPDEEJEANJ OJFCACKMOFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct PDHALOGKABI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059E")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400059F")]
	private FEJGNMMNDHD HPMNBNLACCC;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private BEHHGOBGNKL LDPIMCPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x8094600", Offset = "0x8093A00", VA = "0x188094600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x8094300", Offset = "0x8093700", VA = "0x188094300")]
	public static Task AMNMBKBGPIL(HENFMPPFGFG LMJMNPPPAHL, FEJGNMMNDHD HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x80943E0", Offset = "0x80937E0", VA = "0x1880943E0")]
	private void AMNMBKBGPIL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct EKGCPPJHFLO
{
	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x8085400", Offset = "0x8084800", VA = "0x188085400")]
	public static Task AMNMBKBGPIL(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct POBJNOKPJGO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct MHOONIPEGOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private APGKENHKANG<string>.EEEKGBDKLHP <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x808EF10", Offset = "0x808E310", VA = "0x18808EF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x808F440", Offset = "0x808E840", VA = "0x18808F440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x80953C0", Offset = "0x80947C0", VA = "0x1880953C0")]
	[AsyncStateMachine(typeof(MHOONIPEGOM))]
	public static Task AMNMBKBGPIL(KKJJOKHIFIF NHOEKMCOCFJ, FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct GEDMJOHOMED
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct NBHAKOEJGMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public PLDBJHIGINN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private HENFMPPFGFG <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private BEHHGOBGNKL <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private CPPDEEJEANJ <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private IFKKDICMKCC <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private List<(PersistenceView, AJANKEAEBKF)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private AJANKEAEBKF <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x8090AE0", Offset = "0x808FEE0", VA = "0x188090AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x80917C0", Offset = "0x8090BC0", VA = "0x1880917C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x80867F0", Offset = "0x8085BF0", VA = "0x1880867F0")]
	[AsyncStateMachine(typeof(NBHAKOEJGMK))]
	public static Task AMNMBKBGPIL(KKJJOKHIFIF NHOEKMCOCFJ, FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x8086940", Offset = "0x8085D40", VA = "0x188086940")]
	private static void OIJCFOGEAJK(PersistenceView EKLEPCBGCMK, AJANKEAEBKF LLCPKAOMDKB, FEJGNMMNDHD HPMNBNLACCC, CPPDEEJEANJ OIHFCHECHPE, bool PKDAIMKHECK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct BMDNKCDBAPG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct AKMDJMPECKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public HENFMPPFGFG roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private IFKKDICMKCC <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x8081400", Offset = "0x8080800", VA = "0x188081400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x8081A20", Offset = "0x8080E20", VA = "0x188081A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x8081FD0", Offset = "0x80813D0", VA = "0x188081FD0")]
	[AsyncStateMachine(typeof(AKMDJMPECKE))]
	public static Task AMNMBKBGPIL(HENFMPPFGFG LMJMNPPPAHL, FEJGNMMNDHD HPMNBNLACCC, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct HGDOANGMHBG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct LDPDNBPMKKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public HENFMPPFGFG roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x808C800", Offset = "0x808BC00", VA = "0x18808C800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x808CA10", Offset = "0x808BE10", VA = "0x18808CA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class GEMKBMFJJJB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000161")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005D3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D4")]
			public APGKENHKANG<string>.EEEKGBDKLHP timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D5")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D6")]
			public GEMKBMFJJJB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x8097420", Offset = "0x8096820", VA = "0x188097420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x80977B0", Offset = "0x8096BB0", VA = "0x1880977B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public GEMKBMFJJJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x8086B40", Offset = "0x8085F40", VA = "0x188086B40")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task NOHIFMNCGAO(APGKENHKANG<string>.EEEKGBDKLHP timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct AIJFBBOPIKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public HGDOANGMHBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private IFKKDICMKCC <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x807F2C0", Offset = "0x807E6C0", VA = "0x18807F2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x807FED0", Offset = "0x807F2D0", VA = "0x18807FED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class EOKCKGBMKPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public CECIAOOGNBJ version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public EOKCKGBMKPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x8085590", Offset = "0x8084990", VA = "0x188085590")]
		internal object LHDFAGFCDMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x80854E0", Offset = "0x80848E0", VA = "0x1880854E0")]
		internal object GPOJFHMIGPA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private FEJGNMMNDHD HPMNBNLACCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private KKJJOKHIFIF NHOEKMCOCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private bool LIJMPIPGMKC;

	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private static readonly ByteString BAFEBLDBIPA;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private BEHHGOBGNKL LDPIMCPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x8088640", Offset = "0x8087A40", VA = "0x188088640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private CDCAHPMDKLI JLEJGCAJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x80885A0", Offset = "0x80879A0", VA = "0x1880885A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x8087C30", Offset = "0x8087030", VA = "0x188087C30")]
	[AsyncStateMachine(typeof(LDPDNBPMKKL))]
	public static Task AMNMBKBGPIL(HENFMPPFGFG LMJMNPPPAHL, FEJGNMMNDHD HPMNBNLACCC, KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH, bool LIJMPIPGMKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x8087B00", Offset = "0x8086F00", VA = "0x188087B00")]
	[AsyncStateMachine(typeof(AIJFBBOPIKP))]
	private Task AMNMBKBGPIL(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x8087D80", Offset = "0x8087180", VA = "0x188087D80")]
	private void BFKEHEIPFBG([NotNull] AOIFKBLFGKD KLBPAEOBMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x8088560", Offset = "0x8087960", VA = "0x188088560")]
	private bool COCAPJOKCHF(CECIAOOGNBJ IOFNCNFBMGK, AOIFKBLFGKD KLBPAEOBMAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal struct CGLKDPOJEME
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct LAAJLPFHAFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public AsyncTaskMethodBuilder<FEJGNMMNDHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public CGLKDPOJEME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public PKEEJPANGHO.BNNACOHHJOL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private APGKENHKANG<string>.EEEKGBDKLHP <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter<IReadOnlyCollection<INFPHCDJCLC>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private TaskAwaiter<(KGPHFOFOMPJ<MJBEDDENEDM, ADGPAJEIFGP>, KGPHFOFOMPJ<PPEBEAEDJID<AOIFKBLFGKD>, ADGPAJEIFGP>, KGPHFOFOMPJ<PPEBEAEDJID<NFAAFKCENHI>, ADGPAJEIFGP>, KGPHFOFOMPJ<PPEBEAEDJID<IEnumerable<LLDEBPMCGFM>>, ADGPAJEIFGP>, KGPHFOFOMPJ<PPEBEAEDJID<OADNLLEBHMI>, ADGPAJEIFGP>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x808B9B0", Offset = "0x808ADB0", VA = "0x18808B9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x808C790", Offset = "0x808BB90", VA = "0x18808C790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct HAJOLELEFEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<MJBEDDENEDM, ADGPAJEIFGP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public APGKENHKANG<string>.EEEKGBDKLHP downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public CGLKDPOJEME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public IReadOnlyCollection<INFPHCDJCLC> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public IReadOnlyCollection<INFPHCDJCLC> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public PKEEJPANGHO.BNNACOHHJOL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		private TaskAwaiter<KGPHFOFOMPJ<MJBEDDENEDM, ADGPAJEIFGP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x8087430", Offset = "0x8086830", VA = "0x188087430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x8087A90", Offset = "0x8086E90", VA = "0x188087A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private GLNNEJMAOCG<KKCEGILFGJB, NFAAFKCENHI> NMJLEPIBEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	private GLNNEJMAOCG<KKCEGILFGJB, AOIFKBLFGKD> NBFDPHANPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	private GLNNEJMAOCG<APIECIFOHEN, IEnumerable<LLDEBPMCGFM>> IAFCAIPLCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	private GLNNEJMAOCG<long, OADNLLEBHMI> AEDPGNCCDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	private KFJDGJEGIOM KNENEEOMHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	private IBBAMKLHGAN BCEDDHNENJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	private GMHIEIPOGED DNJKJFGBJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private Guid? JGICNMOHCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private IReadOnlyCollection<INFPHCDJCLC> BKGEJEKCCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private Task<IReadOnlyCollection<INFPHCDJCLC>> NJHDMFNCGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	private KKCEGILFGJB JKIDAGFNHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	private KKCEGILFGJB LLICHJIMFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private KKCEGILFGJB? IANBAGIGNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	private APIECIFOHEN OOCJDIEIEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB;

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x80828B0", Offset = "0x8081CB0", VA = "0x1880828B0")]
	public static Task<FEJGNMMNDHD> MDOFEFHDGHD(HENFMPPFGFG LMJMNPPPAHL, [In] LLFJICEIFIE HPMNBNLACCC, PKEEJPANGHO.BNNACOHHJOL ELOKFHOLKDI, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x80824D0", Offset = "0x80818D0", VA = "0x1880824D0")]
	[AsyncStateMachine(typeof(LAAJLPFHAFG))]
	private Task<FEJGNMMNDHD> AMNMBKBGPIL(PKEEJPANGHO.BNNACOHHJOL ELOKFHOLKDI, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x8082680", Offset = "0x8081A80", VA = "0x188082680")]
	[AsyncStateMachine(typeof(HAJOLELEFEC))]
	private Task<KGPHFOFOMPJ<MJBEDDENEDM, ADGPAJEIFGP>> BDELOHHCEOG(Guid? JGICNMOHCMI, IReadOnlyCollection<INFPHCDJCLC> BKGEJEKCCOC, IReadOnlyCollection<INFPHCDJCLC> NGEAFLLBCHM, long? MIFADOBCMAC, long? OFAOCKBMEGP, PKEEJPANGHO.BNNACOHHJOL ELOKFHOLKDI, APGKENHKANG<string>.EEEKGBDKLHP DBPNBHHJBHL, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct MIPGGNGAMPA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct DJHBKLBNGCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public AsyncTaskMethodBuilder<LLFJICEIFIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public MIPGGNGAMPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private APGKENHKANG<string>.EEEKGBDKLHP <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private TaskAwaiter<LLFJICEIFIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x80840C0", Offset = "0x80834C0", VA = "0x1880840C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x8084510", Offset = "0x8083910", VA = "0x188084510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct PJBCMJBALNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public AsyncTaskMethodBuilder<LLFJICEIFIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public MIPGGNGAMPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private TaskAwaiter<LLFJICEIFIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x8094C40", Offset = "0x8094040", VA = "0x188094C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x80950C0", Offset = "0x80944C0", VA = "0x1880950C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class BLBMEDMJHGJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		private struct <<FetchRoomLoadDetails>g__getRoomSaveData|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000633")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000634")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000635")]
			public BLBMEDMJHGJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000636")]
			private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000637")]
			private TaskAwaiter<MJFIDHLLGBC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000638")]
			private TaskAwaiter<GKGFGBABKAH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x8095500", Offset = "0x8094900", VA = "0x188095500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x8095EC0", Offset = "0x80952C0", VA = "0x188095EC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public HMNAEIFDIFE roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public BEHHGOBGNKL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public KKCEGILFGJB superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public KKCEGILFGJB subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public IReadOnlyList<INFPHCDJCLC> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public IReadOnlyList<INFPHCDJCLC> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public IBBAMKLHGAN roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public BLBMEDMJHGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xDB0490", Offset = "0xDAF890", VA = "0x180DB0490")]
		internal bool CEHOOAKAKBE(GMHIEIPOGED sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x8081F00", Offset = "0x8081300", VA = "0x188081F00")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task PIKIONADBML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x8081D00", Offset = "0x8081100", VA = "0x188081D00")]
		internal Task<APIECIFOHEN> FDINHINCFDG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct NJFPBLLLEMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public AsyncTaskMethodBuilder<LLFJICEIFIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public HMNAEIFDIFE roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public BEHHGOBGNKL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public KKCEGILFGJB superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private BLBMEDMJHGJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private GMHIEIPOGED <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private Task<APIECIFOHEN> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private TaskAwaiter<IBBAMKLHGAN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private TaskAwaiter<APIECIFOHEN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x8092840", Offset = "0x8091C40", VA = "0x188092840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x80937F0", Offset = "0x8092BF0", VA = "0x1880937F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private BEHHGOBGNKL IAPHFNOPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	private EGBBHHGAGKN BDFIBCDOEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000610")]
	private HMNAEIFDIFE FPEOBPEELJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	private APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private long MIFADOBCMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	private long JCNNPHFBOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	private long KFJJHJMHDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private string EFBGJFMCDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private KKCEGILFGJB BFMEHFLBKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private Guid MKCDIKOMEAO;

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x8090890", Offset = "0x808FC90", VA = "0x188090890")]
	public static Task<LLFJICEIFIE> MDOFEFHDGHD(HENFMPPFGFG LMJMNPPPAHL, NAMDFBDBPAO ANMDEHLLLBJ, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x80903D0", Offset = "0x808F7D0", VA = "0x1880903D0")]
	[AsyncStateMachine(typeof(DJHBKLBNGCF))]
	private Task<LLFJICEIFIE> AMNMBKBGPIL(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x8090520", Offset = "0x808F920", VA = "0x188090520")]
	[AsyncStateMachine(typeof(PJBCMJBALNK))]
	private Task<LLFJICEIFIE> CBBODNHLDHH(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x8090690", Offset = "0x808FA90", VA = "0x188090690")]
	[AsyncStateMachine(typeof(NJFPBLLLEMG))]
	private static Task<LLFJICEIFIE> CBBODNHLDHH(BEHHGOBGNKL IAPHFNOPBJO, HMNAEIFDIFE FPEOBPEELJF, long MIFADOBCMAC, long JCNNPHFBOMP, long KFJJHJMHDOB, string EFBGJFMCDKM, KKCEGILFGJB BFMEHFLBKKN, Guid MKCDIKOMEAO, CancellationToken LMNHDKIFBOH, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x8090860", Offset = "0x808FC60", VA = "0x188090860")]
	private void LJAIHCPKFMN(IBBAMKLHGAN BCEDDHNENJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
internal struct KHOOBDAKPAO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct PILJOLPOOME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public KHOOBDAKPAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x8094650", Offset = "0x8093A50", VA = "0x188094650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x8094BE0", Offset = "0x8093FE0", VA = "0x188094BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064C")]
	private BEHHGOBGNKL IAPHFNOPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400064D")]
	private FEJGNMMNDHD HPMNBNLACCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400064E")]
	private APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private float NECLKMCCDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private float DHDMPBNLPAG;

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x808B120", Offset = "0x808A520", VA = "0x18808B120")]
	public static Task CHFKHDLNPND(HENFMPPFGFG LMJMNPPPAHL, FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x808AEC0", Offset = "0x808A2C0", VA = "0x18808AEC0")]
	[AsyncStateMachine(typeof(PILJOLPOOME))]
	public Task AMNMBKBGPIL(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x808AFE0", Offset = "0x808A3E0", VA = "0x18808AFE0")]
	private static void BGGNIDBDMPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x808B2C0", Offset = "0x808A6C0", VA = "0x18808B2C0")]
	private void JEJHEAHHMAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x808B440", Offset = "0x808A840", VA = "0x18808B440")]
	private static float PLCAELMDBCK(BEHHGOBGNKL IAPHFNOPBJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x808B420", Offset = "0x808A820", VA = "0x18808B420")]
	private static float MFCPJOMBOEJ()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000170")]
internal struct MBJPOMJEPGB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct IKDDEFNIEGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public KKJJOKHIFIF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private EBHOBHMGDHC <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private HENFMPPFGFG <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private NEKEBJFHDJO.GLLCLBOHLDM <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x8088CE0", Offset = "0x80880E0", VA = "0x188088CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x8089500", Offset = "0x8088900", VA = "0x188089500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct CEHPLELBBFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x80820F0", Offset = "0x80814F0", VA = "0x1880820F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8082420", Offset = "0x8081820", VA = "0x188082420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x808DC70", Offset = "0x808D070", VA = "0x18808DC70")]
	[AsyncStateMachine(typeof(IKDDEFNIEGO))]
	public static Task AMNMBKBGPIL(KKJJOKHIFIF NHOEKMCOCFJ, FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x808DE70", Offset = "0x808D270", VA = "0x18808DE70")]
	private static Task<EPOGGLOBAKG> CPBEDOIBKNP(KKJJOKHIFIF NHOEKMCOCFJ, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x808DDB0", Offset = "0x808D1B0", VA = "0x18808DDB0")]
	[AsyncStateMachine(typeof(CEHPLELBBFL))]
	private static Task BDHKNJBDGNL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal struct AIEAPCNIPJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct JGFNECAPHPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public AIEAPCNIPJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x80898F0", Offset = "0x8088CF0", VA = "0x1880898F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x8089FA0", Offset = "0x80893A0", VA = "0x188089FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class DIJFPHLAAPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public DIJFPHLAAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x8084040", Offset = "0x8083440", VA = "0x188084040")]
		internal object ONHCMHEPCNJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct JHPEADIODNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public AIEAPCNIPJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x808A690", Offset = "0x8089A90", VA = "0x18808A690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x808AB10", Offset = "0x8089F10", VA = "0x18808AB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private bool IDMFCMLEMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private CancellationToken LMNHDKIFBOH;

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x807F120", Offset = "0x807E520", VA = "0x18807F120")]
	public static Task GGENPDJMBBE(HENFMPPFGFG LMJMNPPPAHL, bool IDMFCMLEMKF, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken ACCKNLEMPFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x807F030", Offset = "0x807E430", VA = "0x18807F030")]
	[AsyncStateMachine(typeof(JGFNECAPHPN))]
	private Task AMNMBKBGPIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x807F190", Offset = "0x807E590", VA = "0x18807F190")]
	[AsyncStateMachine(typeof(JHPEADIODNF))]
	private Task NGCKJANIEHD(bool FCCJDBBOCBI, string DFCMKAEHLAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710")]
	private bool IKHAKCDAABE(bool IDMFCMLEMKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal struct JABCCLAIPFH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct EBDACLAJKPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public JABCCLAIPFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x8084580", Offset = "0x8083980", VA = "0x188084580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x8084AF0", Offset = "0x8083EF0", VA = "0x188084AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class CFNEJDFFHMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public CFNEJDFFHMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x8082480", Offset = "0x8081880", VA = "0x188082480")]
		internal object ONHCMHEPCNJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct FHCHKFGLFGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public JABCCLAIPFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x8085DA0", Offset = "0x80851A0", VA = "0x188085DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x8086230", Offset = "0x8085630", VA = "0x188086230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067E")]
	private JAEMPKFBFLE HLOOKLFAJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400067F")]
	private APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private bool KLLCNDEIEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private FEJGNMMNDHD HPMNBNLACCC;

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x80896F0", Offset = "0x8088AF0", VA = "0x1880896F0")]
	public static Task<Scene> BGMGGAGKKOL(HENFMPPFGFG LMJMNPPPAHL, JAEMPKFBFLE NGFOGEBLNMM, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x80895D0", Offset = "0x80889D0", VA = "0x1880895D0")]
	[AsyncStateMachine(typeof(EBDACLAJKPJ))]
	private Task<Scene> AMNMBKBGPIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x8089770", Offset = "0x8088B70", VA = "0x188089770")]
	private bool MOJAMDEECPC(FEJGNMMNDHD HPMNBNLACCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x8089560", Offset = "0x8088960", VA = "0x188089560")]
	private void ADLGAEFDFOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x80897A0", Offset = "0x8088BA0", VA = "0x1880897A0")]
	[AsyncStateMachine(typeof(FHCHKFGLFGH))]
	private Task<Scene> NGCKJANIEHD(string DFCMKAEHLAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal struct KMGIEHGOPOH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct CPHEOOLMLOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public KMGIEHGOPOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public CPPDEEJEANJ nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public FEJGNMMNDHD deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private APGKENHKANG<string>.EEEKGBDKLHP <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private TaskAwaiter<CPPDEEJEANJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x8083500", Offset = "0x8082900", VA = "0x188083500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x8083FD0", Offset = "0x80833D0", VA = "0x188083FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct CONLCCGKFON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public AsyncTaskMethodBuilder<CPPDEEJEANJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public KMGIEHGOPOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public CPPDEEJEANJ state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x80831B0", Offset = "0x80825B0", VA = "0x1880831B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x8083490", Offset = "0x8082890", VA = "0x188083490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	private readonly KKJJOKHIFIF NHOEKMCOCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000690")]
	private readonly EGBBHHGAGKN BDFIBCDOEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	private readonly AJIIKDKENGF LAOGAOKCDDK;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private EBHOBHMGDHC GOAKAGEIOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x65620D0", Offset = "0x65614D0", VA = "0x1865620D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x808B830", Offset = "0x808AC30", VA = "0x18808B830")]
	public KMGIEHGOPOH(KKJJOKHIFIF NHOEKMCOCFJ, EGBBHHGAGKN BDFIBCDOEKG, AJIIKDKENGF LAOGAOKCDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x808B6B0", Offset = "0x808AAB0", VA = "0x18808B6B0")]
	[AsyncStateMachine(typeof(CPHEOOLMLOM))]
	public Task<CPPDEEJEANJ> PFJGMBDMACP(CPPDEEJEANJ OKCFFPINPMN, FEJGNMMNDHD PNEKEJIIDPC, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH, bool JAPCKMIOHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x808B500", Offset = "0x808A900", VA = "0x18808B500")]
	[AsyncStateMachine(typeof(CONLCCGKFON))]
	private Task<CPPDEEJEANJ> DOMAGLIGIDO(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CPPDEEJEANJ DHJOIBPBMPI, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x808B680", Offset = "0x808AA80", VA = "0x18808B680")]
	private bool KIIMBFKDJJI(CPPDEEJEANJ LCPALEACDKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x808B660", Offset = "0x808AA60", VA = "0x18808B660")]
	private void GFDFDHMHGGA(string GJKLHCCFCHI)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal struct BHBKMDIDFMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct FCNNLGOHHIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public EBHOBHMGDHC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public PLDBJHIGINN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private IFKKDICMKCC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private List<(PersistenceView, AJANKEAEBKF)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private (PersistenceView, AJANKEAEBKF) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x8085670", Offset = "0x8084A70", VA = "0x188085670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x8085D40", Offset = "0x8085140", VA = "0x188085D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x8081BC0", Offset = "0x8080FC0", VA = "0x188081BC0")]
	[AsyncStateMachine(typeof(FCNNLGOHHIO))]
	public static Task AMNMBKBGPIL(EBHOBHMGDHC EKJBIEIFIHC, FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal struct CLMNPEIAENC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct NKJMELEIPNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public EBHOBHMGDHC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public PLDBJHIGINN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private CECIAOOGNBJ <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private IFKKDICMKCC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private List<(PersistenceView, AJANKEAEBKF)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private AJANKEAEBKF <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x8093860", Offset = "0x8092C60", VA = "0x188093860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x8094140", Offset = "0x8093540", VA = "0x188094140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x8082DB0", Offset = "0x80821B0", VA = "0x188082DB0")]
	[AsyncStateMachine(typeof(NKJMELEIPNO))]
	public static Task AMNMBKBGPIL(EBHOBHMGDHC EKJBIEIFIHC, FEJGNMMNDHD HPMNBNLACCC, PLDBJHIGINN IOFCLEOGOLJ, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal struct NEKEBJFHDJO
{
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	public struct GLLCLBOHLDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public List<PBLDHPJABID> CBPLGBMDHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public List<AJANKEAEBKF> IABBBFPOLCB;

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0xA147A0", Offset = "0xA13BA0", VA = "0x180A147A0")]
		public GLLCLBOHLDM(List<PBLDHPJABID> CBPLGBMDHAG, List<AJANKEAEBKF> IABBBFPOLCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class LMONBMICLNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public IEnumerable<PBLDHPJABID> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public LMONBMICLNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x808DBF0", Offset = "0x808CFF0", VA = "0x18808DBF0")]
		internal object EILLAILGMPF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006BE")]
	private HENFMPPFGFG LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006BF")]
	private FEJGNMMNDHD HPMNBNLACCC;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private BEHHGOBGNKL LDPIMCPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x8092260", Offset = "0x8091660", VA = "0x188092260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x8091A80", Offset = "0x8090E80", VA = "0x188091A80")]
	public static GLLCLBOHLDM AMNMBKBGPIL(HENFMPPFGFG LMJMNPPPAHL, FEJGNMMNDHD HPMNBNLACCC)
	{
		return default(GLLCLBOHLDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x8091820", Offset = "0x8090C20", VA = "0x188091820")]
	private GLLCLBOHLDM AMNMBKBGPIL()
	{
		return default(GLLCLBOHLDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x8091AE0", Offset = "0x8090EE0", VA = "0x188091AE0")]
	private GLLCLBOHLDM CJMLOMBJCJE(AOIFKBLFGKD KLBPAEOBMAP, CECIAOOGNBJ JBMJKJMIILJ)
	{
		return default(GLLCLBOHLDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x8092090", Offset = "0x8091490", VA = "0x188092090")]
	private bool DBKGNKJLFNB(IEnumerable<PBLDHPJABID> CBPLGBMDHAG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000185")]
internal struct ACKIMHGLCDB
{
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private sealed class BABOBBFDNMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public NEKEBJFHDJO.GLLCLBOHLDM instantiations;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public BABOBBFDNMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x8081A80", Offset = "0x8080E80", VA = "0x188081A80")]
		internal object NOHIFMNCGAO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class BFMOGLDGGCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public BFMOGLDGGCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x8081B30", Offset = "0x8080F30", VA = "0x188081B30")]
		internal object MFBLKHJDHJI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x807E240", Offset = "0x807D640", VA = "0x18807E240")]
	public static void AMNMBKBGPIL(EBHOBHMGDHC EKJBIEIFIHC, FEJGNMMNDHD HPMNBNLACCC, NEKEBJFHDJO.GLLCLBOHLDM OOGDBEOLEGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal class AJIIKDKENGF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct GKLOOPPDIIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public AJIIKDKENGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public CPPDEEJEANJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public FEJGNMMNDHD deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x8086C60", Offset = "0x8086060", VA = "0x188086C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x80873D0", Offset = "0x80867D0", VA = "0x1880873D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class FJJHPOCKOHP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018B")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006D4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006D5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006D6")]
			public FJJHPOCKOHP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006D7")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006D8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x8097100", Offset = "0x8096500", VA = "0x188097100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x80973C0", Offset = "0x80967C0", VA = "0x1880973C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public AJIIKDKENGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public APGKENHKANG<string>.EEEKGBDKLHP handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public FJJHPOCKOHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x80862A0", Offset = "0x80856A0", VA = "0x1880862A0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task LOELDOBFGJF(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private struct NHLAIFOJHNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public AJIIKDKENGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		private FJJHPOCKOHP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x80922B0", Offset = "0x80916B0", VA = "0x1880922B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x80927E0", Offset = "0x8091BE0", VA = "0x1880927E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private struct CGHNABAIHNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public AJIIKDKENGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private Dictionary<Guid, List<PHPLHHACNNI>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x809A070", Offset = "0x8099470", VA = "0x18809A070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x809A680", Offset = "0x8099A80", VA = "0x18809A680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct MHDKNLKIHPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public AJIIKDKENGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private Dictionary<Guid, List<PHPLHHACNNI>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x80A4800", Offset = "0x80A3C00", VA = "0x1880A4800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x80A4E90", Offset = "0x80A4290", VA = "0x1880A4E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private sealed class FHFLIPAJCHM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006F8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006F9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006FA")]
			public PHPLHHACNNI handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006FB")]
			public FHFLIPAJCHM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006FC")]
			private IFKKDICMKCC <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006FD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x80A6640", Offset = "0x80A5A40", VA = "0x1880A6640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x80A6AB0", Offset = "0x80A5EB0", VA = "0x1880A6AB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public AGFEBOGLHIP runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public List<PHPLHHACNNI> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public FHFLIPAJCHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x809C580", Offset = "0x809B980", VA = "0x18809C580")]
		internal object NGGFEKJILEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x809C480", Offset = "0x809B880", VA = "0x18809C480")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task EDNOBBOKBKE(PHPLHHACNNI handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x809C670", Offset = "0x809BA70", VA = "0x18809C670")]
		internal object NNBKCJKMLFN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct EKJJPNJDCDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public AGFEBOGLHIP runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public List<PHPLHHACNNI> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private FHFLIPAJCHM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x809BF50", Offset = "0x809B350", VA = "0x18809BF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x809C420", Offset = "0x809B820", VA = "0x18809C420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct KLMHHOOGGBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public AJIIKDKENGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public APGKENHKANG<string>.EEEKGBDKLHP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x80A3C40", Offset = "0x80A3040", VA = "0x1880A3C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x80A3F30", Offset = "0x80A3330", VA = "0x1880A3F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class PMPFNEMHKBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public PMPFNEMHKBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x80A65D0", Offset = "0x80A59D0", VA = "0x1880A65D0")]
		internal object GDDKBEIHCHH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private struct DFMNFGOBKGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public AJIIKDKENGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public FEJGNMMNDHD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x809A8B0", Offset = "0x8099CB0", VA = "0x18809A8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x809AD60", Offset = "0x809A160", VA = "0x18809AD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class OAACFJAODMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public OAACFJAODMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x80A5110", Offset = "0x80A4510", VA = "0x1880A5110")]
		internal object HPDNPFNPPMN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private struct BFDNMGGEGJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public AJIIKDKENGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		private IFKKDICMKCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x8097EE0", Offset = "0x80972E0", VA = "0x188097EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x8098510", Offset = "0x8097910", VA = "0x188098510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class BJNNDEFPAMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public BJNNDEFPAMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x8098570", Offset = "0x8097970", VA = "0x188098570")]
		internal object GCMELIHGDHG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private readonly KKJJOKHIFIF NHOEKMCOCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private GFIJHOCNJMG LAOGAOKCDDK;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private EBHOBHMGDHC GOAKAGEIOAF
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xFF9210", Offset = "0xFF8610", VA = "0x180FF9210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
	public AJIIKDKENGF(KKJJOKHIFIF NHOEKMCOCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x8080070", Offset = "0x807F470", VA = "0x188080070")]
	[AsyncStateMachine(typeof(GKLOOPPDIIK))]
	public Task AMNMBKBGPIL(CPPDEEJEANJ OIHFCHECHPE, FEJGNMMNDHD PNEKEJIIDPC, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x8080760", Offset = "0x807FB60", VA = "0x188080760")]
	[AsyncStateMachine(typeof(NHLAIFOJHNI))]
	private Task JCKBKECGNIE(FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x80804E0", Offset = "0x807F8E0", VA = "0x1880804E0")]
	[AsyncStateMachine(typeof(CGHNABAIHNN))]
	private Task FIFJHCHNHOC(FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x8080D30", Offset = "0x8080130", VA = "0x188080D30")]
	[AsyncStateMachine(typeof(MHDKNLKIHPE))]
	private Task PPHLAAFCKIL(FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x8080A70", Offset = "0x807FE70", VA = "0x188080A70")]
	[AsyncStateMachine(typeof(EKJJPNJDCDH))]
	private Task OPJCJNMKFKC(Guid EBKKNHAJLEM, List<PHPLHHACNNI> PHGHBAOFPNF, AGFEBOGLHIP AMPLHFDHCMG, FEJGNMMNDHD HPMNBNLACCC, CancellationToken HHGPJKKLNIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x8080620", Offset = "0x807FA20", VA = "0x188080620")]
	[AsyncStateMachine(typeof(KLMHHOOGGBI))]
	private Task FPFOIKJPJHG(FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x807FF30", Offset = "0x807F330", VA = "0x18807FF30")]
	[AsyncStateMachine(typeof(DFMNFGOBKGO))]
	private Task ALHIHAHLADF(Guid MPNKLMEHFIA, FEJGNMMNDHD HPMNBNLACCC, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x80803A0", Offset = "0x807F7A0", VA = "0x1880803A0")]
	[AsyncStateMachine(typeof(BFDNMGGEGJF))]
	private Task EBMKDHCDHPE(Guid MPNKLMEHFIA, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x8080950", Offset = "0x807FD50", VA = "0x188080950")]
	private void KKMNLEHLGGD(Guid MPNKLMEHFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x80808A0", Offset = "0x807FCA0", VA = "0x1880808A0")]
	private void KKAABHJGHAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x8080BC0", Offset = "0x807FFC0", VA = "0x188080BC0")]
	public Guid PACHFDDJNIA(CPPDEEJEANJ EBDPJJJPIOL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x80801C0", Offset = "0x807F5C0", VA = "0x1880801C0")]
	[CompilerGenerated]
	private object DNHMKMJBIKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
internal struct JAKNLIMDIHM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct JGMHFBPAAFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public JAKNLIMDIHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private APGKENHKANG<string>.EEEKGBDKLHP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private IEnumerator<HIAAHBCANNL> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x80A1FE0", Offset = "0x80A13E0", VA = "0x1880A1FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x80A2680", Offset = "0x80A1A80", VA = "0x1880A2680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	private BEHHGOBGNKL IAPHFNOPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	private APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000728")]
	private CancellationToken LMNHDKIFBOH;

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x80A1BC0", Offset = "0x80A0FC0", VA = "0x1880A1BC0")]
	public static Task PFDECELLGBL(BEHHGOBGNKL IAPHFNOPBJO, APGKENHKANG<string>.EEEKGBDKLHP KINEPAABOFB, CancellationToken ACCKNLEMPFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x80A1AD0", Offset = "0x80A0ED0", VA = "0x1880A1AD0")]
	[AsyncStateMachine(typeof(JGMHFBPAAFL))]
	private Task AMNMBKBGPIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public readonly struct DCMMCMGKNNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	public readonly bool JBFHOMJDIAE;

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x2862360", Offset = "0x2861760", VA = "0x182862360")]
	public DCMMCMGKNNK(bool KNOHFHHIJHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public readonly struct PLFCMNGIAGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	public readonly AOIFKBLFGKD? FDLLHFJHPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000731")]
	public readonly LMBINBOIHNM ADFGKBCLDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000732")]
	public readonly Guid? NBIGHKECMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000733")]
	public readonly IReadOnlyList<Guid> ECDAMHAKBBI;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public IReadOnlyCollection<string> GGOIBNGNOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x80A64B0", Offset = "0x80A58B0", VA = "0x1880A64B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public IReadOnlyDictionary<long, int> NLDNGDGJCEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x80A6490", Offset = "0x80A5890", VA = "0x1880A6490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x80A64D0", Offset = "0x80A58D0", VA = "0x1880A64D0")]
	public PLFCMNGIAGA(AOIFKBLFGKD? LLMAFCHBBPF, LMBINBOIHNM IJPFNDPHDOM, Guid? JGICNMOHCMI, [Optional] IReadOnlyList<Guid>? HHCLEOOMIME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal class HHEPFLADLLI : LOMGCHGEPFF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private struct IBMDBBGMGGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public AsyncTaskMethodBuilder<PLFCMNGIAGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public HHEPFLADLLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public HKFCLLCDEKJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public HJGDKKKNFOO roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		private IFKKDICMKCC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x80A0A80", Offset = "0x809FE80", VA = "0x1880A0A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x80A1120", Offset = "0x80A0520", VA = "0x1880A1120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class HHLNFCACDJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public HHLNFCACDJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x809FE10", Offset = "0x809F210", VA = "0x18809FE10")]
		internal object BCBOBPECJLJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private struct CCEKMHFGDAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public HHEPFLADLLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public HKFCLLCDEKJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		private HHLNFCACDJG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		private IFKKDICMKCC <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private LEHDJFKJBJH<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x8099540", Offset = "0x8098940", VA = "0x188099540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x809A010", Offset = "0x8099410", VA = "0x18809A010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000734")]
	private readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x4000735")]
	private static readonly TimeSpan KLNMLCEHBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000736")]
	private readonly ICJNLBAHBIB AGIMLMJEEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000737")]
	private readonly KFMCEPHLDFP OIIAIOBOJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000738")]
	private readonly GMCCGHJBJAL CFKGPJIDBKL;

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x809FDA0", Offset = "0x809F1A0", VA = "0x18809FDA0")]
	public HHEPFLADLLI(KKJJOKHIFIF NHOEKMCOCFJ, ICJNLBAHBIB AGIMLMJEEAK, KFMCEPHLDFP IELMBIOABLF, GMCCGHJBJAL CFKGPJIDBKL, GBHBOJAPDOA DPDKJPMBJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x809FBE0", Offset = "0x809EFE0", VA = "0x18809FBE0")]
	[AsyncStateMachine(typeof(IBMDBBGMGGA))]
	public Task<PLFCMNGIAGA> PELCBGJOJPC(long JCNNPHFBOMP, HJGDKKKNFOO ONHCODKGHOO, HKFCLLCDEKJ BONNIONLFGJ, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x809FAA0", Offset = "0x809EEA0", VA = "0x18809FAA0")]
	[AsyncStateMachine(typeof(CCEKMHFGDAI))]
	private Task MGGPPECPLCA(HKFCLLCDEKJ BONNIONLFGJ, PersistenceView[] HOLHGEDPHEF, StringBuilder LNPIOIEKNKK, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x809F240", Offset = "0x809E640", VA = "0x18809F240")]
	private PLFCMNGIAGA IJFCCFNGONE(long JCNNPHFBOMP, HJGDKKKNFOO ONHCODKGHOO, HKFCLLCDEKJ BONNIONLFGJ, IEnumerable<PersistenceView> HOLHGEDPHEF, StringBuilder LNPIOIEKNKK)
	{
		return default(PLFCMNGIAGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x809EBE0", Offset = "0x809DFE0", VA = "0x18809EBE0")]
	private AOIFKBLFGKD CJDCDGODCMM(long JCNNPHFBOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x809F850", Offset = "0x809EC50", VA = "0x18809F850")]
	private void LFFPAMIKHNA(AOIFKBLFGKD ONBMANKKKHN, StringBuilder LNPIOIEKNKK, IEnumerable<PersistenceView> HOLHGEDPHEF, [In] EJPLPBCADEO PAKDJMBDPBI, AOBGJNEOAEI IGKLENELELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x809EDA0", Offset = "0x809E1A0", VA = "0x18809EDA0")]
	private void FHBIJFICLBH(AOIFKBLFGKD ONBMANKKKHN, StringBuilder LNPIOIEKNKK, PersistenceView EKLEPCBGCMK, AOBGJNEOAEI IGKLENELELN, [In] EJPLPBCADEO PAKDJMBDPBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal class HOBKOKHAHLA : LOMGCHGEPFF
{
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[CompilerGenerated]
	private sealed class IOEPMDGPIFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public LBNOIGENJNJ.HCGGFPCHEGC roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public IOEPMDGPIFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x80A1A80", Offset = "0x80A0E80", VA = "0x1880A1A80")]
		internal object LDDDCLJDLCB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private struct OOLIABOCJPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		public AsyncTaskMethodBuilder<(LBNOIGENJNJ.HCGGFPCHEGC roomDataUpload, LBNOIGENJNJ.HCGGFPCHEGC subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public PLFCMNGIAGA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public BEHHGOBGNKL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		private IOEPMDGPIFI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		private TaskAwaiter<LBNOIGENJNJ.HCGGFPCHEGC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x80A5180", Offset = "0x80A4580", VA = "0x1880A5180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x80A5A00", Offset = "0x80A4E00", VA = "0x1880A5A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private struct JEIDJDKJFAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		public AsyncTaskMethodBuilder<DHJBDKCLFJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		public HOBKOKHAHLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public IJHECIBDPGO roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public PLFCMNGIAGA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		private TaskAwaiter<DHJBDKCLFJF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x80A1C30", Offset = "0x80A1030", VA = "0x1880A1C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x80A1ED0", Offset = "0x80A12D0", VA = "0x1880A1ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private struct EJMBLCIHKBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public AsyncTaskMethodBuilder<DHJBDKCLFJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public BEHHGOBGNKL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public PLFCMNGIAGA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public NFIJHFLFIBC ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public IJHECIBDPGO roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		private TaskAwaiter<(LBNOIGENJNJ.HCGGFPCHEGC roomDataUpload, LBNOIGENJNJ.HCGGFPCHEGC subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		private TaskAwaiter<DHJBDKCLFJF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x809B880", Offset = "0x809AC80", VA = "0x18809B880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x809BEE0", Offset = "0x809B2E0", VA = "0x18809BEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private struct MBDHMKBAKDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public AsyncTaskMethodBuilder<MJFIDHLLGBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public HOBKOKHAHLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public PLFCMNGIAGA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		private TaskAwaiter<(LBNOIGENJNJ.HCGGFPCHEGC roomDataUpload, LBNOIGENJNJ.HCGGFPCHEGC subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		private TaskAwaiter<MJFIDHLLGBC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x80A42D0", Offset = "0x80A36D0", VA = "0x1880A42D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x80A4790", Offset = "0x80A3B90", VA = "0x1880A4790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private sealed class KDNHJAKHPNO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001A9")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000785")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000786")]
			public AsyncTaskMethodBuilder<EPOGGLOBAKG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000787")]
			public KDNHJAKHPNO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000788")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000789")]
			private EPOGGLOBAKG <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400078A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400078B")]
			private TaskAwaiter<MJFIDHLLGBC> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400078C")]
			private TaskAwaiter<DHJBDKCLFJF> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400078D")]
			private TaskAwaiter<EPOGGLOBAKG> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0x80A6B10", Offset = "0x80A5F10", VA = "0x1880A6B10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x80A7D20", Offset = "0x80A7120", VA = "0x1880A7D20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		public HOBKOKHAHLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public PLFCMNGIAGA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public IJHECIBDPGO roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public DCMMCMGKNNK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public KDNHJAKHPNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x80A3B10", Offset = "0x80A2F10", VA = "0x1880A3B10")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<EPOGGLOBAKG> HCHDELPDNNI(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct BLODLCGLJEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public AsyncTaskMethodBuilder<EPOGGLOBAKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public HOBKOKHAHLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public PLFCMNGIAGA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public IJHECIBDPGO roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public DCMMCMGKNNK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		private TaskAwaiter<EPOGGLOBAKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x80985E0", Offset = "0x80979E0", VA = "0x1880985E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x8098910", Offset = "0x8097D10", VA = "0x188098910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000752")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x4000753")]
	private static readonly GBHBOJAPDOA MLIAFKELENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000754")]
	private readonly DKOGEAIEABM OLIGAJLLAND;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private HENFMPPFGFG KBLPAMDIOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x8072880", Offset = "0x8071C80", VA = "0x188072880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x80A09F0", Offset = "0x809FDF0", VA = "0x1880A09F0")]
	public HOBKOKHAHLA(KKJJOKHIFIF NHOEKMCOCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x80A04D0", Offset = "0x809F8D0", VA = "0x1880A04D0")]
	[AsyncStateMachine(typeof(OOLIABOCJPP))]
	private static Task<(LBNOIGENJNJ.HCGGFPCHEGC, LBNOIGENJNJ.HCGGFPCHEGC)> GOGNIGAJIBM(BEHHGOBGNKL IAPHFNOPBJO, PLFCMNGIAGA ECMHMDMOHLI, long MIFADOBCMAC, long OFAOCKBMEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x80A0010", Offset = "0x809F410", VA = "0x1880A0010")]
	[AsyncStateMachine(typeof(JEIDJDKJFAI))]
	public Task<DHJBDKCLFJF> BJPJHGFPCMH(int ALJILABKHFO, [CanBeNull] IJHECIBDPGO FBOPDOAKGNF, PLFCMNGIAGA ECMHMDMOHLI, long MIFADOBCMAC, long OFAOCKBMEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x80A0180", Offset = "0x809F580", VA = "0x1880A0180")]
	public static Task<DHJBDKCLFJF> BJPJHGFPCMH(BEHHGOBGNKL IAPHFNOPBJO, int ALJILABKHFO, [CanBeNull] IJHECIBDPGO FBOPDOAKGNF, PLFCMNGIAGA ECMHMDMOHLI, long MIFADOBCMAC, long OFAOCKBMEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x809FE80", Offset = "0x809F280", VA = "0x18809FE80")]
	[AsyncStateMachine(typeof(EJMBLCIHKBN))]
	public static Task<DHJBDKCLFJF> BJPJHGFPCMH(BEHHGOBGNKL IAPHFNOPBJO, int ALJILABKHFO, [CanBeNull] IJHECIBDPGO FBOPDOAKGNF, PLFCMNGIAGA ECMHMDMOHLI, long MIFADOBCMAC, long OFAOCKBMEGP, NFIJHFLFIBC FAAABALDJOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x80A0620", Offset = "0x809FA20", VA = "0x1880A0620")]
	[AsyncStateMachine(typeof(MBDHMKBAKDC))]
	private Task<MJFIDHLLGBC> IALMHFPKNGA(string EFBGJFMCDKM, int ALJILABKHFO, PLFCMNGIAGA ECMHMDMOHLI, long MIFADOBCMAC, long OFAOCKBMEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x80A07A0", Offset = "0x809FBA0", VA = "0x1880A07A0")]
	[AsyncStateMachine(typeof(BLODLCGLJEA))]
	public Task<EPOGGLOBAKG> INLCLMJPADM(int ALJILABKHFO, IJHECIBDPGO? FBOPDOAKGNF, PLFCMNGIAGA ECMHMDMOHLI, long MIFADOBCMAC, long OFAOCKBMEGP, DCMMCMGKNNK PHPGFAPLADG, APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public abstract class CJPEGCLNHBM<T> where T : CJPEGCLNHBM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079A")]
	internal readonly HENFMPPFGFG HANEBLJAFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079B")]
	private int? LOLGHOBDHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079C")]
	protected readonly Guid FDCJMIFHPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079D")]
	protected readonly OGNLJOEPPKN BONBPEOCPCL;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected T GMCDKEOPHIL
	{
		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x6402050", Offset = "0x6401450", VA = "0x186402050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x64020B0", Offset = "0x64014B0", VA = "0x1864020B0")]
	internal CJPEGCLNHBM(HENFMPPFGFG OCPJDDFOEKE, OGNLJOEPPKN FHHMBNMHEHD, [Optional] Guid? FDFDCKJIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x6401D00", Offset = "0x6401100", VA = "0x186401D00")]
	private EPOGGLOBAKG ELBCNGCIOMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "4")]
	protected virtual void PKHIHBGNKDK(EPOGGLOBAKG DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x6401FB0", Offset = "0x64013B0", VA = "0x186401FB0")]
	public T IPICJBGHNPE(DNIGIBHMBIB GGMAHLNBIDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x6401DE0", Offset = "0x64011E0", VA = "0x186401DE0")]
	public T EPHPJJCIMJJ(int OKGNFGGIHLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x6401E80", Offset = "0x6401280", VA = "0x186401E80", Slot = "5")]
	public virtual Task<OGJPCDKPGHL> IGGEPNIJKHC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public class NILLKCEJPKG : CJPEGCLNHBM<NILLKCEJPKG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400079E")]
	private NAMDFBDBPAO DMDJHNIAOJN;

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x80A5040", Offset = "0x80A4440", VA = "0x1880A5040")]
	internal NILLKCEJPKG(HENFMPPFGFG OCPJDDFOEKE, OGNLJOEPPKN FHHMBNMHEHD, [Optional] Guid? FDFDCKJIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x7392A70", Offset = "0x7391E70", VA = "0x187392A70")]
	public NILLKCEJPKG LHGENFAMPIP(NAMDFBDBPAO DMDJHNIAOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x80A4F70", Offset = "0x80A4370", VA = "0x1880A4F70", Slot = "4")]
	protected override void PKHIHBGNKDK(EPOGGLOBAKG DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public class IJCJEHDBGCB : CJPEGCLNHBM<IJCJEHDBGCB>
{
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	internal enum HKPKMIDKNEB
	{
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[CompilerGenerated]
	private struct PDIBKBEJPAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		public AsyncTaskMethodBuilder<OGJPCDKPGHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public IJCJEHDBGCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		private TaskAwaiter<OGJPCDKPGHL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x80A5A70", Offset = "0x80A4E70", VA = "0x1880A5A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x80A5E20", Offset = "0x80A5220", VA = "0x1880A5E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400079F")]
	private HKPKMIDKNEB BFEGOLPGOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007A0")]
	private string KFMJCPIFOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007A1")]
	private IJHECIBDPGO DMDJHNIAOJN;

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x80A14D0", Offset = "0x80A08D0", VA = "0x1880A14D0")]
	internal IJCJEHDBGCB(HENFMPPFGFG OCPJDDFOEKE, OGNLJOEPPKN FHHMBNMHEHD, [Optional] Guid? FDFDCKJIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x80A1190", Offset = "0x80A0590", VA = "0x1880A1190")]
	public IJCJEHDBGCB CMCBPGJKPNC(string ONJHPHOODPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x80A1340", Offset = "0x80A0740", VA = "0x1880A1340")]
	public IJCJEHDBGCB OAEECGLPLKL(bool AJAHJLHNKJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x80A1320", Offset = "0x80A0720", VA = "0x1880A1320")]
	public IJCJEHDBGCB JJGFGJMDAHL(bool PCKJNEHNNLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x80A1200", Offset = "0x80A0600", VA = "0x1880A1200")]
	public IJCJEHDBGCB GCGNJLJJICF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x80A1360", Offset = "0x80A0760", VA = "0x1880A1360", Slot = "4")]
	protected override void PKHIHBGNKDK(EPOGGLOBAKG DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x80A1230", Offset = "0x80A0630", VA = "0x1880A1230", Slot = "5")]
	[AsyncStateMachine(typeof(PDIBKBEJPAC))]
	public override Task<OGJPCDKPGHL> IGGEPNIJKHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x80A11C0", Offset = "0x80A05C0", VA = "0x1880A11C0")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<OGJPCDKPGHL> FMKFANKEEPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
internal static class COCCCGMHJAK
{
	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x809A6E0", Offset = "0x8099AE0", VA = "0x18809A6E0")]
	public static void GBCKNBAHNKN(this OLGIGMIMIFN OKDJBKODHNO, ELMNGLJGGCK PJHPPMJLCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x809A830", Offset = "0x8099C30", VA = "0x18809A830")]
	public static void MAAMEOOGHIP(this ELMNGLJGGCK HHOKLMFBNEK, [Optional] string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public static class IKPPOFIHFCD
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x80A1930", Offset = "0x80A0D30", VA = "0x1880A1930")]
	public static KKCEGILFGJB HGKDLNNDPCF(this NIEMIMHBOGJ PALJLCLNIHE)
	{
		return default(KKCEGILFGJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x80A19D0", Offset = "0x80A0DD0", VA = "0x1880A19D0")]
	public static NIEMIMHBOGJ PMKAIBADFBK(this KKCEGILFGJB IFIFEABECPD)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001B3")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			public JNDBDBIFPHO ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			public JNDBDBIFPHO HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006D0")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		private static JNDBDBIFPHO[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		private Dictionary<JNDBDBIFPHO, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x80A8480", Offset = "0x80A7880", VA = "0x1880A8480")]
		public bool NKBMCGJPMLE(JNDBDBIFPHO GCFDJFLLMIH, [Out] ResultConfig HNFCGGMPMHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x80A8340", Offset = "0x80A7740", VA = "0x1880A8340")]
		public ResultConfig GNFPFEMAKPF(JNDBDBIFPHO JKODLOFLBMK, [Optional] HashSet<JNDBDBIFPHO> IANHIMJDGBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x80A8AC0", Offset = "0x80A7EC0", VA = "0x1880A8AC0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x80A84F0", Offset = "0x80A78F0", VA = "0x1880A84F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xAFB4C0", Offset = "0xAFA8C0", VA = "0x180AFB4C0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
public class LKCGMKJMEPF : FAOIIFKBBED
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	[CompilerGenerated]
	private struct IJELGPFPNJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public LKCGMKJMEPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public APGKENHKANG<string>.EEEKGBDKLHP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x80A1640", Offset = "0x80A0A40", VA = "0x1880A1640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x80A18D0", Offset = "0x80A0CD0", VA = "0x1880A18D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[CompilerGenerated]
	private struct FIHCAGLKJJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		public APGKENHKANG<string>.EEEKGBDKLHP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		public FAOIIFKBBED preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		private APGKENHKANG<string>.EEEKGBDKLHP <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x809C760", Offset = "0x809BB60", VA = "0x18809C760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x809CC10", Offset = "0x809C010", VA = "0x18809CC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007B9")]
	private readonly PCGFALIICAO DEJGPOAAAGI;

	[Cpp2IlInjected.Token(Token = "0x40007BA")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public string AEMAACCBEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x80A3F90", Offset = "0x80A3390", VA = "0x1880A3F90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x80A41F0", Offset = "0x80A35F0", VA = "0x1880A41F0")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	internal static void OPNOJEPKKPP(DHLGDCALOEP EOJAEMANAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LKCGMKJMEPF([CMKKAFOAFJE(null)] PCGFALIICAO DEJGPOAAAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x80A3FC0", Offset = "0x80A33C0", VA = "0x1880A3FC0", Slot = "5")]
	[AsyncStateMachine(typeof(IJELGPFPNJA))]
	public Task AMNMBKBGPIL(APGKENHKANG<string>.EEEKGBDKLHP GHLKOGBLJCP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x80A40D0", Offset = "0x80A34D0", VA = "0x1880A40D0")]
	[AsyncStateMachine(typeof(FIHCAGLKJJB))]
	private Task HNEJBHNPFEF(FAOIIFKBBED HKHKDBPNEED, APGKENHKANG<string>.EEEKGBDKLHP GHLKOGBLJCP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B8")]
public interface PCGFALIICAO : FAOIIFKBBED
{
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
public interface FAOIIFKBBED
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	string AEMAACCBEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AMNMBKBGPIL(APGKENHKANG<string>.EEEKGBDKLHP GHLKOGBLJCP, CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
public static class AINGOBDEJJH
{
	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x8097AD0", Offset = "0x8096ED0", VA = "0x188097AD0")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	internal static void BBLAOBGDHMG(DHLGDCALOEP EOJAEMANAOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
public interface CKKDNBIBBCP : IEquatable<CKKDNBIBBCP>
{
	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	DateTime BJLNCFEJNHA
	{
		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPLHDDCDICF();

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GEGGBOPFAEM(long MIFADOBCMAC, long JCNNPHFBOMP, [Out] PLFCMNGIAGA ECMHMDMOHLI);
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
internal class JIMCGDCBCOD : JJEFOPFFIIN
{
	[Cpp2IlInjected.Token(Token = "0x20001BD")]
	[CompilerGenerated]
	private sealed class JOKMPDFGEBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		public JFCACKFPDGD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public JOKMPDFGEBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x80A3AA0", Offset = "0x80A2EA0", VA = "0x1880A3AA0")]
		internal object KAIJFHHNHNH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007C8")]
	private readonly GBMHKFGAAKM EGGLDPGDCFD;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<CKKDNBIBBCP> JNBEEIPBIFD
	{
		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x80A2B10", Offset = "0x80A1F10", VA = "0x1880A2B10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x80A2EC0", Offset = "0x80A22C0", VA = "0x1880A2EC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
	[UnityEngine.Scripting.Preserve]
	public JIMCGDCBCOD([CMKKAFOAFJE(null)] GBMHKFGAAKM EGGLDPGDCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x80A2BC0", Offset = "0x80A1FC0", VA = "0x1880A2BC0", Slot = "6")]
	public bool IIHLEFJGIEA(long MIFADOBCMAC, long JCNNPHFBOMP, PLFCMNGIAGA ECMHMDMOHLI, JFCACKFPDGD GIHOEMBHLDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0xD0E0C0", Offset = "0xD0D4C0", VA = "0x180D0E0C0")]
	private void FDPPHHPHCED(CKKDNBIBBCP CEDHNEPJPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x80A3150", Offset = "0x80A2550", VA = "0x1880A3150", Slot = "7")]
	public bool NINICLEKIBN(long MIFADOBCMAC, long JCNNPHFBOMP, [Out] CKKDNBIBBCP HGHJCHINOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x80A30A0", Offset = "0x80A24A0", VA = "0x1880A30A0", Slot = "8")]
	public bool NBHNIPPBFAL(long MIFADOBCMAC, long JCNNPHFBOMP, JFCACKFPDGD GIHOEMBHLDB, [Out] CKKDNBIBBCP HGHJCHINOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x80A26E0", Offset = "0x80A1AE0", VA = "0x1880A26E0")]
	private void BHEBMOODBDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x80A2F70", Offset = "0x80A2370", VA = "0x1880A2F70", Slot = "9")]
	public void KNDJCHHOBKJ(long MIFADOBCMAC, long JCNNPHFBOMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
internal abstract class DHNGKNLLHCN : GBMHKFGAAKM
{
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	protected enum MCMOEPGLMEN : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	[CompilerGenerated]
	private sealed class CBDHBCGOMDD : IEnumerable<CKKDNBIBBCP>, IEnumerable, IEnumerator<CKKDNBIBBCP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		private CKKDNBIBBCP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		public DHNGKNLLHCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private JFCACKFPDGD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		public JFCACKFPDGD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		private CKKDNBIBBCP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xDE6750", Offset = "0xDE5B50", VA = "0x180DE6750")]
		[DebuggerHidden]
		public CBDHBCGOMDD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x8099210", Offset = "0x8098610", VA = "0x188099210", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x80994F0", Offset = "0x80988F0", VA = "0x1880994F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x8099440", Offset = "0x8098840", VA = "0x188099440", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CKKDNBIBBCP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x8099440", Offset = "0x8098840", VA = "0x188099440", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[CompilerGenerated]
	private sealed class JFAODIFAPDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		public JFCACKFPDGD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public JFAODIFAPDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x80A1F40", Offset = "0x80A1340", VA = "0x1880A1F40")]
		internal object FFPKHNILFPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[CompilerGenerated]
	private sealed class NBJKEBNOBHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		public DHNGKNLLHCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public NBJKEBNOBHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x80A4EF0", Offset = "0x80A42F0", VA = "0x1880A4EF0")]
		internal void NKIMDDLIINL(NOGKHBFIKBD.GGJNLOGIEPC ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007CE")]
	private readonly object CJNELGHOAMP;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	protected string DIIEIDHPMOK
	{
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x809B1B0", Offset = "0x809A5B0", VA = "0x18809B1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public abstract JHEPPKFKLJA JBACIEDJFCN
	{
		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x809B800", Offset = "0x809AC00", VA = "0x18809B800")]
	protected DHNGKNLLHCN([CanBeNull] string HPFDDMPIFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x809B580", Offset = "0x809A980", VA = "0x18809B580", Slot = "5")]
	public bool JHHKOFPBOED(long MIFADOBCMAC, long JCNNPHFBOMP, JFCACKFPDGD GIHOEMBHLDB, [Out] CKKDNBIBBCP CEDHNEPJPLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x809B770", Offset = "0x809AB70", VA = "0x18809B770", Slot = "6")]
	[IteratorStateMachine(typeof(CBDHBCGOMDD))]
	public IEnumerable<CKKDNBIBBCP> MIPDJJJKIJE(JFCACKFPDGD GIHOEMBHLDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void NIJAKLMIGCP(Stream OCNLBBDBIHI, long MIFADOBCMAC, long JCNNPHFBOMP, PLFCMNGIAGA ECMHMDMOHLI);

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool AJCGEBOBFPA(Stream NHHOHACOPOO, long MIFADOBCMAC, long JCNNPHFBOMP, CCPPLFONDLN CAIINJFADJO, [Out] PLFCMNGIAGA ECMHMDMOHLI);

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x809AE30", Offset = "0x809A230", VA = "0x18809AE30", Slot = "7")]
	public CKKDNBIBBCP FLAAOIDEDHM(long MIFADOBCMAC, long JCNNPHFBOMP, PLFCMNGIAGA ECMHMDMOHLI, JFCACKFPDGD GIHOEMBHLDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo EOOPOFGFDJB(long MIFADOBCMAC, long JCNNPHFBOMP, JFCACKFPDGD GIHOEMBHLDB, MCMOEPGLMEN AGBOFEFHDBD);

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo ECMEPHNGFPK(JFCACKFPDGD GIHOEMBHLDB, MCMOEPGLMEN AGBOFEFHDBD);

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x809ADC0", Offset = "0x809A1C0", VA = "0x18809ADC0")]
	protected void AJPCNODBNMF(NOGKHBFIKBD.GGJNLOGIEPC NJCPOEBCCFB, string GJKLHCCFCHI, FileInfo OMBFEJGGAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x809B1C0", Offset = "0x809A5C0", VA = "0x18809B1C0")]
	internal bool HOCEEMMCNDC(FileInfo AKLEFFEABNP, long MIFADOBCMAC, long JCNNPHFBOMP, [Out] PLFCMNGIAGA ECMHMDMOHLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
	private void MFPEPEPJABF(Exception OBHLNPEHLEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
internal class GCLNHIHFMEF : DHNGKNLLHCN
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public override JHEPPKFKLJA JBACIEDJFCN
	{
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x1C8A880", Offset = "0x1C89C80", VA = "0x181C8A880", Slot = "8")]
		get
		{
			return default(JHEPPKFKLJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x809D890", Offset = "0x809CC90", VA = "0x18809D890")]
	public GCLNHIHFMEF([Optional] string HPFDDMPIFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x809D560", Offset = "0x809C960", VA = "0x18809D560")]
	private void KFBKCLFFBJF(JFCACKFPDGD GIHOEMBHLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x809D5E0", Offset = "0x809C9E0", VA = "0x18809D5E0", Slot = "9")]
	internal override void NIJAKLMIGCP(Stream OCNLBBDBIHI, long MIFADOBCMAC, long JCNNPHFBOMP, PLFCMNGIAGA ECMHMDMOHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x809CC70", Offset = "0x809C070", VA = "0x18809CC70", Slot = "10")]
	internal override bool AJCGEBOBFPA(Stream NHHOHACOPOO, long MIFADOBCMAC, long JCNNPHFBOMP, CCPPLFONDLN CAIINJFADJO, [Out] PLFCMNGIAGA ECMHMDMOHLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x809D470", Offset = "0x809C870", VA = "0x18809D470", Slot = "11")]
	protected override FileInfo EOOPOFGFDJB(long MIFADOBCMAC, long JCNNPHFBOMP, JFCACKFPDGD GIHOEMBHLDB, MCMOEPGLMEN AGBOFEFHDBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x809D370", Offset = "0x809C770", VA = "0x18809D370", Slot = "12")]
	protected override DirectoryInfo ECMEPHNGFPK(JFCACKFPDGD GIHOEMBHLDB, MCMOEPGLMEN AGBOFEFHDBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
internal sealed class GIILEBAMJJA : DHNGKNLLHCN
{
	[Cpp2IlInjected.Token(Token = "0x40007DE")]
	private static readonly byte[] DJBLFBEBKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007DF")]
	private readonly byte[] CBBOOBPJNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007E0")]
	private readonly byte[] JEOMEMKIDID;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public override JHEPPKFKLJA JBACIEDJFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x6BBEDD0", Offset = "0x6BBE1D0", VA = "0x186BBEDD0", Slot = "8")]
		get
		{
			return default(JHEPPKFKLJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x809EAF0", Offset = "0x809DEF0", VA = "0x18809EAF0")]
	public GIILEBAMJJA([Optional] string HPFDDMPIFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x809E640", Offset = "0x809DA40", VA = "0x18809E640", Slot = "9")]
	internal override void NIJAKLMIGCP(Stream OCNLBBDBIHI, long MIFADOBCMAC, long JCNNPHFBOMP, PLFCMNGIAGA ECMHMDMOHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x809D8D0", Offset = "0x809CCD0", VA = "0x18809D8D0", Slot = "10")]
	internal override bool AJCGEBOBFPA(Stream NHHOHACOPOO, long MIFADOBCMAC, long JCNNPHFBOMP, CCPPLFONDLN CAIINJFADJO, [Out] PLFCMNGIAGA ECMHMDMOHLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x809E580", Offset = "0x809D980", VA = "0x18809E580")]
	private void FGJGHIGHKBH(byte[] DHHEGLJJIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x809E450", Offset = "0x809D850", VA = "0x18809E450", Slot = "11")]
	protected override FileInfo EOOPOFGFDJB(long MIFADOBCMAC, long JCNNPHFBOMP, JFCACKFPDGD GIHOEMBHLDB, MCMOEPGLMEN AGBOFEFHDBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x809E340", Offset = "0x809D740", VA = "0x18809E340", Slot = "12")]
	protected override DirectoryInfo ECMEPHNGFPK(JFCACKFPDGD GIHOEMBHLDB, MCMOEPGLMEN AGBOFEFHDBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
public enum JHEPPKFKLJA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40007E4")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40007E5")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40007E6")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
internal class BOOPABDMMJD : GBMHKFGAAKM
{
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[CompilerGenerated]
	private sealed class JJOPBHHPDKP : IEnumerable<CKKDNBIBBCP>, IEnumerable, IEnumerator<CKKDNBIBBCP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		private CKKDNBIBBCP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		public BOOPABDMMJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private JFCACKFPDGD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		public JFCACKFPDGD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		private JHEPPKFKLJA[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		private IEnumerator<CKKDNBIBBCP> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		private CKKDNBIBBCP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xDE6750", Offset = "0xDE5B50", VA = "0x180DE6750")]
		[DebuggerHidden]
		public JJOPBHHPDKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x80A36F0", Offset = "0x80A2AF0", VA = "0x1880A36F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x80A32C0", Offset = "0x80A26C0", VA = "0x1880A32C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x80A35A0", Offset = "0x80A29A0", VA = "0x1880A35A0")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x80A36A0", Offset = "0x80A2AA0", VA = "0x1880A36A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x80A35F0", Offset = "0x80A29F0", VA = "0x1880A35F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CKKDNBIBBCP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x80A35F0", Offset = "0x80A29F0", VA = "0x1880A35F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007E7")]
	private readonly JHEPPKFKLJA[] CLBJGGFGIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007E8")]
	private readonly Dictionary<JHEPPKFKLJA, GBMHKFGAAKM> DEIFFNCEEHI;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public JHEPPKFKLJA JBACIEDJFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x8098E00", Offset = "0x8098200", VA = "0x188098E00", Slot = "4")]
		get
		{
			return default(JHEPPKFKLJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x8098EC0", Offset = "0x80982C0", VA = "0x188098EC0")]
	[UnityEngine.Scripting.Preserve]
	public BOOPABDMMJD(params GBMHKFGAAKM[] NBHMBPHMBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x8098CB0", Offset = "0x80980B0", VA = "0x188098CB0", Slot = "5")]
	public bool JHHKOFPBOED(long MIFADOBCMAC, long JCNNPHFBOMP, JFCACKFPDGD GIHOEMBHLDB, [Out] CKKDNBIBBCP CEDHNEPJPLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x8098980", Offset = "0x8097D80", VA = "0x188098980")]
	private void AFELGFJEBCC(int HAKFCPHADCF, long MIFADOBCMAC, long JCNNPHFBOMP, JFCACKFPDGD GIHOEMBHLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x8098E30", Offset = "0x8098230", VA = "0x188098E30", Slot = "6")]
	[IteratorStateMachine(typeof(JJOPBHHPDKP))]
	public IEnumerable<CKKDNBIBBCP> MIPDJJJKIJE(JFCACKFPDGD GIHOEMBHLDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x8098BC0", Offset = "0x8097FC0", VA = "0x188098BC0", Slot = "7")]
	public CKKDNBIBBCP FLAAOIDEDHM(long MIFADOBCMAC, long JCNNPHFBOMP, PLFCMNGIAGA ECMHMDMOHLI, JFCACKFPDGD GIHOEMBHLDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
internal static class JNCMPLKIDDD
{
	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x80A3780", Offset = "0x80A2B80", VA = "0x1880A3780")]
	internal static byte[] BILNGEOLLLO(byte[] DHHEGLJJIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x80A3840", Offset = "0x80A2C40", VA = "0x1880A3840")]
	public static void GENNJMMDKBC(Stream DHNIJNCIKDC, byte[] PFPGIOEIJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x80A38C0", Offset = "0x80A2CC0", VA = "0x1880A38C0")]
	public static bool JNELINDMJBG(Stream DHNIJNCIKDC, long DJIOEHNGCPA, CCPPLFONDLN GBIKANHNGLB, [Out] byte[] JBLJGMBBIIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
internal sealed class PLAMICGLKAL : CKKDNBIBBCP, IEquatable<CKKDNBIBBCP>, IEquatable<PLAMICGLKAL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F6")]
	private readonly DHNGKNLLHCN BKOIFKEAJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007F7")]
	public readonly FileInfo MHEHEPMGBLG;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public JHEPPKFKLJA JBACIEDJFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x798EAF0", Offset = "0x798DEF0", VA = "0x18798EAF0", Slot = "9")]
		get
		{
			return default(JHEPPKFKLJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public DateTime BJLNCFEJNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x80A5E90", Offset = "0x80A5290", VA = "0x1880A5E90", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x80A6380", Offset = "0x80A5780", VA = "0x1880A6380")]
	public PLAMICGLKAL(DHNGKNLLHCN LCKIEHPLCKO, FileInfo AKLEFFEABNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x80A62D0", Offset = "0x80A56D0", VA = "0x1880A62D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x80A6210", Offset = "0x80A5610", VA = "0x1880A6210", Slot = "5")]
	public void LPLHDDCDICF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x80A6140", Offset = "0x80A5540", VA = "0x1880A6140", Slot = "6")]
	public bool GEGGBOPFAEM(long MIFADOBCMAC, long JCNNPHFBOMP, [Out] PLFCMNGIAGA ECMHMDMOHLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x80A60D0", Offset = "0x80A54D0", VA = "0x1880A60D0", Slot = "7")]
	public bool Equals(CKKDNBIBBCP KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x80A5F20", Offset = "0x80A5320", VA = "0x1880A5F20", Slot = "8")]
	public bool Equals(PLAMICGLKAL KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x80A5FE0", Offset = "0x80A53E0", VA = "0x1880A5FE0", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x80A6180", Offset = "0x80A5580", VA = "0x1880A6180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
public delegate void CCPPLFONDLN(NOGKHBFIKBD.GGJNLOGIEPC FCJAMLOPNNN, string DAMFJFKKFBI);
[Cpp2IlInjected.Token(Token = "0x20001CE")]
internal interface GBMHKFGAAKM
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	JHEPPKFKLJA JBACIEDJFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JHHKOFPBOED(long MIFADOBCMAC, long JCNNPHFBOMP, JFCACKFPDGD GIHOEMBHLDB, [Out] CKKDNBIBBCP CEDHNEPJPLG);

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<CKKDNBIBBCP> MIPDJJJKIJE(JFCACKFPDGD GIHOEMBHLDB);

	[Cpp2IlInjected.Token(Token = "0x6000746")]
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
