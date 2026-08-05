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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7C33E30", Offset = "0x7C32A30", VA = "0x187C33E30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x983710", Offset = "0x982310", VA = "0x180983710")]
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
	public class LogRegistrationIndex : NELPCBNCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C2FEB0", Offset = "0x7C2EAB0", VA = "0x187C2FEB0", Slot = "4")]
		public override void CHOGICNNBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C36CF0", Offset = "0x7C358F0", VA = "0x187C36CF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CLAJOCHLBDB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F640", Offset = "0x7C1E240", VA = "0x187C1F640")]
	public CLAJOCHLBDB(string KBPDEFFIKOJ, Exception HPLHIDGGGDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class PBMJGBFNHLM : PHGPPNDHPEN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct FGALCCDFJMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<IPHHHIANCDI>> <>t__builder;

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
		private TaskAwaiter<DOGBGFIFBGJ<NAKFAFENAFD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C27690", Offset = "0x7C26290", VA = "0x187C27690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C278D0", Offset = "0x7C264D0", VA = "0x187C278D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct NLIOEKGLFNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<EOLHPFLLOJO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<EOLHPFLLOJO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C33630", Offset = "0x7C32230", VA = "0x187C33630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C33840", Offset = "0x7C32440", VA = "0x187C33840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	[UnityEngine.Scripting.Preserve]
	public PBMJGBFNHLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C342B0", Offset = "0x7C32EB0", VA = "0x187C342B0", Slot = "4")]
	[AsyncStateMachine(typeof(FGALCCDFJMH))]
	public Task<IReadOnlyList<IPHHHIANCDI>> ABCHIPOJGNE(long EPGJLNEAJPA, long HPCDEBDHAFJ, [Optional] CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C343D0", Offset = "0x7C32FD0", VA = "0x187C343D0", Slot = "5")]
	[AsyncStateMachine(typeof(NLIOEKGLFNB))]
	public Task<IReadOnlyList<EOLHPFLLOJO>> HGMPMEKCHPO(IReadOnlyList<int> ONCDMDBALFP, [Optional] CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PGLMCAEMEFM : IEquatable<PGLMCAEMEFM>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int JLGLKLCGKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	EOLHPFLLOJO BMKIFKMLLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime KCAAHOJEKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	EFDBCIJNJGP? GFOONEBJFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DNDHJFMEHLE? MBHFJEODFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	FDABDNCAIMI NHJAGIOFHOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<DMOINJJJLLJ> ALEHCIEOHNC();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum FDABDNCAIMI
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PHGPPNDHPEN
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<IPHHHIANCDI>> ABCHIPOJGNE(long EPGJLNEAJPA, long HPCDEBDHAFJ, [Optional] CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<EOLHPFLLOJO>> HGMPMEKCHPO(IReadOnlyList<int> ONCDMDBALFP, [Optional] CancellationToken NAOIMKEDKEJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LFJPMEKAPFG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class LMCJPLMCKGB : PGLMCAEMEFM, IEquatable<PGLMCAEMEFM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct HJOFLDLBHLO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<DMOINJJJLLJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public LMCJPLMCKGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private KFAHCBBMCBI <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<BCPENJPKFJJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<DMOINJJJLLJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7C29130", Offset = "0x7C27D30", VA = "0x187C29130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7C295F0", Offset = "0x7C281F0", VA = "0x187C295F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly IPHHHIANCDI NCNKENJCBFG;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int JLGLKLCGKKK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x95B870", Offset = "0x95A470", VA = "0x18095B870", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public EOLHPFLLOJO BMKIFKMLLJC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime ODDICNCFJCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2757770", Offset = "0x2756370", VA = "0x182757770", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public EFDBCIJNJGP? GFOONEBJFNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x103D2C0", Offset = "0x103BEC0", VA = "0x18103D2C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public DNDHJFMEHLE? MBHFJEODFOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2757E90", Offset = "0x2756A90", VA = "0x182757E90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public FDABDNCAIMI NHJAGIOFHOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA78B70", Offset = "0xA77770", VA = "0x180A78B70", Slot = "10")]
			get
			{
				return default(FDABDNCAIMI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7C2ECB0", Offset = "0x7C2D8B0", VA = "0x187C2ECB0", Slot = "9")]
		[AsyncStateMachine(typeof(HJOFLDLBHLO))]
		public Task<DMOINJJJLLJ> ALEHCIEOHNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7C2EFA0", Offset = "0x7C2DBA0", VA = "0x187C2EFA0")]
		public LMCJPLMCKGB(int KKHBDKFKLHA, EOLHPFLLOJO JAJNJFHGGLH, IPHHHIANCDI NCNKENJCBFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7C2EE50", Offset = "0x7C2DA50", VA = "0x187C2EE50", Slot = "11")]
		public bool Equals(PGLMCAEMEFM PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C2EDB0", Offset = "0x7C2D9B0", VA = "0x187C2EDB0", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C2EEE0", Offset = "0x7C2DAE0", VA = "0x187C2EEE0")]
		private bool FNLCEJFBDFK(LMCJPLMCKGB PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C2EF20", Offset = "0x7C2DB20", VA = "0x187C2EF20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class IMMKFKDFAFG : PGLMCAEMEFM, IEquatable<PGLMCAEMEFM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct KIABHOIMAKI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<DMOINJJJLLJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public IMMKFKDFAFG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<DMOINJJJLLJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7C2DDF0", Offset = "0x7C2C9F0", VA = "0x187C2DDF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7C2E040", Offset = "0x7C2CC40", VA = "0x187C2E040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly JOHMHGNLPIP CJOICCOAALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly EFDBCIJNJGP GDPMBOAFNKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly DNDHJFMEHLE LGDEOIMHGNI;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int JLGLKLCGKKK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7C2B0E0", Offset = "0x7C29CE0", VA = "0x187C2B0E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public EOLHPFLLOJO BMKIFKMLLJC
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7C2B000", Offset = "0x7C29C00", VA = "0x187C2B000", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime ODDICNCFJCA
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7C2B090", Offset = "0x7C29C90", VA = "0x187C2B090", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public EFDBCIJNJGP? GFOONEBJFNO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7C2B120", Offset = "0x7C29D20", VA = "0x187C2B120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DNDHJFMEHLE? MBHFJEODFOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7C2AC90", Offset = "0x7C29890", VA = "0x187C2AC90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public FDABDNCAIMI NHJAGIOFHOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA7F430", Offset = "0xA7E030", VA = "0x180A7F430", Slot = "10")]
			get
			{
				return default(FDABDNCAIMI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1BDD310", Offset = "0x1BDBF10", VA = "0x181BDD310")]
		public IMMKFKDFAFG(JOHMHGNLPIP EBANPFALAHB, EFDBCIJNJGP EFMNFPCAKLG, DNDHJFMEHLE CBEHHIAFCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7C2ACE0", Offset = "0x7C298E0", VA = "0x187C2ACE0", Slot = "9")]
		[AsyncStateMachine(typeof(KIABHOIMAKI))]
		public Task<DMOINJJJLLJ> ALEHCIEOHNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C2ADD0", Offset = "0x7C299D0", VA = "0x187C2ADD0", Slot = "11")]
		public bool Equals(PGLMCAEMEFM PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AE70", Offset = "0x7C29A70", VA = "0x187C2AE70", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AF20", Offset = "0x7C29B20", VA = "0x187C2AF20")]
		private bool FNLCEJFBDFK(IMMKFKDFAFG PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AF80", Offset = "0x7C29B80", VA = "0x187C2AF80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class GCJKOEBBDMJ : PGLMCAEMEFM, IEquatable<PGLMCAEMEFM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct ADLNCFOPBMN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<DMOINJJJLLJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<DMOINJJJLLJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7C177D0", Offset = "0x7C163D0", VA = "0x187C177D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7C17A30", Offset = "0x7C16630", VA = "0x187C17A30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly EOLHPFLLOJO NJGJIHAMIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly EFDBCIJNJGP GDPMBOAFNKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly DNDHJFMEHLE LGDEOIMHGNI;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int JLGLKLCGKKK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7C281D0", Offset = "0x7C26DD0", VA = "0x187C281D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public EOLHPFLLOJO BMKIFKMLLJC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime ODDICNCFJCA
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public EFDBCIJNJGP? GFOONEBJFNO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7C281F0", Offset = "0x7C26DF0", VA = "0x187C281F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public DNDHJFMEHLE? MBHFJEODFOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7C27E50", Offset = "0x7C26A50", VA = "0x187C27E50", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public FDABDNCAIMI NHJAGIOFHOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "10")]
			get
			{
				return default(FDABDNCAIMI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1BDD310", Offset = "0x1BDBF10", VA = "0x181BDD310")]
		public GCJKOEBBDMJ(EOLHPFLLOJO JAJNJFHGGLH, EFDBCIJNJGP EFMNFPCAKLG, DNDHJFMEHLE CBEHHIAFCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C27EA0", Offset = "0x7C26AA0", VA = "0x187C27EA0", Slot = "9")]
		[AsyncStateMachine(typeof(ADLNCFOPBMN))]
		public Task<DMOINJJJLLJ> ALEHCIEOHNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7C27FF0", Offset = "0x7C26BF0", VA = "0x187C27FF0", Slot = "11")]
		public bool Equals(PGLMCAEMEFM PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7C27F70", Offset = "0x7C26B70", VA = "0x187C27F70", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C28140", Offset = "0x7C26D40", VA = "0x187C28140", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C28060", Offset = "0x7C26C60", VA = "0x187C28060")]
		private bool FNLCEJFBDFK(GCJKOEBBDMJ PELBNOCGOOJ)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct LNEOHEONGLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<PGLMCAEMEFM>> <>t__builder;

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
		public LFJPMEKAPFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<IPHHHIANCDI> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<IPHHHIANCDI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, EOLHPFLLOJO account, IPHHHIANCDI roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F000", Offset = "0x7C2DC00", VA = "0x187C2F000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7C2FE40", Offset = "0x7C2EA40", VA = "0x187C2FE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct NFNMONONLIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, EOLHPFLLOJO account, IPHHHIANCDI roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<IPHHHIANCDI> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public LFJPMEKAPFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<EOLHPFLLOJO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7C32BF0", Offset = "0x7C317F0", VA = "0x187C32BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7C335C0", Offset = "0x7C321C0", VA = "0x187C335C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LEFOKHFFFDA FCOPOMMNHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly PHGPPNDHPEN KJIJCPPIDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly KKOOLMKCHOG FNFKMPKNMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly MJFHCEFLNCG<(long, long), IReadOnlyList<IPHHHIANCDI>> GHGPDIPABIF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E4B0", Offset = "0x7C2D0B0", VA = "0x187C2E4B0")]
	[UnityEngine.Scripting.Preserve]
	public LFJPMEKAPFG([GJMNBPKNJPO(null)] PHGPPNDHPEN LOPALJMMPKO, [GJMNBPKNJPO(null)] KKOOLMKCHOG DADCDDADCDL, [GJMNBPKNJPO(null)] LEFOKHFFFDA EHLOOMNGPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E360", Offset = "0x7C2CF60", VA = "0x187C2E360")]
	[AsyncStateMachine(typeof(LNEOHEONGLK))]
	public Task<IList<PGLMCAEMEFM>> IFGMFMBBGCA(long EPGJLNEAJPA, long DMLJPKIDBPD, bool CFJJOIJOFAC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E1C0", Offset = "0x7C2CDC0", VA = "0x187C2E1C0")]
	private bool EBDHHELCNME(DateTime? MMBADDCBNLH, long EPGJLNEAJPA, long DMLJPKIDBPD, [Out] JOHMHGNLPIP ENLLCILGBAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E0B0", Offset = "0x7C2CCB0", VA = "0x187C2E0B0")]
	[AsyncStateMachine(typeof(NFNMONONLIK))]
	private Task<IReadOnlyList<(int, EOLHPFLLOJO, IPHHHIANCDI)>> BBOOJJMCJHN(IReadOnlyList<IPHHHIANCDI> DJPCMDCFDJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KKOOLMKCHOG
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<JOHMHGNLPIP> BFEPKBBCMCP;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool INCLJBDGBOB(long EPGJLNEAJPA, long DMLJPKIDBPD, DDJCMNHOHEN KCBKNEHLEEA, GBJMJAJMANP GEJNDLMJHME);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MFHFFEHNIKO(long EPGJLNEAJPA, long DMLJPKIDBPD, [Out] JOHMHGNLPIP ENLLCILGBAC);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LPKAGKCOACE(long EPGJLNEAJPA, long DMLJPKIDBPD, GBJMJAJMANP GEJNDLMJHME, [Out] JOHMHGNLPIP ENLLCILGBAC);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OFAPFGJBOHF(long EPGJLNEAJPA, long DMLJPKIDBPD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface FGGAIJEAMEP : ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KMMKJACJCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task NFLEINHEBJA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MONNCEBBBOJ(Task LFJIOJDNNEN, string MFJBFAFDEAH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface IHBMKCGFJGL : ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DMOINJJJLLJ> FBHOKADAIID(JOHMHGNLPIP ENLLCILGBAC);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AKMDIOCAGBM(CancellationToken NAOIMKEDKEJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface IIEJDJFCFPM : ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	OAACMBCGIPK IIFFMEJALBO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCLOLKDCEJC();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KELAEPMKBPI();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface ABCMKPCOBHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIMKJDEKJHN(CCOEFMMBAGF MGMNCIIJMMO);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface NEEOCIBJGGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan BOFKCLHPEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan FANBMILHKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan BLFPFHOOJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan LCNNKHFMMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool GABHFHNHBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool LCMCBAMCJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool GOKJGKEMMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int CDMJKOMFNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool HALCKEGMOLN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool KACFBFKCAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum NOGJPOGGCIF
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum KMCPGADBLKC
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
public struct LJCMGKIJECP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long ICNOBLKLHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long HPCDEBDHAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly NOGJPOGGCIF ADFFEBFOCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception FEBDNKCGBHE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7C2EA00", Offset = "0x7C2D600", VA = "0x187C2EA00")]
	public LJCMGKIJECP(long ICNOBLKLHAG, long HPCDEBDHAFJ, NOGJPOGGCIF ADFFEBFOCBD, [CanBeNull] Exception FEBDNKCGBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E9B0", Offset = "0x7C2D5B0", VA = "0x187C2E9B0")]
	public static LJCMGKIJECP HOIGFCMABAE(GJIEMBMKFED JPHOBLFNMNH, NOGJPOGGCIF ADFFEBFOCBD, [Optional] Exception FEBDNKCGBHE)
	{
		return default(LJCMGKIJECP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void NCGDELCGGDE(LJCMGKIJECP EAHKGKDJCMN);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface GPIHMDFOHPE : ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action LNGMNBHAMCE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event NCGDELCGGDE AKMHMDCNIEB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NCGDELCGGDE IADKAOFIIPN;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event NCGDELCGGDE NACOJLMEONL;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KDNLCFEPOPL();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LBIFLJEKILN(LJCMGKIJECP EAHKGKDJCMN);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FDIEAODCIFO(LJCMGKIJECP EAHKGKDJCMN);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JOCOHLNIHKJ(LJCMGKIJECP EAHKGKDJCMN);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LNLNGBMCHFI(KMCPGADBLKC PAHFPJDPHAE, bool CFLNFJDNJEK);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface MPINOMEJPKK : ABCMKPCOBHD, IDisposable
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

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool PJBIMMMMEKM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LANGLIOODDP(Reason NCKCEGPNPKI = Reason.Unknown);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BBODPILKOJD();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface OLHPKBEDEOA : ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	TaskStatus HOPCDBOPLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CHOLCBOMNGK(GJIEMBMKFED EACCLNFIEFF, DDBLHNHDLGD FOCFEKCFLGP, CancellationToken MJJLMJBFHKM);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class BIGHBMMEMFG
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C19C60", Offset = "0x7C18860", VA = "0x187C19C60")]
	public static bool FLMPKEFBNGJ(this OLHPKBEDEOA KMMOMAHEDJH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task FJGJIIFMOMM(CancellationToken IKLHDHMJFFL, int EPFOEOAPCEG, HNNAMAANNEG ANOEIEDBMIG);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface BJGILIINBGI : ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ANNCKHMPBMO(FJGJIIFMOMM GDHNNPJICDB);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface CCOEFMMBAGF : KFAHCBBMCBI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	CancellationToken LJMCHFHNKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	KPLLBHIBBNH DNOIHHONCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	CIFPFBINLMO KAOPEMANLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ECDMOFDHGEJ MKOFOFDAJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	FELCLIHLJOK GNGHLGLBLNG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	KBHJNNDHNLA MIGBFCLAGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	DBKFCHLKGLK JMOLHIPNKME
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	EJKKNOAOEIP JHIGHNIFCKP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	CGFOHGKICKB HNHLIDOGHKN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	FGGAIJEAMEP FPKAIIPIMCN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	IHBMKCGFJGL PPCACAGMJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	GPIHMDFOHPE HGMIEECGJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	MPINOMEJPKK ILFEPNEEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	OLHPKBEDEOA JFHBAMPKIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	BJGILIINBGI HDMPOBBDIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	KDECNGEPAAI JHEOFMGJIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	PDCJABGHHFC NEFPLGPDLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	LLLFKIDLHGI JNCACCOJPCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	KJOBOODKMKB PGEGDHCIBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	GPDONAADODL FCFJDPLLMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	NHDAALLPKCI MGFEALFBPHM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	CBOGOEJPCKE CLLEKFILIKF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	EALAPKIKAFC JOGIPFKAPPF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	EAMEOBBBCIN JLDPAECBOPP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	LKPDIPCHIEG HABMLJJCLFK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	IIEJDJFCFPM IOAGDMMKEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	NEEOCIBJGGJ PKJJMPLJKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	CHEPJELAGEF OEADEHFMLDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	KKOOLMKCHOG EFPIIPOGDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	HIOHOGPJAAA OOKKCKOLOEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	NBDPEGDJHOL NEBBEHOMIBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	HJCFJFKLJMF BHMHFFMIALD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	FCIPKPGJBNG CHDKJKKOJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	new bool GKOAHADDDIO
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
	void NPEOHAEMDEL(DDBLHNHDLGD EBDBNJJEPPE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface KDECNGEPAAI : ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	POGPPOMAOEO GFCJDEIJPEO(Guid HBKGJHPGIDP);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BLAPNJAELFA(Guid HBKGJHPGIDP);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IIIAFNOJFBG(Guid HBKGJHPGIDP, Task HLCGKBBHCJE);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CCICOIKDLMF(Guid HBKGJHPGIDP, DMOINJJJLLJ AGKFIFJKFEP);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(DMOINJJJLLJ, Task)> OJEIPDEFBEP(Guid HBKGJHPGIDP);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface FNMGEKHAILD : ABCMKPCOBHD, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface PDCJABGHHFC : ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEOLKGFAPKN(DKFJDNOJOIC KBPDEFFIKOJ);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GACJNNJAFBL(DKFJDNOJOIC KBPDEFFIKOJ);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<DOGDFHEJDDI> FCKJFBKBJKF(CancellationToken KEALLEAKBOD);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface LLLFKIDLHGI : ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	POGPPOMAOEO CMELBMPKPLF(DKFJDNOJOIC CPJONCGIFLG);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GDLNKACPCKK(Guid HBKGJHPGIDP, Task HLCGKBBHCJE);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface KJOBOODKMKB : ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DMOINJJJLLJ> PGEGDHCIBKO(DKFJDNOJOIC AGMOEDNNLFN);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface GPDONAADODL : ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PDKHDMNJGNI> PFGLCLNJFPE(FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, GJIEMBMKFED EACCLNFIEFF, CancellationToken NAOIMKEDKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface CBOGOEJPCKE : ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DMOINJJJLLJ CGGNGAAGOPG(GDNMNFALBCN IBIKFHPOJNI);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OOFIKMNJGDK(string ICLCPILCBMO);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface NHDAALLPKCI : ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DKFJDNOJOIC> PGHFHLOADDI(DKFJDNOJOIC AGFMCIMDGME, CBACDIIFINF KPKLENBGBEA, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<DKFJDNOJOIC> NMKJMPELNOL(CancellationToken NAOIMKEDKEJ, CBACDIIFINF KPKLENBGBEA);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GDLHPPGEFNI ECEKBFKNOKP(AIKLBIMPFFC BDEENMDMDJI, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GDLHPPGEFNI JDCKKAEJELF(AIKLBIMPFFC BDEENMDMDJI, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface EALAPKIKAFC : ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DMOINJJJLLJ LEMINGEICKE(GDNMNFALBCN IBIKFHPOJNI, DOGDFHEJDDI KOJKHHJNKAC);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DMOINJJJLLJ LHLMKDDMAOE(GDNMNFALBCN JGPFOMMMDPB);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface EAMEOBBBCIN
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HKKBINIGIDM(DKHGBKGEGOM FGKGKPADGPD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNFCJPCCDAB(DKHGBKGEGOM FGKGKPADGPD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GHDHDHKDJDL(DKHGBKGEGOM FGKGKPADGPD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FIGKBKFOMNE(DKHGBKGEGOM FGKGKPADGPD);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class DKHGBKGEGOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly GJIEMBMKFED HMHCFEMAKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private Dictionary<string, string> OOGMBMPLIIF;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public FNEANCIAOBI<string> PKANCLJENJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x957500", Offset = "0x956100", VA = "0x180957500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	public DKHGBKGEGOM(GJIEMBMKFED LHACABBHAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FB30", Offset = "0x7C1E730", VA = "0x187C1FB30")]
	public DKHGBKGEGOM INJJNAHCLEH(string NKANGPLHEGE, string MPDLOLIOGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FAA0", Offset = "0x7C1E6A0", VA = "0x187C1FAA0")]
	public bool EGMOCFDMEIF([Out] IEnumerable<KeyValuePair<string, string>> BCHGHFMPHGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D407A0", Offset = "0x6D3F3A0", VA = "0x186D407A0")]
	public DKHGBKGEGOM MALNHGFMFMA(FNEANCIAOBI<string> IFHLDBMAMPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CHEPJELAGEF
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool FOMDLAEINKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string GEJAGBHBCHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool ICGIBBIEDON
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JHBIKMFKMLH();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LDHNIHMDDKI AOGFEHGJPNJ(long JKENKIDPAII);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EICOLPKHCNF<HEJHHLFMEKL, PGMIGGEMMKL> BKPHHHMJFCE(long JKENKIDPAII);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EICOLPKHCNF<HEJHHLFMEKL, OFOCKDHGIHJ> KLAJNFPFOCF(long JKENKIDPAII);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EICOLPKHCNF<long, KPGCKGMEOEP> MFEKAAAPNNK();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ADPAIKEPDAD(long JKENKIDPAII, [Out] bool IOFFKBCDMEN);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> LJAFJAHOOAH(byte[] MAGHCEFJIPG, byte[] LLKJICLKDCC, CancellationToken NAOIMKEDKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface KFAHCBBMCBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool FLMPKEFBNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool EKGPDNCJJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool GKOAHADDDIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	DDBLHNHDLGD IPCEDNBGLEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action LNGMNBHAMCE;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event NCGDELCGGDE AKMHMDCNIEB;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NCGDELCGGDE IADKAOFIIPN;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event NCGDELCGGDE NACOJLMEONL;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BBODPILKOJD();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BFMECADPGLO CKBLGGGJAGK();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BJHDMGOPKCA ACMJCJDBKIL();

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task<DMOINJJJLLJ> FBHOKADAIID(JOHMHGNLPIP EBANPFALAHB);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task AKMDIOCAGBM(CancellationToken NAOIMKEDKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface KBHJNNDHNLA
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool CCPGCEOHJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	string IICHCKDFCGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLFOIKAKGOE(Scene EMCNLPPGAFD);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task EGCLOLODBCH(EBJBDIAEPAJ HKBPNDMHLII, IReadOnlyList<EBJBDIAEPAJ> MHOPJFMOGID, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HDLLEAMNECF();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task ODGHEAJGHHN();
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface FELCLIHLJOK
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	ONBJJNNFOFI EKBCFEONFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool OJMCGOKKNPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool OACLJAGMIBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool CIEIFCGKGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool DFEFENMCLFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	int CJDPAJEEHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool LIHDKLBPKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool AHKKHEJAOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	int HMONOKNJDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	int OANJMIPAELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool PLFEMNKNBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool HKBLIGBPOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool JLDCODIOFDA
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	float PCIFCLJOEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<float> NAILPEBPAFJ;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KPLLBHIBBNH CBKNEJHLPGB(KPLLBHIBBNH LNIINKOLAGG);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMKCDJNDJCO(KPLLBHIBBNH AGGFAPJEEEN);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OCFMAFCJCCO();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task EMBCLCDPBAD(FNEANCIAOBI<string>.IDKBCAKILKJ MFFDPDFGHLB, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KFLHGGLIMDP(float FBHIHMHGJOE);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OLEPDGIPMFD(string JLDGAOJPDBN);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<HGFIOFABNDK> MIPBFBDHKKA();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable NGEOJKLBFBD(object HJIAOGEIAJO, HGFIOFABNDK LNAHAHEDANG);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<LLFODJKOGKI> DGGDCFPHPIO();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PGMIGGEMMKL HEBGPBBJEHL(IEnumerable<IJKLPCMEAKO> IIKONCIHAIC);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NAHPIHCPHIH(int BODILIPNFGI);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task HKJDHLHDANJ();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JIIPKEKFGLA();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool IILDCCGCFAL();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task HLJGHMAKCBI(CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task DAODPDFGJJP(CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<MHCHKHKIDOP> IMOGKOCFLEF(DateTime KKICIAONAIH, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> MNMJGGLDKEJ(CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OMOOGDGHOGD(string KBPDEFFIKOJ = "", float ALPIBOHIFKI = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "25")]
	JEDFCFCIPKF ALHLALGGLKH(ALDOMEDIEBM HEFJEHMANPA, OFIKJAIFHJE ODLAGEOHJKB, OFOCKDHGIHJ DIMMCCLGMGB, IEnumerable<PersistenceView> IMBOBJIGNAH, OFMCEBLPNDA MBGKPCMEDFL);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HKDHJDBMDEO(OFOCKDHGIHJ DIMMCCLGMGB);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EIACEEDNEHD(IJKLPCMEAKO AIINMDJLKBF, [In] JEDFCFCIPKF DKCKOHHDAEN);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task OCECHMLKHDE(OFOCKDHGIHJ HMPKKHEGEKK, bool INOGLDHCFID, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task OJOKCGOJNCH(CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void OBBPMEPFDEB(long EPGJLNEAJPA, long HPCDEBDHAFJ, BCPENJPKFJJ MDPGCFDKEND, IPHHHIANCDI OJJAMPIBBBB, DDJCMNHOHEN KCBKNEHLEEA, DJAABFPCNFG? DHCBPLHFGNP, GLNOINNEODG? IAEOKHNKAHO);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void AOOMBKIHGDN(long EPGJLNEAJPA, long HPCDEBDHAFJ, GLNOINNEODG? IAEOKHNKAHO);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void OLEGDPINIFJ(PersistenceView GHHKMJKCOEK);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void ADBCLOLCOIH(string MBCJKDNCLIP, GJIEMBMKFED LHACABBHAGD, JCOCCFMLIAE MPNJBLCNBBK, [Optional] string? ADDFDGJLHEP, [Optional] string? NALFFOBDHGM, [Optional] string? CCHHOJGJHED);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool BNILMDPOHDP(PersistenceView DPCLJPBHKAL);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool PKEEOAKCBMC(IJKLPCMEAKO AIINMDJLKBF, LFHJKKOJGDF ELCHENGMGIK, [Out] IODINKAINFK CPIKHJILDIE);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task EMAKCOOIPFC(CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void EPOBGFKFEON();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable ECCONLFPDCJ();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void OAPGNEPHMBL(OFOCKDHGIHJ HMPKKHEGEKK, LFHJKKOJGDF ELCHENGMGIK);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> LCIBIKCBJKA(CIFPFBINLMO CDOHCPAIEHP, CancellationToken NAOIMKEDKEJ, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void HOKJOILLELH(CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<BGHBHPAMLJF> HOEOIPDKMLH(EMJPNEAAKMK AGFMCIMDGME);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<BCPENJPKFJJ> BEJHJPOGEAL(long EPGJLNEAJPA, bool APBABPBMAAM, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<NAKFAFENAFD> EDEOOPBOFKC(long EPGJLNEAJPA, long HPCDEBDHAFJ, long BHNIPLLDJPL, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<NAKFAFENAFD> KGANDNFAFFG(long EPGJLNEAJPA, long HPCDEBDHAFJ, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<NBCCHAPKOEK> NPIOLHLHCOJ(string MDHENNAADKE, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "47")]
	Task<NBCCHAPKOEK> MKPEELCPPIJ(string MDHENNAADKE, long EPGJLNEAJPA, long HPCDEBDHAFJ, string ECHHHHOHFJN, APMILOHFFGE.CINCBNFEIDP FDFFMDBCAPG, APMILOHFFGE.CINCBNFEIDP LLKJICLKDCC, int HGCGPNLLJML);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool GNHHGEKPECI();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool MOCHDEFNGJH();

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool DAKKODKGANF(IEnumerable<IODINKAINFK> OINNHINDNBH);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void FNGFGDJFBIK(List<GameObject> ACECFFBAIOD);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "53")]
	float HCCHMGEJMDL();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "54")]
	Task<bool> PMDKCIPAJNP(CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "55")]
	Task<Scene> MBDCBPDLHIM(string JMDBEOGKEMG, LoadSceneMode FGKKLFOHPGD, bool BJEPJNHFKNK, FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void ILGJOELFNFE();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void LCFJHKLFMCA(bool BEPIDPDHFCG);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void JLKGIOAKHKC();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void AGLDCHGMAKN();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void CJAFIONEJJJ(bool OHIBCJODAOB);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void BAGJLHHKFJH(GJIEMBMKFED FHCHGLDFBAF);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task LPAKGPPOFKG(FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task NNBBPIKMEOE(FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task JLAOIGPGBNJ(FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task FBEEIMGACJE(FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "75")]
	IDisposable KFCDFJFGJNN();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "76")]
	ENOABELDKIL OMEOMMKMPBH();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "77")]
	Task BDJNKJPKPEM(CancellationToken NAOIMKEDKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface ENOABELDKIL
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BNOEKEOGAGA(CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PHFILHDKBNF(CancellationToken NAOIMKEDKEJ);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct JEDFCFCIPKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public HashSet<int> HAFLNDHCGNA;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum MHCHKHKIDOP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct ALDOMEDIEBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public string JHPMMGNBIPP;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface ONBJJNNFOFI
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	GJIEMBMKFED MLACALBADOG
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	BCPENJPKFJJ CEGCIDADGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	FFBHBDHOGKB LNHGCFPPEON
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool JIBNOIAENBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	bool EGFLNCGAJHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	int JAAJNMEFHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action AJGKBLKBMHF;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<int> IECCOHAMAHH;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OHODBGJNCEA();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.HAFHDNLIOHN> DMJJGEMHNGB(long JKENKIDPAII, [Optional] CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<GLCGEGGFDHI> NMMACMIBJNM(GJIEMBMKFED LHACABBHAGD, [Optional] DDBLHNHDLGD FOCFEKCFLGP);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<GLCGEGGFDHI> CIHIADHBMGK();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task HPKOAPBBKCN();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(GJIEMBMKFED, DDBLHNHDLGD) CBJEMEMDJJO();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KHAMOMBBPPI LNDBHEFBOHC();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BAALFCKGLCM(long JKENKIDPAII);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NMEDGGFAMIG(GJIEMBMKFED LHACABBHAGD, Matchmaking.JMHPPLNHBHC HBANOBDOKBJ, (int Major, int? Minor)? LNJMPIHLDED);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface LKPDIPCHIEG
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBEMIJDFKOO([Out] IEnumerable<int> LPHIKIIAFMJ);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PCLLCLFIELK(ABCMEDAMFNA IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEENKCEMNCF(ABCMEDAMFNA IKLHDHMJFFL);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface COOKCPHLAFN
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NMDAGCFMOLP(DMOINJJJLLJ IIHIICEIEJN);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface CPACBEBFPFG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKBPFCHBCLH(BHEOGNFHJLM.LMDFJICBCCE GIPAELEOGOO);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFOJHBIOELB(BHEOGNFHJLM.LMDFJICBCCE GIPAELEOGOO);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface DBKFCHLKGLK : CPACBEBFPFG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DMOINJJJLLJ KFMHALGOHGK(GDNMNFALBCN JGPFOMMMDPB);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface EJKKNOAOEIP : CPACBEBFPFG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DMOINJJJLLJ CGGNGAAGOPG(GDNMNFALBCN JCNJPDCHNEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface LDHNIHMDDKI
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PNJEPLMEKHI<EBJBDIAEPAJ, KLJHHNJNNDG>> EOFHLNNMNAE(string ECHHHHOHFJN, long JKENKIDPAII, long? EPGJLNEAJPA, long? HPCDEBDHAFJ, OEKPEONBLNM.ADAAGALHODG BPJMGGENCKI, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<PNJEPLMEKHI<IReadOnlyList<EBJBDIAEPAJ>, KLJHHNJNNDG>> PHGBBEMNALE(IReadOnlyList<DIKJEBDFCIA> MKPGCELACMI, CancellationToken NAOIMKEDKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface EICOLPKHCNF<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PNJEPLMEKHI<HAKOKJPNEOL<TData>, KLJHHNJNNDG>> BIDEKLFLOLH(TGetDataArg GJPLANLJOMM, CancellationToken NAOIMKEDKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal sealed class CGJACEPBDPD : CCOEFMMBAGF, KFAHCBBMCBI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct NDKPHKIHICK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder<DMOINJJJLLJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public CGJACEPBDPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public JOHMHGNLPIP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<DMOINJJJLLJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C32900", Offset = "0x7C31500", VA = "0x187C32900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C32B80", Offset = "0x7C31780", VA = "0x187C32B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct LJEBLMNEELC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CGJACEPBDPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C2EA20", Offset = "0x7C2D620", VA = "0x187C2EA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C2EC50", Offset = "0x7C2D850", VA = "0x187C2EC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class MBMBPDPHIFL : IEnumerable<ABCMKPCOBHD>, IEnumerable, IEnumerator<ABCMKPCOBHD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ABCMKPCOBHD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CGJACEPBDPD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private ABCMKPCOBHD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xD30330", Offset = "0xD2EF30", VA = "0x180D30330")]
		[DebuggerHidden]
		public MBMBPDPHIFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C30560", Offset = "0x7C2F160", VA = "0x187C30560", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C309C0", Offset = "0x7C2F5C0", VA = "0x187C309C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C30910", Offset = "0x7C2F510", VA = "0x187C30910", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ABCMKPCOBHD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C30910", Offset = "0x7C2F510", VA = "0x187C30910", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly CancellationTokenSource KPJCKFDMLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly KPLLBHIBBNH AGGFAPJEEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool EIHBPFOIIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private CDLHLOBNCOL KDJHFLICGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool NGKHCLEMJMM;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public CIFPFBINLMO KAOPEMANLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x95F000", Offset = "0x95DC00", VA = "0x18095F000", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x95EFF0", Offset = "0x95DBF0", VA = "0x18095EFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public ECDMOFDHGEJ MKOFOFDAJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x95F010", Offset = "0x95DC10", VA = "0x18095F010", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x95F040", Offset = "0x95DC40", VA = "0x18095F040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public FELCLIHLJOK GNGHLGLBLNG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x95F020", Offset = "0x95DC20", VA = "0x18095F020", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x95F030", Offset = "0x95DC30", VA = "0x18095F030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public KBHJNNDHNLA MIGBFCLAGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x961520", Offset = "0x960120", VA = "0x180961520", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x961530", Offset = "0x960130", VA = "0x180961530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public DBKFCHLKGLK JMOLHIPNKME
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x961620", Offset = "0x960220", VA = "0x180961620", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9615F0", Offset = "0x9601F0", VA = "0x1809615F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public EJKKNOAOEIP JHIGHNIFCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x963230", Offset = "0x961E30", VA = "0x180963230", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x963150", Offset = "0x961D50", VA = "0x180963150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public CGFOHGKICKB HNHLIDOGHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x963180", Offset = "0x961D80", VA = "0x180963180", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9631B0", Offset = "0x961DB0", VA = "0x1809631B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public FGGAIJEAMEP FPKAIIPIMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9631F0", Offset = "0x961DF0", VA = "0x1809631F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x963190", Offset = "0x961D90", VA = "0x180963190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public IHBMKCGFJGL PPCACAGMJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA79300", Offset = "0xA77F00", VA = "0x180A79300", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x1116760", Offset = "0x1115360", VA = "0x181116760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public GPIHMDFOHPE HGMIEECGJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x963170", Offset = "0x961D70", VA = "0x180963170", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9630D0", Offset = "0x961CD0", VA = "0x1809630D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public MPINOMEJPKK ILFEPNEEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xB8FC30", Offset = "0xB8E830", VA = "0x180B8FC30", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xCE2060", Offset = "0xCE0C60", VA = "0x180CE2060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public OLHPKBEDEOA JFHBAMPKIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x95A600", Offset = "0x959200", VA = "0x18095A600", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x95A5E0", Offset = "0x9591E0", VA = "0x18095A5E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public BJGILIINBGI HDMPOBBDIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xAC2650", Offset = "0xAC1250", VA = "0x180AC2650", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xCF11F0", Offset = "0xCEFDF0", VA = "0x180CF11F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public KDECNGEPAAI JHEOFMGJIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xBCAC00", Offset = "0xBC9800", VA = "0x180BCAC00", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xBCAC10", Offset = "0xBC9810", VA = "0x180BCAC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public FNMGEKHAILD GHMIMPPBHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xB8FB00", Offset = "0xB8E700", VA = "0x180B8FB00", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xF779E0", Offset = "0xF765E0", VA = "0x180F779E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public PDCJABGHHFC NEFPLGPDLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xB7B030", Offset = "0xB79C30", VA = "0x180B7B030", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xBFDA30", Offset = "0xBFC630", VA = "0x180BFDA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public LLLFKIDLHGI JNCACCOJPCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA44580", Offset = "0xA43180", VA = "0x180A44580", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA441D0", Offset = "0xA42DD0", VA = "0x180A441D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public KJOBOODKMKB PGEGDHCIBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x95A5D0", Offset = "0x9591D0", VA = "0x18095A5D0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x95A5B0", Offset = "0x9591B0", VA = "0x18095A5B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public GPDONAADODL FCFJDPLLMHP
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA48EF0", Offset = "0xA47AF0", VA = "0x180A48EF0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA48D50", Offset = "0xA47950", VA = "0x180A48D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public NHDAALLPKCI MGFEALFBPHM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA621E0", Offset = "0xA60DE0", VA = "0x180A621E0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA60750", Offset = "0xA5F350", VA = "0x180A60750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public CBOGOEJPCKE CLLEKFILIKF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA42760", Offset = "0xA41360", VA = "0x180A42760", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA60770", Offset = "0xA5F370", VA = "0x180A60770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public EALAPKIKAFC JOGIPFKAPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA42890", Offset = "0xA41490", VA = "0x180A42890", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA48950", Offset = "0xA47550", VA = "0x180A48950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public EAMEOBBBCIN JLDPAECBOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA428A0", Offset = "0xA414A0", VA = "0x180A428A0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7A0", Offset = "0xA3D3A0", VA = "0x180A3E7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public LKPDIPCHIEG HABMLJJCLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9C3DC0", Offset = "0x9C29C0", VA = "0x1809C3DC0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9C8B80", Offset = "0x9C7780", VA = "0x1809C8B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public IIEJDJFCFPM IOAGDMMKEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA36C20", Offset = "0xA35820", VA = "0x180A36C20", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x11F6800", Offset = "0x11F5400", VA = "0x1811F6800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public NEEOCIBJGGJ PKJJMPLJKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9C9D70", Offset = "0x9C8970", VA = "0x1809C9D70", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5D0", Offset = "0xA3E1D0", VA = "0x180A3F5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public CHEPJELAGEF OEADEHFMLDD
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9C0D70", Offset = "0x9BF970", VA = "0x1809C0D70", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA6A190", Offset = "0xA68D90", VA = "0x180A6A190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public KKOOLMKCHOG EFPIIPOGDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9C0930", Offset = "0x9BF530", VA = "0x1809C0930", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public HIOHOGPJAAA OOKKCKOLOEK
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9B9B30", Offset = "0x9B8730", VA = "0x1809B9B30", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public NBDPEGDJHOL NEBBEHOMIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9C0B50", Offset = "0x9BF750", VA = "0x1809C0B50", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public HJCFJFKLJMF BHMHFFMIALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9C6F90", Offset = "0x9C5B90", VA = "0x1809C6F90", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public FCIPKPGJBNG CHDKJKKOJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9BA060", Offset = "0x9B8C60", VA = "0x1809BA060", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public DDBLHNHDLGD IPCEDNBGLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA300E0", Offset = "0xA2ECE0", VA = "0x180A300E0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x11F67C0", Offset = "0x11F53C0", VA = "0x1811F67C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private bool CODNFDILIHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C1AFA0", Offset = "0x7C19BA0", VA = "0x187C1AFA0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private bool CMIHJJCEHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C1AB10", Offset = "0x7C19710", VA = "0x187C1AB10", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private bool ALPBENJNNIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x1177510", Offset = "0x1176110", VA = "0x181177510", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private CancellationToken JMOIKNOMLON
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C1ADF0", Offset = "0x7C199F0", VA = "0x187C1ADF0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private KPLLBHIBBNH CMBJGOHEBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private bool PKCFLMLBJLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1177510", Offset = "0x1176110", VA = "0x181177510", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1173FA0", Offset = "0x1172BA0", VA = "0x181173FA0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event Action DAAOAKHHFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B250", Offset = "0x7C19E50", VA = "0x187C1B250", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B0D0", Offset = "0x7C19CD0", VA = "0x187C1B0D0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event NCGDELCGGDE OBHALLKPEHK
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B190", Offset = "0x7C19D90", VA = "0x187C1B190", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B1F0", Offset = "0x7C19DF0", VA = "0x187C1B1F0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event NCGDELCGGDE HKIEBAKPEFP
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B130", Offset = "0x7C19D30", VA = "0x187C1B130", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7C1AC40", Offset = "0x7C19840", VA = "0x187C1AC40", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event NCGDELCGGDE HLGIHNGEHIN
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B450", Offset = "0x7C1A050", VA = "0x187C1B450", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1AD90", Offset = "0x7C19990", VA = "0x187C1AD90", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x11F67C0", Offset = "0x11F53C0", VA = "0x1811F67C0", Slot = "39")]
	public void NPEOHAEMDEL(DDBLHNHDLGD EBDBNJJEPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B510", Offset = "0x7C1A110", VA = "0x187C1B510")]
	[UnityEngine.Scripting.Preserve]
	internal CGJACEPBDPD([GJMNBPKNJPO(null)] KPLLBHIBBNH AGGFAPJEEEN, [GJMNBPKNJPO(null)] CIFPFBINLMO CDOHCPAIEHP, [GJMNBPKNJPO(null)] ECDMOFDHGEJ ACMMBDBLFHG, [GJMNBPKNJPO(null)] FELCLIHLJOK JOHAHHCBBCJ, [GJMNBPKNJPO(null)] KBHJNNDHNLA PABJAONDCNG, [GJMNBPKNJPO(null)] DBKFCHLKGLK GENCLJMEBBO, [GJMNBPKNJPO(null)] EJKKNOAOEIP HJEGEEMLDLJ, [GJMNBPKNJPO(null)] CGFOHGKICKB MEHMKCADMMB, [GJMNBPKNJPO(null)] FGGAIJEAMEP FHKHLMMIGDI, [GJMNBPKNJPO(null)] IHBMKCGFJGL HCNALOEFLKE, [GJMNBPKNJPO(null)] GPIHMDFOHPE IFDKMFMNDDG, [GJMNBPKNJPO(null)] MPINOMEJPKK ABOHOLFMPHN, [GJMNBPKNJPO(null)] OLHPKBEDEOA KMMOMAHEDJH, [GJMNBPKNJPO(null)] BJGILIINBGI GMJBBBDFEND, [GJMNBPKNJPO(null)] KDECNGEPAAI PONCODGMFPK, [GJMNBPKNJPO(null)] FNMGEKHAILD FKDMDJDKHPP, [GJMNBPKNJPO(null)] PDCJABGHHFC PHBFKKCLDJE, [GJMNBPKNJPO(null)] LLLFKIDLHGI PBMHENEEDHE, [GJMNBPKNJPO(null)] KJOBOODKMKB EKLKLKCPHLH, [GJMNBPKNJPO(null)] GPDONAADODL PJHIGGOLAIL, [GJMNBPKNJPO(null)] CBOGOEJPCKE GFHJHLLJNLJ, [GJMNBPKNJPO(null)] NHDAALLPKCI KJIOALHKEEA, [GJMNBPKNJPO(null)] EALAPKIKAFC AGMAIPCGBNJ, [GJMNBPKNJPO(null)] EAMEOBBBCIN MPOAIPEIGPB, [GJMNBPKNJPO(null)] LKPDIPCHIEG DHCICOPFIBG, [GJMNBPKNJPO(null)] NEEOCIBJGGJ BKDMEACEJJF, [GJMNBPKNJPO(null)] CHEPJELAGEF GLAGPEJLAML, [GJMNBPKNJPO(null)] KKOOLMKCHOG OFAPHEOGOBA, [GJMNBPKNJPO(null)] HIOHOGPJAAA LLKJEFLGJGE, [GJMNBPKNJPO(null)] NBDPEGDJHOL JACJFOPJCNE, [GJMNBPKNJPO(null)] HJCFJFKLJMF IHNKLAIIBOJ, [GJMNBPKNJPO(null)] FCIPKPGJBNG KDFODFHJFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AB90", Offset = "0x7C19790", VA = "0x187C1AB90")]
	private void AIMKJDEKJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AE10", Offset = "0x7C19A10", VA = "0x187C1AE10", Slot = "57")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B000", Offset = "0x7C19C00", VA = "0x187C1B000", Slot = "51")]
	private void EKLLIMMPLNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AA80", Offset = "0x7C19680", VA = "0x187C1AA80", Slot = "52")]
	private BFMECADPGLO AAIGGNOMCNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B2B0", Offset = "0x7C19EB0", VA = "0x187C1B2B0", Slot = "53")]
	private BJHDMGOPKCA NIFBKCBMDPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B340", Offset = "0x7C19F40", VA = "0x187C1B340", Slot = "54")]
	[AsyncStateMachine(typeof(NDKPHKIHICK))]
	private Task<DMOINJJJLLJ> OCDMDPBALBO(JOHMHGNLPIP ENLLCILGBAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C1ACA0", Offset = "0x7C198A0", VA = "0x187C1ACA0", Slot = "55")]
	[AsyncStateMachine(typeof(LJEBLMNEELC))]
	private Task BOKGLCMMLGA(CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B050", Offset = "0x7C19C50", VA = "0x187C1B050")]
	[IteratorStateMachine(typeof(MBMBPDPHIFL))]
	private IEnumerable<ABCMKPCOBHD> GMMOIGCDEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B4B0", Offset = "0x7C1A0B0", VA = "0x187C1B4B0")]
	[CompilerGenerated]
	private void PEINMCPAJKC(ABCMKPCOBHD AKHNIBOPJIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class AKDJIPNABPE : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x157DE70", Offset = "0x157CA70", VA = "0x18157DE70")]
	public AKDJIPNABPE(string KBPDEFFIKOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class BMKNDMLGNHO : LAGIOCNLPCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct KANAHEIDPLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AsyncTaskMethodBuilder<LAGIOCNLPCJ.ILDEHJEOCIB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public HashSet<MPINOMEJPKK.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public BMKNDMLGNHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BDE0", Offset = "0x7C2A9E0", VA = "0x187C2BDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C2C0E0", Offset = "0x7C2ACE0", VA = "0x187C2C0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly CCOEFMMBAGF MGMNCIIJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly FELCLIHLJOK JOHAHHCBBCJ;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private string PKHPAPFANFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A150", Offset = "0x7C18D50", VA = "0x187C1A150", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x9677A0", Offset = "0x9663A0", VA = "0x1809677A0")]
	public BMKNDMLGNHO(CCOEFMMBAGF MGMNCIIJMMO, FELCLIHLJOK JOHAHHCBBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A180", Offset = "0x7C18D80", VA = "0x187C1A180", Slot = "5")]
	[AsyncStateMachine(typeof(KANAHEIDPLA))]
	public Task<LAGIOCNLPCJ.ILDEHJEOCIB> OJMKABAIEKO(HashSet<MPINOMEJPKK.Reason> ABDJIDIOHLI, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class ONGNHADCGDP : CHBBLLJPINJ, LAGIOCNLPCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct EBDBLFHBDAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder<LAGIOCNLPCJ.ILDEHJEOCIB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public ONGNHADCGDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public HashSet<MPINOMEJPKK.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private GJIEMBMKFED <localRoomInstance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <preFallbackInstance>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private bool <currentIsOffline>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<LAGIOCNLPCJ.ILDEHJEOCIB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C1FC00", Offset = "0x7C1E800", VA = "0x187C1FC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C20560", Offset = "0x7C1F160", VA = "0x187C20560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private string PKHPAPFANFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C340B0", Offset = "0x7C32CB0", VA = "0x187C340B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x9677A0", Offset = "0x9663A0", VA = "0x1809677A0")]
	public ONGNHADCGDP(CCOEFMMBAGF MGMNCIIJMMO, FELCLIHLJOK JOHAHHCBBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C340E0", Offset = "0x7C32CE0", VA = "0x187C340E0", Slot = "5")]
	[AsyncStateMachine(typeof(EBDBLFHBDAL))]
	public Task<LAGIOCNLPCJ.ILDEHJEOCIB> OJMKABAIEKO(HashSet<MPINOMEJPKK.Reason> ABDJIDIOHLI, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal class CIJNGJCHOLC : CHBBLLJPINJ, LAGIOCNLPCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct NANAAHCLLBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder<LAGIOCNLPCJ.ILDEHJEOCIB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public CIJNGJCHOLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public HashSet<MPINOMEJPKK.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter<GLCGEGGFDHI> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TaskAwaiter<LAGIOCNLPCJ.ILDEHJEOCIB> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C31710", Offset = "0x7C30310", VA = "0x187C31710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C32100", Offset = "0x7C30D00", VA = "0x187C32100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private string PKHPAPFANFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F440", Offset = "0x7C1E040", VA = "0x187C1F440", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x9677A0", Offset = "0x9663A0", VA = "0x1809677A0")]
	public CIJNGJCHOLC(CCOEFMMBAGF MGMNCIIJMMO, FELCLIHLJOK JOHAHHCBBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F470", Offset = "0x7C1E070", VA = "0x187C1F470", Slot = "5")]
	[AsyncStateMachine(typeof(NANAAHCLLBI))]
	public Task<LAGIOCNLPCJ.ILDEHJEOCIB> OJMKABAIEKO(HashSet<MPINOMEJPKK.Reason> ABDJIDIOHLI, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal class OEMCKMKLADN : CHBBLLJPINJ, LAGIOCNLPCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class HHLALLBNEJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public GLCGEGGFDHI matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public GJIEMBMKFED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public HHLALLBNEJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C290B0", Offset = "0x7C27CB0", VA = "0x187C290B0")]
		internal object PKKGJBLLILB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C28FF0", Offset = "0x7C27BF0", VA = "0x187C28FF0")]
		internal object GHIFABMAODO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct AMBEAAGENJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public AsyncTaskMethodBuilder<LAGIOCNLPCJ.ILDEHJEOCIB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public OEMCKMKLADN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public HashSet<MPINOMEJPKK.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private HHLALLBNEJN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter<GLCGEGGFDHI> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter<LAGIOCNLPCJ.ILDEHJEOCIB> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C18430", Offset = "0x7C17030", VA = "0x187C18430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C19050", Offset = "0x7C17C50", VA = "0x187C19050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private string PKHPAPFANFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C33EB0", Offset = "0x7C32AB0", VA = "0x187C33EB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x9677A0", Offset = "0x9663A0", VA = "0x1809677A0")]
	public OEMCKMKLADN(CCOEFMMBAGF MGMNCIIJMMO, FELCLIHLJOK JOHAHHCBBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7C33EE0", Offset = "0x7C32AE0", VA = "0x187C33EE0", Slot = "5")]
	[AsyncStateMachine(typeof(AMBEAAGENJP))]
	public Task<LAGIOCNLPCJ.ILDEHJEOCIB> OJMKABAIEKO(HashSet<MPINOMEJPKK.Reason> ABDJIDIOHLI, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal abstract class CHBBLLJPINJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct IPAGLODFOBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public NDNFAPMFFIF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public HashSet<MPINOMEJPKK.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public CHBBLLJPINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private List<MPINOMEJPKK.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B170", Offset = "0x7C29D70", VA = "0x187C2B170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B690", Offset = "0x7C2A290", VA = "0x187C2B690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	protected readonly CCOEFMMBAGF MGMNCIIJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	protected readonly FELCLIHLJOK JOHAHHCBBCJ;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	protected ONBJJNNFOFI EKBCFEONFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B990", Offset = "0x7C1A590", VA = "0x187C1B990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x9677A0", Offset = "0x9663A0", VA = "0x1809677A0")]
	public CHBBLLJPINJ(CCOEFMMBAGF MGMNCIIJMMO, FELCLIHLJOK JOHAHHCBBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B9E0", Offset = "0x7C1A5E0", VA = "0x187C1B9E0")]
	[AsyncStateMachine(typeof(IPAGLODFOBI))]
	protected Task MLBIMNNOAHK(NDNFAPMFFIF DFFCPCMIFOD, HashSet<MPINOMEJPKK.Reason> ABDJIDIOHLI, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class EPOPJEOAFEA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct DDKLPHMCBDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public AsyncTaskMethodBuilder<LAGIOCNLPCJ.ILDEHJEOCIB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public FELCLIHLJOK callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F6B0", Offset = "0x7C1E2B0", VA = "0x187C1F6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C1FA30", Offset = "0x7C1E630", VA = "0x187C1FA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class BEJIFKFBGEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CCOEFMMBAGF roomManager;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public BEJIFKFBGEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7C191A0", Offset = "0x7C17DA0", VA = "0x187C191A0")]
		internal object NPMJFNEPKMM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static readonly float OMDKGEJAOHP;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	internal static readonly HashSet<MPINOMEJPKK.Reason> OGFHHPMLABN;

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7C26CE0", Offset = "0x7C258E0", VA = "0x187C26CE0")]
	[AsyncStateMachine(typeof(DDKLPHMCBDD))]
	internal static Task<LAGIOCNLPCJ.ILDEHJEOCIB> DFIEIJPNCKG(FELCLIHLJOK JOHAHHCBBCJ, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7C26DF0", Offset = "0x7C259F0", VA = "0x187C26DF0")]
	internal static void LEOGGBKLLGP(CCOEFMMBAGF MGMNCIIJMMO, NDNFAPMFFIF DFFCPCMIFOD, string MBCJKDNCLIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal interface LAGIOCNLPCJ
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct ILDEHJEOCIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public bool CFLNFJDNJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public MPINOMEJPKK.Reason NCKCEGPNPKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Enum? CCHHOJGJHED;

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC50", Offset = "0x7C29850", VA = "0x187C2AC50")]
		public static ILDEHJEOCIB HJALOCABDFH()
		{
			return default(ILDEHJEOCIB);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC60", Offset = "0x7C29860", VA = "0x187C2AC60")]
		public static ILDEHJEOCIB JMDJOJNFEOH(MPINOMEJPKK.Reason NCKCEGPNPKI, [Optional] Enum? CCHHOJGJHED)
		{
			return default(ILDEHJEOCIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	string HGHHAHEJLAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ILDEHJEOCIB> OJMKABAIEKO(HashSet<MPINOMEJPKK.Reason> ABDJIDIOHLI, CancellationToken NAOIMKEDKEJ);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal struct HOEKMLFBLML
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class FLHIIOBGLNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public CCOEFMMBAGF manager;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public FLHIIOBGLNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C27A30", Offset = "0x7C26630", VA = "0x187C27A30")]
		internal Task BDIDPMPFMLA(CancellationToken cancellationToken, int roomTotalVersion, HNNAMAANNEG localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct FBAKNCGAHHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public HOEKMLFBLML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private JOHMHGNLPIP <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TaskAwaiter<MHCHKHKIDOP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter<DMOINJJJLLJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C27090", Offset = "0x7C25C90", VA = "0x187C27090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C27620", Offset = "0x7C26220", VA = "0x187C27620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct MAMOLKIFABI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public HOEKMLFBLML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C301E0", Offset = "0x7C2EDE0", VA = "0x187C301E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7C30500", Offset = "0x7C2F100", VA = "0x187C30500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly CancellationToken NAOIMKEDKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly CCOEFMMBAGF JHBOJJACLJB;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private CIFPFBINLMO KAOPEMANLJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AAB0", Offset = "0x7C296B0", VA = "0x187C2AAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private FELCLIHLJOK GNGHLGLBLNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC00", Offset = "0x7C29800", VA = "0x187C2AC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private ONBJJNNFOFI EKBCFEONFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A510", Offset = "0x7C29110", VA = "0x187C2A510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private IHBMKCGFJGL PPCACAGMJAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C2ABB0", Offset = "0x7C297B0", VA = "0x187C2ABB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2544C80", Offset = "0x2543880", VA = "0x182544C80")]
	public HOEKMLFBLML(CancellationToken NAOIMKEDKEJ, CCOEFMMBAGF JHBOJJACLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AB00", Offset = "0x7C29700", VA = "0x187C2AB00")]
	public static FJGJIIFMOMM IJDEMAPAHBH(CCOEFMMBAGF JHBOJJACLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A590", Offset = "0x7C29190", VA = "0x187C2A590")]
	[AsyncStateMachine(typeof(FBAKNCGAHHL))]
	public Task<bool> BDNCCGGPJGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A6A0", Offset = "0x7C292A0", VA = "0x187C2A6A0")]
	private bool BHHGPCDLEBC([Out] JOHMHGNLPIP ENLLCILGBAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A8B0", Offset = "0x7C294B0", VA = "0x187C2A8B0")]
	[AsyncStateMachine(typeof(MAMOLKIFABI))]
	private Task DCDCINPBDMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A980", Offset = "0x7C29580", VA = "0x187C2A980")]
	private Task<MHCHKHKIDOP> DLGKGJBLOAF(JOHMHGNLPIP GKMMCKDNCGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct POGPPOMAOEO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly KDECNGEPAAI PONCODGMFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly Guid HBKGJHPGIDP;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private Task<(DMOINJJJLLJ, Task)> PNCEKDGNHGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C35880", Offset = "0x7C34480", VA = "0x187C35880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4B0CA70", Offset = "0x4B0B670", VA = "0x184B0CA70")]
	public POGPPOMAOEO(KDECNGEPAAI PONCODGMFPK, Guid HBKGJHPGIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7C35A20", Offset = "0x7C34620", VA = "0x187C35A20")]
	public TaskAwaiter<(DMOINJJJLLJ, Task)> MADAPDACNGL()
	{
		return default(TaskAwaiter<(DMOINJJJLLJ, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7C35950", Offset = "0x7C34550", VA = "0x187C35950", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct FPNMIFNOGCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly TaskCompletionSource<(DMOINJJJLLJ, Task)> MBGCPHCGDFK;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Task<(DMOINJJJLLJ, Task)> PNCEKDGNHGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C27A80", Offset = "0x7C26680", VA = "0x187C27A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C27CD0", Offset = "0x7C268D0", VA = "0x187C27CD0")]
	public FPNMIFNOGCN(TimeSpan IOGIGKLDIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C27BE0", Offset = "0x7C267E0", VA = "0x187C27BE0")]
	public void MNILOKNOIFL(Task HLCGKBBHCJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7C27B50", Offset = "0x7C26750", VA = "0x187C27B50")]
	public void FKFFEFMJEAB(DMOINJJJLLJ IIHIICEIEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7C27C80", Offset = "0x7C26880", VA = "0x187C27C80")]
	public void MOBNJGCIGEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7C27AC0", Offset = "0x7C266C0", VA = "0x187C27AC0")]
	internal void FHOHBCHPBKC(string KBPDEFFIKOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class NBIEMFFPGFF
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class KBDMCGFFDCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public IPHHHIANCDI subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public KBDMCGFFDCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7C2C150", Offset = "0x7C2AD50", VA = "0x187C2C150")]
		internal bool PMDEDJMBJCP(FFBHBDHOGKB s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7C32260", Offset = "0x7C30E60", VA = "0x187C32260")]
	public static PDKHDMNJGNI EPPBBCFCJMI(long ICNOBLKLHAG, long HPCDEBDHAFJ, string MDHENNAADKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7C322F0", Offset = "0x7C30EF0", VA = "0x187C322F0")]
	public static PDKHDMNJGNI EPPBBCFCJMI(long ICNOBLKLHAG, long HPCDEBDHAFJ, HEJHHLFMEKL MAGHCEFJIPG, long BHNIPLLDJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7C323B0", Offset = "0x7C30FB0", VA = "0x187C323B0")]
	public static PDKHDMNJGNI EPPBBCFCJMI(BGHBHPAMLJF ENONGDPMLPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7C32540", Offset = "0x7C31140", VA = "0x187C32540")]
	public static PDKHDMNJGNI EPPBBCFCJMI(BCPENJPKFJJ IGGDJIHKPCC, IPHHHIANCDI HIICLNLFGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7C32170", Offset = "0x7C30D70", VA = "0x187C32170")]
	public static PDKHDMNJGNI AMIMOHGMDCG(this PDKHDMNJGNI BFDCDDMLJOF, BCPENJPKFJJ IIBHCLIIEEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7C32770", Offset = "0x7C31370", VA = "0x187C32770")]
	public static PDKHDMNJGNI IGOPHOMPPDP(this PDKHDMNJGNI BFDCDDMLJOF, IPHHHIANCDI JJMNAPOKMHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[RecRoom.NoEngine.Common.Preserve]
internal class LHHJLLMKAJK : FGGAIJEAMEP, ABCMKPCOBHD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct JPALDHMMJMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public LHHJLLMKAJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B6F0", Offset = "0x7C2A2F0", VA = "0x187C2B6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BD80", Offset = "0x7C2A980", VA = "0x187C2BD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly ABCMEDAMFNA HCABEKJDEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private string FEMIMMDMGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Task FNNMPBANFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private CCOEFMMBAGF MGMNCIIJMMO;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool KMMKJACJCBL
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7C2E8F0", Offset = "0x7C2D4F0", VA = "0x187C2E8F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Task NFLEINHEBJA
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2E5E0", Offset = "0x7C2D1E0", VA = "0x187C2E5E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x957540", Offset = "0x956140", VA = "0x180957540", Slot = "7")]
	public void AIMKJDEKJHN(CCOEFMMBAGF MGMNCIIJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E790", Offset = "0x7C2D390", VA = "0x187C2E790", Slot = "6")]
	public void MONNCEBBBOJ(Task LFJIOJDNNEN, string MFJBFAFDEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E670", Offset = "0x7C2D270", VA = "0x187C2E670")]
	[AsyncStateMachine(typeof(JPALDHMMJMG))]
	private Task FJFBHHCJLBJ(Task OBKCLFBIBFD, string MFJBFAFDEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E920", Offset = "0x7C2D520", VA = "0x187C2E920")]
	public LHHJLLMKAJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal class BKHCIFJFFCC : IIEJDJFCFPM, ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private bool EDIOBFHDEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private OAACMBCGIPK EMJNMIKFHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private CIFPFBINLMO CDOHCPAIEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private NEEOCIBJGGJ BKDMEACEJJF;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public OAACMBCGIPK IIFFMEJALBO
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A020", Offset = "0x7C18C20", VA = "0x187C1A020", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7C19CB0", Offset = "0x7C188B0", VA = "0x187C19CB0", Slot = "7")]
	public void AIMKJDEKJHN(CCOEFMMBAGF MGMNCIIJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7C19E30", Offset = "0x7C18A30", VA = "0x187C19E30", Slot = "5")]
	public void CCLOLKDCEJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7C19FE0", Offset = "0x7C18BE0", VA = "0x187C19FE0", Slot = "6")]
	public void KELAEPMKBPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A090", Offset = "0x7C18C90", VA = "0x187C1A090")]
	private Task FDGKDMFPPIL(ABGOFDAGANF LOJMCGAMMAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7C19FE0", Offset = "0x7C18BE0", VA = "0x187C19FE0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public BKHCIFJFFCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal class CGEGBAGBOMB : NEEOCIBJGGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class CBBNOJPGGLN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly DEECLODLFLE EPNBOPCMOMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private readonly string NKANGPLHEGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private readonly T NBKBMLNEBHK;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public T GNLOKINMAMH
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xB435D0", Offset = "0xB421D0", VA = "0x180B435D0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xB43A50", Offset = "0xB42650", VA = "0x180B43A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x59B6870", Offset = "0x59B5470", VA = "0x1859B6870")]
		public CBBNOJPGGLN(DEECLODLFLE EPNBOPCMOMD, string NKANGPLHEGE, T NBKBMLNEBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x59B6330", Offset = "0x59B4F30", VA = "0x1859B6330")]
		private void KLPHIOOLHGG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly DEECLODLFLE EPNBOPCMOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly CBBNOJPGGLN<TimeSpan> NKIKLGAHLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly CBBNOJPGGLN<TimeSpan> EDIEPDOCPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly CBBNOJPGGLN<TimeSpan> IJGFDCOFDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly CBBNOJPGGLN<TimeSpan> CDMLCIJJINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly CBBNOJPGGLN<bool> GIPDECPECJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly CBBNOJPGGLN<bool> APNBALBGEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly CBBNOJPGGLN<bool> OCAOLCBHIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly CBBNOJPGGLN<int> NLJANLHGMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly CBBNOJPGGLN<bool> FOLMHMNFPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly CBBNOJPGGLN<bool> MKCOODHCKFE;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public TimeSpan BOFKCLHPEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A450", Offset = "0x7C19050", VA = "0x187C1A450", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public TimeSpan FANBMILHKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A3D0", Offset = "0x7C18FD0", VA = "0x187C1A3D0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public TimeSpan BLFPFHOOJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A410", Offset = "0x7C19010", VA = "0x187C1A410", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public TimeSpan LCNNKHFMMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A4D0", Offset = "0x7C190D0", VA = "0x187C1A4D0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool GABHFHNHBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A590", Offset = "0x7C19190", VA = "0x187C1A590", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool LCMCBAMCJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A510", Offset = "0x7C19110", VA = "0x187C1A510", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool GOKJGKEMMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A5D0", Offset = "0x7C191D0", VA = "0x187C1A5D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public int CDMJKOMFNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A390", Offset = "0x7C18F90", VA = "0x187C1A390", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool HALCKEGMOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A490", Offset = "0x7C19090", VA = "0x187C1A490", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool KACFBFKCAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A550", Offset = "0x7C19150", VA = "0x187C1A550", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A610", Offset = "0x7C19210", VA = "0x187C1A610")]
	[UnityEngine.Scripting.Preserve]
	public CGEGBAGBOMB([GJMNBPKNJPO(null)] DEECLODLFLE EPNBOPCMOMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[UnityEngine.Scripting.Preserve]
internal class AIGEEBGHCBP : GPIHMDFOHPE, ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class AMKIPKOPDJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public LJCMGKIJECP roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public AMKIPKOPDJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7C190C0", Offset = "0x7C17CC0", VA = "0x187C190C0")]
		internal object AADGBJFMMIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	[CompilerGenerated]
	private Action<KMCPGADBLKC, bool> BBBLENDAGMK;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action LNGMNBHAMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7C182F0", Offset = "0x7C16EF0", VA = "0x187C182F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7C17E70", Offset = "0x7C16A70", VA = "0x187C17E70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event NCGDELCGGDE AKMHMDCNIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7C17D00", Offset = "0x7C16900", VA = "0x187C17D00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7C17C60", Offset = "0x7C16860", VA = "0x187C17C60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event NCGDELCGGDE IADKAOFIIPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7C18390", Offset = "0x7C16F90", VA = "0x187C18390", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7C181B0", Offset = "0x7C16DB0", VA = "0x187C181B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event NCGDELCGGDE NACOJLMEONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x7C18250", Offset = "0x7C16E50", VA = "0x187C18250", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x7C17DD0", Offset = "0x7C169D0", VA = "0x187C17DD0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "17")]
	public void AIMKJDEKJHN(CCOEFMMBAGF MGMNCIIJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7C17F40", Offset = "0x7C16B40", VA = "0x187C17F40", Slot = "12")]
	public void KDNLCFEPOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7C18130", Offset = "0x7C16D30", VA = "0x187C18130", Slot = "13")]
	public void LBIFLJEKILN(LJCMGKIJECP EAHKGKDJCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x7C17DA0", Offset = "0x7C169A0", VA = "0x187C17DA0", Slot = "14")]
	public void FDIEAODCIFO(LJCMGKIJECP EAHKGKDJCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7C17F10", Offset = "0x7C16B10", VA = "0x187C17F10", Slot = "15")]
	public void JOCOHLNIHKJ(LJCMGKIJECP EAHKGKDJCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7C18160", Offset = "0x7C16D60", VA = "0x187C18160", Slot = "16")]
	public void LNLNGBMCHFI(KMCPGADBLKC PAHFPJDPHAE, bool CFLNFJDNJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7C17AA0", Offset = "0x7C166A0", VA = "0x187C17AA0")]
	private void AOKANKCOAFH(NCGDELCGGDE LNAHAHEDANG, LJCMGKIJECP EAHKGKDJCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public AIGEEBGHCBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[UnityEngine.Scripting.Preserve]
internal class HLDOLFALPAM : MPINOMEJPKK, ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private class KFPKGAFAJBI : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct PMDDJELCDKF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public KFPKGAFAJBI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public MPINOMEJPKK.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private GINHMPCLHHC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private LAGIOCNLPCJ[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private TaskAwaiter<LAGIOCNLPCJ.ILDEHJEOCIB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x7C34630", Offset = "0x7C33230", VA = "0x187C34630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x7C34D60", Offset = "0x7C33960", VA = "0x187C34D60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct HFDDGNAGMKH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public AsyncTaskMethodBuilder<LAGIOCNLPCJ.ILDEHJEOCIB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public LAGIOCNLPCJ fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public KFPKGAFAJBI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public MPINOMEJPKK.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			private GINHMPCLHHC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private NOMMIFCDKMK <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private TaskAwaiter<LAGIOCNLPCJ.ILDEHJEOCIB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x7C282F0", Offset = "0x7C26EF0", VA = "0x187C282F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x7C28F80", Offset = "0x7C27B80", VA = "0x187C28F80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class CGDEEJKCAEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public LAGIOCNLPCJ fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public CGDEEJKCAEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x7C1A310", Offset = "0x7C18F10", VA = "0x187C1A310")]
			internal object KHLKCHAIKHC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public Task LFJIOJDNNEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public CancellationTokenSource LJCFPGNHBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public NOMMIFCDKMK KBDLGGGGDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public FELCLIHLJOK JOHAHHCBBCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public JCOCCFMLIAE MPNJBLCNBBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public GJIEMBMKFED LHACABBHAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public LAGIOCNLPCJ[] EHICCFHKPHF;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool MCDJDPMKNFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7C2C460", Offset = "0x7C2B060", VA = "0x187C2C460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool GHHNOKCCPBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D2B0", Offset = "0x7C2BEB0", VA = "0x187C2D2B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7C2DCD0", Offset = "0x7C2C8D0", VA = "0x187C2DCD0")]
		public KFPKGAFAJBI(FELCLIHLJOK JOHAHHCBBCJ, JCOCCFMLIAE MPNJBLCNBBK, GJIEMBMKFED LHACABBHAGD, LAGIOCNLPCJ[] EHICCFHKPHF, CancellationToken NAOIMKEDKEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7C2C650", Offset = "0x7C2B250", VA = "0x187C2C650", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7C2CE30", Offset = "0x7C2BA30", VA = "0x187C2CE30")]
		public void JDCDDGBODCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7C2CEA0", Offset = "0x7C2BAA0", VA = "0x187C2CEA0")]
		public void JEDBLMPACGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2C7E0", Offset = "0x7C2B3E0", VA = "0x187C2C7E0")]
		public void EFCBKEOJJGP(MPINOMEJPKK.Reason PAMNFMEJCEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7C2CD30", Offset = "0x7C2B930", VA = "0x187C2CD30")]
		[AsyncStateMachine(typeof(PMDDJELCDKF))]
		public Task FLPPJJFOPHK(MPINOMEJPKK.Reason NCKCEGPNPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7C2CA90", Offset = "0x7C2B690", VA = "0x187C2CA90")]
		[AsyncStateMachine(typeof(HFDDGNAGMKH))]
		private Task<LAGIOCNLPCJ.ILDEHJEOCIB> EGPCJOEAOIN(MPINOMEJPKK.Reason NCKCEGPNPKI, LAGIOCNLPCJ PBKHJNINDLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7C2C480", Offset = "0x7C2B080", VA = "0x187C2C480")]
		private void CGGJMLPGGMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2C5A0", Offset = "0x7C2B1A0", VA = "0x187C2C5A0")]
		public bool DKCDIDCKPJB(MPINOMEJPKK.Reason NGGGKHONFJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D000", Offset = "0x7C2BC00", VA = "0x187C2D000")]
		private void JFLIMNHFAFG(NOMMIFCDKMK CMPEMMPBPLC, MPINOMEJPKK.Reason NCKCEGPNPKI = MPINOMEJPKK.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7C2C290", Offset = "0x7C2AE90", VA = "0x187C2C290")]
		private void CAKJDKDKJFH(NOMMIFCDKMK CMPEMMPBPLC, LAGIOCNLPCJ.ILDEHJEOCIB HBANOBDOKBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D2D0", Offset = "0x7C2BED0", VA = "0x187C2D2D0")]
		private void LAPMMGJHJDM(NOMMIFCDKMK CMPEMMPBPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D580", Offset = "0x7C2C180", VA = "0x187C2D580")]
		private void PFOKALOEBNI(NOMMIFCDKMK CMPEMMPBPLC, LAGIOCNLPCJ.ILDEHJEOCIB HBANOBDOKBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7C2CBD0", Offset = "0x7C2B7D0", VA = "0x187C2CBD0")]
		private void ENJNAHDEJMM(NOMMIFCDKMK CMPEMMPBPLC, Exception COMMOGJDAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7C2C180", Offset = "0x7C2AD80", VA = "0x187C2C180")]
		private void AOHBBOMGAJL(LAGIOCNLPCJ PBKHJNINDLA, MPINOMEJPKK.Reason NCKCEGPNPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D470", Offset = "0x7C2C070", VA = "0x187C2D470")]
		private void LOKHMJHAFMC(LAGIOCNLPCJ PBKHJNINDLA, MPINOMEJPKK.Reason NCKCEGPNPKI, string CCHHOJGJHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D940", Offset = "0x7C2C540", VA = "0x187C2D940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class NOMMIFCDKMK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public Task<LAGIOCNLPCJ.ILDEHJEOCIB> LFJIOJDNNEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public CancellationTokenSource LJCFPGNHBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public LAGIOCNLPCJ PBKHJNINDLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public MPINOMEJPKK.Reason PAMNFMEJCEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public HashSet<MPINOMEJPKK.Reason> ABDJIDIOHLI;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool MCDJDPMKNFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x7C2C460", Offset = "0x7C2B060", VA = "0x187C2C460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool GHHNOKCCPBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D2B0", Offset = "0x7C2BEB0", VA = "0x187C2D2B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7C338D0", Offset = "0x7C324D0", VA = "0x187C338D0")]
		public void GHAJACFBFNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7C338B0", Offset = "0x7C324B0", VA = "0x187C338B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7C33A30", Offset = "0x7C32630", VA = "0x187C33A30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7C33DA0", Offset = "0x7C329A0", VA = "0x187C33DA0")]
		public NOMMIFCDKMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class PMANPKHANOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public MPINOMEJPKK.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public PMANPKHANOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7C345C0", Offset = "0x7C331C0", VA = "0x187C345C0")]
		internal object NKEIOCABEPB(NOMMIFCDKMK x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7C34550", Offset = "0x7C33150", VA = "0x187C34550")]
		internal object HEKIFEKBPII(KFPKGAFAJBI x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7C344E0", Offset = "0x7C330E0", VA = "0x187C344E0")]
		internal object AHJBOCAEMBO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct PMOFMEHOCBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public MPINOMEJPKK.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public HLDOLFALPAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private PMANPKHANOL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7C34DC0", Offset = "0x7C339C0", VA = "0x187C34DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7C35820", Offset = "0x7C34420", VA = "0x187C35820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct EDFLOBJIKJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public HLDOLFALPAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public MPINOMEJPKK.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private KFPKGAFAJBI <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7C205D0", Offset = "0x7C1F1D0", VA = "0x187C205D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7C21240", Offset = "0x7C1FE40", VA = "0x187C21240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct ABNMIBHGCIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public HLDOLFALPAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x7C17200", Offset = "0x7C15E00", VA = "0x187C17200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7C17770", Offset = "0x7C16370", VA = "0x187C17770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	internal static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	internal static readonly NDNFAPMFFIF AFKHFJMPBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private CCOEFMMBAGF MGMNCIIJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private FELCLIHLJOK JOHAHHCBBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private KFPKGAFAJBI JNJOIPFPIOH;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private ONBJJNNFOFI EKBCFEONFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7C296E0", Offset = "0x7C282E0", VA = "0x187C296E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool PJBIMMMMEKM
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x20B90A0", Offset = "0x20B7CA0", VA = "0x1820B90A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private bool OKOMIFJOACP
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A2D0", Offset = "0x7C28ED0", VA = "0x187C2A2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7C29660", Offset = "0x7C28260", VA = "0x187C29660", Slot = "7")]
	public void AIMKJDEKJHN(CCOEFMMBAGF MGMNCIIJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7C29C90", Offset = "0x7C28890", VA = "0x187C29C90", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7C29CA0", Offset = "0x7C288A0", VA = "0x187C29CA0", Slot = "9")]
	public void GHAJACFBFNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7C29E20", Offset = "0x7C28A20", VA = "0x187C29E20")]
	private bool LAMNLCPOJBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7C29800", Offset = "0x7C28400", VA = "0x187C29800", Slot = "6")]
	private void BNMMDNIHCEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7C29BA0", Offset = "0x7C287A0", VA = "0x187C29BA0", Slot = "5")]
	[AsyncStateMachine(typeof(PMOFMEHOCBE))]
	private Task DOBOLELEGKP(MPINOMEJPKK.Reason NCKCEGPNPKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7C298D0", Offset = "0x7C284D0", VA = "0x187C298D0")]
	private bool DHAOFHLLIAN(MPINOMEJPKK.Reason NCKCEGPNPKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7C29F00", Offset = "0x7C28B00", VA = "0x187C29F00")]
	private LAGIOCNLPCJ[] MPDBMMOAHBL(GJIEMBMKFED CDONJPGHAKB, JCOCCFMLIAE LAEEOBHGCJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A340", Offset = "0x7C28F40", VA = "0x187C2A340")]
	[AsyncStateMachine(typeof(EDFLOBJIKJK))]
	private Task OKKOPMJMOFG(MPINOMEJPKK.Reason NCKCEGPNPKI, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7C29730", Offset = "0x7C28330", VA = "0x187C29730")]
	[AsyncStateMachine(typeof(ABNMIBHGCIM))]
	private Task APBFIPPFPCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public HLDOLFALPAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[RecRoom.NoEngine.Common.Preserve]
internal class CHHFOOGKCND : OLHPKBEDEOA, ABCMKPCOBHD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct BICPENNNEPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public GJIEMBMKFED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public CHHFOOGKCND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public DDBLHNHDLGD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C192A0", Offset = "0x7C17EA0", VA = "0x187C192A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C19C00", Offset = "0x7C18800", VA = "0x187C19C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct MDKMFOKKPOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public CHHFOOGKCND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public GJIEMBMKFED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public DDBLHNHDLGD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private FNEANCIAOBI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private GINHMPCLHHC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private CBACDIIFINF <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private DKHGBKGEGOM <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C30A10", Offset = "0x7C2F610", VA = "0x187C30A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C316B0", Offset = "0x7C302B0", VA = "0x187C316B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class GKEDMNJBECI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public Matchmaking.JMHPPLNHBHC result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public DJHIMIFIFBN errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public GKEDMNJBECI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C28240", Offset = "0x7C26E40", VA = "0x187C28240")]
		internal object EAKDPPAHLMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class MPGDDBKOFLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Task<PDKHDMNJGNI> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public MPGDDBKOFLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		internal Task<PDKHDMNJGNI> OFHGCCGNGCP(FNEANCIAOBI<string>.IDKBCAKILKJ _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct EICHEBPIMKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public CHHFOOGKCND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public GJIEMBMKFED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public DDBLHNHDLGD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public CBACDIIFINF joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private MPGDDBKOFLE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private DMMAGACMAGB <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private GINHMPCLHHC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private FFAGHJPHLLH <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Task<Matchmaking.HAFHDNLIOHN> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private FAKGNFLJFGG <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private TaskAwaiter<Matchmaking.HAFHDNLIOHN> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private TaskAwaiter<PDKHDMNJGNI> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C212A0", Offset = "0x7C1FEA0", VA = "0x187C212A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C26C80", Offset = "0x7C25880", VA = "0x187C26C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct BAPOIHNOJEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public CHHFOOGKCND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C399A0", Offset = "0x7C385A0", VA = "0x187C399A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A400", Offset = "0x7C39000", VA = "0x187C3A400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct HOENJLJODLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public CHHFOOGKCND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private KPLLBHIBBNH <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C482F0", Offset = "0x7C46EF0", VA = "0x187C482F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7C48770", Offset = "0x7C47370", VA = "0x187C48770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct AIBEPBDKMFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public AsyncTaskMethodBuilder<Matchmaking.HAFHDNLIOHN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public GJIEMBMKFED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public CHHFOOGKCND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private TaskAwaiter<Matchmaking.HAFHDNLIOHN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7C374E0", Offset = "0x7C360E0", VA = "0x187C374E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7C379B0", Offset = "0x7C365B0", VA = "0x187C379B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct HIEJPKMHBLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public Matchmaking.HAFHDNLIOHN serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public CHHFOOGKCND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public CBACDIIFINF joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private TaskAwaiter<OLDEMAHBKGC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C474E0", Offset = "0x7C460E0", VA = "0x187C474E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C47B20", Offset = "0x7C46720", VA = "0x187C47B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class CNDNKDAILFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public GJIEMBMKFED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public CNDNKDAILFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B410", Offset = "0x7C3A010", VA = "0x187C3B410")]
		internal object MBPAEHLJHCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B310", Offset = "0x7C39F10", VA = "0x187C3B310")]
		internal string KNKGLOHONGK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct NNLLDKBKOGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public GJIEMBMKFED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public CHHFOOGKCND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private CNDNKDAILFN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C525F0", Offset = "0x7C511F0", VA = "0x187C525F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C53180", Offset = "0x7C51D80", VA = "0x187C53180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct NDCMEIBFHLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public CHHFOOGKCND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public CBACDIIFINF joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public PDKHDMNJGNI initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public GJIEMBMKFED targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public DMMAGACMAGB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C50C80", Offset = "0x7C4F880", VA = "0x187C50C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C51470", Offset = "0x7C50070", VA = "0x187C51470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct EGDDONKLLJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public CHHFOOGKCND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private GINHMPCLHHC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private GINHMPCLHHC <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C3EBE0", Offset = "0x7C3D7E0", VA = "0x187C3EBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C403C0", Offset = "0x7C3EFC0", VA = "0x187C403C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct JIHHEDBELJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public HNNAMAANNEG localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public CHHFOOGKCND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter<DMOINJJJLLJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D650", Offset = "0x7C4C250", VA = "0x187C4D650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DE40", Offset = "0x7C4CA40", VA = "0x187C4DE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class LAFHHCGIPGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public GJIEMBMKFED targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public LAFHHCGIPGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C4EC50", Offset = "0x7C4D850", VA = "0x187C4EC50")]
		internal object LBMKDMLOOAJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class CIMKNPHPMEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public CIMKNPHPMEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C3AD70", Offset = "0x7C39970", VA = "0x187C3AD70")]
		internal void DKOKAOLFOEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class JHDIPHFBJHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public GJIEMBMKFED targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public JHDIPHFBJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D510", Offset = "0x7C4C110", VA = "0x187C4D510")]
		internal object CCIEGLIHBEI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class FKCILHDJNAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public GJIEMBMKFED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public FKCILHDJNAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C41500", Offset = "0x7C40100", VA = "0x187C41500")]
		internal string LLGGPNMGICB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private static readonly NDNFAPMFFIF MEBLKCHNEOM;

	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private static readonly NDNFAPMFFIF MMEPPHANGAA;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private static readonly NDNFAPMFFIF LJMCDMPHCBI;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly string FOMIDPGLNPG;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly string ILGEOAEGHBF;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly string OFMNDDKBPCB;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public static readonly Guid BLMKKHNOBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private CGFOHGKICKB MEHMKCADMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private ECDMOFDHGEJ ACMMBDBLFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private CIFPFBINLMO CDOHCPAIEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private CCOEFMMBAGF MGMNCIIJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private FELCLIHLJOK JOHAHHCBBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private MPINOMEJPKK ABOHOLFMPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private FGGAIJEAMEP FHKHLMMIGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private GPIHMDFOHPE IFDKMFMNDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private NBDPEGDJHOL JACJFOPJCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private HIOHOGPJAAA LLKJEFLGJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private IDisposable NHJGMOHDNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private FCIPKPGJBNG KDFODFHJFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly ABCMEDAMFNA OCKDLBADAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private FAKGNFLJFGG IDJBFBPBPEF;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public TaskStatus HOPCDBOPLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x97FE30", Offset = "0x97EA30", VA = "0x18097FE30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x110CF80", Offset = "0x110BB80", VA = "0x18110CF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private ONBJJNNFOFI EKBCFEONFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C120", Offset = "0x7C1AD20", VA = "0x187C1C120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BDF0", Offset = "0x7C1A9F0", VA = "0x187C1BDF0", Slot = "6")]
	public void AIMKJDEKJHN(CCOEFMMBAGF MGMNCIIJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CD80", Offset = "0x7C1B980", VA = "0x187C1CD80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C4B0", Offset = "0x7C1B0B0", VA = "0x187C1C4B0", Slot = "5")]
	[AsyncStateMachine(typeof(BICPENNNEPE))]
	public Task CHOLCBOMNGK(GJIEMBMKFED EACCLNFIEFF, DDBLHNHDLGD FOCFEKCFLGP, CancellationToken MJJLMJBFHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E920", Offset = "0x7C1D520", VA = "0x187C1E920")]
	[AsyncStateMachine(typeof(MDKMFOKKPOB))]
	private Task LCLEKDBCIJL(GJIEMBMKFED EACCLNFIEFF, DDBLHNHDLGD FOCFEKCFLGP, CancellationToken MJJLMJBFHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E4C0", Offset = "0x7C1D0C0", VA = "0x187C1E4C0")]
	private void KJFEEJOANBK(NBDPEGDJHOL JACJFOPJCNE, GJIEMBMKFED EACCLNFIEFF, Exception COMMOGJDAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CDD0", Offset = "0x7C1B9D0", VA = "0x187C1CDD0")]
	private static void EGDJGAGOHKN(DKHGBKGEGOM LLILEGHKCNP, Exception COMMOGJDAGN, [Optional] List<int> GNMFFBCKOKI, int NHGNHHENPFP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C9D0", Offset = "0x7C1B5D0", VA = "0x187C1C9D0")]
	[AsyncStateMachine(typeof(EICHEBPIMKL))]
	private Task DBDPELGGHIF(FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, GJIEMBMKFED EACCLNFIEFF, DDBLHNHDLGD FOCFEKCFLGP, CBACDIIFINF ECKIAMPFHKP, CancellationToken MJJLMJBFHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D910", Offset = "0x7C1C510", VA = "0x187C1D910")]
	private void FGCKMLJONHH([CallerMemberName] string PACJLEODEKJ = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DA90", Offset = "0x7C1C690", VA = "0x187C1DA90")]
	[AsyncStateMachine(typeof(BAPOIHNOJEL))]
	private Task FIDOLMEHKEF(FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DBC0", Offset = "0x7C1C7C0", VA = "0x187C1DBC0")]
	private void FNOKADKNODI(GJIEMBMKFED EACCLNFIEFF, CancellationToken MJJLMJBFHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DFD0", Offset = "0x7C1CBD0", VA = "0x187C1DFD0")]
	private void HJLKNFGBKEJ(GJIEMBMKFED EACCLNFIEFF, TaskStatus FMBHGDMMNOG, string KBPDEFFIKOJ, CBACDIIFINF ECKIAMPFHKP, Exception LIELHOAJGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DEF0", Offset = "0x7C1CAF0", VA = "0x187C1DEF0")]
	private void GOCHMDICJLM(GJIEMBMKFED EACCLNFIEFF, CBACDIIFINF ECKIAMPFHKP, OperationCanceledException KOCDINDDCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C2E0", Offset = "0x7C1AEE0", VA = "0x187C1C2E0")]
	private void CBKNMOBOGKF(GJIEMBMKFED EACCLNFIEFF, CBACDIIFINF ECKIAMPFHKP, Exception COMMOGJDAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C730", Offset = "0x7C1B330", VA = "0x187C1C730")]
	private void CKGAOOKHKNJ(GJIEMBMKFED EACCLNFIEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C1EC10", Offset = "0x7C1D810", VA = "0x187C1EC10")]
	private static LJCMGKIJECP OGLHCBIMFHI(GJIEMBMKFED EACCLNFIEFF)
	{
		return default(LJCMGKIJECP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D710", Offset = "0x7C1C310", VA = "0x187C1D710")]
	[AsyncStateMachine(typeof(HOENJLJODLC))]
	private Task ENIAHNLCPJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CC20", Offset = "0x7C1B820", VA = "0x187C1CC20")]
	[AsyncStateMachine(typeof(AIBEPBDKMFC))]
	private Task<Matchmaking.HAFHDNLIOHN> DMJJGEMHNGB(GJIEMBMKFED EACCLNFIEFF, FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E230", Offset = "0x7C1CE30", VA = "0x187C1E230")]
	private static OLDEMAHBKGC JONPJIGLBFD(Matchmaking.HAFHDNLIOHN MDOJIBPEPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C360", Offset = "0x7C1AF60", VA = "0x187C1C360")]
	[AsyncStateMachine(typeof(HIEJPKMHBLD))]
	private Task CGJJCFKGDEO(Matchmaking.HAFHDNLIOHN MDOJIBPEPGE, CBACDIIFINF ECKIAMPFHKP, FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, CancellationToken PKGBAOCOHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F070", Offset = "0x7C1DC70", VA = "0x187C1F070")]
	[AsyncStateMachine(typeof(NNLLDKBKOGK))]
	private Task PLGOGFOIJJB(GJIEMBMKFED EACCLNFIEFF, CancellationTokenSource JGDCAMKNIIJ, Task ODNIGCDGGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C170", Offset = "0x7C1AD70", VA = "0x187C1C170")]
	[AsyncStateMachine(typeof(NDCMEIBFHLE))]
	private Task AOGMCGHBGID(PDKHDMNJGNI CAFEFALKHPP, DMMAGACMAGB LMLEMKCJJPO, GJIEMBMKFED AMBGFHJPKFB, CBACDIIFINF ADIHGKPMKLD, FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, CancellationToken OHHHILLJFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C1EE80", Offset = "0x7C1DA80", VA = "0x187C1EE80")]
	private CBACDIIFINF PHEKKPGIEIH(CBACDIIFINF ADIHGKPMKLD, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C5F0", Offset = "0x7C1B1F0", VA = "0x187C1C5F0")]
	[AsyncStateMachine(typeof(EGDDONKLLJG))]
	private Task CKACLOJFLDD(FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D7E0", Offset = "0x7C1C3E0", VA = "0x187C1D7E0")]
	[AsyncStateMachine(typeof(JIHHEDBELJP))]
	private Task FAECPINGHJP(CancellationToken NAOIMKEDKEJ, int EPFOEOAPCEG, HNNAMAANNEG ANOEIEDBMIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E340", Offset = "0x7C1CF40", VA = "0x187C1E340")]
	private static void KBPBGEKCFLO(GJIEMBMKFED EACCLNFIEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BBA0", Offset = "0x7C1A7A0", VA = "0x187C1BBA0")]
	private void AIAGCCGEFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C940", Offset = "0x7C1B540", VA = "0x187C1C940")]
	private void DACGNLIEHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BB10", Offset = "0x7C1A710", VA = "0x187C1BB10")]
	private void AFKLBGAGGMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7C1EB80", Offset = "0x7C1D780", VA = "0x187C1EB80")]
	private void OAEBCBFMCHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CB30", Offset = "0x7C1B730", VA = "0x187C1CB30")]
	private static void DMHFIEHOOPK(GJIEMBMKFED EACCLNFIEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C1EA70", Offset = "0x7C1D670", VA = "0x187C1EA70")]
	private static CancellationTokenRegistration MCPGIPHEMDL(GJIEMBMKFED EACCLNFIEFF, CancellationToken PKGBAOCOHJD)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D610", Offset = "0x7C1C210", VA = "0x187C1D610")]
	private static void EJPPCKAPPND(GJIEMBMKFED EACCLNFIEFF, Exception COMMOGJDAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7C1EC70", Offset = "0x7C1D870", VA = "0x187C1EC70")]
	private void OMAOFJAEIPP(GJIEMBMKFED EACCLNFIEFF, Task ODNIGCDGGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DF70", Offset = "0x7C1CB70", VA = "0x187C1DF70")]
	private static void HBFNBGCENOB(Func<string> EJCEKPPDLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F3B0", Offset = "0x7C1DFB0", VA = "0x187C1F3B0")]
	public CHHFOOGKCND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7C1EE20", Offset = "0x7C1DA20", VA = "0x187C1EE20")]
	[CompilerGenerated]
	internal static (int, int?) PBJBPGCENPN(DJHIMIFIFBN LNJMPIHLDED)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[RecRoom.NoEngine.Common.Preserve]
internal class IEBDAGKDBCM : BJGILIINBGI, ABCMKPCOBHD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct DANHLOFJNOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public IEBDAGKDBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public HNNAMAANNEG localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C270", Offset = "0x7C3AE70", VA = "0x187C3C270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C750", Offset = "0x7C3B350", VA = "0x187C3C750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class KCOIIBLCEGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public IEBDAGKDBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public HNNAMAANNEG localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public KCOIIBLCEGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E5E0", Offset = "0x7C4D1E0", VA = "0x187C4E5E0")]
		internal List<Task> EBGBLBNIFOF(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct ILHKCBLCOHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public FJGJIIFMOMM taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public HNNAMAANNEG localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7C4BF90", Offset = "0x7C4AB90", VA = "0x187C4BF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C330", Offset = "0x7C4AF30", VA = "0x187C4C330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct FDHJKPHNKDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public IEBDAGKDBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C40B60", Offset = "0x7C3F760", VA = "0x187C40B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C40E40", Offset = "0x7C3FA40", VA = "0x187C40E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private readonly HashSet<FJGJIIFMOMM> GANJNNOFEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private ECDMOFDHGEJ ACMMBDBLFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private CCOEFMMBAGF MGMNCIIJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private HGFIOFABNDK JBEGGGNJNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private OMEJDJKPJGL PHBGGLKCMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private IDisposable NHJGMOHDNFF;

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7C48D70", Offset = "0x7C47970", VA = "0x187C48D70", Slot = "5")]
	public void AIMKJDEKJHN(CCOEFMMBAGF MGMNCIIJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C490B0", Offset = "0x7C47CB0", VA = "0x187C490B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C49050", Offset = "0x7C47C50", VA = "0x187C49050", Slot = "4")]
	public bool ANNCKHMPBMO(FJGJIIFMOMM GDHNNPJICDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C49110", Offset = "0x7C47D10", VA = "0x187C49110")]
	private void EALNLOCIMHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C491E0", Offset = "0x7C47DE0", VA = "0x187C491E0")]
	private void EPFFAPOGBNF(DFAGOCGJMME FDFFMDBCAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C49B50", Offset = "0x7C48750", VA = "0x187C49B50")]
	[AsyncStateMachine(typeof(DANHLOFJNOO))]
	private Task LKFBGHIBACG(int EPFOEOAPCEG, HNNAMAANNEG ANOEIEDBMIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C495A0", Offset = "0x7C481A0", VA = "0x187C495A0")]
	private Func<CancellationToken, List<Task>> IMPKBJJLGFM(int EPFOEOAPCEG, HNNAMAANNEG ANOEIEDBMIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C49670", Offset = "0x7C48270", VA = "0x187C49670")]
	private List<Task> KJCIDKICHEO(int EPFOEOAPCEG, HNNAMAANNEG ANOEIEDBMIG, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C49480", Offset = "0x7C48080", VA = "0x187C49480")]
	[AsyncStateMachine(typeof(ILHKCBLCOHH))]
	private Task GPOFKPEAKCL(FJGJIIFMOMM FACDALAFIFJ, CancellationToken IKLHDHMJFFL, int EPFOEOAPCEG, HNNAMAANNEG ANOEIEDBMIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C49C40", Offset = "0x7C48840", VA = "0x187C49C40")]
	[AsyncStateMachine(typeof(FDHJKPHNKDE))]
	private Task OMJKMLPBAOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C49400", Offset = "0x7C48000", VA = "0x187C49400")]
	private void GHAJACFBFNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C49D10", Offset = "0x7C48910", VA = "0x187C49D10")]
	public IEBDAGKDBCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[UnityEngine.Scripting.Preserve]
internal sealed class GJGFPDHFKIE : KDECNGEPAAI, ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class IHCLNMABDMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public IHCLNMABDMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7C49F40", Offset = "0x7C48B40", VA = "0x187C49F40")]
		internal object JMFIINELJFD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class ENIIBBPHGML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public ENIIBBPHGML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x7C408D0", Offset = "0x7C3F4D0", VA = "0x187C408D0")]
		internal object PMNJANCBNJH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class JGEEDBKAGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public JGEEDBKAGEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class NHOFHLLDMCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public NHOFHLLDMCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x7C51580", Offset = "0x7C50180", VA = "0x187C51580")]
		internal object PFCMOHODDIM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class KILLLLKDIIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public KILLLLKDIIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E620", Offset = "0x7C4D220", VA = "0x187C4E620")]
		internal object OPCAMMBMPFJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private readonly Dictionary<Guid, FPNMIFNOGCN> PONCODGMFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private readonly TimeSpan PNIKKDMGNFH;

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "9")]
	public void AIMKJDEKJHN(CCOEFMMBAGF MGMNCIIJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7C43C80", Offset = "0x7C42880", VA = "0x187C43C80", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7C43C90", Offset = "0x7C42890", VA = "0x187C43C90", Slot = "4")]
	public POGPPOMAOEO GFCJDEIJPEO(Guid HBKGJHPGIDP)
	{
		return default(POGPPOMAOEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7C43890", Offset = "0x7C42490", VA = "0x187C43890", Slot = "5")]
	public bool BLAPNJAELFA(Guid HBKGJHPGIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7C43EB0", Offset = "0x7C42AB0", VA = "0x187C43EB0", Slot = "6")]
	public bool IIIAFNOJFBG(Guid HBKGJHPGIDP, Task HLCGKBBHCJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7C43AA0", Offset = "0x7C426A0", VA = "0x187C43AA0", Slot = "7")]
	public bool CCICOIKDLMF(Guid HBKGJHPGIDP, DMOINJJJLLJ IIHIICEIEJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C44410", Offset = "0x7C43010", VA = "0x187C44410", Slot = "8")]
	public Task<(DMOINJJJLLJ, Task)> OJEIPDEFBEP(Guid HBKGJHPGIDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C441E0", Offset = "0x7C42DE0", VA = "0x187C441E0")]
	private void KFHCNFFICEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C44480", Offset = "0x7C43080", VA = "0x187C44480")]
	public GJGFPDHFKIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[RecRoom.NoEngine.Common.Preserve]
internal class DENDFJKLMBB : FNMGEKHAILD, ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private class EPKPNFAJNAO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private readonly GJIEMBMKFED FHCHGLDFBAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private readonly CancellationTokenSource HGGNOAGNIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public readonly CancellationToken MOKNDENEOMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private bool DBHJMKHJPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private bool BPEPOBJKFCM;

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7C40AB0", Offset = "0x7C3F6B0", VA = "0x187C40AB0")]
		public EPKPNFAJNAO(GJIEMBMKFED FHCHGLDFBAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7C40960", Offset = "0x7C3F560", VA = "0x187C40960")]
		public void GHAJACFBFNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7C40930", Offset = "0x7C3F530", VA = "0x187C40930", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class CPDICMMCKAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public ABGOFDAGANF disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public CPDICMMCKAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B510", Offset = "0x7C3A110", VA = "0x187C3B510")]
		internal object KONOPKMCHMB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct OJPOJPEHOHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public ABGOFDAGANF disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public DENDFJKLMBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7C54000", Offset = "0x7C52C00", VA = "0x187C54000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7C54450", Offset = "0x7C53050", VA = "0x187C54450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class EBABBIBMAIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public DENDFJKLMBB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public EBABBIBMAIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x7C3EB10", Offset = "0x7C3D710", VA = "0x187C3EB10")]
		internal object LKDNPDHODHK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class INCCLICFHJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public GJIEMBMKFED newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public EBABBIBMAIA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public INCCLICFHJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C4E0", Offset = "0x7C4B0E0", VA = "0x187C4C4E0")]
		internal object EEAEHABKBPM((GJIEMBMKFED lastLocalPlayerRoomInstance, GJIEMBMKFED newRoomInstance, MPINOMEJPKK fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct IHMFBIMLKOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public DENDFJKLMBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private GINHMPCLHHC <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x7C49FA0", Offset = "0x7C48BA0", VA = "0x187C49FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class IGKLJNDOJAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public GJIEMBMKFED newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public IGKLJNDOJAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7C49DA0", Offset = "0x7C489A0", VA = "0x187C49DA0")]
		internal object CLIIPBCGNJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x7C49E80", Offset = "0x7C48A80", VA = "0x187C49E80")]
		internal void GDFIIALIEOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x7C49E40", Offset = "0x7C48A40", VA = "0x187C49E40")]
		internal object EJPKMMDOHBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x7C49F00", Offset = "0x7C48B00", VA = "0x187C49F00")]
		internal object MMMFFFNNAEL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private struct LNDMIDOEIOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public GJIEMBMKFED newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public DENDFJKLMBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public DDBLHNHDLGD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private IGKLJNDOJAK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F9E0", Offset = "0x7C4E5E0", VA = "0x187C4F9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7C509A0", Offset = "0x7C4F5A0", VA = "0x187C509A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private static readonly CGHGHJJHGCC.KDAKKCBFIHM OCJKAPHJLOD;

	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private static readonly PDJEPPMAHDP NEPFPIFLDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private ECDMOFDHGEJ ACMMBDBLFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private CCOEFMMBAGF MGMNCIIJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private MPINOMEJPKK ABOHOLFMPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private FELCLIHLJOK JOHAHHCBBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private NEEOCIBJGGJ BKDMEACEJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private OLHPKBEDEOA KMMOMAHEDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private GJIEMBMKFED IBOOBNHFKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private EPKPNFAJNAO CGHIJGKGDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private bool FGHCEMKMBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private Task EDGFLDBEPAO;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private ONBJJNNFOFI EKBCFEONFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CB40", Offset = "0x7C3B740", VA = "0x187C3CB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool NGMAECOAKHL
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xAFA9E0", Offset = "0xAF95E0", VA = "0x180AFA9E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7C3D5B0", Offset = "0x7C3C1B0", VA = "0x187C3D5B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C8A0", Offset = "0x7C3B4A0", VA = "0x187C3C8A0", Slot = "4")]
	public void AIMKJDEKJHN(CCOEFMMBAGF MGMNCIIJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D0B0", Offset = "0x7C3BCB0", VA = "0x187C3D0B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C7B0", Offset = "0x7C3B3B0", VA = "0x187C3C7B0")]
	[AsyncStateMachine(typeof(OJPOJPEHOHO))]
	private Task AHNLDMMMGGN(ABGOFDAGANF NMEJOAKPEJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CB90", Offset = "0x7C3B790", VA = "0x187C3CB90")]
	private void AJGKBLKBMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D420", Offset = "0x7C3C020", VA = "0x187C3D420")]
	private void MHGGJOCGIBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D5C0", Offset = "0x7C3C1C0", VA = "0x187C3D5C0")]
	private void NKLKEHIBIOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D790", Offset = "0x7C3C390", VA = "0x187C3D790")]
	private bool PMJDHGENCMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D220", Offset = "0x7C3BE20", VA = "0x187C3D220")]
	[AsyncStateMachine(typeof(IHMFBIMLKOH))]
	private void IECCOHAMAHH(int GMOJJMIJPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CD20", Offset = "0x7C3B920", VA = "0x187C3CD20")]
	private void AOLPMKJFKOK([Out] IDisposable OPJOELMEFGB, [Out] IDisposable CBPGOHPLEKE, [Out] IDisposable NFJHOOIDJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CFB0", Offset = "0x7C3BBB0", VA = "0x187C3CFB0")]
	private bool CLDHJFIOFFI(GJIEMBMKFED FHCHGLDFBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D740", Offset = "0x7C3C340", VA = "0x187C3D740")]
	private void OPHBEOHBKOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D2F0", Offset = "0x7C3BEF0", VA = "0x187C3D2F0")]
	[AsyncStateMachine(typeof(LNDMIDOEIOI))]
	private Task LCLEKDBCIJL(GJIEMBMKFED FHCHGLDFBAF, DDBLHNHDLGD FOCFEKCFLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DB90", Offset = "0x7C3C790", VA = "0x187C3DB90")]
	public DENDFJKLMBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[UnityEngine.Scripting.Preserve]
internal sealed class ALGCIKFJEPA : PDCJABGHHFC, ABCMKPCOBHD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct GNKMLIFGMLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public AsyncTaskMethodBuilder<DOGDFHEJDDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public ALGCIKFJEPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<DOGDFHEJDDI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x7C44B10", Offset = "0x7C43710", VA = "0x187C44B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x7C44DA0", Offset = "0x7C439A0", VA = "0x187C44DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class GMMGDGAIDEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public DKFJDNOJOIC message;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public GMMGDGAIDEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7C44AB0", Offset = "0x7C436B0", VA = "0x187C44AB0")]
		internal object MLONBMMAEHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class JIHEEHKAEEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public DKFJDNOJOIC messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public JIHEEHKAEEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D5F0", Offset = "0x7C4C1F0", VA = "0x187C4D5F0")]
		internal object CJBHDIAJIOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class GDLADIGJPPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public DKFJDNOJOIC request;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public GDLADIGJPPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x7C42C90", Offset = "0x7C41890", VA = "0x187C42C90")]
		internal object BOMGIMAOGKN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct JGKIDIFPKPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public DKFJDNOJOIC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public ALGCIKFJEPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private TaskAwaiter<AIKLBIMPFFC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7C4CBE0", Offset = "0x7C4B7E0", VA = "0x187C4CBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D4B0", Offset = "0x7C4C0B0", VA = "0x187C4D4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class AFGEMAFJBNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public DKFJDNOJOIC operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public AFGEMAFJBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x7C37480", Offset = "0x7C36080", VA = "0x187C37480")]
		internal object BCBHDFIJLOC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct AOPECMKGFOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public DKFJDNOJOIC operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public ALGCIKFJEPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private CBACDIIFINF <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter<DKFJDNOJOIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x7C38DD0", Offset = "0x7C379D0", VA = "0x187C38DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x7C39940", Offset = "0x7C38540", VA = "0x187C39940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct IDCDGCDMFJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public AsyncTaskMethodBuilder<AIKLBIMPFFC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public ALGCIKFJEPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public DKFJDNOJOIC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private IJIKBDOJGEA.DNAGMPJKFGP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private CBACDIIFINF <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private TaskAwaiter<DKFJDNOJOIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x7C487D0", Offset = "0x7C473D0", VA = "0x187C487D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x7C48D00", Offset = "0x7C47900", VA = "0x187C48D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class DIBPEIEOHOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public AIKLBIMPFFC operation;

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public DIBPEIEOHOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DC60", Offset = "0x7C3C860", VA = "0x187C3DC60")]
		internal object LFNAMDLGKMD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct DLGMBOOHLJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public AIKLBIMPFFC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public ALGCIKFJEPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private FNEANCIAOBI<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DCE0", Offset = "0x7C3C8E0", VA = "0x187C3DCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E310", Offset = "0x7C3CF10", VA = "0x187C3E310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class DGBFLHECEDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public DKFJDNOJOIC request;

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public DGBFLHECEDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DC00", Offset = "0x7C3C800", VA = "0x187C3DC00")]
		internal object HHBCAPEGFJL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class NBFBPCIANNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public DKFJDNOJOIC request;

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public NBFBPCIANNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x7C50C20", Offset = "0x7C4F820", VA = "0x187C50C20")]
		internal object HJBCHHOJMMN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private CCOEFMMBAGF MGMNCIIJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private FGGAIJEAMEP FHKHLMMIGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private LLLFKIDLHGI PBMHENEEDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private NHDAALLPKCI KJIOALHKEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private CIFPFBINLMO CDOHCPAIEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private TaskCompletionSource<DOGDFHEJDDI> BCMGNCJCOIO;

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7C37A20", Offset = "0x7C36620", VA = "0x187C37A20", Slot = "7")]
	public void AIMKJDEKJHN(CCOEFMMBAGF MGMNCIIJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7C38150", Offset = "0x7C36D50", VA = "0x187C38150", Slot = "6")]
	[AsyncStateMachine(typeof(GNKMLIFGMLO))]
	public Task<DOGDFHEJDDI> FCKJFBKBJKF(CancellationToken KEALLEAKBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7C386E0", Offset = "0x7C372E0", VA = "0x187C386E0", Slot = "4")]
	public void GEOLKGFAPKN(DKFJDNOJOIC KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7C38380", Offset = "0x7C36F80", VA = "0x187C38380", Slot = "5")]
	public void GACJNNJAFBL(DKFJDNOJOIC FAGHJMMOADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7C37B10", Offset = "0x7C36710", VA = "0x187C37B10")]
	[AsyncStateMachine(typeof(JGKIDIFPKPI))]
	private Task AJNOKIANDGJ(DKFJDNOJOIC AGFMCIMDGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7C37FB0", Offset = "0x7C36BB0", VA = "0x187C37FB0")]
	[AsyncStateMachine(typeof(AOPECMKGFOO))]
	private Task DAKEAHIMLMN(DKFJDNOJOIC DKKNLPGNFMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7C38C80", Offset = "0x7C37880", VA = "0x187C38C80")]
	[AsyncStateMachine(typeof(IDCDGCDMFJC))]
	private Task<AIKLBIMPFFC> PBPKPBAGPOF(DKFJDNOJOIC AGFMCIMDGME, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7C380C0", Offset = "0x7C36CC0", VA = "0x187C380C0")]
	private CBACDIIFINF DGIGHMFGCNK(DKFJDNOJOIC AGMOEDNNLFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7C38260", Offset = "0x7C36E60", VA = "0x187C38260")]
	[AsyncStateMachine(typeof(DLGMBOOHLJP))]
	private Task FGIPKNLOIOB(AIKLBIMPFFC GAJFLBPNGCK, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7C38A70", Offset = "0x7C37670", VA = "0x187C38A70")]
	private AIKLBIMPFFC HNKPGCCCECL(DKFJDNOJOIC AGFMCIMDGME, CBACDIIFINF KPKLENBGBEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3B80", Offset = "0x3AC2780", VA = "0x183AC3B80")]
	private T NLBPFLOFLCI<T>(T MPDLOLIOGJL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7C37C20", Offset = "0x7C36820", VA = "0x187C37C20")]
	private AIKLBIMPFFC CGHMPGBPBIP(DKFJDNOJOIC AGFMCIMDGME, CBACDIIFINF KPKLENBGBEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public ALGCIKFJEPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[UnityEngine.Scripting.Preserve]
internal sealed class HGHFEFLPOKD : LLLFKIDLHGI, ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class GHJHMDKEAIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public GHJHMDKEAIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7C43820", Offset = "0x7C42420", VA = "0x187C43820")]
		internal object OGCCDNAFJLL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class DAIPNPJIIDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public DAIPNPJIIDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C200", Offset = "0x7C3AE00", VA = "0x187C3C200")]
		internal object AADHFJEPGEH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private CIFPFBINLMO CDOHCPAIEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private EALAPKIKAFC AGMAIPCGBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private PDCJABGHHFC PHBFKKCLDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private KDECNGEPAAI PONCODGMFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private LKPDIPCHIEG DHCICOPFIBG;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7C45680", Offset = "0x7C44280", VA = "0x187C45680", Slot = "6")]
	public void AIMKJDEKJHN(CCOEFMMBAGF MGMNCIIJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7C465E0", Offset = "0x7C451E0", VA = "0x187C465E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7C45D60", Offset = "0x7C44960", VA = "0x187C45D60", Slot = "4")]
	public POGPPOMAOEO CMELBMPKPLF(DKFJDNOJOIC CPJONCGIFLG)
	{
		return default(POGPPOMAOEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7C468D0", Offset = "0x7C454D0", VA = "0x187C468D0", Slot = "5")]
	public void GDLNKACPCKK(Guid HBKGJHPGIDP, Task HLCGKBBHCJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x7C459F0", Offset = "0x7C445F0", VA = "0x187C459F0")]
	private void BNDPJODBOOI(byte DBIADELHCAC, int KEJOCEPAGCK, object OHHFGMEIFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x7C46CF0", Offset = "0x7C458F0", VA = "0x187C46CF0")]
	private void JDKOCPCJEIJ(ONNDOCGPBDI MCKCODFDFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7C47270", Offset = "0x7C45E70", VA = "0x187C47270")]
	private void JKCOLPPNPIL(ONNDOCGPBDI MCKCODFDFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x7C46690", Offset = "0x7C45290", VA = "0x187C46690")]
	private void FDLBBPENJJO(ONNDOCGPBDI MCKCODFDFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7C45AC0", Offset = "0x7C446C0", VA = "0x187C45AC0")]
	private DMOINJJJLLJ CBINFONHGFB(DKFJDNOJOIC AGMOEDNNLFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x7C457F0", Offset = "0x7C443F0", VA = "0x187C457F0")]
	private void BJBAIKKGIEA(DKFJDNOJOIC DKKNLPGNFMJ, DMOINJJJLLJ IIHIICEIEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7C46400", Offset = "0x7C45000", VA = "0x187C46400")]
	private bool DBABHBJNDDG(DKFJDNOJOIC DKKNLPGNFMJ, DMOINJJJLLJ IIHIICEIEJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7C46AE0", Offset = "0x7C456E0", VA = "0x187C46AE0")]
	private bool IJBPEFNOHGG(DKFJDNOJOIC CCPPLDCINHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7C46180", Offset = "0x7C44D80", VA = "0x187C46180")]
	private bool COOKPCFDOBH(byte DBIADELHCAC, ExitGames.Client.Photon.Hashtable MCKCODFDFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public HGHFEFLPOKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class CKJDDJGBPPG : KJOBOODKMKB, ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class MKGMGGJKFEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public DOGDFHEJDDI operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public CKJDDJGBPPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public DKFJDNOJOIC roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public MKGMGGJKFEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7C50BB0", Offset = "0x7C4F7B0", VA = "0x187C50BB0")]
		internal object FIICEIJBNBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7C50A00", Offset = "0x7C4F600", VA = "0x187C50A00")]
		internal object BMPPGFBGILD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct GBOBBFAFOPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AsyncTaskMethodBuilder<DMOINJJJLLJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public CKJDDJGBPPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public DKFJDNOJOIC roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private TaskAwaiter<DMOINJJJLLJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7C42580", Offset = "0x7C41180", VA = "0x187C42580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7C42C20", Offset = "0x7C41820", VA = "0x187C42C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class FPBIJJKDCBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public DOGDFHEJDDI operationType;

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public FPBIJJKDCBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7C42510", Offset = "0x7C41110", VA = "0x187C42510")]
		internal object FDGNHNHADKM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class ILMKHGHNOGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public DKFJDNOJOIC request;

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public ILMKHGHNOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C400", Offset = "0x7C4B000", VA = "0x187C4C400")]
		internal object KKOCEOCFLNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C390", Offset = "0x7C4AF90", VA = "0x187C4C390")]
		internal object JGNJFLEBPOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C470", Offset = "0x7C4B070", VA = "0x187C4C470")]
		internal object PKNEGKOGAKH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct FOCAIILLICK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public AsyncTaskMethodBuilder<DMOINJJJLLJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public DKFJDNOJOIC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public CKJDDJGBPPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private ILMKHGHNOGG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private POGPPOMAOEO <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private DMOINJJJLLJ <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private TaskAwaiter<(DMOINJJJLLJ validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7C41BD0", Offset = "0x7C407D0", VA = "0x187C41BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7C424A0", Offset = "0x7C410A0", VA = "0x187C424A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private CIFPFBINLMO CDOHCPAIEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private EALAPKIKAFC AGMAIPCGBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private LLLFKIDLHGI PBMHENEEDHE;

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7C3AE10", Offset = "0x7C39A10", VA = "0x187C3AE10", Slot = "5")]
	public void AIMKJDEKJHN(CCOEFMMBAGF MGMNCIIJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7C3B000", Offset = "0x7C39C00", VA = "0x187C3B000", Slot = "4")]
	[AsyncStateMachine(typeof(GBOBBFAFOPM))]
	private Task<DMOINJJJLLJ> HEJNANELLMG(DKFJDNOJOIC AGMOEDNNLFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7C3B120", Offset = "0x7C39D20", VA = "0x187C3B120")]
	private bool OHHCNACFDGA(DOGDFHEJDDI PAHFPJDPHAE, [Out] DMOINJJJLLJ HBANOBDOKBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7C3AEC0", Offset = "0x7C39AC0", VA = "0x187C3AEC0")]
	[AsyncStateMachine(typeof(FOCAIILLICK))]
	private Task<DMOINJJJLLJ> GMFHMJHMMNK(DKFJDNOJOIC AGFMCIMDGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public CKJDDJGBPPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class GNMBJPNBHFL : GPDONAADODL, ABCMKPCOBHD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct IPMAPAGAIAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public AsyncTaskMethodBuilder<PDKHDMNJGNI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public GJIEMBMKFED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public GNMBJPNBHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter<BCPENJPKFJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private TaskAwaiter<PDKHDMNJGNI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C5A0", Offset = "0x7C4B1A0", VA = "0x187C4C5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7C4CB70", Offset = "0x7C4B770", VA = "0x187C4CB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class NHLJGMOLJEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public NHLJGMOLJEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7C514D0", Offset = "0x7C500D0", VA = "0x187C514D0")]
		internal object PHKAPCPKBGF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct GDLIHPNCINF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public AsyncTaskMethodBuilder<BCPENJPKFJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public GNMBJPNBHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public GJIEMBMKFED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private NHLJGMOLJEL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private TaskAwaiter<BCPENJPKFJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7C42CF0", Offset = "0x7C418F0", VA = "0x187C42CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7C432E0", Offset = "0x7C41EE0", VA = "0x187C432E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct OOAPKAFMJCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public AsyncTaskMethodBuilder<PDKHDMNJGNI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public GNMBJPNBHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public GJIEMBMKFED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public BCPENJPKFJJ roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private TaskAwaiter<(HEJHHLFMEKL superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7C544B0", Offset = "0x7C530B0", VA = "0x187C544B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7C54910", Offset = "0x7C53510", VA = "0x187C54910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class EKLAKCMFJGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public EKLAKCMFJGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xCF12D0", Offset = "0xCEFED0", VA = "0x180CF12D0")]
		internal bool EDENHGKLOCI(FFBHBDHOGKB sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct CGMEOKLKGLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public AsyncTaskMethodBuilder<(HEJHHLFMEKL superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public BCPENJPKFJJ roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public GNMBJPNBHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public GJIEMBMKFED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private TaskAwaiter<(HEJHHLFMEKL superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A660", Offset = "0x7C39260", VA = "0x187C3A660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7C3AD00", Offset = "0x7C39900", VA = "0x187C3AD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class OIFONAJIMMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public OIFONAJIMMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C53F50", Offset = "0x7C52B50", VA = "0x187C53F50")]
		internal object FIMOMBOBBHJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct PNPPMOOHKFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public AsyncTaskMethodBuilder<(HEJHHLFMEKL superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public FFBHBDHOGKB subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public GNMBJPNBHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public GJIEMBMKFED dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private OIFONAJIMMN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private TaskAwaiter<NAKFAFENAFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C55040", Offset = "0x7C53C40", VA = "0x187C55040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C55770", Offset = "0x7C54370", VA = "0x187C55770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private static readonly (HEJHHLFMEKL superRoomData, long subRoomDataSaveId) AEFNDMABKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private FELCLIHLJOK JOHAHHCBBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private HJCFJFKLJMF IHNKLAIIBOJ;

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x7C44E10", Offset = "0x7C43A10", VA = "0x187C44E10", Slot = "5")]
	public void AIMKJDEKJHN(CCOEFMMBAGF MGMNCIIJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x7C452E0", Offset = "0x7C43EE0", VA = "0x187C452E0", Slot = "4")]
	[AsyncStateMachine(typeof(IPMAPAGAIAB))]
	public Task<PDKHDMNJGNI> PFGLCLNJFPE(FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, GJIEMBMKFED EACCLNFIEFF, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x7C45180", Offset = "0x7C43D80", VA = "0x187C45180")]
	[AsyncStateMachine(typeof(GDLIHPNCINF))]
	private Task<BCPENJPKFJJ> PEAAOKBKBKB(GJIEMBMKFED EACCLNFIEFF, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x7C45010", Offset = "0x7C43C10", VA = "0x187C45010")]
	[AsyncStateMachine(typeof(OOAPKAFMJCF))]
	private Task<PDKHDMNJGNI> FCGCHIHNDKC(GJIEMBMKFED EACCLNFIEFF, BCPENJPKFJJ DMHINAGAHMH, long DMLJPKIDBPD, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x7C44EA0", Offset = "0x7C43AA0", VA = "0x187C44EA0")]
	[AsyncStateMachine(typeof(CGMEOKLKGLP))]
	private Task<(HEJHHLFMEKL, long)> BDPIGOEKMLL(GJIEMBMKFED EACCLNFIEFF, BCPENJPKFJJ DMHINAGAHMH, long DMLJPKIDBPD, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x7C45440", Offset = "0x7C44040", VA = "0x187C45440")]
	[AsyncStateMachine(typeof(PNPPMOOHKFM))]
	private Task<(HEJHHLFMEKL, long)> PJOKJMAFPEH(GJIEMBMKFED AOMHHGMIMLI, FFBHBDHOGKB EEOCKJNOBGC, long DMLJPKIDBPD, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public GNMBJPNBHFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[UnityEngine.Scripting.Preserve]
internal sealed class JLAJGHLADDC : NHDAALLPKCI, ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class JIAMKNHIIEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public DKFJDNOJOIC request;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public JIAMKNHIIEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D590", Offset = "0x7C4C190", VA = "0x187C4D590")]
		internal object BJKJNJINAOB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct PFBKGFGMIFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AsyncTaskMethodBuilder<DKFJDNOJOIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public DKFJDNOJOIC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public JLAJGHLADDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public CBACDIIFINF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private TaskAwaiter<DKFJDNOJOIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C54980", Offset = "0x7C53580", VA = "0x187C54980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F90", Offset = "0x7C53B90", VA = "0x187C54F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private struct FHAKACDLHLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public AsyncTaskMethodBuilder<DKFJDNOJOIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public JLAJGHLADDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public CBACDIIFINF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private TaskAwaiter<IOKEFKHOBFF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C40EA0", Offset = "0x7C3FAA0", VA = "0x187C40EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C41490", Offset = "0x7C40090", VA = "0x187C41490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class EELGAFGLCIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public DKFJDNOJOIC request;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public EELGAFGLCIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C3EB80", Offset = "0x7C3D780", VA = "0x187C3EB80")]
		internal object GIFLPMPKHLO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct DAGKFKDAPOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public AsyncTaskMethodBuilder<DKFJDNOJOIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public DKFJDNOJOIC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public JLAJGHLADDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public CBACDIIFINF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private KMEJPIJJHOD <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private HOOEPKEMHLC <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private TaskAwaiter<IOKEFKHOBFF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B5A0", Offset = "0x7C3A1A0", VA = "0x187C3B5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C190", Offset = "0x7C3AD90", VA = "0x187C3C190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private CIFPFBINLMO CDOHCPAIEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private IIEJDJFCFPM ELGIICOALKH;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private OAACMBCGIPK IIFFMEJALBO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DFE0", Offset = "0x7C4CBE0", VA = "0x187C4DFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DEA0", Offset = "0x7C4CAA0", VA = "0x187C4DEA0", Slot = "8")]
	public void AIMKJDEKJHN(CCOEFMMBAGF MGMNCIIJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E480", Offset = "0x7C4D080", VA = "0x187C4E480", Slot = "4")]
	[AsyncStateMachine(typeof(PFBKGFGMIFC))]
	public Task<DKFJDNOJOIC> PGHFHLOADDI(DKFJDNOJOIC AGFMCIMDGME, CBACDIIFINF KPKLENBGBEA, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E330", Offset = "0x7C4CF30", VA = "0x187C4E330", Slot = "5")]
	[AsyncStateMachine(typeof(FHAKACDLHLD))]
	public Task<DKFJDNOJOIC> NMKJMPELNOL(CancellationToken NAOIMKEDKEJ, CBACDIIFINF KPKLENBGBEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DF30", Offset = "0x7C4CB30", VA = "0x187C4DF30", Slot = "6")]
	public GDLHPPGEFNI ECEKBFKNOKP(AIKLBIMPFFC BDEENMDMDJI, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E200", Offset = "0x7C4CE00", VA = "0x187C4E200", Slot = "7")]
	public GDLHPPGEFNI JDCKKAEJELF(AIKLBIMPFFC BDEENMDMDJI, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E0A0", Offset = "0x7C4CCA0", VA = "0x187C4E0A0")]
	[AsyncStateMachine(typeof(DAGKFKDAPOE))]
	private Task<DKFJDNOJOIC> FPKDAJDBMAH(DKFJDNOJOIC AGFMCIMDGME, CBACDIIFINF KPKLENBGBEA, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x336FFF0", Offset = "0x336EBF0", VA = "0x18336FFF0")]
	private static byte[] PFHKGAANKCI(DKFJDNOJOIC KBPDEFFIKOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public JLAJGHLADDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[UnityEngine.Scripting.Preserve]
internal sealed class KOGLPFJKKDO : EALAPKIKAFC, ABCMKPCOBHD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private DBKFCHLKGLK GENCLJMEBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	private CIFPFBINLMO CDOHCPAIEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	private FGGAIJEAMEP FHKHLMMIGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private CBOGOEJPCKE GFHJHLLJNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private FELCLIHLJOK JOHAHHCBBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private OLHPKBEDEOA KMMOMAHEDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private BJGILIINBGI GMJBBBDFEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private NEEOCIBJGGJ BKDMEACEJJF;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private ONBJJNNFOFI EKBCFEONFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E7F0", Offset = "0x7C4D3F0", VA = "0x187C4E7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private static DMOINJJJLLJ HJALOCABDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E840", Offset = "0x7C4D440", VA = "0x187C4E840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E680", Offset = "0x7C4D280", VA = "0x187C4E680", Slot = "6")]
	public void AIMKJDEKJHN(CCOEFMMBAGF MGMNCIIJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E850", Offset = "0x7C4D450", VA = "0x187C4E850", Slot = "4")]
	public DMOINJJJLLJ LEMINGEICKE(GDNMNFALBCN IBIKFHPOJNI, DOGDFHEJDDI KOJKHHJNKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E9C0", Offset = "0x7C4D5C0", VA = "0x187C4E9C0", Slot = "5")]
	public DMOINJJJLLJ LHLMKDDMAOE(GDNMNFALBCN JGPFOMMMDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x7C4EC40", Offset = "0x7C4D840", VA = "0x187C4EC40")]
	private static DMOINJJJLLJ PBDELNCFEMD(DDLOFGAAMNB NCKCEGPNPKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public KOGLPFJKKDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class PGDHJJGCAFK : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7C55000", Offset = "0x7C53C00", VA = "0x187C55000")]
	public PGDHJJGCAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F75AE0", Offset = "0x6F746E0", VA = "0x186F75AE0")]
	public PGDHJJGCAFK(string KBPDEFFIKOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[UnityEngine.Scripting.Preserve]
internal sealed class NIPJHHEADNP : IHBMKCGFJGL, ABCMKPCOBHD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct LMOGMOKAMON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public AsyncTaskMethodBuilder<DMOINJJJLLJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public NIPJHHEADNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public JOHMHGNLPIP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private FNEANCIAOBI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private MEDEJIGBEIA <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private TaskAwaiter<DMOINJJJLLJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C4EE20", Offset = "0x7C4DA20", VA = "0x187C4EE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F970", Offset = "0x7C4E570", VA = "0x187C4F970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct OANKHKJOENN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public NIPJHHEADNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C531E0", Offset = "0x7C51DE0", VA = "0x187C531E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C53920", Offset = "0x7C52520", VA = "0x187C53920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct GLDOKBHMNLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public NIPJHHEADNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C44540", Offset = "0x7C43140", VA = "0x187C44540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C44A50", Offset = "0x7C43650", VA = "0x187C44A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct DMAPODDJNJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public NIPJHHEADNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E370", Offset = "0x7C3CF70", VA = "0x187C3E370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C3EAB0", Offset = "0x7C3D6B0", VA = "0x187C3EAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct BCBBBKFLJIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public NIPJHHEADNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A460", Offset = "0x7C39060", VA = "0x187C3A460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A600", Offset = "0x7C39200", VA = "0x187C3A600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct HMJFCLGHADG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public NIPJHHEADNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C47B80", Offset = "0x7C46780", VA = "0x187C47B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7C48290", Offset = "0x7C46E90", VA = "0x187C48290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct GGCLOMGFDKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public NIPJHHEADNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7C43350", Offset = "0x7C41F50", VA = "0x187C43350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7C437C0", Offset = "0x7C423C0", VA = "0x187C437C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct FMOFGKJJOKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public NIPJHHEADNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public GBJMJAJMANP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private FNEANCIAOBI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7C41600", Offset = "0x7C40200", VA = "0x187C41600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7C41B70", Offset = "0x7C40770", VA = "0x187C41B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private CIFPFBINLMO CDOHCPAIEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private CCOEFMMBAGF MGMNCIIJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private FELCLIHLJOK JOHAHHCBBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private NHDAALLPKCI KJIOALHKEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private FGGAIJEAMEP FHKHLMMIGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private BJGILIINBGI GMJBBBDFEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private CancellationTokenSource JEJHDMKFPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private Task HODGCMKAFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private TaskCompletionSource<int> LFKOKLDGGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private int OGOIHDFAJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private int IJGHNNHKNLA;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7C51850", Offset = "0x7C50450", VA = "0x187C51850", Slot = "6")]
	public void AIMKJDEKJHN(CCOEFMMBAGF MGMNCIIJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x10BBEE0", Offset = "0x10BAAE0", VA = "0x1810BBEE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C52400", Offset = "0x7C51000", VA = "0x187C52400")]
	private void NONGNLPBCKC(float JCGHCAHIEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7C51F50", Offset = "0x7C50B50", VA = "0x187C51F50", Slot = "4")]
	[AsyncStateMachine(typeof(LMOGMOKAMON))]
	public Task<DMOINJJJLLJ> FBHOKADAIID(JOHMHGNLPIP ENLLCILGBAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7C51A00", Offset = "0x7C50600", VA = "0x187C51A00", Slot = "5")]
	[AsyncStateMachine(typeof(OANKHKJOENN))]
	public Task AKMDIOCAGBM([Optional] CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x10BBEE0", Offset = "0x10BAAE0", VA = "0x1810BBEE0")]
	public void HLJDNNOEMDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x7C515E0", Offset = "0x7C501E0", VA = "0x187C515E0")]
	private MEDEJIGBEIA ACKMDBMEIPL(JOHMHGNLPIP ENLLCILGBAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C52310", Offset = "0x7C50F10", VA = "0x187C52310")]
	[AsyncStateMachine(typeof(GLDOKBHMNLB))]
	private Task NBBAGGAGBAA(CancellationToken MJJLMJBFHKM, int EPFOEOAPCEG, HNNAMAANNEG ANOEIEDBMIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C52080", Offset = "0x7C50C80", VA = "0x187C52080")]
	[AsyncStateMachine(typeof(DMAPODDJNJL))]
	private Task KCOLNDDCPPL(CancellationToken MJJLMJBFHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x7C51AF0", Offset = "0x7C506F0", VA = "0x187C51AF0")]
	[AsyncStateMachine(typeof(BCBBBKFLJIO))]
	private Task CFPNDEPECFL([Optional] CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7C51E60", Offset = "0x7C50A60", VA = "0x187C51E60")]
	[AsyncStateMachine(typeof(HMJFCLGHADG))]
	private Task EGODKCBIDJJ(CancellationToken MJJLMJBFHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x7C51750", Offset = "0x7C50350", VA = "0x187C51750")]
	[AsyncStateMachine(typeof(GGCLOMGFDKK))]
	private Task ADDIGLFDGOO(CancellationToken JKNFHIAEIEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x7C52180", Offset = "0x7C50D80", VA = "0x187C52180")]
	private Task KLFJMDHLKGL(GBJMJAJMANP GEJNDLMJHME, CancellationToken MJJLMJBFHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x7C524E0", Offset = "0x7C510E0", VA = "0x187C524E0")]
	[AsyncStateMachine(typeof(FMOFGKJJOKH))]
	private Task PKDOMOPAEND(GBJMJAJMANP GEJNDLMJHME, CancellationToken MJJLMJBFHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7C51BE0", Offset = "0x7C507E0", VA = "0x187C51BE0")]
	private bool CGGNGAAGOPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public NIPJHHEADNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[UnityEngine.Scripting.Preserve]
internal class EGDOGBKLEBD : CBOGOEJPCKE, ABCMKPCOBHD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct OEKICDNGLHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public EGDOGBKLEBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private FNEANCIAOBI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7C53980", Offset = "0x7C52580", VA = "0x187C53980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C53EF0", Offset = "0x7C52AF0", VA = "0x187C53EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private EJKKNOAOEIP HJEGEEMLDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private CCOEFMMBAGF MGMNCIIJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private EALAPKIKAFC AGMAIPCGBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private NHDAALLPKCI KJIOALHKEEA;

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C40420", Offset = "0x7C3F020", VA = "0x187C40420", Slot = "6")]
	public void AIMKJDEKJHN(CCOEFMMBAGF MGMNCIIJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C40690", Offset = "0x7C3F290", VA = "0x187C40690", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C407D0", Offset = "0x7C3F3D0", VA = "0x187C407D0", Slot = "5")]
	[AsyncStateMachine(typeof(OEKICDNGLHJ))]
	public Task OOFIKMNJGDK(string ICLCPILCBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C40630", Offset = "0x7C3F230", VA = "0x187C40630", Slot = "4")]
	public DMOINJJJLLJ CGGNGAAGOPG(GDNMNFALBCN IBIKFHPOJNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C406E0", Offset = "0x7C3F2E0", VA = "0x187C406E0")]
	private EKPDHFBKNAI IOIKNLMGAEN(string ICLCPILCBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public EGDOGBKLEBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class IIFNJBNEEHF
{
	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B6E0", Offset = "0x7C4A2E0", VA = "0x187C4B6E0")]
	public static void FLPIHFCBKHC(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B920", Offset = "0x7C4A520", VA = "0x187C4B920")]
	internal static void HLFCJDFFEJP(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7C4BA80", Offset = "0x7C4A680", VA = "0x187C4BA80")]
	internal static void NDLPNNPCCFG(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x7C4BB60", Offset = "0x7C4A760", VA = "0x187C4BB60")]
	internal static void POAOJLLKFPF(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x33B5120", Offset = "0x33B3D20", VA = "0x1833B5120")]
	private static void HMIHBLPLBFK<Interface, Impl, Interface>(KPLLBHIBBNH AGGFAPJEEEN) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal class BLGLEPDDBNL : ECOIBJOAHOJ<DKFJDNOJOIC>
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private sealed class LKDFFCDFDCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public DKFJDNOJOIC message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public LKDFFCDFDCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C6B3C0", Offset = "0x7C69FC0", VA = "0x187C6B3C0")]
		internal object EPBMCJGBKDM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly BLGLEPDDBNL FFLNCJPMHOJ;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A820", Offset = "0x7C59420", VA = "0x187C5A820")]
	public ExitGames.Client.Photon.Hashtable DHDDBDHCOJI(DKFJDNOJOIC KBPDEFFIKOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A6F0", Offset = "0x7C592F0", VA = "0x187C5A6F0", Slot = "5")]
	protected override void AICFICFANMF(DKFJDNOJOIC KBPDEFFIKOJ, IDictionary<object, object> LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x7C5AC70", Offset = "0x7C59870", VA = "0x187C5AC70", Slot = "6")]
	public override DKFJDNOJOIC KOHMJABOPGF(IDictionary<object, object> LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7C5AB60", Offset = "0x7C59760", VA = "0x187C5AB60")]
	private static void HBFNBGCENOB(string IGAJDACOHDK, DKFJDNOJOIC KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x7C5AF30", Offset = "0x7C59B30", VA = "0x187C5AF30")]
	public BLGLEPDDBNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A8B0", Offset = "0x7C594B0", VA = "0x187C5A8B0")]
	[CompilerGenerated]
	internal static string DLBOJCOPAHA(PDKHDMNJGNI BFDCDDMLJOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class ANAMBHIKKFB
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public static DMOINJJJLLJ HJALOCABDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x7C56F90", Offset = "0x7C55B90", VA = "0x187C56F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C57430", Offset = "0x7C56030", VA = "0x187C57430")]
	public static bool OCMNPAIHGGN(this DMOINJJJLLJ IIHIICEIEJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C57450", Offset = "0x7C56050", VA = "0x187C57450")]
	public static DMOINJJJLLJ PBDELNCFEMD(DDLOFGAAMNB GMPMFCHLNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x7C57240", Offset = "0x7C55E40", VA = "0x187C57240")]
	public static DMOINJJJLLJ IJCHEMODCCE(IEnumerable<DMOINJJJLLJ> CBFKHMOPMIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x7C56FF0", Offset = "0x7C55BF0", VA = "0x187C56FF0")]
	public static string GDCEKGHCMJM(this DMOINJJJLLJ HBANOBDOKBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public abstract class BHEOGNFHJLM : CPACBEBFPFG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public delegate DMOINJJJLLJ LMDFJICBCCE([NotNull] GDNMNFALBCN DOFDBBKJPAL);

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class FKKHHPAKAHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public GDNMNFALBCN photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public FKKHHPAKAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x1359CA0", Offset = "0x13588A0", VA = "0x181359CA0")]
		internal DMOINJJJLLJ JGOHFNMBMDJ(LMDFJICBCCE v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private bool EIHBPFOIIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	protected readonly HashSet<LMDFJICBCCE> JJAIJEAAMMN;

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x7C586A0", Offset = "0x7C572A0", VA = "0x187C586A0", Slot = "4")]
	public void GKBPFCHBCLH(LMDFJICBCCE GIPAELEOGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x7C58700", Offset = "0x7C57300", VA = "0x187C58700", Slot = "5")]
	public void JFOJHBIOELB(LMDFJICBCCE GIPAELEOGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x7C58650", Offset = "0x7C57250", VA = "0x187C58650", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7C58760", Offset = "0x7C57360", VA = "0x187C58760")]
	protected DMOINJJJLLJ KNOBFMJGMOI(GDNMNFALBCN JGPFOMMMDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x7C589F0", Offset = "0x7C575F0", VA = "0x187C589F0")]
	protected BHEOGNFHJLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public class OPCMBJJGNFC : BHEOGNFHJLM, DBKFCHLKGLK, CPACBEBFPFG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private sealed class NFDOLALPKOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public DMOINJJJLLJ result;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public NFDOLALPKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7C6D550", Offset = "0x7C6C150", VA = "0x187C6D550")]
		internal object MIJIOKAONFG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7C67270", Offset = "0x7C65E70", VA = "0x187C67270")]
	[UnityEngine.Scripting.Preserve]
	public OPCMBJJGNFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F910", Offset = "0x7C6E510", VA = "0x187C6F910", Slot = "8")]
	public DMOINJJJLLJ KFMHALGOHGK(GDNMNFALBCN JGPFOMMMDPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public class ILIJHCFOIKE : BHEOGNFHJLM, EJKKNOAOEIP, CPACBEBFPFG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class HBJLHLECHDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public DMOINJJJLLJ result;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public HBJLHLECHDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x7C654D0", Offset = "0x7C640D0", VA = "0x187C654D0")]
		internal object BAHMNCKGGAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x7C67270", Offset = "0x7C65E70", VA = "0x187C67270")]
	[UnityEngine.Scripting.Preserve]
	public ILIJHCFOIKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7C67160", Offset = "0x7C65D60", VA = "0x187C67160", Slot = "8")]
	public DMOINJJJLLJ CGGNGAAGOPG(GDNMNFALBCN JCNJPDCHNEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal static class FDDIOGLEPMO
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class BLMLBMPNEGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public FNEANCIAOBI<string> timer;

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public BLMLBMPNEGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AF70", Offset = "0x7C59B70", VA = "0x187C5AF70")]
		internal object ACENKHGLEGB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x7C62EC0", Offset = "0x7C61AC0", VA = "0x187C62EC0")]
	public static FNEANCIAOBI<string> LNKAOCNPIGL(NDNFAPMFFIF DFFCPCMIFOD, [Optional] string CKHAMLHEFEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x7C62E00", Offset = "0x7C61A00", VA = "0x187C62E00")]
	public static void LGACODNECKM(FNEANCIAOBI<string> IFHLDBMAMPN, NDNFAPMFFIF DFFCPCMIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x7C62D40", Offset = "0x7C61940", VA = "0x187C62D40")]
	public static string JJEJAFPOEDF(DKFJDNOJOIC AGMOEDNNLFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal static class ENHPGIGPPPD
{
	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x7C61300", Offset = "0x7C5FF00", VA = "0x187C61300")]
	public static void OLIHKGHIABG(this CIFPFBINLMO CDOHCPAIEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x7C612F0", Offset = "0x7C5FEF0", VA = "0x187C612F0")]
	public static void OKNNNLEAKDE(this CIFPFBINLMO CDOHCPAIEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x7C611D0", Offset = "0x7C5FDD0", VA = "0x187C611D0")]
	private static void IAGGPODBJEG(this CIFPFBINLMO CDOHCPAIEHP, bool BCNFJLIIENN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class BGODMMLHFNN : AEIBJBCHIBE, FNLDFBFCOLB, GKKFDFILMMC, OMKDFABMFAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private readonly FNLDFBFCOLB ACLFABLMHLA;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public GDNMNFALBCN DCCCIJHEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x7C58290", Offset = "0x7C56E90", VA = "0x187C58290", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public int JLIKKPBLFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x7C583C0", Offset = "0x7C56FC0", VA = "0x187C583C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public int KMPLAGIKFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x7C58240", Offset = "0x7C56E40", VA = "0x187C58240", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool AAFFOOJAEGC
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public int CGKHOIGPDDF
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xA78B70", Offset = "0xA77770", VA = "0x180A78B70", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event EOAAEPAAGJE.FOFEJMNAPAB IBKPOFGDFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event PEMPDFCFPLJ KIEPAGIKIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x7C58460", Offset = "0x7C57060", VA = "0x187C58460", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x7C58100", Offset = "0x7C56D00", VA = "0x187C58100", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<bool> PNICNHIGDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<GDNMNFALBCN> IOLDOLDCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action MHHLOKCFJGM
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x7C581A0", Offset = "0x7C56DA0", VA = "0x187C581A0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x7C585B0", Offset = "0x7C571B0", VA = "0x187C585B0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0xBB8930", Offset = "0xBB7530", VA = "0x180BB8930")]
	public BGODMMLHFNN(FNLDFBFCOLB ACLFABLMHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x7C58500", Offset = "0x7C57100", VA = "0x187C58500", Slot = "8")]
	public bool NKJHBMLPIMI(byte DBIADELHCAC, object ADBGIDEPMFJ, JJDLPMGEECN BFKAHMLFOLP, SendOptions MNGKBMLKHPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x7C582E0", Offset = "0x7C56EE0", VA = "0x187C582E0", Slot = "16")]
	public GDNMNFALBCN KBNHCMPDJOD(int HOGOECIJPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "19")]
	public void JBBJIOFGKPA(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "20")]
	public void JMDLGLJIDEF(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "21")]
	public void BOAJFCEDFAA(object IKLHDHMJFFL, bool BLDCPMNMFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7C58410", Offset = "0x7C57010", VA = "0x187C58410", Slot = "22")]
	public IDisposable MDEDMHAELOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "23")]
	private bool JAMPENPLBPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "24")]
	public void HKJFPANDMIG(StringBuilder MKOCLFBKMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0xD94760", Offset = "0xD93360", VA = "0x180D94760", Slot = "25")]
	public bool OAJFAJCIACA(bool KMHEHKLABAE, [Out] string AHPAHIHOBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0xD3F040", Offset = "0xD3DC40", VA = "0x180D3F040", Slot = "28")]
	public void BPPFOOJBIGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
internal struct ONNDOCGPBDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private readonly IDictionary<object, object> MCKCODFDFLP;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0xBDB470", Offset = "0xBDA070", VA = "0x180BDB470")]
	public ONNDOCGPBDI(IDictionary<object, object> MCKCODFDFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F860", Offset = "0x7C6E460", VA = "0x187C6F860")]
	public bool PFFNNNDMCGD([Out] DKFJDNOJOIC KBPDEFFIKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F7B0", Offset = "0x7C6E3B0", VA = "0x187C6F7B0")]
	public Guid OGGGMCNGNEF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F680", Offset = "0x7C6E280", VA = "0x187C6F680")]
	public DMOINJJJLLJ MBDLEHAGGON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F590", Offset = "0x7C6E190", VA = "0x187C6F590")]
	public static ExitGames.Client.Photon.Hashtable EPPBBCFCJMI(DKFJDNOJOIC KBPDEFFIKOJ, DMOINJJJLLJ IIHIICEIEJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal static class NACHOJLNICH
{
	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D4D0", Offset = "0x7C6C0D0", VA = "0x187C6D4D0")]
	public static bool IJMHODKOBJG(this GJIEMBMKFED LHACABBHAGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal struct OMEJDJKPJGL : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct DBOIHJMJLHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public OMEJDJKPJGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x7C5DD10", Offset = "0x7C5C910", VA = "0x187C5DD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x7C5DEF0", Offset = "0x7C5CAF0", VA = "0x187C5DEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private readonly CancellationTokenSource HGGNOAGNIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000389")]
	private bool EIHBPFOIIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038A")]
	private Task LFJIOJDNNEN;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool KBPDDCJKJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F430", Offset = "0x7C6E030", VA = "0x187C6F430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F460", Offset = "0x7C6E060", VA = "0x187C6F460")]
	public OMEJDJKPJGL(CancellationToken NAOIMKEDKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F2D0", Offset = "0x7C6DED0", VA = "0x187C6F2D0")]
	[AsyncStateMachine(typeof(DBOIHJMJLHI))]
	public Task BFFKACNNNFC(Func<CancellationToken, List<Task>> GELEMJBLADG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F3E0", Offset = "0x7C6DFE0", VA = "0x187C6F3E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public readonly struct DKODLFBAMNJ<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct OEALKEAHFKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<HAKOKJPNEOL<TData>, KLJHHNJNNDG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public DKODLFBAMNJ<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private TaskAwaiter<PNJEPLMEKHI<HAKOKJPNEOL<TData>, KLJHHNJNNDG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x4F72D90", Offset = "0x4F71990", VA = "0x184F72D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7550", Offset = "0x3FF6150", VA = "0x183FF7550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private readonly EICOLPKHCNF<TGetDataArg, TData> IHDBCEJNIED;

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xBDB470", Offset = "0xBDA070", VA = "0x180BDB470")]
	internal DKODLFBAMNJ(EICOLPKHCNF<TGetDataArg, TData> CJMMHNIMOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x631F1E0", Offset = "0x631DDE0", VA = "0x18631F1E0")]
	[AsyncStateMachine(typeof(DKODLFBAMNJ<, >.OEALKEAHFKI))]
	public Task<PNJEPLMEKHI<HAKOKJPNEOL<TData>, KLJHHNJNNDG>> NEGGNIHHAGC(TGetDataArg GJPLANLJOMM, string AMHGIACPHMG, FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public static class MMPOAHONMKA
{
	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x316A2A0", Offset = "0x3168EA0", VA = "0x18316A2A0")]
	public static DKODLFBAMNJ<TGetDataArg, TData> JPHABLICNHB<TGetDataArg, TData>(EICOLPKHCNF<TGetDataArg, TData> CJMMHNIMOJB)
	{
		return default(DKODLFBAMNJ<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public struct DJHIMIFIFBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public readonly int AHLCEPHNFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public readonly int? HGDBNIALHPK;

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x4AE90F0", Offset = "0x4AE7CF0", VA = "0x184AE90F0")]
	public DJHIMIFIFBN(int BODILIPNFGI, [Optional] int? GNDEANBBNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FE10", Offset = "0x7C5EA10", VA = "0x187C5FE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public interface LDPCAEOBAKF<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJPGCJIGBJD();

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LDPCAEOBAKF<T> OBDDPPMELKH(string ADNNPIPKIEB);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LDPCAEOBAKF<T> CMPMFOGJALN(DNGCPPBNJLH<T> AMILNEMIHAL);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LDPCAEOBAKF<T> PGJGAEJBFAH(int LNJMPIHLDED);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LDPCAEOBAKF<T> FIBILKBHJMN(int LNJMPIHLDED, EKJJABHMEKP<T> MGMKCLBGPCK);
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public interface NBDPEGDJHOL
{
	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LDPCAEOBAKF<T> JKCMCNIOFAI<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BIHNGEGPIIH KINIPOMIGLJ(Exception COMMOGJDAGN);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DJHIMIFIFBN NGGMMEELGKE(Exception COMMOGJDAGN);
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public delegate string DNGCPPBNJLH<in T>(T COMMOGJDAGN) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public delegate int EKJJABHMEKP<in T>(T COMMOGJDAGN) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000F5")]
internal class FAJFLDCGMBJ : NBDPEGDJHOL
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	private delegate string DNAPKENOIFJ(Exception COMMOGJDAGN);

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	private delegate int IIHOEDBFIGK(Exception COMMOGJDAGN);

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	private class BMOPFHIFLAK<T> : LDPCAEOBAKF<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		[CompilerGenerated]
		private sealed class IFHGLGOABIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public IFHGLGOABIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
			internal string FBPLICMCMHK(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		[CompilerGenerated]
		private sealed class ILEIPFAKFPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public DNGCPPBNJLH<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public ILEIPFAKFPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x44DB460", Offset = "0x44DA060", VA = "0x1844DB460")]
			internal string EIAKHHFHGGE(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		[CompilerGenerated]
		private sealed class GILJCGHCKCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public EKJJABHMEKP<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public GILJCGHCKCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0x44DB460", Offset = "0x44DA060", VA = "0x1844DB460")]
			internal int CNCJGHKNEKE(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private readonly FAJFLDCGMBJ JACJFOPJCNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private readonly Type BJODCFNJBGN;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x581EC00", Offset = "0x581D800", VA = "0x18581EC00")]
		internal BMOPFHIFLAK(FAJFLDCGMBJ JACJFOPJCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x581E930", Offset = "0x581D530", VA = "0x18581E930", Slot = "4")]
		public void EJPGCJIGBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x581EAA0", Offset = "0x581D6A0", VA = "0x18581EAA0", Slot = "5")]
		public LDPCAEOBAKF<T> OBDDPPMELKH(string ADNNPIPKIEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x581E810", Offset = "0x581D410", VA = "0x18581E810", Slot = "6")]
		public LDPCAEOBAKF<T> CMPMFOGJALN(DNGCPPBNJLH<T> AMILNEMIHAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x581EBC0", Offset = "0x581D7C0", VA = "0x18581EBC0", Slot = "7")]
		public LDPCAEOBAKF<T> PGJGAEJBFAH(int LNJMPIHLDED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x581E960", Offset = "0x581D560", VA = "0x18581E960", Slot = "8")]
		public LDPCAEOBAKF<T> FIBILKBHJMN(int LNJMPIHLDED, EKJJABHMEKP<T> MGMKCLBGPCK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private class HGADPMAKDIJ<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private bool KBMENNCJLNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private readonly List<Type> DABILJEDJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private readonly Dictionary<Type, TVal> BOAMAIEJHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly Dictionary<Type, int> PDNOPIHNHOB;

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public IReadOnlyList<Type> GMMJNLDKLHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0x45B2EE0", Offset = "0x45B1AE0", VA = "0x1845B2EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x45B3500", Offset = "0x45B2100", VA = "0x1845B3500")]
		public HGADPMAKDIJ(Dictionary<Type, int> PDNOPIHNHOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x45B31A0", Offset = "0x45B1DA0", VA = "0x1845B31A0")]
		public void GFCJDEIJPEO(Type NKANGPLHEGE, TVal ODFJOPDFEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x45B2E80", Offset = "0x45B1A80", VA = "0x1845B2E80")]
		public bool ALDLKJOOCIM(Type BJODCFNJBGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x45B3380", Offset = "0x45B1F80", VA = "0x1845B3380")]
		public bool INKNHBFADMF(TVal MPDLOLIOGJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x45B3320", Offset = "0x45B1F20", VA = "0x1845B3320")]
		public TVal IMOGIGFHIEP(Type ADFFEBFOCBD)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x45B3060", Offset = "0x45B1C60", VA = "0x1845B3060")]
		[CompilerGenerated]
		private int FMGENOJICED(Type EMPBJNJLKCI, Type OPIOMKLKFOC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class GKKGJCPHJOG : IEnumerable<DJHIMIFIFBN>, IEnumerable, IEnumerator<DJHIMIFIFBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private DJHIMIFIFBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public FAJFLDCGMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private IEnumerator<DJHIMIFIFBN> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		private DJHIMIFIFBN System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x40685B0", Offset = "0x40671B0", VA = "0x1840685B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(DJHIMIFIFBN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x7C65130", Offset = "0x7C63D30", VA = "0x187C65130", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xD30330", Offset = "0xD2EF30", VA = "0x180D30330")]
		[DebuggerHidden]
		public GKKGJCPHJOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x7C65180", Offset = "0x7C63D80", VA = "0x187C65180", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x7C64B70", Offset = "0x7C63770", VA = "0x187C64B70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x7C64AD0", Offset = "0x7C636D0", VA = "0x187C64AD0")]
		private void AOMOFJGADBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x7C64B20", Offset = "0x7C63720", VA = "0x187C64B20")]
		private void BENEFBJOBNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x7C650E0", Offset = "0x7C63CE0", VA = "0x187C650E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x7C65020", Offset = "0x7C63C20", VA = "0x187C65020", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DJHIMIFIFBN> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x7C65020", Offset = "0x7C63C20", VA = "0x187C65020", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	private static readonly DJHIMIFIFBN IPHJEGFOHKF;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	private static readonly Dictionary<Type, int> OPGPEPMPJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039E")]
	private readonly HashSet<Type> CAJACFFKIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private readonly HGADPMAKDIJ<int> OKPHOGIMOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	private readonly HGADPMAKDIJ<IIHOEDBFIGK> CEJFFJCGBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	private readonly HGADPMAKDIJ<DNAPKENOIFJ> NPJGLBOPLKK;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7C61CF0", Offset = "0x7C608F0", VA = "0x187C61CF0")]
	[DMDJPIBKEJJ.OHIIEKNFAKB.OKGKMEFLHLK]
	internal static void HMDEJEGKIBO(KPLLBHIBBNH DMGOKFDJBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7C62780", Offset = "0x7C61380", VA = "0x187C62780")]
	[RecRoom.NoEngine.Common.Preserve]
	public FAJFLDCGMBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x30E8390", Offset = "0x30E6F90", VA = "0x1830E8390", Slot = "4")]
	public LDPCAEOBAKF<T> JKCMCNIOFAI<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7C61E90", Offset = "0x7C60A90", VA = "0x187C61E90", Slot = "5")]
	public BIHNGEGPIIH KINIPOMIGLJ(Exception COMMOGJDAGN)
	{
		return default(BIHNGEGPIIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7C621F0", Offset = "0x7C60DF0", VA = "0x187C621F0", Slot = "6")]
	public DJHIMIFIFBN NGGMMEELGKE(Exception? COMMOGJDAGN)
	{
		return default(DJHIMIFIFBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x7C61DF0", Offset = "0x7C609F0", VA = "0x187C61DF0", Slot = "7")]
	[IteratorStateMachine(typeof(GKKGJCPHJOG))]
	public IEnumerable<DJHIMIFIFBN> JLJKAMEDBLP(Exception COMMOGJDAGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7C620A0", Offset = "0x7C60CA0", VA = "0x187C620A0", Slot = "8")]
	public string NELKBMFBLEG(Exception? COMMOGJDAGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7C619F0", Offset = "0x7C605F0", VA = "0x187C619F0")]
	private string HAJFOCMNEOG(AggregateException FLDCLABEEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x7C61310", Offset = "0x7C5FF10", VA = "0x187C61310")]
	private void CBIFONBBKCJ(Type BJODCFNJBGN, int LNJMPIHLDED, IIHOEDBFIGK? NOKJKIPNBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x7C616C0", Offset = "0x7C602C0", VA = "0x187C616C0")]
	private void FIOGFGFGJIL(Type BJODCFNJBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7C623F0", Offset = "0x7C60FF0", VA = "0x187C623F0")]
	private void OEPMIFMIGFL(Type BJODCFNJBGN, DNAPKENOIFJ KBOGCHNAJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x7C61F20", Offset = "0x7C60B20", VA = "0x187C61F20")]
	private static int KJCLAKNGKFE(Type BJODCFNJBGN, Dictionary<Type, int> PDNOPIHNHOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x334DF80", Offset = "0x334CB80", VA = "0x18334DF80")]
	private static bool BCOJPMBCNME<TVal>(HGADPMAKDIJ<TVal> FKBJBKHIAAE, Type BJODCFNJBGN, [Out] TVal MPDLOLIOGJL) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x7C61910", Offset = "0x7C60510", VA = "0x187C61910")]
	[CompilerGenerated]
	internal static int FPHBBAJDMNM(Type EIDCNKFJLCC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public struct BIHNGEGPIIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public readonly DJHIMIFIFBN IOAGLBJIAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public readonly string EAHECHEPPEC;

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x7C598A0", Offset = "0x7C584A0", VA = "0x187C598A0")]
	public BIHNGEGPIIH(string EBPNLGEAMHN, DJHIMIFIFBN LNJMPIHLDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x7C59800", Offset = "0x7C58400", VA = "0x187C59800")]
	public string ELCCJOGEFJE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public class CGFOHGKICKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	private readonly LPPPCMBMLLD KHNLPEFIACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	private string LPHAFGMAJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	private long? IHOAGCFOIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	private long? IKLMEEALMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	private long? NEBMECCIOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	private string KOIMFECDDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	private GMPFCPBAOFJ JOOIEIEBMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	private long? IIJEGCPDODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	private bool PHMJKEJLCHA;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public string JHMLCJGCNMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public long FPBLKCONBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x7C5C2F0", Offset = "0x7C5AEF0", VA = "0x187C5C2F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public long LHJBBGGKKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x7C5CE70", Offset = "0x7C5BA70", VA = "0x187C5CE70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public long NFDFJMLKLCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x7C5CF70", Offset = "0x7C5BB70", VA = "0x187C5CF70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public string CIOONDDFEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x7C5C860", Offset = "0x7C5B460", VA = "0x187C5C860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public GMPFCPBAOFJ EDJNDELLMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xBEA7E0", Offset = "0xBE93E0", VA = "0x180BEA7E0")]
		get
		{
			return default(GMPFCPBAOFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x7C5CFD0", Offset = "0x7C5BBD0", VA = "0x187C5CFD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public long GMINIBDGCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x7C5D0C0", Offset = "0x7C5BCC0", VA = "0x187C5D0C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D120", Offset = "0x7C5BD20", VA = "0x187C5D120")]
	[UnityEngine.Scripting.Preserve]
	public CGFOHGKICKB([GJMNBPKNJPO(null)] LPPPCMBMLLD KHNLPEFIACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CC20", Offset = "0x7C5B820", VA = "0x187C5CC20")]
	private void JCJKBKPLFHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C3D0", Offset = "0x7C5AFD0", VA = "0x187C5C3D0")]
	public void FFDEAMFKLHN(long EPGJLNEAJPA, long DMLJPKIDBPD, [Optional] long? JKENKIDPAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CED0", Offset = "0x7C5BAD0", VA = "0x187C5CED0")]
	public void NKDHKAFCCLJ(long JKENKIDPAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C350", Offset = "0x7C5AF50", VA = "0x187C5C350")]
	public void FDLLAGAJPGK(string MODFNHOHCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C8A0", Offset = "0x7C5B4A0", VA = "0x187C5C8A0")]
	public void GBDBCFBCHOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal class GDLHPPGEFNI : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct NIAFEBIGDGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public AsyncTaskMethodBuilder<DKFJDNOJOIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public DKFJDNOJOIC roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public GDLHPPGEFNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private TaskAwaiter<OAACMBCGIPK.OLHCHJBFINO<DKFJDNOJOIC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C6D5B0", Offset = "0x7C6C1B0", VA = "0x187C6D5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C6DAF0", Offset = "0x7C6C6F0", VA = "0x187C6DAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct PJFENBIJLCF<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class BPGJHODJMOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public DKFJDNOJOIC roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public BPGJHODJMOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AFF0", Offset = "0x7C59BF0", VA = "0x187C5AFF0")]
		internal DKFJDNOJOIC HIOGLDPFAFJ(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct HCCCHKDHKHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public AsyncTaskMethodBuilder<OAACMBCGIPK.OLHCHJBFINO<DKFJDNOJOIC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public DKFJDNOJOIC roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public GDLHPPGEFNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private KMEJPIJJHOD <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private TaskAwaiter<OAACMBCGIPK.OLHCHJBFINO<DKFJDNOJOIC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C65530", Offset = "0x7C64130", VA = "0x187C65530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C65B40", Offset = "0x7C64740", VA = "0x187C65B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct DJDKPFHLPFJ<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public GDLHPPGEFNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x631CB10", Offset = "0x631B710", VA = "0x18631CB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6BF0", Offset = "0x3CB57F0", VA = "0x183CB6BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct FALMKKPBKEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public GDLHPPGEFNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C62B20", Offset = "0x7C61720", VA = "0x187C62B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C62CE0", Offset = "0x7C618E0", VA = "0x187C62CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class JOAABDCLKLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public JOAABDCLKLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C69820", Offset = "0x7C68420", VA = "0x187C69820")]
		internal object DGLMBAOFCPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C69880", Offset = "0x7C68480", VA = "0x187C69880")]
		internal bool IAKOHHKJACM(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class EIGEFKNDDMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public EIGEFKNDDMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C60910", Offset = "0x7C5F510", VA = "0x187C60910")]
		internal object PBCCLNCNGGC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private sealed class LPOBOFHCAFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public LPOBOFHCAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x7C6C050", Offset = "0x7C6AC50", VA = "0x187C6C050")]
		internal object IJJGIMBMOBI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private sealed class CIICDBLKFDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public CIICDBLKFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x7C5DB50", Offset = "0x7C5C750", VA = "0x187C5DB50")]
		internal object ADAAADGODAJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class IIGCOPKKHIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public GDLHPPGEFNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public IIGCOPKKHIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C66DD0", Offset = "0x7C659D0", VA = "0x187C66DD0")]
		internal object EPBMCJGBKDM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private static readonly Guid JOOIKKCEDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public readonly AIKLBIMPFFC MMJDINNGFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly OAACMBCGIPK CMKDDEPADGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly GKKFDFILMMC CDOHCPAIEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly OMKDFABMFAN CBHBFEOIKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	private bool LMKNKKKBBPP;

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C644E0", Offset = "0x7C630E0", VA = "0x187C644E0")]
	public GDLHPPGEFNI(AIKLBIMPFFC GAJFLBPNGCK, OAACMBCGIPK CMKDDEPADGF, GKKFDFILMMC CDOHCPAIEHP, OMKDFABMFAN CBHBFEOIKIC, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C638B0", Offset = "0x7C624B0", VA = "0x187C638B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C63680", Offset = "0x7C62280", VA = "0x187C63680")]
	public void CHNGMDJADMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C63AA0", Offset = "0x7C626A0", VA = "0x187C63AA0")]
	public void IAPBBGPAHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C63B60", Offset = "0x7C62760", VA = "0x187C63B60")]
	public void JCGHIIJKMKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C64090", Offset = "0x7C62C90", VA = "0x187C64090")]
	[AsyncStateMachine(typeof(NIAFEBIGDGJ))]
	internal Task<DKFJDNOJOIC> LKFPOAGCHCM(FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, DKFJDNOJOIC AGMOEDNNLFN, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x336FFF0", Offset = "0x336EBF0", VA = "0x18336FFF0")]
	private static byte[] ANFHLCPKDPD<T>(T KBPDEFFIKOJ) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x3370540", Offset = "0x336F140", VA = "0x183370540")]
	private static T MLGNPCINEKE<T>(MessageParser<T> BMJNONDENEE, byte[] KBPDEFFIKOJ, T ENLAJEPNFNO) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C63F50", Offset = "0x7C62B50", VA = "0x187C63F50")]
	[AsyncStateMachine(typeof(HCCCHKDHKHA))]
	private Task<OAACMBCGIPK.OLHCHJBFINO<DKFJDNOJOIC>> LGOLBFKOOMP(DKFJDNOJOIC AGMOEDNNLFN, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x3370000", Offset = "0x336EC00", VA = "0x183370000")]
	[AsyncStateMachine(typeof(DJDKPFHLPFJ<>))]
	internal Task<T> JGMLCFNMODJ<T>(CancellationToken MJJLMJBFHKM, Func<CancellationToken, Task<T>> KBDDGHFHILM, int JPIMFGAHECB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C63C20", Offset = "0x7C62820", VA = "0x187C63C20")]
	[AsyncStateMachine(typeof(FALMKKPBKEN))]
	internal Task JGMLCFNMODJ(CancellationToken MJJLMJBFHKM, Func<CancellationToken, Task> KBDDGHFHILM, int JPIMFGAHECB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x7C634A0", Offset = "0x7C620A0", VA = "0x187C634A0")]
	public NNEIKHJFFLC AOHMODACAAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C638C0", Offset = "0x7C624C0", VA = "0x187C638C0")]
	public JMOOMBIGPHA EPDDGKPPAIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C63D50", Offset = "0x7C62950", VA = "0x187C63D50")]
	public BPLDJNEHPDK KDCOPLPCGGH([Optional] NDNFAPMFFIF? DFFCPCMIFOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C63520", Offset = "0x7C62120", VA = "0x187C63520")]
	public void BKKGBFFPLMK(Func<Guid, bool> LMCMNHGBIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x7C641F0", Offset = "0x7C62DF0", VA = "0x187C641F0")]
	public void OHAFKPKHNKN(Func<Guid, bool> IIHGEDMJCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x7C64300", Offset = "0x7C62F00", VA = "0x187C64300")]
	public Guid PGHAOOIGDJC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x7C637A0", Offset = "0x7C623A0", VA = "0x187C637A0")]
	public void CIKPAOAANFD(Guid LOGCALAGGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x7C63370", Offset = "0x7C61F70", VA = "0x187C63370")]
	public void ACONDCFJCAJ(DKFJDNOJOIC ENOCBFKAFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C63990", Offset = "0x7C62590", VA = "0x187C63990")]
	public void HBFNBGCENOB(string DEDNJEOBKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x3370690", Offset = "0x336F290", VA = "0x183370690")]
	private T NLBPFLOFLCI<T>(T MPDLOLIOGJL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x7C63940", Offset = "0x7C62540", VA = "0x187C63940")]
	public void GCDKBEKMEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x33702A0", Offset = "0x336EEA0", VA = "0x1833702A0")]
	[CompilerGenerated]
	internal static string MGIHNICKPDL<T>(byte[] FOLLKKLPOMJ, int NGOEEBFMFOH, PJFENBIJLCF<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
internal sealed class PGPCCIECLKD : AIKLBIMPFFC
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class JMBHLHKJMLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public JMBHLHKJMLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C679E0", Offset = "0x7C665E0", VA = "0x187C679E0")]
		internal object IAJIPBONKMF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct AOAAKAFAFMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public PGPCCIECLKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public GDLHPPGEFNI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private KHAMOMBBPPI <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private JMOOMBIGPHA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C574B0", Offset = "0x7C560B0", VA = "0x187C574B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C57E00", Offset = "0x7C56A00", VA = "0x187C57E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct PNAOLDNPEML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public PGPCCIECLKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private TaskAwaiter<BCPENJPKFJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C702D0", Offset = "0x7C6EED0", VA = "0x187C702D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C70A00", Offset = "0x7C6F600", VA = "0x187C70A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct OFLCJCPLLFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public PGPCCIECLKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		private TaskAwaiter<NAKFAFENAFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EB40", Offset = "0x7C6D740", VA = "0x187C6EB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EE50", Offset = "0x7C6DA50", VA = "0x187C6EE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class IKKNGKDBKBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public KHAMOMBBPPI presence;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public IKKNGKDBKBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C67020", Offset = "0x7C65C20", VA = "0x187C67020")]
		internal object IEDAJOMGCIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	private static readonly NDNFAPMFFIF DGCKGNFPJBN;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	private static readonly NDNFAPMFFIF ONFPFKLEDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	private readonly PDKHDMNJGNI CAFEFALKHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	private readonly GJIEMBMKFED PDIIEIMPFKE;

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x7C70010", Offset = "0x7C6EC10", VA = "0x187C70010")]
	public PGPCCIECLKD(PDKHDMNJGNI CAFEFALKHPP, GJIEMBMKFED PDIIEIMPFKE, Guid HBKGJHPGIDP, CCOEFMMBAGF MGMNCIIJMMO, CBACDIIFINF MELNFNGOHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x7C6FA20", Offset = "0x7C6E620", VA = "0x187C6FA20", Slot = "7")]
	[AsyncStateMachine(typeof(AOAAKAFAFMO))]
	protected override Task ICHELDHMAHL(GDLHPPGEFNI AHAIDLILHKJ, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x7C6FC70", Offset = "0x7C6E870", VA = "0x187C6FC70")]
	[AsyncStateMachine(typeof(PNAOLDNPEML))]
	private Task LCFJHKLFMCA(CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x7C6FB60", Offset = "0x7C6E760", VA = "0x187C6FB60")]
	[AsyncStateMachine(typeof(OFLCJCPLLFA))]
	private Task<int> KODBLHBHHGE(CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C6FD70", Offset = "0x7C6E970", VA = "0x187C6FD70")]
	private KHAMOMBBPPI LNDBHEFBOHC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class MEDEJIGBEIA : AIKLBIMPFFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct KGIOAHAPNHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public MEDEJIGBEIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public GDLHPPGEFNI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private TaskAwaiter<BGHBHPAMLJF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x7C69F50", Offset = "0x7C68B50", VA = "0x187C69F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C6A8F0", Offset = "0x7C694F0", VA = "0x187C6A8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private readonly int KEICHGOCAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private readonly JOHMHGNLPIP EBANPFALAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly long JMAKOHJDMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public readonly long PHACIOLMFHF;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public BGHBHPAMLJF CJBNMNANKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x9631F0", Offset = "0x961DF0", VA = "0x1809631F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x963190", Offset = "0x961D90", VA = "0x180963190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C1E0", Offset = "0x7C6ADE0", VA = "0x187C6C1E0")]
	public MEDEJIGBEIA(Guid HBKGJHPGIDP, CCOEFMMBAGF MGMNCIIJMMO, CBACDIIFINF MELNFNGOHEB, int KEICHGOCAFG, JOHMHGNLPIP EBANPFALAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C0C0", Offset = "0x7C6ACC0", VA = "0x187C6C0C0", Slot = "7")]
	[AsyncStateMachine(typeof(KGIOAHAPNHK))]
	protected override Task ICHELDHMAHL(GDLHPPGEFNI AHAIDLILHKJ, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal abstract class FNEOCEBPOGJ : AIKLBIMPFFC
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class IMGMHJDMJON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public FNEOCEBPOGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public ENOABELDKIL playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public IMGMHJDMJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x7C67280", Offset = "0x7C65E80", VA = "0x187C67280")]
		internal Task IFKDEDJCLHK(FNEANCIAOBI<string>.IDKBCAKILKJ postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C672C0", Offset = "0x7C65EC0", VA = "0x187C672C0")]
		internal object JCEIIPANMHN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct BKHIONJEMKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public FNEOCEBPOGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public GDLHPPGEFNI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private IMGMHJDMJON <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C59EC0", Offset = "0x7C58AC0", VA = "0x187C59EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A690", Offset = "0x7C59290", VA = "0x187C5A690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct KAPPOAFBHCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public ENOABELDKIL playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public FNEOCEBPOGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C69940", Offset = "0x7C68540", VA = "0x187C69940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x7C69EF0", Offset = "0x7C68AF0", VA = "0x187C69EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C63320", Offset = "0x7C61F20", VA = "0x187C63320")]
	public FNEOCEBPOGJ(Guid HBKGJHPGIDP, CCOEFMMBAGF MGMNCIIJMMO, CBACDIIFINF MELNFNGOHEB, string PFEDEAGMAGE, KMCPGADBLKC PAHFPJDPHAE, bool KAKECJKHFKO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C630A0", Offset = "0x7C61CA0", VA = "0x187C630A0", Slot = "7")]
	[AsyncStateMachine(typeof(BKHIONJEMKG))]
	protected override Task ICHELDHMAHL(GDLHPPGEFNI AHAIDLILHKJ, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task GFEEIOIFPJL(GDLHPPGEFNI AHAIDLILHKJ, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C631E0", Offset = "0x7C61DE0", VA = "0x187C631E0")]
	[AsyncStateMachine(typeof(KAPPOAFBHCF))]
	private Task NLKBCFHJNMA(IDisposable KENMBPIAEIF, ENOABELDKIL OIHFFIBFJML, FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal class APPILKIMLFF : AIKLBIMPFFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct LJNIBPFDPND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public APPILKIMLFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public GDLHPPGEFNI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private TaskAwaiter<DDJCMNHOHEN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C6ADF0", Offset = "0x7C699F0", VA = "0x187C6ADF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x7C6B360", Offset = "0x7C69F60", VA = "0x187C6B360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private readonly GBJMJAJMANP GEJNDLMJHME;

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x7C58060", Offset = "0x7C56C60", VA = "0x187C58060")]
	public APPILKIMLFF(Guid HBKGJHPGIDP, CCOEFMMBAGF MGMNCIIJMMO, CBACDIIFINF MELNFNGOHEB, GBJMJAJMANP GEJNDLMJHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x7C57F80", Offset = "0x7C56B80", VA = "0x187C57F80", Slot = "6")]
	protected override string OAHIGOICPFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x7C57E60", Offset = "0x7C56A60", VA = "0x187C57E60", Slot = "7")]
	[AsyncStateMachine(typeof(LJNIBPFDPND))]
	protected override Task ICHELDHMAHL(GDLHPPGEFNI AHAIDLILHKJ, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal abstract class AIKLBIMPFFC : OOCBOHNBEIH
{
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public delegate Task CPCDIEDFGMM(FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class PMCCBAPMCME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public AIKLBIMPFFC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public PMCCBAPMCME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x7C701A0", Offset = "0x7C6EDA0", VA = "0x187C701A0")]
		internal Task JFKFPNBDAGF(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class AJBBGOBJHMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public PMCCBAPMCME CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public AJBBGOBJHMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x7C56ED0", Offset = "0x7C55AD0", VA = "0x187C56ED0")]
		internal object MEOLKGFJKMJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private struct BPGNPNJPDAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public AIKLBIMPFFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public Func<AIKLBIMPFFC, FNEANCIAOBI<string>.IDKBCAKILKJ, GDLHPPGEFNI> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private PMCCBAPMCME <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private GDLHPPGEFNI <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private TaskAwaiter<DKFJDNOJOIC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B0D0", Offset = "0x7C59CD0", VA = "0x187C5B0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x7C5C290", Offset = "0x7C5AE90", VA = "0x187C5C290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct DJEDEMOEABB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x7C5E1A0", Offset = "0x7C5CDA0", VA = "0x187C5E1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x7C5EC40", Offset = "0x7C5D840", VA = "0x187C5EC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct GJHONIDMPIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public AIKLBIMPFFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x7C64710", Offset = "0x7C63310", VA = "0x187C64710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x7C64A70", Offset = "0x7C63670", VA = "0x187C64A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public readonly Guid GGHEGFOPPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public readonly ByteString PBPKLIBOHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public readonly CBACDIIFINF IDOAOHDLEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	protected readonly string OOKJJEAHNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly CCOEFMMBAGF MGMNCIIJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private readonly bool KAKECJKHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private readonly Queue<CPCDIEDFGMM> COPEIDNOINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly FFAGHJPHLLH ODODPBEBKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private readonly KMCPGADBLKC PAHFPJDPHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private bool DGMPEKHAEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public GMPFCPBAOFJ BDEPFKAJKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public GMPFCPBAOFJ IGLOCGDCHJI;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public CCOEFMMBAGF IBAOJHOHOJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x95CEF0", Offset = "0x95BAF0", VA = "0x18095CEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public FELCLIHLJOK GNGHLGLBLNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C56840", Offset = "0x7C55440", VA = "0x187C56840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public KBHJNNDHNLA MIGBFCLAGPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C56D20", Offset = "0x7C55920", VA = "0x187C56D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public ONBJJNNFOFI EKBCFEONFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C56280", Offset = "0x7C54E80", VA = "0x187C56280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event KHHDCNPGNJA HOGNFFHBGGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C56D00", Offset = "0x7C55900", VA = "0x187C56D00", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x7C56CE0", Offset = "0x7C558E0", VA = "0x187C56CE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C56D70", Offset = "0x7C55970", VA = "0x187C56D70")]
	protected AIKLBIMPFFC(Guid HBKGJHPGIDP, CCOEFMMBAGF MGMNCIIJMMO, CBACDIIFINF MELNFNGOHEB, string PFEDEAGMAGE, KMCPGADBLKC PAHFPJDPHAE, bool KAKECJKHFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x7C56CA0", Offset = "0x7C558A0", VA = "0x187C56CA0", Slot = "6")]
	protected virtual string OAHIGOICPFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x7C56220", Offset = "0x7C54E20", VA = "0x187C56220")]
	public void AGGMBHBJONE(CPCDIEDFGMM FACDALAFIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x7C566A0", Offset = "0x7C552A0", VA = "0x187C566A0")]
	protected void EPNGCCKGLOI(float NKBNDBLIKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x7C56300", Offset = "0x7C54F00", VA = "0x187C56300")]
	[AsyncStateMachine(typeof(BPGNPNJPDAE))]
	public Task BDNCCGGPJGH(CancellationToken NAOIMKEDKEJ, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, [Optional] Func<AIKLBIMPFFC, FNEANCIAOBI<string>.IDKBCAKILKJ, GDLHPPGEFNI> NEJBPGCADOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x7C56450", Offset = "0x7C55050", VA = "0x187C56450")]
	[AsyncStateMachine(typeof(DJEDEMOEABB))]
	private static Task BNDLEMODGPO(Func<CancellationToken, Task> COOBANAILNP, Func<CancellationToken, Task> JHEOBLJMDHJ, CancellationToken MJJLMJBFHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x7C566C0", Offset = "0x7C552C0", VA = "0x187C566C0")]
	private void FCPMBHHBACN(bool CFLNFJDNJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x7C56A80", Offset = "0x7C55680", VA = "0x187C56A80")]
	private void NNMBEKABDLL(GDLHPPGEFNI AHAIDLILHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task ICHELDHMAHL(GDLHPPGEFNI AHAIDLILHKJ, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x7C56580", Offset = "0x7C55180", VA = "0x187C56580")]
	[AsyncStateMachine(typeof(GJHONIDMPIB))]
	private Task COPOBGFCBBI(FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x7C56910", Offset = "0x7C55510", VA = "0x187C56910")]
	public DKFJDNOJOIC LAIIMEBCMFP(KMEJPIJJHOD HCDBLAHMLFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x7C56990", Offset = "0x7C55590", VA = "0x187C56990")]
	[CompilerGenerated]
	private Task MLONOILFJOO(CancellationToken LDIBCOFKEDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x7C56890", Offset = "0x7C55490", VA = "0x187C56890")]
	[CompilerGenerated]
	private object KHLEMIABJAF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal sealed class HAPDGKGPFNP : FNEOCEBPOGJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct MLFHGGMHGEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public HAPDGKGPFNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public GDLHPPGEFNI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private LJCMGKIJECP <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private JMOOMBIGPHA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x7C6C7B0", Offset = "0x7C6B3B0", VA = "0x187C6C7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x7C6CF10", Offset = "0x7C6BB10", VA = "0x187C6CF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private readonly PDKHDMNJGNI CHBINNBOPHE;

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x7C65420", Offset = "0x7C64020", VA = "0x187C65420")]
	public HAPDGKGPFNP(Guid HBKGJHPGIDP, CCOEFMMBAGF MGMNCIIJMMO, PDKHDMNJGNI CHBINNBOPHE, CBACDIIFINF MELNFNGOHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x7C652D0", Offset = "0x7C63ED0", VA = "0x187C652D0", Slot = "8")]
	[AsyncStateMachine(typeof(MLFHGGMHGEJ))]
	protected override Task GFEEIOIFPJL(GDLHPPGEFNI AHAIDLILHKJ, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal class EKPDHFBKNAI : AIKLBIMPFFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct OMBNMEEBMCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public EKPDHFBKNAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public GDLHPPGEFNI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private TaskAwaiter<DDJCMNHOHEN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EEC0", Offset = "0x7C6DAC0", VA = "0x187C6EEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F270", Offset = "0x7C6DE70", VA = "0x187C6F270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private readonly string EJGBLJJEFMK;

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x7C60A80", Offset = "0x7C5F680", VA = "0x187C60A80")]
	public EKPDHFBKNAI(Guid HBKGJHPGIDP, CCOEFMMBAGF MGMNCIIJMMO, CBACDIIFINF MELNFNGOHEB, string EJGBLJJEFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x7C60970", Offset = "0x7C5F570", VA = "0x187C60970", Slot = "7")]
	[AsyncStateMachine(typeof(OMBNMEEBMCI))]
	protected override Task ICHELDHMAHL(GDLHPPGEFNI AHAIDLILHKJ, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal class JKCEHNKNJOI : FNEOCEBPOGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class JBMDPGGKPLD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012A")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			public AsyncTaskMethodBuilder<DKFJDNOJOIC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			public JBMDPGGKPLD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			private TaskAwaiter<DDJCMNHOHEN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			private TaskAwaiter<DKFJDNOJOIC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0x7C718D0", Offset = "0x7C704D0", VA = "0x187C718D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x7C71D90", Offset = "0x7C70990", VA = "0x187C71D90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public JKCEHNKNJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public BPLDJNEHPDK serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public ALDOMEDIEBM roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public NNEIKHJFFLC uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public GLNOINNEODG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public JBMDPGGKPLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x7C67350", Offset = "0x7C65F50", VA = "0x187C67350")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<DKFJDNOJOIC> IAFAIJOHJDK(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct NKMPKNOPNFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public JKCEHNKNJOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public GDLHPPGEFNI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private JBMDPGGKPLD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private LJCMGKIJECP <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private JMOOMBIGPHA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private DKFJDNOJOIC <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private TaskAwaiter<DKFJDNOJOIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x7C6DB60", Offset = "0x7C6C760", VA = "0x187C6DB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EAE0", Offset = "0x7C6D6E0", VA = "0x187C6EAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private static readonly NDNFAPMFFIF DGCKGNFPJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private readonly int HGCGPNLLJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	[CanBeNull]
	private readonly DJAABFPCNFG DHCBPLHFGNP;

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x7C67930", Offset = "0x7C66530", VA = "0x187C67930")]
	public JKCEHNKNJOI(Guid HBKGJHPGIDP, CCOEFMMBAGF MGMNCIIJMMO, int HGCGPNLLJML, DJAABFPCNFG DHCBPLHFGNP, CBACDIIFINF MELNFNGOHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x7C67470", Offset = "0x7C66070", VA = "0x187C67470", Slot = "8")]
	[AsyncStateMachine(typeof(NKMPKNOPNFM))]
	protected override Task GFEEIOIFPJL(GDLHPPGEFNI AHAIDLILHKJ, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x7C67780", Offset = "0x7C66380", VA = "0x187C67780")]
	private void OHJEJFOGLFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x7C675B0", Offset = "0x7C661B0", VA = "0x187C675B0")]
	private void GMABLEJDOPJ(FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, LJCMGKIJECP EAHKGKDJCMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
internal abstract class DDCOPDEMIJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public readonly AIKLBIMPFFC MMJDINNGFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public readonly GDLHPPGEFNI OMLANACOAMK;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public FELCLIHLJOK GNGHLGLBLNG
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5E0F0", Offset = "0x7C5CCF0", VA = "0x187C5E0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public ONBJJNNFOFI EKBCFEONFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x7C5DF50", Offset = "0x7C5CB50", VA = "0x187C5DF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E140", Offset = "0x7C5CD40", VA = "0x187C5E140")]
	protected DDCOPDEMIJO(GDLHPPGEFNI AHAIDLILHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DFE0", Offset = "0x7C5CBE0", VA = "0x187C5DFE0")]
	protected void HBFNBGCENOB(string DEDNJEOBKEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal struct BJNCCHBBNCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public Dictionary<Guid, List<LNGBFNJPCKM>> IMOGEBDLKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public Dictionary<Guid, List<LNGBFNJPCKM>> JHMGBBPGOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public Dictionary<Guid, List<LNGBFNJPCKM>> OPJLPLJPFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public List<Guid> JIJDDJAPBHO;

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x7C598C0", Offset = "0x7C584C0", VA = "0x187C598C0")]
	public static BJNCCHBBNCF IMOGIGFHIEP(FELCLIHLJOK JOHAHHCBBCJ, GMPFCPBAOFJ GHNKOJFJEJD, DFAGOCGJMME HJMFAGHEMMB)
	{
		return default(BJNCCHBBNCF);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal struct ENGCKBJDHDN
{
	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50")]
	public static ENGCKBJDHDN EPPBBCFCJMI()
	{
		return default(ENGCKBJDHDN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal struct FIFOFPOFLHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public readonly BCPENJPKFJJ MDPGCFDKEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public readonly FFBHBDHOGKB ICHBBGHLOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public readonly string ECHHHHOHFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public readonly IReadOnlyList<DIKJEBDFCIA> MKPGCELACMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public readonly HEJHHLFMEKL MAGHCEFJIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public readonly HEJHHLFMEKL LLKJICLKDCC;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool NPAGNLMMOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x7C62FA0", Offset = "0x7C61BA0", VA = "0x187C62FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x7C63010", Offset = "0x7C61C10", VA = "0x187C63010")]
	public FIFOFPOFLHC(BCPENJPKFJJ MDPGCFDKEND, FFBHBDHOGKB ICHBBGHLOON, string ECHHHHOHFJN, IReadOnlyList<DIKJEBDFCIA> MKPGCELACMI, HEJHHLFMEKL MAGHCEFJIPG, HEJHHLFMEKL LLKJICLKDCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal struct MEGCPDKOOFN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private readonly GDLHPPGEFNI AHAIDLILHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	private readonly Guid LOGCALAGGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private bool CFLNFJDNJEK;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C5F0", Offset = "0x7C6B1F0", VA = "0x187C6C5F0")]
	public static MEGCPDKOOFN PGHAOOIGDJC(GDLHPPGEFNI AHAIDLILHKJ)
	{
		return default(MEGCPDKOOFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0xFF7490", Offset = "0xFF6090", VA = "0x180FF7490")]
	public void PAKAKNKHMFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C540", Offset = "0x7C6B140", VA = "0x187C6C540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C620", Offset = "0x7C6B220", VA = "0x187C6C620")]
	private MEGCPDKOOFN(GDLHPPGEFNI AHAIDLILHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C310", Offset = "0x7C6AF10", VA = "0x187C6C310")]
	private void CIKPAOAANFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C550", Offset = "0x7C6B150", VA = "0x187C6C550")]
	private Func<Guid, bool> ENMHBFMEOBN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal class JMOOMBIGPHA : DDCOPDEMIJO, OOCBOHNBEIH
{
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	public delegate Task<GMPFCPBAOFJ> DKFKCMHBGHA(DFAGOCGJMME LLDJIJICLJF, DJCNGDIOJNF KENHJFEIPEL, FFAGHJPHLLH LMLEMKCJJPO, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct LPCLLIMGPAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public PDKHDMNJGNI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private MEGCPDKOOFN <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private TaskAwaiter<DKFJDNOJOIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x7C6B720", Offset = "0x7C6A320", VA = "0x187C6B720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x7C6BFF0", Offset = "0x7C6ABF0", VA = "0x187C6BFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct KGPMFMLBJAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public AsyncTaskMethodBuilder<DKFJDNOJOIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public PDKHDMNJGNI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private TaskAwaiter<DKFJDNOJOIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x7C6A950", Offset = "0x7C69550", VA = "0x187C6A950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x7C6AD80", Offset = "0x7C69980", VA = "0x187C6AD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct ENDLICIOHKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public PDKHDMNJGNI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x7C60B30", Offset = "0x7C5F730", VA = "0x187C60B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x7C61170", Offset = "0x7C5FD70", VA = "0x187C61170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private sealed class MLNOFJFLCFN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000138")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			public AsyncTaskMethodBuilder<FIFOFPOFLHC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			public MLNOFJFLCFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004D2")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D3")]
			private FIFOFPOFLHC <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40004D4")]
			private TaskAwaiter<GMPFCPBAOFJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40004D5")]
			private TaskAwaiter<FIFOFPOFLHC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0x7C70A60", Offset = "0x7C6F660", VA = "0x187C70A60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x7C711C0", Offset = "0x7C6FDC0", VA = "0x187C711C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000139")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004D7")]
			public AsyncTaskMethodBuilder<DFAGOCGJMME> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			public MLNOFJFLCFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			private DFAGOCGJMME <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			private TaskAwaiter<GMPFCPBAOFJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			private TaskAwaiter<DFAGOCGJMME> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x7C71230", Offset = "0x7C6FE30", VA = "0x187C71230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x7C71860", Offset = "0x7C70460", VA = "0x187C71860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public PDKHDMNJGNI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public FFAGHJPHLLH preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public FFAGHJPHLLH downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public FIFOFPOFLHC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public FFAGHJPHLLH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public DFAGOCGJMME phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public OEKPEONBLNM.ADAAGALHODG <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public MLNOFJFLCFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x7C6D1F0", Offset = "0x7C6BDF0", VA = "0x187C6D1F0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<FIFOFPOFLHC> DFHGPKBBPPK(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x7C6CF70", Offset = "0x7C6BB70", VA = "0x187C6CF70")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<DFAGOCGJMME> AOLKOOJONBI(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7C6D330", Offset = "0x7C6BF30", VA = "0x187C6D330")]
		internal void GDFGOMHCGAI(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x7C6D090", Offset = "0x7C6BC90", VA = "0x187C6D090")]
		internal Task CJJMJPLALDK(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x7C6D370", Offset = "0x7C6BF70", VA = "0x187C6D370")]
		internal Task JMNHJMLNFPE(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct BHLLPEMIEPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public PDKHDMNJGNI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private MLNOFJFLCFN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private TaskAwaiter<FIFOFPOFLHC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private TaskAwaiter<DFAGOCGJMME> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x7C58A80", Offset = "0x7C57680", VA = "0x187C58A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x7C597A0", Offset = "0x7C583A0", VA = "0x187C597A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct DJHDMMIOOBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public DFAGOCGJMME phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public FFAGHJPHLLH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private TaskAwaiter<GMPFCPBAOFJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private DJCNGDIOJNF <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x7C5ECA0", Offset = "0x7C5D8A0", VA = "0x187C5ECA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FDB0", Offset = "0x7C5E9B0", VA = "0x187C5FDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct EDEANPALJMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FFF0", Offset = "0x7C5EBF0", VA = "0x187C5FFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x7C608B0", Offset = "0x7C5F4B0", VA = "0x187C608B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct CHGOIDCOPNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public FFAGHJPHLLH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private TaskAwaiter<GMPFCPBAOFJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x7C5D160", Offset = "0x7C5BD60", VA = "0x187C5D160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x7C5DAF0", Offset = "0x7C5C6F0", VA = "0x187C5DAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct HFJNMCIOIJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public AsyncTaskMethodBuilder<GMPFCPBAOFJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public FFAGHJPHLLH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private TaskAwaiter<GMPFCPBAOFJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x7C65BB0", Offset = "0x7C647B0", VA = "0x187C65BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x7C66D60", Offset = "0x7C65960", VA = "0x187C66D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct ILNGIMLEAEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public AsyncTaskMethodBuilder<GMPFCPBAOFJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public FFAGHJPHLLH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public DJCNGDIOJNF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private TaskAwaiter<GMPFCPBAOFJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x7C7D050", Offset = "0x7C7BC50", VA = "0x187C7D050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x7C7E160", Offset = "0x7C7CD60", VA = "0x187C7E160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct HMEKMMDOHLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public AsyncTaskMethodBuilder<GMPFCPBAOFJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public GMPFCPBAOFJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public FFAGHJPHLLH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public DFAGOCGJMME deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private TaskAwaiter<GMPFCPBAOFJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x7C7BE30", Offset = "0x7C7AA30", VA = "0x187C7BE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x7C7C080", Offset = "0x7C7AC80", VA = "0x187C7C080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class GBKCOLFOCBD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000143")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public AsyncTaskMethodBuilder<GMPFCPBAOFJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public GBKCOLFOCBD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			private GINHMPCLHHC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private TaskAwaiter<GMPFCPBAOFJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0x7C8A270", Offset = "0x7C88E70", VA = "0x187C8A270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0x7C8A890", Offset = "0x7C89490", VA = "0x187C8A890", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public FFAGHJPHLLH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public DKFKCMHBGHA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public DJCNGDIOJNF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public GMPFCPBAOFJ originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public GBKCOLFOCBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x7C78E00", Offset = "0x7C77A00", VA = "0x187C78E00")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<GMPFCPBAOFJ> LKPDKONKADN(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct FJIFNHPKKJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public AsyncTaskMethodBuilder<GMPFCPBAOFJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public FFAGHJPHLLH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public DKFKCMHBGHA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public DJCNGDIOJNF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter<GMPFCPBAOFJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x7C78870", Offset = "0x7C77470", VA = "0x187C78870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x7C78D90", Offset = "0x7C77990", VA = "0x187C78D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct GDDNGJBKMGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public FFAGHJPHLLH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private GMPFCPBAOFJ <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private IEnumerator<GMPFCPBAOFJ> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private TaskAwaiter<GMPFCPBAOFJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x7C79200", Offset = "0x7C77E00", VA = "0x187C79200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x7C79750", Offset = "0x7C78350", VA = "0x187C79750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct MABALDNGMCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x7C840B0", Offset = "0x7C82CB0", VA = "0x187C840B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x7C843A0", Offset = "0x7C82FA0", VA = "0x187C843A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct BKHCBPPBLPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x7C733E0", Offset = "0x7C71FE0", VA = "0x187C733E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x7C73600", Offset = "0x7C72200", VA = "0x187C73600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private sealed class KILAOMJGMJE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000149")]
		private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			public AsyncTaskMethodBuilder<GMPFCPBAOFJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			public KILAOMJGMJE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			public DFAGOCGJMME data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			public FFAGHJPHLLH progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400055B")]
			public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400055C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			private TaskAwaiter<GMPFCPBAOFJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			private TaskAwaiter<IADFBMFBFHC> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x7C8A900", Offset = "0x7C89500", VA = "0x187C8A900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x7C8B3A0", Offset = "0x7C89FA0", VA = "0x187C8B3A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public FEEOKHNNLEM mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public KILAOMJGMJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x7C800A0", Offset = "0x7C7ECA0", VA = "0x187C800A0")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<GMPFCPBAOFJ> OMCEDJADECH(DFAGOCGJMME data, DJCNGDIOJNF _, FFAGHJPHLLH progressTracker, FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct HICHFMLGDNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public DFAGOCGJMME phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public FFAGHJPHLLH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private KILAOMJGMJE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private DJCNGDIOJNF <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private TaskAwaiter<GMPFCPBAOFJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x7C7AF10", Offset = "0x7C79B10", VA = "0x187C7AF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x7C7BDD0", Offset = "0x7C7A9D0", VA = "0x187C7BDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct KAKLEMDEABH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x7C7FC40", Offset = "0x7C7E840", VA = "0x187C7FC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x7C80040", Offset = "0x7C7EC40", VA = "0x187C80040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct DDHGLFHJDLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public AsyncTaskMethodBuilder<GMPFCPBAOFJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public JMOOMBIGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public FFAGHJPHLLH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private TaskAwaiter<GMPFCPBAOFJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x7C76060", Offset = "0x7C74C60", VA = "0x187C76060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x7C76680", Offset = "0x7C75280", VA = "0x187C76680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private readonly ABCMEDAMFNA FKEKPLJNHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	private readonly ABCMEDAMFNA PJFGFBKEINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private readonly CGFOHGKICKB MEHMKCADMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private readonly MCAPBLLCCGE IPBHCHINOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private readonly KOPCFCOHBON PLNJNLOBOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private ProfilerCounterValue<int> FJKGDLPCHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	private readonly DMMAGACMAGB OLPAIFGOLDG;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private CCOEFMMBAGF IBAOJHOHOJC
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7C68CE0", Offset = "0x7C678E0", VA = "0x187C68CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event KHHDCNPGNJA HOGNFFHBGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x7C693A0", Offset = "0x7C67FA0", VA = "0x187C693A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x7C68F40", Offset = "0x7C67B40", VA = "0x187C68F40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x7C69560", Offset = "0x7C68160", VA = "0x187C69560")]
	public JMOOMBIGPHA(GDLHPPGEFNI AHAIDLILHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x7C68260", Offset = "0x7C66E60", VA = "0x187C68260")]
	[AsyncStateMachine(typeof(LPCLLIMGPAD))]
	public Task GGHFDFMEBGD(PDKHDMNJGNI AGFMCIMDGME, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x7C68420", Offset = "0x7C67020", VA = "0x187C68420")]
	[AsyncStateMachine(typeof(KGPMFMLBJAJ))]
	private Task<DKFJDNOJOIC> IAFJBMFLNAK(PDKHDMNJGNI AGFMCIMDGME, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x7C68D10", Offset = "0x7C67910", VA = "0x187C68D10")]
	[AsyncStateMachine(typeof(ENDLICIOHKG))]
	private Task ODCJPNGHMEM(PDKHDMNJGNI AGFMCIMDGME, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x7C67E70", Offset = "0x7C66A70", VA = "0x187C67E70")]
	[AsyncStateMachine(typeof(BHLLPEMIEPL))]
	private Task EIFJFEBJCJE(PDKHDMNJGNI AGFMCIMDGME, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken IDNDAJLLIMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x7C67C30", Offset = "0x7C66830", VA = "0x187C67C30")]
	[AsyncStateMachine(typeof(DJHDMMIOOBD))]
	private Task DNKLGNNDJMM(DFAGOCGJMME LFBFADBDDKH, FFAGHJPHLLH CGLAKHDEPFB, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken DLEDBLHEBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x7C689E0", Offset = "0x7C675E0", VA = "0x187C689E0")]
	[AsyncStateMachine(typeof(EDEANPALJMJ))]
	private Task LPAKGPPOFKG(FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x7C68FA0", Offset = "0x7C67BA0", VA = "0x187C68FA0")]
	[AsyncStateMachine(typeof(CHGOIDCOPNM))]
	private Task OLOPJEPABGN(DFAGOCGJMME LLDJIJICLJF, FFAGHJPHLLH LMLEMKCJJPO, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x7C690F0", Offset = "0x7C67CF0", VA = "0x187C690F0")]
	[AsyncStateMachine(typeof(HFJNMCIOIJK))]
	private Task<GMPFCPBAOFJ> OOPNPMJJHKF(DFAGOCGJMME LLDJIJICLJF, DJCNGDIOJNF KPMDAHBLNIB, FFAGHJPHLLH LMLEMKCJJPO, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x7C68AF0", Offset = "0x7C676F0", VA = "0x187C68AF0")]
	[AsyncStateMachine(typeof(ILNGIMLEAEP))]
	private Task<GMPFCPBAOFJ> MINAOIFGBAC(DFAGOCGJMME LLDJIJICLJF, DJCNGDIOJNF KPMDAHBLNIB, FFAGHJPHLLH LMLEMKCJJPO, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x7C686D0", Offset = "0x7C672D0", VA = "0x187C686D0")]
	[AsyncStateMachine(typeof(HMEKMMDOHLM))]
	private Task<GMPFCPBAOFJ> IOPBBOBELKE(GMPFCPBAOFJ GHNKOJFJEJD, DFAGOCGJMME HJMFAGHEMMB, FFAGHJPHLLH LMLEMKCJJPO, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ, bool OJDOBCOPMFE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x7C68E50", Offset = "0x7C67A50", VA = "0x187C68E50")]
	private bool OECEBDJKGGI(DFAGOCGJMME LFBFADBDDKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x7C67AA0", Offset = "0x7C666A0", VA = "0x187C67AA0")]
	[AsyncStateMachine(typeof(FJIFNHPKKJE))]
	protected Task<GMPFCPBAOFJ> DHGHIGACFGD(DFAGOCGJMME LLDJIJICLJF, DJCNGDIOJNF KPMDAHBLNIB, FFAGHJPHLLH LMLEMKCJJPO, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ, DKFKCMHBGHA GDKJMNFNNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x7C680F0", Offset = "0x7C66CF0", VA = "0x187C680F0")]
	[AsyncStateMachine(typeof(GDDNGJBKMGJ))]
	private Task FECPEABNGFD(DFAGOCGJMME LLDJIJICLJF, FFAGHJPHLLH LMLEMKCJJPO, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x7C68850", Offset = "0x7C67450", VA = "0x187C68850")]
	private void IPPJHOGFBGD(GMPFCPBAOFJ JHPLKOLEFDA, FFAGHJPHLLH LMLEMKCJJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x7C68F60", Offset = "0x7C67B60", VA = "0x187C68F60")]
	private void OLLINKPNMOO(GMPFCPBAOFJ IABECPFGOPF, [Out] GMPFCPBAOFJ COAIOCEINPM, [Out] GMPFCPBAOFJ CNDDBIHJFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x7C69520", Offset = "0x7C68120", VA = "0x187C69520")]
	private Task<FIFOFPOFLHC> PLDHILOMLGP(PDKHDMNJGNI AGFMCIMDGME, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x7C683B0", Offset = "0x7C66FB0", VA = "0x187C683B0")]
	private Task<DFAGOCGJMME> GPCPDLNBGLE(FIFOFPOFLHC LLDJIJICLJF, OEKPEONBLNM.ADAAGALHODG BPJMGGENCKI, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x7C69250", Offset = "0x7C67E50", VA = "0x187C69250")]
	[AsyncStateMachine(typeof(MABALDNGMCF))]
	private Task OPMBCEMHAGM(DFAGOCGJMME LLDJIJICLJF, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ, bool PPPDCJLEEMC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x7C67D80", Offset = "0x7C66980", VA = "0x187C67D80")]
	[AsyncStateMachine(typeof(BKHCBPPBLPP))]
	private Task EDBPEPBPKCI(DFAGOCGJMME LLDJIJICLJF, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x7C683F0", Offset = "0x7C66FF0", VA = "0x187C683F0")]
	private Task HJNHKMFHKDP(DFAGOCGJMME LLDJIJICLJF, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x7C68240", Offset = "0x7C66E40", VA = "0x187C68240")]
	private Task FJJJJLNHONG(DFAGOCGJMME LLDJIJICLJF, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x7C688A0", Offset = "0x7C674A0", VA = "0x187C688A0")]
	private Task JDLPFLGMIMK(DFAGOCGJMME LLDJIJICLJF, DJCNGDIOJNF KPMDAHBLNIB, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x7C688C0", Offset = "0x7C674C0", VA = "0x187C688C0")]
	private Task KMCNEPFJFFJ(DFAGOCGJMME LLDJIJICLJF, DJCNGDIOJNF KPMDAHBLNIB, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x7C67A70", Offset = "0x7C66670", VA = "0x187C67A70")]
	private static Task BMAKPMNCEAP(CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x7C67A80", Offset = "0x7C66680", VA = "0x187C67A80")]
	private Task CEKGJKLNING(DFAGOCGJMME LLDJIJICLJF, DJCNGDIOJNF KPMDAHBLNIB, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x7C67A50", Offset = "0x7C66650", VA = "0x187C67A50")]
	private Task ADOFCNIDNDP(DFAGOCGJMME LLDJIJICLJF, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x7C688E0", Offset = "0x7C674E0", VA = "0x187C688E0")]
	private void KOLHIGCKIOI(PDKHDMNJGNI AGFMCIMDGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x7C68930", Offset = "0x7C67530", VA = "0x187C68930")]
	public void LODKHEBOHJC(long JKENKIDPAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
	private static void CILGJNFLDND(BCPENJPKFJJ MDPGCFDKEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x7C68580", Offset = "0x7C67180", VA = "0x187C68580")]
	[AsyncStateMachine(typeof(HICHFMLGDNE))]
	private Task IFNCFGCBJNO(DFAGOCGJMME LFBFADBDDKH, FFAGHJPHLLH CGLAKHDEPFB, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken DLEDBLHEBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x7C67FB0", Offset = "0x7C66BB0", VA = "0x187C67FB0")]
	[AsyncStateMachine(typeof(KAKLEMDEABH))]
	private Task EJEAFGJAIOC(DFAGOCGJMME LLDJIJICLJF, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x7C68C70", Offset = "0x7C67870", VA = "0x187C68C70")]
	private static LKGOIGMMNHP NFLHMONOGDE(DFAGOCGJMME HJMFAGHEMMB)
	{
		return default(LKGOIGMMNHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x7C693C0", Offset = "0x7C67FC0", VA = "0x187C693C0")]
	[AsyncStateMachine(typeof(DDHGLFHJDLM))]
	private Task<GMPFCPBAOFJ> PENGBEAIHNO(DFAGOCGJMME LLDJIJICLJF, DJCNGDIOJNF KPMDAHBLNIB, FFAGHJPHLLH LMLEMKCJJPO, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
	private void DEPGBMOOBIP(GMPFCPBAOFJ PJHOCNHKMFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
internal struct OMNOOOKKMJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400057C")]
	private CCOEFMMBAGF MGMNCIIJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400057D")]
	private DFAGOCGJMME LLDJIJICLJF;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private FELCLIHLJOK GNGHLGLBLNG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C87370", Offset = "0x7C85F70", VA = "0x187C87370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x7C87290", Offset = "0x7C85E90", VA = "0x187C87290")]
	public static Task BDNCCGGPJGH(CCOEFMMBAGF MGMNCIIJMMO, DFAGOCGJMME LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C87080", Offset = "0x7C85C80", VA = "0x187C87080")]
	private void BDNCCGGPJGH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct IJDCFFGAAKJ
{
	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C7CEC0", Offset = "0x7C7BAC0", VA = "0x187C7CEC0")]
	public static Task BDNCCGGPJGH(CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct KPNHPBKELJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct PCIBDFKMJMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public GDLHPPGEFNI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C880F0", Offset = "0x7C86CF0", VA = "0x187C880F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C88620", Offset = "0x7C87220", VA = "0x187C88620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C81450", Offset = "0x7C80050", VA = "0x187C81450")]
	[AsyncStateMachine(typeof(PCIBDFKMJMI))]
	public static Task BDNCCGGPJGH(GDLHPPGEFNI AHAIDLILHKJ, DFAGOCGJMME LLDJIJICLJF, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct MPIKFOOAEOF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct OOGLEJECHOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public GDLHPPGEFNI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public DJCNGDIOJNF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private CCOEFMMBAGF <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private FELCLIHLJOK <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private GMPFCPBAOFJ <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private GINHMPCLHHC <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private List<(PersistenceView, IJKLPCMEAKO)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private IJKLPCMEAKO <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C873C0", Offset = "0x7C85FC0", VA = "0x187C873C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C88090", Offset = "0x7C86C90", VA = "0x187C88090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C86660", Offset = "0x7C85260", VA = "0x187C86660")]
	[AsyncStateMachine(typeof(OOGLEJECHOB))]
	public static Task BDNCCGGPJGH(GDLHPPGEFNI AHAIDLILHKJ, DFAGOCGJMME LLDJIJICLJF, DJCNGDIOJNF KPMDAHBLNIB, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C867B0", Offset = "0x7C853B0", VA = "0x187C867B0")]
	private static void IDHCDODPLMH(PersistenceView DPCLJPBHKAL, IJKLPCMEAKO AIINMDJLKBF, DFAGOCGJMME LLDJIJICLJF, GMPFCPBAOFJ GHNKOJFJEJD, bool INOGLDHCFID)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000154")]
internal struct HBHBMMEKHNH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct BKFJDILPILP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public CCOEFMMBAGF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private GINHMPCLHHC <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C72D60", Offset = "0x7C71960", VA = "0x187C72D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C73380", Offset = "0x7C71F80", VA = "0x187C73380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A2F0", Offset = "0x7C78EF0", VA = "0x187C7A2F0")]
	[AsyncStateMachine(typeof(BKFJDILPILP))]
	public static Task BDNCCGGPJGH(CCOEFMMBAGF MGMNCIIJMMO, DFAGOCGJMME LLDJIJICLJF, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct CCHOEPFGKPC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct HODHFHNGPAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public CCOEFMMBAGF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public GDLHPPGEFNI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C7C0F0", Offset = "0x7C7ACF0", VA = "0x187C7C0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C7C300", Offset = "0x7C7AF00", VA = "0x187C7C300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class BPGOEOLEHOP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000159")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005B1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005B2")]
			public FNEANCIAOBI<string>.IDKBCAKILKJ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B3")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005B4")]
			public BPGOEOLEHOP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x7C8B730", Offset = "0x7C8A330", VA = "0x187C8B730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x7C8BAC0", Offset = "0x7C8A6C0", VA = "0x187C8BAC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public BPGOEOLEHOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C737A0", Offset = "0x7C723A0", VA = "0x187C737A0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task GGOAAMEPGMD(FNEANCIAOBI<string>.IDKBCAKILKJ timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct PENDMJOIHLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public CCHOEPFGKPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private GINHMPCLHHC <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private TaskAwaiter<DKFJDNOJOIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C88C10", Offset = "0x7C87810", VA = "0x187C88C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C89810", Offset = "0x7C88410", VA = "0x187C89810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private sealed class HDBGICKKCEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public LFHJKKOJGDF version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public HDBGICKKCEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C7A410", Offset = "0x7C79010", VA = "0x187C7A410")]
		internal object LEIFHCOCIDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x7C7A4F0", Offset = "0x7C790F0", VA = "0x187C7A4F0")]
		internal object LKKDAADKLCK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	private CCOEFMMBAGF MGMNCIIJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	private DFAGOCGJMME LLDJIJICLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005A3")]
	private GDLHPPGEFNI AHAIDLILHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005A4")]
	private bool PPPDCJLEEMC;

	[Cpp2IlInjected.Token(Token = "0x40005A5")]
	private static readonly ByteString FELIFLCBPHC;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	private FELCLIHLJOK GNGHLGLBLNG
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C749E0", Offset = "0x7C735E0", VA = "0x187C749E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private ONBJJNNFOFI EKBCFEONFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C73EB0", Offset = "0x7C72AB0", VA = "0x187C73EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x7C73F90", Offset = "0x7C72B90", VA = "0x187C73F90")]
	[AsyncStateMachine(typeof(HODHFHNGPAG))]
	public static Task BDNCCGGPJGH(CCOEFMMBAGF MGMNCIIJMMO, DFAGOCGJMME LLDJIJICLJF, GDLHPPGEFNI AHAIDLILHKJ, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ, bool PPPDCJLEEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C740E0", Offset = "0x7C72CE0", VA = "0x187C740E0")]
	[AsyncStateMachine(typeof(PENDMJOIHLC))]
	private Task BDNCCGGPJGH(FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x7C74210", Offset = "0x7C72E10", VA = "0x187C74210")]
	private void CBGBOIPDFNP([NotNull] OFOCKDHGIHJ HMPKKHEGEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x7C73F50", Offset = "0x7C72B50", VA = "0x187C73F50")]
	private bool AJNPMOABBAM(LFHJKKOJGDF HBIBCNEICNM, OFOCKDHGIHJ HMPKKHEGEKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct LDPGIACJPGL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct KMOOGAHEHHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public AsyncTaskMethodBuilder<DFAGOCGJMME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public LDPGIACJPGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public OEKPEONBLNM.ADAAGALHODG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private TaskAwaiter<(PNJEPLMEKHI<EBJBDIAEPAJ, KLJHHNJNNDG>, PNJEPLMEKHI<IReadOnlyList<EBJBDIAEPAJ>, KLJHHNJNNDG>, PNJEPLMEKHI<HAKOKJPNEOL<OFOCKDHGIHJ>, KLJHHNJNNDG>, PNJEPLMEKHI<HAKOKJPNEOL<PGMIGGEMMKL>, KLJHHNJNNDG>, PNJEPLMEKHI<HAKOKJPNEOL<KPGCKGMEOEP>, KLJHHNJNNDG>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C80280", Offset = "0x7C7EE80", VA = "0x187C80280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C80DC0", Offset = "0x7C7F9C0", VA = "0x187C80DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct LDCMGIIJJOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<EBJBDIAEPAJ, KLJHHNJNNDG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public LDPGIACJPGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public OEKPEONBLNM.ADAAGALHODG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private TaskAwaiter<PNJEPLMEKHI<EBJBDIAEPAJ, KLJHHNJNNDG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C81590", Offset = "0x7C80190", VA = "0x187C81590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C81BA0", Offset = "0x7C807A0", VA = "0x187C81BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct HHPNHOLIMNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<IReadOnlyList<EBJBDIAEPAJ>, KLJHHNJNNDG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public LDPGIACJPGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public IReadOnlyList<DIKJEBDFCIA> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private TaskAwaiter<PNJEPLMEKHI<IReadOnlyList<EBJBDIAEPAJ>, KLJHHNJNNDG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C7A8F0", Offset = "0x7C794F0", VA = "0x187C7A8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x7C7AEA0", Offset = "0x7C79AA0", VA = "0x187C7AEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private DKODLFBAMNJ<HEJHHLFMEKL, PGMIGGEMMKL> IPNNGBCOAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private DKODLFBAMNJ<HEJHHLFMEKL, OFOCKDHGIHJ> DKGIBEEJDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private DKODLFBAMNJ<long, KPGCKGMEOEP> AALBJMHIBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private LDHNIHMDDKI CEHKFANCPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private BCPENJPKFJJ MDPGCFDKEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	private FFBHBDHOGKB ICHBBGHLOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	private string ECHHHHOHFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	private IReadOnlyList<DIKJEBDFCIA> MKPGCELACMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private HEJHHLFMEKL MAGHCEFJIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private HEJHHLFMEKL LLKJICLKDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private long JKENKIDPAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN;

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x7C81F50", Offset = "0x7C80B50", VA = "0x187C81F50")]
	public static Task<DFAGOCGJMME> DPONFIJNDMK(CCOEFMMBAGF MGMNCIIJMMO, [In] FIFOFPOFLHC LLDJIJICLJF, OEKPEONBLNM.ADAAGALHODG BPJMGGENCKI, FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x7C81C10", Offset = "0x7C80810", VA = "0x187C81C10")]
	[AsyncStateMachine(typeof(KMOOGAHEHHO))]
	private Task<DFAGOCGJMME> BDNCCGGPJGH(OEKPEONBLNM.ADAAGALHODG BPJMGGENCKI, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x7C81D80", Offset = "0x7C80980", VA = "0x187C81D80")]
	[AsyncStateMachine(typeof(LDCMGIIJJOC))]
	private Task<PNJEPLMEKHI<EBJBDIAEPAJ, KLJHHNJNNDG>> BHDMJDOAPLK(string ECHHHHOHFJN, long JKENKIDPAII, long? EPGJLNEAJPA, long? HPCDEBDHAFJ, OEKPEONBLNM.ADAAGALHODG BPJMGGENCKI, FNEANCIAOBI<string>.IDKBCAKILKJ GOAJALHPIPP, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C82330", Offset = "0x7C80F30", VA = "0x187C82330")]
	[AsyncStateMachine(typeof(HHPNHOLIMNF))]
	private Task<PNJEPLMEKHI<IReadOnlyList<EBJBDIAEPAJ>, KLJHHNJNNDG>> FMMPBJGGFCK(IReadOnlyList<DIKJEBDFCIA> MKPGCELACMI, FNEANCIAOBI<string>.IDKBCAKILKJ GOAJALHPIPP, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct LGEGGFDPGKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct LLIKMMOGKCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public AsyncTaskMethodBuilder<FIFOFPOFLHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public LGEGGFDPGKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter<FIFOFPOFLHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C832F0", Offset = "0x7C81EF0", VA = "0x187C832F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C83700", Offset = "0x7C82300", VA = "0x187C83700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct JAAGLCMCKOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public AsyncTaskMethodBuilder<FIFOFPOFLHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public LGEGGFDPGKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private TaskAwaiter<FIFOFPOFLHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C7E8F0", Offset = "0x7C7D4F0", VA = "0x187C7E8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C7ED20", Offset = "0x7C7D920", VA = "0x187C7ED20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class LPBNBGLEHMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public LPBNBGLEHMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xCF12D0", Offset = "0xCEFED0", VA = "0x180CF12D0")]
		internal bool MACHAJGAHBA(FFBHBDHOGKB sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct MMOJFDCIJFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public AsyncTaskMethodBuilder<FIFOFPOFLHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public HEJHHLFMEKL superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public FELCLIHLJOK callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private LPBNBGLEHMH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public CHEPJELAGEF roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private BCPENJPKFJJ <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private FFBHBDHOGKB <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private IReadOnlyList<DIKJEBDFCIA> <unitySubAssets>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private HEJHHLFMEKL <superRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private HEJHHLFMEKL <subRoomData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private TaskAwaiter<BCPENJPKFJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private TaskAwaiter<NBCCHAPKOEK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private TaskAwaiter<NAKFAFENAFD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C85390", Offset = "0x7C83F90", VA = "0x187C85390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C865F0", Offset = "0x7C851F0", VA = "0x187C865F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private FELCLIHLJOK JOHAHHCBBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private CGFOHGKICKB MEHMKCADMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	private CHEPJELAGEF GLAGPEJLAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	private FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private long EPGJLNEAJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	private long DMLJPKIDBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private long BHNIPLLDJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private string MDHENNAADKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private HEJHHLFMEKL IKJFPCEPAJJ;

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C82610", Offset = "0x7C81210", VA = "0x187C82610")]
	public static Task<FIFOFPOFLHC> DPONFIJNDMK(CCOEFMMBAGF MGMNCIIJMMO, PDKHDMNJGNI AGFMCIMDGME, FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x7C824C0", Offset = "0x7C810C0", VA = "0x187C824C0")]
	[AsyncStateMachine(typeof(LLIKMMOGKCN))]
	private Task<FIFOFPOFLHC> BDNCCGGPJGH(CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x7C82870", Offset = "0x7C81470", VA = "0x187C82870")]
	[AsyncStateMachine(typeof(JAAGLCMCKOG))]
	private Task<FIFOFPOFLHC> PLDHILOMLGP(FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x7C829D0", Offset = "0x7C815D0", VA = "0x187C829D0")]
	[AsyncStateMachine(typeof(MMOJFDCIJFJ))]
	private static Task<FIFOFPOFLHC> PLDHILOMLGP(FELCLIHLJOK JOHAHHCBBCJ, CHEPJELAGEF GLAGPEJLAML, long EPGJLNEAJPA, long DMLJPKIDBPD, long BHNIPLLDJPL, string MDHENNAADKE, HEJHHLFMEKL IKJFPCEPAJJ, CancellationToken NAOIMKEDKEJ, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x7C82840", Offset = "0x7C81440", VA = "0x187C82840")]
	private void GMEABHCEEJO(BCPENJPKFJJ MDPGCFDKEND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct DKFJDMDAHJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct CAGJDOGFFHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public DKFJDMDAHJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C738C0", Offset = "0x7C724C0", VA = "0x187C738C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C73E50", Offset = "0x7C72A50", VA = "0x187C73E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	private FELCLIHLJOK JOHAHHCBBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400061D")]
	private DFAGOCGJMME LLDJIJICLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400061E")]
	private FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400061F")]
	private float DHAACLKAGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000620")]
	private float GLNLLFIKIFH;

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x7C76F40", Offset = "0x7C75B40", VA = "0x187C76F40")]
	public static Task ACEEILGFBCC(CCOEFMMBAGF MGMNCIIJMMO, DFAGOCGJMME LLDJIJICLJF, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x7C77210", Offset = "0x7C75E10", VA = "0x187C77210")]
	[AsyncStateMachine(typeof(CAGJDOGFFHH))]
	public Task BDNCCGGPJGH(CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x7C770E0", Offset = "0x7C75CE0", VA = "0x187C770E0")]
	private static void BDDJJOGNKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x7C77410", Offset = "0x7C76010", VA = "0x187C77410")]
	private void KENHBCLGMNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x7C77330", Offset = "0x7C75F30", VA = "0x187C77330")]
	private static float GNKMGOIMCJP(FELCLIHLJOK JOHAHHCBBCJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x7C773F0", Offset = "0x7C75FF0", VA = "0x187C773F0")]
	private static float IJOLCIOBGBH()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct JOFONFLPEEO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct EHEEHJNKIBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public GDLHPPGEFNI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private AIKLBIMPFFC <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private CCOEFMMBAGF <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		private EJEMHHBEBGL.CCJHOIKMFBJ <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private TaskAwaiter<DKFJDNOJOIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C77570", Offset = "0x7C76170", VA = "0x187C77570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C77D90", Offset = "0x7C76990", VA = "0x187C77D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct BDALIHKIDEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x7C729D0", Offset = "0x7C715D0", VA = "0x187C729D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x7C72D00", Offset = "0x7C71900", VA = "0x187C72D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C7F9D0", Offset = "0x7C7E5D0", VA = "0x187C7F9D0")]
	[AsyncStateMachine(typeof(EHEEHJNKIBK))]
	public static Task BDNCCGGPJGH(GDLHPPGEFNI AHAIDLILHKJ, DFAGOCGJMME LLDJIJICLJF, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C7FBD0", Offset = "0x7C7E7D0", VA = "0x187C7FBD0")]
	private static Task<DKFJDNOJOIC> NHNGBKECDFI(GDLHPPGEFNI AHAIDLILHKJ, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C7FB10", Offset = "0x7C7E710", VA = "0x187C7FB10")]
	[AsyncStateMachine(typeof(BDALIHKIDEP))]
	private static Task GMNBGMDIMGN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal struct KOCMMEPEGAK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct DGPOJGKCILH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public KOCMMEPEGAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C766F0", Offset = "0x7C752F0", VA = "0x187C766F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C76DA0", Offset = "0x7C759A0", VA = "0x187C76DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class KKMCPBMKCKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public KKMCPBMKCKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x7C80200", Offset = "0x7C7EE00", VA = "0x187C80200")]
		internal object BAICBMPOKNE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct DCCNNGGCDPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public KOCMMEPEGAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C75B80", Offset = "0x7C74780", VA = "0x187C75B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C76000", Offset = "0x7C74C00", VA = "0x187C76000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	private bool JNCGNPMPCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400063C")]
	private FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400063D")]
	private CCOEFMMBAGF MGMNCIIJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400063E")]
	private CancellationToken NAOIMKEDKEJ;

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C81050", Offset = "0x7C7FC50", VA = "0x187C81050")]
	public static Task NDEDMMLELAA(CCOEFMMBAGF MGMNCIIJMMO, bool JNCGNPMPCKL, FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, CancellationToken PKGBAOCOHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C80F60", Offset = "0x7C7FB60", VA = "0x187C80F60")]
	[AsyncStateMachine(typeof(DGPOJGKCILH))]
	private Task BDNCCGGPJGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C80E30", Offset = "0x7C7FA30", VA = "0x187C80E30")]
	[AsyncStateMachine(typeof(DCCNNGGCDPJ))]
	private Task BBNJPJPBCOB(bool BJEPJNHFKNK, string JMDBEOGKEMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50")]
	private bool GFBOLLPMLHG(bool JNCGNPMPCKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
internal struct IDMKGLGIKJF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct CCPOKIGFKII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public IDMKGLGIKJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C74AC0", Offset = "0x7C736C0", VA = "0x187C74AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C75030", Offset = "0x7C73C30", VA = "0x187C75030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class PKMPILAEHBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public PKMPILAEHBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x7C89870", Offset = "0x7C88470", VA = "0x187C89870")]
		internal object BAICBMPOKNE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct PMLGNHHGPLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public IDMKGLGIKJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x7C898C0", Offset = "0x7C884C0", VA = "0x187C898C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x7C89D40", Offset = "0x7C88940", VA = "0x187C89D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064E")]
	private CFOHLAAPFAG AOMAKJNPMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private CCOEFMMBAGF MGMNCIIJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	private bool FFFHKIBHDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	private DFAGOCGJMME LLDJIJICLJF;

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x7C7CDA0", Offset = "0x7C7B9A0", VA = "0x187C7CDA0")]
	public static Task<Scene> DCFENNNKHCH(CCOEFMMBAGF MGMNCIIJMMO, CFOHLAAPFAG EEPANDEDKIB, FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x7C7CC80", Offset = "0x7C7B880", VA = "0x187C7CC80")]
	[AsyncStateMachine(typeof(CCPOKIGFKII))]
	private Task<Scene> BDNCCGGPJGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x7C7CE20", Offset = "0x7C7BA20", VA = "0x187C7CE20")]
	private bool IKPEIJMOHMB(DFAGOCGJMME LLDJIJICLJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x7C7CE50", Offset = "0x7C7BA50", VA = "0x187C7CE50")]
	private void ILGJOELFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x7C7CB30", Offset = "0x7C7B730", VA = "0x187C7CB30")]
	[AsyncStateMachine(typeof(PMLGNHHGPLG))]
	private Task<Scene> BBNJPJPBCOB(string JMDBEOGKEMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal struct KOPCFCOHBON
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct GILGJEEGPDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public AsyncTaskMethodBuilder<GMPFCPBAOFJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public KOPCFCOHBON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public GMPFCPBAOFJ nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public DFAGOCGJMME deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private TaskAwaiter<GMPFCPBAOFJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x7C797B0", Offset = "0x7C783B0", VA = "0x187C797B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x7C7A280", Offset = "0x7C78E80", VA = "0x187C7A280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct HDLGJCMABMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public AsyncTaskMethodBuilder<GMPFCPBAOFJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public KOPCFCOHBON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public GMPFCPBAOFJ state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private TaskAwaiter<DKFJDNOJOIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x7C7A5A0", Offset = "0x7C791A0", VA = "0x187C7A5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x7C7A880", Offset = "0x7C79480", VA = "0x187C7A880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	private readonly GDLHPPGEFNI AHAIDLILHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	private readonly CGFOHGKICKB MEHMKCADMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000661")]
	private readonly MCAPBLLCCGE IPBHCHINOPF;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	private AIKLBIMPFFC MMJDINNGFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x62B2590", Offset = "0x62B1190", VA = "0x1862B2590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x7C813F0", Offset = "0x7C7FFF0", VA = "0x187C813F0")]
	public KOPCFCOHBON(GDLHPPGEFNI AHAIDLILHKJ, CGFOHGKICKB MEHMKCADMMB, MCAPBLLCCGE IPBHCHINOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x7C81220", Offset = "0x7C7FE20", VA = "0x187C81220")]
	[AsyncStateMachine(typeof(GILGJEEGPDE))]
	public Task<GMPFCPBAOFJ> EGAIIMMJAMM(GMPFCPBAOFJ IAHHLLEEDLA, DFAGOCGJMME HJMFAGHEMMB, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ, bool OJDOBCOPMFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x7C810C0", Offset = "0x7C7FCC0", VA = "0x187C810C0")]
	[AsyncStateMachine(typeof(HDLGJCMABMO))]
	private Task<GMPFCPBAOFJ> BNDOENAHNME(FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, GMPFCPBAOFJ CMPEMMPBPLC, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x7C813C0", Offset = "0x7C7FFC0", VA = "0x187C813C0")]
	private bool JPMECLLLOEO(GMPFCPBAOFJ LOIFCIMKNDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x7C813A0", Offset = "0x7C7FFA0", VA = "0x187C813A0")]
	private void HBFNBGCENOB(string EJCEKPPDLHD)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000176")]
internal struct DKEFMPEKDJL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct INOMHDAGAMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public AIKLBIMPFFC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public DJCNGDIOJNF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private GINHMPCLHHC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private List<(PersistenceView, IJKLPCMEAKO)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private (PersistenceView, IJKLPCMEAKO) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x7C7E1D0", Offset = "0x7C7CDD0", VA = "0x187C7E1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x7C7E890", Offset = "0x7C7D490", VA = "0x187C7E890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x7C76E00", Offset = "0x7C75A00", VA = "0x187C76E00")]
	[AsyncStateMachine(typeof(INOMHDAGAMN))]
	public static Task BDNCCGGPJGH(AIKLBIMPFFC GAJFLBPNGCK, DFAGOCGJMME LLDJIJICLJF, DJCNGDIOJNF KPMDAHBLNIB, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000178")]
internal struct BMBHLOHOKEG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct LPJHAJKIJCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public AIKLBIMPFFC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public DJCNGDIOJNF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private LFHJKKOJGDF <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private GINHMPCLHHC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private List<(PersistenceView, IJKLPCMEAKO)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private IJKLPCMEAKO <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x7C83770", Offset = "0x7C82370", VA = "0x187C83770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x7C84050", Offset = "0x7C82C50", VA = "0x187C84050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x7C73660", Offset = "0x7C72260", VA = "0x187C73660")]
	[AsyncStateMachine(typeof(LPJHAJKIJCP))]
	public static Task BDNCCGGPJGH(AIKLBIMPFFC GAJFLBPNGCK, DFAGOCGJMME LLDJIJICLJF, DJCNGDIOJNF KPMDAHBLNIB, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
internal struct EJEMHHBEBGL
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	public struct CCJHOIKMFBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public List<IODINKAINFK> HHPMIOPKHEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public List<IJKLPCMEAKO> GGHLDBCKKBJ;

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x9DD890", Offset = "0x9DC490", VA = "0x1809DD890")]
		public CCJHOIKMFBJ(List<IODINKAINFK> HHPMIOPKHEF, List<IJKLPCMEAKO> GGHLDBCKKBJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class MLEPPFJCIDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public IEnumerable<IODINKAINFK> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public MLEPPFJCIDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x7C85310", Offset = "0x7C83F10", VA = "0x187C85310")]
		internal object BDJADANIGJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068E")]
	private CCOEFMMBAGF MGMNCIIJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	private DFAGOCGJMME LLDJIJICLJF;

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private FELCLIHLJOK GNGHLGLBLNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x7C780A0", Offset = "0x7C76CA0", VA = "0x187C780A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x7C77DF0", Offset = "0x7C769F0", VA = "0x187C77DF0")]
	public static CCJHOIKMFBJ BDNCCGGPJGH(CCOEFMMBAGF MGMNCIIJMMO, DFAGOCGJMME LLDJIJICLJF)
	{
		return default(CCJHOIKMFBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x7C77E50", Offset = "0x7C76A50", VA = "0x187C77E50")]
	private CCJHOIKMFBJ BDNCCGGPJGH()
	{
		return default(CCJHOIKMFBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x7C780F0", Offset = "0x7C76CF0", VA = "0x187C780F0")]
	private CCJHOIKMFBJ MAJFDJBDDDB(OFOCKDHGIHJ HMPKKHEGEKK, LFHJKKOJGDF ELCHENGMGIK)
	{
		return default(CCJHOIKMFBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x7C786A0", Offset = "0x7C772A0", VA = "0x187C786A0")]
	private bool NMEGBNHAAGH(IEnumerable<IODINKAINFK> HHPMIOPKHEF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal struct CPKEMDFDKLI
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class ILIINEAHOBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public EJEMHHBEBGL.CCJHOIKMFBJ instantiations;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public ILIINEAHOBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x7C7CFA0", Offset = "0x7C7BBA0", VA = "0x187C7CFA0")]
		internal object GGOAAMEPGMD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class JCELCGNBIAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public JCELCGNBIAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x7C7ED90", Offset = "0x7C7D990", VA = "0x187C7ED90")]
		internal object JFKFPNBDAGF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x7C750A0", Offset = "0x7C73CA0", VA = "0x187C750A0")]
	public static void BDNCCGGPJGH(AIKLBIMPFFC GAJFLBPNGCK, DFAGOCGJMME LLDJIJICLJF, EJEMHHBEBGL.CCJHOIKMFBJ ODKHLABAMMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class MCAPBLLCCGE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct HPDPDIHBCGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public MCAPBLLCCGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public GMPFCPBAOFJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public DFAGOCGJMME deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x7C7C360", Offset = "0x7C7AF60", VA = "0x187C7C360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x7C7CAD0", Offset = "0x7C7B6D0", VA = "0x187C7CAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class LIJCPMFIACJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000183")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006A4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006A5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006A6")]
			public LIJCPMFIACJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006A7")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006A8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x7C8B410", Offset = "0x7C8A010", VA = "0x187C8B410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x7C8B6D0", Offset = "0x7C8A2D0", VA = "0x187C8B6D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public MCAPBLLCCGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public LIJCPMFIACJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x7C82B70", Offset = "0x7C81770", VA = "0x187C82B70")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task KOLMPLINJNB(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private struct PCINNMIJJDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public MCAPBLLCCGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private LIJCPMFIACJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x7C88680", Offset = "0x7C87280", VA = "0x187C88680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x7C88BB0", Offset = "0x7C877B0", VA = "0x187C88BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct OKPOENOHAFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public MCAPBLLCCGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private Dictionary<Guid, List<LNGBFNJPCKM>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x7C86A10", Offset = "0x7C85610", VA = "0x187C86A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x7C87020", Offset = "0x7C85C20", VA = "0x187C87020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct AEGBCACFFGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public MCAPBLLCCGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private Dictionary<Guid, List<LNGBFNJPCKM>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x7C722D0", Offset = "0x7C70ED0", VA = "0x187C722D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x7C72970", Offset = "0x7C71570", VA = "0x187C72970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class GDBHKPLLHDC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			public LNGBFNJPCKM handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			public GDBHKPLLHDC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006CC")]
			private GINHMPCLHHC <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006CD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x7C89DB0", Offset = "0x7C889B0", VA = "0x187C89DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x7C8A210", Offset = "0x7C88E10", VA = "0x187C8A210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public IKLHEBFBMKL runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public List<LNGBFNJPCKM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public GDBHKPLLHDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x7C79010", Offset = "0x7C77C10", VA = "0x187C79010")]
		internal object DNDHJNHNIND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x7C79100", Offset = "0x7C77D00", VA = "0x187C79100")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task KJFKLOKKAKG(LNGBFNJPCKM handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F20", Offset = "0x7C77B20", VA = "0x187C78F20")]
		internal object BACNHDOBBIK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct CPPDJJDMOKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public IKLHEBFBMKL runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public List<LNGBFNJPCKM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private GDBHKPLLHDC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x7C75650", Offset = "0x7C74250", VA = "0x187C75650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x7C75B20", Offset = "0x7C74720", VA = "0x187C75B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private struct JEPACGLOCBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public MCAPBLLCCGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x7C7EE20", Offset = "0x7C7DA20", VA = "0x187C7EE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F3E0", Offset = "0x7C7DFE0", VA = "0x187C7F3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class JMCOKNBGEEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public JMCOKNBGEEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F960", Offset = "0x7C7E560", VA = "0x187C7F960")]
		internal object LFCOIMHLHGG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private struct JFHFBLDFNAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public MCAPBLLCCGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public DFAGOCGJMME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F440", Offset = "0x7C7E040", VA = "0x187C7F440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F900", Offset = "0x7C7E500", VA = "0x187C7F900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private sealed class OHLFBKFJLFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public OHLFBKFJLFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x7C869A0", Offset = "0x7C855A0", VA = "0x187C869A0")]
		internal object MINCMFNCPHD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private struct LKPFOBGOHDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public MCAPBLLCCGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private GINHMPCLHHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private TaskAwaiter<DKFJDNOJOIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x7C82C60", Offset = "0x7C81860", VA = "0x187C82C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x7C83290", Offset = "0x7C81E90", VA = "0x187C83290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class JHLGEOADCBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public JHLGEOADCBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x7C94510", Offset = "0x7C93110", VA = "0x187C94510")]
		internal object AAGPAJPNIDJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	private readonly GDLHPPGEFNI AHAIDLILHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private BJNCCHBBNCF IPBHCHINOPF;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private AIKLBIMPFFC MMJDINNGFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0xF00A70", Offset = "0xEFF670", VA = "0x180F00A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	public MCAPBLLCCGE(GDLHPPGEFNI AHAIDLILHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x7C84680", Offset = "0x7C83280", VA = "0x187C84680")]
	[AsyncStateMachine(typeof(HPDPDIHBCGN))]
	public Task BDNCCGGPJGH(GMPFCPBAOFJ GHNKOJFJEJD, DFAGOCGJMME HJMFAGHEMMB, FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x7C851D0", Offset = "0x7C83DD0", VA = "0x187C851D0")]
	[AsyncStateMachine(typeof(PCINNMIJJDN))]
	private Task PPBBJINAHMJ(DFAGOCGJMME LLDJIJICLJF, FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x7C84540", Offset = "0x7C83140", VA = "0x187C84540")]
	[AsyncStateMachine(typeof(OKPOENOHAFI))]
	private Task BCHLDOMOHGG(DFAGOCGJMME LLDJIJICLJF, FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x7C84A50", Offset = "0x7C83650", VA = "0x187C84A50")]
	[AsyncStateMachine(typeof(AEGBCACFFGI))]
	private Task HNCBAOOIOOH(DFAGOCGJMME LLDJIJICLJF, FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x7C84CF0", Offset = "0x7C838F0", VA = "0x187C84CF0")]
	[AsyncStateMachine(typeof(CPPDJJDMOKC))]
	private Task MAGMNCJEOFL(Guid GHBJIIPNEFH, List<LNGBFNJPCKM> CNJMKBKHIMF, IKLHEBFBMKL NDIJOLOJABC, DFAGOCGJMME LLDJIJICLJF, CancellationToken IKLHDHMJFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x7C85090", Offset = "0x7C83C90", VA = "0x187C85090")]
	[AsyncStateMachine(typeof(JEPACGLOCBE))]
	private Task PBAPDGADPMJ(DFAGOCGJMME LLDJIJICLJF, FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x7C84400", Offset = "0x7C83000", VA = "0x187C84400")]
	[AsyncStateMachine(typeof(JFHFBLDFNAD))]
	private Task AOBNOCBJLGE(Guid HMKBONPOBHO, DFAGOCGJMME LLDJIJICLJF, FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x7C84F50", Offset = "0x7C83B50", VA = "0x187C84F50")]
	[AsyncStateMachine(typeof(LKPFOBGOHDA))]
	private Task OIMHHOBGLHA(Guid HMKBONPOBHO, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x7C84E40", Offset = "0x7C83A40", VA = "0x187C84E40")]
	private void MLIBPMCJPDF(Guid HMKBONPOBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x7C847D0", Offset = "0x7C833D0", VA = "0x187C847D0")]
	private void DMLBHONMFNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x7C84B90", Offset = "0x7C83790", VA = "0x187C84B90")]
	public Guid LAFIJBMKOOC(GMPFCPBAOFJ JHPLKOLEFDA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x7C84880", Offset = "0x7C83480", VA = "0x187C84880")]
	[CompilerGenerated]
	private object ELEKFKLPLOJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
internal struct PKIEPBMNGHA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct BFBKDAFHIBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public PKIEPBMNGHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		private IEnumerator<LLFODJKOGKI> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x7C8CAF0", Offset = "0x7C8B6F0", VA = "0x187C8CAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D190", Offset = "0x7C8BD90", VA = "0x187C8D190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006F6")]
	private FELCLIHLJOK JOHAHHCBBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006F7")]
	private FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F8")]
	private CancellationToken NAOIMKEDKEJ;

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x7C971B0", Offset = "0x7C95DB0", VA = "0x187C971B0")]
	public static Task BFFKACNNNFC(FELCLIHLJOK JOHAHHCBBCJ, FNEANCIAOBI<string>.IDKBCAKILKJ IFHLDBMAMPN, CancellationToken PKGBAOCOHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x7C970C0", Offset = "0x7C95CC0", VA = "0x187C970C0")]
	[AsyncStateMachine(typeof(BFBKDAFHIBH))]
	private Task BDNCCGGPJGH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
public readonly struct GLNOINNEODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006FF")]
	public readonly bool GNBBPINIGMI;

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x271C880", Offset = "0x271B480", VA = "0x18271C880")]
	public GLNOINNEODG(bool NJDBPHCOILH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public readonly struct DDJCMNHOHEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000700")]
	public readonly OFOCKDHGIHJ? DALPBKNMNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000701")]
	public readonly IBODDJGEHIP NHMJIFDICFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000702")]
	public readonly string? JHPMMGNBIPP;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public IReadOnlyCollection<string> DALMHOFPEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FA90", Offset = "0x7C8E690", VA = "0x187C8FA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public IReadOnlyDictionary<long, int> CDBBHGGKKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FAB0", Offset = "0x7C8E6B0", VA = "0x187C8FAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FAD0", Offset = "0x7C8E6D0", VA = "0x187C8FAD0")]
	public DDJCMNHOHEN(OFOCKDHGIHJ? FDFFMDBCAPG, IBODDJGEHIP LKLPCKMCBKC, string? ECHHHHOHFJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
internal class BPLDJNEHPDK : DDCOPDEMIJO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private struct DAGIPKIPHGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public AsyncTaskMethodBuilder<DDJCMNHOHEN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public BPLDJNEHPDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public OFIKJAIFHJE serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public ALDOMEDIEBM roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private GINHMPCLHHC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F3B0", Offset = "0x7C8DFB0", VA = "0x187C8F3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FA20", Offset = "0x7C8E620", VA = "0x187C8FA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class MNJLKALDEPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public MNJLKALDEPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x7C94ED0", Offset = "0x7C93AD0", VA = "0x187C94ED0")]
		internal object PFLDKOOLDLM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private struct ACONAPCEPMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public BPLDJNEHPDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public OFIKJAIFHJE serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private MNJLKALDEPM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private GINHMPCLHHC <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private HKBIAANNAOH<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x7C8BF50", Offset = "0x7C8AB50", VA = "0x187C8BF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x7C8CA10", Offset = "0x7C8B610", VA = "0x187C8CA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000703")]
	private readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x4000704")]
	private static readonly TimeSpan EEFAOJDPHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000705")]
	private readonly JPOILHJIGBH BICCOONJHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000706")]
	private readonly GKEPJDFIPML OPLACKAFNDM;

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x7C8EED0", Offset = "0x7C8DAD0", VA = "0x187C8EED0")]
	public BPLDJNEHPDK(GDLHPPGEFNI AHAIDLILHKJ, JPOILHJIGBH BICCOONJHOH, GKEPJDFIPML IFGPFIIAEGN, NDNFAPMFFIF DFFCPCMIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x7C8E000", Offset = "0x7C8CC00", VA = "0x187C8E000")]
	[AsyncStateMachine(typeof(DAGIPKIPHGI))]
	public Task<DDJCMNHOHEN> DHDDBDHCOJI(long DMLJPKIDBPD, ALDOMEDIEBM HEFJEHMANPA, OFIKJAIFHJE ODLAGEOHJKB, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x7C8E160", Offset = "0x7C8CD60", VA = "0x187C8E160")]
	[AsyncStateMachine(typeof(ACONAPCEPMO))]
	private Task FEFMJALPBHC(OFIKJAIFHJE ODLAGEOHJKB, PersistenceView[] IMBOBJIGNAH, StringBuilder JHICGNGLJCL, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x7C8E2A0", Offset = "0x7C8CEA0", VA = "0x187C8E2A0")]
	private DDJCMNHOHEN GJONLDMDMBH(long DMLJPKIDBPD, ALDOMEDIEBM HEFJEHMANPA, OFIKJAIFHJE ODLAGEOHJKB, IEnumerable<PersistenceView> IMBOBJIGNAH, StringBuilder JHICGNGLJCL)
	{
		return default(DDJCMNHOHEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x7C8DE40", Offset = "0x7C8CA40", VA = "0x187C8DE40")]
	private OFOCKDHGIHJ DBIPLABKEPM(long DMLJPKIDBPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x7C8E780", Offset = "0x7C8D380", VA = "0x187C8E780")]
	private void IFHFNCOFDON(OFOCKDHGIHJ DIMMCCLGMGB, StringBuilder JHICGNGLJCL, IEnumerable<PersistenceView> IMBOBJIGNAH, [In] JEDFCFCIPKF DKCKOHHDAEN, OFMCEBLPNDA MBGKPCMEDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x7C8E9D0", Offset = "0x7C8D5D0", VA = "0x187C8E9D0")]
	private void OHIJOOBMFPF(OFOCKDHGIHJ DIMMCCLGMGB, StringBuilder JHICGNGLJCL, PersistenceView DPCLJPBHKAL, OFMCEBLPNDA MBGKPCMEDFL, [In] JEDFCFCIPKF DKCKOHHDAEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal class NNEIKHJFFLC : DDCOPDEMIJO
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class JCLCPFPLHCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		public APMILOHFFGE.CINCBNFEIDP roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public JCLCPFPLHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x7C94420", Offset = "0x7C93020", VA = "0x187C94420")]
		internal object ECIOEPHPILC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private struct FFIBHMHGOJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		public AsyncTaskMethodBuilder<(APMILOHFFGE.CINCBNFEIDP roomDataUpload, APMILOHFFGE.CINCBNFEIDP subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		public DDJCMNHOHEN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public NNEIKHJFFLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		private JCLCPFPLHCH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private TaskAwaiter<APMILOHFFGE.CINCBNFEIDP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x7C91770", Offset = "0x7C90370", VA = "0x187C91770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x7C91FD0", Offset = "0x7C90BD0", VA = "0x187C91FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private struct DLHFCPHPNCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public AsyncTaskMethodBuilder<BGHBHPAMLJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public NNEIKHJFFLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public DDJCMNHOHEN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public DJAABFPCNFG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		private TaskAwaiter<(APMILOHFFGE.CINCBNFEIDP roomDataUpload, APMILOHFFGE.CINCBNFEIDP subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private TaskAwaiter<BGHBHPAMLJF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x7C900E0", Offset = "0x7C8ECE0", VA = "0x187C900E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x7C90780", Offset = "0x7C8F380", VA = "0x187C90780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private struct CIHHPFFNICB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		public AsyncTaskMethodBuilder<NBCCHAPKOEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public NNEIKHJFFLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public DDJCMNHOHEN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		private TaskAwaiter<(APMILOHFFGE.CINCBNFEIDP roomDataUpload, APMILOHFFGE.CINCBNFEIDP subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		private TaskAwaiter<NBCCHAPKOEK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x7C8EF30", Offset = "0x7C8DB30", VA = "0x187C8EF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F340", Offset = "0x7C8DF40", VA = "0x187C8F340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class NNFFKFICAFC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000749")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400074A")]
			public AsyncTaskMethodBuilder<DKFJDNOJOIC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400074B")]
			public NNFFKFICAFC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400074C")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400074D")]
			private DKFJDNOJOIC <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400074E")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400074F")]
			private TaskAwaiter<NBCCHAPKOEK> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000750")]
			private TaskAwaiter<BGHBHPAMLJF> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000751")]
			private TaskAwaiter<DKFJDNOJOIC> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x7C97630", Offset = "0x7C96230", VA = "0x187C97630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x7C985B0", Offset = "0x7C971B0", VA = "0x187C985B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public NNEIKHJFFLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public DDJCMNHOHEN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public DJAABFPCNFG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public GLNOINNEODG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public NNFFKFICAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x7C961C0", Offset = "0x7C94DC0", VA = "0x187C961C0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<DKFJDNOJOIC> EEPGLABPOIN(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private struct IGDHJOFGFEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public AsyncTaskMethodBuilder<DKFJDNOJOIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public NNEIKHJFFLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public DDJCMNHOHEN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public DJAABFPCNFG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public GLNOINNEODG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		private TaskAwaiter<DKFJDNOJOIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x7C93500", Offset = "0x7C92100", VA = "0x187C93500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x7C93810", Offset = "0x7C92410", VA = "0x187C93810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x4000721")]
	private static readonly NDNFAPMFFIF DGCKGNFPJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000722")]
	private readonly GPDONAADODL PJHIGGOLAIL;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private CCOEFMMBAGF IBAOJHOHOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x7C68CE0", Offset = "0x7C678E0", VA = "0x187C68CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x7C96130", Offset = "0x7C94D30", VA = "0x187C96130")]
	public NNEIKHJFFLC(GDLHPPGEFNI AHAIDLILHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x7C95DF0", Offset = "0x7C949F0", VA = "0x187C95DF0")]
	[AsyncStateMachine(typeof(FFIBHMHGOJN))]
	private Task<(APMILOHFFGE.CINCBNFEIDP, APMILOHFFGE.CINCBNFEIDP)> HBPFPFMBHNI(DDJCMNHOHEN KCBKNEHLEEA, long EPGJLNEAJPA, long HPCDEBDHAFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x7C95C80", Offset = "0x7C94880", VA = "0x187C95C80")]
	[AsyncStateMachine(typeof(DLHFCPHPNCG))]
	public Task<BGHBHPAMLJF> GNJBMNKEOIH(int HGCGPNLLJML, [CanBeNull] DJAABFPCNFG DHCBPLHFGNP, DDJCMNHOHEN KCBKNEHLEEA, long EPGJLNEAJPA, long HPCDEBDHAFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x7C95F30", Offset = "0x7C94B30", VA = "0x187C95F30")]
	[AsyncStateMachine(typeof(CIHHPFFNICB))]
	private Task<NBCCHAPKOEK> NBBJDGJPKEG(string MDHENNAADKE, int HGCGPNLLJML, DDJCMNHOHEN KCBKNEHLEEA, long EPGJLNEAJPA, long HPCDEBDHAFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x7C95AE0", Offset = "0x7C946E0", VA = "0x187C95AE0")]
	[AsyncStateMachine(typeof(IGDHJOFGFEI))]
	public Task<DKFJDNOJOIC> FHPOMLIBOME(int HGCGPNLLJML, DJAABFPCNFG? DHCBPLHFGNP, DDJCMNHOHEN KCBKNEHLEEA, long EPGJLNEAJPA, long HPCDEBDHAFJ, GLNOINNEODG IAEOKHNKAHO, FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public abstract class EFIHKEKDIAM<T> where T : EFIHKEKDIAM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075E")]
	internal readonly CCOEFMMBAGF BNMFKCJLAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075F")]
	private int? OKAMNNOIKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000760")]
	protected readonly Guid GGHEGFOPPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000761")]
	protected readonly DOGDFHEJDDI ABLGDFIMCCO;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	protected T MJINKNPDJKD
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x3FC4B80", Offset = "0x3FC3780", VA = "0x183FC4B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4F40", Offset = "0x3FC3B40", VA = "0x183FC4F40")]
	internal EFIHKEKDIAM(CCOEFMMBAGF AKEEGJBPNDC, DOGDFHEJDDI KOJKHHJNKAC, [Optional] Guid? HBKGJHPGIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4DC0", Offset = "0x3FC39C0", VA = "0x183FC4DC0")]
	private DKFJDNOJOIC OBKAAFJMJFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "4")]
	protected virtual void NFKJPFLHIAM(DKFJDNOJOIC KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4EA0", Offset = "0x3FC3AA0", VA = "0x183FC4EA0")]
	public T OHAGDCMLEFB(GDNMNFALBCN JCNJPDCHNEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4D10", Offset = "0x3FC3910", VA = "0x183FC4D10")]
	public T OADFHDNEOEK(int JLNGMEKFAFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4BE0", Offset = "0x3FC37E0", VA = "0x183FC4BE0", Slot = "5")]
	public virtual Task<DMOINJJJLLJ> LIFGHHLKNLM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public class BFMECADPGLO : EFIHKEKDIAM<BFMECADPGLO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000762")]
	private PDKHDMNJGNI BFDCDDMLJOF;

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D2C0", Offset = "0x7C8BEC0", VA = "0x187C8D2C0")]
	internal BFMECADPGLO(CCOEFMMBAGF AKEEGJBPNDC, DOGDFHEJDDI KOJKHHJNKAC, [Optional] Guid? HBKGJHPGIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x7045EA0", Offset = "0x7044AA0", VA = "0x187045EA0")]
	public BFMECADPGLO LDGANEEIIGJ(PDKHDMNJGNI BFDCDDMLJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D1F0", Offset = "0x7C8BDF0", VA = "0x187C8D1F0", Slot = "4")]
	protected override void NFKJPFLHIAM(DKFJDNOJOIC KBPDEFFIKOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
public class BJHDMGOPKCA : EFIHKEKDIAM<BJHDMGOPKCA>
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	internal enum NNNMDOKEPJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private struct PPBLDFMCFFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public AsyncTaskMethodBuilder<DMOINJJJLLJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public BJHDMGOPKCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		private TaskAwaiter<DMOINJJJLLJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x7C97220", Offset = "0x7C95E20", VA = "0x187C97220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x7C975C0", Offset = "0x7C961C0", VA = "0x187C975C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000763")]
	private NNNMDOKEPJF COGAJGHLHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000764")]
	private string NKGMOAAFPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000765")]
	private DJAABFPCNFG BFDCDDMLJOF;

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x7C8DCD0", Offset = "0x7C8C8D0", VA = "0x187C8DCD0")]
	internal BJHDMGOPKCA(CCOEFMMBAGF AKEEGJBPNDC, DOGDFHEJDDI KOJKHHJNKAC, [Optional] Guid? HBKGJHPGIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D9C0", Offset = "0x7C8C5C0", VA = "0x187C8D9C0")]
	public BJHDMGOPKCA GDGAIOOFDPJ(string ICDFHDIHFJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x7C8DA10", Offset = "0x7C8C610", VA = "0x187C8DA10")]
	public BJHDMGOPKCA LFEAEPOHNAE(bool HGLPFLGMHBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D9F0", Offset = "0x7C8C5F0", VA = "0x187C8D9F0")]
	public BJHDMGOPKCA IJDPBJPEGAN(bool MONFCHPCANF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D990", Offset = "0x7C8C590", VA = "0x187C8D990")]
	public BJHDMGOPKCA BEAEFCHPDNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x7C8DB60", Offset = "0x7C8C760", VA = "0x187C8DB60", Slot = "4")]
	protected override void NFKJPFLHIAM(DKFJDNOJOIC KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x7C8DA30", Offset = "0x7C8C630", VA = "0x187C8DA30", Slot = "5")]
	[AsyncStateMachine(typeof(PPBLDFMCFFD))]
	public override Task<DMOINJJJLLJ> LIFGHHLKNLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x7C8DB20", Offset = "0x7C8C720", VA = "0x187C8DB20")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<DMOINJJJLLJ> NBFEHFLNMMM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
internal static class OMDNEODEBEM
{
	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x7C96BC0", Offset = "0x7C957C0", VA = "0x187C96BC0")]
	public static void JLHEFLHGOJM(this KHAMOMBBPPI CGKGMJHPAOG, GJIEMBMKFED PDIIEIMPFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x7C96D10", Offset = "0x7C95910", VA = "0x187C96D10")]
	public static void KBPBGEKCFLO(this GJIEMBMKFED LHACABBHAGD, [Optional] string KBPDEFFIKOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
public static class KBJFJELLMCG
{
	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x7C94970", Offset = "0x7C93570", VA = "0x187C94970")]
	public static HEJHHLFMEKL PBHLCHDGHKJ(this HCIFGEOODML GLIAHPDHECM)
	{
		return default(HEJHHLFMEKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x7C948C0", Offset = "0x7C934C0", VA = "0x187C948C0")]
	public static HCIFGEOODML OKAPAIOGBEC(this HEJHHLFMEKL CEONBIMAOLH)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001AA")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000772")]
			public DDLOFGAAMNB ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000773")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000774")]
			public DDLOFGAAMNB HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000775")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000776")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000777")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600069C")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400076F")]
		private static DDLOFGAAMNB[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		private Dictionary<DDLOFGAAMNB, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x7C98AD0", Offset = "0x7C976D0", VA = "0x187C98AD0")]
		public bool HAHKOLDPODK(DDLOFGAAMNB GMPMFCHLNIB, [Out] ResultConfig BKDMEACEJJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x7C98990", Offset = "0x7C97590", VA = "0x187C98990")]
		public ResultConfig GMMHKCCPKHF(DDLOFGAAMNB NCKCEGPNPKI, [Optional] HashSet<DDLOFGAAMNB> FCNFAGOCCKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x7C990F0", Offset = "0x7C97CF0", VA = "0x187C990F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x7C98B40", Offset = "0x7C97740", VA = "0x187C98B40", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0xA4A930", Offset = "0xA49530", VA = "0x180A4A930")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public class JODOCPOMCFO : FCIPKPGJBNG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private struct HKBJKHCOCCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public JODOCPOMCFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C92770", Offset = "0x7C91370", VA = "0x187C92770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C92A00", Offset = "0x7C91600", VA = "0x187C92A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[CompilerGenerated]
	private struct DGDMILLMHNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		public FCIPKPGJBNG preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FBD0", Offset = "0x7C8E7D0", VA = "0x187C8FBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C90080", Offset = "0x7C8EC80", VA = "0x187C90080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400077D")]
	private readonly AGPPAJDEPNJ AOBJDBKDFOO;

	[Cpp2IlInjected.Token(Token = "0x400077E")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public string OGNKKEFJPAM
	{
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C94700", Offset = "0x7C93300", VA = "0x187C94700", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C94580", Offset = "0x7C93180", VA = "0x187C94580")]
	[DMDJPIBKEJJ.OHIIEKNFAKB.OKGKMEFLHLK]
	internal static void AEFNPIEJNPP(KPLLBHIBBNH DMGOKFDJBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	[RecRoom.NoEngine.Common.Preserve]
	public JODOCPOMCFO([GJMNBPKNJPO(null)] AGPPAJDEPNJ AOBJDBKDFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C945F0", Offset = "0x7C931F0", VA = "0x187C945F0", Slot = "5")]
	[AsyncStateMachine(typeof(HKBJKHCOCCL))]
	public Task BDNCCGGPJGH(FNEANCIAOBI<string>.IDKBCAKILKJ IABIPFABHPJ, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C94730", Offset = "0x7C93330", VA = "0x187C94730")]
	[AsyncStateMachine(typeof(DGDMILLMHNF))]
	private Task MENNMFDHIJF(FCIPKPGJBNG KDFODFHJFKB, FNEANCIAOBI<string>.IDKBCAKILKJ IABIPFABHPJ, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
public interface AGPPAJDEPNJ : FCIPKPGJBNG
{
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public interface FCIPKPGJBNG
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	string OGNKKEFJPAM
	{
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BDNCCGGPJGH(FNEANCIAOBI<string>.IDKBCAKILKJ IABIPFABHPJ, CancellationToken NAOIMKEDKEJ);
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public static class GJMEBGFNBJA
{
	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x7C92360", Offset = "0x7C90F60", VA = "0x187C92360")]
	[DMDJPIBKEJJ.OHIIEKNFAKB.OKGKMEFLHLK]
	internal static void EKJPAICHAMI(KPLLBHIBBNH DMGOKFDJBDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public interface JOHMHGNLPIP : IEquatable<JOHMHGNLPIP>
{
	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	DateTime EPALGHFJGFG
	{
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHBPICLMKAC();

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DJDMCLNHIML(long EPGJLNEAJPA, long DMLJPKIDBPD, [Out] DDJCMNHOHEN KCBKNEHLEEA);
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
internal class IHCBPDJJOHB : KKOOLMKCHOG
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[CompilerGenerated]
	private sealed class ACBMLMAELLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public GBJMJAJMANP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public ACBMLMAELLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C8BEE0", Offset = "0x7C8AAE0", VA = "0x187C8BEE0")]
		internal object CCIMPNAMDNA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400078C")]
	private readonly IDOIIHCBCHI DDKLBCGEDKO;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<JOHMHGNLPIP> BFEPKBBCMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C93880", Offset = "0x7C92480", VA = "0x187C93880", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C93930", Offset = "0x7C92530", VA = "0x187C93930", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	[UnityEngine.Scripting.Preserve]
	public IHCBPDJJOHB([GJMNBPKNJPO(null)] IDOIIHCBCHI DDKLBCGEDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x7C939E0", Offset = "0x7C925E0", VA = "0x187C939E0", Slot = "6")]
	public bool INCLJBDGBOB(long EPGJLNEAJPA, long DMLJPKIDBPD, DDJCMNHOHEN KCBKNEHLEEA, GBJMJAJMANP GEJNDLMJHME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0xC45570", Offset = "0xC44170", VA = "0x180C45570")]
	private void ICLEGCKPFCL(JOHMHGNLPIP EBANPFALAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x7C94190", Offset = "0x7C92D90", VA = "0x187C94190", Slot = "7")]
	public bool MFHFFEHNIKO(long EPGJLNEAJPA, long DMLJPKIDBPD, [Out] JOHMHGNLPIP ENLLCILGBAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x7C940E0", Offset = "0x7C92CE0", VA = "0x187C940E0", Slot = "8")]
	public bool LPKAGKCOACE(long EPGJLNEAJPA, long DMLJPKIDBPD, GBJMJAJMANP GEJNDLMJHME, [Out] JOHMHGNLPIP ENLLCILGBAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x7C93CC0", Offset = "0x7C928C0", VA = "0x187C93CC0")]
	private void JIIJAFIPNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x7C94300", Offset = "0x7C92F00", VA = "0x187C94300", Slot = "9")]
	public void OFAPFGJBOHF(long EPGJLNEAJPA, long DMLJPKIDBPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
internal abstract class IBEHBEKLGBI : IDOIIHCBCHI
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	protected enum ABCPEGDBOGA : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[CompilerGenerated]
	private sealed class ONABBBALPLO : IEnumerable<JOHMHGNLPIP>, IEnumerable, IEnumerator<JOHMHGNLPIP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		private JOHMHGNLPIP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public IBEHBEKLGBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		private GBJMJAJMANP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public GBJMJAJMANP <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		private JOHMHGNLPIP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xD30330", Offset = "0xD2EF30", VA = "0x180D30330")]
		[DebuggerHidden]
		public ONABBBALPLO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C96D90", Offset = "0x7C95990", VA = "0x187C96D90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C97070", Offset = "0x7C95C70", VA = "0x187C97070", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C96FC0", Offset = "0x7C95BC0", VA = "0x187C96FC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JOHMHGNLPIP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C96FC0", Offset = "0x7C95BC0", VA = "0x187C96FC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[CompilerGenerated]
	private sealed class JHHIKJFEAKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public GBJMJAJMANP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public JHHIKJFEAKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C94470", Offset = "0x7C93070", VA = "0x187C94470")]
		internal object OGCEDLINCNA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[CompilerGenerated]
	private sealed class BDOBJAADLPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		public IBEHBEKLGBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public BDOBJAADLPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C8CA70", Offset = "0x7C8B670", VA = "0x187C8CA70")]
		internal void EPABOINNHMD(LBOKIKNGLCO.BNANMHAGODN ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000792")]
	private readonly object DNMPIMMMGBK;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	protected string DNLHOFFIPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x7C93280", Offset = "0x7C91E80", VA = "0x187C93280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public abstract IGFMHNDAFIH PGLEOCFOMIG
	{
		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x7C93480", Offset = "0x7C92080", VA = "0x187C93480")]
	protected IBEHBEKLGBI([CanBeNull] string HJHDOGLDCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x7C93290", Offset = "0x7C91E90", VA = "0x187C93290", Slot = "5")]
	public bool PFNLNOKPKGD(long EPGJLNEAJPA, long DMLJPKIDBPD, GBJMJAJMANP GEJNDLMJHME, [Out] JOHMHGNLPIP EBANPFALAHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C92DD0", Offset = "0x7C919D0", VA = "0x187C92DD0", Slot = "6")]
	[IteratorStateMachine(typeof(ONABBBALPLO))]
	public IEnumerable<JOHMHGNLPIP> HMOKIPNIKFA(GBJMJAJMANP GEJNDLMJHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void OAIHINIAGJK(Stream IKCIBMDPCBG, long EPGJLNEAJPA, long DMLJPKIDBPD, DDJCMNHOHEN KCBKNEHLEEA);

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool PKGCNAKLGFB(Stream FNJNIJKKBPB, long EPGJLNEAJPA, long DMLJPKIDBPD, BCIHFGPKEAC AHNPGPDPIOG, [Out] DDJCMNHOHEN KCBKNEHLEEA);

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x7C92A60", Offset = "0x7C91660", VA = "0x187C92A60", Slot = "7")]
	public JOHMHGNLPIP FFDBCHLABJD(long EPGJLNEAJPA, long DMLJPKIDBPD, DDJCMNHOHEN KCBKNEHLEEA, GBJMJAJMANP GEJNDLMJHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo GBGPADPDCGC(long EPGJLNEAJPA, long DMLJPKIDBPD, GBJMJAJMANP GEJNDLMJHME, ABCPEGDBOGA LPEHHGFMJNP);

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo BHFLKJINOEB(GBJMJAJMANP GEJNDLMJHME, ABCPEGDBOGA LPEHHGFMJNP);

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C93210", Offset = "0x7C91E10", VA = "0x187C93210")]
	protected void JOMKDPEAIKA(LBOKIKNGLCO.BNANMHAGODN EHFGAJADOAL, string EJCEKPPDLHD, FileInfo OKOFMMEPNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C92E60", Offset = "0x7C91A60", VA = "0x187C92E60")]
	internal bool IGOEALJBDKH(FileInfo KCFAGCBHADF, long EPGJLNEAJPA, long DMLJPKIDBPD, [Out] DDJCMNHOHEN KCBKNEHLEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
	private void GOJLIAHDIOD(Exception LIELHOAJGJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
internal class NLJNMLFGMHH : IBEHBEKLGBI
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public override IGFMHNDAFIH PGLEOCFOMIG
	{
		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x1B3EED0", Offset = "0x1B3DAD0", VA = "0x181B3EED0", Slot = "8")]
		get
		{
			return default(IGFMHNDAFIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x7C95AA0", Offset = "0x7C946A0", VA = "0x187C95AA0")]
	public NLJNMLFGMHH([Optional] string HJHDOGLDCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x7C95040", Offset = "0x7C93C40", VA = "0x187C95040")]
	private void CDFBNCJAOEI(GBJMJAJMANP GEJNDLMJHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x7C951B0", Offset = "0x7C93DB0", VA = "0x187C951B0", Slot = "9")]
	internal override void OAIHINIAGJK(Stream IKCIBMDPCBG, long EPGJLNEAJPA, long DMLJPKIDBPD, DDJCMNHOHEN KCBKNEHLEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x7C95440", Offset = "0x7C94040", VA = "0x187C95440", Slot = "10")]
	internal override bool PKGCNAKLGFB(Stream FNJNIJKKBPB, long EPGJLNEAJPA, long DMLJPKIDBPD, BCIHFGPKEAC AHNPGPDPIOG, [Out] DDJCMNHOHEN KCBKNEHLEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x7C950C0", Offset = "0x7C93CC0", VA = "0x187C950C0", Slot = "11")]
	protected override FileInfo GBGPADPDCGC(long EPGJLNEAJPA, long DMLJPKIDBPD, GBJMJAJMANP GEJNDLMJHME, ABCPEGDBOGA LPEHHGFMJNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x7C94F40", Offset = "0x7C93B40", VA = "0x187C94F40", Slot = "12")]
	protected override DirectoryInfo BHFLKJINOEB(GBJMJAJMANP GEJNDLMJHME, ABCPEGDBOGA LPEHHGFMJNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
internal sealed class EGLOKJJADNF : IBEHBEKLGBI
{
	[Cpp2IlInjected.Token(Token = "0x40007A2")]
	private static readonly byte[] NKANGPLHEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007A3")]
	private readonly byte[] MIALLEMIAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007A4")]
	private readonly byte[] NNDECMLHKHC;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public override IGFMHNDAFIH PGLEOCFOMIG
	{
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x68B83D0", Offset = "0x68B6FD0", VA = "0x1868B83D0", Slot = "8")]
		get
		{
			return default(IGFMHNDAFIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C91680", Offset = "0x7C90280", VA = "0x187C91680")]
	public EGLOKJJADNF([Optional] string HJHDOGLDCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x7C90AF0", Offset = "0x7C8F6F0", VA = "0x187C90AF0", Slot = "9")]
	internal override void OAIHINIAGJK(Stream IKCIBMDPCBG, long EPGJLNEAJPA, long DMLJPKIDBPD, DDJCMNHOHEN KCBKNEHLEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C90DB0", Offset = "0x7C8F9B0", VA = "0x187C90DB0", Slot = "10")]
	internal override bool PKGCNAKLGFB(Stream FNJNIJKKBPB, long EPGJLNEAJPA, long DMLJPKIDBPD, BCIHFGPKEAC AHNPGPDPIOG, [Out] DDJCMNHOHEN KCBKNEHLEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C907F0", Offset = "0x7C8F3F0", VA = "0x187C907F0")]
	private void ALFPHKKJCEH(byte[] FOLLKKLPOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C909C0", Offset = "0x7C8F5C0", VA = "0x187C909C0", Slot = "11")]
	protected override FileInfo GBGPADPDCGC(long EPGJLNEAJPA, long DMLJPKIDBPD, GBJMJAJMANP GEJNDLMJHME, ABCPEGDBOGA LPEHHGFMJNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C908B0", Offset = "0x7C8F4B0", VA = "0x187C908B0", Slot = "12")]
	protected override DirectoryInfo BHFLKJINOEB(GBJMJAJMANP GEJNDLMJHME, ABCPEGDBOGA LPEHHGFMJNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
public enum IGFMHNDAFIH : byte
{
	[Cpp2IlInjected.Token(Token = "0x40007A6")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40007A7")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40007A8")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
internal class NPLNOEOOGLC : IDOIIHCBCHI
{
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	[CompilerGenerated]
	private sealed class LPKCDNFBJML : IEnumerable<JOHMHGNLPIP>, IEnumerable, IEnumerator<JOHMHGNLPIP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007B0")]
		private JOHMHGNLPIP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007B1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007B2")]
		public NPLNOEOOGLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007B3")]
		private GBJMJAJMANP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007B4")]
		public GBJMJAJMANP <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007B5")]
		private IGFMHNDAFIH[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007B6")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		private IEnumerator<JOHMHGNLPIP> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		private JOHMHGNLPIP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xD30330", Offset = "0xD2EF30", VA = "0x180D30330")]
		[DebuggerHidden]
		public LPKCDNFBJML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C94E40", Offset = "0x7C93A40", VA = "0x187C94E40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C94A60", Offset = "0x7C93660", VA = "0x187C94A60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C94A10", Offset = "0x7C93610", VA = "0x187C94A10")]
		private void AOMOFJGADBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C94DF0", Offset = "0x7C939F0", VA = "0x187C94DF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C94D40", Offset = "0x7C93940", VA = "0x187C94D40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JOHMHGNLPIP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C94D40", Offset = "0x7C93940", VA = "0x187C94D40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007A9")]
	private readonly IGFMHNDAFIH[] IJANADPMAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007AA")]
	private readonly Dictionary<IGFMHNDAFIH, IDOIIHCBCHI> MGBLIHLLONE;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public IGFMHNDAFIH PGLEOCFOMIG
	{
		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C96710", Offset = "0x7C95310", VA = "0x187C96710", Slot = "4")]
		get
		{
			return default(IGFMHNDAFIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C96890", Offset = "0x7C95490", VA = "0x187C96890")]
	[UnityEngine.Scripting.Preserve]
	public NPLNOEOOGLC(params IDOIIHCBCHI[] NNEPLCHPDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C96740", Offset = "0x7C95340", VA = "0x187C96740", Slot = "5")]
	public bool PFNLNOKPKGD(long EPGJLNEAJPA, long DMLJPKIDBPD, GBJMJAJMANP GEJNDLMJHME, [Out] JOHMHGNLPIP EBANPFALAHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C962F0", Offset = "0x7C94EF0", VA = "0x187C962F0")]
	private void COJJDHMEMDE(int NJLLEAJPLNK, long EPGJLNEAJPA, long DMLJPKIDBPD, GBJMJAJMANP GEJNDLMJHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C96680", Offset = "0x7C95280", VA = "0x187C96680", Slot = "6")]
	[IteratorStateMachine(typeof(LPKCDNFBJML))]
	public IEnumerable<JOHMHGNLPIP> HMOKIPNIKFA(GBJMJAJMANP GEJNDLMJHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C96530", Offset = "0x7C95130", VA = "0x187C96530", Slot = "7")]
	public JOHMHGNLPIP FFDBCHLABJD(long EPGJLNEAJPA, long DMLJPKIDBPD, DDJCMNHOHEN KCBKNEHLEEA, GBJMJAJMANP GEJNDLMJHME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
internal static class GDKIKJCPGIK
{
	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C922A0", Offset = "0x7C90EA0", VA = "0x187C922A0")]
	internal static byte[] PGODELEAOCK(byte[] FOLLKKLPOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C92220", Offset = "0x7C90E20", VA = "0x187C92220")]
	public static void PGCBONCNENF(Stream EJHPLBNDLAI, byte[] DOFMNEMBOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C92040", Offset = "0x7C90C40", VA = "0x187C92040")]
	public static bool DAKHOGBJOJB(Stream EJHPLBNDLAI, long AIBCDNDFJGD, BCIHFGPKEAC AJLJIGCJLCF, [Out] byte[] LCDFHGLFHDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
internal sealed class BGLFLOMBIEA : JOHMHGNLPIP, IEquatable<JOHMHGNLPIP>, IEquatable<BGLFLOMBIEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007B8")]
	private readonly IBEHBEKLGBI CAGBFOKNBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007B9")]
	public readonly FileInfo GKJMAFKCCJJ;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public IGFMHNDAFIH PGLEOCFOMIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x75A8980", Offset = "0x75A7580", VA = "0x1875A8980", Slot = "9")]
		get
		{
			return default(IGFMHNDAFIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public DateTime EPALGHFJGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D390", Offset = "0x7C8BF90", VA = "0x187C8D390", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D880", Offset = "0x7C8C480", VA = "0x187C8D880")]
	public BGLFLOMBIEA(IBEHBEKLGBI AGPOCEOFJBC, FileInfo KCFAGCBHADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D7D0", Offset = "0x7C8C3D0", VA = "0x187C8D7D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D420", Offset = "0x7C8C020", VA = "0x187C8D420", Slot = "5")]
	public void BHBPICLMKAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D4E0", Offset = "0x7C8C0E0", VA = "0x187C8D4E0", Slot = "6")]
	public bool DJDMCLNHIML(long EPGJLNEAJPA, long DMLJPKIDBPD, [Out] DDJCMNHOHEN KCBKNEHLEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D5E0", Offset = "0x7C8C1E0", VA = "0x187C8D5E0", Slot = "7")]
	public bool Equals(JOHMHGNLPIP PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D520", Offset = "0x7C8C120", VA = "0x187C8D520", Slot = "8")]
	public bool Equals(BGLFLOMBIEA PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D650", Offset = "0x7C8C250", VA = "0x187C8D650", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D740", Offset = "0x7C8C340", VA = "0x187C8D740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
public delegate void BCIHFGPKEAC(LBOKIKNGLCO.BNANMHAGODN FCCEDBEILPE, string KBPDEFFIKOJ);
[Cpp2IlInjected.Token(Token = "0x20001C4")]
internal interface IDOIIHCBCHI
{
	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	IGFMHNDAFIH PGLEOCFOMIG
	{
		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PFNLNOKPKGD(long EPGJLNEAJPA, long DMLJPKIDBPD, GBJMJAJMANP GEJNDLMJHME, [Out] JOHMHGNLPIP EBANPFALAHB);

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<JOHMHGNLPIP> HMOKIPNIKFA(GBJMJAJMANP GEJNDLMJHME);

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JOHMHGNLPIP FFDBCHLABJD(long EPGJLNEAJPA, long DMLJPKIDBPD, DDJCMNHOHEN KCBKNEHLEEA, GBJMJAJMANP GEJNDLMJHME);
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
