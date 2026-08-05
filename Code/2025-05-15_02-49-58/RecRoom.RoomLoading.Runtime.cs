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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8427050", Offset = "0x8425650", VA = "0x188427050")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
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
		[Cpp2IlInjected.Address(RVA = "0x84238C0", Offset = "0x8421EC0", VA = "0x1884238C0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x842A550", Offset = "0x8428B50", VA = "0x18842A550", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DIOGHCGECGO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8416FB0", Offset = "0x84155B0", VA = "0x188416FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8423240", Offset = "0x8421840", VA = "0x188423240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8423480", Offset = "0x8421A80", VA = "0x188423480", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8409E40", Offset = "0x8408440", VA = "0x188409E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x840A050", Offset = "0x8408650", VA = "0x18840A050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	[UnityEngine.Scripting.Preserve]
	public NCIGEBCLAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84269E0", Offset = "0x8424FE0", VA = "0x1884269E0", Slot = "4")]
	[AsyncStateMachine(typeof(LHNOEOEDHAJ))]
	public Task<IReadOnlyList<KADKLFOGONN>> MHNGHHEAMFB(long CINEDGEJAIA, long DPKCNMHAPEB, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x84268D0", Offset = "0x8424ED0", VA = "0x1884268D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x841F420", Offset = "0x841DA20", VA = "0x18841F420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x841F9B0", Offset = "0x841DFB0", VA = "0x18841F9B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x841B220", Offset = "0x8419820", VA = "0x18841B220", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KBKDLGNDCGI? CBBDJEMODNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x29BBB10", Offset = "0x29BA110", VA = "0x1829BBB10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public CDIGONBLHDF? NFNJIDCCAAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x841B080", Offset = "0x8419680", VA = "0x18841B080", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NAPCKPCCCNK GNHJGPDGGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xBEDFB0", Offset = "0xBEC5B0", VA = "0x180BEDFB0", Slot = "10")]
			get
			{
				return default(NAPCKPCCCNK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x841B120", Offset = "0x8419720", VA = "0x18841B120", Slot = "9")]
		[AsyncStateMachine(typeof(JJGCIOEBMLL))]
		public Task<GGIHIJCCBHJ> NBJHHHCEOKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x841B240", Offset = "0x8419840", VA = "0x18841B240")]
		public GGEPDPCICGH(int NMFEHPGFFGN, INDKPHCCHHI IBFHFEBHGKB, KADKLFOGONN OOKIAEEEMFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x841AF10", Offset = "0x8419510", VA = "0x18841AF10", Slot = "11")]
		public bool Equals(BBFLLAOCAPG MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x841AFA0", Offset = "0x84195A0", VA = "0x18841AFA0", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x841B040", Offset = "0x8419640", VA = "0x18841B040")]
		private bool GHMPBKAIJIL(GGEPDPCICGH MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x841B0A0", Offset = "0x84196A0", VA = "0x18841B0A0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x8429070", Offset = "0x8427670", VA = "0x188429070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x84292C0", Offset = "0x84278C0", VA = "0x1884292C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x840A8A0", Offset = "0x8408EA0", VA = "0x18840A8A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public INDKPHCCHHI GCGOAHAFJDL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x840AB60", Offset = "0x8409160", VA = "0x18840AB60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime BAOFFOBPNHG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x840ACE0", Offset = "0x84092E0", VA = "0x18840ACE0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public KBKDLGNDCGI? CBBDJEMODNN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x840A850", Offset = "0x8408E50", VA = "0x18840A850", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public CDIGONBLHDF? NFNJIDCCAAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x840AA90", Offset = "0x8409090", VA = "0x18840AA90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NAPCKPCCCNK GNHJGPDGGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xBD6DF0", Offset = "0xBD53F0", VA = "0x180BD6DF0", Slot = "10")]
			get
			{
				return default(NAPCKPCCCNK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1E5ADB0", Offset = "0x1E593B0", VA = "0x181E5ADB0")]
		public AMLDHCNDCPH(OPPGGNKKPPF EBKHBJGGNOP, KBKDLGNDCGI ONFAIAACMCL, CDIGONBLHDF LOCHCLBNCPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x840ABF0", Offset = "0x84091F0", VA = "0x18840ABF0", Slot = "9")]
		[AsyncStateMachine(typeof(PNJEHPDNALE))]
		public Task<GGIHIJCCBHJ> NBJHHHCEOKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x840A8E0", Offset = "0x8408EE0", VA = "0x18840A8E0", Slot = "11")]
		public bool Equals(BBFLLAOCAPG MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x840A980", Offset = "0x8408F80", VA = "0x18840A980", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x840AA30", Offset = "0x8409030", VA = "0x18840AA30")]
		private bool GHMPBKAIJIL(AMLDHCNDCPH MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x840AAE0", Offset = "0x84090E0", VA = "0x18840AAE0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x8426600", Offset = "0x8424C00", VA = "0x188426600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8426860", Offset = "0x8424E60", VA = "0x188426860", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8426B50", Offset = "0x8425150", VA = "0x188426B50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime BAOFFOBPNHG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public KBKDLGNDCGI? CBBDJEMODNN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8426B00", Offset = "0x8425100", VA = "0x188426B00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public CDIGONBLHDF? NFNJIDCCAAE
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8426D40", Offset = "0x8425340", VA = "0x188426D40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NAPCKPCCCNK GNHJGPDGGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "10")]
			get
			{
				return default(NAPCKPCCCNK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1E5ADB0", Offset = "0x1E593B0", VA = "0x181E5ADB0")]
		public NGGMLLOBAIJ(INDKPHCCHHI IBFHFEBHGKB, KBKDLGNDCGI ONFAIAACMCL, CDIGONBLHDF LOCHCLBNCPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8426E20", Offset = "0x8425420", VA = "0x188426E20", Slot = "9")]
		[AsyncStateMachine(typeof(NAPNCAGKDDE))]
		public Task<GGIHIJCCBHJ> NBJHHHCEOKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8426BF0", Offset = "0x84251F0", VA = "0x188426BF0", Slot = "11")]
		public bool Equals(BBFLLAOCAPG MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8426B70", Offset = "0x8425170", VA = "0x188426B70", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8426D90", Offset = "0x8425390", VA = "0x188426D90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8426C60", Offset = "0x8425260", VA = "0x188426C60")]
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
		[Cpp2IlInjected.Address(RVA = "0x841DCF0", Offset = "0x841C2F0", VA = "0x18841DCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x841EB30", Offset = "0x841D130", VA = "0x18841EB30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x840AD30", Offset = "0x8409330", VA = "0x18840AD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x840B700", Offset = "0x8409D00", VA = "0x18840B700", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x8412F70", Offset = "0x8411570", VA = "0x188412F70")]
	[UnityEngine.Scripting.Preserve]
	public BJOAFJLEONA([DJIFKCCBBND(null)] OCONDPENHFH ANIBOLAGJCJ, [DJIFKCCBBND(null)] FKMGBBKKGNI NJJJLNFAOPB, [DJIFKCCBBND(null)] ILOOKKAOHHD NCPPADEPCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8412E20", Offset = "0x8411420", VA = "0x188412E20")]
	[AsyncStateMachine(typeof(IIMEHOFMAMI))]
	public Task<IList<BBFLLAOCAPG>> LCKPLKIOBNF(long CINEDGEJAIA, long NBOIIPJHEBJ, bool ICFDKPFLMNA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8412C80", Offset = "0x8411280", VA = "0x188412C80")]
	private bool FOFDKIBBKAH(DateTime? EONHAIHKAGI, long CINEDGEJAIA, long NBOIIPJHEBJ, [Out] OPPGGNKKPPF HIIKALLGCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8412B70", Offset = "0x8411170", VA = "0x188412B70")]
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
	[Cpp2IlInjected.Address(RVA = "0x84277E0", Offset = "0x8425DE0", VA = "0x1884277E0")]
	public OGDCDNJBIFG(long JABOCCMAHMG, long DPKCNMHAPEB, ECEDGMJBOHJ MLCOGCMJLBB, [CanBeNull] Exception MNKOHFDBNDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8427790", Offset = "0x8425D90", VA = "0x188427790")]
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
	[Cpp2IlInjected.Address(RVA = "0x8427AF0", Offset = "0x84260F0", VA = "0x188427AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public NHNOGEFNFMP(PAIKJEGABFG HJHEMAOEAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8426F80", Offset = "0x8425580", VA = "0x188426F80")]
	public NHNOGEFNFMP MLNPJAKMBHI(string OEHHKNIGGMI, string OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8426EF0", Offset = "0x84254F0", VA = "0x188426EF0")]
	public bool GNNLCBKBEPD([Out] IEnumerable<KeyValuePair<string, string>> HOIDLFKAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x72D5350", Offset = "0x72D3950", VA = "0x1872D5350")]
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
	void MIMBONHMPDP(Guid DMDDOFCAJJF, IReadOnlyList<Guid> BBAMDEDEGNN, FIHCFCEBMME CCJGELGPENP, [Optional] object AICMGGAJMCJ);

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
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xC46E90", Offset = "0xC45490", VA = "0x180C46E90")]
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
		[Cpp2IlInjected.Address(RVA = "0x841CCB0", Offset = "0x841B2B0", VA = "0x18841CCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x841CF30", Offset = "0x841B530", VA = "0x18841CF30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x841B5D0", Offset = "0x8419BD0", VA = "0x18841B5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x841B800", Offset = "0x8419E00", VA = "0x18841B800", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xE9CA20", Offset = "0xE9B020", VA = "0x180E9CA20")]
		[DebuggerHidden]
		public DLGEAEKAKAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8417020", Offset = "0x8415620", VA = "0x188417020", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8417480", Offset = "0x8415A80", VA = "0x188417480", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x84173D0", Offset = "0x84159D0", VA = "0x1884173D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BGMLLKPPOFE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x84173D0", Offset = "0x84159D0", VA = "0x1884173D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6D0", Offset = "0x9ECCD0", VA = "0x1809EE6D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public KFEINBBMNIF NFILJMHMJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6C0", Offset = "0x9ECCC0", VA = "0x1809EE6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public JHHKOFMOFFM PLBPABECHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6E0", Offset = "0x9ECCE0", VA = "0x1809EE6E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6B0", Offset = "0x9ECCB0", VA = "0x1809EE6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public IPGGFFCDLNK BKPNOIHPIEI
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9EECD0", Offset = "0x9ED2D0", VA = "0x1809EECD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public IAEPKIALGDD POBNBGLJGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9EECE0", Offset = "0x9ED2E0", VA = "0x1809EECE0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9EECC0", Offset = "0x9ED2C0", VA = "0x1809EECC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public MBAMAOLNFEE DCPOKBLKBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9F3180", Offset = "0x9F1780", VA = "0x1809F3180", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9F3080", Offset = "0x9F1680", VA = "0x1809F3080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public LAFKPKCKGAP PICEKANBOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9F30F0", Offset = "0x9F16F0", VA = "0x1809F30F0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9F3010", Offset = "0x9F1610", VA = "0x1809F3010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public PLHOCFLCCME FLKHDEPCOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9F3100", Offset = "0x9F1700", VA = "0x1809F3100", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9F2FF0", Offset = "0x9F15F0", VA = "0x1809F2FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public GFAFJAJHEAL ILPIOGPEJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xBEE060", Offset = "0xBEC660", VA = "0x180BEE060", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x13038B0", Offset = "0x1301EB0", VA = "0x1813038B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public KKJBEPHJCKB HEIABABBFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9F3040", Offset = "0x9F1640", VA = "0x1809F3040", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9F3050", Offset = "0x9F1650", VA = "0x1809F3050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public NOKLFIDFJEA PGIADFHLCID
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xCD6750", Offset = "0xCD4D50", VA = "0x180CD6750", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xE59ED0", Offset = "0xE584D0", VA = "0x180E59ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public KJKKPMCIKID FEFFBEOGBKC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9F64A0", Offset = "0x9F4AA0", VA = "0x1809F64A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9F64C0", Offset = "0x9F4AC0", VA = "0x1809F64C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public GIALCOICGEG JDGJMKGIIGP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xD65080", Offset = "0xD63680", VA = "0x180D65080", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xE6ABC0", Offset = "0xE691C0", VA = "0x180E6ABC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public CGGJELIFDNE AGFIACKNDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xD49D80", Offset = "0xD48380", VA = "0x180D49D80", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xD49D90", Offset = "0xD48390", VA = "0x180D49D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IFAIILFJKPF DCEJGBEFPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xCD6580", Offset = "0xCD4B80", VA = "0x180CD6580", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x115C450", Offset = "0x115AA50", VA = "0x18115C450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public GJKNOPEFJGC LPKPPLPFMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xCC11E0", Offset = "0xCBF7E0", VA = "0x180CC11E0", Slot = "62")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xD79440", Offset = "0xD77A40", VA = "0x180D79440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public JOECIDFCFKO EDNEEHBEMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA9D740", Offset = "0xA9BD40", VA = "0x180A9D740", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA9D460", Offset = "0xA9BA60", VA = "0x180A9D460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public JFBCBONLOMK ANPKFBBOMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9F64B0", Offset = "0x9F4AB0", VA = "0x1809F64B0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x9F6480", Offset = "0x9F4A80", VA = "0x1809F6480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public NJGDDFJMLGB ODNMBCHBAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E90", Offset = "0xAC0490", VA = "0x180AC1E90", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xBB8E60", Offset = "0xBB7460", VA = "0x180BB8E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public FCNEEADCJIO LACKJDMKNON
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAA1470", Offset = "0xA9FA70", VA = "0x180AA1470", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xAA0520", Offset = "0xA9EB20", VA = "0x180AA0520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public FAJHEKNGMOI OPLCJBMPICL
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xAA2AA0", Offset = "0xAA10A0", VA = "0x180AA2AA0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xAA2190", Offset = "0xAA0790", VA = "0x180AA2190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public ODFHIPDMKON LKBHDLALJNO
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xAAC790", Offset = "0xAAAD90", VA = "0x180AAC790", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAA9A50", Offset = "0xAA8050", VA = "0x180AA9A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public KPFKDIBGGLC LLCLIMJNIOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA6B3D0", Offset = "0xA699D0", VA = "0x180A6B3D0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA6B460", Offset = "0xA69A60", VA = "0x180A6B460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public OMMADJGGBCJ KBHDBHGBJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA6B0E0", Offset = "0xA696E0", VA = "0x180A6B0E0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA6B440", Offset = "0xA69A40", VA = "0x180A6B440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public DFOJGOILCNA GHNBGCCBLKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA6A350", Offset = "0xA68950", VA = "0x180A6A350", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA610A0", Offset = "0xA5F6A0", VA = "0x180A610A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public NEBLBKINJDB JAOAPLBLLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xAC2820", Offset = "0xAC0E20", VA = "0x180AC2820", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xAAD4E0", Offset = "0xAABAE0", VA = "0x180AAD4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public DMIMJPCFHKL FMEEPCKJBJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA6A2A0", Offset = "0xA688A0", VA = "0x180A6A2A0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA619F0", Offset = "0xA5FFF0", VA = "0x180A619F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public EJHLKPMLCLG CGGOCACINEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xAC1790", Offset = "0xABFD90", VA = "0x180AC1790", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xACA6B0", Offset = "0xAC8CB0", VA = "0x180ACA6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public FKMGBBKKGNI HLIBFBLOPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xAA76A0", Offset = "0xAA5CA0", VA = "0x180AA76A0", Slot = "32")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAF930", Offset = "0xAADF30", VA = "0x180AAF930", Slot = "33")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB0900", Offset = "0xAAEF00", VA = "0x180AB0900", Slot = "34")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB1E80", Offset = "0xAB0480", VA = "0x180AB1E80", Slot = "35")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC1510", Offset = "0xABFB10", VA = "0x180AC1510", Slot = "36")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAB880", Offset = "0xAA9E80", VA = "0x180AAB880", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA637A0", Offset = "0xA61DA0", VA = "0x180A637A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool DGLBODPEDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8422860", Offset = "0x8420E60", VA = "0x188422860", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool CEEANGGHCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8422920", Offset = "0x8420F20", VA = "0x188422920", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool BMPNHBMAJAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1C07F60", Offset = "0x1C06560", VA = "0x181C07F60", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken NBCFHNMMNFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8421EC0", Offset = "0x84204C0", VA = "0x188421EC0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private AINJBKKEAIL ABPMIGNEHFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool CMIEFBPGPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1C07F60", Offset = "0x1C06560", VA = "0x181C07F60", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1C01850", Offset = "0x1BFFE50", VA = "0x181C01850", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action JGFDACLAKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x84228C0", Offset = "0x8420EC0", VA = "0x1884228C0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8422740", Offset = "0x8420D40", VA = "0x188422740", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event FCLJLIMNHCD BMLINDGFCOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8422190", Offset = "0x8420790", VA = "0x188422190", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8422D10", Offset = "0x8421310", VA = "0x188422D10", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event FCLJLIMNHCD FHMLFDKJPKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8421E60", Offset = "0x8420460", VA = "0x188421E60", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8422800", Offset = "0x8420E00", VA = "0x188422800", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event FCLJLIMNHCD KNLFFLJLOJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8421EE0", Offset = "0x84204E0", VA = "0x188421EE0", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x84226E0", Offset = "0x8420CE0", VA = "0x1884226E0", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<KLMNOKPMPDB, bool> GADAANFBCEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8422380", Offset = "0x8420980", VA = "0x188422380", Slot = "48")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x84227A0", Offset = "0x8420DA0", VA = "0x1884227A0", Slot = "49")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0xA637A0", Offset = "0xA61DA0", VA = "0x180A637A0", Slot = "39")]
	public void EDBBCKKPBPG(LLFJDDEPDIJ INIHDKAPFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x8422D70", Offset = "0x8421370", VA = "0x188422D70")]
	[UnityEngine.Scripting.Preserve]
	internal LGPBHLKEPPJ([DJIFKCCBBND(null)] AINJBKKEAIL NELIKBMJKPH, [DJIFKCCBBND(null)] LDMAAALPMPJ NODDAHEDIAD, [DJIFKCCBBND(null)] KFEINBBMNIF PBJBHBOBLLF, [DJIFKCCBBND(null)] JHHKOFMOFFM DHJEDIPMPLO, [DJIFKCCBBND(null)] IPGGFFCDLNK ALJPBJKIMMK, [DJIFKCCBBND(null)] IAEPKIALGDD LEAFBFEDNOC, [DJIFKCCBBND(null)] MBAMAOLNFEE MHAEOAHGKDE, [DJIFKCCBBND(null)] PLHOCFLCCME AANEBFKDCIJ, [DJIFKCCBBND(null)] GFAFJAJHEAL OHEPFLBIHHH, [DJIFKCCBBND(null)] KKJBEPHJCKB OELFAECNHPL, [DJIFKCCBBND(null)] NOKLFIDFJEA EIHAJEPOKNO, [DJIFKCCBBND(null)] KJKKPMCIKID INIKKNPPFKN, [DJIFKCCBBND(null)] GIALCOICGEG GABNHHFPLMP, [DJIFKCCBBND(null)] CGGJELIFDNE BEGEKIBIHIK, [DJIFKCCBBND(null)] IFAIILFJKPF JIHHPLOGLBJ, [DJIFKCCBBND(null)] GJKNOPEFJGC ACBECDIMFKP, [DJIFKCCBBND(null)] JOECIDFCFKO PGIDKOLIOLP, [DJIFKCCBBND(null)] JFBCBONLOMK DICJDHBCDLH, [DJIFKCCBBND(null)] NJGDDFJMLGB CDJMGELKIDP, [DJIFKCCBBND(null)] FCNEEADCJIO DILAOJNHENM, [DJIFKCCBBND(null)] ODFHIPDMKON HFHKNFCAINL, [DJIFKCCBBND(null)] FAJHEKNGMOI OBECGFDEJPK, [DJIFKCCBBND(null)] KPFKDIBGGLC FAPAMCLMPLP, [DJIFKCCBBND(null)] OMMADJGGBCJ NPAIDAEMCCD, [DJIFKCCBBND(null)] DFOJGOILCNA HKHJFPPOMOL, [DJIFKCCBBND(null)] DMIMJPCFHKL NFFGNPJGBOO, [DJIFKCCBBND(null)] EJHLKPMLCLG BCNCMPIIBEG, [DJIFKCCBBND(null)] FKMGBBKKGNI DPJPCPHENPG, [DJIFKCCBBND(null)] LJPPDIILPEC LLLDBKONJJM, [DJIFKCCBBND(null)] IBHJLAMHBCG IMMBIKKFMEN, [DJIFKCCBBND(null)] JPJGDPIBNOF EMPPLKPGDFD, [DJIFKCCBBND(null)] OKGFEPLGNNN MEBFMFIEGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8421F40", Offset = "0x8420540", VA = "0x188421F40")]
	private void ANJKPBDKBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x84221F0", Offset = "0x84207F0", VA = "0x1884221F0", Slot = "61")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x8421E10", Offset = "0x8420410", VA = "0x188421E10", Slot = "53")]
	private void AJBIHENENAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x8422100", Offset = "0x8420700", VA = "0x188422100", Slot = "54")]
	private JKIIIKPEIIP CKDNNDNADJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x8422A00", Offset = "0x8421000", VA = "0x188422A00", Slot = "55")]
	private AJBKMDJKJOF KDBINMAOEJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x84223E0", Offset = "0x84209E0", VA = "0x1884223E0", Slot = "57")]
	public Task FHPKBDKEKGF(int BGINAMOOLIJ, MDNOEFMCADI LMHJJMIBAMA, Func<HFEJJAMCGEP, HFEJJAMCGEP> IEJMBGBDAGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8421FF0", Offset = "0x84205F0", VA = "0x188421FF0")]
	private MANPACGGAHA BPBDKNEOPJB(int BGINAMOOLIJ, MDNOEFMCADI LMHJJMIBAMA, Func<HFEJJAMCGEP, HFEJJAMCGEP> IEJMBGBDAGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x8422B10", Offset = "0x8421110", VA = "0x188422B10", Slot = "58")]
	[AsyncStateMachine(typeof(HHFNANNNEIC))]
	private Task<GGIHIJCCBHJ> LKNJOHOFELB(OPPGGNKKPPF HIIKALLGCLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8422C20", Offset = "0x8421220", VA = "0x188422C20", Slot = "59")]
	[AsyncStateMachine(typeof(GKEPNKIDNLM))]
	private Task NFNBDKMJDHG(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x8422A90", Offset = "0x8421090", VA = "0x188422A90")]
	[IteratorStateMachine(typeof(DLGEAEKAKAM))]
	private IEnumerable<BGMLLKPPOFE> KMMGNKNMKMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x84229A0", Offset = "0x8420FA0", VA = "0x1884229A0")]
	[CompilerGenerated]
	private void JEEHEPMNKHA(BGMLLKPPOFE HABFEKNHDFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class PKLNPICDKGO : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x17CDAF0", Offset = "0x17CC0F0", VA = "0x1817CDAF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8421040", Offset = "0x841F640", VA = "0x188421040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8421340", Offset = "0x841F940", VA = "0x188421340", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8419080", Offset = "0x8417680", VA = "0x188419080", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x9F85E0", Offset = "0x9F6BE0", VA = "0x1809F85E0")]
	public FBOLDFAEFFN(IPAGNGHLCCF BFCIGLOEMAP, JHHKOFMOFFM DHJEDIPMPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x84190B0", Offset = "0x84176B0", VA = "0x1884190B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x841CFA0", Offset = "0x841B5A0", VA = "0x18841CFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x841D900", Offset = "0x841BF00", VA = "0x18841D900", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8428E70", Offset = "0x8427470", VA = "0x188428E70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x9F85E0", Offset = "0x9F6BE0", VA = "0x1809F85E0")]
	public PKMKCAKFBGG(IPAGNGHLCCF BFCIGLOEMAP, JHHKOFMOFFM DHJEDIPMPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8428EA0", Offset = "0x84274A0", VA = "0x188428EA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x84213B0", Offset = "0x841F9B0", VA = "0x1884213B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8421DA0", Offset = "0x84203A0", VA = "0x188421DA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x841DAF0", Offset = "0x841C0F0", VA = "0x18841DAF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x9F85E0", Offset = "0x9F6BE0", VA = "0x1809F85E0")]
	public IGEMONMPKOO(IPAGNGHLCCF BFCIGLOEMAP, JHHKOFMOFFM DHJEDIPMPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x841DB20", Offset = "0x841C120", VA = "0x18841DB20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BGCPHGFAAFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x840BBE0", Offset = "0x840A1E0", VA = "0x18840BBE0")]
		internal object NJDEFDIIFAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x840BC60", Offset = "0x840A260", VA = "0x18840BC60")]
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
		[Cpp2IlInjected.Address(RVA = "0x841B860", Offset = "0x8419E60", VA = "0x18841B860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x841C480", Offset = "0x841AA80", VA = "0x18841C480", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8427800", Offset = "0x8425E00", VA = "0x188427800", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x9F85E0", Offset = "0x9F6BE0", VA = "0x1809F85E0")]
	public OLPFMNKMJHG(IPAGNGHLCCF BFCIGLOEMAP, JHHKOFMOFFM DHJEDIPMPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8427830", Offset = "0x8425E30", VA = "0x188427830", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x84288F0", Offset = "0x8426EF0", VA = "0x1884288F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8428E10", Offset = "0x8427410", VA = "0x188428E10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x841D970", Offset = "0x841BF70", VA = "0x18841D970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x9F85E0", Offset = "0x9F6BE0", VA = "0x1809F85E0")]
	public ICDGGHOJMPN(IPAGNGHLCCF BFCIGLOEMAP, JHHKOFMOFFM DHJEDIPMPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x841D9C0", Offset = "0x841BFC0", VA = "0x18841D9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8418C90", Offset = "0x8417290", VA = "0x188418C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8419010", Offset = "0x8417610", VA = "0x188419010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public AHFONHGEHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x840A750", Offset = "0x8408D50", VA = "0x18840A750")]
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
	[Cpp2IlInjected.Address(RVA = "0x8424EC0", Offset = "0x84234C0", VA = "0x188424EC0")]
	[AsyncStateMachine(typeof(EFLIBJPEAGN))]
	internal static Task<FLIMEIMMDEM.ONMMOAHPBBH> FAHLECLNJNK(JHHKOFMOFFM DHJEDIPMPLO, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8424FD0", Offset = "0x84235D0", VA = "0x188424FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8427A00", Offset = "0x8426000", VA = "0x188427A00")]
		public static ONMMOAHPBBH JPLAKFPJJKE()
		{
			return default(ONMMOAHPBBH);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8427A10", Offset = "0x8426010", VA = "0x188427A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public FEFACOBOMLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8419240", Offset = "0x8417840", VA = "0x188419240")]
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
		[Cpp2IlInjected.Address(RVA = "0x8426000", Offset = "0x8424600", VA = "0x188426000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8426590", Offset = "0x8424B90", VA = "0x188426590", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x840B770", Offset = "0x8409D70", VA = "0x18840B770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x840BA90", Offset = "0x840A090", VA = "0x18840BA90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x841C720", Offset = "0x841AD20", VA = "0x18841C720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private JHHKOFMOFFM PLBPABECHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x841C540", Offset = "0x841AB40", VA = "0x18841C540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private IJPJAKACFOB BJABPNAMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x841C6A0", Offset = "0x841ACA0", VA = "0x18841C6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private KKJBEPHJCKB HEIABABBFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x841C4F0", Offset = "0x841AAF0", VA = "0x18841C4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2797E70", Offset = "0x2796470", VA = "0x182797E70")]
	public GOMNLJCCGLI(CancellationToken CBJPDIFOEKF, IPAGNGHLCCF PAKPDHLKNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x841C770", Offset = "0x841AD70", VA = "0x18841C770")]
	public static BEPKOPDMDEM JOIFJLIJJGP(IPAGNGHLCCF PAKPDHLKNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x841C590", Offset = "0x841AB90", VA = "0x18841C590")]
	[AsyncStateMachine(typeof(MPAELOPDEKP))]
	public Task<bool> GDMALPFODEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x841C820", Offset = "0x841AE20", VA = "0x18841C820")]
	private bool KIFICIOPMDM([Out] OPPGGNKKPPF HIIKALLGCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x841CB60", Offset = "0x841B160", VA = "0x18841CB60")]
	[AsyncStateMachine(typeof(BEHCPNFPNOG))]
	private Task NBPOGBLHNLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x841CA30", Offset = "0x841B030", VA = "0x18841CA30")]
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
		[Cpp2IlInjected.Address(RVA = "0x840A0C0", Offset = "0x84086C0", VA = "0x18840A0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x50C9EA0", Offset = "0x50C84A0", VA = "0x1850C9EA0")]
	public AFOHIMBEAIK(IFAIILFJKPF JIHHPLOGLBJ, Guid DHFBDLBBCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x840A260", Offset = "0x8408860", VA = "0x18840A260")]
	public TaskAwaiter<(GGIHIJCCBHJ, Task)> NCACCMDALIC()
	{
		return default(TaskAwaiter<(GGIHIJCCBHJ, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x840A190", Offset = "0x8408790", VA = "0x18840A190", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8425D20", Offset = "0x8424320", VA = "0x188425D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8425E80", Offset = "0x8424480", VA = "0x188425E80")]
	public MMGJCCEFHKA(TimeSpan PKGMHLEONHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8425C30", Offset = "0x8424230", VA = "0x188425C30")]
	public void AHDBNACLDFJ(Task MENJBHNCOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8425DF0", Offset = "0x84243F0", VA = "0x188425DF0")]
	public void MMDJOFGLDAH(GGIHIJCCBHJ MNJLOAEFEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8425CD0", Offset = "0x84242D0", VA = "0x188425CD0")]
	public void DACKCPGEMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8425D60", Offset = "0x8424360", VA = "0x188425D60")]
	internal void JGGPEGJECOH(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class GHDIGNGHBEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x841B2A0", Offset = "0x84198A0", VA = "0x18841B2A0")]
	public static AENKMJAJKCL IJOGBCECLMH(this AENKMJAJKCL DGHLABNPIEC, GOMNLGPHFID LNOKHBNGHMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x841B440", Offset = "0x8419A40", VA = "0x18841B440")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public FKPLDIKKJEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8419290", Offset = "0x8417890", VA = "0x188419290")]
		internal bool EJPDHCDLONA(IINCMBDAHBF s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly DMIMJPCFHKL CPIJMIHEHHA;

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public KGDFJCJHLNM(DMIMJPCFHKL NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8420A20", Offset = "0x841F020", VA = "0x188420A20", Slot = "4")]
	public AENKMJAJKCL FLLMCNLHKNL(long JABOCCMAHMG, long DPKCNMHAPEB, string JMBBDHDFKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x84208C0", Offset = "0x841EEC0", VA = "0x1884208C0", Slot = "5")]
	public AENKMJAJKCL FLLMCNLHKNL(long JABOCCMAHMG, long DPKCNMHAPEB, NGHKAOKDFBL OFMJDNINMGK, Guid? GCDCGDIAIPJ, long HACNOLAIOHO, bool HCODGODMFLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x8420AB0", Offset = "0x841F0B0", VA = "0x188420AB0", Slot = "6")]
	public AENKMJAJKCL FLLMCNLHKNL(GHABJHKCBDN PECGMNBMCKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8420CB0", Offset = "0x841F2B0", VA = "0x188420CB0", Slot = "7")]
	public AENKMJAJKCL FLLMCNLHKNL(GOMNLGPHFID CPEDNDIONCC, KADKLFOGONN FOLMFHKONEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8420F90", Offset = "0x841F590", VA = "0x188420F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8412480", Offset = "0x8410A80", VA = "0x188412480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8412B10", Offset = "0x8411110", VA = "0x188412B10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8423610", Offset = "0x8421C10", VA = "0x188423610", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task CFCODDMDOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x84237A0", Offset = "0x8421DA0", VA = "0x1884237A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10", Slot = "7")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x8423640", Offset = "0x8421C40", VA = "0x188423640", Slot = "6")]
	public void HNDGLPBCLKM(Task BGKKDAHMDLM, string HFGDCJPDCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x84234F0", Offset = "0x8421AF0", VA = "0x1884234F0")]
	[AsyncStateMachine(typeof(BJLCLOCPLOM))]
	private Task FJIJOGBHPBL(Task JMCJINFHCPM, string HFGDCJPDCBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x8423830", Offset = "0x8421E30", VA = "0x188423830")]
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
		[Cpp2IlInjected.Address(RVA = "0x840A6E0", Offset = "0x8408CE0", VA = "0x18840A6E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x840A2B0", Offset = "0x84088B0", VA = "0x18840A2B0", Slot = "7")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x840A430", Offset = "0x8408A30", VA = "0x18840A430", Slot = "5")]
	public void BDLDJLKMDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x840A5E0", Offset = "0x8408BE0", VA = "0x18840A5E0", Slot = "6")]
	public void ODOONGBGDAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x840A620", Offset = "0x8408C20", VA = "0x18840A620")]
	private Task IAPGKHCPGOE(MFOPHKLDKKA COFBNOFIHKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x840A5E0", Offset = "0x8408BE0", VA = "0x18840A5E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			[Cpp2IlInjected.Address(RVA = "0xC8F7E0", Offset = "0xC8DDE0", VA = "0x180C8F7E0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0xC8F720", Offset = "0xC8DD20", VA = "0x180C8F720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x532CDB0", Offset = "0x532B3B0", VA = "0x18532CDB0")]
		public MAHNFCCFEOI(JAHOCBPGMLL AJHJEIPEGEF, string OEHHKNIGGMI, T JMMNJNFGHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x532C660", Offset = "0x532AC60", VA = "0x18532C660")]
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
		[Cpp2IlInjected.Address(RVA = "0x841EED0", Offset = "0x841D4D0", VA = "0x18841EED0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan PFDHBIEGGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x841ED80", Offset = "0x841D380", VA = "0x18841ED80", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan DPAFCJHHPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x841EE10", Offset = "0x841D410", VA = "0x18841EE10", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan BOPODGNPHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x841EF10", Offset = "0x841D510", VA = "0x18841EF10", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool CKINHNABKGK
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x841EE90", Offset = "0x841D490", VA = "0x18841EE90", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool COCPDMNPDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x841ED40", Offset = "0x841D340", VA = "0x18841ED40", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool EDBBDKDIBIE
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x841EE50", Offset = "0x841D450", VA = "0x18841EE50", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int MCENBAIECMD
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x841ED00", Offset = "0x841D300", VA = "0x18841ED00", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool DJNPKBDGKHO
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x841EC80", Offset = "0x841D280", VA = "0x18841EC80", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool NBAAGDBAKGI
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x841ECC0", Offset = "0x841D2C0", VA = "0x18841ECC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool MCPDLKIHLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x841EDC0", Offset = "0x841D3C0", VA = "0x18841EDC0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x841EF50", Offset = "0x841D550", VA = "0x18841EF50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public JDAJAJKBEIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x841EBA0", Offset = "0x841D1A0", VA = "0x18841EBA0")]
		internal object AAGHKCOFGLB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action BNNCIKDGMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8423FA0", Offset = "0x84225A0", VA = "0x188423FA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x84242D0", Offset = "0x84228D0", VA = "0x1884242D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event FCLJLIMNHCD OGNNBGBILAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8423CA0", Offset = "0x84222A0", VA = "0x188423CA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8423F00", Offset = "0x8422500", VA = "0x188423F00", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event FCLJLIMNHCD LAOCICLHAPO
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8424370", Offset = "0x8422970", VA = "0x188424370", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8424230", Offset = "0x8422830", VA = "0x188424230", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event FCLJLIMNHCD MJPEGKHONEL
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8424460", Offset = "0x8422A60", VA = "0x188424460", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x84245E0", Offset = "0x8422BE0", VA = "0x1884245E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<KLMNOKPMPDB, bool> NBGBDPMCBKA
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8424680", Offset = "0x8422C80", VA = "0x188424680", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8424500", Offset = "0x8422B00", VA = "0x188424500", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "19")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8424040", Offset = "0x8422640", VA = "0x188424040", Slot = "14")]
	public void EOOIBDLJKFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8423C40", Offset = "0x8422240", VA = "0x188423C40", Slot = "15")]
	public void ACANEKOKOPD(OGDCDNJBIFG JJJFPCEDAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8423C70", Offset = "0x8422270", VA = "0x188423C70", Slot = "16")]
	public void BLKDLGGILJJ(OGDCDNJBIFG JJJFPCEDAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x84245B0", Offset = "0x8422BB0", VA = "0x1884245B0", Slot = "17")]
	public void MALCLLIGEBD(OGDCDNJBIFG JJJFPCEDAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x8424410", Offset = "0x8422A10", VA = "0x188424410", Slot = "18")]
	public void ILCACIMPPHO(KLMNOKPMPDB MEOBMEDANDK, bool AMLDIAHNCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x8423D40", Offset = "0x8422340", VA = "0x188423D40")]
	private void CIBKKMOJDEC(FCLJLIMNHCD DLNPOEEPFML, OGDCDNJBIFG JJJFPCEDAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x8424730", Offset = "0x8422D30", VA = "0x188424730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x8424E60", Offset = "0x8423460", VA = "0x188424E60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8417F90", Offset = "0x8416590", VA = "0x188417F90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x8418C20", Offset = "0x8417220", VA = "0x188418C20", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public HAIEAPCCOBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x841CC30", Offset = "0x841B230", VA = "0x18841CC30")]
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
			[Cpp2IlInjected.Address(RVA = "0x8419F40", Offset = "0x8418540", VA = "0x188419F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool HJAGJKGKFKI
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x8419C30", Offset = "0x8418230", VA = "0x188419C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x841ADF0", Offset = "0x84193F0", VA = "0x18841ADF0")]
		public GEHDBBJHGOO(JHHKOFMOFFM DHJEDIPMPLO, OHMKBLJJPPO EAALPKOHFDN, PAIKJEGABFG HJHEMAOEAHO, FLIMEIMMDEM[] KGLIENNIIDN, CancellationToken CBJPDIFOEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8419470", Offset = "0x8417A70", VA = "0x188419470", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8419400", Offset = "0x8417A00", VA = "0x188419400")]
		public void DJEOLHCHGLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8419F60", Offset = "0x8418560", VA = "0x188419F60")]
		public void KCHCMDBBGJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x841A630", Offset = "0x8418C30", VA = "0x18841A630")]
		public void OFKIBLKIJKE(KJKKPMCIKID.Reason OIBKENCHEHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x841A170", Offset = "0x8418770", VA = "0x18841A170")]
		[AsyncStateMachine(typeof(MJGPNPCHIPJ))]
		public Task LELFBKGJJJJ(KJKKPMCIKID.Reason DKBCGBFNIGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x84192C0", Offset = "0x84178C0", VA = "0x1884192C0")]
		[AsyncStateMachine(typeof(EDECDACINKM))]
		private Task<FLIMEIMMDEM.ONMMOAHPBBH> BDJMBLOCAPO(KJKKPMCIKID.Reason DKBCGBFNIGO, FLIMEIMMDEM GNDCLODOCOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8419C50", Offset = "0x8418250", VA = "0x188419C50")]
		private void GGFNAGLPGPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x841A0C0", Offset = "0x84186C0", VA = "0x18841A0C0")]
		public bool KOPBIHBPJKI(KJKKPMCIKID.Reason LGNGGBIFDBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x841A270", Offset = "0x8418870", VA = "0x18841A270")]
		private void NBBFIAKJEGB(OFAKAEPLJIA IDAKFFICKHC, KJKKPMCIKID.Reason DKBCGBFNIGO = KJKKPMCIKID.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8419D70", Offset = "0x8418370", VA = "0x188419D70")]
		private void GGFPFAFKPBI(OFAKAEPLJIA IDAKFFICKHC, FLIMEIMMDEM.ONMMOAHPBBH OBOOAPELMPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x841A8E0", Offset = "0x8418EE0", VA = "0x18841A8E0")]
		private void PCIDLPKEMDF(OFAKAEPLJIA IDAKFFICKHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8419600", Offset = "0x8417C00", VA = "0x188419600")]
		private void EAKNACMKMHH(OFAKAEPLJIA IDAKFFICKHC, FLIMEIMMDEM.ONMMOAHPBBH OBOOAPELMPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8419AD0", Offset = "0x84180D0", VA = "0x188419AD0")]
		private void FCCIPPGOAIF(OFAKAEPLJIA IDAKFFICKHC, Exception APEPCFJIAMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x84199C0", Offset = "0x8417FC0", VA = "0x1884199C0")]
		private void EODMBHEADHA(FLIMEIMMDEM GNDCLODOCOJ, KJKKPMCIKID.Reason DKBCGBFNIGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x841A520", Offset = "0x8418B20", VA = "0x18841A520")]
		private void NLICAJKDNAM(FLIMEIMMDEM GNDCLODOCOJ, KJKKPMCIKID.Reason DKBCGBFNIGO, string AGBNDLBAFHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x841AA80", Offset = "0x8419080", VA = "0x18841AA80", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x8419F40", Offset = "0x8418540", VA = "0x188419F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool HJAGJKGKFKI
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x8419C30", Offset = "0x8418230", VA = "0x188419C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8427220", Offset = "0x8425820", VA = "0x188427220")]
		public void AKBKNLLCFBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8427380", Offset = "0x8425980", VA = "0x188427380", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x84273A0", Offset = "0x84259A0", VA = "0x1884273A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x8427700", Offset = "0x8425D00", VA = "0x188427700")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public OCCEIIOALHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x84270D0", Offset = "0x84256D0", VA = "0x1884270D0")]
		internal object DOMGBKMNBBK(OFAKAEPLJIA x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8427140", Offset = "0x8425740", VA = "0x188427140")]
		internal object FFCIDEBEOLH(GEHDBBJHGOO x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x84271B0", Offset = "0x84257B0", VA = "0x1884271B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84174D0", Offset = "0x8415AD0", VA = "0x1884174D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8417F30", Offset = "0x8416530", VA = "0x188417F30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x840BD20", Offset = "0x840A320", VA = "0x18840BD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x840C990", Offset = "0x840AF90", VA = "0x18840C990", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x84130A0", Offset = "0x84116A0", VA = "0x1884130A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8413610", Offset = "0x8411C10", VA = "0x188413610", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x841FFD0", Offset = "0x841E5D0", VA = "0x18841FFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool HDNJGFJKMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x236AB60", Offset = "0x2369160", VA = "0x18236AB60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool EHPPEBIJBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x84204B0", Offset = "0x841EAB0", VA = "0x1884204B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x841FBA0", Offset = "0x841E1A0", VA = "0x18841FBA0", Slot = "7")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x841FC20", Offset = "0x841E220", VA = "0x18841FC20", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x841FA20", Offset = "0x841E020", VA = "0x18841FA20", Slot = "9")]
	public void AKBKNLLCFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x8420520", Offset = "0x841EB20", VA = "0x188420520")]
	private bool JAAFGFOBHBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x8420020", Offset = "0x841E620", VA = "0x188420020", Slot = "6")]
	private void GOFILBEEIEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8420710", Offset = "0x841ED10", VA = "0x188420710", Slot = "5")]
	[AsyncStateMachine(typeof(DNKBOOJFAKD))]
	private Task OPAMKJHIGFP(KJKKPMCIKID.Reason DKBCGBFNIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x841FD00", Offset = "0x841E300", VA = "0x18841FD00")]
	private bool GCKFBFKCJAO(KJKKPMCIKID.Reason DKBCGBFNIGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x84200F0", Offset = "0x841E6F0", VA = "0x1884200F0")]
	private FLIMEIMMDEM[] GPJDFGLCNOF(PAIKJEGABFG LKMJPMALHKA, OHMKBLJJPPO PNCIAJDNEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x8420600", Offset = "0x841EC00", VA = "0x188420600")]
	[AsyncStateMachine(typeof(BGGNENDPLJD))]
	private Task MMMJHAFMJOE(KJKKPMCIKID.Reason DKBCGBFNIGO, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x841FC30", Offset = "0x841E230", VA = "0x18841FC30")]
	[AsyncStateMachine(typeof(BNKNJOMDMDG))]
	private Task EKBJMCHJBGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8425270", Offset = "0x8423870", VA = "0x188425270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8425BD0", Offset = "0x84241D0", VA = "0x188425BD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8427B40", Offset = "0x8426140", VA = "0x188427B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8428890", Offset = "0x8426E90", VA = "0x188428890", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public OPODJDMAIKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8427A40", Offset = "0x8426040", VA = "0x188427A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public LMMHCJBFFNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
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
		[Cpp2IlInjected.Address(RVA = "0x840C9F0", Offset = "0x840AFF0", VA = "0x18840C9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8412420", Offset = "0x8410A20", VA = "0x188412420", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x843A730", Offset = "0x8438D30", VA = "0x18843A730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x843B1A0", Offset = "0x84397A0", VA = "0x18843B1A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8439620", Offset = "0x8437C20", VA = "0x188439620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8439AA0", Offset = "0x84380A0", VA = "0x188439AA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8442230", Offset = "0x8440830", VA = "0x188442230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8442700", Offset = "0x8440D00", VA = "0x188442700", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8438F80", Offset = "0x8437580", VA = "0x188438F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x84395C0", Offset = "0x8437BC0", VA = "0x1884395C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public POLCFJIINCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8448170", Offset = "0x8446770", VA = "0x188448170")]
		internal object BGNGLHLOMLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8448270", Offset = "0x8446870", VA = "0x188448270")]
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
		[Cpp2IlInjected.Address(RVA = "0x843BC20", Offset = "0x843A220", VA = "0x18843BC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x843C7B0", Offset = "0x843ADB0", VA = "0x18843C7B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x84329C0", Offset = "0x8430FC0", VA = "0x1884329C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x84331B0", Offset = "0x84317B0", VA = "0x1884331B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x842FCC0", Offset = "0x842E2C0", VA = "0x18842FCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x84314A0", Offset = "0x842FAA0", VA = "0x1884314A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x84453B0", Offset = "0x84439B0", VA = "0x1884453B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8445BA0", Offset = "0x84441A0", VA = "0x188445BA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public EKMPFMFDMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8434660", Offset = "0x8432C60", VA = "0x188434660")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public NGAGDFOELCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x84413C0", Offset = "0x843F9C0", VA = "0x1884413C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public FEDCBKLEDOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8435D80", Offset = "0x8434380", VA = "0x188435D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public PELBHDKGGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x84447E0", Offset = "0x8442DE0", VA = "0x1884447E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA12060", Offset = "0xA10660", VA = "0x180A12060", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x131BED0", Offset = "0x131A4D0", VA = "0x18131BED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private IJPJAKACFOB BJABPNAMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8414E20", Offset = "0x8413420", VA = "0x188414E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8413F10", Offset = "0x8412510", VA = "0x188413F10", Slot = "6")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8414A50", Offset = "0x8413050", VA = "0x188414A50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8415630", Offset = "0x8413C30", VA = "0x188415630", Slot = "5")]
	[AsyncStateMachine(typeof(MLMMLAOMDIH))]
	public Task IFKKJMKFBGG(PAIKJEGABFG LEAIIPCAOIH, LLFJDDEPDIJ GKAEKPHDHIG, CancellationToken EBOFCHGLLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8414240", Offset = "0x8412840", VA = "0x188414240")]
	[AsyncStateMachine(typeof(PALFGJDIOHO))]
	private Task CEEBICJBKID(PAIKJEGABFG LEAIIPCAOIH, LLFJDDEPDIJ GKAEKPHDHIG, CancellationToken EBOFCHGLLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8416100", Offset = "0x8414700", VA = "0x188416100")]
	private void MHLNJGBHGFF(IBHJLAMHBCG IMMBIKKFMEN, PAIKJEGABFG LEAIIPCAOIH, Exception APEPCFJIAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x84136D0", Offset = "0x8411CD0", VA = "0x1884136D0")]
	private static void AMCNDMDMFMF(NHNOGEFNFMP KCLJNDLOCKE, Exception APEPCFJIAMB, [Optional] List<int> NONHBAKFOGO, int GADPHLHLJAG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x84150C0", Offset = "0x84136C0", VA = "0x1884150C0")]
	[AsyncStateMachine(typeof(BIOBEAMGBDI))]
	private Task GPPCNGJFHOA(LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, PAIKJEGABFG LEAIIPCAOIH, LLFJDDEPDIJ GKAEKPHDHIG, HPBALDPEPLO ONPHAKPHOJN, CancellationToken EBOFCHGLLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x8416B10", Offset = "0x8415110", VA = "0x188416B10")]
	private void PJGENEOEMPA([CallerMemberName] string MCDCOKIKHMP = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8414390", Offset = "0x8412990", VA = "0x188414390")]
	[AsyncStateMachine(typeof(IMHFGNDLADL))]
	private Task CEPANEEKOIF(LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8415D40", Offset = "0x8414340", VA = "0x188415D40")]
	private void MGDIJCEAEAA(PAIKJEGABFG LEAIIPCAOIH, CancellationToken EBOFCHGLLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8415220", Offset = "0x8413820", VA = "0x188415220")]
	private void HNCGLIJLIEA(PAIKJEGABFG LEAIIPCAOIH, TaskStatus PJPCILIKLGM, string NAAMEAFIHJI, HPBALDPEPLO ONPHAKPHOJN, Exception FJADMGBFJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8416700", Offset = "0x8414D00", VA = "0x188416700")]
	private void NAADEMEBEEI(PAIKJEGABFG LEAIIPCAOIH, HPBALDPEPLO ONPHAKPHOJN, OperationCanceledException LACGGEHDPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8414AA0", Offset = "0x84130A0", VA = "0x188414AA0")]
	private void EIGBHHFBILJ(PAIKJEGABFG LEAIIPCAOIH, HPBALDPEPLO ONPHAKPHOJN, Exception APEPCFJIAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8414B20", Offset = "0x8413120", VA = "0x188414B20")]
	private void FOOOBDDPLNN(PAIKJEGABFG LEAIIPCAOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8415980", Offset = "0x8413F80", VA = "0x188415980")]
	private static OGDCDNJBIFG JFOEFEHMCAC(PAIKJEGABFG LEAIIPCAOIH)
	{
		return default(OGDCDNJBIFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x84144C0", Offset = "0x8412AC0", VA = "0x1884144C0")]
	[AsyncStateMachine(typeof(IJJJMPAHIPB))]
	private Task CHNJHOADPDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x84148F0", Offset = "0x8412EF0", VA = "0x1884148F0")]
	[AsyncStateMachine(typeof(OPHNHBAIKOH))]
	private Task<Matchmaking.MIODFHAAAOG> DNLMGFAFCCB(PAIKJEGABFG LEAIIPCAOIH, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8416A00", Offset = "0x8415000", VA = "0x188416A00")]
	private static CNNKEAJPGPC PEGNIODNFLL(Matchmaking.MIODFHAAAOG BEMGAPIKHPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x8415AE0", Offset = "0x84140E0", VA = "0x188415AE0")]
	[AsyncStateMachine(typeof(IGKDDFEFPLJ))]
	private Task JNHOHGLKKAJ(Matchmaking.MIODFHAAAOG BEMGAPIKHPH, HPBALDPEPLO ONPHAKPHOJN, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken JDCDGDBBGIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x84168C0", Offset = "0x8414EC0", VA = "0x1884168C0")]
	[AsyncStateMachine(typeof(JLFJIKEIILD))]
	private Task PBPLOBFOEBG(PAIKJEGABFG LEAIIPCAOIH, CancellationTokenSource DGNNHFAEMFP, Task DJCCIMIPEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x8414590", Offset = "0x8412B90", VA = "0x188414590")]
	[AsyncStateMachine(typeof(EENBOAPJGLG))]
	private Task COCJIHKCJDD(AENKMJAJKCL GJIIIBDFFHL, HKMALGKDFBG JEAOKNGGMFI, PAIKJEGABFG MENFJEGBKHJ, HPBALDPEPLO JPFNHCBHBEB, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken EADDKLABLKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8414700", Offset = "0x8412D00", VA = "0x188414700")]
	private HPBALDPEPLO DGECELAKJII(HPBALDPEPLO JPFNHCBHBEB, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8416780", Offset = "0x8414D80", VA = "0x188416780")]
	[AsyncStateMachine(typeof(DJLCJKJFBJC))]
	private Task NBAFPMHCEHN(LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x84165D0", Offset = "0x8414BD0", VA = "0x1884165D0")]
	[AsyncStateMachine(typeof(PJCMFDDFJAK))]
	private Task MPPNIDCAJAI(CancellationToken CBJPDIFOEKF, int GMMLOKJHPEI, PFBDGKHFNEC PEEMGACEOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8415770", Offset = "0x8413D70", VA = "0x188415770")]
	private static void IGBMBKGDDBD(PAIKJEGABFG LEAIIPCAOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8414E70", Offset = "0x8413470", VA = "0x188414E70")]
	private void GNCNKABBIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8416C90", Offset = "0x8415290", VA = "0x188416C90")]
	private void PKGPBKMKGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x84158F0", Offset = "0x8413EF0", VA = "0x1884158F0")]
	private void JDHNNEBNGLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x8416070", Offset = "0x8414670", VA = "0x188416070")]
	private void MHDLJPEPFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x8414D30", Offset = "0x8413330", VA = "0x188414D30")]
	private static void GCPHEAEMGOG(PAIKJEGABFG LEAIIPCAOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x8415C30", Offset = "0x8414230", VA = "0x188415C30")]
	private static CancellationTokenRegistration LGEHENAENJD(PAIKJEGABFG LEAIIPCAOIH, CancellationToken JDCDGDBBGIP)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x84159E0", Offset = "0x8413FE0", VA = "0x1884159E0")]
	private static void JJPKKFKIEBJ(PAIKJEGABFG LEAIIPCAOIH, Exception APEPCFJIAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x8415480", Offset = "0x8413A80", VA = "0x188415480")]
	private void IAOEGDODBEE(PAIKJEGABFG LEAIIPCAOIH, Task DJCCIMIPEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8413670", Offset = "0x8411C70", VA = "0x188413670")]
	private static void AHIMDJPCPBN(Func<string> AACKKPGJBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x8416F20", Offset = "0x8415520", VA = "0x188416F20")]
	public DCOJFCLEHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x8416570", Offset = "0x8414B70", VA = "0x188416570")]
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
		[Cpp2IlInjected.Address(RVA = "0x8447C30", Offset = "0x8446230", VA = "0x188447C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8448110", Offset = "0x8446710", VA = "0x188448110", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public OILPCDIHPHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x84421F0", Offset = "0x84407F0", VA = "0x1884421F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x843C810", Offset = "0x843AE10", VA = "0x18843C810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x843CBB0", Offset = "0x843B1B0", VA = "0x18843CBB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x843EC80", Offset = "0x843D280", VA = "0x18843EC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x843EF60", Offset = "0x843D560", VA = "0x18843EF60", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x8446C90", Offset = "0x8445290", VA = "0x188446C90", Slot = "5")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8447110", Offset = "0x8445710", VA = "0x188447110", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8447B40", Offset = "0x8446140", VA = "0x188447B40", Slot = "4")]
	public bool OLHNAMHFFLG(BEPKOPDMDEM DNDLEHOKLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8446F70", Offset = "0x8445570", VA = "0x188446F70")]
	private void BDIKPAGFPOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8447290", Offset = "0x8445890", VA = "0x188447290")]
	private void ICCCAAKOOEP(JOEFAEBJKIB MKIDPONBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x8447A50", Offset = "0x8446050", VA = "0x188447A50")]
	[AsyncStateMachine(typeof(PNPFMGPPEGM))]
	private Task LEGCMELDLHI(int GMMLOKJHPEI, PFBDGKHFNEC PEEMGACEOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8447040", Offset = "0x8445640", VA = "0x188447040")]
	private Func<CancellationToken, List<Task>> DBBCAGHEMFD(int GMMLOKJHPEI, PFBDGKHFNEC PEEMGACEOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x84474B0", Offset = "0x8445AB0", VA = "0x1884474B0")]
	private List<Task> INBOJNDHBMA(int GMMLOKJHPEI, PFBDGKHFNEC PEEMGACEOLF, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x8447170", Offset = "0x8445770", VA = "0x188447170")]
	[AsyncStateMachine(typeof(JLNNOEKFFFG))]
	private Task ENOIDMJBOFN(BEPKOPDMDEM KACLNFIKDJP, CancellationToken EJJDDFFADPC, int GMMLOKJHPEI, PFBDGKHFNEC PEEMGACEOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x8447980", Offset = "0x8445F80", VA = "0x188447980")]
	[AsyncStateMachine(typeof(LIEDEPDEGIN))]
	private Task KEJBHLEIJLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x8446C10", Offset = "0x8445210", VA = "0x188446C10")]
	private void AKBKNLLCFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x8447BA0", Offset = "0x84461A0", VA = "0x188447BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BENLOEBNLNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x842AEC0", Offset = "0x84294C0", VA = "0x18842AEC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public PHIHOPPLDAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8444DB0", Offset = "0x84433B0", VA = "0x188444DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public KEBBEFODOAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x843D870", Offset = "0x843BE70", VA = "0x18843D870")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public DCEDJGDFLCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x842E090", Offset = "0x842C690", VA = "0x18842E090")]
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
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "9")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x843E530", Offset = "0x843CB30", VA = "0x18843E530", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x843E7C0", Offset = "0x843CDC0", VA = "0x18843E7C0", Slot = "4")]
	public AFOHIMBEAIK IIGLPCDPOEE(Guid DHFBDLBBCGN)
	{
		return default(AFOHIMBEAIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x843E5B0", Offset = "0x843CBB0", VA = "0x18843E5B0", Slot = "5")]
	public bool GNAALOCCJEL(Guid DHFBDLBBCGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x843E200", Offset = "0x843C800", VA = "0x18843E200", Slot = "6")]
	public bool CPPOOKGKBAK(Guid DHFBDLBBCGN, Task MENJBHNCOEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x843E9E0", Offset = "0x843CFE0", VA = "0x18843E9E0", Slot = "7")]
	public bool OFJAPNCDIKM(Guid DHFBDLBBCGN, GGIHIJCCBHJ MNJLOAEFEJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x843E540", Offset = "0x843CB40", VA = "0x18843E540", Slot = "8")]
	public Task<(GGIHIJCCBHJ, Task)> EALCCNLLBGO(Guid DHFBDLBBCGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x843DFD0", Offset = "0x843C5D0", VA = "0x18843DFD0")]
	private void ALGCDPEOOFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x843EBC0", Offset = "0x843D1C0", VA = "0x18843EBC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8436730", Offset = "0x8434D30", VA = "0x188436730")]
		public FPAFOEBOJDC(PAIKJEGABFG ELCMKIJIHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x84365B0", Offset = "0x8434BB0", VA = "0x1884365B0")]
		public void AKBKNLLCFBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8436700", Offset = "0x8434D00", VA = "0x188436700", Slot = "4")]
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
		public MFOPHKLDKKA disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public AOEEFOEFCDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x842AE30", Offset = "0x8429430", VA = "0x18842AE30")]
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
		public MFOPHKLDKKA disconnectCause;

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
		[Cpp2IlInjected.Address(RVA = "0x843A280", Offset = "0x8438880", VA = "0x18843A280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x843A6D0", Offset = "0x8438CD0", VA = "0x18843A6D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public FKCPEGNKFGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8436540", Offset = "0x8434B40", VA = "0x188436540")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public MJDOPEIACAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x8440650", Offset = "0x843EC50", VA = "0x188440650")]
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
		[Cpp2IlInjected.Address(RVA = "0x84430A0", Offset = "0x84416A0", VA = "0x1884430A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public KFBLBEMFHEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x843D950", Offset = "0x843BF50", VA = "0x18843D950")]
		internal object LLCHIBKEGAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x843D9F0", Offset = "0x843BFF0", VA = "0x18843D9F0")]
		internal void NEHBBDPEBNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x843D910", Offset = "0x843BF10", VA = "0x18843D910")]
		internal object JHNBMOOGJAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x843D8D0", Offset = "0x843BED0", VA = "0x18843D8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8437010", Offset = "0x8435610", VA = "0x188437010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x8437FD0", Offset = "0x84365D0", VA = "0x188437FD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8433750", Offset = "0x8431D50", VA = "0x188433750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool CPLAGDABEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xC59930", Offset = "0xC57F30", VA = "0x180C59930")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8433D30", Offset = "0x8432330", VA = "0x188433D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x8433210", Offset = "0x8431810", VA = "0x188433210", Slot = "4")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x84335E0", Offset = "0x8431BE0", VA = "0x1884335E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x84337A0", Offset = "0x8431DA0", VA = "0x1884337A0")]
	[AsyncStateMachine(typeof(IMAOPFJBNHF))]
	private Task HDFNILHEPAH(MFOPHKLDKKA FKGOJHDOJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x8433890", Offset = "0x8431E90", VA = "0x188433890")]
	private void JINOHBBNMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x8433D40", Offset = "0x8432340", VA = "0x188433D40")]
	private void OFBKAFGODEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8433A90", Offset = "0x8432090", VA = "0x188433A90")]
	private void KPOEMEHHEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8433A20", Offset = "0x8432020", VA = "0x188433A20")]
	private bool KKOLCJJPPOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x8433C10", Offset = "0x8432210", VA = "0x188433C10")]
	[AsyncStateMachine(typeof(PDPFGHJGNBI))]
	private void MKCODIBLJIE(int LFJPHGCMAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8433ED0", Offset = "0x84324D0", VA = "0x188433ED0")]
	private void OIFEMPMOLOD([Out] IDisposable OBAJHGBEDKP, [Out] IDisposable HICLBANPJFH, [Out] IDisposable FOJACDIEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8434160", Offset = "0x8432760", VA = "0x188434160")]
	private bool OIOHAEDLFCM(PAIKJEGABFG ELCMKIJIHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8433CE0", Offset = "0x84322E0", VA = "0x188433CE0")]
	private void NBHIKBMLECF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x84334B0", Offset = "0x8431AB0", VA = "0x1884334B0")]
	[AsyncStateMachine(typeof(HNPDMIBNPKL))]
	private Task CEEBICJBKID(PAIKJEGABFG ELCMKIJIHIO, LLFJDDEPDIJ GKAEKPHDHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x84345F0", Offset = "0x8432BF0", VA = "0x1884345F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8434EB0", Offset = "0x84334B0", VA = "0x188434EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x8435140", Offset = "0x8433740", VA = "0x188435140", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BIJLPMLGGFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x842B710", Offset = "0x8429D10", VA = "0x18842B710")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public NPPIOBKCDOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x84420D0", Offset = "0x84406D0", VA = "0x1884420D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public DKGCKLEMPDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x8431500", Offset = "0x842FB00", VA = "0x188431500")]
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
		[Cpp2IlInjected.Address(RVA = "0x8442770", Offset = "0x8440D70", VA = "0x188442770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x8443040", Offset = "0x8441640", VA = "0x188443040", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public AGHCDNGLAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x842ACD0", Offset = "0x84292D0", VA = "0x18842ACD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84351B0", Offset = "0x84337B0", VA = "0x1884351B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8435D20", Offset = "0x8434320", VA = "0x188435D20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8444E10", Offset = "0x8443410", VA = "0x188444E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x8445340", Offset = "0x8443940", VA = "0x188445340", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public OFLPKAJGOLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8442170", Offset = "0x8440770", VA = "0x188442170")]
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
		[Cpp2IlInjected.Address(RVA = "0x8441460", Offset = "0x843FA60", VA = "0x188441460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x8441A90", Offset = "0x8440090", VA = "0x188441A90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public HBBIEPJHLKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x8436840", Offset = "0x8434E40", VA = "0x188436840")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public JICOHEIIKIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x843B3C0", Offset = "0x84399C0", VA = "0x18843B3C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x84318F0", Offset = "0x842FEF0", VA = "0x1884318F0", Slot = "7")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8431B00", Offset = "0x8430100", VA = "0x188431B00", Slot = "6")]
	[AsyncStateMachine(typeof(ELAPNLLEGPB))]
	public Task<MCEHODFGIME> GOGCFNHIFMD(CancellationToken JFEANKNHOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x8431560", Offset = "0x842FB60", VA = "0x188431560", Slot = "4")]
	public void AFPIIOCCJEF(DAEAHJMMAED NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x84325B0", Offset = "0x8430BB0", VA = "0x1884325B0", Slot = "5")]
	public void PJPEECINCEE(DAEAHJMMAED BGLJFOPGLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x84324A0", Offset = "0x8430AA0", VA = "0x1884324A0")]
	[AsyncStateMachine(typeof(PBMJIFGGAGP))]
	private Task NNOKLCDMCPG(DAEAHJMMAED HOOJNAMGGBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x84320F0", Offset = "0x84306F0", VA = "0x1884320F0")]
	[AsyncStateMachine(typeof(ELNLMENOAIF))]
	private Task KLIFPDLCGDJ(DAEAHJMMAED EOFANPBCPAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x8431FA0", Offset = "0x84305A0", VA = "0x188431FA0")]
	[AsyncStateMachine(typeof(PHKOIMIBINP))]
	private Task<PPPBMGNNDNF> HNAHDMMIPJB(DAEAHJMMAED HOOJNAMGGBC, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x8432200", Offset = "0x8430800", VA = "0x188432200")]
	private HPBALDPEPLO NDNJCLNDEFB(DAEAHJMMAED CAGMDMPFBND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x84319E0", Offset = "0x842FFE0", VA = "0x1884319E0")]
	[AsyncStateMachine(typeof(NJIEJBMFNHH))]
	private Task GNNPDLMMNEB(PPPBMGNNDNF AOHGJNGCBBI, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x8432290", Offset = "0x8430890", VA = "0x188432290")]
	private PPPBMGNNDNF NDNJKENLGHO(DAEAHJMMAED HOOJNAMGGBC, HPBALDPEPLO HKMAGJLMBHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x36D6C30", Offset = "0x36D5230", VA = "0x1836D6C30")]
	private T CJCJKPNPKEO<T>(T OHLIHBDBKCE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x8431C10", Offset = "0x8430210", VA = "0x188431C10")]
	private PPPBMGNNDNF GOJBMKCOMEE(DAEAHJMMAED HOOJNAMGGBC, HPBALDPEPLO HKMAGJLMBHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public JGKDPGKJFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x843B350", Offset = "0x8439950", VA = "0x18843B350")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public IKNNBMINBAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x843A210", Offset = "0x8438810", VA = "0x18843A210")]
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
	[Cpp2IlInjected.Address(RVA = "0x842B770", Offset = "0x8429D70", VA = "0x18842B770", Slot = "6")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x842BB30", Offset = "0x842A130", VA = "0x18842BB30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x842D1C0", Offset = "0x842B7C0", VA = "0x18842D1C0", Slot = "4")]
	public AFOHIMBEAIK PIAHIINIEGI(DAEAHJMMAED PAFNHBFIGON)
	{
		return default(AFOHIMBEAIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x842C6E0", Offset = "0x842ACE0", VA = "0x18842C6E0", Slot = "5")]
	public void LHAIECBCJJA(Guid DHFBDLBBCGN, Task MENJBHNCOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x842BDE0", Offset = "0x842A3E0", VA = "0x18842BDE0")]
	private void HGJPKNDBGCL(OJOPFCHDHDL KGFBFINKAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x842BEF0", Offset = "0x842A4F0", VA = "0x18842BEF0")]
	private void KHMJNIEOJFP(LPHKFBBGLKG NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x842C470", Offset = "0x842AA70", VA = "0x18842C470")]
	private void LCOADNMFPEJ(LPHKFBBGLKG NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x842C8F0", Offset = "0x842AEF0", VA = "0x18842C8F0")]
	private void NILCHIACLKE(LPHKFBBGLKG NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x842CD10", Offset = "0x842B310", VA = "0x18842CD10")]
	private GGIHIJCCBHJ OLHEKGLFPOI(DAEAHJMMAED CAGMDMPFBND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x842BBE0", Offset = "0x842A1E0", VA = "0x18842BBE0")]
	private void EPNIKNBKMPK(DAEAHJMMAED EOFANPBCPAO, GGIHIJCCBHJ MNJLOAEFEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x842CB30", Offset = "0x842B130", VA = "0x18842CB30")]
	private bool NNEOKKGFLLL(DAEAHJMMAED EOFANPBCPAO, GGIHIJCCBHJ MNJLOAEFEJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x842CFB0", Offset = "0x842B5B0", VA = "0x18842CFB0")]
	private bool ONMHFBCPHAN(DAEAHJMMAED HKCJAMENDMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x842B8E0", Offset = "0x8429EE0", VA = "0x18842B8E0")]
	private bool BNCFNFPOEHI(byte OGKCOMEHLBF, ExitGames.Client.Photon.Hashtable NKBJHKLGFDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BIAMMKIGKBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x842B6A0", Offset = "0x8429CA0", VA = "0x18842B6A0")]
		internal object IEHGGPJGMBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x842B4F0", Offset = "0x8429AF0", VA = "0x18842B4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8439B00", Offset = "0x8438100", VA = "0x188439B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x843A1A0", Offset = "0x84387A0", VA = "0x18843A1A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BMJAGMEODCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x842D5E0", Offset = "0x842BBE0", VA = "0x18842D5E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public JACPBMFABNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x843B270", Offset = "0x8439870", VA = "0x18843B270")]
		internal object IKCBNPGPILP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x843B200", Offset = "0x8439800", VA = "0x18843B200")]
		internal object CADMOLKNCEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x843B2E0", Offset = "0x84398E0", VA = "0x18843B2E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x843F6B0", Offset = "0x843DCB0", VA = "0x18843F6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x843FF80", Offset = "0x843E580", VA = "0x18843FF80", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x843DAD0", Offset = "0x843C0D0", VA = "0x18843DAD0", Slot = "5")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x843DEB0", Offset = "0x843C4B0", VA = "0x18843DEB0", Slot = "4")]
	[AsyncStateMachine(typeof(IKJPOIFCHHD))]
	private Task<GGIHIJCCBHJ> FAJNHCOACMC(DAEAHJMMAED CAGMDMPFBND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x843DCC0", Offset = "0x843C2C0", VA = "0x18843DCC0")]
	private bool CEKFLJOCCDB(MCEHODFGIME MEOBMEDANDK, [Out] GGIHIJCCBHJ OBOOAPELMPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x843DB80", Offset = "0x843C180", VA = "0x18843DB80")]
	[AsyncStateMachine(typeof(MCDEOJADALC))]
	private Task<GGIHIJCCBHJ> BLDHGNDFAGC(DAEAHJMMAED HOOJNAMGGBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x843EFC0", Offset = "0x843D5C0", VA = "0x18843EFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x843F590", Offset = "0x843DB90", VA = "0x18843F590", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public MAFANCHIOEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x843F600", Offset = "0x843DC00", VA = "0x18843F600")]
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
		[Cpp2IlInjected.Address(RVA = "0x842DA30", Offset = "0x842C030", VA = "0x18842DA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x842E020", Offset = "0x842C620", VA = "0x18842E020", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8441AF0", Offset = "0x84400F0", VA = "0x188441AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8442060", Offset = "0x8440660", VA = "0x188442060", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public CCLJNOEBDFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xE67770", Offset = "0xE65D70", VA = "0x180E67770")]
		internal bool LIALJAHOPMN(IINCMBDAHBF sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x842D6E0", Offset = "0x842BCE0", VA = "0x18842D6E0")]
		internal object GNMDAJKJAAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x842D650", Offset = "0x842BC50", VA = "0x18842D650")]
		internal object EGCDAGOFLMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x842D7A0", Offset = "0x842BDA0", VA = "0x18842D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public AHBCEABKJJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x842AD30", Offset = "0x8429330", VA = "0x18842AD30")]
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
		[Cpp2IlInjected.Address(RVA = "0x842ECB0", Offset = "0x842D2B0", VA = "0x18842ECB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x842FC50", Offset = "0x842E250", VA = "0x18842FC50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public EDOIOLIPIOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x8432910", Offset = "0x8430F10", VA = "0x188432910")]
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
		[Cpp2IlInjected.Address(RVA = "0x8440C80", Offset = "0x843F280", VA = "0x188440C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8441350", Offset = "0x843F950", VA = "0x188441350", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x843B580", Offset = "0x8439B80", VA = "0x18843B580", Slot = "5")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x843B420", Offset = "0x8439A20", VA = "0x18843B420", Slot = "4")]
	[AsyncStateMachine(typeof(MACKBHNNNHL))]
	public Task<AENKMJAJKCL> ABPAEOBCGGG(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, PAIKJEGABFG LEAIIPCAOIH, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x843BAC0", Offset = "0x843A0C0", VA = "0x18843BAC0")]
	[AsyncStateMachine(typeof(CNIMCIEBHGH))]
	private Task<GOMNLGPHFID> NEENNCEDKBA(PAIKJEGABFG LEAIIPCAOIH, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x843B950", Offset = "0x8439F50", VA = "0x18843B950")]
	[AsyncStateMachine(typeof(NMKOLFJJIDM))]
	private Task<AENKMJAJKCL> MCOPKEFNDLB(PAIKJEGABFG LEAIIPCAOIH, GOMNLGPHFID NMKJEHFFHPL, long NBOIIPJHEBJ, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x843B7E0", Offset = "0x8439DE0", VA = "0x18843B7E0")]
	[AsyncStateMachine(typeof(DIMLACEJNKO))]
	private Task<LHKFBJIEMLN> INEENPBDMKO(PAIKJEGABFG LEAIIPCAOIH, GOMNLGPHFID NMKJEHFFHPL, long NBOIIPJHEBJ, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x843B670", Offset = "0x8439C70", VA = "0x18843B670")]
	[AsyncStateMachine(typeof(NAGKMHFGMMG))]
	private Task<LHKFBJIEMLN> CFFADELLPGN(PAIKJEGABFG CEGAPABPHKJ, IINCMBDAHBF CHLJPLPCJPN, long NBOIIPJHEBJ, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public GHKBKKDDJPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x84367E0", Offset = "0x8434DE0", VA = "0x1884367E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8434830", Offset = "0x8432E30", VA = "0x188434830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8434E40", Offset = "0x8433440", VA = "0x188434E40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x843FFF0", Offset = "0x843E5F0", VA = "0x18843FFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x84405E0", Offset = "0x843EBE0", VA = "0x1884405E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public KLBPADFOJPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x843DA70", Offset = "0x843C070", VA = "0x18843DA70")]
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
		[Cpp2IlInjected.Address(RVA = "0x843CC10", Offset = "0x843B210", VA = "0x18843CC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x843D800", Offset = "0x843BE00", VA = "0x18843D800", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x84361D0", Offset = "0x84347D0", VA = "0x1884361D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x8435E00", Offset = "0x8434400", VA = "0x188435E00", Slot = "8")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x8436070", Offset = "0x8434670", VA = "0x188436070", Slot = "4")]
	[AsyncStateMachine(typeof(EKNKAFDCFFN))]
	public Task<DAEAHJMMAED> IFFNFJKHIBD(DAEAHJMMAED HOOJNAMGGBC, HPBALDPEPLO HKMAGJLMBHL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x8436290", Offset = "0x8434890", VA = "0x188436290", Slot = "5")]
	[AsyncStateMachine(typeof(MFHADGHFGLO))]
	public Task<DAEAHJMMAED> LMAIGOFMOJO(CancellationToken CBJPDIFOEKF, HPBALDPEPLO HKMAGJLMBHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x8435FC0", Offset = "0x84345C0", VA = "0x188435FC0", Slot = "6")]
	public GEHMKHHFLAO GIMLJHNDHNK(PPPBMGNNDNF IDGCKCFDFPA, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x8435E90", Offset = "0x8434490", VA = "0x188435E90", Slot = "7")]
	public GEHMKHHFLAO GGMGBIFDEGF(PPPBMGNNDNF IDGCKCFDFPA, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x84363E0", Offset = "0x84349E0", VA = "0x1884363E0")]
	[AsyncStateMachine(typeof(KAOMDOFCPIB))]
	private Task<DAEAHJMMAED> NLHCPBIKBMI(DAEAHJMMAED HOOJNAMGGBC, HPBALDPEPLO HKMAGJLMBHL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x38797F0", Offset = "0x3877DF0", VA = "0x1838797F0")]
	private static byte[] EBMLCGPIHNA(DAEAHJMMAED NAAMEAFIHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x842B480", Offset = "0x8429A80", VA = "0x18842B480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static GGIHIJCCBHJ JPLAKFPJJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x842B4E0", Offset = "0x8429AE0", VA = "0x18842B4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x842B090", Offset = "0x8429690", VA = "0x18842B090", Slot = "6")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x842AF20", Offset = "0x8429520", VA = "0x18842AF20", Slot = "4")]
	public GGIHIJCCBHJ AECOKMGPPFN(AIPAHMNCJKP FCDLIEFOPHH, MCEHODFGIME IKONCMMACKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x842B200", Offset = "0x8429800", VA = "0x18842B200", Slot = "5")]
	public GGIHIJCCBHJ BLCKACIGLDJ(AIPAHMNCJKP HIHGMFDAMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x842B4D0", Offset = "0x8429AD0", VA = "0x18842B4D0")]
	private static GGIHIJCCBHJ HNEINKPPENO(GKOJCGDILMH DKBCGBFNIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public BHJHMPAIKBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class OANABFNNJPA : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x8442130", Offset = "0x8440730", VA = "0x188442130")]
	public OANABFNNJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x7645FC0", Offset = "0x76445C0", VA = "0x187645FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x842E0F0", Offset = "0x842C6F0", VA = "0x18842E0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x842EC40", Offset = "0x842D240", VA = "0x18842EC40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x84387E0", Offset = "0x8436DE0", VA = "0x1884387E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x8438F20", Offset = "0x8437520", VA = "0x188438F20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8440710", Offset = "0x843ED10", VA = "0x188440710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x8440C20", Offset = "0x843F220", VA = "0x188440C20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8438030", Offset = "0x8436630", VA = "0x188438030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x8438780", Offset = "0x8436D80", VA = "0x188438780", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x842D830", Offset = "0x842BE30", VA = "0x18842D830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x842D9D0", Offset = "0x842BFD0", VA = "0x18842D9D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x84368A0", Offset = "0x8434EA0", VA = "0x1884368A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x8436FB0", Offset = "0x84355B0", VA = "0x188436FB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x84448E0", Offset = "0x8442EE0", VA = "0x1884448E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x8444D50", Offset = "0x8443350", VA = "0x188444D50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x845A2C0", Offset = "0x84588C0", VA = "0x18845A2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x845A860", Offset = "0x8458E60", VA = "0x18845A860", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x8445C00", Offset = "0x8444200", VA = "0x188445C00", Slot = "6")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x12B0C60", Offset = "0x12AF260", VA = "0x1812B0C60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x8445EA0", Offset = "0x84444A0", VA = "0x188445EA0")]
	private void DGNHLKMBOLJ(float HHKEOHHPHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x8446220", Offset = "0x8444820", VA = "0x188446220", Slot = "4")]
	[AsyncStateMachine(typeof(DHCJDMIINJK))]
	public Task<GGIHIJCCBHJ> FEPBIOOICAE(OPPGGNKKPPF HIIKALLGCLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x8446A20", Offset = "0x8445020", VA = "0x188446A20", Slot = "5")]
	[AsyncStateMachine(typeof(IANLGHIKHIN))]
	public Task NIIEIIOKINC([Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x12B0C60", Offset = "0x12AF260", VA = "0x1812B0C60")]
	public void HKFBEGCLNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x84467B0", Offset = "0x8444DB0", VA = "0x1884467B0")]
	private OIFFOMNPKAJ MJGNFDKDBML(OPPGGNKKPPF HIIKALLGCLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x8446350", Offset = "0x8444950", VA = "0x188446350")]
	[AsyncStateMachine(typeof(MNGPNPFMFIN))]
	private Task IFJHPBFOLNO(CancellationToken EBOFCHGLLPK, int GMMLOKJHPEI, PFBDGKHFNEC PEEMGACEOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x8446B10", Offset = "0x8445110", VA = "0x188446B10")]
	[AsyncStateMachine(typeof(HPGCKPODPPM))]
	private Task OMANIIFCEDD(CancellationToken EBOFCHGLLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x8445DB0", Offset = "0x84443B0", VA = "0x188445DB0")]
	[AsyncStateMachine(typeof(CFPMFHBBBCE))]
	private Task BDLEBBJIFOP([Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x8446440", Offset = "0x8444A40", VA = "0x188446440")]
	[AsyncStateMachine(typeof(HHDMHJACKJK))]
	private Task JBAPJPEPNDI(CancellationToken EBOFCHGLLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x8446920", Offset = "0x8444F20", VA = "0x188446920")]
	[AsyncStateMachine(typeof(PGEBGCHFADO))]
	private Task NDEAKDENPEL(CancellationToken FBKKBOAHBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x8445F80", Offset = "0x8444580", VA = "0x188445F80")]
	private Task DHCMPIJNCOF(KNEDGBILGPM EDHLLDFNCFM, CancellationToken EBOFCHGLLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x8446110", Offset = "0x8444710", VA = "0x188446110")]
	[AsyncStateMachine(typeof(MHBANPPLFEL))]
	private Task DILDDFBPNIP(KNEDGBILGPM EDHLLDFNCFM, CancellationToken EBOFCHGLLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x8446530", Offset = "0x8444B30", VA = "0x188446530")]
	private bool KHANCPFOBAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8457900", Offset = "0x8455F00", VA = "0x188457900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x8457EB0", Offset = "0x84564B0", VA = "0x188457EB0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x8461F70", Offset = "0x8460570", VA = "0x188461F70", Slot = "6")]
	public void ANJKPBDKBKO(IPAGNGHLCCF BFCIGLOEMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x8462250", Offset = "0x8460850", VA = "0x188462250", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x8461E70", Offset = "0x8460470", VA = "0x188461E70", Slot = "5")]
	[AsyncStateMachine(typeof(KFBAGFPEBPI))]
	public Task AHIIEDFIFFE(string IGFKNGAMFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x84623E0", Offset = "0x84609E0", VA = "0x1884623E0", Slot = "4")]
	public GGIHIJCCBHJ KHANCPFOBAK(AIPAHMNCJKP FCDLIEFOPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x84622A0", Offset = "0x84608A0", VA = "0x1884622A0")]
	private FGADKJHOMIE JLNJNPLNNEF(string IGFKNGAMFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PGMDFBNJGJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class ILNMCFBCOOG
{
	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x84569F0", Offset = "0x8454FF0", VA = "0x1884569F0")]
	public static void HFGPHFCKLIA(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x84567B0", Offset = "0x8454DB0", VA = "0x1884567B0")]
	internal static void BNIEDJBNNHM(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x8456910", Offset = "0x8454F10", VA = "0x188456910")]
	internal static void CEINGPOHGDF(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x8456C30", Offset = "0x8455230", VA = "0x188456C30")]
	internal static void NFPBFHFBOKG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x38A3240", Offset = "0x38A1840", VA = "0x1838A3240")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public JJKHMACFNED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x84574F0", Offset = "0x8455AF0", VA = "0x1884574F0")]
		internal object PEEMBAAGIPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly CGCAIAMLOIL MLIJHBGBMKP;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x844C570", Offset = "0x844AB70", VA = "0x18844C570")]
	public ExitGames.Client.Photon.Hashtable DFNAEDFOBIJ(DAEAHJMMAED NAAMEAFIHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x844C600", Offset = "0x844AC00", VA = "0x18844C600", Slot = "5")]
	protected override void ONCMPAIJPBO(DAEAHJMMAED NAAMEAFIHJI, IDictionary<object, object> APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x844C0A0", Offset = "0x844A6A0", VA = "0x18844C0A0", Slot = "6")]
	public override DAEAHJMMAED AKDPGDCBDMI(IDictionary<object, object> APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x844BF90", Offset = "0x844A590", VA = "0x18844BF90")]
	private static void AHIMDJPCPBN(string AIAOPAOOPLP, DAEAHJMMAED NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x844C7C0", Offset = "0x844ADC0", VA = "0x18844C7C0")]
	public CGCAIAMLOIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x844C2D0", Offset = "0x844A8D0", VA = "0x18844C2D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84615F0", Offset = "0x845FBF0", VA = "0x1884615F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x8461650", Offset = "0x845FC50", VA = "0x188461650")]
	public static bool JADGJIAIEEB(this GGIHIJCCBHJ MNJLOAEFEJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x8461590", Offset = "0x845FB90", VA = "0x188461590")]
	public static GGIHIJCCBHJ HNEINKPPENO(GKOJCGDILMH ECOONOEHGGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x84613A0", Offset = "0x845F9A0", VA = "0x1884613A0")]
	public static GGIHIJCCBHJ EBGJDGDECMJ(IEnumerable<GGIHIJCCBHJ> KOPHNHFIBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x8461150", Offset = "0x845F750", VA = "0x188461150")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public MBLFCEFGMKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x15657B0", Offset = "0x1563DB0", VA = "0x1815657B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8457110", Offset = "0x8455710", VA = "0x188457110", Slot = "4")]
	public void GFGGHIPHBFC(MNMAAAIFNNE EDPLIBFIBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x8457400", Offset = "0x8455A00", VA = "0x188457400", Slot = "5")]
	public void KKFKAFOHICN(MNMAAAIFNNE EDPLIBFIBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x84570C0", Offset = "0x84556C0", VA = "0x1884570C0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x8457170", Offset = "0x8455770", VA = "0x188457170")]
	protected GGIHIJCCBHJ KCIKHHHEPLE(AIPAHMNCJKP HIHGMFDAMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x8457460", Offset = "0x8455A60", VA = "0x188457460")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public GOICOPBMFKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8455C50", Offset = "0x8454250", VA = "0x188455C50")]
		internal object EHKGBDGDBGO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x844CE60", Offset = "0x844B460", VA = "0x18844CE60")]
	[UnityEngine.Scripting.Preserve]
	public IDAEODOMAAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x8456580", Offset = "0x8454B80", VA = "0x188456580", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public JBOCCOMDCOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x8457060", Offset = "0x8455660", VA = "0x188457060")]
		internal object OENAHAPEMMO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x844CE60", Offset = "0x844B460", VA = "0x18844CE60")]
	[UnityEngine.Scripting.Preserve]
	public DHFBDLMJJHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x844CD50", Offset = "0x844B350", VA = "0x18844CD50", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public CLGKNHEEDIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x844CA50", Offset = "0x844B050", VA = "0x18844CA50")]
		internal object JAGPAJGFINL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x8460FB0", Offset = "0x845F5B0", VA = "0x188460FB0")]
	public static LDCGKGNFMMI<string> FJCAOCFABJI(JBBHIJHGEPM PAJIGEJCNAP, [Optional] string FPFAFHGGBCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x8460EF0", Offset = "0x845F4F0", VA = "0x188460EF0")]
	public static void FEPCEDCODDP(LDCGKGNFMMI<string> DCCJGOAMNIL, JBBHIJHGEPM PAJIGEJCNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x8461090", Offset = "0x845F690", VA = "0x188461090")]
	public static string LKECEAPNCID(DAEAHJMMAED CAGMDMPFBND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal static class EIEDOBBOKPN
{
	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x844FC80", Offset = "0x844E280", VA = "0x18844FC80")]
	public static void GMOLLDHBBJD(this LDMAAALPMPJ NODDAHEDIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x844FC70", Offset = "0x844E270", VA = "0x18844FC70")]
	public static void CFFJBGFNFHJ(this LDMAAALPMPJ NODDAHEDIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x844FC90", Offset = "0x844E290", VA = "0x18844FC90")]
	private static void HJAPBBALAED(this LDMAAALPMPJ NODDAHEDIAD, bool AOENBMECMMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class EPDEFBAADFM : COJCHFJKFGH, OCEOKOPOIDE, NOCKFOJODFM, CIKJMMPNKIM
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[DefaultMember("Item")]
	private class KHNDLIGIGHK : OJOPFCHDHDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private readonly byte DAOAPLFBLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private readonly int OHEIAKHGGAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private readonly object JPIDMNEHJMB;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public byte BLPCOOECADL
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0xC8F7E0", Offset = "0xC8DDE0", VA = "0x180C8F7E0", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public int FACMAKELJCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0xB76480", Offset = "0xB74A80", VA = "0x180B76480", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public object DNDBDKJJJDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public object OEMFNNCKNFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x8458030", Offset = "0x8456630", VA = "0x188458030", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x764D6B0", Offset = "0x764BCB0", VA = "0x18764D6B0")]
		public KHNDLIGIGHK(byte DAOAPLFBLDC, int OHEIAKHGGAM, object JPIDMNEHJMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x8458080", Offset = "0x8456680", VA = "0x188458080", Slot = "8")]
		public bool LKMKPGKLGLC(byte OEHHKNIGGMI, [Out] object OHLIHBDBKCE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	private readonly OCEOKOPOIDE OOPGEEKAHCE;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public AIPAHMNCJKP GOBODFFBLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x84503C0", Offset = "0x844E9C0", VA = "0x1884503C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int CBPDIDBMAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x8450A30", Offset = "0x844F030", VA = "0x188450A30", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int GDMDCOLJKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x8450210", Offset = "0x844E810", VA = "0x188450210", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public AIPAHMNCJKP DBAJPAJFKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x84509E0", Offset = "0x844EFE0", VA = "0x1884509E0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool CHECBKFCEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public int BGJGEDOMAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xBEDFB0", Offset = "0xBEC5B0", VA = "0x180BEDFB0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public string FNIDKLLCNLL
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x8450300", Offset = "0x844E900", VA = "0x188450300", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Func<string, string> FDBKMKNHCNH
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x8450920", Offset = "0x844EF20", VA = "0x188450920", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action<string, long> OMEIKEFOGOL
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event Action<OJOPFCHDHDL> DFKNIPLLABH
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x8450410", Offset = "0x844EA10", VA = "0x188450410", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x8450870", Offset = "0x844EE70", VA = "0x188450870", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> PGGHJNOGJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "25")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "26")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<AIPAHMNCJKP> BOFMJJJDNII
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action IGNBBEIMHLG
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x8450170", Offset = "0x844E770", VA = "0x188450170", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x8450260", Offset = "0x844E860", VA = "0x188450260", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xD20480", Offset = "0xD1EA80", VA = "0x180D20480")]
	public EPDEFBAADFM(OCEOKOPOIDE OOPGEEKAHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x8450640", Offset = "0x844EC40", VA = "0x188450640", Slot = "8")]
	public bool HCJMLNIBOLL(byte OGKCOMEHLBF, object ECDOALGCOGB, FIHNAFNBAOM BPOCFKJCMPI, ECINONBCFEB NFHBBLBIHNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x84505A0", Offset = "0x844EBA0", VA = "0x1884505A0", Slot = "19")]
	public AIPAHMNCJKP FJANIPABJKC(int NDLKGDLDBGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x8450750", Offset = "0x844ED50", VA = "0x188450750", Slot = "20")]
	public AIPAHMNCJKP IPELDIICOHI(int BEKCOFDFFEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x84504C0", Offset = "0x844EAC0", VA = "0x1884504C0", Slot = "21")]
	public AIPAHMNCJKP FHOPPGHOFNI(int NDLKGDLDBGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x8450A80", Offset = "0x844F080", VA = "0x188450A80", Slot = "22")]
	public IReadOnlyList<AIPAHMNCJKP> OJJFAAMHMDG(bool KDMFJEEFAMJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x8450830", Offset = "0x844EE30", VA = "0x188450830", Slot = "23")]
	public IReadOnlyList<AIPAHMNCJKP> KDHNNCGFHDK(bool KDMFJEEFAMJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "24")]
	public bool HILFMHCJLJP(AIPAHMNCJKP KLNMAEPBFPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "27")]
	public void DKPIKMBPINA(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "28")]
	public void ALMPMCJJIOE(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "29")]
	public void BNNDCGBBCIN(object EJJDDFFADPC, bool OCMLCOPEGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x8450B60", Offset = "0x844F160", VA = "0x188450B60", Slot = "30")]
	public IDisposable PLDDPPBKMIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "31")]
	private bool FGECOFDOFAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "32")]
	public void FGCMBDGGIHH(StringBuilder JHKAJNJALDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0xF69F00", Offset = "0xF68500", VA = "0x180F69F00", Slot = "33")]
	public bool MBCAHMDJCAI(bool BOFOJGDGLOP, [Out] string JHEMEKBLBHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0xF15EC0", Offset = "0xF144C0", VA = "0x180F15EC0", Slot = "36")]
	public void EDIOHFHBDHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal struct LPHKFBBGLKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	private readonly IDictionary<object, object> NKBJHKLGFDP;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0xD2EEF0", Offset = "0xD2D4F0", VA = "0x180D2EEF0")]
	public LPHKFBBGLKG(IDictionary<object, object> NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x84597B0", Offset = "0x8457DB0", VA = "0x1884597B0")]
	public bool DIIPOHHAKKD([Out] DAEAHJMMAED NAAMEAFIHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x8459A80", Offset = "0x8458080", VA = "0x188459A80")]
	public Guid PILGNJADEJL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x8459950", Offset = "0x8457F50", VA = "0x188459950")]
	public GGIHIJCCBHJ HPDKBILAJJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x8459860", Offset = "0x8457E60", VA = "0x188459860")]
	public static ExitGames.Client.Photon.Hashtable FLLMCNLHKNL(DAEAHJMMAED NAAMEAFIHJI, GGIHIJCCBHJ MNJLOAEFEJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal static class EPEHKPEOINA
{
	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x8450BB0", Offset = "0x844F1B0", VA = "0x188450BB0")]
	public static bool HPFGKIHMNNP(this PAIKJEGABFG HJHEMAOEAHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal struct MFIEBJJDOKB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct BAPEODFIGHC : IAsyncStateMachine
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
		public MFIEBJJDOKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x8449790", Offset = "0x8447D90", VA = "0x188449790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x8449970", Offset = "0x8447F70", VA = "0x188449970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	private readonly CancellationTokenSource CLDKCMPEHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400039D")]
	private bool DPFEMHMCJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039E")]
	private Task BGKKDAHMDLM;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool LKIDIFGHMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x845A160", Offset = "0x8458760", VA = "0x18845A160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x845A190", Offset = "0x8458790", VA = "0x18845A190")]
	public MFIEBJJDOKB(CancellationToken CBJPDIFOEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x845A000", Offset = "0x8458600", VA = "0x18845A000")]
	[AsyncStateMachine(typeof(BAPEODFIGHC))]
	public Task DIENEBAEOMC(Func<CancellationToken, List<Task>> HBFHHJFANBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x845A110", Offset = "0x8458710", VA = "0x18845A110", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public readonly struct KLLJHPOCLHE<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct ECKBFDGKAGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<PFOMDLOAMOL<TData>, OGMCLKGLBPG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public KLLJHPOCLHE<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private TaskAwaiter<HHHCCNLMPJL<PFOMDLOAMOL<TData>, OGMCLKGLBPG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x44F89B0", Offset = "0x44F6FB0", VA = "0x1844F89B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x44F9550", Offset = "0x44F7B50", VA = "0x1844F9550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private readonly CEFIABFPECO<TGetDataArg, TData> IJFOHHKJJKM;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0xD2EEF0", Offset = "0xD2D4F0", VA = "0x180D2EEF0")]
	internal KLLJHPOCLHE(CEFIABFPECO<TGetDataArg, TData> MMCKJCAOGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x501A4A0", Offset = "0x5018AA0", VA = "0x18501A4A0")]
	[AsyncStateMachine(typeof(KLLJHPOCLHE<, >.ECKBFDGKAGC))]
	public Task<HHHCCNLMPJL<PFOMDLOAMOL<TData>, OGMCLKGLBPG>> DJPILFFGEMC(TGetDataArg GIOLPIPFPPJ, string CCKBGGOCFOE, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class FMELJIPNMJG
{
	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x36ADAB0", Offset = "0x36AC0B0", VA = "0x1836ADAB0")]
	public static KLLJHPOCLHE<TGetDataArg, TData> ACADPGMDEBE<TGetDataArg, TData>(CEFIABFPECO<TGetDataArg, TData> MMCKJCAOGBM)
	{
		return default(KLLJHPOCLHE<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public struct HBMPNPEHDHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public readonly int BLPCOOECADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public readonly int? KLBAABHABHI;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x50C5610", Offset = "0x50C3C10", VA = "0x1850C5610")]
	public HBMPNPEHDHN(int DAOAPLFBLDC, [Optional] int? HPMMEOADALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x8455CB0", Offset = "0x84542B0", VA = "0x188455CB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface OBNCDKECHJH<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAPMPDILBOF();

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OBNCDKECHJH<T> JPIMILOLNGI(string NCGJCKHFLGN);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OBNCDKECHJH<T> NDBEEFGNKEA(DHNONLKKJIP<T> KKBFPFNALJK);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OBNCDKECHJH<T> CMLECHKKPMB(int LELALGHIBFL);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OBNCDKECHJH<T> LDOIJOOMFKD(int LELALGHIBFL, POGDNIPDDOF<T> LJJBCIIDJIP);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface IBHJLAMHBCG
{
	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OBNCDKECHJH<T> EGGMNEPKEGO<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LADNFHMCJKC CDGPNPFGMIJ(Exception APEPCFJIAMB);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HBMPNPEHDHN BDKPEGJDMJP(Exception APEPCFJIAMB);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public delegate string DHNONLKKJIP<in T>(T APEPCFJIAMB) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public delegate int POGDNIPDDOF<in T>(T APEPCFJIAMB) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FC")]
internal class OELJFAPHCCJ : IBHJLAMHBCG
{
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private delegate string BPLODBJBKOH(Exception APEPCFJIAMB);

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private delegate int GJANCOLLMJG(Exception APEPCFJIAMB);

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private class DIOPCAPOBKD<T> : OBNCDKECHJH<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		[CompilerGenerated]
		private sealed class PDHJMJDJGOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public PDHJMJDJGOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			internal string HEIHGGHHBAA(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class GFEMHPIPJID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			public DHNONLKKJIP<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public GFEMHPIPJID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x4521FD0", Offset = "0x45205D0", VA = "0x184521FD0")]
			internal string GHILDNCJHDJ(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class EJLDMBHNMIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public POGDNIPDDOF<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public EJLDMBHNMIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x4521FD0", Offset = "0x45205D0", VA = "0x184521FD0")]
			internal int PCOAEHFLMPN(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private readonly OELJFAPHCCJ IMMBIKKFMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private readonly Type BONIGKDFHKB;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A41B10", Offset = "0x6A40110", VA = "0x186A41B10")]
		internal DIOPCAPOBKD(OELJFAPHCCJ IMMBIKKFMEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A41890", Offset = "0x6A3FE90", VA = "0x186A41890", Slot = "4")]
		public void KAPMPDILBOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A41770", Offset = "0x6A3FD70", VA = "0x186A41770", Slot = "5")]
		public OBNCDKECHJH<T> JPIMILOLNGI(string NCGJCKHFLGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A419F0", Offset = "0x6A3FFF0", VA = "0x186A419F0", Slot = "6")]
		public OBNCDKECHJH<T> NDBEEFGNKEA(DHNONLKKJIP<T> KKBFPFNALJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x6A41730", Offset = "0x6A3FD30", VA = "0x186A41730", Slot = "7")]
		public OBNCDKECHJH<T> CMLECHKKPMB(int LELALGHIBFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A418C0", Offset = "0x6A3FEC0", VA = "0x186A418C0", Slot = "8")]
		public OBNCDKECHJH<T> LDOIJOOMFKD(int LELALGHIBFL, POGDNIPDDOF<T> LJJBCIIDJIP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private class OLPMKHLFKDJ<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private bool EHOJJGJOJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private readonly List<Type> CBOMCCCMIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private readonly Dictionary<Type, TVal> HCIMFFEAFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private readonly Dictionary<Type, int> OLBOPINIDKL;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public IReadOnlyList<Type> NHLCMINJMEG
		{
			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x5544BB0", Offset = "0x55431B0", VA = "0x185544BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x5545070", Offset = "0x5543670", VA = "0x185545070")]
		public OLPMKHLFKDJ(Dictionary<Type, int> OLBOPINIDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x5544E50", Offset = "0x5543450", VA = "0x185544E50")]
		public void IIGLPCDPOEE(Type OEHHKNIGGMI, TVal GCDAJLDGOIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x5544AB0", Offset = "0x55430B0", VA = "0x185544AB0")]
		public bool AGMILAFMHHE(Type BONIGKDFHKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x5544F00", Offset = "0x5543500", VA = "0x185544F00")]
		public bool JAOEPNGFPMK(TVal OHLIHBDBKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x40A2DF0", Offset = "0x40A13F0", VA = "0x1840A2DF0")]
		public TVal PHDCGNDDLGA(Type MLCOGCMJLBB)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x5544D00", Offset = "0x5543300", VA = "0x185544D00")]
		[CompilerGenerated]
		private int FPJCMKLCGJK(Type KPKGOLFBDHB, Type JJKBILGLHJC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private sealed class PEGJJGKHENH : IEnumerable<HBMPNPEHDHN>, IEnumerable, IEnumerator<HBMPNPEHDHN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private HBMPNPEHDHN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public OELJFAPHCCJ <>4__this;

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
		private IEnumerator<HBMPNPEHDHN> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private HBMPNPEHDHN System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x4591490", Offset = "0x458FA90", VA = "0x184591490", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(HBMPNPEHDHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0x8461CD0", Offset = "0x84602D0", VA = "0x188461CD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xE9CA20", Offset = "0xE9B020", VA = "0x180E9CA20")]
		[DebuggerHidden]
		public PEGJJGKHENH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x8461D20", Offset = "0x8460320", VA = "0x188461D20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x84616C0", Offset = "0x845FCC0", VA = "0x1884616C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x8461670", Offset = "0x845FC70", VA = "0x188461670")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x8461B70", Offset = "0x8460170", VA = "0x188461B70")]
		private void PJDCPOGKKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x8461C80", Offset = "0x8460280", VA = "0x188461C80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x8461BC0", Offset = "0x84601C0", VA = "0x188461BC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HBMPNPEHDHN> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x8461BC0", Offset = "0x84601C0", VA = "0x188461BC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private static readonly HBMPNPEHDHN HNEEEIKLENM;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private static readonly Dictionary<Type, int> MCKEJJLMJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly HashSet<Type> FMBDHNMNIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	private readonly OLPMKHLFKDJ<int> LJCKLBEPGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	private readonly OLPMKHLFKDJ<GJANCOLLMJG> AIEEICIECNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	private readonly OLPMKHLFKDJ<BPLODBJBKOH> NDPGJCPFFNK;

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x845E9C0", Offset = "0x845CFC0", VA = "0x18845E9C0")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	internal static void MAKIPFCGLCJ(AINJBKKEAIL PJLGMBBLBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x845EC40", Offset = "0x845D240", VA = "0x18845EC40")]
	[RecRoom.NoEngine.Common.Preserve]
	public OELJFAPHCCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x36C4FE0", Offset = "0x36C35E0", VA = "0x1836C4FE0", Slot = "4")]
	public OBNCDKECHJH<T> EGGMNEPKEGO<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x845DF50", Offset = "0x845C550", VA = "0x18845DF50", Slot = "5")]
	public LADNFHMCJKC CDGPNPFGMIJ(Exception APEPCFJIAMB)
	{
		return default(LADNFHMCJKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x845DB30", Offset = "0x845C130", VA = "0x18845DB30", Slot = "6")]
	public HBMPNPEHDHN BDKPEGJDMJP(Exception? APEPCFJIAMB)
	{
		return default(HBMPNPEHDHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x845DD30", Offset = "0x845C330", VA = "0x18845DD30", Slot = "7")]
	[IteratorStateMachine(typeof(PEGJJGKHENH))]
	public IEnumerable<HBMPNPEHDHN> BJGEIKPLDGM(Exception APEPCFJIAMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x845EA30", Offset = "0x845D030", VA = "0x18845EA30", Slot = "8")]
	public string MFGJAHBDACG(Exception? APEPCFJIAMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x845E0C0", Offset = "0x845C6C0", VA = "0x18845E0C0")]
	private string HFBHMPFBJKB(AggregateException DDPJLHLLDEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x845E610", Offset = "0x845CC10", VA = "0x18845E610")]
	private void KJCPOFLAPFE(Type BONIGKDFHKB, int LELALGHIBFL, GJANCOLLMJG? DMFEAKDOMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x845E3C0", Offset = "0x845C9C0", VA = "0x18845E3C0")]
	private void IPJLINNODJL(Type BONIGKDFHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x845D860", Offset = "0x845BE60", VA = "0x18845D860")]
	private void AIJAMNCOFME(Type BONIGKDFHKB, BPLODBJBKOH GHBBDPKACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x845DDD0", Offset = "0x845C3D0", VA = "0x18845DDD0")]
	private static int CANBAEMELDP(Type BONIGKDFHKB, Dictionary<Type, int> OLBOPINIDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x39EAD70", Offset = "0x39E9370", VA = "0x1839EAD70")]
	private static bool BKNCNAFKDCN<TVal>(OLPMKHLFKDJ<TVal> DHLGAIMCINE, Type BONIGKDFHKB, [Out] TVal OHLIHBDBKCE) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x845DFE0", Offset = "0x845C5E0", VA = "0x18845DFE0")]
	[CompilerGenerated]
	internal static int HDGPDNHHEDC(Type COLGODNEKAJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public struct LADNFHMCJKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public readonly HBMPNPEHDHN MAOIEOGFFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public readonly string HFGBEFOGKEI;

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x8458960", Offset = "0x8456F60", VA = "0x188458960")]
	public LADNFHMCJKC(string OLMDHHIGBJB, HBMPNPEHDHN LELALGHIBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x84588C0", Offset = "0x8456EC0", VA = "0x1884588C0")]
	public string IFFMJMELLPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public class PLHOCFLCCME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	private readonly DBENBDOGMLE HOEGGBMBFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	private string NBIDDPLGEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private long? NLGHOAENGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	private long? DGJJNNDKENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private long? MJEDJOPIOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private string AICIKMEEBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private IHHBKLENLMK DNCDPIDDNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private long? GOJNKGPKLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private bool LGMGMCBJBEK;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public string MHGFJNIFJPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public long KMIHABKOEPN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x8462630", Offset = "0x8460C30", VA = "0x188462630")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public long LDAENLHGJFE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x8462AF0", Offset = "0x84610F0", VA = "0x188462AF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public long CHPEOODLDHE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x84625D0", Offset = "0x8460BD0", VA = "0x1884625D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string OODJGDGPLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x8462590", Offset = "0x8460B90", VA = "0x188462590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public IHHBKLENLMK BFNPKMIEPDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xD75B20", Offset = "0xD74120", VA = "0x180D75B20")]
		get
		{
			return default(IHHBKLENLMK);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x84624A0", Offset = "0x8460AA0", VA = "0x1884624A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public long NGBPDOGKLPC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x8462A90", Offset = "0x8461090", VA = "0x188462A90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x84632D0", Offset = "0x84618D0", VA = "0x1884632D0")]
	[UnityEngine.Scripting.Preserve]
	public PLHOCFLCCME([DJIFKCCBBND(null)] DBENBDOGMLE HOEGGBMBFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x8462B50", Offset = "0x8461150", VA = "0x188462B50")]
	private void KGGGDHMOBFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x8462E40", Offset = "0x8461440", VA = "0x188462E40")]
	public void MAAKGIGDIKI(long CINEDGEJAIA, long NBOIIPJHEBJ, [Optional] long? CFBANPJJEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x8462DA0", Offset = "0x84613A0", VA = "0x188462DA0")]
	public void LKHMAONAMFE(long CFBANPJJEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x8462A10", Offset = "0x8461010", VA = "0x188462A10")]
	public void DAGKPKEJMDP(string PCMGNKOHCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x8462690", Offset = "0x8460C90", VA = "0x188462690")]
	public void CPCGPAEHOGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
internal class GEHMKHHFLAO : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct KIEMHJIHHKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public AsyncTaskMethodBuilder<DAEAHJMMAED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public DAEAHJMMAED roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public GEHMKHHFLAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private TaskAwaiter<OBOJAHIICMM.ELCFJMNDKFL<DAEAHJMMAED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x84580D0", Offset = "0x84566D0", VA = "0x1884580D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x8458610", Offset = "0x8456C10", VA = "0x188458610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct IMCLOJAIIGA<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private sealed class DHDPFPJOFKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public DAEAHJMMAED roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public DHDPFPJOFKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x844CC70", Offset = "0x844B270", VA = "0x18844CC70")]
		internal DAEAHJMMAED GHBFFMNKMHE(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct FNMAIACOEEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder<OBOJAHIICMM.ELCFJMNDKFL<DAEAHJMMAED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public DAEAHJMMAED roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public GEHMKHHFLAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private AGHPMNKMEMJ <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private TaskAwaiter<OBOJAHIICMM.ELCFJMNDKFL<DAEAHJMMAED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x8452320", Offset = "0x8450920", VA = "0x188452320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x8452930", Offset = "0x8450F30", VA = "0x188452930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct BPAHHIIFBNB<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public GEHMKHHFLAO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6413540", Offset = "0x6411B40", VA = "0x186413540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x44F9550", Offset = "0x44F7B50", VA = "0x1844F9550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct BFIMGJPDFEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public GEHMKHHFLAO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x844A4D0", Offset = "0x8448AD0", VA = "0x18844A4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x844A7B0", Offset = "0x8448DB0", VA = "0x18844A7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class IHDJFAIBPKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public IHDJFAIBPKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x8456690", Offset = "0x8454C90", VA = "0x188456690")]
		internal object AFMLJNCBDCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x84566F0", Offset = "0x8454CF0", VA = "0x1884566F0")]
		internal bool GGAGAEOMHIP(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class NCIBCLGAKHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public NCIBCLGAKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x845B460", Offset = "0x8459A60", VA = "0x18845B460")]
		internal object FOLGOKHKCBP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class LDEGFIGNGNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public LDEGFIGNGNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x8458980", Offset = "0x8456F80", VA = "0x188458980")]
		internal object LDDEAENEAFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class AEIBDHJAJDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public AEIBDHJAJDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x8448DF0", Offset = "0x84473F0", VA = "0x188448DF0")]
		internal object CMJFMEAGFLI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class LABODMFDCOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public GEHMKHHFLAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public LABODMFDCOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x8458680", Offset = "0x8456C80", VA = "0x188458680")]
		internal object PEEMBAAGIPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private static readonly Guid DFNNHGGDCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public readonly PPPBMGNNDNF AAIHBKEDJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private readonly OBOJAHIICMM HAHJDNHBDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private readonly NOCKFOJODFM NODDAHEDIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	private readonly CIKJMMPNKIM CAKMPKKLEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	private bool LKKCCMMEAMB;

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x8454CF0", Offset = "0x84532F0", VA = "0x188454CF0")]
	public GEHMKHHFLAO(PPPBMGNNDNF AOHGJNGCBBI, OBOJAHIICMM HAHJDNHBDND, NOCKFOJODFM NODDAHEDIAD, CIKJMMPNKIM CAKMPKKLEEB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x8453F70", Offset = "0x8452570", VA = "0x188453F70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x8454820", Offset = "0x8452E20", VA = "0x188454820")]
	public void IHEJEEPNJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x8454A50", Offset = "0x8453050", VA = "0x188454A50")]
	public void KLGEEIPFGIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x8453EB0", Offset = "0x84524B0", VA = "0x188453EB0")]
	public void BKMNPGHPHFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x8453C20", Offset = "0x8452220", VA = "0x188453C20")]
	[AsyncStateMachine(typeof(KIEMHJIHHKH))]
	internal Task<DAEAHJMMAED> APOJKNDKELP(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, DAEAHJMMAED CAGMDMPFBND, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x38797F0", Offset = "0x3877DF0", VA = "0x1838797F0")]
	private static byte[] BPOAHIPMOGN<T>(T NAAMEAFIHJI) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x3879E30", Offset = "0x3878430", VA = "0x183879E30")]
	private static T NPBMBNAKEBM<T>(MessageParser<T> PLJDBFGEJFF, byte[] NAAMEAFIHJI, T DPCDDDOIHML) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x8454300", Offset = "0x8452900", VA = "0x188454300")]
	[AsyncStateMachine(typeof(FNMAIACOEEC))]
	private Task<OBOJAHIICMM.ELCFJMNDKFL<DAEAHJMMAED>> GJJAPLJOLFN(DAEAHJMMAED CAGMDMPFBND, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x38798F0", Offset = "0x3877EF0", VA = "0x1838798F0")]
	[AsyncStateMachine(typeof(BPAHHIIFBNB<>))]
	internal Task<T> HFJPOKDMCME<T>(CancellationToken EBOFCHGLLPK, Func<CancellationToken, Task<T>> NPOFLNLGLKI, int EOKABIBEHKG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x84544C0", Offset = "0x8452AC0", VA = "0x1884544C0")]
	[AsyncStateMachine(typeof(BFIMGJPDFEB))]
	internal Task HFJPOKDMCME(CancellationToken EBOFCHGLLPK, Func<CancellationToken, Task> NPOFLNLGLKI, int EOKABIBEHKG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x8454750", Offset = "0x8452D50", VA = "0x188454750")]
	public DMPOKLHCOJD IBDBOFPDPIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x8454440", Offset = "0x8452A40", VA = "0x188454440")]
	public EAJJHPPIGJC HCAADBKIOPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x8454090", Offset = "0x8452690", VA = "0x188454090")]
	public MOJFFBJNPFJ FNLMJPJPCLB([Optional] JBBHIJHGEPM? PAJIGEJCNAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x84545F0", Offset = "0x8452BF0", VA = "0x1884545F0")]
	public void HMGLEFDJKIA(Func<Guid, bool> GLCENBLKGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x8453F80", Offset = "0x8452580", VA = "0x188453F80")]
	public void EOIHFEIBEKA(Func<Guid, bool> HEEKELAELBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x8454B10", Offset = "0x8453110", VA = "0x188454B10")]
	public Guid LFIICAHNOAB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x8454940", Offset = "0x8452F40", VA = "0x188454940")]
	public void KJELAEGPJCA(Guid IGEEKENFEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x8453D80", Offset = "0x8452380", VA = "0x188453D80")]
	public void BHLMHFKHKCC(DAEAHJMMAED JFOANNPHGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x8453B10", Offset = "0x8452110", VA = "0x188453B10")]
	public void AHIMDJPCPBN(string EFDFGKJJCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x3879800", Offset = "0x3877E00", VA = "0x183879800")]
	private T CJCJKPNPKEO<T>(T OHLIHBDBKCE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x84547D0", Offset = "0x8452DD0", VA = "0x1884547D0")]
	public void IDAIBAFFEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x3879B90", Offset = "0x3878190", VA = "0x183879B90")]
	[CompilerGenerated]
	internal static string JHCAEBPIFPL<T>(byte[] ACDPPDBEDDM, int HOMPFMAAAKM, IMCLOJAIIGA<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal sealed class FAEENFFPBBD : PPPBMGNNDNF
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class DFHLGJIKNMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public DFHLGJIKNMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x844CC00", Offset = "0x844B200", VA = "0x18844CC00")]
		internal object GOAGLAFDPGD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct GNOLNGHOJKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public FAEENFFPBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private IKJOECKPNBM <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private EAJJHPPIGJC <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x84552A0", Offset = "0x84538A0", VA = "0x1884552A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x8455BF0", Offset = "0x84541F0", VA = "0x188455BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct MJHMMIOBBFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public FAEENFFPBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private TaskAwaiter<GOMNLGPHFID> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x845ACD0", Offset = "0x84592D0", VA = "0x18845ACD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x845B400", Offset = "0x8459A00", VA = "0x18845B400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct GEOBHCBEIGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public FAEENFFPBBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private TaskAwaiter<NEDLDDMDCHB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x8454F20", Offset = "0x8453520", VA = "0x188454F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x8455230", Offset = "0x8453830", VA = "0x188455230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class ADKJKAOGDMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public IKJOECKPNBM presence;

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public ADKJKAOGDMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x8448CB0", Offset = "0x84472B0", VA = "0x188448CB0")]
		internal object MPNBCHNOPBP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	private static readonly JBBHIJHGEPM HDNPMENDLCN;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private static readonly JBBHIJHGEPM GHMGAICLGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private readonly AENKMJAJKCL GJIIIBDFFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly PAIKJEGABFG FKPLNDNGIOB;

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x8451220", Offset = "0x844F820", VA = "0x188451220")]
	public FAEENFFPBBD(AENKMJAJKCL GJIIIBDFFHL, PAIKJEGABFG FKPLNDNGIOB, Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, HPBALDPEPLO GGBIELGEIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x8450D30", Offset = "0x844F330", VA = "0x188450D30", Slot = "7")]
	[AsyncStateMachine(typeof(GNOLNGHOJKK))]
	protected override Task BJJJFDGGDPF(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x8450C30", Offset = "0x844F230", VA = "0x188450C30")]
	[AsyncStateMachine(typeof(MJHMMIOBBFD))]
	private Task AHFMHDDHHEN(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x8450E70", Offset = "0x844F470", VA = "0x188450E70")]
	[AsyncStateMachine(typeof(GEOBHCBEIGN))]
	private Task<int> LJENNOMNKDH(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x8450F80", Offset = "0x844F580", VA = "0x188450F80")]
	private IKJOECKPNBM OHKNFMLJLIE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal class OIFFOMNPKAJ : PPPBMGNNDNF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct OPPNNCNFHIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public OIFFOMNPKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private TaskAwaiter<GHABJHKCBDN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x84604E0", Offset = "0x845EAE0", VA = "0x1884604E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x8460E90", Offset = "0x845F490", VA = "0x188460E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private readonly int MMFPNLNMPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private readonly OPPGGNKKPPF EBKHBJGGNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public readonly long BJFFDFGEMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public readonly long IGDPLOIKGIA;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public GHABJHKCBDN EOELPLOEPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x9F3100", Offset = "0x9F1700", VA = "0x1809F3100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x9F2FF0", Offset = "0x9F15F0", VA = "0x1809F2FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x845F3A0", Offset = "0x845D9A0", VA = "0x18845F3A0")]
	public OIFFOMNPKAJ(Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, HPBALDPEPLO GGBIELGEIEA, int MMFPNLNMPFP, OPPGGNKKPPF EBKHBJGGNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x845F280", Offset = "0x845D880", VA = "0x18845F280", Slot = "7")]
	[AsyncStateMachine(typeof(OPPNNCNFHIO))]
	protected override Task BJJJFDGGDPF(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal abstract class MCFEFOAOGIC : PPPBMGNNDNF
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class OPCNPOACDOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public MCFEFOAOGIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public CEFMCOIEMHB playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public OPCNPOACDOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x8460410", Offset = "0x845EA10", VA = "0x188460410")]
		internal Task HEBMHBPLNFB(LDCGKGNFMMI<string>.CKHHEKIPJDF postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x8460450", Offset = "0x845EA50", VA = "0x188460450")]
		internal object IJNMDPCHNKJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private struct DMMAGNLBODO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public MCFEFOAOGIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private OPCNPOACDOK <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x844D480", Offset = "0x844BA80", VA = "0x18844D480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x844DC50", Offset = "0x844C250", VA = "0x18844DC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct DLLDKHLIKAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public CEFMCOIEMHB playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public MCFEFOAOGIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x844CE70", Offset = "0x844B470", VA = "0x18844CE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x844D420", Offset = "0x844BA20", VA = "0x18844D420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x8459FB0", Offset = "0x84585B0", VA = "0x188459FB0")]
	public MCFEFOAOGIC(Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, HPBALDPEPLO GGBIELGEIEA, string ANIMIEIPAGE, KLMNOKPMPDB MEOBMEDANDK, bool EPJEALHDNJK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x8459E70", Offset = "0x8458470", VA = "0x188459E70", Slot = "7")]
	[AsyncStateMachine(typeof(DMMAGNLBODO))]
	protected override Task BJJJFDGGDPF(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task OEAGPGDLPOA(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x8459D30", Offset = "0x8458330", VA = "0x188459D30")]
	[AsyncStateMachine(typeof(DLLDKHLIKAC))]
	private Task BICOMEEFCDB(IDisposable HMBGEOCFKLF, CEFMCOIEMHB EPBBOAEAEML, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal class OGBKKNMLPDM : PPPBMGNNDNF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct BNINGBHCHOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public OGBKKNMLPDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public GEHMKHHFLAO operationContext;

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
		private TaskAwaiter<HFEJJAMCGEP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x844B9A0", Offset = "0x8449FA0", VA = "0x18844B9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x844BF30", Offset = "0x844A530", VA = "0x18844BF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private readonly KNEDGBILGPM EDHLLDFNCFM;

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x845F1E0", Offset = "0x845D7E0", VA = "0x18845F1E0")]
	public OGBKKNMLPDM(Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, HPBALDPEPLO GGBIELGEIEA, KNEDGBILGPM EDHLLDFNCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x845F100", Offset = "0x845D700", VA = "0x18845F100", Slot = "6")]
	protected override string PPFILDFJAOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x845EFE0", Offset = "0x845D5E0", VA = "0x18845EFE0", Slot = "7")]
	[AsyncStateMachine(typeof(BNINGBHCHOG))]
	protected override Task BJJJFDGGDPF(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal abstract class PPPBMGNNDNF : AEAIFIOMDPM
{
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public delegate Task HNANNOLPNEO(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private sealed class DCLEKALIING
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public PPPBMGNNDNF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public DCLEKALIING()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x844CAD0", Offset = "0x844B0D0", VA = "0x18844CAD0")]
		internal Task DFBECEDJHLP(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class JPLBFDMKHNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public DCLEKALIING CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public JPLBFDMKHNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x8457840", Offset = "0x8455E40", VA = "0x188457840")]
		internal object APPLAPKLJIO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct NLECPHEEENH : IAsyncStateMachine
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
		public PPPBMGNNDNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public Func<PPPBMGNNDNF, LDCGKGNFMMI<string>.CKHHEKIPJDF, GEHMKHHFLAO> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private DCLEKALIING <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private GEHMKHHFLAO <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private TaskAwaiter<DAEAHJMMAED> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x845BA30", Offset = "0x845A030", VA = "0x18845BA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x845CBF0", Offset = "0x845B1F0", VA = "0x18845CBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct BCDAAGJNHAE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x84499D0", Offset = "0x8447FD0", VA = "0x1884499D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x844A470", Offset = "0x8448A70", VA = "0x18844A470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct ENOGJKAHPAM : IAsyncStateMachine
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
		public PPPBMGNNDNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x844FDB0", Offset = "0x844E3B0", VA = "0x18844FDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x8450110", Offset = "0x844E710", VA = "0x188450110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public readonly Guid EHBJDHPDJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public readonly ByteString BOLHLLCEDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public readonly HPBALDPEPLO PBHKFAEONMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	protected readonly string DICMHFPKLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private readonly IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private readonly bool EPJEALHDNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private readonly Queue<HNANNOLPNEO> EFDFIAKKDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private readonly BAKGMMHDEOL GJIOAEOHEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private readonly KLMNOKPMPDB MEOBMEDANDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private bool KOEPONLCDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public IHHBKLENLMK BEOLMPIJNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public IHHBKLENLMK KKPAKKJANIH;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public IPAGNGHLCCF KFEELBCAGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public JHHKOFMOFFM PLBPABECHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x84638F0", Offset = "0x8461EF0", VA = "0x1884638F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public IPGGFFCDLNK BKPNOIHPIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x8463E30", Offset = "0x8462430", VA = "0x188463E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public IJPJAKACFOB BJABPNAMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x8463B30", Offset = "0x8462130", VA = "0x188463B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event BFAMDEMJIGI GIDLGFMCOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x8463940", Offset = "0x8461F40", VA = "0x188463940", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x84638D0", Offset = "0x8461ED0", VA = "0x1884638D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x8464300", Offset = "0x8462900", VA = "0x188464300")]
	protected PPPBMGNNDNF(Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, HPBALDPEPLO GGBIELGEIEA, string ANIMIEIPAGE, KLMNOKPMPDB MEOBMEDANDK, bool EPJEALHDNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x84642C0", Offset = "0x84628C0", VA = "0x1884642C0", Slot = "6")]
	protected virtual string PPFILDFJAOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x8463DD0", Offset = "0x84623D0", VA = "0x188463DD0")]
	public void KABHFJHKJCH(HNANNOLPNEO KACLNFIKDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x8464130", Offset = "0x8462730", VA = "0x188464130")]
	protected void OCPPHDLNAIJ(float NOOBIPOJNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x84639E0", Offset = "0x8461FE0", VA = "0x1884639E0")]
	[AsyncStateMachine(typeof(NLECPHEEENH))]
	public Task GDMALPFODEM(CancellationToken CBJPDIFOEKF, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, [Optional] Func<PPPBMGNNDNF, LDCGKGNFMMI<string>.CKHHEKIPJDF, GEHMKHHFLAO> AIFOBAKGPAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x8464000", Offset = "0x8462600", VA = "0x188464000")]
	[AsyncStateMachine(typeof(BCDAAGJNHAE))]
	private static Task NEAGPOPNDOI(Func<CancellationToken, Task> CJHGKDINONF, Func<CancellationToken, Task> NPAEKKBJFGC, CancellationToken EBOFCHGLLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x8463E80", Offset = "0x8462480", VA = "0x188463E80")]
	private void MOMNLNCHKFK(bool AMLDIAHNCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x8463BB0", Offset = "0x84621B0", VA = "0x188463BB0")]
	private void JLNNGCJEOPC(GEHMKHHFLAO AJGFGCKEHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task BJJJFDGGDPF(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x84637B0", Offset = "0x8461DB0", VA = "0x1884637B0")]
	[AsyncStateMachine(typeof(ENOGJKAHPAM))]
	private Task AGINECDCMJF(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x8464240", Offset = "0x8462840", VA = "0x188464240")]
	public DAEAHJMMAED PAMIJHPAECD(AGHPMNKMEMJ LEDHJMAHPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x8464150", Offset = "0x8462750", VA = "0x188464150")]
	[CompilerGenerated]
	private Task OMFHECKLPIP(CancellationToken LEMBKBGMCDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x8463960", Offset = "0x8461F60", VA = "0x188463960")]
	[CompilerGenerated]
	private object EDDOLIAOPNK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
internal sealed class HOJPLEHKJGH : MCFEFOAOGIC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct LMPHBNAEAFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public HOJPLEHKJGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private OGDCDNJBIFG <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private EAJJHPPIGJC <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x8458FF0", Offset = "0x84575F0", VA = "0x188458FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x8459750", Offset = "0x8457D50", VA = "0x188459750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	private readonly AENKMJAJKCL NMEIJLCHIKN;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x8456030", Offset = "0x8454630", VA = "0x188456030")]
	public HOJPLEHKJGH(Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, AENKMJAJKCL NMEIJLCHIKN, HPBALDPEPLO GGBIELGEIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x8455EE0", Offset = "0x84544E0", VA = "0x188455EE0", Slot = "8")]
	[AsyncStateMachine(typeof(LMPHBNAEAFI))]
	protected override Task OEAGPGDLPOA(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal class FGADKJHOMIE : PPPBMGNNDNF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct MJEPIHAMPHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public FGADKJHOMIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private TaskAwaiter<HFEJJAMCGEP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x845A8C0", Offset = "0x8458EC0", VA = "0x18845A8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x845AC70", Offset = "0x8459270", VA = "0x18845AC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private readonly string NMFNBOACOOE;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x8452270", Offset = "0x8450870", VA = "0x188452270")]
	public FGADKJHOMIE(Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, HPBALDPEPLO GGBIELGEIEA, string NMFNBOACOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x8452160", Offset = "0x8450760", VA = "0x188452160", Slot = "7")]
	[AsyncStateMachine(typeof(MJEPIHAMPHD))]
	protected override Task BJJJFDGGDPF(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal class NKAFDBHGPAC : MCFEFOAOGIC
{
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class KHBOENMMCLP
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
			public AsyncTaskMethodBuilder<DAEAHJMMAED> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			public KHBOENMMCLP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			private TaskAwaiter<HFEJJAMCGEP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			private TaskAwaiter<DAEAHJMMAED> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0x84653B0", Offset = "0x84639B0", VA = "0x1884653B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0x84658A0", Offset = "0x8463EA0", VA = "0x1884658A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public NKAFDBHGPAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public MOJFFBJNPFJ serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public MJJOEIPLFFL roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public DMPOKLHCOJD uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public GHIBGJOBNGE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public KHBOENMMCLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x8457F10", Offset = "0x8456510", VA = "0x188457F10")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<DAEAHJMMAED> OMGDPGLKEMH(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct OJHEPHEAGBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public NKAFDBHGPAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private KHBOENMMCLP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private OGDCDNJBIFG <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private EAJJHPPIGJC <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private DAEAHJMMAED <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x845F4D0", Offset = "0x845DAD0", VA = "0x18845F4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x84603B0", Offset = "0x845E9B0", VA = "0x1884603B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private static readonly JBBHIJHGEPM HDNPMENDLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private readonly int BGINAMOOLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	[CanBeNull]
	private readonly MDNOEFMCADI LMHJJMIBAMA;

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x845B980", Offset = "0x8459F80", VA = "0x18845B980")]
	public NKAFDBHGPAC(Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, int BGINAMOOLIJ, MDNOEFMCADI LMHJJMIBAMA, HPBALDPEPLO GGBIELGEIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x845B5C0", Offset = "0x8459BC0", VA = "0x18845B5C0", Slot = "8")]
	[AsyncStateMachine(typeof(OJHEPHEAGBF))]
	protected override Task OEAGPGDLPOA(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x845B4C0", Offset = "0x8459AC0", VA = "0x18845B4C0")]
	private void KEHBCMLDANA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x845B700", Offset = "0x8459D00", VA = "0x18845B700")]
	private void PICDIOCPHMA(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, OGDCDNJBIFG JJJFPCEDAAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal class MANPACGGAHA : PPPBMGNNDNF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct BILJFENNEMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public MANPACGGAHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private OGDCDNJBIFG <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private GKHPBLLBAIL<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private TaskAwaiter<GHABJHKCBDN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x844A810", Offset = "0x8448E10", VA = "0x18844A810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x844B940", Offset = "0x8449F40", VA = "0x18844B940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private readonly int BGINAMOOLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	private readonly MDNOEFMCADI LMHJJMIBAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private Func<HFEJJAMCGEP, HFEJJAMCGEP> IEJMBGBDAGB;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x8459C70", Offset = "0x8458270", VA = "0x188459C70")]
	public MANPACGGAHA(Guid DHFBDLBBCGN, IPAGNGHLCCF BFCIGLOEMAP, int BGINAMOOLIJ, MDNOEFMCADI LMHJJMIBAMA, Func<HFEJJAMCGEP, HFEJJAMCGEP> IEJMBGBDAGB, HPBALDPEPLO GGBIELGEIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x8459B30", Offset = "0x8458130", VA = "0x188459B30", Slot = "7")]
	[AsyncStateMachine(typeof(BILJFENNEMI))]
	protected override Task BJJJFDGGDPF(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal abstract class CGFGCNFFKKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public readonly PPPBMGNNDNF AAIHBKEDJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public readonly GEHMKHHFLAO KNNFCCCKBOI;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public JHHKOFMOFFM PLBPABECHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x844C910", Offset = "0x844AF10", VA = "0x18844C910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public IJPJAKACFOB BJABPNAMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x844C960", Offset = "0x844AF60", VA = "0x18844C960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x844C9F0", Offset = "0x844AFF0", VA = "0x18844C9F0")]
	protected CGFGCNFFKKJ(GEHMKHHFLAO AJGFGCKEHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x844C800", Offset = "0x844AE00", VA = "0x18844C800")]
	protected void AHIMDJPCPBN(string EFDFGKJJCLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal struct LMMOHLNEFMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public Dictionary<Guid, List<JCIEFCALJCE>> NDALPMLLJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public Dictionary<Guid, List<JCIEFCALJCE>> CJBFDILCBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public Dictionary<Guid, List<JCIEFCALJCE>> DOCIPEFPLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public List<Guid> EHFIDIHNNAG;

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x84589F0", Offset = "0x8456FF0", VA = "0x1884589F0")]
	public static LMMOHLNEFMM PHDCGNDDLGA(JHHKOFMOFFM DHJEDIPMPLO, IHHBKLENLMK NHCKJIIHJGE, JOEFAEBJKIB GIJBGILJKNL)
	{
		return default(LMMOHLNEFMM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct DIKIIKEINBD
{
	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0")]
	public static DIKIIKEINBD FLLMCNLHKNL()
	{
		return default(DIKIIKEINBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct EAEOJFOCIBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public readonly GOMNLGPHFID KNDDJPGLJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public readonly IINCMBDAHBF KEKMAFALOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public readonly Guid? DMDDOFCAJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public readonly IReadOnlyCollection<JJDFEBIHCFN> FPOFAECKECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public readonly IReadOnlyCollection<JJDFEBIHCFN> LLJNIILIBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public readonly NGHKAOKDFBL OFMJDNINMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public readonly NGHKAOKDFBL EKHBMLBAPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public readonly DIKDBMHBMCM AHIENHBHJOM;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool GADOFBOHLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x844DCB0", Offset = "0x844C2B0", VA = "0x18844DCB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x844DD40", Offset = "0x844C340", VA = "0x18844DD40")]
	public EAEOJFOCIBE(GOMNLGPHFID KNDDJPGLJMO, IINCMBDAHBF KEKMAFALOGL, Guid? DMDDOFCAJJF, IReadOnlyList<JJDFEBIHCFN> FPOFAECKECE, IReadOnlyCollection<JJDFEBIHCFN> LLJNIILIBCB, NGHKAOKDFBL OFMJDNINMGK, NGHKAOKDFBL EKHBMLBAPGI, DIKDBMHBMCM AHIENHBHJOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct HPHPJCODCED : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private readonly GEHMKHHFLAO AJGFGCKEHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private readonly Guid IGEEKENFEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private bool AMLDIAHNCEJ;

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x84563C0", Offset = "0x84549C0", VA = "0x1884563C0")]
	public static HPHPJCODCED LFIICAHNOAB(GEHMKHHFLAO AJGFGCKEHBB)
	{
		return default(HPHPJCODCED);
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x11D58C0", Offset = "0x11D3EC0", VA = "0x1811D58C0")]
	public void CBBJELLKGAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x84560E0", Offset = "0x84546E0", VA = "0x1884560E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x84563F0", Offset = "0x84549F0", VA = "0x1884563F0")]
	private HPHPJCODCED(GEHMKHHFLAO AJGFGCKEHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x8456190", Offset = "0x8454790", VA = "0x188456190")]
	private void KJELAEGPJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x84560F0", Offset = "0x84546F0", VA = "0x1884560F0")]
	private Func<Guid, bool> GOEMDPOPHHK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal class EAJJHPPIGJC : CGFGCNFFKKJ, AEAIFIOMDPM
{
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	public delegate Task<IHHBKLENLMK> LADFBABIGGF(JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KHAHHALEIML, BAKGMMHDEOL JEAOKNGGMFI, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct AJMFDDJLHBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public AENKMJAJKCL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private HPHPJCODCED <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x8448E60", Offset = "0x8447460", VA = "0x188448E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x8449730", Offset = "0x8447D30", VA = "0x188449730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct PLKGJDBJDPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public AsyncTaskMethodBuilder<DAEAHJMMAED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public AENKMJAJKCL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x8463310", Offset = "0x8461910", VA = "0x188463310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x8463740", Offset = "0x8461D40", VA = "0x188463740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct OADLMOOPCNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public AENKMJAJKCL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x845D1C0", Offset = "0x845B7C0", VA = "0x18845D1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x845D800", Offset = "0x845BE00", VA = "0x18845D800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class NNILHGGJCOL
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
			public AsyncTaskMethodBuilder<EAEOJFOCIBE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			public NNILHGGJCOL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			private EAEOJFOCIBE <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004FC")]
			private TaskAwaiter<IHHBKLENLMK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			private TaskAwaiter<EAEOJFOCIBE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x8464460", Offset = "0x8462A60", VA = "0x188464460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x8464C50", Offset = "0x8463250", VA = "0x188464C50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<JOEFAEBJKIB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			public NNILHGGJCOL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			private JOEFAEBJKIB <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000503")]
			private TaskAwaiter<IHHBKLENLMK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000504")]
			private TaskAwaiter<JOEFAEBJKIB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x8464CC0", Offset = "0x84632C0", VA = "0x188464CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x8465340", Offset = "0x8463940", VA = "0x188465340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public AENKMJAJKCL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public BAKGMMHDEOL preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public BAKGMMHDEOL downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public EAEOJFOCIBE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public BAKGMMHDEOL postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public JOEFAEBJKIB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public LKLEKOGDEBE.OBNDLGOKJBI <>9__5;

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public NNILHGGJCOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x845D070", Offset = "0x845B670", VA = "0x18845D070")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<EAEOJFOCIBE> NBEGPGBPOJI(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x845CDF0", Offset = "0x845B3F0", VA = "0x18845CDF0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<JOEFAEBJKIB> HIHJCPBKHEK(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x845CDB0", Offset = "0x845B3B0", VA = "0x18845CDB0")]
		internal void FJJNEOIAPMB(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x845CC50", Offset = "0x845B250", VA = "0x18845CC50")]
		internal Task FJINOMMAANG(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x845CF10", Offset = "0x845B510", VA = "0x18845CF10")]
		internal Task LCFCOBKOMDL(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct FBGCJDDOEEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public AENKMJAJKCL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private NNILHGGJCOL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private TaskAwaiter<EAEOJFOCIBE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private TaskAwaiter<JOEFAEBJKIB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x84513B0", Offset = "0x844F9B0", VA = "0x1884513B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x8452100", Offset = "0x8450700", VA = "0x188452100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct FOFLNHJANLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public JOEFAEBJKIB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public BAKGMMHDEOL postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private TaskAwaiter<IHHBKLENLMK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private AMIGCLEJKKN <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x84529A0", Offset = "0x8450FA0", VA = "0x1884529A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x8453AB0", Offset = "0x84520B0", VA = "0x188453AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct LNDGGJJELDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x8476BE0", Offset = "0x84751E0", VA = "0x188476BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x84773C0", Offset = "0x84759C0", VA = "0x1884773C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct HDDJPCCIINI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public BAKGMMHDEOL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private TaskAwaiter<IHHBKLENLMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x84702C0", Offset = "0x846E8C0", VA = "0x1884702C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x8470B00", Offset = "0x846F100", VA = "0x188470B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct FCDMPBMIPNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public BAKGMMHDEOL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private TaskAwaiter<IHHBKLENLMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x846CC90", Offset = "0x846B290", VA = "0x18846CC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x846DC50", Offset = "0x846C250", VA = "0x18846DC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct EACNADHGBPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public BAKGMMHDEOL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public AMIGCLEJKKN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private TaskAwaiter<IHHBKLENLMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x8468FD0", Offset = "0x84675D0", VA = "0x188468FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x846A0E0", Offset = "0x84686E0", VA = "0x18846A0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct DBBHEPNDDLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public IHHBKLENLMK operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public BAKGMMHDEOL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public JOEFAEBJKIB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private TaskAwaiter<IHHBKLENLMK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x8468D10", Offset = "0x8467310", VA = "0x188468D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x8468F60", Offset = "0x8467560", VA = "0x188468F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class BMCLEFKENEL
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
			public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			public BMCLEFKENEL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			private JHEDBCMAENC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			private TaskAwaiter<IHHBKLENLMK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x847DF10", Offset = "0x847C510", VA = "0x18847DF10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x847E530", Offset = "0x847CB30", VA = "0x18847E530", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public BAKGMMHDEOL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public LADFBABIGGF masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public AMIGCLEJKKN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public IHHBKLENLMK originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BMCLEFKENEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x8467BF0", Offset = "0x84661F0", VA = "0x188467BF0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<IHHBKLENLMK> KHBBDMNNJPN(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct FMFGENCMMAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public BAKGMMHDEOL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public LADFBABIGGF masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public AMIGCLEJKKN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private TaskAwaiter<IHHBKLENLMK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x846E3D0", Offset = "0x846C9D0", VA = "0x18846E3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x846E8F0", Offset = "0x846CEF0", VA = "0x18846E8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct EPCGHNPEBEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public BAKGMMHDEOL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private IHHBKLENLMK <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private IEnumerator<IHHBKLENLMK> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private TaskAwaiter<IHHBKLENLMK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x846C6E0", Offset = "0x846ACE0", VA = "0x18846C6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x846CC30", Offset = "0x846B230", VA = "0x18846CC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct JFDPCBBJFBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x8473730", Offset = "0x8471D30", VA = "0x188473730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x8473A20", Offset = "0x8472020", VA = "0x188473A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct MFNHHBCECOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x8477DD0", Offset = "0x84763D0", VA = "0x188477DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x8477FF0", Offset = "0x84765F0", VA = "0x188477FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class LKGFJOAFAMP
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
			public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			public LKGFJOAFAMP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public JOEFAEBJKIB data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			public BAKGMMHDEOL progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			private TaskAwaiter<IHHBKLENLMK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			private TaskAwaiter<PNMPDOEFGAA> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x847E5A0", Offset = "0x847CBA0", VA = "0x18847E5A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x847F060", Offset = "0x847D660", VA = "0x18847F060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public JAJMJMCBDCI mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public LKGFJOAFAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x8476590", Offset = "0x8474B90", VA = "0x188476590")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<IHHBKLENLMK> AACBKKIDMAF(JOEFAEBJKIB data, AMIGCLEJKKN _, BAKGMMHDEOL progressTracker, LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct GAPCPJDKIHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public JOEFAEBJKIB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public BAKGMMHDEOL postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private LKGFJOAFAMP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private AMIGCLEJKKN <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private TaskAwaiter<IHHBKLENLMK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x846E960", Offset = "0x846CF60", VA = "0x18846E960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x846F830", Offset = "0x846DE30", VA = "0x18846F830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct PAEMBNLJEGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x847A950", Offset = "0x8478F50", VA = "0x18847A950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x847AD50", Offset = "0x8479350", VA = "0x18847AD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct LIACLKHIOOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public EAJJHPPIGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public BAKGMMHDEOL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private TaskAwaiter<IHHBKLENLMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x8475F00", Offset = "0x8474500", VA = "0x188475F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x8476520", Offset = "0x8474B20", VA = "0x188476520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private readonly BDMLCHKFOFH LAMPIOPGDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private readonly BDMLCHKFOFH OPCIPKOEPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private readonly PLHOCFLCCME AANEBFKDCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private readonly PHFJIAMDFFA LDGKLCBAEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private readonly EKILGEACLCB HJALPDOCMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private ProfilerCounterValue<int> KFAPHEFEEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private readonly HKMALGKDFBG DHMAABOAJAK;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private IPAGNGHLCCF KFEELBCAGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x844DDF0", Offset = "0x844C3F0", VA = "0x18844DDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event BFAMDEMJIGI GIDLGFMCOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x844E540", Offset = "0x844CB40", VA = "0x18844E540", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x844E3D0", Offset = "0x844C9D0", VA = "0x18844E3D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x844F9B0", Offset = "0x844DFB0", VA = "0x18844F9B0")]
	public EAJJHPPIGJC(GEHMKHHFLAO AJGFGCKEHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x844E560", Offset = "0x844CB60", VA = "0x18844E560")]
	[AsyncStateMachine(typeof(AJMFDDJLHBG))]
	public Task EDOEPKBAEGM(AENKMJAJKCL HOOJNAMGGBC, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x844F630", Offset = "0x844DC30", VA = "0x18844F630")]
	[AsyncStateMachine(typeof(PLKGJDBJDPM))]
	private Task<DAEAHJMMAED> OODPNIKAJOF(AENKMJAJKCL HOOJNAMGGBC, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x844F4F0", Offset = "0x844DAF0", VA = "0x18844F4F0")]
	[AsyncStateMachine(typeof(OADLMOOPCNN))]
	private Task NBGHCNDHNJK(AENKMJAJKCL HOOJNAMGGBC, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x844F320", Offset = "0x844D920", VA = "0x18844F320")]
	[AsyncStateMachine(typeof(FBGCJDDOEEO))]
	private Task LEDNAHMOELM(AENKMJAJKCL HOOJNAMGGBC, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken JJBBPEILOIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x844EA70", Offset = "0x844D070", VA = "0x18844EA70")]
	[AsyncStateMachine(typeof(FOFLNHJANLO))]
	private Task FDDGJPOAEBH(JOEFAEBJKIB NJLJEKGKBFA, BAKGMMHDEOL KNADNIOJNOE, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken HNIFIEMGDPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x844F7F0", Offset = "0x844DDF0", VA = "0x18844F7F0")]
	[AsyncStateMachine(typeof(LNDGGJJELDG))]
	private Task PLPGBABOJJN(LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x844E3F0", Offset = "0x844C9F0", VA = "0x18844E3F0")]
	[AsyncStateMachine(typeof(HDDJPCCIINI))]
	private Task EACCBDOIFEB(JOEFAEBJKIB APDBNIMCPID, BAKGMMHDEOL JEAOKNGGMFI, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x844F0A0", Offset = "0x844D6A0", VA = "0x18844F0A0")]
	[AsyncStateMachine(typeof(FCDMPBMIPNM))]
	private Task<IHHBKLENLMK> KDDHIMBFADG(JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, BAKGMMHDEOL JEAOKNGGMFI, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x844E230", Offset = "0x844C830", VA = "0x18844E230")]
	[AsyncStateMachine(typeof(EACNADHGBPN))]
	private Task<IHHBKLENLMK> BLMKPKHNPGF(JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, BAKGMMHDEOL JEAOKNGGMFI, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x844DE20", Offset = "0x844C420", VA = "0x18844DE20")]
	[AsyncStateMachine(typeof(DBBHEPNDDLK))]
	private Task<IHHBKLENLMK> AGFKJMPBAAF(IHHBKLENLMK NHCKJIIHJGE, JOEFAEBJKIB GIJBGILJKNL, BAKGMMHDEOL JEAOKNGGMFI, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF, bool CIPDMCKNNIA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x844EDE0", Offset = "0x844D3E0", VA = "0x18844EDE0")]
	private bool HNHFMEMCNCO(JOEFAEBJKIB NJLJEKGKBFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x844EC10", Offset = "0x844D210", VA = "0x18844EC10")]
	[AsyncStateMachine(typeof(FMFGENCMMAG))]
	protected Task<IHHBKLENLMK> GKMPFFDGLHK(JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, BAKGMMHDEOL JEAOKNGGMFI, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF, LADFBABIGGF IHJJMMLHCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x844E0E0", Offset = "0x844C6E0", VA = "0x18844E0E0")]
	[AsyncStateMachine(typeof(EPCGHNPEBEF))]
	private Task BKLAFKMFKNJ(JOEFAEBJKIB APDBNIMCPID, BAKGMMHDEOL JEAOKNGGMFI, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x844F460", Offset = "0x844DA60", VA = "0x18844F460")]
	private void LIPBDHJJMLL(IHHBKLENLMK PAJPHIMOMIF, BAKGMMHDEOL JEAOKNGGMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x844EEF0", Offset = "0x844D4F0", VA = "0x18844EEF0")]
	private void IKPINLMAIIK(IHHBKLENLMK OMFJEBBABLE, [Out] IHHBKLENLMK IFINDNCODHD, [Out] IHHBKLENLMK ICHPHJLAMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x844F790", Offset = "0x844DD90", VA = "0x18844F790")]
	private Task<EAEOJFOCIBE> PJEJKBJPHEJ(AENKMJAJKCL HOOJNAMGGBC, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x844EDA0", Offset = "0x844D3A0", VA = "0x18844EDA0")]
	private Task<JOEFAEBJKIB> GLLADIDKIML(EAEOJFOCIBE APDBNIMCPID, LKLEKOGDEBE.OBNDLGOKJBI BHELEDFDDCN, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x844EF50", Offset = "0x844D550", VA = "0x18844EF50")]
	[AsyncStateMachine(typeof(JFDPCBBJFBM))]
	private Task INLCPPFDMDC(JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF, bool GFFKPEPGKHC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x844E6B0", Offset = "0x844CCB0", VA = "0x18844E6B0")]
	[AsyncStateMachine(typeof(MFNHHBCECOP))]
	private Task EGDJEHIKBFE(JOEFAEBJKIB APDBNIMCPID, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x844F4C0", Offset = "0x844DAC0", VA = "0x18844F4C0")]
	private Task MHALDBDKPKM(JOEFAEBJKIB APDBNIMCPID, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x844F7D0", Offset = "0x844DDD0", VA = "0x18844F7D0")]
	private Task PJHOEPPBEDN(JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x844EED0", Offset = "0x844D4D0", VA = "0x18844EED0")]
	private Task IJMOKDCPBPN(JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x844EF30", Offset = "0x844D530", VA = "0x18844EF30")]
	private Task IMIMLLHKHHJ(JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x844F4B0", Offset = "0x844DAB0", VA = "0x18844F4B0")]
	private static Task LOKIDKJKKFA(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x844E7A0", Offset = "0x844CDA0", VA = "0x18844E7A0")]
	private Task EPEDOLELIIC(JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x844E3B0", Offset = "0x844C9B0", VA = "0x18844E3B0")]
	private Task CDLCNIOHNNG(JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x844EBC0", Offset = "0x844D1C0", VA = "0x18844EBC0")]
	private void GBGIHACGHKN(AENKMJAJKCL HOOJNAMGGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x844F900", Offset = "0x844DF00", VA = "0x18844F900")]
	public void PPCONFLLMCP(long CFBANPJJEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	private static void PIEBNGKJJNC(GOMNLGPHFID KNDDJPGLJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x844E920", Offset = "0x844CF20", VA = "0x18844E920")]
	[AsyncStateMachine(typeof(GAPCPJDKIHH))]
	private Task FCEOHIEDGPF(JOEFAEBJKIB NJLJEKGKBFA, BAKGMMHDEOL KNADNIOJNOE, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken HNIFIEMGDPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x844DFA0", Offset = "0x844C5A0", VA = "0x18844DFA0")]
	[AsyncStateMachine(typeof(PAEMBNLJEGC))]
	private Task BCMHMPEEMOB(JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x844F200", Offset = "0x844D800", VA = "0x18844F200")]
	private static GMMJMMMKMBM KPJAKCGCJCC(JOEFAEBJKIB GIJBGILJKNL)
	{
		return default(GMMJMMMKMBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x844E7C0", Offset = "0x844CDC0", VA = "0x18844E7C0")]
	[AsyncStateMachine(typeof(LIACLKHIOOA))]
	private Task<IHHBKLENLMK> FBCCMLAEMBI(JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, BAKGMMHDEOL JEAOKNGGMFI, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	private void DNPHOKGICMB(IHHBKLENLMK LCBJJCCLMFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct NKEGADBEMPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A4")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005A5")]
	private JOEFAEBJKIB APDBNIMCPID;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private JHHKOFMOFFM PLBPABECHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x8478C80", Offset = "0x8477280", VA = "0x188478C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x8478CD0", Offset = "0x84772D0", VA = "0x188478CD0")]
	public static Task GDMALPFODEM(IPAGNGHLCCF BFCIGLOEMAP, JOEFAEBJKIB APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x8478DB0", Offset = "0x84773B0", VA = "0x188478DB0")]
	private void GDMALPFODEM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct BPDCAGGOPNJ
{
	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x8467D10", Offset = "0x8466310", VA = "0x188467D10")]
	public static Task GDMALPFODEM(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct HLMKGHAKGHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct PMAJIEPGJOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x847C8A0", Offset = "0x847AEA0", VA = "0x18847C8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x847CDD0", Offset = "0x847B3D0", VA = "0x18847CDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x8470B60", Offset = "0x846F160", VA = "0x188470B60")]
	[AsyncStateMachine(typeof(PMAJIEPGJOP))]
	public static Task GDMALPFODEM(GEHMKHHFLAO AJGFGCKEHBB, JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal struct KFLFOFJAIGN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct ELGJKHBCMMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public AMIGCLEJKKN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private IPAGNGHLCCF <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private JHHKOFMOFFM <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private IHHBKLENLMK <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private JHEDBCMAENC <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private List<(PersistenceView, DJNGLNAIHJJ)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private DJNGLNAIHJJ <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x846B9B0", Offset = "0x8469FB0", VA = "0x18846B9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x846C680", Offset = "0x846AC80", VA = "0x18846C680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x8474B50", Offset = "0x8473150", VA = "0x188474B50")]
	[AsyncStateMachine(typeof(ELGJKHBCMMG))]
	public static Task GDMALPFODEM(GEHMKHHFLAO AJGFGCKEHBB, JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x8474CA0", Offset = "0x84732A0", VA = "0x188474CA0")]
	private static void ILDPHEEAEHE(PersistenceView NNAEIGBDCOK, DJNGLNAIHJJ BJPIFCHFNAA, JOEFAEBJKIB APDBNIMCPID, IHHBKLENLMK NHCKJIIHJGE, bool NPHJGNGAOEN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct INJABJLIBIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct CPEGILMICJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public IPAGNGHLCCF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private JHEDBCMAENC <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x8468690", Offset = "0x8466C90", VA = "0x188468690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x8468CB0", Offset = "0x84672B0", VA = "0x188468CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x8471FF0", Offset = "0x84705F0", VA = "0x188471FF0")]
	[AsyncStateMachine(typeof(CPEGILMICJE))]
	public static Task GDMALPFODEM(IPAGNGHLCCF BFCIGLOEMAP, JOEFAEBJKIB APDBNIMCPID, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct EBBPBNLIGOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct OADCEMGJIFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public IPAGNGHLCCF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x84799D0", Offset = "0x8477FD0", VA = "0x1884799D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x8479BE0", Offset = "0x84781E0", VA = "0x188479BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class PJKBDDNAIIA
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
			public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005DC")]
			public PJKBDDNAIIA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005DD")]
			private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005DE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x847F0D0", Offset = "0x847D6D0", VA = "0x18847F0D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x847F460", Offset = "0x847DA60", VA = "0x18847F460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public PJKBDDNAIIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x847C780", Offset = "0x847AD80", VA = "0x18847C780")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task OKNAKMDFPMF(LDCGKGNFMMI<string>.CKHHEKIPJDF timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct KHBIACANPOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public EBBPBNLIGOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private JHEDBCMAENC <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x8475220", Offset = "0x8473820", VA = "0x188475220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x8475E20", Offset = "0x8474420", VA = "0x188475E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private sealed class CJNFDFMFCGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public APPGMHGFBGI version;

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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public CJNFDFMFCGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x8468500", Offset = "0x8466B00", VA = "0x188468500")]
		internal object IAMHPGLDGIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x84685E0", Offset = "0x8466BE0", VA = "0x1884685E0")]
		internal object IMAPOPDIMOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private JOEFAEBJKIB APDBNIMCPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	private GEHMKHHFLAO AJGFGCKEHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	private bool GFFKPEPGKHC;

	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	private static readonly ByteString OMOGNPBDFEN;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private JHHKOFMOFFM PLBPABECHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x846A960", Offset = "0x8468F60", VA = "0x18846A960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private IJPJAKACFOB BJABPNAMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x846AC30", Offset = "0x8469230", VA = "0x18846AC30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x846A9B0", Offset = "0x8468FB0", VA = "0x18846A9B0")]
	[AsyncStateMachine(typeof(OADCEMGJIFE))]
	public static Task GDMALPFODEM(IPAGNGHLCCF BFCIGLOEMAP, JOEFAEBJKIB APDBNIMCPID, GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF, bool GFFKPEPGKHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x846AB00", Offset = "0x8469100", VA = "0x18846AB00")]
	[AsyncStateMachine(typeof(KHBIACANPOH))]
	private Task GDMALPFODEM(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x846A190", Offset = "0x8468790", VA = "0x18846A190")]
	private void DEKFIMFLOGD([NotNull] BPLHNECCAPN DELDEHHAKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x846A150", Offset = "0x8468750", VA = "0x18846A150")]
	private bool BNPIILPMDAF(APPGMHGFBGI DJNGLBELENN, BPLHNECCAPN DELDEHHAKDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
internal struct MKCHPLLAKJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct IOLILHICOCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public AsyncTaskMethodBuilder<JOEFAEBJKIB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public MKCHPLLAKJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public LKLEKOGDEBE.OBNDLGOKJBI downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private TaskAwaiter<IReadOnlyCollection<JJDFEBIHCFN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private TaskAwaiter<(HHHCCNLMPJL<HFIBBAIEKFD, OGMCLKGLBPG>, HHHCCNLMPJL<PFOMDLOAMOL<BPLHNECCAPN>, OGMCLKGLBPG>, HHHCCNLMPJL<PFOMDLOAMOL<HNAGJAILJOF>, OGMCLKGLBPG>, HHHCCNLMPJL<PFOMDLOAMOL<IEnumerable<MCIJFDPPJOL>>, OGMCLKGLBPG>, HHHCCNLMPJL<PFOMDLOAMOL<COGPNGPCNGP>, OGMCLKGLBPG>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x8472110", Offset = "0x8470710", VA = "0x188472110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x8472EF0", Offset = "0x84714F0", VA = "0x188472EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct PODJIDBADAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<HFIBBAIEKFD, OGMCLKGLBPG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public MKCHPLLAKJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public IReadOnlyCollection<JJDFEBIHCFN> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public IReadOnlyCollection<JJDFEBIHCFN> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public LKLEKOGDEBE.OBNDLGOKJBI downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private TaskAwaiter<HHHCCNLMPJL<HFIBBAIEKFD, OGMCLKGLBPG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x847CE30", Offset = "0x847B430", VA = "0x18847CE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x847D490", Offset = "0x847BA90", VA = "0x18847D490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	private KLLJHPOCLHE<NGHKAOKDFBL, HNAGJAILJOF> BNBHCHCMJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private KLLJHPOCLHE<NGHKAOKDFBL, BPLHNECCAPN> OHCODIMLEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private KLLJHPOCLHE<DIKDBMHBMCM, IEnumerable<MCIJFDPPJOL>> CGMILGBHLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private KLLJHPOCLHE<long, COGPNGPCNGP> MCLGELBFODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	private EMCAKAJMIMO GCOFMFFEGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	private GOMNLGPHFID KNDDJPGLJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private IINCMBDAHBF KEKMAFALOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	private Guid? DMDDOFCAJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private IReadOnlyCollection<JJDFEBIHCFN> FPOFAECKECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private Task<IReadOnlyCollection<JJDFEBIHCFN>> DFJCNECFEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private NGHKAOKDFBL OFMJDNINMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private NGHKAOKDFBL EKHBMLBAPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	private NGHKAOKDFBL? NHNPOIIGHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40005FB")]
	private DIKDBMHBMCM AHIENHBHJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40005FC")]
	private LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL;

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x8478200", Offset = "0x8476800", VA = "0x188478200")]
	public static Task<JOEFAEBJKIB> GNAMKEEBKGL(IPAGNGHLCCF BFCIGLOEMAP, [In] EAEOJFOCIBE APDBNIMCPID, LKLEKOGDEBE.OBNDLGOKJBI BHELEDFDDCN, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x8478050", Offset = "0x8476650", VA = "0x188478050")]
	[AsyncStateMachine(typeof(IOLILHICOCM))]
	private Task<JOEFAEBJKIB> GDMALPFODEM(LKLEKOGDEBE.OBNDLGOKJBI BHELEDFDDCN, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x8478700", Offset = "0x8476D00", VA = "0x188478700")]
	[AsyncStateMachine(typeof(PODJIDBADAP))]
	private Task<HHHCCNLMPJL<HFIBBAIEKFD, OGMCLKGLBPG>> ICIINIKJGIF(Guid? DMDDOFCAJJF, IReadOnlyCollection<JJDFEBIHCFN> FPOFAECKECE, IReadOnlyCollection<JJDFEBIHCFN> LLJNIILIBCB, long? CINEDGEJAIA, long? DPKCNMHAPEB, LKLEKOGDEBE.OBNDLGOKJBI BHELEDFDDCN, LDCGKGNFMMI<string>.CKHHEKIPJDF KBMLEGCCJDH, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
internal struct FDMNOOLMEPB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct LNDMANOEKKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public AsyncTaskMethodBuilder<EAEOJFOCIBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public FDMNOOLMEPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private TaskAwaiter<EAEOJFOCIBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x8477420", Offset = "0x8475A20", VA = "0x188477420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x8477870", Offset = "0x8475E70", VA = "0x188477870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct MBHMCDLNOPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public AsyncTaskMethodBuilder<EAEOJFOCIBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public FDMNOOLMEPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private TaskAwaiter<EAEOJFOCIBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x84778E0", Offset = "0x8475EE0", VA = "0x1884778E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x8477D60", Offset = "0x8476360", VA = "0x188477D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class AOBKAOCJPBO
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
			public AOBKAOCJPBO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			private TaskAwaiter<NOEKMJCDIOB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400063E")]
			private TaskAwaiter<NEDLDDMDCHB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x847D500", Offset = "0x847BB00", VA = "0x18847D500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x847DEB0", Offset = "0x847C4B0", VA = "0x18847DEB0", Slot = "5")]
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
		public EJHLKPMLCLG roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public JHHKOFMOFFM callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public NGHKAOKDFBL superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public NGHKAOKDFBL subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public IReadOnlyList<JJDFEBIHCFN> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public IReadOnlyList<JJDFEBIHCFN> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public GOMNLGPHFID roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public AOBKAOCJPBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xE67770", Offset = "0xE65D70", VA = "0x180E67770")]
		internal bool EJPPCJMGEGP(IINCMBDAHBF sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x8466F80", Offset = "0x8465580", VA = "0x188466F80")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task OIJJOHAAKEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x8466D80", Offset = "0x8465380", VA = "0x188466D80")]
		internal Task<DIKDBMHBMCM> FCMAHLDBJIF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct JIKGAOCLODO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public AsyncTaskMethodBuilder<EAEOJFOCIBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public EJHLKPMLCLG roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public JHHKOFMOFFM callbacks;

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
		public NGHKAOKDFBL superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private AOBKAOCJPBO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private IINCMBDAHBF <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private Task<DIKDBMHBMCM> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private TaskAwaiter<GOMNLGPHFID> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private TaskAwaiter<DIKDBMHBMCM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x8473A80", Offset = "0x8472080", VA = "0x188473A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8474A30", Offset = "0x8473030", VA = "0x188474A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	private JHHKOFMOFFM DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private PLHOCFLCCME AANEBFKDCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private EJHLKPMLCLG BCNCMPIIBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	private long CINEDGEJAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	private long NBOIIPJHEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private long HACNOLAIOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private string JMBBDHDFKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	private NGHKAOKDFBL HFBHAAKDPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400061D")]
	private Guid GDHLBGMCLLJ;

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x846DE40", Offset = "0x846C440", VA = "0x18846DE40")]
	public static Task<EAEOJFOCIBE> GNAMKEEBKGL(IPAGNGHLCCF BFCIGLOEMAP, AENKMJAJKCL HOOJNAMGGBC, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x846DCC0", Offset = "0x846C2C0", VA = "0x18846DCC0")]
	[AsyncStateMachine(typeof(LNDMANOEKKH))]
	private Task<EAEOJFOCIBE> GDMALPFODEM(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x846E260", Offset = "0x846C860", VA = "0x18846E260")]
	[AsyncStateMachine(typeof(MBHMCDLNOPK))]
	private Task<EAEOJFOCIBE> PJEJKBJPHEJ(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x846E090", Offset = "0x846C690", VA = "0x18846E090")]
	[AsyncStateMachine(typeof(JIKGAOCLODO))]
	private static Task<EAEOJFOCIBE> PJEJKBJPHEJ(JHHKOFMOFFM DHJEDIPMPLO, EJHLKPMLCLG BCNCMPIIBEG, long CINEDGEJAIA, long NBOIIPJHEBJ, long HACNOLAIOHO, string JMBBDHDFKMN, NGHKAOKDFBL HFBHAAKDPMK, Guid GDHLBGMCLLJ, CancellationToken CBJPDIFOEKF, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x846DE10", Offset = "0x846C410", VA = "0x18846DE10")]
	private void GMBOENADNFI(GOMNLGPHFID KNDDJPGLJMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
internal struct EKNGJCMJDON
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct BJJHBDPJLDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public EKNGJCMJDON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x8467600", Offset = "0x8465C00", VA = "0x188467600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x8467B90", Offset = "0x8466190", VA = "0x188467B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	private JHHKOFMOFFM DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private JOEFAEBJKIB APDBNIMCPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000654")]
	private LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private float NFCINNNCIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private float NOCKDIDHLMO;

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x846B4A0", Offset = "0x8469AA0", VA = "0x18846B4A0")]
	public static Task LJCOBGHNIAJ(IPAGNGHLCCF BFCIGLOEMAP, JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x846B380", Offset = "0x8469980", VA = "0x18846B380")]
	[AsyncStateMachine(typeof(BJJHBDPJLDG))]
	public Task GDMALPFODEM(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x846B880", Offset = "0x8469E80", VA = "0x18846B880")]
	private static void PLOCCGMPIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x846B700", Offset = "0x8469D00", VA = "0x18846B700")]
	private void OGFKJLCEMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x846B640", Offset = "0x8469C40", VA = "0x18846B640")]
	private static float NLBJEKAFBPH(JHHKOFMOFFM DHJEDIPMPLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x846B860", Offset = "0x8469E60", VA = "0x18846B860")]
	private static float OKBMAHAHIIE()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000172")]
internal struct HMOCADIKAFJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private struct NPHJOCPPCHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public GEHMKHHFLAO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private PPPBMGNNDNF <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private IPAGNGHLCCF <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private AGJCFBFMDCK.DDCNOPNHDPM <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x8479150", Offset = "0x8477750", VA = "0x188479150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x8479970", Offset = "0x8477F70", VA = "0x188479970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct AIELGNNJIOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x84669F0", Offset = "0x8464FF0", VA = "0x1884669F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x8466D20", Offset = "0x8465320", VA = "0x188466D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x84716A0", Offset = "0x846FCA0", VA = "0x1884716A0")]
	[AsyncStateMachine(typeof(NPHJOCPPCHE))]
	public static Task GDMALPFODEM(GEHMKHHFLAO AJGFGCKEHBB, JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x84717E0", Offset = "0x846FDE0", VA = "0x1884717E0")]
	private static Task<DAEAHJMMAED> LEBCHMOEDPG(GEHMKHHFLAO AJGFGCKEHBB, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x84715E0", Offset = "0x846FBE0", VA = "0x1884715E0")]
	[AsyncStateMachine(typeof(AIELGNNJIOH))]
	private static Task CAFGCIGBDJH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
internal struct EBIIFJCDEKP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct CIEBHMADBID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public EBIIFJCDEKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x8467DF0", Offset = "0x84663F0", VA = "0x188467DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x84684A0", Offset = "0x8466AA0", VA = "0x1884684A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class IDCILHPGBFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public IDCILHPGBFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x8471850", Offset = "0x846FE50", VA = "0x188471850")]
		internal object MDJIAKPDBCE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct PDICFIDGPNF : IAsyncStateMachine
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
		public EBIIFJCDEKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x847ADB0", Offset = "0x84793B0", VA = "0x18847ADB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x847B230", Offset = "0x8479830", VA = "0x18847B230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private bool GPGJKJMFCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private CancellationToken CBJPDIFOEKF;

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x846AE90", Offset = "0x8469490", VA = "0x18846AE90")]
	public static Task BJJOOCPFFMI(IPAGNGHLCCF BFCIGLOEMAP, bool GPGJKJMFCFP, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken JDCDGDBBGIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x846AF00", Offset = "0x8469500", VA = "0x18846AF00")]
	[AsyncStateMachine(typeof(CIEBHMADBID))]
	private Task GDMALPFODEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x846AD60", Offset = "0x8469360", VA = "0x18846AD60")]
	[AsyncStateMachine(typeof(PDICFIDGPNF))]
	private Task AAAMEHIBOMA(bool BEGAHOKPHIA, string NHHGKEDIJJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0")]
	private bool HKGLNKIDGEI(bool GPGJKJMFCFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
internal struct KGKJAAEFGKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct PEHFLKKDKEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public KGKJAAEFGKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x847B290", Offset = "0x8479890", VA = "0x18847B290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x847B800", Offset = "0x8479E00", VA = "0x18847B800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class NLLNNBHHILO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public NLLNNBHHILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x8479100", Offset = "0x8477700", VA = "0x188479100")]
		internal object MDJIAKPDBCE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct LMMMKDOLNDG : IAsyncStateMachine
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
		public KGKJAAEFGKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x84766F0", Offset = "0x8474CF0", VA = "0x1884766F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x8476B70", Offset = "0x8475170", VA = "0x188476B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private AHKCDLBPKNG DNEDILMENHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private bool CDPOAJCCACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private JOEFAEBJKIB APDBNIMCPID;

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x84751A0", Offset = "0x84737A0", VA = "0x1884751A0")]
	public static Task<Scene> LGEJEHLNBKI(IPAGNGHLCCF BFCIGLOEMAP, AHKCDLBPKNG DLLDHIIMPKO, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x8474FE0", Offset = "0x84735E0", VA = "0x188474FE0")]
	[AsyncStateMachine(typeof(PEHFLKKDKEK))]
	private Task<Scene> GDMALPFODEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x8475100", Offset = "0x8473700", VA = "0x188475100")]
	private bool GOKJHKPJHKF(JOEFAEBJKIB APDBNIMCPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x8475130", Offset = "0x8473730", VA = "0x188475130")]
	private void IGPNICKEGEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x8474E90", Offset = "0x8473490", VA = "0x188474E90")]
	[AsyncStateMachine(typeof(LMMMKDOLNDG))]
	private Task<Scene> AAAMEHIBOMA(string NHHGKEDIJJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal struct EKILGEACLCB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct OFMJNIKBFPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public EKILGEACLCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public IHHBKLENLMK nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public JOEFAEBJKIB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private TaskAwaiter<IHHBKLENLMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x8479CD0", Offset = "0x84782D0", VA = "0x188479CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x847A7A0", Offset = "0x8478DA0", VA = "0x18847A7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct MNOJFKAAKCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public AsyncTaskMethodBuilder<IHHBKLENLMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public EKILGEACLCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public IHHBKLENLMK state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x8478930", Offset = "0x8476F30", VA = "0x188478930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x8478C10", Offset = "0x8477210", VA = "0x188478C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	private readonly GEHMKHHFLAO AJGFGCKEHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	private readonly PLHOCFLCCME AANEBFKDCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private readonly PHFJIAMDFFA LDGKLCBAEKI;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private PPPBMGNNDNF AAIHBKEDJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x6904CD0", Offset = "0x69032D0", VA = "0x186904CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x846B320", Offset = "0x8469920", VA = "0x18846B320")]
	public EKILGEACLCB(GEHMKHHFLAO AJGFGCKEHBB, PLHOCFLCCME AANEBFKDCIJ, PHFJIAMDFFA LDGKLCBAEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x846B170", Offset = "0x8469770", VA = "0x18846B170")]
	[AsyncStateMachine(typeof(OFMJNIKBFPE))]
	public Task<IHHBKLENLMK> KPKNHBIGEMI(IHHBKLENLMK EFAPNPKMFEC, JOEFAEBJKIB GIJBGILJKNL, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF, bool CIPDMCKNNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x846B010", Offset = "0x8469610", VA = "0x18846B010")]
	[AsyncStateMachine(typeof(MNOJFKAAKCG))]
	private Task<IHHBKLENLMK> BJMCBFJMCHK(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, IHHBKLENLMK IDAKFFICKHC, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x846B2F0", Offset = "0x84698F0", VA = "0x18846B2F0")]
	private bool NGAFJKEIKIO(IHHBKLENLMK ECLMPMLLNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x846AFF0", Offset = "0x84695F0", VA = "0x18846AFF0")]
	private void AHIMDJPCPBN(string AACKKPGJBPA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal struct OIJDHBECCGN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct IFJJKALNFKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public PPPBMGNNDNF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public AMIGCLEJKKN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private JHEDBCMAENC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private List<(PersistenceView, DJNGLNAIHJJ)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private (PersistenceView, DJNGLNAIHJJ) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x84718D0", Offset = "0x846FED0", VA = "0x1884718D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x8471F90", Offset = "0x8470590", VA = "0x188471F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x847A810", Offset = "0x8478E10", VA = "0x18847A810")]
	[AsyncStateMachine(typeof(IFJJKALNFKC))]
	public static Task GDMALPFODEM(PPPBMGNNDNF AOHGJNGCBBI, JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal struct NKNKPDPJMKB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private struct HMLIJHDMLCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public PPPBMGNNDNF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public AMIGCLEJKKN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private APPGMHGFBGI <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private JHEDBCMAENC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private List<(PersistenceView, DJNGLNAIHJJ)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private DJNGLNAIHJJ <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x8470CA0", Offset = "0x846F2A0", VA = "0x188470CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x8471580", Offset = "0x846FB80", VA = "0x188471580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x8478FC0", Offset = "0x84775C0", VA = "0x188478FC0")]
	[AsyncStateMachine(typeof(HMLIJHDMLCO))]
	public static Task GDMALPFODEM(PPPBMGNNDNF AOHGJNGCBBI, JOEFAEBJKIB APDBNIMCPID, AMIGCLEJKKN KLNJJLKKHCG, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public struct HCIBNIKBMHI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct GJFEIGIGPHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<HFIBBAIEKFD, OGMCLKGLBPG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public HCIBNIKBMHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public LKLEKOGDEBE.OBNDLGOKJBI preloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private TaskAwaiter<HHHCCNLMPJL<HFIBBAIEKFD, OGMCLKGLBPG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x846F890", Offset = "0x846DE90", VA = "0x18846F890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x846FF10", Offset = "0x846E510", VA = "0x18846FF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	private long OLIHOCDFDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private long AODGHMLLAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private Guid? BDKBBFKFOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	private IReadOnlyCollection<JJDFEBIHCFN> GFFKCAJABEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private IReadOnlyCollection<JJDFEBIHCFN> CEDOEFILHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private EMCAKAJMIMO JHDGAMGLDFA;

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x84700E0", Offset = "0x846E6E0", VA = "0x1884700E0")]
	public static Task<HHHCCNLMPJL<HFIBBAIEKFD, OGMCLKGLBPG>> GNAMKEEBKGL(long CINEDGEJAIA, long NBOIIPJHEBJ, NEDLDDMDCHB KLDLPBNELBC, LKLEKOGDEBE.OBNDLGOKJBI FGPMNAKBLHC, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x846FF80", Offset = "0x846E580", VA = "0x18846FF80")]
	[AsyncStateMachine(typeof(GJFEIGIGPHD))]
	private Task<HHHCCNLMPJL<HFIBBAIEKFD, OGMCLKGLBPG>> GDMALPFODEM(LKLEKOGDEBE.OBNDLGOKJBI FGPMNAKBLHC, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal struct AGJCFBFMDCK
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	public struct DDCNOPNHDPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public List<FLOHPLGLJLN> HCGEDANEBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public List<DJNGLNAIHJJ> OHNOBDFHNNP;

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xABB7D0", Offset = "0xAB9DD0", VA = "0x180ABB7D0")]
		public DDCNOPNHDPM(List<FLOHPLGLJLN> HCGEDANEBJM, List<DJNGLNAIHJJ> OHNOBDFHNNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class KOFEDGDICFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public IEnumerable<FLOHPLGLJLN> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public KOFEDGDICFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x8475E80", Offset = "0x8474480", VA = "0x188475E80")]
		internal object EBAIPAPHEEJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private IPAGNGHLCCF BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	private JOEFAEBJKIB APDBNIMCPID;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private JHHKOFMOFFM PLBPABECHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x8466150", Offset = "0x8464750", VA = "0x188466150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x8466740", Offset = "0x8464D40", VA = "0x188466740")]
	public static DDCNOPNHDPM GDMALPFODEM(IPAGNGHLCCF BFCIGLOEMAP, JOEFAEBJKIB APDBNIMCPID)
	{
		return default(DDCNOPNHDPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x84667A0", Offset = "0x8464DA0", VA = "0x1884667A0")]
	private DDCNOPNHDPM GDMALPFODEM()
	{
		return default(DDCNOPNHDPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x84661A0", Offset = "0x84647A0", VA = "0x1884661A0")]
	private DDCNOPNHDPM FFCAJOBIBCG(BPLHNECCAPN DELDEHHAKDM, APPGMHGFBGI HLPIFOPEBCL)
	{
		return default(DDCNOPNHDPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x8465F80", Offset = "0x8464580", VA = "0x188465F80")]
	private bool CFKGONFDLJM(IEnumerable<FLOHPLGLJLN> HCGEDANEBJM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal struct APBCKENEMNN
{
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class KFHIBDEHKMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public AGJCFBFMDCK.DDCNOPNHDPM instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public KFHIBDEHKMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x8474AA0", Offset = "0x84730A0", VA = "0x188474AA0")]
		internal object OKNAKMDFPMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class OEILBBHPBDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public OEILBBHPBDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x8479C40", Offset = "0x8478240", VA = "0x188479C40")]
		internal object DFBECEDJHLP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x8467050", Offset = "0x8465650", VA = "0x188467050")]
	public static void GDMALPFODEM(PPPBMGNNDNF AOHGJNGCBBI, JOEFAEBJKIB APDBNIMCPID, AGJCFBFMDCK.DDCNOPNHDPM AOHAMOKDOPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
internal class PHFJIAMDFFA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private struct JBAEBDJADON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public PHFJIAMDFFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public IHHBKLENLMK operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public JOEFAEBJKIB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x8472F60", Offset = "0x8471560", VA = "0x188472F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x84736D0", Offset = "0x8471CD0", VA = "0x1884736D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private sealed class OGABNIJNPBG
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
			public OGABNIJNPBG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006EB")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(RVA = "0x848EE20", Offset = "0x848D420", VA = "0x18848EE20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(RVA = "0x848EFC0", Offset = "0x848D5C0", VA = "0x18848EFC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public PHFJIAMDFFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public OGABNIJNPBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x848DF00", Offset = "0x848C500", VA = "0x18848DF00")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task HFKCNMEBCIO(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private struct IHDAGKDDBIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public PHFJIAMDFFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		private OGABNIJNPBG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x84873D0", Offset = "0x84859D0", VA = "0x1884873D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x8487900", Offset = "0x8485F00", VA = "0x188487900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private struct JLNPENACEGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public PHFJIAMDFFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private Dictionary<Guid, List<JCIEFCALJCE>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x848AAE0", Offset = "0x84890E0", VA = "0x18848AAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x848B0F0", Offset = "0x84896F0", VA = "0x18848B0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct MIDLIFGDKKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public PHFJIAMDFFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		private Dictionary<Guid, List<JCIEFCALJCE>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x848B650", Offset = "0x8489C50", VA = "0x18848B650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x848BCE0", Offset = "0x848A2E0", VA = "0x18848BCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class CCIDIDGHFPN
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
			public JCIEFCALJCE handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400070F")]
			public CCIDIDGHFPN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000710")]
			private JHEDBCMAENC <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000711")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x848E960", Offset = "0x848CF60", VA = "0x18848E960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x848EDC0", Offset = "0x848D3C0", VA = "0x18848EDC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public LOIOFANBADN runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public List<JCIEFCALJCE> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public CCIDIDGHFPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x8481A50", Offset = "0x8480050", VA = "0x188481A50")]
		internal object BEGBKCEIFBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x8481C30", Offset = "0x8480230", VA = "0x188481C30")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task MGHNPBCEIKG(JCIEFCALJCE handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x8481B40", Offset = "0x8480140", VA = "0x188481B40")]
		internal object LFNANEBNEPC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private struct GJDICBCNGOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public LOIOFANBADN runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public List<JCIEFCALJCE> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private CCIDIDGHFPN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x8486050", Offset = "0x8484650", VA = "0x188486050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x8486520", Offset = "0x8484B20", VA = "0x188486520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private struct KNCAJMBNIEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public PHFJIAMDFFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timer;

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
		[Cpp2IlInjected.Address(RVA = "0x848B150", Offset = "0x8489750", VA = "0x18848B150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x848B440", Offset = "0x8489A40", VA = "0x18848B440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class CKFBCNHGNPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public CKFBCNHGNPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x8482140", Offset = "0x8480740", VA = "0x188482140")]
		internal object CGDELGEBGKD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private struct FDAGPIAGNJI : IAsyncStateMachine
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
		public PHFJIAMDFFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public JOEFAEBJKIB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x84843D0", Offset = "0x84829D0", VA = "0x1884843D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x8484880", Offset = "0x8482E80", VA = "0x188484880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class BBIHMOLBALH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BBIHMOLBALH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x8481080", Offset = "0x847F680", VA = "0x188481080")]
		internal object AINMJLJADJA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct IMBIBILDLLC : IAsyncStateMachine
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
		public PHFJIAMDFFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private JHEDBCMAENC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x84879E0", Offset = "0x8485FE0", VA = "0x1884879E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x8488010", Offset = "0x8486610", VA = "0x188488010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private sealed class MNGBHPALJME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public MNGBHPALJME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x848C260", Offset = "0x848A860", VA = "0x18848C260")]
		internal object OJIPBAKIAKA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private readonly GEHMKHHFLAO AJGFGCKEHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private LMMOHLNEFMM LDGKLCBAEKI;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private PPPBMGNNDNF AAIHBKEDJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x10DD020", Offset = "0x10DB620", VA = "0x1810DD020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public PHFJIAMDFFA(GEHMKHHFLAO AJGFGCKEHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x847BE10", Offset = "0x847A410", VA = "0x18847BE10")]
	[AsyncStateMachine(typeof(JBAEBDJADON))]
	public Task GDMALPFODEM(IHHBKLENLMK NHCKJIIHJGE, JOEFAEBJKIB GIJBGILJKNL, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x847C270", Offset = "0x847A870", VA = "0x18847C270")]
	[AsyncStateMachine(typeof(IHDAGKDDBIJ))]
	private Task IJHKGPDNHFM(JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x847C640", Offset = "0x847AC40", VA = "0x18847C640")]
	[AsyncStateMachine(typeof(JLNPENACEGJ))]
	private Task NNCEFILELKE(JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x847C3B0", Offset = "0x847A9B0", VA = "0x18847C3B0")]
	[AsyncStateMachine(typeof(MIDLIFGDKKE))]
	private Task JLFFCILAPIF(JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x847C4F0", Offset = "0x847AAF0", VA = "0x18847C4F0")]
	[AsyncStateMachine(typeof(GJDICBCNGOJ))]
	private Task MMPKKMIIKGK(Guid KGIKCAHMNMJ, List<JCIEFCALJCE> AHFMANOMGMM, LOIOFANBADN ENNNHBGPBFL, JOEFAEBJKIB APDBNIMCPID, CancellationToken EJJDDFFADPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x847BCD0", Offset = "0x847A2D0", VA = "0x18847BCD0")]
	[AsyncStateMachine(typeof(KNCAJMBNIEE))]
	private Task GCGIHGMMAIA(JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x847C130", Offset = "0x847A730", VA = "0x18847C130")]
	[AsyncStateMachine(typeof(FDAGPIAGNJI))]
	private Task HAIFBNLHNMF(Guid AHEIMNKCFGL, JOEFAEBJKIB APDBNIMCPID, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x847BAE0", Offset = "0x847A0E0", VA = "0x18847BAE0")]
	[AsyncStateMachine(typeof(IMBIBILDLLC))]
	private Task COIDOEGLIIM(Guid AHEIMNKCFGL, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x847B9D0", Offset = "0x8479FD0", VA = "0x18847B9D0")]
	private void CCEKOJAJFOE(Guid AHEIMNKCFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x847BC20", Offset = "0x847A220", VA = "0x18847BC20")]
	private void DBMDHJDBMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x847B870", Offset = "0x8479E70", VA = "0x18847B870")]
	public Guid BMIGNMHOGJO(IHHBKLENLMK PAJPHIMOMIF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x847BF60", Offset = "0x847A560", VA = "0x18847BF60")]
	[CompilerGenerated]
	private object GNHKGBNLDAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal struct LIIFKOJAKIB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private struct APJJOKAICOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public LIIFKOJAKIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		private IEnumerator<JMBLJGACIPD> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x847FFA0", Offset = "0x847E5A0", VA = "0x18847FFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x8480640", Offset = "0x847EC40", VA = "0x188480640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073A")]
	private JHHKOFMOFFM DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400073B")]
	private LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400073C")]
	private CancellationToken CBJPDIFOEKF;

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x848B4F0", Offset = "0x8489AF0", VA = "0x18848B4F0")]
	public static Task DIENEBAEOMC(JHHKOFMOFFM DHJEDIPMPLO, LDCGKGNFMMI<string>.CKHHEKIPJDF DCCJGOAMNIL, CancellationToken JDCDGDBBGIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x848B560", Offset = "0x8489B60", VA = "0x18848B560")]
	[AsyncStateMachine(typeof(APJJOKAICOL))]
	private Task GDMALPFODEM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public readonly struct GHIBGJOBNGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000743")]
	public readonly bool CBPKCEJAKBJ;

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x29A9300", Offset = "0x29A7900", VA = "0x1829A9300")]
	public GHIBGJOBNGE(bool CEJFGABFDAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public readonly struct HFEJJAMCGEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000744")]
	public readonly BPLHNECCAPN? NFLGDLDCAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000745")]
	public readonly IKNHBNNCJJD FHLPMMMIOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000746")]
	public readonly Guid? KJPMNOCOJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000747")]
	public readonly IReadOnlyList<Guid> BJJGAMKNDKB;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public IReadOnlyCollection<string> NHLOMDEHAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x8486990", Offset = "0x8484F90", VA = "0x188486990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public IReadOnlyDictionary<long, int> MPFOJEFIJPE
	{
		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x84869B0", Offset = "0x8484FB0", VA = "0x1884869B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x84869D0", Offset = "0x8484FD0", VA = "0x1884869D0")]
	public HFEJJAMCGEP(BPLHNECCAPN? MKIDPONBDDE, IKNHBNNCJJD FEHGBNNFHCB, Guid? DMDDOFCAJJF, [Optional] IReadOnlyList<Guid>? JGKMLGPNMHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal class MOJFFBJNPFJ : CGFGCNFFKKJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[CompilerGenerated]
	private struct DEBHNGKCJAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public AsyncTaskMethodBuilder<HFEJJAMCGEP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public MOJFFBJNPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		public FHEBLHGADNG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public MJJOEIPLFFL roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		private JHEDBCMAENC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x8482D70", Offset = "0x8481370", VA = "0x188482D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x8483410", Offset = "0x8481A10", VA = "0x188483410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[CompilerGenerated]
	private sealed class BDJLBHLMJJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BDJLBHLMJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x84810F0", Offset = "0x847F6F0", VA = "0x1884810F0")]
		internal object MJOAIHILEOI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private struct FHPBFEOMJFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public MOJFFBJNPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		public FHEBLHGADNG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		private BDJLBHLMJJE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		private JHEDBCMAENC <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		private IEALDBHBOML<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x84848E0", Offset = "0x8482EE0", VA = "0x1884848E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x84853A0", Offset = "0x84839A0", VA = "0x1884853A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000748")]
	private readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000749")]
	private static readonly TimeSpan EAFGOHCLJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400074A")]
	private readonly FJIPBDIIELL HNIEEBOHBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400074B")]
	private readonly JHCGHNLIGPE DPAAKCMGANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400074C")]
	private readonly PBCBIJGDOEH OKJENHLCDON;

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x848D480", Offset = "0x848BA80", VA = "0x18848D480")]
	public MOJFFBJNPFJ(GEHMKHHFLAO AJGFGCKEHBB, FJIPBDIIELL HNIEEBOHBEN, JHCGHNLIGPE GNCBIKPPMJO, PBCBIJGDOEH OKJENHLCDON, JBBHIJHGEPM PAJIGEJCNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x848CD70", Offset = "0x848B370", VA = "0x18848CD70")]
	[AsyncStateMachine(typeof(DEBHNGKCJAH))]
	public Task<HFEJJAMCGEP> DFNAEDFOBIJ(long NBOIIPJHEBJ, MJJOEIPLFFL BICOFHMOEBP, FHEBLHGADNG DMBMNBBDHKN, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x848D2D0", Offset = "0x848B8D0", VA = "0x18848D2D0")]
	[AsyncStateMachine(typeof(FHPBFEOMJFD))]
	private Task NEGOKDJDMDC(FHEBLHGADNG DMBMNBBDHKN, PersistenceView[] HKOHHLANDDM, StringBuilder FJJFEBNNKCK, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x848C2D0", Offset = "0x848A8D0", VA = "0x18848C2D0")]
	private HFEJJAMCGEP BHCPMJGCBML(long NBOIIPJHEBJ, MJJOEIPLFFL BICOFHMOEBP, FHEBLHGADNG DMBMNBBDHKN, IEnumerable<PersistenceView> HKOHHLANDDM, StringBuilder FJJFEBNNKCK)
	{
		return default(HFEJJAMCGEP);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x848CEC0", Offset = "0x848B4C0", VA = "0x18848CEC0")]
	private BPLHNECCAPN LGMECJMODPB(long NBOIIPJHEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x848D080", Offset = "0x848B680", VA = "0x18848D080")]
	private void MPICBEAOLKA(BPLHNECCAPN ILAABPGJMFE, StringBuilder FJJFEBNNKCK, IEnumerable<PersistenceView> HKOHHLANDDM, [In] BELCGLLEFHB GCGBHFPEKCE, HDGPNFAELAI FGPPEIIOCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x848C8E0", Offset = "0x848AEE0", VA = "0x18848C8E0")]
	private void CPILJCJFLHH(BPLHNECCAPN ILAABPGJMFE, StringBuilder FJJFEBNNKCK, PersistenceView NNAEIGBDCOK, HDGPNFAELAI FGPPEIIOCJJ, [In] BELCGLLEFHB GCGBHFPEKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
internal class DMPOKLHCOJD : CGFGCNFFKKJ
{
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class LDHIBJJJBKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public KAKCKKIHOCK.ADGAEKFCFIH roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public LDHIBJJJBKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x848B4A0", Offset = "0x8489AA0", VA = "0x18848B4A0")]
		internal object EHCGMCGMMGN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private struct BJDLKBGLHII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public AsyncTaskMethodBuilder<(KAKCKKIHOCK.ADGAEKFCFIH roomDataUpload, KAKCKKIHOCK.ADGAEKFCFIH subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public HFEJJAMCGEP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public JHHKOFMOFFM callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		private LDHIBJJJBKC <>8__1;

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
		private TaskAwaiter<KAKCKKIHOCK.ADGAEKFCFIH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x8481160", Offset = "0x847F760", VA = "0x188481160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x84819E0", Offset = "0x847FFE0", VA = "0x1884819E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private struct APNCNIKFIFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public AsyncTaskMethodBuilder<GHABJHKCBDN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public DMPOKLHCOJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		public MDNOEFMCADI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		public HFEJJAMCGEP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		private TaskAwaiter<GHABJHKCBDN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x84806A0", Offset = "0x847ECA0", VA = "0x1884806A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x8480940", Offset = "0x847EF40", VA = "0x188480940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct BALAEHOGAOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		public AsyncTaskMethodBuilder<GHABJHKCBDN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public JHHKOFMOFFM callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		public HFEJJAMCGEP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public FHMABBJMFCN ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public MDNOEFMCADI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		private TaskAwaiter<(KAKCKKIHOCK.ADGAEKFCFIH roomDataUpload, KAKCKKIHOCK.ADGAEKFCFIH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		private TaskAwaiter<GHABJHKCBDN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x84809B0", Offset = "0x847EFB0", VA = "0x1884809B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x8481010", Offset = "0x847F610", VA = "0x188481010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private struct MMGMFJAHGEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		public AsyncTaskMethodBuilder<NOEKMJCDIOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		public DMPOKLHCOJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public HFEJJAMCGEP roomSerializedData;

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
		private TaskAwaiter<(KAKCKKIHOCK.ADGAEKFCFIH roomDataUpload, KAKCKKIHOCK.ADGAEKFCFIH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		private TaskAwaiter<NOEKMJCDIOB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x848BD40", Offset = "0x848A340", VA = "0x18848BD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x848C1F0", Offset = "0x848A7F0", VA = "0x18848C1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private sealed class NEMFJEKCEFM
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
			public AsyncTaskMethodBuilder<DAEAHJMMAED> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400079B")]
			public NEMFJEKCEFM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400079C")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400079D")]
			private DAEAHJMMAED <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400079E")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400079F")]
			private TaskAwaiter<NOEKMJCDIOB> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007A0")]
			private TaskAwaiter<GHABJHKCBDN> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007A1")]
			private TaskAwaiter<DAEAHJMMAED> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0x848F020", Offset = "0x848D620", VA = "0x18848F020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x8490220", Offset = "0x848E820", VA = "0x188490220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public DMPOKLHCOJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public HFEJJAMCGEP roomSerializedData;

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
		public MDNOEFMCADI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public GHIBGJOBNGE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public NEMFJEKCEFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x848DDD0", Offset = "0x848C3D0", VA = "0x18848DDD0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<DAEAHJMMAED> DNBDBOKLFAK(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[CompilerGenerated]
	private struct HIPOBDEPEJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		public AsyncTaskMethodBuilder<DAEAHJMMAED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		public DMPOKLHCOJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		public HFEJJAMCGEP roomSerializedData;

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
		public MDNOEFMCADI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public GHIBGJOBNGE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		private TaskAwaiter<DAEAHJMMAED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x8486B70", Offset = "0x8485170", VA = "0x188486B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x8486EA0", Offset = "0x84854A0", VA = "0x188486EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000766")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000767")]
	private static readonly JBBHIJHGEPM HDNPMENDLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000768")]
	private readonly FCNEEADCJIO DILAOJNHENM;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private IPAGNGHLCCF KFEELBCAGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x844DDF0", Offset = "0x844C3F0", VA = "0x18844DDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x8483FE0", Offset = "0x84825E0", VA = "0x188483FE0")]
	public DMPOKLHCOJD(GEHMKHHFLAO AJGFGCKEHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x84837B0", Offset = "0x8481DB0", VA = "0x1884837B0")]
	[AsyncStateMachine(typeof(BJDLKBGLHII))]
	private static Task<(KAKCKKIHOCK.ADGAEKFCFIH, KAKCKKIHOCK.ADGAEKFCFIH)> HKBHDCPBPIL(JHHKOFMOFFM DHJEDIPMPLO, HFEJJAMCGEP KMDNEDBDMKJ, long CINEDGEJAIA, long DPKCNMHAPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x8483900", Offset = "0x8481F00", VA = "0x188483900")]
	[AsyncStateMachine(typeof(APNCNIKFIFD))]
	public Task<GHABJHKCBDN> MKEIEBDFEFK(int BGINAMOOLIJ, [CanBeNull] MDNOEFMCADI LMHJJMIBAMA, HFEJJAMCGEP KMDNEDBDMKJ, long CINEDGEJAIA, long DPKCNMHAPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x8483C00", Offset = "0x8482200", VA = "0x188483C00")]
	public static Task<GHABJHKCBDN> MKEIEBDFEFK(JHHKOFMOFFM DHJEDIPMPLO, int BGINAMOOLIJ, [CanBeNull] MDNOEFMCADI LMHJJMIBAMA, HFEJJAMCGEP KMDNEDBDMKJ, long CINEDGEJAIA, long DPKCNMHAPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x8483A70", Offset = "0x8482070", VA = "0x188483A70")]
	[AsyncStateMachine(typeof(BALAEHOGAOI))]
	public static Task<GHABJHKCBDN> MKEIEBDFEFK(JHHKOFMOFFM DHJEDIPMPLO, int BGINAMOOLIJ, [CanBeNull] MDNOEFMCADI LMHJJMIBAMA, HFEJJAMCGEP KMDNEDBDMKJ, long CINEDGEJAIA, long DPKCNMHAPEB, FHMABBJMFCN IFNGLDEADKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x8483480", Offset = "0x8481A80", VA = "0x188483480")]
	[AsyncStateMachine(typeof(MMGMFJAHGEN))]
	private Task<NOEKMJCDIOB> BLDBFIFJCJP(string JMBBDHDFKMN, int BGINAMOOLIJ, HFEJJAMCGEP KMDNEDBDMKJ, long CINEDGEJAIA, long DPKCNMHAPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x8483600", Offset = "0x8481C00", VA = "0x188483600")]
	[AsyncStateMachine(typeof(HIPOBDEPEJM))]
	public Task<DAEAHJMMAED> HHFFPLDCOPG(int BGINAMOOLIJ, MDNOEFMCADI? LMHJJMIBAMA, HFEJJAMCGEP KMDNEDBDMKJ, long CINEDGEJAIA, long DPKCNMHAPEB, GHIBGJOBNGE HMEALLJEACK, LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
public abstract class JJEOFOBLPPE<T> where T : JJEOFOBLPPE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007AE")]
	internal readonly IPAGNGHLCCF CMIMNHJBHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007AF")]
	private int? OGCAMFNODBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007B0")]
	protected readonly Guid EHBJDHPDJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007B1")]
	protected readonly MCEHODFGIME PMGOEHPMGKM;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	protected T OAMLFEMFPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x4E82DD0", Offset = "0x4E813D0", VA = "0x184E82DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x4E82E30", Offset = "0x4E81430", VA = "0x184E82E30")]
	internal JJEOFOBLPPE(IPAGNGHLCCF HMCEMLGBOJN, MCEHODFGIME IKONCMMACKE, [Optional] Guid? DHFBDLBBCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x4E82CF0", Offset = "0x4E812F0", VA = "0x184E82CF0")]
	private DAEAHJMMAED IDBFCFMCDOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	protected virtual void JKADJDONKCD(DAEAHJMMAED NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x4E82BB0", Offset = "0x4E811B0", VA = "0x184E82BB0")]
	public T FMPHLFCEFOL(AIPAHMNCJKP MCADOGGHICO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x4E82C50", Offset = "0x4E81250", VA = "0x184E82C50")]
	public T GCAAPBKHAPE(int COAOFMGNHMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x4E82A80", Offset = "0x4E81080", VA = "0x184E82A80", Slot = "5")]
	public virtual Task<GGIHIJCCBHJ> EALGDBLMHNA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public class JKIIIKPEIIP : JJEOFOBLPPE<JKIIIKPEIIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007B2")]
	private AENKMJAJKCL DGHLABNPIEC;

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x8489200", Offset = "0x8487800", VA = "0x188489200")]
	internal JKIIIKPEIIP(IPAGNGHLCCF HMCEMLGBOJN, MCEHODFGIME IKONCMMACKE, [Optional] Guid? DHFBDLBBCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x7700560", Offset = "0x76FEB60", VA = "0x187700560")]
	public JKIIIKPEIIP GEAKCODCLHF(AENKMJAJKCL DGHLABNPIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x8489130", Offset = "0x8487730", VA = "0x188489130", Slot = "4")]
	protected override void JKADJDONKCD(DAEAHJMMAED NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public class AJBKMDJKJOF : JJEOFOBLPPE<AJBKMDJKJOF>
{
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	internal enum IBDBHFCMOBG
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
	private struct CIBOKOHJFEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public AsyncTaskMethodBuilder<GGIHIJCCBHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public AJBKMDJKJOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		private TaskAwaiter<GGIHIJCCBHJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x8481D30", Offset = "0x8480330", VA = "0x188481D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x84820D0", Offset = "0x84806D0", VA = "0x1884820D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007B3")]
	private IBDBHFCMOBG HKNBGIJKCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007B4")]
	private string APANPFBLGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007B5")]
	private MDNOEFMCADI DGHLABNPIEC;

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x847FAF0", Offset = "0x847E0F0", VA = "0x18847FAF0")]
	internal AJBKMDJKJOF(IPAGNGHLCCF HMCEMLGBOJN, MCEHODFGIME IKONCMMACKE, [Optional] Guid? DHFBDLBBCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x847F7F0", Offset = "0x847DDF0", VA = "0x18847F7F0")]
	public AJBKMDJKJOF BFBNCLLCHHE(string HHPFBMBMELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x847F7B0", Offset = "0x847DDB0", VA = "0x18847F7B0")]
	public AJBKMDJKJOF AGKIPELMDFB(bool GFMFLEPMNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x847F7D0", Offset = "0x847DDD0", VA = "0x18847F7D0")]
	public AJBKMDJKJOF AODONBEPFDH(bool EGDBBMJKJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x847F820", Offset = "0x847DE20", VA = "0x18847F820")]
	public AJBKMDJKJOF DKAJODAAKDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x847F980", Offset = "0x847DF80", VA = "0x18847F980", Slot = "4")]
	protected override void JKADJDONKCD(DAEAHJMMAED NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x847F850", Offset = "0x847DE50", VA = "0x18847F850", Slot = "5")]
	[AsyncStateMachine(typeof(CIBOKOHJFEN))]
	public override Task<GGIHIJCCBHJ> EALGDBLMHNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x847F940", Offset = "0x847DF40", VA = "0x18847F940")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<GGIHIJCCBHJ> IAPAGHMNHLN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
internal static class OGMPMEKOCBP
{
	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x848E6C0", Offset = "0x848CCC0", VA = "0x18848E6C0")]
	public static void PKDLJEOCDIA(this IKJOECKPNBM HCIBJEJKPFM, PAIKJEGABFG FKPLNDNGIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x848E640", Offset = "0x848CC40", VA = "0x18848E640")]
	public static void IGBMBKGDDBD(this PAIKJEGABFG HJHEMAOEAHO, [Optional] string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
public static class OHECHOJLIPD
{
	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x848E8C0", Offset = "0x848CEC0", VA = "0x18848E8C0")]
	public static NGHKAOKDFBL PIJLIHCCPFJ(this MJLOLKIDFMP OMEHHNGIHKJ)
	{
		return default(NGHKAOKDFBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x848E810", Offset = "0x848CE10", VA = "0x18848E810")]
	public static MJLOLKIDFMP CGPGGHJAFDM(this NGHKAOKDFBL ONJNMMMAKMJ)
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
			public GKOJCGDILMH ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007C3")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007C4")]
			public GKOJCGDILMH HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		private static GKOJCGDILMH[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		private Dictionary<GKOJCGDILMH, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x84907E0", Offset = "0x848EDE0", VA = "0x1884907E0")]
		public bool KEHIAPILGAG(GKOJCGDILMH ECOONOEHGGP, [Out] ResultConfig NFFGNPJGBOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x8490850", Offset = "0x848EE50", VA = "0x188490850")]
		public ResultConfig OODEHJABLJO(GKOJCGDILMH DKBCGBFNIGO, [Optional] HashSet<GKOJCGDILMH> HDFKKPCHFAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x8490F40", Offset = "0x848F540", VA = "0x188490F40", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x8490990", Offset = "0x848EF90", VA = "0x188490990", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0xBBABA0", Offset = "0xBB91A0", VA = "0x180BBABA0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
public class AKNGIKBBHKG : OKGFEPLGNNN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[CompilerGenerated]
	private struct DPMDNPAPNKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		public AKNGIKBBHKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x8484070", Offset = "0x8482670", VA = "0x188484070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x8484300", Offset = "0x8482900", VA = "0x188484300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[CompilerGenerated]
	private struct JLADLODNINO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		public OKGFEPLGNNN preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x84892D0", Offset = "0x84878D0", VA = "0x1884892D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x8489780", Offset = "0x8487D80", VA = "0x188489780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007CD")]
	private readonly FADGJJEOCKD NPGOEEEJDDL;

	[Cpp2IlInjected.Token(Token = "0x40007CE")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string IMDPEJLINIL
	{
		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x847FCD0", Offset = "0x847E2D0", VA = "0x18847FCD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x847FC60", Offset = "0x847E260", VA = "0x18847FC60")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	internal static void CPNCJILCPPN(AINJBKKEAIL PJLGMBBLBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public AKNGIKBBHKG([DJIFKCCBBND(null)] FADGJJEOCKD NPGOEEEJDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x847FD00", Offset = "0x847E300", VA = "0x18847FD00", Slot = "5")]
	[AsyncStateMachine(typeof(DPMDNPAPNKA))]
	public Task GDMALPFODEM(LDCGKGNFMMI<string>.CKHHEKIPJDF MCLBGLJLFCK, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x847FE10", Offset = "0x847E410", VA = "0x18847FE10")]
	[AsyncStateMachine(typeof(JLADLODNINO))]
	private Task GDPBDKHNMNB(OKGFEPLGNNN MEBFMFIEGMH, LDCGKGNFMMI<string>.CKHHEKIPJDF MCLBGLJLFCK, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
public interface FADGJJEOCKD : OKGFEPLGNNN
{
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
public interface OKGFEPLGNNN
{
	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	string IMDPEJLINIL
	{
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GDMALPFODEM(LDCGKGNFMMI<string>.CKHHEKIPJDF MCLBGLJLFCK, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public static class GPADKKALJKB
{
	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x8486580", Offset = "0x8484B80", VA = "0x188486580")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	internal static void JPEDEHNINOC(AINJBKKEAIL PJLGMBBLBIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public interface OPPGGNKKPPF : IEquatable<OPPGGNKKPPF>
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	DateTime EGIEPOFBJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFJDNJLICMH();

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GDEOLFKPCPI(long CINEDGEJAIA, long NBOIIPJHEBJ, [Out] HFEJJAMCGEP KMDNEDBDMKJ);
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
internal class DACHKOBCJIL : FKMGBBKKGNI
{
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	[CompilerGenerated]
	private sealed class EJMGKAANIED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DE")]
		public KNEDGBILGPM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DF")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public EJMGKAANIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x8484360", Offset = "0x8482960", VA = "0x188484360")]
		internal object EFGBLACOPJA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007DC")]
	private readonly DKJAMFBNPLF BPFIAFHIJHH;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<OPPGGNKKPPF> KIFCAFINGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x84821B0", Offset = "0x84807B0", VA = "0x1884821B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x8482BA0", Offset = "0x84811A0", VA = "0x188482BA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	[UnityEngine.Scripting.Preserve]
	public DACHKOBCJIL([DJIFKCCBBND(null)] DKJAMFBNPLF BPFIAFHIJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x8482730", Offset = "0x8480D30", VA = "0x188482730", Slot = "6")]
	public bool EFGFHMKDHML(long CINEDGEJAIA, long NBOIIPJHEBJ, HFEJJAMCGEP KMDNEDBDMKJ, KNEDGBILGPM EDHLLDFNCFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0xDBA1C0", Offset = "0xDB87C0", VA = "0x180DBA1C0")]
	private void ACGHAPHBICM(OPPGGNKKPPF EBKHBJGGNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x8482A30", Offset = "0x8481030", VA = "0x188482A30", Slot = "7")]
	public bool FHNCAFIPDJA(long CINEDGEJAIA, long NBOIIPJHEBJ, [Out] OPPGGNKKPPF HIIKALLGCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x8482680", Offset = "0x8480C80", VA = "0x188482680", Slot = "8")]
	public bool EEPFFLLCOIA(long CINEDGEJAIA, long NBOIIPJHEBJ, KNEDGBILGPM EDHLLDFNCFM, [Out] OPPGGNKKPPF HIIKALLGCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x8482260", Offset = "0x8480860", VA = "0x188482260")]
	private void EEMNNPJKEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x8482C50", Offset = "0x8481250", VA = "0x188482C50", Slot = "9")]
	public void MOEMLOMEHPE(long CINEDGEJAIA, long NBOIIPJHEBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
internal abstract class JKGNEDDKDBK : DKJAMFBNPLF
{
	[Cpp2IlInjected.Token(Token = "0x20001C4")]
	protected enum JKGCPKNFEAO : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[CompilerGenerated]
	private sealed class OGJAPNDBKJE : IEnumerable<OPPGGNKKPPF>, IEnumerable, IEnumerator<OPPGGNKKPPF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		private OPPGGNKKPPF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		public JKGNEDDKDBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		private KNEDGBILGPM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		public KNEDGBILGPM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private OPPGGNKKPPF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xE9CA20", Offset = "0xE9B020", VA = "0x180E9CA20")]
		[DebuggerHidden]
		public OGJAPNDBKJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x848DFF0", Offset = "0x848C5F0", VA = "0x18848DFF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x848E2D0", Offset = "0x848C8D0", VA = "0x18848E2D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x848E220", Offset = "0x848C820", VA = "0x18848E220", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OPPGGNKKPPF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x848E220", Offset = "0x848C820", VA = "0x18848E220", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[CompilerGenerated]
	private sealed class HHPLNKPOKPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		public KNEDGBILGPM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public HHPLNKPOKPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x8486AD0", Offset = "0x84850D0", VA = "0x188486AD0")]
		internal object OIJIHEJJOBK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[CompilerGenerated]
	private sealed class IJBHNCOAAOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		public JKGNEDDKDBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public IJBHNCOAAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x8487960", Offset = "0x8485F60", VA = "0x188487960")]
		internal void LJHBPFDBIIB(HHPDMFCBIOB.GHCFLBOPIHD ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007E2")]
	private readonly object NDHFMFFJCBO;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	protected string PMCMJBNLCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x8488960", Offset = "0x8486F60", VA = "0x188488960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public abstract PPAOKKLNNOP EDAJMNNCAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x84890B0", Offset = "0x84876B0", VA = "0x1884890B0")]
	protected JKGNEDDKDBK([CanBeNull] string LDEMNPMAAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x8488670", Offset = "0x8486C70", VA = "0x188488670", Slot = "5")]
	public bool ABCOMPDCKBM(long CINEDGEJAIA, long NBOIIPJHEBJ, KNEDGBILGPM EDHLLDFNCFM, [Out] OPPGGNKKPPF EBKHBJGGNOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x8488860", Offset = "0x8486E60", VA = "0x188488860", Slot = "6")]
	[IteratorStateMachine(typeof(OGJAPNDBKJE))]
	public IEnumerable<OPPGGNKKPPF> EGKNGFEDPFL(KNEDGBILGPM EDHLLDFNCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void FNMOKCMKIIE(Stream OCIOHDOCJBD, long CINEDGEJAIA, long NBOIIPJHEBJ, HFEJJAMCGEP KMDNEDBDMKJ);

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool IHCPINAMKCG(Stream GEAMOGAPCBF, long CINEDGEJAIA, long NBOIIPJHEBJ, CBMPHAAPMJB JKAKMBAHLDB, [Out] HFEJJAMCGEP KMDNEDBDMKJ);

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x8488970", Offset = "0x8486F70", VA = "0x188488970", Slot = "7")]
	public OPPGGNKKPPF LKKBHHBBEOC(long CINEDGEJAIA, long NBOIIPJHEBJ, HFEJJAMCGEP KMDNEDBDMKJ, KNEDGBILGPM EDHLLDFNCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo PLJCCPGMDKL(long CINEDGEJAIA, long NBOIIPJHEBJ, KNEDGBILGPM EDHLLDFNCFM, JKGCPKNFEAO MCIHPICHCGD);

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo LFOGLJEIIMM(KNEDGBILGPM EDHLLDFNCFM, JKGCPKNFEAO MCIHPICHCGD);

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x84888F0", Offset = "0x8486EF0", VA = "0x1884888F0")]
	protected void GJBDPCEDJDE(HHPDMFCBIOB.GHCFLBOPIHD JFGIOLBDCAL, string AACKKPGJBPA, FileInfo KFCOHPJKAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x8488CF0", Offset = "0x84872F0", VA = "0x188488CF0")]
	internal bool MINFIHIJFPL(FileInfo BGOFIJFKOAL, long CINEDGEJAIA, long NBOIIPJHEBJ, [Out] HFEJJAMCGEP KMDNEDBDMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	private void PMDAJNJIFII(Exception FJADMGBFJLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
internal class GBCCGCEMGNB : JKGNEDDKDBK
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public override PPAOKKLNNOP EDAJMNNCAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x123FB50", Offset = "0x123E150", VA = "0x18123FB50", Slot = "8")]
		get
		{
			return default(PPAOKKLNNOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x8486010", Offset = "0x8484610", VA = "0x188486010")]
	public GBCCGCEMGNB([Optional] string LDEMNPMAAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x8485EA0", Offset = "0x84844A0", VA = "0x188485EA0")]
	private void LNAKLPECJGE(KNEDGBILGPM EDHLLDFNCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x8485400", Offset = "0x8483A00", VA = "0x188485400", Slot = "9")]
	internal override void FNMOKCMKIIE(Stream OCIOHDOCJBD, long CINEDGEJAIA, long NBOIIPJHEBJ, HFEJJAMCGEP KMDNEDBDMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x84856B0", Offset = "0x8483CB0", VA = "0x1884856B0", Slot = "10")]
	internal override bool IHCPINAMKCG(Stream GEAMOGAPCBF, long CINEDGEJAIA, long NBOIIPJHEBJ, CBMPHAAPMJB JKAKMBAHLDB, [Out] HFEJJAMCGEP KMDNEDBDMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x8485F20", Offset = "0x8484520", VA = "0x188485F20", Slot = "11")]
	protected override FileInfo PLJCCPGMDKL(long CINEDGEJAIA, long NBOIIPJHEBJ, KNEDGBILGPM EDHLLDFNCFM, JKGCPKNFEAO MCIHPICHCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x8485DA0", Offset = "0x84843A0", VA = "0x188485DA0", Slot = "12")]
	protected override DirectoryInfo LFOGLJEIIMM(KNEDGBILGPM EDHLLDFNCFM, JKGCPKNFEAO MCIHPICHCGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
internal sealed class JLKAMOANDDE : JKGNEDDKDBK
{
	[Cpp2IlInjected.Token(Token = "0x40007F2")]
	private static readonly byte[] OEHHKNIGGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007F3")]
	private readonly byte[] AFNDJBKGMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007F4")]
	private readonly byte[] MGPONCFNDKH;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public override PPAOKKLNNOP EDAJMNNCAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x17AA440", Offset = "0x17A8A40", VA = "0x1817AA440", Slot = "8")]
		get
		{
			return default(PPAOKKLNNOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x848A9F0", Offset = "0x8488FF0", VA = "0x18848A9F0")]
	public JLKAMOANDDE([Optional] string LDEMNPMAAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x84897E0", Offset = "0x8487DE0", VA = "0x1884897E0", Slot = "9")]
	internal override void FNMOKCMKIIE(Stream OCIOHDOCJBD, long CINEDGEJAIA, long NBOIIPJHEBJ, HFEJJAMCGEP KMDNEDBDMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x8489CB0", Offset = "0x84882B0", VA = "0x188489CB0", Slot = "10")]
	internal override bool IHCPINAMKCG(Stream GEAMOGAPCBF, long CINEDGEJAIA, long NBOIIPJHEBJ, CBMPHAAPMJB JKAKMBAHLDB, [Out] HFEJJAMCGEP KMDNEDBDMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x8489BF0", Offset = "0x84881F0", VA = "0x188489BF0")]
	private void GIPBBHAMHCN(byte[] ACDPPDBEDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x848A830", Offset = "0x8488E30", VA = "0x18848A830", Slot = "11")]
	protected override FileInfo PLJCCPGMDKL(long CINEDGEJAIA, long NBOIIPJHEBJ, KNEDGBILGPM EDHLLDFNCFM, JKGCPKNFEAO MCIHPICHCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x848A720", Offset = "0x8488D20", VA = "0x18848A720", Slot = "12")]
	protected override DirectoryInfo LFOGLJEIIMM(KNEDGBILGPM EDHLLDFNCFM, JKGCPKNFEAO MCIHPICHCGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
public enum PPAOKKLNNOP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40007F8")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40007F9")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40007FA")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
internal class NDOKBCDOGGE : DKJAMFBNPLF
{
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	[CompilerGenerated]
	private sealed class ICDPOJJMLOE : IEnumerable<OPPGGNKKPPF>, IEnumerable, IEnumerator<OPPGGNKKPPF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		private OPPGGNKKPPF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000803")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		public NDOKBCDOGGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		private KNEDGBILGPM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		public KNEDGBILGPM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000807")]
		private PPAOKKLNNOP[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000808")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000809")]
		private IEnumerator<OPPGGNKKPPF> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		private OPPGGNKKPPF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0xE9CA20", Offset = "0xE9B020", VA = "0x180E9CA20")]
		[DebuggerHidden]
		public ICDPOJJMLOE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x8487340", Offset = "0x8485940", VA = "0x188487340", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x8486F60", Offset = "0x8485560", VA = "0x188486F60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x8486F10", Offset = "0x8485510", VA = "0x188486F10")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x84872F0", Offset = "0x84858F0", VA = "0x1884872F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x8487240", Offset = "0x8485840", VA = "0x188487240", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OPPGGNKKPPF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x8487240", Offset = "0x8485840", VA = "0x188487240", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007FB")]
	private readonly PPAOKKLNNOP[] FCHFFOOHCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007FC")]
	private readonly Dictionary<PPAOKKLNNOP, DKJAMFBNPLF> LGHPHIMILFB;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public PPAOKKLNNOP EDAJMNNCAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x848D910", Offset = "0x848BF10", VA = "0x18848D910", Slot = "4")]
		get
		{
			return default(PPAOKKLNNOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x848DAA0", Offset = "0x848C0A0", VA = "0x18848DAA0")]
	[UnityEngine.Scripting.Preserve]
	public NDOKBCDOGGE(params DKJAMFBNPLF[] OHJBDPAMLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x848D4F0", Offset = "0x848BAF0", VA = "0x18848D4F0", Slot = "5")]
	public bool ABCOMPDCKBM(long CINEDGEJAIA, long NBOIIPJHEBJ, KNEDGBILGPM EDHLLDFNCFM, [Out] OPPGGNKKPPF EBKHBJGGNOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x848D6D0", Offset = "0x848BCD0", VA = "0x18848D6D0")]
	private void HDHFALPBFKL(int DFGKADJLHHG, long CINEDGEJAIA, long NBOIIPJHEBJ, KNEDGBILGPM EDHLLDFNCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x848D640", Offset = "0x848BC40", VA = "0x18848D640", Slot = "6")]
	[IteratorStateMachine(typeof(ICDPOJJMLOE))]
	public IEnumerable<OPPGGNKKPPF> EGKNGFEDPFL(KNEDGBILGPM EDHLLDFNCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x848D940", Offset = "0x848BF40", VA = "0x18848D940", Slot = "7")]
	public OPPGGNKKPPF LKKBHHBBEOC(long CINEDGEJAIA, long NBOIIPJHEBJ, HFEJJAMCGEP KMDNEDBDMKJ, KNEDGBILGPM EDHLLDFNCFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
internal static class OGKNEMGCDFM
{
	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x848E580", Offset = "0x848CB80", VA = "0x18848E580")]
	internal static byte[] PCPAIAGIAKM(byte[] ACDPPDBEDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x848E320", Offset = "0x848C920", VA = "0x18848E320")]
	public static void ACDEGEEGHPM(Stream NLPKMHEBOCK, byte[] LALFPAPNFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x848E3A0", Offset = "0x848C9A0", VA = "0x18848E3A0")]
	public static bool AOIAFIBPOGK(Stream NLPKMHEBOCK, long FKFJONJGMJL, CBMPHAAPMJB BFJNEIFGILB, [Out] byte[] ACLKDALNABC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
internal sealed class JKEBHBOGLMJ : OPPGGNKKPPF, IEquatable<OPPGGNKKPPF>, IEquatable<JKEBHBOGLMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400080A")]
	private readonly JKGNEDDKDBK CPGANHOMLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400080B")]
	public readonly FileInfo LGJILMJGKLJ;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public PPAOKKLNNOP EDAJMNNCAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x7D65320", Offset = "0x7D63920", VA = "0x187D65320", Slot = "9")]
		get
		{
			return default(PPAOKKLNNOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public DateTime EGIEPOFBJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x84882D0", Offset = "0x84868D0", VA = "0x1884882D0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x8488560", Offset = "0x8486B60", VA = "0x188488560")]
	public JKEBHBOGLMJ(JKGNEDDKDBK NELIDEAEIHF, FileInfo BGOFIJFKOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(RVA = "0x84884B0", Offset = "0x8486AB0", VA = "0x1884884B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x84883F0", Offset = "0x84869F0", VA = "0x1884883F0", Slot = "5")]
	public void NFJDNJLICMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x8488290", Offset = "0x8486890", VA = "0x188488290", Slot = "6")]
	public bool GDEOLFKPCPI(long CINEDGEJAIA, long NBOIIPJHEBJ, [Out] HFEJJAMCGEP KMDNEDBDMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x8488220", Offset = "0x8486820", VA = "0x188488220", Slot = "7")]
	public bool Equals(OPPGGNKKPPF MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x8488070", Offset = "0x8486670", VA = "0x188488070", Slot = "8")]
	public bool Equals(JKEBHBOGLMJ MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(RVA = "0x8488130", Offset = "0x8486730", VA = "0x188488130", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000758")]
	[Cpp2IlInjected.Address(RVA = "0x8488360", Offset = "0x8486960", VA = "0x188488360", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
public delegate void CBMPHAAPMJB(HHPDMFCBIOB.GHCFLBOPIHD IJNDKHIBLOC, string NAAMEAFIHJI);
[Cpp2IlInjected.Token(Token = "0x20001D2")]
internal interface DKJAMFBNPLF
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	PPAOKKLNNOP EDAJMNNCAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600075C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ABCOMPDCKBM(long CINEDGEJAIA, long NBOIIPJHEBJ, KNEDGBILGPM EDHLLDFNCFM, [Out] OPPGGNKKPPF EBKHBJGGNOP);

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<OPPGGNKKPPF> EGKNGFEDPFL(KNEDGBILGPM EDHLLDFNCFM);

	[Cpp2IlInjected.Token(Token = "0x600075E")]
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
