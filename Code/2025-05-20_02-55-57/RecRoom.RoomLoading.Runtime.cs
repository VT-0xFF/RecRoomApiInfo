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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x849ED30", Offset = "0x849DF30", VA = "0x18849ED30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
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
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x849ABA0", Offset = "0x8499DA0", VA = "0x18849ABA0", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84A2250", Offset = "0x84A1450", VA = "0x1884A2250", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class PBCMLGFCOJP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x84A0A30", Offset = "0x849FC30", VA = "0x1884A0A30")]
	public PBCMLGFCOJP(string BDAAPBJEHGD, Exception DBEGDJHGEMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class MFKJCCFPIEE : PHMHBHANNFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LCJIHDJCPOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<PFLEEJFBOMH>> <>t__builder;

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
		private TaskAwaiter<KHJJFNOMMBL<IACGOJIMLMI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8491360", Offset = "0x8490560", VA = "0x188491360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84915A0", Offset = "0x84907A0", VA = "0x1884915A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HCEDKEADDON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<JOAINFLCKGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<JOAINFLCKGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x848AED0", Offset = "0x848A0D0", VA = "0x18848AED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x848B0E0", Offset = "0x848A2E0", VA = "0x18848B0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	[UnityEngine.Scripting.Preserve]
	public MFKJCCFPIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x849BFF0", Offset = "0x849B1F0", VA = "0x18849BFF0", Slot = "4")]
	[AsyncStateMachine(typeof(LCJIHDJCPOO))]
	public Task<IReadOnlyList<PFLEEJFBOMH>> IMLICNLMJBI(long BENLNHBBIME, long OECKHCOHBDG, [Optional] CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x849BEE0", Offset = "0x849B0E0", VA = "0x18849BEE0", Slot = "5")]
	[AsyncStateMachine(typeof(HCEDKEADDON))]
	public Task<IReadOnlyList<JOAINFLCKGF>> FMAIGFMJDAI(IReadOnlyList<int> IHOLCANINIK, [Optional] CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DENHJHBGJNP : IEquatable<DENHJHBGJNP>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int DAGBGKBONBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	JOAINFLCKGF LJPGAACMOPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime IIPEFGLGDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	OHGJBEJJKAO? DPEBAEKCPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	PFPLJFNADEF? DJAKICFFDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	NGIIPBFLOMF OEDALMFLDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<BAKFNEOFNEC> IAJLKPDJOGG();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum NGIIPBFLOMF
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PHMHBHANNFG
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<PFLEEJFBOMH>> IMLICNLMJBI(long BENLNHBBIME, long OECKHCOHBDG, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<JOAINFLCKGF>> FMAIGFMJDAI(IReadOnlyList<int> IHOLCANINIK, [Optional] CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MPPGEDLNLOG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class PPMNANOEAOP : DENHJHBGJNP, IEquatable<DENHJHBGJNP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct OEHJAPCJNDF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<BAKFNEOFNEC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public PPMNANOEAOP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private KBPOKGNGKKF <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<JKGEOIDCPBI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<BAKFNEOFNEC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x849F740", Offset = "0x849E940", VA = "0x18849F740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x849FCD0", Offset = "0x849EED0", VA = "0x18849FCD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly PFLEEJFBOMH JCBKIHNIPCB;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int DAGBGKBONBH
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public JOAINFLCKGF LJPGAACMOPO
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime FBIKLHIKGIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x84A0FB0", Offset = "0x84A01B0", VA = "0x1884A0FB0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OHGJBEJJKAO? DPEBAEKCPKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x29ED8F0", Offset = "0x29ECAF0", VA = "0x1829ED8F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public PFPLJFNADEF? DJAKICFFDPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x84A0CA0", Offset = "0x849FEA0", VA = "0x1884A0CA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NGIIPBFLOMF OEDALMFLDOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xBE2300", Offset = "0xBE1500", VA = "0x180BE2300", Slot = "10")]
			get
			{
				return default(NGIIPBFLOMF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x84A0EB0", Offset = "0x84A00B0", VA = "0x1884A0EB0", Slot = "9")]
		[AsyncStateMachine(typeof(OEHJAPCJNDF))]
		public Task<BAKFNEOFNEC> IAJLKPDJOGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x84A0FD0", Offset = "0x84A01D0", VA = "0x1884A0FD0")]
		public PPMNANOEAOP(int OCGAFMKFMMN, JOAINFLCKGF FBPMNHBAMPK, PFLEEJFBOMH JCBKIHNIPCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84A0DA0", Offset = "0x849FFA0", VA = "0x1884A0DA0", Slot = "11")]
		public bool Equals(DENHJHBGJNP FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84A0D00", Offset = "0x849FF00", VA = "0x1884A0D00", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84A0CC0", Offset = "0x849FEC0", VA = "0x1884A0CC0")]
		private bool DDJPEOIBENI(PPMNANOEAOP FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84A0E30", Offset = "0x84A0030", VA = "0x1884A0E30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class DLNLJLLLJIK : DENHJHBGJNP, IEquatable<DENHJHBGJNP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct DJIFDOLOJMJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<BAKFNEOFNEC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public DLNLJLLLJIK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<BAKFNEOFNEC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8485DA0", Offset = "0x8484FA0", VA = "0x188485DA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8485FF0", Offset = "0x84851F0", VA = "0x188485FF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly LDMGLHEANGA LJEAEGNAHAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly OHGJBEJJKAO ECLDMCFDOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly PFPLJFNADEF LDKACFAOKAE;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int DAGBGKBONBH
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8486110", Offset = "0x8485310", VA = "0x188486110", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public JOAINFLCKGF LJPGAACMOPO
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8486460", Offset = "0x8485660", VA = "0x188486460", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime FBIKLHIKGIA
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x84864F0", Offset = "0x84856F0", VA = "0x1884864F0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public OHGJBEJJKAO? DPEBAEKCPKD
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8486410", Offset = "0x8485610", VA = "0x188486410", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PFPLJFNADEF? DJAKICFFDPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8486060", Offset = "0x8485260", VA = "0x188486060", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NGIIPBFLOMF OEDALMFLDOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xBE5C50", Offset = "0xBE4E50", VA = "0x180BE5C50", Slot = "10")]
			get
			{
				return default(NGIIPBFLOMF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B350", Offset = "0x1E7A550", VA = "0x181E7B350")]
		public DLNLJLLLJIK(LDMGLHEANGA HGIBJDOBNNM, OHGJBEJJKAO FCBJLGEKDNE, PFPLJFNADEF NONCLFKNDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8486320", Offset = "0x8485520", VA = "0x188486320", Slot = "9")]
		[AsyncStateMachine(typeof(DJIFDOLOJMJ))]
		public Task<BAKFNEOFNEC> IAJLKPDJOGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8486150", Offset = "0x8485350", VA = "0x188486150", Slot = "11")]
		public bool Equals(DENHJHBGJNP FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84861F0", Offset = "0x84853F0", VA = "0x1884861F0", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84860B0", Offset = "0x84852B0", VA = "0x1884860B0")]
		private bool DDJPEOIBENI(DLNLJLLLJIK FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84862A0", Offset = "0x84854A0", VA = "0x1884862A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class CFBAIOIODEP : DENHJHBGJNP, IEquatable<DENHJHBGJNP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct JDLPGLPBBHF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<BAKFNEOFNEC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<BAKFNEOFNEC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x848F7F0", Offset = "0x848E9F0", VA = "0x18848F7F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x848FA50", Offset = "0x848EC50", VA = "0x18848FA50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly JOAINFLCKGF MJDNJEFLNDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly OHGJBEJJKAO ECLDMCFDOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly PFPLJFNADEF LDKACFAOKAE;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int DAGBGKBONBH
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x84850B0", Offset = "0x84842B0", VA = "0x1884850B0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public JOAINFLCKGF LJPGAACMOPO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime FBIKLHIKGIA
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public OHGJBEJJKAO? DPEBAEKCPKD
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8485320", Offset = "0x8484520", VA = "0x188485320", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public PFPLJFNADEF? DJAKICFFDPF
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8484F80", Offset = "0x8484180", VA = "0x188484F80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NGIIPBFLOMF OEDALMFLDOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "10")]
			get
			{
				return default(NGIIPBFLOMF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B350", Offset = "0x1E7A550", VA = "0x181E7B350")]
		public CFBAIOIODEP(JOAINFLCKGF FBPMNHBAMPK, OHGJBEJJKAO FCBJLGEKDNE, PFPLJFNADEF NONCLFKNDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8485250", Offset = "0x8484450", VA = "0x188485250", Slot = "9")]
		[AsyncStateMachine(typeof(JDLPGLPBBHF))]
		public Task<BAKFNEOFNEC> IAJLKPDJOGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8485150", Offset = "0x8484350", VA = "0x188485150", Slot = "11")]
		public bool Equals(DENHJHBGJNP FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84850D0", Offset = "0x84842D0", VA = "0x1884850D0", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84851C0", Offset = "0x84843C0", VA = "0x1884851C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8484FD0", Offset = "0x84841D0", VA = "0x188484FD0")]
		private bool DDJPEOIBENI(CFBAIOIODEP FNJGMJGALLH)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct DPDALKBCBOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<DENHJHBGJNP>> <>t__builder;

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
		public MPPGEDLNLOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<PFLEEJFBOMH> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<PFLEEJFBOMH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, JOAINFLCKGF account, PFLEEJFBOMH roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x84875E0", Offset = "0x84867E0", VA = "0x1884875E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8488420", Offset = "0x8487620", VA = "0x188488420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct KIHJKAELAEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, JOAINFLCKGF account, PFLEEJFBOMH roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<PFLEEJFBOMH> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public MPPGEDLNLOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<JOAINFLCKGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8490220", Offset = "0x848F420", VA = "0x188490220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8490BF0", Offset = "0x848FDF0", VA = "0x188490BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly GNFHNBGBBHA GIKKKNEBJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly PHMHBHANNFG MBNAFFLCHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly HDMDFMDDCIJ HELCCAKDKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly JBIBALGPAGF<(long, long), IReadOnlyList<PFLEEJFBOMH>> HJINDDKECHL;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x849E850", Offset = "0x849DA50", VA = "0x18849E850")]
	[UnityEngine.Scripting.Preserve]
	public MPPGEDLNLOG([ALHAHLCGLLK(null)] PHMHBHANNFG MLGOMPPOIJF, [ALHAHLCGLLK(null)] HDMDFMDDCIJ AGDBNNFECEF, [ALHAHLCGLLK(null)] GNFHNBGBBHA GFFKJINPAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x849E450", Offset = "0x849D650", VA = "0x18849E450")]
	[AsyncStateMachine(typeof(DPDALKBCBOG))]
	public Task<IList<DENHJHBGJNP>> APDPLNNFGMA(long BENLNHBBIME, long DLHGMNACNGF, bool FKDHIEJEMPD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x849E5A0", Offset = "0x849D7A0", VA = "0x18849E5A0")]
	private bool DGNMGMLLIJE(DateTime? HHCGEFPNHGG, long BENLNHBBIME, long DLHGMNACNGF, [Out] LDMGLHEANGA NCCNNAGALKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x849E740", Offset = "0x849D940", VA = "0x18849E740")]
	[AsyncStateMachine(typeof(KIHJKAELAEJ))]
	private Task<IReadOnlyList<(int, JOAINFLCKGF, PFLEEJFBOMH)>> PJPBHJHFEGA(IReadOnlyList<PFLEEJFBOMH> KANPPGHCFLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HDMDFMDDCIJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<LDMGLHEANGA> PBNDMJKGHPD;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ALJECKCPJHN(long BENLNHBBIME, long DLHGMNACNGF, NOBGLNGJEOC FENKMKKCLAD, KMPELHDOPPN MNDHCACEDBN);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CAEDHDJHOLC(long BENLNHBBIME, long DLHGMNACNGF, [Out] LDMGLHEANGA NCCNNAGALKA);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MMCEIIAEHMP(long BENLNHBBIME, long DLHGMNACNGF, KMPELHDOPPN MNDHCACEDBN, [Out] LDMGLHEANGA NCCNNAGALKA);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PECBNIMNOML(long BENLNHBBIME, long DLHGMNACNGF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface OLBGBKMPEDD : MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HECADAFOPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task JNPAOCAKGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JAAJHBGCPAP(Task LDLKICLCOAG, string KANNOFPGEHC);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface OLPLOOGCKPM : MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BAKFNEOFNEC> HPLAFMHEMPO(LDMGLHEANGA NCCNNAGALKA);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GCGJFELMJCF(CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface FEEFIKKCALC : MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	KFHGIGIDJID PIPFJHGKIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJDOKICFBEG();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LFPLENEDCDI();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface MGBHAJGBNCO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ILLMBOBOELN(MEBNIAGNGEK LLMBGPNPABD);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface GJCPHMABOGP
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan HMBEPDMCLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan ABPOJNILEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan NBIOIOKAJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan NFLFDMGHDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool DIMCJIMPEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool NLDDBBGEAIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DJLCMHGMGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int NPAPONBPHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool OOKEJLCDKDK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool PBBDIGBAMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool EKGCHOJHFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum IMFFICEMKMP
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum OLELLGCFNAL
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
public struct DBJKOHCNHMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long BPLMJDMGKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long OECKHCOHBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly IMFFICEMKMP EDLOHJEBKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception DOAIOFKENPB;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84853C0", Offset = "0x84845C0", VA = "0x1884853C0")]
	public DBJKOHCNHMF(long BPLMJDMGKND, long OECKHCOHBDG, IMFFICEMKMP EDLOHJEBKFM, [CanBeNull] Exception DOAIOFKENPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8485370", Offset = "0x8484570", VA = "0x188485370")]
	public static DBJKOHCNHMF JHLKCEPMGDF(LDKIAIAGMBD GKFNJKIIEEL, IMFFICEMKMP EDLOHJEBKFM, [Optional] Exception DOAIOFKENPB)
	{
		return default(DBJKOHCNHMF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void JOALIPKLKDJ(DBJKOHCNHMF JFHHMNEAJLO);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface JJOKMDOJOMN : MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action OCBODCPMEJO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event JOALIPKLKDJ HLLJBOKGGCG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JOALIPKLKDJ JNDANJCEELM;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event JOALIPKLKDJ ILKIPLEJHPP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<OLELLGCFNAL, bool> LOJMNDHNBKP;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FPGEMNJBBID();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FPMKDNGEGDH(DBJKOHCNHMF JFHHMNEAJLO);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OEMPEHADAFD(DBJKOHCNHMF JFHHMNEAJLO);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MKDFDOPLEDJ(DBJKOHCNHMF JFHHMNEAJLO);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MFGOLLAGCMD(OLELLGCFNAL LCIBBKGCJFA, bool MAEMMABLBFK);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface DLBFDEDKKIP : MGBHAJGBNCO, IDisposable
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
	bool FIGGMKEGKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LEKMCIEFFOK(Reason BPAILNFLNFH = Reason.Unknown);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MELKLOLMFIP();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface FKJNHFGFCKO : MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus HHCPBPCCFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FJFIGNDLJBP(LDKIAIAGMBD KMOFNLCOIND, DKFFONJNCCB FMGLLICHMEL, CancellationToken DMKDGAIEPFB);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class KCNLJCLFOAG
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x84901D0", Offset = "0x848F3D0", VA = "0x1884901D0")]
	public static bool LBMIIDBDGPF(this FKJNHFGFCKO LNMPHMOJHEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task HCJIFMBBOCA(CancellationToken PPOILDCNBFL, int ABBDMCLAHED, ODJGKIKFMEP FEOKJEOAMPL);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface CALKIGGPPIO : MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GJGKOGJNFLA(HCJIFMBBOCA KJCPAPIMKJK);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface MEBNIAGNGEK : KBPOKGNGKKF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken LAKCOHHMPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	HILJAABEPDC LKMNPKLONEA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	LKDJDKEKNAC FJJGNIKEKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	DBILADPCAAF IIFIJPMCMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	LAMEDCHOMHL LMBINNBIMPB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	KBHPCHHAFMJ LDJLFEGHNAM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	PFIGMICDKCM CPGDLFKCNFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	EHKLKJJGGDO JNMNNDGDAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	MHBBONFJJIK OFGKMLIGPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	OLBGBKMPEDD KKKGNAAAJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	OLPLOOGCKPM LKKEJIIGDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	JJOKMDOJOMN HOBJACLOFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	DLBFDEDKKIP FDBPCKHGEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	FKJNHFGFCKO LEMGOBPFFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CALKIGGPPIO GFPKPNCIODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	AFKJMJFJBOK DGHPACHFGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	KGIPECMHEKG ADCJBCCGLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	EKDHJNKDHJK NHMDADCGLNB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	PGINMAMCAGF BECNDDGDNPN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	ALEJNHMPADG PHPIOMCAMAK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	BCELOMMLBPF GPGKOLGNGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	ICFDEOCFBGL LBHHEHCHBLP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	CAFJFKGMMAP OIOCJCCIHJI
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	GCONNCCNCHF OBOCKNKFPIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	COGAEPFNDJG PHMKKGJKKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	FEEFIKKCALC IIINACJFBPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	GJCPHMABOGP HLIEPEFDHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	BNBGAHNOJKP FMAGACAPCKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	HDMDFMDDCIJ HOMADGCKDHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	FGCOLJKEGJL ECIMALGALDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	NAEGGHPNDKJ HCHFAPIPLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	GHPBGHDHCCH DPIGDCKOOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	KBBKDEGOKGN KEPBKLCOKHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool EMIEKLMCMBJ
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
	void LGDFPMNGDFH(DKFFONJNCCB GABLFEAOAMM);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface AFKJMJFJBOK : MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FAOABMFLDEO OOLDDNFEGEK(Guid BOAAABDJCPH);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KKKHDEJPLIG(Guid BOAAABDJCPH);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GADJKGKHEOI(Guid BOAAABDJCPH, Task MONDHIAMLMP);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LPGGCODEBAN(Guid BOAAABDJCPH, BAKFNEOFNEC NANNDNMCNJC);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(BAKFNEOFNEC, Task)> LMDPHEHCELP(Guid BOAAABDJCPH);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface CJNBIMMBOOP : MGBHAJGBNCO, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface KGIPECMHEKG : MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPPDMHAFNND(CBMIKICCFNL BDAAPBJEHGD);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCDIKKFFJOA(CBMIKICCFNL BDAAPBJEHGD);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<LGKCOAGJCFN> GHOBKEFLLNG(CancellationToken CDJPCHILKDL);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface EKDHJNKDHJK : MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FAOABMFLDEO NHJCLOAIBOG(CBMIKICCFNL FHKILDIHLGE);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAIFGPKOAFA(Guid BOAAABDJCPH, Task MONDHIAMLMP);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface PGINMAMCAGF : MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BAKFNEOFNEC> BECNDDGDNPN(CBMIKICCFNL BHGDNHJGCCJ);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface ALEJNHMPADG : MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IAAJJFDJPDA> NPOIDNKGBKH(EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, LDKIAIAGMBD KMOFNLCOIND, CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface ICFDEOCFBGL : MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BAKFNEOFNEC CBOEBOKBMNC(KPDBONCIMNC EEODOEPMOBC);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BOCMMCODOFC(string PJPBBAPADDN);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface BCELOMMLBPF : MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CBMIKICCFNL> JOHDGNGBKJF(CBMIKICCFNL MGALKMHOLCM, IHKEKBDONBN DFBIOGENMMF, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CBMIKICCFNL> AAJDEKCCHFA(CancellationToken HCELDNOKOAM, IHKEKBDONBN DFBIOGENMMF);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FBMKMKEAMFG BILFDBJLLJA(GLOBKHNLMMN GFJNKCCMOOO, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FBMKMKEAMFG OKOPNGCAFIM(GLOBKHNLMMN GFJNKCCMOOO, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface CAFJFKGMMAP : MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BAKFNEOFNEC JAAOAHCPHKC(KPDBONCIMNC EEODOEPMOBC, LGKCOAGJCFN PBGOMDAJBLP);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BAKFNEOFNEC KPKLOPNEMKJ(KPDBONCIMNC MAGKLMEPFAD);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface BNEBLNMMBKE
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	const int LKGKPACDFFE = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, LGJBBKMIBIM> NLHKEFKKEJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action EGKCMAICEAA
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
	IReadOnlyList<Guid> ANJNIJOMLEJ();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task CIAGAIKJFOL([Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task FBEBDCAJOND([Optional] CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface GCONNCCNCHF
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ODNPDNNKJLF(FPHPINCHKOK LFKFDAAOPKP);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHPMNIOHNNA(FPHPINCHKOK LFKFDAAOPKP);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EHADCDONIBO(FPHPINCHKOK LFKFDAAOPKP);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MJAJPMHJFLJ(FPHPINCHKOK LFKFDAAOPKP);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class FPHPINCHKOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly LDKIAIAGMBD PGLHEFACLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Dictionary<string, string> EEBKBPPGIOO;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public EAIPOBMEIGP<string> BPEFOBMCGHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public FPHPINCHKOK(LDKIAIAGMBD MDLGPLHBALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x848A2F0", Offset = "0x84894F0", VA = "0x18848A2F0")]
	public FPHPINCHKOK MNEEOBDONKP(string AGBHGDFILGO, string MLCDCHNOCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x848A260", Offset = "0x8489460", VA = "0x18848A260")]
	public bool FPLOCPEDDNF([Out] IEnumerable<KeyValuePair<string, string>> LLLDAGGOIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7319740", Offset = "0x7318940", VA = "0x187319740")]
	public FPHPINCHKOK NPOMMPEGLON(EAIPOBMEIGP<string> AGHDGMNHDIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface BNBGAHNOJKP
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool LMADCKHFKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string IIPBAJODLCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool DBOEBDGPHCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BAAFCGMLEPM();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HBHCIFDDHPO NBNHIIIEFOA(long GKDHCJGNLGL);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FIMKINNJGKA<ELAGIFLJMJI, HAPGMLIDNII> JMNGINNEPGO(long GKDHCJGNLGL);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FIMKINNJGKA<ELAGIFLJMJI, CBMANFMCNIJ> FLPLDOKNIBC(long GKDHCJGNLGL);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FIMKINNJGKA<long, LPOALELDKHA> GKKNGEJJHMB();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<PPPFLOFMGEF>> BELMFMBCIKN(long GKDHCJGNLGL, IReadOnlyCollection<PPPFLOFMGEF> DDEKEBCFHMF, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DMJEECANJAD(long GKDHCJGNLGL, [Out] bool DGKLOMCAPHJ);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> DEIEFNIFDFM(byte[] ALDFCBINAND, byte[] OHFDGJIJNKH, IReadOnlyCollection<Guid> AHIDAAHILKM, CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface AJFCPCJPLCN
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IAAJJFDJPDA EAIFKKLDBGP(long BPLMJDMGKND, long OECKHCOHBDG, string HKPLMIHOJLJ);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IAAJJFDJPDA EAIFKKLDBGP(long BPLMJDMGKND, long OECKHCOHBDG, ELAGIFLJMJI ALDFCBINAND, Guid? DBOJAFAJJAG, long IOPIKANEPAB, bool FCBMODOACPJ);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IAAJJFDJPDA EAIFKKLDBGP(PDHIEPEKDIL CLHMIEKOHKD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IAAJJFDJPDA EAIFKKLDBGP(JKGEOIDCPBI HFCPGIJLMJB, PFLEEJFBOMH KHGFGMFNBDK);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface KBPOKGNGKKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool LBMIIDBDGPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool FFPIIECJGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool EMIEKLMCMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	AJFCPCJPLCN MPCLPNIGBFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	DKFFONJNCCB JDBOBIAGMHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action OCBODCPMEJO;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event JOALIPKLKDJ HLLJBOKGGCG;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event JOALIPKLKDJ JNDANJCEELM;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event JOALIPKLKDJ ILKIPLEJHPP;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<OLELLGCFNAL, bool> LOJMNDHNBKP;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MELKLOLMFIP();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GNEDCFKEHAA EJEKLCCBGPC();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	OBBAMKBGNID PAFJPJNFGFN();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task OPKCFPMDMEJ(int FBJJKIBIHMG, AMCBFCIFFOH EBNNDHKBAPE, Func<NOBGLNGJEOC, NOBGLNGJEOC> NDNPCGCGOEI);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<BAKFNEOFNEC> HPLAFMHEMPO(LDMGLHEANGA HGIBJDOBNNM);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task GCGJFELMJCF(CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface KBHPCHHAFMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool HLNFEBAECHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool FEMAPBEPILD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? BPPPCPGCBLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOEHAJKHEPF(Scene FNJADBFFJBC);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task IOIKEEGAIGH(HFOBIEDOLJN FIICHJGNPHN, IReadOnlyList<HFOBIEDOLJN> BKLCDDMJGOA, IReadOnlyList<HFOBIEDOLJN> KPADFFDJCPK, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NKLJBLLBIDP(Guid LIPEAFABIEA, IReadOnlyList<Guid> AHIDAAHILKM, EHEPJEAAANC OCHKHDDKHIC, [Optional] object PDGGKJDFGPC);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task HOGCPHHBLAO(IReadOnlyList<Guid> PPAAPFEENEN, CancellationToken ALFKNKAGCKO);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JEEMOCELCPM GDPJLANBEAP();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task INFMPKBLGOE();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ELFKNHNBFME(GameObject FOEGMFMLJCB);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task EANOOEDAIOL();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface LAMEDCHOMHL
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	MOALAMGIMLB LHDJPHOLKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool MMGMIHMNLJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool LMOJEENBPCD
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool OCIHJGLOMAD
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool FCDLGMFKJKC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int BKBOBBIPNOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool OJJFMBAOPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool OBIIKNAKOLB
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int FEAFOPGCHIB
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int MLCBKOEJJAB
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool BBFAAKDJEEC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool KJHGNMKEIKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool BBBBEHHGCHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float DAKBJHDCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> PLIGGCLKINO;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HILJAABEPDC LBKNHFOFJDH(HILJAABEPDC EHJIEHKGOBN);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KNAABBGFIFK(HILJAABEPDC NPCDKJJJIDL);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LHMKGHLGEHE();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task LGNFIHGNNLG(EAIPOBMEIGP<string>.MNKIBAEKPMC KKEKMEFLIML, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DLHDPKDPAPN(float IMNNIMPHNKE);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OLPCODFCCAL(string BFICFCBIIPI);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<ICLKLOMOCNH> BHDNKJBEPNE();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable JMLFDIOEGCA(object OPJOIGJBJKN, ICLKLOMOCNH LKMFAJMIACB);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<COGKCPDJMJE> ODKOGIBOFNI();

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HAPGMLIDNII CFBKFKEEGME(IEnumerable<AOAEIBCNJOH> JBDOMHNKPDL);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NDIJACMLGAJ(int DEBMEFDDEDD);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task BJFFOAGHCKI();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EIEBDNDMEPK();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool HCFKAKGAGHM();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task COKNLNEJHHE(CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task HGACOOCPKAC(CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<GNJANIPNJFB> HLOPPHILKNF(DateTime CCLBLPBNNKO, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> HMOKCFKIFBO(CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CAINOILJECP(string BDAAPBJEHGD = "", float NJODBBGOGON = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "25")]
	JEKOHOLAJIK LFHHGABMAPK(EGJEOIABGDI FFKLHEMIAPD, AGMAHEAGHKP ABCGNDCNMLD, CBMANFMCNIJ HAKHLEEIOLA, IEnumerable<PersistenceView> JPLHCDMAEKF, HBKODKOLCMP HMEMHGFCCGD);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void POIBJGPNBPO(CBMANFMCNIJ HAKHLEEIOLA);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CMFPJJHKAAG(AOAEIBCNJOH COAOCPHILMM, [In] JEKOHOLAJIK PKGLEOPIBMF);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task KMHOHKGNONC(CBMANFMCNIJ HIOKFECJHKI, bool MPIEAGHGJCB, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task PBFHHKNNFLJ(CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GBOHBCOPJOM(long BENLNHBBIME, long OECKHCOHBDG, JKGEOIDCPBI GKCIPCHGLOA, PFLEEJFBOMH ACEBOLCFHGN, NOBGLNGJEOC FENKMKKCLAD, AMCBFCIFFOH? EBNNDHKBAPE, OEKDMCDJKCL? JJKOKCGHAHO);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void MBJFHIAIHCJ(long BENLNHBBIME, long OECKHCOHBDG, OEKDMCDJKCL? JJKOKCGHAHO);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void KNEKJLKDDEJ(PersistenceView JJELANFOBMH);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void CLHBMLCFKKK(string AMPMPNLBCLJ, LDKIAIAGMBD MDLGPLHBALF, BMFIAEEKEEC KJBOCECGEEL, [Optional] string? ICLMPAFIBJC, [Optional] string? HBFFAEKCENM, [Optional] string? AADIDMILKGP);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool JGGCGHGOLKM(PersistenceView DMGGONLOPJG);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool ECEPKFAIMOO(AOAEIBCNJOH COAOCPHILMM, PHALJEJMFGJ CDJGDGHHGEH, [Out] KPFBBJDLKAE GHPMBNPOFHO);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task FICNJDABHKD(CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void CCFLGPJCMAA();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable HILFBHLLBMB();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void BIBKILIJCOC(CBMANFMCNIJ HIOKFECJHKI, PHALJEJMFGJ CDJGDGHHGEH);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> BDEHAADCBKM(LKDJDKEKNAC GCMEJOEAFHA, CancellationToken HCELDNOKOAM, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void EABLGLGBCBH(CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<PDHIEPEKDIL> DEBAKLDJHDP(LPBKHGAEKND MGALKMHOLCM);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<JKGEOIDCPBI> CAFMMNGPOMG(long BENLNHBBIME, bool ICNBBGAKDMP, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<IACGOJIMLMI> ALEJABNCHHA(long BENLNHBBIME, long OECKHCOHBDG, long IOPIKANEPAB, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<IACGOJIMLMI> HLBNOGGFHOM(long BENLNHBBIME, long OECKHCOHBDG, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<HPNKLCGCBEM> FEPPCMCJIBP(long BENLNHBBIME, Guid CABFGOAMDAM, long? DLHGMNACNGF, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "47")]
	FIMKINNJGKA<HPNKLCGCBEM, IEnumerable<MEGCPPBFEPP>> NJFMNLCLAOC();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<BFBOEDNCMMM> NPNEKNIHCEH(string HKPLMIHOJLJ, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<BFBOEDNCMMM> BACGNMPLMEI(string HKPLMIHOJLJ, long BENLNHBBIME, long OECKHCOHBDG, Guid? LIPEAFABIEA, CLLHCDHAJBH.OEKEMKNECIB GIKGHELDAKC, CLLHCDHAJBH.OEKEMKNECIB OHFDGJIJNKH, int FBJJKIBIHMG);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool BPIPADKMJBG();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool IODOCLJDCPB();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool OANEENMEGBK(IEnumerable<KPFBBJDLKAE> FJMCMOEDKLL);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void EMDCNHAEJDC(List<GameObject> KEBIPHLACDB);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float AELDNKMEPHI();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> OHAFKJBGDON(CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> ODFNMBBBIMI(string OIMMOCPAEDE, LoadSceneMode HJMCGOFELPE, bool PDDFIAPODMK, EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void LGGJFAODPFA();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void MBJOHGHFKNB(bool PGGLOGHIPPK);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void HKKNOKNLGCH();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void HNOOONFKPEC();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void MAMBJKEOJGE(bool JCCEPJIBKPH);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task<CLLHCDHAJBH.OEKEMKNECIB> HAPEKCDGLFF(byte[] DHAOEHNLNON, CLLHCDHAJBH.AFBGEDAFKGO CODLOGLEGPE, BJJFIMOKGBE GBJMIGLAKDE, [Optional] IReadOnlyCollection<string>? OGOKDIIFKAO, [Optional] string? JDKGCNHICAO);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void AJHCDFMCGIC(LDKIAIAGMBD AGODDPHOGHF);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task FJHDGHGOGON(EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task JCALPMNGAAG(EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task EMJGKDMLGFK(EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "77")]
	Task JLCPGNONAAD(EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "78")]
	IDisposable BCDGPLCPJGL();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "79")]
	ADOIDAHHKJO MANLODEIBLL();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "80")]
	Task ELAOKCIICBP(CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface ADOIDAHHKJO
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EEDCDGHEBJB(CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JDELLEJNOCG(CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct JEKOHOLAJIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public HashSet<int> MLEDBJLBNCN;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum GNJANIPNJFB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct EGJEOIABGDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Guid? FMGNEFGHELO;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface MOALAMGIMLB
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	LDKIAIAGMBD MGFLPMIHPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	JKGEOIDCPBI GJEAIDAGIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	LKOOIDABJPJ OJFEIDKEEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool CMGOFEMMILL
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool EEBFMMCHDDH
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int CGJOIAKLMEF
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action HNDNOMDKDCD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> GHDDDODLNOI;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DGKMMAOGHJD();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.BCOKBGGEHOC> FJKOMGMINHD(long GKDHCJGNLGL, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<PFNHANHLLDI> IKOLLECEHKJ(LDKIAIAGMBD MDLGPLHBALF, [Optional] DKFFONJNCCB FMGLLICHMEL);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<PFNHANHLLDI> PIFMFANAFLD();

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task JJDANEJEIEF();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(LDKIAIAGMBD, DKFFONJNCCB) ADDDLFBEEBK();

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "16")]
	GGCHOPOFBKB PHOAAOPHFGC();

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EAODLLNIGAA(long GKDHCJGNLGL);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JPLBPIHHDGE(LDKIAIAGMBD MDLGPLHBALF, Matchmaking.BLHAEFEOGNL IGGKBIDIAJL, (int Major, int? Minor)? KNADPDIBGFF);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface COGAEPFNDJG
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJJPGKMHMHO([Out] IEnumerable<int> BGDMCIIKEFO);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELJOJBHDJNB(AAILLPLJANG PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NNKJLCJHIJI(AAILLPLJANG PPOILDCNBFL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface GGKPPFFBNPI
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IOKNFDHPHOD(BAKFNEOFNEC IOEOAHLDCIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface FOAIEFMKMKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LJGGCBNMKLJ(OEHAJMFFHDL.EBAPFEPHLGO ACOBMPOJHAF);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCEHFGMJGKL(OEHAJMFFHDL.EBAPFEPHLGO ACOBMPOJHAF);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface PFIGMICDKCM : FOAIEFMKMKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BAKFNEOFNEC MJHBNMHLJGH(KPDBONCIMNC MAGKLMEPFAD);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface EHKLKJJGGDO : FOAIEFMKMKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BAKFNEOFNEC CBOEBOKBMNC(KPDBONCIMNC MHLIPNBBNLC);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface HBHCIFDDHPO
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LOAMJJJEMNF<BOLOMBBNDKH, DKPIACPJNCE>> FOEKBNOEJAK(Guid? LIPEAFABIEA, IReadOnlyCollection<PPPFLOFMGEF> FIFIFCJKBDK, IReadOnlyCollection<PPPFLOFMGEF> IJKFNPLGOLJ, JKFADJAFDJI JMNOLGCJADD, long? BENLNHBBIME, long? OECKHCOHBDG, BMDKIDJMNGN.MPGGFACLDBI KAIPLCENELE, CancellationToken HCELDNOKOAM, bool CGFCMNJDPOP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class BOLOMBBNDKH
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public HFOBIEDOLJN HJONGBFDKPD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<HFOBIEDOLJN> IMIPEGFNDJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<HFOBIEDOLJN> COHMPBAFCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xC40420", Offset = "0xC3F620", VA = "0x180C40420")]
	public BOLOMBBNDKH(HFOBIEDOLJN FNHLIFGLEFC, IReadOnlyList<HFOBIEDOLJN> AKJEDGJLLHB, IReadOnlyList<HFOBIEDOLJN> AEKHEOKBNDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface FIMKINNJGKA<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LOAMJJJEMNF<PKKJJPIBJOL<TData>, DKPIACPJNCE>> BJHLEDCOKEB(TGetDataArg HLMDGBFCIDH, CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class ANJACFNOCGB : MEBNIAGNGEK, KBPOKGNGKKF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct GMHEAIKLPOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<BAKFNEOFNEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public ANJACFNOCGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public LDMGLHEANGA autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<BAKFNEOFNEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x848A4A0", Offset = "0x84896A0", VA = "0x18848A4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x848A720", Offset = "0x8489920", VA = "0x18848A720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct FEOPDKJBEAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public ANJACFNOCGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8489510", Offset = "0x8488710", VA = "0x188489510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8489740", Offset = "0x8488940", VA = "0x188489740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class AOLLCDIDGKF : IEnumerable<MGBHAJGBNCO>, IEnumerable, IEnumerator<MGBHAJGBNCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private MGBHAJGBNCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public ANJACFNOCGB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private MGBHAJGBNCO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xE9E930", Offset = "0xE9DB30", VA = "0x180E9E930")]
		[DebuggerHidden]
		public AOLLCDIDGKF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8483860", Offset = "0x8482A60", VA = "0x188483860", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8483CC0", Offset = "0x8482EC0", VA = "0x188483CC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8483C10", Offset = "0x8482E10", VA = "0x188483C10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MGBHAJGBNCO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8483C10", Offset = "0x8482E10", VA = "0x188483C10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CancellationTokenSource NDDMPAKCNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly HILJAABEPDC NPCDKJJJIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool KBCJGENOOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private DLGCPONKCIB KHLGACONFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool DGBNBIBOPBO;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public LKDJDKEKNAC FJJGNIKEKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F24B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public DBILADPCAAF IIFIJPMCMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9F32E0", Offset = "0x9F24E0", VA = "0x1809F32E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9F3300", Offset = "0x9F2500", VA = "0x1809F3300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public LAMEDCHOMHL LMBINNBIMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9F32C0", Offset = "0x9F24C0", VA = "0x1809F32C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9F32D0", Offset = "0x9F24D0", VA = "0x1809F32D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public KBHPCHHAFMJ LDJLFEGHNAM
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9F32F0", Offset = "0x9F24F0", VA = "0x1809F32F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F24A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public PFIGMICDKCM CPGDLFKCNFI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9F3280", Offset = "0x9F2480", VA = "0x1809F3280", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9F3310", Offset = "0x9F2510", VA = "0x1809F3310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public EHKLKJJGGDO JNMNNDGDAEO
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8670", VA = "0x1809F9470", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9F93F0", Offset = "0x9F85F0", VA = "0x1809F93F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public AJFCPCJPLCN MPCLPNIGBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9F94E0", Offset = "0x9F86E0", VA = "0x1809F94E0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9F95B0", Offset = "0x9F87B0", VA = "0x1809F95B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public MHBBONFJJIK OFGKMLIGPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9F9460", Offset = "0x9F8660", VA = "0x1809F9460", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9F94A0", Offset = "0x9F86A0", VA = "0x1809F94A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public OLBGBKMPEDD KKKGNAAAJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xBE1AD0", Offset = "0xBE0CD0", VA = "0x180BE1AD0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x1316000", Offset = "0x1315200", VA = "0x181316000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public OLPLOOGCKPM LKKEJIIGDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9F9400", Offset = "0x9F8600", VA = "0x1809F9400", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9F94C0", Offset = "0x9F86C0", VA = "0x1809F94C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public JJOKMDOJOMN HOBJACLOFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xCDF180", Offset = "0xCDE380", VA = "0x180CDF180", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xE62E80", Offset = "0xE62080", VA = "0x180E62E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public DLBFDEDKKIP FDBPCKHGEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9F8B10", Offset = "0x9F7D10", VA = "0x1809F8B10", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9F8AD0", Offset = "0x9F7CD0", VA = "0x1809F8AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public FKJNHFGFCKO LEMGOBPFFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xD6D9C0", Offset = "0xD6CBC0", VA = "0x180D6D9C0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xE70820", Offset = "0xE6FA20", VA = "0x180E70820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public CALKIGGPPIO GFPKPNCIODM
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xD51D30", Offset = "0xD50F30", VA = "0x180D51D30", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xD51D40", Offset = "0xD50F40", VA = "0x180D51D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public AFKJMJFJBOK DGHPACHFGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xCDEFB0", Offset = "0xCDE1B0", VA = "0x180CDEFB0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x116ED50", Offset = "0x116DF50", VA = "0x18116ED50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public CJNBIMMBOOP IMDKHFEKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xCCA9E0", Offset = "0xCC9BE0", VA = "0x180CCA9E0", Slot = "62")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xD7F160", Offset = "0xD7E360", VA = "0x180D7F160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public KGIPECMHEKG ADCJBCCGLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xAA3910", Offset = "0xAA2B10", VA = "0x180AA3910", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xAA38F0", Offset = "0xAA2AF0", VA = "0x180AA38F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public EKDHJNKDHJK NHMDADCGLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9F8AC0", Offset = "0x9F7CC0", VA = "0x1809F8AC0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x9F8B20", Offset = "0x9F7D20", VA = "0x1809F8B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public PGINMAMCAGF BECNDDGDNPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAC8BA0", Offset = "0xAC7DA0", VA = "0x180AC8BA0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xBC0D60", Offset = "0xBBFF60", VA = "0x180BC0D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public ALEJNHMPADG PHPIOMCAMAK
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4350", Offset = "0xAC3550", VA = "0x180AC4350", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xAC3220", Offset = "0xAC2420", VA = "0x180AC3220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public BCELOMMLBPF GPGKOLGNGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xAA8460", Offset = "0xAA7660", VA = "0x180AA8460", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xAA80F0", Offset = "0xAA72F0", VA = "0x180AA80F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public ICFDEOCFBGL LBHHEHCHBLP
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xAA8470", Offset = "0xAA7670", VA = "0x180AA8470", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAA7830", Offset = "0xAA6A30", VA = "0x180AA7830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CAFJFKGMMAP OIOCJCCIHJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xAC9540", Offset = "0xAC8740", VA = "0x180AC9540", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xB940D0", Offset = "0xB932D0", VA = "0x180B940D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public GCONNCCNCHF OBOCKNKFPIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA6F6D0", Offset = "0xA6E8D0", VA = "0x180A6F6D0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA6F760", Offset = "0xA6E960", VA = "0x180A6F760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public COGAEPFNDJG PHMKKGJKKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA6F3E0", Offset = "0xA6E5E0", VA = "0x180A6F3E0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA6F740", Offset = "0xA6E940", VA = "0x180A6F740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public FEEFIKKCALC IIINACJFBPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA6E650", Offset = "0xA6D850", VA = "0x180A6E650", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA6A180", Offset = "0xA69380", VA = "0x180A6A180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public GJCPHMABOGP HLIEPEFDHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xABDEA0", Offset = "0xABD0A0", VA = "0x180ABDEA0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xABBB00", Offset = "0xABAD00", VA = "0x180ABBB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public BNBGAHNOJKP FMAGACAPCKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA6E550", Offset = "0xA6D750", VA = "0x180A6E550", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA6B140", Offset = "0xA6A340", VA = "0x180A6B140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public HDMDFMDDCIJ HOMADGCKDHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xAB7180", Offset = "0xAB6380", VA = "0x180AB7180", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public FGCOLJKEGJL ECIMALGALDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xABC210", Offset = "0xABB410", VA = "0x180ABC210", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public NAEGGHPNDKJ HCHFAPIPLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xABB770", Offset = "0xABA970", VA = "0x180ABB770", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GHPBGHDHCCH DPIGDCKOOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xABC0A0", Offset = "0xABB2A0", VA = "0x180ABC0A0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public KBBKDEGOKGN KEPBKLCOKHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xAC8220", Offset = "0xAC7420", VA = "0x180AC8220", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public DKFFONJNCCB JDBOBIAGMHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xABC8C0", Offset = "0xABBAC0", VA = "0x180ABC8C0", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xC2F080", Offset = "0xC2E280", VA = "0x180C2F080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool KOPNNNBCJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8482510", Offset = "0x8481710", VA = "0x188482510", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool NLPMJFLBILB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8482DE0", Offset = "0x8481FE0", VA = "0x188482DE0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool GBHDAEKMJFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1C28090", Offset = "0x1C27290", VA = "0x181C28090", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken PLEDLNGFPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8482790", Offset = "0x8481990", VA = "0x188482790", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private HILJAABEPDC DGOENKKIHEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool FDJCLOFKMND
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1C28090", Offset = "0x1C27290", VA = "0x181C28090", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1C21CB0", Offset = "0x1C20EB0", VA = "0x181C21CB0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action FJFEAKCFOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8482EC0", Offset = "0x84820C0", VA = "0x188482EC0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8482430", Offset = "0x8481630", VA = "0x188482430", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event JOALIPKLKDJ FGEPKDPCOEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8483030", Offset = "0x8482230", VA = "0x188483030", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8482C70", Offset = "0x8481E70", VA = "0x188482C70", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event JOALIPKLKDJ MFIFMLKOBFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8482870", Offset = "0x8481A70", VA = "0x188482870", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8482D80", Offset = "0x8481F80", VA = "0x188482D80", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event JOALIPKLKDJ KPGFHELFHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x84827B0", Offset = "0x84819B0", VA = "0x1884827B0", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8482CD0", Offset = "0x8481ED0", VA = "0x188482CD0", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<OLELLGCFNAL, bool> LPHMOIONKFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8482810", Offset = "0x8481A10", VA = "0x188482810", Slot = "48")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8482B20", Offset = "0x8481D20", VA = "0x188482B20", Slot = "49")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0xC2F080", Offset = "0xC2E280", VA = "0x180C2F080", Slot = "39")]
	public void LGDFPMNGDFH(DKFFONJNCCB GABLFEAOAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x8483390", Offset = "0x8482590", VA = "0x188483390")]
	[UnityEngine.Scripting.Preserve]
	internal ANJACFNOCGB([ALHAHLCGLLK(null)] HILJAABEPDC NPCDKJJJIDL, [ALHAHLCGLLK(null)] LKDJDKEKNAC GCMEJOEAFHA, [ALHAHLCGLLK(null)] DBILADPCAAF BKDDCHLEEJJ, [ALHAHLCGLLK(null)] LAMEDCHOMHL OIONFMJBFHJ, [ALHAHLCGLLK(null)] KBHPCHHAFMJ OAKDKIOIFFD, [ALHAHLCGLLK(null)] PFIGMICDKCM OCEAMFGGCBG, [ALHAHLCGLLK(null)] EHKLKJJGGDO FKBGIHJJFDH, [ALHAHLCGLLK(null)] MHBBONFJJIK FCFPPCDHFAL, [ALHAHLCGLLK(null)] OLBGBKMPEDD AOLJPOFFFJO, [ALHAHLCGLLK(null)] OLPLOOGCKPM LJMEBGDCKLI, [ALHAHLCGLLK(null)] JJOKMDOJOMN HCMOKBCCKGO, [ALHAHLCGLLK(null)] DLBFDEDKKIP DKGLCLKCEHM, [ALHAHLCGLLK(null)] FKJNHFGFCKO LNMPHMOJHEB, [ALHAHLCGLLK(null)] CALKIGGPPIO ACMFJNKHDMK, [ALHAHLCGLLK(null)] AFKJMJFJBOK MMDNIIIPOAH, [ALHAHLCGLLK(null)] CJNBIMMBOOP BHHCPLDGIOF, [ALHAHLCGLLK(null)] KGIPECMHEKG COMNJHFAEPD, [ALHAHLCGLLK(null)] EKDHJNKDHJK PGODBKJLNFF, [ALHAHLCGLLK(null)] PGINMAMCAGF ANAPBJEKDGB, [ALHAHLCGLLK(null)] ALEJNHMPADG HHLMBMFMNFE, [ALHAHLCGLLK(null)] ICFDEOCFBGL EDJBDOJJKCB, [ALHAHLCGLLK(null)] BCELOMMLBPF INOIIJHMAPA, [ALHAHLCGLLK(null)] CAFJFKGMMAP LGIPFAFNFAL, [ALHAHLCGLLK(null)] GCONNCCNCHF PEIPNLIKLHM, [ALHAHLCGLLK(null)] COGAEPFNDJG LNCPFPACNIN, [ALHAHLCGLLK(null)] GJCPHMABOGP EPCCHCFNMNH, [ALHAHLCGLLK(null)] BNBGAHNOJKP JKCKIGMECHD, [ALHAHLCGLLK(null)] HDMDFMDDCIJ FKIPOLPJBMJ, [ALHAHLCGLLK(null)] FGCOLJKEGJL IBBJEJHOLCA, [ALHAHLCGLLK(null)] NAEGGHPNDKJ JLPILAGLHOF, [ALHAHLCGLLK(null)] GHPBGHDHCCH NOGEMALBFHB, [ALHAHLCGLLK(null)] KBBKDEGOKGN MGGOFABMKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8482A70", Offset = "0x8481C70", VA = "0x188482A70")]
	private void ILLMBOBOELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8482600", Offset = "0x8481800", VA = "0x188482600", Slot = "61")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x8482D30", Offset = "0x8481F30", VA = "0x188482D30", Slot = "53")]
	private void LMKIDPGLDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x84828D0", Offset = "0x8481AD0", VA = "0x1884828D0", Slot = "54")]
	private GNEDCFKEHAA GMNEANNNLEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x8482570", Offset = "0x8481770", VA = "0x188482570", Slot = "55")]
	private OBBAMKBGNID CPCKHBGJLDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8483090", Offset = "0x8482290", VA = "0x188483090", Slot = "57")]
	public Task OPKCFPMDMEJ(int FBJJKIBIHMG, AMCBFCIFFOH EBNNDHKBAPE, Func<NOBGLNGJEOC, NOBGLNGJEOC> NDNPCGCGOEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8482960", Offset = "0x8481B60", VA = "0x188482960")]
	private BJOPBEFMNLE HJANOLCEAFG(int FBJJKIBIHMG, AMCBFCIFFOH EBNNDHKBAPE, Func<NOBGLNGJEOC, NOBGLNGJEOC> NDNPCGCGOEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x8482F20", Offset = "0x8482120", VA = "0x188482F20", Slot = "58")]
	[AsyncStateMachine(typeof(GMHEAIKLPOE))]
	private Task<BAKFNEOFNEC> MPBIAOMEMJN(LDMGLHEANGA NCCNNAGALKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8482B80", Offset = "0x8481D80", VA = "0x188482B80", Slot = "59")]
	[AsyncStateMachine(typeof(FEOPDKJBEAJ))]
	private Task JICECMMBOIJ(CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x8482490", Offset = "0x8481690", VA = "0x188482490")]
	[IteratorStateMachine(typeof(AOLLCDIDGKF))]
	private IEnumerable<MGBHAJGBNCO> BNAODNEPJOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x8482E60", Offset = "0x8482060", VA = "0x188482E60")]
	[CompilerGenerated]
	private void MNBBLAIFHAH(MGBHAJGBNCO CBNJHLDNKAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class HNCGGOKLIDP : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x17E10E0", Offset = "0x17E02E0", VA = "0x1817E10E0")]
	public HNCGGOKLIDP(string BDAAPBJEHGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class JKFJEGJJEIH : JDLPIHFPGEL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct LECNHPBGIPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<JDLPIHFPGEL.DLOHELCJLPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public HashSet<DLBFDEDKKIP.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public JKFJEGJJEIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8492070", Offset = "0x8491270", VA = "0x188492070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8492370", Offset = "0x8491570", VA = "0x188492370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly MEBNIAGNGEK LLMBGPNPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly LAMEDCHOMHL OIONFMJBFHJ;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string NLHDALANIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x848FB10", Offset = "0x848ED10", VA = "0x18848FB10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x9FFD40", Offset = "0x9FEF40", VA = "0x1809FFD40")]
	public JKFJEGJJEIH(MEBNIAGNGEK LLMBGPNPABD, LAMEDCHOMHL OIONFMJBFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x848FB40", Offset = "0x848ED40", VA = "0x18848FB40", Slot = "5")]
	[AsyncStateMachine(typeof(LECNHPBGIPE))]
	public Task<JDLPIHFPGEL.DLOHELCJLPH> PNJJMFNDOCN(HashSet<DLBFDEDKKIP.Reason> MBDDJIMCJFL, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class PFAJFBBKPAA : JMHGLKOCJGG, JDLPIHFPGEL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct LOKCAFHNFMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<JDLPIHFPGEL.DLOHELCJLPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public PFAJFBBKPAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public HashSet<DLBFDEDKKIP.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private LDKIAIAGMBD <localRoomInstance>5__2;

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
		private TaskAwaiter<JDLPIHFPGEL.DLOHELCJLPH> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8499420", Offset = "0x8498620", VA = "0x188499420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8499D80", Offset = "0x8498F80", VA = "0x188499D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string NLHDALANIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x84A0AA0", Offset = "0x849FCA0", VA = "0x1884A0AA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x9FFD40", Offset = "0x9FEF40", VA = "0x1809FFD40")]
	public PFAJFBBKPAA(MEBNIAGNGEK LLMBGPNPABD, LAMEDCHOMHL OIONFMJBFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x84A0AD0", Offset = "0x849FCD0", VA = "0x1884A0AD0", Slot = "5")]
	[AsyncStateMachine(typeof(LOKCAFHNFMG))]
	public Task<JDLPIHFPGEL.DLOHELCJLPH> PNJJMFNDOCN(HashSet<DLBFDEDKKIP.Reason> MBDDJIMCJFL, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class ILMKFFPFGAM : JMHGLKOCJGG, JDLPIHFPGEL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct LDELBKCPJOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public AsyncTaskMethodBuilder<JDLPIHFPGEL.DLOHELCJLPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public ILMKFFPFGAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public HashSet<DLBFDEDKKIP.Reason> fallbackTriggersToIgnore;

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
		private TaskAwaiter<PFNHANHLLDI> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter<JDLPIHFPGEL.DLOHELCJLPH> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8491610", Offset = "0x8490810", VA = "0x188491610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8492000", Offset = "0x8491200", VA = "0x188492000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string NLHDALANIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x848F200", Offset = "0x848E400", VA = "0x18848F200", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x9FFD40", Offset = "0x9FEF40", VA = "0x1809FFD40")]
	public ILMKFFPFGAM(MEBNIAGNGEK LLMBGPNPABD, LAMEDCHOMHL OIONFMJBFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x848F230", Offset = "0x848E430", VA = "0x18848F230", Slot = "5")]
	[AsyncStateMachine(typeof(LDELBKCPJOD))]
	public Task<JDLPIHFPGEL.DLOHELCJLPH> PNJJMFNDOCN(HashSet<DLBFDEDKKIP.Reason> MBDDJIMCJFL, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class OALCDMMHNED : JMHGLKOCJGG, JDLPIHFPGEL
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class EALOLNFEKCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public PFNHANHLLDI matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public LDKIAIAGMBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public EALOLNFEKCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8488490", Offset = "0x8487690", VA = "0x188488490")]
		internal object AKACAAIIBDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8488510", Offset = "0x8487710", VA = "0x188488510")]
		internal object NACHIINBCPF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct DMCDHAOJCHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public AsyncTaskMethodBuilder<JDLPIHFPGEL.DLOHELCJLPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public OALCDMMHNED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public HashSet<DLBFDEDKKIP.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private EALOLNFEKCD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<PFNHANHLLDI> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter<JDLPIHFPGEL.DLOHELCJLPH> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8486580", Offset = "0x8485780", VA = "0x188486580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x84871A0", Offset = "0x84863A0", VA = "0x1884871A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string NLHDALANIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x849EDB0", Offset = "0x849DFB0", VA = "0x18849EDB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x9FFD40", Offset = "0x9FEF40", VA = "0x1809FFD40")]
	public OALCDMMHNED(MEBNIAGNGEK LLMBGPNPABD, LAMEDCHOMHL OIONFMJBFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x849EDE0", Offset = "0x849DFE0", VA = "0x18849EDE0", Slot = "5")]
	[AsyncStateMachine(typeof(DMCDHAOJCHP))]
	public Task<JDLPIHFPGEL.DLOHELCJLPH> PNJJMFNDOCN(HashSet<DLBFDEDKKIP.Reason> MBDDJIMCJFL, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class JMHGLKOCJGG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct LOEEMCCOHOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public FODGIOKBGBI log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public HashSet<DLBFDEDKKIP.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public JMHGLKOCJGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<DLBFDEDKKIP.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8498EA0", Offset = "0x84980A0", VA = "0x188498EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x84993C0", Offset = "0x84985C0", VA = "0x1884993C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	protected readonly MEBNIAGNGEK LLMBGPNPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	protected readonly LAMEDCHOMHL OIONFMJBFHJ;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected MOALAMGIMLB LHDJPHOLKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x848FCD0", Offset = "0x848EED0", VA = "0x18848FCD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x9FFD40", Offset = "0x9FEF40", VA = "0x1809FFD40")]
	public JMHGLKOCJGG(MEBNIAGNGEK LLMBGPNPABD, LAMEDCHOMHL OIONFMJBFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x848FD20", Offset = "0x848EF20", VA = "0x18848FD20")]
	[AsyncStateMachine(typeof(LOEEMCCOHOM))]
	protected Task PGMJKPOINNK(FODGIOKBGBI FHEIHFBIKLF, HashSet<DLBFDEDKKIP.Reason> MBDDJIMCJFL, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class NCCCNCJIMNC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct IOICGFPFLFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder<JDLPIHFPGEL.DLOHELCJLPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public LAMEDCHOMHL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x848F400", Offset = "0x848E600", VA = "0x18848F400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x848F780", Offset = "0x848E980", VA = "0x18848F780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class KPGKLJMLBPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public MEBNIAGNGEK roomManager;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KPGKLJMLBPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8490C60", Offset = "0x848FE60", VA = "0x188490C60")]
		internal object FEIJMNGDMFH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly float OOIJAACEDME;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	internal static readonly HashSet<DLBFDEDKKIP.Reason> KBDFDANPGEB;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x849E980", Offset = "0x849DB80", VA = "0x18849E980")]
	[AsyncStateMachine(typeof(IOICGFPFLFD))]
	internal static Task<JDLPIHFPGEL.DLOHELCJLPH> FGAMPEDBFNO(LAMEDCHOMHL OIONFMJBFHJ, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x849EA90", Offset = "0x849DC90", VA = "0x18849EA90")]
	internal static void MDLDJBKCJFN(MEBNIAGNGEK LLMBGPNPABD, FODGIOKBGBI FHEIHFBIKLF, string AMPMPNLBCLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface JDLPIHFPGEL
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct DLOHELCJLPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public bool MAEMMABLBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public DLBFDEDKKIP.Reason BPAILNFLNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Enum? AADIDMILKGP;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8486540", Offset = "0x8485740", VA = "0x188486540")]
		public static DLOHELCJLPH KDJBHGKCOBM()
		{
			return default(DLOHELCJLPH);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8486550", Offset = "0x8485750", VA = "0x188486550")]
		public static DLOHELCJLPH OLDAMLEKDPK(DLBFDEDKKIP.Reason BPAILNFLNFH, [Optional] Enum? AADIDMILKGP)
		{
			return default(DLOHELCJLPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string HMJEEGFDCKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<DLOHELCJLPH> PNJJMFNDOCN(HashSet<DLBFDEDKKIP.Reason> MBDDJIMCJFL, CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct GOFJABBHPHK
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class JFFPOFMBCGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public MEBNIAGNGEK manager;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public JFFPOFMBCGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x848FAC0", Offset = "0x848ECC0", VA = "0x18848FAC0")]
		internal Task GKGNECMCJIN(CancellationToken cancellationToken, int roomTotalVersion, ODJGKIKFMEP localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct LBMAMBFLCGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public GOFJABBHPHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private LDMGLHEANGA <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter<GNJANIPNJFB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter<BAKFNEOFNEC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8490D60", Offset = "0x848FF60", VA = "0x188490D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x84912F0", Offset = "0x84904F0", VA = "0x1884912F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct JNEGGFCJJPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public GOFJABBHPHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x848FE50", Offset = "0x848F050", VA = "0x18848FE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8490170", Offset = "0x848F370", VA = "0x188490170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly CancellationToken HCELDNOKOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly MEBNIAGNGEK MHGFNMBGACA;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private LKDJDKEKNAC FJJGNIKEKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x848A8C0", Offset = "0x8489AC0", VA = "0x18848A8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private LAMEDCHOMHL LMBINNBIMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x848A990", Offset = "0x8489B90", VA = "0x18848A990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private MOALAMGIMLB LHDJPHOLKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x848A910", Offset = "0x8489B10", VA = "0x18848A910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private OLPLOOGCKPM LKKEJIIGDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x848ABF0", Offset = "0x8489DF0", VA = "0x18848ABF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x27C6CD0", Offset = "0x27C5ED0", VA = "0x1827C6CD0")]
	public GOFJABBHPHK(CancellationToken HCELDNOKOAM, MEBNIAGNGEK MHGFNMBGACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x848AD10", Offset = "0x8489F10", VA = "0x18848AD10")]
	public static HCJIFMBBOCA LFGNDMOCKAK(MEBNIAGNGEK MHGFNMBGACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x848ADC0", Offset = "0x8489FC0", VA = "0x18848ADC0")]
	[AsyncStateMachine(typeof(LBMAMBFLCGG))]
	public Task<bool> MENHHIHEOIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x848A9E0", Offset = "0x8489BE0", VA = "0x18848A9E0")]
	private bool JHAILDDIHHB([Out] LDMGLHEANGA NCCNNAGALKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x848AC40", Offset = "0x8489E40", VA = "0x18848AC40")]
	[AsyncStateMachine(typeof(JNEGGFCJJPM))]
	private Task JMICPBOFHPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x848A790", Offset = "0x8489990", VA = "0x18848A790")]
	private Task<GNJANIPNJFB> GDAJOKKNDPD(LDMGLHEANGA DKKHDDMINFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct FAOABMFLDEO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly AFKJMJFJBOK MMDNIIIPOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Guid BOAAABDJCPH;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(BAKFNEOFNEC, Task)> JCBPEABCHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8488720", Offset = "0x8487920", VA = "0x188488720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x50ACD30", Offset = "0x50ABF30", VA = "0x1850ACD30")]
	public FAOABMFLDEO(AFKJMJFJBOK MMDNIIIPOAH, Guid BOAAABDJCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x84887F0", Offset = "0x84879F0", VA = "0x1884887F0")]
	public TaskAwaiter<(BAKFNEOFNEC, Task)> LKNFDOKEILD()
	{
		return default(TaskAwaiter<(BAKFNEOFNEC, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8488650", Offset = "0x8487850", VA = "0x188488650", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct CACMJBIEADD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly TaskCompletionSource<(BAKFNEOFNEC, Task)> HAMKBPLMFBO;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(BAKFNEOFNEC, Task)> JCBPEABCHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8484C50", Offset = "0x8483E50", VA = "0x188484C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8484E00", Offset = "0x8484000", VA = "0x188484E00")]
	public CACMJBIEADD(TimeSpan KMMOMBOBGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8484BB0", Offset = "0x8483DB0", VA = "0x188484BB0")]
	public void DALIGPEELDN(Task MONDHIAMLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8484D20", Offset = "0x8483F20", VA = "0x188484D20")]
	public void GHCPNHCEGGA(BAKFNEOFNEC IOEOAHLDCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8484DB0", Offset = "0x8483FB0", VA = "0x188484DB0")]
	public void KNAPAJCGONN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8484C90", Offset = "0x8483E90", VA = "0x188484C90")]
	internal void GBOLCDLGMGD(string BDAAPBJEHGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class LFNIICEIPFL
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8492570", Offset = "0x8491770", VA = "0x188492570")]
	public static IAAJJFDJPDA DLIMFNBFAFL(this IAAJJFDJPDA MGEJNDCFBJA, JKGEOIDCPBI BLBGNLMNKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x84923E0", Offset = "0x84915E0", VA = "0x1884923E0")]
	public static IAAJJFDJPDA ANOPBBCOMCL(this IAAJJFDJPDA MGEJNDCFBJA, PFLEEJFBOMH PKGHIOCJMDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class OHCPINHIGIC : AJFCPCJPLCN
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class MDONAENLPKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public PFLEEJFBOMH subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MDONAENLPKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x849B3C0", Offset = "0x849A5C0", VA = "0x18849B3C0")]
		internal bool MAKAJLHBIAE(LKOOIDABJPJ s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly GJCPHMABOGP CEPPPGEHGHJ;

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public OHCPINHIGIC(GJCPHMABOGP EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x849FEA0", Offset = "0x849F0A0", VA = "0x18849FEA0", Slot = "4")]
	public IAAJJFDJPDA EAIFKKLDBGP(long BPLMJDMGKND, long OECKHCOHBDG, string HKPLMIHOJLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x849FD40", Offset = "0x849EF40", VA = "0x18849FD40", Slot = "5")]
	public IAAJJFDJPDA EAIFKKLDBGP(long BPLMJDMGKND, long OECKHCOHBDG, ELAGIFLJMJI ALDFCBINAND, Guid? DBOJAFAJJAG, long IOPIKANEPAB, bool FCBMODOACPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x84A0210", Offset = "0x849F410", VA = "0x1884A0210", Slot = "6")]
	public IAAJJFDJPDA EAIFKKLDBGP(PDHIEPEKDIL CLHMIEKOHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x849FF30", Offset = "0x849F130", VA = "0x18849FF30", Slot = "7")]
	public IAAJJFDJPDA EAIFKKLDBGP(JKGEOIDCPBI HFCPGIJLMJB, PFLEEJFBOMH KHGFGMFNBDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x84A0410", Offset = "0x849F610", VA = "0x1884A0410")]
	private Guid? LIALNLEHHBF(JKGEOIDCPBI FMALGNAOJAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class DOIDFOLNJCO : OLBGBKMPEDD, MGBHAJGBNCO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct MGNHLPGDCHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public DOIDFOLNJCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x849C110", Offset = "0x849B310", VA = "0x18849C110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x849C7A0", Offset = "0x849B9A0", VA = "0x18849C7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly AAILLPLJANG ADCLAANOBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private string MGBJMNMODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Task APEKCENJFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private MEBNIAGNGEK LLMBGPNPABD;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool HECADAFOPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8487520", Offset = "0x8486720", VA = "0x188487520", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task JNPAOCAKGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8487330", Offset = "0x8486530", VA = "0x188487330", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750", Slot = "7")]
	public void ILLMBOBOELN(MEBNIAGNGEK LLMBGPNPABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x84873C0", Offset = "0x84865C0", VA = "0x1884873C0", Slot = "6")]
	public void JAAJHBGCPAP(Task LDLKICLCOAG, string KANNOFPGEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8487210", Offset = "0x8486410", VA = "0x188487210")]
	[AsyncStateMachine(typeof(MGNHLPGDCHP))]
	private Task DFCOIGABEEI(Task IMEDKFLLIOK, string KANNOFPGEHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x8487550", Offset = "0x8486750", VA = "0x188487550")]
	public DOIDFOLNJCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class MAIBECFCALP : FEEFIKKCALC, MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private bool EHDPFJCKBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private KFHGIGIDJID PHINGBJDPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private LKDJDKEKNAC GCMEJOEAFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private GJCPHMABOGP EPCCHCFNMNH;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public KFHGIGIDJID PIPFJHGKIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x849B350", Offset = "0x849A550", VA = "0x18849B350", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x849B1D0", Offset = "0x849A3D0", VA = "0x18849B1D0", Slot = "7")]
	public void ILLMBOBOELN(MEBNIAGNGEK LLMBGPNPABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x849B020", Offset = "0x849A220", VA = "0x18849B020", Slot = "5")]
	public void HJDOKICFBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x849AFE0", Offset = "0x849A1E0", VA = "0x18849AFE0", Slot = "6")]
	public void LFPLENEDCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x849AF20", Offset = "0x849A120", VA = "0x18849AF20")]
	private Task CCFEFAJFJDA(IDKGCAIANLP NIDPEFPJBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x849AFE0", Offset = "0x849A1E0", VA = "0x18849AFE0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MAIBECFCALP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class AJHAFJMNBBM : GJCPHMABOGP
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class DPIFLGIOKMF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly HJGCGGODOAD MIFPNJKPFOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly string AGBHGDFILGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly T FAGKKFIFNNI;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T ABLHJAOAOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xC8C5E0", Offset = "0xC8B7E0", VA = "0x180C8C5E0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0xC8C5D0", Offset = "0xC8B7D0", VA = "0x180C8C5D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x6A31410", Offset = "0x6A30610", VA = "0x186A31410")]
		public DPIFLGIOKMF(HJGCGGODOAD MIFPNJKPFOG, string AGBHGDFILGO, T FAGKKFIFNNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6A30F60", Offset = "0x6A30160", VA = "0x186A30F60")]
		private void DMJBKFNEPLC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly HJGCGGODOAD MIFPNJKPFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly DPIFLGIOKMF<TimeSpan> OEOFMLGKDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly DPIFLGIOKMF<TimeSpan> EFOAJDANAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly DPIFLGIOKMF<TimeSpan> BJAPMLBINMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly DPIFLGIOKMF<TimeSpan> HAMLDNPMGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly DPIFLGIOKMF<bool> OJMBAHBPEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly DPIFLGIOKMF<bool> JDHGIDBOEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly DPIFLGIOKMF<bool> AKJOACMMDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly DPIFLGIOKMF<int> LIJFDCMGPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly DPIFLGIOKMF<bool> MBHDKDLFMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly DPIFLGIOKMF<bool> NFCMMFFCLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly DPIFLGIOKMF<IBKBPFELIAH> MKLNLBHBICP;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan HMBEPDMCLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8481D10", Offset = "0x8480F10", VA = "0x188481D10", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan ABPOJNILEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8481E60", Offset = "0x8481060", VA = "0x188481E60", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan NBIOIOKAJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8481DE0", Offset = "0x8480FE0", VA = "0x188481DE0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan NFLFDMGHDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8481EA0", Offset = "0x84810A0", VA = "0x188481EA0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DIMCJIMPEIE
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8481DA0", Offset = "0x8480FA0", VA = "0x188481DA0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool NLDDBBGEAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8481F20", Offset = "0x8481120", VA = "0x188481F20", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool DJLCMHGMGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8481E20", Offset = "0x8481020", VA = "0x188481E20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int NPAPONBPHHL
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8481C90", Offset = "0x8480E90", VA = "0x188481C90", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool OOKEJLCDKDK
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8481CD0", Offset = "0x8480ED0", VA = "0x188481CD0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool PBBDIGBAMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8481EE0", Offset = "0x84810E0", VA = "0x188481EE0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool EKGCHOJHFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8481D50", Offset = "0x8480F50", VA = "0x188481D50", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8481F60", Offset = "0x8481160", VA = "0x188481F60")]
	[UnityEngine.Scripting.Preserve]
	public AJHAFJMNBBM([ALHAHLCGLLK(null)] HJGCGGODOAD MIFPNJKPFOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class MFHMKIIBOBD : JJOKMDOJOMN, MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class GLHDJCDLIPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public DBJKOHCNHMF roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public GLHDJCDLIPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x848A3C0", Offset = "0x84895C0", VA = "0x18848A3C0")]
		internal object ODCJBHPPLKO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action OCBODCPMEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x849BD60", Offset = "0x849AF60", VA = "0x18849BD60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x849B3F0", Offset = "0x849A5F0", VA = "0x18849B3F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event JOALIPKLKDJ HLLJBOKGGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x849BB00", Offset = "0x849AD00", VA = "0x18849BB00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x849BBA0", Offset = "0x849ADA0", VA = "0x18849BBA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event JOALIPKLKDJ JNDANJCEELM
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x849B9C0", Offset = "0x849ABC0", VA = "0x18849B9C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x849B650", Offset = "0x849A850", VA = "0x18849B650", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event JOALIPKLKDJ ILKIPLEJHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x849BA60", Offset = "0x849AC60", VA = "0x18849BA60", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x849BC90", Offset = "0x849AE90", VA = "0x18849BC90", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<OLELLGCFNAL, bool> LOJMNDHNBKP
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x849BE00", Offset = "0x849B000", VA = "0x18849BE00", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x849B910", Offset = "0x849AB10", VA = "0x18849B910", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "19")]
	public void ILLMBOBOELN(MEBNIAGNGEK LLMBGPNPABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x849B6F0", Offset = "0x849A8F0", VA = "0x18849B6F0", Slot = "14")]
	public void FPGEMNJBBID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x849B8E0", Offset = "0x849AAE0", VA = "0x18849B8E0", Slot = "15")]
	public void FPMKDNGEGDH(DBJKOHCNHMF JFHHMNEAJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x849BEB0", Offset = "0x849B0B0", VA = "0x18849BEB0", Slot = "16")]
	public void OEMPEHADAFD(DBJKOHCNHMF JFHHMNEAJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x849BD30", Offset = "0x849AF30", VA = "0x18849BD30", Slot = "17")]
	public void MKDFDOPLEDJ(DBJKOHCNHMF JFHHMNEAJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x849BC40", Offset = "0x849AE40", VA = "0x18849BC40", Slot = "18")]
	public void MFGOLLAGCMD(OLELLGCFNAL LCIBBKGCJFA, bool MAEMMABLBFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x849B490", Offset = "0x849A690", VA = "0x18849B490")]
	private void ENEDPBAOBKF(JOALIPKLKDJ LKMFAJMIACB, DBJKOHCNHMF JFHHMNEAJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MFHMKIIBOBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[UnityEngine.Scripting.Preserve]
internal class BOLAHDACHCN : DLBFDEDKKIP, MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class MOFCBJAEDAI : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct OBLHDKNBBDJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public MOFCBJAEDAI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public DLBFDEDKKIP.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private AHAEBJLBPKA <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private JDLPIHFPGEL[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private TaskAwaiter<JDLPIHFPGEL.DLOHELCJLPH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x849EFB0", Offset = "0x849E1B0", VA = "0x18849EFB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x849F6E0", Offset = "0x849E8E0", VA = "0x18849F6E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private struct LLCAMBIIILE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public AsyncTaskMethodBuilder<JDLPIHFPGEL.DLOHELCJLPH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public JDLPIHFPGEL fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public MOFCBJAEDAI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public DLBFDEDKKIP.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private AHAEBJLBPKA <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private ONGDJEPBGLI <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private TaskAwaiter<JDLPIHFPGEL.DLOHELCJLPH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x84981A0", Offset = "0x84973A0", VA = "0x1884981A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x8498E30", Offset = "0x8498030", VA = "0x188498E30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class EEFAEHKBEKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public JDLPIHFPGEL fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public EEFAEHKBEKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x84885D0", Offset = "0x84877D0", VA = "0x1884885D0")]
			internal object DMFELGKGMLM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Task LDLKICLCOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationTokenSource HLIKNJCPCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public ONGDJEPBGLI FOMAEIFCAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public LAMEDCHOMHL OIONFMJBFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public BMFIAEEKEEC KJBOCECGEEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public LDKIAIAGMBD MDLGPLHBALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public JDLPIHFPGEL[] HLPPDAGMGGN;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool INKNHIHBLEB
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x849D2A0", Offset = "0x849C4A0", VA = "0x18849D2A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool NLHMGNMCGJD
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x849D070", Offset = "0x849C270", VA = "0x18849D070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x849E330", Offset = "0x849D530", VA = "0x18849E330")]
		public MOFCBJAEDAI(LAMEDCHOMHL OIONFMJBFHJ, BMFIAEEKEEC KJBOCECGEEL, LDKIAIAGMBD MDLGPLHBALF, JDLPIHFPGEL[] HLPPDAGMGGN, CancellationToken HCELDNOKOAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x849CA60", Offset = "0x849BC60", VA = "0x18849CA60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x849CEA0", Offset = "0x849C0A0", VA = "0x18849CEA0")]
		public void EBNEAPCILJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x849CF10", Offset = "0x849C110", VA = "0x18849CF10")]
		public void EHJKOMGJIAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x849CBF0", Offset = "0x849BDF0", VA = "0x18849CBF0")]
		public void EAKAAFIHDIN(DLBFDEDKKIP.Reason GEFHNFAJHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x849D1A0", Offset = "0x849C3A0", VA = "0x18849D1A0")]
		[AsyncStateMachine(typeof(OBLHDKNBBDJ))]
		public Task IOKHDAPIEIJ(DLBFDEDKKIP.Reason BPAILNFLNFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x849C920", Offset = "0x849BB20", VA = "0x18849C920")]
		[AsyncStateMachine(typeof(LLCAMBIIILE))]
		private Task<JDLPIHFPGEL.DLOHELCJLPH> CJCGBBMEDBF(DLBFDEDKKIP.Reason BPAILNFLNFH, JDLPIHFPGEL FMNIKIHJPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x849C800", Offset = "0x849BA00", VA = "0x18849C800")]
		private void BILIMJAMLLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x849D2C0", Offset = "0x849C4C0", VA = "0x18849D2C0")]
		public bool JKLBKCEHJCO(DLBFDEDKKIP.Reason EBIHAKLHKGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x849D540", Offset = "0x849C740", VA = "0x18849D540")]
		private void MFAFCKAGLMC(ONGDJEPBGLI HPAPEOOKLIH, DLBFDEDKKIP.Reason BPAILNFLNFH = DLBFDEDKKIP.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x849D370", Offset = "0x849C570", VA = "0x18849D370")]
		private void LHNFLEPALGN(ONGDJEPBGLI HPAPEOOKLIH, JDLPIHFPGEL.DLOHELCJLPH IGGKBIDIAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x849D7F0", Offset = "0x849C9F0", VA = "0x18849D7F0")]
		private void MIPOCMJAJJP(ONGDJEPBGLI HPAPEOOKLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x849DC00", Offset = "0x849CE00", VA = "0x18849DC00")]
		private void PABODNHOKHM(ONGDJEPBGLI HPAPEOOKLIH, JDLPIHFPGEL.DLOHELCJLPH IGGKBIDIAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x849D990", Offset = "0x849CB90", VA = "0x18849D990")]
		private void NLCGHMHLIBL(ONGDJEPBGLI HPAPEOOKLIH, Exception MJPFDOAJBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x849D090", Offset = "0x849C290", VA = "0x18849D090")]
		private void HHOHPAHLKOD(JDLPIHFPGEL FMNIKIHJPKI, DLBFDEDKKIP.Reason BPAILNFLNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x849DAF0", Offset = "0x849CCF0", VA = "0x18849DAF0")]
		private void OGNFCEOEMFO(JDLPIHFPGEL FMNIKIHJPKI, DLBFDEDKKIP.Reason BPAILNFLNFH, string AADIDMILKGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x849DFC0", Offset = "0x849D1C0", VA = "0x18849DFC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class ONGDJEPBGLI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Task<JDLPIHFPGEL.DLOHELCJLPH> LDLKICLCOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public CancellationTokenSource HLIKNJCPCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public JDLPIHFPGEL FMNIKIHJPKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public DLBFDEDKKIP.Reason GEFHNFAJHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public HashSet<DLBFDEDKKIP.Reason> MBDDJIMCJFL;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool INKNHIHBLEB
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x849D2A0", Offset = "0x849C4A0", VA = "0x18849D2A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool NLHMGNMCGJD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x849D070", Offset = "0x849C270", VA = "0x18849D070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x84A04E0", Offset = "0x849F6E0", VA = "0x1884A04E0")]
		public void PCMJMPFBLNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x84A04C0", Offset = "0x849F6C0", VA = "0x1884A04C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x84A0640", Offset = "0x849F840", VA = "0x1884A0640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x84A09A0", Offset = "0x849FBA0", VA = "0x1884A09A0")]
		public ONGDJEPBGLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class ADOAOJIOKCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public DLBFDEDKKIP.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ADOAOJIOKCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8481BB0", Offset = "0x8480DB0", VA = "0x188481BB0")]
		internal object JHENPNFOCBF(ONGDJEPBGLI x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8481B40", Offset = "0x8480D40", VA = "0x188481B40")]
		internal object EAFNLLJNLDN(MOFCBJAEDAI x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8481C20", Offset = "0x8480E20", VA = "0x188481C20")]
		internal object JNGNJPOGPNB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct FMBAGIOGAHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public DLBFDEDKKIP.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public BOLAHDACHCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private ADOAOJIOKCA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x84897A0", Offset = "0x84889A0", VA = "0x1884897A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x848A200", Offset = "0x8489400", VA = "0x18848A200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct FCCNMPODFFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public BOLAHDACHCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public DLBFDEDKKIP.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private MOFCBJAEDAI <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8488840", Offset = "0x8487A40", VA = "0x188488840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x84894B0", Offset = "0x84886B0", VA = "0x1884894B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct IDMFLCGENAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public BOLAHDACHCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x848EC30", Offset = "0x848DE30", VA = "0x18848EC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x848F1A0", Offset = "0x848E3A0", VA = "0x18848F1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	internal static readonly FODGIOKBGBI DKCHHOBPODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private MEBNIAGNGEK LLMBGPNPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private LAMEDCHOMHL OIONFMJBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private MOFCBJAEDAI BOKMOBOIFOH;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private MOALAMGIMLB LHDJPHOLKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8484230", Offset = "0x8483430", VA = "0x188484230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool FIGGMKEGKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2396770", Offset = "0x2395970", VA = "0x182396770", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool JGFEGODEJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8484280", Offset = "0x8483480", VA = "0x188484280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x84841B0", Offset = "0x84833B0", VA = "0x1884841B0", Slot = "7")]
	public void ILLMBOBOELN(MEBNIAGNGEK LLMBGPNPABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8483D10", Offset = "0x8482F10", VA = "0x188483D10", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8484970", Offset = "0x8483B70", VA = "0x188484970", Slot = "9")]
	public void PCMJMPFBLNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x84846B0", Offset = "0x84838B0", VA = "0x1884846B0")]
	private bool OFEBHDDKINK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x8484790", Offset = "0x8483990", VA = "0x188484790", Slot = "6")]
	private void OFJJBPJEJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x84842F0", Offset = "0x84834F0", VA = "0x1884842F0", Slot = "5")]
	[AsyncStateMachine(typeof(FMBAGIOGAHI))]
	private Task KMEKFEOCBPM(DLBFDEDKKIP.Reason BPAILNFLNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x84843E0", Offset = "0x84835E0", VA = "0x1884843E0")]
	private bool NBHINJBPFMI(DLBFDEDKKIP.Reason BPAILNFLNFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x8483D20", Offset = "0x8482F20", VA = "0x188483D20")]
	private JDLPIHFPGEL[] ECEFBBBIKDE(LDKIAIAGMBD EFIBEMKMELE, BMFIAEEKEEC LLEHLAOKALN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x8484860", Offset = "0x8483A60", VA = "0x188484860")]
	[AsyncStateMachine(typeof(FCCNMPODFFF))]
	private Task OFMJPMOKJEN(DLBFDEDKKIP.Reason BPAILNFLNFH, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x84840E0", Offset = "0x84832E0", VA = "0x1884840E0")]
	[AsyncStateMachine(typeof(IDMFLCGENAE))]
	private Task HOPCDNOIJJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public BOLAHDACHCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class HKHJKBJJKDN : FKJNHFGFCKO, MGBHAJGBNCO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct DFIAIIDMNEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public LDKIAIAGMBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public HKHJKBJJKDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public DKFFONJNCCB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x84853E0", Offset = "0x84845E0", VA = "0x1884853E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8485D40", Offset = "0x8484F40", VA = "0x188485D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct LOMMGICMELG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public HKHJKBJJKDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public LDKIAIAGMBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public DKFFONJNCCB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private EAIPOBMEIGP<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private AHAEBJLBPKA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private IHKEKBDONBN <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private FPHPINCHKOK <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8499DF0", Offset = "0x8498FF0", VA = "0x188499DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x849AB40", Offset = "0x8499D40", VA = "0x18849AB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class HHKHFGPLOFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public Matchmaking.BLHAEFEOGNL result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public PIFIONLEBIH errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public HHKHFGPLOFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x848B240", Offset = "0x848A440", VA = "0x18848B240")]
		internal object PHLCNHINAIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class DJFNAMIKDIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Task<IAAJJFDJPDA> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DJFNAMIKDIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		internal Task<IAAJJFDJPDA> HFEJENLEKBM(EAIPOBMEIGP<string>.MNKIBAEKPMC _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct LJPCBEHIAEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public HKHJKBJJKDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public LDKIAIAGMBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public DKFFONJNCCB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public IHKEKBDONBN joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private DJFNAMIKDIJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private EGOLNJDEEMP <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private AHAEBJLBPKA <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private NPIJPEFDCBH <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private Task<Matchmaking.BCOKBGGEHOC> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private PHLLCDOAJBE <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.BCOKBGGEHOC> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter<IAAJJFDJPDA> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8492710", Offset = "0x8491910", VA = "0x188492710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8498140", Offset = "0x8497340", VA = "0x188498140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct PEGNFKJMOLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public HKHJKBJJKDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <disconnectTimerScope>5__3;

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
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x84BEC70", Offset = "0x84BDE70", VA = "0x1884BEC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x84BF6E0", Offset = "0x84BE8E0", VA = "0x1884BF6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct ODIDJACICOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public HKHJKBJJKDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private HILJAABEPDC <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x84BCB00", Offset = "0x84BBD00", VA = "0x1884BCB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x84BCF80", Offset = "0x84BC180", VA = "0x1884BCF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct BDCMBGHFMAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public AsyncTaskMethodBuilder<Matchmaking.BCOKBGGEHOC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public LDKIAIAGMBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public HKHJKBJJKDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TaskAwaiter<Matchmaking.BCOKBGGEHOC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x84A83A0", Offset = "0x84A75A0", VA = "0x1884A83A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x84A8870", Offset = "0x84A7A70", VA = "0x1884A8870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct MMMLIGMEFPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public Matchmaking.BCOKBGGEHOC serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public HKHJKBJJKDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public IHKEKBDONBN joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private TaskAwaiter<PLFCNAAENKM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x84BB710", Offset = "0x84BA910", VA = "0x1884BB710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x84BBD50", Offset = "0x84BAF50", VA = "0x1884BBD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class PCHDMDKOMJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public LDKIAIAGMBD targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PCHDMDKOMJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x84BE930", Offset = "0x84BDB30", VA = "0x1884BE930")]
		internal object EKNBDPBHDLG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x84BEA30", Offset = "0x84BDC30", VA = "0x1884BEA30")]
		internal string PDLMKEIKHOK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct AHAHDEJPGPL : IAsyncStateMachine
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
		public LDKIAIAGMBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public HKHJKBJJKDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private PCHDMDKOMJE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private AHAEBJLBPKA <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x84A2A50", Offset = "0x84A1C50", VA = "0x1884A2A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x84A35E0", Offset = "0x84A27E0", VA = "0x1884A35E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct PBJANFKELIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public HKHJKBJJKDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public IHKEKBDONBN joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public IAAJJFDJPDA initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public LDKIAIAGMBD targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public EGOLNJDEEMP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x84BDC30", Offset = "0x84BCE30", VA = "0x1884BDC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x84BE420", Offset = "0x84BD620", VA = "0x1884BE420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct ANHMJLLAFCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public HKHJKBJJKDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private AHAEBJLBPKA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap3;

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
		private AHAEBJLBPKA <>7__wrap5;

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
		[Cpp2IlInjected.Address(RVA = "0x84A5000", Offset = "0x84A4200", VA = "0x1884A5000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x84A67E0", Offset = "0x84A59E0", VA = "0x1884A67E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct BDBEHOKPDND : IAsyncStateMachine
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
		public ODJGKIKFMEP localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public HKHJKBJJKDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<BAKFNEOFNEC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x84A7AF0", Offset = "0x84A6CF0", VA = "0x1884A7AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x84A82E0", Offset = "0x84A74E0", VA = "0x1884A82E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class DGOOOGFLJML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public LDKIAIAGMBD targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DGOOOGFLJML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x84ACB50", Offset = "0x84ABD50", VA = "0x1884ACB50")]
		internal object HAEIOPAEGNC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class BDLOOPGPOAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public BDLOOPGPOAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x84A88E0", Offset = "0x84A7AE0", VA = "0x1884A88E0")]
		internal void OALGPCHHABD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class MBAFPGEKKOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public LDKIAIAGMBD targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MBAFPGEKKOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x84B8B70", Offset = "0x84B7D70", VA = "0x1884B8B70")]
		internal object FGGCAOEFAJG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class PCNAEKEEPGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public LDKIAIAGMBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PCNAEKEEPGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x84BEB30", Offset = "0x84BDD30", VA = "0x1884BEB30")]
		internal string HGDJEEGDBKD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly FODGIOKBGBI OOENBPLAOID;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly FODGIOKBGBI AMPPCDEHIPG;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly FODGIOKBGBI GBHIJEFFNEH;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly string ONCCBNJCDJH;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static readonly string PHKEMGMFNHM;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static readonly string NHKMIMMDBGP;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public static readonly Guid AGIPHGAAPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private MHBBONFJJIK FCFPPCDHFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private DBILADPCAAF BKDDCHLEEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private LKDJDKEKNAC GCMEJOEAFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private MEBNIAGNGEK LLMBGPNPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private LAMEDCHOMHL OIONFMJBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private DLBFDEDKKIP DKGLCLKCEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private OLBGBKMPEDD AOLJPOFFFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private JJOKMDOJOMN HCMOKBCCKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private NAEGGHPNDKJ JLPILAGLHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private FGCOLJKEGJL IBBJEJHOLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private IDisposable BFBEMDECPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private KBBKDEGOKGN MGGOFABMKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly AAILLPLJANG LKKMCGCKBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private PHLLCDOAJBE PPAIPFLLMBC;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus HHCPBPCCFMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA17F30", Offset = "0xA17130", VA = "0x180A17F30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x132D4E0", Offset = "0x132C6E0", VA = "0x18132D4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private MOALAMGIMLB LHDJPHOLKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x848DCB0", Offset = "0x848CEB0", VA = "0x18848DCB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x848D850", Offset = "0x848CA50", VA = "0x18848D850", Slot = "6")]
	public void ILLMBOBOELN(MEBNIAGNGEK LLMBGPNPABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x848BE00", Offset = "0x848B000", VA = "0x18848BE00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x848C540", Offset = "0x848B740", VA = "0x18848C540", Slot = "5")]
	[AsyncStateMachine(typeof(DFIAIIDMNEK))]
	public Task FJFIGNDLJBP(LDKIAIAGMBD KMOFNLCOIND, DKFFONJNCCB FMGLLICHMEL, CancellationToken DMKDGAIEPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x848DD00", Offset = "0x848CF00", VA = "0x18848DD00")]
	[AsyncStateMachine(typeof(LOMMGICMELG))]
	private Task IPPOPEOJPBO(LDKIAIAGMBD KMOFNLCOIND, DKFFONJNCCB FMGLLICHMEL, CancellationToken DMKDGAIEPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x848B990", Offset = "0x848AB90", VA = "0x18848B990")]
	private void CPJAOBLNKNH(NAEGGHPNDKJ JLPILAGLHOF, LDKIAIAGMBD KMOFNLCOIND, Exception MJPFDOAJBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x848C7E0", Offset = "0x848B9E0", VA = "0x18848C7E0")]
	private static void FMPFPDJMGPN(FPHPINCHKOK HGBIIKOJCCB, Exception MJPFDOAJBLF, [Optional] List<int> OLNLHLKCIHM, int AKCGGOOLGDC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x848E430", Offset = "0x848D630", VA = "0x18848E430")]
	[AsyncStateMachine(typeof(LJPCBEHIAEK))]
	private Task MBBKJMJMHMF(EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, LDKIAIAGMBD KMOFNLCOIND, DKFFONJNCCB FMGLLICHMEL, IHKEKBDONBN JPBKGEMLKBA, CancellationToken DMKDGAIEPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x848DE50", Offset = "0x848D050", VA = "0x18848DE50")]
	private void JIGLCPKFECD([CallerMemberName] string HNILPCLEJPC = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x848D370", Offset = "0x848C570", VA = "0x18848D370")]
	[AsyncStateMachine(typeof(PEGNFKJMOLE))]
	private Task HPFHIFOHEPE(EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x848D4A0", Offset = "0x848C6A0", VA = "0x18848D4A0")]
	private void IDPOFOOFMPO(LDKIAIAGMBD KMOFNLCOIND, CancellationToken DMKDGAIEPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x848B3E0", Offset = "0x848A5E0", VA = "0x18848B3E0")]
	private void BGLEOEBBBMC(LDKIAIAGMBD KMOFNLCOIND, TaskStatus CLEHGGOHMOO, string BDAAPBJEHGD, IHKEKBDONBN JPBKGEMLKBA, Exception NNDKGEOCFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x848E890", Offset = "0x848DA90", VA = "0x18848E890")]
	private void OPCLLMMAOEB(LDKIAIAGMBD KMOFNLCOIND, IHKEKBDONBN JPBKGEMLKBA, OperationCanceledException EEJCADFDKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x848D7D0", Offset = "0x848C9D0", VA = "0x18848D7D0")]
	private void IHGONIKLPGN(LDKIAIAGMBD KMOFNLCOIND, IHKEKBDONBN JPBKGEMLKBA, Exception MJPFDOAJBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x848E0E0", Offset = "0x848D2E0", VA = "0x18848E0E0")]
	private void JPFANDHELDD(LDKIAIAGMBD KMOFNLCOIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x848B7C0", Offset = "0x848A9C0", VA = "0x18848B7C0")]
	private static DBJKOHCNHMF CLBDOAFHFGI(LDKIAIAGMBD KMOFNLCOIND)
	{
		return default(DBJKOHCNHMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x848E590", Offset = "0x848D790", VA = "0x18848E590")]
	[AsyncStateMachine(typeof(ODIDJACICOP))]
	private Task MBHAMPIOMEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x848C680", Offset = "0x848B880", VA = "0x18848C680")]
	[AsyncStateMachine(typeof(BDCMBGHFMAP))]
	private Task<Matchmaking.BCOKBGGEHOC> FJKOMGMINHD(LDKIAIAGMBD KMOFNLCOIND, EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x848D080", Offset = "0x848C280", VA = "0x18848D080")]
	private static PLFCNAAENKM GHJHAOJFEEB(Matchmaking.BCOKBGGEHOC DPIODECEDBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x848D220", Offset = "0x848C420", VA = "0x18848D220")]
	[AsyncStateMachine(typeof(MMMLIGMEFPD))]
	private Task HKHDEHFNIHL(Matchmaking.BCOKBGGEHOC DPIODECEDBA, IHKEKBDONBN JPBKGEMLKBA, EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, CancellationToken PIBIIIAPLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x848E750", Offset = "0x848D950", VA = "0x18848E750")]
	[AsyncStateMachine(typeof(AHAHDEJPGPL))]
	private Task ONOOMLJBHHD(LDKIAIAGMBD KMOFNLCOIND, CancellationTokenSource DDPJKPEFDMB, Task PHBMLIGDDKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x848B820", Offset = "0x848AA20", VA = "0x18848B820")]
	[AsyncStateMachine(typeof(PBJANFKELIB))]
	private Task CNCICJNHJHC(IAAJJFDJPDA JMGILABOBNI, EGOLNJDEEMP ENIJPHENPOB, LDKIAIAGMBD LIFNBAGMPAD, IHKEKBDONBN MFNHHFDJADG, EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, CancellationToken JONPLMHBBFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x848BE50", Offset = "0x848B050", VA = "0x18848BE50")]
	private IHKEKBDONBN EAHJOLEPMGH(IHKEKBDONBN MFNHHFDJADG, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x848E2F0", Offset = "0x848D4F0", VA = "0x18848E2F0")]
	[AsyncStateMachine(typeof(ANHMJLLAFCI))]
	private Task KOHJKILFALF(EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x848DB80", Offset = "0x848CD80", VA = "0x18848DB80")]
	[AsyncStateMachine(typeof(BDBEHOKPDND))]
	private Task IMKNBJLCMDF(CancellationToken HCELDNOKOAM, int ABBDMCLAHED, ODJGKIKFMEP FEOKJEOAMPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x848B640", Offset = "0x848A840", VA = "0x18848B640")]
	private static void CIPIPOKDKBO(LDKIAIAGMBD KMOFNLCOIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x848C040", Offset = "0x848B240", VA = "0x18848C040")]
	private void EAPEBECGNNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x848D190", Offset = "0x848C390", VA = "0x18848D190")]
	private void HAFOKIEEBCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x848E910", Offset = "0x848DB10", VA = "0x18848E910")]
	private void PJCDHCIFNAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x848E6C0", Offset = "0x848D8C0", VA = "0x18848E6C0")]
	private void OGNOHIOOKAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x848B2F0", Offset = "0x848A4F0", VA = "0x18848B2F0")]
	private static void BECIPBAPAFG(LDKIAIAGMBD KMOFNLCOIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x848DFD0", Offset = "0x848D1D0", VA = "0x18848DFD0")]
	private static CancellationTokenRegistration JLCNLJPNIPM(LDKIAIAGMBD KMOFNLCOIND, CancellationToken PIBIIIAPLCH)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x848C290", Offset = "0x848B490", VA = "0x18848C290")]
	private static void ECEJFPFHBBM(LDKIAIAGMBD KMOFNLCOIND, Exception MJPFDOAJBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x848C390", Offset = "0x848B590", VA = "0x18848C390")]
	private void EEDKGKJMEOC(LDKIAIAGMBD KMOFNLCOIND, Task PHBMLIGDDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x848D020", Offset = "0x848C220", VA = "0x18848D020")]
	private static void GCMHLHCLEDM(Func<string> FNJOHGLGALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x848EBA0", Offset = "0x848DDA0", VA = "0x18848EBA0")]
	public HKHJKBJJKDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x848E660", Offset = "0x848D860", VA = "0x18848E660")]
	[CompilerGenerated]
	internal static (int, int?) NGKDCPDDJEK(PIFIONLEBIH KNADPDIBGFF)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[RecRoom.NoEngine.Common.Preserve]
internal class AICLHGJHNHK : CALKIGGPPIO, MGBHAJGBNCO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct OKEJPLNKEEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public AICLHGJHNHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public ODJGKIKFMEP localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x84BD190", Offset = "0x84BC390", VA = "0x1884BD190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x84BD670", Offset = "0x84BC870", VA = "0x1884BD670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class FPOHGHFCFIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public AICLHGJHNHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public ODJGKIKFMEP localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public FPOHGHFCFIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x84B63B0", Offset = "0x84B55B0", VA = "0x1884B63B0")]
		internal List<Task> ENPGJCNHNIF(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct IADMEDEOKNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public HCJIFMBBOCA taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public ODJGKIKFMEP localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x84B77A0", Offset = "0x84B69A0", VA = "0x1884B77A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x84B7B40", Offset = "0x84B6D40", VA = "0x1884B7B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct LHGEHKJNKAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AICLHGJHNHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x84B81A0", Offset = "0x84B73A0", VA = "0x1884B81A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x84B8480", Offset = "0x84B7680", VA = "0x1884B8480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly HashSet<HCJIFMBBOCA> OKFBMJOJBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private DBILADPCAAF BKDDCHLEEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private MEBNIAGNGEK LLMBGPNPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private ICLKLOMOCNH NJCBKJKMIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private DGJIAHJGPNK DHGPFLABCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private IDisposable BFBEMDECPAJ;

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x84A39F0", Offset = "0x84A2BF0", VA = "0x1884A39F0", Slot = "5")]
	public void ILLMBOBOELN(MEBNIAGNGEK LLMBGPNPABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x84A36A0", Offset = "0x84A28A0", VA = "0x1884A36A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x84A37D0", Offset = "0x84A29D0", VA = "0x1884A37D0", Slot = "4")]
	public bool GJGKOGJNFLA(HCJIFMBBOCA KJCPAPIMKJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x84A3CD0", Offset = "0x84A2ED0", VA = "0x1884A3CD0")]
	private void IPJMIKGPHOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x84A3DA0", Offset = "0x84A2FA0", VA = "0x1884A3DA0")]
	private void JPMFHKPIIMD(FIEDEFBCGNM GIKGHELDAKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x84A3900", Offset = "0x84A2B00", VA = "0x1884A3900")]
	[AsyncStateMachine(typeof(OKEJPLNKEEO))]
	private Task IJFLPDGFGGH(int ABBDMCLAHED, ODJGKIKFMEP FEOKJEOAMPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x84A3830", Offset = "0x84A2A30", VA = "0x1884A3830")]
	private Func<CancellationToken, List<Task>> GMHOKPDFPGL(int ABBDMCLAHED, ODJGKIKFMEP FEOKJEOAMPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x84A3FC0", Offset = "0x84A31C0", VA = "0x1884A3FC0")]
	private List<Task> KEPHIACAFJC(int ABBDMCLAHED, ODJGKIKFMEP FEOKJEOAMPL, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x84A4490", Offset = "0x84A3690", VA = "0x1884A4490")]
	[AsyncStateMachine(typeof(IADMEDEOKNA))]
	private Task NENJAFDHEAF(HCJIFMBBOCA PNMMBEAJIIE, CancellationToken PPOILDCNBFL, int ABBDMCLAHED, ODJGKIKFMEP FEOKJEOAMPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x84A3700", Offset = "0x84A2900", VA = "0x1884A3700")]
	[AsyncStateMachine(typeof(LHGEHKJNKAA))]
	private Task FBDEOLHCHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x84A45B0", Offset = "0x84A37B0", VA = "0x1884A45B0")]
	private void PCMJMPFBLNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x84A4630", Offset = "0x84A3830", VA = "0x1884A4630")]
	public AICLHGJHNHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[UnityEngine.Scripting.Preserve]
internal sealed class MKCNFJEBFDL : AFKJMJFJBOK, MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class BAJLMKPGOFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public BAJLMKPGOFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x84A7A90", Offset = "0x84A6C90", VA = "0x1884A7A90")]
		internal object COJDMPKEGMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class DFOPCHHDJFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DFOPCHHDJFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x84AC3B0", Offset = "0x84AB5B0", VA = "0x1884AC3B0")]
		internal object NBAOFJCAJLF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class CIIFCLGCLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CIIFCLGCLKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class ENKBBMMLLDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ENKBBMMLLDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x84B4F70", Offset = "0x84B4170", VA = "0x1884B4F70")]
		internal object KJLIHKMHFMD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class NAKBFMJPKBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public NAKBFMJPKBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x84BBE10", Offset = "0x84BB010", VA = "0x1884BBE10")]
		internal object BAFCGAHOIBA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private readonly Dictionary<Guid, CACMJBIEADD> MMDNIIIPOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private readonly TimeSpan JKANGFNALIL;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "9")]
	public void ILLMBOBOELN(MEBNIAGNGEK LLMBGPNPABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x84B8BF0", Offset = "0x84B7DF0", VA = "0x1884B8BF0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x84B95C0", Offset = "0x84B87C0", VA = "0x1884B95C0", Slot = "4")]
	public FAOABMFLDEO OOLDDNFEGEK(Guid BOAAABDJCPH)
	{
		return default(FAOABMFLDEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x84B9160", Offset = "0x84B8360", VA = "0x1884B9160", Slot = "5")]
	public bool KKKHDEJPLIG(Guid BOAAABDJCPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x84B8C00", Offset = "0x84B7E00", VA = "0x1884B8C00", Slot = "6")]
	public bool GADJKGKHEOI(Guid BOAAABDJCPH, Task MONDHIAMLMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x84B93E0", Offset = "0x84B85E0", VA = "0x1884B93E0", Slot = "7")]
	public bool LPGGCODEBAN(Guid BOAAABDJCPH, BAKFNEOFNEC IOEOAHLDCIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x84B9370", Offset = "0x84B8570", VA = "0x1884B9370", Slot = "8")]
	public Task<(BAKFNEOFNEC, Task)> LMDPHEHCELP(Guid BOAAABDJCPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x84B8F30", Offset = "0x84B8130", VA = "0x1884B8F30")]
	private void IIIJMIFBDHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x84B97E0", Offset = "0x84B89E0", VA = "0x1884B97E0")]
	public MKCNFJEBFDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[RecRoom.NoEngine.Common.Preserve]
internal class BHEKBFHKMME : CJNBIMMBOOP, MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private class CHJLNOELJOI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private readonly LDKIAIAGMBD AGODDPHOGHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private readonly CancellationTokenSource BDMFGMOCHPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public readonly CancellationToken EIFJDLIJOPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private bool JLDOANKGJOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private bool DJOMNIEOFJP;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x84ABBA0", Offset = "0x84AADA0", VA = "0x1884ABBA0")]
		public CHJLNOELJOI(LDKIAIAGMBD AGODDPHOGHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x84ABA50", Offset = "0x84AAC50", VA = "0x1884ABA50")]
		public void PCMJMPFBLNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x84ABA20", Offset = "0x84AAC20", VA = "0x1884ABA20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class OECAFKNKAOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public IDKGCAIANLP disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public OECAFKNKAOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x84BD090", Offset = "0x84BC290", VA = "0x1884BD090")]
		internal object EDMPJFALIEO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct PCBFHNHPNIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public IDKGCAIANLP disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public BHEKBFHKMME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x84BE480", Offset = "0x84BD680", VA = "0x1884BE480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x84BE8D0", Offset = "0x84BDAD0", VA = "0x1884BE8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class KEECAPDAANL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public BHEKBFHKMME <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KEECAPDAANL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x84B80C0", Offset = "0x84B72C0", VA = "0x1884B80C0")]
		internal object FGOFBGJEDCJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class CJGEEHMLBAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public LDKIAIAGMBD newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public KEECAPDAANL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CJGEEHMLBAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x84ABC50", Offset = "0x84AAE50", VA = "0x1884ABC50")]
		internal object GIIBIGJOALC((LDKIAIAGMBD lastLocalPlayerRoomInstance, LDKIAIAGMBD newRoomInstance, DLBFDEDKKIP fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct EMMMAEKCLII : IAsyncStateMachine
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
		public BHEKBFHKMME <>4__this;

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
		private AHAEBJLBPKA <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x84B23D0", Offset = "0x84B15D0", VA = "0x1884B23D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class PEICCKGBPGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public LDKIAIAGMBD newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PEICCKGBPGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x84BF740", Offset = "0x84BE940", VA = "0x1884BF740")]
		internal object BJMNMKDMLJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x84BF7E0", Offset = "0x84BE9E0", VA = "0x1884BF7E0")]
		internal void JOIAFMOALDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x84BF860", Offset = "0x84BEA60", VA = "0x1884BF860")]
		internal object KIGFJMHEBMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x84BF8A0", Offset = "0x84BEAA0", VA = "0x1884BF8A0")]
		internal object MKFDNLLCBLJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct EEAKGAGHEEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public LDKIAIAGMBD newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public BHEKBFHKMME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public DKFFONJNCCB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private PEICCKGBPGJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private AHAEBJLBPKA <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x84B1300", Offset = "0x84B0500", VA = "0x1884B1300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x84B22C0", Offset = "0x84B14C0", VA = "0x1884B22C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly MNHPGBKFMKH.BDLKMHEEJKM BFJKNEAPCCJ;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly JIHHPFPGGDH EOBDILMMEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private DBILADPCAAF BKDDCHLEEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private MEBNIAGNGEK LLMBGPNPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private DLBFDEDKKIP DKGLCLKCEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private LAMEDCHOMHL OIONFMJBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private GJCPHMABOGP EPCCHCFNMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private FKJNHFGFCKO LNMPHMOJHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private LDKIAIAGMBD GLAHAEKDIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private CHJLNOELJOI FLKDIFACKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private bool PMLEKFNPKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private Task KDHDAFBACGL;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private MOALAMGIMLB LHDJPHOLKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x84A9570", Offset = "0x84A8770", VA = "0x1884A9570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool ALGKKPNCIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xC63350", Offset = "0xC62550", VA = "0x180C63350")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x84A96F0", Offset = "0x84A88F0", VA = "0x1884A96F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x84A92D0", Offset = "0x84A84D0", VA = "0x1884A92D0", Slot = "4")]
	public void ILLMBOBOELN(MEBNIAGNGEK LLMBGPNPABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x84A8C00", Offset = "0x84A7E00", VA = "0x1884A8C00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x84A8B10", Offset = "0x84A7D10", VA = "0x1884A8B10")]
	[AsyncStateMachine(typeof(PCBFHNHPNIO))]
	private Task DKMOBCDNBHO(IDKGCAIANLP HMKGNEMMMCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x84A9140", Offset = "0x84A8340", VA = "0x1884A9140")]
	private void HNDNOMDKDCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x84A8980", Offset = "0x84A7B80", VA = "0x1884A8980")]
	private void CKDJGHDDHDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x84A9700", Offset = "0x84A8900", VA = "0x1884A9700")]
	private void PBCGKBFDBCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x84A90D0", Offset = "0x84A82D0", VA = "0x1884A90D0")]
	private bool HKPPLKKPBPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x84A8D70", Offset = "0x84A7F70", VA = "0x1884A8D70")]
	[AsyncStateMachine(typeof(EMMMAEKCLII))]
	private void GHDDDODLNOI(int KOCMKKLCMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x84A8E40", Offset = "0x84A8040", VA = "0x1884A8E40")]
	private void HCKGBJEBFFM([Out] IDisposable IEFDBCFIAHO, [Out] IDisposable DHLHNILPNAM, [Out] IDisposable PPNGDFPOKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x84A9880", Offset = "0x84A8A80", VA = "0x1884A9880")]
	private bool POLHOBIAHKM(LDKIAIAGMBD AGODDPHOGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x84A9980", Offset = "0x84A8B80", VA = "0x1884A9980")]
	private void PPJHMMDDHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x84A95C0", Offset = "0x84A87C0", VA = "0x1884A95C0")]
	[AsyncStateMachine(typeof(EEAKGAGHEEB))]
	private Task IPPOPEOJPBO(LDKIAIAGMBD AGODDPHOGHF, DKFFONJNCCB FMGLLICHMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x84A9D60", Offset = "0x84A8F60", VA = "0x1884A9D60")]
	public BHEKBFHKMME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[UnityEngine.Scripting.Preserve]
internal sealed class DOGFMOGKBGE : KGIPECMHEKG, MGBHAJGBNCO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct JMCMDHINMDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<LGKCOAGJCFN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public DOGFMOGKBGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<LGKCOAGJCFN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x84B7DC0", Offset = "0x84B6FC0", VA = "0x1884B7DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x84B8050", Offset = "0x84B7250", VA = "0x1884B8050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class BDCDJEIAKDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public CBMIKICCFNL message;

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public BDCDJEIAKDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x84A8340", Offset = "0x84A7540", VA = "0x1884A8340")]
		internal object EBDNFDHAJMD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class MNEPKAPAHEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public CBMIKICCFNL messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MNEPKAPAHEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x84BBDB0", Offset = "0x84BAFB0", VA = "0x1884BBDB0")]
		internal object BNBFIMPDFEL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class EODGFMEIEPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public CBMIKICCFNL request;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public EODGFMEIEPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x84B4FD0", Offset = "0x84B41D0", VA = "0x1884B4FD0")]
		internal object JBBGBANDJGB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct GDCPPNFFNMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public CBMIKICCFNL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public DOGFMOGKBGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<GLOBKHNLMMN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x84B63F0", Offset = "0x84B55F0", VA = "0x1884B63F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x84B6CC0", Offset = "0x84B5EC0", VA = "0x1884B6CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class OMEJFHJGEED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public CBMIKICCFNL operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public OMEJFHJGEED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x84BD6D0", Offset = "0x84BC8D0", VA = "0x1884BD6D0")]
		internal object CLJKNNIOFLJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct BABHNDFNLKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public CBMIKICCFNL operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public DOGFMOGKBGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private IHKEKBDONBN <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<CBMIKICCFNL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x84A6EC0", Offset = "0x84A60C0", VA = "0x1884A6EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x84A7A30", Offset = "0x84A6C30", VA = "0x1884A7A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct GGFBJKKDBCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public AsyncTaskMethodBuilder<GLOBKHNLMMN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public DOGFMOGKBGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public CBMIKICCFNL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private BDFADCHMCHI.NBCLHFNGGNP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private IHKEKBDONBN <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter<CBMIKICCFNL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x84B6D20", Offset = "0x84B5F20", VA = "0x1884B6D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x84B7250", Offset = "0x84B6450", VA = "0x1884B7250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class ADGBIJFLBPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public GLOBKHNLMMN operation;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ADGBIJFLBPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x84A29D0", Offset = "0x84A1BD0", VA = "0x1884A29D0")]
		internal object PHMAJBKBMKD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct LONOBGHAHFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public GLOBKHNLMMN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public DOGFMOGKBGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private EAIPOBMEIGP<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x84B84E0", Offset = "0x84B76E0", VA = "0x1884B84E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x84B8B10", Offset = "0x84B7D10", VA = "0x1884B8B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class DFMNIOJKHNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public CBMIKICCFNL request;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DFMNIOJKHNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x84AC350", Offset = "0x84AB550", VA = "0x1884AC350")]
		internal object IHJKODDFJFH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class NOCPLNBCEPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public CBMIKICCFNL request;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public NOCPLNBCEPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x84BC530", Offset = "0x84BB730", VA = "0x1884BC530")]
		internal object OPBDOAGJJJO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private MEBNIAGNGEK LLMBGPNPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private OLBGBKMPEDD AOLJPOFFFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private EKDHJNKDHJK PGODBKJLNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private BCELOMMLBPF INOIIJHMAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private LKDJDKEKNAC GCMEJOEAFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private TaskCompletionSource<LGKCOAGJCFN> IMKECGGHPLD;

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x84AEAA0", Offset = "0x84ADCA0", VA = "0x1884AEAA0", Slot = "7")]
	public void ILLMBOBOELN(MEBNIAGNGEK LLMBGPNPABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x84AE670", Offset = "0x84AD870", VA = "0x1884AE670", Slot = "6")]
	[AsyncStateMachine(typeof(JMCMDHINMDI))]
	public Task<LGKCOAGJCFN> GHOBKEFLLNG(CancellationToken CDJPCHILKDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x84AF0A0", Offset = "0x84AE2A0", VA = "0x1884AF0A0", Slot = "4")]
	public void OPPDMHAFNND(CBMIKICCFNL BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x84AEC20", Offset = "0x84ADE20", VA = "0x1884AEC20", Slot = "5")]
	public void JCDIKKFFJOA(CBMIKICCFNL LCNEMGPBMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x84AE780", Offset = "0x84AD980", VA = "0x1884AE780")]
	[AsyncStateMachine(typeof(GDCPPNFFNMM))]
	private Task GIOIICHPFGL(CBMIKICCFNL MGALKMHOLCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x84AE080", Offset = "0x84AD280", VA = "0x1884AE080")]
	[AsyncStateMachine(typeof(BABHNDFNLKA))]
	private Task CFOJCNPMNPM(CBMIKICCFNL LDHBHMDKPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x84AE190", Offset = "0x84AD390", VA = "0x1884AE190")]
	[AsyncStateMachine(typeof(GGFBJKKDBCD))]
	private Task<GLOBKHNLMMN> DFDCJFHLJCA(CBMIKICCFNL MGALKMHOLCM, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x84AEB90", Offset = "0x84ADD90", VA = "0x1884AEB90")]
	private IHKEKBDONBN JAPIFLFOJEA(CBMIKICCFNL BHGDNHJGCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x84AEF80", Offset = "0x84AE180", VA = "0x1884AEF80")]
	[AsyncStateMachine(typeof(LONOBGHAHFC))]
	private Task KGFCPGPNGJJ(GLOBKHNLMMN AFMEMNMIOCM, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x84AE890", Offset = "0x84ADA90", VA = "0x1884AE890")]
	private GLOBKHNLMMN IHPGAHOFFIN(CBMIKICCFNL MGALKMHOLCM, IHKEKBDONBN DFBIOGENMMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x36742D0", Offset = "0x36734D0", VA = "0x1836742D0")]
	private T PHHPHPCMCNO<T>(T MLCDCHNOCFI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x84AE2E0", Offset = "0x84AD4E0", VA = "0x1884AE2E0")]
	private GLOBKHNLMMN FHPCGAAHIFM(CBMIKICCFNL MGALKMHOLCM, IHKEKBDONBN DFBIOGENMMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public DOGFMOGKBGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class MKHMFCKCEKK : EKDHJNKDHJK, MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class DAJGMJIAMGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DAJGMJIAMGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x84ABD10", Offset = "0x84AAF10", VA = "0x1884ABD10")]
		internal object OHEHEINLOOF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class KGEKGPOCBGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KGEKGPOCBGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x84B8130", Offset = "0x84B7330", VA = "0x1884B8130")]
		internal object IALPFCNPKLM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private LKDJDKEKNAC GCMEJOEAFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private CAFJFKGMMAP LGIPFAFNFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private KGIPECMHEKG COMNJHFAEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private AFKJMJFJBOK MMDNIIIPOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private COGAEPFNDJG LNCPFPACNIN;

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x84BA5D0", Offset = "0x84B97D0", VA = "0x1884BA5D0", Slot = "6")]
	public void ILLMBOBOELN(MEBNIAGNGEK LLMBGPNPABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x84B9C50", Offset = "0x84B8E50", VA = "0x1884B9C50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x84BB2F0", Offset = "0x84BA4F0", VA = "0x1884BB2F0", Slot = "4")]
	public FAOABMFLDEO NHJCLOAIBOG(CBMIKICCFNL FHKILDIHLGE)
	{
		return default(FAOABMFLDEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x84B9D00", Offset = "0x84B8F00", VA = "0x1884B9D00", Slot = "5")]
	public void GAIFGPKOAFA(Guid BOAAABDJCPH, Task MONDHIAMLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x84B98A0", Offset = "0x84B8AA0", VA = "0x1884B98A0")]
	private void AEBLLDOHHAI(KOEIHCIJPPL IMPAKIFFNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x84BA980", Offset = "0x84B9B80", VA = "0x1884BA980")]
	private void LGAOKOIOLAO(LLAGKKENMEI ELJMGFIBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x84B9F10", Offset = "0x84B9110", VA = "0x1884B9F10")]
	private void HLNGDACMPKH(LLAGKKENMEI ELJMGFIBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x84BA740", Offset = "0x84B9940", VA = "0x1884BA740")]
	private void KPDNHHHKKLE(LLAGKKENMEI ELJMGFIBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x84B99B0", Offset = "0x84B8BB0", VA = "0x1884B99B0")]
	private BAKFNEOFNEC DHAJJLPNCJM(CBMIKICCFNL BHGDNHJGCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x84BA180", Offset = "0x84B9380", VA = "0x1884BA180")]
	private void HMHAKIOIMBG(CBMIKICCFNL LDHBHMDKPLL, BAKFNEOFNEC IOEOAHLDCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x84BB110", Offset = "0x84BA310", VA = "0x1884BB110")]
	private bool MCLDFKDHHLN(CBMIKICCFNL LDHBHMDKPLL, BAKFNEOFNEC IOEOAHLDCIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x84BAF00", Offset = "0x84BA100", VA = "0x1884BAF00")]
	private bool MBFLHLFINFK(CBMIKICCFNL CAKKAKLNHKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x84BA380", Offset = "0x84B9580", VA = "0x1884BA380")]
	private bool IFJFLGBJBEF(byte PIOPNFOBDGK, ExitGames.Client.Photon.Hashtable ELJMGFIBFCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MKHMFCKCEKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[UnityEngine.Scripting.Preserve]
internal sealed class ONABBEHFCBM : PGINMAMCAGF, MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class IBLPEEJMFMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public LGKCOAGJCFN operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public ONABBEHFCBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public CBMIKICCFNL roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public IBLPEEJMFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x84B7D50", Offset = "0x84B6F50", VA = "0x1884B7D50")]
		internal object NBIOLHGOILH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x84B7BA0", Offset = "0x84B6DA0", VA = "0x1884B7BA0")]
		internal object LIFPJJOLIFE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct DOOGCNPOLOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public AsyncTaskMethodBuilder<BAKFNEOFNEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public ONABBEHFCBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public CBMIKICCFNL roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter<BAKFNEOFNEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x84AF430", Offset = "0x84AE630", VA = "0x1884AF430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x84AFAD0", Offset = "0x84AECD0", VA = "0x1884AFAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class OEDPOHIAMIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public LGKCOAGJCFN operationType;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public OEDPOHIAMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x84BD120", Offset = "0x84BC320", VA = "0x1884BD120")]
		internal object JDLKJLLFKHL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class PMDFFJFEBEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public CBMIKICCFNL request;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PMDFFJFEBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x84C0000", Offset = "0x84BF200", VA = "0x1884C0000")]
		internal object LHHMLNPOGMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x84BFF90", Offset = "0x84BF190", VA = "0x1884BFF90")]
		internal object KNPNBHLDFBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x84BFF20", Offset = "0x84BF120", VA = "0x1884BFF20")]
		internal object IHOJHHCNMEI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct AIFOLPPLGJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public AsyncTaskMethodBuilder<BAKFNEOFNEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public CBMIKICCFNL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public ONABBEHFCBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private PMDFFJFEBEC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private FAOABMFLDEO <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private BAKFNEOFNEC <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<(BAKFNEOFNEC validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x84A46C0", Offset = "0x84A38C0", VA = "0x1884A46C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x84A4F90", Offset = "0x84A4190", VA = "0x1884A4F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private LKDJDKEKNAC GCMEJOEAFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private CAFJFKGMMAP LGIPFAFNFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private EKDHJNKDHJK PGODBKJLNFF;

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x84BD920", Offset = "0x84BCB20", VA = "0x1884BD920", Slot = "5")]
	public void ILLMBOBOELN(MEBNIAGNGEK LLMBGPNPABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x84BDB10", Offset = "0x84BCD10", VA = "0x1884BDB10", Slot = "4")]
	[AsyncStateMachine(typeof(DOOGCNPOLOC))]
	private Task<BAKFNEOFNEC> PHILOPPCMHM(CBMIKICCFNL BHGDNHJGCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x84BD730", Offset = "0x84BC930", VA = "0x1884BD730")]
	private bool DDFGMPBMAHP(LGKCOAGJCFN LCIBBKGCJFA, [Out] BAKFNEOFNEC IGGKBIDIAJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x84BD9D0", Offset = "0x84BCBD0", VA = "0x1884BD9D0")]
	[AsyncStateMachine(typeof(AIFOLPPLGJO))]
	private Task<BAKFNEOFNEC> KNLMJHGPBNJ(CBMIKICCFNL MGALKMHOLCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public ONABBEHFCBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class ENAEEAHCNOE : ALEJNHMPADG, MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private struct LCGFHEEAFFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public ELAGIFLJMJI IHNDBMIDBEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public long MDKBNEEMIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public Guid? GHMHBAKMPDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public bool OODLKHPNEDK;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct PFFNCAEBALI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public AsyncTaskMethodBuilder<IAAJJFDJPDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public LDKIAIAGMBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public ENAEEAHCNOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter<JKGEOIDCPBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<IAAJJFDJPDA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x84BF8E0", Offset = "0x84BEAE0", VA = "0x1884BF8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x84BFEB0", Offset = "0x84BF0B0", VA = "0x1884BFEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class ODIGPHOILKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ODIGPHOILKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x84BCFE0", Offset = "0x84BC1E0", VA = "0x1884BCFE0")]
		internal object AJBKOILMLGP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct NMKEGABAGDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<JKGEOIDCPBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public ENAEEAHCNOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public LDKIAIAGMBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private ODIGPHOILKC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter<JKGEOIDCPBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x84BBED0", Offset = "0x84BB0D0", VA = "0x1884BBED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x84BC4C0", Offset = "0x84BB6C0", VA = "0x1884BC4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct CGGCCDJGBID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder<IAAJJFDJPDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public ENAEEAHCNOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public LDKIAIAGMBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public JKGEOIDCPBI roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<LCGFHEEAFFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x84AB440", Offset = "0x84AA640", VA = "0x1884AB440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x84AB9B0", Offset = "0x84AABB0", VA = "0x1884AB9B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class GGIPCMEOCFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public JKGEOIDCPBI roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public GGIPCMEOCFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xE6E1F0", Offset = "0xE6D3F0", VA = "0x180E6E1F0")]
		internal bool DGHPMNEBDNI(LKOOIDABJPJ sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x84B73E0", Offset = "0x84B65E0", VA = "0x1884B73E0")]
		internal object PMLEPEIGCJJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x84B72C0", Offset = "0x84B64C0", VA = "0x1884B72C0")]
		internal object ALHAPMBGKDH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x84B7350", Offset = "0x84B6550", VA = "0x1884B7350")]
		internal object JFBFLEAJECC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class GOIFJBCGMLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public GGIPCMEOCFG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public GOIFJBCGMLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x84B74A0", Offset = "0x84B66A0", VA = "0x1884B74A0")]
		internal object DODGHALMMKG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct CBLENHAJKJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder<LCGFHEEAFFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public JKGEOIDCPBI roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public ENAEEAHCNOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public LDKIAIAGMBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private GOIFJBCGMLH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private TaskAwaiter<LCGFHEEAFFI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private TaskAwaiter<HPNKLCGCBEM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x84AA430", Offset = "0x84A9630", VA = "0x1884AA430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x84AB3D0", Offset = "0x84AA5D0", VA = "0x1884AB3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class EIJBDHHAPJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public EIJBDHHAPJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x84B2320", Offset = "0x84B1520", VA = "0x1884B2320")]
		internal object NEBFABJEKGN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct DGMEDEBDIIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AsyncTaskMethodBuilder<LCGFHEEAFFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public LKOOIDABJPJ subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public ENAEEAHCNOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public LDKIAIAGMBD dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private EIJBDHHAPJI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private TaskAwaiter<IACGOJIMLMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x84AC410", Offset = "0x84AB610", VA = "0x1884AC410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x84ACAE0", Offset = "0x84ABCE0", VA = "0x1884ACAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private LAMEDCHOMHL OIONFMJBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private GJCPHMABOGP EPCCHCFNMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private GHPBGHDHCCH NOGEMALBFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private AJFCPCJPLCN LGAFNDNNMOA;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x84B3DE0", Offset = "0x84B2FE0", VA = "0x1884B3DE0", Slot = "5")]
	public void ILLMBOBOELN(MEBNIAGNGEK LLMBGPNPABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x84B4040", Offset = "0x84B3240", VA = "0x1884B4040", Slot = "4")]
	[AsyncStateMachine(typeof(PFFNCAEBALI))]
	public Task<IAAJJFDJPDA> NPOIDNKGBKH(EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, LDKIAIAGMBD KMOFNLCOIND, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x84B3C80", Offset = "0x84B2E80", VA = "0x1884B3C80")]
	[AsyncStateMachine(typeof(NMKEGABAGDG))]
	private Task<JKGEOIDCPBI> FCMALLKCIEK(LDKIAIAGMBD KMOFNLCOIND, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x84B3ED0", Offset = "0x84B30D0", VA = "0x1884B3ED0")]
	[AsyncStateMachine(typeof(CGGCCDJGBID))]
	private Task<IAAJJFDJPDA> KPPNAFFHGJN(LDKIAIAGMBD KMOFNLCOIND, JKGEOIDCPBI GAGMCMAACOG, long DLHGMNACNGF, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x84B41A0", Offset = "0x84B33A0", VA = "0x1884B41A0")]
	[AsyncStateMachine(typeof(CBLENHAJKJD))]
	private Task<LCGFHEEAFFI> PNGMODNADNL(LDKIAIAGMBD KMOFNLCOIND, JKGEOIDCPBI GAGMCMAACOG, long DLHGMNACNGF, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x84B3B10", Offset = "0x84B2D10", VA = "0x1884B3B10")]
	[AsyncStateMachine(typeof(DGMEDEBDIIK))]
	private Task<LCGFHEEAFFI> ADFDMCHCBKN(LDKIAIAGMBD OCNFFIEHHKC, LKOOIDABJPJ HMMHPLPIBDK, long DLHGMNACNGF, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public ENAEEAHCNOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[UnityEngine.Scripting.Preserve]
internal sealed class FLLMFNJBJPD : BCELOMMLBPF, MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class AIAOKIKEEDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public CBMIKICCFNL request;

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public AIAOKIKEEDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x84A3640", Offset = "0x84A2840", VA = "0x1884A3640")]
		internal object BFDGGJLKGJH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private struct AOKAKNPEOLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public AsyncTaskMethodBuilder<CBMIKICCFNL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public CBMIKICCFNL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public FLLMFNJBJPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public IHKEKBDONBN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private TaskAwaiter<CBMIKICCFNL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x84A6840", Offset = "0x84A5A40", VA = "0x1884A6840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x84A6E50", Offset = "0x84A6050", VA = "0x1884A6E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct BMNNJBKOIAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public AsyncTaskMethodBuilder<CBMIKICCFNL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public FLLMFNJBJPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public IHKEKBDONBN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TaskAwaiter<MEAOOFOHDKO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x84A9DD0", Offset = "0x84A8FD0", VA = "0x1884A9DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x84AA3C0", Offset = "0x84A95C0", VA = "0x1884AA3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class NEAHLHKNINC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public CBMIKICCFNL request;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public NEAHLHKNINC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x84BBE70", Offset = "0x84BB070", VA = "0x1884BBE70")]
		internal object LGBCONJMGHK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct ENGFFMIOHAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder<CBMIKICCFNL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public CBMIKICCFNL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public FLLMFNJBJPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public IHKEKBDONBN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private BOCIKMOFFGJ <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private EFAPEFGONHF <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private TaskAwaiter<MEAOOFOHDKO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x84B4310", Offset = "0x84B3510", VA = "0x1884B4310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x84B4F00", Offset = "0x84B4100", VA = "0x1884B4F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private LKDJDKEKNAC GCMEJOEAFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private FEEFIKKCALC EPOJJBPPNKI;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private KFHGIGIDJID PIPFJHGKIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x84B5B90", Offset = "0x84B4D90", VA = "0x1884B5B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x84B59A0", Offset = "0x84B4BA0", VA = "0x1884B59A0", Slot = "8")]
	public void ILLMBOBOELN(MEBNIAGNGEK LLMBGPNPABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x84B5A30", Offset = "0x84B4C30", VA = "0x1884B5A30", Slot = "4")]
	[AsyncStateMachine(typeof(AOKAKNPEOLK))]
	public Task<CBMIKICCFNL> JOHDGNGBKJF(CBMIKICCFNL MGALKMHOLCM, IHKEKBDONBN DFBIOGENMMF, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x84B57A0", Offset = "0x84B49A0", VA = "0x1884B57A0", Slot = "5")]
	[AsyncStateMachine(typeof(BMNNJBKOIAC))]
	public Task<CBMIKICCFNL> AAJDEKCCHFA(CancellationToken HCELDNOKOAM, IHKEKBDONBN DFBIOGENMMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x84B58F0", Offset = "0x84B4AF0", VA = "0x1884B58F0", Slot = "6")]
	public FBMKMKEAMFG BILFDBJLLJA(GLOBKHNLMMN GFJNKCCMOOO, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x84B5DB0", Offset = "0x84B4FB0", VA = "0x1884B5DB0", Slot = "7")]
	public FBMKMKEAMFG OKOPNGCAFIM(GLOBKHNLMMN GFJNKCCMOOO, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x84B5C50", Offset = "0x84B4E50", VA = "0x1884B5C50")]
	[AsyncStateMachine(typeof(ENGFFMIOHAE))]
	private Task<CBMIKICCFNL> OFIPKKNJHHN(CBMIKICCFNL MGALKMHOLCM, IHKEKBDONBN DFBIOGENMMF, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x37F3C60", Offset = "0x37F2E60", VA = "0x1837F3C60")]
	private static byte[] BBMACNBFOLF(CBMIKICCFNL BDAAPBJEHGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public FLLMFNJBJPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[UnityEngine.Scripting.Preserve]
internal sealed class DDNCADNBGOL : CAFJFKGMMAP, MGBHAJGBNCO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private PFIGMICDKCM OCEAMFGGCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private LKDJDKEKNAC GCMEJOEAFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private OLBGBKMPEDD AOLJPOFFFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private ICFDEOCFBGL EDJBDOJJKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private LAMEDCHOMHL OIONFMJBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private FKJNHFGFCKO LNMPHMOJHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private CALKIGGPPIO ACMFJNKHDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private GJCPHMABOGP EPCCHCFNMNH;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private MOALAMGIMLB LHDJPHOLKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x84ABF00", Offset = "0x84AB100", VA = "0x1884ABF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static BAKFNEOFNEC KDJBHGKCOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x84AC340", Offset = "0x84AB540", VA = "0x1884AC340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x84ABD90", Offset = "0x84AAF90", VA = "0x1884ABD90", Slot = "6")]
	public void ILLMBOBOELN(MEBNIAGNGEK LLMBGPNPABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x84ABF50", Offset = "0x84AB150", VA = "0x1884ABF50", Slot = "4")]
	public BAKFNEOFNEC JAAOAHCPHKC(KPDBONCIMNC EEODOEPMOBC, LGKCOAGJCFN PBGOMDAJBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x84AC0C0", Offset = "0x84AB2C0", VA = "0x1884AC0C0", Slot = "5")]
	public BAKFNEOFNEC KPKLOPNEMKJ(KPDBONCIMNC MAGKLMEPFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x84ABD80", Offset = "0x84AAF80", VA = "0x1884ABD80")]
	private static BAKFNEOFNEC FBAMBOFLPKG(LIGHLHNEGBJ BPAILNFLNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public DDNCADNBGOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class PEFHOOMJHJL : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x84BEC30", Offset = "0x84BDE30", VA = "0x1884BEC30")]
	public PEFHOOMJHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x76A8C10", Offset = "0x76A7E10", VA = "0x1876A8C10")]
	public PEFHOOMJHJL(string BDAAPBJEHGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[UnityEngine.Scripting.Preserve]
internal sealed class DPLLJGBIBID : OLPLOOGCKPM, MGBHAJGBNCO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct DMCFPJHEEFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public AsyncTaskMethodBuilder<BAKFNEOFNEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public DPLLJGBIBID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public LDMGLHEANGA autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private EAIPOBMEIGP<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private PAIGJFEOFBG <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private TaskAwaiter<BAKFNEOFNEC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x84AD4C0", Offset = "0x84AC6C0", VA = "0x1884AD4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x84AE010", Offset = "0x84AD210", VA = "0x1884AE010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct DLAKHOGKGGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public DPLLJGBIBID <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x84ACD20", Offset = "0x84ABF20", VA = "0x1884ACD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x84AD460", Offset = "0x84AC660", VA = "0x1884AD460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct OAAOJOCFOOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public DPLLJGBIBID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x84BC590", Offset = "0x84BB790", VA = "0x1884BC590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x84BCAA0", Offset = "0x84BBCA0", VA = "0x1884BCAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct EDFCMICOHDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public DPLLJGBIBID <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x84B0B50", Offset = "0x84AFD50", VA = "0x1884B0B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x84B12A0", Offset = "0x84B04A0", VA = "0x1884B12A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct HDGJHFAIGHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public DPLLJGBIBID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x84B75A0", Offset = "0x84B67A0", VA = "0x1884B75A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x84B7740", Offset = "0x84B6940", VA = "0x1884B7740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct FCFNDAGJCNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public DPLLJGBIBID <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x84B5030", Offset = "0x84B4230", VA = "0x1884B5030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x84B5740", Offset = "0x84B4940", VA = "0x1884B5740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct FNHJPONCDGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public DPLLJGBIBID <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x84B5EE0", Offset = "0x84B50E0", VA = "0x1884B5EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x84B6350", Offset = "0x84B5550", VA = "0x1884B6350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct OGEGJJDOJEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public DPLLJGBIBID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public KMPELHDOPPN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private EAIPOBMEIGP<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x84DAE50", Offset = "0x84DA050", VA = "0x1884DAE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x84DB3F0", Offset = "0x84DA5F0", VA = "0x1884DB3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private LKDJDKEKNAC GCMEJOEAFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private MEBNIAGNGEK LLMBGPNPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private LAMEDCHOMHL OIONFMJBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private BCELOMMLBPF INOIIJHMAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private OLBGBKMPEDD AOLJPOFFFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private CALKIGGPPIO ACMFJNKHDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private CancellationTokenSource ADBIIKDKKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private Task MAKKJIILIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private TaskCompletionSource<int> GCABMILPKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private int JGANFHEDKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private int DCHFCBACAJO;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x84B02E0", Offset = "0x84AF4E0", VA = "0x1884B02E0", Slot = "6")]
	public void ILLMBOBOELN(MEBNIAGNGEK LLMBGPNPABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x12BF2C0", Offset = "0x12BE4C0", VA = "0x1812BF2C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x84B0880", Offset = "0x84AFA80", VA = "0x1884B0880")]
	private void OKECCJDGHIB(float EJEMFGABGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x84B01B0", Offset = "0x84AF3B0", VA = "0x1884B01B0", Slot = "4")]
	[AsyncStateMachine(typeof(DMCFPJHEEFO))]
	public Task<BAKFNEOFNEC> HPLAFMHEMPO(LDMGLHEANGA NCCNNAGALKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x84B00C0", Offset = "0x84AF2C0", VA = "0x1884B00C0", Slot = "5")]
	[AsyncStateMachine(typeof(DLAKHOGKGGH))]
	public Task GCGJFELMJCF([Optional] CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x12BF2C0", Offset = "0x12BE4C0", VA = "0x1812BF2C0")]
	public void GIJPPEIFNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x84AFF50", Offset = "0x84AF150", VA = "0x1884AFF50")]
	private PAIGJFEOFBG FCNBKJOJCJI(LDMGLHEANGA NCCNNAGALKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x84B0790", Offset = "0x84AF990", VA = "0x1884B0790")]
	[AsyncStateMachine(typeof(OAAOJOCFOOC))]
	private Task MEJPJJEHKCF(CancellationToken DMKDGAIEPFB, int ABBDMCLAHED, ODJGKIKFMEP FEOKJEOAMPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x84B0690", Offset = "0x84AF890", VA = "0x1884B0690")]
	[AsyncStateMachine(typeof(EDFCMICOHDC))]
	private Task JMJFGHNEMDK(CancellationToken DMKDGAIEPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x84B0490", Offset = "0x84AF690", VA = "0x1884B0490")]
	[AsyncStateMachine(typeof(HDGJHFAIGHJ))]
	private Task JFKCDGJNBNB([Optional] CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x84B0960", Offset = "0x84AFB60", VA = "0x1884B0960")]
	[AsyncStateMachine(typeof(FCFNDAGJCNL))]
	private Task PALHCLIGFNA(CancellationToken DMKDGAIEPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x84B0A50", Offset = "0x84AFC50", VA = "0x1884B0A50")]
	[AsyncStateMachine(typeof(FNHJPONCDGN))]
	private Task PIMIMOLGFAJ(CancellationToken INFBNOMMIFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x84AFB40", Offset = "0x84AED40", VA = "0x1884AFB40")]
	private Task AJKGOOHOKNO(KMPELHDOPPN MNDHCACEDBN, CancellationToken DMKDGAIEPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x84B0580", Offset = "0x84AF780", VA = "0x1884B0580")]
	[AsyncStateMachine(typeof(OGEGJJDOJEL))]
	private Task JGLFIBJKIEN(KMPELHDOPPN MNDHCACEDBN, CancellationToken DMKDGAIEPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x84AFCD0", Offset = "0x84AEED0", VA = "0x1884AFCD0")]
	private bool CBOEBOKBMNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public DPLLJGBIBID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[UnityEngine.Scripting.Preserve]
internal class AGBINBDOCMA : ICFDEOCFBGL, MGBHAJGBNCO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct KBBBBONALOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public AGBINBDOCMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private EAIPOBMEIGP<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x84D3DD0", Offset = "0x84D2FD0", VA = "0x1884D3DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x84D4380", Offset = "0x84D3580", VA = "0x1884D4380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private EHKLKJJGGDO FKBGIHJJFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private MEBNIAGNGEK LLMBGPNPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private CAFJFKGMMAP LGIPFAFNFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private BCELOMMLBPF INOIIJHMAPA;

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x84C1D60", Offset = "0x84C0F60", VA = "0x1884C1D60", Slot = "6")]
	public void ILLMBOBOELN(MEBNIAGNGEK LLMBGPNPABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x84C1D10", Offset = "0x84C0F10", VA = "0x1884C1D10", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x84C1B50", Offset = "0x84C0D50", VA = "0x1884C1B50", Slot = "5")]
	[AsyncStateMachine(typeof(KBBBBONALOP))]
	public Task BOCMMCODOFC(string PJPBBAPADDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x84C1C50", Offset = "0x84C0E50", VA = "0x1884C1C50", Slot = "4")]
	public BAKFNEOFNEC CBOEBOKBMNC(KPDBONCIMNC EEODOEPMOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x84C2040", Offset = "0x84C1240", VA = "0x1884C2040")]
	private JDCCBOCKOJN KAJFBODJILO(string PJPBBAPADDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public AGBINBDOCMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class FKIKBILOOAM
{
	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x84CAEA0", Offset = "0x84CA0A0", VA = "0x1884CAEA0")]
	public static void CMBMCJNEEBH(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x84CB5F0", Offset = "0x84CA7F0", VA = "0x1884CB5F0")]
	internal static void OHGJBHOANGE(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x84CB0E0", Offset = "0x84CA2E0", VA = "0x1884CB0E0")]
	internal static void EDLDFLGKLHF(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x84CB1C0", Offset = "0x84CA3C0", VA = "0x1884CB1C0")]
	internal static void HJEEEGOABME(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x3804A60", Offset = "0x3803C60", VA = "0x183804A60")]
	private static void BPOIJHLPOKP<Interface, Impl, Interface>(HILJAABEPDC NPCDKJJJIDL) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class AFFJKEICBHI : AFPMIDKCBKN<CBMIKICCFNL>
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class EJOFDAIDCFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public CBMIKICCFNL message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public EJOFDAIDCFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x84C93F0", Offset = "0x84C85F0", VA = "0x1884C93F0")]
		internal object AFDMKMCEAOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly AFFJKEICBHI NDDGJHHDBNJ;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x84C12E0", Offset = "0x84C04E0", VA = "0x1884C12E0")]
	public ExitGames.Client.Photon.Hashtable CEBCPPBDNIB(CBMIKICCFNL BDAAPBJEHGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x84C1370", Offset = "0x84C0570", VA = "0x1884C1370", Slot = "5")]
	protected override void ELJDILDFPKE(CBMIKICCFNL BDAAPBJEHGD, IDictionary<object, object> DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x84C15B0", Offset = "0x84C07B0", VA = "0x1884C15B0", Slot = "6")]
	public override CBMIKICCFNL JKAINKAKBPB(IDictionary<object, object> DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x84C14A0", Offset = "0x84C06A0", VA = "0x1884C14A0")]
	private static void GCMHLHCLEDM(string KGAIOPMOPGF, CBMIKICCFNL BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x84C1B10", Offset = "0x84C0D10", VA = "0x1884C1B10")]
	public AFFJKEICBHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x84C17E0", Offset = "0x84C09E0", VA = "0x1884C17E0")]
	[CompilerGenerated]
	internal static string OJDFCFEOHHH(IAAJJFDJPDA MGEJNDCFBJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class AHEKMPLJKGJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static BAKFNEOFNEC KDJBHGKCOBM
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x84C2640", Offset = "0x84C1840", VA = "0x1884C2640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x84C2430", Offset = "0x84C1630", VA = "0x1884C2430")]
	public static bool IDAHCNKIDPF(this BAKFNEOFNEC IOEOAHLDCIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x84C2180", Offset = "0x84C1380", VA = "0x1884C2180")]
	public static BAKFNEOFNEC FBAMBOFLPKG(LIGHLHNEGBJ FFHCHELDDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x84C2450", Offset = "0x84C1650", VA = "0x1884C2450")]
	public static BAKFNEOFNEC JDABGLGGGLJ(IEnumerable<BAKFNEOFNEC> ELHFKCHPLFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x84C21E0", Offset = "0x84C13E0", VA = "0x1884C21E0")]
	public static string ICDOIDDHKNB(this BAKFNEOFNEC IGGKBIDIAJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public abstract class OEHAJMFFHDL : FOAIEFMKMKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public delegate BAKFNEOFNEC EBAPFEPHLGO([NotNull] KPDBONCIMNC MLPHHMINIJO);

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class HGJGGEEHCHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public KPDBONCIMNC photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public HGJGGEEHCHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x1573BE0", Offset = "0x1572DE0", VA = "0x181573BE0")]
		internal BAKFNEOFNEC KPELFOPPCGG(EBAPFEPHLGO v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	private bool KBCJGENOOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038E")]
	protected readonly HashSet<EBAPFEPHLGO> GMIMLCBDNOP;

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x84DAAD0", Offset = "0x84D9CD0", VA = "0x1884DAAD0", Slot = "4")]
	public void LJGGCBNMKLJ(EBAPFEPHLGO ACOBMPOJHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x84DAA20", Offset = "0x84D9C20", VA = "0x1884DAA20", Slot = "5")]
	public void CCEHFGMJGKL(EBAPFEPHLGO ACOBMPOJHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x84DAA80", Offset = "0x84D9C80", VA = "0x1884DAA80", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x84DAB30", Offset = "0x84D9D30", VA = "0x1884DAB30")]
	protected BAKFNEOFNEC OCMKKAMDGKM(KPDBONCIMNC MAGKLMEPFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x84DADC0", Offset = "0x84D9FC0", VA = "0x1884DADC0")]
	protected OEHAJMFFHDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public class NGPCEDNGBEK : OEHAJMFFHDL, PFIGMICDKCM, FOAIEFMKMKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class PKEFAALNODM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public BAKFNEOFNEC result;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PKEFAALNODM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x84DC100", Offset = "0x84DB300", VA = "0x1884DC100")]
		internal object JOCFCPPEECL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x84CD7B0", Offset = "0x84CC9B0", VA = "0x1884CD7B0")]
	[UnityEngine.Scripting.Preserve]
	public NGPCEDNGBEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x84D8C50", Offset = "0x84D7E50", VA = "0x1884D8C50", Slot = "8")]
	public BAKFNEOFNEC MJHBNMHLJGH(KPDBONCIMNC MAGKLMEPFAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class HDPLOJACOLJ : OEHAJMFFHDL, EHKLKJJGGDO, FOAIEFMKMKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class PCFDOEDFMAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public BAKFNEOFNEC result;

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PCFDOEDFMAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x84DBFC0", Offset = "0x84DB1C0", VA = "0x1884DBFC0")]
		internal object AEDJMCOBOIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x84CD7B0", Offset = "0x84CC9B0", VA = "0x1884CD7B0")]
	[UnityEngine.Scripting.Preserve]
	public HDPLOJACOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x84CD6A0", Offset = "0x84CC8A0", VA = "0x1884CD6A0", Slot = "8")]
	public BAKFNEOFNEC CBOEBOKBMNC(KPDBONCIMNC MHLIPNBBNLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal static class CJCFKEHMLIK
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class GOPEMPBFCCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public EAIPOBMEIGP<string> timer;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public GOPEMPBFCCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x84CD620", Offset = "0x84CC820", VA = "0x1884CD620")]
		internal object ENHHJCAFOIL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x84C5C90", Offset = "0x84C4E90", VA = "0x1884C5C90")]
	public static EAIPOBMEIGP<string> MLEDJOKDCKB(FODGIOKBGBI FHEIHFBIKLF, [Optional] string EMHIEHKFOKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x84C5BD0", Offset = "0x84C4DD0", VA = "0x1884C5BD0")]
	public static void LEFJKIKDJAO(EAIPOBMEIGP<string> AGHDGMNHDIP, FODGIOKBGBI FHEIHFBIKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x84C5D70", Offset = "0x84C4F70", VA = "0x1884C5D70")]
	public static string OIIADBEDHNJ(CBMIKICCFNL BHGDNHJGCCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal static class BKDPGFPMBBB
{
	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x84C3370", Offset = "0x84C2570", VA = "0x1884C3370")]
	public static void BLLPFHDHFFG(this LKDJDKEKNAC GCMEJOEAFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x84C34A0", Offset = "0x84C26A0", VA = "0x1884C34A0")]
	public static void IAHOGICHGDO(this LKDJDKEKNAC GCMEJOEAFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x84C3380", Offset = "0x84C2580", VA = "0x1884C3380")]
	private static void GPHIKFNKHDC(this LKDJDKEKNAC GCMEJOEAFHA, bool KJGKCEPFHCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class FNMICKDMLMI : OBKGJCEONDL, EFJACBMEPDD, NEHMOIAADDF, KGKHHAGNGBJ
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[DefaultMember("Item")]
	private class KFNNOCMIPPF : KOEIHCIJPPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private readonly byte DEBMEFDDEDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private readonly int NEGFBCIAAFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private readonly object KMKFGMNMCDG;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public byte EGKLDLJEOLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0xC8C5E0", Offset = "0xC8B7E0", VA = "0x180C8C5E0", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public int APNPGHGIJOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0xB834E0", Offset = "0xB826E0", VA = "0x180B834E0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public object IIPDAPMAFOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public object JCGKBEGFBHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x84D4450", Offset = "0x84D3650", VA = "0x1884D4450", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x76B0300", Offset = "0x76AF500", VA = "0x1876B0300")]
		public KFNNOCMIPPF(byte DEBMEFDDEDD, int NEGFBCIAAFG, object KMKFGMNMCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x84D44A0", Offset = "0x84D36A0", VA = "0x1884D44A0", Slot = "8")]
		public bool FLFGMEICIOC(byte AGBHGDFILGO, [Out] object MLCDCHNOCFI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	private readonly EFJACBMEPDD KLKJKHJLBFE;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public KPDBONCIMNC HJOKCGMKHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x84CBB50", Offset = "0x84CAD50", VA = "0x1884CBB50", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int MCMGOCKDHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x84CBF90", Offset = "0x84CB190", VA = "0x1884CBF90", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int JNHDLOEALMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x84CBC80", Offset = "0x84CAE80", VA = "0x1884CBC80", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public KPDBONCIMNC NIDMOCIHNNA
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x84CBD80", Offset = "0x84CAF80", VA = "0x1884CBD80", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool OPIIEEFNEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public int NFNNKKPFPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xBE2300", Offset = "0xBE1500", VA = "0x180BE2300", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public string KDCANANJGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x84CBA90", Offset = "0x84CAC90", VA = "0x1884CBA90", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Func<string, string> HMFODGIFDOL
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x84CB8F0", Offset = "0x84CAAF0", VA = "0x1884CB8F0", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action<string, long> NIJBOKCFOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event Action<KOEIHCIJPPL> KMIKHLKHFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x84CBCD0", Offset = "0x84CAED0", VA = "0x1884CBCD0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x84CB840", Offset = "0x84CAA40", VA = "0x1884CB840", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> CAKDMKMEACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "25")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "26")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<KPDBONCIMNC> EGLNBJMLJNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action EFCDPCDHJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x84CBBA0", Offset = "0x84CADA0", VA = "0x1884CBBA0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x84CB750", Offset = "0x84CA950", VA = "0x1884CB750", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xD26BB0", Offset = "0xD25DB0", VA = "0x180D26BB0")]
	public FNMICKDMLMI(EFJACBMEPDD KLKJKHJLBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x84CC080", Offset = "0x84CB280", VA = "0x1884CC080", Slot = "8")]
	public bool NFBGOKDBCJO(byte PIOPNFOBDGK, object IFOHHOCICOA, BKJLKPIDHCH OGDFOLOIAKB, NGFCECHAKNA KKKDIOFNONH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x84CBFE0", Offset = "0x84CB1E0", VA = "0x1884CBFE0", Slot = "19")]
	public KPDBONCIMNC NCPELPBKKKG(int OKKOLKBKJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x84CB9B0", Offset = "0x84CABB0", VA = "0x1884CB9B0", Slot = "20")]
	public KPDBONCIMNC DIHLLGENEIE(int JKLFDKBOKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x84CBDD0", Offset = "0x84CAFD0", VA = "0x1884CBDD0", Slot = "21")]
	public KPDBONCIMNC MBFOOMIECAO(int OKKOLKBKJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x84CBEB0", Offset = "0x84CB0B0", VA = "0x1884CBEB0", Slot = "22")]
	public IReadOnlyList<KPDBONCIMNC> MBMHELONHAA(bool HEPAGKNAEID = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x84CBC40", Offset = "0x84CAE40", VA = "0x1884CBC40", Slot = "23")]
	public IReadOnlyList<KPDBONCIMNC> HAGCCJFIMMJ(bool HEPAGKNAEID = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "24")]
	public bool MHIJFJDPACP(KPDBONCIMNC FKCJJGCDPAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "27")]
	public void KNCFOOEKFHA(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "28")]
	public void LAKLIOHEHKA(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "29")]
	public void AMGABCHDGGH(object PPOILDCNBFL, bool PJIDDMKIDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x84CB7F0", Offset = "0x84CA9F0", VA = "0x1884CB7F0", Slot = "30")]
	public IDisposable BONJNGDIBJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "31")]
	private bool MPGOFNODFJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "32")]
	public void LALGKGICNKK(StringBuilder FHEDDEPOGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0xF9A7F0", Offset = "0xF999F0", VA = "0x180F9A7F0", Slot = "33")]
	public bool FCICALEFKBC(bool GCELKBHPBFA, [Out] string KOIHEPAFBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0xF1DDA0", Offset = "0xF1CFA0", VA = "0x180F1DDA0", Slot = "36")]
	public void KNGCKIEOKMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal struct LLAGKKENMEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	private readonly IDictionary<object, object> ELJMGFIBFCP;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0xD42160", Offset = "0xD41360", VA = "0x180D42160")]
	public LLAGKKENMEI(IDictionary<object, object> ELJMGFIBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x84D7540", Offset = "0x84D6740", VA = "0x1884D7540")]
	public bool NGDICMPNAAL([Out] CBMIKICCFNL BDAAPBJEHGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x84D7490", Offset = "0x84D6690", VA = "0x1884D7490")]
	public Guid GPFEPIJMAEM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x84D7360", Offset = "0x84D6560", VA = "0x1884D7360")]
	public BAKFNEOFNEC FGNNALEBPGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x84D7270", Offset = "0x84D6470", VA = "0x1884D7270")]
	public static ExitGames.Client.Photon.Hashtable EAIFKKLDBGP(CBMIKICCFNL BDAAPBJEHGD, BAKFNEOFNEC IOEOAHLDCIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal static class GADEDHNIJCE
{
	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x84CC190", Offset = "0x84CB390", VA = "0x1884CC190")]
	public static bool NLEHFNNMHPG(this LDKIAIAGMBD MDLGPLHBALF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal struct DGJIAHJGPNK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct KIJMCFIGNDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public DGJIAHJGPNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x84D44F0", Offset = "0x84D36F0", VA = "0x1884D44F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x84D46D0", Offset = "0x84D38D0", VA = "0x1884D46D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	private readonly CancellationTokenSource BDMFGMOCHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400039D")]
	private bool KBCJGENOOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039E")]
	private Task LDLKICLCOAG;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool KJALJJOFOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x84C82A0", Offset = "0x84C74A0", VA = "0x1884C82A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x84C8430", Offset = "0x84C7630", VA = "0x1884C8430")]
	public DGJIAHJGPNK(CancellationToken HCELDNOKOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x84C8320", Offset = "0x84C7520", VA = "0x1884C8320")]
	[AsyncStateMachine(typeof(KIJMCFIGNDA))]
	public Task KIJPAHJPCDG(Func<CancellationToken, List<Task>> FKILGGAFOKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x84C82D0", Offset = "0x84C74D0", VA = "0x1884C82D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public readonly struct HMIMLCMIJEA<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct CMGONOPHFDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<PKKJJPIBJOL<TData>, DKPIACPJNCE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public HMIMLCMIJEA<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private TaskAwaiter<LOAMJJJEMNF<PKKJJPIBJOL<TData>, DKPIACPJNCE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x662F570", Offset = "0x662E770", VA = "0x18662F570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x562F210", Offset = "0x562E410", VA = "0x18562F210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private readonly FIMKINNJGKA<TGetDataArg, TData> MPDDJFAHINH;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0xD42160", Offset = "0xD41360", VA = "0x180D42160")]
	internal HMIMLCMIJEA(FIMKINNJGKA<TGetDataArg, TData> POLANHDJCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x4BAACF0", Offset = "0x4BA9EF0", VA = "0x184BAACF0")]
	[AsyncStateMachine(typeof(HMIMLCMIJEA<, >.CMGONOPHFDM))]
	public Task<LOAMJJJEMNF<PKKJJPIBJOL<TData>, DKPIACPJNCE>> EEEPFDHBFFJ(TGetDataArg HLMDGBFCIDH, string FHGKOLMMCBJ, EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class FNGJFKBCLKD
{
	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x36A0E10", Offset = "0x36A0010", VA = "0x1836A0E10")]
	public static HMIMLCMIJEA<TGetDataArg, TData> OIKMHICCLEP<TGetDataArg, TData>(FIMKINNJGKA<TGetDataArg, TData> POLANHDJCNH)
	{
		return default(HMIMLCMIJEA<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public struct PIFIONLEBIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public readonly int EGKLDLJEOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public readonly int? LDNIGIOAAEK;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x50A7790", Offset = "0x50A6990", VA = "0x1850A7790")]
	public PIFIONLEBIH(int DEBMEFDDEDD, [Optional] int? EHDOMFEIKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x84DC020", Offset = "0x84DB220", VA = "0x1884DC020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface LJAOCBBOGCF<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COEPELHOPGO();

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LJAOCBBOGCF<T> KGGPKGBJJDL(string JGBHCJABAIH);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LJAOCBBOGCF<T> EPMPHKANGMC(IKPMPKAJHPH<T> FIKCJMOLPJL);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LJAOCBBOGCF<T> PGALLIMJDOJ(int KNADPDIBGFF);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LJAOCBBOGCF<T> GOEEABDAENO(int KNADPDIBGFF, EDGGLJOBIBL<T> PGMCLOODIPF);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface NAEGGHPNDKJ
{
	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LJAOCBBOGCF<T> JOAHFNEHMGF<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GLFFIOHILOA KIAPPOBOBOB(Exception MJPFDOAJBLF);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PIFIONLEBIH LEIPNJAOMFJ(Exception MJPFDOAJBLF);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public delegate string IKPMPKAJHPH<in T>(T MJPFDOAJBLF) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public delegate int EDGGLJOBIBL<in T>(T MJPFDOAJBLF) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FC")]
internal class CALALBPIKIJ : NAEGGHPNDKJ
{
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private delegate string KDLIINHENGK(Exception MJPFDOAJBLF);

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private delegate int EELPKEHEHGB(Exception MJPFDOAJBLF);

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private class GMJIONNPMFJ<T> : LJAOCBBOGCF<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		[CompilerGenerated]
		private sealed class BMAIEDPOPDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public BMAIEDPOPDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			internal string OCIJEBDPECA(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class NBEIKAEECMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			public IKPMPKAJHPH<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public NBEIKAEECMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x53718C0", Offset = "0x5370AC0", VA = "0x1853718C0")]
			internal string ANNPKHIMOHK(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class OFFHADBKPCK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public EDGGLJOBIBL<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public OFFHADBKPCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x53718C0", Offset = "0x5370AC0", VA = "0x1853718C0")]
			internal int KJEOKONMLNN(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private readonly CALALBPIKIJ JLPILAGLHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private readonly Type GMAIPPOGEAP;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x4A99370", Offset = "0x4A98570", VA = "0x184A99370")]
		internal GMJIONNPMFJ(CALALBPIKIJ JLPILAGLHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x4A98F90", Offset = "0x4A98190", VA = "0x184A98F90", Slot = "4")]
		public void COEPELHOPGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x4A99210", Offset = "0x4A98410", VA = "0x184A99210", Slot = "5")]
		public LJAOCBBOGCF<T> KGGPKGBJJDL(string JGBHCJABAIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x4A98FC0", Offset = "0x4A981C0", VA = "0x184A98FC0", Slot = "6")]
		public LJAOCBBOGCF<T> EPMPHKANGMC(IKPMPKAJHPH<T> FIKCJMOLPJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x4A99330", Offset = "0x4A98530", VA = "0x184A99330", Slot = "7")]
		public LJAOCBBOGCF<T> PGALLIMJDOJ(int KNADPDIBGFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x4A990E0", Offset = "0x4A982E0", VA = "0x184A990E0", Slot = "8")]
		public LJAOCBBOGCF<T> GOEEABDAENO(int KNADPDIBGFF, EDGGLJOBIBL<T> PGMCLOODIPF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private class MACMHGCOOLC<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private bool POOJOAMONLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private readonly List<Type> KBMEHMNBBNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private readonly Dictionary<Type, TVal> FJEKCAPAMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private readonly Dictionary<Type, int> BKHEBMGKCMI;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public IReadOnlyList<Type> GIOBNKPHMKH
		{
			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x52C6B20", Offset = "0x52C5D20", VA = "0x1852C6B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x52C6F00", Offset = "0x52C6100", VA = "0x1852C6F00")]
		public MACMHGCOOLC(Dictionary<Type, int> BKHEBMGKCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x52C6D30", Offset = "0x52C5F30", VA = "0x1852C6D30")]
		public void OOLDDNFEGEK(Type AGBHGDFILGO, TVal KFEGNKODPFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x52C68F0", Offset = "0x52C5AF0", VA = "0x1852C68F0")]
		public bool DBFNPMCEBBC(Type GMAIPPOGEAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x52C6AD0", Offset = "0x52C5CD0", VA = "0x1852C6AD0")]
		public bool IFKALMBLEBM(TVal MLCDCHNOCFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x52C6A80", Offset = "0x52C5C80", VA = "0x1852C6A80")]
		public TVal HKFPFFCEPKK(Type EDLOHJEBKFM)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x52C6940", Offset = "0x52C5B40", VA = "0x1852C6940")]
		[CompilerGenerated]
		private int DHGOJLGIDIH(Type IHGDCJEKBGL, Type JNCAKHHPJDH)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private sealed class BBKKFJKFONK : IEnumerable<PIFIONLEBIH>, IEnumerable, IEnumerator<PIFIONLEBIH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private PIFIONLEBIH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public CALALBPIKIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private IEnumerator<PIFIONLEBIH> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private PIFIONLEBIH System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x45AFBE0", Offset = "0x45AEDE0", VA = "0x1845AFBE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PIFIONLEBIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0x84C2FD0", Offset = "0x84C21D0", VA = "0x1884C2FD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xE9E930", Offset = "0xE9DB30", VA = "0x180E9E930")]
		[DebuggerHidden]
		public BBKKFJKFONK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x84C3020", Offset = "0x84C2220", VA = "0x1884C3020", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x84C2A10", Offset = "0x84C1C10", VA = "0x1884C2A10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x84C2970", Offset = "0x84C1B70", VA = "0x1884C2970")]
		private void CKKMGPGLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x84C29C0", Offset = "0x84C1BC0", VA = "0x1884C29C0")]
		private void GCCIFBPGOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x84C2F80", Offset = "0x84C2180", VA = "0x1884C2F80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x84C2EC0", Offset = "0x84C20C0", VA = "0x1884C2EC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PIFIONLEBIH> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x84C2EC0", Offset = "0x84C20C0", VA = "0x1884C2EC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private static readonly PIFIONLEBIH KJJEPGEOAIP;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private static readonly Dictionary<Type, int> FLHPKDPKGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly HashSet<Type> GJIJICFHEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	private readonly MACMHGCOOLC<int> ELBCKKNKKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	private readonly MACMHGCOOLC<EELPKEHEHGB> LBHNPMLBEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	private readonly MACMHGCOOLC<KDLIINHENGK> IKNKGEJNJDL;

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x84C4CD0", Offset = "0x84C3ED0", VA = "0x1884C4CD0")]
	[DBIDCJGLKKO.BICJMLCNMCI.FCGHBDOAPKJ]
	internal static void NPCFNJKLMBL(HILJAABEPDC PHIACDDDGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x84C5830", Offset = "0x84C4A30", VA = "0x1884C5830")]
	[RecRoom.NoEngine.Common.Preserve]
	public CALALBPIKIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x3615CF0", Offset = "0x3614EF0", VA = "0x183615CF0", Slot = "4")]
	public LJAOCBBOGCF<T> JOAHFNEHMGF<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x84C49A0", Offset = "0x84C3BA0", VA = "0x1884C49A0", Slot = "5")]
	public GLFFIOHILOA KIAPPOBOBOB(Exception MJPFDOAJBLF)
	{
		return default(GLFFIOHILOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x84C4A30", Offset = "0x84C3C30", VA = "0x1884C4A30", Slot = "6")]
	public PIFIONLEBIH LEIPNJAOMFJ(Exception? MJPFDOAJBLF)
	{
		return default(PIFIONLEBIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x84C4C30", Offset = "0x84C3E30", VA = "0x1884C4C30", Slot = "7")]
	[IteratorStateMachine(typeof(BBKKFJKFONK))]
	public IEnumerable<PIFIONLEBIH> MLLFGGKLFEJ(Exception MJPFDOAJBLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x84C53C0", Offset = "0x84C45C0", VA = "0x1884C53C0", Slot = "8")]
	public string PEOGICJGNFM(Exception? MJPFDOAJBLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x84C4450", Offset = "0x84C3650", VA = "0x1884C4450")]
	private string DCMPPOBHGKA(AggregateException IAMBIJCJEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x84C5010", Offset = "0x84C4210", VA = "0x1884C5010")]
	private void OPGDNEBPLCO(Type GMAIPPOGEAP, int KNADPDIBGFF, EELPKEHEHGB? EJFPIFCLIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x84C4750", Offset = "0x84C3950", VA = "0x1884C4750")]
	private void EAGAOMBODGK(Type GMAIPPOGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x84C4D40", Offset = "0x84C3F40", VA = "0x1884C4D40")]
	private void OBLKMLDOKAP(Type GMAIPPOGEAP, KDLIINHENGK CBCJKAMEHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x84C55F0", Offset = "0x84C47F0", VA = "0x1884C55F0")]
	private static int PLFLJBEAAII(Type GMAIPPOGEAP, Dictionary<Type, int> BKHEBMGKCMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x36158E0", Offset = "0x3614AE0", VA = "0x1836158E0")]
	private static bool DDNMGPCLAMB<TVal>(MACMHGCOOLC<TVal> CPMBLPBIGIH, Type GMAIPPOGEAP, [Out] TVal MLCDCHNOCFI) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x84C5510", Offset = "0x84C4710", VA = "0x1884C5510")]
	[CompilerGenerated]
	internal static int PJAPPIIJNAE(Type PPLIOLOMNJF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public struct GLFFIOHILOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public readonly PIFIONLEBIH EDIHBCCGMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public readonly string CEJABMDOFBG;

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x84CC950", Offset = "0x84CBB50", VA = "0x1884CC950")]
	public GLFFIOHILOA(string PMGDMEJNEPF, PIFIONLEBIH KNADPDIBGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x84CC8B0", Offset = "0x84CBAB0", VA = "0x1884CC8B0")]
	public string PLANIHACOGD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public class MHBBONFJJIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	private readonly GGLODBMJCPL EGEMPDINIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	private string HFOLDEPFBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private long? FNLFMAOLDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	private long? EJOLINOMAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private long? LHEGDECCDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private string LAFAGLFJMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private MBBDNOCBHIC ADMFLGDLHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private long? EMEEJHAPGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private bool CDBMCNBLKLN;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public string IKDEAFABMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public long HAJIAMPIPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x84D86F0", Offset = "0x84D78F0", VA = "0x1884D86F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public long CBBMKKFJEFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x84D7920", Offset = "0x84D6B20", VA = "0x1884D7920")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public long PBFBDILDGBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x84D81B0", Offset = "0x84D73B0", VA = "0x1884D81B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string GGANJGLBIBO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x84D86B0", Offset = "0x84D78B0", VA = "0x1884D86B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public MBBDNOCBHIC GKKGBMBCGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xD863B0", Offset = "0xD855B0", VA = "0x180D863B0")]
		get
		{
			return default(MBBDNOCBHIC);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x84D7E70", Offset = "0x84D7070", VA = "0x1884D7E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public long NIAEAPIFMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x84D7E10", Offset = "0x84D7010", VA = "0x1884D7E10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x84D8750", Offset = "0x84D7950", VA = "0x1884D8750")]
	[UnityEngine.Scripting.Preserve]
	public MHBBONFJJIK([ALHAHLCGLLK(null)] GGLODBMJCPL EGEMPDINIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x84D7F60", Offset = "0x84D7160", VA = "0x1884D7F60")]
	private void HFGBPAFEGMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x84D7980", Offset = "0x84D6B80", VA = "0x1884D7980")]
	public void AKCOKEFCJDP(long BENLNHBBIME, long DLHGMNACNGF, [Optional] long? GKDHCJGNLGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x84D8610", Offset = "0x84D7810", VA = "0x1884D8610")]
	public void MCBDPCDHAJG(long GKDHCJGNLGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x84D8590", Offset = "0x84D7790", VA = "0x1884D8590")]
	public void LCPLGJAFMLA(string JNLIDFAFPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x84D8210", Offset = "0x84D7410", VA = "0x1884D8210")]
	public void IGPPIFENDCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
internal class FBMKMKEAMFG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct JGLJMHCIKED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public AsyncTaskMethodBuilder<CBMIKICCFNL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public CBMIKICCFNL roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public FBMKMKEAMFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private TaskAwaiter<KFHGIGIDJID.HDBLPNMPBHJ<CBMIKICCFNL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x84D3820", Offset = "0x84D2A20", VA = "0x1884D3820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x84D3D60", Offset = "0x84D2F60", VA = "0x1884D3D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct PFJAEJGNLPG<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private sealed class MDJPKDPNFGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public CBMIKICCFNL roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MDJPKDPNFGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x84D7840", Offset = "0x84D6A40", VA = "0x1884D7840")]
		internal CBMIKICCFNL NLIBLOCFNGF(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct EDBKCGAIMEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder<KFHGIGIDJID.HDBLPNMPBHJ<CBMIKICCFNL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public CBMIKICCFNL roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public FBMKMKEAMFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private BOCIKMOFFGJ <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private TaskAwaiter<KFHGIGIDJID.HDBLPNMPBHJ<CBMIKICCFNL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x84C8D70", Offset = "0x84C7F70", VA = "0x1884C8D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x84C9380", Offset = "0x84C8580", VA = "0x1884C9380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct DJJPPIAFAOM<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public FBMKMKEAMFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A28870", Offset = "0x6A27A70", VA = "0x186A28870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x562F210", Offset = "0x562E410", VA = "0x18562F210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct LBBMFEEBBDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public FBMKMKEAMFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x84D57A0", Offset = "0x84D49A0", VA = "0x1884D57A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x84D5A80", Offset = "0x84D4C80", VA = "0x1884D5A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class CNCIJDAMLKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CNCIJDAMLKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x84C5FB0", Offset = "0x84C51B0", VA = "0x1884C5FB0")]
		internal object IOHJMMNKGLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x84C5EF0", Offset = "0x84C50F0", VA = "0x1884C5EF0")]
		internal bool BODLGGIELIL(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class JFLHBJFBOPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public JFLHBJFBOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x84D37C0", Offset = "0x84D29C0", VA = "0x1884D37C0")]
		internal object KMNMOEJLKOL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class JCEIINGCLEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public JCEIINGCLEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x84D1960", Offset = "0x84D0B60", VA = "0x1884D1960")]
		internal object OILOHAOMCBE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class PABFMMCJOLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PABFMMCJOLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x84DBD00", Offset = "0x84DAF00", VA = "0x1884DBD00")]
		internal object KCDCGPIACLN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class JBPLLHBJMIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public FBMKMKEAMFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public JBPLLHBJMIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x84D1720", Offset = "0x84D0920", VA = "0x1884D1720")]
		internal object AFDMKMCEAOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private static readonly Guid MPHJMFFIJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public readonly GLOBKHNLMMN CNGNBGINFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private readonly KFHGIGIDJID DIPCFLLAADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private readonly NEHMOIAADDF GCMEJOEAFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	private readonly KGKHHAGNGBJ HHGHNHBNBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	private bool IAJLJIEBMKP;

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x84CAA70", Offset = "0x84C9C70", VA = "0x1884CAA70")]
	public FBMKMKEAMFG(GLOBKHNLMMN AFMEMNMIOCM, KFHGIGIDJID DIPCFLLAADD, NEHMOIAADDF GCMEJOEAFHA, KGKHHAGNGBJ HHGHNHBNBIP, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x84C9D70", Offset = "0x84C8F70", VA = "0x1884C9D70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x84CA770", Offset = "0x84C9970", VA = "0x1884CA770")]
	public void MHDANHBHLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x84CA180", Offset = "0x84C9380", VA = "0x1884CA180")]
	public void GPIGLEOMHIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x84CA630", Offset = "0x84C9830", VA = "0x1884CA630")]
	public void LGMKALNEIBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x84CA4D0", Offset = "0x84C96D0", VA = "0x1884CA4D0")]
	[AsyncStateMachine(typeof(JGLJMHCIKED))]
	internal Task<CBMIKICCFNL> LGFNLKNNBGO(EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CBMIKICCFNL BHGDNHJGCCJ, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x37F3C60", Offset = "0x37F2E60", VA = "0x1837F3C60")]
	private static byte[] PCIGEADHBJK<T>(T BDAAPBJEHGD) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x37F3C70", Offset = "0x37F2E70", VA = "0x1837F3C70")]
	private static T PFIHNHCGCMG<T>(MessageParser<T> GNCOBDAAGBC, byte[] BDAAPBJEHGD, T FBLJGIIDEPF) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x84C9D80", Offset = "0x84C8F80", VA = "0x1884C9D80")]
	[AsyncStateMachine(typeof(EDBKCGAIMEF))]
	private Task<KFHGIGIDJID.HDBLPNMPBHJ<CBMIKICCFNL>> ECKIKICBJCF(CBMIKICCFNL BHGDNHJGCCJ, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x37F39C0", Offset = "0x37F2BC0", VA = "0x1837F39C0")]
	[AsyncStateMachine(typeof(DJJPPIAFAOM<>))]
	internal Task<T> KFOEPDBIHHH<T>(CancellationToken DMKDGAIEPFB, Func<CancellationToken, Task<T>> HLLFNNAAIJD, int FNCDCCBCKOM = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x84CA3A0", Offset = "0x84C95A0", VA = "0x1884CA3A0")]
	[AsyncStateMachine(typeof(LBBMFEEBBDD))]
	internal Task KFOEPDBIHHH(CancellationToken DMKDGAIEPFB, Func<CancellationToken, Task> HLLFNNAAIJD, int FNCDCCBCKOM = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x84CA6F0", Offset = "0x84C98F0", VA = "0x1884CA6F0")]
	public IBMCGJPPEGL LLGNJLBAMLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x84C9FF0", Offset = "0x84C91F0", VA = "0x1884C9FF0")]
	public DDLDEFLOBDG FGJNJOEEDPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x84C9890", Offset = "0x84C8A90", VA = "0x1884C9890")]
	public IFGFBHAGDOE AJKLEHGHCBI([Optional] FODGIOKBGBI? FHEIHFBIKLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x84C9C10", Offset = "0x84C8E10", VA = "0x1884C9C10")]
	public void CMECBGIOCKF(Func<Guid, bool> KKMMGICHIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x84CA240", Offset = "0x84C9440", VA = "0x1884CA240")]
	public void IGOCONIJILB(Func<Guid, bool> NBMEGGDHHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x84CA890", Offset = "0x84C9A90", VA = "0x1884CA890")]
	public Guid OGBGMODGACC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x84C9B00", Offset = "0x84C8D00", VA = "0x1884C9B00")]
	public void CFIHAIHKHKP(Guid LOKMKCNFKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x84C9EC0", Offset = "0x84C90C0", VA = "0x1884C9EC0")]
	public void FAMCNIIPJMJ(CBMIKICCFNL JLEGOMLIBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x84CA070", Offset = "0x84C9270", VA = "0x1884CA070")]
	public void GCMHLHCLEDM(string NLKLPAAEIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x37F3DC0", Offset = "0x37F2FC0", VA = "0x1837F3DC0")]
	private T PHHPHPCMCNO<T>(T MLCDCHNOCFI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x84CA350", Offset = "0x84C9550", VA = "0x1884CA350")]
	public void KCLDFAGPLDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x37F3720", Offset = "0x37F2920", VA = "0x1837F3720")]
	[CompilerGenerated]
	internal static string CEKEFAADHPB<T>(byte[] FONJAIMABAP, int JKMHCAHCOEF, PFJAEJGNLPG<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal sealed class ILHBIKFEOJL : GLOBKHNLMMN
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class KFNMKFKPOAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KFNMKFKPOAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x84D43E0", Offset = "0x84D35E0", VA = "0x1884D43E0")]
		internal object MLBJPLDJHGA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct BLNMPNOPIHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public ILHBIKFEOJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public FBMKMKEAMFG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private GGCHOPOFBKB <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private DDLDEFLOBDG <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x84C34B0", Offset = "0x84C26B0", VA = "0x1884C34B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x84C3E00", Offset = "0x84C3000", VA = "0x1884C3E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct OMIEDFCHCNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public ILHBIKFEOJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private TaskAwaiter<JKGEOIDCPBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x84DB450", Offset = "0x84DA650", VA = "0x1884DB450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x84DBB80", Offset = "0x84DAD80", VA = "0x1884DBB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct MIPLAGIDDPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public ILHBIKFEOJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private TaskAwaiter<IACGOJIMLMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x84D8790", Offset = "0x84D7990", VA = "0x1884D8790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x84D8AA0", Offset = "0x84D7CA0", VA = "0x1884D8AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class OEHACFLDEMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public GGCHOPOFBKB presence;

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public OEHACFLDEMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x84DA8E0", Offset = "0x84D9AE0", VA = "0x1884DA8E0")]
		internal object HPCPPCKIKAO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	private static readonly FODGIOKBGBI JFIAIMAKOFF;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private static readonly FODGIOKBGBI HDKNJGJNKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private readonly IAAJJFDJPDA JMGILABOBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly LDKIAIAGMBD FPACIHKBLHL;

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x84D07E0", Offset = "0x84CF9E0", VA = "0x1884D07E0")]
	public ILHBIKFEOJL(IAAJJFDJPDA JMGILABOBNI, LDKIAIAGMBD FPACIHKBLHL, Guid BOAAABDJCPH, MEBNIAGNGEK LLMBGPNPABD, IHKEKBDONBN LPLPCKAJLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x84D0400", Offset = "0x84CF600", VA = "0x1884D0400", Slot = "7")]
	[AsyncStateMachine(typeof(BLNMPNOPIHK))]
	protected override Task MHHMELONGOE(FBMKMKEAMFG DFANBODNJBB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x84D0300", Offset = "0x84CF500", VA = "0x1884D0300")]
	[AsyncStateMachine(typeof(OMIEDFCHCNN))]
	private Task MBJOHGHFKNB(CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x84D01F0", Offset = "0x84CF3F0", VA = "0x1884D01F0")]
	[AsyncStateMachine(typeof(MIPLAGIDDPC))]
	private Task<int> EMBEFKMODPF(CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x84D0540", Offset = "0x84CF740", VA = "0x1884D0540")]
	private GGCHOPOFBKB PHOAAOPHFGC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal class PAIGJFEOFBG : GLOBKHNLMMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct JDCFNLNGGKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public PAIGJFEOFBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public FBMKMKEAMFG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private TaskAwaiter<PDHIEPEKDIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x84D2DB0", Offset = "0x84D1FB0", VA = "0x1884D2DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x84D3760", Offset = "0x84D2960", VA = "0x1884D3760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private readonly int HAKIEJGJADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private readonly LDMGLHEANGA HGIBJDOBNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public readonly long IDAIGHAHCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public readonly long AOCDNIIDIAE;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public PDHIEPEKDIL JNFDLIMFJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x9F9460", Offset = "0x9F8660", VA = "0x1809F9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x9F94A0", Offset = "0x9F86A0", VA = "0x1809F94A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x84DBE90", Offset = "0x84DB090", VA = "0x1884DBE90")]
	public PAIGJFEOFBG(Guid BOAAABDJCPH, MEBNIAGNGEK LLMBGPNPABD, IHKEKBDONBN LPLPCKAJLBM, int HAKIEJGJADE, LDMGLHEANGA HGIBJDOBNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x84DBD70", Offset = "0x84DAF70", VA = "0x1884DBD70", Slot = "7")]
	[AsyncStateMachine(typeof(JDCFNLNGGKO))]
	protected override Task MHHMELONGOE(FBMKMKEAMFG DFANBODNJBB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal abstract class ALJKNEPOOBD : GLOBKHNLMMN
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class NKNJCGNJFMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public ALJKNEPOOBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public ADOIDAHHKJO playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public NKNJCGNJFMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x84D8DF0", Offset = "0x84D7FF0", VA = "0x1884D8DF0")]
		internal Task PAAPELAPGCC(EAIPOBMEIGP<string>.MNKIBAEKPMC postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x84D8D60", Offset = "0x84D7F60", VA = "0x1884D8D60")]
		internal object LCAHCHLNMNM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private struct HHOCENEPAMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public ALJKNEPOOBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public FBMKMKEAMFG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private NKNJCGNJFMC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x84CD7C0", Offset = "0x84CC9C0", VA = "0x1884CD7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x84CDF90", Offset = "0x84CD190", VA = "0x1884CDF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct HOICHCFMFFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public ADOIDAHHKJO playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public ALJKNEPOOBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x84CF420", Offset = "0x84CE620", VA = "0x1884CF420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x84CF9D0", Offset = "0x84CEBD0", VA = "0x1884CF9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x84C2920", Offset = "0x84C1B20", VA = "0x1884C2920")]
	public ALJKNEPOOBD(Guid BOAAABDJCPH, MEBNIAGNGEK LLMBGPNPABD, IHKEKBDONBN LPLPCKAJLBM, string HANLGOGCPAL, OLELLGCFNAL LCIBBKGCJFA, bool HDGMFPDOGAG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x84C27E0", Offset = "0x84C19E0", VA = "0x1884C27E0", Slot = "7")]
	[AsyncStateMachine(typeof(HHOCENEPAMI))]
	protected override Task MHHMELONGOE(FBMKMKEAMFG DFANBODNJBB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task GEEKPFPKBGK(FBMKMKEAMFG DFANBODNJBB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x84C26A0", Offset = "0x84C18A0", VA = "0x1884C26A0")]
	[AsyncStateMachine(typeof(HOICHCFMFFP))]
	private Task LPLFJOMDBIN(IDisposable FJCDLBGAAOD, ADOIDAHHKJO GLHBPJHHFIA, EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal class EBABNBNAJNN : GLOBKHNLMMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct BNFAKBHBFBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public EBABNBNAJNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public FBMKMKEAMFG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private TaskAwaiter<NOBGLNGJEOC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x84C3E60", Offset = "0x84C3060", VA = "0x1884C3E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x84C43F0", Offset = "0x84C35F0", VA = "0x1884C43F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private readonly KMPELHDOPPN MNDHCACEDBN;

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x84C8CD0", Offset = "0x84C7ED0", VA = "0x1884C8CD0")]
	public EBABNBNAJNN(Guid BOAAABDJCPH, MEBNIAGNGEK LLMBGPNPABD, IHKEKBDONBN LPLPCKAJLBM, KMPELHDOPPN MNDHCACEDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x84C8BF0", Offset = "0x84C7DF0", VA = "0x1884C8BF0", Slot = "6")]
	protected override string NAIDPLJCIBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x84C8AD0", Offset = "0x84C7CD0", VA = "0x1884C8AD0", Slot = "7")]
	[AsyncStateMachine(typeof(BNFAKBHBFBP))]
	protected override Task MHHMELONGOE(FBMKMKEAMFG DFANBODNJBB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal abstract class GLOBKHNLMMN : LIJKHOFENFD
{
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public delegate Task FAMCAAELJJE(EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private sealed class HNJNDGCGEIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public GLOBKHNLMMN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public HNJNDGCGEIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x84CF2F0", Offset = "0x84CE4F0", VA = "0x1884CF2F0")]
		internal Task KNJJIMFDLDA(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class CKIJKHACBJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public HNJNDGCGEIL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CKIJKHACBJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x84C5E30", Offset = "0x84C5030", VA = "0x1884C5E30")]
		internal object DHAJJJFBJLL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct JCMKIILDNBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public GLOBKHNLMMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public Func<GLOBKHNLMMN, EAIPOBMEIGP<string>.MNKIBAEKPMC, FBMKMKEAMFG> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private HNJNDGCGEIL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private FBMKMKEAMFG <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private TaskAwaiter<CBMIKICCFNL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x84D19D0", Offset = "0x84D0BD0", VA = "0x1884D19D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x84D2B90", Offset = "0x84D1D90", VA = "0x1884D2B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct KIKKEFFLPPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x84D4730", Offset = "0x84D3930", VA = "0x1884D4730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x84D51D0", Offset = "0x84D43D0", VA = "0x1884D51D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct HICOLMBOEGF : IAsyncStateMachine
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
		public GLOBKHNLMMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x84CDFF0", Offset = "0x84CD1F0", VA = "0x1884CDFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x84CE350", Offset = "0x84CD550", VA = "0x1884CE350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public readonly Guid MKPBDMFKODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public readonly ByteString JKMPIFFJLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public readonly IHKEKBDONBN LOJAOGLICPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	protected readonly string DJEDFPDABOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private readonly MEBNIAGNGEK LLMBGPNPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private readonly bool HDGMFPDOGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private readonly Queue<FAMCAAELJJE> LEKEAOODOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private readonly NPIJPEFDCBH EBFDIIBPDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private readonly OLELLGCFNAL LCIBBKGCJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private bool NOHOKEAEDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public MBBDNOCBHIC GCJOOBHEKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public MBBDNOCBHIC AGNIONLOKNA;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public MEBNIAGNGEK DDEKMBOMGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public LAMEDCHOMHL LMBINNBIMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x84CCEB0", Offset = "0x84CC0B0", VA = "0x1884CCEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public KBHPCHHAFMJ LDJLFEGHNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x84CCB70", Offset = "0x84CBD70", VA = "0x1884CCB70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public MOALAMGIMLB LHDJPHOLKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x84CCE30", Offset = "0x84CC030", VA = "0x1884CCE30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event HOBIDMFELEB HBIIFHAAGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x84CCB50", Offset = "0x84CBD50", VA = "0x1884CCB50", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x84CCE10", Offset = "0x84CC010", VA = "0x1884CCE10", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x84CD4C0", Offset = "0x84CC6C0", VA = "0x1884CD4C0")]
	protected GLOBKHNLMMN(Guid BOAAABDJCPH, MEBNIAGNGEK LLMBGPNPABD, IHKEKBDONBN LPLPCKAJLBM, string HANLGOGCPAL, OLELLGCFNAL LCIBBKGCJFA, bool HDGMFPDOGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x84CD400", Offset = "0x84CC600", VA = "0x1884CD400", Slot = "6")]
	protected virtual string NAIDPLJCIBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x84CCAF0", Offset = "0x84CBCF0", VA = "0x1884CCAF0")]
	public void CPNCOBMEEIB(FAMCAAELJJE PNMMBEAJIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x84CD1A0", Offset = "0x84CC3A0", VA = "0x1884CD1A0")]
	protected void LGLKKLDNKMF(float OJJILHCFMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x84CD2B0", Offset = "0x84CC4B0", VA = "0x1884CD2B0")]
	[AsyncStateMachine(typeof(JCMKIILDNBG))]
	public Task MENHHIHEOIL(CancellationToken HCELDNOKOAM, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, [Optional] Func<GLOBKHNLMMN, EAIPOBMEIGP<string>.MNKIBAEKPMC, FBMKMKEAMFG> KIFHIKKJEAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x84CCBC0", Offset = "0x84CBDC0", VA = "0x1884CCBC0")]
	[AsyncStateMachine(typeof(KIKKEFFLPPB))]
	private static Task FAIJOGGNEOD(Func<CancellationToken, Task> ACDJNHBCKDI, Func<CancellationToken, Task> KAHLAFJDFCB, CancellationToken DMKDGAIEPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x84CC970", Offset = "0x84CBB70", VA = "0x1884CC970")]
	private void CODAJNAANFO(bool MAEMMABLBFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x84CCF00", Offset = "0x84CC100", VA = "0x1884CCF00")]
	private void JINIEOJLKKH(FBMKMKEAMFG DFANBODNJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task MHHMELONGOE(FBMKMKEAMFG DFANBODNJBB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x84CCCF0", Offset = "0x84CBEF0", VA = "0x1884CCCF0")]
	[AsyncStateMachine(typeof(HICOLMBOEGF))]
	private Task FEIFJGLLJEN(EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x84CD440", Offset = "0x84CC640", VA = "0x1884CD440")]
	public CBMIKICCFNL PNHFAIELHGK(BOCIKMOFFGJ BBDHHGPGCNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x84CD1C0", Offset = "0x84CC3C0", VA = "0x1884CD1C0")]
	[CompilerGenerated]
	private Task MCLAMEJHNGD(CancellationToken PNIEJJKFCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x84CD120", Offset = "0x84CC320", VA = "0x1884CD120")]
	[CompilerGenerated]
	private object KMFKEPKLHBA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
internal sealed class FEIFCFFMBMH : ALJKNEPOOBD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct IHHNCIOCNFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public FEIFCFFMBMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public FBMKMKEAMFG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private DBJKOHCNHMF <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private DDLDEFLOBDG <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x84CFA30", Offset = "0x84CEC30", VA = "0x1884CFA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x84D0190", Offset = "0x84CF390", VA = "0x1884D0190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	private readonly IAAJJFDJPDA GAGFOJCNCAE;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x84CADF0", Offset = "0x84C9FF0", VA = "0x1884CADF0")]
	public FEIFCFFMBMH(Guid BOAAABDJCPH, MEBNIAGNGEK LLMBGPNPABD, IAAJJFDJPDA GAGFOJCNCAE, IHKEKBDONBN LPLPCKAJLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x84CACA0", Offset = "0x84C9EA0", VA = "0x1884CACA0", Slot = "8")]
	[AsyncStateMachine(typeof(IHHNCIOCNFG))]
	protected override Task GEEKPFPKBGK(FBMKMKEAMFG DFANBODNJBB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal class JDCCBOCKOJN : GLOBKHNLMMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct DDHOOJGLDJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public JDCCBOCKOJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public FBMKMKEAMFG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private TaskAwaiter<NOBGLNGJEOC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x84C6010", Offset = "0x84C5210", VA = "0x1884C6010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x84C63C0", Offset = "0x84C55C0", VA = "0x1884C63C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private readonly string BJOPJMLCFCA;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x84D2D00", Offset = "0x84D1F00", VA = "0x1884D2D00")]
	public JDCCBOCKOJN(Guid BOAAABDJCPH, MEBNIAGNGEK LLMBGPNPABD, IHKEKBDONBN LPLPCKAJLBM, string BJOPJMLCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x84D2BF0", Offset = "0x84D1DF0", VA = "0x1884D2BF0", Slot = "7")]
	[AsyncStateMachine(typeof(DDHOOJGLDJE))]
	protected override Task MHHMELONGOE(FBMKMKEAMFG DFANBODNJBB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal class DINNBKBABMD : ALJKNEPOOBD
{
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class ONLLNLFLKOI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			public AsyncTaskMethodBuilder<CBMIKICCFNL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			public ONLLNLFLKOI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			private TaskAwaiter<NOBGLNGJEOC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			private TaskAwaiter<CBMIKICCFNL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0x84DD0B0", Offset = "0x84DC2B0", VA = "0x1884DD0B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0x84DD5A0", Offset = "0x84DC7A0", VA = "0x1884DD5A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public DINNBKBABMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public IFGFBHAGDOE serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public EGJEOIABGDI roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public IBMCGJPPEGL uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public OEKDMCDJKCL roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ONLLNLFLKOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x84DBBE0", Offset = "0x84DADE0", VA = "0x1884DBBE0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<CBMIKICCFNL> BMGKCIBJHCO(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct HIJNLLDKDAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public DINNBKBABMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public FBMKMKEAMFG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private ONLLNLFLKOI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private DBJKOHCNHMF <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private DDLDEFLOBDG <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private CBMIKICCFNL <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private TaskAwaiter<CBMIKICCFNL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x84CE3B0", Offset = "0x84CD5B0", VA = "0x1884CE3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x84CF290", Offset = "0x84CE490", VA = "0x1884CF290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private static readonly FODGIOKBGBI JFIAIMAKOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private readonly int FBJJKIBIHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	[CanBeNull]
	private readonly AMCBFCIFFOH EBNNDHKBAPE;

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x84C8A20", Offset = "0x84C7C20", VA = "0x1884C8A20")]
	public DINNBKBABMD(Guid BOAAABDJCPH, MEBNIAGNGEK LLMBGPNPABD, int FBJJKIBIHMG, AMCBFCIFFOH EBNNDHKBAPE, IHKEKBDONBN LPLPCKAJLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x84C8560", Offset = "0x84C7760", VA = "0x1884C8560", Slot = "8")]
	[AsyncStateMachine(typeof(HIJNLLDKDAM))]
	protected override Task GEEKPFPKBGK(FBMKMKEAMFG DFANBODNJBB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x84C86A0", Offset = "0x84C78A0", VA = "0x1884C86A0")]
	private void MMMKAMLDBIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x84C87A0", Offset = "0x84C79A0", VA = "0x1884C87A0")]
	private void NKLJKKAHHBN(EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, DBJKOHCNHMF JFHHMNEAJLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal class BJOPBEFMNLE : GLOBKHNLMMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct LIGFBLKDPBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public BJOPBEFMNLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private DBJKOHCNHMF <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private PAACHOBIIFN<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private TaskAwaiter<PDHIEPEKDIL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x84D60E0", Offset = "0x84D52E0", VA = "0x1884D60E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x84D7210", Offset = "0x84D6410", VA = "0x1884D7210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private readonly int FBJJKIBIHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	private readonly AMCBFCIFFOH EBNNDHKBAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private Func<NOBGLNGJEOC, NOBGLNGJEOC> NDNPCGCGOEI;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x84C32B0", Offset = "0x84C24B0", VA = "0x1884C32B0")]
	public BJOPBEFMNLE(Guid BOAAABDJCPH, MEBNIAGNGEK LLMBGPNPABD, int FBJJKIBIHMG, AMCBFCIFFOH EBNNDHKBAPE, Func<NOBGLNGJEOC, NOBGLNGJEOC> NDNPCGCGOEI, IHKEKBDONBN LPLPCKAJLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x84C3170", Offset = "0x84C2370", VA = "0x1884C3170", Slot = "7")]
	[AsyncStateMachine(typeof(LIGFBLKDPBD))]
	protected override Task MHHMELONGOE(FBMKMKEAMFG DFANBODNJBB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal abstract class LOCEDEEHOHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public readonly GLOBKHNLMMN CNGNBGINFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public readonly FBMKMKEAMFG GNLOLFNCDBF;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public LAMEDCHOMHL LMBINNBIMPB
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x84D7790", Offset = "0x84D6990", VA = "0x1884D7790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public MOALAMGIMLB LHDJPHOLKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x84D7700", Offset = "0x84D6900", VA = "0x1884D7700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x84D77E0", Offset = "0x84D69E0", VA = "0x1884D77E0")]
	protected LOCEDEEHOHE(FBMKMKEAMFG DFANBODNJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x84D75F0", Offset = "0x84D67F0", VA = "0x1884D75F0")]
	protected void GCMHLHCLEDM(string NLKLPAAEIMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal struct LHFJKMLIJBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public Dictionary<Guid, List<OFCBOOGBEMO>> HNBDMPELKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public Dictionary<Guid, List<OFCBOOGBEMO>> LJDLIBKONEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public Dictionary<Guid, List<OFCBOOGBEMO>> JAPIPOEIJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public List<Guid> IGKBOOAHDHC;

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x84D5AE0", Offset = "0x84D4CE0", VA = "0x1884D5AE0")]
	public static LHFJKMLIJBJ HKFPFFCEPKK(LAMEDCHOMHL OIONFMJBFHJ, MBBDNOCBHIC MMLJKLMFMIK, FIEDEFBCGNM GEEJDHPDEKD)
	{
		return default(LHFJKMLIJBJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct CHHPMMFJEJF
{
	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0")]
	public static CHHPMMFJEJF EAIFKKLDBGP()
	{
		return default(CHHPMMFJEJF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct MMKNLEBFHHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public readonly JKGEOIDCPBI GKCIPCHGLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public readonly LKOOIDABJPJ NBFHPABLEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public readonly Guid? LIPEAFABIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public readonly IReadOnlyCollection<PPPFLOFMGEF> FIFIFCJKBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public readonly IReadOnlyCollection<PPPFLOFMGEF> IJKFNPLGOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public readonly ELAGIFLJMJI ALDFCBINAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public readonly ELAGIFLJMJI OHFDGJIJNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public readonly HPNKLCGCBEM EEPHBGODAOC;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool FGKDDPNEKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x84D8B10", Offset = "0x84D7D10", VA = "0x1884D8B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x84D8BA0", Offset = "0x84D7DA0", VA = "0x1884D8BA0")]
	public MMKNLEBFHHO(JKGEOIDCPBI GKCIPCHGLOA, LKOOIDABJPJ NBFHPABLEIO, Guid? LIPEAFABIEA, IReadOnlyList<PPPFLOFMGEF> FIFIFCJKBDK, IReadOnlyCollection<PPPFLOFMGEF> IJKFNPLGOLJ, ELAGIFLJMJI ALDFCBINAND, ELAGIFLJMJI OHFDGJIJNKH, HPNKLCGCBEM EEPHBGODAOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct NPAKJDLDDJL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private readonly FBMKMKEAMFG DFANBODNJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private readonly Guid LOKMKCNFKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private bool MAEMMABLBFK;

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x84D95B0", Offset = "0x84D87B0", VA = "0x1884D95B0")]
	public static NPAKJDLDDJL OGBGMODGACC(FBMKMKEAMFG DFANBODNJBB)
	{
		return default(NPAKJDLDDJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x11D23C0", Offset = "0x11D15C0", VA = "0x1811D23C0")]
	public void FCKNNPAOLGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x84D9500", Offset = "0x84D8700", VA = "0x1884D9500", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x84D95E0", Offset = "0x84D87E0", VA = "0x1884D95E0")]
	private NPAKJDLDDJL(FBMKMKEAMFG DFANBODNJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x84D92D0", Offset = "0x84D84D0", VA = "0x1884D92D0")]
	private void CFIHAIHKHKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x84D9510", Offset = "0x84D8710", VA = "0x1884D9510")]
	private Func<Guid, bool> INJCDAPADGD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal class DDLDEFLOBDG : LOCEDEEHOHE, LIJKHOFENFD
{
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	public delegate Task<MBBDNOCBHIC> AEJKMMDFNOK(FIEDEFBCGNM DHAOEHNLNON, NPMEPDGKAFM HILPKKKJJON, NPIJPEFDCBH ENIJPHENPOB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct AAFBJNOPBKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public IAAJJFDJPDA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private NPAKJDLDDJL <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private TaskAwaiter<CBMIKICCFNL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x84C09B0", Offset = "0x84BFBB0", VA = "0x1884C09B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x84C1280", Offset = "0x84C0480", VA = "0x1884C1280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct NMDJIFGHJCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public AsyncTaskMethodBuilder<CBMIKICCFNL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public IAAJJFDJPDA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private TaskAwaiter<CBMIKICCFNL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x84D8E30", Offset = "0x84D8030", VA = "0x1884D8E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x84D9260", Offset = "0x84D8460", VA = "0x1884D9260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct GCECILEKMNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public IAAJJFDJPDA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x84CC210", Offset = "0x84CB410", VA = "0x1884CC210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x84CC850", Offset = "0x84CBA50", VA = "0x1884CC850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class KPJILEJHPLK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000142")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			public AsyncTaskMethodBuilder<MMKNLEBFHHO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			public KPJILEJHPLK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			private MMKNLEBFHHO <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004FC")]
			private TaskAwaiter<MBBDNOCBHIC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			private TaskAwaiter<MMKNLEBFHHO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x84DC160", Offset = "0x84DB360", VA = "0x1884DC160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x84DC950", Offset = "0x84DBB50", VA = "0x1884DC950", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000143")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004FF")]
			public AsyncTaskMethodBuilder<FIEDEFBCGNM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			public KPJILEJHPLK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			private FIEDEFBCGNM <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000503")]
			private TaskAwaiter<MBBDNOCBHIC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000504")]
			private TaskAwaiter<FIEDEFBCGNM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x84DC9C0", Offset = "0x84DBBC0", VA = "0x1884DC9C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x84DD040", Offset = "0x84DC240", VA = "0x1884DD040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public IAAJJFDJPDA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public NPIJPEFDCBH preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public NPIJPEFDCBH downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public MMKNLEBFHHO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public NPIJPEFDCBH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public FIEDEFBCGNM phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public BMDKIDJMNGN.MPGGFACLDBI <>9__5;

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KPJILEJHPLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x84D5650", Offset = "0x84D4850", VA = "0x1884D5650")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<MMKNLEBFHHO> JHDOFIAJHAF(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x84D5230", Offset = "0x84D4430", VA = "0x1884D5230")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<FIEDEFBCGNM> ACBJPJEEODM(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x84D5610", Offset = "0x84D4810", VA = "0x1884D5610")]
		internal void IOGCFMLGBML(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x84D5350", Offset = "0x84D4550", VA = "0x1884D5350")]
		internal Task EOLHHEJGPNP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x84D54B0", Offset = "0x84D46B0", VA = "0x1884D54B0")]
		internal Task FEHNLKLKOOO(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct ILHGJENCJGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public IAAJJFDJPDA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private KPJILEJHPLK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private TaskAwaiter<MMKNLEBFHHO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private TaskAwaiter<FIEDEFBCGNM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x84D0970", Offset = "0x84CFB70", VA = "0x1884D0970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x84D16C0", Offset = "0x84D08C0", VA = "0x1884D16C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct OBBFLDAMMMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public FIEDEFBCGNM phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public NPIJPEFDCBH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private TaskAwaiter<MBBDNOCBHIC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private NPMEPDGKAFM <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x84D9770", Offset = "0x84D8970", VA = "0x1884D9770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x84DA880", Offset = "0x84D9A80", VA = "0x1884DA880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct MMPOJIAELCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x84F02E0", Offset = "0x84EF4E0", VA = "0x1884F02E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x84F0AC0", Offset = "0x84EFCC0", VA = "0x1884F0AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct EJJGCMHJGJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public NPIJPEFDCBH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private TaskAwaiter<MBBDNOCBHIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x84E2BC0", Offset = "0x84E1DC0", VA = "0x1884E2BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x84E3400", Offset = "0x84E2600", VA = "0x1884E3400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct DDKHMCEDHML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public AsyncTaskMethodBuilder<MBBDNOCBHIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public NPIJPEFDCBH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private TaskAwaiter<MBBDNOCBHIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x84E1080", Offset = "0x84E0280", VA = "0x1884E1080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x84E2040", Offset = "0x84E1240", VA = "0x1884E2040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct NAAOENLGEOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public AsyncTaskMethodBuilder<MBBDNOCBHIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public NPIJPEFDCBH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public NPMEPDGKAFM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private TaskAwaiter<MBBDNOCBHIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x84F0B20", Offset = "0x84EFD20", VA = "0x1884F0B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x84F1C30", Offset = "0x84F0E30", VA = "0x1884F1C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct NMLJGKNKMJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public AsyncTaskMethodBuilder<MBBDNOCBHIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public MBBDNOCBHIC operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public NPIJPEFDCBH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public FIEDEFBCGNM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private TaskAwaiter<MBBDNOCBHIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x84F3360", Offset = "0x84F2560", VA = "0x1884F3360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x84F35B0", Offset = "0x84F27B0", VA = "0x1884F35B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class PMNENIPAFNO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014D")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			public AsyncTaskMethodBuilder<MBBDNOCBHIC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			public PMNENIPAFNO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			private AHAEBJLBPKA <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			private TaskAwaiter<MBBDNOCBHIC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C10", Offset = "0x84F4E10", VA = "0x1884F5C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x84F6230", Offset = "0x84F5430", VA = "0x1884F6230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public NPIJPEFDCBH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public AEJKMMDFNOK masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public NPMEPDGKAFM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public MBBDNOCBHIC originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PMNENIPAFNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x84F50E0", Offset = "0x84F42E0", VA = "0x1884F50E0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<MBBDNOCBHIC> CKOPIFBMIAL(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct JDFILHJLBGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public AsyncTaskMethodBuilder<MBBDNOCBHIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public NPIJPEFDCBH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public AEJKMMDFNOK masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public NPMEPDGKAFM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private TaskAwaiter<MBBDNOCBHIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x84E9FC0", Offset = "0x84E91C0", VA = "0x1884E9FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x84EA4E0", Offset = "0x84E96E0", VA = "0x1884EA4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct MFCCJPLHCLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public NPIJPEFDCBH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private MBBDNOCBHIC <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private IEnumerator<MBBDNOCBHIC> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private TaskAwaiter<MBBDNOCBHIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x84ED830", Offset = "0x84ECA30", VA = "0x1884ED830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x84EDD80", Offset = "0x84ECF80", VA = "0x1884EDD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct LBBCLNONELM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x84ECE10", Offset = "0x84EC010", VA = "0x1884ECE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x84ED100", Offset = "0x84EC300", VA = "0x1884ED100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct BBKGALJLEAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x84DEC10", Offset = "0x84DDE10", VA = "0x1884DEC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x84DEE30", Offset = "0x84DE030", VA = "0x1884DEE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class GNHLHHGKJEB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000153")]
		private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public AsyncTaskMethodBuilder<MBBDNOCBHIC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			public GNHLHHGKJEB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public FIEDEFBCGNM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			public NPIJPEFDCBH progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			private TaskAwaiter<MBBDNOCBHIC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			private TaskAwaiter<GCPJNNHNOAH> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x84F62A0", Offset = "0x84F54A0", VA = "0x1884F62A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x84F6D60", Offset = "0x84F5F60", VA = "0x1884F6D60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public ALCLNKJHOHL mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public GNHLHHGKJEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x84E6D50", Offset = "0x84E5F50", VA = "0x1884E6D50")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<MBBDNOCBHIC> DBKBILCEFLJ(FIEDEFBCGNM data, NPMEPDGKAFM _, NPIJPEFDCBH progressTracker, EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct MJHFCAKJDEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public FIEDEFBCGNM phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public NPIJPEFDCBH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private GNHLHHGKJEB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private NPMEPDGKAFM <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private TaskAwaiter<MBBDNOCBHIC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x84EF3B0", Offset = "0x84EE5B0", VA = "0x1884EF3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x84F0280", Offset = "0x84EF480", VA = "0x1884F0280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct JLOALBJCOGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x84EC0B0", Offset = "0x84EB2B0", VA = "0x1884EC0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x84EC4B0", Offset = "0x84EB6B0", VA = "0x1884EC4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct GEPGONDAGJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public AsyncTaskMethodBuilder<MBBDNOCBHIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public DDLDEFLOBDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public NPIJPEFDCBH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private TaskAwaiter<MBBDNOCBHIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x84E5D00", Offset = "0x84E4F00", VA = "0x1884E5D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x84E6320", Offset = "0x84E5520", VA = "0x1884E6320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private readonly AAILLPLJANG GALMNIBKAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private readonly AAILLPLJANG EKFEOKDFKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private readonly MHBBONFJJIK FCFPPCDHFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private readonly GPMDGOLEFJN BKNPNHLENFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private readonly LODMDPOOIJC HEHAGDBEOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private ProfilerCounterValue<int> DAGBLLFONKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private readonly EGOLNJDEEMP BLDCDDCJEDE;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private MEBNIAGNGEK DDEKMBOMGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x84C6F30", Offset = "0x84C6130", VA = "0x1884C6F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event HOBIDMFELEB HBIIFHAAGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x84C6B50", Offset = "0x84C5D50", VA = "0x1884C6B50", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x84C6BD0", Offset = "0x84C5DD0", VA = "0x1884C6BD0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x84C7FE0", Offset = "0x84C71E0", VA = "0x1884C7FE0")]
	public DDLDEFLOBDG(FBMKMKEAMFG DFANBODNJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x84C6760", Offset = "0x84C5960", VA = "0x1884C6760")]
	[AsyncStateMachine(typeof(AAFBJNOPBKP))]
	public Task DNEDIMANGIL(IAAJJFDJPDA MGALKMHOLCM, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x84C68B0", Offset = "0x84C5AB0", VA = "0x1884C68B0")]
	[AsyncStateMachine(typeof(NMDJIFGHJCM))]
	private Task<CBMIKICCFNL> DONPJCLGKOK(IAAJJFDJPDA MGALKMHOLCM, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x84C7160", Offset = "0x84C6360", VA = "0x1884C7160")]
	[AsyncStateMachine(typeof(GCECILEKMNI))]
	private Task JCOGBGMPDGP(IAAJJFDJPDA MGALKMHOLCM, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x84C6A10", Offset = "0x84C5C10", VA = "0x1884C6A10")]
	[AsyncStateMachine(typeof(ILHGJENCJGP))]
	private Task EANHBBKPNHK(IAAJJFDJPDA MGALKMHOLCM, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken AGALPFPFPHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x84C6420", Offset = "0x84C5620", VA = "0x1884C6420")]
	[AsyncStateMachine(typeof(OBBFLDAMMMJ))]
	private Task BFEDNIIKEBC(FIEDEFBCGNM MNIBCKMAPMJ, NPIJPEFDCBH PDNLJDPFGEN, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken CNECMHFFDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x84C6BF0", Offset = "0x84C5DF0", VA = "0x1884C6BF0")]
	[AsyncStateMachine(typeof(MMPOJIAELCD))]
	private Task FJHDGHGOGON(EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x84C77C0", Offset = "0x84C69C0", VA = "0x1884C77C0")]
	[AsyncStateMachine(typeof(EJJGCMHJGJO))]
	private Task LELPGOECLNB(FIEDEFBCGNM DHAOEHNLNON, NPIJPEFDCBH ENIJPHENPOB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x84C7CA0", Offset = "0x84C6EA0", VA = "0x1884C7CA0")]
	[AsyncStateMachine(typeof(DDKHMCEDHML))]
	private Task<MBBDNOCBHIC> NBBGPIPCNNK(FIEDEFBCGNM DHAOEHNLNON, NPMEPDGKAFM GCKDCNNODIF, NPIJPEFDCBH ENIJPHENPOB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x84C65E0", Offset = "0x84C57E0", VA = "0x1884C65E0")]
	[AsyncStateMachine(typeof(NAAOENLGEOE))]
	private Task<MBBDNOCBHIC> CMKBOMBBBBN(FIEDEFBCGNM DHAOEHNLNON, NPMEPDGKAFM GCKDCNNODIF, NPIJPEFDCBH ENIJPHENPOB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x84C6D00", Offset = "0x84C5F00", VA = "0x1884C6D00")]
	[AsyncStateMachine(typeof(NMLJGKNKMJO))]
	private Task<MBBDNOCBHIC> GANKLMOGAEG(MBBDNOCBHIC MMLJKLMFMIK, FIEDEFBCGNM GEEJDHPDEKD, NPIJPEFDCBH ENIJPHENPOB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM, bool CLBCBPCHNCF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x84C7510", Offset = "0x84C6710", VA = "0x1884C7510")]
	private bool KGPCIFNNCCP(FIEDEFBCGNM MNIBCKMAPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x84C6FD0", Offset = "0x84C61D0", VA = "0x1884C6FD0")]
	[AsyncStateMachine(typeof(JDFILHJLBGG))]
	protected Task<MBBDNOCBHIC> ILICOOKJMAF(FIEDEFBCGNM DHAOEHNLNON, NPMEPDGKAFM GCKDCNNODIF, NPIJPEFDCBH ENIJPHENPOB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM, AEJKMMDFNOK EBABIHHKIAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x84C7A10", Offset = "0x84C6C10", VA = "0x1884C7A10")]
	[AsyncStateMachine(typeof(MFCCJPLHCLK))]
	private Task MKHGPADHPBD(FIEDEFBCGNM DHAOEHNLNON, NPIJPEFDCBH ENIJPHENPOB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x84C7770", Offset = "0x84C6970", VA = "0x1884C7770")]
	private void LEGKDIIJBFI(MBBDNOCBHIC GNHHPPGPONN, NPIJPEFDCBH ENIJPHENPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x84C7FA0", Offset = "0x84C71A0", VA = "0x1884C7FA0")]
	private void PKKFKNOEMAM(MBBDNOCBHIC MAGLMBDBBIK, [Out] MBBDNOCBHIC LOAFJEBHPIB, [Out] MBBDNOCBHIC CBEBOBEJGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x84C6F90", Offset = "0x84C6190", VA = "0x1884C6F90")]
	private Task<MMKNLEBFHHO> GKIJDPBJEHD(IAAJJFDJPDA MGALKMHOLCM, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x84C6B70", Offset = "0x84C5D70", VA = "0x1884C6B70")]
	private Task<FIEDEFBCGNM> EOGOHADFANF(MMKNLEBFHHO DHAOEHNLNON, BMDKIDJMNGN.MPGGFACLDBI KAIPLCENELE, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x84C72A0", Offset = "0x84C64A0", VA = "0x1884C72A0")]
	[AsyncStateMachine(typeof(LBBCLNONELM))]
	private Task JGFBALDFEAP(FIEDEFBCGNM DHAOEHNLNON, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM, bool IJKHKIONGPK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x84C7920", Offset = "0x84C6B20", VA = "0x1884C7920")]
	[AsyncStateMachine(typeof(BBKGALJLEAF))]
	private Task MDDLJFAFACO(FIEDEFBCGNM DHAOEHNLNON, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x84C6F60", Offset = "0x84C6160", VA = "0x1884C6F60")]
	private Task GJELLAGHPNI(FIEDEFBCGNM DHAOEHNLNON, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x84C65C0", Offset = "0x84C57C0", VA = "0x1884C65C0")]
	private Task CMADPDNKOJN(FIEDEFBCGNM DHAOEHNLNON, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x84C7E20", Offset = "0x84C7020", VA = "0x1884C7E20")]
	private Task NKIEMCNHBJM(FIEDEFBCGNM DHAOEHNLNON, NPMEPDGKAFM GCKDCNNODIF, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x84C7E00", Offset = "0x84C7000", VA = "0x1884C7E00")]
	private Task NEFGMLBJPNG(FIEDEFBCGNM DHAOEHNLNON, NPMEPDGKAFM GCKDCNNODIF, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x84C7910", Offset = "0x84C6B10", VA = "0x1884C7910")]
	private static Task MBDBLILLOPL(CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x84C6BB0", Offset = "0x84C5DB0", VA = "0x1884C6BB0")]
	private Task EPJEPFOJBCM(FIEDEFBCGNM DHAOEHNLNON, NPMEPDGKAFM GCKDCNNODIF, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x84C7750", Offset = "0x84C6950", VA = "0x1884C7750")]
	private Task KMADPMHNPHB(FIEDEFBCGNM DHAOEHNLNON, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x84C6570", Offset = "0x84C5770", VA = "0x1884C6570")]
	private void BLOBADJPEOI(IAAJJFDJPDA MGALKMHOLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x84C6E80", Offset = "0x84C6080", VA = "0x1884C6E80")]
	public void GENEJOKKMOK(long GKDHCJGNLGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	private static void BLLAEPHPEFL(JKGEOIDCPBI GKCIPCHGLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x84C7600", Offset = "0x84C6800", VA = "0x1884C7600")]
	[AsyncStateMachine(typeof(MJHFCAKJDEF))]
	private Task KIBFLGGPBOL(FIEDEFBCGNM MNIBCKMAPMJ, NPIJPEFDCBH PDNLJDPFGEN, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken CNECMHFFDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x84C7B60", Offset = "0x84C6D60", VA = "0x1884C7B60")]
	[AsyncStateMachine(typeof(JLOALBJCOGO))]
	private Task MPKHDKEJAIN(FIEDEFBCGNM DHAOEHNLNON, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x84C73F0", Offset = "0x84C65F0", VA = "0x1884C73F0")]
	private static HLDHGKEJCGP JGPKDANKHEL(FIEDEFBCGNM GEEJDHPDEKD)
	{
		return default(HLDHGKEJCGP);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x84C7E40", Offset = "0x84C7040", VA = "0x1884C7E40")]
	[AsyncStateMachine(typeof(GEPGONDAGJD))]
	private Task<MBBDNOCBHIC> OLBHBNKHBNK(FIEDEFBCGNM DHAOEHNLNON, NPMEPDGKAFM GCKDCNNODIF, NPIJPEFDCBH ENIJPHENPOB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	private void DAAEBFEDMIK(MBBDNOCBHIC EIJNIKIHJNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct KPGBNPHGMOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A4")]
	private MEBNIAGNGEK LLMBGPNPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005A5")]
	private FIEDEFBCGNM DHAOEHNLNON;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private LAMEDCHOMHL LMBINNBIMPB
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x84ECAD0", Offset = "0x84EBCD0", VA = "0x1884ECAD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x84ECB20", Offset = "0x84EBD20", VA = "0x1884ECB20")]
	public static Task MENHHIHEOIL(MEBNIAGNGEK LLMBGPNPABD, FIEDEFBCGNM DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x84ECC00", Offset = "0x84EBE00", VA = "0x1884ECC00")]
	private void MENHHIHEOIL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct IGEKILKCICO
{
	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x84E8BF0", Offset = "0x84E7DF0", VA = "0x1884E8BF0")]
	public static Task MENHHIHEOIL(CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct GINGLAIHONJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct NDJBFOBKPMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public FBMKMKEAMFG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x84F2600", Offset = "0x84F1800", VA = "0x1884F2600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x84F2B30", Offset = "0x84F1D30", VA = "0x1884F2B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x84E6390", Offset = "0x84E5590", VA = "0x1884E6390")]
	[AsyncStateMachine(typeof(NDJBFOBKPMA))]
	public static Task MENHHIHEOIL(FBMKMKEAMFG DFANBODNJBB, FIEDEFBCGNM DHAOEHNLNON, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal struct IICOHKFFKGF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct FAPCCDBNOBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public FBMKMKEAMFG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public NPMEPDGKAFM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private MEBNIAGNGEK <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private LAMEDCHOMHL <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private MBBDNOCBHIC <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private AHAEBJLBPKA <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private List<(PersistenceView, AOAEIBCNJOH)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private AOAEIBCNJOH <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x84E3A40", Offset = "0x84E2C40", VA = "0x1884E3A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x84E4710", Offset = "0x84E3910", VA = "0x1884E4710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x84E97A0", Offset = "0x84E89A0", VA = "0x1884E97A0")]
	[AsyncStateMachine(typeof(FAPCCDBNOBA))]
	public static Task MENHHIHEOIL(FBMKMKEAMFG DFANBODNJBB, FIEDEFBCGNM DHAOEHNLNON, NPMEPDGKAFM GCKDCNNODIF, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x84E95B0", Offset = "0x84E87B0", VA = "0x1884E95B0")]
	private static void JKFLBMBCGBG(PersistenceView DMGGONLOPJG, AOAEIBCNJOH COAOCPHILMM, FIEDEFBCGNM DHAOEHNLNON, MBBDNOCBHIC MMLJKLMFMIK, bool MPIEAGHGJCB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct BJNBHMPEIKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct AAAFHANFNJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public MEBNIAGNGEK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private AHAEBJLBPKA <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x84DDC80", Offset = "0x84DCE80", VA = "0x1884DDC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x84DE2A0", Offset = "0x84DD4A0", VA = "0x1884DE2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x84DF380", Offset = "0x84DE580", VA = "0x1884DF380")]
	[AsyncStateMachine(typeof(AAAFHANFNJK))]
	public static Task MENHHIHEOIL(MEBNIAGNGEK LLMBGPNPABD, FIEDEFBCGNM DHAOEHNLNON, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct FHHDCGLKHBD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct FDIGJBDKINC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public MEBNIAGNGEK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public FBMKMKEAMFG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x84E4770", Offset = "0x84E3970", VA = "0x1884E4770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x84E4980", Offset = "0x84E3B80", VA = "0x1884E4980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class KKHJHEDJCOI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000163")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			public EAIPOBMEIGP<string>.MNKIBAEKPMC timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005DC")]
			public KKHJHEDJCOI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005DD")]
			private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005DE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x84F6DD0", Offset = "0x84F5FD0", VA = "0x1884F6DD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x84F7160", Offset = "0x84F6360", VA = "0x1884F7160", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KKHJHEDJCOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x84EC9B0", Offset = "0x84EBBB0", VA = "0x1884EC9B0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task CHHFEKNNBAD(EAIPOBMEIGP<string>.MNKIBAEKPMC timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct BKMHNGEONIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public FHHDCGLKHBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private AHAEBJLBPKA <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private TaskAwaiter<CBMIKICCFNL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x84DF4A0", Offset = "0x84DE6A0", VA = "0x1884DF4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x84E00A0", Offset = "0x84DF2A0", VA = "0x1884E00A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private sealed class KCMFJDPPCMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public PHALJEJMFGJ version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KCMFJDPPCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x84EC640", Offset = "0x84EB840", VA = "0x1884EC640")]
		internal object LCHKILHJBGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x84EC590", Offset = "0x84EB790", VA = "0x1884EC590")]
		internal object DGLLPACHLOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private MEBNIAGNGEK LLMBGPNPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private FIEDEFBCGNM DHAOEHNLNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	private FBMKMKEAMFG DFANBODNJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	private bool IJKHKIONGPK;

	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	private static readonly ByteString OGPGBJKPIMI;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private LAMEDCHOMHL LMBINNBIMPB
	{
		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x84E5250", Offset = "0x84E4450", VA = "0x1884E5250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private MOALAMGIMLB LHDJPHOLKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x84E51B0", Offset = "0x84E43B0", VA = "0x1884E51B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x84E53D0", Offset = "0x84E45D0", VA = "0x1884E53D0")]
	[AsyncStateMachine(typeof(FDIGJBDKINC))]
	public static Task MENHHIHEOIL(MEBNIAGNGEK LLMBGPNPABD, FIEDEFBCGNM DHAOEHNLNON, FBMKMKEAMFG DFANBODNJBB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM, bool IJKHKIONGPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x84E52A0", Offset = "0x84E44A0", VA = "0x1884E52A0")]
	[AsyncStateMachine(typeof(BKMHNGEONIM))]
	private Task MENHHIHEOIL(EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x84E49E0", Offset = "0x84E3BE0", VA = "0x1884E49E0")]
	private void GFCBMNGLANL([NotNull] CBMANFMCNIJ HIOKFECJHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x84E5520", Offset = "0x84E4720", VA = "0x1884E5520")]
	private bool OHENEMLFLLG(PHALJEJMFGJ COBPGHDNJHM, CBMANFMCNIJ HIOKFECJHKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
internal struct IHAHHGPCMME
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct JDGPBLDNJAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public AsyncTaskMethodBuilder<FIEDEFBCGNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public IHAHHGPCMME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public BMDKIDJMNGN.MPGGFACLDBI downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private TaskAwaiter<IReadOnlyCollection<PPPFLOFMGEF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private TaskAwaiter<(LOAMJJJEMNF<BOLOMBBNDKH, DKPIACPJNCE>, LOAMJJJEMNF<PKKJJPIBJOL<CBMANFMCNIJ>, DKPIACPJNCE>, LOAMJJJEMNF<PKKJJPIBJOL<HAPGMLIDNII>, DKPIACPJNCE>, LOAMJJJEMNF<PKKJJPIBJOL<IEnumerable<MEGCPPBFEPP>>, DKPIACPJNCE>, LOAMJJJEMNF<PKKJJPIBJOL<LPOALELDKHA>, DKPIACPJNCE>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x84EA550", Offset = "0x84E9750", VA = "0x1884EA550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x84EB330", Offset = "0x84EA530", VA = "0x1884EB330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct IJIOKAHNHAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<BOLOMBBNDKH, DKPIACPJNCE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public IHAHHGPCMME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public IReadOnlyCollection<PPPFLOFMGEF> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public IReadOnlyCollection<PPPFLOFMGEF> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public BMDKIDJMNGN.MPGGFACLDBI downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private TaskAwaiter<LOAMJJJEMNF<BOLOMBBNDKH, DKPIACPJNCE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x84E98F0", Offset = "0x84E8AF0", VA = "0x1884E98F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x84E9F50", Offset = "0x84E9150", VA = "0x1884E9F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	private HMIMLCMIJEA<ELAGIFLJMJI, HAPGMLIDNII> HNMLKNPINGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private HMIMLCMIJEA<ELAGIFLJMJI, CBMANFMCNIJ> CPBIOEIILAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private HMIMLCMIJEA<HPNKLCGCBEM, IEnumerable<MEGCPPBFEPP>> JFIFEPPDDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private HMIMLCMIJEA<long, LPOALELDKHA> KJBJBNFBLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	private HBHCIFDDHPO NILLFPJDLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	private JKGEOIDCPBI GKCIPCHGLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private LKOOIDABJPJ NBFHPABLEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	private Guid? LIPEAFABIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private IReadOnlyCollection<PPPFLOFMGEF> FIFIFCJKBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private Task<IReadOnlyCollection<PPPFLOFMGEF>> AOBOJFIPFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private ELAGIFLJMJI ALDFCBINAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private ELAGIFLJMJI OHFDGJIJNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	private ELAGIFLJMJI? PLGPNGBHBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40005FB")]
	private HPNKLCGCBEM EEPHBGODAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40005FC")]
	private EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP;

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x84E8CD0", Offset = "0x84E7ED0", VA = "0x1884E8CD0")]
	public static Task<FIEDEFBCGNM> GPFDAOMGIOH(MEBNIAGNGEK LLMBGPNPABD, [In] MMKNLEBFHHO DHAOEHNLNON, BMDKIDJMNGN.MPGGFACLDBI KAIPLCENELE, EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x84E9400", Offset = "0x84E8600", VA = "0x1884E9400")]
	[AsyncStateMachine(typeof(JDGPBLDNJAO))]
	private Task<FIEDEFBCGNM> MENHHIHEOIL(BMDKIDJMNGN.MPGGFACLDBI KAIPLCENELE, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x84E91D0", Offset = "0x84E83D0", VA = "0x1884E91D0")]
	[AsyncStateMachine(typeof(IJIOKAHNHAN))]
	private Task<LOAMJJJEMNF<BOLOMBBNDKH, DKPIACPJNCE>> JBIGFCKENMC(Guid? LIPEAFABIEA, IReadOnlyCollection<PPPFLOFMGEF> FIFIFCJKBDK, IReadOnlyCollection<PPPFLOFMGEF> IJKFNPLGOLJ, long? BENLNHBBIME, long? OECKHCOHBDG, BMDKIDJMNGN.MPGGFACLDBI KAIPLCENELE, EAIPOBMEIGP<string>.MNKIBAEKPMC NJILMGHIEPL, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
internal struct GEHCOHJAEIJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct CHILOGKLONJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public AsyncTaskMethodBuilder<MMKNLEBFHHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public GEHCOHJAEIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private TaskAwaiter<MMKNLEBFHHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x84E04B0", Offset = "0x84DF6B0", VA = "0x1884E04B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x84E0900", Offset = "0x84DFB00", VA = "0x1884E0900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct BGMFELFGFID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public AsyncTaskMethodBuilder<MMKNLEBFHHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public GEHCOHJAEIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private TaskAwaiter<MMKNLEBFHHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x84DEE90", Offset = "0x84DE090", VA = "0x1884DEE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x84DF310", Offset = "0x84DE510", VA = "0x1884DF310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class CGNDKEJPDCN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016D")]
		private struct <<FetchRoomLoadDetails>g__getRoomSaveData|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			public CGNDKEJPDCN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			private TaskAwaiter<BFBOEDNCMMM> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400063E")]
			private TaskAwaiter<IACGOJIMLMI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x84F5200", Offset = "0x84F4400", VA = "0x1884F5200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x84F5BB0", Offset = "0x84F4DB0", VA = "0x1884F5BB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public BNBGAHNOJKP roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public LAMEDCHOMHL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public ELAGIFLJMJI superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public ELAGIFLJMJI subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public IReadOnlyList<PPPFLOFMGEF> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public IReadOnlyList<PPPFLOFMGEF> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public JKGEOIDCPBI roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CGNDKEJPDCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xE6E1F0", Offset = "0xE6D3F0", VA = "0x180E6E1F0")]
		internal bool LGPBBPIBJMO(LKOOIDABJPJ sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x84E03E0", Offset = "0x84DF5E0", VA = "0x1884E03E0")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task BFMHGFJMAEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x84E01E0", Offset = "0x84DF3E0", VA = "0x1884E01E0")]
		internal Task<HPNKLCGCBEM> BDKLNPDDBJF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct MFMMEGLHFGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public AsyncTaskMethodBuilder<MMKNLEBFHHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public BNBGAHNOJKP roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public LAMEDCHOMHL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public ELAGIFLJMJI superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private CGNDKEJPDCN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private LKOOIDABJPJ <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private Task<HPNKLCGCBEM> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private TaskAwaiter<JKGEOIDCPBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private TaskAwaiter<HPNKLCGCBEM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x84EE390", Offset = "0x84ED590", VA = "0x1884EE390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x84EF340", Offset = "0x84EE540", VA = "0x1884EF340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	private LAMEDCHOMHL OIONFMJBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private MHBBONFJJIK FCFPPCDHFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private BNBGAHNOJKP JKCKIGMECHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	private long BENLNHBBIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	private long DLHGMNACNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private long IOPIKANEPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private string HKPLMIHOJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	private ELAGIFLJMJI BOACGJEELHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400061D")]
	private Guid IDIAIKKAAEM;

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x84E5960", Offset = "0x84E4B60", VA = "0x1884E5960")]
	public static Task<MMKNLEBFHHO> GPFDAOMGIOH(MEBNIAGNGEK LLMBGPNPABD, IAAJJFDJPDA MGALKMHOLCM, EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x84E5BB0", Offset = "0x84E4DB0", VA = "0x1884E5BB0")]
	[AsyncStateMachine(typeof(CHILOGKLONJ))]
	private Task<MMKNLEBFHHO> MENHHIHEOIL(CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x84E5620", Offset = "0x84E4820", VA = "0x1884E5620")]
	[AsyncStateMachine(typeof(BGMFELFGFID))]
	private Task<MMKNLEBFHHO> GKIJDPBJEHD(EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x84E5790", Offset = "0x84E4990", VA = "0x1884E5790")]
	[AsyncStateMachine(typeof(MFMMEGLHFGO))]
	private static Task<MMKNLEBFHHO> GKIJDPBJEHD(LAMEDCHOMHL OIONFMJBFHJ, BNBGAHNOJKP JKCKIGMECHD, long BENLNHBBIME, long DLHGMNACNGF, long IOPIKANEPAB, string HKPLMIHOJLJ, ELAGIFLJMJI BOACGJEELHD, Guid IDIAIKKAAEM, CancellationToken HCELDNOKOAM, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x84E55F0", Offset = "0x84E47F0", VA = "0x1884E55F0")]
	private void AOOJGIHHBLI(JKGEOIDCPBI GKCIPCHGLOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
internal struct EHBPCFENFFK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct JLBGDMGCAEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public EHBPCFENFFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x84EBAC0", Offset = "0x84EACC0", VA = "0x1884EBAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x84EC050", Offset = "0x84EB250", VA = "0x1884EC050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	private LAMEDCHOMHL OIONFMJBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private FIEDEFBCGNM DHAOEHNLNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000654")]
	private EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private float FNNLJLAFPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private float IOEIMIPNHNO;

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x84E2590", Offset = "0x84E1790", VA = "0x1884E2590")]
	public static Task AFMJLNCBIGC(MEBNIAGNGEK LLMBGPNPABD, FIEDEFBCGNM DHAOEHNLNON, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x84E2A80", Offset = "0x84E1C80", VA = "0x1884E2A80")]
	[AsyncStateMachine(typeof(JLBGDMGCAEF))]
	public Task MENHHIHEOIL(CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x84E2730", Offset = "0x84E1930", VA = "0x1884E2730")]
	private static void GBJEGGHKKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x84E2920", Offset = "0x84E1B20", VA = "0x1884E2920")]
	private void KHNFIHPIKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x84E2860", Offset = "0x84E1A60", VA = "0x1884E2860")]
	private static float HILKEBOHICE(LAMEDCHOMHL OIONFMJBFHJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x84E2BA0", Offset = "0x84E1DA0", VA = "0x1884E2BA0")]
	private static float PMHHPNEEFDC()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000172")]
internal struct NDIDBKMBEAA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private struct GKMJLFKHLOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public FBMKMKEAMFG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private GLOBKHNLMMN <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private MEBNIAGNGEK <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private PGONKHONIGI.IIOPIJBKLJE <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private TaskAwaiter<CBMIKICCFNL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x84E64D0", Offset = "0x84E56D0", VA = "0x1884E64D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x84E6CF0", Offset = "0x84E5EF0", VA = "0x1884E6CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct JFNPJLAMBMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x84EB730", Offset = "0x84EA930", VA = "0x1884EB730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x84EBA60", Offset = "0x84EAC60", VA = "0x1884EBA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x84F24C0", Offset = "0x84F16C0", VA = "0x1884F24C0")]
	[AsyncStateMachine(typeof(GKMJLFKHLOA))]
	public static Task MENHHIHEOIL(FBMKMKEAMFG DFANBODNJBB, FIEDEFBCGNM DHAOEHNLNON, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x84F2390", Offset = "0x84F1590", VA = "0x1884F2390")]
	private static Task<CBMIKICCFNL> EGHKPKFFHGM(FBMKMKEAMFG DFANBODNJBB, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x84F2400", Offset = "0x84F1600", VA = "0x1884F2400")]
	[AsyncStateMachine(typeof(JFNPJLAMBMM))]
	private static Task GAPGHLIGPHM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
internal struct KGOEFELOJCC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct CIOIKNKPNGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public KGOEFELOJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x84E0970", Offset = "0x84DFB70", VA = "0x1884E0970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x84E1020", Offset = "0x84E0220", VA = "0x1884E1020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class KBAENGCOGDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KBAENGCOGDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x84EC510", Offset = "0x84EB710", VA = "0x1884EC510")]
		internal object GLMHOJJHKNP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct DIFIDGJOEKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public KGOEFELOJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x84E20B0", Offset = "0x84E12B0", VA = "0x1884E20B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x84E2530", Offset = "0x84E1730", VA = "0x1884E2530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private bool EHGIDFEKOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private MEBNIAGNGEK LLMBGPNPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private CancellationToken HCELDNOKOAM;

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x84EC720", Offset = "0x84EB920", VA = "0x1884EC720")]
	public static Task FLNGEPCNAFC(MEBNIAGNGEK LLMBGPNPABD, bool EHGIDFEKOJG, EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, CancellationToken PIBIIIAPLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x84EC790", Offset = "0x84EB990", VA = "0x1884EC790")]
	[AsyncStateMachine(typeof(CIOIKNKPNGC))]
	private Task MENHHIHEOIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x84EC880", Offset = "0x84EBA80", VA = "0x1884EC880")]
	[AsyncStateMachine(typeof(DIFIDGJOEKP))]
	private Task ONBEDAFAEFC(bool PDDFIAPODMK, string OIMMOCPAEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0")]
	private bool KABDPLIEFBD(bool EHGIDFEKOJG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
internal struct JECBACDLDGG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct EPGICMBJPEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public JECBACDLDGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x84E3460", Offset = "0x84E2660", VA = "0x1884E3460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x84E39D0", Offset = "0x84E2BD0", VA = "0x1884E39D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class BNGAGDLCHLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public BNGAGDLCHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x84E0100", Offset = "0x84DF300", VA = "0x1884E0100")]
		internal object GLMHOJJHKNP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct HAOCPMIAMKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public JECBACDLDGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x84E7DC0", Offset = "0x84E6FC0", VA = "0x1884E7DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x84E8240", Offset = "0x84E7440", VA = "0x1884E8240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private BEBKBOMAABG OKHJKIIOFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private MEBNIAGNGEK LLMBGPNPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private bool ILFLFGBCIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private FIEDEFBCGNM DHAOEHNLNON;

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x84EB3A0", Offset = "0x84EA5A0", VA = "0x1884EB3A0")]
	public static Task<Scene> DDIELBEOMLO(MEBNIAGNGEK LLMBGPNPABD, BEBKBOMAABG PECCAPLMLLK, EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x84EB4C0", Offset = "0x84EA6C0", VA = "0x1884EB4C0")]
	[AsyncStateMachine(typeof(EPGICMBJPEJ))]
	private Task<Scene> MENHHIHEOIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x84EB420", Offset = "0x84EA620", VA = "0x1884EB420")]
	private bool JHGBDKJBPGM(FIEDEFBCGNM DHAOEHNLNON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x84EB450", Offset = "0x84EA650", VA = "0x1884EB450")]
	private void LGGJFAODPFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x84EB5E0", Offset = "0x84EA7E0", VA = "0x1884EB5E0")]
	[AsyncStateMachine(typeof(HAOCPMIAMKA))]
	private Task<Scene> ONBEDAFAEFC(string OIMMOCPAEDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal struct LODMDPOOIJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct PJCNPKOKOGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public AsyncTaskMethodBuilder<MBBDNOCBHIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public LODMDPOOIJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public MBBDNOCBHIC nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public FIEDEFBCGNM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private TaskAwaiter<MBBDNOCBHIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x84F45A0", Offset = "0x84F37A0", VA = "0x1884F45A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x84F5070", Offset = "0x84F4270", VA = "0x1884F5070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct OFABEEEDCPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public AsyncTaskMethodBuilder<MBBDNOCBHIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public LODMDPOOIJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public MBBDNOCBHIC state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private TaskAwaiter<CBMIKICCFNL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x84F3760", Offset = "0x84F2960", VA = "0x1884F3760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x84F3A40", Offset = "0x84F2C40", VA = "0x1884F3A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	private readonly FBMKMKEAMFG DFANBODNJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	private readonly MHBBONFJJIK FCFPPCDHFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private readonly GPMDGOLEFJN BKNPNHLENFI;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private GLOBKHNLMMN CNGNBGINFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x69664C0", Offset = "0x69656C0", VA = "0x1869664C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x84ED7D0", Offset = "0x84EC9D0", VA = "0x1884ED7D0")]
	public LODMDPOOIJC(FBMKMKEAMFG DFANBODNJBB, MHBBONFJJIK FCFPPCDHFAL, GPMDGOLEFJN BKNPNHLENFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x84ED4F0", Offset = "0x84EC6F0", VA = "0x1884ED4F0")]
	[AsyncStateMachine(typeof(PJCNPKOKOGE))]
	public Task<MBBDNOCBHIC> INOPAENOJFH(MBBDNOCBHIC EFBONFGDJGP, FIEDEFBCGNM GEEJDHPDEKD, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM, bool CLBCBPCHNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x84ED670", Offset = "0x84EC870", VA = "0x1884ED670")]
	[AsyncStateMachine(typeof(OFABEEEDCPF))]
	private Task<MBBDNOCBHIC> PIDAOCGJJJC(EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, MBBDNOCBHIC HPAPEOOKLIH, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x84ED4A0", Offset = "0x84EC6A0", VA = "0x1884ED4A0")]
	private bool BKLBLHBJNIP(MBBDNOCBHIC MJHMHHBOJGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x84ED4D0", Offset = "0x84EC6D0", VA = "0x1884ED4D0")]
	private void GCMHLHCLEDM(string FNJOHGLGALB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal struct NNBAMKGLJBB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct NGPBGKIOENE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public GLOBKHNLMMN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public NPMEPDGKAFM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private AHAEBJLBPKA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private List<(PersistenceView, AOAEIBCNJOH)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private (PersistenceView, AOAEIBCNJOH) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x84F2B90", Offset = "0x84F1D90", VA = "0x1884F2B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x84F3250", Offset = "0x84F2450", VA = "0x1884F3250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x84F3620", Offset = "0x84F2820", VA = "0x1884F3620")]
	[AsyncStateMachine(typeof(NGPBGKIOENE))]
	public static Task MENHHIHEOIL(GLOBKHNLMMN AFMEMNMIOCM, FIEDEFBCGNM DHAOEHNLNON, NPMEPDGKAFM GCKDCNNODIF, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal struct ACJMPPFMCDB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private struct IDFFOEOONDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public GLOBKHNLMMN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public NPMEPDGKAFM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private PHALJEJMFGJ <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private AHAEBJLBPKA <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private List<(PersistenceView, AOAEIBCNJOH)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private AOAEIBCNJOH <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x84E82B0", Offset = "0x84E74B0", VA = "0x1884E82B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x84E8B90", Offset = "0x84E7D90", VA = "0x1884E8B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x84DE300", Offset = "0x84DD500", VA = "0x1884DE300")]
	[AsyncStateMachine(typeof(IDFFOEOONDA))]
	public static Task MENHHIHEOIL(GLOBKHNLMMN AFMEMNMIOCM, FIEDEFBCGNM DHAOEHNLNON, NPMEPDGKAFM GCKDCNNODIF, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public struct LJGIIGHJKEE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct NBKKCBPLMGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<BOLOMBBNDKH, DKPIACPJNCE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public LJGIIGHJKEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public BMDKIDJMNGN.MPGGFACLDBI preloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private TaskAwaiter<LOAMJJJEMNF<BOLOMBBNDKH, DKPIACPJNCE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x84F1CA0", Offset = "0x84F0EA0", VA = "0x1884F1CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x84F2320", Offset = "0x84F1520", VA = "0x1884F2320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	private long HGDKILLNFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private long OOKEGLGLJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private Guid? OJEBGMOJFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	private IReadOnlyCollection<PPPFLOFMGEF> NGJODAHAOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private IReadOnlyCollection<PPPFLOFMGEF> HGNHBIMONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private HBHCIFDDHPO FDPIKPIFKGK;

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x84ED160", Offset = "0x84EC360", VA = "0x1884ED160")]
	public static Task<LOAMJJJEMNF<BOLOMBBNDKH, DKPIACPJNCE>> GPFDAOMGIOH(long BENLNHBBIME, long DLHGMNACNGF, IACGOJIMLMI FHJAKCIFNHB, BMDKIDJMNGN.MPGGFACLDBI CDGPIPBJICG, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x84ED2C0", Offset = "0x84EC4C0", VA = "0x1884ED2C0")]
	[AsyncStateMachine(typeof(NBKKCBPLMGJ))]
	private Task<LOAMJJJEMNF<BOLOMBBNDKH, DKPIACPJNCE>> MENHHIHEOIL(BMDKIDJMNGN.MPGGFACLDBI CDGPIPBJICG, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal struct PGONKHONIGI
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	public struct IIOPIJBKLJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public List<KPFBBJDLKAE> OFHPPGBKPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public List<AOAEIBCNJOH> BHBCBAGAMKD;

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xAE1FD0", Offset = "0xAE11D0", VA = "0x180AE1FD0")]
		public IIOPIJBKLJE(List<KPFBBJDLKAE> OFHPPGBKPJF, List<AOAEIBCNJOH> BHBCBAGAMKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class PDLDFIOOGKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public IEnumerable<KPFBBJDLKAE> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PDLDFIOOGKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x84F3AB0", Offset = "0x84F2CB0", VA = "0x1884F3AB0")]
		internal object JIIJJMHCBGE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private MEBNIAGNGEK LLMBGPNPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	private FIEDEFBCGNM DHAOEHNLNON;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private LAMEDCHOMHL LMBINNBIMPB
	{
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x84F42A0", Offset = "0x84F34A0", VA = "0x1884F42A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x84F42F0", Offset = "0x84F34F0", VA = "0x1884F42F0")]
	public static IIOPIJBKLJE MENHHIHEOIL(MEBNIAGNGEK LLMBGPNPABD, FIEDEFBCGNM DHAOEHNLNON)
	{
		return default(IIOPIJBKLJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x84F4350", Offset = "0x84F3550", VA = "0x1884F4350")]
	private IIOPIJBKLJE MENHHIHEOIL()
	{
		return default(IIOPIJBKLJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x84F3D00", Offset = "0x84F2F00", VA = "0x1884F3D00")]
	private IIOPIJBKLJE GHADNFCHCAK(CBMANFMCNIJ HIOKFECJHKI, PHALJEJMFGJ CDJGDGHHGEH)
	{
		return default(IIOPIJBKLJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x84F3B30", Offset = "0x84F2D30", VA = "0x1884F3B30")]
	private bool AMDPGIFNGGC(IEnumerable<KPFBBJDLKAE> OFHPPGBKPJF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal struct MFDLGJFLMOO
{
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class NHFJOJNNEHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public PGONKHONIGI.IIOPIJBKLJE instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public NHFJOJNNEHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x84F32B0", Offset = "0x84F24B0", VA = "0x1884F32B0")]
		internal object CHHFEKNNBAD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class CBKEJNCNEBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CBKEJNCNEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x84E0150", Offset = "0x84DF350", VA = "0x1884E0150")]
		internal object KNJJIMFDLDA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x84EDDE0", Offset = "0x84ECFE0", VA = "0x1884EDDE0")]
	public static void MENHHIHEOIL(GLOBKHNLMMN AFMEMNMIOCM, FIEDEFBCGNM DHAOEHNLNON, PGONKHONIGI.IIOPIJBKLJE BHIBIIHGCDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
internal class GPMDGOLEFJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private struct ALBBCJBNLAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public GPMDGOLEFJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public MBBDNOCBHIC operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public FIEDEFBCGNM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x84DE440", Offset = "0x84DD640", VA = "0x1884DE440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x84DEBB0", Offset = "0x84DDDB0", VA = "0x1884DEBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private sealed class KPDAPONILIG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018F")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006E8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006E9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006EA")]
			public KPDAPONILIG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006EB")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(RVA = "0x8506B20", Offset = "0x8505D20", VA = "0x188506B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(RVA = "0x8506CC0", Offset = "0x8505EC0", VA = "0x188506CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public GPMDGOLEFJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KPDAPONILIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x8500820", Offset = "0x84FFA20", VA = "0x188500820")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task LIPHKGGALAA(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private struct HDHHBIAGEDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public GPMDGOLEFJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		private KPDAPONILIG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x84FC250", Offset = "0x84FB450", VA = "0x1884FC250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x84FC780", Offset = "0x84FB980", VA = "0x1884FC780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private struct FFNGGCAFELO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public GPMDGOLEFJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private Dictionary<Guid, List<OFCBOOGBEMO>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x84FA440", Offset = "0x84F9640", VA = "0x1884FA440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x84FAA50", Offset = "0x84F9C50", VA = "0x1884FAA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct GGLKOOBLEBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public GPMDGOLEFJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		private Dictionary<Guid, List<OFCBOOGBEMO>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x84FB9C0", Offset = "0x84FABC0", VA = "0x1884FB9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x84FC050", Offset = "0x84FB250", VA = "0x1884FC050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class NEPBNDNINAK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000194")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400070C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400070D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400070E")]
			public OFCBOOGBEMO handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400070F")]
			public NEPBNDNINAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000710")]
			private AHAEBJLBPKA <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000711")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x8506660", Offset = "0x8505860", VA = "0x188506660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x8506AC0", Offset = "0x8505CC0", VA = "0x188506AC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public CGEKIBEOHGB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public List<OFCBOOGBEMO> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public NEPBNDNINAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x85019A0", Offset = "0x8500BA0", VA = "0x1885019A0")]
		internal object GBNNCCKHKIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x8501A90", Offset = "0x8500C90", VA = "0x188501A90")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task IFCBNKIMODH(OFCBOOGBEMO handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x85018B0", Offset = "0x8500AB0", VA = "0x1885018B0")]
		internal object EPNHOPKJNNI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private struct EFMDKIGGEJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public CGEKIBEOHGB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public List<OFCBOOGBEMO> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private NEPBNDNINAK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x84F85B0", Offset = "0x84F77B0", VA = "0x1884F85B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x84F8A80", Offset = "0x84F7C80", VA = "0x1884F8A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private struct KFDNPNLBGFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public GPMDGOLEFJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x85004D0", Offset = "0x84FF6D0", VA = "0x1885004D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x85007C0", Offset = "0x84FF9C0", VA = "0x1885007C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class DFKDPOIOMON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DFKDPOIOMON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x84F8130", Offset = "0x84F7330", VA = "0x1884F8130")]
		internal object KIPBPBLMEPI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private struct GABKCHPBKNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public GPMDGOLEFJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public FIEDEFBCGNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x84FADA0", Offset = "0x84F9FA0", VA = "0x1884FADA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x84FB250", Offset = "0x84FA450", VA = "0x1884FB250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class PFEEJJFIOHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PFEEJJFIOHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x85056D0", Offset = "0x85048D0", VA = "0x1885056D0")]
		internal object EJJDGMOOEGI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct NAMDGFCKEFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public GPMDGOLEFJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private AHAEBJLBPKA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		private TaskAwaiter<CBMIKICCFNL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x85011D0", Offset = "0x85003D0", VA = "0x1885011D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x8501800", Offset = "0x8500A00", VA = "0x188501800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private sealed class BIIPKMFCJFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public BIIPKMFCJFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x84F77E0", Offset = "0x84F69E0", VA = "0x1884F77E0")]
		internal object AKMNLOAHGPI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private readonly FBMKMKEAMFG DFANBODNJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private LHFJKMLIJBJ BKNPNHLENFI;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private GLOBKHNLMMN CNGNBGINFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x1134C60", Offset = "0x1133E60", VA = "0x181134C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public GPMDGOLEFJN(FBMKMKEAMFG DFANBODNJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x84E7740", Offset = "0x84E6940", VA = "0x1884E7740")]
	[AsyncStateMachine(typeof(ALBBCJBNLAE))]
	public Task MENHHIHEOIL(MBBDNOCBHIC MMLJKLMFMIK, FIEDEFBCGNM GEEJDHPDEKD, EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x84E7B20", Offset = "0x84E6D20", VA = "0x1884E7B20")]
	[AsyncStateMachine(typeof(HDHHBIAGEDJ))]
	private Task NBOGKGCNJJF(FIEDEFBCGNM DHAOEHNLNON, EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x84E74C0", Offset = "0x84E66C0", VA = "0x1884E74C0")]
	[AsyncStateMachine(typeof(FFNGGCAFELO))]
	private Task INKKIFDIKEM(FIEDEFBCGNM DHAOEHNLNON, EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x84E7890", Offset = "0x84E6A90", VA = "0x1884E7890")]
	[AsyncStateMachine(typeof(GGLKOOBLEBM))]
	private Task MGHNMOPGFAP(FIEDEFBCGNM DHAOEHNLNON, EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x84E79D0", Offset = "0x84E6BD0", VA = "0x1884E79D0")]
	[AsyncStateMachine(typeof(EFMDKIGGEJP))]
	private Task MODGILOAACE(Guid BIOPHAELICD, List<OFCBOOGBEMO> MGKBEPHGIBJ, CGEKIBEOHGB DAKOPIJKDHC, FIEDEFBCGNM DHAOEHNLNON, CancellationToken PPOILDCNBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x84E7080", Offset = "0x84E6280", VA = "0x1884E7080")]
	[AsyncStateMachine(typeof(KFDNPNLBGFJ))]
	private Task CPICOBCKOID(FIEDEFBCGNM DHAOEHNLNON, EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x84E7270", Offset = "0x84E6470", VA = "0x1884E7270")]
	[AsyncStateMachine(typeof(GABKCHPBKNC))]
	private Task DBLAGDGBLCL(Guid IBANHOBHEGF, FIEDEFBCGNM DHAOEHNLNON, EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x84E7600", Offset = "0x84E6800", VA = "0x1884E7600")]
	[AsyncStateMachine(typeof(NAMDGFCKEFA))]
	private Task JOKGPEEFJAK(Guid IBANHOBHEGF, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x84E73B0", Offset = "0x84E65B0", VA = "0x1884E73B0")]
	private void GMHCNOFBAFH(Guid IBANHOBHEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x84E71C0", Offset = "0x84E63C0", VA = "0x1884E71C0")]
	private void DAACEBDJMMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x84E7C60", Offset = "0x84E6E60", VA = "0x1884E7C60")]
	public Guid OKJCCIPOEON(MBBDNOCBHIC GNHHPPGPONN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x84E6EB0", Offset = "0x84E60B0", VA = "0x1884E6EB0")]
	[CompilerGenerated]
	private object APHCOMNLOJG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal struct KCMAOAFECNN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private struct PPKFLBJLHFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public KCMAOAFECNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		private IEnumerator<COGKCPDJMJE> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x8505F60", Offset = "0x8505160", VA = "0x188505F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x8506600", Offset = "0x8505800", VA = "0x188506600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073A")]
	private LAMEDCHOMHL OIONFMJBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400073B")]
	private EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400073C")]
	private CancellationToken HCELDNOKOAM;

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x8500300", Offset = "0x84FF500", VA = "0x188500300")]
	public static Task KIJPAHJPCDG(LAMEDCHOMHL OIONFMJBFHJ, EAIPOBMEIGP<string>.MNKIBAEKPMC AGHDGMNHDIP, CancellationToken PIBIIIAPLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x8500370", Offset = "0x84FF570", VA = "0x188500370")]
	[AsyncStateMachine(typeof(PPKFLBJLHFA))]
	private Task MENHHIHEOIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public readonly struct OEKDMCDJKCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000743")]
	public readonly bool MIAJLNLPHLC;

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x29E56C0", Offset = "0x29E48C0", VA = "0x1829E56C0")]
	public OEKDMCDJKCL(bool LJOHFKIGBJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public readonly struct NOBGLNGJEOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000744")]
	public readonly CBMANFMCNIJ? LPAIKGOKIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000745")]
	public readonly LBBAHHNJLGB JAOCFHNIFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000746")]
	public readonly Guid? FMGNEFGHELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000747")]
	public readonly IReadOnlyList<Guid> NLHKEFKKEJC;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public IReadOnlyCollection<string> EBJMMHGKBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x8503E60", Offset = "0x8503060", VA = "0x188503E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public IReadOnlyDictionary<long, int> BGOCECMLFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x8503E40", Offset = "0x8503040", VA = "0x188503E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x8503E80", Offset = "0x8503080", VA = "0x188503E80")]
	public NOBGLNGJEOC(CBMANFMCNIJ? GIKGHELDAKC, LBBAHHNJLGB KPGLBJEDFGA, Guid? LIPEAFABIEA, [Optional] IReadOnlyList<Guid>? OHDFOONHHKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal class IFGFBHAGDOE : LOCEDEEHOHE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[CompilerGenerated]
	private struct GAIIDAAEGMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public AsyncTaskMethodBuilder<NOBGLNGJEOC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public IFGFBHAGDOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		public AGMAHEAGHKP serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public EGJEOIABGDI roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		private AHAEBJLBPKA <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x84FB2B0", Offset = "0x84FA4B0", VA = "0x1884FB2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x84FB950", Offset = "0x84FAB50", VA = "0x1884FB950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[CompilerGenerated]
	private sealed class JCEMOEONDGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public JCEMOEONDGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x84FFE80", Offset = "0x84FF080", VA = "0x1884FFE80")]
		internal object EALCIEICCAG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private struct NNPGNGBBMHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public IFGFBHAGDOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		public AGMAHEAGHKP serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		private JCEMOEONDGF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		private AHAEBJLBPKA <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		private GBAADKKOBIK<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x8503320", Offset = "0x8502520", VA = "0x188503320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x8503DE0", Offset = "0x8502FE0", VA = "0x188503DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000748")]
	private readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x4000749")]
	private static readonly TimeSpan GJNFPHDIBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400074A")]
	private readonly IDNDFGFEOGJ DCIKHINJKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400074B")]
	private readonly FJDGIFFFMEL NJBPGEPCFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400074C")]
	private readonly BNEBLNMMBKE KMGBCOCAAHA;

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x84FEF20", Offset = "0x84FE120", VA = "0x1884FEF20")]
	public IFGFBHAGDOE(FBMKMKEAMFG DFANBODNJBB, IDNDFGFEOGJ DCIKHINJKEJ, FJDGIFFFMEL FKFLIHGNLLJ, BNEBLNMMBKE KMGBCOCAAHA, FODGIOKBGBI FHEIHFBIKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x84FDD70", Offset = "0x84FCF70", VA = "0x1884FDD70")]
	[AsyncStateMachine(typeof(GAIIDAAEGMD))]
	public Task<NOBGLNGJEOC> CEBCPPBDNIB(long DLHGMNACNGF, EGJEOIABGDI FFKLHEMIAPD, AGMAHEAGHKP ABCGNDCNMLD, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x84FED70", Offset = "0x84FDF70", VA = "0x1884FED70")]
	[AsyncStateMachine(typeof(NNPGNGBBMHL))]
	private Task JHFMAGDFDCO(AGMAHEAGHKP ABCGNDCNMLD, PersistenceView[] JPLHCDMAEKF, StringBuilder PMGKNBKOGFN, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x84FE110", Offset = "0x84FD310", VA = "0x1884FE110")]
	private NOBGLNGJEOC GJLNFPDHOID(long DLHGMNACNGF, EGJEOIABGDI FFKLHEMIAPD, AGMAHEAGHKP ABCGNDCNMLD, IEnumerable<PersistenceView> JPLHCDMAEKF, StringBuilder PMGKNBKOGFN)
	{
		return default(NOBGLNGJEOC);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x84FE720", Offset = "0x84FD920", VA = "0x1884FE720")]
	private CBMANFMCNIJ GLIADPJBGCC(long DLHGMNACNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x84FDEC0", Offset = "0x84FD0C0", VA = "0x1884FDEC0")]
	private void FIHLIEACIGE(CBMANFMCNIJ HAKHLEEIOLA, StringBuilder PMGKNBKOGFN, IEnumerable<PersistenceView> JPLHCDMAEKF, [In] JEKOHOLAJIK PKGLEOPIBMF, HBKODKOLCMP HMEMHGFCCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x84FE8E0", Offset = "0x84FDAE0", VA = "0x1884FE8E0")]
	private void ILLDIOFMDAM(CBMANFMCNIJ HAKHLEEIOLA, StringBuilder PMGKNBKOGFN, PersistenceView DMGGONLOPJG, HBKODKOLCMP HMEMHGFCCGD, [In] JEKOHOLAJIK PKGLEOPIBMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
internal class IBMCGJPPEGL : LOCEDEEHOHE
{
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class NBPAMKPPBFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public CLLHCDHAJBH.OEKEMKNECIB roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public NBPAMKPPBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x8501860", Offset = "0x8500A60", VA = "0x188501860")]
		internal object CAIEHMKDFGL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private struct IJJAKIAKHPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public AsyncTaskMethodBuilder<(CLLHCDHAJBH.OEKEMKNECIB roomDataUpload, CLLHCDHAJBH.OEKEMKNECIB subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public NOBGLNGJEOC roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public LAMEDCHOMHL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		private NBPAMKPPBFC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		private TaskAwaiter<CLLHCDHAJBH.OEKEMKNECIB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x84FEF90", Offset = "0x84FE190", VA = "0x1884FEF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x84FF810", Offset = "0x84FEA10", VA = "0x1884FF810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private struct HHAMJPFEHHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public AsyncTaskMethodBuilder<PDHIEPEKDIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public IBMCGJPPEGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		public AMCBFCIFFOH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		public NOBGLNGJEOC roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		private TaskAwaiter<PDHIEPEKDIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x84FCE70", Offset = "0x84FC070", VA = "0x1884FCE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x84FD110", Offset = "0x84FC310", VA = "0x1884FD110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct PHLDDIFDLNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		public AsyncTaskMethodBuilder<PDHIEPEKDIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public LAMEDCHOMHL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		public NOBGLNGJEOC roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public PMBENBIFFBO ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public AMCBFCIFFOH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		private TaskAwaiter<(CLLHCDHAJBH.OEKEMKNECIB roomDataUpload, CLLHCDHAJBH.OEKEMKNECIB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		private TaskAwaiter<PDHIEPEKDIL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x8505740", Offset = "0x8504940", VA = "0x188505740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x8505DA0", Offset = "0x8504FA0", VA = "0x188505DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private struct LHKLPGOAEIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		public AsyncTaskMethodBuilder<BFBOEDNCMMM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		public IBMCGJPPEGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public NOBGLNGJEOC roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		private TaskAwaiter<(CLLHCDHAJBH.OEKEMKNECIB roomDataUpload, CLLHCDHAJBH.OEKEMKNECIB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		private TaskAwaiter<BFBOEDNCMMM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x8500910", Offset = "0x84FFB10", VA = "0x188500910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x8500DC0", Offset = "0x84FFFC0", VA = "0x188500DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private sealed class OPENMEHGDBB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AD")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000799")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400079A")]
			public AsyncTaskMethodBuilder<CBMIKICCFNL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400079B")]
			public OPENMEHGDBB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400079C")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400079D")]
			private CBMIKICCFNL <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400079E")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400079F")]
			private TaskAwaiter<BFBOEDNCMMM> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007A0")]
			private TaskAwaiter<PDHIEPEKDIL> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007A1")]
			private TaskAwaiter<CBMIKICCFNL> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0x8506D20", Offset = "0x8505F20", VA = "0x188506D20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x8507F20", Offset = "0x8507120", VA = "0x188507F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public IBMCGJPPEGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public NOBGLNGJEOC roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public AMCBFCIFFOH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public OEKDMCDJKCL roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public OPENMEHGDBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x8504FF0", Offset = "0x85041F0", VA = "0x188504FF0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<CBMIKICCFNL> IPCCCDCPCKL(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[CompilerGenerated]
	private struct MADBENCMJDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		public AsyncTaskMethodBuilder<CBMIKICCFNL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		public IBMCGJPPEGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		public NOBGLNGJEOC roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public AMCBFCIFFOH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public OEKDMCDJKCL roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		private TaskAwaiter<CBMIKICCFNL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x8500E30", Offset = "0x8500030", VA = "0x188500E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x8501160", Offset = "0x8500360", VA = "0x188501160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000766")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x4000767")]
	private static readonly FODGIOKBGBI JFIAIMAKOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000768")]
	private readonly ALEJNHMPADG HHLMBMFMNFE;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private MEBNIAGNGEK DDEKMBOMGEE
	{
		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x84C6F30", Offset = "0x84C6130", VA = "0x1884C6F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x84FDCE0", Offset = "0x84FCEE0", VA = "0x1884FDCE0")]
	public IBMCGJPPEGL(FBMKMKEAMFG DFANBODNJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x84FD980", Offset = "0x84FCB80", VA = "0x1884FD980")]
	[AsyncStateMachine(typeof(IJJAKIAKHPN))]
	private static Task<(CLLHCDHAJBH.OEKEMKNECIB, CLLHCDHAJBH.OEKEMKNECIB)> KDAABHCOFOH(LAMEDCHOMHL OIONFMJBFHJ, NOBGLNGJEOC FENKMKKCLAD, long BENLNHBBIME, long OECKHCOHBDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x84FD330", Offset = "0x84FC530", VA = "0x1884FD330")]
	[AsyncStateMachine(typeof(HHAMJPFEHHG))]
	public Task<PDHIEPEKDIL> GKGCGGIJEFC(int FBJJKIBIHMG, [CanBeNull] AMCBFCIFFOH EBNNDHKBAPE, NOBGLNGJEOC FENKMKKCLAD, long BENLNHBBIME, long OECKHCOHBDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x84FD630", Offset = "0x84FC830", VA = "0x1884FD630")]
	public static Task<PDHIEPEKDIL> GKGCGGIJEFC(LAMEDCHOMHL OIONFMJBFHJ, int FBJJKIBIHMG, [CanBeNull] AMCBFCIFFOH EBNNDHKBAPE, NOBGLNGJEOC FENKMKKCLAD, long BENLNHBBIME, long OECKHCOHBDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x84FD4A0", Offset = "0x84FC6A0", VA = "0x1884FD4A0")]
	[AsyncStateMachine(typeof(PHLDDIFDLNF))]
	public static Task<PDHIEPEKDIL> GKGCGGIJEFC(LAMEDCHOMHL OIONFMJBFHJ, int FBJJKIBIHMG, [CanBeNull] AMCBFCIFFOH EBNNDHKBAPE, NOBGLNGJEOC FENKMKKCLAD, long BENLNHBBIME, long OECKHCOHBDG, PMBENBIFFBO KPJEDEKLOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x84FDAD0", Offset = "0x84FCCD0", VA = "0x1884FDAD0")]
	[AsyncStateMachine(typeof(LHKLPGOAEIC))]
	private Task<BFBOEDNCMMM> OAIKDHHJJJL(string HKPLMIHOJLJ, int FBJJKIBIHMG, NOBGLNGJEOC FENKMKKCLAD, long BENLNHBBIME, long OECKHCOHBDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x84FD180", Offset = "0x84FC380", VA = "0x1884FD180")]
	[AsyncStateMachine(typeof(MADBENCMJDF))]
	public Task<CBMIKICCFNL> AGNNBKBLCNM(int FBJJKIBIHMG, AMCBFCIFFOH? EBNNDHKBAPE, NOBGLNGJEOC FENKMKKCLAD, long BENLNHBBIME, long OECKHCOHBDG, OEKDMCDJKCL JJKOKCGHAHO, EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
public abstract class MBMDNPFLDPJ<T> where T : MBMDNPFLDPJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007AE")]
	internal readonly MEBNIAGNGEK BMELPCOOEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007AF")]
	private int? IGJFMDPEDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007B0")]
	protected readonly Guid MKPBDMFKODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007B1")]
	protected readonly LGKCOAGJCFN EAEKPNNGBAP;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	protected T PBANNMBKCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x52D6140", Offset = "0x52D5340", VA = "0x1852D6140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x52D61A0", Offset = "0x52D53A0", VA = "0x1852D61A0")]
	internal MBMDNPFLDPJ(MEBNIAGNGEK OJHICHELAOA, LGKCOAGJCFN PBGOMDAJBLP, [Optional] Guid? BOAAABDJCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x52D6060", Offset = "0x52D5260", VA = "0x1852D6060")]
	private CBMIKICCFNL HCHKLKKLABA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	protected virtual void JJMGPAPABKJ(CBMIKICCFNL BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x52D5DF0", Offset = "0x52D4FF0", VA = "0x1852D5DF0")]
	public T CLCMDKLBGDP(KPDBONCIMNC MHLIPNBBNLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x52D5FC0", Offset = "0x52D51C0", VA = "0x1852D5FC0")]
	public T HALACGBOEPG(int HAINIAGJOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x52D5E90", Offset = "0x52D5090", VA = "0x1852D5E90", Slot = "5")]
	public virtual Task<BAKFNEOFNEC> DCJILOEAGKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public class GNEDCFKEHAA : MBMDNPFLDPJ<GNEDCFKEHAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007B2")]
	private IAAJJFDJPDA MGEJNDCFBJA;

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x84FC180", Offset = "0x84FB380", VA = "0x1884FC180")]
	internal GNEDCFKEHAA(MEBNIAGNGEK OJHICHELAOA, LGKCOAGJCFN PBGOMDAJBLP, [Optional] Guid? BOAAABDJCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x77631B0", Offset = "0x77623B0", VA = "0x1877631B0")]
	public GNEDCFKEHAA HIJDOEIJPMJ(IAAJJFDJPDA MGEJNDCFBJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x84FC0B0", Offset = "0x84FB2B0", VA = "0x1884FC0B0", Slot = "4")]
	protected override void JJMGPAPABKJ(CBMIKICCFNL BDAAPBJEHGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public class OBBAMKBGNID : MBMDNPFLDPJ<OBBAMKBGNID>
{
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	internal enum FIHJHCEONFD
	{
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007B8")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	[CompilerGenerated]
	private struct DJKADGPHMCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public AsyncTaskMethodBuilder<BAKFNEOFNEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public OBBAMKBGNID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		private TaskAwaiter<BAKFNEOFNEC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x84F81A0", Offset = "0x84F73A0", VA = "0x1884F81A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x84F8540", Offset = "0x84F7740", VA = "0x1884F8540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007B3")]
	private FIHJHCEONFD AKEALKCFAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007B4")]
	private string BMCAPBMOBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007B5")]
	private AMCBFCIFFOH MGEJNDCFBJA;

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x85042C0", Offset = "0x85034C0", VA = "0x1885042C0")]
	internal OBBAMKBGNID(MEBNIAGNGEK OJHICHELAOA, LGKCOAGJCFN PBGOMDAJBLP, [Optional] Guid? BOAAABDJCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x8504290", Offset = "0x8503490", VA = "0x188504290")]
	public OBBAMKBGNID NEIFLFGFEBF(string CMDDDPOOGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x85040E0", Offset = "0x85032E0", VA = "0x1885040E0")]
	public OBBAMKBGNID GEAMNDJOEMN(bool IPFLNPENGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x8504270", Offset = "0x8503470", VA = "0x188504270")]
	public OBBAMKBGNID JPPGKHIANMA(bool FBPCGFGCIKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x85040B0", Offset = "0x85032B0", VA = "0x1885040B0")]
	public OBBAMKBGNID FOBBELEGOGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x8504100", Offset = "0x8503300", VA = "0x188504100", Slot = "4")]
	protected override void JJMGPAPABKJ(CBMIKICCFNL BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x8503F80", Offset = "0x8503180", VA = "0x188503F80", Slot = "5")]
	[AsyncStateMachine(typeof(DJKADGPHMCO))]
	public override Task<BAKFNEOFNEC> DCJILOEAGKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x8504070", Offset = "0x8503270", VA = "0x188504070")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<BAKFNEOFNEC> ELAJAJPOFPC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
internal static class HFIEEKMBAMB
{
	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x84FCD20", Offset = "0x84FBF20", VA = "0x1884FCD20")]
	public static void NHFECGPGLCK(this GGCHOPOFBKB DJBNFODOLII, LDKIAIAGMBD FPACIHKBLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x84FCCA0", Offset = "0x84FBEA0", VA = "0x1884FCCA0")]
	public static void CIPIPOKDKBO(this LDKIAIAGMBD MDLGPLHBALF, [Optional] string BDAAPBJEHGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
public static class POMEGAPCFNF
{
	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x8505E10", Offset = "0x8505010", VA = "0x188505E10")]
	public static ELAGIFLJMJI ABPDDHHBLJB(this IJFPPBMLKKD MLFKMODPGPM)
	{
		return default(ELAGIFLJMJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x8505EB0", Offset = "0x85050B0", VA = "0x188505EB0")]
	public static IJFPPBMLKKD IIMDAFNJPPN(this ELAGIFLJMJI ODGNGHBNFNI)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001B7")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007C2")]
			public LIGHLHNEGBJ ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007C3")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007C4")]
			public LIGHLHNEGBJ HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007C5")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007C6")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007C7")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		private static LIGHLHNEGBJ[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		private Dictionary<LIGHLHNEGBJ, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x8508620", Offset = "0x8507820", VA = "0x188508620")]
		public bool KKGNADCLMGH(LIGHLHNEGBJ FFHCHELDDAC, [Out] ResultConfig EPCCHCFNMNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x85084E0", Offset = "0x85076E0", VA = "0x1885084E0")]
		public ResultConfig JFNODMFFGGL(LIGHLHNEGBJ BPAILNFLNFH, [Optional] HashSet<LIGHLHNEGBJ> CNCIHBPHJMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x8508C40", Offset = "0x8507E40", VA = "0x188508C40", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x8508690", Offset = "0x8507890", VA = "0x188508690", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0xBC3030", Offset = "0xBC2230", VA = "0x180BC3030")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
public class EHJIEDNJHJF : KBBKDEGOKGN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[CompilerGenerated]
	private struct FHDCLLABEAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		public EHJIEDNJHJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x84FAAB0", Offset = "0x84F9CB0", VA = "0x1884FAAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x84FAD40", Offset = "0x84F9F40", VA = "0x1884FAD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[CompilerGenerated]
	private struct PCGNANGIPJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		public KBBKDEGOKGN preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x8505120", Offset = "0x8504320", VA = "0x188505120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x85055D0", Offset = "0x85047D0", VA = "0x1885055D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007CD")]
	private readonly MMHICMAKPCJ JAEMFKOMIFC;

	[Cpp2IlInjected.Token(Token = "0x40007CE")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string JBKHCAHOLOM
	{
		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x84F8B50", Offset = "0x84F7D50", VA = "0x1884F8B50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x84F8AE0", Offset = "0x84F7CE0", VA = "0x1884F8AE0")]
	[DBIDCJGLKKO.BICJMLCNMCI.FCGHBDOAPKJ]
	internal static void IMCKJCIKHAK(HILJAABEPDC PHIACDDDGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EHJIEDNJHJF([ALHAHLCGLLK(null)] MMHICMAKPCJ JAEMFKOMIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x84F8B80", Offset = "0x84F7D80", VA = "0x1884F8B80", Slot = "5")]
	[AsyncStateMachine(typeof(FHDCLLABEAC))]
	public Task MENHHIHEOIL(EAIPOBMEIGP<string>.MNKIBAEKPMC PNMFADJPMPF, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x84F8C90", Offset = "0x84F7E90", VA = "0x1884F8C90")]
	[AsyncStateMachine(typeof(PCGNANGIPJL))]
	private Task MKCDFOLCLJA(KBBKDEGOKGN MGGOFABMKCA, EAIPOBMEIGP<string>.MNKIBAEKPMC PNMFADJPMPF, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
public interface MMHICMAKPCJ : KBBKDEGOKGN
{
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
public interface KBBKDEGOKGN
{
	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	string JBKHCAHOLOM
	{
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MENHHIHEOIL(EAIPOBMEIGP<string>.MNKIBAEKPMC PNMFADJPMPF, CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public static class JFLJGGJNHAK
{
	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x84FFEF0", Offset = "0x84FF0F0", VA = "0x1884FFEF0")]
	[DBIDCJGLKKO.BICJMLCNMCI.FCGHBDOAPKJ]
	internal static void OIIIADNPFIO(HILJAABEPDC PHIACDDDGBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public interface LDMGLHEANGA : IEquatable<LDMGLHEANGA>
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	DateTime KKNCEMPLEJB
	{
		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OBLPHJOOGOM();

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NIOCJDJBELC(long BENLNHBBIME, long DLHGMNACNGF, [Out] NOBGLNGJEOC FENKMKKCLAD);
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
internal class OOCPPAMMNCB : HDMDFMDDCIJ
{
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	[CompilerGenerated]
	private sealed class KFADEHHIHMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DE")]
		public KMPELHDOPPN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DF")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KFADEHHIHMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x8500460", Offset = "0x84FF660", VA = "0x188500460")]
		internal object MBINNMLJOIG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007DC")]
	private readonly KPLAHCAHFDL AGJNKLHHNBH;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<LDMGLHEANGA> PBNDMJKGHPD
	{
		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x85048A0", Offset = "0x8503AA0", VA = "0x1885048A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x8504D70", Offset = "0x8503F70", VA = "0x188504D70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	[UnityEngine.Scripting.Preserve]
	public OOCPPAMMNCB([ALHAHLCGLLK(null)] KPLAHCAHFDL AGJNKLHHNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x8504430", Offset = "0x8503630", VA = "0x188504430", Slot = "6")]
	public bool ALJECKCPJHN(long BENLNHBBIME, long DLHGMNACNGF, NOBGLNGJEOC FENKMKKCLAD, KMPELHDOPPN MNDHCACEDBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0xDC1A60", Offset = "0xDC0C60", VA = "0x180DC1A60")]
	private void OENFBPANLGJ(LDMGLHEANGA HGIBJDOBNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x8504730", Offset = "0x8503930", VA = "0x188504730", Slot = "7")]
	public bool CAEDHDJHOLC(long BENLNHBBIME, long DLHGMNACNGF, [Out] LDMGLHEANGA NCCNNAGALKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x8504E20", Offset = "0x8504020", VA = "0x188504E20", Slot = "8")]
	public bool MMCEIIAEHMP(long BENLNHBBIME, long DLHGMNACNGF, KMPELHDOPPN MNDHCACEDBN, [Out] LDMGLHEANGA NCCNNAGALKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x8504950", Offset = "0x8503B50", VA = "0x188504950")]
	private void IMODPKOFDNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x8504ED0", Offset = "0x85040D0", VA = "0x188504ED0", Slot = "9")]
	public void PECBNIMNOML(long BENLNHBBIME, long DLHGMNACNGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
internal abstract class NMAEMOGKCNJ : KPLAHCAHFDL
{
	[Cpp2IlInjected.Token(Token = "0x20001C4")]
	protected enum ILLPDKAIDEP : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[CompilerGenerated]
	private sealed class BGKAFNPMKBP : IEnumerable<LDMGLHEANGA>, IEnumerable, IEnumerator<LDMGLHEANGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		private LDMGLHEANGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		public NMAEMOGKCNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		private KMPELHDOPPN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		public KMPELHDOPPN <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private LDMGLHEANGA System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xE9E930", Offset = "0xE9DB30", VA = "0x180E9E930")]
		[DebuggerHidden]
		public BGKAFNPMKBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x84F74B0", Offset = "0x84F66B0", VA = "0x1884F74B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x84F7790", Offset = "0x84F6990", VA = "0x1884F7790", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x84F76E0", Offset = "0x84F68E0", VA = "0x1884F76E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LDMGLHEANGA> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x84F76E0", Offset = "0x84F68E0", VA = "0x1884F76E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[CompilerGenerated]
	private sealed class PFDNHOCMOOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		public KMPELHDOPPN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PFDNHOCMOOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x8505630", Offset = "0x8504830", VA = "0x188505630")]
		internal object OMENIJJKDDF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[CompilerGenerated]
	private sealed class NLFLDKAHPGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		public NMAEMOGKCNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public NLFLDKAHPGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x85027E0", Offset = "0x85019E0", VA = "0x1885027E0")]
		internal void PKAALFHKHBB(BMLFFJJDCHO.NBMNLIAFFHJ ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007E2")]
	private readonly object INCHIBFEGJH;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	protected string BIAKAOJHILB
	{
		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x8502E80", Offset = "0x8502080", VA = "0x188502E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public abstract ILEFIJBMDOP LPHEMNOAHDF
	{
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x85032A0", Offset = "0x85024A0", VA = "0x1885032A0")]
	protected NMAEMOGKCNJ([CanBeNull] string HLKBIMIBCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x85028D0", Offset = "0x8501AD0", VA = "0x1885028D0", Slot = "5")]
	public bool CGJONGDBKPE(long BENLNHBBIME, long DLHGMNACNGF, KMPELHDOPPN MNDHCACEDBN, [Out] LDMGLHEANGA HGIBJDOBNNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x8502E90", Offset = "0x8502090", VA = "0x188502E90", Slot = "6")]
	[IteratorStateMachine(typeof(BGKAFNPMKBP))]
	public IEnumerable<LDMGLHEANGA> HINCBFADNPK(KMPELHDOPPN MNDHCACEDBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void GFHNBDNHDAG(Stream HIJNDFGIGDA, long BENLNHBBIME, long DLHGMNACNGF, NOBGLNGJEOC FENKMKKCLAD);

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool LAKHKMMBNDM(Stream KEBAOPOOHIA, long BENLNHBBIME, long DLHGMNACNGF, PDJGKMLKNMF PFADEFPHJIN, [Out] NOBGLNGJEOC FENKMKKCLAD);

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x8502F20", Offset = "0x8502120", VA = "0x188502F20", Slot = "7")]
	public LDMGLHEANGA PLBOLKFGHGC(long BENLNHBBIME, long DLHGMNACNGF, NOBGLNGJEOC FENKMKKCLAD, KMPELHDOPPN MNDHCACEDBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo BONGPDIFBFP(long BENLNHBBIME, long DLHGMNACNGF, KMPELHDOPPN MNDHCACEDBN, ILLPDKAIDEP IKIFCMGFBDP);

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo DPNHKFKABMN(KMPELHDOPPN MNDHCACEDBN, ILLPDKAIDEP IKIFCMGFBDP);

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x8502860", Offset = "0x8501A60", VA = "0x188502860")]
	protected void ANFCKJFLOPE(BMLFFJJDCHO.NBMNLIAFFHJ EMMGKPBPPDN, string FNJOHGLGALB, FileInfo OPKLOGKACGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x8502AC0", Offset = "0x8501CC0", VA = "0x188502AC0")]
	internal bool ENLDBDBHGLD(FileInfo BEDPGIFICNI, long BENLNHBBIME, long DLHGMNACNGF, [Out] NOBGLNGJEOC FENKMKKCLAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	private void JIJIICHGIDP(Exception NNDKGEOCFFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
internal class NJIGONEKOAC : NMAEMOGKCNJ
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public override ILEFIJBMDOP LPHEMNOAHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x1252670", Offset = "0x1251870", VA = "0x181252670", Slot = "8")]
		get
		{
			return default(ILEFIJBMDOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x85027A0", Offset = "0x85019A0", VA = "0x1885027A0")]
	public NJIGONEKOAC([Optional] string HLKBIMIBCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x8501C80", Offset = "0x8500E80", VA = "0x188501C80")]
	private void CAPBJOAMKKF(KMPELHDOPPN MNDHCACEDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x8501E00", Offset = "0x8501000", VA = "0x188501E00", Slot = "9")]
	internal override void GFHNBDNHDAG(Stream HIJNDFGIGDA, long BENLNHBBIME, long DLHGMNACNGF, NOBGLNGJEOC FENKMKKCLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x85020B0", Offset = "0x85012B0", VA = "0x1885020B0", Slot = "10")]
	internal override bool LAKHKMMBNDM(Stream KEBAOPOOHIA, long BENLNHBBIME, long DLHGMNACNGF, PDJGKMLKNMF PFADEFPHJIN, [Out] NOBGLNGJEOC FENKMKKCLAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x8501B90", Offset = "0x8500D90", VA = "0x188501B90", Slot = "11")]
	protected override FileInfo BONGPDIFBFP(long BENLNHBBIME, long DLHGMNACNGF, KMPELHDOPPN MNDHCACEDBN, ILLPDKAIDEP IKIFCMGFBDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x8501D00", Offset = "0x8500F00", VA = "0x188501D00", Slot = "12")]
	protected override DirectoryInfo DPNHKFKABMN(KMPELHDOPPN MNDHCACEDBN, ILLPDKAIDEP IKIFCMGFBDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
internal sealed class FEAPDBDFEIC : NMAEMOGKCNJ
{
	[Cpp2IlInjected.Token(Token = "0x40007F2")]
	private static readonly byte[] AGBHGDFILGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007F3")]
	private readonly byte[] HHBLKEIGPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007F4")]
	private readonly byte[] HLAHAHAJHFK;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public override ILEFIJBMDOP LPHEMNOAHDF
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x17BAD90", Offset = "0x17B9F90", VA = "0x1817BAD90", Slot = "8")]
		get
		{
			return default(ILEFIJBMDOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x84FA350", Offset = "0x84F9550", VA = "0x1884FA350")]
	public FEAPDBDFEIC([Optional] string HLKBIMIBCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x84F9380", Offset = "0x84F8580", VA = "0x1884F9380", Slot = "9")]
	internal override void GFHNBDNHDAG(Stream HIJNDFGIGDA, long BENLNHBBIME, long DLHGMNACNGF, NOBGLNGJEOC FENKMKKCLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x84F9790", Offset = "0x84F8990", VA = "0x1884F9790", Slot = "10")]
	internal override bool LAKHKMMBNDM(Stream KEBAOPOOHIA, long BENLNHBBIME, long DLHGMNACNGF, PDJGKMLKNMF PFADEFPHJIN, [Out] NOBGLNGJEOC FENKMKKCLAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x84FA200", Offset = "0x84F9400", VA = "0x1884FA200")]
	private void OCEJMOHLNJN(byte[] FONJAIMABAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x84F9140", Offset = "0x84F8340", VA = "0x1884F9140", Slot = "11")]
	protected override FileInfo BONGPDIFBFP(long BENLNHBBIME, long DLHGMNACNGF, KMPELHDOPPN MNDHCACEDBN, ILLPDKAIDEP IKIFCMGFBDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x84F9270", Offset = "0x84F8470", VA = "0x1884F9270", Slot = "12")]
	protected override DirectoryInfo DPNHKFKABMN(KMPELHDOPPN MNDHCACEDBN, ILLPDKAIDEP IKIFCMGFBDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
public enum ILEFIJBMDOP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40007F8")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40007F9")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40007FA")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
internal class CNPFGIIPJEJ : KPLAHCAHFDL
{
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	[CompilerGenerated]
	private sealed class HFCFLIIALLA : IEnumerable<LDMGLHEANGA>, IEnumerable, IEnumerator<LDMGLHEANGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		private LDMGLHEANGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000803")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		public CNPFGIIPJEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		private KMPELHDOPPN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		public KMPELHDOPPN <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000807")]
		private ILEFIJBMDOP[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000808")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000809")]
		private IEnumerator<LDMGLHEANGA> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		private LDMGLHEANGA System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0xE9E930", Offset = "0xE9DB30", VA = "0x180E9E930")]
		[DebuggerHidden]
		public HFCFLIIALLA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x84FCC10", Offset = "0x84FBE10", VA = "0x1884FCC10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x84FC830", Offset = "0x84FBA30", VA = "0x1884FC830", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x84FC7E0", Offset = "0x84FB9E0", VA = "0x1884FC7E0")]
		private void CKKMGPGLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x84FCBC0", Offset = "0x84FBDC0", VA = "0x1884FCBC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x84FCB10", Offset = "0x84FBD10", VA = "0x1884FCB10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LDMGLHEANGA> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x84FCB10", Offset = "0x84FBD10", VA = "0x1884FCB10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007FB")]
	private readonly ILEFIJBMDOP[] HINGOHGBEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007FC")]
	private readonly Dictionary<ILEFIJBMDOP, KPLAHCAHFDL> KBGCMBGPNIN;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public ILEFIJBMDOP LPHEMNOAHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x84F79A0", Offset = "0x84F6BA0", VA = "0x1884F79A0", Slot = "4")]
		get
		{
			return default(ILEFIJBMDOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x84F7E00", Offset = "0x84F7000", VA = "0x1884F7E00")]
	[UnityEngine.Scripting.Preserve]
	public CNPFGIIPJEJ(params KPLAHCAHFDL[] EFOLOCEJLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x84F7850", Offset = "0x84F6A50", VA = "0x1884F7850", Slot = "5")]
	public bool CGJONGDBKPE(long BENLNHBBIME, long DLHGMNACNGF, KMPELHDOPPN MNDHCACEDBN, [Out] LDMGLHEANGA HGIBJDOBNNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x84F79D0", Offset = "0x84F6BD0", VA = "0x1884F79D0")]
	private void GMFMDHIDOHP(int MLJIHJADEHB, long BENLNHBBIME, long DLHGMNACNGF, KMPELHDOPPN MNDHCACEDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x84F7C10", Offset = "0x84F6E10", VA = "0x1884F7C10", Slot = "6")]
	[IteratorStateMachine(typeof(HFCFLIIALLA))]
	public IEnumerable<LDMGLHEANGA> HINCBFADNPK(KMPELHDOPPN MNDHCACEDBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x84F7CA0", Offset = "0x84F6EA0", VA = "0x1884F7CA0", Slot = "7")]
	public LDMGLHEANGA PLBOLKFGHGC(long BENLNHBBIME, long DLHGMNACNGF, NOBGLNGJEOC FENKMKKCLAD, KMPELHDOPPN MNDHCACEDBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
internal static class ENFCEAMEKKL
{
	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x84F8EA0", Offset = "0x84F80A0", VA = "0x1884F8EA0")]
	internal static byte[] JNBBNNMHMFM(byte[] FONJAIMABAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x84F8E20", Offset = "0x84F8020", VA = "0x1884F8E20")]
	public static void BHBFEKIOIBA(Stream KDAEEKGJCBE, byte[] NLCEDBFDGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x84F8F60", Offset = "0x84F8160", VA = "0x1884F8F60")]
	public static bool LNNNOAOEAGC(Stream KDAEEKGJCBE, long ENPKCDKDELH, PDJGKMLKNMF MMILEOLOJDO, [Out] byte[] AFJCADGHBCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
internal sealed class IPJOMCMDKFK : LDMGLHEANGA, IEquatable<LDMGLHEANGA>, IEquatable<IPJOMCMDKFK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400080A")]
	private readonly NMAEMOGKCNJ LNIPAPLOGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400080B")]
	public readonly FileInfo OMGGPKKAOFA;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public ILEFIJBMDOP LPHEMNOAHDF
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x7DD0F40", Offset = "0x7DD0140", VA = "0x187DD0F40", Slot = "9")]
		get
		{
			return default(ILEFIJBMDOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public DateTime KKNCEMPLEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x84FFB70", Offset = "0x84FED70", VA = "0x1884FFB70", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x84FFD70", Offset = "0x84FEF70", VA = "0x1884FFD70")]
	public IPJOMCMDKFK(NMAEMOGKCNJ EONEPHAGGHO, FileInfo BEDPGIFICNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(RVA = "0x84FFCC0", Offset = "0x84FEEC0", VA = "0x1884FFCC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x84FFC00", Offset = "0x84FEE00", VA = "0x1884FFC00", Slot = "5")]
	public void OBLPHJOOGOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x84FFB30", Offset = "0x84FED30", VA = "0x1884FFB30", Slot = "6")]
	public bool NIOCJDJBELC(long BENLNHBBIME, long DLHGMNACNGF, [Out] NOBGLNGJEOC FENKMKKCLAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x84FF970", Offset = "0x84FEB70", VA = "0x1884FF970", Slot = "7")]
	public bool Equals(LDMGLHEANGA FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x84FF9E0", Offset = "0x84FEBE0", VA = "0x1884FF9E0", Slot = "8")]
	public bool Equals(IPJOMCMDKFK FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(RVA = "0x84FF880", Offset = "0x84FEA80", VA = "0x1884FF880", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000758")]
	[Cpp2IlInjected.Address(RVA = "0x84FFAA0", Offset = "0x84FECA0", VA = "0x1884FFAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
public delegate void PDJGKMLKNMF(BMLFFJJDCHO.NBMNLIAFFHJ JNBHDCBKBFA, string BDAAPBJEHGD);
[Cpp2IlInjected.Token(Token = "0x20001D2")]
internal interface KPLAHCAHFDL
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	ILEFIJBMDOP LPHEMNOAHDF
	{
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600075C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CGJONGDBKPE(long BENLNHBBIME, long DLHGMNACNGF, KMPELHDOPPN MNDHCACEDBN, [Out] LDMGLHEANGA HGIBJDOBNNM);

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<LDMGLHEANGA> HINCBFADNPK(KMPELHDOPPN MNDHCACEDBN);

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LDMGLHEANGA PLBOLKFGHGC(long BENLNHBBIME, long DLHGMNACNGF, NOBGLNGJEOC FENKMKKCLAD, KMPELHDOPPN MNDHCACEDBN);
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
