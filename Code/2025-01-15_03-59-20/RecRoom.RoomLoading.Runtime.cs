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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x77100B0", Offset = "0x770F4B0", VA = "0x1877100B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
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
	public class LogRegistrationIndex : IMPGLFODBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x770DED0", Offset = "0x770D2D0", VA = "0x18770DED0", Slot = "4")]
		public override void EMOBGIHOLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7717B20", Offset = "0x7716F20", VA = "0x187717B20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MNFKALNPLDE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x770EC80", Offset = "0x770E080", VA = "0x18770EC80")]
	public MNFKALNPLDE(string LNICHECHJFC, Exception AMBPMFFJDPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class DDMMELHOKNL : PDIIMHBGLLB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct PLNGCBLPAME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<GNODDIAAKFD>> <>t__builder;

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
		private TaskAwaiter<ENPMNALFKDH<GNODDIAAKFD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x77171B0", Offset = "0x77165B0", VA = "0x1877171B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77173F0", Offset = "0x77167F0", VA = "0x1877173F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct FDJGLJFIMHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<EJMNLGMFCDG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<EJMNLGMFCDG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7700740", Offset = "0x76FFB40", VA = "0x187700740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7700950", Offset = "0x76FFD50", VA = "0x187700950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	[UnityEngine.Scripting.Preserve]
	public DDMMELHOKNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x76FBEC0", Offset = "0x76FB2C0", VA = "0x1876FBEC0", Slot = "4")]
	[AsyncStateMachine(typeof(PLNGCBLPAME))]
	public Task<IReadOnlyList<GNODDIAAKFD>> CNHACHKGMNN(long GGLEGKBAGLC, long LPKNEPKMMOO, [Optional] CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x76FBFE0", Offset = "0x76FB3E0", VA = "0x1876FBFE0", Slot = "5")]
	[AsyncStateMachine(typeof(FDJGLJFIMHO))]
	public Task<IReadOnlyList<EJMNLGMFCDG>> NMLJOIGNOFJ(IReadOnlyList<int> MPHLPMNPFEO, [Optional] CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GICCDOFPJPG : IEquatable<GICCDOFPJPG>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int DLNGFHIKGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	EJMNLGMFCDG KDDOEEIKCKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime MOHLBCJIBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEFGEALKNFF? LHDDIBBFPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	JOIKEDMHHLH? FKCIOBNCJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	CCDLEHJMOHJ AEGGFHGBFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<BMNBHAPJIMJ> GBNJLMANDIE();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum CCDLEHJMOHJ
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PDIIMHBGLLB
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<GNODDIAAKFD>> CNHACHKGMNN(long GGLEGKBAGLC, long LPKNEPKMMOO, [Optional] CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<EJMNLGMFCDG>> NMLJOIGNOFJ(IReadOnlyList<int> MPHLPMNPFEO, [Optional] CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class OLJDGIBPBGI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class ABFDFIJKEJP : GICCDOFPJPG, IEquatable<GICCDOFPJPG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct KCMCKDHMEAA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<BMNBHAPJIMJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public ABFDFIJKEJP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private JGCOOGJEKHJ <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<NLMAEEICDJF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<BMNBHAPJIMJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x770AE80", Offset = "0x770A280", VA = "0x18770AE80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x770B340", Offset = "0x770A740", VA = "0x18770B340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly GNODDIAAKFD KEOFEOJHKHI;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int DLNGFHIKGBH
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8C93C0", Offset = "0x8C87C0", VA = "0x1808C93C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public EJMNLGMFCDG KDDOEEIKCKD
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime BONBOCHACGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x61ABA80", Offset = "0x61AAE80", VA = "0x1861ABA80", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IEFGEALKNFF? LHDDIBBFPAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9C05A0", Offset = "0x9BF9A0", VA = "0x1809C05A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public JOIKEDMHHLH? FKCIOBNCJNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x61ABB80", Offset = "0x61AAF80", VA = "0x1861ABB80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CCDLEHJMOHJ AEGGFHGBFLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x93EBD0", Offset = "0x93DFD0", VA = "0x18093EBD0", Slot = "10")]
			get
			{
				return default(CCDLEHJMOHJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x76F9AE0", Offset = "0x76F8EE0", VA = "0x1876F9AE0", Slot = "9")]
		[AsyncStateMachine(typeof(KCMCKDHMEAA))]
		public Task<BMNBHAPJIMJ> GBNJLMANDIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x76F9C60", Offset = "0x76F9060", VA = "0x1876F9C60")]
		public ABFDFIJKEJP(int ONABBDDMFNJ, EJMNLGMFCDG ECOHOJHAHJJ, GNODDIAAKFD KEOFEOJHKHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x76F99B0", Offset = "0x76F8DB0", VA = "0x1876F99B0", Slot = "11")]
		public bool Equals(GICCDOFPJPG BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x76F9A40", Offset = "0x76F8E40", VA = "0x1876F9A40", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x76F9970", Offset = "0x76F8D70", VA = "0x1876F9970")]
		private bool ANMIEIMOOAO(ABFDFIJKEJP BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x76F9BE0", Offset = "0x76F8FE0", VA = "0x1876F9BE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class FIMEHELDMFJ : GICCDOFPJPG, IEquatable<GICCDOFPJPG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct KKJABNGDILJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<BMNBHAPJIMJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public FIMEHELDMFJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<BMNBHAPJIMJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x770D570", Offset = "0x770C970", VA = "0x18770D570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x770D7C0", Offset = "0x770CBC0", VA = "0x18770D7C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly OGAHHHAJHDC PBHOGLGIDGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly IEFGEALKNFF CABBHKIBFGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly JOIKEDMHHLH KFCHKIKCEKL;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int DLNGFHIKGBH
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7700A20", Offset = "0x76FFE20", VA = "0x187700A20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public EJMNLGMFCDG KDDOEEIKCKD
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7700DC0", Offset = "0x77001C0", VA = "0x187700DC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime BONBOCHACGL
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7700A60", Offset = "0x76FFE60", VA = "0x187700A60", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IEFGEALKNFF? LHDDIBBFPAM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7700E50", Offset = "0x7700250", VA = "0x187700E50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public JOIKEDMHHLH? FKCIOBNCJNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7700C00", Offset = "0x7700000", VA = "0x187700C00", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public CCDLEHJMOHJ AEGGFHGBFLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x935560", Offset = "0x934960", VA = "0x180935560", Slot = "10")]
			get
			{
				return default(CCDLEHJMOHJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1828F60", Offset = "0x1828360", VA = "0x181828F60")]
		public FIMEHELDMFJ(OGAHHHAJHDC CKMDEKPOFMF, IEFGEALKNFF CFMMKGCFKJF, JOIKEDMHHLH HFHCEMHPCPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7700C50", Offset = "0x7700050", VA = "0x187700C50", Slot = "9")]
		[AsyncStateMachine(typeof(KKJABNGDILJ))]
		public Task<BMNBHAPJIMJ> GBNJLMANDIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7700AB0", Offset = "0x76FFEB0", VA = "0x187700AB0", Slot = "11")]
		public bool Equals(GICCDOFPJPG BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7700B50", Offset = "0x76FFF50", VA = "0x187700B50", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x77009C0", Offset = "0x76FFDC0", VA = "0x1877009C0")]
		private bool ANMIEIMOOAO(FIMEHELDMFJ BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7700D40", Offset = "0x7700140", VA = "0x187700D40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class JNELHCACPMC : GICCDOFPJPG, IEquatable<GICCDOFPJPG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct NBEMLCIILJP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<BMNBHAPJIMJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<BMNBHAPJIMJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x770ECF0", Offset = "0x770E0F0", VA = "0x18770ECF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x770EF50", Offset = "0x770E350", VA = "0x18770EF50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly EJMNLGMFCDG GIMEKDMNBEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly IEFGEALKNFF CABBHKIBFGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly JOIKEDMHHLH KFCHKIKCEKL;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int DLNGFHIKGBH
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7706CC0", Offset = "0x77060C0", VA = "0x187706CC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public EJMNLGMFCDG KDDOEEIKCKD
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime BONBOCHACGL
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEFGEALKNFF? LHDDIBBFPAM
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7706F80", Offset = "0x7706380", VA = "0x187706F80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public JOIKEDMHHLH? FKCIOBNCJNM
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7706DD0", Offset = "0x77061D0", VA = "0x187706DD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public CCDLEHJMOHJ AEGGFHGBFLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "10")]
			get
			{
				return default(CCDLEHJMOHJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1828F60", Offset = "0x1828360", VA = "0x181828F60")]
		public JNELHCACPMC(EJMNLGMFCDG ECOHOJHAHJJ, IEFGEALKNFF CFMMKGCFKJF, JOIKEDMHHLH HFHCEMHPCPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7706E20", Offset = "0x7706220", VA = "0x187706E20", Slot = "9")]
		[AsyncStateMachine(typeof(NBEMLCIILJP))]
		public Task<BMNBHAPJIMJ> GBNJLMANDIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7706D60", Offset = "0x7706160", VA = "0x187706D60", Slot = "11")]
		public bool Equals(GICCDOFPJPG BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7706CE0", Offset = "0x77060E0", VA = "0x187706CE0", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7706EF0", Offset = "0x77062F0", VA = "0x187706EF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7706BE0", Offset = "0x7705FE0", VA = "0x187706BE0")]
		private bool ANMIEIMOOAO(JNELHCACPMC BMKPAKCEMFK)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct DOIEIBOGDGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<GICCDOFPJPG>> <>t__builder;

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
		public OLJDGIBPBGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<GNODDIAAKFD> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<GNODDIAAKFD>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, EJMNLGMFCDG account, GNODDIAAKFD roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x76FE590", Offset = "0x76FD990", VA = "0x1876FE590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x76FF3C0", Offset = "0x76FE7C0", VA = "0x1876FF3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct CEMHECCFPBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, EJMNLGMFCDG account, GNODDIAAKFD roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<GNODDIAAKFD> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public OLJDGIBPBGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<EJMNLGMFCDG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x76FACF0", Offset = "0x76FA0F0", VA = "0x1876FACF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x76FB6B0", Offset = "0x76FAAB0", VA = "0x1876FB6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FOKHBNFMEAP EODINJFJEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly PDIIMHBGLLB EGFNJHMMAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly FGFDBJOOGKL NEPNEBNHDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly KHPJJBFPLGK<(long, long), IReadOnlyList<GNODDIAAKFD>> DEICAFPBEAL;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7711630", Offset = "0x7710A30", VA = "0x187711630")]
	[UnityEngine.Scripting.Preserve]
	public OLJDGIBPBGI([CNGCCDLPGOD(null)] PDIIMHBGLLB MPDKGNEOIBF, [CNGCCDLPGOD(null)] FGFDBJOOGKL FMOJFNNCADL, [CNGCCDLPGOD(null)] FOKHBNFMEAP EAILAMILFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7711340", Offset = "0x7710740", VA = "0x187711340")]
	[AsyncStateMachine(typeof(DOIEIBOGDGE))]
	public Task<IList<GICCDOFPJPG>> JFIKBBFFAFC(long GGLEGKBAGLC, long DLGNECIGKLC, bool BNCKKCAKDHO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7711490", Offset = "0x7710890", VA = "0x187711490")]
	private bool LBDBAIKFPKM(DateTime? IHLFHFBEGOC, long GGLEGKBAGLC, long DLGNECIGKLC, [Out] OGAHHHAJHDC KGCIEMPDBFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7711230", Offset = "0x7710630", VA = "0x187711230")]
	[AsyncStateMachine(typeof(CEMHECCFPBH))]
	private Task<IReadOnlyList<(int, EJMNLGMFCDG, GNODDIAAKFD)>> DGOODPEIJJI(IReadOnlyList<GNODDIAAKFD> CJKIKFCOOJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FGFDBJOOGKL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<OGAHHHAJHDC> KPMEDLKCGDN;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KBHJNMEEJKI(long GGLEGKBAGLC, long DLGNECIGKLC, BIPJJKGGCNE MOCEEFBBOOH, BFBICLDJJAD ODJFJIBMPIO);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KDBKNLIGEHI(long GGLEGKBAGLC, long DLGNECIGKLC, [Out] OGAHHHAJHDC KGCIEMPDBFO);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LFOFDLKAPDM(long GGLEGKBAGLC, long DLGNECIGKLC, BFBICLDJJAD ODJFJIBMPIO, [Out] OGAHHHAJHDC KGCIEMPDBFO);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LEOEJLDOMCM(long GGLEGKBAGLC, long DLGNECIGKLC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface LHHDEKNNILG : LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BLJANFPKKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task OPCFJBCLCPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGKHDMMCDLJ(Task LCFJPCOMAFL, string CLBKIJMMEJI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface BIFNOFKPNFP : LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BMNBHAPJIMJ> BDHBKOJDFHN(OGAHHHAJHDC KGCIEMPDBFO);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HFFAGDBFNIE(CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface BIOGHNKCPHL : LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	HOEBJIIEGFO MKEAELGMPDA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOCDNDBJHKD();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LAJEJDIFPJH();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface LEKKAGKCCHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOJJEJPOBFE(FGMEGFCAHOO EKABOCOCDBK);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface BFPGCNENHGP
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan EMNICBDMKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan JAMMHNIGNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan OGMFDDIOPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan JPNKNFAIKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool BALBNLJPOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool OJIGLHKHEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool HILDKJINKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int DOACHPNMDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool OIEBNPOIPEN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool IDBNGNOLNHK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum AOEKHPHPFLG
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum LJNFHBCPNNB
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
public struct AFMCCHKAGHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long KOPAGGCCKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long LPKNEPKMMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly AOEKHPHPFLG IFBDJLKPHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception IAANNFEHDON;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x76F9D10", Offset = "0x76F9110", VA = "0x1876F9D10")]
	public AFMCCHKAGHJ(long KOPAGGCCKKF, long LPKNEPKMMOO, AOEKHPHPFLG IFBDJLKPHIG, [CanBeNull] Exception IAANNFEHDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x76F9CC0", Offset = "0x76F90C0", VA = "0x1876F9CC0")]
	public static AFMCCHKAGHJ MEINOAHMLLJ(OPCCMKNHDBC MFIGDOAMPLE, AOEKHPHPFLG IFBDJLKPHIG, [Optional] Exception IAANNFEHDON)
	{
		return default(AFMCCHKAGHJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void BBJBFNANILB(AFMCCHKAGHJ JOIHKBAHMPG);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface NJJOBPIEEBD : LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action ACCLPOJDLJA;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event BBJBFNANILB KPEADDGLFCE;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event BBJBFNANILB KJPCAGFAABA;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event BBJBFNANILB OPPKMNJPMKL;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<LJNFHBCPNNB, bool> CKKCGEGPLPC;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CMLNMCBMKEN();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FGMLOENPFFD(AFMCCHKAGHJ JOIHKBAHMPG);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CFIOLPOAPDF(AFMCCHKAGHJ JOIHKBAHMPG);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FELDNLHJAFA(AFMCCHKAGHJ JOIHKBAHMPG);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HLNFKHDKIFB(LJNFHBCPNNB LNABBPEHJIJ, bool BIDPAAHCAAA);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface OFAIDDBHGII : LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LFOHMBIMCOH();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KEJIIIOCNNO();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface KBJHGCHDPOA : LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus KKDJGKLDMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CMJEFBBPNCM(OPCCMKNHDBC MEAFHEONFHD, PFODNDLNIEM OKKLLCCBHFK, CancellationToken FGKKJOBPJBP);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class KPPNANAGBIN
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x770D830", Offset = "0x770CC30", VA = "0x18770D830")]
	public static bool PCIOEKLCOFJ(this KBJHGCHDPOA HKPGINJDHPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate Task IGHOGOBMLLF(CancellationToken CMNJCPJBHGE, int HLAOHLMDNLM, AECOPHFIFAP HKGLPPGLJFI);
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface EKHPCFNCOAH : LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JDDOJGHPKJG(IGHOGOBMLLF HGJOGNHDHHI);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface FGMEGFCAHOO : JGCOOGJEKHJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken LFJAFMNJGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	CGJHFFGEHKC NKLJCGFGLHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	HCMOGHGOBGB KCPGHJIOEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	DCFACMMFOLA EHIEHCJDAFP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	HJHDHMCCGBJ EEGJAFGKABI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	DEEAIEEIPBM AGEOCKPOFAN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	KAINKLBPDLA AHFAALCDBIA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	GGPPIGPEPAI ADHJJLGBHPC
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	KDKGOMPODOP KBJFOBDGIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	LHHDEKNNILG ELKCKOOBCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	BIFNOFKPNFP OKNHDPPCOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	NJJOBPIEEBD KADHBGDODMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	OFAIDDBHGII EMPJMFOELCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	KBJHGCHDPOA AHNIFFDMDOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	EKHPCFNCOAH ECMBAEHOPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	PONAGHIDMCH OAOGKJJCOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IKIAIKFLBIM KBKGMCHCCOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HFGJNCPNPMN IMJHACNBLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	HOPKELNFEOC ADGPGMGCPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CPKFCHFLOKG IDFCLFODCDN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	MPGGJDCHONJ DFOMMLOHLDF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	OPHHCOONIMC IDDCJOHEPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	AIMAIBHBLDD DAMEKGEPNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	NCJMKHJMGOJ HIFEIHAMPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	IBEECJFKBNI LDHKOHPHNEM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	BIOGHNKCPHL NLPAFCCKFJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	BFPGCNENHGP NGMCCIGDJII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	PPGBCHJLLOD MHINAOKCFKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	FGFDBJOOGKL AEFFKMOJFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	NNCDHDGNJDP KDHLLHEMLGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	MOAJKCFHBNI KJMACBPIEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	OPACFMPIKLJ LEFMBOHEEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	JHJPFICBPAM LADKALFLDHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	new bool GGNEGBCLNCJ
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
	void JPDBALIPJHM(PFODNDLNIEM NAPMDNNFBMI);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface PONAGHIDMCH : LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLJMECJKGKE EBDKDKCDLND(Guid NDFJMJHNPGE);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BDKJEBALGLD(Guid NDFJMJHNPGE);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OAABOCPMCPI(Guid NDFJMJHNPGE, Task ONIAAOHFKKF);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NBAGPJMBKOF(Guid NDFJMJHNPGE, BMNBHAPJIMJ GCJOPPEIAPO);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(BMNBHAPJIMJ, Task)> BHNPNBHLEAE(Guid NDFJMJHNPGE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface DJDKBPJOFLH : LEKKAGKCCHD, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface IKIAIKFLBIM : LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPCJMJKEFOE(CCONCDOKPJO LNICHECHJFC);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIIPCFFAMCH(CCONCDOKPJO LNICHECHJFC);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<AMGJKMNLMLJ> BCMHHFACDHG(CancellationToken GALLNEIFFMH);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface HFGJNCPNPMN : LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLJMECJKGKE IFAHJMEPAAP(CCONCDOKPJO PIPLPFAAPIM);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJNKCGALELO(Guid NDFJMJHNPGE, Task ONIAAOHFKKF);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface HOPKELNFEOC : LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BMNBHAPJIMJ> ADGPGMGCPIM(CCONCDOKPJO KMKPLDDNJFB);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface CPKFCHFLOKG : LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FPMKMFBIMPJ> FKGJCCMPKNJ(LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, OPCCMKNHDBC MEAFHEONFHD, CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface OPHHCOONIMC : LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMNBHAPJIMJ ONKONKGPEJN(GHBEGPNJJCK KAGCDLLONEE);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BDOJLINNIAP(string DFDAPFPPOMG);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface MPGGJDCHONJ : LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CCONCDOKPJO> AKCAIKBEDBB(CCONCDOKPJO BLIDGDGMCAP, OMNPNKGOFMO GMKEFJJNHMB, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CCONCDOKPJO> MBBHIOBAONA(CancellationToken FHGIOBPPFHG, OMNPNKGOFMO GMKEFJJNHMB);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FJBKMLGOLKO GEKIPADBFNM(KJPDDBJMGCN GCLMCFNJLCG, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FJBKMLGOLKO JEDCIOEPNKP(KJPDDBJMGCN GCLMCFNJLCG, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface AIMAIBHBLDD : LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMNBHAPJIMJ PHLNOMJAJEJ(GHBEGPNJJCK KAGCDLLONEE, AMGJKMNLMLJ HPBFPGBNKMH);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BMNBHAPJIMJ MIGHFFPFNAI(GHBEGPNJJCK JBOJCMIBDGL);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface NCJMKHJMGOJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CLMOMOAJBIA(AANHBPCJIBP EPHJHMJHNBG);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMLPJFLHPEP(AANHBPCJIBP EPHJHMJHNBG);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IEGMALKOCFL(AANHBPCJIBP EPHJHMJHNBG);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNIJBECOHND(AANHBPCJIBP EPHJHMJHNBG);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class AANHBPCJIBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly OPCCMKNHDBC FAMODAAJHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> BHOMGOBDEBO;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public LOALKKNJJLG<string> HMMDEEGOOOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8C7990", Offset = "0x8C6D90", VA = "0x1808C7990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	public AANHBPCJIBP(OPCCMKNHDBC PDGAIGHKDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x76F98A0", Offset = "0x76F8CA0", VA = "0x1876F98A0")]
	public AANHBPCJIBP PHMHDDBMJLC(string LDCKBFKFIKC, string HCPAOILCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x76F9810", Offset = "0x76F8C10", VA = "0x1876F9810")]
	public bool JKELNEJIGGP([Out] IEnumerable<KeyValuePair<string, string>> JNHMKCGGFOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x689ADC0", Offset = "0x689A1C0", VA = "0x18689ADC0")]
	public AANHBPCJIBP KGNAGLBEHAA(LOALKKNJJLG<string> HIKLLEDALJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface PPGBCHJLLOD
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool HHOINOAMAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string EGLCMDLGDBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool GEOFKHCABHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DAHEHICFMMO();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DDNNAIEPHOL HLIJCAFKIJG(long OPIAKLFIGIP);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IGFOGCPKOGI<OAOEDECEGIP, KOLIENJCING> DIOGAEDNLKD(long OPIAKLFIGIP);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IGFOGCPKOGI<OAOEDECEGIP, HGOBDFLLNNB> NHOEAJLKJFM(long OPIAKLFIGIP);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IGFOGCPKOGI<long, GLNMJLGMCJB> AMIBDPAMLJP();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CLIBDPGNPJO(long OPIAKLFIGIP, [Out] bool KHLDCBIPJPH);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> KFICJJCFFME(byte[] EJFFMDCEBKO, byte[] MHINPKLKBNP, CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface JGCOOGJEKHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool PCIOEKLCOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool EHBFLOFIICC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool GGNEGBCLNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	PFODNDLNIEM CFIDLFKBJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action ACCLPOJDLJA;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event BBJBFNANILB KPEADDGLFCE;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event BBJBFNANILB KJPCAGFAABA;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event BBJBFNANILB OPPKMNJPMKL;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<LJNFHBCPNNB, bool> CKKCGEGPLPC;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KEJIIIOCNNO();

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CKPLJOINKGK AOCJAGLKELI();

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GHFPLKGHBEI PFMDEAICBML();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<BMNBHAPJIMJ> BDHBKOJDFHN(OGAHHHAJHDC CKMDEKPOFMF);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task HFFAGDBFNIE(CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface DEEAIEEIPBM
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool GONHKPBLGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	string IPNIMPGANGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPKPHCEPOGK(Scene CNEILNANELP);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task GMNCNPLGHMK(BEBJMKGGJCL EEMCEJCAIIE, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task DMGFALDOCEF();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task DPCBALDPMDF();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface HJHDHMCCGBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	HJHCBNKLCIG GAFOLMMMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool OPDPHHOCLMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool CNLAJKNADEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool LCLJCHDJALC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool AMFABCLPIHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	int KAIPHOIDNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool AMNCMFACPDF
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool BFOFAFGJJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	int GGKEPBPIALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	int AOFPMKKPHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool MEDALIILIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool IIDAPCLKIJM
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool KDMCGJDGCPM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	float FKOECJNADCM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> FEPHPMEBHDH;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CGJHFFGEHKC IIGGDDHGOCJ(CGJHFFGEHKC BGCFKAPEFBF);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DCGPKFEJFPN(CGJHFFGEHKC CLDCJHAFFHO);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DOEJGHBMBGO();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task IIMCABLNLDK(LOALKKNJJLG<string>.HAPJMIAELKE HCLFOODOGNH, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CLAHNCIIKOH(float FEFOPHHCAEN);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GHMLILPAFBC(string BLNFCPHILBB);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<ELGDDGNBNAM> MKBHGLHLKFE();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable NAHPOGHPGHH(object NOIHGGNEIML, ELGDDGNBNAM PCJIPPNKMGE);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<HPMJLMPHAND> CDHPOKMIMEO();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KOLIENJCING HIOKGCFCPIP(IEnumerable<CGBJPDKLJAK> LLLHMPGFCPE);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EEPCGMGCIHM(int CFOOJJGCIPD);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task GMOCAEDDADG();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GCJPKJIFOPE();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool OFMBNEHKNGH();

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task LGAGIAFGNEH(CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task LJBLNCICCBJ(CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<HACOBFCCNMG> IMJEBHEPKGI(DateTime IHOMOPFMEOH, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> PMGMBJEMOBK(CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OBJDECMMADM(string LNICHECHJFC = "", float BOHBFCKDKCE = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "25")]
	BCCIAMCEKPO OHLHIADAFNH(CDGJEEKFCOI KAKFCKOFOOK, COFODAIELBI ODMLHODKOLD, HGOBDFLLNNB PGBNBAHJDBK, IEnumerable<PersistenceView> MBBEFFKJFGO, DKMGPMPCBCG PJBKIDLPJPJ);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JGJBEJKNKGI(HGOBDFLLNNB PGBNBAHJDBK);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NKEGBLDNBHD(CGBJPDKLJAK MMJPLOBEPHL, [In] BCCIAMCEKPO CHCGJBFGHLH);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task LAJNFPENAHP(HGOBDFLLNNB NLABEPFOMIJ, bool HDAFCAFFADH, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task MHNFCMKPOLO(CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MAEIOCLBLOD(long GGLEGKBAGLC, long LPKNEPKMMOO, NLMAEEICDJF CIOKBAAIBPO, GNODDIAAKFD DJEDMBOBINN, BIPJJKGGCNE MOCEEFBBOOH, AFDCCJMMFPI? OIOCKBBMOLC, HKHNPHNDIJN? LGDDOKOLPPN);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void NPGAOEMBGIG(long GGLEGKBAGLC, long LPKNEPKMMOO, HKHNPHNDIJN? LGDDOKOLPPN);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void GJKCIMDNPPI(PersistenceView HGHMJIMBFFF);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool LAHMPDJEPGE(PersistenceView CICGDGCLMFK);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool FIILNLLHJGN(CGBJPDKLJAK MMJPLOBEPHL, KFBEOIPGGLH ABJKAJCHFGG, [Out] DMKLLCNLMLC BGEMLFCEMOK);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task HCJMADIBCGI(CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void HPAPFOHBIOA();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable EFOEEECFMAH();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void NKFIIKGOEFM(HGOBDFLLNNB NLABEPFOMIJ, KFBEOIPGGLH ABJKAJCHFGG);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> FEMKNFDJDOP(HCMOGHGOBGB NPGFBLNGFLA, CancellationToken FHGIOBPPFHG, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void KJAHPNMPFJP(CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<GCEMIOFDIKP> CBPIKFALCDA(HAHCMCAGNIO BLIDGDGMCAP);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<NLMAEEICDJF> JBHOOKKGBOL(long GGLEGKBAGLC, bool ANCCNIIBHFK, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<GNODDIAAKFD> BCBGMPKLBGJ(long GGLEGKBAGLC, long LPKNEPKMMOO, long ENIGCGECECI, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<GNODDIAAKFD> LDODICLHKDO(long GGLEGKBAGLC, long LPKNEPKMMOO, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<CDLAJKKPEIP> DJPECKAEEPB(string MEHAKHCKJPP, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<CDLAJKKPEIP> CIOHIFPNPHE(string MEHAKHCKJPP, long GGLEGKBAGLC, long LPKNEPKMMOO, string EHJCFMNPKKH, PEPHOBCFPJA.IALAPHHGNMM JOMOCOIMIGC, PEPHOBCFPJA.IALAPHHGNMM MHINPKLKBNP, int ELEAAIEFPFE);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool PCHIMNIFJKF();

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool LCLLPJGLFHF();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool HKPLJPEHMAO(IEnumerable<DMKLLCNLMLC> PMDOBNKACOE);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void LGNBDCGEMFO(List<GameObject> MKKALDBPJJL);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "52")]
	float MKPHFPPBJPF();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task<Scene> GHBELNGKBJL(string KAJDLHPACAD, LoadSceneMode FOKINDFAEDI, bool OIBFECHFNCC, LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void ALGEPKJJOIJ();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void PEKMMMBABMF(bool JCDOMELOGPP);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void ELNONPEMDME();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void FGLKCNHBGJJ();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void OBPBPENKGCL(OPCCMKNHDBC NFGGJAGKIGE);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task OGPDLDMKCDK(LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task LLKIPFFIBLE(LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "70")]
	Task GBAOPAPCNKP(LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task GALABNCPMHD(LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "72")]
	IDisposable MFKNPCCIIIG();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "73")]
	NIAOGPBFGOC KMDPEFKCIJB();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task HCGNBNLIGOE(CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface NIAOGPBFGOC
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MHHGJJPLLAF(CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FLCIAGABPLD(CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct BCCIAMCEKPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> PAMIMEKNNDP;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum HACOBFCCNMG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct CDGJEEKFCOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string KHIOJHOKJLE;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface HJHCBNKLCIG
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	OPCCMKNHDBC DPEEOAIEBMC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	NLMAEEICDJF LACKPHJPKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	BEANCEBHDPC FFHBAAPCGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool BNLAMFPKGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool ECLPPDPCCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	int EOPHBJLKEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action MGDMNENIBPF;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> PAEJNFMNBMO;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IPJJNIMPALO();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.POKDDKNCBCM> CMFKJHKBOBE(long OPIAKLFIGIP, [Optional] CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<DGJLHEGBBOE> OFDBBKCODIH();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task MJMDMKAFELG();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(OPCCMKNHDBC, PFODNDLNIEM) OIAFJKDBEGF();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GJHHDDAHPMJ BGIKPKKCCND();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FDFNIHFANBB(long OPIAKLFIGIP);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CPJNGGKPLPA(OPCCMKNHDBC PDGAIGHKDCM, Matchmaking.LICDBLACJHA CEDDFJCBLGM, (int Major, int? Minor)? MMEACNFBMEM);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface IBEECJFKBNI
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PFFIDOAOHIN([Out] IEnumerable<int> NFKBJPAENGH);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EJHBPGNJFOE(PALGLKMIOIC CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGBLEDBPNFO(PALGLKMIOIC CMNJCPJBHGE);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface PIADLPFDFGH
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NPIPNCKMDGI(BMNBHAPJIMJ OAFNHPEIMDK);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface HFIFNFAINFO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MMIGONDOPLE(MDLNANPNEJA.PJGINHCNAPB DGPMLMKLKOP);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHADPAAOMOE(MDLNANPNEJA.PJGINHCNAPB DGPMLMKLKOP);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface KAINKLBPDLA : HFIFNFAINFO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMNBHAPJIMJ GCAKAKJFNFN(GHBEGPNJJCK JBOJCMIBDGL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface GGPPIGPEPAI : HFIFNFAINFO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMNBHAPJIMJ ONKONKGPEJN(GHBEGPNJJCK JHJHBOANJNF);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface DDNNAIEPHOL
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ABNAGONECLM<BEBJMKGGJCL, PJPEMJHFJLC>> KHICBNCDJEB(string EHJCFMNPKKH, long OPIAKLFIGIP, long? GGLEGKBAGLC, long? LPKNEPKMMOO, KEGPANADHNE.AGLEJHOOMJP NIJPDKBAALP, CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface IGFOGCPKOGI<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ABNAGONECLM<DPJCBEABHHK<TData>, PJPEMJHFJLC>> FODHDNADIEE(TGetDataArg FJIKACGIPBH, CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class DMNIEJDPHMA : FGMEGFCAHOO, JGCOOGJEKHJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct IAFEKMNHHHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder<BMNBHAPJIMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public DMNIEJDPHMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public OGAHHHAJHDC autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter<BMNBHAPJIMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7703B70", Offset = "0x7702F70", VA = "0x187703B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7703DF0", Offset = "0x77031F0", VA = "0x187703DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct AKIALPBOOMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public DMNIEJDPHMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x76F9D30", Offset = "0x76F9130", VA = "0x1876F9D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x76F9F60", Offset = "0x76F9360", VA = "0x1876F9F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class GCKMNNGDCLG : IEnumerable<LEKKAGKCCHD>, IEnumerable, IEnumerator<LEKKAGKCCHD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private LEKKAGKCCHD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public DMNIEJDPHMA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		private LEKKAGKCCHD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xADC3A0", Offset = "0xADB7A0", VA = "0x180ADC3A0")]
		[DebuggerHidden]
		public GCKMNNGDCLG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7700EA0", Offset = "0x77002A0", VA = "0x187700EA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7701300", Offset = "0x7700700", VA = "0x187701300", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7701250", Offset = "0x7700650", VA = "0x187701250", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LEKKAGKCCHD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7701250", Offset = "0x7700650", VA = "0x187701250", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource LAJEIBBAFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly CGJHFFGEHKC CLDCJHAFFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool IOFECLNHDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private INCIAIKALNG NAKOOEIPDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private bool IOIPEMIJJBJ;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public HCMOGHGOBGB KCPGHJIOEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8CAEF0", Offset = "0x8CA2F0", VA = "0x1808CAEF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8CAEB0", Offset = "0x8CA2B0", VA = "0x1808CAEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public DCFACMMFOLA EHIEHCJDAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8CAEC0", Offset = "0x8CA2C0", VA = "0x1808CAEC0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8CAF30", Offset = "0x8CA330", VA = "0x1808CAF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public HJHDHMCCGBJ EEGJAFGKABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8CAEE0", Offset = "0x8CA2E0", VA = "0x1808CAEE0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8CAED0", Offset = "0x8CA2D0", VA = "0x1808CAED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public DEEAIEEIPBM AGEOCKPOFAN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8CAF00", Offset = "0x8CA300", VA = "0x1808CAF00", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8CAF40", Offset = "0x8CA340", VA = "0x1808CAF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public KAINKLBPDLA AHFAALCDBIA
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8CAF20", Offset = "0x8CA320", VA = "0x1808CAF20", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8CAF10", Offset = "0x8CA310", VA = "0x1808CAF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public GGPPIGPEPAI ADHJJLGBHPC
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9F0", Offset = "0x8CEDF0", VA = "0x1808CF9F0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8CFAC0", Offset = "0x8CEEC0", VA = "0x1808CFAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public KDKGOMPODOP KBJFOBDGIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8CFAE0", Offset = "0x8CEEE0", VA = "0x1808CFAE0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA90", Offset = "0x8CEE90", VA = "0x1808CFA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public LHHDEKNNILG ELKCKOOBCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA20", Offset = "0x8CEE20", VA = "0x1808CFA20", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB90", Offset = "0x8CEF90", VA = "0x1808CFB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public BIFNOFKPNFP OKNHDPPCOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9A4A00", Offset = "0x9A3E00", VA = "0x1809A4A00", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xE97840", Offset = "0xE96C40", VA = "0x180E97840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public NJJOBPIEEBD KADHBGDODMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB40", Offset = "0x8CEF40", VA = "0x1808CFB40", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB70", Offset = "0x8CEF70", VA = "0x1808CFB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public OFAIDDBHGII EMPJMFOELCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA8C290", Offset = "0xA8B690", VA = "0x180A8C290", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA8BFE0", Offset = "0xA8B3E0", VA = "0x180A8BFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public KBJHGCHDPOA AHNIFFDMDOM
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8CDCD0", Offset = "0x8CD0D0", VA = "0x1808CDCD0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8CDD20", Offset = "0x8CD120", VA = "0x1808CDD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public EKHPCFNCOAH ECMBAEHOPGK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x99A220", Offset = "0x999620", VA = "0x18099A220", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA9C280", Offset = "0xA9B680", VA = "0x180A9C280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public PONAGHIDMCH OAOGKJJCOBI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x97C760", Offset = "0x97BB60", VA = "0x18097C760", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x97C770", Offset = "0x97BB70", VA = "0x18097C770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public DJDKBPJOFLH JHCBDHMINPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9EBBE0", Offset = "0x9EAFE0", VA = "0x1809EBBE0", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xD18120", Offset = "0xD17520", VA = "0x180D18120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public IKIAIKFLBIM KBKGMCHCCOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9EBBD0", Offset = "0x9EAFD0", VA = "0x1809EBBD0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x994500", Offset = "0x993900", VA = "0x180994500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public HFGJNCPNPMN IMJHACNBLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9EB9E0", Offset = "0x9EADE0", VA = "0x1809EB9E0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xAF8470", Offset = "0xAF7870", VA = "0x180AF8470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public HOPKELNFEOC ADGPGMGCPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8CDC60", Offset = "0x8CD060", VA = "0x1808CDC60", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8CDD00", Offset = "0x8CD100", VA = "0x1808CDD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public CPKFCHFLOKG IDFCLFODCDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9EBB80", Offset = "0x9EAF80", VA = "0x1809EBB80", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xF769F0", Offset = "0xF75DF0", VA = "0x180F769F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public MPGGJDCHONJ DFOMMLOHLDF
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9EBB70", Offset = "0x9EAF70", VA = "0x1809EBB70", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xD9D820", Offset = "0xD9CC20", VA = "0x180D9D820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public OPHHCOONIMC IDDCJOHEPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x993240", Offset = "0x992640", VA = "0x180993240", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x993090", Offset = "0x992490", VA = "0x180993090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public AIMAIBHBLDD DAMEKGEPNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9EBA90", Offset = "0x9EAE90", VA = "0x1809EBA90", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xF769D0", Offset = "0xF75DD0", VA = "0x180F769D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public NCJMKHJMGOJ HIFEIHAMPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x911AB0", Offset = "0x910EB0", VA = "0x180911AB0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA6D020", Offset = "0xA6C420", VA = "0x180A6D020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IBEECJFKBNI LDHKOHPHNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x940600", Offset = "0x93FA00", VA = "0x180940600", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xF76B30", Offset = "0xF75F30", VA = "0x180F76B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public BIOGHNKCPHL NLPAFCCKFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9774E0", Offset = "0x9768E0", VA = "0x1809774E0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x976F50", Offset = "0x976350", VA = "0x180976F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public BFPGCNENHGP NGMCCIGDJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x979E80", Offset = "0x979280", VA = "0x180979E80", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x977000", Offset = "0x976400", VA = "0x180977000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public PPGBCHJLLOD MHINAOKCFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x991150", Offset = "0x990550", VA = "0x180991150", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x98EA80", Offset = "0x98DE80", VA = "0x18098EA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public FGFDBJOOGKL AEFFKMOJFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9EBB00", Offset = "0x9EAF00", VA = "0x1809EBB00", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public NNCDHDGNJDP KDHLLHEMLGI
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9EBB10", Offset = "0x9EAF10", VA = "0x1809EBB10", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public MOAJKCFHBNI KJMACBPIEKI
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9EBB20", Offset = "0x9EAF20", VA = "0x1809EBB20", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public OPACFMPIKLJ LEFMBOHEEGC
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9EBB30", Offset = "0x9EAF30", VA = "0x1809EBB30", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public JHJPFICBPAM LADKALFLDHG
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x985B20", Offset = "0x984F20", VA = "0x180985B20", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public PFODNDLNIEM CFIDLFKBJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xEDF750", Offset = "0xEDEB50", VA = "0x180EDF750", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xF76A70", Offset = "0xF75E70", VA = "0x180F76A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private bool IIOEMBGLBOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x76FDFF0", Offset = "0x76FD3F0", VA = "0x1876FDFF0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private bool CPEFPHMMIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x76FD670", Offset = "0x76FCA70", VA = "0x1876FD670", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private bool KNKNCONKFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x11A6F20", Offset = "0x11A6320", VA = "0x1811A6F20", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private CancellationToken JMCJCCLHGED
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x76FDA90", Offset = "0x76FCE90", VA = "0x1876FDA90", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private CGJHFFGEHKC HNLHLOGLLDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private bool OAKOICOOIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x11A6F20", Offset = "0x11A6320", VA = "0x1811A6F20", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x11A7390", Offset = "0x11A6790", VA = "0x1811A7390", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action DOLADFPNGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x76FD5C0", Offset = "0x76FC9C0", VA = "0x1876FD5C0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x76FE0B0", Offset = "0x76FD4B0", VA = "0x1876FE0B0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event BBJBFNANILB IEFBGBNEBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x76FDA30", Offset = "0x76FCE30", VA = "0x1876FDA30", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x76FDE00", Offset = "0x76FD200", VA = "0x1876FDE00", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event BBJBFNANILB DNAKFKGLAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x76FDD40", Offset = "0x76FD140", VA = "0x1876FDD40", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x76FD9D0", Offset = "0x76FCDD0", VA = "0x1876FD9D0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event BBJBFNANILB GABJHCNCFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x76FD910", Offset = "0x76FCD10", VA = "0x1876FD910", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x76FE050", Offset = "0x76FD450", VA = "0x1876FE050", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<LJNFHBCPNNB, bool> CIKNDIGIGNH
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x76FDE60", Offset = "0x76FD260", VA = "0x1876FDE60", Slot = "48")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x76FDDA0", Offset = "0x76FD1A0", VA = "0x1876FDDA0", Slot = "49")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0xF76A70", Offset = "0xF75E70", VA = "0x180F76A70", Slot = "39")]
	public void JPDBALIPJHM(PFODNDLNIEM NAPMDNNFBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x76FE110", Offset = "0x76FD510", VA = "0x1876FE110")]
	[UnityEngine.Scripting.Preserve]
	internal DMNIEJDPHMA([CNGCCDLPGOD(null)] CGJHFFGEHKC CLDCJHAFFHO, [CNGCCDLPGOD(null)] HCMOGHGOBGB NPGFBLNGFLA, [CNGCCDLPGOD(null)] DCFACMMFOLA FFGPDEIMDFC, [CNGCCDLPGOD(null)] HJHDHMCCGBJ IHMGMGMEKPB, [CNGCCDLPGOD(null)] DEEAIEEIPBM AOMODJKMBHD, [CNGCCDLPGOD(null)] KAINKLBPDLA DOHDOJDMGBE, [CNGCCDLPGOD(null)] GGPPIGPEPAI LCGACHEIPAL, [CNGCCDLPGOD(null)] KDKGOMPODOP EJHFGMBCHCF, [CNGCCDLPGOD(null)] LHHDEKNNILG GMCCGJOCKOK, [CNGCCDLPGOD(null)] BIFNOFKPNFP HCGMJGEFGFC, [CNGCCDLPGOD(null)] NJJOBPIEEBD GGPLCIOHPHD, [CNGCCDLPGOD(null)] OFAIDDBHGII ABBFNBJIPGL, [CNGCCDLPGOD(null)] KBJHGCHDPOA HKPGINJDHPE, [CNGCCDLPGOD(null)] EKHPCFNCOAH JJPFBNGEBDF, [CNGCCDLPGOD(null)] PONAGHIDMCH CMJDNJADPCG, [CNGCCDLPGOD(null)] DJDKBPJOFLH ODJGBOALKHO, [CNGCCDLPGOD(null)] IKIAIKFLBIM HJCDAJNLPGD, [CNGCCDLPGOD(null)] HFGJNCPNPMN PCFGIEPNHLN, [CNGCCDLPGOD(null)] HOPKELNFEOC BMPAMGKEAMB, [CNGCCDLPGOD(null)] CPKFCHFLOKG GPCFMPGNCDE, [CNGCCDLPGOD(null)] OPHHCOONIMC LFLDOJBNIBG, [CNGCCDLPGOD(null)] MPGGJDCHONJ PDGJKDOGMEJ, [CNGCCDLPGOD(null)] AIMAIBHBLDD MENNAMHALEP, [CNGCCDLPGOD(null)] NCJMKHJMGOJ MEPEOJLBCCL, [CNGCCDLPGOD(null)] IBEECJFKBNI EJKJINEIEFK, [CNGCCDLPGOD(null)] BFPGCNENHGP JAGODFHKNAI, [CNGCCDLPGOD(null)] PPGBCHJLLOD CLFPKOLNGKK, [CNGCCDLPGOD(null)] FGFDBJOOGKL CGBAOEHIIHA, [CNGCCDLPGOD(null)] NNCDHDGNJDP FDGPHHEDMFN, [CNGCCDLPGOD(null)] MOAJKCFHBNI GEALOMHNOHA, [CNGCCDLPGOD(null)] OPACFMPIKLJ FFOPLHPMAIN, [CNGCCDLPGOD(null)] JHJPFICBPAM EJAPPCPFCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x76FDF40", Offset = "0x76FD340", VA = "0x1876FDF40")]
	private void OOJJEJPOBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x76FD6F0", Offset = "0x76FCAF0", VA = "0x1876FD6F0", Slot = "59")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x76FD620", Offset = "0x76FCA20", VA = "0x1876FD620", Slot = "53")]
	private void CJOFMKLFGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x76FDBA0", Offset = "0x76FCFA0", VA = "0x1876FDBA0", Slot = "54")]
	private CKPLJOINKGK LBHAOMBHCAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x76FD880", Offset = "0x76FCC80", VA = "0x1876FD880", Slot = "55")]
	private GHFPLKGHBEI EKNGKMDNGOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x76FDC30", Offset = "0x76FD030", VA = "0x1876FDC30", Slot = "56")]
	[AsyncStateMachine(typeof(IAFEKMNHHHK))]
	private Task<BMNBHAPJIMJ> LHKPHJGHBHG(OGAHHHAJHDC KGCIEMPDBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x76FDAB0", Offset = "0x76FCEB0", VA = "0x1876FDAB0", Slot = "57")]
	[AsyncStateMachine(typeof(AKIALPBOOMG))]
	private Task IMCMMBHLNGO(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x76FDEC0", Offset = "0x76FD2C0", VA = "0x1876FDEC0")]
	[IteratorStateMachine(typeof(GCKMNNGDCLG))]
	private IEnumerable<LEKKAGKCCHD> OJCFFFENKMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x76FD970", Offset = "0x76FCD70", VA = "0x1876FD970")]
	[CompilerGenerated]
	private void GDFOOAEJJMK(LEKKAGKCCHD HFEBDCHJGBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class JBDPMABEOCO : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x12FC7B0", Offset = "0x12FBBB0", VA = "0x1812FC7B0")]
	public JBDPMABEOCO(string LNICHECHJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class KFEKGEMNNDP : KNEAEAOFAOK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct HNDOBKEOPEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KFEKGEMNNDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7702E00", Offset = "0x7702200", VA = "0x187702E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7703140", Offset = "0x7702540", VA = "0x187703140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly FGMEGFCAHOO EKABOCOCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly HJHDHMCCGBJ IHMGMGMEKPB;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8D5E30", Offset = "0x8D5230", VA = "0x1808D5E30")]
	public KFEKGEMNNDP(FGMEGFCAHOO EKABOCOCDBK, HJHDHMCCGBJ IHMGMGMEKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x770B490", Offset = "0x770A890", VA = "0x18770B490", Slot = "4")]
	[AsyncStateMachine(typeof(HNDOBKEOPEE))]
	public Task<bool> OKEDDPHFJMA(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x770B3B0", Offset = "0x770A7B0", VA = "0x18770B3B0")]
	[CompilerGenerated]
	private object MIEHEMJFKGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class MIFFOFFKMGE : KNEAEAOFAOK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct KFJKMHIOIPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public MIFFOFFKMGE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x770B580", Offset = "0x770A980", VA = "0x18770B580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x770BCC0", Offset = "0x770B0C0", VA = "0x18770BCC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly FGMEGFCAHOO EKABOCOCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly HJHDHMCCGBJ IHMGMGMEKPB;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private HJHCBNKLCIG GAFOLMMMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x770E1D0", Offset = "0x770D5D0", VA = "0x18770E1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x8D5E30", Offset = "0x8D5230", VA = "0x1808D5E30")]
	public MIFFOFFKMGE(FGMEGFCAHOO EKABOCOCDBK, HJHDHMCCGBJ IHMGMGMEKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x770E220", Offset = "0x770D620", VA = "0x18770E220", Slot = "4")]
	[AsyncStateMachine(typeof(KFJKMHIOIPH))]
	public Task<bool> OKEDDPHFJMA(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x770E0F0", Offset = "0x770D4F0", VA = "0x18770E0F0")]
	[CompilerGenerated]
	private object FBOMLJOAODN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class LABLHJKFIMP : KNEAEAOFAOK
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class BGDIMKNIBLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public LABLHJKFIMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public DGJLHEGBBOE result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public OPCCMKNHDBC newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public BGDIMKNIBLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x76FA0D0", Offset = "0x76F94D0", VA = "0x1876FA0D0")]
		internal object GPKDMMGCNEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x76F9FC0", Offset = "0x76F93C0", VA = "0x1876F9FC0")]
		internal object DDBMGPLIFGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x76FA030", Offset = "0x76F9430", VA = "0x1876FA030")]
		internal object EBGJLJMKDGK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct OECKLLAEGBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public LABLHJKFIMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private BGDIMKNIBLK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<DGJLHEGBBOE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7710130", Offset = "0x770F530", VA = "0x187710130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7710AD0", Offset = "0x770FED0", VA = "0x187710AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly FGMEGFCAHOO EKABOCOCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly HJHDHMCCGBJ IHMGMGMEKPB;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private HJHCBNKLCIG GAFOLMMMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x770D880", Offset = "0x770CC80", VA = "0x18770D880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8D5E30", Offset = "0x8D5230", VA = "0x1808D5E30")]
	public LABLHJKFIMP(FGMEGFCAHOO EKABOCOCDBK, HJHDHMCCGBJ IHMGMGMEKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x770D8D0", Offset = "0x770CCD0", VA = "0x18770D8D0", Slot = "4")]
	[AsyncStateMachine(typeof(OECKLLAEGBK))]
	public Task<bool> OKEDDPHFJMA(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal interface KNEAEAOFAOK
{
	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> OKEDDPHFJMA(CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct MJEAAAFDIJH
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class IHFNNCMGLGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public FGMEGFCAHOO manager;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public IHFNNCMGLGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x77046E0", Offset = "0x7703AE0", VA = "0x1877046E0")]
		internal Task EBBLLJOFJGK(CancellationToken cancellationToken, int roomTotalVersion, AECOPHFIFAP localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct NMDDFHFNMHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public MJEAAAFDIJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private OGAHHHAJHDC <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<HACOBFCCNMG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private TaskAwaiter<BMNBHAPJIMJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x770FAB0", Offset = "0x770EEB0", VA = "0x18770FAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7710040", Offset = "0x770F440", VA = "0x187710040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct FBGAIHJFGPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public MJEAAAFDIJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x77003C0", Offset = "0x76FF7C0", VA = "0x1877003C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x77006E0", Offset = "0x76FFAE0", VA = "0x1877006E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly CancellationToken FHGIOBPPFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly FGMEGFCAHOO KCLPDCIIPCH;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private HCMOGHGOBGB KCPGHJIOEIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x770E8B0", Offset = "0x770DCB0", VA = "0x18770E8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private HJHDHMCCGBJ EEGJAFGKABI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x770E350", Offset = "0x770D750", VA = "0x18770E350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private HJHCBNKLCIG GAFOLMMMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x770E900", Offset = "0x770DD00", VA = "0x18770E900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private BIFNOFKPNFP OKNHDPPCOAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x770E5B0", Offset = "0x770D9B0", VA = "0x18770E5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2331A70", Offset = "0x2330E70", VA = "0x182331A70")]
	public MJEAAAFDIJH(CancellationToken FHGIOBPPFHG, FGMEGFCAHOO KCLPDCIIPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x770E600", Offset = "0x770DA00", VA = "0x18770E600")]
	public static IGHOGOBMLLF EHJJLFHAKLE(FGMEGFCAHOO KCLPDCIIPCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x770E980", Offset = "0x770DD80", VA = "0x18770E980")]
	[AsyncStateMachine(typeof(NMDDFHFNMHO))]
	public Task<bool> PKMNDLFOFHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x770E3A0", Offset = "0x770D7A0", VA = "0x18770E3A0")]
	private bool APODKAIJAJF([Out] OGAHHHAJHDC KGCIEMPDBFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x770E6B0", Offset = "0x770DAB0", VA = "0x18770E6B0")]
	[AsyncStateMachine(typeof(FBGAIHJFGPD))]
	private Task EKFBEKEGBGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x770E780", Offset = "0x770DB80", VA = "0x18770E780")]
	private Task<HACOBFCCNMG> HHHEJFOPHBL(OGAHHHAJHDC MKDGGBONNPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct MLJMECJKGKE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly PONAGHIDMCH CMJDNJADPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Guid NDFJMJHNPGE;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Task<(BMNBHAPJIMJ, Task)> DKOPFBHADKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x770EA90", Offset = "0x770DE90", VA = "0x18770EA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x47A75A0", Offset = "0x47A69A0", VA = "0x1847A75A0")]
	public MLJMECJKGKE(PONAGHIDMCH CMJDNJADPCG, Guid NDFJMJHNPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x770EC30", Offset = "0x770E030", VA = "0x18770EC30")]
	public TaskAwaiter<(BMNBHAPJIMJ, Task)> PFIDLIKIIJL()
	{
		return default(TaskAwaiter<(BMNBHAPJIMJ, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x770EB60", Offset = "0x770DF60", VA = "0x18770EB60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct CBEENLKBONB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly TaskCompletionSource<(BMNBHAPJIMJ, Task)> ABALEOLEOOP;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public Task<(BMNBHAPJIMJ, Task)> DKOPFBHADKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x76FA250", Offset = "0x76F9650", VA = "0x1876FA250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x76FA410", Offset = "0x76F9810", VA = "0x1876FA410")]
	public CBEENLKBONB(TimeSpan NIFKBJPBAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x76FA370", Offset = "0x76F9770", VA = "0x1876FA370")]
	public void FHKMLNAAOMF(Task ONIAAOHFKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x76FA290", Offset = "0x76F9690", VA = "0x1876FA290")]
	public void AOJDPDJPIPC(BMNBHAPJIMJ OAFNHPEIMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x76FA320", Offset = "0x76F9720", VA = "0x1876FA320")]
	public void FHDPPDFPKNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x76FA1C0", Offset = "0x76F95C0", VA = "0x1876FA1C0")]
	internal void AFHKJOMFBBD(string LNICHECHJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class IFALHEJNGHP
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class NJFFBNAFCCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public GNODDIAAKFD subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public NJFFBNAFCCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x770FA80", Offset = "0x770EE80", VA = "0x18770FA80")]
		internal bool HMDGKMPNGDC(BEANCEBHDPC s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x77044A0", Offset = "0x77038A0", VA = "0x1877044A0")]
	public static FPMKMFBIMPJ KOPOAAAOIOD(long KOPAGGCCKKF, long LPKNEPKMMOO, string MEHAKHCKJPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7704530", Offset = "0x7703930", VA = "0x187704530")]
	public static FPMKMFBIMPJ KOPOAAAOIOD(long KOPAGGCCKKF, long LPKNEPKMMOO, OAOEDECEGIP EJFFMDCEBKO, long ENIGCGECECI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x77040E0", Offset = "0x77034E0", VA = "0x1877040E0")]
	public static FPMKMFBIMPJ KOPOAAAOIOD(GCEMIOFDIKP ILIENPCMBPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7704270", Offset = "0x7703670", VA = "0x187704270")]
	public static FPMKMFBIMPJ KOPOAAAOIOD(NLMAEEICDJF MCKBOBOEFOP, GNODDIAAKFD ICJPBDGJLFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7703FF0", Offset = "0x77033F0", VA = "0x187703FF0")]
	public static FPMKMFBIMPJ FMODDAKFKMA(this FPMKMFBIMPJ PBJNGGAILNG, NLMAEEICDJF LCFHEMNKKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7703E60", Offset = "0x7703260", VA = "0x187703E60")]
	public static FPMKMFBIMPJ ANOPMOOOHDG(this FPMKMFBIMPJ PBJNGGAILNG, GNODDIAAKFD JIJNHBMOPDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RecRoom.NoEngine.Common.Preserve]
internal class JNLLFCAFCDN : LHHDEKNNILG, LEKKAGKCCHD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct OHDJHHAJNPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public JNLLFCAFCDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7710B40", Offset = "0x770FF40", VA = "0x187710B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x77111D0", Offset = "0x77105D0", VA = "0x1877111D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly PALGLKMIOIC DFNFKGEAADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private string BBCKDHKGOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Task LBPNDMDIKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private FGMEGFCAHOO EKABOCOCDBK;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool BLJANFPKKIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7707250", Offset = "0x7706650", VA = "0x187707250", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Task OPCFJBCLCPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7707280", Offset = "0x7706680", VA = "0x187707280", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8C7DD0", Offset = "0x8C71D0", VA = "0x1808C7DD0", Slot = "7")]
	public void OOJJEJPOBFE(FGMEGFCAHOO EKABOCOCDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7706FD0", Offset = "0x77063D0", VA = "0x187706FD0", Slot = "6")]
	public void DGKHDMMCDLJ(Task LCFJPCOMAFL, string CLBKIJMMEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7707130", Offset = "0x7706530", VA = "0x187707130")]
	[AsyncStateMachine(typeof(OHDJHHAJNPI))]
	private Task JMKAGPHHGGE(Task EPPAELGIDII, string CLBKIJMMEJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7707310", Offset = "0x7706710", VA = "0x187707310")]
	public JNLLFCAFCDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class EGKPCKLLFAM : BIOGHNKCPHL, LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool ECBPGEOPFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private HOEBJIIEGFO PEJJGIOAGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private HCMOGHGOBGB NPGFBLNGFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private BFPGCNENHGP JAGODFHKNAI;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public HOEBJIIEGFO MKEAELGMPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x77001D0", Offset = "0x76FF5D0", VA = "0x1877001D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7700240", Offset = "0x76FF640", VA = "0x187700240", Slot = "7")]
	public void OOJJEJPOBFE(FGMEGFCAHOO EKABOCOCDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x76FFFE0", Offset = "0x76FF3E0", VA = "0x1876FFFE0", Slot = "5")]
	public void DOCDNDBJHKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7700190", Offset = "0x76FF590", VA = "0x187700190", Slot = "6")]
	public void LAJEJDIFPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x76FFF20", Offset = "0x76FF320", VA = "0x1876FFF20")]
	private Task AMBDGGEHHNC(OBHGDFHKAIC PGHMIFOEHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7700190", Offset = "0x76FF590", VA = "0x187700190", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public EGKPCKLLFAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class DCAFAKCONGH : BFPGCNENHGP
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class FFHCHGAMKJB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly AJCHOFIOKBP OMPDJEGMEOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly string LDCKBFKFIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly T EKFBHIJFHMA;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public T GFHLLJBPNAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x9617B0", Offset = "0x960BB0", VA = "0x1809617B0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x96FE20", Offset = "0x96F220", VA = "0x18096FE20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x40729F0", Offset = "0x4071DF0", VA = "0x1840729F0")]
		public FFHCHGAMKJB(AJCHOFIOKBP OMPDJEGMEOI, string LDCKBFKFIKC, T EKFBHIJFHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x40720A0", Offset = "0x40714A0", VA = "0x1840720A0")]
		private void FOAPFGHGMAI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly AJCHOFIOKBP OMPDJEGMEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly FFHCHGAMKJB<TimeSpan> FPJGFDPLFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly FFHCHGAMKJB<TimeSpan> IIAMNABEFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly FFHCHGAMKJB<TimeSpan> DKPBLMJCNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly FFHCHGAMKJB<TimeSpan> ICEPFJCGPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly FFHCHGAMKJB<bool> OIDPIIOMKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly FFHCHGAMKJB<bool> LHOHALMCBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly FFHCHGAMKJB<bool> AKBOJNFIGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly FFHCHGAMKJB<int> NJHADPBMEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly FFHCHGAMKJB<bool> FMMAMIBLIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly FFHCHGAMKJB<bool> LBLHDJOCDLC;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public TimeSpan EMNICBDMKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x76FB820", Offset = "0x76FAC20", VA = "0x1876FB820", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public TimeSpan JAMMHNIGNBL
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x76FB7A0", Offset = "0x76FABA0", VA = "0x1876FB7A0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public TimeSpan OGMFDDIOPNF
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x76FB960", Offset = "0x76FAD60", VA = "0x1876FB960", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public TimeSpan JPNKNFAIKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x76FB7E0", Offset = "0x76FABE0", VA = "0x1876FB7E0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool BALBNLJPOOK
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x76FB860", Offset = "0x76FAC60", VA = "0x1876FB860", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool OJIGLHKHEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x76FB8E0", Offset = "0x76FACE0", VA = "0x1876FB8E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool HILDKJINKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x76FB8A0", Offset = "0x76FACA0", VA = "0x1876FB8A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public int DOACHPNMDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x76FB920", Offset = "0x76FAD20", VA = "0x1876FB920", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool OIEBNPOIPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x76FB760", Offset = "0x76FAB60", VA = "0x1876FB760", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool IDBNGNOLNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x76FB720", Offset = "0x76FAB20", VA = "0x1876FB720", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x76FB9A0", Offset = "0x76FADA0", VA = "0x1876FB9A0")]
	[UnityEngine.Scripting.Preserve]
	public DCAFAKCONGH([CNGCCDLPGOD(null)] AJCHOFIOKBP OMPDJEGMEOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[UnityEngine.Scripting.Preserve]
internal class EAGAMPMFKFA : NJJOBPIEEBD, LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class JOJCINHFIND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AFMCCHKAGHJ roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JOJCINHFIND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x770ADA0", Offset = "0x770A1A0", VA = "0x18770ADA0")]
		internal object ALPCDIILMNM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action ACCLPOJDLJA
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x76FFBF0", Offset = "0x76FEFF0", VA = "0x1876FFBF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x76FF870", Offset = "0x76FEC70", VA = "0x1876FF870", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event BBJBFNANILB KPEADDGLFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x76FF9B0", Offset = "0x76FEDB0", VA = "0x1876FF9B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x76FFAA0", Offset = "0x76FEEA0", VA = "0x1876FFAA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event BBJBFNANILB KJPCAGFAABA
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x76FF910", Offset = "0x76FED10", VA = "0x1876FF910", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x76FFC90", Offset = "0x76FF090", VA = "0x1876FFC90", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event BBJBFNANILB OPPKMNJPMKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x76FFE80", Offset = "0x76FF280", VA = "0x1876FFE80", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x76FFDE0", Offset = "0x76FF1E0", VA = "0x1876FFDE0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<LJNFHBCPNNB, bool> CKKCGEGPLPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x76FFD30", Offset = "0x76FF130", VA = "0x1876FFD30", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x76FFB40", Offset = "0x76FEF40", VA = "0x1876FFB40", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "19")]
	public void OOJJEJPOBFE(FGMEGFCAHOO EKABOCOCDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x76FF620", Offset = "0x76FEA20", VA = "0x1876FF620", Slot = "14")]
	public void CMLNMCBMKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x76FF840", Offset = "0x76FEC40", VA = "0x1876FF840", Slot = "15")]
	public void FGMLOENPFFD(AFMCCHKAGHJ JOIHKBAHMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x76FF5F0", Offset = "0x76FE9F0", VA = "0x1876FF5F0", Slot = "16")]
	public void CFIOLPOAPDF(AFMCCHKAGHJ JOIHKBAHMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x76FF810", Offset = "0x76FEC10", VA = "0x1876FF810", Slot = "17")]
	public void FELDNLHJAFA(AFMCCHKAGHJ JOIHKBAHMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x76FFA50", Offset = "0x76FEE50", VA = "0x1876FFA50", Slot = "18")]
	public void HLNFKHDKIFB(LJNFHBCPNNB LNABBPEHJIJ, bool BIDPAAHCAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x76FF430", Offset = "0x76FE830", VA = "0x1876FF430")]
	private void CAHJKFNDGBI(BBJBFNANILB PCJIPPNKMGE, AFMCCHKAGHJ JOIHKBAHMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public EAGAMPMFKFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[UnityEngine.Scripting.Preserve]
internal class IIGLMKFKKFB : OFAIDDBHGII, LEKKAGKCCHD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct JMKLEBLEAFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public IIGLMKFKKFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7706080", Offset = "0x7705480", VA = "0x187706080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7706600", Offset = "0x7705A00", VA = "0x187706600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct HDHKJCILCLI : IAsyncStateMachine
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
		public IIGLMKFKKFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7702690", Offset = "0x7701A90", VA = "0x187702690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x7702D30", Offset = "0x7702130", VA = "0x187702D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class HEKGABIMGEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public HEKGABIMGEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7702D90", Offset = "0x7702190", VA = "0x187702D90")]
		internal object AEKAHGMIBDA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct GEIPONHLNIL : IAsyncStateMachine
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
		public IIGLMKFKKFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private HEKGABIMGEM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7701550", Offset = "0x7700950", VA = "0x187701550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7701CA0", Offset = "0x77010A0", VA = "0x187701CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class PKLMMNCGFCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public PKLMMNCGFCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7717140", Offset = "0x7716540", VA = "0x187717140")]
		internal object EAKHFDNDKDP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private FGMEGFCAHOO EKABOCOCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private HJHDHMCCGBJ IHMGMGMEKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private KNEAEAOFAOK[] NEIKKKLFEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private CancellationTokenSource BPPNMIHDBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int JDAFLIICKJG;

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7705350", Offset = "0x7704750", VA = "0x187705350", Slot = "6")]
	public void OOJJEJPOBFE(FGMEGFCAHOO EKABOCOCDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7704D90", Offset = "0x7704190", VA = "0x187704D90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x7705120", Offset = "0x7704520", VA = "0x187705120", Slot = "8")]
	public void MCJPJJDIODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7704EA0", Offset = "0x77042A0", VA = "0x187704EA0", Slot = "5")]
	public void KEJIIIOCNNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x7705050", Offset = "0x7704450", VA = "0x187705050", Slot = "4")]
	[AsyncStateMachine(typeof(JMKLEBLEAFB))]
	public Task LFOHMBIMCOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x77049A0", Offset = "0x7703DA0", VA = "0x1877049A0")]
	private void BPFKIBPEEDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x7704DA0", Offset = "0x77041A0", VA = "0x187704DA0")]
	[AsyncStateMachine(typeof(HDHKJCILCLI))]
	private Task HNKHBHOFOGB(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x7704860", Offset = "0x7703C60", VA = "0x187704860")]
	[AsyncStateMachine(typeof(GEIPONHLNIL))]
	private Task<bool> AMCDDKEPFHG(int IIACLAMOIEE, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7704CB0", Offset = "0x77040B0", VA = "0x187704CB0")]
	private void CNIOIAOBCHJ(int IIACLAMOIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7704F70", Offset = "0x7704370", VA = "0x187704F70")]
	private void KGDPGAAOBEE(int IIACLAMOIEE, bool BIDPAAHCAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x7704730", Offset = "0x7703B30", VA = "0x187704730")]
	private void AFKMMODAGFH(int IIACLAMOIEE, Exception DIPLOOHMPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7705220", Offset = "0x7704620", VA = "0x187705220")]
	private void MOHOKCEPBGI(CancellationToken FHGIOBPPFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public IIGLMKFKKFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[RecRoom.NoEngine.Common.Preserve]
internal class JOBCIFJANON : KBJHGCHDPOA, LEKKAGKCCHD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct HPKLMGJPPFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public OPCCMKNHDBC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public JOBCIFJANON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public PFODNDLNIEM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x77031B0", Offset = "0x77025B0", VA = "0x1877031B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7703B10", Offset = "0x7702F10", VA = "0x187703B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct DFHPBEIGIMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JOBCIFJANON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public OPCCMKNHDBC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public PFODNDLNIEM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private LOALKKNJJLG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private CIICFINBKJN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private OMNPNKGOFMO <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private AANHBPCJIBP <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x76FC8C0", Offset = "0x76FBCC0", VA = "0x1876FC8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x76FD560", Offset = "0x76FC960", VA = "0x1876FD560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class DDGBPNGLLGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Matchmaking.LICDBLACJHA result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public DBMDMEAJGBE errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public DDGBPNGLLGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x76FBE10", Offset = "0x76FB210", VA = "0x1876FBE10")]
		internal object LPDPFOOOIMC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class GHBBCKLPCGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public Task<FPMKMFBIMPJ> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public GHBBCKLPCGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		internal Task<FPMKMFBIMPJ> IAAKDAAALBE(LOALKKNJJLG<string>.HAPJMIAELKE _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct PHHEHDIEGDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public JOBCIFJANON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public OPCCMKNHDBC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public LOALKKNJJLG<string>.HAPJMIAELKE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public PFODNDLNIEM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public OMNPNKGOFMO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private GHBBCKLPCGE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private PGEPEEEPGPE <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private CIICFINBKJN <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private NFELGJLCDGC <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private Task<Matchmaking.POKDDKNCBCM> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private GBLJCGEFNHC <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.POKDDKNCBCM> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter<FPMKMFBIMPJ> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7711760", Offset = "0x7710B60", VA = "0x187711760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x77170E0", Offset = "0x77164E0", VA = "0x1877170E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct NBHPEDNIAHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public JOBCIFJANON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public LOALKKNJJLG<string>.HAPJMIAELKE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <disconnectTimerScope>5__3;

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
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x770EFC0", Offset = "0x770E3C0", VA = "0x18770EFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x770FA20", Offset = "0x770EE20", VA = "0x18770FA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct LHKLHFCPEFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public JOBCIFJANON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private CGJHFFGEHKC <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x770D9F0", Offset = "0x770CDF0", VA = "0x18770D9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x770DE70", Offset = "0x770D270", VA = "0x18770DE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct JMOFLKBMJME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public AsyncTaskMethodBuilder<Matchmaking.POKDDKNCBCM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public OPCCMKNHDBC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public LOALKKNJJLG<string>.HAPJMIAELKE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public JOBCIFJANON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter<Matchmaking.POKDDKNCBCM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7706660", Offset = "0x7705A60", VA = "0x187706660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7706B70", Offset = "0x7705F70", VA = "0x187706B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct CBNMGECAMOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public LOALKKNJJLG<string>.HAPJMIAELKE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Matchmaking.POKDDKNCBCM serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public JOBCIFJANON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public OMNPNKGOFMO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TaskAwaiter<NLKNGCNIGMO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x76FA590", Offset = "0x76F9990", VA = "0x1876FA590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x76FAC90", Offset = "0x76FA090", VA = "0x1876FAC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class GDDNGIMODCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public OPCCMKNHDBC targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public GDDNGIMODCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7701450", Offset = "0x7700850", VA = "0x187701450")]
		internal object NLBGJLDAKMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7701350", Offset = "0x7700750", VA = "0x187701350")]
		internal string CGJJEHKAFCN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct JHNMBOJFPJN : IAsyncStateMachine
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
		public OPCCMKNHDBC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public JOBCIFJANON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private GDDNGIMODCJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private CIICFINBKJN <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x7705450", Offset = "0x7704850", VA = "0x187705450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7706020", Offset = "0x7705420", VA = "0x187706020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct GIDEAGIAFLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public LOALKKNJJLG<string>.HAPJMIAELKE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public JOBCIFJANON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public OMNPNKGOFMO joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public FPMKMFBIMPJ initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public OPCCMKNHDBC targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public PGEPEEEPGPE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7701D10", Offset = "0x7701110", VA = "0x187701D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7702630", Offset = "0x7701A30", VA = "0x187702630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct KGAJFDAADKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public LOALKKNJJLG<string>.HAPJMIAELKE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public JOBCIFJANON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private CIICFINBKJN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap3;

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
		private CIICFINBKJN <>7__wrap5;

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
		[Cpp2IlInjected.Address(RVA = "0x770BD30", Offset = "0x770B130", VA = "0x18770BD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x770D510", Offset = "0x770C910", VA = "0x18770D510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct DENALGGCPAD : IAsyncStateMachine
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
		public AECOPHFIFAP localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public JOBCIFJANON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private TaskAwaiter<BMNBHAPJIMJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x76FC0F0", Offset = "0x76FB4F0", VA = "0x1876FC0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x76FC860", Offset = "0x76FBC60", VA = "0x1876FC860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class KHAEIIAKCHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public OPCCMKNHDBC targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public KHAEIIAKCHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x772E330", Offset = "0x772D730", VA = "0x18772E330")]
		internal object FLJBDOHPJPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class PAPIJLBLDHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public PAPIJLBLDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7735690", Offset = "0x7734A90", VA = "0x187735690")]
		internal void CBJGDKKGODA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class JKGIJIAEKBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public OPCCMKNHDBC targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JKGIJIAEKBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x772BE30", Offset = "0x772B230", VA = "0x18772BE30")]
		internal object EDICEOJCKHA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class KFKFNOINFIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public OPCCMKNHDBC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public KFKFNOINFIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x772D9C0", Offset = "0x772CDC0", VA = "0x18772D9C0")]
		internal string OIGLLDIGNBL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly GKOKEEMOOFG KCOONMBJGMO;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly GKOKEEMOOFG DOLOPIAJMGP;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly GKOKEEMOOFG KGJJLAMJFLD;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string DBEEBOJBIMN;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly string IBDBALJNKJN;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly string KGGCOFEBLHJ;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly Guid CEKAEMLEBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private KDKGOMPODOP EJHFGMBCHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private DCFACMMFOLA FFGPDEIMDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private HCMOGHGOBGB NPGFBLNGFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private FGMEGFCAHOO EKABOCOCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private HJHDHMCCGBJ IHMGMGMEKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private OFAIDDBHGII ABBFNBJIPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private LHHDEKNNILG GMCCGJOCKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NJJOBPIEEBD GGPLCIOHPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private MOAJKCFHBNI GEALOMHNOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NNCDHDGNJDP FDGPHHEDMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private IDisposable FMMJKKEKLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private JHJPFICBPAM EJAPPCPFCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly PALGLKMIOIC EMDDGIPINEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private GBLJCGEFNHC OJJBHADIIMN;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public TaskStatus KKDJGKLDMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8EE380", Offset = "0x8ED780", VA = "0x1808EE380", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xE8D380", Offset = "0xE8C780", VA = "0x180E8D380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private HJHCBNKLCIG GAFOLMMMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x770A040", Offset = "0x7709440", VA = "0x18770A040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x770A760", Offset = "0x7709B60", VA = "0x18770A760", Slot = "6")]
	public void OOJJEJPOBFE(FGMEGFCAHOO EKABOCOCDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x77083C0", Offset = "0x77077C0", VA = "0x1877083C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7707CB0", Offset = "0x77070B0", VA = "0x187707CB0", Slot = "5")]
	[AsyncStateMachine(typeof(HPKLMGJPPFF))]
	public Task CMJEFBBPNCM(OPCCMKNHDBC MEAFHEONFHD, PFODNDLNIEM OKKLLCCBHFK, CancellationToken FGKKJOBPJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x77086F0", Offset = "0x7707AF0", VA = "0x1877086F0")]
	[AsyncStateMachine(typeof(DFHPBEIGIMN))]
	private Task HIMABPDDIFJ(OPCCMKNHDBC MEAFHEONFHD, PFODNDLNIEM OKKLLCCBHFK, CancellationToken FGKKJOBPJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x77075F0", Offset = "0x77069F0", VA = "0x1877075F0")]
	private void AMEJAJFNHFF(MOAJKCFHBNI GEALOMHNOHA, OPCCMKNHDBC MEAFHEONFHD, Exception DIPLOOHMPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x77091F0", Offset = "0x77085F0", VA = "0x1877091F0")]
	private static void LFNIBJGMLON(AANHBPCJIBP BCLOKCNLCGH, Exception DIPLOOHMPFH, [Optional] List<int> BICOFPCNPEA, int JDAFLIICKJG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7708980", Offset = "0x7707D80", VA = "0x187708980")]
	[AsyncStateMachine(typeof(PHHEHDIEGDH))]
	private Task JFOAHNAGIHN(LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, OPCCMKNHDBC MEAFHEONFHD, PFODNDLNIEM OKKLLCCBHFK, OMNPNKGOFMO JEOBGKAHMHN, CancellationToken FGKKJOBPJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7708410", Offset = "0x7707810", VA = "0x187708410")]
	private void ELOIJHOHHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7708290", Offset = "0x7707690", VA = "0x187708290")]
	[AsyncStateMachine(typeof(NBHPEDNIAHB))]
	private Task DJHHACHDPOK(LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7707DF0", Offset = "0x77071F0", VA = "0x187707DF0")]
	private void DHCHAKACLML(OPCCMKNHDBC MEAFHEONFHD, CancellationToken FGKKJOBPJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7708D30", Offset = "0x7708130", VA = "0x187708D30")]
	private void KDJELIFGKAG(OPCCMKNHDBC MEAFHEONFHD, OMNPNKGOFMO JEOBGKAHMHN, OperationCanceledException NKOFDNKGMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x7709E00", Offset = "0x7709200", VA = "0x187709E00")]
	private void NGBCBNALHMA(OPCCMKNHDBC MEAFHEONFHD, OMNPNKGOFMO JEOBGKAHMHN, Exception DIPLOOHMPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7709BF0", Offset = "0x7708FF0", VA = "0x187709BF0")]
	private void MDNFKFKNBJD(OPCCMKNHDBC MEAFHEONFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x770A240", Offset = "0x7709640", VA = "0x18770A240")]
	private static AFMCCHKAGHJ NJCHAPGAJMK(OPCCMKNHDBC MEAFHEONFHD)
	{
		return default(AFMCCHKAGHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7709B20", Offset = "0x7708F20", VA = "0x187709B20")]
	[AsyncStateMachine(typeof(LHKLHFCPEFI))]
	private Task LLNDNEFNEGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7707B50", Offset = "0x7706F50", VA = "0x187707B50")]
	[AsyncStateMachine(typeof(JMOFLKBMJME))]
	private Task<Matchmaking.POKDDKNCBCM> CMFKJHKBOBE(OPCCMKNHDBC MEAFHEONFHD, LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7707A40", Offset = "0x7706E40", VA = "0x187707A40")]
	private static NLKNGCNIGMO BLHFDAHOEHD(Matchmaking.POKDDKNCBCM BFFNJBILDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x770A610", Offset = "0x7709A10", VA = "0x18770A610")]
	[AsyncStateMachine(typeof(CBNMGECAMOJ))]
	private Task OEHCHLAAFNA(Matchmaking.POKDDKNCBCM BFFNJBILDCL, OMNPNKGOFMO JEOBGKAHMHN, LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, CancellationToken KAOFONNHCIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x77073A0", Offset = "0x77067A0", VA = "0x1877073A0")]
	[AsyncStateMachine(typeof(JHNMBOJFPJN))]
	private Task AAKIAGJECCL(OPCCMKNHDBC MEAFHEONFHD, CancellationTokenSource AJEJKDICCDL, Task NDMHLEAGFNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7708120", Offset = "0x7707520", VA = "0x187708120")]
	[AsyncStateMachine(typeof(GIDEAGIAFLF))]
	private Task DJEPAKFGEPE(FPMKMFBIMPJ KACHGOKLIEC, PGEPEEEPGPE MJHFIICPKEL, OPCCMKNHDBC AJNBJBEMIEO, OMNPNKGOFMO NAMAEBMMLJL, LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, CancellationToken ADHOLOLGKIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x770A2A0", Offset = "0x77096A0", VA = "0x18770A2A0")]
	private OMNPNKGOFMO NPAFGPBIBJI(OMNPNKGOFMO NAMAEBMMLJL, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7708840", Offset = "0x7707C40", VA = "0x187708840")]
	[AsyncStateMachine(typeof(KGAJFDAADKA))]
	private Task JANJGHNNFEO(LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7708F70", Offset = "0x7708370", VA = "0x187708F70")]
	[AsyncStateMachine(typeof(DENALGGCPAD))]
	private Task KIAEEMNGPCI(CancellationToken FHGIOBPPFHG, int HLAOHLMDNLM, AECOPHFIFAP HKGLPPGLJFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x770A490", Offset = "0x7709890", VA = "0x18770A490")]
	private static void OBGNBAFBJHG(OPCCMKNHDBC MEAFHEONFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7708AE0", Offset = "0x7707EE0", VA = "0x187708AE0")]
	private void JOEACNEJPNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x77090A0", Offset = "0x77084A0", VA = "0x1877090A0")]
	private void LADAKPDPLBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x770AA80", Offset = "0x7709E80", VA = "0x18770AA80")]
	private void PIOEFPCKNPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x7708660", Offset = "0x7707A60", VA = "0x187708660")]
	private void HAIJBKMCLCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x7709A30", Offset = "0x7708E30", VA = "0x187709A30")]
	private static void LKEHACMOJDI(OPCCMKNHDBC MEAFHEONFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x77074E0", Offset = "0x77068E0", VA = "0x1877074E0")]
	private static CancellationTokenRegistration AJEIBDLFCDJ(OPCCMKNHDBC MEAFHEONFHD, CancellationToken KAOFONNHCIH)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7708560", Offset = "0x7707960", VA = "0x187708560")]
	private static void GFIHFCNFKAD(OPCCMKNHDBC MEAFHEONFHD, Exception DIPLOOHMPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x770A090", Offset = "0x7709490", VA = "0x18770A090")]
	private void NIMAGDJFBMA(OPCCMKNHDBC MEAFHEONFHD, Task NDMHLEAGFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7709130", Offset = "0x7708530", VA = "0x187709130")]
	private static void LDCMEBNGNBB(Func<string> GOICOPEBMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x770AD10", Offset = "0x770A110", VA = "0x18770AD10")]
	public JOBCIFJANON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7709190", Offset = "0x7708590", VA = "0x187709190")]
	[CompilerGenerated]
	internal static (int, int?) LDKLHGMNGPH(DBMDMEAJGBE MMEACNFBMEM)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class LNOGEJOLAOA : EKHPCFNCOAH, LEKKAGKCCHD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct GLFNMLAKJFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public LNOGEJOLAOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AECOPHFIFAP localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7723C90", Offset = "0x7723090", VA = "0x187723C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x77240F0", Offset = "0x77234F0", VA = "0x1877240F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class OHJIEGHFDHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public LNOGEJOLAOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public AECOPHFIFAP localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public OHJIEGHFDHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x77352F0", Offset = "0x77346F0", VA = "0x1877352F0")]
		internal List<Task> OEHBMOCDDIJ(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct IGAKPCKBHCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public IGHOGOBMLLF taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public AECOPHFIFAP localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7727910", Offset = "0x7726D10", VA = "0x187727910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7727CB0", Offset = "0x77270B0", VA = "0x187727CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct PKEEJKGIGNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public LNOGEJOLAOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x77358C0", Offset = "0x7734CC0", VA = "0x1877358C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7735BA0", Offset = "0x7734FA0", VA = "0x187735BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly HashSet<IGHOGOBMLLF> KCIAFIFIILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private DCFACMMFOLA FFGPDEIMDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private FGMEGFCAHOO EKABOCOCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private ELGDDGNBNAM FCBGOEMPOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private IMAOMDCNIFJ HKFDJIAIFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private IDisposable FMMJKKEKLBJ;

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7731430", Offset = "0x7730830", VA = "0x187731430", Slot = "5")]
	public void OOJJEJPOBFE(FGMEGFCAHOO EKABOCOCDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x77308C0", Offset = "0x772FCC0", VA = "0x1877308C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7731160", Offset = "0x7730560", VA = "0x187731160", Slot = "4")]
	public bool JDDOJGHPKJG(IGHOGOBMLLF HGJOGNHDHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x7730720", Offset = "0x772FB20", VA = "0x187730720")]
	private void AFDCDNBJNLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7730F40", Offset = "0x7730340", VA = "0x187730F40")]
	private void IKHPLBPIHOP(MCGHEPNDHCL JOMOCOIMIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7731270", Offset = "0x7730670", VA = "0x187731270")]
	[AsyncStateMachine(typeof(GLFNMLAKJFO))]
	private Task NJPIMFADEGJ(int HLAOHLMDNLM, AECOPHFIFAP HKGLPPGLJFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x77307F0", Offset = "0x772FBF0", VA = "0x1877307F0")]
	private Func<CancellationToken, List<Task>> BBJAOLJOCON(int HLAOHLMDNLM, AECOPHFIFAP HKGLPPGLJFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7730A60", Offset = "0x772FE60", VA = "0x187730A60")]
	private List<Task> HNMPMCFNHGI(int HLAOHLMDNLM, AECOPHFIFAP HKGLPPGLJFI, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7730940", Offset = "0x772FD40", VA = "0x187730940")]
	[AsyncStateMachine(typeof(IGAKPCKBHCN))]
	private Task FMNIPGONJPA(IGHOGOBMLLF HCMKHHLLJEJ, CancellationToken CMNJCPJBHGE, int HLAOHLMDNLM, AECOPHFIFAP HKGLPPGLJFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7731360", Offset = "0x7730760", VA = "0x187731360")]
	[AsyncStateMachine(typeof(PKEEJKGIGNB))]
	private Task OCJIMFLDNEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x77311C0", Offset = "0x77305C0", VA = "0x1877311C0")]
	private void MCJPJJDIODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7731730", Offset = "0x7730B30", VA = "0x187731730")]
	public LNOGEJOLAOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[UnityEngine.Scripting.Preserve]
internal sealed class JOOOPFEGKHD : PONAGHIDMCH, LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class BELFPCEJHGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public BELFPCEJHGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7719490", Offset = "0x7718890", VA = "0x187719490")]
		internal object IGNLCPIGPEL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class HCLJCNEJFNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public HCLJCNEJFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7725CC0", Offset = "0x77250C0", VA = "0x187725CC0")]
		internal object LMGHLOCPAIN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class FMJKMCNHJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public FMJKMCNHJLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class HJEEGAAMELH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public HJEEGAAMELH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7727210", Offset = "0x7726610", VA = "0x187727210")]
		internal object EEOGMKDLOEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class AGJGJBCFCOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public AGJGJBCFCOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7718C30", Offset = "0x7718030", VA = "0x187718C30")]
		internal object NKELJBGOPFH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly Dictionary<Guid, CBEENLKBONB> CMJDNJADPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private readonly TimeSpan FPGGEALDDPJ;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "9")]
	public void OOJJEJPOBFE(FGMEGFCAHOO EKABOCOCDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x772C130", Offset = "0x772B530", VA = "0x18772C130", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x772C140", Offset = "0x772B540", VA = "0x18772C140", Slot = "4")]
	public MLJMECJKGKE EBDKDKCDLND(Guid NDFJMJHNPGE)
	{
		return default(MLJMECJKGKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x772BEB0", Offset = "0x772B2B0", VA = "0x18772BEB0", Slot = "5")]
	public bool BDKJEBALGLD(Guid NDFJMJHNPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x772C770", Offset = "0x772BB70", VA = "0x18772C770", Slot = "6")]
	public bool OAABOCPMCPI(Guid NDFJMJHNPGE, Task ONIAAOHFKKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x772C590", Offset = "0x772B990", VA = "0x18772C590", Slot = "7")]
	public bool NBAGPJMBKOF(Guid NDFJMJHNPGE, BMNBHAPJIMJ OAFNHPEIMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x772C0C0", Offset = "0x772B4C0", VA = "0x18772C0C0", Slot = "8")]
	public Task<(BMNBHAPJIMJ, Task)> BHNPNBHLEAE(Guid NDFJMJHNPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x772C360", Offset = "0x772B760", VA = "0x18772C360")]
	private void FFPIAHMKLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x772CAA0", Offset = "0x772BEA0", VA = "0x18772CAA0")]
	public JOOOPFEGKHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[RecRoom.NoEngine.Common.Preserve]
internal class HCDBFDOKKAP : DJDKBPJOFLH, LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private class MLJHAHACDMH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private readonly OPCCMKNHDBC NFGGJAGKIGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private readonly CancellationTokenSource BPPNMIHDBGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public readonly CancellationToken GGAGHGDLNFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private bool BDOCALPINAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private bool NDHHFMKHGIO;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7731FE0", Offset = "0x77313E0", VA = "0x187731FE0")]
		public MLJHAHACDMH(OPCCMKNHDBC NFGGJAGKIGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7731E90", Offset = "0x7731290", VA = "0x187731E90")]
		public void MCJPJJDIODB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7731E60", Offset = "0x7731260", VA = "0x187731E60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class OLBBMCLGOOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public OBHGDFHKAIC disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public OLBBMCLGOOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7735330", Offset = "0x7734730", VA = "0x187735330")]
		internal object ICMOJJLAENC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct ADADHCAPOPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public OBHGDFHKAIC disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public HCDBFDOKKAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7718280", Offset = "0x7717680", VA = "0x187718280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7718680", Offset = "0x7717A80", VA = "0x187718680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class GHKNCCFCNPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public GHKNCCFCNPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7723BC0", Offset = "0x7722FC0", VA = "0x187723BC0")]
		internal object KDIPJAKHDNP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct INGOOPFEKNN : IAsyncStateMachine
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
		public HCDBFDOKKAP <>4__this;

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
		private CIICFINBKJN <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7728660", Offset = "0x7727A60", VA = "0x187728660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class HHJEKBAOMMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public OPCCMKNHDBC newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public HHJEKBAOMMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7727170", Offset = "0x7726570", VA = "0x187727170")]
		internal object INFFNDFHDKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x77270F0", Offset = "0x77264F0", VA = "0x1877270F0")]
		internal object EJPFGADNOEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7727130", Offset = "0x7726530", VA = "0x187727130")]
		internal object HELIOFMMGDL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class JALCKDJHPKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JALCKDJHPKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x772AF50", Offset = "0x772A350", VA = "0x18772AF50")]
		internal void DJEBGHPBLLL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct EKPDBFEOIPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public OPCCMKNHDBC newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public HCDBFDOKKAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public PFODNDLNIEM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private HHJEKBAOMMG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private CIICFINBKJN <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x771EFF0", Offset = "0x771E3F0", VA = "0x18771EFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x771FF80", Offset = "0x771F380", VA = "0x18771FF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly AFMANAGHNGL.BDHJJAACFDM KGPDONNNNBO;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly ANDMNHBOFDI MLLCOBINHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private DCFACMMFOLA FFGPDEIMDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private FGMEGFCAHOO EKABOCOCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private OFAIDDBHGII ABBFNBJIPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private HJHDHMCCGBJ IHMGMGMEKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private BFPGCNENHGP JAGODFHKNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private KBJHGCHDPOA HKPGINJDHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private OPCCMKNHDBC ACIELNJJGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private MLJHAHACDMH PKJDPODANKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private bool IOMJEGNLNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private Task LFDAEOKGHHD;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private HJHCBNKLCIG GAFOLMMMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x77254F0", Offset = "0x77248F0", VA = "0x1877254F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool GCMHEIDHPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xAE8480", Offset = "0xAE7880", VA = "0x180AE8480")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7725540", Offset = "0x7724940", VA = "0x187725540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7725550", Offset = "0x7724950", VA = "0x187725550", Slot = "4")]
	public void OOJJEJPOBFE(FGMEGFCAHOO EKABOCOCDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7724C20", Offset = "0x7724020", VA = "0x187724C20", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7724D90", Offset = "0x7724190", VA = "0x187724D90")]
	[AsyncStateMachine(typeof(ADADHCAPOPB))]
	private Task GJOJHOHKDCG(OBHGDFHKAIC NGDBFOGAJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7725360", Offset = "0x7724760", VA = "0x187725360")]
	private void MGDMNENIBPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7724A90", Offset = "0x7723E90", VA = "0x187724A90")]
	private void DPKEBOLIBIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7724850", Offset = "0x7723C50", VA = "0x187724850")]
	private void AJLILPMNMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x77249D0", Offset = "0x7723DD0", VA = "0x1877249D0")]
	private bool CJFHCEHAAEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x77257F0", Offset = "0x7724BF0", VA = "0x1877257F0")]
	[AsyncStateMachine(typeof(INGOOPFEKNN))]
	private void PAEJNFMNBMO(int BHDCNGMMPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x77250D0", Offset = "0x77244D0", VA = "0x1877250D0")]
	private void HNOALJADHBD([Out] IDisposable LEHCBIBAFKK, [Out] IDisposable IJBCHADBNHP, [Out] IDisposable NJGALOCJGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7724E80", Offset = "0x7724280", VA = "0x187724E80")]
	private bool HADCKOOCNKF(OPCCMKNHDBC NFGGJAGKIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7724A40", Offset = "0x7723E40", VA = "0x187724A40")]
	private void DCOKNFBGBFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x7724FA0", Offset = "0x77243A0", VA = "0x187724FA0")]
	[AsyncStateMachine(typeof(EKPDBFEOIPK))]
	private Task HIMABPDDIFJ(OPCCMKNHDBC NFGGJAGKIGE, PFODNDLNIEM OKKLLCCBHFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7725C50", Offset = "0x7725050", VA = "0x187725C50")]
	public HCDBFDOKKAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[UnityEngine.Scripting.Preserve]
internal sealed class CGKKHBKDHEL : IKIAIKFLBIM, LEKKAGKCCHD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct CBIGPKLKFPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public AsyncTaskMethodBuilder<AMGJKMNLMLJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public CGKKHBKDHEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private TaskAwaiter<AMGJKMNLMLJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x771A6A0", Offset = "0x7719AA0", VA = "0x18771A6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x771A930", Offset = "0x7719D30", VA = "0x18771A930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class ECCHKMKBAGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public CCONCDOKPJO message;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public ECCHKMKBAGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x771E7E0", Offset = "0x771DBE0", VA = "0x18771E7E0")]
		internal object MEFPCJDECJH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class OEBHKAAPMOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public CCONCDOKPJO messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public OEBHKAAPMOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x77346C0", Offset = "0x7733AC0", VA = "0x1877346C0")]
		internal object EKEFMJNOEOG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class FJNMKPNOKJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public CCONCDOKPJO request;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public FJNMKPNOKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7722BC0", Offset = "0x7721FC0", VA = "0x187722BC0")]
		internal object BEJPAEDPLBF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct COICGINPCAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public CCONCDOKPJO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public CGKKHBKDHEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<KJPDDBJMGCN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x771C570", Offset = "0x771B970", VA = "0x18771C570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x771CE40", Offset = "0x771C240", VA = "0x18771CE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class MAOKIGPADPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public CCONCDOKPJO operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public MAOKIGPADPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x77317C0", Offset = "0x7730BC0", VA = "0x1877317C0")]
		internal object BMEGJMIANIA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct OHANFMOMONM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public CCONCDOKPJO operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public CGKKHBKDHEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private OMNPNKGOFMO <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<CCONCDOKPJO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x7734720", Offset = "0x7733B20", VA = "0x187734720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x7735290", Offset = "0x7734690", VA = "0x187735290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct LBPIIJMKONM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder<KJPDDBJMGCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public CGKKHBKDHEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public CCONCDOKPJO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private LPGCBMHGCAB.FJHICMJJGJH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private OMNPNKGOFMO <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private TaskAwaiter<CCONCDOKPJO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x772F100", Offset = "0x772E500", VA = "0x18772F100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x772F630", Offset = "0x772EA30", VA = "0x18772F630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class PIOCMMCHGDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public KJPDDBJMGCN operation;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public PIOCMMCHGDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x7735790", Offset = "0x7734B90", VA = "0x187735790")]
		internal object HGGBAFMMAOO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct IMDEMPHANLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public KJPDDBJMGCN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public CGKKHBKDHEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private LOALKKNJJLG<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x7727FD0", Offset = "0x77273D0", VA = "0x187727FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x7728600", Offset = "0x7727A00", VA = "0x187728600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class CMNAOKLFPOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public CCONCDOKPJO request;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public CMNAOKLFPOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x771C510", Offset = "0x771B910", VA = "0x18771C510")]
		internal object FEEIAOKDIGG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class GHKPBGEHBAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public CCONCDOKPJO request;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public GHKPBGEHBAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7723C30", Offset = "0x7723030", VA = "0x187723C30")]
		internal object EKPILENPHEE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private FGMEGFCAHOO EKABOCOCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private LHHDEKNNILG GMCCGJOCKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private HFGJNCPNPMN PCFGIEPNHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private MPGGJDCHONJ PDGJKDOGMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private HCMOGHGOBGB NPGFBLNGFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private TaskCompletionSource<AMGJKMNLMLJ> CPAMODINGNE;

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x771BCE0", Offset = "0x771B0E0", VA = "0x18771BCE0", Slot = "7")]
	public void OOJJEJPOBFE(FGMEGFCAHOO EKABOCOCDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x771AA20", Offset = "0x7719E20", VA = "0x18771AA20", Slot = "6")]
	[AsyncStateMachine(typeof(CBIGPKLKFPF))]
	public Task<AMGJKMNLMLJ> BCMHHFACDHG(CancellationToken GALLNEIFFMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x771B610", Offset = "0x771AA10", VA = "0x18771B610", Slot = "4")]
	public void DPCJMJKEFOE(CCONCDOKPJO LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x771AEC0", Offset = "0x771A2C0", VA = "0x18771AEC0", Slot = "5")]
	public void BIIPCFFAMCH(CCONCDOKPJO CJHHGCPDFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x771BBD0", Offset = "0x771AFD0", VA = "0x18771BBD0")]
	[AsyncStateMachine(typeof(COICGINPCAL))]
	private Task KBDDFHBGHJC(CCONCDOKPJO BLIDGDGMCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x771BAC0", Offset = "0x771AEC0", VA = "0x18771BAC0")]
	[AsyncStateMachine(typeof(OHANFMOMONM))]
	private Task JAKANIAOFBE(CCONCDOKPJO AEGPGAJBGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x771B430", Offset = "0x771A830", VA = "0x18771B430")]
	[AsyncStateMachine(typeof(LBPIIJMKONM))]
	private Task<KJPDDBJMGCN> CDFFNIJKLJC(CCONCDOKPJO BLIDGDGMCAP, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x771B580", Offset = "0x771A980", VA = "0x18771B580")]
	private OMNPNKGOFMO DAKOHJDPIKL(CCONCDOKPJO KMKPLDDNJFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x771B9A0", Offset = "0x771ADA0", VA = "0x18771B9A0")]
	[AsyncStateMachine(typeof(IMDEMPHANLG))]
	private Task IGNBCFMFGCE(KJPDDBJMGCN CGENICICIAO, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x771B220", Offset = "0x771A620", VA = "0x18771B220")]
	private KJPDDBJMGCN BPKPMGHHHNJ(CCONCDOKPJO BLIDGDGMCAP, OMNPNKGOFMO GMKEFJJNHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2E465C0", Offset = "0x2E459C0", VA = "0x182E465C0")]
	private T BEKPNNCMPNJ<T>(T HCPAOILCJCB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x771AB30", Offset = "0x7719F30", VA = "0x18771AB30")]
	private KJPDDBJMGCN BHOJDOLMNEP(CCONCDOKPJO BLIDGDGMCAP, OMNPNKGOFMO GMKEFJJNHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public CGKKHBKDHEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[UnityEngine.Scripting.Preserve]
internal sealed class FBIAAFDFMND : HFGJNCPNPMN, LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class MKAFKBMFHLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public MKAFKBMFHLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x7731DF0", Offset = "0x77311F0", VA = "0x187731DF0")]
		internal object PCAAPJDLPNG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class DDKMNCFFGOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public DDKMNCFFGOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x771DD80", Offset = "0x771D180", VA = "0x18771DD80")]
		internal object FBPDODHCNDM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private HCMOGHGOBGB NPGFBLNGFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private AIMAIBHBLDD MENNAMHALEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private IKIAIKFLBIM HJCDAJNLPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private PONAGHIDMCH CMJDNJADPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private IBEECJFKBNI EJKJINEIEFK;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x77229D0", Offset = "0x7721DD0", VA = "0x1877229D0", Slot = "6")]
	public void OOJJEJPOBFE(FGMEGFCAHOO EKABOCOCDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7720DD0", Offset = "0x77201D0", VA = "0x187720DD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x77218F0", Offset = "0x7720CF0", VA = "0x1877218F0", Slot = "4")]
	public MLJMECJKGKE IFAHJMEPAAP(CCONCDOKPJO PIPLPFAAPIM)
	{
		return default(MLJMECJKGKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7720BC0", Offset = "0x771FFC0", VA = "0x187720BC0", Slot = "5")]
	public void BJNKCGALELO(Guid NDFJMJHNPGE, Task ONIAAOHFKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x77215F0", Offset = "0x77209F0", VA = "0x1877215F0")]
	private void HJIJGKEKNEC(byte PIAEBCPLIBI, int OAAKGEPPNGN, object PFKJNPEJLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7721080", Offset = "0x7720480", VA = "0x187721080")]
	private void EKHMOOPMOLI(GDOIDPAPDPJ IAAPABJLNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x77221D0", Offset = "0x77215D0", VA = "0x1877221D0")]
	private void LNPNJLDKANE(GDOIDPAPDPJ IAAPABJLNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7721D10", Offset = "0x7721110", VA = "0x187721D10")]
	private void JCEJAHBMOKG(GDOIDPAPDPJ IAAPABJLNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x77216C0", Offset = "0x7720AC0", VA = "0x1877216C0")]
	private BMNBHAPJIMJ HJKCFDCANBD(CCONCDOKPJO KMKPLDDNJFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7720E80", Offset = "0x7720280", VA = "0x187720E80")]
	private void EKCAAKPDHDF(CCONCDOKPJO AEGPGAJBGFD, BMNBHAPJIMJ OAFNHPEIMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x7722730", Offset = "0x7721B30", VA = "0x187722730")]
	private bool OGJJDKOLMEC(CCONCDOKPJO AEGPGAJBGFD, BMNBHAPJIMJ OAFNHPEIMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x77224C0", Offset = "0x77218C0", VA = "0x1877224C0")]
	private bool NMCKJLEECPE(CCONCDOKPJO EKEFLFIKPJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x7721F50", Offset = "0x7721350", VA = "0x187721F50")]
	private bool KEHEJBBGGLC(byte PIAEBCPLIBI, ExitGames.Client.Photon.Hashtable IAAPABJLNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public FBIAAFDFMND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[UnityEngine.Scripting.Preserve]
internal sealed class CLCPPELHDFB : HOPKELNFEOC, LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class BKBJLOAHGNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public AMGJKMNLMLJ operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public CLCPPELHDFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public CCONCDOKPJO roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public BKBJLOAHGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x7719620", Offset = "0x7718A20", VA = "0x187719620")]
		internal object JJOGJCPKDBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x77194F0", Offset = "0x77188F0", VA = "0x1877194F0")]
		internal object BJDICPPNBGG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct EODHEDJBAPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<BMNBHAPJIMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public CLCPPELHDFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public CCONCDOKPJO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<BMNBHAPJIMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x771FFE0", Offset = "0x771F3E0", VA = "0x18771FFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7720680", Offset = "0x771FA80", VA = "0x187720680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class OOAFDDMHFLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public AMGJKMNLMLJ operationType;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public OOAFDDMHFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x7735620", Offset = "0x7734A20", VA = "0x187735620")]
		internal object LHFIABNPDLO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class EHNMJJMOGJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public CCONCDOKPJO request;

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public EHNMJJMOGJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x771E840", Offset = "0x771DC40", VA = "0x18771E840")]
		internal object HBPCKMPKOMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x771E920", Offset = "0x771DD20", VA = "0x18771E920")]
		internal object MCEPLDKMDIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x771E8B0", Offset = "0x771DCB0", VA = "0x18771E8B0")]
		internal object LFLFDLPEPLF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct LKAKPAONADA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<BMNBHAPJIMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public CCONCDOKPJO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public CLCPPELHDFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private EHNMJJMOGJK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private MLJMECJKGKE <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private BMNBHAPJIMJ <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private TaskAwaiter<(BMNBHAPJIMJ validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x772FD20", Offset = "0x772F120", VA = "0x18772FD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x77305F0", Offset = "0x772F9F0", VA = "0x1877305F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private HCMOGHGOBGB NPGFBLNGFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private AIMAIBHBLDD MENNAMHALEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private HFGJNCPNPMN PCFGIEPNHLN;

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x771C260", Offset = "0x771B660", VA = "0x18771C260", Slot = "5")]
	public void OOJJEJPOBFE(FGMEGFCAHOO EKABOCOCDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x771BE10", Offset = "0x771B210", VA = "0x18771BE10", Slot = "4")]
	[AsyncStateMachine(typeof(EODHEDJBAPM))]
	private Task<BMNBHAPJIMJ> DDODMODCAND(CCONCDOKPJO KMKPLDDNJFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x771BF30", Offset = "0x771B330", VA = "0x18771BF30")]
	private bool GCJDFOIMLJN(AMGJKMNLMLJ LNABBPEHJIJ, [Out] BMNBHAPJIMJ CEDDFJCBLGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x771C120", Offset = "0x771B520", VA = "0x18771C120")]
	[AsyncStateMachine(typeof(LKAKPAONADA))]
	private Task<BMNBHAPJIMJ> KBDJCKFGMEN(CCONCDOKPJO BLIDGDGMCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public CLCPPELHDFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class JEJLJPCKBDK : CPKFCHFLOKG, LEKKAGKCCHD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct IDNCOADKIBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<FPMKMFBIMPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public OPCCMKNHDBC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public JEJLJPCKBDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private TaskAwaiter<NLMAEEICDJF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<FPMKMFBIMPJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x77272D0", Offset = "0x77266D0", VA = "0x1877272D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x77278A0", Offset = "0x7726CA0", VA = "0x1877278A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class NPKEGJEMLOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public NPKEGJEMLOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x7734610", Offset = "0x7733A10", VA = "0x187734610")]
		internal object HKBJIDFOCBM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct EJHFPAACBHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public AsyncTaskMethodBuilder<NLMAEEICDJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public JEJLJPCKBDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public OPCCMKNHDBC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private NPKEGJEMLOG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<NLMAEEICDJF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x771E990", Offset = "0x771DD90", VA = "0x18771E990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x771EF80", Offset = "0x771E380", VA = "0x18771EF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct GFBDBENKIOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<FPMKMFBIMPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public JEJLJPCKBDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public OPCCMKNHDBC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public NLMAEEICDJF roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<(OAOEDECEGIP superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7722FA0", Offset = "0x77223A0", VA = "0x187722FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7723400", Offset = "0x7722800", VA = "0x187723400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class COEIBENNOAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public COEIBENNOAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xA99C70", Offset = "0xA99070", VA = "0x180A99C70")]
		internal bool JPNNCAKMPPF(BEANCEBHDPC sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct NEOGIFIBKBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<(OAOEDECEGIP superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public NLMAEEICDJF roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public JEJLJPCKBDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public OPCCMKNHDBC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<(OAOEDECEGIP superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x7732830", Offset = "0x7731C30", VA = "0x187732830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x7732ED0", Offset = "0x77322D0", VA = "0x187732ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class PJIJKHGLLKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public PJIJKHGLLKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x7735810", Offset = "0x7734C10", VA = "0x187735810")]
		internal object MMCHIACFGFE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct NHNKEBOMMLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public AsyncTaskMethodBuilder<(OAOEDECEGIP superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public BEANCEBHDPC subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public JEJLJPCKBDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public OPCCMKNHDBC dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private PJIJKHGLLKC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private TaskAwaiter<GNODDIAAKFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x7733E70", Offset = "0x7733270", VA = "0x187733E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x77345A0", Offset = "0x77339A0", VA = "0x1877345A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static readonly (OAOEDECEGIP superRoomData, long subRoomDataSaveId) CEBNHGNLFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private HJHDHMCCGBJ IHMGMGMEKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private OPACFMPIKLJ FFOPLHPMAIN;

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x772BB60", Offset = "0x772AF60", VA = "0x18772BB60", Slot = "5")]
	public void OOJJEJPOBFE(FGMEGFCAHOO EKABOCOCDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x772B730", Offset = "0x772AB30", VA = "0x18772B730", Slot = "4")]
	[AsyncStateMachine(typeof(IDNCOADKIBD))]
	public Task<FPMKMFBIMPJ> FKGJCCMPKNJ(LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, OPCCMKNHDBC MEAFHEONFHD, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x772B890", Offset = "0x772AC90", VA = "0x18772B890")]
	[AsyncStateMachine(typeof(EJHFPAACBHC))]
	private Task<NLMAEEICDJF> LFOPHPBGAFM(OPCCMKNHDBC MEAFHEONFHD, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x772B5C0", Offset = "0x772A9C0", VA = "0x18772B5C0")]
	[AsyncStateMachine(typeof(GFBDBENKIOB))]
	private Task<FPMKMFBIMPJ> BHACEDNFGOJ(OPCCMKNHDBC MEAFHEONFHD, NLMAEEICDJF MEMOPNKIGBD, long DLGNECIGKLC, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x772BBF0", Offset = "0x772AFF0", VA = "0x18772BBF0")]
	[AsyncStateMachine(typeof(NEOGIFIBKBJ))]
	private Task<(OAOEDECEGIP, long)> PMPCOLLGIPA(OPCCMKNHDBC MEAFHEONFHD, NLMAEEICDJF MEMOPNKIGBD, long DLGNECIGKLC, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x772B9F0", Offset = "0x772ADF0", VA = "0x18772B9F0")]
	[AsyncStateMachine(typeof(NHNKEBOMMLE))]
	private Task<(OAOEDECEGIP, long)> OACGEDBEKDB(OPCCMKNHDBC NPDHOKDNKPA, BEANCEBHDPC AMOABMIJIBE, long DLGNECIGKLC, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public JEJLJPCKBDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[UnityEngine.Scripting.Preserve]
internal sealed class GFIDHIPLGBF : MPGGJDCHONJ, LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class ABFLLFHCPCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public CCONCDOKPJO request;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public ABFLLFHCPCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x7718220", Offset = "0x7717620", VA = "0x187718220")]
		internal object JEOGFBCOCBM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct KJKAMIDHEKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public AsyncTaskMethodBuilder<CCONCDOKPJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public CCONCDOKPJO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public GFIDHIPLGBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public OMNPNKGOFMO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private TaskAwaiter<CCONCDOKPJO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x772E500", Offset = "0x772D900", VA = "0x18772E500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x772EB10", Offset = "0x772DF10", VA = "0x18772EB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct DAAHIFHMLKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<CCONCDOKPJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public GFIDHIPLGBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public OMNPNKGOFMO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter<IKHDHHPOJEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x771CEA0", Offset = "0x771C2A0", VA = "0x18771CEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x771D490", Offset = "0x771C890", VA = "0x18771D490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class MJDJIFOLHMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public CCONCDOKPJO request;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public MJDJIFOLHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x7731D90", Offset = "0x7731190", VA = "0x187731D90")]
		internal object KDOENGCANNL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct POGNBPPPHMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<CCONCDOKPJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CCONCDOKPJO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public GFIDHIPLGBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public OMNPNKGOFMO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private JKHEJALAHKH <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private FAGDHJGOIDG <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter<IKHDHHPOJEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x7735C00", Offset = "0x7735000", VA = "0x187735C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x77367F0", Offset = "0x7735BF0", VA = "0x1877367F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private HCMOGHGOBGB NPGFBLNGFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private BIOGHNKCPHL LIJLFMNEHLF;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private HOEBJIIEGFO MKEAELGMPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7723A70", Offset = "0x7722E70", VA = "0x187723A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7723B30", Offset = "0x7722F30", VA = "0x187723B30", Slot = "8")]
	public void OOJJEJPOBFE(FGMEGFCAHOO EKABOCOCDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x7723470", Offset = "0x7722870", VA = "0x187723470", Slot = "4")]
	[AsyncStateMachine(typeof(KJKAMIDHEKG))]
	public Task<CCONCDOKPJO> AKCAIKBEDBB(CCONCDOKPJO BLIDGDGMCAP, OMNPNKGOFMO GMKEFJJNHMB, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7723920", Offset = "0x7722D20", VA = "0x187723920", Slot = "5")]
	[AsyncStateMachine(typeof(DAAHIFHMLKI))]
	public Task<CCONCDOKPJO> MBBHIOBAONA(CancellationToken FHGIOBPPFHG, OMNPNKGOFMO GMKEFJJNHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7723730", Offset = "0x7722B30", VA = "0x187723730", Slot = "6")]
	public FJBKMLGOLKO GEKIPADBFNM(KJPDDBJMGCN GCLMCFNJLCG, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x77237E0", Offset = "0x7722BE0", VA = "0x1877237E0", Slot = "7")]
	public FJBKMLGOLKO JEDCIOEPNKP(KJPDDBJMGCN GCLMCFNJLCG, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x77235D0", Offset = "0x77229D0", VA = "0x1877235D0")]
	[AsyncStateMachine(typeof(POGNBPPPHMG))]
	private Task<CCONCDOKPJO> FMOIJBHHIHA(CCONCDOKPJO BLIDGDGMCAP, OMNPNKGOFMO GMKEFJJNHMB, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x30270A0", Offset = "0x30264A0", VA = "0x1830270A0")]
	private static byte[] ONHMFLHLILM(CCONCDOKPJO LNICHECHJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public GFIDHIPLGBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class GNJMDPLODMI : AIMAIBHBLDD, LEKKAGKCCHD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private KAINKLBPDLA DOHDOJDMGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private HCMOGHGOBGB NPGFBLNGFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private LHHDEKNNILG GMCCGJOCKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private OPHHCOONIMC LFLDOJBNIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private HJHDHMCCGBJ IHMGMGMEKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private KBJHGCHDPOA HKPGINJDHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private EKHPCFNCOAH JJPFBNGEBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private BFPGCNENHGP JAGODFHKNAI;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private HJHCBNKLCIG GAFOLMMMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x77244C0", Offset = "0x77238C0", VA = "0x1877244C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private static BMNBHAPJIMJ ANLKMKLKLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x7724150", Offset = "0x7723550", VA = "0x187724150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7724570", Offset = "0x7723970", VA = "0x187724570", Slot = "6")]
	public void OOJJEJPOBFE(FGMEGFCAHOO EKABOCOCDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x77246E0", Offset = "0x7723AE0", VA = "0x1877246E0", Slot = "4")]
	public BMNBHAPJIMJ PHLNOMJAJEJ(GHBEGPNJJCK KAGCDLLONEE, AMGJKMNLMLJ HPBFPGBNKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x77241B0", Offset = "0x77235B0", VA = "0x1877241B0", Slot = "5")]
	public BMNBHAPJIMJ MIGHFFPFNAI(GHBEGPNJJCK JBOJCMIBDGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7724510", Offset = "0x7723910", VA = "0x187724510")]
	private static BMNBHAPJIMJ NMALFKILIKP(NMIBGAKAKKA OCIFOIBHPJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public GNJMDPLODMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class CIHEGACMOMI : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x771BDD0", Offset = "0x771B1D0", VA = "0x18771BDD0")]
	public CIHEGACMOMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x6ACEFF0", Offset = "0x6ACE3F0", VA = "0x186ACEFF0")]
	public CIHEGACMOMI(string LNICHECHJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[UnityEngine.Scripting.Preserve]
internal sealed class BODLLKLPFCL : BIFNOFKPNFP, LEKKAGKCCHD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct NGGHBNDMGBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public AsyncTaskMethodBuilder<BMNBHAPJIMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public BODLLKLPFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public OGAHHHAJHDC autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private LOALKKNJJLG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private CNKHPAKNHDN <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter<BMNBHAPJIMJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7733290", Offset = "0x7732690", VA = "0x187733290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7733E00", Offset = "0x7733200", VA = "0x187733E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct DACLBGMFHOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public BODLLKLPFCL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x771D500", Offset = "0x771C900", VA = "0x18771D500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x771DC40", Offset = "0x771D040", VA = "0x18771DC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct LDJLCJJFDJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public BODLLKLPFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x772F6A0", Offset = "0x772EAA0", VA = "0x18772F6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x772FBB0", Offset = "0x772EFB0", VA = "0x18772FBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct MPLJAFAOLCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public BODLLKLPFCL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7732090", Offset = "0x7731490", VA = "0x187732090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x77327D0", Offset = "0x7731BD0", VA = "0x1877327D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct CMLFPHPDCPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public BODLLKLPFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x771C310", Offset = "0x771B710", VA = "0x18771C310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x771C4B0", Offset = "0x771B8B0", VA = "0x18771C4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct HFNNEOAKLNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public BODLLKLPFCL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7726180", Offset = "0x7725580", VA = "0x187726180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7726890", Offset = "0x7725C90", VA = "0x187726890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct EOPCDLOJLMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public BODLLKLPFCL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x77206F0", Offset = "0x771FAF0", VA = "0x1877206F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7720B60", Offset = "0x771FF60", VA = "0x187720B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct AMCCCPHGJBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public BODLLKLPFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public BFBICLDJJAD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private LOALKKNJJLG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7718C90", Offset = "0x7718090", VA = "0x187718C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x77191F0", Offset = "0x77185F0", VA = "0x1877191F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private HCMOGHGOBGB NPGFBLNGFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private FGMEGFCAHOO EKABOCOCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private HJHDHMCCGBJ IHMGMGMEKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private MPGGJDCHONJ PDGJKDOGMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private LHHDEKNNILG GMCCGJOCKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private EKHPCFNCOAH JJPFBNGEBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private CancellationTokenSource JKFECFMONAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private Task HHBIGJCNNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private TaskCompletionSource<int> GOAHJBOAHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private int GOCGBGGOMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private int AOOFONBLALH;

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x771A400", Offset = "0x7719800", VA = "0x18771A400", Slot = "6")]
	public void OOJJEJPOBFE(FGMEGFCAHOO EKABOCOCDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0xE44590", Offset = "0xE43990", VA = "0x180E44590", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x77199A0", Offset = "0x7718DA0", VA = "0x1877199A0")]
	private void HOMMCMKIBHF(float NKGNAJLJPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7719690", Offset = "0x7718A90", VA = "0x187719690", Slot = "4")]
	[AsyncStateMachine(typeof(NGGHBNDMGBH))]
	public Task<BMNBHAPJIMJ> BDHBKOJDFHN(OGAHHHAJHDC KGCIEMPDBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x77198B0", Offset = "0x7718CB0", VA = "0x1877198B0", Slot = "5")]
	[AsyncStateMachine(typeof(DACLBGMFHOP))]
	public Task HFFAGDBFNIE([Optional] CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0xE44590", Offset = "0xE43990", VA = "0x180E44590")]
	public void ICJGOGNOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7719A80", Offset = "0x7718E80", VA = "0x187719A80")]
	private CNKHPAKNHDN IHCOEOIPNMA(OGAHHHAJHDC KGCIEMPDBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7719E00", Offset = "0x7719200", VA = "0x187719E00")]
	[AsyncStateMachine(typeof(LDJLCJJFDJE))]
	private Task KJLEBEANAKP(CancellationToken FGKKJOBPJBP, int HLAOHLMDNLM, AECOPHFIFAP HKGLPPGLJFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x7719EF0", Offset = "0x77192F0", VA = "0x187719EF0")]
	[AsyncStateMachine(typeof(MPLJAFAOLCB))]
	private Task MOMGGMJHJHA(CancellationToken FGKKJOBPJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x771A5B0", Offset = "0x77199B0", VA = "0x18771A5B0")]
	[AsyncStateMachine(typeof(CMLFPHPDCPL))]
	private Task PGFLNDFJLBG([Optional] CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x77197C0", Offset = "0x7718BC0", VA = "0x1877197C0")]
	[AsyncStateMachine(typeof(HFNNEOAKLNP))]
	private Task GJIHMCOGFON(CancellationToken FGKKJOBPJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7719D00", Offset = "0x7719100", VA = "0x187719D00")]
	[AsyncStateMachine(typeof(EOPCDLOJLMG))]
	private Task KFKPJINDNAL(CancellationToken KLCFIJKKPOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x7719FF0", Offset = "0x77193F0", VA = "0x187719FF0")]
	private Task NMKKPGADOCH(BFBICLDJJAD ODJFJIBMPIO, CancellationToken FGKKJOBPJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x7719BF0", Offset = "0x7718FF0", VA = "0x187719BF0")]
	[AsyncStateMachine(typeof(AMCCCPHGJBM))]
	private Task JFIFBDPOEKN(BFBICLDJJAD ODJFJIBMPIO, CancellationToken FGKKJOBPJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x771A180", Offset = "0x7719580", VA = "0x18771A180")]
	private bool ONKONKGPEJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public BODLLKLPFCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[UnityEngine.Scripting.Preserve]
internal class LANDAONHHMN : OPHHCOONIMC, LEKKAGKCCHD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct JCJENKOHPBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public LANDAONHHMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private LOALKKNJJLG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x772AFF0", Offset = "0x772A3F0", VA = "0x18772AFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x772B560", Offset = "0x772A960", VA = "0x18772B560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private GGPPIGPEPAI LCGACHEIPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private FGMEGFCAHOO EKABOCOCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private AIMAIBHBLDD MENNAMHALEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private MPGGJDCHONJ PDGJKDOGMEJ;

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x772EE20", Offset = "0x772E220", VA = "0x18772EE20", Slot = "6")]
	public void OOJJEJPOBFE(FGMEGFCAHOO EKABOCOCDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x772EC80", Offset = "0x772E080", VA = "0x18772EC80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x772EB80", Offset = "0x772DF80", VA = "0x18772EB80", Slot = "5")]
	[AsyncStateMachine(typeof(JCJENKOHPBI))]
	public Task BDOJLINNIAP(string DFDAPFPPOMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x772EDC0", Offset = "0x772E1C0", VA = "0x18772EDC0", Slot = "4")]
	public BMNBHAPJIMJ ONKONKGPEJN(GHBEGPNJJCK KAGCDLLONEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x772ECD0", Offset = "0x772E0D0", VA = "0x18772ECD0")]
	private NCPKEFALMLK EKDBFPAJKJH(string DFDAPFPPOMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public LANDAONHHMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class DDOEOGGCEKP
{
	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x771E480", Offset = "0x771D880", VA = "0x18771E480")]
	public static void ODAGKBCNONC(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x771E320", Offset = "0x771D720", VA = "0x18771E320")]
	internal static void KDPPAGBMNDH(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x771DDF0", Offset = "0x771D1F0", VA = "0x18771DDF0")]
	internal static void CCHGLJIMIGG(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x771DED0", Offset = "0x771D2D0", VA = "0x18771DED0")]
	internal static void DAIPFIFNMGD(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class KFNJKOLOAJG : EFIDJKPPBOL<CCONCDOKPJO>
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class NFNJJKEHGGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public CCONCDOKPJO message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public NFNJJKEHGGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7732F40", Offset = "0x7732340", VA = "0x187732F40")]
		internal object KBOMPNLLDFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly KFNJKOLOAJG ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x772DD60", Offset = "0x772D160", VA = "0x18772DD60")]
	public ExitGames.Client.Photon.Hashtable GKPJGNLGAKF(CCONCDOKPJO LNICHECHJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x772E020", Offset = "0x772D420", VA = "0x18772E020", Slot = "5")]
	protected override void KDOCBHMAIFO(CCONCDOKPJO LNICHECHJFC, IDictionary<object, object> JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x772DDF0", Offset = "0x772D1F0", VA = "0x18772DDF0", Slot = "6")]
	public override CCONCDOKPJO KBLFJIABLOP(IDictionary<object, object> JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x772E150", Offset = "0x772D550", VA = "0x18772E150")]
	private static void LDCMEBNGNBB(string OFPCHMPPOHL, CCONCDOKPJO LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x772E2F0", Offset = "0x772D6F0", VA = "0x18772E2F0")]
	public KFNJKOLOAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x772DAC0", Offset = "0x772CEC0", VA = "0x18772DAC0")]
	[CompilerGenerated]
	internal static string GDOIPDDHIEL(FPMKMFBIMPJ PBJNGGAILNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class HEMICMMJAJI
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public static BMNBHAPJIMJ ANLKMKLKLPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x7724150", Offset = "0x7723550", VA = "0x187724150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x7726160", Offset = "0x7725560", VA = "0x187726160")]
	public static bool JEMEOGMBJNK(this BMNBHAPJIMJ OAFNHPEIMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x7724510", Offset = "0x7723910", VA = "0x187724510")]
	public static BMNBHAPJIMJ NMALFKILIKP(NMIBGAKAKKA IPBIFNNEPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7725F70", Offset = "0x7725370", VA = "0x187725F70")]
	public static BMNBHAPJIMJ IKBDPFEGLCN(IEnumerable<BMNBHAPJIMJ> HNGMDEDAKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x7725D20", Offset = "0x7725120", VA = "0x187725D20")]
	public static string HLHHKMGGCEE(this BMNBHAPJIMJ CEDDFJCBLGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public abstract class MDLNANPNEJA : HFIFNFAINFO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public delegate BMNBHAPJIMJ PJGINHCNAPB([NotNull] GHBEGPNJJCK GDDBEGDLDDK);

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class LDODFILONEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public GHBEGPNJJCK photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public LDODFILONEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x6CD8D10", Offset = "0x6CD8110", VA = "0x186CD8D10")]
		internal BMNBHAPJIMJ AEPKIDOHPJI(PJGINHCNAPB v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private bool IOFECLNHDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	protected readonly HashSet<PJGINHCNAPB> NEDLHBPLLJP;

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x7731B00", Offset = "0x7730F00", VA = "0x187731B00", Slot = "4")]
	public void MMIGONDOPLE(PJGINHCNAPB DGPMLMKLKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7731B60", Offset = "0x7730F60", VA = "0x187731B60", Slot = "5")]
	public void PHADPAAOMOE(PJGINHCNAPB DGPMLMKLKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x7731820", Offset = "0x7730C20", VA = "0x187731820", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x7731870", Offset = "0x7730C70", VA = "0x187731870")]
	protected BMNBHAPJIMJ EDNMHMPNAKH(GHBEGPNJJCK JBOJCMIBDGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7731BC0", Offset = "0x7730FC0", VA = "0x187731BC0")]
	protected MDLNANPNEJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class LEOJAMNGMFE : MDLNANPNEJA, KAINKLBPDLA, HFIFNFAINFO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private sealed class PGMEJFHIAHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public BMNBHAPJIMJ result;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public PGMEJFHIAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7735730", Offset = "0x7734B30", VA = "0x187735730")]
		internal object AHIPHGFDGGE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x771E7D0", Offset = "0x771DBD0", VA = "0x18771E7D0")]
	[UnityEngine.Scripting.Preserve]
	public LEOJAMNGMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x772FC10", Offset = "0x772F010", VA = "0x18772FC10", Slot = "8")]
	public BMNBHAPJIMJ GCAKAKJFNFN(GHBEGPNJJCK JBOJCMIBDGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class DPIFNJFMBIJ : MDLNANPNEJA, GGPPIGPEPAI, HFIFNFAINFO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private sealed class HMPHHGHKBDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public BMNBHAPJIMJ result;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public HMPHHGHKBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7727270", Offset = "0x7726670", VA = "0x187727270")]
		internal object CKKOHKILBPI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x771E7D0", Offset = "0x771DBD0", VA = "0x18771E7D0")]
	[UnityEngine.Scripting.Preserve]
	public DPIFNJFMBIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x771E6C0", Offset = "0x771DAC0", VA = "0x18771E6C0", Slot = "8")]
	public BMNBHAPJIMJ ONKONKGPEJN(GHBEGPNJJCK JHJHBOANJNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class OLDEJANLIHG
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private sealed class FIHHDJOCHGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public LOALKKNJJLG<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public FIHHDJOCHGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7722B40", Offset = "0x7721F40", VA = "0x187722B40")]
		internal object ADGBOMNAPLF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7735480", Offset = "0x7734880", VA = "0x187735480")]
	public static LOALKKNJJLG<string> FCICGPAGONC(GKOKEEMOOFG GGCNADGKGHO, [Optional] string CEPLLPEMOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x7735560", Offset = "0x7734960", VA = "0x187735560")]
	public static void NCCGCOMHPIH(LOALKKNJJLG<string> HIKLLEDALJM, GKOKEEMOOFG GGCNADGKGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x77353C0", Offset = "0x77347C0", VA = "0x1877353C0")]
	public static string FBJMLLMAOKF(CCONCDOKPJO KMKPLDDNJFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal static class MIJGPEEGPHO
{
	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x7731D80", Offset = "0x7731180", VA = "0x187731D80")]
	public static void PPFCCJDDMKP(this HCMOGHGOBGB NPGFBLNGFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x7731D70", Offset = "0x7731170", VA = "0x187731D70")]
	public static void NOPHLBHHEDK(this HCMOGHGOBGB NPGFBLNGFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7731C50", Offset = "0x7731050", VA = "0x187731C50")]
	private static void NAKNLDNCDGN(this HCMOGHGOBGB NPGFBLNGFLA, bool JFKAFIHCALD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class ADHJKEAFJDG : IPELBJBIFJI, FHDKBEFMFDM, DAILNJMEEOC, AGAJMHLEFKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private readonly FHDKBEFMFDM IJMNHEFCCAL;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public GHBEGPNJJCK DMLKJKHJLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x77186E0", Offset = "0x7717AE0", VA = "0x1877186E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public int LADHCIAOIJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7718730", Offset = "0x7717B30", VA = "0x187718730", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int OHFOJNENAJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7718BE0", Offset = "0x7717FE0", VA = "0x187718BE0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool FIJHLCJHAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public int MCFODFJCLLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x93EBD0", Offset = "0x93DFD0", VA = "0x18093EBD0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event GPHOFIKEMIO.MLPKLCKEMKK EAAMBDJOKAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event JOIEKMOCIMD HKDKLDGBPEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7718B40", Offset = "0x7717F40", VA = "0x187718B40", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x77188D0", Offset = "0x7717CD0", VA = "0x1877188D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> CAIBMMIBKEP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<GHBEGPNJJCK> FJJECOMGFJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action OOONPFFPPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x7718970", Offset = "0x7717D70", VA = "0x187718970", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7718780", Offset = "0x7717B80", VA = "0x187718780", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x953D10", Offset = "0x953110", VA = "0x180953D10")]
	public ADHJKEAFJDG(FHDKBEFMFDM IJMNHEFCCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x7718820", Offset = "0x7717C20", VA = "0x187718820", Slot = "8")]
	public bool FIJHKFHLJKI(byte PIAEBCPLIBI, ExitGames.Client.Photon.Hashtable AJFEAOELDAH, ENLDIOIDELJ EJAAFLFEGGC, SendOptions HGCPIIPPEMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7718A10", Offset = "0x7717E10", VA = "0x187718A10", Slot = "16")]
	public GHBEGPNJJCK GECKLKHADGN(int HKJDGEGEECN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "19")]
	public void NNHNGOEJCFO(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "20")]
	public void HAMBFDIKABP(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "21")]
	public void MCLKPIEMGPG(object CMNJCPJBHGE, bool DGOLCPKLMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x7718AF0", Offset = "0x7717EF0", VA = "0x187718AF0", Slot = "22")]
	public IDisposable HLAHIEGBJBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "23")]
	private bool BHIHMHFGJOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "24")]
	public void IFOIDFOOADP(StringBuilder DIOODJKKPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0xB3C290", Offset = "0xB3B690", VA = "0x180B3C290", Slot = "25")]
	public bool IJDACAIOMIE(bool MHPKBGBNFGL, [Out] string PLAICKAFAFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0xA8B4D0", Offset = "0xA8A8D0", VA = "0x180A8B4D0", Slot = "28")]
	public void CIMOEKIEDEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct GDOIDPAPDPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private readonly IDictionary<object, object> IAAPABJLNAL;

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x96A9A0", Offset = "0x969DA0", VA = "0x18096A9A0")]
	public GDOIDPAPDPJ(IDictionary<object, object> IAAPABJLNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7722C20", Offset = "0x7722020", VA = "0x187722C20")]
	public bool EEDMKJGEHIF([Out] CCONCDOKPJO LNICHECHJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x7722CD0", Offset = "0x77220D0", VA = "0x187722CD0")]
	public Guid IKPFHFEAPGB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x7722E70", Offset = "0x7722270", VA = "0x187722E70")]
	public BMNBHAPJIMJ MNEAPFDFHBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7722D80", Offset = "0x7722180", VA = "0x187722D80")]
	public static ExitGames.Client.Photon.Hashtable KOPOAAAOIOD(CCONCDOKPJO LNICHECHJFC, BMNBHAPJIMJ OAFNHPEIMDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal static class CCIPPNEDJBP
{
	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x771A9A0", Offset = "0x7719DA0", VA = "0x18771A9A0")]
	public static bool GHILPNNIIHI(this OPCCMKNHDBC PDGAIGHKDCM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct IMAOMDCNIFJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct ANCDDKKHHEC : IAsyncStateMachine
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
		public IMAOMDCNIFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7719250", Offset = "0x7718650", VA = "0x187719250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7719430", Offset = "0x7718830", VA = "0x187719430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private readonly CancellationTokenSource BPPNMIHDBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	private bool IOFECLNHDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private Task LCFJPCOMAFL;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool BDPCGJLEFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7727D60", Offset = "0x7727160", VA = "0x187727D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x7727EA0", Offset = "0x77272A0", VA = "0x187727EA0")]
	public IMAOMDCNIFJ(CancellationToken FHGIOBPPFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7727D90", Offset = "0x7727190", VA = "0x187727D90")]
	[AsyncStateMachine(typeof(ANCDDKKHHEC))]
	public Task KHDDLLKPKMC(Func<CancellationToken, List<Task>> ILPNKLCDJDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7727D10", Offset = "0x7727110", VA = "0x187727D10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public readonly struct OOCFCNOADMF<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct PAPELABADKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<DPJCBEABHHK<TData>, PJPEMJHFJLC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public LOALKKNJJLG<string>.HAPJMIAELKE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public OOCFCNOADMF<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private TaskAwaiter<ABNAGONECLM<DPJCBEABHHK<TData>, PJPEMJHFJLC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x4C442F0", Offset = "0x4C436F0", VA = "0x184C442F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x4357D30", Offset = "0x4357130", VA = "0x184357D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private readonly IGFOGCPKOGI<TGetDataArg, TData> OIKLGOFBDMC;

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x96A9A0", Offset = "0x969DA0", VA = "0x18096A9A0")]
	internal OOCFCNOADMF(IGFOGCPKOGI<TGetDataArg, TData> CFAPAOIIPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3A10", Offset = "0x4BA2E10", VA = "0x184BA3A10")]
	[AsyncStateMachine(typeof(OOCFCNOADMF<, >.PAPELABADKB))]
	public Task<ABNAGONECLM<DPJCBEABHHK<TData>, PJPEMJHFJLC>> JHABFMNEGNB(TGetDataArg FJIKACGIPBH, string EGONOFEHGJA, LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class BINNIGANPPO
{
	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC180", Offset = "0x2DDB580", VA = "0x182DDC180")]
	public static OOCFCNOADMF<TGetDataArg, TData> ODOFIFAGLAJ<TGetDataArg, TData>(IGFOGCPKOGI<TGetDataArg, TData> CFAPAOIIPAA)
	{
		return default(OOCFCNOADMF<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public struct DBMDMEAJGBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public readonly int HDJNINPDDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public readonly int? ADGOADEBJMK;

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x47A7840", Offset = "0x47A6C40", VA = "0x1847A7840")]
	public DBMDMEAJGBE(int CFOOJJGCIPD, [Optional] int? GPKDLBEEFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x771DCA0", Offset = "0x771D0A0", VA = "0x18771DCA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface OFIDHMMBCKN<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LNNBJLIHGJG();

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OFIDHMMBCKN<T> FMDFMIGIJCI(string PFKGJDDEPJK);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OFIDHMMBCKN<T> NJMMDIPKMIE(LBNAAKJDHEN<T> KLONGCLAKNP);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OFIDHMMBCKN<T> DFJMHNMAKJL(int MMEACNFBMEM);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OFIDHMMBCKN<T> BLBDHGBNJIL(int MMEACNFBMEM, JMEHIFFKICF<T> KEJELEOMBJP);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface MOAJKCFHBNI
{
	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OFIDHMMBCKN<T> MPHNPJDEGEI<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LLDAOLPLPJA MEDNFNDEBDK(Exception DIPLOOHMPFH);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DBMDMEAJGBE MHCMLHBPJPE(Exception DIPLOOHMPFH);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public delegate string LBNAAKJDHEN<in T>(T DIPLOOHMPFH) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public delegate int JMEHIFFKICF<in T>(T DIPLOOHMPFH) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class JALCHMADNMF : MOAJKCFHBNI
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private delegate string NCBDCKPIGOB(Exception DIPLOOHMPFH);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private delegate int JCKHILPNGGP(Exception DIPLOOHMPFH);

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class IBHJGDLPACH<T> : OFIDHMMBCKN<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class MIBBFKNBGDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public MIBBFKNBGDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
			internal string EGCMGKFFBLE(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class PMKIIOCDCLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public LBNAAKJDHEN<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public PMKIIOCDCLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x4CAE420", Offset = "0x4CAD820", VA = "0x184CAE420")]
			internal string KGIABEIPOFI(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class POKEIAPKIAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public JMEHIFFKICF<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public POKEIAPKIAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x4CAE420", Offset = "0x4CAD820", VA = "0x184CAE420")]
			internal int DHPBPJDAJLM(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private readonly JALCHMADNMF GEALOMHNOHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private readonly Type NENHDJHHPPP;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x43298C0", Offset = "0x4328CC0", VA = "0x1843298C0")]
		internal IBHJGDLPACH(JALCHMADNMF GEALOMHNOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x4329770", Offset = "0x4328B70", VA = "0x184329770", Slot = "4")]
		public void LNNBJLIHGJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x4329650", Offset = "0x4328A50", VA = "0x184329650", Slot = "5")]
		public OFIDHMMBCKN<T> FMDFMIGIJCI(string PFKGJDDEPJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x43297A0", Offset = "0x4328BA0", VA = "0x1843297A0", Slot = "6")]
		public OFIDHMMBCKN<T> NJMMDIPKMIE(LBNAAKJDHEN<T> KLONGCLAKNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x4329610", Offset = "0x4328A10", VA = "0x184329610", Slot = "7")]
		public OFIDHMMBCKN<T> DFJMHNMAKJL(int MMEACNFBMEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x43294D0", Offset = "0x43288D0", VA = "0x1843294D0", Slot = "8")]
		public OFIDHMMBCKN<T> BLBDHGBNJIL(int MMEACNFBMEM, JMEHIFFKICF<T> KEJELEOMBJP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class OHIOIKOFHNK<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private bool JOMMBDLLPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly List<Type> AGCPGGOPLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private readonly Dictionary<Type, TVal> ONNHFDIPJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private readonly Dictionary<Type, int> AACGHOLNBBJ;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public IReadOnlyList<Type> MOKEEGCLJJM
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x4B82990", Offset = "0x4B81D90", VA = "0x184B82990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x4B82A50", Offset = "0x4B81E50", VA = "0x184B82A50")]
		public OHIOIKOFHNK(Dictionary<Type, int> AACGHOLNBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x4B825B0", Offset = "0x4B819B0", VA = "0x184B825B0")]
		public void EBDKDKCDLND(Type LDCKBFKFIKC, TVal BBFFJMPBBGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x4B82550", Offset = "0x4B81950", VA = "0x184B82550")]
		public bool DNMFDEBNPOH(Type NENHDJHHPPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x4B82870", Offset = "0x4B81C70", VA = "0x184B82870")]
		public bool HAKPEAPDBLH(TVal HCPAOILCJCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x4B824F0", Offset = "0x4B818F0", VA = "0x184B824F0")]
		public TVal AFFELPLAAIM(Type IFBDJLKPHIG)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x4B827D0", Offset = "0x4B81BD0", VA = "0x184B827D0")]
		[CompilerGenerated]
		private int GEDPIKIBCFJ(Type PAANILDCACJ, Type MNCLMKMMFIC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class HGLPLILALPL : IEnumerable<DBMDMEAJGBE>, IEnumerable, IEnumerator<DBMDMEAJGBE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private DBMDMEAJGBE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public JALCHMADNMF <>4__this;

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
		private IEnumerator<DBMDMEAJGBE> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private DBMDMEAJGBE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0x3D3AB80", Offset = "0x3D39F80", VA = "0x183D3AB80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(DBMDMEAJGBE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x7726F50", Offset = "0x7726350", VA = "0x187726F50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xADC3A0", Offset = "0xADB7A0", VA = "0x180ADC3A0")]
		[DebuggerHidden]
		public HGLPLILALPL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x7726FA0", Offset = "0x77263A0", VA = "0x187726FA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x7726940", Offset = "0x7725D40", VA = "0x187726940", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x7726DF0", Offset = "0x77261F0", VA = "0x187726DF0")]
		private void NOLPLDAPGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x77268F0", Offset = "0x7725CF0", VA = "0x1877268F0")]
		private void GFPCIOJGMDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x7726F00", Offset = "0x7726300", VA = "0x187726F00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x7726E40", Offset = "0x7726240", VA = "0x187726E40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DBMDMEAJGBE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x7726E40", Offset = "0x7726240", VA = "0x187726E40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private static readonly DBMDMEAJGBE MNANLANPIBI;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private static readonly Dictionary<Type, int> CKEICFILHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly HashSet<Type> GPCEKLCPGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly OHIOIKOFHNK<int> EKNNMFCIBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private readonly OHIOIKOFHNK<JCKHILPNGGP> ADBCMEODHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly OHIOIKOFHNK<NCBDCKPIGOB> LKGJCDHCLDJ;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x772AA50", Offset = "0x7729E50", VA = "0x18772AA50")]
	[AGCFNMIICNN.OGAOPBBDHOG.CHABDOHBNJI]
	internal static void OHHPJPBCCIE(CGJHFFGEHKC AEBJKCFPLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x772AC20", Offset = "0x772A020", VA = "0x18772AC20")]
	[RecRoom.NoEngine.Common.Preserve]
	public JALCHMADNMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2E46CD0", Offset = "0x2E460D0", VA = "0x182E46CD0", Slot = "4")]
	public OFIDHMMBCKN<T> MPHNPJDEGEI<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x772A7C0", Offset = "0x7729BC0", VA = "0x18772A7C0", Slot = "5")]
	public LLDAOLPLPJA MEDNFNDEBDK(Exception DIPLOOHMPFH)
	{
		return default(LLDAOLPLPJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x772A850", Offset = "0x7729C50", VA = "0x18772A850", Slot = "6")]
	public DBMDMEAJGBE MHCMLHBPJPE(Exception? DIPLOOHMPFH)
	{
		return default(DBMDMEAJGBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x772AAC0", Offset = "0x7729EC0", VA = "0x18772AAC0", Slot = "7")]
	[IteratorStateMachine(typeof(HGLPLILALPL))]
	public IEnumerable<DBMDMEAJGBE> ONHOFJONHFI(Exception DIPLOOHMPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x772A670", Offset = "0x7729A70", VA = "0x18772A670", Slot = "8")]
	public string LFJOPAFFOJE(Exception? DIPLOOHMPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7729A90", Offset = "0x7728E90", VA = "0x187729A90")]
	private string FJAIPKINHAB(AggregateException BCGCDAIIIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7729E70", Offset = "0x7729270", VA = "0x187729E70")]
	private void GFNHIOPDMBF(Type NENHDJHHPPP, int MMEACNFBMEM, JCKHILPNGGP? EJBLBEFDBBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x7729840", Offset = "0x7728C40", VA = "0x187729840")]
	private void EKLLFELIALN(Type NENHDJHHPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x772A220", Offset = "0x7729620", VA = "0x18772A220")]
	private void IKNGNJFANNJ(Type NENHDJHHPPP, NCBDCKPIGOB AAAGMEAABFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x772A4F0", Offset = "0x77298F0", VA = "0x18772A4F0")]
	private static int KNDLKMDGNBE(Type NENHDJHHPPP, Dictionary<Type, int> AACGHOLNBBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x30C8F80", Offset = "0x30C8380", VA = "0x1830C8F80")]
	private static bool HFFCJNMNCJC<TVal>(OHIOIKOFHNK<TVal> KLODBELJCDF, Type NENHDJHHPPP, [Out] TVal HCPAOILCJCB) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7729D90", Offset = "0x7729190", VA = "0x187729D90")]
	[CompilerGenerated]
	internal static int FNKOEKMABMC(Type BHJIJLBOJJN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public struct LLDAOLPLPJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public readonly DBMDMEAJGBE JHGLEFBLDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public readonly string AIKLMANMGFG;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7730700", Offset = "0x772FB00", VA = "0x187730700")]
	public LLDAOLPLPJA(string KDDBMKCHINN, DBMDMEAJGBE MMEACNFBMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7730660", Offset = "0x772FA60", VA = "0x187730660")]
	public string CKKHDGGHLEL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class KDKGOMPODOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private readonly GMAGBLHDHPN OINOCADKCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private string DMDPCPEKOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private long? EBMCKDACJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private long? HFOGLNDEACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private long? LCEFBPAPBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private string OBLGCJPNBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private NNOEIPEILJE JOHIBEGLABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private long? OHCICJBELCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private bool OHHOAFGAPID;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string MIOFJKHFLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public long AMKBLKFJPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x772CFF0", Offset = "0x772C3F0", VA = "0x18772CFF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long KDDPKALDMMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x772D550", Offset = "0x772C950", VA = "0x18772D550")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public long HKECLHINDCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x772D5B0", Offset = "0x772C9B0", VA = "0x18772D5B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public string KFGCJCHOJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x772D2A0", Offset = "0x772C6A0", VA = "0x18772D2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public NNOEIPEILJE LMKDDICNJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x99DFB0", Offset = "0x99D3B0", VA = "0x18099DFB0")]
		get
		{
			return default(NNOEIPEILJE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x772D460", Offset = "0x772C860", VA = "0x18772D460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public long OBOAAGHFFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x772D2E0", Offset = "0x772C6E0", VA = "0x18772D2E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x772D980", Offset = "0x772CD80", VA = "0x18772D980")]
	[UnityEngine.Scripting.Preserve]
	public KDKGOMPODOP([CNGCCDLPGOD(null)] GMAGBLHDHPN OINOCADKCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x772D050", Offset = "0x772C450", VA = "0x18772D050")]
	private void FJICMOFDNDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x772CB60", Offset = "0x772BF60", VA = "0x18772CB60")]
	public void DGFDCCCGLHM(long GGLEGKBAGLC, long DLGNECIGKLC, [Optional] long? OPIAKLFIGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x772D340", Offset = "0x772C740", VA = "0x18772D340")]
	public void HIIHEHLOFAF(long OPIAKLFIGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x772D3E0", Offset = "0x772C7E0", VA = "0x18772D3E0")]
	public void IGAGKHDMHHM(string MEGDKFHABBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x772D610", Offset = "0x772CA10", VA = "0x18772D610")]
	public void OJMBBMFNELH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal class FJBKMLGOLKO : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct LJPBOCMNIAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder<CCONCDOKPJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public CCONCDOKPJO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public FJBKMLGOLKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private TaskAwaiter<HOEBJIIEGFO.EHMAMMNPFFL<CCONCDOKPJO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x774A940", Offset = "0x7749D40", VA = "0x18774A940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x774AE80", Offset = "0x774A280", VA = "0x18774AE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct LIMMCFAODKE<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class NFBHCBMJBGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public CCONCDOKPJO roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public NFBHCBMJBGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x774C560", Offset = "0x774B960", VA = "0x18774C560")]
		internal CCONCDOKPJO OEPPFMHPICD(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct JNEOEMEFGKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public AsyncTaskMethodBuilder<HOEBJIIEGFO.EHMAMMNPFFL<CCONCDOKPJO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public CCONCDOKPJO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public FJBKMLGOLKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private JKHEJALAHKH <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private TaskAwaiter<HOEBJIIEGFO.EHMAMMNPFFL<CCONCDOKPJO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x7748DF0", Offset = "0x77481F0", VA = "0x187748DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x7749400", Offset = "0x7748800", VA = "0x187749400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct AHMHDKABONN<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public FJBKMLGOLKO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x41D8BD0", Offset = "0x41D7FD0", VA = "0x1841D8BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x39B37C0", Offset = "0x39B2BC0", VA = "0x1839B37C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct LDBANNKHHDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public FJBKMLGOLKO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x774A720", Offset = "0x7749B20", VA = "0x18774A720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x774A8E0", Offset = "0x7749CE0", VA = "0x18774A8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class AAIHOAMNGKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public AAIHOAMNGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x7737250", Offset = "0x7736650", VA = "0x187737250")]
		internal object MHEADAIANBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x7737190", Offset = "0x7736590", VA = "0x187737190")]
		internal bool CIJHDBECCEO(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class JGFKDELCLDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JGFKDELCLDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x7747CB0", Offset = "0x77470B0", VA = "0x187747CB0")]
		internal object HBDOFEKFOEA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class DBEJCDGEFJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public DBEJCDGEFJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x773CA70", Offset = "0x773BE70", VA = "0x18773CA70")]
		internal object NPGKDIFJCBB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class MLOKDDNCFEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public MLOKDDNCFEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x774C2B0", Offset = "0x774B6B0", VA = "0x18774C2B0")]
		internal object HBBDHMLIMCO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class OIDILPIAEKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public FJBKMLGOLKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public OIDILPIAEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x774DA00", Offset = "0x774CE00", VA = "0x18774DA00")]
		internal object KBOMPNLLDFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private static readonly Guid FFILAOFDJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public readonly KJPDDBJMGCN DPEHFFFLHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly HOEBJIIEGFO GMALKKBADHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private readonly DAILNJMEEOC NPGFBLNGFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private readonly AGAJMHLEFKP NMDMIAFLIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private bool JKKHCJPLDIB;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x77425E0", Offset = "0x77419E0", VA = "0x1877425E0")]
	public FJBKMLGOLKO(KJPDDBJMGCN CGENICICIAO, HOEBJIIEGFO GMALKKBADHG, DAILNJMEEOC NPGFBLNGFLA, AGAJMHLEFKP NMDMIAFLIGF, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7741980", Offset = "0x7740D80", VA = "0x187741980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7741570", Offset = "0x7740970", VA = "0x187741570")]
	public void CDIPJOJGGCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x7742230", Offset = "0x7741630", VA = "0x187742230")]
	public void MKEKHFFGLDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7741E80", Offset = "0x7741280", VA = "0x187741E80")]
	public void JIKPHPLEBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x77417D0", Offset = "0x7740BD0", VA = "0x1877417D0")]
	[AsyncStateMachine(typeof(LJPBOCMNIAB))]
	internal Task<CCONCDOKPJO> DFOJOOAJDDG(LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CCONCDOKPJO KMKPLDDNJFB, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x30270A0", Offset = "0x30264A0", VA = "0x1830270A0")]
	private static byte[] FJPAIPFJAFD<T>(T LNICHECHJFC) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x3026CB0", Offset = "0x30260B0", VA = "0x183026CB0")]
	private static T ENMJBMEJMNH<T>(MessageParser<T> AFKFJBCGION, byte[] LNICHECHJFC, T KGGCKPJBIDN) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x7741690", Offset = "0x7740A90", VA = "0x187741690")]
	[AsyncStateMachine(typeof(JNEOEMEFGKD))]
	private Task<HOEBJIIEGFO.EHMAMMNPFFL<CCONCDOKPJO>> DFNNFNAICIE(CCONCDOKPJO KMKPLDDNJFB, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x3026A10", Offset = "0x3025E10", VA = "0x183026A10")]
	[AsyncStateMachine(typeof(AHMHDKABONN<>))]
	internal Task<T> ENLMIOIOCOG<T>(CancellationToken FGKKJOBPJBP, Func<CancellationToken, Task<T>> LBBNNPJELPI, int HINPMNKBMHP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7741990", Offset = "0x7740D90", VA = "0x187741990")]
	[AsyncStateMachine(typeof(LDBANNKHHDL))]
	internal Task ENLMIOIOCOG(CancellationToken FGKKJOBPJBP, Func<CancellationToken, Task> LBBNNPJELPI, int HINPMNKBMHP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7741F40", Offset = "0x7741340", VA = "0x187741F40")]
	public ENILGKKBBJD KAHOGPOECID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x77414F0", Offset = "0x77408F0", VA = "0x1877414F0")]
	public BHGLKAANHID BJPKMHJDNBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7741D00", Offset = "0x7741100", VA = "0x187741D00")]
	public IFNCKGOBGJO INDGACNEOKJ([Optional] GKOKEEMOOFG? GGCNADGKGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7741FC0", Offset = "0x77413C0", VA = "0x187741FC0")]
	public void LCOMOJKPGEB(Func<Guid, bool> AICBJKANNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x77422F0", Offset = "0x77416F0", VA = "0x1877422F0")]
	public void NBJKIAOLMBN(Func<Guid, bool> OOMJANKNCBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7742400", Offset = "0x7741800", VA = "0x187742400")]
	public Guid NLAHALBLHIL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x7741BF0", Offset = "0x7740FF0", VA = "0x187741BF0")]
	public void IHHMKBLGCLC(Guid ICLHOIPKEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7741AC0", Offset = "0x7740EC0", VA = "0x187741AC0")]
	public void FDGHEPKJHHE(CCONCDOKPJO IONFHEGBLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7742120", Offset = "0x7741520", VA = "0x187742120")]
	public void LDCMEBNGNBB(string NIEONIJPKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x3026930", Offset = "0x3025D30", VA = "0x183026930")]
	private T BEKPNNCMPNJ<T>(T HCPAOILCJCB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x7741930", Offset = "0x7740D30", VA = "0x187741930")]
	public void DIBHPLFAAPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x3026E00", Offset = "0x3026200", VA = "0x183026E00")]
	[CompilerGenerated]
	internal static string FIEJPMGPDEK<T>(byte[] MDABPMPEKPN, int HOCAGGHKPKE, LIMMCFAODKE<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal sealed class IFPHBAEOGCF : KJPDDBJMGCN
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class HKANDDGEEMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public HKANDDGEEMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x77454D0", Offset = "0x77448D0", VA = "0x1877454D0")]
		internal object ILHGHBJFLPC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct EFPNALNNKMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public IFPHBAEOGCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public FJBKMLGOLKO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private GJHHDDAHPMJ <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private BHGLKAANHID <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x773D850", Offset = "0x773CC50", VA = "0x18773D850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x773E120", Offset = "0x773D520", VA = "0x18773E120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct GKHEAEDIFBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public IFPHBAEOGCF <>4__this;

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
		private TaskAwaiter<NLMAEEICDJF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x7743FA0", Offset = "0x77433A0", VA = "0x187743FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x77446E0", Offset = "0x7743AE0", VA = "0x1877446E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct EDPEJPKIIGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public IFPHBAEOGCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private TaskAwaiter<GNODDIAAKFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x773D3D0", Offset = "0x773C7D0", VA = "0x18773D3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x773D6E0", Offset = "0x773CAE0", VA = "0x18773D6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class NKCACCAJAIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public GJHHDDAHPMJ presence;

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public NKCACCAJAIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x774C640", Offset = "0x774BA40", VA = "0x18774C640")]
		internal object JLILDHAMMOK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private static readonly GKOKEEMOOFG PAELLOBOLHG;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private static readonly GKOKEEMOOFG IIONJLPBMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000389")]
	private readonly FPMKMFBIMPJ KACHGOKLIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400038A")]
	private readonly OPCCMKNHDBC GICKIOGCEJF;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x7745D20", Offset = "0x7745120", VA = "0x187745D20")]
	public IFPHBAEOGCF(FPMKMFBIMPJ KACHGOKLIEC, OPCCMKNHDBC GICKIOGCEJF, Guid NDFJMJHNPGE, FGMEGFCAHOO EKABOCOCDBK, OMNPNKGOFMO ENKCDDDEHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x7745B10", Offset = "0x7744F10", VA = "0x187745B10", Slot = "7")]
	[AsyncStateMachine(typeof(EFPNALNNKMA))]
	protected override Task PLPLIMOGMCE(FJBKMLGOLKO NDIKCIPCMBB, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x7745A10", Offset = "0x7744E10", VA = "0x187745A10")]
	[AsyncStateMachine(typeof(GKHEAEDIFBL))]
	private Task PEKMMMBABMF(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x7745900", Offset = "0x7744D00", VA = "0x187745900")]
	[AsyncStateMachine(typeof(EDPEJPKIIGB))]
	private Task<int> LGIILGEFKMG(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x7745740", Offset = "0x7744B40", VA = "0x187745740")]
	private GJHHDDAHPMJ BGIKPKKCCND()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class CNKHPAKNHDN : KJPDDBJMGCN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct ODMPBGJGLHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public CNKHPAKNHDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public FJBKMLGOLKO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private TaskAwaiter<GCEMIOFDIKP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x774D000", Offset = "0x774C400", VA = "0x18774D000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x774D9A0", Offset = "0x774CDA0", VA = "0x18774D9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private readonly int IMMJCOMGLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	private readonly OGAHHHAJHDC CKMDEKPOFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public readonly long JHIEDJKCDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public readonly long BGEIJJEHBEC;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public GCEMIOFDIKP COFEAFMJOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA20", Offset = "0x8CEE20", VA = "0x1808CFA20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB90", Offset = "0x8CEF90", VA = "0x1808CFB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x773B720", Offset = "0x773AB20", VA = "0x18773B720")]
	public CNKHPAKNHDN(Guid NDFJMJHNPGE, FGMEGFCAHOO EKABOCOCDBK, OMNPNKGOFMO ENKCDDDEHEI, int IMMJCOMGLFA, OGAHHHAJHDC CKMDEKPOFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x773B600", Offset = "0x773AA00", VA = "0x18773B600", Slot = "7")]
	[AsyncStateMachine(typeof(ODMPBGJGLHE))]
	protected override Task PLPLIMOGMCE(FJBKMLGOLKO NDIKCIPCMBB, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class NPFHOKPGCJM : KJPDDBJMGCN
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class DPAHGKNBIJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public NPFHOKPGCJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public NIAOGPBFGOC playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public DPAHGKNBIJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x773D300", Offset = "0x773C700", VA = "0x18773D300")]
		internal Task CCNFCNCFCKH(LOALKKNJJLG<string>.HAPJMIAELKE postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x773D340", Offset = "0x773C740", VA = "0x18773D340")]
		internal object JBJKDJDLMHN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct DIOMPEELNFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public NPFHOKPGCJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public FJBKMLGOLKO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private DPAHGKNBIJA <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x773CAE0", Offset = "0x773BEE0", VA = "0x18773CAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x773D2A0", Offset = "0x773C6A0", VA = "0x18773D2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct INHALHJCKKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public LOALKKNJJLG<string>.HAPJMIAELKE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public NIAOGPBFGOC playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public NPFHOKPGCJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x77466A0", Offset = "0x7745AA0", VA = "0x1877466A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x7746C40", Offset = "0x7746040", VA = "0x187746C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x774CA00", Offset = "0x774BE00", VA = "0x18774CA00")]
	public NPFHOKPGCJM(Guid NDFJMJHNPGE, FGMEGFCAHOO EKABOCOCDBK, OMNPNKGOFMO ENKCDDDEHEI, string PPNIAAKBEFH, LJNFHBCPNNB LNABBPEHJIJ, bool MCLOPJNELAN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x774C8C0", Offset = "0x774BCC0", VA = "0x18774C8C0", Slot = "7")]
	[AsyncStateMachine(typeof(DIOMPEELNFO))]
	protected override Task PLPLIMOGMCE(FJBKMLGOLKO NDIKCIPCMBB, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task NNLEACOALLB(FJBKMLGOLKO NDIKCIPCMBB, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x774C780", Offset = "0x774BB80", VA = "0x18774C780")]
	[AsyncStateMachine(typeof(INHALHJCKKN))]
	private Task BMFMOGCCGFC(IDisposable CGMDAMCNAFK, NIAOGPBFGOC FKBMJNMBFAA, LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class LLNCGPEGFAC : KJPDDBJMGCN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct HJFKADGFLDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public LLNCGPEGFAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public FJBKMLGOLKO operationContext;

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
		private TaskAwaiter<BIPJJKGGCNE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x7744F00", Offset = "0x7744300", VA = "0x187744F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x7745470", Offset = "0x7744870", VA = "0x187745470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly BFBICLDJJAD ODJFJIBMPIO;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x774C0C0", Offset = "0x774B4C0", VA = "0x18774C0C0")]
	public LLNCGPEGFAC(Guid NDFJMJHNPGE, FGMEGFCAHOO EKABOCOCDBK, OMNPNKGOFMO ENKCDDDEHEI, BFBICLDJJAD ODJFJIBMPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x774BEC0", Offset = "0x774B2C0", VA = "0x18774BEC0", Slot = "6")]
	protected override string IPFPLOAONEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x774BFA0", Offset = "0x774B3A0", VA = "0x18774BFA0", Slot = "7")]
	[AsyncStateMachine(typeof(HJFKADGFLDN))]
	protected override Task PLPLIMOGMCE(FJBKMLGOLKO NDIKCIPCMBB, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal abstract class KJPDDBJMGCN : FFAOHLJEEBB
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public delegate Task MFCEPPDPDHP(LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class FANFMMAHNBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public LOALKKNJJLG<string>.HAPJMIAELKE operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public KJPDDBJMGCN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public FANFMMAHNBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x7741170", Offset = "0x7740570", VA = "0x187741170")]
		internal Task PBCIHDMECKI(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class AOCBNHNOJKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public FANFMMAHNBB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public AOCBNHNOJKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x7737A90", Offset = "0x7736E90", VA = "0x187737A90")]
		internal object NGEMPDLFFMF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct CKNLJIOIEGK : IAsyncStateMachine
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
		public KJPDDBJMGCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public Func<KJPDDBJMGCN, LOALKKNJJLG<string>.HAPJMIAELKE, FJBKMLGOLKO> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private FANFMMAHNBB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private FJBKMLGOLKO <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private TaskAwaiter<CCONCDOKPJO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x7739AA0", Offset = "0x7738EA0", VA = "0x187739AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x773AC60", Offset = "0x773A060", VA = "0x18773AC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct FAAILNLAFDF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7740670", Offset = "0x773FA70", VA = "0x187740670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x7741110", Offset = "0x7740510", VA = "0x187741110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct BOPFJHHHGGI : IAsyncStateMachine
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
		public KJPDDBJMGCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x77396E0", Offset = "0x7738AE0", VA = "0x1877396E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x7739A40", Offset = "0x7738E40", VA = "0x187739A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public readonly Guid FINDPKDPGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public readonly ByteString ADJOEAGPKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public readonly OMNPNKGOFMO NLCBCODPOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	protected readonly string IBNPJPBIGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly FGMEGFCAHOO EKABOCOCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly bool MCLOPJNELAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly Queue<MFCEPPDPDHP> HBHNIFLPGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly NFELGJLCDGC CODHLAJFEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private readonly LJNFHBCPNNB LNABBPEHJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private bool HKIBNAGKODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public NNOEIPEILJE GHIKELHEHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public NNOEIPEILJE LGFGGMHLEMG;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public FGMEGFCAHOO ECFALHAGKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C7970", Offset = "0x8C6D70", VA = "0x1808C7970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public HJHDHMCCGBJ EEGJAFGKABI
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x7749D20", Offset = "0x7749120", VA = "0x187749D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public DEEAIEEIPBM AGEOCKPOFAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x7749F80", Offset = "0x7749380", VA = "0x187749F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public HJHCBNKLCIG GAFOLMMMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x774A1A0", Offset = "0x77495A0", VA = "0x18774A1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event PCHPOLLMJLF KJFPNPOBMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x774A100", Offset = "0x7749500", VA = "0x18774A100", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x7749F40", Offset = "0x7749340", VA = "0x187749F40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x774A5C0", Offset = "0x77499C0", VA = "0x18774A5C0")]
	protected KJPDDBJMGCN(Guid NDFJMJHNPGE, FGMEGFCAHOO EKABOCOCDBK, OMNPNKGOFMO ENKCDDDEHEI, string PPNIAAKBEFH, LJNFHBCPNNB LNABBPEHJIJ, bool MCLOPJNELAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x7749FD0", Offset = "0x77493D0", VA = "0x187749FD0", Slot = "6")]
	protected virtual string IPFPLOAONEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x7749D70", Offset = "0x7749170", VA = "0x187749D70")]
	public void BFHCCNIPDMG(MFCEPPDPDHP HCMKHHLLJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x7749F60", Offset = "0x7749360", VA = "0x187749F60")]
	protected void FFPFPNIKKFM(float AHHPGJOEACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x774A340", Offset = "0x7749740", VA = "0x18774A340")]
	[AsyncStateMachine(typeof(CKNLJIOIEGK))]
	public Task PKMNDLFOFHF(CancellationToken FHGIOBPPFHG, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, [Optional] Func<KJPDDBJMGCN, LOALKKNJJLG<string>.HAPJMIAELKE, FJBKMLGOLKO> EPADFOAKOBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x774A490", Offset = "0x7749890", VA = "0x18774A490")]
	[AsyncStateMachine(typeof(FAAILNLAFDF))]
	private static Task PLGIFPAJBCI(Func<CancellationToken, Task> DIDNLACHJIE, Func<CancellationToken, Task> DBKIGMJEAFP, CancellationToken FGKKJOBPJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x7749DD0", Offset = "0x77491D0", VA = "0x187749DD0")]
	private void BLLMIALGAIB(bool BIDPAAHCAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x7749A80", Offset = "0x7748E80", VA = "0x187749A80")]
	private void ALGHKNBAAJK(FJBKMLGOLKO NDIKCIPCMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task PLPLIMOGMCE(FJBKMLGOLKO NDIKCIPCMBB, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x774A220", Offset = "0x7749620", VA = "0x18774A220")]
	[AsyncStateMachine(typeof(BOPFJHHHGGI))]
	private Task PIDPPDNBEHL(LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x7749CA0", Offset = "0x77490A0", VA = "0x187749CA0")]
	public CCONCDOKPJO ALOKMBAHENP(JKHEJALAHKH GHJPJBAFCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x774A010", Offset = "0x7749410", VA = "0x18774A010")]
	[CompilerGenerated]
	private Task LLIHHJDHOMJ(CancellationToken OPGNNMINDKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x774A120", Offset = "0x7749520", VA = "0x18774A120")]
	[CompilerGenerated]
	private object MMMLCKKEKMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal sealed class IEJJCMPIOIH : NPFHOKPGCJM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct JKPFEIGILDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public IEJJCMPIOIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public FJBKMLGOLKO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private AFMCCHKAGHJ <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private BHGLKAANHID <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x7747D10", Offset = "0x7747110", VA = "0x187747D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x7748470", Offset = "0x7747870", VA = "0x187748470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	private readonly FPMKMFBIMPJ NFEMGLFEKJM;

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x7745690", Offset = "0x7744A90", VA = "0x187745690")]
	public IEJJCMPIOIH(Guid NDFJMJHNPGE, FGMEGFCAHOO EKABOCOCDBK, FPMKMFBIMPJ NFEMGLFEKJM, OMNPNKGOFMO ENKCDDDEHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x7745540", Offset = "0x7744940", VA = "0x187745540", Slot = "8")]
	[AsyncStateMachine(typeof(JKPFEIGILDC))]
	protected override Task NNLEACOALLB(FJBKMLGOLKO NDIKCIPCMBB, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class NCPKEFALMLK : KJPDDBJMGCN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct KCNKJHDMOPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public NCPKEFALMLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public FJBKMLGOLKO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private TaskAwaiter<BIPJJKGGCNE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x7749470", Offset = "0x7748870", VA = "0x187749470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x7749820", Offset = "0x7748C20", VA = "0x187749820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly string NNCJBHDKFKL;

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x774C430", Offset = "0x774B830", VA = "0x18774C430")]
	public NCPKEFALMLK(Guid NDFJMJHNPGE, FGMEGFCAHOO EKABOCOCDBK, OMNPNKGOFMO ENKCDDDEHEI, string NNCJBHDKFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x774C320", Offset = "0x774B720", VA = "0x18774C320", Slot = "7")]
	[AsyncStateMachine(typeof(KCNKJHDMOPL))]
	protected override Task PLPLIMOGMCE(FJBKMLGOLKO NDIKCIPCMBB, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal class IKPPGHHBICL : NPFHOKPGCJM
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class HGAFNLOHPNI
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
			public AsyncTaskMethodBuilder<CCONCDOKPJO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			public HGAFNLOHPNI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041C")]
			private TaskAwaiter<BIPJJKGGCNE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			private TaskAwaiter<CCONCDOKPJO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(RVA = "0x7750090", Offset = "0x774F490", VA = "0x187750090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x7750550", Offset = "0x774F950", VA = "0x187750550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public IKPPGHHBICL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public IFNCKGOBGJO serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public CDGJEEKFCOI roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public ENILGKKBBJD uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public HKHNPHNDIJN roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public HGAFNLOHPNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x7744DE0", Offset = "0x77441E0", VA = "0x187744DE0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<CCONCDOKPJO> CHEECBKPBIE(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct LKHGGDEECCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public IKPPGHHBICL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public FJBKMLGOLKO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private HGAFNLOHPNI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private AFMCCHKAGHJ <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private BHGLKAANHID <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private CCONCDOKPJO <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private TaskAwaiter<CCONCDOKPJO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x774AEF0", Offset = "0x774A2F0", VA = "0x18774AEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x774BE60", Offset = "0x774B260", VA = "0x18774BE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private static readonly GKOKEEMOOFG PAELLOBOLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private readonly int ELEAAIEFPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	[CanBeNull]
	private readonly AFDCCJMMFPI OIOCKBBMOLC;

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x7746370", Offset = "0x7745770", VA = "0x187746370")]
	public IKPPGHHBICL(Guid NDFJMJHNPGE, FGMEGFCAHOO EKABOCOCDBK, int ELEAAIEFPFE, AFDCCJMMFPI OIOCKBBMOLC, OMNPNKGOFMO ENKCDDDEHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x7746180", Offset = "0x7745580", VA = "0x187746180", Slot = "8")]
	[AsyncStateMachine(typeof(LKHGGDEECCP))]
	protected override Task NNLEACOALLB(FJBKMLGOLKO NDIKCIPCMBB, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x7746080", Offset = "0x7745480", VA = "0x187746080")]
	private void NFLEFMOILGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x7745EB0", Offset = "0x77452B0", VA = "0x187745EB0")]
	private void KIJAICPHDNM(LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, AFMCCHKAGHJ JOIHKBAHMPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal abstract class FFHKMDJJEOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public readonly KJPDDBJMGCN DPEHFFFLHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public readonly FJBKMLGOLKO HLDPNAPCMNF;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public HJHDHMCCGBJ EEGJAFGKABI
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x77412A0", Offset = "0x77406A0", VA = "0x1877412A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public HJHCBNKLCIG GAFOLMMMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x7741400", Offset = "0x7740800", VA = "0x187741400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x7741490", Offset = "0x7740890", VA = "0x187741490")]
	protected FFHKMDJJEOM(FJBKMLGOLKO NDIKCIPCMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x77412F0", Offset = "0x77406F0", VA = "0x1877412F0")]
	protected void LDCMEBNGNBB(string NIEONIJPKMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal struct EKLEDIHDDBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public Dictionary<Guid, List<BHDNCPJPFMP>> BCALAHFBFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public Dictionary<Guid, List<BHDNCPJPFMP>> DIBHEGKEFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public Dictionary<Guid, List<BHDNCPJPFMP>> KICICIHHBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public List<Guid> LBELPEENBOJ;

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x773E180", Offset = "0x773D580", VA = "0x18773E180")]
	public static EKLEDIHDDBM AFFELPLAAIM(HJHDHMCCGBJ IHMGMGMEKPB, NNOEIPEILJE KMBHNMBCHFF, MCGHEPNDHCL COKNKBNPIMH)
	{
		return default(EKLEDIHDDBM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct EBGPPMDOBAE
{
	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0")]
	public static EBGPPMDOBAE KOPOAAAOIOD()
	{
		return default(EBGPPMDOBAE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct NDOBDCNBMAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public readonly NLMAEEICDJF CIOKBAAIBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public readonly BEANCEBHDPC ELONMONDCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public readonly string EHJCFMNPKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public readonly OAOEDECEGIP EJFFMDCEBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public readonly OAOEDECEGIP MHINPKLKBNP;

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x774C4E0", Offset = "0x774B8E0", VA = "0x18774C4E0")]
	public NDOBDCNBMAD(NLMAEEICDJF CIOKBAAIBPO, BEANCEBHDPC ELONMONDCOI, string EHJCFMNPKKH, OAOEDECEGIP EJFFMDCEBKO, OAOEDECEGIP MHINPKLKBNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct CLKBEIKIKEH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private readonly FJBKMLGOLKO NDIKCIPCMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly Guid ICLHOIPKEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private bool BIDPAAHCAAA;

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x773B440", Offset = "0x773A840", VA = "0x18773B440")]
	public static CLKBEIKIKEH NLAHALBLHIL(FJBKMLGOLKO NDIKCIPCMBB)
	{
		return default(CLKBEIKIKEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0xD6F2E0", Offset = "0xD6E6E0", VA = "0x180D6F2E0")]
	public void NADHKJGIJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x773B160", Offset = "0x773A560", VA = "0x18773B160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x773B470", Offset = "0x773A870", VA = "0x18773B470")]
	private CLKBEIKIKEH(FJBKMLGOLKO NDIKCIPCMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x773B170", Offset = "0x773A570", VA = "0x18773B170")]
	private void IHHMKBLGCLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x773B3A0", Offset = "0x773A7A0", VA = "0x18773B3A0")]
	private Func<Guid, bool> NCPELCCABIN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal class BHGLKAANHID : FFHKMDJJEOM, FFAOHLJEEBB
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	public delegate Task<NNOEIPEILJE> EEDPKNBGCEF(MCGHEPNDHCL JGCOLLOOLHL, HHIHHHCKIEO DACICMMEJAO, NFELGJLCDGC MJHFIICPKEL, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct AJOGOFFEKHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public FPMKMFBIMPJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private CLKBEIKIKEH <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private TaskAwaiter<CCONCDOKPJO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x77372B0", Offset = "0x77366B0", VA = "0x1877372B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7737A30", Offset = "0x7736E30", VA = "0x187737A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct CLIOGFKAOLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public AsyncTaskMethodBuilder<CCONCDOKPJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public FPMKMFBIMPJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private TaskAwaiter<CCONCDOKPJO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x773ACC0", Offset = "0x773A0C0", VA = "0x18773ACC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x773B0F0", Offset = "0x773A4F0", VA = "0x18773B0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct HFHFBNFHGAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public FPMKMFBIMPJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x7744740", Offset = "0x7743B40", VA = "0x187744740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x7744D80", Offset = "0x7744180", VA = "0x187744D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class PLMNFFGLFHA
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
			public AsyncTaskMethodBuilder<NDOBDCNBMAD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public PLMNFFGLFHA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private NDOBDCNBMAD <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			private TaskAwaiter<NNOEIPEILJE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			private TaskAwaiter<NDOBDCNBMAD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(RVA = "0x774EB90", Offset = "0x774DF90", VA = "0x18774EB90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x774F2F0", Offset = "0x774E6F0", VA = "0x18774F2F0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<MCGHEPNDHCL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public PLMNFFGLFHA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private MCGHEPNDHCL <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			private TaskAwaiter<NNOEIPEILJE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			private TaskAwaiter<MCGHEPNDHCL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x774F360", Offset = "0x774E760", VA = "0x18774F360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x774F990", Offset = "0x774ED90", VA = "0x18774F990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public FPMKMFBIMPJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public NFELGJLCDGC preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public NFELGJLCDGC downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public NDOBDCNBMAD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public NFELGJLCDGC postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public MCGHEPNDHCL phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public KEGPANADHNE.AGLEJHOOMJP <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public PLMNFFGLFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x774EA50", Offset = "0x774DE50", VA = "0x18774EA50")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<NDOBDCNBMAD> NHHLHEAPMGA(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x774E630", Offset = "0x774DA30", VA = "0x18774E630")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<MCGHEPNDHCL> FJKMMPNCMFG(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x774E750", Offset = "0x774DB50", VA = "0x18774E750")]
		internal void KCNJICBLBIP(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x774E790", Offset = "0x774DB90", VA = "0x18774E790")]
		internal Task MPMDIKAOHJP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x774E8F0", Offset = "0x774DCF0", VA = "0x18774E8F0")]
		internal Task NFIMAINPLHC(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct EPBDOMOJKJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public FPMKMFBIMPJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private PLMNFFGLFHA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter<NDOBDCNBMAD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private TaskAwaiter<MCGHEPNDHCL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x773F8F0", Offset = "0x773ECF0", VA = "0x18773F8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x7740610", Offset = "0x773FA10", VA = "0x187740610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct IPEKJAEEKOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public MCGHEPNDHCL phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public NFELGJLCDGC postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private TaskAwaiter<NNOEIPEILJE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private HHIHHHCKIEO <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x7746CA0", Offset = "0x77460A0", VA = "0x187746CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x7747B30", Offset = "0x7746F30", VA = "0x187747B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct JNCJHDOOFOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public LOALKKNJJLG<string>.HAPJMIAELKE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x77484D0", Offset = "0x77478D0", VA = "0x1877484D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x7748D90", Offset = "0x7748190", VA = "0x187748D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct PAKFIGFEPEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public NFELGJLCDGC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private TaskAwaiter<NNOEIPEILJE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x774DC40", Offset = "0x774D040", VA = "0x18774DC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x774E5D0", Offset = "0x774D9D0", VA = "0x18774E5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct COOKMPNCPCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public AsyncTaskMethodBuilder<NNOEIPEILJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public NFELGJLCDGC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private TaskAwaiter<NNOEIPEILJE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x773B850", Offset = "0x773AC50", VA = "0x18773B850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x773CA00", Offset = "0x773BE00", VA = "0x18773CA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct ELEIHNNMGEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public AsyncTaskMethodBuilder<NNOEIPEILJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public NFELGJLCDGC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public HHIHHHCKIEO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private TaskAwaiter<NNOEIPEILJE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x773E780", Offset = "0x773DB80", VA = "0x18773E780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x773F880", Offset = "0x773EC80", VA = "0x18773F880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct GADAKIAFDNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public AsyncTaskMethodBuilder<NNOEIPEILJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public NNOEIPEILJE operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public NFELGJLCDGC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public MCGHEPNDHCL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private TaskAwaiter<NNOEIPEILJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x7742810", Offset = "0x7741C10", VA = "0x187742810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x7742AB0", Offset = "0x7741EB0", VA = "0x187742AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class JEDMFMFBKDH
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
			public AsyncTaskMethodBuilder<NNOEIPEILJE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			public JEDMFMFBKDH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			private CIICFINBKJN <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			private TaskAwaiter<NNOEIPEILJE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x774FA00", Offset = "0x774EE00", VA = "0x18774FA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x7750020", Offset = "0x774F420", VA = "0x187750020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public NFELGJLCDGC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public EEDPKNBGCEF masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public HHIHHHCKIEO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public NNOEIPEILJE originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JEDMFMFBKDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x7747B90", Offset = "0x7746F90", VA = "0x187747B90")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<NNOEIPEILJE> IABBLGLFJDB(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct GFFLOFELOJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public AsyncTaskMethodBuilder<NNOEIPEILJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public NFELGJLCDGC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public EEDPKNBGCEF masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public HHIHHHCKIEO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private TaskAwaiter<NNOEIPEILJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x7743A10", Offset = "0x7742E10", VA = "0x187743A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x7743F30", Offset = "0x7743330", VA = "0x187743F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct NPPDNDFKPFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public NFELGJLCDGC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private NNOEIPEILJE <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private IEnumerator<NNOEIPEILJE> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TaskAwaiter<NNOEIPEILJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x774CA50", Offset = "0x774BE50", VA = "0x18774CA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x774CFA0", Offset = "0x774C3A0", VA = "0x18774CFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct IMIJKNFEPFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x7746420", Offset = "0x7745820", VA = "0x187746420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x7746640", Offset = "0x7745A40", VA = "0x187746640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct KEACKLFHGNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7749880", Offset = "0x7748C80", VA = "0x187749880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7749A20", Offset = "0x7748E20", VA = "0x187749A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct GCCJOKHCGHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public MCGHEPNDHCL phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public NFELGJLCDGC postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private TaskAwaiter<NNOEIPEILJE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private HHIHHHCKIEO <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x7742B20", Offset = "0x7741F20", VA = "0x187742B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x77439B0", Offset = "0x7742DB0", VA = "0x1877439B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct JNLHNIBNLPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public AsyncTaskMethodBuilder<NNOEIPEILJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public BHGLKAANHID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public NFELGJLCDGC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private TaskAwaiter<NNOEIPEILJE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x7760520", Offset = "0x775F920", VA = "0x187760520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x7761220", Offset = "0x7760620", VA = "0x187761220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly PALGLKMIOIC GAEOPDOKLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly PALGLKMIOIC JBAHGHPNGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private readonly KDKGOMPODOP EJHFGMBCHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private readonly AMAMNGGHLEM JIFFCBLFGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly IIFBKBDIBFH OBMBJLMOJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private ProfilerCounterValue<int> CGFMBDLDHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private readonly PGEPEEEPGPE HHMKMMENGIM;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private FGMEGFCAHOO ECFALHAGKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x77393F0", Offset = "0x77387F0", VA = "0x1877393F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event PCHPOLLMJLF KJFPNPOBMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x7738BB0", Offset = "0x7737FB0", VA = "0x187738BB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x7738450", Offset = "0x7737850", VA = "0x187738450", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x7739420", Offset = "0x7738820", VA = "0x187739420")]
	public BHGLKAANHID(FJBKMLGOLKO NDIKCIPCMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x7738BD0", Offset = "0x7737FD0", VA = "0x187738BD0")]
	[AsyncStateMachine(typeof(AJOGOFFEKHB))]
	public Task MHAOLKCBOJJ(FPMKMFBIMPJ BLIDGDGMCAP, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x77385D0", Offset = "0x77379D0", VA = "0x1877385D0")]
	[AsyncStateMachine(typeof(CLIOGFKAOLO))]
	private Task<CCONCDOKPJO> FMLBCLCPJAA(FPMKMFBIMPJ BLIDGDGMCAP, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x7738470", Offset = "0x7737870", VA = "0x187738470")]
	[AsyncStateMachine(typeof(HFHFBNFHGAO))]
	private Task EAFFJFJMPFL(FPMKMFBIMPJ BLIDGDGMCAP, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x77388C0", Offset = "0x7737CC0", VA = "0x1877388C0")]
	[AsyncStateMachine(typeof(EPBDOMOJKJC))]
	private Task JPKGCELPOIP(FPMKMFBIMPJ BLIDGDGMCAP, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FNFBKDELBFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x7738E10", Offset = "0x7738210", VA = "0x187738E10")]
	[AsyncStateMachine(typeof(IPEKJAEEKOB))]
	private Task MIDCCDEPNCJ(MCGHEPNDHCL KMDKEMNLJEL, NFELGJLCDGC GGCPHJOKNOK, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken KLMKNMBIJHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x7739190", Offset = "0x7738590", VA = "0x187739190")]
	[AsyncStateMachine(typeof(JNCJHDOOFOM))]
	private Task OGPDLDMKCDK(LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x77392A0", Offset = "0x77386A0", VA = "0x1877392A0")]
	[AsyncStateMachine(typeof(PAKFIGFEPEA))]
	private Task OMOIGEGCHIL(MCGHEPNDHCL JGCOLLOOLHL, NFELGJLCDGC MJHFIICPKEL, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x7738100", Offset = "0x7737500", VA = "0x187738100")]
	[AsyncStateMachine(typeof(COOKMPNCPCP))]
	private Task<NNOEIPEILJE> CHJCIOBDCMO(MCGHEPNDHCL JGCOLLOOLHL, HHIHHHCKIEO EGIAAOFKAAP, NFELGJLCDGC MJHFIICPKEL, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x7737B50", Offset = "0x7736F50", VA = "0x187737B50")]
	[AsyncStateMachine(typeof(ELEIHNNMGEL))]
	private Task<NNOEIPEILJE> AEEEIKMCJDI(MCGHEPNDHCL JGCOLLOOLHL, HHIHHHCKIEO EGIAAOFKAAP, NFELGJLCDGC MJHFIICPKEL, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x7738260", Offset = "0x7737660", VA = "0x187738260")]
	[AsyncStateMachine(typeof(GADAKIAFDNP))]
	private Task<NNOEIPEILJE> CLHJIFHNNNA(NNOEIPEILJE KMBHNMBCHFF, MCGHEPNDHCL COKNKBNPIMH, NFELGJLCDGC MJHFIICPKEL, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG, bool NBMLHKPCMLD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x7738D20", Offset = "0x7738120", VA = "0x187738D20")]
	private bool MHIBPGAMADM(MCGHEPNDHCL KMDKEMNLJEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x7738A20", Offset = "0x7737E20", VA = "0x187738A20")]
	[AsyncStateMachine(typeof(GFFLOFELOJF))]
	protected Task<NNOEIPEILJE> MBMFJDJCHNO(MCGHEPNDHCL JGCOLLOOLHL, HHIHHHCKIEO EGIAAOFKAAP, NFELGJLCDGC MJHFIICPKEL, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG, EEDPKNBGCEF ANDGAMCNNJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x7737E40", Offset = "0x7737240", VA = "0x187737E40")]
	[AsyncStateMachine(typeof(NPPDNDFKPFA))]
	private Task BMBDJLPIKFF(MCGHEPNDHCL JGCOLLOOLHL, NFELGJLCDGC MJHFIICPKEL, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x7738860", Offset = "0x7737C60", VA = "0x187738860")]
	private void JDJAEANCHOK(NNOEIPEILJE ONLFLFLBONH, NFELGJLCDGC MJHFIICPKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x7738410", Offset = "0x7737810", VA = "0x187738410")]
	private void DEMNNKENHGG(NNOEIPEILJE AILLAKKFIGF, [Out] NNOEIPEILJE IKAJAEFEEJF, [Out] NNOEIPEILJE LAOCMDGMFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x7738730", Offset = "0x7737B30", VA = "0x187738730")]
	private Task<NDOBDCNBMAD> GMFCMIFJDII(FPMKMFBIMPJ BLIDGDGMCAP, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x7738F60", Offset = "0x7738360", VA = "0x187738F60")]
	private Task<MCGHEPNDHCL> MKHDFELDCAG(NDOBDCNBMAD JGCOLLOOLHL, KEGPANADHNE.AGLEJHOOMJP NIJPDKBAALP, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x7737CF0", Offset = "0x77370F0", VA = "0x187737CF0")]
	[AsyncStateMachine(typeof(IMIJKNFEPFC))]
	private Task BIKEKADALMF(MCGHEPNDHCL JGCOLLOOLHL, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG, bool HCPLKADDGOM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x7738770", Offset = "0x7737B70", VA = "0x187738770")]
	[AsyncStateMachine(typeof(KEACKLFHGNA))]
	private Task GPNDIEPLHGF(MCGHEPNDHCL JGCOLLOOLHL, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x77383E0", Offset = "0x77377E0", VA = "0x1877383E0")]
	private Task DEBNMINEFLH(MCGHEPNDHCL JGCOLLOOLHL, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x7737F90", Offset = "0x7737390", VA = "0x187737F90")]
	private Task BNFFPAECCJJ(MCGHEPNDHCL JGCOLLOOLHL, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x7739100", Offset = "0x7738500", VA = "0x187739100")]
	private Task NJPOLNENPFK(MCGHEPNDHCL JGCOLLOOLHL, HHIHHHCKIEO EGIAAOFKAAP, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x77385B0", Offset = "0x77379B0", VA = "0x1877385B0")]
	private Task EMPACGBMLLF(MCGHEPNDHCL JGCOLLOOLHL, HHIHHHCKIEO EGIAAOFKAAP, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x77388B0", Offset = "0x7737CB0", VA = "0x1877388B0")]
	private static Task JDKJEJCGAKM(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x7737CD0", Offset = "0x77370D0", VA = "0x187737CD0")]
	private Task ANGIBKEHPCB(MCGHEPNDHCL JGCOLLOOLHL, HHIHHHCKIEO EGIAAOFKAAP, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x7738A00", Offset = "0x7737E00", VA = "0x187738A00")]
	private Task KCJKBPCCKCA(MCGHEPNDHCL JGCOLLOOLHL, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x7739120", Offset = "0x7738520", VA = "0x187739120")]
	private void NKKDCJJMGME(FPMKMFBIMPJ BLIDGDGMCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x7739170", Offset = "0x7738570", VA = "0x187739170")]
	public void OFHMILMMKAA(long OPIAKLFIGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
	private static void JHFBDEGLHFB(NLMAEEICDJF CIOKBAAIBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x7737FB0", Offset = "0x77373B0", VA = "0x187737FB0")]
	[AsyncStateMachine(typeof(GCCJOKHCGHL))]
	private Task CDCNHAIJLGD(MCGHEPNDHCL KMDKEMNLJEL, NFELGJLCDGC GGCPHJOKNOK, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken KLMKNMBIJHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x7738FA0", Offset = "0x77383A0", VA = "0x187738FA0")]
	[AsyncStateMachine(typeof(JNLHNIBNLPM))]
	[CompilerGenerated]
	private Task<NNOEIPEILJE> NHBNPNFLMKC(MCGHEPNDHCL JGCOLLOOLHL, HHIHHHCKIEO EGIAAOFKAAP, NFELGJLCDGC MJHFIICPKEL, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct BEBEPOMCJMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private FGMEGFCAHOO EKABOCOCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private MCGHEPNDHCL JGCOLLOOLHL;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private HJHDHMCCGBJ EEGJAFGKABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x77549D0", Offset = "0x7753DD0", VA = "0x1877549D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x7754A20", Offset = "0x7753E20", VA = "0x187754A20")]
	public static Task PKMNDLFOFHF(FGMEGFCAHOO EKABOCOCDBK, MCGHEPNDHCL JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x7754B00", Offset = "0x7753F00", VA = "0x187754B00")]
	private void PKMNDLFOFHF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct PFPIAGJBGDH
{
	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x7767DB0", Offset = "0x77671B0", VA = "0x187767DB0")]
	public static Task PKMNDLFOFHF(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct OCOLOFBJGHP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct AECPLMENOMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public FJBKMLGOLKO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x77515D0", Offset = "0x77509D0", VA = "0x1877515D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x7751B00", Offset = "0x7750F00", VA = "0x187751B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x77664D0", Offset = "0x77658D0", VA = "0x1877664D0")]
	[AsyncStateMachine(typeof(AECPLMENOMI))]
	public static Task PKMNDLFOFHF(FJBKMLGOLKO NDIKCIPCMBB, MCGHEPNDHCL JGCOLLOOLHL, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct LLPKPJAHAAC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct DJJDNGBNHEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public FJBKMLGOLKO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public HHIHHHCKIEO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private NNOEIPEILJE <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private FGMEGFCAHOO <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private HJHDHMCCGBJ <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private CIICFINBKJN <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private List<(PersistenceView, CGBJPDKLJAK)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private CGBJPDKLJAK <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x7756A00", Offset = "0x7755E00", VA = "0x187756A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x7757690", Offset = "0x7756A90", VA = "0x187757690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x77634E0", Offset = "0x77628E0", VA = "0x1877634E0")]
	[AsyncStateMachine(typeof(DJJDNGBNHEM))]
	public static Task PKMNDLFOFHF(FJBKMLGOLKO NDIKCIPCMBB, MCGHEPNDHCL JGCOLLOOLHL, HHIHHHCKIEO EGIAAOFKAAP, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x77632F0", Offset = "0x77626F0", VA = "0x1877632F0")]
	private static void NFCLJDAKNHB(PersistenceView CICGDGCLMFK, CGBJPDKLJAK MMJPLOBEPHL, MCGHEPNDHCL JGCOLLOOLHL, NNOEIPEILJE KMBHNMBCHFF, bool HDAFCAFFADH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct DKLBIJCOFLP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct LIDAAFBFADC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public FGMEGFCAHOO roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private CIICFINBKJN <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x7762C70", Offset = "0x7762070", VA = "0x187762C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x7763290", Offset = "0x7762690", VA = "0x187763290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x77576F0", Offset = "0x7756AF0", VA = "0x1877576F0")]
	[AsyncStateMachine(typeof(LIDAAFBFADC))]
	public static Task PKMNDLFOFHF(FGMEGFCAHOO EKABOCOCDBK, MCGHEPNDHCL JGCOLLOOLHL, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct AAKFLIFNMDJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct MMCPMNFJHAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public FGMEGFCAHOO roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public FJBKMLGOLKO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x7764530", Offset = "0x7763930", VA = "0x187764530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x7764740", Offset = "0x7763B40", VA = "0x187764740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class BFANEEADPBJ
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
			public LOALKKNJJLG<string>.HAPJMIAELKE timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			public BFANEEADPBJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x7769B20", Offset = "0x7768F20", VA = "0x187769B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x7769EB0", Offset = "0x77692B0", VA = "0x187769EB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public BFANEEADPBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x7754D10", Offset = "0x7754110", VA = "0x187754D10")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task KPIOINFCAGN(LOALKKNJJLG<string>.HAPJMIAELKE timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct EBGJKKBICDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public AAKFLIFNMDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private CIICFINBKJN <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private TaskAwaiter<CCONCDOKPJO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x7757810", Offset = "0x7756C10", VA = "0x187757810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x7758400", Offset = "0x7757800", VA = "0x187758400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class CGHGANLDBOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public KFBEOIPGGLH version;

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
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public CGHGANLDBOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x7756740", Offset = "0x7755B40", VA = "0x187756740")]
		internal object NBHHDLLCEMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x7756820", Offset = "0x7755C20", VA = "0x187756820")]
		internal object POHEHNDACMN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private FGMEGFCAHOO EKABOCOCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private MCGHEPNDHCL JGCOLLOOLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private FJBKMLGOLKO NDIKCIPCMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private bool HCPLKADDGOM;

	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private static readonly ByteString JBKJMAAFGOI;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private HJHDHMCCGBJ EEGJAFGKABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x7750900", Offset = "0x774FD00", VA = "0x187750900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private HJHCBNKLCIG GAFOLMMMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x77510F0", Offset = "0x77504F0", VA = "0x1877510F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x7751300", Offset = "0x7750700", VA = "0x187751300")]
	[AsyncStateMachine(typeof(MMCPMNFJHAM))]
	public static Task PKMNDLFOFHF(FGMEGFCAHOO EKABOCOCDBK, MCGHEPNDHCL JGCOLLOOLHL, FJBKMLGOLKO NDIKCIPCMBB, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG, bool HCPLKADDGOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x77511D0", Offset = "0x77505D0", VA = "0x1877511D0")]
	[AsyncStateMachine(typeof(EBGJKKBICDA))]
	private Task PKMNDLFOFHF(LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x7750950", Offset = "0x774FD50", VA = "0x187750950")]
	private void LFLALCHILIK([NotNull] HGOBDFLLNNB NLABEPFOMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x7751190", Offset = "0x7750590", VA = "0x187751190")]
	private bool PHIFBFFNNMO(KFBEOIPGGLH GKEHKEEIHAE, HGOBDFLLNNB NLABEPFOMIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct NINLDHCNPHN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct GAEKBBJOLIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public AsyncTaskMethodBuilder<MCGHEPNDHCL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public NINLDHCNPHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public KEGPANADHNE.AGLEJHOOMJP downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private TaskAwaiter<(ABNAGONECLM<BEBJMKGGJCL, PJPEMJHFJLC>, ABNAGONECLM<DPJCBEABHHK<HGOBDFLLNNB>, PJPEMJHFJLC>, ABNAGONECLM<DPJCBEABHHK<KOLIENJCING>, PJPEMJHFJLC>, ABNAGONECLM<DPJCBEABHHK<GLNMJLGMCJB>, PJPEMJHFJLC>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x775B330", Offset = "0x775A730", VA = "0x18775B330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x775BDE0", Offset = "0x775B1E0", VA = "0x18775BDE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct APECOFKCNHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<BEBJMKGGJCL, PJPEMJHFJLC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public LOALKKNJJLG<string>.HAPJMIAELKE downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public NINLDHCNPHN <>4__this;

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
		public KEGPANADHNE.AGLEJHOOMJP downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter<ABNAGONECLM<BEBJMKGGJCL, PJPEMJHFJLC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x7753D60", Offset = "0x7753160", VA = "0x187753D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7754370", Offset = "0x7753770", VA = "0x187754370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private OOCFCNOADMF<OAOEDECEGIP, KOLIENJCING> NKPEDCFJLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private OOCFCNOADMF<OAOEDECEGIP, HGOBDFLLNNB> ILHENILCBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private OOCFCNOADMF<long, GLNMJLGMCJB> BPCKLGEHLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private DDNNAIEPHOL NFEFMAOABGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private NLMAEEICDJF CIOKBAAIBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private BEANCEBHDPC ELONMONDCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private string EHJCFMNPKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private OAOEDECEGIP EJFFMDCEBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	private OAOEDECEGIP MHINPKLKBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private long OPIAKLFIGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	private LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM;

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x7765E20", Offset = "0x7765220", VA = "0x187765E20")]
	public static Task<MCGHEPNDHCL> CEJOOFAFEBH(FGMEGFCAHOO EKABOCOCDBK, [In] NDOBDCNBMAD JGCOLLOOLHL, KEGPANADHNE.AGLEJHOOMJP NIJPDKBAALP, LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x7766340", Offset = "0x7765740", VA = "0x187766340")]
	[AsyncStateMachine(typeof(GAEKBBJOLIM))]
	private Task<MCGHEPNDHCL> PKMNDLFOFHF(KEGPANADHNE.AGLEJHOOMJP NIJPDKBAALP, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x7766180", Offset = "0x7765580", VA = "0x187766180")]
	[AsyncStateMachine(typeof(APECOFKCNHH))]
	private Task<ABNAGONECLM<BEBJMKGGJCL, PJPEMJHFJLC>> COHFBKIMKIJ(string EHJCFMNPKKH, long OPIAKLFIGIP, long? GGLEGKBAGLC, long? LPKNEPKMMOO, KEGPANADHNE.AGLEJHOOMJP NIJPDKBAALP, LOALKKNJJLG<string>.HAPJMIAELKE DKGCKFACFPP, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct PMFNCFFEJBM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct EDCLCKDLPIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public AsyncTaskMethodBuilder<NDOBDCNBMAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public PMFNCFFEJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private TaskAwaiter<NDOBDCNBMAD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x7758460", Offset = "0x7757860", VA = "0x187758460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x7758870", Offset = "0x7757C70", VA = "0x187758870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct JGAHCDCJMEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public AsyncTaskMethodBuilder<NDOBDCNBMAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public PMFNCFFEJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private TaskAwaiter<NDOBDCNBMAD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x775FA50", Offset = "0x775EE50", VA = "0x18775FA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x775FE80", Offset = "0x775F280", VA = "0x18775FE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class FDEHAEHAGLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public FDEHAEHAGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xA99C70", Offset = "0xA99070", VA = "0x180A99C70")]
		internal bool PNLNHELDHOP(BEANCEBHDPC sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct FKFDDOPBNIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public AsyncTaskMethodBuilder<NDOBDCNBMAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public OAOEDECEGIP superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public HJHDHMCCGBJ callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private FDEHAEHAGLG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public PPGBCHJLLOD roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private NLMAEEICDJF <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private BEANCEBHDPC <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private OAOEDECEGIP <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private OAOEDECEGIP <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter<NLMAEEICDJF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter<CDLAJKKPEIP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private TaskAwaiter<GNODDIAAKFD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x77596D0", Offset = "0x7758AD0", VA = "0x1877596D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x775A810", Offset = "0x7759C10", VA = "0x18775A810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private HJHDHMCCGBJ IHMGMGMEKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private KDKGOMPODOP EJHFGMBCHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private PPGBCHJLLOD CLFPKOLNGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private long GGLEGKBAGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private long DLGNECIGKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private long ENIGCGECECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private string MEHAKHCKJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private OAOEDECEGIP NGANEKEKHHB;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x7768590", Offset = "0x7767990", VA = "0x187768590")]
	public static Task<NDOBDCNBMAD> CEJOOFAFEBH(FGMEGFCAHOO EKABOCOCDBK, FPMKMFBIMPJ BLIDGDGMCAP, LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x7768AF0", Offset = "0x7767EF0", VA = "0x187768AF0")]
	[AsyncStateMachine(typeof(EDCLCKDLPIG))]
	private Task<NDOBDCNBMAD> PKMNDLFOFHF(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x77687C0", Offset = "0x7767BC0", VA = "0x1877687C0")]
	[AsyncStateMachine(typeof(JGAHCDCJMEI))]
	private Task<NDOBDCNBMAD> GMFCMIFJDII(LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x7768920", Offset = "0x7767D20", VA = "0x187768920")]
	[AsyncStateMachine(typeof(FKFDDOPBNIA))]
	private static Task<NDOBDCNBMAD> GMFCMIFJDII(HJHDHMCCGBJ IHMGMGMEKPB, PPGBCHJLLOD CLFPKOLNGKK, long GGLEGKBAGLC, long DLGNECIGKLC, long ENIGCGECECI, string MEHAKHCKJPP, OAOEDECEGIP NGANEKEKHHB, CancellationToken FHGIOBPPFHG, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x7768AC0", Offset = "0x7767EC0", VA = "0x187768AC0")]
	private void IFBCFGJAMOH(NLMAEEICDJF CIOKBAAIBPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
internal struct JHMAILBACKE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct BCAGEBOPIDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public JHMAILBACKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x77543E0", Offset = "0x77537E0", VA = "0x1877543E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x7754970", Offset = "0x7753D70", VA = "0x187754970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private HJHDHMCCGBJ IHMGMGMEKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private MCGHEPNDHCL JGCOLLOOLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private float BOPCHINFPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private float FCNNFIMPNCC;

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x7760260", Offset = "0x775F660", VA = "0x187760260")]
	public static Task NBEBENNDLIL(FGMEGFCAHOO EKABOCOCDBK, MCGHEPNDHCL JGCOLLOOLHL, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x7760400", Offset = "0x775F800", VA = "0x187760400")]
	[AsyncStateMachine(typeof(BCAGEBOPIDG))]
	public Task PKMNDLFOFHF(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x775FEF0", Offset = "0x775F2F0", VA = "0x18775FEF0")]
	private static void DBGLBFEAENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x7760100", Offset = "0x775F500", VA = "0x187760100")]
	private void KALCKNGAIJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x7760020", Offset = "0x775F420", VA = "0x187760020")]
	private static float HDDEDCOJONH(HJHDHMCCGBJ IHMGMGMEKPB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x77600E0", Offset = "0x775F4E0", VA = "0x1877600E0")]
	private static float JBMNNNJHJLN()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct MDCEDHPHBPF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct JBEMBBOFLBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public FJBKMLGOLKO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private KJPDDBJMGCN <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private FGMEGFCAHOO <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private MPAAIIFEHIE.FCHMPIMMENP <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private TaskAwaiter<CCONCDOKPJO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x775F1D0", Offset = "0x775E5D0", VA = "0x18775F1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x775F9F0", Offset = "0x775EDF0", VA = "0x18775F9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct FJOFEIEFMMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x7759340", Offset = "0x7758740", VA = "0x187759340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x7759670", Offset = "0x7758A70", VA = "0x187759670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x77643F0", Offset = "0x77637F0", VA = "0x1877643F0")]
	[AsyncStateMachine(typeof(JBEMBBOFLBG))]
	public static Task PKMNDLFOFHF(FJBKMLGOLKO NDIKCIPCMBB, MCGHEPNDHCL JGCOLLOOLHL, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x7764380", Offset = "0x7763780", VA = "0x187764380")]
	private static Task<CCONCDOKPJO> FJNGFADENAO(FJBKMLGOLKO NDIKCIPCMBB, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x77642C0", Offset = "0x77636C0", VA = "0x1877642C0")]
	[AsyncStateMachine(typeof(FJOFEIEFMMG))]
	private static Task BNGBIDNCNHK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct MOEIJDBHNLB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct KBOBHLGNMOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public MOEIJDBHNLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x77613D0", Offset = "0x77607D0", VA = "0x1877613D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x7761A80", Offset = "0x7760E80", VA = "0x187761A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class GEHCKEGCNIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public GEHCKEGCNIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x775BE50", Offset = "0x775B250", VA = "0x18775BE50")]
		internal object KKHDLCGMPAN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct KNBCDGBEEOG : IAsyncStateMachine
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
		public MOEIJDBHNLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x7761EC0", Offset = "0x77612C0", VA = "0x187761EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x7762340", Offset = "0x7761740", VA = "0x187762340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B0")]
	private bool BOINAEIOOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B2")]
	private FGMEGFCAHOO EKABOCOCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005B3")]
	private CancellationToken FHGIOBPPFHG;

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x77648D0", Offset = "0x7763CD0", VA = "0x1877648D0")]
	public static Task JDGDCPHLPCD(FGMEGFCAHOO EKABOCOCDBK, bool BOINAEIOOID, LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, CancellationToken KAOFONNHCIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x7764940", Offset = "0x7763D40", VA = "0x187764940")]
	[AsyncStateMachine(typeof(KBOBHLGNMOF))]
	private Task PKMNDLFOFHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x77647A0", Offset = "0x7763BA0", VA = "0x1877647A0")]
	[AsyncStateMachine(typeof(KNBCDGBEEOG))]
	private Task BFIMOGBGGPO(bool OIBFECHFNCC, string KAJDLHPACAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0")]
	private bool JIMMBJKFABL(bool BOINAEIOOID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct OMONONEDHFL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct HONIFGICEEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public OMONONEDHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x775D290", Offset = "0x775C690", VA = "0x18775D290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x775D800", Offset = "0x775CC00", VA = "0x18775D800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class GFLMKBBNBLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public GFLMKBBNBLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x775C460", Offset = "0x775B860", VA = "0x18775C460")]
		internal object KKHDLCGMPAN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct PFHHALLHKOL : IAsyncStateMachine
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
		public OMONONEDHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x77678C0", Offset = "0x7766CC0", VA = "0x1877678C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x7767D40", Offset = "0x7767140", VA = "0x187767D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private AIFPAFFMODB KLNEIELAHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private FGMEGFCAHOO EKABOCOCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private bool FMIOKPMFBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private MCGHEPNDHCL JGCOLLOOLHL;

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x77672E0", Offset = "0x77666E0", VA = "0x1877672E0")]
	public static Task<Scene> CNLDCBMBICH(FGMEGFCAHOO EKABOCOCDBK, AIFPAFFMODB MEAFLNLPPJA, LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x7767360", Offset = "0x7766760", VA = "0x187767360")]
	[AsyncStateMachine(typeof(HONIFGICEEM))]
	private Task<Scene> PKMNDLFOFHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x7767160", Offset = "0x7766560", VA = "0x187767160")]
	private bool ALHPFCMHBHA(MCGHEPNDHCL JGCOLLOOLHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x77670F0", Offset = "0x77664F0", VA = "0x1877670F0")]
	private void ALGEPKJJOIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x7767190", Offset = "0x7766590", VA = "0x187767190")]
	[AsyncStateMachine(typeof(PFHHALLHKOL))]
	private Task<Scene> BFIMOGBGGPO(string KAJDLHPACAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct IIFBKBDIBFH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct AGMIILJIEJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public AsyncTaskMethodBuilder<NNOEIPEILJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public IIFBKBDIBFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public NNOEIPEILJE nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public MCGHEPNDHCL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter<NNOEIPEILJE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7751BB0", Offset = "0x7750FB0", VA = "0x187751BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x7752680", Offset = "0x7751A80", VA = "0x187752680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct KEELDHHOAEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public AsyncTaskMethodBuilder<NNOEIPEILJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public IIFBKBDIBFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public NNOEIPEILJE state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private TaskAwaiter<CCONCDOKPJO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x7761AE0", Offset = "0x7760EE0", VA = "0x187761AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7761DC0", Offset = "0x77611C0", VA = "0x187761DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	private readonly FJBKMLGOLKO NDIKCIPCMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	private readonly KDKGOMPODOP EJHFGMBCHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	private readonly AMAMNGGHLEM JIFFCBLFGOL;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private KJPDDBJMGCN DPEHFFFLHIO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB8B0", Offset = "0x5DEACB0", VA = "0x185DEB8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x775F170", Offset = "0x775E570", VA = "0x18775F170")]
	public IIFBKBDIBFH(FJBKMLGOLKO NDIKCIPCMBB, KDKGOMPODOP EJHFGMBCHCF, AMAMNGGHLEM JIFFCBLFGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x775EFA0", Offset = "0x775E3A0", VA = "0x18775EFA0")]
	[AsyncStateMachine(typeof(AGMIILJIEJL))]
	public Task<NNOEIPEILJE> HCFBLMPJGGM(NNOEIPEILJE KABCGGCBDEJ, MCGHEPNDHCL COKNKBNPIMH, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG, bool NBMLHKPCMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x775EE40", Offset = "0x775E240", VA = "0x18775EE40")]
	[AsyncStateMachine(typeof(KEELDHHOAEG))]
	private Task<NNOEIPEILJE> FIDBMJDLJKH(LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, NNOEIPEILJE MPLALBADMNL, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x775F140", Offset = "0x775E540", VA = "0x18775F140")]
	private bool MGKGHEOBLHM(NNOEIPEILJE JIKEFLDGENO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x775F120", Offset = "0x775E520", VA = "0x18775F120")]
	private void LDCMEBNGNBB(string GOICOPEBMAL)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct JPPGDEEOHDP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct HGMCJKKPNFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public KJPDDBJMGCN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public HHIHHHCKIEO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private CIICFINBKJN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private List<(PersistenceView, CGBJPDKLJAK)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private (PersistenceView, CGBJPDKLJAK) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x775C530", Offset = "0x775B930", VA = "0x18775C530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x775CB80", Offset = "0x775BF80", VA = "0x18775CB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x7761290", Offset = "0x7760690", VA = "0x187761290")]
	[AsyncStateMachine(typeof(HGMCJKKPNFE))]
	public static Task PKMNDLFOFHF(KJPDDBJMGCN CGENICICIAO, MCGHEPNDHCL JGCOLLOOLHL, HHIHHHCKIEO EGIAAOFKAAP, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct FPPCBAJCMEK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct BHOKLADANHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public KJPDDBJMGCN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public HHIHHHCKIEO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private KFBEOIPGGLH <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private CIICFINBKJN <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private List<(PersistenceView, CGBJPDKLJAK)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private CGBJPDKLJAK <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x7754E30", Offset = "0x7754230", VA = "0x187754E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x77556E0", Offset = "0x7754AE0", VA = "0x1877556E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x775B1F0", Offset = "0x775A5F0", VA = "0x18775B1F0")]
	[AsyncStateMachine(typeof(BHOKLADANHH))]
	public static Task PKMNDLFOFHF(KJPDDBJMGCN CGENICICIAO, MCGHEPNDHCL JGCOLLOOLHL, HHIHHHCKIEO EGIAAOFKAAP, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct MPAAIIFEHIE
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	public struct FCHMPIMMENP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public List<DMKLLCNLMLC> JKDLONGJLHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public List<CGBJPDKLJAK> NHGCDEDEGJM;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xE8EEE0", Offset = "0xE8E2E0", VA = "0x180E8EEE0")]
		public FCHMPIMMENP(List<DMKLLCNLMLC> JKDLONGJLHM, List<CGBJPDKLJAK> NHGCDEDEGJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class GLAKHGOOHAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public IEnumerable<DMKLLCNLMLC> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public GLAKHGOOHAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x775C4B0", Offset = "0x775B8B0", VA = "0x18775C4B0")]
		internal object HGHDIAPIJFC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	private FGMEGFCAHOO EKABOCOCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private MCGHEPNDHCL JGCOLLOOLHL;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private HJHDHMCCGBJ EEGJAFGKABI
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x7764A30", Offset = "0x7763E30", VA = "0x187764A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x77651F0", Offset = "0x77645F0", VA = "0x1877651F0")]
	public static FCHMPIMMENP PKMNDLFOFHF(FGMEGFCAHOO EKABOCOCDBK, MCGHEPNDHCL JGCOLLOOLHL)
	{
		return default(FCHMPIMMENP);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x7765250", Offset = "0x7764650", VA = "0x187765250")]
	private FCHMPIMMENP PKMNDLFOFHF()
	{
		return default(FCHMPIMMENP);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x7764C50", Offset = "0x7764050", VA = "0x187764C50")]
	private FCHMPIMMENP FPBHIMMPMHA(HGOBDFLLNNB NLABEPFOMIJ, KFBEOIPGGLH ABJKAJCHFGG)
	{
		return default(FCHMPIMMENP);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x7764A80", Offset = "0x7763E80", VA = "0x187764A80")]
	private bool DLADHHBCCBI(IEnumerable<DMKLLCNLMLC> JKDLONGJLHM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct OFMEEAKIHDM
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class FPAMPOGPHAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public MPAAIIFEHIE.FCHMPIMMENP instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public FPAMPOGPHAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x775B140", Offset = "0x775A540", VA = "0x18775B140")]
		internal object KPIOINFCAGN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class KKGJIBENHKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public KKGJIBENHKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x7761E30", Offset = "0x7761230", VA = "0x187761E30")]
		internal object PBCIHDMECKI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x7766610", Offset = "0x7765A10", VA = "0x187766610")]
	public static void PKMNDLFOFHF(KJPDDBJMGCN CGENICICIAO, MCGHEPNDHCL JGCOLLOOLHL, MPAAIIFEHIE.FCHMPIMMENP KAFNOJBGCIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal class AMAMNGGHLEM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct CEACELKBHHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public AMAMNGGHLEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public NNOEIPEILJE operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public MCGHEPNDHCL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public LOALKKNJJLG<string>.HAPJMIAELKE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x7755F70", Offset = "0x7755370", VA = "0x187755F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x77566E0", Offset = "0x7755AE0", VA = "0x1877566E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class ADAICKMHKCO
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
			public ADAICKMHKCO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400061D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x7769800", Offset = "0x7768C00", VA = "0x187769800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x7769AC0", Offset = "0x7768EC0", VA = "0x187769AC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public AMAMNGGHLEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public LOALKKNJJLG<string>.HAPJMIAELKE handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public ADAICKMHKCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x77514E0", Offset = "0x77508E0", VA = "0x1877514E0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task JCEALIBEHFH(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct LOEBPABCFAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public AMAMNGGHLEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public LOALKKNJJLG<string>.HAPJMIAELKE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private ADAICKMHKCO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x7763630", Offset = "0x7762A30", VA = "0x187763630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x7763B60", Offset = "0x7762F60", VA = "0x187763B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct HNBECBNALPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public AMAMNGGHLEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public LOALKKNJJLG<string>.HAPJMIAELKE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		private Dictionary<Guid, List<BHDNCPJPFMP>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x775CC20", Offset = "0x775C020", VA = "0x18775CC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x775D230", Offset = "0x775C630", VA = "0x18775D230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct PNMFDMFFGEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public AMAMNGGHLEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public LOALKKNJJLG<string>.HAPJMIAELKE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private Dictionary<Guid, List<BHDNCPJPFMP>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x7768C40", Offset = "0x7768040", VA = "0x187768C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x77692E0", Offset = "0x77686E0", VA = "0x1877692E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class PBEIPJFABGN
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
			public BHDNCPJPFMP handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000640")]
			public PBEIPJFABGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			private CIICFINBKJN <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000642")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005DF")]
			[Cpp2IlInjected.Address(RVA = "0x7769340", Offset = "0x7768740", VA = "0x187769340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x77697A0", Offset = "0x7768BA0", VA = "0x1877697A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public OOGMJHAJHKO runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public List<BHDNCPJPFMP> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public PBEIPJFABGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x77676E0", Offset = "0x7766AE0", VA = "0x1877676E0")]
		internal object DLBPPJNHLAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x77675E0", Offset = "0x77669E0", VA = "0x1877675E0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task ABNJDFBEMGM(BHDNCPJPFMP handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x77677D0", Offset = "0x7766BD0", VA = "0x1877677D0")]
		internal object GLNHHLNBKCO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct OHFCMHKJNHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public OOGMJHAJHKO runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public List<BHDNCPJPFMP> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private PBEIPJFABGN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x7766BC0", Offset = "0x7765FC0", VA = "0x187766BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x7767090", Offset = "0x7766490", VA = "0x187767090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct NGPDJLJOFLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public AMAMNGGHLEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public LOALKKNJJLG<string>.HAPJMIAELKE timer;

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
		[Cpp2IlInjected.Address(RVA = "0x7765790", Offset = "0x7764B90", VA = "0x187765790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x7765D50", Offset = "0x7765150", VA = "0x187765D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class NIMBLOFOFEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public NIMBLOFOFEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x7765DB0", Offset = "0x77651B0", VA = "0x187765DB0")]
		internal object PPNDBLNNOKM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct GEPJNKDNDBJ : IAsyncStateMachine
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
		public AMAMNGGHLEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public MCGHEPNDHCL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x775BF40", Offset = "0x775B340", VA = "0x18775BF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x775C400", Offset = "0x775B800", VA = "0x18775C400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class AMKMNIDJAAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public AMKMNIDJAAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x7753600", Offset = "0x7752A00", VA = "0x187753600")]
		internal object MEABFDPPFLB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct PLEEBBENAHF : IAsyncStateMachine
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
		public AMAMNGGHLEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter<CCONCDOKPJO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x7767F00", Offset = "0x7767300", VA = "0x187767F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x7768530", Offset = "0x7767930", VA = "0x187768530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class GEHLLPOOAPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public GEHLLPOOAPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x775BED0", Offset = "0x775B2D0", VA = "0x18775BED0")]
		internal object HHGGEPPNBEB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private readonly FJBKMLGOLKO NDIKCIPCMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private EKLEDIHDDBM JIFFCBLFGOL;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private KJPDDBJMGCN DPEHFFFLHIO
	{
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xCA5030", Offset = "0xCA4430", VA = "0x180CA5030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	public AMAMNGGHLEM(FJBKMLGOLKO NDIKCIPCMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x77534B0", Offset = "0x77528B0", VA = "0x1877534B0")]
	[AsyncStateMachine(typeof(CEACELKBHHG))]
	public Task PKMNDLFOFHF(NNOEIPEILJE KMBHNMBCHFF, MCGHEPNDHCL COKNKBNPIMH, LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x77526F0", Offset = "0x7751AF0", VA = "0x1877526F0")]
	[AsyncStateMachine(typeof(LOEBPABCFAB))]
	private Task AJLGBOLKAGP(MCGHEPNDHCL JGCOLLOOLHL, LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x7752C70", Offset = "0x7752070", VA = "0x187752C70")]
	[AsyncStateMachine(typeof(HNBECBNALPC))]
	private Task JCIEKJCAIOE(MCGHEPNDHCL JGCOLLOOLHL, LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x77530E0", Offset = "0x77524E0", VA = "0x1877530E0")]
	[AsyncStateMachine(typeof(PNMFDMFFGEA))]
	private Task LGIHOCKPDAC(MCGHEPNDHCL JGCOLLOOLHL, LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x7753360", Offset = "0x7752760", VA = "0x187753360")]
	[AsyncStateMachine(typeof(OHFCMHKJNHL))]
	private Task OLLGAPKNAEM(Guid LGMOJECPMCA, List<BHDNCPJPFMP> MHDHPLGPOJB, OOGMJHAJHKO BKDKJDJFGDG, MCGHEPNDHCL JGCOLLOOLHL, CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x7753220", Offset = "0x7752620", VA = "0x187753220")]
	[AsyncStateMachine(typeof(NGPDJLJOFLP))]
	private Task OGHNGMLPEBN(MCGHEPNDHCL JGCOLLOOLHL, LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x7752830", Offset = "0x7751C30", VA = "0x187752830")]
	[AsyncStateMachine(typeof(GEPJNKDNDBJ))]
	private Task BCOONANPFDJ(Guid CNFFHLOJDAN, MCGHEPNDHCL JGCOLLOOLHL, LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x7752B30", Offset = "0x7751F30", VA = "0x187752B30")]
	[AsyncStateMachine(typeof(PLEEBBENAHF))]
	private Task IIPNLOMPMHA(Guid CNFFHLOJDAN, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x7752970", Offset = "0x7751D70", VA = "0x187752970")]
	private void DCIKLEEAFEA(Guid CNFFHLOJDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x7752A80", Offset = "0x7751E80", VA = "0x187752A80")]
	private void FDGFCLCLMOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x7752F80", Offset = "0x7752380", VA = "0x187752F80")]
	public Guid KFFDJGGMKOP(NNOEIPEILJE ONLFLFLBONH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x7752DB0", Offset = "0x77521B0", VA = "0x187752DB0")]
	[CompilerGenerated]
	private object KDCFCFHDAGH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal struct PACBHCKMPCN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct AOHPPPGEJIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public PACBHCKMPCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private IEnumerator<HPMJLMPHAND> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x7753670", Offset = "0x7752A70", VA = "0x187753670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x7753D00", Offset = "0x7753100", VA = "0x187753D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private HJHDHMCCGBJ IHMGMGMEKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private CancellationToken FHGIOBPPFHG;

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x7767480", Offset = "0x7766880", VA = "0x187767480")]
	public static Task KHDDLLKPKMC(HJHDHMCCGBJ IHMGMGMEKPB, LOALKKNJJLG<string>.HAPJMIAELKE HIKLLEDALJM, CancellationToken KAOFONNHCIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x77674F0", Offset = "0x77668F0", VA = "0x1877674F0")]
	[AsyncStateMachine(typeof(AOHPPPGEJIC))]
	private Task PKMNDLFOFHF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public readonly struct HKHNPHNDIJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	public readonly bool OBCHOAAALHP;

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x2508F90", Offset = "0x2508390", VA = "0x182508F90")]
	public HKHNPHNDIJN(bool GPDFBLJCCPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
public readonly struct BIPJJKGGCNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	public readonly HGOBDFLLNNB? PDKODKAAMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	public readonly EJCDMFDDOCE OCELPNAMJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	public readonly string? KHIOJHOKJLE;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public IReadOnlyCollection<string> LLIEHEAHOEG
	{
		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x7755740", Offset = "0x7754B40", VA = "0x187755740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyDictionary<long, int> LIOFPLDFFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x7755760", Offset = "0x7754B60", VA = "0x187755760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x7755780", Offset = "0x7754B80", VA = "0x187755780")]
	public BIPJJKGGCNE(HGOBDFLLNNB? JOMOCOIMIGC, EJCDMFDDOCE JEEOAANMJOL, string? EHJCFMNPKKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class IFNCKGOBGJO : FFHKMDJJEOM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct CDBACPILCKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public AsyncTaskMethodBuilder<BIPJJKGGCNE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public IFNCKGOBGJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public COFODAIELBI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public CDGJEEKFCOI roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private CIICFINBKJN <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x7755880", Offset = "0x7754C80", VA = "0x187755880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x7755F00", Offset = "0x7755300", VA = "0x187755F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class NEDKFJAPNGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public COFODAIELBI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public IFNCKGOBGJO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public NEDKFJAPNGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x77654A0", Offset = "0x77648A0", VA = "0x1877654A0")]
		internal Task AMDAHNOGDLC(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x77656B0", Offset = "0x7764AB0", VA = "0x1877656B0")]
		internal Task FHBBHEKJGIF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class PINJMMDNLNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public NEDKFJAPNGD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public PINJMMDNLNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x7767E90", Offset = "0x7767290", VA = "0x187767E90")]
		internal object FIAMFHPBPAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class HIIAGEAFAGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public NEDKFJAPNGD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public HIIAGEAFAGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x775CBE0", Offset = "0x775BFE0", VA = "0x18775CBE0")]
		internal Task KKPBLEKPGHG(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct FNDCFJIMJPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public COFODAIELBI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public IFNCKGOBGJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private PINJMMDNLNI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private CIICFINBKJN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x775A880", Offset = "0x7759C80", VA = "0x18775A880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x775B0E0", Offset = "0x775A4E0", VA = "0x18775B0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	private readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.Token(Token = "0x4000679")]
	private static readonly TimeSpan ONOONHHKPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	private readonly LCOONJCLGCG JDDANOOEMNO;

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x775E970", Offset = "0x775DD70", VA = "0x18775E970")]
	public IFNCKGOBGJO(FJBKMLGOLKO NDIKCIPCMBB, LCOONJCLGCG JDDANOOEMNO, GKOKEEMOOFG GGCNADGKGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x775D870", Offset = "0x775CC70", VA = "0x18775D870")]
	[AsyncStateMachine(typeof(CDBACPILCKO))]
	public Task<BIPJJKGGCNE> GKPJGNLGAKF(long DLGNECIGKLC, CDGJEEKFCOI KAKFCKOFOOK, COFODAIELBI ODMLHODKOLD, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x775E0E0", Offset = "0x775D4E0", VA = "0x18775E0E0")]
	[AsyncStateMachine(typeof(FNDCFJIMJPN))]
	private Task MHFCPGNMKAA(COFODAIELBI ODMLHODKOLD, IEnumerable<PersistenceView> MBBEFFKJFGO, StringBuilder CNJMCPMBDII, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x775D9D0", Offset = "0x775CDD0", VA = "0x18775D9D0")]
	private BIPJJKGGCNE GMFABIGCKFF(long DLGNECIGKLC, CDGJEEKFCOI KAKFCKOFOOK, COFODAIELBI ODMLHODKOLD, IEnumerable<PersistenceView> MBBEFFKJFGO, StringBuilder CNJMCPMBDII)
	{
		return default(BIPJJKGGCNE);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x775DF90", Offset = "0x775D390", VA = "0x18775DF90")]
	private HGOBDFLLNNB HBIIJEPPFCI(long DLGNECIGKLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x775E6B0", Offset = "0x775DAB0", VA = "0x18775E6B0")]
	private void OOPLOKJEGEM(HGOBDFLLNNB PGBNBAHJDBK, StringBuilder CNJMCPMBDII, IEnumerable<PersistenceView> MBBEFFKJFGO, [In] BCCIAMCEKPO CHCGJBFGHLH, DKMGPMPCBCG PJBKIDLPJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x775E220", Offset = "0x775D620", VA = "0x18775E220")]
	private void NJCDBDACBBB(HGOBDFLLNNB PGBNBAHJDBK, StringBuilder CNJMCPMBDII, PersistenceView CICGDGCLMFK, DKMGPMPCBCG PJBKIDLPJPJ, [In] BCCIAMCEKPO CHCGJBFGHLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal class ENILGKKBBJD : FFHKMDJJEOM
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class AGLLHIOHGNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public PEPHOBCFPJA.IALAPHHGNMM roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public AGLLHIOHGNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x7751B60", Offset = "0x7750F60", VA = "0x187751B60")]
		internal object HMACFEFGENA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct KPAEOAACNOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public AsyncTaskMethodBuilder<(PEPHOBCFPJA.IALAPHHGNMM roomDataUpload, PEPHOBCFPJA.IALAPHHGNMM subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public BIPJJKGGCNE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public ENILGKKBBJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private AGLLHIOHGNC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private TaskAwaiter<PEPHOBCFPJA.IALAPHHGNMM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x77623A0", Offset = "0x77617A0", VA = "0x1877623A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x7762C00", Offset = "0x7762000", VA = "0x187762C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct MCKALIHFGIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public AsyncTaskMethodBuilder<GCEMIOFDIKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public ENILGKKBBJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public BIPJJKGGCNE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public AFDCCJMMFPI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private TaskAwaiter<(PEPHOBCFPJA.IALAPHHGNMM roomDataUpload, PEPHOBCFPJA.IALAPHHGNMM subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private TaskAwaiter<GCEMIOFDIKP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x7763BC0", Offset = "0x7762FC0", VA = "0x187763BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x7764250", Offset = "0x7763650", VA = "0x187764250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private struct IGLOPAAMFDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public AsyncTaskMethodBuilder<CDLAJKKPEIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public ENILGKKBBJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public BIPJJKGGCNE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private TaskAwaiter<(PEPHOBCFPJA.IALAPHHGNMM roomDataUpload, PEPHOBCFPJA.IALAPHHGNMM subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private TaskAwaiter<CDLAJKKPEIP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x775E9C0", Offset = "0x775DDC0", VA = "0x18775E9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x775EDD0", Offset = "0x775E1D0", VA = "0x18775EDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class CNDPOGBELCD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018D")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			public AsyncTaskMethodBuilder<CCONCDOKPJO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			public CNDPOGBELCD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			private CCONCDOKPJO <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006CC")]
			private TaskAwaiter<CDLAJKKPEIP> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006CD")]
			private TaskAwaiter<GCEMIOFDIKP> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006CE")]
			private TaskAwaiter<CCONCDOKPJO> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0x7769F10", Offset = "0x7769310", VA = "0x187769F10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x776AF00", Offset = "0x776A300", VA = "0x18776AF00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public ENILGKKBBJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public BIPJJKGGCNE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public AFDCCJMMFPI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public HKHNPHNDIJN roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public CNDPOGBELCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x77568D0", Offset = "0x7755CD0", VA = "0x1877568D0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<CCONCDOKPJO> BHFNNFAKHCA(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct ENEBMOKIDLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public AsyncTaskMethodBuilder<CCONCDOKPJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public ENILGKKBBJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public BIPJJKGGCNE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public AFDCCJMMFPI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public HKHNPHNDIJN roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		public LOALKKNJJLG<string>.HAPJMIAELKE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private TaskAwaiter<CCONCDOKPJO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x77588E0", Offset = "0x7757CE0", VA = "0x1877588E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x7758BF0", Offset = "0x7757FF0", VA = "0x187758BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private static readonly GKOKEEMOOFG PAELLOBOLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private readonly CPKFCHFLOKG GPCFMPGNCDE;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private FGMEGFCAHOO ECFALHAGKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x77393F0", Offset = "0x77387F0", VA = "0x1877393F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x77592B0", Offset = "0x77586B0", VA = "0x1877592B0")]
	public ENILGKKBBJD(FJBKMLGOLKO NDIKCIPCMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x7758DD0", Offset = "0x77581D0", VA = "0x187758DD0")]
	[AsyncStateMachine(typeof(KPAEOAACNOG))]
	private Task<(PEPHOBCFPJA.IALAPHHGNMM, PEPHOBCFPJA.IALAPHHGNMM)> GGADEKBGDGB(BIPJJKGGCNE MOCEEFBBOOH, long GGLEGKBAGLC, long LPKNEPKMMOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x7758F10", Offset = "0x7758310", VA = "0x187758F10")]
	[AsyncStateMachine(typeof(MCKALIHFGIA))]
	public Task<GCEMIOFDIKP> MIPOIFOMMIA(int ELEAAIEFPFE, [CanBeNull] AFDCCJMMFPI OIOCKBBMOLC, BIPJJKGGCNE MOCEEFBBOOH, long GGLEGKBAGLC, long LPKNEPKMMOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x7758C60", Offset = "0x7758060", VA = "0x187758C60")]
	[AsyncStateMachine(typeof(IGLOPAAMFDL))]
	private Task<CDLAJKKPEIP> AAPKKPGIDBL(string MEHAKHCKJPP, int ELEAAIEFPFE, BIPJJKGGCNE MOCEEFBBOOH, long GGLEGKBAGLC, long LPKNEPKMMOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x7759080", Offset = "0x7758480", VA = "0x187759080")]
	[AsyncStateMachine(typeof(ENEBMOKIDLD))]
	public Task<CCONCDOKPJO> NAGHPHKNIBE(int ELEAAIEFPFE, AFDCCJMMFPI? OIOCKBBMOLC, BIPJJKGGCNE MOCEEFBBOOH, long GGLEGKBAGLC, long LPKNEPKMMOO, HKHNPHNDIJN LGDDOKOLPPN, LOALKKNJJLG<string>.HAPJMIAELKE DFAMJNJLPDN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public abstract class NPICOCKPFFA<T> where T : NPICOCKPFFA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	internal readonly FGMEGFCAHOO JHOHIIMKMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private int? JNAJMHABOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	protected readonly Guid FINDPKDPGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	protected readonly AMGJKMNLMLJ BPJAGLIBGPK;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	protected T OPOCHAFMDDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x4A9F450", Offset = "0x4A9E850", VA = "0x184A9F450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x4A9F550", Offset = "0x4A9E950", VA = "0x184A9F550")]
	internal NPICOCKPFFA(FGMEGFCAHOO EOGOOCLJKGI, AMGJKMNLMLJ HPBFPGBNKMH, [Optional] Guid? NDFJMJHNPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x4A9F240", Offset = "0x4A9E640", VA = "0x184A9F240")]
	private CCONCDOKPJO CICCOANCMML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "4")]
	protected virtual void JCLNHGHDIBH(CCONCDOKPJO LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x4A9F4B0", Offset = "0x4A9E8B0", VA = "0x184A9F4B0")]
	public T NBDEFJENJKK(GHBEGPNJJCK JHJHBOANJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x4A9F190", Offset = "0x4A9E590", VA = "0x184A9F190")]
	public T BHOIHCFIAND(int DBIHCECPIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x4A9F320", Offset = "0x4A9E720", VA = "0x184A9F320", Slot = "5")]
	public virtual Task<BMNBHAPJIMJ> HBAFPFHPHIB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class CKPLJOINKGK : NPICOCKPFFA<CKPLJOINKGK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private FPMKMFBIMPJ PBJNGGAILNG;

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x776D4A0", Offset = "0x776C8A0", VA = "0x18776D4A0")]
	internal CKPLJOINKGK(FGMEGFCAHOO EOGOOCLJKGI, AMGJKMNLMLJ HPBFPGBNKMH, [Optional] Guid? NDFJMJHNPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x6BA0D20", Offset = "0x6BA0120", VA = "0x186BA0D20")]
	public CKPLJOINKGK CEAANMFNPME(FPMKMFBIMPJ PBJNGGAILNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x776D3D0", Offset = "0x776C7D0", VA = "0x18776D3D0", Slot = "4")]
	protected override void JCLNHGHDIBH(CCONCDOKPJO LNICHECHJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public class GHFPLKGHBEI : NPICOCKPFFA<GHFPLKGHBEI>
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	internal enum BNOKBLOINIH
	{
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct KIEBMIODFBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public AsyncTaskMethodBuilder<BMNBHAPJIMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public GHFPLKGHBEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private TaskAwaiter<BMNBHAPJIMJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x776FB40", Offset = "0x776EF40", VA = "0x18776FB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x776FEE0", Offset = "0x776F2E0", VA = "0x18776FEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private BNOKBLOINIH AAFHBKBBCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private string LEFIEIEDLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006E2")]
	private AFDCCJMMFPI PBJNGGAILNG;

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x776EE60", Offset = "0x776E260", VA = "0x18776EE60")]
	internal GHFPLKGHBEI(FGMEGFCAHOO EOGOOCLJKGI, AMGJKMNLMLJ HPBFPGBNKMH, [Optional] Guid? NDFJMJHNPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x776EE10", Offset = "0x776E210", VA = "0x18776EE10")]
	public GHFPLKGHBEI JLAJFNFBNDF(string JADMIFIBKFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x776EB90", Offset = "0x776DF90", VA = "0x18776EB90")]
	public GHFPLKGHBEI FFIANHOJBNC(bool MFGDCFCCOJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x776EE40", Offset = "0x776E240", VA = "0x18776EE40")]
	public GHFPLKGHBEI KGKDPLABEKC(bool FAKBPKMMDAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x776EB60", Offset = "0x776DF60", VA = "0x18776EB60")]
	public GHFPLKGHBEI DEEPMKBIGBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x776ECA0", Offset = "0x776E0A0", VA = "0x18776ECA0", Slot = "4")]
	protected override void JCLNHGHDIBH(CCONCDOKPJO LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x776EBB0", Offset = "0x776DFB0", VA = "0x18776EBB0", Slot = "5")]
	[AsyncStateMachine(typeof(KIEBMIODFBA))]
	public override Task<BMNBHAPJIMJ> HBAFPFHPHIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x776EB20", Offset = "0x776DF20", VA = "0x18776EB20")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<BMNBHAPJIMJ> DBEJCFBLPAG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
internal static class POBLJPCECCF
{
	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x7771C80", Offset = "0x7771080", VA = "0x187771C80")]
	public static void MICJFLEJFML(this GJHHDDAHPMJ LKNKDHCENAE, OPCCMKNHDBC GICKIOGCEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x7771DD0", Offset = "0x77711D0", VA = "0x187771DD0")]
	public static void OBGNBAFBJHG(this OPCCMKNHDBC PDGAIGHKDCM, [Optional] string LNICHECHJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public static class NGLMJNMAHDF
{
	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x77708B0", Offset = "0x776FCB0", VA = "0x1877708B0")]
	public static OAOEDECEGIP FEPJBNMGKJF(this BKECNJFBBNP MEAJHGHCODC)
	{
		return default(OAOEDECEGIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x7770950", Offset = "0x776FD50", VA = "0x187770950")]
	public static BKECNJFBBNP HPKDFCCBFDB(this OAOEDECEGIP NNNPMKHAAAI)
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
			[Cpp2IlInjected.Token(Token = "0x40006EF")]
			public NMIBGAKAKKA ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006F0")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006F1")]
			public NMIBGAKAKKA HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006F2")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006F3")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006F4")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private static NMIBGAKAKKA[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		private Dictionary<NMIBGAKAKKA, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x77720B0", Offset = "0x77714B0", VA = "0x1877720B0")]
		public bool EONBEJKOBIL(NMIBGAKAKKA IPBIFNNEPHN, [Out] ResultConfig JAGODFHKNAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x7772120", Offset = "0x7771520", VA = "0x187772120")]
		public ResultConfig KLBLNOEPDEG(NMIBGAKAKKA OCIFOIBHPJJ, [Optional] HashSet<NMIBGAKAKKA> MPFLPGAADLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x7772810", Offset = "0x7771C10", VA = "0x187772810", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x7772260", Offset = "0x7771660", VA = "0x187772260", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x962010", Offset = "0x961410", VA = "0x180962010")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class PGENAJEEHOJ : JHJPFICBPAM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct FFCMANNKBHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public PGENAJEEHOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public LOALKKNJJLG<string>.HAPJMIAELKE timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x776E510", Offset = "0x776D910", VA = "0x18776E510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x776E7A0", Offset = "0x776DBA0", VA = "0x18776E7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct ILIACEPEBBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public LOALKKNJJLG<string>.HAPJMIAELKE timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public JHJPFICBPAM preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		private LOALKKNJJLG<string>.HAPJMIAELKE <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x776EFD0", Offset = "0x776E3D0", VA = "0x18776EFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x776F4E0", Offset = "0x776E8E0", VA = "0x18776F4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006FA")]
	private readonly DMNFKLINNHI JPLCIGIMNDG;

	[Cpp2IlInjected.Token(Token = "0x40006FB")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public string LGLEHLGEEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x7771A60", Offset = "0x7770E60", VA = "0x187771A60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x7771A90", Offset = "0x7770E90", VA = "0x187771A90")]
	[AGCFNMIICNN.OGAOPBBDHOG.CHABDOHBNJI]
	internal static void FAMCDKJJNOL(CGJHFFGEHKC AEBJKCFPLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	[RecRoom.NoEngine.Common.Preserve]
	public PGENAJEEHOJ([CNGCCDLPGOD(null)] DMNFKLINNHI JPLCIGIMNDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x7771B00", Offset = "0x7770F00", VA = "0x187771B00", Slot = "5")]
	[AsyncStateMachine(typeof(FFCMANNKBHP))]
	public Task PKMNDLFOFHF(LOALKKNJJLG<string>.HAPJMIAELKE MKFIMMFPBBA, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x7771940", Offset = "0x7770D40", VA = "0x187771940")]
	[AsyncStateMachine(typeof(ILIACEPEBBL))]
	private Task CPEJOIEOJON(JHJPFICBPAM EJAPPCPFCEL, LOALKKNJJLG<string>.HAPJMIAELKE MKFIMMFPBBA, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public interface DMNFKLINNHI : JHJPFICBPAM
{
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public interface JHJPFICBPAM
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	string LGLEHLGEEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PKMNDLFOFHF(LOALKKNJJLG<string>.HAPJMIAELKE MKFIMMFPBBA, CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public static class NMDIGDCLFBJ
{
	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x7771530", Offset = "0x7770930", VA = "0x187771530")]
	[AGCFNMIICNN.OGAOPBBDHOG.CHABDOHBNJI]
	internal static void BMOABOOGHNH(CGJHFFGEHKC AEBJKCFPLND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public interface OGAHHHAJHDC : IEquatable<OGAHHHAJHDC>
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	DateTime OKMPJKIHJOK
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HPCOKLBOPJG();

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FHBKBMIDMEK(long GGLEGKBAGLC, long DLGNECIGKLC, [Out] BIPJJKGGCNE MOCEEFBBOOH);
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal class EHNHKLGHPKN : FGFDBJOOGKL
{
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private sealed class BDNKBJIPIPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public BFBICLDJJAD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public BDNKBJIPIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x776B500", Offset = "0x776A900", VA = "0x18776B500")]
		internal object ABGOAOIMHAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private readonly JIFAIFLOBBO BMGFKNHLFGN;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<OGAHHHAJHDC> KPMEDLKCGDN
	{
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x776D650", Offset = "0x776CA50", VA = "0x18776D650", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x776DD10", Offset = "0x776D110", VA = "0x18776DD10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	[UnityEngine.Scripting.Preserve]
	public EHNHKLGHPKN([CNGCCDLPGOD(null)] JIFAIFLOBBO BMGFKNHLFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x776D700", Offset = "0x776CB00", VA = "0x18776D700", Slot = "6")]
	public bool KBHJNMEEJKI(long GGLEGKBAGLC, long DLGNECIGKLC, BIPJJKGGCNE MOCEEFBBOOH, BFBICLDJJAD ODJFJIBMPIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x9DC4F0", Offset = "0x9DB8F0", VA = "0x1809DC4F0")]
	private void CPOJONHENEK(OGAHHHAJHDC CKMDEKPOFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x776D9E0", Offset = "0x776CDE0", VA = "0x18776D9E0", Slot = "7")]
	public bool KDBKNLIGEHI(long GGLEGKBAGLC, long DLGNECIGKLC, [Out] OGAHHHAJHDC KGCIEMPDBFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x776DC60", Offset = "0x776D060", VA = "0x18776DC60", Slot = "8")]
	public bool LFOFDLKAPDM(long GGLEGKBAGLC, long DLGNECIGKLC, BFBICLDJJAD ODJFJIBMPIO, [Out] OGAHHHAJHDC KGCIEMPDBFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x776DDC0", Offset = "0x776D1C0", VA = "0x18776DDC0")]
	private void NEBJGCKPIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x776DB50", Offset = "0x776CF50", VA = "0x18776DB50", Slot = "9")]
	public void LEOEJLDOMCM(long GGLEGKBAGLC, long DLGNECIGKLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal abstract class BHMBIIHLHIK : JIFAIFLOBBO
{
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	protected enum LDNAKEAPKMN : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class FBDFOJNFOHB : IEnumerable<OGAHHHAJHDC>, IEnumerable, IEnumerator<OGAHHHAJHDC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private OGAHHHAJHDC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public BHMBIIHLHIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		private BFBICLDJJAD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public BFBICLDJJAD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		private OGAHHHAJHDC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xADC3A0", Offset = "0xADB7A0", VA = "0x180ADC3A0")]
		[DebuggerHidden]
		public FBDFOJNFOHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x776E1E0", Offset = "0x776D5E0", VA = "0x18776E1E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x776E4C0", Offset = "0x776D8C0", VA = "0x18776E4C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x776E410", Offset = "0x776D810", VA = "0x18776E410", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OGAHHHAJHDC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x776E410", Offset = "0x776D810", VA = "0x18776E410", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private sealed class LGMFFFMBOAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public BFBICLDJJAD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public LGMFFFMBOAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x776FF50", Offset = "0x776F350", VA = "0x18776FF50")]
		internal object AOJGFCJLCDE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class CMAPEDFAEIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public BHMBIIHLHIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public CMAPEDFAEIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x776D5D0", Offset = "0x776C9D0", VA = "0x18776D5D0")]
		internal void NGLBKMOJDNC(KCKEBEEJOPL.AECHHODHHLF ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400070F")]
	private readonly object ACAKHIABEAH;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	protected string CCDPOMICMBC
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x776D340", Offset = "0x776C740", VA = "0x18776D340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public abstract HGCEKPALOLE BKKIJFLOAHM
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x776D350", Offset = "0x776C750", VA = "0x18776D350")]
	protected BHMBIIHLHIK([CanBeNull] string BKJCIHCEMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x776D0F0", Offset = "0x776C4F0", VA = "0x18776D0F0", Slot = "5")]
	public bool LLINKCNBFFL(long GGLEGKBAGLC, long DLGNECIGKLC, BFBICLDJJAD ODJFJIBMPIO, [Out] OGAHHHAJHDC CKMDEKPOFMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x776CCB0", Offset = "0x776C0B0", VA = "0x18776CCB0", Slot = "6")]
	[IteratorStateMachine(typeof(FBDFOJNFOHB))]
	public IEnumerable<OGAHHHAJHDC> GNJFHCACKMA(BFBICLDJJAD ODJFJIBMPIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void FPBGBMHJPLH(Stream BMOEFCLCDKH, long GGLEGKBAGLC, long DLGNECIGKLC, BIPJJKGGCNE MOCEEFBBOOH);

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool KEDBINAEMDG(Stream JPALMOOBDAP, long GGLEGKBAGLC, long DLGNECIGKLC, AMCPIMCBJDA GIPNOJDJBKI, [Out] BIPJJKGGCNE MOCEEFBBOOH);

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x776C940", Offset = "0x776BD40", VA = "0x18776C940", Slot = "7")]
	public OGAHHHAJHDC EAEIJLNFFBH(long GGLEGKBAGLC, long DLGNECIGKLC, BIPJJKGGCNE MOCEEFBBOOH, BFBICLDJJAD ODJFJIBMPIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo FGOIIFFNPFH(long GGLEGKBAGLC, long DLGNECIGKLC, BFBICLDJJAD ODJFJIBMPIO, LDNAKEAPKMN PJFJMHACMJI);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo DBEIONFNHCP(BFBICLDJJAD ODJFJIBMPIO, LDNAKEAPKMN PJFJMHACMJI);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x776D2D0", Offset = "0x776C6D0", VA = "0x18776D2D0")]
	protected void LOIPGONMJCO(KCKEBEEJOPL.AECHHODHHLF ALEAHMGGDEP, string GOICOPEBMAL, FileInfo AGKGFCCJBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x776CD40", Offset = "0x776C140", VA = "0x18776CD40")]
	internal bool HCIJMHKFMJH(FileInfo MCAEKOBCPEF, long GGLEGKBAGLC, long DLGNECIGKLC, [Out] BIPJJKGGCNE MOCEEFBBOOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
	private void PJCOFHIDDHO(Exception ANOAFKDKLKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal class NHOBHMDGEPF : BHMBIIHLHIK
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public override HGCEKPALOLE BKKIJFLOAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x17AD340", Offset = "0x17AC740", VA = "0x1817AD340", Slot = "8")]
		get
		{
			return default(HGCEKPALOLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x77714F0", Offset = "0x77708F0", VA = "0x1877714F0")]
	public NHOBHMDGEPF([Optional] string BKJCIHCEMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x7770B00", Offset = "0x776FF00", VA = "0x187770B00")]
	private void EJOKBBHJLNC(BFBICLDJJAD ODJFJIBMPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x7770C70", Offset = "0x7770070", VA = "0x187770C70", Slot = "9")]
	internal override void FPBGBMHJPLH(Stream BMOEFCLCDKH, long GGLEGKBAGLC, long DLGNECIGKLC, BIPJJKGGCNE MOCEEFBBOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x7770F00", Offset = "0x7770300", VA = "0x187770F00", Slot = "10")]
	internal override bool KEDBINAEMDG(Stream JPALMOOBDAP, long GGLEGKBAGLC, long DLGNECIGKLC, AMCPIMCBJDA GIPNOJDJBKI, [Out] BIPJJKGGCNE MOCEEFBBOOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x7770B80", Offset = "0x776FF80", VA = "0x187770B80", Slot = "11")]
	protected override FileInfo FGOIIFFNPFH(long GGLEGKBAGLC, long DLGNECIGKLC, BFBICLDJJAD ODJFJIBMPIO, LDNAKEAPKMN PJFJMHACMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x7770A00", Offset = "0x776FE00", VA = "0x187770A00", Slot = "12")]
	protected override DirectoryInfo DBEIONFNHCP(BFBICLDJJAD ODJFJIBMPIO, LDNAKEAPKMN PJFJMHACMJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal sealed class BFGDDLKLBLL : BHMBIIHLHIK
{
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	private static readonly byte[] LDCKBFKFIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private readonly byte[] AIGNPNNDENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000721")]
	private readonly byte[] JDKJGOIAEFG;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public override HGCEKPALOLE BKKIJFLOAHM
	{
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x64288D0", Offset = "0x6427CD0", VA = "0x1864288D0", Slot = "8")]
		get
		{
			return default(HGCEKPALOLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x776C850", Offset = "0x776BC50", VA = "0x18776C850")]
	public BFGDDLKLBLL([Optional] string BKJCIHCEMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x776BC70", Offset = "0x776B070", VA = "0x18776BC70", Slot = "9")]
	internal override void FPBGBMHJPLH(Stream BMOEFCLCDKH, long GGLEGKBAGLC, long DLGNECIGKLC, BIPJJKGGCNE MOCEEFBBOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x776BFE0", Offset = "0x776B3E0", VA = "0x18776BFE0", Slot = "10")]
	internal override bool KEDBINAEMDG(Stream JPALMOOBDAP, long GGLEGKBAGLC, long DLGNECIGKLC, AMCPIMCBJDA GIPNOJDJBKI, [Out] BIPJJKGGCNE MOCEEFBBOOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x776BF20", Offset = "0x776B320", VA = "0x18776BF20")]
	private void HJFECPMCHDC(byte[] MDABPMPEKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x776BB40", Offset = "0x776AF40", VA = "0x18776BB40", Slot = "11")]
	protected override FileInfo FGOIIFFNPFH(long GGLEGKBAGLC, long DLGNECIGKLC, BFBICLDJJAD ODJFJIBMPIO, LDNAKEAPKMN PJFJMHACMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x776BA30", Offset = "0x776AE30", VA = "0x18776BA30", Slot = "12")]
	protected override DirectoryInfo DBEIONFNHCP(BFBICLDJJAD ODJFJIBMPIO, LDNAKEAPKMN PJFJMHACMJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public enum HGCEKPALOLE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000723")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000725")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal class LMBOBNLJBEC : JIFAIFLOBBO
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class BEBIBEOLCJB : IEnumerable<OGAHHHAJHDC>, IEnumerable, IEnumerator<OGAHHHAJHDC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private OGAHHHAJHDC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public LMBOBNLJBEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		private BFBICLDJJAD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public BFBICLDJJAD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		private HGCEKPALOLE[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private IEnumerator<OGAHHHAJHDC> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		private OGAHHHAJHDC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xADC3A0", Offset = "0xADB7A0", VA = "0x180ADC3A0")]
		[DebuggerHidden]
		public BEBIBEOLCJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x776B9A0", Offset = "0x776ADA0", VA = "0x18776B9A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x776B570", Offset = "0x776A970", VA = "0x18776B570", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x776B850", Offset = "0x776AC50", VA = "0x18776B850")]
		private void NOLPLDAPGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x776B950", Offset = "0x776AD50", VA = "0x18776B950", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x776B8A0", Offset = "0x776ACA0", VA = "0x18776B8A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OGAHHHAJHDC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x776B8A0", Offset = "0x776ACA0", VA = "0x18776B8A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	private readonly HGCEKPALOLE[] BGIMCDPKCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	private readonly Dictionary<HGCEKPALOLE, JIFAIFLOBBO> NGDOOPFLPJP;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public HGCEKPALOLE BKKIJFLOAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x7770550", Offset = "0x776F950", VA = "0x187770550", Slot = "4")]
		get
		{
			return default(HGCEKPALOLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x7770580", Offset = "0x776F980", VA = "0x187770580")]
	[UnityEngine.Scripting.Preserve]
	public LMBOBNLJBEC(params JIFAIFLOBBO[] GIAEOHEMBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x7770400", Offset = "0x776F800", VA = "0x187770400", Slot = "5")]
	public bool LLINKCNBFFL(long GGLEGKBAGLC, long DLGNECIGKLC, BFBICLDJJAD ODJFJIBMPIO, [Out] OGAHHHAJHDC CKMDEKPOFMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x776FFF0", Offset = "0x776F3F0", VA = "0x18776FFF0")]
	private void BAEBMIEKFPK(int LLNLMANNFAD, long GGLEGKBAGLC, long DLGNECIGKLC, BFBICLDJJAD ODJFJIBMPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x7770370", Offset = "0x776F770", VA = "0x187770370", Slot = "6")]
	[IteratorStateMachine(typeof(BEBIBEOLCJB))]
	public IEnumerable<OGAHHHAJHDC> GNJFHCACKMA(BFBICLDJJAD ODJFJIBMPIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x7770220", Offset = "0x776F620", VA = "0x187770220", Slot = "7")]
	public OGAHHHAJHDC EAEIJLNFFBH(long GGLEGKBAGLC, long DLGNECIGKLC, BIPJJKGGCNE MOCEEFBBOOH, BFBICLDJJAD ODJFJIBMPIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class FNCDHIJJHLO
{
	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x776EA60", Offset = "0x776DE60", VA = "0x18776EA60")]
	internal static byte[] HMPNJNIHMEB(byte[] MDABPMPEKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x776E800", Offset = "0x776DC00", VA = "0x18776E800")]
	public static void EBFOEENNKAG(Stream CLFCADGNELJ, byte[] ACGMDEMIHCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x776E880", Offset = "0x776DC80", VA = "0x18776E880")]
	public static bool GADALKILAIN(Stream CLFCADGNELJ, long FDPMOPFKMKC, AMCPIMCBJDA MGDPBJEODDA, [Out] byte[] CLCHIBNNAJC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
internal sealed class IPGHIDAIKCF : OGAHHHAJHDC, IEquatable<OGAHHHAJHDC>, IEquatable<IPGHIDAIKCF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000735")]
	private readonly BHMBIIHLHIK EGCEAFILDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000736")]
	public readonly FileInfo LNCDKONJPOM;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public HGCEKPALOLE BKKIJFLOAHM
	{
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x70EA100", Offset = "0x70E9500", VA = "0x1870EA100", Slot = "9")]
		get
		{
			return default(HGCEKPALOLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public DateTime OKMPJKIHJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x776F8F0", Offset = "0x776ECF0", VA = "0x18776F8F0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x776FA30", Offset = "0x776EE30", VA = "0x18776FA30")]
	public IPGHIDAIKCF(BHMBIIHLHIK FJOKJJMHHBG, FileInfo MCAEKOBCPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x776F980", Offset = "0x776ED80", VA = "0x18776F980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x776F830", Offset = "0x776EC30", VA = "0x18776F830", Slot = "5")]
	public void HPCOKLBOPJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x776F760", Offset = "0x776EB60", VA = "0x18776F760", Slot = "6")]
	public bool FHBKBMIDMEK(long GGLEGKBAGLC, long DLGNECIGKLC, [Out] BIPJJKGGCNE MOCEEFBBOOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x776F600", Offset = "0x776EA00", VA = "0x18776F600", Slot = "7")]
	public bool Equals(OGAHHHAJHDC BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x776F540", Offset = "0x776E940", VA = "0x18776F540", Slot = "8")]
	public bool Equals(IPGHIDAIKCF BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x776F670", Offset = "0x776EA70", VA = "0x18776F670", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x776F7A0", Offset = "0x776EBA0", VA = "0x18776F7A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public delegate void AMCPIMCBJDA(KCKEBEEJOPL.AECHHODHHLF OEELEAMGDLH, string LNICHECHJFC);
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface JIFAIFLOBBO
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	HGCEKPALOLE BKKIJFLOAHM
	{
		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LLINKCNBFFL(long GGLEGKBAGLC, long DLGNECIGKLC, BFBICLDJJAD ODJFJIBMPIO, [Out] OGAHHHAJHDC CKMDEKPOFMF);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<OGAHHHAJHDC> GNJFHCACKMA(BFBICLDJJAD ODJFJIBMPIO);

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OGAHHHAJHDC EAEIJLNFFBH(long GGLEGKBAGLC, long DLGNECIGKLC, BIPJJKGGCNE MOCEEFBBOOH, BFBICLDJJAD ODJFJIBMPIO);
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
