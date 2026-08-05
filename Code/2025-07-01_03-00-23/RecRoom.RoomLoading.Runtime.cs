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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x8809A70", Offset = "0x8808070", VA = "0x188809A70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class EDBLCFBGHDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal Task<ANOBLFNCFNO> BALDEHPJPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal Task LDPFMBGEKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal CGBBDOKLCCK KLEHPABJPIO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EDBLCFBGHDL()
	{
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x88073A0", Offset = "0x88059A0", VA = "0x1888073A0", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x8818060", Offset = "0x8816660", VA = "0x188818060", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HHPFKDFBDJN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x87FE040", Offset = "0x87FC640", VA = "0x1887FE040")]
	public HHPFKDFBDJN(string CJIMOMNMAGD, Exception OGLKKFPLOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal class OHDKMECKEOC : JJLKIEEPIGM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct IIHHNIHOLDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<IReadOnlyList<NCMNMFPILFF>> <>t__builder;

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
		private TaskAwaiter<OMLCLFNIFOC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88007B0", Offset = "0x87FEDB0", VA = "0x1888007B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88009F0", Offset = "0x87FEFF0", VA = "0x1888009F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct OAIABDCIFJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<EJICOJHBPFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<List<EJICOJHBPFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8809AF0", Offset = "0x88080F0", VA = "0x188809AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8809D00", Offset = "0x8808300", VA = "0x188809D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	[UnityEngine.Scripting.Preserve]
	public OHDKMECKEOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x880A220", Offset = "0x8808820", VA = "0x18880A220", Slot = "4")]
	[AsyncStateMachine(typeof(IIHHNIHOLDM))]
	public Task<IReadOnlyList<NCMNMFPILFF>> LODLMLALJOD(long CDFGHIILPDC, long EIMKPFCNHML, [Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x880A340", Offset = "0x8808940", VA = "0x18880A340", Slot = "5")]
	[AsyncStateMachine(typeof(OAIABDCIFJC))]
	public Task<IReadOnlyList<EJICOJHBPFL>> NJJBNEFIIKE(IReadOnlyList<int> DFNPFDGIJBG, [Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DELCAOEJGBJ : IEquatable<DELCAOEJGBJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int DNMOHGBFCPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	EJICOJHBPFL DBMALGKMKEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime ILCICKMLFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	KBHKIMMHEIJ? CABBOCNNMFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	ALEBJOJBEGF? BGGPHKNGKIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	MFPDPLMDIIH IOMMONCGNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<JDKMKDKEGJC> NCDGDHGEDEH();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum MFPDPLMDIIH
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JJLKIEEPIGM
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<NCMNMFPILFF>> LODLMLALJOD(long CDFGHIILPDC, long EIMKPFCNHML, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<EJICOJHBPFL>> NJJBNEFIIKE(IReadOnlyList<int> DFNPFDGIJBG, [Optional] CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CFBMIDAHAOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class EBDHCADCFHH : DELCAOEJGBJ, IEquatable<DELCAOEJGBJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct EDMOHIEHBHA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncTaskMethodBuilder<JDKMKDKEGJC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public EBDHCADCFHH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private JFIDBHHFOOE <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private TaskAwaiter<AHDDLFMPJGL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private TaskAwaiter<JDKMKDKEGJC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x87FAEC0", Offset = "0x87F94C0", VA = "0x1887FAEC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x87FB440", Offset = "0x87F9A40", VA = "0x1887FB440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly NCMNMFPILFF APPEFJBGBAL;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int DNMOHGBFCPG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public EJICOJHBPFL DBMALGKMKEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime JNDJCBLGEMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x87FAA80", Offset = "0x87F9080", VA = "0x1887FAA80", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KBHKIMMHEIJ? CABBOCNNMFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2C10070", Offset = "0x2C0E670", VA = "0x182C10070", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ALEBJOJBEGF? BGGPHKNGKIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x87FAC50", Offset = "0x87F9250", VA = "0x1887FAC50", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MFPDPLMDIIH IOMMONCGNDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA9EFC0", Offset = "0xA9D5C0", VA = "0x180A9EFC0", Slot = "10")]
			get
			{
				return default(MFPDPLMDIIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x87FAC70", Offset = "0x87F9270", VA = "0x1887FAC70", Slot = "9")]
		[AsyncStateMachine(typeof(EDMOHIEHBHA))]
		public Task<JDKMKDKEGJC> NCDGDHGEDEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x87FAD70", Offset = "0x87F9370", VA = "0x1887FAD70")]
		public EBDHCADCFHH(int MJAPMJCAGIL, EJICOJHBPFL BKLCECLPAFO, NCMNMFPILFF APPEFJBGBAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x87FAB40", Offset = "0x87F9140", VA = "0x1887FAB40", Slot = "11")]
		public bool Equals(DELCAOEJGBJ HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x87FAAA0", Offset = "0x87F90A0", VA = "0x1887FAAA0", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x87FAA40", Offset = "0x87F9040", VA = "0x1887FAA40")]
		private bool CAKONPFNIBI(EBDHCADCFHH HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x87FABD0", Offset = "0x87F91D0", VA = "0x1887FABD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class MIILNDEGEBN : DELCAOEJGBJ, IEquatable<DELCAOEJGBJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct DAOLOOGBIHN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public AsyncTaskMethodBuilder<JDKMKDKEGJC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public MIILNDEGEBN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<JDKMKDKEGJC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x87F9F70", Offset = "0x87F8570", VA = "0x1887F9F70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x87FA1C0", Offset = "0x87F87C0", VA = "0x1887FA1C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly FOKPKNFMFMF JANKMIAJLDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly KBHKIMMHEIJ KKOKEJAENEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly ALEBJOJBEGF LJAMKNGDDLP;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int DNMOHGBFCPG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8807FA0", Offset = "0x88065A0", VA = "0x188807FA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public EJICOJHBPFL DBMALGKMKEM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8808170", Offset = "0x8806770", VA = "0x188808170", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime JNDJCBLGEMC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8807D80", Offset = "0x8806380", VA = "0x188807D80", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public KBHKIMMHEIJ? CABBOCNNMFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8807FE0", Offset = "0x88065E0", VA = "0x188807FE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ALEBJOJBEGF? BGGPHKNGKIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8808030", Offset = "0x8806630", VA = "0x188808030", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public MFPDPLMDIIH IOMMONCGNDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xC8CD50", Offset = "0xC8B350", VA = "0x180C8CD50", Slot = "10")]
			get
			{
				return default(MFPDPLMDIIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x202C850", Offset = "0x202AE50", VA = "0x18202C850")]
		public MIILNDEGEBN(FOKPKNFMFMF ICKONMFOJOH, KBHKIMMHEIJ IJLNCPNLJCK, ALEBJOJBEGF PGCBDDGHPBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8808080", Offset = "0x8806680", VA = "0x188808080", Slot = "9")]
		[AsyncStateMachine(typeof(DAOLOOGBIHN))]
		public Task<JDKMKDKEGJC> NCDGDHGEDEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8807DD0", Offset = "0x88063D0", VA = "0x188807DD0", Slot = "11")]
		public bool Equals(DELCAOEJGBJ HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8807E70", Offset = "0x8806470", VA = "0x188807E70", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8807D20", Offset = "0x8806320", VA = "0x188807D20")]
		private bool CAKONPFNIBI(MIILNDEGEBN HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8807F20", Offset = "0x8806520", VA = "0x188807F20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private sealed class KCCNFBHGPLK : DELCAOEJGBJ, IEquatable<DELCAOEJGBJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct GKEJCKMJMKB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder<JDKMKDKEGJC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<JDKMKDKEGJC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x87FD8F0", Offset = "0x87FBEF0", VA = "0x1887FD8F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x87FDB50", Offset = "0x87FC150", VA = "0x1887FDB50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly EJICOJHBPFL FPAMMOHIFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly KBHKIMMHEIJ KKOKEJAENEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly ALEBJOJBEGF LJAMKNGDDLP;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int DNMOHGBFCPG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8802B90", Offset = "0x8801190", VA = "0x188802B90", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public EJICOJHBPFL DBMALGKMKEM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime JNDJCBLGEMC
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public KBHKIMMHEIJ? CABBOCNNMFP
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8802BB0", Offset = "0x88011B0", VA = "0x188802BB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public ALEBJOJBEGF? BGGPHKNGKIO
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8802C00", Offset = "0x8801200", VA = "0x188802C00", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public MFPDPLMDIIH IOMMONCGNDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "10")]
			get
			{
				return default(MFPDPLMDIIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x202C850", Offset = "0x202AE50", VA = "0x18202C850")]
		public KCCNFBHGPLK(EJICOJHBPFL BKLCECLPAFO, KBHKIMMHEIJ IJLNCPNLJCK, ALEBJOJBEGF PGCBDDGHPBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8802C50", Offset = "0x8801250", VA = "0x188802C50", Slot = "9")]
		[AsyncStateMachine(typeof(GKEJCKMJMKB))]
		public Task<JDKMKDKEGJC> NCDGDHGEDEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8802A10", Offset = "0x8801010", VA = "0x188802A10", Slot = "11")]
		public bool Equals(DELCAOEJGBJ HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8802A80", Offset = "0x8801080", VA = "0x188802A80", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8802B00", Offset = "0x8801100", VA = "0x188802B00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8802930", Offset = "0x8800F30", VA = "0x188802930")]
		private bool CAKONPFNIBI(KCCNFBHGPLK HOPHFOOKMCC)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct HKLGBMGCHJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<IList<DELCAOEJGBJ>> <>t__builder;

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
		public CFBMIDAHAOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IReadOnlyList<NCMNMFPILFF> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<IReadOnlyList<NCMNMFPILFF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<(int accountId, EJICOJHBPFL account, NCMNMFPILFF roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x87FE0B0", Offset = "0x87FC6B0", VA = "0x1887FE0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x87FEEF0", Offset = "0x87FD4F0", VA = "0x1887FEEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct KHGCMIACCBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, EJICOJHBPFL account, NCMNMFPILFF roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IReadOnlyList<NCMNMFPILFF> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CFBMIDAHAOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<IReadOnlyList<EJICOJHBPFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x88030D0", Offset = "0x88016D0", VA = "0x1888030D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8803AE0", Offset = "0x88020E0", VA = "0x188803AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly MKEMADKGGII BGGEFIKFNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly JJLKIEEPIGM LFOLLEIEHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly OOGKMMNAEKD MEJFKJDJGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly GMAPHMCBPAK<(long, long), IReadOnlyList<NCMNMFPILFF>> JJIGNDKPKBO;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x87F9E40", Offset = "0x87F8440", VA = "0x1887F9E40")]
	[UnityEngine.Scripting.Preserve]
	public CFBMIDAHAOJ([GGNLMCAPMLP(null)] JJLKIEEPIGM CODEFBNFCAL, [GGNLMCAPMLP(null)] OOGKMMNAEKD AKNOGAPEBOE, [GGNLMCAPMLP(null)] MKEMADKGGII EOFEJNJFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x87F9BE0", Offset = "0x87F81E0", VA = "0x1887F9BE0")]
	[AsyncStateMachine(typeof(HKLGBMGCHJP))]
	public Task<IList<DELCAOEJGBJ>> CNHOCKCLFIL(long CDFGHIILPDC, long BKDNOJBOAHD, bool KKNFEOLKAKO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x87F9A40", Offset = "0x87F8040", VA = "0x1887F9A40")]
	private bool AICCGCEIHDI(DateTime? NLIOADJNELI, long CDFGHIILPDC, long BKDNOJBOAHD, [Out] FOKPKNFMFMF MFANCCGGIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x87F9D30", Offset = "0x87F8330", VA = "0x1887F9D30")]
	[AsyncStateMachine(typeof(KHGCMIACCBE))]
	private Task<IReadOnlyList<(int, EJICOJHBPFL, NCMNMFPILFF)>> EKLHHEDCBIP(IReadOnlyList<NCMNMFPILFF> KBFAAFKBLEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OOGKMMNAEKD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<FOKPKNFMFMF> OCPLILGBBGE;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NDPOIOFKENA(long CDFGHIILPDC, long BKDNOJBOAHD, IOGPAGLBJEO OOJHDNHPGCB, LHKOGNCOGAD POKKLCDMDDO);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KJIKGKEDJAL(long CDFGHIILPDC, long BKDNOJBOAHD, [Out] FOKPKNFMFMF MFANCCGGIPE);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LJNDDBJFDAL(long CDFGHIILPDC, long BKDNOJBOAHD, LHKOGNCOGAD POKKLCDMDDO, [Out] FOKPKNFMFMF MFANCCGGIPE);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PPPIHNANFAL(long CDFGHIILPDC, long BKDNOJBOAHD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface KODFNEJDPGD : NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NFKEPDHPMJF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task MPEIKIIBOJD
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFPHDOPBNJL(Task NPLKHMALANM, string FABFBBMJMHF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface GEEHHCAKHMO : NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JDKMKDKEGJC> KLGINGLOCIF(FOKPKNFMFMF MFANCCGGIPE);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AMMFMFOKAPL(CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface HMEIBBFFPJL : NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	IFDOMAFAHPI NMAKKAFAHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBFKOFALNMM();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LAICNBEBDJF();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface NIJFJDBNJOC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLMOPKJJIJF(DALKFPIOIFA GEJAMCMAAHF);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal interface NAFLOBGIDBA
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan LCDGGCMPPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan BKKLDDDJHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan CILCMLBGMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan MJBBNDJHFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool AMFLIOJLOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool CNNLNMHDJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool ILDKHBJCHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int CLECOKOEFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool HJPIJLKADOM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool GANKPBKEMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool IGBHNAJELJP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum DCKJDKPFCEO
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum ICJABCEOLMI
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
public struct DLDIJLNEIBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly long DGEHJFHKEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly long EIMKPFCNHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly DCKJDKPFCEO JLPANLJHHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[CanBeNull]
	public readonly Exception BOEIEDABPCE;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x87FAA20", Offset = "0x87F9020", VA = "0x1887FAA20")]
	public DLDIJLNEIBF(long DGEHJFHKEOG, long EIMKPFCNHML, DCKJDKPFCEO JLPANLJHHFI, [CanBeNull] Exception BOEIEDABPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x87FA9D0", Offset = "0x87F8FD0", VA = "0x1887FA9D0")]
	public static DLDIJLNEIBF APGCMCCAODE(MPGMBCPBAJA OCDJMBJBICJ, DCKJDKPFCEO JLPANLJHHFI, [Optional] Exception BOEIEDABPCE)
	{
		return default(DLDIJLNEIBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void CMDNGMGGMOD(DLDIJLNEIBF HFPKGHFHAFJ);
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface MOLNDKPIOKM : NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event CMDNGMGGMOD BBMGMJFKJMF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event CMDNGMGGMOD EAOFGCLEMNP;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event CMDNGMGGMOD DEKMMDANDKO;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<ICJABCEOLMI, bool> LIHCJFAKFML;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IIADJEEALGO(DLDIJLNEIBF HFPKGHFHAFJ);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NBOIMLPDHHB(DLDIJLNEIBF HFPKGHFHAFJ);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NNNKBBFMLJA(DLDIJLNEIBF HFPKGHFHAFJ);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AENKFDJGJFD(ICJABCEOLMI FHIJCHFCPCC, bool DDMLMBGCPOD);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface JCIIJKJNGJH : NIJFJDBNJOC, IDisposable, FNLFGFPFCLM
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool LKGCPNGHOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IEBFDEFKCLL();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface LDCCCOIGGJK : NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus BMJMMGENPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BJAEOPGDOON(MPGMBCPBAJA AEDAKEMLNJC, KOIFLJMDNHD HDCPKPPEKKC, CancellationToken BACOGCKOPIE);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class NBHPGFLBABE
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8808620", Offset = "0x8806C20", VA = "0x188808620")]
	public static bool KBKCCBKIAIL(this LDCCCOIGGJK CPBLHGLGNCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task EBGJHLDMFLM(CancellationToken DKFMAIJGPFL, int OHJBDEEMPBB, MJGCNECCLCM KIGFJAABOEN);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface GOHCGKCPCEL : NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JKNMAPAKOKH(EBGJHLDMFLM HHCEJMFBPJP);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface DALKFPIOIFA : JFIDBHHFOOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken GPBHLDGGNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	DCNOMJHNEOK GCIHOPCMPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	KEDGPMDLKIM LHLOMPMFPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	CHNOGHNCFEH EIJNCDIBHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	FKOJBBBPHKG NPBKIMIDKGK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	EPGNDILKKFC MAAOCEJIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	AOENICALHEG DMOGFJMKIOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	IKIILEMDACF KOAEIEACIJC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	GAIHMFBPIKO AJFBLIBGGMC
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	KODFNEJDPGD OCIEAHJCOBM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	GEEHHCAKHMO CAMJAKDCIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	MOLNDKPIOKM LLBBEPMKJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	JCIIJKJNGJH CIMHDJKMLPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	LDCCCOIGGJK FCHJGFPDBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	GOHCGKCPCEL BLPOCHLJOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	PBKFNKIOBNA JKLBFNCKEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	MGMGPMNGPNM GDKDNMJEMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	KFAOLFKLPPG NAFBDOFGMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	OAOALCBGOKE CGHOFJKIJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	JAMLGNMIFIP DFANEALDLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	APFHKANGDCD KPDIAKDJKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	HMOKDIKKLGL AJPLOFDHMPK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	NLNHABCLGJO JBEIECMEBEA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	AFNPPEPACEB PPEDLMPOHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	JACLPEDCCNI ONIOMINMKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	HMEIBBFFPJL LLIBPNODOGN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	NAFLOBGIDBA HIHDKLNGDFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	OGNGJGBMNNO EEJDNJOLFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	OOGKMMNAEKD MMIJCGDDLOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	FPIDAMIJABG HOGEHOKMJOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	BNKNFMABFHH NPCJIHJLKKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	JFIJFNKBJKD LFPHGNLGFLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	JOGBHPFCPAE DDGCIBCBICI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool MOCAJGHHEJI
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
	void FOIMILCJNPK(KOIFLJMDNHD KLAPMLDOMFB);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface PBKFNKIOBNA : NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EFFCNFKHGDB JDPCENHCAFL(Guid HOFBFGLIONA);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BAFGFGCDOJB(Guid HOFBFGLIONA);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KCKPLIHOBIA(Guid HOFBFGLIONA, Task JBBNLFDGKBG);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ONEDNEPPDFL(Guid HOFBFGLIONA, JDKMKDKEGJC FFGGMLGKLMP);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(JDKMKDKEGJC, Task)> GBMMKEDJDAH(Guid HOFBFGLIONA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface NEJKDIOFFPF : NIJFJDBNJOC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface MGMGPMNGPNM : NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JADGIPPKKEP(MDPCDPBDELI CJIMOMNMAGD);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAIIGKCDPCP(MDPCDPBDELI CJIMOMNMAGD);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<KOJHHCPHIHG> CLLHCHAKPEH(CancellationToken AGMPHDKNCLN);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface KFAOLFKLPPG : NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EFFCNFKHGDB APMALHGFCJN(MDPCDPBDELI PCKACHENBCH);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFNDFIJOCKF(Guid HOFBFGLIONA, Task JBBNLFDGKBG);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface OAOALCBGOKE : NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JDKMKDKEGJC> CGHOFJKIJCH(MDPCDPBDELI LJHHNBPFKDP);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface JAMLGNMIFIP : NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JBNAFHMBIJM> EBAHACFBBNO(EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, MPGMBCPBAJA AEDAKEMLNJC, CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface HMOKDIKKLGL : NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JDKMKDKEGJC GDEAAPHPHNE(KNOJHPOMDED FMDCDGBCECG);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NCHGLJAAMLH(string HIOPFIEJGKH);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface APFHKANGDCD : NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MDPCDPBDELI> PIICGANECBC(MDPCDPBDELI IPMGANOCOKF, LCHHEHIMOLC LOLNHDPCOOD, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MDPCDPBDELI> NPPEKFKBAIG(CancellationToken KMHHNOGHBLL, LCHHEHIMOLC LOLNHDPCOOD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PFFMPBIDPGL FEIPAHKIBEL(EMNCKDOLLHH KACCELMHHIB, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PFFMPBIDPGL BFEGEPMFHDB(EMNCKDOLLHH KACCELMHHIB, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface NLNHABCLGJO : NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JDKMKDKEGJC CFPMNLPKCLK(KNOJHPOMDED FMDCDGBCECG, KOJHHCPHIHG EBCFJIOFMNC);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JDKMKDKEGJC GFNAHCEAAOE(KNOJHPOMDED DKKOHDCAINF);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface CELFBJMCOIK
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	const int GAEEOBFEEGL = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, LKOPPGFEJAJ> GEFLJNHMFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action DGLPGCOONOM
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
	IReadOnlyList<Guid> PNLFOEADMNP();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task PADBLBBPEGF([Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task KJKCGMLAKKO([Optional] CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface AFNPPEPACEB
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBIADOHIHJC(LEKKPPJKHAI LOGDNHOMKLD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGOEAJHJBEB(LEKKPPJKHAI LOGDNHOMKLD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFBFKLGHOME(LEKKPPJKHAI LOGDNHOMKLD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JEBDENOFOHL(LEKKPPJKHAI LOGDNHOMKLD);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class LEKKPPJKHAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly MPGMBCPBAJA FMBFAOAPICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Dictionary<string, string> COAHNNNBDHI;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public EHMNEFALKGP<string> OIEOPLNPNME
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	public LEKKPPJKHAI(MPGMBCPBAJA GKIIDCPHJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8806610", Offset = "0x8804C10", VA = "0x188806610")]
	public LEKKPPJKHAI HLAAANKDPCC(string BLIBAMJKLIA, string KKGBKLFKCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x88066E0", Offset = "0x8804CE0", VA = "0x1888066E0")]
	public bool PMCNPFBCAFC([Out] IEnumerable<KeyValuePair<string, string>> DKNNHOGGDAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x75FDA30", Offset = "0x75FC030", VA = "0x1875FDA30")]
	public LEKKPPJKHAI FMKMDBCHOJH(EHMNEFALKGP<string> GPIJGKLDGAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface OGNGJGBMNNO
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool ELMPPPKNKOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string IKHNIJDCEHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool JOEHPGOCOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CGKPCIJLPLJ();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IPACOGLKGDO PNLAPLDDKIF(long LICAODAKGNG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GBHOJJLKKMG<HNKIFFEICOH, DGDAAPKHMFH> HAJKDBAJNED(long LICAODAKGNG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GBHOJJLKKMG<HNKIFFEICOH, AJMAHGBGLEH> OHCCNCBGEFD(long LICAODAKGNG);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GBHOJJLKKMG<long, AONOBGDNKLF> LAOEPANIFCP();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<IAAKCJFJKMO>> DNJCCACBEML(long LICAODAKGNG, IReadOnlyCollection<IAAKCJFJKMO> IHCIIOFKMEN, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HPBIMOHKJAF(long LICAODAKGNG, [Out] bool PLFHDFNFIFJ);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> KBDIAEIJPOO(byte[] IDFCIPJEKLJ, byte[] NMGICMHGEIB, IReadOnlyCollection<Guid> LPJCCHCLJGN, CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface KPCHIGHLFME
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JBNAFHMBIJM MMBKOMPANAO(long DGEHJFHKEOG, long EIMKPFCNHML, string JLBGEPDOPBL);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JBNAFHMBIJM MMBKOMPANAO(long DGEHJFHKEOG, long EIMKPFCNHML, HNKIFFEICOH IDFCIPJEKLJ, Guid? GKKPMKCEDJH, long IOFOOKADLPP, bool DIDLOKGFDGH);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JBNAFHMBIJM MMBKOMPANAO(NGFAKGBILNI POBJHICPOHD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JBNAFHMBIJM MMBKOMPANAO(AHDDLFMPJGL KFJOEOOLCGM, NCMNMFPILFF AKEFFDGOFMM);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface JFIDBHHFOOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool KBKCCBKIAIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool AJALFIPDPJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool MOCAJGHHEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	KPCHIGHLFME ABJEPJMGGAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	KOIFLJMDNHD HBNJADPDJOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event CMDNGMGGMOD BBMGMJFKJMF;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event CMDNGMGGMOD EAOFGCLEMNP;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event CMDNGMGGMOD DEKMMDANDKO;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<ICJABCEOLMI, bool> LIHCJFAKFML;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IEBFDEFKCLL();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PBNGOKLOGLC BIFPLOIMFFO();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KEHJIGNGEIF JJMJBNICMKN();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task HCEBMLIKCIG(int CPHKAGOKACI, OBKGFFDIEBB KNJBGLOGECM, Func<IOGPAGLBJEO, IOGPAGLBJEO> GPPAHEIGFPJ);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<JDKMKDKEGJC> KLGINGLOCIF(FOKPKNFMFMF ICKONMFOJOH);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task AMMFMFOKAPL(CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface EPGNDILKKFC
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool OHBECMNFCDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool NNBCHKMKNKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? JCAADEJEADD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIDJEDNCGFP(Scene EMLMFLMDLMM);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task EHLDFLKIGCP(AIJGIOEGHJD PCOFLOJEDFD, IReadOnlyList<AIJGIOEGHJD> NMFFPJJHLEK, IReadOnlyList<AIJGIOEGHJD> DLKMEIOOJNL, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OKMNNLHOPFK(Guid JJMDOACODNI, IReadOnlyList<Guid> LPJCCHCLJGN, MHICFAGLKOH KOCFJGHEPAO, [Optional] object EIMHGPOHCMA);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task PJPFNKHJAFA(IReadOnlyList<Guid> NCMNHBJMNGC, CancellationToken AEJDJBPIMJP);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AJPMMEDAFEP LAMFHIBDJJK();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task BINBJGHKMBK();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FPJMALIDCLP(GameObject JLCFNKJMHLL);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task IAOFFAOPCPB();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface FKOJBBBPHKG
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	NIBBLCAGIDJ IAEGCNMCKDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool BGLCENDKCKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool HEBNENOBAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool CAFBKOGBHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool GCBLHABLBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int ENMCKKCLDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool IPOEEOLGBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool OOPCOJJGDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int HOIPCILIANM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int NNIGBDKEAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool HKPMNCHNBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool LJKOKCCIPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool LHBIDLAFLPK
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float IGJFELHBIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<float> NJBCAECMNNH;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DCNOMJHNEOK JJMPGGJCOBL(DCNOMJHNEOK FJADHAPEHDD);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKMINBPJOJF(DCNOMJHNEOK FAIEEFHMPLL);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GGCFJILLNDO();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task MPMJEOAIKMP(EHMNEFALKGP<string>.OJMJGFAOFAB FFPANAELCAP, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JHGAKGFAFEA(float JHIEFLJEGFB);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LNMLELHGNBJ(string JNBBFCFPNMI);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<JHFENBPHJMD> KCMCKHCIFGM();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable JEHKFECPPOP(object HILCMKALFIH, JHFENBPHJMD NKIIOMEEMNC);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<BOAMAKLLGJN> IPBKEBFGPEJ();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DGDAAPKHMFH AJNEJFJPOHN(IEnumerable<BFMGGPKDIJO> MOPJNDMHEHE);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EIICDLEGIDO(int EFGKEPFKHGG);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task PKEJFOGCECM();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PMKEOOLJACJ();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool EAMDHIMAAIC();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task NJLCEHEOFFB(CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task PPIKLNMFCFE(CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<BNFMGKBHKEE> EIKIELCMMIA(DateTime FJMKDCHODDL, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> LFBEGAILJCM(CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FMFOGLOMDKM(string CJIMOMNMAGD = "", float EMDIBPDBFEG = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "25")]
	LMOOJIGPACL JICDMDGBFMC(HHKCKLCLDME KNHGOKAEHEN, KOMDHNBMFBB JJNJGNDPHAE, AJMAHGBGLEH BGEEFICGHMC, IEnumerable<PersistenceView> ACDHMCOHAGL, LKGBJCCKCII PABNCJJENCE);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NOBGFEPNGCM(AJMAHGBGLEH BGEEFICGHMC);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void OOMEHAIHELH(BFMGGPKDIJO OLLCMNMACHB, [In] LMOOJIGPACL MPBJHANHEBC);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task DBMNDLOJLEH(AJMAHGBGLEH LICGHODJFLH, bool FKGJBJMFIHM, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task GMEIJDAKKAC(CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void EPHDPCGEOHF(long CDFGHIILPDC, long EIMKPFCNHML, AHDDLFMPJGL FHNEJLIAKMI, NCMNMFPILFF DDLONOFJMNL, IOGPAGLBJEO OOJHDNHPGCB, OBKGFFDIEBB? KNJBGLOGECM, LOOEEGLMAPD? MFJMFLEELHD);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void POHGNGIEIEH(long CDFGHIILPDC, long EIMKPFCNHML, LOOEEGLMAPD? MFJMFLEELHD);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void ADBJCILBMPA(PersistenceView AMCMBAONJAO);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void MLIFEPCHJLC(string PAKPCPFHJMH, MPGMBCPBAJA GKIIDCPHJMB, EKJPCJHKEHD NJPOPCBKEDB, [Optional] string? KALCHPHJOKC, [Optional] string? KHMNKOBDGKH, [Optional] string? FJLCNJKLPKO);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool DKGPPOIJDGC(PersistenceView PHGOJDGOFOF);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool HDEPECNKFPC(BFMGGPKDIJO OLLCMNMACHB, BAHICIMNAGL JIAEOGJKHJM, [Out] ODCMNIBKEMF DKKKLDGCMAI);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task IHNOOBEAFCP(CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void IFNJIJLOBGJ();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable PMAEBFBNIMA();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void MKPLBJNKAME(AJMAHGBGLEH LICGHODJFLH, BAHICIMNAGL JIAEOGJKHJM);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> BCIIJCCJNDL(KEDGPMDLKIM ILCCHPCLICG, CancellationToken KMHHNOGHBLL, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void KGLLBGLKFIK(CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<NGFAKGBILNI> NNCGDMGCGMM(LHENEJELNFK IPMGANOCOKF);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<AHDDLFMPJGL> PABJANHBJJF(long CDFGHIILPDC, bool LIOIFMGNFGD, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<OIFNFKHALGJ> DMIFDDCCNCJ(long CDFGHIILPDC, long EIMKPFCNHML, long IOFOOKADLPP, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<NCMNMFPILFF> MEBAOGIABAO(long CDFGHIILPDC, long EIMKPFCNHML, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<BEBIDCLFPCH> FDBFLKEBHHP(long CDFGHIILPDC, Guid GDDOOCPJEOP, long? BKDNOJBOAHD, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "47")]
	GBHOJJLKKMG<BEBIDCLFPCH, IEnumerable<OIIHNAILALJ>> DDAFHBONDHH();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<FNFJCDCKIHC> CHHEGKCOGOG(string JLBGEPDOPBL, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<FNFJCDCKIHC> GNALNKBBAIA(string JLBGEPDOPBL, long CDFGHIILPDC, long EIMKPFCNHML, Guid? JJMDOACODNI, OHCCJONBAFK.GGHFKFMIGOO MODBIBDJKOA, OHCCJONBAFK.GGHFKFMIGOO NMGICMHGEIB, int CPHKAGOKACI);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool HAOJBLJEEEI();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool EJCLPHGHAJO();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool EPEEDKIFAEF(IEnumerable<ODCMNIBKEMF> ABDPKBMKCGF);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void AKPBGEDPOJO(List<GameObject> PGPGLKCOGFP);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float BAFMMMJMBJJ();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> HDNGOJIJOPO(CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> HKCMFAGFFND(string NFPDPBJAKNH, LoadSceneMode PDPNEMANIDA, bool JCEEENKJLIL, EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void JFLALBFLNJE(bool IOAJJAMFEKK);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void ENPCMLLICAG();

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void JKONILLIKOK();

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void BGBCFKLNICK(bool KAACEHAPJOM);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task<OHCCJONBAFK.GGHFKFMIGOO> KBGPJKBCPHH(byte[] ACJFHCNBBBO, OHCCJONBAFK.FNDDCPFLCMH IEOEOOPKMKJ, ICELDIABFOI CGFAPFOEDGH, [Optional] IReadOnlyCollection<string>? HJKOECHMGKH, [Optional] string? FLDKOLHPANH);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void HIHNELEOBPA(MPGMBCPBAJA EEJGNICGGAF);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task JBJKAOGKPMF(EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task GNJLEGMPJFM(EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task INHCGPDJLDO(EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task GBLPDKFBOFC(EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "77")]
	IDisposable LGEBCAAHIGL();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "78")]
	AFNFPHMPCJI EHODILJCGKD();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "79")]
	Task ACGAJCLGHEH(CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface AFNFPHMPCJI
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JJMHKHBJJGB(CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CLGDECHOANE(CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct LMOOJIGPACL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public HashSet<int> FBCHGHCJFOH;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum BNFMGKBHKEE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct HHKCKLCLDME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Guid? MLKNKNCKMID;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface NIBBLCAGIDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	MPGMBCPBAJA BMFHEBNGMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	AHDDLFMPJGL IKLKANMLENB
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	GPFDHCLPDCM JFJOOENIPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool LNHLPPLPNKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool OOPKADLDKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int GKBPNCKFJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action OECDCOAPBNC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<int> DMOGHKNKKBO;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AAADDFMBBFO();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.PPMBHKAFCJG> PMNLEFLNALK(long LICAODAKGNG, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<ODIDMJHEOOD> NAMDCAGIIOA(MPGMBCPBAJA GKIIDCPHJMB, [Optional] KOIFLJMDNHD HDCPKPPEKKC);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<ODIDMJHEOOD> KDHOAOBFBLN();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task LNJLLAJJLOC();

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(MPGMBCPBAJA, KOIFLJMDNHD) PLLCBDOBPNJ();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	PIOHADAKEMO ADCNPHIFKEH();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KEBGNMDPFJF(long LICAODAKGNG);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MGNPOJHFGPD(MPGMBCPBAJA GKIIDCPHJMB, Matchmaking.GLNHDLEJGCA HPCDHGHHCOO, (int Major, int? Minor)? AMNMJKOJOJL);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface JACLPEDCCNI
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHHPNFMJOHF([Out] IEnumerable<int> NDIEJEPJPJP);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GIFGPDHMJJA(ANCHKNHFGEI DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGFNCDJJGNE(ANCHKNHFGEI DKFMAIJGPFL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface IBBOFAPCEEH
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KJFDPFANJHK(JDKMKDKEGJC DAKFIHCINKD);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface MPIGCFEMKOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPIFLMCHAGE(OPKGHMCNGGL.DMAOBNMLONB AIEIFPMMCPP);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLLDICEAALL(OPKGHMCNGGL.DMAOBNMLONB AIEIFPMMCPP);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface AOENICALHEG : MPIGCFEMKOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JDKMKDKEGJC EDPMPCGGCPD(KNOJHPOMDED DKKOHDCAINF);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface IKIILEMDACF : MPIGCFEMKOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JDKMKDKEGJC GDEAAPHPHNE(KNOJHPOMDED GEHCGKCBEID);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface IPACOGLKGDO
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FANMKCKHALG<MEJLPLHGLFG, PELIOLHOEHA>> CHLDKPGBLNK(Guid? JJMDOACODNI, IReadOnlyCollection<IAAKCJFJKMO> HLPNFPMJBOA, IReadOnlyCollection<IAAKCJFJKMO> HLLHJGPMONJ, MJEAKCEPAAA MOGBELODMPN, long? CDFGHIILPDC, long? EIMKPFCNHML, AGHKNMPOBEI.CHKBJJABKDO KHONJAPCKBP, CancellationToken KMHHNOGHBLL, bool BNEAPDJIOBP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class MEJLPLHGLFG
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public AIJGIOEGHJD OOJCKOHKPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<AIJGIOEGHJD> GEJMPNJOLBF
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<AIJGIOEGHJD> CHCNNJBALNG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xCFEAB0", Offset = "0xCFD0B0", VA = "0x180CFEAB0")]
	public MEJLPLHGLFG(AIJGIOEGHJD NJIOALOLMMF, IReadOnlyList<AIJGIOEGHJD> BPDFFGLLKPP, IReadOnlyList<AIJGIOEGHJD> PAMJMNJLIKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface GBHOJJLKKMG<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FANMKCKHALG<OOEFICMLGFH<TData>, PELIOLHOEHA>> OBHEDEGPDBC(TGetDataArg DFPJDDAMCPC, CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class LANPOJHAFAL : DALKFPIOIFA, JFIDBHHFOOE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct BIIDEKBEPML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<JDKMKDKEGJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public LANPOJHAFAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public FOKPKNFMFMF autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<JDKMKDKEGJC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x87F8100", Offset = "0x87F6700", VA = "0x1887F8100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x87F8380", Offset = "0x87F6980", VA = "0x1887F8380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct EJNNFPELJFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public LANPOJHAFAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x87FB770", Offset = "0x87F9D70", VA = "0x1887FB770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x87FB9A0", Offset = "0x87F9FA0", VA = "0x1887FB9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class OFOEJODBMPD : IEnumerable<NIJFJDBNJOC>, IEnumerable, IEnumerator<NIJFJDBNJOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private NIJFJDBNJOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public LANPOJHAFAL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private NIJFJDBNJOC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4CD30", VA = "0x180F4E730")]
		[DebuggerHidden]
		public OFOEJODBMPD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8809D70", Offset = "0x8808370", VA = "0x188809D70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x880A1D0", Offset = "0x88087D0", VA = "0x18880A1D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x880A120", Offset = "0x8808720", VA = "0x18880A120", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NIJFJDBNJOC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x880A120", Offset = "0x8808720", VA = "0x18880A120", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly CancellationTokenSource KNKFAONDEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly DCNOMJHNEOK FAIEEFHMPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool DNDJADKEJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private BDOIMEILLOM AIBKLNIGMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private bool KCGBMMKDKLA;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public KEDGPMDLKIM LHLOMPMFPPC
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA449C0", Offset = "0xA42FC0", VA = "0x180A449C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public CHNOGHNCFEH EIJNCDIBHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA44970", Offset = "0xA42F70", VA = "0x180A44970", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA449B0", Offset = "0xA42FB0", VA = "0x180A449B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public FKOJBBBPHKG NPBKIMIDKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA44990", Offset = "0xA42F90", VA = "0x180A44990", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA44950", Offset = "0xA42F50", VA = "0x180A44950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public EPGNDILKKFC MAAOCEJIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA449A0", Offset = "0xA42FA0", VA = "0x180A449A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA44980", Offset = "0xA42F80", VA = "0x180A44980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public AOENICALHEG DMOGFJMKIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA50E50", Offset = "0xA4F450", VA = "0x180A50E50", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA50C70", Offset = "0xA4F270", VA = "0x180A50C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public IKIILEMDACF KOAEIEACIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4E0", Offset = "0xA4AAE0", VA = "0x180A4C4E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4C0", Offset = "0xA4AAC0", VA = "0x180A4C4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public KPCHIGHLFME ABJEPJMGGAI
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA4C400", Offset = "0xA4AA00", VA = "0x180A4C400", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2F0", Offset = "0xA4A8F0", VA = "0x180A4C2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public GAIHMFBPIKO AJFBLIBGGMC
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA4C410", Offset = "0xA4AA10", VA = "0x180A4C410", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA4C320", Offset = "0xA4A920", VA = "0x180A4C320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public KODFNEJDPGD OCIEAHJCOBM
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xAB07D0", Offset = "0xAAEDD0", VA = "0x180AB07D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAADC60", VA = "0x180AAF660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public GEEHHCAKHMO CAMJAKDCIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA4C3C0", Offset = "0xA4A9C0", VA = "0x180A4C3C0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA4C440", Offset = "0xA4AA40", VA = "0x180A4C440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public MOLNDKPIOKM LLBBEPMKJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xAB0BF0", Offset = "0xAAF1F0", VA = "0x180AB0BF0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xF26510", Offset = "0xF24B10", VA = "0x180F26510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public JCIIJKJNGJH CIMHDJKMLPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA51E60", Offset = "0xA50460", VA = "0x180A51E60", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA51EE0", Offset = "0xA504E0", VA = "0x180A51EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public LDCCCOIGGJK FCHJGFPDBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xE23A60", Offset = "0xE22060", VA = "0x180E23A60", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xF2B480", Offset = "0xF29A80", VA = "0x180F2B480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public GOHCGKCPCEL BLPOCHLJOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xAD80E0", Offset = "0xAD66E0", VA = "0x180AD80E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAD8100", Offset = "0xAD6700", VA = "0x180AD8100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public PBKFNKIOBNA JKLBFNCKEGE
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xAD80F0", Offset = "0xAD66F0", VA = "0x180AD80F0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xAD8130", Offset = "0xAD6730", VA = "0x180AD8130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public NEJKDIOFFPF BCCNDJOIPML
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xAD80D0", Offset = "0xAD66D0", VA = "0x180AD80D0", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xAD80B0", Offset = "0xAD66B0", VA = "0x180AD80B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public MGMGPMNGPNM GDKDNMJEMLH
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xAD2FA0", Offset = "0xAD15A0", VA = "0x180AD2FA0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xACBF50", Offset = "0xACA550", VA = "0x180ACBF50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public KFAOLFKLPPG NAFBDOFGMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA51ED0", Offset = "0xA504D0", VA = "0x180A51ED0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA51EB0", Offset = "0xA504B0", VA = "0x180A51EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public OAOALCBGOKE CGHOFJKIJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xAD32B0", Offset = "0xAD18B0", VA = "0x180AD32B0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xACB8B0", Offset = "0xAC9EB0", VA = "0x180ACB8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public JAMLGNMIFIP DFANEALDLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xB6EA90", Offset = "0xB6D090", VA = "0x180B6EA90", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xB6D910", Offset = "0xB6BF10", VA = "0x180B6D910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public APFHKANGDCD KPDIAKDJKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xB66EA0", Offset = "0xB654A0", VA = "0x180B66EA0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xB55540", Offset = "0xB53B40", VA = "0x180B55540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public HMOKDIKKLGL AJPLOFDHMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAD3200", Offset = "0xAD1800", VA = "0x180AD3200", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xACBF30", Offset = "0xACA530", VA = "0x180ACBF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public NLNHABCLGJO JBEIECMEBEA
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAD3440", Offset = "0xAD1A40", VA = "0x180AD3440", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xACF930", VA = "0x180AD1330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public AFNPPEPACEB PPEDLMPOHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xAD32E0", Offset = "0xAD18E0", VA = "0x180AD32E0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xAD3620", Offset = "0xAD1C20", VA = "0x180AD3620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public JACLPEDCCNI ONIOMINMKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xAD2FB0", Offset = "0xAD15B0", VA = "0x180AD2FB0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAD34A0", Offset = "0xAD1AA0", VA = "0x180AD34A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public HMEIBBFFPJL LLIBPNODOGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xB12E50", Offset = "0xB11450", VA = "0x180B12E50", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xB0DC90", Offset = "0xB0C290", VA = "0x180B0DC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public NAFLOBGIDBA HIHDKLNGDFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xB5B440", Offset = "0xB59A40", VA = "0x180B5B440", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xB60F60", Offset = "0xB5F560", VA = "0x180B60F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public OGNGJGBMNNO EEJDNJOLFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xAD3340", Offset = "0xAD1940", VA = "0x180AD3340", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xACAD60", Offset = "0xAC9360", VA = "0x180ACAD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public OOGKMMNAEKD MMIJCGDDLOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xAD2F90", Offset = "0xAD1590", VA = "0x180AD2F90", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public FPIDAMIJABG HOGEHOKMJOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xB5A210", Offset = "0xB58810", VA = "0x180B5A210", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public BNKNFMABFHH NPCJIHJLKKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xB5C6A0", Offset = "0xB5ACA0", VA = "0x180B5C6A0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public JFIJFNKBJKD LFPHGNLGFLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xB5E6D0", Offset = "0xB5CCD0", VA = "0x180B5E6D0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public JOGBHPFCPAE DDGCIBCBICI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xB72A80", Offset = "0xB71080", VA = "0x180B72A80", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public KOIFLJMDNHD HBNJADPDJOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xB5DCF0", Offset = "0xB5C2F0", VA = "0x180B5DCF0", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xCDA370", Offset = "0xCD8970", VA = "0x180CDA370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool EFDGICNMAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x88053F0", Offset = "0x88039F0", VA = "0x1888053F0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool BMDBPALPBPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8806030", Offset = "0x8804630", VA = "0x188806030", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool JKDMINANFHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4820", Offset = "0x1DE2E20", VA = "0x181DE4820", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken MHBEBAJOKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8805530", Offset = "0x8803B30", VA = "0x188805530", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private DCNOMJHNEOK JHBJPIPEAOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool GKNEJCBOCAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4820", Offset = "0x1DE2E20", VA = "0x181DE4820", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1570", Offset = "0x1DDFB70", VA = "0x181DE1570", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event CMDNGMGGMOD AIGENLNBCBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8805FD0", Offset = "0x88045D0", VA = "0x188805FD0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8805390", Offset = "0x8803990", VA = "0x188805390", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event CMDNGMGGMOD PMEHHAKDMPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8805DA0", Offset = "0x88043A0", VA = "0x188805DA0", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8805330", Offset = "0x8803930", VA = "0x188805330", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event CMDNGMGGMOD KFLPEEMCPFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8805F10", Offset = "0x8804510", VA = "0x188805F10", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x88057A0", Offset = "0x8803DA0", VA = "0x1888057A0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event Action<ICJABCEOLMI, bool> ECDNIOGIDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x88052D0", Offset = "0x88038D0", VA = "0x1888052D0", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x88054D0", Offset = "0x8803AD0", VA = "0x1888054D0", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xCDA370", Offset = "0xCD8970", VA = "0x180CDA370", Slot = "39")]
	public void FOIMILCJNPK(KOIFLJMDNHD KLAPMLDOMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8806140", Offset = "0x8804740", VA = "0x188806140")]
	[UnityEngine.Scripting.Preserve]
	internal LANPOJHAFAL([GGNLMCAPMLP(null)] DCNOMJHNEOK FAIEEFHMPLL, [GGNLMCAPMLP(null)] KEDGPMDLKIM ILCCHPCLICG, [GGNLMCAPMLP(null)] CHNOGHNCFEH COCHLDFDDJA, [GGNLMCAPMLP(null)] FKOJBBBPHKG ACIHABPADPI, [GGNLMCAPMLP(null)] EPGNDILKKFC ILJDNFDKCIL, [GGNLMCAPMLP(null)] AOENICALHEG HMGHLOHDLHJ, [GGNLMCAPMLP(null)] IKIILEMDACF PPLAKJAADCA, [GGNLMCAPMLP(null)] GAIHMFBPIKO ACEKANILHJD, [GGNLMCAPMLP(null)] KODFNEJDPGD JNOFNLPKHAH, [GGNLMCAPMLP(null)] GEEHHCAKHMO MNMHIDNJEFM, [GGNLMCAPMLP(null)] MOLNDKPIOKM KLGCFGPCNMD, [GGNLMCAPMLP(null)] JCIIJKJNGJH EECPDJPICPL, [GGNLMCAPMLP(null)] LDCCCOIGGJK CPBLHGLGNCP, [GGNLMCAPMLP(null)] GOHCGKCPCEL ILFFCOLMGAE, [GGNLMCAPMLP(null)] PBKFNKIOBNA MOJOKMILBMJ, [GGNLMCAPMLP(null)] NEJKDIOFFPF NODADMGOBIC, [GGNLMCAPMLP(null)] MGMGPMNGPNM GOPFBMIMGPG, [GGNLMCAPMLP(null)] KFAOLFKLPPG HKFGJNBIMHL, [GGNLMCAPMLP(null)] OAOALCBGOKE ACDEKEPALAE, [GGNLMCAPMLP(null)] JAMLGNMIFIP NKKBJCNHIPM, [GGNLMCAPMLP(null)] HMOKDIKKLGL FNHPJNIGBNI, [GGNLMCAPMLP(null)] APFHKANGDCD LGIMMCIELII, [GGNLMCAPMLP(null)] NLNHABCLGJO GPKNAFMKICD, [GGNLMCAPMLP(null)] AFNPPEPACEB BAGFKPOBCJE, [GGNLMCAPMLP(null)] JACLPEDCCNI JBOGAGFKBNI, [GGNLMCAPMLP(null)] NAFLOBGIDBA HHBGHAKIGCN, [GGNLMCAPMLP(null)] OGNGJGBMNNO HINGNPFBBIL, [GGNLMCAPMLP(null)] OOGKMMNAEKD FHGHABCDCNA, [GGNLMCAPMLP(null)] FPIDAMIJABG IFMBECNOOLN, [GGNLMCAPMLP(null)] BNKNFMABFHH AIIKLDGAOKH, [GGNLMCAPMLP(null)] JFIJFNKBJKD GMKLHHKBNBD, [GGNLMCAPMLP(null)] JOGBHPFCPAE BACJBJFNCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x88056F0", Offset = "0x8803CF0", VA = "0x1888056F0")]
	private void FLMOPKJJIJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x8805550", Offset = "0x8803B50", VA = "0x188805550", Slot = "59")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x8805280", Offset = "0x8803880", VA = "0x188805280", Slot = "51")]
	private void AMGMAHFENLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x88060B0", Offset = "0x88046B0", VA = "0x1888060B0", Slot = "52")]
	private PBNGOKLOGLC PLIEGAFODFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8805C20", Offset = "0x8804220", VA = "0x188805C20", Slot = "53")]
	private KEHJIGNGEIF IEHAPGJIKHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x8805800", Offset = "0x8803E00", VA = "0x188805800", Slot = "55")]
	public Task HCEBMLIKCIG(int CPHKAGOKACI, OBKGFFDIEBB KNJBGLOGECM, Func<IOGPAGLBJEO, IOGPAGLBJEO> GPPAHEIGFPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x8805E00", Offset = "0x8804400", VA = "0x188805E00")]
	private FNAKBHDMGAB KIPMFLCPMPC(int CPHKAGOKACI, OBKGFFDIEBB KNJBGLOGECM, Func<IOGPAGLBJEO, IOGPAGLBJEO> GPPAHEIGFPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8805B10", Offset = "0x8804110", VA = "0x188805B10", Slot = "56")]
	[AsyncStateMachine(typeof(BIIDEKBEPML))]
	private Task<JDKMKDKEGJC> IEHAKFDNKMG(FOKPKNFMFMF MFANCCGGIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8805CB0", Offset = "0x88042B0", VA = "0x188805CB0", Slot = "57")]
	[AsyncStateMachine(typeof(EJNNFPELJFG))]
	private Task JJEJCMBFLHC(CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8805450", Offset = "0x8803A50", VA = "0x188805450")]
	[IteratorStateMachine(typeof(OFOEJODBMPD))]
	private IEnumerable<NIJFJDBNJOC> DFOKDNCEGCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8805F70", Offset = "0x8804570", VA = "0x188805F70")]
	[CompilerGenerated]
	private void NCPLDKFCLMC(NIJFJDBNJOC DNCHHBPCLHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class CPKAEOEKBMI : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x19A8E00", Offset = "0x19A7400", VA = "0x1819A8E00")]
	public CPKAEOEKBMI(string CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class LHDJCMPJHHC : ADPHJGAIKIC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct BJNMADMJPDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder<ADPHJGAIKIC.MPEPGDHIMCP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public HashSet<FNLFGFPFCLM.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public LHDJCMPJHHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x87F8DC0", Offset = "0x87F73C0", VA = "0x1887F8DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x87F90D0", Offset = "0x87F76D0", VA = "0x1887F90D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly DALKFPIOIFA GEJAMCMAAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly FKOJBBBPHKG ACIHABPADPI;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string BFPCHNMONKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8806880", Offset = "0x8804E80", VA = "0x188806880", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0xA4BEA0", Offset = "0xA4A4A0", VA = "0x180A4BEA0")]
	public LHDJCMPJHHC(DALKFPIOIFA GEJAMCMAAHF, FKOJBBBPHKG ACIHABPADPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x8806770", Offset = "0x8804D70", VA = "0x188806770", Slot = "5")]
	[AsyncStateMachine(typeof(BJNMADMJPDN))]
	public Task<ADPHJGAIKIC.MPEPGDHIMCP> MNOHFHPCKLB(HashSet<FNLFGFPFCLM.Reason> FAENGDADNFA, CancellationToken KMHHNOGHBLL, FNLFGFPFCLM.Reason CIOGCOOPLBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class JHBOPMJGBDL : BPGOEHHKGEP, ADPHJGAIKIC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct JNIPAHJCFKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<ADPHJGAIKIC.MPEPGDHIMCP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public JHBOPMJGBDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public HashSet<FNLFGFPFCLM.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public FNLFGFPFCLM.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private MPGMBCPBAJA <localRoomInstance>5__2;

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
		private TaskAwaiter<ADPHJGAIKIC.MPEPGDHIMCP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8801EF0", Offset = "0x88004F0", VA = "0x188801EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x88028C0", Offset = "0x8800EC0", VA = "0x1888028C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly IJMNBIIDPGK LDADKFPMBGB;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string BFPCHNMONKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8801290", Offset = "0x87FF890", VA = "0x188801290", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8801340", Offset = "0x87FF940", VA = "0x188801340")]
	public JHBOPMJGBDL([GGNLMCAPMLP(null)] DALKFPIOIFA GEJAMCMAAHF, [GGNLMCAPMLP(null)] FKOJBBBPHKG ACIHABPADPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8801140", Offset = "0x87FF740", VA = "0x188801140", Slot = "5")]
	[AsyncStateMachine(typeof(JNIPAHJCFKJ))]
	public Task<ADPHJGAIKIC.MPEPGDHIMCP> MNOHFHPCKLB(HashSet<FNLFGFPFCLM.Reason> FAENGDADNFA, CancellationToken KMHHNOGHBLL, FNLFGFPFCLM.Reason CIOGCOOPLBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class GGDIJJKLEBB : BPGOEHHKGEP, ADPHJGAIKIC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct OPBHBFDHJGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<ADPHJGAIKIC.MPEPGDHIMCP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public GGDIJJKLEBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public HashSet<FNLFGFPFCLM.Reason> fallbackTriggersToIgnore;

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
		private TaskAwaiter<ODIDMJHEOOD> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<ADPHJGAIKIC.MPEPGDHIMCP> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x880AC20", Offset = "0x8809220", VA = "0x18880AC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x880B610", Offset = "0x8809C10", VA = "0x18880B610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string BFPCHNMONKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x87FC8B0", Offset = "0x87FAEB0", VA = "0x1887FC8B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0xA4BEA0", Offset = "0xA4A4A0", VA = "0x180A4BEA0")]
	public GGDIJJKLEBB(DALKFPIOIFA GEJAMCMAAHF, FKOJBBBPHKG ACIHABPADPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x87FC760", Offset = "0x87FAD60", VA = "0x1887FC760", Slot = "5")]
	[AsyncStateMachine(typeof(OPBHBFDHJGI))]
	public Task<ADPHJGAIKIC.MPEPGDHIMCP> MNOHFHPCKLB(HashSet<FNLFGFPFCLM.Reason> FAENGDADNFA, CancellationToken KMHHNOGHBLL, FNLFGFPFCLM.Reason CIOGCOOPLBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class LPCFHBMANHD : BPGOEHHKGEP, ADPHJGAIKIC
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class JECEMDNLHBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public ODIDMJHEOOD matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public MPGMBCPBAJA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public JECEMDNLHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8800C20", Offset = "0x87FF220", VA = "0x188800C20")]
		internal object HLPGLAHDEPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8800B60", Offset = "0x87FF160", VA = "0x188800B60")]
		internal object ABBJPKDFAHJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct HMJGGPDNCID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<ADPHJGAIKIC.MPEPGDHIMCP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public LPCFHBMANHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public HashSet<FNLFGFPFCLM.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private JECEMDNLHBD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public FNLFGFPFCLM.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter<ODIDMJHEOOD> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter<ADPHJGAIKIC.MPEPGDHIMCP> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x87FEF60", Offset = "0x87FD560", VA = "0x1887FEF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x87FFC00", Offset = "0x87FE200", VA = "0x1887FFC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly IJMNBIIDPGK LDADKFPMBGB;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string BFPCHNMONKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8807220", Offset = "0x8805820", VA = "0x188807220", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x88072D0", Offset = "0x88058D0", VA = "0x1888072D0")]
	public LPCFHBMANHD([GGNLMCAPMLP(null)] DALKFPIOIFA GEJAMCMAAHF, [GGNLMCAPMLP(null)] FKOJBBBPHKG ACIHABPADPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x88070D0", Offset = "0x88056D0", VA = "0x1888070D0", Slot = "5")]
	[AsyncStateMachine(typeof(HMJGGPDNCID))]
	public Task<ADPHJGAIKIC.MPEPGDHIMCP> MNOHFHPCKLB(HashSet<FNLFGFPFCLM.Reason> FAENGDADNFA, CancellationToken KMHHNOGHBLL, FNLFGFPFCLM.Reason CIOGCOOPLBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class BPGOEHHKGEP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct LALOPKNGKLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public LHMKAIAPMBI log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public HashSet<FNLFGFPFCLM.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public BPGOEHHKGEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private List<FNLFGFPFCLM.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8804D00", Offset = "0x8803300", VA = "0x188804D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8805220", Offset = "0x8803820", VA = "0x188805220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	protected readonly DALKFPIOIFA GEJAMCMAAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	protected readonly FKOJBBBPHKG ACIHABPADPI;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected NIBBLCAGIDJ IAEGCNMCKDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x87F9270", Offset = "0x87F7870", VA = "0x1887F9270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0xA4BEA0", Offset = "0xA4A4A0", VA = "0x180A4BEA0")]
	public BPGOEHHKGEP(DALKFPIOIFA GEJAMCMAAHF, FKOJBBBPHKG ACIHABPADPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x87F9140", Offset = "0x87F7740", VA = "0x1887F9140")]
	[AsyncStateMachine(typeof(LALOPKNGKLN))]
	protected Task NFAFJMHIABP(LHMKAIAPMBI NDJJBNFFFGK, HashSet<FNLFGFPFCLM.Reason> FAENGDADNFA, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class KDGJKGCCFFL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct ICFMOCIAMOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder<ADPHJGAIKIC.MPEPGDHIMCP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public FKOJBBBPHKG callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8800040", Offset = "0x87FE640", VA = "0x188800040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x88003C0", Offset = "0x87FE9C0", VA = "0x1888003C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class IJJDFLPEHDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public DALKFPIOIFA roomManager;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public IJJDFLPEHDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8800A60", Offset = "0x87FF060", VA = "0x188800A60")]
		internal object OAGFLLEAEFD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static readonly float PBBJLGJAEAE;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	internal static readonly HashSet<FNLFGFPFCLM.Reason> LMGGJGPKGJJ;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8802D20", Offset = "0x8801320", VA = "0x188802D20")]
	[AsyncStateMachine(typeof(ICFMOCIAMOH))]
	internal static Task<ADPHJGAIKIC.MPEPGDHIMCP> MHNFFFLPBIN(FKOJBBBPHKG ACIHABPADPI, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8802E30", Offset = "0x8801430", VA = "0x188802E30")]
	internal static void PGLLFMKDLAA(DALKFPIOIFA GEJAMCMAAHF, LHMKAIAPMBI NDJJBNFFFGK, string PAKPCPFHJMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface ADPHJGAIKIC
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct MPEPGDHIMCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool DDMLMBGCPOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public FNLFGFPFCLM.Reason CIOGCOOPLBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Enum? FJLCNJKLPKO;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8808610", Offset = "0x8806C10", VA = "0x188808610")]
		public static MPEPGDHIMCP NMGKKEJKHDO()
		{
			return default(MPEPGDHIMCP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x88085E0", Offset = "0x8806BE0", VA = "0x1888085E0")]
		public static MPEPGDHIMCP GGEOPAPODEJ(FNLFGFPFCLM.Reason CIOGCOOPLBM, [Optional] Enum? FJLCNJKLPKO)
		{
			return default(MPEPGDHIMCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string CBKDAAKMPFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MPEPGDHIMCP> MNOHFHPCKLB(HashSet<FNLFGFPFCLM.Reason> FAENGDADNFA, CancellationToken KMHHNOGHBLL, FNLFGFPFCLM.Reason CIOGCOOPLBM);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct NGOPJHNEDLG
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class EFBCNBJCBCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public DALKFPIOIFA manager;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public EFBCNBJCBCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x87FB4B0", Offset = "0x87F9AB0", VA = "0x1887FB4B0")]
		internal Task OHFEFGMCGJD(CancellationToken cancellationToken, int roomTotalVersion, MJGCNECCLCM localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct PLMDEEGLLIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public NGOPJHNEDLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private FOKPKNFMFMF <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter<BNFMGKBHKEE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private TaskAwaiter<JDKMKDKEGJC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8816780", Offset = "0x8814D80", VA = "0x188816780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8816D10", Offset = "0x8815310", VA = "0x188816D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct ICOEPLIHPEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public NGOPJHNEDLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8800430", Offset = "0x87FEA30", VA = "0x188800430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8800750", Offset = "0x87FED50", VA = "0x188800750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly CancellationToken KMHHNOGHBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly DALKFPIOIFA MIPDPIDNIBN;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private KEDGPMDLKIM LHLOMPMFPPC
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x88088F0", Offset = "0x8806EF0", VA = "0x1888088F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private FKOJBBBPHKG NPBKIMIDKGK
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x88086C0", Offset = "0x8806CC0", VA = "0x1888086C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private NIBBLCAGIDJ IAEGCNMCKDC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8808D30", Offset = "0x8807330", VA = "0x188808D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private GEEHHCAKHMO CAMJAKDCIJN
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8808670", Offset = "0x8806C70", VA = "0x188808670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x298A840", Offset = "0x2988E40", VA = "0x18298A840")]
	public NGOPJHNEDLG(CancellationToken KMHHNOGHBLL, DALKFPIOIFA MIPDPIDNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8808C80", Offset = "0x8807280", VA = "0x188808C80")]
	public static EBGJHLDMFLM PBLAMDEKPCN(DALKFPIOIFA MIPDPIDNIBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x88087E0", Offset = "0x8806DE0", VA = "0x1888087E0")]
	[AsyncStateMachine(typeof(PLMDEEGLLIJ))]
	public Task<bool> JNJJALJCEOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8808940", Offset = "0x8806F40", VA = "0x188808940")]
	private bool KPGMHOAAHJJ([Out] FOKPKNFMFMF MFANCCGGIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8808710", Offset = "0x8806D10", VA = "0x188808710")]
	[AsyncStateMachine(typeof(ICOEPLIHPEF))]
	private Task INBMPEJGNIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8808B50", Offset = "0x8807150", VA = "0x188808B50")]
	private Task<BNFMGKBHKEE> PBGHMIEMJAH(FOKPKNFMFMF HFOOKKLCPPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct EFFCNFKHGDB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly PBKFNKIOBNA MOJOKMILBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Guid HOFBFGLIONA;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(JDKMKDKEGJC, Task)> EAABGLLOBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x87FB5D0", Offset = "0x87F9BD0", VA = "0x1887FB5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5370100", Offset = "0x536E700", VA = "0x185370100")]
	public EFFCNFKHGDB(PBKFNKIOBNA MOJOKMILBMJ, Guid HOFBFGLIONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x87FB6A0", Offset = "0x87F9CA0", VA = "0x1887FB6A0")]
	public TaskAwaiter<(JDKMKDKEGJC, Task)> MJAODGLODJM()
	{
		return default(TaskAwaiter<(JDKMKDKEGJC, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x87FB500", Offset = "0x87F9B00", VA = "0x1887FB500", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct MJLLDLFKGDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly TaskCompletionSource<(JDKMKDKEGJC, Task)> FEOIJMDGILN;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(JDKMKDKEGJC, Task)> EAABGLLOBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x88082F0", Offset = "0x88068F0", VA = "0x1888082F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x8808450", Offset = "0x8806A50", VA = "0x188808450")]
	public MJLLDLFKGDN(TimeSpan GHMHNEFJOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8808250", Offset = "0x8806850", VA = "0x188808250")]
	public void EGJCHCPDLMI(Task JBBNLFDGKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8808330", Offset = "0x8806930", VA = "0x188808330")]
	public void NEGIPCMGIPI(JDKMKDKEGJC DAKFIHCINKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8808200", Offset = "0x8806800", VA = "0x188808200")]
	public void DNLEAHBEPKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x88083C0", Offset = "0x88069C0", VA = "0x1888083C0")]
	internal void OKJILGABLHJ(string CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class HCEOMOMHADO
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x87FDD10", Offset = "0x87FC310", VA = "0x1887FDD10")]
	public static JBNAFHMBIJM MOBHKKAMDOO(this JBNAFHMBIJM INCLIAEIKDJ, AHDDLFMPJGL ODFHPPAIFIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x87FDEB0", Offset = "0x87FC4B0", VA = "0x1887FDEB0")]
	public static JBNAFHMBIJM NJEBLFLEJIH(this JBNAFHMBIJM INCLIAEIKDJ, NCMNMFPILFF JLDNHKMHEJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class CDJFMLFBDAN : KPCHIGHLFME
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class GEPMPAJNHDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public NCMNMFPILFF subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public GEPMPAJNHDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x87FC730", Offset = "0x87FAD30", VA = "0x1887FC730")]
		internal bool GDEPMLGIIBE(GPFDHCLPDCM s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly NAFLOBGIDBA FIMJIBOPEDA;

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	public CDJFMLFBDAN(NAFLOBGIDBA HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x87F9570", Offset = "0x87F7B70", VA = "0x1887F9570", Slot = "4")]
	public JBNAFHMBIJM MMBKOMPANAO(long DGEHJFHKEOG, long EIMKPFCNHML, string JLBGEPDOPBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x87F98E0", Offset = "0x87F7EE0", VA = "0x1887F98E0", Slot = "5")]
	public JBNAFHMBIJM MMBKOMPANAO(long DGEHJFHKEOG, long EIMKPFCNHML, HNKIFFEICOH IDFCIPJEKLJ, Guid? GKKPMKCEDJH, long IOFOOKADLPP, bool DIDLOKGFDGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x87F9370", Offset = "0x87F7970", VA = "0x1887F9370", Slot = "6")]
	public JBNAFHMBIJM MMBKOMPANAO(NGFAKGBILNI POBJHICPOHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x87F9600", Offset = "0x87F7C00", VA = "0x1887F9600", Slot = "7")]
	public JBNAFHMBIJM MMBKOMPANAO(AHDDLFMPJGL KFJOEOOLCGM, NCMNMFPILFF AKEFFDGOFMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x87F92C0", Offset = "0x87F78C0", VA = "0x1887F92C0")]
	private Guid? LCCCDLIKLKJ(AHDDLFMPJGL NPENBLMBFGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class HNILHCAFHEP : KODFNEJDPGD, NIJFJDBNJOC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct NNINJKGMLME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public HNILHCAFHEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8809370", Offset = "0x8807970", VA = "0x188809370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8809A10", Offset = "0x8808010", VA = "0x188809A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly ANCHKNHFGEI MLFDMHJEHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private string LHJJEDKNPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Task ENOAHEDDNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private DALKFPIOIFA GEJAMCMAAHF;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool NFKEPDHPMJF
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x87FFD90", Offset = "0x87FE390", VA = "0x1887FFD90", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task MPEIKIIBOJD
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x87FFDC0", Offset = "0x87FE3C0", VA = "0x1887FFDC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10", Slot = "7")]
	public void FLMOPKJJIJF(DALKFPIOIFA GEJAMCMAAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x87FFE50", Offset = "0x87FE450", VA = "0x1887FFE50", Slot = "6")]
	public void PFPHDOPBNJL(Task NPLKHMALANM, string FABFBBMJMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x87FFC70", Offset = "0x87FE270", VA = "0x1887FFC70")]
	[AsyncStateMachine(typeof(NNINJKGMLME))]
	private Task DAGACKNMBDA(Task DNOLAMGPFHN, string FABFBBMJMHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x87FFFB0", Offset = "0x87FE5B0", VA = "0x1887FFFB0")]
	public HNILHCAFHEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class JGCOPJPKKPJ : HMEIBBFFPJL, NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private bool EACBJFJJDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private IFDOMAFAHPI JHNEAPFDAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private KEDGPMDLKIM ILCCHPCLICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NAFLOBGIDBA HHBGHAKIGCN;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public IFDOMAFAHPI NMAKKAFAHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8800F20", Offset = "0x87FF520", VA = "0x188800F20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8800DA0", Offset = "0x87FF3A0", VA = "0x188800DA0", Slot = "7")]
	public void FLMOPKJJIJF(DALKFPIOIFA GEJAMCMAAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x8800F90", Offset = "0x87FF590", VA = "0x188800F90", Slot = "5")]
	public void IBFKOFALNMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x8800CA0", Offset = "0x87FF2A0", VA = "0x188800CA0", Slot = "6")]
	public void LAICNBEBDJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x8800CE0", Offset = "0x87FF2E0", VA = "0x188800CE0")]
	private Task FHLMNGKINJH(OAJNBKMEPPG HKKDKDDKEBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x8800CA0", Offset = "0x87FF2A0", VA = "0x188800CA0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public JGCOPJPKKPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class LINBFMCKKLG : NAFLOBGIDBA
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class MOLPFMKMBEM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly MFFKJDDAJBP HINKJLIAKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly string BLIBAMJKLIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly T COMAGLLDBOM;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T IBMJNNAJGNM
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xAC2F90", Offset = "0xAC1590", VA = "0x180AC2F90")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xAC2F80", Offset = "0xAC1580", VA = "0x180AC2F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x561DBF0", Offset = "0x561C1F0", VA = "0x18561DBF0")]
		public MOLPFMKMBEM(MFFKJDDAJBP HINKJLIAKGN, string BLIBAMJKLIA, T COMAGLLDBOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x561D610", Offset = "0x561BC10", VA = "0x18561D610")]
		private void HIKEFHDJDKC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly MFFKJDDAJBP HINKJLIAKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly MOLPFMKMBEM<TimeSpan> GLPICIPOPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly MOLPFMKMBEM<TimeSpan> JDGKBALFBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly MOLPFMKMBEM<TimeSpan> KKJBCPJINED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly MOLPFMKMBEM<TimeSpan> IFJCMMJIABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly MOLPFMKMBEM<bool> CIFKOAFJFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly MOLPFMKMBEM<bool> CIACNKDADOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly MOLPFMKMBEM<bool> LKBAPLOLJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly MOLPFMKMBEM<int> JOMIBJCDAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly MOLPFMKMBEM<bool> ONEMPHCGJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly MOLPFMKMBEM<bool> ABGGGMGKKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly MOLPFMKMBEM<NDAOEIDIMDM> CJMANMLLFJE;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan LCDGGCMPPDO
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8806A40", Offset = "0x8805040", VA = "0x188806A40", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan BKKLDDDJHKB
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8806BC0", Offset = "0x88051C0", VA = "0x188806BC0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan CILCMLBGMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8806B80", Offset = "0x8805180", VA = "0x188806B80", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan MJBBNDJHFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8806A80", Offset = "0x8805080", VA = "0x188806A80", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool AMFLIOJLOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8806980", Offset = "0x8804F80", VA = "0x188806980", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool CNNLNMHDJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8806AC0", Offset = "0x88050C0", VA = "0x188806AC0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool ILDKHBJCHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x88069C0", Offset = "0x8804FC0", VA = "0x1888069C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int CLECOKOEFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8806B00", Offset = "0x8805100", VA = "0x188806B00", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool HJPIJLKADOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8806A00", Offset = "0x8805000", VA = "0x188806A00", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool GANKPBKEMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8806B40", Offset = "0x8805140", VA = "0x188806B40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool IGBHNAJELJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8806930", Offset = "0x8804F30", VA = "0x188806930", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x8806C00", Offset = "0x8805200", VA = "0x188806C00")]
	[UnityEngine.Scripting.Preserve]
	public LINBFMCKKLG([GGNLMCAPMLP(null)] MFFKJDDAJBP HINKJLIAKGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class OHMMOANNOAM : MOLNDKPIOKM, NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class POBIJGHFONP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public DLDIJLNEIBF roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public POBIJGHFONP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8816D80", Offset = "0x8815380", VA = "0x188816D80")]
		internal object BCGELPANIDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event CMDNGMGGMOD BBMGMJFKJMF
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x880AA80", Offset = "0x8809080", VA = "0x18880AA80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x880A940", Offset = "0x8808F40", VA = "0x18880A940", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event CMDNGMGGMOD EAOFGCLEMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x880A9E0", Offset = "0x8808FE0", VA = "0x18880A9E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x880A6A0", Offset = "0x8808CA0", VA = "0x18880A6A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event CMDNGMGGMOD DEKMMDANDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x880A4A0", Offset = "0x8808AA0", VA = "0x18880A4A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x880AB80", Offset = "0x8809180", VA = "0x18880AB80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<ICJABCEOLMI, bool> LIHCJFAKFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x880A540", Offset = "0x8808B40", VA = "0x18880A540", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x880A5F0", Offset = "0x8808BF0", VA = "0x18880A5F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "16")]
	public void FLMOPKJJIJF(DALKFPIOIFA GEJAMCMAAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x880A910", Offset = "0x8808F10", VA = "0x18880A910", Slot = "12")]
	public void IIADJEEALGO(DLDIJLNEIBF HFPKGHFHAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x880AB20", Offset = "0x8809120", VA = "0x18880AB20", Slot = "13")]
	public void NBOIMLPDHHB(DLDIJLNEIBF HFPKGHFHAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x880AB50", Offset = "0x8809150", VA = "0x18880AB50", Slot = "14")]
	public void NNNKBBFMLJA(DLDIJLNEIBF HFPKGHFHAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x880A450", Offset = "0x8808A50", VA = "0x18880A450", Slot = "15")]
	public void AENKFDJGJFD(ICJABCEOLMI FHIJCHFCPCC, bool DDMLMBGCPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x880A740", Offset = "0x8808D40", VA = "0x18880A740")]
	private void GHDKDALNEMC(CMDNGMGGMOD NKIIOMEEMNC, DLDIJLNEIBF HFPKGHFHAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public OHMMOANNOAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[UnityEngine.Scripting.Preserve]
internal class GGIPMALABHG : JCIIJKJNGJH, NIJFJDBNJOC, IDisposable, FNLFGFPFCLM
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private class PLGOPLIKBAD : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct DIAICCDEBBH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public PLGOPLIKBAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public FNLFGFPFCLM.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private AFBNCPDOCOC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private ADPHJGAIKIC[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			private TaskAwaiter<ADPHJGAIKIC.MPEPGDHIMCP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x87FA230", Offset = "0x87F8830", VA = "0x1887FA230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x87FA970", Offset = "0x87F8F70", VA = "0x1887FA970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct FDCLNAGHBEF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public AsyncTaskMethodBuilder<ADPHJGAIKIC.MPEPGDHIMCP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public ADPHJGAIKIC fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public PLGOPLIKBAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public FNLFGFPFCLM.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			private AFBNCPDOCOC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private NHIFHKINLKH <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private TaskAwaiter<ADPHJGAIKIC.MPEPGDHIMCP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x87FBA00", Offset = "0x87FA000", VA = "0x1887FBA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x87FC6C0", Offset = "0x87FACC0", VA = "0x1887FC6C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class EFMLIKHMNNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public ADPHJGAIKIC fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public EFMLIKHMNNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x87FB6F0", Offset = "0x87F9CF0", VA = "0x1887FB6F0")]
			internal object IEELGEEJNMK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Task NPLKHMALANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CancellationTokenSource OLINDFJIJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public NHIFHKINLKH OPILIPNJIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public FKOJBBBPHKG ACIHABPADPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public EKJPCJHKEHD NJPOPCBKEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public MPGMBCPBAJA GKIIDCPHJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public ADPHJGAIKIC[] CJHPDLOBMFB;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool LKLEAPMLHCO
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x8808F40", Offset = "0x8807540", VA = "0x188808F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool ICPIBEPGFOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8808F60", Offset = "0x8807560", VA = "0x188808F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8816660", Offset = "0x8814C60", VA = "0x188816660")]
		public PLGOPLIKBAD(FKOJBBBPHKG ACIHABPADPI, EKJPCJHKEHD NJPOPCBKEDB, MPGMBCPBAJA GKIIDCPHJMB, ADPHJGAIKIC[] CJHPDLOBMFB, CancellationToken KMHHNOGHBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8815010", Offset = "0x8813610", VA = "0x188815010", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8815920", Offset = "0x8813F20", VA = "0x188815920")]
		public void GDHLAJHDHJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8815580", Offset = "0x8813B80", VA = "0x188815580")]
		public void FHBCCFGMLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8815E10", Offset = "0x8814410", VA = "0x188815E10")]
		public void LMDOLDONCCJ(FNLFGFPFCLM.Reason KHOEPFNMAEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x88161F0", Offset = "0x88147F0", VA = "0x1888161F0")]
		[AsyncStateMachine(typeof(DIAICCDEBBH))]
		public Task PMNNIBMIBCA(FNLFGFPFCLM.Reason CIOGCOOPLBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8815990", Offset = "0x8813F90", VA = "0x188815990")]
		[AsyncStateMachine(typeof(FDCLNAGHBEF))]
		private Task<ADPHJGAIKIC.MPEPGDHIMCP> INNCCJIFPIG(FNLFGFPFCLM.Reason CIOGCOOPLBM, ADPHJGAIKIC KLLIEJFIOOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8815800", Offset = "0x8813E00", VA = "0x188815800")]
		private void GCAMKDFCNGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8814F60", Offset = "0x8813560", VA = "0x188814F60")]
		public bool DAJHAIJNOFD(FNLFGFPFCLM.Reason IPIBNOLLLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8814CA0", Offset = "0x88132A0", VA = "0x188814CA0")]
		private void CGMDNACNFAG(NHIFHKINLKH DCPJOMEJHIO, FNLFGFPFCLM.Reason CIOGCOOPLBM = FNLFGFPFCLM.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8815C40", Offset = "0x8814240", VA = "0x188815C40")]
		private void LDBPFAKGEHI(NHIFHKINLKH DCPJOMEJHIO, ADPHJGAIKIC.MPEPGDHIMCP HPCDHGHHCOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8814AF0", Offset = "0x88130F0", VA = "0x188814AF0")]
		private void BGCNMLFLFAG(NHIFHKINLKH DCPJOMEJHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x88151B0", Offset = "0x88137B0", VA = "0x1888151B0")]
		private void ECHGAGOJGEN(NHIFHKINLKH DCPJOMEJHIO, ADPHJGAIKIC.MPEPGDHIMCP HPCDHGHHCOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8815AD0", Offset = "0x88140D0", VA = "0x188815AD0")]
		private void LBLHEJPDAOE(NHIFHKINLKH DCPJOMEJHIO, Exception CGONOPBDIAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x88160E0", Offset = "0x88146E0", VA = "0x1888160E0")]
		private void OJFGJEOONNJ(ADPHJGAIKIC KLLIEJFIOOG, FNLFGFPFCLM.Reason CIOGCOOPLBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x88156F0", Offset = "0x8813CF0", VA = "0x1888156F0")]
		private void FPMCFOGJNHH(ADPHJGAIKIC KLLIEJFIOOG, FNLFGFPFCLM.Reason CIOGCOOPLBM, string FJLCNJKLPKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x88162F0", Offset = "0x88148F0", VA = "0x1888162F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class NHIFHKINLKH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public Task<ADPHJGAIKIC.MPEPGDHIMCP> NPLKHMALANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public CancellationTokenSource OLINDFJIJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public ADPHJGAIKIC KLLIEJFIOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public FNLFGFPFCLM.Reason KHOEPFNMAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public HashSet<FNLFGFPFCLM.Reason> FAENGDADNFA;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool LKLEAPMLHCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x8808F40", Offset = "0x8807540", VA = "0x188808F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool ICPIBEPGFOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x8808F60", Offset = "0x8807560", VA = "0x188808F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8808DD0", Offset = "0x88073D0", VA = "0x188808DD0")]
		public void FJGIFBPLLNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8808DB0", Offset = "0x88073B0", VA = "0x188808DB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8808F80", Offset = "0x8807580", VA = "0x188808F80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x88092E0", Offset = "0x88078E0", VA = "0x1888092E0")]
		public NHIFHKINLKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class GPHMPCEJKGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public FNLFGFPFCLM.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public GPHMPCEJKGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x87FDBC0", Offset = "0x87FC1C0", VA = "0x1887FDBC0")]
		internal object AAMKOAAIJNC(NHIFHKINLKH x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x87FDC30", Offset = "0x87FC230", VA = "0x1887FDC30")]
		internal object NCILBCELOMD(PLGOPLIKBAD x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x87FDCA0", Offset = "0x87FC2A0", VA = "0x1887FDCA0")]
		internal object OPCHKGLOICC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct JHKPINGHICB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public FNLFGFPFCLM.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public GGIPMALABHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private GPHMPCEJKGL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8801410", Offset = "0x87FFA10", VA = "0x188801410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8801E90", Offset = "0x8800490", VA = "0x188801E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct BGFBDDLEGFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GGIPMALABHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public FNLFGFPFCLM.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private PLGOPLIKBAD <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x87F7410", Offset = "0x87F5A10", VA = "0x1887F7410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x87F80A0", Offset = "0x87F66A0", VA = "0x1887F80A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct MDICLBPHBLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GGIPMALABHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8807720", Offset = "0x8805D20", VA = "0x188807720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8807CC0", Offset = "0x88062C0", VA = "0x188807CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	internal static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	internal static readonly LHMKAIAPMBI GBKPNFHCPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private DALKFPIOIFA GEJAMCMAAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private FKOJBBBPHKG ACIHABPADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private PLGOPLIKBAD OBLGMNPOPBC;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private NIBBLCAGIDJ IAEGCNMCKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x87FD7E0", Offset = "0x87FBDE0", VA = "0x1887FD7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool LKGCPNGHOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x25A1280", Offset = "0x259F880", VA = "0x1825A1280", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool MHDJMKMDOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x87FD680", Offset = "0x87FBC80", VA = "0x1887FD680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x87FD140", Offset = "0x87FB740", VA = "0x1887FD140", Slot = "6")]
	public void FLMOPKJJIJF(DALKFPIOIFA GEJAMCMAAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x87FCFA0", Offset = "0x87FB5A0", VA = "0x1887FCFA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x87FCFB0", Offset = "0x87FB5B0", VA = "0x1887FCFB0", Slot = "9")]
	public void FJGIFBPLLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x87FC960", Offset = "0x87FAF60", VA = "0x1887FC960")]
	private bool BLPDAAADDGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x87FCED0", Offset = "0x87FB4D0", VA = "0x1887FCED0", Slot = "5")]
	private void DPJNJGKHJLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x87FD6F0", Offset = "0x87FBCF0", VA = "0x1887FD6F0", Slot = "8")]
	[AsyncStateMachine(typeof(JHKPINGHICB))]
	public Task MOKPKDEHJAC(FNLFGFPFCLM.Reason CIOGCOOPLBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x87FD290", Offset = "0x87FB890", VA = "0x1887FD290")]
	private bool IILDNHIAMKH(FNLFGFPFCLM.Reason CIOGCOOPLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x87FCA40", Offset = "0x87FB040", VA = "0x1887FCA40")]
	private ADPHJGAIKIC[] BOJIFCLNIKG(MPGMBCPBAJA CCKPKDIGAPO, EKJPCJHKEHD DPMNIFHFBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x87FD570", Offset = "0x87FBB70", VA = "0x1887FD570")]
	[AsyncStateMachine(typeof(BGFBDDLEGFO))]
	private Task KPNPBNCJBDC(FNLFGFPFCLM.Reason CIOGCOOPLBM, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x87FD1C0", Offset = "0x87FB7C0", VA = "0x1887FD1C0")]
	[AsyncStateMachine(typeof(MDICLBPHBLB))]
	private Task HPFHNMIJHMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public GGIPMALABHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class PJKHNLACCLE : LDCCCOIGGJK, NIJFJDBNJOC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct BJLODACMNKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public MPGMBCPBAJA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public PJKHNLACCLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public KOIFLJMDNHD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x87F83F0", Offset = "0x87F69F0", VA = "0x1887F83F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x87F8D60", Offset = "0x87F7360", VA = "0x1887F8D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct KNEMBNBHGIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public PJKHNLACCLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public MPGMBCPBAJA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public KOIFLJMDNHD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private EHMNEFALKGP<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private AFBNCPDOCOC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private LCHHEHIMOLC <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private LEKKPPJKHAI <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8803B50", Offset = "0x8802150", VA = "0x188803B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8804CA0", Offset = "0x88032A0", VA = "0x188804CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class AGGOLDBCACO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public Matchmaking.GLNHDLEJGCA result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public EILCJHBBKGK errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public AGGOLDBCACO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x87F7360", Offset = "0x87F5960", VA = "0x1887F7360")]
		internal object NELDGLIOFIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class LDCCAGCIIAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public Task<JBNAFHMBIJM> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public LDCCAGCIIAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		internal Task<JBNAFHMBIJM> MMJKDGAJCKI(EHMNEFALKGP<string>.OJMJGFAOFAB _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct PJNJKGOOKGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public PJKHNLACCLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public MPGMBCPBAJA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public KOIFLJMDNHD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public LCHHEHIMOLC joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private LDCCAGCIIAK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private AFLGFKBHKAI <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private AFBNCPDOCOC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private PFPFHKOPDKJ <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private Task<Matchmaking.PPMBHKAFCJG> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private HNENOOOIFJJ <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter<Matchmaking.PPMBHKAFCJG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private TaskAwaiter<JBNAFHMBIJM> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x880F130", Offset = "0x880D730", VA = "0x18880F130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8814A90", Offset = "0x8813090", VA = "0x188814A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class HDCCNHHNAFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public Task<JBNAFHMBIJM> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public HDCCNHHNAFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		internal Task<JBNAFHMBIJM> DMMDHPJMJGC(EHMNEFALKGP<string>.OJMJGFAOFAB _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct LOJOMNCMNPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public PJKHNLACCLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public MPGMBCPBAJA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public KOIFLJMDNHD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public LCHHEHIMOLC joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private AFLGFKBHKAI <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private AFBNCPDOCOC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private PFPFHKOPDKJ <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private Task<Matchmaking.PPMBHKAFCJG> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private JBNAFHMBIJM <initialRoomLoadPayload>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private EDBLCFBGHDL <preloadContext>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter<JBNAFHMBIJM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private HNENOOOIFJJ <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private Task <loadEmptySceneTask>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private GIEMCODENJA <sceneManagementService>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private CGBBDOKLCCK <scenePreloadRequest>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private CancellationTokenSource <cameraFadeCts>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter<ANOBLFNCFNO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private int <i>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private YieldAwaitable.YieldAwaiter <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private TaskAwaiter<Matchmaking.PPMBHKAFCJG> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private CancellationToken <photonJoinedToken>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x882B400", Offset = "0x8829A00", VA = "0x18882B400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8830A80", Offset = "0x882F080", VA = "0x188830A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct BDBDOGNALOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public PJKHNLACCLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x881B170", Offset = "0x8819770", VA = "0x18881B170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x881BBE0", Offset = "0x881A1E0", VA = "0x18881BBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct FMBPHOPOKDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public PJKHNLACCLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private DCNOMJHNEOK <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x881F390", Offset = "0x881D990", VA = "0x18881F390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x881F820", Offset = "0x881DE20", VA = "0x18881F820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct CPDMGJAEBKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public AsyncTaskMethodBuilder<Matchmaking.PPMBHKAFCJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public MPGMBCPBAJA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public PJKHNLACCLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter<Matchmaking.PPMBHKAFCJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x881DD00", Offset = "0x881C300", VA = "0x18881DD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x881E1E0", Offset = "0x881C7E0", VA = "0x18881E1E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct MKANCGMNPMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public Matchmaking.PPMBHKAFCJG serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public PJKHNLACCLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public LCHHEHIMOLC joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private TaskAwaiter<CHLHACCNABJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8832F00", Offset = "0x8831500", VA = "0x188832F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8833540", Offset = "0x8831B40", VA = "0x188833540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class CMNHLKBNAPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public MPGMBCPBAJA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public CMNHLKBNAPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x881DB00", Offset = "0x881C100", VA = "0x18881DB00")]
		internal object ACHGNGAJDNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x881DC00", Offset = "0x881C200", VA = "0x18881DC00")]
		internal string EKPJFFLAIBJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct GDLEJIHKIEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public MPGMBCPBAJA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public PJKHNLACCLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private CMNHLKBNAPD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x88206C0", Offset = "0x881ECC0", VA = "0x1888206C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8821250", Offset = "0x881F850", VA = "0x188821250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct DDAMLGNJGBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public PJKHNLACCLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public LCHHEHIMOLC joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public JBNAFHMBIJM initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public MPGMBCPBAJA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public EDBLCFBGHDL preloadContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public AFLGFKBHKAI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x881E250", Offset = "0x881C850", VA = "0x18881E250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x881EA40", Offset = "0x881D040", VA = "0x18881EA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct BEKANCBDHCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public PJKHNLACCLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private AFBNCPDOCOC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private AFBNCPDOCOC <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x881BC40", Offset = "0x881A240", VA = "0x18881BC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x881D420", Offset = "0x881BA20", VA = "0x18881D420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct JCGDOCFOMGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public MJGCNECCLCM localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public PJKHNLACCLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<JDKMKDKEGJC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8826D10", Offset = "0x8825310", VA = "0x188826D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8827510", Offset = "0x8825B10", VA = "0x188827510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class NNGFCEKIIDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public MPGMBCPBAJA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public NNGFCEKIIDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x88358D0", Offset = "0x8833ED0", VA = "0x1888358D0")]
		internal object LACALHLILLO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class OBBHCEPJGOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public OBBHCEPJGOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x8835AA0", Offset = "0x88340A0", VA = "0x188835AA0")]
		internal void ONHDGDJOEDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class FJEGLBNJEGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public MPGMBCPBAJA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public FJEGLBNJEGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x881F2B0", Offset = "0x881D8B0", VA = "0x18881F2B0")]
		internal object EEBJMIOJFLO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class LGEKMGCJFLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public MPGMBCPBAJA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public LGEKMGCJFLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8829D80", Offset = "0x8828380", VA = "0x188829D80")]
		internal string NOFIHLKBGNK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly LHMKAIAPMBI HFJNOBAFFOJ;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly LHMKAIAPMBI IHLIKMHJJLD;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly LHMKAIAPMBI NPBPFIIHBLA;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly string GCBHGNFMHGM;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static readonly string BNNPOBPDIHH;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private static readonly string DOBEHBPIKDE;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public static readonly Guid DEPIKPJJGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private GAIHMFBPIKO ACEKANILHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private CHNOGHNCFEH COCHLDFDDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private KEDGPMDLKIM ILCCHPCLICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private DALKFPIOIFA GEJAMCMAAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private FKOJBBBPHKG ACIHABPADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private JCIIJKJNGJH EECPDJPICPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private KODFNEJDPGD JNOFNLPKHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private MOLNDKPIOKM KLGCFGPCNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private BNKNFMABFHH AIIKLDGAOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private FPIDAMIJABG IFMBECNOOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private IDisposable PJBEMMGJLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private JOGBHPFCPAE BACJBJFNCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly ANCHKNHFGEI CIFDOHNLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private HNENOOOIFJJ MJNLAHMENED;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus BMJMMGENPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xA6CC40", Offset = "0xA6B240", VA = "0x180A6CC40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x14964F0", Offset = "0x1494AF0", VA = "0x1814964F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private NIBBLCAGIDJ IAEGCNMCKDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x880ECD0", Offset = "0x880D2D0", VA = "0x18880ECD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x880C320", Offset = "0x880A920", VA = "0x18880C320", Slot = "6")]
	public void FLMOPKJJIJF(DALKFPIOIFA GEJAMCMAAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x880BF60", Offset = "0x880A560", VA = "0x18880BF60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x880BB40", Offset = "0x880A140", VA = "0x18880BB40", Slot = "5")]
	[AsyncStateMachine(typeof(BJLODACMNKE))]
	public Task BJAEOPGDOON(MPGMBCPBAJA AEDAKEMLNJC, KOIFLJMDNHD HDCPKPPEKKC, CancellationToken BACOGCKOPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x880D930", Offset = "0x880BF30", VA = "0x18880D930")]
	[AsyncStateMachine(typeof(KNEMBNBHGIJ))]
	private Task KCAKELMIGFM(MPGMBCPBAJA AEDAKEMLNJC, KOIFLJMDNHD HDCPKPPEKKC, CancellationToken BACOGCKOPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x880C7A0", Offset = "0x880ADA0", VA = "0x18880C7A0")]
	private void GCMKBLGLOFN(BNKNFMABFHH AIIKLDGAOKH, MPGMBCPBAJA AEDAKEMLNJC, Exception CGONOPBDIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x880DB90", Offset = "0x880C190", VA = "0x18880DB90")]
	private static void LGDAJPOFFHH(LEKKPPJKHAI BFPPEMAPJKI, Exception CGONOPBDIAB, [Optional] List<int> APHMKOOFDGM, int PIEFOENDKAA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x880C640", Offset = "0x880AC40", VA = "0x18880C640")]
	[AsyncStateMachine(typeof(PJNJKGOOKGE))]
	private Task FLPLCPMPFLA(EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, MPGMBCPBAJA AEDAKEMLNJC, KOIFLJMDNHD HDCPKPPEKKC, LCHHEHIMOLC ANAJKGAMCGH, CancellationToken BACOGCKOPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x880C1C0", Offset = "0x880A7C0", VA = "0x18880C1C0")]
	[AsyncStateMachine(typeof(LOJOMNCMNPJ))]
	private Task EOLCCHAMAEO(EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, MPGMBCPBAJA AEDAKEMLNJC, KOIFLJMDNHD HDCPKPPEKKC, LCHHEHIMOLC ANAJKGAMCGH, CancellationToken BACOGCKOPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x880CEB0", Offset = "0x880B4B0", VA = "0x18880CEB0")]
	private void HAPOOLOPMML([CallerMemberName] string GLBFENKKLBN = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x880D290", Offset = "0x880B890", VA = "0x18880D290")]
	[AsyncStateMachine(typeof(BDBDOGNALOK))]
	private Task HKKKJODPNFF(EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x880E660", Offset = "0x880CC60", VA = "0x18880E660")]
	private void LJPCHNNFLDC(MPGMBCPBAJA AEDAKEMLNJC, CancellationToken BACOGCKOPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x880D030", Offset = "0x880B630", VA = "0x18880D030")]
	private void HJFPHHBDOHB(MPGMBCPBAJA AEDAKEMLNJC, TaskStatus GLNNAENDNMD, string CJIMOMNMAGD, LCHHEHIMOLC ANAJKGAMCGH, Exception KCNEOPLNBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x880DA80", Offset = "0x880C080", VA = "0x18880DA80")]
	private void KIFHMHOKBPG(MPGMBCPBAJA AEDAKEMLNJC, LCHHEHIMOLC ANAJKGAMCGH, OperationCanceledException EMBMFDCFAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x880D580", Offset = "0x880BB80", VA = "0x18880D580")]
	private void IJGPFNPOCGK(MPGMBCPBAJA AEDAKEMLNJC, LCHHEHIMOLC ANAJKGAMCGH, Exception CGONOPBDIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x880BC80", Offset = "0x880A280", VA = "0x18880BC80")]
	private void CAKCPGNIJBI(MPGMBCPBAJA AEDAKEMLNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x880B770", Offset = "0x8809D70", VA = "0x18880B770")]
	private static DLDIJLNEIBF ALONOBAFHEO(MPGMBCPBAJA AEDAKEMLNJC)
	{
		return default(DLDIJLNEIBF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x880BE90", Offset = "0x880A490", VA = "0x18880BE90")]
	[AsyncStateMachine(typeof(FMBPHOPOKDD))]
	private Task CKAFANBALKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x880ED20", Offset = "0x880D320", VA = "0x18880ED20")]
	[AsyncStateMachine(typeof(CPDMGJAEBKC))]
	private Task<Matchmaking.PPMBHKAFCJG> PMNLEFLNALK(MPGMBCPBAJA AEDAKEMLNJC, EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x880E550", Offset = "0x880CB50", VA = "0x18880E550")]
	private static CHLHACCNABJ LJAMELPBDEO(Matchmaking.PPMBHKAFCJG HOKDDHAKGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x880CD60", Offset = "0x880B360", VA = "0x18880CD60")]
	[AsyncStateMachine(typeof(MKANCGMNPMK))]
	private Task GPIKDNLDPIM(Matchmaking.PPMBHKAFCJG HOKDDHAKGDG, LCHHEHIMOLC ANAJKGAMCGH, EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, CancellationToken JLIPPIADDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x880E990", Offset = "0x880CF90", VA = "0x18880E990")]
	[AsyncStateMachine(typeof(GDLEJIHKIEP))]
	private Task NDJIFHNOFNE(MPGMBCPBAJA AEDAKEMLNJC, CancellationTokenSource LNPOIHGDPAD, Task MOOLMILBEFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x880B9C0", Offset = "0x8809FC0", VA = "0x18880B9C0")]
	[AsyncStateMachine(typeof(DDAMLGNJGBB))]
	private Task BEEILODAJDE(JBNAFHMBIJM FPILGCGMMOI, AFLGFKBHKAI AMHFLHGINAG, MPGMBCPBAJA EDGBFOPGMND, LCHHEHIMOLC LKBGGEGCDEO, EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, CancellationToken FLEPGPIGJJE, [Optional] EDBLCFBGHDL GJJIDPBEDPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x880B7D0", Offset = "0x8809DD0", VA = "0x18880B7D0")]
	private LCHHEHIMOLC BCCDPECBPKM(LCHHEHIMOLC LKBGGEGCDEO, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x880CC20", Offset = "0x880B220", VA = "0x18880CC20")]
	[AsyncStateMachine(typeof(BEKANCBDHCI))]
	private Task GDFFGLJLMJA(EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x880D3C0", Offset = "0x880B9C0", VA = "0x18880D3C0")]
	[AsyncStateMachine(typeof(JCGDOCFOMGO))]
	private Task HOFLCAPCAKE(CancellationToken KMHHNOGHBLL, int OHJBDEEMPBB, MJGCNECCLCM KIGFJAABOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x880E3D0", Offset = "0x880C9D0", VA = "0x18880E3D0")]
	private static void LHJBLMPKHDI(MPGMBCPBAJA AEDAKEMLNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x880D600", Offset = "0x880BC00", VA = "0x18880D600")]
	private void JIKMBPCKOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x880D4F0", Offset = "0x880BAF0", VA = "0x18880D4F0")]
	private void IJGKENMEGKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x880EB30", Offset = "0x880D130", VA = "0x18880EB30")]
	private void ODILCGENLFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x880DB00", Offset = "0x880C100", VA = "0x18880DB00")]
	private void LDMFCDCNPFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x880B680", Offset = "0x8809C80", VA = "0x18880B680")]
	private static void ABMFDDPOPEN(MPGMBCPBAJA AEDAKEMLNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x880EBC0", Offset = "0x880D1C0", VA = "0x18880EBC0")]
	private static CancellationTokenRegistration PCFGEAFAPHI(MPGMBCPBAJA AEDAKEMLNJC, CancellationToken JLIPPIADDOK)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x880D830", Offset = "0x880BE30", VA = "0x18880D830")]
	private static void JMPILPACNEN(MPGMBCPBAJA AEDAKEMLNJC, Exception CGONOPBDIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x880C010", Offset = "0x880A610", VA = "0x18880C010")]
	private void EHAENPMMOLI(MPGMBCPBAJA AEDAKEMLNJC, Task MOOLMILBEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x880EAD0", Offset = "0x880D0D0", VA = "0x18880EAD0")]
	private static void OAAFJAHOMDO(Func<string> KDAOOGLIINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x880F0A0", Offset = "0x880D6A0", VA = "0x18880F0A0")]
	public PJKHNLACCLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x880BFB0", Offset = "0x880A5B0", VA = "0x18880BFB0")]
	[CompilerGenerated]
	internal static (int, int?) EBAAOOLAKCE(EILCJHBBKGK AMNMJKOJOJL)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[RecRoom.NoEngine.Common.Preserve]
internal class NLJAHGMGGDD : GOHCGKCPCEL, NIJFJDBNJOC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct CAPFABDOBJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public NLJAHGMGGDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public MJGCNECCLCM localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x881D550", Offset = "0x881BB50", VA = "0x18881D550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x881DA30", Offset = "0x881C030", VA = "0x18881DA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class IHHBMCHMBEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public NLJAHGMGGDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public MJGCNECCLCM localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public IHHBMCHMBEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x88260F0", Offset = "0x88246F0", VA = "0x1888260F0")]
		internal List<Task> PKELDJJCKOH(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct HGJEEIMBEPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public EBGJHLDMFLM taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public MJGCNECCLCM localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8825AE0", Offset = "0x88240E0", VA = "0x188825AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8825E80", Offset = "0x8824480", VA = "0x188825E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct FNFAJPMKEPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public NLJAHGMGGDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8820380", Offset = "0x881E980", VA = "0x188820380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8820660", Offset = "0x881EC60", VA = "0x188820660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private readonly HashSet<EBGJHLDMFLM> BINDKKNEBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private CHNOGHNCFEH COCHLDFDDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private DALKFPIOIFA GEJAMCMAAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private JHFENBPHJMD KHIMNJMNEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private EAFIPOGJKBC JBDKJPAADAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private IDisposable PJBEMMGJLDE;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8834200", Offset = "0x8832800", VA = "0x188834200", Slot = "5")]
	public void FLMOPKJJIJF(DALKFPIOIFA GEJAMCMAAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8834050", Offset = "0x8832650", VA = "0x188834050", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x88344E0", Offset = "0x8832AE0", VA = "0x1888344E0", Slot = "4")]
	public bool JKNMAPAKOKH(EBGJHLDMFLM HHCEJMFBPJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x88340B0", Offset = "0x88326B0", VA = "0x1888340B0")]
	private void FCOOCGDOPNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8833E30", Offset = "0x8832430", VA = "0x188833E30")]
	private void DHLPKKGJDJM(JBAPOOINJKO MODBIBDJKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8834540", Offset = "0x8832B40", VA = "0x188834540")]
	[AsyncStateMachine(typeof(CAPFABDOBJM))]
	private Task NBLDMBBECDO(int OHJBDEEMPBB, MJGCNECCLCM KIGFJAABOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x8833890", Offset = "0x8831E90", VA = "0x188833890")]
	private Func<CancellationToken, List<Task>> BNOAHAMHICA(int OHJBDEEMPBB, MJGCNECCLCM KIGFJAABOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x8833960", Offset = "0x8831F60", VA = "0x188833960")]
	private List<Task> CEJALGEEDIH(int OHJBDEEMPBB, MJGCNECCLCM KIGFJAABOEN, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x8834630", Offset = "0x8832C30", VA = "0x188834630")]
	[AsyncStateMachine(typeof(HGJEEIMBEPH))]
	private Task NEABGMPBOGJ(EBGJHLDMFLM LKDLEEGIIKE, CancellationToken DKFMAIJGPFL, int OHJBDEEMPBB, MJGCNECCLCM KIGFJAABOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x8834750", Offset = "0x8832D50", VA = "0x188834750")]
	[AsyncStateMachine(typeof(FNFAJPMKEPP))]
	private Task PLODPMHKGKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8834180", Offset = "0x8832780", VA = "0x188834180")]
	private void FJGIFBPLLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8834820", Offset = "0x8832E20", VA = "0x188834820")]
	public NLJAHGMGGDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[UnityEngine.Scripting.Preserve]
internal sealed class GJLDNDOEOAK : PBKFNKIOBNA, NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class LGPGCHEMBHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public LGPGCHEMBHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x8829E80", Offset = "0x8828480", VA = "0x188829E80")]
		internal object PHHAGCGJILO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class LLJECBHINGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public LLJECBHINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x882B3A0", Offset = "0x88299A0", VA = "0x18882B3A0")]
		internal object MANAECAPOII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class BEMJBJEDPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BEMJBJEDPNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class MECHJHFEKPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public MECHJHFEKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8830F90", Offset = "0x882F590", VA = "0x188830F90")]
		internal object KELPLCNFLFO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class BJIAJDKKGFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BJIAJDKKGFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x881D480", Offset = "0x881BA80", VA = "0x18881D480")]
		internal object FLLGHANCBIH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private readonly Dictionary<Guid, MJLLDLFKGDN> MOJOKMILBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private readonly TimeSpan LAMGODPDMPH;

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "9")]
	public void FLMOPKJJIJF(DALKFPIOIFA GEJAMCMAAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x8821A90", Offset = "0x8820090", VA = "0x188821A90", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x8821D40", Offset = "0x8820340", VA = "0x188821D40", Slot = "4")]
	public EFFCNFKHGDB JDPCENHCAFL(Guid HOFBFGLIONA)
	{
		return default(EFFCNFKHGDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x8821880", Offset = "0x881FE80", VA = "0x188821880", Slot = "5")]
	public bool BAFGFGCDOJB(Guid HOFBFGLIONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x8821F60", Offset = "0x8820560", VA = "0x188821F60", Slot = "6")]
	public bool KCKPLIHOBIA(Guid HOFBFGLIONA, Task JBBNLFDGKBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x8822290", Offset = "0x8820890", VA = "0x188822290", Slot = "7")]
	public bool ONEDNEPPDFL(Guid HOFBFGLIONA, JDKMKDKEGJC DAKFIHCINKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x8821AA0", Offset = "0x88200A0", VA = "0x188821AA0", Slot = "8")]
	public Task<(JDKMKDKEGJC, Task)> GBMMKEDJDAH(Guid HOFBFGLIONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x8821B10", Offset = "0x8820110", VA = "0x188821B10")]
	private void HKFHCJBKKHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x8822470", Offset = "0x8820A70", VA = "0x188822470")]
	public GJLDNDOEOAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[RecRoom.NoEngine.Common.Preserve]
internal class KHHFKKKCDFB : NEJKDIOFFPF, NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class JIGBFNHOBDC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private readonly MPGMBCPBAJA EEJGNICGGAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private readonly CancellationTokenSource PCGMGJPANKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public readonly CancellationToken JMHGIAHOODA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private bool MPLIDDOPPNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private bool IPJFEJDAGIO;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x8828180", Offset = "0x8826780", VA = "0x188828180")]
		public JIGBFNHOBDC(MPGMBCPBAJA EEJGNICGGAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8828030", Offset = "0x8826630", VA = "0x188828030")]
		public void FJGIFBPLLNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8828000", Offset = "0x8826600", VA = "0x188828000", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class FILIADBDCNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public OAJNBKMEPPG disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public FILIADBDCNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x881F220", Offset = "0x881D820", VA = "0x18881F220")]
		internal object BCDLNNAPGOH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private struct MAHBHNBJFOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public OAJNBKMEPPG disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public KHHFKKKCDFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8830AE0", Offset = "0x882F0E0", VA = "0x188830AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8830F30", Offset = "0x882F530", VA = "0x188830F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class CCOGKNNCMNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public KHHFKKKCDFB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public CCOGKNNCMNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x881DA90", Offset = "0x881C090", VA = "0x18881DA90")]
		internal object DAPMJBHDIEK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class AEFBEEOGOAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public MPGMBCPBAJA newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public CCOGKNNCMNM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public AEFBEEOGOAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x88194C0", Offset = "0x8817AC0", VA = "0x1888194C0")]
		internal object LJJCIIPOKGI((MPGMBCPBAJA lastLocalPlayerRoomInstance, MPGMBCPBAJA newRoomInstance, JCIIJKJNGJH fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct GKCOABHKPKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public KHHFKKKCDFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private AFBNCPDOCOC <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x8822530", Offset = "0x8820B30", VA = "0x188822530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6DB0", Offset = "0xAA53B0", VA = "0x180AA6DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class IHDNPGHHFDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public MPGMBCPBAJA newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public IHDNPGHHFDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x8826050", Offset = "0x8824650", VA = "0x188826050")]
		internal object MJFPCGPDENE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8825F90", Offset = "0x8824590", VA = "0x188825F90")]
		internal void IEJHAOMNGIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8825F50", Offset = "0x8824550", VA = "0x188825F50")]
		internal object DIAFMOOJECI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8826010", Offset = "0x8824610", VA = "0x188826010")]
		internal object KHHHILOFJNB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct AKEJHHHHMDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public MPGMBCPBAJA newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public KHHFKKKCDFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public KOIFLJMDNHD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private IHDNPGHHFDE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x881A150", Offset = "0x8818750", VA = "0x18881A150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x881B110", Offset = "0x8819710", VA = "0x18881B110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly GGCCNEACPFH.FAEMNKLPNFE EDNFJPPIDND;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static readonly KOJMLKHMICP PBPPJALAJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private CHNOGHNCFEH COCHLDFDDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private DALKFPIOIFA GEJAMCMAAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private JCIIJKJNGJH EECPDJPICPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private FKOJBBBPHKG ACIHABPADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private NAFLOBGIDBA HHBGHAKIGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private LDCCCOIGGJK CPBLHGLGNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private MPGMBCPBAJA PKMCGGEJIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private JIGBFNHOBDC DMFOCPDPKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private bool PCEMNAHKEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private Task MJJBIPNGGPC;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private NIBBLCAGIDJ IAEGCNMCKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x88292B0", Offset = "0x88278B0", VA = "0x1888292B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool NOBDLKNEJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xD19390", Offset = "0xD17990", VA = "0x180D19390")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8828B60", Offset = "0x8827160", VA = "0x188828B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x88287C0", Offset = "0x8826DC0", VA = "0x1888287C0", Slot = "4")]
	public void FLMOPKJJIJF(DALKFPIOIFA GEJAMCMAAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8828600", Offset = "0x8826C00", VA = "0x188828600", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8828B70", Offset = "0x8827170", VA = "0x188828B70")]
	[AsyncStateMachine(typeof(MAHBHNBJFOA))]
	private Task IICLBCHINMJ(OAJNBKMEPPG KLMPGFJOMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8828F20", Offset = "0x8827520", VA = "0x188828F20")]
	private void OECDCOAPBNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8828C60", Offset = "0x8827260", VA = "0x188828C60")]
	private void JMNCDNLCLLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8829130", Offset = "0x8827730", VA = "0x188829130")]
	private void OOBOFFHDNBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x88290B0", Offset = "0x88276B0", VA = "0x1888290B0")]
	private bool OKBKFHIBFNG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8828530", Offset = "0x8826B30", VA = "0x188828530")]
	[AsyncStateMachine(typeof(GKCOABHKPKD))]
	private void DMOGHKNKKBO(int HKLGEDHKAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8828290", Offset = "0x8826890", VA = "0x188828290")]
	private void BGLPEAJHLMA([Out] IDisposable CEIINNIKOIP, [Out] IDisposable AJNGKFBNKDF, [Out] IDisposable OOGPPNNMKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x8828A60", Offset = "0x8827060", VA = "0x188828A60")]
	private bool HBNADDDPFKL(MPGMBCPBAJA EEJGNICGGAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8828770", Offset = "0x8826D70", VA = "0x188828770")]
	private void EAJHMCEKELJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8828DF0", Offset = "0x88273F0", VA = "0x188828DF0")]
	[AsyncStateMachine(typeof(AKEJHHHHMDO))]
	private Task KCAKELMIGFM(MPGMBCPBAJA EEJGNICGGAF, KOIFLJMDNHD HDCPKPPEKKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x88296C0", Offset = "0x8827CC0", VA = "0x1888296C0")]
	public KHHFKKKCDFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[UnityEngine.Scripting.Preserve]
internal sealed class LHKHAAFIMLL : MGMGPMNGPNM, NIJFJDBNJOC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct FNAFBBDGLFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public AsyncTaskMethodBuilder<KOJHHCPHIHG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public LHKHAAFIMLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private TaskAwaiter<KOJHHCPHIHG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x8820080", Offset = "0x881E680", VA = "0x188820080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x8820310", Offset = "0x881E910", VA = "0x188820310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class ILNCDDGFOKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public MDPCDPBDELI message;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ILNCDDGFOKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x8826CB0", Offset = "0x88252B0", VA = "0x188826CB0")]
		internal object PKMJNGJDIPM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class NDPGJNJNJHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public MDPCDPBDELI messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public NDPGJNJNJHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x8833830", Offset = "0x8831E30", VA = "0x188833830")]
		internal object GIGNGJMFFMO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class GLNAGGIJBGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public MDPCDPBDELI request;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public GLNAGGIJBGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x8824380", Offset = "0x8822980", VA = "0x188824380")]
		internal object OMDHELNCNGK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct HABBJEPCKPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public MDPCDPBDELI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public LHKHAAFIMLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private TaskAwaiter<EMNCKDOLLHH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x88243E0", Offset = "0x88229E0", VA = "0x1888243E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x8824CB0", Offset = "0x88232B0", VA = "0x188824CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class LJIFAMAFMBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public MDPCDPBDELI operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public LJIFAMAFMBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x882B340", Offset = "0x8829940", VA = "0x18882B340")]
		internal object APAEDFIFFHE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct AHHNICEAIBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public MDPCDPBDELI operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public LHKHAAFIMLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private LCHHEHIMOLC <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private TaskAwaiter<MDPCDPBDELI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x8819580", Offset = "0x8817B80", VA = "0x188819580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x881A0F0", Offset = "0x88186F0", VA = "0x18881A0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct PKHNKFEJJPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public AsyncTaskMethodBuilder<EMNCKDOLLHH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public LHKHAAFIMLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public MDPCDPBDELI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private GGEAGHAPEOJ.CDEHJNKGPKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private LCHHEHIMOLC <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private TaskAwaiter<MDPCDPBDELI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8837220", Offset = "0x8835820", VA = "0x188837220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8837750", Offset = "0x8835D50", VA = "0x188837750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class ABKJIBGEABF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public EMNCKDOLLHH operation;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ABKJIBGEABF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x88187E0", Offset = "0x8816DE0", VA = "0x1888187E0")]
		internal object KDDHIGGHGGD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct GKJNCGNFDEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public EMNCKDOLLHH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public LHKHAAFIMLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private EHMNEFALKGP<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x8823CE0", Offset = "0x88222E0", VA = "0x188823CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8824320", Offset = "0x8822920", VA = "0x188824320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class JPPCDKICALP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public MDPCDPBDELI request;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public JPPCDKICALP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x8828230", Offset = "0x8826830", VA = "0x188828230")]
		internal object LEGJOHNGNFC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class HBOAAAIGJEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public MDPCDPBDELI request;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public HBOAAAIGJEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x8824D10", Offset = "0x8823310", VA = "0x188824D10")]
		internal object CIELDFPMDLD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private DALKFPIOIFA GEJAMCMAAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private KODFNEJDPGD JNOFNLPKHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private KFAOLFKLPPG HKFGJNBIMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private APFHKANGDCD LGIMMCIELII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private KEDGPMDLKIM ILCCHPCLICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private TaskCompletionSource<KOJHHCPHIHG> PLPCLIBJLOM;

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x882A4F0", Offset = "0x8828AF0", VA = "0x18882A4F0", Slot = "7")]
	public void FLMOPKJJIJF(DALKFPIOIFA GEJAMCMAAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x8829FF0", Offset = "0x88285F0", VA = "0x188829FF0", Slot = "6")]
	[AsyncStateMachine(typeof(FNAFBBDGLFD))]
	public Task<KOJHHCPHIHG> CLLHCHAKPEH(CancellationToken AGMPHDKNCLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x882A700", Offset = "0x8828D00", VA = "0x18882A700", Slot = "4")]
	public void JADGIPPKKEP(MDPCDPBDELI CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x882A100", Offset = "0x8828700", VA = "0x18882A100", Slot = "5")]
	public void DAIIGKCDPCP(MDPCDPBDELI MOJIJPBIPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x8829EE0", Offset = "0x88284E0", VA = "0x188829EE0")]
	[AsyncStateMachine(typeof(HABBJEPCKPK))]
	private Task CJNMDPDPFCL(MDPCDPBDELI IPMGANOCOKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x882AF70", Offset = "0x8829570", VA = "0x18882AF70")]
	[AsyncStateMachine(typeof(AHHNICEAIBO))]
	private Task PJKBPAAMHEA(MDPCDPBDELI HFGCEOMMOBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x882AA90", Offset = "0x8829090", VA = "0x18882AA90")]
	[AsyncStateMachine(typeof(PKHNKFEJJPH))]
	private Task<EMNCKDOLLHH> LMLBIDNFMLA(MDPCDPBDELI IPMGANOCOKF, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x882A460", Offset = "0x8828A60", VA = "0x18882A460")]
	private LCHHEHIMOLC EPJGGIMNBAD(MDPCDPBDELI LJHHNBPFKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x882A5E0", Offset = "0x8828BE0", VA = "0x18882A5E0")]
	[AsyncStateMachine(typeof(GKJNCGNFDEA))]
	private Task GLNIPJGBFOD(EMNCKDOLLHH GFCEGHONGDJ, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x882B080", Offset = "0x8829680", VA = "0x18882B080")]
	private EMNCKDOLLHH PMHCHNELNBK(MDPCDPBDELI IPMGANOCOKF, LCHHEHIMOLC LOLNHDPCOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2260", Offset = "0x3BF0860", VA = "0x183BF2260")]
	private T HDFGJOCGMKK<T>(T KKGBKLFKCPO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x882ABE0", Offset = "0x88291E0", VA = "0x18882ABE0")]
	private EMNCKDOLLHH MCLJCOIACAL(MDPCDPBDELI IPMGANOCOKF, LCHHEHIMOLC LOLNHDPCOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public LHKHAAFIMLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class MHFGNFEIACK : KFAOLFKLPPG, NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class KPBBHGLNAKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public KPBBHGLNAKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x8829730", Offset = "0x8827D30", VA = "0x188829730")]
		internal object BIMJHKDPOEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class BLDODHCGBPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BLDODHCGBPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x881D4E0", Offset = "0x881BAE0", VA = "0x18881D4E0")]
		internal object NKIPNMLDIAM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private KEDGPMDLKIM ILCCHPCLICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private NLNHABCLGJO GPKNAFMKICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private MGMGPMNGPNM GOPFBMIMGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private PBKFNKIOBNA MOJOKMILBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private JACLPEDCCNI JBOGAGFKBNI;

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x8832190", Offset = "0x8830790", VA = "0x188832190", Slot = "6")]
	public void FLMOPKJJIJF(DALKFPIOIFA GEJAMCMAAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x88320E0", Offset = "0x88306E0", VA = "0x1888320E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x8831590", Offset = "0x882FB90", VA = "0x188831590", Slot = "4")]
	public EFFCNFKHGDB APMALHGFCJN(MDPCDPBDELI PCKACHENBCH)
	{
		return default(EFFCNFKHGDB);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x8831C80", Offset = "0x8830280", VA = "0x188831C80", Slot = "5")]
	public void BFNDFIJOCKF(Guid HOFBFGLIONA, Task JBBNLFDGKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x88327A0", Offset = "0x8830DA0", VA = "0x1888327A0")]
	private void IKNKAMJICKF(FNFHFOLBALO OPFDLFBBADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x8830FF0", Offset = "0x882F5F0", VA = "0x188830FF0")]
	private void AJHALOFDMPK(ICHJNGBJMGG FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x8832300", Offset = "0x8830900", VA = "0x188832300")]
	private void GGIGBHJIGLP(ICHJNGBJMGG FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x8832AA0", Offset = "0x88310A0", VA = "0x188832AA0")]
	private void MJCPEAGEEJO(ICHJNGBJMGG FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x88319D0", Offset = "0x882FFD0", VA = "0x1888319D0")]
	private JDKMKDKEGJC BEBOOFMKMGM(MDPCDPBDELI LJHHNBPFKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x8832590", Offset = "0x8830B90", VA = "0x188832590")]
	private void GPPOOOGMMLJ(MDPCDPBDELI HFGCEOMMOBH, JDKMKDKEGJC DAKFIHCINKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x88328B0", Offset = "0x8830EB0", VA = "0x1888328B0")]
	private bool JJIJPLDMONM(MDPCDPBDELI HFGCEOMMOBH, JDKMKDKEGJC DAKFIHCINKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x8832CE0", Offset = "0x88312E0", VA = "0x188832CE0")]
	private bool PJICEBFNBPM(MDPCDPBDELI GKILICCKIKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x8831E90", Offset = "0x8830490", VA = "0x188831E90")]
	private bool BLKPALAPLLM(byte FHBJJABHKPG, ExitGames.Client.Photon.Hashtable FLDOIECLDLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public MHFGNFEIACK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class IIOFFKHHPKJ : OAOALCBGOKE, NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class PEECMLKENLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public KOJHHCPHIHG operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public IIOFFKHHPKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public MDPCDPBDELI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public PEECMLKENLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x8837020", Offset = "0x8835620", VA = "0x188837020")]
		internal object ADPKDDEBPMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x8837090", Offset = "0x8835690", VA = "0x188837090")]
		internal object NBOCJJNGCFF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct HCMCNGONGAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public AsyncTaskMethodBuilder<JDKMKDKEGJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public IIOFFKHHPKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public MDPCDPBDELI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private TaskAwaiter<JDKMKDKEGJC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8824D70", Offset = "0x8823370", VA = "0x188824D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8825410", Offset = "0x8823A10", VA = "0x188825410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class HONCBDJNLDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public KOJHHCPHIHG operationType;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public HONCBDJNLDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x8825EE0", Offset = "0x88244E0", VA = "0x188825EE0")]
		internal object JBOONBCKALL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class JIAFHOHJBCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public MDPCDPBDELI request;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public JIAFHOHJBCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x8827F20", Offset = "0x8826520", VA = "0x188827F20")]
		internal object CNGNAEHLNDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x8827F90", Offset = "0x8826590", VA = "0x188827F90")]
		internal object KGJOJFGJAGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x8827EB0", Offset = "0x88264B0", VA = "0x188827EB0")]
		internal object BHMMBDEJDJE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct JDABOIJHCIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public AsyncTaskMethodBuilder<JDKMKDKEGJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public MDPCDPBDELI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public IIOFFKHHPKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private JIAFHOHJBCJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private EFFCNFKHGDB <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private JDKMKDKEGJC <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<(JDKMKDKEGJC validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8827570", Offset = "0x8825B70", VA = "0x188827570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8827E40", Offset = "0x8826440", VA = "0x188827E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private KEDGPMDLKIM ILCCHPCLICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private NLNHABCLGJO GPKNAFMKICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private KFAOLFKLPPG HKFGJNBIMHL;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x88268D0", Offset = "0x8824ED0", VA = "0x1888268D0", Slot = "5")]
	public void FLMOPKJJIJF(DALKFPIOIFA GEJAMCMAAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x88267B0", Offset = "0x8824DB0", VA = "0x1888267B0", Slot = "4")]
	[AsyncStateMachine(typeof(HCMCNGONGAD))]
	private Task<JDKMKDKEGJC> CHKLONMCOMI(MDPCDPBDELI LJHHNBPFKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x8826AC0", Offset = "0x88250C0", VA = "0x188826AC0")]
	private bool LLCDDOCLNHG(KOJHHCPHIHG FHIJCHFCPCC, [Out] JDKMKDKEGJC HPCDHGHHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x8826980", Offset = "0x8824F80", VA = "0x188826980")]
	[AsyncStateMachine(typeof(JDABOIJHCIL))]
	private Task<JDKMKDKEGJC> JHEBJFAMAEJ(MDPCDPBDELI IPMGANOCOKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public IIOFFKHHPKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class FMGDKAJMFHB : JAMLGNMIFIP, NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private struct FBHEJBBKBCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public HNKIFFEICOH GBMCGNKEPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public long OFKIMLAGNFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public Guid? IOKBDNMHANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public bool MDKNKDAPIBN;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct FHNIEJHPEHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public AsyncTaskMethodBuilder<JBNAFHMBIJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public MPGMBCPBAJA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public FMGDKAJMFHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private TaskAwaiter<AHDDLFMPJGL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private TaskAwaiter<JBNAFHMBIJM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x881EBE0", Offset = "0x881D1E0", VA = "0x18881EBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x881F1B0", Offset = "0x881D7B0", VA = "0x18881F1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class NBKOAHOPBPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public NBKOAHOPBPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x8833780", Offset = "0x8831D80", VA = "0x188833780")]
		internal object EPCKIDGKCFJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct HDAKJCEACHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public AsyncTaskMethodBuilder<AHDDLFMPJGL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public FMGDKAJMFHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public MPGMBCPBAJA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private NBKOAHOPBPA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter<AHDDLFMPJGL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x8825480", Offset = "0x8823A80", VA = "0x188825480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8825A70", Offset = "0x8824070", VA = "0x188825A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct LAHHPKGIBAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public AsyncTaskMethodBuilder<JBNAFHMBIJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public FMGDKAJMFHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public MPGMBCPBAJA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public AHDDLFMPJGL roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private TaskAwaiter<FBHEJBBKBCF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x88297A0", Offset = "0x8827DA0", VA = "0x1888297A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x8829D10", Offset = "0x8828310", VA = "0x188829D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class NAGHLJMKGCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public AHDDLFMPJGL roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public NAGHLJMKGCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xF54700", Offset = "0xF52D00", VA = "0x180F54700")]
		internal bool CHLHOPIPNBM(GPFDHCLPDCM sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x88335A0", Offset = "0x8831BA0", VA = "0x1888335A0")]
		internal object BKLGIFEFAKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x88336F0", Offset = "0x8831CF0", VA = "0x1888336F0")]
		internal object PDIIOLEPLJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x8833660", Offset = "0x8831C60", VA = "0x188833660")]
		internal object NEEGNMJIDCC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class DEKGDHLNMAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public NAGHLJMKGCK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public DEKGDHLNMAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x881EAE0", Offset = "0x881D0E0", VA = "0x18881EAE0")]
		internal object BHOAMBFPINA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private struct NMJGKAIBJFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public AsyncTaskMethodBuilder<FBHEJBBKBCF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public AHDDLFMPJGL roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public FMGDKAJMFHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public MPGMBCPBAJA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private DEKGDHLNMAK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private TaskAwaiter<FBHEJBBKBCF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private TaskAwaiter<BEBIDCLFPCH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x88348B0", Offset = "0x8832EB0", VA = "0x1888348B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8835860", Offset = "0x8833E60", VA = "0x188835860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class LJCPLHALFKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public LJCPLHALFKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x882B290", Offset = "0x8829890", VA = "0x18882B290")]
		internal object KKIMNDGHGIC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct ODOKJHJHGFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public AsyncTaskMethodBuilder<FBHEJBBKBCF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public GPFDHCLPDCM subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public FMGDKAJMFHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public MPGMBCPBAJA dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private LJCPLHALFKI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private TaskAwaiter<NCMNMFPILFF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x8835B40", Offset = "0x8834140", VA = "0x188835B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8836200", Offset = "0x8834800", VA = "0x188836200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private FKOJBBBPHKG ACIHABPADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private NAFLOBGIDBA HHBGHAKIGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private JFIJFNKBJKD GMKLHHKBNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private KPCHIGHLFME PJJHJGCMDIB;

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x881FB50", Offset = "0x881E150", VA = "0x18881FB50", Slot = "5")]
	public void FLMOPKJJIJF(DALKFPIOIFA GEJAMCMAAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x881F880", Offset = "0x881DE80", VA = "0x18881F880", Slot = "4")]
	[AsyncStateMachine(typeof(FHNIEJHPEHF))]
	public Task<JBNAFHMBIJM> EBAHACFBBNO(EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, MPGMBCPBAJA AEDAKEMLNJC, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x881FC40", Offset = "0x881E240", VA = "0x18881FC40")]
	[AsyncStateMachine(typeof(HDAKJCEACHB))]
	private Task<AHDDLFMPJGL> GMMEBBHPNAC(MPGMBCPBAJA AEDAKEMLNJC, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x881FDA0", Offset = "0x881E3A0", VA = "0x18881FDA0")]
	[AsyncStateMachine(typeof(LAHHPKGIBAB))]
	private Task<JBNAFHMBIJM> MNILBHAHBNM(MPGMBCPBAJA AEDAKEMLNJC, AHDDLFMPJGL NHAFNMPNAOF, long BKDNOJBOAHD, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x881FF10", Offset = "0x881E510", VA = "0x18881FF10")]
	[AsyncStateMachine(typeof(NMJGKAIBJFP))]
	private Task<FBHEJBBKBCF> PCCLECKLCOM(MPGMBCPBAJA AEDAKEMLNJC, AHDDLFMPJGL NHAFNMPNAOF, long BKDNOJBOAHD, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x881F9E0", Offset = "0x881DFE0", VA = "0x18881F9E0")]
	[AsyncStateMachine(typeof(ODOKJHJHGFE))]
	private Task<FBHEJBBKBCF> EHFAFECODDC(MPGMBCPBAJA LHJPKKOEHKE, GPFDHCLPDCM LFHGJEHABLM, long BKDNOJBOAHD, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public FMGDKAJMFHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[UnityEngine.Scripting.Preserve]
internal sealed class OOHPOELNAMK : APFHKANGDCD, NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class FLNBIPMKJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public MDPCDPBDELI request;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public FLNBIPMKJGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x881F330", Offset = "0x881D930", VA = "0x18881F330")]
		internal object ILOCDGCDIJD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private struct IHJKOBIHJLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder<MDPCDPBDELI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public MDPCDPBDELI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public OOHPOELNAMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public LCHHEHIMOLC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private TaskAwaiter<MDPCDPBDELI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8826130", Offset = "0x8824730", VA = "0x188826130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8826740", Offset = "0x8824D40", VA = "0x188826740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct PBHAPMMKPNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public AsyncTaskMethodBuilder<MDPCDPBDELI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public OOHPOELNAMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public LCHHEHIMOLC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private TaskAwaiter<BFFMACPGCFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x88369B0", Offset = "0x8834FB0", VA = "0x1888369B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8836FB0", Offset = "0x88355B0", VA = "0x188836FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class PGDMEEMDIEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public MDPCDPBDELI request;

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public PGDMEEMDIEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x88371C0", Offset = "0x88357C0", VA = "0x1888371C0")]
		internal object EMAJAKNPDMF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct ADCOJIHOLIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public AsyncTaskMethodBuilder<MDPCDPBDELI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public MDPCDPBDELI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public OOHPOELNAMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public LCHHEHIMOLC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private PCBOKBFNMAK <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private GLPALIFAPMK <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private TaskAwaiter<BFFMACPGCFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8818860", Offset = "0x8816E60", VA = "0x188818860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8819450", Offset = "0x8817A50", VA = "0x188819450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private KEDGPMDLKIM ILCCHPCLICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private HMEIBBFFPJL FEBBGHDEGLF;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private IFDOMAFAHPI NMAKKAFAHOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x88364E0", Offset = "0x8834AE0", VA = "0x1888364E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x8836450", Offset = "0x8834A50", VA = "0x188836450", Slot = "8")]
	public void FLMOPKJJIJF(DALKFPIOIFA GEJAMCMAAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x8836850", Offset = "0x8834E50", VA = "0x188836850", Slot = "4")]
	[AsyncStateMachine(typeof(IHJKOBIHJLN))]
	public Task<MDPCDPBDELI> PIICGANECBC(MDPCDPBDELI IPMGANOCOKF, LCHHEHIMOLC LOLNHDPCOOD, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x8836700", Offset = "0x8834D00", VA = "0x188836700", Slot = "5")]
	[AsyncStateMachine(typeof(PBHAPMMKPNA))]
	public Task<MDPCDPBDELI> NPPEKFKBAIG(CancellationToken KMHHNOGHBLL, LCHHEHIMOLC LOLNHDPCOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x88363A0", Offset = "0x88349A0", VA = "0x1888363A0", Slot = "6")]
	public PFFMPBIDPGL FEIPAHKIBEL(EMNCKDOLLHH KACCELMHHIB, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x8836270", Offset = "0x8834870", VA = "0x188836270", Slot = "7")]
	public PFFMPBIDPGL BFEGEPMFHDB(EMNCKDOLLHH KACCELMHHIB, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x88365A0", Offset = "0x8834BA0", VA = "0x1888365A0")]
	[AsyncStateMachine(typeof(ADCOJIHOLIG))]
	private Task<MDPCDPBDELI> NBDLONAHJEN(MDPCDPBDELI IPMGANOCOKF, LCHHEHIMOLC LOLNHDPCOOD, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC1B0", Offset = "0x3CFA7B0", VA = "0x183CFC1B0")]
	private static byte[] DJBALMLONDE(MDPCDPBDELI CJIMOMNMAGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public OOHPOELNAMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[UnityEngine.Scripting.Preserve]
internal sealed class GFLMBCPKECD : NLNHABCLGJO, NIJFJDBNJOC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private AOENICALHEG HMGHLOHDLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private KEDGPMDLKIM ILCCHPCLICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private KODFNEJDPGD JNOFNLPKHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private HMOKDIKKLGL FNHPJNIGBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private FKOJBBBPHKG ACIHABPADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private LDCCCOIGGJK CPBLHGLGNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private GOHCGKCPCEL ILFFCOLMGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private NAFLOBGIDBA HHBGHAKIGCN;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private NIBBLCAGIDJ IAEGCNMCKDC
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x8821830", Offset = "0x881FE30", VA = "0x188821830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static JDKMKDKEGJC NMGKKEJKHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x8821820", Offset = "0x881FE20", VA = "0x188821820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x8821430", Offset = "0x881FA30", VA = "0x188821430", Slot = "6")]
	public void FLMOPKJJIJF(DALKFPIOIFA GEJAMCMAAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x88212C0", Offset = "0x881F8C0", VA = "0x1888212C0", Slot = "4")]
	public JDKMKDKEGJC CFPMNLPKCLK(KNOJHPOMDED FMDCDGBCECG, KOJHHCPHIHG EBCFJIOFMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x88215A0", Offset = "0x881FBA0", VA = "0x1888215A0", Slot = "5")]
	public JDKMKDKEGJC GFNAHCEAAOE(KNOJHPOMDED DKKOHDCAINF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x88212B0", Offset = "0x881F8B0", VA = "0x1888212B0")]
	private static JDKMKDKEGJC BKDDPJFHFHH(JPKCPLKGCFK CIOGCOOPLBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public GFLMBCPKECD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class DEALBLCNHNB : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x881EAA0", Offset = "0x881D0A0", VA = "0x18881EAA0")]
	public DEALBLCNHNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x798A590", Offset = "0x7988B90", VA = "0x18798A590")]
	public DEALBLCNHNB(string CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[UnityEngine.Scripting.Preserve]
internal sealed class BDGCIMFCOJI : GEEHHCAKHMO, NIJFJDBNJOC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct CADNHPFPMLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public AsyncTaskMethodBuilder<JDKMKDKEGJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public BDGCIMFCOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public FOKPKNFMFMF autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private EHMNEFALKGP<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private LBBFKCLPDNH <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private TaskAwaiter<JDKMKDKEGJC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x883AE90", Offset = "0x8839490", VA = "0x18883AE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x883B860", Offset = "0x8839E60", VA = "0x18883B860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct FFJKHBLKGGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public BDGCIMFCOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x8841E10", Offset = "0x8840410", VA = "0x188841E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x8842570", Offset = "0x8840B70", VA = "0x188842570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct MGJEPACIEDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public BDGCIMFCOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x884DBD0", Offset = "0x884C1D0", VA = "0x18884DBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x884E0E0", Offset = "0x884C6E0", VA = "0x18884E0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct OBMKABKENOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public BDGCIMFCOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x88509A0", Offset = "0x884EFA0", VA = "0x1888509A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x8851160", Offset = "0x884F760", VA = "0x188851160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct PGBFAJGNIDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public BDGCIMFCOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x8854440", Offset = "0x8852A40", VA = "0x188854440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x88545E0", Offset = "0x8852BE0", VA = "0x1888545E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct CKLDDBBJCPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public BDGCIMFCOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x883DE70", Offset = "0x883C470", VA = "0x18883DE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x883E5A0", Offset = "0x883CBA0", VA = "0x18883E5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct MEPMDEFHLDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public BDGCIMFCOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x884D700", Offset = "0x884BD00", VA = "0x18884D700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x884DB70", Offset = "0x884C170", VA = "0x18884DB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct NGFJENOOIBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public BDGCIMFCOJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public LHKOGNCOGAD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private EHMNEFALKGP<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x884E710", Offset = "0x884CD10", VA = "0x18884E710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x884ECB0", Offset = "0x884D2B0", VA = "0x18884ECB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private KEDGPMDLKIM ILCCHPCLICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private DALKFPIOIFA GEJAMCMAAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private FKOJBBBPHKG ACIHABPADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private APFHKANGDCD LGIMMCIELII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private KODFNEJDPGD JNOFNLPKHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private GOHCGKCPCEL ILFFCOLMGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private CancellationTokenSource FBHEHCPJJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private Task DILPMECCKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private TaskCompletionSource<int> MPOPDAHGOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private int FBGJLEPFPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private int DDNCPFCAGOO;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x883A390", Offset = "0x8838990", VA = "0x18883A390", Slot = "6")]
	public void FLMOPKJJIJF(DALKFPIOIFA GEJAMCMAAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x1448650", Offset = "0x1446C50", VA = "0x181448650", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x883A7C0", Offset = "0x8838DC0", VA = "0x18883A7C0")]
	private void IGNOANOABNB(float JINCOGFPLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x883AA30", Offset = "0x8839030", VA = "0x18883AA30", Slot = "4")]
	[AsyncStateMachine(typeof(CADNHPFPMLO))]
	public Task<JDKMKDKEGJC> KLGINGLOCIF(FOKPKNFMFMF MFANCCGGIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x8839D80", Offset = "0x8838380", VA = "0x188839D80", Slot = "5")]
	[AsyncStateMachine(typeof(FFJKHBLKGGJ))]
	public Task AMMFMFOKAPL([Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x1448650", Offset = "0x1446C50", VA = "0x181448650")]
	public void ANCEOCEFIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x883A160", Offset = "0x8838760", VA = "0x18883A160")]
	private LBBFKCLPDNH ECLFBLGONOO(FOKPKNFMFMF MFANCCGGIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x8839F60", Offset = "0x8838560", VA = "0x188839F60")]
	[AsyncStateMachine(typeof(MGJEPACIEDN))]
	private Task CHIHNPHDHPE(CancellationToken BACOGCKOPIE, int OHJBDEEMPBB, MJGCNECCLCM KIGFJAABOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x8839C80", Offset = "0x8838280", VA = "0x188839C80")]
	[AsyncStateMachine(typeof(OBMKABKENOJ))]
	private Task AMAAJMKAPNP(CancellationToken BACOGCKOPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x8839E70", Offset = "0x8838470", VA = "0x188839E70")]
	[AsyncStateMachine(typeof(PGBFAJGNIDP))]
	private Task APGLCEOLOIE([Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x883AB60", Offset = "0x8839160", VA = "0x18883AB60")]
	[AsyncStateMachine(typeof(CKLDDBBJCPJ))]
	private Task MKIKELGAHGC(CancellationToken BACOGCKOPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x8839B80", Offset = "0x8838180", VA = "0x188839B80")]
	[AsyncStateMachine(typeof(MEPMDEFHLDE))]
	private Task ALAIFODNPHF(CancellationToken PCNHPNBLPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x883A8A0", Offset = "0x8838EA0", VA = "0x18883A8A0")]
	private Task KFLDOBFFHCO(LHKOGNCOGAD POKKLCDMDDO, CancellationToken BACOGCKOPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x883A050", Offset = "0x8838650", VA = "0x18883A050")]
	[AsyncStateMachine(typeof(NGFJENOOIBB))]
	private Task DBNGHCNKOIB(LHKOGNCOGAD POKKLCDMDDO, CancellationToken BACOGCKOPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x883A540", Offset = "0x8838B40", VA = "0x18883A540")]
	private bool GDEAAPHPHNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public BDGCIMFCOJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[UnityEngine.Scripting.Preserve]
internal class NFFEFDECNJN : HMOKDIKKLGL, NIJFJDBNJOC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct CCCKPPOEPCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public NFFEFDECNJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private EHMNEFALKGP<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x883BEF0", Offset = "0x883A4F0", VA = "0x18883BEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x883C4B0", Offset = "0x883AAB0", VA = "0x18883C4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038F")]
	private IKIILEMDACF PPLAKJAADCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private DALKFPIOIFA GEJAMCMAAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000391")]
	private NLNHABCLGJO GPKNAFMKICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private APFHKANGDCD LGIMMCIELII;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x884E190", Offset = "0x884C790", VA = "0x18884E190", Slot = "6")]
	public void FLMOPKJJIJF(DALKFPIOIFA GEJAMCMAAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x884E140", Offset = "0x884C740", VA = "0x18884E140", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x884E610", Offset = "0x884CC10", VA = "0x18884E610", Slot = "5")]
	[AsyncStateMachine(typeof(CCCKPPOEPCP))]
	public Task NCHGLJAAMLH(string HIOPFIEJGKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x884E470", Offset = "0x884CA70", VA = "0x18884E470", Slot = "4")]
	public JDKMKDKEGJC GDEAAPHPHNE(KNOJHPOMDED FMDCDGBCECG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x884E4D0", Offset = "0x884CAD0", VA = "0x18884E4D0")]
	private DPKFLPBHCLE GMPGGEAOLGF(string HIOPFIEJGKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public NFFEFDECNJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class DFMNPDOCBBG
{
	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x883EA30", Offset = "0x883D030", VA = "0x18883EA30")]
	public static void DBMPEJKIGAC(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x883EC70", Offset = "0x883D270", VA = "0x18883EC70")]
	internal static void FBNPFHAPJKG(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x883EDD0", Offset = "0x883D3D0", VA = "0x18883EDD0")]
	internal static void JPJNILJJLCK(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x883E600", Offset = "0x883CC00", VA = "0x18883E600")]
	internal static void AKNNJHNLEED(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x3996DD0", Offset = "0x39953D0", VA = "0x183996DD0")]
	private static void DCFAGNDLHCA<Interface, Impl, Interface>(DCNOMJHNEOK FAIEEFHMPLL) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal class ILKCLHAPKHL : DDEOMBDAGAG<MDPCDPBDELI>
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class PPJNHOJPIKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public MDPCDPBDELI message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public PPJNHOJPIKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x88546A0", Offset = "0x8852CA0", VA = "0x1888546A0")]
		internal object EAOCJOGNGBH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly ILKCLHAPKHL FNIBPMLJKFE;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x884B2D0", Offset = "0x88498D0", VA = "0x18884B2D0")]
	public ExitGames.Client.Photon.Hashtable LGGJGPOGIBH(MDPCDPBDELI CJIMOMNMAGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x884AF70", Offset = "0x8849570", VA = "0x18884AF70", Slot = "5")]
	protected override void CNFFMMPKNBE(MDPCDPBDELI CJIMOMNMAGD, IDictionary<object, object> ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x884B0A0", Offset = "0x88496A0", VA = "0x18884B0A0", Slot = "6")]
	public override MDPCDPBDELI FJJOMODMCLM(IDictionary<object, object> ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x884B360", Offset = "0x8849960", VA = "0x18884B360")]
	private static void OAAFJAHOMDO(string FEOGEOCFLBH, MDPCDPBDELI CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x884B7B0", Offset = "0x8849DB0", VA = "0x18884B7B0")]
	public ILKCLHAPKHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x884B470", Offset = "0x8849A70", VA = "0x18884B470")]
	[CompilerGenerated]
	internal static string OMGKIIJADJH(JBNAFHMBIJM INCLIAEIKDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public static class KLCAODMIFMG
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static JDKMKDKEGJC NMGKKEJKHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x884C790", Offset = "0x884AD90", VA = "0x18884C790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x884CA50", Offset = "0x884B050", VA = "0x18884CA50")]
	public static bool NCJDFAKEJNN(this JDKMKDKEGJC DAKFIHCINKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x884C530", Offset = "0x884AB30", VA = "0x18884C530")]
	public static JDKMKDKEGJC BKDDPJFHFHH(JPKCPLKGCFK EEOBLKILFID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x884C590", Offset = "0x884AB90", VA = "0x18884C590")]
	public static JDKMKDKEGJC HLJKIAHAEBO(IEnumerable<JDKMKDKEGJC> BHKDFNJEEOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x884C7F0", Offset = "0x884ADF0", VA = "0x18884C7F0")]
	public static string KCNJFNOEGMH(this JDKMKDKEGJC HPCDHGHHCOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public abstract class OPKGHMCNGGL : MPIGCFEMKOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public delegate JDKMKDKEGJC DMAOBNMLONB([NotNull] KNOJHPOMDED ODLCNMKCNKM);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class GOAJDIFOCJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public KNOJHPOMDED photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public GOAJDIFOCJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1719530", Offset = "0x1717B30", VA = "0x181719530")]
		internal JDKMKDKEGJC LOAJJNCOAFE(DMAOBNMLONB v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private bool DNDJADKEJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	protected readonly HashSet<DMAOBNMLONB> CBHDBPGGCKL;

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x8851520", Offset = "0x884FB20", VA = "0x188851520", Slot = "4")]
	public void EPIFLMCHAGE(DMAOBNMLONB AIEIFPMMCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x8851580", Offset = "0x884FB80", VA = "0x188851580", Slot = "5")]
	public void PLLDICEAALL(DMAOBNMLONB AIEIFPMMCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x88514D0", Offset = "0x884FAD0", VA = "0x1888514D0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x8851230", Offset = "0x884F830", VA = "0x188851230")]
	protected JDKMKDKEGJC DJKBDHNHNNG(KNOJHPOMDED DKKOHDCAINF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x88515E0", Offset = "0x884FBE0", VA = "0x1888515E0")]
	protected OPKGHMCNGGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class LLIMNMIKHOD : OPKGHMCNGGL, AOENICALHEG, MPIGCFEMKOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class PINIGNLMDBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public JDKMKDKEGJC result;

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public PINIGNLMDBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x8854640", Offset = "0x8852C40", VA = "0x188854640")]
		internal object ODALPAIPJJI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x884BEA0", Offset = "0x884A4A0", VA = "0x18884BEA0")]
	[UnityEngine.Scripting.Preserve]
	public LLIMNMIKHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x884D450", Offset = "0x884BA50", VA = "0x18884D450", Slot = "8")]
	public JDKMKDKEGJC EDPMPCGGCPD(KNOJHPOMDED DKKOHDCAINF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class IPPOLGKOAMA : OPKGHMCNGGL, IKIILEMDACF, MPIGCFEMKOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class NOPKCIBGCNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public JDKMKDKEGJC result;

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public NOPKCIBGCNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x88508D0", Offset = "0x884EED0", VA = "0x1888508D0")]
		internal object KJBHBMADHAD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x884BEA0", Offset = "0x884A4A0", VA = "0x18884BEA0")]
	[UnityEngine.Scripting.Preserve]
	public IPPOLGKOAMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x884BD90", Offset = "0x884A390", VA = "0x18884BD90", Slot = "8")]
	public JDKMKDKEGJC GDEAAPHPHNE(KNOJHPOMDED GEHCGKCBEID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal static class IMLJECNCMLO
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private sealed class MDMPJKJMHOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public EHMNEFALKGP<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public MDMPJKJMHOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x884D680", Offset = "0x884BC80", VA = "0x18884D680")]
		internal object HFMHDNKDHKM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x884BBF0", Offset = "0x884A1F0", VA = "0x18884BBF0")]
	public static EHMNEFALKGP<string> JDNDGBEHNDM(LHMKAIAPMBI NDJJBNFFFGK, [Optional] string BEPJOICBAPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x884BB30", Offset = "0x884A130", VA = "0x18884BB30")]
	public static void FEPIOANJAIE(EHMNEFALKGP<string> GPIJGKLDGAC, LHMKAIAPMBI NDJJBNFFFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x884BCD0", Offset = "0x884A2D0", VA = "0x18884BCD0")]
	public static string LGPPGFOMIMN(MDPCDPBDELI LJHHNBPFKDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal static class BBHPLIJKLED
{
	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x8839970", Offset = "0x8837F70", VA = "0x188839970")]
	public static void JNOJINDJKIM(this KEDGPMDLKIM ILCCHPCLICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x8839840", Offset = "0x8837E40", VA = "0x188839840")]
	public static void FNHLLKNMDAF(this KEDGPMDLKIM ILCCHPCLICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x8839850", Offset = "0x8837E50", VA = "0x188839850")]
	private static void INOLPDNFAOG(this KEDGPMDLKIM ILCCHPCLICG, bool BAFFJOPPBLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class HEPBHDANLEN : IJDNGFHAHCO, EJGGMPEHJPP, KNPOGEIDBBM, LMOOPOFGDGI
{
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[DefaultMember("Item")]
	private class CHINODEKBPL : FNFHFOLBALO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly byte EFGKEPFKHGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly int NDLIFLFKGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly object EPBFKKABIHO;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public byte GHAPNAILIOH
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xAC2F90", Offset = "0xAC1590", VA = "0x180AC2F90", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public int BPEKBDECLLM
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xAA5D70", Offset = "0xAA4370", VA = "0x180AA5D70", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public object MCBFLDFKJDI
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public object FCKKEJIGIAA
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x883DDD0", Offset = "0x883C3D0", VA = "0x18883DDD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x7991CB0", Offset = "0x79902B0", VA = "0x187991CB0")]
		public CHINODEKBPL(byte EFGKEPFKHGG, int NDLIFLFKGJD, object EPBFKKABIHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x883DE20", Offset = "0x883C420", VA = "0x18883DE20", Slot = "8")]
		public bool OMCPIMBCGII(byte BLIBAMJKLIA, [Out] object KKGBKLFKCPO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	private readonly EJGGMPEHJPP IJAGGNOEBCA;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public KNOJHPOMDED BINJEDHCNNB
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x8847230", Offset = "0x8845830", VA = "0x188847230", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int DILHBJCAKJF
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x8846C80", Offset = "0x8845280", VA = "0x188846C80", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int DFNHGFBMNCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x88470A0", Offset = "0x88456A0", VA = "0x1888470A0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public KNOJHPOMDED AOCMHBHLIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x8846FB0", Offset = "0x88455B0", VA = "0x188846FB0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool PHFOHDOOMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public int DDDIPAHOJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xA9EFC0", Offset = "0xA9D5C0", VA = "0x180A9EFC0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public string ECACLEPEAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x88470F0", Offset = "0x88456F0", VA = "0x1888470F0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Func<string, string> HBCEKCNKJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x8847450", Offset = "0x8845A50", VA = "0x188847450", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<string, long> DMGJFFIDKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<FNFHFOLBALO> MFOONIBONDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x8847510", Offset = "0x8845B10", VA = "0x188847510", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x8847280", Offset = "0x8845880", VA = "0x188847280", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<bool> HHJDOCEDKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "26")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "27")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<KNOJHPOMDED> IMDOMLKACCL
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action JHCOFLNFHFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x8847000", Offset = "0x8845600", VA = "0x188847000", Slot = "35")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x8846CD0", Offset = "0x88452D0", VA = "0x188846CD0", Slot = "36")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x8846C20", Offset = "0x8845220", VA = "0x188846C20", Slot = "19")]
	public void AGIGLJJJDMJ(string IEDAJGLJHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0xDCEF10", Offset = "0xDCD510", VA = "0x180DCEF10")]
	public HEPBHDANLEN(EJGGMPEHJPP IJAGGNOEBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x8846E50", Offset = "0x8845450", VA = "0x188846E50", Slot = "8")]
	public bool JFEGKCBMLGB(byte FHBJJABHKPG, object HBPOJHGLIJD, JCLKAOOIHID JCIFHCCPGEJ, GMBKBHGPJMD PFJLCJLCCNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x88475C0", Offset = "0x8845BC0", VA = "0x1888475C0", Slot = "20")]
	public KNOJHPOMDED PNNMCBEJHIK(int LPDADLLGOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x8846D70", Offset = "0x8845370", VA = "0x188846D70", Slot = "21")]
	public KNOJHPOMDED JENFDGKHDBJ(int DKGJDLCFPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x8847150", Offset = "0x8845750", VA = "0x188847150", Slot = "22")]
	public KNOJHPOMDED NOHGHGCIFNN(int LPDADLLGOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x8847370", Offset = "0x8845970", VA = "0x188847370", Slot = "23")]
	public IReadOnlyList<KNOJHPOMDED> PADCFKADHOA(bool ABPOGIAJPII = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x8847330", Offset = "0x8845930", VA = "0x188847330", Slot = "24")]
	public IReadOnlyList<KNOJHPOMDED> OOHPNCCGIHE(bool ABPOGIAJPII = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "25")]
	public bool AFPCFFFMDLB(KNOJHPOMDED IIEPGCMOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "28")]
	public void IEFHEPKDIDM(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "29")]
	public void HOKENOKGCOI(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "30")]
	public void GKNLPKPFEEP(object DKFMAIJGPFL, bool BNCAKEBPMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x8846F60", Offset = "0x8845560", VA = "0x188846F60", Slot = "31")]
	public IDisposable KLGOIMBEBIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "32")]
	private bool HIDBMBHLPEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "33")]
	public void DGCIHKAHILO(StringBuilder ALFEMNGJGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x1017290", Offset = "0x1015890", VA = "0x181017290", Slot = "34")]
	public bool PJEGPIFHAPO(bool MOCIIBLGHNI, [Out] string NNDNCFBMBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0xFA3800", Offset = "0xFA1E00", VA = "0x180FA3800", Slot = "37")]
	public void GFOKDFAJHKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct ICHJNGBJMGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly IDictionary<object, object> FLDOIECLDLD;

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0xDE8A40", Offset = "0xDE7040", VA = "0x180DE8A40")]
	public ICHJNGBJMGG(IDictionary<object, object> FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x884A170", Offset = "0x8848770", VA = "0x18884A170")]
	public bool ANNDKKJCMKG([Out] MDPCDPBDELI CJIMOMNMAGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x884A360", Offset = "0x8848960", VA = "0x18884A360")]
	public Guid HMAEPOKNCCC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x884A220", Offset = "0x8848820", VA = "0x18884A220")]
	public JDKMKDKEGJC BBAPMHPCHKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x884A410", Offset = "0x8848A10", VA = "0x18884A410")]
	public static ExitGames.Client.Photon.Hashtable MMBKOMPANAO(MDPCDPBDELI CJIMOMNMAGD, JDKMKDKEGJC DAKFIHCINKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal static class FGEMKJGDGOM
{
	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x88425D0", Offset = "0x8840BD0", VA = "0x1888425D0")]
	public static bool CCELFAIHLKO(this MPGMBCPBAJA GKIIDCPHJMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct EAFIPOGJKBC : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct PBFIACJEKDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public EAFIPOGJKBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x8852AF0", Offset = "0x88510F0", VA = "0x188852AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8852CD0", Offset = "0x88512D0", VA = "0x188852CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly CancellationTokenSource PCGMGJPANKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private bool DNDJADKEJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private Task NPLKHMALANM;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool LAPKEHOOABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x883F070", Offset = "0x883D670", VA = "0x18883F070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x883F200", Offset = "0x883D800", VA = "0x18883F200")]
	public EAFIPOGJKBC(CancellationToken KMHHNOGHBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x883F0A0", Offset = "0x883D6A0", VA = "0x18883F0A0")]
	[AsyncStateMachine(typeof(PBFIACJEKDL))]
	public Task DEIJEPKPFIK(Func<CancellationToken, List<Task>> KBCGBKALINO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x883F1B0", Offset = "0x883D7B0", VA = "0x18883F1B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public readonly struct JFAPNEJCJCM<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct HJDPIFABKDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public AsyncTaskMethodBuilder<FANMKCKHALG<OOEFICMLGFH<TData>, PELIOLHOEHA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public JFAPNEJCJCM<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private TaskAwaiter<FANMKCKHALG<OOEFICMLGFH<TData>, PELIOLHOEHA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x4E0AD60", Offset = "0x4E09360", VA = "0x184E0AD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x478E1B0", Offset = "0x478C7B0", VA = "0x18478E1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	private readonly GBHOJJLKKMG<TGetDataArg, TData> ODPIHOLNHGM;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0xDE8A40", Offset = "0xDE7040", VA = "0x180DE8A40")]
	internal JFAPNEJCJCM(GBHOJJLKKMG<TGetDataArg, TData> GMIGKAKBDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x5199870", Offset = "0x5197E70", VA = "0x185199870")]
	[AsyncStateMachine(typeof(JFAPNEJCJCM<, >.HJDPIFABKDD))]
	public Task<FANMKCKHALG<OOEFICMLGFH<TData>, PELIOLHOEHA>> ILCPIHCKNFA(TGetDataArg DFPJDDAMCPC, string HEONCKMCFNE, EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class PNOMNDHGHMF
{
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x38D0990", Offset = "0x38CEF90", VA = "0x1838D0990")]
	public static JFAPNEJCJCM<TGetDataArg, TData> BFOPDLPDKBM<TGetDataArg, TData>(GBHOJJLKKMG<TGetDataArg, TData> GMIGKAKBDIM)
	{
		return default(JFAPNEJCJCM<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public struct EILCJHBBKGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public readonly int GHAPNAILIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public readonly int? MELHNMCPNKJ;

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x5369610", Offset = "0x5367C10", VA = "0x185369610")]
	public EILCJHBBKGK(int EFGKEPFKHGG, [Optional] int? APJFBDNPGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x883F560", Offset = "0x883DB60", VA = "0x18883F560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface INBADLBCKLH<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHJCHIIPIKG();

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "1")]
	INBADLBCKLH<T> KHGKELNDDKJ(string HJBLCFHEMEA);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "2")]
	INBADLBCKLH<T> NEMEFNLCPAF(NNNBFKJBMLI<T> ALKMHINPCIO);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "3")]
	INBADLBCKLH<T> JBPHGCCMHMH(int AMNMJKOJOJL);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "4")]
	INBADLBCKLH<T> CGELALBKKIM(int AMNMJKOJOJL, FCHCEJHCEBD<T> FKKLHPAJCAE);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface BNKNFMABFHH
{
	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "0")]
	INBADLBCKLH<T> HHHMOINDINK<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NMPINGEOKOP LDELDHBPGDE(Exception CGONOPBDIAB);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EILCJHBBKGK JFNCEFIHLBM(Exception CGONOPBDIAB);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public delegate string NNNBFKJBMLI<in T>(T CGONOPBDIAB) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public delegate int FCHCEJHCEBD<in T>(T CGONOPBDIAB) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal class HKJMKKDNPDL : BNKNFMABFHH
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private delegate string OGFAJJDMONA(Exception CGONOPBDIAB);

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private delegate int MKGOOFDHJMH(Exception CGONOPBDIAB);

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class PODNFEKFCPE<T> : INBADLBCKLH<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class ILJOLOOFPPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public ILJOLOOFPPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			internal string IFBIIOLGHOP(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class FJCLOIMCBAM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public NNNBFKJBMLI<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public FJCLOIMCBAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x4C4BD10", Offset = "0x4C4A310", VA = "0x184C4BD10")]
			internal string BKJGCAHFPNN(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		[CompilerGenerated]
		private sealed class ICMHCKNGHIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public FCHCEJHCEBD<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public ICMHCKNGHIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x4C4BD10", Offset = "0x4C4A310", VA = "0x184C4BD10")]
			internal int OFGDKLMBIKM(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private readonly HKJMKKDNPDL AIIKLDGAOKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private readonly Type AMGCMFMIIJO;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x5900CA0", Offset = "0x58FF2A0", VA = "0x185900CA0")]
		internal PODNFEKFCPE(HKJMKKDNPDL AIIKLDGAOKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x5900A10", Offset = "0x58FF010", VA = "0x185900A10", Slot = "4")]
		public void CHJCHIIPIKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x5900A80", Offset = "0x58FF080", VA = "0x185900A80", Slot = "5")]
		public INBADLBCKLH<T> KHGKELNDDKJ(string HJBLCFHEMEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x5900B90", Offset = "0x58FF190", VA = "0x185900B90", Slot = "6")]
		public INBADLBCKLH<T> NEMEFNLCPAF(NNNBFKJBMLI<T> ALKMHINPCIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x5900A40", Offset = "0x58FF040", VA = "0x185900A40", Slot = "7")]
		public INBADLBCKLH<T> JBPHGCCMHMH(int AMNMJKOJOJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x59008F0", Offset = "0x58FEEF0", VA = "0x1859008F0", Slot = "8")]
		public INBADLBCKLH<T> CGELALBKKIM(int AMNMJKOJOJL, FCHCEJHCEBD<T> FKKLHPAJCAE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	private class CJDNKLHELBJ<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private bool PLFGIJPIDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private readonly List<Type> JLIBGALBIOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private readonly Dictionary<Type, TVal> ALJPNJBBKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private readonly Dictionary<Type, int> JCIAFLEIEEO;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public IReadOnlyList<Type> NGBBIBEOLBC
		{
			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x6875E10", Offset = "0x6874410", VA = "0x186875E10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x6876320", Offset = "0x6874920", VA = "0x186876320")]
		public CJDNKLHELBJ(Dictionary<Type, int> JCIAFLEIEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x6875F10", Offset = "0x6874510", VA = "0x186875F10")]
		public void JDPCENHCAFL(Type BLIBAMJKLIA, TVal FADBOFNILPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x6876090", Offset = "0x6874690", VA = "0x186876090")]
		public bool OHDNOAGDCPK(Type AMGCMFMIIJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x6875ED0", Offset = "0x68744D0", VA = "0x186875ED0")]
		public bool JAMFHEADPDN(TVal KKGBKLFKCPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x6876050", Offset = "0x6874650", VA = "0x186876050")]
		public TVal KBGIPADPFGF(Type JLPANLJHHFI)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x68760D0", Offset = "0x68746D0", VA = "0x1868760D0")]
		[CompilerGenerated]
		private int PNLDNCLPFPK(Type MCBNAPBMEDJ, Type EIIKIKJHNCI)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class NJLHAMABCEH : IEnumerable<EILCJHBBKGK>, IEnumerable, IEnumerator<EILCJHBBKGK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private EILCJHBBKGK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public HKJMKKDNPDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private IEnumerator<EILCJHBBKGK> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private EILCJHBBKGK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x47FF830", Offset = "0x47FDE30", VA = "0x1847FF830", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(EILCJHBBKGK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x884F370", Offset = "0x884D970", VA = "0x18884F370", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4CD30", VA = "0x180F4E730")]
		[DebuggerHidden]
		public NJLHAMABCEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x884F3C0", Offset = "0x884D9C0", VA = "0x18884F3C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x884ED60", Offset = "0x884D360", VA = "0x18884ED60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x884ED10", Offset = "0x884D310", VA = "0x18884ED10")]
		private void APENNGMAANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x884F210", Offset = "0x884D810", VA = "0x18884F210")]
		private void NECCDOCMECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x884F320", Offset = "0x884D920", VA = "0x18884F320", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x884F260", Offset = "0x884D860", VA = "0x18884F260", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EILCJHBBKGK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x884F260", Offset = "0x884D860", VA = "0x18884F260", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private static readonly EILCJHBBKGK AEIIKABNFKC;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private static readonly Dictionary<Type, int> IHIMLLJCLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly HashSet<Type> JMFOCFIENMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly CJDNKLHELBJ<int> FPBDOCDGBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	private readonly CJDNKLHELBJ<MKGOOFDHJMH> LGJLKMMLCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	private readonly CJDNKLHELBJ<OGFAJJDMONA> IDEMAKLGGKB;

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x88481D0", Offset = "0x88467D0", VA = "0x1888481D0")]
	[BNHIEDNKDNA.MLFEBCDGLFC.CIEDAEOKGHH]
	internal static void GLAOIPJFGAH(DCNOMJHNEOK PPICPBELMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x8849300", Offset = "0x8847900", VA = "0x188849300")]
	[RecRoom.NoEngine.Common.Preserve]
	public HKJMKKDNPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x39504A0", Offset = "0x394EAA0", VA = "0x1839504A0", Slot = "4")]
	public INBADLBCKLH<T> HHHMOINDINK<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x88491A0", Offset = "0x88477A0", VA = "0x1888491A0", Slot = "5")]
	public NMPINGEOKOP LDELDHBPGDE(Exception CGONOPBDIAB)
	{
		return default(NMPINGEOKOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x88488C0", Offset = "0x8846EC0", VA = "0x1888488C0", Slot = "6")]
	public EILCJHBBKGK JFNCEFIHLBM(Exception? CGONOPBDIAB)
	{
		return default(EILCJHBBKGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x8848130", Offset = "0x8846730", VA = "0x188848130", Slot = "7")]
	[IteratorStateMachine(typeof(NJLHAMABCEH))]
	public IEnumerable<EILCJHBBKGK> CDHDINCJCBM(Exception CGONOPBDIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x8847FE0", Offset = "0x88465E0", VA = "0x188847FE0", Slot = "8")]
	public string ANKDDKMAIBC(Exception? CGONOPBDIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x8848D10", Offset = "0x8847310", VA = "0x188848D10")]
	private string JHJDJDLDEDI(AggregateException BLNAOOIGHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x8848240", Offset = "0x8846840", VA = "0x188848240")]
	private void HJCALEBOELC(Type AMGCMFMIIJO, int AMNMJKOJOJL, MKGOOFDHJMH? OKKGBGBGDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x8848AC0", Offset = "0x88470C0", VA = "0x188848AC0")]
	private void JGICHGDKCCM(Type AMGCMFMIIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x88485F0", Offset = "0x8846BF0", VA = "0x1888485F0")]
	private void INEMENANKBK(Type AMGCMFMIIJO, OGFAJJDMONA ANCAMDPBPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x8849020", Offset = "0x8847620", VA = "0x188849020")]
	private static int KBKEDAOLOBN(Type AMGCMFMIIJO, Dictionary<Type, int> JCIAFLEIEEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x3B66780", Offset = "0x3B64D80", VA = "0x183B66780")]
	private static bool NLLIEHDLGBE<TVal>(CJDNKLHELBJ<TVal> NIJLHKNCLKB, Type AMGCMFMIIJO, [Out] TVal KKGBKLFKCPO) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x8847F00", Offset = "0x8846500", VA = "0x188847F00")]
	[CompilerGenerated]
	internal static int AEKKJHECLPN(Type OOAPCCCHLEP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public struct NMPINGEOKOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public readonly EILCJHBBKGK EHCDCKLHAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public readonly string BPANGNIFEAE;

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x88508B0", Offset = "0x884EEB0", VA = "0x1888508B0")]
	public NMPINGEOKOP(string ACHJFOMEAPL, EILCJHBBKGK AMNMJKOJOJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x8850810", Offset = "0x884EE10", VA = "0x188850810")]
	public string BECKBADKLCE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public class GAIHMFBPIKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	private readonly EBGNLCHEEDD FAOKCJNEEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private string CDHDFEPFEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private long? HKCPIPHFDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private long? DFPMFJKBEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private long? INDJONFABJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private string CPJIPGEBDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private OHFLHPGOJMC JOOGMIKOMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private long? OJNIIHFNJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private bool DGGINIEHONF;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public string HLGNBBAABIK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public long NBKNBBGJCKI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x88436E0", Offset = "0x8841CE0", VA = "0x1888436E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public long LGDHMJHPDJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x8844440", Offset = "0x8842A40", VA = "0x188844440")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public long JPDGFGLOAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x88444A0", Offset = "0x8842AA0", VA = "0x1888444A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string CGHGOPFPHON
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x8843C80", Offset = "0x8842280", VA = "0x188843C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public OHFLHPGOJMC HFGKFAGJKAB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xAA9EE0", Offset = "0xAA84E0", VA = "0x180AA9EE0")]
		get
		{
			return default(OHFLHPGOJMC);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x8843B90", Offset = "0x8842190", VA = "0x188843B90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public long OMOAMACHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x8843AB0", Offset = "0x88420B0", VA = "0x188843AB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x8844500", Offset = "0x8842B00", VA = "0x188844500")]
	[UnityEngine.Scripting.Preserve]
	public GAIHMFBPIKO([GGNLMCAPMLP(null)] EBGNLCHEEDD FAOKCJNEEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x88441F0", Offset = "0x88427F0", VA = "0x1888441F0")]
	private void LLEFJBGMMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x8843CC0", Offset = "0x88422C0", VA = "0x188843CC0")]
	public void KAJELHBHEJK(long CDFGHIILPDC, long BKDNOJBOAHD, [Optional] long? LICAODAKGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x8844150", Offset = "0x8842750", VA = "0x188844150")]
	public void KDAJDJBIAFC(long LICAODAKGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x8843B10", Offset = "0x8842110", VA = "0x188843B10")]
	public void DEINFNHMCOB(string MEEGOFEGGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x8843740", Offset = "0x8841D40", VA = "0x188843740")]
	public void BNMNPJCHNGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal class PFFMPBIDPGL : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct FHJCFPPNFBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public AsyncTaskMethodBuilder<MDPCDPBDELI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public MDPCDPBDELI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public PFFMPBIDPGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private TaskAwaiter<IFDOMAFAHPI.LGPJPGJMMGD<MDPCDPBDELI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x8842650", Offset = "0x8840C50", VA = "0x188842650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x8842B90", Offset = "0x8841190", VA = "0x188842B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct CABCDJJHNJC<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class ECOIADNLOKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public MDPCDPBDELI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ECOIADNLOKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x883F330", Offset = "0x883D930", VA = "0x18883F330")]
		internal MDPCDPBDELI DNJMJKFBOOO(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct KKPFLCCCHII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public AsyncTaskMethodBuilder<IFDOMAFAHPI.LGPJPGJMMGD<MDPCDPBDELI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public MDPCDPBDELI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public PFFMPBIDPGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private PCBOKBFNMAK <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private TaskAwaiter<IFDOMAFAHPI.LGPJPGJMMGD<MDPCDPBDELI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x884BEB0", Offset = "0x884A4B0", VA = "0x18884BEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x884C4C0", Offset = "0x884AAC0", VA = "0x18884C4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct EKABJFDBJAI<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public PFFMPBIDPGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x478DC20", Offset = "0x478C220", VA = "0x18478DC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x478E1B0", Offset = "0x478C7B0", VA = "0x18478E1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct IMLDJPDGHNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public PFFMPBIDPGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x884B7F0", Offset = "0x8849DF0", VA = "0x18884B7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x884BAD0", Offset = "0x884A0D0", VA = "0x18884BAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class MBAHJLBGCFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public MBAHJLBGCFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x884D620", Offset = "0x884BC20", VA = "0x18884D620")]
		internal object KGBGOPKIHPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x884D560", Offset = "0x884BB60", VA = "0x18884D560")]
		internal bool EAPIKAFDAPF(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class IKLLOIFJOEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public IKLLOIFJOEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x884AF10", Offset = "0x8849510", VA = "0x18884AF10")]
		internal object NLGNJAMIHEN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class OFIFGCHMGBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public OFIFGCHMGBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x88511C0", Offset = "0x884F7C0", VA = "0x1888511C0")]
		internal object EPFFFDJNCFF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class NPDBPHGDBKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public NPDBPHGDBKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x8850930", Offset = "0x884EF30", VA = "0x188850930")]
		internal object FHIMBBFJAKL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class BNCEHJFOBLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public PFFMPBIDPGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BNCEHJFOBLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x883AC50", Offset = "0x8839250", VA = "0x18883AC50")]
		internal object EAOCJOGNGBH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private static readonly Guid NGEMBPJAFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public readonly EMNCKDOLLHH INLICGFLEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	private readonly IFDOMAFAHPI ACDEONDCDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	private readonly KNPOGEIDBBM ILCCHPCLICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	private readonly LMOOPOFGDGI FCMCBPGIICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	private bool OPFEJDCHCNK;

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x8854210", Offset = "0x8852810", VA = "0x188854210")]
	public PFFMPBIDPGL(EMNCKDOLLHH GFCEGHONGDJ, IFDOMAFAHPI ACDEONDCDDN, KNPOGEIDBBM ILCCHPCLICG, LMOOPOFGDGI FCMCBPGIICB, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x88536A0", Offset = "0x8851CA0", VA = "0x1888536A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x88536B0", Offset = "0x8851CB0", VA = "0x1888536B0")]
	public void FLEBFHIHIPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x8853E10", Offset = "0x8852410", VA = "0x188853E10")]
	public void MABHGKMJHLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x8853BF0", Offset = "0x88521F0", VA = "0x188853BF0")]
	public void JBABIOMKHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x8853950", Offset = "0x8851F50", VA = "0x188853950")]
	[AsyncStateMachine(typeof(FHJCFPPNFBG))]
	internal Task<MDPCDPBDELI> HMPPIOOPJCO(EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, MDPCDPBDELI LJHHNBPFKDP, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC1B0", Offset = "0x3CFA7B0", VA = "0x183CFC1B0")]
	private static byte[] LMPHEGHAPLJ<T>(T CJIMOMNMAGD) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x3CFBCD0", Offset = "0x3CFA2D0", VA = "0x183CFBCD0")]
	private static T FGBAANFOJJD<T>(MessageParser<T> IHMPAIIHCAP, byte[] CJIMOMNMAGD, T DAJHIGHJODM) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x8853450", Offset = "0x8851A50", VA = "0x188853450")]
	[AsyncStateMachine(typeof(KKPFLCCCHII))]
	private Task<IFDOMAFAHPI.LGPJPGJMMGD<MDPCDPBDELI>> BFIIHMPGHCO(MDPCDPBDELI LJHHNBPFKDP, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC1C0", Offset = "0x3CFA7C0", VA = "0x183CFC1C0")]
	[AsyncStateMachine(typeof(EKABJFDBJAI<>))]
	internal Task<T> OPADBNOEBNM<T>(CancellationToken BACOGCKOPIE, Func<CancellationToken, Task<T>> ELLBJIGBNKD, int HPHCEELIBLB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x8853FE0", Offset = "0x88525E0", VA = "0x188853FE0")]
	[AsyncStateMachine(typeof(IMLDJPDGHNM))]
	internal Task OPADBNOEBNM(CancellationToken BACOGCKOPIE, Func<CancellationToken, Task> ELLBJIGBNKD, int HPHCEELIBLB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x88533D0", Offset = "0x88519D0", VA = "0x1888533D0")]
	public FEKLHCJEDBF BEJJENGLNMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x8854110", Offset = "0x8852710", VA = "0x188854110")]
	public GLHPBJELIGN PHHJCAOJHPA([Optional] EDBLCFBGHDL GJJIDPBEDPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x8853000", Offset = "0x8851600", VA = "0x188853000")]
	public MCDHDLJKKKH AOIGPIKCPMK([Optional] LHMKAIAPMBI? NDJJBNFFFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x8853270", Offset = "0x8851870", VA = "0x188853270")]
	public void BDPPFOBANIE(Func<Guid, bool> ECJPMDMILND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x8853D00", Offset = "0x8852300", VA = "0x188853D00")]
	public void LFAAHKAOGEC(Func<Guid, bool> POCOLGCEFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x88537D0", Offset = "0x8851DD0", VA = "0x1888537D0")]
	public Guid GJKFAKHHKBD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x8853590", Offset = "0x8851B90", VA = "0x188853590")]
	public void DANJGMHGFDC(Guid MGDNFCPIBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x8853AB0", Offset = "0x88520B0", VA = "0x188853AB0")]
	public void IOMDIJJKGHP(MDPCDPBDELI GNCLMDCBNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x8853ED0", Offset = "0x88524D0", VA = "0x188853ED0")]
	public void OAAFJAHOMDO(string ADJELBKFOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC0D0", Offset = "0x3CFA6D0", VA = "0x183CFC0D0")]
	private T HDFGJOCGMKK<T>(T KKGBKLFKCPO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x8853CB0", Offset = "0x88522B0", VA = "0x188853CB0")]
	public void KEPLPOAONJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x3CFBE20", Offset = "0x3CFA420", VA = "0x183CFBE20")]
	[CompilerGenerated]
	internal static string FMFAHBGLKEC<T>(byte[] IHNKIKDOAOB, int HLHNCCLDLKF, CABCDJJHNJC<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal sealed class FPDOMNOEMGH : EMNCKDOLLHH
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class HADIIMPGHKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public HADIIMPGHKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x8846BB0", Offset = "0x88451B0", VA = "0x188846BB0")]
		internal object NFGNFMIJEJA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct FEPHAEEHGCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public FPDOMNOEMGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public PFFMPBIDPGL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private PIOHADAKEMO <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private GLHPBJELIGN <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<ELMHHAPCGGP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x8840AF0", Offset = "0x883F0F0", VA = "0x188840AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x88419F0", Offset = "0x883FFF0", VA = "0x1888419F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct EMGPGENFAJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public FPDOMNOEMGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private TaskAwaiter<AHDDLFMPJGL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x883F640", Offset = "0x883DC40", VA = "0x18883F640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x883FDE0", Offset = "0x883E3E0", VA = "0x18883FDE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct AKDOFLLHKNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public FPDOMNOEMGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private TaskAwaiter<OIFNFKHALGJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x8839260", Offset = "0x8837860", VA = "0x188839260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x8839570", Offset = "0x8837B70", VA = "0x188839570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private sealed class PPOBPOICBNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public PIOHADAKEMO presence;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public PPOBPOICBNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x88549F0", Offset = "0x8852FF0", VA = "0x1888549F0")]
		internal object CDNHMIJGFEK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private static readonly LHMKAIAPMBI APBBCOJENIN;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private static readonly LHMKAIAPMBI HCIKMLKLIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private readonly JBNAFHMBIJM FPILGCGMMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private readonly MPGMBCPBAJA PCEFELIJEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly EDBLCFBGHDL GJJIDPBEDPI;

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x8843530", Offset = "0x8841B30", VA = "0x188843530")]
	public FPDOMNOEMGH(JBNAFHMBIJM FPILGCGMMOI, MPGMBCPBAJA PCEFELIJEOG, Guid HOFBFGLIONA, DALKFPIOIFA GEJAMCMAAHF, LCHHEHIMOLC POPHBDDGECB, EDBLCFBGHDL GJJIDPBEDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x8843200", Offset = "0x8841800", VA = "0x188843200", Slot = "7")]
	[AsyncStateMachine(typeof(FEPHAEEHGCJ))]
	protected override Task GIFFDGDCGIA(PFFMPBIDPGL MOICONIKBMO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x8843350", Offset = "0x8841950", VA = "0x188843350")]
	[AsyncStateMachine(typeof(EMGPGENFAJP))]
	private Task JFLALBFLNJE(CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x88430F0", Offset = "0x88416F0", VA = "0x1888430F0")]
	[AsyncStateMachine(typeof(AKDOFLLHKNI))]
	private Task<int> BJCJFOCOHPK(CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x8842F20", Offset = "0x8841520", VA = "0x188842F20")]
	private PIOHADAKEMO ADCNPHIFKEH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal class LBBFKCLPDNH : EMNCKDOLLHH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct ICJGDNBOHIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public LBBFKCLPDNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public PFFMPBIDPGL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private TaskAwaiter<NGFAKGBILNI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x884A500", Offset = "0x8848B00", VA = "0x18884A500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x884AEB0", Offset = "0x88494B0", VA = "0x18884AEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly int ODINPCDKCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly FOKPKNFMFMF ICKONMFOJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public readonly long HAHFIFLNJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public readonly long BHAKEMPMPBP;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public NGFAKGBILNI ELONKAPEHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xA4C410", Offset = "0xA4AA10", VA = "0x180A4C410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xA4C320", Offset = "0xA4A920", VA = "0x180A4C320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x884D080", Offset = "0x884B680", VA = "0x18884D080")]
	public LBBFKCLPDNH(Guid HOFBFGLIONA, DALKFPIOIFA GEJAMCMAAHF, LCHHEHIMOLC POPHBDDGECB, int ODINPCDKCPN, FOKPKNFMFMF ICKONMFOJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x884CF60", Offset = "0x884B560", VA = "0x18884CF60", Slot = "7")]
	[AsyncStateMachine(typeof(ICJGDNBOHIM))]
	protected override Task GIFFDGDCGIA(PFFMPBIDPGL MOICONIKBMO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal abstract class PEJOBFKJNID : EMNCKDOLLHH
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class HIHGIPILKAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public PEJOBFKJNID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public AFNFPHMPCJI playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public HIHGIPILKAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x8847E30", Offset = "0x8846430", VA = "0x188847E30")]
		internal Task BBCAENPCECD(EHMNEFALKGP<string>.OJMJGFAOFAB postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x8847E70", Offset = "0x8846470", VA = "0x188847E70")]
		internal object HDCAAKMIDEM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct CHBCBCLEFHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public PEJOBFKJNID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public PFFMPBIDPGL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private HIHGIPILKAB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x883C510", Offset = "0x883AB10", VA = "0x18883C510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x883CE20", Offset = "0x883B420", VA = "0x18883CE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct HOJAHMHEOML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public AFNFPHMPCJI playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public PEJOBFKJNID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x88496A0", Offset = "0x8847CA0", VA = "0x1888496A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x8849C50", Offset = "0x8848250", VA = "0x188849C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x8852FB0", Offset = "0x88515B0", VA = "0x188852FB0")]
	public PEJOBFKJNID(Guid HOFBFGLIONA, DALKFPIOIFA GEJAMCMAAHF, LCHHEHIMOLC POPHBDDGECB, string JBIJKNNNHIH, ICJABCEOLMI FHIJCHFCPCC, bool EBFGADBJFFI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x8852E70", Offset = "0x8851470", VA = "0x188852E70", Slot = "7")]
	[AsyncStateMachine(typeof(CHBCBCLEFHA))]
	protected override Task GIFFDGDCGIA(PFFMPBIDPGL MOICONIKBMO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task BPFALPCLMDB(PFFMPBIDPGL MOICONIKBMO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x8852D30", Offset = "0x8851330", VA = "0x188852D30")]
	[AsyncStateMachine(typeof(HOJAHMHEOML))]
	private Task GGJLGKDHEON(IDisposable POMIDHKKKLF, AFNFPHMPCJI LCMCDFABELH, EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal class LDDHMAMILNN : EMNCKDOLLHH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct ABAKFJLICEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public LDDHMAMILNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public PFFMPBIDPGL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private TaskAwaiter<IOGPAGLBJEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x8838050", Offset = "0x8836650", VA = "0x188838050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x8838640", Offset = "0x8836C40", VA = "0x188838640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	private readonly LHKOGNCOGAD POKKLCDMDDO;

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x884D3B0", Offset = "0x884B9B0", VA = "0x18884D3B0")]
	public LDDHMAMILNN(Guid HOFBFGLIONA, DALKFPIOIFA GEJAMCMAAHF, LCHHEHIMOLC POPHBDDGECB, LHKOGNCOGAD POKKLCDMDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x884D2D0", Offset = "0x884B8D0", VA = "0x18884D2D0", Slot = "6")]
	protected override string LNAOMPNCGBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x884D1B0", Offset = "0x884B7B0", VA = "0x18884D1B0", Slot = "7")]
	[AsyncStateMachine(typeof(ABAKFJLICEP))]
	protected override Task GIFFDGDCGIA(PFFMPBIDPGL MOICONIKBMO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal abstract class EMNCKDOLLHH : CDFFLGJDJOC
{
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	public delegate Task EIHGHOFOJHI(EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class FICMNMPMNNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public EMNCKDOLLHH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public FICMNMPMNNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x8842C00", Offset = "0x8841200", VA = "0x188842C00")]
		internal Task NFANINKJMBG(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class ABHBPCKMKME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public FICMNMPMNNK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ABHBPCKMKME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x88386A0", Offset = "0x8836CA0", VA = "0x1888386A0")]
		internal object NHLLCFCGDKJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct NMNOILAKJOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public EMNCKDOLLHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public Func<EMNCKDOLLHH, EHMNEFALKGP<string>.OJMJGFAOFAB, PFFMPBIDPGL> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private FICMNMPMNNK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private PFFMPBIDPGL <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter<MDPCDPBDELI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x884F510", Offset = "0x884DB10", VA = "0x18884F510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x88507B0", Offset = "0x884EDB0", VA = "0x1888507B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct ABIMDJEDFFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x8838760", Offset = "0x8836D60", VA = "0x188838760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x8839200", Offset = "0x8837800", VA = "0x188839200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct FFGCENLCLBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public EMNCKDOLLHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x8841A50", Offset = "0x8840050", VA = "0x188841A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x8841DB0", Offset = "0x88403B0", VA = "0x188841DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public readonly Guid LKALCKLEAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public readonly ByteString GIKKBCDKGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public readonly LCHHEHIMOLC NBDIJKJOECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	protected readonly string BCHDLIKJEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private readonly DALKFPIOIFA GEJAMCMAAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private readonly bool EBFGADBJFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private readonly Queue<EIHGHOFOJHI> KDEAHKACJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private readonly PFPFHKOPDKJ MEECKEMEKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private readonly ICJABCEOLMI FHIJCHFCPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private bool BBOELIGGOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public OHFLHPGOJMC HEDFEDHADJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public OHFLHPGOJMC NAEAEJCIFNJ;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public DALKFPIOIFA LJEBHODLNOD
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public FKOJBBBPHKG NPBKIMIDKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x8840360", Offset = "0x883E960", VA = "0x188840360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public EPGNDILKKFC MAAOCEJIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x8840430", Offset = "0x883EA30", VA = "0x188840430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public NIBBLCAGIDJ IAEGCNMCKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x8840910", Offset = "0x883EF10", VA = "0x188840910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event CNAAIHJLCGH DECFFNKCHGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x88402C0", Offset = "0x883E8C0", VA = "0x1888402C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x8840570", Offset = "0x883EB70", VA = "0x188840570", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x8840990", Offset = "0x883EF90", VA = "0x188840990")]
	protected EMNCKDOLLHH(Guid HOFBFGLIONA, DALKFPIOIFA GEJAMCMAAHF, LCHHEHIMOLC POPHBDDGECB, string JBIJKNNNHIH, ICJABCEOLMI FHIJCHFCPCC, bool EBFGADBJFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x8840850", Offset = "0x883EE50", VA = "0x188840850", Slot = "6")]
	protected virtual string LNAOMPNCGBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x88402E0", Offset = "0x883E8E0", VA = "0x1888402E0")]
	public void EAONNJDEHME(EIHGHOFOJHI LKDLEEGIIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x8840340", Offset = "0x883E940", VA = "0x188840340")]
	protected void GGLBFFBFLHE(float CMGKLEEINPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x8840590", Offset = "0x883EB90", VA = "0x188840590")]
	[AsyncStateMachine(typeof(NMNOILAKJOO))]
	public Task JNJJALJCEOA(CancellationToken KMHHNOGHBLL, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, [Optional] Func<EMNCKDOLLHH, EHMNEFALKGP<string>.OJMJGFAOFAB, PFFMPBIDPGL> JACCDJNNKLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x883FF60", Offset = "0x883E560", VA = "0x18883FF60")]
	[AsyncStateMachine(typeof(ABIMDJEDFFO))]
	private static Task AOBGNAHBMBF(Func<CancellationToken, Task> NHNBEJKPCHB, Func<CancellationToken, Task> JEOICIGLMAJ, CancellationToken BACOGCKOPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x88406E0", Offset = "0x883ECE0", VA = "0x1888406E0")]
	private void KGAPJGOLIJD(bool DDMLMBGCPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x8840090", Offset = "0x883E690", VA = "0x188840090")]
	private void CCLIHOPDFOE(PFFMPBIDPGL MOICONIKBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task GIFFDGDCGIA(PFFMPBIDPGL MOICONIKBMO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x883FE40", Offset = "0x883E440", VA = "0x18883FE40")]
	[AsyncStateMachine(typeof(FFGCENLCLBF))]
	private Task AHEEIHJAFML(EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x8840890", Offset = "0x883EE90", VA = "0x188840890")]
	public MDPCDPBDELI PEGNPPGHHGM(PCBOKBFNMAK PCPNKNFOIMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x8840480", Offset = "0x883EA80", VA = "0x188840480")]
	[CompilerGenerated]
	private Task JFMOKHHEEGO(CancellationToken MMMCFFENLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x88403B0", Offset = "0x883E9B0", VA = "0x1888403B0")]
	[CompilerGenerated]
	private object IPHGNMHLELD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal sealed class BCEDEKPAKMO : PEJOBFKJNID
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct HHIMMKCMEGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public BCEDEKPAKMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public PFFMPBIDPGL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private DLDIJLNEIBF <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private GLHPBJELIGN <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x8847660", Offset = "0x8845C60", VA = "0x188847660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x8847DD0", Offset = "0x88463D0", VA = "0x188847DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private readonly JBNAFHMBIJM OHAGMIMNEEK;

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x8839AD0", Offset = "0x88380D0", VA = "0x188839AD0")]
	public BCEDEKPAKMO(Guid HOFBFGLIONA, DALKFPIOIFA GEJAMCMAAHF, JBNAFHMBIJM OHAGMIMNEEK, LCHHEHIMOLC POPHBDDGECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x8839980", Offset = "0x8837F80", VA = "0x188839980", Slot = "8")]
	[AsyncStateMachine(typeof(HHIMMKCMEGA))]
	protected override Task BPFALPCLMDB(PFFMPBIDPGL MOICONIKBMO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal class DPKFLPBHCLE : EMNCKDOLLHH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct KPLOFOIAHDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public DPKFLPBHCLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public PFFMPBIDPGL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private TaskAwaiter<IOGPAGLBJEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x884CA70", Offset = "0x884B070", VA = "0x18884CA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x884CF00", Offset = "0x884B500", VA = "0x18884CF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private readonly string DBHEFABHDIL;

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x883EFC0", Offset = "0x883D5C0", VA = "0x18883EFC0")]
	public DPKFLPBHCLE(Guid HOFBFGLIONA, DALKFPIOIFA GEJAMCMAAHF, LCHHEHIMOLC POPHBDDGECB, string DBHEFABHDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x883EEB0", Offset = "0x883D4B0", VA = "0x18883EEB0", Slot = "7")]
	[AsyncStateMachine(typeof(KPLOFOIAHDJ))]
	protected override Task GIFFDGDCGIA(PFFMPBIDPGL MOICONIKBMO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal class GJBBJGIEEKP : PEJOBFKJNID
{
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class AOGAJDJBFBC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000133")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004AD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004AE")]
			public AsyncTaskMethodBuilder<MDPCDPBDELI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004AF")]
			public AOGAJDJBFBC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B0")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			private TaskAwaiter<IOGPAGLBJEO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			private TaskAwaiter<MDPCDPBDELI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x8854B30", Offset = "0x8853130", VA = "0x188854B30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0x8855020", Offset = "0x8853620", VA = "0x188855020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public GJBBJGIEEKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public MCDHDLJKKKH serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public HHKCKLCLDME roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public FEKLHCJEDBF uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public LOOEEGLMAPD roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public AOGAJDJBFBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x8839720", Offset = "0x8837D20", VA = "0x188839720")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<MDPCDPBDELI> CLIKIDNPACO(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct CHGDHCNJEIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public GJBBJGIEEKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public PFFMPBIDPGL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private AOGAJDJBFBC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private DLDIJLNEIBF <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private GLHPBJELIGN <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private MDPCDPBDELI <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private TaskAwaiter<MDPCDPBDELI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x883CE80", Offset = "0x883B480", VA = "0x18883CE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x883DD70", Offset = "0x883C370", VA = "0x18883DD70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	private static readonly LHMKAIAPMBI APBBCOJENIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private readonly int CPHKAGOKACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	[CanBeNull]
	private readonly OBKGFFDIEBB KNJBGLOGECM;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x8844A00", Offset = "0x8843000", VA = "0x188844A00")]
	public GJBBJGIEEKP(Guid HOFBFGLIONA, DALKFPIOIFA GEJAMCMAAHF, int CPHKAGOKACI, OBKGFFDIEBB KNJBGLOGECM, LCHHEHIMOLC POPHBDDGECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x8844710", Offset = "0x8842D10", VA = "0x188844710", Slot = "8")]
	[AsyncStateMachine(typeof(CHGDHCNJEIG))]
	protected override Task BPFALPCLMDB(PFFMPBIDPGL MOICONIKBMO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x8844850", Offset = "0x8842E50", VA = "0x188844850")]
	private void MFKHGLBGFCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x8844540", Offset = "0x8842B40", VA = "0x188844540")]
	private void ANCFMJNIGLA(EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, DLDIJLNEIBF HFPKGHFHAFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal class FNAKBHDMGAB : EMNCKDOLLHH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct PANAJIKMBIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public FNAKBHDMGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private DLDIJLNEIBF <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private OIFNFKHALGJ <currentRoomSave>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private MODONOMENDG<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private TaskAwaiter<OIFNFKHALGJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private TaskAwaiter<NGFAKGBILNI> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x8851670", Offset = "0x884FC70", VA = "0x188851670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x8852A90", Offset = "0x8851090", VA = "0x188852A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private readonly int CPHKAGOKACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private readonly OBKGFFDIEBB KNJBGLOGECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	private Func<IOGPAGLBJEO, IOGPAGLBJEO> GPPAHEIGFPJ;

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x8842E60", Offset = "0x8841460", VA = "0x188842E60")]
	public FNAKBHDMGAB(Guid HOFBFGLIONA, DALKFPIOIFA GEJAMCMAAHF, int CPHKAGOKACI, OBKGFFDIEBB KNJBGLOGECM, Func<IOGPAGLBJEO, IOGPAGLBJEO> GPPAHEIGFPJ, LCHHEHIMOLC POPHBDDGECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x8842D30", Offset = "0x8841330", VA = "0x188842D30", Slot = "7")]
	[AsyncStateMachine(typeof(PANAJIKMBIJ))]
	protected override Task GIFFDGDCGIA(PFFMPBIDPGL MOICONIKBMO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal abstract class GLCLDFDBPJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public readonly EMNCKDOLLHH INLICGFLEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public readonly PFFMPBIDPGL OKEKDDANHGL;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public FKOJBBBPHKG NPBKIMIDKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x8844AB0", Offset = "0x88430B0", VA = "0x188844AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public NIBBLCAGIDJ IAEGCNMCKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x8844C20", Offset = "0x8843220", VA = "0x188844C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x8844CB0", Offset = "0x88432B0", VA = "0x188844CB0")]
	protected GLCLDFDBPJP(PFFMPBIDPGL MOICONIKBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x8844B00", Offset = "0x8843100", VA = "0x188844B00")]
	protected void OAAFJAHOMDO(string ADJELBKFOBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct CAEJMEKKHNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public Dictionary<Guid, List<GOOCAHGGBEP>> AOCIDBFCCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public Dictionary<Guid, List<GOOCAHGGBEP>> CCHLECPHGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public Dictionary<Guid, List<GOOCAHGGBEP>> OMMADODMEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public List<Guid> FHEAIKJILLG;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x883B8D0", Offset = "0x8839ED0", VA = "0x18883B8D0")]
	public static CAEJMEKKHNA KBGIPADPFGF(FKOJBBBPHKG ACIHABPADPI, OHFLHPGOJMC OBLNDDMADKE, JBAPOOINJKO AOJKEENFNFP)
	{
		return default(CAEJMEKKHNA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct COCKCPMKIAM
{
	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450")]
	public static COCKCPMKIAM MMBKOMPANAO()
	{
		return default(COCKCPMKIAM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct ANOBLFNCFNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public readonly AHDDLFMPJGL FHNEJLIAKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public readonly GPFDHCLPDCM NJAPGLBIHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public readonly Guid? JJMDOACODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public readonly IReadOnlyCollection<IAAKCJFJKMO> HLPNFPMJBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public readonly IReadOnlyCollection<IAAKCJFJKMO> HLLHJGPMONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public readonly HNKIFFEICOH IDFCIPJEKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public readonly HNKIFFEICOH NMGICMHGEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public readonly BEBIDCLFPCH HEBDPKFEKJH;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool JINEJEFLNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x88395E0", Offset = "0x8837BE0", VA = "0x1888395E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x8839670", Offset = "0x8837C70", VA = "0x188839670")]
	public ANOBLFNCFNO(AHDDLFMPJGL FHNEJLIAKMI, GPFDHCLPDCM NJAPGLBIHKN, Guid? JJMDOACODNI, IReadOnlyList<IAAKCJFJKMO> HLPNFPMJBOA, IReadOnlyCollection<IAAKCJFJKMO> HLLHJGPMONJ, HNKIFFEICOH IDFCIPJEKLJ, HNKIFFEICOH NMGICMHGEIB, BEBIDCLFPCH HEBDPKFEKJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct IAJGBNCOIBH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private readonly PFFMPBIDPGL MOICONIKBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private readonly Guid MGDNFCPIBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private bool DDMLMBGCPOD;

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x8849FA0", Offset = "0x88485A0", VA = "0x188849FA0")]
	public static IAJGBNCOIBH GJKFAKHHKBD(PFFMPBIDPGL MOICONIKBMO)
	{
		return default(IAJGBNCOIBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x1294CB0", Offset = "0x12932B0", VA = "0x181294CB0")]
	public void PFGEIAMAJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x8849EF0", Offset = "0x88484F0", VA = "0x188849EF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x8849FD0", Offset = "0x88485D0", VA = "0x188849FD0")]
	private IAJGBNCOIBH(PFFMPBIDPGL MOICONIKBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x8849CB0", Offset = "0x88482B0", VA = "0x188849CB0")]
	private void DANJGMHGFDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x8849F00", Offset = "0x8848500", VA = "0x188849F00")]
	private Func<Guid, bool> FAHNEOFNFHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal class GLHPBJELIGN : GLCLDFDBPJP, CDFFLGJDJOC
{
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public delegate Task<OHFLHPGOJMC> AGNFOANJBHM(JBAPOOINJKO ACJFHCNBBBO, DLEADHPIGIL JMKIFEOKKLB, PFPFHKOPDKJ AMHFLHGINAG, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct FJBBFEDCDEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public JBNAFHMBIJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private IAJGBNCOIBH <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private TaskAwaiter<MDPCDPBDELI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x885CB10", Offset = "0x885B110", VA = "0x18885CB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x885D250", Offset = "0x885B850", VA = "0x18885D250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct FGDEOJIDCBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public AsyncTaskMethodBuilder<MDPCDPBDELI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public JBNAFHMBIJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private TaskAwaiter<MDPCDPBDELI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x885B100", Offset = "0x8859700", VA = "0x18885B100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x885B530", Offset = "0x8859B30", VA = "0x18885B530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct LMFCEDIIMDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public JBNAFHMBIJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x8864A50", Offset = "0x8863050", VA = "0x188864A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x8864F10", Offset = "0x8863510", VA = "0x188864F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class ODIPCCIPBJC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000143")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			public AsyncTaskMethodBuilder<ANOBLFNCFNO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public ODIPCCIPBJC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			private ANOBLFNCFNO <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			private TaskAwaiter<OHFLHPGOJMC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			private TaskAwaiter<ANOBLFNCFNO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x886AE20", Offset = "0x8869420", VA = "0x18886AE20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x886B6E0", Offset = "0x8869CE0", VA = "0x18886B6E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000144")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000516")]
			public AsyncTaskMethodBuilder<JBAPOOINJKO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000517")]
			public ODIPCCIPBJC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000518")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000519")]
			private JBAPOOINJKO <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400051A")]
			private TaskAwaiter<OHFLHPGOJMC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400051B")]
			private TaskAwaiter<JBAPOOINJKO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x886B750", Offset = "0x8869D50", VA = "0x18886B750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x886BDA0", Offset = "0x886A3A0", VA = "0x18886BDA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public JBNAFHMBIJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public PFPFHKOPDKJ preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public PFPFHKOPDKJ downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public ANOBLFNCFNO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public PFPFHKOPDKJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public JBAPOOINJKO phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public AGHKNMPOBEI.CHKBJJABKDO <>9__5;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ODIPCCIPBJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x88686B0", Offset = "0x8866CB0", VA = "0x1888686B0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<ANOBLFNCFNO> AKJIPNADDAH(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x8868840", Offset = "0x8866E40", VA = "0x188868840")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<JBAPOOINJKO> JDBHCGCHFCP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x88689A0", Offset = "0x8866FA0", VA = "0x1888689A0")]
		internal void OIJHNJLPKLH(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x8868800", Offset = "0x8866E00", VA = "0x188868800")]
		internal Task HMFJNLPLIDL(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x8868960", Offset = "0x8866F60", VA = "0x188868960")]
		internal Task LCIPOINJHLM(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct GMBOEBKLECB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public JBNAFHMBIJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private ODIPCCIPBJC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private TaskAwaiter<ANOBLFNCFNO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private TaskAwaiter<JBAPOOINJKO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x885D2B0", Offset = "0x885B8B0", VA = "0x18885D2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x885DF80", Offset = "0x885C580", VA = "0x18885DF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct FDFGFCENGMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public JBAPOOINJKO phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public PFPFHKOPDKJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private TaskAwaiter<OHFLHPGOJMC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private DLEADHPIGIL <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x885A240", Offset = "0x8858840", VA = "0x18885A240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x885B0A0", Offset = "0x88596A0", VA = "0x18885B0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct ABJBAFPDKKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x8856740", Offset = "0x8854D40", VA = "0x188856740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x8856F20", Offset = "0x8855520", VA = "0x188856F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct ELOGHHMGILG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public PFPFHKOPDKJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private TaskAwaiter<OHFLHPGOJMC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x8859310", Offset = "0x8857910", VA = "0x188859310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x8859B50", Offset = "0x8858150", VA = "0x188859B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct AAOHPGPDGOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public AsyncTaskMethodBuilder<OHFLHPGOJMC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public PFPFHKOPDKJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private TaskAwaiter<OHFLHPGOJMC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x8855710", Offset = "0x8853D10", VA = "0x188855710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x88566D0", Offset = "0x8854CD0", VA = "0x1888566D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct JDFCPFMGCIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public AsyncTaskMethodBuilder<OHFLHPGOJMC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public PFPFHKOPDKJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public DLEADHPIGIL timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private TaskAwaiter<OHFLHPGOJMC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x8860580", Offset = "0x885EB80", VA = "0x188860580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x8861690", Offset = "0x885FC90", VA = "0x188861690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct HMKBNLBJBFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public AsyncTaskMethodBuilder<OHFLHPGOJMC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public OHFLHPGOJMC operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public PFPFHKOPDKJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public JBAPOOINJKO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private TaskAwaiter<OHFLHPGOJMC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x885E700", Offset = "0x885CD00", VA = "0x18885E700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x885E960", Offset = "0x885CF60", VA = "0x18885E960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class DJAMIMFFDAA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014E")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			public AsyncTaskMethodBuilder<OHFLHPGOJMC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			public DJAMIMFFDAA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			private AFBNCPDOCOC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			private TaskAwaiter<OHFLHPGOJMC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x886BE10", Offset = "0x886A410", VA = "0x18886BE10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x886C440", Offset = "0x886AA40", VA = "0x18886C440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public PFPFHKOPDKJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public AGNFOANJBHM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public DLEADHPIGIL timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public OHFLHPGOJMC originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public DJAMIMFFDAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x88580E0", Offset = "0x88566E0", VA = "0x1888580E0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<OHFLHPGOJMC> ONAHKMBODDA(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct PJLMACFJOGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public AsyncTaskMethodBuilder<OHFLHPGOJMC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public PFPFHKOPDKJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public AGNFOANJBHM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public DLEADHPIGIL timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private TaskAwaiter<OHFLHPGOJMC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x8869E80", Offset = "0x8868480", VA = "0x188869E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x886A3A0", Offset = "0x88689A0", VA = "0x18886A3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct KDOJABCGFDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public PFPFHKOPDKJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private OHFLHPGOJMC <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private IEnumerator<OHFLHPGOJMC> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private TaskAwaiter<OHFLHPGOJMC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x8862A00", Offset = "0x8861000", VA = "0x188862A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x8862F60", Offset = "0x8861560", VA = "0x188862F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct NJBBFNPDHJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x8868360", Offset = "0x8866960", VA = "0x188868360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x8868650", Offset = "0x8866C50", VA = "0x188868650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct IIAKNOOHLDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x885EFB0", Offset = "0x885D5B0", VA = "0x18885EFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x885F1E0", Offset = "0x885D7E0", VA = "0x18885F1E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class BAIFFPECABL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public AsyncTaskMethodBuilder<OHFLHPGOJMC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			public BAIFFPECABL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			public JBAPOOINJKO data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			public PFPFHKOPDKJ progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400059B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400059C")]
			private TaskAwaiter<OHFLHPGOJMC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400059D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			private TaskAwaiter<BFGBENOAGHM> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x886C4B0", Offset = "0x886AAB0", VA = "0x18886C4B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x886CF80", Offset = "0x886B580", VA = "0x18886CF80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public FJJIMNOHOPC mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BAIFFPECABL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x8856F80", Offset = "0x8855580", VA = "0x188856F80")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<OHFLHPGOJMC> OMABNOJFMCM(JBAPOOINJKO data, DLEADHPIGIL _, PFPFHKOPDKJ progressTracker, EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct NEJLINAEAAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public JBAPOOINJKO phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public PFPFHKOPDKJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private BAIFFPECABL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private DLEADHPIGIL <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private TaskAwaiter<OHFLHPGOJMC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x8866FB0", Offset = "0x88655B0", VA = "0x188866FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x8867E00", Offset = "0x8866400", VA = "0x188867E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct EDGDOKNMPJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x8858EB0", Offset = "0x88574B0", VA = "0x188858EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x88592B0", Offset = "0x88578B0", VA = "0x1888592B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct EMECKNBDNJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public AsyncTaskMethodBuilder<OHFLHPGOJMC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public GLHPBJELIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public PFPFHKOPDKJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private TaskAwaiter<OHFLHPGOJMC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x8859BB0", Offset = "0x88581B0", VA = "0x188859BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x885A1D0", Offset = "0x88587D0", VA = "0x18885A1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private readonly ANCHKNHFGEI PLICNKEPGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private readonly ANCHKNHFGEI LJBKFLAIGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private readonly GAIHMFBPIKO ACEKANILHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private readonly NFBEFIFEAJP CIOPFLOEEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private readonly CHPAFPMKFIA FGAGHDCFAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private ProfilerCounterValue<int> JJFHMLHCJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private readonly AFLGFKBHKAI JJKAIBHDMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private readonly EDBLCFBGHDL GJJIDPBEDPI;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private DALKFPIOIFA LJEBHODLNOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x8844D10", Offset = "0x8843310", VA = "0x188844D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event CNAAIHJLCGH DECFFNKCHGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x8845280", Offset = "0x8843880", VA = "0x188845280", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x8845F90", Offset = "0x8844590", VA = "0x188845F90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x88468D0", Offset = "0x8844ED0", VA = "0x1888468D0")]
	public GLHPBJELIGN(PFFMPBIDPGL MOICONIKBMO, EDBLCFBGHDL GJJIDPBEDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x8846340", Offset = "0x8844940", VA = "0x188846340")]
	[AsyncStateMachine(typeof(FJBBFEDCDEH))]
	public Task OHEPBHFLHEL(JBNAFHMBIJM IPMGANOCOKF, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x8845810", Offset = "0x8843E10", VA = "0x188845810")]
	[AsyncStateMachine(typeof(FGDEOJIDCBG))]
	private Task<MDPCDPBDELI> GEJDKOIMKCE(JBNAFHMBIJM IPMGANOCOKF, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x88461F0", Offset = "0x88447F0", VA = "0x1888461F0")]
	[AsyncStateMachine(typeof(LMFCEDIIMDK))]
	private Task NCPDMKPEKLM(JBNAFHMBIJM IPMGANOCOKF, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x8844D40", Offset = "0x8843340", VA = "0x188844D40")]
	[AsyncStateMachine(typeof(GMBOEBKLECB))]
	private Task ALPGIDGPKBK(JBNAFHMBIJM IPMGANOCOKF, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken APLLPELDOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x88465E0", Offset = "0x8844BE0", VA = "0x1888465E0")]
	[AsyncStateMachine(typeof(FDFGFCENGMD))]
	private Task OLOLMGNNACH(JBAPOOINJKO BBKHIBDOFMG, PFPFHKOPDKJ JCGBEHNEILO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken BOMDCMIHJMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x8845E30", Offset = "0x8844430", VA = "0x188845E30")]
	[AsyncStateMachine(typeof(ABJBAFPDKKF))]
	private Task JBJKAOGKPMF(EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x8845C90", Offset = "0x8844290", VA = "0x188845C90")]
	[AsyncStateMachine(typeof(ELOGHHMGILG))]
	private Task IKFLIGDFLGC(JBAPOOINJKO ACJFHCNBBBO, PFPFHKOPDKJ AMHFLHGINAG, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x8846730", Offset = "0x8844D30", VA = "0x188846730")]
	[AsyncStateMachine(typeof(AAOHPGPDGOP))]
	private Task<OHFLHPGOJMC> PHCDIJOOHOP(JBAPOOINJKO ACJFHCNBBBO, DLEADHPIGIL FGLGGNKFBOG, PFPFHKOPDKJ AMHFLHGINAG, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x88452A0", Offset = "0x88438A0", VA = "0x1888452A0")]
	[AsyncStateMachine(typeof(JDFCPFMGCIM))]
	private Task<OHFLHPGOJMC> DNEHHFOPNBI(JBAPOOINJKO ACJFHCNBBBO, DLEADHPIGIL FGLGGNKFBOG, PFPFHKOPDKJ AMHFLHGINAG, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x88455C0", Offset = "0x8843BC0", VA = "0x1888455C0")]
	[AsyncStateMachine(typeof(HMKBNLBJBFG))]
	private Task<OHFLHPGOJMC> FHIDAJGKLLO(OHFLHPGOJMC OBLNDDMADKE, JBAPOOINJKO AOJKEENFNFP, PFPFHKOPDKJ AMHFLHGINAG, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL, bool JFEOLEBOMCF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x8845190", Offset = "0x8843790", VA = "0x188845190")]
	private bool DFMEFEABBCF(JBAPOOINJKO BBKHIBDOFMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x8845B00", Offset = "0x8844100", VA = "0x188845B00")]
	[AsyncStateMachine(typeof(PJLMACFJOGB))]
	protected Task<OHFLHPGOJMC> HMMAPPJOCJF(JBAPOOINJKO ACJFHCNBBBO, DLEADHPIGIL FGLGGNKFBOG, PFPFHKOPDKJ AMHFLHGINAG, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL, AGNFOANJBHM PIDFPKDLFKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x8846490", Offset = "0x8844A90", VA = "0x188846490")]
	[AsyncStateMachine(typeof(KDOJABCGFDP))]
	private Task OJDNPCBOJAC(JBAPOOINJKO ACJFHCNBBBO, PFPFHKOPDKJ AMHFLHGINAG, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x8845F40", Offset = "0x8844540", VA = "0x188845F40")]
	private void JCMFFKIKAFM(OHFLHPGOJMC BJAHCNGKGOH, PFPFHKOPDKJ AMHFLHGINAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x8845420", Offset = "0x8843A20", VA = "0x188845420")]
	private void EEBPDHBNKDM(OHFLHPGOJMC EHIIGICLCEO, [Out] OHFLHPGOJMC ICKPBPIFKMN, [Out] OHFLHPGOJMC IGMIBNGBIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x8846890", Offset = "0x8844E90", VA = "0x188846890")]
	private Task<ANOBLFNCFNO> PIJDNMFKIHF(JBNAFHMBIJM IPMGANOCOKF, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x8845970", Offset = "0x8843F70", VA = "0x188845970")]
	private Task<JBAPOOINJKO> GHLLPGEGBHK(ANOBLFNCFNO ACJFHCNBBBO, AGHKNMPOBEI.CHKBJJABKDO KHONJAPCKBP, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x8845040", Offset = "0x8843640", VA = "0x188845040")]
	[AsyncStateMachine(typeof(NJBBFNPDHJM))]
	private Task CKFCDJIPJDP(JBAPOOINJKO ACJFHCNBBBO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL, bool HGEEBONPEEC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x8845FB0", Offset = "0x88445B0", VA = "0x188845FB0")]
	[AsyncStateMachine(typeof(IIAKNOOHLDM))]
	private Task JKPKOBBPOEP(JBAPOOINJKO ACJFHCNBBBO, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x88461C0", Offset = "0x88447C0", VA = "0x1888461C0")]
	private Task NBJAKDHANHN(JBAPOOINJKO ACJFHCNBBBO, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x8845000", Offset = "0x8843600", VA = "0x188845000")]
	private Task BIFGEONFGOF(JBAPOOINJKO ACJFHCNBBBO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x8844E80", Offset = "0x8843480", VA = "0x188844E80")]
	private Task APFIMNEMAOG(JBAPOOINJKO ACJFHCNBBBO, DLEADHPIGIL FGLGGNKFBOG, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x8845460", Offset = "0x8843A60", VA = "0x188845460")]
	private Task FAKPNDEKCKO(JBAPOOINJKO ACJFHCNBBBO, DLEADHPIGIL FGLGGNKFBOG, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x8846330", Offset = "0x8844930", VA = "0x188846330")]
	private static Task ODNOGPGCFPI(CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x8845020", Offset = "0x8843620", VA = "0x188845020")]
	private Task CEKOGHIGOKG(JBAPOOINJKO ACJFHCNBBBO, DLEADHPIGIL FGLGGNKFBOG, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x88457F0", Offset = "0x8843DF0", VA = "0x1888457F0")]
	private Task FNHIABKFMOC(JBAPOOINJKO ACJFHCNBBBO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x8845DE0", Offset = "0x88443E0", VA = "0x188845DE0")]
	private void IKMFHFJIJHI(JBNAFHMBIJM IPMGANOCOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x8845740", Offset = "0x8843D40", VA = "0x188845740")]
	public void FKCIFMJDMDC(long LICAODAKGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	private static void BFGPJGGPHOO(AHDDLFMPJGL FHNEJLIAKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x88459B0", Offset = "0x8843FB0", VA = "0x1888459B0")]
	[AsyncStateMachine(typeof(NEJLINAEAAL))]
	private Task HDGKPIEHLOF(JBAPOOINJKO BBKHIBDOFMG, PFPFHKOPDKJ JCGBEHNEILO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken BOMDCMIHJMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x8845480", Offset = "0x8843A80", VA = "0x188845480")]
	[AsyncStateMachine(typeof(EDGDOKNMPJA))]
	private Task FEDJMIILLAI(JBAPOOINJKO ACJFHCNBBBO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x88460A0", Offset = "0x88446A0", VA = "0x1888460A0")]
	private static OLLBGKKIMKC MIDGKCBBCIA(JBAPOOINJKO AOJKEENFNFP)
	{
		return default(OLLBGKKIMKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x8844EA0", Offset = "0x88434A0", VA = "0x188844EA0")]
	[AsyncStateMachine(typeof(EMECKNBDNJB))]
	private Task<OHFLHPGOJMC> BIBEPBAOIJA(JBAPOOINJKO ACJFHCNBBBO, DLEADHPIGIL FGLGGNKFBOG, PFPFHKOPDKJ AMHFLHGINAG, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	private void IDOHCENBDPD(OHFLHPGOJMC COEMJHNCHBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct HKHEMLBICAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	private DALKFPIOIFA GEJAMCMAAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	private JBAPOOINJKO ACJFHCNBBBO;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private FKOJBBBPHKG NPBKIMIDKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x885E3B0", Offset = "0x885C9B0", VA = "0x18885E3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x885E400", Offset = "0x885CA00", VA = "0x18885E400")]
	public static Task JNJJALJCEOA(DALKFPIOIFA GEJAMCMAAHF, JBAPOOINJKO ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x885E4E0", Offset = "0x885CAE0", VA = "0x18885E4E0")]
	private void JNJJALJCEOA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct KDJFGNANGPP
{
	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x8862920", Offset = "0x8860F20", VA = "0x188862920")]
	public static Task JNJJALJCEOA(CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct FGHMDOIALOB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct FHPMPNKBONO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public PFFMPBIDPGL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x885BF40", Offset = "0x885A540", VA = "0x18885BF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x885C470", Offset = "0x885AA70", VA = "0x18885C470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x885B5A0", Offset = "0x8859BA0", VA = "0x18885B5A0")]
	[AsyncStateMachine(typeof(FHPMPNKBONO))]
	public static Task JNJJALJCEOA(PFFMPBIDPGL MOICONIKBMO, JBAPOOINJKO ACJFHCNBBBO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct GOJFAFCDKKE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct OILHDOAHKIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public PFFMPBIDPGL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public DLEADHPIGIL timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private DALKFPIOIFA <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private FKOJBBBPHKG <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private OHFLHPGOJMC <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private AFBNCPDOCOC <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private List<(PersistenceView, BFMGGPKDIJO)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private BFMGGPKDIJO <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x88689E0", Offset = "0x8866FE0", VA = "0x1888689E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x88696C0", Offset = "0x8867CC0", VA = "0x1888696C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x885E260", Offset = "0x885C860", VA = "0x18885E260")]
	[AsyncStateMachine(typeof(OILHDOAHKIH))]
	public static Task JNJJALJCEOA(PFFMPBIDPGL MOICONIKBMO, JBAPOOINJKO ACJFHCNBBBO, DLEADHPIGIL FGLGGNKFBOG, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x885E060", Offset = "0x885C660", VA = "0x18885E060")]
	private static void JFKGENDEAJC(PersistenceView PHGOJDGOFOF, BFMGGPKDIJO OLLCMNMACHB, JBAPOOINJKO ACJFHCNBBBO, OHFLHPGOJMC OBLNDDMADKE, bool FKGJBJMFIHM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal struct IGNAMBNINIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct CEIECEHGEAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public DALKFPIOIFA roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private AFBNCPDOCOC <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x88570E0", Offset = "0x88556E0", VA = "0x1888570E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x8857700", Offset = "0x8855D00", VA = "0x188857700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x885EE90", Offset = "0x885D490", VA = "0x18885EE90")]
	[AsyncStateMachine(typeof(CEIECEHGEAM))]
	public static Task JNJJALJCEOA(DALKFPIOIFA GEJAMCMAAHF, JBAPOOINJKO ACJFHCNBBBO, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct MLFMGKMEGEH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct MMKFIKCHBIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public DALKFPIOIFA roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public PFFMPBIDPGL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x8865D20", Offset = "0x8864320", VA = "0x188865D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x8865F30", Offset = "0x8864530", VA = "0x188865F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class PBANPHAHKJE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000164")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005F0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F1")]
			public EHMNEFALKGP<string>.OJMJGFAOFAB timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005F2")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005F3")]
			public PBANPHAHKJE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005F4")]
			private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x886CFF0", Offset = "0x886B5F0", VA = "0x18886CFF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x886D380", Offset = "0x886B980", VA = "0x18886D380", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public PBANPHAHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x8869720", Offset = "0x8867D20", VA = "0x188869720")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task IDAGNLGNDFK(EHMNEFALKGP<string>.OJMJGFAOFAB timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct KHMIGKNIOIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public MLFMGKMEGEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private AFBNCPDOCOC <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private TaskAwaiter<MDPCDPBDELI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x8862FC0", Offset = "0x88615C0", VA = "0x188862FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x8863BD0", Offset = "0x88621D0", VA = "0x188863BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class MHKPIDFHHJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public BAHICIMNAGL version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public MHKPIDFHHJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x8865020", Offset = "0x8863620", VA = "0x188865020")]
		internal object OBIDCJMDOHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x8864F70", Offset = "0x8863570", VA = "0x188864F70")]
		internal object LFPKLIGMOHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private DALKFPIOIFA GEJAMCMAAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private JBAPOOINJKO ACJFHCNBBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private PFFMPBIDPGL MOICONIKBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private bool HGEEBONPEEC;

	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private static readonly ByteString NLCCGBEHEDB;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private FKOJBBBPHKG NPBKIMIDKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x88658E0", Offset = "0x8863EE0", VA = "0x1888658E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private NIBBLCAGIDJ IAEGCNMCKDC
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x8865BF0", Offset = "0x88641F0", VA = "0x188865BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x8865AA0", Offset = "0x88640A0", VA = "0x188865AA0")]
	[AsyncStateMachine(typeof(MMKFIKCHBIC))]
	public static Task JNJJALJCEOA(DALKFPIOIFA GEJAMCMAAHF, JBAPOOINJKO ACJFHCNBBBO, PFFMPBIDPGL MOICONIKBMO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL, bool HGEEBONPEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x8865970", Offset = "0x8863F70", VA = "0x188865970")]
	[AsyncStateMachine(typeof(KHMIGKNIOIJ))]
	private Task JNJJALJCEOA(EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x8865100", Offset = "0x8863700", VA = "0x188865100")]
	private void ALGGMCBEHGE([NotNull] AJMAHGBGLEH LICGHODJFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x8865930", Offset = "0x8863F30", VA = "0x188865930")]
	private bool HDGMAEDOIND(BAHICIMNAGL PFGEKBLLNEL, AJMAHGBGLEH LICGHODJFLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct JFMHAEKNPJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct ILNNDIMBFLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public AsyncTaskMethodBuilder<JBAPOOINJKO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public JFMHAEKNPJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public AGHKNMPOBEI.CHKBJJABKDO downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private TaskAwaiter<IReadOnlyCollection<IAAKCJFJKMO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private TaskAwaiter<(FANMKCKHALG<MEJLPLHGLFG, PELIOLHOEHA>, FANMKCKHALG<OOEFICMLGFH<AJMAHGBGLEH>, PELIOLHOEHA>, FANMKCKHALG<OOEFICMLGFH<DGDAAPKHMFH>, PELIOLHOEHA>, FANMKCKHALG<OOEFICMLGFH<IEnumerable<OIIHNAILALJ>>, PELIOLHOEHA>, FANMKCKHALG<OOEFICMLGFH<AONOBGDNKLF>, PELIOLHOEHA>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x885F240", Offset = "0x885D840", VA = "0x18885F240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x8860020", Offset = "0x885E620", VA = "0x188860020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct JHMIGPFEGFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public AsyncTaskMethodBuilder<FANMKCKHALG<MEJLPLHGLFG, PELIOLHOEHA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public JFMHAEKNPJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public IReadOnlyCollection<IAAKCJFJKMO> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public IReadOnlyCollection<IAAKCJFJKMO> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public AGHKNMPOBEI.CHKBJJABKDO downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private TaskAwaiter<FANMKCKHALG<MEJLPLHGLFG, PELIOLHOEHA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x8862250", Offset = "0x8860850", VA = "0x188862250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x88628B0", Offset = "0x8860EB0", VA = "0x1888628B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	private JFAPNEJCJCM<HNKIFFEICOH, DGDAAPKHMFH> EMFHONCONKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	private JFAPNEJCJCM<HNKIFFEICOH, AJMAHGBGLEH> KELDKMGPKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private JFAPNEJCJCM<BEBIDCLFPCH, IEnumerable<OIIHNAILALJ>> JNOMLDGBNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private JFAPNEJCJCM<long, AONOBGDNKLF> IHODOKGJFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	private IPACOGLKGDO JFNCGGIONED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private AHDDLFMPJGL FHNEJLIAKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private GPFDHCLPDCM NJAPGLBIHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private Guid? JJMDOACODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private IReadOnlyCollection<IAAKCJFJKMO> HLPNFPMJBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private Task<IReadOnlyCollection<IAAKCJFJKMO>> GMFEDJDNNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	private HNKIFFEICOH IDFCIPJEKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000610")]
	private HNKIFFEICOH NMGICMHGEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	private HNKIFFEICOH? IKLEPPBLIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private BEBIDCLFPCH HEBDPKFEKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	private EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC;

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x8861700", Offset = "0x885FD00", VA = "0x188861700")]
	public static Task<JBAPOOINJKO> FGNLFBJBBCI(DALKFPIOIFA GEJAMCMAAHF, [In] ANOBLFNCFNO ACJFHCNBBBO, AGHKNMPOBEI.CHKBJJABKDO KHONJAPCKBP, EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x8861DD0", Offset = "0x88603D0", VA = "0x188861DD0")]
	[AsyncStateMachine(typeof(ILNNDIMBFLI))]
	private Task<JBAPOOINJKO> JNJJALJCEOA(AGHKNMPOBEI.CHKBJJABKDO KHONJAPCKBP, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x8861BA0", Offset = "0x88601A0", VA = "0x188861BA0")]
	[AsyncStateMachine(typeof(JHMIGPFEGFM))]
	private Task<FANMKCKHALG<MEJLPLHGLFG, PELIOLHOEHA>> FNMHLHFCMMF(Guid? JJMDOACODNI, IReadOnlyCollection<IAAKCJFJKMO> HLPNFPMJBOA, IReadOnlyCollection<IAAKCJFJKMO> HLLHJGPMONJ, long? CDFGHIILPDC, long? EIMKPFCNHML, AGHKNMPOBEI.CHKBJJABKDO KHONJAPCKBP, EHMNEFALKGP<string>.OJMJGFAOFAB GHODFLJFPOE, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal struct CKDGEINMBDJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct HNJENGAFFJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public AsyncTaskMethodBuilder<ANOBLFNCFNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public CKDGEINMBDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private TaskAwaiter<ANOBLFNCFNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x885E9D0", Offset = "0x885CFD0", VA = "0x18885E9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x885EE20", Offset = "0x885D420", VA = "0x18885EE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct IMAAFCJPDKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public AsyncTaskMethodBuilder<ANOBLFNCFNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public CKDGEINMBDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private TaskAwaiter<ANOBLFNCFNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x8860090", Offset = "0x885E690", VA = "0x188860090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x8860510", Offset = "0x885EB10", VA = "0x188860510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class JGPDCIDDDGG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		private struct <<FetchRoomLoadDetails>g__getRoomSaveData|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000650")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000651")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000652")]
			public JGPDCIDDDGG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000653")]
			private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000654")]
			private TaskAwaiter<FNFJCDCKIHC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			private TaskAwaiter<OIFNFKHALGJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x886A410", Offset = "0x8868A10", VA = "0x18886A410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x886ADC0", Offset = "0x88693C0", VA = "0x18886ADC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public OGNGJGBMNNO roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public FKOJBBBPHKG callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public HNKIFFEICOH superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public HNKIFFEICOH subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public IReadOnlyList<IAAKCJFJKMO> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public IReadOnlyList<IAAKCJFJKMO> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public AHDDLFMPJGL roomDetails;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public JGPDCIDDDGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xF54700", Offset = "0xF52D00", VA = "0x180F54700")]
		internal bool JDPELMBJJHN(GPFDHCLPDCM sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x8861F80", Offset = "0x8860580", VA = "0x188861F80")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task LFMEGNONAAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x8862050", Offset = "0x8860650", VA = "0x188862050")]
		internal Task<BEBIDCLFPCH> PNJJBNDDKJG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct NBLMFMCELHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public AsyncTaskMethodBuilder<ANOBLFNCFNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public OGNGJGBMNNO roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public FKOJBBBPHKG callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public HNKIFFEICOH superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private JGPDCIDDDGG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private GPFDHCLPDCM <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private Task<BEBIDCLFPCH> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private TaskAwaiter<AHDDLFMPJGL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private TaskAwaiter<BEBIDCLFPCH> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x8865F90", Offset = "0x8864590", VA = "0x188865F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x8866F40", Offset = "0x8865540", VA = "0x188866F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	private FKOJBBBPHKG ACIHABPADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	private GAIHMFBPIKO ACEKANILHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	private OGNGJGBMNNO HINGNPFBBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	private EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	private long CDFGHIILPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private long BKDNOJBOAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private long IOFOOKADLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private string JLBGEPDOPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	private HNKIFFEICOH CPJAFBFJEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	private Guid ELCHNDNPHCA;

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x8857760", Offset = "0x8855D60", VA = "0x188857760")]
	public static Task<ANOBLFNCFNO> FGNLFBJBBCI(DALKFPIOIFA GEJAMCMAAHF, JBNAFHMBIJM IPMGANOCOKF, EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x88579B0", Offset = "0x8855FB0", VA = "0x1888579B0")]
	[AsyncStateMachine(typeof(HNJENGAFFJJ))]
	private Task<ANOBLFNCFNO> JNJJALJCEOA(CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x8857B30", Offset = "0x8856130", VA = "0x188857B30")]
	[AsyncStateMachine(typeof(IMAAFCJPDKC))]
	private Task<ANOBLFNCFNO> PIJDNMFKIHF(EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x8857CA0", Offset = "0x88562A0", VA = "0x188857CA0")]
	[AsyncStateMachine(typeof(NBLMFMCELHG))]
	private static Task<ANOBLFNCFNO> PIJDNMFKIHF(FKOJBBBPHKG ACIHABPADPI, OGNGJGBMNNO HINGNPFBBIL, long CDFGHIILPDC, long BKDNOJBOAHD, long IOFOOKADLPP, string JLBGEPDOPBL, HNKIFFEICOH CPJAFBFJEGC, Guid ELCHNDNPHCA, CancellationToken KMHHNOGHBLL, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x8857B00", Offset = "0x8856100", VA = "0x188857B00")]
	private void NOAPMKJMAGE(AHDDLFMPJGL FHNEJLIAKMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
internal struct FIJIFDJDBOF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct PDLAOHOOJFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public FIJIFDJDBOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x8869840", Offset = "0x8867E40", VA = "0x188869840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8869DD0", Offset = "0x88683D0", VA = "0x188869DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000669")]
	private FKOJBBBPHKG ACIHABPADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066A")]
	private JBAPOOINJKO ACJFHCNBBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private float IBIJLLGFFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private float KMIGEPPNLOM;

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x885C970", Offset = "0x885AF70", VA = "0x18885C970")]
	public static Task OPEPCFEDANA(DALKFPIOIFA GEJAMCMAAHF, JBAPOOINJKO ACJFHCNBBBO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x885C850", Offset = "0x885AE50", VA = "0x18885C850")]
	[AsyncStateMachine(typeof(PDLAOHOOJFC))]
	public Task JNJJALJCEOA(CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x885C590", Offset = "0x885AB90", VA = "0x18885C590")]
	private static void CGEOKJJKOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x885C6F0", Offset = "0x885ACF0", VA = "0x18885C6F0")]
	private void IMHODAMJFCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x885C4D0", Offset = "0x885AAD0", VA = "0x18885C4D0")]
	private static float CEBLPADCGHN(FKOJBBBPHKG ACIHABPADPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x885C6D0", Offset = "0x885ACD0", VA = "0x18885C6D0")]
	private static float DJGFFNCCKHK()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal struct CMLCPIDCMLA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct FGLBPKFCNHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public PFFMPBIDPGL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private EMNCKDOLLHH <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private DALKFPIOIFA <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private GKGGMBFGDPH.EOLOEHNNEOD <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private TaskAwaiter<MDPCDPBDELI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x885B6E0", Offset = "0x8859CE0", VA = "0x18885B6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x885BEE0", Offset = "0x885A4E0", VA = "0x18885BEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct LHOFNMAHCGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x88646C0", Offset = "0x8862CC0", VA = "0x1888646C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x88649F0", Offset = "0x8862FF0", VA = "0x1888649F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x8857EE0", Offset = "0x88564E0", VA = "0x188857EE0")]
	[AsyncStateMachine(typeof(FGLBPKFCNHA))]
	public static Task JNJJALJCEOA(PFFMPBIDPGL MOICONIKBMO, JBAPOOINJKO ACJFHCNBBBO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x8857E70", Offset = "0x8856470", VA = "0x188857E70")]
	private static Task<MDPCDPBDELI> BPCNBKIEHCG(PFFMPBIDPGL MOICONIKBMO, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x8858020", Offset = "0x8856620", VA = "0x188858020")]
	[AsyncStateMachine(typeof(LHOFNMAHCGP))]
	private static Task MMPLCOGNNPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
internal struct ECKPEPPLIKH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct LHBPCJHKDGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public ECKPEPPLIKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x8863ED0", Offset = "0x88624D0", VA = "0x188863ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x8864660", Offset = "0x8862C60", VA = "0x188864660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class GMNGBLBEDMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public GMNGBLBEDMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x885DFE0", Offset = "0x885C5E0", VA = "0x18885DFE0")]
		internal object EDIPEAGCIFB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct DKECPLFIFBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public ECKPEPPLIKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x8858200", Offset = "0x8856800", VA = "0x188858200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x8858680", Offset = "0x8856C80", VA = "0x188858680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private bool FMKMFFNJPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000689")]
	private EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private DALKFPIOIFA GEJAMCMAAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	private CancellationToken KMHHNOGHBLL;

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x8858D50", Offset = "0x8857350", VA = "0x188858D50")]
	public static Task HDGDFMJHPJC(DALKFPIOIFA GEJAMCMAAHF, bool FMKMFFNJPLE, EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, CancellationToken JLIPPIADDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x8858DC0", Offset = "0x88573C0", VA = "0x188858DC0")]
	[AsyncStateMachine(typeof(LHBPCJHKDGK))]
	private Task JNJJALJCEOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x8858C20", Offset = "0x8857220", VA = "0x188858C20")]
	[AsyncStateMachine(typeof(DKECPLFIFBM))]
	private Task CHEILPPBMOM(bool JCEEENKJLIL, string NFPDPBJAKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450")]
	private bool FIGAEJJKEJI(bool FMKMFFNJPLE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
internal struct KPINBCPPPOI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private struct DMDBACAKEDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public KPINBCPPPOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x88586E0", Offset = "0x8856CE0", VA = "0x1888586E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x8858BB0", Offset = "0x88571B0", VA = "0x188858BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class PJHFDGCBOGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public PJHFDGCBOGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x8869E30", Offset = "0x8868430", VA = "0x188869E30")]
		internal object EDIPEAGCIFB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct NGCHKIINFMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public KPINBCPPPOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x8867E60", Offset = "0x8866460", VA = "0x188867E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x88682F0", Offset = "0x88668F0", VA = "0x1888682F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private JEGCDDBLFIG PHOMBNDDNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private DALKFPIOIFA GEJAMCMAAHF;

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x8863E80", Offset = "0x8862480", VA = "0x188863E80")]
	public static Task<Scene> MIHKCAOIIHP(DALKFPIOIFA GEJAMCMAAHF, JEGCDDBLFIG NPGHCDMLEBE, EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x8863D70", Offset = "0x8862370", VA = "0x188863D70")]
	[AsyncStateMachine(typeof(DMDBACAKEDK))]
	private Task<Scene> JNJJALJCEOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x8863C30", Offset = "0x8862230", VA = "0x188863C30")]
	[AsyncStateMachine(typeof(NGCHKIINFMI))]
	private Task<Scene> CHEILPPBMOM(string NFPDPBJAKNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal struct CHPAFPMKFIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct AIHMFMNDDDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public AsyncTaskMethodBuilder<OHFLHPGOJMC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public CHPAFPMKFIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public OHFLHPGOJMC nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public JBAPOOINJKO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private TaskAwaiter<OHFLHPGOJMC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x886D8C0", Offset = "0x886BEC0", VA = "0x18886D8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x886E390", Offset = "0x886C990", VA = "0x18886E390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct DIOPLCMJFHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public AsyncTaskMethodBuilder<OHFLHPGOJMC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public CHPAFPMKFIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public OHFLHPGOJMC state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private TaskAwaiter<MDPCDPBDELI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x8872A60", Offset = "0x8871060", VA = "0x188872A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x8872D40", Offset = "0x8871340", VA = "0x188872D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private readonly PFFMPBIDPGL MOICONIKBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	private readonly GAIHMFBPIKO ACEKANILHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	private readonly NFBEFIFEAJP CIOPFLOEEOG;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private EMNCKDOLLHH INLICGFLEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x6C54BB0", Offset = "0x6C531B0", VA = "0x186C54BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x8871720", Offset = "0x886FD20", VA = "0x188871720")]
	public CHPAFPMKFIA(PFFMPBIDPGL MOICONIKBMO, GAIHMFBPIKO ACEKANILHJD, NFBEFIFEAJP CIOPFLOEEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x8871550", Offset = "0x886FB50", VA = "0x188871550")]
	[AsyncStateMachine(typeof(AIHMFMNDDDA))]
	public Task<OHFLHPGOJMC> GFCKMDGFDAA(OHFLHPGOJMC KHMBHJLEPOI, JBAPOOINJKO AOJKEENFNFP, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL, bool JFEOLEBOMCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x88713F0", Offset = "0x886F9F0", VA = "0x1888713F0")]
	[AsyncStateMachine(typeof(DIOPLCMJFHE))]
	private Task<OHFLHPGOJMC> DBNNBAOOGHM(EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, OHFLHPGOJMC DCPJOMEJHIO, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x88716D0", Offset = "0x886FCD0", VA = "0x1888716D0")]
	private bool HFGMJBKKODO(OHFLHPGOJMC ADLCLJCPJFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x8871700", Offset = "0x886FD00", VA = "0x188871700")]
	private void OAAFJAHOMDO(string KDAOOGLIINF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal struct BHLAMJHLHAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct OPAJECHJBBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public EMNCKDOLLHH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public DLEADHPIGIL timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private AFBNCPDOCOC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private List<(PersistenceView, BFMGGPKDIJO)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private (PersistenceView, BFMGGPKDIJO) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x8880780", Offset = "0x887ED80", VA = "0x188880780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x8880E50", Offset = "0x887F450", VA = "0x188880E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x886EA30", Offset = "0x886D030", VA = "0x18886EA30")]
	[AsyncStateMachine(typeof(OPAJECHJBBK))]
	public static Task JNJJALJCEOA(EMNCKDOLLHH GFCEGHONGDJ, JBAPOOINJKO ACJFHCNBBBO, DLEADHPIGIL FGLGGNKFBOG, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal struct IPENKDKLAEI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private struct GEHPMDIDJGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public EMNCKDOLLHH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public DLEADHPIGIL timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private BAHICIMNAGL <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private AFBNCPDOCOC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private List<(PersistenceView, BFMGGPKDIJO)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private BFMGGPKDIJO <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x88769B0", Offset = "0x8874FB0", VA = "0x1888769B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x8877290", Offset = "0x8875890", VA = "0x188877290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x8878D80", Offset = "0x8877380", VA = "0x188878D80")]
	[AsyncStateMachine(typeof(GEHPMDIDJGE))]
	public static Task JNJJALJCEOA(EMNCKDOLLHH GFCEGHONGDJ, JBAPOOINJKO ACJFHCNBBBO, DLEADHPIGIL FGLGGNKFBOG, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public struct FLMHDEHJFFO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct HMLDHIODENP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public AsyncTaskMethodBuilder<FANMKCKHALG<MEJLPLHGLFG, PELIOLHOEHA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public FLMHDEHJFFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public AGHKNMPOBEI.CHKBJJABKDO preloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private TaskAwaiter<FANMKCKHALG<MEJLPLHGLFG, PELIOLHOEHA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x88780D0", Offset = "0x88766D0", VA = "0x1888780D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x8878750", Offset = "0x8876D50", VA = "0x188878750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private long ICDBKFJJLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private long JHMOJKEOHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private Guid? FJGPGKFDJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private IReadOnlyCollection<IAAKCJFJKMO> GMDOEIMIJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private IReadOnlyCollection<IAAKCJFJKMO> BMNOEDAPMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private IPACOGLKGDO KBPNHNKJHOC;

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x8876660", Offset = "0x8874C60", VA = "0x188876660")]
	public static Task<FANMKCKHALG<MEJLPLHGLFG, PELIOLHOEHA>> FGNLFBJBBCI(long CDFGHIILPDC, long BKDNOJBOAHD, OIFNFKHALGJ BLBKDPMMEMP, AGHKNMPOBEI.CHKBJJABKDO PCMIDGIANGB, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x88767C0", Offset = "0x8874DC0", VA = "0x1888767C0")]
	[AsyncStateMachine(typeof(HMLDHIODENP))]
	private Task<FANMKCKHALG<MEJLPLHGLFG, PELIOLHOEHA>> JNJJALJCEOA(AGHKNMPOBEI.CHKBJJABKDO PCMIDGIANGB, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal struct GKGGMBFGDPH
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	public struct EOLOEHNNEOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public List<ODCMNIBKEMF> GKHMANNDJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public List<BFMGGPKDIJO> FBJLEHGDPLI;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xB8E8F0", Offset = "0xB8CEF0", VA = "0x180B8E8F0")]
		public EOLOEHNNEOD(List<ODCMNIBKEMF> GKHMANNDJFP, List<BFMGGPKDIJO> FBJLEHGDPLI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class NAPJAKEAMAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public IEnumerable<ODCMNIBKEMF> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public NAPJAKEAMAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x887CD50", Offset = "0x887B350", VA = "0x18887CD50")]
		internal object CFLDAMGHKIE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006E7")]
	private DALKFPIOIFA GEJAMCMAAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006E8")]
	private JBAPOOINJKO ACJFHCNBBBO;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private FKOJBBBPHKG NPBKIMIDKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x8877D50", Offset = "0x8876350", VA = "0x188877D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x8877DA0", Offset = "0x88763A0", VA = "0x188877DA0")]
	public static EOLOEHNNEOD JNJJALJCEOA(DALKFPIOIFA GEJAMCMAAHF, JBAPOOINJKO ACJFHCNBBBO)
	{
		return default(EOLOEHNNEOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x8877E00", Offset = "0x8876400", VA = "0x188877E00")]
	private EOLOEHNNEOD JNJJALJCEOA()
	{
		return default(EOLOEHNNEOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x88777A0", Offset = "0x8875DA0", VA = "0x1888777A0")]
	private EOLOEHNNEOD GDPBPDIOLNC(AJMAHGBGLEH LICGHODJFLH, BAHICIMNAGL JIAEOGJKHJM)
	{
		return default(EOLOEHNNEOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x88775D0", Offset = "0x8875BD0", VA = "0x1888775D0")]
	private bool CKCMMLPFKPB(IEnumerable<ODCMNIBKEMF> GKHMANNDJFP)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal struct LGDINIPJOKE
{
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class EHCCCOOAGNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public GKGGMBFGDPH.EOLOEHNNEOD instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public EHCCCOOAGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x8874660", Offset = "0x8872C60", VA = "0x188874660")]
		internal object IDAGNLGNDFK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class BILHLEBPFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BILHLEBPFJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x886EB70", Offset = "0x886D170", VA = "0x18886EB70")]
		internal object NFANINKJMBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x887A000", Offset = "0x8878600", VA = "0x18887A000")]
	public static void JNJJALJCEOA(EMNCKDOLLHH GFCEGHONGDJ, JBAPOOINJKO ACJFHCNBBBO, GKGGMBFGDPH.EOLOEHNNEOD KOCNMLMNLBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
internal class NFBEFIFEAJP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct OLCHMMNAIHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public NFBEFIFEAJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public OHFLHPGOJMC operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public JBAPOOINJKO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x887FFB0", Offset = "0x887E5B0", VA = "0x18887FFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x8880720", Offset = "0x887ED20", VA = "0x188880720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private sealed class JCNBHOEPENB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006FE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006FF")]
			public JCNBHOEPENB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000700")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000701")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x8882C80", Offset = "0x8881280", VA = "0x188882C80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x8882F40", Offset = "0x8881540", VA = "0x188882F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public NFBEFIFEAJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public JCNBHOEPENB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x8878EC0", Offset = "0x88774C0", VA = "0x188878EC0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task BFJGACAKBOB(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private struct PPDEKDMEHIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public NFBEFIFEAJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private JCNBHOEPENB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x8882220", Offset = "0x8880820", VA = "0x188882220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x8882750", Offset = "0x8880D50", VA = "0x188882750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct NLBPIACMCME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public NFBEFIFEAJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private Dictionary<Guid, List<GOOCAHGGBEP>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x887E3B0", Offset = "0x887C9B0", VA = "0x18887E3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x887E9C0", Offset = "0x887CFC0", VA = "0x18887E9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct EAFIEGBHJCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public NFBEFIFEAJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private Dictionary<Guid, List<GOOCAHGGBEP>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x8873F60", Offset = "0x8872560", VA = "0x188873F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x8874600", Offset = "0x8872C00", VA = "0x188874600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class GGJIDLGBKEO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000721")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000722")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000723")]
			public GOOCAHGGBEP handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000724")]
			public GGJIDLGBKEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000725")]
			private AFBNCPDOCOC <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000726")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x88827B0", Offset = "0x8880DB0", VA = "0x1888827B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x8882C20", Offset = "0x8881220", VA = "0x188882C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public AAMCBFBFJFI runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public List<GOOCAHGGBEP> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public GGJIDLGBKEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x88774E0", Offset = "0x8875AE0", VA = "0x1888774E0")]
		internal object LLGFCDBJMJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x88772F0", Offset = "0x88758F0", VA = "0x1888772F0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task FPGFNMIMAOI(GOOCAHGGBEP handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x88773F0", Offset = "0x88759F0", VA = "0x1888773F0")]
		internal object HLDMKOJINCL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private struct KKLOMLLHIFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public AAMCBFBFJFI runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public List<GOOCAHGGBEP> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private GGJIDLGBKEO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x8879AD0", Offset = "0x88780D0", VA = "0x188879AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x8879FA0", Offset = "0x88785A0", VA = "0x188879FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private struct BOOHGBMAMNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public NFBEFIFEAJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x886F480", Offset = "0x886DA80", VA = "0x18886F480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x886FA40", Offset = "0x886E040", VA = "0x18886FA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class FENPEHPCPEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public FENPEHPCPEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x8875990", Offset = "0x8873F90", VA = "0x188875990")]
		internal object FJJPIEPLGJM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct CGFOGBDEFCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public NFBEFIFEAJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		public JBAPOOINJKO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x8870ED0", Offset = "0x886F4D0", VA = "0x188870ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x8871390", Offset = "0x886F990", VA = "0x188871390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class KEAGFCELBGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public KEAGFCELBGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x88795B0", Offset = "0x8877BB0", VA = "0x1888795B0")]
		internal object GHBDINDIBND()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private struct NHPHAFLNLID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public NFBEFIFEAJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		private AFBNCPDOCOC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private TaskAwaiter<MDPCDPBDELI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x887DD10", Offset = "0x887C310", VA = "0x18887DD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x887E350", Offset = "0x887C950", VA = "0x18887E350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private sealed class MNEHBDDHDEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public MNEHBDDHDEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x887CCE0", Offset = "0x887B2E0", VA = "0x18887CCE0")]
		internal object KBJGFJGCFNP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006EF")]
	private readonly PFFMPBIDPGL MOICONIKBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F0")]
	private CAEJMEKKHNA CIOPFLOEEOG;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private EMNCKDOLLHH INLICGFLEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x11A28C0", Offset = "0x11A0EC0", VA = "0x1811A28C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	public NFBEFIFEAJP(PFFMPBIDPGL MOICONIKBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x887D390", Offset = "0x887B990", VA = "0x18887D390")]
	[AsyncStateMachine(typeof(OLCHMMNAIHH))]
	public Task JNJJALJCEOA(OHFLHPGOJMC OBLNDDMADKE, JBAPOOINJKO AOJKEENFNFP, EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x887D9F0", Offset = "0x887BFF0", VA = "0x18887D9F0")]
	[AsyncStateMachine(typeof(PPDEKDMEHIA))]
	private Task MHNFOMEIEFC(JBAPOOINJKO ACJFHCNBBBO, EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x887D8B0", Offset = "0x887BEB0", VA = "0x18887D8B0")]
	[AsyncStateMachine(typeof(NLBPIACMCME))]
	private Task LGJFKDFCGJH(JBAPOOINJKO ACJFHCNBBBO, EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x887D600", Offset = "0x887BC00", VA = "0x18887D600")]
	[AsyncStateMachine(typeof(EAFIEGBHJCP))]
	private Task KPKOJNHLPFM(JBAPOOINJKO ACJFHCNBBBO, EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x887CDD0", Offset = "0x887B3D0", VA = "0x18887CDD0")]
	[AsyncStateMachine(typeof(KKLOMLLHIFI))]
	private Task AGFHJDBFIED(Guid CFLEFNJNLMB, List<GOOCAHGGBEP> AJAKGINJCOH, AAMCBFBFJFI FBHIBOALAJE, JBAPOOINJKO ACJFHCNBBBO, CancellationToken DKFMAIJGPFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x887CF20", Offset = "0x887B520", VA = "0x18887CF20")]
	[AsyncStateMachine(typeof(BOOHGBMAMNG))]
	private Task BIKMOIKOLCF(JBAPOOINJKO ACJFHCNBBBO, EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x887D060", Offset = "0x887B660", VA = "0x18887D060")]
	[AsyncStateMachine(typeof(CGFOGBDEFCL))]
	private Task CPNHHJEDFIN(Guid FEICDJHCCPN, JBAPOOINJKO ACJFHCNBBBO, EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x887D250", Offset = "0x887B850", VA = "0x18887D250")]
	[AsyncStateMachine(typeof(NHPHAFLNLID))]
	private Task IJHKBEELNJP(Guid FEICDJHCCPN, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x887D4E0", Offset = "0x887BAE0", VA = "0x18887D4E0")]
	private void KMCJNHOMFAF(Guid FEICDJHCCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x887D1A0", Offset = "0x887B7A0", VA = "0x18887D1A0")]
	private void DHBFPFPOKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x887D740", Offset = "0x887BD40", VA = "0x18887D740")]
	public Guid LBENMADCJED(OHFLHPGOJMC BJAHCNGKGOH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x887DB30", Offset = "0x887C130", VA = "0x18887DB30")]
	[CompilerGenerated]
	private object PAOAHKCHJGB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
internal struct IGIGIEMGHEI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private struct DONIJMNFPEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public IGIGIEMGHEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		private IEnumerator<BOAMAKLLGJN> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x8873870", Offset = "0x8871E70", VA = "0x188873870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x8873F00", Offset = "0x8872500", VA = "0x188873F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400074F")]
	private FKOJBBBPHKG ACIHABPADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000750")]
	private EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000751")]
	private CancellationToken KMHHNOGHBLL;

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x88787C0", Offset = "0x8876DC0", VA = "0x1888787C0")]
	public static Task DEIJEPKPFIK(FKOJBBBPHKG ACIHABPADPI, EHMNEFALKGP<string>.OJMJGFAOFAB GPIJGKLDGAC, CancellationToken JLIPPIADDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x8878830", Offset = "0x8876E30", VA = "0x188878830")]
	[AsyncStateMachine(typeof(DONIJMNFPEH))]
	private Task JNJJALJCEOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public readonly struct LOOEEGLMAPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000758")]
	public readonly bool BMENNJOHCDN;

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x2BCE300", Offset = "0x2BCC900", VA = "0x182BCE300")]
	public LOOEEGLMAPD(bool JPHPILMAADI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
public readonly struct IOGPAGLBJEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000759")]
	public readonly AJMAHGBGLEH? PLHFMGAGOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400075A")]
	public readonly KFJNLJMOJAL DGHEEEMHEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400075B")]
	public readonly Guid? MLKNKNCKMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400075C")]
	public readonly IReadOnlyList<Guid> GEFLJNHMFKC;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public IReadOnlyCollection<string> OHMDHKOHLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x8878C40", Offset = "0x8877240", VA = "0x188878C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public IReadOnlyDictionary<long, int> KHEIBNGOIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x8878C60", Offset = "0x8877260", VA = "0x188878C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x8878C80", Offset = "0x8877280", VA = "0x188878C80")]
	public IOGPAGLBJEO(AJMAHGBGLEH? MODBIBDJKOA, KFJNLJMOJAL OAKGOIIIMOE, Guid? JJMDOACODNI, [Optional] IReadOnlyList<Guid>? HCMHMFDHPKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal class MCDHDLJKKKH : GLCLDFDBPJP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[CompilerGenerated]
	private struct DCEOHPEHIAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public AsyncTaskMethodBuilder<IOGPAGLBJEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public MCDHDLJKKKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public KOMDHNBMFBB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public HHKCKLCLDME roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		private AFBNCPDOCOC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x8871780", Offset = "0x886FD80", VA = "0x188871780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x8871E20", Offset = "0x8870420", VA = "0x188871E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private sealed class HCBCPBOGGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public HCBCPBOGGIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x8878060", Offset = "0x8876660", VA = "0x188878060")]
		internal object HHOOOAEAFMN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private struct MEFHJJHCMPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public MCDHDLJKKKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public KOMDHNBMFBB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		private HCBCPBOGGIJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		private AFBNCPDOCOC <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		private POIJGDNEEOK<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x887C070", Offset = "0x887A670", VA = "0x18887C070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x887CC30", Offset = "0x887B230", VA = "0x18887CC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400075D")]
	private readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x400075E")]
	private static readonly TimeSpan EAOFEIKOHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400075F")]
	private readonly DBEKAAMCOGK MBAKGIDIMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000760")]
	private readonly IIIONIFKNEA FMKCFNGFPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000761")]
	private readonly CELFBJMCOIK EAHLEEGLIEG;

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x887BCF0", Offset = "0x887A2F0", VA = "0x18887BCF0")]
	public MCDHDLJKKKH(PFFMPBIDPGL MOICONIKBMO, DBEKAAMCOGK MBAKGIDIMAD, IIIONIFKNEA DKLLCNBLPFA, CELFBJMCOIK EAHLEEGLIEG, LHMKAIAPMBI NDJJBNFFFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x887BB30", Offset = "0x887A130", VA = "0x18887BB30")]
	[AsyncStateMachine(typeof(DCEOHPEHIAL))]
	public Task<IOGPAGLBJEO> LGGJGPOGIBH(long BKDNOJBOAHD, HHKCKLCLDME KNHGOKAEHEN, KOMDHNBMFBB JJNJGNDPHAE, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x887B5A0", Offset = "0x8879BA0", VA = "0x18887B5A0")]
	private static bool JEMEMACKLMO(PersistenceView PHGOJDGOFOF, [Out] PJCHABHGKBB IOAFDIOLNJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x887B050", Offset = "0x8879650", VA = "0x18887B050")]
	[AsyncStateMachine(typeof(MEFHJJHCMPD))]
	private Task DEBMGJGHDFI(KOMDHNBMFBB JJNJGNDPHAE, PersistenceView[] ACDHMCOHAGL, StringBuilder HHFGGKBAABO, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x887AA40", Offset = "0x8879040", VA = "0x18887AA40")]
	private IOGPAGLBJEO DCPEAHKMLNI(long BKDNOJBOAHD, HHKCKLCLDME KNHGOKAEHEN, KOMDHNBMFBB JJNJGNDPHAE, IEnumerable<PersistenceView> ACDHMCOHAGL, StringBuilder HHFGGKBAABO)
	{
		return default(IOGPAGLBJEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x887B190", Offset = "0x8879790", VA = "0x18887B190")]
	private AJMAHGBGLEH FKPHLIDBLFI(long BKDNOJBOAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x887B350", Offset = "0x8879950", VA = "0x18887B350")]
	private void GKPAKEDPOEH(AJMAHGBGLEH BGEEFICGHMC, StringBuilder HHFGGKBAABO, IEnumerable<PersistenceView> ACDHMCOHAGL, [In] LMOOJIGPACL MPBJHANHEBC, LKGBJCCKCII PABNCJJENCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x887B690", Offset = "0x8879C90", VA = "0x18887B690")]
	private void KELJGKCDEMO(AJMAHGBGLEH BGEEFICGHMC, StringBuilder HHFGGKBAABO, PersistenceView PHGOJDGOFOF, LKGBJCCKCII PABNCJJENCE, [In] LMOOJIGPACL MPBJHANHEBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
internal class FEKLHCJEDBF : GLCLDFDBPJP
{
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private sealed class MEHKEPGBAOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public OHCCJONBAFK.GGHFKFMIGOO roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public MEHKEPGBAOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x887CC90", Offset = "0x887B290", VA = "0x18887CC90")]
		internal object FGKIGPBBAJK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private struct PIKDLAKLBOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public AsyncTaskMethodBuilder<(OHCCJONBAFK.GGHFKFMIGOO roomDataUpload, OHCCJONBAFK.GGHFKFMIGOO subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public IOGPAGLBJEO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public FKOJBBBPHKG callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		private MEHKEPGBAOL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		private TaskAwaiter<OHCCJONBAFK.GGHFKFMIGOO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x88810D0", Offset = "0x887F6D0", VA = "0x1888810D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x8881950", Offset = "0x887FF50", VA = "0x188881950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct MCNHJEOGBPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		public AsyncTaskMethodBuilder<NGFAKGBILNI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public FEKLHCJEDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public OBKGFFDIEBB roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public IOGPAGLBJEO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		private TaskAwaiter<NGFAKGBILNI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x887BD60", Offset = "0x887A360", VA = "0x18887BD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x887C000", Offset = "0x887A600", VA = "0x18887C000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private struct CDDNECKBPHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public AsyncTaskMethodBuilder<NGFAKGBILNI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public FKOJBBBPHKG callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public IOGPAGLBJEO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public CPGFIEADEHF ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public OBKGFFDIEBB roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		private TaskAwaiter<(OHCCJONBAFK.GGHFKFMIGOO roomDataUpload, OHCCJONBAFK.GGHFKFMIGOO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		private TaskAwaiter<NGFAKGBILNI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x886FFA0", Offset = "0x886E5A0", VA = "0x18886FFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x8870600", Offset = "0x886EC00", VA = "0x188870600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private struct CDGAHCCGPCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		public AsyncTaskMethodBuilder<FNFJCDCKIHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public FEKLHCJEDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		public IOGPAGLBJEO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		private TaskAwaiter<(OHCCJONBAFK.GGHFKFMIGOO roomDataUpload, OHCCJONBAFK.GGHFKFMIGOO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		private TaskAwaiter<FNFJCDCKIHC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x8870670", Offset = "0x886EC70", VA = "0x188870670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x8870B30", Offset = "0x886F130", VA = "0x188870B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class OJKLPBJJHPG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AE")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			public AsyncTaskMethodBuilder<MDPCDPBDELI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			public OJKLPBJJHPG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			private MDPCDPBDELI <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			private TaskAwaiter<FNFJCDCKIHC> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			private TaskAwaiter<NGFAKGBILNI> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			private TaskAwaiter<MDPCDPBDELI> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006BD")]
			[Cpp2IlInjected.Address(RVA = "0x8882FA0", Offset = "0x88815A0", VA = "0x188882FA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BE")]
			[Cpp2IlInjected.Address(RVA = "0x88841B0", Offset = "0x88827B0", VA = "0x1888841B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		public FEKLHCJEDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		public IOGPAGLBJEO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public OBKGFFDIEBB roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		public LOOEEGLMAPD roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public OJKLPBJJHPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x887FE80", Offset = "0x887E480", VA = "0x18887FE80")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<MDPCDPBDELI> JBLECFDGGKO(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[CompilerGenerated]
	private struct PMENAFJPLDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007B8")]
		public AsyncTaskMethodBuilder<MDPCDPBDELI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public FEKLHCJEDBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		public IOGPAGLBJEO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public OBKGFFDIEBB roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public LOOEEGLMAPD roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		private TaskAwaiter<MDPCDPBDELI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x88819C0", Offset = "0x887FFC0", VA = "0x1888819C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x8881CF0", Offset = "0x88802F0", VA = "0x188881CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400077B")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x400077C")]
	private static readonly LHMKAIAPMBI APBBCOJENIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400077D")]
	private readonly JAMLGNMIFIP NKKBJCNHIPM;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private DALKFPIOIFA LJEBHODLNOD
	{
		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x8844D10", Offset = "0x8843310", VA = "0x188844D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x8875900", Offset = "0x8873F00", VA = "0x188875900")]
	public FEKLHCJEDBF(PFFMPBIDPGL MOICONIKBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x8874F10", Offset = "0x8873510", VA = "0x188874F10")]
	[AsyncStateMachine(typeof(PIKDLAKLBOE))]
	private static Task<(OHCCJONBAFK.GGHFKFMIGOO, OHCCJONBAFK.GGHFKFMIGOO)> JEFNHEFBIGF(FKOJBBBPHKG ACIHABPADPI, IOGPAGLBJEO OOJHDNHPGCB, long CDFGHIILPDC, long EIMKPFCNHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x8875060", Offset = "0x8873660", VA = "0x188875060")]
	[AsyncStateMachine(typeof(MCNHJEOGBPH))]
	public Task<NGFAKGBILNI> KDEOLEDAHHC(int CPHKAGOKACI, [CanBeNull] OBKGFFDIEBB KNJBGLOGECM, IOGPAGLBJEO OOJHDNHPGCB, long CDFGHIILPDC, long EIMKPFCNHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x8875360", Offset = "0x8873960", VA = "0x188875360")]
	public static Task<NGFAKGBILNI> KDEOLEDAHHC(FKOJBBBPHKG ACIHABPADPI, int CPHKAGOKACI, [CanBeNull] OBKGFFDIEBB KNJBGLOGECM, IOGPAGLBJEO OOJHDNHPGCB, long CDFGHIILPDC, long EIMKPFCNHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x88751D0", Offset = "0x88737D0", VA = "0x1888751D0")]
	[AsyncStateMachine(typeof(CDDNECKBPHG))]
	public static Task<NGFAKGBILNI> KDEOLEDAHHC(FKOJBBBPHKG ACIHABPADPI, int CPHKAGOKACI, [CanBeNull] OBKGFFDIEBB KNJBGLOGECM, IOGPAGLBJEO OOJHDNHPGCB, long CDFGHIILPDC, long EIMKPFCNHML, CPGFIEADEHF KBMLCAABEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x8874D90", Offset = "0x8873390", VA = "0x188874D90")]
	[AsyncStateMachine(typeof(CDGAHCCGPCM))]
	private Task<FNFJCDCKIHC> BHGOCOPKCEC(string JLBGEPDOPBL, int CPHKAGOKACI, IOGPAGLBJEO OOJHDNHPGCB, long CDFGHIILPDC, long EIMKPFCNHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x88756B0", Offset = "0x8873CB0", VA = "0x1888756B0")]
	[AsyncStateMachine(typeof(PMENAFJPLDG))]
	public Task<MDPCDPBDELI> KJPONEBJLBN(int CPHKAGOKACI, OBKGFFDIEBB? KNJBGLOGECM, IOGPAGLBJEO OOJHDNHPGCB, long CDFGHIILPDC, long EIMKPFCNHML, LOOEEGLMAPD MFJMFLEELHD, EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public abstract class NNEGLNAAJPM<T> where T : NNEGLNAAJPM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C3")]
	internal readonly DALKFPIOIFA CIPFJHOBOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C4")]
	private int? CGDBPDKMKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C5")]
	protected readonly Guid LKALCKLEAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C6")]
	protected readonly KOJHHCPHIHG GACHHCDOCLL;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	protected T DCHJEEBMGAD
	{
		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x56A0800", Offset = "0x569EE00", VA = "0x1856A0800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x56A0B50", Offset = "0x569F150", VA = "0x1856A0B50")]
	internal NNEGLNAAJPM(DALKFPIOIFA IJDHKINBJBN, KOJHHCPHIHG EBCFJIOFMNC, [Optional] Guid? HOFBFGLIONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x56A0A70", Offset = "0x569F070", VA = "0x1856A0A70")]
	private MDPCDPBDELI NPFLIODMBGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	protected virtual void LAENGLNKCGA(MDPCDPBDELI CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x56A0860", Offset = "0x569EE60", VA = "0x1856A0860")]
	public T DDGBGGPPOOL(KNOJHPOMDED GEHCGKCBEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x56A0770", Offset = "0x569ED70", VA = "0x1856A0770")]
	public T AEAOOEPJEIA(int CGOKJKFNKLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x56A0950", Offset = "0x569EF50", VA = "0x1856A0950", Slot = "5")]
	public virtual Task<JDKMKDKEGJC> IOJADCBJNEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public class PBNGOKLOGLC : NNEGLNAAJPM<PBNGOKLOGLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007C7")]
	private JBNAFHMBIJM INCLIAEIKDJ;

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x8880F80", Offset = "0x887F580", VA = "0x188880F80")]
	internal PBNGOKLOGLC(DALKFPIOIFA IJDHKINBJBN, KOJHHCPHIHG EBCFJIOFMNC, [Optional] Guid? HOFBFGLIONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x7A47130", Offset = "0x7A45730", VA = "0x187A47130")]
	public PBNGOKLOGLC HMNJECGCCBN(JBNAFHMBIJM INCLIAEIKDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x8880EB0", Offset = "0x887F4B0", VA = "0x188880EB0", Slot = "4")]
	protected override void LAENGLNKCGA(MDPCDPBDELI CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public class KEHJIGNGEIF : NNEGLNAAJPM<KEHJIGNGEIF>
{
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	internal enum PKEGMMAGCCG
	{
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[CompilerGenerated]
	private struct MADHPEDKBPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		public AsyncTaskMethodBuilder<JDKMKDKEGJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		public KEHJIGNGEIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		private TaskAwaiter<JDKMKDKEGJC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x887A620", Offset = "0x8878C20", VA = "0x18887A620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x887A9D0", Offset = "0x8878FD0", VA = "0x18887A9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007C8")]
	private PKEGMMAGCCG HPDKAPCOHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007C9")]
	private string LENBEAMDHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007CA")]
	private OBKGFFDIEBB INCLIAEIKDJ;

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x8879960", Offset = "0x8877F60", VA = "0x188879960")]
	internal KEHJIGNGEIF(DALKFPIOIFA IJDHKINBJBN, KOJHHCPHIHG EBCFJIOFMNC, [Optional] Guid? HOFBFGLIONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x8879930", Offset = "0x8877F30", VA = "0x188879930")]
	public KEHJIGNGEIF PLCDODBNPHD(string LCNJPNDEDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x8879620", Offset = "0x8877C20", VA = "0x188879620")]
	public KEHJIGNGEIF CHJBOPPPBJF(bool MNLMMJDNPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x8879640", Offset = "0x8877C40", VA = "0x188879640")]
	public KEHJIGNGEIF CKNJEDGEBAC(bool NNNNAPKDIKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x88796A0", Offset = "0x8877CA0", VA = "0x1888796A0")]
	public KEHJIGNGEIF GNJJBHPCHGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x88797C0", Offset = "0x8877DC0", VA = "0x1888797C0", Slot = "4")]
	protected override void LAENGLNKCGA(MDPCDPBDELI CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x88796D0", Offset = "0x8877CD0", VA = "0x1888796D0", Slot = "5")]
	[AsyncStateMachine(typeof(MADHPEDKBPA))]
	public override Task<JDKMKDKEGJC> IOJADCBJNEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x8879660", Offset = "0x8877C60", VA = "0x188879660")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<JDKMKDKEGJC> EGAEGGMOIPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
internal static class EHOFDMKEAOG
{
	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x8874790", Offset = "0x8872D90", VA = "0x188874790")]
	public static void NILKBLGHFLI(this PIOHADAKEMO FEBEKKFBDPJ, MPGMBCPBAJA PCEFELIJEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x8874710", Offset = "0x8872D10", VA = "0x188874710")]
	public static void LHJBLMPKHDI(this MPGMBCPBAJA GKIIDCPHJMB, [Optional] string CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
public static class OEHLCMKMAHL
{
	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x887FDE0", Offset = "0x887E3E0", VA = "0x18887FDE0")]
	public static HNKIFFEICOH EFFGBBMPEHB(this LIFAKAIMHBN PABLKPAKAOD)
	{
		return default(HNKIFFEICOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x887FD30", Offset = "0x887E330", VA = "0x18887FD30")]
	public static LIFAKAIMHBN DABDDMGLAPF(this HNKIFFEICOH HCIKJMGMOCD)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001B8")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007D7")]
			public JPKCPLKGCFK ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007D8")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007D9")]
			public JPKCPLKGCFK HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006DF")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		private static JPKCPLKGCFK[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private Dictionary<JPKCPLKGCFK, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x8884910", Offset = "0x8882F10", VA = "0x188884910")]
		public bool IOMDOJOOMGM(JPKCPLKGCFK EEOBLKILFID, [Out] ResultConfig HHBGHAKIGCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x88847D0", Offset = "0x8882DD0", VA = "0x1888847D0")]
		public ResultConfig DJGCPOPKFIK(JPKCPLKGCFK CIOGCOOPLBM, [Optional] HashSet<JPKCPLKGCFK> IOGHIFIIIHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x8884EE0", Offset = "0x88834E0", VA = "0x188884EE0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x8884980", Offset = "0x8882F80", VA = "0x188884980", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xC6D2F0", Offset = "0xC6B8F0", VA = "0x180C6D2F0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
public class AJNINOOBFLB : JOGBHPFCPAE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[CompilerGenerated]
	private struct BBILPKJIBHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public AJNINOOBFLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x886E740", Offset = "0x886CD40", VA = "0x18886E740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x886E9D0", Offset = "0x886CFD0", VA = "0x18886E9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[CompilerGenerated]
	private struct CBKNLMDAIGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		public JOGBHPFCPAE preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x886FAA0", Offset = "0x886E0A0", VA = "0x18886FAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x886FF40", Offset = "0x886E540", VA = "0x18886FF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007E2")]
	private readonly KHKIICOLHEN CNBGFEKBKFB;

	[Cpp2IlInjected.Token(Token = "0x40007E3")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string EKICILFHPMI
	{
		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x886E590", Offset = "0x886CB90", VA = "0x18886E590", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x886E400", Offset = "0x886CA00", VA = "0x18886E400")]
	[BNHIEDNKDNA.MLFEBCDGLFC.CIEDAEOKGHH]
	internal static void BGFKKOPDAMP(DCNOMJHNEOK PPICPBELMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	[RecRoom.NoEngine.Common.Preserve]
	public AJNINOOBFLB([GGNLMCAPMLP(null)] KHKIICOLHEN CNBGFEKBKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x886E5C0", Offset = "0x886CBC0", VA = "0x18886E5C0", Slot = "5")]
	[AsyncStateMachine(typeof(BBILPKJIBHO))]
	public Task JNJJALJCEOA(EHMNEFALKGP<string>.OJMJGFAOFAB PFAHMJFBIOD, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x886E470", Offset = "0x886CA70", VA = "0x18886E470")]
	[AsyncStateMachine(typeof(CBKNLMDAIGB))]
	private Task EDDDIDBLOJG(JOGBHPFCPAE BACJBJFNCKO, EHMNEFALKGP<string>.OJMJGFAOFAB PFAHMJFBIOD, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
public interface KHKIICOLHEN : JOGBHPFCPAE
{
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public interface JOGBHPFCPAE
{
	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	string EKICILFHPMI
	{
		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JNJJALJCEOA(EHMNEFALKGP<string>.OJMJGFAOFAB PFAHMJFBIOD, CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public static class FDDACFCEGIB
{
	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x8874980", Offset = "0x8872F80", VA = "0x188874980")]
	[BNHIEDNKDNA.MLFEBCDGLFC.CIEDAEOKGHH]
	internal static void PCDILHPDLBD(DCNOMJHNEOK PPICPBELMKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public interface FOKPKNFMFMF : IEquatable<FOKPKNFMFMF>
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	DateTime BGPAPNMLHIE
	{
		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPHCLFEDDBO();

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CIDGCACLEHA(long CDFGHIILPDC, long BKDNOJBOAHD, [Out] IOGPAGLBJEO OOJHDNHPGCB);
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
internal class DHFOOMKCFHF : OOGKMMNAEKD
{
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[CompilerGenerated]
	private sealed class LMMNJNIDOIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		public LHKOGNCOGAD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public LMMNJNIDOIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x887A5B0", Offset = "0x8878BB0", VA = "0x18887A5B0")]
		internal object IKCMDNBIEDJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F1")]
	private readonly BMCKNPGDCJD BJMOMKLEDID;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<FOKPKNFMFMF> OCPLILGBBGE
	{
		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x8871F40", Offset = "0x8870540", VA = "0x188871F40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x8871E90", Offset = "0x8870490", VA = "0x188871E90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	[UnityEngine.Scripting.Preserve]
	public DHFOOMKCFHF([GGNLMCAPMLP(null)] BMCKNPGDCJD BJMOMKLEDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x8872640", Offset = "0x8870C40", VA = "0x188872640", Slot = "6")]
	public bool NDPOIOFKENA(long CDFGHIILPDC, long BKDNOJBOAHD, IOGPAGLBJEO OOJHDNHPGCB, LHKOGNCOGAD POKKLCDMDDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0xE70830", Offset = "0xE6EE30", VA = "0x180E70830")]
	private void LDHILFEMFBC(FOKPKNFMFMF ICKONMFOJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x8871FF0", Offset = "0x88705F0", VA = "0x188871FF0", Slot = "7")]
	public bool KJIKGKEDJAL(long CDFGHIILPDC, long BKDNOJBOAHD, [Out] FOKPKNFMFMF MFANCCGGIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x8872160", Offset = "0x8870760", VA = "0x188872160", Slot = "8")]
	public bool LJNDDBJFDAL(long CDFGHIILPDC, long BKDNOJBOAHD, LHKOGNCOGAD POKKLCDMDDO, [Out] FOKPKNFMFMF MFANCCGGIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x8872210", Offset = "0x8870810", VA = "0x188872210")]
	private void NCJOHOAIAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x8872940", Offset = "0x8870F40", VA = "0x188872940", Slot = "9")]
	public void PPPIHNANFAL(long CDFGHIILPDC, long BKDNOJBOAHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
internal abstract class DNEPEIKKAKI : BMCKNPGDCJD
{
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	protected enum FGHPIBDJOCO : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[CompilerGenerated]
	private sealed class CDGDMIBHLJD : IEnumerable<FOKPKNFMFMF>, IEnumerable, IEnumerator<FOKPKNFMFMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		private FOKPKNFMFMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		public DNEPEIKKAKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		private LHKOGNCOGAD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		public LHKOGNCOGAD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private FOKPKNFMFMF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4CD30", VA = "0x180F4E730")]
		[DebuggerHidden]
		public CDGDMIBHLJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x8870BA0", Offset = "0x886F1A0", VA = "0x188870BA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x8870E80", Offset = "0x886F480", VA = "0x188870E80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x8870DD0", Offset = "0x886F3D0", VA = "0x188870DD0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FOKPKNFMFMF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x8870DD0", Offset = "0x886F3D0", VA = "0x188870DD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[CompilerGenerated]
	private sealed class FCIOJJMKABC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000803")]
		public LHKOGNCOGAD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public FCIOJJMKABC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x88748E0", Offset = "0x8872EE0", VA = "0x1888748E0")]
		internal object GKPJFCBCBNL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[CompilerGenerated]
	private sealed class PHALGKBPKIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		public DNEPEIKKAKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public PHALGKBPKIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x8881050", Offset = "0x887F650", VA = "0x188881050")]
		internal void BABMHDJAOJB(EGILCHNOPLG.ACOCCNDELPE ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F7")]
	private readonly object PAIMDPMBIEJ;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	protected string JNNONOEMEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x8873770", Offset = "0x8871D70", VA = "0x188873770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public abstract IKOECHEKJFE GKGCMAJMDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x88737F0", Offset = "0x8871DF0", VA = "0x1888737F0")]
	protected DNEPEIKKAKI([CanBeNull] string KHBCCMCGDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x88731C0", Offset = "0x88717C0", VA = "0x1888731C0", Slot = "5")]
	public bool EKEDIMKNGDN(long CDFGHIILPDC, long BKDNOJBOAHD, LHKOGNCOGAD POKKLCDMDDO, [Out] FOKPKNFMFMF ICKONMFOJOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x8872DB0", Offset = "0x88713B0", VA = "0x188872DB0", Slot = "6")]
	[IteratorStateMachine(typeof(CDGDMIBHLJD))]
	public IEnumerable<FOKPKNFMFMF> CGMMFMDDEJG(LHKOGNCOGAD POKKLCDMDDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void NDFIJNOPPKD(Stream KDFFNBOLOKC, long CDFGHIILPDC, long BKDNOJBOAHD, IOGPAGLBJEO OOJHDNHPGCB);

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool KPNKNFIIOAJ(Stream JKDNJENOMEN, long CDFGHIILPDC, long BKDNOJBOAHD, FDAPGHCKOEB JKHJIFPANIJ, [Out] IOGPAGLBJEO OOJHDNHPGCB);

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x8872E40", Offset = "0x8871440", VA = "0x188872E40", Slot = "7")]
	public FOKPKNFMFMF DNHAMBCLIHO(long CDFGHIILPDC, long BKDNOJBOAHD, IOGPAGLBJEO OOJHDNHPGCB, LHKOGNCOGAD POKKLCDMDDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo MFDEOINBMAC(long CDFGHIILPDC, long BKDNOJBOAHD, LHKOGNCOGAD POKKLCDMDDO, FGHPIBDJOCO FBENOAHAGAD);

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo OOBDLJDOMAC(LHKOGNCOGAD POKKLCDMDDO, FGHPIBDJOCO FBENOAHAGAD);

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x8873780", Offset = "0x8871D80", VA = "0x188873780")]
	protected void JMFMOHLHDJD(EGILCHNOPLG.ACOCCNDELPE MGOMMFHJDEM, string KDAOOGLIINF, FileInfo MEMBBAJGFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x88733B0", Offset = "0x88719B0", VA = "0x1888733B0")]
	internal bool GBGNANFKJND(FileInfo BEAPNCFJABE, long CDFGHIILPDC, long BKDNOJBOAHD, [Out] IOGPAGLBJEO OOJHDNHPGCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	private void AIJKEIPNPLO(Exception KCNEOPLNBEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
internal class FICCOJAGIFG : DNEPEIKKAKI
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public override IKOECHEKJFE GKGCMAJMDML
	{
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x13CE4A0", Offset = "0x13CCAA0", VA = "0x1813CE4A0", Slot = "8")]
		get
		{
			return default(IKOECHEKJFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x8876620", Offset = "0x8874C20", VA = "0x188876620")]
	public FICCOJAGIFG([Optional] string KHBCCMCGDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x8875A00", Offset = "0x8874000", VA = "0x188875A00")]
	private void DGKMLKENDCF(LHKOGNCOGAD POKKLCDMDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x8876270", Offset = "0x8874870", VA = "0x188876270", Slot = "9")]
	internal override void NDFIJNOPPKD(Stream KDFFNBOLOKC, long CDFGHIILPDC, long BKDNOJBOAHD, IOGPAGLBJEO OOJHDNHPGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x8875A80", Offset = "0x8874080", VA = "0x188875A80", Slot = "10")]
	internal override bool KPNKNFIIOAJ(Stream JKDNJENOMEN, long CDFGHIILPDC, long BKDNOJBOAHD, FDAPGHCKOEB JKHJIFPANIJ, [Out] IOGPAGLBJEO OOJHDNHPGCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x8876180", Offset = "0x8874780", VA = "0x188876180", Slot = "11")]
	protected override FileInfo MFDEOINBMAC(long CDFGHIILPDC, long BKDNOJBOAHD, LHKOGNCOGAD POKKLCDMDDO, FGHPIBDJOCO FBENOAHAGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x8876520", Offset = "0x8874B20", VA = "0x188876520", Slot = "12")]
	protected override DirectoryInfo OOBDLJDOMAC(LHKOGNCOGAD POKKLCDMDDO, FGHPIBDJOCO FBENOAHAGAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
internal sealed class NMMOEGKEFDN : DNEPEIKKAKI
{
	[Cpp2IlInjected.Token(Token = "0x4000807")]
	private static readonly byte[] BLIBAMJKLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000808")]
	private readonly byte[] HCIKECPNGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000809")]
	private readonly byte[] KOEEMABPCPD;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public override IKOECHEKJFE GKGCMAJMDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x197FCA0", Offset = "0x197E2A0", VA = "0x18197FCA0", Slot = "8")]
		get
		{
			return default(IKOECHEKJFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x887FC40", Offset = "0x887E240", VA = "0x18887FC40")]
	public NMMOEGKEFDN([Optional] string KHBCCMCGDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x887F680", Offset = "0x887DC80", VA = "0x18887F680", Slot = "9")]
	internal override void NDFIJNOPPKD(Stream KDFFNBOLOKC, long CDFGHIILPDC, long BKDNOJBOAHD, IOGPAGLBJEO OOJHDNHPGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x887EAE0", Offset = "0x887D0E0", VA = "0x18887EAE0", Slot = "10")]
	internal override bool KPNKNFIIOAJ(Stream JKDNJENOMEN, long CDFGHIILPDC, long BKDNOJBOAHD, FDAPGHCKOEB JKHJIFPANIJ, [Out] IOGPAGLBJEO OOJHDNHPGCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x887EA20", Offset = "0x887D020", VA = "0x18887EA20")]
	private void JLHNIENFMPO(byte[] IHNKIKDOAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x887F550", Offset = "0x887DB50", VA = "0x18887F550", Slot = "11")]
	protected override FileInfo MFDEOINBMAC(long CDFGHIILPDC, long BKDNOJBOAHD, LHKOGNCOGAD POKKLCDMDDO, FGHPIBDJOCO FBENOAHAGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x887FAA0", Offset = "0x887E0A0", VA = "0x18887FAA0", Slot = "12")]
	protected override DirectoryInfo OOBDLJDOMAC(LHKOGNCOGAD POKKLCDMDDO, FGHPIBDJOCO FBENOAHAGAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
public enum IKOECHEKJFE : byte
{
	[Cpp2IlInjected.Token(Token = "0x400080D")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400080E")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400080F")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
internal class BOILDNFEPAO : BMCKNPGDCJD
{
	[Cpp2IlInjected.Token(Token = "0x20001CF")]
	[CompilerGenerated]
	private sealed class POHBILNJKCJ : IEnumerable<FOKPKNFMFMF>, IEnumerable, IEnumerator<FOKPKNFMFMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000816")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		private FOKPKNFMFMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		public BOILDNFEPAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private LHKOGNCOGAD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		public LHKOGNCOGAD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		private IKOECHEKJFE[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		private IEnumerator<FOKPKNFMFMF> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		private FOKPKNFMFMF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4CD30", VA = "0x180F4E730")]
		[DebuggerHidden]
		public POHBILNJKCJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x8882190", Offset = "0x8880790", VA = "0x188882190", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x8881DB0", Offset = "0x88803B0", VA = "0x188881DB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x8881D60", Offset = "0x8880360", VA = "0x188881D60")]
		private void APENNGMAANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x8882140", Offset = "0x8880740", VA = "0x188882140", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x8882090", Offset = "0x8880690", VA = "0x188882090", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FOKPKNFMFMF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x8882090", Offset = "0x8880690", VA = "0x188882090", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000810")]
	private readonly IKOECHEKJFE[] JENIFNOMOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000811")]
	private readonly Dictionary<IKOECHEKJFE, BMCKNPGDCJD> AJPABCDHEIK;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public IKOECHEKJFE GKGCMAJMDML
	{
		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x886EED0", Offset = "0x886D4D0", VA = "0x18886EED0", Slot = "4")]
		get
		{
			return default(IKOECHEKJFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x886F130", Offset = "0x886D730", VA = "0x18886F130")]
	[UnityEngine.Scripting.Preserve]
	public BOILDNFEPAO(params BMCKNPGDCJD[] CNEKDKJEODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x886ED80", Offset = "0x886D380", VA = "0x18886ED80", Slot = "5")]
	public bool EKEDIMKNGDN(long CDFGHIILPDC, long BKDNOJBOAHD, LHKOGNCOGAD POKKLCDMDDO, [Out] FOKPKNFMFMF ICKONMFOJOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x886EF00", Offset = "0x886D500", VA = "0x18886EF00")]
	private void MGOJOOMEHCM(int FBOAJCCAAHN, long CDFGHIILPDC, long BKDNOJBOAHD, LHKOGNCOGAD POKKLCDMDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x886EC00", Offset = "0x886D200", VA = "0x18886EC00", Slot = "6")]
	[IteratorStateMachine(typeof(POHBILNJKCJ))]
	public IEnumerable<FOKPKNFMFMF> CGMMFMDDEJG(LHKOGNCOGAD POKKLCDMDDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x886EC90", Offset = "0x886D290", VA = "0x18886EC90", Slot = "7")]
	public FOKPKNFMFMF DNHAMBCLIHO(long CDFGHIILPDC, long BKDNOJBOAHD, IOGPAGLBJEO OOJHDNHPGCB, LHKOGNCOGAD POKKLCDMDDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
internal static class IKDMGDANOME
{
	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x8878920", Offset = "0x8876F20", VA = "0x188878920")]
	internal static byte[] AEMMIHHGGJI(byte[] IHNKIKDOAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x8878BC0", Offset = "0x88771C0", VA = "0x188878BC0")]
	public static void JNNFAPBAOFC(Stream HPOBJJDBMBK, byte[] JHMBNEPJJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x88789E0", Offset = "0x8876FE0", VA = "0x1888789E0")]
	public static bool HBPNGIDJAKM(Stream HPOBJJDBMBK, long KNLHHMBEKGK, FDAPGHCKOEB IPDIMFFCCBH, [Out] byte[] FMIFMANJLMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
internal sealed class KDBMDEAICKO : FOKPKNFMFMF, IEquatable<FOKPKNFMFMF>, IEquatable<KDBMDEAICKO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400081F")]
	private readonly DNEPEIKKAKI HJOMOIFEONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000820")]
	public readonly FileInfo IHJKMNDLKHJ;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public IKOECHEKJFE GKGCMAJMDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x80FFB20", Offset = "0x80FE120", VA = "0x1880FFB20", Slot = "9")]
		get
		{
			return default(IKOECHEKJFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public DateTime BGPAPNMLHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x8878FB0", Offset = "0x88775B0", VA = "0x188878FB0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x88794A0", Offset = "0x8877AA0", VA = "0x1888794A0")]
	public KDBMDEAICKO(DNEPEIKKAKI CJNJPOOAGMJ, FileInfo BEAPNCFJABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x88793F0", Offset = "0x88779F0", VA = "0x1888793F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x8879330", Offset = "0x8877930", VA = "0x188879330", Slot = "5")]
	public void NPHCLFEDDBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x8879040", Offset = "0x8877640", VA = "0x188879040", Slot = "6")]
	public bool CIDGCACLEHA(long CDFGHIILPDC, long BKDNOJBOAHD, [Out] IOGPAGLBJEO OOJHDNHPGCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x8879230", Offset = "0x8877830", VA = "0x188879230", Slot = "7")]
	public bool Equals(FOKPKNFMFMF HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x8879080", Offset = "0x8877680", VA = "0x188879080", Slot = "8")]
	public bool Equals(KDBMDEAICKO HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x8879140", Offset = "0x8877740", VA = "0x188879140", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x88792A0", Offset = "0x88778A0", VA = "0x1888792A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
public delegate void FDAPGHCKOEB(EGILCHNOPLG.ACOCCNDELPE GGOGAIMBFKF, string CJIMOMNMAGD);
[Cpp2IlInjected.Token(Token = "0x20001D3")]
internal interface BMCKNPGDCJD
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	IKOECHEKJFE GKGCMAJMDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EKEDIMKNGDN(long CDFGHIILPDC, long BKDNOJBOAHD, LHKOGNCOGAD POKKLCDMDDO, [Out] FOKPKNFMFMF ICKONMFOJOH);

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<FOKPKNFMFMF> CGMMFMDDEJG(LHKOGNCOGAD POKKLCDMDDO);

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FOKPKNFMFMF DNHAMBCLIHO(long CDFGHIILPDC, long BKDNOJBOAHD, IOGPAGLBJEO OOJHDNHPGCB, LHKOGNCOGAD POKKLCDMDDO);
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
