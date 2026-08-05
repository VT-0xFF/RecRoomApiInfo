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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x8441240", Offset = "0x8440240", VA = "0x188441240")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x843DA60", Offset = "0x843CA60", VA = "0x18843DA60", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x8444850", Offset = "0x8443850", VA = "0x188444850", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642640", VA = "0x182643640")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DIOGHCGECGO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8431010", Offset = "0x8430010", VA = "0x188431010")]
	public DIOGHCGECGO(string NAAMEAFIHJI, Exception HBNIOKPNOCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class NCIGEBCLAAI : OCONDPENHFH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LHNOEOEDHAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<KADKLFOGONN>> <>t__builder;

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
		private TaskAwaiter<FDPGAAIPEKA<NEDLDDMDCHB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x843D3E0", Offset = "0x843C3E0", VA = "0x18843D3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x843D620", Offset = "0x843C620", VA = "0x18843D620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct AFCEJANNCDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<INDKPHCCHHI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<INDKPHCCHHI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8423DA0", Offset = "0x8422DA0", VA = "0x188423DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8423FB0", Offset = "0x8422FB0", VA = "0x188423FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	[UnityEngine.Scripting.Preserve]
	public NCIGEBCLAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8440BD0", Offset = "0x843FBD0", VA = "0x188440BD0", Slot = "4")]
	[AsyncStateMachine(typeof(LHNOEOEDHAJ))]
	public Task<IReadOnlyList<KADKLFOGONN>> MHNGHHEAMFB(long CINEDGEJAIA, long DPKCNMHAPEB, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8440AC0", Offset = "0x843FAC0", VA = "0x188440AC0", Slot = "5")]
	[AsyncStateMachine(typeof(AFCEJANNCDA))]
	public Task<IReadOnlyList<INDKPHCCHHI>> MBEPAODPLFJ(IReadOnlyList<int> NCFPKCADDII, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BBFLLAOCAPG : IEquatable<BBFLLAOCAPG>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int HAELNHIJFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	INDKPHCCHHI GCGOAHAFJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime DGHKNGACOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	KBKDLGNDCGI? CBBDJEMODNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	CDIGONBLHDF? NFNJIDCCAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	NAPCKPCCCNK GNHJGPDGGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<GGIHIJCCBHJ> NBJHHHCEOKH();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum NAPCKPCCCNK
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OCONDPENHFH
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<KADKLFOGONN>> MHNGHHEAMFB(long CINEDGEJAIA, long DPKCNMHAPEB, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<INDKPHCCHHI>> MBEPAODPLFJ(IReadOnlyList<int> NCFPKCADDII, [Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BJOAFJLEONA
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class GGEPDPCICGH : BBFLLAOCAPG, IEquatable<BBFLLAOCAPG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct JJGCIOEBMLL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<GGIHIJCCBHJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public GGEPDPCICGH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private GHEABDPEEMJ <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<GOMNLGPHFID> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<GGIHIJCCBHJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8439560", Offset = "0x8438560", VA = "0x188439560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8439AF0", Offset = "0x8438AF0", VA = "0x188439AF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly KADKLFOGONN OOKIAEEEMFG;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int HAELNHIJFMP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public INDKPHCCHHI GCGOAHAFJDL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime BAOFFOBPNHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8435340", Offset = "0x8434340", VA = "0x188435340", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KBKDLGNDCGI? CBBDJEMODNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6CCD4F0", Offset = "0x6CCC4F0", VA = "0x186CCD4F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public CDIGONBLHDF? NFNJIDCCAAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x29B9DD0", Offset = "0x29B8DD0", VA = "0x1829B9DD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NAPCKPCCCNK GNHJGPDGGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xBDE1B0", Offset = "0xBDD1B0", VA = "0x180BDE1B0", Slot = "10")]
			get
			{
				return default(NAPCKPCCCNK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8435240", Offset = "0x8434240", VA = "0x188435240", Slot = "9")]
		[AsyncStateMachine(typeof(JJGCIOEBMLL))]
		public Task<GGIHIJCCBHJ> NBJHHHCEOKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8435360", Offset = "0x8434360", VA = "0x188435360")]
		public GGEPDPCICGH(int NMFEHPGFFGN, INDKPHCCHHI IBFHFEBHGKB, KADKLFOGONN OOKIAEEEMFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8435050", Offset = "0x8434050", VA = "0x188435050", Slot = "11")]
		public bool Equals(BBFLLAOCAPG MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84350E0", Offset = "0x84340E0", VA = "0x1884350E0", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8435180", Offset = "0x8434180", VA = "0x188435180")]
		private bool GHMPBKAIJIL(GGEPDPCICGH MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84351C0", Offset = "0x84341C0", VA = "0x1884351C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class AMLDHCNDCPH : BBFLLAOCAPG, IEquatable<BBFLLAOCAPG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct PNJEHPDNALE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<GGIHIJCCBHJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public AMLDHCNDCPH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<GGIHIJCCBHJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8443280", Offset = "0x8442280", VA = "0x188443280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x84434D0", Offset = "0x84424D0", VA = "0x1884434D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly OPPGGNKKPPF EPJNAKFHFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly KBKDLGNDCGI BLDKMMJPLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CDIGONBLHDF EDGNNNADBNF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int HAELNHIJFMP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8424800", Offset = "0x8423800", VA = "0x188424800", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public INDKPHCCHHI GCGOAHAFJDL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8424AC0", Offset = "0x8423AC0", VA = "0x188424AC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime BAOFFOBPNHG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8424C40", Offset = "0x8423C40", VA = "0x188424C40", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public KBKDLGNDCGI? CBBDJEMODNN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x84247B0", Offset = "0x84237B0", VA = "0x1884247B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public CDIGONBLHDF? NFNJIDCCAAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x84249F0", Offset = "0x84239F0", VA = "0x1884249F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NAPCKPCCCNK GNHJGPDGGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xBCB9B0", Offset = "0xBCA9B0", VA = "0x180BCB9B0", Slot = "10")]
			get
			{
				return default(NAPCKPCCCNK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1E44B60", Offset = "0x1E43B60", VA = "0x181E44B60")]
		public AMLDHCNDCPH(OPPGGNKKPPF EBKHBJGGNOP, KBKDLGNDCGI ONFAIAACMCL, CDIGONBLHDF LOCHCLBNCPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8424B50", Offset = "0x8423B50", VA = "0x188424B50", Slot = "9")]
		[AsyncStateMachine(typeof(PNJEHPDNALE))]
		public Task<GGIHIJCCBHJ> NBJHHHCEOKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8424840", Offset = "0x8423840", VA = "0x188424840", Slot = "11")]
		public bool Equals(BBFLLAOCAPG MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84248E0", Offset = "0x84238E0", VA = "0x1884248E0", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8424990", Offset = "0x8423990", VA = "0x188424990")]
		private bool GHMPBKAIJIL(AMLDHCNDCPH MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8424A40", Offset = "0x8423A40", VA = "0x188424A40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class NGGMLLOBAIJ : BBFLLAOCAPG, IEquatable<BBFLLAOCAPG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct NAPNCAGKDDE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<GGIHIJCCBHJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<GGIHIJCCBHJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x84407F0", Offset = "0x843F7F0", VA = "0x1884407F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8440A50", Offset = "0x843FA50", VA = "0x188440A50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly INDKPHCCHHI MADGGIDEGMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly KBKDLGNDCGI BLDKMMJPLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly CDIGONBLHDF EDGNNNADBNF;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int HAELNHIJFMP
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8440D40", Offset = "0x843FD40", VA = "0x188440D40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public INDKPHCCHHI GCGOAHAFJDL
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime BAOFFOBPNHG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public KBKDLGNDCGI? CBBDJEMODNN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8440CF0", Offset = "0x843FCF0", VA = "0x188440CF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public CDIGONBLHDF? NFNJIDCCAAE
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8440F30", Offset = "0x843FF30", VA = "0x188440F30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NAPCKPCCCNK GNHJGPDGGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "10")]
			get
			{
				return default(NAPCKPCCCNK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1E44B60", Offset = "0x1E43B60", VA = "0x181E44B60")]
		public NGGMLLOBAIJ(INDKPHCCHHI IBFHFEBHGKB, KBKDLGNDCGI ONFAIAACMCL, CDIGONBLHDF LOCHCLBNCPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8441010", Offset = "0x8440010", VA = "0x188441010", Slot = "9")]
		[AsyncStateMachine(typeof(NAPNCAGKDDE))]
		public Task<GGIHIJCCBHJ> NBJHHHCEOKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8440DE0", Offset = "0x843FDE0", VA = "0x188440DE0", Slot = "11")]
		public bool Equals(BBFLLAOCAPG MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8440D60", Offset = "0x843FD60", VA = "0x188440D60", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8440F80", Offset = "0x843FF80", VA = "0x188440F80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8440E50", Offset = "0x843FE50", VA = "0x188440E50")]
		private bool GHMPBKAIJIL(NGGMLLOBAIJ MIJLJBIHDMP)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct IIMEHOFMAMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<BBFLLAOCAPG>> <>t__builder;

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
		public BJOAFJLEONA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<KADKLFOGONN> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<KADKLFOGONN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, INDKPHCCHHI account, KADKLFOGONN roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8437E30", Offset = "0x8436E30", VA = "0x188437E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8438C70", Offset = "0x8437C70", VA = "0x188438C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct ANILFEMIMOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, INDKPHCCHHI account, KADKLFOGONN roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<KADKLFOGONN> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public BJOAFJLEONA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<INDKPHCCHHI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8424C90", Offset = "0x8423C90", VA = "0x188424C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8425690", Offset = "0x8424690", VA = "0x188425690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly ILOOKKAOHHD KHPANELNEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly OCONDPENHFH OOHDMOBHNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly FKMGBBKKGNI OIHBHDKDLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly FAKLKHOBCAF<(long, long), IReadOnlyList<KADKLFOGONN>> HFGDPLPOACO;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x842CF70", Offset = "0x842BF70", VA = "0x18842CF70")]
	[UnityEngine.Scripting.Preserve]
	public BJOAFJLEONA([DJIFKCCBBND(null)] OCONDPENHFH ANIBOLAGJCJ, [DJIFKCCBBND(null)] FKMGBBKKGNI NJJJLNFAOPB, [DJIFKCCBBND(null)] ILOOKKAOHHD NCPPADEPCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x842CE20", Offset = "0x842BE20", VA = "0x18842CE20")]
	[AsyncStateMachine(typeof(IIMEHOFMAMI))]
	public Task<IList<BBFLLAOCAPG>> LCKPLKIOBNF(long CINEDGEJAIA, long NBOIIPJHEBJ, bool ICFDKPFLMNA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x842CC80", Offset = "0x842BC80", VA = "0x18842CC80")]
	private bool FOFDKIBBKAH(DateTime? EONHAIHKAGI, long CINEDGEJAIA, long NBOIIPJHEBJ, [Out] OPPGGNKKPPF HIIKALLGCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x842CB70", Offset = "0x842BB70", VA = "0x18842CB70")]
	[AsyncStateMachine(typeof(ANILFEMIMOF))]
	private Task<IReadOnlyList<(int, INDKPHCCHHI, KADKLFOGONN)>> ELIADBMDJJE(IReadOnlyList<KADKLFOGONN> HMPICDBLGHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FKMGBBKKGNI
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<OPPGGNKKPPF> KIFCAFINGFA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EFGFHMKDHML(long CINEDGEJAIA, long NBOIIPJHEBJ, HFEJJAMCGEP KMDNEDBDMKJ, KNEDGBILGPM EDHLLDFNCFM);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FHNCAFIPDJA(long CINEDGEJAIA, long NBOIIPJHEBJ, [Out] OPPGGNKKPPF HIIKALLGCLK);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EEPFFLLCOIA(long CINEDGEJAIA, long NBOIIPJHEBJ, KNEDGBILGPM EDHLLDFNCFM, [Out] OPPGGNKKPPF HIIKALLGCLK);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MOEMLOMEHPE(long CINEDGEJAIA, long NBOIIPJHEBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface GFAFJAJHEAL : BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool EDDJHOGAIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task CFCODDMDOHH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNDGLPBCLKM(Task BGKKDAHMDLM, string HFGDCJPDCBB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface KKJBEPHJCKB : BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GGIHIJCCBHJ> FEPBIOOICAE(OPPGGNKKPPF HIIKALLGCLK);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NIIEIIOKINC(CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface NEBLBKINJDB : BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	OBOJAHIICMM IBFIAENFGPE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BDLDJLKMDIN();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODOONGBGDAG();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface BGMLLKPPOFE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface DMIMJPCFHKL
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan JJHHGAIOEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan PFDHBIEGGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan DPAFCJHHPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan BOPODGNPHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool CKINHNABKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool COCPDMNPDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool EDBBDKDIBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int MCENBAIECMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool DJNPKBDGKHO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool NBAAGDBAKGI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool MCPDLKIHLPI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum ECEDGMJBOHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum KLMNOKPMPDB
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
public struct OGDCDNJBIFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long JABOCCMAHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long DPKCNMHAPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly ECEDGMJBOHJ MLCOGCMJLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception MNKOHFDBNDB;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84419F0", Offset = "0x84409F0", VA = "0x1884419F0")]
	public OGDCDNJBIFG(long JABOCCMAHMG, long DPKCNMHAPEB, ECEDGMJBOHJ MLCOGCMJLBB, [CanBeNull] Exception MNKOHFDBNDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x84419A0", Offset = "0x84409A0", VA = "0x1884419A0")]
	public static OGDCDNJBIFG ECGNHAOMACM(PAIKJEGABFG BFOJDNNGACG, ECEDGMJBOHJ MLCOGCMJLBB, [Optional] Exception MNKOHFDBNDB)
	{
		return default(OGDCDNJBIFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void FCLJLIMNHCD(OGDCDNJBIFG JJJFPCEDAAB);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface NOKLFIDFJEA : BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action BNNCIKDGMKG;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event FCLJLIMNHCD OGNNBGBILAG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event FCLJLIMNHCD LAOCICLHAPO;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event FCLJLIMNHCD MJPEGKHONEL;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<KLMNOKPMPDB, bool> NBGBDPMCBKA;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EOOIBDLJKFC();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ACANEKOKOPD(OGDCDNJBIFG JJJFPCEDAAB);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BLKDLGGILJJ(OGDCDNJBIFG JJJFPCEDAAB);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MALCLLIGEBD(OGDCDNJBIFG JJJFPCEDAAB);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ILCACIMPPHO(KLMNOKPMPDB MEOBMEDANDK, bool AMLDIAHNCEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface KJKKPMCIKID : BGMLLKPPOFE, IDisposable
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
	bool HDNJGFJKMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LBPGIDJNDGL(Reason DKBCGBFNIGO = Reason.Unknown);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GCECHLGMCDH();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface GIALCOICGEG : BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus CKMENNJIKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IFKKJMKFBGG(PAIKJEGABFG LEAIIPCAOIH, LLFJDDEPDIJ GKAEKPHDHIG, CancellationToken EBOFCHGLLPK);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class PAHAKPCOAHL
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8441D00", Offset = "0x8440D00", VA = "0x188441D00")]
	public static bool GGCLBOCINDO(this GIALCOICGEG GABNHHFPLMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task BEPKOPDMDEM(CancellationToken EJJDDFFADPC, int GMMLOKJHPEI, PFBDGKHFNEC PEEMGACEOLF);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface CGGJELIFDNE : BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OLHNAMHFFLG(BEPKOPDMDEM DNDLEHOKLFI);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface IPAGNGHLCCF : GHEABDPEEMJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken OONIJILGGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	AINJBKKEAIL NMEPAIFHADH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	LDMAAALPMPJ LCACEGJGIDO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	KFEINBBMNIF NFILJMHMJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	JHHKOFMOFFM PLBPABECHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	IPGGFFCDLNK BKPNOIHPIEI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	IAEPKIALGDD POBNBGLJGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	MBAMAOLNFEE DCPOKBLKBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	PLHOCFLCCME FLKHDEPCOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	GFAFJAJHEAL ILPIOGPEJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	KKJBEPHJCKB HEIABABBFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	NOKLFIDFJEA PGIADFHLCID
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	KJKKPMCIKID FEFFBEOGBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	GIALCOICGEG JDGJMKGIIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CGGJELIFDNE AGFIACKNDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	IFAIILFJKPF DCEJGBEFPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	JOECIDFCFKO EDNEEHBEMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	JFBCBONLOMK ANPKFBBOMJN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	NJGDDFJMLGB ODNMBCHBAOL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	FCNEEADCJIO LACKJDMKNON
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	FAJHEKNGMOI OPLCJBMPICL
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	ODFHIPDMKON LKBHDLALJNO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	KPFKDIBGGLC LLCLIMJNIOE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	OMMADJGGBCJ KBHDBHGBJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	DFOJGOILCNA GHNBGCCBLKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	NEBLBKINJDB JAOAPLBLLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	DMIMJPCFHKL FMEEPCKJBJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EJHLKPMLCLG CGGOCACINEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	FKMGBBKKGNI HLIBFBLOPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	LJPPDIILPEC HCDPIPPNGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	IBHJLAMHBCG BHOPEHCNCCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	JPJGDPIBNOF AGPHFLBPFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	OKGFEPLGNNN NDLBFOPIEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool EJINKNCGMJF
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
	void EDBBCKKPBPG(LLFJDDEPDIJ INIHDKAPFCM);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface IFAIILFJKPF : BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AFOHIMBEAIK IIGLPCDPOEE(Guid DHFBDLBBCGN);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GNAALOCCJEL(Guid DHFBDLBBCGN);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CPPOOKGKBAK(Guid DHFBDLBBCGN, Task MENJBHNCOEA);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OFJAPNCDIKM(Guid DHFBDLBBCGN, GGIHIJCCBHJ IKDKNJKMIAP);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(GGIHIJCCBHJ, Task)> EALCCNLLBGO(Guid DHFBDLBBCGN);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface GJKNOPEFJGC : BGMLLKPPOFE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface JOECIDFCFKO : BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFPIIOCCJEF(DAEAHJMMAED NAAMEAFIHJI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJPEECINCEE(DAEAHJMMAED NAAMEAFIHJI);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<MCEHODFGIME> GOGCFNHIFMD(CancellationToken JFEANKNHOEL);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface JFBCBONLOMK : BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AFOHIMBEAIK PIAHIINIEGI(DAEAHJMMAED PAFNHBFIGON);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHAIECBCJJA(Guid DHFBDLBBCGN, Task MENJBHNCOEA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface NJGDDFJMLGB : BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GGIHIJCCBHJ> ODNMBCHBAOL(DAEAHJMMAED CAGMDMPFBND);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface FCNEEADCJIO : BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AENKMJAJKCL> ABPAEOBCGGG(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, PAIKJEGABFG LEAIIPCAOIH, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface ODFHIPDMKON : BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GGIHIJCCBHJ KHANCPFOBAK(AIPAHMNCJKP FCDLIEFOPHH);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AHIIEDFIFFE(string IGFKNGAMFIG);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface FAJHEKNGMOI : BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DAEAHJMMAED> IFFNFJKHIBD(DAEAHJMMAED HOOJNAMGGBC, HPBALDPEPLO HKMAGJLMBHL, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<DAEAHJMMAED> LMAIGOFMOJO(CancellationToken CBJPDIFOEKF, HPBALDPEPLO HKMAGJLMBHL);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GEHMKHHFLAO GIMLJHNDHNK(PPPBMGNNDNF IDGCKCFDFPA, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GEHMKHHFLAO GGMGBIFDEGF(PPPBMGNNDNF IDGCKCFDFPA, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface KPFKDIBGGLC : BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GGIHIJCCBHJ AECOKMGPPFN(AIPAHMNCJKP FCDLIEFOPHH, MCEHODFGIME IKONCMMACKE);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GGIHIJCCBHJ BLCKACIGLDJ(AIPAHMNCJKP HIHGMFDAMLE);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface PBCBIJGDOEH
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	const int HNHBALHEHLM = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, PMOKDFKEMBA> BJJGAMKNDKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action MGPNPOPAKPL
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
	IReadOnlyList<Guid> AENKNLAEOGA();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task ALIPILELFHP([Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task BDEGMJFOIBJ([Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface OMMADJGGBCJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HIHINJPGALM(NHNOGEFNFMP LOPMMOIJKMI);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHBHKIPMDEC(NHNOGEFNFMP LOPMMOIJKMI);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDCOAOFFFHK(NHNOGEFNFMP LOPMMOIJKMI);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FOKDODIPINF(NHNOGEFNFMP LOPMMOIJKMI);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class NHNOGEFNFMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly PAIKJEGABFG PJMFJDGAONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Dictionary<string, string> CIAELOLMGJJ;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public LDCGKGNFMMI<string> DPJPGOLCBFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public NHNOGEFNFMP(PAIKJEGABFG HJHEMAOEAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8441170", Offset = "0x8440170", VA = "0x188441170")]
	public NHNOGEFNFMP MLNPJAKMBHI(string OEHHKNIGGMI, string OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x84410E0", Offset = "0x84400E0", VA = "0x1884410E0")]
	public bool GNNLCBKBEPD([Out] IEnumerable<KeyValuePair<string, string>> HOIDLFKAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x72FFDB0", Offset = "0x72FEDB0", VA = "0x1872FFDB0")]
	public NHNOGEFNFMP PNFGKIODLPP(LDCGKGNFMMI<string> DCCJGOAMNIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface EJHLKPMLCLG
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool JLEMJHEBMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string MMAPHJBEAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool BMHEKEMLKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EHMAFGJANPL();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EMCAKAJMIMO LDJGFOJBLIK(long CFBANPJJEAK);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CEFIABFPECO<NGHKAOKDFBL, HNAGJAILJOF> GAGEIJEJEJG(long CFBANPJJEAK);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CEFIABFPECO<NGHKAOKDFBL, BPLHNECCAPN> ACIEPGJFLPE(long CFBANPJJEAK);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CEFIABFPECO<long, COGPNGPCNGP> IGGJFEBAGNL();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<JJDFEBIHCFN>> HNBDCAJLPML(long CFBANPJJEAK, IReadOnlyCollection<JJDFEBIHCFN> NEEBANOOBOC, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DFLKAKNJEAJ(long CFBANPJJEAK, [Out] bool ALIGABMLCIF);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> NFJDMOFLEKJ(byte[] OFMJDNINMGK, byte[] EKHBMLBAPGI, IReadOnlyCollection<Guid> BBAMDEDEGNN, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface LAFKPKCKGAP
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AENKMJAJKCL FLLMCNLHKNL(long JABOCCMAHMG, long DPKCNMHAPEB, string JMBBDHDFKMN);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AENKMJAJKCL FLLMCNLHKNL(long JABOCCMAHMG, long DPKCNMHAPEB, NGHKAOKDFBL OFMJDNINMGK, Guid? GCDCGDIAIPJ, long HACNOLAIOHO, bool HCODGODMFLK);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AENKMJAJKCL FLLMCNLHKNL(GHABJHKCBDN PECGMNBMCKE);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AENKMJAJKCL FLLMCNLHKNL(GOMNLGPHFID CPEDNDIONCC, KADKLFOGONN FOLMFHKONEN);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface GHEABDPEEMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool GGCLBOCINDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool OAOIGHGJJCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool EJINKNCGMJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	LAFKPKCKGAP PICEKANBOAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	LLFJDDEPDIJ FKAJENDPOPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action BNNCIKDGMKG;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FCLJLIMNHCD OGNNBGBILAG;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event FCLJLIMNHCD LAOCICLHAPO;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event FCLJLIMNHCD MJPEGKHONEL;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<KLMNOKPMPDB, bool> NBGBDPMCBKA;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GCECHLGMCDH();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JKIIIKPEIIP HHFJNDFGHHJ();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AJBKMDJKJOF BNKOPMDAMEL();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task FHPKBDKEKGF(int BGINAMOOLIJ, MDNOEFMCADI LMHJJMIBAMA, Func<HFEJJAMCGEP, HFEJJAMCGEP> IEJMBGBDAGB);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<GGIHIJCCBHJ> FEPBIOOICAE(OPPGGNKKPPF EBKHBJGGNOP);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task NIIEIIOKINC(CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface IPGGFFCDLNK
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool JFMFLBJCIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool CNDILIILIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? IOJDAHCJGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFHJJGNDPGO(Scene FAAKBABMLML);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task APFHHDDFBNE(IMCNCDOFDAG FHGKAMMKLAM, IReadOnlyList<IMCNCDOFDAG> JIOPLJODAOJ, IReadOnlyList<IMCNCDOFDAG> OBIDMGEBDJG, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HIMLMDMHGGN(AJJJELHNNKL GAJOCMHPGFM);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task HLJKMGKCLKK(IReadOnlyList<Guid> CLDPCOGPOKE, CancellationToken EPDLFNHNOFC);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EKPOAKLBMCN CKELAJGMMCI();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task LJGIBJEIDPG();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CJEOBIJAHEJ(GameObject NHAAFJKFJLE);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task BPMNBLAFKMI();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface JHHKOFMOFFM
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	IJPJAKACFOB BJABPNAMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool CABHFLBKIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool LIGPEOODNDA
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool IEHKJMHJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool KIBKJMCFCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int KOIINNKEDDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool IKLDAEPDKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool MCGOMEDBBHF
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int MHBOBENJEOI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int JCAMKEIAMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool IECDEPKNLOI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool JKDBAKNNODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool PCBOJPHLMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float NHAIEGMBNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> BEOILCGICNJ;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AINJBKKEAIL IFDHENIGBML(AINJBKKEAIL LDALBILPAIG);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IFLJFABCKKB(AINJBKKEAIL NELIKBMJKPH);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GGPLAIJJDHE();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task ILKALNCEOLD(LDCGKGNFMMI<string>.CKHHEKIPJDF EBNHGKICMHD, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KCDCHBJKMLG(float NHDJKKLKHBP);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GEMEGFAHBNE(string EKPIAKIDDJI);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<LFLPPHCMPGO> PECAOOPBNND();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable LAJPBEEJBMP(object INLEBAAACKH, LFLPPHCMPGO DLNPOEEPFML);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<JMBLJGACIPD> GEDDDOHFNJJ();

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HNAGJAILJOF EGLBKMBGCLI(IEnumerable<DJNGLNAIHJJ> NCOPFNGDDLG);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OFPBNECBDFJ(int DAOAPLFBLDC);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task BABGCIIGCPH();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FHFBOEAMEKL();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool LNJFOGNFLAC();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task BOHCJDBKDJI(CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task MLNKDFJHEFH(CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<FOPHMFKIKPK> PCKDFOCJLKL(DateTime NODLEJKNEEL, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> ONMEJNOKPMN(CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OMKNJGACHHL(string NAAMEAFIHJI = "", float JHNMLGDIFJL = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "25")]
	BELCGLLEFHB OJIJCBAMDOM(MJJOEIPLFFL BICOFHMOEBP, FHEBLHGADNG DMBMNBBDHKN, BPLHNECCAPN ILAABPGJMFE, IEnumerable<PersistenceView> HKOHHLANDDM, HDGPNFAELAI FGPPEIIOCJJ);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PJMOIPCACKF(BPLHNECCAPN ILAABPGJMFE);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LDKFHFGHHII(DJNGLNAIHJJ BJPIFCHFNAA, [In] BELCGLLEFHB GCGBHFPEKCE);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task KOJNCBBGPHG(BPLHNECCAPN DELDEHHAKDM, bool NPHJGNGAOEN, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task JEDKFLENHCJ(CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GJNHEAPADIN(long CINEDGEJAIA, long DPKCNMHAPEB, GOMNLGPHFID KNDDJPGLJMO, KADKLFOGONN KFFKOPGOOKK, HFEJJAMCGEP KMDNEDBDMKJ, MDNOEFMCADI? LMHJJMIBAMA, GHIBGJOBNGE? HMEALLJEACK);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void HIMAAPNAIAF(long CINEDGEJAIA, long DPKCNMHAPEB, GHIBGJOBNGE? HMEALLJEACK);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void INPOLIOLJCA(PersistenceView INEPKEJEDFD);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void GJNEGIAIKON(string PGIMMLMOFBJ, PAIKJEGABFG HJHEMAOEAHO, OHMKBLJJPPO EAALPKOHFDN, [Optional] string? HFKMFFFPOJJ, [Optional] string? DFOCJNOIDLE, [Optional] string? AGBNDLBAFHL);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool JMAIHJPKNEI(PersistenceView NNAEIGBDCOK);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool LDBJKPPOKLB(DJNGLNAIHJJ BJPIFCHFNAA, APPGMHGFBGI HLPIFOPEBCL, [Out] FLOHPLGLJLN PJCOAFFFNEM);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task JOOMGLJLOMD(CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void IJLNMILKDPC();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable KILBJHBHJMI();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void MGOLPOIBHPM(BPLHNECCAPN DELDEHHAKDM, APPGMHGFBGI HLPIFOPEBCL);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> APKJFIEPONM(LDMAAALPMPJ NODDAHEDIAD, CancellationToken CBJPDIFOEKF, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void NGEGAAMFJKJ(CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<GHABJHKCBDN> LGMFFLFDDCN(CGFIPPAOILI HOOJNAMGGBC);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<GOMNLGPHFID> JCICHCBGHNL(long CINEDGEJAIA, bool FHPBHBIMBFH, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<NEDLDDMDCHB> OLKCGJPFLMK(long CINEDGEJAIA, long DPKCNMHAPEB, long HACNOLAIOHO, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<NEDLDDMDCHB> BHFBJFGDHLP(long CINEDGEJAIA, long DPKCNMHAPEB, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<DIKDBMHBMCM> LIPEKODEPCL(long CINEDGEJAIA, Guid LKBGKPDOLCB, long? NBOIIPJHEBJ, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "47")]
	CEFIABFPECO<DIKDBMHBMCM, IEnumerable<MCIJFDPPJOL>> EJCMJPNGKNB();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<NOEKMJCDIOB> BHLCMLDNCOL(string JMBBDHDFKMN, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<NOEKMJCDIOB> MLENLGJEOCC(string JMBBDHDFKMN, long CINEDGEJAIA, long DPKCNMHAPEB, Guid? DMDDOFCAJJF, KAKCKKIHOCK.ADGAEKFCFIH MKIDPONBDDE, KAKCKKIHOCK.ADGAEKFCFIH EKHBMLBAPGI, int BGINAMOOLIJ);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool GLFFPNAPCKI();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool BHAJGBCGDGJ();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool EKNHAILIFIL(IEnumerable<FLOHPLGLJLN> DPJAHMIJCGC);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void KPGHFDFPOBC(List<GameObject> CHKCCDDAHMP);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float BCAJFKOHIAP();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> BNGCDDIBFJF(CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> MDAGPEBKPOI(string NHHGKEDIJJG, LoadSceneMode KGOKOCNMGEO, bool BEGAHOKPHIA, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void IGPNICKEGEB();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void AHFMHDDHHEN(bool BFEIIPBAHBE);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void DDGEAFABPCA();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void EAOGNGGGLAD();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void EACOHKOPPHB(bool BAINPBMAOAK);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task<KAKCKKIHOCK.ADGAEKFCFIH> JBJIPKNGCAF(byte[] APDBNIMCPID, KAKCKKIHOCK.EOOJEMCGDEM ICFDKJLBKNO, ICPFJALFLHF CIIGMEACAMO, [Optional] IReadOnlyCollection<string>? BAOIAHDLBFK, [Optional] string? KMOBBJGIONK);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void NBJNNMGOBDM(PAIKJEGABFG ELCMKIJIHIO);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task PLPGBABOJJN(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task CKFDIFKOFOH(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task JDLIPDPKKIE(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "77")]
	Task NBNBHOLHLDJ(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "78")]
	IDisposable PGIJEJKOJJN();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "79")]
	CEFMCOIEMHB OIJGKAJOFOH();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "80")]
	Task POJCKHNKDHH(CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface CEFMCOIEMHB
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NCNNGMHBDCC(CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KIFENBCNAPI(CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct BELCGLLEFHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public HashSet<int> LAPONEEJKBA;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum FOPHMFKIKPK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct MJJOEIPLFFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Guid? KJPMNOCOJND;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface IJPJAKACFOB
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	PAIKJEGABFG IJOCJPJPEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	GOMNLGPHFID FJHCOGJEAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	IINCMBDAHBF COKBGIAGJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool KBKEBAJKDHG
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool IMHFAOBCIMF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int EHCOECBJJLI
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action JINOHBBNMLK;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> MKCODIBLJIE;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JKFAPOLAOOP();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.MIODFHAAAOG> DNLMGFAFCCB(long CFBANPJJEAK, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<GKEIPOPCDPO> ELNAEINCNAI(PAIKJEGABFG HJHEMAOEAHO, [Optional] LLFJDDEPDIJ GKAEKPHDHIG);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<GKEIPOPCDPO> KBKMMJBMEAP();

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task JACLFINHHDF();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(PAIKJEGABFG, LLFJDDEPDIJ) MOJFBDINJMB();

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IKJOECKPNBM OHKNFMLJLIE();

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DNOEEFHHMHF(long CFBANPJJEAK);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PDOFDDIKKJL(PAIKJEGABFG HJHEMAOEAHO, Matchmaking.LCLHJLDMAHM OBOOAPELMPF, (int Major, int? Minor)? LELALGHIBFL);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface DFOJGOILCNA
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MOFFCHCFJNC([Out] IEnumerable<int> OBEHOCOHHPL);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMHLNNHKMMJ(BDMLCHKFOFH EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EADEOEEFDGL(BDMLCHKFOFH EJJDDFFADPC);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface CGNIKLKBLMA
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JPIIINEPJHG(GGIHIJCCBHJ MNJLOAEFEJN);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface PKEELNCJLNM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFGGHIPHBFC(JFLKEALDLHG.MNMAAAIFNNE EDPLIBFIBNG);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKFKAFOHICN(JFLKEALDLHG.MNMAAAIFNNE EDPLIBFIBNG);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface IAEPKIALGDD : PKEELNCJLNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GGIHIJCCBHJ CAAEDFHFHDD(AIPAHMNCJKP HIHGMFDAMLE);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface MBAMAOLNFEE : PKEELNCJLNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GGIHIJCCBHJ KHANCPFOBAK(AIPAHMNCJKP MCADOGGHICO);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface EMCAKAJMIMO
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HHHCCNLMPJL<HFIBBAIEKFD, OGMCLKGLBPG>> EBHEECIOCJB(Guid? DMDDOFCAJJF, IReadOnlyCollection<JJDFEBIHCFN> FPOFAECKECE, IReadOnlyCollection<JJDFEBIHCFN> LLJNIILIBCB, OKCCHEBOMGF FGCLIMPLEAL, long? CINEDGEJAIA, long? DPKCNMHAPEB, LKLEKOGDEBE.OBNDLGOKJBI BHELEDFDDCN, CancellationToken CBJPDIFOEKF, bool MMPIOKNLHNC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class HFIBBAIEKFD
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public IMCNCDOFDAG HNKILIOJPPK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<IMCNCDOFDAG> OMKNMOCJCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<IMCNCDOFDAG> DKNNPEDDIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xC47F60", Offset = "0xC46F60", VA = "0x180C47F60")]
	public HFIBBAIEKFD(IMCNCDOFDAG ODHDJAAHLJD, IReadOnlyList<IMCNCDOFDAG> MHEJGLEOCEB, IReadOnlyList<IMCNCDOFDAG> EIBACFONJOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface CEFIABFPECO<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HHHCCNLMPJL<PFOMDLOAMOL<TData>, OGMCLKGLBPG>> CMBCHACEDFL(TGetDataArg GIOLPIPFPPJ, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class LGPBHLKEPPJ : IPAGNGHLCCF, GHEABDPEEMJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct HHFNANNNEIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<GGIHIJCCBHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public LGPBHLKEPPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public OPPGGNKKPPF autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<GGIHIJCCBHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8436DF0", Offset = "0x8435DF0", VA = "0x188436DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8437070", Offset = "0x8436070", VA = "0x188437070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct GKEPNKIDNLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public LGPBHLKEPPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x84356F0", Offset = "0x84346F0", VA = "0x1884356F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8435920", Offset = "0x8434920", VA = "0x188435920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class DLGEAEKAKAM : IEnumerable<BGMLLKPPOFE>, IEnumerable, IEnumerator<BGMLLKPPOFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private BGMLLKPPOFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public LGPBHLKEPPJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private BGMLLKPPOFE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xE8B5B0", Offset = "0xE8A5B0", VA = "0x180E8B5B0")]
		[DebuggerHidden]
		public DLGEAEKAKAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8431080", Offset = "0x8430080", VA = "0x188431080", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x84314E0", Offset = "0x84304E0", VA = "0x1884314E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8431430", Offset = "0x8430430", VA = "0x188431430", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BGMLLKPPOFE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8431430", Offset = "0x8430430", VA = "0x188431430", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CancellationTokenSource DIHBKGPCGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly AINJBKKEAIL NELIKBMJKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool DPFEMHMCJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private KGOFFFJEMCM EFPGDJLDFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool FLPBMHLPMFC;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public LDMAAALPMPJ LCACEGJGIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9F46E0", Offset = "0x9F36E0", VA = "0x1809F46E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public KFEINBBMNIF NFILJMHMJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9F4710", Offset = "0x9F3710", VA = "0x1809F4710", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9F46D0", Offset = "0x9F36D0", VA = "0x1809F46D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public JHHKOFMOFFM PLBPABECHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9F46F0", Offset = "0x9F36F0", VA = "0x1809F46F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9F46C0", Offset = "0x9F36C0", VA = "0x1809F46C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public IPGGFFCDLNK BKPNOIHPIEI
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CF0", Offset = "0x9F3CF0", VA = "0x1809F4CF0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CD0", Offset = "0x9F3CD0", VA = "0x1809F4CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public IAEPKIALGDD POBNBGLJGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CE0", Offset = "0x9F3CE0", VA = "0x1809F4CE0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CC0", Offset = "0x9F3CC0", VA = "0x1809F4CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public MBAMAOLNFEE DCPOKBLKBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9180", Offset = "0x9F8180", VA = "0x1809F9180", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9080", Offset = "0x9F8080", VA = "0x1809F9080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public LAFKPKCKGAP PICEKANBOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9F90F0", Offset = "0x9F80F0", VA = "0x1809F90F0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9F9010", Offset = "0x9F8010", VA = "0x1809F9010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public PLHOCFLCCME FLKHDEPCOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9F9100", Offset = "0x9F8100", VA = "0x1809F9100", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9F8FF0", Offset = "0x9F7FF0", VA = "0x1809F8FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public GFAFJAJHEAL ILPIOGPEJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xBDE270", Offset = "0xBDD270", VA = "0x180BDE270", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x12CD960", Offset = "0x12CC960", VA = "0x1812CD960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public KKJBEPHJCKB HEIABABBFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9F9040", Offset = "0x9F8040", VA = "0x1809F9040", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9F9050", Offset = "0x9F8050", VA = "0x1809F9050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public NOKLFIDFJEA PGIADFHLCID
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xCC02E0", Offset = "0xCBF2E0", VA = "0x180CC02E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xE32260", Offset = "0xE31260", VA = "0x180E32260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public KJKKPMCIKID FEFFBEOGBKC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9FC4A0", Offset = "0x9FB4A0", VA = "0x1809FC4A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9FC4C0", Offset = "0x9FB4C0", VA = "0x1809FC4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public GIALCOICGEG JDGJMKGIIGP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xC0CEE0", Offset = "0xC0BEE0", VA = "0x180C0CEE0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xE430C0", Offset = "0xE420C0", VA = "0x180E430C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public CGGJELIFDNE AGFIACKNDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xD36B70", Offset = "0xD35B70", VA = "0x180D36B70", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xD36B80", Offset = "0xD35B80", VA = "0x180D36B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IFAIILFJKPF DCEJGBEFPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xCC0110", Offset = "0xCBF110", VA = "0x180CC0110", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x1148380", Offset = "0x1147380", VA = "0x181148380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public GJKNOPEFJGC LPKPPLPFMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xCAABF0", Offset = "0xCA9BF0", VA = "0x180CAABF0", Slot = "62")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xD66840", Offset = "0xD65840", VA = "0x180D66840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public JOECIDFCFKO EDNEEHBEMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA869A0", VA = "0x180A879A0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA894A0", Offset = "0xA884A0", VA = "0x180A894A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public JFBCBONLOMK ANPKFBBOMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9FC4B0", Offset = "0x9FB4B0", VA = "0x1809FC4B0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x9FC480", Offset = "0x9FB480", VA = "0x1809FC480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public NJGDDFJMLGB ODNMBCHBAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAB0EA0", Offset = "0xAAFEA0", VA = "0x180AB0EA0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xB75B90", Offset = "0xB74B90", VA = "0x180B75B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public FCNEEADCJIO LACKJDMKNON
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D7A0", Offset = "0xA8C7A0", VA = "0x180A8D7A0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA8C850", Offset = "0xA8B850", VA = "0x180A8C850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public FAJHEKNGMOI OPLCJBMPICL
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA87B50", Offset = "0xA86B50", VA = "0x180A87B50", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA90EE0", Offset = "0xA8FEE0", VA = "0x180A90EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public ODFHIPDMKON LKBHDLALJNO
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA87B80", Offset = "0xA86B80", VA = "0x180A87B80", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA86F60", Offset = "0xA85F60", VA = "0x180A86F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public KPFKDIBGGLC LLCLIMJNIOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xAB1870", Offset = "0xAB0870", VA = "0x180AB1870", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xB7EDE0", Offset = "0xB7DDE0", VA = "0x180B7EDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public OMMADJGGBCJ KBHDBHGBJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xAB1830", Offset = "0xAB0830", VA = "0x180AB1830", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xAA4C40", Offset = "0xAA3C40", VA = "0x180AA4C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public DFOJGOILCNA GHNBGCCBLKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xAB1850", Offset = "0xAB0850", VA = "0x180AB1850", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA951B0", Offset = "0xA941B0", VA = "0x180A951B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public NEBLBKINJDB JAOAPLBLLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xAB1840", Offset = "0xAB0840", VA = "0x180AB1840", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA9C4D0", Offset = "0xA9B4D0", VA = "0x180A9C4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public DMIMJPCFHKL FMEEPCKJBJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA9F5D0", Offset = "0xA9E5D0", VA = "0x180A9F5D0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xAA13E0", Offset = "0xAA03E0", VA = "0x180AA13E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public EJHLKPMLCLG CGGOCACINEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xAB0750", Offset = "0xAAF750", VA = "0x180AB0750", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xABA740", Offset = "0xAB9740", VA = "0x180ABA740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public FKMGBBKKGNI HLIBFBLOPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA965E0", Offset = "0xA955E0", VA = "0x180A965E0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public LJPPDIILPEC HCDPIPPNGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA9E950", Offset = "0xA9D950", VA = "0x180A9E950", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public IBHJLAMHBCG BHOPEHCNCCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA9F930", Offset = "0xA9E930", VA = "0x180A9F930", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public JPJGDPIBNOF AGPHFLBPFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA0EB0", Offset = "0xA9FEB0", VA = "0x180AA0EB0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public OKGFEPLGNNN NDLBFOPIEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xAB04C0", Offset = "0xAAF4C0", VA = "0x180AB04C0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public LLFJDDEPDIJ FKAJENDPOPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA9A820", Offset = "0xA99820", VA = "0x180A9A820", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xF696A0", Offset = "0xF686A0", VA = "0x180F696A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool DGLBODPEDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x843CA00", Offset = "0x843BA00", VA = "0x18843CA00", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool CEEANGGHCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x843CAC0", Offset = "0x843BAC0", VA = "0x18843CAC0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool BMPNHBMAJAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1BEFD50", Offset = "0x1BEED50", VA = "0x181BEFD50", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken NBCFHNMMNFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x843C040", Offset = "0x843B040", VA = "0x18843C040", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private AINJBKKEAIL ABPMIGNEHFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool CMIEFBPGPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1BEFD50", Offset = "0x1BEED50", VA = "0x181BEFD50", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1BE96D0", Offset = "0x1BE86D0", VA = "0x181BE96D0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action JGFDACLAKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x843CA60", Offset = "0x843BA60", VA = "0x18843CA60", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x843C8E0", Offset = "0x843B8E0", VA = "0x18843C8E0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event FCLJLIMNHCD BMLINDGFCOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x843C310", Offset = "0x843B310", VA = "0x18843C310", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x843CEB0", Offset = "0x843BEB0", VA = "0x18843CEB0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event FCLJLIMNHCD FHMLFDKJPKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x843BFE0", Offset = "0x843AFE0", VA = "0x18843BFE0", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x843C9A0", Offset = "0x843B9A0", VA = "0x18843C9A0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event FCLJLIMNHCD KNLFFLJLOJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x843C060", Offset = "0x843B060", VA = "0x18843C060", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x843C880", Offset = "0x843B880", VA = "0x18843C880", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<KLMNOKPMPDB, bool> GADAANFBCEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x843C510", Offset = "0x843B510", VA = "0x18843C510", Slot = "48")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x843C940", Offset = "0x843B940", VA = "0x18843C940", Slot = "49")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0xF696A0", Offset = "0xF686A0", VA = "0x180F696A0", Slot = "39")]
	public void EDBBCKKPBPG(LLFJDDEPDIJ INIHDKAPFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x843CF10", Offset = "0x843BF10", VA = "0x18843CF10")]
	[UnityEngine.Scripting.Preserve]
	internal LGPBHLKEPPJ([DJIFKCCBBND(null)] AINJBKKEAIL NELIKBMJKPH, [DJIFKCCBBND(null)] LDMAAALPMPJ NODDAHEDIAD, [DJIFKCCBBND(null)] KFEINBBMNIF PBJBHBOBLLF, [DJIFKCCBBND(null)] JHHKOFMOFFM DHJEDIPMPLO, [DJIFKCCBBND(null)] IPGGFFCDLNK ALJPBJKIMMK, [DJIFKCCBBND(null)] IAEPKIALGDD LEAFBFEDNOC, [DJIFKCCBBND(null)] MBAMAOLNFEE MHAEOAHGKDE, [DJIFKCCBBND(null)] PLHOCFLCCME AANEBFKDCIJ, [DJIFKCCBBND(null)] GFAFJAJHEAL OHEPFLBIHHH, [DJIFKCCBBND(null)] KKJBEPHJCKB OELFAECNHPL, [DJIFKCCBBND(null)] NOKLFIDFJEA EIHAJEPOKNO, [DJIFKCCBBND(null)] KJKKPMCIKID INIKKNPPFKN, [DJIFKCCBBND(null)] GIALCOICGEG GABNHHFPLMP, [DJIFKCCBBND(null)] CGGJELIFDNE BEGEKIBIHIK, [DJIFKCCBBND(null)] IFAIILFJKPF JIHHPLOGLBJ, [DJIFKCCBBND(null)] GJKNOPEFJGC ACBECDIMFKP, [DJIFKCCBBND(null)] JOECIDFCFKO PGIDKOLIOLP, [DJIFKCCBBND(null)] JFBCBONLOMK DICJDHBCDLH, [DJIFKCCBBND(null)] NJGDDFJMLGB CDJMGELKIDP, [DJIFKCCBBND(null)] FCNEEADCJIO DILAOJNHENM, [DJIFKCCBBND(null)] ODFHIPDMKON HFHKNFCAINL, [DJIFKCCBBND(null)] FAJHEKNGMOI OBECGFDEJPK, [DJIFKCCBBND(null)] KPFKDIBGGLC FAPAMCLMPLP, [DJIFKCCBBND(null)] OMMADJGGBCJ NPAIDAEMCCD, [DJIFKCCBBND(null)] DFOJGOILCNA HKHJFPPOMOL, [DJIFKCCBBND(null)] DMIMJPCFHKL NFFGNPJGBOO, [DJIFKCCBBND(null)] EJHLKPMLCLG BCNCMPIIBEG, [DJIFKCCBBND(null)] FKMGBBKKGNI DPJPCPHENPG, [DJIFKCCBBND(null)] LJPPDIILPEC LLLDBKONJJM, [DJIFKCCBBND(null)] IBHJLAMHBCG IMMBIKKFMEN, [DJIFKCCBBND(null)] JPJGDPIBNOF EMPPLKPGDFD, [DJIFKCCBBND(null)] OKGFEPLGNNN MEBFMFIEGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x843C0C0", Offset = "0x843B0C0", VA = "0x18843C0C0")]
	private void ANJKPBDKBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x843C370", Offset = "0x843B370", VA = "0x18843C370", Slot = "61")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x843BF90", Offset = "0x843AF90", VA = "0x18843BF90", Slot = "53")]
	private void AJBIHENENAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x843C280", Offset = "0x843B280", VA = "0x18843C280", Slot = "54")]
	private JKIIIKPEIIP CKDNNDNADJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x843CBA0", Offset = "0x843BBA0", VA = "0x18843CBA0", Slot = "55")]
	private AJBKMDJKJOF KDBINMAOEJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x843C570", Offset = "0x843B570", VA = "0x18843C570", Slot = "57")]
	public Task FHPKBDKEKGF(int BGINAMOOLIJ, MDNOEFMCADI LMHJJMIBAMA, Func<HFEJJAMCGEP, HFEJJAMCGEP> IEJMBGBDAGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x843C170", Offset = "0x843B170", VA = "0x18843C170")]
	private MANPACGGAHA BPBDKNEOPJB(int BGINAMOOLIJ, MDNOEFMCADI LMHJJMIBAMA, Func<HFEJJAMCGEP, HFEJJAMCGEP> IEJMBGBDAGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x843CCB0", Offset = "0x843BCB0", VA = "0x18843CCB0", Slot = "58")]
	[AsyncStateMachine(typeof(HHFNANNNEIC))]
	private Task<GGIHIJCCBHJ> LKNJOHOFELB(OPPGGNKKPPF HIIKALLGCLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x843CDC0", Offset = "0x843BDC0", VA = "0x18843CDC0", Slot = "59")]
	[AsyncStateMachine(typeof(GKEPNKIDNLM))]
	private Task NFNBDKMJDHG(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x843CC30", Offset = "0x843BC30", VA = "0x18843CC30")]
	[IteratorStateMachine(typeof(DLGEAEKAKAM))]
	private IEnumerable<BGMLLKPPOFE> KMMGNKNMKMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x843CB40", Offset = "0x843BB40", VA = "0x18843CB40")]
	[CompilerGenerated]
	private void JEEHEPMNKHA(BGMLLKPPOFE HABFEKNHDFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class PKLNPICDKGO : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x17B3000", Offset = "0x17B2000", VA = "0x1817B3000")]
	public PKLNPICDKGO(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class FBOLDFAEFFN : FLIMEIMMDEM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct KHLPMOHPOHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<FLIMEIMMDEM.ONMMOAHPBBH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public HashSet<KJKKPMCIKID.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public FBOLDFAEFFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x843B1B0", Offset = "0x843A1B0", VA = "0x18843B1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x843B4C0", Offset = "0x843A4C0", VA = "0x18843B4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly JHHKOFMOFFM DHJEDIPMPLO;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string OJKJJCDCMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8433120", Offset = "0x8432120", VA = "0x188433120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x9FE5E0", Offset = "0x9FD5E0", VA = "0x1809FE5E0")]
	public FBOLDFAEFFN(IPAGNGHLCCF BFCIGLOEMAP, JHHKOFMOFFM DHJEDIPMPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8433150", Offset = "0x8432150", VA = "0x188433150", Slot = "5")]
	[AsyncStateMachine(typeof(KHLPMOHPOHI))]
	public Task<FLIMEIMMDEM.ONMMOAHPBBH> OHICNCEPHDL(HashSet<KJKKPMCIKID.Reason> DFAIOEIAGIB, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class PKMKCAKFBGG : ICDGGHOJMPN, FLIMEIMMDEM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct HJABGFJIFLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<FLIMEIMMDEM.ONMMOAHPBBH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public PKMKCAKFBGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public HashSet<KJKKPMCIKID.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private PAIKJEGABFG <localRoomInstance>5__2;

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
		private TaskAwaiter<FLIMEIMMDEM.ONMMOAHPBBH> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x84370E0", Offset = "0x84360E0", VA = "0x1884370E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8437A40", Offset = "0x8436A40", VA = "0x188437A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string OJKJJCDCMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8443080", Offset = "0x8442080", VA = "0x188443080", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x9FE5E0", Offset = "0x9FD5E0", VA = "0x1809FE5E0")]
	public PKMKCAKFBGG(IPAGNGHLCCF BFCIGLOEMAP, JHHKOFMOFFM DHJEDIPMPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x84430B0", Offset = "0x84420B0", VA = "0x1884430B0", Slot = "5")]
	[AsyncStateMachine(typeof(HJABGFJIFLL))]
	public Task<FLIMEIMMDEM.ONMMOAHPBBH> OHICNCEPHDL(HashSet<KJKKPMCIKID.Reason> DFAIOEIAGIB, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class IGEMONMPKOO : ICDGGHOJMPN, FLIMEIMMDEM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct LGADJAPHPBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public AsyncTaskMethodBuilder<FLIMEIMMDEM.ONMMOAHPBBH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public IGEMONMPKOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public HashSet<KJKKPMCIKID.Reason> fallbackTriggersToIgnore;

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
		private TaskAwaiter<GKEIPOPCDPO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter<FLIMEIMMDEM.ONMMOAHPBBH> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x843B530", Offset = "0x843A530", VA = "0x18843B530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x843BF20", Offset = "0x843AF20", VA = "0x18843BF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string OJKJJCDCMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8437C30", Offset = "0x8436C30", VA = "0x188437C30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x9FE5E0", Offset = "0x9FD5E0", VA = "0x1809FE5E0")]
	public IGEMONMPKOO(IPAGNGHLCCF BFCIGLOEMAP, JHHKOFMOFFM DHJEDIPMPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x8437C60", Offset = "0x8436C60", VA = "0x188437C60", Slot = "5")]
	[AsyncStateMachine(typeof(LGADJAPHPBC))]
	public Task<FLIMEIMMDEM.ONMMOAHPBBH> OHICNCEPHDL(HashSet<KJKKPMCIKID.Reason> DFAIOEIAGIB, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class OLPFMNKMJHG : ICDGGHOJMPN, FLIMEIMMDEM
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class BGCPHGFAAFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public GKEIPOPCDPO matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public PAIKJEGABFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BGCPHGFAAFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8425B70", Offset = "0x8424B70", VA = "0x188425B70")]
		internal object NJDEFDIIFAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8425BF0", Offset = "0x8424BF0", VA = "0x188425BF0")]
		internal object POIKKBHJNMB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct GNLNMENFJMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public AsyncTaskMethodBuilder<FLIMEIMMDEM.ONMMOAHPBBH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public OLPFMNKMJHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public HashSet<KJKKPMCIKID.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private BGCPHGFAAFH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<GKEIPOPCDPO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter<FLIMEIMMDEM.ONMMOAHPBBH> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8435980", Offset = "0x8434980", VA = "0x188435980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x84365C0", Offset = "0x84355C0", VA = "0x1884365C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string OJKJJCDCMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8441A10", Offset = "0x8440A10", VA = "0x188441A10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x9FE5E0", Offset = "0x9FD5E0", VA = "0x1809FE5E0")]
	public OLPFMNKMJHG(IPAGNGHLCCF BFCIGLOEMAP, JHHKOFMOFFM DHJEDIPMPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8441A40", Offset = "0x8440A40", VA = "0x188441A40", Slot = "5")]
	[AsyncStateMachine(typeof(GNLNMENFJMB))]
	public Task<FLIMEIMMDEM.ONMMOAHPBBH> OHICNCEPHDL(HashSet<KJKKPMCIKID.Reason> DFAIOEIAGIB, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class ICDGGHOJMPN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct PGDPGGGPIOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public JBBHIJHGEPM log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public HashSet<KJKKPMCIKID.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public ICDGGHOJMPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<KJKKPMCIKID.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8442B00", Offset = "0x8441B00", VA = "0x188442B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8443020", Offset = "0x8442020", VA = "0x188443020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	protected readonly IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	protected readonly JHHKOFMOFFM DHJEDIPMPLO;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected IJPJAKACFOB BJABPNAMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8437AB0", Offset = "0x8436AB0", VA = "0x188437AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x9FE5E0", Offset = "0x9FD5E0", VA = "0x1809FE5E0")]
	public ICDGGHOJMPN(IPAGNGHLCCF BFCIGLOEMAP, JHHKOFMOFFM DHJEDIPMPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8437B00", Offset = "0x8436B00", VA = "0x188437B00")]
	[AsyncStateMachine(typeof(PGDPGGGPIOD))]
	protected Task JLHGBFJNDGE(JBBHIJHGEPM PAJIGEJCNAP, HashSet<KJKKPMCIKID.Reason> DFAIOEIAGIB, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class MKBPCNDJCJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct EFLIBJPEAGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder<FLIMEIMMDEM.ONMMOAHPBBH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public JHHKOFMOFFM callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8432D30", Offset = "0x8431D30", VA = "0x188432D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x84330B0", Offset = "0x84320B0", VA = "0x1884330B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class AHFONHGEHJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public IPAGNGHLCCF roomManager;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public AHFONHGEHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x84246B0", Offset = "0x84236B0", VA = "0x1884246B0")]
		internal object DJIINOLMKLA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly float OLINNIEFHIB;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	internal static readonly HashSet<KJKKPMCIKID.Reason> IIDEAAHHICK;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x843F090", Offset = "0x843E090", VA = "0x18843F090")]
	[AsyncStateMachine(typeof(EFLIBJPEAGN))]
	internal static Task<FLIMEIMMDEM.ONMMOAHPBBH> FAHLECLNJNK(JHHKOFMOFFM DHJEDIPMPLO, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x843F1A0", Offset = "0x843E1A0", VA = "0x18843F1A0")]
	internal static void NOONKHPJGFK(IPAGNGHLCCF BFCIGLOEMAP, JBBHIJHGEPM PAJIGEJCNAP, string PGIMMLMOFBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface FLIMEIMMDEM
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct ONMMOAHPBBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public bool AMLDIAHNCEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public KJKKPMCIKID.Reason DKBCGBFNIGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Enum? AGBNDLBAFHL;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8441C10", Offset = "0x8440C10", VA = "0x188441C10")]
		public static ONMMOAHPBBH JPLAKFPJJKE()
		{
			return default(ONMMOAHPBBH);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8441C20", Offset = "0x8440C20", VA = "0x188441C20")]
		public static ONMMOAHPBBH OCGBLALGDNP(KJKKPMCIKID.Reason DKBCGBFNIGO, [Optional] Enum? AGBNDLBAFHL)
		{
			return default(ONMMOAHPBBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string FIOLCLPHJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ONMMOAHPBBH> OHICNCEPHDL(HashSet<KJKKPMCIKID.Reason> DFAIOEIAGIB, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct GOMNLJCCGLI
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class FEFACOBOMLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public IPAGNGHLCCF manager;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public FEFACOBOMLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x84332E0", Offset = "0x84322E0", VA = "0x1884332E0")]
		internal Task GHKEGANAMKO(CancellationToken cancellationToken, int roomTotalVersion, PFBDGKHFNEC localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct MPAELOPDEKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public GOMNLJCCGLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private OPPGGNKKPPF <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter<FOPHMFKIKPK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter<GGIHIJCCBHJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x84401F0", Offset = "0x843F1F0", VA = "0x1884401F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8440780", Offset = "0x843F780", VA = "0x188440780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct BEHCPNFPNOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public GOMNLJCCGLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8425700", Offset = "0x8424700", VA = "0x188425700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8425A20", Offset = "0x8424A20", VA = "0x188425A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly CancellationToken CBJPDIFOEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly IPAGNGHLCCF PAKPDHLKNJE;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private LDMAAALPMPJ LCACEGJGIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8436860", Offset = "0x8435860", VA = "0x188436860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private JHHKOFMOFFM PLBPABECHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8436680", Offset = "0x8435680", VA = "0x188436680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private IJPJAKACFOB BJABPNAMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x84367E0", Offset = "0x84357E0", VA = "0x1884367E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private KKJBEPHJCKB HEIABABBFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8436630", Offset = "0x8435630", VA = "0x188436630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2797150", Offset = "0x2796150", VA = "0x182797150")]
	public GOMNLJCCGLI(CancellationToken CBJPDIFOEKF, IPAGNGHLCCF PAKPDHLKNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x84368B0", Offset = "0x84358B0", VA = "0x1884368B0")]
	public static BEPKOPDMDEM JOIFJLIJJGP(IPAGNGHLCCF PAKPDHLKNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x84366D0", Offset = "0x84356D0", VA = "0x1884366D0")]
	[AsyncStateMachine(typeof(MPAELOPDEKP))]
	public Task<bool> GDMALPFODEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x8436960", Offset = "0x8435960", VA = "0x188436960")]
	private bool KIFICIOPMDM([Out] OPPGGNKKPPF HIIKALLGCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x8436CA0", Offset = "0x8435CA0", VA = "0x188436CA0")]
	[AsyncStateMachine(typeof(BEHCPNFPNOG))]
	private Task NBPOGBLHNLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x8436B70", Offset = "0x8435B70", VA = "0x188436B70")]
	private Task<FOPHMFKIKPK> NBOOEJDGBNP(OPPGGNKKPPF FHOHFDFAODM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct AFOHIMBEAIK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly IFAIILFJKPF JIHHPLOGLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Guid DHFBDLBBCGN;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(GGIHIJCCBHJ, Task)> NENODKDFGBP
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8424020", Offset = "0x8423020", VA = "0x188424020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5099030", Offset = "0x5098030", VA = "0x185099030")]
	public AFOHIMBEAIK(IFAIILFJKPF JIHHPLOGLBJ, Guid DHFBDLBBCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x84241C0", Offset = "0x84231C0", VA = "0x1884241C0")]
	public TaskAwaiter<(GGIHIJCCBHJ, Task)> NCACCMDALIC()
	{
		return default(TaskAwaiter<(GGIHIJCCBHJ, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x84240F0", Offset = "0x84230F0", VA = "0x1884240F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct MMGJCCEFHKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly TaskCompletionSource<(GGIHIJCCBHJ, Task)> GCAKHKLHHEH;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(GGIHIJCCBHJ, Task)> NENODKDFGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x843FF00", Offset = "0x843EF00", VA = "0x18843FF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8440060", Offset = "0x843F060", VA = "0x188440060")]
	public MMGJCCEFHKA(TimeSpan PKGMHLEONHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x843FE10", Offset = "0x843EE10", VA = "0x18843FE10")]
	public void AHDBNACLDFJ(Task MENJBHNCOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x843FFD0", Offset = "0x843EFD0", VA = "0x18843FFD0")]
	public void MMDJOFGLDAH(GGIHIJCCBHJ MNJLOAEFEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x843FEB0", Offset = "0x843EEB0", VA = "0x18843FEB0")]
	public void DACKCPGEMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x843FF40", Offset = "0x843EF40", VA = "0x18843FF40")]
	internal void JGGPEGJECOH(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class GHDIGNGHBEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x84353C0", Offset = "0x84343C0", VA = "0x1884353C0")]
	public static AENKMJAJKCL IJOGBCECLMH(this AENKMJAJKCL DGHLABNPIEC, GOMNLGPHFID LNOKHBNGHMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8435560", Offset = "0x8434560", VA = "0x188435560")]
	public static AENKMJAJKCL MBLGFPMKLMG(this AENKMJAJKCL DGHLABNPIEC, KADKLFOGONN BKHDJJIMHNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class KGDFJCJHLNM : LAFKPKCKGAP
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class FKPLDIKKJEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public KADKLFOGONN subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public FKPLDIKKJEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8433330", Offset = "0x8432330", VA = "0x188433330")]
		internal bool EJPDHCDLONA(IINCMBDAHBF s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly DMIMJPCFHKL CPIJMIHEHHA;

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public KGDFJCJHLNM(DMIMJPCFHKL NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x843AB90", Offset = "0x8439B90", VA = "0x18843AB90", Slot = "4")]
	public AENKMJAJKCL FLLMCNLHKNL(long JABOCCMAHMG, long DPKCNMHAPEB, string JMBBDHDFKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x843AA30", Offset = "0x8439A30", VA = "0x18843AA30", Slot = "5")]
	public AENKMJAJKCL FLLMCNLHKNL(long JABOCCMAHMG, long DPKCNMHAPEB, NGHKAOKDFBL OFMJDNINMGK, Guid? GCDCGDIAIPJ, long HACNOLAIOHO, bool HCODGODMFLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x843AC20", Offset = "0x8439C20", VA = "0x18843AC20", Slot = "6")]
	public AENKMJAJKCL FLLMCNLHKNL(GHABJHKCBDN PECGMNBMCKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x843AE20", Offset = "0x8439E20", VA = "0x18843AE20", Slot = "7")]
	public AENKMJAJKCL FLLMCNLHKNL(GOMNLGPHFID CPEDNDIONCC, KADKLFOGONN FOLMFHKONEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x843B100", Offset = "0x843A100", VA = "0x18843B100")]
	private Guid? HHNFGNDNIGH(GOMNLGPHFID AFAEDCLENCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class LMKEPPLLGLH : GFAFJAJHEAL, BGMLLKPPOFE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct BJLCLOCPLOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public LMKEPPLLGLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x842C470", Offset = "0x842B470", VA = "0x18842C470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x842CB10", Offset = "0x842BB10", VA = "0x18842CB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly BDMLCHKFOFH FNCENFKHFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private string BGPHPBMNMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Task FPBPLJMMNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool EDDJHOGAIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x843D7B0", Offset = "0x843C7B0", VA = "0x18843D7B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task CFCODDMDOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x843D940", Offset = "0x843C940", VA = "0x18843D940", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20", Slot = "7")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x843D7E0", Offset = "0x843C7E0", VA = "0x18843D7E0", Slot = "6")]
	public void HNDGLPBCLKM(Task BGKKDAHMDLM, string HFGDCJPDCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x843D690", Offset = "0x843C690", VA = "0x18843D690")]
	[AsyncStateMachine(typeof(BJLCLOCPLOM))]
	private Task FJIJOGBHPBL(Task JMCJINFHCPM, string HFGDCJPDCBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x843D9D0", Offset = "0x843C9D0", VA = "0x18843D9D0")]
	public LMKEPPLLGLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class AGHINABJNFK : NEBLBKINJDB, BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private bool EHAHLCFFNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private OBOJAHIICMM JNBELABFAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private LDMAAALPMPJ NODDAHEDIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private DMIMJPCFHKL NFFGNPJGBOO;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public OBOJAHIICMM IBFIAENFGPE
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8424640", Offset = "0x8423640", VA = "0x188424640", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x8424210", Offset = "0x8423210", VA = "0x188424210", Slot = "7")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x8424390", Offset = "0x8423390", VA = "0x188424390", Slot = "5")]
	public void BDLDJLKMDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x8424540", Offset = "0x8423540", VA = "0x188424540", Slot = "6")]
	public void ODOONGBGDAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x8424580", Offset = "0x8423580", VA = "0x188424580")]
	private Task IAPGKHCPGOE(GBMOIPIDAFL COFBNOFIHKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x8424540", Offset = "0x8423540", VA = "0x188424540", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public AGHINABJNFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class JEAOGHMNLMI : DMIMJPCFHKL
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class MAHNFCCFEOI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly JAHOCBPGMLL AJHJEIPEGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly string OEHHKNIGGMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly T JMMNJNFGHEP;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T FPGFCMMHMJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xC649F0", Offset = "0xC639F0", VA = "0x180C649F0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0xC648C0", Offset = "0xC638C0", VA = "0x180C648C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x53053D0", Offset = "0x53043D0", VA = "0x1853053D0")]
		public MAHNFCCFEOI(JAHOCBPGMLL AJHJEIPEGEF, string OEHHKNIGGMI, T JMMNJNFGHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x5304C70", Offset = "0x5303C70", VA = "0x185304C70")]
		private void COFNJJODOJC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly JAHOCBPGMLL AJHJEIPEGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly MAHNFCCFEOI<TimeSpan> JGGOAKLBLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly MAHNFCCFEOI<TimeSpan> MOACFPLFKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly MAHNFCCFEOI<TimeSpan> JPNBPEKBLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly MAHNFCCFEOI<TimeSpan> IFHLKJBKADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly MAHNFCCFEOI<bool> MNEJDHEGJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly MAHNFCCFEOI<bool> PNLCCLONIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly MAHNFCCFEOI<bool> DGKPMKAFOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly MAHNFCCFEOI<int> GKDACDDMDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly MAHNFCCFEOI<bool> BCMAIAKAGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly MAHNFCCFEOI<bool> ODDJIEKKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly MAHNFCCFEOI<FFEEJALAFLP> NDIJEKOEOAI;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan JJHHGAIOEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8439010", Offset = "0x8438010", VA = "0x188439010", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan PFDHBIEGGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8438EC0", Offset = "0x8437EC0", VA = "0x188438EC0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan DPAFCJHHPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8438F50", Offset = "0x8437F50", VA = "0x188438F50", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan BOPODGNPHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8439050", Offset = "0x8438050", VA = "0x188439050", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool CKINHNABKGK
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8438FD0", Offset = "0x8437FD0", VA = "0x188438FD0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool COCPDMNPDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8438E80", Offset = "0x8437E80", VA = "0x188438E80", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool EDBBDKDIBIE
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8438F90", Offset = "0x8437F90", VA = "0x188438F90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int MCENBAIECMD
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8438E40", Offset = "0x8437E40", VA = "0x188438E40", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool DJNPKBDGKHO
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8438DC0", Offset = "0x8437DC0", VA = "0x188438DC0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool NBAAGDBAKGI
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8438E00", Offset = "0x8437E00", VA = "0x188438E00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool MCPDLKIHLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8438F00", Offset = "0x8437F00", VA = "0x188438F00", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8439090", Offset = "0x8438090", VA = "0x188439090")]
	[UnityEngine.Scripting.Preserve]
	public JEAOGHMNLMI([DJIFKCCBBND(null)] JAHOCBPGMLL AJHJEIPEGEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class MBHDFODPBNB : NOKLFIDFJEA, BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class JDAJAJKBEIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public OGDCDNJBIFG roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public JDAJAJKBEIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8438CE0", Offset = "0x8437CE0", VA = "0x188438CE0")]
		internal object AAGHKCOFGLB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action BNNCIKDGMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x843E150", Offset = "0x843D150", VA = "0x18843E150", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x843E490", Offset = "0x843D490", VA = "0x18843E490", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event FCLJLIMNHCD OGNNBGBILAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x843DE40", Offset = "0x843CE40", VA = "0x18843DE40", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x843E0B0", Offset = "0x843D0B0", VA = "0x18843E0B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event FCLJLIMNHCD LAOCICLHAPO
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x843E530", Offset = "0x843D530", VA = "0x18843E530", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x843E3F0", Offset = "0x843D3F0", VA = "0x18843E3F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event FCLJLIMNHCD MJPEGKHONEL
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x843E620", Offset = "0x843D620", VA = "0x18843E620", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x843E7A0", Offset = "0x843D7A0", VA = "0x18843E7A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<KLMNOKPMPDB, bool> NBGBDPMCBKA
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x843E840", Offset = "0x843D840", VA = "0x18843E840", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x843E6C0", Offset = "0x843D6C0", VA = "0x18843E6C0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "19")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x843E1F0", Offset = "0x843D1F0", VA = "0x18843E1F0", Slot = "14")]
	public void EOOIBDLJKFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x843DDE0", Offset = "0x843CDE0", VA = "0x18843DDE0", Slot = "15")]
	public void ACANEKOKOPD(OGDCDNJBIFG JJJFPCEDAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x843DE10", Offset = "0x843CE10", VA = "0x18843DE10", Slot = "16")]
	public void BLKDLGGILJJ(OGDCDNJBIFG JJJFPCEDAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x843E770", Offset = "0x843D770", VA = "0x18843E770", Slot = "17")]
	public void MALCLLIGEBD(OGDCDNJBIFG JJJFPCEDAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x843E5D0", Offset = "0x843D5D0", VA = "0x18843E5D0", Slot = "18")]
	public void ILCACIMPPHO(KLMNOKPMPDB MEOBMEDANDK, bool AMLDIAHNCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x843DEE0", Offset = "0x843CEE0", VA = "0x18843DEE0")]
	private void CIBKKMOJDEC(FCLJLIMNHCD DLNPOEEPFML, OGDCDNJBIFG JJJFPCEDAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public MBHDFODPBNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[UnityEngine.Scripting.Preserve]
internal class KAANNBPKKDD : KJKKPMCIKID, BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class GEHDBBJHGOO : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct MJGPNPCHIPJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public GEHDBBJHGOO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public KJKKPMCIKID.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private JHEDBCMAENC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private FLIMEIMMDEM[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private TaskAwaiter<FLIMEIMMDEM.ONMMOAHPBBH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x843E8F0", Offset = "0x843D8F0", VA = "0x18843E8F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x843F030", Offset = "0x843E030", VA = "0x18843F030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private struct EDECDACINKM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public AsyncTaskMethodBuilder<FLIMEIMMDEM.ONMMOAHPBBH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public FLIMEIMMDEM fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public GEHDBBJHGOO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public KJKKPMCIKID.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private JHEDBCMAENC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private OFAKAEPLJIA <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private TaskAwaiter<FLIMEIMMDEM.ONMMOAHPBBH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x8432010", Offset = "0x8431010", VA = "0x188432010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x8432CC0", Offset = "0x8431CC0", VA = "0x188432CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class HAIEAPCCOBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public FLIMEIMMDEM fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public HAIEAPCCOBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8436D70", Offset = "0x8435D70", VA = "0x188436D70")]
			internal object AKFHFKKDEHN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Task BGKKDAHMDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationTokenSource HELAMEEKEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public OFAKAEPLJIA GHEMBIKFMJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public JHHKOFMOFFM DHJEDIPMPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public OHMKBLJJPPO EAALPKOHFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public PAIKJEGABFG HJHEMAOEAHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public FLIMEIMMDEM[] KGLIENNIIDN;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool MFDNMEOBGFE
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x8434010", Offset = "0x8433010", VA = "0x188434010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool HJAGJKGKFKI
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x8433D00", Offset = "0x8432D00", VA = "0x188433D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8434F30", Offset = "0x8433F30", VA = "0x188434F30")]
		public GEHDBBJHGOO(JHHKOFMOFFM DHJEDIPMPLO, OHMKBLJJPPO EAALPKOHFDN, PAIKJEGABFG HJHEMAOEAHO, FLIMEIMMDEM[] KGLIENNIIDN, CancellationToken CBJPDIFOEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8433510", Offset = "0x8432510", VA = "0x188433510", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x84334A0", Offset = "0x84324A0", VA = "0x1884334A0")]
		public void DJEOLHCHGLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8434030", Offset = "0x8433030", VA = "0x188434030")]
		public void KCHCMDBBGJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8434720", Offset = "0x8433720", VA = "0x188434720")]
		public void OFKIBLKIJKE(KJKKPMCIKID.Reason OIBKENCHEHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8434250", Offset = "0x8433250", VA = "0x188434250")]
		[AsyncStateMachine(typeof(MJGPNPCHIPJ))]
		public Task LELFBKGJJJJ(KJKKPMCIKID.Reason DKBCGBFNIGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8433360", Offset = "0x8432360", VA = "0x188433360")]
		[AsyncStateMachine(typeof(EDECDACINKM))]
		private Task<FLIMEIMMDEM.ONMMOAHPBBH> BDJMBLOCAPO(KJKKPMCIKID.Reason DKBCGBFNIGO, FLIMEIMMDEM GNDCLODOCOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8433D20", Offset = "0x8432D20", VA = "0x188433D20")]
		private void GGFNAGLPGPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x84341A0", Offset = "0x84331A0", VA = "0x1884341A0")]
		public bool KOPBIHBPJKI(KJKKPMCIKID.Reason LGNGGBIFDBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8434350", Offset = "0x8433350", VA = "0x188434350")]
		private void NBBFIAKJEGB(OFAKAEPLJIA IDAKFFICKHC, KJKKPMCIKID.Reason DKBCGBFNIGO = KJKKPMCIKID.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8433E40", Offset = "0x8432E40", VA = "0x188433E40")]
		private void GGFPFAFKPBI(OFAKAEPLJIA IDAKFFICKHC, FLIMEIMMDEM.ONMMOAHPBBH OBOOAPELMPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x84349F0", Offset = "0x84339F0", VA = "0x1884349F0")]
		private void PCIDLPKEMDF(OFAKAEPLJIA IDAKFFICKHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x84336B0", Offset = "0x84326B0", VA = "0x1884336B0")]
		private void EAKNACMKMHH(OFAKAEPLJIA IDAKFFICKHC, FLIMEIMMDEM.ONMMOAHPBBH OBOOAPELMPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8433B90", Offset = "0x8432B90", VA = "0x188433B90")]
		private void FCCIPPGOAIF(OFAKAEPLJIA IDAKFFICKHC, Exception APEPCFJIAMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8433A80", Offset = "0x8432A80", VA = "0x188433A80")]
		private void EODMBHEADHA(FLIMEIMMDEM GNDCLODOCOJ, KJKKPMCIKID.Reason DKBCGBFNIGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8434610", Offset = "0x8433610", VA = "0x188434610")]
		private void NLICAJKDNAM(FLIMEIMMDEM GNDCLODOCOJ, KJKKPMCIKID.Reason DKBCGBFNIGO, string AGBNDLBAFHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8434BA0", Offset = "0x8433BA0", VA = "0x188434BA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class OFAKAEPLJIA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Task<FLIMEIMMDEM.ONMMOAHPBBH> BGKKDAHMDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public CancellationTokenSource HELAMEEKEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public FLIMEIMMDEM GNDCLODOCOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public KJKKPMCIKID.Reason OIBKENCHEHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public HashSet<KJKKPMCIKID.Reason> DFAIOEIAGIB;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool MFDNMEOBGFE
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x8434010", Offset = "0x8433010", VA = "0x188434010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool HJAGJKGKFKI
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x8433D00", Offset = "0x8432D00", VA = "0x188433D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8441410", Offset = "0x8440410", VA = "0x188441410")]
		public void AKBKNLLCFBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8441580", Offset = "0x8440580", VA = "0x188441580", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x84415A0", Offset = "0x84405A0", VA = "0x1884415A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x8441910", Offset = "0x8440910", VA = "0x188441910")]
		public OFAKAEPLJIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class OCCEIIOALHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public KJKKPMCIKID.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public OCCEIIOALHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x84412C0", Offset = "0x84402C0", VA = "0x1884412C0")]
		internal object DOMGBKMNBBK(OFAKAEPLJIA x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8441330", Offset = "0x8440330", VA = "0x188441330")]
		internal object FFCIDEBEOLH(GEHDBBJHGOO x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x84413A0", Offset = "0x84403A0", VA = "0x1884413A0")]
		internal object OEJFKCKOBFA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct DNKBOOJFAKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public KJKKPMCIKID.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public KAANNBPKKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private OCCEIIOALHI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8431530", Offset = "0x8430530", VA = "0x188431530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8431FB0", Offset = "0x8430FB0", VA = "0x188431FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct BGGNENDPLJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public KAANNBPKKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public KJKKPMCIKID.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private GEHDBBJHGOO <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8425CB0", Offset = "0x8424CB0", VA = "0x188425CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8426940", Offset = "0x8425940", VA = "0x188426940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct BNKNJOMDMDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public KAANNBPKKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x842D0A0", Offset = "0x842C0A0", VA = "0x18842D0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x842D640", Offset = "0x842C640", VA = "0x18842D640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	internal static readonly JBBHIJHGEPM LNNENHIEMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private JHHKOFMOFFM DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private GEHDBBJHGOO OKNOLGPHBBK;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private IJPJAKACFOB BJABPNAMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x843A130", Offset = "0x8439130", VA = "0x18843A130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool HDNJGFJKMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2352740", Offset = "0x2351740", VA = "0x182352740", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool EHPPEBIJBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x843A620", Offset = "0x8439620", VA = "0x18843A620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8439CF0", Offset = "0x8438CF0", VA = "0x188439CF0", Slot = "7")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8439D70", Offset = "0x8438D70", VA = "0x188439D70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8439B60", Offset = "0x8438B60", VA = "0x188439B60", Slot = "9")]
	public void AKBKNLLCFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x843A690", Offset = "0x8439690", VA = "0x18843A690")]
	private bool JAAFGFOBHBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x843A180", Offset = "0x8439180", VA = "0x18843A180", Slot = "6")]
	private void GOFILBEEIEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x843A880", Offset = "0x8439880", VA = "0x18843A880", Slot = "5")]
	[AsyncStateMachine(typeof(DNKBOOJFAKD))]
	private Task OPAMKJHIGFP(KJKKPMCIKID.Reason DKBCGBFNIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x8439E50", Offset = "0x8438E50", VA = "0x188439E50")]
	private bool GCKFBFKCJAO(KJKKPMCIKID.Reason DKBCGBFNIGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x843A250", Offset = "0x8439250", VA = "0x18843A250")]
	private FLIMEIMMDEM[] GPJDFGLCNOF(PAIKJEGABFG LKMJPMALHKA, OHMKBLJJPPO PNCIAJDNEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x843A770", Offset = "0x8439770", VA = "0x18843A770")]
	[AsyncStateMachine(typeof(BGGNENDPLJD))]
	private Task MMMJHAFMJOE(KJKKPMCIKID.Reason DKBCGBFNIGO, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x8439D80", Offset = "0x8438D80", VA = "0x188439D80")]
	[AsyncStateMachine(typeof(BNKNJOMDMDG))]
	private Task EKBJMCHJBGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public KAANNBPKKDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class DCOJFCLEHBJ : GIALCOICGEG, BGMLLKPPOFE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct MLMMLAOMDIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public PAIKJEGABFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public DCOJFCLEHBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public LLFJDDEPDIJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x843F440", Offset = "0x843E440", VA = "0x18843F440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x843FDB0", Offset = "0x843EDB0", VA = "0x18843FDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct PALFGJDIOHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public DCOJFCLEHBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public PAIKJEGABFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public LLFJDDEPDIJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private LDCGKGNFMMI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private JHEDBCMAENC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private HPBALDPEPLO <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private NHNOGEFNFMP <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8441D50", Offset = "0x8440D50", VA = "0x188441D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8442AA0", Offset = "0x8441AA0", VA = "0x188442AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class OPODJDMAIKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public Matchmaking.LCLHJLDMAHM result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public HBMPNPEHDHN errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public OPODJDMAIKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8441C50", Offset = "0x8440C50", VA = "0x188441C50")]
		internal object MAFKJBFADOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class LMMHCJBFFNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Task<AENKMJAJKCL> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public LMMHCJBFFNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		internal Task<AENKMJAJKCL> PBCDIFAODOE(LDCGKGNFMMI<string>.CKHHEKIPJDF _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct BIOBEAMGBDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public DCOJFCLEHBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public PAIKJEGABFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public LLFJDDEPDIJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public HPBALDPEPLO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private LMMHCJBFFNB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private HKMALGKDFBG <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private JHEDBCMAENC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private BAKGMMHDEOL <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private Task<Matchmaking.MIODFHAAAOG> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private DOHHNMFAEOD <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.MIODFHAAAOG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter<AENKMJAJKCL> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x84269A0", Offset = "0x84259A0", VA = "0x1884269A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x842C410", Offset = "0x842B410", VA = "0x18842C410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct IMHFGNDLADL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public DCOJFCLEHBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <disconnectTimerScope>5__3;

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
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8454B90", Offset = "0x8453B90", VA = "0x188454B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8455600", Offset = "0x8454600", VA = "0x188455600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct IJJJMPAHIPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public DCOJFCLEHBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private AINJBKKEAIL <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8453A80", Offset = "0x8452A80", VA = "0x188453A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8453F00", Offset = "0x8452F00", VA = "0x188453F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct OPHNHBAIKOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public AsyncTaskMethodBuilder<Matchmaking.MIODFHAAAOG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public PAIKJEGABFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public DCOJFCLEHBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TaskAwaiter<Matchmaking.MIODFHAAAOG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x845C6B0", Offset = "0x845B6B0", VA = "0x18845C6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x845CB80", Offset = "0x845BB80", VA = "0x18845CB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct IGKDDFEFPLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public Matchmaking.MIODFHAAAOG serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public DCOJFCLEHBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public HPBALDPEPLO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private TaskAwaiter<CNNKEAJPGPC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x84533D0", Offset = "0x84523D0", VA = "0x1884533D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8453A20", Offset = "0x8452A20", VA = "0x188453A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class POLCFJIINCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public PAIKJEGABFG targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public POLCFJIINCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8462620", Offset = "0x8461620", VA = "0x188462620")]
		internal object BGNGLHLOMLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8462720", Offset = "0x8461720", VA = "0x188462720")]
		internal string GALBGDKIDKA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct JLFJIKEIILD : IAsyncStateMachine
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
		public PAIKJEGABFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public DCOJFCLEHBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private POLCFJIINCO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private JHEDBCMAENC <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x8456080", Offset = "0x8455080", VA = "0x188456080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8456C20", Offset = "0x8455C20", VA = "0x188456C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct EENBOAPJGLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public DCOJFCLEHBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public HPBALDPEPLO joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public AENKMJAJKCL initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public PAIKJEGABFG targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public HKMALGKDFBG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x844CD70", Offset = "0x844BD70", VA = "0x18844CD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x844D560", Offset = "0x844C560", VA = "0x18844D560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct DJLCJKJFBJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public DCOJFCLEHBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private JHEDBCMAENC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap3;

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
		private JHEDBCMAENC <>7__wrap5;

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
		[Cpp2IlInjected.Address(RVA = "0x844A060", Offset = "0x8449060", VA = "0x18844A060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x844B850", Offset = "0x844A850", VA = "0x18844B850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct PJCMFDDFJAK : IAsyncStateMachine
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
		public PFBDGKHFNEC localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public DCOJFCLEHBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<GGIHIJCCBHJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x845F860", Offset = "0x845E860", VA = "0x18845F860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8460050", Offset = "0x845F050", VA = "0x188460050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class EKMPFMFDMOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public PAIKJEGABFG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public EKMPFMFDMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x844EA60", Offset = "0x844DA60", VA = "0x18844EA60")]
		internal object DEHCDMJFLHP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class NGAGDFOELCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NGAGDFOELCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x845B840", Offset = "0x845A840", VA = "0x18845B840")]
		internal void FBKEENKECIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class FEDCBKLEDOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public PAIKJEGABFG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public FEDCBKLEDOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8450190", Offset = "0x844F190", VA = "0x188450190")]
		internal object PFGJMBECLNC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class PELBHDKGGJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public PAIKJEGABFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public PELBHDKGGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x845EC90", Offset = "0x845DC90", VA = "0x18845EC90")]
		internal string BDALHNMFGAD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly JBBHIJHGEPM MNLLCLILEKK;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly JBBHIJHGEPM AAOGGMBEHBG;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly JBBHIJHGEPM CLMOHLIPJPJ;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly string MAAHHBOCAIP;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static readonly string JOIMKNCKIOL;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static readonly string OEAOKHNFIHD;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public static readonly Guid KNLIBFOAMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private PLHOCFLCCME AANEBFKDCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private KFEINBBMNIF PBJBHBOBLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private LDMAAALPMPJ NODDAHEDIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private JHHKOFMOFFM DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private KJKKPMCIKID INIKKNPPFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private GFAFJAJHEAL OHEPFLBIHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NOKLFIDFJEA EIHAJEPOKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private IBHJLAMHBCG IMMBIKKFMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private LJPPDIILPEC LLLDBKONJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private IDisposable LAEJDBMLGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private OKGFEPLGNNN MEBFMFIEGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly BDMLCHKFOFH AKDOGMNKKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private DOHHNMFAEOD NNEKNDEAGMP;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus CKMENNJIKOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA17D90", Offset = "0xA16D90", VA = "0x180A17D90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x12E4C80", Offset = "0x12E3C80", VA = "0x1812E4C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private IJPJAKACFOB BJABPNAMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x842EE60", Offset = "0x842DE60", VA = "0x18842EE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x842DF50", Offset = "0x842CF50", VA = "0x18842DF50", Slot = "6")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x842EA90", Offset = "0x842DA90", VA = "0x18842EA90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x842F680", Offset = "0x842E680", VA = "0x18842F680", Slot = "5")]
	[AsyncStateMachine(typeof(MLMMLAOMDIH))]
	public Task IFKKJMKFBGG(PAIKJEGABFG LEAIIPCAOIH, LLFJDDEPDIJ GKAEKPHDHIG, CancellationToken EBOFCHGLLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x842E280", Offset = "0x842D280", VA = "0x18842E280")]
	[AsyncStateMachine(typeof(PALFGJDIOHO))]
	private Task CEEBICJBKID(PAIKJEGABFG LEAIIPCAOIH, LLFJDDEPDIJ GKAEKPHDHIG, CancellationToken EBOFCHGLLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8430150", Offset = "0x842F150", VA = "0x188430150")]
	private void MHLNJGBHGFF(IBHJLAMHBCG IMMBIKKFMEN, PAIKJEGABFG LEAIIPCAOIH, Exception APEPCFJIAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x842D700", Offset = "0x842C700", VA = "0x18842D700")]
	private static void AMCNDMDMFMF(NHNOGEFNFMP KCLJNDLOCKE, Exception APEPCFJIAMB, [Optional] List<int> NONHBAKFOGO, int GADPHLHLJAG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x842F100", Offset = "0x842E100", VA = "0x18842F100")]
	[AsyncStateMachine(typeof(BIOBEAMGBDI))]
	private Task GPPCNGJFHOA(LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, PAIKJEGABFG LEAIIPCAOIH, LLFJDDEPDIJ GKAEKPHDHIG, HPBALDPEPLO ONPHAKPHOJN, CancellationToken EBOFCHGLLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x8430B50", Offset = "0x842FB50", VA = "0x188430B50")]
	private void PJGENEOEMPA([CallerMemberName] string MCDCOKIKHMP = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x842E3D0", Offset = "0x842D3D0", VA = "0x18842E3D0")]
	[AsyncStateMachine(typeof(IMHFGNDLADL))]
	private Task CEPANEEKOIF(LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x842FD90", Offset = "0x842ED90", VA = "0x18842FD90")]
	private void MGDIJCEAEAA(PAIKJEGABFG LEAIIPCAOIH, CancellationToken EBOFCHGLLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x842F260", Offset = "0x842E260", VA = "0x18842F260")]
	private void HNCGLIJLIEA(PAIKJEGABFG LEAIIPCAOIH, TaskStatus PJPCILIKLGM, string NAAMEAFIHJI, HPBALDPEPLO ONPHAKPHOJN, Exception FJADMGBFJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8430740", Offset = "0x842F740", VA = "0x188430740")]
	private void NAADEMEBEEI(PAIKJEGABFG LEAIIPCAOIH, HPBALDPEPLO ONPHAKPHOJN, OperationCanceledException LACGGEHDPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x842EAE0", Offset = "0x842DAE0", VA = "0x18842EAE0")]
	private void EIGBHHFBILJ(PAIKJEGABFG LEAIIPCAOIH, HPBALDPEPLO ONPHAKPHOJN, Exception APEPCFJIAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x842EB60", Offset = "0x842DB60", VA = "0x18842EB60")]
	private void FOOOBDDPLNN(PAIKJEGABFG LEAIIPCAOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x842F9D0", Offset = "0x842E9D0", VA = "0x18842F9D0")]
	private static OGDCDNJBIFG JFOEFEHMCAC(PAIKJEGABFG LEAIIPCAOIH)
	{
		return default(OGDCDNJBIFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x842E500", Offset = "0x842D500", VA = "0x18842E500")]
	[AsyncStateMachine(typeof(IJJJMPAHIPB))]
	private Task CHNJHOADPDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x842E930", Offset = "0x842D930", VA = "0x18842E930")]
	[AsyncStateMachine(typeof(OPHNHBAIKOH))]
	private Task<Matchmaking.MIODFHAAAOG> DNLMGFAFCCB(PAIKJEGABFG LEAIIPCAOIH, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8430A40", Offset = "0x842FA40", VA = "0x188430A40")]
	private static CNNKEAJPGPC PEGNIODNFLL(Matchmaking.MIODFHAAAOG BEMGAPIKHPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x842FB30", Offset = "0x842EB30", VA = "0x18842FB30")]
	[AsyncStateMachine(typeof(IGKDDFEFPLJ))]
	private Task JNHOHGLKKAJ(Matchmaking.MIODFHAAAOG BEMGAPIKHPH, HPBALDPEPLO ONPHAKPHOJN, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken JDCDGDBBGIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x8430900", Offset = "0x842F900", VA = "0x188430900")]
	[AsyncStateMachine(typeof(JLFJIKEIILD))]
	private Task PBPLOBFOEBG(PAIKJEGABFG LEAIIPCAOIH, CancellationTokenSource DGNNHFAEMFP, Task DJCCIMIPEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x842E5D0", Offset = "0x842D5D0", VA = "0x18842E5D0")]
	[AsyncStateMachine(typeof(EENBOAPJGLG))]
	private Task COCJIHKCJDD(AENKMJAJKCL GJIIIBDFFHL, HKMALGKDFBG JEAOKNGGMFI, PAIKJEGABFG MENFJEGBKHJ, HPBALDPEPLO JPFNHCBHBEB, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken EADDKLABLKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x842E740", Offset = "0x842D740", VA = "0x18842E740")]
	private HPBALDPEPLO DGECELAKJII(HPBALDPEPLO JPFNHCBHBEB, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x84307C0", Offset = "0x842F7C0", VA = "0x1884307C0")]
	[AsyncStateMachine(typeof(DJLCJKJFBJC))]
	private Task NBAFPMHCEHN(LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x8430610", Offset = "0x842F610", VA = "0x188430610")]
	[AsyncStateMachine(typeof(PJCMFDDFJAK))]
	private Task MPPNIDCAJAI(CancellationToken CBJPDIFOEKF, int GMMLOKJHPEI, PFBDGKHFNEC PEEMGACEOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x842F7C0", Offset = "0x842E7C0", VA = "0x18842F7C0")]
	private static void IGBMBKGDDBD(PAIKJEGABFG LEAIIPCAOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x842EEB0", Offset = "0x842DEB0", VA = "0x18842EEB0")]
	private void GNCNKABBIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8430CD0", Offset = "0x842FCD0", VA = "0x188430CD0")]
	private void PKGPBKMKGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x842F940", Offset = "0x842E940", VA = "0x18842F940")]
	private void JDHNNEBNGLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x84300C0", Offset = "0x842F0C0", VA = "0x1884300C0")]
	private void MHDLJPEPFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x842ED70", Offset = "0x842DD70", VA = "0x18842ED70")]
	private static void GCPHEAEMGOG(PAIKJEGABFG LEAIIPCAOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x842FC80", Offset = "0x842EC80", VA = "0x18842FC80")]
	private static CancellationTokenRegistration LGEHENAENJD(PAIKJEGABFG LEAIIPCAOIH, CancellationToken JDCDGDBBGIP)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x842FA30", Offset = "0x842EA30", VA = "0x18842FA30")]
	private static void JJPKKFKIEBJ(PAIKJEGABFG LEAIIPCAOIH, Exception APEPCFJIAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x842F4D0", Offset = "0x842E4D0", VA = "0x18842F4D0")]
	private void IAOEGDODBEE(PAIKJEGABFG LEAIIPCAOIH, Task DJCCIMIPEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x842D6A0", Offset = "0x842C6A0", VA = "0x18842D6A0")]
	private static void AHIMDJPCPBN(Func<string> AACKKPGJBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x8430F80", Offset = "0x842FF80", VA = "0x188430F80")]
	public DCOJFCLEHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x84305B0", Offset = "0x842F5B0", VA = "0x1884305B0")]
	[CompilerGenerated]
	internal static (int, int?) MPNLMDIOFKP(HBMPNPEHDHN LELALGHIBFL)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[RecRoom.NoEngine.Common.Preserve]
internal class PKEJIJGCJBO : CGGJELIFDNE, BGMLLKPPOFE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct PNPFMGPPEGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public PKEJIJGCJBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public PFBDGKHFNEC localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x84620E0", Offset = "0x84610E0", VA = "0x1884620E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x84625C0", Offset = "0x84615C0", VA = "0x1884625C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class OILPCDIHPHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public PKEJIJGCJBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public PFBDGKHFNEC localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public OILPCDIHPHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x845C670", Offset = "0x845B670", VA = "0x18845C670")]
		internal List<Task> NLIODEJOINA(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct JLNNOEKFFFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public BEPKOPDMDEM taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public PFBDGKHFNEC localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8456C80", Offset = "0x8455C80", VA = "0x188456C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8457020", Offset = "0x8456020", VA = "0x188457020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct LIEDEPDEGIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public PKEJIJGCJBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x84590F0", Offset = "0x84580F0", VA = "0x1884590F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x84593D0", Offset = "0x84583D0", VA = "0x1884593D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly HashSet<BEPKOPDMDEM> PAMCMOFHELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private KFEINBBMNIF PBJBHBOBLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private LFLPPHCMPGO HPCHDCNIDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private MFIEBJJDOKB EIIMINKMDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private IDisposable LAEJDBMLGGN;

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x8461140", Offset = "0x8460140", VA = "0x188461140", Slot = "5")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x84615C0", Offset = "0x84605C0", VA = "0x1884615C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8461FF0", Offset = "0x8460FF0", VA = "0x188461FF0", Slot = "4")]
	public bool OLHNAMHFFLG(BEPKOPDMDEM DNDLEHOKLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8461420", Offset = "0x8460420", VA = "0x188461420")]
	private void BDIKPAGFPOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8461740", Offset = "0x8460740", VA = "0x188461740")]
	private void ICCCAAKOOEP(JOEFAEBJKIB MKIDPONBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x8461F00", Offset = "0x8460F00", VA = "0x188461F00")]
	[AsyncStateMachine(typeof(PNPFMGPPEGM))]
	private Task LEGCMELDLHI(int GMMLOKJHPEI, PFBDGKHFNEC PEEMGACEOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x84614F0", Offset = "0x84604F0", VA = "0x1884614F0")]
	private Func<CancellationToken, List<Task>> DBBCAGHEMFD(int GMMLOKJHPEI, PFBDGKHFNEC PEEMGACEOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8461960", Offset = "0x8460960", VA = "0x188461960")]
	private List<Task> INBOJNDHBMA(int GMMLOKJHPEI, PFBDGKHFNEC PEEMGACEOLF, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x8461620", Offset = "0x8460620", VA = "0x188461620")]
	[AsyncStateMachine(typeof(JLNNOEKFFFG))]
	private Task ENOIDMJBOFN(BEPKOPDMDEM KACLNFIKDJP, CancellationToken EJJDDFFADPC, int GMMLOKJHPEI, PFBDGKHFNEC PEEMGACEOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x8461E30", Offset = "0x8460E30", VA = "0x188461E30")]
	[AsyncStateMachine(typeof(LIEDEPDEGIN))]
	private Task KEJBHLEIJLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x84610C0", Offset = "0x84600C0", VA = "0x1884610C0")]
	private void AKBKNLLCFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x8462050", Offset = "0x8461050", VA = "0x188462050")]
	public PKEJIJGCJBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[UnityEngine.Scripting.Preserve]
internal sealed class KPOKAPCEAMH : IFAIILFJKPF, BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class BENLOEBNLNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BENLOEBNLNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x84451D0", Offset = "0x84441D0", VA = "0x1884451D0")]
		internal object KGBBNKIMHDN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class PHIHOPPLDAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public PHIHOPPLDAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x845F260", Offset = "0x845E260", VA = "0x18845F260")]
		internal object CPDLCIPOCLJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class DGNDJAALAIK
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public DGNDJAALAIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class KEBBEFODOAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public KEBBEFODOAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8457CE0", Offset = "0x8456CE0", VA = "0x188457CE0")]
		internal object GCGFLGMGEEB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class DCEDJGDFLCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public DCEDJGDFLCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8448420", Offset = "0x8447420", VA = "0x188448420")]
		internal object OKGCELMIKKG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private readonly Dictionary<Guid, MMGJCCEFHKA> JIHHPLOGLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private readonly TimeSpan DELJLKDHFKC;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "9")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x84589A0", Offset = "0x84579A0", VA = "0x1884589A0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x8458C30", Offset = "0x8457C30", VA = "0x188458C30", Slot = "4")]
	public AFOHIMBEAIK IIGLPCDPOEE(Guid DHFBDLBBCGN)
	{
		return default(AFOHIMBEAIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x8458A20", Offset = "0x8457A20", VA = "0x188458A20", Slot = "5")]
	public bool GNAALOCCJEL(Guid DHFBDLBBCGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x8458670", Offset = "0x8457670", VA = "0x188458670", Slot = "6")]
	public bool CPPOOKGKBAK(Guid DHFBDLBBCGN, Task MENJBHNCOEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8458E50", Offset = "0x8457E50", VA = "0x188458E50", Slot = "7")]
	public bool OFJAPNCDIKM(Guid DHFBDLBBCGN, GGIHIJCCBHJ MNJLOAEFEJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x84589B0", Offset = "0x84579B0", VA = "0x1884589B0", Slot = "8")]
	public Task<(GGIHIJCCBHJ, Task)> EALCCNLLBGO(Guid DHFBDLBBCGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8458440", Offset = "0x8457440", VA = "0x188458440")]
	private void ALGCDPEOOFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x8459030", Offset = "0x8458030", VA = "0x188459030")]
	public KPOKAPCEAMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[RecRoom.NoEngine.Common.Preserve]
internal class EFINDBGCMIH : GJKNOPEFJGC, BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private class FPAFOEBOJDC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private readonly PAIKJEGABFG ELCMKIJIHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private readonly CancellationTokenSource CLDKCMPEHDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public readonly CancellationToken IOEHGJLONAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private bool MFFCJLDPJJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private bool CIAFEFCBLPC;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8450B40", Offset = "0x844FB40", VA = "0x188450B40")]
		public FPAFOEBOJDC(PAIKJEGABFG ELCMKIJIHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x84509C0", Offset = "0x844F9C0", VA = "0x1884509C0")]
		public void AKBKNLLCFBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8450B10", Offset = "0x844FB10", VA = "0x188450B10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class AOEEFOEFCDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public GBMOIPIDAFL disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public AOEEFOEFCDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8445140", Offset = "0x8444140", VA = "0x188445140")]
		internal object GJFLAMBDHFO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct IMAOPFJBNHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public GBMOIPIDAFL disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public EFINDBGCMIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x84546E0", Offset = "0x84536E0", VA = "0x1884546E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x8454B30", Offset = "0x8453B30", VA = "0x188454B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class FKCPEGNKFGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public EFINDBGCMIH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public FKCPEGNKFGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8450950", Offset = "0x844F950", VA = "0x188450950")]
		internal object CFDNDHNKHAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class MJDOPEIACAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public PAIKJEGABFG newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public FKCPEGNKFGJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public MJDOPEIACAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x845AAD0", Offset = "0x8459AD0", VA = "0x18845AAD0")]
		internal object GKALJBHNHEB((PAIKJEGABFG lastLocalPlayerRoomInstance, PAIKJEGABFG newRoomInstance, KJKKPMCIKID fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct PDPFGHJGNBI : IAsyncStateMachine
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
		public EFINDBGCMIH <>4__this;

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
		private JHEDBCMAENC <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x845D520", Offset = "0x845C520", VA = "0x18845D520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class KFBLBEMFHEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public PAIKJEGABFG newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public KFBLBEMFHEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8457DC0", Offset = "0x8456DC0", VA = "0x188457DC0")]
		internal object LLCHIBKEGAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8457E60", Offset = "0x8456E60", VA = "0x188457E60")]
		internal void NEHBBDPEBNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x8457D80", Offset = "0x8456D80", VA = "0x188457D80")]
		internal object JHNBMOOGJAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x8457D40", Offset = "0x8456D40", VA = "0x188457D40")]
		internal object AJNDJLNAAMA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct HNPDMIBNPKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public PAIKJEGABFG newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public EFINDBGCMIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public LLFJDDEPDIJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private KFBLBEMFHEH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private JHEDBCMAENC <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x8451440", Offset = "0x8450440", VA = "0x188451440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x8452400", Offset = "0x8451400", VA = "0x188452400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly GOEIPGLACMD.LHPOBAFJPNC BMLPJOAEGBJ;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly KFPJLLJHHDK PCGCPFAPEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private KFEINBBMNIF PBJBHBOBLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private KJKKPMCIKID INIKKNPPFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private JHHKOFMOFFM DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private DMIMJPCFHKL NFFGNPJGBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private GIALCOICGEG GABNHHFPLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private PAIKJEGABFG AEJGJIBIOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private FPAFOEBOJDC FBBDJBOKPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private bool JMJLKIAIEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private Task JCPDMIIAGEH;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private IJPJAKACFOB BJABPNAMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x844DB00", Offset = "0x844CB00", VA = "0x18844DB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool CPLAGDABEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xC58EB0", Offset = "0xC57EB0", VA = "0x180C58EB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x844E0F0", Offset = "0x844D0F0", VA = "0x18844E0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x844D5C0", Offset = "0x844C5C0", VA = "0x18844D5C0", Slot = "4")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x844D990", Offset = "0x844C990", VA = "0x18844D990", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x844DB50", Offset = "0x844CB50", VA = "0x18844DB50")]
	[AsyncStateMachine(typeof(IMAOPFJBNHF))]
	private Task HDFNILHEPAH(GBMOIPIDAFL FKGOJHDOJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x844DC40", Offset = "0x844CC40", VA = "0x18844DC40")]
	private void JINOHBBNMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x844E100", Offset = "0x844D100", VA = "0x18844E100")]
	private void OFBKAFGODEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x844DE50", Offset = "0x844CE50", VA = "0x18844DE50")]
	private void KPOEMEHHEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x844DDD0", Offset = "0x844CDD0", VA = "0x18844DDD0")]
	private bool KKOLCJJPPOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x844DFD0", Offset = "0x844CFD0", VA = "0x18844DFD0")]
	[AsyncStateMachine(typeof(PDPFGHJGNBI))]
	private void MKCODIBLJIE(int LFJPHGCMAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x844E290", Offset = "0x844D290", VA = "0x18844E290")]
	private void OIFEMPMOLOD([Out] IDisposable OBAJHGBEDKP, [Out] IDisposable HICLBANPJFH, [Out] IDisposable FOJACDIEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x844E530", Offset = "0x844D530", VA = "0x18844E530")]
	private bool OIOHAEDLFCM(PAIKJEGABFG ELCMKIJIHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x844E0A0", Offset = "0x844D0A0", VA = "0x18844E0A0")]
	private void NBHIKBMLECF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x844D860", Offset = "0x844C860", VA = "0x18844D860")]
	[AsyncStateMachine(typeof(HNPDMIBNPKL))]
	private Task CEEBICJBKID(PAIKJEGABFG ELCMKIJIHIO, LLFJDDEPDIJ GKAEKPHDHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x844E9F0", Offset = "0x844D9F0", VA = "0x18844E9F0")]
	public EFINDBGCMIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[UnityEngine.Scripting.Preserve]
internal sealed class DPNODAEFNBE : JOECIDFCFKO, BGMLLKPPOFE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct ELAPNLLEGPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<MCEHODFGIME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public DPNODAEFNBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<MCEHODFGIME> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x844F2B0", Offset = "0x844E2B0", VA = "0x18844F2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x844F540", Offset = "0x844E540", VA = "0x18844F540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class BIJLPMLGGFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public DAEAHJMMAED message;

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BIJLPMLGGFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x8445A20", Offset = "0x8444A20", VA = "0x188445A20")]
		internal object JBBLPEBNOJP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class NPPIOBKCDOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public DAEAHJMMAED messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NPPIOBKCDOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x845C550", Offset = "0x845B550", VA = "0x18845C550")]
		internal object PJEANDIOFEN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class DKGCKLEMPDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public DAEAHJMMAED request;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public DKGCKLEMPDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x844B8B0", Offset = "0x844A8B0", VA = "0x18844B8B0")]
		internal object AGGDKDBNJJF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct PBMJIFGGAGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public DAEAHJMMAED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public DPNODAEFNBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<PPPBMGNNDNF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x845CBF0", Offset = "0x845BBF0", VA = "0x18845CBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x845D4C0", Offset = "0x845C4C0", VA = "0x18845D4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class AGHCDNGLAJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public DAEAHJMMAED operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public AGHCDNGLAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x8444FE0", Offset = "0x8443FE0", VA = "0x188444FE0")]
		internal object MIOIPFCIAHB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct ELNLMENOAIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public DAEAHJMMAED operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public DPNODAEFNBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private HPBALDPEPLO <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x844F5B0", Offset = "0x844E5B0", VA = "0x18844F5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8450130", Offset = "0x844F130", VA = "0x188450130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct PHKOIMIBINP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public AsyncTaskMethodBuilder<PPPBMGNNDNF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public DPNODAEFNBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public DAEAHJMMAED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private EIMCPKKLNLB.EDBOMGAOCIA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private HPBALDPEPLO <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x845F2C0", Offset = "0x845E2C0", VA = "0x18845F2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x845F7F0", Offset = "0x845E7F0", VA = "0x18845F7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class OFLPKAJGOLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public PPPBMGNNDNF operation;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public OFLPKAJGOLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x845C5F0", Offset = "0x845B5F0", VA = "0x18845C5F0")]
		internal object PPODJFPDEFP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct NJIEJBMFNHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public PPPBMGNNDNF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public DPNODAEFNBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private LDCGKGNFMMI<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x845B8E0", Offset = "0x845A8E0", VA = "0x18845B8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x845BF10", Offset = "0x845AF10", VA = "0x18845BF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class HBBIEPJHLKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public DAEAHJMMAED request;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public HBBIEPJHLKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x8450C50", Offset = "0x844FC50", VA = "0x188450C50")]
		internal object LNLPPLLBEKO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class JICOHEIIKIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public DAEAHJMMAED request;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public JICOHEIIKIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8455820", Offset = "0x8454820", VA = "0x188455820")]
		internal object MDGMCIDGINB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private GFAFJAJHEAL OHEPFLBIHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private JFBCBONLOMK DICJDHBCDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private FAJHEKNGMOI OBECGFDEJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private LDMAAALPMPJ NODDAHEDIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private TaskCompletionSource<MCEHODFGIME> HOFALOOPHNN;

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x844BCA0", Offset = "0x844ACA0", VA = "0x18844BCA0", Slot = "7")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x844BEB0", Offset = "0x844AEB0", VA = "0x18844BEB0", Slot = "6")]
	[AsyncStateMachine(typeof(ELAPNLLEGPB))]
	public Task<MCEHODFGIME> GOGCFNHIFMD(CancellationToken JFEANKNHOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x844B910", Offset = "0x844A910", VA = "0x18844B910", Slot = "4")]
	public void AFPIIOCCJEF(DAEAHJMMAED NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x844C960", Offset = "0x844B960", VA = "0x18844C960", Slot = "5")]
	public void PJPEECINCEE(DAEAHJMMAED BGLJFOPGLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x844C850", Offset = "0x844B850", VA = "0x18844C850")]
	[AsyncStateMachine(typeof(PBMJIFGGAGP))]
	private Task NNOKLCDMCPG(DAEAHJMMAED HOOJNAMGGBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x844C4A0", Offset = "0x844B4A0", VA = "0x18844C4A0")]
	[AsyncStateMachine(typeof(ELNLMENOAIF))]
	private Task KLIFPDLCGDJ(DAEAHJMMAED EOFANPBCPAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x844C350", Offset = "0x844B350", VA = "0x18844C350")]
	[AsyncStateMachine(typeof(PHKOIMIBINP))]
	private Task<PPPBMGNNDNF> HNAHDMMIPJB(DAEAHJMMAED HOOJNAMGGBC, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x844C5B0", Offset = "0x844B5B0", VA = "0x18844C5B0")]
	private HPBALDPEPLO NDNJCLNDEFB(DAEAHJMMAED CAGMDMPFBND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x844BD90", Offset = "0x844AD90", VA = "0x18844BD90")]
	[AsyncStateMachine(typeof(NJIEJBMFNHH))]
	private Task GNNPDLMMNEB(PPPBMGNNDNF AOHGJNGCBBI, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x844C640", Offset = "0x844B640", VA = "0x18844C640")]
	private PPPBMGNNDNF NDNJKENLGHO(DAEAHJMMAED HOOJNAMGGBC, HPBALDPEPLO HKMAGJLMBHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x36B9050", Offset = "0x36B8050", VA = "0x1836B9050")]
	private T CJCJKPNPKEO<T>(T OHLIHBDBKCE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x844BFC0", Offset = "0x844AFC0", VA = "0x18844BFC0")]
	private PPPBMGNNDNF GOJBMKCOMEE(DAEAHJMMAED HOOJNAMGGBC, HPBALDPEPLO HKMAGJLMBHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public DPNODAEFNBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class BKOPMEJIPCD : JFBCBONLOMK, BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class JGKDPGKJFNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public JGKDPGKJFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x84557B0", Offset = "0x84547B0", VA = "0x1884557B0")]
		internal object IKBIPPCMGNI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class IKNNBMINBAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public IKNNBMINBAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x8454670", Offset = "0x8453670", VA = "0x188454670")]
		internal object DMBEDCIEABD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private LDMAAALPMPJ NODDAHEDIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private KPFKDIBGGLC FAPAMCLMPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private JOECIDFCFKO PGIDKOLIOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private IFAIILFJKPF JIHHPLOGLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private DFOJGOILCNA HKHJFPPOMOL;

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x8445A80", Offset = "0x8444A80", VA = "0x188445A80", Slot = "6")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x8445E80", Offset = "0x8444E80", VA = "0x188445E80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x8447540", Offset = "0x8446540", VA = "0x188447540", Slot = "4")]
	public AFOHIMBEAIK PIAHIINIEGI(DAEAHJMMAED PAFNHBFIGON)
	{
		return default(AFOHIMBEAIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x8446A30", Offset = "0x8445A30", VA = "0x188446A30", Slot = "5")]
	public void LHAIECBCJJA(Guid DHFBDLBBCGN, Task MENJBHNCOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x8446140", Offset = "0x8445140", VA = "0x188446140")]
	private void HGJPKNDBGCL(byte OGKCOMEHLBF, int IJAHNOHAHPB, object BNKPOELNFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x8446210", Offset = "0x8445210", VA = "0x188446210")]
	private void KHMJNIEOJFP(LPHKFBBGLKG NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x84467B0", Offset = "0x84457B0", VA = "0x1884467B0")]
	private void LCOADNMFPEJ(LPHKFBBGLKG NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x8446C40", Offset = "0x8445C40", VA = "0x188446C40")]
	private void NILCHIACLKE(LPHKFBBGLKG NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x8447070", Offset = "0x8446070", VA = "0x188447070")]
	private GGIHIJCCBHJ OLHEKGLFPOI(DAEAHJMMAED CAGMDMPFBND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x8445F30", Offset = "0x8444F30", VA = "0x188445F30")]
	private void EPNIKNBKMPK(DAEAHJMMAED EOFANPBCPAO, GGIHIJCCBHJ MNJLOAEFEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x8446E80", Offset = "0x8445E80", VA = "0x188446E80")]
	private bool NNEOKKGFLLL(DAEAHJMMAED EOFANPBCPAO, GGIHIJCCBHJ MNJLOAEFEJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x8447320", Offset = "0x8446320", VA = "0x188447320")]
	private bool ONMHFBCPHAN(DAEAHJMMAED HKCJAMENDMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x8445BF0", Offset = "0x8444BF0", VA = "0x188445BF0")]
	private bool BNCFNFPOEHI(byte OGKCOMEHLBF, ExitGames.Client.Photon.Hashtable NKBJHKLGFDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public BKOPMEJIPCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[UnityEngine.Scripting.Preserve]
internal sealed class KOLPJCHABDM : NJGDDFJMLGB, BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class BIAMMKIGKBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public MCEHODFGIME operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public KOLPJCHABDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public DAEAHJMMAED roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BIAMMKIGKBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x84459B0", Offset = "0x84449B0", VA = "0x1884459B0")]
		internal object IEHGGPJGMBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8445800", Offset = "0x8444800", VA = "0x188445800")]
		internal object BNEEDEBPFMN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct IKJPOIFCHHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public AsyncTaskMethodBuilder<GGIHIJCCBHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public KOLPJCHABDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public DAEAHJMMAED roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter<GGIHIJCCBHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8453F60", Offset = "0x8452F60", VA = "0x188453F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x8454600", Offset = "0x8453600", VA = "0x188454600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class BMJAGMEODCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public MCEHODFGIME operationType;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BMJAGMEODCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x8447970", Offset = "0x8446970", VA = "0x188447970")]
		internal object FDOGNAPKDCN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class JACPBMFABNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public DAEAHJMMAED request;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public JACPBMFABNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x84556D0", Offset = "0x84546D0", VA = "0x1884556D0")]
		internal object IKCBNPGPILP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x8455660", Offset = "0x8454660", VA = "0x188455660")]
		internal object CADMOLKNCEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x8455740", Offset = "0x8454740", VA = "0x188455740")]
		internal object JOFOMJJIBFE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct MCDEOJADALC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public AsyncTaskMethodBuilder<GGIHIJCCBHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public DAEAHJMMAED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public KOLPJCHABDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private JACPBMFABNN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private AFOHIMBEAIK <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private GGIHIJCCBHJ <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<(GGIHIJCCBHJ validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x8459B20", Offset = "0x8458B20", VA = "0x188459B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x845A3F0", Offset = "0x84593F0", VA = "0x18845A3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private LDMAAALPMPJ NODDAHEDIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private KPFKDIBGGLC FAPAMCLMPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private JFBCBONLOMK DICJDHBCDLH;

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x8457F40", Offset = "0x8456F40", VA = "0x188457F40", Slot = "5")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x8458320", Offset = "0x8457320", VA = "0x188458320", Slot = "4")]
	[AsyncStateMachine(typeof(IKJPOIFCHHD))]
	private Task<GGIHIJCCBHJ> FAJNHCOACMC(DAEAHJMMAED CAGMDMPFBND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x8458130", Offset = "0x8457130", VA = "0x188458130")]
	private bool CEKFLJOCCDB(MCEHODFGIME MEOBMEDANDK, [Out] GGIHIJCCBHJ OBOOAPELMPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x8457FF0", Offset = "0x8456FF0", VA = "0x188457FF0")]
	[AsyncStateMachine(typeof(MCDEOJADALC))]
	private Task<GGIHIJCCBHJ> BLDHGNDFAGC(DAEAHJMMAED HOOJNAMGGBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public KOLPJCHABDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class JKEPDDPEHIG : FCNEEADCJIO, BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private struct LHKFBJIEMLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public NGHKAOKDFBL JMEEIAJHJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public long OCNLGJJEGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public Guid? JDNBKMOAAID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public bool IHEGBHBCBOB;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct MACKBHNNNHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public AsyncTaskMethodBuilder<AENKMJAJKCL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public PAIKJEGABFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public JKEPDDPEHIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter<GOMNLGPHFID> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<AENKMJAJKCL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x8459430", Offset = "0x8458430", VA = "0x188459430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x8459A00", Offset = "0x8458A00", VA = "0x188459A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class MAFANCHIOEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public MAFANCHIOEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x8459A70", Offset = "0x8458A70", VA = "0x188459A70")]
		internal object FKGOOKAEDDO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct CNIMCIEBHGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<GOMNLGPHFID> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public JKEPDDPEHIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public PAIKJEGABFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private MAFANCHIOEO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter<GOMNLGPHFID> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x8447DC0", Offset = "0x8446DC0", VA = "0x188447DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x84483B0", Offset = "0x84473B0", VA = "0x1884483B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct NMKOLFJJIDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder<AENKMJAJKCL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public JKEPDDPEHIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public PAIKJEGABFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public GOMNLGPHFID roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<LHKFBJIEMLN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x845BF70", Offset = "0x845AF70", VA = "0x18845BF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x845C4E0", Offset = "0x845B4E0", VA = "0x18845C4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class CCLJNOEBDFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public GOMNLGPHFID roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public CCLJNOEBDFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xE3FC80", Offset = "0xE3EC80", VA = "0x180E3FC80")]
		internal bool LIALJAHOPMN(IINCMBDAHBF sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x8447A70", Offset = "0x8446A70", VA = "0x188447A70")]
		internal object GNMDAJKJAAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x84479E0", Offset = "0x84469E0", VA = "0x1884479E0")]
		internal object EGCDAGOFLMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x8447B30", Offset = "0x8446B30", VA = "0x188447B30")]
		internal object KOBGHCMAGOH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class AHBCEABKJJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public CCLJNOEBDFL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public AHBCEABKJJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x8445040", Offset = "0x8444040", VA = "0x188445040")]
		internal object JLCECHHFJNG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct DIMLACEJNKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder<LHKFBJIEMLN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public GOMNLGPHFID roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public JKEPDDPEHIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public PAIKJEGABFG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private AHBCEABKJJI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private TaskAwaiter<LHKFBJIEMLN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private TaskAwaiter<DIKDBMHBMCM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8449040", Offset = "0x8448040", VA = "0x188449040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8449FF0", Offset = "0x8448FF0", VA = "0x188449FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class EDOIOLIPIOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public EDOIOLIPIOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x844CCC0", Offset = "0x844BCC0", VA = "0x18844CCC0")]
		internal object EPJJKEBJBLM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct NAGKMHFGMMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AsyncTaskMethodBuilder<LHKFBJIEMLN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public IINCMBDAHBF subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public JKEPDDPEHIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public PAIKJEGABFG dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private EDOIOLIPIOK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private TaskAwaiter<NEDLDDMDCHB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x845B100", Offset = "0x845A100", VA = "0x18845B100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x845B7D0", Offset = "0x845A7D0", VA = "0x18845B7D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private JHHKOFMOFFM DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private DMIMJPCFHKL NFFGNPJGBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private JPJGDPIBNOF EMPPLKPGDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private LAFKPKCKGAP HIDNGDFEDFI;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x84559E0", Offset = "0x84549E0", VA = "0x1884559E0", Slot = "5")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x8455880", Offset = "0x8454880", VA = "0x188455880", Slot = "4")]
	[AsyncStateMachine(typeof(MACKBHNNNHL))]
	public Task<AENKMJAJKCL> ABPAEOBCGGG(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, PAIKJEGABFG LEAIIPCAOIH, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x8455F20", Offset = "0x8454F20", VA = "0x188455F20")]
	[AsyncStateMachine(typeof(CNIMCIEBHGH))]
	private Task<GOMNLGPHFID> NEENNCEDKBA(PAIKJEGABFG LEAIIPCAOIH, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x8455DB0", Offset = "0x8454DB0", VA = "0x188455DB0")]
	[AsyncStateMachine(typeof(NMKOLFJJIDM))]
	private Task<AENKMJAJKCL> MCOPKEFNDLB(PAIKJEGABFG LEAIIPCAOIH, GOMNLGPHFID NMKJEHFFHPL, long NBOIIPJHEBJ, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x8455C40", Offset = "0x8454C40", VA = "0x188455C40")]
	[AsyncStateMachine(typeof(DIMLACEJNKO))]
	private Task<LHKFBJIEMLN> INEENPBDMKO(PAIKJEGABFG LEAIIPCAOIH, GOMNLGPHFID NMKJEHFFHPL, long NBOIIPJHEBJ, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x8455AD0", Offset = "0x8454AD0", VA = "0x188455AD0")]
	[AsyncStateMachine(typeof(NAGKMHFGMMG))]
	private Task<LHKFBJIEMLN> CFFADELLPGN(PAIKJEGABFG CEGAPABPHKJ, IINCMBDAHBF CHLJPLPCJPN, long NBOIIPJHEBJ, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public JKEPDDPEHIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[UnityEngine.Scripting.Preserve]
internal sealed class FJOCNBAHOIE : FAJHEKNGMOI, BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class GHKBKKDDJPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public DAEAHJMMAED request;

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public GHKBKKDDJPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8450BF0", Offset = "0x844FBF0", VA = "0x188450BF0")]
		internal object PNFOHIAFFDK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private struct EKNKAFDCFFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public AsyncTaskMethodBuilder<DAEAHJMMAED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public DAEAHJMMAED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public FJOCNBAHOIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public HPBALDPEPLO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x844EC30", Offset = "0x844DC30", VA = "0x18844EC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x844F240", Offset = "0x844E240", VA = "0x18844F240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct MFHADGHFGLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public AsyncTaskMethodBuilder<DAEAHJMMAED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public FJOCNBAHOIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public HPBALDPEPLO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TaskAwaiter<MOBLIKILLMD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x845A460", Offset = "0x8459460", VA = "0x18845A460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x845AA60", Offset = "0x8459A60", VA = "0x18845AA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class KLBPADFOJPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public DAEAHJMMAED request;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public KLBPADFOJPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x8457EE0", Offset = "0x8456EE0", VA = "0x188457EE0")]
		internal object EHGAKLGLKGK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct KAOMDOFCPIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder<DAEAHJMMAED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public DAEAHJMMAED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public FJOCNBAHOIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public HPBALDPEPLO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private AGHPMNKMEMJ <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private HKIMJPICHOF <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private TaskAwaiter<MOBLIKILLMD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x8457080", Offset = "0x8456080", VA = "0x188457080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x8457C70", Offset = "0x8456C70", VA = "0x188457C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private LDMAAALPMPJ NODDAHEDIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private NEBLBKINJDB IFJPDDIJFGB;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private OBOJAHIICMM IBFIAENFGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x84505E0", Offset = "0x844F5E0", VA = "0x1884505E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x8450210", Offset = "0x844F210", VA = "0x188450210", Slot = "8")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x8450480", Offset = "0x844F480", VA = "0x188450480", Slot = "4")]
	[AsyncStateMachine(typeof(EKNKAFDCFFN))]
	public Task<DAEAHJMMAED> IFFNFJKHIBD(DAEAHJMMAED HOOJNAMGGBC, HPBALDPEPLO HKMAGJLMBHL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x84506A0", Offset = "0x844F6A0", VA = "0x1884506A0", Slot = "5")]
	[AsyncStateMachine(typeof(MFHADGHFGLO))]
	public Task<DAEAHJMMAED> LMAIGOFMOJO(CancellationToken CBJPDIFOEKF, HPBALDPEPLO HKMAGJLMBHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x84503D0", Offset = "0x844F3D0", VA = "0x1884503D0", Slot = "6")]
	public GEHMKHHFLAO GIMLJHNDHNK(PPPBMGNNDNF IDGCKCFDFPA, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x84502A0", Offset = "0x844F2A0", VA = "0x1884502A0", Slot = "7")]
	public GEHMKHHFLAO GGMGBIFDEGF(PPPBMGNNDNF IDGCKCFDFPA, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x84507F0", Offset = "0x844F7F0", VA = "0x1884507F0")]
	[AsyncStateMachine(typeof(KAOMDOFCPIB))]
	private Task<DAEAHJMMAED> NLHCPBIKBMI(DAEAHJMMAED HOOJNAMGGBC, HPBALDPEPLO HKMAGJLMBHL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x385B380", Offset = "0x385A380", VA = "0x18385B380")]
	private static byte[] EBMLCGPIHNA(DAEAHJMMAED NAAMEAFIHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public FJOCNBAHOIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[UnityEngine.Scripting.Preserve]
internal sealed class BHJHMPAIKBF : KPFKDIBGGLC, BGMLLKPPOFE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private IAEPKIALGDD LEAFBFEDNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private LDMAAALPMPJ NODDAHEDIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private GFAFJAJHEAL OHEPFLBIHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private ODFHIPDMKON HFHKNFCAINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private JHHKOFMOFFM DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private GIALCOICGEG GABNHHFPLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private CGGJELIFDNE BEGEKIBIHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private DMIMJPCFHKL NFFGNPJGBOO;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private IJPJAKACFOB BJABPNAMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x8445790", Offset = "0x8444790", VA = "0x188445790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static GGIHIJCCBHJ JPLAKFPJJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x84457F0", Offset = "0x84447F0", VA = "0x1884457F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x84453A0", Offset = "0x84443A0", VA = "0x1884453A0", Slot = "6")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x8445230", Offset = "0x8444230", VA = "0x188445230", Slot = "4")]
	public GGIHIJCCBHJ AECOKMGPPFN(AIPAHMNCJKP FCDLIEFOPHH, MCEHODFGIME IKONCMMACKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x8445510", Offset = "0x8444510", VA = "0x188445510", Slot = "5")]
	public GGIHIJCCBHJ BLCKACIGLDJ(AIPAHMNCJKP HIHGMFDAMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x84457E0", Offset = "0x84447E0", VA = "0x1884457E0")]
	private static GGIHIJCCBHJ HNEINKPPENO(GKOJCGDILMH DKBCGBFNIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public BHJHMPAIKBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class OANABFNNJPA : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x845C5B0", Offset = "0x845B5B0", VA = "0x18845C5B0")]
	public OANABFNNJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x76761B0", Offset = "0x76751B0", VA = "0x1876761B0")]
	public OANABFNNJPA(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[UnityEngine.Scripting.Preserve]
internal sealed class PJPNDIHICFN : KKJBEPHJCKB, BGMLLKPPOFE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct DHCJDMIINJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public AsyncTaskMethodBuilder<GGIHIJCCBHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public PJPNDIHICFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public OPPGGNKKPPF autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private LDCGKGNFMMI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private OIFFOMNPKAJ <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private TaskAwaiter<GGIHIJCCBHJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x8448480", Offset = "0x8447480", VA = "0x188448480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x8448FD0", Offset = "0x8447FD0", VA = "0x188448FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct IANLGHIKHIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public PJPNDIHICFN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8452C10", Offset = "0x8451C10", VA = "0x188452C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x8453370", Offset = "0x8452370", VA = "0x188453370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct MNGPNPFMFIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public PJPNDIHICFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x845AB90", Offset = "0x8459B90", VA = "0x18845AB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x845B0A0", Offset = "0x845A0A0", VA = "0x18845B0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct HPGCKPODPPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public PJPNDIHICFN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8452460", Offset = "0x8451460", VA = "0x188452460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x8452BB0", Offset = "0x8451BB0", VA = "0x188452BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct CFPMFHBBBCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public PJPNDIHICFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x8447BC0", Offset = "0x8446BC0", VA = "0x188447BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x8447D60", Offset = "0x8446D60", VA = "0x188447D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct HHDMHJACKJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public PJPNDIHICFN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8450CB0", Offset = "0x844FCB0", VA = "0x188450CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x84513E0", Offset = "0x84503E0", VA = "0x1884513E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct PGEBGCHFADO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public PJPNDIHICFN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x845ED90", Offset = "0x845DD90", VA = "0x18845ED90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x845F200", Offset = "0x845E200", VA = "0x18845F200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct MHBANPPLFEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public PJPNDIHICFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public KNEDGBILGPM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private LDCGKGNFMMI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x8474320", Offset = "0x8473320", VA = "0x188474320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x84748C0", Offset = "0x84738C0", VA = "0x1884748C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private LDMAAALPMPJ NODDAHEDIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private JHHKOFMOFFM DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private FAJHEKNGMOI OBECGFDEJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private GFAFJAJHEAL OHEPFLBIHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private CGGJELIFDNE BEGEKIBIHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private CancellationTokenSource JDDPBFMCAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private Task AMLMIFEHKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private TaskCompletionSource<int> LBMEECBJKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private int DJHNKIKMIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private int GGDFANKHDBF;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x84600B0", Offset = "0x845F0B0", VA = "0x1884600B0", Slot = "6")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1298390", Offset = "0x1297390", VA = "0x181298390", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x8460350", Offset = "0x845F350", VA = "0x188460350")]
	private void DGNHLKMBOLJ(float HHKEOHHPHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x84606D0", Offset = "0x845F6D0", VA = "0x1884606D0", Slot = "4")]
	[AsyncStateMachine(typeof(DHCJDMIINJK))]
	public Task<GGIHIJCCBHJ> FEPBIOOICAE(OPPGGNKKPPF HIIKALLGCLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x8460ED0", Offset = "0x845FED0", VA = "0x188460ED0", Slot = "5")]
	[AsyncStateMachine(typeof(IANLGHIKHIN))]
	public Task NIIEIIOKINC([Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x1298390", Offset = "0x1297390", VA = "0x181298390")]
	public void HKFBEGCLNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x8460C60", Offset = "0x845FC60", VA = "0x188460C60")]
	private OIFFOMNPKAJ MJGNFDKDBML(OPPGGNKKPPF HIIKALLGCLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x8460800", Offset = "0x845F800", VA = "0x188460800")]
	[AsyncStateMachine(typeof(MNGPNPFMFIN))]
	private Task IFJHPBFOLNO(CancellationToken EBOFCHGLLPK, int GMMLOKJHPEI, PFBDGKHFNEC PEEMGACEOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x8460FC0", Offset = "0x845FFC0", VA = "0x188460FC0")]
	[AsyncStateMachine(typeof(HPGCKPODPPM))]
	private Task OMANIIFCEDD(CancellationToken EBOFCHGLLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x8460260", Offset = "0x845F260", VA = "0x188460260")]
	[AsyncStateMachine(typeof(CFPMFHBBBCE))]
	private Task BDLEBBJIFOP([Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x84608F0", Offset = "0x845F8F0", VA = "0x1884608F0")]
	[AsyncStateMachine(typeof(HHDMHJACKJK))]
	private Task JBAPJPEPNDI(CancellationToken EBOFCHGLLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x8460DD0", Offset = "0x845FDD0", VA = "0x188460DD0")]
	[AsyncStateMachine(typeof(PGEBGCHFADO))]
	private Task NDEAKDENPEL(CancellationToken FBKKBOAHBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x8460430", Offset = "0x845F430", VA = "0x188460430")]
	private Task DHCMPIJNCOF(KNEDGBILGPM EDHLLDFNCFM, CancellationToken EBOFCHGLLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x84605C0", Offset = "0x845F5C0", VA = "0x1884605C0")]
	[AsyncStateMachine(typeof(MHBANPPLFEL))]
	private Task DILDDFBPNIP(KNEDGBILGPM EDHLLDFNCFM, CancellationToken EBOFCHGLLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x84609E0", Offset = "0x845F9E0", VA = "0x1884609E0")]
	private bool KHANCPFOBAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PJPNDIHICFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[UnityEngine.Scripting.Preserve]
internal class PGMDFBNJGJG : ODFHIPDMKON, BGMLLKPPOFE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct KFBAGFPEBPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public PGMDFBNJGJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private LDCGKGNFMMI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x84719D0", Offset = "0x84709D0", VA = "0x1884719D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x8471F80", Offset = "0x8470F80", VA = "0x188471F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private MBAMAOLNFEE MHAEOAHGKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private KPFKDIBGGLC FAPAMCLMPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private FAJHEKNGMOI OBECGFDEJPK;

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x847C020", Offset = "0x847B020", VA = "0x18847C020", Slot = "6")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x847C300", Offset = "0x847B300", VA = "0x18847C300", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x847BF20", Offset = "0x847AF20", VA = "0x18847BF20", Slot = "5")]
	[AsyncStateMachine(typeof(KFBAGFPEBPI))]
	public Task AHIIEDFIFFE(string IGFKNGAMFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x847C490", Offset = "0x847B490", VA = "0x18847C490", Slot = "4")]
	public GGIHIJCCBHJ KHANCPFOBAK(AIPAHMNCJKP FCDLIEFOPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x847C350", Offset = "0x847B350", VA = "0x18847C350")]
	private FGADKJHOMIE JLNJNPLNNEF(string IGFKNGAMFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PGMDFBNJGJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class ILNMCFBCOOG
{
	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x8470AA0", Offset = "0x846FAA0", VA = "0x188470AA0")]
	public static void HFGPHFCKLIA(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x8470860", Offset = "0x846F860", VA = "0x188470860")]
	internal static void BNIEDJBNNHM(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x84709C0", Offset = "0x846F9C0", VA = "0x1884709C0")]
	internal static void CEINGPOHGDF(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x8470CE0", Offset = "0x846FCE0", VA = "0x188470CE0")]
	internal static void NFPBFHFBOKG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x3884FF0", Offset = "0x3883FF0", VA = "0x183884FF0")]
	private static void PIHOAABHJNO<Interface, Impl, Interface>(AINJBKKEAIL NELIKBMJKPH) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class CGCAIAMLOIL : KOJGPGKOAIB<DAEAHJMMAED>
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class JJKHMACFNED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public DAEAHJMMAED message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public JJKHMACFNED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x84715B0", Offset = "0x84705B0", VA = "0x1884715B0")]
		internal object PEEMBAAGIPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly CGCAIAMLOIL MLIJHBGBMKP;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x8466A70", Offset = "0x8465A70", VA = "0x188466A70")]
	public ExitGames.Client.Photon.Hashtable DFNAEDFOBIJ(DAEAHJMMAED NAAMEAFIHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x8466B00", Offset = "0x8465B00", VA = "0x188466B00", Slot = "5")]
	protected override void ONCMPAIJPBO(DAEAHJMMAED NAAMEAFIHJI, IDictionary<object, object> APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x8466590", Offset = "0x8465590", VA = "0x188466590", Slot = "6")]
	public override DAEAHJMMAED AKDPGDCBDMI(IDictionary<object, object> APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x8466480", Offset = "0x8465480", VA = "0x188466480")]
	private static void AHIMDJPCPBN(string AIAOPAOOPLP, DAEAHJMMAED NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x8466CD0", Offset = "0x8465CD0", VA = "0x188466CD0")]
	public CGCAIAMLOIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x84667C0", Offset = "0x84657C0", VA = "0x1884667C0")]
	[CompilerGenerated]
	internal static string BKBDEPNJIAO(AENKMJAJKCL DGHLABNPIEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class PCEGGICBHLO
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static GGIHIJCCBHJ JPLAKFPJJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x847B6A0", Offset = "0x847A6A0", VA = "0x18847B6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x847B700", Offset = "0x847A700", VA = "0x18847B700")]
	public static bool JADGJIAIEEB(this GGIHIJCCBHJ MNJLOAEFEJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x847B640", Offset = "0x847A640", VA = "0x18847B640")]
	public static GGIHIJCCBHJ HNEINKPPENO(GKOJCGDILMH ECOONOEHGGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x847B440", Offset = "0x847A440", VA = "0x18847B440")]
	public static GGIHIJCCBHJ EBGJDGDECMJ(IEnumerable<GGIHIJCCBHJ> KOPHNHFIBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x847B1E0", Offset = "0x847A1E0", VA = "0x18847B1E0")]
	public static string BKEKIIKKJAK(this GGIHIJCCBHJ OBOOAPELMPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public abstract class JFLKEALDLHG : PKEELNCJLNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public delegate GGIHIJCCBHJ MNMAAAIFNNE([NotNull] AIPAHMNCJKP DODIIHCCFIJ);

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class MBLFCEFGMKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public AIPAHMNCJKP photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public MBLFCEFGMKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x154A830", Offset = "0x1549830", VA = "0x18154A830")]
		internal GGIHIJCCBHJ DLPLHGDACJM(MNMAAAIFNNE v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	private bool DPFEMHMCJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038E")]
	protected readonly HashSet<MNMAAAIFNNE> NKPICFAAHJA;

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x84711C0", Offset = "0x84701C0", VA = "0x1884711C0", Slot = "4")]
	public void GFGGHIPHBFC(MNMAAAIFNNE EDPLIBFIBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x84714C0", Offset = "0x84704C0", VA = "0x1884714C0", Slot = "5")]
	public void KKFKAFOHICN(MNMAAAIFNNE EDPLIBFIBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x8471170", Offset = "0x8470170", VA = "0x188471170", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x8471220", Offset = "0x8470220", VA = "0x188471220")]
	protected GGIHIJCCBHJ KCIKHHHEPLE(AIPAHMNCJKP HIHGMFDAMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x8471520", Offset = "0x8470520", VA = "0x188471520")]
	protected JFLKEALDLHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public class IDAEODOMAAH : JFLKEALDLHG, IAEPKIALGDD, PKEELNCJLNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class GOICOPBMFKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public GGIHIJCCBHJ result;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public GOICOPBMFKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x846FCE0", Offset = "0x846ECE0", VA = "0x18846FCE0")]
		internal object EHKGBDGDBGO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x8467380", Offset = "0x8466380", VA = "0x188467380")]
	[UnityEngine.Scripting.Preserve]
	public IDAEODOMAAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x8470630", Offset = "0x846F630", VA = "0x188470630", Slot = "8")]
	public GGIHIJCCBHJ CAAEDFHFHDD(AIPAHMNCJKP HIHGMFDAMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class DHFBDLMJJHA : JFLKEALDLHG, MBAMAOLNFEE, PKEELNCJLNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class JBOCCOMDCOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public GGIHIJCCBHJ result;

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public JBOCCOMDCOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x8471110", Offset = "0x8470110", VA = "0x188471110")]
		internal object OENAHAPEMMO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x8467380", Offset = "0x8466380", VA = "0x188467380")]
	[UnityEngine.Scripting.Preserve]
	public DHFBDLMJJHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x8467270", Offset = "0x8466270", VA = "0x188467270", Slot = "8")]
	public GGIHIJCCBHJ KHANCPFOBAK(AIPAHMNCJKP MCADOGGHICO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal static class PBFHPJNCIMB
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class CLGKNHEEDIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public LDCGKGNFMMI<string> timer;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public CLGKNHEEDIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x8466F70", Offset = "0x8465F70", VA = "0x188466F70")]
		internal object JAGPAJGFINL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x847B040", Offset = "0x847A040", VA = "0x18847B040")]
	public static LDCGKGNFMMI<string> FJCAOCFABJI(JBBHIJHGEPM PAJIGEJCNAP, [Optional] string FPFAFHGGBCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x847AF80", Offset = "0x8479F80", VA = "0x18847AF80")]
	public static void FEPCEDCODDP(LDCGKGNFMMI<string> DCCJGOAMNIL, JBBHIJHGEPM PAJIGEJCNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x847B120", Offset = "0x847A120", VA = "0x18847B120")]
	public static string LKECEAPNCID(DAEAHJMMAED CAGMDMPFBND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal static class EIEDOBBOKPN
{
	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x846A1A0", Offset = "0x84691A0", VA = "0x18846A1A0")]
	public static void GMOLLDHBBJD(this LDMAAALPMPJ NODDAHEDIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x846A190", Offset = "0x8469190", VA = "0x18846A190")]
	public static void CFFJBGFNFHJ(this LDMAAALPMPJ NODDAHEDIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x846A1B0", Offset = "0x84691B0", VA = "0x18846A1B0")]
	private static void HJAPBBALAED(this LDMAAALPMPJ NODDAHEDIAD, bool AOENBMECMMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class EPDEFBAADFM : COJCHFJKFGH, OCEOKOPOIDE, NOCKFOJODFM, CIKJMMPNKIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	private readonly OCEOKOPOIDE OOPGEEKAHCE;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public AIPAHMNCJKP GOBODFFBLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x846A820", Offset = "0x8469820", VA = "0x18846A820", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int CBPDIDBMAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x846AB40", Offset = "0x8469B40", VA = "0x18846AB40", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int GDMDCOLJKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x846A730", Offset = "0x8469730", VA = "0x18846A730", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool CHECBKFCEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int BGJGEDOMAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xBDE1B0", Offset = "0xBDD1B0", VA = "0x180BDE1B0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event MBMFLDLJJEF.NMFDOCPLBMO OMEIKEFOGOL
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event INOLMHODKPJ DFKNIPLLABH
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x846A870", Offset = "0x8469870", VA = "0x18846A870", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x846AAA0", Offset = "0x8469AA0", VA = "0x18846AAA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> PGGHJNOGJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<AIPAHMNCJKP> BOFMJJJDNII
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action IGNBBEIMHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x846A690", Offset = "0x8469690", VA = "0x18846A690", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x846A780", Offset = "0x8469780", VA = "0x18846A780", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0xCEF8D0", Offset = "0xCEE8D0", VA = "0x180CEF8D0")]
	public EPDEFBAADFM(OCEOKOPOIDE OOPGEEKAHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x846A910", Offset = "0x8469910", VA = "0x18846A910", Slot = "8")]
	public bool HCJMLNIBOLL(byte OGKCOMEHLBF, object ECDOALGCOGB, LNHCHEGJGAC BPOCFKJCMPI, SendOptions OIHBBNBFCAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x846A9C0", Offset = "0x84699C0", VA = "0x18846A9C0", Slot = "16")]
	public AIPAHMNCJKP IPELDIICOHI(int BEKCOFDFFEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "19")]
	public void DKPIKMBPINA(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "20")]
	public void ALMPMCJJIOE(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "21")]
	public void BNNDCGBBCIN(object EJJDDFFADPC, bool OCMLCOPEGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x846AB90", Offset = "0x8469B90", VA = "0x18846AB90", Slot = "22")]
	public IDisposable PLDDPPBKMIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "23")]
	private bool FGECOFDOFAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "24")]
	public void FGCMBDGGIHH(StringBuilder JHKAJNJALDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0xF59060", Offset = "0xF58060", VA = "0x180F59060", Slot = "25")]
	public bool MBCAHMDJCAI(bool BOFOJGDGLOP, [Out] string JHEMEKBLBHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0xF04570", Offset = "0xF03570", VA = "0x180F04570", Slot = "28")]
	public void EDIOHFHBDHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal struct LPHKFBBGLKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	private readonly IDictionary<object, object> NKBJHKLGFDP;

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0xCFF9B0", Offset = "0xCFE9B0", VA = "0x180CFF9B0")]
	public LPHKFBBGLKG(IDictionary<object, object> NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x8473800", Offset = "0x8472800", VA = "0x188473800")]
	public bool DIIPOHHAKKD([Out] DAEAHJMMAED NAAMEAFIHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x8473AE0", Offset = "0x8472AE0", VA = "0x188473AE0")]
	public Guid PILGNJADEJL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x84739A0", Offset = "0x84729A0", VA = "0x1884739A0")]
	public GGIHIJCCBHJ HPDKBILAJJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x84738B0", Offset = "0x84728B0", VA = "0x1884738B0")]
	public static ExitGames.Client.Photon.Hashtable FLLMCNLHKNL(DAEAHJMMAED NAAMEAFIHJI, GGIHIJCCBHJ MNJLOAEFEJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal static class EPEHKPEOINA
{
	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x846ABE0", Offset = "0x8469BE0", VA = "0x18846ABE0")]
	public static bool HPFGKIHMNNP(this PAIKJEGABFG HJHEMAOEAHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct MFIEBJJDOKB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct BAPEODFIGHC : IAsyncStateMachine
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
		public MFIEBJJDOKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x8463C80", Offset = "0x8462C80", VA = "0x188463C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x8463E60", Offset = "0x8462E60", VA = "0x188463E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	private readonly CancellationTokenSource CLDKCMPEHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	private bool DPFEMHMCJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	private Task BGKKDAHMDLM;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool LKIDIFGHMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x84741C0", Offset = "0x84731C0", VA = "0x1884741C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x84741F0", Offset = "0x84731F0", VA = "0x1884741F0")]
	public MFIEBJJDOKB(CancellationToken CBJPDIFOEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x8474060", Offset = "0x8473060", VA = "0x188474060")]
	[AsyncStateMachine(typeof(BAPEODFIGHC))]
	public Task DIENEBAEOMC(Func<CancellationToken, List<Task>> HBFHHJFANBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x8474170", Offset = "0x8473170", VA = "0x188474170", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public readonly struct KLLJHPOCLHE<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct ECKBFDGKAGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<PFOMDLOAMOL<TData>, OGMCLKGLBPG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public KLLJHPOCLHE<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private TaskAwaiter<HHHCCNLMPJL<PFOMDLOAMOL<TData>, OGMCLKGLBPG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x44BA920", Offset = "0x44B9920", VA = "0x1844BA920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x44BB500", Offset = "0x44BA500", VA = "0x1844BB500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	private readonly CEFIABFPECO<TGetDataArg, TData> IJFOHHKJJKM;

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0xCFF9B0", Offset = "0xCFE9B0", VA = "0x180CFF9B0")]
	internal KLLJHPOCLHE(CEFIABFPECO<TGetDataArg, TData> MMCKJCAOGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x4FE95D0", Offset = "0x4FE85D0", VA = "0x184FE95D0")]
	[AsyncStateMachine(typeof(KLLJHPOCLHE<, >.ECKBFDGKAGC))]
	public Task<HHHCCNLMPJL<PFOMDLOAMOL<TData>, OGMCLKGLBPG>> DJPILFFGEMC(TGetDataArg GIOLPIPFPPJ, string CCKBGGOCFOE, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public static class FMELJIPNMJG
{
	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x368FB90", Offset = "0x368EB90", VA = "0x18368FB90")]
	public static KLLJHPOCLHE<TGetDataArg, TData> ACADPGMDEBE<TGetDataArg, TData>(CEFIABFPECO<TGetDataArg, TData> MMCKJCAOGBM)
	{
		return default(KLLJHPOCLHE<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public struct HBMPNPEHDHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public readonly int BLPCOOECADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public readonly int? KLBAABHABHI;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x50934F0", Offset = "0x50924F0", VA = "0x1850934F0")]
	public HBMPNPEHDHN(int DAOAPLFBLDC, [Optional] int? HPMMEOADALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x846FD40", Offset = "0x846ED40", VA = "0x18846FD40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface OBNCDKECHJH<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAPMPDILBOF();

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OBNCDKECHJH<T> JPIMILOLNGI(string NCGJCKHFLGN);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OBNCDKECHJH<T> NDBEEFGNKEA(DHNONLKKJIP<T> KKBFPFNALJK);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OBNCDKECHJH<T> CMLECHKKPMB(int LELALGHIBFL);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OBNCDKECHJH<T> LDOIJOOMFKD(int LELALGHIBFL, POGDNIPDDOF<T> LJJBCIIDJIP);
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface IBHJLAMHBCG
{
	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OBNCDKECHJH<T> EGGMNEPKEGO<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LADNFHMCJKC CDGPNPFGMIJ(Exception APEPCFJIAMB);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HBMPNPEHDHN BDKPEGJDMJP(Exception APEPCFJIAMB);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public delegate string DHNONLKKJIP<in T>(T APEPCFJIAMB) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public delegate int POGDNIPDDOF<in T>(T APEPCFJIAMB) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class OELJFAPHCCJ : IBHJLAMHBCG
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private delegate string BPLODBJBKOH(Exception APEPCFJIAMB);

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private delegate int GJANCOLLMJG(Exception APEPCFJIAMB);

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class DIOPCAPOBKD<T> : OBNCDKECHJH<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		[CompilerGenerated]
		private sealed class PDHJMJDJGOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public PDHJMJDJGOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			internal string HEIHGGHHBAA(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000100")]
		[CompilerGenerated]
		private sealed class GFEMHPIPJID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public DHNONLKKJIP<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public GFEMHPIPJID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x44E14D0", Offset = "0x44E04D0", VA = "0x1844E14D0")]
			internal string GHILDNCJHDJ(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class EJLDMBHNMIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public POGDNIPDDOF<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public EJLDMBHNMIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x44E14D0", Offset = "0x44E04D0", VA = "0x1844E14D0")]
			internal int PCOAEHFLMPN(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private readonly OELJFAPHCCJ IMMBIKKFMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private readonly Type BONIGKDFHKB;

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6A60710", Offset = "0x6A5F710", VA = "0x186A60710")]
		internal DIOPCAPOBKD(OELJFAPHCCJ IMMBIKKFMEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x6A60480", Offset = "0x6A5F480", VA = "0x186A60480", Slot = "4")]
		public void KAPMPDILBOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x6A60360", Offset = "0x6A5F360", VA = "0x186A60360", Slot = "5")]
		public OBNCDKECHJH<T> JPIMILOLNGI(string NCGJCKHFLGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6A605F0", Offset = "0x6A5F5F0", VA = "0x186A605F0", Slot = "6")]
		public OBNCDKECHJH<T> NDBEEFGNKEA(DHNONLKKJIP<T> KKBFPFNALJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6A60320", Offset = "0x6A5F320", VA = "0x186A60320", Slot = "7")]
		public OBNCDKECHJH<T> CMLECHKKPMB(int LELALGHIBFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A604B0", Offset = "0x6A5F4B0", VA = "0x186A604B0", Slot = "8")]
		public OBNCDKECHJH<T> LDOIJOOMFKD(int LELALGHIBFL, POGDNIPDDOF<T> LJJBCIIDJIP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class OLPMKHLFKDJ<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private bool EHOJJGJOJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly List<Type> CBOMCCCMIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly Dictionary<Type, TVal> HCIMFFEAFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly Dictionary<Type, int> OLBOPINIDKL;

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public IReadOnlyList<Type> NHLCMINJMEG
		{
			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x5530280", Offset = "0x552F280", VA = "0x185530280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x5530780", Offset = "0x552F780", VA = "0x185530780")]
		public OLPMKHLFKDJ(Dictionary<Type, int> OLBOPINIDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x5530540", Offset = "0x552F540", VA = "0x185530540")]
		public void IIGLPCDPOEE(Type OEHHKNIGGMI, TVal GCDAJLDGOIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x5530160", Offset = "0x552F160", VA = "0x185530160")]
		public bool AGMILAFMHHE(Type BONIGKDFHKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x5530600", Offset = "0x552F600", VA = "0x185530600")]
		public bool JAOEPNGFPMK(TVal OHLIHBDBKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x4060150", Offset = "0x405F150", VA = "0x184060150")]
		public TVal PHDCGNDDLGA(Type MLCOGCMJLBB)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x55303E0", Offset = "0x552F3E0", VA = "0x1855303E0")]
		[CompilerGenerated]
		private int FPJCMKLCGJK(Type KPKGOLFBDHB, Type JJKBILGLHJC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class PEGJJGKHENH : IEnumerable<HBMPNPEHDHN>, IEnumerable, IEnumerator<HBMPNPEHDHN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private HBMPNPEHDHN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public OELJFAPHCCJ <>4__this;

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
		private IEnumerator<HBMPNPEHDHN> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		private HBMPNPEHDHN System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x4553C20", Offset = "0x4552C20", VA = "0x184553C20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(HBMPNPEHDHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x847BD80", Offset = "0x847AD80", VA = "0x18847BD80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xE8B5B0", Offset = "0xE8A5B0", VA = "0x180E8B5B0")]
		[DebuggerHidden]
		public PEGJJGKHENH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x847BDD0", Offset = "0x847ADD0", VA = "0x18847BDD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x847B770", Offset = "0x847A770", VA = "0x18847B770", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x847B720", Offset = "0x847A720", VA = "0x18847B720")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x847BC20", Offset = "0x847AC20", VA = "0x18847BC20")]
		private void PJDCPOGKKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x847BD30", Offset = "0x847AD30", VA = "0x18847BD30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x847BC70", Offset = "0x847AC70", VA = "0x18847BC70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HBMPNPEHDHN> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x847BC70", Offset = "0x847AC70", VA = "0x18847BC70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private static readonly HBMPNPEHDHN HNEEEIKLENM;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private static readonly Dictionary<Type, int> MCKEJJLMJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly HashSet<Type> FMBDHNMNIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private readonly OLPMKHLFKDJ<int> LJCKLBEPGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private readonly OLPMKHLFKDJ<GJANCOLLMJG> AIEEICIECNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly OLPMKHLFKDJ<BPLODBJBKOH> NDPGJCPFFNK;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x8478A30", Offset = "0x8477A30", VA = "0x188478A30")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	internal static void MAKIPFCGLCJ(AINJBKKEAIL PJLGMBBLBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x8478CC0", Offset = "0x8477CC0", VA = "0x188478CC0")]
	[RecRoom.NoEngine.Common.Preserve]
	public OELJFAPHCCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x36A7050", Offset = "0x36A6050", VA = "0x1836A7050", Slot = "4")]
	public OBNCDKECHJH<T> EGGMNEPKEGO<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x8477FB0", Offset = "0x8476FB0", VA = "0x188477FB0", Slot = "5")]
	public LADNFHMCJKC CDGPNPFGMIJ(Exception APEPCFJIAMB)
	{
		return default(LADNFHMCJKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x8477B90", Offset = "0x8476B90", VA = "0x188477B90", Slot = "6")]
	public HBMPNPEHDHN BDKPEGJDMJP(Exception? APEPCFJIAMB)
	{
		return default(HBMPNPEHDHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x8477D90", Offset = "0x8476D90", VA = "0x188477D90", Slot = "7")]
	[IteratorStateMachine(typeof(PEGJJGKHENH))]
	public IEnumerable<HBMPNPEHDHN> BJGEIKPLDGM(Exception APEPCFJIAMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x8478AA0", Offset = "0x8477AA0", VA = "0x188478AA0", Slot = "8")]
	public string MFGJAHBDACG(Exception? APEPCFJIAMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x8478120", Offset = "0x8477120", VA = "0x188478120")]
	private string HFBHMPFBJKB(AggregateException DDPJLHLLDEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x8478680", Offset = "0x8477680", VA = "0x188478680")]
	private void KJCPOFLAPFE(Type BONIGKDFHKB, int LELALGHIBFL, GJANCOLLMJG? DMFEAKDOMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x8478430", Offset = "0x8477430", VA = "0x188478430")]
	private void IPJLINNODJL(Type BONIGKDFHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x84778C0", Offset = "0x84768C0", VA = "0x1884778C0")]
	private void AIJAMNCOFME(Type BONIGKDFHKB, BPLODBJBKOH GHBBDPKACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x8477E30", Offset = "0x8476E30", VA = "0x188477E30")]
	private static int CANBAEMELDP(Type BONIGKDFHKB, Dictionary<Type, int> OLBOPINIDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x39CE4E0", Offset = "0x39CD4E0", VA = "0x1839CE4E0")]
	private static bool BKNCNAFKDCN<TVal>(OLPMKHLFKDJ<TVal> DHLGAIMCINE, Type BONIGKDFHKB, [Out] TVal OHLIHBDBKCE) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x8478040", Offset = "0x8477040", VA = "0x188478040")]
	[CompilerGenerated]
	internal static int HDGPDNHHEDC(Type COLGODNEKAJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public struct LADNFHMCJKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public readonly HBMPNPEHDHN MAOIEOGFFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public readonly string HFGBEFOGKEI;

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x84729A0", Offset = "0x84719A0", VA = "0x1884729A0")]
	public LADNFHMCJKC(string OLMDHHIGBJB, HBMPNPEHDHN LELALGHIBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x8472900", Offset = "0x8471900", VA = "0x188472900")]
	public string IFFMJMELLPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class PLHOCFLCCME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	private readonly DBENBDOGMLE HOEGGBMBFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	private string NBIDDPLGEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	private long? NLGHOAENGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	private long? DGJJNNDKENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	private long? MJEDJOPIOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private string AICIKMEEBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	private IHHBKLENLMK DNCDPIDDNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private long? GOJNKGPKLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private bool LGMGMCBJBEK;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public string MHGFJNIFJPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public long KMIHABKOEPN
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x847C6E0", Offset = "0x847B6E0", VA = "0x18847C6E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public long LDAENLHGJFE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x847CBA0", Offset = "0x847BBA0", VA = "0x18847CBA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public long CHPEOODLDHE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x847C680", Offset = "0x847B680", VA = "0x18847C680")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public string OODJGDGPLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x847C640", Offset = "0x847B640", VA = "0x18847C640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public IHHBKLENLMK BFNPKMIEPDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xD62EF0", Offset = "0xD61EF0", VA = "0x180D62EF0")]
		get
		{
			return default(IHHBKLENLMK);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x847C550", Offset = "0x847B550", VA = "0x18847C550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public long NGBPDOGKLPC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x847CB40", Offset = "0x847BB40", VA = "0x18847CB40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x847D380", Offset = "0x847C380", VA = "0x18847D380")]
	[UnityEngine.Scripting.Preserve]
	public PLHOCFLCCME([DJIFKCCBBND(null)] DBENBDOGMLE HOEGGBMBFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x847CC00", Offset = "0x847BC00", VA = "0x18847CC00")]
	private void KGGGDHMOBFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x847CEF0", Offset = "0x847BEF0", VA = "0x18847CEF0")]
	public void MAAKGIGDIKI(long CINEDGEJAIA, long NBOIIPJHEBJ, [Optional] long? CFBANPJJEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x847CE50", Offset = "0x847BE50", VA = "0x18847CE50")]
	public void LKHMAONAMFE(long CFBANPJJEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x847CAC0", Offset = "0x847BAC0", VA = "0x18847CAC0")]
	public void DAGKPKEJMDP(string PCMGNKOHCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x847C740", Offset = "0x847B740", VA = "0x18847C740")]
	public void CPCGPAEHOGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal class GEHMKHHFLAO : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct KIEMHJIHHKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public AsyncTaskMethodBuilder<DAEAHJMMAED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public DAEAHJMMAED roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public GEHMKHHFLAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private TaskAwaiter<OBOJAHIICMM.ELCFJMNDKFL<DAEAHJMMAED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x8472100", Offset = "0x8471100", VA = "0x188472100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x8472640", Offset = "0x8471640", VA = "0x188472640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct IMCLOJAIIGA<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private sealed class DHDPFPJOFKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public DAEAHJMMAED roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public DHDPFPJOFKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x8467190", Offset = "0x8466190", VA = "0x188467190")]
		internal DAEAHJMMAED GHBFFMNKMHE(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct FNMAIACOEEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public AsyncTaskMethodBuilder<OBOJAHIICMM.ELCFJMNDKFL<DAEAHJMMAED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public DAEAHJMMAED roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public GEHMKHHFLAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private AGHPMNKMEMJ <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private TaskAwaiter<OBOJAHIICMM.ELCFJMNDKFL<DAEAHJMMAED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x846C390", Offset = "0x846B390", VA = "0x18846C390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x846C9A0", Offset = "0x846B9A0", VA = "0x18846C9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct BPAHHIIFBNB<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public GEHMKHHFLAO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x63B40F0", Offset = "0x63B30F0", VA = "0x1863B40F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x44BB500", Offset = "0x44BA500", VA = "0x1844BB500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct BFIMGJPDFEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public GEHMKHHFLAO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x84649C0", Offset = "0x84639C0", VA = "0x1884649C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x8464CA0", Offset = "0x8463CA0", VA = "0x188464CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private sealed class IHDJFAIBPKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public IHDJFAIBPKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x8470740", Offset = "0x846F740", VA = "0x188470740")]
		internal object AFMLJNCBDCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x84707A0", Offset = "0x846F7A0", VA = "0x1884707A0")]
		internal bool GGAGAEOMHIP(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class NCIBCLGAKHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NCIBCLGAKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x84754C0", Offset = "0x84744C0", VA = "0x1884754C0")]
		internal object FOLGOKHKCBP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class LDEGFIGNGNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public LDEGFIGNGNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x84729C0", Offset = "0x84719C0", VA = "0x1884729C0")]
		internal object LDDEAENEAFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class AEIBDHJAJDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public AEIBDHJAJDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x84632E0", Offset = "0x84622E0", VA = "0x1884632E0")]
		internal object CMJFMEAGFLI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class LABODMFDCOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public GEHMKHHFLAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public LABODMFDCOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x84726B0", Offset = "0x84716B0", VA = "0x1884726B0")]
		internal object PEEMBAAGIPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private static readonly Guid DFNNHGGDCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public readonly PPPBMGNNDNF AAIHBKEDJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly OBOJAHIICMM HAHJDNHBDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly NOCKFOJODFM NODDAHEDIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private readonly CIKJMMPNKIM CAKMPKKLEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private bool LKKCCMMEAMB;

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x846ED80", Offset = "0x846DD80", VA = "0x18846ED80")]
	public GEHMKHHFLAO(PPPBMGNNDNF AOHGJNGCBBI, OBOJAHIICMM HAHJDNHBDND, NOCKFOJODFM NODDAHEDIAD, CIKJMMPNKIM CAKMPKKLEEB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x846DFF0", Offset = "0x846CFF0", VA = "0x18846DFF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x846E8A0", Offset = "0x846D8A0", VA = "0x18846E8A0")]
	public void IHEJEEPNJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x846EAD0", Offset = "0x846DAD0", VA = "0x18846EAD0")]
	public void KLGEEIPFGIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x846DF30", Offset = "0x846CF30", VA = "0x18846DF30")]
	public void BKMNPGHPHFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x846DC90", Offset = "0x846CC90", VA = "0x18846DC90")]
	[AsyncStateMachine(typeof(KIEMHJIHHKH))]
	internal Task<DAEAHJMMAED> APOJKNDKELP(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, DAEAHJMMAED CAGMDMPFBND, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x385B380", Offset = "0x385A380", VA = "0x18385B380")]
	private static byte[] BPOAHIPMOGN<T>(T NAAMEAFIHJI) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x385B9D0", Offset = "0x385A9D0", VA = "0x18385B9D0")]
	private static T NPBMBNAKEBM<T>(MessageParser<T> PLJDBFGEJFF, byte[] NAAMEAFIHJI, T DPCDDDOIHML) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x846E380", Offset = "0x846D380", VA = "0x18846E380")]
	[AsyncStateMachine(typeof(FNMAIACOEEC))]
	private Task<OBOJAHIICMM.ELCFJMNDKFL<DAEAHJMMAED>> GJJAPLJOLFN(DAEAHJMMAED CAGMDMPFBND, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x385B480", Offset = "0x385A480", VA = "0x18385B480")]
	[AsyncStateMachine(typeof(BPAHHIIFBNB<>))]
	internal Task<T> HFJPOKDMCME<T>(CancellationToken EBOFCHGLLPK, Func<CancellationToken, Task<T>> NPOFLNLGLKI, int EOKABIBEHKG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x846E540", Offset = "0x846D540", VA = "0x18846E540")]
	[AsyncStateMachine(typeof(BFIMGJPDFEB))]
	internal Task HFJPOKDMCME(CancellationToken EBOFCHGLLPK, Func<CancellationToken, Task> NPOFLNLGLKI, int EOKABIBEHKG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x846E7D0", Offset = "0x846D7D0", VA = "0x18846E7D0")]
	public DMPOKLHCOJD IBDBOFPDPIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x846E4C0", Offset = "0x846D4C0", VA = "0x18846E4C0")]
	public EAJJHPPIGJC HCAADBKIOPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x846E110", Offset = "0x846D110", VA = "0x18846E110")]
	public MOJFFBJNPFJ FNLMJPJPCLB([Optional] JBBHIJHGEPM? PAJIGEJCNAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x846E670", Offset = "0x846D670", VA = "0x18846E670")]
	public void HMGLEFDJKIA(Func<Guid, bool> GLCENBLKGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x846E000", Offset = "0x846D000", VA = "0x18846E000")]
	public void EOIHFEIBEKA(Func<Guid, bool> HEEKELAELBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x846EB90", Offset = "0x846DB90", VA = "0x18846EB90")]
	public Guid LFIICAHNOAB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x846E9C0", Offset = "0x846D9C0", VA = "0x18846E9C0")]
	public void KJELAEGPJCA(Guid IGEEKENFEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x846DDF0", Offset = "0x846CDF0", VA = "0x18846DDF0")]
	public void BHLMHFKHKCC(DAEAHJMMAED JFOANNPHGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x846DB80", Offset = "0x846CB80", VA = "0x18846DB80")]
	public void AHIMDJPCPBN(string EFDFGKJJCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x385B390", Offset = "0x385A390", VA = "0x18385B390")]
	private T CJCJKPNPKEO<T>(T OHLIHBDBKCE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x846E850", Offset = "0x846D850", VA = "0x18846E850")]
	public void IDAIBAFFEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x385B720", Offset = "0x385A720", VA = "0x18385B720")]
	[CompilerGenerated]
	internal static string JHCAEBPIFPL<T>(byte[] ACDPPDBEDDM, int HOMPFMAAAKM, IMCLOJAIIGA<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal sealed class FAEENFFPBBD : PPPBMGNNDNF
{
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class DFHLGJIKNMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public DFHLGJIKNMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x8467120", Offset = "0x8466120", VA = "0x188467120")]
		internal object GOAGLAFDPGD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct GNOLNGHOJKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public FAEENFFPBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private IKJOECKPNBM <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private EAJJHPPIGJC <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x846F330", Offset = "0x846E330", VA = "0x18846F330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x846FC80", Offset = "0x846EC80", VA = "0x18846FC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct MJHMMIOBBFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public FAEENFFPBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private TaskAwaiter<GOMNLGPHFID> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x8474D30", Offset = "0x8473D30", VA = "0x188474D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x8475460", Offset = "0x8474460", VA = "0x188475460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct GEOBHCBEIGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public FAEENFFPBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter<NEDLDDMDCHB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x846EFB0", Offset = "0x846DFB0", VA = "0x18846EFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x846F2C0", Offset = "0x846E2C0", VA = "0x18846F2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private sealed class ADKJKAOGDMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public IKJOECKPNBM presence;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public ADKJKAOGDMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x84631A0", Offset = "0x84621A0", VA = "0x1884631A0")]
		internal object MPNBCHNOPBP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private static readonly JBBHIJHGEPM HDNPMENDLCN;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private static readonly JBBHIJHGEPM GHMGAICLGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private readonly AENKMJAJKCL GJIIIBDFFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	private readonly PAIKJEGABFG FKPLNDNGIOB;

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x846B270", Offset = "0x846A270", VA = "0x18846B270")]
	public FAEENFFPBBD(AENKMJAJKCL GJIIIBDFFHL, PAIKJEGABFG FKPLNDNGIOB, Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, HPBALDPEPLO GGBIELGEIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x846AD60", Offset = "0x8469D60", VA = "0x18846AD60", Slot = "7")]
	[AsyncStateMachine(typeof(GNOLNGHOJKK))]
	protected override Task BJJJFDGGDPF(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x846AC60", Offset = "0x8469C60", VA = "0x18846AC60")]
	[AsyncStateMachine(typeof(MJHMMIOBBFD))]
	private Task AHFMHDDHHEN(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x846AEA0", Offset = "0x8469EA0", VA = "0x18846AEA0")]
	[AsyncStateMachine(typeof(GEOBHCBEIGN))]
	private Task<int> LJENNOMNKDH(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x846AFB0", Offset = "0x8469FB0", VA = "0x18846AFB0")]
	private IKJOECKPNBM OHKNFMLJLIE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class OIFFOMNPKAJ : PPPBMGNNDNF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct OPPNNCNFHIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public OIFFOMNPKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private TaskAwaiter<GHABJHKCBDN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x847A570", Offset = "0x8479570", VA = "0x18847A570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x847AF20", Offset = "0x8479F20", VA = "0x18847AF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private readonly int MMFPNLNMPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private readonly OPPGGNKKPPF EBKHBJGGNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public readonly long BJFFDFGEMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public readonly long IGDPLOIKGIA;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public GHABJHKCBDN EOELPLOEPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x9F9100", Offset = "0x9F8100", VA = "0x1809F9100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x9F8FF0", Offset = "0x9F7FF0", VA = "0x1809F8FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x8479430", Offset = "0x8478430", VA = "0x188479430")]
	public OIFFOMNPKAJ(Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, HPBALDPEPLO GGBIELGEIEA, int MMFPNLNMPFP, OPPGGNKKPPF EBKHBJGGNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x8479310", Offset = "0x8478310", VA = "0x188479310", Slot = "7")]
	[AsyncStateMachine(typeof(OPPNNCNFHIO))]
	protected override Task BJJJFDGGDPF(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal abstract class MCFEFOAOGIC : PPPBMGNNDNF
{
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class OPCNPOACDOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public MCFEFOAOGIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public CEFMCOIEMHB playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public OPCNPOACDOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x847A4A0", Offset = "0x84794A0", VA = "0x18847A4A0")]
		internal Task HEBMHBPLNFB(LDCGKGNFMMI<string>.CKHHEKIPJDF postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x847A4E0", Offset = "0x84794E0", VA = "0x18847A4E0")]
		internal object IJNMDPCHNKJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct DMMAGNLBODO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public MCFEFOAOGIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private OPCNPOACDOK <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x84679A0", Offset = "0x84669A0", VA = "0x1884679A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x8468170", Offset = "0x8467170", VA = "0x188468170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private struct DLLDKHLIKAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public CEFMCOIEMHB playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public MCFEFOAOGIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x8467390", Offset = "0x8466390", VA = "0x188467390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x8467940", Offset = "0x8466940", VA = "0x188467940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x8474010", Offset = "0x8473010", VA = "0x188474010")]
	public MCFEFOAOGIC(Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, HPBALDPEPLO GGBIELGEIEA, string ANIMIEIPAGE, KLMNOKPMPDB MEOBMEDANDK, bool EPJEALHDNJK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x8473ED0", Offset = "0x8472ED0", VA = "0x188473ED0", Slot = "7")]
	[AsyncStateMachine(typeof(DMMAGNLBODO))]
	protected override Task BJJJFDGGDPF(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task OEAGPGDLPOA(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x8473D90", Offset = "0x8472D90", VA = "0x188473D90")]
	[AsyncStateMachine(typeof(DLLDKHLIKAC))]
	private Task BICOMEEFCDB(IDisposable HMBGEOCFKLF, CEFMCOIEMHB EPBBOAEAEML, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
internal class OGBKKNMLPDM : PPPBMGNNDNF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct BNINGBHCHOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public OGBKKNMLPDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public GEHMKHHFLAO operationContext;

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
		private TaskAwaiter<HFEJJAMCGEP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x8465E90", Offset = "0x8464E90", VA = "0x188465E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x8466420", Offset = "0x8465420", VA = "0x188466420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private readonly KNEDGBILGPM EDHLLDFNCFM;

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x8479270", Offset = "0x8478270", VA = "0x188479270")]
	public OGBKKNMLPDM(Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, HPBALDPEPLO GGBIELGEIEA, KNEDGBILGPM EDHLLDFNCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x8479190", Offset = "0x8478190", VA = "0x188479190", Slot = "6")]
	protected override string PPFILDFJAOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x8479070", Offset = "0x8478070", VA = "0x188479070", Slot = "7")]
	[AsyncStateMachine(typeof(BNINGBHCHOG))]
	protected override Task BJJJFDGGDPF(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal abstract class PPPBMGNNDNF : AEAIFIOMDPM
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	public delegate Task HNANNOLPNEO(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class DCLEKALIING
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public PPPBMGNNDNF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public DCLEKALIING()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x8466FF0", Offset = "0x8465FF0", VA = "0x188466FF0")]
		internal Task DFBECEDJHLP(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private sealed class JPLBFDMKHNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public DCLEKALIING CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public JPLBFDMKHNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x8471910", Offset = "0x8470910", VA = "0x188471910")]
		internal object APPLAPKLJIO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct NLECPHEEENH : IAsyncStateMachine
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
		public PPPBMGNNDNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public Func<PPPBMGNNDNF, LDCGKGNFMMI<string>.CKHHEKIPJDF, GEHMKHHFLAO> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private DCLEKALIING <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private GEHMKHHFLAO <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private TaskAwaiter<DAEAHJMMAED> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x8475A90", Offset = "0x8474A90", VA = "0x188475A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x8476C50", Offset = "0x8475C50", VA = "0x188476C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct BCDAAGJNHAE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8463EC0", Offset = "0x8462EC0", VA = "0x188463EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x8464960", Offset = "0x8463960", VA = "0x188464960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct ENOGJKAHPAM : IAsyncStateMachine
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
		public PPPBMGNNDNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x846A2D0", Offset = "0x84692D0", VA = "0x18846A2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x846A630", Offset = "0x8469630", VA = "0x18846A630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public readonly Guid EHBJDHPDJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public readonly ByteString BOLHLLCEDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public readonly HPBALDPEPLO PBHKFAEONMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	protected readonly string DICMHFPKLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private readonly IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	private readonly bool EPJEALHDNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private readonly Queue<HNANNOLPNEO> EFDFIAKKDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private readonly BAKGMMHDEOL GJIOAEOHEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private readonly KLMNOKPMPDB MEOBMEDANDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private bool KOEPONLCDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public IHHBKLENLMK BEOLMPIJNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public IHHBKLENLMK KKPAKKJANIH;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public IPAGNGHLCCF KFEELBCAGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public JHHKOFMOFFM PLBPABECHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x847D9A0", Offset = "0x847C9A0", VA = "0x18847D9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public IPGGFFCDLNK BKPNOIHPIEI
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x847DEF0", Offset = "0x847CEF0", VA = "0x18847DEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public IJPJAKACFOB BJABPNAMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x847DBE0", Offset = "0x847CBE0", VA = "0x18847DBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event BFAMDEMJIGI GIDLGFMCOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x847D9F0", Offset = "0x847C9F0", VA = "0x18847D9F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x847D980", Offset = "0x847C980", VA = "0x18847D980", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x847E3C0", Offset = "0x847D3C0", VA = "0x18847E3C0")]
	protected PPPBMGNNDNF(Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, HPBALDPEPLO GGBIELGEIEA, string ANIMIEIPAGE, KLMNOKPMPDB MEOBMEDANDK, bool EPJEALHDNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x847E380", Offset = "0x847D380", VA = "0x18847E380", Slot = "6")]
	protected virtual string PPFILDFJAOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x847DE90", Offset = "0x847CE90", VA = "0x18847DE90")]
	public void KABHFJHKJCH(HNANNOLPNEO KACLNFIKDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x847E1F0", Offset = "0x847D1F0", VA = "0x18847E1F0")]
	protected void OCPPHDLNAIJ(float NOOBIPOJNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x847DA90", Offset = "0x847CA90", VA = "0x18847DA90")]
	[AsyncStateMachine(typeof(NLECPHEEENH))]
	public Task GDMALPFODEM(CancellationToken CBJPDIFOEKF, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, [Optional] Func<PPPBMGNNDNF, LDCGKGNFMMI<string>.CKHHEKIPJDF, GEHMKHHFLAO> AIFOBAKGPAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x847E0C0", Offset = "0x847D0C0", VA = "0x18847E0C0")]
	[AsyncStateMachine(typeof(BCDAAGJNHAE))]
	private static Task NEAGPOPNDOI(Func<CancellationToken, Task> CJHGKDINONF, Func<CancellationToken, Task> NPAEKKBJFGC, CancellationToken EBOFCHGLLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x847DF40", Offset = "0x847CF40", VA = "0x18847DF40")]
	private void MOMNLNCHKFK(bool AMLDIAHNCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x847DC60", Offset = "0x847CC60", VA = "0x18847DC60")]
	private void JLNNGCJEOPC(GEHMKHHFLAO AJGFGCKEHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task BJJJFDGGDPF(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x847D860", Offset = "0x847C860", VA = "0x18847D860")]
	[AsyncStateMachine(typeof(ENOGJKAHPAM))]
	private Task AGINECDCMJF(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x847E300", Offset = "0x847D300", VA = "0x18847E300")]
	public DAEAHJMMAED PAMIJHPAECD(AGHPMNKMEMJ LEDHJMAHPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x847E210", Offset = "0x847D210", VA = "0x18847E210")]
	[CompilerGenerated]
	private Task OMFHECKLPIP(CancellationToken LEMBKBGMCDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x847DA10", Offset = "0x847CA10", VA = "0x18847DA10")]
	[CompilerGenerated]
	private object EDDOLIAOPNK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
internal sealed class HOJPLEHKJGH : MCFEFOAOGIC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct LMPHBNAEAFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public HOJPLEHKJGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private OGDCDNJBIFG <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private EAJJHPPIGJC <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x8473040", Offset = "0x8472040", VA = "0x188473040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x84737A0", Offset = "0x84727A0", VA = "0x1884737A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private readonly AENKMJAJKCL NMEIJLCHIKN;

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x84700C0", Offset = "0x846F0C0", VA = "0x1884700C0")]
	public HOJPLEHKJGH(Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, AENKMJAJKCL NMEIJLCHIKN, HPBALDPEPLO GGBIELGEIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x846FF70", Offset = "0x846EF70", VA = "0x18846FF70", Slot = "8")]
	[AsyncStateMachine(typeof(LMPHBNAEAFI))]
	protected override Task OEAGPGDLPOA(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal class FGADKJHOMIE : PPPBMGNNDNF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct MJEPIHAMPHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public FGADKJHOMIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private TaskAwaiter<HFEJJAMCGEP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x8474920", Offset = "0x8473920", VA = "0x188474920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x8474CD0", Offset = "0x8473CD0", VA = "0x188474CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private readonly string NMFNBOACOOE;

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x846C2E0", Offset = "0x846B2E0", VA = "0x18846C2E0")]
	public FGADKJHOMIE(Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, HPBALDPEPLO GGBIELGEIEA, string NMFNBOACOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x846C1D0", Offset = "0x846B1D0", VA = "0x18846C1D0", Slot = "7")]
	[AsyncStateMachine(typeof(MJEPIHAMPHD))]
	protected override Task BJJJFDGGDPF(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal class NKAFDBHGPAC : MCFEFOAOGIC
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class KHBOENMMCLP
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
			public AsyncTaskMethodBuilder<DAEAHJMMAED> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public KHBOENMMCLP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			private TaskAwaiter<HFEJJAMCGEP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			private TaskAwaiter<DAEAHJMMAED> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0x847F470", Offset = "0x847E470", VA = "0x18847F470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0x847F960", Offset = "0x847E960", VA = "0x18847F960", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public NKAFDBHGPAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public MOJFFBJNPFJ serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public MJJOEIPLFFL roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public DMPOKLHCOJD uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public GHIBGJOBNGE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public KHBOENMMCLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x8471FE0", Offset = "0x8470FE0", VA = "0x188471FE0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<DAEAHJMMAED> OMGDPGLKEMH(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private struct OJHEPHEAGBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public NKAFDBHGPAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private KHBOENMMCLP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private OGDCDNJBIFG <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private EAJJHPPIGJC <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private DAEAHJMMAED <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x8479560", Offset = "0x8478560", VA = "0x188479560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x847A440", Offset = "0x8479440", VA = "0x18847A440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private static readonly JBBHIJHGEPM HDNPMENDLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private readonly int BGINAMOOLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	[CanBeNull]
	private readonly MDNOEFMCADI LMHJJMIBAMA;

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x84759E0", Offset = "0x84749E0", VA = "0x1884759E0")]
	public NKAFDBHGPAC(Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, int BGINAMOOLIJ, MDNOEFMCADI LMHJJMIBAMA, HPBALDPEPLO GGBIELGEIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x8475620", Offset = "0x8474620", VA = "0x188475620", Slot = "8")]
	[AsyncStateMachine(typeof(OJHEPHEAGBF))]
	protected override Task OEAGPGDLPOA(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x8475520", Offset = "0x8474520", VA = "0x188475520")]
	private void KEHBCMLDANA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x8475760", Offset = "0x8474760", VA = "0x188475760")]
	private void PICDIOCPHMA(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, OGDCDNJBIFG JJJFPCEDAAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal class MANPACGGAHA : PPPBMGNNDNF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct BILJFENNEMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public MANPACGGAHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private OGDCDNJBIFG <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private GKHPBLLBAIL<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private TaskAwaiter<GHABJHKCBDN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x8464D00", Offset = "0x8463D00", VA = "0x188464D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x8465E30", Offset = "0x8464E30", VA = "0x188465E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private readonly int BGINAMOOLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private readonly MDNOEFMCADI LMHJJMIBAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private Func<HFEJJAMCGEP, HFEJJAMCGEP> IEJMBGBDAGB;

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x8473CD0", Offset = "0x8472CD0", VA = "0x188473CD0")]
	public MANPACGGAHA(Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, int BGINAMOOLIJ, MDNOEFMCADI LMHJJMIBAMA, Func<HFEJJAMCGEP, HFEJJAMCGEP> IEJMBGBDAGB, HPBALDPEPLO GGBIELGEIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x8473B90", Offset = "0x8472B90", VA = "0x188473B90", Slot = "7")]
	[AsyncStateMachine(typeof(BILJFENNEMI))]
	protected override Task BJJJFDGGDPF(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal abstract class CGFGCNFFKKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public readonly PPPBMGNNDNF AAIHBKEDJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public readonly GEHMKHHFLAO KNNFCCCKBOI;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public JHHKOFMOFFM PLBPABECHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x8466E30", Offset = "0x8465E30", VA = "0x188466E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public IJPJAKACFOB BJABPNAMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x8466E80", Offset = "0x8465E80", VA = "0x188466E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x8466F10", Offset = "0x8465F10", VA = "0x188466F10")]
	protected CGFGCNFFKKJ(GEHMKHHFLAO AJGFGCKEHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x8466D10", Offset = "0x8465D10", VA = "0x188466D10")]
	protected void AHIMDJPCPBN(string EFDFGKJJCLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct LMMOHLNEFMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public Dictionary<Guid, List<JCIEFCALJCE>> NDALPMLLJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public Dictionary<Guid, List<JCIEFCALJCE>> CJBFDILCBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public Dictionary<Guid, List<JCIEFCALJCE>> DOCIPEFPLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public List<Guid> EHFIDIHNNAG;

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x8472A30", Offset = "0x8471A30", VA = "0x188472A30")]
	public static LMMOHLNEFMM PHDCGNDDLGA(JHHKOFMOFFM DHJEDIPMPLO, IHHBKLENLMK NHCKJIIHJGE, JOEFAEBJKIB GIJBGILJKNL)
	{
		return default(LMMOHLNEFMM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct DIKIIKEINBD
{
	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820")]
	public static DIKIIKEINBD FLLMCNLHKNL()
	{
		return default(DIKIIKEINBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct EAEOJFOCIBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public readonly GOMNLGPHFID KNDDJPGLJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public readonly IINCMBDAHBF KEKMAFALOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public readonly Guid? DMDDOFCAJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public readonly IReadOnlyCollection<JJDFEBIHCFN> FPOFAECKECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public readonly IReadOnlyCollection<JJDFEBIHCFN> LLJNIILIBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public readonly NGHKAOKDFBL OFMJDNINMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public readonly NGHKAOKDFBL EKHBMLBAPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public readonly DIKDBMHBMCM AHIENHBHJOM;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool GADOFBOHLEI
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x84681D0", Offset = "0x84671D0", VA = "0x1884681D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x8468260", Offset = "0x8467260", VA = "0x188468260")]
	public EAEOJFOCIBE(GOMNLGPHFID KNDDJPGLJMO, IINCMBDAHBF KEKMAFALOGL, Guid? DMDDOFCAJJF, IReadOnlyList<JJDFEBIHCFN> FPOFAECKECE, IReadOnlyCollection<JJDFEBIHCFN> LLJNIILIBCB, NGHKAOKDFBL OFMJDNINMGK, NGHKAOKDFBL EKHBMLBAPGI, DIKDBMHBMCM AHIENHBHJOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct HPHPJCODCED : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private readonly GEHMKHHFLAO AJGFGCKEHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private readonly Guid IGEEKENFEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private bool AMLDIAHNCEJ;

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x8470460", Offset = "0x846F460", VA = "0x188470460")]
	public static HPHPJCODCED LFIICAHNOAB(GEHMKHHFLAO AJGFGCKEHBB)
	{
		return default(HPHPJCODCED);
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x11A89C0", Offset = "0x11A79C0", VA = "0x1811A89C0")]
	public void CBBJELLKGAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x8470170", Offset = "0x846F170", VA = "0x188470170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x8470490", Offset = "0x846F490", VA = "0x188470490")]
	private HPHPJCODCED(GEHMKHHFLAO AJGFGCKEHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x8470220", Offset = "0x846F220", VA = "0x188470220")]
	private void KJELAEGPJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x8470180", Offset = "0x846F180", VA = "0x188470180")]
	private Func<Guid, bool> GOEMDPOPHHK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal class EAJJHPPIGJC : CGFGCNFFKKJ, AEAIFIOMDPM
{
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	public delegate Task<IHHBKLENLMK> LADFBABIGGF(JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KHAHHALEIML, BAKGMMHDEOL JEAOKNGGMFI, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct AJMFDDJLHBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public AENKMJAJKCL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private HPHPJCODCED <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x8463350", Offset = "0x8462350", VA = "0x188463350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x8463C20", Offset = "0x8462C20", VA = "0x188463C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct PLKGJDBJDPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public AsyncTaskMethodBuilder<DAEAHJMMAED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public AENKMJAJKCL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x847D3C0", Offset = "0x847C3C0", VA = "0x18847D3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x847D7F0", Offset = "0x847C7F0", VA = "0x18847D7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct OADLMOOPCNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public AENKMJAJKCL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x8477220", Offset = "0x8476220", VA = "0x188477220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x8477860", Offset = "0x8476860", VA = "0x188477860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class NNILHGGJCOL
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
			public AsyncTaskMethodBuilder<EAEOJFOCIBE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			public NNILHGGJCOL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			private EAEOJFOCIBE <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			private TaskAwaiter<IHHBKLENLMK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			private TaskAwaiter<EAEOJFOCIBE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x847E520", Offset = "0x847D520", VA = "0x18847E520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x847ED10", Offset = "0x847DD10", VA = "0x18847ED10", Slot = "5")]
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
			public AsyncTaskMethodBuilder<JOEFAEBJKIB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			public NNILHGGJCOL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004FF")]
			private JOEFAEBJKIB <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			private TaskAwaiter<IHHBKLENLMK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			private TaskAwaiter<JOEFAEBJKIB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x847ED80", Offset = "0x847DD80", VA = "0x18847ED80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x847F400", Offset = "0x847E400", VA = "0x18847F400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public AENKMJAJKCL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public BAKGMMHDEOL preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public BAKGMMHDEOL downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public EAEOJFOCIBE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public BAKGMMHDEOL postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public JOEFAEBJKIB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public LKLEKOGDEBE.OBNDLGOKJBI <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NNILHGGJCOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x84770D0", Offset = "0x84760D0", VA = "0x1884770D0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<EAEOJFOCIBE> NBEGPGBPOJI(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x8476E50", Offset = "0x8475E50", VA = "0x188476E50")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<JOEFAEBJKIB> HIHJCPBKHEK(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x8476E10", Offset = "0x8475E10", VA = "0x188476E10")]
		internal void FJJNEOIAPMB(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x8476CB0", Offset = "0x8475CB0", VA = "0x188476CB0")]
		internal Task FJINOMMAANG(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x8476F70", Offset = "0x8475F70", VA = "0x188476F70")]
		internal Task LCFCOBKOMDL(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct FBGCJDDOEEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public AENKMJAJKCL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private NNILHGGJCOL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private TaskAwaiter<EAEOJFOCIBE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private TaskAwaiter<JOEFAEBJKIB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x846B400", Offset = "0x846A400", VA = "0x18846B400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x846C170", Offset = "0x846B170", VA = "0x18846C170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct FOFLNHJANLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public JOEFAEBJKIB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public BAKGMMHDEOL postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private TaskAwaiter<IHHBKLENLMK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private AMIGCLEJKKN <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x846CA10", Offset = "0x846BA10", VA = "0x18846CA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x846DB20", Offset = "0x846CB20", VA = "0x18846DB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct LNDGGJJELDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x8490DA0", Offset = "0x848FDA0", VA = "0x188490DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x8491580", Offset = "0x8490580", VA = "0x188491580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct HDDJPCCIINI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public BAKGMMHDEOL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private TaskAwaiter<IHHBKLENLMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x848A440", Offset = "0x8489440", VA = "0x18848A440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x848AC80", Offset = "0x8489C80", VA = "0x18848AC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct FCDMPBMIPNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public BAKGMMHDEOL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private TaskAwaiter<IHHBKLENLMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8486E00", Offset = "0x8485E00", VA = "0x188486E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x8487DC0", Offset = "0x8486DC0", VA = "0x188487DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct EACNADHGBPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public BAKGMMHDEOL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public AMIGCLEJKKN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private TaskAwaiter<IHHBKLENLMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x8483110", Offset = "0x8482110", VA = "0x188483110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x8484220", Offset = "0x8483220", VA = "0x188484220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct DBBHEPNDDLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public IHHBKLENLMK operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public BAKGMMHDEOL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public JOEFAEBJKIB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private TaskAwaiter<IHHBKLENLMK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x8482E50", Offset = "0x8481E50", VA = "0x188482E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x84830A0", Offset = "0x84820A0", VA = "0x1884830A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class BMCLEFKENEL
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
			public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public BMCLEFKENEL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			private JHEDBCMAENC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			private TaskAwaiter<IHHBKLENLMK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x8498120", Offset = "0x8497120", VA = "0x188498120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x8498750", Offset = "0x8497750", VA = "0x188498750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public BAKGMMHDEOL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public LADFBABIGGF masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public AMIGCLEJKKN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public IHHBKLENLMK originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BMCLEFKENEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x8481D30", Offset = "0x8480D30", VA = "0x188481D30")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<IHHBKLENLMK> KHBBDMNNJPN(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct FMFGENCMMAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public BAKGMMHDEOL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public LADFBABIGGF masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public AMIGCLEJKKN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private TaskAwaiter<IHHBKLENLMK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x8488540", Offset = "0x8487540", VA = "0x188488540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x8488A60", Offset = "0x8487A60", VA = "0x188488A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct EPCGHNPEBEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public BAKGMMHDEOL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private IHHBKLENLMK <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private IEnumerator<IHHBKLENLMK> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private TaskAwaiter<IHHBKLENLMK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x8486850", Offset = "0x8485850", VA = "0x188486850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x8486DA0", Offset = "0x8485DA0", VA = "0x188486DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct JFDPCBBJFBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x848D8C0", Offset = "0x848C8C0", VA = "0x18848D8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x848DBB0", Offset = "0x848CBB0", VA = "0x18848DBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct MFNHHBCECOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x8491F90", Offset = "0x8490F90", VA = "0x188491F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x84921C0", Offset = "0x84911C0", VA = "0x1884921C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class LKGFJOAFAMP
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
			public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			public LKGFJOAFAMP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public JOEFAEBJKIB data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public BAKGMMHDEOL progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			private TaskAwaiter<IHHBKLENLMK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			private TaskAwaiter<PNMPDOEFGAA> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x84987C0", Offset = "0x84977C0", VA = "0x1884987C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x8499280", Offset = "0x8498280", VA = "0x188499280", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public JAJMJMCBDCI mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public LKGFJOAFAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x8490740", Offset = "0x848F740", VA = "0x188490740")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<IHHBKLENLMK> AACBKKIDMAF(JOEFAEBJKIB data, AMIGCLEJKKN _, BAKGMMHDEOL progressTracker, LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct GAPCPJDKIHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public JOEFAEBJKIB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public BAKGMMHDEOL postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private LKGFJOAFAMP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private AMIGCLEJKKN <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter<IHHBKLENLMK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x8488AD0", Offset = "0x8487AD0", VA = "0x188488AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x84899A0", Offset = "0x84889A0", VA = "0x1884899A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct PAEMBNLJEGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x8494B30", Offset = "0x8493B30", VA = "0x188494B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x8494F30", Offset = "0x8493F30", VA = "0x188494F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct LIACLKHIOOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public BAKGMMHDEOL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private TaskAwaiter<IHHBKLENLMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x84900B0", Offset = "0x848F0B0", VA = "0x1884900B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x84906D0", Offset = "0x848F6D0", VA = "0x1884906D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private readonly BDMLCHKFOFH LAMPIOPGDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private readonly BDMLCHKFOFH OPCIPKOEPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private readonly PLHOCFLCCME AANEBFKDCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private readonly PHFJIAMDFFA LDGKLCBAEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private readonly EKILGEACLCB HJALPDOCMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private ProfilerCounterValue<int> KFAPHEFEEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private readonly HKMALGKDFBG DHMAABOAJAK;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private IPAGNGHLCCF KFEELBCAGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x8468310", Offset = "0x8467310", VA = "0x188468310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event BFAMDEMJIGI GIDLGFMCOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x8468A60", Offset = "0x8467A60", VA = "0x188468A60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x84688F0", Offset = "0x84678F0", VA = "0x1884688F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x8469ED0", Offset = "0x8468ED0", VA = "0x188469ED0")]
	public EAJJHPPIGJC(GEHMKHHFLAO AJGFGCKEHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x8468A80", Offset = "0x8467A80", VA = "0x188468A80")]
	[AsyncStateMachine(typeof(AJMFDDJLHBG))]
	public Task EDOEPKBAEGM(AENKMJAJKCL HOOJNAMGGBC, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x8469B50", Offset = "0x8468B50", VA = "0x188469B50")]
	[AsyncStateMachine(typeof(PLKGJDBJDPM))]
	private Task<DAEAHJMMAED> OODPNIKAJOF(AENKMJAJKCL HOOJNAMGGBC, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x8469A10", Offset = "0x8468A10", VA = "0x188469A10")]
	[AsyncStateMachine(typeof(OADLMOOPCNN))]
	private Task NBGHCNDHNJK(AENKMJAJKCL HOOJNAMGGBC, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x8469840", Offset = "0x8468840", VA = "0x188469840")]
	[AsyncStateMachine(typeof(FBGCJDDOEEO))]
	private Task LEDNAHMOELM(AENKMJAJKCL HOOJNAMGGBC, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken JJBBPEILOIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x8468F90", Offset = "0x8467F90", VA = "0x188468F90")]
	[AsyncStateMachine(typeof(FOFLNHJANLO))]
	private Task FDDGJPOAEBH(JOEFAEBJKIB NJLJEKGKBFA, BAKGMMHDEOL KNADNIOJNOE, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken HNIFIEMGDPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x8469D10", Offset = "0x8468D10", VA = "0x188469D10")]
	[AsyncStateMachine(typeof(LNDGGJJELDG))]
	private Task PLPGBABOJJN(LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x8468910", Offset = "0x8467910", VA = "0x188468910")]
	[AsyncStateMachine(typeof(HDDJPCCIINI))]
	private Task EACCBDOIFEB(JOEFAEBJKIB APDBNIMCPID, BAKGMMHDEOL JEAOKNGGMFI, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x84695C0", Offset = "0x84685C0", VA = "0x1884695C0")]
	[AsyncStateMachine(typeof(FCDMPBMIPNM))]
	private Task<IHHBKLENLMK> KDDHIMBFADG(JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, BAKGMMHDEOL JEAOKNGGMFI, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x8468750", Offset = "0x8467750", VA = "0x188468750")]
	[AsyncStateMachine(typeof(EACNADHGBPN))]
	private Task<IHHBKLENLMK> BLMKPKHNPGF(JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, BAKGMMHDEOL JEAOKNGGMFI, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x8468340", Offset = "0x8467340", VA = "0x188468340")]
	[AsyncStateMachine(typeof(DBBHEPNDDLK))]
	private Task<IHHBKLENLMK> AGFKJMPBAAF(IHHBKLENLMK NHCKJIIHJGE, JOEFAEBJKIB GIJBGILJKNL, BAKGMMHDEOL JEAOKNGGMFI, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF, bool CIPDMCKNNIA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x8469300", Offset = "0x8468300", VA = "0x188469300")]
	private bool HNHFMEMCNCO(JOEFAEBJKIB NJLJEKGKBFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x8469130", Offset = "0x8468130", VA = "0x188469130")]
	[AsyncStateMachine(typeof(FMFGENCMMAG))]
	protected Task<IHHBKLENLMK> GKMPFFDGLHK(JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, BAKGMMHDEOL JEAOKNGGMFI, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF, LADFBABIGGF IHJJMMLHCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x8468600", Offset = "0x8467600", VA = "0x188468600")]
	[AsyncStateMachine(typeof(EPCGHNPEBEF))]
	private Task BKLAFKMFKNJ(JOEFAEBJKIB APDBNIMCPID, BAKGMMHDEOL JEAOKNGGMFI, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x8469980", Offset = "0x8468980", VA = "0x188469980")]
	private void LIPBDHJJMLL(IHHBKLENLMK PAJPHIMOMIF, BAKGMMHDEOL JEAOKNGGMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x8469410", Offset = "0x8468410", VA = "0x188469410")]
	private void IKPINLMAIIK(IHHBKLENLMK OMFJEBBABLE, [Out] IHHBKLENLMK IFINDNCODHD, [Out] IHHBKLENLMK ICHPHJLAMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x8469CB0", Offset = "0x8468CB0", VA = "0x188469CB0")]
	private Task<EAEOJFOCIBE> PJEJKBJPHEJ(AENKMJAJKCL HOOJNAMGGBC, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x84692C0", Offset = "0x84682C0", VA = "0x1884692C0")]
	private Task<JOEFAEBJKIB> GLLADIDKIML(EAEOJFOCIBE APDBNIMCPID, LKLEKOGDEBE.OBNDLGOKJBI BHELEDFDDCN, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x8469470", Offset = "0x8468470", VA = "0x188469470")]
	[AsyncStateMachine(typeof(JFDPCBBJFBM))]
	private Task INLCPPFDMDC(JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF, bool GFFKPEPGKHC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x8468BD0", Offset = "0x8467BD0", VA = "0x188468BD0")]
	[AsyncStateMachine(typeof(MFNHHBCECOP))]
	private Task EGDJEHIKBFE(JOEFAEBJKIB APDBNIMCPID, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x84699E0", Offset = "0x84689E0", VA = "0x1884699E0")]
	private Task MHALDBDKPKM(JOEFAEBJKIB APDBNIMCPID, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x8469CF0", Offset = "0x8468CF0", VA = "0x188469CF0")]
	private Task PJHOEPPBEDN(JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x84693F0", Offset = "0x84683F0", VA = "0x1884693F0")]
	private Task IJMOKDCPBPN(JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x8469450", Offset = "0x8468450", VA = "0x188469450")]
	private Task IMIMLLHKHHJ(JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x84699D0", Offset = "0x84689D0", VA = "0x1884699D0")]
	private static Task LOKIDKJKKFA(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x8468CC0", Offset = "0x8467CC0", VA = "0x188468CC0")]
	private Task EPEDOLELIIC(JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x84688D0", Offset = "0x84678D0", VA = "0x1884688D0")]
	private Task CDLCNIOHNNG(JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x84690E0", Offset = "0x84680E0", VA = "0x1884690E0")]
	private void GBGIHACGHKN(AENKMJAJKCL HOOJNAMGGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x8469E20", Offset = "0x8468E20", VA = "0x188469E20")]
	public void PPCONFLLMCP(long CFBANPJJEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	private static void PIEBNGKJJNC(GOMNLGPHFID KNDDJPGLJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x8468E40", Offset = "0x8467E40", VA = "0x188468E40")]
	[AsyncStateMachine(typeof(GAPCPJDKIHH))]
	private Task FCEOHIEDGPF(JOEFAEBJKIB NJLJEKGKBFA, BAKGMMHDEOL KNADNIOJNOE, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken HNIFIEMGDPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x84684C0", Offset = "0x84674C0", VA = "0x1884684C0")]
	[AsyncStateMachine(typeof(PAEMBNLJEGC))]
	private Task BCMHMPEEMOB(JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x8469720", Offset = "0x8468720", VA = "0x188469720")]
	private static GMMJMMMKMBM KPJAKCGCJCC(JOEFAEBJKIB GIJBGILJKNL)
	{
		return default(GMMJMMMKMBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x8468CE0", Offset = "0x8467CE0", VA = "0x188468CE0")]
	[AsyncStateMachine(typeof(LIACLKHIOOA))]
	private Task<IHHBKLENLMK> FBCCMLAEMBI(JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, BAKGMMHDEOL JEAOKNGGMFI, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	private void DNPHOKGICMB(IHHBKLENLMK LCBJJCCLMFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct NKEGADBEMPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	private JOEFAEBJKIB APDBNIMCPID;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private JHHKOFMOFFM PLBPABECHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x8492E50", Offset = "0x8491E50", VA = "0x188492E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x8492EA0", Offset = "0x8491EA0", VA = "0x188492EA0")]
	public static Task GDMALPFODEM(IPAGNGHLCCF BFCIGLOEMAP, JOEFAEBJKIB APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x8492F80", Offset = "0x8491F80", VA = "0x188492F80")]
	private void GDMALPFODEM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct BPDCAGGOPNJ
{
	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x8481E50", Offset = "0x8480E50", VA = "0x188481E50")]
	public static Task GDMALPFODEM(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct HLMKGHAKGHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct PMAJIEPGJOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x8496AB0", Offset = "0x8495AB0", VA = "0x188496AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x8496FE0", Offset = "0x8495FE0", VA = "0x188496FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x848ACE0", Offset = "0x8489CE0", VA = "0x18848ACE0")]
	[AsyncStateMachine(typeof(PMAJIEPGJOP))]
	public static Task GDMALPFODEM(GEHMKHHFLAO AJGFGCKEHBB, JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct KFLFOFJAIGN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct ELGJKHBCMMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public AMIGCLEJKKN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private IPAGNGHLCCF <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private JHHKOFMOFFM <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private IHHBKLENLMK <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private JHEDBCMAENC <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private List<(PersistenceView, DJNGLNAIHJJ)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private DJNGLNAIHJJ <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x8485B10", Offset = "0x8484B10", VA = "0x188485B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x84867F0", Offset = "0x84857F0", VA = "0x1884867F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x848ECE0", Offset = "0x848DCE0", VA = "0x18848ECE0")]
	[AsyncStateMachine(typeof(ELGJKHBCMMG))]
	public static Task GDMALPFODEM(GEHMKHHFLAO AJGFGCKEHBB, JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x848EE30", Offset = "0x848DE30", VA = "0x18848EE30")]
	private static void ILDPHEEAEHE(PersistenceView NNAEIGBDCOK, DJNGLNAIHJJ BJPIFCHFNAA, JOEFAEBJKIB APDBNIMCPID, IHHBKLENLMK NHCKJIIHJGE, bool NPHJGNGAOEN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct INJABJLIBIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct CPEGILMICJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public IPAGNGHLCCF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private JHEDBCMAENC <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x84827D0", Offset = "0x84817D0", VA = "0x1884827D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x8482DF0", Offset = "0x8481DF0", VA = "0x188482DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x848C180", Offset = "0x848B180", VA = "0x18848C180")]
	[AsyncStateMachine(typeof(CPEGILMICJE))]
	public static Task GDMALPFODEM(IPAGNGHLCCF BFCIGLOEMAP, JOEFAEBJKIB APDBNIMCPID, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal struct EBBPBNLIGOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct OADCEMGJIFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public IPAGNGHLCCF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x8493BB0", Offset = "0x8492BB0", VA = "0x188493BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x8493DC0", Offset = "0x8492DC0", VA = "0x188493DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class PJKBDDNAIIA
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
			public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			public PJKBDDNAIIA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x84992F0", Offset = "0x84982F0", VA = "0x1884992F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x8499680", Offset = "0x8498680", VA = "0x188499680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public PJKBDDNAIIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x8496990", Offset = "0x8495990", VA = "0x188496990")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task OKNAKMDFPMF(LDCGKGNFMMI<string>.CKHHEKIPJDF timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct KHBIACANPOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public EBBPBNLIGOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private JHEDBCMAENC <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x848F3C0", Offset = "0x848E3C0", VA = "0x18848F3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x848FFD0", Offset = "0x848EFD0", VA = "0x18848FFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class CJNFDFMFCGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public APPGMHGFBGI version;

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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public CJNFDFMFCGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x8482640", Offset = "0x8481640", VA = "0x188482640")]
		internal object IAMHPGLDGIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x8482720", Offset = "0x8481720", VA = "0x188482720")]
		internal object IMAPOPDIMOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private JOEFAEBJKIB APDBNIMCPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private GEHMKHHFLAO AJGFGCKEHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private bool GFFKPEPGKHC;

	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private static readonly ByteString OMOGNPBDFEN;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private JHHKOFMOFFM PLBPABECHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x8484AB0", Offset = "0x8483AB0", VA = "0x188484AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private IJPJAKACFOB BJABPNAMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x8484D80", Offset = "0x8483D80", VA = "0x188484D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x8484B00", Offset = "0x8483B00", VA = "0x188484B00")]
	[AsyncStateMachine(typeof(OADCEMGJIFE))]
	public static Task GDMALPFODEM(IPAGNGHLCCF BFCIGLOEMAP, JOEFAEBJKIB APDBNIMCPID, GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF, bool GFFKPEPGKHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x8484C50", Offset = "0x8483C50", VA = "0x188484C50")]
	[AsyncStateMachine(typeof(KHBIACANPOH))]
	private Task GDMALPFODEM(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x84842D0", Offset = "0x84832D0", VA = "0x1884842D0")]
	private void DEKFIMFLOGD([NotNull] BPLHNECCAPN DELDEHHAKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x8484290", Offset = "0x8483290", VA = "0x188484290")]
	private bool BNPIILPMDAF(APPGMHGFBGI DJNGLBELENN, BPLHNECCAPN DELDEHHAKDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct MKCHPLLAKJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct IOLILHICOCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public AsyncTaskMethodBuilder<JOEFAEBJKIB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public MKCHPLLAKJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public LKLEKOGDEBE.OBNDLGOKJBI downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private TaskAwaiter<IReadOnlyCollection<JJDFEBIHCFN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private TaskAwaiter<(HHHCCNLMPJL<HFIBBAIEKFD, OGMCLKGLBPG>, HHHCCNLMPJL<PFOMDLOAMOL<BPLHNECCAPN>, OGMCLKGLBPG>, HHHCCNLMPJL<PFOMDLOAMOL<HNAGJAILJOF>, OGMCLKGLBPG>, HHHCCNLMPJL<PFOMDLOAMOL<IEnumerable<MCIJFDPPJOL>>, OGMCLKGLBPG>, HHHCCNLMPJL<PFOMDLOAMOL<COGPNGPCNGP>, OGMCLKGLBPG>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x848C2A0", Offset = "0x848B2A0", VA = "0x18848C2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x848D080", Offset = "0x848C080", VA = "0x18848D080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct PODJIDBADAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<HFIBBAIEKFD, OGMCLKGLBPG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public MKCHPLLAKJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public IReadOnlyCollection<JJDFEBIHCFN> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public IReadOnlyCollection<JJDFEBIHCFN> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public LKLEKOGDEBE.OBNDLGOKJBI downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter<HHHCCNLMPJL<HFIBBAIEKFD, OGMCLKGLBPG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x8497040", Offset = "0x8496040", VA = "0x188497040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x84976A0", Offset = "0x84966A0", VA = "0x1884976A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	private KLLJHPOCLHE<NGHKAOKDFBL, HNAGJAILJOF> BNBHCHCMJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	private KLLJHPOCLHE<NGHKAOKDFBL, BPLHNECCAPN> OHCODIMLEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	private KLLJHPOCLHE<DIKDBMHBMCM, IEnumerable<MCIJFDPPJOL>> CGMILGBHLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	private KLLJHPOCLHE<long, COGPNGPCNGP> MCLGELBFODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private EMCAKAJMIMO GCOFMFFEGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private GOMNLGPHFID KNDDJPGLJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private IINCMBDAHBF KEKMAFALOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	private Guid? DMDDOFCAJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	private IReadOnlyCollection<JJDFEBIHCFN> FPOFAECKECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private Task<IReadOnlyCollection<JJDFEBIHCFN>> DFJCNECFEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	private NGHKAOKDFBL OFMJDNINMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private NGHKAOKDFBL EKHBMLBAPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private NGHKAOKDFBL? NHNPOIIGHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private DIKDBMHBMCM AHIENHBHJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL;

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x84923D0", Offset = "0x84913D0", VA = "0x1884923D0")]
	public static Task<JOEFAEBJKIB> GNAMKEEBKGL(IPAGNGHLCCF BFCIGLOEMAP, [In] EAEOJFOCIBE APDBNIMCPID, LKLEKOGDEBE.OBNDLGOKJBI BHELEDFDDCN, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x8492220", Offset = "0x8491220", VA = "0x188492220")]
	[AsyncStateMachine(typeof(IOLILHICOCM))]
	private Task<JOEFAEBJKIB> GDMALPFODEM(LKLEKOGDEBE.OBNDLGOKJBI BHELEDFDDCN, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x84928D0", Offset = "0x84918D0", VA = "0x1884928D0")]
	[AsyncStateMachine(typeof(PODJIDBADAP))]
	private Task<HHHCCNLMPJL<HFIBBAIEKFD, OGMCLKGLBPG>> ICIINIKJGIF(Guid? DMDDOFCAJJF, IReadOnlyCollection<JJDFEBIHCFN> FPOFAECKECE, IReadOnlyCollection<JJDFEBIHCFN> LLJNIILIBCB, long? CINEDGEJAIA, long? DPKCNMHAPEB, LKLEKOGDEBE.OBNDLGOKJBI BHELEDFDDCN, LDCGKGNFMMI<string>.CKHHEKIPJDF KBMLEGCCJDH, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct FDMNOOLMEPB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct LNDMANOEKKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public AsyncTaskMethodBuilder<EAEOJFOCIBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public FDMNOOLMEPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private TaskAwaiter<EAEOJFOCIBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x84915E0", Offset = "0x84905E0", VA = "0x1884915E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x8491A30", Offset = "0x8490A30", VA = "0x188491A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct MBHMCDLNOPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public AsyncTaskMethodBuilder<EAEOJFOCIBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public FDMNOOLMEPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private TaskAwaiter<EAEOJFOCIBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x8491AA0", Offset = "0x8490AA0", VA = "0x188491AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x8491F20", Offset = "0x8490F20", VA = "0x188491F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class AOBKAOCJPBO
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
			public AOBKAOCJPBO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			private TaskAwaiter<NOEKMJCDIOB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			private TaskAwaiter<NEDLDDMDCHB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x8497710", Offset = "0x8496710", VA = "0x188497710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x84980C0", Offset = "0x84970C0", VA = "0x1884980C0", Slot = "5")]
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
		public EJHLKPMLCLG roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public JHHKOFMOFFM callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public NGHKAOKDFBL superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public NGHKAOKDFBL subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public IReadOnlyList<JJDFEBIHCFN> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public IReadOnlyList<JJDFEBIHCFN> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public GOMNLGPHFID roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public AOBKAOCJPBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xE3FC80", Offset = "0xE3EC80", VA = "0x180E3FC80")]
		internal bool EJPPCJMGEGP(IINCMBDAHBF sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x84810C0", Offset = "0x84800C0", VA = "0x1884810C0")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task OIJJOHAAKEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x8480EC0", Offset = "0x847FEC0", VA = "0x188480EC0")]
		internal Task<DIKDBMHBMCM> FCMAHLDBJIF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct JIKGAOCLODO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public AsyncTaskMethodBuilder<EAEOJFOCIBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public EJHLKPMLCLG roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public JHHKOFMOFFM callbacks;

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
		public NGHKAOKDFBL superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private AOBKAOCJPBO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private IINCMBDAHBF <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private Task<DIKDBMHBMCM> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private TaskAwaiter<GOMNLGPHFID> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private TaskAwaiter<DIKDBMHBMCM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x848DC10", Offset = "0x848CC10", VA = "0x18848DC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x848EBC0", Offset = "0x848DBC0", VA = "0x18848EBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	private JHHKOFMOFFM DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private PLHOCFLCCME AANEBFKDCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	private EJHLKPMLCLG BCNCMPIIBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	private LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private long CINEDGEJAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private long NBOIIPJHEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private long HACNOLAIOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	private string JMBBDHDFKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	private NGHKAOKDFBL HFBHAAKDPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private Guid GDHLBGMCLLJ;

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x8487FB0", Offset = "0x8486FB0", VA = "0x188487FB0")]
	public static Task<EAEOJFOCIBE> GNAMKEEBKGL(IPAGNGHLCCF BFCIGLOEMAP, AENKMJAJKCL HOOJNAMGGBC, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x8487E30", Offset = "0x8486E30", VA = "0x188487E30")]
	[AsyncStateMachine(typeof(LNDMANOEKKH))]
	private Task<EAEOJFOCIBE> GDMALPFODEM(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x84883D0", Offset = "0x84873D0", VA = "0x1884883D0")]
	[AsyncStateMachine(typeof(MBHMCDLNOPK))]
	private Task<EAEOJFOCIBE> PJEJKBJPHEJ(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x8488200", Offset = "0x8487200", VA = "0x188488200")]
	[AsyncStateMachine(typeof(JIKGAOCLODO))]
	private static Task<EAEOJFOCIBE> PJEJKBJPHEJ(JHHKOFMOFFM DHJEDIPMPLO, EJHLKPMLCLG BCNCMPIIBEG, long CINEDGEJAIA, long NBOIIPJHEBJ, long HACNOLAIOHO, string JMBBDHDFKMN, NGHKAOKDFBL HFBHAAKDPMK, Guid GDHLBGMCLLJ, CancellationToken CBJPDIFOEKF, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x8487F80", Offset = "0x8486F80", VA = "0x188487F80")]
	private void GMBOENADNFI(GOMNLGPHFID KNDDJPGLJMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
internal struct EKNGJCMJDON
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct BJJHBDPJLDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public EKNGJCMJDON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x8481740", Offset = "0x8480740", VA = "0x188481740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x8481CD0", Offset = "0x8480CD0", VA = "0x188481CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private JHHKOFMOFFM DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private JOEFAEBJKIB APDBNIMCPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	private LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	private float NFCINNNCIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private float NOCKDIDHLMO;

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x84855F0", Offset = "0x84845F0", VA = "0x1884855F0")]
	public static Task LJCOBGHNIAJ(IPAGNGHLCCF BFCIGLOEMAP, JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x84854D0", Offset = "0x84844D0", VA = "0x1884854D0")]
	[AsyncStateMachine(typeof(BJJHBDPJLDG))]
	public Task GDMALPFODEM(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x84859D0", Offset = "0x84849D0", VA = "0x1884859D0")]
	private static void PLOCCGMPIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x8485850", Offset = "0x8484850", VA = "0x188485850")]
	private void OGFKJLCEMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x8485790", Offset = "0x8484790", VA = "0x188485790")]
	private static float NLBJEKAFBPH(JHHKOFMOFFM DHJEDIPMPLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x84859B0", Offset = "0x84849B0", VA = "0x1884859B0")]
	private static float OKBMAHAHIIE()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000171")]
internal struct HMOCADIKAFJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct NPHJOCPPCHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private PPPBMGNNDNF <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private IPAGNGHLCCF <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private AGJCFBFMDCK.DDCNOPNHDPM <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x8493330", Offset = "0x8492330", VA = "0x188493330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x8493B50", Offset = "0x8492B50", VA = "0x188493B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private struct AIELGNNJIOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x8480B30", Offset = "0x847FB30", VA = "0x188480B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x8480E60", Offset = "0x847FE60", VA = "0x188480E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x848B820", Offset = "0x848A820", VA = "0x18848B820")]
	[AsyncStateMachine(typeof(NPHJOCPPCHE))]
	public static Task GDMALPFODEM(GEHMKHHFLAO AJGFGCKEHBB, JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x848B960", Offset = "0x848A960", VA = "0x18848B960")]
	private static Task<DAEAHJMMAED> LEBCHMOEDPG(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x848B760", Offset = "0x848A760", VA = "0x18848B760")]
	[AsyncStateMachine(typeof(AIELGNNJIOH))]
	private static Task CAFGCIGBDJH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct EBIIFJCDEKP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct CIEBHMADBID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public EBIIFJCDEKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x8481F30", Offset = "0x8480F30", VA = "0x188481F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x84825E0", Offset = "0x84815E0", VA = "0x1884825E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class IDCILHPGBFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public IDCILHPGBFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x848B9D0", Offset = "0x848A9D0", VA = "0x18848B9D0")]
		internal object MDJIAKPDBCE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct PDICFIDGPNF : IAsyncStateMachine
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
		public EBIIFJCDEKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x8494F90", Offset = "0x8493F90", VA = "0x188494F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x8495410", Offset = "0x8494410", VA = "0x188495410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private bool GPGJKJMFCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private CancellationToken CBJPDIFOEKF;

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x8484FE0", Offset = "0x8483FE0", VA = "0x188484FE0")]
	public static Task BJJOOCPFFMI(IPAGNGHLCCF BFCIGLOEMAP, bool GPGJKJMFCFP, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken JDCDGDBBGIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x8485050", Offset = "0x8484050", VA = "0x188485050")]
	[AsyncStateMachine(typeof(CIEBHMADBID))]
	private Task GDMALPFODEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x8484EB0", Offset = "0x8483EB0", VA = "0x188484EB0")]
	[AsyncStateMachine(typeof(PDICFIDGPNF))]
	private Task AAAMEHIBOMA(bool BEGAHOKPHIA, string NHHGKEDIJJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820")]
	private bool HKGLNKIDGEI(bool GPGJKJMFCFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
internal struct KGKJAAEFGKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct PEHFLKKDKEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public KGKJAAEFGKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x8495470", Offset = "0x8494470", VA = "0x188495470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x84959E0", Offset = "0x84949E0", VA = "0x1884959E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class NLLNNBHHILO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NLLNNBHHILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x84932E0", Offset = "0x84922E0", VA = "0x1884932E0")]
		internal object MDJIAKPDBCE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private struct LMMMKDOLNDG : IAsyncStateMachine
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
		public KGKJAAEFGKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x84908A0", Offset = "0x848F8A0", VA = "0x1884908A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x8490D30", Offset = "0x848FD30", VA = "0x188490D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private AHKCDLBPKNG DNEDILMENHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private bool CDPOAJCCACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private JOEFAEBJKIB APDBNIMCPID;

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x848F340", Offset = "0x848E340", VA = "0x18848F340")]
	public static Task<Scene> LGEJEHLNBKI(IPAGNGHLCCF BFCIGLOEMAP, AHKCDLBPKNG DLLDHIIMPKO, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x848F180", Offset = "0x848E180", VA = "0x18848F180")]
	[AsyncStateMachine(typeof(PEHFLKKDKEK))]
	private Task<Scene> GDMALPFODEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x848F2A0", Offset = "0x848E2A0", VA = "0x18848F2A0")]
	private bool GOKJHKPJHKF(JOEFAEBJKIB APDBNIMCPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x848F2D0", Offset = "0x848E2D0", VA = "0x18848F2D0")]
	private void IGPNICKEGEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x848F030", Offset = "0x848E030", VA = "0x18848F030")]
	[AsyncStateMachine(typeof(LMMMKDOLNDG))]
	private Task<Scene> AAAMEHIBOMA(string NHHGKEDIJJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal struct EKILGEACLCB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct OFMJNIKBFPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public EKILGEACLCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public IHHBKLENLMK nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public JOEFAEBJKIB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private TaskAwaiter<IHHBKLENLMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x8493EB0", Offset = "0x8492EB0", VA = "0x188493EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x8494980", Offset = "0x8493980", VA = "0x188494980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct MNOJFKAAKCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public EKILGEACLCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public IHHBKLENLMK state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x8492B00", Offset = "0x8491B00", VA = "0x188492B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x8492DE0", Offset = "0x8491DE0", VA = "0x188492DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	private readonly GEHMKHHFLAO AJGFGCKEHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private readonly PLHOCFLCCME AANEBFKDCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private readonly PHFJIAMDFFA LDGKLCBAEKI;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private PPPBMGNNDNF AAIHBKEDJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x69028C0", Offset = "0x69018C0", VA = "0x1869028C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x8485470", Offset = "0x8484470", VA = "0x188485470")]
	public EKILGEACLCB(GEHMKHHFLAO AJGFGCKEHBB, PLHOCFLCCME AANEBFKDCIJ, PHFJIAMDFFA LDGKLCBAEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x84852C0", Offset = "0x84842C0", VA = "0x1884852C0")]
	[AsyncStateMachine(typeof(OFMJNIKBFPE))]
	public Task<IHHBKLENLMK> KPKNHBIGEMI(IHHBKLENLMK EFAPNPKMFEC, JOEFAEBJKIB GIJBGILJKNL, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF, bool CIPDMCKNNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x8485160", Offset = "0x8484160", VA = "0x188485160")]
	[AsyncStateMachine(typeof(MNOJFKAAKCG))]
	private Task<IHHBKLENLMK> BJMCBFJMCHK(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, IHHBKLENLMK IDAKFFICKHC, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x8485440", Offset = "0x8484440", VA = "0x188485440")]
	private bool NGAFJKEIKIO(IHHBKLENLMK ECLMPMLLNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x8485140", Offset = "0x8484140", VA = "0x188485140")]
	private void AHIMDJPCPBN(string AACKKPGJBPA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal struct OIJDHBECCGN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct IFJJKALNFKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public PPPBMGNNDNF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public AMIGCLEJKKN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private JHEDBCMAENC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private List<(PersistenceView, DJNGLNAIHJJ)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private (PersistenceView, DJNGLNAIHJJ) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x848BA50", Offset = "0x848AA50", VA = "0x18848BA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x848C120", Offset = "0x848B120", VA = "0x18848C120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x84949F0", Offset = "0x84939F0", VA = "0x1884949F0")]
	[AsyncStateMachine(typeof(IFJJKALNFKC))]
	public static Task GDMALPFODEM(PPPBMGNNDNF AOHGJNGCBBI, JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal struct NKNKPDPJMKB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct HMLIJHDMLCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public PPPBMGNNDNF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public AMIGCLEJKKN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private APPGMHGFBGI <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private JHEDBCMAENC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private List<(PersistenceView, DJNGLNAIHJJ)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private DJNGLNAIHJJ <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x848AE20", Offset = "0x8489E20", VA = "0x18848AE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x848B700", Offset = "0x848A700", VA = "0x18848B700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x84931A0", Offset = "0x84921A0", VA = "0x1884931A0")]
	[AsyncStateMachine(typeof(HMLIJHDMLCO))]
	public static Task GDMALPFODEM(PPPBMGNNDNF AOHGJNGCBBI, JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
public struct HCIBNIKBMHI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private struct GJFEIGIGPHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<HFIBBAIEKFD, OGMCLKGLBPG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public HCIBNIKBMHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public LKLEKOGDEBE.OBNDLGOKJBI preloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		private TaskAwaiter<HHHCCNLMPJL<HFIBBAIEKFD, OGMCLKGLBPG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x8489A00", Offset = "0x8488A00", VA = "0x188489A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x848A080", Offset = "0x8489080", VA = "0x18848A080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private long OLIHOCDFDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private long AODGHMLLAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private Guid? BDKBBFKFOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	private IReadOnlyCollection<JJDFEBIHCFN> GFFKCAJABEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private IReadOnlyCollection<JJDFEBIHCFN> CEDOEFILHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private EMCAKAJMIMO JHDGAMGLDFA;

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x848A250", Offset = "0x8489250", VA = "0x18848A250")]
	public static Task<HHHCCNLMPJL<HFIBBAIEKFD, OGMCLKGLBPG>> GNAMKEEBKGL(long CINEDGEJAIA, long NBOIIPJHEBJ, NEDLDDMDCHB KLDLPBNELBC, LKLEKOGDEBE.OBNDLGOKJBI FGPMNAKBLHC, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x848A0F0", Offset = "0x84890F0", VA = "0x18848A0F0")]
	[AsyncStateMachine(typeof(GJFEIGIGPHD))]
	private Task<HHHCCNLMPJL<HFIBBAIEKFD, OGMCLKGLBPG>> GDMALPFODEM(LKLEKOGDEBE.OBNDLGOKJBI FGPMNAKBLHC, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
internal struct AGJCFBFMDCK
{
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	public struct DDCNOPNHDPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public List<FLOHPLGLJLN> HCGEDANEBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public List<DJNGLNAIHJJ> OHNOBDFHNNP;

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xAAAD70", Offset = "0xAA9D70", VA = "0x180AAAD70")]
		public DDCNOPNHDPM(List<FLOHPLGLJLN> HCGEDANEBJM, List<DJNGLNAIHJJ> OHNOBDFHNNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class KOFEDGDICFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public IEnumerable<FLOHPLGLJLN> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public KOFEDGDICFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x8490030", Offset = "0x848F030", VA = "0x188490030")]
		internal object EBAIPAPHEEJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	private JOEFAEBJKIB APDBNIMCPID;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private JHHKOFMOFFM PLBPABECHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x8480270", Offset = "0x847F270", VA = "0x188480270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x8480870", Offset = "0x847F870", VA = "0x188480870")]
	public static DDCNOPNHDPM GDMALPFODEM(IPAGNGHLCCF BFCIGLOEMAP, JOEFAEBJKIB APDBNIMCPID)
	{
		return default(DDCNOPNHDPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x84808D0", Offset = "0x847F8D0", VA = "0x1884808D0")]
	private DDCNOPNHDPM GDMALPFODEM()
	{
		return default(DDCNOPNHDPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x84802C0", Offset = "0x847F2C0", VA = "0x1884802C0")]
	private DDCNOPNHDPM FFCAJOBIBCG(BPLHNECCAPN DELDEHHAKDM, APPGMHGFBGI HLPIFOPEBCL)
	{
		return default(DDCNOPNHDPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x84800A0", Offset = "0x847F0A0", VA = "0x1884800A0")]
	private bool CFKGONFDLJM(IEnumerable<FLOHPLGLJLN> HCGEDANEBJM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal struct APBCKENEMNN
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class KFHIBDEHKMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public AGJCFBFMDCK.DDCNOPNHDPM instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public KFHIBDEHKMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x848EC30", Offset = "0x848DC30", VA = "0x18848EC30")]
		internal object OKNAKMDFPMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class OEILBBHPBDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public OEILBBHPBDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x8493E20", Offset = "0x8492E20", VA = "0x188493E20")]
		internal object DFBECEDJHLP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x8481190", Offset = "0x8480190", VA = "0x188481190")]
	public static void GDMALPFODEM(PPPBMGNNDNF AOHGJNGCBBI, JOEFAEBJKIB APDBNIMCPID, AGJCFBFMDCK.DDCNOPNHDPM AOHAMOKDOPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal class PHFJIAMDFFA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private struct JBAEBDJADON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public PHFJIAMDFFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public IHHBKLENLMK operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public JOEFAEBJKIB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x848D0F0", Offset = "0x848C0F0", VA = "0x18848D0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x848D860", Offset = "0x848C860", VA = "0x18848D860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class OGABNIJNPBG
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
			public OGABNIJNPBG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006E8")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006E9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x84A90E0", Offset = "0x84A80E0", VA = "0x1884A90E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x84A9280", Offset = "0x84A8280", VA = "0x1884A9280", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public PHFJIAMDFFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public OGABNIJNPBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x84A81B0", Offset = "0x84A71B0", VA = "0x1884A81B0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task HFKCNMEBCIO(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private struct IHDAGKDDBIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public PHFJIAMDFFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		private OGABNIJNPBG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x84A1640", Offset = "0x84A0640", VA = "0x1884A1640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x84A1B70", Offset = "0x84A0B70", VA = "0x1884A1B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private struct JLNPENACEGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public PHFJIAMDFFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		private Dictionary<Guid, List<JCIEFCALJCE>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x84A4D60", Offset = "0x84A3D60", VA = "0x1884A4D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x84A5370", Offset = "0x84A4370", VA = "0x1884A5370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private struct MIDLIFGDKKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public PHFJIAMDFFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private Dictionary<Guid, List<JCIEFCALJCE>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x84A58D0", Offset = "0x84A48D0", VA = "0x1884A58D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x84A5F60", Offset = "0x84A4F60", VA = "0x1884A5F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private sealed class CCIDIDGHFPN
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
			public JCIEFCALJCE handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400070C")]
			public CCIDIDGHFPN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400070D")]
			private JHEDBCMAENC <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400070E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0x84A8C10", Offset = "0x84A7C10", VA = "0x1884A8C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(RVA = "0x84A9080", Offset = "0x84A8080", VA = "0x1884A9080", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public LOIOFANBADN runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public List<JCIEFCALJCE> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public CCIDIDGHFPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x849BC90", Offset = "0x849AC90", VA = "0x18849BC90")]
		internal object BEGBKCEIFBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x849BE70", Offset = "0x849AE70", VA = "0x18849BE70")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task MGHNPBCEIKG(JCIEFCALJCE handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x849BD80", Offset = "0x849AD80", VA = "0x18849BD80")]
		internal object LFNANEBNEPC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private struct GJDICBCNGOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public LOIOFANBADN runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public List<JCIEFCALJCE> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private CCIDIDGHFPN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x84A02C0", Offset = "0x849F2C0", VA = "0x1884A02C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x84A0790", Offset = "0x849F790", VA = "0x1884A0790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private struct KNCAJMBNIEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public PHFJIAMDFFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

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
		[Cpp2IlInjected.Address(RVA = "0x84A53D0", Offset = "0x84A43D0", VA = "0x1884A53D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x84A56C0", Offset = "0x84A46C0", VA = "0x1884A56C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class CKFBCNHGNPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public CKFBCNHGNPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x849C380", Offset = "0x849B380", VA = "0x18849C380")]
		internal object CGDELGEBGKD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private struct FDAGPIAGNJI : IAsyncStateMachine
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
		public PHFJIAMDFFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x849E620", Offset = "0x849D620", VA = "0x18849E620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x849EAD0", Offset = "0x849DAD0", VA = "0x18849EAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class BBIHMOLBALH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BBIHMOLBALH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x849B2C0", Offset = "0x849A2C0", VA = "0x18849B2C0")]
		internal object AINMJLJADJA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct IMBIBILDLLC : IAsyncStateMachine
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
		public PHFJIAMDFFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x84A1C50", Offset = "0x84A0C50", VA = "0x1884A1C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x84A2280", Offset = "0x84A1280", VA = "0x1884A2280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class MNGBHPALJME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public MNGBHPALJME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x84A64E0", Offset = "0x84A54E0", VA = "0x1884A64E0")]
		internal object OJIPBAKIAKA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private readonly GEHMKHHFLAO AJGFGCKEHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private LMMOHLNEFMM LDGKLCBAEKI;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private PPPBMGNNDNF AAIHBKEDJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x10C9580", Offset = "0x10C8580", VA = "0x1810C9580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public PHFJIAMDFFA(GEHMKHHFLAO AJGFGCKEHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x8496010", Offset = "0x8495010", VA = "0x188496010")]
	[AsyncStateMachine(typeof(JBAEBDJADON))]
	public Task GDMALPFODEM(IHHBKLENLMK NHCKJIIHJGE, JOEFAEBJKIB GIJBGILJKNL, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x8496480", Offset = "0x8495480", VA = "0x188496480")]
	[AsyncStateMachine(typeof(IHDAGKDDBIJ))]
	private Task IJHKGPDNHFM(JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x8496850", Offset = "0x8495850", VA = "0x188496850")]
	[AsyncStateMachine(typeof(JLNPENACEGJ))]
	private Task NNCEFILELKE(JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x84965C0", Offset = "0x84955C0", VA = "0x1884965C0")]
	[AsyncStateMachine(typeof(MIDLIFGDKKE))]
	private Task JLFFCILAPIF(JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x8496700", Offset = "0x8495700", VA = "0x188496700")]
	[AsyncStateMachine(typeof(GJDICBCNGOJ))]
	private Task MMPKKMIIKGK(Guid KGIKCAHMNMJ, List<JCIEFCALJCE> AHFMANOMGMM, LOIOFANBADN ENNNHBGPBFL, JOEFAEBJKIB APDBNIMCPID, CancellationToken EJJDDFFADPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x8495ED0", Offset = "0x8494ED0", VA = "0x188495ED0")]
	[AsyncStateMachine(typeof(KNCAJMBNIEE))]
	private Task GCGIHGMMAIA(JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x8496340", Offset = "0x8495340", VA = "0x188496340")]
	[AsyncStateMachine(typeof(FDAGPIAGNJI))]
	private Task HAIFBNLHNMF(Guid AHEIMNKCFGL, JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x8495CE0", Offset = "0x8494CE0", VA = "0x188495CE0")]
	[AsyncStateMachine(typeof(IMBIBILDLLC))]
	private Task COIDOEGLIIM(Guid AHEIMNKCFGL, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x8495BC0", Offset = "0x8494BC0", VA = "0x188495BC0")]
	private void CCEKOJAJFOE(Guid AHEIMNKCFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x8495E20", Offset = "0x8494E20", VA = "0x188495E20")]
	private void DBMDHJDBMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x8495A50", Offset = "0x8494A50", VA = "0x188495A50")]
	public Guid BMIGNMHOGJO(IHHBKLENLMK PAJPHIMOMIF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x8496160", Offset = "0x8495160", VA = "0x188496160")]
	[CompilerGenerated]
	private object GNHKGBNLDAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
internal struct LIIFKOJAKIB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private struct APJJOKAICOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public LIIFKOJAKIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		private IEnumerator<JMBLJGACIPD> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x849A1E0", Offset = "0x84991E0", VA = "0x18849A1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x849A880", Offset = "0x8499880", VA = "0x18849A880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000737")]
	private JHHKOFMOFFM DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000738")]
	private LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000739")]
	private CancellationToken CBJPDIFOEKF;

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x84A5770", Offset = "0x84A4770", VA = "0x1884A5770")]
	public static Task DIENEBAEOMC(JHHKOFMOFFM DHJEDIPMPLO, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken JDCDGDBBGIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x84A57E0", Offset = "0x84A47E0", VA = "0x1884A57E0")]
	[AsyncStateMachine(typeof(APJJOKAICOL))]
	private Task GDMALPFODEM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public readonly struct GHIBGJOBNGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000740")]
	public readonly bool CBPKCEJAKBJ;

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x29A56F0", Offset = "0x29A46F0", VA = "0x1829A56F0")]
	public GHIBGJOBNGE(bool CEJFGABFDAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public readonly struct HFEJJAMCGEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000741")]
	public readonly BPLHNECCAPN? NFLGDLDCAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000742")]
	public readonly IKNHBNNCJJD FHLPMMMIOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000743")]
	public readonly Guid? KJPMNOCOJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000744")]
	public readonly IReadOnlyList<Guid> BJJGAMKNDKB;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public IReadOnlyCollection<string> NHLOMDEHAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x84A0C00", Offset = "0x849FC00", VA = "0x1884A0C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public IReadOnlyDictionary<long, int> MPFOJEFIJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x84A0C20", Offset = "0x849FC20", VA = "0x1884A0C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x84A0C40", Offset = "0x849FC40", VA = "0x1884A0C40")]
	public HFEJJAMCGEP(BPLHNECCAPN? MKIDPONBDDE, IKNHBNNCJJD FEHGBNNFHCB, Guid? DMDDOFCAJJF, [Optional] IReadOnlyList<Guid>? JGKMLGPNMHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal class MOJFFBJNPFJ : CGFGCNFFKKJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private struct DEBHNGKCJAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public AsyncTaskMethodBuilder<HFEJJAMCGEP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public MOJFFBJNPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public FHEBLHGADNG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public MJJOEIPLFFL roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		private JHEDBCMAENC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x849CFB0", Offset = "0x849BFB0", VA = "0x18849CFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x849D650", Offset = "0x849C650", VA = "0x18849D650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[CompilerGenerated]
	private sealed class BDJLBHLMJJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BDJLBHLMJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x849B330", Offset = "0x849A330", VA = "0x18849B330")]
		internal object MJOAIHILEOI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[CompilerGenerated]
	private struct FHPBFEOMJFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public MOJFFBJNPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public FHEBLHGADNG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		private BDJLBHLMJJE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		private JHEDBCMAENC <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		private IEALDBHBOML<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x849EB30", Offset = "0x849DB30", VA = "0x18849EB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x849F600", Offset = "0x849E600", VA = "0x18849F600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000745")]
	private readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000746")]
	private static readonly TimeSpan EAFGOHCLJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000747")]
	private readonly FJIPBDIIELL HNIEEBOHBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000748")]
	private readonly JHCGHNLIGPE DPAAKCMGANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000749")]
	private readonly PBCBIJGDOEH OKJENHLCDON;

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x84A7710", Offset = "0x84A6710", VA = "0x1884A7710")]
	public MOJFFBJNPFJ(GEHMKHHFLAO AJGFGCKEHBB, FJIPBDIIELL HNIEEBOHBEN, JHCGHNLIGPE GNCBIKPPMJO, PBCBIJGDOEH OKJENHLCDON, JBBHIJHGEPM PAJIGEJCNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x84A7000", Offset = "0x84A6000", VA = "0x1884A7000")]
	[AsyncStateMachine(typeof(DEBHNGKCJAH))]
	public Task<HFEJJAMCGEP> DFNAEDFOBIJ(long NBOIIPJHEBJ, MJJOEIPLFFL BICOFHMOEBP, FHEBLHGADNG DMBMNBBDHKN, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x84A7560", Offset = "0x84A6560", VA = "0x1884A7560")]
	[AsyncStateMachine(typeof(FHPBFEOMJFD))]
	private Task NEGOKDJDMDC(FHEBLHGADNG DMBMNBBDHKN, PersistenceView[] HKOHHLANDDM, StringBuilder FJJFEBNNKCK, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x84A6550", Offset = "0x84A5550", VA = "0x1884A6550")]
	private HFEJJAMCGEP BHCPMJGCBML(long NBOIIPJHEBJ, MJJOEIPLFFL BICOFHMOEBP, FHEBLHGADNG DMBMNBBDHKN, IEnumerable<PersistenceView> HKOHHLANDDM, StringBuilder FJJFEBNNKCK)
	{
		return default(HFEJJAMCGEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x84A7150", Offset = "0x84A6150", VA = "0x1884A7150")]
	private BPLHNECCAPN LGMECJMODPB(long NBOIIPJHEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x84A7310", Offset = "0x84A6310", VA = "0x1884A7310")]
	private void MPICBEAOLKA(BPLHNECCAPN ILAABPGJMFE, StringBuilder FJJFEBNNKCK, IEnumerable<PersistenceView> HKOHHLANDDM, [In] BELCGLLEFHB GCGBHFPEKCE, HDGPNFAELAI FGPPEIIOCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x84A6B60", Offset = "0x84A5B60", VA = "0x1884A6B60")]
	private void CPILJCJFLHH(BPLHNECCAPN ILAABPGJMFE, StringBuilder FJJFEBNNKCK, PersistenceView NNAEIGBDCOK, HDGPNFAELAI FGPPEIIOCJJ, [In] BELCGLLEFHB GCGBHFPEKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
internal class DMPOKLHCOJD : CGFGCNFFKKJ
{
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private sealed class LDHIBJJJBKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public KAKCKKIHOCK.ADGAEKFCFIH roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public LDHIBJJJBKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x84A5720", Offset = "0x84A4720", VA = "0x1884A5720")]
		internal object EHCGMCGMMGN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private struct BJDLKBGLHII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public AsyncTaskMethodBuilder<(KAKCKKIHOCK.ADGAEKFCFIH roomDataUpload, KAKCKKIHOCK.ADGAEKFCFIH subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public HFEJJAMCGEP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public JHHKOFMOFFM callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		private LDHIBJJJBKC <>8__1;

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
		private TaskAwaiter<KAKCKKIHOCK.ADGAEKFCFIH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x849B3A0", Offset = "0x849A3A0", VA = "0x18849B3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x849BC20", Offset = "0x849AC20", VA = "0x18849BC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private struct APNCNIKFIFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public AsyncTaskMethodBuilder<GHABJHKCBDN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public DMPOKLHCOJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public MDNOEFMCADI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public HFEJJAMCGEP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private TaskAwaiter<GHABJHKCBDN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x849A8E0", Offset = "0x84998E0", VA = "0x18849A8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x849AB80", Offset = "0x8499B80", VA = "0x18849AB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private struct BALAEHOGAOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		public AsyncTaskMethodBuilder<GHABJHKCBDN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		public JHHKOFMOFFM callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		public HFEJJAMCGEP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		public FHMABBJMFCN ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public MDNOEFMCADI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		private TaskAwaiter<(KAKCKKIHOCK.ADGAEKFCFIH roomDataUpload, KAKCKKIHOCK.ADGAEKFCFIH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		private TaskAwaiter<GHABJHKCBDN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x849ABF0", Offset = "0x8499BF0", VA = "0x18849ABF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x849B250", Offset = "0x849A250", VA = "0x18849B250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct MMGMFJAHGEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public AsyncTaskMethodBuilder<NOEKMJCDIOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public DMPOKLHCOJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public HFEJJAMCGEP roomSerializedData;

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
		private TaskAwaiter<(KAKCKKIHOCK.ADGAEKFCFIH roomDataUpload, KAKCKKIHOCK.ADGAEKFCFIH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		private TaskAwaiter<NOEKMJCDIOB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x84A5FC0", Offset = "0x84A4FC0", VA = "0x1884A5FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x84A6470", Offset = "0x84A5470", VA = "0x1884A6470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private sealed class NEMFJEKCEFM
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
			public AsyncTaskMethodBuilder<DAEAHJMMAED> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000798")]
			public NEMFJEKCEFM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000799")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400079A")]
			private DAEAHJMMAED <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400079B")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400079C")]
			private TaskAwaiter<NOEKMJCDIOB> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400079D")]
			private TaskAwaiter<GHABJHKCBDN> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400079E")]
			private TaskAwaiter<DAEAHJMMAED> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006B8")]
			[Cpp2IlInjected.Address(RVA = "0x84A92E0", Offset = "0x84A82E0", VA = "0x1884A92E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B9")]
			[Cpp2IlInjected.Address(RVA = "0x84AA4E0", Offset = "0x84A94E0", VA = "0x1884AA4E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public DMPOKLHCOJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public HFEJJAMCGEP roomSerializedData;

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
		public MDNOEFMCADI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public GHIBGJOBNGE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NEMFJEKCEFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x84A8080", Offset = "0x84A7080", VA = "0x1884A8080")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<DAEAHJMMAED> DNBDBOKLFAK(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private struct HIPOBDEPEJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		public AsyncTaskMethodBuilder<DAEAHJMMAED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		public DMPOKLHCOJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		public HFEJJAMCGEP roomSerializedData;

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
		public MDNOEFMCADI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		public GHIBGJOBNGE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x84A0DE0", Offset = "0x849FDE0", VA = "0x1884A0DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x84A1110", Offset = "0x84A0110", VA = "0x1884A1110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000763")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000764")]
	private static readonly JBBHIJHGEPM HDNPMENDLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000765")]
	private readonly FCNEEADCJIO DILAOJNHENM;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private IPAGNGHLCCF KFEELBCAGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x8468310", Offset = "0x8467310", VA = "0x188468310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x849E230", Offset = "0x849D230", VA = "0x18849E230")]
	public DMPOKLHCOJD(GEHMKHHFLAO AJGFGCKEHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x849D9F0", Offset = "0x849C9F0", VA = "0x18849D9F0")]
	[AsyncStateMachine(typeof(BJDLKBGLHII))]
	private static Task<(KAKCKKIHOCK.ADGAEKFCFIH, KAKCKKIHOCK.ADGAEKFCFIH)> HKBHDCPBPIL(JHHKOFMOFFM DHJEDIPMPLO, HFEJJAMCGEP KMDNEDBDMKJ, long CINEDGEJAIA, long DPKCNMHAPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x849DB40", Offset = "0x849CB40", VA = "0x18849DB40")]
	[AsyncStateMachine(typeof(APNCNIKFIFD))]
	public Task<GHABJHKCBDN> MKEIEBDFEFK(int BGINAMOOLIJ, [CanBeNull] MDNOEFMCADI LMHJJMIBAMA, HFEJJAMCGEP KMDNEDBDMKJ, long CINEDGEJAIA, long DPKCNMHAPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x849DE40", Offset = "0x849CE40", VA = "0x18849DE40")]
	public static Task<GHABJHKCBDN> MKEIEBDFEFK(JHHKOFMOFFM DHJEDIPMPLO, int BGINAMOOLIJ, [CanBeNull] MDNOEFMCADI LMHJJMIBAMA, HFEJJAMCGEP KMDNEDBDMKJ, long CINEDGEJAIA, long DPKCNMHAPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x849DCB0", Offset = "0x849CCB0", VA = "0x18849DCB0")]
	[AsyncStateMachine(typeof(BALAEHOGAOI))]
	public static Task<GHABJHKCBDN> MKEIEBDFEFK(JHHKOFMOFFM DHJEDIPMPLO, int BGINAMOOLIJ, [CanBeNull] MDNOEFMCADI LMHJJMIBAMA, HFEJJAMCGEP KMDNEDBDMKJ, long CINEDGEJAIA, long DPKCNMHAPEB, FHMABBJMFCN IFNGLDEADKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x849D6C0", Offset = "0x849C6C0", VA = "0x18849D6C0")]
	[AsyncStateMachine(typeof(MMGMFJAHGEN))]
	private Task<NOEKMJCDIOB> BLDBFIFJCJP(string JMBBDHDFKMN, int BGINAMOOLIJ, HFEJJAMCGEP KMDNEDBDMKJ, long CINEDGEJAIA, long DPKCNMHAPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x849D840", Offset = "0x849C840", VA = "0x18849D840")]
	[AsyncStateMachine(typeof(HIPOBDEPEJM))]
	public Task<DAEAHJMMAED> HHFFPLDCOPG(int BGINAMOOLIJ, MDNOEFMCADI? LMHJJMIBAMA, HFEJJAMCGEP KMDNEDBDMKJ, long CINEDGEJAIA, long DPKCNMHAPEB, GHIBGJOBNGE HMEALLJEACK, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
public abstract class JJEOFOBLPPE<T> where T : JJEOFOBLPPE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007AB")]
	internal readonly IPAGNGHLCCF CMIMNHJBHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007AC")]
	private int? OGCAMFNODBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007AD")]
	protected readonly Guid EHBJDHPDJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007AE")]
	protected readonly MCEHODFGIME PMGOEHPMGKM;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected T OAMLFEMFPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x4E3AC70", Offset = "0x4E39C70", VA = "0x184E3AC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x4E3ACD0", Offset = "0x4E39CD0", VA = "0x184E3ACD0")]
	internal JJEOFOBLPPE(IPAGNGHLCCF HMCEMLGBOJN, MCEHODFGIME IKONCMMACKE, [Optional] Guid? DHFBDLBBCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x4E3AB90", Offset = "0x4E39B90", VA = "0x184E3AB90")]
	private DAEAHJMMAED IDBFCFMCDOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	protected virtual void JKADJDONKCD(DAEAHJMMAED NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x4E3AA40", Offset = "0x4E39A40", VA = "0x184E3AA40")]
	public T FMPHLFCEFOL(AIPAHMNCJKP MCADOGGHICO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x4E3AAE0", Offset = "0x4E39AE0", VA = "0x184E3AAE0")]
	public T GCAAPBKHAPE(int COAOFMGNHMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x4E3A910", Offset = "0x4E39910", VA = "0x184E3A910", Slot = "5")]
	public virtual Task<GGIHIJCCBHJ> EALGDBLMHNA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
public class JKIIIKPEIIP : JJEOFOBLPPE<JKIIIKPEIIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007AF")]
	private AENKMJAJKCL DGHLABNPIEC;

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x84A3470", Offset = "0x84A2470", VA = "0x1884A3470")]
	internal JKIIIKPEIIP(IPAGNGHLCCF HMCEMLGBOJN, MCEHODFGIME IKONCMMACKE, [Optional] Guid? DHFBDLBBCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x7732360", Offset = "0x7731360", VA = "0x187732360")]
	public JKIIIKPEIIP GEAKCODCLHF(AENKMJAJKCL DGHLABNPIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x84A33A0", Offset = "0x84A23A0", VA = "0x1884A33A0", Slot = "4")]
	protected override void JKADJDONKCD(DAEAHJMMAED NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public class AJBKMDJKJOF : JJEOFOBLPPE<AJBKMDJKJOF>
{
	[Cpp2IlInjected.Token(Token = "0x20001B1")]
	internal enum IBDBHFCMOBG
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
	private struct CIBOKOHJFEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007B8")]
		public AsyncTaskMethodBuilder<GGIHIJCCBHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public AJBKMDJKJOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		private TaskAwaiter<GGIHIJCCBHJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x849BF70", Offset = "0x849AF70", VA = "0x18849BF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x849C310", Offset = "0x849B310", VA = "0x18849C310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007B0")]
	private IBDBHFCMOBG HKNBGIJKCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007B1")]
	private string APANPFBLGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007B2")]
	private MDNOEFMCADI DGHLABNPIEC;

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x8499D30", Offset = "0x8498D30", VA = "0x188499D30")]
	internal AJBKMDJKJOF(IPAGNGHLCCF HMCEMLGBOJN, MCEHODFGIME IKONCMMACKE, [Optional] Guid? DHFBDLBBCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x8499A30", Offset = "0x8498A30", VA = "0x188499A30")]
	public AJBKMDJKJOF BFBNCLLCHHE(string HHPFBMBMELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x84999F0", Offset = "0x84989F0", VA = "0x1884999F0")]
	public AJBKMDJKJOF AGKIPELMDFB(bool GFMFLEPMNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x8499A10", Offset = "0x8498A10", VA = "0x188499A10")]
	public AJBKMDJKJOF AODONBEPFDH(bool EGDBBMJKJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x8499A60", Offset = "0x8498A60", VA = "0x188499A60")]
	public AJBKMDJKJOF DKAJODAAKDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x8499BC0", Offset = "0x8498BC0", VA = "0x188499BC0", Slot = "4")]
	protected override void JKADJDONKCD(DAEAHJMMAED NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x8499A90", Offset = "0x8498A90", VA = "0x188499A90", Slot = "5")]
	[AsyncStateMachine(typeof(CIBOKOHJFEN))]
	public override Task<GGIHIJCCBHJ> EALGDBLMHNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x8499B80", Offset = "0x8498B80", VA = "0x188499B80")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<GGIHIJCCBHJ> IAPAGHMNHLN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
internal static class OGMPMEKOCBP
{
	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x84A8970", Offset = "0x84A7970", VA = "0x1884A8970")]
	public static void PKDLJEOCDIA(this IKJOECKPNBM HCIBJEJKPFM, PAIKJEGABFG FKPLNDNGIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x84A88F0", Offset = "0x84A78F0", VA = "0x1884A88F0")]
	public static void IGBMBKGDDBD(this PAIKJEGABFG HJHEMAOEAHO, [Optional] string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
public static class OHECHOJLIPD
{
	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x84A8B70", Offset = "0x84A7B70", VA = "0x1884A8B70")]
	public static NGHKAOKDFBL PIJLIHCCPFJ(this MJLOLKIDFMP OMEHHNGIHKJ)
	{
		return default(NGHKAOKDFBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x84A8AC0", Offset = "0x84A7AC0", VA = "0x1884A8AC0")]
	public static MJLOLKIDFMP CGPGGHJAFDM(this NGHKAOKDFBL ONJNMMMAKMJ)
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
			public GKOJCGDILMH ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007C0")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007C1")]
			public GKOJCGDILMH HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		private static GKOJCGDILMH[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		private Dictionary<GKOJCGDILMH, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x84AAB00", Offset = "0x84A9B00", VA = "0x1884AAB00")]
		public bool KEHIAPILGAG(GKOJCGDILMH ECOONOEHGGP, [Out] ResultConfig NFFGNPJGBOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x84AAB70", Offset = "0x84A9B70", VA = "0x1884AAB70")]
		public ResultConfig OODEHJABLJO(GKOJCGDILMH DKBCGBFNIGO, [Optional] HashSet<GKOJCGDILMH> HDFKKPCHFAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x84AB280", Offset = "0x84AA280", VA = "0x1884AB280", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x84AACB0", Offset = "0x84A9CB0", VA = "0x1884AACB0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xBA1DF0", Offset = "0xBA0DF0", VA = "0x180BA1DF0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B8")]
public class AKNGIKBBHKG : OKGFEPLGNNN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[CompilerGenerated]
	private struct DPMDNPAPNKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		public AKNGIKBBHKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x849E2C0", Offset = "0x849D2C0", VA = "0x18849E2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x849E550", Offset = "0x849D550", VA = "0x18849E550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[CompilerGenerated]
	private struct JLADLODNINO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		public OKGFEPLGNNN preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x84A3540", Offset = "0x84A2540", VA = "0x1884A3540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x84A39F0", Offset = "0x84A29F0", VA = "0x1884A39F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007CA")]
	private readonly FADGJJEOCKD NPGOEEEJDDL;

	[Cpp2IlInjected.Token(Token = "0x40007CB")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public string IMDPEJLINIL
	{
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x8499F10", Offset = "0x8498F10", VA = "0x188499F10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x8499EA0", Offset = "0x8498EA0", VA = "0x188499EA0")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	internal static void CPNCJILCPPN(AINJBKKEAIL PJLGMBBLBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public AKNGIKBBHKG([DJIFKCCBBND(null)] FADGJJEOCKD NPGOEEEJDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x8499F40", Offset = "0x8498F40", VA = "0x188499F40", Slot = "5")]
	[AsyncStateMachine(typeof(DPMDNPAPNKA))]
	public Task GDMALPFODEM(LDCGKGNFMMI<string>.CKHHEKIPJDF MCLBGLJLFCK, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x849A050", Offset = "0x8499050", VA = "0x18849A050")]
	[AsyncStateMachine(typeof(JLADLODNINO))]
	private Task GDPBDKHNMNB(OKGFEPLGNNN MEBFMFIEGMH, LDCGKGNFMMI<string>.CKHHEKIPJDF MCLBGLJLFCK, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
public interface FADGJJEOCKD : OKGFEPLGNNN
{
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
public interface OKGFEPLGNNN
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	string IMDPEJLINIL
	{
		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GDMALPFODEM(LDCGKGNFMMI<string>.CKHHEKIPJDF MCLBGLJLFCK, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
public static class GPADKKALJKB
{
	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x84A07F0", Offset = "0x849F7F0", VA = "0x1884A07F0")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	internal static void JPEDEHNINOC(AINJBKKEAIL PJLGMBBLBIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public interface OPPGGNKKPPF : IEquatable<OPPGGNKKPPF>
{
	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	DateTime EGIEPOFBJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFJDNJLICMH();

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GDEOLFKPCPI(long CINEDGEJAIA, long NBOIIPJHEBJ, [Out] HFEJJAMCGEP KMDNEDBDMKJ);
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
internal class DACHKOBCJIL : FKMGBBKKGNI
{
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	[CompilerGenerated]
	private sealed class EJMGKAANIED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		public KNEDGBILGPM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public EJMGKAANIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x849E5B0", Offset = "0x849D5B0", VA = "0x18849E5B0")]
		internal object EFGBLACOPJA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007D9")]
	private readonly DKJAMFBNPLF BPFIAFHIJHH;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<OPPGGNKKPPF> KIFCAFINGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x849C3F0", Offset = "0x849B3F0", VA = "0x18849C3F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x849CDE0", Offset = "0x849BDE0", VA = "0x18849CDE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	[UnityEngine.Scripting.Preserve]
	public DACHKOBCJIL([DJIFKCCBBND(null)] DKJAMFBNPLF BPFIAFHIJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x849C970", Offset = "0x849B970", VA = "0x18849C970", Slot = "6")]
	public bool EFGFHMKDHML(long CINEDGEJAIA, long NBOIIPJHEBJ, HFEJJAMCGEP KMDNEDBDMKJ, KNEDGBILGPM EDHLLDFNCFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0xDA7A10", Offset = "0xDA6A10", VA = "0x180DA7A10")]
	private void ACGHAPHBICM(OPPGGNKKPPF EBKHBJGGNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x849CC70", Offset = "0x849BC70", VA = "0x18849CC70", Slot = "7")]
	public bool FHNCAFIPDJA(long CINEDGEJAIA, long NBOIIPJHEBJ, [Out] OPPGGNKKPPF HIIKALLGCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x849C8C0", Offset = "0x849B8C0", VA = "0x18849C8C0", Slot = "8")]
	public bool EEPFFLLCOIA(long CINEDGEJAIA, long NBOIIPJHEBJ, KNEDGBILGPM EDHLLDFNCFM, [Out] OPPGGNKKPPF HIIKALLGCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x849C4A0", Offset = "0x849B4A0", VA = "0x18849C4A0")]
	private void EEMNNPJKEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x849CE90", Offset = "0x849BE90", VA = "0x18849CE90", Slot = "9")]
	public void MOEMLOMEHPE(long CINEDGEJAIA, long NBOIIPJHEBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
internal abstract class JKGNEDDKDBK : DKJAMFBNPLF
{
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	protected enum JKGCPKNFEAO : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007E1")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007E2")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C4")]
	[CompilerGenerated]
	private sealed class OGJAPNDBKJE : IEnumerable<OPPGGNKKPPF>, IEnumerable, IEnumerator<OPPGGNKKPPF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		private OPPGGNKKPPF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public JKGNEDDKDBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		private KNEDGBILGPM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		public KNEDGBILGPM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		private OPPGGNKKPPF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xE8B5B0", Offset = "0xE8A5B0", VA = "0x180E8B5B0")]
		[DebuggerHidden]
		public OGJAPNDBKJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x84A82A0", Offset = "0x84A72A0", VA = "0x1884A82A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x84A8580", Offset = "0x84A7580", VA = "0x1884A8580", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x84A84D0", Offset = "0x84A74D0", VA = "0x1884A84D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OPPGGNKKPPF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x84A84D0", Offset = "0x84A74D0", VA = "0x1884A84D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[CompilerGenerated]
	private sealed class HHPLNKPOKPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		public KNEDGBILGPM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public HHPLNKPOKPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x84A0D40", Offset = "0x849FD40", VA = "0x1884A0D40")]
		internal object OIJIHEJJOBK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[CompilerGenerated]
	private sealed class IJBHNCOAAOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		public JKGNEDDKDBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public IJBHNCOAAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x84A1BD0", Offset = "0x84A0BD0", VA = "0x1884A1BD0")]
		internal void LJHBPFDBIIB(HHPDMFCBIOB.GHCFLBOPIHD ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007DF")]
	private readonly object NDHFMFFJCBO;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	protected string PMCMJBNLCPC
	{
		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x84A2BD0", Offset = "0x84A1BD0", VA = "0x1884A2BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public abstract PPAOKKLNNOP EDAJMNNCAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x84A3320", Offset = "0x84A2320", VA = "0x1884A3320")]
	protected JKGNEDDKDBK([CanBeNull] string LDEMNPMAAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x84A28E0", Offset = "0x84A18E0", VA = "0x1884A28E0", Slot = "5")]
	public bool ABCOMPDCKBM(long CINEDGEJAIA, long NBOIIPJHEBJ, KNEDGBILGPM EDHLLDFNCFM, [Out] OPPGGNKKPPF EBKHBJGGNOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x84A2AD0", Offset = "0x84A1AD0", VA = "0x1884A2AD0", Slot = "6")]
	[IteratorStateMachine(typeof(OGJAPNDBKJE))]
	public IEnumerable<OPPGGNKKPPF> EGKNGFEDPFL(KNEDGBILGPM EDHLLDFNCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void FNMOKCMKIIE(Stream OCIOHDOCJBD, long CINEDGEJAIA, long NBOIIPJHEBJ, HFEJJAMCGEP KMDNEDBDMKJ);

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool IHCPINAMKCG(Stream GEAMOGAPCBF, long CINEDGEJAIA, long NBOIIPJHEBJ, CBMPHAAPMJB JKAKMBAHLDB, [Out] HFEJJAMCGEP KMDNEDBDMKJ);

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x84A2BE0", Offset = "0x84A1BE0", VA = "0x1884A2BE0", Slot = "7")]
	public OPPGGNKKPPF LKKBHHBBEOC(long CINEDGEJAIA, long NBOIIPJHEBJ, HFEJJAMCGEP KMDNEDBDMKJ, KNEDGBILGPM EDHLLDFNCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo PLJCCPGMDKL(long CINEDGEJAIA, long NBOIIPJHEBJ, KNEDGBILGPM EDHLLDFNCFM, JKGCPKNFEAO MCIHPICHCGD);

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo LFOGLJEIIMM(KNEDGBILGPM EDHLLDFNCFM, JKGCPKNFEAO MCIHPICHCGD);

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x84A2B60", Offset = "0x84A1B60", VA = "0x1884A2B60")]
	protected void GJBDPCEDJDE(HHPDMFCBIOB.GHCFLBOPIHD JFGIOLBDCAL, string AACKKPGJBPA, FileInfo KFCOHPJKAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x84A2F60", Offset = "0x84A1F60", VA = "0x1884A2F60")]
	internal bool MINFIHIJFPL(FileInfo BGOFIJFKOAL, long CINEDGEJAIA, long NBOIIPJHEBJ, [Out] HFEJJAMCGEP KMDNEDBDMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	private void PMDAJNJIFII(Exception FJADMGBFJLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
internal class GBCCGCEMGNB : JKGNEDDKDBK
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public override PPAOKKLNNOP EDAJMNNCAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x1D9E230", Offset = "0x1D9D230", VA = "0x181D9E230", Slot = "8")]
		get
		{
			return default(PPAOKKLNNOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x84A0280", Offset = "0x849F280", VA = "0x1884A0280")]
	public GBCCGCEMGNB([Optional] string LDEMNPMAAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x84A0110", Offset = "0x849F110", VA = "0x1884A0110")]
	private void LNAKLPECJGE(KNEDGBILGPM EDHLLDFNCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x849F660", Offset = "0x849E660", VA = "0x18849F660", Slot = "9")]
	internal override void FNMOKCMKIIE(Stream OCIOHDOCJBD, long CINEDGEJAIA, long NBOIIPJHEBJ, HFEJJAMCGEP KMDNEDBDMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x849F910", Offset = "0x849E910", VA = "0x18849F910", Slot = "10")]
	internal override bool IHCPINAMKCG(Stream GEAMOGAPCBF, long CINEDGEJAIA, long NBOIIPJHEBJ, CBMPHAAPMJB JKAKMBAHLDB, [Out] HFEJJAMCGEP KMDNEDBDMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x84A0190", Offset = "0x849F190", VA = "0x1884A0190", Slot = "11")]
	protected override FileInfo PLJCCPGMDKL(long CINEDGEJAIA, long NBOIIPJHEBJ, KNEDGBILGPM EDHLLDFNCFM, JKGCPKNFEAO MCIHPICHCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x84A0010", Offset = "0x849F010", VA = "0x1884A0010", Slot = "12")]
	protected override DirectoryInfo LFOGLJEIIMM(KNEDGBILGPM EDHLLDFNCFM, JKGCPKNFEAO MCIHPICHCGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
internal sealed class JLKAMOANDDE : JKGNEDDKDBK
{
	[Cpp2IlInjected.Token(Token = "0x40007EF")]
	private static readonly byte[] OEHHKNIGGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007F0")]
	private readonly byte[] AFNDJBKGMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007F1")]
	private readonly byte[] MGPONCFNDKH;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public override PPAOKKLNNOP EDAJMNNCAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x6F4E780", Offset = "0x6F4D780", VA = "0x186F4E780", Slot = "8")]
		get
		{
			return default(PPAOKKLNNOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x84A4C70", Offset = "0x84A3C70", VA = "0x1884A4C70")]
	public JLKAMOANDDE([Optional] string LDEMNPMAAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x84A3A50", Offset = "0x84A2A50", VA = "0x1884A3A50", Slot = "9")]
	internal override void FNMOKCMKIIE(Stream OCIOHDOCJBD, long CINEDGEJAIA, long NBOIIPJHEBJ, HFEJJAMCGEP KMDNEDBDMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x84A3F30", Offset = "0x84A2F30", VA = "0x1884A3F30", Slot = "10")]
	internal override bool IHCPINAMKCG(Stream GEAMOGAPCBF, long CINEDGEJAIA, long NBOIIPJHEBJ, CBMPHAAPMJB JKAKMBAHLDB, [Out] HFEJJAMCGEP KMDNEDBDMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x84A3E70", Offset = "0x84A2E70", VA = "0x1884A3E70")]
	private void GIPBBHAMHCN(byte[] ACDPPDBEDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x84A4AB0", Offset = "0x84A3AB0", VA = "0x1884A4AB0", Slot = "11")]
	protected override FileInfo PLJCCPGMDKL(long CINEDGEJAIA, long NBOIIPJHEBJ, KNEDGBILGPM EDHLLDFNCFM, JKGCPKNFEAO MCIHPICHCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x84A49A0", Offset = "0x84A39A0", VA = "0x1884A49A0", Slot = "12")]
	protected override DirectoryInfo LFOGLJEIIMM(KNEDGBILGPM EDHLLDFNCFM, JKGCPKNFEAO MCIHPICHCGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
public enum PPAOKKLNNOP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40007F5")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40007F6")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40007F7")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
internal class NDOKBCDOGGE : DKJAMFBNPLF
{
	[Cpp2IlInjected.Token(Token = "0x20001CD")]
	[CompilerGenerated]
	private sealed class ICDPOJJMLOE : IEnumerable<OPPGGNKKPPF>, IEnumerable, IEnumerator<OPPGGNKKPPF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		private OPPGGNKKPPF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		public NDOKBCDOGGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		private KNEDGBILGPM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000803")]
		public KNEDGBILGPM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		private PPAOKKLNNOP[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		private IEnumerator<OPPGGNKKPPF> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		private OPPGGNKKPPF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0xE8B5B0", Offset = "0xE8A5B0", VA = "0x180E8B5B0")]
		[DebuggerHidden]
		public ICDPOJJMLOE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x84A15B0", Offset = "0x84A05B0", VA = "0x1884A15B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x84A11D0", Offset = "0x84A01D0", VA = "0x1884A11D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x84A1180", Offset = "0x84A0180", VA = "0x1884A1180")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x84A1560", Offset = "0x84A0560", VA = "0x1884A1560", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x84A14B0", Offset = "0x84A04B0", VA = "0x1884A14B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OPPGGNKKPPF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x84A14B0", Offset = "0x84A04B0", VA = "0x1884A14B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F8")]
	private readonly PPAOKKLNNOP[] FCHFFOOHCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007F9")]
	private readonly Dictionary<PPAOKKLNNOP, DKJAMFBNPLF> LGHPHIMILFB;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public PPAOKKLNNOP EDAJMNNCAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x84A7BA0", Offset = "0x84A6BA0", VA = "0x1884A7BA0", Slot = "4")]
		get
		{
			return default(PPAOKKLNNOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x84A7D30", Offset = "0x84A6D30", VA = "0x1884A7D30")]
	[UnityEngine.Scripting.Preserve]
	public NDOKBCDOGGE(params DKJAMFBNPLF[] OHJBDPAMLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x84A7780", Offset = "0x84A6780", VA = "0x1884A7780", Slot = "5")]
	public bool ABCOMPDCKBM(long CINEDGEJAIA, long NBOIIPJHEBJ, KNEDGBILGPM EDHLLDFNCFM, [Out] OPPGGNKKPPF EBKHBJGGNOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x84A7960", Offset = "0x84A6960", VA = "0x1884A7960")]
	private void HDHFALPBFKL(int DFGKADJLHHG, long CINEDGEJAIA, long NBOIIPJHEBJ, KNEDGBILGPM EDHLLDFNCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x84A78D0", Offset = "0x84A68D0", VA = "0x1884A78D0", Slot = "6")]
	[IteratorStateMachine(typeof(ICDPOJJMLOE))]
	public IEnumerable<OPPGGNKKPPF> EGKNGFEDPFL(KNEDGBILGPM EDHLLDFNCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x84A7BD0", Offset = "0x84A6BD0", VA = "0x1884A7BD0", Slot = "7")]
	public OPPGGNKKPPF LKKBHHBBEOC(long CINEDGEJAIA, long NBOIIPJHEBJ, HFEJJAMCGEP KMDNEDBDMKJ, KNEDGBILGPM EDHLLDFNCFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
internal static class OGKNEMGCDFM
{
	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x84A8830", Offset = "0x84A7830", VA = "0x1884A8830")]
	internal static byte[] PCPAIAGIAKM(byte[] ACDPPDBEDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x84A85D0", Offset = "0x84A75D0", VA = "0x1884A85D0")]
	public static void ACDEGEEGHPM(Stream NLPKMHEBOCK, byte[] LALFPAPNFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x84A8650", Offset = "0x84A7650", VA = "0x1884A8650")]
	public static bool AOIAFIBPOGK(Stream NLPKMHEBOCK, long FKFJONJGMJL, CBMPHAAPMJB BFJNEIFGILB, [Out] byte[] ACLKDALNABC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
internal sealed class JKEBHBOGLMJ : OPPGGNKKPPF, IEquatable<OPPGGNKKPPF>, IEquatable<JKEBHBOGLMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000807")]
	private readonly JKGNEDDKDBK CPGANHOMLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000808")]
	public readonly FileInfo LGJILMJGKLJ;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public PPAOKKLNNOP EDAJMNNCAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x7D736E0", Offset = "0x7D726E0", VA = "0x187D736E0", Slot = "9")]
		get
		{
			return default(PPAOKKLNNOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public DateTime EGIEPOFBJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x84A2540", Offset = "0x84A1540", VA = "0x1884A2540", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x84A27D0", Offset = "0x84A17D0", VA = "0x1884A27D0")]
	public JKEBHBOGLMJ(JKGNEDDKDBK NELIDEAEIHF, FileInfo BGOFIJFKOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x84A2720", Offset = "0x84A1720", VA = "0x1884A2720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x84A2660", Offset = "0x84A1660", VA = "0x1884A2660", Slot = "5")]
	public void NFJDNJLICMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x84A2500", Offset = "0x84A1500", VA = "0x1884A2500", Slot = "6")]
	public bool GDEOLFKPCPI(long CINEDGEJAIA, long NBOIIPJHEBJ, [Out] HFEJJAMCGEP KMDNEDBDMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x84A2490", Offset = "0x84A1490", VA = "0x1884A2490", Slot = "7")]
	public bool Equals(OPPGGNKKPPF MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x84A22E0", Offset = "0x84A12E0", VA = "0x1884A22E0", Slot = "8")]
	public bool Equals(JKEBHBOGLMJ MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x84A23A0", Offset = "0x84A13A0", VA = "0x1884A23A0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x84A25D0", Offset = "0x84A15D0", VA = "0x1884A25D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
public delegate void CBMPHAAPMJB(HHPDMFCBIOB.GHCFLBOPIHD IJNDKHIBLOC, string NAAMEAFIHJI);
[Cpp2IlInjected.Token(Token = "0x20001D1")]
internal interface DKJAMFBNPLF
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	PPAOKKLNNOP EDAJMNNCAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ABCOMPDCKBM(long CINEDGEJAIA, long NBOIIPJHEBJ, KNEDGBILGPM EDHLLDFNCFM, [Out] OPPGGNKKPPF EBKHBJGGNOP);

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<OPPGGNKKPPF> EGKNGFEDPFL(KNEDGBILGPM EDHLLDFNCFM);

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OPPGGNKKPPF LKKBHHBBEOC(long CINEDGEJAIA, long NBOIIPJHEBJ, HFEJJAMCGEP KMDNEDBDMKJ, KNEDGBILGPM EDHLLDFNCFM);
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
