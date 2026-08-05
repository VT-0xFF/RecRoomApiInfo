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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x79600B0", Offset = "0x795F2B0", VA = "0x1879600B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
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
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D6D0", VA = "0x18091E4D0")]
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
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7959D60", Offset = "0x7958F60", VA = "0x187959D60", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x79644D0", Offset = "0x79636D0", VA = "0x1879644D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JOHOJIFMIBF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7957670", Offset = "0x7956870", VA = "0x187957670")]
	public JOHOJIFMIBF(string CBCJFCINKPJ, Exception EKNOIMPALPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class EFGCFEFEJNC : GHJOFHOKBLI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct JACCFOPNBOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<GLPOHAHMIGG>> <>t__builder;

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
		private TaskAwaiter<FCDHELLKKAK<GLPOHAHMIGG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7956170", Offset = "0x7955370", VA = "0x187956170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x79563B0", Offset = "0x79555B0", VA = "0x1879563B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GMDDBIJADGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<JLNAODDLBBG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<JLNAODDLBBG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7953920", Offset = "0x7952B20", VA = "0x187953920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7953B30", Offset = "0x7952D30", VA = "0x187953B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	[UnityEngine.Scripting.Preserve]
	public EFGCFEFEJNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x794BA80", Offset = "0x794AC80", VA = "0x18794BA80", Slot = "4")]
	[AsyncStateMachine(typeof(JACCFOPNBOD))]
	public Task<IReadOnlyList<GLPOHAHMIGG>> IJEPOCHDGBI(long MOMKFNIIPAA, long GHKEIJKOONC, [Optional] CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x794BBA0", Offset = "0x794ADA0", VA = "0x18794BBA0", Slot = "5")]
	[AsyncStateMachine(typeof(GMDDBIJADGD))]
	public Task<IReadOnlyList<JLNAODDLBBG>> NIANGKIDHMG(IReadOnlyList<int> GMHJDJFHLLJ, [Optional] CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JJIDAEEGHND : IEquatable<JJIDAEEGHND>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int GKHAJPLJHHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	JLNAODDLBBG AKBINDFOIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime KPHMANGGGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	LDFCGIKJOLB? PFIBIKFNDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EAFHODAMPLO? JFFHMHDJCOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	ANOLKAACNOE GJFMPFAEICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<JIDFLMCDEBP> BFPHLKLCGNF();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum ANOLKAACNOE
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GHJOFHOKBLI
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<GLPOHAHMIGG>> IJEPOCHDGBI(long MOMKFNIIPAA, long GHKEIJKOONC, [Optional] CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<JLNAODDLBBG>> NIANGKIDHMG(IReadOnlyList<int> GMHJDJFHLLJ, [Optional] CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LJOJFNEMCDG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class IOCDCAABMFP : JJIDAEEGHND, IEquatable<JJIDAEEGHND>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct MIFALCKCFBC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<JIDFLMCDEBP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IOCDCAABMFP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private CAKAGJOFHDA <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<OAOBEPBAJLE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<JIDFLMCDEBP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x795E670", Offset = "0x795D870", VA = "0x18795E670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x795EB30", Offset = "0x795DD30", VA = "0x18795EB30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly GLPOHAHMIGG IFGFADLBLGF;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int GKHAJPLJHHM
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D30", Offset = "0x8F3F30", VA = "0x1808F4D30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public JLNAODDLBBG AKBINDFOIIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime DGJGMJNDMNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x63B8DE0", Offset = "0x63B7FE0", VA = "0x1863B8DE0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public LDFCGIKJOLB? PFIBIKFNDEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xC2D010", Offset = "0xC2C210", VA = "0x180C2D010", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public EAFHODAMPLO? JFFHMHDJCOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x63B8EE0", Offset = "0x63B80E0", VA = "0x1863B8EE0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ANOLKAACNOE GJFMPFAEICI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA8A350", Offset = "0xA89550", VA = "0x180A8A350", Slot = "10")]
			get
			{
				return default(ANOLKAACNOE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7955BC0", Offset = "0x7954DC0", VA = "0x187955BC0", Slot = "9")]
		[AsyncStateMachine(typeof(MIFALCKCFBC))]
		public Task<JIDFLMCDEBP> BFPHLKLCGNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7955EB0", Offset = "0x79550B0", VA = "0x187955EB0")]
		public IOCDCAABMFP(int KHPALEBBHIC, JLNAODDLBBG ACOELABPJAI, GLPOHAHMIGG IFGFADLBLGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7955D60", Offset = "0x7954F60", VA = "0x187955D60", Slot = "11")]
		public bool Equals(JJIDAEEGHND JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7955CC0", Offset = "0x7954EC0", VA = "0x187955CC0", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7955E70", Offset = "0x7955070", VA = "0x187955E70")]
		private bool JABBPONPOJA(IOCDCAABMFP JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7955DF0", Offset = "0x7954FF0", VA = "0x187955DF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class JFJAPCEGJIC : JJIDAEEGHND, IEquatable<JJIDAEEGHND>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct LKDIAGDJKPE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<JIDFLMCDEBP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public JFJAPCEGJIC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<JIDFLMCDEBP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7959AA0", Offset = "0x7958CA0", VA = "0x187959AA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7959CF0", Offset = "0x7958EF0", VA = "0x187959CF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly AOCJALDHGHI GMDPPNKGCCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly LDFCGIKJOLB LINGPOAEBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly EAFHODAMPLO JCEIJMIKJFF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int GKHAJPLJHHM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7956560", Offset = "0x7955760", VA = "0x187956560", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public JLNAODDLBBG AKBINDFOIIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7956740", Offset = "0x7955940", VA = "0x187956740", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime DGJGMJNDMNE
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7956850", Offset = "0x7955A50", VA = "0x187956850", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public LDFCGIKJOLB? PFIBIKFNDEG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7956510", Offset = "0x7955710", VA = "0x187956510", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public EAFHODAMPLO? JFFHMHDJCOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x79565A0", Offset = "0x79557A0", VA = "0x1879565A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ANOLKAACNOE GJFMPFAEICI
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA79BB0", Offset = "0xA78DB0", VA = "0x180A79BB0", Slot = "10")]
			get
			{
				return default(ANOLKAACNOE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1BC8AC0", Offset = "0x1BC7CC0", VA = "0x181BC8AC0")]
		public JFJAPCEGJIC(AOCJALDHGHI EFHNEIIGJPA, LDFCGIKJOLB GNICOMOJOCD, EAFHODAMPLO IHBNBIMNEHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7956420", Offset = "0x7955620", VA = "0x187956420", Slot = "9")]
		[AsyncStateMachine(typeof(LKDIAGDJKPE))]
		public Task<JIDFLMCDEBP> BFPHLKLCGNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x79565F0", Offset = "0x79557F0", VA = "0x1879565F0", Slot = "11")]
		public bool Equals(JJIDAEEGHND JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7956690", Offset = "0x7955890", VA = "0x187956690", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x79568A0", Offset = "0x7955AA0", VA = "0x1879568A0")]
		private bool JABBPONPOJA(JFJAPCEGJIC JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x79567D0", Offset = "0x79559D0", VA = "0x1879567D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class KPAINJDDGOI : JJIDAEEGHND, IEquatable<JJIDAEEGHND>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct NIGJLNEBGPF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<JIDFLMCDEBP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<JIDFLMCDEBP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x795FD70", Offset = "0x795EF70", VA = "0x18795FD70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x795FFD0", Offset = "0x795F1D0", VA = "0x18795FFD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly JLNAODDLBBG FDBPCOJGLIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly LDFCGIKJOLB LINGPOAEBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly EAFHODAMPLO JCEIJMIKJFF;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int GKHAJPLJHHM
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7958FB0", Offset = "0x79581B0", VA = "0x187958FB0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public JLNAODDLBBG AKBINDFOIIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime DGJGMJNDMNE
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public LDFCGIKJOLB? PFIBIKFNDEG
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7958F60", Offset = "0x7958160", VA = "0x187958F60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public EAFHODAMPLO? JFFHMHDJCOF
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7958FD0", Offset = "0x79581D0", VA = "0x187958FD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ANOLKAACNOE GJFMPFAEICI
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "10")]
			get
			{
				return default(ANOLKAACNOE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1BC8AC0", Offset = "0x1BC7CC0", VA = "0x181BC8AC0")]
		public KPAINJDDGOI(JLNAODDLBBG ACOELABPJAI, LDFCGIKJOLB GNICOMOJOCD, EAFHODAMPLO IHBNBIMNEHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7958E90", Offset = "0x7958090", VA = "0x187958E90", Slot = "9")]
		[AsyncStateMachine(typeof(NIGJLNEBGPF))]
		public Task<JIDFLMCDEBP> BFPHLKLCGNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7959020", Offset = "0x7958220", VA = "0x187959020", Slot = "11")]
		public bool Equals(JJIDAEEGHND JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7959090", Offset = "0x7958290", VA = "0x187959090", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7959110", Offset = "0x7958310", VA = "0x187959110", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x79591A0", Offset = "0x79583A0", VA = "0x1879591A0")]
		private bool JABBPONPOJA(KPAINJDDGOI JAINJPLCLDO)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct BDCOLLPEKDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<JJIDAEEGHND>> <>t__builder;

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
		public LJOJFNEMCDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<GLPOHAHMIGG> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<GLPOHAHMIGG>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, JLNAODDLBBG account, GLPOHAHMIGG roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7947AD0", Offset = "0x7946CD0", VA = "0x187947AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7948900", Offset = "0x7947B00", VA = "0x187948900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct HBBPDJAANND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, JLNAODDLBBG account, GLPOHAHMIGG roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<GLPOHAHMIGG> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public LJOJFNEMCDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<JLNAODDLBBG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7953F20", Offset = "0x7953120", VA = "0x187953F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7954920", Offset = "0x7953B20", VA = "0x187954920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly AHNBDAKJCEJ HDPMNHDHNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly GHJOFHOKBLI OGIJIFFKDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly DFAEOHGPHNA BIIEMNIEMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly IGGALDAFIPN<(long, long), IReadOnlyList<GLPOHAHMIGG>> NMLCOKBGKJJ;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7959970", Offset = "0x7958B70", VA = "0x187959970")]
	[UnityEngine.Scripting.Preserve]
	public LJOJFNEMCDG([FMJHJHHALCB(null)] GHJOFHOKBLI PDIDMDHALOH, [FMJHJHHALCB(null)] DFAEOHGPHNA NBMAKPPGGNC, [FMJHJHHALCB(null)] AHNBDAKJCEJ OAHPDBHPGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7959570", Offset = "0x7958770", VA = "0x187959570")]
	[AsyncStateMachine(typeof(BDCOLLPEKDP))]
	public Task<IList<JJIDAEEGHND>> AAINEDBJDHN(long MOMKFNIIPAA, long NPLPICCKAOE, bool CFKLEMEBBAN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x79597D0", Offset = "0x79589D0", VA = "0x1879597D0")]
	private bool PLHICBELLNF(DateTime? MFDLCKOFGML, long MOMKFNIIPAA, long NPLPICCKAOE, [Out] AOCJALDHGHI DOKPKCJJFPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x79596C0", Offset = "0x79588C0", VA = "0x1879596C0")]
	[AsyncStateMachine(typeof(HBBPDJAANND))]
	private Task<IReadOnlyList<(int, JLNAODDLBBG, GLPOHAHMIGG)>> LJMAOMPIHAH(IReadOnlyList<GLPOHAHMIGG> JEBFLPBMLBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DFAEOHGPHNA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<AOCJALDHGHI> BIPNLMJNKJH;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BFAJBBJBPCN(long MOMKFNIIPAA, long NPLPICCKAOE, AGCEOGPCGMI EOIHJIJJOIC, JBGHPJPHEMA IMGJKIKFHHF);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HCOAGIGAGEB(long MOMKFNIIPAA, long NPLPICCKAOE, [Out] AOCJALDHGHI DOKPKCJJFPF);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FCMFJDOBNMF(long MOMKFNIIPAA, long NPLPICCKAOE, JBGHPJPHEMA IMGJKIKFHHF, [Out] AOCJALDHGHI DOKPKCJJFPF);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FHDACEAFPCJ(long MOMKFNIIPAA, long NPLPICCKAOE);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface HNOBBEEKOHL : LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool IBCLOOJFNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task EKNIIAFOABB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KAGIIGFAPFL(Task JPPEAAIELKB, string JIGEOFILHBA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface FBLEPDEEPND : LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JIDFLMCDEBP> LMIKFELOIJE(AOCJALDHGHI DOKPKCJJFPF);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PODIFEJJIAE(CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface GEKEAHMAJJI : LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	FAOLIJLBMLP BFDIHMPBAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AAKGNKEABKA();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MKNDKLLIFCG();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface LOPMFDCLLIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGPOBANFNOP(NDEJMCPCCDJ CNCOIDECOMJ);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface POLHFFJEJFN
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan BMBDIEKOCOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan FIJIAINLLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan MCAIPEJHDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan OKMJIGAJNML
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool FIJFPILOLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool EOELLEKPEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool MPIENFHLEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int KHONHGAMAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool KNCFNNDNMEN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool HOIIEDDAHBE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum HDEGMMMKMOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum NGLFBMMEGBN
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
public struct IAFPHBAAAOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long EIJMKMECPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long GHKEIJKOONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly HDEGMMMKMOJ MDOOANEGCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception DOIHJLOELKG;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x79550D0", Offset = "0x79542D0", VA = "0x1879550D0")]
	public IAFPHBAAAOE(long EIJMKMECPMP, long GHKEIJKOONC, HDEGMMMKMOJ MDOOANEGCAH, [CanBeNull] Exception DOIHJLOELKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7955080", Offset = "0x7954280", VA = "0x187955080")]
	public static IAFPHBAAAOE PLDGGNMENDN(KHDFIKJLGJL PBPEOMJKKKC, HDEGMMMKMOJ MDOOANEGCAH, [Optional] Exception DOIHJLOELKG)
	{
		return default(IAFPHBAAAOE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void HFJCDCCNFNJ(IAFPHBAAAOE ABMEFKHBMNE);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface BMNEILKOCPL : LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action JHGLONFKKKL;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event HFJCDCCNFNJ EHFLKMGDECE;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event HFJCDCCNFNJ KFFNNLCCIMM;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event HFJCDCCNFNJ CFBHGKOECOA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<NGLFBMMEGBN, bool> MJBCEIDDNIK;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JEPNKBJPIHN();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AENBJDDOBMP(IAFPHBAAAOE ABMEFKHBMNE);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LEEJKHDLENF(IAFPHBAAAOE ABMEFKHBMNE);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AABFGMKFBEC(IAFPHBAAAOE ABMEFKHBMNE);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GPDHODAOHPD(NGLFBMMEGBN MFHJGCFBFIG, bool GMKDNLPGIGD);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface PJMBDGNBAGG : LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OEGJBOMNHJM();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KGFKFCNLMHB();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface HKBIGFOCBKM : LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus IILKPEHBEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MFJKKIEDLEF(KHDFIKJLGJL MFJJKMPPMDO, MBLMBODNJJG CDPHCJLDAGN, CancellationToken LHPAGMJCDIN);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class CPEOEMIOOGH
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x79499B0", Offset = "0x7948BB0", VA = "0x1879499B0")]
	public static bool MNAMGANAFHM(this HKBIGFOCBKM CEFAFOIADBM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate Task EODFAJAJAHG(CancellationToken BCOHKLCJCPM, int DLGKMEMHOGL, HEOHLAMPJMC GLOCFMOMECB);
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface ADECPFBBALC : LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKJEAMHLFNH(EODFAJAJAHG IHHGPCGJHDA);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface NDEJMCPCCDJ : CAKAGJOFHDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken IODHPAOFGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	JBPONICDCIO EDAJPGPJGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	JMCGIMEIOCB CAFANJMHLBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	NCGHKHMPIGG HHCFKHALIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	LMIBFAPANNF FFGEEHIBEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	EMIODIFKEJC NHBGKKKLKOF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NNGIBCDKGLA LDBNJIPINIL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	KFOMELNKPNH CNNHIHFNBND
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	EMHDMPCCNCO DIBAJDIKAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	HNOBBEEKOHL LIDDFOAMEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	FBLEPDEEPND HEGKHLGHJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	BMNEILKOCPL DEBJKKEJNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	PJMBDGNBAGG HDMKLKLOMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HKBIGFOCBKM AIOPMEPNNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	ADECPFBBALC BFGFJGACGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	HKDOMLGFBDK EBDBMGCBMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	KBACNKACNHI AACMFGLCJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	NFHJOHAGGAM GKGCLCALKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	ICHOMMDGIHO GEBMAMBKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	MEIJBJKHKBG HPGGEIFPJJP
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	OLDBABLMPPE BJPMMLIELJA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	EEMHNKCNKKG KMPOEKLCMGN
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	DFEKIFGBEDE JOCHEHGGIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	PEHGBBAEFBK NJIOONOPDKI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	NKJCPJBKINC HDDGBEFLCBP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	GEKEAHMAJJI EIKOMCMNEPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	POLHFFJEJFN BPOBBBJPLOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EMBLJOOMEMF CNPNLJKLOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	DFAEOHGPHNA FNAIKEEBPOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	DMOINKDAIOD KPNEIPANLLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	IMIOHGLICFJ FKMPAFCJILL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	NHKBIEIPOHH IBFCHAJFPHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	CCGAMJLHGEA JOEDAFEJFJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	new bool OLOKHJNKBNH
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
	void FGMHPHEGPGP(MBLMBODNJJG HMOFPPMJJAG);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface HKDOMLGFBDK : LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NBFMEBKJMKP CKLHJOINNOK(Guid DHNJGGKJENC);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GMODDBABBFK(Guid DHNJGGKJENC);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BENNGMOAMGM(Guid DHNJGGKJENC, Task LBPFHJHACNN);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MBHDEDAIAHB(Guid DHNJGGKJENC, JIDFLMCDEBP IBKOFPDAELI);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(JIDFLMCDEBP, Task)> AFJPHCJDKIH(Guid DHNJGGKJENC);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface OANEACPOBBM : LOPMFDCLLIO, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface KBACNKACNHI : LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPIMNBPALDC(FJJEHEJHICA CBCJFCINKPJ);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OCMJAAJNNEE(FJJEHEJHICA CBCJFCINKPJ);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<KMGKENCAGOE> JNCBFGCHEHO(CancellationToken BMNPINCDFBK);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface NFHJOHAGGAM : LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NBFMEBKJMKP AEKEMMBDOLF(FJJEHEJHICA PGOMOBGAPKC);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDCNMGHJNEL(Guid DHNJGGKJENC, Task LBPFHJHACNN);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface ICHOMMDGIHO : LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JIDFLMCDEBP> GEBMAMBKILJ(FJJEHEJHICA BGGCAOOLCME);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface MEIJBJKHKBG : LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FENMDJFMHBI> FHLANFNDNKE(EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, KHDFIKJLGJL MFJJKMPPMDO, CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface EEMHNKCNKKG : LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JIDFLMCDEBP BEOPCMOAAHJ(IAGJLFEFIKH IAIFMOHBNFK);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GHFFOPFIMAF(string BIIHNEHMDOI);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface OLDBABLMPPE : LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FJJEHEJHICA> PILOAHCHNEN(FJJEHEJHICA JLBJPEIMAMB, DAIEOJJKKMF HHPEAOJALPJ, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<FJJEHEJHICA> HGOJJKKAKGC(CancellationToken BGEKICMONBE, DAIEOJJKKMF HHPEAOJALPJ);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DDGKJPGGCCE MKBANOCDALD(AJHAEBBPGDJ OKBAPDEMJCF, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DDGKJPGGCCE DHOOGHKEPNG(AJHAEBBPGDJ OKBAPDEMJCF, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface DFEKIFGBEDE : LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JIDFLMCDEBP GLHJJADJBHB(IAGJLFEFIKH IAIFMOHBNFK, KMGKENCAGOE GCOMOAFFFNM);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JIDFLMCDEBP MFGACAGPOAC(IAGJLFEFIKH PJKFPOPJLHM);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface PEHGBBAEFBK
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHPDOKFCGAN(GLICPABNLKJ BJCLELPBBDM);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHFCKKEFFLE(GLICPABNLKJ BJCLELPBBDM);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JDMEJEOCLLL(GLICPABNLKJ BJCLELPBBDM);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JMGBEALEIPB(GLICPABNLKJ BJCLELPBBDM);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class GLICPABNLKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly KHDFIKJLGJL OACBBGEEGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> PCJNEKBCOAJ;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public EKKGOIIBGNN<string> IEKIPMECDOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8F5490", Offset = "0x8F4690", VA = "0x1808F5490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	public GLICPABNLKJ(KHDFIKJLGJL GIEDJEEFFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7953150", Offset = "0x7952350", VA = "0x187953150")]
	public GLICPABNLKJ MKLADDCEAPP(string OFPBICPHALF, string OMEFCJCOLII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x79530C0", Offset = "0x79522C0", VA = "0x1879530C0")]
	public bool EMCIFAECKJJ([Out] IEnumerable<KeyValuePair<string, string>> JNCAHDONHBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6AADF70", Offset = "0x6AAD170", VA = "0x186AADF70")]
	public GLICPABNLKJ FDFPMEDHBFJ(EKKGOIIBGNN<string> FBHOIGDCPGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface EMBLJOOMEMF
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool JFKEICEMHFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string EHLPHCIPJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool AGOJMDCGMOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CCAPPBFMJGE();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FMEENKBEGHJ FIHJDJMIFDN(long BBJKLNFMAJN);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OIGNAFLIEEG<GLPHDJDILNO, CGFMNABJBKA> FKKNDIJMFKM(long BBJKLNFMAJN);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OIGNAFLIEEG<GLPHDJDILNO, LJJCDEANBLH> KAALLNAJNKL(long BBJKLNFMAJN);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OIGNAFLIEEG<long, NCMNDHGNHEG> JIELBPJOFHO();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ANPKILEKFBM(long BBJKLNFMAJN, [Out] bool ALBDNEBKFFB);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> FCPFHINKAPJ(byte[] JBBABNEKIMJ, byte[] KEOAELBKNOE, CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CAKAGJOFHDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool MNAMGANAFHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool ADFNAEJAJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool OLOKHJNKBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	MBLMBODNJJG LCFINPJPKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action JHGLONFKKKL;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event HFJCDCCNFNJ EHFLKMGDECE;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event HFJCDCCNFNJ KFFNNLCCIMM;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event HFJCDCCNFNJ CFBHGKOECOA;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<NGLFBMMEGBN, bool> MJBCEIDDNIK;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KGFKFCNLMHB();

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GEFCICAJODG LEOOFKMEDKK();

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NCOGPGAMNCK PCFFJCEMGID();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<JIDFLMCDEBP> LMIKFELOIJE(AOCJALDHGHI EFHNEIIGJPA);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task PODIFEJJIAE(CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface EMIODIFKEJC
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool JIOGMNPENIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	string LGOJONHLNAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMMHIJNNBCI(Scene GLPLLFLCINH);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task JFEINNHMDDO(EKJLBFLMBMG FCGNLEBJADC, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task GNKOKCONBMM();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task HNMBIBEJKIA();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface LMIBFAPANNF
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	AOMKKEDLMKB INFDKHDKCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool DAOEEFNPMPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool ABNHNPEGDBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool IHKGPHMHFKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool FLKHFJGDCDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	int PPILDIOFJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool MACBLHOBMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool BCGBHBFKJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	int DFAHPDIMBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	int DBFIPOPLAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool ODOKNOMEHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool GNBHMDLNMDF
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool FLPBBDGFPDB
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	float OKEPKJMFEDK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> JPDNKOFKEBN;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JBPONICDCIO JFFPOINJNOI(JBPONICDCIO KBFOJKJCKFK);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LCEFGJDHFAD(JBPONICDCIO CKNPDKKKGFM);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDBAAJPEEME();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task NHBMDIPHIOO(EKKGOIIBGNN<string>.KJLMKGNBAOG LEKENFECBDC, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FKGILPKCIGH(float ILGNNCFDDPC);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BNELAGGEGMB(string ECOGHLMLONM);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<JIKAOKCOAGM> HNEODAJFMAF();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable BJBMLDEALMH(object GCGNIOHLIKK, JIKAOKCOAGM IOFAMKNLLAN);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<DPEIMBPEMEL> HGNFCBJHKAG();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CGFMNABJBKA DHNCAJACHDB(IEnumerable<INLFGDDOIPN> NDJPKPBNOCG);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LJDPFHBFAED(int PEEENJNCMNA);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task NPMFOKCBLOK();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ANNBKPPNPEH();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool FPIMEJONMLO();

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task JAOMEBAAOLP(CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task GILBBGJLCHD(CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<PCLPOBEDIDB> IHCONIGGENI(DateTime MLPEBJLKLLD, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> HDFNBJHKIDO(CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CIHOKPOPLMC(string CBCJFCINKPJ = "", float NHFPPHNGOPH = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KNPOFBEJPHJ GGMODGDNKKC(GBJAOKNDKME MBAOMPKNKCM, PPFCCODPGBI MKBCJJNBDGD, LJJCDEANBLH IOFMDAMACFG, IEnumerable<PersistenceView> EMMFEOCJAFK, IJKMGMJGDCO FOPPDGPMNPA);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IDCLIKIDGBD(LJJCDEANBLH IOFMDAMACFG);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MOAAPJCBDKA(INLFGDDOIPN HMHIBHFIJPG, [In] KNPOFBEJPHJ FOFFEAPCJOK);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task ECPCHBLCNPK(LJJCDEANBLH GIHONGMDDKI, bool IHNFDINBFAG, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task DCPBFIEGHJB(CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MDCNBBLJIOD(long MOMKFNIIPAA, long GHKEIJKOONC, OAOBEPBAJLE BGDELDLHBMB, GLPOHAHMIGG NBDKJFCLFPA, AGCEOGPCGMI EOIHJIJJOIC, CNHGMGKGANK? BLHOFKCFNMK, DGKJNLAJLBC? NAOHACOEFPD);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void EENHDGLEGPC(long MOMKFNIIPAA, long GHKEIJKOONC, DGKJNLAJLBC? NAOHACOEFPD);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void NPODPBMBANC(PersistenceView CHAAGMLBFOD);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool GEPGJLNDEEL(PersistenceView GOAHALBEPJI);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool DKNJMCCIJDN(INLFGDDOIPN HMHIBHFIJPG, IDAGJOOOCKM EPOIOKEICOJ, [Out] ALGOMCFKGGP HLNEIEBMBBD);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task APDADMKHBKN(CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void ADLPIHDBNOH();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable GMDILKPEFPG();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void APIBNDDHIHG(LJJCDEANBLH GIHONGMDDKI, IDAGJOOOCKM EPOIOKEICOJ);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> KHDCKMKMAFE(JMCGIMEIOCB IBMNPFDADDO, CancellationToken BGEKICMONBE, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void CGKOMGODGLL(CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<NMGIKLONOMM> KOJENPGEIGN(CKMKBEDDGJG JLBJPEIMAMB);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<OAOBEPBAJLE> DFEPPAKFPAH(long MOMKFNIIPAA, bool PAEOBGHCDPN, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<GLPOHAHMIGG> KHJKHKGBEJA(long MOMKFNIIPAA, long GHKEIJKOONC, long POOMNAEPOLM, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<GLPOHAHMIGG> NKLFOPHEIDE(long MOMKFNIIPAA, long GHKEIJKOONC, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<NKLGEBMKEAG> LIKHHJJMOAN(string PANOEKHIIKG, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<NKLGEBMKEAG> OICKKNMFPNK(string PANOEKHIIKG, long MOMKFNIIPAA, long GHKEIJKOONC, string BJIJJHHLOJN, AJAPFHEFMLP.MCLJEJPJKJC JPGPNLNCOHG, AJAPFHEFMLP.MCLJEJPJKJC KEOAELBKNOE, int KGAFBFCLOFM);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool IOBKLBHPDEL();

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool CBNCANBCPAN();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool EPGJBEFLLNF(IEnumerable<ALGOMCFKGGP> KHKIOAEKAPC);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void NBFHPHGAOFI(List<GameObject> AOKGJFPBJIA);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "52")]
	float CENFNHFMNAJ();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task<Scene> PMGAMBLKAJK(string OIECDHAKEME, LoadSceneMode PDBOMICJAJM, bool DAFCHLLMHEM, EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void BNABJKDLKPH();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void PNAKMFDHLEC(bool MPKIENECBCP);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void JHEJLOJBFNG();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void LHCIKDDPEEJ();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void OIKIOAHMNDD(KHDFIKJLGJL BPCDGFAHMOF);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task EOHLCKFPFJP(EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task LOMFKDHJEND(EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "70")]
	Task KFNJOEFKPOP(EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task OCMPJANBMAA(EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "72")]
	IDisposable PAEEODDPGIF();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "73")]
	LIMEANOPOBG ICEDNCFHIGC();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task FGDGLJLFBMH(CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface LIMEANOPOBG
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AOIPDNJMKGJ(CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HAAEMAOPIDJ(CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct KNPOFBEJPHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> KGNIOJPNGEE;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum PCLPOBEDIDB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct GBJAOKNDKME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string JHIKLAGJNDM;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface AOMKKEDLMKB
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	KHDFIKJLGJL DMDKFHIDIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	OAOBEPBAJLE FJMANNKMIOK
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	CNMPJHKKKIM FOGPOKOHJOH
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool OHBCJPOLHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool AABLONCOJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	int KKFAFGGDINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action IMHIHALHJFM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> NHADPHCNNNM;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BJBOCDPFLJO();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.HCNCMJKKAAM> AALFMNADBKE(long BBJKLNFMAJN, [Optional] CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<MFJPKPONFIJ> DIPMCMODHJP();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task KGLGGHOELME();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(KHDFIKJLGJL, MBLMBODNJJG) KNNAKIDOAFN();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AFDGPAEKBBP KLBDOAALDLI();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CBEEGCGEGDP(long BBJKLNFMAJN);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DKDKDLHCLGE(KHDFIKJLGJL GIEDJEEFFOM, Matchmaking.CELPPMMKMFO NJFLHCEDIDN, (int Major, int? Minor)? KGBDOKDJBHH);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface NKJCPJBKINC
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OLOFOEIFONA([Out] IEnumerable<int> LHAFCPHBBCG);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGFEEMHOJMK(IGCCAEFBMNB BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JDAPLLMBCFK(IGCCAEFBMNB BCOHKLCJCPM);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface FGGJICPNCLL
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IIGCALNJAEN(JIDFLMCDEBP JFBEBFDNAJM);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface GFPJMIHFAED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HKHGPFDMHBJ(MGJFCHFCCHD.PAHKLMAFDKA HPEEPFLBPIJ);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJKOMIJBHOF(MGJFCHFCCHD.PAHKLMAFDKA HPEEPFLBPIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface NNGIBCDKGLA : GFPJMIHFAED, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JIDFLMCDEBP DGKCGMILAOO(IAGJLFEFIKH PJKFPOPJLHM);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface KFOMELNKPNH : GFPJMIHFAED, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JIDFLMCDEBP BEOPCMOAAHJ(IAGJLFEFIKH FFIHLKECHEF);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface FMEENKBEGHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EBOICGKKPAM<EKJLBFLMBMG, ENAONJKJOID>> LIGDMGLPBEB(string BJIJJHHLOJN, long BBJKLNFMAJN, long? MOMKFNIIPAA, long? GHKEIJKOONC, JEBAGMAELAD.ALKCOCMPHGB HKLIEGDHCBF, CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface OIGNAFLIEEG<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EBOICGKKPAM<LAPLGAAPACL<TData>, ENAONJKJOID>> KHLMCFFLLNE(TGetDataArg CJJMPIPLCIJ, CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class MMIANIDPMDE : NDEJMCPCCDJ, CAKAGJOFHDA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct LEODAFLHHHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder<JIDFLMCDEBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public MMIANIDPMDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AOCJALDHGHI autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter<JIDFLMCDEBP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7959280", Offset = "0x7958480", VA = "0x187959280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7959500", Offset = "0x7958700", VA = "0x187959500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct CHFGGDEGGEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public MMIANIDPMDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7949550", Offset = "0x7948750", VA = "0x187949550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7949780", Offset = "0x7948980", VA = "0x187949780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class MGHPIKOPNEF : IEnumerable<LOPMFDCLLIO>, IEnumerable, IEnumerator<LOPMFDCLLIO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private LOPMFDCLLIO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public MMIANIDPMDE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		private LOPMFDCLLIO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xC45340", Offset = "0xC44540", VA = "0x180C45340")]
		[DebuggerHidden]
		public MGHPIKOPNEF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x795A740", Offset = "0x7959940", VA = "0x18795A740", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x795ABA0", Offset = "0x7959DA0", VA = "0x18795ABA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x795AAF0", Offset = "0x7959CF0", VA = "0x18795AAF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LOPMFDCLLIO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x795AAF0", Offset = "0x7959CF0", VA = "0x18795AAF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource IPMPPDFKNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly JBPONICDCIO CKNPDKKKGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool HAOFCOOGPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private BEPBHHFGGLM GICLLKBBEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private bool HFAOKAOIEOG;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public JMCGIMEIOCB CAFANJMHLBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8F21D0", Offset = "0x8F13D0", VA = "0x1808F21D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8F21B0", Offset = "0x8F13B0", VA = "0x1808F21B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public NCGHKHMPIGG HHCFKHALIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8F2220", Offset = "0x8F1420", VA = "0x1808F2220", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8F2200", Offset = "0x8F1400", VA = "0x1808F2200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public LMIBFAPANNF FFGEEHIBEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8F21E0", Offset = "0x8F13E0", VA = "0x1808F21E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8F2230", Offset = "0x8F1430", VA = "0x1808F2230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public EMIODIFKEJC NHBGKKKLKOF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8F2210", Offset = "0x8F1410", VA = "0x1808F2210", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8F2240", Offset = "0x8F1440", VA = "0x1808F2240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public NNGIBCDKGLA LDBNJIPINIL
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8F21C0", Offset = "0x8F13C0", VA = "0x1808F21C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8F21F0", Offset = "0x8F13F0", VA = "0x1808F21F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public KFOMELNKPNH CNNHIHFNBND
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8F9230", Offset = "0x8F8430", VA = "0x1808F9230", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8F9270", Offset = "0x8F8470", VA = "0x1808F9270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public EMHDMPCCNCO DIBAJDIKAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8F91E0", Offset = "0x8F83E0", VA = "0x1808F91E0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8F92A0", Offset = "0x8F84A0", VA = "0x1808F92A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public HNOBBEEKOHL LIDDFOAMEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8F91C0", Offset = "0x8F83C0", VA = "0x1808F91C0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8F9280", Offset = "0x8F8480", VA = "0x1808F9280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public FBLEPDEEPND HEGKHLGHJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA8A360", Offset = "0xA89560", VA = "0x180A8A360", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x110FBD0", Offset = "0x110EDD0", VA = "0x18110FBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public BMNEILKOCPL DEBJKKEJNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8F9260", Offset = "0x8F8460", VA = "0x1808F9260", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8F9210", Offset = "0x8F8410", VA = "0x1808F9210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public PJMBDGNBAGG HDMKLKLOMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xB79F30", Offset = "0xB79130", VA = "0x180B79F30", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xCEA770", Offset = "0xCE9970", VA = "0x180CEA770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public HKBIGFOCBKM AIOPMEPNNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8F7850", Offset = "0x8F6A50", VA = "0x1808F7850", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8F7890", Offset = "0x8F6A90", VA = "0x1808F7890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public ADECPFBBALC BFGFJGACGAN
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xAB89E0", Offset = "0xAB7BE0", VA = "0x180AB89E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xCF3C60", Offset = "0xCF2E60", VA = "0x180CF3C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public HKDOMLGFBDK EBDBMGCBMOO
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xBD1840", Offset = "0xBD0A40", VA = "0x180BD1840", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xBD1850", Offset = "0xBD0A50", VA = "0x180BD1850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public OANEACPOBBM GBPFBMGKELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xB79D60", Offset = "0xB78F60", VA = "0x180B79D60", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xF88D30", Offset = "0xF87F30", VA = "0x180F88D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public KBACNKACNHI AACMFGLCJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xB65170", Offset = "0xB64370", VA = "0x180B65170", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xBE88E0", Offset = "0xBE7AE0", VA = "0x180BE88E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public NFHJOHAGGAM GKGCLCALKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA48560", Offset = "0xA47760", VA = "0x180A48560", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA483C0", Offset = "0xA475C0", VA = "0x180A483C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public ICHOMMDGIHO GEBMAMBKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8F7860", Offset = "0x8F6A60", VA = "0x1808F7860", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8F7810", Offset = "0x8F6A10", VA = "0x1808F7810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public MEIJBJKHKBG HPGGEIFPJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA03FA0", Offset = "0xA031A0", VA = "0x180A03FA0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA39B30", Offset = "0xA38D30", VA = "0x180A39B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public OLDBABLMPPE BJPMMLIELJA
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x995AF0", Offset = "0x994CF0", VA = "0x180995AF0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1C0", Offset = "0xA4A3C0", VA = "0x180A4B1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public EEMHNKCNKKG KMPOEKLCMGN
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x963CF0", Offset = "0x962EF0", VA = "0x180963CF0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA4B8E0", Offset = "0xA4AAE0", VA = "0x180A4B8E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public DFEKIFGBEDE JOCHEHGGIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA3A2E0", Offset = "0xA394E0", VA = "0x180A3A2E0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA39B10", Offset = "0xA38D10", VA = "0x180A39B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public PEHGBBAEFBK NJIOONOPDKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA3A3D0", Offset = "0xA395D0", VA = "0x180A3A3D0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA448A0", Offset = "0xA43AA0", VA = "0x180A448A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public NKJCPJBKINC HDDGBEFLCBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA3A2F0", Offset = "0xA394F0", VA = "0x180A3A2F0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA398A0", Offset = "0xA38AA0", VA = "0x180A398A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public GEKEAHMAJJI EIKOMCMNEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xBCC9F0", Offset = "0xBCBBF0", VA = "0x180BCC9F0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xBCD650", Offset = "0xBCC850", VA = "0x180BCD650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public POLHFFJEJFN BPOBBBJPLOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA03FE0", Offset = "0xA031E0", VA = "0x180A03FE0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA02080", Offset = "0xA01280", VA = "0x180A02080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public EMBLJOOMEMF CNPNLJKLOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x995C30", Offset = "0x994E30", VA = "0x180995C30", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x993AA0", Offset = "0x992CA0", VA = "0x180993AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public DFAEOHGPHNA FNAIKEEBPOP
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x963E00", Offset = "0x963000", VA = "0x180963E00", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public DMOINKDAIOD KPNEIPANLLD
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x997930", Offset = "0x996B30", VA = "0x180997930", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public IMIOHGLICFJ FKMPAFCJILL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x966400", Offset = "0x965600", VA = "0x180966400", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public NHKBIEIPOHH IBFCHAJFPHL
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9615E0", Offset = "0x9607E0", VA = "0x1809615E0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CCGAMJLHGEA JOEDAFEJFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x960D50", Offset = "0x95FF50", VA = "0x180960D50", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public MBLMBODNJJG LCFINPJPKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x954140", Offset = "0x953340", VA = "0x180954140", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x11E2F30", Offset = "0x11E2130", VA = "0x1811E2F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private bool JHAONFHLFAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x795F310", Offset = "0x795E510", VA = "0x18795F310", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private bool EPIBNOLFJOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x795EEB0", Offset = "0x795E0B0", VA = "0x18795EEB0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private bool OPGCJBKGALN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x1168880", Offset = "0x1167A80", VA = "0x181168880", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private CancellationToken LPAHPKDDPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x795F0D0", Offset = "0x795E2D0", VA = "0x18795F0D0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private JBPONICDCIO DKFBPFNAFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private bool MBLKFHFGDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1168880", Offset = "0x1167A80", VA = "0x181168880", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x11610D0", Offset = "0x11602D0", VA = "0x1811610D0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action OFJIAJNABHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x795F5E0", Offset = "0x795E7E0", VA = "0x18795F5E0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x795EC20", Offset = "0x795DE20", VA = "0x18795EC20", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event HFJCDCCNFNJ EMAGOCKLNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x795ED30", Offset = "0x795DF30", VA = "0x18795ED30", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x795EE50", Offset = "0x795E050", VA = "0x18795EE50", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event HFJCDCCNFNJ MFHBLNJNHCC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x795EDF0", Offset = "0x795DFF0", VA = "0x18795EDF0", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x795F6A0", Offset = "0x795E8A0", VA = "0x18795F6A0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event HFJCDCCNFNJ LKOGBJGDGJP
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x795ED90", Offset = "0x795DF90", VA = "0x18795ED90", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x795ECD0", Offset = "0x795DED0", VA = "0x18795ECD0", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<NGLFBMMEGBN, bool> PJNPCKIPODO
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x795F460", Offset = "0x795E660", VA = "0x18795F460", Slot = "48")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x795F640", Offset = "0x795E840", VA = "0x18795F640", Slot = "49")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x11E2F30", Offset = "0x11E2130", VA = "0x1811E2F30", Slot = "39")]
	public void FGMHPHEGPGP(MBLMBODNJJG HMOFPPMJJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x795F700", Offset = "0x795E900", VA = "0x18795F700")]
	[UnityEngine.Scripting.Preserve]
	internal MMIANIDPMDE([FMJHJHHALCB(null)] JBPONICDCIO CKNPDKKKGFM, [FMJHJHHALCB(null)] JMCGIMEIOCB IBMNPFDADDO, [FMJHJHHALCB(null)] NCGHKHMPIGG BFOPFCHDMBE, [FMJHJHHALCB(null)] LMIBFAPANNF CKNLAJJPLCN, [FMJHJHHALCB(null)] EMIODIFKEJC JOLGEKOOIJC, [FMJHJHHALCB(null)] NNGIBCDKGLA IKOABIOLLGC, [FMJHJHHALCB(null)] KFOMELNKPNH BNJCBFNOIOC, [FMJHJHHALCB(null)] EMHDMPCCNCO CIBHCCPALDN, [FMJHJHHALCB(null)] HNOBBEEKOHL BKBFMJKKCMD, [FMJHJHHALCB(null)] FBLEPDEEPND GNEMIBBHMID, [FMJHJHHALCB(null)] BMNEILKOCPL LAMNNDKOJIM, [FMJHJHHALCB(null)] PJMBDGNBAGG BJNMGJGPPEN, [FMJHJHHALCB(null)] HKBIGFOCBKM CEFAFOIADBM, [FMJHJHHALCB(null)] ADECPFBBALC EBKMFADACPH, [FMJHJHHALCB(null)] HKDOMLGFBDK PCFCEJFBJKA, [FMJHJHHALCB(null)] OANEACPOBBM DKBDOPGHMOG, [FMJHJHHALCB(null)] KBACNKACNHI ONCEFEJCKDG, [FMJHJHHALCB(null)] NFHJOHAGGAM LMEMKKNMKJP, [FMJHJHHALCB(null)] ICHOMMDGIHO CFMLBBEINFG, [FMJHJHHALCB(null)] MEIJBJKHKBG PIIMFOEGMOP, [FMJHJHHALCB(null)] EEMHNKCNKKG JPMACELBNGL, [FMJHJHHALCB(null)] OLDBABLMPPE EFNLDCMHCAJ, [FMJHJHHALCB(null)] DFEKIFGBEDE MJDFIKDOKFO, [FMJHJHHALCB(null)] PEHGBBAEFBK EENIAMKEFAN, [FMJHJHHALCB(null)] NKJCPJBKINC KBHDBLLMDPP, [FMJHJHHALCB(null)] POLHFFJEJFN LFKGAGFDDEM, [FMJHJHHALCB(null)] EMBLJOOMEMF BLBMLALAFDG, [FMJHJHHALCB(null)] DFAEOHGPHNA GFEIBGHEAFH, [FMJHJHHALCB(null)] DMOINKDAIOD BPOHFIDEMLG, [FMJHJHHALCB(null)] IMIOHGLICFJ HKBEPGHODHM, [FMJHJHHALCB(null)] NHKBIEIPOHH NPPPAKEHEAC, [FMJHJHHALCB(null)] CCGAMJLHGEA DAFANNJIAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x795F0F0", Offset = "0x795E2F0", VA = "0x18795F0F0")]
	private void GGPOBANFNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x795EF30", Offset = "0x795E130", VA = "0x18795EF30", Slot = "59")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x795EC80", Offset = "0x795DE80", VA = "0x18795EC80", Slot = "53")]
	private void BPJGHBPOOBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x795F4C0", Offset = "0x795E6C0", VA = "0x18795F4C0", Slot = "54")]
	private GEFCICAJODG MNJDBFMOGKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x795F550", Offset = "0x795E750", VA = "0x18795F550", Slot = "55")]
	private NCOGPGAMNCK NFOBDIAAJHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x795F1A0", Offset = "0x795E3A0", VA = "0x18795F1A0", Slot = "56")]
	[AsyncStateMachine(typeof(LEODAFLHHHB))]
	private Task<JIDFLMCDEBP> GHAOFLCNFIM(AOCJALDHGHI DOKPKCJJFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x795F370", Offset = "0x795E570", VA = "0x18795F370", Slot = "57")]
	[AsyncStateMachine(typeof(CHFGGDEGGEM))]
	private Task IJDHKMBIIAL(CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x795EBA0", Offset = "0x795DDA0", VA = "0x18795EBA0")]
	[IteratorStateMachine(typeof(MGHPIKOPNEF))]
	private IEnumerable<LOPMFDCLLIO> AIAGPNLPDEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x795F2B0", Offset = "0x795E4B0", VA = "0x18795F2B0")]
	[CompilerGenerated]
	private void GHMBNPOONIF(LOPMFDCLLIO DMLGABHGKII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class AOOKCEHECOJ : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1559360", Offset = "0x1558560", VA = "0x181559360")]
	public AOOKCEHECOJ(string CBCJFCINKPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class CMKCKNDMILL : PCNKCONDEHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct KKLDIPAHBBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public CMKCKNDMILL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7958310", Offset = "0x7957510", VA = "0x187958310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7958650", Offset = "0x7957850", VA = "0x187958650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly NDEJMCPCCDJ CNCOIDECOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly LMIBFAPANNF CKNLAJJPLCN;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8FD3B0", Offset = "0x8FC5B0", VA = "0x1808FD3B0")]
	public CMKCKNDMILL(NDEJMCPCCDJ CNCOIDECOMJ, LMIBFAPANNF CKNLAJJPLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x79497E0", Offset = "0x79489E0", VA = "0x1879497E0", Slot = "4")]
	[AsyncStateMachine(typeof(KKLDIPAHBBC))]
	public Task<bool> CEFDJNLIIDG(CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x79498D0", Offset = "0x7948AD0", VA = "0x1879498D0")]
	[CompilerGenerated]
	private object MNOCBGAFINM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class IOKPFOGNCMG : PCNKCONDEHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct KBHOOIGOPLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public IOKPFOGNCMG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x79576E0", Offset = "0x79568E0", VA = "0x1879576E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7957E20", Offset = "0x7957020", VA = "0x187957E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly NDEJMCPCCDJ CNCOIDECOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly LMIBFAPANNF CKNLAJJPLCN;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private AOMKKEDLMKB INFDKHDKCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7956040", Offset = "0x7955240", VA = "0x187956040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x8FD3B0", Offset = "0x8FC5B0", VA = "0x1808FD3B0")]
	public IOKPFOGNCMG(NDEJMCPCCDJ CNCOIDECOMJ, LMIBFAPANNF CKNLAJJPLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7955F10", Offset = "0x7955110", VA = "0x187955F10", Slot = "4")]
	[AsyncStateMachine(typeof(KBHOOIGOPLJ))]
	public Task<bool> CEFDJNLIIDG(CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7956090", Offset = "0x7955290", VA = "0x187956090")]
	[CompilerGenerated]
	private object MBCGNMAAGAP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class PEJEFCKLNFB : PCNKCONDEHC
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class ENBFBCOCIDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public PEJEFCKLNFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public MFJPKPONFIJ result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public KHDFIKJLGJL newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public ENBFBCOCIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x794BCB0", Offset = "0x794AEB0", VA = "0x18794BCB0")]
		internal object BELOKGIBAKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x794BE40", Offset = "0x794B040", VA = "0x18794BE40")]
		internal object PMFDFDJCDAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x794BDA0", Offset = "0x794AFA0", VA = "0x18794BDA0")]
		internal object MDHBLKOFPIF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct DIPAFFMEEFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public PEJEFCKLNFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private ENBFBCOCIDO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<MFJPKPONFIJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x794A700", Offset = "0x7949900", VA = "0x18794A700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x794B0B0", Offset = "0x794A2B0", VA = "0x18794B0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly NDEJMCPCCDJ CNCOIDECOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly LMIBFAPANNF CKNLAJJPLCN;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private AOMKKEDLMKB INFDKHDKCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7960F60", Offset = "0x7960160", VA = "0x187960F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8FD3B0", Offset = "0x8FC5B0", VA = "0x1808FD3B0")]
	public PEJEFCKLNFB(NDEJMCPCCDJ CNCOIDECOMJ, LMIBFAPANNF CKNLAJJPLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7960E40", Offset = "0x7960040", VA = "0x187960E40", Slot = "4")]
	[AsyncStateMachine(typeof(DIPAFFMEEFC))]
	public Task<bool> CEFDJNLIIDG(CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal interface PCNKCONDEHC
{
	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> CEFDJNLIIDG(CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct BHDECEHOADO
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class ENPBCKMFKAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public NDEJMCPCCDJ manager;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public ENPBCKMFKAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x794BEB0", Offset = "0x794B0B0", VA = "0x18794BEB0")]
		internal Task JEKJCGAKKKI(CancellationToken cancellationToken, int roomTotalVersion, HEOHLAMPJMC localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct DCNDLNLJKKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public BHDECEHOADO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private AOCJALDHGHI <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<PCLPOBEDIDB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private TaskAwaiter<JIDFLMCDEBP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x794A100", Offset = "0x7949300", VA = "0x18794A100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x794A690", Offset = "0x7949890", VA = "0x18794A690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct GOKHCGAEKOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public BHDECEHOADO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7953BA0", Offset = "0x7952DA0", VA = "0x187953BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7953EC0", Offset = "0x79530C0", VA = "0x187953EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly CancellationToken BGEKICMONBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly NDEJMCPCCDJ ODPBGAGOMOC;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private JMCGIMEIOCB CAFANJMHLBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7948C00", Offset = "0x7947E00", VA = "0x187948C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private LMIBFAPANNF FFGEEHIBEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7949060", Offset = "0x7948260", VA = "0x187949060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private AOMKKEDLMKB INFDKHDKCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7948FE0", Offset = "0x79481E0", VA = "0x187948FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private FBLEPDEEPND HEGKHLGHJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7948C50", Offset = "0x7947E50", VA = "0x187948C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2523320", Offset = "0x2522520", VA = "0x182523320")]
	public BHDECEHOADO(CancellationToken BGEKICMONBE, NDEJMCPCCDJ ODPBGAGOMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7948B50", Offset = "0x7947D50", VA = "0x187948B50")]
	public static EODFAJAJAHG COCPKDIPANI(NDEJMCPCCDJ ODPBGAGOMOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7948A40", Offset = "0x7947C40", VA = "0x187948A40")]
	[AsyncStateMachine(typeof(DCNDLNLJKKP))]
	public Task<bool> BOIJOOGLJMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x7948DD0", Offset = "0x7947FD0", VA = "0x187948DD0")]
	private bool KAPHEOBNIKG([Out] AOCJALDHGHI DOKPKCJJFPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7948970", Offset = "0x7947B70", VA = "0x187948970")]
	[AsyncStateMachine(typeof(GOKHCGAEKOD))]
	private Task BLKIBIEHEBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7948CA0", Offset = "0x7947EA0", VA = "0x187948CA0")]
	private Task<PCLPOBEDIDB> GLBPPFLKCFC(AOCJALDHGHI PNGGFCJHMGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct NBFMEBKJMKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly HKDOMLGFBDK PCFCEJFBJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Guid DHNJGGKJENC;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Task<(JIDFLMCDEBP, Task)> DFALAIBHBCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x795FC50", Offset = "0x795EE50", VA = "0x18795FC50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x49CA720", Offset = "0x49C9920", VA = "0x1849CA720")]
	public NBFMEBKJMKP(HKDOMLGFBDK PCFCEJFBJKA, Guid DHNJGGKJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x795FD20", Offset = "0x795EF20", VA = "0x18795FD20")]
	public TaskAwaiter<(JIDFLMCDEBP, Task)> LGLANLJPMBI()
	{
		return default(TaskAwaiter<(JIDFLMCDEBP, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x795FB80", Offset = "0x795ED80", VA = "0x18795FB80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct EDKFNECIGGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly TaskCompletionSource<(JIDFLMCDEBP, Task)> GFJDNBKKNHM;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public Task<(JIDFLMCDEBP, Task)> DFALAIBHBCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x794B780", Offset = "0x794A980", VA = "0x18794B780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x794B8F0", Offset = "0x794AAF0", VA = "0x18794B8F0")]
	public EDKFNECIGGG(TimeSpan HLAGGOKJDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x794B850", Offset = "0x794AA50", VA = "0x18794B850")]
	public void MOOEDLEBBFH(Task LBPFHJHACNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x794B6F0", Offset = "0x794A8F0", VA = "0x18794B6F0")]
	public void CKNFCDICMPE(JIDFLMCDEBP JFBEBFDNAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x794B6A0", Offset = "0x794A8A0", VA = "0x18794B6A0")]
	public void ADLGKLMJJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x794B7C0", Offset = "0x794A9C0", VA = "0x18794B7C0")]
	internal void LKJBPGBBEME(string CBCJFCINKPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class JFJGENEPDOB
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class APBJNJEDDAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public GLPOHAHMIGG subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public APBJNJEDDAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x79479C0", Offset = "0x7946BC0", VA = "0x1879479C0")]
		internal bool FIPBJOGDLOF(CNMPJHKKKIM s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7956B80", Offset = "0x7955D80", VA = "0x187956B80")]
	public static FENMDJFMHBI LHPCDDMHIBB(long EIJMKMECPMP, long GHKEIJKOONC, string PANOEKHIIKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7956C10", Offset = "0x7955E10", VA = "0x187956C10")]
	public static FENMDJFMHBI LHPCDDMHIBB(long EIJMKMECPMP, long GHKEIJKOONC, GLPHDJDILNO JBBABNEKIMJ, long POOMNAEPOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7956CD0", Offset = "0x7955ED0", VA = "0x187956CD0")]
	public static FENMDJFMHBI LHPCDDMHIBB(NMGIKLONOMM CDAOMFCCHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7956E60", Offset = "0x7956060", VA = "0x187956E60")]
	public static FENMDJFMHBI LHPCDDMHIBB(OAOBEPBAJLE GMCJJKGGMIE, GLPOHAHMIGG GAIEBHHFJMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7956A90", Offset = "0x7955C90", VA = "0x187956A90")]
	public static FENMDJFMHBI JIJJDADBDHA(this FENMDJFMHBI OCPJHHIMKFB, OAOBEPBAJLE KCBNCOIFFIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7956900", Offset = "0x7955B00", VA = "0x187956900")]
	public static FENMDJFMHBI FDFJGEGPFHO(this FENMDJFMHBI OCPJHHIMKFB, GLPOHAHMIGG LAOHOPKPOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RecRoom.NoEngine.Common.Preserve]
internal class KIGGGOOOCDD : HNOBBEEKOHL, LOPMFDCLLIO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct DBCGCAJIHMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public KIGGGOOOCDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7949A00", Offset = "0x7948C00", VA = "0x187949A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x794A0A0", Offset = "0x79492A0", VA = "0x18794A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly IGCCAEFBMNB BPAEPIDDNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private string PAJKLKJAPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Task AEHDBDBECHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private NDEJMCPCCDJ CNCOIDECOMJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool IBCLOOJFNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x79580F0", Offset = "0x79572F0", VA = "0x1879580F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Task EKNIIAFOABB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7957F40", Offset = "0x7957140", VA = "0x187957F40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8F85C0", Offset = "0x8F77C0", VA = "0x1808F85C0", Slot = "7")]
	public void GGPOBANFNOP(NDEJMCPCCDJ CNCOIDECOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7958120", Offset = "0x7957320", VA = "0x187958120", Slot = "6")]
	public void KAGIIGFAPFL(Task JPPEAAIELKB, string JIGEOFILHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7957FD0", Offset = "0x79571D0", VA = "0x187957FD0")]
	[AsyncStateMachine(typeof(DBCGCAJIHMJ))]
	private Task DFGGLLLIHNO(Task EDCCDJHLGOJ, string JIGEOFILHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7958280", Offset = "0x7957480", VA = "0x187958280")]
	public KIGGGOOOCDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class BIBFJBNPFIN : GEKEAHMAJJI, LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool LFODHLCHFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private FAOLIJLBMLP MAADACILEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private JMCGIMEIOCB IBMNPFDADDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private POLHFFJEJFN LFKGAGFDDEM;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public FAOLIJLBMLP BFDIHMPBAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x79494E0", Offset = "0x79486E0", VA = "0x1879494E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7949360", Offset = "0x7948560", VA = "0x187949360", Slot = "7")]
	public void GGPOBANFNOP(NDEJMCPCCDJ CNCOIDECOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x79490B0", Offset = "0x79482B0", VA = "0x1879490B0", Slot = "5")]
	public void AAKGNKEABKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7949320", Offset = "0x7948520", VA = "0x187949320", Slot = "6")]
	public void MKNDKLLIFCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7949260", Offset = "0x7948460", VA = "0x187949260")]
	private Task AKHLNJPCKOF(MGHBOLDNAIG PIEFIBOFCOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7949320", Offset = "0x7948520", VA = "0x187949320", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public BIBFJBNPFIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class HOKPFAKBBEO : POLHFFJEJFN
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class IFAONAMPNIH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly AFJINEAEPKI APAGJACOOAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly string OFPBICPHALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly T JEBHMGJFPIP;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public T ELOFPHHKCIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xB24780", Offset = "0xB23980", VA = "0x180B24780")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xB24BA0", Offset = "0xB23DA0", VA = "0x180B24BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x45B4270", Offset = "0x45B3470", VA = "0x1845B4270")]
		public IFAONAMPNIH(AFJINEAEPKI APAGJACOOAN, string OFPBICPHALF, T JEBHMGJFPIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x45B3BC0", Offset = "0x45B2DC0", VA = "0x1845B3BC0")]
		private void KEPMKEJEGPM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly AFJINEAEPKI APAGJACOOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly IFAONAMPNIH<TimeSpan> FDABGJKHAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly IFAONAMPNIH<TimeSpan> GJMLGDHMNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly IFAONAMPNIH<TimeSpan> DIJLFFKMPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly IFAONAMPNIH<TimeSpan> MPPHBIBFDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly IFAONAMPNIH<bool> EGEKHJFNCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly IFAONAMPNIH<bool> ENBMJGEHFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly IFAONAMPNIH<bool> GPFBACOHPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly IFAONAMPNIH<int> HAHPLAHGILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly IFAONAMPNIH<bool> KJOODIHINBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly IFAONAMPNIH<bool> POLJNFPOAMB;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public TimeSpan BMBDIEKOCOM
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7954AD0", Offset = "0x7953CD0", VA = "0x187954AD0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public TimeSpan FIJIAINLLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7954B10", Offset = "0x7953D10", VA = "0x187954B10", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public TimeSpan MCAIPEJHDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7954B90", Offset = "0x7953D90", VA = "0x187954B90", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public TimeSpan OKMJIGAJNML
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7954A90", Offset = "0x7953C90", VA = "0x187954A90", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool FIJFPILOLGL
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7954A50", Offset = "0x7953C50", VA = "0x187954A50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool EOELLEKPEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x79549D0", Offset = "0x7953BD0", VA = "0x1879549D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool MPIENFHLEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7954A10", Offset = "0x7953C10", VA = "0x187954A10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public int KHONHGAMAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7954B50", Offset = "0x7953D50", VA = "0x187954B50", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool KNCFNNDNMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7954990", Offset = "0x7953B90", VA = "0x187954990", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool HOIIEDDAHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7954BD0", Offset = "0x7953DD0", VA = "0x187954BD0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7954C10", Offset = "0x7953E10", VA = "0x187954C10")]
	[UnityEngine.Scripting.Preserve]
	public HOKPFAKBBEO([FMJHJHHALCB(null)] AFJINEAEPKI APAGJACOOAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[UnityEngine.Scripting.Preserve]
internal class OBDOKDNMGGB : BMNEILKOCPL, LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class BANPFOMDNMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public IAFPHBAAAOE roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BANPFOMDNMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x79479F0", Offset = "0x7946BF0", VA = "0x1879479F0")]
		internal object CEOGBDEAHLJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action JHGLONFKKKL
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7960160", Offset = "0x795F360", VA = "0x187960160", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7960230", Offset = "0x795F430", VA = "0x187960230", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event HFJCDCCNFNJ EHFLKMGDECE
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7960AF0", Offset = "0x795FCF0", VA = "0x187960AF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x79606D0", Offset = "0x795F8D0", VA = "0x1879606D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event HFJCDCCNFNJ KFFNNLCCIMM
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x79602D0", Offset = "0x795F4D0", VA = "0x1879602D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7960A50", Offset = "0x795FC50", VA = "0x187960A50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event HFJCDCCNFNJ CFBHGKOECOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7960630", Offset = "0x795F830", VA = "0x187960630", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7960370", Offset = "0x795F570", VA = "0x187960370", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<NGLFBMMEGBN, bool> MJBCEIDDNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7960B90", Offset = "0x795FD90", VA = "0x187960B90", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7960970", Offset = "0x795FB70", VA = "0x187960970", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "19")]
	public void GGPOBANFNOP(NDEJMCPCCDJ CNCOIDECOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7960770", Offset = "0x795F970", VA = "0x187960770", Slot = "14")]
	public void JEPNKBJPIHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7960200", Offset = "0x795F400", VA = "0x187960200", Slot = "15")]
	public void AENBJDDOBMP(IAFPHBAAAOE ABMEFKHBMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7960A20", Offset = "0x795FC20", VA = "0x187960A20", Slot = "16")]
	public void LEEJKHDLENF(IAFPHBAAAOE ABMEFKHBMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x7960130", Offset = "0x795F330", VA = "0x187960130", Slot = "17")]
	public void AABFGMKFBEC(IAFPHBAAAOE ABMEFKHBMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7960410", Offset = "0x795F610", VA = "0x187960410", Slot = "18")]
	public void GPDHODAOHPD(NGLFBMMEGBN MFHJGCFBFIG, bool GMKDNLPGIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7960460", Offset = "0x795F660", VA = "0x187960460")]
	private void HJOIGAOEAFJ(HFJCDCCNFNJ IOFAMKNLLAN, IAFPHBAAAOE ABMEFKHBMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public OBDOKDNMGGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[UnityEngine.Scripting.Preserve]
internal class ADLMKBNAFEI : PJMBDGNBAGG, LOPMFDCLLIO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct JIAFGKLDNAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public ADLMKBNAFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7957090", Offset = "0x7956290", VA = "0x187957090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7957610", Offset = "0x7956810", VA = "0x187957610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct GMABJMIDMOL : IAsyncStateMachine
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
		public ADLMKBNAFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7953220", Offset = "0x7952420", VA = "0x187953220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x79538C0", Offset = "0x7952AC0", VA = "0x1879538C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class AFEIHLJENNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public AFEIHLJENNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7946D10", Offset = "0x7945F10", VA = "0x187946D10")]
		internal object KONAPNBMEKL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct MCCPBMGCNAN : IAsyncStateMachine
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
		public ADLMKBNAFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private AFEIHLJENNC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7959F80", Offset = "0x7959180", VA = "0x187959F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x795A6D0", Offset = "0x79598D0", VA = "0x18795A6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class NJDEJJHKNGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public NJDEJJHKNGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7960040", Offset = "0x795F240", VA = "0x187960040")]
		internal object HLAJGJPJHMJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NDEJMCPCCDJ CNCOIDECOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private LMIBFAPANNF CKNLAJJPLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private PCNKCONDEHC[] NCELEOLIGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private CancellationTokenSource BCFACPBIPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int LOJLBNIOJMF;

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x79463E0", Offset = "0x79455E0", VA = "0x1879463E0", Slot = "6")]
	public void GGPOBANFNOP(NDEJMCPCCDJ CNCOIDECOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x79463D0", Offset = "0x79455D0", VA = "0x1879463D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x79460C0", Offset = "0x79452C0", VA = "0x1879460C0", Slot = "8")]
	public void BCMBOJBHPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7946770", Offset = "0x7945970", VA = "0x187946770", Slot = "5")]
	public void KGFKFCNLMHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x7946940", Offset = "0x7945B40", VA = "0x187946940", Slot = "4")]
	[AsyncStateMachine(typeof(JIAFGKLDNAL))]
	public Task OEGJBOMNHJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x7946460", Offset = "0x7945660", VA = "0x187946460")]
	private void HECHDLPMCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x7946840", Offset = "0x7945A40", VA = "0x187946840")]
	[AsyncStateMachine(typeof(GMABJMIDMOL))]
	private Task MNLMMONHFGJ(CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x7946A10", Offset = "0x7945C10", VA = "0x187946A10")]
	[AsyncStateMachine(typeof(MCCPBMGCNAN))]
	private Task<bool> OHELPDAHONK(int CPLNODNGKGB, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7945FE0", Offset = "0x79451E0", VA = "0x187945FE0")]
	private void AONMMKGOCCK(int CPLNODNGKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x79462F0", Offset = "0x79454F0", VA = "0x1879462F0")]
	private void CAEBJOBACII(int CPLNODNGKGB, bool GMKDNLPGIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x79461C0", Offset = "0x79453C0", VA = "0x1879461C0")]
	private void BLMGKHINNED(int CPLNODNGKGB, Exception ANJHEGDKNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7946B50", Offset = "0x7945D50", VA = "0x187946B50")]
	private void PENNBFDPBAA(CancellationToken BGEKICMONBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public ADLMKBNAFEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[RecRoom.NoEngine.Common.Preserve]
internal class MHFPCAKMDKA : HKBIGFOCBKM, LOPMFDCLLIO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct GEABALGHDAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public KHDFIKJLGJL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public MHFPCAKMDKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public MBLMBODNJJG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x79519E0", Offset = "0x7950BE0", VA = "0x1879519E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7952350", Offset = "0x7951550", VA = "0x187952350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct GJAGOCEBFLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public MHFPCAKMDKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public KHDFIKJLGJL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public MBLMBODNJJG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private EKKGOIIBGNN<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private OODALMMDODD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private DAIEOJJKKMF <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private GLICPABNLKJ <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x79523B0", Offset = "0x79515B0", VA = "0x1879523B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7953060", Offset = "0x7952260", VA = "0x187953060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class KEIJPICHDDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Matchmaking.CELPPMMKMFO result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public HGDHJHLLJGP errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public KEIJPICHDDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7957E90", Offset = "0x7957090", VA = "0x187957E90")]
		internal object GBHKHAALHJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class DHIADCCKKHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public Task<FENMDJFMHBI> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public DHIADCCKKHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		internal Task<FENMDJFMHBI> HGJPAJEBDDA(EKKGOIIBGNN<string>.KJLMKGNBAOG _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct FHBOKDBDGDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public MHFPCAKMDKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public KHDFIKJLGJL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public MBLMBODNJJG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public DAIEOJJKKMF joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private DHIADCCKKHP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private IMPDAEGGLLG <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private OODALMMDODD <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private OCHAGJHGHGK <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private Task<Matchmaking.HCNCMJKKAAM> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private KJMDLICJGGB <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.HCNCMJKKAAM> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter<FENMDJFMHBI> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x794BFF0", Offset = "0x794B1F0", VA = "0x18794BFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7951980", Offset = "0x7950B80", VA = "0x187951980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct IMPBNAJBHCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public MHFPCAKMDKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <disconnectTimerScope>5__3;

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
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x79550F0", Offset = "0x79542F0", VA = "0x1879550F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7955B60", Offset = "0x7954D60", VA = "0x187955B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct AOPBGJOIIKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public MHFPCAKMDKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private JBPONICDCIO <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x79474E0", Offset = "0x79466E0", VA = "0x1879474E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7947960", Offset = "0x7946B60", VA = "0x187947960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct EDFNNOFPFLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public AsyncTaskMethodBuilder<Matchmaking.HCNCMJKKAAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public KHDFIKJLGJL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public MHFPCAKMDKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter<Matchmaking.HCNCMJKKAAM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x794B120", Offset = "0x794A320", VA = "0x18794B120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x794B630", Offset = "0x794A830", VA = "0x18794B630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct AGAFDMBALEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Matchmaking.HCNCMJKKAAM serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public MHFPCAKMDKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public DAIEOJJKKMF joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TaskAwaiter<ACAKEBKDGNK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7946D80", Offset = "0x7945F80", VA = "0x187946D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7947480", Offset = "0x7946680", VA = "0x187947480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class OJBFMEELDPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public KHDFIKJLGJL targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public OJBFMEELDPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7960C40", Offset = "0x795FE40", VA = "0x187960C40")]
		internal object GPOPMLENAAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7960D40", Offset = "0x795FF40", VA = "0x187960D40")]
		internal string ONEJFKHLCAI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct PLGFJGMILDL : IAsyncStateMachine
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
		public KHDFIKJLGJL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public MHFPCAKMDKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private OJBFMEELDPM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private OODALMMDODD <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x7960FB0", Offset = "0x79601B0", VA = "0x187960FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7961B90", Offset = "0x7960D90", VA = "0x187961B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct PLOGFBEBDCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public MHFPCAKMDKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public DAIEOJJKKMF joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public FENMDJFMHBI initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public KHDFIKJLGJL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public IMPDAEGGLLG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7961BF0", Offset = "0x7960DF0", VA = "0x187961BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7962510", Offset = "0x7961710", VA = "0x187962510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct PNDOOIIKHLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public MHFPCAKMDKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private OODALMMDODD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap3;

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
		private OODALMMDODD <>7__wrap5;

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
		[Cpp2IlInjected.Address(RVA = "0x7962570", Offset = "0x7961770", VA = "0x187962570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7963D50", Offset = "0x7962F50", VA = "0x187963D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct KLGENOEHJLK : IAsyncStateMachine
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
		public HEOHLAMPJMC localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public MHFPCAKMDKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private TaskAwaiter<JIDFLMCDEBP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x79586C0", Offset = "0x79578C0", VA = "0x1879586C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7958E30", Offset = "0x7958030", VA = "0x187958E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class EPAEEIDPNDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public KHDFIKJLGJL targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public EPAEEIDPNDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7970670", Offset = "0x796F870", VA = "0x187970670")]
		internal object AINLGIJIODB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class KFBNFMHKFHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public KFBNFMHKFHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7975480", Offset = "0x7974680", VA = "0x187975480")]
		internal void GGJFBKBILAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class IBDFAPDFICH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public KHDFIKJLGJL targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public IBDFAPDFICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7974BF0", Offset = "0x7973DF0", VA = "0x187974BF0")]
		internal object NJDIHBFAEGP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class GMGNOLFDHED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public KHDFIKJLGJL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public GMGNOLFDHED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7972A60", Offset = "0x7971C60", VA = "0x187972A60")]
		internal string MFPDFLJNOGL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly KJMCEDJMPPA OPPHLEKBMMB;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly KJMCEDJMPPA PAIHHNDGDOA;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly KJMCEDJMPPA GPJJPKGJMPH;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string OJHNGOLADDE;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly string HGFEHLIOGKO;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly string DIOOIEIAKEN;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly Guid EJEIBONLPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private EMHDMPCCNCO CIBHCCPALDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private NCGHKHMPIGG BFOPFCHDMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private JMCGIMEIOCB IBMNPFDADDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private NDEJMCPCCDJ CNCOIDECOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private LMIBFAPANNF CKNLAJJPLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private PJMBDGNBAGG BJNMGJGPPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private HNOBBEEKOHL BKBFMJKKCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private BMNEILKOCPL LAMNNDKOJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private IMIOHGLICFJ HKBEPGHODHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private DMOINKDAIOD BPOHFIDEMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private IDisposable NPELOHOANDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private CCGAMJLHGEA DAFANNJIAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly IGCCAEFBMNB DLDHGHNJPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private KJMDLICJGGB DOOBIJKHDIP;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public TaskStatus IILKPEHBEBL
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x91AA20", Offset = "0x919C20", VA = "0x18091AA20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x1102FF0", Offset = "0x11021F0", VA = "0x181102FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private AOMKKEDLMKB INFDKHDKCOG
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x795D340", Offset = "0x795C540", VA = "0x18795D340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x795C430", Offset = "0x795B630", VA = "0x18795C430", Slot = "6")]
	public void GGPOBANFNOP(NDEJMCPCCDJ CNCOIDECOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x795B8B0", Offset = "0x795AAB0", VA = "0x18795B8B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x795D4A0", Offset = "0x795C6A0", VA = "0x18795D4A0", Slot = "5")]
	[AsyncStateMachine(typeof(GEABALGHDAN))]
	public Task MFJKKIEDLEF(KHDFIKJLGJL MFJJKMPPMDO, MBLMBODNJJG CDPHCJLDAGN, CancellationToken LHPAGMJCDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x795E270", Offset = "0x795D470", VA = "0x18795E270")]
	[AsyncStateMachine(typeof(GJAGOCEBFLD))]
	private Task POOFCCHNNKJ(KHDFIKJLGJL MFJJKMPPMDO, MBLMBODNJJG CDPHCJLDAGN, CancellationToken LHPAGMJCDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x795BA20", Offset = "0x795AC20", VA = "0x18795BA20")]
	private void EMFLPAGLHME(IMIOHGLICFJ HKBEPGHODHM, KHDFIKJLGJL MFJJKMPPMDO, Exception ANJHEGDKNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x795D9B0", Offset = "0x795CBB0", VA = "0x18795D9B0")]
	private static void NPKAOEKPGDK(GLICPABNLKJ OPGLLDLNJGH, Exception ANJHEGDKNFP, [Optional] List<int> DIGHMAEAEHJ, int LOJLBNIOJMF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x795B2D0", Offset = "0x795A4D0", VA = "0x18795B2D0")]
	[AsyncStateMachine(typeof(FHBOKDBDGDO))]
	private Task CFLPGONAFAC(EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, KHDFIKJLGJL MFJJKMPPMDO, MBLMBODNJJG CDPHCJLDAGN, DAIEOJJKKMF MIHEKIAPICK, CancellationToken LHPAGMJCDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x795D760", Offset = "0x795C960", VA = "0x18795D760")]
	private void NADHHHFEJGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x795AD50", Offset = "0x7959F50", VA = "0x18795AD50")]
	[AsyncStateMachine(typeof(IMPBNAJBHCL))]
	private Task AFLONLMLGHA(EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x795BFC0", Offset = "0x795B1C0", VA = "0x18795BFC0")]
	private void FPJKOCCKIKL(KHDFIKJLGJL MFJJKMPPMDO, CancellationToken LHPAGMJCDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x795D0F0", Offset = "0x795C2F0", VA = "0x18795D0F0")]
	private void JCFENCLGIHB(KHDFIKJLGJL MFJJKMPPMDO, DAIEOJJKKMF MIHEKIAPICK, OperationCanceledException NLICOKFPLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x795CC00", Offset = "0x795BE00", VA = "0x18795CC00")]
	private void HKEEKFLBKOK(KHDFIKJLGJL MFJJKMPPMDO, DAIEOJJKKMF MIHEKIAPICK, Exception ANJHEGDKNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x795B570", Offset = "0x795A770", VA = "0x18795B570")]
	private void DCCFECHBAHO(KHDFIKJLGJL MFJJKMPPMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x795BF60", Offset = "0x795B160", VA = "0x18795BF60")]
	private static IAFPHBAAAOE FKANIKBABDF(KHDFIKJLGJL MFJJKMPPMDO)
	{
		return default(IAFPHBAAAOE);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x795BE90", Offset = "0x795B090", VA = "0x18795BE90")]
	[AsyncStateMachine(typeof(AOPBGJOIIKB))]
	private Task FDHHBACBKAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x795ABF0", Offset = "0x7959DF0", VA = "0x18795ABF0")]
	[AsyncStateMachine(typeof(EDFNNOFPFLM))]
	private Task<Matchmaking.HCNCMJKKAAM> AALFMNADBKE(KHDFIKJLGJL MFJJKMPPMDO, EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x795B070", Offset = "0x795A270", VA = "0x18795B070")]
	private static ACAKEBKDGNK BCBDJGJLGII(Matchmaking.HCNCMJKKAAM JIHGJBMAPNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x795B180", Offset = "0x795A380", VA = "0x18795B180")]
	[AsyncStateMachine(typeof(AGAFDMBALEL))]
	private Task CFDPLFLAEIL(Matchmaking.HCNCMJKKAAM JIHGJBMAPNN, DAIEOJJKKMF MIHEKIAPICK, EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, CancellationToken EFCCBEDNKJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x795C2F0", Offset = "0x795B4F0", VA = "0x18795C2F0")]
	[AsyncStateMachine(typeof(PLGFJGMILDL))]
	private Task GDICAOPOIMH(KHDFIKJLGJL MFJJKMPPMDO, CancellationTokenSource MKGIFNCMJCL, Task GNBJOCDCFOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x795CA90", Offset = "0x795BC90", VA = "0x18795CA90")]
	[AsyncStateMachine(typeof(PLOGFBEBDCN))]
	private Task HAOAOMJHEBH(FENMDJFMHBI BFMLDAJIGMA, IMPDAEGGLLG NMPJEHAAKFP, KHDFIKJLGJL BMDKBCCPLHP, DAIEOJJKKMF IIOJCPEHBPB, EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, CancellationToken HFJPJBKALGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x795AE80", Offset = "0x795A080", VA = "0x18795AE80")]
	private DAIEOJJKKMF AFMFAJKJLGA(DAIEOJJKKMF IIOJCPEHBPB, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x795B430", Offset = "0x795A630", VA = "0x18795B430")]
	[AsyncStateMachine(typeof(PNDOOIIKHLI))]
	private Task CHKPFNJPKOJ(EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x795B780", Offset = "0x795A980", VA = "0x18795B780")]
	[AsyncStateMachine(typeof(KLGENOEHJLK))]
	private Task DEFLCNBGFGK(CancellationToken BGEKICMONBE, int DLGKMEMHOGL, HEOHLAMPJMC GLOCFMOMECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x795D5E0", Offset = "0x795C7E0", VA = "0x18795D5E0")]
	private static void MGCAJLAFOKE(KHDFIKJLGJL MFJJKMPPMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x795C840", Offset = "0x795BA40", VA = "0x18795C840")]
	private void GPCMDMIKDFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x795CE50", Offset = "0x795C050", VA = "0x18795CE50")]
	private void IADFMLKGEDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x795B900", Offset = "0x795AB00", VA = "0x18795B900")]
	private void EIBCHIPBAEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x795B990", Offset = "0x795AB90", VA = "0x18795B990")]
	private void EMFKDEKLFAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x795C750", Offset = "0x795B950", VA = "0x18795C750")]
	private static void GKDOEKIFBKF(KHDFIKJLGJL MFJJKMPPMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x795D390", Offset = "0x795C590", VA = "0x18795D390")]
	private static CancellationTokenRegistration LNNEHKDMOJF(KHDFIKJLGJL MFJJKMPPMDO, CancellationToken EFCCBEDNKJG)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x795D8B0", Offset = "0x795CAB0", VA = "0x18795D8B0")]
	private static void NBDGDPFEGHD(KHDFIKJLGJL MFJJKMPPMDO, Exception ANJHEGDKNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x795CEE0", Offset = "0x795C0E0", VA = "0x18795CEE0")]
	private void IFPAKGGNJAL(KHDFIKJLGJL MFJJKMPPMDO, Task GNBJOCDCFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x795D090", Offset = "0x795C290", VA = "0x18795D090")]
	private static void IKHOJNLBJOK(Func<string> GFNGFABOFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x795E5E0", Offset = "0x795D7E0", VA = "0x18795E5E0")]
	public MHFPCAKMDKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x795E210", Offset = "0x795D410", VA = "0x18795E210")]
	[CompilerGenerated]
	internal static (int, int?) POLFPHJJOLM(HGDHJHLLJGP KGBDOKDJBHH)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class CGCCFOEKMCL : ADECPFBBALC, LOPMFDCLLIO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct LPGHCOLCNAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public CGCCFOEKMCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public HEOHLAMPJMC localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7979910", Offset = "0x7978B10", VA = "0x187979910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7979D80", Offset = "0x7978F80", VA = "0x187979D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class GJOLNIJCIOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public CGCCFOEKMCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public HEOHLAMPJMC localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public GJOLNIJCIOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x79727E0", Offset = "0x79719E0", VA = "0x1879727E0")]
		internal List<Task> CODAACCHHJH(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct PPLHBLFKOJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public EODFAJAJAHG taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public HEOHLAMPJMC localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7982FF0", Offset = "0x79821F0", VA = "0x187982FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7983390", Offset = "0x7982590", VA = "0x187983390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct PAAOEEMLJIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public CGCCFOEKMCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x79816A0", Offset = "0x79808A0", VA = "0x1879816A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7981980", Offset = "0x7980B80", VA = "0x187981980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly HashSet<EODFAJAJAHG> HBDKBBIDCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private NCGHKHMPIGG BFOPFCHDMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private NDEJMCPCCDJ CNCOIDECOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private JIKAOKCOAGM GJJBHPGJLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private DFKKANBBPNH PCPNNIJGPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private IDisposable NPELOHOANDE;

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x79696C0", Offset = "0x79688C0", VA = "0x1879696C0", Slot = "5")]
	public void GGPOBANFNOP(NDEJMCPCCDJ CNCOIDECOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7969350", Offset = "0x7968550", VA = "0x187969350", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x79692F0", Offset = "0x79684F0", VA = "0x1879692F0", Slot = "4")]
	public bool CKJEAMHLFNH(EODFAJAJAHG IHHGPCGJHDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x79693D0", Offset = "0x79685D0", VA = "0x1879693D0")]
	private void EFLPPPMFFHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x79694A0", Offset = "0x79686A0", VA = "0x1879694A0")]
	private void FKGODALNJLF(GHIJJJNKODG JPGPNLNCOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7969AE0", Offset = "0x7968CE0", VA = "0x187969AE0")]
	[AsyncStateMachine(typeof(LPGHCOLCNAG))]
	private Task HCDDBEBCIFD(int DLGKMEMHOGL, HEOHLAMPJMC GLOCFMOMECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7969CA0", Offset = "0x7968EA0", VA = "0x187969CA0")]
	private Func<CancellationToken, List<Task>> LAEOGGINENK(int DLGKMEMHOGL, HEOHLAMPJMC GLOCFMOMECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7969D70", Offset = "0x7968F70", VA = "0x187969D70")]
	private List<Task> LJPLHDJPGFP(int DLGKMEMHOGL, HEOHLAMPJMC GLOCFMOMECB, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x79699C0", Offset = "0x7968BC0", VA = "0x1879699C0")]
	[AsyncStateMachine(typeof(PPLHBLFKOJO))]
	private Task GKNAIOGOFPH(EODFAJAJAHG IDGNMNKCFIL, CancellationToken BCOHKLCJCPM, int DLGKMEMHOGL, HEOHLAMPJMC GLOCFMOMECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7969BD0", Offset = "0x7968DD0", VA = "0x187969BD0")]
	[AsyncStateMachine(typeof(PAAOEEMLJIA))]
	private Task IECANIJPLHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7969240", Offset = "0x7968440", VA = "0x187969240")]
	private void BCMBOJBHPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x796A240", Offset = "0x7969440", VA = "0x18796A240")]
	public CGCCFOEKMCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[UnityEngine.Scripting.Preserve]
internal sealed class HCLIOANFFPG : HKDOMLGFBDK, LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class NPOFJCADIOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public NPOFJCADIOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x797B000", Offset = "0x797A200", VA = "0x18797B000")]
		internal object CMJGPBDLIPN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class CBOGPILOOKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CBOGPILOOKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7967FF0", Offset = "0x79671F0", VA = "0x187967FF0")]
		internal object LKPCLAFLFNL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class AMPGJNGIBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public AMPGJNGIBAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class HKJAFFEJLIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public HKJAFFEJLIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x79744E0", Offset = "0x79736E0", VA = "0x1879744E0")]
		internal object NNCAIOFFIAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class LHPJCPPOOMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public LHPJCPPOOMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7978590", Offset = "0x7977790", VA = "0x187978590")]
		internal object LKCCDOEBLLH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly Dictionary<Guid, EDKFNECIGGG> PCFCEJFBJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private readonly TimeSpan PPEIKIENCGJ;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "9")]
	public void GGPOBANFNOP(NDEJMCPCCDJ CNCOIDECOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7973D10", Offset = "0x7972F10", VA = "0x187973D10", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7973AF0", Offset = "0x7972CF0", VA = "0x187973AF0", Slot = "4")]
	public NBFMEBKJMKP CKLHJOINNOK(Guid DHNJGGKJENC)
	{
		return default(NBFMEBKJMKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7973D20", Offset = "0x7972F20", VA = "0x187973D20", Slot = "5")]
	public bool GMODDBABBFK(Guid DHNJGGKJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x79737C0", Offset = "0x79729C0", VA = "0x1879737C0", Slot = "6")]
	public bool BENNGMOAMGM(Guid DHNJGGKJENC, Task LBPFHJHACNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7973F30", Offset = "0x7973130", VA = "0x187973F30", Slot = "7")]
	public bool MBHDEDAIAHB(Guid DHNJGGKJENC, JIDFLMCDEBP JFBEBFDNAJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7973750", Offset = "0x7972950", VA = "0x187973750", Slot = "8")]
	public Task<(JIDFLMCDEBP, Task)> AFJPHCJDKIH(Guid DHNJGGKJENC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7974110", Offset = "0x7973310", VA = "0x187974110")]
	private void NKABIPJADKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7974340", Offset = "0x7973540", VA = "0x187974340")]
	public HCLIOANFFPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[RecRoom.NoEngine.Common.Preserve]
internal class AKCNMKLHGED : OANEACPOBBM, LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private class KCEBCKIACPI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private readonly KHDFIKJLGJL BPCDGFAHMOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private readonly CancellationTokenSource BCFACPBIPCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public readonly CancellationToken PACGCGGMHMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private bool BLAPKIEGEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private bool CLAMDNBMMAC;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x79753D0", Offset = "0x79745D0", VA = "0x1879753D0")]
		public KCEBCKIACPI(KHDFIKJLGJL BPCDGFAHMOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7975250", Offset = "0x7974450", VA = "0x187975250")]
		public void BCMBOJBHPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x79753A0", Offset = "0x79745A0", VA = "0x1879753A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class BAEJLCLHFJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public MGHBOLDNAIG disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BAEJLCLHFJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7967010", Offset = "0x7966210", VA = "0x187967010")]
		internal object NIPGGNOFGAM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct BMGLFLIFEGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public MGHBOLDNAIG disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public AKCNMKLHGED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7967B90", Offset = "0x7966D90", VA = "0x187967B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7967F90", Offset = "0x7967190", VA = "0x187967F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class EIBNFDNMLGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public EIBNFDNMLGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x796D750", Offset = "0x796C950", VA = "0x18796D750")]
		internal object GMJEDCCJBDM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct CEALMPMAEDD : IAsyncStateMachine
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
		public AKCNMKLHGED <>4__this;

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
		private OODALMMDODD <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7968050", Offset = "0x7967250", VA = "0x187968050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class PHCBJNDEDDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public KHDFIKJLGJL newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public PHCBJNDEDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7981F70", Offset = "0x7981170", VA = "0x187981F70")]
		internal object CNHECHAOEJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7982010", Offset = "0x7981210", VA = "0x187982010")]
		internal object LMMAIPAMOEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7981F30", Offset = "0x7981130", VA = "0x187981F30")]
		internal object BCJNKMNAFDI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class ELAPPKDPPPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public ELAPPKDPPPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x796DC90", Offset = "0x796CE90", VA = "0x18796DC90")]
		internal void LILIIIPJHNC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct OKJCFFKENIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public KHDFIKJLGJL newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public AKCNMKLHGED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public MBLMBODNJJG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private PHCBJNDEDDO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private OODALMMDODD <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x797D670", Offset = "0x797C870", VA = "0x18797D670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x797E600", Offset = "0x797D800", VA = "0x18797E600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly HFDDKOPCOOF.CJBIDKNJMHA CGKEGNONEEO;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly EJJCGEPDLHL ONKIIIDBMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private NCGHKHMPIGG BFOPFCHDMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private NDEJMCPCCDJ CNCOIDECOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private PJMBDGNBAGG BJNMGJGPPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private LMIBFAPANNF CKNLAJJPLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private POLHFFJEJFN LFKGAGFDDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private HKBIGFOCBKM CEFAFOIADBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private KHDFIKJLGJL OCMJIPDDKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private KCEBCKIACPI KIJANDDCJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private bool FENGGANEIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private Task LJIBNPDEPMK;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private AOMKKEDLMKB INFDKHDKCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7965ED0", Offset = "0x79650D0", VA = "0x187965ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool DHMONNKOEFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xB2C4F0", Offset = "0xB2B6F0", VA = "0x180B2C4F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7965D30", Offset = "0x7964F30", VA = "0x187965D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7965A90", Offset = "0x7964C90", VA = "0x187965A90", Slot = "4")]
	public void GGPOBANFNOP(NDEJMCPCCDJ CNCOIDECOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7965800", Offset = "0x7964A00", VA = "0x187965800", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7966250", Offset = "0x7965450", VA = "0x187966250")]
	[AsyncStateMachine(typeof(BMGLFLIFEGA))]
	private Task PIIEKFLJCNI(MGHBOLDNAIG OPJJOMEIDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7965D40", Offset = "0x7964F40", VA = "0x187965D40")]
	private void IMHIHALHJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x79660C0", Offset = "0x79652C0", VA = "0x1879660C0")]
	private void OGEMPKJKODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7965680", Offset = "0x7964880", VA = "0x187965680")]
	private void BICNBADPLCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7965F70", Offset = "0x7965170", VA = "0x187965F70")]
	private bool LCHBACBPKOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7965FF0", Offset = "0x79651F0", VA = "0x187965FF0")]
	[AsyncStateMachine(typeof(CEALMPMAEDD))]
	private void NHADPHCNNNM(int NIGKDAPIFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x79653E0", Offset = "0x79645E0", VA = "0x1879653E0")]
	private void AEFMKEMJMKA([Out] IDisposable IBFOHCHKCLE, [Out] IDisposable OPDDLJDBOCG, [Out] IDisposable DNKDPMNEKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7965970", Offset = "0x7964B70", VA = "0x187965970")]
	private bool FJJMJBAIJCN(KHDFIKJLGJL BPCDGFAHMOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7965F20", Offset = "0x7965120", VA = "0x187965F20")]
	private void LCBCHGKKEIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x7966340", Offset = "0x7965540", VA = "0x187966340")]
	[AsyncStateMachine(typeof(OKJCFFKENIA))]
	private Task POOFCCHNNKJ(KHDFIKJLGJL BPCDGFAHMOF, MBLMBODNJJG CDPHCJLDAGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7966830", Offset = "0x7965A30", VA = "0x187966830")]
	public AKCNMKLHGED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[UnityEngine.Scripting.Preserve]
internal sealed class KHPFPODKOAE : KBACNKACNHI, LOPMFDCLLIO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct LIKJGONHDEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public AsyncTaskMethodBuilder<KMGKENCAGOE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public KHPFPODKOAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private TaskAwaiter<KMGKENCAGOE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x79785F0", Offset = "0x79777F0", VA = "0x1879785F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7978880", Offset = "0x7977A80", VA = "0x187978880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class MPOJDLEBAFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public FJJEHEJHICA message;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public MPOJDLEBAFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x797AE60", Offset = "0x797A060", VA = "0x18797AE60")]
		internal object BNEFBLHHPOO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class JPDLDPJKLCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public FJJEHEJHICA messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public JPDLDPJKLCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x79751F0", Offset = "0x79743F0", VA = "0x1879751F0")]
		internal object DHECAECAJHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class OMFDAEDCGHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public FJJEHEJHICA request;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public OMFDAEDCGHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x797ECA0", Offset = "0x797DEA0", VA = "0x18797ECA0")]
		internal object PEBFOAJFOLM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct OPDJDBCMFLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public FJJEHEJHICA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public KHPFPODKOAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<AJHAEBBPGDJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7980D70", Offset = "0x797FF70", VA = "0x187980D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7981640", Offset = "0x7980840", VA = "0x187981640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class DLDNGHDMNAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public FJJEHEJHICA operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public DLDNGHDMNAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x796D6F0", Offset = "0x796C8F0", VA = "0x18796D6F0")]
		internal object DJAPJHJLAKM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct EMJECMBILKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public FJJEHEJHICA operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public KHPFPODKOAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private DAIEOJJKKMF <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<FJJEHEJHICA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x796F390", Offset = "0x796E590", VA = "0x18796F390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x796FF00", Offset = "0x796F100", VA = "0x18796FF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct DHNEIMGLJOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder<AJHAEBBPGDJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public KHPFPODKOAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public FJJEHEJHICA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private GFNNBLKBMKF.BJAMBOCADPL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private DAIEOJJKKMF <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private TaskAwaiter<FJJEHEJHICA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x796D150", Offset = "0x796C350", VA = "0x18796D150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x796D680", Offset = "0x796C880", VA = "0x18796D680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class FCBNIJFOJOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public AJHAEBBPGDJ operation;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public FCBNIJFOJOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x7970990", Offset = "0x796FB90", VA = "0x187970990")]
		internal object DCKFAOIFDFE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct POLOPAGNFKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public AJHAEBBPGDJ operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public KHPFPODKOAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private EKKGOIIBGNN<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x79828A0", Offset = "0x7981AA0", VA = "0x1879828A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x7982ED0", Offset = "0x79820D0", VA = "0x187982ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class HNNFGILMOOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public FJJEHEJHICA request;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public HNNFGILMOOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x79745C0", Offset = "0x79737C0", VA = "0x1879745C0")]
		internal object KELACBIIBCG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class MFFHMGJNFKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public FJJEHEJHICA request;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public MFFHMGJNFKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7979F00", Offset = "0x7979100", VA = "0x187979F00")]
		internal object LJAMHPLDODO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private NDEJMCPCCDJ CNCOIDECOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private HNOBBEEKOHL BKBFMJKKCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private NFHJOHAGGAM LMEMKKNMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private OLDBABLMPPE EFNLDCMHCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private JMCGIMEIOCB IBMNPFDADDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private TaskCompletionSource<KMGKENCAGOE> FOELBCHEAGE;

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7975A20", Offset = "0x7974C20", VA = "0x187975A20", Slot = "7")]
	public void GGPOBANFNOP(NDEJMCPCCDJ CNCOIDECOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7976230", Offset = "0x7975430", VA = "0x187976230", Slot = "6")]
	[AsyncStateMachine(typeof(LIKJGONHDEI))]
	public Task<KMGKENCAGOE> JNCBFGCHEHO(CancellationToken BMNPINCDFBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7975B10", Offset = "0x7974D10", VA = "0x187975B10", Slot = "4")]
	public void GPIMNBPALDC(FJJEHEJHICA CBCJFCINKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7976460", Offset = "0x7975660", VA = "0x187976460", Slot = "5")]
	public void OCMJAAJNNEE(FJJEHEJHICA ABOGEFGPIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x79767C0", Offset = "0x79759C0", VA = "0x1879767C0")]
	[AsyncStateMachine(typeof(OPDJDBCMFLI))]
	private Task OHDFCLDEGKA(FJJEHEJHICA JLBJPEIMAMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7975700", Offset = "0x7974900", VA = "0x187975700")]
	[AsyncStateMachine(typeof(EMJECMBILKB))]
	private Task DBCDJOGBOHJ(FJJEHEJHICA EDHHOFEAFEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x79755B0", Offset = "0x79747B0", VA = "0x1879755B0")]
	[AsyncStateMachine(typeof(DHNEIMGLJOI))]
	private Task<AJHAEBBPGDJ> BGOONPJPPEL(FJJEHEJHICA JLBJPEIMAMB, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7975520", Offset = "0x7974720", VA = "0x187975520")]
	private DAIEOJJKKMF BBCMHFMINNB(FJJEHEJHICA BGGCAOOLCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7976340", Offset = "0x7975540", VA = "0x187976340")]
	[AsyncStateMachine(typeof(POLOPAGNFKF))]
	private Task LABIGCOAFJB(AJHAEBBPGDJ AHMKJKELCNK, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7975810", Offset = "0x7974A10", VA = "0x187975810")]
	private AJHAEBBPGDJ DMEGLHIBFKP(FJJEHEJHICA JLBJPEIMAMB, DAIEOJJKKMF HHPEAOJALPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x332ADC0", Offset = "0x3329FC0", VA = "0x18332ADC0")]
	private T PBNPLFPGBLD<T>(T OMEFCJCOLII) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7975EA0", Offset = "0x79750A0", VA = "0x187975EA0")]
	private AJHAEBBPGDJ HFKNIAFJAHB(FJJEHEJHICA JLBJPEIMAMB, DAIEOJJKKMF HHPEAOJALPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public KHPFPODKOAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[UnityEngine.Scripting.Preserve]
internal sealed class OOJBLNMANOB : NFHJOHAGGAM, LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class BLFBLKLGBFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BLFBLKLGBFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x7967B20", Offset = "0x7966D20", VA = "0x187967B20")]
		internal object CEOHIIPMENG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class LBAMFCEKBPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public LBAMFCEKBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x7977D10", Offset = "0x7976F10", VA = "0x187977D10")]
		internal object JFADHLEALNJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private JMCGIMEIOCB IBMNPFDADDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private DFEKIFGBEDE MJDFIKDOKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private KBACNKACNHI ONCEFEJCKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private HKDOMLGFBDK PCFCEJFBJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private NKJCPJBKINC KBHDBLLMDPP;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x797F700", Offset = "0x797E900", VA = "0x18797F700", Slot = "6")]
	public void GGPOBANFNOP(NDEJMCPCCDJ CNCOIDECOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x797F3A0", Offset = "0x797E5A0", VA = "0x18797F3A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x797ED60", Offset = "0x797DF60", VA = "0x18797ED60", Slot = "4")]
	public NBFMEBKJMKP AEKEMMBDOLF(FJJEHEJHICA PGOMOBGAPKC)
	{
		return default(NBFMEBKJMKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x797F190", Offset = "0x797E390", VA = "0x18797F190", Slot = "5")]
	public void CDCNMGHJNEL(Guid DHNJGGKJENC, Task LBPFHJHACNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x797FD40", Offset = "0x797EF40", VA = "0x18797FD40")]
	private void HDEFKFLKEOL(byte PJPNCJONJKO, int APDDGNGPBHM, object KPOPMGFMNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x79802D0", Offset = "0x797F4D0", VA = "0x1879802D0")]
	private void JJEEHFHOKKD(KPDAAMLFCIH PKEBHPACJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7980860", Offset = "0x797FA60", VA = "0x187980860")]
	private void JPPKNNIJHEN(KPDAAMLFCIH PKEBHPACJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x797F870", Offset = "0x797EA70", VA = "0x18797F870")]
	private void GOJCEJBLDOD(KPDAAMLFCIH PKEBHPACJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x797FE10", Offset = "0x797F010", VA = "0x18797FE10")]
	private JIDFLMCDEBP HEHCOFNAJPD(FJJEHEJHICA BGGCAOOLCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7980B60", Offset = "0x797FD60", VA = "0x187980B60")]
	private void KOJOGDIFPFG(FJJEHEJHICA EDHHOFEAFEP, JIDFLMCDEBP JFBEBFDNAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x797F450", Offset = "0x797E650", VA = "0x18797F450")]
	private bool EOPHELLPBJG(FJJEHEJHICA EDHHOFEAFEP, JIDFLMCDEBP JFBEBFDNAJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7980050", Offset = "0x797F250", VA = "0x187980050")]
	private bool IEHELFDONFO(FJJEHEJHICA DGKHBJFEEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x797FAB0", Offset = "0x797ECB0", VA = "0x18797FAB0")]
	private bool GOKMLLCMICO(byte PJPNCJONJKO, ExitGames.Client.Photon.Hashtable PKEBHPACJJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public OOJBLNMANOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[UnityEngine.Scripting.Preserve]
internal sealed class OFEBNICIKGF : ICHOMMDGIHO, LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class LFDNFMPLKOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public KMGKENCAGOE operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public OFEBNICIKGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public FJJEHEJHICA roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public LFDNFMPLKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x79783F0", Offset = "0x79775F0", VA = "0x1879783F0")]
		internal object HALJBHPJEBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x7978460", Offset = "0x7977660", VA = "0x187978460")]
		internal object LBPOBPGILCC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct EOPMLNLEICF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<JIDFLMCDEBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public OFEBNICIKGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public FJJEHEJHICA roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<JIDFLMCDEBP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x796FF60", Offset = "0x796F160", VA = "0x18796FF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7970600", Offset = "0x796F800", VA = "0x187970600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class FOHHNGDHFLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public KMGKENCAGOE operationType;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public FOHHNGDHFLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x7971ED0", Offset = "0x79710D0", VA = "0x187971ED0")]
		internal object JCJGCINLFII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class FBKGPGONDHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public FJJEHEJHICA request;

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public FBKGPGONDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x7970920", Offset = "0x796FB20", VA = "0x187970920")]
		internal object PAAPCPBMDAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7970840", Offset = "0x796FA40", VA = "0x187970840")]
		internal object EMMEOPNOCKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x79708B0", Offset = "0x796FAB0", VA = "0x1879708B0")]
		internal object OGJDAPJFLGL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct FLEAAGOHDNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<JIDFLMCDEBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public FJJEHEJHICA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public OFEBNICIKGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private FBKGPGONDHK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private NBFMEBKJMKP <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private JIDFLMCDEBP <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private TaskAwaiter<(JIDFLMCDEBP validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x7970F50", Offset = "0x7970150", VA = "0x187970F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x7971820", Offset = "0x7970A20", VA = "0x187971820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private JMCGIMEIOCB IBMNPFDADDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private DFEKIFGBEDE MJDFIKDOKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private NFHJOHAGGAM LMEMKKNMKJP;

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x797D5C0", Offset = "0x797C7C0", VA = "0x18797D5C0", Slot = "5")]
	public void GGPOBANFNOP(NDEJMCPCCDJ CNCOIDECOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x797D360", Offset = "0x797C560", VA = "0x18797D360", Slot = "4")]
	[AsyncStateMachine(typeof(EOPMLNLEICF))]
	private Task<JIDFLMCDEBP> CJCNLKMFMGJ(FJJEHEJHICA BGGCAOOLCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x797D170", Offset = "0x797C370", VA = "0x18797D170")]
	private bool BMCMBGMLHBN(KMGKENCAGOE MFHJGCFBFIG, [Out] JIDFLMCDEBP NJFLHCEDIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x797D480", Offset = "0x797C680", VA = "0x18797D480")]
	[AsyncStateMachine(typeof(FLEAAGOHDNC))]
	private Task<JIDFLMCDEBP> CPPMCJDAHAO(FJJEHEJHICA JLBJPEIMAMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public OFEBNICIKGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class OBKNAAIHLAM : MEIJBJKHKBG, LOPMFDCLLIO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct FLKAJPKJEBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<FENMDJFMHBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public KHDFIKJLGJL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public OBKNAAIHLAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private TaskAwaiter<OAOBEPBAJLE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<FENMDJFMHBI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7971890", Offset = "0x7970A90", VA = "0x187971890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x7971E60", Offset = "0x7971060", VA = "0x187971E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class PHJACJCBOJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public PHJACJCBOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x7982050", Offset = "0x7981250", VA = "0x187982050")]
		internal object PILBKDNPOGG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct GFPJGLKECOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public AsyncTaskMethodBuilder<OAOBEPBAJLE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public OBKNAAIHLAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public KHDFIKJLGJL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private PHJACJCBOJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<OAOBEPBAJLE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x7972180", Offset = "0x7971380", VA = "0x187972180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7972770", Offset = "0x7971970", VA = "0x187972770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct MGMDHELNNEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<FENMDJFMHBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public OBKNAAIHLAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public KHDFIKJLGJL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public OAOBEPBAJLE roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<(GLPHDJDILNO superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x797A990", Offset = "0x7979B90", VA = "0x18797A990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x797ADF0", Offset = "0x7979FF0", VA = "0x18797ADF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class ONCDJKINDPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public ONCDJKINDPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xCF10D0", Offset = "0xCF02D0", VA = "0x180CF10D0")]
		internal bool ACLPLNDEIOG(CNMPJHKKKIM sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct AOJAMJCBGMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<(GLPHDJDILNO superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public OAOBEPBAJLE roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public OBKNAAIHLAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public KHDFIKJLGJL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<(GLPHDJDILNO superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x7966900", Offset = "0x7965B00", VA = "0x187966900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x7966FA0", Offset = "0x79661A0", VA = "0x187966FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class BFNEEEHODBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BFNEEEHODBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x79673F0", Offset = "0x79665F0", VA = "0x1879673F0")]
		internal object IOHCENOGMMG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct PODJJDFFGOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public AsyncTaskMethodBuilder<(GLPHDJDILNO superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public CNMPJHKKKIM subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public OBKNAAIHLAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public KHDFIKJLGJL dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private BFNEEEHODBE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private TaskAwaiter<GLPOHAHMIGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x7982100", Offset = "0x7981300", VA = "0x187982100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x7982830", Offset = "0x7981A30", VA = "0x187982830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static readonly (GLPHDJDILNO superRoomData, long subRoomDataSaveId) PENABECBMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private LMIBFAPANNF CKNLAJJPLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private NHKBIEIPOHH NPPPAKEHEAC;

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x797B330", Offset = "0x797A530", VA = "0x18797B330", Slot = "5")]
	public void GGPOBANFNOP(NDEJMCPCCDJ CNCOIDECOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x797B1D0", Offset = "0x797A3D0", VA = "0x18797B1D0", Slot = "4")]
	[AsyncStateMachine(typeof(FLKAJPKJEBA))]
	public Task<FENMDJFMHBI> FHLANFNDNKE(EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, KHDFIKJLGJL MFJJKMPPMDO, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x797B3C0", Offset = "0x797A5C0", VA = "0x18797B3C0")]
	[AsyncStateMachine(typeof(GFPJGLKECOI))]
	private Task<OAOBEPBAJLE> MJNHMHCDOJG(KHDFIKJLGJL MFJJKMPPMDO, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x797B060", Offset = "0x797A260", VA = "0x18797B060")]
	[AsyncStateMachine(typeof(MGMDHELNNEP))]
	private Task<FENMDJFMHBI> BJPFMNIOFIB(KHDFIKJLGJL MFJJKMPPMDO, OAOBEPBAJLE MLFBMJNDMCH, long NPLPICCKAOE, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x797B690", Offset = "0x797A890", VA = "0x18797B690")]
	[AsyncStateMachine(typeof(AOJAMJCBGMM))]
	private Task<(GLPHDJDILNO, long)> PDBMFMCDFOM(KHDFIKJLGJL MFJJKMPPMDO, OAOBEPBAJLE MLFBMJNDMCH, long NPLPICCKAOE, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x797B520", Offset = "0x797A720", VA = "0x18797B520")]
	[AsyncStateMachine(typeof(PODJJDFFGOA))]
	private Task<(GLPHDJDILNO, long)> OFNCGCNCAHC(KHDFIKJLGJL KBALFHNGNFA, CNMPJHKKKIM LNHNDOHKGCC, long NPLPICCKAOE, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public OBKNAAIHLAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[UnityEngine.Scripting.Preserve]
internal sealed class LJAHHHFLJLN : OLDBABLMPPE, LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class OBLABGLNCMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public FJJEHEJHICA request;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public OBLABGLNCMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x797B8D0", Offset = "0x797AAD0", VA = "0x18797B8D0")]
		internal object PCIPOHPHPBO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct BLAEBGAGJCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public AsyncTaskMethodBuilder<FJJEHEJHICA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public FJJEHEJHICA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public LJAHHHFLJLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public DAIEOJJKKMF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private TaskAwaiter<FJJEHEJHICA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x79674A0", Offset = "0x79666A0", VA = "0x1879674A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x7967AB0", Offset = "0x7966CB0", VA = "0x187967AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct LCKKMKCOJPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<FJJEHEJHICA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public LJAHHHFLJLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public DAIEOJJKKMF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter<ICIJIBHEEGC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7977D80", Offset = "0x7976F80", VA = "0x187977D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x7978380", Offset = "0x7977580", VA = "0x187978380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class OOIDOGAJMKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public FJJEHEJHICA request;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public OOIDOGAJMKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x797ED00", Offset = "0x797DF00", VA = "0x18797ED00")]
		internal object FGAMHJCDMHP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct CGHBDPHFECM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<FJJEHEJHICA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public FJJEHEJHICA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public LJAHHHFLJLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public DAIEOJJKKMF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private EIIFLLEBLHL <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private LLBMIIIAILK <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter<ICIJIBHEEGC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x796A2D0", Offset = "0x79694D0", VA = "0x18796A2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x796AEC0", Offset = "0x796A0C0", VA = "0x18796AEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private JMCGIMEIOCB IBMNPFDADDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private GEKEAHMAJJI BJPHILDMLIN;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private FAOLIJLBMLP BFDIHMPBAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7978D70", Offset = "0x7977F70", VA = "0x187978D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7978B90", Offset = "0x7977D90", VA = "0x187978B90", Slot = "8")]
	public void GGPOBANFNOP(NDEJMCPCCDJ CNCOIDECOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x7978EE0", Offset = "0x79780E0", VA = "0x187978EE0", Slot = "4")]
	[AsyncStateMachine(typeof(BLAEBGAGJCE))]
	public Task<FJJEHEJHICA> PILOAHCHNEN(FJJEHEJHICA JLBJPEIMAMB, DAIEOJJKKMF HHPEAOJALPJ, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7978C20", Offset = "0x7977E20", VA = "0x187978C20", Slot = "5")]
	[AsyncStateMachine(typeof(LCKKMKCOJPP))]
	public Task<FJJEHEJHICA> HGOJJKKAKGC(CancellationToken BGEKICMONBE, DAIEOJJKKMF HHPEAOJALPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7978E30", Offset = "0x7978030", VA = "0x187978E30", Slot = "6")]
	public DDGKJPGGCCE MKBANOCDALD(AJHAEBBPGDJ OKBAPDEMJCF, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x79788F0", Offset = "0x7977AF0", VA = "0x1879788F0", Slot = "7")]
	public DDGKJPGGCCE DHOOGHKEPNG(AJHAEBBPGDJ OKBAPDEMJCF, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7978A30", Offset = "0x7977C30", VA = "0x187978A30")]
	[AsyncStateMachine(typeof(CGHBDPHFECM))]
	private Task<FJJEHEJHICA> ENJKEONHKKC(FJJEHEJHICA JLBJPEIMAMB, DAIEOJJKKMF HHPEAOJALPJ, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x30F25A0", Offset = "0x30F17A0", VA = "0x1830F25A0")]
	private static byte[] JJFAOJEPDLI(FJJEHEJHICA CBCJFCINKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public LJAHHHFLJLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class OLIHMNDHCKP : DFEKIFGBEDE, LOPMFDCLLIO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private NNGIBCDKGLA IKOABIOLLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private JMCGIMEIOCB IBMNPFDADDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private HNOBBEEKOHL BKBFMJKKCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private EEMHNKCNKKG JPMACELBNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private LMIBFAPANNF CKNLAJJPLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private HKBIGFOCBKM CEFAFOIADBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private ADECPFBBALC EBKMFADACPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private POLHFFJEJFN LFKGAGFDDEM;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private AOMKKEDLMKB INFDKHDKCOG
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x797E940", Offset = "0x797DB40", VA = "0x18797E940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private static JIDFLMCDEBP KMDKEHPCIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x7970C70", Offset = "0x796FE70", VA = "0x187970C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x797E660", Offset = "0x797D860", VA = "0x18797E660", Slot = "6")]
	public void GGPOBANFNOP(NDEJMCPCCDJ CNCOIDECOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x797E7D0", Offset = "0x797D9D0", VA = "0x18797E7D0", Slot = "4")]
	public JIDFLMCDEBP GLHJJADJBHB(IAGJLFEFIKH IAIFMOHBNFK, KMGKENCAGOE GCOMOAFFFNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x797E990", Offset = "0x797DB90", VA = "0x18797E990", Slot = "5")]
	public JIDFLMCDEBP MFGACAGPOAC(IAGJLFEFIKH PJKFPOPJLHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7970C10", Offset = "0x796FE10", VA = "0x187970C10")]
	private static JIDFLMCDEBP GHCKEJFMALM(JPJHKMFKAFE GLMJIDMBMEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public OLIHMNDHCKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class GLACNNAHKKG : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7972820", Offset = "0x7971A20", VA = "0x187972820")]
	public GLACNNAHKKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x6CE5D30", Offset = "0x6CE4F30", VA = "0x186CE5D30")]
	public GLACNNAHKKG(string CBCJFCINKPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[UnityEngine.Scripting.Preserve]
internal sealed class DAFLCIJNHJL : FBLEPDEEPND, LOPMFDCLLIO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct GPFKDBOKIHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public AsyncTaskMethodBuilder<JIDFLMCDEBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public DAFLCIJNHJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AOCJALDHGHI autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private EKKGOIIBGNN<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private KLJKNBJNFJJ <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter<JIDFLMCDEBP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7972B60", Offset = "0x7971D60", VA = "0x187972B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x79736E0", Offset = "0x79728E0", VA = "0x1879736E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct CICKJFALOAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public DAFLCIJNHJL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x796AF30", Offset = "0x796A130", VA = "0x18796AF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x796B690", Offset = "0x796A890", VA = "0x18796B690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct MGKJMKKMCCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public DAFLCIJNHJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x797A420", Offset = "0x7979620", VA = "0x18797A420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x797A930", Offset = "0x7979B30", VA = "0x18797A930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct AHEFEABOFBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public DAFLCIJNHJL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7964C30", Offset = "0x7963E30", VA = "0x187964C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7965380", Offset = "0x7964580", VA = "0x187965380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct GMGJFGJNHPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public DAFLCIJNHJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7972860", Offset = "0x7971A60", VA = "0x187972860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7972A00", Offset = "0x7971C00", VA = "0x187972A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct DCDOHJDDNIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public DAFLCIJNHJL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x796C700", Offset = "0x796B900", VA = "0x18796C700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x796CE30", Offset = "0x796C030", VA = "0x18796CE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct EIHIIBMFMLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public DAFLCIJNHJL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x796D7C0", Offset = "0x796C9C0", VA = "0x18796D7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x796DC30", Offset = "0x796CE30", VA = "0x18796DC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct KOHMFJIFBMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public DAFLCIJNHJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public JBGHPJPHEMA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private EKKGOIIBGNN<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x79773B0", Offset = "0x79765B0", VA = "0x1879773B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7977920", Offset = "0x7976B20", VA = "0x187977920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private JMCGIMEIOCB IBMNPFDADDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private NDEJMCPCCDJ CNCOIDECOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private LMIBFAPANNF CKNLAJJPLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private OLDBABLMPPE EFNLDCMHCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private HNOBBEEKOHL BKBFMJKKCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private ADECPFBBALC EBKMFADACPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private CancellationTokenSource ODEPCBJPNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private Task IHNICENFMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private TaskCompletionSource<int> BAIFLACHDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private int AHCEIDANGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private int BCLBBLONOEL;

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x796BFD0", Offset = "0x796B1D0", VA = "0x18796BFD0", Slot = "6")]
	public void GGPOBANFNOP(NDEJMCPCCDJ CNCOIDECOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x109E700", Offset = "0x109D900", VA = "0x18109E700", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x796C530", Offset = "0x796B730", VA = "0x18796C530")]
	private void PLKOAJMLMBE(float KAHJMPKPBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x796C310", Offset = "0x796B510", VA = "0x18796C310", Slot = "4")]
	[AsyncStateMachine(typeof(GPFKDBOKIHF))]
	public Task<JIDFLMCDEBP> LMIKFELOIJE(AOCJALDHGHI DOKPKCJJFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x796C610", Offset = "0x796B810", VA = "0x18796C610", Slot = "5")]
	[AsyncStateMachine(typeof(CICKJFALOAH))]
	public Task PODIFEJJIAE([Optional] CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x109E700", Offset = "0x109D900", VA = "0x18109E700")]
	public void OIOOLFIPOND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x796BE60", Offset = "0x796B060", VA = "0x18796BE60")]
	private KLJKNBJNFJJ FAMKODDBNMB(AOCJALDHGHI DOKPKCJJFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x796C440", Offset = "0x796B640", VA = "0x18796C440")]
	[AsyncStateMachine(typeof(MGKJMKKMCCD))]
	private Task OFIAEEIBGME(CancellationToken LHPAGMJCDIN, int DLGKMEMHOGL, HEOHLAMPJMC GLOCFMOMECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x796B6F0", Offset = "0x796A8F0", VA = "0x18796B6F0")]
	[AsyncStateMachine(typeof(AHEFEABOFBN))]
	private Task ANMCKEOFNJB(CancellationToken LHPAGMJCDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x796BD70", Offset = "0x796AF70", VA = "0x18796BD70")]
	[AsyncStateMachine(typeof(GMGJFGJNHPG))]
	private Task EEJHHDOHJIM([Optional] CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x796BC80", Offset = "0x796AE80", VA = "0x18796BC80")]
	[AsyncStateMachine(typeof(DCDOHJDDNIJ))]
	private Task EDLMGKMHIIH(CancellationToken LHPAGMJCDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x796BA70", Offset = "0x796AC70", VA = "0x18796BA70")]
	[AsyncStateMachine(typeof(EIHIIBMFMLK))]
	private Task DIHJNDMOFJN(CancellationToken LOMGDFNLMDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x796C180", Offset = "0x796B380", VA = "0x18796C180")]
	private Task IMMFHLBJEGK(JBGHPJPHEMA IMGJKIKFHHF, CancellationToken LHPAGMJCDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x796BB70", Offset = "0x796AD70", VA = "0x18796BB70")]
	[AsyncStateMachine(typeof(KOHMFJIFBMF))]
	private Task EAMOALNJJAP(JBGHPJPHEMA IMGJKIKFHHF, CancellationToken LHPAGMJCDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x796B7F0", Offset = "0x796A9F0", VA = "0x18796B7F0")]
	private bool BEOPCMOAAHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public DAFLCIJNHJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[UnityEngine.Scripting.Preserve]
internal class JCKBKBAEBME : EEMHNKCNKKG, LOPMFDCLLIO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct IAIDOPLGOIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public JCKBKBAEBME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private EKKGOIIBGNN<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7974620", Offset = "0x7973820", VA = "0x187974620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7974B90", Offset = "0x7973D90", VA = "0x187974B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private KFOMELNKPNH BNJCBFNOIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private NDEJMCPCCDJ CNCOIDECOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private DFEKIFGBEDE MJDFIKDOKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private OLDBABLMPPE EFNLDCMHCAJ;

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x7974D20", Offset = "0x7973F20", VA = "0x187974D20", Slot = "6")]
	public void GGPOBANFNOP(NDEJMCPCCDJ CNCOIDECOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x7974CD0", Offset = "0x7973ED0", VA = "0x187974CD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x7975000", Offset = "0x7974200", VA = "0x187975000", Slot = "5")]
	[AsyncStateMachine(typeof(IAIDOPLGOIM))]
	public Task GHFFOPFIMAF(string BIIHNEHMDOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x7974C70", Offset = "0x7973E70", VA = "0x187974C70", Slot = "4")]
	public JIDFLMCDEBP BEOPCMOAAHJ(IAGJLFEFIKH IAIFMOHBNFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x7975100", Offset = "0x7974300", VA = "0x187975100")]
	private GMLEINIAJGJ KIBGBPOIOKE(string BIIHNEHMDOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public JCKBKBAEBME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class LMLMFPJKNBH
{
	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x7979570", Offset = "0x7978770", VA = "0x187979570")]
	public static void IGFLPJPOHEN(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x79797B0", Offset = "0x79789B0", VA = "0x1879797B0")]
	internal static void PKFEBBBMDNI(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x7979490", Offset = "0x7978690", VA = "0x187979490")]
	internal static void GMAOFGJFCME(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x7979040", Offset = "0x7978240", VA = "0x187979040")]
	internal static void BMLEFIKPFOF(JBPONICDCIO CKNPDKKKGFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class KILHGJALGKE : KCAMOEHHGOA<FJJEHEJHICA>
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class BENMGLFAHKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public FJJEHEJHICA message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BENMGLFAHKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x79670A0", Offset = "0x79662A0", VA = "0x1879670A0")]
		internal object ELIGGCBOBNG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly KILHGJALGKE CLACNPDFIIL;

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x7976FE0", Offset = "0x79761E0", VA = "0x187976FE0")]
	public ExitGames.Client.Photon.Hashtable LKDLAIOBOFF(FJJEHEJHICA CBCJFCINKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x79768D0", Offset = "0x7975AD0", VA = "0x1879768D0", Slot = "5")]
	protected override void DDDPKNCNCEF(FJJEHEJHICA CBCJFCINKPJ, IDictionary<object, object> LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7976DB0", Offset = "0x7975FB0", VA = "0x187976DB0", Slot = "6")]
	public override FJJEHEJHICA LAEIJKNHIPI(IDictionary<object, object> LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x7976CA0", Offset = "0x7975EA0", VA = "0x187976CA0")]
	private static void IKHOJNLBJOK(string BGJAGMIIILD, FJJEHEJHICA CBCJFCINKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x7977110", Offset = "0x7976310", VA = "0x187977110")]
	public KILHGJALGKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x7976A00", Offset = "0x7975C00", VA = "0x187976A00")]
	[CompilerGenerated]
	internal static string HLHMLPLEKLN(FENMDJFMHBI OCPJHHIMKFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class FEOIKMIGFIO
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public static JIDFLMCDEBP KMDKEHPCIFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x7970C70", Offset = "0x796FE70", VA = "0x187970C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x7970CD0", Offset = "0x796FED0", VA = "0x187970CD0")]
	public static bool LODOOINNIBK(this JIDFLMCDEBP JFBEBFDNAJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x7970C10", Offset = "0x796FE10", VA = "0x187970C10")]
	public static JIDFLMCDEBP GHCKEJFMALM(JPJHKMFKAFE FAOEPHHMLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7970A10", Offset = "0x796FC10", VA = "0x187970A10")]
	public static JIDFLMCDEBP FNHDKCMPMHJ(IEnumerable<JIDFLMCDEBP> KPGNMOAIIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x7970CF0", Offset = "0x796FEF0", VA = "0x187970CF0")]
	public static string NOFMNLJEAEP(this JIDFLMCDEBP NJFLHCEDIDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public abstract class MGJFCHFCCHD : GFPJMIHFAED, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public delegate JIDFLMCDEBP PAHKLMAFDKA([NotNull] IAGJLFEFIKH EJEKNOCBCJL);

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class DIAPBDMNDGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public IAGJLFEFIKH photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public DIAPBDMNDGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F0AD40", Offset = "0x6F09F40", VA = "0x186F0AD40")]
		internal JIDFLMCDEBP FLLKNPLDBLB(PAHKLMAFDKA v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private bool HAOFCOOGPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	protected readonly HashSet<PAHKLMAFDKA> EOJJDCHOHFA;

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x797A330", Offset = "0x7979530", VA = "0x18797A330", Slot = "4")]
	public void HKHGPFDMHBJ(PAHKLMAFDKA HPEEPFLBPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7979FE0", Offset = "0x79791E0", VA = "0x187979FE0", Slot = "5")]
	public void BJKOMIJBHOF(PAHKLMAFDKA HPEEPFLBPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x797A040", Offset = "0x7979240", VA = "0x18797A040", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x797A090", Offset = "0x7979290", VA = "0x18797A090")]
	protected JIDFLMCDEBP GBGAFBGBPPP(IAGJLFEFIKH PJKFPOPJLHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x797A390", Offset = "0x7979590", VA = "0x18797A390")]
	protected MGJFCHFCCHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class MBEMLAGDIFA : MGJFCHFCCHD, NNGIBCDKGLA, GFPJMIHFAED, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private sealed class ABJEGJAAJDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public JIDFLMCDEBP result;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public ABJEGJAAJDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7964BD0", Offset = "0x7963DD0", VA = "0x187964BD0")]
		internal object KIGHEMKDDKE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x7979EF0", Offset = "0x79790F0", VA = "0x187979EF0")]
	[UnityEngine.Scripting.Preserve]
	public MBEMLAGDIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7979DE0", Offset = "0x7978FE0", VA = "0x187979DE0", Slot = "8")]
	public JIDFLMCDEBP DGKCGMILAOO(IAGJLFEFIKH PJKFPOPJLHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class ODCLBFNAAAH : MGJFCHFCCHD, KFOMELNKPNH, GFPJMIHFAED, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private sealed class ALFONAKPFMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public JIDFLMCDEBP result;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public ALFONAKPFMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x79668A0", Offset = "0x7965AA0", VA = "0x1879668A0")]
		internal object ILKKMJKMOJL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7979EF0", Offset = "0x79790F0", VA = "0x187979EF0")]
	[UnityEngine.Scripting.Preserve]
	public ODCLBFNAAAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x797D060", Offset = "0x797C260", VA = "0x18797D060", Slot = "8")]
	public JIDFLMCDEBP BEOPCMOAAHJ(IAGJLFEFIKH FFIHLKECHEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class KOCECCEKJBP
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private sealed class HMFKEGFFOLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public EKKGOIIBGNN<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public HMFKEGFFOLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7974540", Offset = "0x7973740", VA = "0x187974540")]
		internal object JOGHCAPAOKD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7977210", Offset = "0x7976410", VA = "0x187977210")]
	public static EKKGOIIBGNN<string> DCOJFIPLFKG(KJMCEDJMPPA MOKKIOIDAGN, [Optional] string LHOGHAOILAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x79772F0", Offset = "0x79764F0", VA = "0x1879772F0")]
	public static void LEOJMFCFLJJ(EKKGOIIBGNN<string> FBHOIGDCPGK, KJMCEDJMPPA MOKKIOIDAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x7977150", Offset = "0x7976350", VA = "0x187977150")]
	public static string BLMPCJOONBJ(FJJEHEJHICA BGGCAOOLCME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal static class NAMOIHANMPO
{
	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x797AEC0", Offset = "0x797A0C0", VA = "0x18797AEC0")]
	public static void DDHNEHFGBNC(this JMCGIMEIOCB IBMNPFDADDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x797AFF0", Offset = "0x797A1F0", VA = "0x18797AFF0")]
	public static void OIBDGGDFCLN(this JMCGIMEIOCB IBMNPFDADDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x797AED0", Offset = "0x797A0D0", VA = "0x18797AED0")]
	private static void KJFMJHGKFGN(this JMCGIMEIOCB IBMNPFDADDO, bool NGFDAFHLONB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class PAOGLCMFFPB : POGCJKDBIKH, LLIBCFIKHLJ, CDBPHCGLHLE, HMBFCOMKJMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private readonly LLIBCFIKHLJ KBJLABGEFMP;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public IAGJLFEFIKH NHODNJNBAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7981D00", Offset = "0x7980F00", VA = "0x187981D00", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public int LHCBPIJCLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x79819E0", Offset = "0x7980BE0", VA = "0x1879819E0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int GPHPHBKAMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7981D50", Offset = "0x7980F50", VA = "0x187981D50", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool OLFEDGGGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public int MMODLFGIEKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xA8A350", Offset = "0xA89550", VA = "0x180A8A350", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event KOMJABFENJF.AFBMBHBGFGP BMIPLOLEODC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event IEKKBOKFPMC JHDCDHPIOEN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7981DA0", Offset = "0x7980FA0", VA = "0x187981DA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7981BB0", Offset = "0x7980DB0", VA = "0x187981BB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> OLGLFPAEFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<IAGJLFEFIKH> EMCHPNFPCDE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action MAAEFDFGBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x7981E90", Offset = "0x7981090", VA = "0x187981E90", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7981B10", Offset = "0x7980D10", VA = "0x187981B10", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0xBA2400", Offset = "0xBA1600", VA = "0x180BA2400")]
	public PAOGLCMFFPB(LLIBCFIKHLJ KBJLABGEFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x7981C50", Offset = "0x7980E50", VA = "0x187981C50", Slot = "8")]
	public bool INHDNGNNGCA(byte PJPNCJONJKO, ExitGames.Client.Photon.Hashtable FKGBINBALKL, CDDJOHNBMKA GDLEBELIAJM, SendOptions HDNGIPLBMNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7981A30", Offset = "0x7980C30", VA = "0x187981A30", Slot = "16")]
	public IAGJLFEFIKH ADBFLNGMCIC(int GOLPFJHCONJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "19")]
	public void DNOPNOOFEDK(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "20")]
	public void KPDEKPJKEHA(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "21")]
	public void MDJOCAMALHP(object BCOHKLCJCPM, bool DKNDJLELOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x7981E40", Offset = "0x7981040", VA = "0x187981E40", Slot = "22")]
	public IDisposable LLCFGLIJIKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "23")]
	private bool OENNKBLAJBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "24")]
	public void ODFCLNJFKOG(StringBuilder OJEPGEHGKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0xDC9280", Offset = "0xDC8480", VA = "0x180DC9280", Slot = "25")]
	public bool NLEGHANDNKL(bool NJEBGFMLALH, [Out] string GILNIHGCEJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0xD3AB70", Offset = "0xD39D70", VA = "0x180D3AB70", Slot = "28")]
	public void FGLKHBPDKEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct KPDAAMLFCIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private readonly IDictionary<object, object> PKEBHPACJJN;

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0xBC2740", Offset = "0xBC1940", VA = "0x180BC2740")]
	public KPDAAMLFCIH(IDictionary<object, object> PKEBHPACJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7977C60", Offset = "0x7976E60", VA = "0x187977C60")]
	public bool NLNHJOKJGKB([Out] FJJEHEJHICA CBCJFCINKPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x7977AC0", Offset = "0x7976CC0", VA = "0x187977AC0")]
	public Guid JIMDDHIFCMG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x7977980", Offset = "0x7976B80", VA = "0x187977980")]
	public JIDFLMCDEBP IDENJNNCJJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7977B70", Offset = "0x7976D70", VA = "0x187977B70")]
	public static ExitGames.Client.Photon.Hashtable LHPCDDMHIBB(FJJEHEJHICA CBCJFCINKPJ, JIDFLMCDEBP JFBEBFDNAJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal static class MFHFMCMAECF
{
	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7979F60", Offset = "0x7979160", VA = "0x187979F60")]
	public static bool HFOAIPHPMCF(this KHDFIKJLGJL GIEDJEEFFOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct DFKKANBBPNH : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct GBCCDJJJOBP : IAsyncStateMachine
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
		public DFKKANBBPNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7971F40", Offset = "0x7971140", VA = "0x187971F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7972120", Offset = "0x7971320", VA = "0x187972120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private readonly CancellationTokenSource BCFACPBIPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	private bool HAOFCOOGPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private Task JPPEAAIELKB;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool CLGLGAODANF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x796CE90", Offset = "0x796C090", VA = "0x18796CE90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x796D020", Offset = "0x796C220", VA = "0x18796D020")]
	public DFKKANBBPNH(CancellationToken BGEKICMONBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x796CF10", Offset = "0x796C110", VA = "0x18796CF10")]
	[AsyncStateMachine(typeof(GBCCDJJJOBP))]
	public Task IGBJBCILFHO(Func<CancellationToken, List<Task>> FACDHNGMGKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x796CEC0", Offset = "0x796C0C0", VA = "0x18796CEC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public readonly struct HCOFEFGGBKJ<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct AIBCAOOPCAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<LAPLGAAPACL<TData>, ENAONJKJOID>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public HCOFEFGGBKJ<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private TaskAwaiter<EBOICGKKPAM<LAPLGAAPACL<TData>, ENAONJKJOID>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x452A1E0", Offset = "0x45293E0", VA = "0x18452A1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x44E1490", Offset = "0x44E0690", VA = "0x1844E1490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private readonly OIGNAFLIEEG<TGetDataArg, TData> PHOHCHAEDED;

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0xBC2740", Offset = "0xBC1940", VA = "0x180BC2740")]
	internal HCOFEFGGBKJ(OIGNAFLIEEG<TGetDataArg, TData> KHICLIFOGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x44C1740", Offset = "0x44C0940", VA = "0x1844C1740")]
	[AsyncStateMachine(typeof(HCOFEFGGBKJ<, >.AIBCAOOPCAK))]
	public Task<EBOICGKKPAM<LAPLGAAPACL<TData>, ENAONJKJOID>> DBANGAKJHAB(TGetDataArg CJJMPIPLCIJ, string KPNMNAKEPPN, EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class CPLINJOAPNG
{
	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x30BFDB0", Offset = "0x30BEFB0", VA = "0x1830BFDB0")]
	public static HCOFEFGGBKJ<TGetDataArg, TData> PAJOIGLPBMN<TGetDataArg, TData>(OIGNAFLIEEG<TGetDataArg, TData> KHICLIFOGCP)
	{
		return default(HCOFEFGGBKJ<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public struct HGDHJHLLJGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public readonly int HEAMKNIMBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public readonly int? JKNHEHPMPHE;

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x49CAAB0", Offset = "0x49C9CB0", VA = "0x1849CAAB0")]
	public HGDHJHLLJGP(int PEEENJNCMNA, [Optional] int? LADLCEHKLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x7974400", Offset = "0x7973600", VA = "0x187974400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface POINLBCLAOC<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCPBENMPBAB();

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "1")]
	POINLBCLAOC<T> JODFCHOHCGI(string OOGMDAJCDJN);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "2")]
	POINLBCLAOC<T> MHGJMCPPFKE(OCOAGHCPNBA<T> FFCINNPFIJM);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "3")]
	POINLBCLAOC<T> LMJNAMIONBL(int KGBDOKDJBHH);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "4")]
	POINLBCLAOC<T> FCNECNOPHKB(int KGBDOKDJBHH, LNIAHDJNMLO<T> AMNFDNEAEAB);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface IMIOHGLICFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "0")]
	POINLBCLAOC<T> HIMIOKLHABC<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "1")]
	POMKKOHGLGJ KGJEOMFMOJH(Exception ANJHEGDKNFP);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HGDHJHLLJGP GBLCGHCLNOG(Exception ANJHEGDKNFP);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public delegate string OCOAGHCPNBA<in T>(T ANJHEGDKNFP) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public delegate int LNIAHDJNMLO<in T>(T ANJHEGDKNFP) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class OCKKLOPDHNJ : IMIOHGLICFJ
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private delegate string MPEANFPFEPB(Exception ANJHEGDKNFP);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private delegate int OHFAFGDNCFN(Exception ANJHEGDKNFP);

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class EAMKHJFFGDC<T> : POINLBCLAOC<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class MAPGPGLPBGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public MAPGPGLPBGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
			internal string AGCDBIOJNMG(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class ODLOFALJNEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public OCOAGHCPNBA<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public ODLOFALJNEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x4D840B0", Offset = "0x4D832B0", VA = "0x184D840B0")]
			internal string HJAGBLKFGAP(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class OAKNKJAMLNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public LNIAHDJNMLO<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public OAKNKJAMLNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x4D840B0", Offset = "0x4D832B0", VA = "0x184D840B0")]
			internal int MGKJMILLIHP(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private readonly OCKKLOPDHNJ HKBEPGHODHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private readonly Type AMBCJIHNOOB;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x3ECCE70", Offset = "0x3ECC070", VA = "0x183ECCE70")]
		internal EAMKHJFFGDC(OCKKLOPDHNJ HKBEPGHODHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x3ECCA90", Offset = "0x3ECBC90", VA = "0x183ECCA90", Slot = "4")]
		public void CCPBENMPBAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x3ECCBF0", Offset = "0x3ECBDF0", VA = "0x183ECCBF0", Slot = "5")]
		public POINLBCLAOC<T> JODFCHOHCGI(string OOGMDAJCDJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x3ECCD50", Offset = "0x3ECBF50", VA = "0x183ECCD50", Slot = "6")]
		public POINLBCLAOC<T> MHGJMCPPFKE(OCOAGHCPNBA<T> FFCINNPFIJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x3ECCD10", Offset = "0x3ECBF10", VA = "0x183ECCD10", Slot = "7")]
		public POINLBCLAOC<T> LMJNAMIONBL(int KGBDOKDJBHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x3ECCAC0", Offset = "0x3ECBCC0", VA = "0x183ECCAC0", Slot = "8")]
		public POINLBCLAOC<T> FCNECNOPHKB(int KGBDOKDJBHH, LNIAHDJNMLO<T> AMNFDNEAEAB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class IEFDBGKNNMG<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private bool NGEGDGBONKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly List<Type> IGDGIJHIOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private readonly Dictionary<Type, TVal> ECBLPBGCGDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private readonly Dictionary<Type, int> MOELIFGLLIN;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public IReadOnlyList<Type> KIJDOAFGIFC
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x45B2B20", Offset = "0x45B1D20", VA = "0x1845B2B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x45B2DF0", Offset = "0x45B1FF0", VA = "0x1845B2DF0")]
		public IEFDBGKNNMG(Dictionary<Type, int> MOELIFGLLIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x45B28E0", Offset = "0x45B1AE0", VA = "0x1845B28E0")]
		public void CKLHJOINNOK(Type OFPBICPHALF, TVal IAPIOFHOONE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x45B2C80", Offset = "0x45B1E80", VA = "0x1845B2C80")]
		public bool PKAKCCDMLLP(Type AMBCJIHNOOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x45B2AD0", Offset = "0x45B1CD0", VA = "0x1845B2AD0")]
		public bool IGDELPJLDKB(TVal OMEFCJCOLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x44C10C0", Offset = "0x44C02C0", VA = "0x1844C10C0")]
		public TVal BGMHNJIJIDG(Type MDOOANEGCAH)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x45B2990", Offset = "0x45B1B90", VA = "0x1845B2990")]
		[CompilerGenerated]
		private int HOMDPLKLNDH(Type BMHELHCJJMD, Type HLGPEJKOPCG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class ELDOALAFOKA : IEnumerable<HGDHJHLLJGP>, IEnumerable, IEnumerator<HGDHJHLLJGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private HGDHJHLLJGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public OCKKLOPDHNJ <>4__this;

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
		private IEnumerator<HGDHJHLLJGP> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private HGDHJHLLJGP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0x3FBAE20", Offset = "0x3FBA020", VA = "0x183FBAE20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(HGDHJHLLJGP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x796E390", Offset = "0x796D590", VA = "0x18796E390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xC45340", Offset = "0xC44540", VA = "0x180C45340")]
		[DebuggerHidden]
		public ELDOALAFOKA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x796E3E0", Offset = "0x796D5E0", VA = "0x18796E3E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x796DDD0", Offset = "0x796CFD0", VA = "0x18796DDD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x796DD80", Offset = "0x796CF80", VA = "0x18796DD80")]
		private void MHLANDJELDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x796DD30", Offset = "0x796CF30", VA = "0x18796DD30")]
		private void JELILPGANHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x796E340", Offset = "0x796D540", VA = "0x18796E340", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x796E280", Offset = "0x796D480", VA = "0x18796E280", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HGDHJHLLJGP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x796E280", Offset = "0x796D480", VA = "0x18796E280", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private static readonly HGDHJHLLJGP DLLFFKLJNHD;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private static readonly Dictionary<Type, int> FJPCCNDLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly HashSet<Type> BCEKNCOOLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly IEFDBGKNNMG<int> BLKMOOMEAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private readonly IEFDBGKNNMG<OHFAFGDNCFN> PBLCHCHGMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly IEFDBGKNNMG<MPEANFPFEPB> PLFLHPPJDIO;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x797B930", Offset = "0x797AB30", VA = "0x18797B930")]
	[NAOGKPPNIGE.PBOHCEMILCE.MHACPCJGMLG]
	internal static void BHMHEMCKFJH(JBPONICDCIO FJGJKHFLABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x797CD30", Offset = "0x797BF30", VA = "0x18797CD30")]
	[RecRoom.NoEngine.Common.Preserve]
	public OCKKLOPDHNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x304E4D0", Offset = "0x304D6D0", VA = "0x18304E4D0", Slot = "4")]
	public POINLBCLAOC<T> HIMIOKLHABC<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x797C800", Offset = "0x797BA00", VA = "0x18797C800", Slot = "5")]
	public POMKKOHGLGJ KGJEOMFMOJH(Exception ANJHEGDKNFP)
	{
		return default(POMKKOHGLGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x797BD90", Offset = "0x797AF90", VA = "0x18797BD90", Slot = "6")]
	public HGDHJHLLJGP GBLCGHCLNOG(Exception? ANJHEGDKNFP)
	{
		return default(HGDHJHLLJGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x797C260", Offset = "0x797B460", VA = "0x18797C260", Slot = "7")]
	[IteratorStateMachine(typeof(ELDOALAFOKA))]
	public IEnumerable<HGDHJHLLJGP> GGMNDHGCPCL(Exception ANJHEGDKNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x797C6B0", Offset = "0x797B8B0", VA = "0x18797C6B0", Slot = "8")]
	public string IBCEKIOKDMH(Exception? ANJHEGDKNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x797BA80", Offset = "0x797AC80", VA = "0x18797BA80")]
	private string FNPKNFBMAII(AggregateException NHOEPMFPJGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x797C300", Offset = "0x797B500", VA = "0x18797C300")]
	private void HCMCJBAPCPE(Type AMBCJIHNOOB, int KGBDOKDJBHH, OHFAFGDNCFN? HBFNBKOINMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x797C890", Offset = "0x797BA90", VA = "0x18797C890")]
	private void MBCDMCFAIBL(Type AMBCJIHNOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x797BF90", Offset = "0x797B190", VA = "0x18797BF90")]
	private void GDDLHAODLEI(Type AMBCJIHNOOB, MPEANFPFEPB LPIDGCCIKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x797CAE0", Offset = "0x797BCE0", VA = "0x18797CAE0")]
	private static int OANBGEPMJKF(Type AMBCJIHNOOB, Dictionary<Type, int> MOELIFGLLIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x3433AB0", Offset = "0x3432CB0", VA = "0x183433AB0")]
	private static bool PLOHEPLIDNM<TVal>(IEFDBGKNNMG<TVal> CJALOAIIOIM, Type AMBCJIHNOOB, [Out] TVal OMEFCJCOLII) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x797B9A0", Offset = "0x797ABA0", VA = "0x18797B9A0")]
	[CompilerGenerated]
	internal static int DGIJEJCPHIJ(Type KKILNJHNAKP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public struct POMKKOHGLGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public readonly HGDHJHLLJGP AAPILFGNDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public readonly string DCNEPMFNPGO;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7982FD0", Offset = "0x79821D0", VA = "0x187982FD0")]
	public POMKKOHGLGJ(string FCDPJHGPLMF, HGDHJHLLJGP KGBDOKDJBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7982F30", Offset = "0x7982130", VA = "0x187982F30")]
	public string DKJDBILEHPC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class EMHDMPCCNCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private readonly OFILAFCHFIJ IMKPLDEFAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private string MIOHMAEODLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private long? NDOJOCKFLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private long? PPJJOJDFAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private long? EFLNHPNHILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private string EPJCGINKJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private HODEGGJGEFG GIDLJBGCBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private long? DPDDCKKEPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private bool IFFFIFGALMM;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string KEABCGMEDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public long KLMJHKFKMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x796F2B0", Offset = "0x796E4B0", VA = "0x18796F2B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long NBNFNMHCKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x796E9B0", Offset = "0x796DBB0", VA = "0x18796E9B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public long IPBKFOPHFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x796E5B0", Offset = "0x796D7B0", VA = "0x18796E5B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public string MLMPADECCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x796F310", Offset = "0x796E510", VA = "0x18796F310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public HODEGGJGEFG LOJHOEFMKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xBFC380", Offset = "0xBFB580", VA = "0x180BFC380")]
		get
		{
			return default(HODEGGJGEFG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x796E610", Offset = "0x796D810", VA = "0x18796E610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public long GNLBBKKFOLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x796E700", Offset = "0x796D900", VA = "0x18796E700")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x796F350", Offset = "0x796E550", VA = "0x18796F350")]
	[UnityEngine.Scripting.Preserve]
	public EMHDMPCCNCO([FMJHJHHALCB(null)] OFILAFCHFIJ IMKPLDEFAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x796E760", Offset = "0x796D960", VA = "0x18796E760")]
	private void KFIJCOHEEFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x796EE20", Offset = "0x796E020", VA = "0x18796EE20")]
	public void NABPNKLHGAN(long MOMKFNIIPAA, long NPLPICCKAOE, [Optional] long? BBJKLNFMAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x796ED80", Offset = "0x796DF80", VA = "0x18796ED80")]
	public void MINNBBJIMAH(long BBJKLNFMAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x796E530", Offset = "0x796D730", VA = "0x18796E530")]
	public void BEMFAAPNFPI(string GOIOAGLFIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x796EA10", Offset = "0x796DC10", VA = "0x18796EA10")]
	public void MFMGOJKJGDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal class DDGKJPGGCCE : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct EKEAEMOFJFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder<FJJEHEJHICA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public FJJEHEJHICA roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public DDGKJPGGCCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private TaskAwaiter<FAOLIJLBMLP.PNMPADCMIPA<FJJEHEJHICA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x798BD60", Offset = "0x798AF60", VA = "0x18798BD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x798C2A0", Offset = "0x798B4A0", VA = "0x18798C2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct HFFFHHDDMEC<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class MIJLHCNIJDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public FJJEHEJHICA roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public MIJLHCNIJDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x7998ED0", Offset = "0x79980D0", VA = "0x187998ED0")]
		internal FJJEHEJHICA PPEJNGACKFP(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct LMGMFJFGAJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public AsyncTaskMethodBuilder<FAOLIJLBMLP.PNMPADCMIPA<FJJEHEJHICA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public FJJEHEJHICA roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public DDGKJPGGCCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private EIIFLLEBLHL <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private TaskAwaiter<FAOLIJLBMLP.PNMPADCMIPA<FJJEHEJHICA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x79975C0", Offset = "0x79967C0", VA = "0x1879975C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x7997BD0", Offset = "0x7996DD0", VA = "0x187997BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct MHFCIBOGBPO<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public DDGKJPGGCCE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4BEF5E0", Offset = "0x4BEE7E0", VA = "0x184BEF5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x3C222D0", Offset = "0x3C214D0", VA = "0x183C222D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct OGHIKDOIGCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public DDGKJPGGCCE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x79998C0", Offset = "0x7998AC0", VA = "0x1879998C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x7999A80", Offset = "0x7998C80", VA = "0x187999A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class CPHCKJNBDBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CPHCKJNBDBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x7988100", Offset = "0x7987300", VA = "0x187988100")]
		internal object NOJNHFADHKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x7988040", Offset = "0x7987240", VA = "0x187988040")]
		internal bool LNFNBNLIPPA(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class BPPEHDJEMAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BPPEHDJEMAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x79877B0", Offset = "0x79869B0", VA = "0x1879877B0")]
		internal object AMMKFHHNGJK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class CDGPOAENPPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CDGPOAENPPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x7987810", Offset = "0x7986A10", VA = "0x187987810")]
		internal object LCBCONKBPCK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class MFBGBJIFPKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public MFBGBJIFPKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x7998E60", Offset = "0x7998060", VA = "0x187998E60")]
		internal object KDNOCAFFFHL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class NGNOBIPDOJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public DDGKJPGGCCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public NGNOBIPDOJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x7998FB0", Offset = "0x79981B0", VA = "0x187998FB0")]
		internal object ELIGGCBOBNG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private static readonly Guid FIELCFDJGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public readonly AJHAEBBPGDJ LLCJPMCEFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly FAOLIJLBMLP BLOPGJOOLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private readonly CDBPHCGLHLE IBMNPFDADDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private readonly HMBFCOMKJMP MAJINAJPECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private bool OCNKOGFAPHD;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x798AE80", Offset = "0x798A080", VA = "0x18798AE80")]
	public DDGKJPGGCCE(AJHAEBBPGDJ AHMKJKELCNK, FAOLIJLBMLP BLOPGJOOLEN, CDBPHCGLHLE IBMNPFDADDO, HMBFCOMKJMP MAJINAJPECC, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7989E90", Offset = "0x7989090", VA = "0x187989E90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7989D70", Offset = "0x7988F70", VA = "0x187989D70")]
	public void APLBLFNCBCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x798A110", Offset = "0x7989310", VA = "0x18798A110")]
	public void HEALMKEJLBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x798A9F0", Offset = "0x7989BF0", VA = "0x18798A9F0")]
	public void NKACAHGJKFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x798A890", Offset = "0x7989A90", VA = "0x18798A890")]
	[AsyncStateMachine(typeof(EKEAEMOFJFP))]
	internal Task<FJJEHEJHICA> KKFNHPHCDBJ(EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, FJJEHEJHICA BGGCAOOLCME, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x30F25A0", Offset = "0x30F17A0", VA = "0x1830F25A0")]
	private static byte[] GMMFJOJKJBP<T>(T CBCJFCINKPJ) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x30F1F00", Offset = "0x30F1100", VA = "0x1830F1F00")]
	private static T CLGGNBNHPMK<T>(MessageParser<T> BJNIEHGGDLE, byte[] CBCJFCINKPJ, T BIFMINLMLMJ) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x7989FD0", Offset = "0x79891D0", VA = "0x187989FD0")]
	[AsyncStateMachine(typeof(LMGMFJFGAJC))]
	private Task<FAOLIJLBMLP.PNMPADCMIPA<FJJEHEJHICA>> FCMCODOHBIB(FJJEHEJHICA BGGCAOOLCME, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x30F2300", Offset = "0x30F1500", VA = "0x1830F2300")]
	[AsyncStateMachine(typeof(MHFCIBOGBPO<>))]
	internal Task<T> EOGLIHPFDGP<T>(CancellationToken LHPAGMJCDIN, Func<CancellationToken, Task<T>> JMADILOKOIC, int LFBGGOCEEOM = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7989EA0", Offset = "0x79890A0", VA = "0x187989EA0")]
	[AsyncStateMachine(typeof(OGHIKDOIGCA))]
	internal Task EOGLIHPFDGP(CancellationToken LHPAGMJCDIN, Func<CancellationToken, Task> JMADILOKOIC, int LFBGGOCEEOM = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7989CF0", Offset = "0x7988EF0", VA = "0x187989CF0")]
	public JNNFMHIKODD AEJDGHBHFFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x798A1D0", Offset = "0x79893D0", VA = "0x18798A1D0")]
	public DDGJKIMELJI IKBIJBNIDIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x798AC10", Offset = "0x7989E10", VA = "0x18798AC10")]
	public EPIGPGOPLEI OGCCCDNPLDO([Optional] KJMCEDJMPPA? MOKKIOIDAGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x798A5B0", Offset = "0x79897B0", VA = "0x18798A5B0")]
	public void KBMFAHMNCEA(Func<Guid, bool> DOCBDMOIFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x798AAB0", Offset = "0x7989CB0", VA = "0x18798AAB0")]
	public void NMIPMLLEJPE(Func<Guid, bool> EPIMEKNCHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x798A710", Offset = "0x7989910", VA = "0x18798A710")]
	public Guid KDLBMACPGNE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x798A4A0", Offset = "0x79896A0", VA = "0x18798A4A0")]
	public void JCOCKCOCGDI(Guid OFDLLNFHBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x798A360", Offset = "0x7989560", VA = "0x18798A360")]
	public void JAKKJEMCNKK(FJJEHEJHICA AAIHMKPLMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x798A250", Offset = "0x7989450", VA = "0x18798A250")]
	public void IKHOJNLBJOK(string CLCDJIINGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x30F25B0", Offset = "0x30F17B0", VA = "0x1830F25B0")]
	private T PBNPLFPGBLD<T>(T OMEFCJCOLII) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x798ABC0", Offset = "0x7989DC0", VA = "0x18798ABC0")]
	public void OFGGJMFANEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x30F2050", Offset = "0x30F1250", VA = "0x1830F2050")]
	[CompilerGenerated]
	internal static string DAKOHDHDMLL<T>(byte[] JIGDFCPIKCH, int ODKEIFCIJNC, HFFFHHDDMEC<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal sealed class ACIOLOAHLAM : AJHAEBBPGDJ
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class LKJOBLFJHNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public LKJOBLFJHNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x7997550", Offset = "0x7996750", VA = "0x187997550")]
		internal object PPJPMAAMDBO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct KDDABLDONNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public ACIOLOAHLAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public DDGKJPGGCCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private AFDGPAEKBBP <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private DDGJKIMELJI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x7994190", Offset = "0x7993390", VA = "0x187994190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x7994A60", Offset = "0x7993C60", VA = "0x187994A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct DJEHKKGIBEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public ACIOLOAHLAM <>4__this;

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
		private TaskAwaiter<OAOBEPBAJLE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x798B4C0", Offset = "0x798A6C0", VA = "0x18798B4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x798BC00", Offset = "0x798AE00", VA = "0x18798BC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct LCBMHJJGJHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public ACIOLOAHLAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private TaskAwaiter<GLPOHAHMIGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x79957E0", Offset = "0x79949E0", VA = "0x1879957E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x7995AF0", Offset = "0x7994CF0", VA = "0x187995AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class JPEKNCAOLBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public AFDGPAEKBBP presence;

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public JPEKNCAOLBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x7992970", Offset = "0x7991B70", VA = "0x187992970")]
		internal object JMBBLKIOGEK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private static readonly KJMCEDJMPPA OIEGFOBBFLM;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private static readonly KJMCEDJMPPA MGEGCNLLMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000389")]
	private readonly FENMDJFMHBI BFMLDAJIGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400038A")]
	private readonly KHDFIKJLGJL NMKEJBINBGE;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x7984380", Offset = "0x7983580", VA = "0x187984380")]
	public ACIOLOAHLAM(FENMDJFMHBI BFMLDAJIGMA, KHDFIKJLGJL NMKEJBINBGE, Guid DHNJGGKJENC, NDEJMCPCCDJ CNCOIDECOMJ, DAIEOJJKKMF OFMLNAKOOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x7983F50", Offset = "0x7983150", VA = "0x187983F50", Slot = "7")]
	[AsyncStateMachine(typeof(KDDABLDONNM))]
	protected override Task KOMCNMEPJEP(DDGKJPGGCCE NEMIMEMMONE, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x7984090", Offset = "0x7983290", VA = "0x187984090")]
	[AsyncStateMachine(typeof(DJEHKKGIBEM))]
	private Task PNAKMFDHLEC(CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x7984190", Offset = "0x7983390", VA = "0x187984190")]
	[AsyncStateMachine(typeof(LCBMHJJGJHE))]
	private Task<int> POHMEIDLAKB(CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x7983D80", Offset = "0x7982F80", VA = "0x187983D80")]
	private AFDGPAEKBBP KLBDOAALDLI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class KLJKNBJNFJJ : AJHAEBBPGDJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct LBHFJOMBIIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public KLJKNBJNFJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public DDGKJPGGCCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private TaskAwaiter<NMGIKLONOMM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x7994DE0", Offset = "0x7993FE0", VA = "0x187994DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x7995780", Offset = "0x7994980", VA = "0x187995780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private readonly int PGKHOOJPHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	private readonly AOCJALDHGHI EFHNEIIGJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public readonly long KLKOLHDJPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public readonly long OIHFCDFMIJF;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public NMGIKLONOMM IJJDKHLOHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x8F91C0", Offset = "0x8F83C0", VA = "0x1808F91C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x8F9280", Offset = "0x8F8480", VA = "0x1808F9280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x7994BE0", Offset = "0x7993DE0", VA = "0x187994BE0")]
	public KLJKNBJNFJJ(Guid DHNJGGKJENC, NDEJMCPCCDJ CNCOIDECOMJ, DAIEOJJKKMF OFMLNAKOOLK, int PGKHOOJPHID, AOCJALDHGHI EFHNEIIGJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x7994AC0", Offset = "0x7993CC0", VA = "0x187994AC0", Slot = "7")]
	[AsyncStateMachine(typeof(LBHFJOMBIIF))]
	protected override Task KOMCNMEPJEP(DDGKJPGGCCE NEMIMEMMONE, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class BFFNAAEHAJI : AJHAEBBPGDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class KNEMKKGNOND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public BFFNAAEHAJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public LIMEANOPOBG playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public KNEMKKGNOND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x7994D10", Offset = "0x7993F10", VA = "0x187994D10")]
		internal Task GJBOICDGCGI(EKKGOIIBGNN<string>.KJLMKGNBAOG postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x7994D50", Offset = "0x7993F50", VA = "0x187994D50")]
		internal object PJLBJJPHEAB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct OHFLCPHFHLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public BFFNAAEHAJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public DDGKJPGGCCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private KNEMKKGNOND <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x7999AE0", Offset = "0x7998CE0", VA = "0x187999AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x799A2B0", Offset = "0x79994B0", VA = "0x18799A2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct PFEDEJKEACN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public LIMEANOPOBG playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public BFFNAAEHAJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x799AD00", Offset = "0x7999F00", VA = "0x18799AD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x799B2A0", Offset = "0x799A4A0", VA = "0x18799B2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x7986CB0", Offset = "0x7985EB0", VA = "0x187986CB0")]
	public BFFNAAEHAJI(Guid DHNJGGKJENC, NDEJMCPCCDJ CNCOIDECOMJ, DAIEOJJKKMF OFMLNAKOOLK, string IAKPNFBDIJE, NGLFBMMEGBN MFHJGCFBFIG, bool MPGCOBIEFDD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x7986B70", Offset = "0x7985D70", VA = "0x187986B70", Slot = "7")]
	[AsyncStateMachine(typeof(OHFLCPHFHLO))]
	protected override Task KOMCNMEPJEP(DDGKJPGGCCE NEMIMEMMONE, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task OEIIGLIDHIH(DDGKJPGGCCE NEMIMEMMONE, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x7986A30", Offset = "0x7985C30", VA = "0x187986A30")]
	[AsyncStateMachine(typeof(PFEDEJKEACN))]
	private Task JIFFGGIGNFM(IDisposable JFDOLOHMDNC, LIMEANOPOBG DLNNLODKFFB, EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class GOHAAENAHMP : AJHAEBBPGDJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct PPEACDEFEGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public GOHAAENAHMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public DDGKJPGGCCE operationContext;

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
		private TaskAwaiter<AGCEOGPCGMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x799B300", Offset = "0x799A500", VA = "0x18799B300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x799B870", Offset = "0x799AA70", VA = "0x18799B870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly JBGHPJPHEMA IMGJKIKFHHF;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x798D8A0", Offset = "0x798CAA0", VA = "0x18798D8A0")]
	public GOHAAENAHMP(Guid DHNJGGKJENC, NDEJMCPCCDJ CNCOIDECOMJ, DAIEOJJKKMF OFMLNAKOOLK, JBGHPJPHEMA IMGJKIKFHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x798D7C0", Offset = "0x798C9C0", VA = "0x18798D7C0", Slot = "6")]
	protected override string NMGMIMGOGGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x798D6A0", Offset = "0x798C8A0", VA = "0x18798D6A0", Slot = "7")]
	[AsyncStateMachine(typeof(PPEACDEFEGI))]
	protected override Task KOMCNMEPJEP(DDGKJPGGCCE NEMIMEMMONE, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal abstract class AJHAEBBPGDJ : OONPCCCGCKE
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public delegate Task ANLPAIFANKL(EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class HICDMMFOPMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public AJHAEBBPGDJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public HICDMMFOPMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x798FC80", Offset = "0x798EE80", VA = "0x18798FC80")]
		internal Task HLJCHNJBCNI(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class IMJBJIMENFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public HICDMMFOPMK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public IMJBJIMENFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x7991D10", Offset = "0x7990F10", VA = "0x187991D10")]
		internal object AJDHLMNACLD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct IEMGCKFDHNA : IAsyncStateMachine
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
		public AJHAEBBPGDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public Func<AJHAEBBPGDJ, EKKGOIIBGNN<string>.KJLMKGNBAOG, DDGKJPGGCCE> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private HICDMMFOPMK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private DDGKJPGGCCE <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private TaskAwaiter<FJJEHEJHICA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x7990AF0", Offset = "0x798FCF0", VA = "0x187990AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x7991CB0", Offset = "0x7990EB0", VA = "0x187991CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct LCDLJDGHNBD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7995B60", Offset = "0x7994D60", VA = "0x187995B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x7996600", Offset = "0x7995800", VA = "0x187996600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct AEBDOLDNFNN : IAsyncStateMachine
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
		public AJHAEBBPGDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x79849D0", Offset = "0x7983BD0", VA = "0x1879849D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x7984D30", Offset = "0x7983F30", VA = "0x187984D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public readonly Guid PIPBAHFEAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public readonly ByteString PIAHJNGFBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public readonly DAIEOJJKKMF FIFLFGLNKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	protected readonly string IONNOHKLCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly NDEJMCPCCDJ CNCOIDECOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly bool MPGCOBIEFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly Queue<ANLPAIFANKL> FGMBNPOOACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly OCHAGJHGHGK BAKIBIFOLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private readonly NGLFBMMEGBN MFHJGCFBFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private bool NDGDJMONLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public HODEGGJGEFG PJFNHJHHGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public HODEGGJGEFG PMDGDAEDCKO;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public NDEJMCPCCDJ PGNLDHEDIJE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0E0", Offset = "0x8FA2E0", VA = "0x1808FB0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public LMIBFAPANNF FFGEEHIBEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x7985EE0", Offset = "0x79850E0", VA = "0x187985EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public EMIODIFKEJC NHBGKKKLKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x7985820", Offset = "0x7984A20", VA = "0x187985820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public AOMKKEDLMKB INFDKHDKCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x7985CF0", Offset = "0x7984EF0", VA = "0x187985CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event ELLICKCNDDG MCGNEMECJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x7985CB0", Offset = "0x7984EB0", VA = "0x187985CB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x7985C90", Offset = "0x7984E90", VA = "0x187985C90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x79860F0", Offset = "0x79852F0", VA = "0x1879860F0")]
	protected AJHAEBBPGDJ(Guid DHNJGGKJENC, NDEJMCPCCDJ CNCOIDECOMJ, DAIEOJJKKMF OFMLNAKOOLK, string IAKPNFBDIJE, NGLFBMMEGBN MFHJGCFBFIG, bool MPGCOBIEFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x7985F90", Offset = "0x7985190", VA = "0x187985F90", Slot = "6")]
	protected virtual string NMGMIMGOGGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x7985F30", Offset = "0x7985130", VA = "0x187985F30")]
	public void NMADNDBLBGK(ANLPAIFANKL IDGNMNKCFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x7985CD0", Offset = "0x7984ED0", VA = "0x187985CD0")]
	protected void IPACHJIEKNA(float GBPBPMJPBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x79856D0", Offset = "0x79848D0", VA = "0x1879856D0")]
	[AsyncStateMachine(typeof(IEMGCKFDHNA))]
	public Task BOIJOOGLJMA(CancellationToken BGEKICMONBE, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, [Optional] Func<AJHAEBBPGDJ, EKKGOIIBGNN<string>.KJLMKGNBAOG, DDGKJPGGCCE> MFNMEPNKPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x79855A0", Offset = "0x79847A0", VA = "0x1879855A0")]
	[AsyncStateMachine(typeof(LCDLJDGHNBD))]
	private static Task ADBMJAMLHJD(Func<CancellationToken, Task> FABDJIIPNKM, Func<CancellationToken, Task> CEFDCKGKAGO, CancellationToken LHPAGMJCDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x7985D70", Offset = "0x7984F70", VA = "0x187985D70")]
	private void MLAOACDMENJ(bool GMKDNLPGIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x7985870", Offset = "0x7984A70", VA = "0x187985870")]
	private void DFAFBKHBLKE(DDGKJPGGCCE NEMIMEMMONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task KOMCNMEPJEP(DDGKJPGGCCE NEMIMEMMONE, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x7985FD0", Offset = "0x79851D0", VA = "0x187985FD0")]
	[AsyncStateMachine(typeof(AEBDOLDNFNN))]
	private Task OMOFAEIANFO(EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x7985C10", Offset = "0x7984E10", VA = "0x187985C10")]
	public FJJEHEJHICA FJBHMOPMOFB(EIIFLLEBLHL FNDMDBAKPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x7985AA0", Offset = "0x7984CA0", VA = "0x187985AA0")]
	[CompilerGenerated]
	private Task EJHPFBIPOJB(CancellationToken EBJDGDIMGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x7985B90", Offset = "0x7984D90", VA = "0x187985B90")]
	[CompilerGenerated]
	private object FIKNHAGKDCN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal sealed class AHJNJJCOPDN : BFFNAAEHAJI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct CHDFCLNMILD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public AHJNJJCOPDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public DDGKJPGGCCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private IAFPHBAAAOE <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private DDGJKIMELJI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x7987880", Offset = "0x7986A80", VA = "0x187987880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x7987FE0", Offset = "0x79871E0", VA = "0x187987FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	private readonly FENMDJFMHBI HENLCLFBCAF;

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x7984EE0", Offset = "0x79840E0", VA = "0x187984EE0")]
	public AHJNJJCOPDN(Guid DHNJGGKJENC, NDEJMCPCCDJ CNCOIDECOMJ, FENMDJFMHBI HENLCLFBCAF, DAIEOJJKKMF OFMLNAKOOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x7984D90", Offset = "0x7983F90", VA = "0x187984D90", Slot = "8")]
	[AsyncStateMachine(typeof(CHDFCLNMILD))]
	protected override Task OEIIGLIDHIH(DDGKJPGGCCE NEMIMEMMONE, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class GMLEINIAJGJ : AJHAEBBPGDJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct DFCAIJDOGLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public GMLEINIAJGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public DDGKJPGGCCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private TaskAwaiter<AGCEOGPCGMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x798B0B0", Offset = "0x798A2B0", VA = "0x18798B0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x798B460", Offset = "0x798A660", VA = "0x18798B460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly string FNMKMGLDFDM;

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x798D5F0", Offset = "0x798C7F0", VA = "0x18798D5F0")]
	public GMLEINIAJGJ(Guid DHNJGGKJENC, NDEJMCPCCDJ CNCOIDECOMJ, DAIEOJJKKMF OFMLNAKOOLK, string FNMKMGLDFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x798D4E0", Offset = "0x798C6E0", VA = "0x18798D4E0", Slot = "7")]
	[AsyncStateMachine(typeof(DFCAIJDOGLL))]
	protected override Task KOMCNMEPJEP(DDGKJPGGCCE NEMIMEMMONE, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal class KBJGFKOBNFL : BFFNAAEHAJI
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class NMHMONBDOHD
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
			public AsyncTaskMethodBuilder<FJJEHEJHICA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			public NMHMONBDOHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041C")]
			private TaskAwaiter<AGCEOGPCGMI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			private TaskAwaiter<FJJEHEJHICA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(RVA = "0x799CDE0", Offset = "0x799BFE0", VA = "0x18799CDE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x799D2A0", Offset = "0x799C4A0", VA = "0x18799D2A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public KBJGFKOBNFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public EPIGPGOPLEI serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public GBJAOKNDKME roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public JNNFMHIKODD uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public DGKJNLAJLBC roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public NMHMONBDOHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x79991F0", Offset = "0x79983F0", VA = "0x1879991F0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<FJJEHEJHICA> KGOBOALBNAJ(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct FMGCCKIDLCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public KBJGFKOBNFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public DDGKJPGGCCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private NMHMONBDOHD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private IAFPHBAAAOE <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private DDGJKIMELJI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private FJJEHEJHICA <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private TaskAwaiter<FJJEHEJHICA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x798C510", Offset = "0x798B710", VA = "0x18798C510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x798D480", Offset = "0x798C680", VA = "0x18798D480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private static readonly KJMCEDJMPPA OIEGFOBBFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private readonly int KGAFBFCLOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	[CanBeNull]
	private readonly CNHGMGKGANK BLHOFKCFNMK;

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x79940E0", Offset = "0x79932E0", VA = "0x1879940E0")]
	public KBJGFKOBNFL(Guid DHNJGGKJENC, NDEJMCPCCDJ CNCOIDECOMJ, int KGAFBFCLOFM, CNHGMGKGANK BLHOFKCFNMK, DAIEOJJKKMF OFMLNAKOOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x7993EF0", Offset = "0x79930F0", VA = "0x187993EF0", Slot = "8")]
	[AsyncStateMachine(typeof(FMGCCKIDLCH))]
	protected override Task OEIIGLIDHIH(DDGKJPGGCCE NEMIMEMMONE, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x7993DF0", Offset = "0x7992FF0", VA = "0x187993DF0")]
	private void JMIJLPJLJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x7993C20", Offset = "0x7992E20", VA = "0x187993C20")]
	private void FPHFJKJOAJG(EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, IAFPHBAAAOE ABMEFKHBMNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal abstract class AKGDKLIBGAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public readonly AJHAEBBPGDJ LLCJPMCEFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public readonly DDGKJPGGCCE IBLOCKPOBGD;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public LMIBFAPANNF FFGEEHIBEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x7986400", Offset = "0x7985600", VA = "0x187986400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public AOMKKEDLMKB INFDKHDKCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x7986370", Offset = "0x7985570", VA = "0x187986370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x7986450", Offset = "0x7985650", VA = "0x187986450")]
	protected AKGDKLIBGAN(DDGKJPGGCCE NEMIMEMMONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x7986250", Offset = "0x7985450", VA = "0x187986250")]
	protected void IKHOJNLBJOK(string CLCDJIINGKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal struct AIICDGJHKLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public Dictionary<Guid, List<PHMDAGGHOIA>> FDCOPEDODBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public Dictionary<Guid, List<PHMDAGGHOIA>> JLONGHAGHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public Dictionary<Guid, List<PHMDAGGHOIA>> IELBFCANKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public List<Guid> GBCMMNLFDEF;

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x7984F90", Offset = "0x7984190", VA = "0x187984F90")]
	public static AIICDGJHKLD BGMHNJIJIDG(LMIBFAPANNF CKNLAJJPLCN, HODEGGJGEFG EJNJIIKKDCB, GHIJJJNKODG ELGFNCMNGAO)
	{
		return default(AIICDGJHKLD);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct PNMEAGHIANG
{
	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0")]
	public static PNMEAGHIANG LHPCDDMHIBB()
	{
		return default(PNMEAGHIANG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct BNDBLCIOFNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public readonly OAOBEPBAJLE BGDELDLHBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public readonly CNMPJHKKKIM PIBGHFKDAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public readonly string BJIJJHHLOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public readonly GLPHDJDILNO JBBABNEKIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public readonly GLPHDJDILNO KEOAELBKNOE;

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x7987730", Offset = "0x7986930", VA = "0x187987730")]
	public BNDBLCIOFNJ(OAOBEPBAJLE BGDELDLHBMB, CNMPJHKKKIM PIBGHFKDAOK, string BJIJJHHLOJN, GLPHDJDILNO JBBABNEKIMJ, GLPHDJDILNO KEOAELBKNOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct ADJIHJOJFHD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private readonly DDGKJPGGCCE NEMIMEMMONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly Guid OFDLLNFHBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private bool GMKDNLPGIGD;

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x7984800", Offset = "0x7983A00", VA = "0x187984800")]
	public static ADJIHJOJFHD KDLBMACPGNE(DDGKJPGGCCE NEMIMEMMONE)
	{
		return default(ADJIHJOJFHD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0xFE8BA0", Offset = "0xFE7DA0", VA = "0x180FE8BA0")]
	public void NBOAGILOIDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x7984510", Offset = "0x7983710", VA = "0x187984510", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x7984830", Offset = "0x7983A30", VA = "0x187984830")]
	private ADJIHJOJFHD(DDGKJPGGCCE NEMIMEMMONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x79845C0", Offset = "0x79837C0", VA = "0x1879845C0")]
	private void JCOCKCOCGDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x7984520", Offset = "0x7983720", VA = "0x187984520")]
	private Func<Guid, bool> FMKHBLOLKJG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal class DDGJKIMELJI : AKGDKLIBGAN, OONPCCCGCKE
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	public delegate Task<HODEGGJGEFG> EKALDBBIHOL(GHIJJJNKODG LFDKFEEPNFP, JNGBCHHMFIN CKPDJGKIGII, OCHAGJHGHGK NMPJEHAAKFP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct HNOFPDDJEPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public FENMDJFMHBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private ADJIHJOJFHD <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private TaskAwaiter<FJJEHEJHICA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x7990310", Offset = "0x798F510", VA = "0x187990310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7990A90", Offset = "0x798FC90", VA = "0x187990A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct BKCJILBGLAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public AsyncTaskMethodBuilder<FJJEHEJHICA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public FENMDJFMHBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private TaskAwaiter<FJJEHEJHICA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x7986D00", Offset = "0x7985F00", VA = "0x187986D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x7987130", Offset = "0x7986330", VA = "0x187987130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct HCJMCOBGLON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public FENMDJFMHBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x798D940", Offset = "0x798CB40", VA = "0x18798D940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x798DF80", Offset = "0x798D180", VA = "0x18798DF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class HLFBFINLEOK
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
			public AsyncTaskMethodBuilder<BNDBLCIOFNJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public HLFBFINLEOK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private BNDBLCIOFNJ <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			private TaskAwaiter<HODEGGJGEFG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			private TaskAwaiter<BNDBLCIOFNJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(RVA = "0x799B8D0", Offset = "0x799AAD0", VA = "0x18799B8D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x799C030", Offset = "0x799B230", VA = "0x18799C030", Slot = "5")]
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
			public AsyncTaskMethodBuilder<GHIJJJNKODG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public HLFBFINLEOK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private GHIJJJNKODG <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			private TaskAwaiter<HODEGGJGEFG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			private TaskAwaiter<GHIJJJNKODG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x799C0A0", Offset = "0x799B2A0", VA = "0x18799C0A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x799C6D0", Offset = "0x799B8D0", VA = "0x18799C6D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public FENMDJFMHBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public OCHAGJHGHGK preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public OCHAGJHGHGK downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public BNDBLCIOFNJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public OCHAGJHGHGK postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public GHIJJJNKODG phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public JEBAGMAELAD.ALKCOCMPHGB <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public HLFBFINLEOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x798FED0", Offset = "0x798F0D0", VA = "0x18798FED0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<BNDBLCIOFNJ> JBKGELOHCOP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x798FDB0", Offset = "0x798EFB0", VA = "0x18798FDB0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<GHIJJJNKODG> CNADOLPFPKO(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x79902D0", Offset = "0x798F4D0", VA = "0x1879902D0")]
		internal void PFABLCCLHCC(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x7990170", Offset = "0x798F370", VA = "0x187990170")]
		internal Task LHFMKHDIMKA(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x7990010", Offset = "0x798F210", VA = "0x187990010")]
		internal Task KKGHCBCDHAB(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct HFBHDMINLJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public FENMDJFMHBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private HLFBFINLEOK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter<BNDBLCIOFNJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private TaskAwaiter<GHIJJJNKODG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x798EED0", Offset = "0x798E0D0", VA = "0x18798EED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x798FC20", Offset = "0x798EE20", VA = "0x18798FC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct HENEPGGJBJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public GHIJJJNKODG phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public OCHAGJHGHGK postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private TaskAwaiter<HODEGGJGEFG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private JNGBCHHMFIN <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x798DFE0", Offset = "0x798D1E0", VA = "0x18798DFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x798EE70", Offset = "0x798E070", VA = "0x18798EE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct INNGLEDLJMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x7991DD0", Offset = "0x7990FD0", VA = "0x187991DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x7992690", Offset = "0x7991890", VA = "0x187992690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct OKCABBHDLLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public OCHAGJHGHGK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private TaskAwaiter<HODEGGJGEFG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x799A310", Offset = "0x7999510", VA = "0x18799A310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x799ACA0", Offset = "0x7999EA0", VA = "0x18799ACA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct MALKEABDKED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public AsyncTaskMethodBuilder<HODEGGJGEFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public OCHAGJHGHGK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private TaskAwaiter<HODEGGJGEFG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x7997C40", Offset = "0x7996E40", VA = "0x187997C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x7998DF0", Offset = "0x7997FF0", VA = "0x187998DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct KBBLFMDPJCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public AsyncTaskMethodBuilder<HODEGGJGEFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public OCHAGJHGHGK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public JNGBCHHMFIN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private TaskAwaiter<HODEGGJGEFG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x7992AB0", Offset = "0x7991CB0", VA = "0x187992AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x7993BB0", Offset = "0x7992DB0", VA = "0x187993BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct AMPELKCMAOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public AsyncTaskMethodBuilder<HODEGGJGEFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public HODEGGJGEFG operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public OCHAGJHGHGK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public GHIJJJNKODG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private TaskAwaiter<HODEGGJGEFG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x79864B0", Offset = "0x79856B0", VA = "0x1879864B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x7986750", Offset = "0x7985950", VA = "0x187986750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class AOPGBBFHFNM
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
			public AsyncTaskMethodBuilder<HODEGGJGEFG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			public AOPGBBFHFNM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			private OODALMMDODD <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			private TaskAwaiter<HODEGGJGEFG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x799C740", Offset = "0x799B940", VA = "0x18799C740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x799CD70", Offset = "0x799BF70", VA = "0x18799CD70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public OCHAGJHGHGK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public EKALDBBIHOL masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public JNGBCHHMFIN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public HODEGGJGEFG originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public AOPGBBFHFNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x7986910", Offset = "0x7985B10", VA = "0x187986910")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<HODEGGJGEFG> OLECNOMPGHA(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct BNACAKPLEMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public AsyncTaskMethodBuilder<HODEGGJGEFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public OCHAGJHGHGK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public EKALDBBIHOL masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public JNGBCHHMFIN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private TaskAwaiter<HODEGGJGEFG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x79871A0", Offset = "0x79863A0", VA = "0x1879871A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x79876C0", Offset = "0x79868C0", VA = "0x1879876C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct ODJCPMPOJKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public OCHAGJHGHGK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private HODEGGJGEFG <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private IEnumerator<HODEGGJGEFG> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TaskAwaiter<HODEGGJGEFG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x7999310", Offset = "0x7998510", VA = "0x187999310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x7999860", Offset = "0x7998A60", VA = "0x187999860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct JJHJFNFDAKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x79926F0", Offset = "0x79918F0", VA = "0x1879926F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x7992910", Offset = "0x7991B10", VA = "0x187992910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct FACIFHGGHAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x798C310", Offset = "0x798B510", VA = "0x18798C310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x798C4B0", Offset = "0x798B6B0", VA = "0x18798C4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct LKDCBMKMHFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public GHIJJJNKODG phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public OCHAGJHGHGK postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private TaskAwaiter<HODEGGJGEFG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private JNGBCHHMFIN <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x7996660", Offset = "0x7995860", VA = "0x187996660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x79974F0", Offset = "0x79966F0", VA = "0x1879974F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct NGEHNJDBEOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public AsyncTaskMethodBuilder<HODEGGJGEFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public DDGJKIMELJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public OCHAGJHGHGK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private TaskAwaiter<HODEGGJGEFG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x79B1BB0", Offset = "0x79B0DB0", VA = "0x1879B1BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x79B28B0", Offset = "0x79B1AB0", VA = "0x1879B28B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly IGCCAEFBMNB LMNLHNGJPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly IGCCAEFBMNB JGJDNBLNILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private readonly EMHDMPCCNCO CIBHCCPALDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private readonly LFLHGOJIEEM GHAPLHOCKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly GFCDNFMOCHO HBDJOLPGPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private ProfilerCounterValue<int> ELODHOBECDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private readonly IMPDAEGGLLG ICLEMLLPCLF;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private NDEJMCPCCDJ PGNLDHEDIJE
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x7988680", Offset = "0x7987880", VA = "0x187988680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event ELLICKCNDDG MCGNEMECJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x79893B0", Offset = "0x79885B0", VA = "0x1879893B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x7989210", Offset = "0x7988410", VA = "0x187989210", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x7989A30", Offset = "0x7988C30", VA = "0x187989A30")]
	public DDGJKIMELJI(DDGKJPGGCCE NEMIMEMMONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x79882C0", Offset = "0x79874C0", VA = "0x1879882C0")]
	[AsyncStateMachine(typeof(HNOFPDDJEPP))]
	public Task AKNBOOJJAAL(FENMDJFMHBI JLBJPEIMAMB, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x79886D0", Offset = "0x79878D0", VA = "0x1879886D0")]
	[AsyncStateMachine(typeof(BKCJILBGLAK))]
	private Task<FJJEHEJHICA> COFDNMHCGNI(FENMDJFMHBI JLBJPEIMAMB, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x7988540", Offset = "0x7987740", VA = "0x187988540")]
	[AsyncStateMachine(typeof(HCJMCOBGLON))]
	private Task CFCJKNCGHAD(FENMDJFMHBI JLBJPEIMAMB, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x7989070", Offset = "0x7988270", VA = "0x187989070")]
	[AsyncStateMachine(typeof(HFBHDMINLJJ))]
	private Task GFGDCEMCALK(FENMDJFMHBI JLBJPEIMAMB, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken GEIFBLFOBNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x79893F0", Offset = "0x79885F0", VA = "0x1879893F0")]
	[AsyncStateMachine(typeof(HENEPGGJBJA))]
	private Task KDFKLAGJCBC(GHIJJJNKODG JFNGFPGMMPM, OCHAGJHGHGK HGPOKCEMEPM, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BMBLGCCIFPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x7988CC0", Offset = "0x7987EC0", VA = "0x187988CC0")]
	[AsyncStateMachine(typeof(INNGLEDLJMH))]
	private Task EOHLCKFPFJP(EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x7988F20", Offset = "0x7988120", VA = "0x187988F20")]
	[AsyncStateMachine(typeof(OKCABBHDLLN))]
	private Task GDOJEFONBPA(GHIJJJNKODG LFDKFEEPNFP, OCHAGJHGHGK NMPJEHAAKFP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x7988830", Offset = "0x7987A30", VA = "0x187988830")]
	[AsyncStateMachine(typeof(MALKEABDKED))]
	private Task<HODEGGJGEFG> DHFPPAIENEG(GHIJJJNKODG LFDKFEEPNFP, JNGBCHHMFIN NJHFBODDILP, OCHAGJHGHGK NMPJEHAAKFP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x79898B0", Offset = "0x7988AB0", VA = "0x1879898B0")]
	[AsyncStateMachine(typeof(KBBLFMDPJCD))]
	private Task<HODEGGJGEFG> PMOPMOOKDOK(GHIJJJNKODG LFDKFEEPNFP, JNGBCHHMFIN NJHFBODDILP, OCHAGJHGHGK NMPJEHAAKFP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x7989580", Offset = "0x7988780", VA = "0x187989580")]
	[AsyncStateMachine(typeof(AMPELKCMAOJ))]
	private Task<HODEGGJGEFG> NKENBAGLEPN(HODEGGJGEFG EJNJIIKKDCB, GHIJJJNKODG ELGFNCMNGAO, OCHAGJHGHGK NMPJEHAAKFP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE, bool NGPGAPEHMLI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x7988410", Offset = "0x7987610", VA = "0x187988410")]
	private bool AKOGGKLLEAM(GHIJJJNKODG JFNGFPGMMPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x7988B30", Offset = "0x7987D30", VA = "0x187988B30")]
	[AsyncStateMachine(typeof(BNACAKPLEMI))]
	protected Task<HODEGGJGEFG> ELIBNENKGFM(GHIJJJNKODG LFDKFEEPNFP, JNGBCHHMFIN NJHFBODDILP, OCHAGJHGHGK NMPJEHAAKFP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE, EKALDBBIHOL CALICMCFFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x7989720", Offset = "0x7988920", VA = "0x187989720")]
	[AsyncStateMachine(typeof(ODJCPMPOJKI))]
	private Task PCCOGHIEAAG(GHIJJJNKODG LFDKFEEPNFP, OCHAGJHGHGK NMPJEHAAKFP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x7988990", Offset = "0x7987B90", VA = "0x187988990")]
	private void DPBHFAGOAMO(HODEGGJGEFG BIKADPJEGPF, OCHAGJHGHGK NMPJEHAAKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x7989870", Offset = "0x7988A70", VA = "0x187989870")]
	private void PLDOPOOJKJF(HODEGGJGEFG DFPOGMPNDJO, [Out] HODEGGJGEFG IFDFIPAKHHC, [Out] HODEGGJGEFG CMNFDLIGIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x7989280", Offset = "0x7988480", VA = "0x187989280")]
	private Task<BNDBLCIOFNJ> HLFCDACIMEP(FENMDJFMHBI JLBJPEIMAMB, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x79891B0", Offset = "0x79883B0", VA = "0x1879891B0")]
	private Task<GHIJJJNKODG> GHLCHLOGBCI(BNDBLCIOFNJ LFDKFEEPNFP, JEBAGMAELAD.ALKCOCMPHGB HKLIEGDHCBF, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x79889E0", Offset = "0x7987BE0", VA = "0x1879889E0")]
	[AsyncStateMachine(typeof(JJHJFNFDAKM))]
	private Task EAMLJLACFDL(GHIJJJNKODG LFDKFEEPNFP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE, bool JDFDKNFKIFN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x79892C0", Offset = "0x79884C0", VA = "0x1879892C0")]
	[AsyncStateMachine(typeof(FACIFHGGHAC))]
	private Task HMHHPMLDLBE(GHIJJJNKODG LFDKFEEPNFP, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x7989540", Offset = "0x7988740", VA = "0x187989540")]
	private Task LIFLOCADLNI(GHIJJJNKODG LFDKFEEPNFP, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x79886B0", Offset = "0x79878B0", VA = "0x1879886B0")]
	private Task CLAAFCFCKLB(GHIJJJNKODG LFDKFEEPNFP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x7988520", Offset = "0x7987720", VA = "0x187988520")]
	private Task CCHODPHDEPH(GHIJJJNKODG LFDKFEEPNFP, JNGBCHHMFIN NJHFBODDILP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x7989700", Offset = "0x7988900", VA = "0x187989700")]
	private Task OJOAAPMIENI(GHIJJJNKODG LFDKFEEPNFP, JNGBCHHMFIN NJHFBODDILP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x7989570", Offset = "0x7988770", VA = "0x187989570")]
	private static Task LLCHACNHLND(CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x79891F0", Offset = "0x79883F0", VA = "0x1879891F0")]
	private Task GLBJEMJCPPE(GHIJJJNKODG LFDKFEEPNFP, JNGBCHHMFIN NJHFBODDILP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x7988500", Offset = "0x7987700", VA = "0x187988500")]
	private Task APAEJHBBNPL(GHIJJJNKODG LFDKFEEPNFP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x7989230", Offset = "0x7988430", VA = "0x187989230")]
	private void HHLHJOINOLK(FENMDJFMHBI JLBJPEIMAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x79893D0", Offset = "0x79885D0", VA = "0x1879893D0")]
	public void IBJNDABCHKK(long BBJKLNFMAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
	private static void ALBNBKAHLOO(OAOBEPBAJLE BGDELDLHBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x7988DD0", Offset = "0x7987FD0", VA = "0x187988DD0")]
	[AsyncStateMachine(typeof(LKDCBMKMHFL))]
	private Task FAIFEEIJIKC(GHIJJJNKODG JFNGFPGMMPM, OCHAGJHGHGK HGPOKCEMEPM, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BMBLGCCIFPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x7988160", Offset = "0x7987360", VA = "0x187988160")]
	[AsyncStateMachine(typeof(NGEHNJDBEOK))]
	[CompilerGenerated]
	private Task<HODEGGJGEFG> AKGBAKFEPOK(GHIJJJNKODG LFDKFEEPNFP, JNGBCHHMFIN NJHFBODDILP, OCHAGJHGHGK NMPJEHAAKFP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct HEFGOMLNEFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private NDEJMCPCCDJ CNCOIDECOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private GHIJJJNKODG LFDKFEEPNFP;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private LMIBFAPANNF FFGEEHIBEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x79A7A60", Offset = "0x79A6C60", VA = "0x1879A7A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x79A7770", Offset = "0x79A6970", VA = "0x1879A7770")]
	public static Task BOIJOOGLJMA(NDEJMCPCCDJ CNCOIDECOMJ, GHIJJJNKODG LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x79A7850", Offset = "0x79A6A50", VA = "0x1879A7850")]
	private void BOIJOOGLJMA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct DDAMDMOCAEC
{
	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x79A2040", Offset = "0x79A1240", VA = "0x1879A2040")]
	public static Task BOIJOOGLJMA(CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct PPLENKBIJJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct LDPLKPANDIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public DDGKJPGGCCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x79ADF30", Offset = "0x79AD130", VA = "0x1879ADF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x79AE460", Offset = "0x79AD660", VA = "0x1879AE460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x79B60D0", Offset = "0x79B52D0", VA = "0x1879B60D0")]
	[AsyncStateMachine(typeof(LDPLKPANDIN))]
	public static Task BOIJOOGLJMA(DDGKJPGGCCE NEMIMEMMONE, GHIJJJNKODG LFDKFEEPNFP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct CGHDCJLPNJF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct OMNFEAJMLAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public DDGKJPGGCCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public JNGBCHHMFIN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private HODEGGJGEFG <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private NDEJMCPCCDJ <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private LMIBFAPANNF <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private OODALMMDODD <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private List<(PersistenceView, INLFGDDOIPN)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private INLFGDDOIPN <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x79B49F0", Offset = "0x79B3BF0", VA = "0x1879B49F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x79B5690", Offset = "0x79B4890", VA = "0x1879B5690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x79A1690", Offset = "0x79A0890", VA = "0x1879A1690")]
	[AsyncStateMachine(typeof(OMNFEAJMLAE))]
	public static Task BOIJOOGLJMA(DDGKJPGGCCE NEMIMEMMONE, GHIJJJNKODG LFDKFEEPNFP, JNGBCHHMFIN NJHFBODDILP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x79A17E0", Offset = "0x79A09E0", VA = "0x1879A17E0")]
	private static void GHIKIIAKMEC(PersistenceView GOAHALBEPJI, INLFGDDOIPN HMHIBHFIJPG, GHIJJJNKODG LFDKFEEPNFP, HODEGGJGEFG EJNJIIKKDCB, bool IHNFDINBFAG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct ODMKMNMGBII
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct NJENEAEOAPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public NDEJMCPCCDJ roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private OODALMMDODD <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x79B2920", Offset = "0x79B1B20", VA = "0x1879B2920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x79B2F40", Offset = "0x79B2140", VA = "0x1879B2F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x79B2FA0", Offset = "0x79B21A0", VA = "0x1879B2FA0")]
	[AsyncStateMachine(typeof(NJENEAEOAPP))]
	public static Task BOIJOOGLJMA(NDEJMCPCCDJ CNCOIDECOMJ, GHIJJJNKODG LFDKFEEPNFP, CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct BBJPIFCFMPG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct POMPEGGEEIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public NDEJMCPCCDJ roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public DDGKJPGGCCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x79B5E60", Offset = "0x79B5060", VA = "0x1879B5E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x79B6070", Offset = "0x79B5270", VA = "0x1879B6070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class ABAGMHBHLLC
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
			public EKKGOIIBGNN<string>.KJLMKGNBAOG timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			public ABAGMHBHLLC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x79B6A00", Offset = "0x79B5C00", VA = "0x1879B6A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x79B6D90", Offset = "0x79B5F90", VA = "0x1879B6D90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public ABAGMHBHLLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x799D680", Offset = "0x799C880", VA = "0x18799D680")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task GIBLNCJPPPH(EKKGOIIBGNN<string>.KJLMKGNBAOG timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct OLEBPMKOAMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public BBJPIFCFMPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private OODALMMDODD <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private TaskAwaiter<FJJEHEJHICA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x79B3D80", Offset = "0x79B2F80", VA = "0x1879B3D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x79B4990", Offset = "0x79B3B90", VA = "0x1879B4990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class BBKOBDILHMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public IDAGJOOOCKM version;

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
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BBKOBDILHMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x79A0820", Offset = "0x799FA20", VA = "0x1879A0820")]
		internal object LCNAPDNPJJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x79A0770", Offset = "0x799F970", VA = "0x1879A0770")]
		internal object FCOBEDDFNEC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private NDEJMCPCCDJ CNCOIDECOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private GHIJJJNKODG LFDKFEEPNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private DDGKJPGGCCE NEMIMEMMONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private bool JDFDKNFKIFN;

	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private static readonly ByteString MNBKNGACCJH;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private LMIBFAPANNF FFGEEHIBEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x79A0690", Offset = "0x799F890", VA = "0x1879A0690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private AOMKKEDLMKB INFDKHDKCOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x799FE50", Offset = "0x799F050", VA = "0x18799FE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x799FBD0", Offset = "0x799EDD0", VA = "0x18799FBD0")]
	[AsyncStateMachine(typeof(POMPEGGEEIL))]
	public static Task BOIJOOGLJMA(NDEJMCPCCDJ CNCOIDECOMJ, GHIJJJNKODG LFDKFEEPNFP, DDGKJPGGCCE NEMIMEMMONE, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE, bool JDFDKNFKIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x799FD20", Offset = "0x799EF20", VA = "0x18799FD20")]
	[AsyncStateMachine(typeof(OLEBPMKOAMO))]
	private Task BOIJOOGLJMA(EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x799FEF0", Offset = "0x799F0F0", VA = "0x18799FEF0")]
	private void MIEEKFJBMAF([NotNull] LJJCDEANBLH GIHONGMDDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x799FB90", Offset = "0x799ED90", VA = "0x18799FB90")]
	private bool BKAFOGMFGKK(IDAGJOOOCKM LNKNPHKNIOF, LJJCDEANBLH GIHONGMDDKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct LDAMGIBJOIC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct HFHEGBNOELP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public AsyncTaskMethodBuilder<GHIJJJNKODG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public LDAMGIBJOIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public JEBAGMAELAD.ALKCOCMPHGB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private TaskAwaiter<(EBOICGKKPAM<EKJLBFLMBMG, ENAONJKJOID>, EBOICGKKPAM<LAPLGAAPACL<LJJCDEANBLH>, ENAONJKJOID>, EBOICGKKPAM<LAPLGAAPACL<CGFMNABJBKA>, ENAONJKJOID>, EBOICGKKPAM<LAPLGAAPACL<NCMNDHGNHEG>, ENAONJKJOID>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x79A7AB0", Offset = "0x79A6CB0", VA = "0x1879A7AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x79A8560", Offset = "0x79A7760", VA = "0x1879A8560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct KNKEPCMIHGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<EKJLBFLMBMG, ENAONJKJOID>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public LDAMGIBJOIC <>4__this;

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
		public JEBAGMAELAD.ALKCOCMPHGB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter<EBOICGKKPAM<EKJLBFLMBMG, ENAONJKJOID>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x79ACAB0", Offset = "0x79ABCB0", VA = "0x1879ACAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x79AD0C0", Offset = "0x79AC2C0", VA = "0x1879AD0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private HCOFEFGGBKJ<GLPHDJDILNO, CGFMNABJBKA> FCJEMMOJMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private HCOFEFGGBKJ<GLPHDJDILNO, LJJCDEANBLH> GNFKCFMDMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private HCOFEFGGBKJ<long, NCMNDHGNHEG> MMDACEPPHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private FMEENKBEGHJ GLHPANFMDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private OAOBEPBAJLE BGDELDLHBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private CNMPJHKKKIM PIBGHFKDAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private string BJIJJHHLOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private GLPHDJDILNO JBBABNEKIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	private GLPHDJDILNO KEOAELBKNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private long BBJKLNFMAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	private EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK;

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x79AD9C0", Offset = "0x79ACBC0", VA = "0x1879AD9C0")]
	public static Task<GHIJJJNKODG> EJKEFOAIEKP(NDEJMCPCCDJ CNCOIDECOMJ, [In] BNDBLCIOFNJ LFDKFEEPNFP, JEBAGMAELAD.ALKCOCMPHGB HKLIEGDHCBF, EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x79AD830", Offset = "0x79ACA30", VA = "0x1879AD830")]
	[AsyncStateMachine(typeof(HFHEGBNOELP))]
	private Task<GHIJJJNKODG> BOIJOOGLJMA(JEBAGMAELAD.ALKCOCMPHGB HKLIEGDHCBF, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x79ADD20", Offset = "0x79ACF20", VA = "0x1879ADD20")]
	[AsyncStateMachine(typeof(KNKEPCMIHGC))]
	private Task<EBOICGKKPAM<EKJLBFLMBMG, ENAONJKJOID>> IAFGJBKDKJL(string BJIJJHHLOJN, long BBJKLNFMAJN, long? MOMKFNIIPAA, long? GHKEIJKOONC, JEBAGMAELAD.ALKCOCMPHGB HKLIEGDHCBF, EKKGOIIBGNN<string>.KJLMKGNBAOG MAIFAEMFBCC, CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct NBCIENLABKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct AIGDMOAKELP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public AsyncTaskMethodBuilder<BNDBLCIOFNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public NBCIENLABKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private TaskAwaiter<BNDBLCIOFNJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x799E000", Offset = "0x799D200", VA = "0x18799E000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x799E410", Offset = "0x799D610", VA = "0x18799E410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct DJHEACJPLHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public AsyncTaskMethodBuilder<BNDBLCIOFNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public NBCIENLABKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private TaskAwaiter<BNDBLCIOFNJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x79A2280", Offset = "0x79A1480", VA = "0x1879A2280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x79A26B0", Offset = "0x79A18B0", VA = "0x1879A26B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class EKGBFPCOFOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public EKGBFPCOFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xCF10D0", Offset = "0xCF02D0", VA = "0x180CF10D0")]
		internal bool FKNNCMLLPCO(CNMPJHKKKIM sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct ANCBEHMDCOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public AsyncTaskMethodBuilder<BNDBLCIOFNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public GLPHDJDILNO superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public LMIBFAPANNF callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private EKGBFPCOFOC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public EMBLJOOMEMF roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private OAOBEPBAJLE <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private CNMPJHKKKIM <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private GLPHDJDILNO <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private GLPHDJDILNO <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter<OAOBEPBAJLE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter<NKLGEBMKEAG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private TaskAwaiter<GLPOHAHMIGG> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x799E480", Offset = "0x799D680", VA = "0x18799E480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x799F5D0", Offset = "0x799E7D0", VA = "0x18799F5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private LMIBFAPANNF CKNLAJJPLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private EMHDMPCCNCO CIBHCCPALDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private EMBLJOOMEMF BLBMLALAFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private long MOMKFNIIPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private long NPLPICCKAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private long POOMNAEPOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private string PANOEKHIIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private GLPHDJDILNO EOBHCBNCFJJ;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x79B1650", Offset = "0x79B0850", VA = "0x1879B1650")]
	public static Task<BNDBLCIOFNJ> EJKEFOAIEKP(NDEJMCPCCDJ CNCOIDECOMJ, FENMDJFMHBI JLBJPEIMAMB, EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x79B1500", Offset = "0x79B0700", VA = "0x1879B1500")]
	[AsyncStateMachine(typeof(AIGDMOAKELP))]
	private Task<BNDBLCIOFNJ> BOIJOOGLJMA(CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x79B1A20", Offset = "0x79B0C20", VA = "0x1879B1A20")]
	[AsyncStateMachine(typeof(DJHEACJPLHF))]
	private Task<BNDBLCIOFNJ> HLFCDACIMEP(EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x79B1880", Offset = "0x79B0A80", VA = "0x1879B1880")]
	[AsyncStateMachine(typeof(ANCBEHMDCOA))]
	private static Task<BNDBLCIOFNJ> HLFCDACIMEP(LMIBFAPANNF CKNLAJJPLCN, EMBLJOOMEMF BLBMLALAFDG, long MOMKFNIIPAA, long NPLPICCKAOE, long POOMNAEPOLM, string PANOEKHIIKG, GLPHDJDILNO EOBHCBNCFJJ, CancellationToken BGEKICMONBE, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x79B1B80", Offset = "0x79B0D80", VA = "0x1879B1B80")]
	private void HNGNIHDPAJK(OAOBEPBAJLE BGDELDLHBMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
internal struct JPLIAMFCELO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct GHHDNHPLGOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public JPLIAMFCELO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x79A62F0", Offset = "0x79A54F0", VA = "0x1879A62F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x79A6880", Offset = "0x79A5A80", VA = "0x1879A6880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private LMIBFAPANNF CKNLAJJPLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private GHIJJJNKODG LFDKFEEPNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private float NGBGDDFIBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private float MLPEIOJDGGM;

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x79AC0C0", Offset = "0x79AB2C0", VA = "0x1879AC0C0")]
	public static Task MHEGLICIPKG(NDEJMCPCCDJ CNCOIDECOMJ, GHIJJJNKODG LFDKFEEPNFP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x79ABD80", Offset = "0x79AAF80", VA = "0x1879ABD80")]
	[AsyncStateMachine(typeof(GHHDNHPLGOG))]
	public Task BOIJOOGLJMA(CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x79ABEA0", Offset = "0x79AB0A0", VA = "0x1879ABEA0")]
	private static void IGBGBKAKHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x79AC260", Offset = "0x79AB460", VA = "0x1879AC260")]
	private void MJJLKHGDAGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x79AC000", Offset = "0x79AB200", VA = "0x1879AC000")]
	private static float LGJCHJDPBOD(LMIBFAPANNF CKNLAJJPLCN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x79ABFE0", Offset = "0x79AB1E0", VA = "0x1879ABFE0")]
	private static float KDCPMPLHOED()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct JJMMEDLHPDC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct JBPMNDLPMKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public DDGKJPGGCCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private AJHAEBBPGDJ <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private NDEJMCPCCDJ <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private HEAGNIDPPLK.KFEIMIDABFI <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private TaskAwaiter<FJJEHEJHICA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x79AA6A0", Offset = "0x79A98A0", VA = "0x1879AA6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x79AAEC0", Offset = "0x79AA0C0", VA = "0x1879AAEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct MPNEEICAAFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x79B0D80", Offset = "0x79AFF80", VA = "0x1879B0D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x79B10B0", Offset = "0x79B02B0", VA = "0x1879B10B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x79AAFE0", Offset = "0x79AA1E0", VA = "0x1879AAFE0")]
	[AsyncStateMachine(typeof(JBPMNDLPMKO))]
	public static Task BOIJOOGLJMA(DDGKJPGGCCE NEMIMEMMONE, GHIJJJNKODG LFDKFEEPNFP, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x79AB120", Offset = "0x79AA320", VA = "0x1879AB120")]
	private static Task<FJJEHEJHICA> DNMFEKIMDLP(DDGKJPGGCCE NEMIMEMMONE, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x79AAF20", Offset = "0x79AA120", VA = "0x1879AAF20")]
	[AsyncStateMachine(typeof(MPNEEICAAFF))]
	private static Task AFEIJDJFBCI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct CLPCEOLMPNP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct IEJNCAMKOAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public CLPCEOLMPNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x79A9A00", Offset = "0x79A8C00", VA = "0x1879A9A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x79AA0B0", Offset = "0x79A92B0", VA = "0x1879AA0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class KGPCICDGOPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public KGPCICDGOPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x79AC3C0", Offset = "0x79AB5C0", VA = "0x1879AC3C0")]
		internal object KICPOCJEDKH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct ANKNODCLCLB : IAsyncStateMachine
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
		public CLPCEOLMPNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x799F640", Offset = "0x799E840", VA = "0x18799F640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x799FAC0", Offset = "0x799ECC0", VA = "0x18799FAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B0")]
	private bool LFOAGMGLCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B2")]
	private NDEJMCPCCDJ CNCOIDECOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005B3")]
	private CancellationToken BGEKICMONBE;

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x79A1BC0", Offset = "0x79A0DC0", VA = "0x1879A1BC0")]
	public static Task ENJLLLBCLAP(NDEJMCPCCDJ CNCOIDECOMJ, bool LFOAGMGLCGA, EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, CancellationToken EFCCBEDNKJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x79A1AD0", Offset = "0x79A0CD0", VA = "0x1879A1AD0")]
	[AsyncStateMachine(typeof(IEJNCAMKOAH))]
	private Task BOIJOOGLJMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x79A1C30", Offset = "0x79A0E30", VA = "0x1879A1C30")]
	[AsyncStateMachine(typeof(ANKNODCLCLB))]
	private Task GNPLCGGPLCF(bool DAFCHLLMHEM, string OIECDHAKEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0")]
	private bool MMHAOPBFNEO(bool LFOAGMGLCGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct GPAIFAHOIMK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct EJBICJKINEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public GPAIFAHOIMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x79A41B0", Offset = "0x79A33B0", VA = "0x1879A41B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x79A4720", Offset = "0x79A3920", VA = "0x1879A4720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class LDFJAKCHAJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public LDFJAKCHAJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x79ADEE0", Offset = "0x79AD0E0", VA = "0x1879ADEE0")]
		internal object KICPOCJEDKH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct JNOHKAHMDKE : IAsyncStateMachine
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
		public GPAIFAHOIMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x79AB880", Offset = "0x79AAA80", VA = "0x1879AB880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x79ABD10", Offset = "0x79AAF10", VA = "0x1879ABD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private FKPGCHNCEJB NHMOGANKBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private NDEJMCPCCDJ CNCOIDECOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private bool BCEMGPIPKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private GHIJJJNKODG LFDKFEEPNFP;

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x79A6BF0", Offset = "0x79A5DF0", VA = "0x1879A6BF0")]
	public static Task<Scene> JFFHBCDNPLG(NDEJMCPCCDJ CNCOIDECOMJ, FKPGCHNCEJB BLILBELNPLC, EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x79A6950", Offset = "0x79A5B50", VA = "0x1879A6950")]
	[AsyncStateMachine(typeof(EJBICJKINEP))]
	private Task<Scene> BOIJOOGLJMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x79A6A70", Offset = "0x79A5C70", VA = "0x1879A6A70")]
	private bool CGCCFDKPFCH(GHIJJJNKODG LFDKFEEPNFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x79A68E0", Offset = "0x79A5AE0", VA = "0x1879A68E0")]
	private void BNABJKDLKPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x79A6AA0", Offset = "0x79A5CA0", VA = "0x1879A6AA0")]
	[AsyncStateMachine(typeof(JNOHKAHMDKE))]
	private Task<Scene> GNPLCGGPLCF(string OIECDHAKEME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct GFCDNFMOCHO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct DKFLIOBMNCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public AsyncTaskMethodBuilder<HODEGGJGEFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public GFCDNFMOCHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public HODEGGJGEFG nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public GHIJJJNKODG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter<HODEGGJGEFG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x79A2720", Offset = "0x79A1920", VA = "0x1879A2720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x79A31F0", Offset = "0x79A23F0", VA = "0x1879A31F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct CANICIEMHGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public AsyncTaskMethodBuilder<HODEGGJGEFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public GFCDNFMOCHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public HODEGGJGEFG state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private TaskAwaiter<FJJEHEJHICA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x79A1340", Offset = "0x79A0540", VA = "0x1879A1340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x79A1620", Offset = "0x79A0820", VA = "0x1879A1620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	private readonly DDGKJPGGCCE NEMIMEMMONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	private readonly EMHDMPCCNCO CIBHCCPALDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	private readonly LFLHGOJIEEM GHAPLHOCKIK;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private AJHAEBBPGDJ LLCJPMCEFCA
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x60429E0", Offset = "0x6041BE0", VA = "0x1860429E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x79A6290", Offset = "0x79A5490", VA = "0x1879A6290")]
	public GFCDNFMOCHO(DDGKJPGGCCE NEMIMEMMONE, EMHDMPCCNCO CIBHCCPALDN, LFLHGOJIEEM GHAPLHOCKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x79A6110", Offset = "0x79A5310", VA = "0x1879A6110")]
	[AsyncStateMachine(typeof(DKFLIOBMNCO))]
	public Task<HODEGGJGEFG> PDNDANFKPHE(HODEGGJGEFG BAGAPLPLEBM, GHIJJJNKODG ELGFNCMNGAO, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE, bool NGPGAPEHMLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x79A5FB0", Offset = "0x79A51B0", VA = "0x1879A5FB0")]
	[AsyncStateMachine(typeof(CANICIEMHGP))]
	private Task<HODEGGJGEFG> MPGFOJPNNNG(EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, HODEGGJGEFG ONNLPKDFGPA, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x79A5F60", Offset = "0x79A5160", VA = "0x1879A5F60")]
	private bool HAJKBHPAAOP(HODEGGJGEFG NIHMJBCEJIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x79A5F90", Offset = "0x79A5190", VA = "0x1879A5F90")]
	private void IKHOJNLBJOK(string GFNGFABOFPA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct LHNNNPIECCB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct ACPOHPDBODJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public AJHAEBBPGDJ operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public JNGBCHHMFIN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private OODALMMDODD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private List<(PersistenceView, INLFGDDOIPN)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private (PersistenceView, INLFGDDOIPN) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x799D810", Offset = "0x799CA10", VA = "0x18799D810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x799DE60", Offset = "0x799D060", VA = "0x18799DE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x79AFD10", Offset = "0x79AEF10", VA = "0x1879AFD10")]
	[AsyncStateMachine(typeof(ACPOHPDBODJ))]
	public static Task BOIJOOGLJMA(AJHAEBBPGDJ AHMKJKELCNK, GHIJJJNKODG LFDKFEEPNFP, JNGBCHHMFIN NJHFBODDILP, CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct BEEEDFBGCHO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct LEMPEFFIKMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public AJHAEBBPGDJ operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public JNGBCHHMFIN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private IDAGJOOOCKM <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private OODALMMDODD <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private List<(PersistenceView, INLFGDDOIPN)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private INLFGDDOIPN <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x79AE4C0", Offset = "0x79AD6C0", VA = "0x1879AE4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x79AED70", Offset = "0x79ADF70", VA = "0x1879AED70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x79A0900", Offset = "0x799FB00", VA = "0x1879A0900")]
	[AsyncStateMachine(typeof(LEMPEFFIKMN))]
	public static Task BOIJOOGLJMA(AJHAEBBPGDJ AHMKJKELCNK, GHIJJJNKODG LFDKFEEPNFP, JNGBCHHMFIN NJHFBODDILP, CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct HEAGNIDPPLK
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	public struct KFEIMIDABFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public List<ALGOMCFKGGP> FAPOMABDEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public List<INLFGDDOIPN> JHJEPDIMNPE;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x982390", Offset = "0x981590", VA = "0x180982390")]
		public KFEIMIDABFI(List<ALGOMCFKGGP> FAPOMABDEMM, List<INLFGDDOIPN> JHJEPDIMNPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class HALIACMKFBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public IEnumerable<ALGOMCFKGGP> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public HALIACMKFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x79A6C70", Offset = "0x79A5E70", VA = "0x1879A6C70")]
		internal object HNNBOJKCBMC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	private NDEJMCPCCDJ CNCOIDECOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private GHIJJJNKODG LFDKFEEPNFP;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private LMIBFAPANNF FFGEEHIBEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x79A7720", Offset = "0x79A6920", VA = "0x1879A7720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x79A6CF0", Offset = "0x79A5EF0", VA = "0x1879A6CF0")]
	public static KFEIMIDABFI BOIJOOGLJMA(NDEJMCPCCDJ CNCOIDECOMJ, GHIJJJNKODG LFDKFEEPNFP)
	{
		return default(KFEIMIDABFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x79A6D50", Offset = "0x79A5F50", VA = "0x1879A6D50")]
	private KFEIMIDABFI BOIJOOGLJMA()
	{
		return default(KFEIMIDABFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x79A6FB0", Offset = "0x79A61B0", VA = "0x1879A6FB0")]
	private KFEIMIDABFI GOKACELIMGN(LJJCDEANBLH GIHONGMDDKI, IDAGJOOOCKM EPOIOKEICOJ)
	{
		return default(KFEIMIDABFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x79A7550", Offset = "0x79A6750", VA = "0x1879A7550")]
	private bool KOAOKDNFHKJ(IEnumerable<ALGOMCFKGGP> FAPOMABDEMM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct CAICFMNPKPH
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class ODMMFLBEEPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public HEAGNIDPPLK.KFEIMIDABFI instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public ODMMFLBEEPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x79B30C0", Offset = "0x79B22C0", VA = "0x1879B30C0")]
		internal object GIBLNCJPPPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class EIGHFIFPDND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public EIGHFIFPDND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x79A4120", Offset = "0x79A3320", VA = "0x1879A4120")]
		internal object HLJCHNJBCNI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x79A0D40", Offset = "0x799FF40", VA = "0x1879A0D40")]
	public static void BOIJOOGLJMA(AJHAEBBPGDJ AHMKJKELCNK, GHIJJJNKODG LFDKFEEPNFP, HEAGNIDPPLK.KFEIMIDABFI OOMAJILCEFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal class LFLHGOJIEEM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct EGBNOOCMHDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public LFLHGOJIEEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public HODEGGJGEFG operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public GHIJJJNKODG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x79A3950", Offset = "0x79A2B50", VA = "0x1879A3950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x79A40C0", Offset = "0x79A32C0", VA = "0x1879A40C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class CGMMLPINEJP
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
			public CGMMLPINEJP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400061D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x79B66E0", Offset = "0x79B58E0", VA = "0x1879B66E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x79B69A0", Offset = "0x79B5BA0", VA = "0x1879B69A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public LFLHGOJIEEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CGMMLPINEJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x79A19E0", Offset = "0x79A0BE0", VA = "0x1879A19E0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task LEDMDCBJPOD(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct INMDDLCCLAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public LFLHGOJIEEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private CGMMLPINEJP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x79AA110", Offset = "0x79A9310", VA = "0x1879AA110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x79AA640", Offset = "0x79A9840", VA = "0x1879AA640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct KIPDKMBPPMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public LFLHGOJIEEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		private Dictionary<Guid, List<PHMDAGGHOIA>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x79AC440", Offset = "0x79AB640", VA = "0x1879AC440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x79ACA50", Offset = "0x79ABC50", VA = "0x1879ACA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct KOAAAAIPOAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public LFLHGOJIEEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private Dictionary<Guid, List<PHMDAGGHOIA>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x79AD130", Offset = "0x79AC330", VA = "0x1879AD130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x79AD7D0", Offset = "0x79AC9D0", VA = "0x1879AD7D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class CNEDALBPFPP
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
			public PHMDAGGHOIA handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000640")]
			public CNEDALBPFPP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			private OODALMMDODD <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000642")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005DF")]
			[Cpp2IlInjected.Address(RVA = "0x79B6210", Offset = "0x79B5410", VA = "0x1879B6210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x79B6680", Offset = "0x79B5880", VA = "0x1879B6680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public KGENHFOEMGC runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public List<PHMDAGGHOIA> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CNEDALBPFPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x79A1D60", Offset = "0x79A0F60", VA = "0x1879A1D60")]
		internal object BHAGLNJDLAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x79A1E50", Offset = "0x79A1050", VA = "0x1879A1E50")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task LJFCFPHFJKC(PHMDAGGHOIA handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x79A1F50", Offset = "0x79A1150", VA = "0x1879A1F50")]
		internal object OCLNPILPCAB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct MEFKNKFHGPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public KGENHFOEMGC runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public List<PHMDAGGHOIA> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private CNEDALBPFPP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x79AFF80", Offset = "0x79AF180", VA = "0x1879AFF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x79B0450", Offset = "0x79AF650", VA = "0x1879B0450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct EJMFHKEFFKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public LFLHGOJIEEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG timer;

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
		[Cpp2IlInjected.Address(RVA = "0x79A4790", Offset = "0x79A3990", VA = "0x1879A4790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x79A4D50", Offset = "0x79A3F50", VA = "0x1879A4D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class NAIIDOKAAIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public NAIIDOKAAIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x79B1110", Offset = "0x79B0310", VA = "0x1879B1110")]
		internal object BFEOFDBNGJD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct OHBFFDFAGEM : IAsyncStateMachine
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
		public LFLHGOJIEEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public GHIJJJNKODG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x79B3170", Offset = "0x79B2370", VA = "0x1879B3170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x79B3630", Offset = "0x79B2830", VA = "0x1879B3630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class ABALBIHADFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public ABALBIHADFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x799D7A0", Offset = "0x799C9A0", VA = "0x18799D7A0")]
		internal object NEAPMKHDDDO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct HODBLHHHFKE : IAsyncStateMachine
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
		public LFLHGOJIEEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter<FJJEHEJHICA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x79A9320", Offset = "0x79A8520", VA = "0x1879A9320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x79A9960", Offset = "0x79A8B60", VA = "0x1879A9960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class PDDFKFGBEJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public PDDFKFGBEJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x79B56F0", Offset = "0x79B48F0", VA = "0x1879B56F0")]
		internal object MBLDOAHMPPC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private readonly DDGKJPGGCCE NEMIMEMMONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private AIICDGJHKLD GHAPLHOCKIK;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private AJHAEBBPGDJ LLCJPMCEFCA
	{
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xEF4580", Offset = "0xEF3780", VA = "0x180EF4580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	public LFLHGOJIEEM(DDGKJPGGCCE NEMIMEMMONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x79AEE80", Offset = "0x79AE080", VA = "0x1879AEE80")]
	[AsyncStateMachine(typeof(EGBNOOCMHDM))]
	public Task BOIJOOGLJMA(HODEGGJGEFG EJNJIIKKDCB, GHIJJJNKODG ELGFNCMNGAO, EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x79AF5F0", Offset = "0x79AE7F0", VA = "0x1879AF5F0")]
	[AsyncStateMachine(typeof(INMDDLCCLAN))]
	private Task NJEDHNKKOLB(GHIJJJNKODG LFDKFEEPNFP, EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x79AF730", Offset = "0x79AE930", VA = "0x1879AF730")]
	[AsyncStateMachine(typeof(KIPDKMBPPMO))]
	private Task OKOKJOOOCKL(GHIJJJNKODG LFDKFEEPNFP, EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x79AF250", Offset = "0x79AE450", VA = "0x1879AF250")]
	[AsyncStateMachine(typeof(KOAAAAIPOAA))]
	private Task CFAOHBBDDIN(GHIJJJNKODG LFDKFEEPNFP, EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x79AF9E0", Offset = "0x79AEBE0", VA = "0x1879AF9E0")]
	[AsyncStateMachine(typeof(MEFKNKFHGPJ))]
	private Task PLFHKNCAJOF(Guid ONAEGLADIJL, List<PHMDAGGHOIA> ONLLELCOCOP, KGENHFOEMGC IFFEAICPMLH, GHIJJJNKODG LFDKFEEPNFP, CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x79AF110", Offset = "0x79AE310", VA = "0x1879AF110")]
	[AsyncStateMachine(typeof(EJMFHKEFFKE))]
	private Task CCEKPHCICJN(GHIJJJNKODG LFDKFEEPNFP, EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x79AEFD0", Offset = "0x79AE1D0", VA = "0x1879AEFD0")]
	[AsyncStateMachine(typeof(OHBFFDFAGEM))]
	private Task BOOILGHHNCM(Guid AOOMBBBIJEO, GHIJJJNKODG LFDKFEEPNFP, EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x79AF4B0", Offset = "0x79AE6B0", VA = "0x1879AF4B0")]
	[AsyncStateMachine(typeof(HODBLHHHFKE))]
	private Task HAGAGDGJKMP(Guid AOOMBBBIJEO, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x79AF390", Offset = "0x79AE590", VA = "0x1879AF390")]
	private void GFBIMMKHNLB(Guid AOOMBBBIJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x79AEDD0", Offset = "0x79ADFD0", VA = "0x1879AEDD0")]
	private void ABFMDCMFJBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x79AF870", Offset = "0x79AEA70", VA = "0x1879AF870")]
	public Guid PCAHILDNGEK(HODEGGJGEFG BIKADPJEGPF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x79AFB30", Offset = "0x79AED30", VA = "0x1879AFB30")]
	[CompilerGenerated]
	private object PNFBPGGDEMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal struct DHCMKILHDLI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct OHIJFCOINLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public DHCMKILHDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private IEnumerator<DPEIMBPEMEL> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x79B3690", Offset = "0x79B2890", VA = "0x1879B3690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x79B3D20", Offset = "0x79B2F20", VA = "0x1879B3D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private LMIBFAPANNF CKNLAJJPLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private CancellationToken BGEKICMONBE;

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x79A2210", Offset = "0x79A1410", VA = "0x1879A2210")]
	public static Task IGBJBCILFHO(LMIBFAPANNF CKNLAJJPLCN, EKKGOIIBGNN<string>.KJLMKGNBAOG FBHOIGDCPGK, CancellationToken EFCCBEDNKJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x79A2120", Offset = "0x79A1320", VA = "0x1879A2120")]
	[AsyncStateMachine(typeof(OHIJFCOINLM))]
	private Task BOIJOOGLJMA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public readonly struct DGKJNLAJLBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	public readonly bool BACJMICKJOG;

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x26FF1B0", Offset = "0x26FE3B0", VA = "0x1826FF1B0")]
	public DGKJNLAJLBC(bool IHOFPANMIJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
public readonly struct AGCEOGPCGMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	public readonly LJJCDEANBLH? LBNHEFCOLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	public readonly MMKDBMIBDJL PEDBMBDPIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	public readonly string? JHIKLAGJNDM;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public IReadOnlyCollection<string> APLKCIAPAGP
	{
		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x799DEE0", Offset = "0x799D0E0", VA = "0x18799DEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyDictionary<long, int> OHJHALPEBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x799DEC0", Offset = "0x799D0C0", VA = "0x18799DEC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x799DF00", Offset = "0x799D100", VA = "0x18799DF00")]
	public AGCEOGPCGMI(LJJCDEANBLH? JPGPNLNCOHG, MMKDBMIBDJL GMNAKAGONEH, string? BJIJJHHLOJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class EPIGPGOPLEI : AKGDKLIBGAN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct DPCJBCAOHJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public AsyncTaskMethodBuilder<AGCEOGPCGMI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public EPIGPGOPLEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public PPFCCODPGBI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public GBJAOKNDKME roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private OODALMMDODD <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x79A3260", Offset = "0x79A2460", VA = "0x1879A3260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x79A38E0", Offset = "0x79A2AE0", VA = "0x1879A38E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class BKKNIDDFGJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public PPFCCODPGBI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public EPIGPGOPLEI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BKKNIDDFGJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x79A0A40", Offset = "0x799FC40", VA = "0x1879A0A40")]
		internal Task BDEJFGECOPP(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x79A0C60", Offset = "0x799FE60", VA = "0x1879A0C60")]
		internal Task MIOGECNEOCM(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class APHJBMCBJHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public BKKNIDDFGJG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public APHJBMCBJHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x799FB20", Offset = "0x799ED20", VA = "0x18799FB20")]
		internal object FANOBCOLDCO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class IDONMIGJKNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public BKKNIDDFGJG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public IDONMIGJKNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x79A99C0", Offset = "0x79A8BC0", VA = "0x1879A99C0")]
		internal Task ILMIOIKJEJL(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct MJGPOEOHKLN : IAsyncStateMachine
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
		public PPFCCODPGBI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public EPIGPGOPLEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private APHJBMCBJHL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private OODALMMDODD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x79B04B0", Offset = "0x79AF6B0", VA = "0x1879B04B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x79B0D20", Offset = "0x79AFF20", VA = "0x1879B0D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	private readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.Token(Token = "0x4000679")]
	private static readonly TimeSpan IJMLPAICLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	private readonly BJGLCNBEADA IPDBAJOPDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400067B")]
	private readonly NKBMNLPAHLE MKJJNMMNCAC;

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x79A5F00", Offset = "0x79A5100", VA = "0x1879A5F00")]
	public EPIGPGOPLEI(DDGKJPGGCCE NEMIMEMMONE, BJGLCNBEADA IPDBAJOPDLI, NKBMNLPAHLE GNLEBCAOPII, KJMCEDJMPPA MOKKIOIDAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x79A5D30", Offset = "0x79A4F30", VA = "0x1879A5D30")]
	[AsyncStateMachine(typeof(DPCJBCAOHJC))]
	public Task<AGCEOGPCGMI> LKDLAIOBOFF(long NPLPICCKAOE, GBJAOKNDKME MBAOMPKNKCM, PPFCCODPGBI MKBCJJNBDGD, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x79A53B0", Offset = "0x79A45B0", VA = "0x1879A53B0")]
	[AsyncStateMachine(typeof(MJGPOEOHKLN))]
	private Task IEMLMHKJAEM(PPFCCODPGBI MKBCJJNBDGD, IEnumerable<PersistenceView> EMMFEOCJAFK, StringBuilder FAHIFMHOPDN, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x79A5740", Offset = "0x79A4940", VA = "0x1879A5740")]
	private AGCEOGPCGMI JCFPGMDAEOF(long NPLPICCKAOE, GBJAOKNDKME MBAOMPKNKCM, PPFCCODPGBI MKBCJJNBDGD, IEnumerable<PersistenceView> EMMFEOCJAFK, StringBuilder FAHIFMHOPDN)
	{
		return default(AGCEOGPCGMI);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x79A5250", Offset = "0x79A4450", VA = "0x1879A5250")]
	private LJJCDEANBLH GNKOPBNCIOB(long NPLPICCKAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x79A54F0", Offset = "0x79A46F0", VA = "0x1879A54F0")]
	private void IKIKHLDMNMF(LJJCDEANBLH IOFMDAMACFG, StringBuilder FAHIFMHOPDN, IEnumerable<PersistenceView> EMMFEOCJAFK, [In] KNPOFBEJPHJ FOFFEAPCJOK, IJKMGMJGDCO FOPPDGPMNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x79A4DB0", Offset = "0x79A3FB0", VA = "0x1879A4DB0")]
	private void GJLPKLCAICK(LJJCDEANBLH IOFMDAMACFG, StringBuilder FAHIFMHOPDN, PersistenceView GOAHALBEPJI, IJKMGMJGDCO FOPPDGPMNPA, [In] KNPOFBEJPHJ FOFFEAPCJOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal class JNNFMHIKODD : AKGDKLIBGAN
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class CALJDDPJNMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public AJAPFHEFMLP.MCLJEJPJKJC roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CALJDDPJNMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x79A12F0", Offset = "0x79A04F0", VA = "0x1879A12F0")]
		internal object EFLIMFANDCN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct HNIOAODJEKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public AsyncTaskMethodBuilder<(AJAPFHEFMLP.MCLJEJPJKJC roomDataUpload, AJAPFHEFMLP.MCLJEJPJKJC subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public AGCEOGPCGMI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public JNNFMHIKODD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private CALJDDPJNMD <>8__1;

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
		private TaskAwaiter<AJAPFHEFMLP.MCLJEJPJKJC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x79A8A50", Offset = "0x79A7C50", VA = "0x1879A8A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x79A92B0", Offset = "0x79A84B0", VA = "0x1879A92B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct PGIGGAEPGOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public AsyncTaskMethodBuilder<NMGIKLONOMM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public JNNFMHIKODD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public AGCEOGPCGMI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public CNHGMGKGANK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private TaskAwaiter<(AJAPFHEFMLP.MCLJEJPJKJC roomDataUpload, AJAPFHEFMLP.MCLJEJPJKJC subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private TaskAwaiter<NMGIKLONOMM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x79B5760", Offset = "0x79B4960", VA = "0x1879B5760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x79B5DF0", Offset = "0x79B4FF0", VA = "0x1879B5DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private struct HGOIFCHPMIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public AsyncTaskMethodBuilder<NKLGEBMKEAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public JNNFMHIKODD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public AGCEOGPCGMI roomSerializedData;

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
		private TaskAwaiter<(AJAPFHEFMLP.MCLJEJPJKJC roomDataUpload, AJAPFHEFMLP.MCLJEJPJKJC subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private TaskAwaiter<NKLGEBMKEAG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x79A85D0", Offset = "0x79A77D0", VA = "0x1879A85D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x79A89E0", Offset = "0x79A7BE0", VA = "0x1879A89E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class MDDDBEGMLIL
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
			public AsyncTaskMethodBuilder<FJJEHEJHICA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			public MDDDBEGMLIL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			private FJJEHEJHICA <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006CC")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006CD")]
			private TaskAwaiter<NKLGEBMKEAG> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006CE")]
			private TaskAwaiter<NMGIKLONOMM> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006CF")]
			private TaskAwaiter<FJJEHEJHICA> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0x79B6DF0", Offset = "0x79B5FF0", VA = "0x1879B6DF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x79B7DE0", Offset = "0x79B6FE0", VA = "0x1879B7DE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public JNNFMHIKODD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public AGCEOGPCGMI roomSerializedData;

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
		public CNHGMGKGANK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public DGKJNLAJLBC roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public MDDDBEGMLIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x79AFE50", Offset = "0x79AF050", VA = "0x1879AFE50")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<FJJEHEJHICA> DFGLJIGNBNB(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct NAMCMGBCJJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public AsyncTaskMethodBuilder<FJJEHEJHICA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public JNNFMHIKODD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public AGCEOGPCGMI roomSerializedData;

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
		public CNHGMGKGANK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		public DGKJNLAJLBC roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		private TaskAwaiter<FJJEHEJHICA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x79B1180", Offset = "0x79B0380", VA = "0x1879B1180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x79B1490", Offset = "0x79B0690", VA = "0x1879B1490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private static readonly KJMCEDJMPPA OIEGFOBBFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private readonly MEIJBJKHKBG PIIMFOEGMOP;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private NDEJMCPCCDJ PGNLDHEDIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x7988680", Offset = "0x7987880", VA = "0x187988680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x79AB7F0", Offset = "0x79AA9F0", VA = "0x1879AB7F0")]
	public JNNFMHIKODD(DDGKJPGGCCE NEMIMEMMONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x79AB610", Offset = "0x79AA810", VA = "0x1879AB610")]
	[AsyncStateMachine(typeof(HNIOAODJEKI))]
	private Task<(AJAPFHEFMLP.MCLJEJPJKJC, AJAPFHEFMLP.MCLJEJPJKJC)> IBCCDBCDDAI(AGCEOGPCGMI EOIHJIJJOIC, long MOMKFNIIPAA, long GHKEIJKOONC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x79AB190", Offset = "0x79AA390", VA = "0x1879AB190")]
	[AsyncStateMachine(typeof(PGIGGAEPGOB))]
	public Task<NMGIKLONOMM> ADGHOFPIJBA(int KGAFBFCLOFM, [CanBeNull] CNHGMGKGANK BLHOFKCFNMK, AGCEOGPCGMI EOIHJIJJOIC, long MOMKFNIIPAA, long GHKEIJKOONC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x79AB4A0", Offset = "0x79AA6A0", VA = "0x1879AB4A0")]
	[AsyncStateMachine(typeof(HGOIFCHPMIC))]
	private Task<NKLGEBMKEAG> DMPHPMEOFJP(string PANOEKHIIKG, int KGAFBFCLOFM, AGCEOGPCGMI EOIHJIJJOIC, long MOMKFNIIPAA, long GHKEIJKOONC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x79AB300", Offset = "0x79AA500", VA = "0x1879AB300")]
	[AsyncStateMachine(typeof(NAMCMGBCJJG))]
	public Task<FJJEHEJHICA> BAKLOMMAJGP(int KGAFBFCLOFM, CNHGMGKGANK? BLHOFKCFNMK, AGCEOGPCGMI EOIHJIJJOIC, long MOMKFNIIPAA, long GHKEIJKOONC, DGKJNLAJLBC NAOHACOEFPD, EKKGOIIBGNN<string>.KJLMKGNBAOG KKMMGCCDMGN, CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public abstract class IMHGEPCKAMC<T> where T : IMHGEPCKAMC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	internal readonly NDEJMCPCCDJ ELIABEHODFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private int? DGLNJMHHIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	protected readonly Guid PIPBAHFEAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	protected readonly KMGKENCAGOE PAHENDCBNDG;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	protected T DEFOKFHDBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x4653540", Offset = "0x4652740", VA = "0x184653540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x4653850", Offset = "0x4652A50", VA = "0x184653850")]
	internal IMHGEPCKAMC(NDEJMCPCCDJ DOBJFMKJCNA, KMGKENCAGOE GCOMOAFFFNM, [Optional] Guid? DHNJGGKJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x4653770", Offset = "0x4652970", VA = "0x184653770")]
	private FJJEHEJHICA LENDPKPMNFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "4")]
	protected virtual void LLBNHLDEFMB(FJJEHEJHICA CBCJFCINKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x46535A0", Offset = "0x46527A0", VA = "0x1846535A0")]
	public T IOEPPMCDKKB(IAGJLFEFIKH FFIHLKECHEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x46534A0", Offset = "0x46526A0", VA = "0x1846534A0")]
	public T EFPDGEJLPLD(int CIJGKMINPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x4653640", Offset = "0x4652840", VA = "0x184653640", Slot = "5")]
	public virtual Task<JIDFLMCDEBP> JLJFBLPNMLK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class GEFCICAJODG : IMHGEPCKAMC<GEFCICAJODG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private FENMDJFMHBI OCPJHHIMKFB;

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x79BA730", Offset = "0x79B9930", VA = "0x1879BA730")]
	internal GEFCICAJODG(NDEJMCPCCDJ DOBJFMKJCNA, KMGKENCAGOE GCOMOAFFFNM, [Optional] Guid? DHNJGGKJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x6DBA9C0", Offset = "0x6DB9BC0", VA = "0x186DBA9C0")]
	public GEFCICAJODG HIDGBJCAHDB(FENMDJFMHBI OCPJHHIMKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x79BA660", Offset = "0x79B9860", VA = "0x1879BA660", Slot = "4")]
	protected override void LLBNHLDEFMB(FJJEHEJHICA CBCJFCINKPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public class NCOGPGAMNCK : IMHGEPCKAMC<NCOGPGAMNCK>
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	internal enum LJHHEKMHAEM
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
	private struct HGELMGBJOBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public AsyncTaskMethodBuilder<JIDFLMCDEBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public NCOGPGAMNCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private TaskAwaiter<JIDFLMCDEBP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x79BB550", Offset = "0x79BA750", VA = "0x1879BB550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x79BB8F0", Offset = "0x79BAAF0", VA = "0x1879BB8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private LJHHEKMHAEM MPAPKACKGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006E2")]
	private string DGKMPNGDOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006E3")]
	private CNHGMGKGANK OCPJHHIMKFB;

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x79BE640", Offset = "0x79BD840", VA = "0x1879BE640")]
	internal NCOGPGAMNCK(NDEJMCPCCDJ DOBJFMKJCNA, KMGKENCAGOE GCOMOAFFFNM, [Optional] Guid? DHNJGGKJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x79BE370", Offset = "0x79BD570", VA = "0x1879BE370")]
	public NCOGPGAMNCK HLAGIPNJOOO(string MEAHMKBIOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x79BE3C0", Offset = "0x79BD5C0", VA = "0x1879BE3C0")]
	public NCOGPGAMNCK JKNPKLLCKJN(bool PNAPPLEBMOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x79BE3A0", Offset = "0x79BD5A0", VA = "0x1879BE3A0")]
	public NCOGPGAMNCK IBCBIKJGFMO(bool OFIJOAFADGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x79BE300", Offset = "0x79BD500", VA = "0x1879BE300")]
	public NCOGPGAMNCK AGGBKIHCGPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x79BE4D0", Offset = "0x79BD6D0", VA = "0x1879BE4D0", Slot = "4")]
	protected override void LLBNHLDEFMB(FJJEHEJHICA CBCJFCINKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x79BE3E0", Offset = "0x79BD5E0", VA = "0x1879BE3E0", Slot = "5")]
	[AsyncStateMachine(typeof(HGELMGBJOBB))]
	public override Task<JIDFLMCDEBP> JLJFBLPNMLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x79BE330", Offset = "0x79BD530", VA = "0x1879BE330")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<JIDFLMCDEBP> BHJNPNHIALA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
internal static class DGKIDNIAKDJ
{
	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x79B9650", Offset = "0x79B8850", VA = "0x1879B9650")]
	public static void OBHMOKCFFFI(this AFDGPAEKBBP OECGOOOOBKI, KHDFIKJLGJL NMKEJBINBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x79B95D0", Offset = "0x79B87D0", VA = "0x1879B95D0")]
	public static void MGCAJLAFOKE(this KHDFIKJLGJL GIEDJEEFFOM, [Optional] string CBCJFCINKPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public static class ILKMBAOFIJC
{
	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x79BC200", Offset = "0x79BB400", VA = "0x1879BC200")]
	public static GLPHDJDILNO KOEHAKIGEHH(this MLPHHKJCLJE BKALFDDOLIH)
	{
		return default(GLPHDJDILNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x79BC150", Offset = "0x79BB350", VA = "0x1879BC150")]
	public static MLPHHKJCLJE BHHEPEKLJAL(this GLPHDJDILNO IPHFMKLHDDF)
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
			public JPJHKMFKAFE ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006F1")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006F2")]
			public JPJHKMFKAFE HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		private static JPJHKMFKAFE[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		private Dictionary<JPJHKMFKAFE, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x79BF180", Offset = "0x79BE380", VA = "0x1879BF180")]
		public bool LEMHDGIJPFJ(JPJHKMFKAFE FAOEPHHMLHJ, [Out] ResultConfig LFKGAGFDDEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x79BF040", Offset = "0x79BE240", VA = "0x1879BF040")]
		public ResultConfig ALBIHIBGMFA(JPJHKMFKAFE GLMJIDMBMEG, [Optional] HashSet<JPJHKMFKAFE> BOCMDHPBDAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x79BF7C0", Offset = "0x79BE9C0", VA = "0x1879BF7C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x79BF1F0", Offset = "0x79BE3F0", VA = "0x1879BF1F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0xA59310", Offset = "0xA58510", VA = "0x180A59310")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class COENCBCPHLB : CCGAMJLHGEA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct CIOFPAGDAAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public COENCBCPHLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x79B8FA0", Offset = "0x79B81A0", VA = "0x1879B8FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x79B9230", Offset = "0x79B8430", VA = "0x1879B9230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct JBODLGJCIGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public EKKGOIIBGNN<string>.KJLMKGNBAOG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public CCGAMJLHGEA preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private EKKGOIIBGNN<string>.KJLMKGNBAOG <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x79BC340", Offset = "0x79BB540", VA = "0x1879BC340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x79BC850", Offset = "0x79BBA50", VA = "0x1879BC850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006FB")]
	private readonly FPNIOOAODFJ JEDHGPOEHBM;

	[Cpp2IlInjected.Token(Token = "0x40006FC")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public string CBLOMOFKEMA
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x79B94C0", Offset = "0x79B86C0", VA = "0x1879B94C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x79B94F0", Offset = "0x79B86F0", VA = "0x1879B94F0")]
	[NAOGKPPNIGE.PBOHCEMILCE.MHACPCJGMLG]
	internal static void NINIBBDHOGI(JBPONICDCIO FJGJKHFLABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	[RecRoom.NoEngine.Common.Preserve]
	public COENCBCPHLB([FMJHJHHALCB(null)] FPNIOOAODFJ JEDHGPOEHBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x79B9290", Offset = "0x79B8490", VA = "0x1879B9290", Slot = "5")]
	[AsyncStateMachine(typeof(CIOFPAGDAAP))]
	public Task BOIJOOGLJMA(EKKGOIIBGNN<string>.KJLMKGNBAOG JGAOFMKNFII, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x79B93A0", Offset = "0x79B85A0", VA = "0x1879B93A0")]
	[AsyncStateMachine(typeof(JBODLGJCIGE))]
	private Task DDHLJBALFIO(CCGAMJLHGEA DAFANNJIAFO, EKKGOIIBGNN<string>.KJLMKGNBAOG JGAOFMKNFII, CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public interface FPNIOOAODFJ : CCGAMJLHGEA
{
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public interface CCGAMJLHGEA
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	string CBLOMOFKEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BOIJOOGLJMA(EKKGOIIBGNN<string>.KJLMKGNBAOG JGAOFMKNFII, CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public static class GEFDBLJIMCA
{
	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x79BA860", Offset = "0x79B9A60", VA = "0x1879BA860")]
	[NAOGKPPNIGE.PBOHCEMILCE.MHACPCJGMLG]
	internal static void EMFHCKBHCPB(JBPONICDCIO FJGJKHFLABP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public interface AOCJALDHGHI : IEquatable<AOCJALDHGHI>
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	DateTime IHIDFPJECPM
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MCGFELDCOPM();

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MPBDGLKHIME(long MOMKFNIIPAA, long NPLPICCKAOE, [Out] AGCEOGPCGMI EOIHJIJJOIC);
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal class DIGALHEGGBM : DFAEOHGPHNA
{
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private sealed class ACIFIECIHMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public JBGHPJPHEMA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public ACIFIECIHMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x79B84A0", Offset = "0x79B76A0", VA = "0x1879B84A0")]
		internal object JKEOICDEKEA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400070A")]
	private readonly HNPDGNEGHNC PJIDIIKHPEO;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<AOCJALDHGHI> BIPNLMJNKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x79BA290", Offset = "0x79B9490", VA = "0x1879BA290", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x79BA1E0", Offset = "0x79B93E0", VA = "0x1879BA1E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	[UnityEngine.Scripting.Preserve]
	public DIGALHEGGBM([FMJHJHHALCB(null)] HNPDGNEGHNC PJIDIIKHPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x79B97A0", Offset = "0x79B89A0", VA = "0x1879B97A0", Slot = "6")]
	public bool BFAJBBJBPCN(long MOMKFNIIPAA, long NPLPICCKAOE, AGCEOGPCGMI EOIHJIJJOIC, JBGHPJPHEMA IMGJKIKFHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0xC4CE30", Offset = "0xC4C030", VA = "0x180C4CE30")]
	private void DIHCHBOMMII(AOCJALDHGHI EFHNEIIGJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x79B9C50", Offset = "0x79B8E50", VA = "0x1879B9C50", Slot = "7")]
	public bool HCOAGIGAGEB(long MOMKFNIIPAA, long NPLPICCKAOE, [Out] AOCJALDHGHI DOKPKCJJFPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x79B9A90", Offset = "0x79B8C90", VA = "0x1879B9A90", Slot = "8")]
	public bool FCMFJDOBNMF(long MOMKFNIIPAA, long NPLPICCKAOE, JBGHPJPHEMA IMGJKIKFHHF, [Out] AOCJALDHGHI DOKPKCJJFPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x79B9DC0", Offset = "0x79B8FC0", VA = "0x1879B9DC0")]
	private void HHCFGGKGOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x79B9B40", Offset = "0x79B8D40", VA = "0x1879B9B40", Slot = "9")]
	public void FHDACEAFPCJ(long MOMKFNIIPAA, long NPLPICCKAOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal abstract class BPGGGIOKOFK : HNPDGNEGHNC
{
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	protected enum MBPINDGJOPP : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class IEGLPAIDFIL : IEnumerable<AOCJALDHGHI>, IEnumerable, IEnumerator<AOCJALDHGHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		private AOCJALDHGHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public BPGGGIOKOFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		private JBGHPJPHEMA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public JBGHPJPHEMA <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		private AOCJALDHGHI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xC45340", Offset = "0xC44540", VA = "0x180C45340")]
		[DebuggerHidden]
		public IEGLPAIDFIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x79BBE20", Offset = "0x79BB020", VA = "0x1879BBE20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x79BC100", Offset = "0x79BB300", VA = "0x1879BC100", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x79BC050", Offset = "0x79BB250", VA = "0x1879BC050", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AOCJALDHGHI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x79BC050", Offset = "0x79BB250", VA = "0x1879BC050", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private sealed class IMMOAMHBKMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public JBGHPJPHEMA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public IMMOAMHBKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x79BC2A0", Offset = "0x79BB4A0", VA = "0x1879BC2A0")]
		internal object FNLHBMKFJNJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class AAEEKNNDDHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public BPGGGIOKOFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public AAEEKNNDDHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x79B8420", Offset = "0x79B7620", VA = "0x1879B8420")]
		internal void MLMCELOPOIL(EAOBDCNJJLM.LAOKBJIAHFA ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000710")]
	private readonly object ODEGELAFIIE;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	protected string MNDBCBNHBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x79B8B60", Offset = "0x79B7D60", VA = "0x1879B8B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public abstract DHDMPBPJKEC BACPKDLDJMF
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x79B8F20", Offset = "0x79B8120", VA = "0x1879B8F20")]
	protected BPGGGIOKOFK([CanBeNull] string NAPIKNDEFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x79B8580", Offset = "0x79B7780", VA = "0x1879B8580", Slot = "5")]
	public bool CJADCIMNDOD(long MOMKFNIIPAA, long NPLPICCKAOE, JBGHPJPHEMA IMGJKIKFHHF, [Out] AOCJALDHGHI EFHNEIIGJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x79B8AD0", Offset = "0x79B7CD0", VA = "0x1879B8AD0", Slot = "6")]
	[IteratorStateMachine(typeof(IEGLPAIDFIL))]
	public IEnumerable<AOCJALDHGHI> KBLCMCNPODJ(JBGHPJPHEMA IMGJKIKFHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void BKLDCELLEAI(Stream LAIGPCFLJGA, long MOMKFNIIPAA, long NPLPICCKAOE, AGCEOGPCGMI EOIHJIJJOIC);

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool OJJHCPGJMON(Stream BPLKOMOPBLC, long MOMKFNIIPAA, long NPLPICCKAOE, KNJDAAMLGCH AAGAFNHNOEL, [Out] AGCEOGPCGMI EOIHJIJJOIC);

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x79B8760", Offset = "0x79B7960", VA = "0x1879B8760", Slot = "7")]
	public AOCJALDHGHI JDIANHHNFMI(long MOMKFNIIPAA, long NPLPICCKAOE, AGCEOGPCGMI EOIHJIJJOIC, JBGHPJPHEMA IMGJKIKFHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo AGBMIFFAEGH(long MOMKFNIIPAA, long NPLPICCKAOE, JBGHPJPHEMA IMGJKIKFHHF, MBPINDGJOPP PGHAAMGBCFB);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo EKFILHHFKFP(JBGHPJPHEMA IMGJKIKFHHF, MBPINDGJOPP PGHAAMGBCFB);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x79B8510", Offset = "0x79B7710", VA = "0x1879B8510")]
	protected void CHBIJMKBCLL(EAOBDCNJJLM.LAOKBJIAHFA MJMCHBOKLAM, string GFNGFABOFPA, FileInfo CNLGFGGGCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x79B8B70", Offset = "0x79B7D70", VA = "0x1879B8B70")]
	internal bool NHGDAACFNAO(FileInfo PJFNLKAGAGM, long MOMKFNIIPAA, long NPLPICCKAOE, [Out] AGCEOGPCGMI EOIHJIJJOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
	private void IGEKJJCOJBN(Exception PHEKEBLADHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal class KAFGLCOGMPF : BPGGGIOKOFK
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public override DHDMPBPJKEC BACPKDLDJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x1B40BF0", Offset = "0x1B3FDF0", VA = "0x181B40BF0", Slot = "8")]
		get
		{
			return default(DHDMPBPJKEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x79BE2C0", Offset = "0x79BD4C0", VA = "0x1879BE2C0")]
	public KAFGLCOGMPF([Optional] string NAPIKNDEFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x79BE240", Offset = "0x79BD440", VA = "0x1879BE240")]
	private void PDPBJPDIIAD(JBGHPJPHEMA IMGJKIKFHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x79BD8C0", Offset = "0x79BCAC0", VA = "0x1879BD8C0", Slot = "9")]
	internal override void BKLDCELLEAI(Stream LAIGPCFLJGA, long MOMKFNIIPAA, long NPLPICCKAOE, AGCEOGPCGMI EOIHJIJJOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x79BDC50", Offset = "0x79BCE50", VA = "0x1879BDC50", Slot = "10")]
	internal override bool OJJHCPGJMON(Stream BPLKOMOPBLC, long MOMKFNIIPAA, long NPLPICCKAOE, KNJDAAMLGCH AAGAFNHNOEL, [Out] AGCEOGPCGMI EOIHJIJJOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x79BD7D0", Offset = "0x79BC9D0", VA = "0x1879BD7D0", Slot = "11")]
	protected override FileInfo AGBMIFFAEGH(long MOMKFNIIPAA, long NPLPICCKAOE, JBGHPJPHEMA IMGJKIKFHHF, MBPINDGJOPP PGHAAMGBCFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x79BDB50", Offset = "0x79BCD50", VA = "0x1879BDB50", Slot = "12")]
	protected override DirectoryInfo EKFILHHFKFP(JBGHPJPHEMA IMGJKIKFHHF, MBPINDGJOPP PGHAAMGBCFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal sealed class JCBCJCANMAK : BPGGGIOKOFK
{
	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private static readonly byte[] OFPBICPHALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000721")]
	private readonly byte[] CKNAKOIIJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000722")]
	private readonly byte[] EKKFJIGAIFG;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public override DHDMPBPJKEC BACPKDLDJMF
	{
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x66382A0", Offset = "0x66374A0", VA = "0x1866382A0", Slot = "8")]
		get
		{
			return default(DHDMPBPJKEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x79BD6E0", Offset = "0x79BC8E0", VA = "0x1879BD6E0")]
	public JCBCJCANMAK([Optional] string NAPIKNDEFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x79BC9E0", Offset = "0x79BBBE0", VA = "0x1879BC9E0", Slot = "9")]
	internal override void BKLDCELLEAI(Stream LAIGPCFLJGA, long MOMKFNIIPAA, long NPLPICCKAOE, AGCEOGPCGMI EOIHJIJJOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x79BCE70", Offset = "0x79BC070", VA = "0x1879BCE70", Slot = "10")]
	internal override bool OJJHCPGJMON(Stream BPLKOMOPBLC, long MOMKFNIIPAA, long NPLPICCKAOE, KNJDAAMLGCH AAGAFNHNOEL, [Out] AGCEOGPCGMI EOIHJIJJOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x79BCDB0", Offset = "0x79BBFB0", VA = "0x1879BCDB0")]
	private void LOPFBNKFFPB(byte[] JIGDFCPIKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x79BC8B0", Offset = "0x79BBAB0", VA = "0x1879BC8B0", Slot = "11")]
	protected override FileInfo AGBMIFFAEGH(long MOMKFNIIPAA, long NPLPICCKAOE, JBGHPJPHEMA IMGJKIKFHHF, MBPINDGJOPP PGHAAMGBCFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x79BCCA0", Offset = "0x79BBEA0", VA = "0x1879BCCA0", Slot = "12")]
	protected override DirectoryInfo EKFILHHFKFP(JBGHPJPHEMA IMGJKIKFHHF, MBPINDGJOPP PGHAAMGBCFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public enum DHDMPBPJKEC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000725")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal class HDMDJCFMOBA : HNPDGNEGHNC
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class HOBLGCKPJPJ : IEnumerable<AOCJALDHGHI>, IEnumerable, IEnumerator<AOCJALDHGHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private AOCJALDHGHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public HDMDJCFMOBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private JBGHPJPHEMA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public JBGHPJPHEMA <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private DHDMPBPJKEC[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		private IEnumerator<AOCJALDHGHI> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		private AOCJALDHGHI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xC45340", Offset = "0xC44540", VA = "0x180C45340")]
		[DebuggerHidden]
		public HOBLGCKPJPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x79BBD90", Offset = "0x79BAF90", VA = "0x1879BBD90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x79BB9B0", Offset = "0x79BABB0", VA = "0x1879BB9B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x79BB960", Offset = "0x79BAB60", VA = "0x1879BB960")]
		private void MHLANDJELDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x79BBD40", Offset = "0x79BAF40", VA = "0x1879BBD40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x79BBC90", Offset = "0x79BAE90", VA = "0x1879BBC90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AOCJALDHGHI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x79BBC90", Offset = "0x79BAE90", VA = "0x1879BBC90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	private readonly DHDMPBPJKEC[] FJKCMBKBPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000728")]
	private readonly Dictionary<DHDMPBPJKEC, HNPDGNEGHNC> FJONHDBKAAD;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DHDMPBPJKEC BACPKDLDJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x79BAF10", Offset = "0x79BA110", VA = "0x1879BAF10", Slot = "4")]
		get
		{
			return default(DHDMPBPJKEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x79BB200", Offset = "0x79BA400", VA = "0x1879BB200")]
	[UnityEngine.Scripting.Preserve]
	public HDMDJCFMOBA(params HNPDGNEGHNC[] OKFNEINOJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x79BAC70", Offset = "0x79B9E70", VA = "0x1879BAC70", Slot = "5")]
	public bool CJADCIMNDOD(long MOMKFNIIPAA, long NPLPICCKAOE, JBGHPJPHEMA IMGJKIKFHHF, [Out] AOCJALDHGHI EFHNEIIGJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x79BAFD0", Offset = "0x79BA1D0", VA = "0x1879BAFD0")]
	private void LPLLDCMOBCC(int FPHGHEJMBDM, long MOMKFNIIPAA, long NPLPICCKAOE, JBGHPJPHEMA IMGJKIKFHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x79BAF40", Offset = "0x79BA140", VA = "0x1879BAF40", Slot = "6")]
	[IteratorStateMachine(typeof(HOBLGCKPJPJ))]
	public IEnumerable<AOCJALDHGHI> KBLCMCNPODJ(JBGHPJPHEMA IMGJKIKFHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x79BADC0", Offset = "0x79B9FC0", VA = "0x1879BADC0", Slot = "7")]
	public AOCJALDHGHI JDIANHHNFMI(long MOMKFNIIPAA, long NPLPICCKAOE, AGCEOGPCGMI EOIHJIJJOIC, JBGHPJPHEMA IMGJKIKFHHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class DPGPKPACDNI
{
	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x79BA5A0", Offset = "0x79B97A0", VA = "0x1879BA5A0")]
	internal static byte[] NCENFIKGBMC(byte[] JIGDFCPIKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x79BA520", Offset = "0x79B9720", VA = "0x1879BA520")]
	public static void LLEKIFPKHFJ(Stream OPLAKFCFCLD, byte[] AKBAAMCKDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x79BA340", Offset = "0x79B9540", VA = "0x1879BA340")]
	public static bool CEKIFLEHAFC(Stream OPLAKFCFCLD, long CALDHEAHNLI, KNJDAAMLGCH LGNCHBBJNOJ, [Out] byte[] DPEAPDEONFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
internal sealed class OFNPHHKAHNP : AOCJALDHGHI, IEquatable<AOCJALDHGHI>, IEquatable<OFNPHHKAHNP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000736")]
	private readonly BPGGGIOKOFK OILAFMCDDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000737")]
	public readonly FileInfo KMAMCFFHJLH;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public DHDMPBPJKEC BACPKDLDJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x731B550", Offset = "0x731A750", VA = "0x18731B550", Slot = "9")]
		get
		{
			return default(DHDMPBPJKEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public DateTime IHIDFPJECPM
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x79BEA60", Offset = "0x79BDC60", VA = "0x1879BEA60", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x79BECA0", Offset = "0x79BDEA0", VA = "0x1879BECA0")]
	public OFNPHHKAHNP(BPGGGIOKOFK FDCILDFJJOF, FileInfo PJFNLKAGAGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x79BEBF0", Offset = "0x79BDDF0", VA = "0x1879BEBF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x79BEAF0", Offset = "0x79BDCF0", VA = "0x1879BEAF0", Slot = "5")]
	public void MCGFELDCOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x79BEBB0", Offset = "0x79BDDB0", VA = "0x1879BEBB0", Slot = "6")]
	public bool MPBDGLKHIME(long MOMKFNIIPAA, long NPLPICCKAOE, [Out] AGCEOGPCGMI EOIHJIJJOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x79BE870", Offset = "0x79BDA70", VA = "0x1879BE870", Slot = "7")]
	public bool Equals(AOCJALDHGHI JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x79BE7B0", Offset = "0x79BD9B0", VA = "0x1879BE7B0", Slot = "8")]
	public bool Equals(OFNPHHKAHNP JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x79BE8E0", Offset = "0x79BDAE0", VA = "0x1879BE8E0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x79BE9D0", Offset = "0x79BDBD0", VA = "0x1879BE9D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public delegate void KNJDAAMLGCH(EAOBDCNJJLM.LAOKBJIAHFA FEFLPCBECOJ, string CBCJFCINKPJ);
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface HNPDGNEGHNC
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	DHDMPBPJKEC BACPKDLDJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CJADCIMNDOD(long MOMKFNIIPAA, long NPLPICCKAOE, JBGHPJPHEMA IMGJKIKFHHF, [Out] AOCJALDHGHI EFHNEIIGJPA);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<AOCJALDHGHI> KBLCMCNPODJ(JBGHPJPHEMA IMGJKIKFHHF);

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AOCJALDHGHI JDIANHHNFMI(long MOMKFNIIPAA, long NPLPICCKAOE, AGCEOGPCGMI EOIHJIJJOIC, JBGHPJPHEMA IMGJKIKFHHF);
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
