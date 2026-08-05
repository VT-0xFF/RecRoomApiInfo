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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79CA860", Offset = "0x79C9660", VA = "0x1879CA860")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
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
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
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
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x79C7ED0", Offset = "0x79C6CD0", VA = "0x1879C7ED0", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79CBC10", Offset = "0x79CAA10", VA = "0x1879CBC10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BJNONFEDMLO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x79AEE80", Offset = "0x79ADC80", VA = "0x1879AEE80")]
	public BJNONFEDMLO(string KKBJAPCBOHH, Exception KHOADBPHPDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class ICEPLBJKJEF : LIBBCHECKAE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct KGCLDFHKMFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<KGAIHJLHFDH>> <>t__builder;

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
		private TaskAwaiter<AANCFLJFFNE<KGAIHJLHFDH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x79C5C10", Offset = "0x79C4A10", VA = "0x1879C5C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x79C5E50", Offset = "0x79C4C50", VA = "0x1879C5E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CLAHJBHGDFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<HIKBLHEAMEM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<HIKBLHEAMEM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x79B95B0", Offset = "0x79B83B0", VA = "0x1879B95B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x79B97C0", Offset = "0x79B85C0", VA = "0x1879B97C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	[UnityEngine.Scripting.Preserve]
	public ICEPLBJKJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x79C42A0", Offset = "0x79C30A0", VA = "0x1879C42A0", Slot = "4")]
	[AsyncStateMachine(typeof(KGCLDFHKMFK))]
	public Task<IReadOnlyList<KGAIHJLHFDH>> FCHDFNEOIKF(long OGMIFIGJENM, long FIAEJOGALJF, [Optional] CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x79C43C0", Offset = "0x79C31C0", VA = "0x1879C43C0", Slot = "5")]
	[AsyncStateMachine(typeof(CLAHJBHGDFI))]
	public Task<IReadOnlyList<HIKBLHEAMEM>> OHEANFGOFNJ(IReadOnlyList<int> ACCAPADPKMO, [Optional] CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NONHBFIIHII : IEquatable<NONHBFIIHII>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int HGLICOCFADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	HIKBLHEAMEM DFFEDPEBMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime DAELCIHAPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	KMJAIICLEBG? KILIOLCBELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	ECKBOPJCDIE? GGMPPBCAOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	NENBIGPJNNL HMPCIPAGENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<MDFDKOJBEAB> KABHGMACMDN();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum NENBIGPJNNL
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LIBBCHECKAE
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<KGAIHJLHFDH>> FCHDFNEOIKF(long OGMIFIGJENM, long FIAEJOGALJF, [Optional] CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<HIKBLHEAMEM>> OHEANFGOFNJ(IReadOnlyList<int> ACCAPADPKMO, [Optional] CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NJAPCABHMJK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class APNNEMHBLAD : NONHBFIIHII, IEquatable<NONHBFIIHII>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct EKCGJCPIADJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<MDFDKOJBEAB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public APNNEMHBLAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private CJPBMALJOBP <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<DGCCNGNLMNC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<MDFDKOJBEAB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x79BD000", Offset = "0x79BBE00", VA = "0x1879BD000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x79BD4C0", Offset = "0x79BC2C0", VA = "0x1879BD4C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly KGAIHJLHFDH EINOHAPDBBN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int HGLICOCFADE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8FAE20", Offset = "0x8F9C20", VA = "0x1808FAE20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HIKBLHEAMEM DFFEDPEBMIL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime BIPMBIPPHFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x640C8E0", Offset = "0x640B6E0", VA = "0x18640C8E0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KMJAIICLEBG? KILIOLCBELK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xC55430", Offset = "0xC54230", VA = "0x180C55430", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ECKBOPJCDIE? GGMPPBCAOHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x640C9E0", Offset = "0x640B7E0", VA = "0x18640C9E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NENBIGPJNNL HMPCIPAGENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA9F400", Offset = "0xA9E200", VA = "0x180A9F400", Slot = "10")]
			get
			{
				return default(NENBIGPJNNL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x79ADDB0", Offset = "0x79ACBB0", VA = "0x1879ADDB0", Slot = "9")]
		[AsyncStateMachine(typeof(EKCGJCPIADJ))]
		public Task<MDFDKOJBEAB> KABHGMACMDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x79ADEB0", Offset = "0x79ACCB0", VA = "0x1879ADEB0")]
		public APNNEMHBLAD(int LOODMBHPCMF, HIKBLHEAMEM GJJGDHOBJHH, KGAIHJLHFDH EINOHAPDBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x79ADCA0", Offset = "0x79ACAA0", VA = "0x1879ADCA0", Slot = "11")]
		public bool Equals(NONHBFIIHII LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x79ADC00", Offset = "0x79ACA00", VA = "0x1879ADC00", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x79ADBC0", Offset = "0x79AC9C0", VA = "0x1879ADBC0")]
		private bool BOELPDHOBPE(APNNEMHBLAD LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x79ADD30", Offset = "0x79ACB30", VA = "0x1879ADD30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class EOGGCIGDHLK : NONHBFIIHII, IEquatable<NONHBFIIHII>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct DKNGKHOCBHG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<MDFDKOJBEAB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public EOGGCIGDHLK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<MDFDKOJBEAB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x79BBE70", Offset = "0x79BAC70", VA = "0x1879BBE70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x79BC0C0", Offset = "0x79BAEC0", VA = "0x1879BC0C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly GFONHMBPIOH GPIJIFCJCEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly KMJAIICLEBG OIGLDCJMDAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly ECKBOPJCDIE LHDAKPANEAB;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int HGLICOCFADE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x79BDF40", Offset = "0x79BCD40", VA = "0x1879BDF40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public HIKBLHEAMEM DFFEDPEBMIL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x79BDF80", Offset = "0x79BCD80", VA = "0x1879BDF80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime BIPMBIPPHFG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x79BDE70", Offset = "0x79BCC70", VA = "0x1879BDE70", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public KMJAIICLEBG? KILIOLCBELK
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x79BDCD0", Offset = "0x79BCAD0", VA = "0x1879BDCD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ECKBOPJCDIE? GGMPPBCAOHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x79BE100", Offset = "0x79BCF00", VA = "0x1879BE100", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NENBIGPJNNL HMPCIPAGENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA9B090", Offset = "0xA99E90", VA = "0x180A9B090", Slot = "10")]
			get
			{
				return default(NENBIGPJNNL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1BF04D0", Offset = "0x1BEF2D0", VA = "0x181BF04D0")]
		public EOGGCIGDHLK(GFONHMBPIOH MCNBGALBPCJ, KMJAIICLEBG ABACKPPMOOO, ECKBOPJCDIE HJJHBACAHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x79BE010", Offset = "0x79BCE10", VA = "0x1879BE010", Slot = "9")]
		[AsyncStateMachine(typeof(DKNGKHOCBHG))]
		public Task<MDFDKOJBEAB> KABHGMACMDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x79BDDD0", Offset = "0x79BCBD0", VA = "0x1879BDDD0", Slot = "11")]
		public bool Equals(NONHBFIIHII LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x79BDD20", Offset = "0x79BCB20", VA = "0x1879BDD20", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x79BDC70", Offset = "0x79BCA70", VA = "0x1879BDC70")]
		private bool BOELPDHOBPE(EOGGCIGDHLK LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x79BDEC0", Offset = "0x79BCCC0", VA = "0x1879BDEC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class OPNMKDAPBNP : NONHBFIIHII, IEquatable<NONHBFIIHII>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct KPPDODPGLBE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<MDFDKOJBEAB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<MDFDKOJBEAB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x79C7270", Offset = "0x79C6070", VA = "0x1879C7270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x79C74D0", Offset = "0x79C62D0", VA = "0x1879C74D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly HIKBLHEAMEM LFBHKLFFCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly KMJAIICLEBG OIGLDCJMDAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly ECKBOPJCDIE LHDAKPANEAB;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int HGLICOCFADE
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x79CAFF0", Offset = "0x79C9DF0", VA = "0x1879CAFF0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public HIKBLHEAMEM DFFEDPEBMIL
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime BIPMBIPPHFG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public KMJAIICLEBG? KILIOLCBELK
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x79CAE20", Offset = "0x79C9C20", VA = "0x1879CAE20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public ECKBOPJCDIE? GGMPPBCAOHK
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x79CB0E0", Offset = "0x79C9EE0", VA = "0x1879CB0E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NENBIGPJNNL HMPCIPAGENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "10")]
			get
			{
				return default(NENBIGPJNNL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1BF04D0", Offset = "0x1BEF2D0", VA = "0x181BF04D0")]
		public OPNMKDAPBNP(HIKBLHEAMEM GJJGDHOBJHH, KMJAIICLEBG ABACKPPMOOO, ECKBOPJCDIE HJJHBACAHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x79CB010", Offset = "0x79C9E10", VA = "0x1879CB010", Slot = "9")]
		[AsyncStateMachine(typeof(KPPDODPGLBE))]
		public Task<MDFDKOJBEAB> KABHGMACMDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x79CAE70", Offset = "0x79C9C70", VA = "0x1879CAE70", Slot = "11")]
		public bool Equals(NONHBFIIHII LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x79CAEE0", Offset = "0x79C9CE0", VA = "0x1879CAEE0", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x79CAF60", Offset = "0x79C9D60", VA = "0x1879CAF60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x79CAD40", Offset = "0x79C9B40", VA = "0x1879CAD40")]
		private bool BOELPDHOBPE(OPNMKDAPBNP LHMPMCLNOPG)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct DBJLEMKMCCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<NONHBFIIHII>> <>t__builder;

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
		public NJAPCABHMJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<KGAIHJLHFDH> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<KGAIHJLHFDH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, HIKBLHEAMEM account, KGAIHJLHFDH roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x79B9FF0", Offset = "0x79B8DF0", VA = "0x1879B9FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x79BAE20", Offset = "0x79B9C20", VA = "0x1879BAE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct EOGGEKEBAJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, HIKBLHEAMEM account, KGAIHJLHFDH roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<KGAIHJLHFDH> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NJAPCABHMJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<HIKBLHEAMEM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x79BE150", Offset = "0x79BCF50", VA = "0x1879BE150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x79BEB50", Offset = "0x79BD950", VA = "0x1879BEB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MOAICGAOHEO PJGGLJDPEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly LIBBCHECKAE NEOBBGEIJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly CKBHPLBLHEH GMEBONPNNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly ECKFKDNALJK<(long, long), IReadOnlyList<KGAIHJLHFDH>> LELFNDKOODK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x79CA730", Offset = "0x79C9530", VA = "0x1879CA730")]
	[UnityEngine.Scripting.Preserve]
	public NJAPCABHMJK([MHFJPMCEEAM(null)] LIBBCHECKAE FMBIEKOJDLE, [MHFJPMCEEAM(null)] CKBHPLBLHEH OHLCOGBNMLC, [MHFJPMCEEAM(null)] MOAICGAOHEO MFKDPFECBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x79CA4D0", Offset = "0x79C92D0", VA = "0x1879CA4D0")]
	[AsyncStateMachine(typeof(DBJLEMKMCCA))]
	public Task<IList<NONHBFIIHII>> OOBKOMPJBJI(long OGMIFIGJENM, long MGNAIIKHEOI, bool ICGOGMHJCLI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x79CA330", Offset = "0x79C9130", VA = "0x1879CA330")]
	private bool OEABNKGMGOG(DateTime? MALEEKGOMNM, long OGMIFIGJENM, long MGNAIIKHEOI, [Out] GFONHMBPIOH MFPHOGLGEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x79CA620", Offset = "0x79C9420", VA = "0x1879CA620")]
	[AsyncStateMachine(typeof(EOGGEKEBAJK))]
	private Task<IReadOnlyList<(int, HIKBLHEAMEM, KGAIHJLHFDH)>> PKJEPCMKDIJ(IReadOnlyList<KGAIHJLHFDH> OJHOGIJNFGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CKBHPLBLHEH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GFONHMBPIOH> OGEFGDEDPHI;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IOGPHKOLJMF(long OGMIFIGJENM, long MGNAIIKHEOI, HHJNAOPPEEO OCJDGCBLJNF, BPFCEEPJHKL MAPIMEJAPGE);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FCCLDBAFCIC(long OGMIFIGJENM, long MGNAIIKHEOI, [Out] GFONHMBPIOH MFPHOGLGEEE);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EDFGJEGKOKL(long OGMIFIGJENM, long MGNAIIKHEOI, BPFCEEPJHKL MAPIMEJAPGE, [Out] GFONHMBPIOH MFPHOGLGEEE);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JOIPFIDIDFI(long OGMIFIGJENM, long MGNAIIKHEOI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface GLPAIIHJPGB : FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LPMEPFHLPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task MBHAHLGMKOP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HLPFJCFJLPA(Task BDCCICFJHCL, string DHOEOKFNDCP);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface JLPJEIGMNDF : FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MDFDKOJBEAB> BKFIHHEALPH(GFONHMBPIOH MFPHOGLGEEE);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KELCPGNAFBL(CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface AIFNHGMNCND : FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	HNHOJCCKBFA HLPIJKOFDPI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FDANBDKLEOH();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGIBAHBMJBP();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface FLGLKCKJMGB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JEELJGCJJCO(MLLAEEOLMLG FDPNEEAEJHK);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface DAHLKJIKMOB
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan IHOFDPJCEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan MJEOMIHJDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan HLOADGCDLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan EPMDJAKKABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool KOGJENHLGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool OAFCJCCPFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool CINOOFKJEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int KKFNHNLDLEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool FDNAPIFHMHI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool AEBFHGFEBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum GEIFHGKFFOF
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum ADNACPKIBIF
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
public struct KDCHDHEFHAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long JDAINGEBJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long FIAEJOGALJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly GEIFHGKFFOF OBDHBADPJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception AGLCPIMCHLP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x79C5670", Offset = "0x79C4470", VA = "0x1879C5670")]
	public KDCHDHEFHAG(long JDAINGEBJKE, long FIAEJOGALJF, GEIFHGKFFOF OBDHBADPJNM, [CanBeNull] Exception AGLCPIMCHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x79C5620", Offset = "0x79C4420", VA = "0x1879C5620")]
	public static KDCHDHEFHAG IFANBOIGHJP(NCNEODEEIGF EFFHEJGJIEE, GEIFHGKFFOF OBDHBADPJNM, [Optional] Exception AGLCPIMCHLP)
	{
		return default(KDCHDHEFHAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void MAAGCFFPAOA(KDCHDHEFHAG NGNJEIAEFMD);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface JEMLMLPEGHI : FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action CADDLEDCECK;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event MAAGCFFPAOA PNDCBDEOGAL;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MAAGCFFPAOA AMHGEBNCPNM;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event MAAGCFFPAOA BOKHBOEHOKM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<ADNACPKIBIF, bool> LHPLOFDCNMC;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IKBOEPGNDBE();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MBCBGEFGPGB(KDCHDHEFHAG NGNJEIAEFMD);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PHNGLDIHKBA(KDCHDHEFHAG NGNJEIAEFMD);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ADPFGGJNKFJ(KDCHDHEFHAG NGNJEIAEFMD);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EJCGJEAIFAK(ADNACPKIBIF OCBLIALNMGI, bool AAIFAFJIHJG);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface OFHBBGLGCJM : FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MAEKNOBKLLI();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HICLCJKNLOC();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface MHINNMMEEGD : FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus JGIAMPFODIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PJGNEJPGHPL(NCNEODEEIGF IPJPAHGOIMA, JHEDCICMDGH IDOCOHHFGNI, CancellationToken JHKFKNKNOJO);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class MLEOPIPLLFG
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x79C9BF0", Offset = "0x79C89F0", VA = "0x1879C9BF0")]
	public static bool GMMMOCNPFLC(this MHINNMMEEGD BLGDEPKIECP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate Task OCNMAGANFFL(CancellationToken HACFGBHNOCC, int NBBGNFGEDDB, BKBFPOLBAFH JJOKBEFEBKO);
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface PLPOEFPEGII : FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GHOJJCNFAJA(OCNMAGANFFL MONAAEJDMJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface MLLAEEOLMLG : CJPBMALJOBP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken JKCEGAKEJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	IEPIHLKICIO FIBLJBHNAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	JPDCMPIABBH DIJMFKPBAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	KELKPOFEJCB MFAFCLGIPEA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	INCEBAAAKHE GFIGBBNEHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NFJMELPFNIE CMAAODNPIGI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	ICNHOJHLBKE NNGCKKINNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HNACKPHJDOM BDODFNHOHPF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	IKHJLIGMDLA IKMFPOEHHNP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	GLPAIIHJPGB AOGPBGCNCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	JLPJEIGMNDF KENOOEADEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	JEMLMLPEGHI BBJBDGEFLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	OFHBBGLGCJM APLOAJCNFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	MHINNMMEEGD PBGOKPAMHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	PLPOEFPEGII KEPFPEIFJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	DMMJIOBMFDN KBNNGANOKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	DGHINKAGCDN IKBNKFMGFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KNKMJDCLLPB JPLECFOJEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CHABBDPDNKH PMBAIMGOHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	NPLKADIIGBP BCCKHPEDLNF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	NIDOHPOIPIJ ECAOPCCFFLM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	OGOGEKFANJN IONCLBALKEM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	JONNIPABEJF FLAPOFLJMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	FBAAMGCCCCN FBKNLMONEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	GOJPEFGLELG OJFGGHOGABN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	AIFNHGMNCND NKBJENMFJJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	DAHLKJIKMOB NNLFGAPGDEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	LHMKGGLEKIG MPNNPILFIDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	CKBHPLBLHEH OBBJBKAGLHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	MCGABFLMDLK MEHIKCEAGAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	GKHGIFENKMB CMBDDBGDCLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	CHIEPMBALCJ GGEMOLHDEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	LNKPOCDFECC ILALKJPHNCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	new bool ENEHBPFIBED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void MEKGHLDPMJA(JHEDCICMDGH CCAENAMLDOM);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface DMMJIOBMFDN : FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GPEDDNPHDFO MDGAONDGEMG(Guid KCDDPKBGHIL);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IEINLEAGPOE(Guid KCDDPKBGHIL);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MMNCCPLHCAN(Guid KCDDPKBGHIL, Task MCOPNMGDILD);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DNFOGFNNOJD(Guid KCDDPKBGHIL, MDFDKOJBEAB IAGCOGJPJDE);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(MDFDKOJBEAB, Task)> CLKEAEODMJD(Guid KCDDPKBGHIL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface BCBHOOACEHJ : FLGLKCKJMGB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface DGHINKAGCDN : FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFLOBPBPBOI(LJLDKNMPHBD KKBJAPCBOHH);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GALJMADPPGB(LJLDKNMPHBD KKBJAPCBOHH);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<KGAIIGHCNDA> HMJLMELNGCP(CancellationToken IFBIELIDEKN);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface KNKMJDCLLPB : FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GPEDDNPHDFO HCGPKNFOGFH(LJLDKNMPHBD BENIIKCNHBG);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJBCHOBOMED(Guid KCDDPKBGHIL, Task MCOPNMGDILD);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface CHABBDPDNKH : FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MDFDKOJBEAB> PMBAIMGOHCH(LJLDKNMPHBD ILCGOKLBNKC);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface NPLKADIIGBP : FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JAJOICLCDFI> BCMPFEKONHH(IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, NCNEODEEIGF IPJPAHGOIMA, CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface OGOGEKFANJN : FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MDFDKOJBEAB GGGHPCGLOML(NJGJGBGCLGP ONBBHAJKJFI);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CINHBMOIDOO(string FIJDAMLGBMN);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface NIDOHPOIPIJ : FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LJLDKNMPHBD> HKAKIEEACFN(LJLDKNMPHBD HJFGAIAKKLJ, GHHFOGHNCBC FCEFEKCHPGK, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<LJLDKNMPHBD> GALNCOMCBGN(CancellationToken FEHCANHDGHE, GHHFOGHNCBC FCEFEKCHPGK);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JHFDLGICCMM DAFMGFIECIN(DAODPIEPEBN ECFPIHLAFMH, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JHFDLGICCMM KHIIJFFGKFF(DAODPIEPEBN ECFPIHLAFMH, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface JONNIPABEJF : FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MDFDKOJBEAB NPPIEEDOOPL(NJGJGBGCLGP ONBBHAJKJFI, KGAIIGHCNDA HFPALCMEFCE);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MDFDKOJBEAB LBJPHNLCMIP(NJGJGBGCLGP LJNPHJCIEAL);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface FBAAMGCCCCN
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPECMJNPGPH(GAHOAOADPJI ICFCFOENMPG);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BICNGLIDDMP(GAHOAOADPJI ICFCFOENMPG);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FLBEEOJHOOK(GAHOAOADPJI ICFCFOENMPG);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CGNKGDMKMDP(GAHOAOADPJI ICFCFOENMPG);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class GAHOAOADPJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly NCNEODEEIGF MKBINGIFNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> DOFJDOEGEJE;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public IGPFJOOPHMK<string> NNGIICMJNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B10", Offset = "0x8F6910", VA = "0x1808F7B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	public GAHOAOADPJI(NCNEODEEIGF HBGCIECBLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x79BFAB0", Offset = "0x79BE8B0", VA = "0x1879BFAB0")]
	public GAHOAOADPJI OGLIHJLMCMI(string FFOHLCGHDKA, string IPHILEOFJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x79BFB80", Offset = "0x79BE980", VA = "0x1879BFB80")]
	public bool PMCEIGLCCII([Out] IEnumerable<KeyValuePair<string, string>> DKMIPBNAGBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6B0EC10", Offset = "0x6B0DA10", VA = "0x186B0EC10")]
	public GAHOAOADPJI KKKONDDLMFD(IGPFJOOPHMK<string> HPEGCCHCIAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface LHMKGGLEKIG
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool EKIOIMOPAIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string FLHLKPJMLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool PBDJGCGCAEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JOKKCDKIOLJ();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IBOMAMEIELM BMDILAMMAJC(long GPNMOJOEGPG);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BBEMAPAMDMB<HOAPPKHGKNJ, OLIDAEPNBCP> JGEFEMAJHKG(long GPNMOJOEGPG);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BBEMAPAMDMB<HOAPPKHGKNJ, PPNKBAMJHHC> AEMJPAPPLDN(long GPNMOJOEGPG);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BBEMAPAMDMB<long, GKEPDEDFEAB> EAJDAIFJDNG();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DACPFMLEGKE(long GPNMOJOEGPG, [Out] bool JBBKBFKFPKH);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> AHHAPHNGFPN(byte[] PDNPLFLMEMC, byte[] IDKPIPKAIEF, CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CJPBMALJOBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool GMMMOCNPFLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool GGMDMKBNPPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool ENEHBPFIBED
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	JHEDCICMDGH KGEHIBJAPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action CADDLEDCECK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event MAAGCFFPAOA PNDCBDEOGAL;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event MAAGCFFPAOA AMHGEBNCPNM;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MAAGCFFPAOA BOKHBOEHOKM;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<ADNACPKIBIF, bool> LHPLOFDCNMC;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HICLCJKNLOC();

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CEGDAGAFMIF AKKLKADBEAJ();

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	KFLNFPMFNCF BIPEDEAKAFA();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<MDFDKOJBEAB> BKFIHHEALPH(GFONHMBPIOH MCNBGALBPCJ);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task KELCPGNAFBL(CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface NFJMELPFNIE
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool ANOAHLFPMLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	string APPEAKPCMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCOJEJKDLME(Scene PEJEODNPGDN);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task NMHHILOLIOH(LAAFJKKHBBP KMODBGGNIHO, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task FFGKHAKNAND();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task KGHCHENFKIC();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface INCEBAAAKHE
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	PLHOCBJJMOF ILIBPHFOENB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool EHNKNAMNAMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool IBKFLCGMICD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool GGDBFHCGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool KMLKKEEHDEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	int HMOKLNMDJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool GCNIMFJKHNP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool NNCNEMPFBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	int EAHJCBAPOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	int CBMCPKLFPOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool FFOFEKNCOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool OKBGPDIHIOI
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool DBOJEBPDAEK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	float AFMHKIKBAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> AMOMFFPMNJH;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEPIHLKICIO NBMJNKHJLAE(IEPIHLKICIO MBHFIPEOKPA);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FPNJBHIKJPN(IEPIHLKICIO BCNFHKMHIOK);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DOLBPEJHLKG();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task LCJCAJKHEEL(IGPFJOOPHMK<string>.PDLCJKJEJBF LAOODCKDFLJ, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LMANKIIBLIL(float OCOHPHKFBOI);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GPKKHGDIMKF(string FDOHOLOFKDI);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<DADKOHLCLHL> HBHDCPJIIHJ();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable CEIOMAKGINA(object MOBMLKIIAJP, DADKOHLCLHL EPJFIIMKBMG);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<ILBEHEIANIK> JGBNHNJMLDK();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	OLIDAEPNBCP AHHPPLEONGF(IEnumerable<DACMPOAMDBF> NOOBFGDNPPE);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AJFDOHGDCAA(int KAKBGJICBGD);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task PIOGNBJLAIA();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HPFLHNALJHF();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool JBPKCFOIIFO();

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task PEPBJDECKCL(CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task LMEKILFMNHE(CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<CAOOGOEBJJH> KFDMGOIHOEH(DateTime DIMJJDHACKM, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> LCHNLLIPCMI(CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IOFIHEFNBMK(string KKBJAPCBOHH = "", float ENFBFHBOFDG = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "25")]
	ANMNGACNHED OJJMGFAINGI(AAOEHFDAHGE PFKEDCLDLDD, BEPIOHBDIFE FLIOBDGHCMA, PPNKBAMJHHC BGCDDBLLNAB, IEnumerable<PersistenceView> MJMMOJPFBMG, HDFFBIDJGIE IGKBCMGONPM);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GEFLHIHJCLO(PPNKBAMJHHC BGCDDBLLNAB);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void HPLHLAHLNFL(DACMPOAMDBF HCOLLOKLDBB, [In] ANMNGACNHED BPKDPANDGEC);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task AEADPAFBDHC(PPNKBAMJHHC CMLNEKGHNFK, bool FDDGMOILIAF, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task OJLMGCGILIG(CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MLILJPELHAF(long OGMIFIGJENM, long FIAEJOGALJF, DGCCNGNLMNC KGMCCCOKBDB, KGAIHJLHFDH CHICMOEPFKB, HHJNAOPPEEO OCJDGCBLJNF, HHDDNHJGPBH? GPJDHCNHKAI, MMFABIGAOLJ? EILNEAFHKMN);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void PAOAPFJLFBG(long OGMIFIGJENM, long FIAEJOGALJF, MMFABIGAOLJ? EILNEAFHKMN);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void EEPMDBLHHDG(PersistenceView BPOBPIPFBCJ);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool PLLPPCJOONP(PersistenceView FHOIFELJGJL);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool JJHEHECIBKP(DACMPOAMDBF HCOLLOKLDBB, JNOHDJLMBEA KPICEBLCLHP, [Out] HMBCJHCCMMO DAKGPJGKLJL);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task ACFBFHEPFOD(CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void DMDGANHIJNI();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable LMKLOONHLPP();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void AEDDMPLCJHH(PPNKBAMJHHC CMLNEKGHNFK, JNOHDJLMBEA KPICEBLCLHP);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> ACMMAEEAGCI(JPDCMPIABBH JGDMKGHAADE, CancellationToken FEHCANHDGHE, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void KMHEGMKCIMK(CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<LBFPONJCALF> KHJAOBGNBNM(OFEGBDGNOKK HJFGAIAKKLJ);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<DGCCNGNLMNC> CCKBCCPFJKH(long OGMIFIGJENM, bool OBAGAJECGNK, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<KGAIHJLHFDH> DOFPBALPHIF(long OGMIFIGJENM, long FIAEJOGALJF, long BNKDNHLBLJC, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<KGAIHJLHFDH> PCLCCGJPDON(long OGMIFIGJENM, long FIAEJOGALJF, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<BCOPHPGONJP> HDDDFGALPJB(string BOHOGABJBDK, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<BCOPHPGONJP> NFDJKDBLBAM(string BOHOGABJBDK, long OGMIFIGJENM, long FIAEJOGALJF, string BDGGACIHCDD, PDKLFCMALOG.IPGJLKDJHHK BGIEPHNJHFK, PDKLFCMALOG.IPGJLKDJHHK IDKPIPKAIEF, int HJIDJEJFNED);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool DECOIDIJAGP();

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool MFPJDNJAFDN();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool LFFHFOGILDM(IEnumerable<HMBCJHCCMMO> FEBFKFNNAEB);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void BPMGHDHIOOP(List<GameObject> CIKMCGECPBK);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "52")]
	float JHOHJJMCCDC();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task<Scene> ACIGDHHHCJH(string GJJPEGOGGEA, LoadSceneMode PHFGHJEJLIK, bool AHMINMKHLLM, IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void FHEFIBDHDMA();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void FFJIHLEJILC(bool KKHNIMMKCDA);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void DPDNFNMINMD();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void OPFCFAHEFGG();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void BKGCCKLKEJO(NCNEODEEIGF EMFNNNOAGFD);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task LHFHEEPGKCH(IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task NOGGKCPNGCI(IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "70")]
	Task MECIHADNDNH(IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task HNHIFFNPAHD(IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "72")]
	IDisposable CKJEKKFBADP();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "73")]
	NFELCOGLGCD HABGOHCAMDC();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task MOCGHEOEENN(CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface NFELCOGLGCD
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KKDPLCJKLFG(CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PAMFLFCKBLN(CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct ANMNGACNHED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> CDIKMKOJKAI;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum CAOOGOEBJJH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct AAOEHFDAHGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string BLNOKFAPNDF;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface PLHOCBJJMOF
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	NCNEODEEIGF EJMMCAKMIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	DGCCNGNLMNC GPMOJLHFLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	DADBLAJODHB LLMHEBIKLLO
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool GJGCKOIGPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool JAFBLIOADCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	int ACOKEIMNLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action BCMALHPNDPM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> HIIKGKEKOLJ;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FHDECLJAFGC();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.CMJKCGBCIJI> LIEOLNDODCA(long GPNMOJOEGPG, [Optional] CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<CIHMFMKDMKE> DNBFEHGFJPG();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task FIOFLLAOHIJ();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(NCNEODEEIGF, JHEDCICMDGH) CECGOCHLMOA();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DLPEEKOIOEF HJAJEPIBJNN();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DDJAECEMGIC(long GPNMOJOEGPG);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PGBHJLCENGG(NCNEODEEIGF HBGCIECBLBO, Matchmaking.GKGGJJKLLNP LDEANEOLAOA, (int Major, int? Minor)? INHEKIONAPA);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface GOJPEFGLELG
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HFCAENMCIFL([Out] IEnumerable<int> LODNFJCDKMG);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFNFDAFEGCO(LNJPDINAFGA HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GFFDAOLJGMK(LNJPDINAFGA HACFGBHNOCC);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface NIBCMKHNMFF
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DHEFMMOFGLA(MDFDKOJBEAB FDBNMLEAMHD);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface MKFMNDJHFCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHMLOOMENHD(GBIAJKIANDF.PPIPOGJEPJF NHFKNKHCAME);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKPOLNFCPHP(GBIAJKIANDF.PPIPOGJEPJF NHFKNKHCAME);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface ICNHOJHLBKE : MKFMNDJHFCF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MDFDKOJBEAB HFACFHMOJEJ(NJGJGBGCLGP LJNPHJCIEAL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface HNACKPHJDOM : MKFMNDJHFCF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MDFDKOJBEAB GGGHPCGLOML(NJGJGBGCLGP ANICBEHNGEM);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface IBOMAMEIELM
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PGOLMGNGGBM<LAAFJKKHBBP, MFMDDJMMGHP>> EDPDNNBKNNK(string BDGGACIHCDD, long GPNMOJOEGPG, long? OGMIFIGJENM, long? FIAEJOGALJF, CLICDMBAIMF.CHGKBFNLDNA ODOOICLIBOB, CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface BBEMAPAMDMB<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PGOLMGNGGBM<BJKDDMAILKD<TData>, MFMDDJMMGHP>> IFMMMOFJMHL(TGetDataArg BFLKHJBBCJI, CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class DEOEOPHLFHL : MLLAEEOLMLG, CJPBMALJOBP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct KAHPMMLINNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder<MDFDKOJBEAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public DEOEOPHLFHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public GFONHMBPIOH autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter<MDFDKOJBEAB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x79C5330", Offset = "0x79C4130", VA = "0x1879C5330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x79C55B0", Offset = "0x79C43B0", VA = "0x1879C55B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct OMENFOOJMNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public DEOEOPHLFHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x79CAAB0", Offset = "0x79C98B0", VA = "0x1879CAAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x79CACE0", Offset = "0x79C9AE0", VA = "0x1879CACE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class HFKBCLHGCMH : IEnumerable<FLGLKCKJMGB>, IEnumerable, IEnumerator<FLGLKCKJMGB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private FLGLKCKJMGB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public DEOEOPHLFHL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		private FLGLKCKJMGB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xC3B4C0", Offset = "0xC3A2C0", VA = "0x180C3B4C0")]
		[DebuggerHidden]
		public HFKBCLHGCMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x79C32D0", Offset = "0x79C20D0", VA = "0x1879C32D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x79C3730", Offset = "0x79C2530", VA = "0x1879C3730", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x79C3680", Offset = "0x79C2480", VA = "0x1879C3680", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FLGLKCKJMGB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x79C3680", Offset = "0x79C2480", VA = "0x1879C3680", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource JFNEFBHOHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly IEPIHLKICIO BCNFHKMHIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool BBDDFKFCEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private KCKIGIMFHMI COEENNJABNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private bool EEKIENNGJAL;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public JPDCMPIABBH DIJMFKPBAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8F4230", Offset = "0x8F3030", VA = "0x1808F4230", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8F4250", Offset = "0x8F3050", VA = "0x1808F4250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public KELKPOFEJCB MFAFCLGIPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8F4260", Offset = "0x8F3060", VA = "0x1808F4260", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8F4470", Offset = "0x8F3270", VA = "0x1808F4470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public INCEBAAAKHE GFIGBBNEHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8FBB10", Offset = "0x8FA910", VA = "0x1808FBB10", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8FBB20", Offset = "0x8FA920", VA = "0x1808FBB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public NFJMELPFNIE CMAAODNPIGI
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8F4450", Offset = "0x8F3250", VA = "0x1808F4450", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4220", Offset = "0x8F3020", VA = "0x1808F4220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public ICNHOJHLBKE NNGCKKINNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8F4240", Offset = "0x8F3040", VA = "0x1808F4240", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8F44D0", Offset = "0x8F32D0", VA = "0x1808F44D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public HNACKPHJDOM BDODFNHOHPF
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8FC440", Offset = "0x8FB240", VA = "0x1808FC440", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8FC390", Offset = "0x8FB190", VA = "0x1808FC390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public IKHJLIGMDLA IKMFPOEHHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8FC450", Offset = "0x8FB250", VA = "0x1808FC450", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8FC3E0", Offset = "0x8FB1E0", VA = "0x1808FC3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public GLPAIIHJPGB AOGPBGCNCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8FC330", Offset = "0x8FB130", VA = "0x1808FC330", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8FC490", Offset = "0x8FB290", VA = "0x1808FC490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public JLPJEIGMNDF KENOOEADEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA9F410", Offset = "0xA9E210", VA = "0x180A9F410", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1133CC0", Offset = "0x1132AC0", VA = "0x181133CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public JEMLMLPEGHI BBJBDGEFLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8FC480", Offset = "0x8FB280", VA = "0x1808FC480", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8FC2E0", Offset = "0x8FB0E0", VA = "0x1808FC2E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public OFHBBGLGCJM APLOAJCNFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xB9BD70", Offset = "0xB9AB70", VA = "0x180B9BD70", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xCFF660", Offset = "0xCFE460", VA = "0x180CFF660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public MHINNMMEEGD PBGOKPAMHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x904730", Offset = "0x903530", VA = "0x180904730", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x904790", Offset = "0x903590", VA = "0x180904790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public PLPOEFPEGII KEPFPEIFJMC
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xAD87F0", Offset = "0xAD75F0", VA = "0x180AD87F0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xD01130", Offset = "0xCFFF30", VA = "0x180D01130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public DMMJIOBMFDN KBNNGANOKIN
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xBF3340", Offset = "0xBF2140", VA = "0x180BF3340", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xBF3350", Offset = "0xBF2150", VA = "0x180BF3350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public BCBHOOACEHJ INNHPFAPCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xB9BBA0", Offset = "0xB9A9A0", VA = "0x180B9BBA0", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xFB1CB0", Offset = "0xFB0AB0", VA = "0x180FB1CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public DGHINKAGCDN IKBNKFMGFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xB86D40", Offset = "0xB85B40", VA = "0x180B86D40", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xC09820", Offset = "0xC08620", VA = "0x180C09820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public KNKMJDCLLPB JPLECFOJEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA67EE0", Offset = "0xA66CE0", VA = "0x180A67EE0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA68070", Offset = "0xA66E70", VA = "0x180A68070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public CHABBDPDNKH PMBAIMGOHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x904780", Offset = "0x903580", VA = "0x180904780", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x904760", Offset = "0x903560", VA = "0x180904760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public NPLKADIIGBP BCCKHPEDLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA222B0", Offset = "0xA210B0", VA = "0x180A222B0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA59010", Offset = "0xA57E10", VA = "0x180A59010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public NIDOHPOIPIJ ECAOPCCFFLM
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9B47A0", Offset = "0x9B35A0", VA = "0x1809B47A0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6C0", Offset = "0xA694C0", VA = "0x180A6A6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public OGOGEKFANJN IONCLBALKEM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x984520", Offset = "0x983320", VA = "0x180984520", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA6AB60", Offset = "0xA69960", VA = "0x180A6AB60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public JONNIPABEJF FLAPOFLJMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x969740", Offset = "0x968540", VA = "0x180969740", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA59030", Offset = "0xA57E30", VA = "0x180A59030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public FBAAMGCCCCN FBKNLMONEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA59510", Offset = "0xA58310", VA = "0x180A59510", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA64570", Offset = "0xA63370", VA = "0x180A64570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public GOJPEFGLELG OJFGGHOGABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA59430", Offset = "0xA58230", VA = "0x180A59430", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA59050", Offset = "0xA57E50", VA = "0x180A59050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public AIFNHGMNCND NKBJENMFJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xBEDD00", Offset = "0xBECB00", VA = "0x180BEDD00", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xBEE300", Offset = "0xBED100", VA = "0x180BEE300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public DAHLKJIKMOB NNLFGAPGDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA1CDC0", Offset = "0xA1BBC0", VA = "0x180A1CDC0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA22F40", Offset = "0xA21D40", VA = "0x180A22F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public LHMKGGLEKIG MPNNPILFIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9AE770", Offset = "0x9AD570", VA = "0x1809AE770", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9B5170", Offset = "0x9B3F70", VA = "0x1809B5170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public CKBHPLBLHEH OBBJBKAGLHB
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x97E860", Offset = "0x97D660", VA = "0x18097E860", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public MCGABFLMDLK MEHIKCEAGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9628B0", Offset = "0x9616B0", VA = "0x1809628B0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public GKHGIFENKMB CMBDDBGDCLO
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x97DFE0", Offset = "0x97CDE0", VA = "0x18097DFE0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public CHIEPMBALCJ GGEMOLHDEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x962140", Offset = "0x960F40", VA = "0x180962140", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public LNKPOCDFECC ILALKJPHNCD
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x96DA80", Offset = "0x96C880", VA = "0x18096DA80", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public JHEDCICMDGH KGEHIBJAPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x96E700", Offset = "0x96D500", VA = "0x18096E700", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x12093A0", Offset = "0x12081A0", VA = "0x1812093A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private bool LMGIPMKNNEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x79BB0E0", Offset = "0x79B9EE0", VA = "0x1879BB0E0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private bool IMCMOKPLKLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x79BB310", Offset = "0x79BA110", VA = "0x1879BB310", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private bool FDLGEPFJADM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x1193C50", Offset = "0x1192A50", VA = "0x181193C50", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private CancellationToken AEPOLKNHFOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x79BB4E0", Offset = "0x79BA2E0", VA = "0x1879BB4E0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private IEPIHLKICIO KEFMOMEOEFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private bool PPGPMGPLIIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1193C50", Offset = "0x1192A50", VA = "0x181193C50", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x118D680", Offset = "0x118C480", VA = "0x18118D680", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action DLKCMAJJNLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x79BB930", Offset = "0x79BA730", VA = "0x1879BB930", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x79BB990", Offset = "0x79BA790", VA = "0x1879BB990", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event MAAGCFFPAOA JBLLLMBOEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x79BB700", Offset = "0x79BA500", VA = "0x1879BB700", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x79BB2B0", Offset = "0x79BA0B0", VA = "0x1879BB2B0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event MAAGCFFPAOA IKINDEKGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x79BB480", Offset = "0x79BA280", VA = "0x1879BB480", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x79BAE90", Offset = "0x79B9C90", VA = "0x1879BAE90", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event MAAGCFFPAOA KCPKADMLPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x79BB640", Offset = "0x79BA440", VA = "0x1879BB640", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x79BB760", Offset = "0x79BA560", VA = "0x1879BB760", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<ADNACPKIBIF, bool> GCPNAHCOGEI
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x79BB850", Offset = "0x79BA650", VA = "0x1879BB850", Slot = "48")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x79BB250", Offset = "0x79BA050", VA = "0x1879BB250", Slot = "49")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x12093A0", Offset = "0x12081A0", VA = "0x1812093A0", Slot = "39")]
	public void MEKGHLDPMJA(JHEDCICMDGH CCAENAMLDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x79BB9F0", Offset = "0x79BA7F0", VA = "0x1879BB9F0")]
	[UnityEngine.Scripting.Preserve]
	internal DEOEOPHLFHL([MHFJPMCEEAM(null)] IEPIHLKICIO BCNFHKMHIOK, [MHFJPMCEEAM(null)] JPDCMPIABBH JGDMKGHAADE, [MHFJPMCEEAM(null)] KELKPOFEJCB AEGNKLJBMKL, [MHFJPMCEEAM(null)] INCEBAAAKHE BPGIOHMMDAI, [MHFJPMCEEAM(null)] NFJMELPFNIE ENOBJPLAHPF, [MHFJPMCEEAM(null)] ICNHOJHLBKE MIGKBMABFPK, [MHFJPMCEEAM(null)] HNACKPHJDOM GDJKMEBAFNF, [MHFJPMCEEAM(null)] IKHJLIGMDLA PJICLILFLCE, [MHFJPMCEEAM(null)] GLPAIIHJPGB GDHDLLHDNJC, [MHFJPMCEEAM(null)] JLPJEIGMNDF OKMOOMEIOOO, [MHFJPMCEEAM(null)] JEMLMLPEGHI LFLBNOFMAHN, [MHFJPMCEEAM(null)] OFHBBGLGCJM KOIHEHKELBJ, [MHFJPMCEEAM(null)] MHINNMMEEGD BLGDEPKIECP, [MHFJPMCEEAM(null)] PLPOEFPEGII OIGGONMAIHF, [MHFJPMCEEAM(null)] DMMJIOBMFDN OOGIBHFCIJF, [MHFJPMCEEAM(null)] BCBHOOACEHJ BFAMFBPKKLB, [MHFJPMCEEAM(null)] DGHINKAGCDN FEAHNPLABHC, [MHFJPMCEEAM(null)] KNKMJDCLLPB CKIHIPHEGCD, [MHFJPMCEEAM(null)] CHABBDPDNKH EAMBELFKCCL, [MHFJPMCEEAM(null)] NPLKADIIGBP OIGLNJLKCKO, [MHFJPMCEEAM(null)] OGOGEKFANJN DLEKJGHPHOI, [MHFJPMCEEAM(null)] NIDOHPOIPIJ PEOCKDDEKNJ, [MHFJPMCEEAM(null)] JONNIPABEJF GKMJNCPIFBJ, [MHFJPMCEEAM(null)] FBAAMGCCCCN DPODLACBKEP, [MHFJPMCEEAM(null)] GOJPEFGLELG IOJCBPLMEGH, [MHFJPMCEEAM(null)] DAHLKJIKMOB LHCHLNOABPH, [MHFJPMCEEAM(null)] LHMKGGLEKIG FKIPJCBIEOL, [MHFJPMCEEAM(null)] CKBHPLBLHEH EBFLBKEIEJP, [MHFJPMCEEAM(null)] MCGABFLMDLK IMNGJMLKNLD, [MHFJPMCEEAM(null)] GKHGIFENKMB ELFLKDBDJPD, [MHFJPMCEEAM(null)] CHIEPMBALCJ JAKFGGFGGIH, [MHFJPMCEEAM(null)] LNKPOCDFECC KPBECGJGAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x79BB590", Offset = "0x79BA390", VA = "0x1879BB590")]
	private void JEELJGCJJCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x79BAEF0", Offset = "0x79B9CF0", VA = "0x1879BAEF0", Slot = "59")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x79BB090", Offset = "0x79B9E90", VA = "0x1879BB090", Slot = "53")]
	private void ENCFLPKEBAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x79BB500", Offset = "0x79BA300", VA = "0x1879BB500", Slot = "54")]
	private CEGDAGAFMIF IHKIADIBBLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x79BB7C0", Offset = "0x79BA5C0", VA = "0x1879BB7C0", Slot = "55")]
	private KFLNFPMFNCF MIPFKAIDMEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x79BB140", Offset = "0x79B9F40", VA = "0x1879BB140", Slot = "56")]
	[AsyncStateMachine(typeof(KAHPMMLINNK))]
	private Task<MDFDKOJBEAB> FLMCDFAJFEM(GFONHMBPIOH MFPHOGLGEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x79BB390", Offset = "0x79BA190", VA = "0x1879BB390", Slot = "57")]
	[AsyncStateMachine(typeof(OMENFOOJMNA))]
	private Task GIHOHKPFHNO(CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x79BB8B0", Offset = "0x79BA6B0", VA = "0x1879BB8B0")]
	[IteratorStateMachine(typeof(HFKBCLHGCMH))]
	private IEnumerable<FLGLKCKJMGB> PFECAEBGGMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x79BB6A0", Offset = "0x79BA4A0", VA = "0x1879BB6A0")]
	[CompilerGenerated]
	private void KCMPLPAHNHH(FLGLKCKJMGB MMJIAOCMCPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class OGCKIKHJANL : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1583720", Offset = "0x1582520", VA = "0x181583720")]
	public OGCKIKHJANL(string KKBJAPCBOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class BBKJPNKHAHM : OMIJOPMOGOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct FGIFHGMPBBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public BBKJPNKHAHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x79BEFA0", Offset = "0x79BDDA0", VA = "0x1879BEFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x79BF2E0", Offset = "0x79BE0E0", VA = "0x1879BF2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MLLAEEOLMLG FDPNEEAEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly INCEBAAAKHE BPGIOHMMDAI;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x904660", Offset = "0x903460", VA = "0x180904660")]
	public BBKJPNKHAHM(MLLAEEOLMLG FDPNEEAEJHK, INCEBAAAKHE BPGIOHMMDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x79ADF10", Offset = "0x79ACD10", VA = "0x1879ADF10", Slot = "4")]
	[AsyncStateMachine(typeof(FGIFHGMPBBJ))]
	public Task<bool> CPHKMDEBMOF(CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x79AE000", Offset = "0x79ACE00", VA = "0x1879AE000")]
	[CompilerGenerated]
	private object MAGPJEFBPMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class HFDFCMMPJJG : OMIJOPMOGOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct GMDOJCFGPKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public HFDFCMMPJJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x79BFC10", Offset = "0x79BEA10", VA = "0x1879BFC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x79C0350", Offset = "0x79BF150", VA = "0x1879C0350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly MLLAEEOLMLG FDPNEEAEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly INCEBAAAKHE BPGIOHMMDAI;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private PLHOCBJJMOF ILIBPHFOENB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x79C3070", Offset = "0x79C1E70", VA = "0x1879C3070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x904660", Offset = "0x903460", VA = "0x180904660")]
	public HFDFCMMPJJG(MLLAEEOLMLG FDPNEEAEJHK, INCEBAAAKHE BPGIOHMMDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x79C30C0", Offset = "0x79C1EC0", VA = "0x1879C30C0", Slot = "4")]
	[AsyncStateMachine(typeof(GMDOJCFGPKD))]
	public Task<bool> CPHKMDEBMOF(CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x79C31F0", Offset = "0x79C1FF0", VA = "0x1879C31F0")]
	[CompilerGenerated]
	private object NDMEOPLBCCO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class KJIIDEAMMPH : OMIJOPMOGOA
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class LPHDFLMKDBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public KJIIDEAMMPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CIHMFMKDMKE result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public NCNEODEEIGF newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public LPHDFLMKDBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x79C7D40", Offset = "0x79C6B40", VA = "0x1879C7D40")]
		internal object MHJPPPOJKCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x79C7CD0", Offset = "0x79C6AD0", VA = "0x1879C7CD0")]
		internal object KEMKEPHKHLG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x79C7E30", Offset = "0x79C6C30", VA = "0x1879C7E30")]
		internal object NIIIOIPPBJE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct CAMGFCIPLIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public KJIIDEAMMPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private LPHDFLMKDBC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<CIHMFMKDMKE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x79AF6D0", Offset = "0x79AE4D0", VA = "0x1879AF6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x79B0080", Offset = "0x79AEE80", VA = "0x1879B0080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly MLLAEEOLMLG FDPNEEAEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly INCEBAAAKHE BPGIOHMMDAI;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private PLHOCBJJMOF ILIBPHFOENB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x79C5EC0", Offset = "0x79C4CC0", VA = "0x1879C5EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x904660", Offset = "0x903460", VA = "0x180904660")]
	public KJIIDEAMMPH(MLLAEEOLMLG FDPNEEAEJHK, INCEBAAAKHE BPGIOHMMDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x79C5F10", Offset = "0x79C4D10", VA = "0x1879C5F10", Slot = "4")]
	[AsyncStateMachine(typeof(CAMGFCIPLIC))]
	public Task<bool> CPHKMDEBMOF(CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal interface OMIJOPMOGOA
{
	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> CPHKMDEBMOF(CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct EKDPDNNLDLK
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class IBAJCLIAJGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public MLLAEEOLMLG manager;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public IBAJCLIAJGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x79C4250", Offset = "0x79C3050", VA = "0x1879C4250")]
		internal Task KCMKDDPAKCE(CancellationToken cancellationToken, int roomTotalVersion, BKBFPOLBAFH localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct KJOAIFDEJKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public EKDPDNNLDLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private GFONHMBPIOH <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<CAOOGOEBJJH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private TaskAwaiter<MDFDKOJBEAB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x79C6030", Offset = "0x79C4E30", VA = "0x1879C6030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x79C65C0", Offset = "0x79C53C0", VA = "0x1879C65C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct PEJJMFKBEAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public EKDPDNNLDLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x79CB130", Offset = "0x79C9F30", VA = "0x1879CB130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x79CB450", Offset = "0x79CA250", VA = "0x1879CB450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly CancellationToken FEHCANHDGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly MLLAEEOLMLG HLDNIAJEGKP;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private JPDCMPIABBH DIJMFKPBAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x79BDB10", Offset = "0x79BC910", VA = "0x1879BDB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private INCEBAAAKHE GFIGBBNEHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x79BD530", Offset = "0x79BC330", VA = "0x1879BD530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private PLHOCBJJMOF ILIBPHFOENB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x79BD650", Offset = "0x79BC450", VA = "0x1879BD650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private JLPJEIGMNDF KENOOEADEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x79BD780", Offset = "0x79BC580", VA = "0x1879BD780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x25375B0", Offset = "0x25363B0", VA = "0x1825375B0")]
	public EKDPDNNLDLK(CancellationToken FEHCANHDGHE, MLLAEEOLMLG HLDNIAJEGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x79BD6D0", Offset = "0x79BC4D0", VA = "0x1879BD6D0")]
	public static OCNMAGANFFL CJCLLNPMAJG(MLLAEEOLMLG HLDNIAJEGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x79BDB60", Offset = "0x79BC960", VA = "0x1879BDB60")]
	[AsyncStateMachine(typeof(KJOAIFDEJKE))]
	public Task<bool> NJAAPHNJHEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x79BD7D0", Offset = "0x79BC5D0", VA = "0x1879BD7D0")]
	private bool DOEOFCAOPAK([Out] GFONHMBPIOH MFPHOGLGEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x79BD580", Offset = "0x79BC380", VA = "0x1879BD580")]
	[AsyncStateMachine(typeof(PEJJMFKBEAE))]
	private Task BPPPHPNICFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x79BD9E0", Offset = "0x79BC7E0", VA = "0x1879BD9E0")]
	private Task<CAOOGOEBJJH> GFJGIEOJEEH(GFONHMBPIOH PIGCCJOFLEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct GPEDDNPHDFO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly DMMJIOBMFDN OOGIBHFCIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Guid KCDDPKBGHIL;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Task<(MDFDKOJBEAB, Task)> CCDEOALEJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x79C0500", Offset = "0x79BF300", VA = "0x1879C0500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4A3AAB0", Offset = "0x4A398B0", VA = "0x184A3AAB0")]
	public GPEDDNPHDFO(DMMJIOBMFDN OOGIBHFCIJF, Guid KCDDPKBGHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x79C05D0", Offset = "0x79BF3D0", VA = "0x1879C05D0")]
	public TaskAwaiter<(MDFDKOJBEAB, Task)> JOPFHFCGHMH()
	{
		return default(TaskAwaiter<(MDFDKOJBEAB, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x79C0430", Offset = "0x79BF230", VA = "0x1879C0430", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct FAHLPECCAAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly TaskCompletionSource<(MDFDKOJBEAB, Task)> KMLKEDBINFM;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public Task<(MDFDKOJBEAB, Task)> CCDEOALEJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x79BEC60", Offset = "0x79BDA60", VA = "0x1879BEC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x79BEE10", Offset = "0x79BDC10", VA = "0x1879BEE10")]
	public FAHLPECCAAB(TimeSpan BHBDEJJKCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x79BEBC0", Offset = "0x79BD9C0", VA = "0x1879BEBC0")]
	public void BAMBEOOCFMO(Task MCOPNMGDILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x79BED80", Offset = "0x79BDB80", VA = "0x1879BED80")]
	public void PPLOCHGKHFE(MDFDKOJBEAB FDBNMLEAMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x79BED30", Offset = "0x79BDB30", VA = "0x1879BED30")]
	public void HBJHGIAAIKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x79BECA0", Offset = "0x79BDAA0", VA = "0x1879BECA0")]
	internal void FNJFMNNALHF(string KKBJAPCBOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class LJIOEONLDFF
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class PJCFHGPOEPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public KGAIHJLHFDH subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public PJCFHGPOEPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x79CB4B0", Offset = "0x79CA2B0", VA = "0x1879CB4B0")]
		internal bool NLHNPNGNKEL(DADBLAJODHB s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x79C79C0", Offset = "0x79C67C0", VA = "0x1879C79C0")]
	public static JAJOICLCDFI DCMOGLEGFAE(long JDAINGEBJKE, long FIAEJOGALJF, string BOHOGABJBDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x79C76D0", Offset = "0x79C64D0", VA = "0x1879C76D0")]
	public static JAJOICLCDFI DCMOGLEGFAE(long JDAINGEBJKE, long FIAEJOGALJF, HOAPPKHGKNJ PDNPLFLMEMC, long BNKDNHLBLJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x79C7540", Offset = "0x79C6340", VA = "0x1879C7540")]
	public static JAJOICLCDFI DCMOGLEGFAE(LBFPONJCALF HJLFBHOMFDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x79C7790", Offset = "0x79C6590", VA = "0x1879C7790")]
	public static JAJOICLCDFI DCMOGLEGFAE(DGCCNGNLMNC MMLPFCAKGLE, KGAIHJLHFDH KNLBFJFLLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x79C7A50", Offset = "0x79C6850", VA = "0x1879C7A50")]
	public static JAJOICLCDFI OIDJHEGHFIC(this JAJOICLCDFI KGDIEBJBNPG, DGCCNGNLMNC NHFDFDNDELI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x79C7B40", Offset = "0x79C6940", VA = "0x1879C7B40")]
	public static JAJOICLCDFI PINMOMNHADH(this JAJOICLCDFI KGDIEBJBNPG, KGAIHJLHFDH NAKIGAFBKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RecRoom.NoEngine.Common.Preserve]
internal class BGALEDJGLBH : GLPAIIHJPGB, FLGLKCKJMGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct EKBPJJLCAMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public BGALEDJGLBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x79BC900", Offset = "0x79BB700", VA = "0x1879BC900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x79BCFA0", Offset = "0x79BBDA0", VA = "0x1879BCFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly LNJPDINAFGA CMAIOLIBOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private string ODMPIDOBLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Task GDFBDAPKHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private MLLAEEOLMLG FDPNEEAEJHK;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool LPMEPFHLPNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x79AEAB0", Offset = "0x79AD8B0", VA = "0x1879AEAB0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Task MBHAHLGMKOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x79AEAE0", Offset = "0x79AD8E0", VA = "0x1879AEAE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8F7B40", Offset = "0x8F6940", VA = "0x1808F7B40", Slot = "7")]
	public void JEELJGCJJCO(MLLAEEOLMLG FDPNEEAEJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x79AEB70", Offset = "0x79AD970", VA = "0x1879AEB70", Slot = "6")]
	public void HLPFJCFJLPA(Task BDCCICFJHCL, string DHOEOKFNDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x79AECD0", Offset = "0x79ADAD0", VA = "0x1879AECD0")]
	[AsyncStateMachine(typeof(EKBPJJLCAMI))]
	private Task OBGCBNKBFMC(Task BDIAPHFODKP, string DHOEOKFNDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x79AEDF0", Offset = "0x79ADBF0", VA = "0x1879AEDF0")]
	public BGALEDJGLBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class AAGGMAEBDFB : AIFNHGMNCND, FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool EFILNHGAABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private HNHOJCCKBFA PPBEHMGFJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private JPDCMPIABBH JGDMKGHAADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private DAHLKJIKMOB LHCHLNOABPH;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public HNHOJCCKBFA HLPIJKOFDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x79AD720", Offset = "0x79AC520", VA = "0x1879AD720", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x79AD980", Offset = "0x79AC780", VA = "0x1879AD980", Slot = "7")]
	public void JEELJGCJJCO(MLLAEEOLMLG FDPNEEAEJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x79AD7D0", Offset = "0x79AC5D0", VA = "0x1879AD7D0", Slot = "5")]
	public void FDANBDKLEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x79AD790", Offset = "0x79AC590", VA = "0x1879AD790", Slot = "6")]
	public void DGIBAHBMJBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x79ADB00", Offset = "0x79AC900", VA = "0x1879ADB00")]
	private Task NIMBGLGDFAP(NFIMLCNCGAF BHICHJIFLJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x79AD790", Offset = "0x79AC590", VA = "0x1879AD790", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public AAGGMAEBDFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class MMKAAGPIOAF : DAHLKJIKMOB
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class MBNJGMOJANB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly DPIEDOFFLCF HMHLOFOACGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly string FFOHLCGHDKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly T KBHDDKCAINE;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public T HKHKCHJEPKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xB4A960", Offset = "0xB49760", VA = "0x180B4A960")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xB4BD60", Offset = "0xB4AB60", VA = "0x180B4BD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x4C861A0", Offset = "0x4C84FA0", VA = "0x184C861A0")]
		public MBNJGMOJANB(DPIEDOFFLCF HMHLOFOACGH, string FFOHLCGHDKA, T KBHDDKCAINE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x4C85D20", Offset = "0x4C84B20", VA = "0x184C85D20")]
		private void HBKNCEFOFKK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly DPIEDOFFLCF HMHLOFOACGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly MBNJGMOJANB<TimeSpan> HFKDGFNOFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly MBNJGMOJANB<TimeSpan> MAFAAFCHCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly MBNJGMOJANB<TimeSpan> GFLHMKBICMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly MBNJGMOJANB<TimeSpan> FAMMGBAEADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly MBNJGMOJANB<bool> FGGKCCDKNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly MBNJGMOJANB<bool> KNDJHMCIGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly MBNJGMOJANB<bool> CFNOENKCPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly MBNJGMOJANB<int> MCLHDIHCFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly MBNJGMOJANB<bool> JOMGPFFKCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly MBNJGMOJANB<bool> KHHKAHOBBNM;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public TimeSpan IHOFDPJCEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x79C9CC0", Offset = "0x79C8AC0", VA = "0x1879C9CC0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public TimeSpan MJEOMIHJDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x79C9C80", Offset = "0x79C8A80", VA = "0x1879C9C80", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public TimeSpan HLOADGCDLIL
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x79C9E00", Offset = "0x79C8C00", VA = "0x1879C9E00", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public TimeSpan EPMDJAKKABA
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x79C9DC0", Offset = "0x79C8BC0", VA = "0x1879C9DC0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool KOGJENHLGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x79C9E80", Offset = "0x79C8C80", VA = "0x1879C9E80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool OAFCJCCPFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x79C9D00", Offset = "0x79C8B00", VA = "0x1879C9D00", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool CINOOFKJEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x79C9E40", Offset = "0x79C8C40", VA = "0x1879C9E40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public int KKFNHNLDLEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x79C9D80", Offset = "0x79C8B80", VA = "0x1879C9D80", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool FDNAPIFHMHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x79C9D40", Offset = "0x79C8B40", VA = "0x1879C9D40", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool AEBFHGFEBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x79C9C40", Offset = "0x79C8A40", VA = "0x1879C9C40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x79C9EC0", Offset = "0x79C8CC0", VA = "0x1879C9EC0")]
	[UnityEngine.Scripting.Preserve]
	public MMKAAGPIOAF([MHFJPMCEEAM(null)] DPIEDOFFLCF HMHLOFOACGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[UnityEngine.Scripting.Preserve]
internal class HDICJBJJHBN : JEMLMLPEGHI, FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class OBBLHGHKAHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public KDCHDHEFHAG roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public OBBLHGHKAHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x79CA8E0", Offset = "0x79C96E0", VA = "0x1879CA8E0")]
		internal object LBAANCLHBOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action CADDLEDCECK
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x79C2780", Offset = "0x79C1580", VA = "0x1879C2780", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x79C2AE0", Offset = "0x79C18E0", VA = "0x1879C2AE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event MAAGCFFPAOA PNDCBDEOGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x79C2630", Offset = "0x79C1430", VA = "0x1879C2630", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x79C2590", Offset = "0x79C1390", VA = "0x1879C2590", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event MAAGCFFPAOA AMHGEBNCPNM
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x79C2870", Offset = "0x79C1670", VA = "0x1879C2870", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x79C2D80", Offset = "0x79C1B80", VA = "0x1879C2D80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event MAAGCFFPAOA BOKHBOEHOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x79C2E20", Offset = "0x79C1C20", VA = "0x1879C2E20", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x79C2FD0", Offset = "0x79C1DD0", VA = "0x1879C2FD0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<ADNACPKIBIF, bool> LHPLOFDCNMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x79C26D0", Offset = "0x79C14D0", VA = "0x1879C26D0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x79C2EF0", Offset = "0x79C1CF0", VA = "0x1879C2EF0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "19")]
	public void JEELJGCJJCO(MLLAEEOLMLG FDPNEEAEJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x79C2B80", Offset = "0x79C1980", VA = "0x1879C2B80", Slot = "14")]
	public void IKBOEPGNDBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x79C2EC0", Offset = "0x79C1CC0", VA = "0x1879C2EC0", Slot = "15")]
	public void MBCBGEFGPGB(KDCHDHEFHAG NGNJEIAEFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x79C2FA0", Offset = "0x79C1DA0", VA = "0x1879C2FA0", Slot = "16")]
	public void PHNGLDIHKBA(KDCHDHEFHAG NGNJEIAEFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x79C2560", Offset = "0x79C1360", VA = "0x1879C2560", Slot = "17")]
	public void ADPFGGJNKFJ(KDCHDHEFHAG NGNJEIAEFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x79C2820", Offset = "0x79C1620", VA = "0x1879C2820", Slot = "18")]
	public void EJCGJEAIFAK(ADNACPKIBIF OCBLIALNMGI, bool AAIFAFJIHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x79C2910", Offset = "0x79C1710", VA = "0x1879C2910")]
	private void GAFILCALGLM(MAAGCFFPAOA EPJFIIMKBMG, KDCHDHEFHAG NGNJEIAEFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public HDICJBJJHBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[UnityEngine.Scripting.Preserve]
internal class MDCEHNPNAKK : OFHBBGLGCJM, FLGLKCKJMGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct BMIALAOCDCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public MDCEHNPNAKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x79AF0F0", Offset = "0x79ADEF0", VA = "0x1879AF0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x79AF670", Offset = "0x79AE470", VA = "0x1879AF670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct HBKKLLCEBAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public MDCEHNPNAKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x79C1E60", Offset = "0x79C0C60", VA = "0x1879C1E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x79C2500", Offset = "0x79C1300", VA = "0x1879C2500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class CDEOOAKBOOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public CDEOOAKBOOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x79B00F0", Offset = "0x79AEEF0", VA = "0x1879B00F0")]
		internal object JELHHBIDFGC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct DBDCJGJFHHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public MDCEHNPNAKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private CDEOOAKBOOI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x79B9830", Offset = "0x79B8630", VA = "0x1879B9830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x79B9F80", Offset = "0x79B8D80", VA = "0x1879B9F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class GMMCPMLDBHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public GMMCPMLDBHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x79C03C0", Offset = "0x79BF1C0", VA = "0x1879C03C0")]
		internal object CKEJAIHNLDC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private MLLAEEOLMLG FDPNEEAEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private INCEBAAAKHE BPGIOHMMDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private OMIJOPMOGOA[] MAGCOILIEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private CancellationTokenSource PCBNIHHNEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int LMCBJICGMMN;

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x79C8800", Offset = "0x79C7600", VA = "0x1879C8800", Slot = "6")]
	public void JEELJGCJJCO(MLLAEEOLMLG FDPNEEAEJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x79C84F0", Offset = "0x79C72F0", VA = "0x1879C84F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x79C8880", Offset = "0x79C7680", VA = "0x1879C8880", Slot = "8")]
	public void LFIAFFGOMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x79C8730", Offset = "0x79C7530", VA = "0x1879C8730", Slot = "5")]
	public void HICLCJKNLOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x79C8980", Offset = "0x79C7780", VA = "0x1879C8980", Slot = "4")]
	[AsyncStateMachine(typeof(BMIALAOCDCP))]
	public Task MAEKNOBKLLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x79C8A50", Offset = "0x79C7850", VA = "0x1879C8A50")]
	private void NBLOEENHMIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x79C8500", Offset = "0x79C7300", VA = "0x1879C8500")]
	[AsyncStateMachine(typeof(HBKKLLCEBAG))]
	private Task FGLEPFNOJCK(CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x79C81A0", Offset = "0x79C6FA0", VA = "0x1879C81A0")]
	[AsyncStateMachine(typeof(DBDCJGJFHHN))]
	private Task<bool> AFDODNJJDDI(int KNCPCNBMDNF, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x79C8D70", Offset = "0x79C7B70", VA = "0x1879C8D70")]
	private void OIGAFAHDLBK(int KNCPCNBMDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x79C82E0", Offset = "0x79C70E0", VA = "0x1879C82E0")]
	private void AJBPBAGHODJ(int KNCPCNBMDNF, bool AAIFAFJIHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x79C83C0", Offset = "0x79C71C0", VA = "0x1879C83C0")]
	private void CKFPLPIGJHN(int KNCPCNBMDNF, Exception JGLOLGKKBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x79C8600", Offset = "0x79C7400", VA = "0x1879C8600")]
	private void HEMKCDICBLH(CancellationToken FEHCANHDGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public MDCEHNPNAKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[RecRoom.NoEngine.Common.Preserve]
internal class CJJKLMGPMIL : MHINNMMEEGD, FLGLKCKJMGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct BDPOEJFPPNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public NCNEODEEIGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CJJKLMGPMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public JHEDCICMDGH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x79AE0E0", Offset = "0x79ACEE0", VA = "0x1879AE0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x79AEA50", Offset = "0x79AD850", VA = "0x1879AEA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct MDKCGCBACNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CJJKLMGPMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public NCNEODEEIGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public JHEDCICMDGH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private IGPFJOOPHMK<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private DOOPFMCKBOH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private GHHFOGHNCBC <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private GAHOAOADPJI <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x79C8EE0", Offset = "0x79C7CE0", VA = "0x1879C8EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x79C9B90", Offset = "0x79C8990", VA = "0x1879C9B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class MAJHOMJKPBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Matchmaking.GKGGJJKLLNP result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public OBBMCONLNJK errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MAJHOMJKPBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x79C80F0", Offset = "0x79C6EF0", VA = "0x1879C80F0")]
		internal object ABCNPJAFDPN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class FKDJJDDGPAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public Task<JAJOICLCDFI> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public FKDJJDDGPAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		internal Task<JAJOICLCDFI> FFANLDMDCLC(IGPFJOOPHMK<string>.PDLCJKJEJBF _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct CEFNKEFMAPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CJJKLMGPMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public NCNEODEEIGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public JHEDCICMDGH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public GHHFOGHNCBC joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private FKDJJDDGPAM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private MCPOMHOMLBH <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private DOOPFMCKBOH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private AGMBFHBBGEH <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private Task<Matchmaking.CMJKCGBCIJI> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private MECFKNCPAJB <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter<Matchmaking.CMJKCGBCIJI> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter<JAJOICLCDFI> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x79B0160", Offset = "0x79AEF60", VA = "0x1879B0160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x79B5AF0", Offset = "0x79B48F0", VA = "0x1879B5AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct HJNOBIIAIKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CJJKLMGPMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x79C3780", Offset = "0x79C2580", VA = "0x1879C3780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x79C41F0", Offset = "0x79C2FF0", VA = "0x1879C41F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct JGFCOPIHPIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public CJJKLMGPMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEPIHLKICIO <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x79C4E50", Offset = "0x79C3C50", VA = "0x1879C4E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x79C52D0", Offset = "0x79C40D0", VA = "0x1879C52D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct KFILIMGDMPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public AsyncTaskMethodBuilder<Matchmaking.CMJKCGBCIJI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public NCNEODEEIGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CJJKLMGPMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter<Matchmaking.CMJKCGBCIJI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x79C5690", Offset = "0x79C4490", VA = "0x1879C5690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x79C5BA0", Offset = "0x79C49A0", VA = "0x1879C5BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct FHDFGIOACBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Matchmaking.CMJKCGBCIJI serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CJJKLMGPMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public GHHFOGHNCBC joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TaskAwaiter<IOLCLDMPBLF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x79BF350", Offset = "0x79BE150", VA = "0x1879BF350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x79BFA50", Offset = "0x79BE850", VA = "0x1879BFA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class BLCCBLMHHPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public NCNEODEEIGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public BLCCBLMHHPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x79AEEF0", Offset = "0x79ADCF0", VA = "0x1879AEEF0")]
		internal object BOABPMDEKJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x79AEFF0", Offset = "0x79ADDF0", VA = "0x1879AEFF0")]
		internal string NFBLDGLPCAP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct KLOAJLBDCBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public NCNEODEEIGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public CJJKLMGPMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private BLCCBLMHHPA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x79C6630", Offset = "0x79C5430", VA = "0x1879C6630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x79C7210", Offset = "0x79C6010", VA = "0x1879C7210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct JBJPKJPNFMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CJJKLMGPMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public GHHFOGHNCBC joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public JAJOICLCDFI initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public NCNEODEEIGF targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public MCPOMHOMLBH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x79C44D0", Offset = "0x79C32D0", VA = "0x1879C44D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x79C4DF0", Offset = "0x79C3BF0", VA = "0x1879C4DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct HAHJJBLHNAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public CJJKLMGPMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private DOOPFMCKBOH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private DOOPFMCKBOH <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x79C0620", Offset = "0x79BF420", VA = "0x1879C0620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x79C1E00", Offset = "0x79C0C00", VA = "0x1879C1E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct EBJIDMMJAHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public BKBFPOLBAFH localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public CJJKLMGPMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private TaskAwaiter<MDFDKOJBEAB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x79BC130", Offset = "0x79BAF30", VA = "0x1879BC130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x79BC8A0", Offset = "0x79BB6A0", VA = "0x1879BC8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class GCNNLFFHDPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public NCNEODEEIGF targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public GCNNLFFHDPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x79D7590", Offset = "0x79D6390", VA = "0x1879D7590")]
		internal object BNPJHBPAJFK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class NMCGMGGEDCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public NMCGMGGEDCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x79E8100", Offset = "0x79E6F00", VA = "0x1879E8100")]
		internal void FHLJKBEIJFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class DFEKNIGAFKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public NCNEODEEIGF targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public DFEKNIGAFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x79CF820", Offset = "0x79CE620", VA = "0x1879CF820")]
		internal object ILANFEICFEN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class NGGLAMFAMCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public NCNEODEEIGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public NGGLAMFAMCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x79E7D30", Offset = "0x79E6B30", VA = "0x1879E7D30")]
		internal string JGEMLBFGNBO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly IMOCAMGHNDM DOOFICFGDEL;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly IMOCAMGHNDM GILDEHLHOOF;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly IMOCAMGHNDM HOLPGMCJJBL;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string IBFHMMMAEPP;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly string AHBHMOLJAJN;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly string BFHFKILKIDB;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly Guid CDGNMOLNKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private IKHJLIGMDLA PJICLILFLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private KELKPOFEJCB AEGNKLJBMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private JPDCMPIABBH JGDMKGHAADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private MLLAEEOLMLG FDPNEEAEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private INCEBAAAKHE BPGIOHMMDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private OFHBBGLGCJM KOIHEHKELBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private GLPAIIHJPGB GDHDLLHDNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private JEMLMLPEGHI LFLBNOFMAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private GKHGIFENKMB ELFLKDBDJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private MCGABFLMDLK IMNGJMLKNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private IDisposable PANDONIEPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private LNKPOCDFECC KPBECGJGAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly LNJPDINAFGA ONIHMAKHLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private MECFKNCPAJB FCAPCOINBKJ;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public TaskStatus JGIAMPFODIN
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x91D6E0", Offset = "0x91C4E0", VA = "0x18091D6E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x1126BA0", Offset = "0x11259A0", VA = "0x181126BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private PLHOCBJJMOF ILIBPHFOENB
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x79B6290", Offset = "0x79B5090", VA = "0x1879B6290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x79B7930", Offset = "0x79B6730", VA = "0x1879B7930", Slot = "6")]
	public void JEELJGCJJCO(MLLAEEOLMLG FDPNEEAEJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x79B6530", Offset = "0x79B5330", VA = "0x1879B6530", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x79B91C0", Offset = "0x79B7FC0", VA = "0x1879B91C0", Slot = "5")]
	[AsyncStateMachine(typeof(BDPOEJFPPNO))]
	public Task PJGNEJPGHPL(NCNEODEEIGF IPJPAHGOIMA, JHEDCICMDGH IDOCOHHFGNI, CancellationToken JHKFKNKNOJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x79B7C50", Offset = "0x79B6A50", VA = "0x1879B7C50")]
	[AsyncStateMachine(typeof(MDKCGCBACNB))]
	private Task JLJHGABOJJK(NCNEODEEIGF IPJPAHGOIMA, JHEDCICMDGH IDOCOHHFGNI, CancellationToken JHKFKNKNOJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x79B5B50", Offset = "0x79B4950", VA = "0x1879B5B50")]
	private void AAMGOKLPBAP(GKHGIFENKMB ELFLKDBDJPD, NCNEODEEIGF IPJPAHGOIMA, Exception JGLOLGKKBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x79B84F0", Offset = "0x79B72F0", VA = "0x1879B84F0")]
	private static void OBMIJKBFMGC(GAHOAOADPJI CPJKCCGHPJP, Exception JGLOLGKKBMI, [Optional] List<int> KMFABMBFHMI, int LMCBJICGMMN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x79B63D0", Offset = "0x79B51D0", VA = "0x1879B63D0")]
	[AsyncStateMachine(typeof(CEFNKEFMAPH))]
	private Task DNFAKGKINOJ(IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, NCNEODEEIGF IPJPAHGOIMA, JHEDCICMDGH IDOCOHHFGNI, GHHFOGHNCBC BAGAMNCHOBG, CancellationToken JHKFKNKNOJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x79B8050", Offset = "0x79B6E50", VA = "0x1879B8050")]
	private void LBJLFFIBAGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x79B8FC0", Offset = "0x79B7DC0", VA = "0x1879B8FC0")]
	[AsyncStateMachine(typeof(HJNOBIIAIKK))]
	private Task PFANLAIPANI(IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x79B6700", Offset = "0x79B5500", VA = "0x1879B6700")]
	private void EFKGFHOKEIH(NCNEODEEIGF IPJPAHGOIMA, CancellationToken JHKFKNKNOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x79B6F60", Offset = "0x79B5D60", VA = "0x1879B6F60")]
	private void HGCKIKMDLAB(NCNEODEEIGF IPJPAHGOIMA, GHHFOGHNCBC BAGAMNCHOBG, OperationCanceledException JIMLKMDADAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x79B7320", Offset = "0x79B6120", VA = "0x1879B7320")]
	private void IDOBPMGDKAP(NCNEODEEIGF IPJPAHGOIMA, GHHFOGHNCBC BAGAMNCHOBG, Exception JGLOLGKKBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x79B6AC0", Offset = "0x79B58C0", VA = "0x1879B6AC0")]
	private void EJLPJPLMEDE(NCNEODEEIGF IPJPAHGOIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x79B8400", Offset = "0x79B7200", VA = "0x1879B8400")]
	private static KDCHDHEFHAG MJGDMDMAMKK(NCNEODEEIGF IPJPAHGOIMA)
	{
		return default(KDCHDHEFHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x79B90F0", Offset = "0x79B7EF0", VA = "0x1879B90F0")]
	[AsyncStateMachine(typeof(JGFCOPIHPIM))]
	private Task PIFOADEIFNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x79B81A0", Offset = "0x79B6FA0", VA = "0x1879B81A0")]
	[AsyncStateMachine(typeof(KFILIMGDMPD))]
	private Task<Matchmaking.CMJKCGBCIJI> LIEOLNDODCA(NCNEODEEIGF IPJPAHGOIMA, IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x79B71B0", Offset = "0x79B5FB0", VA = "0x1879B71B0")]
	private static IOLCLDMPBLF HMLHOBDKLCM(Matchmaking.CMJKCGBCIJI BPCPADAANHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x79B6CD0", Offset = "0x79B5AD0", VA = "0x1879B6CD0")]
	[AsyncStateMachine(typeof(FHDFGIOACBM))]
	private Task FKLEJOFNOKI(Matchmaking.CMJKCGBCIJI BPCPADAANHL, GHHFOGHNCBC BAGAMNCHOBG, IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, CancellationToken MPCJFMBODJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x79B6E20", Offset = "0x79B5C20", VA = "0x1879B6E20")]
	[AsyncStateMachine(typeof(KLOAJLBDCBK))]
	private Task HFNMMJNAFCP(NCNEODEEIGF IPJPAHGOIMA, CancellationTokenSource NLJMFAHEOLL, Task JNBGKJJLDJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x79B8D40", Offset = "0x79B7B40", VA = "0x1879B8D40")]
	[AsyncStateMachine(typeof(JBJPKJPNFMP))]
	private Task OKMLGMECLKJ(JAJOICLCDFI DADIHNFCDHB, MCPOMHOMLBH POEFGJLAHPM, NCNEODEEIGF MDAKAEDMBFK, GHHFOGHNCBC IPCGAOHCPEH, IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, CancellationToken JKICJNNAJAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x79B76B0", Offset = "0x79B64B0", VA = "0x1879B76B0")]
	private GHHFOGHNCBC IGOPNJJNNMD(GHHFOGHNCBC IPCGAOHCPEH, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x79B7570", Offset = "0x79B6370", VA = "0x1879B7570")]
	[AsyncStateMachine(typeof(HAHJJBLHNAE))]
	private Task IGLNFJLBBNF(IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x79B5FB0", Offset = "0x79B4DB0", VA = "0x1879B5FB0")]
	[AsyncStateMachine(typeof(EBJIDMMJAHK))]
	private Task AIFJHNAKHIF(CancellationToken FEHCANHDGHE, int NBBGNFGEDDB, BKBFPOLBAFH JJOKBEFEBKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x79B6580", Offset = "0x79B5380", VA = "0x1879B6580")]
	private static void EACJHLMBFMJ(NCNEODEEIGF IPJPAHGOIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x79B7DA0", Offset = "0x79B6BA0", VA = "0x1879B7DA0")]
	private void JMODOBFBEHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x79B6A30", Offset = "0x79B5830", VA = "0x1879B6A30")]
	private void EIABOKLAIFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x79B8460", Offset = "0x79B7260", VA = "0x1879B8460")]
	private void NICFADJCFOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x79B78A0", Offset = "0x79B66A0", VA = "0x1879B78A0")]
	private void ILJDKPMLOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x79B62E0", Offset = "0x79B50E0", VA = "0x1879B62E0")]
	private static void DKJJDNBHFMH(NCNEODEEIGF IPJPAHGOIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x79B8EB0", Offset = "0x79B7CB0", VA = "0x1879B8EB0")]
	private static CancellationTokenRegistration OPFDMPEFAIJ(NCNEODEEIGF IPJPAHGOIMA, CancellationToken MPCJFMBODJF)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x79B8300", Offset = "0x79B7100", VA = "0x1879B8300")]
	private static void MEEEOJLBOCH(NCNEODEEIGF IPJPAHGOIMA, Exception JGLOLGKKBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x79B60E0", Offset = "0x79B4EE0", VA = "0x1879B60E0")]
	private void BFAIEEFBPHK(NCNEODEEIGF IPJPAHGOIMA, Task JNBGKJJLDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x79B7FF0", Offset = "0x79B6DF0", VA = "0x1879B7FF0")]
	private static void KAMAHCNLDOK(Func<string> LPBIMHGKKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x79B9520", Offset = "0x79B8320", VA = "0x1879B9520")]
	public CJJKLMGPMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x79B72C0", Offset = "0x79B60C0", VA = "0x1879B72C0")]
	[CompilerGenerated]
	internal static (int, int?) IDDGFCILIGJ(OBBMCONLNJK INHEKIONAPA)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class IJGEPOFEHHB : PLPOEFPEGII, FLGLKCKJMGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct LMEGHKLNIBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public IJGEPOFEHHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public BKBFPOLBAFH localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x79E5900", Offset = "0x79E4700", VA = "0x1879E5900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x79E5D70", Offset = "0x79E4B70", VA = "0x1879E5D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class ONMMEMBNDFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public IJGEPOFEHHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public BKBFPOLBAFH localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ONMMEMBNDFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x79E9410", Offset = "0x79E8210", VA = "0x1879E9410")]
		internal List<Task> OAKOMOPMHJB(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct POBMHLPBIDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public OCNMAGANFFL taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public BKBFPOLBAFH localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x79EA760", Offset = "0x79E9560", VA = "0x1879EA760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x79EAB00", Offset = "0x79E9900", VA = "0x1879EAB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct GKGNMAOLJPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public IJGEPOFEHHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x79DAD30", Offset = "0x79D9B30", VA = "0x1879DAD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x79DB010", Offset = "0x79D9E10", VA = "0x1879DB010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly HashSet<OCNMAGANFFL> HHDBMFLFIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private KELKPOFEJCB AEGNKLJBMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private MLLAEEOLMLG FDPNEEAEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private DADKOHLCLHL CFMDLPDNMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private BNKKIKJOEFE CGEGEIKMLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private IDisposable PANDONIEPAM;

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x79E0BD0", Offset = "0x79DF9D0", VA = "0x1879E0BD0", Slot = "5")]
	public void JEELJGCJJCO(MLLAEEOLMLG FDPNEEAEJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x79E0860", Offset = "0x79DF660", VA = "0x1879E0860", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x79E0AA0", Offset = "0x79DF8A0", VA = "0x1879E0AA0", Slot = "4")]
	public bool GHOJJCNFAJA(OCNMAGANFFL MONAAEJDMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x79E08E0", Offset = "0x79DF6E0", VA = "0x1879E08E0")]
	private void FOCBHKJPJPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x79E0ED0", Offset = "0x79DFCD0", VA = "0x1879E0ED0")]
	private void KLFOGJBKDBN(HGCCILDLOLL BGIEPHNJHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x79E09B0", Offset = "0x79DF7B0", VA = "0x1879E09B0")]
	[AsyncStateMachine(typeof(LMEGHKLNIBP))]
	private Task GGGBFLFDCME(int NBBGNFGEDDB, BKBFPOLBAFH JJOKBEFEBKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x79E0B00", Offset = "0x79DF900", VA = "0x1879E0B00")]
	private Func<CancellationToken, List<Task>> IMKMAFNAMAE(int NBBGNFGEDDB, BKBFPOLBAFH JJOKBEFEBKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x79E0390", Offset = "0x79DF190", VA = "0x1879E0390")]
	private List<Task> BBEFGNIJABJ(int NBBGNFGEDDB, BKBFPOLBAFH JJOKBEFEBKO, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x79E0270", Offset = "0x79DF070", VA = "0x1879E0270")]
	[AsyncStateMachine(typeof(POBMHLPBIDM))]
	private Task AIKJFIKHPME(OCNMAGANFFL GGMMKCDMKPP, CancellationToken HACFGBHNOCC, int NBBGNFGEDDB, BKBFPOLBAFH JJOKBEFEBKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x79E11A0", Offset = "0x79DFFA0", VA = "0x1879E11A0")]
	[AsyncStateMachine(typeof(GKGNMAOLJPG))]
	private Task PKHJECOAADA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x79E10F0", Offset = "0x79DFEF0", VA = "0x1879E10F0")]
	private void LFIAFFGOMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x79E1270", Offset = "0x79E0070", VA = "0x1879E1270")]
	public IJGEPOFEHHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[UnityEngine.Scripting.Preserve]
internal sealed class EOGBDPJDDHA : DMMJIOBMFDN, FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class OOELAPIGDEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public OOELAPIGDEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x79E9450", Offset = "0x79E8250", VA = "0x1879E9450")]
		internal object ANFFJEPNOEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class NDJEAPLHCOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public NDJEAPLHCOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x79E7CD0", Offset = "0x79E6AD0", VA = "0x1879E7CD0")]
		internal object EAGFDJHNGAO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class HDKPDGHPBIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public HDKPDGHPBIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class HINNDFDNDPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public HINNDFDNDPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x79DDC10", Offset = "0x79DCA10", VA = "0x1879DDC10")]
		internal object GEJBEJEJKNC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class IMMCBDDDBGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public IMMCBDDDBGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x79E23B0", Offset = "0x79E11B0", VA = "0x1879E23B0")]
		internal object LGALNCIHNCN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly Dictionary<Guid, FAHLPECCAAB> OOGIBHFCIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private readonly TimeSpan BKHOBHAIALO;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "9")]
	public void JEELJGCJJCO(MLLAEEOLMLG FDPNEEAEJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x79D4CF0", Offset = "0x79D3AF0", VA = "0x1879D4CF0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x79D5140", Offset = "0x79D3F40", VA = "0x1879D5140", Slot = "4")]
	public GPEDDNPHDFO MDGAONDGEMG(Guid KCDDPKBGHIL)
	{
		return default(GPEDDNPHDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x79D4D00", Offset = "0x79D3B00", VA = "0x1879D4D00", Slot = "5")]
	public bool IEINLEAGPOE(Guid KCDDPKBGHIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x79D5360", Offset = "0x79D4160", VA = "0x1879D5360", Slot = "6")]
	public bool MMNCCPLHCAN(Guid KCDDPKBGHIL, Task MCOPNMGDILD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x79D4B10", Offset = "0x79D3910", VA = "0x1879D4B10", Slot = "7")]
	public bool DNFOGFNNOJD(Guid KCDDPKBGHIL, MDFDKOJBEAB FDBNMLEAMHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x79D4AA0", Offset = "0x79D38A0", VA = "0x1879D4AA0", Slot = "8")]
	public Task<(MDFDKOJBEAB, Task)> CLKEAEODMJD(Guid KCDDPKBGHIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x79D4F10", Offset = "0x79D3D10", VA = "0x1879D4F10")]
	private void LGCPFADBBLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x79D5690", Offset = "0x79D4490", VA = "0x1879D5690")]
	public EOGBDPJDDHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[RecRoom.NoEngine.Common.Preserve]
internal class LENIBNMIMFI : BCBHOOACEHJ, FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private class AINIODHAEJF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private readonly NCNEODEEIGF EMFNNNOAGFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private readonly CancellationTokenSource PCBNIHHNEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public readonly CancellationToken PGMDPJPDGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private bool LCOLOFPCIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private bool EICHBLDJPCE;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x79CC970", Offset = "0x79CB770", VA = "0x1879CC970")]
		public AINIODHAEJF(NCNEODEEIGF EMFNNNOAGFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x79CC820", Offset = "0x79CB620", VA = "0x1879CC820")]
		public void LFIAFFGOMGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x79CC7F0", Offset = "0x79CB5F0", VA = "0x1879CC7F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class NHOKGJOKPBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public NFIMLCNCGAF disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public NHOKGJOKPBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x79E7F50", Offset = "0x79E6D50", VA = "0x1879E7F50")]
		internal object FCFKENCENGC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct ABKCAECDGPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public NFIMLCNCGAF disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public LENIBNMIMFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x79CC390", Offset = "0x79CB190", VA = "0x1879CC390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x79CC790", Offset = "0x79CB590", VA = "0x1879CC790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class ONIAJCAKCKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ONIAJCAKCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x79E93A0", Offset = "0x79E81A0", VA = "0x1879E93A0")]
		internal object GMDFOAGLFJG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct DHDDKHFBHKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public LENIBNMIMFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private DOOPFMCKBOH <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x79CF900", Offset = "0x79CE700", VA = "0x1879CF900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class NHJFDOLIFNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public NCNEODEEIGF newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public NHJFDOLIFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x79E7E30", Offset = "0x79E6C30", VA = "0x1879E7E30")]
		internal object BCPCKEPBAHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x79E7ED0", Offset = "0x79E6CD0", VA = "0x1879E7ED0")]
		internal object CAPPCEMKHIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x79E7F10", Offset = "0x79E6D10", VA = "0x1879E7F10")]
		internal object LCGOLPJAOOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class PJKOIOGKNME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public PJKOIOGKNME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x79EA5B0", Offset = "0x79E93B0", VA = "0x1879EA5B0")]
		internal void BMFEHIICBBK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct EFDKGLANINL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public NCNEODEEIGF newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public LENIBNMIMFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public JHEDCICMDGH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private NHJFDOLIFNN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x79D3590", Offset = "0x79D2390", VA = "0x1879D3590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x79D4520", Offset = "0x79D3320", VA = "0x1879D4520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly GFHGCGAHGHP.PMNJHBFFDEO KEGFEAHOMBH;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly EAJIBKCHNNC KFGPPIHJKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private KELKPOFEJCB AEGNKLJBMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private MLLAEEOLMLG FDPNEEAEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private OFHBBGLGCJM KOIHEHKELBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private INCEBAAAKHE BPGIOHMMDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private DAHLKJIKMOB LHCHLNOABPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private MHINNMMEEGD BLGDEPKIECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private NCNEODEEIGF FODPBCBFEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private AINIODHAEJF NPKIHHFGOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private bool NEAKENCELLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private Task AJCBPOODKPD;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private PLHOCBJJMOF ILIBPHFOENB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x79E3B20", Offset = "0x79E2920", VA = "0x1879E3B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool NKOMCPLEHDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xB45480", Offset = "0xB44280", VA = "0x180B45480")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x79E48F0", Offset = "0x79E36F0", VA = "0x1879E48F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x79E4020", Offset = "0x79E2E20", VA = "0x1879E4020", Slot = "4")]
	public void JEELJGCJJCO(MLLAEEOLMLG FDPNEEAEJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x79E3B70", Offset = "0x79E2970", VA = "0x1879E3B70", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x79E3CE0", Offset = "0x79E2AE0", VA = "0x1879E3CE0")]
	[AsyncStateMachine(typeof(ABKCAECDGPE))]
	private Task FLPEGHCIKIL(NFIMLCNCGAF AKBJIHBJAGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x79E3990", Offset = "0x79E2790", VA = "0x1879E3990")]
	private void BCMALHPNDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x79E43F0", Offset = "0x79E31F0", VA = "0x1879E43F0")]
	private void KGBIHNPMDGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x79E3EA0", Offset = "0x79E2CA0", VA = "0x1879E3EA0")]
	private void JBNADKPPENE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x79E4870", Offset = "0x79E3670", VA = "0x1879E4870")]
	private bool NPKPOGDKIKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x79E3DD0", Offset = "0x79E2BD0", VA = "0x1879E3DD0")]
	[AsyncStateMachine(typeof(DHDDKHFBHKF))]
	private void HIIKGKEKOLJ(int MLOEPLKKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x79E4580", Offset = "0x79E3380", VA = "0x1879E4580")]
	private void LKLMCLFHNNE([Out] IDisposable BFHPOIEMPEJ, [Out] IDisposable PDFBAFCDKGI, [Out] IDisposable DHDEPMNCDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x79E3870", Offset = "0x79E2670", VA = "0x1879E3870")]
	private bool BADDICIEMKG(NCNEODEEIGF EMFNNNOAGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x79E4820", Offset = "0x79E3620", VA = "0x1879E4820")]
	private void MOMHKMDGNNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x79E42C0", Offset = "0x79E30C0", VA = "0x1879E42C0")]
	[AsyncStateMachine(typeof(EFDKGLANINL))]
	private Task JLJHGABOJJK(NCNEODEEIGF EMFNNNOAGFD, JHEDCICMDGH IDOCOHHFGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x79E4CC0", Offset = "0x79E3AC0", VA = "0x1879E4CC0")]
	public LENIBNMIMFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[UnityEngine.Scripting.Preserve]
internal sealed class GDFIHADKGEB : DGHINKAGCDN, FLGLKCKJMGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct MGABHNNEGJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public AsyncTaskMethodBuilder<KGAIIGHCNDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public GDFIHADKGEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private TaskAwaiter<KGAIIGHCNDA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x79E6A80", Offset = "0x79E5880", VA = "0x1879E6A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x79E6D10", Offset = "0x79E5B10", VA = "0x1879E6D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class PIGANNLEBHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public LJLDKNMPHBD message;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public PIGANNLEBHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x79EA550", Offset = "0x79E9350", VA = "0x1879EA550")]
		internal object LAFHPGGMPKF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class LFNADMKBMHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public LJLDKNMPHBD messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public LFNADMKBMHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x79E4D30", Offset = "0x79E3B30", VA = "0x1879E4D30")]
		internal object GNLNJDAHJAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class DACCEOMPMCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public LJLDKNMPHBD request;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public DACCEOMPMCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x79CF7C0", Offset = "0x79CE5C0", VA = "0x1879CF7C0")]
		internal object EJJMDONACHK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct ICHNGGMGPPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public LJLDKNMPHBD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public GDFIHADKGEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<DAODPIEPEBN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x79DE000", Offset = "0x79DCE00", VA = "0x1879DE000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x79DE8D0", Offset = "0x79DD6D0", VA = "0x1879DE8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class DFMLOLNOGAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public LJLDKNMPHBD operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public DFMLOLNOGAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x79CF8A0", Offset = "0x79CE6A0", VA = "0x1879CF8A0")]
		internal object GFKDKMCNBEP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct GHPFGKLNFIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public LJLDKNMPHBD operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public GDFIHADKGEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private GHHFOGHNCBC <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<LJLDKNMPHBD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x79D9C20", Offset = "0x79D8A20", VA = "0x1879D9C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x79DA790", Offset = "0x79D9590", VA = "0x1879DA790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct LHMHMCLBKJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder<DAODPIEPEBN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public GDFIHADKGEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public LJLDKNMPHBD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private AHOPDGKEFGL.CIDPCDCOGHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private GHHFOGHNCBC <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private TaskAwaiter<LJLDKNMPHBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x79E5360", Offset = "0x79E4160", VA = "0x1879E5360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x79E5890", Offset = "0x79E4690", VA = "0x1879E5890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class EILFIANONPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public DAODPIEPEBN operation;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public EILFIANONPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x79D4580", Offset = "0x79D3380", VA = "0x1879D4580")]
		internal object BJCLNOKBLEL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct CBJHFKEHMCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public DAODPIEPEBN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public GDFIHADKGEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private IGPFJOOPHMK<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x79CE650", Offset = "0x79CD450", VA = "0x1879CE650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x79CEC80", Offset = "0x79CDA80", VA = "0x1879CEC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class GHBCFPPMPHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public LJLDKNMPHBD request;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public GHBCFPPMPHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x79D9BC0", Offset = "0x79D89C0", VA = "0x1879D9BC0")]
		internal object CLBLKKCGDHO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class LCNNJIEEOJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public LJLDKNMPHBD request;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public LCNNJIEEOJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x79E3810", Offset = "0x79E2610", VA = "0x1879E3810")]
		internal object ICBADLGGKDG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private MLLAEEOLMLG FDPNEEAEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private GLPAIIHJPGB GDHDLLHDNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private KNKMJDCLLPB CKIHIPHEGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private NIDOHPOIPIJ PEOCKDDEKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private JPDCMPIABBH JGDMKGHAADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private TaskCompletionSource<KGAIIGHCNDA> JINJOCMBCEO;

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x79D8100", Offset = "0x79D6F00", VA = "0x1879D8100", Slot = "7")]
	public void JEELJGCJJCO(MLLAEEOLMLG FDPNEEAEJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x79D7F60", Offset = "0x79D6D60", VA = "0x1879D7F60", Slot = "6")]
	[AsyncStateMachine(typeof(MGABHNNEGJK))]
	public Task<KGAIIGHCNDA> HMJLMELNGCP(CancellationToken IFBIELIDEKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x79D7BD0", Offset = "0x79D69D0", VA = "0x1879D7BD0", Slot = "4")]
	public void HFLOBPBPBOI(LJLDKNMPHBD KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x79D7760", Offset = "0x79D6560", VA = "0x1879D7760", Slot = "5")]
	public void GALJMADPPGB(LJLDKNMPHBD FNLFAJJOGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x79D7AC0", Offset = "0x79D68C0", VA = "0x1879D7AC0")]
	[AsyncStateMachine(typeof(ICHNGGMGPPB))]
	private Task GLJGIJIIEJK(LJLDKNMPHBD HJFGAIAKKLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x79D8310", Offset = "0x79D7110", VA = "0x1879D8310")]
	[AsyncStateMachine(typeof(GHPFGKLNFIO))]
	private Task MGNJCACDEOK(LJLDKNMPHBD LNKDPPFOHJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x79D89C0", Offset = "0x79D77C0", VA = "0x1879D89C0")]
	[AsyncStateMachine(typeof(LHMHMCLBKJA))]
	private Task<DAODPIEPEBN> PPFCPCCDKME(LJLDKNMPHBD HJFGAIAKKLJ, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x79D8070", Offset = "0x79D6E70", VA = "0x1879D8070")]
	private GHHFOGHNCBC IJLAIKMEDNO(LJLDKNMPHBD ILCGOKLBNKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x79D81F0", Offset = "0x79D6FF0", VA = "0x1879D81F0")]
	[AsyncStateMachine(typeof(CBJHFKEHMCF))]
	private Task LGONCEJONKP(DAODPIEPEBN GOPOAFOKCPE, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x79D8420", Offset = "0x79D7220", VA = "0x1879D8420")]
	private DAODPIEPEBN NPLEHLPIKIM(LJLDKNMPHBD HJFGAIAKKLJ, GHHFOGHNCBC FCEFEKCHPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x32A5280", Offset = "0x32A4080", VA = "0x1832A5280")]
	private T FCEFNBDIFMN<T>(T IPHILEOFJLB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x79D8630", Offset = "0x79D7430", VA = "0x1879D8630")]
	private DAODPIEPEBN OMJNPGFGPDL(LJLDKNMPHBD HJFGAIAKKLJ, GHHFOGHNCBC FCEFEKCHPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public GDFIHADKGEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[UnityEngine.Scripting.Preserve]
internal sealed class GLKONMHKLPJ : KNKMJDCLLPB, FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class ABHJFLBOBAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ABHJFLBOBAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x79CC320", Offset = "0x79CB120", VA = "0x1879CC320")]
		internal object JNNONLJLPEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class MAELMCDJBJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MAELMCDJBJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x79E6440", Offset = "0x79E5240", VA = "0x1879E6440")]
		internal object GMPHAJHPCGP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private JPDCMPIABBH JGDMKGHAADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private JONNIPABEJF GKMJNCPIFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private DGHINKAGCDN FEAHNPLABHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private DMMJIOBMFDN OOGIBHFCIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private GOJPEFGLELG IOJCBPLMEGH;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x79DBBB0", Offset = "0x79DA9B0", VA = "0x1879DBBB0", Slot = "6")]
	public void JEELJGCJJCO(MLLAEEOLMLG FDPNEEAEJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x79DB070", Offset = "0x79D9E70", VA = "0x1879DB070", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x79DB1F0", Offset = "0x79D9FF0", VA = "0x1879DB1F0", Slot = "4")]
	public GPEDDNPHDFO HCGPKNFOGFH(LJLDKNMPHBD BENIIKCNHBG)
	{
		return default(GPEDDNPHDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x79DCE70", Offset = "0x79DBC70", VA = "0x1879DCE70", Slot = "5")]
	public void PJBCHOBOMED(Guid KCDDPKBGHIL, Task MCOPNMGDILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x79DB120", Offset = "0x79D9F20", VA = "0x1879DB120")]
	private void FHLAKJDOGNH(byte MEEKNBJKNCI, int MHOPLONLNME, object NPHHEKPDHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x79DB620", Offset = "0x79DA420", VA = "0x1879DB620")]
	private void HDPCHHAKNLD(IABDLELGCHA NEPCFFIOLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x79DC400", Offset = "0x79DB200", VA = "0x1879DC400")]
	private void OHKAGHMDEJO(IABDLELGCHA NEPCFFIOLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x79DBD20", Offset = "0x79DAB20", VA = "0x1879DBD20")]
	private void JGBLBMHDPEF(IABDLELGCHA NEPCFFIOLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x79DC700", Offset = "0x79DB500", VA = "0x1879DC700")]
	private MDFDKOJBEAB OPMKOHKOIHB(LJLDKNMPHBD ILCGOKLBNKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x79DBF60", Offset = "0x79DAD60", VA = "0x1879DBF60")]
	private void LBCGKGLGPGE(LJLDKNMPHBD LNKDPPFOHJL, MDFDKOJBEAB FDBNMLEAMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x79DCBC0", Offset = "0x79DB9C0", VA = "0x1879DCBC0")]
	private bool PDPJIEELPLB(LJLDKNMPHBD LNKDPPFOHJL, MDFDKOJBEAB FDBNMLEAMHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x79DC940", Offset = "0x79DB740", VA = "0x1879DC940")]
	private bool PCBFFCBDMBE(LJLDKNMPHBD ADFCHDMOMIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x79DC170", Offset = "0x79DAF70", VA = "0x1879DC170")]
	private bool LCPDOPGABPJ(byte MEEKNBJKNCI, ExitGames.Client.Photon.Hashtable NEPCFFIOLCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public GLKONMHKLPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[UnityEngine.Scripting.Preserve]
internal sealed class BNKOOEKBDID : CHABBDPDNKH, FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class ILODCMNIBMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public KGAIIGHCNDA operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public BNKOOEKBDID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public LJLDKNMPHBD roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ILODCMNIBMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x79E2340", Offset = "0x79E1140", VA = "0x1879E2340")]
		internal object MLCANHAIADM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x79E2210", Offset = "0x79E1010", VA = "0x1879E2210")]
		internal object FMEANNNMEEE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct IGKEAOFFGEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<MDFDKOJBEAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public BNKOOEKBDID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public LJLDKNMPHBD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<MDFDKOJBEAB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x79DFB60", Offset = "0x79DE960", VA = "0x1879DFB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x79E0200", Offset = "0x79DF000", VA = "0x1879E0200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class KPOBLDEAGMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public KGAIIGHCNDA operationType;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public KPOBLDEAGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x79E37A0", Offset = "0x79E25A0", VA = "0x1879E37A0")]
		internal object GCPEHPKJNEB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class PAAMMDNIFAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public LJLDKNMPHBD request;

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public PAAMMDNIFAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x79E9590", Offset = "0x79E8390", VA = "0x1879E9590")]
		internal object LNOPNGKNMNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x79E9520", Offset = "0x79E8320", VA = "0x1879E9520")]
		internal object JDPNPOLEPOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x79E94B0", Offset = "0x79E82B0", VA = "0x1879E94B0")]
		internal object GNMCFCGDJMO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct GNHODKILGIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<MDFDKOJBEAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public LJLDKNMPHBD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public BNKOOEKBDID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private PAAMMDNIFAD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private GPEDDNPHDFO <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private MDFDKOJBEAB <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private TaskAwaiter<(MDFDKOJBEAB validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x79DD100", Offset = "0x79DBF00", VA = "0x1879DD100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x79DD9D0", Offset = "0x79DC7D0", VA = "0x1879DD9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private JPDCMPIABBH JGDMKGHAADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private JONNIPABEJF GKMJNCPIFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private KNKMJDCLLPB CKIHIPHEGCD;

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x79CD3D0", Offset = "0x79CC1D0", VA = "0x1879CD3D0", Slot = "5")]
	public void JEELJGCJJCO(MLLAEEOLMLG FDPNEEAEJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x79CD2B0", Offset = "0x79CC0B0", VA = "0x1879CD2B0", Slot = "4")]
	[AsyncStateMachine(typeof(IGKEAOFFGEF))]
	private Task<MDFDKOJBEAB> AAFMNIJKIAA(LJLDKNMPHBD ILCGOKLBNKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x79CD5C0", Offset = "0x79CC3C0", VA = "0x1879CD5C0")]
	private bool POILAPDMIJF(KGAIIGHCNDA OCBLIALNMGI, [Out] MDFDKOJBEAB LDEANEOLAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x79CD480", Offset = "0x79CC280", VA = "0x1879CD480")]
	[AsyncStateMachine(typeof(GNHODKILGIF))]
	private Task<MDFDKOJBEAB> KNLBBNNONJJ(LJLDKNMPHBD HJFGAIAKKLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public BNKOOEKBDID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class FFNMOOOOECH : NPLKADIIGBP, FLGLKCKJMGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct IFIGFMEHKEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<JAJOICLCDFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public NCNEODEEIGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public FFNMOOOOECH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private TaskAwaiter<DGCCNGNLMNC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<JAJOICLCDFI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x79DE930", Offset = "0x79DD730", VA = "0x1879DE930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x79DEF00", Offset = "0x79DDD00", VA = "0x1879DEF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class HCHJMHBDPJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public HCHJMHBDPJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x79DDAA0", Offset = "0x79DC8A0", VA = "0x1879DDAA0")]
		internal object CADLLMHENKN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct GGJMBAJJNDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public AsyncTaskMethodBuilder<DGCCNGNLMNC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public FFNMOOOOECH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public NCNEODEEIGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private HCHJMHBDPJI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<DGCCNGNLMNC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x79D9560", Offset = "0x79D8360", VA = "0x1879D9560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x79D9B50", Offset = "0x79D8950", VA = "0x1879D9B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct FKFMOFKJIIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<JAJOICLCDFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public FFNMOOOOECH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public NCNEODEEIGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public DGCCNGNLMNC roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<(HOAPPKHGKNJ superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x79D6020", Offset = "0x79D4E20", VA = "0x1879D6020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x79D6480", Offset = "0x79D5280", VA = "0x1879D6480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class MBHHLPLIACB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MBHHLPLIACB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xD0CC10", Offset = "0xD0BA10", VA = "0x180D0CC10")]
		internal bool AKPLNGKPNCD(DADBLAJODHB sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct BOBPPHMPLKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<(HOAPPKHGKNJ superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public DGCCNGNLMNC roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public FFNMOOOOECH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public NCNEODEEIGF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<(HOAPPKHGKNJ superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x79CD7B0", Offset = "0x79CC5B0", VA = "0x1879CD7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x79CDE50", Offset = "0x79CCC50", VA = "0x1879CDE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class ILGJGJNFIHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ILGJGJNFIHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x79E2160", Offset = "0x79E0F60", VA = "0x1879E2160")]
		internal object KJLIJBDFIJK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct PBMICAMIMGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public AsyncTaskMethodBuilder<(HOAPPKHGKNJ superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public DADBLAJODHB subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public FFNMOOOOECH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public NCNEODEEIGF dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private ILGJGJNFIHD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private TaskAwaiter<KGAIHJLHFDH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x79E9600", Offset = "0x79E8400", VA = "0x1879E9600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x79E9D30", Offset = "0x79E8B30", VA = "0x1879E9D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static readonly (HOAPPKHGKNJ superRoomData, long subRoomDataSaveId) OKMOBIFJPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private INCEBAAAKHE BPGIOHMMDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private CHIEPMBALCJ JAKFGGFGGIH;

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x79D5BE0", Offset = "0x79D49E0", VA = "0x1879D5BE0", Slot = "5")]
	public void JEELJGCJJCO(MLLAEEOLMLG FDPNEEAEJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x79D57B0", Offset = "0x79D45B0", VA = "0x1879D57B0", Slot = "4")]
	[AsyncStateMachine(typeof(IFIGFMEHKEK))]
	public Task<JAJOICLCDFI> BCMPFEKONHH(IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, NCNEODEEIGF IPJPAHGOIMA, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x79D5910", Offset = "0x79D4710", VA = "0x1879D5910")]
	[AsyncStateMachine(typeof(GGJMBAJJNDD))]
	private Task<DGCCNGNLMNC> DEAFAHKGEGP(NCNEODEEIGF IPJPAHGOIMA, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x79D5DE0", Offset = "0x79D4BE0", VA = "0x1879D5DE0")]
	[AsyncStateMachine(typeof(FKFMOFKJIIO))]
	private Task<JAJOICLCDFI> LKNLHNGGNJL(NCNEODEEIGF IPJPAHGOIMA, DGCCNGNLMNC NINGHLHEEFJ, long MGNAIIKHEOI, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x79D5A70", Offset = "0x79D4870", VA = "0x1879D5A70")]
	[AsyncStateMachine(typeof(BOBPPHMPLKE))]
	private Task<(HOAPPKHGKNJ, long)> GAPKGGEPFKD(NCNEODEEIGF IPJPAHGOIMA, DGCCNGNLMNC NINGHLHEEFJ, long MGNAIIKHEOI, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x79D5C70", Offset = "0x79D4A70", VA = "0x1879D5C70")]
	[AsyncStateMachine(typeof(PBMICAMIMGL))]
	private Task<(HOAPPKHGKNJ, long)> JNDAKIDCFCD(NCNEODEEIGF HGBLDIKFFMM, DADBLAJODHB EDDAOOAAGLD, long MGNAIIKHEOI, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public FFNMOOOOECH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[UnityEngine.Scripting.Preserve]
internal sealed class OBMJDHNDLJK : NIDOHPOIPIJ, FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class BMAJNAFLDIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public LJLDKNMPHBD request;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public BMAJNAFLDIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x79CCF90", Offset = "0x79CBD90", VA = "0x1879CCF90")]
		internal object JGOLGJBNDEE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct MOGHBECHIMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public AsyncTaskMethodBuilder<LJLDKNMPHBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public LJLDKNMPHBD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public OBMJDHNDLJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public GHHFOGHNCBC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private TaskAwaiter<LJLDKNMPHBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x79E6D80", Offset = "0x79E5B80", VA = "0x1879E6D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x79E7390", Offset = "0x79E6190", VA = "0x1879E7390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct LPIAHJHMLNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<LJLDKNMPHBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public OBMJDHNDLJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public GHHFOGHNCBC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter<BBCHANAOOCF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x79E5DD0", Offset = "0x79E4BD0", VA = "0x1879E5DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x79E63D0", Offset = "0x79E51D0", VA = "0x1879E63D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class EPAHDOBCBKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public LJLDKNMPHBD request;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public EPAHDOBCBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x79D5750", Offset = "0x79D4550", VA = "0x1879D5750")]
		internal object MCIMKJELLEO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct GALAIGHODOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<LJLDKNMPHBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public LJLDKNMPHBD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public OBMJDHNDLJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public GHHFOGHNCBC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private ABMAHCGCFML <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private PENHCCJFEBM <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter<BBCHANAOOCF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x79D64F0", Offset = "0x79D52F0", VA = "0x1879D64F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x79D70E0", Offset = "0x79D5EE0", VA = "0x1879D70E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private JPDCMPIABBH JGDMKGHAADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private AIFNHGMNCND OKBCCMKAJBF;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private HNHOJCCKBFA HLPIJKOFDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x79E8280", Offset = "0x79E7080", VA = "0x1879E8280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x79E8800", Offset = "0x79E7600", VA = "0x1879E8800", Slot = "8")]
	public void JEELJGCJJCO(MLLAEEOLMLG FDPNEEAEJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x79E86A0", Offset = "0x79E74A0", VA = "0x1879E86A0", Slot = "4")]
	[AsyncStateMachine(typeof(MOGHBECHIMM))]
	public Task<LJLDKNMPHBD> HKAKIEEACFN(LJLDKNMPHBD HJFGAIAKKLJ, GHHFOGHNCBC FCEFEKCHPGK, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x79E83F0", Offset = "0x79E71F0", VA = "0x1879E83F0", Slot = "5")]
	[AsyncStateMachine(typeof(LPIAHJHMLNA))]
	public Task<LJLDKNMPHBD> GALNCOMCBGN(CancellationToken FEHCANHDGHE, GHHFOGHNCBC FCEFEKCHPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x79E8340", Offset = "0x79E7140", VA = "0x1879E8340", Slot = "6")]
	public JHFDLGICCMM DAFMGFIECIN(DAODPIEPEBN ECFPIHLAFMH, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x79E8890", Offset = "0x79E7690", VA = "0x1879E8890", Slot = "7")]
	public JHFDLGICCMM KHIIJFFGKFF(DAODPIEPEBN ECFPIHLAFMH, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x79E8540", Offset = "0x79E7340", VA = "0x1879E8540")]
	[AsyncStateMachine(typeof(GALAIGHODOG))]
	private Task<LJLDKNMPHBD> HINCIECBBIC(LJLDKNMPHBD HJFGAIAKKLJ, GHHFOGHNCBC FCEFEKCHPGK, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x333F410", Offset = "0x333E210", VA = "0x18333F410")]
	private static byte[] ADHFILONJLC(LJLDKNMPHBD KKBJAPCBOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public OBMJDHNDLJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class JLJFCHICECH : JONNIPABEJF, FLGLKCKJMGB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private ICNHOJHLBKE MIGKBMABFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private JPDCMPIABBH JGDMKGHAADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private GLPAIIHJPGB GDHDLLHDNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private OGOGEKFANJN DLEKJGHPHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private INCEBAAAKHE BPGIOHMMDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private MHINNMMEEGD BLGDEPKIECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private PLPOEFPEGII OIGGONMAIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private DAHLKJIKMOB LHCHLNOABPH;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private PLHOCBJJMOF ILIBPHFOENB
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x79E2C10", Offset = "0x79E1A10", VA = "0x1879E2C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private static MDFDKOJBEAB DFNKHLEFBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x79DACB0", Offset = "0x79D9AB0", VA = "0x1879DACB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x79E2C60", Offset = "0x79E1A60", VA = "0x1879E2C60", Slot = "6")]
	public void JEELJGCJJCO(MLLAEEOLMLG FDPNEEAEJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x79E30E0", Offset = "0x79E1EE0", VA = "0x1879E30E0", Slot = "4")]
	public MDFDKOJBEAB NPPIEEDOOPL(NJGJGBGCLGP ONBBHAJKJFI, KGAIIGHCNDA HFPALCMEFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x79E2DD0", Offset = "0x79E1BD0", VA = "0x1879E2DD0", Slot = "5")]
	public MDFDKOJBEAB LBJPHNLCMIP(NJGJGBGCLGP LJNPHJCIEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x79DA7F0", Offset = "0x79D95F0", VA = "0x1879DA7F0")]
	private static MDFDKOJBEAB CHIELPFDJMP(NKHMBKOCNEM ADJDIHDFFBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public JLJFCHICECH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class CLGDOJDGECD : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x79CF780", Offset = "0x79CE580", VA = "0x1879CF780")]
	public CLGDOJDGECD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x6D46700", Offset = "0x6D45500", VA = "0x186D46700")]
	public CLGDOJDGECD(string KKBJAPCBOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[UnityEngine.Scripting.Preserve]
internal sealed class DJGAJGHGPFJ : JLPJEIGMNDF, FLGLKCKJMGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct IGFBJOECFPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public AsyncTaskMethodBuilder<MDFDKOJBEAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public DJGAJGHGPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public GFONHMBPIOH autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private IGPFJOOPHMK<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private BHKENALHBGO <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter<MDFDKOJBEAB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x79DEF70", Offset = "0x79DDD70", VA = "0x1879DEF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x79DFAF0", Offset = "0x79DE8F0", VA = "0x1879DFAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct CGKBLFCEGDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public DJGAJGHGPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x79CED60", Offset = "0x79CDB60", VA = "0x1879CED60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x79CF4C0", Offset = "0x79CE2C0", VA = "0x1879CF4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct BDDFOKGAMHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public DJGAJGHGPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x79CCA20", Offset = "0x79CB820", VA = "0x1879CCA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x79CCF30", Offset = "0x79CBD30", VA = "0x1879CCF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct PFDGCIHCDBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public DJGAJGHGPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x79E9DA0", Offset = "0x79E8BA0", VA = "0x1879E9DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x79EA4F0", Offset = "0x79E92F0", VA = "0x1879EA4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct EKPMONKEJOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public DJGAJGHGPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x79D4840", Offset = "0x79D3640", VA = "0x1879D4840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x79D49E0", Offset = "0x79D37E0", VA = "0x1879D49E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct CBEJDBMJFPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public DJGAJGHGPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x79CDEC0", Offset = "0x79CCCC0", VA = "0x1879CDEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x79CE5F0", Offset = "0x79CD3F0", VA = "0x1879CE5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct GDOPGIFGIPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public DJGAJGHGPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x79D9090", Offset = "0x79D7E90", VA = "0x1879D9090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x79D9500", Offset = "0x79D8300", VA = "0x1879D9500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct LHMABNJDJFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public DJGAJGHGPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public BPFCEEPJHKL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private IGPFJOOPHMK<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x79E4D90", Offset = "0x79E3B90", VA = "0x1879E4D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x79E5300", Offset = "0x79E4100", VA = "0x1879E5300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private JPDCMPIABBH JGDMKGHAADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private MLLAEEOLMLG FDPNEEAEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private INCEBAAAKHE BPGIOHMMDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private NIDOHPOIPIJ PEOCKDDEKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private GLPAIIHJPGB GDHDLLHDNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private PLPOEFPEGII OIGGONMAIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private CancellationTokenSource PNKGGDDIDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private Task JFIIKPMCCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private TaskCompletionSource<int> DDHIMMKEFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private int NPFDMAGMBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private int MDOBHGLCFPN;

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x79D1470", Offset = "0x79D0270", VA = "0x1879D1470", Slot = "6")]
	public void JEELJGCJJCO(MLLAEEOLMLG FDPNEEAEJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x10D2C10", Offset = "0x10D1A10", VA = "0x1810D2C10", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x79D0F10", Offset = "0x79CFD10", VA = "0x1879D0F10")]
	private void GEPONKAJENB(float JDOKLKLFILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x79D0AF0", Offset = "0x79CF8F0", VA = "0x1879D0AF0", Slot = "4")]
	[AsyncStateMachine(typeof(IGFBJOECFPG))]
	public Task<MDFDKOJBEAB> BKFIHHEALPH(GFONHMBPIOH MFPHOGLGEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x79D1620", Offset = "0x79D0420", VA = "0x1879D1620", Slot = "5")]
	[AsyncStateMachine(typeof(CGKBLFCEGDL))]
	public Task KELCPGNAFBL([Optional] CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x10D2C10", Offset = "0x10D1A10", VA = "0x1810D2C10")]
	public void EEFGBNPJBDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x79D1990", Offset = "0x79D0790", VA = "0x1879D1990")]
	private BHKENALHBGO MOFLEOJCOPC(GFONHMBPIOH MFPHOGLGEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x79D1380", Offset = "0x79D0180", VA = "0x1879D1380")]
	[AsyncStateMachine(typeof(BDDFOKGAMHD))]
	private Task IIEJDMCCCDG(CancellationToken JHKFKNKNOJO, int NBBGNFGEDDB, BKBFPOLBAFH JJOKBEFEBKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x79D0E10", Offset = "0x79CFC10", VA = "0x1879D0E10")]
	[AsyncStateMachine(typeof(PFDGCIHCDBG))]
	private Task FHEPAPJNFGF(CancellationToken JHKFKNKNOJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x79D1710", Offset = "0x79D0510", VA = "0x1879D1710")]
	[AsyncStateMachine(typeof(EKPMONKEJOI))]
	private Task MHLLEPOIFMN([Optional] CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x79D0C20", Offset = "0x79CFA20", VA = "0x1879D0C20")]
	[AsyncStateMachine(typeof(CBEJDBMJFPA))]
	private Task CEGACKBEPJI(CancellationToken JHKFKNKNOJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x79D0D10", Offset = "0x79CFB10", VA = "0x1879D0D10")]
	[AsyncStateMachine(typeof(GDOPGIFGIPH))]
	private Task EHDAMCEKMKP(CancellationToken PFLJDJMOPNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x79D1800", Offset = "0x79D0600", VA = "0x1879D1800")]
	private Task MJBDILPDOAM(BPFCEEPJHKL MAPIMEJAPGE, CancellationToken JHKFKNKNOJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x79D1270", Offset = "0x79D0070", VA = "0x1879D1270")]
	[AsyncStateMachine(typeof(LHMABNJDJFL))]
	private Task GMLDKLHIDIH(BPFCEEPJHKL MAPIMEJAPGE, CancellationToken JHKFKNKNOJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x79D0FF0", Offset = "0x79CFDF0", VA = "0x1879D0FF0")]
	private bool GGGHPCGLOML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public DJGAJGHGPFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[UnityEngine.Scripting.Preserve]
internal class GDGBOMLLIKF : OGOGEKFANJN, FLGLKCKJMGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct MELDKIEGFKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public GDGBOMLLIKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private IGPFJOOPHMK<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x79E64B0", Offset = "0x79E52B0", VA = "0x1879E64B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x79E6A20", Offset = "0x79E5820", VA = "0x1879E6A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private HNACKPHJDOM GDJKMEBAFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private MLLAEEOLMLG FDPNEEAEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private JONNIPABEJF GKMJNCPIFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private NIDOHPOIPIJ PEOCKDDEKNJ;

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x79D8DB0", Offset = "0x79D7BB0", VA = "0x1879D8DB0", Slot = "6")]
	public void JEELJGCJJCO(MLLAEEOLMLG FDPNEEAEJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x79D8D00", Offset = "0x79D7B00", VA = "0x1879D8D00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x79D8C00", Offset = "0x79D7A00", VA = "0x1879D8C00", Slot = "5")]
	[AsyncStateMachine(typeof(MELDKIEGFKG))]
	public Task CINHBMOIDOO(string FIJDAMLGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x79D8D50", Offset = "0x79D7B50", VA = "0x1879D8D50", Slot = "4")]
	public MDFDKOJBEAB GGGHPCGLOML(NJGJGBGCLGP ONBBHAJKJFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x79D8B10", Offset = "0x79D7910", VA = "0x1879D8B10")]
	private OPNAGIKNEKI BCHKEOPEPOM(string FIJDAMLGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public GDGBOMLLIKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class NBMADFJKAMI
{
	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x79E7400", Offset = "0x79E6200", VA = "0x1879E7400")]
	public static void DOJCCIGBEHC(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x79E7640", Offset = "0x79E6440", VA = "0x1879E7640")]
	internal static void HFJIJAIOOKN(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x79E7BF0", Offset = "0x79E69F0", VA = "0x1879E7BF0")]
	internal static void OPACADFDPBO(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x79E77A0", Offset = "0x79E65A0", VA = "0x1879E77A0")]
	internal static void NPPILFJIPPG(IEPIHLKICIO BCNFHKMHIOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class ODKKKLNAGBF : IPNBMJKJOMM<LJLDKNMPHBD>
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class EBCNAKAFAHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public LJLDKNMPHBD message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public EBCNAKAFAHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x79D1B00", Offset = "0x79D0900", VA = "0x1879D1B00")]
		internal object DLKIIKHOKOI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly ODKKKLNAGBF GGJCMHODIEM;

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x79E8FC0", Offset = "0x79E7DC0", VA = "0x1879E8FC0")]
	public ExitGames.Client.Photon.Hashtable NPIKEPIONAB(LJLDKNMPHBD KKBJAPCBOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x79E9050", Offset = "0x79E7E50", VA = "0x1879E9050", Slot = "5")]
	protected override void OGPCFLKHHKD(LJLDKNMPHBD KKBJAPCBOHH, IDictionary<object, object> JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x79E89D0", Offset = "0x79E77D0", VA = "0x1879E89D0", Slot = "6")]
	public override LJLDKNMPHBD FEIAPADJKML(IDictionary<object, object> JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x79E8EB0", Offset = "0x79E7CB0", VA = "0x1879E8EB0")]
	private static void KAMAHCNLDOK(string NGIDBJPEGDH, LJLDKNMPHBD KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x79E9220", Offset = "0x79E8020", VA = "0x1879E9220")]
	public ODKKKLNAGBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x79E8C00", Offset = "0x79E7A00", VA = "0x1879E8C00")]
	[CompilerGenerated]
	internal static string IIJMFDLBAJM(JAJOICLCDFI KGDIEBJBNPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class GJMFFGHDABB
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public static MDFDKOJBEAB DFNKHLEFBLE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x79DACB0", Offset = "0x79D9AB0", VA = "0x1879DACB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x79DAD10", Offset = "0x79D9B10", VA = "0x1879DAD10")]
	public static bool LKCLEPPOAIH(this MDFDKOJBEAB FDBNMLEAMHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x79DA7F0", Offset = "0x79D95F0", VA = "0x1879DA7F0")]
	public static MDFDKOJBEAB CHIELPFDJMP(NKHMBKOCNEM JKHEMJOGAHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x79DA850", Offset = "0x79D9650", VA = "0x1879DA850")]
	public static MDFDKOJBEAB HJCHKLGMAAK(IEnumerable<MDFDKOJBEAB> AGABGMGDJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x79DAA50", Offset = "0x79D9850", VA = "0x1879DAA50")]
	public static string IEABLEGCJDN(this MDFDKOJBEAB LDEANEOLAOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public abstract class GBIAJKIANDF : MKFMNDJHFCF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public delegate MDFDKOJBEAB PPIPOGJEPJF([NotNull] NJGJGBGCLGP KJPFMIPALHF);

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class IHLDGANNFOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public NJGJGBGCLGP photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public IHLDGANNFOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F55EE0", Offset = "0x6F54CE0", VA = "0x186F55EE0")]
		internal MDFDKOJBEAB OCLGJLEKLND(PPIPOGJEPJF v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private bool BBDDFKFCEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	protected readonly HashSet<PPIPOGJEPJF> MDENMJOONLO;

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x79D71A0", Offset = "0x79D5FA0", VA = "0x1879D71A0", Slot = "4")]
	public void FHMLOOMENHD(PPIPOGJEPJF NHFKNKHCAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x79D7200", Offset = "0x79D6000", VA = "0x1879D7200", Slot = "5")]
	public void FKPOLNFCPHP(PPIPOGJEPJF NHFKNKHCAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x79D7150", Offset = "0x79D5F50", VA = "0x1879D7150", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x79D7260", Offset = "0x79D6060", VA = "0x1879D7260")]
	protected MDFDKOJBEAB KMEAIBFOEPC(NJGJGBGCLGP LJNPHJCIEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x79D7500", Offset = "0x79D6300", VA = "0x1879D7500")]
	protected GBIAJKIANDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class PKEIBANLDEM : GBIAJKIANDF, ICNHOJHLBKE, MKFMNDJHFCF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private sealed class ENIAJCHMIFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public MDFDKOJBEAB result;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ENIAJCHMIFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x79D4A40", Offset = "0x79D3840", VA = "0x1879D4A40")]
		internal object EOHNNAODKOH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x79E80F0", Offset = "0x79E6EF0", VA = "0x1879E80F0")]
	[UnityEngine.Scripting.Preserve]
	public PKEIBANLDEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x79EA650", Offset = "0x79E9450", VA = "0x1879EA650", Slot = "8")]
	public MDFDKOJBEAB HFACFHMOJEJ(NJGJGBGCLGP LJNPHJCIEAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class NMBBNFAJGMH : GBIAJKIANDF, HNACKPHJDOM, MKFMNDJHFCF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private sealed class GOMBLAEDJEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public MDFDKOJBEAB result;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public GOMBLAEDJEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x79DDA40", Offset = "0x79DC840", VA = "0x1879DDA40")]
		internal object BEOKAANJHCD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x79E80F0", Offset = "0x79E6EF0", VA = "0x1879E80F0")]
	[UnityEngine.Scripting.Preserve]
	public NMBBNFAJGMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x79E7FE0", Offset = "0x79E6DE0", VA = "0x1879E7FE0", Slot = "8")]
	public MDFDKOJBEAB GGGHPCGLOML(NJGJGBGCLGP ANICBEHNGEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class CLDACNOEMNO
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private sealed class CDNIPBFCLGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public IGPFJOOPHMK<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public CDNIPBFCLGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x79CECE0", Offset = "0x79CDAE0", VA = "0x1879CECE0")]
		internal object NKFGBECPAJK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x79CF5E0", Offset = "0x79CE3E0", VA = "0x1879CF5E0")]
	public static IGPFJOOPHMK<string> LOCJHGEGGDA(IMOCAMGHNDM JBCGOBEIKAJ, [Optional] string LIIDAJEPFKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x79CF6C0", Offset = "0x79CE4C0", VA = "0x1879CF6C0")]
	public static void OPMFKHFOIGB(IGPFJOOPHMK<string> HPEGCCHCIAG, IMOCAMGHNDM JBCGOBEIKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x79CF520", Offset = "0x79CE320", VA = "0x1879CF520")]
	public static string LIFDHDCCPBI(LJLDKNMPHBD ILCGOKLBNKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal static class OJMLPJPGAHJ
{
	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x79E9390", Offset = "0x79E8190", VA = "0x1879E9390")]
	public static void KALEIGOGILF(this JPDCMPIABBH JGDMKGHAADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x79E9260", Offset = "0x79E8060", VA = "0x1879E9260")]
	public static void AOGPMNFKADB(this JPDCMPIABBH JGDMKGHAADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x79E9270", Offset = "0x79E8070", VA = "0x1879E9270")]
	private static void HDAHKJKBLBC(this JPDCMPIABBH JGDMKGHAADE, bool OAMOFJBDKPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class KGIHKCACEHI : EDBBGKIFBCP, BGKAAKEFMJD, NFKMAPENCHO, BEFKALFKEOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private readonly BGKAAKEFMJD PGLFICGNEHM;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public NJGJGBGCLGP ODOCIEIBPNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x79E3660", Offset = "0x79E2460", VA = "0x1879E3660", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public int MBABJMLFFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x79E3610", Offset = "0x79E2410", VA = "0x1879E3610", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int NOBIPACHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x79E36B0", Offset = "0x79E24B0", VA = "0x1879E36B0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool KMMCJNIIPIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public int ACGCAKLNIKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xA9F400", Offset = "0xA9E200", VA = "0x180A9F400", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event NLCGHLOHGFI.MHKLANLDIFM MCGKEAGBOCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event CMBGPHLIBJD NACIKADHIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x79E32F0", Offset = "0x79E20F0", VA = "0x1879E32F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x79E3250", Offset = "0x79E2050", VA = "0x1879E3250", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> HGBKINMIAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<NJGJGBGCLGP> JOICHOMAGLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action GHECFJOFHON
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x79E34C0", Offset = "0x79E22C0", VA = "0x1879E34C0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x79E3700", Offset = "0x79E2500", VA = "0x1879E3700", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0xBC23B0", Offset = "0xBC11B0", VA = "0x180BC23B0")]
	public KGIHKCACEHI(BGKAAKEFMJD PGLFICGNEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x79E3560", Offset = "0x79E2360", VA = "0x1879E3560", Slot = "8")]
	public bool KONLLGNJJDK(byte MEEKNBJKNCI, ExitGames.Client.Photon.Hashtable EGFOPBIAGPP, FMNMLIKOHDM CDFMBEECIMO, SendOptions AOEKNNILKFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x79E3390", Offset = "0x79E2190", VA = "0x1879E3390", Slot = "16")]
	public NJGJGBGCLGP HOKBACFMOEN(int JFPAEBMEBNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "19")]
	public void AEAMHCEBFOD(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "20")]
	public void DPGOBIPNGHB(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "21")]
	public void GOADNFGAJMG(object HACFGBHNOCC, bool FKNLOMIJIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x79E3470", Offset = "0x79E2270", VA = "0x1879E3470", Slot = "22")]
	public IDisposable IGEOGGJAIDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "23")]
	private bool OFGGGOAMFJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "24")]
	public void CLOBGHOIKCP(StringBuilder MBLHMIPFEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0xDF00D0", Offset = "0xDEEED0", VA = "0x180DF00D0", Slot = "25")]
	public bool JNCCEDINFDA(bool HNPNFFGCLDF, [Out] string LKNDCPLLKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0xD5F2B0", Offset = "0xD5E0B0", VA = "0x180D5F2B0", Slot = "28")]
	public void FBHMKPEJFLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct IABDLELGCHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private readonly IDictionary<object, object> NEPCFFIOLCP;

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE4F40", VA = "0x180BE6140")]
	public IABDLELGCHA(IDictionary<object, object> NEPCFFIOLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x79DDE10", Offset = "0x79DCC10", VA = "0x1879DDE10")]
	public bool HFFOGNDDCLP([Out] LJLDKNMPHBD KKBJAPCBOHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x79DDD60", Offset = "0x79DCB60", VA = "0x1879DDD60")]
	public Guid FHGKJIHDHBJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x79DDEC0", Offset = "0x79DCCC0", VA = "0x1879DDEC0")]
	public MDFDKOJBEAB IDPABDICFMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x79DDC70", Offset = "0x79DCA70", VA = "0x1879DDC70")]
	public static ExitGames.Client.Photon.Hashtable DCMOGLEGFAE(LJLDKNMPHBD KKBJAPCBOHH, MDFDKOJBEAB FDBNMLEAMHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal static class GMDHLBHDNCN
{
	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x79DD080", Offset = "0x79DBE80", VA = "0x1879DD080")]
	public static bool ONOILMKFNPN(this NCNEODEEIGF HBGCIECBLBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct BNKKIKJOEFE : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct EJNFHBLAABK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public BNKKIKJOEFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x79D4600", Offset = "0x79D3400", VA = "0x1879D4600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x79D47E0", Offset = "0x79D35E0", VA = "0x1879D47E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private readonly CancellationTokenSource PCBNIHHNEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	private bool BBDDFKFCEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private Task BDCCICFJHCL;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool JJCPGCBCCEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x79CD150", Offset = "0x79CBF50", VA = "0x1879CD150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x79CD180", Offset = "0x79CBF80", VA = "0x1879CD180")]
	public BNKKIKJOEFE(CancellationToken FEHCANHDGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x79CCFF0", Offset = "0x79CBDF0", VA = "0x1879CCFF0")]
	[AsyncStateMachine(typeof(EJNFHBLAABK))]
	public Task CDDJHLLIBBJ(Func<CancellationToken, List<Task>> LLNKNHKIEHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x79CD100", Offset = "0x79CBF00", VA = "0x1879CD100", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public readonly struct EOAGCJJKFDL<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct CHFEKIHBKMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<BJKDDMAILKD<TData>, MFMDDJMMGHP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public EOAGCJJKFDL<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private TaskAwaiter<PGOLMGNGGBM<BJKDDMAILKD<TData>, MFMDDJMMGHP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x5960DD0", Offset = "0x595FBD0", VA = "0x185960DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x4524F80", Offset = "0x4523D80", VA = "0x184524F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private readonly BBEMAPAMDMB<TGetDataArg, TData> IKKBNFCGFBJ;

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE4F40", VA = "0x180BE6140")]
	internal EOAGCJJKFDL(BBEMAPAMDMB<TGetDataArg, TData> FLOGLGIGMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x4004190", Offset = "0x4002F90", VA = "0x184004190")]
	[AsyncStateMachine(typeof(EOAGCJJKFDL<, >.CHFEKIHBKMC))]
	public Task<PGOLMGNGGBM<BJKDDMAILKD<TData>, MFMDDJMMGHP>> GJPHPEENFKM(TGetDataArg BFLKHJBBCJI, string IEEMLCGJPPO, IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class NIEHKFKEBIM
{
	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x30F23B0", Offset = "0x30F11B0", VA = "0x1830F23B0")]
	public static EOAGCJJKFDL<TGetDataArg, TData> MKHEJJEDOII<TGetDataArg, TData>(BBEMAPAMDMB<TGetDataArg, TData> FLOGLGIGMAI)
	{
		return default(EOAGCJJKFDL<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public struct OBBMCONLNJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public readonly int JNFIGJDPHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public readonly int? BBCPPMEHPKB;

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x4A364D0", Offset = "0x4A352D0", VA = "0x184A364D0")]
	public OBBMCONLNJK(int KAKBGJICBGD, [Optional] int? AJLNBGKLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x79E81A0", Offset = "0x79E6FA0", VA = "0x1879E81A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface AIOPIPDFBOF<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJJOGHOOAGM();

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AIOPIPDFBOF<T> IKBLPHFODPN(string PGIAAHGDEIH);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AIOPIPDFBOF<T> DPPFEPKFLII(PJGMECONIBP<T> DLMLIKAGJFJ);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AIOPIPDFBOF<T> IADMDFIBINJ(int INHEKIONAPA);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AIOPIPDFBOF<T> KCMOJOAGCKA(int INHEKIONAPA, AFDJCPICGBA<T> ICAKEEODFHF);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface GKHGIFENKMB
{
	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AIOPIPDFBOF<T> CKMAFEOMIDH<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HDHLAFFAHBN NKGEMHMFGBC(Exception JGLOLGKKBMI);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OBBMCONLNJK LOEDFKMGCBJ(Exception JGLOLGKKBMI);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public delegate string PJGMECONIBP<in T>(T JGLOLGKKBMI) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public delegate int AFDJCPICGBA<in T>(T JGLOLGKKBMI) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class ECPCPOJONBH : GKHGIFENKMB
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private delegate string ICEGHHIPPPN(Exception JGLOLGKKBMI);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private delegate int CJBIGIOMJME(Exception JGLOLGKKBMI);

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class HDLNPIAKFJJ<T> : AIOPIPDFBOF<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class BEICGGFHPML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public BEICGGFHPML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
			internal string DMKBDHNHDOM(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class LOPBBPIMGCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public PJGMECONIBP<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public LOPBBPIMGCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x452A390", Offset = "0x4529190", VA = "0x18452A390")]
			internal string MCHFONAJLNL(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class ANLBHKPHBPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public AFDJCPICGBA<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public ANLBHKPHBPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x452A390", Offset = "0x4529190", VA = "0x18452A390")]
			internal int IPCLJBIMPAJ(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private readonly ECPCPOJONBH ELFLKDBDJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private readonly Type GGEOPKHFGKP;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x4554A60", Offset = "0x4553860", VA = "0x184554A60")]
		internal HDLNPIAKFJJ(ECPCPOJONBH ELFLKDBDJPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x4554900", Offset = "0x4553700", VA = "0x184554900", Slot = "4")]
		public void JJJOGHOOAGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x45547E0", Offset = "0x45535E0", VA = "0x1845547E0", Slot = "5")]
		public AIOPIPDFBOF<T> IKBLPHFODPN(string PGIAAHGDEIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x4554680", Offset = "0x4553480", VA = "0x184554680", Slot = "6")]
		public AIOPIPDFBOF<T> DPPFEPKFLII(PJGMECONIBP<T> DLMLIKAGJFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x45547A0", Offset = "0x45535A0", VA = "0x1845547A0", Slot = "7")]
		public AIOPIPDFBOF<T> IADMDFIBINJ(int INHEKIONAPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x4554930", Offset = "0x4553730", VA = "0x184554930", Slot = "8")]
		public AIOPIPDFBOF<T> KCMOJOAGCKA(int INHEKIONAPA, AFDJCPICGBA<T> ICAKEEODFHF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class ODPIGBJCODK<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private bool OGHGKNJJOAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly List<Type> FHCLLGENFMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private readonly Dictionary<Type, TVal> BADGNDIADDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private readonly Dictionary<Type, int> PIBJLLPJAMG;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public IReadOnlyList<Type> FAJGFGEMGCH
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x4E31ED0", Offset = "0x4E30CD0", VA = "0x184E31ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x4E32170", Offset = "0x4E30F70", VA = "0x184E32170")]
		public ODPIGBJCODK(Dictionary<Type, int> PIBJLLPJAMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x4E31D70", Offset = "0x4E30B70", VA = "0x184E31D70")]
		public void MDGAONDGEMG(Type FFOHLCGHDKA, TVal OAJCPHOOFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x4E31D20", Offset = "0x4E30B20", VA = "0x184E31D20")]
		public bool GIFMIOFAEFD(Type GGEOPKHFGKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x4E31CD0", Offset = "0x4E30AD0", VA = "0x184E31CD0")]
		public bool EDFMKGHIOIB(TVal IPHILEOFJLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x4AAED10", Offset = "0x4AADB10", VA = "0x184AAED10")]
		public TVal ANFJBBFMPMK(Type OBDHBADPJNM)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x4E320D0", Offset = "0x4E30ED0", VA = "0x184E320D0")]
		[CompilerGenerated]
		private int OJNKOOHCOKL(Type POKMNHJFHIH, Type OFINLDLGKEH)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class IPHMOCKMCAB : IEnumerable<OBBMCONLNJK>, IEnumerable, IEnumerator<OBBMCONLNJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private OBBMCONLNJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public ECPCPOJONBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private IEnumerator<OBBMCONLNJK> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private OBBMCONLNJK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0x40629D0", Offset = "0x40617D0", VA = "0x1840629D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(OBBMCONLNJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x79E2A70", Offset = "0x79E1870", VA = "0x1879E2A70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xC3B4C0", Offset = "0xC3A2C0", VA = "0x180C3B4C0")]
		[DebuggerHidden]
		public IPHMOCKMCAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x79E2AC0", Offset = "0x79E18C0", VA = "0x1879E2AC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x79E24B0", Offset = "0x79E12B0", VA = "0x1879E24B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x79E2410", Offset = "0x79E1210", VA = "0x1879E2410")]
		private void GEDOPIMJGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x79E2460", Offset = "0x79E1260", VA = "0x1879E2460")]
		private void HHOEFEHKFHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x79E2A20", Offset = "0x79E1820", VA = "0x1879E2A20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x79E2960", Offset = "0x79E1760", VA = "0x1879E2960", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OBBMCONLNJK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x79E2960", Offset = "0x79E1760", VA = "0x1879E2960", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private static readonly OBBMCONLNJK LIKIONOMFCF;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private static readonly Dictionary<Type, int> CNKMMEFNLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly HashSet<Type> NPNFIEFHMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly ODPIGBJCODK<int> GKHFGKOPGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private readonly ODPIGBJCODK<CJBIGIOMJME> KDEOFOGIJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly ODPIGBJCODK<ICEGHHIPPPN> CMNENGOJOFB;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x79D3120", Offset = "0x79D1F20", VA = "0x1879D3120")]
	[FOLINPJCBJN.HMBDLNHFFEJ.EKAOCHOMHGE]
	internal static void PIKBCINMJOC(IEPIHLKICIO JMPMFBCPFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x79D3260", Offset = "0x79D2060", VA = "0x1879D3260")]
	[RecRoom.NoEngine.Common.Preserve]
	public ECPCPOJONBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x3161CF0", Offset = "0x3160AF0", VA = "0x183161CF0", Slot = "4")]
	public AIOPIPDFBOF<T> CKMAFEOMIDH<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x79D2F10", Offset = "0x79D1D10", VA = "0x1879D2F10", Slot = "5")]
	public HDHLAFFAHBN NKGEMHMFGBC(Exception JGLOLGKKBMI)
	{
		return default(HDHLAFFAHBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x79D2C30", Offset = "0x79D1A30", VA = "0x1879D2C30", Slot = "6")]
	public OBBMCONLNJK LOEDFKMGCBJ(Exception? JGLOLGKKBMI)
	{
		return default(OBBMCONLNJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x79D2B90", Offset = "0x79D1990", VA = "0x1879D2B90", Slot = "7")]
	[IteratorStateMachine(typeof(IPHMOCKMCAB))]
	public IEnumerable<OBBMCONLNJK> LGGCEJHCBCD(Exception JGLOLGKKBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x79D2770", Offset = "0x79D1570", VA = "0x1879D2770", Slot = "8")]
	public string EGIIOFLKGJI(Exception? JGLOLGKKBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x79D2210", Offset = "0x79D1010", VA = "0x1879D2210")]
	private string CFEONKHFBJF(AggregateException KJJEOJPBLHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x79D1E60", Offset = "0x79D0C60", VA = "0x1879D1E60")]
	private void AEOKKIHBHOA(Type GGEOPKHFGKP, int INHEKIONAPA, CJBIGIOMJME? OEPGFJCEFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x79D2520", Offset = "0x79D1320", VA = "0x1879D2520")]
	private void DNMBLPNBEDP(Type GGEOPKHFGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x79D28C0", Offset = "0x79D16C0", VA = "0x1879D28C0")]
	private void JPDMFDMPBFF(Type GGEOPKHFGKP, ICEGHHIPPPN EMCPFHMKGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x79D2FA0", Offset = "0x79D1DA0", VA = "0x1879D2FA0")]
	private static int OLJGJCAGCGA(Type GGEOPKHFGKP, Dictionary<Type, int> PIBJLLPJAMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x3161D80", Offset = "0x3160B80", VA = "0x183161D80")]
	private static bool NOECMHDFFGN<TVal>(ODPIGBJCODK<TVal> DCFFMJLJGJB, Type GGEOPKHFGKP, [Out] TVal IPHILEOFJLB) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x79D2E30", Offset = "0x79D1C30", VA = "0x1879D2E30")]
	[CompilerGenerated]
	internal static int NCGNACPMNBG(Type DEMLLKKAFJL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public struct HDHLAFFAHBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public readonly OBBMCONLNJK ELFGBEIOONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public readonly string LNHMOMIDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x79DDBF0", Offset = "0x79DC9F0", VA = "0x1879DDBF0")]
	public HDHLAFFAHBN(string ALBHKAFFNHK, OBBMCONLNJK INHEKIONAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x79DDB50", Offset = "0x79DC950", VA = "0x1879DDB50")]
	public string MDEHOAHJOGF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class IKHJLIGMDLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private readonly PIDAIGGFAFH FOGJLMAPDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private string ECKKCICKLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private long? NPAPELIKLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private long? PHHBHEIGGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private long? IHHJDANDJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private string GBHPEGMALII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private IPCAKDAELIK JOEGNANMADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private long? HIFHACILGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private bool CHOMJFPOAOP;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string BOPDMKPIHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public long OHLAKBKAIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x79E1360", Offset = "0x79E0160", VA = "0x1879E1360")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long MICKHAHDHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x79E1300", Offset = "0x79E0100", VA = "0x1879E1300")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public long MGKBJFMKMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x79E1BD0", Offset = "0x79E09D0", VA = "0x1879E1BD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public string IFHDCOLLLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x79E1550", Offset = "0x79E0350", VA = "0x1879E1550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public IPCAKDAELIK OBDOAFKBJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xC2A540", Offset = "0xC29340", VA = "0x180C2A540")]
		get
		{
			return default(IPCAKDAELIK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x79E13C0", Offset = "0x79E01C0", VA = "0x1879E13C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public long HLOPECPHMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x79E20C0", Offset = "0x79E0EC0", VA = "0x1879E20C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x79E2120", Offset = "0x79E0F20", VA = "0x1879E2120")]
	[UnityEngine.Scripting.Preserve]
	public IKHJLIGMDLA([MHFJPMCEEAM(null)] PIDAIGGFAFH FOGJLMAPDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x79E1590", Offset = "0x79E0390", VA = "0x1879E1590")]
	private void KLOEDBELPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x79E1C30", Offset = "0x79E0A30", VA = "0x1879E1C30")]
	public void OAJMMGNBPHO(long OGMIFIGJENM, long MGNAIIKHEOI, [Optional] long? GPNMOJOEGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x79E14B0", Offset = "0x79E02B0", VA = "0x1879E14B0")]
	public void JLKMAEGIEAF(long GPNMOJOEGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x79E1B50", Offset = "0x79E0950", VA = "0x1879E1B50")]
	public void LBLGKKECKCH(string JNFIKAKAPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x79E17E0", Offset = "0x79E05E0", VA = "0x1879E17E0")]
	public void LAKOHEFJKNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal class JHFDLGICCMM : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct NDDJGGCPHND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder<LJLDKNMPHBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public LJLDKNMPHBD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public JHFDLGICCMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private TaskAwaiter<HNHOJCCKBFA.PJJEEILLOKA<LJLDKNMPHBD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x79FCAF0", Offset = "0x79FB8F0", VA = "0x1879FCAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x79FD030", Offset = "0x79FBE30", VA = "0x1879FD030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct ICIDNHDIBOJ<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class BIDCFDHACKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public LJLDKNMPHBD roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public BIDCFDHACKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x79ED370", Offset = "0x79EC170", VA = "0x1879ED370")]
		internal LJLDKNMPHBD JFKONFHDLPF(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct POBLDPAMFAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public AsyncTaskMethodBuilder<HNHOJCCKBFA.PJJEEILLOKA<LJLDKNMPHBD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public LJLDKNMPHBD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public JHFDLGICCMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private ABMAHCGCFML <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private TaskAwaiter<HNHOJCCKBFA.PJJEEILLOKA<LJLDKNMPHBD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x7A029C0", Offset = "0x7A017C0", VA = "0x187A029C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x7A02FD0", Offset = "0x7A01DD0", VA = "0x187A02FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct GMKBBOPCAKL<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public JHFDLGICCMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x44D28A0", Offset = "0x44D16A0", VA = "0x1844D28A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x3C61B90", Offset = "0x3C60990", VA = "0x183C61B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct EIBKCNINPNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public JHFDLGICCMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x79F3030", Offset = "0x79F1E30", VA = "0x1879F3030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x79F31F0", Offset = "0x79F1FF0", VA = "0x1879F31F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class BADPLCOBPOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public BADPLCOBPOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x79ED0C0", Offset = "0x79EBEC0", VA = "0x1879ED0C0")]
		internal object OEOIEIAFDPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x79ED000", Offset = "0x79EBE00", VA = "0x1879ED000")]
		internal bool BNJHPCPDLLL(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class CJNEDHAMPML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public CJNEDHAMPML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x79EE2C0", Offset = "0x79ED0C0", VA = "0x1879EE2C0")]
		internal object EJDAEKBCKOM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class KJLBBDCFPLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public KJLBBDCFPLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x79F9E10", Offset = "0x79F8C10", VA = "0x1879F9E10")]
		internal object IEANPFIKPGA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class EIICKDDICAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public EIICKDDICAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x79F3250", Offset = "0x79F2050", VA = "0x1879F3250")]
		internal object HMKGBFMNAFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class HMFINCOGJNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public JHFDLGICCMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public HMFINCOGJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x79F7220", Offset = "0x79F6020", VA = "0x1879F7220")]
		internal object DLKIIKHOKOI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private static readonly Guid LKEJPODFEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public readonly DAODPIEPEBN BALKOHALHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly HNHOJCCKBFA CFLLMHKOOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private readonly NFKMAPENCHO JGDMKGHAADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private readonly BEFKALFKEOD FAHLIJNNDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private bool OKFEJBJDCMB;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x79F9820", Offset = "0x79F8620", VA = "0x1879F9820")]
	public JHFDLGICCMM(DAODPIEPEBN GOPOAFOKCPE, HNHOJCCKBFA CFLLMHKOOAC, NFKMAPENCHO JGDMKGHAADE, BEFKALFKEOD FAHLIJNNDFN, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x79F8940", Offset = "0x79F7740", VA = "0x1879F8940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x79F8690", Offset = "0x79F7490", VA = "0x1879F8690")]
	public void AKKKCDLBEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x79F8880", Offset = "0x79F7680", VA = "0x1879F8880")]
	public void DLDMDHILHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x79F96F0", Offset = "0x79F84F0", VA = "0x1879F96F0")]
	public void PKOIFMHACIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x79F8A60", Offset = "0x79F7860", VA = "0x1879F8A60")]
	[AsyncStateMachine(typeof(NDDJGGCPHND))]
	internal Task<LJLDKNMPHBD> GFLGEPKPKDL(IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, LJLDKNMPHBD ILCGOKLBNKC, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x333F410", Offset = "0x333E210", VA = "0x18333F410")]
	private static byte[] OPJAGBCOBIC<T>(T KKBJAPCBOHH) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x333F420", Offset = "0x333E220", VA = "0x18333F420")]
	private static T PBEBMEHFIAO<T>(MessageParser<T> BBNDDPIDNBI, byte[] KKBJAPCBOHH, T KLINFFNPOHN) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x79F8EF0", Offset = "0x79F7CF0", VA = "0x1879F8EF0")]
	[AsyncStateMachine(typeof(POBLDPAMFAN))]
	private Task<HNHOJCCKBFA.PJJEEILLOKA<LJLDKNMPHBD>> JDPJMDNOPBH(LJLDKNMPHBD ILCGOKLBNKC, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x333EEC0", Offset = "0x333DCC0", VA = "0x18333EEC0")]
	[AsyncStateMachine(typeof(GMKBBOPCAKL<>))]
	internal Task<T> HINMDDKLMJE<T>(CancellationToken JHKFKNKNOJO, Func<CancellationToken, Task<T>> LFKIJLCLOCM, int GOOIAAHBDJI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x79F8BC0", Offset = "0x79F79C0", VA = "0x1879F8BC0")]
	[AsyncStateMachine(typeof(EIBKCNINPNO))]
	internal Task HINMDDKLMJE(CancellationToken JHKFKNKNOJO, Func<CancellationToken, Task> LFKIJLCLOCM, int GOOIAAHBDJI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x79F9140", Offset = "0x79F7F40", VA = "0x1879F9140")]
	public OANOFMFOEJL KKGKBJBFNNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x79F87B0", Offset = "0x79F75B0", VA = "0x1879F87B0")]
	public PAHHOIJPGIG CIOMGGLKHPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x79F8CF0", Offset = "0x79F7AF0", VA = "0x1879F8CF0")]
	public GKDCEEMHMOI IOCCENKBEOP([Optional] IMOCAMGHNDM? JBCGOBEIKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x79F9340", Offset = "0x79F8140", VA = "0x1879F9340")]
	public void NLJJJPMDDHK(Func<Guid, bool> PDPCBJHHJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x79F94A0", Offset = "0x79F82A0", VA = "0x1879F94A0")]
	public void OFFIEJNJFGH(Func<Guid, bool> FOMOHGDFDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x79F91C0", Offset = "0x79F7FC0", VA = "0x1879F91C0")]
	public Guid NAALLEAMKDB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x79F8950", Offset = "0x79F7750", VA = "0x1879F8950")]
	public void EFOPLHKPNJK(Guid FEMFKCOMIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x79F95B0", Offset = "0x79F83B0", VA = "0x1879F95B0")]
	public void PAJNODCEIGA(LJLDKNMPHBD FEMOBGLDBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x79F9030", Offset = "0x79F7E30", VA = "0x1879F9030")]
	public void KAMAHCNLDOK(string HGMDMLENFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x333EDE0", Offset = "0x333DBE0", VA = "0x18333EDE0")]
	private T FCEFNBDIFMN<T>(T IPHILEOFJLB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x79F8830", Offset = "0x79F7630", VA = "0x1879F8830")]
	public void DABBHGHHDKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x333F160", Offset = "0x333DF60", VA = "0x18333F160")]
	[CompilerGenerated]
	internal static string HOMLMJGBEJE<T>(byte[] MDJJEFJEKNO, int FICGKJMEBJG, ICIDNHDIBOJ<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal sealed class IDDAPINHIOH : DAODPIEPEBN
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class GIIODJCHEHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public GIIODJCHEHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x79F6180", Offset = "0x79F4F80", VA = "0x1879F6180")]
		internal object HKOLEGPFFOA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct KLPIKHBLJGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public IDDAPINHIOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public JHFDLGICCMM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private DLPEEKOIOEF <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private PAHHOIJPGIG <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x79F9E80", Offset = "0x79F8C80", VA = "0x1879F9E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x79FA750", Offset = "0x79F9550", VA = "0x1879FA750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct NHEFABLNDDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public IDDAPINHIOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private TaskAwaiter<DGCCNGNLMNC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x79FD0A0", Offset = "0x79FBEA0", VA = "0x1879FD0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x79FD7E0", Offset = "0x79FC5E0", VA = "0x1879FD7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct LBPBHBFNFNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public IDDAPINHIOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private TaskAwaiter<KGAIHJLHFDH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x79FAAF0", Offset = "0x79F98F0", VA = "0x1879FAAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x79FAE00", Offset = "0x79F9C00", VA = "0x1879FAE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class LAMHOJPADHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public DLPEEKOIOEF presence;

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public LAMHOJPADHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x79FA9B0", Offset = "0x79F97B0", VA = "0x1879FA9B0")]
		internal object KIBBENEIOBL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private static readonly IMOCAMGHNDM JPIJNFLANHJ;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private static readonly IMOCAMGHNDM FKMFKJFKGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000389")]
	private readonly JAJOICLCDFI DADIHNFCDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400038A")]
	private readonly NCNEODEEIGF GCFPOGJCBGJ;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x79F7F50", Offset = "0x79F6D50", VA = "0x1879F7F50")]
	public IDDAPINHIOH(JAJOICLCDFI DADIHNFCDHB, NCNEODEEIGF GCFPOGJCBGJ, Guid KCDDPKBGHIL, MLLAEEOLMLG FDPNEEAEJHK, GHHFOGHNCBC MOLBFJBMEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x79F7950", Offset = "0x79F6750", VA = "0x1879F7950", Slot = "7")]
	[AsyncStateMachine(typeof(KLPIKHBLJGK))]
	protected override Task AOFOCBNPBGO(JHFDLGICCMM DGPBANFJJEC, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x79F7A90", Offset = "0x79F6890", VA = "0x1879F7A90")]
	[AsyncStateMachine(typeof(NHEFABLNDDJ))]
	private Task FFJIHLEJILC(CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x79F7D60", Offset = "0x79F6B60", VA = "0x1879F7D60")]
	[AsyncStateMachine(typeof(LBPBHBFNFNI))]
	private Task<int> PLDABJFIMDE(CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x79F7B90", Offset = "0x79F6990", VA = "0x1879F7B90")]
	private DLPEEKOIOEF HJAJEPIBJNN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class BHKENALHBGO : DAODPIEPEBN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct DFDJMENEPLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public BHKENALHBGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public JHFDLGICCMM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private TaskAwaiter<LBFPONJCALF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x79F0360", Offset = "0x79EF160", VA = "0x1879F0360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x79F0D00", Offset = "0x79EFB00", VA = "0x1879F0D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private readonly int NBJGOHGCOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	private readonly GFONHMBPIOH MCNBGALBPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public readonly long IPJEADBLJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public readonly long FFCNEONJDNC;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public LBFPONJCALF JDDMDCHINMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x8FC330", Offset = "0x8FB130", VA = "0x1808FC330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x8FC490", Offset = "0x8FB290", VA = "0x1808FC490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x79ED240", Offset = "0x79EC040", VA = "0x1879ED240")]
	public BHKENALHBGO(Guid KCDDPKBGHIL, MLLAEEOLMLG FDPNEEAEJHK, GHHFOGHNCBC MOLBFJBMEMG, int NBJGOHGCOFP, GFONHMBPIOH MCNBGALBPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x79ED120", Offset = "0x79EBF20", VA = "0x1879ED120", Slot = "7")]
	[AsyncStateMachine(typeof(DFDJMENEPLJ))]
	protected override Task AOFOCBNPBGO(JHFDLGICCMM DGPBANFJJEC, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class HHIPDONCMDL : DAODPIEPEBN
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class DCALNHKKEDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public HHIPDONCMDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public NFELCOGLGCD playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public DCALNHKKEDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x79F01D0", Offset = "0x79EEFD0", VA = "0x1879F01D0")]
		internal Task PCPCDFBCGEG(IGPFJOOPHMK<string>.PDLCJKJEJBF postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x79F0140", Offset = "0x79EEF40", VA = "0x1879F0140")]
		internal object KHANNKPCECD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct HKDJBDBPDCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public HHIPDONCMDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public JHFDLGICCMM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private DCALNHKKEDF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x79F6A00", Offset = "0x79F5800", VA = "0x1879F6A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x79F71C0", Offset = "0x79F5FC0", VA = "0x1879F71C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct AHJKEOICBJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public NFELCOGLGCD playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public HHIPDONCMDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x79EC8E0", Offset = "0x79EB6E0", VA = "0x1879EC8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x79ECE80", Offset = "0x79EBC80", VA = "0x1879ECE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x79F69B0", Offset = "0x79F57B0", VA = "0x1879F69B0")]
	public HHIPDONCMDL(Guid KCDDPKBGHIL, MLLAEEOLMLG FDPNEEAEJHK, GHHFOGHNCBC MOLBFJBMEMG, string INDOHCHMIPJ, ADNACPKIBIF OCBLIALNMGI, bool KFBCAHIJLBM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x79F6870", Offset = "0x79F5670", VA = "0x1879F6870", Slot = "7")]
	[AsyncStateMachine(typeof(HKDJBDBPDCM))]
	protected override Task AOFOCBNPBGO(JHFDLGICCMM DGPBANFJJEC, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task FKNNDOOGFHM(JHFDLGICCMM DGPBANFJJEC, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x79F6730", Offset = "0x79F5530", VA = "0x1879F6730")]
	[AsyncStateMachine(typeof(AHJKEOICBJG))]
	private Task ACMADACKCGE(IDisposable BOJENPNEEIO, NFELCOGLGCD HANFPDJOJDJ, IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class PBNMAHCOAGG : DAODPIEPEBN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct FCDGKDCLLKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public PBNMAHCOAGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public JHFDLGICCMM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private TaskAwaiter<HHJNAOPPEEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x79F53D0", Offset = "0x79F41D0", VA = "0x1879F53D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x79F5940", Offset = "0x79F4740", VA = "0x1879F5940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly BPFCEEPJHKL MAPIMEJAPGE;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x7A01340", Offset = "0x7A00140", VA = "0x187A01340")]
	public PBNMAHCOAGG(Guid KCDDPKBGHIL, MLLAEEOLMLG FDPNEEAEJHK, GHHFOGHNCBC MOLBFJBMEMG, BPFCEEPJHKL MAPIMEJAPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x7A01260", Offset = "0x7A00060", VA = "0x187A01260", Slot = "6")]
	protected override string GEAMJLOGNBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x7A01140", Offset = "0x79FFF40", VA = "0x187A01140", Slot = "7")]
	[AsyncStateMachine(typeof(FCDGKDCLLKC))]
	protected override Task AOFOCBNPBGO(JHFDLGICCMM DGPBANFJJEC, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal abstract class DAODPIEPEBN : HNGNINPDPHG
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public delegate Task DCGIOCIPNMD(IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class DNJBNAEGMBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public DAODPIEPEBN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public DNJBNAEGMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x79F1CE0", Offset = "0x79F0AE0", VA = "0x1879F1CE0")]
		internal Task EOFLAPCBDLD(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class CJMJGHIJBBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public DNJBNAEGMBM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public CJMJGHIJBBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x79EE200", Offset = "0x79ED000", VA = "0x1879EE200")]
		internal object DCOGIHKGLLM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct EHDFMMHJNEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public DAODPIEPEBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public Func<DAODPIEPEBN, IGPFJOOPHMK<string>.PDLCJKJEJBF, JHFDLGICCMM> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private DNJBNAEGMBM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private JHFDLGICCMM <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private TaskAwaiter<LJLDKNMPHBD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x79F1E10", Offset = "0x79F0C10", VA = "0x1879F1E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x79F2FD0", Offset = "0x79F1DD0", VA = "0x1879F2FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct NMKPALKJJIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x79FD840", Offset = "0x79FC640", VA = "0x1879FD840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x79FE2E0", Offset = "0x79FD0E0", VA = "0x1879FE2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct KBEJAFPOKAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public DAODPIEPEBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x79F9A50", Offset = "0x79F8850", VA = "0x1879F9A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x79F9DB0", Offset = "0x79F8BB0", VA = "0x1879F9DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public readonly Guid GCOEJOABMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public readonly ByteString KOBPEBKNCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public readonly GHHFOGHNCBC PPKFCNLJIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	protected readonly string GPKODHHLFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly MLLAEEOLMLG FDPNEEAEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly bool KFBCAHIJLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly Queue<DCGIOCIPNMD> LOAKGFDLHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly AGMBFHBBGEH GHNEGGNJINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private readonly ADNACPKIBIF OCBLIALNMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private bool AAAIBFOPFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public IPCAKDAELIK CKIAJNFCJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public IPCAKDAELIK GKOFMIGAANA;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public MLLAEEOLMLG COAJJGLBPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x8F4490", Offset = "0x8F3290", VA = "0x1808F4490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public INCEBAAAKHE GFIGBBNEHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x79EE320", Offset = "0x79ED120", VA = "0x1879EE320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public NFJMELPFNIE CMAAODNPIGI
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x79EE4A0", Offset = "0x79ED2A0", VA = "0x1879EE4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public PLHOCBJJMOF ILIBPHFOENB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x79EE4F0", Offset = "0x79ED2F0", VA = "0x1879EE4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event PCMAJNECMBE NFBIIFHINHC
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x79EE720", Offset = "0x79ED520", VA = "0x1879EE720", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x79EEB60", Offset = "0x79ED960", VA = "0x1879EEB60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x79EEE70", Offset = "0x79EDC70", VA = "0x1879EEE70")]
	protected DAODPIEPEBN(Guid KCDDPKBGHIL, MLLAEEOLMLG FDPNEEAEJHK, GHHFOGHNCBC MOLBFJBMEMG, string INDOHCHMIPJ, ADNACPKIBIF OCBLIALNMGI, bool KFBCAHIJLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x79EE6E0", Offset = "0x79ED4E0", VA = "0x1879EE6E0", Slot = "6")]
	protected virtual string GEAMJLOGNBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x79EEB00", Offset = "0x79ED900", VA = "0x1879EEB00")]
	public void MBDBKGHCOEG(DCGIOCIPNMD GGMMKCDMKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x79EE9F0", Offset = "0x79ED7F0", VA = "0x1879EE9F0")]
	protected void IFPCOKGOIEB(float HLIJNINJIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x79EECA0", Offset = "0x79EDAA0", VA = "0x1879EECA0")]
	[AsyncStateMachine(typeof(EHDFMMHJNEP))]
	public Task NJAAPHNJHEI(CancellationToken FEHCANHDGHE, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, [Optional] Func<DAODPIEPEBN, IGPFJOOPHMK<string>.PDLCJKJEJBF, JHFDLGICCMM> NMFBOELCDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x79EE370", Offset = "0x79ED170", VA = "0x1879EE370")]
	[AsyncStateMachine(typeof(NMKPALKJJIB))]
	private static Task AHOADPAEKPF(Func<CancellationToken, Task> IDFNCAIOGKD, Func<CancellationToken, Task> DEJPMKENNEA, CancellationToken JHKFKNKNOJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x79EE570", Offset = "0x79ED370", VA = "0x1879EE570")]
	private void EOBGMAHDCBL(bool AAIFAFJIHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x79EE740", Offset = "0x79ED540", VA = "0x1879EE740")]
	private void HCMHECBFJGH(JHFDLGICCMM DGPBANFJJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task AOFOCBNPBGO(JHFDLGICCMM DGPBANFJJEC, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x79EEB80", Offset = "0x79ED980", VA = "0x1879EEB80")]
	[AsyncStateMachine(typeof(KBEJAFPOKAE))]
	private Task MMJONFDNNNK(IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x79EEDF0", Offset = "0x79EDBF0", VA = "0x1879EEDF0")]
	public LJLDKNMPHBD OPJCDHJJIKJ(ABMAHCGCFML NAEMNBJGOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x79EEA10", Offset = "0x79ED810", VA = "0x1879EEA10")]
	[CompilerGenerated]
	private Task LLEKIOPHBDA(CancellationToken DHJLEBFEJME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x79EE970", Offset = "0x79ED770", VA = "0x1879EE970")]
	[CompilerGenerated]
	private object HHLNBFMNPOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal sealed class LDGEBAIIBBA : HHIPDONCMDL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct AFAKJFKPGEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public LDGEBAIIBBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public JHFDLGICCMM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private KDCHDHEFHAG <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private PAHHOIJPGIG <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x79EC120", Offset = "0x79EAF20", VA = "0x1879EC120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x79EC880", Offset = "0x79EB680", VA = "0x1879EC880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	private readonly JAJOICLCDFI LJFGADNDIBH;

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x79FB3D0", Offset = "0x79FA1D0", VA = "0x1879FB3D0")]
	public LDGEBAIIBBA(Guid KCDDPKBGHIL, MLLAEEOLMLG FDPNEEAEJHK, JAJOICLCDFI LJFGADNDIBH, GHHFOGHNCBC MOLBFJBMEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x79FB280", Offset = "0x79FA080", VA = "0x1879FB280", Slot = "8")]
	[AsyncStateMachine(typeof(AFAKJFKPGEL))]
	protected override Task FKNNDOOGFHM(JHFDLGICCMM DGPBANFJJEC, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class OPNAGIKNEKI : DAODPIEPEBN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct LCNJGMDJONJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public OPNAGIKNEKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public JHFDLGICCMM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private TaskAwaiter<HHJNAOPPEEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x79FAE70", Offset = "0x79F9C70", VA = "0x1879FAE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x79FB220", Offset = "0x79FA020", VA = "0x1879FB220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly string IMEIKLAJEDI;

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x79FF500", Offset = "0x79FE300", VA = "0x1879FF500")]
	public OPNAGIKNEKI(Guid KCDDPKBGHIL, MLLAEEOLMLG FDPNEEAEJHK, GHHFOGHNCBC MOLBFJBMEMG, string IMEIKLAJEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x79FF3F0", Offset = "0x79FE1F0", VA = "0x1879FF3F0", Slot = "7")]
	[AsyncStateMachine(typeof(LCNJGMDJONJ))]
	protected override Task AOFOCBNPBGO(JHFDLGICCMM DGPBANFJJEC, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal class OPMMGLCLLPA : HHIPDONCMDL
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class LNICOBIEBOK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000119")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public AsyncTaskMethodBuilder<LJLDKNMPHBD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			public LNICOBIEBOK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041C")]
			private TaskAwaiter<HHJNAOPPEEO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			private TaskAwaiter<LJLDKNMPHBD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(RVA = "0x7A04550", Offset = "0x7A03350", VA = "0x187A04550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x7A04A10", Offset = "0x7A03810", VA = "0x187A04A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public OPMMGLCLLPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public GKDCEEMHMOI serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public AAOEHFDAHGE roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public OANOFMFOEJL uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public MMFABIGAOLJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public LNICOBIEBOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x79FB480", Offset = "0x79FA280", VA = "0x1879FB480")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<LJLDKNMPHBD> ACHHPOCKOMI(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct PEPCHDLNPHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public OPMMGLCLLPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public JHFDLGICCMM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private LNICOBIEBOK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private KDCHDHEFHAG <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private PAHHOIJPGIG <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private LJLDKNMPHBD <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private TaskAwaiter<LJLDKNMPHBD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x7A013E0", Offset = "0x7A001E0", VA = "0x187A013E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x7A02350", Offset = "0x7A01150", VA = "0x187A02350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private static readonly IMOCAMGHNDM JPIJNFLANHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private readonly int HJIDJEJFNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	[CanBeNull]
	private readonly HHDDNHJGPBH GPJDHCNHKAI;

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x79FF340", Offset = "0x79FE140", VA = "0x1879FF340")]
	public OPMMGLCLLPA(Guid KCDDPKBGHIL, MLLAEEOLMLG FDPNEEAEJHK, int HJIDJEJFNED, HHDDNHJGPBH GPJDHCNHKAI, GHHFOGHNCBC MOLBFJBMEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x79FF150", Offset = "0x79FDF50", VA = "0x1879FF150", Slot = "8")]
	[AsyncStateMachine(typeof(PEPCHDLNPHO))]
	protected override Task FKNNDOOGFHM(JHFDLGICCMM DGPBANFJJEC, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x79FEE80", Offset = "0x79FDC80", VA = "0x1879FEE80")]
	private void CDIMCGLPGNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x79FEF80", Offset = "0x79FDD80", VA = "0x1879FEF80")]
	private void CIFDHOEJOCH(IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, KDCHDHEFHAG NGNJEIAEFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal abstract class HPKPGEMMHDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public readonly DAODPIEPEBN BALKOHALHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public readonly JHFDLGICCMM LKKCHAEIBHM;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public INCEBAAAKHE GFIGBBNEHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x79F7470", Offset = "0x79F6270", VA = "0x1879F7470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public PLHOCBJJMOF ILIBPHFOENB
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x79F74C0", Offset = "0x79F62C0", VA = "0x1879F74C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x79F7670", Offset = "0x79F6470", VA = "0x1879F7670")]
	protected HPKPGEMMHDP(JHFDLGICCMM DGPBANFJJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x79F7550", Offset = "0x79F6350", VA = "0x1879F7550")]
	protected void KAMAHCNLDOK(string HGMDMLENFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal struct PJAODMICNFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public Dictionary<Guid, List<LLOOPOHDGBK>> MAHAOAHOOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public Dictionary<Guid, List<LLOOPOHDGBK>> DPONMIFAPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public Dictionary<Guid, List<LLOOPOHDGBK>> FDDDNCIBBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public List<Guid> HHJOLEMIEAE;

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x7A023B0", Offset = "0x7A011B0", VA = "0x187A023B0")]
	public static PJAODMICNFG ANFJBBFMPMK(INCEBAAAKHE BPGIOHMMDAI, IPCAKDAELIK GBOHEEMMCLJ, HGCCILDLOLL GNLCLPGKLAJ)
	{
		return default(PJAODMICNFG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct LNBNAIKGJFF
{
	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60")]
	public static LNBNAIKGJFF DCMOGLEGFAE()
	{
		return default(LNBNAIKGJFF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct HAKJFBHLBBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public readonly DGCCNGNLMNC KGMCCCOKBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public readonly DADBLAJODHB IENBCIOOFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public readonly string BDGGACIHCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public readonly HOAPPKHGKNJ PDNPLFLMEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public readonly HOAPPKHGKNJ IDKPIPKAIEF;

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x79F61F0", Offset = "0x79F4FF0", VA = "0x1879F61F0")]
	public HAKJFBHLBBA(DGCCNGNLMNC KGMCCCOKBDB, DADBLAJODHB IENBCIOOFAA, string BDGGACIHCDD, HOAPPKHGKNJ PDNPLFLMEMC, HOAPPKHGKNJ IDKPIPKAIEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct HCFLEHLELBG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private readonly JHFDLGICCMM DGPBANFJJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly Guid FEMFKCOMIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private bool AAIFAFJIHJG;

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x79F6560", Offset = "0x79F5360", VA = "0x1879F6560")]
	public static HCFLEHLELBG NAALLEAMKDB(JHFDLGICCMM DGPBANFJJEC)
	{
		return default(HCFLEHLELBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0xFFC3A0", Offset = "0xFFB1A0", VA = "0x180FFC3A0")]
	public void KOLILDEKKFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x79F6310", Offset = "0x79F5110", VA = "0x1879F6310", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x79F6590", Offset = "0x79F5390", VA = "0x1879F6590")]
	private HCFLEHLELBG(JHFDLGICCMM DGPBANFJJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x79F6320", Offset = "0x79F5120", VA = "0x1879F6320")]
	private void EFOPLHKPNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x79F6270", Offset = "0x79F5070", VA = "0x1879F6270")]
	private Func<Guid, bool> AAIPKACNBJE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal class PAHHOIJPGIG : HPKPGEMMHDP, HNGNINPDPHG
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	public delegate Task<IPCAKDAELIK> MCJGEMMMNHF(HGCCILDLOLL JOAPLPPIFPC, PHJHEBPAOIK CHAEBJKFIDL, AGMBFHBBGEH POEFGJLAHPM, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct GABHLIFKJGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public JAJOICLCDFI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private HCFLEHLELBG <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private TaskAwaiter<LJLDKNMPHBD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x79F59A0", Offset = "0x79F47A0", VA = "0x1879F59A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x79F6120", Offset = "0x79F4F20", VA = "0x1879F6120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct ONCFGFIKMCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public AsyncTaskMethodBuilder<LJLDKNMPHBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public JAJOICLCDFI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private TaskAwaiter<LJLDKNMPHBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x79FE9E0", Offset = "0x79FD7E0", VA = "0x1879FE9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x79FEE10", Offset = "0x79FDC10", VA = "0x1879FEE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct OKHLECCEGKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public JAJOICLCDFI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x79FE340", Offset = "0x79FD140", VA = "0x1879FE340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x79FE980", Offset = "0x79FD780", VA = "0x1879FE980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class LPGPCAIMLPL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public AsyncTaskMethodBuilder<HAKJFBHLBBA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public LPGPCAIMLPL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private HAKJFBHLBBA <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			private TaskAwaiter<IPCAKDAELIK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			private TaskAwaiter<HAKJFBHLBBA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(RVA = "0x7A03040", Offset = "0x7A01E40", VA = "0x187A03040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x7A037A0", Offset = "0x7A025A0", VA = "0x187A037A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000128")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public AsyncTaskMethodBuilder<HGCCILDLOLL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public LPGPCAIMLPL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private HGCCILDLOLL <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			private TaskAwaiter<IPCAKDAELIK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			private TaskAwaiter<HGCCILDLOLL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x7A03810", Offset = "0x7A02610", VA = "0x187A03810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x7A03E40", Offset = "0x7A02C40", VA = "0x187A03E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public JAJOICLCDFI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public AGMBFHBBGEH preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public AGMBFHBBGEH downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public HAKJFBHLBBA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public AGMBFHBBGEH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public HGCCILDLOLL phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public CLICDMBAIMF.CHGKBFNLDNA <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public LPGPCAIMLPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x79FC630", Offset = "0x79FB430", VA = "0x1879FC630")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<HAKJFBHLBBA> LOOBJCDEBAP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x79FC770", Offset = "0x79FB570", VA = "0x1879FC770")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<HGCCILDLOLL> MFCMKCLGLGO(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x79FC490", Offset = "0x79FB290", VA = "0x1879FC490")]
		internal void APMKCPBMLIL(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x79FC890", Offset = "0x79FB690", VA = "0x1879FC890")]
		internal Task MFNLNPNBKNM(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x79FC4D0", Offset = "0x79FB2D0", VA = "0x1879FC4D0")]
		internal Task CKDHFOCGKJK(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct BLFPOHADGEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public JAJOICLCDFI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private LPGPCAIMLPL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter<HAKJFBHLBBA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private TaskAwaiter<HGCCILDLOLL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x79ED450", Offset = "0x79EC250", VA = "0x1879ED450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x79EE1A0", Offset = "0x79ECFA0", VA = "0x1879EE1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct EJNFNLNCLGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public HGCCILDLOLL phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public AGMBFHBBGEH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private TaskAwaiter<IPCAKDAELIK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private PHJHEBPAOIK <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x79F32C0", Offset = "0x79F20C0", VA = "0x1879F32C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x79F4150", Offset = "0x79F2F50", VA = "0x1879F4150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct ACBNAHCOGHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x79EB800", Offset = "0x79EA600", VA = "0x1879EB800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x79EC0C0", Offset = "0x79EAEC0", VA = "0x1879EC0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct DMNGOJBLEMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public AGMBFHBBGEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private TaskAwaiter<IPCAKDAELIK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x79F12F0", Offset = "0x79F00F0", VA = "0x1879F12F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x79F1C80", Offset = "0x79F0A80", VA = "0x1879F1C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct FBIOJIPAFCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public AsyncTaskMethodBuilder<IPCAKDAELIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public AGMBFHBBGEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private TaskAwaiter<IPCAKDAELIK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x79F41B0", Offset = "0x79F2FB0", VA = "0x1879F41B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x79F5360", Offset = "0x79F4160", VA = "0x1879F5360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct DBOADGAPONL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public AsyncTaskMethodBuilder<IPCAKDAELIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public AGMBFHBBGEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public PHJHEBPAOIK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private TaskAwaiter<IPCAKDAELIK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x79EEFD0", Offset = "0x79EDDD0", VA = "0x1879EEFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x79F00D0", Offset = "0x79EEED0", VA = "0x1879F00D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct ACBEBHJOPND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public AsyncTaskMethodBuilder<IPCAKDAELIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public IPCAKDAELIK operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public AGMBFHBBGEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public HGCCILDLOLL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private TaskAwaiter<IPCAKDAELIK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x79EB4F0", Offset = "0x79EA2F0", VA = "0x1879EB4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x79EB790", Offset = "0x79EA590", VA = "0x1879EB790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class ALHHAKPGLHD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			public AsyncTaskMethodBuilder<IPCAKDAELIK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			public ALHHAKPGLHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			private DOOPFMCKBOH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			private TaskAwaiter<IPCAKDAELIK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x7A03EB0", Offset = "0x7A02CB0", VA = "0x187A03EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x7A044E0", Offset = "0x7A032E0", VA = "0x187A044E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public AGMBFHBBGEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public MCJGEMMMNHF masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public PHJHEBPAOIK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public IPCAKDAELIK originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ALHHAKPGLHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x79ECEE0", Offset = "0x79EBCE0", VA = "0x1879ECEE0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<IPCAKDAELIK> CBGJINFAMEO(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct DHHPCFHEGMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public AsyncTaskMethodBuilder<IPCAKDAELIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public AGMBFHBBGEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public MCJGEMMMNHF masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public PHJHEBPAOIK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private TaskAwaiter<IPCAKDAELIK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x79F0D60", Offset = "0x79EFB60", VA = "0x1879F0D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x79F1280", Offset = "0x79F0080", VA = "0x1879F1280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct IIFNNEFDGKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public AGMBFHBBGEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private IPCAKDAELIK <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private IEnumerator<IPCAKDAELIK> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TaskAwaiter<IPCAKDAELIK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x79F80E0", Offset = "0x79F6EE0", VA = "0x1879F80E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x79F8630", Offset = "0x79F7430", VA = "0x1879F8630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct IBJFKPCPCGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x79F76D0", Offset = "0x79F64D0", VA = "0x1879F76D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x79F78F0", Offset = "0x79F66F0", VA = "0x1879F78F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct KNBEAKIGNJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x79FA7B0", Offset = "0x79F95B0", VA = "0x1879FA7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x79FA950", Offset = "0x79F9750", VA = "0x1879FA950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct LNLKDBMLJKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public HGCCILDLOLL phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public AGMBFHBBGEH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private TaskAwaiter<IPCAKDAELIK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private PHJHEBPAOIK <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x79FB5A0", Offset = "0x79FA3A0", VA = "0x1879FB5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x79FC430", Offset = "0x79FB230", VA = "0x1879FC430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct NLLPLFFONEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public AsyncTaskMethodBuilder<IPCAKDAELIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public PAHHOIJPGIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public AGMBFHBBGEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private TaskAwaiter<IPCAKDAELIK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x7A17D20", Offset = "0x7A16B20", VA = "0x187A17D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x7A18A20", Offset = "0x7A17820", VA = "0x187A18A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly LNJPDINAFGA HLMPDJFAIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly LNJPDINAFGA FHFFABOJBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private readonly IKHJLIGMDLA PJICLILFLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private readonly IIJPNLPPLHK CEIDOLNFIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly GCMKKKKJDED MHOPCHBBHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private ProfilerCounterValue<int> BJICGCMKOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private readonly MCPOMHOMLBH PCEKIHCNKFC;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private MLLAEEOLMLG COAJJGLBPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x79FFD50", Offset = "0x79FEB50", VA = "0x1879FFD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event PCMAJNECMBE NFBIIFHINHC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x79FFED0", Offset = "0x79FECD0", VA = "0x1879FFED0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x7A00AD0", Offset = "0x79FF8D0", VA = "0x187A00AD0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x7A00E80", Offset = "0x79FFC80", VA = "0x187A00E80")]
	public PAHHOIJPGIG(JHFDLGICCMM DGPBANFJJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x7A000C0", Offset = "0x79FEEC0", VA = "0x187A000C0")]
	[AsyncStateMachine(typeof(GABHLIFKJGI))]
	public Task HPLDIGMFGFN(JAJOICLCDFI HJFGAIAKKLJ, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x7A005D0", Offset = "0x79FF3D0", VA = "0x187A005D0")]
	[AsyncStateMachine(typeof(ONCFGFIKMCA))]
	private Task<LJLDKNMPHBD> KCAPPPDGIPD(JAJOICLCDFI HJFGAIAKKLJ, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x7A00730", Offset = "0x79FF530", VA = "0x187A00730")]
	[AsyncStateMachine(typeof(OKHLECCEGKJ))]
	private Task KFADHMDJAPE(JAJOICLCDFI HJFGAIAKKLJ, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x79FF910", Offset = "0x79FE710", VA = "0x1879FF910")]
	[AsyncStateMachine(typeof(BLFPOHADGEE))]
	private Task DAEMMBGPFNH(JAJOICLCDFI HJFGAIAKKLJ, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken NDJKMFODEJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x7A00210", Offset = "0x79FF010", VA = "0x187A00210")]
	[AsyncStateMachine(typeof(EJNFNLNCLGD))]
	private Task ICHEHMGJBNJ(HGCCILDLOLL KOFLJFNMHFG, AGMBFHBBGEH KPGINLGNFHP, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken KLOLHPDMMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x7A009C0", Offset = "0x79FF7C0", VA = "0x187A009C0")]
	[AsyncStateMachine(typeof(ACBNAHCOGHA))]
	private Task LHFHEEPGKCH(IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x7A00870", Offset = "0x79FF670", VA = "0x187A00870")]
	[AsyncStateMachine(typeof(DMNGOJBLEMO))]
	private Task LCJJIIONEMD(HGCCILDLOLL JOAPLPPIFPC, AGMBFHBBGEH POEFGJLAHPM, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x7A00B50", Offset = "0x79FF950", VA = "0x187A00B50")]
	[AsyncStateMachine(typeof(FBIOJIPAFCC))]
	private Task<IPCAKDAELIK> PKKCJBPAFHH(HGCCILDLOLL JOAPLPPIFPC, PHJHEBPAOIK GIJHPMLBJPA, AGMBFHBBGEH POEFGJLAHPM, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x7A00D00", Offset = "0x79FFB00", VA = "0x187A00D00")]
	[AsyncStateMachine(typeof(DBOADGAPONL))]
	private Task<IPCAKDAELIK> POIGPPNBPBL(HGCCILDLOLL JOAPLPPIFPC, PHJHEBPAOIK GIJHPMLBJPA, AGMBFHBBGEH POEFGJLAHPM, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x79FFBA0", Offset = "0x79FE9A0", VA = "0x1879FFBA0")]
	[AsyncStateMachine(typeof(ACBEBHJOPND))]
	private Task<IPCAKDAELIK> DODCMMHBOMB(IPCAKDAELIK GBOHEEMMCLJ, HGCCILDLOLL GNLCLPGKLAJ, AGMBFHBBGEH POEFGJLAHPM, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE, bool HDJJJOOHOOA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x7A003D0", Offset = "0x79FF1D0", VA = "0x187A003D0")]
	private bool ILCDADIFKMK(HGCCILDLOLL KOFLJFNMHFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x79FFF30", Offset = "0x79FED30", VA = "0x1879FFF30")]
	[AsyncStateMachine(typeof(DHHPCFHEGMH))]
	protected Task<IPCAKDAELIK> HLPNLFNMOKM(HGCCILDLOLL JOAPLPPIFPC, PHJHEBPAOIK GIJHPMLBJPA, AGMBFHBBGEH POEFGJLAHPM, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE, MCJGEMMMNHF FFHNNMFKKKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x79FF7C0", Offset = "0x79FE5C0", VA = "0x1879FF7C0")]
	[AsyncStateMachine(typeof(IIFNNEFDGKD))]
	private Task CHLDGMCKJOP(HGCCILDLOLL JOAPLPPIFPC, AGMBFHBBGEH POEFGJLAHPM, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x7A00CB0", Offset = "0x79FFAB0", VA = "0x187A00CB0")]
	private void PLAIPDDGMOI(IPCAKDAELIK CNIELKHDHMK, AGMBFHBBGEH POEFGJLAHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x79FFEF0", Offset = "0x79FECF0", VA = "0x1879FFEF0")]
	private void HIHMEPOMJAI(IPCAKDAELIK CPGBOPCAFAE, [Out] IPCAKDAELIK LONFPKPHCJF, [Out] IPCAKDAELIK EFJJDKMFINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x7A00B10", Offset = "0x79FF910", VA = "0x187A00B10")]
	private Task<HAKJFBHLBBA> OAEGKMAEMPB(JAJOICLCDFI HJFGAIAKKLJ, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x79FF5E0", Offset = "0x79FE3E0", VA = "0x1879FF5E0")]
	private Task<HGCCILDLOLL> AINCKEPJBKB(HAKJFBHLBBA JOAPLPPIFPC, CLICDMBAIMF.CHGKBFNLDNA ODOOICLIBOB, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x79FFA50", Offset = "0x79FE850", VA = "0x1879FFA50")]
	[AsyncStateMachine(typeof(IBJFKPCPCGJ))]
	private Task DKLGILKGMBD(HGCCILDLOLL JOAPLPPIFPC, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE, bool KPCHKGCMGGL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x7A004E0", Offset = "0x79FF2E0", VA = "0x187A004E0")]
	[AsyncStateMachine(typeof(KNBEAKIGNJO))]
	private Task IOFKFFDPJJD(HGCCILDLOLL JOAPLPPIFPC, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x79FFD20", Offset = "0x79FEB20", VA = "0x1879FFD20")]
	private Task DPIPHNCMKCA(HGCCILDLOLL JOAPLPPIFPC, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x7A004C0", Offset = "0x79FF2C0", VA = "0x187A004C0")]
	private Task IMLMJPKLHGL(HGCCILDLOLL JOAPLPPIFPC, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x79FF7A0", Offset = "0x79FE5A0", VA = "0x1879FF7A0")]
	private Task CBNFOFFEFDD(HGCCILDLOLL JOAPLPPIFPC, PHJHEBPAOIK GIJHPMLBJPA, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x79FF5C0", Offset = "0x79FE3C0", VA = "0x1879FF5C0")]
	private Task ADEJODBGFOD(HGCCILDLOLL JOAPLPPIFPC, PHJHEBPAOIK GIJHPMLBJPA, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x79FF5B0", Offset = "0x79FE3B0", VA = "0x1879FF5B0")]
	private static Task ABAMNBABGIJ(CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x7A00AF0", Offset = "0x79FF8F0", VA = "0x187A00AF0")]
	private Task NLOJPIFFFLI(HGCCILDLOLL JOAPLPPIFPC, PHJHEBPAOIK GIJHPMLBJPA, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x7A003B0", Offset = "0x79FF1B0", VA = "0x187A003B0")]
	private Task IIBPGHJDBBJ(HGCCILDLOLL JOAPLPPIFPC, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x7A00360", Offset = "0x79FF160", VA = "0x187A00360")]
	private void IDCIJAKCMIH(JAJOICLCDFI HJFGAIAKKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x79FF780", Offset = "0x79FE580", VA = "0x1879FF780")]
	public void BOELCMAHJKO(long GPNMOJOEGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
	private static void CBHECKGGIFO(DGCCNGNLMNC KGMCCCOKBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x79FFD80", Offset = "0x79FEB80", VA = "0x1879FFD80")]
	[AsyncStateMachine(typeof(LNLKDBMLJKM))]
	private Task GEBECCLFMEM(HGCCILDLOLL KOFLJFNMHFG, AGMBFHBBGEH KPGINLGNFHP, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken KLOLHPDMMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x79FF620", Offset = "0x79FE420", VA = "0x1879FF620")]
	[AsyncStateMachine(typeof(NLLPLFFONEF))]
	[CompilerGenerated]
	private Task<IPCAKDAELIK> BFMAPIHHGCM(HGCCILDLOLL JOAPLPPIFPC, PHJHEBPAOIK GIJHPMLBJPA, AGMBFHBBGEH POEFGJLAHPM, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct AFOJMBDKOBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private MLLAEEOLMLG FDPNEEAEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private HGCCILDLOLL JOAPLPPIFPC;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private INCEBAAAKHE GFIGBBNEHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x7A056C0", Offset = "0x7A044C0", VA = "0x187A056C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x7A05920", Offset = "0x7A04720", VA = "0x187A05920")]
	public static Task NJAAPHNJHEI(MLLAEEOLMLG FDPNEEAEJHK, HGCCILDLOLL JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x7A05710", Offset = "0x7A04510", VA = "0x187A05710")]
	private void NJAAPHNJHEI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct KCAAFNIDBFA
{
	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x7A134F0", Offset = "0x7A122F0", VA = "0x187A134F0")]
	public static Task NJAAPHNJHEI(CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct BICEIMBLGHG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct OCDFKPOGELH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public JHFDLGICCMM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x7A19ED0", Offset = "0x7A18CD0", VA = "0x187A19ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x7A1A400", Offset = "0x7A19200", VA = "0x187A1A400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x7A07360", Offset = "0x7A06160", VA = "0x187A07360")]
	[AsyncStateMachine(typeof(OCDFKPOGELH))]
	public static Task NJAAPHNJHEI(JHFDLGICCMM DGPBANFJJEC, HGCCILDLOLL JOAPLPPIFPC, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct NMCELAPLLIO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct CIGIEKOLPHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public JHFDLGICCMM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public PHJHEBPAOIK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private IPCAKDAELIK <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private MLLAEEOLMLG <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private INCEBAAAKHE <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private DOOPFMCKBOH <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private List<(PersistenceView, DACMPOAMDBF)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private DACMPOAMDBF <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x7A08A40", Offset = "0x7A07840", VA = "0x187A08A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x7A096E0", Offset = "0x7A084E0", VA = "0x187A096E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x7A18C90", Offset = "0x7A17A90", VA = "0x187A18C90")]
	[AsyncStateMachine(typeof(CIGIEKOLPHE))]
	public static Task NJAAPHNJHEI(JHFDLGICCMM DGPBANFJJEC, HGCCILDLOLL JOAPLPPIFPC, PHJHEBPAOIK GIJHPMLBJPA, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x7A18A90", Offset = "0x7A17890", VA = "0x187A18A90")]
	private static void ECDNBAPBBAA(PersistenceView FHOIFELJGJL, DACMPOAMDBF HCOLLOKLDBB, HGCCILDLOLL JOAPLPPIFPC, IPCAKDAELIK GBOHEEMMCLJ, bool FDDGMOILIAF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct BHNDEHCBHEG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct BGPHLIJMMCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public MLLAEEOLMLG roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private DOOPFMCKBOH <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x7A06BC0", Offset = "0x7A059C0", VA = "0x187A06BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x7A071E0", Offset = "0x7A05FE0", VA = "0x187A071E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x7A07240", Offset = "0x7A06040", VA = "0x187A07240")]
	[AsyncStateMachine(typeof(BGPHLIJMMCA))]
	public static Task NJAAPHNJHEI(MLLAEEOLMLG FDPNEEAEJHK, HGCCILDLOLL JOAPLPPIFPC, CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct MDALOCEIDCL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct DEGHENCNOMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public MLLAEEOLMLG roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public JHFDLGICCMM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x7A0A7C0", Offset = "0x7A095C0", VA = "0x187A0A7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x7A0A9D0", Offset = "0x7A097D0", VA = "0x187A0A9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class MFLFHHOJDNG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000145")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			public IGPFJOOPHMK<string>.PDLCJKJEJBF timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			public MFLFHHOJDNG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x7A1E180", Offset = "0x7A1CF80", VA = "0x187A1E180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x7A1E510", Offset = "0x7A1D310", VA = "0x187A1E510", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MFLFHHOJDNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x7A15E40", Offset = "0x7A14C40", VA = "0x187A15E40")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task NOBOOBLIJBK(IGPFJOOPHMK<string>.PDLCJKJEJBF timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct NANDEHHIGGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public MDALOCEIDCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private DOOPFMCKBOH <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private TaskAwaiter<LJLDKNMPHBD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x7A16990", Offset = "0x7A15790", VA = "0x187A16990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x7A175A0", Offset = "0x7A163A0", VA = "0x187A175A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class PPKMLDNOIGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public JNOHDJLMBEA version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public PPKMLDNOIGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x7A1D8B0", Offset = "0x7A1C6B0", VA = "0x187A1D8B0")]
		internal object DPBLNGFBGMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x7A1D800", Offset = "0x7A1C600", VA = "0x187A1D800")]
		internal object AIGBDDKPMJP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private MLLAEEOLMLG FDPNEEAEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private HGCCILDLOLL JOAPLPPIFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private JHFDLGICCMM DGPBANFJJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private bool KPCHKGCMGGL;

	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private static readonly ByteString JINDKLBDHJJ;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private INCEBAAAKHE GFIGBBNEHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x7A15210", Offset = "0x7A14010", VA = "0x187A15210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private PLHOCBJJMOF ILIBPHFOENB
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x7A15260", Offset = "0x7A14060", VA = "0x187A15260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x7A15AE0", Offset = "0x7A148E0", VA = "0x187A15AE0")]
	[AsyncStateMachine(typeof(DEGHENCNOMI))]
	public static Task NJAAPHNJHEI(MLLAEEOLMLG FDPNEEAEJHK, HGCCILDLOLL JOAPLPPIFPC, JHFDLGICCMM DGPBANFJJEC, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE, bool KPCHKGCMGGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x7A15C30", Offset = "0x7A14A30", VA = "0x187A15C30")]
	[AsyncStateMachine(typeof(NANDEHHIGGM))]
	private Task NJAAPHNJHEI(IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x7A15340", Offset = "0x7A14140", VA = "0x187A15340")]
	private void JFIHMIKAFCJ([NotNull] PPNKBAMJHHC CMLNEKGHNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x7A15300", Offset = "0x7A14100", VA = "0x187A15300")]
	private bool JDHMKEADBDP(JNOHDJLMBEA BBDOELHAPOH, PPNKBAMJHHC CMLNEKGHNFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct JNPPGMMBFCG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct PMGMEAIAMDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public AsyncTaskMethodBuilder<HGCCILDLOLL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public JNPPGMMBFCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public CLICDMBAIMF.CHGKBFNLDNA downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private TaskAwaiter<(PGOLMGNGGBM<LAAFJKKHBBP, MFMDDJMMGHP>, PGOLMGNGGBM<BJKDDMAILKD<PPNKBAMJHHC>, MFMDDJMMGHP>, PGOLMGNGGBM<BJKDDMAILKD<OLIDAEPNBCP>, MFMDDJMMGHP>, PGOLMGNGGBM<BJKDDMAILKD<GKEPDEDFEAB>, MFMDDJMMGHP>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x7A1BEB0", Offset = "0x7A1ACB0", VA = "0x187A1BEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x7A1C960", Offset = "0x7A1B760", VA = "0x187A1C960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct JECDKCBJFMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<LAAFJKKHBBP, MFMDDJMMGHP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public JNPPGMMBFCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CLICDMBAIMF.CHGKBFNLDNA downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter<PGOLMGNGGBM<LAAFJKKHBBP, MFMDDJMMGHP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x7A127C0", Offset = "0x7A115C0", VA = "0x187A127C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7A12DD0", Offset = "0x7A11BD0", VA = "0x187A12DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private EOAGCJJKFDL<HOAPPKHGKNJ, OLIDAEPNBCP> KHDBKOIKHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private EOAGCJJKFDL<HOAPPKHGKNJ, PPNKBAMJHHC> LPGKNIDGFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private EOAGCJJKFDL<long, GKEPDEDFEAB> NECNMODEHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private IBOMAMEIELM KMICAKHJPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private DGCCNGNLMNC KGMCCCOKBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private DADBLAJODHB IENBCIOOFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private string BDGGACIHCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private HOAPPKHGKNJ PDNPLFLMEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	private HOAPPKHGKNJ IDKPIPKAIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private long GPNMOJOEGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	private IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG;

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x7A13000", Offset = "0x7A11E00", VA = "0x187A13000")]
	public static Task<HGCCILDLOLL> LHLDAMEIJBH(MLLAEEOLMLG FDPNEEAEJHK, [In] HAKJFBHLBBA JOAPLPPIFPC, CLICDMBAIMF.CHGKBFNLDNA ODOOICLIBOB, IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x7A13360", Offset = "0x7A12160", VA = "0x187A13360")]
	[AsyncStateMachine(typeof(PMGMEAIAMDE))]
	private Task<HGCCILDLOLL> NJAAPHNJHEI(CLICDMBAIMF.CHGKBFNLDNA ODOOICLIBOB, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x7A12E40", Offset = "0x7A11C40", VA = "0x187A12E40")]
	[AsyncStateMachine(typeof(JECDKCBJFMM))]
	private Task<PGOLMGNGGBM<LAAFJKKHBBP, MFMDDJMMGHP>> GMHOBKMGIMG(string BDGGACIHCDD, long GPNMOJOEGPG, long? OGMIFIGJENM, long? FIAEJOGALJF, CLICDMBAIMF.CHGKBFNLDNA ODOOICLIBOB, IGPFJOOPHMK<string>.PDLCJKJEJBF IHLAOJLIIFP, CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct KPLKDNOINOD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct MBAMBIIIMEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public AsyncTaskMethodBuilder<HAKJFBHLBBA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public KPLKDNOINOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private TaskAwaiter<HAKJFBHLBBA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x7A14C60", Offset = "0x7A13A60", VA = "0x187A14C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x7A15070", Offset = "0x7A13E70", VA = "0x187A15070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct FKGJNPNDLCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public AsyncTaskMethodBuilder<HAKJFBHLBBA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public KPLKDNOINOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private TaskAwaiter<HAKJFBHLBBA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x7A0C580", Offset = "0x7A0B380", VA = "0x187A0C580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x7A0C9B0", Offset = "0x7A0B7B0", VA = "0x187A0C9B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class DGLBHJJOHLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public DGLBHJJOHLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xD0CC10", Offset = "0xD0BA10", VA = "0x180D0CC10")]
		internal bool OOMKLIMCDGE(DADBLAJODHB sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct BAJAMICLCLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public AsyncTaskMethodBuilder<HAKJFBHLBBA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public HOAPPKHGKNJ superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public INCEBAAAKHE callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private DGLBHJJOHLH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public LHMKGGLEKIG roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private DGCCNGNLMNC <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private DADBLAJODHB <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private HOAPPKHGKNJ <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private HOAPPKHGKNJ <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter<DGCCNGNLMNC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter<BCOPHPGONJP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private TaskAwaiter<KGAIHJLHFDH> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x7A05A00", Offset = "0x7A04800", VA = "0x187A05A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x7A06B50", Offset = "0x7A05950", VA = "0x187A06B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private INCEBAAAKHE BPGIOHMMDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private IKHJLIGMDLA PJICLILFLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private LHMKGGLEKIG FKIPJCBIEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private long OGMIFIGJENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private long MGNAIIKHEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private long BNKDNHLBLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private string BOHOGABJBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private HOAPPKHGKNJ HKPHBGBPAPB;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x7A13730", Offset = "0x7A12530", VA = "0x187A13730")]
	public static Task<HAKJFBHLBBA> LHLDAMEIJBH(MLLAEEOLMLG FDPNEEAEJHK, JAJOICLCDFI HJFGAIAKKLJ, IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x7A13990", Offset = "0x7A12790", VA = "0x187A13990")]
	[AsyncStateMachine(typeof(MBAMBIIIMEI))]
	private Task<HAKJFBHLBBA> NJAAPHNJHEI(CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x7A13C80", Offset = "0x7A12A80", VA = "0x187A13C80")]
	[AsyncStateMachine(typeof(FKGJNPNDLCJ))]
	private Task<HAKJFBHLBBA> OAEGKMAEMPB(IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x7A13AE0", Offset = "0x7A128E0", VA = "0x187A13AE0")]
	[AsyncStateMachine(typeof(BAJAMICLCLL))]
	private static Task<HAKJFBHLBBA> OAEGKMAEMPB(INCEBAAAKHE BPGIOHMMDAI, LHMKGGLEKIG FKIPJCBIEOL, long OGMIFIGJENM, long MGNAIIKHEOI, long BNKDNHLBLJC, string BOHOGABJBDK, HOAPPKHGKNJ HKPHBGBPAPB, CancellationToken FEHCANHDGHE, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x7A13960", Offset = "0x7A12760", VA = "0x187A13960")]
	private void LKFBGMAMNIF(DGCCNGNLMNC KGMCCCOKBDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
internal struct DKKICJGPPNF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct CEHNDKCBHEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public DKKICJGPPNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x7A07B80", Offset = "0x7A06980", VA = "0x187A07B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x7A08110", Offset = "0x7A06F10", VA = "0x187A08110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private INCEBAAAKHE BPGIOHMMDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private HGCCILDLOLL JOAPLPPIFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private float MDJMBFLMING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private float HBPBDCOFHBH;

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x7A0AB70", Offset = "0x7A09970", VA = "0x187A0AB70")]
	public static Task JPFLAKHPAKB(MLLAEEOLMLG FDPNEEAEJHK, HGCCILDLOLL JOAPLPPIFPC, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x7A0AE90", Offset = "0x7A09C90", VA = "0x187A0AE90")]
	[AsyncStateMachine(typeof(CEHNDKCBHEN))]
	public Task NJAAPHNJHEI(CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x7A0AA30", Offset = "0x7A09830", VA = "0x187A0AA30")]
	private static void DEEPJEGMFMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x7A0AD30", Offset = "0x7A09B30", VA = "0x187A0AD30")]
	private void MEMGBICOHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x7A0AFB0", Offset = "0x7A09DB0", VA = "0x187A0AFB0")]
	private static float OIEBOFEGLJJ(INCEBAAAKHE BPGIOHMMDAI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x7A0AD10", Offset = "0x7A09B10", VA = "0x187A0AD10")]
	private static float MDNDAPKMMFC()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct HGOAGIFLAEG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct JAHJMKAGKMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public JHFDLGICCMM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private DAODPIEPEBN <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private MLLAEEOLMLG <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private IFIBKDEODJL.DEEGCCJCLHC <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private TaskAwaiter<LJLDKNMPHBD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x7A11ED0", Offset = "0x7A10CD0", VA = "0x187A11ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x7A126F0", Offset = "0x7A114F0", VA = "0x187A126F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct OFMPEANOFKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x7A1A7E0", Offset = "0x7A195E0", VA = "0x187A1A7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x7A1AB10", Offset = "0x7A19910", VA = "0x187A1AB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x7A0F270", Offset = "0x7A0E070", VA = "0x187A0F270")]
	[AsyncStateMachine(typeof(JAHJMKAGKMH))]
	public static Task NJAAPHNJHEI(JHFDLGICCMM DGPBANFJJEC, HGCCILDLOLL JOAPLPPIFPC, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x7A0F140", Offset = "0x7A0DF40", VA = "0x187A0F140")]
	private static Task<LJLDKNMPHBD> AJBEIEHHBNN(JHFDLGICCMM DGPBANFJJEC, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x7A0F1B0", Offset = "0x7A0DFB0", VA = "0x187A0F1B0")]
	[AsyncStateMachine(typeof(OFMPEANOFKE))]
	private static Task MCOGLAEFONL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct IOCPLGGLDLI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct CNMKPHOCEHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public IOCPLGGLDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x7A097B0", Offset = "0x7A085B0", VA = "0x187A097B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x7A09E60", Offset = "0x7A08C60", VA = "0x187A09E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class GCNPFNIOOIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public GCNPFNIOOIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x7A0D3D0", Offset = "0x7A0C1D0", VA = "0x187A0D3D0")]
		internal object CIPKHJPCANM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct FLGPIEFBOMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public IOCPLGGLDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x7A0CA20", Offset = "0x7A0B820", VA = "0x187A0CA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x7A0CEA0", Offset = "0x7A0BCA0", VA = "0x187A0CEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B0")]
	private bool DPJLJLJMGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B2")]
	private MLLAEEOLMLG FDPNEEAEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005B3")]
	private CancellationToken FEHCANHDGHE;

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x7A11B90", Offset = "0x7A10990", VA = "0x187A11B90")]
	public static Task CNIHGFIAMLK(MLLAEEOLMLG FDPNEEAEJHK, bool DPJLJLJMGNG, IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, CancellationToken MPCJFMBODJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x7A11D30", Offset = "0x7A10B30", VA = "0x187A11D30")]
	[AsyncStateMachine(typeof(CNMKPHOCEHF))]
	private Task NJAAPHNJHEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x7A11C00", Offset = "0x7A10A00", VA = "0x187A11C00")]
	[AsyncStateMachine(typeof(FLGPIEFBOMP))]
	private Task MPEPKHEMFLP(bool AHMINMKHLLM, string GJJPEGOGGEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60")]
	private bool CDJACCOFOKF(bool DPJLJLJMGNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct CBMIOBCCHIO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct LHAOIFPMKML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public CBMIOBCCHIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x7A13E50", Offset = "0x7A12C50", VA = "0x187A13E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x7A143C0", Offset = "0x7A131C0", VA = "0x187A143C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class HNKFNJGLJAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public HNKFNJGLJAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x7A0F4F0", Offset = "0x7A0E2F0", VA = "0x187A0F4F0")]
		internal object CIPKHJPCANM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct NABNDNKBEAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public CBMIOBCCHIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x7A16490", Offset = "0x7A15290", VA = "0x187A16490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x7A16920", Offset = "0x7A15720", VA = "0x187A16920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private DIPFACPGHFK LBPDFEMHOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private MLLAEEOLMLG FDPNEEAEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private bool CDBFLGHMJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private HGCCILDLOLL JOAPLPPIFPC;

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x7A077F0", Offset = "0x7A065F0", VA = "0x187A077F0")]
	public static Task<Scene> DLLPGGGPFFL(MLLAEEOLMLG FDPNEEAEJHK, DIPFACPGHFK JONIPGLGGMB, IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x7A07A60", Offset = "0x7A06860", VA = "0x187A07A60")]
	[AsyncStateMachine(typeof(LHAOIFPMKML))]
	private Task<Scene> NJAAPHNJHEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x7A07870", Offset = "0x7A06670", VA = "0x187A07870")]
	private bool ENIKKMOPAPH(HGCCILDLOLL JOAPLPPIFPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x7A078A0", Offset = "0x7A066A0", VA = "0x187A078A0")]
	private void FHEFIBDHDMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x7A07910", Offset = "0x7A06710", VA = "0x187A07910")]
	[AsyncStateMachine(typeof(NABNDNKBEAF))]
	private Task<Scene> MPEPKHEMFLP(string GJJPEGOGGEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct GCMKKKKJDED
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct IFDNFIKBECF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public AsyncTaskMethodBuilder<IPCAKDAELIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public GCMKKKKJDED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public IPCAKDAELIK nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public HGCCILDLOLL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter<IPCAKDAELIK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7A0F540", Offset = "0x7A0E340", VA = "0x187A0F540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x7A10010", Offset = "0x7A0EE10", VA = "0x187A10010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct BJBKPAIHMMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public AsyncTaskMethodBuilder<IPCAKDAELIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public GCMKKKKJDED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public IPCAKDAELIK state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private TaskAwaiter<LJLDKNMPHBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x7A074A0", Offset = "0x7A062A0", VA = "0x187A074A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7A07780", Offset = "0x7A06580", VA = "0x187A07780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	private readonly JHFDLGICCMM DGPBANFJJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	private readonly IKHJLIGMDLA PJICLILFLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	private readonly IIJPNLPPLHK CEIDOLNFIOO;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private DAODPIEPEBN BALKOHALHLL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x6065790", Offset = "0x6064590", VA = "0x186065790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x7A0D370", Offset = "0x7A0C170", VA = "0x187A0D370")]
	public GCMKKKKJDED(JHFDLGICCMM DGPBANFJJEC, IKHJLIGMDLA PJICLILFLCE, IIJPNLPPLHK CEIDOLNFIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x7A0D040", Offset = "0x7A0BE40", VA = "0x187A0D040")]
	[AsyncStateMachine(typeof(IFDNFIKBECF))]
	public Task<IPCAKDAELIK> AADKNPFDKKE(IPCAKDAELIK LGADINBMOPF, HGCCILDLOLL GNLCLPGKLAJ, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE, bool HDJJJOOHOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x7A0D210", Offset = "0x7A0C010", VA = "0x187A0D210")]
	[AsyncStateMachine(typeof(BJBKPAIHMMH))]
	private Task<IPCAKDAELIK> LECBEDMEKMC(IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, IPCAKDAELIK DKNLFDPIIII, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A0D1C0", Offset = "0x7A0BFC0", VA = "0x187A0D1C0")]
	private bool ELHINIPEOMJ(IPCAKDAELIK NCFOJEANFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x7A0D1F0", Offset = "0x7A0BFF0", VA = "0x187A0D1F0")]
	private void KAMAHCNLDOK(string LPBIMHGKKKN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct FMMMNNIIILD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct DOPBJKNIMED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public DAODPIEPEBN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public PHJHEBPAOIK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private DOOPFMCKBOH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private List<(PersistenceView, DACMPOAMDBF)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private (PersistenceView, DACMPOAMDBF) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x7A0B160", Offset = "0x7A09F60", VA = "0x187A0B160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x7A0B7B0", Offset = "0x7A0A5B0", VA = "0x187A0B7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x7A0CF00", Offset = "0x7A0BD00", VA = "0x187A0CF00")]
	[AsyncStateMachine(typeof(DOPBJKNIMED))]
	public static Task NJAAPHNJHEI(DAODPIEPEBN GOPOAFOKCPE, HGCCILDLOLL JOAPLPPIFPC, PHJHEBPAOIK GIJHPMLBJPA, CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct LOBLFNEGDNJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct PNHELJIBHKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public DAODPIEPEBN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public PHJHEBPAOIK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private JNOHDJLMBEA <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private DOOPFMCKBOH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private List<(PersistenceView, DACMPOAMDBF)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private DACMPOAMDBF <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x7A1C9D0", Offset = "0x7A1B7D0", VA = "0x187A1C9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x7A1D280", Offset = "0x7A1C080", VA = "0x187A1D280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x7A14430", Offset = "0x7A13230", VA = "0x187A14430")]
	[AsyncStateMachine(typeof(PNHELJIBHKO))]
	public static Task NJAAPHNJHEI(DAODPIEPEBN GOPOAFOKCPE, HGCCILDLOLL JOAPLPPIFPC, PHJHEBPAOIK GIJHPMLBJPA, CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct IFIBKDEODJL
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	public struct DEEGCCJCLHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public List<HMBCJHCCMMO> PMDLKPNALKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public List<DACMPOAMDBF> LGMEPHGDHMB;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x956F00", Offset = "0x955D00", VA = "0x180956F00")]
		public DEEGCCJCLHC(List<HMBCJHCCMMO> PMDLKPNALKG, List<DACMPOAMDBF> LGMEPHGDHMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class NGJLEHMALFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public IEnumerable<HMBCJHCCMMO> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public NGJLEHMALFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x7A17CA0", Offset = "0x7A16AA0", VA = "0x187A17CA0")]
		internal object KOBAHFNMHAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	private MLLAEEOLMLG FDPNEEAEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private HGCCILDLOLL JOAPLPPIFPC;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private INCEBAAAKHE GFIGBBNEHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x7A10080", Offset = "0x7A0EE80", VA = "0x187A10080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x7A10AB0", Offset = "0x7A0F8B0", VA = "0x187A10AB0")]
	public static DEEGCCJCLHC NJAAPHNJHEI(MLLAEEOLMLG FDPNEEAEJHK, HGCCILDLOLL JOAPLPPIFPC)
	{
		return default(DEEGCCJCLHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x7A10850", Offset = "0x7A0F650", VA = "0x187A10850")]
	private DEEGCCJCLHC NJAAPHNJHEI()
	{
		return default(DEEGCCJCLHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x7A102A0", Offset = "0x7A0F0A0", VA = "0x187A102A0")]
	private DEEGCCJCLHC MNBCDPMCJJC(PPNKBAMJHHC CMLNEKGHNFK, JNOHDJLMBEA KPICEBLCLHP)
	{
		return default(DEEGCCJCLHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x7A100D0", Offset = "0x7A0EED0", VA = "0x187A100D0")]
	private bool IEKKPBKDCMB(IEnumerable<HMBCJHCCMMO> PMDLKPNALKG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct GGDMOCPHGHC
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class IPFEKDFJIAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public IFIBKDEODJL.DEEGCCJCLHC instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public IPFEKDFJIAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x7A11E20", Offset = "0x7A10C20", VA = "0x187A11E20")]
		internal object NOBOOBLIJBK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class IHBHLMDMFOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public IHBHLMDMFOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x7A10B10", Offset = "0x7A0F910", VA = "0x187A10B10")]
		internal object EOFLAPCBDLD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x7A0D9E0", Offset = "0x7A0C7E0", VA = "0x187A0D9E0")]
	public static void NJAAPHNJHEI(DAODPIEPEBN GOPOAFOKCPE, HGCCILDLOLL JOAPLPPIFPC, IFIBKDEODJL.DEEGCCJCLHC MJAGJLGKAOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal class IIJPNLPPLHK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct PJPDEGDACKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public IIJPNLPPLHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public IPCAKDAELIK operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public HGCCILDLOLL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x7A1B6E0", Offset = "0x7A1A4E0", VA = "0x187A1B6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x7A1BE50", Offset = "0x7A1AC50", VA = "0x187A1BE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class DODLKCHNKCE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400061A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400061B")]
			public DODLKCHNKCE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400061D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x7A1DE60", Offset = "0x7A1CC60", VA = "0x187A1DE60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x7A1E120", Offset = "0x7A1CF20", VA = "0x187A1E120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public IIJPNLPPLHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public DODLKCHNKCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x7A0B070", Offset = "0x7A09E70", VA = "0x187A0B070")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task CMAADCJOHHE(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct GFIJEBNNCCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public IIJPNLPPLHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private DODLKCHNKCE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x7A0D450", Offset = "0x7A0C250", VA = "0x187A0D450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x7A0D980", Offset = "0x7A0C780", VA = "0x187A0D980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct FJFHFNOKFAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public IIJPNLPPLHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		private Dictionary<Guid, List<LLOOPOHDGBK>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x7A0BF10", Offset = "0x7A0AD10", VA = "0x187A0BF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x7A0C520", Offset = "0x7A0B320", VA = "0x187A0C520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct OBKOCMJOJGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public IIJPNLPPLHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private Dictionary<Guid, List<LLOOPOHDGBK>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x7A197D0", Offset = "0x7A185D0", VA = "0x187A197D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x7A19E70", Offset = "0x7A18C70", VA = "0x187A19E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class DEEPNOFMFKA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000173")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400063E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400063F")]
			public LLOOPOHDGBK handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000640")]
			public DEEPNOFMFKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			private DOOPFMCKBOH <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000642")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005DF")]
			[Cpp2IlInjected.Address(RVA = "0x7A1D990", Offset = "0x7A1C790", VA = "0x187A1D990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x7A1DE00", Offset = "0x7A1CC00", VA = "0x187A1DE00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public FPFIIEFODIP runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public List<LLOOPOHDGBK> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public DEEPNOFMFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x7A0A4E0", Offset = "0x7A092E0", VA = "0x187A0A4E0")]
		internal object DLEGOBECNMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x7A0A5D0", Offset = "0x7A093D0", VA = "0x187A0A5D0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task GFJBHHDGMDL(LLOOPOHDGBK handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x7A0A6D0", Offset = "0x7A094D0", VA = "0x187A0A6D0")]
		internal object GLOJNLCJAIB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct MGHOFGOKFOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public FPFIIEFODIP runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public List<LLOOPOHDGBK> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private DEEPNOFMFKA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x7A15F60", Offset = "0x7A14D60", VA = "0x187A15F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x7A16430", Offset = "0x7A15230", VA = "0x187A16430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct CPJMHJGGPIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public IIJPNLPPLHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x7A09EC0", Offset = "0x7A08CC0", VA = "0x187A09EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x7A0A480", Offset = "0x7A09280", VA = "0x187A0A480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class KPOJMILKGMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public KPOJMILKGMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x7A13DE0", Offset = "0x7A12BE0", VA = "0x187A13DE0")]
		internal object DMECLAKKIEC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct POBOBPANFND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public IIJPNLPPLHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public HGCCILDLOLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x7A1D2E0", Offset = "0x7A1C0E0", VA = "0x187A1D2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x7A1D7A0", Offset = "0x7A1C5A0", VA = "0x187A1D7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class CNBNGHACBDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public CNBNGHACBDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x7A09740", Offset = "0x7A08540", VA = "0x187A09740")]
		internal object HFOCAMBCGAF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct NFHBLLOBHEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public IIJPNLPPLHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter<LJLDKNMPHBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x7A17600", Offset = "0x7A16400", VA = "0x187A17600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x7A17C40", Offset = "0x7A16A40", VA = "0x187A17C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class IMAOGJNBABE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public IMAOGJNBABE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x7A11AE0", Offset = "0x7A108E0", VA = "0x187A11AE0")]
		internal object NEAGBDCHLKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private readonly JHFDLGICCMM DGPBANFJJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private PJAODMICNFG CEIDOLNFIOO;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private DAODPIEPEBN BALKOHALHLL
	{
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xF1CBD0", Offset = "0xF1B9D0", VA = "0x180F1CBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	public IIJPNLPPLHK(JHFDLGICCMM DGPBANFJJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x7A11850", Offset = "0x7A10650", VA = "0x187A11850")]
	[AsyncStateMachine(typeof(PJPDEGDACKD))]
	public Task NJAAPHNJHEI(IPCAKDAELIK GBOHEEMMCLJ, HGCCILDLOLL GNLCLPGKLAJ, IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x7A10FA0", Offset = "0x7A0FDA0", VA = "0x187A10FA0")]
	[AsyncStateMachine(typeof(GFIJEBNNCCE))]
	private Task FEBOGEONOIJ(HGCCILDLOLL JOAPLPPIFPC, IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x7A10CF0", Offset = "0x7A0FAF0", VA = "0x187A10CF0")]
	[AsyncStateMachine(typeof(FJFHFNOKFAA))]
	private Task FCCIKAONHAC(HGCCILDLOLL JOAPLPPIFPC, IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x7A119A0", Offset = "0x7A107A0", VA = "0x187A119A0")]
	[AsyncStateMachine(typeof(OBKOCMJOJGD))]
	private Task PECPPJNGOPB(HGCCILDLOLL JOAPLPPIFPC, IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x7A10BA0", Offset = "0x7A0F9A0", VA = "0x187A10BA0")]
	[AsyncStateMachine(typeof(MGHOFGOKFOK))]
	private Task EEDDDMBJAFL(Guid MDBMMEKPILD, List<LLOOPOHDGBK> CIJAGHEDNFB, FPFIIEFODIP CCBBBAPHPAA, HGCCILDLOLL JOAPLPPIFPC, CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x7A11490", Offset = "0x7A10290", VA = "0x187A11490")]
	[AsyncStateMachine(typeof(CPJMHJGGPIK))]
	private Task JLCHMMAGPBA(HGCCILDLOLL JOAPLPPIFPC, IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x7A115D0", Offset = "0x7A103D0", VA = "0x187A115D0")]
	[AsyncStateMachine(typeof(POBOBPANFND))]
	private Task KHGLOLDJKOD(Guid LKBLJBCEIGJ, HGCCILDLOLL JOAPLPPIFPC, IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x7A11710", Offset = "0x7A10510", VA = "0x187A11710")]
	[AsyncStateMachine(typeof(NFHBLLOBHEC))]
	private Task MDNEENGHFAN(Guid LKBLJBCEIGJ, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x7A11190", Offset = "0x7A0FF90", VA = "0x187A11190")]
	private void HJLFFGGOLNF(Guid LKBLJBCEIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x7A110E0", Offset = "0x7A0FEE0", VA = "0x187A110E0")]
	private void GDJNPDIJMFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x7A10E30", Offset = "0x7A0FC30", VA = "0x187A10E30")]
	public Guid FCFFIBPFAOK(IPCAKDAELIK CNIELKHDHMK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x7A112B0", Offset = "0x7A100B0", VA = "0x187A112B0")]
	[CompilerGenerated]
	private object IHAOKJGHAFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal struct KGOGALFGJCM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct LODGKDNBPOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public KGOGALFGJCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private IEnumerator<ILBEHEIANIK> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x7A14570", Offset = "0x7A13370", VA = "0x187A14570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x7A14C00", Offset = "0x7A13A00", VA = "0x187A14C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private INCEBAAAKHE BPGIOHMMDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private CancellationToken FEHCANHDGHE;

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x7A135D0", Offset = "0x7A123D0", VA = "0x187A135D0")]
	public static Task CDDJHLLIBBJ(INCEBAAAKHE BPGIOHMMDAI, IGPFJOOPHMK<string>.PDLCJKJEJBF HPEGCCHCIAG, CancellationToken MPCJFMBODJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x7A13640", Offset = "0x7A12440", VA = "0x187A13640")]
	[AsyncStateMachine(typeof(LODGKDNBPOD))]
	private Task NJAAPHNJHEI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public readonly struct MMFABIGAOLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	public readonly bool FBHFNIBCPBE;

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x271F930", Offset = "0x271E730", VA = "0x18271F930")]
	public MMFABIGAOLJ(bool MICELPCCDHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
public readonly struct HHJNAOPPEEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	public readonly PPNKBAMJHHC? BGINDAILAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	public readonly ALFFPJAMDPL BDHLJFDLDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	public readonly string? BLNOKFAPNDF;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public IReadOnlyCollection<string> CIPPMGAMIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x7A0F3D0", Offset = "0x7A0E1D0", VA = "0x187A0F3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyDictionary<long, int> LAJPABIBBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x7A0F3B0", Offset = "0x7A0E1B0", VA = "0x187A0F3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x7A0F3F0", Offset = "0x7A0E1F0", VA = "0x187A0F3F0")]
	public HHJNAOPPEEO(PPNKBAMJHHC? BGIEPHNJHFK, ALFFPJAMDPL NHGIHMDLEGE, string? BDGGACIHCDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class GKDCEEMHMOI : HPKPGEMMHDP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct OOKLEHKCJCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public AsyncTaskMethodBuilder<HHJNAOPPEEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public GKDCEEMHMOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public BEPIOHBDIFE serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public AAOEHFDAHGE roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private DOOPFMCKBOH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x7A1AFF0", Offset = "0x7A19DF0", VA = "0x187A1AFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x7A1B670", Offset = "0x7A1A470", VA = "0x187A1B670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class OBGKGEJHGIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public BEPIOHBDIFE serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public GKDCEEMHMOI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public OBGKGEJHGIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x7A195B0", Offset = "0x7A183B0", VA = "0x187A195B0")]
		internal Task PMJOBADEPAE(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x7A194D0", Offset = "0x7A182D0", VA = "0x187A194D0")]
		internal Task OEOCJFNPBAE(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class JAHLGMLHGJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public OBGKGEJHGIC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public JAHLGMLHGJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x7A12750", Offset = "0x7A11550", VA = "0x187A12750")]
		internal object IIECDGOHEOD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class INHEAOFJJLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public OBGKGEJHGIC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public INHEAOFJJLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x7A11B50", Offset = "0x7A10950", VA = "0x187A11B50")]
		internal Task CDDIAHJJIIE(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct ACHCPNLCCLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public BEPIOHBDIFE serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public GKDCEEMHMOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private JAHLGMLHGJK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private DOOPFMCKBOH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x7A04DF0", Offset = "0x7A03BF0", VA = "0x187A04DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x7A05660", Offset = "0x7A04460", VA = "0x187A05660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	private readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x4000679")]
	private static readonly TimeSpan PFLBHJEJGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	private readonly PIEHGCCOPPA HFEIDHFGJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400067B")]
	private readonly FNKPDKCGBJE LGPALNGAAAP;

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x7A0F0E0", Offset = "0x7A0DEE0", VA = "0x187A0F0E0")]
	public GKDCEEMHMOI(JHFDLGICCMM DGPBANFJJEC, PIEHGCCOPPA HFEIDHFGJDL, FNKPDKCGBJE NLPIOFLFKNO, IMOCAMGHNDM JBCGOBEIKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x7A0EA70", Offset = "0x7A0D870", VA = "0x187A0EA70")]
	[AsyncStateMachine(typeof(OOKLEHKCJCE))]
	public Task<HHJNAOPPEEO> NPIKEPIONAB(long MGNAIIKHEOI, AAOEHFDAHGE PFKEDCLDLDD, BEPIOHBDIFE FLIOBDGHCMA, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x7A0E340", Offset = "0x7A0D140", VA = "0x187A0E340")]
	[AsyncStateMachine(typeof(ACHCPNLCCLJ))]
	private Task GLBHCNKFEED(BEPIOHBDIFE FLIOBDGHCMA, IEnumerable<PersistenceView> MJMMOJPFBMG, StringBuilder GIHIPEJIILN, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x7A0E480", Offset = "0x7A0D280", VA = "0x187A0E480")]
	private HHJNAOPPEEO IMDFKECPDOJ(long MGNAIIKHEOI, AAOEHFDAHGE PFKEDCLDLDD, BEPIOHBDIFE FLIOBDGHCMA, IEnumerable<PersistenceView> MJMMOJPFBMG, StringBuilder GIHIPEJIILN)
	{
		return default(HHJNAOPPEEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x7A0DF90", Offset = "0x7A0CD90", VA = "0x187A0DF90")]
	private PPNKBAMJHHC DICPGGJNDMH(long MGNAIIKHEOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x7A0E0F0", Offset = "0x7A0CEF0", VA = "0x187A0E0F0")]
	private void GGHIAMGJEOE(PPNKBAMJHHC BGCDDBLLNAB, StringBuilder GIHIPEJIILN, IEnumerable<PersistenceView> MJMMOJPFBMG, [In] ANMNGACNHED BPKDPANDGEC, HDFFBIDJGIE IGKBCMGONPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x7A0EBD0", Offset = "0x7A0D9D0", VA = "0x187A0EBD0")]
	private void OPJKLBEJGFD(PPNKBAMJHHC BGCDDBLLNAB, StringBuilder GIHIPEJIILN, PersistenceView FHOIFELJGJL, HDFFBIDJGIE IGKBCMGONPM, [In] ANMNGACNHED BPKDPANDGEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal class OANOFMFOEJL : HPKPGEMMHDP
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class MDAMJHJOJPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public PDKLFCMALOG.IPGJLKDJHHK roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MDAMJHJOJPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x7A15DF0", Offset = "0x7A14BF0", VA = "0x187A15DF0")]
		internal object JMKMJDBNKHH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct CHLMNJOCKGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public AsyncTaskMethodBuilder<(PDKLFCMALOG.IPGJLKDJHHK roomDataUpload, PDKLFCMALOG.IPGJLKDJHHK subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public HHJNAOPPEEO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public OANOFMFOEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private MDAMJHJOJPI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private TaskAwaiter<PDKLFCMALOG.IPGJLKDJHHK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x7A08170", Offset = "0x7A06F70", VA = "0x187A08170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x7A089D0", Offset = "0x7A077D0", VA = "0x187A089D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct DPHINACEBBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public AsyncTaskMethodBuilder<LBFPONJCALF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public OANOFMFOEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public HHJNAOPPEEO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public HHDDNHJGPBH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private TaskAwaiter<(PDKLFCMALOG.IPGJLKDJHHK roomDataUpload, PDKLFCMALOG.IPGJLKDJHHK subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private TaskAwaiter<LBFPONJCALF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x7A0B810", Offset = "0x7A0A610", VA = "0x187A0B810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x7A0BEA0", Offset = "0x7A0ACA0", VA = "0x187A0BEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private struct OGDHHBIIEOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public AsyncTaskMethodBuilder<BCOPHPGONJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public OANOFMFOEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public HHJNAOPPEEO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private TaskAwaiter<(PDKLFCMALOG.IPGJLKDJHHK roomDataUpload, PDKLFCMALOG.IPGJLKDJHHK subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private TaskAwaiter<BCOPHPGONJP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x7A1AB70", Offset = "0x7A19970", VA = "0x187A1AB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x7A1AF80", Offset = "0x7A19D80", VA = "0x187A1AF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class MBBMOIOAIDF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018D")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			public AsyncTaskMethodBuilder<LJLDKNMPHBD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			public MBBMOIOAIDF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			private LJLDKNMPHBD <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006CC")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006CD")]
			private TaskAwaiter<BCOPHPGONJP> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006CE")]
			private TaskAwaiter<LBFPONJCALF> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006CF")]
			private TaskAwaiter<LJLDKNMPHBD> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0x7A1E570", Offset = "0x7A1D370", VA = "0x187A1E570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x7A1F560", Offset = "0x7A1E360", VA = "0x187A1F560", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public OANOFMFOEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public HHJNAOPPEEO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public HHDDNHJGPBH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public MMFABIGAOLJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MBBMOIOAIDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x7A150E0", Offset = "0x7A13EE0", VA = "0x187A150E0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<LJLDKNMPHBD> EIHPGDHLEBL(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct OCOBHEMHHPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public AsyncTaskMethodBuilder<LJLDKNMPHBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public OANOFMFOEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public HHJNAOPPEEO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public HHDDNHJGPBH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		public MMFABIGAOLJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		private TaskAwaiter<LJLDKNMPHBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x7A1A460", Offset = "0x7A19260", VA = "0x187A1A460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x7A1A770", Offset = "0x7A19570", VA = "0x187A1A770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private static readonly IMOCAMGHNDM JPIJNFLANHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private readonly NPLKADIIGBP OIGLNJLKCKO;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private MLLAEEOLMLG COAJJGLBPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x79FFD50", Offset = "0x79FEB50", VA = "0x1879FFD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x7A19440", Offset = "0x7A18240", VA = "0x187A19440")]
	public OANOFMFOEJL(JHFDLGICCMM DGPBANFJJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x7A190F0", Offset = "0x7A17EF0", VA = "0x187A190F0")]
	[AsyncStateMachine(typeof(CHLMNJOCKGH))]
	private Task<(PDKLFCMALOG.IPGJLKDJHHK, PDKLFCMALOG.IPGJLKDJHHK)> OKCLCKIKPDE(HHJNAOPPEEO OCJDGCBLJNF, long OGMIFIGJENM, long FIAEJOGALJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x7A19230", Offset = "0x7A18030", VA = "0x187A19230")]
	[AsyncStateMachine(typeof(DPHINACEBBC))]
	public Task<LBFPONJCALF> PICKPDLOHGB(int HJIDJEJFNED, [CanBeNull] HHDDNHJGPBH GPJDHCNHKAI, HHJNAOPPEEO OCJDGCBLJNF, long OGMIFIGJENM, long FIAEJOGALJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x7A18DE0", Offset = "0x7A17BE0", VA = "0x187A18DE0")]
	[AsyncStateMachine(typeof(OGDHHBIIEOC))]
	private Task<BCOPHPGONJP> APIEBOODDCG(string BOHOGABJBDK, int HJIDJEJFNED, HHJNAOPPEEO OCJDGCBLJNF, long OGMIFIGJENM, long FIAEJOGALJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x7A18F50", Offset = "0x7A17D50", VA = "0x187A18F50")]
	[AsyncStateMachine(typeof(OCOBHEMHHPC))]
	public Task<LJLDKNMPHBD> EGIGIDBCEJH(int HJIDJEJFNED, HHDDNHJGPBH? GPJDHCNHKAI, HHJNAOPPEEO OCJDGCBLJNF, long OGMIFIGJENM, long FIAEJOGALJF, MMFABIGAOLJ EILNEAFHKMN, IGPFJOOPHMK<string>.PDLCJKJEJBF IBCMMJAJPGM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public abstract class NIJDFAPLLPM<T> where T : NIJDFAPLLPM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	internal readonly MLLAEEOLMLG AHAHEHDMFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private int? BCLPNMCELJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	protected readonly Guid GCOEJOABMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	protected readonly KGAIIGHCNDA GPOKIOHADPG;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	protected T ECGBJINOBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x4D2D340", Offset = "0x4D2C140", VA = "0x184D2D340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x4D2D650", Offset = "0x4D2C450", VA = "0x184D2D650")]
	internal NIJDFAPLLPM(MLLAEEOLMLG DGLIKOHLFDA, KGAIIGHCNDA HFPALCMEFCE, [Optional] Guid? KCDDPKBGHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x4D2D3A0", Offset = "0x4D2C1A0", VA = "0x184D2D3A0")]
	private LJLDKNMPHBD FJAGNEPJNPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "4")]
	protected virtual void DOPALDIJNGP(LJLDKNMPHBD KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x4D2D5B0", Offset = "0x4D2C3B0", VA = "0x184D2D5B0")]
	public T OPNBIFPOHFF(NJGJGBGCLGP ANICBEHNGEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x4D2D2A0", Offset = "0x4D2C0A0", VA = "0x184D2D2A0")]
	public T CLEKKJIHMHN(int FPDHOHHCEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x4D2D480", Offset = "0x4D2C280", VA = "0x184D2D480", Slot = "5")]
	public virtual Task<MDFDKOJBEAB> FJBOCJMAHOO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class CEGDAGAFMIF : NIJDFAPLLPM<CEGDAGAFMIF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private JAJOICLCDFI KGDIEBJBNPG;

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x7A222E0", Offset = "0x7A210E0", VA = "0x187A222E0")]
	internal CEGDAGAFMIF(MLLAEEOLMLG DGLIKOHLFDA, KGAIIGHCNDA HFPALCMEFCE, [Optional] Guid? KCDDPKBGHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x6E18F90", Offset = "0x6E17D90", VA = "0x186E18F90")]
	public CEGDAGAFMIF IFIGPAPFOPH(JAJOICLCDFI KGDIEBJBNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x7A22210", Offset = "0x7A21010", VA = "0x187A22210", Slot = "4")]
	protected override void DOPALDIJNGP(LJLDKNMPHBD KKBJAPCBOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public class KFLNFPMFNCF : NIJDFAPLLPM<KFLNFPMFNCF>
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	internal enum MMKHHBFGFBH
	{
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct NCONOMKGCND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public AsyncTaskMethodBuilder<MDFDKOJBEAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public KFLNFPMFNCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private TaskAwaiter<MDFDKOJBEAB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x7A25C20", Offset = "0x7A24A20", VA = "0x187A25C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x7A25FC0", Offset = "0x7A24DC0", VA = "0x187A25FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private MMKHHBFGFBH BONPJNGGLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006E2")]
	private string BIGJOCENFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006E3")]
	private HHDDNHJGPBH KGDIEBJBNPG;

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x7A24F00", Offset = "0x7A23D00", VA = "0x187A24F00")]
	internal KFLNFPMFNCF(MLLAEEOLMLG DGLIKOHLFDA, KGAIIGHCNDA HFPALCMEFCE, [Optional] Guid? KCDDPKBGHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x7A24E80", Offset = "0x7A23C80", VA = "0x187A24E80")]
	public KFLNFPMFNCF JLEFGLIJNDK(string CHJIHJFAIKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x7A24C00", Offset = "0x7A23A00", VA = "0x187A24C00")]
	public KFLNFPMFNCF BAEPFCCPNHG(bool PKOCBCAMNBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x7A24EB0", Offset = "0x7A23CB0", VA = "0x187A24EB0")]
	public KFLNFPMFNCF KGLMFGIEAAH(bool JBIJEGEDNFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x7A24ED0", Offset = "0x7A23CD0", VA = "0x187A24ED0")]
	public KFLNFPMFNCF OJPAGOJOEMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x7A24C20", Offset = "0x7A23A20", VA = "0x187A24C20", Slot = "4")]
	protected override void DOPALDIJNGP(LJLDKNMPHBD KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x7A24D90", Offset = "0x7A23B90", VA = "0x187A24D90", Slot = "5")]
	[AsyncStateMachine(typeof(NCONOMKGCND))]
	public override Task<MDFDKOJBEAB> FJBOCJMAHOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x7A24BC0", Offset = "0x7A239C0", VA = "0x187A24BC0")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<MDFDKOJBEAB> ADLMCGFADLB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
internal static class NJKMONDICNM
{
	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x7A26030", Offset = "0x7A24E30", VA = "0x187A26030")]
	public static void AHOFGAPFDJF(this DLPEEKOIOEF IBDEJDGIMAF, NCNEODEEIGF GCFPOGJCBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x7A26180", Offset = "0x7A24F80", VA = "0x187A26180")]
	public static void EACJHLMBFMJ(this NCNEODEEIGF HBGCIECBLBO, [Optional] string KKBJAPCBOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public static class BBDGJEOGKDB
{
	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x7A20480", Offset = "0x7A1F280", VA = "0x187A20480")]
	public static HOAPPKHGKNJ EKFMBLGBCHB(this AMHFMFCKHDP EKPBIKEGPLB)
	{
		return default(HOAPPKHGKNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x7A20520", Offset = "0x7A1F320", VA = "0x187A20520")]
	public static AMHFMFCKHDP MJHMLIGOFAF(this HOAPPKHGKNJ LKLDLLKLLBP)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000197")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F0")]
			public NKHMBKOCNEM ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006F1")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006F2")]
			public NKHMBKOCNEM HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006F3")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006F4")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006F5")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		private static NKHMBKOCNEM[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		private Dictionary<NKHMBKOCNEM, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x7A267C0", Offset = "0x7A255C0", VA = "0x187A267C0")]
		public bool JOCHHFNOECO(NKHMBKOCNEM JKHEMJOGAHK, [Out] ResultConfig LHCHLNOABPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x7A26830", Offset = "0x7A25630", VA = "0x187A26830")]
		public ResultConfig MDEMKMCGJCE(NKHMBKOCNEM ADJDIHDFFBH, [Optional] HashSet<NKHMBKOCNEM> BFEMGFMCHMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x7A26F40", Offset = "0x7A25D40", VA = "0x187A26F40", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x7A26970", Offset = "0x7A25770", VA = "0x187A26970", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0xA79E30", Offset = "0xA78C30", VA = "0x180A79E30")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class CKOOLFNJDDC : LNKPOCDFECC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct KEAIMFABFOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public CKOOLFNJDDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x7A248D0", Offset = "0x7A236D0", VA = "0x187A248D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x7A24B60", Offset = "0x7A23960", VA = "0x187A24B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct BMENIGGPFNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public IGPFJOOPHMK<string>.PDLCJKJEJBF timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public LNKPOCDFECC preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private IGPFJOOPHMK<string>.PDLCJKJEJBF <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x7A216A0", Offset = "0x7A204A0", VA = "0x187A216A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x7A21BB0", Offset = "0x7A209B0", VA = "0x187A21BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006FB")]
	private readonly FDGBAGFLNBJ DOHEOLFKKHN;

	[Cpp2IlInjected.Token(Token = "0x40006FC")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public string PANACBABADG
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x7A22410", Offset = "0x7A21210", VA = "0x187A22410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x7A22670", Offset = "0x7A21470", VA = "0x187A22670")]
	[FOLINPJCBJN.HMBDLNHFFEJ.EKAOCHOMHGE]
	internal static void OGLOOKLDEDN(IEPIHLKICIO JMPMFBCPFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	[RecRoom.NoEngine.Common.Preserve]
	public CKOOLFNJDDC([MHFJPMCEEAM(null)] FDGBAGFLNBJ DOHEOLFKKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x7A22560", Offset = "0x7A21360", VA = "0x187A22560", Slot = "5")]
	[AsyncStateMachine(typeof(KEAIMFABFOP))]
	public Task NJAAPHNJHEI(IGPFJOOPHMK<string>.PDLCJKJEJBF NNGOKEMGHAE, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x7A22440", Offset = "0x7A21240", VA = "0x187A22440")]
	[AsyncStateMachine(typeof(BMENIGGPFNJ))]
	private Task HMLPJBJMDPC(LNKPOCDFECC KPBECGJGAHD, IGPFJOOPHMK<string>.PDLCJKJEJBF NNGOKEMGHAE, CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public interface FDGBAGFLNBJ : LNKPOCDFECC
{
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public interface LNKPOCDFECC
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	string PANACBABADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NJAAPHNJHEI(IGPFJOOPHMK<string>.PDLCJKJEJBF NNGOKEMGHAE, CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public static class JMONOELJOEA
{
	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x7A244C0", Offset = "0x7A232C0", VA = "0x187A244C0")]
	[FOLINPJCBJN.HMBDLNHFFEJ.EKAOCHOMHGE]
	internal static void GGGLAIJELEP(IEPIHLKICIO JMPMFBCPFJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public interface GFONHMBPIOH : IEquatable<GFONHMBPIOH>
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	DateTime NDFLOKPACJN
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHMALGCFHGA();

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DIHGOOIKFDK(long OGMIFIGJENM, long MGNAIIKHEOI, [Out] HHJNAOPPEEO OCJDGCBLJNF);
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal class BBDOMLIEFAP : CKBHPLBLHEH
{
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private sealed class BCLEMICOJEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public BPFCEEPJHKL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public BCLEMICOJEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x7A21170", Offset = "0x7A1FF70", VA = "0x187A21170")]
		internal object GABCCDDGNEO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400070A")]
	private readonly PGFPJIEDOIO EIEGAEOIOIP;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<GFONHMBPIOH> OGEFGDEDPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x7A20C10", Offset = "0x7A1FA10", VA = "0x187A20C10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x7A210C0", Offset = "0x7A1FEC0", VA = "0x187A210C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	[UnityEngine.Scripting.Preserve]
	public BBDOMLIEFAP([MHFJPMCEEAM(null)] PGFPJIEDOIO EIEGAEOIOIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x7A20CC0", Offset = "0x7A1FAC0", VA = "0x187A20CC0", Slot = "6")]
	public bool IOGPHKOLJMF(long OGMIFIGJENM, long MGNAIIKHEOI, HHJNAOPPEEO OCJDGCBLJNF, BPFCEEPJHKL MAPIMEJAPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0xC7A120", Offset = "0xC78F20", VA = "0x180C7A120")]
	private void JBENNMGAFLH(GFONHMBPIOH MCNBGALBPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x7A20AA0", Offset = "0x7A1F8A0", VA = "0x187A20AA0", Slot = "7")]
	public bool FCCLDBAFCIC(long OGMIFIGJENM, long MGNAIIKHEOI, [Out] GFONHMBPIOH MFPHOGLGEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x7A209F0", Offset = "0x7A1F7F0", VA = "0x187A209F0", Slot = "8")]
	public bool EDFGJEGKOKL(long OGMIFIGJENM, long MGNAIIKHEOI, BPFCEEPJHKL MAPIMEJAPGE, [Out] GFONHMBPIOH MFPHOGLGEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x7A205D0", Offset = "0x7A1F3D0", VA = "0x187A205D0")]
	private void BHBBFDFKCBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x7A20FB0", Offset = "0x7A1FDB0", VA = "0x187A20FB0", Slot = "9")]
	public void JOIPFIDIDFI(long OGMIFIGJENM, long MGNAIIKHEOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal abstract class GELPHGCBGDH : PGFPJIEDOIO
{
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	protected enum IFKIHEPEJFN : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class PBECOHHABPL : IEnumerable<GFONHMBPIOH>, IEnumerable, IEnumerator<GFONHMBPIOH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		private GFONHMBPIOH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public GELPHGCBGDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		private BPFCEEPJHKL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public BPFCEEPJHKL <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		private GFONHMBPIOH System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600067E")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xC3B4C0", Offset = "0xC3A2C0", VA = "0x180C3B4C0")]
		[DebuggerHidden]
		public PBECOHHABPL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x7A26200", Offset = "0x7A25000", VA = "0x187A26200", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x7A264E0", Offset = "0x7A252E0", VA = "0x187A264E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x7A26430", Offset = "0x7A25230", VA = "0x187A26430", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GFONHMBPIOH> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x7A26430", Offset = "0x7A25230", VA = "0x187A26430", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private sealed class ICAINIAJKEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public BPFCEEPJHKL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ICAINIAJKEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x7A24420", Offset = "0x7A23220", VA = "0x187A24420")]
		internal object NAEFKGIFGGK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class LCPAINHOPKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public GELPHGCBGDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public LCPAINHOPKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x7A25070", Offset = "0x7A23E70", VA = "0x187A25070")]
		internal void NBCDLDAOPGP(LHOJGDHEBLB.CDOKBOADMPM ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000710")]
	private readonly object PJIBMNPMPOA;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	protected string NDADLCGIIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x7A23A20", Offset = "0x7A22820", VA = "0x187A23A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public abstract IGABNMCOEFB LPAPJDCMIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x7A24080", Offset = "0x7A22E80", VA = "0x187A24080")]
	protected GELPHGCBGDH([CanBeNull] string OCKBCEFDLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x7A23AC0", Offset = "0x7A228C0", VA = "0x187A23AC0", Slot = "5")]
	public bool FLMCIBCILMO(long OGMIFIGJENM, long MGNAIIKHEOI, BPFCEEPJHKL MAPIMEJAPGE, [Out] GFONHMBPIOH MCNBGALBPCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x7A23A30", Offset = "0x7A22830", VA = "0x187A23A30", Slot = "6")]
	[IteratorStateMachine(typeof(PBECOHHABPL))]
	public IEnumerable<GFONHMBPIOH> CDALLLDCLCC(BPFCEEPJHKL MAPIMEJAPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void BMBKPHHBLBH(Stream OCMLLDJNEGG, long OGMIFIGJENM, long MGNAIIKHEOI, HHJNAOPPEEO OCJDGCBLJNF);

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool GAFPAIFJBHC(Stream HIFGBACPINP, long OGMIFIGJENM, long MGNAIIKHEOI, GKKEBOMGFNI BOLDKFFDAGG, [Out] HHJNAOPPEEO OCJDGCBLJNF);

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x7A23D10", Offset = "0x7A22B10", VA = "0x187A23D10", Slot = "7")]
	public GFONHMBPIOH PDKABCMGILB(long OGMIFIGJENM, long MGNAIIKHEOI, HHJNAOPPEEO OCJDGCBLJNF, BPFCEEPJHKL MAPIMEJAPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo MOKAKIBONNH(long OGMIFIGJENM, long MGNAIIKHEOI, BPFCEEPJHKL MAPIMEJAPGE, IFKIHEPEJFN LMHMKHIHJNI);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo HHMHBKNKEGB(BPFCEEPJHKL MAPIMEJAPGE, IFKIHEPEJFN LMHMKHIHJNI);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x7A23CA0", Offset = "0x7A22AA0", VA = "0x187A23CA0")]
	protected void LFKPOJACLNH(LHOJGDHEBLB.CDOKBOADMPM FIDBKHPNJIA, string LPBIMHGKKKN, FileInfo MFGIEEBHEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x7A23670", Offset = "0x7A22470", VA = "0x187A23670")]
	internal bool AJHBKJBAFNB(FileInfo ECGAJMAIAAO, long OGMIFIGJENM, long MGNAIIKHEOI, [Out] HHJNAOPPEEO OCJDGCBLJNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
	private void CMLAPKIGJMF(Exception GJIKOBIBPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal class LEGFLECKOKC : GELPHGCBGDH
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public override IGABNMCOEFB LPAPJDCMIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x1B69CB0", Offset = "0x1B68AB0", VA = "0x181B69CB0", Slot = "8")]
		get
		{
			return default(IGABNMCOEFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x7A25BE0", Offset = "0x7A249E0", VA = "0x187A25BE0")]
	public LEGFLECKOKC([Optional] string OCKBCEFDLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x7A25380", Offset = "0x7A24180", VA = "0x187A25380")]
	private void FEFOGFKHJOF(BPFCEEPJHKL MAPIMEJAPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x7A250F0", Offset = "0x7A23EF0", VA = "0x187A250F0", Slot = "9")]
	internal override void BMBKPHHBLBH(Stream OCMLLDJNEGG, long OGMIFIGJENM, long MGNAIIKHEOI, HHJNAOPPEEO OCJDGCBLJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x7A25400", Offset = "0x7A24200", VA = "0x187A25400", Slot = "10")]
	internal override bool GAFPAIFJBHC(Stream HIFGBACPINP, long OGMIFIGJENM, long MGNAIIKHEOI, GKKEBOMGFNI BOLDKFFDAGG, [Out] HHJNAOPPEEO OCJDGCBLJNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x7A25AF0", Offset = "0x7A248F0", VA = "0x187A25AF0", Slot = "11")]
	protected override FileInfo MOKAKIBONNH(long OGMIFIGJENM, long MGNAIIKHEOI, BPFCEEPJHKL MAPIMEJAPGE, IFKIHEPEJFN LMHMKHIHJNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x7A259F0", Offset = "0x7A247F0", VA = "0x187A259F0", Slot = "12")]
	protected override DirectoryInfo HHMHBKNKEGB(BPFCEEPJHKL MAPIMEJAPGE, IFKIHEPEJFN LMHMKHIHJNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal sealed class ELIGAPDEACH : GELPHGCBGDH
{
	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private static readonly byte[] FFOHLCGHDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000721")]
	private readonly byte[] GJCPNNMEDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000722")]
	private readonly byte[] BOBPNDKMPLA;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public override IGABNMCOEFB LPAPJDCMIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x668C8B0", Offset = "0x668B6B0", VA = "0x18668C8B0", Slot = "8")]
		get
		{
			return default(IGABNMCOEFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x7A23580", Offset = "0x7A22380", VA = "0x187A23580")]
	public ELIGAPDEACH([Optional] string OCKBCEFDLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x7A22750", Offset = "0x7A21550", VA = "0x187A22750", Slot = "9")]
	internal override void BMBKPHHBLBH(Stream OCMLLDJNEGG, long OGMIFIGJENM, long MGNAIIKHEOI, HHJNAOPPEEO OCJDGCBLJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x7A22A10", Offset = "0x7A21810", VA = "0x187A22A10", Slot = "10")]
	internal override bool GAFPAIFJBHC(Stream HIFGBACPINP, long OGMIFIGJENM, long MGNAIIKHEOI, GKKEBOMGFNI BOLDKFFDAGG, [Out] HHJNAOPPEEO OCJDGCBLJNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x7A23430", Offset = "0x7A22230", VA = "0x187A23430")]
	private void NAHANOAFIDG(byte[] MDJJEFJEKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x7A23300", Offset = "0x7A22100", VA = "0x187A23300", Slot = "11")]
	protected override FileInfo MOKAKIBONNH(long OGMIFIGJENM, long MGNAIIKHEOI, BPFCEEPJHKL MAPIMEJAPGE, IFKIHEPEJFN LMHMKHIHJNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x7A231F0", Offset = "0x7A21FF0", VA = "0x187A231F0", Slot = "12")]
	protected override DirectoryInfo HHMHBKNKEGB(BPFCEEPJHKL MAPIMEJAPGE, IFKIHEPEJFN LMHMKHIHJNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public enum IGABNMCOEFB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000725")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal class ADCDMJJDNGA : PGFPJIEDOIO
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class BJIGLBBLNGN : IEnumerable<GFONHMBPIOH>, IEnumerable, IEnumerator<GFONHMBPIOH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private GFONHMBPIOH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public ADCDMJJDNGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private BPFCEEPJHKL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public BPFCEEPJHKL <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private IGABNMCOEFB[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		private IEnumerator<GFONHMBPIOH> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		private GFONHMBPIOH System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006A5")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xC3B4C0", Offset = "0xC3A2C0", VA = "0x180C3B4C0")]
		[DebuggerHidden]
		public BJIGLBBLNGN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x7A21610", Offset = "0x7A20410", VA = "0x187A21610", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x7A21230", Offset = "0x7A20030", VA = "0x187A21230", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x7A211E0", Offset = "0x7A1FFE0", VA = "0x187A211E0")]
		private void GEDOPIMJGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x7A215C0", Offset = "0x7A203C0", VA = "0x187A215C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x7A21510", Offset = "0x7A20310", VA = "0x187A21510", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GFONHMBPIOH> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x7A21510", Offset = "0x7A20310", VA = "0x187A21510", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	private readonly IGABNMCOEFB[] AIDGNHHHAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000728")]
	private readonly Dictionary<IGABNMCOEFB, PGFPJIEDOIO> IBNICAGAOLO;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public IGABNMCOEFB LPAPJDCMIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x7A1FE60", Offset = "0x7A1EC60", VA = "0x187A1FE60", Slot = "4")]
		get
		{
			return default(IGABNMCOEFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x7A20130", Offset = "0x7A1EF30", VA = "0x187A20130")]
	[UnityEngine.Scripting.Preserve]
	public ADCDMJJDNGA(params PGFPJIEDOIO[] POKCCDMGMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x7A1FE90", Offset = "0x7A1EC90", VA = "0x187A1FE90", Slot = "5")]
	public bool FLMCIBCILMO(long OGMIFIGJENM, long MGNAIIKHEOI, BPFCEEPJHKL MAPIMEJAPGE, [Out] GFONHMBPIOH MCNBGALBPCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x7A1FC30", Offset = "0x7A1EA30", VA = "0x187A1FC30")]
	private void COOOJDEFCKJ(int OLAKLKIEEIO, long OGMIFIGJENM, long MGNAIIKHEOI, BPFCEEPJHKL MAPIMEJAPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x7A1FBA0", Offset = "0x7A1E9A0", VA = "0x187A1FBA0", Slot = "6")]
	[IteratorStateMachine(typeof(BJIGLBBLNGN))]
	public IEnumerable<GFONHMBPIOH> CDALLLDCLCC(BPFCEEPJHKL MAPIMEJAPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x7A1FFE0", Offset = "0x7A1EDE0", VA = "0x187A1FFE0", Slot = "7")]
	public GFONHMBPIOH PDKABCMGILB(long OGMIFIGJENM, long MGNAIIKHEOI, HHJNAOPPEEO OCJDGCBLJNF, BPFCEEPJHKL MAPIMEJAPGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class IBBEGIPLDAE
{
	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A24180", Offset = "0x7A22F80", VA = "0x187A24180")]
	internal static byte[] LCIONDKOBNE(byte[] MDJJEFJEKNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x7A24100", Offset = "0x7A22F00", VA = "0x187A24100")]
	public static void DPDNJNIEEPF(Stream ONEEGGNAFGN, byte[] NODKMKHHPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x7A24240", Offset = "0x7A23040", VA = "0x187A24240")]
	public static bool OEBNDAKNAGG(Stream ONEEGGNAFGN, long KANPACBGLPD, GKKEBOMGFNI ALBAEOHFPCH, [Out] byte[] HFOBFNENJEG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
internal sealed class BOLOEAAHJEM : GFONHMBPIOH, IEquatable<GFONHMBPIOH>, IEquatable<BOLOEAAHJEM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000736")]
	private readonly GELPHGCBGDH HDOLLKPAHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000737")]
	public readonly FileInfo ABCILFHIKLA;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public IGABNMCOEFB LPAPJDCMIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x7376A20", Offset = "0x7375820", VA = "0x187376A20", Slot = "9")]
		get
		{
			return default(IGABNMCOEFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public DateTime NDFLOKPACJN
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x7A21D10", Offset = "0x7A20B10", VA = "0x187A21D10", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x7A22100", Offset = "0x7A20F00", VA = "0x187A22100")]
	public BOLOEAAHJEM(GELPHGCBGDH IOHJHDDMCJK, FileInfo ECGAJMAIAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x7A22050", Offset = "0x7A20E50", VA = "0x187A22050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x7A21C10", Offset = "0x7A20A10", VA = "0x187A21C10", Slot = "5")]
	public void BHMALGCFHGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x7A21CD0", Offset = "0x7A20AD0", VA = "0x187A21CD0", Slot = "6")]
	public bool DIHGOOIKFDK(long OGMIFIGJENM, long MGNAIIKHEOI, [Out] HHJNAOPPEEO OCJDGCBLJNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x7A21F50", Offset = "0x7A20D50", VA = "0x187A21F50", Slot = "7")]
	public bool Equals(GFONHMBPIOH LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x7A21DA0", Offset = "0x7A20BA0", VA = "0x187A21DA0", Slot = "8")]
	public bool Equals(BOLOEAAHJEM LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x7A21E60", Offset = "0x7A20C60", VA = "0x187A21E60", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x7A21FC0", Offset = "0x7A20DC0", VA = "0x187A21FC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public delegate void GKKEBOMGFNI(LHOJGDHEBLB.CDOKBOADMPM GFPKPNCCFLN, string KKBJAPCBOHH);
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface PGFPJIEDOIO
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	IGABNMCOEFB LPAPJDCMIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FLMCIBCILMO(long OGMIFIGJENM, long MGNAIIKHEOI, BPFCEEPJHKL MAPIMEJAPGE, [Out] GFONHMBPIOH MCNBGALBPCJ);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<GFONHMBPIOH> CDALLLDCLCC(BPFCEEPJHKL MAPIMEJAPGE);

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GFONHMBPIOH PDKABCMGILB(long OGMIFIGJENM, long MGNAIIKHEOI, HHJNAOPPEEO OCJDGCBLJNF, BPFCEEPJHKL MAPIMEJAPGE);
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
